using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Html;


public partial class HtmlDt
{
}

public static partial class HtmlDtControl
{
    /// <summary>
    /// The HTML dt tag
    /// </summary>
    public static Var<IVNode> HtmlDt(this LayoutBuilder b, Action<PropsBuilder<HtmlDt>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("dt", buildProps, children);
    }
    /// <summary>
    /// The HTML dt tag
    /// </summary>
    public static Var<IVNode> HtmlDt(this LayoutBuilder b, Action<PropsBuilder<HtmlDt>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("dt", buildProps, children);
    }
}

