using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Html;


public partial class HtmlA
{
}

public static partial class HtmlAControl
{
    /// <summary>
    /// The HTML a tag
    /// </summary>
    public static Var<IVNode> HtmlA(this LayoutBuilder b, Action<PropsBuilder<HtmlA>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("a", buildProps, children);
    }
    /// <summary>
    /// The HTML a tag
    /// </summary>
    public static Var<IVNode> HtmlA(this LayoutBuilder b, Action<PropsBuilder<HtmlA>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("a", buildProps, children);
    }
}

