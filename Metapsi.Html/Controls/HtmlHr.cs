using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Html;


public partial class HtmlHr
{
}

public static partial class HtmlHrControl
{
    /// <summary>
    /// The HTML hr tag
    /// </summary>
    public static Var<IVNode> HtmlHr(this LayoutBuilder b, Action<PropsBuilder<HtmlHr>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("hr", buildProps, children);
    }
    /// <summary>
    /// The HTML hr tag
    /// </summary>
    public static Var<IVNode> HtmlHr(this LayoutBuilder b, Action<PropsBuilder<HtmlHr>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("hr", buildProps, children);
    }
    /// <summary>
    /// The HTML hr tag
    /// </summary>
    public static Var<IVNode> HtmlHr(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("hr", children);
    }
    /// <summary>
    /// The HTML hr tag
    /// </summary>
    public static Var<IVNode> HtmlHr(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("hr", children);
    }
}

