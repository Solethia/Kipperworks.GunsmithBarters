using SPTarkov.DI.Annotations;
using SPTarkov.Server.Core.DI;
using SPTarkov.Server.Core.Helpers;
using SPTarkov.Server.Core.Models.Common;
using SPTarkov.Server.Core.Models.Eft.Common.Tables;
using SPTarkov.Server.Core.Models.Enums;
using SPTarkov.Server.Core.Models.Utils;
using SPTarkov.Server.Core.Services;

namespace Kipperworks.GunsmithBarters;

[Injectable(TypePriority = OnLoadOrder.PostDBModLoader + 1)]
public class FluentTraderAssortCreator(
    DatabaseService databaseService,
    ISptLogger<FluentTraderAssortCreator> logger,
    ItemHelper itemHelper,
    QuestHelper questHelper)
{
    private readonly List<Item> _ItemsToSell = [];
    private readonly Dictionary<string, List<List<BarterScheme>>> _BarterScheme = [];
    private readonly Dictionary<string, int> _LoyaltyLevel = new();
    private readonly List<Quest> _QuestRestrictions = [];

    private bool _Debug;

    public void SetDebug(bool debug)
    {
        _Debug = debug;
    }

    public FluentTraderAssortCreator CreateSingleAssortItem(MongoId itemTpl, MongoId? itemId = null)
    {
        var newItemToAdd = new Item
        {
            Id = itemId ?? new MongoId(),
            Template = itemTpl,
            ParentId = "hideout",
            SlotId = "hideout",
            Upd = new Upd
            {
                UnlimitedCount = false,
                StackObjectsCount = 100
            }
        };

        _ItemsToSell.Add(newItemToAdd);

        return this;
    }

    public FluentTraderAssortCreator CreateComplexAssortItem(List<Item> items)
    {
        items[0].ParentId = "hideout";
        items[0].SlotId = "hideout";

        var upd = items[0].Upd ??= new Upd();

        upd.UnlimitedCount = false;
        upd.StackObjectsCount = 100;

        _ItemsToSell.AddRange(items);

        return this;
    }

    public FluentTraderAssortCreator AddStackCount(int stackCount)
    {
        GetRootItemUpd().StackObjectsCount = stackCount;

        return this;
    }

    public FluentTraderAssortCreator AddUnlimitedStackCount()
    {
        var upd = GetRootItemUpd();
        upd.StackObjectsCount = 999999;
        upd.UnlimitedCount = true;

        return this;
    }

    public FluentTraderAssortCreator MakeStackCountUnlimited()
    {
        GetRootItemUpd().StackObjectsCount = 999999;

        return this;
    }

    public FluentTraderAssortCreator AddBuyRestriction(int maxBuyLimit)
    {
        var upd = GetRootItemUpd();
        upd.BuyRestrictionMax = maxBuyLimit;
        upd.BuyRestrictionCurrent = 0;

        return this;
    }

    public FluentTraderAssortCreator AddQuestRestriction(Quest quest)
    {
        _QuestRestrictions.Add(quest);

        return this;
    }

    public FluentTraderAssortCreator AddLoyaltyLevel(int level)
    {
        _LoyaltyLevel[_ItemsToSell[0].Id] = level;

        return this;
    }

    public FluentTraderAssortCreator AddMoneyCost(string currencyType, int amount)
    {
        var dataToAdd = new BarterScheme
        {
            Count = amount,
            Template = currencyType
        };

        if (!_BarterScheme.TryAdd(_ItemsToSell[0].Id, [[dataToAdd]]))
        {
            logger.Warning($"Unable to add barter scheme currency: {currencyType}");
        }

        return this;
    }

    public FluentTraderAssortCreator AddBarterCost(MongoId itemTpl, int count)
    {
        var sellableItemId = _ItemsToSell[0].Id;

        if (_BarterScheme.Count == 0)
        {
            var dataToAdd = new BarterScheme
            {
                Count = count,
                Template = itemTpl
            };

            _BarterScheme[sellableItemId] = [[dataToAdd]];
        }
        else
        {
            var existingData = _BarterScheme[sellableItemId][0].FirstOrDefault(x => x.Template == itemTpl);
            if (existingData is not null)
            {
                existingData.Count += count;
            }
            else
            {
                _BarterScheme[sellableItemId][0].Add(new BarterScheme
                {
                    Count = count,
                    Template = itemTpl
                });
            }
        }

        return this;
    }

    public FluentTraderAssortCreator? Export(string traderId, string gunsmithQuestName = "")
    {
        var traderData = databaseService.GetTables().Traders.GetValueOrDefault(traderId);
        if (traderData is null)
        {
            logger.Error($"Unable to find trader with id: {traderId}");

            ClearState();
            return null;
        }

        var itemBeingSold = _ItemsToSell[0];
        var rootItemAddedId = itemBeingSold.Id;
        var loyaltyLevel = _LoyaltyLevel[rootItemAddedId];
        var barterSchemes = _BarterScheme[rootItemAddedId];

        if (traderData.Assort.Items.Exists(x => x.Id == rootItemAddedId))
        {
            logger.Error($"Unable to add complex item with item key: {rootItemAddedId}, key already in use");

            ClearState();
            return null;
        }

        traderData.Assort.Items.AddRange(_ItemsToSell);
        traderData.Assort.BarterScheme[rootItemAddedId] = barterSchemes;
        traderData.Assort.LoyalLevelItems[rootItemAddedId] = loyaltyLevel;

        if (_QuestRestrictions.Count > 0)
        {
            var onQuestSuccessAssort = traderData.QuestAssort["success"];
            foreach (var questRestriction in _QuestRestrictions)
            {
                if (questRestriction.Rewards is null)
                {
                    logger.Warning($"Quest {questRestriction.Id} has no rewards, skipping quest restriction");
                    continue;
                }

                onQuestSuccessAssort[rootItemAddedId] = questRestriction.Id;

                var successRewards = questRestriction.Rewards["Success"];
                var index = successRewards.Count;
                var questReward = new Reward
                {
                    Id = new MongoId(),
                    Index = index,
                    Items =
                    [
                        new Item
                        {
                            Id = itemBeingSold.Id,
                            Template = itemBeingSold.Template
                        }
                    ],
                    LoyaltyLevel = loyaltyLevel,
                    Target = itemBeingSold.Id,
                    TraderId = traderData.Base.Id,
                    Type = RewardType.AssortmentUnlock,
                    Unknown = false
                };
                successRewards.Add(questReward);
            }
        }

        if (_Debug)
        {
            LogExport(gunsmithQuestName, traderData, itemBeingSold, loyaltyLevel, barterSchemes);
        }

        ClearState();
        return this;
    }

    private Upd GetRootItemUpd()
    {
        return _ItemsToSell[0].Upd
            ?? throw new InvalidOperationException("Call CreateSingleAssortItem or CreateComplexAssortItem before modifying item properties.");
    }

    private void ClearState()
    {
        _ItemsToSell.Clear();
        _BarterScheme.Clear();
        _LoyaltyLevel.Clear();
        _QuestRestrictions.Clear();
    }

    private void LogExport(string gunsmithQuestName, Trader trader, Item itemBeingSold, int loyaltyLevel, List<List<BarterScheme>> barterSchemes)
    {
        var itemBeingSoldName = itemHelper.GetItemName(itemBeingSold.Template);
        var barterCostInfo = GetBarterCostInfo(barterSchemes);
        var traderInfo = GetTraderInfo(trader, loyaltyLevel);
        var questRestrictionInfo = GetQuestRestrictionInfo();
        var logExport = $"| {gunsmithQuestName} | {itemBeingSoldName} | {barterCostInfo} | {traderInfo} | {questRestrictionInfo} |";
        logger.Debug(logExport);
    }

    private string GetBarterCostInfo(List<List<BarterScheme>> barterSchemes)
    {
        var source = barterSchemes[0];
        if (source.Count == 0)
            return "";

        return string.Join(", ", source.Select(bs => $"{bs.Count}x{itemHelper.GetItemName(bs.Template)}"));
    }

    private static string GetTraderInfo(Trader trader, int loyaltyLevel)
    {
        return $"{trader.Base.Nickname} LVL{loyaltyLevel}";
    }

    private string GetQuestRestrictionInfo()
    {
        if (_QuestRestrictions.Count == 0)
            return "";

        return string.Join(", ", _QuestRestrictions.Select(q => questHelper.GetQuestNameFromLocale(q.Id)));
    }
}
