using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Html;


public partial class HtmlAside
{
}

public static partial class HtmlAsideControl
{
    /// <summary>
    /// The HTML aside tag
    /// </summary>
    public static Var<IVNode> HtmlAside(this LayoutBuilder b, Action<PropsBuilder<HtmlAside>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("aside", buildProps, children);
    }
    /// <summary>
    /// The HTML aside tag
    /// </summary>
    public static Var<IVNode> HtmlAside(this LayoutBuilder b, Action<PropsBuilder<HtmlAside>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("aside", buildProps, children);
    }
}

