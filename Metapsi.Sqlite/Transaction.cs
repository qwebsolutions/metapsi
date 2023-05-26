using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Threading.Tasks;
using System.Linq;

namespace Metapsi.Sqlite
{
    public static class TransactionExtensions
    {
        public static async Task InsertRecord(
            this System.Data.Common.DbTransaction transaction,
            IRecord record)
        {
            string insertStatement = DbAccess.GetInsertStatement(record);
            await transaction.Connection.ExecuteAsync(insertStatement, record, transaction);
        }

        public static async Task InsertRecords(
            this System.Data.Common.DbTransaction transaction,
            Type recordType,
            System.Collections.IEnumerable collection)
        {
            IEnumerable<string> fieldNames = recordType.GetProperties().Where(x => Db.SupportedScalarTypes.Contains(x.PropertyType)).Select(x => x.Name);
            string joinedFields = string.Join(", ", fieldNames);
            string joinedParameters = string.Join(", ", fieldNames.Select(x => $"@{x}"));
            string insertStatement = $"insert into {recordType.Name} ({joinedFields}) values ({joinedParameters})";

            foreach (IRecord item in collection)
            {
                await transaction.Connection.ExecuteAsync(insertStatement, item, transaction);
            }
        }

        public static async Task FillRecord(
            this System.Data.Common.DbTransaction transaction,
            IRecord record,
            List<IDowntreeRelation> fillRelations)
        {
            foreach (IDowntreeRelation downtreeRelation in fillRelations)
            {
                var parentValue = downtreeRelation.DowntreeIdFunction(record);

                foreach (IUptreeRelation uptreeRelation in downtreeRelation.ChildrenNodes)
                {
                    var childrenRecords = await transaction.LoadRecords(uptreeRelation.RecordType, uptreeRelation.UptreePropExpression, parentValue);
                    var childReference = uptreeRelation.FillPropertyFunction(record) as System.Collections.IList;
                    foreach (IRecord childRecord in childrenRecords)
                    {
                        childReference.Add(childRecord);
                        await transaction.FillRecord(childRecord, uptreeRelation.ChildrenNodes);
                    }
                }
            }
        }

        public static async Task<TDataStructure> LoadStructure<TDataStructure>(
            this System.Data.Common.DbTransaction transaction,
            UptreeRelation<TDataStructure> rootRelation,
            Guid id)
            where TDataStructure : IRecord, new()
        {
            TDataStructure dataStructure = await transaction.LoadRecord<TDataStructure>(id);
            if (dataStructure != null)
            {
                await transaction.FillRecord(dataStructure, rootRelation.ChildrenNodes);
            }
            return dataStructure;
        }

        public static async Task<List<TDataStructure>> LoadStructures<TDataStructure>(
            this System.Data.Common.DbTransaction transaction,
            UptreeRelation<TDataStructure> onRelation)
            where TDataStructure : IRecord, new()
        {
            var all = (await transaction.LoadRecords<TDataStructure>()).ToList();

            foreach (TDataStructure dataStructure in all)
            {
                await transaction.FillRecord(dataStructure, onRelation.ChildrenNodes);
            }

            return all;
        }


        public static async Task<List<TRecord>> LoadStructures<TRecord, TScalar>(
            this System.Data.Common.DbTransaction transaction,
            UptreeRelation<TRecord> onRelation,
            System.Linq.Expressions.Expression<Func<TRecord, TScalar>> byProperty,
            IEnumerable<TScalar> values)
        {
            return (await transaction.LoadStructures(onRelation, typeof(TRecord), byProperty, values.Cast<object>())).Cast<TRecord>().ToList();
        }

        public static async Task<List<TRecord>> LoadStructures<TRecord>(
            this System.Data.Common.DbTransaction transaction,
            UptreeRelation<TRecord> onRelation,
            IEnumerable<Guid> ids)
            where TRecord : IRecord
        {
            return await transaction.LoadStructures(onRelation, x => x.Id, ids);
        }

