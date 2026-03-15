using SPTarkov.Server.Core.Models.Eft.Common.Tables;

namespace Kipperworks.GunsmithBarters;

public static class AsValDefaultPreset
{
    public static GunPreset Create() => new()
    {
        Items =
        [
            new Item
            {
                Id = "67895eb3d549ac3dab0e7fce",
                Template = "57c44b372459772d2b39b8ce",
                Upd = new Upd
                {
                    Repairable = new UpdRepairable { MaxDurability = 100, Durability = 100 },
                    Foldable = new UpdFoldable { Folded = false },
                    FireMode = new UpdFireMode { FireMode = "single" }
                }
            },
            new Item
            {
                Id = "67895eb3d549ac3dab0e7fcf",
                Template = "57c44dd02459772d2e0ae249",
                SlotId = "mod_muzzle",
                ParentId = "67895eb3d549ac3dab0e7fce"
            },
            new Item
            {
                Id = "67895eb3d549ac3dab0e7fd0",
                Template = "57c44f4f2459772d2c627113",
                SlotId = "mod_reciever",
                ParentId = "67895eb3d549ac3dab0e7fce"
            },
            new Item
            {
                Id = "67895eb3d549ac3dab0e7fd1",
                Template = "57838f9f2459774a150289a0",
                SlotId = "mod_magazine",
                ParentId = "67895eb3d549ac3dab0e7fce"
            },
            new Item
            {
                Id = "67895eb3d549ac3dab0e7fd2",
                Template = "57c44fa82459772d2d75e415",
                SlotId = "mod_pistol_grip",
                ParentId = "67895eb3d549ac3dab0e7fce"
            },
            new Item
            {
                Id = "67895eb3d549ac3dab0e7fd3",
                Template = "57c450252459772d28133253",
                SlotId = "mod_stock",
                ParentId = "67895eb3d549ac3dab0e7fce"
            },
            new Item
            {
                Id = "67895eb3d549ac3dab0e7fd4",
                Template = "651178336cad06c37c049eb4",
                SlotId = "mod_handguard",
                ParentId = "67895eb3d549ac3dab0e7fce"
            },
            new Item
            {
                Id = "67895eb3d549ac3dab0e7fd5",
                Template = "57c44e7b2459772d28133248",
                SlotId = "mod_sight_rear",
                ParentId = "67895eb3d549ac3dab0e7fcf",
                Upd = new Upd
                {
                    Sight = new UpdSight
                    {
                        ScopesCurrentCalibPointIndexes = [0],
                        ScopesSelectedModes = [0],
                        SelectedScope = 0,
                        ScopeZoomValue = 0
                    }
                }
            }
        ]
    };
}
