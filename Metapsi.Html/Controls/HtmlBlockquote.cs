using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Html;


public partial class HtmlBlockquote
{
}

public static partial class HtmlBlockquoteControl
{
    /// <summary>
    /// The HTML blockquote tag
    /// </summary>
    public static Var<IVNode> HtmlBlockquote(this LayoutBuilder b, Action<PropsBuilder<HtmlBlockquote>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("blockquote", buildProps, children);
    }
    /// <summary>
    /// The HTML blockquote tag
    /// </summary>
    public static Var<IVNode> HtmlBlockquote(this LayoutBuilder b, Action<PropsBuilder<HtmlBlockquote>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("blockquote", buildProps, children);
    }
}

