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
    /// <para> Content is placed in the scrollable area if provided without a slot. </para>
    /// </summary>
    public static class Slot
    {
        /// <summary>
        /// <para> Should be used for fixed content that should not scroll. </para>
        /// </summary>
        public const string Fixed = "fixed";
    }
    public static class Method
    {
        /// <summary>
        /// <para> Get the element where the actual scrolling takes place. This element can be used to subscribe to `scroll` events or manually modify `scrollTop`. However, it's recommended to use the API provided by `ion-content`:  i.e. Using `ionScroll`, `ionScrollStart`, `ionScrollEnd` for scrolling events and `scrollToPoint()` to scroll the content into a certain point. </para>
        /// <para> () =&gt; Promise&lt;HTMLElement&gt; </para>
        /// </summary>
        public const string GetScrollElement = "getScrollElement";
        /// <summary>
        /// <para> Scroll by a specified X/Y distance in the component. </para>
        /// <para> (x: number, y: number, duration: number) =&gt; Promise&lt;void&gt; </para>
        /// <para> x The amount to scroll by on the horizontal axis. </para>
        /// <para> y The amount to scroll by on the vertical axis. </para>
        /// <para> duration The amount of time to take scrolling by that amount. </para>
        /// </summary>
        public const string ScrollByPoint = "scrollByPoint";
        /// <summary>
        /// <para> Scroll to the bottom of the component. </para>
        /// <para> (duration?: number) =&gt; Promise&lt;void&gt; </para>
        /// <para> duration The amount of time to take scrolling to the bottom. Defaults to `0`. </para>
        /// </summary>
        public const string ScrollToBottom = "scrollToBottom";
        /// <summary>
        /// <para> Scroll to a specified X/Y location in the component. </para>
        /// <para> (x: number | undefined | null, y: number | undefined | null, duration?: number) =&gt; Promise&lt;void&gt; </para>
        /// <para> x The point to scroll to on the horizontal axis. </para>
        /// <para> y The point to scroll to on the vertical axis. </para>
        /// <para> duration The amount of time to take scrolling to that point. Defaults to `0`. </para>
        /// </summary>
        public const string ScrollToPoint = "scrollToPoint";
        /// <summary>
        /// <para> Scroll to the top of the component. </para>
        /// <para> (duration?: number) =&gt; Promise&lt;void&gt; </para>
        /// <para> duration The amount of time to take scrolling to the top. Defaults to `0`. </para>
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
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColor(this AttributesBuilder<IonContent> b,string color)
    {
        b.SetAttribute("color", color);
    }

    /// <summary>
    /// <para> If `true` and the content does not cause an overflow scroll, the scroll interaction will cause a bounce. If the content exceeds the bounds of ionContent, nothing will change. Note, this does not disable the system bounce on iOS. That is an OS level setting. </para>
    /// </summary>
    public static void SetForceOverscroll(this AttributesBuilder<IonContent> b)
    {
        b.SetAttribute("force-overscroll", "");
    }

    /// <summary>
    /// <para> If `true` and the content does not cause an overflow scroll, the scroll interaction will cause a bounce. If the content exceeds the bounds of ionContent, nothing will change. Note, this does not disable the system bounce on iOS. That is an OS level setting. </para>
    /// </summary>
    public static void SetForceOverscroll(this AttributesBuilder<IonContent> b,bool forceOverscroll)
    {
        if (forceOverscroll) b.SetAttribute("force-overscroll", "");
    }

    /// <summary>
    /// <para> If `true`, the content will scroll behind the headers and footers. This effect can easily be seen by setting the toolbar to transparent. </para>
    /// </summary>
    public static void SetFullscreen(this AttributesBuilder<IonContent> b)
    {
        b.SetAttribute("fullscreen", "");
    }

    /// <summary>
    /// <para> If `true`, the content will scroll behind the headers and footers. This effect can easily be seen by setting the toolbar to transparent. </para>
    /// </summary>
    public static void SetFullscreen(this AttributesBuilder<IonContent> b,bool fullscreen)
    {
        if (fullscreen) b.SetAttribute("fullscreen", "");
    }

    /// <summary>
    /// <para> Because of performance reasons, ionScroll events are disabled by default, in order to enable them and start listening from (ionScroll), set this property to `true`. </para>
    /// </summary>
    public static void SetScrollEvents(this AttributesBuilder<IonContent> b)
    {
        b.SetAttribute("scroll-events", "");
    }

    /// <summary>
    /// <para> Because of performance reasons, ionScroll events are disabled by default, in order to enable them and start listening from (ionScroll), set this property to `true`. </para>
    /// </summary>
    public static void SetScrollEvents(this AttributesBuilder<IonContent> b,bool scrollEvents)
    {
        if (scrollEvents) b.SetAttribute("scroll-events", "");
    }

    /// <summary>
    /// <para> If you want to enable the content scrolling in the X axis, set this property to `true`. </para>
    /// </summary>
    public static void SetScrollX(this AttributesBuilder<IonContent> b)
    {
        b.SetAttribute("scroll-x", "");
    }

    /// <summary>
    /// <para> If you want to enable the content scrolling in the X axis, set this property to `true`. </para>
    /// </summary>
    public static void SetScrollX(this AttributesBuilder<IonContent> b,bool scrollX)
    {
        if (scrollX) b.SetAttribute("scroll-x", "");
    }

    /// <summary>
    /// <para> If you want to disable the content scrolling in the Y axis, set this property to `false`. </para>
    /// </summary>
    public static void SetScrollY(this AttributesBuilder<IonContent> b)
    {
        b.SetAttribute("scroll-y", "");
    }

    /// <summary>
    /// <para> If you want to disable the content scrolling in the Y axis, set this property to `false`. </para>
    /// </summary>
    public static void SetScrollY(this AttributesBuilder<IonContent> b,bool scrollY)
    {
        if (scrollY) b.SetAttribute("scroll-y", "");
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
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorDanger<T>(this PropsBuilder<T> b) where T: IonContent
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("danger"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorDark<T>(this PropsBuilder<T> b) where T: IonContent
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("dark"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorLight<T>(this PropsBuilder<T> b) where T: IonContent
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("light"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorMedium<T>(this PropsBuilder<T> b) where T: IonContent
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("medium"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorPrimary<T>(this PropsBuilder<T> b) where T: IonContent
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("primary"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorSecondary<T>(this PropsBuilder<T> b) where T: IonContent
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("secondary"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorSuccess<T>(this PropsBuilder<T> b) where T: IonContent
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("success"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorTertiary<T>(this PropsBuilder<T> b) where T: IonContent
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("tertiary"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorWarning<T>(this PropsBuilder<T> b) where T: IonContent
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("warning"));
    }


    /// <summary>
    /// <para> If `true` and the content does not cause an overflow scroll, the scroll interaction will cause a bounce. If the content exceeds the bounds of ionContent, nothing will change. Note, this does not disable the system bounce on iOS. That is an OS level setting. </para>
    /// </summary>
    public static void SetForceOverscroll<T>(this PropsBuilder<T> b) where T: IonContent
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("forceOverscroll"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true` and the content does not cause an overflow scroll, the scroll interaction will cause a bounce. If the content exceeds the bounds of ionContent, nothing will change. Note, this does not disable the system bounce on iOS. That is an OS level setting. </para>
    /// </summary>
    public static void SetForceOverscroll<T>(this PropsBuilder<T> b, Var<bool> forceOverscroll) where T: IonContent
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("forceOverscroll"), forceOverscroll);
    }

    /// <summary>
    /// <para> If `true` and the content does not cause an overflow scroll, the scroll interaction will cause a bounce. If the content exceeds the bounds of ionContent, nothing will change. Note, this does not disable the system bounce on iOS. That is an OS level setting. </para>
    /// </summary>
    public static void SetForceOverscroll<T>(this PropsBuilder<T> b, bool forceOverscroll) where T: IonContent
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("forceOverscroll"), b.Const(forceOverscroll));
    }


    /// <summary>
    /// <para> If `true`, the content will scroll behind the headers and footers. This effect can easily be seen by setting the toolbar to transparent. </para>
    /// </summary>
    public static void SetFullscreen<T>(this PropsBuilder<T> b) where T: IonContent
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("fullscreen"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, the content will scroll behind the headers and footers. This effect can easily be seen by setting the toolbar to transparent. </para>
    /// </summary>
    public static void SetFullscreen<T>(this PropsBuilder<T> b, Var<bool> fullscreen) where T: IonContent
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("fullscreen"), fullscreen);
    }

    /// <summary>
    /// <para> If `true`, the content will scroll behind the headers and footers. This effect can easily be seen by setting the toolbar to transparent. </para>
    /// </summary>
    public static void SetFullscreen<T>(this PropsBuilder<T> b, bool fullscreen) where T: IonContent
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("fullscreen"), b.Const(fullscreen));
    }


    /// <summary>
    /// <para> Because of performance reasons, ionScroll events are disabled by default, in order to enable them and start listening from (ionScroll), set this property to `true`. </para>
    /// </summary>
    public static void SetScrollEvents<T>(this PropsBuilder<T> b) where T: IonContent
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("scrollEvents"), b.Const(true));
    }


    /// <summary>
    /// <para> Because of performance reasons, ionScroll events are disabled by default, in order to enable them and start listening from (ionScroll), set this property to `true`. </para>
    /// </summary>
    public static void SetScrollEvents<T>(this PropsBuilder<T> b, Var<bool> scrollEvents) where T: IonContent
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("scrollEvents"), scrollEvents);
    }

    /// <summary>
    /// <para> Because of performance reasons, ionScroll events are disabled by default, in order to enable them and start listening from (ionScroll), set this property to `true`. </para>
    /// </summary>
    public static void SetScrollEvents<T>(this PropsBuilder<T> b, bool scrollEvents) where T: IonContent
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("scrollEvents"), b.Const(scrollEvents));
    }


    /// <summary>
    /// <para> If you want to enable the content scrolling in the X axis, set this property to `true`. </para>
    /// </summary>
    public static void SetScrollX<T>(this PropsBuilder<T> b) where T: IonContent
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("scrollX"), b.Const(true));
    }


    /// <summary>
    /// <para> If you want to enable the content scrolling in the X axis, set this property to `true`. </para>
    /// </summary>
    public static void SetScrollX<T>(this PropsBuilder<T> b, Var<bool> scrollX) where T: IonContent
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("scrollX"), scrollX);
    }

    /// <summary>
    /// <para> If you want to enable the content scrolling in the X axis, set this property to `true`. </para>
    /// </summary>
    public static void SetScrollX<T>(this PropsBuilder<T> b, bool scrollX) where T: IonContent
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("scrollX"), b.Const(scrollX));
    }


    /// <summary>
    /// <para> If you want to disable the content scrolling in the Y axis, set this property to `false`. </para>
    /// </summary>
    public static void SetScrollY<T>(this PropsBuilder<T> b) where T: IonContent
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("scrollY"), b.Const(true));
    }


    /// <summary>
    /// <para> If you want to disable the content scrolling in the Y axis, set this property to `false`. </para>
    /// </summary>
    public static void SetScrollY<T>(this PropsBuilder<T> b, Var<bool> scrollY) where T: IonContent
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("scrollY"), scrollY);
    }

    /// <summary>
    /// <para> If you want to disable the content scrolling in the Y axis, set this property to `false`. </para>
    /// </summary>
    public static void SetScrollY<T>(this PropsBuilder<T> b, bool scrollY) where T: IonContent
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("scrollY"), b.Const(scrollY));
    }


    /// <summary>
    /// <para> Emitted while scrolling. This event is disabled by default. Set `scrollEvents` to `true` to enable. </para>
    /// </summary>
    public static void OnIonScroll<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, ScrollDetail>> action) where TComponent: IonContent
    {
        b.OnEventAction("onionScroll", action, "detail");
    }
    /// <summary>
    /// <para> Emitted while scrolling. This event is disabled by default. Set `scrollEvents` to `true` to enable. </para>
    /// </summary>
    public static void OnIonScroll<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<ScrollDetail>, Var<TModel>> action) where TComponent: IonContent
    {
        b.OnEventAction("onionScroll", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// <para> Emitted when the scroll has ended. This event is disabled by default. Set `scrollEvents` to `true` to enable. </para>
    /// </summary>
    public static void OnIonScrollEnd<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, ScrollBaseDetail>> action) where TComponent: IonContent
    {
        b.OnEventAction("onionScrollEnd", action, "detail");
    }
    /// <summary>
    /// <para> Emitted when the scroll has ended. This event is disabled by default. Set `scrollEvents` to `true` to enable. </para>
    /// </summary>
    public static void OnIonScrollEnd<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<ScrollBaseDetail>, Var<TModel>> action) where TComponent: IonContent
    {
        b.OnEventAction("onionScrollEnd", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// <para> Emitted when the scroll has started. This event is disabled by default. Set `scrollEvents` to `true` to enable. </para>
    /// </summary>
    public static void OnIonScrollStart<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, ScrollBaseDetail>> action) where TComponent: IonContent
    {
        b.OnEventAction("onionScrollStart", action, "detail");
    }
    /// <summary>
    /// <para> Emitted when the scroll has started. This event is disabled by default. Set `scrollEvents` to `true` to enable. </para>
    /// </summary>
    public static void OnIonScrollStart<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<ScrollBaseDetail>, Var<TModel>> action) where TComponent: IonContent
    {
        b.OnEventAction("onionScrollStart", b.MakeAction(action), "detail");
    }

}

