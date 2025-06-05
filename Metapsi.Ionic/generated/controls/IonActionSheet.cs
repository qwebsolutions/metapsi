using Metapsi.Html;
using Metapsi.Syntax;
using Metapsi.Hyperapp;

namespace Metapsi.Ionic;

/// <summary>
/// 
/// </summary>
public partial class IonActionSheet
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
        /// Dismiss the action sheet overlay after it has been presented.
        /// </summary>
        public const string Dismiss = "dismiss";
        /// <summary>
        /// Returns a promise that resolves when the action sheet did dismiss.
        /// </summary>
        public const string OnDidDismiss = "onDidDismiss";
        /// <summary>
        /// Returns a promise that resolves when the action sheet will dismiss.
        /// </summary>
        public const string OnWillDismiss = "onWillDismiss";
        /// <summary>
        /// Present the action sheet overlay after it has been created.
        /// </summary>
        public const string Present = "present";
    }
}
/// <summary>
/// Setter extensions of IonActionSheet
/// </summary>
public static partial class IonActionSheetControl
{
    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonActionSheet(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonActionSheet>> buildAttributes, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.IonicTag("ion-action-sheet", buildAttributes, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonActionSheet(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.IonicTag("ion-action-sheet", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonActionSheet(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonActionSheet>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.IonicTag("ion-action-sheet", buildAttributes, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonActionSheet(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.IonicTag("ion-action-sheet", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// If `true`, the action sheet will animate.
    /// </summary>
    public static void SetAnimated(this Metapsi.Html.AttributesBuilder<IonActionSheet> b, bool animated) 
    {
        if (animated) b.SetAttribute("animated", "");
    }

    /// <summary>
    /// If `true`, the action sheet will animate.
    /// </summary>
    public static void SetAnimated(this Metapsi.Html.AttributesBuilder<IonActionSheet> b) 
    {
        b.SetAttribute("animated", "");
    }

    /// <summary>
    /// If `true`, the action sheet will be dismissed when the backdrop is clicked.
    /// </summary>
    public static void SetBackdropDismiss(this Metapsi.Html.AttributesBuilder<IonActionSheet> b, bool backdropDismiss) 
    {
        if (backdropDismiss) b.SetAttribute("backdropDismiss", "");
    }

    /// <summary>
    /// If `true`, the action sheet will be dismissed when the backdrop is clicked.
    /// </summary>
    public static void SetBackdropDismiss(this Metapsi.Html.AttributesBuilder<IonActionSheet> b) 
    {
        b.SetAttribute("backdropDismiss", "");
    }

    /// <summary>
    /// Additional classes to apply for custom CSS. If multiple classes are provided they should be separated by spaces.
    /// </summary>
    public static void SetCssClass(this Metapsi.Html.AttributesBuilder<IonActionSheet> b, string cssClass) 
    {
        b.SetAttribute("cssClass", cssClass);
    }

    /// <summary>
    /// Title for the action sheet.
    /// </summary>
    public static void SetHeader(this Metapsi.Html.AttributesBuilder<IonActionSheet> b, string header) 
    {
        b.SetAttribute("header", header);
    }

    /// <summary>
    /// If `true`, the action sheet will open. If `false`, the action sheet will close. Use this if you need finer grained control over presentation, otherwise just use the actionSheetController or the `trigger` property. Note: `isOpen` will not automatically be set back to `false` when the action sheet dismisses. You will need to do that in your code.
    /// </summary>
    public static void SetIsOpen(this Metapsi.Html.AttributesBuilder<IonActionSheet> b, bool isOpen) 
    {
        if (isOpen) b.SetAttribute("isOpen", "");
    }

    /// <summary>
    /// If `true`, the action sheet will open. If `false`, the action sheet will close. Use this if you need finer grained control over presentation, otherwise just use the actionSheetController or the `trigger` property. Note: `isOpen` will not automatically be set back to `false` when the action sheet dismisses. You will need to do that in your code.
    /// </summary>
    public static void SetIsOpen(this Metapsi.Html.AttributesBuilder<IonActionSheet> b) 
    {
        b.SetAttribute("isOpen", "");
    }

    /// <summary>
    /// If `true`, the keyboard will be automatically dismissed when the overlay is presented.
    /// </summary>
    public static void SetKeyboardClose(this Metapsi.Html.AttributesBuilder<IonActionSheet> b, bool keyboardClose) 
    {
        if (keyboardClose) b.SetAttribute("keyboardClose", "");
    }

    /// <summary>
    /// If `true`, the keyboard will be automatically dismissed when the overlay is presented.
    /// </summary>
    public static void SetKeyboardClose(this Metapsi.Html.AttributesBuilder<IonActionSheet> b) 
    {
        b.SetAttribute("keyboardClose", "");
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos(this Metapsi.Html.AttributesBuilder<IonActionSheet> b) 
    {
        b.SetAttribute("mode", "ios");
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd(this Metapsi.Html.AttributesBuilder<IonActionSheet> b) 
    {
        b.SetAttribute("mode", "md");
    }

    /// <summary>
    /// Subtitle for the action sheet.
    /// </summary>
    public static void SetSubHeader(this Metapsi.Html.AttributesBuilder<IonActionSheet> b, string subHeader) 
    {
        b.SetAttribute("subHeader", subHeader);
    }

    /// <summary>
    /// If `true`, the action sheet will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility).
    /// </summary>
    public static void SetTranslucent(this Metapsi.Html.AttributesBuilder<IonActionSheet> b, bool translucent) 
    {
        if (translucent) b.SetAttribute("translucent", "");
    }

    /// <summary>
    /// If `true`, the action sheet will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility).
    /// </summary>
    public static void SetTranslucent(this Metapsi.Html.AttributesBuilder<IonActionSheet> b) 
    {
        b.SetAttribute("translucent", "");
    }

    /// <summary>
    /// An ID corresponding to the trigger element that causes the action sheet to open when clicked.
    /// </summary>
    public static void SetTrigger(this Metapsi.Html.AttributesBuilder<IonActionSheet> b, string trigger) 
    {
        b.SetAttribute("trigger", trigger);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonActionSheet(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonActionSheet>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.IonicNode("ion-action-sheet", buildProps, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonActionSheet(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.IonicNode("ion-action-sheet", children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonActionSheet(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonActionSheet>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.IonicNode("ion-action-sheet", buildProps, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonActionSheet(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.IonicNode("ion-action-sheet", children);
    }

    /// <summary>
    /// If `true`, the action sheet will animate.
    /// </summary>
    public static void SetAnimated<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonActionSheet
    {
        b.SetAnimated(b.Const(true));
    }

    /// <summary>
    /// If `true`, the action sheet will animate.
    /// </summary>
    public static void SetAnimated<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> animated) where T: IonActionSheet
    {
        b.SetProperty(b.Props, b.Const("animated"), animated);
    }

    /// <summary>
    /// If `true`, the action sheet will animate.
    /// </summary>
    public static void SetAnimated<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool animated) where T: IonActionSheet
    {
        b.SetAnimated(b.Const(animated));
    }

    /// <summary>
    /// If `true`, the action sheet will be dismissed when the backdrop is clicked.
    /// </summary>
    public static void SetBackdropDismiss<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonActionSheet
    {
        b.SetBackdropDismiss(b.Const(true));
    }

    /// <summary>
    /// If `true`, the action sheet will be dismissed when the backdrop is clicked.
    /// </summary>
    public static void SetBackdropDismiss<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> backdropDismiss) where T: IonActionSheet
    {
        b.SetProperty(b.Props, b.Const("backdropDismiss"), backdropDismiss);
    }

    /// <summary>
    /// If `true`, the action sheet will be dismissed when the backdrop is clicked.
    /// </summary>
    public static void SetBackdropDismiss<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool backdropDismiss) where T: IonActionSheet
    {
        b.SetBackdropDismiss(b.Const(backdropDismiss));
    }

    /// <summary>
    /// An array of buttons for the action sheet.
    /// </summary>
    public static void SetButtons<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<System.Collections.Generic.List<string>> buttons) where T: IonActionSheet
    {
        b.SetProperty(b.Props, b.Const("buttons"), buttons);
    }

    /// <summary>
    /// An array of buttons for the action sheet.
    /// </summary>
    public static void SetButtons<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Ionic.ActionSheetButton>> buttons) where T: IonActionSheet
    {
        b.SetProperty(b.Props, b.Const("buttons"), buttons);
    }

    /// <summary>
    /// Additional classes to apply for custom CSS. If multiple classes are provided they should be separated by spaces.
    /// </summary>
    public static void SetCssClass<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> cssClass) where T: IonActionSheet
    {
        b.SetProperty(b.Props, b.Const("cssClass"), cssClass);
    }

    /// <summary>
    /// Additional classes to apply for custom CSS. If multiple classes are provided they should be separated by spaces.
    /// </summary>
    public static void SetCssClass<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<System.Collections.Generic.List<string>> cssClass) where T: IonActionSheet
    {
        b.SetProperty(b.Props, b.Const("cssClass"), cssClass);
    }

    /// <summary>
    /// Title for the action sheet.
    /// </summary>
    public static void SetHeader<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> header) where T: IonActionSheet
    {
        b.SetProperty(b.Props, b.Const("header"), header);
    }

    /// <summary>
    /// Title for the action sheet.
    /// </summary>
    public static void SetHeader<T>(this Metapsi.Syntax.PropsBuilder<T> b, string header) where T: IonActionSheet
    {
        b.SetHeader(b.Const(header));
    }

    /// <summary>
    /// Additional attributes to pass to the action sheet.
    /// </summary>
    public static void SetHtmlAttributes<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<System.Collections.Generic.List<object>> htmlAttributes) where T: IonActionSheet
    {
        b.SetProperty(b.Props, b.Const("htmlAttributes"), htmlAttributes);
    }

    /// <summary>
    /// If `true`, the action sheet will open. If `false`, the action sheet will close. Use this if you need finer grained control over presentation, otherwise just use the actionSheetController or the `trigger` property. Note: `isOpen` will not automatically be set back to `false` when the action sheet dismisses. You will need to do that in your code.
    /// </summary>
    public static void SetIsOpen<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonActionSheet
    {
        b.SetIsOpen(b.Const(true));
    }

    /// <summary>
    /// If `true`, the action sheet will open. If `false`, the action sheet will close. Use this if you need finer grained control over presentation, otherwise just use the actionSheetController or the `trigger` property. Note: `isOpen` will not automatically be set back to `false` when the action sheet dismisses. You will need to do that in your code.
    /// </summary>
    public static void SetIsOpen<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> isOpen) where T: IonActionSheet
    {
        b.SetProperty(b.Props, b.Const("isOpen"), isOpen);
    }

    /// <summary>
    /// If `true`, the action sheet will open. If `false`, the action sheet will close. Use this if you need finer grained control over presentation, otherwise just use the actionSheetController or the `trigger` property. Note: `isOpen` will not automatically be set back to `false` when the action sheet dismisses. You will need to do that in your code.
    /// </summary>
    public static void SetIsOpen<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool isOpen) where T: IonActionSheet
    {
        b.SetIsOpen(b.Const(isOpen));
    }

    /// <summary>
    /// If `true`, the keyboard will be automatically dismissed when the overlay is presented.
    /// </summary>
    public static void SetKeyboardClose<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonActionSheet
    {
        b.SetKeyboardClose(b.Const(true));
    }

    /// <summary>
    /// If `true`, the keyboard will be automatically dismissed when the overlay is presented.
    /// </summary>
    public static void SetKeyboardClose<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> keyboardClose) where T: IonActionSheet
    {
        b.SetProperty(b.Props, b.Const("keyboardClose"), keyboardClose);
    }

    /// <summary>
    /// If `true`, the keyboard will be automatically dismissed when the overlay is presented.
    /// </summary>
    public static void SetKeyboardClose<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool keyboardClose) where T: IonActionSheet
    {
        b.SetKeyboardClose(b.Const(keyboardClose));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonActionSheet
    {
        b.SetProperty(b.Props, b.Const("mode"), b.Const("ios"));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonActionSheet
    {
        b.SetProperty(b.Props, b.Const("mode"), b.Const("md"));
    }

    /// <summary>
    /// Subtitle for the action sheet.
    /// </summary>
    public static void SetSubHeader<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> subHeader) where T: IonActionSheet
    {
        b.SetProperty(b.Props, b.Const("subHeader"), subHeader);
    }

    /// <summary>
    /// Subtitle for the action sheet.
    /// </summary>
    public static void SetSubHeader<T>(this Metapsi.Syntax.PropsBuilder<T> b, string subHeader) where T: IonActionSheet
    {
        b.SetSubHeader(b.Const(subHeader));
    }

    /// <summary>
    /// If `true`, the action sheet will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility).
    /// </summary>
    public static void SetTranslucent<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonActionSheet
    {
        b.SetTranslucent(b.Const(true));
    }

    /// <summary>
    /// If `true`, the action sheet will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility).
    /// </summary>
    public static void SetTranslucent<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> translucent) where T: IonActionSheet
    {
        b.SetProperty(b.Props, b.Const("translucent"), translucent);
    }

    /// <summary>
    /// If `true`, the action sheet will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility).
    /// </summary>
    public static void SetTranslucent<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool translucent) where T: IonActionSheet
    {
        b.SetTranslucent(b.Const(translucent));
    }

    /// <summary>
    /// An ID corresponding to the trigger element that causes the action sheet to open when clicked.
    /// </summary>
    public static void SetTrigger<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> trigger) where T: IonActionSheet
    {
        b.SetProperty(b.Props, b.Const("trigger"), trigger);
    }

    /// <summary>
    /// An ID corresponding to the trigger element that causes the action sheet to open when clicked.
    /// </summary>
    public static void SetTrigger<T>(this Metapsi.Syntax.PropsBuilder<T> b, string trigger) where T: IonActionSheet
    {
        b.SetTrigger(b.Const(trigger));
    }

    /// <summary>
    /// Emitted after the action sheet has dismissed. Shorthand for ionActionSheetDidDismiss.
    /// </summary>
    public static void OnDidDismiss<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonActionSheet
    {
        b.SetProperty(b.Props, "ondidDismiss", action);
    }

    /// <summary>
    /// Emitted after the action sheet has dismissed. Shorthand for ionActionSheetDidDismiss.
    /// </summary>
    public static void OnDidDismiss<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonActionSheet
    {
        b.OnDidDismiss(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the action sheet has dismissed. Shorthand for ionActionSheetDidDismiss.
    /// </summary>
    public static void OnDidDismiss<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonActionSheet
    {
        b.SetProperty(b.Props, "ondidDismiss", action);
    }

    /// <summary>
    /// Emitted after the action sheet has dismissed. Shorthand for ionActionSheetDidDismiss.
    /// </summary>
    public static void OnDidDismiss<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonActionSheet
    {
        b.OnDidDismiss(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the action sheet has dismissed. Shorthand for ionActionSheetDidDismiss.
    /// </summary>
    public static void OnDidDismiss<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.CustomEvent<OverlayEventDetail>>> action) where T: IonActionSheet
    {
        b.SetProperty(b.Props, "ondidDismiss", action);
    }

    /// <summary>
    /// Emitted after the action sheet has presented. Shorthand for ionActionSheetWillDismiss.
    /// </summary>
    public static void OnDidPresent<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonActionSheet
    {
        b.SetProperty(b.Props, "ondidPresent", action);
    }

    /// <summary>
    /// Emitted after the action sheet has presented. Shorthand for ionActionSheetWillDismiss.
    /// </summary>
    public static void OnDidPresent<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonActionSheet
    {
        b.OnDidPresent(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the action sheet has presented. Shorthand for ionActionSheetWillDismiss.
    /// </summary>
    public static void OnDidPresent<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonActionSheet
    {
        b.SetProperty(b.Props, "ondidPresent", action);
    }

    /// <summary>
    /// Emitted after the action sheet has presented. Shorthand for ionActionSheetWillDismiss.
    /// </summary>
    public static void OnDidPresent<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonActionSheet
    {
        b.OnDidPresent(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the action sheet has dismissed.
    /// </summary>
    public static void OnIonActionSheetDidDismiss<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonActionSheet
    {
        b.SetProperty(b.Props, "onionActionSheetDidDismiss", action);
    }

    /// <summary>
    /// Emitted after the action sheet has dismissed.
    /// </summary>
    public static void OnIonActionSheetDidDismiss<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonActionSheet
    {
        b.OnIonActionSheetDidDismiss(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the action sheet has dismissed.
    /// </summary>
    public static void OnIonActionSheetDidDismiss<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonActionSheet
    {
        b.SetProperty(b.Props, "onionActionSheetDidDismiss", action);
    }

    /// <summary>
    /// Emitted after the action sheet has dismissed.
    /// </summary>
    public static void OnIonActionSheetDidDismiss<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonActionSheet
    {
        b.OnIonActionSheetDidDismiss(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the action sheet has dismissed.
    /// </summary>
    public static void OnIonActionSheetDidDismiss<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.CustomEvent<OverlayEventDetail>>> action) where T: IonActionSheet
    {
        b.SetProperty(b.Props, "onionActionSheetDidDismiss", action);
    }

    /// <summary>
    /// Emitted after the action sheet has presented.
    /// </summary>
    public static void OnIonActionSheetDidPresent<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonActionSheet
    {
        b.SetProperty(b.Props, "onionActionSheetDidPresent", action);
    }

    /// <summary>
    /// Emitted after the action sheet has presented.
    /// </summary>
    public static void OnIonActionSheetDidPresent<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonActionSheet
    {
        b.OnIonActionSheetDidPresent(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the action sheet has presented.
    /// </summary>
    public static void OnIonActionSheetDidPresent<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonActionSheet
    {
        b.SetProperty(b.Props, "onionActionSheetDidPresent", action);
    }

    /// <summary>
    /// Emitted after the action sheet has presented.
    /// </summary>
    public static void OnIonActionSheetDidPresent<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonActionSheet
    {
        b.OnIonActionSheetDidPresent(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted before the action sheet has dismissed.
    /// </summary>
    public static void OnIonActionSheetWillDismiss<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonActionSheet
    {
        b.SetProperty(b.Props, "onionActionSheetWillDismiss", action);
    }

    /// <summary>
    /// Emitted before the action sheet has dismissed.
    /// </summary>
    public static void OnIonActionSheetWillDismiss<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonActionSheet
    {
        b.OnIonActionSheetWillDismiss(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted before the action sheet has dismissed.
    /// </summary>
    public static void OnIonActionSheetWillDismiss<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonActionSheet
    {
        b.SetProperty(b.Props, "onionActionSheetWillDismiss", action);
    }

    /// <summary>
    /// Emitted before the action sheet has dismissed.
    /// </summary>
    public static void OnIonActionSheetWillDismiss<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonActionSheet
    {
        b.OnIonActionSheetWillDismiss(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted before the action sheet has dismissed.
    /// </summary>
    public static void OnIonActionSheetWillDismiss<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.CustomEvent<OverlayEventDetail>>> action) where T: IonActionSheet
    {
        b.SetProperty(b.Props, "onionActionSheetWillDismiss", action);
    }

    /// <summary>
    /// Emitted before the action sheet has presented.
    /// </summary>
    public static void OnIonActionSheetWillPresent<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonActionSheet
    {
        b.SetProperty(b.Props, "onionActionSheetWillPresent", action);
    }

    /// <summary>
    /// Emitted before the action sheet has presented.
    /// </summary>
    public static void OnIonActionSheetWillPresent<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonActionSheet
    {
        b.OnIonActionSheetWillPresent(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted before the action sheet has presented.
    /// </summary>
    public static void OnIonActionSheetWillPresent<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonActionSheet
    {
        b.SetProperty(b.Props, "onionActionSheetWillPresent", action);
    }

    /// <summary>
    /// Emitted before the action sheet has presented.
    /// </summary>
    public static void OnIonActionSheetWillPresent<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonActionSheet
    {
        b.OnIonActionSheetWillPresent(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted before the action sheet has dismissed. Shorthand for ionActionSheetWillDismiss.
    /// </summary>
    public static void OnWillDismiss<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonActionSheet
    {
        b.SetProperty(b.Props, "onwillDismiss", action);
    }

    /// <summary>
    /// Emitted before the action sheet has dismissed. Shorthand for ionActionSheetWillDismiss.
    /// </summary>
    public static void OnWillDismiss<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonActionSheet
    {
        b.OnWillDismiss(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted before the action sheet has dismissed. Shorthand for ionActionSheetWillDismiss.
    /// </summary>
    public static void OnWillDismiss<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonActionSheet
    {
        b.SetProperty(b.Props, "onwillDismiss", action);
    }

    /// <summary>
    /// Emitted before the action sheet has dismissed. Shorthand for ionActionSheetWillDismiss.
    /// </summary>
    public static void OnWillDismiss<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonActionSheet
    {
        b.OnWillDismiss(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted before the action sheet has dismissed. Shorthand for ionActionSheetWillDismiss.
    /// </summary>
    public static void OnWillDismiss<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.CustomEvent<OverlayEventDetail>>> action) where T: IonActionSheet
    {
        b.SetProperty(b.Props, "onwillDismiss", action);
    }

    /// <summary>
    /// Emitted before the action sheet has presented. Shorthand for ionActionSheetWillPresent.
    /// </summary>
    public static void OnWillPresent<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonActionSheet
    {
        b.SetProperty(b.Props, "onwillPresent", action);
    }

    /// <summary>
    /// Emitted before the action sheet has presented. Shorthand for ionActionSheetWillPresent.
    /// </summary>
    public static void OnWillPresent<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonActionSheet
    {
        b.OnWillPresent(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted before the action sheet has presented. Shorthand for ionActionSheetWillPresent.
    /// </summary>
    public static void OnWillPresent<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonActionSheet
    {
        b.SetProperty(b.Props, "onwillPresent", action);
    }

    /// <summary>
    /// Emitted before the action sheet has presented. Shorthand for ionActionSheetWillPresent.
    /// </summary>
    public static void OnWillPresent<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonActionSheet
    {
        b.OnWillPresent(b.MakeAction(action));
    }

}