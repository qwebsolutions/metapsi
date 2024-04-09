using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Html;


public partial class HtmlSpan
{
}

public static partial class HtmlSpanControl
{
    /// <summary>
    /// The HTML span tag
    /// </summary>
    public static Var<IVNode> HtmlSpan(this LayoutBuilder b, Action<PropsBuilder<HtmlSpan>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("span", buildProps, children);
    }
    /// <summary>
    /// The HTML span tag
    /// </summary>
    public static Var<IVNode> HtmlSpan(this LayoutBuilder b, Action<PropsBuilder<HtmlSpan>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("span", buildProps, children);
    }
    /// <summary>
    /// The HTML span tag
    /// </summary>
    public static Var<IVNode> HtmlSpan(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("span", children);
    }
    /// <summary>
    /// The HTML span tag
    /// </summary>
    public static Var<IVNode> HtmlSpan(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("span", children);
    }
}

