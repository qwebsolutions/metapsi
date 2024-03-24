using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Html;


public partial class HtmlDd
{
}

public static partial class HtmlDdControl
{
    /// <summary>
    /// The HTML dd tag
    /// </summary>
    public static Var<IVNode> HtmlDd(this LayoutBuilder b, Action<PropsBuilder<HtmlDd>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("dd", buildProps, children);
    }
    /// <summary>
    /// The HTML dd tag
    /// </summary>
    public static Var<IVNode> HtmlDd(this LayoutBuilder b, Action<PropsBuilder<HtmlDd>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("dd", buildProps, children);
    }
}

