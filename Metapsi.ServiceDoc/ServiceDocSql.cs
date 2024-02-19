using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace Metapsi;

public class DocIndexAttribute: Attribute
{
}

[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
public class DocDescriptionAttribute : Attribute
{
    public DocDescriptionAttribute(string summary)
    {
    }

    public DocDescriptionAttribute(string summary, int order)
    {
    }
}

public static partial class ServiceDoc
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

    private class PragmaXTableRow
    {
        public string name { get; set; }
    }

    public static bool TableCreated<T>()
    {
        var tableName = NormalizeTableName(typeof(T).FullName);

        // If the table is created don't attempt to create it again
        return createdTables.Contains(tableName);
    }

    private static HashSet<string> createdTables = new HashSet<string>();

    public static async Task CreateDocumentTableAsync<T>(string fullDbPath)
    {
        var tableName = NormalizeTableName(typeof(T).FullName);

        // If the table is created don't attempt to create it again
        if (TableCreated<T>())
            return;

        using (SQLiteConnection conn = Sqlite.Db.ToConnection(fullDbPath))
        {
            await conn.OpenAsync();

            if (createdTables.Count == 0)
            {
                await conn.ExecuteAsync("PRAGMA journal_mode=WAL;");
            }

            if (!createdTables.Contains(tableName))
            {
                var indexProperties = new List<string>();
                foreach (var property in typeof(T).GetProperties())
                {
                    if (property.CustomAttributes.Any(x => x.AttributeType == typeof(DocIndexAttribute)))
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

                await conn.ExecuteAsync(createDocCommand);

                // If table already existed, it was not recreated. 
                // Check if all index columns are created


                var allColumns = await conn.QueryAsync<PragmaXTableRow>($"PRAGMA table_xinfo({tableName});");

                foreach (var indexProperty in indexProperties)
                {
                    if (!allColumns.Any(x => x.name == indexProperty))
                    {
                        await conn.ExecuteAsync($"ALTER TABLE {tableName} ADD COLUMN {indexProperty} TEXT GENERATED ALWAYS AS (json_extract(json, '$.{indexProperty}')) VIRTUAL NOT NULL");
                    }
                }

                foreach (var indexProperty in indexProperties)
                {
                    await conn.ExecuteAsync(
                        $"CREATE INDEX IF NOT EXISTS {tableName}_{indexProperty} on {tableName}({indexProperty});");
                }

                createdTables.Add(tableName);
            }
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
