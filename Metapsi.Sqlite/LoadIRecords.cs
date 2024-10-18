using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Metapsi.Sqlite
{
    public class OpenTransaction
    {
        public SQLiteConnection Connection { get; set; }
        public SQLiteTransaction Transaction { get; set; }
    }

    public static partial class Db
    {
        public static string ToConnectionString(string filePath)
        {
            if(filePath.Contains("Data Source"))
            {
                return filePath;
            }

            return $"Data Source = {filePath}";
        }

        public static SQLiteConnection ToConnection(string filePath)
        {
            return new SQLiteConnection(ToConnectionString(filePath));
        }

        public static SQLiteConnection ToReadOnlyConnection(string filePath)
        {
            var connectionString = ToConnectionString(filePath);
            connectionString += ";ReadOnly=True;";
            return new SQLiteConnection(connectionString);
        }

        public static async Task<TResult> WithRollback<TResult>(string filePath, Func<OpenTransaction, Task<TResult>> dbQuery)
        {
            var sw = System.Diagnostics.Stopwatch.StartNew();

            TResult result;

            using (SQLiteConnection conn = ToConnection(filePath))
            {
                await conn.OpenAsync();
                var transaction = conn.BeginTransaction();
                result = await dbQuery(new OpenTransaction()
                {
                    Connection = conn,
                    Transaction = transaction
                });
                transaction.Rollback();
            }

            System.Diagnostics.Debug.WriteLine($"{System.DateTime.UtcNow.Roundtrip()} WithRollback<{typeof(TResult).Name}> {sw.ElapsedMilliseconds}");

            return result;
        }

        public static async Task WithCommit(string filePath, Func<OpenTransaction, Task> dbAction)
        {
            var sw = System.Diagnostics.Stopwatch.StartNew();

            using (SQLiteConnection conn = ToConnection(filePath))
            {
                await conn.OpenAsync();
                var transaction = conn.BeginTransaction();
                await dbAction(new OpenTransaction()
                {
                    Connection = conn,
                    Transaction = transaction
                });
                transaction.Commit();
            }
            System.Diagnostics.Debug.WriteLine($"{System.DateTime.UtcNow.Roundtrip()} WithCommit {sw.ElapsedMilliseconds}");
        }

        public static async Task<TResult> WithCommit<TResult>(string filePath, Func<OpenTransaction, Task<TResult>> dbAction)
        {
            var sw = System.Diagnostics.Stopwatch.StartNew();

            using (SQLiteConnection conn = ToConnection(filePath))
            {
                await conn.OpenAsync();
                var transaction = conn.BeginTransaction();
                var result = await dbAction(new OpenTransaction()
                {
                    Connection = conn,
                    Transaction = transaction
                });
                transaction.Commit();


                System.Diagnostics.Debug.WriteLine($"{System.DateTime.UtcNow.Roundtrip()} WithCommit<{typeof(TResult).Name}> {sw.ElapsedMilliseconds}");

                return result;
            }
        }

        public static async Task<IEnumerable<TRecord>> Records<TRecord>(string fileName, IEnumerable<Guid> ids)
        {
            return await WithRollback(fileName, async c => await c.Transaction.LoadRecords<TRecord>(new List<Guid>(ids)));
        }

        public static async Task<IEnumerable<TRecord>> Records<TRecord>(string fileName)
            where TRecord: IRecord
        {
            return await WithRollback(fileName, async c => await c.Transaction.LoadRecords<TRecord>());
        }

        public static async Task<TRecord> Record<TRecord>(string fileName, Guid id)
            where TRecord : IRecord
        {
            return await WithRollback(fileName, async c => await c.Transaction.LoadRecord<TRecord>(id));
        }
    }
}
