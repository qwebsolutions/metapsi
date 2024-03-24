using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Html;


public partial class HtmlFooter
{
}

public static partial class HtmlFooterControl
{
    /// <summary>
    /// The HTML footer tag
    /// </summary>
    public static Var<IVNode> HtmlFooter(this LayoutBuilder b, Action<PropsBuilder<HtmlFooter>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("footer", buildProps, children);
    }
    /// <summary>
    /// The HTML footer tag
    /// </summary>
    public static Var<IVNode> HtmlFooter(this LayoutBuilder b, Action<PropsBuilder<HtmlFooter>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("footer", buildProps, children);
    }
}

