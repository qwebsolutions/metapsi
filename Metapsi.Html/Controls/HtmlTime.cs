using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Html;


public partial class HtmlTime
{
}

public static partial class HtmlTimeControl
{
    /// <summary>
    /// The HTML time tag
    /// </summary>
    public static Var<IVNode> HtmlTime(this LayoutBuilder b, Action<PropsBuilder<HtmlTime>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("time", buildProps, children);
    }
    /// <summary>
    /// The HTML time tag
    /// </summary>
    public static Var<IVNode> HtmlTime(this LayoutBuilder b, Action<PropsBuilder<HtmlTime>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("time", buildProps, children);
    }
}

