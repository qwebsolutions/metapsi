using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Html;


public partial class HtmlTd
{
}

public static partial class HtmlTdControl
{
    /// <summary>
    /// The HTML td tag
    /// </summary>
    public static Var<IVNode> HtmlTd(this LayoutBuilder b, Action<PropsBuilder<HtmlTd>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("td", buildProps, children);
    }
    /// <summary>
    /// The HTML td tag
    /// </summary>
    public static Var<IVNode> HtmlTd(this LayoutBuilder b, Action<PropsBuilder<HtmlTd>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("td", buildProps, children);
    }
}

