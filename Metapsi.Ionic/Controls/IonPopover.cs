using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Ionic;


public partial class IonPopover
{
    public static class Method
    {
        /// <summary>
        /// <para> Dismiss the popover overlay after it has been presented. </para>
        /// <para> (data?: any, role?: string, dismissParentPopover?: boolean) =&gt; Promise&lt;boolean&gt; </para>
        /// <para> data Any data to emit in the dismiss events. </para>
        /// <para> role The role of the element that is dismissing the popover. For example, 'cancel' or 'backdrop'. </para>
        /// <para> dismissParentPopover If `true`, dismissing this popover will also dismiss a parent popover if this popover is nested. Defaults to `true`.  This is a no-op if the overlay has not been presented yet. If you want to remove an overlay from the DOM that was never presented, use the [remove](https://developer.mozilla.org/en-US/docs/Web/API/Element/remove) method. </para>
        /// </summary>
        public const string Dismiss = "dismiss";
        /// <summary>
        /// <para> Returns a promise that resolves when the popover did dismiss. </para>
        /// <para> &lt;T = any&gt;() =&gt; Promise&lt;OverlayEventDetail&lt;T&gt;&gt; </para>
        /// </summary>
        public const string OnDidDismiss = "onDidDismiss";
        /// <summary>
        /// <para> Returns a promise that resolves when the popover will dismiss. </para>
        /// <para> &lt;T = any&gt;() =&gt; Promise&lt;OverlayEventDetail&lt;T&gt;&gt; </para>
        /// </summary>
        public const string OnWillDismiss = "onWillDismiss";
        /// <summary>
        /// <para> Present the popover overlay after it has been created. Developers can pass a mouse, touch, or pointer event to position the popover relative to where that event was dispatched. </para>
        /// <para> (event?: MouseEvent | TouchEvent | PointerEvent | CustomEvent) =&gt; Promise&lt;void&gt; </para>
        /// <para> event  </para>
        /// </summary>
        public const string Present = "present";
    }
}

