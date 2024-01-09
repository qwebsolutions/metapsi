﻿using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace Metapsi.Sqlite
{
    public class NoSqlDocIndexAttribute: Attribute
    {
    }

    public static class NoSql
    {
        public interface IDocument
        {
            public string Id { get; set; }
        }

        public static string NormalizeTableName(string tableName)
        {
            return tableName.Replace(".", "_").Replace("`", "_");
        }

        internal class JustJson
        {
            public string json { get; set; }
        }

        private static HashSet<string> createdTables = new HashSet<string>();

        public static async Task CreateDocumentTable<T>(string fullDbPath)
        {
            var tableName = NormalizeTableName(typeof(T).FullName);

            // If the table is created don't attempt to create it again
            if (createdTables.Contains(tableName))
                return;

            if (createdTables.Count == 0)
            {
                await Db.WithCommit(fullDbPath, async (transaction) => await transaction.Connection.ExecuteAsync("PRAGMA journal_mode=WAL;", transaction: transaction.Transaction));
            }

            if (!createdTables.Contains(tableName))
            {
                await Db.WithCommit(fullDbPath, async (transaction) =>
                {
                    var tableTransaction = await transaction.Connection.BeginTransactionAsync();

                    var indexProperties = new List<string>();
                    foreach (var property in typeof(T).GetProperties())
                    {
                        if (property.CustomAttributes.Any(x => x.AttributeType == typeof(NoSqlDocIndexAttribute)))
                        {
                            indexProperties.Add(property.Name);
                        }
                    }

                    var tableColumnDeclarations = new List<string>();

                    if (typeof(T).IsAssignableTo(typeof(IDocument)))
                        if (!indexProperties.Contains("Id"))
                        {
                            indexProperties.Add("Id");
                        }

                    foreach (var indexProperty in indexProperties)
                    {
                        tableColumnDeclarations.Add($"{indexProperty} TEXT GENERATED ALWAYS AS (json_extract(json, '$.{indexProperty}')) VIRTUAL NOT NULL");
                    }
                    tableColumnDeclarations.Add("json TEXT");

                    var createDocCommand = $"CREATE TABLE IF NOT EXISTS {tableName} ({string.Join(",", tableColumnDeclarations)});";

                    await tableTransaction.Connection.ExecuteAsync(createDocCommand, transaction: tableTransaction);

                    foreach (var indexProperty in indexProperties)
                    {
                        await tableTransaction.Connection.ExecuteAsync(
                            $"CREATE UNIQUE INDEX IF NOT EXISTS {tableName}_{indexProperty} on {tableName}({indexProperty});",
                            transaction: tableTransaction);
                    }

                    await tableTransaction.CommitAsync();

                    createdTables.Add(tableName);
                });
            }
        }

        public static async Task InsertDocument<T>(this System.Data.Common.DbTransaction transaction, T document)
        {
            var tableName = NormalizeTableName(typeof(T).FullName);
            await transaction.Connection.ExecuteAsync($"insert into {tableName} (json) values(@json)", new { json = Metapsi.Serialize.ToJson(document) }, transaction);
        }

        public static async Task DeleteDocument<T>(this System.Data.Common.DbTransaction transaction, T document)
            where T : IDocument
        {
            var tableName = NormalizeTableName(typeof(T).FullName);
            await transaction.Connection.ExecuteAsync($"delete from {tableName} where id=@id", new { document.Id }, transaction);
        }

        public static async Task DeleteDocuments<T, TProp>(
            this System.Data.Common.DbTransaction transaction,
            System.Linq.Expressions.Expression<Func<T, TProp>> byProperty,
            TProp value)
        {
            var tableName = NormalizeTableName(typeof(T).FullName);
            var propertyName = byProperty.PropertyName();
            await transaction.Connection.ExecuteAsync($"delete from {tableName} where {propertyName}=@value", new { value }, transaction);
        }

        public static async Task SaveDocument<T>(this System.Data.Common.DbTransaction transaction, T document)
            where T : IDocument
        {
            await DeleteDocument(transaction, document);
            await InsertDocument(transaction, document);
        }

        public static async Task SaveDocument<T, TProp>(
            this System.Data.Common.DbTransaction transaction,
            T document,
            System.Linq.Expressions.Expression<Func<T, TProp>> idIndexProperty)
        {
            var getId = idIndexProperty.Compile();
            var value = getId(document);
            await DeleteDocuments(transaction, idIndexProperty, value);
            await InsertDocument(transaction, document);
        }

        public static async Task<T> GetDocument<T>(this System.Data.Common.DbTransaction transaction, string id)
            where T : IDocument
        {
            var tableName = NormalizeTableName(typeof(T).FullName);
            var json = await transaction.Connection.ExecuteScalarAsync<string>($"select json from {tableName} where id = @id", new { id }, transaction);

            if (string.IsNullOrWhiteSpace(json))
            {
                return default(T);
            }

            return Metapsi.Serialize.FromJson<T>(json);
        }

        public static async Task<T> GetDocument<T, TProp>(
            this SQLiteTransaction transaction,
            System.Linq.Expressions.Expression<Func<T, TProp>> byIndexProperty,
            TProp value)
        {
            var tableName = NormalizeTableName(typeof(T).FullName);
            var propertyName = byIndexProperty.PropertyName();
            var justJson = await transaction.Connection.QuerySingleOrDefaultAsync<JustJson>($"select json from {tableName} where {propertyName} = @value", new { value }, transaction);
            if (justJson != null)
            {
                return Metapsi.Serialize.FromJson<T>(justJson.json);
            }

            return default(T);
        }

        public static async Task<List<T>> GetDocuments<T>(
            this System.Data.Common.DbTransaction transaction)
        {
            var tableName = NormalizeTableName(typeof(T).FullName);
            var jsonDocuments = await transaction.Connection.QueryAsync<JustJson>($"select json from {tableName} ", new { }, transaction);

            return jsonDocuments.Select(x => Metapsi.Serialize.FromJson<T>(x.json)).ToList();
        }

        public static async Task<List<T>> GetDocuments<T, TProp>(
            this System.Data.Common.DbTransaction transaction,
            System.Linq.Expressions.Expression<Func<T, TProp>> byIndexProperty,
            TProp value)
        {
            var tableName = NormalizeTableName(typeof(T).FullName);
            var propertyName = byIndexProperty.PropertyName();
            var jsonDocuments = await transaction.Connection.QueryAsync<JustJson>($"select json from {tableName} where {propertyName} = @value", new { value }, transaction);

            return jsonDocuments.Select(x => Metapsi.Serialize.FromJson<T>(x.json)).ToList();
        }

        public static async Task<List<T>> FindDocuments<T>(
            this System.Data.Common.DbTransaction transaction,
            System.Linq.Expressions.Expression<Func<T, string>> byIndexProperty,
            string likePattern)
        {
            var tableName = NormalizeTableName(typeof(T).FullName);
            var propertyName = byIndexProperty.PropertyName();
            var jsonDocuments = await transaction.Connection.QueryAsync<JustJson>($"select json from {tableName} where {propertyName} like '{likePattern}'", new { }, transaction);
            return jsonDocuments.Select(x => Metapsi.Serialize.FromJson<T>(x.json)).ToList();
        }
    }
}
