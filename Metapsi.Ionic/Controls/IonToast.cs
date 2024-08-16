using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Ionic;


public partial class IonToast : IonComponent
{
    public IonToast() : base("ion-toast") { }
    public static class Method
    {
        /// <summary>
        /// <para> Dismiss the toast overlay after it has been presented. </para>
        /// <para> (data?: any, role?: string) =&gt; Promise&lt;boolean&gt; </para>
        /// <para> data Any data to emit in the dismiss events. </para>
        /// <para> role The role of the element that is dismissing the toast. This can be useful in a button handler for determining which button was clicked to dismiss the toast. Some examples include: ``"cancel"`, `"destructive"`, "selected"`, and `"backdrop"`.  This is a no-op if the overlay has not been presented yet. If you want to remove an overlay from the DOM that was never presented, use the [remove](https://developer.mozilla.org/en-US/docs/Web/API/Element/remove) method. </para>
        /// </summary>
        public const string Dismiss = "dismiss";
        /// <summary>
        /// <para> Returns a promise that resolves when the toast did dismiss. </para>
        /// <para> &lt;T = any&gt;() =&gt; Promise&lt;OverlayEventDetail&lt;T&gt;&gt; </para>
        /// </summary>
        public const string OnDidDismiss = "onDidDismiss";
        /// <summary>
        /// <para> Returns a promise that resolves when the toast will dismiss. </para>
        /// <para> &lt;T = any&gt;() =&gt; Promise&lt;OverlayEventDetail&lt;T&gt;&gt; </para>
        /// </summary>
        public const string OnWillDismiss = "onWillDismiss";
        /// <summary>
        /// <para> Present the toast overlay after it has been created. </para>
        /// <para> () =&gt; Promise&lt;void&gt; </para>
        /// </summary>
        public const string Present = "present";
    }
}

