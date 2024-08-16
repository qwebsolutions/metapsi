using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Ionic;


public partial class IonToolbar : IonComponent
{
    public IonToolbar() : base("ion-toolbar") { }
    /// <summary>
    /// <para> Content is placed between the named slots if provided without a slot. </para>
    /// </summary>
    public static class Slot
    {
        /// <summary>
        /// <para> Content is placed to the right of the toolbar text in LTR, and to the left in RTL. </para>
        /// </summary>
        public const string End = "end";
        /// <summary>
        /// <para> Content is placed to the right of the toolbar text in `ios` mode, and to the far right in `md` mode. </para>
        /// </summary>
        public const string Primary = "primary";
        /// <summary>
        /// <para> Content is placed to the left of the toolbar text in `ios` mode, and directly to the right in `md` mode. </para>
        /// </summary>
        public const string Secondary = "secondary";
        /// <summary>
        /// <para> Content is placed to the left of the toolbar text in LTR, and to the right in RTL. </para>
        /// </summary>
        public const string Start = "start";
    }
}

public static partial class IonToolbarControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonToolbar(this HtmlBuilder b, Action<AttributesBuilder<IonToolbar>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("ion-toolbar", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonToolbar(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("ion-toolbar", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColor(this AttributesBuilder<IonToolbar> b,string color)
    {
        b.SetAttribute("color", color);
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetMode(this AttributesBuilder<IonToolbar> b,string mode)
    {
        b.SetAttribute("mode", mode);
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeIos(this AttributesBuilder<IonToolbar> b)
    {
        b.SetAttribute("mode", "ios");
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeMd(this AttributesBuilder<IonToolbar> b)
    {
        b.SetAttribute("mode", "md");
    }

    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonToolbar(this LayoutBuilder b, Action<PropsBuilder<IonToolbar>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-toolbar", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonToolbar(this LayoutBuilder b, Action<PropsBuilder<IonToolbar>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-toolbar", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonToolbar(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-toolbar", children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonToolbar(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-toolbar", children);
    }
    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorDanger<T>(this PropsBuilder<T> b) where T: IonToolbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("danger"));
    }


    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeIos<T>(this PropsBuilder<T> b) where T: IonToolbar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("mode"), b.Const("ios"));
    }


}

