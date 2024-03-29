using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Html;


public partial class HtmlLink
{
}

public static partial class HtmlLinkControl
{
    /// <summary>
    /// The HTML link tag
    /// </summary>
    public static Var<IVNode> HtmlLink(this LayoutBuilder b, Action<PropsBuilder<HtmlLink>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("link", buildProps, children);
    }
    /// <summary>
    /// The HTML link tag
    /// </summary>
    public static Var<IVNode> HtmlLink(this LayoutBuilder b, Action<PropsBuilder<HtmlLink>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("link", buildProps, children);
    }
}

