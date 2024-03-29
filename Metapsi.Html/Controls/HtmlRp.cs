using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Html;


public partial class HtmlRp
{
}

public static partial class HtmlRpControl
{
    /// <summary>
    /// The HTML rp tag
    /// </summary>
    public static Var<IVNode> HtmlRp(this LayoutBuilder b, Action<PropsBuilder<HtmlRp>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("rp", buildProps, children);
    }
    /// <summary>
    /// The HTML rp tag
    /// </summary>
    public static Var<IVNode> HtmlRp(this LayoutBuilder b, Action<PropsBuilder<HtmlRp>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("rp", buildProps, children);
    }
}

