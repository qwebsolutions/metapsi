using System;

namespace Metapsi
{
    public static class ExpressionExtensions
    {
        public static string PropertyName<TObject, TProperty>(this System.Linq.Expressions.Expression<Func<TObject, TProperty>> expression)
        {
            return (expression.Body as System.Linq.Expressions.MemberExpression).Member.Name;
        }

        public static string PropertyName(this System.Linq.Expressions.LambdaExpression expression)
        {
            return (expression.Body as System.Linq.Expressions.MemberExpression).Member.Name;
        }
    }
}