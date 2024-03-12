using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Ionic;


public partial class IonModal
{
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
    /// If `true`, the modal will animate.
    /// </summary>
    public static void SetAnimated(this PropsBuilder<IonModal> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("animated"), b.Const(true));
    }

    /// <summary>
    /// A decimal value between 0 and 1 that indicates the point after which the backdrop will begin to fade in when using a sheet modal. Prior to this point, the backdrop will be hidden and the content underneath the sheet can be interacted with. This value is exclusive meaning the backdrop will become active after the value specified.
    /// </summary>
    public static void SetBackdropBreakpoint(this PropsBuilder<IonModal> b, Var<int> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("backdropBreakpoint"), value);
    }
    /// <summary>
    /// A decimal value between 0 and 1 that indicates the point after which the backdrop will begin to fade in when using a sheet modal. Prior to this point, the backdrop will be hidden and the content underneath the sheet can be interacted with. This value is exclusive meaning the backdrop will become active after the value specified.
    /// </summary>
    public static void SetBackdropBreakpoint(this PropsBuilder<IonModal> b, int value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("backdropBreakpoint"), b.Const(value));
    }

    /// <summary>
    /// If `true`, the modal will be dismissed when the backdrop is clicked.
    /// </summary>
    public static void SetBackdropDismiss(this PropsBuilder<IonModal> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("backdropDismiss"), b.Const(true));
    }

    /// <summary>
    /// The breakpoints to use when creating a sheet modal. Each value in the array must be a decimal between 0 and 1 where 0 indicates the modal is fully closed and 1 indicates the modal is fully open. Values are relative to the height of the modal, not the height of the screen. One of the values in this array must be the value of the `initialBreakpoint` property. For example: [0, .25, .5, 1]
    /// </summary>
    public static void SetBreakpoints(this PropsBuilder<IonModal> b, Var<List<int>> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<int>>("breakpoints"), value);
    }
    /// <summary>
    /// The breakpoints to use when creating a sheet modal. Each value in the array must be a decimal between 0 and 1 where 0 indicates the modal is fully closed and 1 indicates the modal is fully open. Values are relative to the height of the modal, not the height of the screen. One of the values in this array must be the value of the `initialBreakpoint` property. For example: [0, .25, .5, 1]
    /// </summary>
    public static void SetBreakpoints(this PropsBuilder<IonModal> b, List<int> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<int>>("breakpoints"), b.Const(value));
    }

    /// <summary>
    /// Determines whether or not a modal can dismiss when calling the `dismiss` method.  If the value is `true` or the value's function returns `true`, the modal will close when trying to dismiss. If the value is `false` or the value's function returns `false`, the modal will not close when trying to dismiss.  See https://ionicframework.com/docs/troubleshooting/runtime#accessing-this if you need to access `this` from within the callback.
    /// </summary>
    public static void SetCanDismiss(this PropsBuilder<IonModal> b, Var<Func<object,string,object>> f)
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<object,string,object>>("canDismiss"), f);
    }
    /// <summary>
    /// Determines whether or not a modal can dismiss when calling the `dismiss` method.  If the value is `true` or the value's function returns `true`, the modal will close when trying to dismiss. If the value is `false` or the value's function returns `false`, the modal will not close when trying to dismiss.  See https://ionicframework.com/docs/troubleshooting/runtime#accessing-this if you need to access `this` from within the callback.
    /// </summary>
    public static void SetCanDismiss(this PropsBuilder<IonModal> b, Func<SyntaxBuilder,Var<object>,Var<string>,Var<object>> f)
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<object,string,object>>("canDismiss"), b.Def(f));
    }
    /// <summary>
    /// Determines whether or not a modal can dismiss when calling the `dismiss` method.  If the value is `true` or the value's function returns `true`, the modal will close when trying to dismiss. If the value is `false` or the value's function returns `false`, the modal will not close when trying to dismiss.  See https://ionicframework.com/docs/troubleshooting/runtime#accessing-this if you need to access `this` from within the callback.
    /// </summary>
    public static void SetCanDismiss(this PropsBuilder<IonModal> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("canDismiss"), b.Const(true));
    }

    /// <summary>
    /// Animation to use when the modal is presented.
    /// </summary>
    public static void SetEnterAnimation(this PropsBuilder<IonModal> b, Var<Func<object,object,Animation>> f)
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<object,object,Animation>>("enterAnimation"), f);
    }
    /// <summary>
    /// Animation to use when the modal is presented.
    /// </summary>
    public static void SetEnterAnimation(this PropsBuilder<IonModal> b, Func<SyntaxBuilder,Var<object>,Var<object>,Var<Animation>> f)
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<object,object,Animation>>("enterAnimation"), b.Def(f));
    }

    /// <summary>
    /// The horizontal line that displays at the top of a sheet modal. It is `true` by default when setting the `breakpoints` and `initialBreakpoint` properties.
    /// </summary>
    public static void SetHandle(this PropsBuilder<IonModal> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("handle"), b.Const(true));
    }

    /// <summary>
    /// The interaction behavior for the sheet modal when the handle is pressed.  Defaults to `"none"`, which  means the modal will not change size or position when the handle is pressed. Set to `"cycle"` to let the modal cycle between available breakpoints when pressed.  Handle behavior is unavailable when the `handle` property is set to `false` or when the `breakpoints` property is not set (using a fullscreen or card modal).
    /// </summary>
    public static void SetHandleBehaviorCycle(this PropsBuilder<IonModal> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("handleBehavior"), b.Const("cycle"));
    }
    /// <summary>
    /// The interaction behavior for the sheet modal when the handle is pressed.  Defaults to `"none"`, which  means the modal will not change size or position when the handle is pressed. Set to `"cycle"` to let the modal cycle between available breakpoints when pressed.  Handle behavior is unavailable when the `handle` property is set to `false` or when the `breakpoints` property is not set (using a fullscreen or card modal).
    /// </summary>
    public static void SetHandleBehaviorNone(this PropsBuilder<IonModal> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("handleBehavior"), b.Const("none"));
    }

    /// <summary>
    /// Additional attributes to pass to the modal.
    /// </summary>
    public static void SetHtmlAttributes(this PropsBuilder<IonModal> b, Var<object> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<object>("htmlAttributes"), value);
    }
    /// <summary>
    /// Additional attributes to pass to the modal.
    /// </summary>
    public static void SetHtmlAttributes(this PropsBuilder<IonModal> b, object value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<object>("htmlAttributes"), b.Const(value));
    }

    /// <summary>
    /// A decimal value between 0 and 1 that indicates the initial point the modal will open at when creating a sheet modal. This value must also be listed in the `breakpoints` array.
    /// </summary>
    public static void SetInitialBreakpoint(this PropsBuilder<IonModal> b, Var<int> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("initialBreakpoint"), value);
    }
    /// <summary>
    /// A decimal value between 0 and 1 that indicates the initial point the modal will open at when creating a sheet modal. This value must also be listed in the `breakpoints` array.
    /// </summary>
    public static void SetInitialBreakpoint(this PropsBuilder<IonModal> b, int value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("initialBreakpoint"), b.Const(value));
    }

    /// <summary>
    /// If `true`, the modal will open. If `false`, the modal will close. Use this if you need finer grained control over presentation, otherwise just use the modalController or the `trigger` property. Note: `isOpen` will not automatically be set back to `false` when the modal dismisses. You will need to do that in your code.
    /// </summary>
    public static void SetIsOpen(this PropsBuilder<IonModal> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("isOpen"), b.Const(true));
    }

    /// <summary>
    /// If `true`, the component passed into `ion-modal` will automatically be mounted when the modal is created. The component will remain mounted even when the modal is dismissed. However, the component will be destroyed when the modal is destroyed. This property is not reactive and should only be used when initially creating a modal.  Note: This feature only applies to inline modals in JavaScript frameworks such as Angular, React, and Vue.
    /// </summary>
    public static void SetKeepContentsMounted(this PropsBuilder<IonModal> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("keepContentsMounted"), b.Const(true));
    }

    /// <summary>
    /// If `true`, the keyboard will be automatically dismissed when the overlay is presented.
    /// </summary>
    public static void SetKeyboardClose(this PropsBuilder<IonModal> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("keyboardClose"), b.Const(true));
    }

    /// <summary>
    /// Animation to use when the modal is dismissed.
    /// </summary>
    public static void SetLeaveAnimation(this PropsBuilder<IonModal> b, Var<Func<object,object,Animation>> f)
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<object,object,Animation>>("leaveAnimation"), f);
    }
    /// <summary>
    /// Animation to use when the modal is dismissed.
    /// </summary>
    public static void SetLeaveAnimation(this PropsBuilder<IonModal> b, Func<SyntaxBuilder,Var<object>,Var<object>,Var<Animation>> f)
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<object,object,Animation>>("leaveAnimation"), b.Def(f));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos(this PropsBuilder<IonModal> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("ios"));
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd(this PropsBuilder<IonModal> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("md"));
    }

    /// <summary>
    /// The element that presented the modal. This is used for card presentation effects and for stacking multiple modals on top of each other. Only applies in iOS mode.
    /// </summary>
    public static void SetPresentingElement(this PropsBuilder<IonModal> b, Var<HTMLElement> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HTMLElement>("presentingElement"), value);
    }
    /// <summary>
    /// The element that presented the modal. This is used for card presentation effects and for stacking multiple modals on top of each other. Only applies in iOS mode.
    /// </summary>
    public static void SetPresentingElement(this PropsBuilder<IonModal> b, HTMLElement value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HTMLElement>("presentingElement"), b.Const(value));
    }

    /// <summary>
    /// If `true`, a backdrop will be displayed behind the modal. This property controls whether or not the backdrop darkens the screen when the modal is presented. It does not control whether or not the backdrop is active or present in the DOM.
    /// </summary>
    public static void SetShowBackdrop(this PropsBuilder<IonModal> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("showBackdrop"), b.Const(true));
    }

    /// <summary>
    /// An ID corresponding to the trigger element that causes the modal to open when clicked.
    /// </summary>
    public static void SetTrigger(this PropsBuilder<IonModal> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("trigger"), value);
    }
    /// <summary>
    /// An ID corresponding to the trigger element that causes the modal to open when clicked.
    /// </summary>
    public static void SetTrigger(this PropsBuilder<IonModal> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("trigger"), b.Const(value));
    }

    /// <summary>
    /// Emitted after the modal has dismissed. Shorthand for ionModalDidDismiss.
    /// </summary>
    public static void OnDidDismiss<TModel>(this PropsBuilder<IonModal> b, Var<HyperType.Action<TModel, OverlayEventDetail>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<OverlayEventDetail>("detail"));
            return b.MakeActionDescriptor<TModel, OverlayEventDetail>(action, value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("ondidDismiss"), eventAction);
    }
    /// <summary>
    /// Emitted after the modal has dismissed. Shorthand for ionModalDidDismiss.
    /// </summary>
    public static void OnDidDismiss<TModel>(this PropsBuilder<IonModal> b, System.Func<SyntaxBuilder, Var<TModel>, Var<OverlayEventDetail>, Var<TModel>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<OverlayEventDetail>("detail"));
            return b.MakeActionDescriptor<TModel, OverlayEventDetail>(b.MakeAction(action), value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("ondidDismiss"), eventAction);
    }

    /// <summary>
    /// Emitted after the modal has presented. Shorthand for ionModalDidPresent.
    /// </summary>
    public static void OnDidPresent<TModel>(this PropsBuilder<IonModal> b, Var<HyperType.Action<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel>>("ondidPresent"), action);
    }
    /// <summary>
    /// Emitted after the modal has presented. Shorthand for ionModalDidPresent.
    /// </summary>
    public static void OnDidPresent<TModel>(this PropsBuilder<IonModal> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel>>("ondidPresent"), b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the modal breakpoint has changed.
    /// </summary>
    public static void OnIonBreakpointDidChange<TModel>(this PropsBuilder<IonModal> b, Var<HyperType.Action<TModel, ModalBreakpointChangeEventDetail>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<ModalBreakpointChangeEventDetail>("detail"));
            return b.MakeActionDescriptor<TModel, ModalBreakpointChangeEventDetail>(action, value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onionBreakpointDidChange"), eventAction);
    }
    /// <summary>
    /// Emitted after the modal breakpoint has changed.
    /// </summary>
    public static void OnIonBreakpointDidChange<TModel>(this PropsBuilder<IonModal> b, System.Func<SyntaxBuilder, Var<TModel>, Var<ModalBreakpointChangeEventDetail>, Var<TModel>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<ModalBreakpointChangeEventDetail>("detail"));
            return b.MakeActionDescriptor<TModel, ModalBreakpointChangeEventDetail>(b.MakeAction(action), value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onionBreakpointDidChange"), eventAction);
    }

    /// <summary>
    /// Emitted after the modal has dismissed.
    /// </summary>
    public static void OnIonModalDidDismiss<TModel>(this PropsBuilder<IonModal> b, Var<HyperType.Action<TModel, OverlayEventDetail>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<OverlayEventDetail>("detail"));
            return b.MakeActionDescriptor<TModel, OverlayEventDetail>(action, value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onionModalDidDismiss"), eventAction);
    }
    /// <summary>
    /// Emitted after the modal has dismissed.
    /// </summary>
    public static void OnIonModalDidDismiss<TModel>(this PropsBuilder<IonModal> b, System.Func<SyntaxBuilder, Var<TModel>, Var<OverlayEventDetail>, Var<TModel>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<OverlayEventDetail>("detail"));
            return b.MakeActionDescriptor<TModel, OverlayEventDetail>(b.MakeAction(action), value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onionModalDidDismiss"), eventAction);
    }

    /// <summary>
    /// Emitted after the modal has presented.
    /// </summary>
    public static void OnIonModalDidPresent<TModel>(this PropsBuilder<IonModal> b, Var<HyperType.Action<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel>>("onionModalDidPresent"), action);
    }
    /// <summary>
    /// Emitted after the modal has presented.
    /// </summary>
    public static void OnIonModalDidPresent<TModel>(this PropsBuilder<IonModal> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel>>("onionModalDidPresent"), b.MakeAction(action));
    }

    /// <summary>
    /// Emitted before the modal has dismissed.
    /// </summary>
    public static void OnIonModalWillDismiss<TModel>(this PropsBuilder<IonModal> b, Var<HyperType.Action<TModel, OverlayEventDetail>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<OverlayEventDetail>("detail"));
            return b.MakeActionDescriptor<TModel, OverlayEventDetail>(action, value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onionModalWillDismiss"), eventAction);
    }
    /// <summary>
    /// Emitted before the modal has dismissed.
    /// </summary>
    public static void OnIonModalWillDismiss<TModel>(this PropsBuilder<IonModal> b, System.Func<SyntaxBuilder, Var<TModel>, Var<OverlayEventDetail>, Var<TModel>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<OverlayEventDetail>("detail"));
            return b.MakeActionDescriptor<TModel, OverlayEventDetail>(b.MakeAction(action), value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onionModalWillDismiss"), eventAction);
    }

    /// <summary>
    /// Emitted before the modal has presented.
    /// </summary>
    public static void OnIonModalWillPresent<TModel>(this PropsBuilder<IonModal> b, Var<HyperType.Action<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel>>("onionModalWillPresent"), action);
    }
    /// <summary>
    /// Emitted before the modal has presented.
    /// </summary>
    public static void OnIonModalWillPresent<TModel>(this PropsBuilder<IonModal> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel>>("onionModalWillPresent"), b.MakeAction(action));
    }

    /// <summary>
    /// Emitted before the modal has dismissed. Shorthand for ionModalWillDismiss.
    /// </summary>
    public static void OnWillDismiss<TModel>(this PropsBuilder<IonModal> b, Var<HyperType.Action<TModel, OverlayEventDetail>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<OverlayEventDetail>("detail"));
            return b.MakeActionDescriptor<TModel, OverlayEventDetail>(action, value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onwillDismiss"), eventAction);
    }
    /// <summary>
    /// Emitted before the modal has dismissed. Shorthand for ionModalWillDismiss.
    /// </summary>
    public static void OnWillDismiss<TModel>(this PropsBuilder<IonModal> b, System.Func<SyntaxBuilder, Var<TModel>, Var<OverlayEventDetail>, Var<TModel>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<OverlayEventDetail>("detail"));
            return b.MakeActionDescriptor<TModel, OverlayEventDetail>(b.MakeAction(action), value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onwillDismiss"), eventAction);
    }

    /// <summary>
    /// Emitted before the modal has presented. Shorthand for ionModalWillPresent.
    /// </summary>
    public static void OnWillPresent<TModel>(this PropsBuilder<IonModal> b, Var<HyperType.Action<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel>>("onwillPresent"), action);
    }
    /// <summary>
    /// Emitted before the modal has presented. Shorthand for ionModalWillPresent.
    /// </summary>
    public static void OnWillPresent<TModel>(this PropsBuilder<IonModal> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel>>("onwillPresent"), b.MakeAction(action));
    }

}

