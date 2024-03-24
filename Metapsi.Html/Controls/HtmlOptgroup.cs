using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Html;


public partial class HtmlOptgroup
{
}

public static partial class HtmlOptgroupControl
{
    /// <summary>
    /// The HTML optgroup tag
    /// </summary>
    public static Var<IVNode> HtmlOptgroup(this LayoutBuilder b, Action<PropsBuilder<HtmlOptgroup>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("optgroup", buildProps, children);
    }
    /// <summary>
    /// The HTML optgroup tag
    /// </summary>
    public static Var<IVNode> HtmlOptgroup(this LayoutBuilder b, Action<PropsBuilder<HtmlOptgroup>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("optgroup", buildProps, children);
    }
}

