using SPTarkov.Server.Core.Models.Eft.Common.Tables;

namespace Kipperworks.GunsmithBarters;

public static class OrsisT5000DefaultPreset
{
    public static GunPreset Create() => new()
    {
        Items =
        [
            new Item
            {
                Id = "43f6d2791ab3cb1d7909332a",
                Template = "5df24cf80dee1b22f862e9bc",
                Upd = new Upd
                {
                    Repairable = new UpdRepairable { MaxDurability = 100, Durability = 100 },
                    FireMode = new UpdFireMode { FireMode = "single" }
                }
            },
            new Item
            {
                Id = "6ad244d789919135761714cf",
                Template = "5df25b6c0b92095fd441e4cf",
                SlotId = "mod_magazine",
                ParentId = "43f6d2791ab3cb1d7909332a"
            },
            new Item
            {
                Id = "728b88629ad6b4ed21a02060",
                Template = "5df256570dee1b22f862e9c4",
                SlotId = "mod_barrel",
                ParentId = "43f6d2791ab3cb1d7909332a"
            },
            new Item
            {
                Id = "c34fdd8cd805629333e28400",
                Template = "5df35e7f2a78646d96665dd4",
                SlotId = "mod_muzzle",
                ParentId = "728b88629ad6b4ed21a02060"
            },
            new Item
            {
                Id = "43c8fccae1643e0ef310d210",
                Template = "5df35e59c41b2312ea3334d5",
                SlotId = "mod_stock",
                ParentId = "43f6d2791ab3cb1d7909332a"
            },
            new Item
            {
                Id = "2606970fcff0508e9e83c701",
                Template = "5df25d3bfd6b4e6e2276dc9a",
                SlotId = "mod_handguard",
                ParentId = "43c8fccae1643e0ef310d210"
            },
            new Item
            {
                Id = "4aa9ec5ed1ac26fb6f0fce21",
                Template = "5df35eb2b11454561e3923e2",
                SlotId = "mod_mount_000",
                ParentId = "2606970fcff0508e9e83c701"
            },
            new Item
            {
                Id = "3e8c549dc219405fa5b141e3",
                Template = "5df35eb2b11454561e3923e2",
                SlotId = "mod_mount_001",
                ParentId = "2606970fcff0508e9e83c701"
            },
            new Item
            {
                Id = "bcb0cbf8c5df90f6015b5c8c",
                Template = "5df35ea9c41b2312ea3334d8",
                SlotId = "mod_mount_002",
                ParentId = "2606970fcff0508e9e83c701"
            },
            new Item
            {
                Id = "eee658d5ccd0328abe24cdac",
                Template = "5df35eb2b11454561e3923e2",
                SlotId = "mod_mount_003",
                ParentId = "2606970fcff0508e9e83c701"
            },
            new Item
            {
                Id = "f060125880bc2dc0b1ed0285",
                Template = "5df36948bb49d91fb446d5ad",
                SlotId = "mod_foregrip",
                ParentId = "2606970fcff0508e9e83c701"
            },
            new Item
            {
                Id = "6f3e8dc3184dc679641113d5",
                Template = "5df38a5fb74cd90030650cb6",
                SlotId = "mod_pistol_grip",
                ParentId = "43c8fccae1643e0ef310d210"
            },
            new Item
            {
                Id = "45e073716a10aea12b04ea46",
                Template = "5df35ddddfc58d14537c2036",
                SlotId = "mod_stock_axis",
                ParentId = "43c8fccae1643e0ef310d210"
            },
            new Item
            {
                Id = "820ca5128518626710ee7485",
                Template = "5df35e970b92095fd441e4d2",
                SlotId = "mod_mount",
                ParentId = "43f6d2791ab3cb1d7909332a"
            },
        ]
    };
}
