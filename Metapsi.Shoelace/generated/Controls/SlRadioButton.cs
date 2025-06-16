using Metapsi.Html;
using Metapsi.Syntax;
using Metapsi.Hyperapp;

namespace Metapsi.Shoelace;

/// <summary>
/// Radios buttons allow the user to select a single option from a group using a button-like control.
/// </summary>
public partial class SlRadioButton
{
    /// <summary>
    /// 
    /// </summary>
    public static class Slot
    {
        /// <summary>
        /// A presentational prefix icon or similar element.
        /// </summary>
        public const string Prefix = "prefix";
        /// <summary>
        /// A presentational suffix icon or similar element.
        /// </summary>
        public const string Suffix = "suffix";
    }
    /// <summary>
    /// 
    /// </summary>
    public static class Method
    {
        /// <summary>
        /// Sets focus on the radio button.
        /// </summary>
        public const string Focus = "focus";
        /// <summary>
        /// Removes focus from the radio button.
        /// </summary>
        public const string Blur = "blur";
    }
}
/// <summary>
/// Setter extensions of SlRadioButton
/// </summary>
public static partial class SlRadioButtonControl
{
    /// <summary>
    /// Radios buttons allow the user to select a single option from a group using a button-like control.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlRadioButton(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlRadioButton>> buildAttributes, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-radio-button", buildAttributes, children);
    }

    /// <summary>
    /// Radios buttons allow the user to select a single option from a group using a button-like control.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlRadioButton(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-radio-button", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// Radios buttons allow the user to select a single option from a group using a button-like control.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlRadioButton(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlRadioButton>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-radio-button", buildAttributes, children);
    }

    /// <summary>
    /// Radios buttons allow the user to select a single option from a group using a button-like control.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlRadioButton(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-radio-button", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// The radio's value. When selected, the radio group will receive this value.
    /// </summary>
    public static void SetValue(this Metapsi.Html.AttributesBuilder<SlRadioButton> b, string value) 
    {
        b.SetAttribute("value", value);
    }

    /// <summary>
    /// Disables the radio button.
    /// </summary>
    public static void SetDisabled(this Metapsi.Html.AttributesBuilder<SlRadioButton> b, bool disabled) 
    {
        if (disabled) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// Disables the radio button.
    /// </summary>
    public static void SetDisabled(this Metapsi.Html.AttributesBuilder<SlRadioButton> b) 
    {
        b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// The radio button's size. When used inside a radio group, the size will be determined by the radio group's size so this attribute can typically be omitted.
    /// </summary>
    public static void SetSizeSmall(this Metapsi.Html.AttributesBuilder<SlRadioButton> b) 
    {
        b.SetAttribute("size", "small");
    }

    /// <summary>
    /// The radio button's size. When used inside a radio group, the size will be determined by the radio group's size so this attribute can typically be omitted.
    /// </summary>
    public static void SetSizeMedium(this Metapsi.Html.AttributesBuilder<SlRadioButton> b) 
    {
        b.SetAttribute("size", "medium");
    }

    /// <summary>
    /// The radio button's size. When used inside a radio group, the size will be determined by the radio group's size so this attribute can typically be omitted.
    /// </summary>
    public static void SetSizeLarge(this Metapsi.Html.AttributesBuilder<SlRadioButton> b) 
    {
        b.SetAttribute("size", "large");
    }

    /// <summary>
    /// Draws a pill-style radio button with rounded edges.
    /// </summary>
    public static void SetPill(this Metapsi.Html.AttributesBuilder<SlRadioButton> b, bool pill) 
    {
        if (pill) b.SetAttribute("pill", "");
    }

    /// <summary>
    /// Draws a pill-style radio button with rounded edges.
    /// </summary>
    public static void SetPill(this Metapsi.Html.AttributesBuilder<SlRadioButton> b) 
    {
        b.SetAttribute("pill", "");
    }

    /// <summary>
    /// Radios buttons allow the user to select a single option from a group using a button-like control.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlRadioButton(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlRadioButton>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-radio-button", buildProps, children);
    }

    /// <summary>
    /// Radios buttons allow the user to select a single option from a group using a button-like control.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlRadioButton(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-radio-button", children);
    }

    /// <summary>
    /// Radios buttons allow the user to select a single option from a group using a button-like control.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlRadioButton(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlRadioButton>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-radio-button", buildProps, children);
    }

    /// <summary>
    /// Radios buttons allow the user to select a single option from a group using a button-like control.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlRadioButton(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-radio-button", children);
    }

    /// <summary>
    /// The radio's value. When selected, the radio group will receive this value.
    /// </summary>
    public static void SetValue<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> value) where T: SlRadioButton
    {
        b.SetProperty(b.Props, b.Const("value"), value);
    }

    /// <summary>
    /// The radio's value. When selected, the radio group will receive this value.
    /// </summary>
    public static void SetValue<T>(this Metapsi.Syntax.PropsBuilder<T> b, string value) where T: SlRadioButton
    {
        b.SetValue(b.Const(value));
    }

    /// <summary>
    /// Disables the radio button.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlRadioButton
    {
        b.SetDisabled(b.Const(true));
    }

    /// <summary>
    /// Disables the radio button.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> disabled) where T: SlRadioButton
    {
        b.SetProperty(b.Props, b.Const("disabled"), disabled);
    }

    /// <summary>
    /// Disables the radio button.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool disabled) where T: SlRadioButton
    {
        b.SetDisabled(b.Const(disabled));
    }

    /// <summary>
    /// The radio button's size. When used inside a radio group, the size will be determined by the radio group's size so this attribute can typically be omitted.
    /// </summary>
    public static void SetSizeSmall<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlRadioButton
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const("small"));
    }

    /// <summary>
    /// The radio button's size. When used inside a radio group, the size will be determined by the radio group's size so this attribute can typically be omitted.
    /// </summary>
    public static void SetSizeMedium<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlRadioButton
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const("medium"));
    }

    /// <summary>
    /// The radio button's size. When used inside a radio group, the size will be determined by the radio group's size so this attribute can typically be omitted.
    /// </summary>
    public static void SetSizeLarge<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlRadioButton
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const("large"));
    }

    /// <summary>
    /// Draws a pill-style radio button with rounded edges.
    /// </summary>
    public static void SetPill<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlRadioButton
    {
        b.SetPill(b.Const(true));
    }

    /// <summary>
    /// Draws a pill-style radio button with rounded edges.
    /// </summary>
    public static void SetPill<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> pill) where T: SlRadioButton
    {
        b.SetProperty(b.Props, b.Const("pill"), pill);
    }

    /// <summary>
    /// Draws a pill-style radio button with rounded edges.
    /// </summary>
    public static void SetPill<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool pill) where T: SlRadioButton
    {
        b.SetPill(b.Const(pill));
    }

    /// <summary>
    /// Emitted when the button loses focus.
    /// </summary>
    public static void OnSlBlur<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: SlRadioButton
    {
        b.OnSlEvent("onsl-blur", action);
    }

    /// <summary>
    /// Emitted when the button loses focus.
    /// </summary>
    public static void OnSlBlur<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: SlRadioButton
    {
        b.OnSlBlur(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the button loses focus.
    /// </summary>
    public static void OnSlBlur<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: SlRadioButton
    {
        b.OnSlEvent("onsl-blur", action);
    }

    /// <summary>
    /// Emitted when the button loses focus.
    /// </summary>
    public static void OnSlBlur<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: SlRadioButton
    {
        b.OnSlBlur(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the button gains focus.
    /// </summary>
    public static void OnSlFocus<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: SlRadioButton
    {
        b.OnSlEvent("onsl-focus", action);
    }

    /// <summary>
    /// Emitted when the button gains focus.
    /// </summary>
    public static void OnSlFocus<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: SlRadioButton
    {
        b.OnSlFocus(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the button gains focus.
    /// </summary>
    public static void OnSlFocus<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: SlRadioButton
    {
        b.OnSlEvent("onsl-focus", action);
    }

    /// <summary>
    /// Emitted when the button gains focus.
    /// </summary>
    public static void OnSlFocus<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: SlRadioButton
    {
        b.OnSlFocus(b.MakeAction(action));
    }

}