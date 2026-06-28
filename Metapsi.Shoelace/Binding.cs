using Metapsi.Html;
using Metapsi.Hyperapp;
using Metapsi.Syntax;

namespace Metapsi.Shoelace;

public static partial class SlCheckboxControl
{
    public static void BindTo<TEntity>(
        this PropsBuilder<SlCheckbox> b,
        Var<TEntity> entityRef,
        System.Linq.Expressions.Expression<System.Func<TEntity, bool>> onProperty)
    {
        var value = b.Get(entityRef, onProperty);
        b.SetChecked(value);
        b.OnSlChange(b.MakeAction((SyntaxBuilder b, Var<object> model, Var<Html.Event> e) =>
        {
            var @checked = b.GetTargetChecked(e);
            b.Set(entityRef, onProperty, value);
            return b.Clone(model);
        }));
    }
}

public static partial class SlInputControl
{
    public static void BindTo<TEntity>(
        this PropsBuilder<SlInput> b,
        Var<TEntity> entityRef,
        System.Linq.Expressions.Expression<System.Func<TEntity, string>> onProperty)
    {
        var value = b.Get(entityRef, onProperty);
        b.SetValue(value);
        b.OnSlInput(b.MakeAction((SyntaxBuilder b, Var<object> model, Var<Html.Event> e) =>
        {
            var value = b.GetTargetValue(e);
            b.Set(entityRef, onProperty, value);
            return b.Clone(model);
        }));
    }

    public static void BindTo<TEntity>(
        this PropsBuilder<SlInput> b,
        Var<TEntity> entityRef,
        System.Linq.Expressions.Expression<System.Func<TEntity, int>> onProperty)
    {
        var value = b.Get(entityRef, onProperty);
        b.SetValueAsNumber(value);
        b.OnSlInput(b.MakeAction((SyntaxBuilder b, Var<object> model, Var<Html.Event> e) =>
        {
            var target = b.Get(e, x => x.target).As<SlInput>();
            var value = b.GetProperty<int>(target, "valueAsNumber");
            b.Set(entityRef, onProperty, value);
            return b.Clone(model);
        }));
    }
}

public static partial class SlSelectControl
{
    public static void BindTo<TEntity>(
        this PropsBuilder<SlSelect> b,
        Var<TEntity> entityRef,
        System.Linq.Expressions.Expression<System.Func<TEntity, string>> onProperty)
    {
        var value = b.Get(entityRef, onProperty);
        b.SetValue(value);
        b.OnSlChange(b.MakeAction((SyntaxBuilder b, Var<object> model, Var<Html.Event> e) =>
        {
            var value = b.GetTargetValue(e);
            b.Set(entityRef, onProperty, value);
            return b.Clone(model);
        }));
    }
}

public static partial class SlTextareaControl
{
    public static void BindTo<TEntity>(
        this PropsBuilder<SlTextarea> b,
        Var<TEntity> entityRef,
        System.Linq.Expressions.Expression<System.Func<TEntity, string>> onProperty)
    {
        var value = b.Get(entityRef, onProperty);
        b.SetValue(value);
        b.OnSlInput(b.MakeAction((SyntaxBuilder b, Var<object> model, Var<Html.Event> e) =>
        {
            var value = b.GetTargetValue(e);
            b.Set(entityRef, onProperty, value);
            return b.Clone(model);
        }));
    }
}