using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace Metapsi.Sqlite
{
    public static class DbAccess
    {
        public static string GetInsertStatement(object o)
        {
            string tableName = o.GetType().Name;
            IEnumerable<string> fieldNames = Ddl.FieldNames(o);
            string joinedFields = string.Join(", ", fieldNames.Select(x => Ddl.QuoteIdentifier(x)));
            string joinedParameters = string.Join(", ", fieldNames.Select(x => $"@{x}"));
            string insertStatement = $"insert into \"{tableName}\" ({joinedFields}) values ({joinedParameters})";
            return insertStatement;
        }

        public static async Task SaveToDbPath(string dbPath, object o)
        {
            using (SQLiteConnection conn = new SQLiteConnection($"Data Source = {dbPath}"))
            {
                conn.Open();
                var transaction = conn.BeginTransaction();

                Save(o, transaction);
                transaction.Commit();
            }
        }

        public static async Task ExecuteToDbPath(string dbPath, string command, object parameter = null)
        {
            using (SQLiteConnection conn = new SQLiteConnection($"Data Source = {dbPath}"))
            {
                conn.Open();
                var transaction = conn.BeginTransaction();

                if (parameter != null)
                {
                    await conn.ExecuteAsync(command, parameter);
                }
                else
                {
                    await conn.ExecuteAsync(command);
                }
                transaction.Commit();
            }
        }

        public static void Save(object o, SQLiteTransaction transaction)
        {
            string tableName = o.GetType().Name;

            transaction.Connection.Execute($"delete from {Ddl.QuoteIdentifier(tableName)} where Id = @Id", o, transaction);
            string insertStatement = GetInsertStatement(o);
            transaction.Connection.Execute(insertStatement, o, transaction);
        }

        public static void SaveCollection<T>(
            string parentProperty,
            IEnumerable<T> collection,
            SQLiteTransaction transaction)
        {
            HashSet<object> hashSet = new HashSet<object>(collection.Select(x => x.GetType().GetProperty(parentProperty).GetValue(x)));
            if (hashSet.Count > 1)
            {
                throw new Exception("Collection items do not share the same parent ID!");
            }

            string tableName = typeof(T).Name;
            if (hashSet.Count == 1)
            {
                transaction.Connection.Execute($"delete from {Ddl.QuoteIdentifier(tableName)} where {Ddl.QuoteIdentifier(parentProperty)} = @Id",
                    new
                    {
                        Id = hashSet.Single().ToString()
                    },
                    transaction);
            }

            IEnumerable<string> fieldNames = typeof(T).GetProperties().Select(x => x.Name);
            string joinedFields = string.Join(", ", fieldNames.Select(x=>Ddl.QuoteIdentifier(x)));
            string joinedParameters = string.Join(", ", fieldNames.Select(x => $"@{x}"));
            string insertStatement = $"insert into {tableName} ({joinedFields}) values ({joinedParameters})";

            foreach (T item in collection)
            {
                transaction.Connection.Execute(insertStatement, item, transaction);
            }
        }

        public static void Delete(object o, SQLiteTransaction transaction)
        {
            string tableName = o.GetType().Name;
            transaction.Connection.Execute($"delete from {Ddl.QuoteIdentifier(tableName)} where Id = @Id", o, transaction);
        }

        public static void DeleteCollection(
            Type itemType,
            string parentProperty,
            object parentPropertyValue,
            SQLiteTransaction transaction)
        {
            transaction.Connection.Execute(
                $"delete from {Ddl.QuoteIdentifier(itemType.Name)} where {Ddl.QuoteIdentifier(parentProperty)} = @ParentId",
                new
                {
                    ParentId = parentPropertyValue
                },
                transaction);
        }
    }
}
