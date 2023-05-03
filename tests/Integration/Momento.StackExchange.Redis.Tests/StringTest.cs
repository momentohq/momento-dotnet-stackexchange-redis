using StackExchange.Redis;

namespace Momento.StackExchange.Redis.Tests;

[Collection("Database")]
public class StringTest : TestBase
{
    public StringTest(DatabaseFixture fixture) : base(fixture)
    {
    }

    [Fact]
    public void StringGet_MissingCache_ThrowsException()
    {
        if (useRedis)
        {
            return;
        }

        var db = new MomentoRedisDatabase(client!, Utils.GuidString());
        Assert.Throws<RedisServerException>(() => db.StringGet(Utils.GuidString()));
    }

    [Fact]
    public async Task StringGetAsync_MissingCache_ThrowsException()
    {
        if (useRedis)
        {
            return;
        }

        var db = new MomentoRedisDatabase(client!, Utils.GuidString());
        await Assert.ThrowsAsync<RedisServerException>(() => db.StringGetAsync(Utils.GuidString()));
    }

    [Fact]
    public void StringGet_MissingKey_HappyPath()
    {
        var result = db.StringGet(Utils.GuidString());
        Assert.True(result.IsNull);
    }

    [Fact]
    public async Task StringGetAsync_MissingKey_HappyPath()
    {
        var result = await db.StringGetAsync(Utils.GuidString());
        Assert.True(result.IsNull);
    }

    [Fact]
    public void StringSet_NoExpiry_HappyPath()
    {
        var key = Utils.GuidString();
        var value = Utils.GuidString();
        var result = db.StringSet(key, value);
        Assert.True(result);

        var storedValue = db.StringGet(key);
        Assert.Equal(value, storedValue);
    }

    [Fact]
    public async Task StringSetAsync_NoExpiry_HappyPath()
    {
        var key = Utils.GuidString();
        var value = Utils.GuidString();
        var result = await db.StringSetAsync(key, value);
        Assert.True(result);

        var storedValue = await db.StringGetAsync(key);
        Assert.Equal(value, storedValue);
    }

    [Fact]
    public void StringSet_KeepTtl_ThrowsException()
    {
        if (useRedis)
        {
            return;
        }

        var key = Utils.GuidString();
        var value = Utils.GuidString();
        var exception = Record.Exception(() => db.StringSet(key, value, keepTtl: true));
        Assert.IsType<NotImplementedException>(exception);
        // Note that because we delegate synchronous calls to asynchronous calls, the exception message will be that of the asynchronous call.
        Assert.StartsWith("Command StringSetAsync with keepTtl=true is not yet supported in MomentoRedisClient", exception.Message);
    }

    [Fact]
    public async Task StringSetAsync_KeepTtl_ThrowsException()
    {
        if (useRedis)
        {
            return;
        }

        var key = Utils.GuidString();
        var value = Utils.GuidString();
        var exception = await Record.ExceptionAsync(() => db.StringSetAsync(key, value, keepTtl: true));
        Assert.IsType<NotImplementedException>(exception);
        Assert.StartsWith("Command StringSetAsync with keepTtl=true is not yet supported in MomentoRedisClient", exception.Message);
    }

    [Fact]
    public void StringSet_WhenExists_ThrowsException()
    {
        if (useRedis)
        {
            return;
        }

        var key = Utils.GuidString();
        var value = Utils.GuidString();
        var exception = Record.Exception(() => db.StringSet(key, value, when: When.Exists));
        Assert.IsType<NotImplementedException>(exception);
        // Note that because we delegate synchronous calls to asynchronous calls, the exception message will be that of the asynchronous call.
        Assert.StartsWith("Command StringSetAsync with When.Exists is not yet supported in MomentoRedisClient", exception.Message);
    }

    [Fact]
    public async Task StringSetAsync_WhenExists_ThrowsException()
    {
        if (useRedis)
        {
            return;
        }

        var key = Utils.GuidString();
        var value = Utils.GuidString();
        var exception = await Record.ExceptionAsync(() => db.StringSetAsync(key, value, when: When.Exists));
        Assert.IsType<NotImplementedException>(exception);
        Assert.StartsWith("Command StringSetAsync with When.Exists is not yet supported in MomentoRedisClient", exception.Message);
    }

    [Fact]
    public void StringSet_HasExpiryAndExpires_HappyPath()
    {
        var key = Utils.GuidString();
        var value = Utils.GuidString();
        var result = db.StringSet(key, value, TimeSpan.FromSeconds(5));
        Assert.True(result);

        var storedValue = db.StringGet(key);
        Assert.Equal(value, storedValue);

        Thread.Sleep(TimeSpan.FromSeconds(5));

        storedValue = db.StringGet(key);
        Assert.True(storedValue.IsNull);
    }

