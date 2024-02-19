using Metapsi.Hyperapp;
using Metapsi.Syntax;
using Metapsi.Dom;
using System;
using Metapsi.Shoelace;
using System.Linq.Expressions;

namespace Metapsi
{
    public static class LocalControls
    {
        public static Var<IVNode> InDataContext<TModel, TData>(this LayoutBuilder b,
            Var<TModel> model,
            System.Linq.Expressions.Expression<Func<TModel, TData>> property,
            System.Func<LayoutBuilder, Var<DataContext<TModel, TData>>, Var<IVNode>> buildControl)
        {
            var outControl = b.Ref<IVNode>(b.T(""));

            b.OnModel(model, (b, context) =>
            {
                b.OnProperty(context, property, (b, context) =>
                {
                    b.SetRef(outControl, b.Call(buildControl, context));
                });
            });

            return b.GetRef(outControl);
        }


        public static System.Linq.Expressions.Expression<Func<TEntity, string>> StringPropertyExpression<TEntity>(string propertyName)
        {
            var x = Expression.Parameter(typeof(TEntity), "x");
            return Expression.Lambda<Func<TEntity, string>>(Expression.Property(x, propertyName), x);
        }

        public static System.Linq.Expressions.Expression<Func<TEntity, bool>> BoolPropertyExpression<TEntity>(string propertyName)
        {
            var x = Expression.Parameter(typeof(TEntity), "x");
            return Expression.Lambda<Func<TEntity, bool>>(Expression.Property(x, propertyName), x);
        }

        public static Var<IVNode> AutoEditForm<TPage, TEntity>(
            this LayoutBuilder b, 
            Var<DataContext<TPage, TEntity>> dataContext)
        {
            var editControls = b.NewCollection<IVNode>();

            var properties = typeof(TEntity).GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance);
            foreach (var property in properties)
            {
                if (property.PropertyType == typeof(bool))
                {
                    var checkbox = b.SlNode(
                        "sl-checkbox",
                        (b, props) =>
                        {
                            b.BindSlCheckedValue(props, dataContext, BoolPropertyExpression<TEntity>(property.Name));
                        },
                        b.T(b.FormatLabel(b.Const(property.Name))));
                    b.Push(editControls, checkbox);
                }

                if (property.PropertyType == typeof(string))
                {
                    var input = b.SlNode(
                        "sl-input",
                        (b, props) =>
                        {
                            b.SetDynamic(props, DynamicProperty.String("label"), b.FormatLabel(b.Const(property.Name)));
                            b.BindSlInputValue(props, dataContext, StringPropertyExpression<TEntity>(property.Name));
                        });
                    b.Push(editControls, input);
                }
            }

            return b.Div("flex flex-col gap-4", editControls);
        }
    }
}
