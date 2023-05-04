using System;
using System.Net;
using System.Threading.Tasks;
using Momento.Sdk.Responses;
using StackExchange.Redis;

namespace Momento.StackExchange.Redis;

public sealed partial class MomentoRedisDatabase : IDatabase
{
    public bool KeyCopy(RedisKey sourceKey, RedisKey destinationKey, int destinationDatabase = -1, bool replace = false, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("KeyCopy");
    }

    public Task<bool> KeyCopyAsync(RedisKey sourceKey, RedisKey destinationKey, int destinationDatabase = -1, bool replace = false, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("KeyCopyAsync");
    }

    public bool KeyDelete(RedisKey key, CommandFlags flags = CommandFlags.None)
    {
        return AwaitTaskAndUnwrapException(KeyDeleteAsync(key, flags));
    }

    public long KeyDelete(RedisKey[] keys, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("KeyDelete");
    }

    public async Task<bool> KeyDeleteAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
    {
        WarnOnFireAndForget(flags);

        var response = await Client.DeleteAsync(CacheName, (string)key!);
        if (response is CacheDeleteResponse.Success)
        {
            // TODO: Redis returns a boolean depending on if there was a key to delete or not.
            // We have not implemented this, so we default to true.
            return true;
        }
        else if (response is CacheDeleteResponse.Error error)
        {
            throw ConvertMomentoErrorToRedisException(error);
        }
        else
        {
            throw CreateUnexpectedResponseException(response);
        }
    }

    public Task<long> KeyDeleteAsync(RedisKey[] keys, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("KeyDeleteAsync");
    }

    public byte[]? KeyDump(RedisKey key, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("KeyDump");
    }

    public Task<byte[]?> KeyDumpAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("KeyDumpAsync");
    }

    public string? KeyEncoding(RedisKey key, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("KeyEncoding");
    }

    public Task<string?> KeyEncodingAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("KeyEncodingAsync");
    }

    public bool KeyExists(RedisKey key, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("KeyExists");
    }

    public long KeyExists(RedisKey[] keys, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("KeyExists");
    }

    public Task<bool> KeyExistsAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("KeyExistsAsync");
    }

    public Task<long> KeyExistsAsync(RedisKey[] keys, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("KeyExistsAsync");
    }

    public bool KeyExpire(RedisKey key, TimeSpan? expiry, CommandFlags flags)
    {
        throw BuildCommandNotImplementedException("KeyExpire");
    }

    public bool KeyExpire(RedisKey key, TimeSpan? expiry, ExpireWhen when = ExpireWhen.Always, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("KeyExpire");
    }

    public bool KeyExpire(RedisKey key, DateTime? expiry, CommandFlags flags)
    {
        throw BuildCommandNotImplementedException("KeyExpire");
    }

    public bool KeyExpire(RedisKey key, DateTime? expiry, ExpireWhen when = ExpireWhen.Always, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("KeyExpire");
    }

    public Task<bool> KeyExpireAsync(RedisKey key, TimeSpan? expiry, CommandFlags flags)
    {
        throw BuildCommandNotImplementedException("KeyExpireAsync");
    }

    public Task<bool> KeyExpireAsync(RedisKey key, TimeSpan? expiry, ExpireWhen when = ExpireWhen.Always, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("KeyExpireAsync");
    }

    public Task<bool> KeyExpireAsync(RedisKey key, DateTime? expiry, CommandFlags flags)
    {
        throw BuildCommandNotImplementedException("KeyExpireAsync");
    }

    public Task<bool> KeyExpireAsync(RedisKey key, DateTime? expiry, ExpireWhen when = ExpireWhen.Always, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("KeyExpireAsync");
    }

    public DateTime? KeyExpireTime(RedisKey key, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("KeyExpireTime");
    }

    public Task<DateTime?> KeyExpireTimeAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("KeyExpireTimeAsync");
    }

    public long? KeyFrequency(RedisKey key, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("KeyFrequency");
    }

    public Task<long?> KeyFrequencyAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("KeyFrequencyAsync");
    }

    public TimeSpan? KeyIdleTime(RedisKey key, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("KeyIdleTime");
    }

    public Task<TimeSpan?> KeyIdleTimeAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("KeyIdleTimeAsync");
    }

    public void KeyMigrate(RedisKey key, EndPoint toServer, int toDatabase = 0, int timeoutMilliseconds = 0, MigrateOptions migrateOptions = MigrateOptions.None, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("KeyMigrate");
    }

    public Task KeyMigrateAsync(RedisKey key, EndPoint toServer, int toDatabase = 0, int timeoutMilliseconds = 0, MigrateOptions migrateOptions = MigrateOptions.None, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("KeyMigrateAsync");
    }

    public bool KeyMove(RedisKey key, int database, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("KeyMove");
    }

    public Task<bool> KeyMoveAsync(RedisKey key, int database, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("KeyMoveAsync");
    }

    public bool KeyPersist(RedisKey key, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("KeyPersist");
    }

    public Task<bool> KeyPersistAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("KeyPersistAsync");
    }

    public RedisKey KeyRandom(CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("KeyRandom");
    }

    public Task<RedisKey> KeyRandomAsync(CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("KeyRandomAsync");
    }

    public long? KeyRefCount(RedisKey key, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("KeyRefCount");
    }

    public Task<long?> KeyRefCountAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("KeyRefCountAsync");
    }

    public bool KeyRename(RedisKey key, RedisKey newKey, When when = When.Always, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("KeyRename");
    }

    public Task<bool> KeyRenameAsync(RedisKey key, RedisKey newKey, When when = When.Always, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("KeyRenameAsync");
    }

    public void KeyRestore(RedisKey key, byte[] value, TimeSpan? expiry = null, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("KeyRestore");
    }

    public Task KeyRestoreAsync(RedisKey key, byte[] value, TimeSpan? expiry = null, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("KeyRestoreAsync");
    }

    public TimeSpan? KeyTimeToLive(RedisKey key, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("KeyTimeToLive");
    }

    public Task<TimeSpan?> KeyTimeToLiveAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("KeyTimeToLiveAsync");
    }

    public bool KeyTouch(RedisKey key, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("KeyTouch");
    }

    public long KeyTouch(RedisKey[] keys, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("KeyTouch");
    }

    public Task<bool> KeyTouchAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("KeyTouchAsync");
    }

    public Task<long> KeyTouchAsync(RedisKey[] keys, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("KeyTouchAsync");
    }

    public RedisType KeyType(RedisKey key, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("KeyType");
    }

    public Task<RedisType> KeyTypeAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("KeyTypeAsync");
    }
}
