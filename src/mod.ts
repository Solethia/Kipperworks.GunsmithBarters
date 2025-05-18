import { DependencyContainer } from "tsyringe";

// SPT types
import { IPreSptLoadMod } from "@spt/models/external/IPreSptLoadMod";
import { IPostDBLoadMod } from "@spt/models/external/IPostDBLoadMod";
import { ILogger } from "@spt/models/spt/utils/ILogger";
import { DatabaseServer } from "@spt/servers/DatabaseServer";
import { HashUtil } from "@spt/utils/HashUtil";

import { FluentAssortConstructor as FluentAssortCreator } from "./fluentTraderAssortCreator";
import { GunsmithBartersConfig } from "./GunsmithBartersConfig";
import configJson from "../config/config.json";
import { GunsmithBarterHelper } from "./gunsmithBarterHelper";
import { ItemHelper } from "@spt/helpers/ItemHelper";
import { QuestHelper } from "@spt/helpers/QuestHelper";

class GunsmithBarters implements IPreSptLoadMod, IPostDBLoadMod
{
    private mod: string;
    private logger: ILogger;

    constructor()
    {
        this.mod = "GunsmithBarters"; // Set name of mod so we can log it to console later
    }

    /**
     * Some work needs to be done prior to SPT code being loaded, registering the profile image + setting trader update time inside the trader config json
     * @param container Dependency container
     */
    public preSptLoad(container: DependencyContainer): void
    {
        // Get a logger
        this.logger = container.resolve<ILogger>("WinstonLogger");
    }

    /**
     * Majority of trader-related work occurs after the aki database has been loaded but prior to SPT code being run
     * @param container Dependency container
     */
    public postDBLoad(container: DependencyContainer): void
    {
        this.logger.debug(`[${this.mod}] postDb Loading... `);

        // Resolve SPT classes we'll use
        const hashUtil: HashUtil = container.resolve<HashUtil>("HashUtil");
        const databaseServer: DatabaseServer = container.resolve<DatabaseServer>("DatabaseServer");
        const itemHelper: ItemHelper = container.resolve<ItemHelper>("ItemHelper");
        const questHelper: QuestHelper = container.resolve<QuestHelper>("QuestHelper");
        const config = configJson as GunsmithBartersConfig;

        // Get a reference to the database tables
        const tables = databaseServer.getTables();

        // Create helper class and use it to register our traders image/icon + set its stock refresh time
        const fluentAssortCreator = new FluentAssortCreator(questHelper, itemHelper, hashUtil, this.logger);
        const gunsmithBarterHelper = new GunsmithBarterHelper(fluentAssortCreator, tables, config);

        gunsmithBarterHelper.addGunsmithOneBarters();
        gunsmithBarterHelper.addGunsmithTwoBarters();
        gunsmithBarterHelper.addGunsmithThreeBarters();
        gunsmithBarterHelper.addGunsmithFourBarters();
        gunsmithBarterHelper.addGunsmithFiveBarters();
        gunsmithBarterHelper.addGunsmithSixBarters();
        gunsmithBarterHelper.addGunsmithSevenBarters();
        gunsmithBarterHelper.addGunsmithEightBarters();
        gunsmithBarterHelper.addGunsmithNineBarters();
        gunsmithBarterHelper.addGunsmithTenBarters();
        gunsmithBarterHelper.addGunsmithEllevenBarters();
        gunsmithBarterHelper.addGunsmithTwelveBarters();
        gunsmithBarterHelper.addGunsmithThirteenBarters();
        gunsmithBarterHelper.addGunsmithFourteenBarters();
        gunsmithBarterHelper.addGunsmithFifteenBarters();
        gunsmithBarterHelper.addGunsmithSixteenBarters();
        gunsmithBarterHelper.addGunsmithSeventeenBarters();
        gunsmithBarterHelper.addGunsmithEighteenBarters();
        gunsmithBarterHelper.addGunsmithNineteenBarters();
        gunsmithBarterHelper.addGunsmithTwentyBarters();

        this.logger.info(`[${this.mod}] barters loaded`);
        this.logger.debug(`[${this.mod}] postDb Loaded`);
    }
}

export const mod = new GunsmithBarters();