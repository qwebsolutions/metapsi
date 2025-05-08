using System.Linq.Expressions;
using System;

namespace Metapsi.Syntax
{
    public static partial class Core
    {
        public static void SetProperty(this SyntaxBuilder b, IVariable into, Var<string> propertyName, IVariable value)
        {
            var import = ImportCore<Delegate>(b, "SetProperty");
            b.CallDynamic(import, into, propertyName, value);
        }

        public static void SetLax<TItem>(SyntaxBuilder b, Var<TItem> var, LambdaExpression access, IVariable value)
        {
            if (!(access.Body is MemberExpression))
            {
                throw new Exception($"Expression {access} is not valid in setter. Setter can only be used on properties of accessor variable");
            }
            else if ((access.Body as MemberExpression).Expression is MemberExpression)
            {
                // If nested member expression
                throw new Exception($"Expression {access} is not valid in setter. Setter can only be used on properties of accessor variable");
            }

            b.SetProperty(var, b.Const(access.PropertyName()), value);
        }

        public static void Set<TItem, TProp>(this SyntaxBuilder b, Var<TItem> var, Expression<Func<TItem, TProp>> access, Var<TProp> value)
        {
            SetLax(b, var, access, value);
        }

        public static void Set<TItem, TProp>(this SyntaxBuilder b, Var<TItem> var, Expression<Func<TItem, TProp>> access, TProp value)
        {
            // Guard against 'double clienting'
            if (value is IVariable)
            {
                SetLax(b, var, access, value as IVariable);
            }
            else
            {
                b.Set(var, access, b.Const(value));
            }
        }

        public static void DeleteProperty(this SyntaxBuilder b, IVariable from, Var<string> propertyName)
        {
            var deleteProperty = ImportCore<Delegate>(b, "DeleteProperty");
            b.CallDynamic(deleteProperty, from, propertyName);
        }

        public static void DeleteProperty<T, TProp>(this SyntaxBuilder b, Var<T> from, System.Linq.Expressions.Expression<Func<T, TProp>> property)
        {
            b.DeleteProperty(from, b.Const(property.PropertyName()));
        }
    }
}
