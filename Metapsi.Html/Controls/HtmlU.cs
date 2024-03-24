using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Html;


public partial class HtmlU
{
}

public static partial class HtmlUControl
{
    /// <summary>
    /// The HTML u tag
    /// </summary>
    public static Var<IVNode> HtmlU(this LayoutBuilder b, Action<PropsBuilder<HtmlU>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("u", buildProps, children);
    }
    /// <summary>
    /// The HTML u tag
    /// </summary>
    public static Var<IVNode> HtmlU(this LayoutBuilder b, Action<PropsBuilder<HtmlU>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("u", buildProps, children);
    }
}

