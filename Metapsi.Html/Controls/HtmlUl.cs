using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Html;


public partial class HtmlUl
{
}

public static partial class HtmlUlControl
{
    /// <summary>
    /// The HTML ul tag
    /// </summary>
    public static Var<IVNode> HtmlUl(this LayoutBuilder b, Action<PropsBuilder<HtmlUl>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("ul", buildProps, children);
    }
    /// <summary>
    /// The HTML ul tag
    /// </summary>
    public static Var<IVNode> HtmlUl(this LayoutBuilder b, Action<PropsBuilder<HtmlUl>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("ul", buildProps, children);
    }
    /// <summary>
    /// The HTML ul tag
    /// </summary>
    public static Var<IVNode> HtmlUl(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("ul", children);
    }
    /// <summary>
    /// The HTML ul tag
    /// </summary>
    public static Var<IVNode> HtmlUl(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("ul", children);
    }
}

