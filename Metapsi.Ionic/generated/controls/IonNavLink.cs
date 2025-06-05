using Metapsi.Html;
using Metapsi.Syntax;
using Metapsi.Hyperapp;

namespace Metapsi.Ionic;

/// <summary>
/// 
/// </summary>
public partial class IonNavLink
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
/// Setter extensions of IonNavLink
/// </summary>
public static partial class IonNavLinkControl
{
    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonNavLink(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonNavLink>> buildAttributes, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.IonicTag("ion-nav-link", buildAttributes, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonNavLink(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.IonicTag("ion-nav-link", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonNavLink(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonNavLink>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.IonicTag("ion-nav-link", buildAttributes, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonNavLink(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.IonicTag("ion-nav-link", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// Component to navigate to. Only used if the `routerDirection` is `"forward"` or `"root"`.
    /// </summary>
    public static void SetComponent(this Metapsi.Html.AttributesBuilder<IonNavLink> b, string component) 
    {
        b.SetAttribute("component", component);
    }

    /// <summary>
    /// The transition direction when navigating to another page.
    /// </summary>
    public static void SetRouterDirectionBack(this Metapsi.Html.AttributesBuilder<IonNavLink> b) 
    {
        b.SetAttribute("routerDirection", "back");
    }

    /// <summary>
    /// The transition direction when navigating to another page.
    /// </summary>
    public static void SetRouterDirectionForward(this Metapsi.Html.AttributesBuilder<IonNavLink> b) 
    {
        b.SetAttribute("routerDirection", "forward");
    }

    /// <summary>
    /// The transition direction when navigating to another page.
    /// </summary>
    public static void SetRouterDirectionRoot(this Metapsi.Html.AttributesBuilder<IonNavLink> b) 
    {
        b.SetAttribute("routerDirection", "root");
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonNavLink(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonNavLink>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.IonicNode("ion-nav-link", buildProps, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonNavLink(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.IonicNode("ion-nav-link", children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonNavLink(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonNavLink>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.IonicNode("ion-nav-link", buildProps, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonNavLink(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.IonicNode("ion-nav-link", children);
    }

    /// <summary>
    /// Component to navigate to. Only used if the `routerDirection` is `"forward"` or `"root"`.
    /// </summary>
    public static void SetComponent<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> component) where T: IonNavLink
    {
        b.SetProperty(b.Props, b.Const("component"), component);
    }

    /// <summary>
    /// Data you want to pass to the component as props. Only used if the `"routerDirection"` is `"forward"` or `"root"`.
    /// </summary>
    public static void SetComponentProps<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Syntax.Var<System.Collections.Generic.List<object>>> componentProps) where T: IonNavLink
    {
        b.SetProperty(b.Props, b.Const("componentProps"), componentProps);
    }

    /// <summary>
    /// The transition direction when navigating to another page.
    /// </summary>
    public static void SetRouterDirectionBack<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonNavLink
    {
        b.SetProperty(b.Props, b.Const("routerDirection"), b.Const("back"));
    }

    /// <summary>
    /// The transition direction when navigating to another page.
    /// </summary>
    public static void SetRouterDirectionForward<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonNavLink
    {
        b.SetProperty(b.Props, b.Const("routerDirection"), b.Const("forward"));
    }

    /// <summary>
    /// The transition direction when navigating to another page.
    /// </summary>
    public static void SetRouterDirectionRoot<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonNavLink
    {
        b.SetProperty(b.Props, b.Const("routerDirection"), b.Const("root"));
    }

}