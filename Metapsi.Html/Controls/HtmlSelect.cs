using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Html;


public partial class HtmlSelect
{
}

public static partial class HtmlSelectControl
{
    /// <summary>
    /// The HTML select tag
    /// </summary>
    public static Var<IVNode> HtmlSelect(this LayoutBuilder b, Action<PropsBuilder<HtmlSelect>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("select", buildProps, children);
    }
    /// <summary>
    /// The HTML select tag
    /// </summary>
    public static Var<IVNode> HtmlSelect(this LayoutBuilder b, Action<PropsBuilder<HtmlSelect>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("select", buildProps, children);
    }
}

