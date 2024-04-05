using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Ionic;


public partial class IonPicker : IonComponent
{
    public IonPicker() : base("ion-picker") { }
    /// <summary>
    /// If `true`, the picker will animate.
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
    /// If `true`, the picker will be dismissed when the backdrop is clicked.
    /// </summary>
    public bool backdropDismiss
    {
        get
        {
            return this.GetTag().GetAttribute<bool>("backdropDismiss");
        }
        set
        {
            if (!value) return;
            this.GetTag().SetAttribute("backdropDismiss", value.ToString());
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
    /// Number of milliseconds to wait before dismissing the picker.
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
    /// Animation to use when the picker is presented.
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
    /// Additional attributes to pass to the picker.
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
    /// If `true`, the picker will open. If `false`, the picker will close. Use this if you need finer grained control over presentation, otherwise just use the pickerController or the `trigger` property. Note: `isOpen` will not automatically be set back to `false` when the picker dismisses. You will need to do that in your code.
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
    /// Animation to use when the picker is dismissed.
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
    /// If `true`, a backdrop will be displayed behind the picker.
    /// </summary>
    public bool showBackdrop
    {
        get
        {
            return this.GetTag().GetAttribute<bool>("showBackdrop");
        }
        set
        {
            if (!value) return;
            this.GetTag().SetAttribute("showBackdrop", value.ToString());
        }
    }

    /// <summary>
    /// An ID corresponding to the trigger element that causes the picker to open when clicked.
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
        /// Dismiss the picker overlay after it has been presented.
        /// <para>(data?: any, role?: string) =&gt; Promise&lt;boolean&gt;</para>
        /// <para>data Any data to emit in the dismiss events.</para>
        /// <para>role The role of the element that is dismissing the picker. This can be useful in a button handler for determining which button was clicked to dismiss the picker. Some examples include: ``"cancel"`, `"destructive"`, "selected"`, and `"backdrop"`.  This is a no-op if the overlay has not been presented yet. If you want to remove an overlay from the DOM that was never presented, use the [remove](https://developer.mozilla.org/en-US/docs/Web/API/Element/remove) method.</para>
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

public static partial class IonPickerControl
{
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonPicker(this LayoutBuilder b, Action<PropsBuilder<IonPicker>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-picker", buildProps, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonPicker(this LayoutBuilder b, Action<PropsBuilder<IonPicker>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-picker", buildProps, children);
    }
    /// <summary>
    /// If `true`, the picker will animate.
    /// </summary>
    public static void SetAnimated(this PropsBuilder<IonPicker> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("animated"), b.Const(true));
    }

    /// <summary>
    /// If `true`, the picker will be dismissed when the backdrop is clicked.
    /// </summary>
    public static void SetBackdropDismiss(this PropsBuilder<IonPicker> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("backdropDismiss"), b.Const(true));
    }

