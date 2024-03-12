using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Shoelace;


public partial class SlCarouselItem
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

