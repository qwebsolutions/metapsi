using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.Json;

namespace Metapsi
{

    public class DefaultSerializer : IJsonSerializer, IAutoLoader
    {
        public string Name { get; } = "default";

        private static JsonSerializerOptions toJsonOptions = null;
        private static JsonSerializerOptions ToJsonOptions
        {
            get
            {
                if (toJsonOptions == null)
                {
                    var newOptions = new JsonSerializerOptions()
                    {
                        WriteIndented = true,
                        IgnoreReadOnlyFields = true,
                        IgnoreReadOnlyProperties = true,
                        DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
                    };
                    //newOptions.Converters.Add(new DynamicObjectConverter());

                    // Only assign after options are fully built to avoid multi-threading errors
                    toJsonOptions = newOptions;
                }

                return toJsonOptions;
            }
        }

        private static JsonSerializerOptions fromJsonOptions = null;
        private static JsonSerializerOptions FromJsonOptions
        {
            get
            {
                if (fromJsonOptions == null)
                {
                    var newOptions = new JsonSerializerOptions();
                    newOptions.Converters.Add(new RecordCollectionConverterFactory());
                    //newOptions.Converters.Add(new DynamicObjectConverter());

                    // Only assign after options are fully built to avoid multi-threading errors
                    fromJsonOptions = newOptions;
                }
                return fromJsonOptions;
            }
        }

        private static JsonSerializerOptions toTypedJsonOptions = null;
        private static JsonSerializerOptions ToTypedJsonOptions
        {
            get
            {
                if (toTypedJsonOptions == null)
                {
                    var newOptions = new System.Text.Json.JsonSerializerOptions();
                    newOptions.IncludeFields = true;
                    //newOptions.Converters.Add(new DynamicObjectConverter());
                    newOptions.IgnoreReadOnlyFields = true;
                    newOptions.IgnoreReadOnlyProperties = true;

                    // Only assign after options are fully built to avoid multi-threading errors
                    toTypedJsonOptions = newOptions;
                }

                return toTypedJsonOptions;
            }
        }

        private static JsonSerializerOptions fromTypedJsonOptions = null;
        private static JsonSerializerOptions FromTypedJsonOptions
        {
            get
            {
                if (fromTypedJsonOptions == null)
                {
                    var newOptions = new System.Text.Json.JsonSerializerOptions();
                    newOptions.Converters.Add(new RecordCollectionConverterFactory());
                    //newOptions.Converters.Add(new DynamicObjectConverter());
                    newOptions.IncludeFields = true;

                    // Only assign after options are fully built to avoid multi-threading errors
                    fromTypedJsonOptions = newOptions;
                }
                return fromTypedJsonOptions;
            }
        }

        public string ToJson(object o)
        {
            string jsonContent = JsonSerializer.Serialize(o, ToJsonOptions);

            return jsonContent;
        }

        //public static T FromTypedJson<T>(string json)
        //{
        //    return (T)FromTypedJson(json);
        //}

        public T FromJson<T>(string json)
        {
            T deserialized = JsonSerializer.Deserialize<T>(json, FromJsonOptions);
            return deserialized;
        }

        public object FromJson(Type t, string json)
        {
            object deserialized = JsonSerializer.Deserialize(json, t, FromJsonOptions);
            return deserialized;
        }

        //public static string ToTypedJson(object o)
        //{
        //    ObjectTypeWrapper untypedTypeWrapper = new ObjectTypeWrapper();
        //    untypedTypeWrapper.Set(o);

        //    return System.Text.Json.JsonSerializer.Serialize(untypedTypeWrapper, options: ToTypedJsonOptions);
        //}

        //public static object FromTypedJson(string serializedJson)
        //{
        //    var typeProperty = System.Text.Json.JsonSerializer.Deserialize<ObjectTypeWrapper>(serializedJson, FromTypedJsonOptions);
        //    Type contentObjectType = Type.GetType(typeProperty.TypeName);

        //    if (contentObjectType == null)
        //    {
        //        var allTypes = AppDomain.CurrentDomain.GetAssemblies().SelectMany(a => a.GetTypes());
        //        contentObjectType = allTypes.FirstOrDefault(x => x.FullName == typeProperty.TypeName);
        //    }

        //    var genericWrapperType = typeof(GenericTypedWrapper<>).MakeGenericType(contentObjectType);

        //    object wrapperObject = System.Text.Json.JsonSerializer.Deserialize(serializedJson, genericWrapperType, FromTypedJsonOptions);
        //    ITypeWrapper objectAccessor = wrapperObject as ITypeWrapper;
        //    return objectAccessor.Get();
        //}
    }
}