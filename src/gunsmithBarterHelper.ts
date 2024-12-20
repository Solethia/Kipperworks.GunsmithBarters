import { IDatabaseTables } from "@spt/models/spt/server/IDatabaseTables";
import { DBTraders } from "./DBTraders";
import { FluentAssortConstructor as FluentAssortCreator } from "./fluentTraderAssortCreator";
import { GunBuilder } from "./gunBuilder";
import { GunsmithBartersConfig } from "./GunsmithBartersConfig";
import { IQuest } from "@spt/models/eft/common/tables/IQuest";

export class GunsmithBarterHelper
{
    private fluentAssortCreator: FluentAssortCreator;
    private gunBuilder: GunBuilder;
    private traders: DBTraders;
    private quests: Record<string, IQuest>;
    private config: GunsmithBartersConfig;
    constructor(fluentAssortCreator: FluentAssortCreator, tables: IDatabaseTables, config: GunsmithBartersConfig)
    {
        this.fluentAssortCreator = fluentAssortCreator;
        this.gunBuilder = new GunBuilder();
        this.traders = new DBTraders(tables);
        this.quests = tables.templates.quests;
        this.config = config;
    }

    public addGunsmithOneBarters(): void
    {
        const plasticPistolGrip = "56083a334bdc2dc8488b4571";
        const ramStick = "57347baf24597738002c6178";
        this.fluentAssortCreator
            .createSingleAssortItem(plasticPistolGrip)
            .addUnlimitedStackCount()
            .addBuyRestriction(2)
            .addBarterCost(ramStick, 1)
            .addLoyaltyLevel(1)
            .export(this.traders.jaeger);

        const ncStarTacticalBlueLaser = "5cc9c20cd7f00c001336c65d";
        const hotrod = "5751496424597720a27126da";
        this.fluentAssortCreator
            .createSingleAssortItem(ncStarTacticalBlueLaser)
            .addUnlimitedStackCount()
            .addBuyRestriction(1)
            .addBarterCost(hotrod, 1)
            .addLoyaltyLevel(1)
            .export(this.traders.skier);
    }

    public addGunsmithTwoBarters(): void
    {
        const kacVerticalForegrip = "5c87ca002e221600114cb150";
        const flatScrewdriver = "5d63d33b86f7746ea9275524";
        this.fluentAssortCreator
            .createSingleAssortItem(kacVerticalForegrip)
            .addUnlimitedStackCount()
            .addBuyRestriction(3)
            .addBarterCost(flatScrewdriver, 2)
            .addLoyaltyLevel(1)
            .export(this.traders.peacekeeper);
    }

    public addGunsmithThreeBarters(): void
    {
        // There are barters for everything already
    }

    public addGunsmithFourBarters(): void
    {
        const sksChoateScopeMount = "6415d33eda439c6a97048b5b";
        const survLSurvivorLighter = "5e2af37686f774755a234b65";
        const crickentlighter = "56742c284bdc2d98058b456d";
        this.fluentAssortCreator
            .createSingleAssortItem(sksChoateScopeMount)
            .addUnlimitedStackCount()
            .addBuyRestriction(1)
            .addBarterCost(survLSurvivorLighter, 1)
            .addBarterCost(crickentlighter, 1)
            .addLoyaltyLevel(2)
            .export(this.traders.jaeger);

        const vomzPiladRiflescope = "5dff772da3651922b360bf91";
        const bottleOfWater = "5448fee04bdc2dbc018b4567";
        this.fluentAssortCreator
            .createSingleAssortItem(vomzPiladRiflescope)
            .addUnlimitedStackCount()
            .addBuyRestriction(1)
            .addBarterCost(bottleOfWater, 2)
            .addLoyaltyLevel(1)
            .export(this.traders.jaeger);

        const leapersScopeMount = "5dff77c759400025ea5150cf";
        const hawkGunpowder = "5d6fc87386f77449db3db94e";
        this.fluentAssortCreator
            .createSingleAssortItem(leapersScopeMount)
            .addUnlimitedStackCount()
            .addBuyRestriction(1)
            .addBarterCost(hawkGunpowder, 1)
            .addLoyaltyLevel(1)
            .export(this.traders.jaeger);


        const sksTapcoIntrafuseBufferTube = "5afd7e095acfc40017541f61";
        const pineappleJuice = "544fb62a4bdc2dfb738b4568";
        this.fluentAssortCreator
            .createSingleAssortItem(sksTapcoIntrafuseBufferTube)
            .addUnlimitedStackCount()
            .addBuyRestriction(1)
            .addBarterCost(pineappleJuice, 1)
            .addLoyaltyLevel(1)
            .export(this.traders.mechanic);

        const sksTapcoIntrafuseSawStylePistolGrip = "5afd7e445acfc4001637e35a";
        const wilstonCigarette = "573476f124597737e04bf328";
        this.fluentAssortCreator
            .createSingleAssortItem(sksTapcoIntrafuseSawStylePistolGrip)
            .addUnlimitedStackCount()
            .addBuyRestriction(1)
            .addBarterCost(wilstonCigarette, 1)
            .addLoyaltyLevel(1)
            .export(this.traders.mechanic);

        const sksHexagonSoundSupressor = "593d490386f7745ee97a1555";
        const electricMotor = "5d1b2fa286f77425227d1674";
        this.fluentAssortCreator
            .createSingleAssortItem(sksHexagonSoundSupressor)
            .addUnlimitedStackCount()
            .addBuyRestriction(1)
            .addBarterCost(electricMotor, 1)
            .addLoyaltyLevel(3)
            .export(this.traders.skier);
    }

