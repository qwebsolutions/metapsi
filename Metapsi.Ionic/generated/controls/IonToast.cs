using Metapsi.Html;
using Metapsi.Syntax;
using Metapsi.Hyperapp;

namespace Metapsi.Ionic;

/// <summary>
/// 
/// </summary>
public partial class IonToast
{
    /// <summary>
    /// 
    /// </summary>
    public static class Slot
    {
    }
    /// <summary>
    /// 
    /// </summary>
    public static class Method
    {
        /// <summary>
        /// Dismiss the toast overlay after it has been presented.
        /// </summary>
        public const string Dismiss = "dismiss";
        /// <summary>
        /// Returns a promise that resolves when the toast did dismiss.
        /// </summary>
        public const string OnDidDismiss = "onDidDismiss";
        /// <summary>
        /// Returns a promise that resolves when the toast will dismiss.
        /// </summary>
        public const string OnWillDismiss = "onWillDismiss";
        /// <summary>
        /// Present the toast overlay after it has been created.
        /// </summary>
        public const string Present = "present";
    }
}
/// <summary>
/// Setter extensions of IonToast
/// </summary>
public static partial class IonToastControl
{
    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonToast(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonToast>> buildAttributes, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.IonicTag("ion-toast", buildAttributes, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonToast(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.IonicTag("ion-toast", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonToast(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonToast>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.IonicTag("ion-toast", buildAttributes, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonToast(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.IonicTag("ion-toast", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// If `true`, the toast will animate.
    /// </summary>
    public static void SetAnimated(this Metapsi.Html.AttributesBuilder<IonToast> b, bool animated) 
    {
        if (animated) b.SetAttribute("animated", "");
    }

    /// <summary>
    /// If `true`, the toast will animate.
    /// </summary>
    public static void SetAnimated(this Metapsi.Html.AttributesBuilder<IonToast> b) 
    {
        b.SetAttribute("animated", "");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDanger(this Metapsi.Html.AttributesBuilder<IonToast> b) 
    {
        b.SetAttribute("color", "danger");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDark(this Metapsi.Html.AttributesBuilder<IonToast> b) 
    {
        b.SetAttribute("color", "dark");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorLight(this Metapsi.Html.AttributesBuilder<IonToast> b) 
    {
        b.SetAttribute("color", "light");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorMedium(this Metapsi.Html.AttributesBuilder<IonToast> b) 
    {
        b.SetAttribute("color", "medium");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorPrimary(this Metapsi.Html.AttributesBuilder<IonToast> b) 
    {
        b.SetAttribute("color", "primary");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSecondary(this Metapsi.Html.AttributesBuilder<IonToast> b) 
    {
        b.SetAttribute("color", "secondary");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSuccess(this Metapsi.Html.AttributesBuilder<IonToast> b) 
    {
        b.SetAttribute("color", "success");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorTertiary(this Metapsi.Html.AttributesBuilder<IonToast> b) 
    {
        b.SetAttribute("color", "tertiary");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorWarning(this Metapsi.Html.AttributesBuilder<IonToast> b) 
    {
        b.SetAttribute("color", "warning");
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor(this Metapsi.Html.AttributesBuilder<IonToast> b, string color) 
    {
        b.SetAttribute("color", color);
    }

    /// <summary>
    /// Additional classes to apply for custom CSS. If multiple classes are provided they should be separated by spaces.
    /// </summary>
    public static void SetCssClass(this Metapsi.Html.AttributesBuilder<IonToast> b, string cssClass) 
    {
        b.SetAttribute("cssClass", cssClass);
    }

    /// <summary>
    /// Header to be shown in the toast.
    /// </summary>
    public static void SetHeader(this Metapsi.Html.AttributesBuilder<IonToast> b, string header) 
    {
        b.SetAttribute("header", header);
    }

    /// <summary>
    /// The name of the icon to display, or the path to a valid SVG file. See `ion-icon`. https://ionic.io/ionicons
    /// </summary>
    public static void SetIcon(this Metapsi.Html.AttributesBuilder<IonToast> b, string icon) 
    {
        b.SetAttribute("icon", icon);
    }

    /// <summary>
    /// If `true`, the toast will open. If `false`, the toast will close. Use this if you need finer grained control over presentation, otherwise just use the toastController or the `trigger` property. Note: `isOpen` will not automatically be set back to `false` when the toast dismisses. You will need to do that in your code.
    /// </summary>
    public static void SetIsOpen(this Metapsi.Html.AttributesBuilder<IonToast> b, bool isOpen) 
    {
        if (isOpen) b.SetAttribute("isOpen", "");
    }

    /// <summary>
    /// If `true`, the toast will open. If `false`, the toast will close. Use this if you need finer grained control over presentation, otherwise just use the toastController or the `trigger` property. Note: `isOpen` will not automatically be set back to `false` when the toast dismisses. You will need to do that in your code.
    /// </summary>
    public static void SetIsOpen(this Metapsi.Html.AttributesBuilder<IonToast> b) 
    {
        b.SetAttribute("isOpen", "");
    }

    /// <summary>
    /// If `true`, the keyboard will be automatically dismissed when the overlay is presented.
    /// </summary>
    public static void SetKeyboardClose(this Metapsi.Html.AttributesBuilder<IonToast> b, bool keyboardClose) 
    {
        if (keyboardClose) b.SetAttribute("keyboardClose", "");
    }

    /// <summary>
    /// If `true`, the keyboard will be automatically dismissed when the overlay is presented.
    /// </summary>
    public static void SetKeyboardClose(this Metapsi.Html.AttributesBuilder<IonToast> b) 
    {
        b.SetAttribute("keyboardClose", "");
    }

    /// <summary>
    /// Defines how the message and buttons are laid out in the toast. 'baseline': The message and the buttons will appear on the same line. Message text may wrap within the message container. 'stacked': The buttons containers and message will stack on top of each other. Use this if you have long text in your buttons.
    /// </summary>
    public static void SetLayoutBaseline(this Metapsi.Html.AttributesBuilder<IonToast> b) 
    {
        b.SetAttribute("layout", "baseline");
    }

    /// <summary>
    /// Defines how the message and buttons are laid out in the toast. 'baseline': The message and the buttons will appear on the same line. Message text may wrap within the message container. 'stacked': The buttons containers and message will stack on top of each other. Use this if you have long text in your buttons.
    /// </summary>
    public static void SetLayoutStacked(this Metapsi.Html.AttributesBuilder<IonToast> b) 
    {
        b.SetAttribute("layout", "stacked");
    }

    /// <summary>
    /// Message to be shown in the toast. This property accepts custom HTML as a string. Content is parsed as plaintext by default. `innerHTMLTemplatesEnabled` must be set to `true` in the Ionic config before custom HTML can be used.
    /// </summary>
    public static void SetMessage(this Metapsi.Html.AttributesBuilder<IonToast> b, string message) 
    {
        b.SetAttribute("message", message);
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos(this Metapsi.Html.AttributesBuilder<IonToast> b) 
    {
        b.SetAttribute("mode", "ios");
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd(this Metapsi.Html.AttributesBuilder<IonToast> b) 
    {
        b.SetAttribute("mode", "md");
    }

    /// <summary>
    /// The starting position of the toast on the screen. Can be tweaked further using the `positionAnchor` property.
    /// </summary>
    public static void SetPositionBottom(this Metapsi.Html.AttributesBuilder<IonToast> b) 
    {
        b.SetAttribute("position", "bottom");
    }

    /// <summary>
    /// The starting position of the toast on the screen. Can be tweaked further using the `positionAnchor` property.
    /// </summary>
    public static void SetPositionMiddle(this Metapsi.Html.AttributesBuilder<IonToast> b) 
    {
        b.SetAttribute("position", "middle");
    }

    /// <summary>
    /// The starting position of the toast on the screen. Can be tweaked further using the `positionAnchor` property.
    /// </summary>
    public static void SetPositionTop(this Metapsi.Html.AttributesBuilder<IonToast> b) 
    {
        b.SetAttribute("position", "top");
    }

    /// <summary>
    /// The element to anchor the toast's position to. Can be set as a direct reference or the ID of the element. With `position="bottom"`, the toast will sit above the chosen element. With `position="top"`, the toast will sit below the chosen element. With `position="middle"`, the value of `positionAnchor` is ignored.
    /// </summary>
    public static void SetPositionAnchor(this Metapsi.Html.AttributesBuilder<IonToast> b, string positionAnchor) 
    {
        b.SetAttribute("positionAnchor", positionAnchor);
    }

    /// <summary>
    /// If set to 'vertical', the Toast can be dismissed with a swipe gesture. The swipe direction is determined by the value of the `position` property: `top`: The Toast can be swiped up to dismiss. `bottom`: The Toast can be swiped down to dismiss. `middle`: The Toast can be swiped up or down to dismiss.
    /// </summary>
    public static void SetSwipeGestureVertical(this Metapsi.Html.AttributesBuilder<IonToast> b) 
    {
        b.SetAttribute("swipeGesture", "vertical");
    }

    /// <summary>
    /// If `true`, the toast will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility).
    /// </summary>
    public static void SetTranslucent(this Metapsi.Html.AttributesBuilder<IonToast> b, bool translucent) 
    {
        if (translucent) b.SetAttribute("translucent", "");
    }

    /// <summary>
    /// If `true`, the toast will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility).
    /// </summary>
    public static void SetTranslucent(this Metapsi.Html.AttributesBuilder<IonToast> b) 
    {
        b.SetAttribute("translucent", "");
    }

    /// <summary>
    /// An ID corresponding to the trigger element that causes the toast to open when clicked.
    /// </summary>
    public static void SetTrigger(this Metapsi.Html.AttributesBuilder<IonToast> b, string trigger) 
    {
        b.SetAttribute("trigger", trigger);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonToast(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonToast>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.IonicNode("ion-toast", buildProps, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonToast(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.IonicNode("ion-toast", children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonToast(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonToast>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.IonicNode("ion-toast", buildProps, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonToast(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.IonicNode("ion-toast", children);
    }

    /// <summary>
    /// If `true`, the toast will animate.
    /// </summary>
    public static void SetAnimated<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonToast
    {
        b.SetAnimated(b.Const(true));
    }

    /// <summary>
    /// If `true`, the toast will animate.
    /// </summary>
    public static void SetAnimated<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> animated) where T: IonToast
    {
        b.SetProperty(b.Props, b.Const("animated"), animated);
    }

    /// <summary>
    /// If `true`, the toast will animate.
    /// </summary>
    public static void SetAnimated<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool animated) where T: IonToast
    {
        b.SetAnimated(b.Const(animated));
    }

    /// <summary>
    /// An array of buttons for the toast.
    /// </summary>
    public static void SetButtons<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<System.Collections.Generic.List<string>> buttons) where T: IonToast
    {
        b.SetProperty(b.Props, b.Const("buttons"), buttons);
    }

    /// <summary>
    /// An array of buttons for the toast.
    /// </summary>
    public static void SetButtons<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Ionic.ToastButton>> buttons) where T: IonToast
    {
        b.SetProperty(b.Props, b.Const("buttons"), buttons);
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDanger<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonToast
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("danger"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDark<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonToast
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("dark"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorLight<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonToast
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("light"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorMedium<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonToast
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("medium"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorPrimary<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonToast
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("primary"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSecondary<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonToast
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("secondary"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSuccess<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonToast
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("success"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorTertiary<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonToast
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("tertiary"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorWarning<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonToast
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("warning"));
    }

    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> color) where T: IonToast
    {
        b.SetProperty(b.Props, b.Const("color"), color);
    }

    /// <summary>
    /// Additional classes to apply for custom CSS. If multiple classes are provided they should be separated by spaces.
    /// </summary>
    public static void SetCssClass<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> cssClass) where T: IonToast
    {
        b.SetProperty(b.Props, b.Const("cssClass"), cssClass);
    }

    /// <summary>
    /// Additional classes to apply for custom CSS. If multiple classes are provided they should be separated by spaces.
    /// </summary>
    public static void SetCssClass<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<System.Collections.Generic.List<string>> cssClass) where T: IonToast
    {
        b.SetProperty(b.Props, b.Const("cssClass"), cssClass);
    }

    /// <summary>
    /// How many milliseconds to wait before hiding the toast. By default, it will show until `dismiss()` is called.
    /// </summary>
    public static void SetDuration<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<int> duration) where T: IonToast
    {
        b.SetProperty(b.Props, b.Const("duration"), duration);
    }

    /// <summary>
    /// How many milliseconds to wait before hiding the toast. By default, it will show until `dismiss()` is called.
    /// </summary>
    public static void SetDuration<T>(this Metapsi.Syntax.PropsBuilder<T> b, int duration) where T: IonToast
    {
        b.SetDuration(b.Const(duration));
    }

    /// <summary>
    /// Header to be shown in the toast.
    /// </summary>
    public static void SetHeader<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> header) where T: IonToast
    {
        b.SetProperty(b.Props, b.Const("header"), header);
    }

    /// <summary>
    /// Header to be shown in the toast.
    /// </summary>
    public static void SetHeader<T>(this Metapsi.Syntax.PropsBuilder<T> b, string header) where T: IonToast
    {
        b.SetHeader(b.Const(header));
    }

    /// <summary>
    /// Additional attributes to pass to the toast.
    /// </summary>
    public static void SetHtmlAttributes<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<System.Collections.Generic.List<object>> htmlAttributes) where T: IonToast
    {
        b.SetProperty(b.Props, b.Const("htmlAttributes"), htmlAttributes);
    }

    /// <summary>
    /// The name of the icon to display, or the path to a valid SVG file. See `ion-icon`. https://ionic.io/ionicons
    /// </summary>
    public static void SetIcon<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> icon) where T: IonToast
    {
        b.SetProperty(b.Props, b.Const("icon"), icon);
    }

    /// <summary>
    /// The name of the icon to display, or the path to a valid SVG file. See `ion-icon`. https://ionic.io/ionicons
    /// </summary>
    public static void SetIcon<T>(this Metapsi.Syntax.PropsBuilder<T> b, string icon) where T: IonToast
    {
        b.SetIcon(b.Const(icon));
    }

    /// <summary>
    /// If `true`, the toast will open. If `false`, the toast will close. Use this if you need finer grained control over presentation, otherwise just use the toastController or the `trigger` property. Note: `isOpen` will not automatically be set back to `false` when the toast dismisses. You will need to do that in your code.
    /// </summary>
    public static void SetIsOpen<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonToast
    {
        b.SetIsOpen(b.Const(true));
    }

    /// <summary>
    /// If `true`, the toast will open. If `false`, the toast will close. Use this if you need finer grained control over presentation, otherwise just use the toastController or the `trigger` property. Note: `isOpen` will not automatically be set back to `false` when the toast dismisses. You will need to do that in your code.
    /// </summary>
    public static void SetIsOpen<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> isOpen) where T: IonToast
    {
        b.SetProperty(b.Props, b.Const("isOpen"), isOpen);
    }

    /// <summary>
    /// If `true`, the toast will open. If `false`, the toast will close. Use this if you need finer grained control over presentation, otherwise just use the toastController or the `trigger` property. Note: `isOpen` will not automatically be set back to `false` when the toast dismisses. You will need to do that in your code.
    /// </summary>
    public static void SetIsOpen<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool isOpen) where T: IonToast
    {
        b.SetIsOpen(b.Const(isOpen));
    }

    /// <summary>
    /// If `true`, the keyboard will be automatically dismissed when the overlay is presented.
    /// </summary>
    public static void SetKeyboardClose<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonToast
    {
        b.SetKeyboardClose(b.Const(true));
    }

    /// <summary>
    /// If `true`, the keyboard will be automatically dismissed when the overlay is presented.
    /// </summary>
    public static void SetKeyboardClose<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> keyboardClose) where T: IonToast
    {
        b.SetProperty(b.Props, b.Const("keyboardClose"), keyboardClose);
    }

    /// <summary>
    /// If `true`, the keyboard will be automatically dismissed when the overlay is presented.
    /// </summary>
    public static void SetKeyboardClose<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool keyboardClose) where T: IonToast
    {
        b.SetKeyboardClose(b.Const(keyboardClose));
    }

    /// <summary>
    /// Defines how the message and buttons are laid out in the toast. 'baseline': The message and the buttons will appear on the same line. Message text may wrap within the message container. 'stacked': The buttons containers and message will stack on top of each other. Use this if you have long text in your buttons.
    /// </summary>
    public static void SetLayoutBaseline<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonToast
    {
        b.SetProperty(b.Props, b.Const("layout"), b.Const("baseline"));
    }

    /// <summary>
    /// Defines how the message and buttons are laid out in the toast. 'baseline': The message and the buttons will appear on the same line. Message text may wrap within the message container. 'stacked': The buttons containers and message will stack on top of each other. Use this if you have long text in your buttons.
    /// </summary>
    public static void SetLayoutStacked<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonToast
    {
        b.SetProperty(b.Props, b.Const("layout"), b.Const("stacked"));
    }

    /// <summary>
    /// Message to be shown in the toast. This property accepts custom HTML as a string. Content is parsed as plaintext by default. `innerHTMLTemplatesEnabled` must be set to `true` in the Ionic config before custom HTML can be used.
    /// </summary>
    public static void SetMessage<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> message) where T: IonToast
    {
        b.SetProperty(b.Props, b.Const("message"), message);
    }

    /// <summary>
    /// Message to be shown in the toast. This property accepts custom HTML as a string. Content is parsed as plaintext by default. `innerHTMLTemplatesEnabled` must be set to `true` in the Ionic config before custom HTML can be used.
    /// </summary>
    public static void SetMessage<T>(this Metapsi.Syntax.PropsBuilder<T> b, string message) where T: IonToast
    {
        b.SetMessage(b.Const(message));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonToast
    {
        b.SetProperty(b.Props, b.Const("mode"), b.Const("ios"));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonToast
    {
        b.SetProperty(b.Props, b.Const("mode"), b.Const("md"));
    }

    /// <summary>
    /// The starting position of the toast on the screen. Can be tweaked further using the `positionAnchor` property.
    /// </summary>
    public static void SetPositionBottom<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonToast
    {
        b.SetProperty(b.Props, b.Const("position"), b.Const("bottom"));
    }

    /// <summary>
    /// The starting position of the toast on the screen. Can be tweaked further using the `positionAnchor` property.
    /// </summary>
    public static void SetPositionMiddle<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonToast
    {
        b.SetProperty(b.Props, b.Const("position"), b.Const("middle"));
    }

    /// <summary>
    /// The starting position of the toast on the screen. Can be tweaked further using the `positionAnchor` property.
    /// </summary>
    public static void SetPositionTop<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonToast
    {
        b.SetProperty(b.Props, b.Const("position"), b.Const("top"));
    }

    /// <summary>
    /// The element to anchor the toast's position to. Can be set as a direct reference or the ID of the element. With `position="bottom"`, the toast will sit above the chosen element. With `position="top"`, the toast will sit below the chosen element. With `position="middle"`, the value of `positionAnchor` is ignored.
    /// </summary>
    public static void SetPositionAnchor<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> positionAnchor) where T: IonToast
    {
        b.SetProperty(b.Props, b.Const("positionAnchor"), positionAnchor);
    }

    /// <summary>
    /// The element to anchor the toast's position to. Can be set as a direct reference or the ID of the element. With `position="bottom"`, the toast will sit above the chosen element. With `position="top"`, the toast will sit below the chosen element. With `position="middle"`, the value of `positionAnchor` is ignored.
    /// </summary>
    public static void SetPositionAnchor<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Html.HTMLElement> positionAnchor) where T: IonToast
    {
        b.SetProperty(b.Props, b.Const("positionAnchor"), positionAnchor);
    }

    /// <summary>
    /// If set to 'vertical', the Toast can be dismissed with a swipe gesture. The swipe direction is determined by the value of the `position` property: `top`: The Toast can be swiped up to dismiss. `bottom`: The Toast can be swiped down to dismiss. `middle`: The Toast can be swiped up or down to dismiss.
    /// </summary>
    public static void SetSwipeGestureVertical<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonToast
    {
        b.SetProperty(b.Props, b.Const("swipeGesture"), b.Const("vertical"));
    }

    /// <summary>
    /// If `true`, the toast will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility).
    /// </summary>
    public static void SetTranslucent<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonToast
    {
        b.SetTranslucent(b.Const(true));
    }

    /// <summary>
    /// If `true`, the toast will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility).
    /// </summary>
    public static void SetTranslucent<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> translucent) where T: IonToast
    {
        b.SetProperty(b.Props, b.Const("translucent"), translucent);
    }

    /// <summary>
    /// If `true`, the toast will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility).
    /// </summary>
    public static void SetTranslucent<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool translucent) where T: IonToast
    {
        b.SetTranslucent(b.Const(translucent));
    }

    /// <summary>
    /// An ID corresponding to the trigger element that causes the toast to open when clicked.
    /// </summary>
    public static void SetTrigger<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> trigger) where T: IonToast
    {
        b.SetProperty(b.Props, b.Const("trigger"), trigger);
    }

    /// <summary>
    /// An ID corresponding to the trigger element that causes the toast to open when clicked.
    /// </summary>
    public static void SetTrigger<T>(this Metapsi.Syntax.PropsBuilder<T> b, string trigger) where T: IonToast
    {
        b.SetTrigger(b.Const(trigger));
    }

    /// <summary>
    /// Emitted after the toast has dismissed. Shorthand for ionToastDidDismiss.
    /// </summary>
    public static void OnDidDismiss<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonToast
    {
        b.SetProperty(b.Props, "ondidDismiss", action);
    }

    /// <summary>
    /// Emitted after the toast has dismissed. Shorthand for ionToastDidDismiss.
    /// </summary>
    public static void OnDidDismiss<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonToast
    {
        b.OnDidDismiss(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the toast has dismissed. Shorthand for ionToastDidDismiss.
    /// </summary>
    public static void OnDidDismiss<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonToast
    {
        b.SetProperty(b.Props, "ondidDismiss", action);
    }

    /// <summary>
    /// Emitted after the toast has dismissed. Shorthand for ionToastDidDismiss.
    /// </summary>
    public static void OnDidDismiss<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonToast
    {
        b.OnDidDismiss(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the toast has dismissed. Shorthand for ionToastDidDismiss.
    /// </summary>
    public static void OnDidDismiss<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.CustomEvent<OverlayEventDetail>>> action) where T: IonToast
    {
        b.SetProperty(b.Props, "ondidDismiss", action);
    }

    /// <summary>
    /// Emitted after the toast has presented. Shorthand for ionToastWillDismiss.
    /// </summary>
    public static void OnDidPresent<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonToast
    {
        b.SetProperty(b.Props, "ondidPresent", action);
    }

    /// <summary>
    /// Emitted after the toast has presented. Shorthand for ionToastWillDismiss.
    /// </summary>
    public static void OnDidPresent<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonToast
    {
        b.OnDidPresent(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the toast has presented. Shorthand for ionToastWillDismiss.
    /// </summary>
    public static void OnDidPresent<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonToast
    {
        b.SetProperty(b.Props, "ondidPresent", action);
    }

    /// <summary>
    /// Emitted after the toast has presented. Shorthand for ionToastWillDismiss.
    /// </summary>
    public static void OnDidPresent<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonToast
    {
        b.OnDidPresent(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the toast has dismissed.
    /// </summary>
    public static void OnIonToastDidDismiss<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonToast
    {
        b.SetProperty(b.Props, "onionToastDidDismiss", action);
    }

    /// <summary>
    /// Emitted after the toast has dismissed.
    /// </summary>
    public static void OnIonToastDidDismiss<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonToast
    {
        b.OnIonToastDidDismiss(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the toast has dismissed.
    /// </summary>
    public static void OnIonToastDidDismiss<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonToast
    {
        b.SetProperty(b.Props, "onionToastDidDismiss", action);
    }

    /// <summary>
    /// Emitted after the toast has dismissed.
    /// </summary>
    public static void OnIonToastDidDismiss<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonToast
    {
        b.OnIonToastDidDismiss(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the toast has dismissed.
    /// </summary>
    public static void OnIonToastDidDismiss<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.CustomEvent<OverlayEventDetail>>> action) where T: IonToast
    {
        b.SetProperty(b.Props, "onionToastDidDismiss", action);
    }

    /// <summary>
    /// Emitted after the toast has presented.
    /// </summary>
    public static void OnIonToastDidPresent<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonToast
    {
        b.SetProperty(b.Props, "onionToastDidPresent", action);
    }

    /// <summary>
    /// Emitted after the toast has presented.
    /// </summary>
    public static void OnIonToastDidPresent<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonToast
    {
        b.OnIonToastDidPresent(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the toast has presented.
    /// </summary>
    public static void OnIonToastDidPresent<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonToast
    {
        b.SetProperty(b.Props, "onionToastDidPresent", action);
    }

    /// <summary>
    /// Emitted after the toast has presented.
    /// </summary>
    public static void OnIonToastDidPresent<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonToast
    {
        b.OnIonToastDidPresent(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted before the toast has dismissed.
    /// </summary>
    public static void OnIonToastWillDismiss<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonToast
    {
        b.SetProperty(b.Props, "onionToastWillDismiss", action);
    }

    /// <summary>
    /// Emitted before the toast has dismissed.
    /// </summary>
    public static void OnIonToastWillDismiss<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonToast
    {
        b.OnIonToastWillDismiss(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted before the toast has dismissed.
    /// </summary>
    public static void OnIonToastWillDismiss<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonToast
    {
        b.SetProperty(b.Props, "onionToastWillDismiss", action);
    }

    /// <summary>
    /// Emitted before the toast has dismissed.
    /// </summary>
    public static void OnIonToastWillDismiss<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonToast
    {
        b.OnIonToastWillDismiss(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted before the toast has dismissed.
    /// </summary>
    public static void OnIonToastWillDismiss<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.CustomEvent<OverlayEventDetail>>> action) where T: IonToast
    {
        b.SetProperty(b.Props, "onionToastWillDismiss", action);
    }

    /// <summary>
    /// Emitted before the toast has presented.
    /// </summary>
    public static void OnIonToastWillPresent<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonToast
    {
        b.SetProperty(b.Props, "onionToastWillPresent", action);
    }

    /// <summary>
    /// Emitted before the toast has presented.
    /// </summary>
    public static void OnIonToastWillPresent<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonToast
    {
        b.OnIonToastWillPresent(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted before the toast has presented.
    /// </summary>
    public static void OnIonToastWillPresent<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonToast
    {
        b.SetProperty(b.Props, "onionToastWillPresent", action);
    }

    /// <summary>
    /// Emitted before the toast has presented.
    /// </summary>
    public static void OnIonToastWillPresent<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonToast
    {
        b.OnIonToastWillPresent(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted before the toast has dismissed. Shorthand for ionToastWillDismiss.
    /// </summary>
    public static void OnWillDismiss<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonToast
    {
        b.SetProperty(b.Props, "onwillDismiss", action);
    }

    /// <summary>
    /// Emitted before the toast has dismissed. Shorthand for ionToastWillDismiss.
    /// </summary>
    public static void OnWillDismiss<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonToast
    {
        b.OnWillDismiss(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted before the toast has dismissed. Shorthand for ionToastWillDismiss.
    /// </summary>
    public static void OnWillDismiss<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonToast
    {
        b.SetProperty(b.Props, "onwillDismiss", action);
    }

    /// <summary>
    /// Emitted before the toast has dismissed. Shorthand for ionToastWillDismiss.
    /// </summary>
    public static void OnWillDismiss<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonToast
    {
        b.OnWillDismiss(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted before the toast has dismissed. Shorthand for ionToastWillDismiss.
    /// </summary>
    public static void OnWillDismiss<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.CustomEvent<OverlayEventDetail>>> action) where T: IonToast
    {
        b.SetProperty(b.Props, "onwillDismiss", action);
    }

    /// <summary>
    /// Emitted before the toast has presented. Shorthand for ionToastWillPresent.
    /// </summary>
    public static void OnWillPresent<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonToast
    {
        b.SetProperty(b.Props, "onwillPresent", action);
    }

    /// <summary>
    /// Emitted before the toast has presented. Shorthand for ionToastWillPresent.
    /// </summary>
    public static void OnWillPresent<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonToast
    {
        b.OnWillPresent(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted before the toast has presented. Shorthand for ionToastWillPresent.
    /// </summary>
    public static void OnWillPresent<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonToast
    {
        b.SetProperty(b.Props, "onwillPresent", action);
    }

    /// <summary>
    /// Emitted before the toast has presented. Shorthand for ionToastWillPresent.
    /// </summary>
    public static void OnWillPresent<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonToast
    {
        b.OnWillPresent(b.MakeAction(action));
    }

}