        public static async Task<List<IRecord>> LoadStructures(
            this System.Data.Common.DbTransaction transaction,
            IUptreeRelation onRelation,
            Type recordType,
            System.Linq.Expressions.LambdaExpression byProperty,
            IEnumerable<object> values)
        {
            var all = (await transaction.LoadRecords(recordType, byProperty, values)).ToList();

            foreach (IRecord dataStructure in all)
            {
                await transaction.FillRecord(dataStructure, onRelation.ChildrenNodes);
            }

            return all;
        }

        public static async Task<IEnumerable<TRecord>> LoadRecords<TRecord>(
            this System.Data.Common.DbTransaction transaction)
            where TRecord : IRecord
        {
            string typeName = typeof(TRecord).Name;
            string query = $"select * from [{typeName}]";
            IEnumerable<TRecord> loaded = await transaction.Connection.QueryAsync<TRecord>(query, transaction: transaction);
            return loaded;
        }

        public static async Task<TRecord> LoadRecord<TRecord>(
            this System.Data.Common.DbTransaction transaction,
            System.Guid id)
            where TRecord : IRecord
        {
            string childTypeName = typeof(TRecord).Name;

            string query = $"select * from [{childTypeName}] where [Id] = @Id";
            TRecord record = await transaction.Connection.QuerySingleOrDefaultAsync<TRecord>(query, new { Id = id }, transaction);
            return record;
        }

        public static async Task<TRecord> LoadRecord<TRecord, TScalar>(
            this System.Data.Common.DbTransaction transaction,
            System.Linq.Expressions.Expression<Func<TRecord, TScalar>> byProperty,
            TScalar scalarValue)
        {
            string childTypeName = typeof(TRecord).Name;
            string propertyName = byProperty.PropertyName();
            string query = $"select * from [{childTypeName}] where [{propertyName}] = @val";
            TRecord record = await transaction.Connection.QuerySingleOrDefaultAsync<TRecord>(query, new { val = scalarValue }, transaction);
            return record;
        }

        public static async Task<IEnumerable<TRecord>> LoadRecords<TRecord>(
            this System.Data.Common.DbTransaction transaction,
            IEnumerable<Guid> ids)
        {
            string childTypeName = typeof(TRecord).Name;
            string query = $"select * from [{childTypeName}] where [Id] in @ids";
            IEnumerable<TRecord> loadedRecords = await transaction.Connection.QueryAsync<TRecord>(query, new { ids = ids.Select(x => x.ToString()).ToList() }, transaction);
            return loadedRecords;
        }

        public static async Task<IEnumerable<TRecord>> LoadRecords<TRecord, TScalar>(
            this System.Data.Common.DbTransaction transaction,
            System.Linq.Expressions.Expression<Func<TRecord, TScalar>> byProperty,
            TScalar scalarValue)
        {
            string childTypeName = typeof(TRecord).Name;
            string propertyName = byProperty.PropertyName();
            string query = $"select * from [{childTypeName}] where [{propertyName}] = @val";
            IEnumerable<TRecord> loadedChildren = await transaction.Connection.QueryAsync<TRecord>(query, new { val = scalarValue }, transaction);
            return loadedChildren;
        }

        public static async Task<IEnumerable<TRecord>> LoadRecords<TRecord, TScalar>(
            this SQLiteTransaction transaction,
            System.Linq.Expressions.Expression<Func<TRecord, TScalar>> byProperty,
            IEnumerable<TScalar> scalarValues)
        {
            string childTypeName = typeof(TRecord).Name;
            string propertyName = byProperty.PropertyName();

            string query = $"select * from [{childTypeName}] where [{propertyName}] in @val";
            IEnumerable<TRecord> loadedChildren = await transaction.Connection.QueryAsync<TRecord>(query, new { val = scalarValues.Select(x => x.ToString()).ToList() }, transaction);
            return loadedChildren;
        }

        public static async Task<IEnumerable<IRecord>> LoadRecords(
            this System.Data.Common.DbTransaction transaction,
            Type recordType,
            System.Linq.Expressions.LambdaExpression byProperty,
            object parentValue)
        {
            string propertyName = byProperty.PropertyName();
            string query = $"select * from [{recordType.Name}] where [{propertyName}] = @parentValue";

