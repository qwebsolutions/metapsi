using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using static Metapsi.Sqlite.Ddl;

namespace Metapsi.Sqlite
{
    public static class Ddl
    {
        public static string GetSqliteTypeAffinity(this Type cSharpType)
        {
            var typeMapping = ScalarMappings.SingleOrDefault(x => x.CSharpType == cSharpType);
            if (typeMapping != null)
                return typeMapping.SqliteType;
            return "TEXT";
        }

        public class ScalarMapping
        {
            public ScalarMapping(Type cSharpType, string sqliteType)
            {
                CSharpType = cSharpType;
                SqliteType = sqliteType;
            }

            public Type CSharpType { get; set; }
            public string SqliteType { get; set; }
        }

        public class ScalarField
        {
            public PropertyInfo PropertyInfo { get; set; }
            public ScalarMapping ScalarMapping { get; set; }
        }

        public class FieldDefinition
        {
            public string FieldName { get; set; }
            public string Definition { get; set; }
        }

        public static List<ScalarMapping> ScalarMappings = new List<ScalarMapping>()
        {
            new ScalarMapping(typeof(bool), "INTEGER"),
            new ScalarMapping(typeof(int), "INTEGER"),
            new ScalarMapping(typeof(string), "TEXT"),
            new ScalarMapping(typeof(Guid), "TEXT"),
            new ScalarMapping(typeof(DateTime), "TEXT")
        };

        public static List<Type> SupportedScalarTypes => ScalarMappings.Select(x => x.CSharpType).ToList();

        public static IEnumerable<string> FieldNames(object o)
        {
            return FieldNames(o.GetType());
        }

        public static IEnumerable<string> FieldNames(System.Type t)
        {
            return t.GetProperties().Where(x => SupportedScalarTypes.Contains(x.PropertyType)).Select(x => x.Name);
        }

        public static IEnumerable<string> FieldNames<T>()
        {
            return FieldNames(typeof(T));
        }

        /// <summary>
        /// Adds quotes to mark keywords as identifiers
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string QuoteIdentifier(string s)
        {
            if (s.StartsWith("\""))
                return s;

            return "\"" + s + "\"";
        }

        public static List<ScalarField> Fields(Type t)
        {
            List<ScalarField> scalarFields = new List<ScalarField>();
            foreach (var property in t.GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance))
            {
                if (SupportedScalarTypes.Contains(property.PropertyType))
                {
                    scalarFields.Add(new ScalarField()
                    {
                        PropertyInfo = property,
                        ScalarMapping = ScalarMappings.First(x => x.CSharpType == property.PropertyType)
                    });
                }
            }

            return scalarFields;
        }

        public static List<FieldDefinition> GetFieldDefinitions(Type t)
        {
            List<FieldDefinition> fieldDefinitions = new List<FieldDefinition>();
            var allFields = Fields(t);
            foreach (var field in allFields)
            {
                fieldDefinitions.Add(
                    new FieldDefinition()
                    {
                        FieldName = field.PropertyInfo.Name,
                        Definition = $"{QuoteIdentifier(field.PropertyInfo.Name)} {field.ScalarMapping.SqliteType}"
                    });
            }
            return fieldDefinitions;
        }

        public static string GetCreateTableStatement<T>(bool ifNotExists = true, Action<FieldDefinition> overwriteFieldDefinition = null)
        {
            var fieldDefinitions = GetFieldDefinitions(typeof(T));
            if (overwriteFieldDefinition == null)
            {
                overwriteFieldDefinition = (fd) => { };
            }
            fieldDefinitions.ForEach(overwriteFieldDefinition);

            string ifNotExistsPlaceholder = ifNotExists ? " IF NOT EXISTS " : " ";

            return $"CREATE TABLE{ifNotExistsPlaceholder}\"{typeof(T).Name}\" ({string.Join(", ", fieldDefinitions.Select(x => x.Definition))})";
        }

        public static async Task CreateTable<T>(this SQLiteTransaction transaction, Action<FieldDefinition> overwriteFieldDefinition = null)
        {
            var createStatement = GetCreateTableStatement<T>(false, overwriteFieldDefinition: overwriteFieldDefinition);
            await transaction.Connection.ExecuteAsync(createStatement, transaction: transaction);
        }

