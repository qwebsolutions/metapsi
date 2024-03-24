using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Html;


public partial class HtmlTable
{
}

public static partial class HtmlTableControl
{
    /// <summary>
    /// The HTML table tag
    /// </summary>
    public static Var<IVNode> HtmlTable(this LayoutBuilder b, Action<PropsBuilder<HtmlTable>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("table", buildProps, children);
    }
    /// <summary>
    /// The HTML table tag
    /// </summary>
    public static Var<IVNode> HtmlTable(this LayoutBuilder b, Action<PropsBuilder<HtmlTable>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("table", buildProps, children);
    }
}

