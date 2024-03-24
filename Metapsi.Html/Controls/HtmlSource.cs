using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Html;


public partial class HtmlSource
{
}

public static partial class HtmlSourceControl
{
    /// <summary>
    /// The HTML source tag
    /// </summary>
    public static Var<IVNode> HtmlSource(this LayoutBuilder b, Action<PropsBuilder<HtmlSource>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("source", buildProps, children);
    }
    /// <summary>
    /// The HTML source tag
    /// </summary>
    public static Var<IVNode> HtmlSource(this LayoutBuilder b, Action<PropsBuilder<HtmlSource>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("source", buildProps, children);
    }
}

