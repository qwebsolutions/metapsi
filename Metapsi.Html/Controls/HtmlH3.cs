using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Html;


public partial class HtmlH3
{
}

public static partial class HtmlH3Control
{
    /// <summary>
    /// The HTML h3 tag
    /// </summary>
    public static Var<IVNode> HtmlH3(this LayoutBuilder b, Action<PropsBuilder<HtmlH3>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("h3", buildProps, children);
    }
    /// <summary>
    /// The HTML h3 tag
    /// </summary>
    public static Var<IVNode> HtmlH3(this LayoutBuilder b, Action<PropsBuilder<HtmlH3>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("h3", buildProps, children);
    }
}

