using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Ionic;


public partial class IonModal : IonComponent
{
    public IonModal() : base("ion-modal") { }
    /// <summary> 
    /// Content is placed inside of the `.modal-content` element.
    /// </summary>
    public static class Slot
    {
    }
    public static class Method
    {
        /// <summary> 
        /// Dismiss the modal overlay after it has been presented.
        /// <para>(data?: any, role?: string) =&gt; Promise&lt;boolean&gt;</para>
        /// <para>data Any data to emit in the dismiss events.</para>
        /// <para>role The role of the element that is dismissing the modal. For example, 'cancel' or 'backdrop'.  This is a no-op if the overlay has not been presented yet. If you want to remove an overlay from the DOM that was never presented, use the [remove](https://developer.mozilla.org/en-US/docs/Web/API/Element/remove) method.</para>
        /// </summary>
        public const string Dismiss = "dismiss";
        /// <summary> 
        /// Returns the current breakpoint of a sheet style modal
        /// <para>() =&gt; Promise&lt;number | undefined&gt;</para>
        /// </summary>
        public const string GetCurrentBreakpoint = "getCurrentBreakpoint";
        /// <summary> 
        /// Returns a promise that resolves when the modal did dismiss.
        /// <para>&lt;T = any&gt;() =&gt; Promise&lt;OverlayEventDetail&lt;T&gt;&gt;</para>
        /// </summary>
        public const string OnDidDismiss = "onDidDismiss";
        /// <summary> 
        /// Returns a promise that resolves when the modal will dismiss.
        /// <para>&lt;T = any&gt;() =&gt; Promise&lt;OverlayEventDetail&lt;T&gt;&gt;</para>
        /// </summary>
        public const string OnWillDismiss = "onWillDismiss";
        /// <summary> 
        /// Present the modal overlay after it has been created.
        /// <para>() =&gt; Promise&lt;void&gt;</para>
        /// </summary>
        public const string Present = "present";
        /// <summary> 
        /// Move a sheet style modal to a specific breakpoint. The breakpoint value must be a value defined in your `breakpoints` array.
        /// <para>(breakpoint: number) =&gt; Promise&lt;void&gt;</para>
        /// <para>breakpoint </para>
        /// </summary>
        public const string SetCurrentBreakpoint = "setCurrentBreakpoint";
    }
}

