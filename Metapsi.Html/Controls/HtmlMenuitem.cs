using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Html;


public partial class HtmlMenuitem
{
}

public static partial class HtmlMenuitemControl
{
    /// <summary>
    /// The HTML menuitem tag
    /// </summary>
    public static Var<IVNode> HtmlMenuitem(this LayoutBuilder b, Action<PropsBuilder<HtmlMenuitem>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("menuitem", buildProps, children);
    }
    /// <summary>
    /// The HTML menuitem tag
    /// </summary>
    public static Var<IVNode> HtmlMenuitem(this LayoutBuilder b, Action<PropsBuilder<HtmlMenuitem>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("menuitem", buildProps, children);
    }
}

