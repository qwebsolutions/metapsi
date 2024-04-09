using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Html;


public partial class HtmlProgress
{
}

public static partial class HtmlProgressControl
{
    /// <summary>
    /// The HTML progress tag
    /// </summary>
    public static Var<IVNode> HtmlProgress(this LayoutBuilder b, Action<PropsBuilder<HtmlProgress>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("progress", buildProps, children);
    }
    /// <summary>
    /// The HTML progress tag
    /// </summary>
    public static Var<IVNode> HtmlProgress(this LayoutBuilder b, Action<PropsBuilder<HtmlProgress>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("progress", buildProps, children);
    }
    /// <summary>
    /// The HTML progress tag
    /// </summary>
    public static Var<IVNode> HtmlProgress(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("progress", children);
    }
    /// <summary>
    /// The HTML progress tag
    /// </summary>
    public static Var<IVNode> HtmlProgress(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("progress", children);
    }
}