public static partial class IonModalControl
{
    /// <summary>
    /// 
    /// </summary>
    public static IHtmlNode IonModal(this HtmlBuilder b, Action<AttributesBuilder<IonModal>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("ion-modal", buildAttributes, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static IHtmlNode IonModal(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("ion-modal", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// If `true`, the modal will animate.
    /// </summary>
    public static void SetAnimated(this AttributesBuilder<IonModal> b)
    {
        b.SetAttribute("animated", "");
    }
    /// <summary>
    /// If `true`, the modal will animate.
    /// </summary>
    public static void SetAnimated(this AttributesBuilder<IonModal> b, bool value)
    {
        if (value) b.SetAttribute("animated", "");
    }

    /// <summary>
    /// A decimal value between 0 and 1 that indicates the point after which the backdrop will begin to fade in when using a sheet modal. Prior to this point, the backdrop will be hidden and the content underneath the sheet can be interacted with. This value is exclusive meaning the backdrop will become active after the value specified.
    /// </summary>
    public static void SetBackdropBreakpoint(this AttributesBuilder<IonModal> b, string value)
    {
        b.SetAttribute("backdrop-breakpoint", value);
    }

    /// <summary>
    /// If `true`, the modal will be dismissed when the backdrop is clicked.
    /// </summary>
    public static void SetBackdropDismiss(this AttributesBuilder<IonModal> b)
    {
        b.SetAttribute("backdrop-dismiss", "");
    }
    /// <summary>
    /// If `true`, the modal will be dismissed when the backdrop is clicked.
    /// </summary>
    public static void SetBackdropDismiss(this AttributesBuilder<IonModal> b, bool value)
    {
        if (value) b.SetAttribute("backdrop-dismiss", "");
    }

    /// <summary>
    /// Determines whether or not a modal can dismiss when calling the `dismiss` method.  If the value is `true` or the value's function returns `true`, the modal will close when trying to dismiss. If the value is `false` or the value's function returns `false`, the modal will not close when trying to dismiss.  See https://ionicframework.com/docs/troubleshooting/runtime#accessing-this if you need to access `this` from within the callback.
    /// </summary>
    public static void SetCanDismiss(this AttributesBuilder<IonModal> b, string value)
    {
        b.SetAttribute("can-dismiss", value);
    }

    /// <summary>
    /// The horizontal line that displays at the top of a sheet modal. It is `true` by default when setting the `breakpoints` and `initialBreakpoint` properties.
    /// </summary>
    public static void SetHandle(this AttributesBuilder<IonModal> b)
    {
        b.SetAttribute("handle", "");
    }
    /// <summary>
    /// The horizontal line that displays at the top of a sheet modal. It is `true` by default when setting the `breakpoints` and `initialBreakpoint` properties.
    /// </summary>
    public static void SetHandle(this AttributesBuilder<IonModal> b, bool value)
    {
        if (value) b.SetAttribute("handle", "");
    }

    /// <summary>
    /// The interaction behavior for the sheet modal when the handle is pressed.  Defaults to `"none"`, which  means the modal will not change size or position when the handle is pressed. Set to `"cycle"` to let the modal cycle between available breakpoints when pressed.  Handle behavior is unavailable when the `handle` property is set to `false` or when the `breakpoints` property is not set (using a fullscreen or card modal).
    /// </summary>
    public static void SetHandleBehavior(this AttributesBuilder<IonModal> b, string value)
    {
        b.SetAttribute("handle-behavior", value);
    }
    /// <summary>
    /// The interaction behavior for the sheet modal when the handle is pressed.  Defaults to `"none"`, which  means the modal will not change size or position when the handle is pressed. Set to `"cycle"` to let the modal cycle between available breakpoints when pressed.  Handle behavior is unavailable when the `handle` property is set to `false` or when the `breakpoints` property is not set (using a fullscreen or card modal).
    /// </summary>
    public static void SetHandleBehaviorCycle(this AttributesBuilder<IonModal> b)
    {
        b.SetAttribute("handle-behavior", "cycle");
    }
    /// <summary>
    /// The interaction behavior for the sheet modal when the handle is pressed.  Defaults to `"none"`, which  means the modal will not change size or position when the handle is pressed. Set to `"cycle"` to let the modal cycle between available breakpoints when pressed.  Handle behavior is unavailable when the `handle` property is set to `false` or when the `breakpoints` property is not set (using a fullscreen or card modal).
    /// </summary>
    public static void SetHandleBehaviorNone(this AttributesBuilder<IonModal> b)
    {
        b.SetAttribute("handle-behavior", "none");
    }

    /// <summary>
    /// A decimal value between 0 and 1 that indicates the initial point the modal will open at when creating a sheet modal. This value must also be listed in the `breakpoints` array.
    /// </summary>
    public static void SetInitialBreakpoint(this AttributesBuilder<IonModal> b, string value)
    {
        b.SetAttribute("initial-breakpoint", value);
    }

    /// <summary>
    /// If `true`, the modal will open. If `false`, the modal will close. Use this if you need finer grained control over presentation, otherwise just use the modalController or the `trigger` property. Note: `isOpen` will not automatically be set back to `false` when the modal dismisses. You will need to do that in your code.
    /// </summary>
    public static void SetIsOpen(this AttributesBuilder<IonModal> b)
    {
        b.SetAttribute("is-open", "");
    }
    /// <summary>
    /// If `true`, the modal will open. If `false`, the modal will close. Use this if you need finer grained control over presentation, otherwise just use the modalController or the `trigger` property. Note: `isOpen` will not automatically be set back to `false` when the modal dismisses. You will need to do that in your code.
    /// </summary>
    public static void SetIsOpen(this AttributesBuilder<IonModal> b, bool value)
    {
        if (value) b.SetAttribute("is-open", "");
    }

    /// <summary>
    /// If `true`, the component passed into `ion-modal` will automatically be mounted when the modal is created. The component will remain mounted even when the modal is dismissed. However, the component will be destroyed when the modal is destroyed. This property is not reactive and should only be used when initially creating a modal.  Note: This feature only applies to inline modals in JavaScript frameworks such as Angular, React, and Vue.
    /// </summary>
    public static void SetKeepContentsMounted(this AttributesBuilder<IonModal> b)
    {
        b.SetAttribute("keep-contents-mounted", "");
    }
    /// <summary>
    /// If `true`, the component passed into `ion-modal` will automatically be mounted when the modal is created. The component will remain mounted even when the modal is dismissed. However, the component will be destroyed when the modal is destroyed. This property is not reactive and should only be used when initially creating a modal.  Note: This feature only applies to inline modals in JavaScript frameworks such as Angular, React, and Vue.
    /// </summary>
    public static void SetKeepContentsMounted(this AttributesBuilder<IonModal> b, bool value)
    {
        if (value) b.SetAttribute("keep-contents-mounted", "");
    }

    /// <summary>
    /// If `true`, the keyboard will be automatically dismissed when the overlay is presented.
    /// </summary>
    public static void SetKeyboardClose(this AttributesBuilder<IonModal> b)
    {
        b.SetAttribute("keyboard-close", "");
    }
    /// <summary>
    /// If `true`, the keyboard will be automatically dismissed when the overlay is presented.
    /// </summary>
    public static void SetKeyboardClose(this AttributesBuilder<IonModal> b, bool value)
    {
        if (value) b.SetAttribute("keyboard-close", "");
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetMode(this AttributesBuilder<IonModal> b, string value)
    {
        b.SetAttribute("mode", value);
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos(this AttributesBuilder<IonModal> b)
    {
        b.SetAttribute("mode", "ios");
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd(this AttributesBuilder<IonModal> b)
    {
        b.SetAttribute("mode", "md");
    }

    /// <summary>
    /// If `true`, a backdrop will be displayed behind the modal. This property controls whether or not the backdrop darkens the screen when the modal is presented. It does not control whether or not the backdrop is active or present in the DOM.
    /// </summary>
    public static void SetShowBackdrop(this AttributesBuilder<IonModal> b)
    {
        b.SetAttribute("show-backdrop", "");
    }
    /// <summary>
    /// If `true`, a backdrop will be displayed behind the modal. This property controls whether or not the backdrop darkens the screen when the modal is presented. It does not control whether or not the backdrop is active or present in the DOM.
    /// </summary>
    public static void SetShowBackdrop(this AttributesBuilder<IonModal> b, bool value)
    {
        if (value) b.SetAttribute("show-backdrop", "");
    }

    /// <summary>
    /// An ID corresponding to the trigger element that causes the modal to open when clicked.
    /// </summary>
    public static void SetTrigger(this AttributesBuilder<IonModal> b, string value)
    {
        b.SetAttribute("trigger", value);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonModal(this LayoutBuilder b, Action<PropsBuilder<IonModal>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-modal", buildProps, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonModal(this LayoutBuilder b, Action<PropsBuilder<IonModal>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-modal", buildProps, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonModal(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-modal", children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonModal(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-modal", children);
    }
    /// <summary>
    /// If `true`, the modal will animate.
    /// </summary>
    public static void SetAnimated<T>(this PropsBuilder<T> b) where T: IonModal
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("animated"), b.Const(true));
    }

    /// <summary>
    /// A decimal value between 0 and 1 that indicates the point after which the backdrop will begin to fade in when using a sheet modal. Prior to this point, the backdrop will be hidden and the content underneath the sheet can be interacted with. This value is exclusive meaning the backdrop will become active after the value specified.
    /// </summary>
    public static void SetBackdropBreakpoint<T>(this PropsBuilder<T> b, Var<int> value) where T: IonModal
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("backdropBreakpoint"), value);
    }
    /// <summary>
    /// A decimal value between 0 and 1 that indicates the point after which the backdrop will begin to fade in when using a sheet modal. Prior to this point, the backdrop will be hidden and the content underneath the sheet can be interacted with. This value is exclusive meaning the backdrop will become active after the value specified.
    /// </summary>
    public static void SetBackdropBreakpoint<T>(this PropsBuilder<T> b, int value) where T: IonModal
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("backdropBreakpoint"), b.Const(value));
    }

    /// <summary>
    /// If `true`, the modal will be dismissed when the backdrop is clicked.
    /// </summary>
    public static void SetBackdropDismiss<T>(this PropsBuilder<T> b) where T: IonModal
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("backdropDismiss"), b.Const(true));
    }

