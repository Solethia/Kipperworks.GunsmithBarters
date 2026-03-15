using SPTarkov.Server.Core.Models.Eft.Common.Tables;

namespace Kipperworks.GunsmithBarters;

public static class KrissVector9x19DefaultPreset
{
    public static GunPreset Create() => new()
    {
        Items =
        [
            new Item
            {
                Id = "67895faed549ac3dab0e83ef",
                Template = "5fc3f2d5900b1d5091531e57",
                Upd = new Upd
                {
                    Repairable = new UpdRepairable { MaxDurability = 100, Durability = 100 },
                    Foldable = new UpdFoldable { Folded = false },
                    FireMode = new UpdFireMode { FireMode = "single" }
                }
            },
            new Item
            {
                Id = "67895faed549ac3dab0e83f0",
                Template = "5a718b548dc32e000d46d262",
                SlotId = "mod_magazine",
                ParentId = "67895faed549ac3dab0e83ef"
            },
            new Item
            {
                Id = "67895faed549ac3dab0e83f1",
                Template = "5fb6567747ce63734e3fa1dc",
                SlotId = "mod_sight_front",
                ParentId = "67895faed549ac3dab0e83ef",
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
                Id = "67895faed549ac3dab0e83f2",
                Template = "5fb6564947ce63734e3fa1da",
                SlotId = "mod_sight_rear",
                ParentId = "67895faed549ac3dab0e83ef",
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
                Id = "67895faed549ac3dab0e83f3",
                Template = "5fb6558ad6f0b2136f2d7eb7",
                SlotId = "mod_stock",
                ParentId = "67895faed549ac3dab0e83ef"
            },
            new Item
            {
                Id = "67895faed549ac3dab0e83f4",
                Template = "5fbbc366ca32ed67276c1557",
                SlotId = "mod_barrel",
                ParentId = "67895faed549ac3dab0e83ef"
            },
            new Item
            {
                Id = "67895faed549ac3dab0e83f5",
                Template = "5fbb976df9986c4cff3fe5f2",
                SlotId = "mod_mount",
                ParentId = "67895faed549ac3dab0e83ef"
            },
            new Item
            {
                Id = "67895faed549ac3dab0e83f6",
                Template = "5fce0f9b55375d18a253eff2",
                SlotId = "mod_mount_001",
                ParentId = "67895faed549ac3dab0e83ef"
            },
            new Item
            {
                Id = "67895faed549ac3dab0e83f7",
                Template = "5fce0f9b55375d18a253eff2",
                SlotId = "mod_mount_002",
                ParentId = "67895faed549ac3dab0e83ef"
            },
            new Item
            {
                Id = "67895faed549ac3dab0e83f8",
                Template = "5fbbc34106bde7524f03cbe9",
                SlotId = "mod_muzzle",
                ParentId = "67895faed549ac3dab0e83f4"
            }
        ]
    };
}
