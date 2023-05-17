using System;

namespace Metapsi
{
    public interface IRecord
    {
        Guid Id { get; }
    }

    public static class Record
    {
        public static TRecord Default<TRecord>()
            where TRecord : IRecord, new()
        {
            TRecord empty = new TRecord();
            ((dynamic)empty).Id = Guid.Empty;
            return empty;
        }

        public static bool IsEmpty(this IRecord record)
        {
            if (record == null)
                return true;

            return record.Id == Guid.Empty;
        }

        public static bool IsValid(this IRecord record)
        {
            return !IsEmpty(record);
        }

        public static bool Same(IRecord first, IRecord second)
        {
            return Serialize.ToJson(first) == Serialize.ToJson(second);
        }

        public static bool Different(IRecord first, IRecord second)
        {
            return !Same(first, second);
        }
    }
}
