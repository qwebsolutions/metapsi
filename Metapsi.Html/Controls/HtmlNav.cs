using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Html;


public partial class HtmlNav
{
}

public static partial class HtmlNavControl
{
    /// <summary>
    /// The HTML nav tag
    /// </summary>
    public static Var<IVNode> HtmlNav(this LayoutBuilder b, Action<PropsBuilder<HtmlNav>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("nav", buildProps, children);
    }
    /// <summary>
    /// The HTML nav tag
    /// </summary>
    public static Var<IVNode> HtmlNav(this LayoutBuilder b, Action<PropsBuilder<HtmlNav>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("nav", buildProps, children);
    }
    /// <summary>
    /// The HTML nav tag
    /// </summary>
    public static Var<IVNode> HtmlNav(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("nav", children);
    }
    /// <summary>
    /// The HTML nav tag
    /// </summary>
    public static Var<IVNode> HtmlNav(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("nav", children);
    }
}

