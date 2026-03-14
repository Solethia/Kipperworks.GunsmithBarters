using SPTarkov.DI.Annotations;
using SPTarkov.Server.Core.DI;
using SPTarkov.Server.Core.Helpers;
using SPTarkov.Server.Core.Models.Eft.Common.Tables;
using SPTarkov.Server.Core.Utils.Cloners;
using System.Reflection;

namespace Kipperworks.GunsmithBarters;

[Injectable(TypePriority = OnLoadOrder.PostDBModLoader + 1)]
public class GunBuilder(
    ModHelper modHelper,
    ICloner cloner)
{
    private GunPreset? _aks74nDefault;
    private GunPreset? _ak102Default;
    private GunPreset? _ak105Default;
    private GunPreset? _akmnDefault;
    private GunPreset? _krissVector9x19Default;
    private GunPreset? _hk416a5Default;
    private GunPreset? _asValDefault;

    private string? _pathToMod;

    private string PathToMod
    {
        get
        {
            _pathToMod ??= modHelper.GetAbsolutePathToModFolder(Assembly.GetExecutingAssembly());
            return _pathToMod;
        }
    }

    private List<Item> LoadAndClonePresetItems(ref GunPreset? cache, string path)
    {
        if (cache is null)
        {
            cache = modHelper.GetJsonDataFromFile<GunPreset>(PathToMod, path)
                ?? throw new InvalidOperationException($"Failed to load gun preset: {path}");
        }

        return cloner.Clone(cache.Items)
            ?? throw new InvalidOperationException($"Failed to clone items from gun preset: {path}");
    }

    public List<Item> GetAks74nDefault()
        => LoadAndClonePresetItems(ref _aks74nDefault, "db/aks74nDefault.json");

    public List<Item> GetAk102Default()
        => LoadAndClonePresetItems(ref _ak102Default, "db/ak102Default.json");

    public List<Item> GetAk105Default()
        => LoadAndClonePresetItems(ref _ak105Default, "db/ak105Default.json");

    public List<Item> GetAkmnDefault()
        => LoadAndClonePresetItems(ref _akmnDefault, "db/akmnDefault.json");

    public List<Item> GetKrissVector9x19Default()
        => LoadAndClonePresetItems(ref _krissVector9x19Default, "db/krissVector9x19Default.json");

    public List<Item> GetHk416a5Default()
        => LoadAndClonePresetItems(ref _hk416a5Default, "db/hk416a5Default.json");

    public List<Item> GetAsValDefault()
        => LoadAndClonePresetItems(ref _asValDefault, "db/asValDefault.json");
}
