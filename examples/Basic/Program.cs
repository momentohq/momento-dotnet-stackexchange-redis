using CommandLine;
using CommandLine.Text;
using Momento.Sdk;
using Momento.Sdk.Auth;
using Momento.Sdk.Config;
using Momento.StackExchange.Redis;
using StackExchange.Redis;

public class Basic
{
    public static async Task Main(string[] args)
    {
        var options = ParseCommandLineArgs(args);

        /// This will construct a regular StackExchange.Redis client <see cref="IDatabase"/>
        /// or a Momento-backed client <see cref="MomentoRedisDatabase"/> depending on the
        /// command line arguments.
        var db = await InitializeStackExchangeRedis(options);

        // From this point forward the code will work with either Momento or Redis, with no changes!
        RedisKey key = "key";
        RedisValue value = "value=";

        Console.WriteLine();
        Console.WriteLine($"Issuing a 'get' for key '{key}', which we have not yet set.");
        var getValue = await db.StringGetAsync(key);
        Console.WriteLine($"result '{getValue}'");

        Console.WriteLine();
        Console.WriteLine($"Issuing a 'set' for key '{key}', with value '{value}'.");
        var setReturnValue = await db.StringSetAsync(key, value, TimeSpan.FromSeconds(60), When.NotExists);
        Console.WriteLine($"result: {setReturnValue}");

        Console.WriteLine();
        Console.WriteLine($"Issuing a 'get' for key '{key}'.");
        getValue = await db.StringGetAsync(key);
        Console.WriteLine($"result: '{getValue}'");
    }

    private static async Task<IDatabase> InitializeStackExchangeRedis(ParserResult<object> options)
    {
        IDatabase db = null!;
        await options.WithParsedAsync<MomentoOptions>(async (momentoOptions) =>
        {
            var client = CreateMomentoClient(momentoOptions.Token, momentoOptions.DefaultTtl);
            await client.CreateCacheAsync(momentoOptions.Cache);
            db = new MomentoRedisDatabase(client, momentoOptions.Cache);
        });
        options.WithParsed<RedisOptions>((redisOptions) =>
        {
            db = CreateRedisClient(redisOptions.Host, redisOptions.Port);
        });
        return db;
    }

    private static IDatabase CreateRedisClient(string host, int port)
    {
        var redis = ConnectionMultiplexer.Connect($"{host}:{port}");
        return redis.GetDatabase();
    }

    private static ICacheClient CreateMomentoClient(string authToken, TimeSpan defaultTtl)
    {
        return new CacheClient(Configurations.Laptop.V1(),
            new StringMomentoTokenProvider(authToken),
            defaultTtl);
    }

    private static ParserResult<object> ParseCommandLineArgs(string[] args)
    {
        var parser = new CommandLine.Parser(with => with.HelpWriter = null);
        var parserResult = parser.ParseArguments<MomentoOptions, RedisOptions>(args);
        parserResult.WithNotParsed(errors => DisplayHelp(parserResult, errors));
        return parserResult;
    }

    [Verb("momento", HelpText = "Use Momento as a backend for StackExchange.Redis")]
    private class MomentoOptions
    {
        [Option('t', "token", Required = true, HelpText = "Momento Auth Token")]
        public string Token { get; set; } = default!;

        [Option('c', "cache", Required = true, HelpText = "Momento Cache Name")]
        public string Cache { get; set; } = default!;

        [Option('d', "defaultTtlSeconds", Required = false, HelpText = "Default TTL for keys")]
        public int DefaultTtlSeconds { get; set; } = 60;

        public TimeSpan DefaultTtl => TimeSpan.FromSeconds(DefaultTtlSeconds);
    }

    [Verb("redis", HelpText = "Use Redis as a backend for StackExchange.Redis")]
    private class RedisOptions
    {
        [Option('h', "host", Required = false, HelpText = "Redis Host")]
        public string Host { get; set; } = "localhost";

        [Option('p', "port", Required = false, HelpText = "Redis Port")]
        public int Port { get; set; } = 6379;
    }

    private static void DisplayHelp<T>(ParserResult<T> result, IEnumerable<Error> errors)
    {
        var helpText = HelpText.AutoBuild(result, h =>
        {
            h.AdditionalNewLineAfterOption = false;
            h.Heading = "Momento.StackExchange.Redis Basic Example";
            h.Copyright = "Copyright (c) 2023 Momento";
            h.AddEnumValuesToHelpText = true;
            return HelpText.DefaultParsingErrorsHandler(result, h);
        }, e => e);
        Console.WriteLine(helpText);
        Environment.Exit(1);
    }
}
