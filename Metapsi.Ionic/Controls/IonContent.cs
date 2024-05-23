using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Ionic;


public partial class IonContent : IonComponent
{
    public IonContent() : base("ion-content") { }
    /// <summary> 
    /// Content is placed in the scrollable area if provided without a slot.
    /// </summary>
    public static class Slot
    {
        /// <summary> 
        /// Should be used for fixed content that should not scroll.
        /// </summary>
        public const string Fixed = "fixed";
    }
    public static class Method
    {
        /// <summary> 
        /// Get the element where the actual scrolling takes place. This element can be used to subscribe to `scroll` events or manually modify `scrollTop`. However, it's recommended to use the API provided by `ion-content`:  i.e. Using `ionScroll`, `ionScrollStart`, `ionScrollEnd` for scrolling events and `scrollToPoint()` to scroll the content into a certain point.
        /// <para>() =&gt; Promise&lt;HTMLElement&gt;</para>
        /// </summary>
        public const string GetScrollElement = "getScrollElement";
        /// <summary> 
        /// Scroll by a specified X/Y distance in the component.
        /// <para>(x: number, y: number, duration: number) =&gt; Promise&lt;void&gt;</para>
        /// <para>x The amount to scroll by on the horizontal axis.</para>
        /// <para>y The amount to scroll by on the vertical axis.</para>
        /// <para>duration The amount of time to take scrolling by that amount.</para>
        /// </summary>
        public const string ScrollByPoint = "scrollByPoint";
        /// <summary> 
        /// Scroll to the bottom of the component.
        /// <para>(duration?: number) =&gt; Promise&lt;void&gt;</para>
        /// <para>duration The amount of time to take scrolling to the bottom. Defaults to `0`.</para>
        /// </summary>
        public const string ScrollToBottom = "scrollToBottom";
        /// <summary> 
        /// Scroll to a specified X/Y location in the component.
        /// <para>(x: number | undefined | null, y: number | undefined | null, duration?: number) =&gt; Promise&lt;void&gt;</para>
        /// <para>x The point to scroll to on the horizontal axis.</para>
        /// <para>y The point to scroll to on the vertical axis.</para>
        /// <para>duration The amount of time to take scrolling to that point. Defaults to `0`.</para>
        /// </summary>
        public const string ScrollToPoint = "scrollToPoint";
        /// <summary> 
        /// Scroll to the top of the component.
        /// <para>(duration?: number) =&gt; Promise&lt;void&gt;</para>
        /// <para>duration The amount of time to take scrolling to the top. Defaults to `0`.</para>
        /// </summary>
        public const string ScrollToTop = "scrollToTop";
    }
}

