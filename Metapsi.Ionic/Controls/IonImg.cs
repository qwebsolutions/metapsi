using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Ionic;


public partial class IonImg : IonComponent
{
    public IonImg() : base("ion-img") { }
}

public static partial class IonImgControl
{
    /// <summary>
    /// 
    /// </summary>
    public static IHtmlNode IonImg(this HtmlBuilder b, Action<AttributesBuilder<IonImg>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("ion-img", buildAttributes, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static IHtmlNode IonImg(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("ion-img", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// This attribute defines the alternative text describing the image. Users will see this text displayed if the image URL is wrong, the image is not in one of the supported formats, or if the image is not yet downloaded.
    /// </summary>
    public static void SetAlt(this AttributesBuilder<IonImg> b, string value)
    {
        b.SetAttribute("alt", value);
    }

    /// <summary>
    /// The image URL. This attribute is mandatory for the `<img>` element.
    /// </summary>
    public static void SetSrc(this AttributesBuilder<IonImg> b, string value)
    {
        b.SetAttribute("src", value);
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
    /// This attribute defines the alternative text describing the image. Users will see this text displayed if the image URL is wrong, the image is not in one of the supported formats, or if the image is not yet downloaded.
    /// </summary>
    public static void SetAlt<T>(this PropsBuilder<T> b, Var<string> value) where T: IonImg
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("alt"), value);
    }
    /// <summary>
    /// This attribute defines the alternative text describing the image. Users will see this text displayed if the image URL is wrong, the image is not in one of the supported formats, or if the image is not yet downloaded.
    /// </summary>
    public static void SetAlt<T>(this PropsBuilder<T> b, string value) where T: IonImg
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("alt"), b.Const(value));
    }

    /// <summary>
    /// The image URL. This attribute is mandatory for the `<img>` element.
    /// </summary>
    public static void SetSrc<T>(this PropsBuilder<T> b, Var<string> value) where T: IonImg
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("src"), value);
    }
    /// <summary>
    /// The image URL. This attribute is mandatory for the `<img>` element.
    /// </summary>
    public static void SetSrc<T>(this PropsBuilder<T> b, string value) where T: IonImg
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("src"), b.Const(value));
    }

    /// <summary>
    /// Emitted when the img fails to load
    /// </summary>
    public static void OnIonError<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonImg
    {
        b.OnEventAction("onionError", action);
    }
    /// <summary>
    /// Emitted when the img fails to load
    /// </summary>
    public static void OnIonError<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonImg
    {
        b.OnEventAction("onionError", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the image has finished loading
    /// </summary>
    public static void OnIonImgDidLoad<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonImg
    {
        b.OnEventAction("onionImgDidLoad", action);
    }
    /// <summary>
    /// Emitted when the image has finished loading
    /// </summary>
    public static void OnIonImgDidLoad<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonImg
    {
        b.OnEventAction("onionImgDidLoad", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the img src has been set
    /// </summary>
    public static void OnIonImgWillLoad<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonImg
    {
        b.OnEventAction("onionImgWillLoad", action);
    }
    /// <summary>
    /// Emitted when the img src has been set
    /// </summary>
    public static void OnIonImgWillLoad<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonImg
    {
        b.OnEventAction("onionImgWillLoad", b.MakeAction(action));
    }

}

