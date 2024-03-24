using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Html;


public partial class HtmlThead
{
}

public static partial class HtmlTheadControl
{
    /// <summary>
    /// The HTML thead tag
    /// </summary>
    public static Var<IVNode> HtmlThead(this LayoutBuilder b, Action<PropsBuilder<HtmlThead>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("thead", buildProps, children);
    }
    /// <summary>
    /// The HTML thead tag
    /// </summary>
    public static Var<IVNode> HtmlThead(this LayoutBuilder b, Action<PropsBuilder<HtmlThead>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("thead", buildProps, children);
    }
}

