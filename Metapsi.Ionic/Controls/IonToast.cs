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
        /// Dismiss the toast overlay after it has been presented.
        /// <para>(data?: any, role?: string) =&gt; Promise&lt;boolean&gt;</para>
        /// <para>data Any data to emit in the dismiss events.</para>
        /// <para>role The role of the element that is dismissing the toast. This can be useful in a button handler for determining which button was clicked to dismiss the toast. Some examples include: ``"cancel"`, `"destructive"`, "selected"`, and `"backdrop"`.  This is a no-op if the overlay has not been presented yet. If you want to remove an overlay from the DOM that was never presented, use the [remove](https://developer.mozilla.org/en-US/docs/Web/API/Element/remove) method.</para>
        /// </summary>
        public const string Dismiss = "dismiss";
        /// <summary> 
        /// Returns a promise that resolves when the toast did dismiss.
        /// <para>&lt;T = any&gt;() =&gt; Promise&lt;OverlayEventDetail&lt;T&gt;&gt;</para>
        /// </summary>
        public const string OnDidDismiss = "onDidDismiss";
        /// <summary> 
        /// Returns a promise that resolves when the toast will dismiss.
        /// <para>&lt;T = any&gt;() =&gt; Promise&lt;OverlayEventDetail&lt;T&gt;&gt;</para>
        /// </summary>
        public const string OnWillDismiss = "onWillDismiss";
        /// <summary> 
        /// Present the toast overlay after it has been created.
        /// <para>() =&gt; Promise&lt;void&gt;</para>
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
    /// If `true`, the toast will animate.
    /// </summary>
    public static void SetAnimated(this AttributesBuilder<IonToast> b)
    {
        b.SetAttribute("animated", "");
    }
    /// <summary>
    /// If `true`, the toast will animate.
    /// </summary>
    public static void SetAnimated(this AttributesBuilder<IonToast> b, bool value)
    {
        if (value) b.SetAttribute("animated", "");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor(this AttributesBuilder<IonToast> b, string value)
    {
        b.SetAttribute("color", value);
    }

    /// <summary>
    /// Additional classes to apply for custom CSS. If multiple classes are provided they should be separated by spaces.
    /// </summary>
    public static void SetCssClass(this AttributesBuilder<IonToast> b, string value)
    {
        b.SetAttribute("css-class", value);
    }

    /// <summary>
    /// How many milliseconds to wait before hiding the toast. By default, it will show until `dismiss()` is called.
    /// </summary>
    public static void SetDuration(this AttributesBuilder<IonToast> b, string value)
    {
        b.SetAttribute("duration", value);
    }

    /// <summary>
    /// Header to be shown in the toast.
    /// </summary>
    public static void SetHeader(this AttributesBuilder<IonToast> b, string value)
    {
        b.SetAttribute("header", value);
    }

    /// <summary>
    /// The name of the icon to display, or the path to a valid SVG file. See `ion-icon`. https://ionic.io/ionicons
    /// </summary>
    public static void SetIcon(this AttributesBuilder<IonToast> b, string value)
    {
        b.SetAttribute("icon", value);
    }

    /// <summary>
    /// If `true`, the toast will open. If `false`, the toast will close. Use this if you need finer grained control over presentation, otherwise just use the toastController or the `trigger` property. Note: `isOpen` will not automatically be set back to `false` when the toast dismisses. You will need to do that in your code.
    /// </summary>
    public static void SetIsOpen(this AttributesBuilder<IonToast> b)
    {
        b.SetAttribute("is-open", "");
    }
    /// <summary>
    /// If `true`, the toast will open. If `false`, the toast will close. Use this if you need finer grained control over presentation, otherwise just use the toastController or the `trigger` property. Note: `isOpen` will not automatically be set back to `false` when the toast dismisses. You will need to do that in your code.
    /// </summary>
    public static void SetIsOpen(this AttributesBuilder<IonToast> b, bool value)
    {
        if (value) b.SetAttribute("is-open", "");
    }

    /// <summary>
    /// If `true`, the keyboard will be automatically dismissed when the overlay is presented.
    /// </summary>
    public static void SetKeyboardClose(this AttributesBuilder<IonToast> b)
    {
        b.SetAttribute("keyboard-close", "");
    }
    /// <summary>
    /// If `true`, the keyboard will be automatically dismissed when the overlay is presented.
    /// </summary>
    public static void SetKeyboardClose(this AttributesBuilder<IonToast> b, bool value)
    {
        if (value) b.SetAttribute("keyboard-close", "");
    }

    /// <summary>
    /// Defines how the message and buttons are laid out in the toast. 'baseline': The message and the buttons will appear on the same line. Message text may wrap within the message container. 'stacked': The buttons containers and message will stack on top of each other. Use this if you have long text in your buttons.
    /// </summary>
    public static void SetLayout(this AttributesBuilder<IonToast> b, string value)
    {
        b.SetAttribute("layout", value);
    }
    /// <summary>
    /// Defines how the message and buttons are laid out in the toast. 'baseline': The message and the buttons will appear on the same line. Message text may wrap within the message container. 'stacked': The buttons containers and message will stack on top of each other. Use this if you have long text in your buttons.
    /// </summary>
    public static void SetLayoutBaseline(this AttributesBuilder<IonToast> b)
    {
        b.SetAttribute("layout", "baseline");
    }
    /// <summary>
    /// Defines how the message and buttons are laid out in the toast. 'baseline': The message and the buttons will appear on the same line. Message text may wrap within the message container. 'stacked': The buttons containers and message will stack on top of each other. Use this if you have long text in your buttons.
    /// </summary>
    public static void SetLayoutStacked(this AttributesBuilder<IonToast> b)
    {
        b.SetAttribute("layout", "stacked");
    }

    /// <summary>
    /// Message to be shown in the toast. This property accepts custom HTML as a string. Content is parsed as plaintext by default. `innerHTMLTemplatesEnabled` must be set to `true` in the Ionic config before custom HTML can be used.
    /// </summary>
    public static void SetMessage(this AttributesBuilder<IonToast> b, string value)
    {
        b.SetAttribute("message", value);
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetMode(this AttributesBuilder<IonToast> b, string value)
    {
        b.SetAttribute("mode", value);
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos(this AttributesBuilder<IonToast> b)
    {
        b.SetAttribute("mode", "ios");
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd(this AttributesBuilder<IonToast> b)
    {
        b.SetAttribute("mode", "md");
    }

    /// <summary>
    /// The starting position of the toast on the screen. Can be tweaked further using the `positionAnchor` property.
    /// </summary>
    public static void SetPosition(this AttributesBuilder<IonToast> b, string value)
    {
        b.SetAttribute("position", value);
    }
    /// <summary>
    /// The starting position of the toast on the screen. Can be tweaked further using the `positionAnchor` property.
    /// </summary>
    public static void SetPositionBottom(this AttributesBuilder<IonToast> b)
    {
        b.SetAttribute("position", "bottom");
    }
    /// <summary>
    /// The starting position of the toast on the screen. Can be tweaked further using the `positionAnchor` property.
    /// </summary>
    public static void SetPositionMiddle(this AttributesBuilder<IonToast> b)
    {
        b.SetAttribute("position", "middle");
    }
    /// <summary>
    /// The starting position of the toast on the screen. Can be tweaked further using the `positionAnchor` property.
    /// </summary>
    public static void SetPositionTop(this AttributesBuilder<IonToast> b)
    {
        b.SetAttribute("position", "top");
    }

    /// <summary>
    /// The element to anchor the toast's position to. Can be set as a direct reference or the ID of the element. With `position="bottom"`, the toast will sit above the chosen element. With `position="top"`, the toast will sit below the chosen element. With `position="middle"`, the value of `positionAnchor` is ignored.
    /// </summary>
    public static void SetPositionAnchor(this AttributesBuilder<IonToast> b, string value)
    {
        b.SetAttribute("position-anchor", value);
    }

    /// <summary>
    /// If set to 'vertical', the Toast can be dismissed with a swipe gesture. The swipe direction is determined by the value of the `position` property: `top`: The Toast can be swiped up to dismiss. `bottom`: The Toast can be swiped down to dismiss. `middle`: The Toast can be swiped up or down to dismiss.
    /// </summary>
    public static void SetSwipeGesture(this AttributesBuilder<IonToast> b, string value)
    {
        b.SetAttribute("swipe-gesture", value);
    }
    /// <summary>
    /// If set to 'vertical', the Toast can be dismissed with a swipe gesture. The swipe direction is determined by the value of the `position` property: `top`: The Toast can be swiped up to dismiss. `bottom`: The Toast can be swiped down to dismiss. `middle`: The Toast can be swiped up or down to dismiss.
    /// </summary>
    public static void SetSwipeGestureVertical(this AttributesBuilder<IonToast> b)
    {
        b.SetAttribute("swipe-gesture", "vertical");
    }

    /// <summary>
    /// If `true`, the toast will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility).
    /// </summary>
    public static void SetTranslucent(this AttributesBuilder<IonToast> b)
    {
        b.SetAttribute("translucent", "");
    }
    /// <summary>
    /// If `true`, the toast will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility).
    /// </summary>
    public static void SetTranslucent(this AttributesBuilder<IonToast> b, bool value)
    {
        if (value) b.SetAttribute("translucent", "");
    }

    /// <summary>
    /// An ID corresponding to the trigger element that causes the toast to open when clicked.
    /// </summary>
    public static void SetTrigger(this AttributesBuilder<IonToast> b, string value)
    {
        b.SetAttribute("trigger", value);
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
    /// If `true`, the toast will animate.
    /// </summary>
    public static void SetAnimated<T>(this PropsBuilder<T> b) where T: IonToast
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("animated"), b.Const(true));
    }

    /// <summary>
    /// An array of buttons for the toast.
    /// </summary>
    public static void SetButtons<T>(this PropsBuilder<T> b, Var<List<string>> value) where T: IonToast
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<string>>("buttons"), value);
    }
    /// <summary>
    /// An array of buttons for the toast.
    /// </summary>
    public static void SetButtons<T>(this PropsBuilder<T> b, List<string> value) where T: IonToast
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<string>>("buttons"), b.Const(value));
    }
    /// <summary>
    /// An array of buttons for the toast.
    /// </summary>
    public static void SetButtons<T>(this PropsBuilder<T> b, Var<List<ToastButton>> value) where T: IonToast
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<ToastButton>>("buttons"), value);
    }
    /// <summary>
    /// An array of buttons for the toast.
    /// </summary>
    public static void SetButtons<T>(this PropsBuilder<T> b, List<ToastButton> value) where T: IonToast
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<ToastButton>>("buttons"), b.Const(value));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDanger<T>(this PropsBuilder<T> b) where T: IonToast
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("danger"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDark<T>(this PropsBuilder<T> b) where T: IonToast
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("dark"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorLight<T>(this PropsBuilder<T> b) where T: IonToast
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("light"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorMedium<T>(this PropsBuilder<T> b) where T: IonToast
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("medium"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorPrimary<T>(this PropsBuilder<T> b) where T: IonToast
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("primary"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSecondary<T>(this PropsBuilder<T> b) where T: IonToast
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("secondary"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSuccess<T>(this PropsBuilder<T> b) where T: IonToast
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("success"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorTertiary<T>(this PropsBuilder<T> b) where T: IonToast
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("tertiary"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorWarning<T>(this PropsBuilder<T> b) where T: IonToast
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("warning"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor<T>(this PropsBuilder<T> b, Var<string> value) where T: IonToast
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), value);
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor<T>(this PropsBuilder<T> b, string value) where T: IonToast
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const(value));
    }

    /// <summary>
    /// Additional classes to apply for custom CSS. If multiple classes are provided they should be separated by spaces.
    /// </summary>
    public static void SetCssClass<T>(this PropsBuilder<T> b, Var<string> value) where T: IonToast
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("cssClass"), value);
    }
    /// <summary>
    /// Additional classes to apply for custom CSS. If multiple classes are provided they should be separated by spaces.
    /// </summary>
    public static void SetCssClass<T>(this PropsBuilder<T> b, string value) where T: IonToast
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("cssClass"), b.Const(value));
    }
    /// <summary>
    /// Additional classes to apply for custom CSS. If multiple classes are provided they should be separated by spaces.
    /// </summary>
    public static void SetCssClass<T>(this PropsBuilder<T> b, Var<List<string>> value) where T: IonToast
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<string>>("cssClass"), value);
    }
    /// <summary>
    /// Additional classes to apply for custom CSS. If multiple classes are provided they should be separated by spaces.
    /// </summary>
    public static void SetCssClass<T>(this PropsBuilder<T> b, List<string> value) where T: IonToast
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<string>>("cssClass"), b.Const(value));
    }

    /// <summary>
    /// How many milliseconds to wait before hiding the toast. By default, it will show until `dismiss()` is called.
    /// </summary>
    public static void SetDuration<T>(this PropsBuilder<T> b, Var<int> value) where T: IonToast
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("duration"), value);
    }
    /// <summary>
    /// How many milliseconds to wait before hiding the toast. By default, it will show until `dismiss()` is called.
    /// </summary>
    public static void SetDuration<T>(this PropsBuilder<T> b, int value) where T: IonToast
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("duration"), b.Const(value));
    }

    /// <summary>
    /// Animation to use when the toast is presented.
    /// </summary>
    public static void SetEnterAnimation<T>(this PropsBuilder<T> b, Var<Func<object,object,Animation>> f) where T: IonToast
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<object,object,Animation>>("enterAnimation"), f);
    }
    /// <summary>
    /// Animation to use when the toast is presented.
    /// </summary>
    public static void SetEnterAnimation<T>(this PropsBuilder<T> b, Func<SyntaxBuilder,Var<object>,Var<object>,Var<Animation>> f) where T: IonToast
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<object,object,Animation>>("enterAnimation"), b.Def(f));
    }

    /// <summary>
    /// Header to be shown in the toast.
    /// </summary>
    public static void SetHeader<T>(this PropsBuilder<T> b, Var<string> value) where T: IonToast
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("header"), value);
    }
    /// <summary>
    /// Header to be shown in the toast.
    /// </summary>
    public static void SetHeader<T>(this PropsBuilder<T> b, string value) where T: IonToast
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("header"), b.Const(value));
    }

    /// <summary>
    /// Additional attributes to pass to the toast.
    /// </summary>
    public static void SetHtmlAttributes<T>(this PropsBuilder<T> b, Var<DynamicObject> value) where T: IonToast
    {
        b.SetDynamic(b.Props, new DynamicProperty<DynamicObject>("htmlAttributes"), value);
    }
    /// <summary>
    /// Additional attributes to pass to the toast.
    /// </summary>
    public static void SetHtmlAttributes<T>(this PropsBuilder<T> b, DynamicObject value) where T: IonToast
    {
        b.SetDynamic(b.Props, new DynamicProperty<DynamicObject>("htmlAttributes"), b.Const(value));
    }

    /// <summary>
    /// The name of the icon to display, or the path to a valid SVG file. See `ion-icon`. https://ionic.io/ionicons
    /// </summary>
    public static void SetIcon<T>(this PropsBuilder<T> b, Var<string> value) where T: IonToast
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("icon"), value);
    }
    /// <summary>
    /// The name of the icon to display, or the path to a valid SVG file. See `ion-icon`. https://ionic.io/ionicons
    /// </summary>
    public static void SetIcon<T>(this PropsBuilder<T> b, string value) where T: IonToast
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("icon"), b.Const(value));
    }

    /// <summary>
    /// If `true`, the toast will open. If `false`, the toast will close. Use this if you need finer grained control over presentation, otherwise just use the toastController or the `trigger` property. Note: `isOpen` will not automatically be set back to `false` when the toast dismisses. You will need to do that in your code.
    /// </summary>
    public static void SetIsOpen<T>(this PropsBuilder<T> b) where T: IonToast
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("isOpen"), b.Const(true));
    }

    /// <summary>
    /// If `true`, the keyboard will be automatically dismissed when the overlay is presented.
    /// </summary>
    public static void SetKeyboardClose<T>(this PropsBuilder<T> b) where T: IonToast
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("keyboardClose"), b.Const(true));
    }

    /// <summary>
    /// Defines how the message and buttons are laid out in the toast. 'baseline': The message and the buttons will appear on the same line. Message text may wrap within the message container. 'stacked': The buttons containers and message will stack on top of each other. Use this if you have long text in your buttons.
    /// </summary>
    public static void SetLayoutBaseline<T>(this PropsBuilder<T> b) where T: IonToast
    {
        b.SetDynamic(b.Props, DynamicProperty.String("layout"), b.Const("baseline"));
    }
    /// <summary>
    /// Defines how the message and buttons are laid out in the toast. 'baseline': The message and the buttons will appear on the same line. Message text may wrap within the message container. 'stacked': The buttons containers and message will stack on top of each other. Use this if you have long text in your buttons.
    /// </summary>
    public static void SetLayoutStacked<T>(this PropsBuilder<T> b) where T: IonToast
    {
        b.SetDynamic(b.Props, DynamicProperty.String("layout"), b.Const("stacked"));
    }

    /// <summary>
    /// Animation to use when the toast is dismissed.
    /// </summary>
    public static void SetLeaveAnimation<T>(this PropsBuilder<T> b, Var<Func<object,object,Animation>> f) where T: IonToast
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<object,object,Animation>>("leaveAnimation"), f);
    }
    /// <summary>
    /// Animation to use when the toast is dismissed.
    /// </summary>
    public static void SetLeaveAnimation<T>(this PropsBuilder<T> b, Func<SyntaxBuilder,Var<object>,Var<object>,Var<Animation>> f) where T: IonToast
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<object,object,Animation>>("leaveAnimation"), b.Def(f));
    }

    /// <summary>
    /// Message to be shown in the toast. This property accepts custom HTML as a string. Content is parsed as plaintext by default. `innerHTMLTemplatesEnabled` must be set to `true` in the Ionic config before custom HTML can be used.
    /// </summary>
    public static void SetMessage<T>(this PropsBuilder<T> b, Var<string> value) where T: IonToast
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("message"), value);
    }
    /// <summary>
    /// Message to be shown in the toast. This property accepts custom HTML as a string. Content is parsed as plaintext by default. `innerHTMLTemplatesEnabled` must be set to `true` in the Ionic config before custom HTML can be used.
    /// </summary>
    public static void SetMessage<T>(this PropsBuilder<T> b, string value) where T: IonToast
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("message"), b.Const(value));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos<T>(this PropsBuilder<T> b) where T: IonToast
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("ios"));
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd<T>(this PropsBuilder<T> b) where T: IonToast
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("md"));
    }

    /// <summary>
    /// The starting position of the toast on the screen. Can be tweaked further using the `positionAnchor` property.
    /// </summary>
    public static void SetPositionBottom<T>(this PropsBuilder<T> b) where T: IonToast
    {
        b.SetDynamic(b.Props, DynamicProperty.String("position"), b.Const("bottom"));
    }
    /// <summary>
    /// The starting position of the toast on the screen. Can be tweaked further using the `positionAnchor` property.
    /// </summary>
    public static void SetPositionMiddle<T>(this PropsBuilder<T> b) where T: IonToast
    {
        b.SetDynamic(b.Props, DynamicProperty.String("position"), b.Const("middle"));
    }
    /// <summary>
    /// The starting position of the toast on the screen. Can be tweaked further using the `positionAnchor` property.
    /// </summary>
    public static void SetPositionTop<T>(this PropsBuilder<T> b) where T: IonToast
    {
        b.SetDynamic(b.Props, DynamicProperty.String("position"), b.Const("top"));
    }

    /// <summary>
    /// The element to anchor the toast's position to. Can be set as a direct reference or the ID of the element. With `position="bottom"`, the toast will sit above the chosen element. With `position="top"`, the toast will sit below the chosen element. With `position="middle"`, the value of `positionAnchor` is ignored.
    /// </summary>
    public static void SetPositionAnchor<T>(this PropsBuilder<T> b, Var<HTMLElement> value) where T: IonToast
    {
        b.SetDynamic(b.Props, new DynamicProperty<HTMLElement>("positionAnchor"), value);
    }
    /// <summary>
    /// The element to anchor the toast's position to. Can be set as a direct reference or the ID of the element. With `position="bottom"`, the toast will sit above the chosen element. With `position="top"`, the toast will sit below the chosen element. With `position="middle"`, the value of `positionAnchor` is ignored.
    /// </summary>
    public static void SetPositionAnchor<T>(this PropsBuilder<T> b, HTMLElement value) where T: IonToast
    {
        b.SetDynamic(b.Props, new DynamicProperty<HTMLElement>("positionAnchor"), b.Const(value));
    }
    /// <summary>
    /// The element to anchor the toast's position to. Can be set as a direct reference or the ID of the element. With `position="bottom"`, the toast will sit above the chosen element. With `position="top"`, the toast will sit below the chosen element. With `position="middle"`, the value of `positionAnchor` is ignored.
    /// </summary>
    public static void SetPositionAnchor<T>(this PropsBuilder<T> b, Var<string> value) where T: IonToast
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("positionAnchor"), value);
    }
    /// <summary>
    /// The element to anchor the toast's position to. Can be set as a direct reference or the ID of the element. With `position="bottom"`, the toast will sit above the chosen element. With `position="top"`, the toast will sit below the chosen element. With `position="middle"`, the value of `positionAnchor` is ignored.
    /// </summary>
    public static void SetPositionAnchor<T>(this PropsBuilder<T> b, string value) where T: IonToast
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("positionAnchor"), b.Const(value));
    }

    /// <summary>
    /// If set to 'vertical', the Toast can be dismissed with a swipe gesture. The swipe direction is determined by the value of the `position` property: `top`: The Toast can be swiped up to dismiss. `bottom`: The Toast can be swiped down to dismiss. `middle`: The Toast can be swiped up or down to dismiss.
    /// </summary>
    public static void SetSwipeGestureVertical<T>(this PropsBuilder<T> b) where T: IonToast
    {
        b.SetDynamic(b.Props, DynamicProperty.String("swipeGesture"), b.Const("vertical"));
    }

    /// <summary>
    /// If `true`, the toast will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility).
    /// </summary>
    public static void SetTranslucent<T>(this PropsBuilder<T> b) where T: IonToast
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("translucent"), b.Const(true));
    }

    /// <summary>
    /// An ID corresponding to the trigger element that causes the toast to open when clicked.
    /// </summary>
    public static void SetTrigger<T>(this PropsBuilder<T> b, Var<string> value) where T: IonToast
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("trigger"), value);
    }
    /// <summary>
    /// An ID corresponding to the trigger element that causes the toast to open when clicked.
    /// </summary>
    public static void SetTrigger<T>(this PropsBuilder<T> b, string value) where T: IonToast
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("trigger"), b.Const(value));
    }

    /// <summary>
    /// Emitted after the toast has dismissed. Shorthand for ionToastDidDismiss.
    /// </summary>
    public static void OnDidDismiss<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, OverlayEventDetail>> action) where TComponent: IonToast
    {
        b.OnEventAction("ondidDismiss", action, "detail");
    }
    /// <summary>
    /// Emitted after the toast has dismissed. Shorthand for ionToastDidDismiss.
    /// </summary>
    public static void OnDidDismiss<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<OverlayEventDetail>, Var<TModel>> action) where TComponent: IonToast
    {
        b.OnEventAction("ondidDismiss", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// Emitted after the toast has presented. Shorthand for ionToastWillDismiss.
    /// </summary>
    public static void OnDidPresent<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonToast
    {
        b.OnEventAction("ondidPresent", action);
    }
    /// <summary>
    /// Emitted after the toast has presented. Shorthand for ionToastWillDismiss.
    /// </summary>
    public static void OnDidPresent<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonToast
    {
        b.OnEventAction("ondidPresent", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the toast has dismissed.
    /// </summary>
    public static void OnIonToastDidDismiss<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, OverlayEventDetail>> action) where TComponent: IonToast
    {
        b.OnEventAction("onionToastDidDismiss", action, "detail");
    }
    /// <summary>
    /// Emitted after the toast has dismissed.
    /// </summary>
    public static void OnIonToastDidDismiss<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<OverlayEventDetail>, Var<TModel>> action) where TComponent: IonToast
    {
        b.OnEventAction("onionToastDidDismiss", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// Emitted after the toast has presented.
    /// </summary>
    public static void OnIonToastDidPresent<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonToast
    {
        b.OnEventAction("onionToastDidPresent", action);
    }
    /// <summary>
    /// Emitted after the toast has presented.
    /// </summary>
    public static void OnIonToastDidPresent<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonToast
    {
        b.OnEventAction("onionToastDidPresent", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted before the toast has dismissed.
    /// </summary>
    public static void OnIonToastWillDismiss<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, OverlayEventDetail>> action) where TComponent: IonToast
    {
        b.OnEventAction("onionToastWillDismiss", action, "detail");
    }
    /// <summary>
    /// Emitted before the toast has dismissed.
    /// </summary>
    public static void OnIonToastWillDismiss<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<OverlayEventDetail>, Var<TModel>> action) where TComponent: IonToast
    {
        b.OnEventAction("onionToastWillDismiss", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// Emitted before the toast has presented.
    /// </summary>
    public static void OnIonToastWillPresent<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonToast
    {
        b.OnEventAction("onionToastWillPresent", action);
    }
    /// <summary>
    /// Emitted before the toast has presented.
    /// </summary>
    public static void OnIonToastWillPresent<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonToast
    {
        b.OnEventAction("onionToastWillPresent", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted before the toast has dismissed. Shorthand for ionToastWillDismiss.
    /// </summary>
    public static void OnWillDismiss<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, OverlayEventDetail>> action) where TComponent: IonToast
    {
        b.OnEventAction("onwillDismiss", action, "detail");
    }
    /// <summary>
    /// Emitted before the toast has dismissed. Shorthand for ionToastWillDismiss.
    /// </summary>
    public static void OnWillDismiss<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<OverlayEventDetail>, Var<TModel>> action) where TComponent: IonToast
    {
        b.OnEventAction("onwillDismiss", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// Emitted before the toast has presented. Shorthand for ionToastWillPresent.
    /// </summary>
    public static void OnWillPresent<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonToast
    {
        b.OnEventAction("onwillPresent", action);
    }
    /// <summary>
    /// Emitted before the toast has presented. Shorthand for ionToastWillPresent.
    /// </summary>
    public static void OnWillPresent<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonToast
    {
        b.OnEventAction("onwillPresent", b.MakeAction(action));
    }

}

