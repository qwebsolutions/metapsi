namespace Metapsi
{
    public class RedisChannelMessage : IData
    {
        public string RedisUrl { get; set; }
        public string ChannelName { get; set; }
        public string Type { get; set; }
        public string Payload { get; set; }

        // For deserialization
        public RedisChannelMessage() { }

        public RedisChannelMessage(string redisUrl, string channelName, string messageType, string payload)
        {
            this.RedisUrl = redisUrl;
            this.ChannelName = channelName;
            this.Type = messageType;
            this.Payload = payload;
        }

        public RedisChannelMessage(string qualifiedChannelName, string messageType, string payload)
        {
            var redis = new RedisChannel(qualifiedChannelName);
            this.RedisUrl = redis.RedisUrl;
            this.ChannelName = redis.ChannelName;
            this.Type = messageType;
            this.Payload = payload;
        }
    }

    public class RedisMessage
    {
        public string Type { get; set; }
        public string Payload { get; set; }

        // For deserialization
        public RedisMessage() { }

        public RedisMessage(string messageType, string payload)
        {
            this.Type = messageType;
            this.Payload = payload;
        }
    }
}
