using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Html;


public partial class HtmlMap
{
}

public static partial class HtmlMapControl
{
    /// <summary>
    /// The HTML map tag
    /// </summary>
    public static Var<IVNode> HtmlMap(this LayoutBuilder b, Action<PropsBuilder<HtmlMap>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("map", buildProps, children);
    }
    /// <summary>
    /// The HTML map tag
    /// </summary>
    public static Var<IVNode> HtmlMap(this LayoutBuilder b, Action<PropsBuilder<HtmlMap>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("map", buildProps, children);
    }
}

