using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Html;


public partial class HtmlDel
{
}

public static partial class HtmlDelControl
{
    /// <summary>
    /// The HTML del tag
    /// </summary>
    public static Var<IVNode> HtmlDel(this LayoutBuilder b, Action<PropsBuilder<HtmlDel>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("del", buildProps, children);
    }
    /// <summary>
    /// The HTML del tag
    /// </summary>
    public static Var<IVNode> HtmlDel(this LayoutBuilder b, Action<PropsBuilder<HtmlDel>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("del", buildProps, children);
    }
}

