using StackExchange.Redis;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Metapsi
{
    public static class BulkReceiver
    {
        public const string MessageAvailable = Receiver.MessageAvailable;

        public class State
        {
            public bool IsShuttingDown { get; set; } = false;
            public Dictionary<string, ConnectionMultiplexer> connections = new Dictionary<string, ConnectionMultiplexer>();


        }

        internal static HashSet<string> CurrentlyReadingChannels { get; set; } = new HashSet<string>();

        public class MessagesAvailableNotification : IData
        {
            public string RedisUrl { get; set; }
            public string ChannelName { get; set; }
        }

        public class MessagesProcessed : IData
        {
            public string RedisUrl { get; set; }
            public string ChannelName { get; set; }
            public long MessagesCount { get; set; }
        }

        /// <summary>
        /// Self-contained, stripped-down receiver that reacts to MessageAvailable notifications and reads all messages at once. 
        /// Reads all available messages at once. Fast (tens of thousands of messages/s) but an error could lose a large amount of messages.
        /// Compatible with RedisSender.
        /// </summary>
        /// <param name="applicationSetup"></param>
        /// <param name="implementationGroup"></param>
        /// <param name="autoStartListeningOn"></param>
        /// <returns></returns>
        public static State AddBulkRedisReceiver(
            this ApplicationSetup applicationSetup,
            ImplementationGroup implementationGroup,
            RedisChannel autoStartListeningOn = null)
        {
            State fastReceiverState = applicationSetup.AddBusinessState(new State());

            applicationSetup.MapEvent<MessagesAvailableNotification>(
                e =>
                {
                    RedisChannel redisChannel = new RedisChannel(e.EventData.RedisUrl, e.EventData.ChannelName);
                    lock (CurrentlyReadingChannels)
                    {
                        // Avoid enqueueing a large amount of commands in case of a burst of notifications
                        // Saves memory
                        if (!CurrentlyReadingChannels.Contains(redisChannel.FullName()))
                        {
                            e.Using(fastReceiverState, implementationGroup).EnqueueCommand(ReadAll, redisChannel);
                        }
                    }
                });

            applicationSetup.MapEvent<ApplicationIsShuttingDown>(
                e =>
                {
                    e.Using(fastReceiverState, implementationGroup).EnqueueCommand(async (cc, state) => state.IsShuttingDown = true);
                });

            if (autoStartListeningOn != null)
            {
                applicationSetup.MapEvent<ApplicationRevived>(
                    e => e.Using(fastReceiverState, implementationGroup).EnqueueCommand(StartListening, autoStartListeningOn));
            }

            return fastReceiverState;
        }

        private static async Task ReadAll(CommandContext commandContext, State state, RedisChannel redisChannel)
        {
            var connection = RedisConnections.GetConnection(state.connections, redisChannel.RedisUrl);

            lock(CurrentlyReadingChannels)
            {
                CurrentlyReadingChannels.Add(redisChannel.FullName());
            }

            while (true)
            {
                long currentCount = await connection.GetDatabase().ListLengthAsync(redisChannel.ChannelName);

                if (currentCount <= 0)
                {
                    break;
                }

                if (currentCount > MaxBulkSize)
                    currentCount = MaxBulkSize;

                RedisValue[] list = await connection.GetDatabase().ListRangeAsync(redisChannel.ChannelName, 0, currentCount - 1);
                await connection.GetDatabase().ListTrimAsync(redisChannel.ChannelName, currentCount, -1);

                foreach (RedisValue value in list)
                {
                    RedisMessage redisMessage = Serialize.FromJson<RedisMessage>(value);
                    await commandContext.Do(RedisReader.Command.ProcessMessage,
                        new RedisChannelMessage(
                            redisChannel.RedisUrl,
                            redisChannel.ChannelName,
                            redisMessage.Type,
                            redisMessage.Payload));
                }

                commandContext.PostEvent(new MessagesProcessed()
                {
                    ChannelName = redisChannel.ChannelName,
                    RedisUrl = redisChannel.RedisUrl,
                    MessagesCount = list.LongLength
                });
            }

            lock(CurrentlyReadingChannels)
            {
                CurrentlyReadingChannels.Remove(redisChannel.FullName());
            }
            //System.Console.WriteLine($"Skipped notifications {skippedNotifications}");
        }

        private const long MaxBulkSize = 33000;

        private static int skippedNotifications = 0;

        internal static async Task StartListening(CommandContext commandContext, State state, RedisChannel redisChannel)
        {
            await RedisConnections.GetConnection(state.connections, redisChannel.RedisUrl).GetSubscriber().SubscribeAsync(redisChannel.ChannelName, async (channel, message) =>
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
                        RedisMessage notification = Serialize.FromJson<RedisMessage>(messageValue);

                        if (notification.Type == Receiver.MessageAvailable)
                        {
                            lock (CurrentlyReadingChannels)
                            {
                                if (!CurrentlyReadingChannels.Contains(redisChannel.FullName()))
                                    commandContext.PostEvent(new MessagesAvailableNotification
                                    {
                                        ChannelName = redisChannel.ChannelName,
                                        RedisUrl = redisChannel.RedisUrl
                                    });
                                else skippedNotifications++;
                            }
                        }
                    }
                }
            });
            await ReadAll(commandContext, state, redisChannel);
        }
    }
}
