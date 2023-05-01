using Momento.Sdk;
using StackExchange.Redis;


namespace Momento.StackExchange.Redis.Tests;

public class TestBase
{
    protected readonly IDatabase db;
    protected readonly ICacheClient? client;
    protected bool useRedis;

    public TestBase(DatabaseFixture fixture)
    {
        db = fixture.Database;
        client = fixture.Client;
        useRedis = fixture.UseRedis;
    }
}
