using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using StackExchange.Redis;

namespace Metapsi.Messaging;

/// <summary>
/// Generic class used to differentiate message transport direction
/// </summary>
/// <typeparam name="T"></typeparam>
public class Inward<T>
{
    public Inward() { }
    public Inward(T message)
    {
        Message = message;
    }
    public T Message { get; set; }
}

/// <summary>
/// Generic class used to differentiate message transport direction
/// </summary>
/// <typeparam name="T"></typeparam>
public class Outward<T>
{
    public Outward() { }
    public Outward(T message)
    {
        Message = message;
    }

    public T Message { get; set; }
}

public class MessagesAvailable
{
    public string RedisQueue { get; set; }
    public int ReadCount { get; set; } = 1;
}

public interface IMessagingTransportBuilder
{

}

internal class OutgoingMessageEvent : IData
{
    public string Type { get; set; }
    public string Json { get; set; }
}


internal class IncomingMessageEvent<T> : IData
{
    public T Message { get; set; }

    public IncomingMessageEvent(T message)
    {
        this.Message = message;
    }
}

internal static class IncomingMessageEvent
{
    public static IData Create(object message)
    {
        var incomingEventType = typeof(IncomingMessageEvent<>).MakeGenericType(message.GetType());
        return Activator.CreateInstance(incomingEventType, message) as IData;
    }
}

internal class MessagingTransportBuilder : IMessagingTransportBuilder
{
    internal ApplicationSetup ApplicationSetup { get; set; }
    internal ImplementationGroup ImplementationGroup { get; set; }
    internal Connections.State Connections { get; set; }
    internal MessageReceiver MessageProcessor { get; set; }
    internal MessagePoster MessagePoster { get; set; }
    public bool SubscribedToAny { get; set; } = false;
}

public static class Redis
{
    public const long AllMessages = -1;

    public static async Task<List<RedisMessage>> ReadFromQueue(CommandContext commandContext, string redisQueueUrl, long messagesCount = AllMessages)
    {
        List<RedisMessage> messages = new List<RedisMessage>();

        var redisChannel = new RedisChannel(redisQueueUrl);

        var redisConnection = await commandContext.Do(Connections.GetRedisConnection, RedisServer.Parse(redisChannel.Server));

        if (messagesCount <= 0)
        {
            messagesCount = await redisConnection.GetDatabase().ListLengthAsync(redisChannel.ChannelName);
        }
        if (messagesCount > 0)
        {
            RedisValue[] values = await redisConnection.GetDatabase().ListLeftPopAsync(redisChannel.ChannelName, messagesCount);

            if (values != null)
            {
                foreach (RedisValue v in values)
                {
                    if (v != RedisValue.Null && v != RedisValue.EmptyString)
                    {
                        RedisMessage redisMessage = Serialize.FromJson<RedisMessage>(v);
                        messages.Add(redisMessage);
                    }
                }
            }
        }

        return messages;
    }

    public static async Task WriteToQueue(CommandContext commandContext, string redisQueueUrl, RedisMessage redisMessage)
    {
        var redisChannel = new RedisChannel(redisQueueUrl);
        ConnectionMultiplexer connection = await commandContext.Do(Connections.GetRedisConnection, RedisServer.Parse(redisChannel.Server));
        string serialized = Serialize.ToJson(redisMessage);
        await connection.GetDatabase().ListRightPushAsync(redisChannel.ChannelName, serialized);
    }

    public static async Task SubscribeTo(CommandContext commandContext, string redisSubUrl, Func<RedisMessage, Task> onMessage)
    {
        if (string.IsNullOrEmpty(redisSubUrl))
            return;

        var redisChannel = new RedisChannel(redisSubUrl);

        var redisConnection = await commandContext.Do(Connections.GetRedisConnection, RedisServer.Parse(redisChannel.Server));

        var subscriber = redisConnection.GetSubscriber();
        await subscriber.SubscribeAsync(redisChannel.ChannelName, async (channel, message) =>
        {
            string messageValue = string.Empty;
            if (message.HasValue)
            {
                messageValue = message;
            }

            if (!string.IsNullOrEmpty(messageValue))
            {
                RedisMessage notification = Serialize.FromJson<RedisMessage>(messageValue);
                await onMessage(notification);
            }
        });
    }

    public static async Task UnsubscribeFrom(CommandContext commandContext, string redisSubUrl)
    {
        if (string.IsNullOrEmpty(redisSubUrl))
            return;

        var redisChannel = new RedisChannel(redisSubUrl);

        var redisConnection = await commandContext.Do(Connections.GetRedisConnection, RedisServer.Parse(redisChannel.Server));

        var subscriber = redisConnection.GetSubscriber();
        await subscriber.UnsubscribeAsync(redisChannel.ChannelName);
    }

