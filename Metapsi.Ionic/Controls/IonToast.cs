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
    /// <summary>
    /// If `true`, the toast will animate.
    /// </summary>
    public bool animated
    {
        get
        {
            return this.GetTag().GetAttribute<bool>("animated");
        }
        set
        {
            if (!value) return;
            this.GetTag().SetAttribute("animated", value.ToString());
        }
    }

    /// <summary>
    /// An array of buttons for the toast.
    /// </summary>
    public List<object> buttons
    {
        get
        {
            return this.GetTag().GetAttribute<List<object>>("buttons");
        }
        set
        {
            this.GetTag().SetAttribute("buttons", value.ToString());
        }
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public string color
    {
        get
        {
            return this.GetTag().GetAttribute<string>("color");
        }
        set
        {
            this.GetTag().SetAttribute("color", value.ToString());
        }
    }

    /// <summary>
    /// Additional classes to apply for custom CSS. If multiple classes are provided they should be separated by spaces.
    /// </summary>
    public string cssClass
    {
        get
        {
            return this.GetTag().GetAttribute<string>("cssClass");
        }
        set
        {
            this.GetTag().SetAttribute("cssClass", value.ToString());
        }
    }

    /// <summary>
    /// How many milliseconds to wait before hiding the toast. By default, it will show until `dismiss()` is called.
    /// </summary>
    public int duration
    {
        get
        {
            return this.GetTag().GetAttribute<int>("duration");
        }
        set
        {
            this.GetTag().SetAttribute("duration", value.ToString());
        }
    }

    /// <summary>
    /// Animation to use when the toast is presented.
    /// </summary>
    public System.Func<object,object,Animation> enterAnimation
    {
        get
        {
            return this.GetTag().GetAttribute<System.Func<object,object,Animation>>("enterAnimation");
        }
        set
        {
            this.GetTag().SetAttribute("enterAnimation", value.ToString());
        }
    }

    /// <summary>
    /// Header to be shown in the toast.
    /// </summary>
    public string header
    {
        get
        {
            return this.GetTag().GetAttribute<string>("header");
        }
        set
        {
            this.GetTag().SetAttribute("header", value.ToString());
        }
    }

    /// <summary>
    /// Additional attributes to pass to the toast.
    /// </summary>
    public object htmlAttributes
    {
        get
        {
            return this.GetTag().GetAttribute<object>("htmlAttributes");
        }
        set
        {
            this.GetTag().SetAttribute("htmlAttributes", value.ToString());
        }
    }

    /// <summary>
    /// The name of the icon to display, or the path to a valid SVG file. See `ion-icon`. https://ionic.io/ionicons
    /// </summary>
    public string icon
    {
        get
        {
            return this.GetTag().GetAttribute<string>("icon");
        }
        set
        {
            this.GetTag().SetAttribute("icon", value.ToString());
        }
    }

    /// <summary>
    /// If `true`, the toast will open. If `false`, the toast will close. Use this if you need finer grained control over presentation, otherwise just use the toastController or the `trigger` property. Note: `isOpen` will not automatically be set back to `false` when the toast dismisses. You will need to do that in your code.
    /// </summary>
    public bool isOpen
    {
        get
        {
            return this.GetTag().GetAttribute<bool>("isOpen");
        }
        set
        {
            if (!value) return;
            this.GetTag().SetAttribute("isOpen", value.ToString());
        }
    }

    /// <summary>
    /// If `true`, the keyboard will be automatically dismissed when the overlay is presented.
    /// </summary>
    public bool keyboardClose
    {
        get
        {
            return this.GetTag().GetAttribute<bool>("keyboardClose");
        }
        set
        {
            if (!value) return;
            this.GetTag().SetAttribute("keyboardClose", value.ToString());
        }
    }

    /// <summary>
    /// Defines how the message and buttons are laid out in the toast. 'baseline': The message and the buttons will appear on the same line. Message text may wrap within the message container. 'stacked': The buttons containers and message will stack on top of each other. Use this if you have long text in your buttons.
    /// </summary>
    public string layout
    {
        get
        {
            return this.GetTag().GetAttribute<string>("layout");
        }
        set
        {
            this.GetTag().SetAttribute("layout", value.ToString());
        }
    }

    /// <summary>
    /// Animation to use when the toast is dismissed.
    /// </summary>
    public System.Func<object,object,Animation> leaveAnimation
    {
        get
        {
            return this.GetTag().GetAttribute<System.Func<object,object,Animation>>("leaveAnimation");
        }
        set
        {
            this.GetTag().SetAttribute("leaveAnimation", value.ToString());
        }
    }

    /// <summary>
    /// Message to be shown in the toast. This property accepts custom HTML as a string. Content is parsed as plaintext by default. `innerHTMLTemplatesEnabled` must be set to `true` in the Ionic config before custom HTML can be used.
    /// </summary>
    public string message
    {
        get
        {
            return this.GetTag().GetAttribute<string>("message");
        }
        set
        {
            this.GetTag().SetAttribute("message", value.ToString());
        }
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public string mode
    {
        get
        {
            return this.GetTag().GetAttribute<string>("mode");
        }
        set
        {
            this.GetTag().SetAttribute("mode", value.ToString());
        }
    }

    /// <summary>
    /// The starting position of the toast on the screen. Can be tweaked further using the `positionAnchor` property.
    /// </summary>
    public string position
    {
        get
        {
            return this.GetTag().GetAttribute<string>("position");
        }
        set
        {
            this.GetTag().SetAttribute("position", value.ToString());
        }
    }

    /// <summary>
    /// The element to anchor the toast's position to. Can be set as a direct reference or the ID of the element. With `position="bottom"`, the toast will sit above the chosen element. With `position="top"`, the toast will sit below the chosen element. With `position="middle"`, the value of `positionAnchor` is ignored.
    /// </summary>
    public string positionAnchor
    {
        get
        {
            return this.GetTag().GetAttribute<string>("positionAnchor");
        }
        set
        {
            this.GetTag().SetAttribute("positionAnchor", value.ToString());
        }
    }

    /// <summary>
    /// If set to 'vertical', the Toast can be dismissed with a swipe gesture. The swipe direction is determined by the value of the `position` property: `top`: The Toast can be swiped up to dismiss. `bottom`: The Toast can be swiped down to dismiss. `middle`: The Toast can be swiped up or down to dismiss.
    /// </summary>
    public string swipeGesture
    {
        get
        {
            return this.GetTag().GetAttribute<string>("swipeGesture");
        }
        set
        {
            this.GetTag().SetAttribute("swipeGesture", value.ToString());
        }
    }

    /// <summary>
    /// If `true`, the toast will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility).
    /// </summary>
    public bool translucent
    {
        get
        {
            return this.GetTag().GetAttribute<bool>("translucent");
        }
        set
        {
            if (!value) return;
            this.GetTag().SetAttribute("translucent", value.ToString());
        }
    }

    /// <summary>
    /// An ID corresponding to the trigger element that causes the toast to open when clicked.
    /// </summary>
    public string trigger
    {
        get
        {
            return this.GetTag().GetAttribute<string>("trigger");
        }
        set
        {
            this.GetTag().SetAttribute("trigger", value.ToString());
        }
    }

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
    /// If `true`, the toast will animate.
    /// </summary>
    public static void SetAnimated(this PropsBuilder<IonToast> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("animated"), b.Const(true));
    }

    /// <summary>
    /// An array of buttons for the toast.
    /// </summary>
    public static void SetButtons(this PropsBuilder<IonToast> b, Var<List<string>> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<string>>("buttons"), value);
    }
    /// <summary>
    /// An array of buttons for the toast.
    /// </summary>
    public static void SetButtons(this PropsBuilder<IonToast> b, List<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<string>>("buttons"), b.Const(value));
    }
    /// <summary>
    /// An array of buttons for the toast.
    /// </summary>
    public static void SetButtons(this PropsBuilder<IonToast> b, Var<List<ToastButton>> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<ToastButton>>("buttons"), value);
    }
    /// <summary>
    /// An array of buttons for the toast.
    /// </summary>
    public static void SetButtons(this PropsBuilder<IonToast> b, List<ToastButton> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<ToastButton>>("buttons"), b.Const(value));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDanger(this PropsBuilder<IonToast> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("danger"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDark(this PropsBuilder<IonToast> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("dark"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorLight(this PropsBuilder<IonToast> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("light"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorMedium(this PropsBuilder<IonToast> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("medium"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorPrimary(this PropsBuilder<IonToast> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("primary"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSecondary(this PropsBuilder<IonToast> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("secondary"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSuccess(this PropsBuilder<IonToast> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("success"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorTertiary(this PropsBuilder<IonToast> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("tertiary"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorWarning(this PropsBuilder<IonToast> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("warning"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor(this PropsBuilder<IonToast> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), value);
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor(this PropsBuilder<IonToast> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const(value));
    }

    /// <summary>
    /// Additional classes to apply for custom CSS. If multiple classes are provided they should be separated by spaces.
    /// </summary>
    public static void SetCssClass(this PropsBuilder<IonToast> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("cssClass"), value);
    }
    /// <summary>
    /// Additional classes to apply for custom CSS. If multiple classes are provided they should be separated by spaces.
    /// </summary>
    public static void SetCssClass(this PropsBuilder<IonToast> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("cssClass"), b.Const(value));
    }
    /// <summary>
    /// Additional classes to apply for custom CSS. If multiple classes are provided they should be separated by spaces.
    /// </summary>
    public static void SetCssClass(this PropsBuilder<IonToast> b, Var<List<string>> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<string>>("cssClass"), value);
    }
    /// <summary>
    /// Additional classes to apply for custom CSS. If multiple classes are provided they should be separated by spaces.
    /// </summary>
    public static void SetCssClass(this PropsBuilder<IonToast> b, List<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<string>>("cssClass"), b.Const(value));
    }

    /// <summary>
    /// How many milliseconds to wait before hiding the toast. By default, it will show until `dismiss()` is called.
    /// </summary>
    public static void SetDuration(this PropsBuilder<IonToast> b, Var<int> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("duration"), value);
    }
    /// <summary>
    /// How many milliseconds to wait before hiding the toast. By default, it will show until `dismiss()` is called.
    /// </summary>
    public static void SetDuration(this PropsBuilder<IonToast> b, int value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("duration"), b.Const(value));
    }

    /// <summary>
    /// Animation to use when the toast is presented.
    /// </summary>
    public static void SetEnterAnimation(this PropsBuilder<IonToast> b, Var<Func<object,object,Animation>> f)
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<object,object,Animation>>("enterAnimation"), f);
    }
    /// <summary>
    /// Animation to use when the toast is presented.
    /// </summary>
    public static void SetEnterAnimation(this PropsBuilder<IonToast> b, Func<SyntaxBuilder,Var<object>,Var<object>,Var<Animation>> f)
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<object,object,Animation>>("enterAnimation"), b.Def(f));
    }

    /// <summary>
    /// Header to be shown in the toast.
    /// </summary>
    public static void SetHeader(this PropsBuilder<IonToast> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("header"), value);
    }
    /// <summary>
    /// Header to be shown in the toast.
    /// </summary>
    public static void SetHeader(this PropsBuilder<IonToast> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("header"), b.Const(value));
    }

    /// <summary>
    /// Additional attributes to pass to the toast.
    /// </summary>
    public static void SetHtmlAttributes(this PropsBuilder<IonToast> b, Var<object> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<object>("htmlAttributes"), value);
    }
    /// <summary>
    /// Additional attributes to pass to the toast.
    /// </summary>
    public static void SetHtmlAttributes(this PropsBuilder<IonToast> b, object value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<object>("htmlAttributes"), b.Const(value));
    }

    /// <summary>
    /// The name of the icon to display, or the path to a valid SVG file. See `ion-icon`. https://ionic.io/ionicons
    /// </summary>
    public static void SetIcon(this PropsBuilder<IonToast> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("icon"), value);
    }
    /// <summary>
    /// The name of the icon to display, or the path to a valid SVG file. See `ion-icon`. https://ionic.io/ionicons
    /// </summary>
    public static void SetIcon(this PropsBuilder<IonToast> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("icon"), b.Const(value));
    }

    /// <summary>
    /// If `true`, the toast will open. If `false`, the toast will close. Use this if you need finer grained control over presentation, otherwise just use the toastController or the `trigger` property. Note: `isOpen` will not automatically be set back to `false` when the toast dismisses. You will need to do that in your code.
    /// </summary>
    public static void SetIsOpen(this PropsBuilder<IonToast> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("isOpen"), b.Const(true));
    }

    /// <summary>
    /// If `true`, the keyboard will be automatically dismissed when the overlay is presented.
    /// </summary>
    public static void SetKeyboardClose(this PropsBuilder<IonToast> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("keyboardClose"), b.Const(true));
    }

    /// <summary>
    /// Defines how the message and buttons are laid out in the toast. 'baseline': The message and the buttons will appear on the same line. Message text may wrap within the message container. 'stacked': The buttons containers and message will stack on top of each other. Use this if you have long text in your buttons.
    /// </summary>
    public static void SetLayoutBaseline(this PropsBuilder<IonToast> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("layout"), b.Const("baseline"));
    }
    /// <summary>
    /// Defines how the message and buttons are laid out in the toast. 'baseline': The message and the buttons will appear on the same line. Message text may wrap within the message container. 'stacked': The buttons containers and message will stack on top of each other. Use this if you have long text in your buttons.
    /// </summary>
    public static void SetLayoutStacked(this PropsBuilder<IonToast> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("layout"), b.Const("stacked"));
    }

    /// <summary>
    /// Animation to use when the toast is dismissed.
    /// </summary>
    public static void SetLeaveAnimation(this PropsBuilder<IonToast> b, Var<Func<object,object,Animation>> f)
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<object,object,Animation>>("leaveAnimation"), f);
    }
    /// <summary>
    /// Animation to use when the toast is dismissed.
    /// </summary>
    public static void SetLeaveAnimation(this PropsBuilder<IonToast> b, Func<SyntaxBuilder,Var<object>,Var<object>,Var<Animation>> f)
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<object,object,Animation>>("leaveAnimation"), b.Def(f));
    }

    /// <summary>
    /// Message to be shown in the toast. This property accepts custom HTML as a string. Content is parsed as plaintext by default. `innerHTMLTemplatesEnabled` must be set to `true` in the Ionic config before custom HTML can be used.
    /// </summary>
    public static void SetMessage(this PropsBuilder<IonToast> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("message"), value);
    }
    /// <summary>
    /// Message to be shown in the toast. This property accepts custom HTML as a string. Content is parsed as plaintext by default. `innerHTMLTemplatesEnabled` must be set to `true` in the Ionic config before custom HTML can be used.
    /// </summary>
    public static void SetMessage(this PropsBuilder<IonToast> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("message"), b.Const(value));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos(this PropsBuilder<IonToast> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("ios"));
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd(this PropsBuilder<IonToast> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("md"));
    }

    /// <summary>
    /// The starting position of the toast on the screen. Can be tweaked further using the `positionAnchor` property.
    /// </summary>
    public static void SetPositionBottom(this PropsBuilder<IonToast> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("position"), b.Const("bottom"));
    }
    /// <summary>
    /// The starting position of the toast on the screen. Can be tweaked further using the `positionAnchor` property.
    /// </summary>
    public static void SetPositionMiddle(this PropsBuilder<IonToast> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("position"), b.Const("middle"));
    }
    /// <summary>
    /// The starting position of the toast on the screen. Can be tweaked further using the `positionAnchor` property.
    /// </summary>
    public static void SetPositionTop(this PropsBuilder<IonToast> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("position"), b.Const("top"));
    }

    /// <summary>
    /// The element to anchor the toast's position to. Can be set as a direct reference or the ID of the element. With `position="bottom"`, the toast will sit above the chosen element. With `position="top"`, the toast will sit below the chosen element. With `position="middle"`, the value of `positionAnchor` is ignored.
    /// </summary>
    public static void SetPositionAnchor(this PropsBuilder<IonToast> b, Var<HTMLElement> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HTMLElement>("positionAnchor"), value);
    }
    /// <summary>
    /// The element to anchor the toast's position to. Can be set as a direct reference or the ID of the element. With `position="bottom"`, the toast will sit above the chosen element. With `position="top"`, the toast will sit below the chosen element. With `position="middle"`, the value of `positionAnchor` is ignored.
    /// </summary>
    public static void SetPositionAnchor(this PropsBuilder<IonToast> b, HTMLElement value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HTMLElement>("positionAnchor"), b.Const(value));
    }
    /// <summary>
    /// The element to anchor the toast's position to. Can be set as a direct reference or the ID of the element. With `position="bottom"`, the toast will sit above the chosen element. With `position="top"`, the toast will sit below the chosen element. With `position="middle"`, the value of `positionAnchor` is ignored.
    /// </summary>
    public static void SetPositionAnchor(this PropsBuilder<IonToast> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("positionAnchor"), value);
    }
    /// <summary>
    /// The element to anchor the toast's position to. Can be set as a direct reference or the ID of the element. With `position="bottom"`, the toast will sit above the chosen element. With `position="top"`, the toast will sit below the chosen element. With `position="middle"`, the value of `positionAnchor` is ignored.
    /// </summary>
    public static void SetPositionAnchor(this PropsBuilder<IonToast> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("positionAnchor"), b.Const(value));
    }

    /// <summary>
    /// If set to 'vertical', the Toast can be dismissed with a swipe gesture. The swipe direction is determined by the value of the `position` property: `top`: The Toast can be swiped up to dismiss. `bottom`: The Toast can be swiped down to dismiss. `middle`: The Toast can be swiped up or down to dismiss.
    /// </summary>
    public static void SetSwipeGestureVertical(this PropsBuilder<IonToast> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("swipeGesture"), b.Const("vertical"));
    }

    /// <summary>
    /// If `true`, the toast will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility).
    /// </summary>
    public static void SetTranslucent(this PropsBuilder<IonToast> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("translucent"), b.Const(true));
    }

    /// <summary>
    /// An ID corresponding to the trigger element that causes the toast to open when clicked.
    /// </summary>
    public static void SetTrigger(this PropsBuilder<IonToast> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("trigger"), value);
    }
    /// <summary>
    /// An ID corresponding to the trigger element that causes the toast to open when clicked.
    /// </summary>
    public static void SetTrigger(this PropsBuilder<IonToast> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("trigger"), b.Const(value));
    }

    /// <summary>
    /// Emitted after the toast has dismissed. Shorthand for ionToastDidDismiss.
    /// </summary>
    public static void OnDidDismiss<TModel>(this PropsBuilder<IonToast> b, Var<HyperType.Action<TModel, OverlayEventDetail>> action)
    {
        b.OnEventAction("ondidDismiss", action, "detail");
    }
    /// <summary>
    /// Emitted after the toast has dismissed. Shorthand for ionToastDidDismiss.
    /// </summary>
    public static void OnDidDismiss<TModel>(this PropsBuilder<IonToast> b, System.Func<SyntaxBuilder, Var<TModel>, Var<OverlayEventDetail>, Var<TModel>> action)
    {
        b.OnEventAction("ondidDismiss", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// Emitted after the toast has presented. Shorthand for ionToastWillDismiss.
    /// </summary>
    public static void OnDidPresent<TModel>(this PropsBuilder<IonToast> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("ondidPresent", action);
    }
    /// <summary>
    /// Emitted after the toast has presented. Shorthand for ionToastWillDismiss.
    /// </summary>
    public static void OnDidPresent<TModel>(this PropsBuilder<IonToast> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("ondidPresent", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the toast has dismissed.
    /// </summary>
    public static void OnIonToastDidDismiss<TModel>(this PropsBuilder<IonToast> b, Var<HyperType.Action<TModel, OverlayEventDetail>> action)
    {
        b.OnEventAction("onionToastDidDismiss", action, "detail");
    }
    /// <summary>
    /// Emitted after the toast has dismissed.
    /// </summary>
    public static void OnIonToastDidDismiss<TModel>(this PropsBuilder<IonToast> b, System.Func<SyntaxBuilder, Var<TModel>, Var<OverlayEventDetail>, Var<TModel>> action)
    {
        b.OnEventAction("onionToastDidDismiss", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// Emitted after the toast has presented.
    /// </summary>
    public static void OnIonToastDidPresent<TModel>(this PropsBuilder<IonToast> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onionToastDidPresent", action);
    }
    /// <summary>
    /// Emitted after the toast has presented.
    /// </summary>
    public static void OnIonToastDidPresent<TModel>(this PropsBuilder<IonToast> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onionToastDidPresent", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted before the toast has dismissed.
    /// </summary>
    public static void OnIonToastWillDismiss<TModel>(this PropsBuilder<IonToast> b, Var<HyperType.Action<TModel, OverlayEventDetail>> action)
    {
        b.OnEventAction("onionToastWillDismiss", action, "detail");
    }
    /// <summary>
    /// Emitted before the toast has dismissed.
    /// </summary>
    public static void OnIonToastWillDismiss<TModel>(this PropsBuilder<IonToast> b, System.Func<SyntaxBuilder, Var<TModel>, Var<OverlayEventDetail>, Var<TModel>> action)
    {
        b.OnEventAction("onionToastWillDismiss", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// Emitted before the toast has presented.
    /// </summary>
    public static void OnIonToastWillPresent<TModel>(this PropsBuilder<IonToast> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onionToastWillPresent", action);
    }
    /// <summary>
    /// Emitted before the toast has presented.
    /// </summary>
    public static void OnIonToastWillPresent<TModel>(this PropsBuilder<IonToast> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onionToastWillPresent", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted before the toast has dismissed. Shorthand for ionToastWillDismiss.
    /// </summary>
    public static void OnWillDismiss<TModel>(this PropsBuilder<IonToast> b, Var<HyperType.Action<TModel, OverlayEventDetail>> action)
    {
        b.OnEventAction("onwillDismiss", action, "detail");
    }
    /// <summary>
    /// Emitted before the toast has dismissed. Shorthand for ionToastWillDismiss.
    /// </summary>
    public static void OnWillDismiss<TModel>(this PropsBuilder<IonToast> b, System.Func<SyntaxBuilder, Var<TModel>, Var<OverlayEventDetail>, Var<TModel>> action)
    {
        b.OnEventAction("onwillDismiss", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// Emitted before the toast has presented. Shorthand for ionToastWillPresent.
    /// </summary>
    public static void OnWillPresent<TModel>(this PropsBuilder<IonToast> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onwillPresent", action);
    }
    /// <summary>
    /// Emitted before the toast has presented. Shorthand for ionToastWillPresent.
    /// </summary>
    public static void OnWillPresent<TModel>(this PropsBuilder<IonToast> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onwillPresent", b.MakeAction(action));
    }

}

