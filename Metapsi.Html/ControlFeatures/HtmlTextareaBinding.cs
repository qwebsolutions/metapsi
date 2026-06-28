using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;

namespace Metapsi.Html;

public partial class HtmlTextarea
{
    public string value { get; set; }
}

public static partial class HtmlTextareaControl
{
    public static void BindTo<TEntity>(
        this PropsBuilder<HtmlTextarea> b,
        Var<TEntity> entityRef,
        System.Linq.Expressions.Expression<System.Func<TEntity, string>> onProperty)
    {
        var value = b.Get(entityRef, onProperty);
        b.SetValue(value);
        b.OnEventAction("input", b.MakeAction((SyntaxBuilder b, Var<object> model, Var<Html.Event> e) =>
        {
            var value = b.GetTargetValue(e);
            b.Set(entityRef, onProperty, value);
            return b.Clone(model);
        }));
    }
}