    public addGunsmithFiveBarters(): void
    {
        // Already has barter for the gun, but with wrong barrel so we add the barrel
        const m870Remington508mmBarrel = "5a787f7ac5856700177af660";
        const strikeCigaretts = "5734770f24597738025ee254";
        const wilstonCigarettes = "573476f124597737e04bf328";
        this.fluentAssortCreator
            .createSingleAssortItem(m870Remington508mmBarrel)
            .addUnlimitedStackCount()
            .addBuyRestriction(1)
            .addBarterCost(strikeCigaretts, 2)
            .addBarterCost(wilstonCigarettes, 2)
            .addLoyaltyLevel(1)
            .export(this.traders.mechanic);

        const cylinderTwelveGagueMuzzleAdapter = "5c0111ab0db834001966914d";
        const saury = "5673de654bdc2d180f8b456d";
        this.fluentAssortCreator
            .createSingleAssortItem(cylinderTwelveGagueMuzzleAdapter)
            .addUnlimitedStackCount()
            .addBuyRestriction(2)
            .addBarterCost(saury, 1)
            .addLoyaltyLevel(1)
            .export(this.traders.jaeger);

        const gkTwoMuzzleBreak = "58272d7f2459774f6311ddfd";
        const electronicComponents = "6389c70ca33d8c4cdf4932c6";
        const printedCircuitBoard = "590a3b0486f7743954552bdb";
        this.fluentAssortCreator
            .createSingleAssortItem(gkTwoMuzzleBreak)
            .addUnlimitedStackCount()
            .addBuyRestriction(2)
            .addBarterCost(electronicComponents, 1)
            .addBarterCost(printedCircuitBoard, 1)
            .addLoyaltyLevel(2)
            .export(this.traders.jaeger);
    }

    public addGunsmithSixBarters(): void
    {
        const fortisShift = "59f8a37386f7747af3328f06";
        const woodenClock = "59e3647686f774176a362507";
        this.fluentAssortCreator
            .createSingleAssortItem(fortisShift)
            .addUnlimitedStackCount()
            .addBuyRestriction(1)
            .addBarterCost(woodenClock, 1)
            .addLoyaltyLevel(4)
            .export(this.traders.peacekeeper);

        const akTapcoSawStyleblackPistolGrip = "5947f92f86f77427344a76b1";
        const capacitors = "5c06782b86f77426df5407d2";
        this.fluentAssortCreator
            .createSingleAssortItem(akTapcoSawStyleblackPistolGrip)
            .addUnlimitedStackCount()
            .addBuyRestriction(1)
            .addBarterCost(capacitors, 3)
            .addLoyaltyLevel(2)
            .export(this.traders.mechanic);

        const akMagpulPmagMagazine = "59d6272486f77466146386ff";
        const herring = "57347d9c245977448b40fa85";
        this.fluentAssortCreator
            .createSingleAssortItem(akMagpulPmagMagazine)
            .addUnlimitedStackCount()
            .addBuyRestriction(4)
            .addBarterCost(herring, 1)
            .addLoyaltyLevel(2)
            .export(this.traders.peacekeeper);

        const akMagpulMoeAkmHandguardFde = "57cffd8224597763b03fc609";
        const bottleOfVodka = "5d40407c86f774318526545a";
        this.fluentAssortCreator
            .createSingleAssortItem(akMagpulMoeAkmHandguardFde)
            .addUnlimitedStackCount()
            .addBuyRestriction(1)
            .addBarterCost(bottleOfVodka, 1)
            .addLoyaltyLevel(2)
            .export(this.traders.peacekeeper);

        const akAkedemiaBastionDustCover = "5d2c76ed48f03532f2136169";
        const pevkoLightBeer = "62a09f32621468534a797acb";
        this.fluentAssortCreator
            .createSingleAssortItem(akAkedemiaBastionDustCover)
            .addUnlimitedStackCount()
            .addBuyRestriction(1)
            .addBarterCost(pevkoLightBeer, 1)
            .addLoyaltyLevel(1)
            .export(this.traders.skier);

        const trijiconTA51SightMount = "59db7eed86f77461f8380365";
        this.fluentAssortCreator
            .createSingleAssortItem(trijiconTA51SightMount)
            .addUnlimitedStackCount()
            .addBuyRestriction(1)
            .addBarterCost(capacitors, 1)
            .addLoyaltyLevel(2)
            .export(this.traders.peacekeeper);

        const trijiconAcogTA11D = "59db7e1086f77448be30ddf3";
        const ssdDrive = "590c392f86f77444754deb29";
        this.fluentAssortCreator
            .createSingleAssortItem(trijiconAcogTA11D)
            .addUnlimitedStackCount()
            .addBuyRestriction(1)
            .addBarterCost(ssdDrive, 1)
            .addLoyaltyLevel(2)
            .export(this.traders.peacekeeper);
    }

