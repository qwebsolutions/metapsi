using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Html;


public partial class HtmlLi
{
}

public static partial class HtmlLiControl
{
    /// <summary>
    /// The HTML li tag
    /// </summary>
    public static Var<IVNode> HtmlLi(this LayoutBuilder b, Action<PropsBuilder<HtmlLi>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("li", buildProps, children);
    }
    /// <summary>
    /// The HTML li tag
    /// </summary>
    public static Var<IVNode> HtmlLi(this LayoutBuilder b, Action<PropsBuilder<HtmlLi>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("li", buildProps, children);
    }
    /// <summary>
    /// The HTML li tag
    /// </summary>
    public static Var<IVNode> HtmlLi(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("li", children);
    }
    /// <summary>
    /// The HTML li tag
    /// </summary>
    public static Var<IVNode> HtmlLi(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("li", children);
    }
}

