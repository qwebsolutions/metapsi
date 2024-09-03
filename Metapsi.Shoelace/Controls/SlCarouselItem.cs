using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Shoelace;


public partial class SlCarouselItem
{
}

public static partial class SlCarouselItemControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlCarouselItem(this HtmlBuilder b, Action<AttributesBuilder<SlCarouselItem>> buildAttributes, params IHtmlNode[] children)
    {
        return b.SlTag("sl-carousel-item", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlCarouselItem(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.SlTag("sl-carousel-item", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlCarouselItem(this HtmlBuilder b, Action<AttributesBuilder<SlCarouselItem>> buildAttributes, List<IHtmlNode> children)
    {
        return b.SlTag("sl-carousel-item", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlCarouselItem(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.SlTag("sl-carousel-item", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlCarouselItem(this LayoutBuilder b, Action<PropsBuilder<SlCarouselItem>> buildProps, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-carousel-item", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlCarouselItem(this LayoutBuilder b, Action<PropsBuilder<SlCarouselItem>> buildProps, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-carousel-item", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlCarouselItem(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-carousel-item", children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlCarouselItem(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-carousel-item", children);
    }
}

