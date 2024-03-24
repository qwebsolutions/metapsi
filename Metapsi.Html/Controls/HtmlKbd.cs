using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Html;


public partial class HtmlKbd
{
}

public static partial class HtmlKbdControl
{
    /// <summary>
    /// The HTML kbd tag
    /// </summary>
    public static Var<IVNode> HtmlKbd(this LayoutBuilder b, Action<PropsBuilder<HtmlKbd>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("kbd", buildProps, children);
    }
    /// <summary>
    /// The HTML kbd tag
    /// </summary>
    public static Var<IVNode> HtmlKbd(this LayoutBuilder b, Action<PropsBuilder<HtmlKbd>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("kbd", buildProps, children);
    }
}

