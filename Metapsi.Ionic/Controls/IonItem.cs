using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Ionic;


public partial class IonItem : IonComponent
{
    public IonItem() : base("ion-item") { }
    /// <summary> 
    /// Content is placed between the named slots if provided without a slot.
    /// </summary>
    public static class Slot
    {
        /// <summary> 
        /// Content is placed to the right of the item text in LTR, and to the left in RTL.
        /// </summary>
        public const string End = "end";
        /// <summary> 
        /// Content is placed to the left of the item text in LTR, and to the right in RTL.
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
        return b.Tag("ion-item", buildAttributes, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static IHtmlNode IonItem(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("ion-item", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// If `true`, a button tag will be rendered and the item will be tappable.
    /// </summary>
    public static void SetButton(this AttributesBuilder<IonItem> b)
    {
        b.SetAttribute("button", "");
    }
    /// <summary>
    /// If `true`, a button tag will be rendered and the item will be tappable.
    /// </summary>
    public static void SetButton(this AttributesBuilder<IonItem> b, bool value)
    {
        if (value) b.SetAttribute("button", "");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor(this AttributesBuilder<IonItem> b, string value)
    {
        b.SetAttribute("color", value);
    }

    /// <summary>
    /// If `true`, a detail arrow will appear on the item. Defaults to `false` unless the `mode` is `ios` and an `href` or `button` property is present.
    /// </summary>
    public static void SetDetail(this AttributesBuilder<IonItem> b)
    {
        b.SetAttribute("detail", "");
    }
    /// <summary>
    /// If `true`, a detail arrow will appear on the item. Defaults to `false` unless the `mode` is `ios` and an `href` or `button` property is present.
    /// </summary>
    public static void SetDetail(this AttributesBuilder<IonItem> b, bool value)
    {
        if (value) b.SetAttribute("detail", "");
    }

    /// <summary>
    /// The icon to use when `detail` is set to `true`.
    /// </summary>
    public static void SetDetailIcon(this AttributesBuilder<IonItem> b, string value)
    {
        b.SetAttribute("detail-icon", value);
    }

    /// <summary>
    /// If `true`, the user cannot interact with the item.
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<IonItem> b)
    {
        b.SetAttribute("disabled", "");
    }
    /// <summary>
    /// If `true`, the user cannot interact with the item.
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<IonItem> b, bool value)
    {
        if (value) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// This attribute instructs browsers to download a URL instead of navigating to it, so the user will be prompted to save it as a local file. If the attribute has a value, it is used as the pre-filled file name in the Save prompt (the user can still change the file name if they want).
    /// </summary>
    public static void SetDownload(this AttributesBuilder<IonItem> b, string value)
    {
        b.SetAttribute("download", value);
    }

    /// <summary>
    /// Contains a URL or a URL fragment that the hyperlink points to. If this property is set, an anchor tag will be rendered.
    /// </summary>
    public static void SetHref(this AttributesBuilder<IonItem> b, string value)
    {
        b.SetAttribute("href", value);
    }

    /// <summary>
    /// How the bottom border should be displayed on the item.
    /// </summary>
    public static void SetLines(this AttributesBuilder<IonItem> b, string value)
    {
        b.SetAttribute("lines", value);
    }
    /// <summary>
    /// How the bottom border should be displayed on the item.
    /// </summary>
    public static void SetLinesFull(this AttributesBuilder<IonItem> b)
    {
        b.SetAttribute("lines", "full");
    }
    /// <summary>
    /// How the bottom border should be displayed on the item.
    /// </summary>
    public static void SetLinesInset(this AttributesBuilder<IonItem> b)
    {
        b.SetAttribute("lines", "inset");
    }
    /// <summary>
    /// How the bottom border should be displayed on the item.
    /// </summary>
    public static void SetLinesNone(this AttributesBuilder<IonItem> b)
    {
        b.SetAttribute("lines", "none");
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetMode(this AttributesBuilder<IonItem> b, string value)
    {
        b.SetAttribute("mode", value);
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos(this AttributesBuilder<IonItem> b)
    {
        b.SetAttribute("mode", "ios");
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd(this AttributesBuilder<IonItem> b)
    {
        b.SetAttribute("mode", "md");
    }

    /// <summary>
    /// Specifies the relationship of the target object to the link object. The value is a space-separated list of [link types](https://developer.mozilla.org/en-US/docs/Web/HTML/Link_types).
    /// </summary>
    public static void SetRel(this AttributesBuilder<IonItem> b, string value)
    {
        b.SetAttribute("rel", value);
    }

    /// <summary>
    /// When using a router, it specifies the transition direction when navigating to another page using `href`.
    /// </summary>
    public static void SetRouterDirection(this AttributesBuilder<IonItem> b, string value)
    {
        b.SetAttribute("router-direction", value);
    }
    /// <summary>
    /// When using a router, it specifies the transition direction when navigating to another page using `href`.
    /// </summary>
    public static void SetRouterDirectionBack(this AttributesBuilder<IonItem> b)
    {
        b.SetAttribute("router-direction", "back");
    }
    /// <summary>
    /// When using a router, it specifies the transition direction when navigating to another page using `href`.
    /// </summary>
    public static void SetRouterDirectionForward(this AttributesBuilder<IonItem> b)
    {
        b.SetAttribute("router-direction", "forward");
    }
    /// <summary>
    /// When using a router, it specifies the transition direction when navigating to another page using `href`.
    /// </summary>
    public static void SetRouterDirectionRoot(this AttributesBuilder<IonItem> b)
    {
        b.SetAttribute("router-direction", "root");
    }

    /// <summary>
    /// Specifies where to display the linked URL. Only applies when an `href` is provided. Special keywords: `"_blank"`, `"_self"`, `"_parent"`, `"_top"`.
    /// </summary>
    public static void SetTarget(this AttributesBuilder<IonItem> b, string value)
    {
        b.SetAttribute("target", value);
    }

    /// <summary>
    /// The type of the button. Only used when an `onclick` or `button` property is present.
    /// </summary>
    public static void SetType(this AttributesBuilder<IonItem> b, string value)
    {
        b.SetAttribute("type", value);
    }
    /// <summary>
    /// The type of the button. Only used when an `onclick` or `button` property is present.
    /// </summary>
    public static void SetTypeButton(this AttributesBuilder<IonItem> b)
    {
        b.SetAttribute("type", "button");
    }
    /// <summary>
    /// The type of the button. Only used when an `onclick` or `button` property is present.
    /// </summary>
    public static void SetTypeReset(this AttributesBuilder<IonItem> b)
    {
        b.SetAttribute("type", "reset");
    }
    /// <summary>
    /// The type of the button. Only used when an `onclick` or `button` property is present.
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
    /// If `true`, a button tag will be rendered and the item will be tappable.
    /// </summary>
    public static void SetButton<T>(this PropsBuilder<T> b) where T: IonItem
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("button"), b.Const(true));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDanger<T>(this PropsBuilder<T> b) where T: IonItem
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("danger"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDark<T>(this PropsBuilder<T> b) where T: IonItem
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("dark"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorLight<T>(this PropsBuilder<T> b) where T: IonItem
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("light"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorMedium<T>(this PropsBuilder<T> b) where T: IonItem
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("medium"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorPrimary<T>(this PropsBuilder<T> b) where T: IonItem
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("primary"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSecondary<T>(this PropsBuilder<T> b) where T: IonItem
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("secondary"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSuccess<T>(this PropsBuilder<T> b) where T: IonItem
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("success"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorTertiary<T>(this PropsBuilder<T> b) where T: IonItem
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("tertiary"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorWarning<T>(this PropsBuilder<T> b) where T: IonItem
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("warning"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor<T>(this PropsBuilder<T> b, Var<string> value) where T: IonItem
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), value);
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor<T>(this PropsBuilder<T> b, string value) where T: IonItem
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const(value));
    }

    /// <summary>
    /// If `true`, a detail arrow will appear on the item. Defaults to `false` unless the `mode` is `ios` and an `href` or `button` property is present.
    /// </summary>
    public static void SetDetail<T>(this PropsBuilder<T> b) where T: IonItem
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("detail"), b.Const(true));
    }

    /// <summary>
    /// The icon to use when `detail` is set to `true`.
    /// </summary>
    public static void SetDetailIcon<T>(this PropsBuilder<T> b, Var<string> value) where T: IonItem
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("detailIcon"), value);
    }
    /// <summary>
    /// The icon to use when `detail` is set to `true`.
    /// </summary>
    public static void SetDetailIcon<T>(this PropsBuilder<T> b, string value) where T: IonItem
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("detailIcon"), b.Const(value));
    }

    /// <summary>
    /// If `true`, the user cannot interact with the item.
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b) where T: IonItem
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("disabled"), b.Const(true));
    }

    /// <summary>
    /// This attribute instructs browsers to download a URL instead of navigating to it, so the user will be prompted to save it as a local file. If the attribute has a value, it is used as the pre-filled file name in the Save prompt (the user can still change the file name if they want).
    /// </summary>
    public static void SetDownload<T>(this PropsBuilder<T> b, Var<string> value) where T: IonItem
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("download"), value);
    }
    /// <summary>
    /// This attribute instructs browsers to download a URL instead of navigating to it, so the user will be prompted to save it as a local file. If the attribute has a value, it is used as the pre-filled file name in the Save prompt (the user can still change the file name if they want).
    /// </summary>
    public static void SetDownload<T>(this PropsBuilder<T> b, string value) where T: IonItem
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("download"), b.Const(value));
    }

    /// <summary>
    /// Contains a URL or a URL fragment that the hyperlink points to. If this property is set, an anchor tag will be rendered.
    /// </summary>
    public static void SetHref<T>(this PropsBuilder<T> b, Var<string> value) where T: IonItem
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("href"), value);
    }
    /// <summary>
    /// Contains a URL or a URL fragment that the hyperlink points to. If this property is set, an anchor tag will be rendered.
    /// </summary>
    public static void SetHref<T>(this PropsBuilder<T> b, string value) where T: IonItem
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("href"), b.Const(value));
    }

    /// <summary>
    /// How the bottom border should be displayed on the item.
    /// </summary>
    public static void SetLinesFull<T>(this PropsBuilder<T> b) where T: IonItem
    {
        b.SetDynamic(b.Props, DynamicProperty.String("lines"), b.Const("full"));
    }
    /// <summary>
    /// How the bottom border should be displayed on the item.
    /// </summary>
    public static void SetLinesInset<T>(this PropsBuilder<T> b) where T: IonItem
    {
        b.SetDynamic(b.Props, DynamicProperty.String("lines"), b.Const("inset"));
    }
    /// <summary>
    /// How the bottom border should be displayed on the item.
    /// </summary>
    public static void SetLinesNone<T>(this PropsBuilder<T> b) where T: IonItem
    {
        b.SetDynamic(b.Props, DynamicProperty.String("lines"), b.Const("none"));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos<T>(this PropsBuilder<T> b) where T: IonItem
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("ios"));
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd<T>(this PropsBuilder<T> b) where T: IonItem
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("md"));
    }

    /// <summary>
    /// Specifies the relationship of the target object to the link object. The value is a space-separated list of [link types](https://developer.mozilla.org/en-US/docs/Web/HTML/Link_types).
    /// </summary>
    public static void SetRel<T>(this PropsBuilder<T> b, Var<string> value) where T: IonItem
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("rel"), value);
    }
    /// <summary>
    /// Specifies the relationship of the target object to the link object. The value is a space-separated list of [link types](https://developer.mozilla.org/en-US/docs/Web/HTML/Link_types).
    /// </summary>
    public static void SetRel<T>(this PropsBuilder<T> b, string value) where T: IonItem
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("rel"), b.Const(value));
    }

    /// <summary>
    /// When using a router, it specifies the transition animation when navigating to another page using `href`.
    /// </summary>
    public static void SetRouterAnimation<T>(this PropsBuilder<T> b, Var<Func<object,object,Animation>> f) where T: IonItem
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<object,object,Animation>>("routerAnimation"), f);
    }
    /// <summary>
    /// When using a router, it specifies the transition animation when navigating to another page using `href`.
    /// </summary>
    public static void SetRouterAnimation<T>(this PropsBuilder<T> b, Func<SyntaxBuilder,Var<object>,Var<object>,Var<Animation>> f) where T: IonItem
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<object,object,Animation>>("routerAnimation"), b.Def(f));
    }

    /// <summary>
    /// When using a router, it specifies the transition direction when navigating to another page using `href`.
    /// </summary>
    public static void SetRouterDirectionBack<T>(this PropsBuilder<T> b) where T: IonItem
    {
        b.SetDynamic(b.Props, DynamicProperty.String("routerDirection"), b.Const("back"));
    }
    /// <summary>
    /// When using a router, it specifies the transition direction when navigating to another page using `href`.
    /// </summary>
    public static void SetRouterDirectionForward<T>(this PropsBuilder<T> b) where T: IonItem
    {
        b.SetDynamic(b.Props, DynamicProperty.String("routerDirection"), b.Const("forward"));
    }
    /// <summary>
    /// When using a router, it specifies the transition direction when navigating to another page using `href`.
    /// </summary>
    public static void SetRouterDirectionRoot<T>(this PropsBuilder<T> b) where T: IonItem
    {
        b.SetDynamic(b.Props, DynamicProperty.String("routerDirection"), b.Const("root"));
    }

    /// <summary>
    /// Specifies where to display the linked URL. Only applies when an `href` is provided. Special keywords: `"_blank"`, `"_self"`, `"_parent"`, `"_top"`.
    /// </summary>
    public static void SetTarget<T>(this PropsBuilder<T> b, Var<string> value) where T: IonItem
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("target"), value);
    }
    /// <summary>
    /// Specifies where to display the linked URL. Only applies when an `href` is provided. Special keywords: `"_blank"`, `"_self"`, `"_parent"`, `"_top"`.
    /// </summary>
    public static void SetTarget<T>(this PropsBuilder<T> b, string value) where T: IonItem
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("target"), b.Const(value));
    }

    /// <summary>
    /// The type of the button. Only used when an `onclick` or `button` property is present.
    /// </summary>
    public static void SetTypeButton<T>(this PropsBuilder<T> b) where T: IonItem
    {
        b.SetDynamic(b.Props, DynamicProperty.String("type"), b.Const("button"));
    }
    /// <summary>
    /// The type of the button. Only used when an `onclick` or `button` property is present.
    /// </summary>
    public static void SetTypeReset<T>(this PropsBuilder<T> b) where T: IonItem
    {
        b.SetDynamic(b.Props, DynamicProperty.String("type"), b.Const("reset"));
    }
    /// <summary>
    /// The type of the button. Only used when an `onclick` or `button` property is present.
    /// </summary>
    public static void SetTypeSubmit<T>(this PropsBuilder<T> b) where T: IonItem
    {
        b.SetDynamic(b.Props, DynamicProperty.String("type"), b.Const("submit"));
    }

}

