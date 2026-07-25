using SPTarkov.Server.Core.Models.Eft.Common.Tables;

namespace Kipperworks.GunsmithBarters;

public static class Ak105DefaultPreset
{
    public static GunPreset Create() => new()
    {
        Items =
        [
            new Item
            {
                Id = "67895cbdd549ac3dab0e7f94",
                Template = "5ac66d9b5acfc4001633997a",
                Upd = new Upd
                {
                    Repairable = new UpdRepairable { MaxDurability = 100, Durability = 100 },
                    Foldable = new UpdFoldable { Folded = false },
                    FireMode = new UpdFireMode { FireMode = "single" }
                }
            },
            new Item
            {
                Id = "67895cbdd549ac3dab0e7f95",
                Template = "59c6633186f7740cf0493bb9",
                SlotId = "mod_gas_block",
                ParentId = "67895cbdd549ac3dab0e7f94"
            },
            new Item
            {
                Id = "67895cbdd549ac3dab0e7f96",
                Template = "5ac72e945acfc43f3b691116",
                SlotId = "mod_muzzle",
                ParentId = "67895cbdd549ac3dab0e7f94"
            },
            new Item
            {
                Id = "67895cbdd549ac3dab0e7f97",
                Template = "5649ade84bdc2d1b2b8b4587",
                SlotId = "mod_pistol_grip",
                ParentId = "67895cbdd549ac3dab0e7f94"
            },
            new Item
            {
                Id = "67895cbdd549ac3dab0e7f98",
                Template = "5ac50da15acfc4001718d287",
                SlotId = "mod_reciever",
                ParentId = "67895cbdd549ac3dab0e7f94"
            },
            new Item
            {
                Id = "67895cbdd549ac3dab0e7f99",
                Template = "5ac733a45acfc400192630e2",
                SlotId = "mod_sight_rear",
                ParentId = "67895cbdd549ac3dab0e7f94",
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
            },
            new Item
            {
                Id = "67895cbdd549ac3dab0e7f9a",
                Template = "5ac50c185acfc400163398d4",
                SlotId = "mod_stock",
                ParentId = "67895cbdd549ac3dab0e7f94"
            },
            new Item
            {
                Id = "67895cbdd549ac3dab0e7f9b",
                Template = "55d480c04bdc2d1d4e8b456a",
                SlotId = "mod_magazine",
                ParentId = "67895cbdd549ac3dab0e7f94"
            },
            new Item
            {
                Id = "67895cbdd549ac3dab0e7f9c",
                Template = "5648b1504bdc2d9d488b4584",
                SlotId = "mod_handguard",
                ParentId = "67895cbdd549ac3dab0e7f95"
            }
        ]
    };
}
