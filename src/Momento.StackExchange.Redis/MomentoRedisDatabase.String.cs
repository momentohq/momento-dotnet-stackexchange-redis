using Momento.Sdk.Responses;
using StackExchange.Redis;

namespace Momento.StackExchange.Redis;

public sealed partial class MomentoRedisDatabase : IDatabase
{
    public long StringAppend(RedisKey key, RedisValue value, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("StringAppend");
    }

    public Task<long> StringAppendAsync(RedisKey key, RedisValue value, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("StringAppendAsync");
    }

    public long StringBitCount(RedisKey key, long start, long end, CommandFlags flags)
    {
        throw BuildCommandNotImplementedException("StringBitCount");
    }

    public long StringBitCount(RedisKey key, long start = 0, long end = -1, StringIndexType indexType = StringIndexType.Byte, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("StringBitCount");
    }

    public Task<long> StringBitCountAsync(RedisKey key, long start, long end, CommandFlags flags)
    {
        throw BuildCommandNotImplementedException("StringBitCountAsync");
    }

    public Task<long> StringBitCountAsync(RedisKey key, long start = 0, long end = -1, StringIndexType indexType = StringIndexType.Byte, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("StringBitCountAsync");
    }

    public long StringBitOperation(Bitwise operation, RedisKey destination, RedisKey first, RedisKey second = default, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("StringBitOperation");
    }

    public long StringBitOperation(Bitwise operation, RedisKey destination, RedisKey[] keys, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("StringBitOperation");
    }

    public Task<long> StringBitOperationAsync(Bitwise operation, RedisKey destination, RedisKey first, RedisKey second = default, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("StringBitOperationAsync");
    }

    public Task<long> StringBitOperationAsync(Bitwise operation, RedisKey destination, RedisKey[] keys, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("StringBitOperationAsync");
    }

    public long StringBitPosition(RedisKey key, bool bit, long start, long end, CommandFlags flags)
    {
        throw BuildCommandNotImplementedException("StringBitPosition");
    }

    public long StringBitPosition(RedisKey key, bool bit, long start = 0, long end = -1, StringIndexType indexType = StringIndexType.Byte, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("StringBitPosition");
    }

    public Task<long> StringBitPositionAsync(RedisKey key, bool bit, long start, long end, CommandFlags flags)
    {
        throw BuildCommandNotImplementedException("StringBitPositionAsync");
    }

    public Task<long> StringBitPositionAsync(RedisKey key, bool bit, long start = 0, long end = -1, StringIndexType indexType = StringIndexType.Byte, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("StringBitPositionAsync");
    }

    public long StringDecrement(RedisKey key, long value = 1, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("StringDecrement");
    }

    public double StringDecrement(RedisKey key, double value, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("StringDecrement");
    }

    public Task<long> StringDecrementAsync(RedisKey key, long value = 1, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("StringDecrementAsync");
    }

    public Task<double> StringDecrementAsync(RedisKey key, double value, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("StringDecrementAsync");
    }

    public RedisValue StringGet(RedisKey key, CommandFlags flags = CommandFlags.None)
    {
        return AwaitTaskAndUnwrapException(StringGetAsync(key, flags));
    }

    public RedisValue[] StringGet(RedisKey[] keys, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("StringGet");
    }

    public async Task<RedisValue> StringGetAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
    {
        WarnOnFireAndForget(flags);

        var response = await Client.GetAsync(CacheName, key.ToString());
        if (response is CacheGetResponse.Hit hit)
        {
            return hit.ValueString;
        }
        else if (response is CacheGetResponse.Miss)
        {
            return RedisValue.Null;
        }
        else if (response is CacheGetResponse.Error error)
        {
            throw ConvertMomentoErrorToRedisException(error);
        }
        else
        {
            throw CreateUnexpectedResponseException(response);
        }
    }

    public Task<RedisValue[]> StringGetAsync(RedisKey[] keys, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("StringGetAsync");
    }

    public bool StringGetBit(RedisKey key, long offset, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("StringGetBit");
    }

    public Task<bool> StringGetBitAsync(RedisKey key, long offset, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("StringGetBitAsync");
    }

    public RedisValue StringGetDelete(RedisKey key, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("StringGetDelete");
    }

