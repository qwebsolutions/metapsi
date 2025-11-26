using Metapsi.Syntax;
using System;

namespace Metapsi.Html;

/// <summary>
/// 
/// </summary>
public class HtmlInputBinding : IAutoRegisterBinding
{
    /// <summary>
    /// 
    /// </summary>
    public Type ControlType => typeof(HtmlInput);

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    /// <exception cref="System.Exception"></exception>
    public Binding GetBinding()
    {
        return Binding.New<HtmlInput>((b, value) =>
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
                    b.Set(x => x.@checked, value.As<bool>());
                },
                b =>
                {
                    // Radios are weird. You set the bool 'checked' if the string 'value' is equal to the radio's value
                    b.If(
                        b.AreEqual(controlType, b.Const("radio")),
                        b =>
                        {
                            var radioValue = b.Get(b.Props, x => x.value);
                            b.If(
                                b.AreEqual(radioValue, value.As<string>()),
                                b =>
                                {
                                    b.Set(x => x.@checked, value.As<bool>());
                                });
                        },
                        b =>
                        {
                            b.Set(x => x.value, value.As<string>());
                        });
                });
        },
            (b, e) =>
            {
                var target = b.Get(e, x => x.target).As<HTMLInputElement>();
                var outRef = b.Ref(b.Get(target, x => x.value));
                var controlType = b.StringToLowerCase(b.Get(target, x => x.type));
                b.If(
                    b.AreEqual(controlType, b.Const("checkbox")),
                    b =>
                    {
                        b.SetRef(outRef, b.Get(target, x => x.@checked).As<string>());
                    });

                b.If(
                    b.AreEqual(controlType, b.Const("radio")),
                    b =>
                    {
                        b.If(b.Get(target, x => x.@checked),
                            b =>
                            {
                                b.SetRef(outRef, b.Get(target, x => x.value));
                            });
                    });

                return b.GetRef(outRef).As<object>();
            },
            (b, action) =>
            {
                var controlType = b.If(b.HasValue(b.Get(b.Props, x => x.type)), b => b.StringToLowerCase(b.Get(b.Props, x => x.type)), b => b.Const(string.Empty));
                var isSet = b.If(
                    b.AreEqual(controlType, b.Const("checkbox")),
                    b =>
                    {
                        b.OnEventAction("click", action);
                        return b.Const(true);
                    },
                    b =>
                    {
                        return b.If(
                            b.AreEqual(controlType, b.Const("radio")),
                            b =>
                            {
                                b.OnEventAction("change", action);
                                return b.Const(true);
                            },
                            b =>
                            {
                                return b.Const(false);
                            });
                    });
                b.If(
                    b.Not(isSet),
                    b =>
                    {
                        b.OnEventAction("input", action);
                    });
            });
    }
}
