using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Html;


public partial class HtmlObject
{
}

public static partial class HtmlObjectControl
{
    /// <summary>
    /// The HTML object tag
    /// </summary>
    public static Var<IVNode> HtmlObject(this LayoutBuilder b, Action<PropsBuilder<HtmlObject>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("object", buildProps, children);
    }
    /// <summary>
    /// The HTML object tag
    /// </summary>
    public static Var<IVNode> HtmlObject(this LayoutBuilder b, Action<PropsBuilder<HtmlObject>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("object", buildProps, children);
    }
    /// <summary>
    /// The HTML object tag
    /// </summary>
    public static Var<IVNode> HtmlObject(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("object", children);
    }
    /// <summary>
    /// The HTML object tag
    /// </summary>
    public static Var<IVNode> HtmlObject(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("object", children);
    }
}

