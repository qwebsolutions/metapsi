using Metapsi.Html;
using Metapsi.Syntax;
using Metapsi.Hyperapp;

namespace Metapsi.Shoelace;

/// <summary>
/// Dividers are used to visually separate or group elements.
/// </summary>
public partial class SlDivider
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
/// Setter extensions of SlDivider
/// </summary>
public static partial class SlDividerControl
{
    /// <summary>
    /// Dividers are used to visually separate or group elements.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlDivider(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlDivider>> buildAttributes, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-divider", buildAttributes, children);
    }

    /// <summary>
    /// Dividers are used to visually separate or group elements.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlDivider(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-divider", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// Dividers are used to visually separate or group elements.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlDivider(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlDivider>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-divider", buildAttributes, children);
    }

    /// <summary>
    /// Dividers are used to visually separate or group elements.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlDivider(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-divider", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// Draws the divider in a vertical orientation.
    /// </summary>
    public static void SetVertical(this Metapsi.Html.AttributesBuilder<SlDivider> b, bool vertical) 
    {
        if (vertical) b.SetAttribute("vertical", "");
    }

    /// <summary>
    /// Draws the divider in a vertical orientation.
    /// </summary>
    public static void SetVertical(this Metapsi.Html.AttributesBuilder<SlDivider> b) 
    {
        b.SetAttribute("vertical", "");
    }

    /// <summary>
    /// Dividers are used to visually separate or group elements.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlDivider(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlDivider>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-divider", buildProps, children);
    }

    /// <summary>
    /// Dividers are used to visually separate or group elements.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlDivider(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-divider", children);
    }

    /// <summary>
    /// Dividers are used to visually separate or group elements.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlDivider(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlDivider>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-divider", buildProps, children);
    }

    /// <summary>
    /// Dividers are used to visually separate or group elements.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlDivider(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-divider", children);
    }

    /// <summary>
    /// Draws the divider in a vertical orientation.
    /// </summary>
    public static void SetVertical<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlDivider
    {
        b.SetVertical(b.Const(true));
    }

    /// <summary>
    /// Draws the divider in a vertical orientation.
    /// </summary>
    public static void SetVertical<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> vertical) where T: SlDivider
    {
        b.SetProperty(b.Props, b.Const("vertical"), vertical);
    }

    /// <summary>
    /// Draws the divider in a vertical orientation.
    /// </summary>
    public static void SetVertical<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool vertical) where T: SlDivider
    {
        b.SetVertical(b.Const(vertical));
    }

}