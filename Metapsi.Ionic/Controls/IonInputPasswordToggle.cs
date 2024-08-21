using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Ionic;


public partial class IonInputPasswordToggle
{
}

public static partial class IonInputPasswordToggleControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonInputPasswordToggle(this HtmlBuilder b, Action<AttributesBuilder<IonInputPasswordToggle>> buildAttributes, params IHtmlNode[] children)
    {
        return b.IonicTag("ion-input-password-toggle", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonInputPasswordToggle(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.IonicTag("ion-input-password-toggle", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonInputPasswordToggle(this HtmlBuilder b, Action<AttributesBuilder<IonInputPasswordToggle>> buildAttributes, List<IHtmlNode> children)
    {
        return b.IonicTag("ion-input-password-toggle", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonInputPasswordToggle(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.IonicTag("ion-input-password-toggle", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColor(this AttributesBuilder<IonInputPasswordToggle> b, string color)
    {
        b.SetAttribute("color", color);
    }

    /// <summary>
    /// <para> The icon that can be used to represent hiding a password. If not set, the "eyeOff" Ionicon will be used. </para>
    /// </summary>
    public static void SetHideIcon(this AttributesBuilder<IonInputPasswordToggle> b, string hideIcon)
    {
        b.SetAttribute("hide-icon", hideIcon);
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetMode(this AttributesBuilder<IonInputPasswordToggle> b, string mode)
    {
        b.SetAttribute("mode", mode);
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeIos(this AttributesBuilder<IonInputPasswordToggle> b)
    {
        b.SetAttribute("mode", "ios");
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeMd(this AttributesBuilder<IonInputPasswordToggle> b)
    {
        b.SetAttribute("mode", "md");
    }

    /// <summary>
    /// <para> The icon that can be used to represent showing a password. If not set, the "eye" Ionicon will be used. </para>
    /// </summary>
    public static void SetShowIcon(this AttributesBuilder<IonInputPasswordToggle> b, string showIcon)
    {
        b.SetAttribute("show-icon", showIcon);
    }

    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonInputPasswordToggle(this LayoutBuilder b, Action<PropsBuilder<IonInputPasswordToggle>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-input-password-toggle", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonInputPasswordToggle(this LayoutBuilder b, Action<PropsBuilder<IonInputPasswordToggle>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-input-password-toggle", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonInputPasswordToggle(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-input-password-toggle", children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonInputPasswordToggle(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-input-password-toggle", children);
    }
    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorDanger<T>(this PropsBuilder<T> b) where T: IonInputPasswordToggle
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("danger"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorDark<T>(this PropsBuilder<T> b) where T: IonInputPasswordToggle
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("dark"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorLight<T>(this PropsBuilder<T> b) where T: IonInputPasswordToggle
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("light"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorMedium<T>(this PropsBuilder<T> b) where T: IonInputPasswordToggle
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("medium"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorPrimary<T>(this PropsBuilder<T> b) where T: IonInputPasswordToggle
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("primary"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorSecondary<T>(this PropsBuilder<T> b) where T: IonInputPasswordToggle
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("secondary"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorSuccess<T>(this PropsBuilder<T> b) where T: IonInputPasswordToggle
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("success"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorTertiary<T>(this PropsBuilder<T> b) where T: IonInputPasswordToggle
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("tertiary"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorWarning<T>(this PropsBuilder<T> b) where T: IonInputPasswordToggle
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("warning"));
    }


    /// <summary>
    /// <para> The icon that can be used to represent hiding a password. If not set, the "eyeOff" Ionicon will be used. </para>
    /// </summary>
    public static void SetHideIcon<T>(this PropsBuilder<T> b, Var<string> hideIcon) where T: IonInputPasswordToggle
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("hideIcon"), hideIcon);
    }

    /// <summary>
    /// <para> The icon that can be used to represent hiding a password. If not set, the "eyeOff" Ionicon will be used. </para>
    /// </summary>
    public static void SetHideIcon<T>(this PropsBuilder<T> b, string hideIcon) where T: IonInputPasswordToggle
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("hideIcon"), b.Const(hideIcon));
    }


    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeIos<T>(this PropsBuilder<T> b) where T: IonInputPasswordToggle
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("mode"), b.Const("ios"));
    }


    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeMd<T>(this PropsBuilder<T> b) where T: IonInputPasswordToggle
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("mode"), b.Const("md"));
    }


    /// <summary>
    /// <para> The icon that can be used to represent showing a password. If not set, the "eye" Ionicon will be used. </para>
    /// </summary>
    public static void SetShowIcon<T>(this PropsBuilder<T> b, Var<string> showIcon) where T: IonInputPasswordToggle
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("showIcon"), showIcon);
    }

    /// <summary>
    /// <para> The icon that can be used to represent showing a password. If not set, the "eye" Ionicon will be used. </para>
    /// </summary>
    public static void SetShowIcon<T>(this PropsBuilder<T> b, string showIcon) where T: IonInputPasswordToggle
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("showIcon"), b.Const(showIcon));
    }


}

