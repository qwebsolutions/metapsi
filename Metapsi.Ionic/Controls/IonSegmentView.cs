using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Ionic;


public partial class IonSegmentView
{
}

public static partial class IonSegmentViewControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonSegmentView(this HtmlBuilder b, Action<AttributesBuilder<IonSegmentView>> buildAttributes, params IHtmlNode[] children)
    {
        return b.IonicTag("ion-segment-view", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonSegmentView(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.IonicTag("ion-segment-view", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonSegmentView(this HtmlBuilder b, Action<AttributesBuilder<IonSegmentView>> buildAttributes, List<IHtmlNode> children)
    {
        return b.IonicTag("ion-segment-view", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonSegmentView(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.IonicTag("ion-segment-view", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> If `true`, the segment view cannot be interacted with. </para>
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<IonSegmentView> b)
    {
        b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// <para> If `true`, the segment view cannot be interacted with. </para>
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<IonSegmentView> b, bool disabled)
    {
        if (disabled) b.SetAttribute("disabled", "");
    }

    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonSegmentView(this LayoutBuilder b, Action<PropsBuilder<IonSegmentView>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-segment-view", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonSegmentView(this LayoutBuilder b, Action<PropsBuilder<IonSegmentView>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-segment-view", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonSegmentView(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-segment-view", children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonSegmentView(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-segment-view", children);
    }
    /// <summary>
    /// <para> If `true`, the segment view cannot be interacted with. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b) where T: IonSegmentView
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, the segment view cannot be interacted with. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, Var<bool> disabled) where T: IonSegmentView
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), disabled);
    }

    /// <summary>
    /// <para> If `true`, the segment view cannot be interacted with. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, bool disabled) where T: IonSegmentView
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), b.Const(disabled));
    }


    /// <summary>
    /// <para> Emitted when the segment view is scrolled. </para>
    /// </summary>
    public static void OnIonSegmentViewScroll<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, SegmentViewScrollEvent>> action) where TComponent: IonSegmentView
    {
        b.OnEventAction("onionSegmentViewScroll", action, "detail");
    }
    /// <summary>
    /// <para> Emitted when the segment view is scrolled. </para>
    /// </summary>
    public static void OnIonSegmentViewScroll<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SegmentViewScrollEvent>, Var<TModel>> action) where TComponent: IonSegmentView
    {
        b.OnEventAction("onionSegmentViewScroll", b.MakeAction(action), "detail");
    }

}

