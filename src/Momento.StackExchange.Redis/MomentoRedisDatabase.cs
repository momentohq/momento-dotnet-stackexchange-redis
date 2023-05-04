using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using Momento.Sdk;
using Momento.Sdk.Exceptions;
using Momento.Sdk.Responses;
using StackExchange.Redis;

namespace Momento.StackExchange.Redis;

public sealed partial class MomentoRedisDatabase : IDatabase, IMomentoRedisDatabase, IDisposable
{
    private ICacheClient Client;
    private string CacheName { get; set; }
    private static readonly string NOT_YET_SUPPORTED_FORMAT_STRING = "{0} is not yet supported in MomentoRedisClient. Please drop by our Discord at https://discord.com/invite/3HkAKjUZGq , or contact us at support@momentohq.com, and let us know what APIs you need!";
    private ILogger logger;

    public IConnectionMultiplexer Multiplexer => throw new NotImplementedException();

    public int Database => 0;

    public MomentoRedisDatabase(ICacheClient client, string cacheName, LoggerFactory? loggerFactory = null)
    {
        Client = client;
        CacheName = cacheName;
        logger = loggerFactory?.CreateLogger<MomentoRedisDatabase>() ?? NullLoggerFactory.Instance.CreateLogger<MomentoRedisDatabase>();
    }

    /// <summary>
    /// Converts a Momento Error to an exception in the StackExchange.Redis taxonomy.
    /// </summary>
    /// <remarks>
    /// The taxonomy here is all over the place:
    /// - <see cref="RedisException"/> is-a <see cref="Exception"/>
    /// - <see cref="RedisServerException"/> is-a <see cref="RedisException"/>
    /// - <see cref="RedisConnectionException"/> is-a <see cref="RedisException"/>
    /// - <see cref="RedisTimeoutException"/> is-a <see cref="System.TimeoutException"/>
    /// - <see cref="RedisCommandException"/> is-a <see cref="Exception"/>
    /// </remarks>
    /// <param name="error">The error response to convert.</param>
    /// <returns>An exception mapped to the StackExchange.Redis exception taxonomy.</returns>
    private Exception ConvertMomentoErrorToRedisException(IError error)
    {
        switch (error.ErrorCode)
        {
            case MomentoErrorCode.INVALID_ARGUMENT_ERROR:
                return new RedisCommandException(error.Message, error.InnerException);
            case MomentoErrorCode.TIMEOUT_ERROR:
                // We currently do not have a way to distinguish between a starved request
                // on the client queue vs a timeout in flight or on the server.
                // For now we default to the latter.
                return new RedisTimeoutException(error.Message, CommandStatus.Sent);
            case MomentoErrorCode.UNKNOWN_ERROR:
                return new RedisException(error.Message, error.InnerException);
            default:
                return new RedisServerException(error.Message);
        }
    }

    /// <summary>
    /// Create an exception for an unexpected response type event.
    /// </summary>
    /// <param name="response">The object outside the domain of expected types.</param>
    /// <returns>An exception object.</returns>
    private RedisException CreateUnexpectedResponseException(object response)
    {
        return new RedisException($"Unexpected response type. Got {response.GetType().Name}");
    }

    /// <summary>
    /// Awaits a task, returns its value, and unwraps any exceptions.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="result"></param>
    /// <returns></returns>
    private T AwaitTaskAndUnwrapException<T>(Task<T> result)
    {
        try
        {
            return result.Result;
        }
        catch (AggregateException e)
        {
            throw e.InnerException;
        }
    }

    private string BuildNotYetSupportedMessage(string thingNotSupported) => String.Format(NOT_YET_SUPPORTED_FORMAT_STRING, thingNotSupported);

    private NotImplementedException BuildCommandNotImplementedException(string name) => new NotImplementedException(BuildNotYetSupportedMessage($"Command {name}"));

    /// <summary>
    /// Warns if the flags are set to FireAndForget, as this is not supported.
    /// </summary>
    /// <remarks>
    /// This is a flag that probably predates the async/await pattern, and is not
    /// supported by MomentoRedisClient.
    /// </remarks>
    /// <param name="flags"></param>
    private void WarnOnFireAndForget(CommandFlags? flags = null)
    {
        if (flags.HasValue && flags == CommandFlags.FireAndForget)
        {
            logger.LogWarning("CommandFlags.FireAndForget is not supported in MomentoRedisClient. This command will be executed as request-response.");
        }
    }

    /// <summary>
    /// Ensure that the <see cref="When"/> parameter is not <see cref="When.Exists"/>, 
    /// as this is not supported.
    /// </summary>
    /// <param name="when"></param>
    /// <param name="name">Name of the method to write to the </param>
    /// <exception cref="NotImplementedException"></exception>
    private void AssertStringWhenImplemented(When when, string name)
    {
        if (when == When.Exists)
        {
            throw BuildCommandNotImplementedException($"{name} with When.Exists");
        }
    }

