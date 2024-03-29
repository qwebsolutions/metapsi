using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Html;


public partial class HtmlSmall
{
}

public static partial class HtmlSmallControl
{
    /// <summary>
    /// The HTML small tag
    /// </summary>
    public static Var<IVNode> HtmlSmall(this LayoutBuilder b, Action<PropsBuilder<HtmlSmall>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("small", buildProps, children);
    }
    /// <summary>
    /// The HTML small tag
    /// </summary>
    public static Var<IVNode> HtmlSmall(this LayoutBuilder b, Action<PropsBuilder<HtmlSmall>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("small", buildProps, children);
    }
}

