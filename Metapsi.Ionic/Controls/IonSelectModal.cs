using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Ionic;


public partial class IonSelectModal
{
}

public static partial class IonSelectModalControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonSelectModal(this HtmlBuilder b, Action<AttributesBuilder<IonSelectModal>> buildAttributes, params IHtmlNode[] children)
    {
        return b.IonicTag("ion-select-modal", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonSelectModal(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.IonicTag("ion-select-modal", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonSelectModal(this HtmlBuilder b, Action<AttributesBuilder<IonSelectModal>> buildAttributes, List<IHtmlNode> children)
    {
        return b.IonicTag("ion-select-modal", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonSelectModal(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.IonicTag("ion-select-modal", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static void SetHeader(this AttributesBuilder<IonSelectModal> b, string header)
    {
        b.SetAttribute("header", header);
    }

    /// <summary>
    ///
    /// </summary>
    public static void SetMultiple(this AttributesBuilder<IonSelectModal> b)
    {
        b.SetAttribute("multiple", "");
    }

    /// <summary>
    ///
    /// </summary>
    public static void SetMultiple(this AttributesBuilder<IonSelectModal> b, bool multiple)
    {
        if (multiple) b.SetAttribute("multiple", "");
    }

    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonSelectModal(this LayoutBuilder b, Action<PropsBuilder<IonSelectModal>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-select-modal", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonSelectModal(this LayoutBuilder b, Action<PropsBuilder<IonSelectModal>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-select-modal", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonSelectModal(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-select-modal", children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonSelectModal(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-select-modal", children);
    }
    /// <summary>
    ///
    /// </summary>
    public static void SetHeader<T>(this PropsBuilder<T> b, Var<string> header) where T: IonSelectModal
    {
        b.SetProperty(b.Props, b.Const("header"), header);
    }

    /// <summary>
    ///
    /// </summary>
    public static void SetHeader<T>(this PropsBuilder<T> b, string header) where T: IonSelectModal
    {
        b.SetProperty(b.Props, b.Const("header"), b.Const(header));
    }


    /// <summary>
    ///
    /// </summary>
    public static void SetMultiple<T>(this PropsBuilder<T> b) where T: IonSelectModal
    {
        b.SetProperty(b.Props, b.Const("multiple"), b.Const(true));
    }


    /// <summary>
    ///
    /// </summary>
    public static void SetMultiple<T>(this PropsBuilder<T> b, Var<bool> multiple) where T: IonSelectModal
    {
        b.SetProperty(b.Props, b.Const("multiple"), multiple);
    }

    /// <summary>
    ///
    /// </summary>
    public static void SetMultiple<T>(this PropsBuilder<T> b, bool multiple) where T: IonSelectModal
    {
        b.SetProperty(b.Props, b.Const("multiple"), b.Const(multiple));
    }


    /// <summary>
    ///
    /// </summary>
    public static void SetOptions<T>(this PropsBuilder<T> b, Var<List<SelectModalOption>> options) where T: IonSelectModal
    {
        b.SetProperty(b.Props, b.Const("options"), options);
    }

    /// <summary>
    ///
    /// </summary>
    public static void SetOptions<T>(this PropsBuilder<T> b, List<SelectModalOption> options) where T: IonSelectModal
    {
        b.SetProperty(b.Props, b.Const("options"), b.Const(options));
    }


}

