using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Metapsi
{
    public static partial class FastRedisReader
    {
        public static class Command
        {
            public static Command<RedisChannelMessage> ProcessMessage { get; set; } = new Command<RedisChannelMessage>(nameof(ProcessMessage));
        }

        public class State
        {
            public State(long batchSize = 1)
            {
                if (batchSize < 0)
                {
                    BatchSize = 1;
                }
                else
                {
                    BatchSize = batchSize;
                }
            }


            internal Dictionary<string, ConnectionMultiplexer> connections = new Dictionary<string, ConnectionMultiplexer>();
            internal HashSet<string> currentlyReadingChannels = new HashSet<string>();
            public long BatchSize { get; }
        }

        public static class Event
        {
            public class MessageRetrieved : IData
            {
                public string ChannelName { get; set; }
                public string RedisUrl { get; set; }
                public string MessageType { get; set; }
                public string Payload { get; set; }
                public string ByCommand { get; set; }
            }
        }

        public static async Task ProcessNextMessage(CommandContext commandContext, State state, RedisChannel redisChannel)
        {
            var connection = RedisConnections.GetConnection(state.connections, redisChannel.RedisUrl);
            RedisValue v = await connection.GetDatabase().ListLeftPopAsync(redisChannel.ChannelName);

            if (v != RedisValue.Null && v != RedisValue.EmptyString)
            {
                RedisMessage redisMessage = Serialize.FromJson<RedisMessage>(v);

                commandContext.PostEvent(new Event.MessageRetrieved()
                {
                    ChannelName = redisChannel.ChannelName,
                    RedisUrl = redisChannel.RedisUrl,
                    MessageType = redisMessage.Type,
                    Payload = redisMessage.Payload,
                    ByCommand = nameof(ProcessNextMessage)
                });

                await commandContext.Do(Command.ProcessMessage,
                    new RedisChannelMessage(
                        redisChannel.RedisUrl,
                        redisChannel.ChannelName,
                        redisMessage.Type,
                        redisMessage.Payload));
            }
        }

        public static async Task ProcessAvailableMessages(CommandContext commandContext, State state, RedisChannel redisChannel)
        {
            var connection = RedisConnections.GetConnection(state.connections, redisChannel.RedisUrl);
            var batch = connection.GetDatabase().CreateBatch();
            //this might create issues
            //var transaction = connection.GetDatabase().CreateTransaction();

            while (true)
            {
                try
                {
                    var currentCount = await connection.GetDatabase().ListLengthAsync(redisChannel.ChannelName);
                    if (currentCount <= 0)
                    {
                        break;
                    }
                    var batchSize = state.BatchSize <= currentCount ? state.BatchSize : currentCount;

                    // // this is batching alternative. List range seems just a bit faster.
                    //var tasks = new List<Task<RedisValue>>();
                    //for (int i = 1; i <= batchSize; i++)
                    //{
                    //    tasks.Add(batch.ListLeftPopAsync(redisChannel.ChannelName));
                    //}
                    //var stopwatch = Stopwatch.StartNew();
                    //batch.Execute();
                    //var results = await Task.WhenAll(tasks);
                    //stopwatch.Stop();
                    //commandContext.Logger.LogDebug($"{nameof(FastRedisReader.ProcessAvailableMessages)} Redis data fetch took {stopwatch.ElapsedMilliseconds} ms");
                    //if (stopwatch.ElapsedMilliseconds > 1000)
                    //{
                    //    commandContext.Logger.LogInfo($"{nameof(FastRedisReader.ProcessAvailableMessages)} Redis data fetch took {stopwatch.ElapsedMilliseconds} ms");
                    //}

                    var stopwatch = Stopwatch.StartNew();
                    var fetchTask = batch.ListRangeAsync(redisChannel.ChannelName, 0, batchSize - 1);
                    var cleanTask = batch.ListTrimAsync(redisChannel.ChannelName, batchSize, -1);
                    batch.Execute();
                    var results = await fetchTask;
                    await cleanTask;
                    stopwatch.Stop();
                    commandContext.Logger.LogDebug($"{nameof(FastRedisReader.ProcessAvailableMessages)} Redis data fetch took {stopwatch.ElapsedMilliseconds} ms");
                    if (stopwatch.ElapsedMilliseconds > 1000)
                    {
                        commandContext.Logger.LogInfo($"{nameof(FastRedisReader.ProcessAvailableMessages)} Redis data fetch took {stopwatch.ElapsedMilliseconds} ms");
                    }

                    foreach (var result in results)
                    {
                        if (result != RedisValue.Null && result != RedisValue.EmptyString)
                        {
                            RedisMessage redisMessage = Serialize.FromJson<RedisMessage>(result);

                            commandContext.PostEvent(new Event.MessageRetrieved()
                            {
                                ChannelName = redisChannel.ChannelName,
                                RedisUrl = redisChannel.RedisUrl,
                                MessageType = redisMessage.Type,
                                Payload = redisMessage.Payload,
                                ByCommand = nameof(ProcessAvailableMessages)
                            });

                            await commandContext.Do(Command.ProcessMessage,
                                new RedisChannelMessage(
                                    redisChannel.RedisUrl,
                                    redisChannel.ChannelName,
                                    redisMessage.Type,
                                    redisMessage.Payload));
                        }
                    }
                }
                catch (Exception ex)
                {
                    commandContext.Logger.LogException(ex);
                    await Task.Delay(1000);
                }
            }

            state.currentlyReadingChannels.Remove(redisChannel.FullName());
        }

        public static async Task<List<string>> GetAvailableMessages(CommandContext commandContext, State state, RedisChannel redisChannel)
        {
            List<string> availableMessages = new List<string>();
            var connection = RedisConnections.GetConnection(state.connections, redisChannel.RedisUrl);
            var batch = connection.GetDatabase().CreateBatch();

            while (true)
            {
                var currentCount = await connection.GetDatabase().ListLengthAsync(redisChannel.ChannelName);
                if (currentCount <= 0)
                {
                    break;
                }
                var batchSize = state.BatchSize <= currentCount ? state.BatchSize : currentCount;

                var tasks = new List<Task<RedisValue>>();
                for (int i = 1; i <= batchSize; i++)
                {
                    tasks.Add(batch.ListLeftPopAsync(redisChannel.ChannelName));
                }
                var stopwatch = Stopwatch.StartNew();
                batch.Execute();
                var results = await Task.WhenAll(tasks);
                stopwatch.Stop();
                commandContext.Logger.LogDebug($"{nameof(FastRedisReader.ProcessAvailableMessages)} Redis data fetch took {stopwatch.ElapsedMilliseconds} ms");

                if (stopwatch.ElapsedMilliseconds > 1000)
                {
                    commandContext.Logger.LogInfo($"{nameof(FastRedisReader.ProcessAvailableMessages)} Redis data fetch took {stopwatch.ElapsedMilliseconds} ms");
                }

                foreach (var result in results)
                {
                    if (result != RedisValue.Null && result != RedisValue.EmptyString)
                    {
                        RedisMessage redisMessage = Serialize.FromJson<RedisMessage>(result);

                        commandContext.PostEvent(new Event.MessageRetrieved()
                        {
                            ChannelName = redisChannel.ChannelName,
                            RedisUrl = redisChannel.RedisUrl,
                            MessageType = redisMessage.Type,
                            Payload = redisMessage.Payload,
                            ByCommand = nameof(GetAvailableMessages)
                        });

                        availableMessages.Add(result);
                    }
                }
            }

            return availableMessages;
        }
    }
}
