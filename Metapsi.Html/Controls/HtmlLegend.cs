using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Html;


public partial class HtmlLegend
{
}

public static partial class HtmlLegendControl
{
    /// <summary>
    /// The HTML legend tag
    /// </summary>
    public static Var<IVNode> HtmlLegend(this LayoutBuilder b, Action<PropsBuilder<HtmlLegend>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("legend", buildProps, children);
    }
    /// <summary>
    /// The HTML legend tag
    /// </summary>
    public static Var<IVNode> HtmlLegend(this LayoutBuilder b, Action<PropsBuilder<HtmlLegend>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("legend", buildProps, children);
    }
}

