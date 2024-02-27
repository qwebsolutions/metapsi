using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using System.ComponentModel;

namespace Metapsi.Shoelace;


public partial interface IClientSideSlCarouselItem
{
}
public static partial class SlCarouselItemControl
{
    /// <summary>
    /// A carousel item represent a slide within a [carousel](/components/carousel).
    /// </summary>
    public static Var<IVNode> SlCarouselItem(this LayoutBuilder b, Action<PropsBuilder<SlCarouselItem>> buildProps, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-carousel-item", buildProps, children);
    }
    /// <summary>
    /// A carousel item represent a slide within a [carousel](/components/carousel).
    /// </summary>
    public static Var<IVNode> SlCarouselItem(this LayoutBuilder b, Action<PropsBuilder<SlCarouselItem>> buildProps, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-carousel-item", buildProps, children);
    }
}

/// <summary>
/// A carousel item represent a slide within a [carousel](/components/carousel).
/// </summary>
public partial class SlCarouselItem : HtmlTag
{
    public SlCarouselItem()
    {
        this.Tag = "sl-carousel-item";
    }

    public static SlCarouselItem New()
    {
        return new SlCarouselItem();
    }
}

public static partial class SlCarouselItemControl
{
}