    public addGunsmithSevenBarters(): void
    {
        const krissDefianceStockBlack = "5fbbaa86f9986c4cff3fe5f6";
        const nails = "590c31c586f774245e3141b2";
        const powerbank = "5af0561e86f7745f5f3ad6ac";
        this.fluentAssortCreator
            .createSingleAssortItem(krissDefianceStockBlack)
            .addUnlimitedStackCount()
            .addBuyRestriction(2)
            .addBarterCost(nails, 1)
            .addBarterCost(powerbank, 1)
            .addLoyaltyLevel(2)
            .export(this.traders.peacekeeper);

        const magpulMoeSlCarbineLenghtMlokHandguard = "5c78f2792e221600106f4683";
        const wires = "5c06779c86f77426e00dd782";
        const roundPliers = "5d1b31ce86f7742523398394";
        this.fluentAssortCreator
            .createSingleAssortItem(magpulMoeSlCarbineLenghtMlokHandguard)
            .addUnlimitedStackCount()
            .addBuyRestriction(2)
            .addBarterCost(wires, 1)
            .addBarterCost(roundPliers, 1)
            .addLoyaltyLevel(1)
            .export(this.traders.skier);

        const windhamGasBlock = "56ea8d2fd2720b7c698b4570";
        const usbAdapter = "5909e99886f7740c983b9984";
        const rechargableBattery = "590a358486f77429692b2790";
        this.fluentAssortCreator
            .createSingleAssortItem(windhamGasBlock)
            .addUnlimitedStackCount()
            .addBuyRestriction(4)
            .addBarterCost(usbAdapter, 1)
            .addBarterCost(rechargableBattery, 1)
            .addLoyaltyLevel(1)
            .export(this.traders.mechanic);

        const danielDefenceVerticalForegripBlack = "651a8bf3a8520e48047bf708";
        const brokenLcd = "5d1b309586f77425227d1676";
        this.fluentAssortCreator
            .createSingleAssortItem(danielDefenceVerticalForegripBlack)
            .addUnlimitedStackCount()
            .addBuyRestriction(1)
            .addBarterCost(brokenLcd, 1)
            .addLoyaltyLevel(2)
            .export(this.traders.peacekeeper);

        const surefireWarCompFlashHider = "5c6d710d2e22165df16b81e7";
        const cyclonRechargableBattery = "5e2aee0a86f774755a234b62";
        this.fluentAssortCreator
            .createSingleAssortItem(surefireWarCompFlashHider)
            .addUnlimitedStackCount()
            .addBuyRestriction(1)
            .addBarterCost(cyclonRechargableBattery, 2)
            .addLoyaltyLevel(2)
            .export(this.traders.skier);
    }

    public addGunsmithEightBarters(): void
    {
        const aks74nDefault = this.gunBuilder.getAks74nDefault();
        const soap = "5c13cd2486f774072c757944";
        const weaponParts = "5d1c819a86f774771b0acd6c";
        this.fluentAssortCreator.createComplexAssortItem(aks74nDefault)
            .addUnlimitedStackCount()
            .addBarterCost(soap, 2)
            .addBarterCost(weaponParts, 1)
            .addBuyRestriction(2)
            .addLoyaltyLevel(2)
            .export(this.traders.prapor);

        // Most of the attachments are on the AK-74M barter from Mechanic level 3 so we only add the things you cant get from that barter.
        const zenitRk0TacticalForegrip = "5c1bc4812e22164bef5cfde7";
        const alyonkaChocolate = "57505f6224597709a92585a9";
        const slickersChocolate = "544fb6cc4bdc2d34748b456e";
        this.fluentAssortCreator
            .createSingleAssortItem(zenitRk0TacticalForegrip)
            .addUnlimitedStackCount()
            .addBuyRestriction(2)
            .addBarterCost(alyonkaChocolate, 1)
            .addBarterCost(slickersChocolate, 1)
            .addLoyaltyLevel(3)
            .export(this.traders.skier);

        const ak12Magazine = "5bed61680db834001d2c45ab";
        const pliers = "590c2b4386f77425357b6123";
        this.fluentAssortCreator
            .createSingleAssortItem(ak12Magazine)
            .addUnlimitedStackCount()
            .addBuyRestriction(1)
            .addBarterCost(pliers, 2)
            .addLoyaltyLevel(3)
            .export(this.traders.prapor);

        const zenitKleschIksIrIlluminator = "5a5f1ce64f39f90b401987bc";
        const phaseControlRelay = "5d1b313086f77425227d1678";
        this.fluentAssortCreator
            .createSingleAssortItem(zenitKleschIksIrIlluminator)
            .addUnlimitedStackCount()
            .addBuyRestriction(2)
            .addBarterCost(phaseControlRelay, 1)
            .addLoyaltyLevel(2)
            .export(this.traders.skier);
    }

