using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Ionic;


public partial class IonInputPasswordToggle : IonComponent
{
    public IonInputPasswordToggle() : base("ion-input-password-toggle") { }
}

public static partial class IonInputPasswordToggleControl
{
    /// <summary>
    /// 
    /// </summary>
    public static IHtmlNode IonInputPasswordToggle(this HtmlBuilder b, Action<AttributesBuilder<IonInputPasswordToggle>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("ion-input-password-toggle", buildAttributes, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static IHtmlNode IonInputPasswordToggle(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("ion-input-password-toggle", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor(this AttributesBuilder<IonInputPasswordToggle> b, string value)
    {
        b.SetAttribute("color", value);
    }

    /// <summary>
    /// The icon that can be used to represent hiding a password. If not set, the "eyeOff" Ionicon will be used.
    /// </summary>
    public static void SetHideIcon(this AttributesBuilder<IonInputPasswordToggle> b, string value)
    {
        b.SetAttribute("hide-icon", value);
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetMode(this AttributesBuilder<IonInputPasswordToggle> b, string value)
    {
        b.SetAttribute("mode", value);
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos(this AttributesBuilder<IonInputPasswordToggle> b)
    {
        b.SetAttribute("mode", "ios");
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd(this AttributesBuilder<IonInputPasswordToggle> b)
    {
        b.SetAttribute("mode", "md");
    }

    /// <summary>
    /// The icon that can be used to represent showing a password. If not set, the "eye" Ionicon will be used.
    /// </summary>
    public static void SetShowIcon(this AttributesBuilder<IonInputPasswordToggle> b, string value)
    {
        b.SetAttribute("show-icon", value);
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
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDanger<T>(this PropsBuilder<T> b) where T: IonInputPasswordToggle
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("danger"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDark<T>(this PropsBuilder<T> b) where T: IonInputPasswordToggle
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("dark"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorLight<T>(this PropsBuilder<T> b) where T: IonInputPasswordToggle
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("light"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorMedium<T>(this PropsBuilder<T> b) where T: IonInputPasswordToggle
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("medium"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorPrimary<T>(this PropsBuilder<T> b) where T: IonInputPasswordToggle
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("primary"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSecondary<T>(this PropsBuilder<T> b) where T: IonInputPasswordToggle
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("secondary"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSuccess<T>(this PropsBuilder<T> b) where T: IonInputPasswordToggle
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("success"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorTertiary<T>(this PropsBuilder<T> b) where T: IonInputPasswordToggle
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("tertiary"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorWarning<T>(this PropsBuilder<T> b) where T: IonInputPasswordToggle
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("warning"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor<T>(this PropsBuilder<T> b, Var<string> value) where T: IonInputPasswordToggle
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), value);
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor<T>(this PropsBuilder<T> b, string value) where T: IonInputPasswordToggle
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const(value));
    }

    /// <summary>
    /// The icon that can be used to represent hiding a password. If not set, the "eyeOff" Ionicon will be used.
    /// </summary>
    public static void SetHideIcon<T>(this PropsBuilder<T> b, Var<string> value) where T: IonInputPasswordToggle
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("hideIcon"), value);
    }
    /// <summary>
    /// The icon that can be used to represent hiding a password. If not set, the "eyeOff" Ionicon will be used.
    /// </summary>
    public static void SetHideIcon<T>(this PropsBuilder<T> b, string value) where T: IonInputPasswordToggle
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("hideIcon"), b.Const(value));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos<T>(this PropsBuilder<T> b) where T: IonInputPasswordToggle
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("ios"));
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd<T>(this PropsBuilder<T> b) where T: IonInputPasswordToggle
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("md"));
    }

    /// <summary>
    /// The icon that can be used to represent showing a password. If not set, the "eye" Ionicon will be used.
    /// </summary>
    public static void SetShowIcon<T>(this PropsBuilder<T> b, Var<string> value) where T: IonInputPasswordToggle
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("showIcon"), value);
    }
    /// <summary>
    /// The icon that can be used to represent showing a password. If not set, the "eye" Ionicon will be used.
    /// </summary>
    public static void SetShowIcon<T>(this PropsBuilder<T> b, string value) where T: IonInputPasswordToggle
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("showIcon"), b.Const(value));
    }

}