    /// <summary>
    /// The breakpoints to use when creating a sheet modal. Each value in the array must be a decimal between 0 and 1 where 0 indicates the modal is fully closed and 1 indicates the modal is fully open. Values are relative to the height of the modal, not the height of the screen. One of the values in this array must be the value of the `initialBreakpoint` property. For example: [0, .25, .5, 1]
    /// </summary>
    public static void SetBreakpoints<T>(this PropsBuilder<T> b, Var<List<int>> value) where T: IonModal
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<int>>("breakpoints"), value);
    }
    /// <summary>
    /// The breakpoints to use when creating a sheet modal. Each value in the array must be a decimal between 0 and 1 where 0 indicates the modal is fully closed and 1 indicates the modal is fully open. Values are relative to the height of the modal, not the height of the screen. One of the values in this array must be the value of the `initialBreakpoint` property. For example: [0, .25, .5, 1]
    /// </summary>
    public static void SetBreakpoints<T>(this PropsBuilder<T> b, List<int> value) where T: IonModal
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<int>>("breakpoints"), b.Const(value));
    }

    /// <summary>
    /// Determines whether or not a modal can dismiss when calling the `dismiss` method.  If the value is `true` or the value's function returns `true`, the modal will close when trying to dismiss. If the value is `false` or the value's function returns `false`, the modal will not close when trying to dismiss.  See https://ionicframework.com/docs/troubleshooting/runtime#accessing-this if you need to access `this` from within the callback.
    /// </summary>
    public static void SetCanDismiss<T>(this PropsBuilder<T> b, Var<Func<object,string,DynamicObject>> f) where T: IonModal
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<object,string,DynamicObject>>("canDismiss"), f);
    }
    /// <summary>
    /// Determines whether or not a modal can dismiss when calling the `dismiss` method.  If the value is `true` or the value's function returns `true`, the modal will close when trying to dismiss. If the value is `false` or the value's function returns `false`, the modal will not close when trying to dismiss.  See https://ionicframework.com/docs/troubleshooting/runtime#accessing-this if you need to access `this` from within the callback.
    /// </summary>
    public static void SetCanDismiss<T>(this PropsBuilder<T> b, Func<SyntaxBuilder,Var<object>,Var<string>,Var<DynamicObject>> f) where T: IonModal
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<object,string,DynamicObject>>("canDismiss"), b.Def(f));
    }
    /// <summary>
    /// Determines whether or not a modal can dismiss when calling the `dismiss` method.  If the value is `true` or the value's function returns `true`, the modal will close when trying to dismiss. If the value is `false` or the value's function returns `false`, the modal will not close when trying to dismiss.  See https://ionicframework.com/docs/troubleshooting/runtime#accessing-this if you need to access `this` from within the callback.
    /// </summary>
    public static void SetCanDismiss<T>(this PropsBuilder<T> b) where T: IonModal
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("canDismiss"), b.Const(true));
    }

    /// <summary>
    /// Animation to use when the modal is presented.
    /// </summary>
    public static void SetEnterAnimation<T>(this PropsBuilder<T> b, Var<Func<object,object,Animation>> f) where T: IonModal
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<object,object,Animation>>("enterAnimation"), f);
    }
    /// <summary>
    /// Animation to use when the modal is presented.
    /// </summary>
    public static void SetEnterAnimation<T>(this PropsBuilder<T> b, Func<SyntaxBuilder,Var<object>,Var<object>,Var<Animation>> f) where T: IonModal
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<object,object,Animation>>("enterAnimation"), b.Def(f));
    }

    /// <summary>
    /// The horizontal line that displays at the top of a sheet modal. It is `true` by default when setting the `breakpoints` and `initialBreakpoint` properties.
    /// </summary>
    public static void SetHandle<T>(this PropsBuilder<T> b) where T: IonModal
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("handle"), b.Const(true));
    }

    /// <summary>
    /// The interaction behavior for the sheet modal when the handle is pressed.  Defaults to `"none"`, which  means the modal will not change size or position when the handle is pressed. Set to `"cycle"` to let the modal cycle between available breakpoints when pressed.  Handle behavior is unavailable when the `handle` property is set to `false` or when the `breakpoints` property is not set (using a fullscreen or card modal).
    /// </summary>
    public static void SetHandleBehaviorCycle<T>(this PropsBuilder<T> b) where T: IonModal
    {
        b.SetDynamic(b.Props, DynamicProperty.String("handleBehavior"), b.Const("cycle"));
    }
    /// <summary>
    /// The interaction behavior for the sheet modal when the handle is pressed.  Defaults to `"none"`, which  means the modal will not change size or position when the handle is pressed. Set to `"cycle"` to let the modal cycle between available breakpoints when pressed.  Handle behavior is unavailable when the `handle` property is set to `false` or when the `breakpoints` property is not set (using a fullscreen or card modal).
    /// </summary>
    public static void SetHandleBehaviorNone<T>(this PropsBuilder<T> b) where T: IonModal
    {
        b.SetDynamic(b.Props, DynamicProperty.String("handleBehavior"), b.Const("none"));
    }

    /// <summary>
    /// Additional attributes to pass to the modal.
    /// </summary>
    public static void SetHtmlAttributes<T>(this PropsBuilder<T> b, Var<DynamicObject> value) where T: IonModal
    {
        b.SetDynamic(b.Props, new DynamicProperty<DynamicObject>("htmlAttributes"), value);
    }
    /// <summary>
    /// Additional attributes to pass to the modal.
    /// </summary>
    public static void SetHtmlAttributes<T>(this PropsBuilder<T> b, DynamicObject value) where T: IonModal
    {
        b.SetDynamic(b.Props, new DynamicProperty<DynamicObject>("htmlAttributes"), b.Const(value));
    }

    /// <summary>
    /// A decimal value between 0 and 1 that indicates the initial point the modal will open at when creating a sheet modal. This value must also be listed in the `breakpoints` array.
    /// </summary>
    public static void SetInitialBreakpoint<T>(this PropsBuilder<T> b, Var<int> value) where T: IonModal
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("initialBreakpoint"), value);
    }
    /// <summary>
    /// A decimal value between 0 and 1 that indicates the initial point the modal will open at when creating a sheet modal. This value must also be listed in the `breakpoints` array.
    /// </summary>
    public static void SetInitialBreakpoint<T>(this PropsBuilder<T> b, int value) where T: IonModal
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("initialBreakpoint"), b.Const(value));
    }

    /// <summary>
    /// If `true`, the modal will open. If `false`, the modal will close. Use this if you need finer grained control over presentation, otherwise just use the modalController or the `trigger` property. Note: `isOpen` will not automatically be set back to `false` when the modal dismisses. You will need to do that in your code.
    /// </summary>
    public static void SetIsOpen<T>(this PropsBuilder<T> b) where T: IonModal
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("isOpen"), b.Const(true));
    }

    /// <summary>
    /// If `true`, the component passed into `ion-modal` will automatically be mounted when the modal is created. The component will remain mounted even when the modal is dismissed. However, the component will be destroyed when the modal is destroyed. This property is not reactive and should only be used when initially creating a modal.  Note: This feature only applies to inline modals in JavaScript frameworks such as Angular, React, and Vue.
    /// </summary>
    public static void SetKeepContentsMounted<T>(this PropsBuilder<T> b) where T: IonModal
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("keepContentsMounted"), b.Const(true));
    }

    /// <summary>
    /// If `true`, the keyboard will be automatically dismissed when the overlay is presented.
    /// </summary>
    public static void SetKeyboardClose<T>(this PropsBuilder<T> b) where T: IonModal
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("keyboardClose"), b.Const(true));
    }

    /// <summary>
    /// Animation to use when the modal is dismissed.
    /// </summary>
    public static void SetLeaveAnimation<T>(this PropsBuilder<T> b, Var<Func<object,object,Animation>> f) where T: IonModal
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<object,object,Animation>>("leaveAnimation"), f);
    }
    /// <summary>
    /// Animation to use when the modal is dismissed.
    /// </summary>
    public static void SetLeaveAnimation<T>(this PropsBuilder<T> b, Func<SyntaxBuilder,Var<object>,Var<object>,Var<Animation>> f) where T: IonModal
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<object,object,Animation>>("leaveAnimation"), b.Def(f));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos<T>(this PropsBuilder<T> b) where T: IonModal
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("ios"));
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd<T>(this PropsBuilder<T> b) where T: IonModal
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("md"));
    }

    /// <summary>
    /// The element that presented the modal. This is used for card presentation effects and for stacking multiple modals on top of each other. Only applies in iOS mode.
    /// </summary>
    public static void SetPresentingElement<T>(this PropsBuilder<T> b, Var<HTMLElement> value) where T: IonModal
    {
        b.SetDynamic(b.Props, new DynamicProperty<HTMLElement>("presentingElement"), value);
    }
    /// <summary>
    /// The element that presented the modal. This is used for card presentation effects and for stacking multiple modals on top of each other. Only applies in iOS mode.
    /// </summary>
    public static void SetPresentingElement<T>(this PropsBuilder<T> b, HTMLElement value) where T: IonModal
    {
        b.SetDynamic(b.Props, new DynamicProperty<HTMLElement>("presentingElement"), b.Const(value));
    }

    /// <summary>
    /// If `true`, a backdrop will be displayed behind the modal. This property controls whether or not the backdrop darkens the screen when the modal is presented. It does not control whether or not the backdrop is active or present in the DOM.
    /// </summary>
    public static void SetShowBackdrop<T>(this PropsBuilder<T> b) where T: IonModal
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("showBackdrop"), b.Const(true));
    }

    /// <summary>
    /// An ID corresponding to the trigger element that causes the modal to open when clicked.
    /// </summary>
    public static void SetTrigger<T>(this PropsBuilder<T> b, Var<string> value) where T: IonModal
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("trigger"), value);
    }
    /// <summary>
    /// An ID corresponding to the trigger element that causes the modal to open when clicked.
    /// </summary>
    public static void SetTrigger<T>(this PropsBuilder<T> b, string value) where T: IonModal
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("trigger"), b.Const(value));
    }

    /// <summary>
    /// Emitted after the modal has dismissed. Shorthand for ionModalDidDismiss.
    /// </summary>
    public static void OnDidDismiss<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, OverlayEventDetail>> action) where TComponent: IonModal
    {
        b.OnEventAction("ondidDismiss", action, "detail");
    }
    /// <summary>
    /// Emitted after the modal has dismissed. Shorthand for ionModalDidDismiss.
    /// </summary>
    public static void OnDidDismiss<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<OverlayEventDetail>, Var<TModel>> action) where TComponent: IonModal
    {
        b.OnEventAction("ondidDismiss", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// Emitted after the modal has presented. Shorthand for ionModalDidPresent.
    /// </summary>
    public static void OnDidPresent<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonModal
    {
        b.OnEventAction("ondidPresent", action);
    }
    /// <summary>
    /// Emitted after the modal has presented. Shorthand for ionModalDidPresent.
    /// </summary>
    public static void OnDidPresent<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonModal
    {
        b.OnEventAction("ondidPresent", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the modal breakpoint has changed.
    /// </summary>
    public static void OnIonBreakpointDidChange<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, ModalBreakpointChangeEventDetail>> action) where TComponent: IonModal
    {
        b.OnEventAction("onionBreakpointDidChange", action, "detail");
    }
    /// <summary>
    /// Emitted after the modal breakpoint has changed.
    /// </summary>
    public static void OnIonBreakpointDidChange<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<ModalBreakpointChangeEventDetail>, Var<TModel>> action) where TComponent: IonModal
    {
        b.OnEventAction("onionBreakpointDidChange", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// Emitted after the modal has dismissed.
    /// </summary>
    public static void OnIonModalDidDismiss<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, OverlayEventDetail>> action) where TComponent: IonModal
    {
        b.OnEventAction("onionModalDidDismiss", action, "detail");
    }
    /// <summary>
    /// Emitted after the modal has dismissed.
    /// </summary>
    public static void OnIonModalDidDismiss<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<OverlayEventDetail>, Var<TModel>> action) where TComponent: IonModal
    {
        b.OnEventAction("onionModalDidDismiss", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// Emitted after the modal has presented.
    /// </summary>
    public static void OnIonModalDidPresent<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonModal
    {
        b.OnEventAction("onionModalDidPresent", action);
    }
    /// <summary>
    /// Emitted after the modal has presented.
    /// </summary>
    public static void OnIonModalDidPresent<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonModal
    {
        b.OnEventAction("onionModalDidPresent", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted before the modal has dismissed.
    /// </summary>
    public static void OnIonModalWillDismiss<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, OverlayEventDetail>> action) where TComponent: IonModal
    {
        b.OnEventAction("onionModalWillDismiss", action, "detail");
    }
    /// <summary>
    /// Emitted before the modal has dismissed.
    /// </summary>
    public static void OnIonModalWillDismiss<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<OverlayEventDetail>, Var<TModel>> action) where TComponent: IonModal
    {
        b.OnEventAction("onionModalWillDismiss", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// Emitted before the modal has presented.
    /// </summary>
    public static void OnIonModalWillPresent<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonModal
    {
        b.OnEventAction("onionModalWillPresent", action);
    }
    /// <summary>
    /// Emitted before the modal has presented.
    /// </summary>
    public static void OnIonModalWillPresent<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonModal
    {
        b.OnEventAction("onionModalWillPresent", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted before the modal has dismissed. Shorthand for ionModalWillDismiss.
    /// </summary>
    public static void OnWillDismiss<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, OverlayEventDetail>> action) where TComponent: IonModal
    {
        b.OnEventAction("onwillDismiss", action, "detail");
    }
    /// <summary>
    /// Emitted before the modal has dismissed. Shorthand for ionModalWillDismiss.
    /// </summary>
    public static void OnWillDismiss<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<OverlayEventDetail>, Var<TModel>> action) where TComponent: IonModal
    {
        b.OnEventAction("onwillDismiss", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// Emitted before the modal has presented. Shorthand for ionModalWillPresent.
    /// </summary>
    public static void OnWillPresent<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonModal
    {
        b.OnEventAction("onwillPresent", action);
    }
    /// <summary>
    /// Emitted before the modal has presented. Shorthand for ionModalWillPresent.
    /// </summary>
    public static void OnWillPresent<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonModal
    {
        b.OnEventAction("onwillPresent", b.MakeAction(action));
    }

}