    public addGunsmithNineBarters(): void
    {
        const p226TjCustomCompensator = "5c6beec32e221601da3578f2";
        const sparkPlug = "590a3c0a86f774385a33c450";
        this.fluentAssortCreator
            .createSingleAssortItem(p226TjCustomCompensator)
            .addUnlimitedStackCount()
            .addBuyRestriction(1)
            .addBarterCost(sparkPlug, 1)
            .addLoyaltyLevel(1)
            .export(this.traders.mechanic);

        const p226ThreadedBarrel = "587de4282459771bca0ec90b";
        const gPhone = "56742c324bdc2d150f8b456d";
        this.fluentAssortCreator
            .createSingleAssortItem(p226ThreadedBarrel)
            .addUnlimitedStackCount()
            .addBuyRestriction(1)
            .addBarterCost(gPhone, 1)
            .addLoyaltyLevel(1)
            .export(this.traders.peacekeeper);
    }

    public addGunsmithTenBarters(): void
    {
        if (this.config.addGunBarters)
        {
            const ak105Default = this.gunBuilder.getAk105Default();
            const hawkGunpoweder = "5d6fc87386f77449db3db94e";
            const weaponParts = "5d1c819a86f774771b0acd6c";
            this.fluentAssortCreator.createComplexAssortItem(ak105Default)
                .addUnlimitedStackCount()
                .addBarterCost(hawkGunpoweder, 1)
                .addBarterCost(weaponParts, 2)
                .addBuyRestriction(1)
                .addLoyaltyLevel(3)
                .export(this.traders.prapor);
        }

        if (this.config.addAttachmentBarters)
        {
            const prapor = this.traders.prapor;
            const ak100seriesPolymerHandguard = "5cbda392ae92155f3c17c39f";
            const bolts = "57347c5b245977448d35f6e1";
            const largeBeefStew = "57347da92459774491567cf5";
            const gunsmithPartTwo = this.quests["5ac2426c86f774138762edfe"];
            this.fluentAssortCreator
                .createSingleAssortItem(ak100seriesPolymerHandguard)
                .addUnlimitedStackCount()
                .addBuyRestriction(2)
                .addQuestRestriction(gunsmithPartTwo)
                .addBarterCost(bolts, 1)
                .addBarterCost(largeBeefStew, 1)
                .addLoyaltyLevel(1)
                .export(prapor);

            const ak100ZenitPtLock = "5ac78eaf5acfc4001926317a";
            const powerCord = "59e36c6f86f774176c10a2a7";
            this.fluentAssortCreator
                .createSingleAssortItem(ak100ZenitPtLock)
                .addUnlimitedStackCount()
                .addBuyRestriction(1)
                .addBarterCost(powerCord, 1)
                .addLoyaltyLevel(2)
                .export(this.traders.skier);

            const akZenitPt1KlassikaStock = "5b222d405acfc400153af4fe";
            const analogThermometer = "5d1b32c186f774252167a530";
            this.fluentAssortCreator
                .createSingleAssortItem(akZenitPt1KlassikaStock)
                .addUnlimitedStackCount()
                .addBuyRestriction(1)
                .addBarterCost(analogThermometer, 1)
                .addLoyaltyLevel(2)
                .export(this.traders.skier);
        }
    }

    public addGunsmithEllevenBarters(): void
    {
        const krissVector19x9Default = this.gunBuilder.getKrissVector19x9Default();
        const lightBulb = "5d1b392c86f77425243e98fe";
        const pressureGauge = "5d1b327086f7742525194449";
        const vitaminsPartTwoQuest = this.quests["5b478ff486f7744d184ecbbf"];
        this.fluentAssortCreator.createComplexAssortItem(krissVector19x9Default)
            .addUnlimitedStackCount()
            .addBarterCost(lightBulb, 4)
            .addBarterCost(pressureGauge, 2)
            .addBuyRestriction(1)
            .addQuestRestriction(vitaminsPartTwoQuest)
            .addLoyaltyLevel(3)
            .export(this.traders.skier);

        const skeletonizedForegrip = "5f6340d3ca442212f4047eb2";
        const drLupoCoffeeBeans = "5e54f6af86f7742199090bf3";
        this.fluentAssortCreator
            .createSingleAssortItem(skeletonizedForegrip)
            .addUnlimitedStackCount()
            .addBuyRestriction(2)
            .addBarterCost(drLupoCoffeeBeans, 1)
            .addLoyaltyLevel(3)
            .export(this.traders.peacekeeper);

        const coltCarbineBufferTube = "5649be884bdc2d79388b4577";
        this.fluentAssortCreator
            .createSingleAssortItem(coltCarbineBufferTube)
            .addUnlimitedStackCount()
            .addBuyRestriction(1)
            .addBarterCost(lightBulb, 2)
            .addLoyaltyLevel(2)
            .export(this.traders.skier);
    }

