using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Html;


public partial class HtmlTemplate
{
}

public static partial class HtmlTemplateControl
{
    /// <summary>
    /// The HTML template tag
    /// </summary>
    public static Var<IVNode> HtmlTemplate(this LayoutBuilder b, Action<PropsBuilder<HtmlTemplate>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("template", buildProps, children);
    }
    /// <summary>
    /// The HTML template tag
    /// </summary>
    public static Var<IVNode> HtmlTemplate(this LayoutBuilder b, Action<PropsBuilder<HtmlTemplate>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("template", buildProps, children);
    }
}

