using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Html;


public partial class HtmlTfoot
{
}

public static partial class HtmlTfootControl
{
    /// <summary>
    /// The HTML tfoot tag
    /// </summary>
    public static Var<IVNode> HtmlTfoot(this LayoutBuilder b, Action<PropsBuilder<HtmlTfoot>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("tfoot", buildProps, children);
    }
    /// <summary>
    /// The HTML tfoot tag
    /// </summary>
    public static Var<IVNode> HtmlTfoot(this LayoutBuilder b, Action<PropsBuilder<HtmlTfoot>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("tfoot", buildProps, children);
    }
}

