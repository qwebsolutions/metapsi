using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Html;


public partial class HtmlMark
{
}

public static partial class HtmlMarkControl
{
    /// <summary>
    /// The HTML mark tag
    /// </summary>
    public static Var<IVNode> HtmlMark(this LayoutBuilder b, Action<PropsBuilder<HtmlMark>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("mark", buildProps, children);
    }
    /// <summary>
    /// The HTML mark tag
    /// </summary>
    public static Var<IVNode> HtmlMark(this LayoutBuilder b, Action<PropsBuilder<HtmlMark>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("mark", buildProps, children);
    }
}

