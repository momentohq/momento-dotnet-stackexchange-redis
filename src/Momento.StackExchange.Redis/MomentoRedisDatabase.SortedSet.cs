using System.Collections.Generic;
using System.Threading.Tasks;
using StackExchange.Redis;

namespace Momento.StackExchange.Redis;

public sealed partial class MomentoRedisDatabase : IDatabase
{
    public bool SortedSetAdd(RedisKey key, RedisValue member, double score, CommandFlags flags)
    {
        throw BuildCommandNotImplementedException("SortedSetAdd");
    }

    public bool SortedSetAdd(RedisKey key, RedisValue member, double score, When when, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("SortedSetAdd");
    }

    public bool SortedSetAdd(RedisKey key, RedisValue member, double score, SortedSetWhen when = SortedSetWhen.Always, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("SortedSetAdd");
    }

    public long SortedSetAdd(RedisKey key, SortedSetEntry[] values, CommandFlags flags)
    {
        throw BuildCommandNotImplementedException("SortedSetAdd");
    }

    public long SortedSetAdd(RedisKey key, SortedSetEntry[] values, When when, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("SortedSetAdd");
    }

    public long SortedSetAdd(RedisKey key, SortedSetEntry[] values, SortedSetWhen when = SortedSetWhen.Always, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("SortedSetAdd");
    }

    public Task<bool> SortedSetAddAsync(RedisKey key, RedisValue member, double score, CommandFlags flags)
    {
        throw BuildCommandNotImplementedException("SortedSetAddAsync");
    }

    public Task<bool> SortedSetAddAsync(RedisKey key, RedisValue member, double score, When when, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("SortedSetAddAsync");
    }

    public Task<bool> SortedSetAddAsync(RedisKey key, RedisValue member, double score, SortedSetWhen when = SortedSetWhen.Always, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("SortedSetAddAsync");
    }

    public Task<long> SortedSetAddAsync(RedisKey key, SortedSetEntry[] values, CommandFlags flags)
    {
        throw BuildCommandNotImplementedException("SortedSetAddAsync");
    }

    public Task<long> SortedSetAddAsync(RedisKey key, SortedSetEntry[] values, When when, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("SortedSetAddAsync");
    }

    public Task<long> SortedSetAddAsync(RedisKey key, SortedSetEntry[] values, SortedSetWhen when = SortedSetWhen.Always, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("SortedSetAddAsync");
    }

    public RedisValue[] SortedSetCombine(SetOperation operation, RedisKey[] keys, double[]? weights = null, Aggregate aggregate = Aggregate.Sum, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("SortedSetCombine");
    }

    public long SortedSetCombineAndStore(SetOperation operation, RedisKey destination, RedisKey first, RedisKey second, Aggregate aggregate = Aggregate.Sum, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("SortedSetCombineAndStore");
    }

    public long SortedSetCombineAndStore(SetOperation operation, RedisKey destination, RedisKey[] keys, double[]? weights = null, Aggregate aggregate = Aggregate.Sum, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("SortedSetCombineAndStore");
    }

    public Task<long> SortedSetCombineAndStoreAsync(SetOperation operation, RedisKey destination, RedisKey first, RedisKey second, Aggregate aggregate = Aggregate.Sum, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("SortedSetCombineAndStoreAsync");
    }

    public Task<long> SortedSetCombineAndStoreAsync(SetOperation operation, RedisKey destination, RedisKey[] keys, double[]? weights = null, Aggregate aggregate = Aggregate.Sum, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("SortedSetCombineAndStoreAsync");
    }

    public Task<RedisValue[]> SortedSetCombineAsync(SetOperation operation, RedisKey[] keys, double[]? weights = null, Aggregate aggregate = Aggregate.Sum, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("SortedSetCombineAsync");
    }

    public SortedSetEntry[] SortedSetCombineWithScores(SetOperation operation, RedisKey[] keys, double[]? weights = null, Aggregate aggregate = Aggregate.Sum, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("SortedSetCombineWithScores");
    }

    public Task<SortedSetEntry[]> SortedSetCombineWithScoresAsync(SetOperation operation, RedisKey[] keys, double[]? weights = null, Aggregate aggregate = Aggregate.Sum, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("SortedSetCombineWithScoresAsync");
    }

    public double SortedSetDecrement(RedisKey key, RedisValue member, double value, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("SortedSetDecrement");
    }

    public Task<double> SortedSetDecrementAsync(RedisKey key, RedisValue member, double value, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("SortedSetDecrementAsync");
    }

    public double SortedSetIncrement(RedisKey key, RedisValue member, double value, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("SortedSetIncrement");
    }

    public Task<double> SortedSetIncrementAsync(RedisKey key, RedisValue member, double value, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("SortedSetIncrementAsync");
    }

    public long SortedSetIntersectionLength(RedisKey[] keys, long limit = 0, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("SortedSetIntersectionLength");
    }

    public Task<long> SortedSetIntersectionLengthAsync(RedisKey[] keys, long limit = 0, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("SortedSetIntersectionLengthAsync");
    }

