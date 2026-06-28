using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;

namespace Metapsi.Html;


public partial class HtmlInput
{
    /// <summary>
    /// 
    /// </summary>
    public string type { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public string value { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public bool @checked { get; set; }
}

public static partial class HtmlInputControl
{
    public static void SetChecked(this PropsBuilder<HtmlInput> b, Var<bool> @checked)
    {
        b.Set(x => x.@checked, @checked);
    }

    public static void BindTo<TEntity>(
        this PropsBuilder<HtmlInput> b,
        Var<TEntity> entityRef,
        System.Linq.Expressions.Expression<System.Func<TEntity, string>> onProperty)
    {
        var controlType = b.If(b.HasValue(b.Get(b.Props, x => x.type)), b => b.StringToLowerCase(b.Get(b.Props, x => x.type)), b => b.Const(string.Empty));

        b.If(
            b.AreEqual(controlType, b.Const("file")),
            b =>
            {
                b.Throw(b.Const("Input type='file' does not support bindings"));
            });

        b.If(
            b.AreEqual(controlType, b.Const("checkbox")),
            b =>
            {
                b.Throw(b.Const("Input type='checkbox' should be used with boolean binding"));
            });

        b.If(
            b.AreEqual(controlType, b.Const("radio")),
            b =>
            {
                // Radios work in a weird way. There are multiple inputs, grouped by 'name' attribute
                // The 'checked' input is the one whose 'value' property matches the model value
                var value = b.Get(entityRef, onProperty);
                var radioValue = b.Get(b.Props, x => x.value);
                b.SetChecked(b.AreEqual(radioValue, value));

                b.OnEventAction("change", b.MakeAction((SyntaxBuilder b, Var<object> model, Var<Event> e) =>
                {
                    var value = b.GetTargetValue(e);
                    b.Set(entityRef, onProperty, value);
                    return b.Clone(model);
                }));
            },
            b =>
            {
                // 'Normal' string value input
                var value = b.Get(entityRef, onProperty);
                b.SetValue(value);
                b.OnInputAction((SyntaxBuilder b, Var<object> model, Var<Html.Event> e) =>
                {
                    var value = b.GetTargetValue(e);
                    b.Set(entityRef, onProperty, value);
                    return b.Clone(model);
                });
            });
    }

    public static void BindTo<TEntity>(
        this PropsBuilder<HtmlInput> b,
        Var<TEntity> entityRef,
        System.Linq.Expressions.Expression<System.Func<TEntity, bool>> onProperty)
    {
        var controlType = b.If(b.HasValue(b.Get(b.Props, x => x.type)), b => b.StringToLowerCase(b.Get(b.Props, x => x.type)), b => b.Const(string.Empty));

        b.If(
            b.AreEqual(controlType, b.Const("file")),
            b =>
            {
                b.Throw(b.Const("Input type='file' does not support bindings"));
            });

        b.If(
            b.AreEqual(controlType, b.Const("radio")),
            b =>
            {
                b.Throw(b.Const("Input type='radio' should be used with string value binding"));
            });

        b.If(
            b.AreEqual(controlType, b.Const("checkbox")),
            b =>
            {
                var value = b.Get(entityRef, onProperty);
                b.SetChecked(value);
                b.OnInputAction((SyntaxBuilder b, Var<object> model, Var<Html.Event> e) =>
                {
                    var value = b.GetTargetChecked(e);
                    b.Set(entityRef, onProperty, value);
                    return b.Clone(model);
                });
            });
    }
}