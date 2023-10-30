using Dapper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Metapsi.Sqlite
{
    public interface IDocument
    {
        string Id { get; }
    }

    public static class NoSql
    {
        private class Document
        {
            public string id { get; set; }
            public string type { get; set; }
            public string json { get; set; }
            public string timestamp { get; set; }
        }

        private static async Task CreateDocumentTable(this System.Data.Common.DbTransaction transaction)
        {
            await transaction.Connection.ExecuteAsync(
                "CREATE TABLE IF NOT EXISTS doc (id TEXT GENERATED ALWAYS AS (json_extract(json, '$.Id')) VIRTUAL NOT NULL, type TEXT NOT NULL, timestamp TEXT, json TEXT);",
                transaction: transaction);

            await transaction.Connection.ExecuteAsync(
                "CREATE UNIQUE INDEX IF NOT EXISTS doc_id on doc(id);",
                transaction: transaction);
        }

        public static async Task SaveDocument(this System.Data.Common.DbTransaction transaction, IDocument document)
        {
            Document internalDoc = new Document()
            {
                json = Metapsi.Serialize.ToJson(document),
                type = document.GetType().AssemblyQualifiedName,
                timestamp = System.DateTime.UtcNow.Roundtrip()
            };
            await CreateDocumentTable(transaction);
            await transaction.Connection.ExecuteAsync("delete from doc where id=@id", new { id = document.Id }, transaction);
            await transaction.Connection.ExecuteAsync(
                "insert into doc (type, timestamp, json) values(@type, @timestamp, @json)", internalDoc, transaction);
        }

        public static async Task<IEnumerable<string>> ListDocumentIds(this System.Data.Common.DbTransaction transaction)
        {
            await CreateDocumentTable(transaction);
            return await transaction.Connection.QueryAsync<string>("select id from doc");
        }

        public static async Task<T> GetDocument<T>(this System.Data.Common.DbTransaction transaction, string id)
        {
            await CreateDocumentTable(transaction);
            var internalDocument = await transaction.Connection.QuerySingleOrDefaultAsync<Document>("select id, type, timestamp, json from doc where id = @id", new { id }, transaction);

            if (internalDocument == null)
                return default(T);

            return (T)Metapsi.Serialize.FromJson(System.Type.GetType(internalDocument.type), internalDocument.json);
        }

        public static async Task DeleteDocument(this System.Data.Common.DbTransaction transaction, string id)
        {
            await CreateDocumentTable(transaction);
            await transaction.Connection.ExecuteAsync("delete from doc where id=@id", new { id }, transaction);
        }
    }
}
