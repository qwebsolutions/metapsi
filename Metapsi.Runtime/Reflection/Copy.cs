using System.Linq;

namespace Metapsi
{
    public static class Copy
    {
        public static RecordCollection<TRecord> Clone<TRecord>(
            this RecordCollection<TRecord> collection)
            where TRecord : IRecord, new()
        {
            RecordCollection<TRecord> clonedCollection = new RecordCollection<TRecord>();
            clonedCollection.AddRange(collection.Select(x => x.Clone()));
            return clonedCollection;
        }

        public static TRecord Clone<TRecord>(this TRecord record) where TRecord : IRecord
        {
            if (record == null)
                return default(TRecord);

            return Serialize.FromJson<TRecord>(Serialize.ToJson(record));
        }

        public static TOutput To<TOutput>(object source)
        {
            return Serialize.FromJson<TOutput>(Serialize.ToJson(source));
        }
    }

    //public static class CopyStructure
    //{
    //    public static TDataStructure Clone<TDataStructure>(this TDataStructure dataStructure)
    //        where TDataStructure : IDataStructure
    //    {
    //        return Copy.To<TDataStructure>(dataStructure);
    //    }
    //}
}