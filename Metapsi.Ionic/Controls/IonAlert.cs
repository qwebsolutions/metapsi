using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Ionic;


public partial class IonAlert : IonComponent
{
    public IonAlert() : base("ion-alert") { }
    public static class Method
    {
        /// <summary>
        /// <para> Dismiss the alert overlay after it has been presented. </para>
        /// <para> (data?: any, role?: string) =&gt; Promise&lt;boolean&gt; </para>
        /// <para> data Any data to emit in the dismiss events. </para>
        /// <para> role The role of the element that is dismissing the alert. This can be useful in a button handler for determining which button was clicked to dismiss the alert. Some examples include: ``"cancel"`, `"destructive"`, "selected"`, and `"backdrop"`.  This is a no-op if the overlay has not been presented yet. If you want to remove an overlay from the DOM that was never presented, use the [remove](https://developer.mozilla.org/en-US/docs/Web/API/Element/remove) method. </para>
        /// </summary>
        public const string Dismiss = "dismiss";
        /// <summary>
        /// <para> Returns a promise that resolves when the alert did dismiss. </para>
        /// <para> &lt;T = any&gt;() =&gt; Promise&lt;OverlayEventDetail&lt;T&gt;&gt; </para>
        /// </summary>
        public const string OnDidDismiss = "onDidDismiss";
        /// <summary>
        /// <para> Returns a promise that resolves when the alert will dismiss. </para>
        /// <para> &lt;T = any&gt;() =&gt; Promise&lt;OverlayEventDetail&lt;T&gt;&gt; </para>
        /// </summary>
        public const string OnWillDismiss = "onWillDismiss";
        /// <summary>
        /// <para> Present the alert overlay after it has been created. </para>
        /// <para> () =&gt; Promise&lt;void&gt; </para>
        /// </summary>
        public const string Present = "present";
    }
}

