using SPTarkov.DI.Annotations;
using SPTarkov.Server.Core.DI;
using SPTarkov.Server.Core.Models.Eft.Common.Tables;
using SPTarkov.Server.Core.Utils.Cloners;

namespace Kipperworks.GunsmithBarters;

[Injectable(TypePriority = OnLoadOrder.PostDBModLoader + 1)]
public class GunBuilder(ICloner cloner)
{
    private GunPreset? _Aks74nDefault;
    private GunPreset? _Ak102Default;
    private GunPreset? _Ak105Default;
    private GunPreset? _AkmnDefault;
    private GunPreset? _KrissVector9x19Default;
    private GunPreset? _Hk416a5Default;
    private GunPreset? _AsValDefault;

    private List<Item> GetOrClonePresetItems(ref GunPreset? cache, Func<GunPreset> factory)
    {
        cache ??= factory();

        return cloner.Clone(cache.Items)
            ?? throw new InvalidOperationException("Failed to clone items from gun preset");
    }

    public List<Item> GetAks74nDefault()
        => GetOrClonePresetItems(ref _Aks74nDefault, Aks74nDefaultPreset.Create);

    public List<Item> GetAk102Default()
        => GetOrClonePresetItems(ref _Ak102Default, Ak102DefaultPreset.Create);

    public List<Item> GetAk105Default()
        => GetOrClonePresetItems(ref _Ak105Default, Ak105DefaultPreset.Create);

    public List<Item> GetAkmnDefault()
        => GetOrClonePresetItems(ref _AkmnDefault, AkmnDefaultPreset.Create);

    public List<Item> GetKrissVector9x19Default()
        => GetOrClonePresetItems(ref _KrissVector9x19Default, KrissVector9x19DefaultPreset.Create);

    public List<Item> GetHk416a5Default()
        => GetOrClonePresetItems(ref _Hk416a5Default, Hk416a5DefaultPreset.Create);

    public List<Item> GetAsValDefault()
        => GetOrClonePresetItems(ref _AsValDefault, AsValDefaultPreset.Create);
}
