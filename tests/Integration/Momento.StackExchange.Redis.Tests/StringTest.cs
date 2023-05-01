using StackExchange.Redis;

namespace Momento.StackExchange.Redis.Tests;

[Collection("Database")]
public class StringTest : TestBase
{
    public StringTest(DatabaseFixture fixture) : base(fixture)
    {
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
}
