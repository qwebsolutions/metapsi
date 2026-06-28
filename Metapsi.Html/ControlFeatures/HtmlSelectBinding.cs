using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;

namespace Metapsi.Html;

public partial class HtmlSelect
{
    public string value { get; set; }
}

public static partial class HtmlSelectControl
{
    public static void BindTo<TEntity>(
        this PropsBuilder<HtmlSelect> b,
        Var<TEntity> entityRef,
        System.Linq.Expressions.Expression<System.Func<TEntity, string>> onProperty)
    {
        var value = b.Get(entityRef, onProperty);
        b.SetValue(value);
        b.OnEventAction("change", b.MakeAction((SyntaxBuilder b, Var<object> model, Var<Html.Event> e) =>
        {
            var value = b.GetTargetValue(e);
            b.Set(entityRef, onProperty, value);
            return b.Clone(model);
        }));
    }
}