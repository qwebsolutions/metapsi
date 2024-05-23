using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Ionic;


public partial class IonActionSheet : IonComponent
{
    public IonActionSheet() : base("ion-action-sheet") { }
    public static class Method
    {
        /// <summary> 
        /// Dismiss the action sheet overlay after it has been presented.
        /// <para>(data?: any, role?: string) =&gt; Promise&lt;boolean&gt;</para>
        /// <para>data Any data to emit in the dismiss events.</para>
        /// <para>role The role of the element that is dismissing the action sheet. This can be useful in a button handler for determining which button was clicked to dismiss the action sheet. Some examples include: ``"cancel"`, `"destructive"`, "selected"`, and `"backdrop"`.  This is a no-op if the overlay has not been presented yet. If you want to remove an overlay from the DOM that was never presented, use the [remove](https://developer.mozilla.org/en-US/docs/Web/API/Element/remove) method.</para>
        /// </summary>
        public const string Dismiss = "dismiss";
        /// <summary> 
        /// Returns a promise that resolves when the action sheet did dismiss.
        /// <para>&lt;T = any&gt;() =&gt; Promise&lt;OverlayEventDetail&lt;T&gt;&gt;</para>
        /// </summary>
        public const string OnDidDismiss = "onDidDismiss";
        /// <summary> 
        /// Returns a promise that resolves when the action sheet will dismiss.
        /// <para>&lt;T = any&gt;() =&gt; Promise&lt;OverlayEventDetail&lt;T&gt;&gt;</para>
        /// </summary>
        public const string OnWillDismiss = "onWillDismiss";
        /// <summary> 
        /// Present the action sheet overlay after it has been created.
        /// <para>() =&gt; Promise&lt;void&gt;</para>
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
        return b.Tag("ion-action-sheet", buildAttributes, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static IHtmlNode IonActionSheet(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("ion-action-sheet", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// If `true`, the action sheet will animate.
    /// </summary>
    public static void SetAnimated(this AttributesBuilder<IonActionSheet> b)
    {
        b.SetAttribute("animated", "");
    }
    /// <summary>
    /// If `true`, the action sheet will animate.
    /// </summary>
    public static void SetAnimated(this AttributesBuilder<IonActionSheet> b, bool value)
    {
        if (value) b.SetAttribute("animated", "");
    }

    /// <summary>
    /// If `true`, the action sheet will be dismissed when the backdrop is clicked.
    /// </summary>
    public static void SetBackdropDismiss(this AttributesBuilder<IonActionSheet> b)
    {
        b.SetAttribute("backdrop-dismiss", "");
    }
    /// <summary>
    /// If `true`, the action sheet will be dismissed when the backdrop is clicked.
    /// </summary>
    public static void SetBackdropDismiss(this AttributesBuilder<IonActionSheet> b, bool value)
    {
        if (value) b.SetAttribute("backdrop-dismiss", "");
    }

    /// <summary>
    /// Additional classes to apply for custom CSS. If multiple classes are provided they should be separated by spaces.
    /// </summary>
    public static void SetCssClass(this AttributesBuilder<IonActionSheet> b, string value)
    {
        b.SetAttribute("css-class", value);
    }

    /// <summary>
    /// Title for the action sheet.
    /// </summary>
    public static void SetHeader(this AttributesBuilder<IonActionSheet> b, string value)
    {
        b.SetAttribute("header", value);
    }

    /// <summary>
    /// If `true`, the action sheet will open. If `false`, the action sheet will close. Use this if you need finer grained control over presentation, otherwise just use the actionSheetController or the `trigger` property. Note: `isOpen` will not automatically be set back to `false` when the action sheet dismisses. You will need to do that in your code.
    /// </summary>
    public static void SetIsOpen(this AttributesBuilder<IonActionSheet> b)
    {
        b.SetAttribute("is-open", "");
    }
    /// <summary>
    /// If `true`, the action sheet will open. If `false`, the action sheet will close. Use this if you need finer grained control over presentation, otherwise just use the actionSheetController or the `trigger` property. Note: `isOpen` will not automatically be set back to `false` when the action sheet dismisses. You will need to do that in your code.
    /// </summary>
    public static void SetIsOpen(this AttributesBuilder<IonActionSheet> b, bool value)
    {
        if (value) b.SetAttribute("is-open", "");
    }

    /// <summary>
    /// If `true`, the keyboard will be automatically dismissed when the overlay is presented.
    /// </summary>
    public static void SetKeyboardClose(this AttributesBuilder<IonActionSheet> b)
    {
        b.SetAttribute("keyboard-close", "");
    }
    /// <summary>
    /// If `true`, the keyboard will be automatically dismissed when the overlay is presented.
    /// </summary>
    public static void SetKeyboardClose(this AttributesBuilder<IonActionSheet> b, bool value)
    {
        if (value) b.SetAttribute("keyboard-close", "");
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetMode(this AttributesBuilder<IonActionSheet> b, string value)
    {
        b.SetAttribute("mode", value);
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos(this AttributesBuilder<IonActionSheet> b)
    {
        b.SetAttribute("mode", "ios");
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd(this AttributesBuilder<IonActionSheet> b)
    {
        b.SetAttribute("mode", "md");
    }

    /// <summary>
    /// Subtitle for the action sheet.
    /// </summary>
    public static void SetSubHeader(this AttributesBuilder<IonActionSheet> b, string value)
    {
        b.SetAttribute("sub-header", value);
    }

    /// <summary>
    /// If `true`, the action sheet will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility).
    /// </summary>
    public static void SetTranslucent(this AttributesBuilder<IonActionSheet> b)
    {
        b.SetAttribute("translucent", "");
    }
    /// <summary>
    /// If `true`, the action sheet will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility).
    /// </summary>
    public static void SetTranslucent(this AttributesBuilder<IonActionSheet> b, bool value)
    {
        if (value) b.SetAttribute("translucent", "");
    }

    /// <summary>
    /// An ID corresponding to the trigger element that causes the action sheet to open when clicked.
    /// </summary>
    public static void SetTrigger(this AttributesBuilder<IonActionSheet> b, string value)
    {
        b.SetAttribute("trigger", value);
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
    /// If `true`, the action sheet will animate.
    /// </summary>
    public static void SetAnimated<T>(this PropsBuilder<T> b) where T: IonActionSheet
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("animated"), b.Const(true));
    }
    /// <summary>
    /// If `true`, the action sheet will animate.
    /// </summary>
    public static void SetAnimated<T>(this PropsBuilder<T> b, Var<bool> value) where T: IonActionSheet
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("animated"), value);
    }
    /// <summary>
    /// If `true`, the action sheet will animate.
    /// </summary>
    public static void SetAnimated<T>(this PropsBuilder<T> b, bool value) where T: IonActionSheet
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("animated"), b.Const(value));
    }

    /// <summary>
    /// If `true`, the action sheet will be dismissed when the backdrop is clicked.
    /// </summary>
    public static void SetBackdropDismiss<T>(this PropsBuilder<T> b) where T: IonActionSheet
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("backdropDismiss"), b.Const(true));
    }
    /// <summary>
    /// If `true`, the action sheet will be dismissed when the backdrop is clicked.
    /// </summary>
    public static void SetBackdropDismiss<T>(this PropsBuilder<T> b, Var<bool> value) where T: IonActionSheet
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("backdropDismiss"), value);
    }
    /// <summary>
    /// If `true`, the action sheet will be dismissed when the backdrop is clicked.
    /// </summary>
    public static void SetBackdropDismiss<T>(this PropsBuilder<T> b, bool value) where T: IonActionSheet
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("backdropDismiss"), b.Const(value));
    }

    /// <summary>
    /// An array of buttons for the action sheet.
    /// </summary>
    public static void SetButtons<T>(this PropsBuilder<T> b, Var<List<string>> value) where T: IonActionSheet
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<string>>("buttons"), value);
    }
    /// <summary>
    /// An array of buttons for the action sheet.
    /// </summary>
    public static void SetButtons<T>(this PropsBuilder<T> b, List<string> value) where T: IonActionSheet
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<string>>("buttons"), b.Const(value));
    }
    /// <summary>
    /// An array of buttons for the action sheet.
    /// </summary>
    public static void SetButtons<T>(this PropsBuilder<T> b, Var<List<ActionSheetButton>> value) where T: IonActionSheet
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<ActionSheetButton>>("buttons"), value);
    }
    /// <summary>
    /// An array of buttons for the action sheet.
    /// </summary>
    public static void SetButtons<T>(this PropsBuilder<T> b, List<ActionSheetButton> value) where T: IonActionSheet
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<ActionSheetButton>>("buttons"), b.Const(value));
    }

    /// <summary>
    /// Additional classes to apply for custom CSS. If multiple classes are provided they should be separated by spaces.
    /// </summary>
    public static void SetCssClass<T>(this PropsBuilder<T> b, Var<string> value) where T: IonActionSheet
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("cssClass"), value);
    }
    /// <summary>
    /// Additional classes to apply for custom CSS. If multiple classes are provided they should be separated by spaces.
    /// </summary>
    public static void SetCssClass<T>(this PropsBuilder<T> b, string value) where T: IonActionSheet
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("cssClass"), b.Const(value));
    }
    /// <summary>
    /// Additional classes to apply for custom CSS. If multiple classes are provided they should be separated by spaces.
    /// </summary>
    public static void SetCssClass<T>(this PropsBuilder<T> b, Var<List<string>> value) where T: IonActionSheet
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<string>>("cssClass"), value);
    }
    /// <summary>
    /// Additional classes to apply for custom CSS. If multiple classes are provided they should be separated by spaces.
    /// </summary>
    public static void SetCssClass<T>(this PropsBuilder<T> b, List<string> value) where T: IonActionSheet
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<string>>("cssClass"), b.Const(value));
    }

    /// <summary>
    /// Animation to use when the action sheet is presented.
    /// </summary>
    public static void SetEnterAnimation<T>(this PropsBuilder<T> b, Var<Func<object,object,Animation>> f) where T: IonActionSheet
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<object,object,Animation>>("enterAnimation"), f);
    }
    /// <summary>
    /// Animation to use when the action sheet is presented.
    /// </summary>
    public static void SetEnterAnimation<T>(this PropsBuilder<T> b, Func<SyntaxBuilder,Var<object>,Var<object>,Var<Animation>> f) where T: IonActionSheet
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<object,object,Animation>>("enterAnimation"), b.Def(f));
    }

    /// <summary>
    /// Title for the action sheet.
    /// </summary>
    public static void SetHeader<T>(this PropsBuilder<T> b, Var<string> value) where T: IonActionSheet
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("header"), value);
    }
    /// <summary>
    /// Title for the action sheet.
    /// </summary>
    public static void SetHeader<T>(this PropsBuilder<T> b, string value) where T: IonActionSheet
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("header"), b.Const(value));
    }

    /// <summary>
    /// Additional attributes to pass to the action sheet.
    /// </summary>
    public static void SetHtmlAttributes<T>(this PropsBuilder<T> b, Var<DynamicObject> value) where T: IonActionSheet
    {
        b.SetDynamic(b.Props, new DynamicProperty<DynamicObject>("htmlAttributes"), value);
    }
    /// <summary>
    /// Additional attributes to pass to the action sheet.
    /// </summary>
    public static void SetHtmlAttributes<T>(this PropsBuilder<T> b, DynamicObject value) where T: IonActionSheet
    {
        b.SetDynamic(b.Props, new DynamicProperty<DynamicObject>("htmlAttributes"), b.Const(value));
    }

    /// <summary>
    /// If `true`, the action sheet will open. If `false`, the action sheet will close. Use this if you need finer grained control over presentation, otherwise just use the actionSheetController or the `trigger` property. Note: `isOpen` will not automatically be set back to `false` when the action sheet dismisses. You will need to do that in your code.
    /// </summary>
    public static void SetIsOpen<T>(this PropsBuilder<T> b) where T: IonActionSheet
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("isOpen"), b.Const(true));
    }
    /// <summary>
    /// If `true`, the action sheet will open. If `false`, the action sheet will close. Use this if you need finer grained control over presentation, otherwise just use the actionSheetController or the `trigger` property. Note: `isOpen` will not automatically be set back to `false` when the action sheet dismisses. You will need to do that in your code.
    /// </summary>
    public static void SetIsOpen<T>(this PropsBuilder<T> b, Var<bool> value) where T: IonActionSheet
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("isOpen"), value);
    }
    /// <summary>
    /// If `true`, the action sheet will open. If `false`, the action sheet will close. Use this if you need finer grained control over presentation, otherwise just use the actionSheetController or the `trigger` property. Note: `isOpen` will not automatically be set back to `false` when the action sheet dismisses. You will need to do that in your code.
    /// </summary>
    public static void SetIsOpen<T>(this PropsBuilder<T> b, bool value) where T: IonActionSheet
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("isOpen"), b.Const(value));
    }

    /// <summary>
    /// If `true`, the keyboard will be automatically dismissed when the overlay is presented.
    /// </summary>
    public static void SetKeyboardClose<T>(this PropsBuilder<T> b) where T: IonActionSheet
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("keyboardClose"), b.Const(true));
    }
    /// <summary>
    /// If `true`, the keyboard will be automatically dismissed when the overlay is presented.
    /// </summary>
    public static void SetKeyboardClose<T>(this PropsBuilder<T> b, Var<bool> value) where T: IonActionSheet
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("keyboardClose"), value);
    }
    /// <summary>
    /// If `true`, the keyboard will be automatically dismissed when the overlay is presented.
    /// </summary>
    public static void SetKeyboardClose<T>(this PropsBuilder<T> b, bool value) where T: IonActionSheet
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("keyboardClose"), b.Const(value));
    }

    /// <summary>
    /// Animation to use when the action sheet is dismissed.
    /// </summary>
    public static void SetLeaveAnimation<T>(this PropsBuilder<T> b, Var<Func<object,object,Animation>> f) where T: IonActionSheet
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<object,object,Animation>>("leaveAnimation"), f);
    }
    /// <summary>
    /// Animation to use when the action sheet is dismissed.
    /// </summary>
    public static void SetLeaveAnimation<T>(this PropsBuilder<T> b, Func<SyntaxBuilder,Var<object>,Var<object>,Var<Animation>> f) where T: IonActionSheet
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<object,object,Animation>>("leaveAnimation"), b.Def(f));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos<T>(this PropsBuilder<T> b) where T: IonActionSheet
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("ios"));
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd<T>(this PropsBuilder<T> b) where T: IonActionSheet
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("md"));
    }

    /// <summary>
    /// Subtitle for the action sheet.
    /// </summary>
    public static void SetSubHeader<T>(this PropsBuilder<T> b, Var<string> value) where T: IonActionSheet
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("subHeader"), value);
    }
    /// <summary>
    /// Subtitle for the action sheet.
    /// </summary>
    public static void SetSubHeader<T>(this PropsBuilder<T> b, string value) where T: IonActionSheet
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("subHeader"), b.Const(value));
    }

    /// <summary>
    /// If `true`, the action sheet will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility).
    /// </summary>
    public static void SetTranslucent<T>(this PropsBuilder<T> b) where T: IonActionSheet
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("translucent"), b.Const(true));
    }
    /// <summary>
    /// If `true`, the action sheet will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility).
    /// </summary>
    public static void SetTranslucent<T>(this PropsBuilder<T> b, Var<bool> value) where T: IonActionSheet
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("translucent"), value);
    }
    /// <summary>
    /// If `true`, the action sheet will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility).
    /// </summary>
    public static void SetTranslucent<T>(this PropsBuilder<T> b, bool value) where T: IonActionSheet
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("translucent"), b.Const(value));
    }

    /// <summary>
    /// An ID corresponding to the trigger element that causes the action sheet to open when clicked.
    /// </summary>
    public static void SetTrigger<T>(this PropsBuilder<T> b, Var<string> value) where T: IonActionSheet
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("trigger"), value);
    }
    /// <summary>
    /// An ID corresponding to the trigger element that causes the action sheet to open when clicked.
    /// </summary>
    public static void SetTrigger<T>(this PropsBuilder<T> b, string value) where T: IonActionSheet
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("trigger"), b.Const(value));
    }

    /// <summary>
    /// Emitted after the action sheet has dismissed. Shorthand for ionActionSheetDidDismiss.
    /// </summary>
    public static void OnDidDismiss<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, OverlayEventDetail>> action) where TComponent: IonActionSheet
    {
        b.OnEventAction("ondidDismiss", action, "detail");
    }
    /// <summary>
    /// Emitted after the action sheet has dismissed. Shorthand for ionActionSheetDidDismiss.
    /// </summary>
    public static void OnDidDismiss<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<OverlayEventDetail>, Var<TModel>> action) where TComponent: IonActionSheet
    {
        b.OnEventAction("ondidDismiss", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// Emitted after the action sheet has presented. Shorthand for ionActionSheetWillDismiss.
    /// </summary>
    public static void OnDidPresent<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonActionSheet
    {
        b.OnEventAction("ondidPresent", action);
    }
    /// <summary>
    /// Emitted after the action sheet has presented. Shorthand for ionActionSheetWillDismiss.
    /// </summary>
    public static void OnDidPresent<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonActionSheet
    {
        b.OnEventAction("ondidPresent", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the action sheet has dismissed.
    /// </summary>
    public static void OnIonActionSheetDidDismiss<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, OverlayEventDetail>> action) where TComponent: IonActionSheet
    {
        b.OnEventAction("onionActionSheetDidDismiss", action, "detail");
    }
    /// <summary>
    /// Emitted after the action sheet has dismissed.
    /// </summary>
    public static void OnIonActionSheetDidDismiss<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<OverlayEventDetail>, Var<TModel>> action) where TComponent: IonActionSheet
    {
        b.OnEventAction("onionActionSheetDidDismiss", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// Emitted after the action sheet has presented.
    /// </summary>
    public static void OnIonActionSheetDidPresent<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonActionSheet
    {
        b.OnEventAction("onionActionSheetDidPresent", action);
    }
    /// <summary>
    /// Emitted after the action sheet has presented.
    /// </summary>
    public static void OnIonActionSheetDidPresent<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonActionSheet
    {
        b.OnEventAction("onionActionSheetDidPresent", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted before the action sheet has dismissed.
    /// </summary>
    public static void OnIonActionSheetWillDismiss<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, OverlayEventDetail>> action) where TComponent: IonActionSheet
    {
        b.OnEventAction("onionActionSheetWillDismiss", action, "detail");
    }
    /// <summary>
    /// Emitted before the action sheet has dismissed.
    /// </summary>
    public static void OnIonActionSheetWillDismiss<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<OverlayEventDetail>, Var<TModel>> action) where TComponent: IonActionSheet
    {
        b.OnEventAction("onionActionSheetWillDismiss", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// Emitted before the action sheet has presented.
    /// </summary>
    public static void OnIonActionSheetWillPresent<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonActionSheet
    {
        b.OnEventAction("onionActionSheetWillPresent", action);
    }
    /// <summary>
    /// Emitted before the action sheet has presented.
    /// </summary>
    public static void OnIonActionSheetWillPresent<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonActionSheet
    {
        b.OnEventAction("onionActionSheetWillPresent", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted before the action sheet has dismissed. Shorthand for ionActionSheetWillDismiss.
    /// </summary>
    public static void OnWillDismiss<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, OverlayEventDetail>> action) where TComponent: IonActionSheet
    {
        b.OnEventAction("onwillDismiss", action, "detail");
    }
    /// <summary>
    /// Emitted before the action sheet has dismissed. Shorthand for ionActionSheetWillDismiss.
    /// </summary>
    public static void OnWillDismiss<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<OverlayEventDetail>, Var<TModel>> action) where TComponent: IonActionSheet
    {
        b.OnEventAction("onwillDismiss", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// Emitted before the action sheet has presented. Shorthand for ionActionSheetWillPresent.
    /// </summary>
    public static void OnWillPresent<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonActionSheet
    {
        b.OnEventAction("onwillPresent", action);
    }
    /// <summary>
    /// Emitted before the action sheet has presented. Shorthand for ionActionSheetWillPresent.
    /// </summary>
    public static void OnWillPresent<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonActionSheet
    {
        b.OnEventAction("onwillPresent", b.MakeAction(action));
    }

}

