using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Metapsi.Sqlite
{
    public static partial class Db
    {
        public static async Task<IEnumerable<TEntity>> Entities<TEntity>(string fileName)
        {
            return await WithRollback(fileName, async c => await c.Transaction.LoadEntities<TEntity>());
        }

        public static async Task<IEnumerable<TEntity>> Entities<TEntity, TScalar>(string fileName,
            System.Linq.Expressions.Expression<Func<TEntity, TScalar>> byProperty,
            TScalar scalarValue)
        {
            return await WithRollback(fileName, async c => await c.Transaction.LoadRecords<TEntity, TScalar>(byProperty, scalarValue));
        }

        public static async Task<IEnumerable<TEntity>> Entities<TEntity, TScalar>(string fileName,
            System.Linq.Expressions.Expression<Func<TEntity, TScalar>> byProperty,
            IEnumerable<TScalar> scalarValue)
        {
            return await WithRollback(fileName, async c => await c.Transaction.LoadRecords<TEntity, TScalar>(byProperty, scalarValue));
        }
    }
}