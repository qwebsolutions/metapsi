using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Ionic;


public partial class IonActionSheet
{
    public static class Method
    {
        /// <summary>
        /// <para> Dismiss the action sheet overlay after it has been presented. </para>
        /// <para> (data?: any, role?: string) =&gt; Promise&lt;boolean&gt; </para>
        /// <para> data Any data to emit in the dismiss events. </para>
        /// <para> role The role of the element that is dismissing the action sheet. This can be useful in a button handler for determining which button was clicked to dismiss the action sheet. Some examples include: ``"cancel"`, `"destructive"`, "selected"`, and `"backdrop"`.  This is a no-op if the overlay has not been presented yet. If you want to remove an overlay from the DOM that was never presented, use the [remove](https://developer.mozilla.org/en-US/docs/Web/API/Element/remove) method. </para>
        /// </summary>
        public const string Dismiss = "dismiss";
        /// <summary>
        /// <para> Returns a promise that resolves when the action sheet did dismiss. </para>
        /// <para> &lt;T = any&gt;() =&gt; Promise&lt;OverlayEventDetail&lt;T&gt;&gt; </para>
        /// </summary>
        public const string OnDidDismiss = "onDidDismiss";
        /// <summary>
        /// <para> Returns a promise that resolves when the action sheet will dismiss. </para>
        /// <para> &lt;T = any&gt;() =&gt; Promise&lt;OverlayEventDetail&lt;T&gt;&gt; </para>
        /// </summary>
        public const string OnWillDismiss = "onWillDismiss";
        /// <summary>
        /// <para> Present the action sheet overlay after it has been created. </para>
        /// <para> () =&gt; Promise&lt;void&gt; </para>
        /// </summary>
        public const string Present = "present";
    }
}

