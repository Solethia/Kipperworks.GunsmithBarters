using SPTarkov.Server.Core.Models.Eft.Common.Tables;

namespace Kipperworks.GunsmithBarters;

public static class Hk416a5DefaultPreset
{
    public static GunPreset Create() => new()
    {
        Items =
        [
            new Item
            {
                Id = "67895f1bd549ac3dab0e83de",
                Template = "5bb2475ed4351e00853264e3",
                Upd = new Upd
                {
                    Repairable = new UpdRepairable { MaxDurability = 100, Durability = 100 },
                    FireMode = new UpdFireMode { FireMode = "single" }
                }
            },
            new Item
            {
                Id = "67895f1bd549ac3dab0e83df",
                Template = "5bb20e0ed4351e3bac1212dc",
                SlotId = "mod_pistol_grip",
                ParentId = "67895f1bd549ac3dab0e83de"
            },
            new Item
            {
                Id = "67895f1bd549ac3dab0e83e0",
                Template = "5c05413a0db834001c390617",
                SlotId = "mod_magazine",
                ParentId = "67895f1bd549ac3dab0e83de"
            },
            new Item
            {
                Id = "67895f1bd549ac3dab0e83e1",
                Template = "5bb20d53d4351e4502010a69",
                SlotId = "mod_reciever",
                ParentId = "67895f1bd549ac3dab0e83de"
            },
            new Item
            {
                Id = "67895f1bd549ac3dab0e83e2",
                Template = "5bb20e58d4351e00320205d7",
                SlotId = "mod_stock",
                ParentId = "67895f1bd549ac3dab0e83de"
            },
            new Item
            {
                Id = "67895f1bd549ac3dab0e83e8",
                Template = "5bb20dbcd4351e44f824c04e",
                SlotId = "mod_charge",
                ParentId = "67895f1bd549ac3dab0e83de"
            },
            new Item
            {
                Id = "67895f1bd549ac3dab0e83e7",
                Template = "5bb20d9cd4351e00334c9d8a",
                SlotId = "mod_barrel",
                ParentId = "67895f1bd549ac3dab0e83e1"
            },
            new Item
            {
                Id = "67895f1bd549ac3dab0e83e6",
                Template = "5bb20de5d4351e0035629e59",
                SlotId = "mod_handguard",
                ParentId = "67895f1bd549ac3dab0e83e1"
            },
            new Item
            {
                Id = "67895f1bd549ac3dab0e83e5",
                Template = "5bb20e49d4351e3bac1212de",
                SlotId = "mod_sight_rear",
                ParentId = "67895f1bd549ac3dab0e83e1",
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
                Id = "67895f1bd549ac3dab0e83e9",
                Template = "5bb20e70d4351e0035629f8f",
                SlotId = "mod_stock_000",
                ParentId = "67895f1bd549ac3dab0e83e2"
            },
            new Item
            {
                Id = "67895f1bd549ac3dab0e83e3",
                Template = "544a38634bdc2d58388b4568",
                SlotId = "mod_muzzle",
                ParentId = "67895f1bd549ac3dab0e83e7"
            },
            new Item
            {
                Id = "67895f1bd549ac3dab0e83e4",
                Template = "5bb20dcad4351e3bac1212da",
                SlotId = "mod_gas_block",
                ParentId = "67895f1bd549ac3dab0e83e7"
            }
        ]
    };
}
