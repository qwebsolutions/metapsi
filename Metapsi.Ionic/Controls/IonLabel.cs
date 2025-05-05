using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Ionic;


public partial class IonLabel
{
}

public static partial class IonLabelControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonLabel(this HtmlBuilder b, Action<AttributesBuilder<IonLabel>> buildAttributes, params IHtmlNode[] children)
    {
        return b.IonicTag("ion-label", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonLabel(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.IonicTag("ion-label", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonLabel(this HtmlBuilder b, Action<AttributesBuilder<IonLabel>> buildAttributes, List<IHtmlNode> children)
    {
        return b.IonicTag("ion-label", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonLabel(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.IonicTag("ion-label", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColor(this AttributesBuilder<IonLabel> b, string color)
    {
        b.SetAttribute("color", color);
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetMode(this AttributesBuilder<IonLabel> b, string mode)
    {
        b.SetAttribute("mode", mode);
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeIos(this AttributesBuilder<IonLabel> b)
    {
        b.SetAttribute("mode", "ios");
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeMd(this AttributesBuilder<IonLabel> b)
    {
        b.SetAttribute("mode", "md");
    }

    /// <summary>
    /// <para> The position determines where and how the label behaves inside an item. </para>
    /// </summary>
    public static void SetPosition(this AttributesBuilder<IonLabel> b, string position)
    {
        b.SetAttribute("position", position);
    }

    /// <summary>
    /// <para> The position determines where and how the label behaves inside an item. </para>
    /// </summary>
    public static void SetPositionFixed(this AttributesBuilder<IonLabel> b)
    {
        b.SetAttribute("position", "fixed");
    }

    /// <summary>
    /// <para> The position determines where and how the label behaves inside an item. </para>
    /// </summary>
    public static void SetPositionFloating(this AttributesBuilder<IonLabel> b)
    {
        b.SetAttribute("position", "floating");
    }

    /// <summary>
    /// <para> The position determines where and how the label behaves inside an item. </para>
    /// </summary>
    public static void SetPositionStacked(this AttributesBuilder<IonLabel> b)
    {
        b.SetAttribute("position", "stacked");
    }

    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonLabel(this LayoutBuilder b, Action<PropsBuilder<IonLabel>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-label", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonLabel(this LayoutBuilder b, Action<PropsBuilder<IonLabel>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-label", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonLabel(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-label", children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonLabel(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-label", children);
    }
    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorDanger<T>(this PropsBuilder<T> b) where T: IonLabel
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("danger"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorDark<T>(this PropsBuilder<T> b) where T: IonLabel
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("dark"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorLight<T>(this PropsBuilder<T> b) where T: IonLabel
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("light"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorMedium<T>(this PropsBuilder<T> b) where T: IonLabel
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("medium"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorPrimary<T>(this PropsBuilder<T> b) where T: IonLabel
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("primary"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorSecondary<T>(this PropsBuilder<T> b) where T: IonLabel
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("secondary"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorSuccess<T>(this PropsBuilder<T> b) where T: IonLabel
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("success"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorTertiary<T>(this PropsBuilder<T> b) where T: IonLabel
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("tertiary"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorWarning<T>(this PropsBuilder<T> b) where T: IonLabel
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("warning"));
    }


    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeIos<T>(this PropsBuilder<T> b) where T: IonLabel
    {
        b.SetProperty(b.Props, b.Const("mode"), b.Const("ios"));
    }


    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeMd<T>(this PropsBuilder<T> b) where T: IonLabel
    {
        b.SetProperty(b.Props, b.Const("mode"), b.Const("md"));
    }


    /// <summary>
    /// <para> The position determines where and how the label behaves inside an item. </para>
    /// </summary>
    public static void SetPositionFixed<T>(this PropsBuilder<T> b) where T: IonLabel
    {
        b.SetProperty(b.Props, b.Const("position"), b.Const("fixed"));
    }


    /// <summary>
    /// <para> The position determines where and how the label behaves inside an item. </para>
    /// </summary>
    public static void SetPositionFloating<T>(this PropsBuilder<T> b) where T: IonLabel
    {
        b.SetProperty(b.Props, b.Const("position"), b.Const("floating"));
    }


    /// <summary>
    /// <para> The position determines where and how the label behaves inside an item. </para>
    /// </summary>
    public static void SetPositionStacked<T>(this PropsBuilder<T> b) where T: IonLabel
    {
        b.SetProperty(b.Props, b.Const("position"), b.Const("stacked"));
    }


}

