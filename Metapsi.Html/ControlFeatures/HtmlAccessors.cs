using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using static Metapsi.Html.Binding;

namespace Metapsi.Html;

public partial class HtmlInput : IHasEditableValue
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

public partial class HtmlTextarea : IHasEditableValue
{
    public string value { get; set; }
}

public partial class HtmlSelect : IHasEditableValue
{
    public string value { get; set; }
}

/// <summary>
/// 
/// </summary>
public interface IAutoRegisterBinding : IAutoLoader
{
    /// <summary>
    /// 
    /// </summary>
    Type ControlType { get; }

    /// <summary>
    /// 
    /// </summary>
    Binding GetBinding();
}

/// <summary>
/// 
/// </summary>
public class AutoRegisterHtmlInputBinding : IAutoRegisterBinding
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
            var controlType = b.StringToLowerCase(b.Get(b.Props, x => x.type));
            b.If(
                b.AreEqual(controlType, b.Const("checkbox")),
                b =>
                {
                    b.Set(x => x.@checked, value.As<bool>());
                });

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
                });

            b.If(
                b.AreEqual(controlType, b.Const("file")),
                b =>
                {
                    b.Throw(b.Const("Input type='file' does not support bindings"));
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
                var controlType = b.StringToLowerCase(b.Get(b.Props, x => x.type));
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

public static class HtmlAccessors
{

}
