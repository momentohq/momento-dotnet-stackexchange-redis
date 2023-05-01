using StackExchange.Redis;


namespace Momento.StackExchange.Redis.Tests;

public class TestBase
{
    protected readonly IDatabase db;
    protected bool useRedis;

    public TestBase(DatabaseFixture fixture)
    {
        db = fixture.Database;
        useRedis = fixture.UseRedis;
    }
}
