using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Html;


public partial class HtmlMath
{
}

public static partial class HtmlMathControl
{
    /// <summary>
    /// The HTML math tag
    /// </summary>
    public static Var<IVNode> HtmlMath(this LayoutBuilder b, Action<PropsBuilder<HtmlMath>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("math", buildProps, children);
    }
    /// <summary>
    /// The HTML math tag
    /// </summary>
    public static Var<IVNode> HtmlMath(this LayoutBuilder b, Action<PropsBuilder<HtmlMath>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("math", buildProps, children);
    }
}

