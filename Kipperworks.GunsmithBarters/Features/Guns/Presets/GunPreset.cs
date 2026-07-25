using SPTarkov.Server.Core.Models.Eft.Common.Tables;

namespace Kipperworks.GunsmithBarters;

public record GunPreset
{
    public List<Item> Items { get; set; } = [];
}
