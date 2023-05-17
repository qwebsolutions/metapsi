using System;
using System.Collections.Generic;

namespace Metapsi
{
    public interface IRecordCollection
    {
        IRecord ById(Guid id);
        bool Contains(System.Guid id);
        IRecordCollection Add(IRecord record);
        IRecordCollection Set(IRecord record);
        IRecordCollection Remove(Guid byId);
        IRecordCollection Filter(IEnumerable<Guid> byIds);
        List<Guid> Ids();

        IEnumerable<IRecord> Records { get; }

        public Type ItemType { get; }
    }
}