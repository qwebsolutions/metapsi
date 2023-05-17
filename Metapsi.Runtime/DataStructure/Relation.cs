using System;
using System.Collections.Generic;
using System.Linq;

namespace Metapsi
{
    public static partial class Relation
    {
        public static List<DataStructureRelation> DefaultRelations(Type dataStructureType)
        {
            List<DataStructureRelation> dataStructureRelations = new List<DataStructureRelation>();

            var collections = Collection.Collections(dataStructureType);
            Dictionary<string, string> knownCollections = new Dictionary<string, string>();

            foreach(CollectionInfo collectionInfo in collections)
            {
                knownCollections.Add(collectionInfo.RecordType.Name, collectionInfo.PropertyInfo.Name);

                if (collectionInfo.Relation != null)
                {
                    dataStructureRelations.Add(collectionInfo.Relation);
                }
                else
                {
                    var relatedIdProperties = collectionInfo.RecordType.GetProperties().Where(x => x.Name != "Id" && x.Name.EndsWith("Id"));

                    foreach (var relatedIdProperty in relatedIdProperties)
                    {
                        string parentRecordType = relatedIdProperty.Name.Substring(0, relatedIdProperty.Name.Length - 2);
                        if (knownCollections.ContainsKey(parentRecordType))
                        {
                            dataStructureRelations.Add(new DataStructureRelation()
                            {
                                ParentCollectionName = knownCollections[parentRecordType],
                                ChildCollectionName = collectionInfo.PropertyInfo.Name,
                                ParentIdField = "Id",
                                ChildIdField = relatedIdProperty.Name
                            });
                        }
                    }
                }
            }

            return dataStructureRelations;
        }
    }
}
