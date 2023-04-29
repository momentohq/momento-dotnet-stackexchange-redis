using Microsoft.Extensions.Logging;
using Momento.Sdk;
using Momento.Sdk.Auth;
using Momento.Sdk.Config;
using StackExchange.Redis;

namespace Momento.StackExchange.Redis.Tests;

public class DatabaseFixture : IDisposable
{
    public IDatabase Database { get; private set; }
    private ICacheClient? Client;
    private string? CacheName;
    private bool UseRedis = Environment.GetEnvironmentVariable("USE_REDIS") == "true";

    public DatabaseFixture()
    {
        if (UseRedis)
        {
            Database = InitializeRedis();
        }
        else
        {
            Database = InitializeMomento();
        }
    }

    private IDatabase InitializeMomento()
    {
        var authProvider = new EnvMomentoTokenProvider("TEST_AUTH_TOKEN");
        CacheName = Environment.GetEnvironmentVariable("TEST_CACHE_NAME") ??
            throw new NullReferenceException("TEST_CACHE_NAME environment variable must be set.");
        var defaultTtl = TimeSpan.FromSeconds(10);

        Client = new CacheClient(Configurations.Laptop.Latest(LoggerFactory.Create(builder =>
                {
                    builder.AddSimpleConsole(options =>
                    {
                        options.IncludeScopes = true;
                        options.SingleLine = true;
                        options.TimestampFormat = "hh:mm:ss ";
                    });
                    builder.AddFilter("Grpc.Net.Client", LogLevel.Error);
                    builder.SetMinimumLevel(LogLevel.Information);
                })),
                authProvider, defaultTtl: defaultTtl);

        var result = Client.CreateCacheAsync(CacheName).Result;

        return new MomentoRedisDatabase(Client, CacheName);
    }

    private IDatabase InitializeRedis()
    {
        var configuration = Environment.GetEnvironmentVariable("REDIS_CONNECTION_STRING") ?? "localhost:6379";
        ConnectionMultiplexer redis = ConnectionMultiplexer.Connect(configuration);
        return redis.GetDatabase();
    }

    public void Dispose()
    {
        if (UseRedis)
        {
            return;
        }

        var result = Client?.DeleteCacheAsync(CacheName!).Result;
        Client?.Dispose();
    }
}

/// <summary>
/// Register the fixture in xUnit.
/// </summary>
[CollectionDefinition("Database")]
public class DatabaseCollection : ICollectionFixture<DatabaseFixture>
{

}
