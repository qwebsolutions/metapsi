using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Html;


public partial class HtmlBdo
{
}

public static partial class HtmlBdoControl
{
    /// <summary>
    /// The HTML bdo tag
    /// </summary>
    public static Var<IVNode> HtmlBdo(this LayoutBuilder b, Action<PropsBuilder<HtmlBdo>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("bdo", buildProps, children);
    }
    /// <summary>
    /// The HTML bdo tag
    /// </summary>
    public static Var<IVNode> HtmlBdo(this LayoutBuilder b, Action<PropsBuilder<HtmlBdo>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("bdo", buildProps, children);
    }
    /// <summary>
    /// The HTML bdo tag
    /// </summary>
    public static Var<IVNode> HtmlBdo(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("bdo", children);
    }
    /// <summary>
    /// The HTML bdo tag
    /// </summary>
    public static Var<IVNode> HtmlBdo(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("bdo", children);
    }
}

