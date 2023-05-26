using StackExchange.Redis;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Metapsi
{
    public static partial class RedisWriter
    {
        public class State
        {
            internal Dictionary<string, ConnectionMultiplexer> connections = new Dictionary<string, ConnectionMultiplexer>();
        }

        public static async Task ClearChannel(CommandContext commandContext, State state, RedisChannel clearChannelCommand)
        {
            ConnectionMultiplexer connection = RedisConnections.GetConnection(state.connections, clearChannelCommand.RedisUrl);

            bool keyWasRemoved = await connection.GetDatabase().KeyDeleteAsync(clearChannelCommand.ChannelName);

            commandContext.PostEvent(new Event.ChannelCleared()
            {
                ChannelName = clearChannelCommand.ChannelName,
                RedisUrl = clearChannelCommand.RedisUrl,
                AnythingRemoved = keyWasRemoved
            });
        }

        public static async Task WriteMessage(CommandContext commandContext, State state, RedisChannelMessage postMessage)
        {
            ConnectionMultiplexer connection = RedisConnections.GetConnection(state.connections, postMessage.RedisUrl);

            RedisMessage redisMessage = new RedisMessage(postMessage.Type, postMessage.Payload);
            string serialized = Serialize.ToJson(redisMessage);
            await connection.GetDatabase().ListRightPushAsync(postMessage.ChannelName, serialized, flags: CommandFlags.FireAndForget);

            commandContext.PostEvent(new Event.MessagePosted()
            {
                ChannelName = postMessage.ChannelName,
                MessageType = postMessage.Type,
                Payload = postMessage.Payload,
                RedisUrl = postMessage.RedisUrl
            });
        }

        public static async Task WriteMessage(CommandContext commandContext, State state, RedisChannelMessage postMessage, int raiseWarningIfCountLargerThan)
        {
            ConnectionMultiplexer connection = RedisConnections.GetConnection(state.connections, postMessage.RedisUrl);

            if (raiseWarningIfCountLargerThan > 0)
            {
                long listlenght = await connection.GetDatabase().ListLengthAsync(postMessage.RedisUrl);
                if (listlenght > raiseWarningIfCountLargerThan)
                {
                    commandContext.PostEvent(new Event.LargeListWarning()
                    {
                        ChannelName = postMessage.ChannelName,
                        RedisUrl = connection.Configuration,
                        PendingCount = (int)listlenght
                    });
                }
            }

            RedisMessage redisMessage = new RedisMessage(postMessage.Type, postMessage.Payload);
            string serialized = Serialize.ToJson(redisMessage);

            await connection.GetDatabase().ListRightPushAsync(postMessage.ChannelName, serialized, flags: CommandFlags.FireAndForget);

            commandContext.PostEvent(new Event.MessagePosted()
            {
                ChannelName = postMessage.ChannelName,
                RedisUrl = postMessage.RedisUrl,
                MessageType = postMessage.Type,
                Payload = postMessage.Payload
            });
        }

        public partial class Event
        {
            public partial class ChannelCleared : IData
            {
                public string RedisUrl { get; set; }
                public string ChannelName { get; set; }
                public bool AnythingRemoved { get; set; }
            }

            public partial class LargeListWarning : IData
            {
                public string RedisUrl { get; set; }
                public string ChannelName { get; set; }
                public int PendingCount { get; set; }
            }
            public partial class MessagePosted : IData
            {
                public string RedisUrl { get; set; }
                public string ChannelName { get; set; }
                public string MessageType { get; set; }
                public string Payload { get; set; }
            }
        }
    }
}
