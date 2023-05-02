using StackExchange.Redis;

namespace Momento.StackExchange.Redis;

public sealed partial class MomentoRedisDatabase : IDatabase
{
    public long HashDecrement(RedisKey key, RedisValue hashField, long value = 1, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("HashDecrement");
    }

    public double HashDecrement(RedisKey key, RedisValue hashField, double value, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("HashDecrement");
    }

    public Task<long> HashDecrementAsync(RedisKey key, RedisValue hashField, long value = 1, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("HashDecrementAsync");
    }

    public Task<double> HashDecrementAsync(RedisKey key, RedisValue hashField, double value, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("HashDecrementAsync");
    }

    public bool HashDelete(RedisKey key, RedisValue hashField, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("HashDelete");
    }

    public long HashDelete(RedisKey key, RedisValue[] hashFields, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("HashDelete");
    }

    public Task<bool> HashDeleteAsync(RedisKey key, RedisValue hashField, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("HashDeleteAsync");
    }

    public Task<long> HashDeleteAsync(RedisKey key, RedisValue[] hashFields, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("HashDeleteAsync");
    }

    public bool HashExists(RedisKey key, RedisValue hashField, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("HashExists");
    }

    public Task<bool> HashExistsAsync(RedisKey key, RedisValue hashField, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("HashExistsAsync");
    }

    public RedisValue HashGet(RedisKey key, RedisValue hashField, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("HashGet");
    }

    public RedisValue[] HashGet(RedisKey key, RedisValue[] hashFields, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("HashGet");
    }

    public HashEntry[] HashGetAll(RedisKey key, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("HashGetAll");
    }

    public Task<HashEntry[]> HashGetAllAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("HashGetAllAsync");
    }

    public Task<RedisValue> HashGetAsync(RedisKey key, RedisValue hashField, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("HashGetAsync");
    }

    public Task<RedisValue[]> HashGetAsync(RedisKey key, RedisValue[] hashFields, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("HashGetAsync");
    }

    public Lease<byte>? HashGetLease(RedisKey key, RedisValue hashField, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("HashGetLease");
    }

    public Task<Lease<byte>?> HashGetLeaseAsync(RedisKey key, RedisValue hashField, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("HashGetLeaseAsync");
    }

    public long HashIncrement(RedisKey key, RedisValue hashField, long value = 1, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("HashIncrement");
    }

    public double HashIncrement(RedisKey key, RedisValue hashField, double value, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("HashIncrement");
    }

    public Task<long> HashIncrementAsync(RedisKey key, RedisValue hashField, long value = 1, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("HashIncrementAsync");
    }

    public Task<double> HashIncrementAsync(RedisKey key, RedisValue hashField, double value, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("HashIncrementAsync");
    }

    public RedisValue[] HashKeys(RedisKey key, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("HashKeys");
    }

    public Task<RedisValue[]> HashKeysAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("HashKeysAsync");
    }

    public long HashLength(RedisKey key, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("HashLength");
    }

    public Task<long> HashLengthAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("HashLengthAsync");
    }

    public RedisValue HashRandomField(RedisKey key, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("HashRandomField");
    }

    public Task<RedisValue> HashRandomFieldAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("HashRandomFieldAsync");
    }

    public RedisValue[] HashRandomFields(RedisKey key, long count, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("HashRandomFields");
    }

    public Task<RedisValue[]> HashRandomFieldsAsync(RedisKey key, long count, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("HashRandomFieldsAsync");
    }

    public HashEntry[] HashRandomFieldsWithValues(RedisKey key, long count, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("HashRandomFieldsWithValues");
    }

    public Task<HashEntry[]> HashRandomFieldsWithValuesAsync(RedisKey key, long count, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("HashRandomFieldsWithValuesAsync");
    }

    public IEnumerable<HashEntry> HashScan(RedisKey key, RedisValue pattern, int pageSize, CommandFlags flags)
    {
        throw BuildCommandNotImplementedException("HashScan");
    }

    public IEnumerable<HashEntry> HashScan(RedisKey key, RedisValue pattern = default, int pageSize = 250, long cursor = 0, int pageOffset = 0, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("HashScan");
    }

    public IAsyncEnumerable<HashEntry> HashScanAsync(RedisKey key, RedisValue pattern = default, int pageSize = 250, long cursor = 0, int pageOffset = 0, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("HashScanAsync");
    }

    public void HashSet(RedisKey key, HashEntry[] hashFields, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("HashSet");
    }

    public bool HashSet(RedisKey key, RedisValue hashField, RedisValue value, When when = When.Always, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("HashSet");
    }

    public Task HashSetAsync(RedisKey key, HashEntry[] hashFields, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("HashSetAsync");
    }

    public Task<bool> HashSetAsync(RedisKey key, RedisValue hashField, RedisValue value, When when = When.Always, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("HashSetAsync");
    }

    public long HashStringLength(RedisKey key, RedisValue hashField, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("HashStringLength");
    }

    public Task<long> HashStringLengthAsync(RedisKey key, RedisValue hashField, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("HashStringLengthAsync");
    }

    public RedisValue[] HashValues(RedisKey key, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("HashValues");
    }

    public Task<RedisValue[]> HashValuesAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("HashValuesAsync");
    }
}
