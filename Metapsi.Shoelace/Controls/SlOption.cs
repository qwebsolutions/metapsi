using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Shoelace;


public partial class SlOption
{
    /// <summary>
    ///
    /// </summary>
    public static class Slot
    {
        /// <summary>
        /// <para> Used to prepend an icon or similar element to the menu item. </para>
        /// </summary>
        public const string Prefix = "prefix";
        /// <summary>
        /// <para> Used to append an icon or similar element to the menu item. </para>
        /// </summary>
        public const string Suffix = "suffix";
    }
    public static class Method
    {
        /// <summary>
        /// <para> Returns a plain text label based on the option's content. </para>
        /// </summary>
        public const string GetTextLabel = "getTextLabel";
    }
}

public static partial class SlOptionControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlOption(this HtmlBuilder b, Action<AttributesBuilder<SlOption>> buildAttributes, params IHtmlNode[] children)
    {
        return b.SlTag("sl-option", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlOption(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.SlTag("sl-option", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlOption(this HtmlBuilder b, Action<AttributesBuilder<SlOption>> buildAttributes, List<IHtmlNode> children)
    {
        return b.SlTag("sl-option", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlOption(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.SlTag("sl-option", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The option's value. When selected, the containing form control will receive this value. The value must be unique from other options in the same group. Values may not contain spaces, as spaces are used as delimiters when listing multiple values. </para>
    /// </summary>
    public static void SetValue(this AttributesBuilder<SlOption> b, string value)
    {
        b.SetAttribute("value", value);
    }

    /// <summary>
    /// <para> Draws the option in a disabled state, preventing selection. </para>
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<SlOption> b)
    {
        b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// <para> Draws the option in a disabled state, preventing selection. </para>
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<SlOption> b, bool disabled)
    {
        if (disabled) b.SetAttribute("disabled", "");
    }

    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlOption(this LayoutBuilder b, Action<PropsBuilder<SlOption>> buildProps, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-option", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlOption(this LayoutBuilder b, Action<PropsBuilder<SlOption>> buildProps, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-option", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlOption(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-option", children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlOption(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-option", children);
    }
    /// <summary>
    /// <para> The option's value. When selected, the containing form control will receive this value. The value must be unique from other options in the same group. Values may not contain spaces, as spaces are used as delimiters when listing multiple values. </para>
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, Var<string> value) where T: SlOption
    {
        b.SetProperty(b.Props, b.Const("value"), value);
    }

    /// <summary>
    /// <para> The option's value. When selected, the containing form control will receive this value. The value must be unique from other options in the same group. Values may not contain spaces, as spaces are used as delimiters when listing multiple values. </para>
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, string value) where T: SlOption
    {
        b.SetProperty(b.Props, b.Const("value"), b.Const(value));
    }


    /// <summary>
    /// <para> Draws the option in a disabled state, preventing selection. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b) where T: SlOption
    {
        b.SetProperty(b.Props, b.Const("disabled"), b.Const(true));
    }


    /// <summary>
    /// <para> Draws the option in a disabled state, preventing selection. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, Var<bool> disabled) where T: SlOption
    {
        b.SetProperty(b.Props, b.Const("disabled"), disabled);
    }

    /// <summary>
    /// <para> Draws the option in a disabled state, preventing selection. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, bool disabled) where T: SlOption
    {
        b.SetProperty(b.Props, b.Const("disabled"), b.Const(disabled));
    }


}

