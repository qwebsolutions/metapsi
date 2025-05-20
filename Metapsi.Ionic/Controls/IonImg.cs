using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Ionic;


public partial class IonImg
{
}

public static partial class IonImgControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonImg(this HtmlBuilder b, Action<AttributesBuilder<IonImg>> buildAttributes, params IHtmlNode[] children)
    {
        return b.IonicTag("ion-img", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonImg(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.IonicTag("ion-img", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonImg(this HtmlBuilder b, Action<AttributesBuilder<IonImg>> buildAttributes, List<IHtmlNode> children)
    {
        return b.IonicTag("ion-img", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonImg(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.IonicTag("ion-img", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> This attribute defines the alternative text describing the image. Users will see this text displayed if the image URL is wrong, the image is not in one of the supported formats, or if the image is not yet downloaded. </para>
    /// </summary>
    public static void SetAlt(this AttributesBuilder<IonImg> b, string alt)
    {
        b.SetAttribute("alt", alt);
    }

    /// <summary>
    /// <para> The image URL. This attribute is mandatory for the `&lt;img&gt;` element. </para>
    /// </summary>
    public static void SetSrc(this AttributesBuilder<IonImg> b, string src)
    {
        b.SetAttribute("src", src);
    }

    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonImg(this LayoutBuilder b, Action<PropsBuilder<IonImg>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-img", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonImg(this LayoutBuilder b, Action<PropsBuilder<IonImg>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-img", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonImg(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-img", children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonImg(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-img", children);
    }
    /// <summary>
    /// <para> This attribute defines the alternative text describing the image. Users will see this text displayed if the image URL is wrong, the image is not in one of the supported formats, or if the image is not yet downloaded. </para>
    /// </summary>
    public static void SetAlt<T>(this PropsBuilder<T> b, Var<string> alt) where T: IonImg
    {
        b.SetProperty(b.Props, b.Const("alt"), alt);
    }

    /// <summary>
    /// <para> This attribute defines the alternative text describing the image. Users will see this text displayed if the image URL is wrong, the image is not in one of the supported formats, or if the image is not yet downloaded. </para>
    /// </summary>
    public static void SetAlt<T>(this PropsBuilder<T> b, string alt) where T: IonImg
    {
        b.SetProperty(b.Props, b.Const("alt"), b.Const(alt));
    }


    /// <summary>
    /// <para> The image URL. This attribute is mandatory for the `&lt;img&gt;` element. </para>
    /// </summary>
    public static void SetSrc<T>(this PropsBuilder<T> b, Var<string> src) where T: IonImg
    {
        b.SetProperty(b.Props, b.Const("src"), src);
    }

    /// <summary>
    /// <para> The image URL. This attribute is mandatory for the `&lt;img&gt;` element. </para>
    /// </summary>
    public static void SetSrc<T>(this PropsBuilder<T> b, string src) where T: IonImg
    {
        b.SetProperty(b.Props, b.Const("src"), b.Const(src));
    }


    /// <summary>
    /// <para> Emitted when the img fails to load </para>
    /// </summary>
    public static void OnIonError<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonImg
    {
        b.OnEventAction("onionError", action);
    }
    /// <summary>
    /// <para> Emitted when the img fails to load </para>
    /// </summary>
    public static void OnIonError<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonImg
    {
        b.OnEventAction("onionError", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the image has finished loading </para>
    /// </summary>
    public static void OnIonImgDidLoad<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonImg
    {
        b.OnEventAction("onionImgDidLoad", action);
    }
    /// <summary>
    /// <para> Emitted when the image has finished loading </para>
    /// </summary>
    public static void OnIonImgDidLoad<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonImg
    {
        b.OnEventAction("onionImgDidLoad", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the img src has been set </para>
    /// </summary>
    public static void OnIonImgWillLoad<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonImg
    {
        b.OnEventAction("onionImgWillLoad", action);
    }
    /// <summary>
    /// <para> Emitted when the img src has been set </para>
    /// </summary>
    public static void OnIonImgWillLoad<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonImg
    {
        b.OnEventAction("onionImgWillLoad", b.MakeAction(action));
    }

}

