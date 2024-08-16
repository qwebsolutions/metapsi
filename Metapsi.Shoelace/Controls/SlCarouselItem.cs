using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Shoelace;


public partial class SlCarouselItem : SlComponent
{
    public SlCarouselItem() : base("sl-carousel-item") { }
}

public static partial class SlCarouselItemControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlCarouselItem(this HtmlBuilder b, Action<AttributesBuilder<SlCarouselItem>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("sl-carousel-item", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlCarouselItem(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("sl-carousel-item", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlCarouselItem(this LayoutBuilder b, Action<PropsBuilder<SlCarouselItem>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("sl-carousel-item", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlCarouselItem(this LayoutBuilder b, Action<PropsBuilder<SlCarouselItem>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("sl-carousel-item", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlCarouselItem(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("sl-carousel-item", children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlCarouselItem(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("sl-carousel-item", children);
    }
}

