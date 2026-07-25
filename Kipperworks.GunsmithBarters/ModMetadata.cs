using SPTarkov.Server.Core.Models.Spt.Mod;

namespace Kipperworks.GunsmithBarters;

public record ModMetadata : AbstractModMetadata
{
    public override string ModGuid { get; init; } = "com.solethia.gunsmithbarters";
    public override string Name { get; init; } = "GunsmithBarters";
    public override string Author { get; init; } = "Solethia";
    public override List<string>? Contributors { get; init; }
    public override SemanticVersioning.Version Version { get; init; } = new(ModInfo.Version);
    public override SemanticVersioning.Range SptVersion { get; init; } = new("~4.0.0");
    public override List<string>? Incompatibilities { get; init; }
    public override Dictionary<string, SemanticVersioning.Range>? ModDependencies { get; init; }
    public override string? Url { get; init; } = "https://forge.sp-tarkov.com/mod/1963/gunsmith-barters";
    public override bool? IsBundleMod { get; init; } = false;
    public override string License { get; init; } = "MIT";
    
}
