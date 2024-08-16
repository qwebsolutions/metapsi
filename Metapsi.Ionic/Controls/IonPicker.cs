using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Ionic;


public partial class IonPicker : IonComponent
{
    public IonPicker() : base("ion-picker") { }
}

public static partial class IonPickerControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonPicker(this HtmlBuilder b, Action<AttributesBuilder<IonPicker>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("ion-picker", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonPicker(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("ion-picker", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetMode(this AttributesBuilder<IonPicker> b,string mode)
    {
        b.SetAttribute("mode", mode);
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeIos(this AttributesBuilder<IonPicker> b)
    {
        b.SetAttribute("mode", "ios");
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeMd(this AttributesBuilder<IonPicker> b)
    {
        b.SetAttribute("mode", "md");
    }

    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonPicker(this LayoutBuilder b, Action<PropsBuilder<IonPicker>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-picker", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonPicker(this LayoutBuilder b, Action<PropsBuilder<IonPicker>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-picker", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonPicker(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-picker", children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonPicker(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-picker", children);
    }
    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeIos<T>(this PropsBuilder<T> b) where T: IonPicker
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("mode"), b.Const("ios"));
    }


    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeMd<T>(this PropsBuilder<T> b) where T: IonPicker
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("mode"), b.Const("md"));
    }


}

