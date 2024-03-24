using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Html;


public partial class HtmlRt
{
}

public static partial class HtmlRtControl
{
    /// <summary>
    /// The HTML rt tag
    /// </summary>
    public static Var<IVNode> HtmlRt(this LayoutBuilder b, Action<PropsBuilder<HtmlRt>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("rt", buildProps, children);
    }
    /// <summary>
    /// The HTML rt tag
    /// </summary>
    public static Var<IVNode> HtmlRt(this LayoutBuilder b, Action<PropsBuilder<HtmlRt>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("rt", buildProps, children);
    }
}

