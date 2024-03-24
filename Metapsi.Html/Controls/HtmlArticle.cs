using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Html;


public partial class HtmlArticle
{
}

public static partial class HtmlArticleControl
{
    /// <summary>
    /// The HTML article tag
    /// </summary>
    public static Var<IVNode> HtmlArticle(this LayoutBuilder b, Action<PropsBuilder<HtmlArticle>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("article", buildProps, children);
    }
    /// <summary>
    /// The HTML article tag
    /// </summary>
    public static Var<IVNode> HtmlArticle(this LayoutBuilder b, Action<PropsBuilder<HtmlArticle>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("article", buildProps, children);
    }
}

