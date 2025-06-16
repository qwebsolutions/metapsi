using Metapsi.Html;
using Metapsi.Syntax;
using Metapsi.Hyperapp;

namespace Metapsi.Ionic;

/// <summary>
/// 
/// </summary>
public partial class IonSkeletonText
{
    /// <summary>
    /// 
    /// </summary>
    public static class Slot
    {
    }
    /// <summary>
    /// 
    /// </summary>
    public static class Method
    {
    }
}
/// <summary>
/// Setter extensions of IonSkeletonText
/// </summary>
public static partial class IonSkeletonTextControl
{
    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonSkeletonText(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonSkeletonText>> buildAttributes, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.IonicTag("ion-skeleton-text", buildAttributes, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonSkeletonText(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.IonicTag("ion-skeleton-text", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonSkeletonText(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonSkeletonText>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.IonicTag("ion-skeleton-text", buildAttributes, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonSkeletonText(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.IonicTag("ion-skeleton-text", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// If `true`, the skeleton text will animate.
    /// </summary>
    public static void SetAnimated(this Metapsi.Html.AttributesBuilder<IonSkeletonText> b, bool animated) 
    {
        if (animated) b.SetAttribute("animated", "");
    }

    /// <summary>
    /// If `true`, the skeleton text will animate.
    /// </summary>
    public static void SetAnimated(this Metapsi.Html.AttributesBuilder<IonSkeletonText> b) 
    {
        b.SetAttribute("animated", "");
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonSkeletonText(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonSkeletonText>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.IonicNode("ion-skeleton-text", buildProps, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonSkeletonText(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.IonicNode("ion-skeleton-text", children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonSkeletonText(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonSkeletonText>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.IonicNode("ion-skeleton-text", buildProps, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonSkeletonText(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.IonicNode("ion-skeleton-text", children);
    }

    /// <summary>
    /// If `true`, the skeleton text will animate.
    /// </summary>
    public static void SetAnimated<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSkeletonText
    {
        b.SetAnimated(b.Const(true));
    }

    /// <summary>
    /// If `true`, the skeleton text will animate.
    /// </summary>
    public static void SetAnimated<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> animated) where T: IonSkeletonText
    {
        b.SetProperty(b.Props, b.Const("animated"), animated);
    }

    /// <summary>
    /// If `true`, the skeleton text will animate.
    /// </summary>
    public static void SetAnimated<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool animated) where T: IonSkeletonText
    {
        b.SetAnimated(b.Const(animated));
    }

}