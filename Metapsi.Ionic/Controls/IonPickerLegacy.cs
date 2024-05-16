using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Ionic;


public partial class IonPickerLegacy : IonComponent
{
    public IonPickerLegacy() : base("ion-picker-legacy") { }
    public static class Method
    {
        /// <summary> 
        /// Dismiss the picker overlay after it has been presented.
        /// <para>(data?: any, role?: string) =&gt; Promise&lt;boolean&gt;</para>
        /// <para>data Any data to emit in the dismiss events.</para>
        /// <para>role The role of the element that is dismissing the picker. This can be useful in a button handler for determining which button was clicked to dismiss the picker. Some examples include: ``"cancel"`, `"destructive"`, "selected"`, and `"backdrop"`.</para>
        /// </summary>
        public const string Dismiss = "dismiss";
        /// <summary> 
        /// Get the column that matches the specified name.
        /// <para>(name: string) =&gt; Promise&lt;PickerColumn | undefined&gt;</para>
        /// <para>name The name of the column.</para>
        /// </summary>
        public const string GetColumn = "getColumn";
        /// <summary> 
        /// Returns a promise that resolves when the picker did dismiss.
        /// <para>&lt;T = any&gt;() =&gt; Promise&lt;OverlayEventDetail&lt;T&gt;&gt;</para>
        /// </summary>
        public const string OnDidDismiss = "onDidDismiss";
        /// <summary> 
        /// Returns a promise that resolves when the picker will dismiss.
        /// <para>&lt;T = any&gt;() =&gt; Promise&lt;OverlayEventDetail&lt;T&gt;&gt;</para>
        /// </summary>
        public const string OnWillDismiss = "onWillDismiss";
        /// <summary> 
        /// Present the picker overlay after it has been created.
        /// <para>() =&gt; Promise&lt;void&gt;</para>
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
        return b.Tag("ion-picker-legacy", buildAttributes, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static IHtmlNode IonPickerLegacy(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("ion-picker-legacy", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// If `true`, the picker will animate.
    /// </summary>
    public static void SetAnimated(this AttributesBuilder<IonPickerLegacy> b)
    {
        b.SetAttribute("animated", "");
    }
    /// <summary>
    /// If `true`, the picker will animate.
    /// </summary>
    public static void SetAnimated(this AttributesBuilder<IonPickerLegacy> b, bool value)
    {
        if (value) b.SetAttribute("animated", "");
    }

    /// <summary>
    /// If `true`, the picker will be dismissed when the backdrop is clicked.
    /// </summary>
    public static void SetBackdropDismiss(this AttributesBuilder<IonPickerLegacy> b)
    {
        b.SetAttribute("backdrop-dismiss", "");
    }
    /// <summary>
    /// If `true`, the picker will be dismissed when the backdrop is clicked.
    /// </summary>
    public static void SetBackdropDismiss(this AttributesBuilder<IonPickerLegacy> b, bool value)
    {
        if (value) b.SetAttribute("backdrop-dismiss", "");
    }

    /// <summary>
    /// Additional classes to apply for custom CSS. If multiple classes are provided they should be separated by spaces.
    /// </summary>
    public static void SetCssClass(this AttributesBuilder<IonPickerLegacy> b, string value)
    {
        b.SetAttribute("css-class", value);
    }

    /// <summary>
    /// Number of milliseconds to wait before dismissing the picker.
    /// </summary>
    public static void SetDuration(this AttributesBuilder<IonPickerLegacy> b, string value)
    {
        b.SetAttribute("duration", value);
    }

    /// <summary>
    /// If `true`, the picker will open. If `false`, the picker will close. Use this if you need finer grained control over presentation, otherwise just use the pickerController or the `trigger` property. Note: `isOpen` will not automatically be set back to `false` when the picker dismisses. You will need to do that in your code.
    /// </summary>
    public static void SetIsOpen(this AttributesBuilder<IonPickerLegacy> b)
    {
        b.SetAttribute("is-open", "");
    }
    /// <summary>
    /// If `true`, the picker will open. If `false`, the picker will close. Use this if you need finer grained control over presentation, otherwise just use the pickerController or the `trigger` property. Note: `isOpen` will not automatically be set back to `false` when the picker dismisses. You will need to do that in your code.
    /// </summary>
    public static void SetIsOpen(this AttributesBuilder<IonPickerLegacy> b, bool value)
    {
        if (value) b.SetAttribute("is-open", "");
    }

    /// <summary>
    /// If `true`, the keyboard will be automatically dismissed when the overlay is presented.
    /// </summary>
    public static void SetKeyboardClose(this AttributesBuilder<IonPickerLegacy> b)
    {
        b.SetAttribute("keyboard-close", "");
    }
    /// <summary>
    /// If `true`, the keyboard will be automatically dismissed when the overlay is presented.
    /// </summary>
    public static void SetKeyboardClose(this AttributesBuilder<IonPickerLegacy> b, bool value)
    {
        if (value) b.SetAttribute("keyboard-close", "");
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetMode(this AttributesBuilder<IonPickerLegacy> b, string value)
    {
        b.SetAttribute("mode", value);
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos(this AttributesBuilder<IonPickerLegacy> b)
    {
        b.SetAttribute("mode", "ios");
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd(this AttributesBuilder<IonPickerLegacy> b)
    {
        b.SetAttribute("mode", "md");
    }

    /// <summary>
    /// If `true`, a backdrop will be displayed behind the picker.
    /// </summary>
    public static void SetShowBackdrop(this AttributesBuilder<IonPickerLegacy> b)
    {
        b.SetAttribute("show-backdrop", "");
    }
    /// <summary>
    /// If `true`, a backdrop will be displayed behind the picker.
    /// </summary>
    public static void SetShowBackdrop(this AttributesBuilder<IonPickerLegacy> b, bool value)
    {
        if (value) b.SetAttribute("show-backdrop", "");
    }

    /// <summary>
    /// An ID corresponding to the trigger element that causes the picker to open when clicked.
    /// </summary>
    public static void SetTrigger(this AttributesBuilder<IonPickerLegacy> b, string value)
    {
        b.SetAttribute("trigger", value);
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
    /// If `true`, the picker will animate.
    /// </summary>
    public static void SetAnimated<T>(this PropsBuilder<T> b) where T: IonPickerLegacy
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("animated"), b.Const(true));
    }

    /// <summary>
    /// If `true`, the picker will be dismissed when the backdrop is clicked.
    /// </summary>
    public static void SetBackdropDismiss<T>(this PropsBuilder<T> b) where T: IonPickerLegacy
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("backdropDismiss"), b.Const(true));
    }

    /// <summary>
    /// Array of buttons to be displayed at the top of the picker.
    /// </summary>
    public static void SetButtons<T>(this PropsBuilder<T> b, Var<List<PickerButton>> value) where T: IonPickerLegacy
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<PickerButton>>("buttons"), value);
    }
    /// <summary>
    /// Array of buttons to be displayed at the top of the picker.
    /// </summary>
    public static void SetButtons<T>(this PropsBuilder<T> b, List<PickerButton> value) where T: IonPickerLegacy
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<PickerButton>>("buttons"), b.Const(value));
    }

