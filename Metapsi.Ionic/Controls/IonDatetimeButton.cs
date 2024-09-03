using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Ionic;


public partial class IonDatetimeButton
{
    /// <summary>
    ///
    /// </summary>
    public static class Slot
    {
        /// <summary>
        /// <para> Content displayed inside of the date button. </para>
        /// </summary>
        public const string DateTarget = "date-target";
        /// <summary>
        /// <para> Content displayed inside of the time button. </para>
        /// </summary>
        public const string TimeTarget = "time-target";
    }
}

public static partial class IonDatetimeButtonControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonDatetimeButton(this HtmlBuilder b, Action<AttributesBuilder<IonDatetimeButton>> buildAttributes, params IHtmlNode[] children)
    {
        return b.IonicTag("ion-datetime-button", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonDatetimeButton(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.IonicTag("ion-datetime-button", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonDatetimeButton(this HtmlBuilder b, Action<AttributesBuilder<IonDatetimeButton>> buildAttributes, List<IHtmlNode> children)
    {
        return b.IonicTag("ion-datetime-button", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonDatetimeButton(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.IonicTag("ion-datetime-button", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColor(this AttributesBuilder<IonDatetimeButton> b, string color)
    {
        b.SetAttribute("color", color);
    }

    /// <summary>
    /// <para> The ID of the `ion-datetime` instance associated with the datetime button. </para>
    /// </summary>
    public static void SetDatetime(this AttributesBuilder<IonDatetimeButton> b, string datetime)
    {
        b.SetAttribute("datetime", datetime);
    }

    /// <summary>
    /// <para> If `true`, the user cannot interact with the button. </para>
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<IonDatetimeButton> b)
    {
        b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// <para> If `true`, the user cannot interact with the button. </para>
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<IonDatetimeButton> b, bool disabled)
    {
        if (disabled) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetMode(this AttributesBuilder<IonDatetimeButton> b, string mode)
    {
        b.SetAttribute("mode", mode);
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeIos(this AttributesBuilder<IonDatetimeButton> b)
    {
        b.SetAttribute("mode", "ios");
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeMd(this AttributesBuilder<IonDatetimeButton> b)
    {
        b.SetAttribute("mode", "md");
    }

    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonDatetimeButton(this LayoutBuilder b, Action<PropsBuilder<IonDatetimeButton>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-datetime-button", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonDatetimeButton(this LayoutBuilder b, Action<PropsBuilder<IonDatetimeButton>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-datetime-button", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonDatetimeButton(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-datetime-button", children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonDatetimeButton(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-datetime-button", children);
    }
    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorDanger<T>(this PropsBuilder<T> b) where T: IonDatetimeButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("danger"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorDark<T>(this PropsBuilder<T> b) where T: IonDatetimeButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("dark"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorLight<T>(this PropsBuilder<T> b) where T: IonDatetimeButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("light"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorMedium<T>(this PropsBuilder<T> b) where T: IonDatetimeButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("medium"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorPrimary<T>(this PropsBuilder<T> b) where T: IonDatetimeButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("primary"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorSecondary<T>(this PropsBuilder<T> b) where T: IonDatetimeButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("secondary"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorSuccess<T>(this PropsBuilder<T> b) where T: IonDatetimeButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("success"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorTertiary<T>(this PropsBuilder<T> b) where T: IonDatetimeButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("tertiary"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorWarning<T>(this PropsBuilder<T> b) where T: IonDatetimeButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("warning"));
    }


    /// <summary>
    /// <para> The ID of the `ion-datetime` instance associated with the datetime button. </para>
    /// </summary>
    public static void SetDatetime<T>(this PropsBuilder<T> b, Var<string> datetime) where T: IonDatetimeButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("datetime"), datetime);
    }

    /// <summary>
    /// <para> The ID of the `ion-datetime` instance associated with the datetime button. </para>
    /// </summary>
    public static void SetDatetime<T>(this PropsBuilder<T> b, string datetime) where T: IonDatetimeButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("datetime"), b.Const(datetime));
    }


    /// <summary>
    /// <para> If `true`, the user cannot interact with the button. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b) where T: IonDatetimeButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, the user cannot interact with the button. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, Var<bool> disabled) where T: IonDatetimeButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), disabled);
    }

    /// <summary>
    /// <para> If `true`, the user cannot interact with the button. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, bool disabled) where T: IonDatetimeButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), b.Const(disabled));
    }


    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeIos<T>(this PropsBuilder<T> b) where T: IonDatetimeButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("mode"), b.Const("ios"));
    }


    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeMd<T>(this PropsBuilder<T> b) where T: IonDatetimeButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("mode"), b.Const("md"));
    }


}

