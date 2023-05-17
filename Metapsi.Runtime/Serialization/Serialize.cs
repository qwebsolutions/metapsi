using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.Json;

namespace Metapsi
{
    public static class Serialize
    {
        private static JsonSerializerOptions toJsonOptions = null;
        private static readonly object toJsonOptionsLocker = new object();
        private static JsonSerializerOptions ToJsonOptions
        {
            get
            {
                if (toJsonOptions == null)
                {
                    lock (toJsonOptionsLocker)
                    {
                        if (toJsonOptions == null)
                        {
                            toJsonOptions = new JsonSerializerOptions()
                            {
                                WriteIndented = true,
                                IgnoreReadOnlyFields = true,
                                IgnoreReadOnlyProperties = true
                            };
                            toJsonOptions.Converters.Add(new DynamicObjectConverter());
                        }
                    }
                }

                return toJsonOptions;
            }
        }

        private static JsonSerializerOptions fromJsonOptions = null;
        private static readonly object fromJsonOptionsLocker = new object();
        private static JsonSerializerOptions FromJsonOptions
        {
            get
            {
                if (fromJsonOptions == null)
                {
                    lock (fromJsonOptionsLocker)
                    {
                        if (fromJsonOptions == null)
                        {
                            fromJsonOptions = new JsonSerializerOptions();
                            fromJsonOptions.Converters.Add(new RecordCollectionConverterFactory());
                            fromJsonOptions.Converters.Add(new DynamicObjectConverter());
                        }
                    }
                }
                return fromJsonOptions;
            }
        }

        private static JsonSerializerOptions toTypedJsonOptions = null;
        private static readonly object toTypedJsonOptionsLocker = new object();
        private static JsonSerializerOptions ToTypedJsonOptions
        {
            get
            {
                if (toTypedJsonOptions == null)
                {
                    lock (toTypedJsonOptionsLocker)
                    {
                        if (toTypedJsonOptions == null)
                        {
                            toTypedJsonOptions = new System.Text.Json.JsonSerializerOptions();
                            toTypedJsonOptions.IncludeFields = true;
                            toTypedJsonOptions.Converters.Add(new DynamicObjectConverter());
                            toTypedJsonOptions.IgnoreReadOnlyFields = true;
                            toTypedJsonOptions.IgnoreReadOnlyProperties = true;
                        }
                    }
                }

                return toTypedJsonOptions;
            }
        }

        private static JsonSerializerOptions fromTypedJsonOptions = null;
        private static readonly object fromTypedJsonOptionsLocker = new object();
        private static JsonSerializerOptions FromTypedJsonOptions
        {
            get
            {
                if (fromTypedJsonOptions == null)
                {
                    lock (fromTypedJsonOptionsLocker)
                    {
                        if (fromTypedJsonOptions == null)
                        {
                            fromTypedJsonOptions = new System.Text.Json.JsonSerializerOptions();
                            fromTypedJsonOptions.Converters.Add(new RecordCollectionConverterFactory());
                            fromTypedJsonOptions.Converters.Add(new DynamicObjectConverter());
                            fromTypedJsonOptions.IncludeFields = true;
                        }
                    }
                }
                return fromTypedJsonOptions;
            }
        }

        public static string ToJson(object o)
        {
            string jsonContent = JsonSerializer.Serialize(o, ToJsonOptions);

            return jsonContent;
        }

        public static T FromTypedJson<T>(string json)
        {
            return (T)FromTypedJson(json);
        }

        public static T FromJson<T>(string json)
        {
            T deserialized = JsonSerializer.Deserialize<T>(json, FromJsonOptions);
            return deserialized;
        }

        public static object FromJson(Type t, string json)
        {
            object deserialized = JsonSerializer.Deserialize(json, t, FromJsonOptions);
            return deserialized;
        }

        public static string ToTypedJson(object o)
        {
            ObjectTypeWrapper untypedTypeWrapper = new ObjectTypeWrapper();
            untypedTypeWrapper.Set(o);

            return System.Text.Json.JsonSerializer.Serialize(untypedTypeWrapper, options: ToTypedJsonOptions);
        }

        public static object FromTypedJson(string serializedJson)
        {
            var typeProperty = System.Text.Json.JsonSerializer.Deserialize<ObjectTypeWrapper>(serializedJson, FromTypedJsonOptions);
            Type contentObjectType = Type.GetType(typeProperty.TypeName);

            if (contentObjectType == null)
            {
                var allTypes = AppDomain.CurrentDomain.GetAssemblies().SelectMany(a => a.GetTypes());
                contentObjectType = allTypes.FirstOrDefault(x => x.FullName == typeProperty.TypeName);
            }

            var genericWrapperType = typeof(GenericTypedWrapper<>).MakeGenericType(contentObjectType);

            object wrapperObject = System.Text.Json.JsonSerializer.Deserialize(serializedJson, genericWrapperType, FromTypedJsonOptions);
            ITypeWrapper objectAccessor = wrapperObject as ITypeWrapper;
            return objectAccessor.Get();
        }

        public static byte[] ToByteArray(string stringValue)
        {
            return System.Text.Encoding.UTF8.GetBytes(stringValue);
        }

        public static string FromByteArray(byte[] bytes)
        {
            return System.Text.Encoding.UTF8.GetString(bytes);
        }
    }
    public static class Locate
    {
        public static object DataItemInCollection(object dataModel, string collectionName, System.Guid itemId)
        {
            dynamic collection = dataModel.GetType().GetProperty(collectionName).GetValue(dataModel);
            foreach (dynamic item in collection)
            {
                if (item.Id == itemId)
                {
                    return item;
                }
            }

            throw new System.Exception($"Cannot locate item with id {itemId} in {collectionName}");
        }
    }

    public static class MetapsiDateTime
    {
        public static string Roundtrip(this DateTime dateTime)
        {
            return dateTime.ToString("O", System.Globalization.CultureInfo.InvariantCulture);
        }

        public static string JsRoundtrip(this DateTime dateTime)
        {
            return dateTime.ToString("s");
        }

        public static DateTime FromRoundTrip(string roundtripDate)
        {
            return DateTime.Parse(roundtripDate, null, System.Globalization.DateTimeStyles.RoundtripKind);
        }

        public static string ItalianFormat(this DateTime dateTime)
        {
            return dateTime.ToString("G", new System.Globalization.CultureInfo("it-IT"));
        }
    }
}