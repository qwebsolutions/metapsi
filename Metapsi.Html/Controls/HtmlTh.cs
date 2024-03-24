using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Html;


public partial class HtmlTh
{
}

public static partial class HtmlThControl
{
    /// <summary>
    /// The HTML th tag
    /// </summary>
    public static Var<IVNode> HtmlTh(this LayoutBuilder b, Action<PropsBuilder<HtmlTh>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("th", buildProps, children);
    }
    /// <summary>
    /// The HTML th tag
    /// </summary>
    public static Var<IVNode> HtmlTh(this LayoutBuilder b, Action<PropsBuilder<HtmlTh>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("th", buildProps, children);
    }
}

