using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Ionic;


public partial class IonLoading : IonComponent
{
    public IonLoading() : base("ion-loading") { }
    public static class Method
    {
        /// <summary> 
        /// Dismiss the loading overlay after it has been presented.
        /// <para>(data?: any, role?: string) =&gt; Promise&lt;boolean&gt;</para>
        /// <para>data Any data to emit in the dismiss events.</para>
        /// <para>role The role of the element that is dismissing the loading. This can be useful in a button handler for determining which button was clicked to dismiss the loading. Some examples include: ``"cancel"`, `"destructive"`, "selected"`, and `"backdrop"`.  This is a no-op if the overlay has not been presented yet. If you want to remove an overlay from the DOM that was never presented, use the [remove](https://developer.mozilla.org/en-US/docs/Web/API/Element/remove) method.</para>
        /// </summary>
        public const string Dismiss = "dismiss";
        /// <summary> 
        /// Returns a promise that resolves when the loading did dismiss.
        /// <para>&lt;T = any&gt;() =&gt; Promise&lt;OverlayEventDetail&lt;T&gt;&gt;</para>
        /// </summary>
        public const string OnDidDismiss = "onDidDismiss";
        /// <summary> 
        /// Returns a promise that resolves when the loading will dismiss.
        /// <para>&lt;T = any&gt;() =&gt; Promise&lt;OverlayEventDetail&lt;T&gt;&gt;</para>
        /// </summary>
        public const string OnWillDismiss = "onWillDismiss";
        /// <summary> 
        /// Present the loading overlay after it has been created.
        /// <para>() =&gt; Promise&lt;void&gt;</para>
        /// </summary>
        public const string Present = "present";
    }
}

