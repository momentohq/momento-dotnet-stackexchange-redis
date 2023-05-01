using StackExchange.Redis;


namespace Momento.StackExchange.Redis.Tests;

public class TestBase
{
    protected readonly IDatabase db;

    public TestBase(DatabaseFixture fixture)
    {
        this.db = fixture.Database;
    }
}
