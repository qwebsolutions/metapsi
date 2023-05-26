using System.Collections.Generic;

namespace Metapsi
{
    public static class FastReceiver
    {
        public const string MessageAvailable = Receiver.MessageAvailable;

        public class References
        {
            public FastRedisReader.State FastRedisReader { get; set; }
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
        public static References AddFastRedisReceiver(
            this ApplicationSetup applicationSetup,
            ImplementationGroup implementationGroup,
            RedisChannel autoStartListeningOn = null,
            long batchSize = 1)
        {
            FastRedisReader.State fastRedisReader = applicationSetup.AddBusinessState(new FastRedisReader.State(batchSize));
            RedisListener.State redisListener = applicationSetup.AddBusinessState(new RedisListener.State());

            applicationSetup.MapEventIf<RedisListener.Event.NotificationReceived>(
                e => e.NotificationType == MessageAvailable,
                e =>
                {
                    RedisChannel redisChannel = new RedisChannel(e.EventData.RedisUrl, e.EventData.ChannelName);
                    if (!fastRedisReader.currentlyReadingChannels.Contains(redisChannel.FullName()))
                    {
                        lock (fastRedisReader.currentlyReadingChannels)
                        {
                            if (!fastRedisReader.currentlyReadingChannels.Contains(redisChannel.FullName()))
                            {
                                fastRedisReader.currentlyReadingChannels.Add(redisChannel.FullName());
                                e.Using(fastRedisReader, implementationGroup).EnqueueCommand(FastRedisReader.ProcessAvailableMessages, redisChannel);
                            }
                        }
                    }
                });

            applicationSetup.MapEvent<RedisListener.Event.RedisListenerSuccessfulSubscribe>(
                e => e.Using(fastRedisReader, implementationGroup).EnqueueCommand(
                    FastRedisReader.ProcessAvailableMessages,
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
                FastRedisReader = fastRedisReader,
                RedisListener = redisListener
            };
        }
    }
}
