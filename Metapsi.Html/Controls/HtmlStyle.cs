using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Html;


public partial class HtmlStyle
{
}

public static partial class HtmlStyleControl
{
    /// <summary>
    /// The HTML style tag
    /// </summary>
    public static Var<IVNode> HtmlStyle(this LayoutBuilder b, Action<PropsBuilder<HtmlStyle>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("style", buildProps, children);
    }
    /// <summary>
    /// The HTML style tag
    /// </summary>
    public static Var<IVNode> HtmlStyle(this LayoutBuilder b, Action<PropsBuilder<HtmlStyle>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("style", buildProps, children);
    }
    /// <summary>
    /// The HTML style tag
    /// </summary>
    public static Var<IVNode> HtmlStyle(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("style", children);
    }
    /// <summary>
    /// The HTML style tag
    /// </summary>
    public static Var<IVNode> HtmlStyle(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("style", children);
    }
}