    public static async Task Notify(CommandContext commandContext, string redisPubUrl, RedisMessage redisMessage)
    {
        if (string.IsNullOrEmpty(redisPubUrl))
            return;

        var redisChannel = new RedisChannel(redisPubUrl);

        var redisConnection = await commandContext.Do(Connections.GetRedisConnection, RedisServer.Parse(redisChannel.Server));

        var subscriber = redisConnection.GetSubscriber();
        string serialized = Serialize.ToJson(redisMessage);
        await subscriber.PublishAsync(redisChannel.ChannelName, serialized, CommandFlags.FireAndForget);
    }
}

public static class MessagingExtensions
{
    public static IMessagingTransportBuilder AddMessagingTransport(
        this ApplicationSetup applicationSetup,
        ImplementationGroup ig,
        string pubRedisUrl = null)
    {
        var builder = new MessagingTransportBuilder()
        {
            ApplicationSetup = applicationSetup,
            ImplementationGroup = ig,
            MessageProcessor = applicationSetup.AddBusinessState(new MessageReceiver()),
            Connections = applicationSetup.AddBusinessState(new Connections.State())
        };

        ig.MapRequest(Connections.GetRedisConnection, async (rc, redisServer) =>
        {
            return await rc.Using(builder.Connections, ig).EnqueueRequest(Connections.GetConnection, redisServer);
        });

        if (pubRedisUrl != null)
        {
            var redisChannel = new RedisChannel(pubRedisUrl);
            builder.MessagePoster = applicationSetup.AddBusinessState(new MessagePoster()
            {
                ChannelName = redisChannel.ChannelName,
                RedisServer = RedisServer.Parse(redisChannel.RedisUrl)
            });
        }

        builder.ApplicationSetup.MapEvent<OutgoingMessageEvent>(e =>
        {
            if (string.IsNullOrEmpty(pubRedisUrl))
            {
                throw new Exception("Outgoing messages cannot be sent because publish channel is not configured");
            }
            else
            {
                e.Using(builder.MessagePoster, builder.ImplementationGroup).EnqueueCommand(PostRedisMessage, e.EventData);
            }
        });

        return builder;
    }

    public static IMessagingTransportBuilder SubscribeTo(
        this IMessagingTransportBuilder builder, 
        string redisChannel,
        bool autoStartListening = true,
        bool autoReadPendingQueue = true)
    {
        if (!string.IsNullOrEmpty(redisChannel))
        {
            MessagingTransportBuilder typedBuilder = builder as MessagingTransportBuilder;
            typedBuilder.MessageProcessor.SubscriptionChannels.Add(redisChannel);

            if (!typedBuilder.SubscribedToAny)
            {
                typedBuilder.SubscribedToAny = true;
                typedBuilder.OnMessage<MessagesAvailable>(async (commandContext, messagesAvailable) =>
                {
                    await ReadMessages(commandContext, typedBuilder.MessageProcessor, messagesAvailable.RedisQueue, messagesAvailable.ReadCount);
                });
            }

            if (autoStartListening)
            {
                typedBuilder.ApplicationSetup.MapEvent<ApplicationRevived>(e =>
                {
                    e.Using(typedBuilder.MessageProcessor, typedBuilder.ImplementationGroup).EnqueueCommand(StartListening);
                });
            }

            if (autoReadPendingQueue)
            {
                typedBuilder.ApplicationSetup.MapEvent<ApplicationRevived>(e =>
                {
                    e.Using(typedBuilder.MessageProcessor, typedBuilder.ImplementationGroup).EnqueueCommand(ReadMessages, redisChannel, Redis.AllMessages);
                });
            }
        }

        return builder;
    }

    private static async Task ReadMessages(CommandContext commandContext, MessageReceiver messageReceiver, string redisQueueUrl, long messagesCount = 1)
    {
        var messages = await Redis.ReadFromQueue(commandContext, redisQueueUrl, messagesCount);

        foreach (var redisMessage in messages)
        {
            RaiseIncomingMessageEvent(commandContext, messageReceiver, redisMessage);
        }
    }

