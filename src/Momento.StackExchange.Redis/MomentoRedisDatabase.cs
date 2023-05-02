﻿using System.Net;
using Momento.Sdk;
using Momento.Sdk.Exceptions;
using StackExchange.Redis;

namespace Momento.StackExchange.Redis;

public sealed partial class MomentoRedisDatabase : IDatabase, IDisposable
{
    private ICacheClient Client;
    private string CacheName { get; set; }

    public IConnectionMultiplexer Multiplexer => throw new NotImplementedException();

    int IDatabase.Database => 0;

    public MomentoRedisDatabase(ICacheClient client, string cacheName)
    {
        Client = client;
        CacheName = cacheName;
    }

    /// <summary>
    /// Converts a Momento Error to an exception in the StackExchange.Redis taxonomy.
    /// </summary>
    /// <param name="message">The human-readable error message.</param>
    /// <param name="innerException">The concrete exception that was generated.</param>
    /// <param name="errorCode">The <see cref="MomentoErrorCode"/> of the particular exception.</param>
    /// <returns>An exception mapped to the StackExchange.Redis exception taxonomy.</returns>
    private Exception ConvertMomentoErrorToRedisException(string message, Exception innerException, MomentoErrorCode errorCode)
    {
        /// The taxonomy here is all over the place:
        /// - <see cref="RedisException"/> is-a <see cref="Exception"/>
        /// - <see cref="RedisServerException"/> is-a <see cref="RedisException"/>
        /// - <see cref="RedisConnectionException"/> is-a <see cref="RedisException"/>
        /// - <see cref="RedisTimeoutException"/> is-a <see cref="System.TimeoutException"/>
        /// - <see cref="RedisCommandException"/> is-a <see cref="Exception"/>
        switch (errorCode)
        {
            case MomentoErrorCode.INVALID_ARGUMENT_ERROR:
                return new RedisCommandException(message, innerException);
            case MomentoErrorCode.TIMEOUT_ERROR:
                // We currently do not have a way to distinguish between a starved request
                // on the client queue vs a timeout in flight or on the server.
                // For now we default to the latter.
                return new RedisTimeoutException(message, CommandStatus.Sent);
            case MomentoErrorCode.UNKNOWN_ERROR:
                return new RedisException(message, innerException);
            default:
                return new RedisServerException(message);
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

    public void Dispose()
    {
        Client.Dispose();
    }

    public IBatch CreateBatch(object? asyncState = null)
    {
        throw new NotImplementedException();
    }

    public ITransaction CreateTransaction(object? asyncState = null)
    {
        throw new NotImplementedException();
    }

    public RedisValue DebugObject(RedisKey key, CommandFlags flags = CommandFlags.None)
    {
        throw new NotImplementedException();
    }

    public Task<RedisValue> DebugObjectAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
    {
        throw new NotImplementedException();
    }

    public RedisResult Execute(string command, params object[] args)
    {
        throw new NotImplementedException();
    }

    public RedisResult Execute(string command, ICollection<object> args, CommandFlags flags = CommandFlags.None)
    {
        throw new NotImplementedException();
    }

    public Task<RedisResult> ExecuteAsync(string command, params object[] args)
    {
        throw new NotImplementedException();
    }

    public Task<RedisResult> ExecuteAsync(string command, ICollection<object>? args, CommandFlags flags = CommandFlags.None)
    {
        throw new NotImplementedException();
    }

    public EndPoint? IdentifyEndpoint(RedisKey key = default, CommandFlags flags = CommandFlags.None)
    {
        throw new NotImplementedException();
    }

    public Task<EndPoint?> IdentifyEndpointAsync(RedisKey key = default, CommandFlags flags = CommandFlags.None)
    {
        throw new NotImplementedException();
    }

    public bool IsConnected(RedisKey key, CommandFlags flags = CommandFlags.None)
    {
        throw new NotImplementedException();
    }

    public TimeSpan Ping(CommandFlags flags = CommandFlags.None)
    {
        throw new NotImplementedException();
    }

    public Task<TimeSpan> PingAsync(CommandFlags flags = CommandFlags.None)
    {
        throw new NotImplementedException();
    }

    public long Publish(RedisChannel channel, RedisValue message, CommandFlags flags = CommandFlags.None)
    {
        throw new NotImplementedException();
    }

    public Task<long> PublishAsync(RedisChannel channel, RedisValue message, CommandFlags flags = CommandFlags.None)
    {
        throw new NotImplementedException();
    }

    public RedisResult ScriptEvaluate(string script, RedisKey[]? keys = null, RedisValue[]? values = null, CommandFlags flags = CommandFlags.None)
    {
        throw new NotImplementedException();
    }

    public RedisResult ScriptEvaluate(byte[] hash, RedisKey[]? keys = null, RedisValue[]? values = null, CommandFlags flags = CommandFlags.None)
    {
        throw new NotImplementedException();
    }

    public RedisResult ScriptEvaluate(LuaScript script, object? parameters = null, CommandFlags flags = CommandFlags.None)
    {
        throw new NotImplementedException();
    }

    public RedisResult ScriptEvaluate(LoadedLuaScript script, object? parameters = null, CommandFlags flags = CommandFlags.None)
    {
        throw new NotImplementedException();
    }

    public Task<RedisResult> ScriptEvaluateAsync(string script, RedisKey[]? keys = null, RedisValue[]? values = null, CommandFlags flags = CommandFlags.None)
    {
        throw new NotImplementedException();
    }

    public Task<RedisResult> ScriptEvaluateAsync(byte[] hash, RedisKey[]? keys = null, RedisValue[]? values = null, CommandFlags flags = CommandFlags.None)
    {
        throw new NotImplementedException();
    }

    public Task<RedisResult> ScriptEvaluateAsync(LuaScript script, object? parameters = null, CommandFlags flags = CommandFlags.None)
    {
        throw new NotImplementedException();
    }

    public Task<RedisResult> ScriptEvaluateAsync(LoadedLuaScript script, object? parameters = null, CommandFlags flags = CommandFlags.None)
    {
        throw new NotImplementedException();
    }

    public RedisResult ScriptEvaluateReadOnly(string script, RedisKey[]? keys = null, RedisValue[]? values = null, CommandFlags flags = CommandFlags.None)
    {
        throw new NotImplementedException();
    }

    public RedisResult ScriptEvaluateReadOnly(byte[] hash, RedisKey[]? keys = null, RedisValue[]? values = null, CommandFlags flags = CommandFlags.None)
    {
        throw new NotImplementedException();
    }

    public Task<RedisResult> ScriptEvaluateReadOnlyAsync(string script, RedisKey[]? keys = null, RedisValue[]? values = null, CommandFlags flags = CommandFlags.None)
    {
        throw new NotImplementedException();
    }

    public Task<RedisResult> ScriptEvaluateReadOnlyAsync(byte[] hash, RedisKey[]? keys = null, RedisValue[]? values = null, CommandFlags flags = CommandFlags.None)
    {
        throw new NotImplementedException();
    }

    public bool TryWait(Task task)
    {
        throw new NotImplementedException();
    }

    public void Wait(Task task)
    {
        throw new NotImplementedException();
    }

    public T Wait<T>(Task<T> task)
    {
        throw new NotImplementedException();
    }

    public void WaitAll(params Task[] tasks)
    {
        throw new NotImplementedException();
    }

    EndPoint? IDatabase.IdentifyEndpoint(RedisKey key, CommandFlags flags)
    {
        throw new NotImplementedException();
    }

    Task<EndPoint?> IDatabaseAsync.IdentifyEndpointAsync(RedisKey key, CommandFlags flags)
    {
        throw new NotImplementedException();
    }
}
