using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Ionic;


public partial class IonListHeader
{
}

public static partial class IonListHeaderControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonListHeader(this HtmlBuilder b, Action<AttributesBuilder<IonListHeader>> buildAttributes, params IHtmlNode[] children)
    {
        return b.IonicTag("ion-list-header", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonListHeader(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.IonicTag("ion-list-header", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonListHeader(this HtmlBuilder b, Action<AttributesBuilder<IonListHeader>> buildAttributes, List<IHtmlNode> children)
    {
        return b.IonicTag("ion-list-header", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonListHeader(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.IonicTag("ion-list-header", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColor(this AttributesBuilder<IonListHeader> b, string color)
    {
        b.SetAttribute("color", color);
    }

    /// <summary>
    /// <para> How the bottom border should be displayed on the list header. </para>
    /// </summary>
    public static void SetLines(this AttributesBuilder<IonListHeader> b, string lines)
    {
        b.SetAttribute("lines", lines);
    }

    /// <summary>
    /// <para> How the bottom border should be displayed on the list header. </para>
    /// </summary>
    public static void SetLinesFull(this AttributesBuilder<IonListHeader> b)
    {
        b.SetAttribute("lines", "full");
    }

    /// <summary>
    /// <para> How the bottom border should be displayed on the list header. </para>
    /// </summary>
    public static void SetLinesInset(this AttributesBuilder<IonListHeader> b)
    {
        b.SetAttribute("lines", "inset");
    }

    /// <summary>
    /// <para> How the bottom border should be displayed on the list header. </para>
    /// </summary>
    public static void SetLinesNone(this AttributesBuilder<IonListHeader> b)
    {
        b.SetAttribute("lines", "none");
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetMode(this AttributesBuilder<IonListHeader> b, string mode)
    {
        b.SetAttribute("mode", mode);
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeIos(this AttributesBuilder<IonListHeader> b)
    {
        b.SetAttribute("mode", "ios");
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeMd(this AttributesBuilder<IonListHeader> b)
    {
        b.SetAttribute("mode", "md");
    }

    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonListHeader(this LayoutBuilder b, Action<PropsBuilder<IonListHeader>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-list-header", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonListHeader(this LayoutBuilder b, Action<PropsBuilder<IonListHeader>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-list-header", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonListHeader(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-list-header", children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonListHeader(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-list-header", children);
    }
    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorDanger<T>(this PropsBuilder<T> b) where T: IonListHeader
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("danger"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorDark<T>(this PropsBuilder<T> b) where T: IonListHeader
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("dark"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorLight<T>(this PropsBuilder<T> b) where T: IonListHeader
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("light"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorMedium<T>(this PropsBuilder<T> b) where T: IonListHeader
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("medium"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorPrimary<T>(this PropsBuilder<T> b) where T: IonListHeader
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("primary"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorSecondary<T>(this PropsBuilder<T> b) where T: IonListHeader
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("secondary"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorSuccess<T>(this PropsBuilder<T> b) where T: IonListHeader
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("success"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorTertiary<T>(this PropsBuilder<T> b) where T: IonListHeader
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("tertiary"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorWarning<T>(this PropsBuilder<T> b) where T: IonListHeader
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("warning"));
    }


    /// <summary>
    /// <para> How the bottom border should be displayed on the list header. </para>
    /// </summary>
    public static void SetLinesFull<T>(this PropsBuilder<T> b) where T: IonListHeader
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("lines"), b.Const("full"));
    }


    /// <summary>
    /// <para> How the bottom border should be displayed on the list header. </para>
    /// </summary>
    public static void SetLinesInset<T>(this PropsBuilder<T> b) where T: IonListHeader
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("lines"), b.Const("inset"));
    }


    /// <summary>
    /// <para> How the bottom border should be displayed on the list header. </para>
    /// </summary>
    public static void SetLinesNone<T>(this PropsBuilder<T> b) where T: IonListHeader
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("lines"), b.Const("none"));
    }


    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeIos<T>(this PropsBuilder<T> b) where T: IonListHeader
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("mode"), b.Const("ios"));
    }


    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeMd<T>(this PropsBuilder<T> b) where T: IonListHeader
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("mode"), b.Const("md"));
    }


}

