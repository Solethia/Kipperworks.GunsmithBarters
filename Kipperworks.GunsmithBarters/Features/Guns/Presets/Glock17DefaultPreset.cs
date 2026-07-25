using SPTarkov.Server.Core.Models.Eft.Common.Tables;

namespace Kipperworks.GunsmithBarters;

public static class Glock17DefaultPreset
{
    public static GunPreset Create() => new()
    {
        Items =
        [
            new Item
            {
                Id = "22d25bd79781303e6a9d78a3",
                Template = "5a7ae0c351dfba0017554310",
                Upd = new Upd
                {
                    Repairable = new UpdRepairable { MaxDurability = 100, Durability = 100 },
                    FireMode = new UpdFireMode { FireMode = "single" }
                }
            },
            new Item
            {
                Id = "ad11af36c7820fdc65ef3da3",
                Template = "5a6b5f868dc32e000a311389",
                SlotId = "mod_barrel",
                ParentId = "22d25bd79781303e6a9d78a3"
            },
            new Item
            {
                Id = "059b8d26967753a78a236cde",
                Template = "5a6f5e048dc32e00094b97da",
                SlotId = "mod_reciever",
                ParentId = "22d25bd79781303e6a9d78a3"
            },
            new Item
            {
                Id = "337f38626b1feb96d31afca7",
                Template = "5a6f5d528dc32e00094b97d9",
                SlotId = "mod_sight_rear",
                ParentId = "059b8d26967753a78a236cde",
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
                Id = "4044c81fd878d353d9a12aa9",
                Template = "5a6f58f68dc32e000a311390",
                SlotId = "mod_sight_front",
                ParentId = "059b8d26967753a78a236cde",
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
                Id = "31dcfaa52588a0e5d6edd38d",
                Template = "5a718b548dc32e000d46d262",
                SlotId = "mod_magazine",
                ParentId = "22d25bd79781303e6a9d78a3"
            },
        ]
    };
}
