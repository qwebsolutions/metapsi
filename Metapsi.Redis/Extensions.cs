using System;
using System.Collections.Generic;
using System.Text;

namespace Metapsi
{
    internal static class Extentions
    {
        internal static string FullName(this RedisChannel redisChannel)
        {
            return $"{redisChannel.RedisUrl}|{redisChannel.ChannelName}";
        }
    }
}