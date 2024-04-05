using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Ionic;


public partial class IonAlert : IonComponent
{
    public IonAlert() : base("ion-alert") { }
    /// <summary>
    /// If `true`, the alert will animate.
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
    /// If `true`, the alert will be dismissed when the backdrop is clicked.
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
    /// Animation to use when the alert is presented.
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
    /// The main title in the heading of the alert.
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
    /// Additional attributes to pass to the alert.
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
    /// If `true`, the alert will open. If `false`, the alert will close. Use this if you need finer grained control over presentation, otherwise just use the alertController or the `trigger` property. Note: `isOpen` will not automatically be set back to `false` when the alert dismisses. You will need to do that in your code.
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
    /// Animation to use when the alert is dismissed.
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
    /// The main message to be displayed in the alert. `message` can accept either plaintext or HTML as a string. To display characters normally reserved for HTML, they must be escaped. For example `<Ionic>` would become `&lt;Ionic&gt;`  For more information: [Security Documentation](https://ionicframework.com/docs/faq/security)  This property accepts custom HTML as a string. Content is parsed as plaintext by default. `innerHTMLTemplatesEnabled` must be set to `true` in the Ionic config before custom HTML can be used.
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
    /// The subtitle in the heading of the alert. Displayed under the title.
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
    /// If `true`, the alert will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility).
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
    /// An ID corresponding to the trigger element that causes the alert to open when clicked.
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
        /// Dismiss the alert overlay after it has been presented.
        /// <para>(data?: any, role?: string) =&gt; Promise&lt;boolean&gt;</para>
        /// <para>data Any data to emit in the dismiss events.</para>
        /// <para>role The role of the element that is dismissing the alert. This can be useful in a button handler for determining which button was clicked to dismiss the alert. Some examples include: ``"cancel"`, `"destructive"`, "selected"`, and `"backdrop"`.  This is a no-op if the overlay has not been presented yet. If you want to remove an overlay from the DOM that was never presented, use the [remove](https://developer.mozilla.org/en-US/docs/Web/API/Element/remove) method.</para>
        /// </summary>
        public const string Dismiss = "dismiss";
        /// <summary> 
        /// Returns a promise that resolves when the alert did dismiss.
        /// <para>&lt;T = any&gt;() =&gt; Promise&lt;OverlayEventDetail&lt;T&gt;&gt;</para>
        /// </summary>
        public const string OnDidDismiss = "onDidDismiss";
        /// <summary> 
        /// Returns a promise that resolves when the alert will dismiss.
        /// <para>&lt;T = any&gt;() =&gt; Promise&lt;OverlayEventDetail&lt;T&gt;&gt;</para>
        /// </summary>
        public const string OnWillDismiss = "onWillDismiss";
        /// <summary> 
        /// Present the alert overlay after it has been created.
        /// <para>() =&gt; Promise&lt;void&gt;</para>
        /// </summary>
        public const string Present = "present";
    }
}

