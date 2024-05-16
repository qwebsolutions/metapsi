using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Threading.Tasks;
using System.Linq;

namespace Metapsi.Sqlite
{
    public static class Validate
    {
        public static async Task<FieldsDiff> ValidateSqliteSchema(string fullDbPath, IEnumerable<System.Type> recordTypes)
        {
            FieldsDiff fullSchemaDiff = new FieldsDiff();

            using (SQLiteConnection conn = new SQLiteConnection($"Data Source = {fullDbPath}"))
            {
                conn.Open();
                var transaction = conn.BeginTransaction();

                foreach (System.Type recordType in recordTypes)
                {
                    var tableDiff = await ValidateSqliteTable(transaction, recordType);

                    fullSchemaDiff.MissingFields.AddRange(tableDiff.MissingFields.Select(x => $"{recordType.Name}.{x}"));
                    fullSchemaDiff.ExtraFields.AddRange(tableDiff.ExtraFields.Select(x => $"{recordType.Name}.{x}"));
                }
                transaction.Rollback();
            }

            return fullSchemaDiff;
        }

        public static async Task<FieldsDiff> ValidateSqliteTable(SQLiteTransaction transaction, System.Type recordType)
        {
            IEnumerable<string> allFieldNames = await transaction.Connection.QueryAsync<string>($"select name from PRAGMA_TABLE_INFO('{recordType.Name}');", transaction: transaction);

            var recordProperties = recordType.GetProperties().Where(x => Ddl.SupportedScalarTypes.Contains(x.PropertyType)).Select(x => x.Name);

            var fieldsDiff = DiffFields(recordProperties, allFieldNames);

            return fieldsDiff;
        }

        public static FieldsDiff DiffFields(IEnumerable<string> knownFields, IEnumerable<string> existingFields)
        {
            FieldsDiff fieldsDiff = new FieldsDiff()
            {
                MissingFields = knownFields.Except(existingFields).ToList(),
                ExtraFields = existingFields.Except(knownFields).ToList()
            };

            return fieldsDiff;
        }


        public class FieldsDiff
        {
            public List<string> ExtraFields { get; set; } = new List<string>();
            public List<string> MissingFields { get; set; } = new List<string>();

            public bool SameFields => ExtraFields.Count == 0 && MissingFields.Count == 0;
        }
    }
}
