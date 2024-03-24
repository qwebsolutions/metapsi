using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Html;


public partial class HtmlH5
{
}

public static partial class HtmlH5Control
{
    /// <summary>
    /// The HTML h5 tag
    /// </summary>
    public static Var<IVNode> HtmlH5(this LayoutBuilder b, Action<PropsBuilder<HtmlH5>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("h5", buildProps, children);
    }
    /// <summary>
    /// The HTML h5 tag
    /// </summary>
    public static Var<IVNode> HtmlH5(this LayoutBuilder b, Action<PropsBuilder<HtmlH5>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("h5", buildProps, children);
    }
}

