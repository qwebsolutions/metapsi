using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Html;


public partial class HtmlColgroup
{
}

public static partial class HtmlColgroupControl
{
    /// <summary>
    /// The HTML colgroup tag
    /// </summary>
    public static Var<IVNode> HtmlColgroup(this LayoutBuilder b, Action<PropsBuilder<HtmlColgroup>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("colgroup", buildProps, children);
    }
    /// <summary>
    /// The HTML colgroup tag
    /// </summary>
    public static Var<IVNode> HtmlColgroup(this LayoutBuilder b, Action<PropsBuilder<HtmlColgroup>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("colgroup", buildProps, children);
    }
}

