using Metapsi.Html;
using Metapsi.Syntax;
using Metapsi.Hyperapp;

namespace Metapsi.Ionic;

/// <summary>
/// 
/// </summary>
public partial class IonPopover
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
        /// Dismiss the popover overlay after it has been presented.
        /// </summary>
        public const string Dismiss = "dismiss";
        /// <summary>
        /// Returns a promise that resolves when the popover did dismiss.
        /// </summary>
        public const string OnDidDismiss = "onDidDismiss";
        /// <summary>
        /// Returns a promise that resolves when the popover will dismiss.
        /// </summary>
        public const string OnWillDismiss = "onWillDismiss";
        /// <summary>
        /// Present the popover overlay after it has been created. Developers can pass a mouse, touch, or pointer event to position the popover relative to where that event was dispatched.
        /// </summary>
        public const string Present = "present";
    }
}
/// <summary>
/// Setter extensions of IonPopover
/// </summary>
public static partial class IonPopoverControl
{
    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonPopover(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonPopover>> buildAttributes, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.IonicTag("ion-popover", buildAttributes, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonPopover(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.IonicTag("ion-popover", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonPopover(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonPopover>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.IonicTag("ion-popover", buildAttributes, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonPopover(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.IonicTag("ion-popover", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// Describes how to align the popover content with the `reference` point. Defaults to `"center"` for `ios` mode, and `"start"` for `md` mode.
    /// </summary>
    public static void SetAlignmentCenter(this Metapsi.Html.AttributesBuilder<IonPopover> b) 
    {
        b.SetAttribute("alignment", "center");
    }

    /// <summary>
    /// Describes how to align the popover content with the `reference` point. Defaults to `"center"` for `ios` mode, and `"start"` for `md` mode.
    /// </summary>
    public static void SetAlignmentEnd(this Metapsi.Html.AttributesBuilder<IonPopover> b) 
    {
        b.SetAttribute("alignment", "end");
    }

    /// <summary>
    /// Describes how to align the popover content with the `reference` point. Defaults to `"center"` for `ios` mode, and `"start"` for `md` mode.
    /// </summary>
    public static void SetAlignmentStart(this Metapsi.Html.AttributesBuilder<IonPopover> b) 
    {
        b.SetAttribute("alignment", "start");
    }

    /// <summary>
    /// If `true`, the popover will animate.
    /// </summary>
    public static void SetAnimated(this Metapsi.Html.AttributesBuilder<IonPopover> b, bool animated) 
    {
        if (animated) b.SetAttribute("animated", "");
    }

    /// <summary>
    /// If `true`, the popover will animate.
    /// </summary>
    public static void SetAnimated(this Metapsi.Html.AttributesBuilder<IonPopover> b) 
    {
        b.SetAttribute("animated", "");
    }

    /// <summary>
    /// If `true`, the popover will display an arrow that points at the `reference` when running in `ios` mode. Does not apply in `md` mode.
    /// </summary>
    public static void SetArrow(this Metapsi.Html.AttributesBuilder<IonPopover> b, bool arrow) 
    {
        if (arrow) b.SetAttribute("arrow", "");
    }

    /// <summary>
    /// If `true`, the popover will display an arrow that points at the `reference` when running in `ios` mode. Does not apply in `md` mode.
    /// </summary>
    public static void SetArrow(this Metapsi.Html.AttributesBuilder<IonPopover> b) 
    {
        b.SetAttribute("arrow", "");
    }

    /// <summary>
    /// If `true`, the popover will be dismissed when the backdrop is clicked.
    /// </summary>
    public static void SetBackdropDismiss(this Metapsi.Html.AttributesBuilder<IonPopover> b, bool backdropDismiss) 
    {
        if (backdropDismiss) b.SetAttribute("backdropDismiss", "");
    }

    /// <summary>
    /// If `true`, the popover will be dismissed when the backdrop is clicked.
    /// </summary>
    public static void SetBackdropDismiss(this Metapsi.Html.AttributesBuilder<IonPopover> b) 
    {
        b.SetAttribute("backdropDismiss", "");
    }

    /// <summary>
    /// The component to display inside of the popover. You only need to use this if you are not using a JavaScript framework. Otherwise, you can just slot your component inside of `ion-popover`.
    /// </summary>
    public static void SetComponent(this Metapsi.Html.AttributesBuilder<IonPopover> b, string component) 
    {
        b.SetAttribute("component", component);
    }

    /// <summary>
    /// If `true`, the popover will be automatically dismissed when the content has been clicked.
    /// </summary>
    public static void SetDismissOnSelect(this Metapsi.Html.AttributesBuilder<IonPopover> b, bool dismissOnSelect) 
    {
        if (dismissOnSelect) b.SetAttribute("dismissOnSelect", "");
    }

    /// <summary>
    /// If `true`, the popover will be automatically dismissed when the content has been clicked.
    /// </summary>
    public static void SetDismissOnSelect(this Metapsi.Html.AttributesBuilder<IonPopover> b) 
    {
        b.SetAttribute("dismissOnSelect", "");
    }

    /// <summary>
    /// If `true`, focus will not be allowed to move outside of this overlay. If `false`, focus will be allowed to move outside of the overlay.  In most scenarios this property should remain set to `true`. Setting this property to `false` can cause severe accessibility issues as users relying on assistive technologies may be able to move focus into a confusing state. We recommend only setting this to `false` when absolutely necessary.  Developers may want to consider disabling focus trapping if this overlay presents a non-Ionic overlay from a 3rd party library. Developers would disable focus trapping on the Ionic overlay when presenting the 3rd party overlay and then re-enable focus trapping when dismissing the 3rd party overlay and moving focus back to the Ionic overlay.
    /// </summary>
    public static void SetFocusTrap(this Metapsi.Html.AttributesBuilder<IonPopover> b, bool focusTrap) 
    {
        if (focusTrap) b.SetAttribute("focusTrap", "");
    }

    /// <summary>
    /// If `true`, focus will not be allowed to move outside of this overlay. If `false`, focus will be allowed to move outside of the overlay.  In most scenarios this property should remain set to `true`. Setting this property to `false` can cause severe accessibility issues as users relying on assistive technologies may be able to move focus into a confusing state. We recommend only setting this to `false` when absolutely necessary.  Developers may want to consider disabling focus trapping if this overlay presents a non-Ionic overlay from a 3rd party library. Developers would disable focus trapping on the Ionic overlay when presenting the 3rd party overlay and then re-enable focus trapping when dismissing the 3rd party overlay and moving focus back to the Ionic overlay.
    /// </summary>
    public static void SetFocusTrap(this Metapsi.Html.AttributesBuilder<IonPopover> b) 
    {
        b.SetAttribute("focusTrap", "");
    }

    /// <summary>
    /// If `true`, the popover will open. If `false`, the popover will close. Use this if you need finer grained control over presentation, otherwise just use the popoverController or the `trigger` property. Note: `isOpen` will not automatically be set back to `false` when the popover dismisses. You will need to do that in your code.
    /// </summary>
    public static void SetIsOpen(this Metapsi.Html.AttributesBuilder<IonPopover> b, bool isOpen) 
    {
        if (isOpen) b.SetAttribute("isOpen", "");
    }

    /// <summary>
    /// If `true`, the popover will open. If `false`, the popover will close. Use this if you need finer grained control over presentation, otherwise just use the popoverController or the `trigger` property. Note: `isOpen` will not automatically be set back to `false` when the popover dismisses. You will need to do that in your code.
    /// </summary>
    public static void SetIsOpen(this Metapsi.Html.AttributesBuilder<IonPopover> b) 
    {
        b.SetAttribute("isOpen", "");
    }

    /// <summary>
    /// If `true`, the component passed into `ion-popover` will automatically be mounted when the popover is created. The component will remain mounted even when the popover is dismissed. However, the component will be destroyed when the popover is destroyed. This property is not reactive and should only be used when initially creating a popover.  Note: This feature only applies to inline popovers in JavaScript frameworks such as Angular, React, and Vue.
    /// </summary>
    public static void SetKeepContentsMounted(this Metapsi.Html.AttributesBuilder<IonPopover> b, bool keepContentsMounted) 
    {
        if (keepContentsMounted) b.SetAttribute("keepContentsMounted", "");
    }

    /// <summary>
    /// If `true`, the component passed into `ion-popover` will automatically be mounted when the popover is created. The component will remain mounted even when the popover is dismissed. However, the component will be destroyed when the popover is destroyed. This property is not reactive and should only be used when initially creating a popover.  Note: This feature only applies to inline popovers in JavaScript frameworks such as Angular, React, and Vue.
    /// </summary>
    public static void SetKeepContentsMounted(this Metapsi.Html.AttributesBuilder<IonPopover> b) 
    {
        b.SetAttribute("keepContentsMounted", "");
    }

    /// <summary>
    /// If `true`, the keyboard will be automatically dismissed when the overlay is presented.
    /// </summary>
    public static void SetKeyboardClose(this Metapsi.Html.AttributesBuilder<IonPopover> b, bool keyboardClose) 
    {
        if (keyboardClose) b.SetAttribute("keyboardClose", "");
    }

    /// <summary>
    /// If `true`, the keyboard will be automatically dismissed when the overlay is presented.
    /// </summary>
    public static void SetKeyboardClose(this Metapsi.Html.AttributesBuilder<IonPopover> b) 
    {
        b.SetAttribute("keyboardClose", "");
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos(this Metapsi.Html.AttributesBuilder<IonPopover> b) 
    {
        b.SetAttribute("mode", "ios");
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd(this Metapsi.Html.AttributesBuilder<IonPopover> b) 
    {
        b.SetAttribute("mode", "md");
    }

    /// <summary>
    /// Describes what to position the popover relative to. If `"trigger"`, the popover will be positioned relative to the trigger button. If passing in an event, this is determined via event.target. If `"event"`, the popover will be positioned relative to the x/y coordinates of the trigger action. If passing in an event, this is determined via event.clientX and event.clientY.
    /// </summary>
    public static void SetReferenceEvent(this Metapsi.Html.AttributesBuilder<IonPopover> b) 
    {
        b.SetAttribute("reference", "event");
    }

    /// <summary>
    /// Describes what to position the popover relative to. If `"trigger"`, the popover will be positioned relative to the trigger button. If passing in an event, this is determined via event.target. If `"event"`, the popover will be positioned relative to the x/y coordinates of the trigger action. If passing in an event, this is determined via event.clientX and event.clientY.
    /// </summary>
    public static void SetReferenceTrigger(this Metapsi.Html.AttributesBuilder<IonPopover> b) 
    {
        b.SetAttribute("reference", "trigger");
    }

    /// <summary>
    /// If `true`, a backdrop will be displayed behind the popover. This property controls whether or not the backdrop darkens the screen when the popover is presented. It does not control whether or not the backdrop is active or present in the DOM.
    /// </summary>
    public static void SetShowBackdrop(this Metapsi.Html.AttributesBuilder<IonPopover> b, bool showBackdrop) 
    {
        if (showBackdrop) b.SetAttribute("showBackdrop", "");
    }

    /// <summary>
    /// If `true`, a backdrop will be displayed behind the popover. This property controls whether or not the backdrop darkens the screen when the popover is presented. It does not control whether or not the backdrop is active or present in the DOM.
    /// </summary>
    public static void SetShowBackdrop(this Metapsi.Html.AttributesBuilder<IonPopover> b) 
    {
        b.SetAttribute("showBackdrop", "");
    }

    /// <summary>
    /// Describes which side of the `reference` point to position the popover on. The `"start"` and `"end"` values are RTL-aware, and the `"left"` and `"right"` values are not.
    /// </summary>
    public static void SetSideBottom(this Metapsi.Html.AttributesBuilder<IonPopover> b) 
    {
        b.SetAttribute("side", "bottom");
    }

    /// <summary>
    /// Describes which side of the `reference` point to position the popover on. The `"start"` and `"end"` values are RTL-aware, and the `"left"` and `"right"` values are not.
    /// </summary>
    public static void SetSideEnd(this Metapsi.Html.AttributesBuilder<IonPopover> b) 
    {
        b.SetAttribute("side", "end");
    }

    /// <summary>
    /// Describes which side of the `reference` point to position the popover on. The `"start"` and `"end"` values are RTL-aware, and the `"left"` and `"right"` values are not.
    /// </summary>
    public static void SetSideLeft(this Metapsi.Html.AttributesBuilder<IonPopover> b) 
    {
        b.SetAttribute("side", "left");
    }

    /// <summary>
    /// Describes which side of the `reference` point to position the popover on. The `"start"` and `"end"` values are RTL-aware, and the `"left"` and `"right"` values are not.
    /// </summary>
    public static void SetSideRight(this Metapsi.Html.AttributesBuilder<IonPopover> b) 
    {
        b.SetAttribute("side", "right");
    }

    /// <summary>
    /// Describes which side of the `reference` point to position the popover on. The `"start"` and `"end"` values are RTL-aware, and the `"left"` and `"right"` values are not.
    /// </summary>
    public static void SetSideStart(this Metapsi.Html.AttributesBuilder<IonPopover> b) 
    {
        b.SetAttribute("side", "start");
    }

    /// <summary>
    /// Describes which side of the `reference` point to position the popover on. The `"start"` and `"end"` values are RTL-aware, and the `"left"` and `"right"` values are not.
    /// </summary>
    public static void SetSideTop(this Metapsi.Html.AttributesBuilder<IonPopover> b) 
    {
        b.SetAttribute("side", "top");
    }

    /// <summary>
    /// Describes how to calculate the popover width. If `"cover"`, the popover width will match the width of the trigger. If `"auto"`, the popover width will be set to a static default value.
    /// </summary>
    public static void SetSizeAuto(this Metapsi.Html.AttributesBuilder<IonPopover> b) 
    {
        b.SetAttribute("size", "auto");
    }

    /// <summary>
    /// Describes how to calculate the popover width. If `"cover"`, the popover width will match the width of the trigger. If `"auto"`, the popover width will be set to a static default value.
    /// </summary>
    public static void SetSizeCover(this Metapsi.Html.AttributesBuilder<IonPopover> b) 
    {
        b.SetAttribute("size", "cover");
    }

    /// <summary>
    /// If `true`, the popover will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility).
    /// </summary>
    public static void SetTranslucent(this Metapsi.Html.AttributesBuilder<IonPopover> b, bool translucent) 
    {
        if (translucent) b.SetAttribute("translucent", "");
    }

    /// <summary>
    /// If `true`, the popover will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility).
    /// </summary>
    public static void SetTranslucent(this Metapsi.Html.AttributesBuilder<IonPopover> b) 
    {
        b.SetAttribute("translucent", "");
    }

    /// <summary>
    /// An ID corresponding to the trigger element that causes the popover to open. Use the `trigger-action` property to customize the interaction that results in the popover opening.
    /// </summary>
    public static void SetTrigger(this Metapsi.Html.AttributesBuilder<IonPopover> b, string trigger) 
    {
        b.SetAttribute("trigger", trigger);
    }

    /// <summary>
    /// Describes what kind of interaction with the trigger that should cause the popover to open. Does not apply when the `trigger` property is `undefined`. If `"click"`, the popover will be presented when the trigger is left clicked. If `"hover"`, the popover will be presented when a pointer hovers over the trigger. If `"context-menu"`, the popover will be presented when the trigger is right clicked on desktop and long pressed on mobile. This will also prevent your device's normal context menu from appearing.
    /// </summary>
    public static void SetTriggerActionClick(this Metapsi.Html.AttributesBuilder<IonPopover> b) 
    {
        b.SetAttribute("triggerAction", "click");
    }

    /// <summary>
    /// Describes what kind of interaction with the trigger that should cause the popover to open. Does not apply when the `trigger` property is `undefined`. If `"click"`, the popover will be presented when the trigger is left clicked. If `"hover"`, the popover will be presented when a pointer hovers over the trigger. If `"context-menu"`, the popover will be presented when the trigger is right clicked on desktop and long pressed on mobile. This will also prevent your device's normal context menu from appearing.
    /// </summary>
    public static void SetTriggerActionContextMenu(this Metapsi.Html.AttributesBuilder<IonPopover> b) 
    {
        b.SetAttribute("triggerAction", "context-menu");
    }

    /// <summary>
    /// Describes what kind of interaction with the trigger that should cause the popover to open. Does not apply when the `trigger` property is `undefined`. If `"click"`, the popover will be presented when the trigger is left clicked. If `"hover"`, the popover will be presented when a pointer hovers over the trigger. If `"context-menu"`, the popover will be presented when the trigger is right clicked on desktop and long pressed on mobile. This will also prevent your device's normal context menu from appearing.
    /// </summary>
    public static void SetTriggerActionHover(this Metapsi.Html.AttributesBuilder<IonPopover> b) 
    {
        b.SetAttribute("triggerAction", "hover");
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonPopover(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonPopover>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.IonicNode("ion-popover", buildProps, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonPopover(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.IonicNode("ion-popover", children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonPopover(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonPopover>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.IonicNode("ion-popover", buildProps, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonPopover(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.IonicNode("ion-popover", children);
    }

    /// <summary>
    /// Describes how to align the popover content with the `reference` point. Defaults to `"center"` for `ios` mode, and `"start"` for `md` mode.
    /// </summary>
    public static void SetAlignmentCenter<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonPopover
    {
        b.SetProperty(b.Props, b.Const("alignment"), b.Const("center"));
    }

    /// <summary>
    /// Describes how to align the popover content with the `reference` point. Defaults to `"center"` for `ios` mode, and `"start"` for `md` mode.
    /// </summary>
    public static void SetAlignmentEnd<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonPopover
    {
        b.SetProperty(b.Props, b.Const("alignment"), b.Const("end"));
    }

    /// <summary>
    /// Describes how to align the popover content with the `reference` point. Defaults to `"center"` for `ios` mode, and `"start"` for `md` mode.
    /// </summary>
    public static void SetAlignmentStart<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonPopover
    {
        b.SetProperty(b.Props, b.Const("alignment"), b.Const("start"));
    }

    /// <summary>
    /// If `true`, the popover will animate.
    /// </summary>
    public static void SetAnimated<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonPopover
    {
        b.SetAnimated(b.Const(true));
    }

    /// <summary>
    /// If `true`, the popover will animate.
    /// </summary>
    public static void SetAnimated<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> animated) where T: IonPopover
    {
        b.SetProperty(b.Props, b.Const("animated"), animated);
    }

    /// <summary>
    /// If `true`, the popover will animate.
    /// </summary>
    public static void SetAnimated<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool animated) where T: IonPopover
    {
        b.SetAnimated(b.Const(animated));
    }

    /// <summary>
    /// If `true`, the popover will display an arrow that points at the `reference` when running in `ios` mode. Does not apply in `md` mode.
    /// </summary>
    public static void SetArrow<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonPopover
    {
        b.SetArrow(b.Const(true));
    }

    /// <summary>
    /// If `true`, the popover will display an arrow that points at the `reference` when running in `ios` mode. Does not apply in `md` mode.
    /// </summary>
    public static void SetArrow<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> arrow) where T: IonPopover
    {
        b.SetProperty(b.Props, b.Const("arrow"), arrow);
    }

    /// <summary>
    /// If `true`, the popover will display an arrow that points at the `reference` when running in `ios` mode. Does not apply in `md` mode.
    /// </summary>
    public static void SetArrow<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool arrow) where T: IonPopover
    {
        b.SetArrow(b.Const(arrow));
    }

    /// <summary>
    /// If `true`, the popover will be dismissed when the backdrop is clicked.
    /// </summary>
    public static void SetBackdropDismiss<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonPopover
    {
        b.SetBackdropDismiss(b.Const(true));
    }

    /// <summary>
    /// If `true`, the popover will be dismissed when the backdrop is clicked.
    /// </summary>
    public static void SetBackdropDismiss<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> backdropDismiss) where T: IonPopover
    {
        b.SetProperty(b.Props, b.Const("backdropDismiss"), backdropDismiss);
    }

    /// <summary>
    /// If `true`, the popover will be dismissed when the backdrop is clicked.
    /// </summary>
    public static void SetBackdropDismiss<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool backdropDismiss) where T: IonPopover
    {
        b.SetBackdropDismiss(b.Const(backdropDismiss));
    }

    /// <summary>
    /// The component to display inside of the popover. You only need to use this if you are not using a JavaScript framework. Otherwise, you can just slot your component inside of `ion-popover`.
    /// </summary>
    public static void SetComponent<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> component) where T: IonPopover
    {
        b.SetProperty(b.Props, b.Const("component"), component);
    }

    /// <summary>
    /// The data to pass to the popover component. You only need to use this if you are not using a JavaScript framework. Otherwise, you can just set the props directly on your component.
    /// </summary>
    public static void SetComponentProps<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Syntax.Var<System.Collections.Generic.List<object>>> componentProps) where T: IonPopover
    {
        b.SetProperty(b.Props, b.Const("componentProps"), componentProps);
    }

    /// <summary>
    /// If `true`, the popover will be automatically dismissed when the content has been clicked.
    /// </summary>
    public static void SetDismissOnSelect<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonPopover
    {
        b.SetDismissOnSelect(b.Const(true));
    }

    /// <summary>
    /// If `true`, the popover will be automatically dismissed when the content has been clicked.
    /// </summary>
    public static void SetDismissOnSelect<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> dismissOnSelect) where T: IonPopover
    {
        b.SetProperty(b.Props, b.Const("dismissOnSelect"), dismissOnSelect);
    }

    /// <summary>
    /// If `true`, the popover will be automatically dismissed when the content has been clicked.
    /// </summary>
    public static void SetDismissOnSelect<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool dismissOnSelect) where T: IonPopover
    {
        b.SetDismissOnSelect(b.Const(dismissOnSelect));
    }

    /// <summary>
    /// The event to pass to the popover animation.
    /// </summary>
    public static void SetEvent<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<object> @event) where T: IonPopover
    {
        b.SetProperty(b.Props, b.Const("event"), @event);
    }

    /// <summary>
    /// If `true`, focus will not be allowed to move outside of this overlay. If `false`, focus will be allowed to move outside of the overlay.  In most scenarios this property should remain set to `true`. Setting this property to `false` can cause severe accessibility issues as users relying on assistive technologies may be able to move focus into a confusing state. We recommend only setting this to `false` when absolutely necessary.  Developers may want to consider disabling focus trapping if this overlay presents a non-Ionic overlay from a 3rd party library. Developers would disable focus trapping on the Ionic overlay when presenting the 3rd party overlay and then re-enable focus trapping when dismissing the 3rd party overlay and moving focus back to the Ionic overlay.
    /// </summary>
    public static void SetFocusTrap<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonPopover
    {
        b.SetFocusTrap(b.Const(true));
    }

    /// <summary>
    /// If `true`, focus will not be allowed to move outside of this overlay. If `false`, focus will be allowed to move outside of the overlay.  In most scenarios this property should remain set to `true`. Setting this property to `false` can cause severe accessibility issues as users relying on assistive technologies may be able to move focus into a confusing state. We recommend only setting this to `false` when absolutely necessary.  Developers may want to consider disabling focus trapping if this overlay presents a non-Ionic overlay from a 3rd party library. Developers would disable focus trapping on the Ionic overlay when presenting the 3rd party overlay and then re-enable focus trapping when dismissing the 3rd party overlay and moving focus back to the Ionic overlay.
    /// </summary>
    public static void SetFocusTrap<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> focusTrap) where T: IonPopover
    {
        b.SetProperty(b.Props, b.Const("focusTrap"), focusTrap);
    }

    /// <summary>
    /// If `true`, focus will not be allowed to move outside of this overlay. If `false`, focus will be allowed to move outside of the overlay.  In most scenarios this property should remain set to `true`. Setting this property to `false` can cause severe accessibility issues as users relying on assistive technologies may be able to move focus into a confusing state. We recommend only setting this to `false` when absolutely necessary.  Developers may want to consider disabling focus trapping if this overlay presents a non-Ionic overlay from a 3rd party library. Developers would disable focus trapping on the Ionic overlay when presenting the 3rd party overlay and then re-enable focus trapping when dismissing the 3rd party overlay and moving focus back to the Ionic overlay.
    /// </summary>
    public static void SetFocusTrap<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool focusTrap) where T: IonPopover
    {
        b.SetFocusTrap(b.Const(focusTrap));
    }

    /// <summary>
    /// Additional attributes to pass to the popover.
    /// </summary>
    public static void SetHtmlAttributes<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Syntax.Var<System.Collections.Generic.List<object>>> htmlAttributes) where T: IonPopover
    {
        b.SetProperty(b.Props, b.Const("htmlAttributes"), htmlAttributes);
    }

    /// <summary>
    /// If `true`, the popover will open. If `false`, the popover will close. Use this if you need finer grained control over presentation, otherwise just use the popoverController or the `trigger` property. Note: `isOpen` will not automatically be set back to `false` when the popover dismisses. You will need to do that in your code.
    /// </summary>
    public static void SetIsOpen<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonPopover
    {
        b.SetIsOpen(b.Const(true));
    }

    /// <summary>
    /// If `true`, the popover will open. If `false`, the popover will close. Use this if you need finer grained control over presentation, otherwise just use the popoverController or the `trigger` property. Note: `isOpen` will not automatically be set back to `false` when the popover dismisses. You will need to do that in your code.
    /// </summary>
    public static void SetIsOpen<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> isOpen) where T: IonPopover
    {
        b.SetProperty(b.Props, b.Const("isOpen"), isOpen);
    }

    /// <summary>
    /// If `true`, the popover will open. If `false`, the popover will close. Use this if you need finer grained control over presentation, otherwise just use the popoverController or the `trigger` property. Note: `isOpen` will not automatically be set back to `false` when the popover dismisses. You will need to do that in your code.
    /// </summary>
    public static void SetIsOpen<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool isOpen) where T: IonPopover
    {
        b.SetIsOpen(b.Const(isOpen));
    }

    /// <summary>
    /// If `true`, the component passed into `ion-popover` will automatically be mounted when the popover is created. The component will remain mounted even when the popover is dismissed. However, the component will be destroyed when the popover is destroyed. This property is not reactive and should only be used when initially creating a popover.  Note: This feature only applies to inline popovers in JavaScript frameworks such as Angular, React, and Vue.
    /// </summary>
    public static void SetKeepContentsMounted<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonPopover
    {
        b.SetKeepContentsMounted(b.Const(true));
    }

    /// <summary>
    /// If `true`, the component passed into `ion-popover` will automatically be mounted when the popover is created. The component will remain mounted even when the popover is dismissed. However, the component will be destroyed when the popover is destroyed. This property is not reactive and should only be used when initially creating a popover.  Note: This feature only applies to inline popovers in JavaScript frameworks such as Angular, React, and Vue.
    /// </summary>
    public static void SetKeepContentsMounted<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> keepContentsMounted) where T: IonPopover
    {
        b.SetProperty(b.Props, b.Const("keepContentsMounted"), keepContentsMounted);
    }

