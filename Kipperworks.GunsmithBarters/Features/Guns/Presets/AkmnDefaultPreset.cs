using SPTarkov.Server.Core.Models.Eft.Common.Tables;

namespace Kipperworks.GunsmithBarters;

public static class AkmnDefaultPreset
{
    public static GunPreset Create() => new()
    {
        Items =
        [
            new Item
            {
                Id = "67895d80d549ac3dab0e7fa5",
                Template = "5a0ec13bfcdbcb00165aa685",
                Upd = new Upd
                {
                    Repairable = new UpdRepairable { MaxDurability = 100, Durability = 100 },
                    FireMode = new UpdFireMode { FireMode = "single" }
                }
            },
            new Item
            {
                Id = "67895d80d549ac3dab0e7fa6",
                Template = "59d64ec286f774171d1e0a42",
                SlotId = "mod_gas_block",
                ParentId = "67895d80d549ac3dab0e7fa5"
            },
            new Item
            {
                Id = "67895d80d549ac3dab0e7fa7",
                Template = "59d64fc686f774171b243fe2",
                SlotId = "mod_muzzle",
                ParentId = "67895d80d549ac3dab0e7fa5"
            },
            new Item
            {
                Id = "67895d80d549ac3dab0e7fa8",
                Template = "59e62cc886f77440d40b52a1",
                SlotId = "mod_pistol_grip",
                ParentId = "67895d80d549ac3dab0e7fa5"
            },
            new Item
            {
                Id = "67895d80d549ac3dab0e7fa9",
                Template = "59d6507c86f7741b846413a2",
                SlotId = "mod_reciever",
                ParentId = "67895d80d549ac3dab0e7fa5"
            },
            new Item
            {
                Id = "67895d80d549ac3dab0e7faa",
                Template = "59d650cf86f7741b846413a4",
                SlotId = "mod_sight_rear",
                ParentId = "67895d80d549ac3dab0e7fa5",
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
                Id = "67895d80d549ac3dab0e7fab",
                Template = "59d6514b86f774171a068a08",
                SlotId = "mod_stock",
                ParentId = "67895d80d549ac3dab0e7fa5"
            },
            new Item
            {
                Id = "67895d80d549ac3dab0e7fac",
                Template = "5a01c29586f77474660c694c",
                SlotId = "mod_magazine",
                ParentId = "67895d80d549ac3dab0e7fa5"
            },
            new Item
            {
                Id = "67895d80d549ac3dab0e7fad",
                Template = "59d64f2f86f77417193ef8b3",
                SlotId = "mod_handguard",
                ParentId = "67895d80d549ac3dab0e7fa6"
            }
        ]
    };
}
