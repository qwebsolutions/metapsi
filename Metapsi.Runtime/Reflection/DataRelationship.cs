//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace Metapsi.Reflection
//{
//    public static class DataStructureRelationshipExtensions
//    {
//        public static async Task FillDataStructureAsync(
//            this List<DataRelationship> dataStructureRelationships,
//            IDataStructure dataStructure,
//            IEnumerable<Guid> startIds,
//            Func<FillStep, Task> buildAction)
//        {
//            RecordCollection<IRecord> filterIdsCollection = new RecordCollection<IRecord>();
//            filterIdsCollection.AddRange(startIds.Select(x => new JustId() { Id = x }));

//            // 'Fake' first step. Creates a virtual relationship between the input parameters & the first declared parent collection

//            await buildAction(new FillStep()
//            {
//                DestinationStructure = dataStructure,
//                CurrentRelationship = new DataRelationship()
//                {
//                    GetChildCollection = dataStructureRelationships.First().GetParentCollection,
//                    GetChildProperty = dataStructureRelationships.First().GetParentProperty,
//                    GetParentCollection = (ds) => filterIdsCollection,
//                    GetParentProperty = (item) => item.Id,
//                }
//            });

//            foreach (DataRelationship relationship in dataStructureRelationships)
//            {
//                var parentCollection = relationship.GetParentCollection(dataStructure);
//                var childCollection = relationship.GetChildCollection(dataStructure);
//                await buildAction(new FillStep()
//                {
//                    DestinationStructure = dataStructure,
//                    CurrentRelationship = relationship
//                });
//            }
//        }

//        public static void FillDataStructure(
//            this List<DataRelationship> dataStructureRelationships,
//            IDataStructure dataStructure,
//            IEnumerable<Guid> startIds,
//            Action<FillStep> buildAction)
//        {
//            RecordCollection<IRecord> startCollection = new RecordCollection<IRecord>();
//            startCollection.AddRange(startIds.Select(x => new JustId() { Id = x }));

//            // 'Fake' first step. Creates a virtual relationship between the input parameters & the first declared parent collection

//            buildAction(new FillStep()
//            {
//                DestinationStructure = dataStructure,
//                CurrentRelationship = new DataRelationship()
//                {
//                    GetChildCollection = dataStructureRelationships.First().GetParentCollection,
//                    GetChildProperty = dataStructureRelationships.First().GetParentProperty,
//                    GetParentCollection = (ds) => startCollection,
//                    GetParentProperty = (item) => item.Id,
//                }
//            });

//            foreach (DataRelationship relationship in dataStructureRelationships)
//            {
//                var parentCollection = relationship.GetParentCollection(dataStructure);
//                var childCollection = relationship.GetChildCollection(dataStructure);
//                buildAction(new FillStep()
//                {
//                    DestinationStructure = dataStructure,
//                    CurrentRelationship = relationship
//                });
//            }
//        }

//        public static T Subset<T>(
//            this List<DataRelationship> dataRelationships,
//            IDataStructure fromDataStructure,
//            Guid id) where T : class, IDataStructure, new()
//        {
//            T subset = new T();
//            dataRelationships.FillDataStructure(subset, new List<Guid>() { id }, fillStep =>
//            {
//                IRecordCollection destinationCollection = fillStep.CurrentRelationship.GetChildCollection(fillStep.DestinationStructure);
//                IRecordCollection sourceCollection = fillStep.CurrentRelationship.GetChildCollection(fromDataStructure);
//                IRecordCollection parentCollection = fillStep.CurrentRelationship.GetParentCollection(subset);
//                HashSet<Guid> parentIds = new HashSet<Guid>(parentCollection.Records.Select(x => fillStep.CurrentRelationship.GetParentProperty(x)));
//                IEnumerable<IRecord> filteredRecords = sourceCollection.Records.Where(x => parentIds.Contains(fillStep.CurrentRelationship.GetChildProperty(x)));
//                foreach (IRecord record in filteredRecords)
//                {
//                    destinationCollection.Add(record);
//                }
//            });

//            return subset;
//        }
//    }

//    //public class DataRelationship
//    //{
//    //    public Func<IDataStructure, IRecordCollection> GetParentCollection { get; set; }
//    //    public Func<IDataStructure, IRecordCollection> GetChildCollection { get; set; }

//    //    public Func<IRecord, Guid> GetParentProperty { get; set; }
//    //    public Func<IRecord, Guid> GetChildProperty { get; set; }

//    //    public Func<Guid, Guid, bool> Operator { get; set; } = (parentId, childId) => true;
//    //}

//    //public class FillStep
//    //{
//    //    public DataRelationship CurrentRelationship { get; set; }
//    //    public IDataStructure DestinationStructure { get; set; }
//    //}

//}