    /// <summary>
    /// If `true`, the component passed into `ion-popover` will automatically be mounted when the popover is created. The component will remain mounted even when the popover is dismissed. However, the component will be destroyed when the popover is destroyed. This property is not reactive and should only be used when initially creating a popover.  Note: This feature only applies to inline popovers in JavaScript frameworks such as Angular, React, and Vue.
    /// </summary>
    public static void SetKeepContentsMounted<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool keepContentsMounted) where T: IonPopover
    {
        b.SetKeepContentsMounted(b.Const(keepContentsMounted));
    }

    /// <summary>
    /// If `true`, the keyboard will be automatically dismissed when the overlay is presented.
    /// </summary>
    public static void SetKeyboardClose<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonPopover
    {
        b.SetKeyboardClose(b.Const(true));
    }

    /// <summary>
    /// If `true`, the keyboard will be automatically dismissed when the overlay is presented.
    /// </summary>
    public static void SetKeyboardClose<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> keyboardClose) where T: IonPopover
    {
        b.SetProperty(b.Props, b.Const("keyboardClose"), keyboardClose);
    }

    /// <summary>
    /// If `true`, the keyboard will be automatically dismissed when the overlay is presented.
    /// </summary>
    public static void SetKeyboardClose<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool keyboardClose) where T: IonPopover
    {
        b.SetKeyboardClose(b.Const(keyboardClose));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonPopover
    {
        b.SetProperty(b.Props, b.Const("mode"), b.Const("ios"));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonPopover
    {
        b.SetProperty(b.Props, b.Const("mode"), b.Const("md"));
    }

    /// <summary>
    /// Describes what to position the popover relative to. If `"trigger"`, the popover will be positioned relative to the trigger button. If passing in an event, this is determined via event.target. If `"event"`, the popover will be positioned relative to the x/y coordinates of the trigger action. If passing in an event, this is determined via event.clientX and event.clientY.
    /// </summary>
    public static void SetReferenceEvent<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonPopover
    {
        b.SetProperty(b.Props, b.Const("reference"), b.Const("event"));
    }

    /// <summary>
    /// Describes what to position the popover relative to. If `"trigger"`, the popover will be positioned relative to the trigger button. If passing in an event, this is determined via event.target. If `"event"`, the popover will be positioned relative to the x/y coordinates of the trigger action. If passing in an event, this is determined via event.clientX and event.clientY.
    /// </summary>
    public static void SetReferenceTrigger<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonPopover
    {
        b.SetProperty(b.Props, b.Const("reference"), b.Const("trigger"));
    }

    /// <summary>
    /// If `true`, a backdrop will be displayed behind the popover. This property controls whether or not the backdrop darkens the screen when the popover is presented. It does not control whether or not the backdrop is active or present in the DOM.
    /// </summary>
    public static void SetShowBackdrop<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonPopover
    {
        b.SetShowBackdrop(b.Const(true));
    }

    /// <summary>
    /// If `true`, a backdrop will be displayed behind the popover. This property controls whether or not the backdrop darkens the screen when the popover is presented. It does not control whether or not the backdrop is active or present in the DOM.
    /// </summary>
    public static void SetShowBackdrop<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> showBackdrop) where T: IonPopover
    {
        b.SetProperty(b.Props, b.Const("showBackdrop"), showBackdrop);
    }

    /// <summary>
    /// If `true`, a backdrop will be displayed behind the popover. This property controls whether or not the backdrop darkens the screen when the popover is presented. It does not control whether or not the backdrop is active or present in the DOM.
    /// </summary>
    public static void SetShowBackdrop<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool showBackdrop) where T: IonPopover
    {
        b.SetShowBackdrop(b.Const(showBackdrop));
    }

    /// <summary>
    /// Describes which side of the `reference` point to position the popover on. The `"start"` and `"end"` values are RTL-aware, and the `"left"` and `"right"` values are not.
    /// </summary>
    public static void SetSideBottom<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonPopover
    {
        b.SetProperty(b.Props, b.Const("side"), b.Const("bottom"));
    }

    /// <summary>
    /// Describes which side of the `reference` point to position the popover on. The `"start"` and `"end"` values are RTL-aware, and the `"left"` and `"right"` values are not.
    /// </summary>
    public static void SetSideEnd<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonPopover
    {
        b.SetProperty(b.Props, b.Const("side"), b.Const("end"));
    }

    /// <summary>
    /// Describes which side of the `reference` point to position the popover on. The `"start"` and `"end"` values are RTL-aware, and the `"left"` and `"right"` values are not.
    /// </summary>
    public static void SetSideLeft<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonPopover
    {
        b.SetProperty(b.Props, b.Const("side"), b.Const("left"));
    }

    /// <summary>
    /// Describes which side of the `reference` point to position the popover on. The `"start"` and `"end"` values are RTL-aware, and the `"left"` and `"right"` values are not.
    /// </summary>
    public static void SetSideRight<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonPopover
    {
        b.SetProperty(b.Props, b.Const("side"), b.Const("right"));
    }

    /// <summary>
    /// Describes which side of the `reference` point to position the popover on. The `"start"` and `"end"` values are RTL-aware, and the `"left"` and `"right"` values are not.
    /// </summary>
    public static void SetSideStart<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonPopover
    {
        b.SetProperty(b.Props, b.Const("side"), b.Const("start"));
    }

    /// <summary>
    /// Describes which side of the `reference` point to position the popover on. The `"start"` and `"end"` values are RTL-aware, and the `"left"` and `"right"` values are not.
    /// </summary>
    public static void SetSideTop<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonPopover
    {
        b.SetProperty(b.Props, b.Const("side"), b.Const("top"));
    }

    /// <summary>
    /// Describes how to calculate the popover width. If `"cover"`, the popover width will match the width of the trigger. If `"auto"`, the popover width will be set to a static default value.
    /// </summary>
    public static void SetSizeAuto<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonPopover
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const("auto"));
    }

    /// <summary>
    /// Describes how to calculate the popover width. If `"cover"`, the popover width will match the width of the trigger. If `"auto"`, the popover width will be set to a static default value.
    /// </summary>
    public static void SetSizeCover<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonPopover
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const("cover"));
    }

    /// <summary>
    /// If `true`, the popover will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility).
    /// </summary>
    public static void SetTranslucent<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonPopover
    {
        b.SetTranslucent(b.Const(true));
    }

    /// <summary>
    /// If `true`, the popover will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility).
    /// </summary>
    public static void SetTranslucent<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> translucent) where T: IonPopover
    {
        b.SetProperty(b.Props, b.Const("translucent"), translucent);
    }

    /// <summary>
    /// If `true`, the popover will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility).
    /// </summary>
    public static void SetTranslucent<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool translucent) where T: IonPopover
    {
        b.SetTranslucent(b.Const(translucent));
    }

    /// <summary>
    /// An ID corresponding to the trigger element that causes the popover to open. Use the `trigger-action` property to customize the interaction that results in the popover opening.
    /// </summary>
    public static void SetTrigger<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> trigger) where T: IonPopover
    {
        b.SetProperty(b.Props, b.Const("trigger"), trigger);
    }

    /// <summary>
    /// An ID corresponding to the trigger element that causes the popover to open. Use the `trigger-action` property to customize the interaction that results in the popover opening.
    /// </summary>
    public static void SetTrigger<T>(this Metapsi.Syntax.PropsBuilder<T> b, string trigger) where T: IonPopover
    {
        b.SetTrigger(b.Const(trigger));
    }

    /// <summary>
    /// Describes what kind of interaction with the trigger that should cause the popover to open. Does not apply when the `trigger` property is `undefined`. If `"click"`, the popover will be presented when the trigger is left clicked. If `"hover"`, the popover will be presented when a pointer hovers over the trigger. If `"context-menu"`, the popover will be presented when the trigger is right clicked on desktop and long pressed on mobile. This will also prevent your device's normal context menu from appearing.
    /// </summary>
    public static void SetTriggerActionClick<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonPopover
    {
        b.SetProperty(b.Props, b.Const("triggerAction"), b.Const("click"));
    }

    /// <summary>
    /// Describes what kind of interaction with the trigger that should cause the popover to open. Does not apply when the `trigger` property is `undefined`. If `"click"`, the popover will be presented when the trigger is left clicked. If `"hover"`, the popover will be presented when a pointer hovers over the trigger. If `"context-menu"`, the popover will be presented when the trigger is right clicked on desktop and long pressed on mobile. This will also prevent your device's normal context menu from appearing.
    /// </summary>
    public static void SetTriggerActionContextMenu<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonPopover
    {
        b.SetProperty(b.Props, b.Const("triggerAction"), b.Const("context-menu"));
    }

    /// <summary>
    /// Describes what kind of interaction with the trigger that should cause the popover to open. Does not apply when the `trigger` property is `undefined`. If `"click"`, the popover will be presented when the trigger is left clicked. If `"hover"`, the popover will be presented when a pointer hovers over the trigger. If `"context-menu"`, the popover will be presented when the trigger is right clicked on desktop and long pressed on mobile. This will also prevent your device's normal context menu from appearing.
    /// </summary>
    public static void SetTriggerActionHover<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonPopover
    {
        b.SetProperty(b.Props, b.Const("triggerAction"), b.Const("hover"));
    }

    /// <summary>
    /// Emitted after the popover has dismissed. Shorthand for ionPopoverDidDismiss.
    /// </summary>
    public static void OnDidDismiss<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonPopover
    {
        b.SetProperty(b.Props, "ondidDismiss", action);
    }

    /// <summary>
    /// Emitted after the popover has dismissed. Shorthand for ionPopoverDidDismiss.
    /// </summary>
    public static void OnDidDismiss<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonPopover
    {
        b.OnDidDismiss(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the popover has dismissed. Shorthand for ionPopoverDidDismiss.
    /// </summary>
    public static void OnDidDismiss<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonPopover
    {
        b.SetProperty(b.Props, "ondidDismiss", action);
    }

    /// <summary>
    /// Emitted after the popover has dismissed. Shorthand for ionPopoverDidDismiss.
    /// </summary>
    public static void OnDidDismiss<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonPopover
    {
        b.OnDidDismiss(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the popover has dismissed. Shorthand for ionPopoverDidDismiss.
    /// </summary>
    public static void OnDidDismiss<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.CustomEvent<OverlayEventDetail>>> action) where T: IonPopover
    {
        b.SetProperty(b.Props, "ondidDismiss", action);
    }

    /// <summary>
    /// Emitted after the popover has presented. Shorthand for ionPopoverWillDismiss.
    /// </summary>
    public static void OnDidPresent<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonPopover
    {
        b.SetProperty(b.Props, "ondidPresent", action);
    }

    /// <summary>
    /// Emitted after the popover has presented. Shorthand for ionPopoverWillDismiss.
    /// </summary>
    public static void OnDidPresent<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonPopover
    {
        b.OnDidPresent(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the popover has presented. Shorthand for ionPopoverWillDismiss.
    /// </summary>
    public static void OnDidPresent<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonPopover
    {
        b.SetProperty(b.Props, "ondidPresent", action);
    }

    /// <summary>
    /// Emitted after the popover has presented. Shorthand for ionPopoverWillDismiss.
    /// </summary>
    public static void OnDidPresent<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonPopover
    {
        b.OnDidPresent(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the popover has dismissed.
    /// </summary>
    public static void OnIonPopoverDidDismiss<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonPopover
    {
        b.SetProperty(b.Props, "onionPopoverDidDismiss", action);
    }

    /// <summary>
    /// Emitted after the popover has dismissed.
    /// </summary>
    public static void OnIonPopoverDidDismiss<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonPopover
    {
        b.OnIonPopoverDidDismiss(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the popover has dismissed.
    /// </summary>
    public static void OnIonPopoverDidDismiss<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonPopover
    {
        b.SetProperty(b.Props, "onionPopoverDidDismiss", action);
    }

    /// <summary>
    /// Emitted after the popover has dismissed.
    /// </summary>
    public static void OnIonPopoverDidDismiss<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonPopover
    {
        b.OnIonPopoverDidDismiss(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the popover has dismissed.
    /// </summary>
    public static void OnIonPopoverDidDismiss<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.CustomEvent<OverlayEventDetail>>> action) where T: IonPopover
    {
        b.SetProperty(b.Props, "onionPopoverDidDismiss", action);
    }

    /// <summary>
    /// Emitted after the popover has presented.
    /// </summary>
    public static void OnIonPopoverDidPresent<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonPopover
    {
        b.SetProperty(b.Props, "onionPopoverDidPresent", action);
    }

    /// <summary>
    /// Emitted after the popover has presented.
    /// </summary>
    public static void OnIonPopoverDidPresent<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonPopover
    {
        b.OnIonPopoverDidPresent(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the popover has presented.
    /// </summary>
    public static void OnIonPopoverDidPresent<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonPopover
    {
        b.SetProperty(b.Props, "onionPopoverDidPresent", action);
    }

    /// <summary>
    /// Emitted after the popover has presented.
    /// </summary>
    public static void OnIonPopoverDidPresent<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonPopover
    {
        b.OnIonPopoverDidPresent(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted before the popover has dismissed.
    /// </summary>
    public static void OnIonPopoverWillDismiss<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonPopover
    {
        b.SetProperty(b.Props, "onionPopoverWillDismiss", action);
    }

    /// <summary>
    /// Emitted before the popover has dismissed.
    /// </summary>
    public static void OnIonPopoverWillDismiss<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonPopover
    {
        b.OnIonPopoverWillDismiss(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted before the popover has dismissed.
    /// </summary>
    public static void OnIonPopoverWillDismiss<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonPopover
    {
        b.SetProperty(b.Props, "onionPopoverWillDismiss", action);
    }

    /// <summary>
    /// Emitted before the popover has dismissed.
    /// </summary>
    public static void OnIonPopoverWillDismiss<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonPopover
    {
        b.OnIonPopoverWillDismiss(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted before the popover has dismissed.
    /// </summary>
    public static void OnIonPopoverWillDismiss<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.CustomEvent<OverlayEventDetail>>> action) where T: IonPopover
    {
        b.SetProperty(b.Props, "onionPopoverWillDismiss", action);
    }

    /// <summary>
    /// Emitted before the popover has presented.
    /// </summary>
    public static void OnIonPopoverWillPresent<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonPopover
    {
        b.SetProperty(b.Props, "onionPopoverWillPresent", action);
    }

    /// <summary>
    /// Emitted before the popover has presented.
    /// </summary>
    public static void OnIonPopoverWillPresent<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonPopover
    {
        b.OnIonPopoverWillPresent(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted before the popover has presented.
    /// </summary>
    public static void OnIonPopoverWillPresent<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonPopover
    {
        b.SetProperty(b.Props, "onionPopoverWillPresent", action);
    }

    /// <summary>
    /// Emitted before the popover has presented.
    /// </summary>
    public static void OnIonPopoverWillPresent<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonPopover
    {
        b.OnIonPopoverWillPresent(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted before the popover has dismissed. Shorthand for ionPopoverWillDismiss.
    /// </summary>
    public static void OnWillDismiss<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonPopover
    {
        b.SetProperty(b.Props, "onwillDismiss", action);
    }

    /// <summary>
    /// Emitted before the popover has dismissed. Shorthand for ionPopoverWillDismiss.
    /// </summary>
    public static void OnWillDismiss<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonPopover
    {
        b.OnWillDismiss(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted before the popover has dismissed. Shorthand for ionPopoverWillDismiss.
    /// </summary>
    public static void OnWillDismiss<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonPopover
    {
        b.SetProperty(b.Props, "onwillDismiss", action);
    }

    /// <summary>
    /// Emitted before the popover has dismissed. Shorthand for ionPopoverWillDismiss.
    /// </summary>
    public static void OnWillDismiss<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonPopover
    {
        b.OnWillDismiss(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted before the popover has dismissed. Shorthand for ionPopoverWillDismiss.
    /// </summary>
    public static void OnWillDismiss<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.CustomEvent<OverlayEventDetail>>> action) where T: IonPopover
    {
        b.SetProperty(b.Props, "onwillDismiss", action);
    }

    /// <summary>
    /// Emitted before the popover has presented. Shorthand for ionPopoverWillPresent.
    /// </summary>
    public static void OnWillPresent<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonPopover
    {
        b.SetProperty(b.Props, "onwillPresent", action);
    }

    /// <summary>
    /// Emitted before the popover has presented. Shorthand for ionPopoverWillPresent.
    /// </summary>
    public static void OnWillPresent<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonPopover
    {
        b.OnWillPresent(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted before the popover has presented. Shorthand for ionPopoverWillPresent.
    /// </summary>
    public static void OnWillPresent<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonPopover
    {
        b.SetProperty(b.Props, "onwillPresent", action);
    }

    /// <summary>
    /// Emitted before the popover has presented. Shorthand for ionPopoverWillPresent.
    /// </summary>
    public static void OnWillPresent<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonPopover
    {
        b.OnWillPresent(b.MakeAction(action));
    }

}