        public static async Task CreateTableIfNotExists<T>(this SQLiteTransaction transaction, Action<FieldDefinition> overwriteFieldDefinition = null)
        {
            var createStatement = GetCreateTableStatement<T>(true, overwriteFieldDefinition: overwriteFieldDefinition);
            await transaction.Connection.ExecuteAsync(createStatement, transaction: transaction);
        }

        public static async Task<TableInfo> GetCurrentTableStructure(this SQLiteTransaction transaction, string tableName)
        {
            IEnumerable<FieldInfo> allFields = await transaction.Connection.QueryAsync<FieldInfo>($"select * from PRAGMA_TABLE_INFO('{tableName}');", transaction: transaction);
            return new TableInfo()
            {
                TableName = tableName,
                Fields = allFields.ToList()
            };
        }

        public static string ColumnDefinition(this FieldInfo fieldInfo)
        {
            var defaultValueString = string.Empty;
            if (!string.IsNullOrEmpty(fieldInfo.dflt_value))
            {
                if (fieldInfo.type == "TEXT")
                {
                    defaultValueString = $"DEFAULT '{fieldInfo.dflt_value}'";
                }
                else
                {
                    defaultValueString = $"DEFAULT {fieldInfo.dflt_value}";
                }
            }

            List<string> definitionTokens = new List<string>()
            {
                QuoteIdentifier(fieldInfo.name),
                fieldInfo.type,
                fieldInfo.pk? "PRIMARY KEY": string.Empty,
                fieldInfo.notnull? "NOT NULL": string.Empty,
                defaultValueString
            };

            var columnDefinition = string.Join(" ", definitionTokens);
            return columnDefinition;
        }

        public static async Task Migrate<T>(this SQLiteTransaction transaction, TableInfo expected, System.Func<SQLiteTransaction, Diff.CollectionChanges<FieldInfo>, Task> migrateAction)
        {
            var currentTableInfo = await transaction.GetCurrentTableStructure(typeof(T).Name);
            var fieldChanges = ChangedFields(currentTableInfo, expected);
            await migrateAction(transaction, fieldChanges);
        }

        public static async Task Migrate<T>(this SQLiteTransaction transaction, System.Func<SQLiteTransaction, Diff.CollectionChanges<FieldInfo>, Task> migrateAction)
        {
            await Migrate<T>(transaction, GetDefaultTableInfo<T>(), migrateAction);
        }

        public static bool ExpectedFieldIsMissing(this Diff.CollectionChanges<FieldInfo> changes, string fieldName)
        {
            return changes.JustInSecond.Any(x => x.name == fieldName);
        }

        public static bool UnusedFieldIsPresent(this Diff.CollectionChanges<FieldInfo> changes, string fieldName)
        {
            return changes.JustInFirst.Any(x => x.name == fieldName);
        }

        public static FieldInfo ExpectedField(this Diff.CollectionChanges<FieldInfo> changes, string fieldName)
        {
            return changes.JustInSecond.SingleOrDefault(x => x.name == fieldName);
        }

        public static TableInfo GetDefaultTableInfo<T>()
        {
            var tableInfo = new TableInfo() { TableName = typeof(T).Name };
            foreach (var property in typeof(T).GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance))
            {
                if (SupportedScalarTypes.Contains(property.PropertyType))
                {
                    tableInfo.Fields.Add(new FieldInfo()
                    {
                        cid = tableInfo.Fields.Count,
                        dflt_value = null,
                        name = property.Name,
                        notnull = false,
                        pk = false,
                        type = ScalarMappings.First(x => x.CSharpType == property.PropertyType).SqliteType
                    });
                }
            }

            return tableInfo;
        }

        public static Diff.CollectionChanges<FieldInfo> ChangedFields(this TableInfo existing, TableInfo expected)
        {
            var fieldsDiff = Diff.CollectionsByKey(existing.Fields, expected.Fields, x => x.name);
            return fieldsDiff;
        }
    }

    public class TableInfo
    {
        public string TableName { get; set; }
        public List<FieldInfo> Fields { get; set; } = new List<FieldInfo>();
    }

    public class FieldInfo
    {
        public int cid { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public bool notnull { get; set; }
        public string dflt_value { get; set; }
        public bool pk { get; set; }
    }
}
