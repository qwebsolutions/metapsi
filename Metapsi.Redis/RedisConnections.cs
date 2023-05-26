using StackExchange.Redis;
using System.Collections.Generic;

namespace Metapsi
{

    public static class RedisConnections
    {
        private static object dictionaryAccessLock = new object();

        private static Dictionary<string, ConnectionMultiplexer> sharedConnections = new Dictionary<string, ConnectionMultiplexer>();

        /// <summary>
        /// This creates the actual connection & keeps it in a shared dictionary
        /// </summary>
        /// <param name="redisUrl"></param>
        /// <returns></returns>
        public static ConnectionMultiplexer GetConnection(string redisUrl)
        {
            lock (dictionaryAccessLock)
            {
                if (!sharedConnections.ContainsKey(redisUrl))
                {
                    sharedConnections.Add(redisUrl, ConnectionMultiplexer.Connect(redisUrl));
                }

                var result = sharedConnections[redisUrl];
                return result;
            }
        }

        /// <summary>
        /// This one fills the connection in a local, not shared, component state dictionary
        /// </summary>
        /// <param name="localConnections"></param>
        /// <param name="redisUrl"></param>
        /// <returns></returns>
        public static ConnectionMultiplexer GetConnection(Dictionary<string, ConnectionMultiplexer> localConnections, string redisUrl)
        {
            if(!localConnections.ContainsKey(redisUrl))
            {
                ConnectionMultiplexer connection = GetConnection(redisUrl);
                localConnections.Add(redisUrl , connection);
            }

            var result = localConnections[redisUrl];
            return result;
        }
    }
}
