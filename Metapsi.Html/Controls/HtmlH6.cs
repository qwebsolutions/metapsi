using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Html;


public partial class HtmlH6
{
}

public static partial class HtmlH6Control
{
    /// <summary>
    /// The HTML h6 tag
    /// </summary>
    public static Var<IVNode> HtmlH6(this LayoutBuilder b, Action<PropsBuilder<HtmlH6>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("h6", buildProps, children);
    }
    /// <summary>
    /// The HTML h6 tag
    /// </summary>
    public static Var<IVNode> HtmlH6(this LayoutBuilder b, Action<PropsBuilder<HtmlH6>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("h6", buildProps, children);
    }
}

