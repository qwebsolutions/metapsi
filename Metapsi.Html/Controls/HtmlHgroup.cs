using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Html;


public partial class HtmlHgroup
{
}

public static partial class HtmlHgroupControl
{
    /// <summary>
    /// The HTML hgroup tag
    /// </summary>
    public static Var<IVNode> HtmlHgroup(this LayoutBuilder b, Action<PropsBuilder<HtmlHgroup>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("hgroup", buildProps, children);
    }
    /// <summary>
    /// The HTML hgroup tag
    /// </summary>
    public static Var<IVNode> HtmlHgroup(this LayoutBuilder b, Action<PropsBuilder<HtmlHgroup>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("hgroup", buildProps, children);
    }
    /// <summary>
    /// The HTML hgroup tag
    /// </summary>
    public static Var<IVNode> HtmlHgroup(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("hgroup", children);
    }
    /// <summary>
    /// The HTML hgroup tag
    /// </summary>
    public static Var<IVNode> HtmlHgroup(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("hgroup", children);
    }
}