public static partial class IonToastControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonToast(this HtmlBuilder b, Action<AttributesBuilder<IonToast>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("ion-toast", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonToast(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("ion-toast", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> If `true`, the toast will animate. </para>
    /// </summary>
    public static void SetAnimated(this AttributesBuilder<IonToast> b)
    {
        b.SetAttribute("animated", "");
    }

    /// <summary>
    /// <para> If `true`, the toast will animate. </para>
    /// </summary>
    public static void SetAnimated(this AttributesBuilder<IonToast> b,bool animated)
    {
        if (animated) b.SetAttribute("animated", "");
    }

    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColor(this AttributesBuilder<IonToast> b,string color)
    {
        b.SetAttribute("color", color);
    }

    /// <summary>
    /// <para> Additional classes to apply for custom CSS. If multiple classes are provided they should be separated by spaces. </para>
    /// </summary>
    public static void SetCssClass(this AttributesBuilder<IonToast> b,string cssClass)
    {
        b.SetAttribute("css-class", cssClass);
    }

    /// <summary>
    /// <para> How many milliseconds to wait before hiding the toast. By default, it will show until `dismiss()` is called. </para>
    /// </summary>
    public static void SetDuration(this AttributesBuilder<IonToast> b,string duration)
    {
        b.SetAttribute("duration", duration);
    }

    /// <summary>
    /// <para> Header to be shown in the toast. </para>
    /// </summary>
    public static void SetHeader(this AttributesBuilder<IonToast> b,string header)
    {
        b.SetAttribute("header", header);
    }

    /// <summary>
    /// <para> The name of the icon to display, or the path to a valid SVG file. See `ion-icon`. https://ionic.io/ionicons </para>
    /// </summary>
    public static void SetIcon(this AttributesBuilder<IonToast> b,string icon)
    {
        b.SetAttribute("icon", icon);
    }

    /// <summary>
    /// <para> If `true`, the toast will open. If `false`, the toast will close. Use this if you need finer grained control over presentation, otherwise just use the toastController or the `trigger` property. Note: `isOpen` will not automatically be set back to `false` when the toast dismisses. You will need to do that in your code. </para>
    /// </summary>
    public static void SetIsOpen(this AttributesBuilder<IonToast> b)
    {
        b.SetAttribute("is-open", "");
    }

    /// <summary>
    /// <para> If `true`, the toast will open. If `false`, the toast will close. Use this if you need finer grained control over presentation, otherwise just use the toastController or the `trigger` property. Note: `isOpen` will not automatically be set back to `false` when the toast dismisses. You will need to do that in your code. </para>
    /// </summary>
    public static void SetIsOpen(this AttributesBuilder<IonToast> b,bool isOpen)
    {
        if (isOpen) b.SetAttribute("is-open", "");
    }

    /// <summary>
    /// <para> If `true`, the keyboard will be automatically dismissed when the overlay is presented. </para>
    /// </summary>
    public static void SetKeyboardClose(this AttributesBuilder<IonToast> b)
    {
        b.SetAttribute("keyboard-close", "");
    }

    /// <summary>
    /// <para> If `true`, the keyboard will be automatically dismissed when the overlay is presented. </para>
    /// </summary>
    public static void SetKeyboardClose(this AttributesBuilder<IonToast> b,bool keyboardClose)
    {
        if (keyboardClose) b.SetAttribute("keyboard-close", "");
    }

    /// <summary>
    /// <para> Defines how the message and buttons are laid out in the toast. 'baseline': The message and the buttons will appear on the same line. Message text may wrap within the message container. 'stacked': The buttons containers and message will stack on top of each other. Use this if you have long text in your buttons. </para>
    /// </summary>
    public static void SetLayout(this AttributesBuilder<IonToast> b,string layout)
    {
        b.SetAttribute("layout", layout);
    }

    /// <summary>
    /// <para> Defines how the message and buttons are laid out in the toast. 'baseline': The message and the buttons will appear on the same line. Message text may wrap within the message container. 'stacked': The buttons containers and message will stack on top of each other. Use this if you have long text in your buttons. </para>
    /// </summary>
    public static void SetLayoutBaseline(this AttributesBuilder<IonToast> b)
    {
        b.SetAttribute("layout", "baseline");
    }

    /// <summary>
    /// <para> Defines how the message and buttons are laid out in the toast. 'baseline': The message and the buttons will appear on the same line. Message text may wrap within the message container. 'stacked': The buttons containers and message will stack on top of each other. Use this if you have long text in your buttons. </para>
    /// </summary>
    public static void SetLayoutStacked(this AttributesBuilder<IonToast> b)
    {
        b.SetAttribute("layout", "stacked");
    }

    /// <summary>
    /// <para> Message to be shown in the toast. This property accepts custom HTML as a string. Content is parsed as plaintext by default. `innerHTMLTemplatesEnabled` must be set to `true` in the Ionic config before custom HTML can be used. </para>
    /// </summary>
    public static void SetMessage(this AttributesBuilder<IonToast> b,string message)
    {
        b.SetAttribute("message", message);
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetMode(this AttributesBuilder<IonToast> b,string mode)
    {
        b.SetAttribute("mode", mode);
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeIos(this AttributesBuilder<IonToast> b)
    {
        b.SetAttribute("mode", "ios");
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeMd(this AttributesBuilder<IonToast> b)
    {
        b.SetAttribute("mode", "md");
    }

    /// <summary>
    /// <para> The starting position of the toast on the screen. Can be tweaked further using the `positionAnchor` property. </para>
    /// </summary>
    public static void SetPosition(this AttributesBuilder<IonToast> b,string position)
    {
        b.SetAttribute("position", position);
    }

    /// <summary>
    /// <para> The starting position of the toast on the screen. Can be tweaked further using the `positionAnchor` property. </para>
    /// </summary>
    public static void SetPositionBottom(this AttributesBuilder<IonToast> b)
    {
        b.SetAttribute("position", "bottom");
    }

    /// <summary>
    /// <para> The starting position of the toast on the screen. Can be tweaked further using the `positionAnchor` property. </para>
    /// </summary>
    public static void SetPositionMiddle(this AttributesBuilder<IonToast> b)
    {
        b.SetAttribute("position", "middle");
    }

    /// <summary>
    /// <para> The starting position of the toast on the screen. Can be tweaked further using the `positionAnchor` property. </para>
    /// </summary>
    public static void SetPositionTop(this AttributesBuilder<IonToast> b)
    {
        b.SetAttribute("position", "top");
    }

    /// <summary>
    /// <para> The element to anchor the toast's position to. Can be set as a direct reference or the ID of the element. With `position="bottom"`, the toast will sit above the chosen element. With `position="top"`, the toast will sit below the chosen element. With `position="middle"`, the value of `positionAnchor` is ignored. </para>
    /// </summary>
    public static void SetPositionAnchor(this AttributesBuilder<IonToast> b,string positionAnchor)
    {
        b.SetAttribute("position-anchor", positionAnchor);
    }

    /// <summary>
    /// <para> If set to 'vertical', the Toast can be dismissed with a swipe gesture. The swipe direction is determined by the value of the `position` property: `top`: The Toast can be swiped up to dismiss. `bottom`: The Toast can be swiped down to dismiss. `middle`: The Toast can be swiped up or down to dismiss. </para>
    /// </summary>
    public static void SetSwipeGesture(this AttributesBuilder<IonToast> b,string swipeGesture)
    {
        b.SetAttribute("swipe-gesture", swipeGesture);
    }

    /// <summary>
    /// <para> If set to 'vertical', the Toast can be dismissed with a swipe gesture. The swipe direction is determined by the value of the `position` property: `top`: The Toast can be swiped up to dismiss. `bottom`: The Toast can be swiped down to dismiss. `middle`: The Toast can be swiped up or down to dismiss. </para>
    /// </summary>
    public static void SetSwipeGestureVertical(this AttributesBuilder<IonToast> b)
    {
        b.SetAttribute("swipe-gesture", "vertical");
    }

    /// <summary>
    /// <para> If `true`, the toast will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility). </para>
    /// </summary>
    public static void SetTranslucent(this AttributesBuilder<IonToast> b)
    {
        b.SetAttribute("translucent", "");
    }

    /// <summary>
    /// <para> If `true`, the toast will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility). </para>
    /// </summary>
    public static void SetTranslucent(this AttributesBuilder<IonToast> b,bool translucent)
    {
        if (translucent) b.SetAttribute("translucent", "");
    }

    /// <summary>
    /// <para> An ID corresponding to the trigger element that causes the toast to open when clicked. </para>
    /// </summary>
    public static void SetTrigger(this AttributesBuilder<IonToast> b,string trigger)
    {
        b.SetAttribute("trigger", trigger);
    }

    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonToast(this LayoutBuilder b, Action<PropsBuilder<IonToast>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-toast", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonToast(this LayoutBuilder b, Action<PropsBuilder<IonToast>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-toast", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonToast(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-toast", children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonToast(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-toast", children);
    }
    /// <summary>
    /// <para> If `true`, the toast will animate. </para>
    /// </summary>
    public static void SetAnimated<T>(this PropsBuilder<T> b) where T: IonToast
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("animated"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, the toast will animate. </para>
    /// </summary>
    public static void SetAnimated<T>(this PropsBuilder<T> b, Var<bool> animated) where T: IonToast
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("animated"), animated);
    }

    /// <summary>
    /// <para> If `true`, the toast will animate. </para>
    /// </summary>
    public static void SetAnimated<T>(this PropsBuilder<T> b, bool animated) where T: IonToast
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("animated"), b.Const(animated));
    }


    /// <summary>
    /// <para> An array of buttons for the toast. </para>
    /// </summary>
    public static void SetButtons<T>(this PropsBuilder<T> b, Var<List<string>> buttons) where T: IonToast
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<string>>("buttons"), buttons);
    }

    /// <summary>
    /// <para> An array of buttons for the toast. </para>
    /// </summary>
    public static void SetButtons<T>(this PropsBuilder<T> b, List<string> buttons) where T: IonToast
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<string>>("buttons"), b.Const(buttons));
    }


    /// <summary>
    /// <para> An array of buttons for the toast. </para>
    /// </summary>
    public static void SetButtons<T>(this PropsBuilder<T> b, Var<List<ToastButton>> buttons) where T: IonToast
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<ToastButton>>("buttons"), buttons);
    }

    /// <summary>
    /// <para> An array of buttons for the toast. </para>
    /// </summary>
    public static void SetButtons<T>(this PropsBuilder<T> b, List<ToastButton> buttons) where T: IonToast
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<ToastButton>>("buttons"), b.Const(buttons));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorDanger<T>(this PropsBuilder<T> b) where T: IonToast
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("danger"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorDark<T>(this PropsBuilder<T> b) where T: IonToast
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("dark"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorLight<T>(this PropsBuilder<T> b) where T: IonToast
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("light"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorMedium<T>(this PropsBuilder<T> b) where T: IonToast
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("medium"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorPrimary<T>(this PropsBuilder<T> b) where T: IonToast
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("primary"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorSecondary<T>(this PropsBuilder<T> b) where T: IonToast
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("secondary"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorSuccess<T>(this PropsBuilder<T> b) where T: IonToast
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("success"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorTertiary<T>(this PropsBuilder<T> b) where T: IonToast
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("tertiary"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorWarning<T>(this PropsBuilder<T> b) where T: IonToast
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("warning"));
    }


    /// <summary>
    /// <para> Additional classes to apply for custom CSS. If multiple classes are provided they should be separated by spaces. </para>
    /// </summary>
    public static void SetCssClass<T>(this PropsBuilder<T> b, Var<string> cssClass) where T: IonToast
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("cssClass"), cssClass);
    }

    /// <summary>
    /// <para> Additional classes to apply for custom CSS. If multiple classes are provided they should be separated by spaces. </para>
    /// </summary>
    public static void SetCssClass<T>(this PropsBuilder<T> b, string cssClass) where T: IonToast
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("cssClass"), b.Const(cssClass));
    }


    /// <summary>
    /// <para> Additional classes to apply for custom CSS. If multiple classes are provided they should be separated by spaces. </para>
    /// </summary>
    public static void SetCssClass<T>(this PropsBuilder<T> b, Var<List<string>> cssClass) where T: IonToast
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<string>>("cssClass"), cssClass);
    }

    /// <summary>
    /// <para> Additional classes to apply for custom CSS. If multiple classes are provided they should be separated by spaces. </para>
    /// </summary>
    public static void SetCssClass<T>(this PropsBuilder<T> b, List<string> cssClass) where T: IonToast
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<string>>("cssClass"), b.Const(cssClass));
    }


    /// <summary>
    /// <para> How many milliseconds to wait before hiding the toast. By default, it will show until `dismiss()` is called. </para>
    /// </summary>
    public static void SetDuration<T>(this PropsBuilder<T> b, Var<int> duration) where T: IonToast
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("duration"), duration);
    }

    /// <summary>
    /// <para> How many milliseconds to wait before hiding the toast. By default, it will show until `dismiss()` is called. </para>
    /// </summary>
    public static void SetDuration<T>(this PropsBuilder<T> b, int duration) where T: IonToast
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("duration"), b.Const(duration));
    }


    /// <summary>
    /// <para> Animation to use when the toast is presented. </para>
    /// </summary>
    public static void SetEnterAnimation<T>(this PropsBuilder<T> b, Var<System.Func<object,object,Animation>> enterAnimation) where T: IonToast
    {
        b.SetDynamic(b.Props, new DynamicProperty<System.Func<object,object,Animation>>("enterAnimation"), enterAnimation);
    }

    /// <summary>
    /// <para> Animation to use when the toast is presented. </para>
    /// </summary>
    public static void SetEnterAnimation<T>(this PropsBuilder<T> b, System.Func<object,object,Animation> enterAnimation) where T: IonToast
    {
        b.SetDynamic(b.Props, new DynamicProperty<System.Func<object,object,Animation>>("enterAnimation"), b.Const(enterAnimation));
    }


    /// <summary>
    /// <para> Header to be shown in the toast. </para>
    /// </summary>
    public static void SetHeader<T>(this PropsBuilder<T> b, Var<string> header) where T: IonToast
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("header"), header);
    }

    /// <summary>
    /// <para> Header to be shown in the toast. </para>
    /// </summary>
    public static void SetHeader<T>(this PropsBuilder<T> b, string header) where T: IonToast
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("header"), b.Const(header));
    }


    /// <summary>
    /// <para> Additional attributes to pass to the toast. </para>
    /// </summary>
    public static void SetHtmlAttributes<T>(this PropsBuilder<T> b, Var<DynamicObject> htmlAttributes) where T: IonToast
    {
        b.SetDynamic(b.Props, new DynamicProperty<DynamicObject>("htmlAttributes"), htmlAttributes);
    }

    /// <summary>
    /// <para> Additional attributes to pass to the toast. </para>
    /// </summary>
    public static void SetHtmlAttributes<T>(this PropsBuilder<T> b, DynamicObject htmlAttributes) where T: IonToast
    {
        b.SetDynamic(b.Props, new DynamicProperty<DynamicObject>("htmlAttributes"), b.Const(htmlAttributes));
    }


    /// <summary>
    /// <para> The name of the icon to display, or the path to a valid SVG file. See `ion-icon`. https://ionic.io/ionicons </para>
    /// </summary>
    public static void SetIcon<T>(this PropsBuilder<T> b, Var<string> icon) where T: IonToast
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("icon"), icon);
    }

    /// <summary>
    /// <para> The name of the icon to display, or the path to a valid SVG file. See `ion-icon`. https://ionic.io/ionicons </para>
    /// </summary>
    public static void SetIcon<T>(this PropsBuilder<T> b, string icon) where T: IonToast
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("icon"), b.Const(icon));
    }


    /// <summary>
    /// <para> If `true`, the toast will open. If `false`, the toast will close. Use this if you need finer grained control over presentation, otherwise just use the toastController or the `trigger` property. Note: `isOpen` will not automatically be set back to `false` when the toast dismisses. You will need to do that in your code. </para>
    /// </summary>
    public static void SetIsOpen<T>(this PropsBuilder<T> b) where T: IonToast
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("isOpen"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, the toast will open. If `false`, the toast will close. Use this if you need finer grained control over presentation, otherwise just use the toastController or the `trigger` property. Note: `isOpen` will not automatically be set back to `false` when the toast dismisses. You will need to do that in your code. </para>
    /// </summary>
    public static void SetIsOpen<T>(this PropsBuilder<T> b, Var<bool> isOpen) where T: IonToast
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("isOpen"), isOpen);
    }

    /// <summary>
    /// <para> If `true`, the toast will open. If `false`, the toast will close. Use this if you need finer grained control over presentation, otherwise just use the toastController or the `trigger` property. Note: `isOpen` will not automatically be set back to `false` when the toast dismisses. You will need to do that in your code. </para>
    /// </summary>
    public static void SetIsOpen<T>(this PropsBuilder<T> b, bool isOpen) where T: IonToast
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("isOpen"), b.Const(isOpen));
    }


    /// <summary>
    /// <para> If `true`, the keyboard will be automatically dismissed when the overlay is presented. </para>
    /// </summary>
    public static void SetKeyboardClose<T>(this PropsBuilder<T> b) where T: IonToast
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("keyboardClose"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, the keyboard will be automatically dismissed when the overlay is presented. </para>
    /// </summary>
    public static void SetKeyboardClose<T>(this PropsBuilder<T> b, Var<bool> keyboardClose) where T: IonToast
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("keyboardClose"), keyboardClose);
    }

    /// <summary>
    /// <para> If `true`, the keyboard will be automatically dismissed when the overlay is presented. </para>
    /// </summary>
    public static void SetKeyboardClose<T>(this PropsBuilder<T> b, bool keyboardClose) where T: IonToast
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("keyboardClose"), b.Const(keyboardClose));
    }


    /// <summary>
    /// <para> Defines how the message and buttons are laid out in the toast. 'baseline': The message and the buttons will appear on the same line. Message text may wrap within the message container. 'stacked': The buttons containers and message will stack on top of each other. Use this if you have long text in your buttons. </para>
    /// </summary>
    public static void SetLayoutBaseline<T>(this PropsBuilder<T> b) where T: IonToast
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("layout"), b.Const("baseline"));
    }


    /// <summary>
    /// <para> Defines how the message and buttons are laid out in the toast. 'baseline': The message and the buttons will appear on the same line. Message text may wrap within the message container. 'stacked': The buttons containers and message will stack on top of each other. Use this if you have long text in your buttons. </para>
    /// </summary>
    public static void SetLayoutStacked<T>(this PropsBuilder<T> b) where T: IonToast
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("layout"), b.Const("stacked"));
    }


    /// <summary>
    /// <para> Animation to use when the toast is dismissed. </para>
    /// </summary>
    public static void SetLeaveAnimation<T>(this PropsBuilder<T> b, Var<System.Func<object,object,Animation>> leaveAnimation) where T: IonToast
    {
        b.SetDynamic(b.Props, new DynamicProperty<System.Func<object,object,Animation>>("leaveAnimation"), leaveAnimation);
    }

    /// <summary>
    /// <para> Animation to use when the toast is dismissed. </para>
    /// </summary>
    public static void SetLeaveAnimation<T>(this PropsBuilder<T> b, System.Func<object,object,Animation> leaveAnimation) where T: IonToast
    {
        b.SetDynamic(b.Props, new DynamicProperty<System.Func<object,object,Animation>>("leaveAnimation"), b.Const(leaveAnimation));
    }


    /// <summary>
    /// <para> Message to be shown in the toast. This property accepts custom HTML as a string. Content is parsed as plaintext by default. `innerHTMLTemplatesEnabled` must be set to `true` in the Ionic config before custom HTML can be used. </para>
    /// </summary>
    public static void SetMessage<T>(this PropsBuilder<T> b, Var<IonicSafeString> message) where T: IonToast
    {
        b.SetDynamic(b.Props, new DynamicProperty<IonicSafeString>("message"), message);
    }



    /// <summary>
    /// <para> Message to be shown in the toast. This property accepts custom HTML as a string. Content is parsed as plaintext by default. `innerHTMLTemplatesEnabled` must be set to `true` in the Ionic config before custom HTML can be used. </para>
    /// </summary>
    public static void SetMessage<T>(this PropsBuilder<T> b, Var<string> message) where T: IonToast
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("message"), message);
    }

    /// <summary>
    /// <para> Message to be shown in the toast. This property accepts custom HTML as a string. Content is parsed as plaintext by default. `innerHTMLTemplatesEnabled` must be set to `true` in the Ionic config before custom HTML can be used. </para>
    /// </summary>
    public static void SetMessage<T>(this PropsBuilder<T> b, string message) where T: IonToast
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("message"), b.Const(message));
    }


    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeIos<T>(this PropsBuilder<T> b) where T: IonToast
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("mode"), b.Const("ios"));
    }


    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeMd<T>(this PropsBuilder<T> b) where T: IonToast
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("mode"), b.Const("md"));
    }


    /// <summary>
    /// <para> The starting position of the toast on the screen. Can be tweaked further using the `positionAnchor` property. </para>
    /// </summary>
    public static void SetPositionBottom<T>(this PropsBuilder<T> b) where T: IonToast
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("position"), b.Const("bottom"));
    }


    /// <summary>
    /// <para> The starting position of the toast on the screen. Can be tweaked further using the `positionAnchor` property. </para>
    /// </summary>
    public static void SetPositionMiddle<T>(this PropsBuilder<T> b) where T: IonToast
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("position"), b.Const("middle"));
    }


    /// <summary>
    /// <para> The starting position of the toast on the screen. Can be tweaked further using the `positionAnchor` property. </para>
    /// </summary>
    public static void SetPositionTop<T>(this PropsBuilder<T> b) where T: IonToast
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("position"), b.Const("top"));
    }


    /// <summary>
    /// <para> The element to anchor the toast's position to. Can be set as a direct reference or the ID of the element. With `position="bottom"`, the toast will sit above the chosen element. With `position="top"`, the toast will sit below the chosen element. With `position="middle"`, the value of `positionAnchor` is ignored. </para>
    /// </summary>
    public static void SetPositionAnchor<T>(this PropsBuilder<T> b, Var<HTMLElement> positionAnchor) where T: IonToast
    {
        b.SetDynamic(b.Props, new DynamicProperty<HTMLElement>("positionAnchor"), positionAnchor);
    }

    /// <summary>
    /// <para> The element to anchor the toast's position to. Can be set as a direct reference or the ID of the element. With `position="bottom"`, the toast will sit above the chosen element. With `position="top"`, the toast will sit below the chosen element. With `position="middle"`, the value of `positionAnchor` is ignored. </para>
    /// </summary>
    public static void SetPositionAnchor<T>(this PropsBuilder<T> b, HTMLElement positionAnchor) where T: IonToast
    {
        b.SetDynamic(b.Props, new DynamicProperty<HTMLElement>("positionAnchor"), b.Const(positionAnchor));
    }


    /// <summary>
    /// <para> The element to anchor the toast's position to. Can be set as a direct reference or the ID of the element. With `position="bottom"`, the toast will sit above the chosen element. With `position="top"`, the toast will sit below the chosen element. With `position="middle"`, the value of `positionAnchor` is ignored. </para>
    /// </summary>
    public static void SetPositionAnchor<T>(this PropsBuilder<T> b, Var<string> positionAnchor) where T: IonToast
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("positionAnchor"), positionAnchor);
    }

    /// <summary>
    /// <para> The element to anchor the toast's position to. Can be set as a direct reference or the ID of the element. With `position="bottom"`, the toast will sit above the chosen element. With `position="top"`, the toast will sit below the chosen element. With `position="middle"`, the value of `positionAnchor` is ignored. </para>
    /// </summary>
    public static void SetPositionAnchor<T>(this PropsBuilder<T> b, string positionAnchor) where T: IonToast
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("positionAnchor"), b.Const(positionAnchor));
    }


    /// <summary>
    /// <para> If set to 'vertical', the Toast can be dismissed with a swipe gesture. The swipe direction is determined by the value of the `position` property: `top`: The Toast can be swiped up to dismiss. `bottom`: The Toast can be swiped down to dismiss. `middle`: The Toast can be swiped up or down to dismiss. </para>
    /// </summary>
    public static void SetSwipeGestureVertical<T>(this PropsBuilder<T> b) where T: IonToast
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("swipeGesture"), b.Const("vertical"));
    }


    /// <summary>
    /// <para> If `true`, the toast will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility). </para>
    /// </summary>
    public static void SetTranslucent<T>(this PropsBuilder<T> b) where T: IonToast
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("translucent"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, the toast will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility). </para>
    /// </summary>
    public static void SetTranslucent<T>(this PropsBuilder<T> b, Var<bool> translucent) where T: IonToast
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("translucent"), translucent);
    }

    /// <summary>
    /// <para> If `true`, the toast will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility). </para>
    /// </summary>
    public static void SetTranslucent<T>(this PropsBuilder<T> b, bool translucent) where T: IonToast
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("translucent"), b.Const(translucent));
    }


    /// <summary>
    /// <para> An ID corresponding to the trigger element that causes the toast to open when clicked. </para>
    /// </summary>
    public static void SetTrigger<T>(this PropsBuilder<T> b, Var<string> trigger) where T: IonToast
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("trigger"), trigger);
    }

    /// <summary>
    /// <para> An ID corresponding to the trigger element that causes the toast to open when clicked. </para>
    /// </summary>
    public static void SetTrigger<T>(this PropsBuilder<T> b, string trigger) where T: IonToast
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("trigger"), b.Const(trigger));
    }


    /// <summary>
    /// <para> Emitted after the toast has dismissed. Shorthand for ionToastDidDismiss. </para>
    /// </summary>
    public static void OnDidDismiss<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, OverlayEventDetail>> action) where TComponent: IonToast
    {
        b.OnEventAction("ondidDismiss", action, "detail");
    }
    /// <summary>
    /// <para> Emitted after the toast has dismissed. Shorthand for ionToastDidDismiss. </para>
    /// </summary>
    public static void OnDidDismiss<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<OverlayEventDetail>, Var<TModel>> action) where TComponent: IonToast
    {
        b.OnEventAction("ondidDismiss", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// <para> Emitted after the toast has presented. Shorthand for ionToastWillDismiss. </para>
    /// </summary>
    public static void OnDidPresent<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonToast
    {
        b.OnEventAction("ondidPresent", action);
    }
    /// <summary>
    /// <para> Emitted after the toast has presented. Shorthand for ionToastWillDismiss. </para>
    /// </summary>
    public static void OnDidPresent<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonToast
    {
        b.OnEventAction("ondidPresent", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted after the toast has dismissed. </para>
    /// </summary>
    public static void OnIonToastDidDismiss<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, OverlayEventDetail>> action) where TComponent: IonToast
    {
        b.OnEventAction("onionToastDidDismiss", action, "detail");
    }
    /// <summary>
    /// <para> Emitted after the toast has dismissed. </para>
    /// </summary>
    public static void OnIonToastDidDismiss<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<OverlayEventDetail>, Var<TModel>> action) where TComponent: IonToast
    {
        b.OnEventAction("onionToastDidDismiss", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// <para> Emitted after the toast has presented. </para>
    /// </summary>
    public static void OnIonToastDidPresent<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonToast
    {
        b.OnEventAction("onionToastDidPresent", action);
    }
    /// <summary>
    /// <para> Emitted after the toast has presented. </para>
    /// </summary>
    public static void OnIonToastDidPresent<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonToast
    {
        b.OnEventAction("onionToastDidPresent", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted before the toast has dismissed. </para>
    /// </summary>
    public static void OnIonToastWillDismiss<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, OverlayEventDetail>> action) where TComponent: IonToast
    {
        b.OnEventAction("onionToastWillDismiss", action, "detail");
    }
    /// <summary>
    /// <para> Emitted before the toast has dismissed. </para>
    /// </summary>
    public static void OnIonToastWillDismiss<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<OverlayEventDetail>, Var<TModel>> action) where TComponent: IonToast
    {
        b.OnEventAction("onionToastWillDismiss", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// <para> Emitted before the toast has presented. </para>
    /// </summary>
    public static void OnIonToastWillPresent<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonToast
    {
        b.OnEventAction("onionToastWillPresent", action);
    }
    /// <summary>
    /// <para> Emitted before the toast has presented. </para>
    /// </summary>
    public static void OnIonToastWillPresent<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonToast
    {
        b.OnEventAction("onionToastWillPresent", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted before the toast has dismissed. Shorthand for ionToastWillDismiss. </para>
    /// </summary>
    public static void OnWillDismiss<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, OverlayEventDetail>> action) where TComponent: IonToast
    {
        b.OnEventAction("onwillDismiss", action, "detail");
    }
    /// <summary>
    /// <para> Emitted before the toast has dismissed. Shorthand for ionToastWillDismiss. </para>
    /// </summary>
    public static void OnWillDismiss<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<OverlayEventDetail>, Var<TModel>> action) where TComponent: IonToast
    {
        b.OnEventAction("onwillDismiss", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// <para> Emitted before the toast has presented. Shorthand for ionToastWillPresent. </para>
    /// </summary>
    public static void OnWillPresent<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonToast
    {
        b.OnEventAction("onwillPresent", action);
    }
    /// <summary>
    /// <para> Emitted before the toast has presented. Shorthand for ionToastWillPresent. </para>
    /// </summary>
    public static void OnWillPresent<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonToast
    {
        b.OnEventAction("onwillPresent", b.MakeAction(action));
    }

}

