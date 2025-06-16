using Metapsi.Html;
using Metapsi.Syntax;
using Metapsi.Hyperapp;

namespace Metapsi.Ionic;

/// <summary>
/// 
/// </summary>
public partial class IonContent
{
    /// <summary>
    /// 
    /// </summary>
    public static class Slot
    {
        /// <summary>
        /// Should be used for fixed content that should not scroll.
        /// </summary>
        public const string Fixed = "fixed";
    }
    /// <summary>
    /// 
    /// </summary>
    public static class Method
    {
        /// <summary>
        /// Get the element where the actual scrolling takes place. This element can be used to subscribe to `scroll` events or manually modify `scrollTop`. However, it's recommended to use the API provided by `ion-content`:  i.e. Using `ionScroll`, `ionScrollStart`, `ionScrollEnd` for scrolling events and `scrollToPoint()` to scroll the content into a certain point.
        /// </summary>
        public const string GetScrollElement = "getScrollElement";
        /// <summary>
        /// Scroll by a specified X/Y distance in the component.
        /// </summary>
        public const string ScrollByPoint = "scrollByPoint";
        /// <summary>
        /// Scroll to the bottom of the component.
        /// </summary>
        public const string ScrollToBottom = "scrollToBottom";
        /// <summary>
        /// Scroll to a specified X/Y location in the component.
        /// </summary>
        public const string ScrollToPoint = "scrollToPoint";
        /// <summary>
        /// Scroll to the top of the component.
        /// </summary>
        public const string ScrollToTop = "scrollToTop";
    }
}
/// <summary>
/// Setter extensions of IonContent
/// </summary>
public static partial class IonContentControl
{
    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonContent(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonContent>> buildAttributes, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.IonicTag("ion-content", buildAttributes, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonContent(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.IonicTag("ion-content", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonContent(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonContent>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.IonicTag("ion-content", buildAttributes, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonContent(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.IonicTag("ion-content", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDanger(this Metapsi.Html.AttributesBuilder<IonContent> b) 
    {
        b.SetAttribute("color", "danger");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDark(this Metapsi.Html.AttributesBuilder<IonContent> b) 
    {
        b.SetAttribute("color", "dark");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorLight(this Metapsi.Html.AttributesBuilder<IonContent> b) 
    {
        b.SetAttribute("color", "light");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorMedium(this Metapsi.Html.AttributesBuilder<IonContent> b) 
    {
        b.SetAttribute("color", "medium");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorPrimary(this Metapsi.Html.AttributesBuilder<IonContent> b) 
    {
        b.SetAttribute("color", "primary");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSecondary(this Metapsi.Html.AttributesBuilder<IonContent> b) 
    {
        b.SetAttribute("color", "secondary");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSuccess(this Metapsi.Html.AttributesBuilder<IonContent> b) 
    {
        b.SetAttribute("color", "success");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorTertiary(this Metapsi.Html.AttributesBuilder<IonContent> b) 
    {
        b.SetAttribute("color", "tertiary");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorWarning(this Metapsi.Html.AttributesBuilder<IonContent> b) 
    {
        b.SetAttribute("color", "warning");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor(this Metapsi.Html.AttributesBuilder<IonContent> b, string color) 
    {
        b.SetAttribute("color", color);
    }

    /// <summary>
    /// Controls where the fixed content is placed relative to the main content in the DOM. This can be used to control the order in which fixed elements receive keyboard focus. For example, if a FAB in the fixed slot should receive keyboard focus before the main page content, set this property to `'before'`.
    /// </summary>
    public static void SetFixedSlotPlacementAfter(this Metapsi.Html.AttributesBuilder<IonContent> b) 
    {
        b.SetAttribute("fixedSlotPlacement", "after");
    }

    /// <summary>
    /// Controls where the fixed content is placed relative to the main content in the DOM. This can be used to control the order in which fixed elements receive keyboard focus. For example, if a FAB in the fixed slot should receive keyboard focus before the main page content, set this property to `'before'`.
    /// </summary>
    public static void SetFixedSlotPlacementBefore(this Metapsi.Html.AttributesBuilder<IonContent> b) 
    {
        b.SetAttribute("fixedSlotPlacement", "before");
    }

    /// <summary>
    /// If `true` and the content does not cause an overflow scroll, the scroll interaction will cause a bounce. If the content exceeds the bounds of ionContent, nothing will change. Note, this does not disable the system bounce on iOS. That is an OS level setting.
    /// </summary>
    public static void SetForceOverscroll(this Metapsi.Html.AttributesBuilder<IonContent> b, bool forceOverscroll) 
    {
        if (forceOverscroll) b.SetAttribute("forceOverscroll", "");
    }

    /// <summary>
    /// If `true` and the content does not cause an overflow scroll, the scroll interaction will cause a bounce. If the content exceeds the bounds of ionContent, nothing will change. Note, this does not disable the system bounce on iOS. That is an OS level setting.
    /// </summary>
    public static void SetForceOverscroll(this Metapsi.Html.AttributesBuilder<IonContent> b) 
    {
        b.SetAttribute("forceOverscroll", "");
    }

    /// <summary>
    /// If `true`, the content will scroll behind the headers and footers. This effect can easily be seen by setting the toolbar to transparent.
    /// </summary>
    public static void SetFullscreen(this Metapsi.Html.AttributesBuilder<IonContent> b, bool fullscreen) 
    {
        if (fullscreen) b.SetAttribute("fullscreen", "");
    }

    /// <summary>
    /// If `true`, the content will scroll behind the headers and footers. This effect can easily be seen by setting the toolbar to transparent.
    /// </summary>
    public static void SetFullscreen(this Metapsi.Html.AttributesBuilder<IonContent> b) 
    {
        b.SetAttribute("fullscreen", "");
    }

    /// <summary>
    /// Because of performance reasons, ionScroll events are disabled by default, in order to enable them and start listening from (ionScroll), set this property to `true`.
    /// </summary>
    public static void SetScrollEvents(this Metapsi.Html.AttributesBuilder<IonContent> b, bool scrollEvents) 
    {
        if (scrollEvents) b.SetAttribute("scrollEvents", "");
    }

    /// <summary>
    /// Because of performance reasons, ionScroll events are disabled by default, in order to enable them and start listening from (ionScroll), set this property to `true`.
    /// </summary>
    public static void SetScrollEvents(this Metapsi.Html.AttributesBuilder<IonContent> b) 
    {
        b.SetAttribute("scrollEvents", "");
    }

    /// <summary>
    /// If you want to enable the content scrolling in the X axis, set this property to `true`.
    /// </summary>
    public static void SetScrollX(this Metapsi.Html.AttributesBuilder<IonContent> b, bool scrollX) 
    {
        if (scrollX) b.SetAttribute("scrollX", "");
    }

    /// <summary>
    /// If you want to enable the content scrolling in the X axis, set this property to `true`.
    /// </summary>
    public static void SetScrollX(this Metapsi.Html.AttributesBuilder<IonContent> b) 
    {
        b.SetAttribute("scrollX", "");
    }

    /// <summary>
    /// If you want to disable the content scrolling in the Y axis, set this property to `false`.
    /// </summary>
    public static void SetScrollY(this Metapsi.Html.AttributesBuilder<IonContent> b, bool scrollY) 
    {
        if (scrollY) b.SetAttribute("scrollY", "");
    }

    /// <summary>
    /// If you want to disable the content scrolling in the Y axis, set this property to `false`.
    /// </summary>
    public static void SetScrollY(this Metapsi.Html.AttributesBuilder<IonContent> b) 
    {
        b.SetAttribute("scrollY", "");
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonContent(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonContent>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.IonicNode("ion-content", buildProps, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonContent(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.IonicNode("ion-content", children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonContent(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonContent>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.IonicNode("ion-content", buildProps, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonContent(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.IonicNode("ion-content", children);
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDanger<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonContent
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("danger"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDark<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonContent
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("dark"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorLight<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonContent
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("light"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorMedium<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonContent
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("medium"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorPrimary<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonContent
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("primary"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSecondary<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonContent
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("secondary"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSuccess<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonContent
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("success"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorTertiary<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonContent
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("tertiary"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorWarning<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonContent
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("warning"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> color) where T: IonContent
    {
        b.SetProperty(b.Props, b.Const("color"), color);
    }

    /// <summary>
    /// Controls where the fixed content is placed relative to the main content in the DOM. This can be used to control the order in which fixed elements receive keyboard focus. For example, if a FAB in the fixed slot should receive keyboard focus before the main page content, set this property to `'before'`.
    /// </summary>
    public static void SetFixedSlotPlacementAfter<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonContent
    {
        b.SetProperty(b.Props, b.Const("fixedSlotPlacement"), b.Const("after"));
    }

    /// <summary>
    /// Controls where the fixed content is placed relative to the main content in the DOM. This can be used to control the order in which fixed elements receive keyboard focus. For example, if a FAB in the fixed slot should receive keyboard focus before the main page content, set this property to `'before'`.
    /// </summary>
    public static void SetFixedSlotPlacementBefore<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonContent
    {
        b.SetProperty(b.Props, b.Const("fixedSlotPlacement"), b.Const("before"));
    }

    /// <summary>
    /// If `true` and the content does not cause an overflow scroll, the scroll interaction will cause a bounce. If the content exceeds the bounds of ionContent, nothing will change. Note, this does not disable the system bounce on iOS. That is an OS level setting.
    /// </summary>
    public static void SetForceOverscroll<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonContent
    {
        b.SetForceOverscroll(b.Const(true));
    }

    /// <summary>
    /// If `true` and the content does not cause an overflow scroll, the scroll interaction will cause a bounce. If the content exceeds the bounds of ionContent, nothing will change. Note, this does not disable the system bounce on iOS. That is an OS level setting.
    /// </summary>
    public static void SetForceOverscroll<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> forceOverscroll) where T: IonContent
    {
        b.SetProperty(b.Props, b.Const("forceOverscroll"), forceOverscroll);
    }

    /// <summary>
    /// If `true` and the content does not cause an overflow scroll, the scroll interaction will cause a bounce. If the content exceeds the bounds of ionContent, nothing will change. Note, this does not disable the system bounce on iOS. That is an OS level setting.
    /// </summary>
    public static void SetForceOverscroll<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool forceOverscroll) where T: IonContent
    {
        b.SetForceOverscroll(b.Const(forceOverscroll));
    }

    /// <summary>
    /// If `true`, the content will scroll behind the headers and footers. This effect can easily be seen by setting the toolbar to transparent.
    /// </summary>
    public static void SetFullscreen<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonContent
    {
        b.SetFullscreen(b.Const(true));
    }

    /// <summary>
    /// If `true`, the content will scroll behind the headers and footers. This effect can easily be seen by setting the toolbar to transparent.
    /// </summary>
    public static void SetFullscreen<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> fullscreen) where T: IonContent
    {
        b.SetProperty(b.Props, b.Const("fullscreen"), fullscreen);
    }

    /// <summary>
    /// If `true`, the content will scroll behind the headers and footers. This effect can easily be seen by setting the toolbar to transparent.
    /// </summary>
    public static void SetFullscreen<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool fullscreen) where T: IonContent
    {
        b.SetFullscreen(b.Const(fullscreen));
    }

    /// <summary>
    /// Because of performance reasons, ionScroll events are disabled by default, in order to enable them and start listening from (ionScroll), set this property to `true`.
    /// </summary>
    public static void SetScrollEvents<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonContent
    {
        b.SetScrollEvents(b.Const(true));
    }

    /// <summary>
    /// Because of performance reasons, ionScroll events are disabled by default, in order to enable them and start listening from (ionScroll), set this property to `true`.
    /// </summary>
    public static void SetScrollEvents<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> scrollEvents) where T: IonContent
    {
        b.SetProperty(b.Props, b.Const("scrollEvents"), scrollEvents);
    }

    /// <summary>
    /// Because of performance reasons, ionScroll events are disabled by default, in order to enable them and start listening from (ionScroll), set this property to `true`.
    /// </summary>
    public static void SetScrollEvents<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool scrollEvents) where T: IonContent
    {
        b.SetScrollEvents(b.Const(scrollEvents));
    }

    /// <summary>
    /// If you want to enable the content scrolling in the X axis, set this property to `true`.
    /// </summary>
    public static void SetScrollX<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonContent
    {
        b.SetScrollX(b.Const(true));
    }

    /// <summary>
    /// If you want to enable the content scrolling in the X axis, set this property to `true`.
    /// </summary>
    public static void SetScrollX<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> scrollX) where T: IonContent
    {
        b.SetProperty(b.Props, b.Const("scrollX"), scrollX);
    }

    /// <summary>
    /// If you want to enable the content scrolling in the X axis, set this property to `true`.
    /// </summary>
    public static void SetScrollX<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool scrollX) where T: IonContent
    {
        b.SetScrollX(b.Const(scrollX));
    }

    /// <summary>
    /// If you want to disable the content scrolling in the Y axis, set this property to `false`.
    /// </summary>
    public static void SetScrollY<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonContent
    {
        b.SetScrollY(b.Const(true));
    }

    /// <summary>
    /// If you want to disable the content scrolling in the Y axis, set this property to `false`.
    /// </summary>
    public static void SetScrollY<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> scrollY) where T: IonContent
    {
        b.SetProperty(b.Props, b.Const("scrollY"), scrollY);
    }

    /// <summary>
    /// If you want to disable the content scrolling in the Y axis, set this property to `false`.
    /// </summary>
    public static void SetScrollY<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool scrollY) where T: IonContent
    {
        b.SetScrollY(b.Const(scrollY));
    }

    /// <summary>
    /// Emitted while scrolling. This event is disabled by default. Set `scrollEvents` to `true` to enable.
    /// </summary>
    public static void OnIonScroll<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonContent
    {
        b.SetProperty(b.Props, "onionScroll", action);
    }

    /// <summary>
    /// Emitted while scrolling. This event is disabled by default. Set `scrollEvents` to `true` to enable.
    /// </summary>
    public static void OnIonScroll<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonContent
    {
        b.OnIonScroll(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted while scrolling. This event is disabled by default. Set `scrollEvents` to `true` to enable.
    /// </summary>
    public static void OnIonScroll<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonContent
    {
        b.SetProperty(b.Props, "onionScroll", action);
    }

    /// <summary>
    /// Emitted while scrolling. This event is disabled by default. Set `scrollEvents` to `true` to enable.
    /// </summary>
    public static void OnIonScroll<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonContent
    {
        b.OnIonScroll(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted while scrolling. This event is disabled by default. Set `scrollEvents` to `true` to enable.
    /// </summary>
    public static void OnIonScroll<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.CustomEvent<ScrollDetail>>> action) where T: IonContent
    {
        b.SetProperty(b.Props, "onionScroll", action);
    }

    /// <summary>
    /// Emitted when the scroll has ended. This event is disabled by default. Set `scrollEvents` to `true` to enable.
    /// </summary>
    public static void OnIonScrollEnd<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonContent
    {
        b.SetProperty(b.Props, "onionScrollEnd", action);
    }

    /// <summary>
    /// Emitted when the scroll has ended. This event is disabled by default. Set `scrollEvents` to `true` to enable.
    /// </summary>
    public static void OnIonScrollEnd<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonContent
    {
        b.OnIonScrollEnd(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the scroll has ended. This event is disabled by default. Set `scrollEvents` to `true` to enable.
    /// </summary>
    public static void OnIonScrollEnd<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonContent
    {
        b.SetProperty(b.Props, "onionScrollEnd", action);
    }

    /// <summary>
    /// Emitted when the scroll has ended. This event is disabled by default. Set `scrollEvents` to `true` to enable.
    /// </summary>
    public static void OnIonScrollEnd<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonContent
    {
        b.OnIonScrollEnd(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the scroll has ended. This event is disabled by default. Set `scrollEvents` to `true` to enable.
    /// </summary>
    public static void OnIonScrollEnd<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.CustomEvent<ScrollBaseDetail>>> action) where T: IonContent
    {
        b.SetProperty(b.Props, "onionScrollEnd", action);
    }

    /// <summary>
    /// Emitted when the scroll has started. This event is disabled by default. Set `scrollEvents` to `true` to enable.
    /// </summary>
    public static void OnIonScrollStart<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonContent
    {
        b.SetProperty(b.Props, "onionScrollStart", action);
    }

    /// <summary>
    /// Emitted when the scroll has started. This event is disabled by default. Set `scrollEvents` to `true` to enable.
    /// </summary>
    public static void OnIonScrollStart<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonContent
    {
        b.OnIonScrollStart(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the scroll has started. This event is disabled by default. Set `scrollEvents` to `true` to enable.
    /// </summary>
    public static void OnIonScrollStart<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonContent
    {
        b.SetProperty(b.Props, "onionScrollStart", action);
    }

    /// <summary>
    /// Emitted when the scroll has started. This event is disabled by default. Set `scrollEvents` to `true` to enable.
    /// </summary>
    public static void OnIonScrollStart<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonContent
    {
        b.OnIonScrollStart(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the scroll has started. This event is disabled by default. Set `scrollEvents` to `true` to enable.
    /// </summary>
    public static void OnIonScrollStart<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.CustomEvent<ScrollBaseDetail>>> action) where T: IonContent
    {
        b.SetProperty(b.Props, "onionScrollStart", action);
    }

}