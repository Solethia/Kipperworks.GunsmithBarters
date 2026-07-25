using SPTarkov.Server.Core.Models.Eft.Common.Tables;

namespace Kipperworks.GunsmithBarters;

public static class SVDS762x54RSSniperRiflePreset
{
    public static GunPreset Create() => new()
    {
        Items =
        [
            new Item
            {
                Id = "6a552da2b3fd4628ace14432",
                Template = "5c46fbd72e2216398b5a8c9c",
                Upd = new Upd
                {
                    Repairable = new UpdRepairable { MaxDurability = 100, Durability = 100 },
                    Foldable = new UpdFoldable { Folded = false },
                    FireMode = new UpdFireMode { FireMode = "single" }
                }
            },
            // On base
            new Item
            {
                Id = "6a552e86b3fd4628ace14446",
                Template = "5c471be12e221602b66cd9ac",
                SlotId = "mod_pistol_grip",
                ParentId = "6a552da2b3fd4628ace14432"
            },
            new Item
            {
                Id = "6a552f77b3fd4628ace14447",
                Template = "5c471c442e221602b542a6f8",
                SlotId = "mod_magazine",
                ParentId = "6a552da2b3fd4628ace14432"
            },
            new Item
            {
                Id = "6a552f7bb3fd4628ace14448",
                Template = "5c471b5d2e221602b21d4e14",
                SlotId = "mod_stock",
                ParentId = "6a552da2b3fd4628ace14432"
            },
            new Item
            {
                Id = "6a552f7fb3fd4628ace14449",
                Template = "5c471cb32e221602b177afaa",
                SlotId = "mod_barrel",
                ParentId = "6a552da2b3fd4628ace14432"
            },
            new Item
            {
                Id = "6a552f86b3fd4628ace1444a",
                Template = "5c471c2d2e22164bef5d077f",
                SlotId = "mod_mount_001",
                ParentId = "6a552da2b3fd4628ace14432"
            },
            new Item
            {
                Id = "6a552f9cb3fd4628ace1444b",
                Template = "5c471bd12e221602b4129c3a",
                SlotId = "mod_reciever",
                ParentId = "6a552da2b3fd4628ace14432"
            },
            // On barrel
            new Item
            {
                Id = "6a553107b3fd4628ace1444c",
                Template = "5c471bfc2e221602b21d4e17",
                SlotId = "mod_muzzle",
                ParentId = "6a552f7fb3fd4628ace14449"
            },
            new Item
            {
                Id = "6a553107b3fd4628ace1444d",
                Template = "5c471c842e221615214259b5",
                SlotId = "mod_gas_block",
                ParentId = "6a552f7fb3fd4628ace14449"
            },
            // On Upper Band (mod_mount_1)
            new Item
            {
                Id = "6a553107b3fd4628ace1444e",
                Template = "5c471c6c2e221602b66cd9ae",
                SlotId = "mod_handguard",
                ParentId = "6a552f86b3fd4628ace1444a"
            },
            new Item
            {
                Id = "6a553107b3fd4628ace1444f",
                Template = "5c471b7e2e2216152006e46c",
                SlotId = "mod_sight_rear",
                ParentId = "6a552f86b3fd4628ace1444a",
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
                Id = "6a553155b3fd4628ace14450",
                Template = "5c471ba12e221602b3137d76",
                SlotId = "mod_sight_front",
                ParentId = "6a553107b3fd4628ace1444c",
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