public static partial class IonLoadingControl
{
    /// <summary>
    /// 
    /// </summary>
    public static IHtmlNode IonLoading(this HtmlBuilder b, Action<AttributesBuilder<IonLoading>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("ion-loading", buildAttributes, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static IHtmlNode IonLoading(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("ion-loading", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// If `true`, the loading indicator will animate.
    /// </summary>
    public static void SetAnimated(this AttributesBuilder<IonLoading> b)
    {
        b.SetAttribute("animated", "");
    }
    /// <summary>
    /// If `true`, the loading indicator will animate.
    /// </summary>
    public static void SetAnimated(this AttributesBuilder<IonLoading> b, bool value)
    {
        if (value) b.SetAttribute("animated", "");
    }

    /// <summary>
    /// If `true`, the loading indicator will be dismissed when the backdrop is clicked.
    /// </summary>
    public static void SetBackdropDismiss(this AttributesBuilder<IonLoading> b)
    {
        b.SetAttribute("backdrop-dismiss", "");
    }
    /// <summary>
    /// If `true`, the loading indicator will be dismissed when the backdrop is clicked.
    /// </summary>
    public static void SetBackdropDismiss(this AttributesBuilder<IonLoading> b, bool value)
    {
        if (value) b.SetAttribute("backdrop-dismiss", "");
    }

    /// <summary>
    /// Additional classes to apply for custom CSS. If multiple classes are provided they should be separated by spaces.
    /// </summary>
    public static void SetCssClass(this AttributesBuilder<IonLoading> b, string value)
    {
        b.SetAttribute("css-class", value);
    }

    /// <summary>
    /// Number of milliseconds to wait before dismissing the loading indicator.
    /// </summary>
    public static void SetDuration(this AttributesBuilder<IonLoading> b, string value)
    {
        b.SetAttribute("duration", value);
    }

    /// <summary>
    /// If `true`, the loading indicator will open. If `false`, the loading indicator will close. Use this if you need finer grained control over presentation, otherwise just use the loadingController or the `trigger` property. Note: `isOpen` will not automatically be set back to `false` when the loading indicator dismisses. You will need to do that in your code.
    /// </summary>
    public static void SetIsOpen(this AttributesBuilder<IonLoading> b)
    {
        b.SetAttribute("is-open", "");
    }
    /// <summary>
    /// If `true`, the loading indicator will open. If `false`, the loading indicator will close. Use this if you need finer grained control over presentation, otherwise just use the loadingController or the `trigger` property. Note: `isOpen` will not automatically be set back to `false` when the loading indicator dismisses. You will need to do that in your code.
    /// </summary>
    public static void SetIsOpen(this AttributesBuilder<IonLoading> b, bool value)
    {
        if (value) b.SetAttribute("is-open", "");
    }

    /// <summary>
    /// If `true`, the keyboard will be automatically dismissed when the overlay is presented.
    /// </summary>
    public static void SetKeyboardClose(this AttributesBuilder<IonLoading> b)
    {
        b.SetAttribute("keyboard-close", "");
    }
    /// <summary>
    /// If `true`, the keyboard will be automatically dismissed when the overlay is presented.
    /// </summary>
    public static void SetKeyboardClose(this AttributesBuilder<IonLoading> b, bool value)
    {
        if (value) b.SetAttribute("keyboard-close", "");
    }

    /// <summary>
    /// Optional text content to display in the loading indicator.  This property accepts custom HTML as a string. Content is parsed as plaintext by default. `innerHTMLTemplatesEnabled` must be set to `true` in the Ionic config before custom HTML can be used.
    /// </summary>
    public static void SetMessage(this AttributesBuilder<IonLoading> b, string value)
    {
        b.SetAttribute("message", value);
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetMode(this AttributesBuilder<IonLoading> b, string value)
    {
        b.SetAttribute("mode", value);
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos(this AttributesBuilder<IonLoading> b)
    {
        b.SetAttribute("mode", "ios");
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd(this AttributesBuilder<IonLoading> b)
    {
        b.SetAttribute("mode", "md");
    }

    /// <summary>
    /// If `true`, a backdrop will be displayed behind the loading indicator.
    /// </summary>
    public static void SetShowBackdrop(this AttributesBuilder<IonLoading> b)
    {
        b.SetAttribute("show-backdrop", "");
    }
    /// <summary>
    /// If `true`, a backdrop will be displayed behind the loading indicator.
    /// </summary>
    public static void SetShowBackdrop(this AttributesBuilder<IonLoading> b, bool value)
    {
        if (value) b.SetAttribute("show-backdrop", "");
    }

    /// <summary>
    /// The name of the spinner to display.
    /// </summary>
    public static void SetSpinner(this AttributesBuilder<IonLoading> b, string value)
    {
        b.SetAttribute("spinner", value);
    }
    /// <summary>
    /// The name of the spinner to display.
    /// </summary>
    public static void SetSpinnerBubbles(this AttributesBuilder<IonLoading> b)
    {
        b.SetAttribute("spinner", "bubbles");
    }
    /// <summary>
    /// The name of the spinner to display.
    /// </summary>
    public static void SetSpinnerCircles(this AttributesBuilder<IonLoading> b)
    {
        b.SetAttribute("spinner", "circles");
    }
    /// <summary>
    /// The name of the spinner to display.
    /// </summary>
    public static void SetSpinnerCircular(this AttributesBuilder<IonLoading> b)
    {
        b.SetAttribute("spinner", "circular");
    }
    /// <summary>
    /// The name of the spinner to display.
    /// </summary>
    public static void SetSpinnerCrescent(this AttributesBuilder<IonLoading> b)
    {
        b.SetAttribute("spinner", "crescent");
    }
    /// <summary>
    /// The name of the spinner to display.
    /// </summary>
    public static void SetSpinnerDots(this AttributesBuilder<IonLoading> b)
    {
        b.SetAttribute("spinner", "dots");
    }
    /// <summary>
    /// The name of the spinner to display.
    /// </summary>
    public static void SetSpinnerLines(this AttributesBuilder<IonLoading> b)
    {
        b.SetAttribute("spinner", "lines");
    }
    /// <summary>
    /// The name of the spinner to display.
    /// </summary>
    public static void SetSpinnerLinesSharp(this AttributesBuilder<IonLoading> b)
    {
        b.SetAttribute("spinner", "lines-sharp");
    }
    /// <summary>
    /// The name of the spinner to display.
    /// </summary>
    public static void SetSpinnerLinesSharpSmall(this AttributesBuilder<IonLoading> b)
    {
        b.SetAttribute("spinner", "lines-sharp-small");
    }
    /// <summary>
    /// The name of the spinner to display.
    /// </summary>
    public static void SetSpinnerLinesSmall(this AttributesBuilder<IonLoading> b)
    {
        b.SetAttribute("spinner", "lines-small");
    }

    /// <summary>
    /// If `true`, the loading indicator will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility).
    /// </summary>
    public static void SetTranslucent(this AttributesBuilder<IonLoading> b)
    {
        b.SetAttribute("translucent", "");
    }
    /// <summary>
    /// If `true`, the loading indicator will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility).
    /// </summary>
    public static void SetTranslucent(this AttributesBuilder<IonLoading> b, bool value)
    {
        if (value) b.SetAttribute("translucent", "");
    }

    /// <summary>
    /// An ID corresponding to the trigger element that causes the loading indicator to open when clicked.
    /// </summary>
    public static void SetTrigger(this AttributesBuilder<IonLoading> b, string value)
    {
        b.SetAttribute("trigger", value);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonLoading(this LayoutBuilder b, Action<PropsBuilder<IonLoading>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-loading", buildProps, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonLoading(this LayoutBuilder b, Action<PropsBuilder<IonLoading>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-loading", buildProps, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonLoading(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-loading", children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonLoading(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-loading", children);
    }
    /// <summary>
    /// If `true`, the loading indicator will animate.
    /// </summary>
    public static void SetAnimated<T>(this PropsBuilder<T> b) where T: IonLoading
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("animated"), b.Const(true));
    }

    /// <summary>
    /// If `true`, the loading indicator will be dismissed when the backdrop is clicked.
    /// </summary>
    public static void SetBackdropDismiss<T>(this PropsBuilder<T> b) where T: IonLoading
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("backdropDismiss"), b.Const(true));
    }

    /// <summary>
    /// Additional classes to apply for custom CSS. If multiple classes are provided they should be separated by spaces.
    /// </summary>
    public static void SetCssClass<T>(this PropsBuilder<T> b, Var<string> value) where T: IonLoading
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("cssClass"), value);
    }
    /// <summary>
    /// Additional classes to apply for custom CSS. If multiple classes are provided they should be separated by spaces.
    /// </summary>
    public static void SetCssClass<T>(this PropsBuilder<T> b, string value) where T: IonLoading
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("cssClass"), b.Const(value));
    }
    /// <summary>
    /// Additional classes to apply for custom CSS. If multiple classes are provided they should be separated by spaces.
    /// </summary>
    public static void SetCssClass<T>(this PropsBuilder<T> b, Var<List<string>> value) where T: IonLoading
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<string>>("cssClass"), value);
    }
    /// <summary>
    /// Additional classes to apply for custom CSS. If multiple classes are provided they should be separated by spaces.
    /// </summary>
    public static void SetCssClass<T>(this PropsBuilder<T> b, List<string> value) where T: IonLoading
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<string>>("cssClass"), b.Const(value));
    }

    /// <summary>
    /// Number of milliseconds to wait before dismissing the loading indicator.
    /// </summary>
    public static void SetDuration<T>(this PropsBuilder<T> b, Var<int> value) where T: IonLoading
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("duration"), value);
    }
    /// <summary>
    /// Number of milliseconds to wait before dismissing the loading indicator.
    /// </summary>
    public static void SetDuration<T>(this PropsBuilder<T> b, int value) where T: IonLoading
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("duration"), b.Const(value));
    }

    /// <summary>
    /// Animation to use when the loading indicator is presented.
    /// </summary>
    public static void SetEnterAnimation<T>(this PropsBuilder<T> b, Var<Func<object,object,Animation>> f) where T: IonLoading
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<object,object,Animation>>("enterAnimation"), f);
    }
    /// <summary>
    /// Animation to use when the loading indicator is presented.
    /// </summary>
    public static void SetEnterAnimation<T>(this PropsBuilder<T> b, Func<SyntaxBuilder,Var<object>,Var<object>,Var<Animation>> f) where T: IonLoading
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<object,object,Animation>>("enterAnimation"), b.Def(f));
    }

    /// <summary>
    /// Additional attributes to pass to the loader.
    /// </summary>
    public static void SetHtmlAttributes<T>(this PropsBuilder<T> b, Var<DynamicObject> value) where T: IonLoading
    {
        b.SetDynamic(b.Props, new DynamicProperty<DynamicObject>("htmlAttributes"), value);
    }
    /// <summary>
    /// Additional attributes to pass to the loader.
    /// </summary>
    public static void SetHtmlAttributes<T>(this PropsBuilder<T> b, DynamicObject value) where T: IonLoading
    {
        b.SetDynamic(b.Props, new DynamicProperty<DynamicObject>("htmlAttributes"), b.Const(value));
    }

    /// <summary>
    /// If `true`, the loading indicator will open. If `false`, the loading indicator will close. Use this if you need finer grained control over presentation, otherwise just use the loadingController or the `trigger` property. Note: `isOpen` will not automatically be set back to `false` when the loading indicator dismisses. You will need to do that in your code.
    /// </summary>
    public static void SetIsOpen<T>(this PropsBuilder<T> b) where T: IonLoading
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("isOpen"), b.Const(true));
    }

    /// <summary>
    /// If `true`, the keyboard will be automatically dismissed when the overlay is presented.
    /// </summary>
    public static void SetKeyboardClose<T>(this PropsBuilder<T> b) where T: IonLoading
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("keyboardClose"), b.Const(true));
    }

    /// <summary>
    /// Animation to use when the loading indicator is dismissed.
    /// </summary>
    public static void SetLeaveAnimation<T>(this PropsBuilder<T> b, Var<Func<object,object,Animation>> f) where T: IonLoading
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<object,object,Animation>>("leaveAnimation"), f);
    }
    /// <summary>
    /// Animation to use when the loading indicator is dismissed.
    /// </summary>
    public static void SetLeaveAnimation<T>(this PropsBuilder<T> b, Func<SyntaxBuilder,Var<object>,Var<object>,Var<Animation>> f) where T: IonLoading
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<object,object,Animation>>("leaveAnimation"), b.Def(f));
    }

    /// <summary>
    /// Optional text content to display in the loading indicator.  This property accepts custom HTML as a string. Content is parsed as plaintext by default. `innerHTMLTemplatesEnabled` must be set to `true` in the Ionic config before custom HTML can be used.
    /// </summary>
    public static void SetMessage<T>(this PropsBuilder<T> b, Var<string> value) where T: IonLoading
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("message"), value);
    }
    /// <summary>
    /// Optional text content to display in the loading indicator.  This property accepts custom HTML as a string. Content is parsed as plaintext by default. `innerHTMLTemplatesEnabled` must be set to `true` in the Ionic config before custom HTML can be used.
    /// </summary>
    public static void SetMessage<T>(this PropsBuilder<T> b, string value) where T: IonLoading
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("message"), b.Const(value));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos<T>(this PropsBuilder<T> b) where T: IonLoading
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("ios"));
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd<T>(this PropsBuilder<T> b) where T: IonLoading
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("md"));
    }

    /// <summary>
    /// If `true`, a backdrop will be displayed behind the loading indicator.
    /// </summary>
    public static void SetShowBackdrop<T>(this PropsBuilder<T> b) where T: IonLoading
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("showBackdrop"), b.Const(true));
    }

    /// <summary>
    /// The name of the spinner to display.
    /// </summary>
    public static void SetSpinnerBubbles<T>(this PropsBuilder<T> b) where T: IonLoading
    {
        b.SetDynamic(b.Props, DynamicProperty.String("spinner"), b.Const("bubbles"));
    }
    /// <summary>
    /// The name of the spinner to display.
    /// </summary>
    public static void SetSpinnerCircles<T>(this PropsBuilder<T> b) where T: IonLoading
    {
        b.SetDynamic(b.Props, DynamicProperty.String("spinner"), b.Const("circles"));
    }
    /// <summary>
    /// The name of the spinner to display.
    /// </summary>
    public static void SetSpinnerCircular<T>(this PropsBuilder<T> b) where T: IonLoading
    {
        b.SetDynamic(b.Props, DynamicProperty.String("spinner"), b.Const("circular"));
    }
    /// <summary>
    /// The name of the spinner to display.
    /// </summary>
    public static void SetSpinnerCrescent<T>(this PropsBuilder<T> b) where T: IonLoading
    {
        b.SetDynamic(b.Props, DynamicProperty.String("spinner"), b.Const("crescent"));
    }
    /// <summary>
    /// The name of the spinner to display.
    /// </summary>
    public static void SetSpinnerDots<T>(this PropsBuilder<T> b) where T: IonLoading
    {
        b.SetDynamic(b.Props, DynamicProperty.String("spinner"), b.Const("dots"));
    }
    /// <summary>
    /// The name of the spinner to display.
    /// </summary>
    public static void SetSpinnerLines<T>(this PropsBuilder<T> b) where T: IonLoading
    {
        b.SetDynamic(b.Props, DynamicProperty.String("spinner"), b.Const("lines"));
    }
    /// <summary>
    /// The name of the spinner to display.
    /// </summary>
    public static void SetSpinnerLinesSharp<T>(this PropsBuilder<T> b) where T: IonLoading
    {
        b.SetDynamic(b.Props, DynamicProperty.String("spinner"), b.Const("lines-sharp"));
    }
    /// <summary>
    /// The name of the spinner to display.
    /// </summary>
    public static void SetSpinnerLinesSharpSmall<T>(this PropsBuilder<T> b) where T: IonLoading
    {
        b.SetDynamic(b.Props, DynamicProperty.String("spinner"), b.Const("lines-sharp-small"));
    }
    /// <summary>
    /// The name of the spinner to display.
    /// </summary>
    public static void SetSpinnerLinesSmall<T>(this PropsBuilder<T> b) where T: IonLoading
    {
        b.SetDynamic(b.Props, DynamicProperty.String("spinner"), b.Const("lines-small"));
    }

    /// <summary>
    /// If `true`, the loading indicator will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility).
    /// </summary>
    public static void SetTranslucent<T>(this PropsBuilder<T> b) where T: IonLoading
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("translucent"), b.Const(true));
    }

    /// <summary>
    /// An ID corresponding to the trigger element that causes the loading indicator to open when clicked.
    /// </summary>
    public static void SetTrigger<T>(this PropsBuilder<T> b, Var<string> value) where T: IonLoading
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("trigger"), value);
    }
    /// <summary>
    /// An ID corresponding to the trigger element that causes the loading indicator to open when clicked.
    /// </summary>
    public static void SetTrigger<T>(this PropsBuilder<T> b, string value) where T: IonLoading
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("trigger"), b.Const(value));
    }

    /// <summary>
    /// Emitted after the loading indicator has dismissed. Shorthand for ionLoadingDidDismiss.
    /// </summary>
    public static void OnDidDismiss<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, OverlayEventDetail>> action) where TComponent: IonLoading
    {
        b.OnEventAction("ondidDismiss", action, "detail");
    }
    /// <summary>
    /// Emitted after the loading indicator has dismissed. Shorthand for ionLoadingDidDismiss.
    /// </summary>
    public static void OnDidDismiss<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<OverlayEventDetail>, Var<TModel>> action) where TComponent: IonLoading
    {
        b.OnEventAction("ondidDismiss", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// Emitted after the loading indicator has presented. Shorthand for ionLoadingWillDismiss.
    /// </summary>
    public static void OnDidPresent<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonLoading
    {
        b.OnEventAction("ondidPresent", action);
    }
    /// <summary>
    /// Emitted after the loading indicator has presented. Shorthand for ionLoadingWillDismiss.
    /// </summary>
    public static void OnDidPresent<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonLoading
    {
        b.OnEventAction("ondidPresent", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the loading has dismissed.
    /// </summary>
    public static void OnIonLoadingDidDismiss<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, OverlayEventDetail>> action) where TComponent: IonLoading
    {
        b.OnEventAction("onionLoadingDidDismiss", action, "detail");
    }
    /// <summary>
    /// Emitted after the loading has dismissed.
    /// </summary>
    public static void OnIonLoadingDidDismiss<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<OverlayEventDetail>, Var<TModel>> action) where TComponent: IonLoading
    {
        b.OnEventAction("onionLoadingDidDismiss", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// Emitted after the loading has presented.
    /// </summary>
    public static void OnIonLoadingDidPresent<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonLoading
    {
        b.OnEventAction("onionLoadingDidPresent", action);
    }
    /// <summary>
    /// Emitted after the loading has presented.
    /// </summary>
    public static void OnIonLoadingDidPresent<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonLoading
    {
        b.OnEventAction("onionLoadingDidPresent", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted before the loading has dismissed.
    /// </summary>
    public static void OnIonLoadingWillDismiss<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, OverlayEventDetail>> action) where TComponent: IonLoading
    {
        b.OnEventAction("onionLoadingWillDismiss", action, "detail");
    }
    /// <summary>
    /// Emitted before the loading has dismissed.
    /// </summary>
    public static void OnIonLoadingWillDismiss<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<OverlayEventDetail>, Var<TModel>> action) where TComponent: IonLoading
    {
        b.OnEventAction("onionLoadingWillDismiss", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// Emitted before the loading has presented.
    /// </summary>
    public static void OnIonLoadingWillPresent<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonLoading
    {
        b.OnEventAction("onionLoadingWillPresent", action);
    }
    /// <summary>
    /// Emitted before the loading has presented.
    /// </summary>
    public static void OnIonLoadingWillPresent<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonLoading
    {
        b.OnEventAction("onionLoadingWillPresent", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted before the loading indicator has dismissed. Shorthand for ionLoadingWillDismiss.
    /// </summary>
    public static void OnWillDismiss<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, OverlayEventDetail>> action) where TComponent: IonLoading
    {
        b.OnEventAction("onwillDismiss", action, "detail");
    }
    /// <summary>
    /// Emitted before the loading indicator has dismissed. Shorthand for ionLoadingWillDismiss.
    /// </summary>
    public static void OnWillDismiss<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<OverlayEventDetail>, Var<TModel>> action) where TComponent: IonLoading
    {
        b.OnEventAction("onwillDismiss", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// Emitted before the loading indicator has presented. Shorthand for ionLoadingWillPresent.
    /// </summary>
    public static void OnWillPresent<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonLoading
    {
        b.OnEventAction("onwillPresent", action);
    }
    /// <summary>
    /// Emitted before the loading indicator has presented. Shorthand for ionLoadingWillPresent.
    /// </summary>
    public static void OnWillPresent<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonLoading
    {
        b.OnEventAction("onwillPresent", b.MakeAction(action));
    }

}

