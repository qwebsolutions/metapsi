using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Ionic;


public partial class IonReorder
{
}

public static partial class IonReorderControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonReorder(this HtmlBuilder b, Action<AttributesBuilder<IonReorder>> buildAttributes, params IHtmlNode[] children)
    {
        return b.IonicTag("ion-reorder", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonReorder(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.IonicTag("ion-reorder", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonReorder(this HtmlBuilder b, Action<AttributesBuilder<IonReorder>> buildAttributes, List<IHtmlNode> children)
    {
        return b.IonicTag("ion-reorder", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonReorder(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.IonicTag("ion-reorder", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonReorder(this LayoutBuilder b, Action<PropsBuilder<IonReorder>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-reorder", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonReorder(this LayoutBuilder b, Action<PropsBuilder<IonReorder>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-reorder", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonReorder(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-reorder", children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonReorder(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-reorder", children);
    }
}

