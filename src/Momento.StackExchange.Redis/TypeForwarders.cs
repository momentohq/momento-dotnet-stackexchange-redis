using System.Runtime.CompilerServices;
using StackExchange.Redis;

/*
 * If someone opts to only install Momento.StackExchange.Redis,
 * they will need access to the StackExchange.Redis types used
 * in the interfaces.
 *
 * This file forwards the types used in the interfaces to the
 * types in StackExchange.Redis.
 */
[assembly: TypeForwardedTo(typeof(RedisKey))]
[assembly: TypeForwardedTo(typeof(RedisValue))]
