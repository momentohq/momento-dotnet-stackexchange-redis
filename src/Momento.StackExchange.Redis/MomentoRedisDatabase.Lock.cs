using StackExchange.Redis;

namespace Momento.StackExchange.Redis;

public sealed partial class MomentoRedisDatabase : IDatabase
{
    public bool LockExtend(RedisKey key, RedisValue value, TimeSpan expiry, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("LockExtend");
    }

    public Task<bool> LockExtendAsync(RedisKey key, RedisValue value, TimeSpan expiry, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("LockExtendAsync");
    }

    public RedisValue LockQuery(RedisKey key, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("LockQuery");
    }

    public Task<RedisValue> LockQueryAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("LockQueryAsync");
    }

    public bool LockRelease(RedisKey key, RedisValue value, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("LockRelease");
    }

    public Task<bool> LockReleaseAsync(RedisKey key, RedisValue value, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("LockReleaseAsync");
    }

    public bool LockTake(RedisKey key, RedisValue value, TimeSpan expiry, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("LockTake");
    }

    public Task<bool> LockTakeAsync(RedisKey key, RedisValue value, TimeSpan expiry, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("LockTakeAsync");
    }
}
