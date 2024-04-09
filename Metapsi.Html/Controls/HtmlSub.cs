using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Html;


public partial class HtmlSub
{
}

public static partial class HtmlSubControl
{
    /// <summary>
    /// The HTML sub tag
    /// </summary>
    public static Var<IVNode> HtmlSub(this LayoutBuilder b, Action<PropsBuilder<HtmlSub>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("sub", buildProps, children);
    }
    /// <summary>
    /// The HTML sub tag
    /// </summary>
    public static Var<IVNode> HtmlSub(this LayoutBuilder b, Action<PropsBuilder<HtmlSub>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("sub", buildProps, children);
    }
    /// <summary>
    /// The HTML sub tag
    /// </summary>
    public static Var<IVNode> HtmlSub(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("sub", children);
    }
    /// <summary>
    /// The HTML sub tag
    /// </summary>
    public static Var<IVNode> HtmlSub(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("sub", children);
    }
}

