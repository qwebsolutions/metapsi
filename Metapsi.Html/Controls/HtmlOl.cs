using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Html;


public partial class HtmlOl
{
}

public static partial class HtmlOlControl
{
    /// <summary>
    /// The HTML ol tag
    /// </summary>
    public static Var<IVNode> HtmlOl(this LayoutBuilder b, Action<PropsBuilder<HtmlOl>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("ol", buildProps, children);
    }
    /// <summary>
    /// The HTML ol tag
    /// </summary>
    public static Var<IVNode> HtmlOl(this LayoutBuilder b, Action<PropsBuilder<HtmlOl>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("ol", buildProps, children);
    }
    /// <summary>
    /// The HTML ol tag
    /// </summary>
    public static Var<IVNode> HtmlOl(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("ol", children);
    }
    /// <summary>
    /// The HTML ol tag
    /// </summary>
    public static Var<IVNode> HtmlOl(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("ol", children);
    }
}

