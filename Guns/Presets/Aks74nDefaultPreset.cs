using SPTarkov.Server.Core.Models.Eft.Common.Tables;

namespace Kipperworks.GunsmithBarters;

public static class Aks74nDefaultPreset
{
    public static GunPreset Create() => new()
    {
        Items =
        [
            new Item
            {
                Id = "67895e3ed549ac3dab0e7fbd",
                Template = "5ab8e9fcd8ce870019439434",
                Upd = new Upd
                {
                    Repairable = new UpdRepairable { MaxDurability = 100, Durability = 100 },
                    Foldable = new UpdFoldable { Folded = false },
                    FireMode = new UpdFireMode { FireMode = "single" }
                }
            },
            new Item
            {
                Id = "67895e3ed549ac3dab0e7fbe",
                Template = "59c6633186f7740cf0493bb9",
                SlotId = "mod_gas_block",
                ParentId = "67895e3ed549ac3dab0e7fbd"
            },
            new Item
            {
                Id = "67895e3ed549ac3dab0e7fbf",
                Template = "5649aa744bdc2ded0b8b457e",
                SlotId = "mod_muzzle",
                ParentId = "67895e3ed549ac3dab0e7fbd"
            },
            new Item
            {
                Id = "67895e3ed549ac3dab0e7fc0",
                Template = "57e3dba62459770f0c32322b",
                SlotId = "mod_pistol_grip",
                ParentId = "67895e3ed549ac3dab0e7fbd"
            },
            new Item
            {
                Id = "67895e3ed549ac3dab0e7fc1",
                Template = "5649af094bdc2df8348b4586",
                SlotId = "mod_reciever",
                ParentId = "67895e3ed549ac3dab0e7fbd"
            },
            new Item
            {
                Id = "67895e3ed549ac3dab0e7fc2",
                Template = "5649b0544bdc2d1b2b8b458a",
                SlotId = "mod_sight_rear",
                ParentId = "67895e3ed549ac3dab0e7fbd",
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
                Id = "67895e3ed549ac3dab0e7fc3",
                Template = "5ab626e4d8ce87272e4c6e43",
                SlotId = "mod_stock",
                ParentId = "67895e3ed549ac3dab0e7fbd"
            },
            new Item
            {
                Id = "67895e3ed549ac3dab0e7fc4",
                Template = "564ca99c4bdc2d16268b4589",
                SlotId = "mod_magazine",
                ParentId = "67895e3ed549ac3dab0e7fbd"
            },
            new Item
            {
                Id = "67895e3ed549ac3dab0e7fc5",
                Template = "5648b0744bdc2d363b8b4578",
                SlotId = "mod_handguard",
                ParentId = "67895e3ed549ac3dab0e7fbe"
            }
        ]
    };
}
