using Metapsi.Html;
using Metapsi.Syntax;
using Metapsi.Hyperapp;

namespace Metapsi.Ionic;

/// <summary>
/// 
/// </summary>
public partial class IonModal
{
    /// <summary>
    /// 
    /// </summary>
    public static class Slot
    {
    }
    /// <summary>
    /// 
    /// </summary>
    public static class Method
    {
        /// <summary>
        /// Dismiss the modal overlay after it has been presented.
        /// </summary>
        public const string Dismiss = "dismiss";
        /// <summary>
        /// Returns the current breakpoint of a sheet style modal
        /// </summary>
        public const string GetCurrentBreakpoint = "getCurrentBreakpoint";
        /// <summary>
        /// Returns a promise that resolves when the modal did dismiss.
        /// </summary>
        public const string OnDidDismiss = "onDidDismiss";
        /// <summary>
        /// Returns a promise that resolves when the modal will dismiss.
        /// </summary>
        public const string OnWillDismiss = "onWillDismiss";
        /// <summary>
        /// Present the modal overlay after it has been created.
        /// </summary>
        public const string Present = "present";
        /// <summary>
        /// Move a sheet style modal to a specific breakpoint. The breakpoint value must be a value defined in your `breakpoints` array.
        /// </summary>
        public const string SetCurrentBreakpoint = "setCurrentBreakpoint";
    }
}
/// <summary>
/// Setter extensions of IonModal
/// </summary>
public static partial class IonModalControl
{
    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonModal(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonModal>> buildAttributes, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.IonicTag("ion-modal", buildAttributes, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonModal(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.IonicTag("ion-modal", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonModal(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonModal>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.IonicTag("ion-modal", buildAttributes, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonModal(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.IonicTag("ion-modal", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// If `true`, the modal will animate.
    /// </summary>
    public static void SetAnimated(this Metapsi.Html.AttributesBuilder<IonModal> b, bool animated) 
    {
        if (animated) b.SetAttribute("animated", "");
    }

    /// <summary>
    /// If `true`, the modal will animate.
    /// </summary>
    public static void SetAnimated(this Metapsi.Html.AttributesBuilder<IonModal> b) 
    {
        b.SetAttribute("animated", "");
    }

    /// <summary>
    /// If `true`, the modal will be dismissed when the backdrop is clicked.
    /// </summary>
    public static void SetBackdropDismiss(this Metapsi.Html.AttributesBuilder<IonModal> b, bool backdropDismiss) 
    {
        if (backdropDismiss) b.SetAttribute("backdropDismiss", "");
    }

    /// <summary>
    /// If `true`, the modal will be dismissed when the backdrop is clicked.
    /// </summary>
    public static void SetBackdropDismiss(this Metapsi.Html.AttributesBuilder<IonModal> b) 
    {
        b.SetAttribute("backdropDismiss", "");
    }

    /// <summary>
    /// Determines whether or not a modal can dismiss when calling the `dismiss` method.  If the value is `true` or the value's function returns `true`, the modal will close when trying to dismiss. If the value is `false` or the value's function returns `false`, the modal will not close when trying to dismiss.  See https://ionicframework.com/docs/troubleshooting/runtime#accessing-this if you need to access `this` from within the callback.
    /// </summary>
    public static void SetCanDismiss(this Metapsi.Html.AttributesBuilder<IonModal> b, bool canDismiss) 
    {
        if (canDismiss) b.SetAttribute("canDismiss", "");
    }

    /// <summary>
    /// Determines whether or not a modal can dismiss when calling the `dismiss` method.  If the value is `true` or the value's function returns `true`, the modal will close when trying to dismiss. If the value is `false` or the value's function returns `false`, the modal will not close when trying to dismiss.  See https://ionicframework.com/docs/troubleshooting/runtime#accessing-this if you need to access `this` from within the callback.
    /// </summary>
    public static void SetCanDismiss(this Metapsi.Html.AttributesBuilder<IonModal> b) 
    {
        b.SetAttribute("canDismiss", "");
    }

    /// <summary>
    /// Controls whether scrolling or dragging within the sheet modal expands it to a larger breakpoint. This only takes effect when `breakpoints` and `initialBreakpoint` are set.  If `true`, scrolling or dragging anywhere in the modal will first expand it to the next breakpoint. Once fully expanded, scrolling will affect the content. If `false`, scrolling will always affect the content. The modal will only expand when dragging the header or handle. The modal will close when dragging the header or handle. It can also be closed when dragging the content, but only if the content is scrolled to the top.
    /// </summary>
    public static void SetExpandToScroll(this Metapsi.Html.AttributesBuilder<IonModal> b, bool expandToScroll) 
    {
        if (expandToScroll) b.SetAttribute("expandToScroll", "");
    }

    /// <summary>
    /// Controls whether scrolling or dragging within the sheet modal expands it to a larger breakpoint. This only takes effect when `breakpoints` and `initialBreakpoint` are set.  If `true`, scrolling or dragging anywhere in the modal will first expand it to the next breakpoint. Once fully expanded, scrolling will affect the content. If `false`, scrolling will always affect the content. The modal will only expand when dragging the header or handle. The modal will close when dragging the header or handle. It can also be closed when dragging the content, but only if the content is scrolled to the top.
    /// </summary>
    public static void SetExpandToScroll(this Metapsi.Html.AttributesBuilder<IonModal> b) 
    {
        b.SetAttribute("expandToScroll", "");
    }

    /// <summary>
    /// If `true`, focus will not be allowed to move outside of this overlay. If `false`, focus will be allowed to move outside of the overlay.  In most scenarios this property should remain set to `true`. Setting this property to `false` can cause severe accessibility issues as users relying on assistive technologies may be able to move focus into a confusing state. We recommend only setting this to `false` when absolutely necessary.  Developers may want to consider disabling focus trapping if this overlay presents a non-Ionic overlay from a 3rd party library. Developers would disable focus trapping on the Ionic overlay when presenting the 3rd party overlay and then re-enable focus trapping when dismissing the 3rd party overlay and moving focus back to the Ionic overlay.
    /// </summary>
    public static void SetFocusTrap(this Metapsi.Html.AttributesBuilder<IonModal> b, bool focusTrap) 
    {
        if (focusTrap) b.SetAttribute("focusTrap", "");
    }

    /// <summary>
    /// If `true`, focus will not be allowed to move outside of this overlay. If `false`, focus will be allowed to move outside of the overlay.  In most scenarios this property should remain set to `true`. Setting this property to `false` can cause severe accessibility issues as users relying on assistive technologies may be able to move focus into a confusing state. We recommend only setting this to `false` when absolutely necessary.  Developers may want to consider disabling focus trapping if this overlay presents a non-Ionic overlay from a 3rd party library. Developers would disable focus trapping on the Ionic overlay when presenting the 3rd party overlay and then re-enable focus trapping when dismissing the 3rd party overlay and moving focus back to the Ionic overlay.
    /// </summary>
    public static void SetFocusTrap(this Metapsi.Html.AttributesBuilder<IonModal> b) 
    {
        b.SetAttribute("focusTrap", "");
    }

    /// <summary>
    /// The horizontal line that displays at the top of a sheet modal. It is `true` by default when setting the `breakpoints` and `initialBreakpoint` properties.
    /// </summary>
    public static void SetHandle(this Metapsi.Html.AttributesBuilder<IonModal> b, bool handle) 
    {
        if (handle) b.SetAttribute("handle", "");
    }

    /// <summary>
    /// The horizontal line that displays at the top of a sheet modal. It is `true` by default when setting the `breakpoints` and `initialBreakpoint` properties.
    /// </summary>
    public static void SetHandle(this Metapsi.Html.AttributesBuilder<IonModal> b) 
    {
        b.SetAttribute("handle", "");
    }

    /// <summary>
    /// The interaction behavior for the sheet modal when the handle is pressed.  Defaults to `"none"`, which  means the modal will not change size or position when the handle is pressed. Set to `"cycle"` to let the modal cycle between available breakpoints when pressed.  Handle behavior is unavailable when the `handle` property is set to `false` or when the `breakpoints` property is not set (using a fullscreen or card modal).
    /// </summary>
    public static void SetHandleBehaviorCycle(this Metapsi.Html.AttributesBuilder<IonModal> b) 
    {
        b.SetAttribute("handleBehavior", "cycle");
    }

    /// <summary>
    /// The interaction behavior for the sheet modal when the handle is pressed.  Defaults to `"none"`, which  means the modal will not change size or position when the handle is pressed. Set to `"cycle"` to let the modal cycle between available breakpoints when pressed.  Handle behavior is unavailable when the `handle` property is set to `false` or when the `breakpoints` property is not set (using a fullscreen or card modal).
    /// </summary>
    public static void SetHandleBehaviorNone(this Metapsi.Html.AttributesBuilder<IonModal> b) 
    {
        b.SetAttribute("handleBehavior", "none");
    }

    /// <summary>
    /// A decimal value between 0 and 1 that indicates the initial point the modal will open at when creating a sheet modal. This value must also be listed in the `breakpoints` array.
    /// </summary>
    public static void SetInitialBreakpoint(this Metapsi.Html.AttributesBuilder<IonModal> b, string initialBreakpoint) 
    {
        b.SetAttribute("initialBreakpoint", initialBreakpoint);
    }

    /// <summary>
    /// If `true`, the modal will open. If `false`, the modal will close. Use this if you need finer grained control over presentation, otherwise just use the modalController or the `trigger` property. Note: `isOpen` will not automatically be set back to `false` when the modal dismisses. You will need to do that in your code.
    /// </summary>
    public static void SetIsOpen(this Metapsi.Html.AttributesBuilder<IonModal> b, bool isOpen) 
    {
        if (isOpen) b.SetAttribute("isOpen", "");
    }

    /// <summary>
    /// If `true`, the modal will open. If `false`, the modal will close. Use this if you need finer grained control over presentation, otherwise just use the modalController or the `trigger` property. Note: `isOpen` will not automatically be set back to `false` when the modal dismisses. You will need to do that in your code.
    /// </summary>
    public static void SetIsOpen(this Metapsi.Html.AttributesBuilder<IonModal> b) 
    {
        b.SetAttribute("isOpen", "");
    }

    /// <summary>
    /// If `true`, the component passed into `ion-modal` will automatically be mounted when the modal is created. The component will remain mounted even when the modal is dismissed. However, the component will be destroyed when the modal is destroyed. This property is not reactive and should only be used when initially creating a modal.  Note: This feature only applies to inline modals in JavaScript frameworks such as Angular, React, and Vue.
    /// </summary>
    public static void SetKeepContentsMounted(this Metapsi.Html.AttributesBuilder<IonModal> b, bool keepContentsMounted) 
    {
        if (keepContentsMounted) b.SetAttribute("keepContentsMounted", "");
    }

    /// <summary>
    /// If `true`, the component passed into `ion-modal` will automatically be mounted when the modal is created. The component will remain mounted even when the modal is dismissed. However, the component will be destroyed when the modal is destroyed. This property is not reactive and should only be used when initially creating a modal.  Note: This feature only applies to inline modals in JavaScript frameworks such as Angular, React, and Vue.
    /// </summary>
    public static void SetKeepContentsMounted(this Metapsi.Html.AttributesBuilder<IonModal> b) 
    {
        b.SetAttribute("keepContentsMounted", "");
    }

    /// <summary>
    /// If `true`, the keyboard will be automatically dismissed when the overlay is presented.
    /// </summary>
    public static void SetKeyboardClose(this Metapsi.Html.AttributesBuilder<IonModal> b, bool keyboardClose) 
    {
        if (keyboardClose) b.SetAttribute("keyboardClose", "");
    }

    /// <summary>
    /// If `true`, the keyboard will be automatically dismissed when the overlay is presented.
    /// </summary>
    public static void SetKeyboardClose(this Metapsi.Html.AttributesBuilder<IonModal> b) 
    {
        b.SetAttribute("keyboardClose", "");
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos(this Metapsi.Html.AttributesBuilder<IonModal> b) 
    {
        b.SetAttribute("mode", "ios");
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd(this Metapsi.Html.AttributesBuilder<IonModal> b) 
    {
        b.SetAttribute("mode", "md");
    }

    /// <summary>
    /// If `true`, a backdrop will be displayed behind the modal. This property controls whether or not the backdrop darkens the screen when the modal is presented. It does not control whether or not the backdrop is active or present in the DOM.
    /// </summary>
    public static void SetShowBackdrop(this Metapsi.Html.AttributesBuilder<IonModal> b, bool showBackdrop) 
    {
        if (showBackdrop) b.SetAttribute("showBackdrop", "");
    }

    /// <summary>
    /// If `true`, a backdrop will be displayed behind the modal. This property controls whether or not the backdrop darkens the screen when the modal is presented. It does not control whether or not the backdrop is active or present in the DOM.
    /// </summary>
    public static void SetShowBackdrop(this Metapsi.Html.AttributesBuilder<IonModal> b) 
    {
        b.SetAttribute("showBackdrop", "");
    }

    /// <summary>
    /// An ID corresponding to the trigger element that causes the modal to open when clicked.
    /// </summary>
    public static void SetTrigger(this Metapsi.Html.AttributesBuilder<IonModal> b, string trigger) 
    {
        b.SetAttribute("trigger", trigger);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonModal(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonModal>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.IonicNode("ion-modal", buildProps, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonModal(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.IonicNode("ion-modal", children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonModal(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonModal>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.IonicNode("ion-modal", buildProps, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonModal(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.IonicNode("ion-modal", children);
    }

    /// <summary>
    /// If `true`, the modal will animate.
    /// </summary>
    public static void SetAnimated<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonModal
    {
        b.SetAnimated(b.Const(true));
    }

    /// <summary>
    /// If `true`, the modal will animate.
    /// </summary>
    public static void SetAnimated<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> animated) where T: IonModal
    {
        b.SetProperty(b.Props, b.Const("animated"), animated);
    }

    /// <summary>
    /// If `true`, the modal will animate.
    /// </summary>
    public static void SetAnimated<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool animated) where T: IonModal
    {
        b.SetAnimated(b.Const(animated));
    }

    /// <summary>
    /// A decimal value between 0 and 1 that indicates the point after which the backdrop will begin to fade in when using a sheet modal. Prior to this point, the backdrop will be hidden and the content underneath the sheet can be interacted with. This value is exclusive meaning the backdrop will become active after the value specified.
    /// </summary>
    public static void SetBackdropBreakpoint<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<decimal> backdropBreakpoint) where T: IonModal
    {
        b.SetProperty(b.Props, b.Const("backdropBreakpoint"), backdropBreakpoint);
    }

    /// <summary>
    /// If `true`, the modal will be dismissed when the backdrop is clicked.
    /// </summary>
    public static void SetBackdropDismiss<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonModal
    {
        b.SetBackdropDismiss(b.Const(true));
    }

    /// <summary>
    /// If `true`, the modal will be dismissed when the backdrop is clicked.
    /// </summary>
    public static void SetBackdropDismiss<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> backdropDismiss) where T: IonModal
    {
        b.SetProperty(b.Props, b.Const("backdropDismiss"), backdropDismiss);
    }

    /// <summary>
    /// If `true`, the modal will be dismissed when the backdrop is clicked.
    /// </summary>
    public static void SetBackdropDismiss<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool backdropDismiss) where T: IonModal
    {
        b.SetBackdropDismiss(b.Const(backdropDismiss));
    }

    /// <summary>
    /// The breakpoints to use when creating a sheet modal. Each value in the array must be a decimal between 0 and 1 where 0 indicates the modal is fully closed and 1 indicates the modal is fully open. Values are relative to the height of the modal, not the height of the screen. One of the values in this array must be the value of the `initialBreakpoint` property. For example: [0, .25, .5, 1]
    /// </summary>
    public static void SetBreakpoints<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<System.Collections.Generic.List<decimal>> breakpoints) where T: IonModal
    {
        b.SetProperty(b.Props, b.Const("breakpoints"), breakpoints);
    }

    /// <summary>
    /// Determines whether or not a modal can dismiss when calling the `dismiss` method.  If the value is `true` or the value's function returns `true`, the modal will close when trying to dismiss. If the value is `false` or the value's function returns `false`, the modal will not close when trying to dismiss.  See https://ionicframework.com/docs/troubleshooting/runtime#accessing-this if you need to access `this` from within the callback.
    /// </summary>
    public static void SetCanDismiss<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> canDismiss) where T: IonModal
    {
        b.SetProperty(b.Props, b.Const("canDismiss"), canDismiss);
    }

    /// <summary>
    /// Determines whether or not a modal can dismiss when calling the `dismiss` method.  If the value is `true` or the value's function returns `true`, the modal will close when trying to dismiss. If the value is `false` or the value's function returns `false`, the modal will not close when trying to dismiss.  See https://ionicframework.com/docs/troubleshooting/runtime#accessing-this if you need to access `this` from within the callback.
    /// </summary>
    public static void SetCanDismiss<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<System.Func<object, string, Metapsi.Html.Promise>> canDismiss) where T: IonModal
    {
        b.SetProperty(b.Props, b.Const("canDismiss"), canDismiss);
    }

    /// <summary>
    /// Controls whether scrolling or dragging within the sheet modal expands it to a larger breakpoint. This only takes effect when `breakpoints` and `initialBreakpoint` are set.  If `true`, scrolling or dragging anywhere in the modal will first expand it to the next breakpoint. Once fully expanded, scrolling will affect the content. If `false`, scrolling will always affect the content. The modal will only expand when dragging the header or handle. The modal will close when dragging the header or handle. It can also be closed when dragging the content, but only if the content is scrolled to the top.
    /// </summary>
    public static void SetExpandToScroll<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonModal
    {
        b.SetExpandToScroll(b.Const(true));
    }

    /// <summary>
    /// Controls whether scrolling or dragging within the sheet modal expands it to a larger breakpoint. This only takes effect when `breakpoints` and `initialBreakpoint` are set.  If `true`, scrolling or dragging anywhere in the modal will first expand it to the next breakpoint. Once fully expanded, scrolling will affect the content. If `false`, scrolling will always affect the content. The modal will only expand when dragging the header or handle. The modal will close when dragging the header or handle. It can also be closed when dragging the content, but only if the content is scrolled to the top.
    /// </summary>
    public static void SetExpandToScroll<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> expandToScroll) where T: IonModal
    {
        b.SetProperty(b.Props, b.Const("expandToScroll"), expandToScroll);
    }

    /// <summary>
    /// Controls whether scrolling or dragging within the sheet modal expands it to a larger breakpoint. This only takes effect when `breakpoints` and `initialBreakpoint` are set.  If `true`, scrolling or dragging anywhere in the modal will first expand it to the next breakpoint. Once fully expanded, scrolling will affect the content. If `false`, scrolling will always affect the content. The modal will only expand when dragging the header or handle. The modal will close when dragging the header or handle. It can also be closed when dragging the content, but only if the content is scrolled to the top.
    /// </summary>
    public static void SetExpandToScroll<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool expandToScroll) where T: IonModal
    {
        b.SetExpandToScroll(b.Const(expandToScroll));
    }

    /// <summary>
    /// If `true`, focus will not be allowed to move outside of this overlay. If `false`, focus will be allowed to move outside of the overlay.  In most scenarios this property should remain set to `true`. Setting this property to `false` can cause severe accessibility issues as users relying on assistive technologies may be able to move focus into a confusing state. We recommend only setting this to `false` when absolutely necessary.  Developers may want to consider disabling focus trapping if this overlay presents a non-Ionic overlay from a 3rd party library. Developers would disable focus trapping on the Ionic overlay when presenting the 3rd party overlay and then re-enable focus trapping when dismissing the 3rd party overlay and moving focus back to the Ionic overlay.
    /// </summary>
    public static void SetFocusTrap<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonModal
    {
        b.SetFocusTrap(b.Const(true));
    }

    /// <summary>
    /// If `true`, focus will not be allowed to move outside of this overlay. If `false`, focus will be allowed to move outside of the overlay.  In most scenarios this property should remain set to `true`. Setting this property to `false` can cause severe accessibility issues as users relying on assistive technologies may be able to move focus into a confusing state. We recommend only setting this to `false` when absolutely necessary.  Developers may want to consider disabling focus trapping if this overlay presents a non-Ionic overlay from a 3rd party library. Developers would disable focus trapping on the Ionic overlay when presenting the 3rd party overlay and then re-enable focus trapping when dismissing the 3rd party overlay and moving focus back to the Ionic overlay.
    /// </summary>
    public static void SetFocusTrap<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> focusTrap) where T: IonModal
    {
        b.SetProperty(b.Props, b.Const("focusTrap"), focusTrap);
    }

    /// <summary>
    /// If `true`, focus will not be allowed to move outside of this overlay. If `false`, focus will be allowed to move outside of the overlay.  In most scenarios this property should remain set to `true`. Setting this property to `false` can cause severe accessibility issues as users relying on assistive technologies may be able to move focus into a confusing state. We recommend only setting this to `false` when absolutely necessary.  Developers may want to consider disabling focus trapping if this overlay presents a non-Ionic overlay from a 3rd party library. Developers would disable focus trapping on the Ionic overlay when presenting the 3rd party overlay and then re-enable focus trapping when dismissing the 3rd party overlay and moving focus back to the Ionic overlay.
    /// </summary>
    public static void SetFocusTrap<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool focusTrap) where T: IonModal
    {
        b.SetFocusTrap(b.Const(focusTrap));
    }

    /// <summary>
    /// The horizontal line that displays at the top of a sheet modal. It is `true` by default when setting the `breakpoints` and `initialBreakpoint` properties.
    /// </summary>
    public static void SetHandle<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonModal
    {
        b.SetHandle(b.Const(true));
    }

    /// <summary>
    /// The horizontal line that displays at the top of a sheet modal. It is `true` by default when setting the `breakpoints` and `initialBreakpoint` properties.
    /// </summary>
    public static void SetHandle<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> handle) where T: IonModal
    {
        b.SetProperty(b.Props, b.Const("handle"), handle);
    }

    /// <summary>
    /// The horizontal line that displays at the top of a sheet modal. It is `true` by default when setting the `breakpoints` and `initialBreakpoint` properties.
    /// </summary>
    public static void SetHandle<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool handle) where T: IonModal
    {
        b.SetHandle(b.Const(handle));
    }

    /// <summary>
    /// The interaction behavior for the sheet modal when the handle is pressed.  Defaults to `"none"`, which  means the modal will not change size or position when the handle is pressed. Set to `"cycle"` to let the modal cycle between available breakpoints when pressed.  Handle behavior is unavailable when the `handle` property is set to `false` or when the `breakpoints` property is not set (using a fullscreen or card modal).
    /// </summary>
    public static void SetHandleBehaviorCycle<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonModal
    {
        b.SetProperty(b.Props, b.Const("handleBehavior"), b.Const("cycle"));
    }

    /// <summary>
    /// The interaction behavior for the sheet modal when the handle is pressed.  Defaults to `"none"`, which  means the modal will not change size or position when the handle is pressed. Set to `"cycle"` to let the modal cycle between available breakpoints when pressed.  Handle behavior is unavailable when the `handle` property is set to `false` or when the `breakpoints` property is not set (using a fullscreen or card modal).
    /// </summary>
    public static void SetHandleBehaviorNone<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonModal
    {
        b.SetProperty(b.Props, b.Const("handleBehavior"), b.Const("none"));
    }

    /// <summary>
    /// Additional attributes to pass to the modal.
    /// </summary>
    public static void SetHtmlAttributes<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<System.Collections.Generic.List<object>> htmlAttributes) where T: IonModal
    {
        b.SetProperty(b.Props, b.Const("htmlAttributes"), htmlAttributes);
    }

    /// <summary>
    /// A decimal value between 0 and 1 that indicates the initial point the modal will open at when creating a sheet modal. This value must also be listed in the `breakpoints` array.
    /// </summary>
    public static void SetInitialBreakpoint<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<decimal> initialBreakpoint) where T: IonModal
    {
        b.SetProperty(b.Props, b.Const("initialBreakpoint"), initialBreakpoint);
    }

    /// <summary>
    /// A decimal value between 0 and 1 that indicates the initial point the modal will open at when creating a sheet modal. This value must also be listed in the `breakpoints` array.
    /// </summary>
    public static void SetInitialBreakpoint<T>(this Metapsi.Syntax.PropsBuilder<T> b, decimal initialBreakpoint) where T: IonModal
    {
        b.SetInitialBreakpoint(b.Const(initialBreakpoint));
    }

    /// <summary>
    /// A decimal value between 0 and 1 that indicates the initial point the modal will open at when creating a sheet modal. This value must also be listed in the `breakpoints` array.
    /// </summary>
    public static void SetInitialBreakpoint<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<int> initialBreakpoint) where T: IonModal
    {
        b.SetProperty(b.Props, b.Const("initialBreakpoint"), initialBreakpoint);
    }