    public long SortedSetLength(RedisKey key, double min = double.NegativeInfinity, double max = double.PositiveInfinity, Exclude exclude = Exclude.None, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("SortedSetLength");
    }

    public Task<long> SortedSetLengthAsync(RedisKey key, double min = double.NegativeInfinity, double max = double.PositiveInfinity, Exclude exclude = Exclude.None, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("SortedSetLengthAsync");
    }

    public long SortedSetLengthByValue(RedisKey key, RedisValue min, RedisValue max, Exclude exclude = Exclude.None, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("SortedSetLengthByValue");
    }

    public Task<long> SortedSetLengthByValueAsync(RedisKey key, RedisValue min, RedisValue max, Exclude exclude = Exclude.None, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("SortedSetLengthByValueAsync");
    }

    public SortedSetEntry? SortedSetPop(RedisKey key, Order order = Order.Ascending, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("SortedSetPop");
    }

    public SortedSetEntry[] SortedSetPop(RedisKey key, long count, Order order = Order.Ascending, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("SortedSetPop");
    }

    public SortedSetPopResult SortedSetPop(RedisKey[] keys, long count, Order order = Order.Ascending, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("SortedSetPop");
    }

    public Task<SortedSetEntry?> SortedSetPopAsync(RedisKey key, Order order = Order.Ascending, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("SortedSetPopAsync");
    }

    public Task<SortedSetEntry[]> SortedSetPopAsync(RedisKey key, long count, Order order = Order.Ascending, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("SortedSetPopAsync");
    }

    public Task<SortedSetPopResult> SortedSetPopAsync(RedisKey[] keys, long count, Order order = Order.Ascending, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("SortedSetPopAsync");
    }

    public RedisValue SortedSetRandomMember(RedisKey key, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("SortedSetRandomMember");
    }

