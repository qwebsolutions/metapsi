using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Html;


public partial class HtmlAddress
{
}

public static partial class HtmlAddressControl
{
    /// <summary>
    /// The HTML address tag
    /// </summary>
    public static Var<IVNode> HtmlAddress(this LayoutBuilder b, Action<PropsBuilder<HtmlAddress>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("address", buildProps, children);
    }
    /// <summary>
    /// The HTML address tag
    /// </summary>
    public static Var<IVNode> HtmlAddress(this LayoutBuilder b, Action<PropsBuilder<HtmlAddress>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("address", buildProps, children);
    }
    /// <summary>
    /// The HTML address tag
    /// </summary>
    public static Var<IVNode> HtmlAddress(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("address", children);
    }
    /// <summary>
    /// The HTML address tag
    /// </summary>
    public static Var<IVNode> HtmlAddress(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("address", children);
    }
}

