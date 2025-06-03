using Metapsi.Html;
using Metapsi.Syntax;
using Metapsi.Hyperapp;

namespace Metapsi.Shoelace;

/// <summary>
/// Options define the selectable items within various form controls such as [select](/components/select).
/// </summary>
public partial class SlOption
{
    /// <summary>
    /// 
    /// </summary>
    public static class Slot
    {
        /// <summary>
        /// Used to prepend an icon or similar element to the menu item.
        /// </summary>
        public const string Prefix = "prefix";
        /// <summary>
        /// Used to append an icon or similar element to the menu item.
        /// </summary>
        public const string Suffix = "suffix";
    }
    /// <summary>
    /// 
    /// </summary>
    public static class Method
    {
        /// <summary>
        /// Returns a plain text label based on the option's content.
        /// </summary>
        public const string GetTextLabel = "getTextLabel";
    }
}
/// <summary>
/// Setter extensions of SlOption
/// </summary>
public static partial class SlOptionControl
{
    /// <summary>
    /// Options define the selectable items within various form controls such as [select](/components/select).
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlOption(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlOption>> buildAttributes, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-option", buildAttributes, children);
    }

    /// <summary>
    /// Options define the selectable items within various form controls such as [select](/components/select).
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlOption(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-option", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// Options define the selectable items within various form controls such as [select](/components/select).
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlOption(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlOption>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-option", buildAttributes, children);
    }

    /// <summary>
    /// Options define the selectable items within various form controls such as [select](/components/select).
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlOption(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-option", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// The option's value. When selected, the containing form control will receive this value. The value must be unique from other options in the same group. Values may not contain spaces, as spaces are used as delimiters when listing multiple values.
    /// </summary>
    public static void SetValue(this Metapsi.Html.AttributesBuilder<SlOption> b, string value) 
    {
        b.SetAttribute("value", value);
    }

    /// <summary>
    /// Draws the option in a disabled state, preventing selection.
    /// </summary>
    public static void SetDisabled(this Metapsi.Html.AttributesBuilder<SlOption> b, bool disabled) 
    {
        if (disabled) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// Draws the option in a disabled state, preventing selection.
    /// </summary>
    public static void SetDisabled(this Metapsi.Html.AttributesBuilder<SlOption> b) 
    {
        b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// Options define the selectable items within various form controls such as [select](/components/select).
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlOption(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlOption>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-option", buildProps, children);
    }

    /// <summary>
    /// Options define the selectable items within various form controls such as [select](/components/select).
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlOption(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-option", children);
    }

    /// <summary>
    /// Options define the selectable items within various form controls such as [select](/components/select).
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlOption(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlOption>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-option", buildProps, children);
    }

    /// <summary>
    /// Options define the selectable items within various form controls such as [select](/components/select).
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlOption(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-option", children);
    }

    /// <summary>
    /// The option's value. When selected, the containing form control will receive this value. The value must be unique from other options in the same group. Values may not contain spaces, as spaces are used as delimiters when listing multiple values.
    /// </summary>
    public static void SetValue<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> value) where T: SlOption
    {
        b.SetProperty(b.Props, b.Const("value"), value);
    }

    /// <summary>
    /// The option's value. When selected, the containing form control will receive this value. The value must be unique from other options in the same group. Values may not contain spaces, as spaces are used as delimiters when listing multiple values.
    /// </summary>
    public static void SetValue<T>(this Metapsi.Syntax.PropsBuilder<T> b, string value) where T: SlOption
    {
        b.SetValue(b.Const(value));
    }

    /// <summary>
    /// Draws the option in a disabled state, preventing selection.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlOption
    {
        b.SetDisabled(b.Const(true));
    }

    /// <summary>
    /// Draws the option in a disabled state, preventing selection.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> disabled) where T: SlOption
    {
        b.SetProperty(b.Props, b.Const("disabled"), disabled);
    }

    /// <summary>
    /// Draws the option in a disabled state, preventing selection.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool disabled) where T: SlOption
    {
        b.SetDisabled(b.Const(disabled));
    }

}