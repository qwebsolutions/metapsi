using Metapsi.Html;
using Metapsi.Syntax;
using Metapsi.Hyperapp;

namespace Metapsi.Shoelace;

/// <summary>
/// Cards can be used to group related subjects in a container.
/// </summary>
public partial class SlCard
{
    /// <summary>
    /// 
    /// </summary>
    public static class Slot
    {
        /// <summary>
        /// An optional header for the card.
        /// </summary>
        public const string Header = "header";
        /// <summary>
        /// An optional footer for the card.
        /// </summary>
        public const string Footer = "footer";
        /// <summary>
        /// An optional image to render at the start of the card.
        /// </summary>
        public const string Image = "image";
    }
    /// <summary>
    /// 
    /// </summary>
    public static class Method
    {
    }
}
/// <summary>
/// Setter extensions of SlCard
/// </summary>
public static partial class SlCardControl
{
    /// <summary>
    /// Cards can be used to group related subjects in a container.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlCard(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlCard>> buildAttributes, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-card", buildAttributes, children);
    }

    /// <summary>
    /// Cards can be used to group related subjects in a container.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlCard(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-card", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// Cards can be used to group related subjects in a container.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlCard(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlCard>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-card", buildAttributes, children);
    }

    /// <summary>
    /// Cards can be used to group related subjects in a container.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlCard(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-card", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// Cards can be used to group related subjects in a container.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlCard(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlCard>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-card", buildProps, children);
    }

    /// <summary>
    /// Cards can be used to group related subjects in a container.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlCard(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-card", children);
    }

    /// <summary>
    /// Cards can be used to group related subjects in a container.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlCard(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlCard>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-card", buildProps, children);
    }

    /// <summary>
    /// Cards can be used to group related subjects in a container.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlCard(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-card", children);
    }

}