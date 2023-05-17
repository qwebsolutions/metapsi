using System;
using System.Collections.Generic;
using System.Linq;

namespace Metapsi
{
    public static class Collection
    {
        public static RecordCollection<TRecord> ToRecordCollection<TRecord>(this IEnumerable<TRecord> records)
            where TRecord : IRecord, new()
        {
            return new RecordCollection<TRecord>(records);
        }

        public static IRecordCollection New(Type recordType)
        {
            var collectionType = typeof(RecordCollection<>).MakeGenericType(recordType);
            IRecordCollection collection = (IRecordCollection)Activator.CreateInstance(collectionType);
            return collection;
        }

        public static IEnumerable<CollectionInfo> Collections(Type dataStructureType)
        {
            var collectionProperties = dataStructureType.GetProperties().Where(x => x.CanWrite && typeof(IRecordCollection).IsAssignableFrom(x.PropertyType));
            var collections = collectionProperties.Select(x => new CollectionInfo()
            {
                PropertyInfo = x,
                Order = OrderAttributeValue(x),
                Relation = RelationAttribute(x),
                RecordType = x.PropertyType.GenericTypeArguments.First()
            });

            var ordered = collections.OrderBy(x => x.Order);
            return ordered.ToList();
        }

        public static IEnumerable<CollectionInfo> Collections<T>() where T : IDataStructure
        {
            return Collections(typeof(T));
        }

        public static IEnumerable<CollectionInfo> Collections(this IDataStructure ds)
        {
            return Collections(ds.GetType());
        }

        private static int OrderAttributeValue(System.Reflection.PropertyInfo propertyInfo)
        {
            var orderAttribute = propertyInfo.CustomAttributes.SingleOrDefault(x => x.AttributeType == typeof(OrderAttribute));
            if (orderAttribute == null)
                return int.MaxValue;

            return (int)orderAttribute.ConstructorArguments[0].Value;
        }

        private static DataStructureRelation RelationAttribute(System.Reflection.PropertyInfo propertyInfo)
        {
            var relationAttributes = propertyInfo.DeclaringType.CustomAttributes.Where(x => x.AttributeType == typeof(RelationAttribute));

            var relationAttribute = relationAttributes.SingleOrDefault(x => ((string)x.ConstructorArguments[2].Value) == propertyInfo.Name);

            if (relationAttribute == null)
                return null;

            return new DataStructureRelation()
            {
                ParentCollectionName = (string)relationAttribute.ConstructorArguments[0].Value,
                ParentIdField = (string)relationAttribute.ConstructorArguments[1].Value,
                ChildCollectionName = (string)relationAttribute.ConstructorArguments[2].Value,
                ChildIdField = (string)relationAttribute.ConstructorArguments[3].Value
            };
        }
    }
}