public static partial class IonAlertControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonAlert(this HtmlBuilder b, Action<AttributesBuilder<IonAlert>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("ion-alert", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonAlert(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("ion-alert", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> If `true`, the alert will animate. </para>
    /// </summary>
    public static void SetAnimated(this AttributesBuilder<IonAlert> b)
    {
        b.SetAttribute("animated", "");
    }

    /// <summary>
    /// <para> If `true`, the alert will animate. </para>
    /// </summary>
    public static void SetAnimated(this AttributesBuilder<IonAlert> b,bool animated)
    {
        if (animated) b.SetAttribute("animated", "");
    }

    /// <summary>
    /// <para> If `true`, the alert will be dismissed when the backdrop is clicked. </para>
    /// </summary>
    public static void SetBackdropDismiss(this AttributesBuilder<IonAlert> b)
    {
        b.SetAttribute("backdrop-dismiss", "");
    }

    /// <summary>
    /// <para> If `true`, the alert will be dismissed when the backdrop is clicked. </para>
    /// </summary>
    public static void SetBackdropDismiss(this AttributesBuilder<IonAlert> b,bool backdropDismiss)
    {
        if (backdropDismiss) b.SetAttribute("backdrop-dismiss", "");
    }

    /// <summary>
    /// <para> Additional classes to apply for custom CSS. If multiple classes are provided they should be separated by spaces. </para>
    /// </summary>
    public static void SetCssClass(this AttributesBuilder<IonAlert> b,string cssClass)
    {
        b.SetAttribute("css-class", cssClass);
    }

    /// <summary>
    /// <para> The main title in the heading of the alert. </para>
    /// </summary>
    public static void SetHeader(this AttributesBuilder<IonAlert> b,string header)
    {
        b.SetAttribute("header", header);
    }

    /// <summary>
    /// <para> If `true`, the alert will open. If `false`, the alert will close. Use this if you need finer grained control over presentation, otherwise just use the alertController or the `trigger` property. Note: `isOpen` will not automatically be set back to `false` when the alert dismisses. You will need to do that in your code. </para>
    /// </summary>
    public static void SetIsOpen(this AttributesBuilder<IonAlert> b)
    {
        b.SetAttribute("is-open", "");
    }

    /// <summary>
    /// <para> If `true`, the alert will open. If `false`, the alert will close. Use this if you need finer grained control over presentation, otherwise just use the alertController or the `trigger` property. Note: `isOpen` will not automatically be set back to `false` when the alert dismisses. You will need to do that in your code. </para>
    /// </summary>
    public static void SetIsOpen(this AttributesBuilder<IonAlert> b,bool isOpen)
    {
        if (isOpen) b.SetAttribute("is-open", "");
    }

    /// <summary>
    /// <para> If `true`, the keyboard will be automatically dismissed when the overlay is presented. </para>
    /// </summary>
    public static void SetKeyboardClose(this AttributesBuilder<IonAlert> b)
    {
        b.SetAttribute("keyboard-close", "");
    }

    /// <summary>
    /// <para> If `true`, the keyboard will be automatically dismissed when the overlay is presented. </para>
    /// </summary>
    public static void SetKeyboardClose(this AttributesBuilder<IonAlert> b,bool keyboardClose)
    {
        if (keyboardClose) b.SetAttribute("keyboard-close", "");
    }

    /// <summary>
    /// <para> The main message to be displayed in the alert. `message` can accept either plaintext or HTML as a string. To display characters normally reserved for HTML, they must be escaped. For example `<Ionic>` would become `&lt;Ionic&gt;`  For more information: [Security Documentation](https://ionicframework.com/docs/faq/security)  This property accepts custom HTML as a string. Content is parsed as plaintext by default. `innerHTMLTemplatesEnabled` must be set to `true` in the Ionic config before custom HTML can be used. </para>
    /// </summary>
    public static void SetMessage(this AttributesBuilder<IonAlert> b,string message)
    {
        b.SetAttribute("message", message);
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetMode(this AttributesBuilder<IonAlert> b,string mode)
    {
        b.SetAttribute("mode", mode);
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeIos(this AttributesBuilder<IonAlert> b)
    {
        b.SetAttribute("mode", "ios");
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeMd(this AttributesBuilder<IonAlert> b)
    {
        b.SetAttribute("mode", "md");
    }

    /// <summary>
    /// <para> The subtitle in the heading of the alert. Displayed under the title. </para>
    /// </summary>
    public static void SetSubHeader(this AttributesBuilder<IonAlert> b,string subHeader)
    {
        b.SetAttribute("sub-header", subHeader);
    }

    /// <summary>
    /// <para> If `true`, the alert will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility). </para>
    /// </summary>
    public static void SetTranslucent(this AttributesBuilder<IonAlert> b)
    {
        b.SetAttribute("translucent", "");
    }

    /// <summary>
    /// <para> If `true`, the alert will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility). </para>
    /// </summary>
    public static void SetTranslucent(this AttributesBuilder<IonAlert> b,bool translucent)
    {
        if (translucent) b.SetAttribute("translucent", "");
    }

    /// <summary>
    /// <para> An ID corresponding to the trigger element that causes the alert to open when clicked. </para>
    /// </summary>
    public static void SetTrigger(this AttributesBuilder<IonAlert> b,string trigger)
    {
        b.SetAttribute("trigger", trigger);
    }

    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonAlert(this LayoutBuilder b, Action<PropsBuilder<IonAlert>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-alert", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonAlert(this LayoutBuilder b, Action<PropsBuilder<IonAlert>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-alert", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonAlert(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-alert", children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonAlert(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-alert", children);
    }
    /// <summary>
    /// <para> If `true`, the alert will animate. </para>
    /// </summary>
    public static void SetAnimated<T>(this PropsBuilder<T> b) where T: IonAlert
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("animated"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, the alert will animate. </para>
    /// </summary>
    public static void SetAnimated<T>(this PropsBuilder<T> b, Var<bool> animated) where T: IonAlert
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("animated"), animated);
    }

    /// <summary>
    /// <para> If `true`, the alert will animate. </para>
    /// </summary>
    public static void SetAnimated<T>(this PropsBuilder<T> b, bool animated) where T: IonAlert
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("animated"), b.Const(animated));
    }


    /// <summary>
    /// <para> If `true`, the alert will be dismissed when the backdrop is clicked. </para>
    /// </summary>
    public static void SetBackdropDismiss<T>(this PropsBuilder<T> b) where T: IonAlert
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("backdropDismiss"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, the alert will be dismissed when the backdrop is clicked. </para>
    /// </summary>
    public static void SetBackdropDismiss<T>(this PropsBuilder<T> b, Var<bool> backdropDismiss) where T: IonAlert
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("backdropDismiss"), backdropDismiss);
    }

    /// <summary>
    /// <para> If `true`, the alert will be dismissed when the backdrop is clicked. </para>
    /// </summary>
    public static void SetBackdropDismiss<T>(this PropsBuilder<T> b, bool backdropDismiss) where T: IonAlert
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("backdropDismiss"), b.Const(backdropDismiss));
    }


    /// <summary>
    /// <para> Array of buttons to be added to the alert. </para>
    /// </summary>
    public static void SetButtons<T>(this PropsBuilder<T> b, Var<List<string>> buttons) where T: IonAlert
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<string>>("buttons"), buttons);
    }

    /// <summary>
    /// <para> Array of buttons to be added to the alert. </para>
    /// </summary>
    public static void SetButtons<T>(this PropsBuilder<T> b, List<string> buttons) where T: IonAlert
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<string>>("buttons"), b.Const(buttons));
    }


    /// <summary>
    /// <para> Array of buttons to be added to the alert. </para>
    /// </summary>
    public static void SetButtons<T>(this PropsBuilder<T> b, Var<List<AlertButton>> buttons) where T: IonAlert
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<AlertButton>>("buttons"), buttons);
    }

    /// <summary>
    /// <para> Array of buttons to be added to the alert. </para>
    /// </summary>
    public static void SetButtons<T>(this PropsBuilder<T> b, List<AlertButton> buttons) where T: IonAlert
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<AlertButton>>("buttons"), b.Const(buttons));
    }


    /// <summary>
    /// <para> Additional classes to apply for custom CSS. If multiple classes are provided they should be separated by spaces. </para>
    /// </summary>
    public static void SetCssClass<T>(this PropsBuilder<T> b, Var<string> cssClass) where T: IonAlert
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("cssClass"), cssClass);
    }

    /// <summary>
    /// <para> Additional classes to apply for custom CSS. If multiple classes are provided they should be separated by spaces. </para>
    /// </summary>
    public static void SetCssClass<T>(this PropsBuilder<T> b, string cssClass) where T: IonAlert
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("cssClass"), b.Const(cssClass));
    }


    /// <summary>
    /// <para> Additional classes to apply for custom CSS. If multiple classes are provided they should be separated by spaces. </para>
    /// </summary>
    public static void SetCssClass<T>(this PropsBuilder<T> b, Var<List<string>> cssClass) where T: IonAlert
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<string>>("cssClass"), cssClass);
    }

    /// <summary>
    /// <para> Additional classes to apply for custom CSS. If multiple classes are provided they should be separated by spaces. </para>
    /// </summary>
    public static void SetCssClass<T>(this PropsBuilder<T> b, List<string> cssClass) where T: IonAlert
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<string>>("cssClass"), b.Const(cssClass));
    }


    /// <summary>
    /// <para> Animation to use when the alert is presented. </para>
    /// </summary>
    public static void SetEnterAnimation<T>(this PropsBuilder<T> b, Var<System.Func<object,object,Animation>> enterAnimation) where T: IonAlert
    {
        b.SetDynamic(b.Props, new DynamicProperty<System.Func<object,object,Animation>>("enterAnimation"), enterAnimation);
    }

    /// <summary>
    /// <para> Animation to use when the alert is presented. </para>
    /// </summary>
    public static void SetEnterAnimation<T>(this PropsBuilder<T> b, System.Func<object,object,Animation> enterAnimation) where T: IonAlert
    {
        b.SetDynamic(b.Props, new DynamicProperty<System.Func<object,object,Animation>>("enterAnimation"), b.Const(enterAnimation));
    }


    /// <summary>
    /// <para> The main title in the heading of the alert. </para>
    /// </summary>
    public static void SetHeader<T>(this PropsBuilder<T> b, Var<string> header) where T: IonAlert
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("header"), header);
    }

    /// <summary>
    /// <para> The main title in the heading of the alert. </para>
    /// </summary>
    public static void SetHeader<T>(this PropsBuilder<T> b, string header) where T: IonAlert
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("header"), b.Const(header));
    }


    /// <summary>
    /// <para> Additional attributes to pass to the alert. </para>
    /// </summary>
    public static void SetHtmlAttributes<T>(this PropsBuilder<T> b, Var<DynamicObject> htmlAttributes) where T: IonAlert
    {
        b.SetDynamic(b.Props, new DynamicProperty<DynamicObject>("htmlAttributes"), htmlAttributes);
    }

    /// <summary>
    /// <para> Additional attributes to pass to the alert. </para>
    /// </summary>
    public static void SetHtmlAttributes<T>(this PropsBuilder<T> b, DynamicObject htmlAttributes) where T: IonAlert
    {
        b.SetDynamic(b.Props, new DynamicProperty<DynamicObject>("htmlAttributes"), b.Const(htmlAttributes));
    }


    /// <summary>
    /// <para> Array of input to show in the alert. </para>
    /// </summary>
    public static void SetInputs<T>(this PropsBuilder<T> b, Var<List<AlertInput>> inputs) where T: IonAlert
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<AlertInput>>("inputs"), inputs);
    }

    /// <summary>
    /// <para> Array of input to show in the alert. </para>
    /// </summary>
    public static void SetInputs<T>(this PropsBuilder<T> b, List<AlertInput> inputs) where T: IonAlert
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<AlertInput>>("inputs"), b.Const(inputs));
    }


    /// <summary>
    /// <para> If `true`, the alert will open. If `false`, the alert will close. Use this if you need finer grained control over presentation, otherwise just use the alertController or the `trigger` property. Note: `isOpen` will not automatically be set back to `false` when the alert dismisses. You will need to do that in your code. </para>
    /// </summary>
    public static void SetIsOpen<T>(this PropsBuilder<T> b) where T: IonAlert
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("isOpen"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, the alert will open. If `false`, the alert will close. Use this if you need finer grained control over presentation, otherwise just use the alertController or the `trigger` property. Note: `isOpen` will not automatically be set back to `false` when the alert dismisses. You will need to do that in your code. </para>
    /// </summary>
    public static void SetIsOpen<T>(this PropsBuilder<T> b, Var<bool> isOpen) where T: IonAlert
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("isOpen"), isOpen);
    }

    /// <summary>
    /// <para> If `true`, the alert will open. If `false`, the alert will close. Use this if you need finer grained control over presentation, otherwise just use the alertController or the `trigger` property. Note: `isOpen` will not automatically be set back to `false` when the alert dismisses. You will need to do that in your code. </para>
    /// </summary>
    public static void SetIsOpen<T>(this PropsBuilder<T> b, bool isOpen) where T: IonAlert
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("isOpen"), b.Const(isOpen));
    }


    /// <summary>
    /// <para> If `true`, the keyboard will be automatically dismissed when the overlay is presented. </para>
    /// </summary>
    public static void SetKeyboardClose<T>(this PropsBuilder<T> b) where T: IonAlert
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("keyboardClose"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, the keyboard will be automatically dismissed when the overlay is presented. </para>
    /// </summary>
    public static void SetKeyboardClose<T>(this PropsBuilder<T> b, Var<bool> keyboardClose) where T: IonAlert
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("keyboardClose"), keyboardClose);
    }

    /// <summary>
    /// <para> If `true`, the keyboard will be automatically dismissed when the overlay is presented. </para>
    /// </summary>
    public static void SetKeyboardClose<T>(this PropsBuilder<T> b, bool keyboardClose) where T: IonAlert
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("keyboardClose"), b.Const(keyboardClose));
    }


    /// <summary>
    /// <para> Animation to use when the alert is dismissed. </para>
    /// </summary>
    public static void SetLeaveAnimation<T>(this PropsBuilder<T> b, Var<System.Func<object,object,Animation>> leaveAnimation) where T: IonAlert
    {
        b.SetDynamic(b.Props, new DynamicProperty<System.Func<object,object,Animation>>("leaveAnimation"), leaveAnimation);
    }

    /// <summary>
    /// <para> Animation to use when the alert is dismissed. </para>
    /// </summary>
    public static void SetLeaveAnimation<T>(this PropsBuilder<T> b, System.Func<object,object,Animation> leaveAnimation) where T: IonAlert
    {
        b.SetDynamic(b.Props, new DynamicProperty<System.Func<object,object,Animation>>("leaveAnimation"), b.Const(leaveAnimation));
    }


    /// <summary>
    /// <para> The main message to be displayed in the alert. `message` can accept either plaintext or HTML as a string. To display characters normally reserved for HTML, they must be escaped. For example `<Ionic>` would become `&lt;Ionic&gt;`  For more information: [Security Documentation](https://ionicframework.com/docs/faq/security)  This property accepts custom HTML as a string. Content is parsed as plaintext by default. `innerHTMLTemplatesEnabled` must be set to `true` in the Ionic config before custom HTML can be used. </para>
    /// </summary>
    public static void SetMessage<T>(this PropsBuilder<T> b, Var<IonicSafeString> message) where T: IonAlert
    {
        b.SetDynamic(b.Props, new DynamicProperty<IonicSafeString>("message"), message);
    }



    /// <summary>
    /// <para> The main message to be displayed in the alert. `message` can accept either plaintext or HTML as a string. To display characters normally reserved for HTML, they must be escaped. For example `<Ionic>` would become `&lt;Ionic&gt;`  For more information: [Security Documentation](https://ionicframework.com/docs/faq/security)  This property accepts custom HTML as a string. Content is parsed as plaintext by default. `innerHTMLTemplatesEnabled` must be set to `true` in the Ionic config before custom HTML can be used. </para>
    /// </summary>
    public static void SetMessage<T>(this PropsBuilder<T> b, Var<string> message) where T: IonAlert
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("message"), message);
    }

    /// <summary>
    /// <para> The main message to be displayed in the alert. `message` can accept either plaintext or HTML as a string. To display characters normally reserved for HTML, they must be escaped. For example `<Ionic>` would become `&lt;Ionic&gt;`  For more information: [Security Documentation](https://ionicframework.com/docs/faq/security)  This property accepts custom HTML as a string. Content is parsed as plaintext by default. `innerHTMLTemplatesEnabled` must be set to `true` in the Ionic config before custom HTML can be used. </para>
    /// </summary>
    public static void SetMessage<T>(this PropsBuilder<T> b, string message) where T: IonAlert
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("message"), b.Const(message));
    }


    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeIos<T>(this PropsBuilder<T> b) where T: IonAlert
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("mode"), b.Const("ios"));
    }


    /// <summary>
    /// <para> The subtitle in the heading of the alert. Displayed under the title. </para>
    /// </summary>
    public static void SetSubHeader<T>(this PropsBuilder<T> b, Var<string> subHeader) where T: IonAlert
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("subHeader"), subHeader);
    }

    /// <summary>
    /// <para> The subtitle in the heading of the alert. Displayed under the title. </para>
    /// </summary>
    public static void SetSubHeader<T>(this PropsBuilder<T> b, string subHeader) where T: IonAlert
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("subHeader"), b.Const(subHeader));
    }


    /// <summary>
    /// <para> If `true`, the alert will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility). </para>
    /// </summary>
    public static void SetTranslucent<T>(this PropsBuilder<T> b) where T: IonAlert
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("translucent"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, the alert will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility). </para>
    /// </summary>
    public static void SetTranslucent<T>(this PropsBuilder<T> b, Var<bool> translucent) where T: IonAlert
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("translucent"), translucent);
    }

    /// <summary>
    /// <para> If `true`, the alert will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility). </para>
    /// </summary>
    public static void SetTranslucent<T>(this PropsBuilder<T> b, bool translucent) where T: IonAlert
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("translucent"), b.Const(translucent));
    }


    /// <summary>
    /// <para> An ID corresponding to the trigger element that causes the alert to open when clicked. </para>
    /// </summary>
    public static void SetTrigger<T>(this PropsBuilder<T> b, Var<string> trigger) where T: IonAlert
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("trigger"), trigger);
    }

    /// <summary>
    /// <para> An ID corresponding to the trigger element that causes the alert to open when clicked. </para>
    /// </summary>
    public static void SetTrigger<T>(this PropsBuilder<T> b, string trigger) where T: IonAlert
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("trigger"), b.Const(trigger));
    }


    /// <summary>
    /// <para> Emitted after the alert has dismissed. Shorthand for ionAlertDidDismiss. </para>
    /// </summary>
    public static void OnDidDismiss<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, OverlayEventDetail>> action) where TComponent: IonAlert
    {
        b.OnEventAction("ondidDismiss", action, "detail");
    }
    /// <summary>
    /// <para> Emitted after the alert has dismissed. Shorthand for ionAlertDidDismiss. </para>
    /// </summary>
    public static void OnDidDismiss<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<OverlayEventDetail>, Var<TModel>> action) where TComponent: IonAlert
    {
        b.OnEventAction("ondidDismiss", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// <para> Emitted after the alert has presented. Shorthand for ionAlertWillDismiss. </para>
    /// </summary>
    public static void OnDidPresent<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonAlert
    {
        b.OnEventAction("ondidPresent", action);
    }
    /// <summary>
    /// <para> Emitted after the alert has presented. Shorthand for ionAlertWillDismiss. </para>
    /// </summary>
    public static void OnDidPresent<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonAlert
    {
        b.OnEventAction("ondidPresent", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted after the alert has dismissed. </para>
    /// </summary>
    public static void OnIonAlertDidDismiss<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, OverlayEventDetail>> action) where TComponent: IonAlert
    {
        b.OnEventAction("onionAlertDidDismiss", action, "detail");
    }
    /// <summary>
    /// <para> Emitted after the alert has dismissed. </para>
    /// </summary>
    public static void OnIonAlertDidDismiss<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<OverlayEventDetail>, Var<TModel>> action) where TComponent: IonAlert
    {
        b.OnEventAction("onionAlertDidDismiss", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// <para> Emitted after the alert has presented. </para>
    /// </summary>
    public static void OnIonAlertDidPresent<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonAlert
    {
        b.OnEventAction("onionAlertDidPresent", action);
    }
    /// <summary>
    /// <para> Emitted after the alert has presented. </para>
    /// </summary>
    public static void OnIonAlertDidPresent<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonAlert
    {
        b.OnEventAction("onionAlertDidPresent", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted before the alert has dismissed. </para>
    /// </summary>
    public static void OnIonAlertWillDismiss<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, OverlayEventDetail>> action) where TComponent: IonAlert
    {
        b.OnEventAction("onionAlertWillDismiss", action, "detail");
    }
    /// <summary>
    /// <para> Emitted before the alert has dismissed. </para>
    /// </summary>
    public static void OnIonAlertWillDismiss<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<OverlayEventDetail>, Var<TModel>> action) where TComponent: IonAlert
    {
        b.OnEventAction("onionAlertWillDismiss", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// <para> Emitted before the alert has presented. </para>
    /// </summary>
    public static void OnIonAlertWillPresent<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonAlert
    {
        b.OnEventAction("onionAlertWillPresent", action);
    }
    /// <summary>
    /// <para> Emitted before the alert has presented. </para>
    /// </summary>
    public static void OnIonAlertWillPresent<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonAlert
    {
        b.OnEventAction("onionAlertWillPresent", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted before the alert has dismissed. Shorthand for ionAlertWillDismiss. </para>
    /// </summary>
    public static void OnWillDismiss<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, OverlayEventDetail>> action) where TComponent: IonAlert
    {
        b.OnEventAction("onwillDismiss", action, "detail");
    }
    /// <summary>
    /// <para> Emitted before the alert has dismissed. Shorthand for ionAlertWillDismiss. </para>
    /// </summary>
    public static void OnWillDismiss<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<OverlayEventDetail>, Var<TModel>> action) where TComponent: IonAlert
    {
        b.OnEventAction("onwillDismiss", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// <para> Emitted before the alert has presented. Shorthand for ionAlertWillPresent. </para>
    /// </summary>
    public static void OnWillPresent<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonAlert
    {
        b.OnEventAction("onwillPresent", action);
    }
    /// <summary>
    /// <para> Emitted before the alert has presented. Shorthand for ionAlertWillPresent. </para>
    /// </summary>
    public static void OnWillPresent<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonAlert
    {
        b.OnEventAction("onwillPresent", b.MakeAction(action));
    }

}

