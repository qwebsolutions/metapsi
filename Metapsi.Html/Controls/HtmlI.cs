using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Html;


public partial class HtmlI
{
}

public static partial class HtmlIControl
{
    /// <summary>
    /// The HTML i tag
    /// </summary>
    public static Var<IVNode> HtmlI(this LayoutBuilder b, Action<PropsBuilder<HtmlI>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("i", buildProps, children);
    }
    /// <summary>
    /// The HTML i tag
    /// </summary>
    public static Var<IVNode> HtmlI(this LayoutBuilder b, Action<PropsBuilder<HtmlI>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("i", buildProps, children);
    }
}

