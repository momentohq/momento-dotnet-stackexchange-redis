using System.Threading.Tasks;
using StackExchange.Redis;

namespace Momento.StackExchange.Redis;

public sealed partial class MomentoRedisDatabase : IDatabase
{
    public bool HyperLogLogAdd(RedisKey key, RedisValue value, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("HyperLogLogAdd");
    }

    public bool HyperLogLogAdd(RedisKey key, RedisValue[] values, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("HyperLogLogAdd");
    }

    public Task<bool> HyperLogLogAddAsync(RedisKey key, RedisValue value, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("HyperLogLogAddAsync");
    }

    public Task<bool> HyperLogLogAddAsync(RedisKey key, RedisValue[] values, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("HyperLogLogAddAsync");
    }

    public long HyperLogLogLength(RedisKey key, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("HyperLogLogLength");
    }

    public long HyperLogLogLength(RedisKey[] keys, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("HyperLogLogLength");
    }

    public Task<long> HyperLogLogLengthAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("HyperLogLogLengthAsync");
    }

    public Task<long> HyperLogLogLengthAsync(RedisKey[] keys, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("HyperLogLogLengthAsync");
    }

    public void HyperLogLogMerge(RedisKey destination, RedisKey first, RedisKey second, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("HyperLogLogMerge");
    }

    public void HyperLogLogMerge(RedisKey destination, RedisKey[] sourceKeys, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("HyperLogLogMerge");
    }

    public Task HyperLogLogMergeAsync(RedisKey destination, RedisKey first, RedisKey second, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("HyperLogLogMergeAsync");
    }

    public Task HyperLogLogMergeAsync(RedisKey destination, RedisKey[] sourceKeys, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("HyperLogLogMergeAsync");
    }
}