    private static async Task StartListening(CommandContext commandContext, MessageReceiver messageReceiver, string subscriptionChannel)
    {
        if (string.IsNullOrEmpty(subscriptionChannel))
            return;

        if (!messageReceiver.ListeningOnChannels.Contains(subscriptionChannel))
        {
            var updated = new HashSet<string>(messageReceiver.ListeningOnChannels);
            updated.Add(subscriptionChannel);
            messageReceiver.ListeningOnChannels = updated;

            var redisChannel = new RedisChannel(subscriptionChannel);

            var redisConnection = await commandContext.Do(Connections.GetRedisConnection, RedisServer.Parse(redisChannel.Server));

            redisConnection.ConnectionFailed += (s, e) => { commandContext.Logger.LogInfo($"Redis connection failed to channel {redisChannel.RedisUrl}"); };
            redisConnection.ConnectionRestored += (s, e) => { commandContext.Logger.LogInfo($"Redis connection restored to channel {redisChannel.RedisUrl}"); };
            var subscriber = redisConnection.GetSubscriber();
            await subscriber.SubscribeAsync(redisChannel.ChannelName, async (channel, message) =>
            {
                string messageValue = string.Empty;
                if (message.HasValue)
                {
                    messageValue = message;
                }

                if (!string.IsNullOrEmpty(messageValue))
                {
                    commandContext.Logger.LogDebug($"Redis raw notification: {messageValue}");
                    RedisMessage notification = Serialize.FromJson<RedisMessage>(messageValue);
                    RaiseIncomingMessageEvent(commandContext, messageReceiver, notification);
                }
            });
        }
    }

    private static async Task StartListening(CommandContext commandContext, MessageReceiver messageReceiver)
    {
        foreach (string channel in messageReceiver.SubscriptionChannels)
        {
            await StartListening(commandContext, messageReceiver, channel);
        }
    }

    private static void RaiseIncomingMessageEvent(CommandContext commandContext, MessageReceiver messageReceiver, RedisMessage message)
    {
        if (string.IsNullOrEmpty(message.Type))
        {
            commandContext.Logger.LogError($"Redis message has no type: {Metapsi.Serialize.ToJson(message)}");
            return;
        }

        var type = Type.GetType(message.Type);

        if (type == null)
        {
            commandContext.Logger.LogError($"Redis message has unknown type: {Metapsi.Serialize.ToJson(message)}");
            return;
        }

        var messagePayload = Serialize.FromJson(type, message.Payload);

        var messageReceivedEvent = IncomingMessageEvent.Create(messagePayload);

        commandContext.PostEvent(messageReceivedEvent);
    }

    public static void RaiseNotification<T>(this CommandContext commandContext, T messagingEvent)
    {
        var type = messagingEvent.GetType();

        // Send internally to Redis notifier
        commandContext.PostEvent(new OutgoingMessageEvent()
        {
            // Use pseudo assembly qualified name, ignoring version and other stuff,
            // as they might be not in sync between sender & receiver
            Type = $"{type.FullName}, {type.Assembly.GetName().Name}",
            Json = Metapsi.Serialize.ToJson(messagingEvent)
        });
    }

    private static async Task PostRedisMessage(CommandContext commandContext, MessagePoster poster, OutgoingMessageEvent outgoingMessage)
    {
        ConnectionMultiplexer connection = await commandContext.Do(Connections.GetRedisConnection, poster.RedisServer);

        RedisMessage notification = new RedisMessage(outgoingMessage.Type, outgoingMessage.Json);
        string serialized = Serialize.ToJson(notification);

        await connection.GetSubscriber().PublishAsync(poster.ChannelName, serialized, CommandFlags.FireAndForget);
    }

    public static void OnMessage<T>(this IMessagingTransportBuilder messagingContext, Func<CommandContext, T, Task> onMessage)
    {
        MessagingTransportBuilder typedContext = messagingContext as MessagingTransportBuilder;

        typedContext.ApplicationSetup.MapEvent<IncomingMessageEvent<T>>(e =>
        {
            e.Using(typedContext.MessageProcessor, typedContext.ImplementationGroup).EnqueueCommand(
                async (CommandContext commandContext, MessageReceiver state) =>
                {
                    await onMessage(commandContext, e.EventData.Message);
                });
        });
    }
}

public static class Connections
{
    public static Request<ConnectionMultiplexer, RedisServer> GetRedisConnection { get; set; } = new Request<ConnectionMultiplexer, RedisServer>(nameof(GetRedisConnection));

    public class State
    {
        public Dictionary<string, ConnectionMultiplexer> Connections { get; set; } = new Dictionary<string, ConnectionMultiplexer>();
    }

    public static async Task<ConnectionMultiplexer> GetConnection(CommandContext commandContext, State state, RedisServer redisServer)
    {
        var redisUrl = redisServer.ToString();
        if (!state.Connections.ContainsKey(redisUrl))
        {
            var newConnection = ConnectionMultiplexer.Connect(redisUrl);
            state.Connections[redisUrl] = newConnection;
        }

        return state.Connections[redisUrl];
    }
}

internal class MessageReceiver
{
    // The channels to subscribe to
    public HashSet<string> SubscriptionChannels { get; set; } = new();

    // The channels currently subscribed to (for delayed subscription or unsubscribe)
    public HashSet<string> ListeningOnChannels { get; set; } = new();
}

internal class MessagePoster
{
    public RedisServer RedisServer { get; set; }
    public string ChannelName { get; set; }
}