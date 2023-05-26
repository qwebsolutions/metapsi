using StackExchange.Redis;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Metapsi
{
    public static partial class RedisListener
    {
        public static partial class Event
        {
            public partial class NotificationReceived : IData
            {
                public string RedisUrl { get; set; }
                public string ChannelName { get; set; }
                public string NotificationType { get; set; }
                public string Payload { get; set; } = string.Empty;
            }

            public partial class RedisListenerSuccessfulSubscribe : IData
            {
                public string RedisUrl { get; set; }
                public string ChannelName { get; set; }
            }
        }

        public class State
        {
            public bool IsShuttingDown { get; set; } = false;
            internal Dictionary<string, ConnectionMultiplexer> connections = new Dictionary<string, ConnectionMultiplexer>();
        }

        public static async Task StartListening(CommandContext commandContext, State state, RedisChannel redisChannel)
        {
            if(string.IsNullOrEmpty(redisChannel.ChannelName))
            {
                commandContext.Logger.LogInfo($"Redis channel is empty, listening skipped");
                return;
            }

            commandContext.Logger.LogInfo($"Start listening {redisChannel}");
            var redisConnection = RedisConnections.GetConnection(state.connections, redisChannel.RedisUrl);
            redisConnection.ConnectionFailed += (s, e) => { commandContext.Logger.LogInfo($"Redis connection failed to channel {redisChannel.RedisUrl}"); };
            redisConnection.ConnectionRestored += (s, e) => { commandContext.Logger.LogInfo($"Redis connection restored to channel {redisChannel.RedisUrl}"); };
            var subscriber = redisConnection.GetSubscriber();
            await subscriber.SubscribeAsync(redisChannel.ChannelName, async (channel, message) =>
            {
                if (!state.IsShuttingDown)
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

                        commandContext.PostEvent(new Event.NotificationReceived()
                        {
                            NotificationType = notification.Type,
                            Payload = notification.Payload,
                            ChannelName = redisChannel.ChannelName,
                            RedisUrl = redisChannel.RedisUrl
                        });
                    }
                }
            });
            commandContext.PostEvent(new Event.RedisListenerSuccessfulSubscribe()
            {
                ChannelName = redisChannel.ChannelName,
                RedisUrl = redisChannel.RedisUrl
            });
        }

        public static async Task StopListening(CommandContext commandContext, State state)
        {
            state.IsShuttingDown = true;
        }
    }

    public class RedisChannel
    {
        public string Server { get; set; }
        public int Port { get; set; } = 6379;
        public string ChannelName { get; set; }

        public RedisChannel() { }

        public RedisChannel(RedisResource redisResource)
        {
            this.Server = redisResource.Server;
            this.Port = redisResource.Port;
            this.ChannelName = redisResource.Path;
        }

        public RedisChannel(string qualifiedChannelName)
        {
            RedisResource redisResource = RedisResource.Parse(qualifiedChannelName);
            this.Server = redisResource.Server;
            this.Port = redisResource.Port;
            this.ChannelName = redisResource.Path;
        }

        public RedisChannel(string redisUrl, string channelName)
        {
            var redisServer = RedisServer.Parse(redisUrl);
            this.Server = redisServer.Server;
            this.Port = redisServer.Port;
            this.ChannelName = channelName;
        }

        public override string ToString()
        {
            return $"{this.Server}:{this.Port}/{this.ChannelName}";
        }

        public string RedisUrl => $"{this.Server}:{this.Port}";
    }

    public class RedisQueue
    {
        public string Server { get; set; }
        public int Port { get; set; } = 6379;
        public string QueueName { get; set; }


        public RedisQueue(RedisResource redisResource)
        {
            this.Server = redisResource.Server;
            this.Port = redisResource.Port;
            this.QueueName = redisResource.Path;
        }

        public RedisQueue(string qualifiedQueueName)
        {
            RedisResource redisResource = RedisResource.Parse(qualifiedQueueName);
            this.Server = redisResource.Server;
            this.Port = redisResource.Port;
            this.QueueName = redisResource.Path;
        }

        public override string ToString()
        {
            return $"{this.Server}:{this.Port}/{this.QueueName}";
        }

        public string RedisUrl => $"{this.Server}:{this.Port}";
    }

    public class RedisResource
    {
        public string Server { get; set; }
        public int Port { get; set; } = 6379;
        public string Path { get; set; }

        public static RedisResource Parse(string qualifiedResource)
        {
            if (string.IsNullOrWhiteSpace(qualifiedResource))
                return new RedisResource();

            var segments = qualifiedResource.Split('/').ToList();
            if (segments.Count() != 2)
                throw new System.Exception($"Redis resource {qualifiedResource} does not have the correct format!");

            RedisResource redisResource = new RedisResource();
            redisResource.Path = segments.Last().Trim();

            RedisServer redisServer = RedisServer.Parse(segments.First());

            redisResource.Server = redisServer.Server;
            redisResource.Port = redisServer.Port;

            return redisResource;
        }
    }

    public class RedisServer
    {
        public string Server { get; set; }
        public int Port { get; set; } = 6379;

        public static RedisServer Parse(string server)
        {
            RedisServer redisServer = new RedisServer();

            if (server.Contains(":"))
            {
                var serverAndPort = server.Split(':');

                if (serverAndPort.Count() != 2)
                {
                    throw new System.Exception($"Redis server {server} does not have the correct format!");
                }

                redisServer.Server = serverAndPort.First();
                redisServer.Port = int.Parse(serverAndPort.Last().Trim());
            }
            else
            {
                redisServer.Server = server;
            }

            return redisServer;
        }
    }
}
