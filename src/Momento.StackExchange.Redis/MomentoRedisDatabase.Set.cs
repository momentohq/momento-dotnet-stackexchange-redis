using StackExchange.Redis;

namespace Momento.StackExchange.Redis;

public sealed partial class MomentoRedisDatabase : IDatabase
{
    public bool SetAdd(RedisKey key, RedisValue value, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("SetAdd");
    }

    public long SetAdd(RedisKey key, RedisValue[] values, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("SetAdd");
    }

    public Task<bool> SetAddAsync(RedisKey key, RedisValue value, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("SetAddAsync");
    }

    public Task<long> SetAddAsync(RedisKey key, RedisValue[] values, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("SetAddAsync");
    }

    public RedisValue[] SetCombine(SetOperation operation, RedisKey first, RedisKey second, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("SetCombine");
    }

    public RedisValue[] SetCombine(SetOperation operation, RedisKey[] keys, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("SetCombine");
    }

    public long SetCombineAndStore(SetOperation operation, RedisKey destination, RedisKey first, RedisKey second, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("SetCombineAndStore");
    }

    public long SetCombineAndStore(SetOperation operation, RedisKey destination, RedisKey[] keys, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("SetCombineAndStore");
    }

    public Task<long> SetCombineAndStoreAsync(SetOperation operation, RedisKey destination, RedisKey first, RedisKey second, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("SetCombineAndStoreAsync");
    }

    public Task<long> SetCombineAndStoreAsync(SetOperation operation, RedisKey destination, RedisKey[] keys, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("SetCombineAndStoreAsync");
    }

    public Task<RedisValue[]> SetCombineAsync(SetOperation operation, RedisKey first, RedisKey second, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("SetCombineAsync");
    }

    public Task<RedisValue[]> SetCombineAsync(SetOperation operation, RedisKey[] keys, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("SetCombineAsync");
    }

    public bool SetContains(RedisKey key, RedisValue value, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("SetContains");
    }

    public bool[] SetContains(RedisKey key, RedisValue[] values, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("SetContains");
    }

    public Task<bool> SetContainsAsync(RedisKey key, RedisValue value, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("SetContainsAsync");
    }

    public Task<bool[]> SetContainsAsync(RedisKey key, RedisValue[] values, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("SetContainsAsync");
    }

    public long SetIntersectionLength(RedisKey[] keys, long limit = 0, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("SetIntersectionLength");
    }

    public Task<long> SetIntersectionLengthAsync(RedisKey[] keys, long limit = 0, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("SetIntersectionLengthAsync");
    }

    public long SetLength(RedisKey key, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("SetLength");
    }

    public Task<long> SetLengthAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("SetLengthAsync");
    }

    public RedisValue[] SetMembers(RedisKey key, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("SetMembers");
    }

    public Task<RedisValue[]> SetMembersAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("SetMembersAsync");
    }

    public bool SetMove(RedisKey source, RedisKey destination, RedisValue value, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("SetMove");
    }

    public Task<bool> SetMoveAsync(RedisKey source, RedisKey destination, RedisValue value, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("SetMoveAsync");
    }

    public RedisValue SetPop(RedisKey key, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("SetPop");
    }

    public RedisValue[] SetPop(RedisKey key, long count, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("SetPop");
    }

    public Task<RedisValue> SetPopAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("SetPopAsync");
    }

    public Task<RedisValue[]> SetPopAsync(RedisKey key, long count, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("SetPopAsync");
    }

    public RedisValue SetRandomMember(RedisKey key, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("SetRandomMember");
    }

    public Task<RedisValue> SetRandomMemberAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("SetRandomMemberAsync");
    }

    public RedisValue[] SetRandomMembers(RedisKey key, long count, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("SetRandomMembers");
    }

    public Task<RedisValue[]> SetRandomMembersAsync(RedisKey key, long count, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("SetRandomMembersAsync");
    }

    public bool SetRemove(RedisKey key, RedisValue value, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("SetRemove");
    }

    public long SetRemove(RedisKey key, RedisValue[] values, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("SetRemove");
    }

    public Task<bool> SetRemoveAsync(RedisKey key, RedisValue value, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("SetRemoveAsync");
    }

    public Task<long> SetRemoveAsync(RedisKey key, RedisValue[] values, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("SetRemoveAsync");
    }

    public IEnumerable<RedisValue> SetScan(RedisKey key, RedisValue pattern, int pageSize, CommandFlags flags)
    {
        throw BuildCommandNotImplementedException("SetScan");
    }

    public IEnumerable<RedisValue> SetScan(RedisKey key, RedisValue pattern = default, int pageSize = 250, long cursor = 0, int pageOffset = 0, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("SetScan");
    }

    public IAsyncEnumerable<RedisValue> SetScanAsync(RedisKey key, RedisValue pattern = default, int pageSize = 250, long cursor = 0, int pageOffset = 0, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("SetScanAsync");
    }
}
