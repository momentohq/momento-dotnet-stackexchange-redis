{{ ossHeader }}

# Momento StackExchange.Redis compatibility client

## What and why?

This project provides a Momento-backed implementation of [StackExchange.Redis](https://github.com/StackExchange/StackExchange.Redis)
The goal is to provide a drop-in replacement for [StackExchange.Redis](https://github.com/StackExchange/StackExchange.Redis) so that you can
use the same code with either a Redis server or with the Momento Cache service!

You can use Momento as your cache engine for any .NET frameworks that support a redis-backed cache.

## Usage

To switch your existing `StackExchange.Redis` application to use Momento, you only need to change the code where you construct your client object:

<table>
<tr>
 <td width="50%">With StackExchange.Redis client</td>
 <td width="50%">With Momento's StackExchange.Redis compatibility client</td>
</tr>
<tr>
 <td width="50%" valign="top">

```csharp
using StackExchange.Redis;
// Replace these values with your Redis server's details
var REDIS_HOST = "my.redis-server.com";
var REDIS_PORT = 6379;
// Create a Redis client
var connectionMultiplexer = ConnectionMultiplexer.Connect($"{REDIS_HOST}:{REDIS_PORT}");
var db = connectionMultiplexer.GetDatabase();
```

</td>
<td width="50%">

```csharp
// Import the Momento redis compatibility client.
using System;
using Momento.Auth;
using Momento.Config;
using Momento.Sdk;
using Momento.StackExchange.Redis;
// Initialize Momento's client.
var db = MomentoRedisDatabase(
  new CacheClient(
    config: Configurations.Laptop.v1(),
    authProvider: new EnvMomentoTokenProvider("MOMENTO_AUTH_TOKEN"),
    defaultTtl: TimeSpan.FromSeconds(60),
  }),
  "cache_name"
);
```

 </td>
</tr>
</table>

**NOTE**: The Momento `StackExchange.Redis` implementation currently supports simple key/value pairs (`GET`, `SET`). We will continue to add support for additional Redis APIs in the future; for more
information see the [Current Redis API Support](#current-redis-api-support) section later in this doc.

## Installation

The Momento StackExchange.Redis compatibility client is [available on NuGet](https://www.nuget.org/packages/Momento.StackExchange.Redis).
You can install it via:

```bash
dotnet add package Momento.StackExchange.Redis
```

## Examples

### Prerequisites

To run these examples, you will need a Momento auth token. You can generate one using the [Momento CLI](https://github.com/momentohq/momento-cli).

The examples will utlize your auth token via the environment variable `MOMENTO_AUTH_TOKEN` you set.

### Basic example

In the [`examples/Basic`](./examples/Basic) directory, you will find a simple CLI app that does some basic sets and gets
on string values. You can pass the `--momento` flag to run against Momento, or the `--redis` flag to run against
a local Redis (defaults to 127.0.0.0:6379 and is configurable).

You can run the example via `dotnet run`. To pass CLI options you will need to pass an extra `--` to tell `dotnet` that
the following options should be passed through.

Here's an example run against Momento Cache:

```bash
cd examples/Basic
export MOMENTO_AUTH_TOKEN=<your momento auth token goes here>
dotnet run -- momento -a $MOMENTO_AUTH_TOKEN -c cache
```

And the output should look something like this:

```
Using Momento as a backend for StackExchange.Redis, with cache 'cache'

Issuing a 'get' for key 'key', which we have not yet set.
result 'value='

Issuing a 'set' for key 'key', with value 'value='.
result: False

Issuing a 'get' for key 'key'.
result: 'value='
```

Similarly to test against a local Redis instance, run:

```bash
cd examples/Basic
dotnet run -- redis
```

## Current Redis API Support

This library supports the most popular Redis APIs, but does not yet support all Redis APIs. We currently support the most
common APIs related to string values (GET, SET, etc.). We will be adding support for additional
APIs in the future. If there is a particular API that you need support for, please drop by our [Discord](https://discord.com/invite/3HkAKjUZGq)
or e-mail us at [support@momentohq.com](mailto:support@momentohq.com) and let us know!

In the meantime, if you call a method from the `StackExchange.Redis` API that we do not yet support, you will get a `NotImplementedException`
letting you know that the method is not implemented yet.

### C# Compile-Time API Checking

If you'd like compile-time checking to tell you if you are using any APIs that we don't yet
support, we provide our own `IMomentoRedisDatabase` interface, which is a fully compatible subset of the official `StackExchange.Redis`
interface `IDatabase` but explicitly lists out the APIs that we currently support.

So, you can make a one-line change to your constructor call and get back an instance of this interface instead of the
default `StackExchange.Redis` interface, and then the C# compiler will catch any calls that your code is making to Redis
API methods that we don't yet support, so you'll know before you even try to run the code.

All you need to do is type the `MomentoRedisDatabase` object we instantiated above as
`IMomentoRedisDatabase`. Here's what it looks like:

```csharp
IMomentoRedisDatabase db = MomentoRedisDatabase(
  new CacheClient(
    config: Configurations.Laptop.v1(),
    authProvider: new EnvMomentoTokenProvider("MOMENTO_AUTH_TOKEN"),
    defaultTtl: TimeSpan.FromSeconds(60),
  }),
  "cache_name"
);
```

Exactly the same constructor as before other than the `IMomentoRedisDatabase` type, and now you get compile-time compatibility checking!\*

If you try this, and your code doesn't compile because we are missing APIs that you need, please do reach out to us!

\* Note that some flags are not supported. You may get a warning for those (eg `CommandFlags.FireAndForget`) or a runtime exception (`When.Exists`).

{{ ossFooter }}
