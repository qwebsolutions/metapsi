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
        public static string ToConnectionString(
            string filePath,
            Action<SQLiteConnectionStringBuilder> build = null)
        {
            if (filePath.ToLower().Contains("data source"))
            {
                return filePath;
            }

            SQLiteConnectionStringBuilder builder = new SQLiteConnectionStringBuilder();
            builder.DataSource = filePath;
            builder.BinaryGUID = false;
            builder.DateTimeFormat = SQLiteDateFormats.ISO8601;
            if (build != null)
            {
                build(builder);
            }

            return builder.ConnectionString;
        }

        public static SQLiteConnection ToConnection(
            string filePath,
            Action<SQLiteConnectionStringBuilder> build = null)
        {
            return new SQLiteConnection(ToConnectionString(filePath, build));
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