    public Task<RedisValue> StringGetDeleteAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("StringGetDeleteAsync");
    }

    public Lease<byte>? StringGetLease(RedisKey key, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("StringGetLease");
    }

    public Task<Lease<byte>?> StringGetLeaseAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("StringGetLeaseAsync");
    }

    public RedisValue StringGetRange(RedisKey key, long start, long end, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("StringGetRange");
    }

    public Task<RedisValue> StringGetRangeAsync(RedisKey key, long start, long end, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("StringGetRangeAsync");
    }

    public RedisValue StringGetSet(RedisKey key, RedisValue value, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("StringGetSet");
    }

    public Task<RedisValue> StringGetSetAsync(RedisKey key, RedisValue value, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("StringGetSetAsync");
    }

    public RedisValue StringGetSetExpiry(RedisKey key, TimeSpan? expiry, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("StringGetSetExpiry");
    }

    public RedisValue StringGetSetExpiry(RedisKey key, DateTime expiry, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("StringGetSetExpiry");
    }

    public Task<RedisValue> StringGetSetExpiryAsync(RedisKey key, TimeSpan? expiry, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("StringGetSetExpiryAsync");
    }

    public Task<RedisValue> StringGetSetExpiryAsync(RedisKey key, DateTime expiry, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("StringGetSetExpiryAsync");
    }

    public RedisValueWithExpiry StringGetWithExpiry(RedisKey key, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("StringGetWithExpiry");
    }

    public Task<RedisValueWithExpiry> StringGetWithExpiryAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("StringGetWithExpiryAsync");
    }

    public long StringIncrement(RedisKey key, long value = 1, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("StringIncrement");
    }

    public double StringIncrement(RedisKey key, double value, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("StringIncrement");
    }

    public Task<long> StringIncrementAsync(RedisKey key, long value = 1, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("StringIncrementAsync");
    }

    public Task<double> StringIncrementAsync(RedisKey key, double value, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("StringIncrementAsync");
    }

    public long StringLength(RedisKey key, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("StringLength");
    }

    public Task<long> StringLengthAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("StringLengthAsync");
    }

    public string? StringLongestCommonSubsequence(RedisKey first, RedisKey second, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("StringLongestCommonSubsequence");
    }

    public Task<string?> StringLongestCommonSubsequenceAsync(RedisKey first, RedisKey second, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("StringLongestCommonSubsequenceAsync");
    }

    public long StringLongestCommonSubsequenceLength(RedisKey first, RedisKey second, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("StringLongestCommonSubsequenceLength");
    }

    public Task<long> StringLongestCommonSubsequenceLengthAsync(RedisKey first, RedisKey second, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("StringLongestCommonSubsequenceLengthAsync");
    }

    public LCSMatchResult StringLongestCommonSubsequenceWithMatches(RedisKey first, RedisKey second, long minLength = 0, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("StringLongestCommonSubsequenceWithMatches");
    }

    public Task<LCSMatchResult> StringLongestCommonSubsequenceWithMatchesAsync(RedisKey first, RedisKey second, long minLength = 0, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("StringLongestCommonSubsequenceWithMatchesAsync");
    }

    public bool StringSet(RedisKey key, RedisValue value, TimeSpan? expiry, When when)
    {
        return AwaitTaskAndUnwrapException(StringSetAsync(key, value, expiry, when));
    }

    public bool StringSet(RedisKey key, RedisValue value, TimeSpan? expiry, When when, CommandFlags flags)
    {
        throw BuildCommandNotImplementedException("StringSet");
    }

    public bool StringSet(RedisKey key, RedisValue value, TimeSpan? expiry = null, bool keepTtl = false, When when = When.Always, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("StringSet");
    }

    public bool StringSet(KeyValuePair<RedisKey, RedisValue>[] values, When when = When.Always, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("StringSet");
    }

    public RedisValue StringSetAndGet(RedisKey key, RedisValue value, TimeSpan? expiry, When when, CommandFlags flags)
    {
        throw BuildCommandNotImplementedException("StringSetAndGet");
    }

    public RedisValue StringSetAndGet(RedisKey key, RedisValue value, TimeSpan? expiry = null, bool keepTtl = false, When when = When.Always, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("StringSetAndGet");
    }

    public Task<RedisValue> StringSetAndGetAsync(RedisKey key, RedisValue value, TimeSpan? expiry, When when, CommandFlags flags)
    {
        throw BuildCommandNotImplementedException("StringSetAndGetAsync");
    }

    public Task<RedisValue> StringSetAndGetAsync(RedisKey key, RedisValue value, TimeSpan? expiry = null, bool keepTtl = false, When when = When.Always, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("StringSetAndGetAsync");
    }

    public async Task<bool> StringSetAsync(RedisKey key, RedisValue value, TimeSpan? expiry, When when)
    {
        AssertStringWhenImplemented(when, "StringSetAsync");

        var response = await Client.SetAsync(CacheName, (string)key!, (string)value!, expiry);
        if (response is CacheSetResponse.Success)
        {
            return true;
        }
        else if (response is CacheSetResponse.Error error)
        {
            throw ConvertMomentoErrorToRedisException(error);
        }
        else
        {
            throw CreateUnexpectedResponseException(response);
        }
    }

    public Task<bool> StringSetAsync(RedisKey key, RedisValue value, TimeSpan? expiry, When when, CommandFlags flags)
    {
        throw BuildCommandNotImplementedException("StringSetAsync");
    }

    public Task<bool> StringSetAsync(RedisKey key, RedisValue value, TimeSpan? expiry = null, bool keepTtl = false, When when = When.Always, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("StringSetAsync");
    }

    public Task<bool> StringSetAsync(KeyValuePair<RedisKey, RedisValue>[] values, When when = When.Always, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("StringSetAsync");
    }

    public bool StringSetBit(RedisKey key, long offset, bool bit, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("StringSetBit");
    }

    public Task<bool> StringSetBitAsync(RedisKey key, long offset, bool bit, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("StringSetBitAsync");
    }

    public RedisValue StringSetRange(RedisKey key, long offset, RedisValue value, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("StringSetRange");
    }

    public Task<RedisValue> StringSetRangeAsync(RedisKey key, long offset, RedisValue value, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("StringSetRangeAsync");
    }
}