public static partial class IonActionSheetControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonActionSheet(this HtmlBuilder b, Action<AttributesBuilder<IonActionSheet>> buildAttributes, params IHtmlNode[] children)
    {
        return b.IonicTag("ion-action-sheet", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonActionSheet(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.IonicTag("ion-action-sheet", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonActionSheet(this HtmlBuilder b, Action<AttributesBuilder<IonActionSheet>> buildAttributes, List<IHtmlNode> children)
    {
        return b.IonicTag("ion-action-sheet", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonActionSheet(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.IonicTag("ion-action-sheet", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> If `true`, the action sheet will animate. </para>
    /// </summary>
    public static void SetAnimated(this AttributesBuilder<IonActionSheet> b)
    {
        b.SetAttribute("animated", "");
    }

    /// <summary>
    /// <para> If `true`, the action sheet will animate. </para>
    /// </summary>
    public static void SetAnimated(this AttributesBuilder<IonActionSheet> b, bool animated)
    {
        if (animated) b.SetAttribute("animated", "");
    }

    /// <summary>
    /// <para> If `true`, the action sheet will be dismissed when the backdrop is clicked. </para>
    /// </summary>
    public static void SetBackdropDismiss(this AttributesBuilder<IonActionSheet> b)
    {
        b.SetAttribute("backdrop-dismiss", "");
    }

    /// <summary>
    /// <para> If `true`, the action sheet will be dismissed when the backdrop is clicked. </para>
    /// </summary>
    public static void SetBackdropDismiss(this AttributesBuilder<IonActionSheet> b, bool backdropDismiss)
    {
        if (backdropDismiss) b.SetAttribute("backdrop-dismiss", "");
    }

    /// <summary>
    /// <para> Additional classes to apply for custom CSS. If multiple classes are provided they should be separated by spaces. </para>
    /// </summary>
    public static void SetCssClass(this AttributesBuilder<IonActionSheet> b, string cssClass)
    {
        b.SetAttribute("css-class", cssClass);
    }

    /// <summary>
    /// <para> Title for the action sheet. </para>
    /// </summary>
    public static void SetHeader(this AttributesBuilder<IonActionSheet> b, string header)
    {
        b.SetAttribute("header", header);
    }

    /// <summary>
    /// <para> If `true`, the action sheet will open. If `false`, the action sheet will close. Use this if you need finer grained control over presentation, otherwise just use the actionSheetController or the `trigger` property. Note: `isOpen` will not automatically be set back to `false` when the action sheet dismisses. You will need to do that in your code. </para>
    /// </summary>
    public static void SetIsOpen(this AttributesBuilder<IonActionSheet> b)
    {
        b.SetAttribute("is-open", "");
    }

    /// <summary>
    /// <para> If `true`, the action sheet will open. If `false`, the action sheet will close. Use this if you need finer grained control over presentation, otherwise just use the actionSheetController or the `trigger` property. Note: `isOpen` will not automatically be set back to `false` when the action sheet dismisses. You will need to do that in your code. </para>
    /// </summary>
    public static void SetIsOpen(this AttributesBuilder<IonActionSheet> b, bool isOpen)
    {
        if (isOpen) b.SetAttribute("is-open", "");
    }

    /// <summary>
    /// <para> If `true`, the keyboard will be automatically dismissed when the overlay is presented. </para>
    /// </summary>
    public static void SetKeyboardClose(this AttributesBuilder<IonActionSheet> b)
    {
        b.SetAttribute("keyboard-close", "");
    }

    /// <summary>
    /// <para> If `true`, the keyboard will be automatically dismissed when the overlay is presented. </para>
    /// </summary>
    public static void SetKeyboardClose(this AttributesBuilder<IonActionSheet> b, bool keyboardClose)
    {
        if (keyboardClose) b.SetAttribute("keyboard-close", "");
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetMode(this AttributesBuilder<IonActionSheet> b, string mode)
    {
        b.SetAttribute("mode", mode);
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeIos(this AttributesBuilder<IonActionSheet> b)
    {
        b.SetAttribute("mode", "ios");
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeMd(this AttributesBuilder<IonActionSheet> b)
    {
        b.SetAttribute("mode", "md");
    }

    /// <summary>
    /// <para> Subtitle for the action sheet. </para>
    /// </summary>
    public static void SetSubHeader(this AttributesBuilder<IonActionSheet> b, string subHeader)
    {
        b.SetAttribute("sub-header", subHeader);
    }

    /// <summary>
    /// <para> If `true`, the action sheet will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility). </para>
    /// </summary>
    public static void SetTranslucent(this AttributesBuilder<IonActionSheet> b)
    {
        b.SetAttribute("translucent", "");
    }

    /// <summary>
    /// <para> If `true`, the action sheet will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility). </para>
    /// </summary>
    public static void SetTranslucent(this AttributesBuilder<IonActionSheet> b, bool translucent)
    {
        if (translucent) b.SetAttribute("translucent", "");
    }

    /// <summary>
    /// <para> An ID corresponding to the trigger element that causes the action sheet to open when clicked. </para>
    /// </summary>
    public static void SetTrigger(this AttributesBuilder<IonActionSheet> b, string trigger)
    {
        b.SetAttribute("trigger", trigger);
    }

    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonActionSheet(this LayoutBuilder b, Action<PropsBuilder<IonActionSheet>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-action-sheet", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonActionSheet(this LayoutBuilder b, Action<PropsBuilder<IonActionSheet>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-action-sheet", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonActionSheet(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-action-sheet", children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonActionSheet(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-action-sheet", children);
    }
    /// <summary>
    /// <para> If `true`, the action sheet will animate. </para>
    /// </summary>
    public static void SetAnimated<T>(this PropsBuilder<T> b) where T: IonActionSheet
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("animated"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, the action sheet will animate. </para>
    /// </summary>
    public static void SetAnimated<T>(this PropsBuilder<T> b, Var<bool> animated) where T: IonActionSheet
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("animated"), animated);
    }

    /// <summary>
    /// <para> If `true`, the action sheet will animate. </para>
    /// </summary>
    public static void SetAnimated<T>(this PropsBuilder<T> b, bool animated) where T: IonActionSheet
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("animated"), b.Const(animated));
    }


    /// <summary>
    /// <para> If `true`, the action sheet will be dismissed when the backdrop is clicked. </para>
    /// </summary>
    public static void SetBackdropDismiss<T>(this PropsBuilder<T> b) where T: IonActionSheet
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("backdropDismiss"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, the action sheet will be dismissed when the backdrop is clicked. </para>
    /// </summary>
    public static void SetBackdropDismiss<T>(this PropsBuilder<T> b, Var<bool> backdropDismiss) where T: IonActionSheet
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("backdropDismiss"), backdropDismiss);
    }

    /// <summary>
    /// <para> If `true`, the action sheet will be dismissed when the backdrop is clicked. </para>
    /// </summary>
    public static void SetBackdropDismiss<T>(this PropsBuilder<T> b, bool backdropDismiss) where T: IonActionSheet
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("backdropDismiss"), b.Const(backdropDismiss));
    }


    /// <summary>
    /// <para> An array of buttons for the action sheet. </para>
    /// </summary>
    public static void SetButtons<T>(this PropsBuilder<T> b, Var<List<string>> buttons) where T: IonActionSheet
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<string>>("buttons"), buttons);
    }

    /// <summary>
    /// <para> An array of buttons for the action sheet. </para>
    /// </summary>
    public static void SetButtons<T>(this PropsBuilder<T> b, List<string> buttons) where T: IonActionSheet
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<string>>("buttons"), b.Const(buttons));
    }


    /// <summary>
    /// <para> An array of buttons for the action sheet. </para>
    /// </summary>
    public static void SetButtons<T>(this PropsBuilder<T> b, Var<List<ActionSheetButton>> buttons) where T: IonActionSheet
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<ActionSheetButton>>("buttons"), buttons);
    }

    /// <summary>
    /// <para> An array of buttons for the action sheet. </para>
    /// </summary>
    public static void SetButtons<T>(this PropsBuilder<T> b, List<ActionSheetButton> buttons) where T: IonActionSheet
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<ActionSheetButton>>("buttons"), b.Const(buttons));
    }


    /// <summary>
    /// <para> Additional classes to apply for custom CSS. If multiple classes are provided they should be separated by spaces. </para>
    /// </summary>
    public static void SetCssClass<T>(this PropsBuilder<T> b, Var<string> cssClass) where T: IonActionSheet
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("cssClass"), cssClass);
    }

    /// <summary>
    /// <para> Additional classes to apply for custom CSS. If multiple classes are provided they should be separated by spaces. </para>
    /// </summary>
    public static void SetCssClass<T>(this PropsBuilder<T> b, string cssClass) where T: IonActionSheet
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("cssClass"), b.Const(cssClass));
    }


    /// <summary>
    /// <para> Additional classes to apply for custom CSS. If multiple classes are provided they should be separated by spaces. </para>
    /// </summary>
    public static void SetCssClass<T>(this PropsBuilder<T> b, Var<List<string>> cssClass) where T: IonActionSheet
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<string>>("cssClass"), cssClass);
    }

    /// <summary>
    /// <para> Additional classes to apply for custom CSS. If multiple classes are provided they should be separated by spaces. </para>
    /// </summary>
    public static void SetCssClass<T>(this PropsBuilder<T> b, List<string> cssClass) where T: IonActionSheet
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<string>>("cssClass"), b.Const(cssClass));
    }


    /// <summary>
    /// <para> Animation to use when the action sheet is presented. </para>
    /// </summary>
    public static void SetEnterAnimation<T>(this PropsBuilder<T> b, Var<System.Func<object,object,Animation>> enterAnimation) where T: IonActionSheet
    {
        b.SetDynamic(b.Props, new DynamicProperty<System.Func<object,object,Animation>>("enterAnimation"), enterAnimation);
    }

    /// <summary>
    /// <para> Animation to use when the action sheet is presented. </para>
    /// </summary>
    public static void SetEnterAnimation<T>(this PropsBuilder<T> b, System.Func<object,object,Animation> enterAnimation) where T: IonActionSheet
    {
        b.SetDynamic(b.Props, new DynamicProperty<System.Func<object,object,Animation>>("enterAnimation"), b.Const(enterAnimation));
    }


    /// <summary>
    /// <para> Title for the action sheet. </para>
    /// </summary>
    public static void SetHeader<T>(this PropsBuilder<T> b, Var<string> header) where T: IonActionSheet
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("header"), header);
    }

    /// <summary>
    /// <para> Title for the action sheet. </para>
    /// </summary>
    public static void SetHeader<T>(this PropsBuilder<T> b, string header) where T: IonActionSheet
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("header"), b.Const(header));
    }


    /// <summary>
    /// <para> Additional attributes to pass to the action sheet. </para>
    /// </summary>
    public static void SetHtmlAttributes<T>(this PropsBuilder<T> b, Var<DynamicObject> htmlAttributes) where T: IonActionSheet
    {
        b.SetDynamic(b.Props, new DynamicProperty<DynamicObject>("htmlAttributes"), htmlAttributes);
    }

    /// <summary>
    /// <para> Additional attributes to pass to the action sheet. </para>
    /// </summary>
    public static void SetHtmlAttributes<T>(this PropsBuilder<T> b, DynamicObject htmlAttributes) where T: IonActionSheet
    {
        b.SetDynamic(b.Props, new DynamicProperty<DynamicObject>("htmlAttributes"), b.Const(htmlAttributes));
    }


    /// <summary>
    /// <para> If `true`, the action sheet will open. If `false`, the action sheet will close. Use this if you need finer grained control over presentation, otherwise just use the actionSheetController or the `trigger` property. Note: `isOpen` will not automatically be set back to `false` when the action sheet dismisses. You will need to do that in your code. </para>
    /// </summary>
    public static void SetIsOpen<T>(this PropsBuilder<T> b) where T: IonActionSheet
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("isOpen"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, the action sheet will open. If `false`, the action sheet will close. Use this if you need finer grained control over presentation, otherwise just use the actionSheetController or the `trigger` property. Note: `isOpen` will not automatically be set back to `false` when the action sheet dismisses. You will need to do that in your code. </para>
    /// </summary>
    public static void SetIsOpen<T>(this PropsBuilder<T> b, Var<bool> isOpen) where T: IonActionSheet
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("isOpen"), isOpen);
    }

    /// <summary>
    /// <para> If `true`, the action sheet will open. If `false`, the action sheet will close. Use this if you need finer grained control over presentation, otherwise just use the actionSheetController or the `trigger` property. Note: `isOpen` will not automatically be set back to `false` when the action sheet dismisses. You will need to do that in your code. </para>
    /// </summary>
    public static void SetIsOpen<T>(this PropsBuilder<T> b, bool isOpen) where T: IonActionSheet
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("isOpen"), b.Const(isOpen));
    }


    /// <summary>
    /// <para> If `true`, the keyboard will be automatically dismissed when the overlay is presented. </para>
    /// </summary>
    public static void SetKeyboardClose<T>(this PropsBuilder<T> b) where T: IonActionSheet
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("keyboardClose"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, the keyboard will be automatically dismissed when the overlay is presented. </para>
    /// </summary>
    public static void SetKeyboardClose<T>(this PropsBuilder<T> b, Var<bool> keyboardClose) where T: IonActionSheet
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("keyboardClose"), keyboardClose);
    }

    /// <summary>
    /// <para> If `true`, the keyboard will be automatically dismissed when the overlay is presented. </para>
    /// </summary>
    public static void SetKeyboardClose<T>(this PropsBuilder<T> b, bool keyboardClose) where T: IonActionSheet
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("keyboardClose"), b.Const(keyboardClose));
    }


    /// <summary>
    /// <para> Animation to use when the action sheet is dismissed. </para>
    /// </summary>
    public static void SetLeaveAnimation<T>(this PropsBuilder<T> b, Var<System.Func<object,object,Animation>> leaveAnimation) where T: IonActionSheet
    {
        b.SetDynamic(b.Props, new DynamicProperty<System.Func<object,object,Animation>>("leaveAnimation"), leaveAnimation);
    }

    /// <summary>
    /// <para> Animation to use when the action sheet is dismissed. </para>
    /// </summary>
    public static void SetLeaveAnimation<T>(this PropsBuilder<T> b, System.Func<object,object,Animation> leaveAnimation) where T: IonActionSheet
    {
        b.SetDynamic(b.Props, new DynamicProperty<System.Func<object,object,Animation>>("leaveAnimation"), b.Const(leaveAnimation));
    }


    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeIos<T>(this PropsBuilder<T> b) where T: IonActionSheet
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("mode"), b.Const("ios"));
    }


    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeMd<T>(this PropsBuilder<T> b) where T: IonActionSheet
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("mode"), b.Const("md"));
    }


    /// <summary>
    /// <para> Subtitle for the action sheet. </para>
    /// </summary>
    public static void SetSubHeader<T>(this PropsBuilder<T> b, Var<string> subHeader) where T: IonActionSheet
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("subHeader"), subHeader);
    }

    /// <summary>
    /// <para> Subtitle for the action sheet. </para>
    /// </summary>
    public static void SetSubHeader<T>(this PropsBuilder<T> b, string subHeader) where T: IonActionSheet
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("subHeader"), b.Const(subHeader));
    }


    /// <summary>
    /// <para> If `true`, the action sheet will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility). </para>
    /// </summary>
    public static void SetTranslucent<T>(this PropsBuilder<T> b) where T: IonActionSheet
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("translucent"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, the action sheet will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility). </para>
    /// </summary>
    public static void SetTranslucent<T>(this PropsBuilder<T> b, Var<bool> translucent) where T: IonActionSheet
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("translucent"), translucent);
    }

    /// <summary>
    /// <para> If `true`, the action sheet will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility). </para>
    /// </summary>
    public static void SetTranslucent<T>(this PropsBuilder<T> b, bool translucent) where T: IonActionSheet
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("translucent"), b.Const(translucent));
    }


    /// <summary>
    /// <para> An ID corresponding to the trigger element that causes the action sheet to open when clicked. </para>
    /// </summary>
    public static void SetTrigger<T>(this PropsBuilder<T> b, Var<string> trigger) where T: IonActionSheet
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("trigger"), trigger);
    }

    /// <summary>
    /// <para> An ID corresponding to the trigger element that causes the action sheet to open when clicked. </para>
    /// </summary>
    public static void SetTrigger<T>(this PropsBuilder<T> b, string trigger) where T: IonActionSheet
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("trigger"), b.Const(trigger));
    }


    /// <summary>
    /// <para> Emitted after the action sheet has dismissed. Shorthand for ionActionSheetDidDismiss. </para>
    /// </summary>
    public static void OnDidDismiss<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, OverlayEventDetail>> action) where TComponent: IonActionSheet
    {
        b.OnEventAction("ondidDismiss", action, "detail");
    }
    /// <summary>
    /// <para> Emitted after the action sheet has dismissed. Shorthand for ionActionSheetDidDismiss. </para>
    /// </summary>
    public static void OnDidDismiss<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<OverlayEventDetail>, Var<TModel>> action) where TComponent: IonActionSheet
    {
        b.OnEventAction("ondidDismiss", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// <para> Emitted after the action sheet has presented. Shorthand for ionActionSheetWillDismiss. </para>
    /// </summary>
    public static void OnDidPresent<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonActionSheet
    {
        b.OnEventAction("ondidPresent", action);
    }
    /// <summary>
    /// <para> Emitted after the action sheet has presented. Shorthand for ionActionSheetWillDismiss. </para>
    /// </summary>
    public static void OnDidPresent<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonActionSheet
    {
        b.OnEventAction("ondidPresent", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted after the action sheet has dismissed. </para>
    /// </summary>
    public static void OnIonActionSheetDidDismiss<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, OverlayEventDetail>> action) where TComponent: IonActionSheet
    {
        b.OnEventAction("onionActionSheetDidDismiss", action, "detail");
    }
    /// <summary>
    /// <para> Emitted after the action sheet has dismissed. </para>
    /// </summary>
    public static void OnIonActionSheetDidDismiss<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<OverlayEventDetail>, Var<TModel>> action) where TComponent: IonActionSheet
    {
        b.OnEventAction("onionActionSheetDidDismiss", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// <para> Emitted after the action sheet has presented. </para>
    /// </summary>
    public static void OnIonActionSheetDidPresent<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonActionSheet
    {
        b.OnEventAction("onionActionSheetDidPresent", action);
    }
    /// <summary>
    /// <para> Emitted after the action sheet has presented. </para>
    /// </summary>
    public static void OnIonActionSheetDidPresent<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonActionSheet
    {
        b.OnEventAction("onionActionSheetDidPresent", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted before the action sheet has dismissed. </para>
    /// </summary>
    public static void OnIonActionSheetWillDismiss<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, OverlayEventDetail>> action) where TComponent: IonActionSheet
    {
        b.OnEventAction("onionActionSheetWillDismiss", action, "detail");
    }
    /// <summary>
    /// <para> Emitted before the action sheet has dismissed. </para>
    /// </summary>
    public static void OnIonActionSheetWillDismiss<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<OverlayEventDetail>, Var<TModel>> action) where TComponent: IonActionSheet
    {
        b.OnEventAction("onionActionSheetWillDismiss", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// <para> Emitted before the action sheet has presented. </para>
    /// </summary>
    public static void OnIonActionSheetWillPresent<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonActionSheet
    {
        b.OnEventAction("onionActionSheetWillPresent", action);
    }
    /// <summary>
    /// <para> Emitted before the action sheet has presented. </para>
    /// </summary>
    public static void OnIonActionSheetWillPresent<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonActionSheet
    {
        b.OnEventAction("onionActionSheetWillPresent", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted before the action sheet has dismissed. Shorthand for ionActionSheetWillDismiss. </para>
    /// </summary>
    public static void OnWillDismiss<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, OverlayEventDetail>> action) where TComponent: IonActionSheet
    {
        b.OnEventAction("onwillDismiss", action, "detail");
    }
    /// <summary>
    /// <para> Emitted before the action sheet has dismissed. Shorthand for ionActionSheetWillDismiss. </para>
    /// </summary>
    public static void OnWillDismiss<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<OverlayEventDetail>, Var<TModel>> action) where TComponent: IonActionSheet
    {
        b.OnEventAction("onwillDismiss", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// <para> Emitted before the action sheet has presented. Shorthand for ionActionSheetWillPresent. </para>
    /// </summary>
    public static void OnWillPresent<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonActionSheet
    {
        b.OnEventAction("onwillPresent", action);
    }
    /// <summary>
    /// <para> Emitted before the action sheet has presented. Shorthand for ionActionSheetWillPresent. </para>
    /// </summary>
    public static void OnWillPresent<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonActionSheet
    {
        b.OnEventAction("onwillPresent", b.MakeAction(action));
    }

}

