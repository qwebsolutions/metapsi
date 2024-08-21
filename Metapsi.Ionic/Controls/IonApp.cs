using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Ionic;


public partial class IonApp
{
}

public static partial class IonAppControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonApp(this HtmlBuilder b, Action<AttributesBuilder<IonApp>> buildAttributes, params IHtmlNode[] children)
    {
        return b.IonicTag("ion-app", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonApp(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.IonicTag("ion-app", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonApp(this HtmlBuilder b, Action<AttributesBuilder<IonApp>> buildAttributes, List<IHtmlNode> children)
    {
        return b.IonicTag("ion-app", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonApp(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.IonicTag("ion-app", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonApp(this LayoutBuilder b, Action<PropsBuilder<IonApp>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-app", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonApp(this LayoutBuilder b, Action<PropsBuilder<IonApp>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-app", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonApp(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-app", children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonApp(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-app", children);
    }
}

