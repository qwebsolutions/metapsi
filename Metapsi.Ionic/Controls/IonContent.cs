using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Ionic;


public partial class IonContent
{
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
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDanger(this PropsBuilder<IonContent> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("danger"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDark(this PropsBuilder<IonContent> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("dark"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorLight(this PropsBuilder<IonContent> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("light"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorMedium(this PropsBuilder<IonContent> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("medium"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorPrimary(this PropsBuilder<IonContent> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("primary"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSecondary(this PropsBuilder<IonContent> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("secondary"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSuccess(this PropsBuilder<IonContent> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("success"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorTertiary(this PropsBuilder<IonContent> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("tertiary"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorWarning(this PropsBuilder<IonContent> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("warning"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor(this PropsBuilder<IonContent> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), value);
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor(this PropsBuilder<IonContent> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const(value));
    }

    /// <summary>
    /// If `true` and the content does not cause an overflow scroll, the scroll interaction will cause a bounce. If the content exceeds the bounds of ionContent, nothing will change. Note, this does not disable the system bounce on iOS. That is an OS level setting.
    /// </summary>
    public static void SetForceOverscroll(this PropsBuilder<IonContent> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("forceOverscroll"), b.Const(true));
    }

    /// <summary>
    /// If `true`, the content will scroll behind the headers and footers. This effect can easily be seen by setting the toolbar to transparent.
    /// </summary>
    public static void SetFullscreen(this PropsBuilder<IonContent> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("fullscreen"), b.Const(true));
    }

    /// <summary>
    /// Because of performance reasons, ionScroll events are disabled by default, in order to enable them and start listening from (ionScroll), set this property to `true`.
    /// </summary>
    public static void SetScrollEvents(this PropsBuilder<IonContent> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("scrollEvents"), b.Const(true));
    }

    /// <summary>
    /// If you want to enable the content scrolling in the X axis, set this property to `true`.
    /// </summary>
    public static void SetScrollX(this PropsBuilder<IonContent> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("scrollX"), b.Const(true));
    }

    /// <summary>
    /// If you want to disable the content scrolling in the Y axis, set this property to `false`.
    /// </summary>
    public static void SetScrollY(this PropsBuilder<IonContent> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("scrollY"), b.Const(true));
    }

    /// <summary>
    /// Emitted while scrolling. This event is disabled by default. Set `scrollEvents` to `true` to enable.
    /// </summary>
    public static void OnIonScroll<TModel>(this PropsBuilder<IonContent> b, Var<HyperType.Action<TModel, ScrollDetail>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<ScrollDetail>("detail"));
            return b.MakeActionDescriptor<TModel, ScrollDetail>(action, value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onionScroll"), eventAction);
    }
    /// <summary>
    /// Emitted while scrolling. This event is disabled by default. Set `scrollEvents` to `true` to enable.
    /// </summary>
    public static void OnIonScroll<TModel>(this PropsBuilder<IonContent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<ScrollDetail>, Var<TModel>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<ScrollDetail>("detail"));
            return b.MakeActionDescriptor<TModel, ScrollDetail>(b.MakeAction(action), value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onionScroll"), eventAction);
    }

    /// <summary>
    /// Emitted when the scroll has ended. This event is disabled by default. Set `scrollEvents` to `true` to enable.
    /// </summary>
    public static void OnIonScrollEnd<TModel>(this PropsBuilder<IonContent> b, Var<HyperType.Action<TModel, ScrollBaseDetail>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<ScrollBaseDetail>("detail"));
            return b.MakeActionDescriptor<TModel, ScrollBaseDetail>(action, value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onionScrollEnd"), eventAction);
    }
    /// <summary>
    /// Emitted when the scroll has ended. This event is disabled by default. Set `scrollEvents` to `true` to enable.
    /// </summary>
    public static void OnIonScrollEnd<TModel>(this PropsBuilder<IonContent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<ScrollBaseDetail>, Var<TModel>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<ScrollBaseDetail>("detail"));
            return b.MakeActionDescriptor<TModel, ScrollBaseDetail>(b.MakeAction(action), value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onionScrollEnd"), eventAction);
    }

    /// <summary>
    /// Emitted when the scroll has started. This event is disabled by default. Set `scrollEvents` to `true` to enable.
    /// </summary>
    public static void OnIonScrollStart<TModel>(this PropsBuilder<IonContent> b, Var<HyperType.Action<TModel, ScrollBaseDetail>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<ScrollBaseDetail>("detail"));
            return b.MakeActionDescriptor<TModel, ScrollBaseDetail>(action, value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onionScrollStart"), eventAction);
    }
    /// <summary>
    /// Emitted when the scroll has started. This event is disabled by default. Set `scrollEvents` to `true` to enable.
    /// </summary>
    public static void OnIonScrollStart<TModel>(this PropsBuilder<IonContent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<ScrollBaseDetail>, Var<TModel>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<ScrollBaseDetail>("detail"));
            return b.MakeActionDescriptor<TModel, ScrollBaseDetail>(b.MakeAction(action), value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onionScrollStart"), eventAction);
    }

}

