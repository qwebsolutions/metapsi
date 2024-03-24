using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Html;


public partial class HtmlS
{
}

public static partial class HtmlSControl
{
    /// <summary>
    /// The HTML s tag
    /// </summary>
    public static Var<IVNode> HtmlS(this LayoutBuilder b, Action<PropsBuilder<HtmlS>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("s", buildProps, children);
    }
    /// <summary>
    /// The HTML s tag
    /// </summary>
    public static Var<IVNode> HtmlS(this LayoutBuilder b, Action<PropsBuilder<HtmlS>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("s", buildProps, children);
    }
}

