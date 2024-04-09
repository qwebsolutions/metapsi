using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Html;


public partial class HtmlTr
{
}

public static partial class HtmlTrControl
{
    /// <summary>
    /// The HTML tr tag
    /// </summary>
    public static Var<IVNode> HtmlTr(this LayoutBuilder b, Action<PropsBuilder<HtmlTr>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("tr", buildProps, children);
    }
    /// <summary>
    /// The HTML tr tag
    /// </summary>
    public static Var<IVNode> HtmlTr(this LayoutBuilder b, Action<PropsBuilder<HtmlTr>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("tr", buildProps, children);
    }
    /// <summary>
    /// The HTML tr tag
    /// </summary>
    public static Var<IVNode> HtmlTr(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("tr", children);
    }
    /// <summary>
    /// The HTML tr tag
    /// </summary>
    public static Var<IVNode> HtmlTr(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("tr", children);
    }
}

