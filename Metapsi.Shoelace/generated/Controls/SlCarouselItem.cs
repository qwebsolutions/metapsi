using Metapsi.Html;
using Metapsi.Syntax;
using Metapsi.Hyperapp;

namespace Metapsi.Shoelace;

/// <summary>
/// A carousel item represent a slide within a [carousel](/components/carousel).
/// </summary>
public partial class SlCarouselItem
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
/// Setter extensions of SlCarouselItem
/// </summary>
public static partial class SlCarouselItemControl
{
    /// <summary>
    /// A carousel item represent a slide within a [carousel](/components/carousel).
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlCarouselItem(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlCarouselItem>> buildAttributes, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-carousel-item", buildAttributes, children);
    }

    /// <summary>
    /// A carousel item represent a slide within a [carousel](/components/carousel).
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlCarouselItem(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-carousel-item", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// A carousel item represent a slide within a [carousel](/components/carousel).
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlCarouselItem(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlCarouselItem>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-carousel-item", buildAttributes, children);
    }

    /// <summary>
    /// A carousel item represent a slide within a [carousel](/components/carousel).
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlCarouselItem(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-carousel-item", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// A carousel item represent a slide within a [carousel](/components/carousel).
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlCarouselItem(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlCarouselItem>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-carousel-item", buildProps, children);
    }

    /// <summary>
    /// A carousel item represent a slide within a [carousel](/components/carousel).
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlCarouselItem(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-carousel-item", children);
    }

    /// <summary>
    /// A carousel item represent a slide within a [carousel](/components/carousel).
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlCarouselItem(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlCarouselItem>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-carousel-item", buildProps, children);
    }

    /// <summary>
    /// A carousel item represent a slide within a [carousel](/components/carousel).
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlCarouselItem(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-carousel-item", children);
    }

}