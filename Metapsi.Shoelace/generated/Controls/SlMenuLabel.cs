using Metapsi.Html;
using Metapsi.Syntax;
using Metapsi.Hyperapp;

namespace Metapsi.Shoelace;

/// <summary>
/// Menu labels are used to describe a group of menu items.
/// </summary>
public partial class SlMenuLabel
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
/// Setter extensions of SlMenuLabel
/// </summary>
public static partial class SlMenuLabelControl
{
    /// <summary>
    /// Menu labels are used to describe a group of menu items.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlMenuLabel(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlMenuLabel>> buildAttributes, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-menu-label", buildAttributes, children);
    }

    /// <summary>
    /// Menu labels are used to describe a group of menu items.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlMenuLabel(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-menu-label", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// Menu labels are used to describe a group of menu items.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlMenuLabel(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlMenuLabel>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-menu-label", buildAttributes, children);
    }

    /// <summary>
    /// Menu labels are used to describe a group of menu items.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlMenuLabel(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-menu-label", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// Menu labels are used to describe a group of menu items.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlMenuLabel(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlMenuLabel>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-menu-label", buildProps, children);
    }

    /// <summary>
    /// Menu labels are used to describe a group of menu items.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlMenuLabel(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-menu-label", children);
    }

    /// <summary>
    /// Menu labels are used to describe a group of menu items.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlMenuLabel(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlMenuLabel>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-menu-label", buildProps, children);
    }

    /// <summary>
    /// Menu labels are used to describe a group of menu items.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlMenuLabel(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-menu-label", children);
    }

}