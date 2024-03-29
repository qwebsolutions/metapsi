using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Html;


public partial class HtmlP
{
}

public static partial class HtmlPControl
{
    /// <summary>
    /// The HTML p tag
    /// </summary>
    public static Var<IVNode> HtmlP(this LayoutBuilder b, Action<PropsBuilder<HtmlP>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("p", buildProps, children);
    }
    /// <summary>
    /// The HTML p tag
    /// </summary>
    public static Var<IVNode> HtmlP(this LayoutBuilder b, Action<PropsBuilder<HtmlP>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("p", buildProps, children);
    }
}

