using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Html;


public partial class HtmlOutput
{
}

public static partial class HtmlOutputControl
{
    /// <summary>
    /// The HTML output tag
    /// </summary>
    public static Var<IVNode> HtmlOutput(this LayoutBuilder b, Action<PropsBuilder<HtmlOutput>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("output", buildProps, children);
    }
    /// <summary>
    /// The HTML output tag
    /// </summary>
    public static Var<IVNode> HtmlOutput(this LayoutBuilder b, Action<PropsBuilder<HtmlOutput>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("output", buildProps, children);
    }
}

