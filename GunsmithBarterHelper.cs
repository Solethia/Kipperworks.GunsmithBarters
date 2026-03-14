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
    private GunsmithBartersConfig _config = null!;
    private Dictionary<MongoId, Quest> _quests = null!;

    public void Initialize(GunsmithBartersConfig config)
    {
        _config = config;
        _quests = databaseService.GetTables().Templates.Quests;
    }

    public void AddGunsmithOneBarters()
    {
        var questName = "Gunsmith - Part 1";
        if (_config.AddAttachmentBarters)
        {
            var plasticPistolGrip = "56083a334bdc2dc8488b4571";
            var ramStick = "57347baf24597738002c6178";
            fluentAssortCreator
                .CreateSingleAssortItem(plasticPistolGrip)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(2)
                .AddBarterCost(ramStick, 1)
                .AddLoyaltyLevel(1)
                .Export(TraderIds.Jaeger, questName);

            var ncStarTacticalBlueLaser = "5cc9c20cd7f00c001336c65d";
            var hotrod = "5751496424597720a27126da";
            fluentAssortCreator
                .CreateSingleAssortItem(ncStarTacticalBlueLaser)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(1)
                .AddBarterCost(hotrod, 1)
                .AddLoyaltyLevel(1)
                .Export(TraderIds.Skier, questName);
        }
    }

    public void AddGunsmithTwoBarters()
    {
        var questName = "Gunsmith - Part 2";
        if (_config.AddAttachmentBarters)
        {
            var kacVerticalForegrip = "5c87ca002e221600114cb150";
            var flatScrewdriver = "5d63d33b86f7746ea9275524";
            fluentAssortCreator
                .CreateSingleAssortItem(kacVerticalForegrip)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(3)
                .AddBarterCost(flatScrewdriver, 2)
                .AddLoyaltyLevel(1)
                .Export(TraderIds.Peacekeeper, questName);
        }
    }

    public void AddGunsmithThreeBarters()
    {
        // There are barters for everything already
    }

    public void AddGunsmithFourBarters()
    {
        var questName = "Gunsmith - Part 4";
        if (_config.AddAttachmentBarters)
        {
            var sksChoateScopeMount = "6415d33eda439c6a97048b5b";
            var survLSurvivorLighter = "5e2af37686f774755a234b65";
            var crickentlighter = "56742c284bdc2d98058b456d";
            fluentAssortCreator
                .CreateSingleAssortItem(sksChoateScopeMount)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(1)
                .AddBarterCost(survLSurvivorLighter, 1)
                .AddBarterCost(crickentlighter, 1)
                .AddLoyaltyLevel(2)
                .Export(TraderIds.Jaeger, questName);

            var vomzPiladRiflescope = "5dff772da3651922b360bf91";
            var bottleOfWater = "5448fee04bdc2dbc018b4567";
            fluentAssortCreator
                .CreateSingleAssortItem(vomzPiladRiflescope)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(1)
                .AddBarterCost(bottleOfWater, 2)
                .AddLoyaltyLevel(1)
                .Export(TraderIds.Jaeger, questName);

            var leapersScopeMount = "5dff77c759400025ea5150cf";
            var hawkGunpowder = "5d6fc87386f77449db3db94e";
            fluentAssortCreator
                .CreateSingleAssortItem(leapersScopeMount)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(1)
                .AddBarterCost(hawkGunpowder, 1)
                .AddLoyaltyLevel(1)
                .Export(TraderIds.Jaeger, questName);

            var sksTapcoIntrafuseBufferTube = "5afd7e095acfc40017541f61";
            var pineappleJuice = "544fb62a4bdc2dfb738b4568";
            fluentAssortCreator
                .CreateSingleAssortItem(sksTapcoIntrafuseBufferTube)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(1)
                .AddBarterCost(pineappleJuice, 1)
                .AddLoyaltyLevel(1)
                .Export(TraderIds.Mechanic, questName);

            var sksTapcoIntrafuseSawStylePistolGrip = "5afd7e445acfc4001637e35a";
            var wilstonCigarette = "573476f124597737e04bf328";
            fluentAssortCreator
                .CreateSingleAssortItem(sksTapcoIntrafuseSawStylePistolGrip)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(1)
                .AddBarterCost(wilstonCigarette, 1)
                .AddLoyaltyLevel(1)
                .Export(TraderIds.Mechanic, questName);

            var sksHexagonSoundSupressor = "593d490386f7745ee97a1555";
            var electricMotor = "5d1b2fa286f77425227d1674";
            fluentAssortCreator
                .CreateSingleAssortItem(sksHexagonSoundSupressor)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(1)
                .AddBarterCost(electricMotor, 1)
                .AddLoyaltyLevel(3)
                .Export(TraderIds.Skier, questName);
        }
    }

    public void AddGunsmithFiveBarters()
    {
        var questName = "Gunsmith - Part 5";
        if (_config.AddAttachmentBarters)
        {
            var m870Remington508mmBarrel = "5a787f7ac5856700177af660";
            var strikeCigaretts = "5734770f24597738025ee254";
            var wilstonCigarettes = "573476f124597737e04bf328";
            fluentAssortCreator
                .CreateSingleAssortItem(m870Remington508mmBarrel)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(1)
                .AddBarterCost(strikeCigaretts, 2)
                .AddBarterCost(wilstonCigarettes, 2)
                .AddLoyaltyLevel(1)
                .Export(TraderIds.Mechanic, questName);

            var cylinderTwelveGagueMuzzleAdapter = "5c0111ab0db834001966914d";
            var saury = "5673de654bdc2d180f8b456d";
            fluentAssortCreator
                .CreateSingleAssortItem(cylinderTwelveGagueMuzzleAdapter)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(2)
                .AddBarterCost(saury, 1)
                .AddLoyaltyLevel(1)
                .Export(TraderIds.Jaeger, questName);

            var gkTwoMuzzleBreak = "58272d7f2459774f6311ddfd";
            var electronicComponents = "6389c70ca33d8c4cdf4932c6";
            var printedCircuitBoard = "590a3b0486f7743954552bdb";
            fluentAssortCreator
                .CreateSingleAssortItem(gkTwoMuzzleBreak)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(2)
                .AddBarterCost(electronicComponents, 1)
                .AddBarterCost(printedCircuitBoard, 1)
                .AddLoyaltyLevel(2)
                .Export(TraderIds.Jaeger, questName);
        }
    }

    public void AddGunsmithSixBarters()
    {
        var questName = "Gunsmith - Part 6";
        if (_config.AddAttachmentBarters)
        {
            var fortisShift = "59f8a37386f7747af3328f06";
            var woodenClock = "59e3647686f774176a362507";
            fluentAssortCreator
                .CreateSingleAssortItem(fortisShift)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(1)
                .AddBarterCost(woodenClock, 1)
                .AddLoyaltyLevel(4)
                .Export(TraderIds.Peacekeeper, questName);

            var akTapcoSawStyleblackPistolGrip = "5947f92f86f77427344a76b1";
            var capacitors = "5c06782b86f77426df5407d2";
            fluentAssortCreator
                .CreateSingleAssortItem(akTapcoSawStyleblackPistolGrip)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(1)
                .AddBarterCost(capacitors, 3)
                .AddLoyaltyLevel(2)
                .Export(TraderIds.Mechanic, questName);

            var akMagpulPmagMagazine = "59d6272486f77466146386ff";
            var herring = "57347d9c245977448b40fa85";
            fluentAssortCreator
                .CreateSingleAssortItem(akMagpulPmagMagazine)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(4)
                .AddBarterCost(herring, 1)
                .AddLoyaltyLevel(2)
                .Export(TraderIds.Peacekeeper, questName);

            var akMagpulMoeAkmHandguardFde = "57cffd8224597763b03fc609";
            var bottleOfVodka = "5d40407c86f774318526545a";
            fluentAssortCreator
                .CreateSingleAssortItem(akMagpulMoeAkmHandguardFde)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(1)
                .AddBarterCost(bottleOfVodka, 1)
                .AddLoyaltyLevel(2)
                .Export(TraderIds.Peacekeeper, questName);

            var akAkedemiaBastionDustCover = "5d2c76ed48f03532f2136169";
            var pevkoLightBeer = "62a09f32621468534a797acb";
            fluentAssortCreator
                .CreateSingleAssortItem(akAkedemiaBastionDustCover)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(1)
                .AddBarterCost(pevkoLightBeer, 1)
                .AddLoyaltyLevel(1)
                .Export(TraderIds.Skier, questName);

            var trijiconTA51SightMount = "59db7eed86f77461f8380365";
            fluentAssortCreator
                .CreateSingleAssortItem(trijiconTA51SightMount)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(1)
                .AddBarterCost(capacitors, 1)
                .AddLoyaltyLevel(2)
                .Export(TraderIds.Peacekeeper, questName);

            var trijiconAcogTA11D = "59db7e1086f77448be30ddf3";
            var ssdDrive = "590c392f86f77444754deb29";
            fluentAssortCreator
                .CreateSingleAssortItem(trijiconAcogTA11D)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(1)
                .AddBarterCost(ssdDrive, 1)
                .AddLoyaltyLevel(2)
                .Export(TraderIds.Peacekeeper, questName);
        }
    }

    public void AddGunsmithSevenBarters()
    {
        var questName = "Gunsmith - Part 7";
        if (_config.AddAttachmentBarters)
        {
            var krissDefianceStockBlack = "5fbbaa86f9986c4cff3fe5f6";
            var nails = "590c31c586f774245e3141b2";
            var powerbank = "5af0561e86f7745f5f3ad6ac";
            fluentAssortCreator
                .CreateSingleAssortItem(krissDefianceStockBlack)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(2)
                .AddBarterCost(nails, 1)
                .AddBarterCost(powerbank, 1)
                .AddLoyaltyLevel(2)
                .Export(TraderIds.Peacekeeper, questName);

            var magpulMoeSlCarbineLenghtMlokHandguard = "5c78f2792e221600106f4683";
            var wires = "5c06779c86f77426e00dd782";
            var roundPliers = "5d1b31ce86f7742523398394";
            fluentAssortCreator
                .CreateSingleAssortItem(magpulMoeSlCarbineLenghtMlokHandguard)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(2)
                .AddBarterCost(wires, 1)
                .AddBarterCost(roundPliers, 1)
                .AddLoyaltyLevel(1)
                .Export(TraderIds.Skier, questName);

            var windhamGasBlock = "56ea8d2fd2720b7c698b4570";
            var usbAdapter = "5909e99886f7740c983b9984";
            var rechargableBattery = "590a358486f77429692b2790";
            fluentAssortCreator
                .CreateSingleAssortItem(windhamGasBlock)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(4)
                .AddBarterCost(usbAdapter, 1)
                .AddBarterCost(rechargableBattery, 1)
                .AddLoyaltyLevel(1)
                .Export(TraderIds.Mechanic, questName);

            var danielDefenceVerticalForegripBlack = "651a8bf3a8520e48047bf708";
            var brokenLcd = "5d1b309586f77425227d1676";
            fluentAssortCreator
                .CreateSingleAssortItem(danielDefenceVerticalForegripBlack)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(1)
                .AddBarterCost(brokenLcd, 1)
                .AddLoyaltyLevel(2)
                .Export(TraderIds.Peacekeeper, questName);

            var surefireWarCompFlashHider = "5c6d710d2e22165df16b81e7";
            var cyclonRechargableBattery = "5e2aee0a86f774755a234b62";
            fluentAssortCreator
                .CreateSingleAssortItem(surefireWarCompFlashHider)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(1)
                .AddBarterCost(cyclonRechargableBattery, 2)
                .AddLoyaltyLevel(2)
                .Export(TraderIds.Skier, questName);
        }
    }

    public void AddGunsmithEightBarters()
    {
        var questName = "Gunsmith - Part 8";
        if (_config.AddGunBarters)
        {
            var aks74nDefault = gunBuilder.GetAks74nDefault();
            var soap = "5c13cd2486f774072c757944";
            var weaponParts = "5d1c819a86f774771b0acd6c";
            fluentAssortCreator.CreateComplexAssortItem(aks74nDefault)
                .AddUnlimitedStackCount()
                .AddBarterCost(soap, 2)
                .AddBarterCost(weaponParts, 1)
                .AddBuyRestriction(2)
                .AddLoyaltyLevel(2)
                .Export(TraderIds.Prapor, questName);
        }

        if (_config.AddAttachmentBarters)
        {
            var zenitRk0TacticalForegrip = "5c1bc4812e22164bef5cfde7";
            var alyonkaChocolate = "57505f6224597709a92585a9";
            var slickersChocolate = "544fb6cc4bdc2d34748b456e";
            fluentAssortCreator
                .CreateSingleAssortItem(zenitRk0TacticalForegrip)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(2)
                .AddBarterCost(alyonkaChocolate, 1)
                .AddBarterCost(slickersChocolate, 1)
                .AddLoyaltyLevel(3)
                .Export(TraderIds.Skier, questName);

            var ak12Magazine = "5bed61680db834001d2c45ab";
            var pliers = "590c2b4386f77425357b6123";
            fluentAssortCreator
                .CreateSingleAssortItem(ak12Magazine)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(1)
                .AddBarterCost(pliers, 2)
                .AddLoyaltyLevel(3)
                .Export(TraderIds.Prapor, questName);

            var zenitKleschIksIrIlluminator = "5a5f1ce64f39f90b401987bc";
            var phaseControlRelay = "5d1b313086f77425227d1678";
            fluentAssortCreator
                .CreateSingleAssortItem(zenitKleschIksIrIlluminator)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(2)
                .AddBarterCost(phaseControlRelay, 1)
                .AddLoyaltyLevel(2)
                .Export(TraderIds.Skier, questName);
        }
    }

    public void AddGunsmithNineBarters()
    {
        var questName = "Gunsmith - Part 9";
        if (_config.AddAttachmentBarters)
        {
            var p226TjCustomCompensator = "5c6beec32e221601da3578f2";
            var sparkPlug = "590a3c0a86f774385a33c450";
            fluentAssortCreator
                .CreateSingleAssortItem(p226TjCustomCompensator)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(1)
                .AddBarterCost(sparkPlug, 1)
                .AddLoyaltyLevel(1)
                .Export(TraderIds.Mechanic, questName);

            var p226ThreadedBarrel = "587de4282459771bca0ec90b";
            var gPhone = "56742c324bdc2d150f8b456d";
            fluentAssortCreator
                .CreateSingleAssortItem(p226ThreadedBarrel)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(1)
                .AddBarterCost(gPhone, 1)
                .AddLoyaltyLevel(1)
                .Export(TraderIds.Peacekeeper, questName);
        }
    }

    public void AddGunsmithTenBarters()
    {
        var questName = "Gunsmith - Part 10";
        if (_config.AddGunBarters)
        {
            var ak105Default = gunBuilder.GetAk105Default();
            var hawkGunpowder = "5d6fc87386f77449db3db94e";
            var weaponParts = "5d1c819a86f774771b0acd6c";
            fluentAssortCreator.CreateComplexAssortItem(ak105Default)
                .AddUnlimitedStackCount()
                .AddBarterCost(hawkGunpowder, 1)
                .AddBarterCost(weaponParts, 2)
                .AddBuyRestriction(1)
                .AddLoyaltyLevel(3)
                .Export(TraderIds.Prapor, questName);
        }

        if (_config.AddAttachmentBarters)
        {
            var ak100seriesPolymerHandguard = "5cbda392ae92155f3c17c39f";
            var bolts = "57347c5b245977448d35f6e1";
            var largeBeefStew = "57347da92459774491567cf5";
            var gunsmithPartTwo = _quests["5ac2426c86f774138762edfe"];
            fluentAssortCreator
                .CreateSingleAssortItem(ak100seriesPolymerHandguard)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(2)
                .AddQuestRestriction(gunsmithPartTwo)
                .AddBarterCost(bolts, 1)
                .AddBarterCost(largeBeefStew, 1)
                .AddLoyaltyLevel(1)
                .Export(TraderIds.Prapor, questName);

            var ak100ZenitPtLock = "5ac78eaf5acfc4001926317a";
            var powerCord = "59e36c6f86f774176c10a2a7";
            fluentAssortCreator
                .CreateSingleAssortItem(ak100ZenitPtLock)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(1)
                .AddBarterCost(powerCord, 1)
                .AddLoyaltyLevel(2)
                .Export(TraderIds.Skier, questName);

            var akZenitPt1KlassikaStock = "5b222d405acfc400153af4fe";
            var analogThermometer = "5d1b32c186f774252167a530";
            fluentAssortCreator
                .CreateSingleAssortItem(akZenitPt1KlassikaStock)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(1)
                .AddBarterCost(analogThermometer, 1)
                .AddLoyaltyLevel(2)
                .Export(TraderIds.Skier, questName);
        }
    }

    public void AddGunsmithElevenBarters()
    {
        var questName = "Gunsmith - Part 11";
        var lightBulb = "5d1b392c86f77425243e98fe";
        if (_config.AddGunBarters)
        {
            var krissVector9x19Default = gunBuilder.GetKrissVector9x19Default();
            var pressureGauge = "5d1b327086f7742525194449";
            var vitaminsPartTwoQuest = _quests["5b478ff486f7744d184ecbbf"];
            fluentAssortCreator.CreateComplexAssortItem(krissVector9x19Default)
                .AddUnlimitedStackCount()
                .AddBarterCost(lightBulb, 4)
                .AddBarterCost(pressureGauge, 2)
                .AddBuyRestriction(1)
                .AddQuestRestriction(vitaminsPartTwoQuest)
                .AddLoyaltyLevel(3)
                .Export(TraderIds.Skier, questName);
        }

        if (_config.AddAttachmentBarters)
        {
            var skeletonizedForegrip = "5f6340d3ca442212f4047eb2";
            var drLupoCoffeeBeans = "5e54f6af86f7742199090bf3";
            fluentAssortCreator
                .CreateSingleAssortItem(skeletonizedForegrip)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(2)
                .AddBarterCost(drLupoCoffeeBeans, 1)
                .AddLoyaltyLevel(3)
                .Export(TraderIds.Peacekeeper, questName);

            var coltCarbineBufferTube = "5649be884bdc2d79388b4577";
            fluentAssortCreator
                .CreateSingleAssortItem(coltCarbineBufferTube)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(1)
                .AddBarterCost(lightBulb, 2)
                .AddLoyaltyLevel(2)
                .Export(TraderIds.Skier, questName);
        }
    }

    public void AddGunsmithTwelveBarters()
    {
        var questName = "Gunsmith - Part 12";
        if (_config.AddAttachmentBarters)
        {
            var steinerFlashlight = "5b07dd285acfc4001754240d";
            var awl = "62a0a098de7ac8199358053b";
            fluentAssortCreator
                .CreateSingleAssortItem(steinerFlashlight)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(1)
                .AddBarterCost(awl, 1)
                .AddLoyaltyLevel(3)
                .Export(TraderIds.Mechanic, questName);
        }
    }

    public void AddGunsmithThirteenBarters()
    {
        var questName = "Gunsmith - Part 13";
        if (_config.AddAttachmentBarters)
        {
            var remingtonRagh4InchRail = "5c0102b20db834001d23eebc";
            var metalSpareParts = "61bf7b6302b3924be92fa8c3";
            fluentAssortCreator
                .CreateSingleAssortItem(remingtonRagh4InchRail)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(2)
                .AddBarterCost(metalSpareParts, 1)
                .AddLoyaltyLevel(2)
                .Export(TraderIds.Mechanic, questName);

            var kacFoldingRearSight = "5c1780312e221602b66cc189";
            var zibboLighter = "56742c2e4bdc2d95058b456d";
            fluentAssortCreator
                .CreateSingleAssortItem(kacFoldingRearSight)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(1)
                .AddBarterCost(zibboLighter, 1)
                .AddLoyaltyLevel(2)
                .Export(TraderIds.Peacekeeper, questName);

            var kacFoldingFrontSight = "5c17804b2e2216152006c02f";
            fluentAssortCreator
                .CreateSingleAssortItem(kacFoldingFrontSight)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(1)
                .AddBarterCost(zibboLighter, 1)
                .AddLoyaltyLevel(2)
                .Export(TraderIds.Peacekeeper, questName);

            var firearmsSkeletonizedStyle01PistolGrip = "6113c3586c780c1e710c90bc";
            var beardOil = "5bc9b9ecd4351e3bac122519";
            var chainlet = "573474f924597738002c6174";
            fluentAssortCreator
                .CreateSingleAssortItem(firearmsSkeletonizedStyle01PistolGrip)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(1)
                .AddBarterCost(beardOil, 1)
                .AddBarterCost(chainlet, 1)
                .AddLoyaltyLevel(3)
                .Export(TraderIds.Skier, questName);
        }
    }

    public void AddGunsmithFourteenBarters()
    {
        var questName = "Gunsmith - Part 14";
        if (_config.AddGunBarters)
        {
            var hk416a5Default = gunBuilder.GetHk416a5Default();
            var cpuFan = "5734779624597737e04bf329";
            var cpu = "573477e124597737dd42e191";
            var wetJobPartThree = _quests["5a27bc1586f7741f6d40fa2f"];
            fluentAssortCreator.CreateComplexAssortItem(hk416a5Default)
                .AddUnlimitedStackCount()
                .AddBarterCost(cpuFan, 4)
                .AddBarterCost(cpu, 2)
                .AddBuyRestriction(1)
                .AddQuestRestriction(wetJobPartThree)
                .AddLoyaltyLevel(3)
                .Export(TraderIds.Peacekeeper, questName);
        }

        if (_config.AddAttachmentBarters)
        {
            var magpulMlokCantileverMount = "6269220d70b6c02e665f2635";
            var rechargableBattery = "590a358486f77429692b2790";
            fluentAssortCreator
                .CreateSingleAssortItem(magpulMlokCantileverMount)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(2)
                .AddBarterCost(rechargableBattery, 1)
                .AddLoyaltyLevel(2)
                .Export(TraderIds.Skier, questName);

            var magpulMoePistolGrip = "5d15cf3bd7ad1a67e71518b2";
            var powerSupplyUnit = "57347c2e24597744902c94a1";
            fluentAssortCreator
                .CreateSingleAssortItem(magpulMoePistolGrip)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(1)
                .AddBarterCost(powerSupplyUnit, 1)
                .AddLoyaltyLevel(3)
                .Export(TraderIds.Peacekeeper, questName);

            var magpulUbrGen2StockFde = "5947eab886f77475961d96c5";
            var workingLcd = "5d1b304286f774253763a528";
            fluentAssortCreator
                .CreateSingleAssortItem(magpulUbrGen2StockFde)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(1)
                .AddBarterCost(workingLcd, 1)
                .AddLoyaltyLevel(3)
                .Export(TraderIds.Peacekeeper, questName);

            var magpulRvgForegripFde = "5fce0cf655375d18a253eff0";
            var screwdriver = "590c2d8786f774245b1f03f3";
            var ductTape = "57347c1124597737fb1379e3";
            fluentAssortCreator
                .CreateSingleAssortItem(magpulRvgForegripFde)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(1)
                .AddBarterCost(screwdriver, 1)
                .AddBarterCost(ductTape, 3)
                .AddLoyaltyLevel(3)
                .Export(TraderIds.Peacekeeper, questName);

            var l3HarrisLa5bPeqTacticalDevice = "5c06595c0db834001a66af6c";
            var electronicComponents = "6389c70ca33d8c4cdf4932c6";
            fluentAssortCreator
                .CreateSingleAssortItem(l3HarrisLa5bPeqTacticalDevice)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(1)
                .AddBarterCost(electronicComponents, 1)
                .AddLoyaltyLevel(4)
                .Export(TraderIds.Mechanic, questName);

            var magpulFlipUpRearSightFde = "5c18b9192e2216398b5a8104";
            var nippers = "5d40425986f7743185265461";
            fluentAssortCreator
                .CreateSingleAssortItem(magpulFlipUpRearSightFde)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(1)
                .AddBarterCost(nippers, 1)
                .AddLoyaltyLevel(2)
                .Export(TraderIds.Mechanic, questName);

            var magpulFlipUpFrontSightFde = "5c18b90d2e2216152142466b";
            fluentAssortCreator
                .CreateSingleAssortItem(magpulFlipUpFrontSightFde)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(1)
                .AddBarterCost(nippers, 1)
                .AddLoyaltyLevel(2)
                .Export(TraderIds.Mechanic, questName);

            var eoTechExpHolographicSightTan = "558022b54bdc2dac148b458d";
            var toolset = "590c2e1186f77425357b6124";
            fluentAssortCreator
                .CreateSingleAssortItem(eoTechExpHolographicSightTan)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(1)
                .AddBarterCost(toolset, 1)
                .AddLoyaltyLevel(4)
                .Export(TraderIds.Mechanic, questName);
        }
    }

    public void AddGunsmithFifteenBarters()
    {
        var questName = "Gunsmith - Part 15";
        if (_config.AddGunBarters)
        {
            var asValDefault = gunBuilder.GetAsValDefault();
            var pressureGauge = "5d1b327086f7742525194449";
            var kekTape = "5e2af29386f7746d4159f077";
            fluentAssortCreator.CreateComplexAssortItem(asValDefault)
                .AddUnlimitedStackCount()
                .AddBarterCost(pressureGauge, 1)
                .AddBarterCost(kekTape, 4)
                .AddBuyRestriction(1)
                .AddLoyaltyLevel(4)
                .Export(TraderIds.Prapor, questName);
        }

        if (_config.AddAttachmentBarters)
        {
            var dovetailNightVisionScope = "5a7c74b3e899ef0014332c29";
            var strikeCigarettes = "5734770f24597738025ee254";
            fluentAssortCreator
                .CreateSingleAssortItem(dovetailNightVisionScope)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(2)
                .AddBarterCost(strikeCigarettes, 2)
                .AddLoyaltyLevel(1)
                .Export(TraderIds.Prapor, questName);

            var valZenitB3RingMount = "57a3459f245977764a01f703";
            var goldChain = "5734758f24597738025ee253";
            fluentAssortCreator
                .CreateSingleAssortItem(valZenitB3RingMount)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(1)
                .AddBarterCost(goldChain, 1)
                .AddLoyaltyLevel(3)
                .Export(TraderIds.Skier, questName);
        }
    }

    public void AddGunsmithSixteenBarters()
    {
        // Barters already exist
    }

    public void AddGunsmithSeventeenBarters()
    {
        var questName = "Gunsmith - Part 17";
        var strikeCigarettes = "5734770f24597738025ee254";
        if (_config.AddGunBarters)
        {
            var ak102Default = gunBuilder.GetAk102Default();
            var longFlatScrewdriver = "5d4042a986f7743185265463";
            var shortFlatScrewdriver = "5d63d33b86f7746ea9275524";
            fluentAssortCreator.CreateComplexAssortItem(ak102Default)
                .AddUnlimitedStackCount()
                .AddBarterCost(longFlatScrewdriver, 2)
                .AddBarterCost(shortFlatScrewdriver, 2)
                .AddBarterCost(strikeCigarettes, 2)
                .AddBuyRestriction(1)
                .AddLoyaltyLevel(3)
                .Export(TraderIds.Mechanic, questName);
        }

        if (_config.AddAttachmentBarters)
        {
            var akCncWarriorMuzzleDeviceAdapter = "5e21ca18e4d47f0da15e77dd";
            fluentAssortCreator
                .CreateSingleAssortItem(akCncWarriorMuzzleDeviceAdapter)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(2)
                .AddBarterCost(strikeCigarettes, 3)
                .AddLoyaltyLevel(3)
                .Export(TraderIds.Mechanic, questName);

            var rpk16BufferTube = "5beec8b20db834001961942a";
            var pliers = "590c2b4386f77425357b6123";
            fluentAssortCreator
                .CreateSingleAssortItem(rpk16BufferTube)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(1)
                .AddBarterCost(pliers, 2)
                .AddLoyaltyLevel(3)
                .Export(TraderIds.Mechanic, questName);

            var akZenithB10MHandguard = "5648b4534bdc2d3d1c8b4580";
            var dvdDrive = "5734781f24597737e04bf32a";
            var nails = "590c31c586f774245e3141b2";
            fluentAssortCreator
                .CreateSingleAssortItem(akZenithB10MHandguard)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(1)
                .AddBarterCost(dvdDrive, 1)
                .AddBarterCost(nails, 1)
                .AddLoyaltyLevel(3)
                .Export(TraderIds.Skier, questName);

            var magpulAfgTacticalForegripOliveDrab = "588226ef24597767af46e39c";
            var phaseControlRelay = "5d1b313086f77425227d1678";
            fluentAssortCreator
                .CreateSingleAssortItem(magpulAfgTacticalForegripOliveDrab)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(1)
                .AddBarterCost(phaseControlRelay, 2)
                .AddLoyaltyLevel(3)
                .Export(TraderIds.Mechanic, questName);

            var zenitKlesch2UTacticalFlashlight = "5b3a337e5acfc4704b4a19a0";
            var lightBulb = "5d1b392c86f77425243e98fe";
            fluentAssortCreator
                .CreateSingleAssortItem(zenitKlesch2UTacticalFlashlight)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(1)
                .AddBarterCost(lightBulb, 2)
                .AddLoyaltyLevel(3)
                .Export(TraderIds.Mechanic, questName);

            var akCssKnurledChargingHandle = "6130ca3fd92c473c77020dbd";
            var blendTea = "5bc9be8fd4351e00334cae6e";
            fluentAssortCreator
                .CreateSingleAssortItem(akCssKnurledChargingHandle)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(1)
                .AddBarterCost(blendTea, 1)
                .AddLoyaltyLevel(3)
                .Export(TraderIds.Skier, questName);

            var akZenitB33DustCover = "5649af884bdc2d1b2b8b4589";
            var toolset = "590c2e1186f77425357b6124";
            fluentAssortCreator
                .CreateSingleAssortItem(akZenitB33DustCover)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(1)
                .AddBarterCost(toolset, 1)
                .AddLoyaltyLevel(3)
                .Export(TraderIds.Skier, questName);
        }
    }

    public void AddGunsmithEighteenBarters()
    {
        var questName = "Gunsmith - Part 18";
        if (_config.AddGunBarters)
        {
            var akmnDefault = gunBuilder.GetAkmnDefault();
            var canOfGreenPeas = "57347d692459774491567cf1";
            fluentAssortCreator.CreateComplexAssortItem(akmnDefault)
                .AddUnlimitedStackCount()
                .AddBarterCost(canOfGreenPeas, 4)
                .AddBuyRestriction(2)
                .AddLoyaltyLevel(3)
                .Export(TraderIds.Prapor, questName);
        }

        if (_config.AddAttachmentBarters)
        {
            var akMagpulMoeAkmHandguardBlack = "57cff947245977638e6f2a19";
            var tarkerDriedMeat = "65815f0e647e3d7246384e14";
            fluentAssortCreator
                .CreateSingleAssortItem(akMagpulMoeAkmHandguardBlack)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(2)
                .AddBarterCost(tarkerDriedMeat, 2)
                .AddLoyaltyLevel(3)
                .Export(TraderIds.Mechanic, questName);

            var magpulMlokAfgTacticalForegripBlack = "57cffb66245977632f391a99";
            var ductTape = "57347c1124597737fb1379e3";
            fluentAssortCreator
                .CreateSingleAssortItem(magpulMlokAfgTacticalForegripBlack)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(3)
                .AddBarterCost(ductTape, 3)
                .AddLoyaltyLevel(3)
                .Export(TraderIds.Skier, questName);

            var magpulZhukovSStock = "5b0e794b5acfc47a877359b2";
            var geigerMullerCounter = "5672cb724bdc2dc2088b456b";
            fluentAssortCreator
                .CreateSingleAssortItem(magpulZhukovSStock)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(1)
                .AddBarterCost(geigerMullerCounter, 2)
                .AddLoyaltyLevel(4)
                .Export(TraderIds.Peacekeeper, questName);

            var akMagpulMoePistolGrip = "5b30ac585acfc433000eb79c";
            var powerCord = "59e36c6f86f774176c10a2a7";
            fluentAssortCreator
                .CreateSingleAssortItem(akMagpulMoePistolGrip)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(1)
                .AddBarterCost(powerCord, 2)
                .AddLoyaltyLevel(3)
                .Export(TraderIds.Mechanic, questName);

            var eoTechHss1HybridSight = "5c07dd120db834001c39092d";
            var sparkPlug = "590a3c0a86f774385a33c450";
            var workingLcd = "5d1b304286f774253763a528";
            fluentAssortCreator
                .CreateSingleAssortItem(eoTechHss1HybridSight)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(1)
                .AddBarterCost(sparkPlug, 2)
                .AddBarterCost(workingLcd, 1)
                .AddLoyaltyLevel(4)
                .Export(TraderIds.Peacekeeper, questName);
        }
    }

    public void AddGunsmithNineteenBarters()
    {
        var questName = "Gunsmith - Part 19";
        if (_config.AddAttachmentBarters)
        {
            var svdsLynxArmsHingeBufferTubeAdapter = "6197b229af1f5202c57a9bea";
            var mreRationPack = "590c5f0d86f77413997acfab";
            fluentAssortCreator
                .CreateSingleAssortItem(svdsLynxArmsHingeBufferTubeAdapter)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(2)
                .AddBarterCost(mreRationPack, 1)
                .AddLoyaltyLevel(2)
                .Export(TraderIds.Jaeger, questName);

            var magpulUbrGen2StockBlack = "5947e98b86f774778f1448bc";
            var bleach = "59e3556c86f7741776641ac2";
            var soap = "5c13cd2486f774072c757944";
            fluentAssortCreator
                .CreateSingleAssortItem(magpulUbrGen2StockBlack)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(3)
                .AddBarterCost(bleach, 1)
                .AddBarterCost(soap, 1)
                .AddLoyaltyLevel(3)
                .Export(TraderIds.Peacekeeper, questName);

            var svdsRotor43ThreadAdapter = "5e01e9e273d8eb11426f5bc3";
            var wd40Small = "590c5bbd86f774785762df04";
            fluentAssortCreator
                .CreateSingleAssortItem(svdsRotor43ThreadAdapter)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(1)
                .AddBarterCost(wd40Small, 2)
                .AddLoyaltyLevel(3)
                .Export(TraderIds.Mechanic, questName);

            var rotor43SoundSupressor762x54R = "5e01ea19e9dc277128008c0b";
            var book = "5bc9c049d4351e3bac122519";
            fluentAssortCreator
                .CreateSingleAssortItem(rotor43SoundSupressor762x54R)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(1)
                .AddBarterCost(book, 1)
                .AddLoyaltyLevel(3)
                .Export(TraderIds.Skier, questName);

            var marchTacticalFFP30mmRiflescope = "57c5ac0824597754771e88a9";
            var sugar = "59e3577886f774176a362503";
            fluentAssortCreator
                .CreateSingleAssortItem(marchTacticalFFP30mmRiflescope)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(1)
                .AddBarterCost(sugar, 3)
                .AddLoyaltyLevel(4)
                .Export(TraderIds.Jaeger, questName);
        }
    }

    public void AddGunsmithTwentyBarters()
    {
        var questName = "Gunsmith - Part 20";
        if (_config.AddAttachmentBarters)
        {
            var m1a20RoundMagazine = "5aaf8a0be5b5b00015693243";
            var huntingMatches = "5e2af2bc86f7746d3f3c33fc";
            fluentAssortCreator
                .CreateSingleAssortItem(m1a20RoundMagazine)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(2)
                .AddBarterCost(huntingMatches, 2)
                .AddLoyaltyLevel(2)
                .Export(TraderIds.Peacekeeper, questName);

            var aimpointMicroT1ReflexSight = "58d399e486f77442e0016fe7";
            var zibboLighter = "56742c2e4bdc2d95058b456d";
            fluentAssortCreator
                .CreateSingleAssortItem(aimpointMicroT1ReflexSight)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(3)
                .AddBarterCost(zibboLighter, 2)
                .AddLoyaltyLevel(2)
                .Export(TraderIds.Peacekeeper, questName);

            var aimpointMicroStandardMount = "58d39d3d86f77445bb794ae7";
            var crickentlighter = "56742c284bdc2d98058b456d";
            fluentAssortCreator
                .CreateSingleAssortItem(aimpointMicroStandardMount)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(1)
                .AddBarterCost(crickentlighter, 1)
                .AddLoyaltyLevel(1)
                .Export(TraderIds.Mechanic, questName);

            var holosunLs321TacticalDevice = "57fd23e32459772d0805bcf1";
            var tarCola = "57514643245977207f2c2d09";
            fluentAssortCreator
                .CreateSingleAssortItem(holosunLs321TacticalDevice)
                .AddUnlimitedStackCount()
                .AddBuyRestriction(2)
                .AddBarterCost(tarCola, 2)
                .AddLoyaltyLevel(3)
                .Export(TraderIds.Skier, questName);
        }
    }
}