    /// <summary>
    /// Array of buttons to be displayed at the top of the picker.
    /// </summary>
    public static void SetButtons(this PropsBuilder<IonPicker> b, Var<List<PickerButton>> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<PickerButton>>("buttons"), value);
    }
    /// <summary>
    /// Array of buttons to be displayed at the top of the picker.
    /// </summary>
    public static void SetButtons(this PropsBuilder<IonPicker> b, List<PickerButton> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<PickerButton>>("buttons"), b.Const(value));
    }

    /// <summary>
    /// Array of columns to be displayed in the picker.
    /// </summary>
    public static void SetColumns(this PropsBuilder<IonPicker> b, Var<List<PickerColumn>> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<PickerColumn>>("columns"), value);
    }
    /// <summary>
    /// Array of columns to be displayed in the picker.
    /// </summary>
    public static void SetColumns(this PropsBuilder<IonPicker> b, List<PickerColumn> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<PickerColumn>>("columns"), b.Const(value));
    }

    /// <summary>
    /// Additional classes to apply for custom CSS. If multiple classes are provided they should be separated by spaces.
    /// </summary>
    public static void SetCssClass(this PropsBuilder<IonPicker> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("cssClass"), value);
    }
    /// <summary>
    /// Additional classes to apply for custom CSS. If multiple classes are provided they should be separated by spaces.
    /// </summary>
    public static void SetCssClass(this PropsBuilder<IonPicker> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("cssClass"), b.Const(value));
    }
    /// <summary>
    /// Additional classes to apply for custom CSS. If multiple classes are provided they should be separated by spaces.
    /// </summary>
    public static void SetCssClass(this PropsBuilder<IonPicker> b, Var<List<string>> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<string>>("cssClass"), value);
    }
    /// <summary>
    /// Additional classes to apply for custom CSS. If multiple classes are provided they should be separated by spaces.
    /// </summary>
    public static void SetCssClass(this PropsBuilder<IonPicker> b, List<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<string>>("cssClass"), b.Const(value));
    }

    /// <summary>
    /// Number of milliseconds to wait before dismissing the picker.
    /// </summary>
    public static void SetDuration(this PropsBuilder<IonPicker> b, Var<int> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("duration"), value);
    }
    /// <summary>
    /// Number of milliseconds to wait before dismissing the picker.
    /// </summary>
    public static void SetDuration(this PropsBuilder<IonPicker> b, int value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("duration"), b.Const(value));
    }

    /// <summary>
    /// Animation to use when the picker is presented.
    /// </summary>
    public static void SetEnterAnimation(this PropsBuilder<IonPicker> b, Var<Func<object,object,Animation>> f)
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<object,object,Animation>>("enterAnimation"), f);
    }
    /// <summary>
    /// Animation to use when the picker is presented.
    /// </summary>
    public static void SetEnterAnimation(this PropsBuilder<IonPicker> b, Func<SyntaxBuilder,Var<object>,Var<object>,Var<Animation>> f)
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<object,object,Animation>>("enterAnimation"), b.Def(f));
    }

    /// <summary>
    /// Additional attributes to pass to the picker.
    /// </summary>
    public static void SetHtmlAttributes(this PropsBuilder<IonPicker> b, Var<object> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<object>("htmlAttributes"), value);
    }
    /// <summary>
    /// Additional attributes to pass to the picker.
    /// </summary>
    public static void SetHtmlAttributes(this PropsBuilder<IonPicker> b, object value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<object>("htmlAttributes"), b.Const(value));
    }

    /// <summary>
    /// If `true`, the picker will open. If `false`, the picker will close. Use this if you need finer grained control over presentation, otherwise just use the pickerController or the `trigger` property. Note: `isOpen` will not automatically be set back to `false` when the picker dismisses. You will need to do that in your code.
    /// </summary>
    public static void SetIsOpen(this PropsBuilder<IonPicker> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("isOpen"), b.Const(true));
    }

    /// <summary>
    /// If `true`, the keyboard will be automatically dismissed when the overlay is presented.
    /// </summary>
    public static void SetKeyboardClose(this PropsBuilder<IonPicker> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("keyboardClose"), b.Const(true));
    }

    /// <summary>
    /// Animation to use when the picker is dismissed.
    /// </summary>
    public static void SetLeaveAnimation(this PropsBuilder<IonPicker> b, Var<Func<object,object,Animation>> f)
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<object,object,Animation>>("leaveAnimation"), f);
    }
    /// <summary>
    /// Animation to use when the picker is dismissed.
    /// </summary>
    public static void SetLeaveAnimation(this PropsBuilder<IonPicker> b, Func<SyntaxBuilder,Var<object>,Var<object>,Var<Animation>> f)
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<object,object,Animation>>("leaveAnimation"), b.Def(f));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos(this PropsBuilder<IonPicker> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("ios"));
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd(this PropsBuilder<IonPicker> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("md"));
    }

    /// <summary>
    /// If `true`, a backdrop will be displayed behind the picker.
    /// </summary>
    public static void SetShowBackdrop(this PropsBuilder<IonPicker> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("showBackdrop"), b.Const(true));
    }

    /// <summary>
    /// An ID corresponding to the trigger element that causes the picker to open when clicked.
    /// </summary>
    public static void SetTrigger(this PropsBuilder<IonPicker> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("trigger"), value);
    }
    /// <summary>
    /// An ID corresponding to the trigger element that causes the picker to open when clicked.
    /// </summary>
    public static void SetTrigger(this PropsBuilder<IonPicker> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("trigger"), b.Const(value));
    }

    /// <summary>
    /// Emitted after the picker has dismissed. Shorthand for ionPickerDidDismiss.
    /// </summary>
    public static void OnDidDismiss<TModel>(this PropsBuilder<IonPicker> b, Var<HyperType.Action<TModel, OverlayEventDetail>> action)
    {
        b.OnEventAction("ondidDismiss", action, "detail");
    }
    /// <summary>
    /// Emitted after the picker has dismissed. Shorthand for ionPickerDidDismiss.
    /// </summary>
    public static void OnDidDismiss<TModel>(this PropsBuilder<IonPicker> b, System.Func<SyntaxBuilder, Var<TModel>, Var<OverlayEventDetail>, Var<TModel>> action)
    {
        b.OnEventAction("ondidDismiss", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// Emitted after the picker has presented. Shorthand for ionPickerWillDismiss.
    /// </summary>
    public static void OnDidPresent<TModel>(this PropsBuilder<IonPicker> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("ondidPresent", action);
    }
    /// <summary>
    /// Emitted after the picker has presented. Shorthand for ionPickerWillDismiss.
    /// </summary>
    public static void OnDidPresent<TModel>(this PropsBuilder<IonPicker> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("ondidPresent", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the picker has dismissed.
    /// </summary>
    public static void OnIonPickerDidDismiss<TModel>(this PropsBuilder<IonPicker> b, Var<HyperType.Action<TModel, OverlayEventDetail>> action)
    {
        b.OnEventAction("onionPickerDidDismiss", action, "detail");
    }
    /// <summary>
    /// Emitted after the picker has dismissed.
    /// </summary>
    public static void OnIonPickerDidDismiss<TModel>(this PropsBuilder<IonPicker> b, System.Func<SyntaxBuilder, Var<TModel>, Var<OverlayEventDetail>, Var<TModel>> action)
    {
        b.OnEventAction("onionPickerDidDismiss", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// Emitted after the picker has presented.
    /// </summary>
    public static void OnIonPickerDidPresent<TModel>(this PropsBuilder<IonPicker> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onionPickerDidPresent", action);
    }
    /// <summary>
    /// Emitted after the picker has presented.
    /// </summary>
    public static void OnIonPickerDidPresent<TModel>(this PropsBuilder<IonPicker> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onionPickerDidPresent", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted before the picker has dismissed.
    /// </summary>
    public static void OnIonPickerWillDismiss<TModel>(this PropsBuilder<IonPicker> b, Var<HyperType.Action<TModel, OverlayEventDetail>> action)
    {
        b.OnEventAction("onionPickerWillDismiss", action, "detail");
    }
    /// <summary>
    /// Emitted before the picker has dismissed.
    /// </summary>
    public static void OnIonPickerWillDismiss<TModel>(this PropsBuilder<IonPicker> b, System.Func<SyntaxBuilder, Var<TModel>, Var<OverlayEventDetail>, Var<TModel>> action)
    {
        b.OnEventAction("onionPickerWillDismiss", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// Emitted before the picker has presented.
    /// </summary>
    public static void OnIonPickerWillPresent<TModel>(this PropsBuilder<IonPicker> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onionPickerWillPresent", action);
    }
    /// <summary>
    /// Emitted before the picker has presented.
    /// </summary>
    public static void OnIonPickerWillPresent<TModel>(this PropsBuilder<IonPicker> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onionPickerWillPresent", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted before the picker has dismissed. Shorthand for ionPickerWillDismiss.
    /// </summary>
    public static void OnWillDismiss<TModel>(this PropsBuilder<IonPicker> b, Var<HyperType.Action<TModel, OverlayEventDetail>> action)
    {
        b.OnEventAction("onwillDismiss", action, "detail");
    }
    /// <summary>
    /// Emitted before the picker has dismissed. Shorthand for ionPickerWillDismiss.
    /// </summary>
    public static void OnWillDismiss<TModel>(this PropsBuilder<IonPicker> b, System.Func<SyntaxBuilder, Var<TModel>, Var<OverlayEventDetail>, Var<TModel>> action)
    {
        b.OnEventAction("onwillDismiss", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// Emitted before the picker has presented. Shorthand for ionPickerWillPresent.
    /// </summary>
    public static void OnWillPresent<TModel>(this PropsBuilder<IonPicker> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onwillPresent", action);
    }
    /// <summary>
    /// Emitted before the picker has presented. Shorthand for ionPickerWillPresent.
    /// </summary>
    public static void OnWillPresent<TModel>(this PropsBuilder<IonPicker> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onwillPresent", b.MakeAction(action));
    }

}