            if (parentValue is Guid)
                parentValue = parentValue.ToString();

            IEnumerable<object> loadedChildren = await transaction.Connection.QueryAsync(recordType, query, new { parentValue }, transaction);
            return loadedChildren.Cast<IRecord>();
        }

        public static async Task<IEnumerable<IRecord>> LoadRecords(
            this System.Data.Common.DbTransaction transaction,
            Type recordType,
            System.Linq.Expressions.LambdaExpression byProperty,
            IEnumerable<object>  parentValues)
        {
            List<object> inList = new List<object>();
            foreach (object parentValue in parentValues)
            {
                if (parentValue is Guid)
                {
                    inList.Add(parentValue.ToString());
                }
                else
                {
                    inList.Add(parentValue);
                }
            }

            string propertyName = byProperty.PropertyName();
            string query = $"select * from [{recordType.Name}] where [{propertyName}] in @inList";

            IEnumerable<object> loadedChildren = await transaction.Connection.QueryAsync(recordType, query, new { inList }, transaction);
            return loadedChildren.Cast<IRecord>();
        }

        public static async Task DeleteRecord<TRecord>(
            this System.Data.Common.DbTransaction transaction,
            Guid id) where TRecord: IRecord
        {
            await transaction.DeleteRecords<TRecord, Guid>(r => r.Id, new List<Guid>() { id });
        }

        public static async Task DeleteRecords<TRecord, TScalar>(
            this System.Data.Common.DbTransaction transaction,
            System.Linq.Expressions.Expression<Func<TRecord, TScalar>> byProperty,
            IEnumerable<TScalar> scalarValues)
        {
            string typeName = typeof(TRecord).Name;
            string propertyName = byProperty.PropertyName();

            string delete = $"delete from [{typeName}] where [{propertyName}] in @values";
            await transaction.Connection.ExecuteAsync(delete, new { values = scalarValues.Select(x => x.ToString()).ToList() }, transaction);
        }

        public static async Task DeleteRecords(
            this System.Data.Common.DbTransaction transaction,
            Type recordType,
            System.Linq.Expressions.LambdaExpression byProperty,
            object propertyValue)
        {
            string propertyName = byProperty.PropertyName();

            if (propertyValue is Guid)
                propertyValue = propertyValue.ToString();

            string delete = $"delete from [{recordType.Name}] where [{propertyName}] = @propertyValue";
            await transaction.Connection.ExecuteAsync(delete, new { propertyValue }, transaction);
        }

        public static async Task InsertStructure(
            this System.Data.Common.DbTransaction transaction,
            IRecord record,
            List<IDowntreeRelation> relations)
        {
            await transaction.InsertRecord(record);
            foreach (IDowntreeRelation downtreeRelation in relations)
            {
                var parentValue = downtreeRelation.DowntreeIdFunction(record);

                foreach (IUptreeRelation uptreeRelation in downtreeRelation.ChildrenNodes)
                {
                    System.Collections.IEnumerable records = (System.Collections.IEnumerable)uptreeRelation.FillPropertyFunction(record);
                    foreach (IRecord childRecord in records)
                    {
                        await transaction.InsertStructure(childRecord, uptreeRelation.ChildrenNodes);
                    }
                }
            }
        }

        public static async Task DeleteRecord(
            this System.Data.Common.DbTransaction transaction,
            IRecord record)
        {
            string tableName = record.GetType().Name;
            await transaction.Connection.ExecuteAsync($"delete from {tableName} where Id = @Id", record, transaction);
        }

        public static async Task DeleteStructure(
            this System.Data.Common.DbTransaction transaction,
            IRecord record,
            List<IDowntreeRelation> relations)
        {
            if (record == null)
                return;

            await transaction.DeleteRecord(record);
            foreach (IDowntreeRelation downtreeRelation in relations)
            {
                var parentValue = downtreeRelation.DowntreeIdFunction(record);

                foreach (IUptreeRelation uptreeRelation in downtreeRelation.ChildrenNodes)
                {
                    System.Collections.IEnumerable records = (System.Collections.IEnumerable)uptreeRelation.FillPropertyFunction(record);
                    foreach (IRecord childRecord in records)
                    {
                        await transaction.DeleteStructure(childRecord, uptreeRelation.ChildrenNodes);
                    }
                }
            }
        }

