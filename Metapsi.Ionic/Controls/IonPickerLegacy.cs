using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Ionic;


public partial class IonPickerLegacy
{
    public static class Method
    {
        /// <summary>
        /// <para> Dismiss the picker overlay after it has been presented. </para>
        /// <para> (data?: any, role?: string) =&gt; Promise&lt;boolean&gt; </para>
        /// <para> data Any data to emit in the dismiss events. </para>
        /// <para> role The role of the element that is dismissing the picker. This can be useful in a button handler for determining which button was clicked to dismiss the picker. Some examples include: ``"cancel"`, `"destructive"`, "selected"`, and `"backdrop"`. </para>
        /// </summary>
        public const string Dismiss = "dismiss";
        /// <summary>
        /// <para> Get the column that matches the specified name. </para>
        /// <para> (name: string) =&gt; Promise&lt;PickerColumn | undefined&gt; </para>
        /// <para> name The name of the column. </para>
        /// </summary>
        public const string GetColumn = "getColumn";
        /// <summary>
        /// <para> Returns a promise that resolves when the picker did dismiss. </para>
        /// <para> &lt;T = any&gt;() =&gt; Promise&lt;OverlayEventDetail&lt;T&gt;&gt; </para>
        /// </summary>
        public const string OnDidDismiss = "onDidDismiss";
        /// <summary>
        /// <para> Returns a promise that resolves when the picker will dismiss. </para>
        /// <para> &lt;T = any&gt;() =&gt; Promise&lt;OverlayEventDetail&lt;T&gt;&gt; </para>
        /// </summary>
        public const string OnWillDismiss = "onWillDismiss";
        /// <summary>
        /// <para> Present the picker overlay after it has been created. </para>
        /// <para> () =&gt; Promise&lt;void&gt; </para>
        /// </summary>
        public const string Present = "present";
    }
}