    public addGunsmithTwelveBarters(): void
    {
        const steinerFlashlight = "5b07dd285acfc4001754240d";
        const awl = "62a0a098de7ac8199358053b";
        this.fluentAssortCreator
            .createSingleAssortItem(steinerFlashlight)
            .addUnlimitedStackCount()
            .addBuyRestriction(1)
            .addBarterCost(awl, 1)
            .addLoyaltyLevel(3)
            .export(this.traders.mechanic);
    }

    public addGunsmithThirteenBarters(): void
    {
        const remingtonRagh4InchRail = "5c0102b20db834001d23eebc";
        const metalSpareParts = "61bf7b6302b3924be92fa8c3";
        this.fluentAssortCreator
            .createSingleAssortItem(remingtonRagh4InchRail)
            .addUnlimitedStackCount()
            .addBuyRestriction(2)
            .addBarterCost(metalSpareParts, 1)
            .addLoyaltyLevel(2)
            .export(this.traders.mechanic);

        const kacFoldingRearSight = "5c1780312e221602b66cc189";
        const zibboLighter = "56742c2e4bdc2d95058b456d";
        this.fluentAssortCreator
            .createSingleAssortItem(kacFoldingRearSight)
            .addUnlimitedStackCount()
            .addBuyRestriction(1)
            .addBarterCost(zibboLighter, 1)
            .addLoyaltyLevel(2)
            .export(this.traders.peacekeeper);

        const kacFoldingFrontSight = "5c17804b2e2216152006c02f";
        this.fluentAssortCreator
            .createSingleAssortItem(kacFoldingFrontSight)
            .addUnlimitedStackCount()
            .addBuyRestriction(1)
            .addBarterCost(zibboLighter, 1)
            .addLoyaltyLevel(2)
            .export(this.traders.peacekeeper);

        const firearmsSkeletonizedStyle01PistolGrip = "6113c3586c780c1e710c90bc";
        const beardOil = "5bc9b9ecd4351e3bac122519";
        const chainlet = "573474f924597738002c6174";
        this.fluentAssortCreator
            .createSingleAssortItem(firearmsSkeletonizedStyle01PistolGrip)
            .addUnlimitedStackCount()
            .addBuyRestriction(1)
            .addBarterCost(beardOil, 1)
            .addBarterCost(chainlet, 1)
            .addLoyaltyLevel(3)
            .export(this.traders.skier);
    }

    public addGunsmithFourteenBarters(): void
    {
        const hk416a5Default = this.gunBuilder.getHk416a5Default();
        const cpuFan = "5734779624597737e04bf329";
        const cpu = "573477e124597737dd42e191";
        const wetJobPartThree = this.quests["5a27bc1586f7741f6d40fa2f"];
        this.fluentAssortCreator.createComplexAssortItem(hk416a5Default)
            .addUnlimitedStackCount()
            .addBarterCost(cpuFan, 4)
            .addBarterCost(cpu, 2)
            .addBuyRestriction(1)
            .addQuestRestriction(wetJobPartThree)
            .addLoyaltyLevel(3)
            .export(this.traders.peacekeeper);

        const magpulMlokCantileverMount = "6269220d70b6c02e665f2635";
        const rechargableBattery = "590a358486f77429692b2790";
        this.fluentAssortCreator
            .createSingleAssortItem(magpulMlokCantileverMount)
            .addUnlimitedStackCount()
            .addBuyRestriction(2)
            .addBarterCost(rechargableBattery, 1)
            .addLoyaltyLevel(2)
            .export(this.traders.skier);

        const magpulMoePistolGrip = "5d15cf3bd7ad1a67e71518b2";
        const powerSupplyUnit = "57347c2e24597744902c94a1";
        this.fluentAssortCreator
            .createSingleAssortItem(magpulMoePistolGrip)
            .addUnlimitedStackCount()
            .addBuyRestriction(1)
            .addBarterCost(powerSupplyUnit, 1)
            .addLoyaltyLevel(3)
            .export(this.traders.peacekeeper);

        const magpulUbrGen2StockFde = "5947eab886f77475961d96c5";
        const workingLcd = "5d1b304286f774253763a528";
        this.fluentAssortCreator
            .createSingleAssortItem(magpulUbrGen2StockFde)
            .addUnlimitedStackCount()
            .addBuyRestriction(1)
            .addBarterCost(workingLcd, 1)
            .addLoyaltyLevel(3)
            .export(this.traders.peacekeeper);

        const magpulRvgForegripFde = "5fce0cf655375d18a253eff0";
        const screwdriver = "590c2d8786f774245b1f03f3";
        const ductTape = "57347c1124597737fb1379e3";
        this.fluentAssortCreator
            .createSingleAssortItem(magpulRvgForegripFde)
            .addUnlimitedStackCount()
            .addBuyRestriction(1)
            .addBarterCost(screwdriver, 1)
            .addBarterCost(ductTape, 3)
            .addLoyaltyLevel(3)
            .export(this.traders.peacekeeper);

        const l3HarrisLa5bPeqTacticalDevice = "5c06595c0db834001a66af6c";
        const electronicComponents = "6389c70ca33d8c4cdf4932c6";
        this.fluentAssortCreator
            .createSingleAssortItem(l3HarrisLa5bPeqTacticalDevice)
            .addUnlimitedStackCount()
            .addBuyRestriction(1)
            .addBarterCost(electronicComponents, 1)
            .addLoyaltyLevel(4)
            .export(this.traders.mechanic);

        const magpulFlipUpRearSightFde = "5c18b9192e2216398b5a8104";
        const nippers = "5d40425986f7743185265461";
        this.fluentAssortCreator
            .createSingleAssortItem(magpulFlipUpRearSightFde)
            .addUnlimitedStackCount()
            .addBuyRestriction(1)
            .addBarterCost(nippers, 1)
            .addLoyaltyLevel(2)
            .export(this.traders.mechanic);

        const magpulFlipUpFrontSightFde = "5c18b90d2e2216152142466b";
        this.fluentAssortCreator
            .createSingleAssortItem(magpulFlipUpFrontSightFde)
            .addUnlimitedStackCount()
            .addBuyRestriction(1)
            .addBarterCost(nippers, 1)
            .addLoyaltyLevel(2)
            .export(this.traders.mechanic);

        const eoTechExpHolographicSightTan = "558022b54bdc2dac148b458d";
        const toolset = "590c2e1186f77425357b6124";
        this.fluentAssortCreator
            .createSingleAssortItem(eoTechExpHolographicSightTan)
            .addUnlimitedStackCount()
            .addBuyRestriction(1)
            .addBarterCost(toolset, 1)
            .addLoyaltyLevel(4)
            .export(this.traders.mechanic);
    }

