using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Html;


public partial class HtmlB
{
}

public static partial class HtmlBControl
{
    /// <summary>
    /// The HTML b tag
    /// </summary>
    public static Var<IVNode> HtmlB(this LayoutBuilder b, Action<PropsBuilder<HtmlB>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("b", buildProps, children);
    }
    /// <summary>
    /// The HTML b tag
    /// </summary>
    public static Var<IVNode> HtmlB(this LayoutBuilder b, Action<PropsBuilder<HtmlB>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("b", buildProps, children);
    }
    /// <summary>
    /// The HTML b tag
    /// </summary>
    public static Var<IVNode> HtmlB(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("b", children);
    }
    /// <summary>
    /// The HTML b tag
    /// </summary>
    public static Var<IVNode> HtmlB(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("b", children);
    }
}

