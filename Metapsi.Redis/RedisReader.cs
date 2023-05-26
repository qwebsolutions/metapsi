using StackExchange.Redis;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Metapsi
{
    public static partial class RedisReader
    {
        public static class Command
        {
            public static Command<RedisChannelMessage> ProcessMessage { get; set; } = new Command<RedisChannelMessage>(nameof(ProcessMessage));
        }

        public class State
        {
            internal Dictionary<string, ConnectionMultiplexer> connections = new Dictionary<string, ConnectionMultiplexer>();
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

            while (true)
            {
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
                        ByCommand = nameof(ProcessAvailableMessages)
                    });

                    await commandContext.Do(Command.ProcessMessage,
                        new RedisChannelMessage(
                            redisChannel.RedisUrl,
                            redisChannel.ChannelName,
                            redisMessage.Type,
                            redisMessage.Payload));
                }
                else break;
            }
        }

        public static async Task<List<string>> GetAvailableMessages(CommandContext commandContext, State state, RedisChannel redisChannel)
        {
            List<string> availableMessages = new List<string>();

            var connection = RedisConnections.GetConnection(state.connections, redisChannel.RedisUrl);

            while (true)
            {
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
                        ByCommand = nameof(GetAvailableMessages)
                    });

                    availableMessages.Add(v);
                }
                else break;
            }

            return availableMessages;
        }
    }
}
