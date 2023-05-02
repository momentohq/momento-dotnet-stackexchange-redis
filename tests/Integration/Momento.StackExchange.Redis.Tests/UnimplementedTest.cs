using StackExchange.Redis;

namespace Momento.StackExchange.Redis.Tests;

[Collection("Database")]
public class UnimplementedTest : TestBase
{
    public UnimplementedTest(DatabaseFixture fixture) : base(fixture)
    {
    }

    [Fact]
    public void GeoAdd_Unimplemented_ThrowsException()
    {
        var exception = Record.Exception(() => db.GeoAdd(Utils.GuidString(), new GeoEntry(0, 0, 0)));
        Assert.IsType<NotImplementedException>(exception);
        Assert.Equal("Command GeoAdd is not yet supported in MomentoRedisClient. Please drop by our Discord at https://discord.com/invite/3HkAKjUZGq , or contact us at support@momentohq.com, and let us know what APIs you need!", exception.Message);
    }
}
