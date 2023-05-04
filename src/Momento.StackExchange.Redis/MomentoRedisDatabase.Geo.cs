using System.Threading.Tasks;
using StackExchange.Redis;

namespace Momento.StackExchange.Redis;

public sealed partial class MomentoRedisDatabase : IDatabase
{
    public bool GeoAdd(RedisKey key, double longitude, double latitude, RedisValue member, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("GeoAdd");
    }

    public bool GeoAdd(RedisKey key, GeoEntry value, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("GeoAdd");
    }

    public long GeoAdd(RedisKey key, GeoEntry[] values, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("GeoAdd");
    }

    public Task<bool> GeoAddAsync(RedisKey key, double longitude, double latitude, RedisValue member, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("GeoAddAsync");
    }

    public Task<bool> GeoAddAsync(RedisKey key, GeoEntry value, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("GeoAddAsync");
    }

    public Task<long> GeoAddAsync(RedisKey key, GeoEntry[] values, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("GeoAddAsync");
    }

    public double? GeoDistance(RedisKey key, RedisValue member1, RedisValue member2, GeoUnit unit = GeoUnit.Meters, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("GeoDistance");
    }

    public Task<double?> GeoDistanceAsync(RedisKey key, RedisValue member1, RedisValue member2, GeoUnit unit = GeoUnit.Meters, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("GeoDistanceAsync");
    }

    public string?[] GeoHash(RedisKey key, RedisValue[] members, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("GeoHash");
    }

    public string? GeoHash(RedisKey key, RedisValue member, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("GeoHash");
    }

    public Task<string?[]> GeoHashAsync(RedisKey key, RedisValue[] members, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("GeoHashAsync");
    }

    public Task<string?> GeoHashAsync(RedisKey key, RedisValue member, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("GeoHashAsync");
    }

    public GeoPosition?[] GeoPosition(RedisKey key, RedisValue[] members, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("GeoPosition");
    }

    public GeoPosition? GeoPosition(RedisKey key, RedisValue member, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("GeoPosition");
    }

    public Task<GeoPosition?[]> GeoPositionAsync(RedisKey key, RedisValue[] members, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("GeoPositionAsync");
    }

    public Task<GeoPosition?> GeoPositionAsync(RedisKey key, RedisValue member, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("GeoPositionAsync");
    }

    public GeoRadiusResult[] GeoRadius(RedisKey key, RedisValue member, double radius, GeoUnit unit = GeoUnit.Meters, int count = -1, Order? order = null, GeoRadiusOptions options = GeoRadiusOptions.Default, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("GeoRadius");
    }

    public GeoRadiusResult[] GeoRadius(RedisKey key, double longitude, double latitude, double radius, GeoUnit unit = GeoUnit.Meters, int count = -1, Order? order = null, GeoRadiusOptions options = GeoRadiusOptions.Default, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("GeoRadius");
    }

    public Task<GeoRadiusResult[]> GeoRadiusAsync(RedisKey key, RedisValue member, double radius, GeoUnit unit = GeoUnit.Meters, int count = -1, Order? order = null, GeoRadiusOptions options = GeoRadiusOptions.Default, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("GeoRadiusAsync");
    }

    public Task<GeoRadiusResult[]> GeoRadiusAsync(RedisKey key, double longitude, double latitude, double radius, GeoUnit unit = GeoUnit.Meters, int count = -1, Order? order = null, GeoRadiusOptions options = GeoRadiusOptions.Default, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("GeoRadiusAsync");
    }

    public bool GeoRemove(RedisKey key, RedisValue member, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("GeoRemove");
    }

    public Task<bool> GeoRemoveAsync(RedisKey key, RedisValue member, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("GeoRemoveAsync");
    }

    public GeoRadiusResult[] GeoSearch(RedisKey key, RedisValue member, GeoSearchShape shape, int count = -1, bool demandClosest = true, Order? order = null, GeoRadiusOptions options = GeoRadiusOptions.Default, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("GeoSearch");
    }

    public GeoRadiusResult[] GeoSearch(RedisKey key, double longitude, double latitude, GeoSearchShape shape, int count = -1, bool demandClosest = true, Order? order = null, GeoRadiusOptions options = GeoRadiusOptions.Default, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("GeoSearch");
    }

    public long GeoSearchAndStore(RedisKey sourceKey, RedisKey destinationKey, RedisValue member, GeoSearchShape shape, int count = -1, bool demandClosest = true, Order? order = null, bool storeDistances = false, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("GeoSearchAndStore");
    }

    public long GeoSearchAndStore(RedisKey sourceKey, RedisKey destinationKey, double longitude, double latitude, GeoSearchShape shape, int count = -1, bool demandClosest = true, Order? order = null, bool storeDistances = false, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("GeoSearchAndStore");
    }

    public Task<long> GeoSearchAndStoreAsync(RedisKey sourceKey, RedisKey destinationKey, RedisValue member, GeoSearchShape shape, int count = -1, bool demandClosest = true, Order? order = null, bool storeDistances = false, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("GeoSearchAndStoreAsync");
    }

    public Task<long> GeoSearchAndStoreAsync(RedisKey sourceKey, RedisKey destinationKey, double longitude, double latitude, GeoSearchShape shape, int count = -1, bool demandClosest = true, Order? order = null, bool storeDistances = false, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("GeoSearchAndStoreAsync");
    }


    public Task<GeoRadiusResult[]> GeoSearchAsync(RedisKey key, RedisValue member, GeoSearchShape shape, int count = -1, bool demandClosest = true, Order? order = null, GeoRadiusOptions options = GeoRadiusOptions.Default, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("GeoSearchAsync");
    }

    public Task<GeoRadiusResult[]> GeoSearchAsync(RedisKey key, double longitude, double latitude, GeoSearchShape shape, int count = -1, bool demandClosest = true, Order? order = null, GeoRadiusOptions options = GeoRadiusOptions.Default, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("GeoSearchAsync");
    }
}
