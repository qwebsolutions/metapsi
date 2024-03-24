using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Html;


public partial class HtmlDetails
{
}

public static partial class HtmlDetailsControl
{
    /// <summary>
    /// The HTML details tag
    /// </summary>
    public static Var<IVNode> HtmlDetails(this LayoutBuilder b, Action<PropsBuilder<HtmlDetails>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("details", buildProps, children);
    }
    /// <summary>
    /// The HTML details tag
    /// </summary>
    public static Var<IVNode> HtmlDetails(this LayoutBuilder b, Action<PropsBuilder<HtmlDetails>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("details", buildProps, children);
    }
}

