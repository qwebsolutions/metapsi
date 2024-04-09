using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Html;


public partial class HtmlH4
{
}

public static partial class HtmlH4Control
{
    /// <summary>
    /// The HTML h4 tag
    /// </summary>
    public static Var<IVNode> HtmlH4(this LayoutBuilder b, Action<PropsBuilder<HtmlH4>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("h4", buildProps, children);
    }
    /// <summary>
    /// The HTML h4 tag
    /// </summary>
    public static Var<IVNode> HtmlH4(this LayoutBuilder b, Action<PropsBuilder<HtmlH4>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("h4", buildProps, children);
    }
    /// <summary>
    /// The HTML h4 tag
    /// </summary>
    public static Var<IVNode> HtmlH4(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("h4", children);
    }
    /// <summary>
    /// The HTML h4 tag
    /// </summary>
    public static Var<IVNode> HtmlH4(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("h4", children);
    }
}

