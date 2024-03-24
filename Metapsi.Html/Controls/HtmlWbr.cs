using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Html;


public partial class HtmlWbr
{
}

public static partial class HtmlWbrControl
{
    /// <summary>
    /// The HTML wbr tag
    /// </summary>
    public static Var<IVNode> HtmlWbr(this LayoutBuilder b, Action<PropsBuilder<HtmlWbr>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("wbr", buildProps, children);
    }
    /// <summary>
    /// The HTML wbr tag
    /// </summary>
    public static Var<IVNode> HtmlWbr(this LayoutBuilder b, Action<PropsBuilder<HtmlWbr>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("wbr", buildProps, children);
    }
}

