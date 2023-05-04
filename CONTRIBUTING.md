# Welcome to the Momento.StackExchange.Redis contributing guide :wave:

Thank you for taking your time to contribute to our Momento `StackExchange.Redis` wrapper!
<br/>
This guide will provide you information to start your own development and testing.
<br/>
Happy coding :dancer:
<br/>

## Requirements :coffee:

- The latest [.NET SDK](hhttps://learn.microsoft.com/en-us/dotnet/core/install/) is required
- A Momento Auth Token is required, you can generate one using the [Momento CLI](https://github.com/momentohq/momento-cli)

<br/>

## Build :computer:

```
make build
```

<br/>

## Formatting :flashlight:

```
make format
```

<br/>

## Tests :zap:

### To test against .NET Framework

You will need to be running on Windows to test against .NET Framework. If you cannot or
will not, the CI server runs these tests in a Windows image. You can test locally using
only .NET 6 as described below.

### Run integration tests against Momento on .NET6 and .NET Framework

```
TEST_AUTH_TOKEN=<YOUR_AUTH_TOKEN> make test-momento
```

### Run integration tests against Momento on .NET6 only

```
TEST_AUTH_TOKEN=<YOUR_AUTH_TOKEN> make test-net6-momento
```

### Run integration tests against Redis

First run Redis either natively, run Redis in a Docker container, or do your development in a devcontainer. Here is an example of running Redis in a Docker container:

```
docker run -it -p 6379:6379 redis
```

Then run the tests against .NET6 and .NET Framework:

```
make test-redis
```

or similarly to run against .NET6 only:

```
make test-net6-redis
```

This assumes the Redis server is running on `localhost:6379`. If using a different host and port, modify the above command as follows:

```
TEST_REDIS_ADDRESS=<IP:PORT> make test-redis
```

By running Redis on the local host, you can use the `redis-cli` to inspect the state of the Redis server as well as interactively debug the tests. We have also included a devcontainer config which will mount the entire coding environment into a Docker container, including the Redis server. See `.devcontainer` for more details.

### Run all tests

This will run both the integration tests against Momento and Redis. As above, we assume the Redis server is running on `localhost:6379`.

```
TEST_AUTH_TOKEN=<YOUR_AUTH_TOKEN> make test
```

or to test against .NET6 only:

```
TEST_AUTH_TOKEN=<YOUR_AUTH_TOKEN> make test-net6
```

# StackExchange.Redis internals

## CommandFlags

Each method supports taking a [`CommandFlags`](https://github.com/StackExchange/StackExchange.Redis/blob/7ad0add610f913479016bd012ea742d5d74f77b7/src/StackExchange.Redis/Enums/CommandFlags.cs) enum. According to `StackExchange.Redis`, these values are "behavior markers" for each command.

Most of the options indicate where the command will be executed in a Redis cluster, hence are irrelevant for Momento. Our client will ignore these options.

The only relevant option is `FireAndForget`, which will make the command execute asynchronously and return immediately. We currently do not support this. The client will ignore this, execute the command normally, and log a warning.

## When

Many methods support taking a `When` enum that specifies the condition under which the operation
should be performed. The default is `When.Always`, which means the operation should be
performed regardless of whether the item is in the cache.

Other options are `When.Exists` and `When.NotExists`, which will perform the operation only if the key already exists or does not exist, respectively. For `StringSet`, `When.Exists` has not been implemented and the client will throw an exception if used.
