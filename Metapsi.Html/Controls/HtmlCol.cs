using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Html;


public partial class HtmlCol
{
}

public static partial class HtmlColControl
{
    /// <summary>
    /// The HTML col tag
    /// </summary>
    public static Var<IVNode> HtmlCol(this LayoutBuilder b, Action<PropsBuilder<HtmlCol>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("col", buildProps, children);
    }
    /// <summary>
    /// The HTML col tag
    /// </summary>
    public static Var<IVNode> HtmlCol(this LayoutBuilder b, Action<PropsBuilder<HtmlCol>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("col", buildProps, children);
    }
}

