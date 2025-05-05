using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Ionic;


public partial class IonBackdrop
{
}

public static partial class IonBackdropControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonBackdrop(this HtmlBuilder b, Action<AttributesBuilder<IonBackdrop>> buildAttributes, params IHtmlNode[] children)
    {
        return b.IonicTag("ion-backdrop", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonBackdrop(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.IonicTag("ion-backdrop", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonBackdrop(this HtmlBuilder b, Action<AttributesBuilder<IonBackdrop>> buildAttributes, List<IHtmlNode> children)
    {
        return b.IonicTag("ion-backdrop", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonBackdrop(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.IonicTag("ion-backdrop", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> If `true`, the backdrop will stop propagation on tap. </para>
    /// </summary>
    public static void SetStopPropagation(this AttributesBuilder<IonBackdrop> b)
    {
        b.SetAttribute("stop-propagation", "");
    }

    /// <summary>
    /// <para> If `true`, the backdrop will stop propagation on tap. </para>
    /// </summary>
    public static void SetStopPropagation(this AttributesBuilder<IonBackdrop> b, bool stopPropagation)
    {
        if (stopPropagation) b.SetAttribute("stop-propagation", "");
    }

    /// <summary>
    /// <para> If `true`, the backdrop will can be clicked and will emit the `ionBackdropTap` event. </para>
    /// </summary>
    public static void SetTappable(this AttributesBuilder<IonBackdrop> b)
    {
        b.SetAttribute("tappable", "");
    }

    /// <summary>
    /// <para> If `true`, the backdrop will can be clicked and will emit the `ionBackdropTap` event. </para>
    /// </summary>
    public static void SetTappable(this AttributesBuilder<IonBackdrop> b, bool tappable)
    {
        if (tappable) b.SetAttribute("tappable", "");
    }

    /// <summary>
    /// <para> If `true`, the backdrop will be visible. </para>
    /// </summary>
    public static void SetVisible(this AttributesBuilder<IonBackdrop> b)
    {
        b.SetAttribute("visible", "");
    }

    /// <summary>
    /// <para> If `true`, the backdrop will be visible. </para>
    /// </summary>
    public static void SetVisible(this AttributesBuilder<IonBackdrop> b, bool visible)
    {
        if (visible) b.SetAttribute("visible", "");
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
    /// <para> If `true`, the backdrop will stop propagation on tap. </para>
    /// </summary>
    public static void SetStopPropagation<T>(this PropsBuilder<T> b) where T: IonBackdrop
    {
        b.SetProperty(b.Props, b.Const("stopPropagation"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, the backdrop will stop propagation on tap. </para>
    /// </summary>
    public static void SetStopPropagation<T>(this PropsBuilder<T> b, Var<bool> stopPropagation) where T: IonBackdrop
    {
        b.SetProperty(b.Props, b.Const("stopPropagation"), stopPropagation);
    }

    /// <summary>
    /// <para> If `true`, the backdrop will stop propagation on tap. </para>
    /// </summary>
    public static void SetStopPropagation<T>(this PropsBuilder<T> b, bool stopPropagation) where T: IonBackdrop
    {
        b.SetProperty(b.Props, b.Const("stopPropagation"), b.Const(stopPropagation));
    }


    /// <summary>
    /// <para> If `true`, the backdrop will can be clicked and will emit the `ionBackdropTap` event. </para>
    /// </summary>
    public static void SetTappable<T>(this PropsBuilder<T> b) where T: IonBackdrop
    {
        b.SetProperty(b.Props, b.Const("tappable"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, the backdrop will can be clicked and will emit the `ionBackdropTap` event. </para>
    /// </summary>
    public static void SetTappable<T>(this PropsBuilder<T> b, Var<bool> tappable) where T: IonBackdrop
    {
        b.SetProperty(b.Props, b.Const("tappable"), tappable);
    }

    /// <summary>
    /// <para> If `true`, the backdrop will can be clicked and will emit the `ionBackdropTap` event. </para>
    /// </summary>
    public static void SetTappable<T>(this PropsBuilder<T> b, bool tappable) where T: IonBackdrop
    {
        b.SetProperty(b.Props, b.Const("tappable"), b.Const(tappable));
    }


    /// <summary>
    /// <para> If `true`, the backdrop will be visible. </para>
    /// </summary>
    public static void SetVisible<T>(this PropsBuilder<T> b) where T: IonBackdrop
    {
        b.SetProperty(b.Props, b.Const("visible"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, the backdrop will be visible. </para>
    /// </summary>
    public static void SetVisible<T>(this PropsBuilder<T> b, Var<bool> visible) where T: IonBackdrop
    {
        b.SetProperty(b.Props, b.Const("visible"), visible);
    }

    /// <summary>
    /// <para> If `true`, the backdrop will be visible. </para>
    /// </summary>
    public static void SetVisible<T>(this PropsBuilder<T> b, bool visible) where T: IonBackdrop
    {
        b.SetProperty(b.Props, b.Const("visible"), b.Const(visible));
    }


    /// <summary>
    /// <para> Emitted when the backdrop is tapped. </para>
    /// </summary>
    public static void OnIonBackdropTap<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonBackdrop
    {
        b.OnEventAction("onionBackdropTap", action);
    }
    /// <summary>
    /// <para> Emitted when the backdrop is tapped. </para>
    /// </summary>
    public static void OnIonBackdropTap<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonBackdrop
    {
        b.OnEventAction("onionBackdropTap", b.MakeAction(action));
    }

}

