using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Ionic;


public partial class IonLoading : IonComponent
{
    public IonLoading() : base("ion-loading") { }
    /// <summary>
    /// If `true`, the loading indicator will animate.
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
    /// If `true`, the loading indicator will be dismissed when the backdrop is clicked.
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
    /// Number of milliseconds to wait before dismissing the loading indicator.
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
    /// Animation to use when the loading indicator is presented.
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
    /// Additional attributes to pass to the loader.
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
    /// If `true`, the loading indicator will open. If `false`, the loading indicator will close. Use this if you need finer grained control over presentation, otherwise just use the loadingController or the `trigger` property. Note: `isOpen` will not automatically be set back to `false` when the loading indicator dismisses. You will need to do that in your code.
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
    /// Animation to use when the loading indicator is dismissed.
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
    /// Optional text content to display in the loading indicator.  This property accepts custom HTML as a string. Content is parsed as plaintext by default. `innerHTMLTemplatesEnabled` must be set to `true` in the Ionic config before custom HTML can be used.
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
    /// If `true`, a backdrop will be displayed behind the loading indicator.
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
    /// The name of the spinner to display.
    /// </summary>
    public string spinner
    {
        get
        {
            return this.GetTag().GetAttribute<string>("spinner");
        }
        set
        {
            this.GetTag().SetAttribute("spinner", value.ToString());
        }
    }

    /// <summary>
    /// If `true`, the loading indicator will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility).
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
    /// An ID corresponding to the trigger element that causes the loading indicator to open when clicked.
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
        /// Dismiss the loading overlay after it has been presented.
        /// <para>(data?: any, role?: string) =&gt; Promise&lt;boolean&gt;</para>
        /// <para>data Any data to emit in the dismiss events.</para>
        /// <para>role The role of the element that is dismissing the loading. This can be useful in a button handler for determining which button was clicked to dismiss the loading. Some examples include: ``"cancel"`, `"destructive"`, "selected"`, and `"backdrop"`.  This is a no-op if the overlay has not been presented yet. If you want to remove an overlay from the DOM that was never presented, use the [remove](https://developer.mozilla.org/en-US/docs/Web/API/Element/remove) method.</para>
        /// </summary>
        public const string Dismiss = "dismiss";
        /// <summary> 
        /// Returns a promise that resolves when the loading did dismiss.
        /// <para>&lt;T = any&gt;() =&gt; Promise&lt;OverlayEventDetail&lt;T&gt;&gt;</para>
        /// </summary>
        public const string OnDidDismiss = "onDidDismiss";
        /// <summary> 
        /// Returns a promise that resolves when the loading will dismiss.
        /// <para>&lt;T = any&gt;() =&gt; Promise&lt;OverlayEventDetail&lt;T&gt;&gt;</para>
        /// </summary>
        public const string OnWillDismiss = "onWillDismiss";
        /// <summary> 
        /// Present the loading overlay after it has been created.
        /// <para>() =&gt; Promise&lt;void&gt;</para>
        /// </summary>
        public const string Present = "present";
    }
}

