using System;
using System.Collections.Generic;
using System.Linq;

namespace Metapsi
{
    public interface IDataStructure
    {

    }

    public class DataStructureRelation
    {
        public string ParentCollectionName { get; set; }
        public string ChildCollectionName { get; set; }
        public string ParentIdField { get; set; }
        public string ChildIdField { get; set; }
    }

    public static class DataStructure
    {
        public static bool Same<T>(T first, T second) where T : IDataStructure, new()
        {
            return !Different(first, second);
        }

        public static bool Different<T>(T first, T second) where T : IDataStructure, new()
        {
            return Diff.Structures(first, second).HasChanges;
        }

        public static TSubset Extract<TSubset>(this IDataStructure fromStructure, Guid topId)
            where TSubset : IDataStructure, new()
        {
            return fromStructure.Extract<TSubset>(new List<Guid>() { topId });
        }

        public static IRecordCollection GetRecords(this IDataStructure dataStructure, string collectionName)
        {
            return dataStructure.GetType().GetProperty(collectionName).GetValue(dataStructure) as IRecordCollection;
        }

        public static void SetRecords(this IDataStructure intoDataStructure, string collectionName, IRecordCollection recordCollection)
        {
            intoDataStructure.GetType().GetProperty(collectionName).SetValue(intoDataStructure, recordCollection);
        }

        public static void SetRecords(this IDataStructure intoDataStructure, string collectionName, IEnumerable<IRecord> recordCollection)
        {
            var collectionProperty = intoDataStructure.GetType().GetProperty(collectionName);
            var recordType = collectionProperty.PropertyType.GenericTypeArguments.First();
            IRecordCollection typedCollection = Collection.New(recordType);

            foreach (IRecord record in recordCollection)
            {
                typedCollection.Add(record);
            }

            collectionProperty.SetValue(intoDataStructure, typedCollection);
        }

        public static HashSet<Guid> TopIds(this IDataStructure dataStructure)
        {
            var collections = dataStructure.Collections().First();
            return new HashSet<Guid>(dataStructure.GetRecords(collections.PropertyInfo.Name).Ids());
        }

        public static TSubset Extract<TSubset>(this IDataStructure fromStructure, IEnumerable<Guid> topIds)
            where TSubset: IDataStructure, new()
        {
            TSubset subset = new TSubset();
            var subsetCollections = subset.Collections();

            if (subsetCollections.Any())
            {
                var topRecords = fromStructure.GetRecords(subsetCollections.First().PropertyInfo.Name).Filter(topIds);
                subset.SetRecords(subsetCollections.First().PropertyInfo.Name, topRecords);
            }

            foreach (DataStructureRelation dataStructureRelation in Relation.DefaultRelations(typeof(TSubset)))
            {
                IRecordCollection subsetParentCollection = subset.GetRecords(dataStructureRelation.ParentCollectionName);
                HashSet<Guid> parentIds = new HashSet<Guid>(subsetParentCollection.Records.Select(x => x.Get<Guid>(dataStructureRelation.ParentIdField)));
                IRecordCollection sourceChildCollection = fromStructure.GetRecords(dataStructureRelation.ChildCollectionName);
                IRecordCollection filtered = Collection.New(sourceChildCollection.ItemType);
                foreach(IRecord record in sourceChildCollection.Records)
                {
                    if(parentIds.Contains(record.Get<Guid>(dataStructureRelation.ChildIdField)))
                    {
                        filtered.Add(record);
                    }
                }
                subset.SetRecords(dataStructureRelation.ChildCollectionName, filtered);
            }

            return subset;
        }

        public static void Remove<TSubset>(this IDataStructure fromStructure, Guid topId)
            where TSubset : IDataStructure, new()
        {
            fromStructure.Remove<TSubset>(new List<Guid>() { topId });
        }

        public static void Remove<TSubset>(this IDataStructure fromStructure, IEnumerable<Guid> topIds)
            where TSubset : IDataStructure, new()
        {
            TSubset subset = fromStructure.Extract<TSubset>(topIds);
            var subsetCollections = subset.Collections();
            foreach (CollectionInfo subsetCollection in subsetCollections)
            {
                IRecordCollection supersetCollection = fromStructure.GetRecords(subsetCollection.PropertyInfo.Name);

                foreach (IRecord subsetRecord in subset.GetRecords(subsetCollection.PropertyInfo.Name).Records)
                {
                    supersetCollection.Remove(subsetRecord.Id);
                }
            }
        }

        public static void Merge<TSubset>(this IDataStructure intoStructure, TSubset subset)
            where TSubset : IDataStructure, new()
        {
            intoStructure.Remove<TSubset>(subset.TopIds());

            var subsetCollections = subset.Collections();

            foreach (CollectionInfo subsetCollection in subsetCollections)
            {
                var supersetRecords = intoStructure.GetRecords(subsetCollection.Name);
                foreach (IRecord record in subset.GetRecords(subsetCollection.Name).Records)
                {
                    supersetRecords.Add(record.Clone());
                }
            }
        }
    }
}
