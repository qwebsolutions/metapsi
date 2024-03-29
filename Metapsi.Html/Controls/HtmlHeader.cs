using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Html;


public partial class HtmlHeader
{
}

public static partial class HtmlHeaderControl
{
    /// <summary>
    /// The HTML header tag
    /// </summary>
    public static Var<IVNode> HtmlHeader(this LayoutBuilder b, Action<PropsBuilder<HtmlHeader>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("header", buildProps, children);
    }
    /// <summary>
    /// The HTML header tag
    /// </summary>
    public static Var<IVNode> HtmlHeader(this LayoutBuilder b, Action<PropsBuilder<HtmlHeader>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("header", buildProps, children);
    }
}

