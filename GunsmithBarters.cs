using SPTarkov.DI.Annotations;
using SPTarkov.Server.Core.DI;
using SPTarkov.Server.Core.Helpers;
using SPTarkov.Server.Core.Models.Spt.Mod;
using SPTarkov.Server.Core.Models.Utils;
using System.Reflection;

namespace Kipperworks.GunsmithBarters;

[Injectable(TypePriority = OnLoadOrder.PostDBModLoader + 1)]
public class GunsmithBarters(
    ISptLogger<GunsmithBarters> logger,
    ModHelper modHelper,
    FluentTraderAssortCreator fluentAssortCreator,
    GunsmithBarterHelper gunsmithBarterHelper)
    : IOnLoad
{
    public Task OnLoad()
    {
        logger.Debug("[GunsmithBarters] Loading...");

        var pathToMod = modHelper.GetAbsolutePathToModFolder(Assembly.GetExecutingAssembly());
        var config = modHelper.GetJsonDataFromFile<GunsmithBartersConfig>(pathToMod, "config/config.json");

        if (config.BarterAddTypes.Count == 0)
        {
            logger.Info("[GunsmithBarters] All barter types disabled in config, skipping...");
            return Task.CompletedTask;
        }

        fluentAssortCreator.SetDebug(config.Debug);
        gunsmithBarterHelper.Initialize(config);

        gunsmithBarterHelper.AddGunsmithOneBarters();
        gunsmithBarterHelper.AddGunsmithTwoBarters();
        gunsmithBarterHelper.AddGunsmithThreeBarters();
        gunsmithBarterHelper.AddGunsmithFourBarters();
        gunsmithBarterHelper.AddGunsmithFiveBarters();
        gunsmithBarterHelper.AddGunsmithSixBarters();
        gunsmithBarterHelper.AddGunsmithSevenBarters();
        gunsmithBarterHelper.AddGunsmithEightBarters();
        gunsmithBarterHelper.AddGunsmithNineBarters();
        gunsmithBarterHelper.AddGunsmithTenBarters();
        gunsmithBarterHelper.AddGunsmithElevenBarters();
        gunsmithBarterHelper.AddGunsmithTwelveBarters();
        gunsmithBarterHelper.AddGunsmithThirteenBarters();
        gunsmithBarterHelper.AddGunsmithFourteenBarters();
        gunsmithBarterHelper.AddGunsmithFifteenBarters();
        gunsmithBarterHelper.AddGunsmithSixteenBarters();
        gunsmithBarterHelper.AddGunsmithSeventeenBarters();
        gunsmithBarterHelper.AddGunsmithEighteenBarters();
        gunsmithBarterHelper.AddGunsmithNineteenBarters();
        gunsmithBarterHelper.AddGunsmithTwentyBarters();

        var barterAddTypeNames = config.BarterAddTypes.Where(x => x.Enabled).Select(x => x.Name);
        logger.Info($"[GunsmithBarters] Barters loaded - {string.Join(", ", barterAddTypeNames)}");

        return Task.CompletedTask;
    }
}
