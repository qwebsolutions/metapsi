using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Ionic;


public partial class IonSkeletonText : IonComponent
{
    public IonSkeletonText() : base("ion-skeleton-text") { }
}

public static partial class IonSkeletonTextControl
{
    /// <summary>
    /// 
    /// </summary>
    public static IHtmlNode IonSkeletonText(this HtmlBuilder b, Action<AttributesBuilder<IonSkeletonText>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("ion-skeleton-text", buildAttributes, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static IHtmlNode IonSkeletonText(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("ion-skeleton-text", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// If `true`, the skeleton text will animate.
    /// </summary>
    public static void SetAnimated(this AttributesBuilder<IonSkeletonText> b)
    {
        b.SetAttribute("animated", "");
    }
    /// <summary>
    /// If `true`, the skeleton text will animate.
    /// </summary>
    public static void SetAnimated(this AttributesBuilder<IonSkeletonText> b, bool value)
    {
        if (value) b.SetAttribute("animated", "");
    }

    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonSkeletonText(this LayoutBuilder b, Action<PropsBuilder<IonSkeletonText>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-skeleton-text", buildProps, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonSkeletonText(this LayoutBuilder b, Action<PropsBuilder<IonSkeletonText>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-skeleton-text", buildProps, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonSkeletonText(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-skeleton-text", children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonSkeletonText(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-skeleton-text", children);
    }
    /// <summary>
    /// If `true`, the skeleton text will animate.
    /// </summary>
    public static void SetAnimated<T>(this PropsBuilder<T> b) where T: IonSkeletonText
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("animated"), b.Const(true));
    }

}