    public addGunsmithFifteenBarters(): void
    {
        const asValDefault = this.gunBuilder.getAsValDefault();
        const pressureGauge = "5d1b327086f7742525194449";
        const kekTape = "5e2af29386f7746d4159f077";
        this.fluentAssortCreator.createComplexAssortItem(asValDefault)
            .addUnlimitedStackCount()
            .addBarterCost(pressureGauge, 1)
            .addBarterCost(kekTape, 4)
            .addBuyRestriction(1)
            .addLoyaltyLevel(4)
            .export(this.traders.prapor);

        const dovetailNightVisionScope = "5a7c74b3e899ef0014332c29";
        const strikeCigarettes = "5734770f24597738025ee254";
        this.fluentAssortCreator
            .createSingleAssortItem(dovetailNightVisionScope)
            .addUnlimitedStackCount()
            .addBuyRestriction(2)
            .addBarterCost(strikeCigarettes, 2)
            .addLoyaltyLevel(1)
            .export(this.traders.prapor);

        const valZenitB3RingMount = "57a3459f245977764a01f703";
        const goldChain = "5734758f24597738025ee253";
        this.fluentAssortCreator
            .createSingleAssortItem(valZenitB3RingMount)
            .addUnlimitedStackCount()
            .addBuyRestriction(1)
            .addBarterCost(goldChain, 1)
            .addLoyaltyLevel(3)
            .export(this.traders.skier);
    }


    public addGunsmithSixteenBarters(): void
    {
        // Barters already exists
    }

