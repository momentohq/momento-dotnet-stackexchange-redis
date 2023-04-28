using Momento.StackExchange.Redis;

namespace Momento.StackExchange.Redis.Tests;

public class UnitTest1
{
    [Fact]
    public void Get_StubInvocation_ThrowsException()
    {
        var database = new MomentoRedisDatabase();
        Assert.Throws<NotImplementedException>(() => database.StringGet("key"));
    }
}
