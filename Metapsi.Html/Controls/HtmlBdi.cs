using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Html;


public partial class HtmlBdi
{
}

public static partial class HtmlBdiControl
{
    /// <summary>
    /// The HTML bdi tag
    /// </summary>
    public static Var<IVNode> HtmlBdi(this LayoutBuilder b, Action<PropsBuilder<HtmlBdi>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("bdi", buildProps, children);
    }
    /// <summary>
    /// The HTML bdi tag
    /// </summary>
    public static Var<IVNode> HtmlBdi(this LayoutBuilder b, Action<PropsBuilder<HtmlBdi>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("bdi", buildProps, children);
    }
}

