using Metapsi.Html;
using Metapsi.Syntax;
using Metapsi.Hyperapp;

namespace Metapsi.Ionic;

/// <summary>
/// 
/// </summary>
public partial class IonRouterOutlet
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
/// Setter extensions of IonRouterOutlet
/// </summary>
public static partial class IonRouterOutletControl
{
    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonRouterOutlet(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonRouterOutlet>> buildAttributes, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.IonicTag("ion-router-outlet", buildAttributes, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonRouterOutlet(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.IonicTag("ion-router-outlet", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonRouterOutlet(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonRouterOutlet>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.IonicTag("ion-router-outlet", buildAttributes, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonRouterOutlet(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.IonicTag("ion-router-outlet", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// If `true`, the router-outlet should animate the transition of components.
    /// </summary>
    public static void SetAnimated(this Metapsi.Html.AttributesBuilder<IonRouterOutlet> b, bool animated) 
    {
        if (animated) b.SetAttribute("animated", "");
    }

    /// <summary>
    /// If `true`, the router-outlet should animate the transition of components.
    /// </summary>
    public static void SetAnimated(this Metapsi.Html.AttributesBuilder<IonRouterOutlet> b) 
    {
        b.SetAttribute("animated", "");
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos(this Metapsi.Html.AttributesBuilder<IonRouterOutlet> b) 
    {
        b.SetAttribute("mode", "ios");
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd(this Metapsi.Html.AttributesBuilder<IonRouterOutlet> b) 
    {
        b.SetAttribute("mode", "md");
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonRouterOutlet(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonRouterOutlet>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.IonicNode("ion-router-outlet", buildProps, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonRouterOutlet(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.IonicNode("ion-router-outlet", children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonRouterOutlet(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonRouterOutlet>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.IonicNode("ion-router-outlet", buildProps, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonRouterOutlet(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.IonicNode("ion-router-outlet", children);
    }

    /// <summary>
    /// If `true`, the router-outlet should animate the transition of components.
    /// </summary>
    public static void SetAnimated<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonRouterOutlet
    {
        b.SetAnimated(b.Const(true));
    }

    /// <summary>
    /// If `true`, the router-outlet should animate the transition of components.
    /// </summary>
    public static void SetAnimated<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> animated) where T: IonRouterOutlet
    {
        b.SetProperty(b.Props, b.Const("animated"), animated);
    }

    /// <summary>
    /// If `true`, the router-outlet should animate the transition of components.
    /// </summary>
    public static void SetAnimated<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool animated) where T: IonRouterOutlet
    {
        b.SetAnimated(b.Const(animated));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonRouterOutlet
    {
        b.SetProperty(b.Props, b.Const("mode"), b.Const("ios"));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonRouterOutlet
    {
        b.SetProperty(b.Props, b.Const("mode"), b.Const("md"));
    }

}