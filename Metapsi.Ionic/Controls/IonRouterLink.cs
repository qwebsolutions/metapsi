using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Ionic;


public partial class IonRouterLink
{
}

public static partial class IonRouterLinkControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonRouterLink(this HtmlBuilder b, Action<AttributesBuilder<IonRouterLink>> buildAttributes, params IHtmlNode[] children)
    {
        return b.IonicTag("ion-router-link", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonRouterLink(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.IonicTag("ion-router-link", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonRouterLink(this HtmlBuilder b, Action<AttributesBuilder<IonRouterLink>> buildAttributes, List<IHtmlNode> children)
    {
        return b.IonicTag("ion-router-link", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonRouterLink(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.IonicTag("ion-router-link", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColor(this AttributesBuilder<IonRouterLink> b, string color)
    {
        b.SetAttribute("color", color);
    }

    /// <summary>
    /// <para> Contains a URL or a URL fragment that the hyperlink points to. If this property is set, an anchor tag will be rendered. </para>
    /// </summary>
    public static void SetHref(this AttributesBuilder<IonRouterLink> b, string href)
    {
        b.SetAttribute("href", href);
    }

    /// <summary>
    /// <para> Specifies the relationship of the target object to the link object. The value is a space-separated list of [link types](https://developer.mozilla.org/en-US/docs/Web/HTML/Link_types). </para>
    /// </summary>
    public static void SetRel(this AttributesBuilder<IonRouterLink> b, string rel)
    {
        b.SetAttribute("rel", rel);
    }

    /// <summary>
    /// <para> When using a router, it specifies the transition direction when navigating to another page using `href`. </para>
    /// </summary>
    public static void SetRouterDirection(this AttributesBuilder<IonRouterLink> b, string routerDirection)
    {
        b.SetAttribute("router-direction", routerDirection);
    }

    /// <summary>
    /// <para> When using a router, it specifies the transition direction when navigating to another page using `href`. </para>
    /// </summary>
    public static void SetRouterDirectionBack(this AttributesBuilder<IonRouterLink> b)
    {
        b.SetAttribute("router-direction", "back");
    }

    /// <summary>
    /// <para> When using a router, it specifies the transition direction when navigating to another page using `href`. </para>
    /// </summary>
    public static void SetRouterDirectionForward(this AttributesBuilder<IonRouterLink> b)
    {
        b.SetAttribute("router-direction", "forward");
    }

    /// <summary>
    /// <para> When using a router, it specifies the transition direction when navigating to another page using `href`. </para>
    /// </summary>
    public static void SetRouterDirectionRoot(this AttributesBuilder<IonRouterLink> b)
    {
        b.SetAttribute("router-direction", "root");
    }

    /// <summary>
    /// <para> Specifies where to display the linked URL. Only applies when an `href` is provided. Special keywords: `"_blank"`, `"_self"`, `"_parent"`, `"_top"`. </para>
    /// </summary>
    public static void SetTarget(this AttributesBuilder<IonRouterLink> b, string target)
    {
        b.SetAttribute("target", target);
    }

    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonRouterLink(this LayoutBuilder b, Action<PropsBuilder<IonRouterLink>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-router-link", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonRouterLink(this LayoutBuilder b, Action<PropsBuilder<IonRouterLink>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-router-link", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonRouterLink(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-router-link", children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonRouterLink(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-router-link", children);
    }
    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorDanger<T>(this PropsBuilder<T> b) where T: IonRouterLink
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("danger"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorDark<T>(this PropsBuilder<T> b) where T: IonRouterLink
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("dark"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorLight<T>(this PropsBuilder<T> b) where T: IonRouterLink
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("light"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorMedium<T>(this PropsBuilder<T> b) where T: IonRouterLink
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("medium"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorPrimary<T>(this PropsBuilder<T> b) where T: IonRouterLink
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("primary"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorSecondary<T>(this PropsBuilder<T> b) where T: IonRouterLink
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("secondary"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorSuccess<T>(this PropsBuilder<T> b) where T: IonRouterLink
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("success"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorTertiary<T>(this PropsBuilder<T> b) where T: IonRouterLink
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("tertiary"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorWarning<T>(this PropsBuilder<T> b) where T: IonRouterLink
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("warning"));
    }


    /// <summary>
    /// <para> Contains a URL or a URL fragment that the hyperlink points to. If this property is set, an anchor tag will be rendered. </para>
    /// </summary>
    public static void SetHref<T>(this PropsBuilder<T> b, Var<string> href) where T: IonRouterLink
    {
        b.SetProperty(b.Props, b.Const("href"), href);
    }

    /// <summary>
    /// <para> Contains a URL or a URL fragment that the hyperlink points to. If this property is set, an anchor tag will be rendered. </para>
    /// </summary>
    public static void SetHref<T>(this PropsBuilder<T> b, string href) where T: IonRouterLink
    {
        b.SetProperty(b.Props, b.Const("href"), b.Const(href));
    }


    /// <summary>
    /// <para> Specifies the relationship of the target object to the link object. The value is a space-separated list of [link types](https://developer.mozilla.org/en-US/docs/Web/HTML/Link_types). </para>
    /// </summary>
    public static void SetRel<T>(this PropsBuilder<T> b, Var<string> rel) where T: IonRouterLink
    {
        b.SetProperty(b.Props, b.Const("rel"), rel);
    }

    /// <summary>
    /// <para> Specifies the relationship of the target object to the link object. The value is a space-separated list of [link types](https://developer.mozilla.org/en-US/docs/Web/HTML/Link_types). </para>
    /// </summary>
    public static void SetRel<T>(this PropsBuilder<T> b, string rel) where T: IonRouterLink
    {
        b.SetProperty(b.Props, b.Const("rel"), b.Const(rel));
    }


    /// <summary>
    /// <para> When using a router, it specifies the transition animation when navigating to another page using `href`. </para>
    /// </summary>
    public static void SetRouterAnimation<T>(this PropsBuilder<T> b, Var<System.Func<DynamicObject,DynamicObject,Animation>> routerAnimation) where T: IonRouterLink
    {
        b.SetProperty(b.Props, b.Const("routerAnimation"), routerAnimation);
    }

    /// <summary>
    /// <para> When using a router, it specifies the transition animation when navigating to another page using `href`. </para>
    /// </summary>
    public static void SetRouterAnimation<T>(this PropsBuilder<T> b, System.Func<DynamicObject,DynamicObject,Animation> routerAnimation) where T: IonRouterLink
    {
        b.SetProperty(b.Props, b.Const("routerAnimation"), b.Const(routerAnimation));
    }


    /// <summary>
    /// <para> When using a router, it specifies the transition direction when navigating to another page using `href`. </para>
    /// </summary>
    public static void SetRouterDirectionBack<T>(this PropsBuilder<T> b) where T: IonRouterLink
    {
        b.SetProperty(b.Props, b.Const("routerDirection"), b.Const("back"));
    }


    /// <summary>
    /// <para> When using a router, it specifies the transition direction when navigating to another page using `href`. </para>
    /// </summary>
    public static void SetRouterDirectionForward<T>(this PropsBuilder<T> b) where T: IonRouterLink
    {
        b.SetProperty(b.Props, b.Const("routerDirection"), b.Const("forward"));
    }


    /// <summary>
    /// <para> When using a router, it specifies the transition direction when navigating to another page using `href`. </para>
    /// </summary>
    public static void SetRouterDirectionRoot<T>(this PropsBuilder<T> b) where T: IonRouterLink
    {
        b.SetProperty(b.Props, b.Const("routerDirection"), b.Const("root"));
    }


    /// <summary>
    /// <para> Specifies where to display the linked URL. Only applies when an `href` is provided. Special keywords: `"_blank"`, `"_self"`, `"_parent"`, `"_top"`. </para>
    /// </summary>
    public static void SetTarget<T>(this PropsBuilder<T> b, Var<string> target) where T: IonRouterLink
    {
        b.SetProperty(b.Props, b.Const("target"), target);
    }

    /// <summary>
    /// <para> Specifies where to display the linked URL. Only applies when an `href` is provided. Special keywords: `"_blank"`, `"_self"`, `"_parent"`, `"_top"`. </para>
    /// </summary>
    public static void SetTarget<T>(this PropsBuilder<T> b, string target) where T: IonRouterLink
    {
        b.SetProperty(b.Props, b.Const("target"), b.Const(target));
    }


}

