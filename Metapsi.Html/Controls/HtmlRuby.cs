using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Html;


public partial class HtmlRuby
{
}

public static partial class HtmlRubyControl
{
    /// <summary>
    /// The HTML ruby tag
    /// </summary>
    public static Var<IVNode> HtmlRuby(this LayoutBuilder b, Action<PropsBuilder<HtmlRuby>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("ruby", buildProps, children);
    }
    /// <summary>
    /// The HTML ruby tag
    /// </summary>
    public static Var<IVNode> HtmlRuby(this LayoutBuilder b, Action<PropsBuilder<HtmlRuby>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("ruby", buildProps, children);
    }
}

