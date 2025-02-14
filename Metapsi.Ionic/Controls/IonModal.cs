using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Ionic;


public partial class IonModal
{
    public static class Method
    {
        /// <summary>
        /// <para> Dismiss the modal overlay after it has been presented. </para>
        /// <para> (data?: any, role?: string) =&gt; Promise&lt;boolean&gt; </para>
        /// <para> data Any data to emit in the dismiss events. </para>
        /// <para> role The role of the element that is dismissing the modal. For example, 'cancel' or 'backdrop'.  This is a no-op if the overlay has not been presented yet. If you want to remove an overlay from the DOM that was never presented, use the [remove](https://developer.mozilla.org/en-US/docs/Web/API/Element/remove) method. </para>
        /// </summary>
        public const string Dismiss = "dismiss";
        /// <summary>
        /// <para> Returns the current breakpoint of a sheet style modal </para>
        /// <para> () =&gt; Promise&lt;number | undefined&gt; </para>
        /// </summary>
        public const string GetCurrentBreakpoint = "getCurrentBreakpoint";
        /// <summary>
        /// <para> Returns a promise that resolves when the modal did dismiss. </para>
        /// <para> &lt;T = any&gt;() =&gt; Promise&lt;OverlayEventDetail&lt;T&gt;&gt; </para>
        /// </summary>
        public const string OnDidDismiss = "onDidDismiss";
        /// <summary>
        /// <para> Returns a promise that resolves when the modal will dismiss. </para>
        /// <para> &lt;T = any&gt;() =&gt; Promise&lt;OverlayEventDetail&lt;T&gt;&gt; </para>
        /// </summary>
        public const string OnWillDismiss = "onWillDismiss";
        /// <summary>
        /// <para> Present the modal overlay after it has been created. </para>
        /// <para> () =&gt; Promise&lt;void&gt; </para>
        /// </summary>
        public const string Present = "present";
        /// <summary>
        /// <para> Move a sheet style modal to a specific breakpoint. The breakpoint value must be a value defined in your `breakpoints` array. </para>
        /// <para> (breakpoint: number) =&gt; Promise&lt;void&gt; </para>
        /// <para> breakpoint  </para>
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
        return b.IonicTag("ion-modal", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonModal(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.IonicTag("ion-modal", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonModal(this HtmlBuilder b, Action<AttributesBuilder<IonModal>> buildAttributes, List<IHtmlNode> children)
    {
        return b.IonicTag("ion-modal", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonModal(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.IonicTag("ion-modal", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> If `true`, the modal will animate. </para>
    /// </summary>
    public static void SetAnimated(this AttributesBuilder<IonModal> b)
    {
        b.SetAttribute("animated", "");
    }

    /// <summary>
    /// <para> If `true`, the modal will animate. </para>
    /// </summary>
    public static void SetAnimated(this AttributesBuilder<IonModal> b, bool animated)
    {
        if (animated) b.SetAttribute("animated", "");
    }

    /// <summary>
    /// <para> A decimal value between 0 and 1 that indicates the point after which the backdrop will begin to fade in when using a sheet modal. Prior to this point, the backdrop will be hidden and the content underneath the sheet can be interacted with. This value is exclusive meaning the backdrop will become active after the value specified. </para>
    /// </summary>
    public static void SetBackdropBreakpoint(this AttributesBuilder<IonModal> b, string backdropBreakpoint)
    {
        b.SetAttribute("backdrop-breakpoint", backdropBreakpoint);
    }

    /// <summary>
    /// <para> If `true`, the modal will be dismissed when the backdrop is clicked. </para>
    /// </summary>
    public static void SetBackdropDismiss(this AttributesBuilder<IonModal> b)
    {
        b.SetAttribute("backdrop-dismiss", "");
    }

    /// <summary>
    /// <para> If `true`, the modal will be dismissed when the backdrop is clicked. </para>
    /// </summary>
    public static void SetBackdropDismiss(this AttributesBuilder<IonModal> b, bool backdropDismiss)
    {
        if (backdropDismiss) b.SetAttribute("backdrop-dismiss", "");
    }

    /// <summary>
    /// <para> Determines whether or not a modal can dismiss when calling the `dismiss` method.  If the value is `true` or the value's function returns `true`, the modal will close when trying to dismiss. If the value is `false` or the value's function returns `false`, the modal will not close when trying to dismiss.  See https://ionicframework.com/docs/troubleshooting/runtime#accessing-this if you need to access `this` from within the callback. </para>
    /// </summary>
    public static void SetCanDismiss(this AttributesBuilder<IonModal> b, string canDismiss)
    {
        b.SetAttribute("can-dismiss", canDismiss);
    }

    /// <summary>
    /// <para> If `true`, focus will not be allowed to move outside of this overlay. If `false`, focus will be allowed to move outside of the overlay.  In most scenarios this property should remain set to `true`. Setting this property to `false` can cause severe accessibility issues as users relying on assistive technologies may be able to move focus into a confusing state. We recommend only setting this to `false` when absolutely necessary.  Developers may want to consider disabling focus trapping if this overlay presents a non-Ionic overlay from a 3rd party library. Developers would disable focus trapping on the Ionic overlay when presenting the 3rd party overlay and then re-enable focus trapping when dismissing the 3rd party overlay and moving focus back to the Ionic overlay. </para>
    /// </summary>
    public static void SetFocusTrap(this AttributesBuilder<IonModal> b)
    {
        b.SetAttribute("focus-trap", "");
    }

    /// <summary>
    /// <para> If `true`, focus will not be allowed to move outside of this overlay. If `false`, focus will be allowed to move outside of the overlay.  In most scenarios this property should remain set to `true`. Setting this property to `false` can cause severe accessibility issues as users relying on assistive technologies may be able to move focus into a confusing state. We recommend only setting this to `false` when absolutely necessary.  Developers may want to consider disabling focus trapping if this overlay presents a non-Ionic overlay from a 3rd party library. Developers would disable focus trapping on the Ionic overlay when presenting the 3rd party overlay and then re-enable focus trapping when dismissing the 3rd party overlay and moving focus back to the Ionic overlay. </para>
    /// </summary>
    public static void SetFocusTrap(this AttributesBuilder<IonModal> b, bool focusTrap)
    {
        if (focusTrap) b.SetAttribute("focus-trap", "");
    }

    /// <summary>
    /// <para> The horizontal line that displays at the top of a sheet modal. It is `true` by default when setting the `breakpoints` and `initialBreakpoint` properties. </para>
    /// </summary>
    public static void SetHandle(this AttributesBuilder<IonModal> b)
    {
        b.SetAttribute("handle", "");
    }

    /// <summary>
    /// <para> The horizontal line that displays at the top of a sheet modal. It is `true` by default when setting the `breakpoints` and `initialBreakpoint` properties. </para>
    /// </summary>
    public static void SetHandle(this AttributesBuilder<IonModal> b, bool handle)
    {
        if (handle) b.SetAttribute("handle", "");
    }

    /// <summary>
    /// <para> The interaction behavior for the sheet modal when the handle is pressed.  Defaults to `"none"`, which  means the modal will not change size or position when the handle is pressed. Set to `"cycle"` to let the modal cycle between available breakpoints when pressed.  Handle behavior is unavailable when the `handle` property is set to `false` or when the `breakpoints` property is not set (using a fullscreen or card modal). </para>
    /// </summary>
    public static void SetHandleBehavior(this AttributesBuilder<IonModal> b, string handleBehavior)
    {
        b.SetAttribute("handle-behavior", handleBehavior);
    }

    /// <summary>
    /// <para> The interaction behavior for the sheet modal when the handle is pressed.  Defaults to `"none"`, which  means the modal will not change size or position when the handle is pressed. Set to `"cycle"` to let the modal cycle between available breakpoints when pressed.  Handle behavior is unavailable when the `handle` property is set to `false` or when the `breakpoints` property is not set (using a fullscreen or card modal). </para>
    /// </summary>
    public static void SetHandleBehaviorCycle(this AttributesBuilder<IonModal> b)
    {
        b.SetAttribute("handle-behavior", "cycle");
    }

    /// <summary>
    /// <para> The interaction behavior for the sheet modal when the handle is pressed.  Defaults to `"none"`, which  means the modal will not change size or position when the handle is pressed. Set to `"cycle"` to let the modal cycle between available breakpoints when pressed.  Handle behavior is unavailable when the `handle` property is set to `false` or when the `breakpoints` property is not set (using a fullscreen or card modal). </para>
    /// </summary>
    public static void SetHandleBehaviorNone(this AttributesBuilder<IonModal> b)
    {
        b.SetAttribute("handle-behavior", "none");
    }

    /// <summary>
    /// <para> A decimal value between 0 and 1 that indicates the initial point the modal will open at when creating a sheet modal. This value must also be listed in the `breakpoints` array. </para>
    /// </summary>
    public static void SetInitialBreakpoint(this AttributesBuilder<IonModal> b, string initialBreakpoint)
    {
        b.SetAttribute("initial-breakpoint", initialBreakpoint);
    }

    /// <summary>
    /// <para> If `true`, the modal will open. If `false`, the modal will close. Use this if you need finer grained control over presentation, otherwise just use the modalController or the `trigger` property. Note: `isOpen` will not automatically be set back to `false` when the modal dismisses. You will need to do that in your code. </para>
    /// </summary>
    public static void SetIsOpen(this AttributesBuilder<IonModal> b)
    {
        b.SetAttribute("is-open", "");
    }

    /// <summary>
    /// <para> If `true`, the modal will open. If `false`, the modal will close. Use this if you need finer grained control over presentation, otherwise just use the modalController or the `trigger` property. Note: `isOpen` will not automatically be set back to `false` when the modal dismisses. You will need to do that in your code. </para>
    /// </summary>
    public static void SetIsOpen(this AttributesBuilder<IonModal> b, bool isOpen)
    {
        if (isOpen) b.SetAttribute("is-open", "");
    }

    /// <summary>
    /// <para> If `true`, the component passed into `ion-modal` will automatically be mounted when the modal is created. The component will remain mounted even when the modal is dismissed. However, the component will be destroyed when the modal is destroyed. This property is not reactive and should only be used when initially creating a modal.  Note: This feature only applies to inline modals in JavaScript frameworks such as Angular, React, and Vue. </para>
    /// </summary>
    public static void SetKeepContentsMounted(this AttributesBuilder<IonModal> b)
    {
        b.SetAttribute("keep-contents-mounted", "");
    }

    /// <summary>
    /// <para> If `true`, the component passed into `ion-modal` will automatically be mounted when the modal is created. The component will remain mounted even when the modal is dismissed. However, the component will be destroyed when the modal is destroyed. This property is not reactive and should only be used when initially creating a modal.  Note: This feature only applies to inline modals in JavaScript frameworks such as Angular, React, and Vue. </para>
    /// </summary>
    public static void SetKeepContentsMounted(this AttributesBuilder<IonModal> b, bool keepContentsMounted)
    {
        if (keepContentsMounted) b.SetAttribute("keep-contents-mounted", "");
    }

    /// <summary>
    /// <para> If `true`, the keyboard will be automatically dismissed when the overlay is presented. </para>
    /// </summary>
    public static void SetKeyboardClose(this AttributesBuilder<IonModal> b)
    {
        b.SetAttribute("keyboard-close", "");
    }

    /// <summary>
    /// <para> If `true`, the keyboard will be automatically dismissed when the overlay is presented. </para>
    /// </summary>
    public static void SetKeyboardClose(this AttributesBuilder<IonModal> b, bool keyboardClose)
    {
        if (keyboardClose) b.SetAttribute("keyboard-close", "");
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetMode(this AttributesBuilder<IonModal> b, string mode)
    {
        b.SetAttribute("mode", mode);
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeIos(this AttributesBuilder<IonModal> b)
    {
        b.SetAttribute("mode", "ios");
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeMd(this AttributesBuilder<IonModal> b)
    {
        b.SetAttribute("mode", "md");
    }

    /// <summary>
    /// <para> If `true`, a backdrop will be displayed behind the modal. This property controls whether or not the backdrop darkens the screen when the modal is presented. It does not control whether or not the backdrop is active or present in the DOM. </para>
    /// </summary>
    public static void SetShowBackdrop(this AttributesBuilder<IonModal> b)
    {
        b.SetAttribute("show-backdrop", "");
    }

    /// <summary>
    /// <para> If `true`, a backdrop will be displayed behind the modal. This property controls whether or not the backdrop darkens the screen when the modal is presented. It does not control whether or not the backdrop is active or present in the DOM. </para>
    /// </summary>
    public static void SetShowBackdrop(this AttributesBuilder<IonModal> b, bool showBackdrop)
    {
        if (showBackdrop) b.SetAttribute("show-backdrop", "");
    }

    /// <summary>
    /// <para> An ID corresponding to the trigger element that causes the modal to open when clicked. </para>
    /// </summary>
    public static void SetTrigger(this AttributesBuilder<IonModal> b, string trigger)
    {
        b.SetAttribute("trigger", trigger);
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
    /// <para> If `true`, the modal will animate. </para>
    /// </summary>
    public static void SetAnimated<T>(this PropsBuilder<T> b) where T: IonModal
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("animated"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, the modal will animate. </para>
    /// </summary>
    public static void SetAnimated<T>(this PropsBuilder<T> b, Var<bool> animated) where T: IonModal
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("animated"), animated);
    }

    /// <summary>
    /// <para> If `true`, the modal will animate. </para>
    /// </summary>
    public static void SetAnimated<T>(this PropsBuilder<T> b, bool animated) where T: IonModal
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("animated"), b.Const(animated));
    }


    /// <summary>
    /// <para> A decimal value between 0 and 1 that indicates the point after which the backdrop will begin to fade in when using a sheet modal. Prior to this point, the backdrop will be hidden and the content underneath the sheet can be interacted with. This value is exclusive meaning the backdrop will become active after the value specified. </para>
    /// </summary>
    public static void SetBackdropBreakpoint<T>(this PropsBuilder<T> b, Var<int> backdropBreakpoint) where T: IonModal
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("backdropBreakpoint"), backdropBreakpoint);
    }

    /// <summary>
    /// <para> A decimal value between 0 and 1 that indicates the point after which the backdrop will begin to fade in when using a sheet modal. Prior to this point, the backdrop will be hidden and the content underneath the sheet can be interacted with. This value is exclusive meaning the backdrop will become active after the value specified. </para>
    /// </summary>
    public static void SetBackdropBreakpoint<T>(this PropsBuilder<T> b, int backdropBreakpoint) where T: IonModal
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("backdropBreakpoint"), b.Const(backdropBreakpoint));
    }


    /// <summary>
    /// <para> If `true`, the modal will be dismissed when the backdrop is clicked. </para>
    /// </summary>
    public static void SetBackdropDismiss<T>(this PropsBuilder<T> b) where T: IonModal
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("backdropDismiss"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, the modal will be dismissed when the backdrop is clicked. </para>
    /// </summary>
    public static void SetBackdropDismiss<T>(this PropsBuilder<T> b, Var<bool> backdropDismiss) where T: IonModal
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("backdropDismiss"), backdropDismiss);
    }

    /// <summary>
    /// <para> If `true`, the modal will be dismissed when the backdrop is clicked. </para>
    /// </summary>
    public static void SetBackdropDismiss<T>(this PropsBuilder<T> b, bool backdropDismiss) where T: IonModal
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("backdropDismiss"), b.Const(backdropDismiss));
    }


    /// <summary>
    /// <para> The breakpoints to use when creating a sheet modal. Each value in the array must be a decimal between 0 and 1 where 0 indicates the modal is fully closed and 1 indicates the modal is fully open. Values are relative to the height of the modal, not the height of the screen. One of the values in this array must be the value of the `initialBreakpoint` property. For example: [0, .25, .5, 1] </para>
    /// </summary>
    public static void SetBreakpoints<T>(this PropsBuilder<T> b, Var<List<int>> breakpoints) where T: IonModal
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<int>>("breakpoints"), breakpoints);
    }