    /// <summary>
    /// A decimal value between 0 and 1 that indicates the initial point the modal will open at when creating a sheet modal. This value must also be listed in the `breakpoints` array.
    /// </summary>
    public static void SetInitialBreakpoint<T>(this Metapsi.Syntax.PropsBuilder<T> b, int initialBreakpoint) where T: IonModal
    {
        b.SetInitialBreakpoint(b.Const(initialBreakpoint));
    }

    /// <summary>
    /// If `true`, the modal will open. If `false`, the modal will close. Use this if you need finer grained control over presentation, otherwise just use the modalController or the `trigger` property. Note: `isOpen` will not automatically be set back to `false` when the modal dismisses. You will need to do that in your code.
    /// </summary>
    public static void SetIsOpen<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonModal
    {
        b.SetIsOpen(b.Const(true));
    }

    /// <summary>
    /// If `true`, the modal will open. If `false`, the modal will close. Use this if you need finer grained control over presentation, otherwise just use the modalController or the `trigger` property. Note: `isOpen` will not automatically be set back to `false` when the modal dismisses. You will need to do that in your code.
    /// </summary>
    public static void SetIsOpen<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> isOpen) where T: IonModal
    {
        b.SetProperty(b.Props, b.Const("isOpen"), isOpen);
    }

    /// <summary>
    /// If `true`, the modal will open. If `false`, the modal will close. Use this if you need finer grained control over presentation, otherwise just use the modalController or the `trigger` property. Note: `isOpen` will not automatically be set back to `false` when the modal dismisses. You will need to do that in your code.
    /// </summary>
    public static void SetIsOpen<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool isOpen) where T: IonModal
    {
        b.SetIsOpen(b.Const(isOpen));
    }

    /// <summary>
    /// If `true`, the component passed into `ion-modal` will automatically be mounted when the modal is created. The component will remain mounted even when the modal is dismissed. However, the component will be destroyed when the modal is destroyed. This property is not reactive and should only be used when initially creating a modal.  Note: This feature only applies to inline modals in JavaScript frameworks such as Angular, React, and Vue.
    /// </summary>
    public static void SetKeepContentsMounted<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonModal
    {
        b.SetKeepContentsMounted(b.Const(true));
    }

    /// <summary>
    /// If `true`, the component passed into `ion-modal` will automatically be mounted when the modal is created. The component will remain mounted even when the modal is dismissed. However, the component will be destroyed when the modal is destroyed. This property is not reactive and should only be used when initially creating a modal.  Note: This feature only applies to inline modals in JavaScript frameworks such as Angular, React, and Vue.
    /// </summary>
    public static void SetKeepContentsMounted<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> keepContentsMounted) where T: IonModal
    {
        b.SetProperty(b.Props, b.Const("keepContentsMounted"), keepContentsMounted);
    }

    /// <summary>
    /// If `true`, the component passed into `ion-modal` will automatically be mounted when the modal is created. The component will remain mounted even when the modal is dismissed. However, the component will be destroyed when the modal is destroyed. This property is not reactive and should only be used when initially creating a modal.  Note: This feature only applies to inline modals in JavaScript frameworks such as Angular, React, and Vue.
    /// </summary>
    public static void SetKeepContentsMounted<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool keepContentsMounted) where T: IonModal
    {
        b.SetKeepContentsMounted(b.Const(keepContentsMounted));
    }

    /// <summary>
    /// If `true`, the keyboard will be automatically dismissed when the overlay is presented.
    /// </summary>
    public static void SetKeyboardClose<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonModal
    {
        b.SetKeyboardClose(b.Const(true));
    }

    /// <summary>
    /// If `true`, the keyboard will be automatically dismissed when the overlay is presented.
    /// </summary>
    public static void SetKeyboardClose<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> keyboardClose) where T: IonModal
    {
        b.SetProperty(b.Props, b.Const("keyboardClose"), keyboardClose);
    }

    /// <summary>
    /// If `true`, the keyboard will be automatically dismissed when the overlay is presented.
    /// </summary>
    public static void SetKeyboardClose<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool keyboardClose) where T: IonModal
    {
        b.SetKeyboardClose(b.Const(keyboardClose));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonModal
    {
        b.SetProperty(b.Props, b.Const("mode"), b.Const("ios"));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonModal
    {
        b.SetProperty(b.Props, b.Const("mode"), b.Const("md"));
    }

    /// <summary>
    /// The element that presented the modal. This is used for card presentation effects and for stacking multiple modals on top of each other. Only applies in iOS mode.
    /// </summary>
    public static void SetPresentingElement<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Html.HTMLElement> presentingElement) where T: IonModal
    {
        b.SetProperty(b.Props, b.Const("presentingElement"), presentingElement);
    }

    /// <summary>
    /// If `true`, a backdrop will be displayed behind the modal. This property controls whether or not the backdrop darkens the screen when the modal is presented. It does not control whether or not the backdrop is active or present in the DOM.
    /// </summary>
    public static void SetShowBackdrop<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonModal
    {
        b.SetShowBackdrop(b.Const(true));
    }

    /// <summary>
    /// If `true`, a backdrop will be displayed behind the modal. This property controls whether or not the backdrop darkens the screen when the modal is presented. It does not control whether or not the backdrop is active or present in the DOM.
    /// </summary>
    public static void SetShowBackdrop<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> showBackdrop) where T: IonModal
    {
        b.SetProperty(b.Props, b.Const("showBackdrop"), showBackdrop);
    }

    /// <summary>
    /// If `true`, a backdrop will be displayed behind the modal. This property controls whether or not the backdrop darkens the screen when the modal is presented. It does not control whether or not the backdrop is active or present in the DOM.
    /// </summary>
    public static void SetShowBackdrop<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool showBackdrop) where T: IonModal
    {
        b.SetShowBackdrop(b.Const(showBackdrop));
    }

    /// <summary>
    /// An ID corresponding to the trigger element that causes the modal to open when clicked.
    /// </summary>
    public static void SetTrigger<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> trigger) where T: IonModal
    {
        b.SetProperty(b.Props, b.Const("trigger"), trigger);
    }

    /// <summary>
    /// An ID corresponding to the trigger element that causes the modal to open when clicked.
    /// </summary>
    public static void SetTrigger<T>(this Metapsi.Syntax.PropsBuilder<T> b, string trigger) where T: IonModal
    {
        b.SetTrigger(b.Const(trigger));
    }

    /// <summary>
    /// Emitted after the modal has dismissed. Shorthand for ionModalDidDismiss.
    /// </summary>
    public static void OnDidDismiss<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonModal
    {
        b.SetProperty(b.Props, "ondidDismiss", action);
    }

    /// <summary>
    /// Emitted after the modal has dismissed. Shorthand for ionModalDidDismiss.
    /// </summary>
    public static void OnDidDismiss<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonModal
    {
        b.OnDidDismiss(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the modal has dismissed. Shorthand for ionModalDidDismiss.
    /// </summary>
    public static void OnDidDismiss<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonModal
    {
        b.SetProperty(b.Props, "ondidDismiss", action);
    }

    /// <summary>
    /// Emitted after the modal has dismissed. Shorthand for ionModalDidDismiss.
    /// </summary>
    public static void OnDidDismiss<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonModal
    {
        b.OnDidDismiss(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the modal has dismissed. Shorthand for ionModalDidDismiss.
    /// </summary>
    public static void OnDidDismiss<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.CustomEvent<OverlayEventDetail>>> action) where T: IonModal
    {
        b.SetProperty(b.Props, "ondidDismiss", action);
    }

    /// <summary>
    /// Emitted after the modal has presented. Shorthand for ionModalDidPresent.
    /// </summary>
    public static void OnDidPresent<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonModal
    {
        b.SetProperty(b.Props, "ondidPresent", action);
    }

    /// <summary>
    /// Emitted after the modal has presented. Shorthand for ionModalDidPresent.
    /// </summary>
    public static void OnDidPresent<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonModal
    {
        b.OnDidPresent(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the modal has presented. Shorthand for ionModalDidPresent.
    /// </summary>
    public static void OnDidPresent<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonModal
    {
        b.SetProperty(b.Props, "ondidPresent", action);
    }

    /// <summary>
    /// Emitted after the modal has presented. Shorthand for ionModalDidPresent.
    /// </summary>
    public static void OnDidPresent<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonModal
    {
        b.OnDidPresent(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the modal breakpoint has changed.
    /// </summary>
    public static void OnIonBreakpointDidChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonModal
    {
        b.SetProperty(b.Props, "onionBreakpointDidChange", action);
    }

    /// <summary>
    /// Emitted after the modal breakpoint has changed.
    /// </summary>
    public static void OnIonBreakpointDidChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonModal
    {
        b.OnIonBreakpointDidChange(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the modal breakpoint has changed.
    /// </summary>
    public static void OnIonBreakpointDidChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonModal
    {
        b.SetProperty(b.Props, "onionBreakpointDidChange", action);
    }

    /// <summary>
    /// Emitted after the modal breakpoint has changed.
    /// </summary>
    public static void OnIonBreakpointDidChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonModal
    {
        b.OnIonBreakpointDidChange(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the modal breakpoint has changed.
    /// </summary>
    public static void OnIonBreakpointDidChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.CustomEvent<ModalBreakpointChangeEventDetail>>> action) where T: IonModal
    {
        b.SetProperty(b.Props, "onionBreakpointDidChange", action);
    }

    /// <summary>
    /// Emitted after the modal has dismissed.
    /// </summary>
    public static void OnIonModalDidDismiss<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonModal
    {
        b.SetProperty(b.Props, "onionModalDidDismiss", action);
    }

    /// <summary>
    /// Emitted after the modal has dismissed.
    /// </summary>
    public static void OnIonModalDidDismiss<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonModal
    {
        b.OnIonModalDidDismiss(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the modal has dismissed.
    /// </summary>
    public static void OnIonModalDidDismiss<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonModal
    {
        b.SetProperty(b.Props, "onionModalDidDismiss", action);
    }

    /// <summary>
    /// Emitted after the modal has dismissed.
    /// </summary>
    public static void OnIonModalDidDismiss<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonModal
    {
        b.OnIonModalDidDismiss(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the modal has dismissed.
    /// </summary>
    public static void OnIonModalDidDismiss<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.CustomEvent<OverlayEventDetail>>> action) where T: IonModal
    {
        b.SetProperty(b.Props, "onionModalDidDismiss", action);
    }

    /// <summary>
    /// Emitted after the modal has presented.
    /// </summary>
    public static void OnIonModalDidPresent<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonModal
    {
        b.SetProperty(b.Props, "onionModalDidPresent", action);
    }

    /// <summary>
    /// Emitted after the modal has presented.
    /// </summary>
    public static void OnIonModalDidPresent<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonModal
    {
        b.OnIonModalDidPresent(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the modal has presented.
    /// </summary>
    public static void OnIonModalDidPresent<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonModal
    {
        b.SetProperty(b.Props, "onionModalDidPresent", action);
    }

    /// <summary>
    /// Emitted after the modal has presented.
    /// </summary>
    public static void OnIonModalDidPresent<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonModal
    {
        b.OnIonModalDidPresent(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted before the modal has dismissed.
    /// </summary>
    public static void OnIonModalWillDismiss<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonModal
    {
        b.SetProperty(b.Props, "onionModalWillDismiss", action);
    }

    /// <summary>
    /// Emitted before the modal has dismissed.
    /// </summary>
    public static void OnIonModalWillDismiss<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonModal
    {
        b.OnIonModalWillDismiss(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted before the modal has dismissed.
    /// </summary>
    public static void OnIonModalWillDismiss<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonModal
    {
        b.SetProperty(b.Props, "onionModalWillDismiss", action);
    }

    /// <summary>
    /// Emitted before the modal has dismissed.
    /// </summary>
    public static void OnIonModalWillDismiss<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonModal
    {
        b.OnIonModalWillDismiss(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted before the modal has dismissed.
    /// </summary>
    public static void OnIonModalWillDismiss<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.CustomEvent<OverlayEventDetail>>> action) where T: IonModal
    {
        b.SetProperty(b.Props, "onionModalWillDismiss", action);
    }

    /// <summary>
    /// Emitted before the modal has presented.
    /// </summary>
    public static void OnIonModalWillPresent<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonModal
    {
        b.SetProperty(b.Props, "onionModalWillPresent", action);
    }

    /// <summary>
    /// Emitted before the modal has presented.
    /// </summary>
    public static void OnIonModalWillPresent<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonModal
    {
        b.OnIonModalWillPresent(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted before the modal has presented.
    /// </summary>
    public static void OnIonModalWillPresent<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonModal
    {
        b.SetProperty(b.Props, "onionModalWillPresent", action);
    }

    /// <summary>
    /// Emitted before the modal has presented.
    /// </summary>
    public static void OnIonModalWillPresent<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonModal
    {
        b.OnIonModalWillPresent(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted before the modal has dismissed. Shorthand for ionModalWillDismiss.
    /// </summary>
    public static void OnWillDismiss<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonModal
    {
        b.SetProperty(b.Props, "onwillDismiss", action);
    }

    /// <summary>
    /// Emitted before the modal has dismissed. Shorthand for ionModalWillDismiss.
    /// </summary>
    public static void OnWillDismiss<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonModal
    {
        b.OnWillDismiss(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted before the modal has dismissed. Shorthand for ionModalWillDismiss.
    /// </summary>
    public static void OnWillDismiss<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonModal
    {
        b.SetProperty(b.Props, "onwillDismiss", action);
    }

    /// <summary>
    /// Emitted before the modal has dismissed. Shorthand for ionModalWillDismiss.
    /// </summary>
    public static void OnWillDismiss<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonModal
    {
        b.OnWillDismiss(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted before the modal has dismissed. Shorthand for ionModalWillDismiss.
    /// </summary>
    public static void OnWillDismiss<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.CustomEvent<OverlayEventDetail>>> action) where T: IonModal
    {
        b.SetProperty(b.Props, "onwillDismiss", action);
    }

    /// <summary>
    /// Emitted before the modal has presented. Shorthand for ionModalWillPresent.
    /// </summary>
    public static void OnWillPresent<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonModal
    {
        b.SetProperty(b.Props, "onwillPresent", action);
    }

    /// <summary>
    /// Emitted before the modal has presented. Shorthand for ionModalWillPresent.
    /// </summary>
    public static void OnWillPresent<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonModal
    {
        b.OnWillPresent(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted before the modal has presented. Shorthand for ionModalWillPresent.
    /// </summary>
    public static void OnWillPresent<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonModal
    {
        b.SetProperty(b.Props, "onwillPresent", action);
    }

    /// <summary>
    /// Emitted before the modal has presented. Shorthand for ionModalWillPresent.
    /// </summary>
    public static void OnWillPresent<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonModal
    {
        b.OnWillPresent(b.MakeAction(action));
    }

}