using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Html;


public partial class HtmlLabel
{
}

public static partial class HtmlLabelControl
{
    /// <summary>
    /// The HTML label tag
    /// </summary>
    public static Var<IVNode> HtmlLabel(this LayoutBuilder b, Action<PropsBuilder<HtmlLabel>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("label", buildProps, children);
    }
    /// <summary>
    /// The HTML label tag
    /// </summary>
    public static Var<IVNode> HtmlLabel(this LayoutBuilder b, Action<PropsBuilder<HtmlLabel>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("label", buildProps, children);
    }
}

