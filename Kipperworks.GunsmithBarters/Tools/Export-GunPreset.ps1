<#
.SYNOPSIS
	Extracts a gun preset from SPT globals.json and emits a ready-to-paste C# preset class. Probably is a easier way to do this, but I couldn't find one.

.PARAMETER GunTemplateId
	The template ID (_tpl) of the root gun item (e.g. "5a7ae0c351dfba0017554310" for Glock 17).

.PARAMETER ClassName
	The name of the C# class to generate (e.g. "Glock17DefaultPreset").

.PARAMETER GlobalsPath
	Path to globals.json. Defaults to GunbuilderItems\database\globals.json relative to script location.

.PARAMETER ItemsPath
	Path to items.json. Defaults to GunbuilderItems\database\templates\items.json relative to script location.

.EXAMPLE
	# Validation run against AKS-74N
	.\Export-GunPreset.ps1 -GunTemplateId "5ab8e9fcd8ce870019439434" -ClassName "Aks74nDefaultPresetTest"

	# Glock 17
	.\Export-GunPreset.ps1 -GunTemplateId "5a7ae0c351dfba0017554310" -ClassName "Glock17DefaultPreset"
#>
param(
	[Parameter(Mandatory)]
	[string]$GunTemplateId,

	[Parameter(Mandatory)]
	[string]$ClassName,

	[string]$GlobalsPath,
	[string]$ItemsPath
)

$repoRoot = Split-Path $PSScriptRoot -Parent

if (-not $GlobalsPath) {
	$GlobalsPath = Join-Path $repoRoot "GunbuilderItems\database\globals.json"
}
if (-not $ItemsPath) {
	$ItemsPath = Join-Path $repoRoot "GunbuilderItems\database\templates\items.json"
}

Write-Host "Loading globals.json..." -ForegroundColor Cyan
$globals = Get-Content $GlobalsPath -Raw | ConvertFrom-Json

Write-Host "Searching ItemPresets for gun template '$GunTemplateId'..." -ForegroundColor Cyan

$matchedPreset = $null
$matchedPresetId = $null

foreach ($prop in $globals.ItemPresets.PSObject.Properties) {
	$preset = $prop.Value
	$items = $preset._items
	if (-not $items) { continue }

	# Root item has no parentId
	$rootItem = $items | Where-Object { -not $_.parentId -or $_.parentId -eq "" } | Select-Object -First 1
	if ($rootItem -and $rootItem._tpl -eq $GunTemplateId) {
		$matchedPreset = $preset
		$matchedPresetId = $prop.Name
		break
	}
}

if (-not $matchedPreset) {
	Write-Error "No preset found with root item template '$GunTemplateId' in ItemPresets."
	exit 1
}

Write-Host "Found preset: $matchedPresetId ($($matchedPreset._name))" -ForegroundColor Green
Write-Host "Item count: $($matchedPreset._items.Count)" -ForegroundColor Green

# Check if gun is foldable by looking at items.json
Write-Host "Checking items.json for Foldable property on '$GunTemplateId'..." -ForegroundColor Cyan
$itemsJson = Get-Content $ItemsPath -Raw
$isFoldable = $itemsJson -match ('"' + $GunTemplateId + '"[\s\S]{0,3000}?"Foldable":\s*true')
Write-Host "Foldable: $isFoldable" -ForegroundColor $(if ($isFoldable) { "Yellow" } else { "Gray" })

# Generate fresh MongoIds (24-char hex)
function New-MongoId {
	$bytes = [System.Security.Cryptography.RandomNumberGenerator]::GetBytes(12)
	return [System.Convert]::ToHexString($bytes).ToLower()
}

# Build remap: old instance ID -> new MongoId
$idRemap = @{}
foreach ($item in $matchedPreset._items) {
	$idRemap[$item._id] = New-MongoId
}

# Helper: render a C# Item block
function Render-Item {
	param($item, $idRemap, $isRoot, $isFoldable)

	$newId     = $idRemap[$item._id]
	$tpl       = $item._tpl
	$slotId    = $item.slotId
	$parentId  = $item.parentId
	$newParent = if ($parentId) { $idRemap[$parentId] } else { $null }

	$needsUpd = $isRoot -or ($slotId -and $slotId -match "sight")

	# Build ordered list of (name, value) scalar properties; we decide commas last
	$props = [System.Collections.Generic.List[string]]::new()
	$props.Add("                Id = `"$newId`"")
	$props.Add("                Template = `"$tpl`"")
	if ($slotId)    { $props.Add("                SlotId = `"$slotId`"") }
	if ($newParent) { $props.Add("                ParentId = `"$newParent`"") }

	$lines = [System.Collections.Generic.List[string]]::new()
	$lines.Add("            new Item")
	$lines.Add("            {")

	# All scalar props need trailing commas — either followed by another prop or by Upd
	foreach ($p in $props) {
		$lines.Add("$p,")
	}

	if ($needsUpd) {
		$lines.Add("                Upd = new Upd")
		$lines.Add("                {")

		if ($isRoot) {
			$lines.Add("                    Repairable = new UpdRepairable { MaxDurability = 100, Durability = 100 },")
			if ($isFoldable) {
				$lines.Add("                    Foldable = new UpdFoldable { Folded = false },")
			}
			$lines.Add("                    FireMode = new UpdFireMode { FireMode = `"single`" }")
		} elseif ($slotId -match "sight") {
			$lines.Add("                    Sight = new UpdSight")
			$lines.Add("                    {")
			$lines.Add("                        ScopesCurrentCalibPointIndexes = [0],")
			$lines.Add("                        ScopesSelectedModes = [0],")
			$lines.Add("                        SelectedScope = 0,")
			$lines.Add("                        ScopeZoomValue = 0")
			$lines.Add("                    }")
		}

		$lines.Add("                }")
	} else {
		# No Upd block — last scalar prop should NOT have a trailing comma.
		# Remove the comma from the last line.
		$lastIdx = $lines.Count - 1
		$lines[$lastIdx] = $lines[$lastIdx] -replace ',$', ''
	}

	$lines.Add("            },")
	return $lines -join "`n"
}

# Build the C# output
$sb = [System.Text.StringBuilder]::new()
$null = $sb.AppendLine("using SPTarkov.Server.Core.Models.Eft.Common.Tables;")
$null = $sb.AppendLine("")
$null = $sb.AppendLine("namespace Kipperworks.GunsmithBarters;")
$null = $sb.AppendLine("")
$null = $sb.AppendLine("public static class $ClassName")
$null = $sb.AppendLine("{")
$null = $sb.AppendLine("    public static GunPreset Create() => new()")
$null = $sb.AppendLine("    {")
$null = $sb.AppendLine("        Items =")
$null = $sb.AppendLine("        [")

$items = $matchedPreset._items

# Root first, then children
$rootItem = $items | Where-Object { -not $_.parentId -or $_.parentId -eq "" } | Select-Object -First 1
$childItems = $items | Where-Object { $_.parentId -and $_.parentId -ne "" }

$rendered = Render-Item -item $rootItem -idRemap $idRemap -isRoot $true -isFoldable $isFoldable
$null = $sb.AppendLine($rendered)

foreach ($child in $childItems) {
	$rendered = Render-Item -item $child -idRemap $idRemap -isRoot $false -isFoldable $false
	$null = $sb.AppendLine($rendered)
}

$null = $sb.AppendLine("        ]")
$null = $sb.AppendLine("    };")
$null = $sb.AppendLine("}")

$output = $sb.ToString()
Write-Host ""
Write-Host "=== Generated C# ===" -ForegroundColor Green
Write-Host $output
