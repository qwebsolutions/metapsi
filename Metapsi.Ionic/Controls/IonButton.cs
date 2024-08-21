using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Ionic;


public partial class IonButton
{
    /// <summary>
    /// <para> Content is placed between the named slots if provided without a slot. </para>
    /// </summary>
    public static class Slot
    {
        /// <summary>
        /// <para> Content is placed to the right of the button text in LTR, and to the left in RTL. </para>
        /// </summary>
        public const string End = "end";
        /// <summary>
        /// <para> Should be used on an icon in a button that has no text. </para>
        /// </summary>
        public const string IconOnly = "icon-only";
        /// <summary>
        /// <para> Content is placed to the left of the button text in LTR, and to the right in RTL. </para>
        /// </summary>
        public const string Start = "start";
    }
}

public static partial class IonButtonControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonButton(this HtmlBuilder b, Action<AttributesBuilder<IonButton>> buildAttributes, params IHtmlNode[] children)
    {
        return b.IonicTag("ion-button", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonButton(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.IonicTag("ion-button", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonButton(this HtmlBuilder b, Action<AttributesBuilder<IonButton>> buildAttributes, List<IHtmlNode> children)
    {
        return b.IonicTag("ion-button", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonButton(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.IonicTag("ion-button", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The type of button. </para>
    /// </summary>
    public static void SetButtonType(this AttributesBuilder<IonButton> b, string buttonType)
    {
        b.SetAttribute("button-type", buttonType);
    }

    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColor(this AttributesBuilder<IonButton> b, string color)
    {
        b.SetAttribute("color", color);
    }

    /// <summary>
    /// <para> If `true`, the user cannot interact with the button. </para>
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<IonButton> b)
    {
        b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// <para> If `true`, the user cannot interact with the button. </para>
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<IonButton> b, bool disabled)
    {
        if (disabled) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// <para> This attribute instructs browsers to download a URL instead of navigating to it, so the user will be prompted to save it as a local file. If the attribute has a value, it is used as the pre-filled file name in the Save prompt (the user can still change the file name if they want). </para>
    /// </summary>
    public static void SetDownload(this AttributesBuilder<IonButton> b, string download)
    {
        b.SetAttribute("download", download);
    }

    /// <summary>
    /// <para> Set to `"block"` for a full-width button or to `"full"` for a full-width button with square corners and no left or right borders. </para>
    /// </summary>
    public static void SetExpand(this AttributesBuilder<IonButton> b, string expand)
    {
        b.SetAttribute("expand", expand);
    }

    /// <summary>
    /// <para> Set to `"block"` for a full-width button or to `"full"` for a full-width button with square corners and no left or right borders. </para>
    /// </summary>
    public static void SetExpandBlock(this AttributesBuilder<IonButton> b)
    {
        b.SetAttribute("expand", "block");
    }

    /// <summary>
    /// <para> Set to `"block"` for a full-width button or to `"full"` for a full-width button with square corners and no left or right borders. </para>
    /// </summary>
    public static void SetExpandFull(this AttributesBuilder<IonButton> b)
    {
        b.SetAttribute("expand", "full");
    }

    /// <summary>
    /// <para> Set to `"clear"` for a transparent button that resembles a flat button, to `"outline"` for a transparent button with a border, or to `"solid"` for a button with a filled background. The default fill is `"solid"` except inside of a toolbar, where the default is `"clear"`. </para>
    /// </summary>
    public static void SetFill(this AttributesBuilder<IonButton> b, string fill)
    {
        b.SetAttribute("fill", fill);
    }

    /// <summary>
    /// <para> Set to `"clear"` for a transparent button that resembles a flat button, to `"outline"` for a transparent button with a border, or to `"solid"` for a button with a filled background. The default fill is `"solid"` except inside of a toolbar, where the default is `"clear"`. </para>
    /// </summary>
    public static void SetFillClear(this AttributesBuilder<IonButton> b)
    {
        b.SetAttribute("fill", "clear");
    }

    /// <summary>
    /// <para> Set to `"clear"` for a transparent button that resembles a flat button, to `"outline"` for a transparent button with a border, or to `"solid"` for a button with a filled background. The default fill is `"solid"` except inside of a toolbar, where the default is `"clear"`. </para>
    /// </summary>
    public static void SetFillDefault(this AttributesBuilder<IonButton> b)
    {
        b.SetAttribute("fill", "default");
    }

    /// <summary>
    /// <para> Set to `"clear"` for a transparent button that resembles a flat button, to `"outline"` for a transparent button with a border, or to `"solid"` for a button with a filled background. The default fill is `"solid"` except inside of a toolbar, where the default is `"clear"`. </para>
    /// </summary>
    public static void SetFillOutline(this AttributesBuilder<IonButton> b)
    {
        b.SetAttribute("fill", "outline");
    }

    /// <summary>
    /// <para> Set to `"clear"` for a transparent button that resembles a flat button, to `"outline"` for a transparent button with a border, or to `"solid"` for a button with a filled background. The default fill is `"solid"` except inside of a toolbar, where the default is `"clear"`. </para>
    /// </summary>
    public static void SetFillSolid(this AttributesBuilder<IonButton> b)
    {
        b.SetAttribute("fill", "solid");
    }

    /// <summary>
    /// <para> The HTML form element or form element id. Used to submit a form when the button is not a child of the form. </para>
    /// </summary>
    public static void SetForm(this AttributesBuilder<IonButton> b, string form)
    {
        b.SetAttribute("form", form);
    }

    /// <summary>
    /// <para> Contains a URL or a URL fragment that the hyperlink points to. If this property is set, an anchor tag will be rendered. </para>
    /// </summary>
    public static void SetHref(this AttributesBuilder<IonButton> b, string href)
    {
        b.SetAttribute("href", href);
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetMode(this AttributesBuilder<IonButton> b, string mode)
    {
        b.SetAttribute("mode", mode);
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeIos(this AttributesBuilder<IonButton> b)
    {
        b.SetAttribute("mode", "ios");
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeMd(this AttributesBuilder<IonButton> b)
    {
        b.SetAttribute("mode", "md");
    }

    /// <summary>
    /// <para> Specifies the relationship of the target object to the link object. The value is a space-separated list of [link types](https://developer.mozilla.org/en-US/docs/Web/HTML/Link_types). </para>
    /// </summary>
    public static void SetRel(this AttributesBuilder<IonButton> b, string rel)
    {
        b.SetAttribute("rel", rel);
    }

    /// <summary>
    /// <para> When using a router, it specifies the transition direction when navigating to another page using `href`. </para>
    /// </summary>
    public static void SetRouterDirection(this AttributesBuilder<IonButton> b, string routerDirection)
    {
        b.SetAttribute("router-direction", routerDirection);
    }

    /// <summary>
    /// <para> When using a router, it specifies the transition direction when navigating to another page using `href`. </para>
    /// </summary>
    public static void SetRouterDirectionBack(this AttributesBuilder<IonButton> b)
    {
        b.SetAttribute("router-direction", "back");
    }

    /// <summary>
    /// <para> When using a router, it specifies the transition direction when navigating to another page using `href`. </para>
    /// </summary>
    public static void SetRouterDirectionForward(this AttributesBuilder<IonButton> b)
    {
        b.SetAttribute("router-direction", "forward");
    }

    /// <summary>
    /// <para> When using a router, it specifies the transition direction when navigating to another page using `href`. </para>
    /// </summary>
    public static void SetRouterDirectionRoot(this AttributesBuilder<IonButton> b)
    {
        b.SetAttribute("router-direction", "root");
    }

    /// <summary>
    /// <para> Set to `"round"` for a button with more rounded corners. </para>
    /// </summary>
    public static void SetShape(this AttributesBuilder<IonButton> b, string shape)
    {
        b.SetAttribute("shape", shape);
    }

    /// <summary>
    /// <para> Set to `"round"` for a button with more rounded corners. </para>
    /// </summary>
    public static void SetShapeRound(this AttributesBuilder<IonButton> b)
    {
        b.SetAttribute("shape", "round");
    }

    /// <summary>
    /// <para> Set to `"small"` for a button with less height and padding, to `"default"` for a button with the default height and padding, or to `"large"` for a button with more height and padding. By default the size is unset, unless the button is inside of an item, where the size is `"small"` by default. Set the size to `"default"` inside of an item to make it a standard size button. </para>
    /// </summary>
    public static void SetSize(this AttributesBuilder<IonButton> b, string size)
    {
        b.SetAttribute("size", size);
    }

    /// <summary>
    /// <para> Set to `"small"` for a button with less height and padding, to `"default"` for a button with the default height and padding, or to `"large"` for a button with more height and padding. By default the size is unset, unless the button is inside of an item, where the size is `"small"` by default. Set the size to `"default"` inside of an item to make it a standard size button. </para>
    /// </summary>
    public static void SetSizeDefault(this AttributesBuilder<IonButton> b)
    {
        b.SetAttribute("size", "default");
    }

    /// <summary>
    /// <para> Set to `"small"` for a button with less height and padding, to `"default"` for a button with the default height and padding, or to `"large"` for a button with more height and padding. By default the size is unset, unless the button is inside of an item, where the size is `"small"` by default. Set the size to `"default"` inside of an item to make it a standard size button. </para>
    /// </summary>
    public static void SetSizeLarge(this AttributesBuilder<IonButton> b)
    {
        b.SetAttribute("size", "large");
    }

    /// <summary>
    /// <para> Set to `"small"` for a button with less height and padding, to `"default"` for a button with the default height and padding, or to `"large"` for a button with more height and padding. By default the size is unset, unless the button is inside of an item, where the size is `"small"` by default. Set the size to `"default"` inside of an item to make it a standard size button. </para>
    /// </summary>
    public static void SetSizeSmall(this AttributesBuilder<IonButton> b)
    {
        b.SetAttribute("size", "small");
    }

    /// <summary>
    /// <para> If `true`, activates a button with a heavier font weight. </para>
    /// </summary>
    public static void SetStrong(this AttributesBuilder<IonButton> b)
    {
        b.SetAttribute("strong", "");
    }

    /// <summary>
    /// <para> If `true`, activates a button with a heavier font weight. </para>
    /// </summary>
    public static void SetStrong(this AttributesBuilder<IonButton> b, bool strong)
    {
        if (strong) b.SetAttribute("strong", "");
    }

    /// <summary>
    /// <para> Specifies where to display the linked URL. Only applies when an `href` is provided. Special keywords: `"_blank"`, `"_self"`, `"_parent"`, `"_top"`. </para>
    /// </summary>
    public static void SetTarget(this AttributesBuilder<IonButton> b, string target)
    {
        b.SetAttribute("target", target);
    }

    /// <summary>
    /// <para> The type of the button. </para>
    /// </summary>
    public static void SetType(this AttributesBuilder<IonButton> b, string type)
    {
        b.SetAttribute("type", type);
    }

    /// <summary>
    /// <para> The type of the button. </para>
    /// </summary>
    public static void SetTypeButton(this AttributesBuilder<IonButton> b)
    {
        b.SetAttribute("type", "button");
    }

    /// <summary>
    /// <para> The type of the button. </para>
    /// </summary>
    public static void SetTypeReset(this AttributesBuilder<IonButton> b)
    {
        b.SetAttribute("type", "reset");
    }

    /// <summary>
    /// <para> The type of the button. </para>
    /// </summary>
    public static void SetTypeSubmit(this AttributesBuilder<IonButton> b)
    {
        b.SetAttribute("type", "submit");
    }

    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonButton(this LayoutBuilder b, Action<PropsBuilder<IonButton>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-button", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonButton(this LayoutBuilder b, Action<PropsBuilder<IonButton>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-button", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonButton(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-button", children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonButton(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-button", children);
    }
    /// <summary>
    /// <para> The type of button. </para>
    /// </summary>
    public static void SetButtonType<T>(this PropsBuilder<T> b, Var<string> buttonType) where T: IonButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("buttonType"), buttonType);
    }

    /// <summary>
    /// <para> The type of button. </para>
    /// </summary>
    public static void SetButtonType<T>(this PropsBuilder<T> b, string buttonType) where T: IonButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("buttonType"), b.Const(buttonType));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorDanger<T>(this PropsBuilder<T> b) where T: IonButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("danger"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorDark<T>(this PropsBuilder<T> b) where T: IonButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("dark"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorLight<T>(this PropsBuilder<T> b) where T: IonButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("light"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorMedium<T>(this PropsBuilder<T> b) where T: IonButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("medium"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorPrimary<T>(this PropsBuilder<T> b) where T: IonButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("primary"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorSecondary<T>(this PropsBuilder<T> b) where T: IonButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("secondary"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorSuccess<T>(this PropsBuilder<T> b) where T: IonButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("success"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorTertiary<T>(this PropsBuilder<T> b) where T: IonButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("tertiary"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorWarning<T>(this PropsBuilder<T> b) where T: IonButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("warning"));
    }


    /// <summary>
    /// <para> If `true`, the user cannot interact with the button. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b) where T: IonButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, the user cannot interact with the button. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, Var<bool> disabled) where T: IonButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), disabled);
    }

    /// <summary>
    /// <para> If `true`, the user cannot interact with the button. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, bool disabled) where T: IonButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), b.Const(disabled));
    }


    /// <summary>
    /// <para> This attribute instructs browsers to download a URL instead of navigating to it, so the user will be prompted to save it as a local file. If the attribute has a value, it is used as the pre-filled file name in the Save prompt (the user can still change the file name if they want). </para>
    /// </summary>
    public static void SetDownload<T>(this PropsBuilder<T> b, Var<string> download) where T: IonButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("download"), download);
    }

    /// <summary>
    /// <para> This attribute instructs browsers to download a URL instead of navigating to it, so the user will be prompted to save it as a local file. If the attribute has a value, it is used as the pre-filled file name in the Save prompt (the user can still change the file name if they want). </para>
    /// </summary>
    public static void SetDownload<T>(this PropsBuilder<T> b, string download) where T: IonButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("download"), b.Const(download));
    }


    /// <summary>
    /// <para> Set to `"block"` for a full-width button or to `"full"` for a full-width button with square corners and no left or right borders. </para>
    /// </summary>
    public static void SetExpandBlock<T>(this PropsBuilder<T> b) where T: IonButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("expand"), b.Const("block"));
    }


    /// <summary>
    /// <para> Set to `"block"` for a full-width button or to `"full"` for a full-width button with square corners and no left or right borders. </para>
    /// </summary>
    public static void SetExpandFull<T>(this PropsBuilder<T> b) where T: IonButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("expand"), b.Const("full"));
    }


    /// <summary>
    /// <para> Set to `"clear"` for a transparent button that resembles a flat button, to `"outline"` for a transparent button with a border, or to `"solid"` for a button with a filled background. The default fill is `"solid"` except inside of a toolbar, where the default is `"clear"`. </para>
    /// </summary>
    public static void SetFillClear<T>(this PropsBuilder<T> b) where T: IonButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("fill"), b.Const("clear"));
    }


    /// <summary>
    /// <para> Set to `"clear"` for a transparent button that resembles a flat button, to `"outline"` for a transparent button with a border, or to `"solid"` for a button with a filled background. The default fill is `"solid"` except inside of a toolbar, where the default is `"clear"`. </para>
    /// </summary>
    public static void SetFillDefault<T>(this PropsBuilder<T> b) where T: IonButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("fill"), b.Const("default"));
    }


    /// <summary>
    /// <para> Set to `"clear"` for a transparent button that resembles a flat button, to `"outline"` for a transparent button with a border, or to `"solid"` for a button with a filled background. The default fill is `"solid"` except inside of a toolbar, where the default is `"clear"`. </para>
    /// </summary>
    public static void SetFillOutline<T>(this PropsBuilder<T> b) where T: IonButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("fill"), b.Const("outline"));
    }


    /// <summary>
    /// <para> Set to `"clear"` for a transparent button that resembles a flat button, to `"outline"` for a transparent button with a border, or to `"solid"` for a button with a filled background. The default fill is `"solid"` except inside of a toolbar, where the default is `"clear"`. </para>
    /// </summary>
    public static void SetFillSolid<T>(this PropsBuilder<T> b) where T: IonButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("fill"), b.Const("solid"));
    }


    /// <summary>
    /// <para> The HTML form element or form element id. Used to submit a form when the button is not a child of the form. </para>
    /// </summary>
    public static void SetForm<T>(this PropsBuilder<T> b, Var<HTMLFormElement> form) where T: IonButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<HTMLFormElement>("form"), form);
    }

    /// <summary>
    /// <para> The HTML form element or form element id. Used to submit a form when the button is not a child of the form. </para>
    /// </summary>
    public static void SetForm<T>(this PropsBuilder<T> b, HTMLFormElement form) where T: IonButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<HTMLFormElement>("form"), b.Const(form));
    }


    /// <summary>
    /// <para> The HTML form element or form element id. Used to submit a form when the button is not a child of the form. </para>
    /// </summary>
    public static void SetForm<T>(this PropsBuilder<T> b, Var<string> form) where T: IonButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("form"), form);
    }

    /// <summary>
    /// <para> The HTML form element or form element id. Used to submit a form when the button is not a child of the form. </para>
    /// </summary>
    public static void SetForm<T>(this PropsBuilder<T> b, string form) where T: IonButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("form"), b.Const(form));
    }


    /// <summary>
    /// <para> Contains a URL or a URL fragment that the hyperlink points to. If this property is set, an anchor tag will be rendered. </para>
    /// </summary>
    public static void SetHref<T>(this PropsBuilder<T> b, Var<string> href) where T: IonButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("href"), href);
    }

    /// <summary>
    /// <para> Contains a URL or a URL fragment that the hyperlink points to. If this property is set, an anchor tag will be rendered. </para>
    /// </summary>
    public static void SetHref<T>(this PropsBuilder<T> b, string href) where T: IonButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("href"), b.Const(href));
    }


    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeIos<T>(this PropsBuilder<T> b) where T: IonButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("mode"), b.Const("ios"));
    }


    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeMd<T>(this PropsBuilder<T> b) where T: IonButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("mode"), b.Const("md"));
    }


    /// <summary>
    /// <para> Specifies the relationship of the target object to the link object. The value is a space-separated list of [link types](https://developer.mozilla.org/en-US/docs/Web/HTML/Link_types). </para>
    /// </summary>
    public static void SetRel<T>(this PropsBuilder<T> b, Var<string> rel) where T: IonButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("rel"), rel);
    }

    /// <summary>
    /// <para> Specifies the relationship of the target object to the link object. The value is a space-separated list of [link types](https://developer.mozilla.org/en-US/docs/Web/HTML/Link_types). </para>
    /// </summary>
    public static void SetRel<T>(this PropsBuilder<T> b, string rel) where T: IonButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("rel"), b.Const(rel));
    }


    /// <summary>
    /// <para> When using a router, it specifies the transition animation when navigating to another page using `href`. </para>
    /// </summary>
    public static void SetRouterAnimation<T>(this PropsBuilder<T> b, Var<System.Func<object,object,Animation>> routerAnimation) where T: IonButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<System.Func<object,object,Animation>>("routerAnimation"), routerAnimation);
    }

    /// <summary>
    /// <para> When using a router, it specifies the transition animation when navigating to another page using `href`. </para>
    /// </summary>
    public static void SetRouterAnimation<T>(this PropsBuilder<T> b, System.Func<object,object,Animation> routerAnimation) where T: IonButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<System.Func<object,object,Animation>>("routerAnimation"), b.Const(routerAnimation));
    }


    /// <summary>
    /// <para> When using a router, it specifies the transition direction when navigating to another page using `href`. </para>
    /// </summary>
    public static void SetRouterDirectionBack<T>(this PropsBuilder<T> b) where T: IonButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("routerDirection"), b.Const("back"));
    }


    /// <summary>
    /// <para> When using a router, it specifies the transition direction when navigating to another page using `href`. </para>
    /// </summary>
    public static void SetRouterDirectionForward<T>(this PropsBuilder<T> b) where T: IonButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("routerDirection"), b.Const("forward"));
    }


    /// <summary>
    /// <para> When using a router, it specifies the transition direction when navigating to another page using `href`. </para>
    /// </summary>
    public static void SetRouterDirectionRoot<T>(this PropsBuilder<T> b) where T: IonButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("routerDirection"), b.Const("root"));
    }


    /// <summary>
    /// <para> Set to `"round"` for a button with more rounded corners. </para>
    /// </summary>
    public static void SetShapeRound<T>(this PropsBuilder<T> b) where T: IonButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("shape"), b.Const("round"));
    }


    /// <summary>
    /// <para> Set to `"small"` for a button with less height and padding, to `"default"` for a button with the default height and padding, or to `"large"` for a button with more height and padding. By default the size is unset, unless the button is inside of an item, where the size is `"small"` by default. Set the size to `"default"` inside of an item to make it a standard size button. </para>
    /// </summary>
    public static void SetSizeDefault<T>(this PropsBuilder<T> b) where T: IonButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("size"), b.Const("default"));
    }


    /// <summary>
    /// <para> Set to `"small"` for a button with less height and padding, to `"default"` for a button with the default height and padding, or to `"large"` for a button with more height and padding. By default the size is unset, unless the button is inside of an item, where the size is `"small"` by default. Set the size to `"default"` inside of an item to make it a standard size button. </para>
    /// </summary>
    public static void SetSizeLarge<T>(this PropsBuilder<T> b) where T: IonButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("size"), b.Const("large"));
    }


    /// <summary>
    /// <para> Set to `"small"` for a button with less height and padding, to `"default"` for a button with the default height and padding, or to `"large"` for a button with more height and padding. By default the size is unset, unless the button is inside of an item, where the size is `"small"` by default. Set the size to `"default"` inside of an item to make it a standard size button. </para>
    /// </summary>
    public static void SetSizeSmall<T>(this PropsBuilder<T> b) where T: IonButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("size"), b.Const("small"));
    }


    /// <summary>
    /// <para> If `true`, activates a button with a heavier font weight. </para>
    /// </summary>
    public static void SetStrong<T>(this PropsBuilder<T> b) where T: IonButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("strong"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, activates a button with a heavier font weight. </para>
    /// </summary>
    public static void SetStrong<T>(this PropsBuilder<T> b, Var<bool> strong) where T: IonButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("strong"), strong);
    }

    /// <summary>
    /// <para> If `true`, activates a button with a heavier font weight. </para>
    /// </summary>
    public static void SetStrong<T>(this PropsBuilder<T> b, bool strong) where T: IonButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("strong"), b.Const(strong));
    }


    /// <summary>
    /// <para> Specifies where to display the linked URL. Only applies when an `href` is provided. Special keywords: `"_blank"`, `"_self"`, `"_parent"`, `"_top"`. </para>
    /// </summary>
    public static void SetTarget<T>(this PropsBuilder<T> b, Var<string> target) where T: IonButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("target"), target);
    }

    /// <summary>
    /// <para> Specifies where to display the linked URL. Only applies when an `href` is provided. Special keywords: `"_blank"`, `"_self"`, `"_parent"`, `"_top"`. </para>
    /// </summary>
    public static void SetTarget<T>(this PropsBuilder<T> b, string target) where T: IonButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("target"), b.Const(target));
    }


    /// <summary>
    /// <para> The type of the button. </para>
    /// </summary>
    public static void SetTypeButton<T>(this PropsBuilder<T> b) where T: IonButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("type"), b.Const("button"));
    }


    /// <summary>
    /// <para> The type of the button. </para>
    /// </summary>
    public static void SetTypeReset<T>(this PropsBuilder<T> b) where T: IonButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("type"), b.Const("reset"));
    }


    /// <summary>
    /// <para> The type of the button. </para>
    /// </summary>
    public static void SetTypeSubmit<T>(this PropsBuilder<T> b) where T: IonButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("type"), b.Const("submit"));
    }


    /// <summary>
    /// <para> Emitted when the button loses focus. </para>
    /// </summary>
    public static void OnIonBlur<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonButton
    {
        b.OnEventAction("onionBlur", action);
    }
    /// <summary>
    /// <para> Emitted when the button loses focus. </para>
    /// </summary>
    public static void OnIonBlur<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonButton
    {
        b.OnEventAction("onionBlur", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the button has focus. </para>
    /// </summary>
    public static void OnIonFocus<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonButton
    {
        b.OnEventAction("onionFocus", action);
    }
    /// <summary>
    /// <para> Emitted when the button has focus. </para>
    /// </summary>
    public static void OnIonFocus<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonButton
    {
        b.OnEventAction("onionFocus", b.MakeAction(action));
    }

}