    public addGunsmithSeventeenBarters(): void
    {
        const ak102Default = this.gunBuilder.getAk102Default();
        const longFlatScrewdriver = "5d4042a986f7743185265463";
        const shortFlatScrewdriver = "5d63d33b86f7746ea9275524";
        const strikeCigarettes = "5734770f24597738025ee254";
        this.fluentAssortCreator.createComplexAssortItem(ak102Default)
            .addUnlimitedStackCount()
            .addBarterCost(longFlatScrewdriver, 2)
            .addBarterCost(shortFlatScrewdriver, 2)
            .addBarterCost(strikeCigarettes, 2)
            .addBuyRestriction(1)
            .addLoyaltyLevel(3)
            .export(this.traders.mechanic);

        const akCncWarrirorMuzzleDeviceAdapter = "5e21ca18e4d47f0da15e77dd";
        this.fluentAssortCreator
            .createSingleAssortItem(akCncWarrirorMuzzleDeviceAdapter)
            .addUnlimitedStackCount()
            .addBuyRestriction(2)
            .addBarterCost(strikeCigarettes, 3)
            .addLoyaltyLevel(3)
            .export(this.traders.mechanic);

        const rpk16BufferTube = "5beec8b20db834001961942a";
        const pliers = "590c2b4386f77425357b6123";
        this.fluentAssortCreator
            .createSingleAssortItem(rpk16BufferTube)
            .addUnlimitedStackCount()
            .addBuyRestriction(1)
            .addBarterCost(pliers, 2)
            .addLoyaltyLevel(3)
            .export(this.traders.mechanic);

        const akZenithB10MHandguard = "5648b4534bdc2d3d1c8b4580";
        const dvdDrive = "5734781f24597737e04bf32a";
        const nails = "590c31c586f774245e3141b2";
        this.fluentAssortCreator
            .createSingleAssortItem(akZenithB10MHandguard)
            .addUnlimitedStackCount()
            .addBuyRestriction(1)
            .addBarterCost(dvdDrive, 1)
            .addBarterCost(nails, 1)
            .addLoyaltyLevel(3)
            .export(this.traders.skier);

        const magpulAfgTacticalForegripOliveDrap = "588226ef24597767af46e39c";
        const phaseControlRelay = "5d1b313086f77425227d1678";
        this.fluentAssortCreator
            .createSingleAssortItem(magpulAfgTacticalForegripOliveDrap)
            .addUnlimitedStackCount()
            .addBuyRestriction(1)
            .addBarterCost(phaseControlRelay, 2)
            .addLoyaltyLevel(3)
            .export(this.traders.mechanic);

        const zenitKlesch2UTacticalFlashlight = "5b3a337e5acfc4704b4a19a0";
        const lightBulb = "5d1b392c86f77425243e98fe";
        this.fluentAssortCreator
            .createSingleAssortItem(zenitKlesch2UTacticalFlashlight)
            .addUnlimitedStackCount()
            .addBuyRestriction(1)
            .addBarterCost(lightBulb, 2)
            .addLoyaltyLevel(3)
            .export(this.traders.mechanic);

        const akCssKnurledChargingHandle = "6130ca3fd92c473c77020dbd";
        const blendTea = "5bc9be8fd4351e00334cae6e";
        this.fluentAssortCreator
            .createSingleAssortItem(akCssKnurledChargingHandle)
            .addUnlimitedStackCount()
            .addBuyRestriction(1)
            .addBarterCost(blendTea, 1)
            .addLoyaltyLevel(3)
            .export(this.traders.skier);

        const akZenitB33DustCover = "5649af884bdc2d1b2b8b4589";
        const toolset = "590c2e1186f77425357b6124";
        this.fluentAssortCreator
            .createSingleAssortItem(akZenitB33DustCover)
            .addUnlimitedStackCount()
            .addBuyRestriction(1)
            .addBarterCost(toolset, 1)
            .addLoyaltyLevel(3)
            .export(this.traders.skier);
    }

    public addGunsmithEighteenBarters(): void
    {
        const akmnDefault = this.gunBuilder.getAkmnDefault();
        const canOfGreenPeas = "57347d692459774491567cf1";
        this.fluentAssortCreator.createComplexAssortItem(akmnDefault)
            .addUnlimitedStackCount()
            .addBarterCost(canOfGreenPeas, 4)
            .addBuyRestriction(2)
            .addLoyaltyLevel(3)
            .export(this.traders.prapor);

        const akMagpulMoeAkmHandguardBlack = "57cff947245977638e6f2a19";
        const tarkerDriedMeat = "65815f0e647e3d7246384e14";
        this.fluentAssortCreator
            .createSingleAssortItem(akMagpulMoeAkmHandguardBlack)
            .addUnlimitedStackCount()
            .addBuyRestriction(2)
            .addBarterCost(tarkerDriedMeat, 2)
            .addLoyaltyLevel(3)
            .export(this.traders.mechanic);

        const magpulMlokAfgTacticalForegripBlack = "57cffb66245977632f391a99";
        const ductTape = "57347c1124597737fb1379e3";
        this.fluentAssortCreator
            .createSingleAssortItem(magpulMlokAfgTacticalForegripBlack)
            .addUnlimitedStackCount()
            .addBuyRestriction(3)
            .addBarterCost(ductTape, 3)
            .addLoyaltyLevel(3)
            .export(this.traders.skier);

        const magpulZhukovSStock = "5b0e794b5acfc47a877359b2";
        const geigerMullerCounter = "5672cb724bdc2dc2088b456b";
        this.fluentAssortCreator
            .createSingleAssortItem(magpulZhukovSStock)
            .addUnlimitedStackCount()
            .addBuyRestriction(1)
            .addBarterCost(geigerMullerCounter, 2)
            .addLoyaltyLevel(4)
            .export(this.traders.peacekeeper);
        
        const akMagpulMoePistolGrip = "5b30ac585acfc433000eb79c";
        const powerCord = "59e36c6f86f774176c10a2a7";
        this.fluentAssortCreator
            .createSingleAssortItem(akMagpulMoePistolGrip)
            .addUnlimitedStackCount()
            .addBuyRestriction(1)
            .addBarterCost(powerCord, 2)
            .addLoyaltyLevel(3)
            .export(this.traders.mechanic);

        const eoTechHss1HybridSight = "5c07dd120db834001c39092d";
        const sparkPlug = "590a3c0a86f774385a33c450";
        const workingLcd = "5d1b304286f774253763a528";
        this.fluentAssortCreator
            .createSingleAssortItem(eoTechHss1HybridSight)
            .addUnlimitedStackCount()
            .addBuyRestriction(1)
            .addBarterCost(sparkPlug, 2)
            .addBarterCost(workingLcd, 1)
            .addLoyaltyLevel(4)
            .export(this.traders.peacekeeper);
    }