public static partial class IonAlertControl
{
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonAlert(this LayoutBuilder b, Action<PropsBuilder<IonAlert>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-alert", buildProps, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonAlert(this LayoutBuilder b, Action<PropsBuilder<IonAlert>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-alert", buildProps, children);
    }
    /// <summary>
    /// If `true`, the alert will animate.
    /// </summary>
    public static void SetAnimated(this PropsBuilder<IonAlert> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("animated"), b.Const(true));
    }

    /// <summary>
    /// If `true`, the alert will be dismissed when the backdrop is clicked.
    /// </summary>
    public static void SetBackdropDismiss(this PropsBuilder<IonAlert> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("backdropDismiss"), b.Const(true));
    }

    /// <summary>
    /// Array of buttons to be added to the alert.
    /// </summary>
    public static void SetButtons(this PropsBuilder<IonAlert> b, Var<List<string>> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<string>>("buttons"), value);
    }
    /// <summary>
    /// Array of buttons to be added to the alert.
    /// </summary>
    public static void SetButtons(this PropsBuilder<IonAlert> b, List<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<string>>("buttons"), b.Const(value));
    }
    /// <summary>
    /// Array of buttons to be added to the alert.
    /// </summary>
    public static void SetButtons(this PropsBuilder<IonAlert> b, Var<List<AlertButton>> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<AlertButton>>("buttons"), value);
    }
    /// <summary>
    /// Array of buttons to be added to the alert.
    /// </summary>
    public static void SetButtons(this PropsBuilder<IonAlert> b, List<AlertButton> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<AlertButton>>("buttons"), b.Const(value));
    }

    /// <summary>
    /// Additional classes to apply for custom CSS. If multiple classes are provided they should be separated by spaces.
    /// </summary>
    public static void SetCssClass(this PropsBuilder<IonAlert> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("cssClass"), value);
    }
    /// <summary>
    /// Additional classes to apply for custom CSS. If multiple classes are provided they should be separated by spaces.
    /// </summary>
    public static void SetCssClass(this PropsBuilder<IonAlert> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("cssClass"), b.Const(value));
    }
    /// <summary>
    /// Additional classes to apply for custom CSS. If multiple classes are provided they should be separated by spaces.
    /// </summary>
    public static void SetCssClass(this PropsBuilder<IonAlert> b, Var<List<string>> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<string>>("cssClass"), value);
    }
    /// <summary>
    /// Additional classes to apply for custom CSS. If multiple classes are provided they should be separated by spaces.
    /// </summary>
    public static void SetCssClass(this PropsBuilder<IonAlert> b, List<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<string>>("cssClass"), b.Const(value));
    }

    /// <summary>
    /// Animation to use when the alert is presented.
    /// </summary>
    public static void SetEnterAnimation(this PropsBuilder<IonAlert> b, Var<Func<object,object,Animation>> f)
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<object,object,Animation>>("enterAnimation"), f);
    }
    /// <summary>
    /// Animation to use when the alert is presented.
    /// </summary>
    public static void SetEnterAnimation(this PropsBuilder<IonAlert> b, Func<SyntaxBuilder,Var<object>,Var<object>,Var<Animation>> f)
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<object,object,Animation>>("enterAnimation"), b.Def(f));
    }

    /// <summary>
    /// The main title in the heading of the alert.
    /// </summary>
    public static void SetHeader(this PropsBuilder<IonAlert> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("header"), value);
    }
    /// <summary>
    /// The main title in the heading of the alert.
    /// </summary>
    public static void SetHeader(this PropsBuilder<IonAlert> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("header"), b.Const(value));
    }

    /// <summary>
    /// Additional attributes to pass to the alert.
    /// </summary>
    public static void SetHtmlAttributes(this PropsBuilder<IonAlert> b, Var<object> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<object>("htmlAttributes"), value);
    }
    /// <summary>
    /// Additional attributes to pass to the alert.
    /// </summary>
    public static void SetHtmlAttributes(this PropsBuilder<IonAlert> b, object value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<object>("htmlAttributes"), b.Const(value));
    }

    /// <summary>
    /// Array of input to show in the alert.
    /// </summary>
    public static void SetInputs(this PropsBuilder<IonAlert> b, Var<List<AlertInput>> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<AlertInput>>("inputs"), value);
    }
    /// <summary>
    /// Array of input to show in the alert.
    /// </summary>
    public static void SetInputs(this PropsBuilder<IonAlert> b, List<AlertInput> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<AlertInput>>("inputs"), b.Const(value));
    }

    /// <summary>
    /// If `true`, the alert will open. If `false`, the alert will close. Use this if you need finer grained control over presentation, otherwise just use the alertController or the `trigger` property. Note: `isOpen` will not automatically be set back to `false` when the alert dismisses. You will need to do that in your code.
    /// </summary>
    public static void SetIsOpen(this PropsBuilder<IonAlert> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("isOpen"), b.Const(true));
    }

    /// <summary>
    /// If `true`, the keyboard will be automatically dismissed when the overlay is presented.
    /// </summary>
    public static void SetKeyboardClose(this PropsBuilder<IonAlert> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("keyboardClose"), b.Const(true));
    }

    /// <summary>
    /// Animation to use when the alert is dismissed.
    /// </summary>
    public static void SetLeaveAnimation(this PropsBuilder<IonAlert> b, Var<Func<object,object,Animation>> f)
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<object,object,Animation>>("leaveAnimation"), f);
    }
    /// <summary>
    /// Animation to use when the alert is dismissed.
    /// </summary>
    public static void SetLeaveAnimation(this PropsBuilder<IonAlert> b, Func<SyntaxBuilder,Var<object>,Var<object>,Var<Animation>> f)
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<object,object,Animation>>("leaveAnimation"), b.Def(f));
    }

    /// <summary>
    /// The main message to be displayed in the alert. `message` can accept either plaintext or HTML as a string. To display characters normally reserved for HTML, they must be escaped. For example `<Ionic>` would become `&lt;Ionic&gt;`  For more information: [Security Documentation](https://ionicframework.com/docs/faq/security)  This property accepts custom HTML as a string. Content is parsed as plaintext by default. `innerHTMLTemplatesEnabled` must be set to `true` in the Ionic config before custom HTML can be used.
    /// </summary>
    public static void SetMessage(this PropsBuilder<IonAlert> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("message"), value);
    }
    /// <summary>
    /// The main message to be displayed in the alert. `message` can accept either plaintext or HTML as a string. To display characters normally reserved for HTML, they must be escaped. For example `<Ionic>` would become `&lt;Ionic&gt;`  For more information: [Security Documentation](https://ionicframework.com/docs/faq/security)  This property accepts custom HTML as a string. Content is parsed as plaintext by default. `innerHTMLTemplatesEnabled` must be set to `true` in the Ionic config before custom HTML can be used.
    /// </summary>
    public static void SetMessage(this PropsBuilder<IonAlert> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("message"), b.Const(value));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos(this PropsBuilder<IonAlert> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("ios"));
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd(this PropsBuilder<IonAlert> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("md"));
    }

    /// <summary>
    /// The subtitle in the heading of the alert. Displayed under the title.
    /// </summary>
    public static void SetSubHeader(this PropsBuilder<IonAlert> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("subHeader"), value);
    }
    /// <summary>
    /// The subtitle in the heading of the alert. Displayed under the title.
    /// </summary>
    public static void SetSubHeader(this PropsBuilder<IonAlert> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("subHeader"), b.Const(value));
    }

    /// <summary>
    /// If `true`, the alert will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility).
    /// </summary>
    public static void SetTranslucent(this PropsBuilder<IonAlert> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("translucent"), b.Const(true));
    }

    /// <summary>
    /// An ID corresponding to the trigger element that causes the alert to open when clicked.
    /// </summary>
    public static void SetTrigger(this PropsBuilder<IonAlert> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("trigger"), value);
    }
    /// <summary>
    /// An ID corresponding to the trigger element that causes the alert to open when clicked.
    /// </summary>
    public static void SetTrigger(this PropsBuilder<IonAlert> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("trigger"), b.Const(value));
    }

    /// <summary>
    /// Emitted after the alert has dismissed. Shorthand for ionAlertDidDismiss.
    /// </summary>
    public static void OnDidDismiss<TModel>(this PropsBuilder<IonAlert> b, Var<HyperType.Action<TModel, OverlayEventDetail>> action)
    {
        b.OnEventAction("ondidDismiss", action, "detail");
    }
    /// <summary>
    /// Emitted after the alert has dismissed. Shorthand for ionAlertDidDismiss.
    /// </summary>
    public static void OnDidDismiss<TModel>(this PropsBuilder<IonAlert> b, System.Func<SyntaxBuilder, Var<TModel>, Var<OverlayEventDetail>, Var<TModel>> action)
    {
        b.OnEventAction("ondidDismiss", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// Emitted after the alert has presented. Shorthand for ionAlertWillDismiss.
    /// </summary>
    public static void OnDidPresent<TModel>(this PropsBuilder<IonAlert> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("ondidPresent", action);
    }
    /// <summary>
    /// Emitted after the alert has presented. Shorthand for ionAlertWillDismiss.
    /// </summary>
    public static void OnDidPresent<TModel>(this PropsBuilder<IonAlert> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("ondidPresent", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the alert has dismissed.
    /// </summary>
    public static void OnIonAlertDidDismiss<TModel>(this PropsBuilder<IonAlert> b, Var<HyperType.Action<TModel, OverlayEventDetail>> action)
    {
        b.OnEventAction("onionAlertDidDismiss", action, "detail");
    }
    /// <summary>
    /// Emitted after the alert has dismissed.
    /// </summary>
    public static void OnIonAlertDidDismiss<TModel>(this PropsBuilder<IonAlert> b, System.Func<SyntaxBuilder, Var<TModel>, Var<OverlayEventDetail>, Var<TModel>> action)
    {
        b.OnEventAction("onionAlertDidDismiss", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// Emitted after the alert has presented.
    /// </summary>
    public static void OnIonAlertDidPresent<TModel>(this PropsBuilder<IonAlert> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onionAlertDidPresent", action);
    }
    /// <summary>
    /// Emitted after the alert has presented.
    /// </summary>
    public static void OnIonAlertDidPresent<TModel>(this PropsBuilder<IonAlert> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onionAlertDidPresent", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted before the alert has dismissed.
    /// </summary>
    public static void OnIonAlertWillDismiss<TModel>(this PropsBuilder<IonAlert> b, Var<HyperType.Action<TModel, OverlayEventDetail>> action)
    {
        b.OnEventAction("onionAlertWillDismiss", action, "detail");
    }
    /// <summary>
    /// Emitted before the alert has dismissed.
    /// </summary>
    public static void OnIonAlertWillDismiss<TModel>(this PropsBuilder<IonAlert> b, System.Func<SyntaxBuilder, Var<TModel>, Var<OverlayEventDetail>, Var<TModel>> action)
    {
        b.OnEventAction("onionAlertWillDismiss", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// Emitted before the alert has presented.
    /// </summary>
    public static void OnIonAlertWillPresent<TModel>(this PropsBuilder<IonAlert> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onionAlertWillPresent", action);
    }
    /// <summary>
    /// Emitted before the alert has presented.
    /// </summary>
    public static void OnIonAlertWillPresent<TModel>(this PropsBuilder<IonAlert> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onionAlertWillPresent", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted before the alert has dismissed. Shorthand for ionAlertWillDismiss.
    /// </summary>
    public static void OnWillDismiss<TModel>(this PropsBuilder<IonAlert> b, Var<HyperType.Action<TModel, OverlayEventDetail>> action)
    {
        b.OnEventAction("onwillDismiss", action, "detail");
    }
    /// <summary>
    /// Emitted before the alert has dismissed. Shorthand for ionAlertWillDismiss.
    /// </summary>
    public static void OnWillDismiss<TModel>(this PropsBuilder<IonAlert> b, System.Func<SyntaxBuilder, Var<TModel>, Var<OverlayEventDetail>, Var<TModel>> action)
    {
        b.OnEventAction("onwillDismiss", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// Emitted before the alert has presented. Shorthand for ionAlertWillPresent.
    /// </summary>
    public static void OnWillPresent<TModel>(this PropsBuilder<IonAlert> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onwillPresent", action);
    }
    /// <summary>
    /// Emitted before the alert has presented. Shorthand for ionAlertWillPresent.
    /// </summary>
    public static void OnWillPresent<TModel>(this PropsBuilder<IonAlert> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onwillPresent", b.MakeAction(action));
    }

}

