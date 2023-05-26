namespace Metapsi
{
    public static class Receiver
    {
        public const string MessageAvailable = "MessageAvailable";

        public class References
        {
            public RedisReader.State RedisReader { get; set; }
            public RedisListener.State RedisListener { get; set; }
        }

        /// <summary>
        /// Wires up a RedisReader & RedisListener that reads messages one by one. 
        /// It is slow (hundreds messages/s) but unprocessed messages remain in the redis queue, 
        /// so it is safer, an error wouldn't lose a large amount of messages.
        /// On MessageAvailable notification -> RedisReader.ProcessAvailableMessages. 
        /// On ApplicationIsShuttingDown -> RedisListener.StopListening.
        /// Does not start listening on application start by default because some services need to perform other operations first.
        /// Does start listening if also passed 'autoStartListningOn' parameter.
        /// Compatible with RedisSender.
        /// </summary>
        /// <param name="applicationSetup"></param>
        /// <param name="implementationGroup"></param>
        /// <param name="autoStartListeningOn"></param>
        /// <returns></returns>
        public static References AddRedisReceiver(
            this ApplicationSetup applicationSetup,
            ImplementationGroup implementationGroup,
            RedisChannel autoStartListeningOn = null)
        {
            RedisReader.State redisReader = applicationSetup.AddBusinessState(new RedisReader.State());
            RedisListener.State redisListener = applicationSetup.AddBusinessState(new RedisListener.State());

            applicationSetup.MapEventIf<RedisListener.Event.NotificationReceived>(
                e => e.NotificationType == MessageAvailable,
                e =>
                {
                    e.Using(redisReader, implementationGroup).EnqueueCommand(
                        RedisReader.ProcessAvailableMessages,
                        new RedisChannel(e.EventData.RedisUrl, e.EventData.ChannelName));
                });

            applicationSetup.MapEvent<RedisListener.Event.RedisListenerSuccessfulSubscribe>(
                e => e.Using(redisReader, implementationGroup).EnqueueCommand(
                    RedisReader.ProcessAvailableMessages,
                    new RedisChannel(e.EventData.RedisUrl, e.EventData.ChannelName)));

            applicationSetup.MapEvent<ApplicationIsShuttingDown>(
                e =>
                {
                    e.Using(redisListener, implementationGroup).EnqueueCommand(RedisListener.StopListening);
                });

            if (autoStartListeningOn != null)
            {
                applicationSetup.MapEvent<ApplicationRevived>(
                    e => e.Using(redisListener, implementationGroup).EnqueueCommand(RedisListener.StartListening, autoStartListeningOn));
            }

            return new References()
            {
                RedisReader = redisReader,
                RedisListener = redisListener
            };
        }
    }
}