    /// <summary>
    /// Array of columns to be displayed in the picker.
    /// </summary>
    public static void SetColumns<T>(this PropsBuilder<T> b, Var<List<PickerColumn>> value) where T: IonPickerLegacy
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<PickerColumn>>("columns"), value);
    }
    /// <summary>
    /// Array of columns to be displayed in the picker.
    /// </summary>
    public static void SetColumns<T>(this PropsBuilder<T> b, List<PickerColumn> value) where T: IonPickerLegacy
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<PickerColumn>>("columns"), b.Const(value));
    }

    /// <summary>
    /// Additional classes to apply for custom CSS. If multiple classes are provided they should be separated by spaces.
    /// </summary>
    public static void SetCssClass<T>(this PropsBuilder<T> b, Var<string> value) where T: IonPickerLegacy
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("cssClass"), value);
    }
    /// <summary>
    /// Additional classes to apply for custom CSS. If multiple classes are provided they should be separated by spaces.
    /// </summary>
    public static void SetCssClass<T>(this PropsBuilder<T> b, string value) where T: IonPickerLegacy
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("cssClass"), b.Const(value));
    }
    /// <summary>
    /// Additional classes to apply for custom CSS. If multiple classes are provided they should be separated by spaces.
    /// </summary>
    public static void SetCssClass<T>(this PropsBuilder<T> b, Var<List<string>> value) where T: IonPickerLegacy
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<string>>("cssClass"), value);
    }
    /// <summary>
    /// Additional classes to apply for custom CSS. If multiple classes are provided they should be separated by spaces.
    /// </summary>
    public static void SetCssClass<T>(this PropsBuilder<T> b, List<string> value) where T: IonPickerLegacy
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<string>>("cssClass"), b.Const(value));
    }

    /// <summary>
    /// Number of milliseconds to wait before dismissing the picker.
    /// </summary>
    public static void SetDuration<T>(this PropsBuilder<T> b, Var<int> value) where T: IonPickerLegacy
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("duration"), value);
    }
    /// <summary>
    /// Number of milliseconds to wait before dismissing the picker.
    /// </summary>
    public static void SetDuration<T>(this PropsBuilder<T> b, int value) where T: IonPickerLegacy
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("duration"), b.Const(value));
    }

    /// <summary>
    /// Animation to use when the picker is presented.
    /// </summary>
    public static void SetEnterAnimation<T>(this PropsBuilder<T> b, Var<Func<object,object,Animation>> f) where T: IonPickerLegacy
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<object,object,Animation>>("enterAnimation"), f);
    }
    /// <summary>
    /// Animation to use when the picker is presented.
    /// </summary>
    public static void SetEnterAnimation<T>(this PropsBuilder<T> b, Func<SyntaxBuilder,Var<object>,Var<object>,Var<Animation>> f) where T: IonPickerLegacy
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<object,object,Animation>>("enterAnimation"), b.Def(f));
    }

    /// <summary>
    /// Additional attributes to pass to the picker.
    /// </summary>
    public static void SetHtmlAttributes<T>(this PropsBuilder<T> b, Var<DynamicObject> value) where T: IonPickerLegacy
    {
        b.SetDynamic(b.Props, new DynamicProperty<DynamicObject>("htmlAttributes"), value);
    }
    /// <summary>
    /// Additional attributes to pass to the picker.
    /// </summary>
    public static void SetHtmlAttributes<T>(this PropsBuilder<T> b, DynamicObject value) where T: IonPickerLegacy
    {
        b.SetDynamic(b.Props, new DynamicProperty<DynamicObject>("htmlAttributes"), b.Const(value));
    }

    /// <summary>
    /// If `true`, the picker will open. If `false`, the picker will close. Use this if you need finer grained control over presentation, otherwise just use the pickerController or the `trigger` property. Note: `isOpen` will not automatically be set back to `false` when the picker dismisses. You will need to do that in your code.
    /// </summary>
    public static void SetIsOpen<T>(this PropsBuilder<T> b) where T: IonPickerLegacy
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("isOpen"), b.Const(true));
    }

    /// <summary>
    /// If `true`, the keyboard will be automatically dismissed when the overlay is presented.
    /// </summary>
    public static void SetKeyboardClose<T>(this PropsBuilder<T> b) where T: IonPickerLegacy
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("keyboardClose"), b.Const(true));
    }

    /// <summary>
    /// Animation to use when the picker is dismissed.
    /// </summary>
    public static void SetLeaveAnimation<T>(this PropsBuilder<T> b, Var<Func<object,object,Animation>> f) where T: IonPickerLegacy
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<object,object,Animation>>("leaveAnimation"), f);
    }
    /// <summary>
    /// Animation to use when the picker is dismissed.
    /// </summary>
    public static void SetLeaveAnimation<T>(this PropsBuilder<T> b, Func<SyntaxBuilder,Var<object>,Var<object>,Var<Animation>> f) where T: IonPickerLegacy
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<object,object,Animation>>("leaveAnimation"), b.Def(f));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos<T>(this PropsBuilder<T> b) where T: IonPickerLegacy
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("ios"));
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd<T>(this PropsBuilder<T> b) where T: IonPickerLegacy
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("md"));
    }

    /// <summary>
    /// If `true`, a backdrop will be displayed behind the picker.
    /// </summary>
    public static void SetShowBackdrop<T>(this PropsBuilder<T> b) where T: IonPickerLegacy
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("showBackdrop"), b.Const(true));
    }

    /// <summary>
    /// An ID corresponding to the trigger element that causes the picker to open when clicked.
    /// </summary>
    public static void SetTrigger<T>(this PropsBuilder<T> b, Var<string> value) where T: IonPickerLegacy
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("trigger"), value);
    }
    /// <summary>
    /// An ID corresponding to the trigger element that causes the picker to open when clicked.
    /// </summary>
    public static void SetTrigger<T>(this PropsBuilder<T> b, string value) where T: IonPickerLegacy
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("trigger"), b.Const(value));
    }

    /// <summary>
    /// Emitted after the picker has dismissed. Shorthand for ionPickerDidDismiss.
    /// </summary>
    public static void OnDidDismiss<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, OverlayEventDetail>> action) where TComponent: IonPickerLegacy
    {
        b.OnEventAction("ondidDismiss", action, "detail");
    }
    /// <summary>
    /// Emitted after the picker has dismissed. Shorthand for ionPickerDidDismiss.
    /// </summary>
    public static void OnDidDismiss<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<OverlayEventDetail>, Var<TModel>> action) where TComponent: IonPickerLegacy
    {
        b.OnEventAction("ondidDismiss", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// Emitted after the picker has presented. Shorthand for ionPickerWillDismiss.
    /// </summary>
    public static void OnDidPresent<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonPickerLegacy
    {
        b.OnEventAction("ondidPresent", action);
    }
    /// <summary>
    /// Emitted after the picker has presented. Shorthand for ionPickerWillDismiss.
    /// </summary>
    public static void OnDidPresent<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonPickerLegacy
    {
        b.OnEventAction("ondidPresent", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the picker has dismissed.
    /// </summary>
    public static void OnIonPickerDidDismiss<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, OverlayEventDetail>> action) where TComponent: IonPickerLegacy
    {
        b.OnEventAction("onionPickerDidDismiss", action, "detail");
    }
    /// <summary>
    /// Emitted after the picker has dismissed.
    /// </summary>
    public static void OnIonPickerDidDismiss<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<OverlayEventDetail>, Var<TModel>> action) where TComponent: IonPickerLegacy
    {
        b.OnEventAction("onionPickerDidDismiss", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// Emitted after the picker has presented.
    /// </summary>
    public static void OnIonPickerDidPresent<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonPickerLegacy
    {
        b.OnEventAction("onionPickerDidPresent", action);
    }
    /// <summary>
    /// Emitted after the picker has presented.
    /// </summary>
    public static void OnIonPickerDidPresent<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonPickerLegacy
    {
        b.OnEventAction("onionPickerDidPresent", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted before the picker has dismissed.
    /// </summary>
    public static void OnIonPickerWillDismiss<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, OverlayEventDetail>> action) where TComponent: IonPickerLegacy
    {
        b.OnEventAction("onionPickerWillDismiss", action, "detail");
    }
    /// <summary>
    /// Emitted before the picker has dismissed.
    /// </summary>
    public static void OnIonPickerWillDismiss<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<OverlayEventDetail>, Var<TModel>> action) where TComponent: IonPickerLegacy
    {
        b.OnEventAction("onionPickerWillDismiss", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// Emitted before the picker has presented.
    /// </summary>
    public static void OnIonPickerWillPresent<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonPickerLegacy
    {
        b.OnEventAction("onionPickerWillPresent", action);
    }
    /// <summary>
    /// Emitted before the picker has presented.
    /// </summary>
    public static void OnIonPickerWillPresent<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonPickerLegacy
    {
        b.OnEventAction("onionPickerWillPresent", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted before the picker has dismissed. Shorthand for ionPickerWillDismiss.
    /// </summary>
    public static void OnWillDismiss<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, OverlayEventDetail>> action) where TComponent: IonPickerLegacy
    {
        b.OnEventAction("onwillDismiss", action, "detail");
    }
    /// <summary>
    /// Emitted before the picker has dismissed. Shorthand for ionPickerWillDismiss.
    /// </summary>
    public static void OnWillDismiss<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<OverlayEventDetail>, Var<TModel>> action) where TComponent: IonPickerLegacy
    {
        b.OnEventAction("onwillDismiss", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// Emitted before the picker has presented. Shorthand for ionPickerWillPresent.
    /// </summary>
    public static void OnWillPresent<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonPickerLegacy
    {
        b.OnEventAction("onwillPresent", action);
    }
    /// <summary>
    /// Emitted before the picker has presented. Shorthand for ionPickerWillPresent.
    /// </summary>
    public static void OnWillPresent<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonPickerLegacy
    {
        b.OnEventAction("onwillPresent", b.MakeAction(action));
    }

}

