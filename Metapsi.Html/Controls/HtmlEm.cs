using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Html;


public partial class HtmlEm
{
}

public static partial class HtmlEmControl
{
    /// <summary>
    /// The HTML em tag
    /// </summary>
    public static Var<IVNode> HtmlEm(this LayoutBuilder b, Action<PropsBuilder<HtmlEm>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("em", buildProps, children);
    }
    /// <summary>
    /// The HTML em tag
    /// </summary>
    public static Var<IVNode> HtmlEm(this LayoutBuilder b, Action<PropsBuilder<HtmlEm>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("em", buildProps, children);
    }
}

