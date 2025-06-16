using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Metapsi
{
    //public static class Property
    //{
    //    public static TValue Get<TValue>(object o, string propertyName)
    //    {
    //        return (TValue)o.GetType().GetProperty(propertyName).GetValue(o);
    //    }

    //    public static void Set<TValue>(object o, string propertyName, TValue value)
    //    {
    //        o.GetType().GetProperty(propertyName).SetValue(o, value);
    //    }
    //}

    //public class SerializationConverterFactory : System.Text.Json.Serialization.JsonConverterFactory
    //{
    //    public override bool CanConvert(Type typeToConvert)
    //    {
    //        return typeToConvert.Name.Contains("RecordCollection");

    //    }

    //    public override JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options)
    //    {
    //        return options.GetConverter(typeof(IEnumerable));
    //    }
    //}

    //public static class CloneExtensions
    //{
    //    public static RecordCollection<TRecord> Clone<TRecord>(RecordCollection<TRecord> collection)
    //        where TRecord : IRecord, IClonable<TRecord>
    //    {
    //        RecordCollection<TRecord> clonedCollection = new RecordCollection<TRecord>();
    //        clonedCollection.AddRange(collection.Select(x => x.Clone());
    //        return clonedCollection;
    //    }
    //}

    //public static RecordCollection<TChild> ChildrenOf<TChild, TParent>(RecordCollection<TParent> parents)
    //{
    //    System.Func<InfrastructureService, System.Guid> plm = InfrastructureService.GetId;
    //    System.Func<InfrastructureServiceParameterDeclaration, System.Guid> plt = InfrastructureServiceParameterDeclaration.GetInfrastructureServiceId;

    //    //System.Func<InfrastructureService, InfrastructureServiceParameterValue> relation = (service)=> 
    //    //System.Func<System.Guid, System.Func<TDataSource, >

    //    // Filter by specific ID property

    //    System.Func<
    //        RecordCollection<TRecord>,
    //        System.Guid,
    //        RecordCollection<TRecord>> func = null;
    //}

    //public static class Load
    //{
    //    public static RecordCollection<TRecord> HavingProperty<TRecord, TScalar>(
    //        this IEnumerable<TRecord> sourceCollection,
    //        System.Func<TRecord, TScalar> getProperty,
    //        TScalar scalarValue)
    //        where TRecord : IRecord
    //    {
    //        IEnumerable<TRecord> filtered = sourceCollection.Where(x => getProperty(x).Equals(scalarValue));
    //        RecordCollection<TRecord> outputCollection = new RecordCollection<TRecord>().Merge(filtered);
    //        return outputCollection;
    //    }
    //}

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
