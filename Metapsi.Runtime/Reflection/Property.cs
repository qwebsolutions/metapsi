using System.Collections.Generic;
using System.Linq;

namespace Metapsi
{
    public static class Filter
    {
        public static RecordCollection<TRecord> HavingProperty<TRecord, TScalar>(
            this IEnumerable<TRecord> sourceCollection,
            System.Func<TRecord, TScalar> getProperty,
            TScalar scalarValue)
            where TRecord : IRecord, new()
        {
            IEnumerable<TRecord> filtered = sourceCollection.Where(x => getProperty(x).Equals(scalarValue));
            RecordCollection<TRecord> outputCollection = new RecordCollection<TRecord>().AddRange(filtered);
            return outputCollection;
        }

        public static RecordCollection<TChildRecord> HavingParent<TChildRecord, TParentRecord, TScalar>(
            this IEnumerable<TChildRecord> sourceChildrenCollection,
            System.Func<TChildRecord, TScalar> getChildProperty,
            TParentRecord fixedParent,
            System.Func<TParentRecord, TScalar> getParentProperty)
            where TParentRecord: IRecord, new()
            where TChildRecord: IRecord, new()
        {
            RecordCollection<TChildRecord> outputCollection = new RecordCollection<TChildRecord>();
            TScalar scalarValue = getParentProperty(fixedParent);
            outputCollection.AddRange(HavingProperty(sourceChildrenCollection, getChildProperty, scalarValue));
            return outputCollection;
        }

        public static RecordCollection<TChildRecord> HavingParents<TChildRecord, TParentRecord, TScalar>(
            this IEnumerable<TChildRecord> sourceChildrenCollection,
            System.Func<TChildRecord, TScalar> getChildProperty,
            IEnumerable<TParentRecord> fixedParents,
            System.Func<TParentRecord, TScalar> getParentProperty)
            where TParentRecord : IRecord, new()
            where TChildRecord : IRecord, new()
        {
            RecordCollection<TChildRecord> outputCollection = new RecordCollection<TChildRecord>();
            foreach (TParentRecord fixedParentRecord in fixedParents)
            {
                RecordCollection<TChildRecord> childrenOfCurrentParent = sourceChildrenCollection.HavingParent(getChildProperty, fixedParentRecord, getParentProperty);
                outputCollection.AddRange(childrenOfCurrentParent);
            }

            return outputCollection;
        }

        public static T Get<T>(this IRecord record, string propertyName)
        {
            return (T)record.GetType().GetProperty(propertyName).GetValue(record);
        }

        public static void Set<T>(this IRecord record, string propertyName, T value)
        {
            record.GetType().GetProperty(propertyName).SetValue(record, value);
        }
    }
}
