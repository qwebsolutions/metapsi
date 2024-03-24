using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Html;


public partial class HtmlSection
{
}

public static partial class HtmlSectionControl
{
    /// <summary>
    /// The HTML section tag
    /// </summary>
    public static Var<IVNode> HtmlSection(this LayoutBuilder b, Action<PropsBuilder<HtmlSection>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("section", buildProps, children);
    }
    /// <summary>
    /// The HTML section tag
    /// </summary>
    public static Var<IVNode> HtmlSection(this LayoutBuilder b, Action<PropsBuilder<HtmlSection>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("section", buildProps, children);
    }
}

