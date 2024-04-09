using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Html;


public partial class HtmlSamp
{
}

public static partial class HtmlSampControl
{
    /// <summary>
    /// The HTML samp tag
    /// </summary>
    public static Var<IVNode> HtmlSamp(this LayoutBuilder b, Action<PropsBuilder<HtmlSamp>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("samp", buildProps, children);
    }
    /// <summary>
    /// The HTML samp tag
    /// </summary>
    public static Var<IVNode> HtmlSamp(this LayoutBuilder b, Action<PropsBuilder<HtmlSamp>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("samp", buildProps, children);
    }
    /// <summary>
    /// The HTML samp tag
    /// </summary>
    public static Var<IVNode> HtmlSamp(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("samp", children);
    }
    /// <summary>
    /// The HTML samp tag
    /// </summary>
    public static Var<IVNode> HtmlSamp(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("samp", children);
    }
}

