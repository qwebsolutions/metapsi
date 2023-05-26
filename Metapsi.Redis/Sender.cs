namespace Metapsi
{
    public static class Sender
    {
        public const string MessageAvailable = Receiver.MessageAvailable;


        public class References
        {
            public RedisNotifier.State RedisNotifier { get; set; }
            public RedisWriter.State RedisWriter { get; set; }
        }

        public static References AddRedisSender(
            this ApplicationSetup applicationSetup,
            ImplementationGroup implementationGroup,
            RedisNotifier.State redisNotifier,
            RedisWriter.State redisWriter)
        {
            References references = new References()
            {
                RedisNotifier = redisNotifier,
                RedisWriter = redisWriter
            };

            //applicationSetup.MapEvent<RedisWriter.Event.MessagePosted>(
            //    e =>
            //    {
            //        e.Using(redisNotifier, implementationGroup).EnqueueCommand(RedisNotifier.NotifyChannel,
            //            new RedisChannelMessage(e.EventData.RedisUrl, e.EventData.ChannelName, MessageAvailable, string.Empty));
            //    });

            applicationSetup.MapEvent<RedisWriter.Event.MessagePosted>(e => EnqueueNotification(e, redisNotifier, implementationGroup));
            return references;
        }

        public static void EnqueueNotification(EventContext<RedisWriter.Event.MessagePosted> e, RedisNotifier.State redisNotifier, ImplementationGroup implementationGroup)
        {
            e.Using(redisNotifier, implementationGroup).EnqueueCommand(RedisNotifier.NotifyChannel,
                       new RedisChannelMessage(e.EventData.RedisUrl, e.EventData.ChannelName, MessageAvailable, string.Empty));
        }

        public static References AddRedisSender(
            this ApplicationSetup applicationSetup,
            ImplementationGroup implementationGroup)
        {
            return applicationSetup.AddRedisSender(
                implementationGroup,
                applicationSetup.AddBusinessState(new RedisNotifier.State()),
                applicationSetup.AddBusinessState(new RedisWriter.State()));
        }
    }
}
