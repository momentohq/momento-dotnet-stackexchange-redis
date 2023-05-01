using StackExchange.Redis;

namespace Momento.StackExchange.Redis.Tests;

[Collection("Database")]
public class StringTest : TestBase
{
    public StringTest(DatabaseFixture fixture) : base(fixture)
    {
    }

    [Fact]
    public void Get_MissingCache_ThrowsException()
    {
        if (useRedis)
        {
            return;
        }

        var db = new MomentoRedisDatabase(client!, Utils.GuidString());
        Assert.Throws<RedisServerException>(() => db.StringGet(Utils.GuidString()));
    }

    [Fact]
    public void Get_MissingKey_HappyPath()
    {
        var result = db.StringGet(Utils.GuidString());
        Assert.True(result.IsNull);
    }

    [Fact]
    public void Set_NoExpiry_HappyPath()
    {
        var key = Utils.GuidString();
        var value = Utils.GuidString();
        var result = db.StringSet(key, value, null, When.Always);
        Assert.True(result);

        var storedValue = db.StringGet(key);
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
}
