using System;
using System.Collections.Generic;
using System.Linq;

namespace Metapsi
{
    public static class Diff
    {
        public static DataStructureDiff Structures<TDataStructure>(TDataStructure previous, TDataStructure next)
            where TDataStructure: IDataStructure, new()
        {
            var diff = new DataStructureDiff();

            if (previous == null)
                previous = new TDataStructure();

            if (next == null)
                next = new TDataStructure();

            var prevCollections = previous.Collections();

            foreach (var c in prevCollections)
            {
                IRecordCollection prevValues = c.PropertyInfo.GetValue(previous) as IRecordCollection;
                IRecordCollection nextValues = c.PropertyInfo.GetValue(next) as IRecordCollection;

                diff = MergeDiffs(diff, UntypedCollections(prevValues, nextValues, c.PropertyInfo.Name));
            }
            return diff;
        }

        public static DataStructureDiff MergeDiffs(DataStructureDiff diff1, DataStructureDiff diff2)
        {
            DataStructureDiff mergedDiff = new DataStructureDiff();
            mergedDiff.AddedItems.AddRange(diff1.AddedItems);
            mergedDiff.AddedItems.AddRange(diff2.AddedItems);

            mergedDiff.ChangedItems.AddRange(diff1.ChangedItems);
            mergedDiff.ChangedItems.AddRange(diff2.ChangedItems);

            mergedDiff.RemovedItems.AddRange(diff1.RemovedItems);
            mergedDiff.RemovedItems.AddRange(diff2.RemovedItems);

            mergedDiff.ItemProperties.AddRange(diff1.ItemProperties);
            mergedDiff.ItemProperties.AddRange(diff2.ItemProperties);

            return mergedDiff;
        }

        private static Guid GetId(object o)
        {
            return (Guid)o.GetType().GetProperty("Id").GetValue(o);
        }

        public static DataStructureDiff TypedCollections<TItemType>(IEnumerable<TItemType> previousCollection, IEnumerable<TItemType> currentCollection, string collectionName)
        {
            DataStructureDiff dataStructureDiff = new DataStructureDiff();

            HashSet<Guid> previousItemIds = new HashSet<Guid>(previousCollection.Select(x => GetId(x)));
            HashSet<Guid> currentItemIds = new HashSet<Guid>(currentCollection.Select(x => GetId(x)));

            HashSet<Guid> removedItemIds = new HashSet<Guid>(previousItemIds.Except(currentItemIds));
            HashSet<Guid> addedItemIds = new HashSet<Guid>(currentItemIds.Except(previousItemIds));
            HashSet<Guid> commonItemIds = new HashSet<Guid>(previousItemIds.Intersect(currentItemIds));

            foreach (Guid removedId in removedItemIds)
            {
                dataStructureDiff.RemovedItems.Add(new RemovedDataItem()
                {
                    DataItemId = removedId,
                    DataItemType = typeof(TItemType).AssemblyQualifiedName,
                    FromDataStructureCollection = collectionName
                });
            }

            foreach (Guid addedId in addedItemIds)
            {
                dataStructureDiff.AddedItems.Add(new AddedDataItem()
                {
                    DataItemId = addedId,
                    DataItemType = typeof(TItemType).AssemblyQualifiedName,
                    InDataStructureCollection = collectionName
                });

                var addedItem = currentCollection.Single(x => GetId(x) == addedId);

                foreach (var property in typeof(TItemType).GetProperties())
                {
                    var scalarTypeAttribute = property.CustomAttributes.SingleOrDefault(x => x.AttributeType == typeof(ScalarTypeNameAttribute));

                    // If it does not have the attribute it is not a generated property
                    if (scalarTypeAttribute != null)
                    {
                        dataStructureDiff.ItemProperties.Add(new ChangedItemProperty()
                        {
                            ChangeId = dataStructureDiff.AddedItems.Last().Id,
                            PropertyName = property.Name,
                            PropertyValue = ToString(property.GetValue(addedItem)),
                            ScalarTypeName = scalarTypeAttribute.ConstructorArguments.Single().Value.ToString()
                        });
                    }
                }
            }

            foreach (Guid commonId in commonItemIds)
            {
                TItemType previousItem = previousCollection.Single(x => GetId(x) == commonId);
                TItemType currentItem = currentCollection.Single(x => GetId(x) == commonId);
                foreach (var property in typeof(TItemType).GetProperties())
                {
                    var scalarTypeAttribute = property.CustomAttributes.SingleOrDefault(x => x.AttributeType == typeof(ScalarTypeNameAttribute));
                    if (scalarTypeAttribute == null)
                        continue;

                    bool isDifferent = false;
                    string previousValueAsString = ToString(property.GetValue(previousItem));
                    string currentValueAsString = ToString(property.GetValue(currentItem));
                    if (previousValueAsString != currentValueAsString)
                    {
                        if (!isDifferent)
                        {
                            isDifferent = true;
                            dataStructureDiff.ChangedItems.Add(new ChangedDataItem()
                            {
                                DataItemId = commonId,
                                DataItemType = typeof(TItemType).AssemblyQualifiedName,
                                InDataStructureCollection = collectionName
                            });
                        }

                        dataStructureDiff.ItemProperties.Add(new ChangedItemProperty()
                        {
                            ChangeId = dataStructureDiff.ChangedItems.Last().Id,
                            PropertyName = property.Name,
                            PropertyValue = currentValueAsString,
                            ScalarTypeName = scalarTypeAttribute.ConstructorArguments.Single().Value.ToString()
                        });
                    }
                }
            }

            return dataStructureDiff;
        }

