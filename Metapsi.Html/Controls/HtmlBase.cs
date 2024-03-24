using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Html;


public partial class HtmlBase
{
}

public static partial class HtmlBaseControl
{
    /// <summary>
    /// The HTML base tag
    /// </summary>
    public static Var<IVNode> HtmlBase(this LayoutBuilder b, Action<PropsBuilder<HtmlBase>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("base", buildProps, children);
    }
    /// <summary>
    /// The HTML base tag
    /// </summary>
    public static Var<IVNode> HtmlBase(this LayoutBuilder b, Action<PropsBuilder<HtmlBase>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("base", buildProps, children);
    }
}