    [Fact]
    public async Task StringSetAsync_HasExpiryAndExpires_HappyPath()
    {
        var key = Utils.GuidString();
        var value = Utils.GuidString();
        var result = await db.StringSetAsync(key, value, TimeSpan.FromSeconds(5));
        Assert.True(result);

        var storedValue = await db.StringGetAsync(key);
        Assert.Equal(value, storedValue);

        await Task.Delay(TimeSpan.FromSeconds(5));

        storedValue = await db.StringGetAsync(key);
        Assert.True(storedValue.IsNull);
    }

    [Fact]
    public void StringSet_WhenNotExistsAndKeyMissing_WasStored()
    {
        var key = Utils.GuidString();
        var value = Utils.GuidString();
        var result = db.StringSet(key, value, when: When.NotExists);
        Assert.True(result);

        var storedValue = db.StringGet(key);
        Assert.Equal(value, storedValue);
    }

    [Fact]
    public async Task StringSetAsync_WhenNotExistsAndKeyMissing_WasStored()
    {
        var key = Utils.GuidString();
        var value = Utils.GuidString();
        var result = await db.StringSetAsync(key, value, when: When.NotExists);
        Assert.True(result);

        var storedValue = await db.StringGetAsync(key);
        Assert.Equal(value, storedValue);
    }

    [Fact]
    public void StringSet_WhenNotExistsAndKeyExists_WasntStored()
    {
        var key = Utils.GuidString();
        var value = Utils.GuidString();
        db.StringSet(key, value);

        var newValue = Utils.GuidString();
        var result = db.StringSet(key, newValue, when: When.NotExists);
        Assert.False(result);

        var storedValue = db.StringGet(key);
        Assert.Equal(value, storedValue);
    }

    [Fact]
    public async Task StringSetAsync_WhenNotExistsAndKeyExists_WasntStored()
    {
        var key = Utils.GuidString();
        var value = Utils.GuidString();
        await db.StringSetAsync(key, value);

        var newValue = Utils.GuidString();
        var result = await db.StringSetAsync(key, newValue, when: When.NotExists);
        Assert.False(result);

        var storedValue = await db.StringGetAsync(key);
        Assert.Equal(value, storedValue);
    }

    [Fact]
    public void KeyDelete_MissingKey_HappyPath()
    {
        var key = Utils.GuidString();

        // Verify key not there
        var getResponse = db.StringGet(key);
        Assert.True(getResponse.IsNull);

        // Delete
        var result = db.KeyDelete(Utils.GuidString());

        if (useRedis)
        {
            Assert.False(result);
        }
        else
        {
            Assert.True(result);
        }

        // Verify key still not there
        getResponse = db.StringGet(key);
        Assert.True(getResponse.IsNull);
    }

    [Fact]
    public async Task KeyDeleteAsync_MissingKey_HappyPath()
    {
        var key = Utils.GuidString();

        // Verify key not there
        var getResponse = await db.StringGetAsync(key);
        Assert.True(getResponse.IsNull);

        // Delete
        var result = await db.KeyDeleteAsync(Utils.GuidString());

        if (useRedis)
        {
            Assert.False(result);
        }
        else
        {
            Assert.True(result);
        }

        // Verify key still not there
        getResponse = await db.StringGetAsync(key);
        Assert.True(getResponse.IsNull);
    }

    [Fact]
    public void KeyDelete_KeyExists_HappyPath()
    {
        var key = Utils.GuidString();
        var value = Utils.GuidString();
        var result = db.StringSet(key, value, null, When.Always);
        Assert.True(result);

        // Verify key is there
        var getResponse = db.StringGet(key);
        Assert.Equal(value, getResponse);

        var deleteResponse = db.KeyDelete(key);
        Assert.True(deleteResponse);

        // Verify key is gone
        getResponse = db.StringGet(key);
        Assert.True(getResponse.IsNull);
    }

    [Fact]
    public async Task KeyDeleteAsync_KeyExists_HappyPath()
    {
        var key = Utils.GuidString();
        var value = Utils.GuidString();
        var result = await db.StringSetAsync(key, value, null, When.Always);
        Assert.True(result);

        // Verify key is there
        var getResponse = await db.StringGetAsync(key);
        Assert.Equal(value, getResponse);

        var deleteResponse = await db.KeyDeleteAsync(key);
        Assert.True(deleteResponse);

        // Verify key is gone
        getResponse = await db.StringGetAsync(key);
        Assert.True(getResponse.IsNull);
    }
}