public static partial class IonPopoverControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonPopover(this HtmlBuilder b, Action<AttributesBuilder<IonPopover>> buildAttributes, params IHtmlNode[] children)
    {
        return b.IonicTag("ion-popover", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonPopover(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.IonicTag("ion-popover", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonPopover(this HtmlBuilder b, Action<AttributesBuilder<IonPopover>> buildAttributes, List<IHtmlNode> children)
    {
        return b.IonicTag("ion-popover", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonPopover(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.IonicTag("ion-popover", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> Describes how to align the popover content with the `reference` point. Defaults to `"center"` for `ios` mode, and `"start"` for `md` mode. </para>
    /// </summary>
    public static void SetAlignment(this AttributesBuilder<IonPopover> b, string alignment)
    {
        b.SetAttribute("alignment", alignment);
    }

    /// <summary>
    /// <para> Describes how to align the popover content with the `reference` point. Defaults to `"center"` for `ios` mode, and `"start"` for `md` mode. </para>
    /// </summary>
    public static void SetAlignmentCenter(this AttributesBuilder<IonPopover> b)
    {
        b.SetAttribute("alignment", "center");
    }

    /// <summary>
    /// <para> Describes how to align the popover content with the `reference` point. Defaults to `"center"` for `ios` mode, and `"start"` for `md` mode. </para>
    /// </summary>
    public static void SetAlignmentEnd(this AttributesBuilder<IonPopover> b)
    {
        b.SetAttribute("alignment", "end");
    }

    /// <summary>
    /// <para> Describes how to align the popover content with the `reference` point. Defaults to `"center"` for `ios` mode, and `"start"` for `md` mode. </para>
    /// </summary>
    public static void SetAlignmentStart(this AttributesBuilder<IonPopover> b)
    {
        b.SetAttribute("alignment", "start");
    }

    /// <summary>
    /// <para> If `true`, the popover will animate. </para>
    /// </summary>
    public static void SetAnimated(this AttributesBuilder<IonPopover> b)
    {
        b.SetAttribute("animated", "");
    }

    /// <summary>
    /// <para> If `true`, the popover will animate. </para>
    /// </summary>
    public static void SetAnimated(this AttributesBuilder<IonPopover> b, bool animated)
    {
        if (animated) b.SetAttribute("animated", "");
    }

    /// <summary>
    /// <para> If `true`, the popover will display an arrow that points at the `reference` when running in `ios` mode. Does not apply in `md` mode. </para>
    /// </summary>
    public static void SetArrow(this AttributesBuilder<IonPopover> b)
    {
        b.SetAttribute("arrow", "");
    }

    /// <summary>
    /// <para> If `true`, the popover will display an arrow that points at the `reference` when running in `ios` mode. Does not apply in `md` mode. </para>
    /// </summary>
    public static void SetArrow(this AttributesBuilder<IonPopover> b, bool arrow)
    {
        if (arrow) b.SetAttribute("arrow", "");
    }

    /// <summary>
    /// <para> If `true`, the popover will be dismissed when the backdrop is clicked. </para>
    /// </summary>
    public static void SetBackdropDismiss(this AttributesBuilder<IonPopover> b)
    {
        b.SetAttribute("backdrop-dismiss", "");
    }

    /// <summary>
    /// <para> If `true`, the popover will be dismissed when the backdrop is clicked. </para>
    /// </summary>
    public static void SetBackdropDismiss(this AttributesBuilder<IonPopover> b, bool backdropDismiss)
    {
        if (backdropDismiss) b.SetAttribute("backdrop-dismiss", "");
    }

    /// <summary>
    /// <para> The component to display inside of the popover. You only need to use this if you are not using a JavaScript framework. Otherwise, you can just slot your component inside of `ion-popover`. </para>
    /// </summary>
    public static void SetComponent(this AttributesBuilder<IonPopover> b, string component)
    {
        b.SetAttribute("component", component);
    }

    /// <summary>
    /// <para> If `true`, the popover will be automatically dismissed when the content has been clicked. </para>
    /// </summary>
    public static void SetDismissOnSelect(this AttributesBuilder<IonPopover> b)
    {
        b.SetAttribute("dismiss-on-select", "");
    }

    /// <summary>
    /// <para> If `true`, the popover will be automatically dismissed when the content has been clicked. </para>
    /// </summary>
    public static void SetDismissOnSelect(this AttributesBuilder<IonPopover> b, bool dismissOnSelect)
    {
        if (dismissOnSelect) b.SetAttribute("dismiss-on-select", "");
    }

    /// <summary>
    /// <para> The event to pass to the popover animation. </para>
    /// </summary>
    public static void SetEvent(this AttributesBuilder<IonPopover> b, string @event)
    {
        b.SetAttribute("event", @event);
    }

    /// <summary>
    /// <para> If `true`, focus will not be allowed to move outside of this overlay. If `false`, focus will be allowed to move outside of the overlay.  In most scenarios this property should remain set to `true`. Setting this property to `false` can cause severe accessibility issues as users relying on assistive technologies may be able to move focus into a confusing state. We recommend only setting this to `false` when absolutely necessary.  Developers may want to consider disabling focus trapping if this overlay presents a non-Ionic overlay from a 3rd party library. Developers would disable focus trapping on the Ionic overlay when presenting the 3rd party overlay and then re-enable focus trapping when dismissing the 3rd party overlay and moving focus back to the Ionic overlay. </para>
    /// </summary>
    public static void SetFocusTrap(this AttributesBuilder<IonPopover> b)
    {
        b.SetAttribute("focus-trap", "");
    }

    /// <summary>
    /// <para> If `true`, focus will not be allowed to move outside of this overlay. If `false`, focus will be allowed to move outside of the overlay.  In most scenarios this property should remain set to `true`. Setting this property to `false` can cause severe accessibility issues as users relying on assistive technologies may be able to move focus into a confusing state. We recommend only setting this to `false` when absolutely necessary.  Developers may want to consider disabling focus trapping if this overlay presents a non-Ionic overlay from a 3rd party library. Developers would disable focus trapping on the Ionic overlay when presenting the 3rd party overlay and then re-enable focus trapping when dismissing the 3rd party overlay and moving focus back to the Ionic overlay. </para>
    /// </summary>
    public static void SetFocusTrap(this AttributesBuilder<IonPopover> b, bool focusTrap)
    {
        if (focusTrap) b.SetAttribute("focus-trap", "");
    }

    /// <summary>
    /// <para> If `true`, the popover will open. If `false`, the popover will close. Use this if you need finer grained control over presentation, otherwise just use the popoverController or the `trigger` property. Note: `isOpen` will not automatically be set back to `false` when the popover dismisses. You will need to do that in your code. </para>
    /// </summary>
    public static void SetIsOpen(this AttributesBuilder<IonPopover> b)
    {
        b.SetAttribute("is-open", "");
    }

    /// <summary>
    /// <para> If `true`, the popover will open. If `false`, the popover will close. Use this if you need finer grained control over presentation, otherwise just use the popoverController or the `trigger` property. Note: `isOpen` will not automatically be set back to `false` when the popover dismisses. You will need to do that in your code. </para>
    /// </summary>
    public static void SetIsOpen(this AttributesBuilder<IonPopover> b, bool isOpen)
    {
        if (isOpen) b.SetAttribute("is-open", "");
    }

    /// <summary>
    /// <para> If `true`, the component passed into `ion-popover` will automatically be mounted when the popover is created. The component will remain mounted even when the popover is dismissed. However, the component will be destroyed when the popover is destroyed. This property is not reactive and should only be used when initially creating a popover.  Note: This feature only applies to inline popovers in JavaScript frameworks such as Angular, React, and Vue. </para>
    /// </summary>
    public static void SetKeepContentsMounted(this AttributesBuilder<IonPopover> b)
    {
        b.SetAttribute("keep-contents-mounted", "");
    }

    /// <summary>
    /// <para> If `true`, the component passed into `ion-popover` will automatically be mounted when the popover is created. The component will remain mounted even when the popover is dismissed. However, the component will be destroyed when the popover is destroyed. This property is not reactive and should only be used when initially creating a popover.  Note: This feature only applies to inline popovers in JavaScript frameworks such as Angular, React, and Vue. </para>
    /// </summary>
    public static void SetKeepContentsMounted(this AttributesBuilder<IonPopover> b, bool keepContentsMounted)
    {
        if (keepContentsMounted) b.SetAttribute("keep-contents-mounted", "");
    }

    /// <summary>
    /// <para> If `true`, the keyboard will be automatically dismissed when the overlay is presented. </para>
    /// </summary>
    public static void SetKeyboardClose(this AttributesBuilder<IonPopover> b)
    {
        b.SetAttribute("keyboard-close", "");
    }

    /// <summary>
    /// <para> If `true`, the keyboard will be automatically dismissed when the overlay is presented. </para>
    /// </summary>
    public static void SetKeyboardClose(this AttributesBuilder<IonPopover> b, bool keyboardClose)
    {
        if (keyboardClose) b.SetAttribute("keyboard-close", "");
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetMode(this AttributesBuilder<IonPopover> b, string mode)
    {
        b.SetAttribute("mode", mode);
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeIos(this AttributesBuilder<IonPopover> b)
    {
        b.SetAttribute("mode", "ios");
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeMd(this AttributesBuilder<IonPopover> b)
    {
        b.SetAttribute("mode", "md");
    }

    /// <summary>
    /// <para> Describes what to position the popover relative to. If `"trigger"`, the popover will be positioned relative to the trigger button. If passing in an event, this is determined via event.target. If `"event"`, the popover will be positioned relative to the x/y coordinates of the trigger action. If passing in an event, this is determined via event.clientX and event.clientY. </para>
    /// </summary>
    public static void SetReference(this AttributesBuilder<IonPopover> b, string reference)
    {
        b.SetAttribute("reference", reference);
    }

    /// <summary>
    /// <para> Describes what to position the popover relative to. If `"trigger"`, the popover will be positioned relative to the trigger button. If passing in an event, this is determined via event.target. If `"event"`, the popover will be positioned relative to the x/y coordinates of the trigger action. If passing in an event, this is determined via event.clientX and event.clientY. </para>
    /// </summary>
    public static void SetReferenceEvent(this AttributesBuilder<IonPopover> b)
    {
        b.SetAttribute("reference", "event");
    }

    /// <summary>
    /// <para> Describes what to position the popover relative to. If `"trigger"`, the popover will be positioned relative to the trigger button. If passing in an event, this is determined via event.target. If `"event"`, the popover will be positioned relative to the x/y coordinates of the trigger action. If passing in an event, this is determined via event.clientX and event.clientY. </para>
    /// </summary>
    public static void SetReferenceTrigger(this AttributesBuilder<IonPopover> b)
    {
        b.SetAttribute("reference", "trigger");
    }

    /// <summary>
    /// <para> If `true`, a backdrop will be displayed behind the popover. This property controls whether or not the backdrop darkens the screen when the popover is presented. It does not control whether or not the backdrop is active or present in the DOM. </para>
    /// </summary>
    public static void SetShowBackdrop(this AttributesBuilder<IonPopover> b)
    {
        b.SetAttribute("show-backdrop", "");
    }

    /// <summary>
    /// <para> If `true`, a backdrop will be displayed behind the popover. This property controls whether or not the backdrop darkens the screen when the popover is presented. It does not control whether or not the backdrop is active or present in the DOM. </para>
    /// </summary>
    public static void SetShowBackdrop(this AttributesBuilder<IonPopover> b, bool showBackdrop)
    {
        if (showBackdrop) b.SetAttribute("show-backdrop", "");
    }

    /// <summary>
    /// <para> Describes which side of the `reference` point to position the popover on. The `"start"` and `"end"` values are RTL-aware, and the `"left"` and `"right"` values are not. </para>
    /// </summary>
    public static void SetSide(this AttributesBuilder<IonPopover> b, string side)
    {
        b.SetAttribute("side", side);
    }

    /// <summary>
    /// <para> Describes which side of the `reference` point to position the popover on. The `"start"` and `"end"` values are RTL-aware, and the `"left"` and `"right"` values are not. </para>
    /// </summary>
    public static void SetSideBottom(this AttributesBuilder<IonPopover> b)
    {
        b.SetAttribute("side", "bottom");
    }

    /// <summary>
    /// <para> Describes which side of the `reference` point to position the popover on. The `"start"` and `"end"` values are RTL-aware, and the `"left"` and `"right"` values are not. </para>
    /// </summary>
    public static void SetSideEnd(this AttributesBuilder<IonPopover> b)
    {
        b.SetAttribute("side", "end");
    }

    /// <summary>
    /// <para> Describes which side of the `reference` point to position the popover on. The `"start"` and `"end"` values are RTL-aware, and the `"left"` and `"right"` values are not. </para>
    /// </summary>
    public static void SetSideLeft(this AttributesBuilder<IonPopover> b)
    {
        b.SetAttribute("side", "left");
    }

    /// <summary>
    /// <para> Describes which side of the `reference` point to position the popover on. The `"start"` and `"end"` values are RTL-aware, and the `"left"` and `"right"` values are not. </para>
    /// </summary>
    public static void SetSideRight(this AttributesBuilder<IonPopover> b)
    {
        b.SetAttribute("side", "right");
    }

    /// <summary>
    /// <para> Describes which side of the `reference` point to position the popover on. The `"start"` and `"end"` values are RTL-aware, and the `"left"` and `"right"` values are not. </para>
    /// </summary>
    public static void SetSideStart(this AttributesBuilder<IonPopover> b)
    {
        b.SetAttribute("side", "start");
    }

    /// <summary>
    /// <para> Describes which side of the `reference` point to position the popover on. The `"start"` and `"end"` values are RTL-aware, and the `"left"` and `"right"` values are not. </para>
    /// </summary>
    public static void SetSideTop(this AttributesBuilder<IonPopover> b)
    {
        b.SetAttribute("side", "top");
    }

    /// <summary>
    /// <para> Describes how to calculate the popover width. If `"cover"`, the popover width will match the width of the trigger. If `"auto"`, the popover width will be set to a static default value. </para>
    /// </summary>
    public static void SetSize(this AttributesBuilder<IonPopover> b, string size)
    {
        b.SetAttribute("size", size);
    }

    /// <summary>
    /// <para> Describes how to calculate the popover width. If `"cover"`, the popover width will match the width of the trigger. If `"auto"`, the popover width will be set to a static default value. </para>
    /// </summary>
    public static void SetSizeAuto(this AttributesBuilder<IonPopover> b)
    {
        b.SetAttribute("size", "auto");
    }

    /// <summary>
    /// <para> Describes how to calculate the popover width. If `"cover"`, the popover width will match the width of the trigger. If `"auto"`, the popover width will be set to a static default value. </para>
    /// </summary>
    public static void SetSizeCover(this AttributesBuilder<IonPopover> b)
    {
        b.SetAttribute("size", "cover");
    }

    /// <summary>
    /// <para> If `true`, the popover will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility). </para>
    /// </summary>
    public static void SetTranslucent(this AttributesBuilder<IonPopover> b)
    {
        b.SetAttribute("translucent", "");
    }

    /// <summary>
    /// <para> If `true`, the popover will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility). </para>
    /// </summary>
    public static void SetTranslucent(this AttributesBuilder<IonPopover> b, bool translucent)
    {
        if (translucent) b.SetAttribute("translucent", "");
    }

    /// <summary>
    /// <para> An ID corresponding to the trigger element that causes the popover to open. Use the `trigger-action` property to customize the interaction that results in the popover opening. </para>
    /// </summary>
    public static void SetTrigger(this AttributesBuilder<IonPopover> b, string trigger)
    {
        b.SetAttribute("trigger", trigger);
    }

    /// <summary>
    /// <para> Describes what kind of interaction with the trigger that should cause the popover to open. Does not apply when the `trigger` property is `undefined`. If `"click"`, the popover will be presented when the trigger is left clicked. If `"hover"`, the popover will be presented when a pointer hovers over the trigger. If `"context-menu"`, the popover will be presented when the trigger is right clicked on desktop and long pressed on mobile. This will also prevent your device's normal context menu from appearing. </para>
    /// </summary>
    public static void SetTriggerAction(this AttributesBuilder<IonPopover> b, string triggerAction)
    {
        b.SetAttribute("trigger-action", triggerAction);
    }

    /// <summary>
    /// <para> Describes what kind of interaction with the trigger that should cause the popover to open. Does not apply when the `trigger` property is `undefined`. If `"click"`, the popover will be presented when the trigger is left clicked. If `"hover"`, the popover will be presented when a pointer hovers over the trigger. If `"context-menu"`, the popover will be presented when the trigger is right clicked on desktop and long pressed on mobile. This will also prevent your device's normal context menu from appearing. </para>
    /// </summary>
    public static void SetTriggerActionClick(this AttributesBuilder<IonPopover> b)
    {
        b.SetAttribute("trigger-action", "click");
    }

    /// <summary>
    /// <para> Describes what kind of interaction with the trigger that should cause the popover to open. Does not apply when the `trigger` property is `undefined`. If `"click"`, the popover will be presented when the trigger is left clicked. If `"hover"`, the popover will be presented when a pointer hovers over the trigger. If `"context-menu"`, the popover will be presented when the trigger is right clicked on desktop and long pressed on mobile. This will also prevent your device's normal context menu from appearing. </para>
    /// </summary>
    public static void SetTriggerActionContextMenu(this AttributesBuilder<IonPopover> b)
    {
        b.SetAttribute("trigger-action", "context-menu");
    }

    /// <summary>
    /// <para> Describes what kind of interaction with the trigger that should cause the popover to open. Does not apply when the `trigger` property is `undefined`. If `"click"`, the popover will be presented when the trigger is left clicked. If `"hover"`, the popover will be presented when a pointer hovers over the trigger. If `"context-menu"`, the popover will be presented when the trigger is right clicked on desktop and long pressed on mobile. This will also prevent your device's normal context menu from appearing. </para>
    /// </summary>
    public static void SetTriggerActionHover(this AttributesBuilder<IonPopover> b)
    {
        b.SetAttribute("trigger-action", "hover");
    }

    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonPopover(this LayoutBuilder b, Action<PropsBuilder<IonPopover>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-popover", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonPopover(this LayoutBuilder b, Action<PropsBuilder<IonPopover>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-popover", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonPopover(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-popover", children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonPopover(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-popover", children);
    }
    /// <summary>
    /// <para> Describes how to align the popover content with the `reference` point. Defaults to `"center"` for `ios` mode, and `"start"` for `md` mode. </para>
    /// </summary>
    public static void SetAlignmentCenter<T>(this PropsBuilder<T> b) where T: IonPopover
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("alignment"), b.Const("center"));
    }


    /// <summary>
    /// <para> Describes how to align the popover content with the `reference` point. Defaults to `"center"` for `ios` mode, and `"start"` for `md` mode. </para>
    /// </summary>
    public static void SetAlignmentEnd<T>(this PropsBuilder<T> b) where T: IonPopover
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("alignment"), b.Const("end"));
    }


    /// <summary>
    /// <para> Describes how to align the popover content with the `reference` point. Defaults to `"center"` for `ios` mode, and `"start"` for `md` mode. </para>
    /// </summary>
    public static void SetAlignmentStart<T>(this PropsBuilder<T> b) where T: IonPopover
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("alignment"), b.Const("start"));
    }


    /// <summary>
    /// <para> If `true`, the popover will animate. </para>
    /// </summary>
    public static void SetAnimated<T>(this PropsBuilder<T> b) where T: IonPopover
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("animated"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, the popover will animate. </para>
    /// </summary>
    public static void SetAnimated<T>(this PropsBuilder<T> b, Var<bool> animated) where T: IonPopover
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("animated"), animated);
    }

    /// <summary>
    /// <para> If `true`, the popover will animate. </para>
    /// </summary>
    public static void SetAnimated<T>(this PropsBuilder<T> b, bool animated) where T: IonPopover
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("animated"), b.Const(animated));
    }


    /// <summary>
    /// <para> If `true`, the popover will display an arrow that points at the `reference` when running in `ios` mode. Does not apply in `md` mode. </para>
    /// </summary>
    public static void SetArrow<T>(this PropsBuilder<T> b) where T: IonPopover
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("arrow"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, the popover will display an arrow that points at the `reference` when running in `ios` mode. Does not apply in `md` mode. </para>
    /// </summary>
    public static void SetArrow<T>(this PropsBuilder<T> b, Var<bool> arrow) where T: IonPopover
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("arrow"), arrow);
    }

    /// <summary>
    /// <para> If `true`, the popover will display an arrow that points at the `reference` when running in `ios` mode. Does not apply in `md` mode. </para>
    /// </summary>
    public static void SetArrow<T>(this PropsBuilder<T> b, bool arrow) where T: IonPopover
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("arrow"), b.Const(arrow));
    }


    /// <summary>
    /// <para> If `true`, the popover will be dismissed when the backdrop is clicked. </para>
    /// </summary>
    public static void SetBackdropDismiss<T>(this PropsBuilder<T> b) where T: IonPopover
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("backdropDismiss"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, the popover will be dismissed when the backdrop is clicked. </para>
    /// </summary>
    public static void SetBackdropDismiss<T>(this PropsBuilder<T> b, Var<bool> backdropDismiss) where T: IonPopover
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("backdropDismiss"), backdropDismiss);
    }

    /// <summary>
    /// <para> If `true`, the popover will be dismissed when the backdrop is clicked. </para>
    /// </summary>
    public static void SetBackdropDismiss<T>(this PropsBuilder<T> b, bool backdropDismiss) where T: IonPopover
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("backdropDismiss"), b.Const(backdropDismiss));
    }


    /// <summary>
    /// <para> The component to display inside of the popover. You only need to use this if you are not using a JavaScript framework. Otherwise, you can just slot your component inside of `ion-popover`. </para>
    /// </summary>
    public static void SetComponent<T>(this PropsBuilder<T> b, Var<Metapsi.Ionic.Function> component) where T: IonPopover
    {
        b.SetDynamic(b.Props, new DynamicProperty<Metapsi.Ionic.Function>("component"), component);
    }

    /// <summary>
    /// <para> The component to display inside of the popover. You only need to use this if you are not using a JavaScript framework. Otherwise, you can just slot your component inside of `ion-popover`. </para>
    /// </summary>
    public static void SetComponent<T>(this PropsBuilder<T> b, Metapsi.Ionic.Function component) where T: IonPopover
    {
        b.SetDynamic(b.Props, new DynamicProperty<Metapsi.Ionic.Function>("component"), b.Const(component));
    }


    /// <summary>
    /// <para> The component to display inside of the popover. You only need to use this if you are not using a JavaScript framework. Otherwise, you can just slot your component inside of `ion-popover`. </para>
    /// </summary>
    public static void SetComponent<T>(this PropsBuilder<T> b, Var<HTMLElement> component) where T: IonPopover
    {
        b.SetDynamic(b.Props, new DynamicProperty<HTMLElement>("component"), component);
    }

    /// <summary>
    /// <para> The component to display inside of the popover. You only need to use this if you are not using a JavaScript framework. Otherwise, you can just slot your component inside of `ion-popover`. </para>
    /// </summary>
    public static void SetComponent<T>(this PropsBuilder<T> b, HTMLElement component) where T: IonPopover
    {
        b.SetDynamic(b.Props, new DynamicProperty<HTMLElement>("component"), b.Const(component));
    }


    /// <summary>
    /// <para> The component to display inside of the popover. You only need to use this if you are not using a JavaScript framework. Otherwise, you can just slot your component inside of `ion-popover`. </para>
    /// </summary>
    public static void SetComponent<T>(this PropsBuilder<T> b, Var<string> component) where T: IonPopover
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("component"), component);
    }

    /// <summary>
    /// <para> The component to display inside of the popover. You only need to use this if you are not using a JavaScript framework. Otherwise, you can just slot your component inside of `ion-popover`. </para>
    /// </summary>
    public static void SetComponent<T>(this PropsBuilder<T> b, string component) where T: IonPopover
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("component"), b.Const(component));
    }


    /// <summary>
    /// <para> The data to pass to the popover component. You only need to use this if you are not using a JavaScript framework. Otherwise, you can just set the props directly on your component. </para>
    /// </summary>
    public static void SetComponentProps<T>(this PropsBuilder<T> b, Var<DynamicObject> componentProps) where T: IonPopover
    {
        b.SetDynamic(b.Props, new DynamicProperty<DynamicObject>("componentProps"), componentProps);
    }

    /// <summary>
    /// <para> The data to pass to the popover component. You only need to use this if you are not using a JavaScript framework. Otherwise, you can just set the props directly on your component. </para>
    /// </summary>
    public static void SetComponentProps<T>(this PropsBuilder<T> b, DynamicObject componentProps) where T: IonPopover
    {
        b.SetDynamic(b.Props, new DynamicProperty<DynamicObject>("componentProps"), b.Const(componentProps));
    }


    /// <summary>
    /// <para> If `true`, the popover will be automatically dismissed when the content has been clicked. </para>
    /// </summary>
    public static void SetDismissOnSelect<T>(this PropsBuilder<T> b) where T: IonPopover
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("dismissOnSelect"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, the popover will be automatically dismissed when the content has been clicked. </para>
    /// </summary>
    public static void SetDismissOnSelect<T>(this PropsBuilder<T> b, Var<bool> dismissOnSelect) where T: IonPopover
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("dismissOnSelect"), dismissOnSelect);
    }

    /// <summary>
    /// <para> If `true`, the popover will be automatically dismissed when the content has been clicked. </para>
    /// </summary>
    public static void SetDismissOnSelect<T>(this PropsBuilder<T> b, bool dismissOnSelect) where T: IonPopover
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("dismissOnSelect"), b.Const(dismissOnSelect));
    }


    /// <summary>
    /// <para> Animation to use when the popover is presented. </para>
    /// </summary>
    public static void SetEnterAnimation<T>(this PropsBuilder<T> b, Var<System.Func<object,object,Animation>> enterAnimation) where T: IonPopover
    {
        b.SetDynamic(b.Props, new DynamicProperty<System.Func<object,object,Animation>>("enterAnimation"), enterAnimation);
    }

    /// <summary>
    /// <para> Animation to use when the popover is presented. </para>
    /// </summary>
    public static void SetEnterAnimation<T>(this PropsBuilder<T> b, System.Func<object,object,Animation> enterAnimation) where T: IonPopover
    {
        b.SetDynamic(b.Props, new DynamicProperty<System.Func<object,object,Animation>>("enterAnimation"), b.Const(enterAnimation));
    }


    /// <summary>
    /// <para> The event to pass to the popover animation. </para>
    /// </summary>
    public static void SetEvent<T>(this PropsBuilder<T> b, Var<object> @event) where T: IonPopover
    {
        b.SetDynamic(b.Props, new DynamicProperty<object>("event"), @event);
    }

    /// <summary>
    /// <para> The event to pass to the popover animation. </para>
    /// </summary>
    public static void SetEvent<T>(this PropsBuilder<T> b, object @event) where T: IonPopover
    {
        b.SetDynamic(b.Props, new DynamicProperty<object>("event"), b.Const(@event));
    }


    /// <summary>
    /// <para> If `true`, focus will not be allowed to move outside of this overlay. If `false`, focus will be allowed to move outside of the overlay.  In most scenarios this property should remain set to `true`. Setting this property to `false` can cause severe accessibility issues as users relying on assistive technologies may be able to move focus into a confusing state. We recommend only setting this to `false` when absolutely necessary.  Developers may want to consider disabling focus trapping if this overlay presents a non-Ionic overlay from a 3rd party library. Developers would disable focus trapping on the Ionic overlay when presenting the 3rd party overlay and then re-enable focus trapping when dismissing the 3rd party overlay and moving focus back to the Ionic overlay. </para>
    /// </summary>
    public static void SetFocusTrap<T>(this PropsBuilder<T> b) where T: IonPopover
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("focusTrap"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, focus will not be allowed to move outside of this overlay. If `false`, focus will be allowed to move outside of the overlay.  In most scenarios this property should remain set to `true`. Setting this property to `false` can cause severe accessibility issues as users relying on assistive technologies may be able to move focus into a confusing state. We recommend only setting this to `false` when absolutely necessary.  Developers may want to consider disabling focus trapping if this overlay presents a non-Ionic overlay from a 3rd party library. Developers would disable focus trapping on the Ionic overlay when presenting the 3rd party overlay and then re-enable focus trapping when dismissing the 3rd party overlay and moving focus back to the Ionic overlay. </para>
    /// </summary>
    public static void SetFocusTrap<T>(this PropsBuilder<T> b, Var<bool> focusTrap) where T: IonPopover
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("focusTrap"), focusTrap);
    }

    /// <summary>
    /// <para> If `true`, focus will not be allowed to move outside of this overlay. If `false`, focus will be allowed to move outside of the overlay.  In most scenarios this property should remain set to `true`. Setting this property to `false` can cause severe accessibility issues as users relying on assistive technologies may be able to move focus into a confusing state. We recommend only setting this to `false` when absolutely necessary.  Developers may want to consider disabling focus trapping if this overlay presents a non-Ionic overlay from a 3rd party library. Developers would disable focus trapping on the Ionic overlay when presenting the 3rd party overlay and then re-enable focus trapping when dismissing the 3rd party overlay and moving focus back to the Ionic overlay. </para>
    /// </summary>
    public static void SetFocusTrap<T>(this PropsBuilder<T> b, bool focusTrap) where T: IonPopover
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("focusTrap"), b.Const(focusTrap));
    }


    /// <summary>
    /// <para> Additional attributes to pass to the popover. </para>
    /// </summary>
    public static void SetHtmlAttributes<T>(this PropsBuilder<T> b, Var<DynamicObject> htmlAttributes) where T: IonPopover
    {
        b.SetDynamic(b.Props, new DynamicProperty<DynamicObject>("htmlAttributes"), htmlAttributes);
    }

    /// <summary>
    /// <para> Additional attributes to pass to the popover. </para>
    /// </summary>
    public static void SetHtmlAttributes<T>(this PropsBuilder<T> b, DynamicObject htmlAttributes) where T: IonPopover
    {
        b.SetDynamic(b.Props, new DynamicProperty<DynamicObject>("htmlAttributes"), b.Const(htmlAttributes));
    }


    /// <summary>
    /// <para> If `true`, the popover will open. If `false`, the popover will close. Use this if you need finer grained control over presentation, otherwise just use the popoverController or the `trigger` property. Note: `isOpen` will not automatically be set back to `false` when the popover dismisses. You will need to do that in your code. </para>
    /// </summary>
    public static void SetIsOpen<T>(this PropsBuilder<T> b) where T: IonPopover
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("isOpen"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, the popover will open. If `false`, the popover will close. Use this if you need finer grained control over presentation, otherwise just use the popoverController or the `trigger` property. Note: `isOpen` will not automatically be set back to `false` when the popover dismisses. You will need to do that in your code. </para>
    /// </summary>
    public static void SetIsOpen<T>(this PropsBuilder<T> b, Var<bool> isOpen) where T: IonPopover
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("isOpen"), isOpen);
    }

    /// <summary>
    /// <para> If `true`, the popover will open. If `false`, the popover will close. Use this if you need finer grained control over presentation, otherwise just use the popoverController or the `trigger` property. Note: `isOpen` will not automatically be set back to `false` when the popover dismisses. You will need to do that in your code. </para>
    /// </summary>
    public static void SetIsOpen<T>(this PropsBuilder<T> b, bool isOpen) where T: IonPopover
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("isOpen"), b.Const(isOpen));
    }


    /// <summary>
    /// <para> If `true`, the component passed into `ion-popover` will automatically be mounted when the popover is created. The component will remain mounted even when the popover is dismissed. However, the component will be destroyed when the popover is destroyed. This property is not reactive and should only be used when initially creating a popover.  Note: This feature only applies to inline popovers in JavaScript frameworks such as Angular, React, and Vue. </para>
    /// </summary>
    public static void SetKeepContentsMounted<T>(this PropsBuilder<T> b) where T: IonPopover
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("keepContentsMounted"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, the component passed into `ion-popover` will automatically be mounted when the popover is created. The component will remain mounted even when the popover is dismissed. However, the component will be destroyed when the popover is destroyed. This property is not reactive and should only be used when initially creating a popover.  Note: This feature only applies to inline popovers in JavaScript frameworks such as Angular, React, and Vue. </para>
    /// </summary>
    public static void SetKeepContentsMounted<T>(this PropsBuilder<T> b, Var<bool> keepContentsMounted) where T: IonPopover
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("keepContentsMounted"), keepContentsMounted);
    }

    /// <summary>
    /// <para> If `true`, the component passed into `ion-popover` will automatically be mounted when the popover is created. The component will remain mounted even when the popover is dismissed. However, the component will be destroyed when the popover is destroyed. This property is not reactive and should only be used when initially creating a popover.  Note: This feature only applies to inline popovers in JavaScript frameworks such as Angular, React, and Vue. </para>
    /// </summary>
    public static void SetKeepContentsMounted<T>(this PropsBuilder<T> b, bool keepContentsMounted) where T: IonPopover
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("keepContentsMounted"), b.Const(keepContentsMounted));
    }


    /// <summary>
    /// <para> If `true`, the keyboard will be automatically dismissed when the overlay is presented. </para>
    /// </summary>
    public static void SetKeyboardClose<T>(this PropsBuilder<T> b) where T: IonPopover
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("keyboardClose"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, the keyboard will be automatically dismissed when the overlay is presented. </para>
    /// </summary>
    public static void SetKeyboardClose<T>(this PropsBuilder<T> b, Var<bool> keyboardClose) where T: IonPopover
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("keyboardClose"), keyboardClose);
    }

    /// <summary>
    /// <para> If `true`, the keyboard will be automatically dismissed when the overlay is presented. </para>
    /// </summary>
    public static void SetKeyboardClose<T>(this PropsBuilder<T> b, bool keyboardClose) where T: IonPopover
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("keyboardClose"), b.Const(keyboardClose));
    }


    /// <summary>
    /// <para> Animation to use when the popover is dismissed. </para>
    /// </summary>
    public static void SetLeaveAnimation<T>(this PropsBuilder<T> b, Var<System.Func<object,object,Animation>> leaveAnimation) where T: IonPopover
    {
        b.SetDynamic(b.Props, new DynamicProperty<System.Func<object,object,Animation>>("leaveAnimation"), leaveAnimation);
    }

    /// <summary>
    /// <para> Animation to use when the popover is dismissed. </para>
    /// </summary>
    public static void SetLeaveAnimation<T>(this PropsBuilder<T> b, System.Func<object,object,Animation> leaveAnimation) where T: IonPopover
    {
        b.SetDynamic(b.Props, new DynamicProperty<System.Func<object,object,Animation>>("leaveAnimation"), b.Const(leaveAnimation));
    }


    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeIos<T>(this PropsBuilder<T> b) where T: IonPopover
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("mode"), b.Const("ios"));
    }


    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeMd<T>(this PropsBuilder<T> b) where T: IonPopover
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("mode"), b.Const("md"));
    }


    /// <summary>
    /// <para> Describes what to position the popover relative to. If `"trigger"`, the popover will be positioned relative to the trigger button. If passing in an event, this is determined via event.target. If `"event"`, the popover will be positioned relative to the x/y coordinates of the trigger action. If passing in an event, this is determined via event.clientX and event.clientY. </para>
    /// </summary>
    public static void SetReferenceEvent<T>(this PropsBuilder<T> b) where T: IonPopover
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("reference"), b.Const("event"));
    }


    /// <summary>
    /// <para> Describes what to position the popover relative to. If `"trigger"`, the popover will be positioned relative to the trigger button. If passing in an event, this is determined via event.target. If `"event"`, the popover will be positioned relative to the x/y coordinates of the trigger action. If passing in an event, this is determined via event.clientX and event.clientY. </para>
    /// </summary>
    public static void SetReferenceTrigger<T>(this PropsBuilder<T> b) where T: IonPopover
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("reference"), b.Const("trigger"));
    }


    /// <summary>
    /// <para> If `true`, a backdrop will be displayed behind the popover. This property controls whether or not the backdrop darkens the screen when the popover is presented. It does not control whether or not the backdrop is active or present in the DOM. </para>
    /// </summary>
    public static void SetShowBackdrop<T>(this PropsBuilder<T> b) where T: IonPopover
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("showBackdrop"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, a backdrop will be displayed behind the popover. This property controls whether or not the backdrop darkens the screen when the popover is presented. It does not control whether or not the backdrop is active or present in the DOM. </para>
    /// </summary>
    public static void SetShowBackdrop<T>(this PropsBuilder<T> b, Var<bool> showBackdrop) where T: IonPopover
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("showBackdrop"), showBackdrop);
    }

    /// <summary>
    /// <para> If `true`, a backdrop will be displayed behind the popover. This property controls whether or not the backdrop darkens the screen when the popover is presented. It does not control whether or not the backdrop is active or present in the DOM. </para>
    /// </summary>
    public static void SetShowBackdrop<T>(this PropsBuilder<T> b, bool showBackdrop) where T: IonPopover
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("showBackdrop"), b.Const(showBackdrop));
    }


    /// <summary>
    /// <para> Describes which side of the `reference` point to position the popover on. The `"start"` and `"end"` values are RTL-aware, and the `"left"` and `"right"` values are not. </para>
    /// </summary>
    public static void SetSideBottom<T>(this PropsBuilder<T> b) where T: IonPopover
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("side"), b.Const("bottom"));
    }


    /// <summary>
    /// <para> Describes which side of the `reference` point to position the popover on. The `"start"` and `"end"` values are RTL-aware, and the `"left"` and `"right"` values are not. </para>
    /// </summary>
    public static void SetSideEnd<T>(this PropsBuilder<T> b) where T: IonPopover
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("side"), b.Const("end"));
    }


    /// <summary>
    /// <para> Describes which side of the `reference` point to position the popover on. The `"start"` and `"end"` values are RTL-aware, and the `"left"` and `"right"` values are not. </para>
    /// </summary>
    public static void SetSideLeft<T>(this PropsBuilder<T> b) where T: IonPopover
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("side"), b.Const("left"));
    }


    /// <summary>
    /// <para> Describes which side of the `reference` point to position the popover on. The `"start"` and `"end"` values are RTL-aware, and the `"left"` and `"right"` values are not. </para>
    /// </summary>
    public static void SetSideRight<T>(this PropsBuilder<T> b) where T: IonPopover
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("side"), b.Const("right"));
    }


    /// <summary>
    /// <para> Describes which side of the `reference` point to position the popover on. The `"start"` and `"end"` values are RTL-aware, and the `"left"` and `"right"` values are not. </para>
    /// </summary>
    public static void SetSideStart<T>(this PropsBuilder<T> b) where T: IonPopover
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("side"), b.Const("start"));
    }


    /// <summary>
    /// <para> Describes which side of the `reference` point to position the popover on. The `"start"` and `"end"` values are RTL-aware, and the `"left"` and `"right"` values are not. </para>
    /// </summary>
    public static void SetSideTop<T>(this PropsBuilder<T> b) where T: IonPopover
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("side"), b.Const("top"));
    }


    /// <summary>
    /// <para> Describes how to calculate the popover width. If `"cover"`, the popover width will match the width of the trigger. If `"auto"`, the popover width will be set to a static default value. </para>
    /// </summary>
    public static void SetSizeAuto<T>(this PropsBuilder<T> b) where T: IonPopover
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("size"), b.Const("auto"));
    }


    /// <summary>
    /// <para> Describes how to calculate the popover width. If `"cover"`, the popover width will match the width of the trigger. If `"auto"`, the popover width will be set to a static default value. </para>
    /// </summary>
    public static void SetSizeCover<T>(this PropsBuilder<T> b) where T: IonPopover
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("size"), b.Const("cover"));
    }


    /// <summary>
    /// <para> If `true`, the popover will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility). </para>
    /// </summary>
    public static void SetTranslucent<T>(this PropsBuilder<T> b) where T: IonPopover
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("translucent"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, the popover will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility). </para>
    /// </summary>
    public static void SetTranslucent<T>(this PropsBuilder<T> b, Var<bool> translucent) where T: IonPopover
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("translucent"), translucent);
    }

    /// <summary>
    /// <para> If `true`, the popover will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility). </para>
    /// </summary>
    public static void SetTranslucent<T>(this PropsBuilder<T> b, bool translucent) where T: IonPopover
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("translucent"), b.Const(translucent));
    }


    /// <summary>
    /// <para> An ID corresponding to the trigger element that causes the popover to open. Use the `trigger-action` property to customize the interaction that results in the popover opening. </para>
    /// </summary>
    public static void SetTrigger<T>(this PropsBuilder<T> b, Var<string> trigger) where T: IonPopover
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("trigger"), trigger);
    }

    /// <summary>
    /// <para> An ID corresponding to the trigger element that causes the popover to open. Use the `trigger-action` property to customize the interaction that results in the popover opening. </para>
    /// </summary>
    public static void SetTrigger<T>(this PropsBuilder<T> b, string trigger) where T: IonPopover
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("trigger"), b.Const(trigger));
    }


    /// <summary>
    /// <para> Describes what kind of interaction with the trigger that should cause the popover to open. Does not apply when the `trigger` property is `undefined`. If `"click"`, the popover will be presented when the trigger is left clicked. If `"hover"`, the popover will be presented when a pointer hovers over the trigger. If `"context-menu"`, the popover will be presented when the trigger is right clicked on desktop and long pressed on mobile. This will also prevent your device's normal context menu from appearing. </para>
    /// </summary>
    public static void SetTriggerActionClick<T>(this PropsBuilder<T> b) where T: IonPopover
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("triggerAction"), b.Const("click"));
    }


    /// <summary>
    /// <para> Describes what kind of interaction with the trigger that should cause the popover to open. Does not apply when the `trigger` property is `undefined`. If `"click"`, the popover will be presented when the trigger is left clicked. If `"hover"`, the popover will be presented when a pointer hovers over the trigger. If `"context-menu"`, the popover will be presented when the trigger is right clicked on desktop and long pressed on mobile. This will also prevent your device's normal context menu from appearing. </para>
    /// </summary>
    public static void SetTriggerActionContextMenu<T>(this PropsBuilder<T> b) where T: IonPopover
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("triggerAction"), b.Const("context-menu"));
    }


    /// <summary>
    /// <para> Describes what kind of interaction with the trigger that should cause the popover to open. Does not apply when the `trigger` property is `undefined`. If `"click"`, the popover will be presented when the trigger is left clicked. If `"hover"`, the popover will be presented when a pointer hovers over the trigger. If `"context-menu"`, the popover will be presented when the trigger is right clicked on desktop and long pressed on mobile. This will also prevent your device's normal context menu from appearing. </para>
    /// </summary>
    public static void SetTriggerActionHover<T>(this PropsBuilder<T> b) where T: IonPopover
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("triggerAction"), b.Const("hover"));
    }


    /// <summary>
    /// <para> Emitted after the popover has dismissed. Shorthand for ionPopoverDidDismiss. </para>
    /// </summary>
    public static void OnDidDismiss<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, OverlayEventDetail>> action) where TComponent: IonPopover
    {
        b.OnEventAction("ondidDismiss", action, "detail");
    }
    /// <summary>
    /// <para> Emitted after the popover has dismissed. Shorthand for ionPopoverDidDismiss. </para>
    /// </summary>
    public static void OnDidDismiss<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<OverlayEventDetail>, Var<TModel>> action) where TComponent: IonPopover
    {
        b.OnEventAction("ondidDismiss", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// <para> Emitted after the popover has presented. Shorthand for ionPopoverWillDismiss. </para>
    /// </summary>
    public static void OnDidPresent<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonPopover
    {
        b.OnEventAction("ondidPresent", action);
    }
    /// <summary>
    /// <para> Emitted after the popover has presented. Shorthand for ionPopoverWillDismiss. </para>
    /// </summary>
    public static void OnDidPresent<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonPopover
    {
        b.OnEventAction("ondidPresent", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted after the popover has dismissed. </para>
    /// </summary>
    public static void OnIonPopoverDidDismiss<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, OverlayEventDetail>> action) where TComponent: IonPopover
    {
        b.OnEventAction("onionPopoverDidDismiss", action, "detail");
    }
    /// <summary>
    /// <para> Emitted after the popover has dismissed. </para>
    /// </summary>
    public static void OnIonPopoverDidDismiss<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<OverlayEventDetail>, Var<TModel>> action) where TComponent: IonPopover
    {
        b.OnEventAction("onionPopoverDidDismiss", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// <para> Emitted after the popover has presented. </para>
    /// </summary>
    public static void OnIonPopoverDidPresent<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonPopover
    {
        b.OnEventAction("onionPopoverDidPresent", action);
    }
    /// <summary>
    /// <para> Emitted after the popover has presented. </para>
    /// </summary>
    public static void OnIonPopoverDidPresent<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonPopover
    {
        b.OnEventAction("onionPopoverDidPresent", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted before the popover has dismissed. </para>
    /// </summary>
    public static void OnIonPopoverWillDismiss<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, OverlayEventDetail>> action) where TComponent: IonPopover
    {
        b.OnEventAction("onionPopoverWillDismiss", action, "detail");
    }
    /// <summary>
    /// <para> Emitted before the popover has dismissed. </para>
    /// </summary>
    public static void OnIonPopoverWillDismiss<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<OverlayEventDetail>, Var<TModel>> action) where TComponent: IonPopover
    {
        b.OnEventAction("onionPopoverWillDismiss", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// <para> Emitted before the popover has presented. </para>
    /// </summary>
    public static void OnIonPopoverWillPresent<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonPopover
    {
        b.OnEventAction("onionPopoverWillPresent", action);
    }
    /// <summary>
    /// <para> Emitted before the popover has presented. </para>
    /// </summary>
    public static void OnIonPopoverWillPresent<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonPopover
    {
        b.OnEventAction("onionPopoverWillPresent", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted before the popover has dismissed. Shorthand for ionPopoverWillDismiss. </para>
    /// </summary>
    public static void OnWillDismiss<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, OverlayEventDetail>> action) where TComponent: IonPopover
    {
        b.OnEventAction("onwillDismiss", action, "detail");
    }
    /// <summary>
    /// <para> Emitted before the popover has dismissed. Shorthand for ionPopoverWillDismiss. </para>
    /// </summary>
    public static void OnWillDismiss<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<OverlayEventDetail>, Var<TModel>> action) where TComponent: IonPopover
    {
        b.OnEventAction("onwillDismiss", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// <para> Emitted before the popover has presented. Shorthand for ionPopoverWillPresent. </para>
    /// </summary>
    public static void OnWillPresent<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonPopover
    {
        b.OnEventAction("onwillPresent", action);
    }
    /// <summary>
    /// <para> Emitted before the popover has presented. Shorthand for ionPopoverWillPresent. </para>
    /// </summary>
    public static void OnWillPresent<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonPopover
    {
        b.OnEventAction("onwillPresent", b.MakeAction(action));
    }

}

