using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;

namespace Metapsi
{
    public static class Scalar
    {
        /// <summary>
        /// Types that return the same value when converted to string and back
        /// </summary>
        public static List<Type> Types = new List<Type>()
        {
            typeof(string),
            typeof(int),
            typeof(long),
            typeof(decimal),
            typeof(bool),
            typeof(Guid),
            typeof(DateTime)
        };

        public static bool Object(object obj)
        {
            var objType = obj.GetType();

            if (objType == typeof(Type))
            {
                throw new NotSupportedException($"Types should be checked by using {nameof(Scalar)}.{nameof(Type)}");
            }

            return Type(objType);
        }

        public static bool Type(Type type)
        {
            if (Types.Contains(type))
                return true;

            if (type.IsEnum)
                return true;

            return false;
        }
    }

    public static class Diff
    {
        public class Changes
        {
            public List<ScalarPropertyDiff> ScalarChanges { get; set; } = new List<ScalarPropertyDiff>();
            public List<CollectionPropertyDiff> CollectionChanges { get; set; } = new List<CollectionPropertyDiff>();

            public bool None => ScalarChanges.Count == 0 && CollectionChanges.Count == 0;
        }

        public class ScalarPropertyDiff
        {
            public PropertyInfo Property { get; set; }
            public object FirstValue { get; set; }
            public object SecondValue { get; set; }
        }

        public class CollectionPropertyDiff
        {
            public PropertyInfo Property { get; set; }
            public CollectionChanges Changes { get; set; }
        }

        public class CollectionChanges
        {
            // There's no such thing as common but changed
            // They might represent the same logical object,
            // but their serialization is different. 
            // It's basically just in first/just in second VERSIONS of objects

            public List<object> JustInFirst { get; set; } = new List<object>();
            public List<object> JustInSecond { get; set; } = new List<object>();

            public bool None => JustInFirst.Count == 0 && JustInSecond.Count == 0;
        }

        public static CollectionChanges Collections(System.Collections.IEnumerable first, System.Collections.IEnumerable second)
        {
            Dictionary<string, object> firstAsJson = new Dictionary<string, object>();
            Dictionary<string, object> secondAsJson = new Dictionary<string, object>();

            foreach (var item in first)
            {
                var json = Metapsi.Serialize.ToJson(item);
                firstAsJson.Add(json, item);
            }

            foreach (var item in second)
            {
                var json = Metapsi.Serialize.ToJson(item);
                secondAsJson.Add(json, item);
            }

            CollectionChanges result = new CollectionChanges();

            List<string> firstKeys = firstAsJson.Keys.ToList();

            foreach (var json in firstKeys)
            {
                if (secondAsJson.ContainsKey(json))
                {
                    //result.Common.Add(firstAsJson[json]);
                    firstAsJson.Remove(json);
                    secondAsJson.Remove(json);
                }
                else
                {
                    result.JustInFirst.Add(firstAsJson[json]);
                    firstAsJson.Remove(json);
                }
            }

            List<string> remainingSecondKeys = secondAsJson.Keys.ToList();
            foreach (var json in remainingSecondKeys)
            {
                if (firstAsJson.ContainsKey(json))
                {
                    // Common values should already be removed
                    throw new Exception("Error in diff");
                }
                else
                {
                    result.JustInSecond.Add(secondAsJson[json]);
                }
            }

            return result;
        }

        public static Changes Anything<T>(T first, T second)
        {
            Changes diff = new Changes();

            var allProperties = typeof(T).GetProperties();

            foreach (var property in allProperties)
            {
                if (property.CanWrite)
                {
                    var propertyType = property.PropertyType;
                    if (Scalar.Type(propertyType))
                    {
                        var firstValue = property.GetValue(first);
                        var secondValue = property.GetValue(second);

                        if (firstValue.ToString() != secondValue.ToString())
                        {
                            diff.ScalarChanges.Add(new ScalarPropertyDiff()
                            {
                                Property = property,
                                FirstValue = firstValue,
                                SecondValue = secondValue
                            });
                        }
                    }
                    else if (property.PropertyType.IsAssignableTo(typeof(System.Collections.IEnumerable)))
                    {
                        var firstCollection = property.GetValue(first) as System.Collections.IEnumerable;
                        var secondCollection = property.GetValue(second) as System.Collections.IEnumerable;

                        var collectionsDiff = Collections(firstCollection, secondCollection);
                        if (!collectionsDiff.None)
                        {
                            diff.CollectionChanges.Add(new CollectionPropertyDiff()
                            {
                                Changes = collectionsDiff,
                                Property = property
                            });
                        }
                    }
                    else
                    {
                        // Not supported
                    }
                }
            }

            return diff;
        }

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