using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Html;


public partial class HtmlH1
{
}

public static partial class HtmlH1Control
{
    /// <summary>
    /// The HTML h1 tag
    /// </summary>
    public static Var<IVNode> HtmlH1(this LayoutBuilder b, Action<PropsBuilder<HtmlH1>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("h1", buildProps, children);
    }
    /// <summary>
    /// The HTML h1 tag
    /// </summary>
    public static Var<IVNode> HtmlH1(this LayoutBuilder b, Action<PropsBuilder<HtmlH1>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("h1", buildProps, children);
    }
}

