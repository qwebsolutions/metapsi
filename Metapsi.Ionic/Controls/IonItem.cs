using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Ionic;


public partial class IonItem
{
    /// <summary>
    /// <para> Content is placed between the named slots if provided without a slot. </para>
    /// </summary>
    public static class Slot
    {
        /// <summary>
        /// <para> Content is placed to the right of the item text in LTR, and to the left in RTL. </para>
        /// </summary>
        public const string End = "end";
        /// <summary>
        /// <para> Content is placed to the left of the item text in LTR, and to the right in RTL. </para>
        /// </summary>
        public const string Start = "start";
    }
}

public static partial class IonItemControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonItem(this HtmlBuilder b, Action<AttributesBuilder<IonItem>> buildAttributes, params IHtmlNode[] children)
    {
        return b.IonicTag("ion-item", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonItem(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.IonicTag("ion-item", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonItem(this HtmlBuilder b, Action<AttributesBuilder<IonItem>> buildAttributes, List<IHtmlNode> children)
    {
        return b.IonicTag("ion-item", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonItem(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.IonicTag("ion-item", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> If `true`, a button tag will be rendered and the item will be tappable. </para>
    /// </summary>
    public static void SetButton(this AttributesBuilder<IonItem> b)
    {
        b.SetAttribute("button", "");
    }

    /// <summary>
    /// <para> If `true`, a button tag will be rendered and the item will be tappable. </para>
    /// </summary>
    public static void SetButton(this AttributesBuilder<IonItem> b, bool button)
    {
        if (button) b.SetAttribute("button", "");
    }

    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColor(this AttributesBuilder<IonItem> b, string color)
    {
        b.SetAttribute("color", color);
    }

    /// <summary>
    /// <para> If `true`, a detail arrow will appear on the item. Defaults to `false` unless the `mode` is `ios` and an `href` or `button` property is present. </para>
    /// </summary>
    public static void SetDetail(this AttributesBuilder<IonItem> b)
    {
        b.SetAttribute("detail", "");
    }

    /// <summary>
    /// <para> If `true`, a detail arrow will appear on the item. Defaults to `false` unless the `mode` is `ios` and an `href` or `button` property is present. </para>
    /// </summary>
    public static void SetDetail(this AttributesBuilder<IonItem> b, bool detail)
    {
        if (detail) b.SetAttribute("detail", "");
    }

    /// <summary>
    /// <para> The icon to use when `detail` is set to `true`. </para>
    /// </summary>
    public static void SetDetailIcon(this AttributesBuilder<IonItem> b, string detailIcon)
    {
        b.SetAttribute("detail-icon", detailIcon);
    }

    /// <summary>
    /// <para> If `true`, the user cannot interact with the item. </para>
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<IonItem> b)
    {
        b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// <para> If `true`, the user cannot interact with the item. </para>
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<IonItem> b, bool disabled)
    {
        if (disabled) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// <para> This attribute instructs browsers to download a URL instead of navigating to it, so the user will be prompted to save it as a local file. If the attribute has a value, it is used as the pre-filled file name in the Save prompt (the user can still change the file name if they want). </para>
    /// </summary>
    public static void SetDownload(this AttributesBuilder<IonItem> b, string download)
    {
        b.SetAttribute("download", download);
    }

    /// <summary>
    /// <para> Contains a URL or a URL fragment that the hyperlink points to. If this property is set, an anchor tag will be rendered. </para>
    /// </summary>
    public static void SetHref(this AttributesBuilder<IonItem> b, string href)
    {
        b.SetAttribute("href", href);
    }

    /// <summary>
    /// <para> How the bottom border should be displayed on the item. </para>
    /// </summary>
    public static void SetLines(this AttributesBuilder<IonItem> b, string lines)
    {
        b.SetAttribute("lines", lines);
    }

    /// <summary>
    /// <para> How the bottom border should be displayed on the item. </para>
    /// </summary>
    public static void SetLinesFull(this AttributesBuilder<IonItem> b)
    {
        b.SetAttribute("lines", "full");
    }

    /// <summary>
    /// <para> How the bottom border should be displayed on the item. </para>
    /// </summary>
    public static void SetLinesInset(this AttributesBuilder<IonItem> b)
    {
        b.SetAttribute("lines", "inset");
    }

    /// <summary>
    /// <para> How the bottom border should be displayed on the item. </para>
    /// </summary>
    public static void SetLinesNone(this AttributesBuilder<IonItem> b)
    {
        b.SetAttribute("lines", "none");
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetMode(this AttributesBuilder<IonItem> b, string mode)
    {
        b.SetAttribute("mode", mode);
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeIos(this AttributesBuilder<IonItem> b)
    {
        b.SetAttribute("mode", "ios");
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeMd(this AttributesBuilder<IonItem> b)
    {
        b.SetAttribute("mode", "md");
    }

    /// <summary>
    /// <para> Specifies the relationship of the target object to the link object. The value is a space-separated list of [link types](https://developer.mozilla.org/en-US/docs/Web/HTML/Link_types). </para>
    /// </summary>
    public static void SetRel(this AttributesBuilder<IonItem> b, string rel)
    {
        b.SetAttribute("rel", rel);
    }

    /// <summary>
    /// <para> When using a router, it specifies the transition direction when navigating to another page using `href`. </para>
    /// </summary>
    public static void SetRouterDirection(this AttributesBuilder<IonItem> b, string routerDirection)
    {
        b.SetAttribute("router-direction", routerDirection);
    }

    /// <summary>
    /// <para> When using a router, it specifies the transition direction when navigating to another page using `href`. </para>
    /// </summary>
    public static void SetRouterDirectionBack(this AttributesBuilder<IonItem> b)
    {
        b.SetAttribute("router-direction", "back");
    }

    /// <summary>
    /// <para> When using a router, it specifies the transition direction when navigating to another page using `href`. </para>
    /// </summary>
    public static void SetRouterDirectionForward(this AttributesBuilder<IonItem> b)
    {
        b.SetAttribute("router-direction", "forward");
    }

    /// <summary>
    /// <para> When using a router, it specifies the transition direction when navigating to another page using `href`. </para>
    /// </summary>
    public static void SetRouterDirectionRoot(this AttributesBuilder<IonItem> b)
    {
        b.SetAttribute("router-direction", "root");
    }

    /// <summary>
    /// <para> Specifies where to display the linked URL. Only applies when an `href` is provided. Special keywords: `"_blank"`, `"_self"`, `"_parent"`, `"_top"`. </para>
    /// </summary>
    public static void SetTarget(this AttributesBuilder<IonItem> b, string target)
    {
        b.SetAttribute("target", target);
    }

    /// <summary>
    /// <para> The type of the button. Only used when an `onclick` or `button` property is present. </para>
    /// </summary>
    public static void SetType(this AttributesBuilder<IonItem> b, string type)
    {
        b.SetAttribute("type", type);
    }

    /// <summary>
    /// <para> The type of the button. Only used when an `onclick` or `button` property is present. </para>
    /// </summary>
    public static void SetTypeButton(this AttributesBuilder<IonItem> b)
    {
        b.SetAttribute("type", "button");
    }

    /// <summary>
    /// <para> The type of the button. Only used when an `onclick` or `button` property is present. </para>
    /// </summary>
    public static void SetTypeReset(this AttributesBuilder<IonItem> b)
    {
        b.SetAttribute("type", "reset");
    }

    /// <summary>
    /// <para> The type of the button. Only used when an `onclick` or `button` property is present. </para>
    /// </summary>
    public static void SetTypeSubmit(this AttributesBuilder<IonItem> b)
    {
        b.SetAttribute("type", "submit");
    }

    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonItem(this LayoutBuilder b, Action<PropsBuilder<IonItem>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-item", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonItem(this LayoutBuilder b, Action<PropsBuilder<IonItem>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-item", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonItem(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-item", children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonItem(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-item", children);
    }
    /// <summary>
    /// <para> If `true`, a button tag will be rendered and the item will be tappable. </para>
    /// </summary>
    public static void SetButton<T>(this PropsBuilder<T> b) where T: IonItem
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("button"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, a button tag will be rendered and the item will be tappable. </para>
    /// </summary>
    public static void SetButton<T>(this PropsBuilder<T> b, Var<bool> button) where T: IonItem
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("button"), button);
    }

    /// <summary>
    /// <para> If `true`, a button tag will be rendered and the item will be tappable. </para>
    /// </summary>
    public static void SetButton<T>(this PropsBuilder<T> b, bool button) where T: IonItem
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("button"), b.Const(button));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorDanger<T>(this PropsBuilder<T> b) where T: IonItem
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("danger"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorDark<T>(this PropsBuilder<T> b) where T: IonItem
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("dark"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorLight<T>(this PropsBuilder<T> b) where T: IonItem
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("light"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorMedium<T>(this PropsBuilder<T> b) where T: IonItem
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("medium"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorPrimary<T>(this PropsBuilder<T> b) where T: IonItem
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("primary"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorSecondary<T>(this PropsBuilder<T> b) where T: IonItem
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("secondary"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorSuccess<T>(this PropsBuilder<T> b) where T: IonItem
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("success"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorTertiary<T>(this PropsBuilder<T> b) where T: IonItem
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("tertiary"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorWarning<T>(this PropsBuilder<T> b) where T: IonItem
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("warning"));
    }


    /// <summary>
    /// <para> If `true`, a detail arrow will appear on the item. Defaults to `false` unless the `mode` is `ios` and an `href` or `button` property is present. </para>
    /// </summary>
    public static void SetDetail<T>(this PropsBuilder<T> b) where T: IonItem
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("detail"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, a detail arrow will appear on the item. Defaults to `false` unless the `mode` is `ios` and an `href` or `button` property is present. </para>
    /// </summary>
    public static void SetDetail<T>(this PropsBuilder<T> b, Var<bool> detail) where T: IonItem
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("detail"), detail);
    }

    /// <summary>
    /// <para> If `true`, a detail arrow will appear on the item. Defaults to `false` unless the `mode` is `ios` and an `href` or `button` property is present. </para>
    /// </summary>
    public static void SetDetail<T>(this PropsBuilder<T> b, bool detail) where T: IonItem
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("detail"), b.Const(detail));
    }


    /// <summary>
    /// <para> The icon to use when `detail` is set to `true`. </para>
    /// </summary>
    public static void SetDetailIcon<T>(this PropsBuilder<T> b, Var<string> detailIcon) where T: IonItem
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("detailIcon"), detailIcon);
    }

    /// <summary>
    /// <para> The icon to use when `detail` is set to `true`. </para>
    /// </summary>
    public static void SetDetailIcon<T>(this PropsBuilder<T> b, string detailIcon) where T: IonItem
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("detailIcon"), b.Const(detailIcon));
    }


    /// <summary>
    /// <para> If `true`, the user cannot interact with the item. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b) where T: IonItem
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, the user cannot interact with the item. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, Var<bool> disabled) where T: IonItem
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), disabled);
    }

    /// <summary>
    /// <para> If `true`, the user cannot interact with the item. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, bool disabled) where T: IonItem
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), b.Const(disabled));
    }


    /// <summary>
    /// <para> This attribute instructs browsers to download a URL instead of navigating to it, so the user will be prompted to save it as a local file. If the attribute has a value, it is used as the pre-filled file name in the Save prompt (the user can still change the file name if they want). </para>
    /// </summary>
    public static void SetDownload<T>(this PropsBuilder<T> b, Var<string> download) where T: IonItem
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("download"), download);
    }

    /// <summary>
    /// <para> This attribute instructs browsers to download a URL instead of navigating to it, so the user will be prompted to save it as a local file. If the attribute has a value, it is used as the pre-filled file name in the Save prompt (the user can still change the file name if they want). </para>
    /// </summary>
    public static void SetDownload<T>(this PropsBuilder<T> b, string download) where T: IonItem
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("download"), b.Const(download));
    }


    /// <summary>
    /// <para> Contains a URL or a URL fragment that the hyperlink points to. If this property is set, an anchor tag will be rendered. </para>
    /// </summary>
    public static void SetHref<T>(this PropsBuilder<T> b, Var<string> href) where T: IonItem
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("href"), href);
    }

    /// <summary>
    /// <para> Contains a URL or a URL fragment that the hyperlink points to. If this property is set, an anchor tag will be rendered. </para>
    /// </summary>
    public static void SetHref<T>(this PropsBuilder<T> b, string href) where T: IonItem
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("href"), b.Const(href));
    }


    /// <summary>
    /// <para> How the bottom border should be displayed on the item. </para>
    /// </summary>
    public static void SetLinesFull<T>(this PropsBuilder<T> b) where T: IonItem
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("lines"), b.Const("full"));
    }


    /// <summary>
    /// <para> How the bottom border should be displayed on the item. </para>
    /// </summary>
    public static void SetLinesInset<T>(this PropsBuilder<T> b) where T: IonItem
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("lines"), b.Const("inset"));
    }


    /// <summary>
    /// <para> How the bottom border should be displayed on the item. </para>
    /// </summary>
    public static void SetLinesNone<T>(this PropsBuilder<T> b) where T: IonItem
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("lines"), b.Const("none"));
    }


    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeIos<T>(this PropsBuilder<T> b) where T: IonItem
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("mode"), b.Const("ios"));
    }


    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeMd<T>(this PropsBuilder<T> b) where T: IonItem
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("mode"), b.Const("md"));
    }


    /// <summary>
    /// <para> Specifies the relationship of the target object to the link object. The value is a space-separated list of [link types](https://developer.mozilla.org/en-US/docs/Web/HTML/Link_types). </para>
    /// </summary>
    public static void SetRel<T>(this PropsBuilder<T> b, Var<string> rel) where T: IonItem
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("rel"), rel);
    }

    /// <summary>
    /// <para> Specifies the relationship of the target object to the link object. The value is a space-separated list of [link types](https://developer.mozilla.org/en-US/docs/Web/HTML/Link_types). </para>
    /// </summary>
    public static void SetRel<T>(this PropsBuilder<T> b, string rel) where T: IonItem
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("rel"), b.Const(rel));
    }


    /// <summary>
    /// <para> When using a router, it specifies the transition animation when navigating to another page using `href`. </para>
    /// </summary>
    public static void SetRouterAnimation<T>(this PropsBuilder<T> b, Var<System.Func<object,object,Animation>> routerAnimation) where T: IonItem
    {
        b.SetDynamic(b.Props, new DynamicProperty<System.Func<object,object,Animation>>("routerAnimation"), routerAnimation);
    }

    /// <summary>
    /// <para> When using a router, it specifies the transition animation when navigating to another page using `href`. </para>
    /// </summary>
    public static void SetRouterAnimation<T>(this PropsBuilder<T> b, System.Func<object,object,Animation> routerAnimation) where T: IonItem
    {
        b.SetDynamic(b.Props, new DynamicProperty<System.Func<object,object,Animation>>("routerAnimation"), b.Const(routerAnimation));
    }


    /// <summary>
    /// <para> When using a router, it specifies the transition direction when navigating to another page using `href`. </para>
    /// </summary>
    public static void SetRouterDirectionBack<T>(this PropsBuilder<T> b) where T: IonItem
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("routerDirection"), b.Const("back"));
    }


    /// <summary>
    /// <para> When using a router, it specifies the transition direction when navigating to another page using `href`. </para>
    /// </summary>
    public static void SetRouterDirectionForward<T>(this PropsBuilder<T> b) where T: IonItem
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("routerDirection"), b.Const("forward"));
    }


    /// <summary>
    /// <para> When using a router, it specifies the transition direction when navigating to another page using `href`. </para>
    /// </summary>
    public static void SetRouterDirectionRoot<T>(this PropsBuilder<T> b) where T: IonItem
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("routerDirection"), b.Const("root"));
    }


    /// <summary>
    /// <para> Specifies where to display the linked URL. Only applies when an `href` is provided. Special keywords: `"_blank"`, `"_self"`, `"_parent"`, `"_top"`. </para>
    /// </summary>
    public static void SetTarget<T>(this PropsBuilder<T> b, Var<string> target) where T: IonItem
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("target"), target);
    }

    /// <summary>
    /// <para> Specifies where to display the linked URL. Only applies when an `href` is provided. Special keywords: `"_blank"`, `"_self"`, `"_parent"`, `"_top"`. </para>
    /// </summary>
    public static void SetTarget<T>(this PropsBuilder<T> b, string target) where T: IonItem
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("target"), b.Const(target));
    }


    /// <summary>
    /// <para> The type of the button. Only used when an `onclick` or `button` property is present. </para>
    /// </summary>
    public static void SetTypeButton<T>(this PropsBuilder<T> b) where T: IonItem
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("type"), b.Const("button"));
    }


    /// <summary>
    /// <para> The type of the button. Only used when an `onclick` or `button` property is present. </para>
    /// </summary>
    public static void SetTypeReset<T>(this PropsBuilder<T> b) where T: IonItem
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("type"), b.Const("reset"));
    }


    /// <summary>
    /// <para> The type of the button. Only used when an `onclick` or `button` property is present. </para>
    /// </summary>
    public static void SetTypeSubmit<T>(this PropsBuilder<T> b) where T: IonItem
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("type"), b.Const("submit"));
    }


}

