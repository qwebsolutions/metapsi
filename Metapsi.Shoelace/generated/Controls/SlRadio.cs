using Metapsi.Html;
using Metapsi.Syntax;
using Metapsi.Hyperapp;

namespace Metapsi.Shoelace;

/// <summary>
/// Radios allow the user to select a single option from a group.
/// </summary>
public partial class SlRadio
{
    /// <summary>
    /// 
    /// </summary>
    public static class Slot
    {
    }
    /// <summary>
    /// 
    /// </summary>
    public static class Method
    {
    }
}
/// <summary>
/// Setter extensions of SlRadio
/// </summary>
public static partial class SlRadioControl
{
    /// <summary>
    /// Radios allow the user to select a single option from a group.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlRadio(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlRadio>> buildAttributes, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-radio", buildAttributes, children);
    }

    /// <summary>
    /// Radios allow the user to select a single option from a group.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlRadio(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-radio", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// Radios allow the user to select a single option from a group.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlRadio(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlRadio>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-radio", buildAttributes, children);
    }

    /// <summary>
    /// Radios allow the user to select a single option from a group.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlRadio(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-radio", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// The radio's value. When selected, the radio group will receive this value.
    /// </summary>
    public static void SetValue(this Metapsi.Html.AttributesBuilder<SlRadio> b, string value) 
    {
        b.SetAttribute("value", value);
    }

    /// <summary>
    /// The radio's size. When used inside a radio group, the size will be determined by the radio group's size so this attribute can typically be omitted.
    /// </summary>
    public static void SetSizeSmall(this Metapsi.Html.AttributesBuilder<SlRadio> b) 
    {
        b.SetAttribute("size", "small");
    }

    /// <summary>
    /// The radio's size. When used inside a radio group, the size will be determined by the radio group's size so this attribute can typically be omitted.
    /// </summary>
    public static void SetSizeMedium(this Metapsi.Html.AttributesBuilder<SlRadio> b) 
    {
        b.SetAttribute("size", "medium");
    }

    /// <summary>
    /// The radio's size. When used inside a radio group, the size will be determined by the radio group's size so this attribute can typically be omitted.
    /// </summary>
    public static void SetSizeLarge(this Metapsi.Html.AttributesBuilder<SlRadio> b) 
    {
        b.SetAttribute("size", "large");
    }

    /// <summary>
    /// Disables the radio.
    /// </summary>
    public static void SetDisabled(this Metapsi.Html.AttributesBuilder<SlRadio> b, bool disabled) 
    {
        if (disabled) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// Disables the radio.
    /// </summary>
    public static void SetDisabled(this Metapsi.Html.AttributesBuilder<SlRadio> b) 
    {
        b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// Radios allow the user to select a single option from a group.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlRadio(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlRadio>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-radio", buildProps, children);
    }

    /// <summary>
    /// Radios allow the user to select a single option from a group.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlRadio(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-radio", children);
    }

    /// <summary>
    /// Radios allow the user to select a single option from a group.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlRadio(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlRadio>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-radio", buildProps, children);
    }

    /// <summary>
    /// Radios allow the user to select a single option from a group.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlRadio(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-radio", children);
    }

    /// <summary>
    /// The radio's value. When selected, the radio group will receive this value.
    /// </summary>
    public static void SetValue<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> value) where T: SlRadio
    {
        b.SetProperty(b.Props, b.Const("value"), value);
    }

    /// <summary>
    /// The radio's value. When selected, the radio group will receive this value.
    /// </summary>
    public static void SetValue<T>(this Metapsi.Syntax.PropsBuilder<T> b, string value) where T: SlRadio
    {
        b.SetValue(b.Const(value));
    }

    /// <summary>
    /// The radio's size. When used inside a radio group, the size will be determined by the radio group's size so this attribute can typically be omitted.
    /// </summary>
    public static void SetSizeSmall<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlRadio
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const("small"));
    }

    /// <summary>
    /// The radio's size. When used inside a radio group, the size will be determined by the radio group's size so this attribute can typically be omitted.
    /// </summary>
    public static void SetSizeMedium<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlRadio
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const("medium"));
    }

    /// <summary>
    /// The radio's size. When used inside a radio group, the size will be determined by the radio group's size so this attribute can typically be omitted.
    /// </summary>
    public static void SetSizeLarge<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlRadio
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const("large"));
    }

    /// <summary>
    /// Disables the radio.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlRadio
    {
        b.SetDisabled(b.Const(true));
    }

    /// <summary>
    /// Disables the radio.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> disabled) where T: SlRadio
    {
        b.SetProperty(b.Props, b.Const("disabled"), disabled);
    }

    /// <summary>
    /// Disables the radio.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool disabled) where T: SlRadio
    {
        b.SetDisabled(b.Const(disabled));
    }

    /// <summary>
    /// Emitted when the control loses focus.
    /// </summary>
    public static void OnSlBlur<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: SlRadio
    {
        b.OnSlEvent("onsl-blur", action);
    }

    /// <summary>
    /// Emitted when the control loses focus.
    /// </summary>
    public static void OnSlBlur<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: SlRadio
    {
        b.OnSlBlur(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the control loses focus.
    /// </summary>
    public static void OnSlBlur<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: SlRadio
    {
        b.OnSlEvent("onsl-blur", action);
    }

    /// <summary>
    /// Emitted when the control loses focus.
    /// </summary>
    public static void OnSlBlur<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: SlRadio
    {
        b.OnSlBlur(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the control gains focus.
    /// </summary>
    public static void OnSlFocus<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: SlRadio
    {
        b.OnSlEvent("onsl-focus", action);
    }

    /// <summary>
    /// Emitted when the control gains focus.
    /// </summary>
    public static void OnSlFocus<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: SlRadio
    {
        b.OnSlFocus(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the control gains focus.
    /// </summary>
    public static void OnSlFocus<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: SlRadio
    {
        b.OnSlEvent("onsl-focus", action);
    }

    /// <summary>
    /// Emitted when the control gains focus.
    /// </summary>
    public static void OnSlFocus<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: SlRadio
    {
        b.OnSlFocus(b.MakeAction(action));
    }

}