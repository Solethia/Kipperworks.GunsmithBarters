using SPTarkov.Server.Core.Models.Eft.Common.Tables;

namespace Kipperworks.GunsmithBarters;

public static class Ak102DefaultPreset
{
    public static GunPreset Create() => new()
    {
        Items =
        [
            new Item
            {
                Id = "67895bf8d549ac3dab0e7f8a",
                Template = "5ac66d015acfc400180ae6e4",
                Upd = new Upd
                {
                    Repairable = new UpdRepairable { MaxDurability = 100, Durability = 100 },
                    Foldable = new UpdFoldable { Folded = false },
                    FireMode = new UpdFireMode { FireMode = "single" }
                }
            },
            new Item
            {
                Id = "67895bf8d549ac3dab0e7f8b",
                Template = "59c6633186f7740cf0493bb9",
                SlotId = "mod_gas_block",
                ParentId = "67895bf8d549ac3dab0e7f8a"
            },
            new Item
            {
                Id = "67895bf8d549ac3dab0e7f8c",
                Template = "5ac72e725acfc400180ae701",
                SlotId = "mod_muzzle",
                ParentId = "67895bf8d549ac3dab0e7f8a"
            },
            new Item
            {
                Id = "67895bf8d549ac3dab0e7f8d",
                Template = "5649ade84bdc2d1b2b8b4587",
                SlotId = "mod_pistol_grip",
                ParentId = "67895bf8d549ac3dab0e7f8a"
            },
            new Item
            {
                Id = "67895bf8d549ac3dab0e7f8e",
                Template = "5ac50da15acfc4001718d287",
                SlotId = "mod_reciever",
                ParentId = "67895bf8d549ac3dab0e7f8a"
            },
            new Item
            {
                Id = "67895bf8d549ac3dab0e7f8f",
                Template = "5ac733a45acfc400192630e2",
                SlotId = "mod_sight_rear",
                ParentId = "67895bf8d549ac3dab0e7f8a",
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
                Id = "67895bf8d549ac3dab0e7f80",
                Template = "5ac50c185acfc400163398d4",
                SlotId = "mod_stock",
                ParentId = "67895bf8d549ac3dab0e7f8a"
            },
            new Item
            {
                Id = "67895bf8d549ac3dab0e7f81",
                Template = "5ac66c5d5acfc4001718d314",
                SlotId = "mod_magazine",
                ParentId = "67895bf8d549ac3dab0e7f8a"
            },
            new Item
            {
                Id = "67895bf8d549ac3dab0e7f82",
                Template = "5648b1504bdc2d9d488b4584",
                SlotId = "mod_handguard",
                ParentId = "67895bf8d549ac3dab0e7f8b"
            }
        ]
    };
}
