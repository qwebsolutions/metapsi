using Dapper;
using System;
using System.Data.SQLite;
using System.Threading.Tasks;

namespace Metapsi.Sqlite
{
    public class SqliteQueue : TaskQueue<SQLiteConnection>
    {
        public string DbPath { get; private set; }

        public SqliteQueue(string dbPath) : base(InitializeConnection(dbPath))
        {
            this.DbPath = dbPath;
        }

        private static SQLiteConnection InitializeConnection(string dbPath)
        {
            SQLiteConnection connection = Db.ToConnection(dbPath);
            connection.Open();
            return connection;
        }

        public async Task CloseConnection()
        {
            await this.Enqueue(async (connection) =>
            {
                connection.Close();
            });
        }
    }

    public static class SqliteQueueExtensions
    {
        public static async Task SetJournalMode(this SqliteQueue sqliteQueue, string mode)
        {
            await sqliteQueue.Enqueue(async (conn) => await conn.ExecuteAsync($"PRAGMA journal_mode={mode};"));
        }

        public static async Task SetJournalModeWal(this SqliteQueue sqliteQueue)
        {
            await sqliteQueue.SetJournalMode("WAL");
        }

        public static async Task<TResult> WithCommit<TResult>(this SqliteQueue sqliteQueue, Func<SQLiteTransaction, Task<TResult>> dbAction)
        {
            return await sqliteQueue.Enqueue(async (conn) =>
            {
                var sw = System.Diagnostics.Stopwatch.StartNew();
                var transaction = conn.BeginTransaction();
                var result = await dbAction(transaction);
                transaction.Commit();

                System.Diagnostics.Debug.WriteLine($"{System.DateTime.UtcNow.Roundtrip()} WithCommit<{typeof(TResult).CSharpTypeName()}> {sw.ElapsedMilliseconds}");
                return result;
            });
        }

        public static async Task WithCommit(this SqliteQueue sqliteQueue, Func<SQLiteTransaction, Task> dbAction)
        {
            await sqliteQueue.Enqueue(async (conn) =>
            {
                var sw = System.Diagnostics.Stopwatch.StartNew();
                var transaction = conn.BeginTransaction();
                await dbAction(transaction);
                transaction.Commit();
                System.Diagnostics.Debug.WriteLine($"{System.DateTime.UtcNow.Roundtrip()} WithCommit {sw.ElapsedMilliseconds}");
            });
        }

        public static async Task<TResult> WithRollback<TResult>(this SqliteQueue sqliteQueue, Func<SQLiteTransaction, Task<TResult>> dbQuery)
        {
            return await sqliteQueue.Enqueue(async (conn) =>
            {
                var sw = System.Diagnostics.Stopwatch.StartNew();
                var transaction = conn.BeginTransaction();
                var result = await dbQuery(transaction);
                transaction.Rollback();
                System.Diagnostics.Debug.WriteLine($"{System.DateTime.UtcNow.Roundtrip()} WithRollback<{typeof(TResult).CSharpTypeName()}> {sw.ElapsedMilliseconds}");
                return result;
            });
        }

        public static async Task WithRollback(this SqliteQueue sqliteQueue, Func<SQLiteTransaction, Task> dbQuery)
        {
            await sqliteQueue.Enqueue(async (conn) =>
            {
                var sw = System.Diagnostics.Stopwatch.StartNew();
                var transaction = conn.BeginTransaction();
                await dbQuery(transaction);
                transaction.Rollback();
                System.Diagnostics.Debug.WriteLine($"{System.DateTime.UtcNow.Roundtrip()} WithRollback {sw.ElapsedMilliseconds}");
            });
        }
    }
}