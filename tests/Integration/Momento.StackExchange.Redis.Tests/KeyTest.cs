using StackExchange.Redis;

namespace Momento.StackExchange.Redis.Tests;

[Collection("Database")]
public class KeyTest : TestBase
{
    public KeyTest(DatabaseFixture fixture) : base(fixture)
    {
    }

    [Theory]
    [InlineData(ExpireWhen.GreaterThanCurrentExpiry)]
    [InlineData(ExpireWhen.HasExpiry)]
    [InlineData(ExpireWhen.HasNoExpiry)]
    [InlineData(ExpireWhen.LessThanCurrentExpiry)]
    public void KeyExpire_WithExpireWhen_ThrowsException(ExpireWhen expireWhen)
    {
        if (useRedis)
        {
            // Redis supports this
            return;
        }
        var key = Utils.GuidString();
        var value = Utils.GuidString();

        var exception = Record.Exception(() => db.KeyExpire(key, TimeSpan.FromSeconds(60), expireWhen));
        Assert.IsType<NotImplementedException>(exception);
        Assert.StartsWith($"Command KeyExpireAsync with when={expireWhen} is not yet supported", exception.Message);
    }

    [Theory]
    [InlineData(ExpireWhen.GreaterThanCurrentExpiry)]
    [InlineData(ExpireWhen.HasExpiry)]
    [InlineData(ExpireWhen.HasNoExpiry)]
    [InlineData(ExpireWhen.LessThanCurrentExpiry)]
    public async Task KeyExpireAsync_WithExpireWhen_ThrowsException(ExpireWhen expireWhen)
    {
        if (useRedis)
        {
            // Redis supports this
            return;
        }
        var key = Utils.GuidString();
        var value = Utils.GuidString();

        var exception = await Record.ExceptionAsync(async () => await db.KeyExpireAsync(key, TimeSpan.FromSeconds(60), expireWhen));
        Assert.IsType<NotImplementedException>(exception);
        Assert.StartsWith($"Command KeyExpireAsync with when={expireWhen} is not yet supported", exception.Message);
    }

    [Fact]
    public void KeyExpire_NullTimeSpan_Noop()
    {
        var key = Utils.GuidString();
        var value = Utils.GuidString();

        db.StringSet(key, value);
        var expireResult = db.KeyExpire(key, (TimeSpan?)null);

        Assert.False(expireResult);

        var actual = db.StringGet(key);
        Assert.Equal(value, actual);
    }

    [Fact]
    public async Task KeyExpireAsync_NullTimeSpan_Noop()
    {
        var key = Utils.GuidString();
        var value = Utils.GuidString();

        await db.StringSetAsync(key, value);
        var expireResult = await db.KeyExpireAsync(key, (TimeSpan?)null);

        Assert.False(expireResult);

        var actual = await db.StringGetAsync(key);
        Assert.Equal(value, actual);
    }

    [Fact]
    public void KeyExpire_NullDateTime_Noop()
    {
        var key = Utils.GuidString();
        var value = Utils.GuidString();

        db.StringSet(key, value);
        var expireResult = db.KeyExpire(key, (DateTime?)null);

        Assert.False(expireResult);

        var actual = db.StringGet(key);
        Assert.Equal(value, actual);
    }

    [Fact]
    public async Task KeyExpireAsync_NullDateTime_Noop()
    {
        var key = Utils.GuidString();
        var value = Utils.GuidString();

        await db.StringSetAsync(key, value);
        var expireResult = await db.KeyExpireAsync(key, (DateTime?)null);

        Assert.False(expireResult);

        var actual = await db.StringGetAsync(key);
        Assert.Equal(value, actual);
    }

    [Fact]
    public void KeyExpire_PastDateTime_ShouldExpire()
    {
        var key = Utils.GuidString();
        var value = Utils.GuidString();

        db.StringSet(key, value, TimeSpan.FromSeconds(60));
        var expireResult = db.KeyExpire(key, DateTime.Now.AddSeconds(-60));

        Assert.True(expireResult);

        var actual = db.StringGet(key);
        Assert.True(actual.IsNull);
    }

