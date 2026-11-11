using System;
using System.Collections.Generic;

namespace Metapsi
{
    public interface IJsonSerializer
    {
        /// <summary>
        /// Writes case-sensitive, drops nulls
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        string ToLiteral(object obj);

        /// <summary>
        /// Writes case-sensitive, keeps nulls
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        string ToJson(object obj);

        /// <summary>
        /// Reads matching the server-side casing
        /// </summary>
        /// <param name="type"></param>
        /// <param name="json"></param>
        /// <returns></returns>
        object FromJson(Type type, string json);
    }

    public static class JsonSerializerExtensions
    {
        public static T FromJson<T>(this IJsonSerializer serializer, string json)
        {
            var value = serializer.FromJson(typeof(T), json);
            return value == null ? default : (T)value;
        }
    }
}