    public void Dispose()
    {
        Client.Dispose();
    }

    public IBatch CreateBatch(object? asyncState = null)
    {
        throw BuildCommandNotImplementedException("CreateBatch");
    }

    public ITransaction CreateTransaction(object? asyncState = null)
    {
        throw BuildCommandNotImplementedException("CreateTransaction");
    }

    public RedisValue DebugObject(RedisKey key, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("DebugObject");
    }

    public Task<RedisValue> DebugObjectAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("DebugObjectAsync");
    }

    public RedisResult Execute(string command, params object[] args)
    {
        throw BuildCommandNotImplementedException("Execute");
    }

    public RedisResult Execute(string command, ICollection<object> args, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("Execute");
    }

    public Task<RedisResult> ExecuteAsync(string command, params object[] args)
    {
        throw BuildCommandNotImplementedException("ExecuteAsync");
    }

    public Task<RedisResult> ExecuteAsync(string command, ICollection<object>? args, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("ExecuteAsync");
    }

    public EndPoint? IdentifyEndpoint(RedisKey key = default, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("IdentifyEndpoint");
    }

    public Task<EndPoint?> IdentifyEndpointAsync(RedisKey key = default, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("IdentifyEndpointAsync");
    }

    public bool IsConnected(RedisKey key, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("IsConnected");
    }

    public TimeSpan Ping(CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("Ping");
    }

    public Task<TimeSpan> PingAsync(CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("PingAsync");
    }

    public long Publish(RedisChannel channel, RedisValue message, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("Publish");
    }

    public Task<long> PublishAsync(RedisChannel channel, RedisValue message, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("PublishAsync");
    }

    public RedisResult ScriptEvaluate(string script, RedisKey[]? keys = null, RedisValue[]? values = null, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("ScriptEvaluate");
    }

    public RedisResult ScriptEvaluate(byte[] hash, RedisKey[]? keys = null, RedisValue[]? values = null, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("ScriptEvaluate");
    }

    public RedisResult ScriptEvaluate(LuaScript script, object? parameters = null, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("ScriptEvaluate");
    }

    public RedisResult ScriptEvaluate(LoadedLuaScript script, object? parameters = null, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("ScriptEvaluate");
    }

    public Task<RedisResult> ScriptEvaluateAsync(string script, RedisKey[]? keys = null, RedisValue[]? values = null, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("ScriptEvaluateAsync");
    }

    public Task<RedisResult> ScriptEvaluateAsync(byte[] hash, RedisKey[]? keys = null, RedisValue[]? values = null, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("ScriptEvaluateAsync");
    }

    public Task<RedisResult> ScriptEvaluateAsync(LuaScript script, object? parameters = null, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("ScriptEvaluateAsync");
    }

    public Task<RedisResult> ScriptEvaluateAsync(LoadedLuaScript script, object? parameters = null, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("ScriptEvaluateAsync");
    }

    public RedisResult ScriptEvaluateReadOnly(string script, RedisKey[]? keys = null, RedisValue[]? values = null, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("ScriptEvaluateReadOnly");
    }

    public RedisResult ScriptEvaluateReadOnly(byte[] hash, RedisKey[]? keys = null, RedisValue[]? values = null, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("ScriptEvaluateReadOnly");
    }

    public Task<RedisResult> ScriptEvaluateReadOnlyAsync(string script, RedisKey[]? keys = null, RedisValue[]? values = null, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("ScriptEvaluateReadOnlyAsync");
    }

    public Task<RedisResult> ScriptEvaluateReadOnlyAsync(byte[] hash, RedisKey[]? keys = null, RedisValue[]? values = null, CommandFlags flags = CommandFlags.None)
    {
        throw BuildCommandNotImplementedException("ScriptEvaluateReadOnlyAsync");
    }

    public bool TryWait(Task task)
    {
        throw BuildCommandNotImplementedException("TryWait");
    }

    public void Wait(Task task)
    {
        throw BuildCommandNotImplementedException("Wait");
    }

    public T Wait<T>(Task<T> task)
    {
        throw BuildCommandNotImplementedException("Wait");
    }

    public void WaitAll(params Task[] tasks)
    {
        throw BuildCommandNotImplementedException("WaitAll");
    }

    EndPoint? IDatabase.IdentifyEndpoint(RedisKey key, CommandFlags flags)
    {
        throw BuildCommandNotImplementedException("IdentifyEndpoint");
    }

    Task<EndPoint?> IDatabaseAsync.IdentifyEndpointAsync(RedisKey key, CommandFlags flags)
    {
        throw BuildCommandNotImplementedException("IdentifyEndpointAsync");
    }
}
