using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Html;


public partial class HtmlAbbr
{
}

public static partial class HtmlAbbrControl
{
    /// <summary>
    /// The HTML abbr tag
    /// </summary>
    public static Var<IVNode> HtmlAbbr(this LayoutBuilder b, Action<PropsBuilder<HtmlAbbr>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("abbr", buildProps, children);
    }
    /// <summary>
    /// The HTML abbr tag
    /// </summary>
    public static Var<IVNode> HtmlAbbr(this LayoutBuilder b, Action<PropsBuilder<HtmlAbbr>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("abbr", buildProps, children);
    }
}