public static partial class IonContentControl
{
    /// <summary>
    /// 
    /// </summary>
    public static IHtmlNode IonContent(this HtmlBuilder b, Action<AttributesBuilder<IonContent>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("ion-content", buildAttributes, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static IHtmlNode IonContent(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("ion-content", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor(this AttributesBuilder<IonContent> b, string value)
    {
        b.SetAttribute("color", value);
    }

    /// <summary>
    /// If `true` and the content does not cause an overflow scroll, the scroll interaction will cause a bounce. If the content exceeds the bounds of ionContent, nothing will change. Note, this does not disable the system bounce on iOS. That is an OS level setting.
    /// </summary>
    public static void SetForceOverscroll(this AttributesBuilder<IonContent> b)
    {
        b.SetAttribute("force-overscroll", "");
    }
    /// <summary>
    /// If `true` and the content does not cause an overflow scroll, the scroll interaction will cause a bounce. If the content exceeds the bounds of ionContent, nothing will change. Note, this does not disable the system bounce on iOS. That is an OS level setting.
    /// </summary>
    public static void SetForceOverscroll(this AttributesBuilder<IonContent> b, bool value)
    {
        if (value) b.SetAttribute("force-overscroll", "");
    }

    /// <summary>
    /// If `true`, the content will scroll behind the headers and footers. This effect can easily be seen by setting the toolbar to transparent.
    /// </summary>
    public static void SetFullscreen(this AttributesBuilder<IonContent> b)
    {
        b.SetAttribute("fullscreen", "");
    }
    /// <summary>
    /// If `true`, the content will scroll behind the headers and footers. This effect can easily be seen by setting the toolbar to transparent.
    /// </summary>
    public static void SetFullscreen(this AttributesBuilder<IonContent> b, bool value)
    {
        if (value) b.SetAttribute("fullscreen", "");
    }

    /// <summary>
    /// Because of performance reasons, ionScroll events are disabled by default, in order to enable them and start listening from (ionScroll), set this property to `true`.
    /// </summary>
    public static void SetScrollEvents(this AttributesBuilder<IonContent> b)
    {
        b.SetAttribute("scroll-events", "");
    }
    /// <summary>
    /// Because of performance reasons, ionScroll events are disabled by default, in order to enable them and start listening from (ionScroll), set this property to `true`.
    /// </summary>
    public static void SetScrollEvents(this AttributesBuilder<IonContent> b, bool value)
    {
        if (value) b.SetAttribute("scroll-events", "");
    }

    /// <summary>
    /// If you want to enable the content scrolling in the X axis, set this property to `true`.
    /// </summary>
    public static void SetScrollX(this AttributesBuilder<IonContent> b)
    {
        b.SetAttribute("scroll-x", "");
    }
    /// <summary>
    /// If you want to enable the content scrolling in the X axis, set this property to `true`.
    /// </summary>
    public static void SetScrollX(this AttributesBuilder<IonContent> b, bool value)
    {
        if (value) b.SetAttribute("scroll-x", "");
    }

    /// <summary>
    /// If you want to disable the content scrolling in the Y axis, set this property to `false`.
    /// </summary>
    public static void SetScrollY(this AttributesBuilder<IonContent> b)
    {
        b.SetAttribute("scroll-y", "");
    }
    /// <summary>
    /// If you want to disable the content scrolling in the Y axis, set this property to `false`.
    /// </summary>
    public static void SetScrollY(this AttributesBuilder<IonContent> b, bool value)
    {
        if (value) b.SetAttribute("scroll-y", "");
    }

    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonContent(this LayoutBuilder b, Action<PropsBuilder<IonContent>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-content", buildProps, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonContent(this LayoutBuilder b, Action<PropsBuilder<IonContent>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-content", buildProps, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonContent(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-content", children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonContent(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-content", children);
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDanger<T>(this PropsBuilder<T> b) where T: IonContent
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("danger"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDark<T>(this PropsBuilder<T> b) where T: IonContent
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("dark"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorLight<T>(this PropsBuilder<T> b) where T: IonContent
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("light"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorMedium<T>(this PropsBuilder<T> b) where T: IonContent
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("medium"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorPrimary<T>(this PropsBuilder<T> b) where T: IonContent
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("primary"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSecondary<T>(this PropsBuilder<T> b) where T: IonContent
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("secondary"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSuccess<T>(this PropsBuilder<T> b) where T: IonContent
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("success"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorTertiary<T>(this PropsBuilder<T> b) where T: IonContent
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("tertiary"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorWarning<T>(this PropsBuilder<T> b) where T: IonContent
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("warning"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor<T>(this PropsBuilder<T> b, Var<string> value) where T: IonContent
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), value);
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor<T>(this PropsBuilder<T> b, string value) where T: IonContent
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const(value));
    }

    /// <summary>
    /// If `true` and the content does not cause an overflow scroll, the scroll interaction will cause a bounce. If the content exceeds the bounds of ionContent, nothing will change. Note, this does not disable the system bounce on iOS. That is an OS level setting.
    /// </summary>
    public static void SetForceOverscroll<T>(this PropsBuilder<T> b) where T: IonContent
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("forceOverscroll"), b.Const(true));
    }
    /// <summary>
    /// If `true` and the content does not cause an overflow scroll, the scroll interaction will cause a bounce. If the content exceeds the bounds of ionContent, nothing will change. Note, this does not disable the system bounce on iOS. That is an OS level setting.
    /// </summary>
    public static void SetForceOverscroll<T>(this PropsBuilder<T> b, Var<bool> value) where T: IonContent
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("forceOverscroll"), value);
    }
    /// <summary>
    /// If `true` and the content does not cause an overflow scroll, the scroll interaction will cause a bounce. If the content exceeds the bounds of ionContent, nothing will change. Note, this does not disable the system bounce on iOS. That is an OS level setting.
    /// </summary>
    public static void SetForceOverscroll<T>(this PropsBuilder<T> b, bool value) where T: IonContent
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("forceOverscroll"), b.Const(value));
    }

    /// <summary>
    /// If `true`, the content will scroll behind the headers and footers. This effect can easily be seen by setting the toolbar to transparent.
    /// </summary>
    public static void SetFullscreen<T>(this PropsBuilder<T> b) where T: IonContent
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("fullscreen"), b.Const(true));
    }
    /// <summary>
    /// If `true`, the content will scroll behind the headers and footers. This effect can easily be seen by setting the toolbar to transparent.
    /// </summary>
    public static void SetFullscreen<T>(this PropsBuilder<T> b, Var<bool> value) where T: IonContent
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("fullscreen"), value);
    }
    /// <summary>
    /// If `true`, the content will scroll behind the headers and footers. This effect can easily be seen by setting the toolbar to transparent.
    /// </summary>
    public static void SetFullscreen<T>(this PropsBuilder<T> b, bool value) where T: IonContent
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("fullscreen"), b.Const(value));
    }

    /// <summary>
    /// Because of performance reasons, ionScroll events are disabled by default, in order to enable them and start listening from (ionScroll), set this property to `true`.
    /// </summary>
    public static void SetScrollEvents<T>(this PropsBuilder<T> b) where T: IonContent
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("scrollEvents"), b.Const(true));
    }
    /// <summary>
    /// Because of performance reasons, ionScroll events are disabled by default, in order to enable them and start listening from (ionScroll), set this property to `true`.
    /// </summary>
    public static void SetScrollEvents<T>(this PropsBuilder<T> b, Var<bool> value) where T: IonContent
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("scrollEvents"), value);
    }
    /// <summary>
    /// Because of performance reasons, ionScroll events are disabled by default, in order to enable them and start listening from (ionScroll), set this property to `true`.
    /// </summary>
    public static void SetScrollEvents<T>(this PropsBuilder<T> b, bool value) where T: IonContent
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("scrollEvents"), b.Const(value));
    }

    /// <summary>
    /// If you want to enable the content scrolling in the X axis, set this property to `true`.
    /// </summary>
    public static void SetScrollX<T>(this PropsBuilder<T> b) where T: IonContent
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("scrollX"), b.Const(true));
    }
    /// <summary>
    /// If you want to enable the content scrolling in the X axis, set this property to `true`.
    /// </summary>
    public static void SetScrollX<T>(this PropsBuilder<T> b, Var<bool> value) where T: IonContent
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("scrollX"), value);
    }
    /// <summary>
    /// If you want to enable the content scrolling in the X axis, set this property to `true`.
    /// </summary>
    public static void SetScrollX<T>(this PropsBuilder<T> b, bool value) where T: IonContent
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("scrollX"), b.Const(value));
    }

    /// <summary>
    /// If you want to disable the content scrolling in the Y axis, set this property to `false`.
    /// </summary>
    public static void SetScrollY<T>(this PropsBuilder<T> b) where T: IonContent
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("scrollY"), b.Const(true));
    }
    /// <summary>
    /// If you want to disable the content scrolling in the Y axis, set this property to `false`.
    /// </summary>
    public static void SetScrollY<T>(this PropsBuilder<T> b, Var<bool> value) where T: IonContent
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("scrollY"), value);
    }
    /// <summary>
    /// If you want to disable the content scrolling in the Y axis, set this property to `false`.
    /// </summary>
    public static void SetScrollY<T>(this PropsBuilder<T> b, bool value) where T: IonContent
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("scrollY"), b.Const(value));
    }

    /// <summary>
    /// Emitted while scrolling. This event is disabled by default. Set `scrollEvents` to `true` to enable.
    /// </summary>
    public static void OnIonScroll<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, ScrollDetail>> action) where TComponent: IonContent
    {
        b.OnEventAction("onionScroll", action, "detail");
    }
    /// <summary>
    /// Emitted while scrolling. This event is disabled by default. Set `scrollEvents` to `true` to enable.
    /// </summary>
    public static void OnIonScroll<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<ScrollDetail>, Var<TModel>> action) where TComponent: IonContent
    {
        b.OnEventAction("onionScroll", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// Emitted when the scroll has ended. This event is disabled by default. Set `scrollEvents` to `true` to enable.
    /// </summary>
    public static void OnIonScrollEnd<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, ScrollBaseDetail>> action) where TComponent: IonContent
    {
        b.OnEventAction("onionScrollEnd", action, "detail");
    }
    /// <summary>
    /// Emitted when the scroll has ended. This event is disabled by default. Set `scrollEvents` to `true` to enable.
    /// </summary>
    public static void OnIonScrollEnd<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<ScrollBaseDetail>, Var<TModel>> action) where TComponent: IonContent
    {
        b.OnEventAction("onionScrollEnd", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// Emitted when the scroll has started. This event is disabled by default. Set `scrollEvents` to `true` to enable.
    /// </summary>
    public static void OnIonScrollStart<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, ScrollBaseDetail>> action) where TComponent: IonContent
    {
        b.OnEventAction("onionScrollStart", action, "detail");
    }
    /// <summary>
    /// Emitted when the scroll has started. This event is disabled by default. Set `scrollEvents` to `true` to enable.
    /// </summary>
    public static void OnIonScrollStart<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<ScrollBaseDetail>, Var<TModel>> action) where TComponent: IonContent
    {
        b.OnEventAction("onionScrollStart", b.MakeAction(action), "detail");
    }

}

