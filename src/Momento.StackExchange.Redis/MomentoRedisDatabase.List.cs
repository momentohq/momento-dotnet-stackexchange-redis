using System.Threading.Tasks;
using StackExchange.Redis;

namespace Momento.StackExchange.Redis;

public sealed partial class MomentoRedisDatabase : IDatabase
{
    public RedisValue ListGetByIndex(RedisKey key, long index, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("ListGetByIndex");
    }

    public Task<RedisValue> ListGetByIndexAsync(RedisKey key, long index, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("ListGetByIndexAsync");
    }

    public long ListInsertAfter(RedisKey key, RedisValue pivot, RedisValue value, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("ListInsertAfter");
    }

    public Task<long> ListInsertAfterAsync(RedisKey key, RedisValue pivot, RedisValue value, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("ListInsertAfterAsync");
    }

    public long ListInsertBefore(RedisKey key, RedisValue pivot, RedisValue value, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("ListInsertBefore");
    }

    public Task<long> ListInsertBeforeAsync(RedisKey key, RedisValue pivot, RedisValue value, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("ListInsertBeforeAsync");
    }

    public RedisValue ListLeftPop(RedisKey key, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("ListLeftPop");
    }

    public RedisValue[] ListLeftPop(RedisKey key, long count, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("ListLeftPop");
    }

    public ListPopResult ListLeftPop(RedisKey[] keys, long count, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("ListLeftPop");
    }

    public Task<RedisValue> ListLeftPopAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("ListLeftPopAsync");
    }

    public Task<RedisValue[]> ListLeftPopAsync(RedisKey key, long count, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("ListLeftPopAsync");
    }

    public Task<ListPopResult> ListLeftPopAsync(RedisKey[] keys, long count, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("ListLeftPopAsync");
    }

    public long ListLeftPush(RedisKey key, RedisValue value, When when = When.Always, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("ListLeftPush");
    }

    public long ListLeftPush(RedisKey key, RedisValue[] values, When when = When.Always, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("ListLeftPush");
    }

    public long ListLeftPush(RedisKey key, RedisValue[] values, CommandFlags flags)
    {
        throw BuildCommandNotImplementedException("ListLeftPush");
    }

    public Task<long> ListLeftPushAsync(RedisKey key, RedisValue value, When when = When.Always, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("ListLeftPushAsync");
    }

    public Task<long> ListLeftPushAsync(RedisKey key, RedisValue[] values, When when = When.Always, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("ListLeftPushAsync");
    }

    public Task<long> ListLeftPushAsync(RedisKey key, RedisValue[] values, CommandFlags flags)
    {
        throw BuildCommandNotImplementedException("ListLeftPushAsync");
    }

    public long ListLength(RedisKey key, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("ListLength");
    }

    public Task<long> ListLengthAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("ListLengthAsync");
    }

    public RedisValue ListMove(RedisKey sourceKey, RedisKey destinationKey, ListSide sourceSide, ListSide destinationSide, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("ListMove");
    }

    public Task<RedisValue> ListMoveAsync(RedisKey sourceKey, RedisKey destinationKey, ListSide sourceSide, ListSide destinationSide, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("ListMoveAsync");
    }

    public long ListPosition(RedisKey key, RedisValue element, long rank = 1, long maxLength = 0, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("ListPosition");
    }

    public Task<long> ListPositionAsync(RedisKey key, RedisValue element, long rank = 1, long maxLength = 0, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("ListPositionAsync");
    }

    public long[] ListPositions(RedisKey key, RedisValue element, long count, long rank = 1, long maxLength = 0, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("ListPositions");
    }

    public Task<long[]> ListPositionsAsync(RedisKey key, RedisValue element, long count, long rank = 1, long maxLength = 0, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("ListPositionsAsync");
    }

    public RedisValue[] ListRange(RedisKey key, long start = 0, long stop = -1, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("ListRange");
    }

    public Task<RedisValue[]> ListRangeAsync(RedisKey key, long start = 0, long stop = -1, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("ListRangeAsync");
    }

    public long ListRemove(RedisKey key, RedisValue value, long count = 0, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("ListRemove");
    }

    public Task<long> ListRemoveAsync(RedisKey key, RedisValue value, long count = 0, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("ListRemoveAsync");
    }

    public RedisValue ListRightPop(RedisKey key, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("ListRightPop");
    }

    public RedisValue[] ListRightPop(RedisKey key, long count, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("ListRightPop");
    }

    public ListPopResult ListRightPop(RedisKey[] keys, long count, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("ListRightPop");
    }

    public Task<RedisValue> ListRightPopAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("ListRightPopAsync");
    }

    public Task<RedisValue[]> ListRightPopAsync(RedisKey key, long count, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("ListRightPopAsync");
    }

    public Task<ListPopResult> ListRightPopAsync(RedisKey[] keys, long count, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("ListRightPopAsync");
    }

    public RedisValue ListRightPopLeftPush(RedisKey source, RedisKey destination, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("ListRightPopLeftPush");
    }

    public Task<RedisValue> ListRightPopLeftPushAsync(RedisKey source, RedisKey destination, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("ListRightPopLeftPushAsync");
    }

    public long ListRightPush(RedisKey key, RedisValue value, When when = When.Always, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("ListRightPush");
    }

    public long ListRightPush(RedisKey key, RedisValue[] values, When when = When.Always, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("ListRightPush");
    }

    public long ListRightPush(RedisKey key, RedisValue[] values, CommandFlags flags)
    {
        throw BuildCommandNotImplementedException("ListRightPush");
    }

    public Task<long> ListRightPushAsync(RedisKey key, RedisValue value, When when = When.Always, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("ListRightPushAsync");
    }

    public Task<long> ListRightPushAsync(RedisKey key, RedisValue[] values, When when = When.Always, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("ListRightPushAsync");
    }

    public Task<long> ListRightPushAsync(RedisKey key, RedisValue[] values, CommandFlags flags)
    {
        throw BuildCommandNotImplementedException("ListRightPushAsync");
    }

    public void ListSetByIndex(RedisKey key, long index, RedisValue value, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("ListSetByIndex");
    }

    public Task ListSetByIndexAsync(RedisKey key, long index, RedisValue value, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("ListSetByIndexAsync");
    }

    public void ListTrim(RedisKey key, long start, long stop, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("ListTrim");
    }

    public Task ListTrimAsync(RedisKey key, long start, long stop, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("ListTrimAsync");
    }
}
