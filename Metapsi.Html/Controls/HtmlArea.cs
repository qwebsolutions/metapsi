using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Html;


public partial class HtmlArea
{
}

public static partial class HtmlAreaControl
{
    /// <summary>
    /// The HTML area tag
    /// </summary>
    public static Var<IVNode> HtmlArea(this LayoutBuilder b, Action<PropsBuilder<HtmlArea>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("area", buildProps, children);
    }
    /// <summary>
    /// The HTML area tag
    /// </summary>
    public static Var<IVNode> HtmlArea(this LayoutBuilder b, Action<PropsBuilder<HtmlArea>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("area", buildProps, children);
    }
}

