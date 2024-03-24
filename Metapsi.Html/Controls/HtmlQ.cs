using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Html;


public partial class HtmlQ
{
}

public static partial class HtmlQControl
{
    /// <summary>
    /// The HTML q tag
    /// </summary>
    public static Var<IVNode> HtmlQ(this LayoutBuilder b, Action<PropsBuilder<HtmlQ>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("q", buildProps, children);
    }
    /// <summary>
    /// The HTML q tag
    /// </summary>
    public static Var<IVNode> HtmlQ(this LayoutBuilder b, Action<PropsBuilder<HtmlQ>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("q", buildProps, children);
    }
}

