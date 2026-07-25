using SPTarkov.DI.Annotations;
using SPTarkov.Server.Core.DI;
using SPTarkov.Server.Core.Models.Common;
using SPTarkov.Server.Core.Models.Eft.Common.Tables;
using SPTarkov.Server.Core.Services;

namespace Kipperworks.GunsmithBarters;

[Injectable(TypePriority = OnLoadOrder.PostDBModLoader + 1)]
public class GunsmithBarterHelper(
    FluentTraderAssortCreator fluentAssortCreator,
    GunBuilder gunBuilder,
    DatabaseService databaseService)
{
    private GunsmithBartersConfig _Config = null!;
    private Dictionary<MongoId, Quest> _Quests = null!;

    public void Initialize(GunsmithBartersConfig config)
    {
        _Config = config;
        _Quests = databaseService.GetTables().Templates.Quests;
    }

    public void AddGunsmithOneBarters()
    {
        var questName = "Gunsmith - Part 1";
        if (_Config.AddAttachmentBarters)
        {
            fluentAssortCreator
                .CreateSingleAssortItem(ItemIds.PLASTIC_PISTOL_GRIP)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(2)
                .AddBarterCost(ItemIds.RAM_STICK, 1)
                .AddLoyaltyLevel(1)
                .Export(TraderIds.JAEGER, questName);

            fluentAssortCreator
                .CreateSingleAssortItem(ItemIds.NC_STAR_TACTICAL_BLUE_LASER)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(1)
                .AddBarterCost(ItemIds.HOTROD, 1)
                .AddLoyaltyLevel(1)
                .Export(TraderIds.SKIER, questName);
        }
    }

    public void AddGunsmithTwoBarters()
    {
        var questName = "Gunsmith - Part 2";
        if (_Config.AddAttachmentBarters)
        {
            fluentAssortCreator
                .CreateSingleAssortItem(ItemIds.KAC_VERTICAL_FOREGRIP)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(3)
                .AddBarterCost(ItemIds.FLAT_SCREWDRIVER, 2)
                .AddLoyaltyLevel(1)
                .Export(TraderIds.PEACEKEEPER, questName);
        }
    }

    public void AddGunsmithThreeBarters()
    {
        // There are barters for everything already
    }

    public void AddGunsmithFourBarters()
    {
        var questName = "Gunsmith - Part 4";
        if (_Config.AddAttachmentBarters)
        {
            fluentAssortCreator
                .CreateSingleAssortItem(ItemIds.SKS_CHOATE_SCOPE_MOUNT)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(1)
                .AddBarterCost(ItemIds.SURVL_SURVIVOR_LIGHTER, 1)
                .AddBarterCost(ItemIds.CRICKENT_LIGHTER, 1)
                .AddLoyaltyLevel(2)
                .Export(TraderIds.JAEGER, questName);

            fluentAssortCreator
                .CreateSingleAssortItem(ItemIds.VOMZ_PILAD_RIFLESCOPE)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(1)
                .AddBarterCost(ItemIds.BOTTLE_OF_WATER, 2)
                .AddLoyaltyLevel(1)
                .Export(TraderIds.JAEGER, questName);

            fluentAssortCreator
                .CreateSingleAssortItem(ItemIds.LEAPERS_SCOPE_MOUNT)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(1)
                .AddBarterCost(ItemIds.HAWK_GUNPOWDER, 1)
                .AddLoyaltyLevel(1)
                .Export(TraderIds.JAEGER, questName);

            fluentAssortCreator
                .CreateSingleAssortItem(ItemIds.SKS_TAPCO_INTRAFUSE_BUFFER_TUBE)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(1)
                .AddBarterCost(ItemIds.PINEAPPLE_JUICE, 1)
                .AddLoyaltyLevel(1)
                .Export(TraderIds.MECHANIC, questName);

            fluentAssortCreator
                .CreateSingleAssortItem(ItemIds.SKS_TAPCO_INTRAFUSE_SAW_STYLE_PISTOL_GRIP)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(1)
                .AddBarterCost(ItemIds.WILSTON_CIGARETTE, 1)
                .AddLoyaltyLevel(1)
                .Export(TraderIds.MECHANIC, questName);

            fluentAssortCreator
                .CreateSingleAssortItem(ItemIds.SKS_HEXAGON_SOUND_SUPPRESSOR)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(1)
                .AddBarterCost(ItemIds.ELECTRIC_MOTOR, 1)
                .AddLoyaltyLevel(3)
                .Export(TraderIds.SKIER, questName);
        }
    }

    public void AddGunsmithFiveBarters()
    {
        var questName = "Gunsmith - Part 5";
        if (_Config.AddAttachmentBarters)
        {
            fluentAssortCreator
                .CreateSingleAssortItem(ItemIds.M870_REMINGTON_508MM_BARREL)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(1)
                .AddBarterCost(ItemIds.STRIKE_CIGARETTES, 2)
                .AddBarterCost(ItemIds.WILSTON_CIGARETTE, 2)
                .AddLoyaltyLevel(1)
                .Export(TraderIds.MECHANIC, questName);

            fluentAssortCreator
                .CreateSingleAssortItem(ItemIds.ME_CYLINDER_12GA_MUZZLE_ADAPTER)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(2)
                .AddBarterCost(ItemIds.SAURY, 1)
                .AddLoyaltyLevel(1)
                .Export(TraderIds.JAEGER, questName);

            fluentAssortCreator
                .CreateSingleAssortItem(ItemIds.GK_TWO_MUZZLE_BRAKE)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(2)
                .AddBarterCost(ItemIds.ELECTRONIC_COMPONENTS, 1)
                .AddBarterCost(ItemIds.PRINTED_CIRCUIT_BOARD, 1)
                .AddLoyaltyLevel(2)
                .Export(TraderIds.JAEGER, questName);
        }
    }

    public void AddGunsmithSixBarters()
    {
        var questName = "Gunsmith - Part 6";
        if (_Config.AddAttachmentBarters)
        {
            fluentAssortCreator
                .CreateSingleAssortItem(ItemIds.FORTIS_SHIFT)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(1)
                .AddBarterCost(ItemIds.WOODEN_CLOCK, 1)
                .AddLoyaltyLevel(4)
                .Export(TraderIds.PEACEKEEPER, questName);

            fluentAssortCreator
                .CreateSingleAssortItem(ItemIds.AK_TAPCO_SAW_STYLE_BLACK_PISTOL_GRIP)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(1)
                .AddBarterCost(ItemIds.CAPACITORS, 3)
                .AddLoyaltyLevel(2)
                .Export(TraderIds.MECHANIC, questName);

            fluentAssortCreator
                .CreateSingleAssortItem(ItemIds.AK_MAGPUL_PMAG_MAGAZINE)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(4)
                .AddBarterCost(ItemIds.HERRING, 1)
                .AddLoyaltyLevel(2)
                .Export(TraderIds.PEACEKEEPER, questName);

            fluentAssortCreator
                .CreateSingleAssortItem(ItemIds.AK_MAGPUL_MOE_AKM_HANDGUARD_FDE)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(1)
                .AddBarterCost(ItemIds.BOTTLE_OF_VODKA, 1)
                .AddLoyaltyLevel(2)
                .Export(TraderIds.PEACEKEEPER, questName);

            fluentAssortCreator
                .CreateSingleAssortItem(ItemIds.AK_AKEDEMIA_BASTION_DUST_COVER)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(1)
                .AddBarterCost(ItemIds.PEVKO_LIGHT_BEER, 1)
                .AddLoyaltyLevel(1)
                .Export(TraderIds.SKIER, questName);

            fluentAssortCreator
                .CreateSingleAssortItem(ItemIds.TRIJICON_TA51_SIGHT_MOUNT)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(1)
                .AddBarterCost(ItemIds.CAPACITORS, 1)
                .AddLoyaltyLevel(2)
                .Export(TraderIds.PEACEKEEPER, questName);

            fluentAssortCreator
                .CreateSingleAssortItem(ItemIds.TRIJICON_ACOG_TA11D)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(1)
                .AddBarterCost(ItemIds.SSD_DRIVE, 1)
                .AddLoyaltyLevel(2)
                .Export(TraderIds.PEACEKEEPER, questName);
        }
    }

    public void AddGunsmithSevenBarters()
    {
        var questName = "Gunsmith - Part 7";
        if (_Config.AddAttachmentBarters)
        {
            fluentAssortCreator
                .CreateSingleAssortItem(ItemIds.KRISS_DEFIANCE_STOCK_BLACK)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(2)
                .AddBarterCost(ItemIds.NAILS, 1)
                .AddBarterCost(ItemIds.POWERBANK, 1)
                .AddLoyaltyLevel(2)
                .Export(TraderIds.PEACEKEEPER, questName);

            fluentAssortCreator
                .CreateSingleAssortItem(ItemIds.MAGPUL_MOE_SL_CARBINE_LENGTH_MLOK_HANDGUARD)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(2)
                .AddBarterCost(ItemIds.WIRES, 1)
                .AddBarterCost(ItemIds.ROUND_PLIERS, 1)
                .AddLoyaltyLevel(1)
                .Export(TraderIds.SKIER, questName);

            fluentAssortCreator
                .CreateSingleAssortItem(ItemIds.WINDHAM_GAS_BLOCK)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(4)
                .AddBarterCost(ItemIds.USB_ADAPTER, 1)
                .AddBarterCost(ItemIds.RECHARGEABLE_BATTERY, 1)
                .AddLoyaltyLevel(1)
                .Export(TraderIds.MECHANIC, questName);

            fluentAssortCreator
                .CreateSingleAssortItem(ItemIds.DANIEL_DEFENCE_VERTICAL_FOREGRIP_BLACK)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(1)
                .AddBarterCost(ItemIds.BROKEN_LCD, 1)
                .AddLoyaltyLevel(2)
                .Export(TraderIds.PEACEKEEPER, questName);

            fluentAssortCreator
                .CreateSingleAssortItem(ItemIds.SUREFIRE_WAR_COMP_FLASH_HIDER)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(1)
                .AddBarterCost(ItemIds.CYCLON_RECHARGEABLE_BATTERY, 2)
                .AddLoyaltyLevel(2)
                .Export(TraderIds.SKIER, questName);
        }
    }

    public void AddGunsmithEightBarters()
    {
        var questName = "Gunsmith - Part 8";
        if (_Config.AddGunBarters)
        {
            var aks74nDefault = gunBuilder.GetAks74nDefault();
            fluentAssortCreator.CreateComplexAssortItem(aks74nDefault)
                .AddUnlimitedStackCount()
                .AddBarterCost(ItemIds.SOAP, 2)
                .AddBarterCost(ItemIds.WEAPON_PARTS, 1)
                .AddBuyRestriction(2)
                .AddLoyaltyLevel(2)
                .Export(TraderIds.PRAPOR, questName);
        }

        if (_Config.AddAttachmentBarters)
        {
            fluentAssortCreator
                .CreateSingleAssortItem(ItemIds.AKS74_AKS74U_ZENIT_PT_LOCK)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(2)
                .AddBarterCost(ItemIds.LONG_FLAT_SCREWDRIVER, 1)
                .AddBarterCost(ItemIds.LIGHT_BULB, 1)
                .AddLoyaltyLevel(2)
                .Export(TraderIds.SKIER, questName);

            fluentAssortCreator
                .CreateSingleAssortItem(ItemIds.AK_ZENIT_PT3_KLASSIKA_STOCK)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(2)
                .AddBarterCost(ItemIds.BOLTS, 1)
                .AddBarterCost(ItemIds.CAN_OF_MAJAICA_COFFEE_BEANS, 1)
                .AddLoyaltyLevel(3)
                .Export(TraderIds.SKIER, questName);

            fluentAssortCreator
                .CreateSingleAssortItem(ItemIds.AK_ZENIT_RK3_PISTOL_GRIP)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(2)
                .AddBarterCost(ItemIds.POWER_CORD, 1)
                .AddBarterCost(ItemIds.MALBORO_CIGARETTES, 1)
                .AddQuestRestriction(_Quests[QuestIds.MISSING_CARGO])
                .AddLoyaltyLevel(3)
                .Export(TraderIds.SKIER, questName);

            fluentAssortCreator
                .CreateSingleAssortItem(ItemIds.AK_ZENIT_B33_DUST_COVER)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(2)
                .AddBarterCost(ItemIds.TOOLSET, 1)
                .AddLoyaltyLevel(3)
                .Export(TraderIds.SKIER, questName);

            fluentAssortCreator
                .CreateSingleAssortItem(ItemIds.AK_ZENIT_DTK1_MUZZLE_BRAKE)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(2)
                .AddBarterCost(ItemIds.PIECE_OF_PLEXIGLASS, 1)
                .AddLoyaltyLevel(2)
                .Export(TraderIds.SKIER, questName);

            fluentAssortCreator
                .CreateSingleAssortItem(ItemIds.ZENIT_KLESCH_2IKS_IR_ILLUMINATOR)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(2)
                .AddBarterCost(ItemIds.PHASE_CONTROL_RELAY, 1)
                .AddLoyaltyLevel(2)
                .Export(TraderIds.SKIER, questName);

            fluentAssortCreator
                .CreateSingleAssortItem(ItemIds.ZENIT_RK0_TACTICAL_FOREGRIP)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(2)
                .AddBarterCost(ItemIds.ALYONKA_CHOCOLATE, 1)
                .AddBarterCost(ItemIds.SLICKERS_CHOCOLATE, 1)
                .AddLoyaltyLevel(3)
                .Export(TraderIds.SKIER, questName);

            fluentAssortCreator
                .CreateSingleAssortItem(ItemIds.AK12_MAGAZINE)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(1)
                .AddBarterCost(ItemIds.PLIERS, 2)
                .AddLoyaltyLevel(3)
                .Export(TraderIds.PRAPOR, questName);
        }
    }

    public void AddGunsmithOldFriendsRequestGlock17Barters()
    {
        var questName = "Gunsmith - Old Friend's Request: Glock 17";
        if (_Config.AddGunBarters)
        {
            var glock17Default = gunBuilder.GetGlock17Default();
            fluentAssortCreator.CreateComplexAssortItem(glock17Default)
                .AddUnlimitedStackCount()
                .AddBarterCost(ItemIds.TAR_COLA, 1)
                .AddBuyRestriction(1)
                .AddLoyaltyLevel(1)
                .Export(TraderIds.MECHANIC, questName);
        }

        if (_Config.AddAttachmentBarters)
        {
            fluentAssortCreator
                .CreateSingleAssortItem(ItemIds.GLOCK_9X19_DOUBLE_DIAMOND_114MM_THREADED_BARREL)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(2)
                .AddBarterCost(ItemIds.TUBE_OF_POXERAM_COLD_WELDING, 1)
                .AddLoyaltyLevel(2)
                .Export(TraderIds.MECHANIC, questName);

            fluentAssortCreator
                .CreateSingleAssortItem(ItemIds.GLOCK_9X19_DOUBLE_DIAMOND_THREAD_PROTECTOR)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(2)
                .AddBarterCost(ItemIds.APOLLO_SOYUZ_CIGARETTES, 1)
                .AddLoyaltyLevel(1)
                .Export(TraderIds.MECHANIC, questName);

            fluentAssortCreator
                .CreateSingleAssortItem(ItemIds.GLOCK_PACHMAYR_TACTICAL_GRIP_GLOVE)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(2)
                .AddBarterCost(ItemIds.PLIERS, 1)
                .AddBarterCost(ItemIds.MALBORO_CIGARETTES, 1)
                .AddLoyaltyLevel(1)
                .Export(TraderIds.MECHANIC, questName);

            fluentAssortCreator
                .CreateSingleAssortItem(ItemIds.GLOCK_9X19_MAGPUL_PMAG_GL9_21_ROUND_MAGAZINE)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(2)
                .AddBarterCost(ItemIds.PLIERS, 1)
                .AddBarterCost(ItemIds.DVD_DRIVE, 1)
                .AddLoyaltyLevel(1)
                .Export(TraderIds.MECHANIC, questName);
        }
    }

    public void AddGunsmithOldFriendsRequestOrsisT5000Barters()
    {
        var questName = "Gunsmith - Old Friend's Request: Orsis T-5000";
        if (_Config.AddGunBarters)
        {
            var orsisT5000Default = gunBuilder.GetOrsisT5000Default();
            fluentAssortCreator.CreateComplexAssortItem(orsisT5000Default)
                .AddUnlimitedStackCount()
                .AddBarterCost(ItemIds.SAS_DRIVE, 1)
                .AddBarterCost(ItemIds.DAMAGED_HARD_DRIVE, 1)
                .AddBuyRestriction(1)
                .AddQuestRestriction(_Quests[QuestIds.LEND_LEASE_PART_ONE])
                .AddLoyaltyLevel(2)
                .Export(TraderIds.SKIER, questName);
        }

        if (_Config.AddAttachmentBarters)
        {
            fluentAssortCreator
                .CreateSingleAssortItem(ItemIds.HARRIS_S_BRM_6_9_BIPOD)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(2)
                .AddBarterCost(ItemIds.PRINTED_CIRCUIT_BOARD, 1)
                .AddLoyaltyLevel(2)
                .Export(TraderIds.SKIER, questName);
        }
    }

    public void AddGunsmithOldFriendsRequestPP19Barters()
    {
        var questName = "Gunsmith - Old Friend's Request: PP19";
        if (_Config.AddAttachmentBarters)
        {
            fluentAssortCreator
                .CreateSingleAssortItem(ItemIds.PP19_01_VITYAZ_SN_DUST_COVER)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(2)
                .AddBarterCost(ItemIds.INSULATING_TAPE, 1)
                .AddLoyaltyLevel(1)
                .Export(TraderIds.PRAPOR, questName);

            fluentAssortCreator
                .CreateSingleAssortItem(ItemIds.AIMPOINT_MICRO_SPACER_HIGH)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(2)
                .AddBarterCost(ItemIds.MALBORO_CIGARETTES, 1)
                .AddLoyaltyLevel(1)
                .Export(TraderIds.PEACEKEEPER, questName);

            fluentAssortCreator
                .CreateSingleAssortItem(ItemIds.PP19_01_VITYAZ_9X19_SOUND_SUPPRESSOR)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(2)
                .AddBarterCost(ItemIds.PRINTER_PAPER, 1)
                .AddLoyaltyLevel(2)
                .Export(TraderIds.MECHANIC, questName);

            fluentAssortCreator
                .CreateSingleAssortItem(ItemIds.PP19_01_VITYAZ_SAG_MK1_MLOK_HANDGUARD_WITH_GAS_TUBE)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(2)
                .AddBarterCost(ItemIds.ULTRAVIOLET_LAMP, 1)
                .AddLoyaltyLevel(2)
                .Export(TraderIds.MECHANIC, questName);

            fluentAssortCreator
                .CreateSingleAssortItem(ItemIds.ZENIT_RK6_TACTICAL_FOREGRIP)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(2)
                .AddBarterCost(ItemIds.DUCT_TAPE, 2)
                .AddLoyaltyLevel(1)
                .Export(TraderIds.SKIER, questName);

            fluentAssortCreator
                .CreateSingleAssortItem(ItemIds.L3_HARRIS_AN_PEQ15_TACTICAL_DEVICE_TAN)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(2)
                .AddBarterCost(ItemIds.USB_ADAPTER, 1)
                .AddBarterCost(ItemIds.CAN_OF_MAJAICA_COFFEE_BEANS, 1)
                .AddLoyaltyLevel(3)
                .Export(TraderIds.PEACEKEEPER, questName);

            fluentAssortCreator
                .CreateSingleAssortItem(ItemIds.ZENIT_KLESCH_2P_FLASHLIGHT_WITH_LASER)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(2)
                .AddBarterCost(ItemIds.CRICKENT_LIGHTER, 1)
                .AddBarterCost(ItemIds.STRIKE_CIGARETTES, 1)
                .AddLoyaltyLevel(2)
                .Export(TraderIds.SKIER, questName);
        }
    }

    public void AddGunsmithNineBarters()
    {
        var questName = "Gunsmith - Part 9";
        if (_Config.AddAttachmentBarters)
        {
            fluentAssortCreator
                .CreateSingleAssortItem(ItemIds.P226_TJ_CUSTOM_COMPENSATOR)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(1)
                .AddBarterCost(ItemIds.SPARK_PLUG, 1)
                .AddLoyaltyLevel(1)
                .Export(TraderIds.MECHANIC, questName);

            fluentAssortCreator
                .CreateSingleAssortItem(ItemIds.P226_THREADED_BARREL)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(1)
                .AddBarterCost(ItemIds.GPHONE, 1)
                .AddLoyaltyLevel(1)
                .Export(TraderIds.PEACEKEEPER, questName);
        }
    }

    public void AddGunsmithTenBarters()
    {
        var questName = "Gunsmith - Part 10";
        if (_Config.AddGunBarters)
        {
            var ak105Default = gunBuilder.GetAk105Default();
            fluentAssortCreator.CreateComplexAssortItem(ak105Default)
                .AddUnlimitedStackCount()
                .AddBarterCost(ItemIds.HAWK_GUNPOWDER, 1)
                .AddBarterCost(ItemIds.WEAPON_PARTS, 2)
                .AddBuyRestriction(1)
                .AddLoyaltyLevel(3)
                .Export(TraderIds.PRAPOR, questName);
        }

        if (_Config.AddAttachmentBarters)
        {
            var gunsmithPartTwo = _Quests[QuestIds.GUNSMITH_PART_TWO];
            fluentAssortCreator
                .CreateSingleAssortItem(ItemIds.AK100_SERIES_POLYMER_HANDGUARD)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(2)
                .AddQuestRestriction(gunsmithPartTwo)
                .AddBarterCost(ItemIds.BOLTS, 1)
                .AddBarterCost(ItemIds.LARGE_BEEF_STEW, 1)
                .AddLoyaltyLevel(1)
                .Export(TraderIds.PRAPOR, questName);

            fluentAssortCreator
                .CreateSingleAssortItem(ItemIds.AK100_ZENIT_PT_LOCK)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(1)
                .AddBarterCost(ItemIds.POWER_CORD, 1)
                .AddLoyaltyLevel(2)
                .Export(TraderIds.SKIER, questName);

            fluentAssortCreator
                .CreateSingleAssortItem(ItemIds.AK_ZENIT_PT1_KLASSIKA_STOCK)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(1)
                .AddBarterCost(ItemIds.ANALOG_THERMOMETER, 1)
                .AddLoyaltyLevel(2)
                .Export(TraderIds.SKIER, questName);
        }
    }

    public void AddGunsmithElevenBarters()
    {
        var questName = "Gunsmith - Part 11";
        if (_Config.AddGunBarters)
        {
            var krissVector9x19Default = gunBuilder.GetKrissVector9x19Default();
            var vitaminsPartTwoQuest = _Quests[QuestIds.VITAMINS_PART_TWO];
            fluentAssortCreator.CreateComplexAssortItem(krissVector9x19Default)
                .AddUnlimitedStackCount()
                .AddBarterCost(ItemIds.LIGHT_BULB, 4)
                .AddBarterCost(ItemIds.PRESSURE_GAUGE, 2)
                .AddBuyRestriction(1)
                .AddQuestRestriction(vitaminsPartTwoQuest)
                .AddLoyaltyLevel(3)
                .Export(TraderIds.SKIER, questName);
        }

        if (_Config.AddAttachmentBarters)
        {
            fluentAssortCreator
                .CreateSingleAssortItem(ItemIds.SKELETONIZED_FOREGRIP)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(2)
                .AddBarterCost(ItemIds.DR_LUPO_COFFEE_BEANS, 1)
                .AddLoyaltyLevel(3)
                .Export(TraderIds.PEACEKEEPER, questName);

            fluentAssortCreator
                .CreateSingleAssortItem(ItemIds.COLT_CARBINE_BUFFER_TUBE)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(1)
                .AddBarterCost(ItemIds.LIGHT_BULB, 2)
                .AddLoyaltyLevel(2)
                .Export(TraderIds.SKIER, questName);
        }
    }

    public void AddGunsmithTwelveBarters()
    {
        var questName = "Gunsmith - Part 12";
        if (_Config.AddAttachmentBarters)
        {
            fluentAssortCreator
                .CreateSingleAssortItem(ItemIds.STEINER_FLASHLIGHT)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(1)
                .AddBarterCost(ItemIds.AWL, 1)
                .AddLoyaltyLevel(3)
                .Export(TraderIds.MECHANIC, questName);
        }
    }

    public void AddGunsmithThirteenBarters()
    {
        var questName = "Gunsmith - Part 13";
        if (_Config.AddAttachmentBarters)
        {
            fluentAssortCreator
                .CreateSingleAssortItem(ItemIds.REMINGTON_RAGH4_INCH_RAIL)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(2)
                .AddBarterCost(ItemIds.METAL_SPARE_PARTS, 1)
                .AddLoyaltyLevel(2)
                .Export(TraderIds.MECHANIC, questName);

            fluentAssortCreator
                .CreateSingleAssortItem(ItemIds.KAC_FOLDING_REAR_SIGHT)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(1)
                .AddBarterCost(ItemIds.ZIBBO_LIGHTER, 1)
                .AddLoyaltyLevel(2)
                .Export(TraderIds.PEACEKEEPER, questName);

            fluentAssortCreator
                .CreateSingleAssortItem(ItemIds.KAC_FOLDING_FRONT_SIGHT)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(1)
                .AddBarterCost(ItemIds.ZIBBO_LIGHTER, 1)
                .AddLoyaltyLevel(2)
                .Export(TraderIds.PEACEKEEPER, questName);

            fluentAssortCreator
                .CreateSingleAssortItem(ItemIds.FIREARMS_SKELETONIZED_STYLE_01_PISTOL_GRIP)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(1)
                .AddBarterCost(ItemIds.BEARD_OIL, 1)
                .AddBarterCost(ItemIds.CHAINLET, 1)
                .AddLoyaltyLevel(3)
                .Export(TraderIds.SKIER, questName);
        }
    }

    public void AddGunsmithFourteenBarters()
    {
        var questName = "Gunsmith - Part 14";
        if (_Config.AddGunBarters)
        {
            var hk416a5Default = gunBuilder.GetHk416a5Default();
            var wetJobPartThree = _Quests[QuestIds.WET_JOB_PART_THREE];
            fluentAssortCreator.CreateComplexAssortItem(hk416a5Default)
                .AddUnlimitedStackCount()
                .AddBarterCost(ItemIds.CPU_FAN, 4)
                .AddBarterCost(ItemIds.CPU, 2)
                .AddBuyRestriction(1)
                .AddQuestRestriction(wetJobPartThree)
                .AddLoyaltyLevel(3)
                .Export(TraderIds.PEACEKEEPER, questName);
        }

        if (_Config.AddAttachmentBarters)
        {
            fluentAssortCreator
                .CreateSingleAssortItem(ItemIds.MAGPUL_MLOK_CANTILEVER_MOUNT)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(2)
                .AddBarterCost(ItemIds.RECHARGEABLE_BATTERY, 1)
                .AddLoyaltyLevel(2)
                .Export(TraderIds.SKIER, questName);

            fluentAssortCreator
                .CreateSingleAssortItem(ItemIds.MAGPUL_MOE_PISTOL_GRIP)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(1)
                .AddBarterCost(ItemIds.POWER_SUPPLY_UNIT, 1)
                .AddLoyaltyLevel(3)
                .Export(TraderIds.PEACEKEEPER, questName);

            fluentAssortCreator
                .CreateSingleAssortItem(ItemIds.MAGPUL_UBR_GEN2_STOCK_FDE)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(1)
                .AddBarterCost(ItemIds.WORKING_LCD, 1)
                .AddLoyaltyLevel(3)
                .Export(TraderIds.PEACEKEEPER, questName);

            fluentAssortCreator
                .CreateSingleAssortItem(ItemIds.MAGPUL_RVG_FOREGRIP_FDE)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(1)
                .AddBarterCost(ItemIds.SCREWDRIVER, 1)
                .AddBarterCost(ItemIds.DUCT_TAPE, 3)
                .AddLoyaltyLevel(3)
                .Export(TraderIds.PEACEKEEPER, questName);

            fluentAssortCreator
                .CreateSingleAssortItem(ItemIds.L3_HARRIS_LA5B_PEQ_TACTICAL_DEVICE)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(1)
                .AddBarterCost(ItemIds.ELECTRONIC_COMPONENTS, 1)
                .AddLoyaltyLevel(4)
                .Export(TraderIds.MECHANIC, questName);

            fluentAssortCreator
                .CreateSingleAssortItem(ItemIds.MAGPUL_FLIP_UP_REAR_SIGHT_FDE)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(1)
                .AddBarterCost(ItemIds.NIPPERS, 1)
                .AddLoyaltyLevel(2)
                .Export(TraderIds.MECHANIC, questName);

            fluentAssortCreator
                .CreateSingleAssortItem(ItemIds.MAGPUL_FLIP_UP_FRONT_SIGHT_FDE)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(1)
                .AddBarterCost(ItemIds.NIPPERS, 1)
                .AddLoyaltyLevel(2)
                .Export(TraderIds.MECHANIC, questName);

            fluentAssortCreator
                .CreateSingleAssortItem(ItemIds.EO_TECH_EXP_HOLOGRAPHIC_SIGHT_TAN)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(1)
                .AddBarterCost(ItemIds.TOOLSET, 1)
                .AddLoyaltyLevel(4)
                .Export(TraderIds.MECHANIC, questName);
        }
    }

    public void AddGunsmithFifteenBarters()
    {
        var questName = "Gunsmith - Part 15";
        if (_Config.AddGunBarters)
        {
            var asValDefault = gunBuilder.GetAsValDefault();
            fluentAssortCreator.CreateComplexAssortItem(asValDefault)
                .AddUnlimitedStackCount()
                .AddBarterCost(ItemIds.PRESSURE_GAUGE, 1)
                .AddBarterCost(ItemIds.KEK_TAPE, 4)
                .AddBuyRestriction(1)
                .AddLoyaltyLevel(4)
                .Export(TraderIds.PRAPOR, questName);
        }

        if (_Config.AddAttachmentBarters)
        {
            fluentAssortCreator
                .CreateSingleAssortItem(ItemIds.DOVETAIL_NIGHT_VISION_SCOPE)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(2)
                .AddBarterCost(ItemIds.STRIKE_CIGARETTES, 2)
                .AddLoyaltyLevel(1)
                .Export(TraderIds.PRAPOR, questName);

            fluentAssortCreator
                .CreateSingleAssortItem(ItemIds.VAL_ZENIT_B3_RING_MOUNT)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(1)
                .AddBarterCost(ItemIds.GOLD_CHAIN, 1)
                .AddLoyaltyLevel(3)
                .Export(TraderIds.SKIER, questName);
        }
    }

    public void AddGunsmithSixteenBarters()
    {
        // Barters already exist
    }

    public void AddGunsmithSeventeenBarters()
    {
        var questName = "Gunsmith - Part 17";
        if (_Config.AddGunBarters)
        {
            var ak102Default = gunBuilder.GetAk102Default();
            fluentAssortCreator.CreateComplexAssortItem(ak102Default)
                .AddUnlimitedStackCount()
                .AddBarterCost(ItemIds.LONG_FLAT_SCREWDRIVER, 2)
                .AddBarterCost(ItemIds.FLAT_SCREWDRIVER, 2)
                .AddBarterCost(ItemIds.STRIKE_CIGARETTES, 2)
                .AddBuyRestriction(1)
                .AddLoyaltyLevel(3)
                .Export(TraderIds.MECHANIC, questName);
        }

        if (_Config.AddAttachmentBarters)
        {
            fluentAssortCreator
                .CreateSingleAssortItem(ItemIds.AK_CNC_WARRIOR_MUZZLE_DEVICE_ADAPTER)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(2)
                .AddBarterCost(ItemIds.STRIKE_CIGARETTES, 3)
                .AddLoyaltyLevel(3)
                .Export(TraderIds.MECHANIC, questName);

            fluentAssortCreator
                .CreateSingleAssortItem(ItemIds.RPK16_BUFFER_TUBE)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(1)
                .AddBarterCost(ItemIds.PLIERS, 2)
                .AddLoyaltyLevel(3)
                .Export(TraderIds.MECHANIC, questName);

            fluentAssortCreator
                .CreateSingleAssortItem(ItemIds.AK_ZENITH_B10M_HANDGUARD)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(1)
                .AddBarterCost(ItemIds.DVD_DRIVE, 1)
                .AddBarterCost(ItemIds.NAILS, 1)
                .AddLoyaltyLevel(3)
                .Export(TraderIds.SKIER, questName);

            fluentAssortCreator
                .CreateSingleAssortItem(ItemIds.MAGPUL_AFG_TACTICAL_FOREGRIP_OLIVE_DRAB)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(1)
                .AddBarterCost(ItemIds.PHASE_CONTROL_RELAY, 2)
                .AddLoyaltyLevel(3)
                .Export(TraderIds.MECHANIC, questName);

            fluentAssortCreator
                .CreateSingleAssortItem(ItemIds.ZENIT_KLESCH2U_TACTICAL_FLASHLIGHT)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(1)
                .AddBarterCost(ItemIds.LIGHT_BULB, 2)
                .AddLoyaltyLevel(3)
                .Export(TraderIds.MECHANIC, questName);

            fluentAssortCreator
                .CreateSingleAssortItem(ItemIds.AK_CSS_KNURLED_CHARGING_HANDLE)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(1)
                .AddBarterCost(ItemIds.BLEND_TEA, 1)
                .AddLoyaltyLevel(3)
                .Export(TraderIds.SKIER, questName);
        }
    }

    public void AddGunsmithEighteenBarters()
    {
        var questName = "Gunsmith - Part 18";
        if (_Config.AddGunBarters)
        {
            var akmnDefault = gunBuilder.GetAkmnDefault();
            fluentAssortCreator.CreateComplexAssortItem(akmnDefault)
                .AddUnlimitedStackCount()
                .AddBarterCost(ItemIds.CAN_OF_GREEN_PEAS, 4)
                .AddBuyRestriction(2)
                .AddLoyaltyLevel(3)
                .Export(TraderIds.PRAPOR, questName);
        }

        if (_Config.AddAttachmentBarters)
        {
            fluentAssortCreator
                .CreateSingleAssortItem(ItemIds.AK_MAGPUL_MOE_AKM_HANDGUARD_BLACK)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(2)
                .AddBarterCost(ItemIds.TARKER_DRIED_MEAT, 2)
                .AddLoyaltyLevel(3)
                .Export(TraderIds.MECHANIC, questName);

            fluentAssortCreator
                .CreateSingleAssortItem(ItemIds.MAGPUL_MLOK_AFG_TACTICAL_FOREGRIP_BLACK)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(3)
                .AddBarterCost(ItemIds.DUCT_TAPE, 3)
                .AddLoyaltyLevel(3)
                .Export(TraderIds.SKIER, questName);

            fluentAssortCreator
                .CreateSingleAssortItem(ItemIds.MAGPUL_ZHUKOV_S_STOCK)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(1)
                .AddBarterCost(ItemIds.GEIGER_MULLER_COUNTER, 2)
                .AddLoyaltyLevel(4)
                .Export(TraderIds.PEACEKEEPER, questName);

            fluentAssortCreator
                .CreateSingleAssortItem(ItemIds.AK_MAGPUL_MOE_PISTOL_GRIP)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(1)
                .AddBarterCost(ItemIds.POWER_CORD, 2)
                .AddLoyaltyLevel(3)
                .Export(TraderIds.MECHANIC, questName);

            fluentAssortCreator
                .CreateSingleAssortItem(ItemIds.EO_TECH_HSS1_HYBRID_SIGHT)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(1)
                .AddBarterCost(ItemIds.SPARK_PLUG, 2)
                .AddBarterCost(ItemIds.WORKING_LCD, 1)
                .AddLoyaltyLevel(4)
                .Export(TraderIds.PEACEKEEPER, questName);
        }
    }

    public void AddGunsmithNineteenBarters()
    {
        var questName = "Gunsmith - Part 19";
        if (_Config.AddGunBarters)
        {
            var svds = gunBuilder.GetSVDS762x54RSniperRifleDefault();
            fluentAssortCreator.CreateComplexAssortItem(svds)
                .AddUnlimitedStackCount()
                .AddBarterCost(ItemIds.LVNDMARKS_RAT_POISON, 1)
                .AddBarterCost(ItemIds.BLEACH, 1)
                .AddBarterCost(ItemIds.ALKALINE_CLEANER_FOR_HEAT_EXCHANGERS, 1)
                .AddBuyRestriction(2)
                .AddLoyaltyLevel(3)
                .Export(TraderIds.PRAPOR, questName);
        }

        if (_Config.AddAttachmentBarters)
        {
            fluentAssortCreator
                .CreateSingleAssortItem(ItemIds.SVDS_LYNX_ARMS_HINGE_BUFFER_TUBE_ADAPTER)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(2)
                .AddBarterCost(ItemIds.MRE_RATION_PACK, 1)
                .AddLoyaltyLevel(2)
                .Export(TraderIds.JAEGER, questName);

            fluentAssortCreator
                .CreateSingleAssortItem(ItemIds.MAGPUL_UBR_GEN2_STOCK_BLACK)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(3)
                .AddBarterCost(ItemIds.BLEACH, 1)
                .AddBarterCost(ItemIds.SOAP, 1)
                .AddLoyaltyLevel(3)
                .Export(TraderIds.PEACEKEEPER, questName);

            fluentAssortCreator
                .CreateSingleAssortItem(ItemIds.SVDS_ROTOR43_THREAD_ADAPTER)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(1)
                .AddBarterCost(ItemIds.WD40_SMALL, 2)
                .AddLoyaltyLevel(3)
                .Export(TraderIds.MECHANIC, questName);

            fluentAssortCreator
                .CreateSingleAssortItem(ItemIds.ROTOR43_SOUND_SUPPRESSOR_762X54R)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(1)
                .AddBarterCost(ItemIds.BOOK, 1)
                .AddLoyaltyLevel(3)
                .Export(TraderIds.SKIER, questName);

            fluentAssortCreator
                .CreateSingleAssortItem(ItemIds.MARCH_TACTICAL_FFP_30MM_RIFLESCOPE)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(1)
                .AddBarterCost(ItemIds.SUGAR, 3)
                .AddLoyaltyLevel(4)
                .Export(TraderIds.JAEGER, questName);
        }
    }

    public void AddGunsmithTwentyBarters()
    {
        var questName = "Gunsmith - Part 20";
        if (_Config.AddAttachmentBarters)
        {
            fluentAssortCreator
                .CreateSingleAssortItem(ItemIds.M1A_20_ROUND_MAGAZINE)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(2)
                .AddBarterCost(ItemIds.HUNTING_MATCHES, 2)
                .AddLoyaltyLevel(2)
                .Export(TraderIds.PEACEKEEPER, questName);

            fluentAssortCreator
                .CreateSingleAssortItem(ItemIds.AIMPOINT_MICRO_T1_REFLEX_SIGHT)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(3)
                .AddBarterCost(ItemIds.ZIBBO_LIGHTER, 2)
                .AddLoyaltyLevel(2)
                .Export(TraderIds.PEACEKEEPER, questName);

            fluentAssortCreator
                .CreateSingleAssortItem(ItemIds.AIMPOINT_MICRO_STANDARD_MOUNT)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(1)
                .AddBarterCost(ItemIds.CRICKENT_LIGHTER, 1)
                .AddLoyaltyLevel(1)
                .Export(TraderIds.MECHANIC, questName);

            fluentAssortCreator
                .CreateSingleAssortItem(ItemIds.HOLOSUN_LS321_TACTICAL_DEVICE)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(2)
                .AddBarterCost(ItemIds.TAR_COLA, 2)
                .AddLoyaltyLevel(3)
                .Export(TraderIds.SKIER, questName);
        }
    }
}
