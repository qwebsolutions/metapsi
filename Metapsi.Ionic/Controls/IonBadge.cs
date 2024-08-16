using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Ionic;


public partial class IonBadge : IonComponent
{
    public IonBadge() : base("ion-badge") { }
}

public static partial class IonBadgeControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonBadge(this HtmlBuilder b, Action<AttributesBuilder<IonBadge>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("ion-badge", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonBadge(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("ion-badge", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColor(this AttributesBuilder<IonBadge> b,string color)
    {
        b.SetAttribute("color", color);
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetMode(this AttributesBuilder<IonBadge> b,string mode)
    {
        b.SetAttribute("mode", mode);
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeIos(this AttributesBuilder<IonBadge> b)
    {
        b.SetAttribute("mode", "ios");
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeMd(this AttributesBuilder<IonBadge> b)
    {
        b.SetAttribute("mode", "md");
    }

    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonBadge(this LayoutBuilder b, Action<PropsBuilder<IonBadge>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-badge", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonBadge(this LayoutBuilder b, Action<PropsBuilder<IonBadge>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-badge", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonBadge(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-badge", children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonBadge(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-badge", children);
    }
    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorDanger<T>(this PropsBuilder<T> b) where T: IonBadge
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("danger"));
    }


    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeIos<T>(this PropsBuilder<T> b) where T: IonBadge
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("mode"), b.Const("ios"));
    }


}