public static partial class IonLoadingControl
{
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonLoading(this LayoutBuilder b, Action<PropsBuilder<IonLoading>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-loading", buildProps, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonLoading(this LayoutBuilder b, Action<PropsBuilder<IonLoading>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-loading", buildProps, children);
    }
    /// <summary>
    /// If `true`, the loading indicator will animate.
    /// </summary>
    public static void SetAnimated(this PropsBuilder<IonLoading> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("animated"), b.Const(true));
    }

    /// <summary>
    /// If `true`, the loading indicator will be dismissed when the backdrop is clicked.
    /// </summary>
    public static void SetBackdropDismiss(this PropsBuilder<IonLoading> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("backdropDismiss"), b.Const(true));
    }

    /// <summary>
    /// Additional classes to apply for custom CSS. If multiple classes are provided they should be separated by spaces.
    /// </summary>
    public static void SetCssClass(this PropsBuilder<IonLoading> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("cssClass"), value);
    }
    /// <summary>
    /// Additional classes to apply for custom CSS. If multiple classes are provided they should be separated by spaces.
    /// </summary>
    public static void SetCssClass(this PropsBuilder<IonLoading> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("cssClass"), b.Const(value));
    }
    /// <summary>
    /// Additional classes to apply for custom CSS. If multiple classes are provided they should be separated by spaces.
    /// </summary>
    public static void SetCssClass(this PropsBuilder<IonLoading> b, Var<List<string>> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<string>>("cssClass"), value);
    }
    /// <summary>
    /// Additional classes to apply for custom CSS. If multiple classes are provided they should be separated by spaces.
    /// </summary>
    public static void SetCssClass(this PropsBuilder<IonLoading> b, List<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<string>>("cssClass"), b.Const(value));
    }

    /// <summary>
    /// Number of milliseconds to wait before dismissing the loading indicator.
    /// </summary>
    public static void SetDuration(this PropsBuilder<IonLoading> b, Var<int> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("duration"), value);
    }
    /// <summary>
    /// Number of milliseconds to wait before dismissing the loading indicator.
    /// </summary>
    public static void SetDuration(this PropsBuilder<IonLoading> b, int value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("duration"), b.Const(value));
    }

    /// <summary>
    /// Animation to use when the loading indicator is presented.
    /// </summary>
    public static void SetEnterAnimation(this PropsBuilder<IonLoading> b, Var<Func<object,object,Animation>> f)
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<object,object,Animation>>("enterAnimation"), f);
    }
    /// <summary>
    /// Animation to use when the loading indicator is presented.
    /// </summary>
    public static void SetEnterAnimation(this PropsBuilder<IonLoading> b, Func<SyntaxBuilder,Var<object>,Var<object>,Var<Animation>> f)
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<object,object,Animation>>("enterAnimation"), b.Def(f));
    }

    /// <summary>
    /// Additional attributes to pass to the loader.
    /// </summary>
    public static void SetHtmlAttributes(this PropsBuilder<IonLoading> b, Var<object> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<object>("htmlAttributes"), value);
    }
    /// <summary>
    /// Additional attributes to pass to the loader.
    /// </summary>
    public static void SetHtmlAttributes(this PropsBuilder<IonLoading> b, object value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<object>("htmlAttributes"), b.Const(value));
    }

    /// <summary>
    /// If `true`, the loading indicator will open. If `false`, the loading indicator will close. Use this if you need finer grained control over presentation, otherwise just use the loadingController or the `trigger` property. Note: `isOpen` will not automatically be set back to `false` when the loading indicator dismisses. You will need to do that in your code.
    /// </summary>
    public static void SetIsOpen(this PropsBuilder<IonLoading> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("isOpen"), b.Const(true));
    }

    /// <summary>
    /// If `true`, the keyboard will be automatically dismissed when the overlay is presented.
    /// </summary>
    public static void SetKeyboardClose(this PropsBuilder<IonLoading> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("keyboardClose"), b.Const(true));
    }

    /// <summary>
    /// Animation to use when the loading indicator is dismissed.
    /// </summary>
    public static void SetLeaveAnimation(this PropsBuilder<IonLoading> b, Var<Func<object,object,Animation>> f)
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<object,object,Animation>>("leaveAnimation"), f);
    }
    /// <summary>
    /// Animation to use when the loading indicator is dismissed.
    /// </summary>
    public static void SetLeaveAnimation(this PropsBuilder<IonLoading> b, Func<SyntaxBuilder,Var<object>,Var<object>,Var<Animation>> f)
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<object,object,Animation>>("leaveAnimation"), b.Def(f));
    }

    /// <summary>
    /// Optional text content to display in the loading indicator.  This property accepts custom HTML as a string. Content is parsed as plaintext by default. `innerHTMLTemplatesEnabled` must be set to `true` in the Ionic config before custom HTML can be used.
    /// </summary>
    public static void SetMessage(this PropsBuilder<IonLoading> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("message"), value);
    }
    /// <summary>
    /// Optional text content to display in the loading indicator.  This property accepts custom HTML as a string. Content is parsed as plaintext by default. `innerHTMLTemplatesEnabled` must be set to `true` in the Ionic config before custom HTML can be used.
    /// </summary>
    public static void SetMessage(this PropsBuilder<IonLoading> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("message"), b.Const(value));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos(this PropsBuilder<IonLoading> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("ios"));
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd(this PropsBuilder<IonLoading> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("md"));
    }

    /// <summary>
    /// If `true`, a backdrop will be displayed behind the loading indicator.
    /// </summary>
    public static void SetShowBackdrop(this PropsBuilder<IonLoading> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("showBackdrop"), b.Const(true));
    }

    /// <summary>
    /// The name of the spinner to display.
    /// </summary>
    public static void SetSpinnerBubbles(this PropsBuilder<IonLoading> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("spinner"), b.Const("bubbles"));
    }
    /// <summary>
    /// The name of the spinner to display.
    /// </summary>
    public static void SetSpinnerCircles(this PropsBuilder<IonLoading> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("spinner"), b.Const("circles"));
    }
    /// <summary>
    /// The name of the spinner to display.
    /// </summary>
    public static void SetSpinnerCircular(this PropsBuilder<IonLoading> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("spinner"), b.Const("circular"));
    }
    /// <summary>
    /// The name of the spinner to display.
    /// </summary>
    public static void SetSpinnerCrescent(this PropsBuilder<IonLoading> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("spinner"), b.Const("crescent"));
    }
    /// <summary>
    /// The name of the spinner to display.
    /// </summary>
    public static void SetSpinnerDots(this PropsBuilder<IonLoading> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("spinner"), b.Const("dots"));
    }
    /// <summary>
    /// The name of the spinner to display.
    /// </summary>
    public static void SetSpinnerLines(this PropsBuilder<IonLoading> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("spinner"), b.Const("lines"));
    }
    /// <summary>
    /// The name of the spinner to display.
    /// </summary>
    public static void SetSpinnerLinesSharp(this PropsBuilder<IonLoading> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("spinner"), b.Const("lines-sharp"));
    }
    /// <summary>
    /// The name of the spinner to display.
    /// </summary>
    public static void SetSpinnerLinesSharpSmall(this PropsBuilder<IonLoading> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("spinner"), b.Const("lines-sharp-small"));
    }
    /// <summary>
    /// The name of the spinner to display.
    /// </summary>
    public static void SetSpinnerLinesSmall(this PropsBuilder<IonLoading> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("spinner"), b.Const("lines-small"));
    }

    /// <summary>
    /// If `true`, the loading indicator will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility).
    /// </summary>
    public static void SetTranslucent(this PropsBuilder<IonLoading> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("translucent"), b.Const(true));
    }

    /// <summary>
    /// An ID corresponding to the trigger element that causes the loading indicator to open when clicked.
    /// </summary>
    public static void SetTrigger(this PropsBuilder<IonLoading> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("trigger"), value);
    }
    /// <summary>
    /// An ID corresponding to the trigger element that causes the loading indicator to open when clicked.
    /// </summary>
    public static void SetTrigger(this PropsBuilder<IonLoading> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("trigger"), b.Const(value));
    }

    /// <summary>
    /// Emitted after the loading indicator has dismissed. Shorthand for ionLoadingDidDismiss.
    /// </summary>
    public static void OnDidDismiss<TModel>(this PropsBuilder<IonLoading> b, Var<HyperType.Action<TModel, OverlayEventDetail>> action)
    {
        b.OnEventAction("ondidDismiss", action, "detail");
    }
    /// <summary>
    /// Emitted after the loading indicator has dismissed. Shorthand for ionLoadingDidDismiss.
    /// </summary>
    public static void OnDidDismiss<TModel>(this PropsBuilder<IonLoading> b, System.Func<SyntaxBuilder, Var<TModel>, Var<OverlayEventDetail>, Var<TModel>> action)
    {
        b.OnEventAction("ondidDismiss", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// Emitted after the loading indicator has presented. Shorthand for ionLoadingWillDismiss.
    /// </summary>
    public static void OnDidPresent<TModel>(this PropsBuilder<IonLoading> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("ondidPresent", action);
    }
    /// <summary>
    /// Emitted after the loading indicator has presented. Shorthand for ionLoadingWillDismiss.
    /// </summary>
    public static void OnDidPresent<TModel>(this PropsBuilder<IonLoading> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("ondidPresent", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the loading has dismissed.
    /// </summary>
    public static void OnIonLoadingDidDismiss<TModel>(this PropsBuilder<IonLoading> b, Var<HyperType.Action<TModel, OverlayEventDetail>> action)
    {
        b.OnEventAction("onionLoadingDidDismiss", action, "detail");
    }
    /// <summary>
    /// Emitted after the loading has dismissed.
    /// </summary>
    public static void OnIonLoadingDidDismiss<TModel>(this PropsBuilder<IonLoading> b, System.Func<SyntaxBuilder, Var<TModel>, Var<OverlayEventDetail>, Var<TModel>> action)
    {
        b.OnEventAction("onionLoadingDidDismiss", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// Emitted after the loading has presented.
    /// </summary>
    public static void OnIonLoadingDidPresent<TModel>(this PropsBuilder<IonLoading> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onionLoadingDidPresent", action);
    }
    /// <summary>
    /// Emitted after the loading has presented.
    /// </summary>
    public static void OnIonLoadingDidPresent<TModel>(this PropsBuilder<IonLoading> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onionLoadingDidPresent", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted before the loading has dismissed.
    /// </summary>
    public static void OnIonLoadingWillDismiss<TModel>(this PropsBuilder<IonLoading> b, Var<HyperType.Action<TModel, OverlayEventDetail>> action)
    {
        b.OnEventAction("onionLoadingWillDismiss", action, "detail");
    }
    /// <summary>
    /// Emitted before the loading has dismissed.
    /// </summary>
    public static void OnIonLoadingWillDismiss<TModel>(this PropsBuilder<IonLoading> b, System.Func<SyntaxBuilder, Var<TModel>, Var<OverlayEventDetail>, Var<TModel>> action)
    {
        b.OnEventAction("onionLoadingWillDismiss", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// Emitted before the loading has presented.
    /// </summary>
    public static void OnIonLoadingWillPresent<TModel>(this PropsBuilder<IonLoading> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onionLoadingWillPresent", action);
    }
    /// <summary>
    /// Emitted before the loading has presented.
    /// </summary>
    public static void OnIonLoadingWillPresent<TModel>(this PropsBuilder<IonLoading> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onionLoadingWillPresent", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted before the loading indicator has dismissed. Shorthand for ionLoadingWillDismiss.
    /// </summary>
    public static void OnWillDismiss<TModel>(this PropsBuilder<IonLoading> b, Var<HyperType.Action<TModel, OverlayEventDetail>> action)
    {
        b.OnEventAction("onwillDismiss", action, "detail");
    }
    /// <summary>
    /// Emitted before the loading indicator has dismissed. Shorthand for ionLoadingWillDismiss.
    /// </summary>
    public static void OnWillDismiss<TModel>(this PropsBuilder<IonLoading> b, System.Func<SyntaxBuilder, Var<TModel>, Var<OverlayEventDetail>, Var<TModel>> action)
    {
        b.OnEventAction("onwillDismiss", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// Emitted before the loading indicator has presented. Shorthand for ionLoadingWillPresent.
    /// </summary>
    public static void OnWillPresent<TModel>(this PropsBuilder<IonLoading> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onwillPresent", action);
    }
    /// <summary>
    /// Emitted before the loading indicator has presented. Shorthand for ionLoadingWillPresent.
    /// </summary>
    public static void OnWillPresent<TModel>(this PropsBuilder<IonLoading> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onwillPresent", b.MakeAction(action));
    }

}