    public addGunsmithNineteenBarters(): void
    {
        const svdsLynxArmsHingeBufferTubeAdapter = "6197b229af1f5202c57a9bea";
        const mreRationPack = "590c5f0d86f77413997acfab";
        this.fluentAssortCreator
            .createSingleAssortItem(svdsLynxArmsHingeBufferTubeAdapter)
            .addUnlimitedStackCount()
            .addBuyRestriction(2)
            .addBarterCost(mreRationPack, 1)
            .addLoyaltyLevel(2)
            .export(this.traders.jaeger);

        const magpulUbrGen2StockBlack = "5947e98b86f774778f1448bc";
        const bleach = "59e3556c86f7741776641ac2";
        const soap = "5c13cd2486f774072c757944";
        this.fluentAssortCreator
            .createSingleAssortItem(magpulUbrGen2StockBlack)
            .addUnlimitedStackCount()
            .addBuyRestriction(3)
            .addBarterCost(bleach, 1)
            .addBarterCost(soap, 1)
            .addLoyaltyLevel(3)
            .export(this.traders.peacekeeper);

        const svdsRotor43ThreadAdapter = "5e01e9e273d8eb11426f5bc3";
        const wd40Small = "590c5bbd86f774785762df04";
        this.fluentAssortCreator
            .createSingleAssortItem(svdsRotor43ThreadAdapter)
            .addUnlimitedStackCount()
            .addBuyRestriction(1)
            .addBarterCost(wd40Small, 2)
            .addLoyaltyLevel(3)
            .export(this.traders.mechanic);
        
        const rotor43SoundSupressor762x54R = "5e01ea19e9dc277128008c0b";
        const book = "5bc9c049d4351e44f824d360";
        this.fluentAssortCreator
            .createSingleAssortItem(rotor43SoundSupressor762x54R)
            .addUnlimitedStackCount()
            .addBuyRestriction(1)
            .addBarterCost(book, 1)
            .addLoyaltyLevel(3)
            .export(this.traders.skier);

        const marchTacticalFFP30mmRiflescope = "57c5ac0824597754771e88a9";
        const sugar = "59e3577886f774176a362503";
        this.fluentAssortCreator
            .createSingleAssortItem(marchTacticalFFP30mmRiflescope)
            .addUnlimitedStackCount()
            .addBuyRestriction(1)
            .addBarterCost(sugar, 3)
            .addLoyaltyLevel(4)
            .export(this.traders.jaeger);
    }

    public addGunsmithTwentyBarters(): void
    {
        const m1a20RoundMagazine = "5aaf8a0be5b5b00015693243";
        const huntingMatches = "5e2af2bc86f7746d3f3c33fc";
        this.fluentAssortCreator
            .createSingleAssortItem(m1a20RoundMagazine)
            .addUnlimitedStackCount()
            .addBuyRestriction(2)
            .addBarterCost(huntingMatches, 2)
            .addLoyaltyLevel(2)
            .export(this.traders.peacekeeper);

        const aimpointMicroT1ReflexSight = "58d399e486f77442e0016fe7";
        const zibboLighter = "56742c2e4bdc2d95058b456d";
        this.fluentAssortCreator
            .createSingleAssortItem(aimpointMicroT1ReflexSight)
            .addUnlimitedStackCount()
            .addBuyRestriction(3)
            .addBarterCost(zibboLighter, 2)
            .addLoyaltyLevel(2)
            .export(this.traders.peacekeeper);

        const aimpointMicroStandardMount = "58d39d3d86f77445bb794ae7";
        const crickentlighter = "56742c284bdc2d98058b456d";
        this.fluentAssortCreator
            .createSingleAssortItem(aimpointMicroStandardMount)
            .addUnlimitedStackCount()
            .addBuyRestriction(1)
            .addBarterCost(crickentlighter, 1)
            .addLoyaltyLevel(1)
            .export(this.traders.mechanic);

        const holosunLs321TacticalDevice = "57fd23e32459772d0805bcf1";
        const tarCola = "57514643245977207f2c2d09";
        this.fluentAssortCreator
            .createSingleAssortItem(holosunLs321TacticalDevice)
            .addUnlimitedStackCount()
            .addBuyRestriction(2)
            .addBarterCost(tarCola, 2)
            .addLoyaltyLevel(3)
            .export(this.traders.skier);
    }
}