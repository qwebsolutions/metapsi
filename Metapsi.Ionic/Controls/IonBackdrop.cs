using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Ionic;


public partial class IonBackdrop : IonComponent
{
    public IonBackdrop() : base("ion-backdrop") { }
}

public static partial class IonBackdropControl
{
    /// <summary>
    /// 
    /// </summary>
    public static IHtmlNode IonBackdrop(this HtmlBuilder b, Action<AttributesBuilder<IonBackdrop>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("ion-backdrop", buildAttributes, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static IHtmlNode IonBackdrop(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("ion-backdrop", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// If `true`, the backdrop will stop propagation on tap.
    /// </summary>
    public static void SetStopPropagation(this AttributesBuilder<IonBackdrop> b)
    {
        b.SetAttribute("stop-propagation", "");
    }
    /// <summary>
    /// If `true`, the backdrop will stop propagation on tap.
    /// </summary>
    public static void SetStopPropagation(this AttributesBuilder<IonBackdrop> b, bool value)
    {
        if (value) b.SetAttribute("stop-propagation", "");
    }

    /// <summary>
    /// If `true`, the backdrop will can be clicked and will emit the `ionBackdropTap` event.
    /// </summary>
    public static void SetTappable(this AttributesBuilder<IonBackdrop> b)
    {
        b.SetAttribute("tappable", "");
    }
    /// <summary>
    /// If `true`, the backdrop will can be clicked and will emit the `ionBackdropTap` event.
    /// </summary>
    public static void SetTappable(this AttributesBuilder<IonBackdrop> b, bool value)
    {
        if (value) b.SetAttribute("tappable", "");
    }

    /// <summary>
    /// If `true`, the backdrop will be visible.
    /// </summary>
    public static void SetVisible(this AttributesBuilder<IonBackdrop> b)
    {
        b.SetAttribute("visible", "");
    }
    /// <summary>
    /// If `true`, the backdrop will be visible.
    /// </summary>
    public static void SetVisible(this AttributesBuilder<IonBackdrop> b, bool value)
    {
        if (value) b.SetAttribute("visible", "");
    }

    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonBackdrop(this LayoutBuilder b, Action<PropsBuilder<IonBackdrop>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-backdrop", buildProps, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonBackdrop(this LayoutBuilder b, Action<PropsBuilder<IonBackdrop>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-backdrop", buildProps, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonBackdrop(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-backdrop", children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonBackdrop(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-backdrop", children);
    }
    /// <summary>
    /// If `true`, the backdrop will stop propagation on tap.
    /// </summary>
    public static void SetStopPropagation<T>(this PropsBuilder<T> b) where T: IonBackdrop
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("stopPropagation"), b.Const(true));
    }
    /// <summary>
    /// If `true`, the backdrop will stop propagation on tap.
    /// </summary>
    public static void SetStopPropagation<T>(this PropsBuilder<T> b, Var<bool> value) where T: IonBackdrop
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("stopPropagation"), value);
    }
    /// <summary>
    /// If `true`, the backdrop will stop propagation on tap.
    /// </summary>
    public static void SetStopPropagation<T>(this PropsBuilder<T> b, bool value) where T: IonBackdrop
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("stopPropagation"), b.Const(value));
    }

    /// <summary>
    /// If `true`, the backdrop will can be clicked and will emit the `ionBackdropTap` event.
    /// </summary>
    public static void SetTappable<T>(this PropsBuilder<T> b) where T: IonBackdrop
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("tappable"), b.Const(true));
    }
    /// <summary>
    /// If `true`, the backdrop will can be clicked and will emit the `ionBackdropTap` event.
    /// </summary>
    public static void SetTappable<T>(this PropsBuilder<T> b, Var<bool> value) where T: IonBackdrop
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("tappable"), value);
    }
    /// <summary>
    /// If `true`, the backdrop will can be clicked and will emit the `ionBackdropTap` event.
    /// </summary>
    public static void SetTappable<T>(this PropsBuilder<T> b, bool value) where T: IonBackdrop
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("tappable"), b.Const(value));
    }

    /// <summary>
    /// If `true`, the backdrop will be visible.
    /// </summary>
    public static void SetVisible<T>(this PropsBuilder<T> b) where T: IonBackdrop
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("visible"), b.Const(true));
    }
    /// <summary>
    /// If `true`, the backdrop will be visible.
    /// </summary>
    public static void SetVisible<T>(this PropsBuilder<T> b, Var<bool> value) where T: IonBackdrop
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("visible"), value);
    }
    /// <summary>
    /// If `true`, the backdrop will be visible.
    /// </summary>
    public static void SetVisible<T>(this PropsBuilder<T> b, bool value) where T: IonBackdrop
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("visible"), b.Const(value));
    }

    /// <summary>
    /// Emitted when the backdrop is tapped.
    /// </summary>
    public static void OnIonBackdropTap<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonBackdrop
    {
        b.OnEventAction("onionBackdropTap", action);
    }
    /// <summary>
    /// Emitted when the backdrop is tapped.
    /// </summary>
    public static void OnIonBackdropTap<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonBackdrop
    {
        b.OnEventAction("onionBackdropTap", b.MakeAction(action));
    }

}

