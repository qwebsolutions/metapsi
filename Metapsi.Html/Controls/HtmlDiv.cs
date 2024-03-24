using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Html;


public partial class HtmlDiv
{
}

public static partial class HtmlDivControl
{
    /// <summary>
    /// The HTML div tag
    /// </summary>
    public static Var<IVNode> HtmlDiv(this LayoutBuilder b, Action<PropsBuilder<HtmlDiv>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("div", buildProps, children);
    }
    /// <summary>
    /// The HTML div tag
    /// </summary>
    public static Var<IVNode> HtmlDiv(this LayoutBuilder b, Action<PropsBuilder<HtmlDiv>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("div", buildProps, children);
    }
}