    /// <summary>
    /// <para> The breakpoints to use when creating a sheet modal. Each value in the array must be a decimal between 0 and 1 where 0 indicates the modal is fully closed and 1 indicates the modal is fully open. Values are relative to the height of the modal, not the height of the screen. One of the values in this array must be the value of the `initialBreakpoint` property. For example: [0, .25, .5, 1] </para>
    /// </summary>
    public static void SetBreakpoints<T>(this PropsBuilder<T> b, List<int> breakpoints) where T: IonModal
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<int>>("breakpoints"), b.Const(breakpoints));
    }


    /// <summary>
    /// <para> Determines whether or not a modal can dismiss when calling the `dismiss` method.  If the value is `true` or the value's function returns `true`, the modal will close when trying to dismiss. If the value is `false` or the value's function returns `false`, the modal will not close when trying to dismiss.  See https://ionicframework.com/docs/troubleshooting/runtime#accessing-this if you need to access `this` from within the callback. </para>
    /// </summary>
    public static void SetCanDismiss<T>(this PropsBuilder<T> b, Var<System.Func<DynamicObject,string,DynamicObject>> canDismiss) where T: IonModal
    {
        b.SetDynamic(b.Props, new DynamicProperty<System.Func<DynamicObject,string,DynamicObject>>("canDismiss"), canDismiss);
    }

    /// <summary>
    /// <para> Determines whether or not a modal can dismiss when calling the `dismiss` method.  If the value is `true` or the value's function returns `true`, the modal will close when trying to dismiss. If the value is `false` or the value's function returns `false`, the modal will not close when trying to dismiss.  See https://ionicframework.com/docs/troubleshooting/runtime#accessing-this if you need to access `this` from within the callback. </para>
    /// </summary>
    public static void SetCanDismiss<T>(this PropsBuilder<T> b, System.Func<DynamicObject,string,DynamicObject> canDismiss) where T: IonModal
    {
        b.SetDynamic(b.Props, new DynamicProperty<System.Func<DynamicObject,string,DynamicObject>>("canDismiss"), b.Const(canDismiss));
    }


    /// <summary>
    /// <para> Determines whether or not a modal can dismiss when calling the `dismiss` method.  If the value is `true` or the value's function returns `true`, the modal will close when trying to dismiss. If the value is `false` or the value's function returns `false`, the modal will not close when trying to dismiss.  See https://ionicframework.com/docs/troubleshooting/runtime#accessing-this if you need to access `this` from within the callback. </para>
    /// </summary>
    public static void SetCanDismiss<T>(this PropsBuilder<T> b) where T: IonModal
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("canDismiss"), b.Const(true));
    }


    /// <summary>
    /// <para> Determines whether or not a modal can dismiss when calling the `dismiss` method.  If the value is `true` or the value's function returns `true`, the modal will close when trying to dismiss. If the value is `false` or the value's function returns `false`, the modal will not close when trying to dismiss.  See https://ionicframework.com/docs/troubleshooting/runtime#accessing-this if you need to access `this` from within the callback. </para>
    /// </summary>
    public static void SetCanDismiss<T>(this PropsBuilder<T> b, Var<bool> canDismiss) where T: IonModal
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("canDismiss"), canDismiss);
    }

    /// <summary>
    /// <para> Determines whether or not a modal can dismiss when calling the `dismiss` method.  If the value is `true` or the value's function returns `true`, the modal will close when trying to dismiss. If the value is `false` or the value's function returns `false`, the modal will not close when trying to dismiss.  See https://ionicframework.com/docs/troubleshooting/runtime#accessing-this if you need to access `this` from within the callback. </para>
    /// </summary>
    public static void SetCanDismiss<T>(this PropsBuilder<T> b, bool canDismiss) where T: IonModal
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("canDismiss"), b.Const(canDismiss));
    }


    /// <summary>
    /// <para> Animation to use when the modal is presented. </para>
    /// </summary>
    public static void SetEnterAnimation<T>(this PropsBuilder<T> b, Var<System.Func<DynamicObject,DynamicObject,Animation>> enterAnimation) where T: IonModal
    {
        b.SetDynamic(b.Props, new DynamicProperty<System.Func<DynamicObject,DynamicObject,Animation>>("enterAnimation"), enterAnimation);
    }

    /// <summary>
    /// <para> Animation to use when the modal is presented. </para>
    /// </summary>
    public static void SetEnterAnimation<T>(this PropsBuilder<T> b, System.Func<DynamicObject,DynamicObject,Animation> enterAnimation) where T: IonModal
    {
        b.SetDynamic(b.Props, new DynamicProperty<System.Func<DynamicObject,DynamicObject,Animation>>("enterAnimation"), b.Const(enterAnimation));
    }


    /// <summary>
    /// <para> If `true`, focus will not be allowed to move outside of this overlay. If `false`, focus will be allowed to move outside of the overlay.  In most scenarios this property should remain set to `true`. Setting this property to `false` can cause severe accessibility issues as users relying on assistive technologies may be able to move focus into a confusing state. We recommend only setting this to `false` when absolutely necessary.  Developers may want to consider disabling focus trapping if this overlay presents a non-Ionic overlay from a 3rd party library. Developers would disable focus trapping on the Ionic overlay when presenting the 3rd party overlay and then re-enable focus trapping when dismissing the 3rd party overlay and moving focus back to the Ionic overlay. </para>
    /// </summary>
    public static void SetFocusTrap<T>(this PropsBuilder<T> b) where T: IonModal
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("focusTrap"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, focus will not be allowed to move outside of this overlay. If `false`, focus will be allowed to move outside of the overlay.  In most scenarios this property should remain set to `true`. Setting this property to `false` can cause severe accessibility issues as users relying on assistive technologies may be able to move focus into a confusing state. We recommend only setting this to `false` when absolutely necessary.  Developers may want to consider disabling focus trapping if this overlay presents a non-Ionic overlay from a 3rd party library. Developers would disable focus trapping on the Ionic overlay when presenting the 3rd party overlay and then re-enable focus trapping when dismissing the 3rd party overlay and moving focus back to the Ionic overlay. </para>
    /// </summary>
    public static void SetFocusTrap<T>(this PropsBuilder<T> b, Var<bool> focusTrap) where T: IonModal
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("focusTrap"), focusTrap);
    }

    /// <summary>
    /// <para> If `true`, focus will not be allowed to move outside of this overlay. If `false`, focus will be allowed to move outside of the overlay.  In most scenarios this property should remain set to `true`. Setting this property to `false` can cause severe accessibility issues as users relying on assistive technologies may be able to move focus into a confusing state. We recommend only setting this to `false` when absolutely necessary.  Developers may want to consider disabling focus trapping if this overlay presents a non-Ionic overlay from a 3rd party library. Developers would disable focus trapping on the Ionic overlay when presenting the 3rd party overlay and then re-enable focus trapping when dismissing the 3rd party overlay and moving focus back to the Ionic overlay. </para>
    /// </summary>
    public static void SetFocusTrap<T>(this PropsBuilder<T> b, bool focusTrap) where T: IonModal
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("focusTrap"), b.Const(focusTrap));
    }


    /// <summary>
    /// <para> The horizontal line that displays at the top of a sheet modal. It is `true` by default when setting the `breakpoints` and `initialBreakpoint` properties. </para>
    /// </summary>
    public static void SetHandle<T>(this PropsBuilder<T> b) where T: IonModal
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("handle"), b.Const(true));
    }


    /// <summary>
    /// <para> The horizontal line that displays at the top of a sheet modal. It is `true` by default when setting the `breakpoints` and `initialBreakpoint` properties. </para>
    /// </summary>
    public static void SetHandle<T>(this PropsBuilder<T> b, Var<bool> handle) where T: IonModal
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("handle"), handle);
    }

    /// <summary>
    /// <para> The horizontal line that displays at the top of a sheet modal. It is `true` by default when setting the `breakpoints` and `initialBreakpoint` properties. </para>
    /// </summary>
    public static void SetHandle<T>(this PropsBuilder<T> b, bool handle) where T: IonModal
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("handle"), b.Const(handle));
    }


    /// <summary>
    /// <para> The interaction behavior for the sheet modal when the handle is pressed.  Defaults to `"none"`, which  means the modal will not change size or position when the handle is pressed. Set to `"cycle"` to let the modal cycle between available breakpoints when pressed.  Handle behavior is unavailable when the `handle` property is set to `false` or when the `breakpoints` property is not set (using a fullscreen or card modal). </para>
    /// </summary>
    public static void SetHandleBehaviorCycle<T>(this PropsBuilder<T> b) where T: IonModal
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("handleBehavior"), b.Const("cycle"));
    }


    /// <summary>
    /// <para> The interaction behavior for the sheet modal when the handle is pressed.  Defaults to `"none"`, which  means the modal will not change size or position when the handle is pressed. Set to `"cycle"` to let the modal cycle between available breakpoints when pressed.  Handle behavior is unavailable when the `handle` property is set to `false` or when the `breakpoints` property is not set (using a fullscreen or card modal). </para>
    /// </summary>
    public static void SetHandleBehaviorNone<T>(this PropsBuilder<T> b) where T: IonModal
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("handleBehavior"), b.Const("none"));
    }


    /// <summary>
    /// <para> Additional attributes to pass to the modal. </para>
    /// </summary>
    public static void SetHtmlAttributes<T>(this PropsBuilder<T> b, Var<DynamicObject> htmlAttributes) where T: IonModal
    {
        b.SetDynamic(b.Props, new DynamicProperty<DynamicObject>("htmlAttributes"), htmlAttributes);
    }

    /// <summary>
    /// <para> Additional attributes to pass to the modal. </para>
    /// </summary>
    public static void SetHtmlAttributes<T>(this PropsBuilder<T> b, DynamicObject htmlAttributes) where T: IonModal
    {
        b.SetDynamic(b.Props, new DynamicProperty<DynamicObject>("htmlAttributes"), b.Const(htmlAttributes));
    }


    /// <summary>
    /// <para> A decimal value between 0 and 1 that indicates the initial point the modal will open at when creating a sheet modal. This value must also be listed in the `breakpoints` array. </para>
    /// </summary>
    public static void SetInitialBreakpoint<T>(this PropsBuilder<T> b, Var<int> initialBreakpoint) where T: IonModal
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("initialBreakpoint"), initialBreakpoint);
    }

    /// <summary>
    /// <para> A decimal value between 0 and 1 that indicates the initial point the modal will open at when creating a sheet modal. This value must also be listed in the `breakpoints` array. </para>
    /// </summary>
    public static void SetInitialBreakpoint<T>(this PropsBuilder<T> b, int initialBreakpoint) where T: IonModal
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("initialBreakpoint"), b.Const(initialBreakpoint));
    }


    /// <summary>
    /// <para> If `true`, the modal will open. If `false`, the modal will close. Use this if you need finer grained control over presentation, otherwise just use the modalController or the `trigger` property. Note: `isOpen` will not automatically be set back to `false` when the modal dismisses. You will need to do that in your code. </para>
    /// </summary>
    public static void SetIsOpen<T>(this PropsBuilder<T> b) where T: IonModal
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("isOpen"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, the modal will open. If `false`, the modal will close. Use this if you need finer grained control over presentation, otherwise just use the modalController or the `trigger` property. Note: `isOpen` will not automatically be set back to `false` when the modal dismisses. You will need to do that in your code. </para>
    /// </summary>
    public static void SetIsOpen<T>(this PropsBuilder<T> b, Var<bool> isOpen) where T: IonModal
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("isOpen"), isOpen);
    }

    /// <summary>
    /// <para> If `true`, the modal will open. If `false`, the modal will close. Use this if you need finer grained control over presentation, otherwise just use the modalController or the `trigger` property. Note: `isOpen` will not automatically be set back to `false` when the modal dismisses. You will need to do that in your code. </para>
    /// </summary>
    public static void SetIsOpen<T>(this PropsBuilder<T> b, bool isOpen) where T: IonModal
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("isOpen"), b.Const(isOpen));
    }


    /// <summary>
    /// <para> If `true`, the component passed into `ion-modal` will automatically be mounted when the modal is created. The component will remain mounted even when the modal is dismissed. However, the component will be destroyed when the modal is destroyed. This property is not reactive and should only be used when initially creating a modal.  Note: This feature only applies to inline modals in JavaScript frameworks such as Angular, React, and Vue. </para>
    /// </summary>
    public static void SetKeepContentsMounted<T>(this PropsBuilder<T> b) where T: IonModal
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("keepContentsMounted"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, the component passed into `ion-modal` will automatically be mounted when the modal is created. The component will remain mounted even when the modal is dismissed. However, the component will be destroyed when the modal is destroyed. This property is not reactive and should only be used when initially creating a modal.  Note: This feature only applies to inline modals in JavaScript frameworks such as Angular, React, and Vue. </para>
    /// </summary>
    public static void SetKeepContentsMounted<T>(this PropsBuilder<T> b, Var<bool> keepContentsMounted) where T: IonModal
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("keepContentsMounted"), keepContentsMounted);
    }

    /// <summary>
    /// <para> If `true`, the component passed into `ion-modal` will automatically be mounted when the modal is created. The component will remain mounted even when the modal is dismissed. However, the component will be destroyed when the modal is destroyed. This property is not reactive and should only be used when initially creating a modal.  Note: This feature only applies to inline modals in JavaScript frameworks such as Angular, React, and Vue. </para>
    /// </summary>
    public static void SetKeepContentsMounted<T>(this PropsBuilder<T> b, bool keepContentsMounted) where T: IonModal
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("keepContentsMounted"), b.Const(keepContentsMounted));
    }


    /// <summary>
    /// <para> If `true`, the keyboard will be automatically dismissed when the overlay is presented. </para>
    /// </summary>
    public static void SetKeyboardClose<T>(this PropsBuilder<T> b) where T: IonModal
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("keyboardClose"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, the keyboard will be automatically dismissed when the overlay is presented. </para>
    /// </summary>
    public static void SetKeyboardClose<T>(this PropsBuilder<T> b, Var<bool> keyboardClose) where T: IonModal
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("keyboardClose"), keyboardClose);
    }

    /// <summary>
    /// <para> If `true`, the keyboard will be automatically dismissed when the overlay is presented. </para>
    /// </summary>
    public static void SetKeyboardClose<T>(this PropsBuilder<T> b, bool keyboardClose) where T: IonModal
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("keyboardClose"), b.Const(keyboardClose));
    }


    /// <summary>
    /// <para> Animation to use when the modal is dismissed. </para>
    /// </summary>
    public static void SetLeaveAnimation<T>(this PropsBuilder<T> b, Var<System.Func<DynamicObject,DynamicObject,Animation>> leaveAnimation) where T: IonModal
    {
        b.SetDynamic(b.Props, new DynamicProperty<System.Func<DynamicObject,DynamicObject,Animation>>("leaveAnimation"), leaveAnimation);
    }

    /// <summary>
    /// <para> Animation to use when the modal is dismissed. </para>
    /// </summary>
    public static void SetLeaveAnimation<T>(this PropsBuilder<T> b, System.Func<DynamicObject,DynamicObject,Animation> leaveAnimation) where T: IonModal
    {
        b.SetDynamic(b.Props, new DynamicProperty<System.Func<DynamicObject,DynamicObject,Animation>>("leaveAnimation"), b.Const(leaveAnimation));
    }


    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeIos<T>(this PropsBuilder<T> b) where T: IonModal
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("mode"), b.Const("ios"));
    }


    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeMd<T>(this PropsBuilder<T> b) where T: IonModal
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("mode"), b.Const("md"));
    }


    /// <summary>
    /// <para> The element that presented the modal. This is used for card presentation effects and for stacking multiple modals on top of each other. Only applies in iOS mode. </para>
    /// </summary>
    public static void SetPresentingElement<T>(this PropsBuilder<T> b, Var<HTMLElement> presentingElement) where T: IonModal
    {
        b.SetDynamic(b.Props, new DynamicProperty<HTMLElement>("presentingElement"), presentingElement);
    }

    /// <summary>
    /// <para> The element that presented the modal. This is used for card presentation effects and for stacking multiple modals on top of each other. Only applies in iOS mode. </para>
    /// </summary>
    public static void SetPresentingElement<T>(this PropsBuilder<T> b, HTMLElement presentingElement) where T: IonModal
    {
        b.SetDynamic(b.Props, new DynamicProperty<HTMLElement>("presentingElement"), b.Const(presentingElement));
    }


    /// <summary>
    /// <para> If `true`, a backdrop will be displayed behind the modal. This property controls whether or not the backdrop darkens the screen when the modal is presented. It does not control whether or not the backdrop is active or present in the DOM. </para>
    /// </summary>
    public static void SetShowBackdrop<T>(this PropsBuilder<T> b) where T: IonModal
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("showBackdrop"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, a backdrop will be displayed behind the modal. This property controls whether or not the backdrop darkens the screen when the modal is presented. It does not control whether or not the backdrop is active or present in the DOM. </para>
    /// </summary>
    public static void SetShowBackdrop<T>(this PropsBuilder<T> b, Var<bool> showBackdrop) where T: IonModal
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("showBackdrop"), showBackdrop);
    }

    /// <summary>
    /// <para> If `true`, a backdrop will be displayed behind the modal. This property controls whether or not the backdrop darkens the screen when the modal is presented. It does not control whether or not the backdrop is active or present in the DOM. </para>
    /// </summary>
    public static void SetShowBackdrop<T>(this PropsBuilder<T> b, bool showBackdrop) where T: IonModal
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("showBackdrop"), b.Const(showBackdrop));
    }


    /// <summary>
    /// <para> An ID corresponding to the trigger element that causes the modal to open when clicked. </para>
    /// </summary>
    public static void SetTrigger<T>(this PropsBuilder<T> b, Var<string> trigger) where T: IonModal
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("trigger"), trigger);
    }

    /// <summary>
    /// <para> An ID corresponding to the trigger element that causes the modal to open when clicked. </para>
    /// </summary>
    public static void SetTrigger<T>(this PropsBuilder<T> b, string trigger) where T: IonModal
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("trigger"), b.Const(trigger));
    }


    /// <summary>
    /// <para> Emitted after the modal has dismissed. Shorthand for ionModalDidDismiss. </para>
    /// </summary>
    public static void OnDidDismiss<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, OverlayEventDetail>> action) where TComponent: IonModal
    {
        b.OnEventAction("ondidDismiss", action, "detail");
    }
    /// <summary>
    /// <para> Emitted after the modal has dismissed. Shorthand for ionModalDidDismiss. </para>
    /// </summary>
    public static void OnDidDismiss<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<OverlayEventDetail>, Var<TModel>> action) where TComponent: IonModal
    {
        b.OnEventAction("ondidDismiss", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// <para> Emitted after the modal has presented. Shorthand for ionModalDidPresent. </para>
    /// </summary>
    public static void OnDidPresent<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonModal
    {
        b.OnEventAction("ondidPresent", action);
    }
    /// <summary>
    /// <para> Emitted after the modal has presented. Shorthand for ionModalDidPresent. </para>
    /// </summary>
    public static void OnDidPresent<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonModal
    {
        b.OnEventAction("ondidPresent", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted after the modal breakpoint has changed. </para>
    /// </summary>
    public static void OnIonBreakpointDidChange<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, ModalBreakpointChangeEventDetail>> action) where TComponent: IonModal
    {
        b.OnEventAction("onionBreakpointDidChange", action, "detail");
    }
    /// <summary>
    /// <para> Emitted after the modal breakpoint has changed. </para>
    /// </summary>
    public static void OnIonBreakpointDidChange<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<ModalBreakpointChangeEventDetail>, Var<TModel>> action) where TComponent: IonModal
    {
        b.OnEventAction("onionBreakpointDidChange", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// <para> Emitted after the modal has dismissed. </para>
    /// </summary>
    public static void OnIonModalDidDismiss<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, OverlayEventDetail>> action) where TComponent: IonModal
    {
        b.OnEventAction("onionModalDidDismiss", action, "detail");
    }
    /// <summary>
    /// <para> Emitted after the modal has dismissed. </para>
    /// </summary>
    public static void OnIonModalDidDismiss<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<OverlayEventDetail>, Var<TModel>> action) where TComponent: IonModal
    {
        b.OnEventAction("onionModalDidDismiss", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// <para> Emitted after the modal has presented. </para>
    /// </summary>
    public static void OnIonModalDidPresent<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonModal
    {
        b.OnEventAction("onionModalDidPresent", action);
    }
    /// <summary>
    /// <para> Emitted after the modal has presented. </para>
    /// </summary>
    public static void OnIonModalDidPresent<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonModal
    {
        b.OnEventAction("onionModalDidPresent", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted before the modal has dismissed. </para>
    /// </summary>
    public static void OnIonModalWillDismiss<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, OverlayEventDetail>> action) where TComponent: IonModal
    {
        b.OnEventAction("onionModalWillDismiss", action, "detail");
    }
    /// <summary>
    /// <para> Emitted before the modal has dismissed. </para>
    /// </summary>
    public static void OnIonModalWillDismiss<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<OverlayEventDetail>, Var<TModel>> action) where TComponent: IonModal
    {
        b.OnEventAction("onionModalWillDismiss", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// <para> Emitted before the modal has presented. </para>
    /// </summary>
    public static void OnIonModalWillPresent<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonModal
    {
        b.OnEventAction("onionModalWillPresent", action);
    }
    /// <summary>
    /// <para> Emitted before the modal has presented. </para>
    /// </summary>
    public static void OnIonModalWillPresent<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonModal
    {
        b.OnEventAction("onionModalWillPresent", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted before the modal has dismissed. Shorthand for ionModalWillDismiss. </para>
    /// </summary>
    public static void OnWillDismiss<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, OverlayEventDetail>> action) where TComponent: IonModal
    {
        b.OnEventAction("onwillDismiss", action, "detail");
    }
    /// <summary>
    /// <para> Emitted before the modal has dismissed. Shorthand for ionModalWillDismiss. </para>
    /// </summary>
    public static void OnWillDismiss<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<OverlayEventDetail>, Var<TModel>> action) where TComponent: IonModal
    {
        b.OnEventAction("onwillDismiss", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// <para> Emitted before the modal has presented. Shorthand for ionModalWillPresent. </para>
    /// </summary>
    public static void OnWillPresent<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonModal
    {
        b.OnEventAction("onwillPresent", action);
    }
    /// <summary>
    /// <para> Emitted before the modal has presented. Shorthand for ionModalWillPresent. </para>
    /// </summary>
    public static void OnWillPresent<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonModal
    {
        b.OnEventAction("onwillPresent", b.MakeAction(action));
    }

}

