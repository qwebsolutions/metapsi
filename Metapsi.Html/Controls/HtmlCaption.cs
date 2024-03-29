using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Html;


public partial class HtmlCaption
{
}

public static partial class HtmlCaptionControl
{
    /// <summary>
    /// The HTML caption tag
    /// </summary>
    public static Var<IVNode> HtmlCaption(this LayoutBuilder b, Action<PropsBuilder<HtmlCaption>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("caption", buildProps, children);
    }
    /// <summary>
    /// The HTML caption tag
    /// </summary>
    public static Var<IVNode> HtmlCaption(this LayoutBuilder b, Action<PropsBuilder<HtmlCaption>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("caption", buildProps, children);
    }
}

