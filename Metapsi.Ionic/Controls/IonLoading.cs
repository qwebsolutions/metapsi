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
        /// <para> Dismiss the loading overlay after it has been presented. </para>
        /// <para> (data?: any, role?: string) =&gt; Promise&lt;boolean&gt; </para>
        /// <para> data Any data to emit in the dismiss events. </para>
        /// <para> role The role of the element that is dismissing the loading. This can be useful in a button handler for determining which button was clicked to dismiss the loading. Some examples include: ``"cancel"`, `"destructive"`, "selected"`, and `"backdrop"`.  This is a no-op if the overlay has not been presented yet. If you want to remove an overlay from the DOM that was never presented, use the [remove](https://developer.mozilla.org/en-US/docs/Web/API/Element/remove) method. </para>
        /// </summary>
        public const string Dismiss = "dismiss";
        /// <summary>
        /// <para> Returns a promise that resolves when the loading did dismiss. </para>
        /// <para> &lt;T = any&gt;() =&gt; Promise&lt;OverlayEventDetail&lt;T&gt;&gt; </para>
        /// </summary>
        public const string OnDidDismiss = "onDidDismiss";
        /// <summary>
        /// <para> Returns a promise that resolves when the loading will dismiss. </para>
        /// <para> &lt;T = any&gt;() =&gt; Promise&lt;OverlayEventDetail&lt;T&gt;&gt; </para>
        /// </summary>
        public const string OnWillDismiss = "onWillDismiss";
        /// <summary>
        /// <para> Present the loading overlay after it has been created. </para>
        /// <para> () =&gt; Promise&lt;void&gt; </para>
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
    /// <para> If `true`, the loading indicator will animate. </para>
    /// </summary>
    public static void SetAnimated(this AttributesBuilder<IonLoading> b)
    {
        b.SetAttribute("animated", "");
    }

    /// <summary>
    /// <para> If `true`, the loading indicator will animate. </para>
    /// </summary>
    public static void SetAnimated(this AttributesBuilder<IonLoading> b,bool animated)
    {
        if (animated) b.SetAttribute("animated", "");
    }

    /// <summary>
    /// <para> If `true`, the loading indicator will be dismissed when the backdrop is clicked. </para>
    /// </summary>
    public static void SetBackdropDismiss(this AttributesBuilder<IonLoading> b)
    {
        b.SetAttribute("backdrop-dismiss", "");
    }

    /// <summary>
    /// <para> If `true`, the loading indicator will be dismissed when the backdrop is clicked. </para>
    /// </summary>
    public static void SetBackdropDismiss(this AttributesBuilder<IonLoading> b,bool backdropDismiss)
    {
        if (backdropDismiss) b.SetAttribute("backdrop-dismiss", "");
    }

    /// <summary>
    /// <para> Additional classes to apply for custom CSS. If multiple classes are provided they should be separated by spaces. </para>
    /// </summary>
    public static void SetCssClass(this AttributesBuilder<IonLoading> b,string cssClass)
    {
        b.SetAttribute("css-class", cssClass);
    }

    /// <summary>
    /// <para> Number of milliseconds to wait before dismissing the loading indicator. </para>
    /// </summary>
    public static void SetDuration(this AttributesBuilder<IonLoading> b,string duration)
    {
        b.SetAttribute("duration", duration);
    }

    /// <summary>
    /// <para> If `true`, the loading indicator will open. If `false`, the loading indicator will close. Use this if you need finer grained control over presentation, otherwise just use the loadingController or the `trigger` property. Note: `isOpen` will not automatically be set back to `false` when the loading indicator dismisses. You will need to do that in your code. </para>
    /// </summary>
    public static void SetIsOpen(this AttributesBuilder<IonLoading> b)
    {
        b.SetAttribute("is-open", "");
    }

    /// <summary>
    /// <para> If `true`, the loading indicator will open. If `false`, the loading indicator will close. Use this if you need finer grained control over presentation, otherwise just use the loadingController or the `trigger` property. Note: `isOpen` will not automatically be set back to `false` when the loading indicator dismisses. You will need to do that in your code. </para>
    /// </summary>
    public static void SetIsOpen(this AttributesBuilder<IonLoading> b,bool isOpen)
    {
        if (isOpen) b.SetAttribute("is-open", "");
    }

    /// <summary>
    /// <para> If `true`, the keyboard will be automatically dismissed when the overlay is presented. </para>
    /// </summary>
    public static void SetKeyboardClose(this AttributesBuilder<IonLoading> b)
    {
        b.SetAttribute("keyboard-close", "");
    }

    /// <summary>
    /// <para> If `true`, the keyboard will be automatically dismissed when the overlay is presented. </para>
    /// </summary>
    public static void SetKeyboardClose(this AttributesBuilder<IonLoading> b,bool keyboardClose)
    {
        if (keyboardClose) b.SetAttribute("keyboard-close", "");
    }

    /// <summary>
    /// <para> Optional text content to display in the loading indicator.  This property accepts custom HTML as a string. Content is parsed as plaintext by default. `innerHTMLTemplatesEnabled` must be set to `true` in the Ionic config before custom HTML can be used. </para>
    /// </summary>
    public static void SetMessage(this AttributesBuilder<IonLoading> b,string message)
    {
        b.SetAttribute("message", message);
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetMode(this AttributesBuilder<IonLoading> b,string mode)
    {
        b.SetAttribute("mode", mode);
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeIos(this AttributesBuilder<IonLoading> b)
    {
        b.SetAttribute("mode", "ios");
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeMd(this AttributesBuilder<IonLoading> b)
    {
        b.SetAttribute("mode", "md");
    }

    /// <summary>
    /// <para> If `true`, a backdrop will be displayed behind the loading indicator. </para>
    /// </summary>
    public static void SetShowBackdrop(this AttributesBuilder<IonLoading> b)
    {
        b.SetAttribute("show-backdrop", "");
    }

    /// <summary>
    /// <para> If `true`, a backdrop will be displayed behind the loading indicator. </para>
    /// </summary>
    public static void SetShowBackdrop(this AttributesBuilder<IonLoading> b,bool showBackdrop)
    {
        if (showBackdrop) b.SetAttribute("show-backdrop", "");
    }

    /// <summary>
    /// <para> The name of the spinner to display. </para>
    /// </summary>
    public static void SetSpinner(this AttributesBuilder<IonLoading> b,string spinner)
    {
        b.SetAttribute("spinner", spinner);
    }

    /// <summary>
    /// <para> The name of the spinner to display. </para>
    /// </summary>
    public static void SetSpinnerBubbles(this AttributesBuilder<IonLoading> b)
    {
        b.SetAttribute("spinner", "bubbles");
    }

    /// <summary>
    /// <para> The name of the spinner to display. </para>
    /// </summary>
    public static void SetSpinnerCircles(this AttributesBuilder<IonLoading> b)
    {
        b.SetAttribute("spinner", "circles");
    }

    /// <summary>
    /// <para> The name of the spinner to display. </para>
    /// </summary>
    public static void SetSpinnerCircular(this AttributesBuilder<IonLoading> b)
    {
        b.SetAttribute("spinner", "circular");
    }

    /// <summary>
    /// <para> The name of the spinner to display. </para>
    /// </summary>
    public static void SetSpinnerCrescent(this AttributesBuilder<IonLoading> b)
    {
        b.SetAttribute("spinner", "crescent");
    }

    /// <summary>
    /// <para> The name of the spinner to display. </para>
    /// </summary>
    public static void SetSpinnerDots(this AttributesBuilder<IonLoading> b)
    {
        b.SetAttribute("spinner", "dots");
    }

    /// <summary>
    /// <para> The name of the spinner to display. </para>
    /// </summary>
    public static void SetSpinnerLines(this AttributesBuilder<IonLoading> b)
    {
        b.SetAttribute("spinner", "lines");
    }

    /// <summary>
    /// <para> The name of the spinner to display. </para>
    /// </summary>
    public static void SetSpinnerLinesSharp(this AttributesBuilder<IonLoading> b)
    {
        b.SetAttribute("spinner", "lines-sharp");
    }

    /// <summary>
    /// <para> The name of the spinner to display. </para>
    /// </summary>
    public static void SetSpinnerLinesSharpSmall(this AttributesBuilder<IonLoading> b)
    {
        b.SetAttribute("spinner", "lines-sharp-small");
    }

    /// <summary>
    /// <para> The name of the spinner to display. </para>
    /// </summary>
    public static void SetSpinnerLinesSmall(this AttributesBuilder<IonLoading> b)
    {
        b.SetAttribute("spinner", "lines-small");
    }

    /// <summary>
    /// <para> If `true`, the loading indicator will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility). </para>
    /// </summary>
    public static void SetTranslucent(this AttributesBuilder<IonLoading> b)
    {
        b.SetAttribute("translucent", "");
    }

    /// <summary>
    /// <para> If `true`, the loading indicator will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility). </para>
    /// </summary>
    public static void SetTranslucent(this AttributesBuilder<IonLoading> b,bool translucent)
    {
        if (translucent) b.SetAttribute("translucent", "");
    }

    /// <summary>
    /// <para> An ID corresponding to the trigger element that causes the loading indicator to open when clicked. </para>
    /// </summary>
    public static void SetTrigger(this AttributesBuilder<IonLoading> b,string trigger)
    {
        b.SetAttribute("trigger", trigger);
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
    /// <para> If `true`, the loading indicator will animate. </para>
    /// </summary>
    public static void SetAnimated<T>(this PropsBuilder<T> b) where T: IonLoading
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("animated"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, the loading indicator will animate. </para>
    /// </summary>
    public static void SetAnimated<T>(this PropsBuilder<T> b, Var<bool> animated) where T: IonLoading
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("animated"), animated);
    }

    /// <summary>
    /// <para> If `true`, the loading indicator will animate. </para>
    /// </summary>
    public static void SetAnimated<T>(this PropsBuilder<T> b, bool animated) where T: IonLoading
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("animated"), b.Const(animated));
    }


    /// <summary>
    /// <para> If `true`, the loading indicator will be dismissed when the backdrop is clicked. </para>
    /// </summary>
    public static void SetBackdropDismiss<T>(this PropsBuilder<T> b) where T: IonLoading
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("backdropDismiss"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, the loading indicator will be dismissed when the backdrop is clicked. </para>
    /// </summary>
    public static void SetBackdropDismiss<T>(this PropsBuilder<T> b, Var<bool> backdropDismiss) where T: IonLoading
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("backdropDismiss"), backdropDismiss);
    }

    /// <summary>
    /// <para> If `true`, the loading indicator will be dismissed when the backdrop is clicked. </para>
    /// </summary>
    public static void SetBackdropDismiss<T>(this PropsBuilder<T> b, bool backdropDismiss) where T: IonLoading
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("backdropDismiss"), b.Const(backdropDismiss));
    }


    /// <summary>
    /// <para> Additional classes to apply for custom CSS. If multiple classes are provided they should be separated by spaces. </para>
    /// </summary>
    public static void SetCssClass<T>(this PropsBuilder<T> b, Var<string> cssClass) where T: IonLoading
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("cssClass"), cssClass);
    }

    /// <summary>
    /// <para> Additional classes to apply for custom CSS. If multiple classes are provided they should be separated by spaces. </para>
    /// </summary>
    public static void SetCssClass<T>(this PropsBuilder<T> b, string cssClass) where T: IonLoading
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("cssClass"), b.Const(cssClass));
    }


    /// <summary>
    /// <para> Additional classes to apply for custom CSS. If multiple classes are provided they should be separated by spaces. </para>
    /// </summary>
    public static void SetCssClass<T>(this PropsBuilder<T> b, Var<List<string>> cssClass) where T: IonLoading
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<string>>("cssClass"), cssClass);
    }

    /// <summary>
    /// <para> Additional classes to apply for custom CSS. If multiple classes are provided they should be separated by spaces. </para>
    /// </summary>
    public static void SetCssClass<T>(this PropsBuilder<T> b, List<string> cssClass) where T: IonLoading
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<string>>("cssClass"), b.Const(cssClass));
    }


    /// <summary>
    /// <para> Number of milliseconds to wait before dismissing the loading indicator. </para>
    /// </summary>
    public static void SetDuration<T>(this PropsBuilder<T> b, Var<int> duration) where T: IonLoading
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("duration"), duration);
    }

    /// <summary>
    /// <para> Number of milliseconds to wait before dismissing the loading indicator. </para>
    /// </summary>
    public static void SetDuration<T>(this PropsBuilder<T> b, int duration) where T: IonLoading
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("duration"), b.Const(duration));
    }


    /// <summary>
    /// <para> Animation to use when the loading indicator is presented. </para>
    /// </summary>
    public static void SetEnterAnimation<T>(this PropsBuilder<T> b, Var<System.Func<object,object,Animation>> enterAnimation) where T: IonLoading
    {
        b.SetDynamic(b.Props, new DynamicProperty<System.Func<object,object,Animation>>("enterAnimation"), enterAnimation);
    }

    /// <summary>
    /// <para> Animation to use when the loading indicator is presented. </para>
    /// </summary>
    public static void SetEnterAnimation<T>(this PropsBuilder<T> b, System.Func<object,object,Animation> enterAnimation) where T: IonLoading
    {
        b.SetDynamic(b.Props, new DynamicProperty<System.Func<object,object,Animation>>("enterAnimation"), b.Const(enterAnimation));
    }


    /// <summary>
    /// <para> Additional attributes to pass to the loader. </para>
    /// </summary>
    public static void SetHtmlAttributes<T>(this PropsBuilder<T> b, Var<DynamicObject> htmlAttributes) where T: IonLoading
    {
        b.SetDynamic(b.Props, new DynamicProperty<DynamicObject>("htmlAttributes"), htmlAttributes);
    }

    /// <summary>
    /// <para> Additional attributes to pass to the loader. </para>
    /// </summary>
    public static void SetHtmlAttributes<T>(this PropsBuilder<T> b, DynamicObject htmlAttributes) where T: IonLoading
    {
        b.SetDynamic(b.Props, new DynamicProperty<DynamicObject>("htmlAttributes"), b.Const(htmlAttributes));
    }


    /// <summary>
    /// <para> If `true`, the loading indicator will open. If `false`, the loading indicator will close. Use this if you need finer grained control over presentation, otherwise just use the loadingController or the `trigger` property. Note: `isOpen` will not automatically be set back to `false` when the loading indicator dismisses. You will need to do that in your code. </para>
    /// </summary>
    public static void SetIsOpen<T>(this PropsBuilder<T> b) where T: IonLoading
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("isOpen"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, the loading indicator will open. If `false`, the loading indicator will close. Use this if you need finer grained control over presentation, otherwise just use the loadingController or the `trigger` property. Note: `isOpen` will not automatically be set back to `false` when the loading indicator dismisses. You will need to do that in your code. </para>
    /// </summary>
    public static void SetIsOpen<T>(this PropsBuilder<T> b, Var<bool> isOpen) where T: IonLoading
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("isOpen"), isOpen);
    }

    /// <summary>
    /// <para> If `true`, the loading indicator will open. If `false`, the loading indicator will close. Use this if you need finer grained control over presentation, otherwise just use the loadingController or the `trigger` property. Note: `isOpen` will not automatically be set back to `false` when the loading indicator dismisses. You will need to do that in your code. </para>
    /// </summary>
    public static void SetIsOpen<T>(this PropsBuilder<T> b, bool isOpen) where T: IonLoading
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("isOpen"), b.Const(isOpen));
    }


    /// <summary>
    /// <para> If `true`, the keyboard will be automatically dismissed when the overlay is presented. </para>
    /// </summary>
    public static void SetKeyboardClose<T>(this PropsBuilder<T> b) where T: IonLoading
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("keyboardClose"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, the keyboard will be automatically dismissed when the overlay is presented. </para>
    /// </summary>
    public static void SetKeyboardClose<T>(this PropsBuilder<T> b, Var<bool> keyboardClose) where T: IonLoading
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("keyboardClose"), keyboardClose);
    }

    /// <summary>
    /// <para> If `true`, the keyboard will be automatically dismissed when the overlay is presented. </para>
    /// </summary>
    public static void SetKeyboardClose<T>(this PropsBuilder<T> b, bool keyboardClose) where T: IonLoading
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("keyboardClose"), b.Const(keyboardClose));
    }


    /// <summary>
    /// <para> Animation to use when the loading indicator is dismissed. </para>
    /// </summary>
    public static void SetLeaveAnimation<T>(this PropsBuilder<T> b, Var<System.Func<object,object,Animation>> leaveAnimation) where T: IonLoading
    {
        b.SetDynamic(b.Props, new DynamicProperty<System.Func<object,object,Animation>>("leaveAnimation"), leaveAnimation);
    }

    /// <summary>
    /// <para> Animation to use when the loading indicator is dismissed. </para>
    /// </summary>
    public static void SetLeaveAnimation<T>(this PropsBuilder<T> b, System.Func<object,object,Animation> leaveAnimation) where T: IonLoading
    {
        b.SetDynamic(b.Props, new DynamicProperty<System.Func<object,object,Animation>>("leaveAnimation"), b.Const(leaveAnimation));
    }


    /// <summary>
    /// <para> Optional text content to display in the loading indicator.  This property accepts custom HTML as a string. Content is parsed as plaintext by default. `innerHTMLTemplatesEnabled` must be set to `true` in the Ionic config before custom HTML can be used. </para>
    /// </summary>
    public static void SetMessage<T>(this PropsBuilder<T> b, Var<IonicSafeString> message) where T: IonLoading
    {
        b.SetDynamic(b.Props, new DynamicProperty<IonicSafeString>("message"), message);
    }



    /// <summary>
    /// <para> Optional text content to display in the loading indicator.  This property accepts custom HTML as a string. Content is parsed as plaintext by default. `innerHTMLTemplatesEnabled` must be set to `true` in the Ionic config before custom HTML can be used. </para>
    /// </summary>
    public static void SetMessage<T>(this PropsBuilder<T> b, Var<string> message) where T: IonLoading
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("message"), message);
    }

    /// <summary>
    /// <para> Optional text content to display in the loading indicator.  This property accepts custom HTML as a string. Content is parsed as plaintext by default. `innerHTMLTemplatesEnabled` must be set to `true` in the Ionic config before custom HTML can be used. </para>
    /// </summary>
    public static void SetMessage<T>(this PropsBuilder<T> b, string message) where T: IonLoading
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("message"), b.Const(message));
    }


    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeIos<T>(this PropsBuilder<T> b) where T: IonLoading
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("mode"), b.Const("ios"));
    }


    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeMd<T>(this PropsBuilder<T> b) where T: IonLoading
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("mode"), b.Const("md"));
    }


    /// <summary>
    /// <para> If `true`, a backdrop will be displayed behind the loading indicator. </para>
    /// </summary>
    public static void SetShowBackdrop<T>(this PropsBuilder<T> b) where T: IonLoading
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("showBackdrop"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, a backdrop will be displayed behind the loading indicator. </para>
    /// </summary>
    public static void SetShowBackdrop<T>(this PropsBuilder<T> b, Var<bool> showBackdrop) where T: IonLoading
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("showBackdrop"), showBackdrop);
    }

    /// <summary>
    /// <para> If `true`, a backdrop will be displayed behind the loading indicator. </para>
    /// </summary>
    public static void SetShowBackdrop<T>(this PropsBuilder<T> b, bool showBackdrop) where T: IonLoading
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("showBackdrop"), b.Const(showBackdrop));
    }


    /// <summary>
    /// <para> The name of the spinner to display. </para>
    /// </summary>
    public static void SetSpinnerBubbles<T>(this PropsBuilder<T> b) where T: IonLoading
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("spinner"), b.Const("bubbles"));
    }


    /// <summary>
    /// <para> The name of the spinner to display. </para>
    /// </summary>
    public static void SetSpinnerCircles<T>(this PropsBuilder<T> b) where T: IonLoading
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("spinner"), b.Const("circles"));
    }


    /// <summary>
    /// <para> The name of the spinner to display. </para>
    /// </summary>
    public static void SetSpinnerCircular<T>(this PropsBuilder<T> b) where T: IonLoading
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("spinner"), b.Const("circular"));
    }


    /// <summary>
    /// <para> The name of the spinner to display. </para>
    /// </summary>
    public static void SetSpinnerCrescent<T>(this PropsBuilder<T> b) where T: IonLoading
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("spinner"), b.Const("crescent"));
    }


    /// <summary>
    /// <para> The name of the spinner to display. </para>
    /// </summary>
    public static void SetSpinnerDots<T>(this PropsBuilder<T> b) where T: IonLoading
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("spinner"), b.Const("dots"));
    }


    /// <summary>
    /// <para> The name of the spinner to display. </para>
    /// </summary>
    public static void SetSpinnerLines<T>(this PropsBuilder<T> b) where T: IonLoading
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("spinner"), b.Const("lines"));
    }


    /// <summary>
    /// <para> The name of the spinner to display. </para>
    /// </summary>
    public static void SetSpinnerLinesSharp<T>(this PropsBuilder<T> b) where T: IonLoading
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("spinner"), b.Const("lines-sharp"));
    }


    /// <summary>
    /// <para> The name of the spinner to display. </para>
    /// </summary>
    public static void SetSpinnerLinesSharpSmall<T>(this PropsBuilder<T> b) where T: IonLoading
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("spinner"), b.Const("lines-sharp-small"));
    }


    /// <summary>
    /// <para> The name of the spinner to display. </para>
    /// </summary>
    public static void SetSpinnerLinesSmall<T>(this PropsBuilder<T> b) where T: IonLoading
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("spinner"), b.Const("lines-small"));
    }


    /// <summary>
    /// <para> If `true`, the loading indicator will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility). </para>
    /// </summary>
    public static void SetTranslucent<T>(this PropsBuilder<T> b) where T: IonLoading
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("translucent"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, the loading indicator will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility). </para>
    /// </summary>
    public static void SetTranslucent<T>(this PropsBuilder<T> b, Var<bool> translucent) where T: IonLoading
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("translucent"), translucent);
    }

    /// <summary>
    /// <para> If `true`, the loading indicator will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility). </para>
    /// </summary>
    public static void SetTranslucent<T>(this PropsBuilder<T> b, bool translucent) where T: IonLoading
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("translucent"), b.Const(translucent));
    }


    /// <summary>
    /// <para> An ID corresponding to the trigger element that causes the loading indicator to open when clicked. </para>
    /// </summary>
    public static void SetTrigger<T>(this PropsBuilder<T> b, Var<string> trigger) where T: IonLoading
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("trigger"), trigger);
    }

    /// <summary>
    /// <para> An ID corresponding to the trigger element that causes the loading indicator to open when clicked. </para>
    /// </summary>
    public static void SetTrigger<T>(this PropsBuilder<T> b, string trigger) where T: IonLoading
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("trigger"), b.Const(trigger));
    }


    /// <summary>
    /// <para> Emitted after the loading indicator has dismissed. Shorthand for ionLoadingDidDismiss. </para>
    /// </summary>
    public static void OnDidDismiss<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, OverlayEventDetail>> action) where TComponent: IonLoading
    {
        b.OnEventAction("ondidDismiss", action, "detail");
    }
    /// <summary>
    /// <para> Emitted after the loading indicator has dismissed. Shorthand for ionLoadingDidDismiss. </para>
    /// </summary>
    public static void OnDidDismiss<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<OverlayEventDetail>, Var<TModel>> action) where TComponent: IonLoading
    {
        b.OnEventAction("ondidDismiss", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// <para> Emitted after the loading indicator has presented. Shorthand for ionLoadingWillDismiss. </para>
    /// </summary>
    public static void OnDidPresent<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonLoading
    {
        b.OnEventAction("ondidPresent", action);
    }
    /// <summary>
    /// <para> Emitted after the loading indicator has presented. Shorthand for ionLoadingWillDismiss. </para>
    /// </summary>
    public static void OnDidPresent<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonLoading
    {
        b.OnEventAction("ondidPresent", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted after the loading has dismissed. </para>
    /// </summary>
    public static void OnIonLoadingDidDismiss<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, OverlayEventDetail>> action) where TComponent: IonLoading
    {
        b.OnEventAction("onionLoadingDidDismiss", action, "detail");
    }
    /// <summary>
    /// <para> Emitted after the loading has dismissed. </para>
    /// </summary>
    public static void OnIonLoadingDidDismiss<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<OverlayEventDetail>, Var<TModel>> action) where TComponent: IonLoading
    {
        b.OnEventAction("onionLoadingDidDismiss", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// <para> Emitted after the loading has presented. </para>
    /// </summary>
    public static void OnIonLoadingDidPresent<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonLoading
    {
        b.OnEventAction("onionLoadingDidPresent", action);
    }
    /// <summary>
    /// <para> Emitted after the loading has presented. </para>
    /// </summary>
    public static void OnIonLoadingDidPresent<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonLoading
    {
        b.OnEventAction("onionLoadingDidPresent", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted before the loading has dismissed. </para>
    /// </summary>
    public static void OnIonLoadingWillDismiss<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, OverlayEventDetail>> action) where TComponent: IonLoading
    {
        b.OnEventAction("onionLoadingWillDismiss", action, "detail");
    }
    /// <summary>
    /// <para> Emitted before the loading has dismissed. </para>
    /// </summary>
    public static void OnIonLoadingWillDismiss<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<OverlayEventDetail>, Var<TModel>> action) where TComponent: IonLoading
    {
        b.OnEventAction("onionLoadingWillDismiss", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// <para> Emitted before the loading has presented. </para>
    /// </summary>
    public static void OnIonLoadingWillPresent<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonLoading
    {
        b.OnEventAction("onionLoadingWillPresent", action);
    }
    /// <summary>
    /// <para> Emitted before the loading has presented. </para>
    /// </summary>
    public static void OnIonLoadingWillPresent<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonLoading
    {
        b.OnEventAction("onionLoadingWillPresent", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted before the loading indicator has dismissed. Shorthand for ionLoadingWillDismiss. </para>
    /// </summary>
    public static void OnWillDismiss<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, OverlayEventDetail>> action) where TComponent: IonLoading
    {
        b.OnEventAction("onwillDismiss", action, "detail");
    }
    /// <summary>
    /// <para> Emitted before the loading indicator has dismissed. Shorthand for ionLoadingWillDismiss. </para>
    /// </summary>
    public static void OnWillDismiss<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<OverlayEventDetail>, Var<TModel>> action) where TComponent: IonLoading
    {
        b.OnEventAction("onwillDismiss", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// <para> Emitted before the loading indicator has presented. Shorthand for ionLoadingWillPresent. </para>
    /// </summary>
    public static void OnWillPresent<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonLoading
    {
        b.OnEventAction("onwillPresent", action);
    }
    /// <summary>
    /// <para> Emitted before the loading indicator has presented. Shorthand for ionLoadingWillPresent. </para>
    /// </summary>
    public static void OnWillPresent<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonLoading
    {
        b.OnEventAction("onwillPresent", b.MakeAction(action));
    }

}