        public static async Task SaveStructure<TRecord>(
            this System.Data.Common.DbTransaction dbTransaction,
            UptreeRelation<TRecord> relation,
            TRecord record) where TRecord : IRecord, new()
        {
            var previouslySaved = await dbTransaction.LoadStructure(relation, record.Id);
            if (previouslySaved != null)
            {
                await dbTransaction.DeleteStructure(previouslySaved, relation.ChildrenNodes);
            }
            await dbTransaction.InsertStructure(record, relation.ChildrenNodes);
        }

        public static void SaveChanges(
            this SQLiteTransaction transaction,
            DataStructureDiff dataStructureDiff)
        {
            transaction.DeleteRemovedItems(dataStructureDiff);
            transaction.InsertAddedItems(dataStructureDiff);
            transaction.UpdateChangedItems(dataStructureDiff);
        }

        public static void DeleteRemovedItems(
            this SQLiteTransaction transaction,
            DataStructureDiff dataStructureDiff)
        {
            foreach (RemovedDataItem removedDataItem in dataStructureDiff.RemovedItems)
            {
                DeleteRemovedItem(dataStructureDiff, removedDataItem, transaction);
            }
        }

        public static void DeleteRemovedItem(
            DataStructureDiff dataStructureDiff,
            RemovedDataItem removedDataItem,
            SQLiteTransaction transaction)
        {
            Type removedType = Type.GetType(removedDataItem.DataItemType);
            transaction.Connection.Execute(
                $"delete from {removedType.Name} where Id = @DataItemId", removedDataItem, transaction);
        }

        public static void InsertAddedItems(
            this SQLiteTransaction transaction,
            DataStructureDiff dataStructureDiff)
        {
            foreach (AddedDataItem addedDataItem in dataStructureDiff.AddedItems)
            {
                transaction.InsertAddedItem(dataStructureDiff, addedDataItem);
            }
        }


        public static void InsertAddedItem(
            this SQLiteTransaction transaction,
            DataStructureDiff dataStructureDiff,
            AddedDataItem addedDataItem)
        {
            Type type = Type.GetType(addedDataItem.DataItemType);
            object insertObject = Activator.CreateInstance(type);
            var properties = dataStructureDiff.ItemProperties.Where(x => x.ChangeId == addedDataItem.Id);

            foreach (var property in properties)
            {
                type.GetProperty(property.PropertyName).SetValue(insertObject, Scalar.GetConvertedValue(property));
            }

            string insertStatement = DbAccess.GetInsertStatement(insertObject);
            transaction.Connection.Execute(insertStatement, insertObject, transaction);
        }


        public static void UpdateChangedItems(
            this SQLiteTransaction transaction,
            DataStructureDiff dataStructureDiff)
        {
            foreach (ChangedDataItem changedDataItem in dataStructureDiff.ChangedItems)
            {
                transaction.UpdateChangedItem(dataStructureDiff, changedDataItem);
            }
        }

        public static void UpdateChangedItem(
            this SQLiteTransaction transaction,
            DataStructureDiff dataStructureDiff,
            ChangedDataItem changedDataItem)
        {
            var updatedProperties = dataStructureDiff.ItemProperties.Where(x => x.ChangeId == changedDataItem.Id);

            string updateFields = string.Join(", ", updatedProperties.Select(x => $"{x.PropertyName} = @{x.PropertyName}"));

            Type type = Type.GetType(changedDataItem.DataItemType);
            object updateObject = Activator.CreateInstance(type);

            type.GetProperty("Id").SetValue(updateObject, changedDataItem.DataItemId);
            foreach (var property in updatedProperties)
            {
                type.GetProperty(property.PropertyName).SetValue(updateObject, Scalar.GetConvertedValue(property));
            }

            transaction.Connection.Execute($"update {type.Name} set {updateFields} where Id = @Id", updateObject, transaction);
        }
    }
}
