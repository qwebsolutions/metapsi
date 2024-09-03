using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Ionic;


public partial class IonRow
{
}

public static partial class IonRowControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonRow(this HtmlBuilder b, Action<AttributesBuilder<IonRow>> buildAttributes, params IHtmlNode[] children)
    {
        return b.IonicTag("ion-row", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonRow(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.IonicTag("ion-row", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonRow(this HtmlBuilder b, Action<AttributesBuilder<IonRow>> buildAttributes, List<IHtmlNode> children)
    {
        return b.IonicTag("ion-row", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonRow(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.IonicTag("ion-row", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonRow(this LayoutBuilder b, Action<PropsBuilder<IonRow>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-row", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonRow(this LayoutBuilder b, Action<PropsBuilder<IonRow>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-row", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonRow(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-row", children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonRow(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-row", children);
    }
}

