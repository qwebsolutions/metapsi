using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Html;


public partial class HtmlIframe
{
}

public static partial class HtmlIframeControl
{
    /// <summary>
    /// The HTML iframe tag
    /// </summary>
    public static Var<IVNode> HtmlIframe(this LayoutBuilder b, Action<PropsBuilder<HtmlIframe>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("iframe", buildProps, children);
    }
    /// <summary>
    /// The HTML iframe tag
    /// </summary>
    public static Var<IVNode> HtmlIframe(this LayoutBuilder b, Action<PropsBuilder<HtmlIframe>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("iframe", buildProps, children);
    }
}

