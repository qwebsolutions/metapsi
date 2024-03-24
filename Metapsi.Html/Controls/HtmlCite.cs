using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Html;


public partial class HtmlCite
{
}

public static partial class HtmlCiteControl
{
    /// <summary>
    /// The HTML cite tag
    /// </summary>
    public static Var<IVNode> HtmlCite(this LayoutBuilder b, Action<PropsBuilder<HtmlCite>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("cite", buildProps, children);
    }
    /// <summary>
    /// The HTML cite tag
    /// </summary>
    public static Var<IVNode> HtmlCite(this LayoutBuilder b, Action<PropsBuilder<HtmlCite>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("cite", buildProps, children);
    }
}

