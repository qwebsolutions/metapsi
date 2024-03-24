using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Html;


public partial class HtmlFigcaption
{
}

public static partial class HtmlFigcaptionControl
{
    /// <summary>
    /// The HTML figcaption tag
    /// </summary>
    public static Var<IVNode> HtmlFigcaption(this LayoutBuilder b, Action<PropsBuilder<HtmlFigcaption>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("figcaption", buildProps, children);
    }
    /// <summary>
    /// The HTML figcaption tag
    /// </summary>
    public static Var<IVNode> HtmlFigcaption(this LayoutBuilder b, Action<PropsBuilder<HtmlFigcaption>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("figcaption", buildProps, children);
    }
}