    // async version of the above
    [Fact]
    public async Task KeyExpireAsync_PastDateTime_ShouldExpire()
    {
        var key = Utils.GuidString();
        var value = Utils.GuidString();

        await db.StringSetAsync(key, value, TimeSpan.FromSeconds(60));
        var expireResult = await db.KeyExpireAsync(key, DateTime.Now.AddSeconds(-60));

        Assert.True(expireResult);

        var actual = await db.StringGetAsync(key);
        Assert.True(actual.IsNull);
    }

    [Fact]
    public void KeyExpire_NegativeTimeSpan_ShouldExpire()
    {
        var key = Utils.GuidString();
        var value = Utils.GuidString();

        db.StringSet(key, value, TimeSpan.FromSeconds(60));
        var expireResult = db.KeyExpire(key, TimeSpan.FromSeconds(-60));

        Assert.True(expireResult);

        var actual = db.StringGet(key);
        Assert.True(actual.IsNull);
    }

    [Fact]
    public async Task KeyExpireAsync_NegativeTimeSpan_ShouldExpire()
    {
        var key = Utils.GuidString();
        var value = Utils.GuidString();

        await db.StringSetAsync(key, value, TimeSpan.FromSeconds(60));
        var expireResult = await db.KeyExpireAsync(key, TimeSpan.FromSeconds(-60));

        Assert.True(expireResult);

        var actual = await db.StringGetAsync(key);
        Assert.True(actual.IsNull);
    }

    [Fact]
    public void KeyExpire_NegativeTimeSpanKeyDoesntExist_ReturnsFalse()
    {
        var key = Utils.GuidString();

        var expireResult = db.KeyExpire(key, TimeSpan.FromSeconds(-60));

        if (useRedis)
        {
            Assert.False(expireResult);
        }
        else
        {
            // Momento doesn't return delete status, so we default to true
            Assert.True(expireResult);
        }
    }

    [Fact]
    public async Task KeyExpireAsync_NegativeTimeSpanKeyDoesntExist_ReturnsFalse()
    {
        var key = Utils.GuidString();

        var expireResult = await db.KeyExpireAsync(key, TimeSpan.FromSeconds(-60));

        if (useRedis)
        {
            Assert.False(expireResult);
        }
        else
        {
            // Momento doesn't return delete status, so we default to true
            Assert.True(expireResult);
        }
    }

    [Fact]
    public void KeyExpire_TimeSpanWithSmallTtl_ItemExpires()
    {
        var key = Utils.GuidString();
        var value = Utils.GuidString();

        db.StringSet(key, value, TimeSpan.FromSeconds(60));

        var expireResult = db.KeyExpire(key, TimeSpan.FromSeconds(1));
        Assert.True(expireResult);

        Thread.Sleep(2000);

        var getResult = db.StringGet(key);
        Assert.True(getResult.IsNull);
    }

    [Fact]
    public async Task KeyExpireAsync_TimeSpanWithSmallTtl_ShouldExpire()
    {
        var key = Utils.GuidString();
        var value = Utils.GuidString();

        await db.StringSetAsync(key, value, TimeSpan.FromSeconds(60));

        var expireResult = await db.KeyExpireAsync(key, TimeSpan.FromSeconds(1));
        Assert.True(expireResult);

        await Task.Delay(2000);

        var getResult = await db.StringGetAsync(key);
        Assert.True(getResult.IsNull);
    }

    [Fact]
    public void KeyExpire_DateTimeInNearFuture_ShouldExpire()
    {
        var key = Utils.GuidString();
        var value = Utils.GuidString();

        db.StringSet(key, value, TimeSpan.FromSeconds(60));

        var expireResult = db.KeyExpire(key, DateTime.Now.AddSeconds(2));
        Assert.True(expireResult);

        Thread.Sleep(2000);

        var getResult = db.StringGet(key);
        Assert.True(getResult.IsNull);
    }

    [Fact]
    public async Task KeyExpireAsync_DateTimeInNearFuture_ShouldExpire()
    {
        var key = Utils.GuidString();
        var value = Utils.GuidString();

        await db.StringSetAsync(key, value, TimeSpan.FromSeconds(60));

        var expireResult = await db.KeyExpireAsync(key, DateTime.Now.AddSeconds(2));
        Assert.True(expireResult);

        await Task.Delay(2000);

        var getResult = await db.StringGetAsync(key);
        Assert.True(getResult.IsNull);
    }
}