public static partial class IonPickerLegacyControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonPickerLegacy(this HtmlBuilder b, Action<AttributesBuilder<IonPickerLegacy>> buildAttributes, params IHtmlNode[] children)
    {
        return b.IonicTag("ion-picker-legacy", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonPickerLegacy(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.IonicTag("ion-picker-legacy", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonPickerLegacy(this HtmlBuilder b, Action<AttributesBuilder<IonPickerLegacy>> buildAttributes, List<IHtmlNode> children)
    {
        return b.IonicTag("ion-picker-legacy", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonPickerLegacy(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.IonicTag("ion-picker-legacy", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> If `true`, the picker will animate. </para>
    /// </summary>
    public static void SetAnimated(this AttributesBuilder<IonPickerLegacy> b)
    {
        b.SetAttribute("animated", "");
    }

    /// <summary>
    /// <para> If `true`, the picker will animate. </para>
    /// </summary>
    public static void SetAnimated(this AttributesBuilder<IonPickerLegacy> b, bool animated)
    {
        if (animated) b.SetAttribute("animated", "");
    }

    /// <summary>
    /// <para> If `true`, the picker will be dismissed when the backdrop is clicked. </para>
    /// </summary>
    public static void SetBackdropDismiss(this AttributesBuilder<IonPickerLegacy> b)
    {
        b.SetAttribute("backdrop-dismiss", "");
    }

    /// <summary>
    /// <para> If `true`, the picker will be dismissed when the backdrop is clicked. </para>
    /// </summary>
    public static void SetBackdropDismiss(this AttributesBuilder<IonPickerLegacy> b, bool backdropDismiss)
    {
        if (backdropDismiss) b.SetAttribute("backdrop-dismiss", "");
    }

    /// <summary>
    /// <para> Additional classes to apply for custom CSS. If multiple classes are provided they should be separated by spaces. </para>
    /// </summary>
    public static void SetCssClass(this AttributesBuilder<IonPickerLegacy> b, string cssClass)
    {
        b.SetAttribute("css-class", cssClass);
    }

    /// <summary>
    /// <para> Number of milliseconds to wait before dismissing the picker. </para>
    /// </summary>
    public static void SetDuration(this AttributesBuilder<IonPickerLegacy> b, string duration)
    {
        b.SetAttribute("duration", duration);
    }

    /// <summary>
    /// <para> If `true`, the picker will open. If `false`, the picker will close. Use this if you need finer grained control over presentation, otherwise just use the pickerController or the `trigger` property. Note: `isOpen` will not automatically be set back to `false` when the picker dismisses. You will need to do that in your code. </para>
    /// </summary>
    public static void SetIsOpen(this AttributesBuilder<IonPickerLegacy> b)
    {
        b.SetAttribute("is-open", "");
    }

    /// <summary>
    /// <para> If `true`, the picker will open. If `false`, the picker will close. Use this if you need finer grained control over presentation, otherwise just use the pickerController or the `trigger` property. Note: `isOpen` will not automatically be set back to `false` when the picker dismisses. You will need to do that in your code. </para>
    /// </summary>
    public static void SetIsOpen(this AttributesBuilder<IonPickerLegacy> b, bool isOpen)
    {
        if (isOpen) b.SetAttribute("is-open", "");
    }

    /// <summary>
    /// <para> If `true`, the keyboard will be automatically dismissed when the overlay is presented. </para>
    /// </summary>
    public static void SetKeyboardClose(this AttributesBuilder<IonPickerLegacy> b)
    {
        b.SetAttribute("keyboard-close", "");
    }

    /// <summary>
    /// <para> If `true`, the keyboard will be automatically dismissed when the overlay is presented. </para>
    /// </summary>
    public static void SetKeyboardClose(this AttributesBuilder<IonPickerLegacy> b, bool keyboardClose)
    {
        if (keyboardClose) b.SetAttribute("keyboard-close", "");
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetMode(this AttributesBuilder<IonPickerLegacy> b, string mode)
    {
        b.SetAttribute("mode", mode);
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeIos(this AttributesBuilder<IonPickerLegacy> b)
    {
        b.SetAttribute("mode", "ios");
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeMd(this AttributesBuilder<IonPickerLegacy> b)
    {
        b.SetAttribute("mode", "md");
    }

    /// <summary>
    /// <para> If `true`, a backdrop will be displayed behind the picker. </para>
    /// </summary>
    public static void SetShowBackdrop(this AttributesBuilder<IonPickerLegacy> b)
    {
        b.SetAttribute("show-backdrop", "");
    }

    /// <summary>
    /// <para> If `true`, a backdrop will be displayed behind the picker. </para>
    /// </summary>
    public static void SetShowBackdrop(this AttributesBuilder<IonPickerLegacy> b, bool showBackdrop)
    {
        if (showBackdrop) b.SetAttribute("show-backdrop", "");
    }

    /// <summary>
    /// <para> An ID corresponding to the trigger element that causes the picker to open when clicked. </para>
    /// </summary>
    public static void SetTrigger(this AttributesBuilder<IonPickerLegacy> b, string trigger)
    {
        b.SetAttribute("trigger", trigger);
    }

    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonPickerLegacy(this LayoutBuilder b, Action<PropsBuilder<IonPickerLegacy>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-picker-legacy", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonPickerLegacy(this LayoutBuilder b, Action<PropsBuilder<IonPickerLegacy>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-picker-legacy", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonPickerLegacy(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-picker-legacy", children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonPickerLegacy(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-picker-legacy", children);
    }
    /// <summary>
    /// <para> If `true`, the picker will animate. </para>
    /// </summary>
    public static void SetAnimated<T>(this PropsBuilder<T> b) where T: IonPickerLegacy
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("animated"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, the picker will animate. </para>
    /// </summary>
    public static void SetAnimated<T>(this PropsBuilder<T> b, Var<bool> animated) where T: IonPickerLegacy
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("animated"), animated);
    }

    /// <summary>
    /// <para> If `true`, the picker will animate. </para>
    /// </summary>
    public static void SetAnimated<T>(this PropsBuilder<T> b, bool animated) where T: IonPickerLegacy
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("animated"), b.Const(animated));
    }


    /// <summary>
    /// <para> If `true`, the picker will be dismissed when the backdrop is clicked. </para>
    /// </summary>
    public static void SetBackdropDismiss<T>(this PropsBuilder<T> b) where T: IonPickerLegacy
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("backdropDismiss"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, the picker will be dismissed when the backdrop is clicked. </para>
    /// </summary>
    public static void SetBackdropDismiss<T>(this PropsBuilder<T> b, Var<bool> backdropDismiss) where T: IonPickerLegacy
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("backdropDismiss"), backdropDismiss);
    }

    /// <summary>
    /// <para> If `true`, the picker will be dismissed when the backdrop is clicked. </para>
    /// </summary>
    public static void SetBackdropDismiss<T>(this PropsBuilder<T> b, bool backdropDismiss) where T: IonPickerLegacy
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("backdropDismiss"), b.Const(backdropDismiss));
    }


    /// <summary>
    /// <para> Array of buttons to be displayed at the top of the picker. </para>
    /// </summary>
    public static void SetButtons<T>(this PropsBuilder<T> b, Var<List<PickerButton>> buttons) where T: IonPickerLegacy
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<PickerButton>>("buttons"), buttons);
    }

    /// <summary>
    /// <para> Array of buttons to be displayed at the top of the picker. </para>
    /// </summary>
    public static void SetButtons<T>(this PropsBuilder<T> b, List<PickerButton> buttons) where T: IonPickerLegacy
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<PickerButton>>("buttons"), b.Const(buttons));
    }


    /// <summary>
    /// <para> Array of columns to be displayed in the picker. </para>
    /// </summary>
    public static void SetColumns<T>(this PropsBuilder<T> b, Var<List<PickerColumn>> columns) where T: IonPickerLegacy
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<PickerColumn>>("columns"), columns);
    }

    /// <summary>
    /// <para> Array of columns to be displayed in the picker. </para>
    /// </summary>
    public static void SetColumns<T>(this PropsBuilder<T> b, List<PickerColumn> columns) where T: IonPickerLegacy
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<PickerColumn>>("columns"), b.Const(columns));
    }


    /// <summary>
    /// <para> Additional classes to apply for custom CSS. If multiple classes are provided they should be separated by spaces. </para>
    /// </summary>
    public static void SetCssClass<T>(this PropsBuilder<T> b, Var<string> cssClass) where T: IonPickerLegacy
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("cssClass"), cssClass);
    }

    /// <summary>
    /// <para> Additional classes to apply for custom CSS. If multiple classes are provided they should be separated by spaces. </para>
    /// </summary>
    public static void SetCssClass<T>(this PropsBuilder<T> b, string cssClass) where T: IonPickerLegacy
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("cssClass"), b.Const(cssClass));
    }


    /// <summary>
    /// <para> Additional classes to apply for custom CSS. If multiple classes are provided they should be separated by spaces. </para>
    /// </summary>
    public static void SetCssClass<T>(this PropsBuilder<T> b, Var<List<string>> cssClass) where T: IonPickerLegacy
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<string>>("cssClass"), cssClass);
    }

    /// <summary>
    /// <para> Additional classes to apply for custom CSS. If multiple classes are provided they should be separated by spaces. </para>
    /// </summary>
    public static void SetCssClass<T>(this PropsBuilder<T> b, List<string> cssClass) where T: IonPickerLegacy
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<string>>("cssClass"), b.Const(cssClass));
    }


    /// <summary>
    /// <para> Number of milliseconds to wait before dismissing the picker. </para>
    /// </summary>
    public static void SetDuration<T>(this PropsBuilder<T> b, Var<int> duration) where T: IonPickerLegacy
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("duration"), duration);
    }

    /// <summary>
    /// <para> Number of milliseconds to wait before dismissing the picker. </para>
    /// </summary>
    public static void SetDuration<T>(this PropsBuilder<T> b, int duration) where T: IonPickerLegacy
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("duration"), b.Const(duration));
    }


    /// <summary>
    /// <para> Animation to use when the picker is presented. </para>
    /// </summary>
    public static void SetEnterAnimation<T>(this PropsBuilder<T> b, Var<System.Func<object,object,Animation>> enterAnimation) where T: IonPickerLegacy
    {
        b.SetDynamic(b.Props, new DynamicProperty<System.Func<object,object,Animation>>("enterAnimation"), enterAnimation);
    }

    /// <summary>
    /// <para> Animation to use when the picker is presented. </para>
    /// </summary>
    public static void SetEnterAnimation<T>(this PropsBuilder<T> b, System.Func<object,object,Animation> enterAnimation) where T: IonPickerLegacy
    {
        b.SetDynamic(b.Props, new DynamicProperty<System.Func<object,object,Animation>>("enterAnimation"), b.Const(enterAnimation));
    }


    /// <summary>
    /// <para> Additional attributes to pass to the picker. </para>
    /// </summary>
    public static void SetHtmlAttributes<T>(this PropsBuilder<T> b, Var<DynamicObject> htmlAttributes) where T: IonPickerLegacy
    {
        b.SetDynamic(b.Props, new DynamicProperty<DynamicObject>("htmlAttributes"), htmlAttributes);
    }

    /// <summary>
    /// <para> Additional attributes to pass to the picker. </para>
    /// </summary>
    public static void SetHtmlAttributes<T>(this PropsBuilder<T> b, DynamicObject htmlAttributes) where T: IonPickerLegacy
    {
        b.SetDynamic(b.Props, new DynamicProperty<DynamicObject>("htmlAttributes"), b.Const(htmlAttributes));
    }


    /// <summary>
    /// <para> If `true`, the picker will open. If `false`, the picker will close. Use this if you need finer grained control over presentation, otherwise just use the pickerController or the `trigger` property. Note: `isOpen` will not automatically be set back to `false` when the picker dismisses. You will need to do that in your code. </para>
    /// </summary>
    public static void SetIsOpen<T>(this PropsBuilder<T> b) where T: IonPickerLegacy
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("isOpen"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, the picker will open. If `false`, the picker will close. Use this if you need finer grained control over presentation, otherwise just use the pickerController or the `trigger` property. Note: `isOpen` will not automatically be set back to `false` when the picker dismisses. You will need to do that in your code. </para>
    /// </summary>
    public static void SetIsOpen<T>(this PropsBuilder<T> b, Var<bool> isOpen) where T: IonPickerLegacy
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("isOpen"), isOpen);
    }

    /// <summary>
    /// <para> If `true`, the picker will open. If `false`, the picker will close. Use this if you need finer grained control over presentation, otherwise just use the pickerController or the `trigger` property. Note: `isOpen` will not automatically be set back to `false` when the picker dismisses. You will need to do that in your code. </para>
    /// </summary>
    public static void SetIsOpen<T>(this PropsBuilder<T> b, bool isOpen) where T: IonPickerLegacy
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("isOpen"), b.Const(isOpen));
    }


    /// <summary>
    /// <para> If `true`, the keyboard will be automatically dismissed when the overlay is presented. </para>
    /// </summary>
    public static void SetKeyboardClose<T>(this PropsBuilder<T> b) where T: IonPickerLegacy
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("keyboardClose"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, the keyboard will be automatically dismissed when the overlay is presented. </para>
    /// </summary>
    public static void SetKeyboardClose<T>(this PropsBuilder<T> b, Var<bool> keyboardClose) where T: IonPickerLegacy
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("keyboardClose"), keyboardClose);
    }

    /// <summary>
    /// <para> If `true`, the keyboard will be automatically dismissed when the overlay is presented. </para>
    /// </summary>
    public static void SetKeyboardClose<T>(this PropsBuilder<T> b, bool keyboardClose) where T: IonPickerLegacy
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("keyboardClose"), b.Const(keyboardClose));
    }


    /// <summary>
    /// <para> Animation to use when the picker is dismissed. </para>
    /// </summary>
    public static void SetLeaveAnimation<T>(this PropsBuilder<T> b, Var<System.Func<object,object,Animation>> leaveAnimation) where T: IonPickerLegacy
    {
        b.SetDynamic(b.Props, new DynamicProperty<System.Func<object,object,Animation>>("leaveAnimation"), leaveAnimation);
    }

    /// <summary>
    /// <para> Animation to use when the picker is dismissed. </para>
    /// </summary>
    public static void SetLeaveAnimation<T>(this PropsBuilder<T> b, System.Func<object,object,Animation> leaveAnimation) where T: IonPickerLegacy
    {
        b.SetDynamic(b.Props, new DynamicProperty<System.Func<object,object,Animation>>("leaveAnimation"), b.Const(leaveAnimation));
    }


    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeIos<T>(this PropsBuilder<T> b) where T: IonPickerLegacy
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("mode"), b.Const("ios"));
    }


    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeMd<T>(this PropsBuilder<T> b) where T: IonPickerLegacy
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("mode"), b.Const("md"));
    }


    /// <summary>
    /// <para> If `true`, a backdrop will be displayed behind the picker. </para>
    /// </summary>
    public static void SetShowBackdrop<T>(this PropsBuilder<T> b) where T: IonPickerLegacy
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("showBackdrop"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, a backdrop will be displayed behind the picker. </para>
    /// </summary>
    public static void SetShowBackdrop<T>(this PropsBuilder<T> b, Var<bool> showBackdrop) where T: IonPickerLegacy
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("showBackdrop"), showBackdrop);
    }

    /// <summary>
    /// <para> If `true`, a backdrop will be displayed behind the picker. </para>
    /// </summary>
    public static void SetShowBackdrop<T>(this PropsBuilder<T> b, bool showBackdrop) where T: IonPickerLegacy
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("showBackdrop"), b.Const(showBackdrop));
    }


    /// <summary>
    /// <para> An ID corresponding to the trigger element that causes the picker to open when clicked. </para>
    /// </summary>
    public static void SetTrigger<T>(this PropsBuilder<T> b, Var<string> trigger) where T: IonPickerLegacy
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("trigger"), trigger);
    }

    /// <summary>
    /// <para> An ID corresponding to the trigger element that causes the picker to open when clicked. </para>
    /// </summary>
    public static void SetTrigger<T>(this PropsBuilder<T> b, string trigger) where T: IonPickerLegacy
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("trigger"), b.Const(trigger));
    }


    /// <summary>
    /// <para> Emitted after the picker has dismissed. Shorthand for ionPickerDidDismiss. </para>
    /// </summary>
    public static void OnDidDismiss<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, OverlayEventDetail>> action) where TComponent: IonPickerLegacy
    {
        b.OnEventAction("ondidDismiss", action, "detail");
    }
    /// <summary>
    /// <para> Emitted after the picker has dismissed. Shorthand for ionPickerDidDismiss. </para>
    /// </summary>
    public static void OnDidDismiss<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<OverlayEventDetail>, Var<TModel>> action) where TComponent: IonPickerLegacy
    {
        b.OnEventAction("ondidDismiss", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// <para> Emitted after the picker has presented. Shorthand for ionPickerWillDismiss. </para>
    /// </summary>
    public static void OnDidPresent<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonPickerLegacy
    {
        b.OnEventAction("ondidPresent", action);
    }
    /// <summary>
    /// <para> Emitted after the picker has presented. Shorthand for ionPickerWillDismiss. </para>
    /// </summary>
    public static void OnDidPresent<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonPickerLegacy
    {
        b.OnEventAction("ondidPresent", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted after the picker has dismissed. </para>
    /// </summary>
    public static void OnIonPickerDidDismiss<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, OverlayEventDetail>> action) where TComponent: IonPickerLegacy
    {
        b.OnEventAction("onionPickerDidDismiss", action, "detail");
    }
    /// <summary>
    /// <para> Emitted after the picker has dismissed. </para>
    /// </summary>
    public static void OnIonPickerDidDismiss<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<OverlayEventDetail>, Var<TModel>> action) where TComponent: IonPickerLegacy
    {
        b.OnEventAction("onionPickerDidDismiss", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// <para> Emitted after the picker has presented. </para>
    /// </summary>
    public static void OnIonPickerDidPresent<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonPickerLegacy
    {
        b.OnEventAction("onionPickerDidPresent", action);
    }
    /// <summary>
    /// <para> Emitted after the picker has presented. </para>
    /// </summary>
    public static void OnIonPickerDidPresent<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonPickerLegacy
    {
        b.OnEventAction("onionPickerDidPresent", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted before the picker has dismissed. </para>
    /// </summary>
    public static void OnIonPickerWillDismiss<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, OverlayEventDetail>> action) where TComponent: IonPickerLegacy
    {
        b.OnEventAction("onionPickerWillDismiss", action, "detail");
    }
    /// <summary>
    /// <para> Emitted before the picker has dismissed. </para>
    /// </summary>
    public static void OnIonPickerWillDismiss<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<OverlayEventDetail>, Var<TModel>> action) where TComponent: IonPickerLegacy
    {
        b.OnEventAction("onionPickerWillDismiss", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// <para> Emitted before the picker has presented. </para>
    /// </summary>
    public static void OnIonPickerWillPresent<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonPickerLegacy
    {
        b.OnEventAction("onionPickerWillPresent", action);
    }
    /// <summary>
    /// <para> Emitted before the picker has presented. </para>
    /// </summary>
    public static void OnIonPickerWillPresent<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonPickerLegacy
    {
        b.OnEventAction("onionPickerWillPresent", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted before the picker has dismissed. Shorthand for ionPickerWillDismiss. </para>
    /// </summary>
    public static void OnWillDismiss<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, OverlayEventDetail>> action) where TComponent: IonPickerLegacy
    {
        b.OnEventAction("onwillDismiss", action, "detail");
    }
    /// <summary>
    /// <para> Emitted before the picker has dismissed. Shorthand for ionPickerWillDismiss. </para>
    /// </summary>
    public static void OnWillDismiss<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<OverlayEventDetail>, Var<TModel>> action) where TComponent: IonPickerLegacy
    {
        b.OnEventAction("onwillDismiss", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// <para> Emitted before the picker has presented. Shorthand for ionPickerWillPresent. </para>
    /// </summary>
    public static void OnWillPresent<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonPickerLegacy
    {
        b.OnEventAction("onwillPresent", action);
    }
    /// <summary>
    /// <para> Emitted before the picker has presented. Shorthand for ionPickerWillPresent. </para>
    /// </summary>
    public static void OnWillPresent<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonPickerLegacy
    {
        b.OnEventAction("onwillPresent", b.MakeAction(action));
    }

}

