using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Metapsi
{
    public class RecordCollection<TRecord> : IRecordCollection, IEnumerable<TRecord>
        where TRecord : IRecord, new()
    {
        public RecordCollection()
        {
            records = new Dictionary<Guid, TRecord>();
        }

        public RecordCollection(IEnumerable<TRecord> records) : this()
        {
            this.AddRange(records);
        }

        public Type ItemType => typeof(TRecord);

        private Dictionary<System.Guid, TRecord> records;

        public IEnumerable<IRecord> Records
        {
            get
            {
                return this as IEnumerable<IRecord>;
            }
        }

        public IEnumerator<TRecord> GetEnumerator()
        {
            return records.Values.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return records.Values.GetEnumerator();
        }

        public TRecord ById(System.Guid id)
        {
            return records[id];
        }

        public TRecord ByIdOrDefault(Guid id)
        {
            if (records.ContainsKey(id))
                return records[id];

            return Record.Default<TRecord>();
        }

        public bool Contains(System.Guid id)
        {
            return records.ContainsKey(id);
        }

        public RecordCollection<TRecord> Add(TRecord record)
        {
            if (records.ContainsKey(record.Id))
                throw new System.Exception("Record key already exists!");
            records[record.Id] = record;
            return this;
        }

        public RecordCollection<TRecord> Set(TRecord record)
        {
            if (Metapsi.Record.IsValid(record))
            {
                records[record.Id] = record;
            }
            return this;
        }

        public RecordCollection<TRecord> AddRange(IEnumerable<TRecord> collection)
        {
            foreach (var record in collection)
            {
                if (records.ContainsKey(record.Id))
                    throw new System.Exception("Found duplicate record key when merging collections!");
                records[record.Id] = record;
            }
            return this;
        }

        public RecordCollection<TRecord> Update(IEnumerable<TRecord> collection)
        {
            foreach (var record in collection)
            {
                records[record.Id] = record;
            }
            return this;
        }

        // I couldn't decide which name is better
        public RecordCollection<TRecord> Merge(IEnumerable<TRecord> collection)
        {
            return Update(collection);
        }

        public RecordCollection<TRecord> Overwrite(IEnumerable<TRecord> collection)
        {
            this.RemoveAll();
            this.AddRange(collection);
            return this;
        }

        public RecordCollection<TRecord> RemoveAll(Predicate<TRecord> predicate = null)
        {
            if (predicate == null)
            {
                predicate = x => true;
            }

            List<System.Guid> idsToRemove = new List<Guid>();
            foreach (TRecord record in this)
            {
                if (predicate(record))
                    idsToRemove.Add(record.Id);
            }

            foreach (var id in idsToRemove)
            {
                records.Remove(id);
            }
            return this;
        }

        public RecordCollection<TRecord> Remove(Guid byId)
        {
            this.RemoveAll(x => x.Id == byId);
            return this;
        }

        public RecordCollection<TRecord> Remove(TRecord record)
        {
            Remove(record.Id);
            return this;
        }

        public IRecordCollection Add(IRecord record)
        {
            this.Add((TRecord)record);
            return this;
        }

        public IRecordCollection Set(IRecord record)
        {
            this.Set((TRecord)record);
            return this;
        }

        IRecordCollection IRecordCollection.Remove(Guid byId)
        {
            return this.Remove(byId);
        }

        IRecord IRecordCollection.ById(Guid id)
        {
            return this.ById(id);
        }

        public List<Guid> Ids()
        {
            return new List<Guid>(Records.Select(x => x.Id));
        }

        public RecordCollection<TRecord> Filter(IEnumerable<Guid> byIds)
        {
            RecordCollection<TRecord> filtered = new RecordCollection<TRecord>();
            filtered.AddRange(this.Where(x => byIds.Contains(x.Id)).Select(x => x.Clone()));
            return filtered;
        }

        IRecordCollection IRecordCollection.Filter(IEnumerable<Guid> byIds)
        {
            return this.Filter(byIds);
        }
    }
}