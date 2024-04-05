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
    /// <summary>
    /// If `true`, the action sheet will animate.
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
    /// If `true`, the action sheet will be dismissed when the backdrop is clicked.
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
    /// Animation to use when the action sheet is presented.
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
    /// Title for the action sheet.
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
    /// Additional attributes to pass to the action sheet.
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
    /// If `true`, the action sheet will open. If `false`, the action sheet will close. Use this if you need finer grained control over presentation, otherwise just use the actionSheetController or the `trigger` property. Note: `isOpen` will not automatically be set back to `false` when the action sheet dismisses. You will need to do that in your code.
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
    /// Animation to use when the action sheet is dismissed.
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
    /// Subtitle for the action sheet.
    /// </summary>
    public string subHeader
    {
        get
        {
            return this.GetTag().GetAttribute<string>("subHeader");
        }
        set
        {
            this.GetTag().SetAttribute("subHeader", value.ToString());
        }
    }

    /// <summary>
    /// If `true`, the action sheet will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility).
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
    /// An ID corresponding to the trigger element that causes the action sheet to open when clicked.
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
    /// If `true`, the action sheet will animate.
    /// </summary>
    public static void SetAnimated(this PropsBuilder<IonActionSheet> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("animated"), b.Const(true));
    }

    /// <summary>
    /// If `true`, the action sheet will be dismissed when the backdrop is clicked.
    /// </summary>
    public static void SetBackdropDismiss(this PropsBuilder<IonActionSheet> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("backdropDismiss"), b.Const(true));
    }

    /// <summary>
    /// An array of buttons for the action sheet.
    /// </summary>
    public static void SetButtons(this PropsBuilder<IonActionSheet> b, Var<List<string>> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<string>>("buttons"), value);
    }
    /// <summary>
    /// An array of buttons for the action sheet.
    /// </summary>
    public static void SetButtons(this PropsBuilder<IonActionSheet> b, List<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<string>>("buttons"), b.Const(value));
    }
    /// <summary>
    /// An array of buttons for the action sheet.
    /// </summary>
    public static void SetButtons(this PropsBuilder<IonActionSheet> b, Var<List<ActionSheetButton>> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<ActionSheetButton>>("buttons"), value);
    }
    /// <summary>
    /// An array of buttons for the action sheet.
    /// </summary>
    public static void SetButtons(this PropsBuilder<IonActionSheet> b, List<ActionSheetButton> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<ActionSheetButton>>("buttons"), b.Const(value));
    }

    /// <summary>
    /// Additional classes to apply for custom CSS. If multiple classes are provided they should be separated by spaces.
    /// </summary>
    public static void SetCssClass(this PropsBuilder<IonActionSheet> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("cssClass"), value);
    }
    /// <summary>
    /// Additional classes to apply for custom CSS. If multiple classes are provided they should be separated by spaces.
    /// </summary>
    public static void SetCssClass(this PropsBuilder<IonActionSheet> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("cssClass"), b.Const(value));
    }
    /// <summary>
    /// Additional classes to apply for custom CSS. If multiple classes are provided they should be separated by spaces.
    /// </summary>
    public static void SetCssClass(this PropsBuilder<IonActionSheet> b, Var<List<string>> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<string>>("cssClass"), value);
    }
    /// <summary>
    /// Additional classes to apply for custom CSS. If multiple classes are provided they should be separated by spaces.
    /// </summary>
    public static void SetCssClass(this PropsBuilder<IonActionSheet> b, List<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<string>>("cssClass"), b.Const(value));
    }

    /// <summary>
    /// Animation to use when the action sheet is presented.
    /// </summary>
    public static void SetEnterAnimation(this PropsBuilder<IonActionSheet> b, Var<Func<object,object,Animation>> f)
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<object,object,Animation>>("enterAnimation"), f);
    }
    /// <summary>
    /// Animation to use when the action sheet is presented.
    /// </summary>
    public static void SetEnterAnimation(this PropsBuilder<IonActionSheet> b, Func<SyntaxBuilder,Var<object>,Var<object>,Var<Animation>> f)
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<object,object,Animation>>("enterAnimation"), b.Def(f));
    }

    /// <summary>
    /// Title for the action sheet.
    /// </summary>
    public static void SetHeader(this PropsBuilder<IonActionSheet> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("header"), value);
    }
    /// <summary>
    /// Title for the action sheet.
    /// </summary>
    public static void SetHeader(this PropsBuilder<IonActionSheet> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("header"), b.Const(value));
    }

    /// <summary>
    /// Additional attributes to pass to the action sheet.
    /// </summary>
    public static void SetHtmlAttributes(this PropsBuilder<IonActionSheet> b, Var<object> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<object>("htmlAttributes"), value);
    }
    /// <summary>
    /// Additional attributes to pass to the action sheet.
    /// </summary>
    public static void SetHtmlAttributes(this PropsBuilder<IonActionSheet> b, object value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<object>("htmlAttributes"), b.Const(value));
    }

    /// <summary>
    /// If `true`, the action sheet will open. If `false`, the action sheet will close. Use this if you need finer grained control over presentation, otherwise just use the actionSheetController or the `trigger` property. Note: `isOpen` will not automatically be set back to `false` when the action sheet dismisses. You will need to do that in your code.
    /// </summary>
    public static void SetIsOpen(this PropsBuilder<IonActionSheet> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("isOpen"), b.Const(true));
    }

    /// <summary>
    /// If `true`, the keyboard will be automatically dismissed when the overlay is presented.
    /// </summary>
    public static void SetKeyboardClose(this PropsBuilder<IonActionSheet> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("keyboardClose"), b.Const(true));
    }

    /// <summary>
    /// Animation to use when the action sheet is dismissed.
    /// </summary>
    public static void SetLeaveAnimation(this PropsBuilder<IonActionSheet> b, Var<Func<object,object,Animation>> f)
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<object,object,Animation>>("leaveAnimation"), f);
    }
    /// <summary>
    /// Animation to use when the action sheet is dismissed.
    /// </summary>
    public static void SetLeaveAnimation(this PropsBuilder<IonActionSheet> b, Func<SyntaxBuilder,Var<object>,Var<object>,Var<Animation>> f)
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<object,object,Animation>>("leaveAnimation"), b.Def(f));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos(this PropsBuilder<IonActionSheet> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("ios"));
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd(this PropsBuilder<IonActionSheet> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("md"));
    }

    /// <summary>
    /// Subtitle for the action sheet.
    /// </summary>
    public static void SetSubHeader(this PropsBuilder<IonActionSheet> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("subHeader"), value);
    }
    /// <summary>
    /// Subtitle for the action sheet.
    /// </summary>
    public static void SetSubHeader(this PropsBuilder<IonActionSheet> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("subHeader"), b.Const(value));
    }

    /// <summary>
    /// If `true`, the action sheet will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility).
    /// </summary>
    public static void SetTranslucent(this PropsBuilder<IonActionSheet> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("translucent"), b.Const(true));
    }

    /// <summary>
    /// An ID corresponding to the trigger element that causes the action sheet to open when clicked.
    /// </summary>
    public static void SetTrigger(this PropsBuilder<IonActionSheet> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("trigger"), value);
    }
    /// <summary>
    /// An ID corresponding to the trigger element that causes the action sheet to open when clicked.
    /// </summary>
    public static void SetTrigger(this PropsBuilder<IonActionSheet> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("trigger"), b.Const(value));
    }

    /// <summary>
    /// Emitted after the action sheet has dismissed. Shorthand for ionActionSheetDidDismiss.
    /// </summary>
    public static void OnDidDismiss<TModel>(this PropsBuilder<IonActionSheet> b, Var<HyperType.Action<TModel, OverlayEventDetail>> action)
    {
        b.OnEventAction("ondidDismiss", action, "detail");
    }
    /// <summary>
    /// Emitted after the action sheet has dismissed. Shorthand for ionActionSheetDidDismiss.
    /// </summary>
    public static void OnDidDismiss<TModel>(this PropsBuilder<IonActionSheet> b, System.Func<SyntaxBuilder, Var<TModel>, Var<OverlayEventDetail>, Var<TModel>> action)
    {
        b.OnEventAction("ondidDismiss", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// Emitted after the action sheet has presented. Shorthand for ionActionSheetWillDismiss.
    /// </summary>
    public static void OnDidPresent<TModel>(this PropsBuilder<IonActionSheet> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("ondidPresent", action);
    }
    /// <summary>
    /// Emitted after the action sheet has presented. Shorthand for ionActionSheetWillDismiss.
    /// </summary>
    public static void OnDidPresent<TModel>(this PropsBuilder<IonActionSheet> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("ondidPresent", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the action sheet has dismissed.
    /// </summary>
    public static void OnIonActionSheetDidDismiss<TModel>(this PropsBuilder<IonActionSheet> b, Var<HyperType.Action<TModel, OverlayEventDetail>> action)
    {
        b.OnEventAction("onionActionSheetDidDismiss", action, "detail");
    }
    /// <summary>
    /// Emitted after the action sheet has dismissed.
    /// </summary>
    public static void OnIonActionSheetDidDismiss<TModel>(this PropsBuilder<IonActionSheet> b, System.Func<SyntaxBuilder, Var<TModel>, Var<OverlayEventDetail>, Var<TModel>> action)
    {
        b.OnEventAction("onionActionSheetDidDismiss", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// Emitted after the action sheet has presented.
    /// </summary>
    public static void OnIonActionSheetDidPresent<TModel>(this PropsBuilder<IonActionSheet> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onionActionSheetDidPresent", action);
    }
    /// <summary>
    /// Emitted after the action sheet has presented.
    /// </summary>
    public static void OnIonActionSheetDidPresent<TModel>(this PropsBuilder<IonActionSheet> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onionActionSheetDidPresent", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted before the action sheet has dismissed.
    /// </summary>
    public static void OnIonActionSheetWillDismiss<TModel>(this PropsBuilder<IonActionSheet> b, Var<HyperType.Action<TModel, OverlayEventDetail>> action)
    {
        b.OnEventAction("onionActionSheetWillDismiss", action, "detail");
    }
    /// <summary>
    /// Emitted before the action sheet has dismissed.
    /// </summary>
    public static void OnIonActionSheetWillDismiss<TModel>(this PropsBuilder<IonActionSheet> b, System.Func<SyntaxBuilder, Var<TModel>, Var<OverlayEventDetail>, Var<TModel>> action)
    {
        b.OnEventAction("onionActionSheetWillDismiss", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// Emitted before the action sheet has presented.
    /// </summary>
    public static void OnIonActionSheetWillPresent<TModel>(this PropsBuilder<IonActionSheet> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onionActionSheetWillPresent", action);
    }
    /// <summary>
    /// Emitted before the action sheet has presented.
    /// </summary>
    public static void OnIonActionSheetWillPresent<TModel>(this PropsBuilder<IonActionSheet> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onionActionSheetWillPresent", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted before the action sheet has dismissed. Shorthand for ionActionSheetWillDismiss.
    /// </summary>
    public static void OnWillDismiss<TModel>(this PropsBuilder<IonActionSheet> b, Var<HyperType.Action<TModel, OverlayEventDetail>> action)
    {
        b.OnEventAction("onwillDismiss", action, "detail");
    }
    /// <summary>
    /// Emitted before the action sheet has dismissed. Shorthand for ionActionSheetWillDismiss.
    /// </summary>
    public static void OnWillDismiss<TModel>(this PropsBuilder<IonActionSheet> b, System.Func<SyntaxBuilder, Var<TModel>, Var<OverlayEventDetail>, Var<TModel>> action)
    {
        b.OnEventAction("onwillDismiss", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// Emitted before the action sheet has presented. Shorthand for ionActionSheetWillPresent.
    /// </summary>
    public static void OnWillPresent<TModel>(this PropsBuilder<IonActionSheet> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onwillPresent", action);
    }
    /// <summary>
    /// Emitted before the action sheet has presented. Shorthand for ionActionSheetWillPresent.
    /// </summary>
    public static void OnWillPresent<TModel>(this PropsBuilder<IonActionSheet> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onwillPresent", b.MakeAction(action));
    }

}

