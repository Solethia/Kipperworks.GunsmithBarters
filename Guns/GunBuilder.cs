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
    private GunPreset? _Aks74nDefault;
    private GunPreset? _Ak102Default;
    private GunPreset? _Ak105Default;
    private GunPreset? _AkmnDefault;
    private GunPreset? _KrissVector9x19Default;
    private GunPreset? _Hk416a5Default;
    private GunPreset? _AsValDefault;

    private string? _PathToModValue;

    private string _PathToMod
    {
        get
        {
            _PathToModValue ??= modHelper.GetAbsolutePathToModFolder(Assembly.GetExecutingAssembly());
            return _PathToModValue;
        }
    }

    private List<Item> LoadAndClonePresetItems(ref GunPreset? cache, string path)
    {
        if (cache is null)
        {
            cache = modHelper.GetJsonDataFromFile<GunPreset>(_PathToMod, path)
                ?? throw new InvalidOperationException($"Failed to load gun preset: {path}");
        }

        return cloner.Clone(cache.Items)
            ?? throw new InvalidOperationException($"Failed to clone items from gun preset: {path}");
    }

    public List<Item> GetAks74nDefault()
        => LoadAndClonePresetItems(ref _Aks74nDefault, "db/aks74nDefault.json");

    public List<Item> GetAk102Default()
        => LoadAndClonePresetItems(ref _Ak102Default, "db/ak102Default.json");

    public List<Item> GetAk105Default()
        => LoadAndClonePresetItems(ref _Ak105Default, "db/ak105Default.json");

    public List<Item> GetAkmnDefault()
        => LoadAndClonePresetItems(ref _AkmnDefault, "db/akmnDefault.json");

    public List<Item> GetKrissVector9x19Default()
        => LoadAndClonePresetItems(ref _KrissVector9x19Default, "db/krissVector9x19Default.json");

    public List<Item> GetHk416a5Default()
        => LoadAndClonePresetItems(ref _Hk416a5Default, "db/hk416a5Default.json");

    public List<Item> GetAsValDefault()
        => LoadAndClonePresetItems(ref _AsValDefault, "db/asValDefault.json");
}