        public static DataStructureDiff UntypedCollections(IRecordCollection previousCollection, IRecordCollection currentCollection, string collectionName)
        {
            if (previousCollection.ItemType != currentCollection.ItemType)
                throw new Exception("Cannot diff collections of different item types");

            Type recordType = previousCollection.ItemType;

            DataStructureDiff dataStructureDiff = new DataStructureDiff();

            HashSet<Guid> previousItemIds = new HashSet<Guid>(previousCollection.Records.Select(x => x.Id));
            HashSet<Guid> currentItemIds = new HashSet<Guid>(currentCollection.Records.Select(x => x.Id));

            HashSet<Guid> removedItemIds = new HashSet<Guid>(previousItemIds.Except(currentItemIds));
            HashSet<Guid> addedItemIds = new HashSet<Guid>(currentItemIds.Except(previousItemIds));
            HashSet<Guid> commonItemIds = new HashSet<Guid>(previousItemIds.Intersect(currentItemIds));

            foreach (Guid removedId in removedItemIds)
            {
                dataStructureDiff.RemovedItems.Add(new RemovedDataItem()
                {
                    DataItemId = removedId,
                    DataItemType = recordType.AssemblyQualifiedName,
                    FromDataStructureCollection = collectionName
                });
            }

            foreach (Guid addedId in addedItemIds)
            {
                dataStructureDiff.AddedItems.Add(new AddedDataItem()
                {
                    DataItemId = addedId,
                    DataItemType = recordType.AssemblyQualifiedName,
                    InDataStructureCollection = collectionName
                });

                var addedItem = currentCollection.ById(addedId);

                foreach (var property in recordType.GetProperties())
                {
                    var scalarTypeAttribute = property.CustomAttributes.SingleOrDefault(x => x.AttributeType == typeof(ScalarTypeNameAttribute));

                    // If it does not have the attribute it is not a generated property
                    if (scalarTypeAttribute != null)
                    {
                        dataStructureDiff.ItemProperties.Add(new ChangedItemProperty()
                        {
                            ChangeId = dataStructureDiff.AddedItems.Last().Id,
                            PropertyName = property.Name,
                            PropertyValue = ToString(property.GetValue(addedItem)),
                            ScalarTypeName = scalarTypeAttribute.ConstructorArguments.Single().Value.ToString()
                        });
                    }
                }
            }

            foreach (Guid commonId in commonItemIds)
            {
                IRecord previousItem = previousCollection.ById(commonId);
                IRecord currentItem = currentCollection.ById(commonId);

                foreach (var property in recordType.GetProperties())
                {
                    var scalarTypeAttribute = property.CustomAttributes.SingleOrDefault(x => x.AttributeType == typeof(ScalarTypeNameAttribute));
                    if (scalarTypeAttribute == null)
                        continue;

                    bool isDifferent = false;
                    string previousValueAsString = ToString(property.GetValue(previousItem));
                    string currentValueAsString = ToString(property.GetValue(currentItem));
                    if (previousValueAsString != currentValueAsString)
                    {
                        if (!isDifferent)
                        {
                            isDifferent = true;
                            dataStructureDiff.ChangedItems.Add(new ChangedDataItem()
                            {
                                DataItemId = commonId,
                                DataItemType = recordType.AssemblyQualifiedName,
                                InDataStructureCollection = collectionName
                            });
                        }

                        dataStructureDiff.ItemProperties.Add(new ChangedItemProperty()
                        {
                            ChangeId = dataStructureDiff.ChangedItems.Last().Id,
                            PropertyName = property.Name,
                            PropertyValue = currentValueAsString,
                            ScalarTypeName = scalarTypeAttribute.ConstructorArguments.Single().Value.ToString()
                        });
                    }
                }
            }

            return dataStructureDiff;
        }

        private static string ToString(object o)
        {
            if (o == null)
                return "null";

            if (o is DateTime)
            {
                DateTime timestamp = (DateTime)o;
                return timestamp.ToString("O");
            }

            return o.ToString();
        }

    }
}