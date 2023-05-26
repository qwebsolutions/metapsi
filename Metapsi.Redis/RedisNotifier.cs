using StackExchange.Redis;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Metapsi
{
    public static partial class RedisNotifier
    {
        public class State
        {
            internal Dictionary<string, ConnectionMultiplexer> connections = new Dictionary<string, ConnectionMultiplexer>();
        }

        public static partial class Event
        {
            public partial class ChannelNotified : IData
            {
                public string ChannelName { get; set; }
                public int ReceiversCount { get; set; }
            }
        }

        public static async Task NotifyChannel(CommandContext context, State state, RedisChannelMessage message)
        {
            long receivers = await RaiseNotification(state, message);
            context.PostEvent(new Event.ChannelNotified()
            {
                ChannelName = message.ChannelName,
                ReceiversCount = (int)receivers
            });
        }

        public static async Task<long> RaiseNotification(State state, RedisChannelMessage message)
        {
            ConnectionMultiplexer connection = RedisConnections.GetConnection(state.connections, message.RedisUrl);

            RedisMessage notification = new RedisMessage(message.Type, message.Payload);
            string serialized = Serialize.ToJson(notification);

            long receivers = await connection.GetSubscriber().PublishAsync(message.ChannelName, serialized, CommandFlags.FireAndForget);
            return receivers;
        }
    }
}