    public Task<RedisValue> SortedSetRandomMemberAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("SortedSetRandomMemberAsync");
    }

    public RedisValue[] SortedSetRandomMembers(RedisKey key, long count, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("SortedSetRandomMembers");
    }

    public Task<RedisValue[]> SortedSetRandomMembersAsync(RedisKey key, long count, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("SortedSetRandomMembersAsync");
    }

    public SortedSetEntry[] SortedSetRandomMembersWithScores(RedisKey key, long count, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("SortedSetRandomMembersWithScores");
    }

    public Task<SortedSetEntry[]> SortedSetRandomMembersWithScoresAsync(RedisKey key, long count, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("SortedSetRandomMembersWithScoresAsync");
    }

    public long SortedSetRangeAndStore(RedisKey sourceKey, RedisKey destinationKey, RedisValue start, RedisValue stop, SortedSetOrder sortedSetOrder = SortedSetOrder.ByRank, Exclude exclude = Exclude.None, Order order = Order.Ascending, long skip = 0, long? take = null, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("SortedSetRangeAndStore");
    }

    public Task<long> SortedSetRangeAndStoreAsync(RedisKey sourceKey, RedisKey destinationKey, RedisValue start, RedisValue stop, SortedSetOrder sortedSetOrder = SortedSetOrder.ByRank, Exclude exclude = Exclude.None, Order order = Order.Ascending, long skip = 0, long? take = null, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("SortedSetRangeAndStoreAsync");
    }

    public RedisValue[] SortedSetRangeByRank(RedisKey key, long start = 0, long stop = -1, Order order = Order.Ascending, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("SortedSetRangeByRank");
    }

    public Task<RedisValue[]> SortedSetRangeByRankAsync(RedisKey key, long start = 0, long stop = -1, Order order = Order.Ascending, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("SortedSetRangeByRankAsync");
    }

    public SortedSetEntry[] SortedSetRangeByRankWithScores(RedisKey key, long start = 0, long stop = -1, Order order = Order.Ascending, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("SortedSetRangeByRankWithScores");
    }

    public Task<SortedSetEntry[]> SortedSetRangeByRankWithScoresAsync(RedisKey key, long start = 0, long stop = -1, Order order = Order.Ascending, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("SortedSetRangeByRankWithScoresAsync");
    }

    public RedisValue[] SortedSetRangeByScore(RedisKey key, double start = double.NegativeInfinity, double stop = double.PositiveInfinity, Exclude exclude = Exclude.None, Order order = Order.Ascending, long skip = 0, long take = -1, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("SortedSetRangeByScore");
    }

    public Task<RedisValue[]> SortedSetRangeByScoreAsync(RedisKey key, double start = double.NegativeInfinity, double stop = double.PositiveInfinity, Exclude exclude = Exclude.None, Order order = Order.Ascending, long skip = 0, long take = -1, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("SortedSetRangeByScoreAsync");
    }

    public SortedSetEntry[] SortedSetRangeByScoreWithScores(RedisKey key, double start = double.NegativeInfinity, double stop = double.PositiveInfinity, Exclude exclude = Exclude.None, Order order = Order.Ascending, long skip = 0, long take = -1, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("SortedSetRangeByScoreWithScores");
    }

    public Task<SortedSetEntry[]> SortedSetRangeByScoreWithScoresAsync(RedisKey key, double start = double.NegativeInfinity, double stop = double.PositiveInfinity, Exclude exclude = Exclude.None, Order order = Order.Ascending, long skip = 0, long take = -1, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("SortedSetRangeByScoreWithScoresAsync");
    }

    public RedisValue[] SortedSetRangeByValue(RedisKey key, RedisValue min, RedisValue max, Exclude exclude, long skip, long take = -1, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("SortedSetRangeByValue");
    }

    public RedisValue[] SortedSetRangeByValue(RedisKey key, RedisValue min = default, RedisValue max = default, Exclude exclude = Exclude.None, Order order = Order.Ascending, long skip = 0, long take = -1, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("SortedSetRangeByValue");
    }

    public Task<RedisValue[]> SortedSetRangeByValueAsync(RedisKey key, RedisValue min, RedisValue max, Exclude exclude, long skip, long take = -1, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("SortedSetRangeByValueAsync");
    }

    public Task<RedisValue[]> SortedSetRangeByValueAsync(RedisKey key, RedisValue min = default, RedisValue max = default, Exclude exclude = Exclude.None, Order order = Order.Ascending, long skip = 0, long take = -1, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("SortedSetRangeByValueAsync");
    }

    public long? SortedSetRank(RedisKey key, RedisValue member, Order order = Order.Ascending, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("SortedSetRank");
    }

    public Task<long?> SortedSetRankAsync(RedisKey key, RedisValue member, Order order = Order.Ascending, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("SortedSetRankAsync");
    }

    public bool SortedSetRemove(RedisKey key, RedisValue member, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("SortedSetRemove");
    }

    public long SortedSetRemove(RedisKey key, RedisValue[] members, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("SortedSetRemove");
    }

    public Task<bool> SortedSetRemoveAsync(RedisKey key, RedisValue member, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("SortedSetRemoveAsync");
    }

    public Task<long> SortedSetRemoveAsync(RedisKey key, RedisValue[] members, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("SortedSetRemoveAsync");
    }

    public long SortedSetRemoveRangeByRank(RedisKey key, long start, long stop, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("SortedSetRemoveRangeByRank");
    }

    public Task<long> SortedSetRemoveRangeByRankAsync(RedisKey key, long start, long stop, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("SortedSetRemoveRangeByRankAsync");
    }

    public long SortedSetRemoveRangeByScore(RedisKey key, double start, double stop, Exclude exclude = Exclude.None, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("SortedSetRemoveRangeByScore");
    }

    public Task<long> SortedSetRemoveRangeByScoreAsync(RedisKey key, double start, double stop, Exclude exclude = Exclude.None, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("SortedSetRemoveRangeByScoreAsync");
    }

    public long SortedSetRemoveRangeByValue(RedisKey key, RedisValue min, RedisValue max, Exclude exclude = Exclude.None, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("SortedSetRemoveRangeByValue");
    }

    public Task<long> SortedSetRemoveRangeByValueAsync(RedisKey key, RedisValue min, RedisValue max, Exclude exclude = Exclude.None, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("SortedSetRemoveRangeByValueAsync");
    }

    public IEnumerable<SortedSetEntry> SortedSetScan(RedisKey key, RedisValue pattern, int pageSize, CommandFlags flags)
    {
        throw BuildCommandNotImplementedException("SortedSetScan");
    }

    public IEnumerable<SortedSetEntry> SortedSetScan(RedisKey key, RedisValue pattern = default, int pageSize = 250, long cursor = 0, int pageOffset = 0, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("SortedSetScan");
    }

    public IAsyncEnumerable<SortedSetEntry> SortedSetScanAsync(RedisKey key, RedisValue pattern = default, int pageSize = 250, long cursor = 0, int pageOffset = 0, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("SortedSetScanAsync");
    }

    public double? SortedSetScore(RedisKey key, RedisValue member, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("SortedSetScore");
    }

    public Task<double?> SortedSetScoreAsync(RedisKey key, RedisValue member, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("SortedSetScoreAsync");
    }

    public double?[] SortedSetScores(RedisKey key, RedisValue[] members, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("SortedSetScores");
    }

    public Task<double?[]> SortedSetScoresAsync(RedisKey key, RedisValue[] members, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("SortedSetScoresAsync");
    }

    public bool SortedSetUpdate(RedisKey key, RedisValue member, double score, SortedSetWhen when = SortedSetWhen.Always, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("SortedSetUpdate");
    }

    public long SortedSetUpdate(RedisKey key, SortedSetEntry[] values, SortedSetWhen when = SortedSetWhen.Always, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("SortedSetUpdate");
    }

    public Task<bool> SortedSetUpdateAsync(RedisKey key, RedisValue member, double score, SortedSetWhen when = SortedSetWhen.Always, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("SortedSetUpdateAsync");
    }

    public Task<long> SortedSetUpdateAsync(RedisKey key, SortedSetEntry[] values, SortedSetWhen when = SortedSetWhen.Always, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("SortedSetUpdateAsync");
    }
}
