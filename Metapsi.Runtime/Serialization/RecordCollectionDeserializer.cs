using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Metapsi
{
    public class RecordCollectionDeserializer<TRecord> : JsonConverter<RecordCollection<TRecord>>
        where TRecord : IRecord, new()
    {
        public override RecordCollection<TRecord> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            RecordCollection<TRecord> outputCollection = new RecordCollection<TRecord>();

            var colConverter = options.GetConverter(typeof(IEnumerable<TRecord>)) as JsonConverter<IEnumerable<TRecord>>;

            var enumerableCollection = colConverter.Read(ref reader, typeof(IEnumerable<TRecord>), options);

            foreach (var record in enumerableCollection)
            {
                outputCollection.Add(record);
            }

            return outputCollection;
        }

        public override void Write(Utf8JsonWriter writer, RecordCollection<TRecord> value, JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }
    }
}
