using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Html;


public partial class HtmlSummary
{
}

public static partial class HtmlSummaryControl
{
    /// <summary>
    /// The HTML summary tag
    /// </summary>
    public static Var<IVNode> HtmlSummary(this LayoutBuilder b, Action<PropsBuilder<HtmlSummary>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("summary", buildProps, children);
    }
    /// <summary>
    /// The HTML summary tag
    /// </summary>
    public static Var<IVNode> HtmlSummary(this LayoutBuilder b, Action<PropsBuilder<HtmlSummary>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("summary", buildProps, children);
    }
}

