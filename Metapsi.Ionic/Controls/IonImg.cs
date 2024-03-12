using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Ionic;


public partial class IonImg
{
}

public static partial class IonImgControl
{
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
    /// This attribute defines the alternative text describing the image. Users will see this text displayed if the image URL is wrong, the image is not in one of the supported formats, or if the image is not yet downloaded.
    /// </summary>
    public static void SetAlt(this PropsBuilder<IonImg> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("alt"), value);
    }
    /// <summary>
    /// This attribute defines the alternative text describing the image. Users will see this text displayed if the image URL is wrong, the image is not in one of the supported formats, or if the image is not yet downloaded.
    /// </summary>
    public static void SetAlt(this PropsBuilder<IonImg> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("alt"), b.Const(value));
    }

    /// <summary>
    /// The image URL. This attribute is mandatory for the `<img>` element.
    /// </summary>
    public static void SetSrc(this PropsBuilder<IonImg> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("src"), value);
    }
    /// <summary>
    /// The image URL. This attribute is mandatory for the `<img>` element.
    /// </summary>
    public static void SetSrc(this PropsBuilder<IonImg> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("src"), b.Const(value));
    }

    /// <summary>
    /// Emitted when the img fails to load
    /// </summary>
    public static void OnIonError<TModel>(this PropsBuilder<IonImg> b, Var<HyperType.Action<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel>>("onionError"), action);
    }
    /// <summary>
    /// Emitted when the img fails to load
    /// </summary>
    public static void OnIonError<TModel>(this PropsBuilder<IonImg> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel>>("onionError"), b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the image has finished loading
    /// </summary>
    public static void OnIonImgDidLoad<TModel>(this PropsBuilder<IonImg> b, Var<HyperType.Action<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel>>("onionImgDidLoad"), action);
    }
    /// <summary>
    /// Emitted when the image has finished loading
    /// </summary>
    public static void OnIonImgDidLoad<TModel>(this PropsBuilder<IonImg> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel>>("onionImgDidLoad"), b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the img src has been set
    /// </summary>
    public static void OnIonImgWillLoad<TModel>(this PropsBuilder<IonImg> b, Var<HyperType.Action<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel>>("onionImgWillLoad"), action);
    }
    /// <summary>
    /// Emitted when the img src has been set
    /// </summary>
    public static void OnIonImgWillLoad<TModel>(this PropsBuilder<IonImg> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel>>("onionImgWillLoad"), b.MakeAction(action));
    }

}

