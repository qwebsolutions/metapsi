using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Ionic;


public partial class IonPopover : IonComponent
{
    public IonPopover() : base("ion-popover") { }
    /// <summary> 
    /// Content is placed inside of the `.popover-content` element.
    /// </summary>
    public static class Slot
    {
    }
    public static class Method
    {
        /// <summary> 
        /// Dismiss the popover overlay after it has been presented.
        /// <para>(data?: any, role?: string, dismissParentPopover?: boolean) =&gt; Promise&lt;boolean&gt;</para>
        /// <para>data Any data to emit in the dismiss events.</para>
        /// <para>role The role of the element that is dismissing the popover. For example, 'cancel' or 'backdrop'.</para>
        /// <para>dismissParentPopover If `true`, dismissing this popover will also dismiss a parent popover if this popover is nested. Defaults to `true`.  This is a no-op if the overlay has not been presented yet. If you want to remove an overlay from the DOM that was never presented, use the [remove](https://developer.mozilla.org/en-US/docs/Web/API/Element/remove) method.</para>
        /// </summary>
        public const string Dismiss = "dismiss";
        /// <summary> 
        /// Returns a promise that resolves when the popover did dismiss.
        /// <para>&lt;T = any&gt;() =&gt; Promise&lt;OverlayEventDetail&lt;T&gt;&gt;</para>
        /// </summary>
        public const string OnDidDismiss = "onDidDismiss";
        /// <summary> 
        /// Returns a promise that resolves when the popover will dismiss.
        /// <para>&lt;T = any&gt;() =&gt; Promise&lt;OverlayEventDetail&lt;T&gt;&gt;</para>
        /// </summary>
        public const string OnWillDismiss = "onWillDismiss";
        /// <summary> 
        /// Present the popover overlay after it has been created. Developers can pass a mouse, touch, or pointer event to position the popover relative to where that event was dispatched.
        /// <para>(event?: MouseEvent | TouchEvent | PointerEvent | CustomEvent) =&gt; Promise&lt;void&gt;</para>
        /// <para>event </para>
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
        return b.Tag("ion-popover", buildAttributes, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static IHtmlNode IonPopover(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("ion-popover", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// Describes how to align the popover content with the `reference` point. Defaults to `"center"` for `ios` mode, and `"start"` for `md` mode.
    /// </summary>
    public static void SetAlignment(this AttributesBuilder<IonPopover> b, string value)
    {
        b.SetAttribute("alignment", value);
    }
    /// <summary>
    /// Describes how to align the popover content with the `reference` point. Defaults to `"center"` for `ios` mode, and `"start"` for `md` mode.
    /// </summary>
    public static void SetAlignmentCenter(this AttributesBuilder<IonPopover> b)
    {
        b.SetAttribute("alignment", "center");
    }
    /// <summary>
    /// Describes how to align the popover content with the `reference` point. Defaults to `"center"` for `ios` mode, and `"start"` for `md` mode.
    /// </summary>
    public static void SetAlignmentEnd(this AttributesBuilder<IonPopover> b)
    {
        b.SetAttribute("alignment", "end");
    }
    /// <summary>
    /// Describes how to align the popover content with the `reference` point. Defaults to `"center"` for `ios` mode, and `"start"` for `md` mode.
    /// </summary>
    public static void SetAlignmentStart(this AttributesBuilder<IonPopover> b)
    {
        b.SetAttribute("alignment", "start");
    }

    /// <summary>
    /// If `true`, the popover will animate.
    /// </summary>
    public static void SetAnimated(this AttributesBuilder<IonPopover> b)
    {
        b.SetAttribute("animated", "");
    }
    /// <summary>
    /// If `true`, the popover will animate.
    /// </summary>
    public static void SetAnimated(this AttributesBuilder<IonPopover> b, bool value)
    {
        if (value) b.SetAttribute("animated", "");
    }

    /// <summary>
    /// If `true`, the popover will display an arrow that points at the `reference` when running in `ios` mode. Does not apply in `md` mode.
    /// </summary>
    public static void SetArrow(this AttributesBuilder<IonPopover> b)
    {
        b.SetAttribute("arrow", "");
    }
    /// <summary>
    /// If `true`, the popover will display an arrow that points at the `reference` when running in `ios` mode. Does not apply in `md` mode.
    /// </summary>
    public static void SetArrow(this AttributesBuilder<IonPopover> b, bool value)
    {
        if (value) b.SetAttribute("arrow", "");
    }

    /// <summary>
    /// If `true`, the popover will be dismissed when the backdrop is clicked.
    /// </summary>
    public static void SetBackdropDismiss(this AttributesBuilder<IonPopover> b)
    {
        b.SetAttribute("backdrop-dismiss", "");
    }
    /// <summary>
    /// If `true`, the popover will be dismissed when the backdrop is clicked.
    /// </summary>
    public static void SetBackdropDismiss(this AttributesBuilder<IonPopover> b, bool value)
    {
        if (value) b.SetAttribute("backdrop-dismiss", "");
    }

    /// <summary>
    /// The component to display inside of the popover. You only need to use this if you are not using a JavaScript framework. Otherwise, you can just slot your component inside of `ion-popover`.
    /// </summary>
    public static void SetComponent(this AttributesBuilder<IonPopover> b, string value)
    {
        b.SetAttribute("component", value);
    }

    /// <summary>
    /// If `true`, the popover will be automatically dismissed when the content has been clicked.
    /// </summary>
    public static void SetDismissOnSelect(this AttributesBuilder<IonPopover> b)
    {
        b.SetAttribute("dismiss-on-select", "");
    }
    /// <summary>
    /// If `true`, the popover will be automatically dismissed when the content has been clicked.
    /// </summary>
    public static void SetDismissOnSelect(this AttributesBuilder<IonPopover> b, bool value)
    {
        if (value) b.SetAttribute("dismiss-on-select", "");
    }

    /// <summary>
    /// The event to pass to the popover animation.
    /// </summary>
    public static void SetEvent(this AttributesBuilder<IonPopover> b, string value)
    {
        b.SetAttribute("event", value);
    }

    /// <summary>
    /// If `true`, the popover will open. If `false`, the popover will close. Use this if you need finer grained control over presentation, otherwise just use the popoverController or the `trigger` property. Note: `isOpen` will not automatically be set back to `false` when the popover dismisses. You will need to do that in your code.
    /// </summary>
    public static void SetIsOpen(this AttributesBuilder<IonPopover> b)
    {
        b.SetAttribute("is-open", "");
    }
    /// <summary>
    /// If `true`, the popover will open. If `false`, the popover will close. Use this if you need finer grained control over presentation, otherwise just use the popoverController or the `trigger` property. Note: `isOpen` will not automatically be set back to `false` when the popover dismisses. You will need to do that in your code.
    /// </summary>
    public static void SetIsOpen(this AttributesBuilder<IonPopover> b, bool value)
    {
        if (value) b.SetAttribute("is-open", "");
    }

    /// <summary>
    /// If `true`, the component passed into `ion-popover` will automatically be mounted when the popover is created. The component will remain mounted even when the popover is dismissed. However, the component will be destroyed when the popover is destroyed. This property is not reactive and should only be used when initially creating a popover.  Note: This feature only applies to inline popovers in JavaScript frameworks such as Angular, React, and Vue.
    /// </summary>
    public static void SetKeepContentsMounted(this AttributesBuilder<IonPopover> b)
    {
        b.SetAttribute("keep-contents-mounted", "");
    }
    /// <summary>
    /// If `true`, the component passed into `ion-popover` will automatically be mounted when the popover is created. The component will remain mounted even when the popover is dismissed. However, the component will be destroyed when the popover is destroyed. This property is not reactive and should only be used when initially creating a popover.  Note: This feature only applies to inline popovers in JavaScript frameworks such as Angular, React, and Vue.
    /// </summary>
    public static void SetKeepContentsMounted(this AttributesBuilder<IonPopover> b, bool value)
    {
        if (value) b.SetAttribute("keep-contents-mounted", "");
    }

    /// <summary>
    /// If `true`, the keyboard will be automatically dismissed when the overlay is presented.
    /// </summary>
    public static void SetKeyboardClose(this AttributesBuilder<IonPopover> b)
    {
        b.SetAttribute("keyboard-close", "");
    }
    /// <summary>
    /// If `true`, the keyboard will be automatically dismissed when the overlay is presented.
    /// </summary>
    public static void SetKeyboardClose(this AttributesBuilder<IonPopover> b, bool value)
    {
        if (value) b.SetAttribute("keyboard-close", "");
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetMode(this AttributesBuilder<IonPopover> b, string value)
    {
        b.SetAttribute("mode", value);
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos(this AttributesBuilder<IonPopover> b)
    {
        b.SetAttribute("mode", "ios");
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd(this AttributesBuilder<IonPopover> b)
    {
        b.SetAttribute("mode", "md");
    }

    /// <summary>
    /// Describes what to position the popover relative to. If `"trigger"`, the popover will be positioned relative to the trigger button. If passing in an event, this is determined via event.target. If `"event"`, the popover will be positioned relative to the x/y coordinates of the trigger action. If passing in an event, this is determined via event.clientX and event.clientY.
    /// </summary>
    public static void SetReference(this AttributesBuilder<IonPopover> b, string value)
    {
        b.SetAttribute("reference", value);
    }
    /// <summary>
    /// Describes what to position the popover relative to. If `"trigger"`, the popover will be positioned relative to the trigger button. If passing in an event, this is determined via event.target. If `"event"`, the popover will be positioned relative to the x/y coordinates of the trigger action. If passing in an event, this is determined via event.clientX and event.clientY.
    /// </summary>
    public static void SetReferenceEvent(this AttributesBuilder<IonPopover> b)
    {
        b.SetAttribute("reference", "event");
    }
    /// <summary>
    /// Describes what to position the popover relative to. If `"trigger"`, the popover will be positioned relative to the trigger button. If passing in an event, this is determined via event.target. If `"event"`, the popover will be positioned relative to the x/y coordinates of the trigger action. If passing in an event, this is determined via event.clientX and event.clientY.
    /// </summary>
    public static void SetReferenceTrigger(this AttributesBuilder<IonPopover> b)
    {
        b.SetAttribute("reference", "trigger");
    }

    /// <summary>
    /// If `true`, a backdrop will be displayed behind the popover. This property controls whether or not the backdrop darkens the screen when the popover is presented. It does not control whether or not the backdrop is active or present in the DOM.
    /// </summary>
    public static void SetShowBackdrop(this AttributesBuilder<IonPopover> b)
    {
        b.SetAttribute("show-backdrop", "");
    }
    /// <summary>
    /// If `true`, a backdrop will be displayed behind the popover. This property controls whether or not the backdrop darkens the screen when the popover is presented. It does not control whether or not the backdrop is active or present in the DOM.
    /// </summary>
    public static void SetShowBackdrop(this AttributesBuilder<IonPopover> b, bool value)
    {
        if (value) b.SetAttribute("show-backdrop", "");
    }

    /// <summary>
    /// Describes which side of the `reference` point to position the popover on. The `"start"` and `"end"` values are RTL-aware, and the `"left"` and `"right"` values are not.
    /// </summary>
    public static void SetSide(this AttributesBuilder<IonPopover> b, string value)
    {
        b.SetAttribute("side", value);
    }
    /// <summary>
    /// Describes which side of the `reference` point to position the popover on. The `"start"` and `"end"` values are RTL-aware, and the `"left"` and `"right"` values are not.
    /// </summary>
    public static void SetSideBottom(this AttributesBuilder<IonPopover> b)
    {
        b.SetAttribute("side", "bottom");
    }
    /// <summary>
    /// Describes which side of the `reference` point to position the popover on. The `"start"` and `"end"` values are RTL-aware, and the `"left"` and `"right"` values are not.
    /// </summary>
    public static void SetSideEnd(this AttributesBuilder<IonPopover> b)
    {
        b.SetAttribute("side", "end");
    }
    /// <summary>
    /// Describes which side of the `reference` point to position the popover on. The `"start"` and `"end"` values are RTL-aware, and the `"left"` and `"right"` values are not.
    /// </summary>
    public static void SetSideLeft(this AttributesBuilder<IonPopover> b)
    {
        b.SetAttribute("side", "left");
    }
    /// <summary>
    /// Describes which side of the `reference` point to position the popover on. The `"start"` and `"end"` values are RTL-aware, and the `"left"` and `"right"` values are not.
    /// </summary>
    public static void SetSideRight(this AttributesBuilder<IonPopover> b)
    {
        b.SetAttribute("side", "right");
    }
    /// <summary>
    /// Describes which side of the `reference` point to position the popover on. The `"start"` and `"end"` values are RTL-aware, and the `"left"` and `"right"` values are not.
    /// </summary>
    public static void SetSideStart(this AttributesBuilder<IonPopover> b)
    {
        b.SetAttribute("side", "start");
    }
    /// <summary>
    /// Describes which side of the `reference` point to position the popover on. The `"start"` and `"end"` values are RTL-aware, and the `"left"` and `"right"` values are not.
    /// </summary>
    public static void SetSideTop(this AttributesBuilder<IonPopover> b)
    {
        b.SetAttribute("side", "top");
    }

    /// <summary>
    /// Describes how to calculate the popover width. If `"cover"`, the popover width will match the width of the trigger. If `"auto"`, the popover width will be set to a static default value.
    /// </summary>
    public static void SetSize(this AttributesBuilder<IonPopover> b, string value)
    {
        b.SetAttribute("size", value);
    }
    /// <summary>
    /// Describes how to calculate the popover width. If `"cover"`, the popover width will match the width of the trigger. If `"auto"`, the popover width will be set to a static default value.
    /// </summary>
    public static void SetSizeAuto(this AttributesBuilder<IonPopover> b)
    {
        b.SetAttribute("size", "auto");
    }
    /// <summary>
    /// Describes how to calculate the popover width. If `"cover"`, the popover width will match the width of the trigger. If `"auto"`, the popover width will be set to a static default value.
    /// </summary>
    public static void SetSizeCover(this AttributesBuilder<IonPopover> b)
    {
        b.SetAttribute("size", "cover");
    }

    /// <summary>
    /// If `true`, the popover will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility).
    /// </summary>
    public static void SetTranslucent(this AttributesBuilder<IonPopover> b)
    {
        b.SetAttribute("translucent", "");
    }
    /// <summary>
    /// If `true`, the popover will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility).
    /// </summary>
    public static void SetTranslucent(this AttributesBuilder<IonPopover> b, bool value)
    {
        if (value) b.SetAttribute("translucent", "");
    }

    /// <summary>
    /// An ID corresponding to the trigger element that causes the popover to open. Use the `trigger-action` property to customize the interaction that results in the popover opening.
    /// </summary>
    public static void SetTrigger(this AttributesBuilder<IonPopover> b, string value)
    {
        b.SetAttribute("trigger", value);
    }

    /// <summary>
    /// Describes what kind of interaction with the trigger that should cause the popover to open. Does not apply when the `trigger` property is `undefined`. If `"click"`, the popover will be presented when the trigger is left clicked. If `"hover"`, the popover will be presented when a pointer hovers over the trigger. If `"context-menu"`, the popover will be presented when the trigger is right clicked on desktop and long pressed on mobile. This will also prevent your device's normal context menu from appearing.
    /// </summary>
    public static void SetTriggerAction(this AttributesBuilder<IonPopover> b, string value)
    {
        b.SetAttribute("trigger-action", value);
    }
    /// <summary>
    /// Describes what kind of interaction with the trigger that should cause the popover to open. Does not apply when the `trigger` property is `undefined`. If `"click"`, the popover will be presented when the trigger is left clicked. If `"hover"`, the popover will be presented when a pointer hovers over the trigger. If `"context-menu"`, the popover will be presented when the trigger is right clicked on desktop and long pressed on mobile. This will also prevent your device's normal context menu from appearing.
    /// </summary>
    public static void SetTriggerActionClick(this AttributesBuilder<IonPopover> b)
    {
        b.SetAttribute("trigger-action", "click");
    }
    /// <summary>
    /// Describes what kind of interaction with the trigger that should cause the popover to open. Does not apply when the `trigger` property is `undefined`. If `"click"`, the popover will be presented when the trigger is left clicked. If `"hover"`, the popover will be presented when a pointer hovers over the trigger. If `"context-menu"`, the popover will be presented when the trigger is right clicked on desktop and long pressed on mobile. This will also prevent your device's normal context menu from appearing.
    /// </summary>
    public static void SetTriggerActionContextMenu(this AttributesBuilder<IonPopover> b)
    {
        b.SetAttribute("trigger-action", "context-menu");
    }
    /// <summary>
    /// Describes what kind of interaction with the trigger that should cause the popover to open. Does not apply when the `trigger` property is `undefined`. If `"click"`, the popover will be presented when the trigger is left clicked. If `"hover"`, the popover will be presented when a pointer hovers over the trigger. If `"context-menu"`, the popover will be presented when the trigger is right clicked on desktop and long pressed on mobile. This will also prevent your device's normal context menu from appearing.
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
    /// Describes how to align the popover content with the `reference` point. Defaults to `"center"` for `ios` mode, and `"start"` for `md` mode.
    /// </summary>
    public static void SetAlignmentCenter<T>(this PropsBuilder<T> b) where T: IonPopover
    {
        b.SetDynamic(b.Props, DynamicProperty.String("alignment"), b.Const("center"));
    }
    /// <summary>
    /// Describes how to align the popover content with the `reference` point. Defaults to `"center"` for `ios` mode, and `"start"` for `md` mode.
    /// </summary>
    public static void SetAlignmentEnd<T>(this PropsBuilder<T> b) where T: IonPopover
    {
        b.SetDynamic(b.Props, DynamicProperty.String("alignment"), b.Const("end"));
    }
    /// <summary>
    /// Describes how to align the popover content with the `reference` point. Defaults to `"center"` for `ios` mode, and `"start"` for `md` mode.
    /// </summary>
    public static void SetAlignmentStart<T>(this PropsBuilder<T> b) where T: IonPopover
    {
        b.SetDynamic(b.Props, DynamicProperty.String("alignment"), b.Const("start"));
    }

    /// <summary>
    /// If `true`, the popover will animate.
    /// </summary>
    public static void SetAnimated<T>(this PropsBuilder<T> b) where T: IonPopover
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("animated"), b.Const(true));
    }

    /// <summary>
    /// If `true`, the popover will display an arrow that points at the `reference` when running in `ios` mode. Does not apply in `md` mode.
    /// </summary>
    public static void SetArrow<T>(this PropsBuilder<T> b) where T: IonPopover
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("arrow"), b.Const(true));
    }

    /// <summary>
    /// If `true`, the popover will be dismissed when the backdrop is clicked.
    /// </summary>
    public static void SetBackdropDismiss<T>(this PropsBuilder<T> b) where T: IonPopover
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("backdropDismiss"), b.Const(true));
    }

    /// <summary>
    /// The component to display inside of the popover. You only need to use this if you are not using a JavaScript framework. Otherwise, you can just slot your component inside of `ion-popover`.
    /// </summary>
    public static void SetComponent<T>(this PropsBuilder<T> b, Var<Metapsi.Ionic.Function> value) where T: IonPopover
    {
        b.SetDynamic(b.Props, new DynamicProperty<Metapsi.Ionic.Function>("component"), value);
    }
    /// <summary>
    /// The component to display inside of the popover. You only need to use this if you are not using a JavaScript framework. Otherwise, you can just slot your component inside of `ion-popover`.
    /// </summary>
    public static void SetComponent<T>(this PropsBuilder<T> b, Metapsi.Ionic.Function value) where T: IonPopover
    {
        b.SetDynamic(b.Props, new DynamicProperty<Metapsi.Ionic.Function>("component"), b.Const(value));
    }
    /// <summary>
    /// The component to display inside of the popover. You only need to use this if you are not using a JavaScript framework. Otherwise, you can just slot your component inside of `ion-popover`.
    /// </summary>
    public static void SetComponent<T>(this PropsBuilder<T> b, Var<HTMLElement> value) where T: IonPopover
    {
        b.SetDynamic(b.Props, new DynamicProperty<HTMLElement>("component"), value);
    }
    /// <summary>
    /// The component to display inside of the popover. You only need to use this if you are not using a JavaScript framework. Otherwise, you can just slot your component inside of `ion-popover`.
    /// </summary>
    public static void SetComponent<T>(this PropsBuilder<T> b, HTMLElement value) where T: IonPopover
    {
        b.SetDynamic(b.Props, new DynamicProperty<HTMLElement>("component"), b.Const(value));
    }
    /// <summary>
    /// The component to display inside of the popover. You only need to use this if you are not using a JavaScript framework. Otherwise, you can just slot your component inside of `ion-popover`.
    /// </summary>
    public static void SetComponent<T>(this PropsBuilder<T> b, Var<string> value) where T: IonPopover
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("component"), value);
    }
    /// <summary>
    /// The component to display inside of the popover. You only need to use this if you are not using a JavaScript framework. Otherwise, you can just slot your component inside of `ion-popover`.
    /// </summary>
    public static void SetComponent<T>(this PropsBuilder<T> b, string value) where T: IonPopover
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("component"), b.Const(value));
    }

    /// <summary>
    /// The data to pass to the popover component. You only need to use this if you are not using a JavaScript framework. Otherwise, you can just set the props directly on your component.
    /// </summary>
    public static void SetComponentProps<T>(this PropsBuilder<T> b, Var<DynamicObject> value) where T: IonPopover
    {
        b.SetDynamic(b.Props, new DynamicProperty<DynamicObject>("componentProps"), value);
    }
    /// <summary>
    /// The data to pass to the popover component. You only need to use this if you are not using a JavaScript framework. Otherwise, you can just set the props directly on your component.
    /// </summary>
    public static void SetComponentProps<T>(this PropsBuilder<T> b, DynamicObject value) where T: IonPopover
    {
        b.SetDynamic(b.Props, new DynamicProperty<DynamicObject>("componentProps"), b.Const(value));
    }

    /// <summary>
    /// If `true`, the popover will be automatically dismissed when the content has been clicked.
    /// </summary>
    public static void SetDismissOnSelect<T>(this PropsBuilder<T> b) where T: IonPopover
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("dismissOnSelect"), b.Const(true));
    }

    /// <summary>
    /// Animation to use when the popover is presented.
    /// </summary>
    public static void SetEnterAnimation<T>(this PropsBuilder<T> b, Var<Func<object,object,Animation>> f) where T: IonPopover
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<object,object,Animation>>("enterAnimation"), f);
    }
    /// <summary>
    /// Animation to use when the popover is presented.
    /// </summary>
    public static void SetEnterAnimation<T>(this PropsBuilder<T> b, Func<SyntaxBuilder,Var<object>,Var<object>,Var<Animation>> f) where T: IonPopover
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<object,object,Animation>>("enterAnimation"), b.Def(f));
    }

    /// <summary>
    /// The event to pass to the popover animation.
    /// </summary>
    public static void SetEvent<T>(this PropsBuilder<T> b, Var<object> value) where T: IonPopover
    {
        b.SetDynamic(b.Props, new DynamicProperty<object>("event"), value);
    }
    /// <summary>
    /// The event to pass to the popover animation.
    /// </summary>
    public static void SetEvent<T>(this PropsBuilder<T> b, object value) where T: IonPopover
    {
        b.SetDynamic(b.Props, new DynamicProperty<object>("event"), b.Const(value));
    }

    /// <summary>
    /// Additional attributes to pass to the popover.
    /// </summary>
    public static void SetHtmlAttributes<T>(this PropsBuilder<T> b, Var<DynamicObject> value) where T: IonPopover
    {
        b.SetDynamic(b.Props, new DynamicProperty<DynamicObject>("htmlAttributes"), value);
    }
    /// <summary>
    /// Additional attributes to pass to the popover.
    /// </summary>
    public static void SetHtmlAttributes<T>(this PropsBuilder<T> b, DynamicObject value) where T: IonPopover
    {
        b.SetDynamic(b.Props, new DynamicProperty<DynamicObject>("htmlAttributes"), b.Const(value));
    }

    /// <summary>
    /// If `true`, the popover will open. If `false`, the popover will close. Use this if you need finer grained control over presentation, otherwise just use the popoverController or the `trigger` property. Note: `isOpen` will not automatically be set back to `false` when the popover dismisses. You will need to do that in your code.
    /// </summary>
    public static void SetIsOpen<T>(this PropsBuilder<T> b) where T: IonPopover
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("isOpen"), b.Const(true));
    }

    /// <summary>
    /// If `true`, the component passed into `ion-popover` will automatically be mounted when the popover is created. The component will remain mounted even when the popover is dismissed. However, the component will be destroyed when the popover is destroyed. This property is not reactive and should only be used when initially creating a popover.  Note: This feature only applies to inline popovers in JavaScript frameworks such as Angular, React, and Vue.
    /// </summary>
    public static void SetKeepContentsMounted<T>(this PropsBuilder<T> b) where T: IonPopover
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("keepContentsMounted"), b.Const(true));
    }

    /// <summary>
    /// If `true`, the keyboard will be automatically dismissed when the overlay is presented.
    /// </summary>
    public static void SetKeyboardClose<T>(this PropsBuilder<T> b) where T: IonPopover
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("keyboardClose"), b.Const(true));
    }

    /// <summary>
    /// Animation to use when the popover is dismissed.
    /// </summary>
    public static void SetLeaveAnimation<T>(this PropsBuilder<T> b, Var<Func<object,object,Animation>> f) where T: IonPopover
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<object,object,Animation>>("leaveAnimation"), f);
    }
    /// <summary>
    /// Animation to use when the popover is dismissed.
    /// </summary>
    public static void SetLeaveAnimation<T>(this PropsBuilder<T> b, Func<SyntaxBuilder,Var<object>,Var<object>,Var<Animation>> f) where T: IonPopover
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<object,object,Animation>>("leaveAnimation"), b.Def(f));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos<T>(this PropsBuilder<T> b) where T: IonPopover
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("ios"));
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd<T>(this PropsBuilder<T> b) where T: IonPopover
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("md"));
    }

    /// <summary>
    /// Describes what to position the popover relative to. If `"trigger"`, the popover will be positioned relative to the trigger button. If passing in an event, this is determined via event.target. If `"event"`, the popover will be positioned relative to the x/y coordinates of the trigger action. If passing in an event, this is determined via event.clientX and event.clientY.
    /// </summary>
    public static void SetReferenceEvent<T>(this PropsBuilder<T> b) where T: IonPopover
    {
        b.SetDynamic(b.Props, DynamicProperty.String("reference"), b.Const("event"));
    }
    /// <summary>
    /// Describes what to position the popover relative to. If `"trigger"`, the popover will be positioned relative to the trigger button. If passing in an event, this is determined via event.target. If `"event"`, the popover will be positioned relative to the x/y coordinates of the trigger action. If passing in an event, this is determined via event.clientX and event.clientY.
    /// </summary>
    public static void SetReferenceTrigger<T>(this PropsBuilder<T> b) where T: IonPopover
    {
        b.SetDynamic(b.Props, DynamicProperty.String("reference"), b.Const("trigger"));
    }

    /// <summary>
    /// If `true`, a backdrop will be displayed behind the popover. This property controls whether or not the backdrop darkens the screen when the popover is presented. It does not control whether or not the backdrop is active or present in the DOM.
    /// </summary>
    public static void SetShowBackdrop<T>(this PropsBuilder<T> b) where T: IonPopover
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("showBackdrop"), b.Const(true));
    }

    /// <summary>
    /// Describes which side of the `reference` point to position the popover on. The `"start"` and `"end"` values are RTL-aware, and the `"left"` and `"right"` values are not.
    /// </summary>
    public static void SetSideBottom<T>(this PropsBuilder<T> b) where T: IonPopover
    {
        b.SetDynamic(b.Props, DynamicProperty.String("side"), b.Const("bottom"));
    }
    /// <summary>
    /// Describes which side of the `reference` point to position the popover on. The `"start"` and `"end"` values are RTL-aware, and the `"left"` and `"right"` values are not.
    /// </summary>
    public static void SetSideEnd<T>(this PropsBuilder<T> b) where T: IonPopover
    {
        b.SetDynamic(b.Props, DynamicProperty.String("side"), b.Const("end"));
    }
    /// <summary>
    /// Describes which side of the `reference` point to position the popover on. The `"start"` and `"end"` values are RTL-aware, and the `"left"` and `"right"` values are not.
    /// </summary>
    public static void SetSideLeft<T>(this PropsBuilder<T> b) where T: IonPopover
    {
        b.SetDynamic(b.Props, DynamicProperty.String("side"), b.Const("left"));
    }
    /// <summary>
    /// Describes which side of the `reference` point to position the popover on. The `"start"` and `"end"` values are RTL-aware, and the `"left"` and `"right"` values are not.
    /// </summary>
    public static void SetSideRight<T>(this PropsBuilder<T> b) where T: IonPopover
    {
        b.SetDynamic(b.Props, DynamicProperty.String("side"), b.Const("right"));
    }
    /// <summary>
    /// Describes which side of the `reference` point to position the popover on. The `"start"` and `"end"` values are RTL-aware, and the `"left"` and `"right"` values are not.
    /// </summary>
    public static void SetSideStart<T>(this PropsBuilder<T> b) where T: IonPopover
    {
        b.SetDynamic(b.Props, DynamicProperty.String("side"), b.Const("start"));
    }
    /// <summary>
    /// Describes which side of the `reference` point to position the popover on. The `"start"` and `"end"` values are RTL-aware, and the `"left"` and `"right"` values are not.
    /// </summary>
    public static void SetSideTop<T>(this PropsBuilder<T> b) where T: IonPopover
    {
        b.SetDynamic(b.Props, DynamicProperty.String("side"), b.Const("top"));
    }

    /// <summary>
    /// Describes how to calculate the popover width. If `"cover"`, the popover width will match the width of the trigger. If `"auto"`, the popover width will be set to a static default value.
    /// </summary>
    public static void SetSizeAuto<T>(this PropsBuilder<T> b) where T: IonPopover
    {
        b.SetDynamic(b.Props, DynamicProperty.String("size"), b.Const("auto"));
    }
    /// <summary>
    /// Describes how to calculate the popover width. If `"cover"`, the popover width will match the width of the trigger. If `"auto"`, the popover width will be set to a static default value.
    /// </summary>
    public static void SetSizeCover<T>(this PropsBuilder<T> b) where T: IonPopover
    {
        b.SetDynamic(b.Props, DynamicProperty.String("size"), b.Const("cover"));
    }

    /// <summary>
    /// If `true`, the popover will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility).
    /// </summary>
    public static void SetTranslucent<T>(this PropsBuilder<T> b) where T: IonPopover
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("translucent"), b.Const(true));
    }

    /// <summary>
    /// An ID corresponding to the trigger element that causes the popover to open. Use the `trigger-action` property to customize the interaction that results in the popover opening.
    /// </summary>
    public static void SetTrigger<T>(this PropsBuilder<T> b, Var<string> value) where T: IonPopover
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("trigger"), value);
    }
    /// <summary>
    /// An ID corresponding to the trigger element that causes the popover to open. Use the `trigger-action` property to customize the interaction that results in the popover opening.
    /// </summary>
    public static void SetTrigger<T>(this PropsBuilder<T> b, string value) where T: IonPopover
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("trigger"), b.Const(value));
    }

    /// <summary>
    /// Describes what kind of interaction with the trigger that should cause the popover to open. Does not apply when the `trigger` property is `undefined`. If `"click"`, the popover will be presented when the trigger is left clicked. If `"hover"`, the popover will be presented when a pointer hovers over the trigger. If `"context-menu"`, the popover will be presented when the trigger is right clicked on desktop and long pressed on mobile. This will also prevent your device's normal context menu from appearing.
    /// </summary>
    public static void SetTriggerActionClick<T>(this PropsBuilder<T> b) where T: IonPopover
    {
        b.SetDynamic(b.Props, DynamicProperty.String("triggerAction"), b.Const("click"));
    }
    /// <summary>
    /// Describes what kind of interaction with the trigger that should cause the popover to open. Does not apply when the `trigger` property is `undefined`. If `"click"`, the popover will be presented when the trigger is left clicked. If `"hover"`, the popover will be presented when a pointer hovers over the trigger. If `"context-menu"`, the popover will be presented when the trigger is right clicked on desktop and long pressed on mobile. This will also prevent your device's normal context menu from appearing.
    /// </summary>
    public static void SetTriggerActionContextMenu<T>(this PropsBuilder<T> b) where T: IonPopover
    {
        b.SetDynamic(b.Props, DynamicProperty.String("triggerAction"), b.Const("context-menu"));
    }
    /// <summary>
    /// Describes what kind of interaction with the trigger that should cause the popover to open. Does not apply when the `trigger` property is `undefined`. If `"click"`, the popover will be presented when the trigger is left clicked. If `"hover"`, the popover will be presented when a pointer hovers over the trigger. If `"context-menu"`, the popover will be presented when the trigger is right clicked on desktop and long pressed on mobile. This will also prevent your device's normal context menu from appearing.
    /// </summary>
    public static void SetTriggerActionHover<T>(this PropsBuilder<T> b) where T: IonPopover
    {
        b.SetDynamic(b.Props, DynamicProperty.String("triggerAction"), b.Const("hover"));
    }

    /// <summary>
    /// Emitted after the popover has dismissed. Shorthand for ionPopoverDidDismiss.
    /// </summary>
    public static void OnDidDismiss<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, OverlayEventDetail>> action) where TComponent: IonPopover
    {
        b.OnEventAction("ondidDismiss", action, "detail");
    }
    /// <summary>
    /// Emitted after the popover has dismissed. Shorthand for ionPopoverDidDismiss.
    /// </summary>
    public static void OnDidDismiss<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<OverlayEventDetail>, Var<TModel>> action) where TComponent: IonPopover
    {
        b.OnEventAction("ondidDismiss", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// Emitted after the popover has presented. Shorthand for ionPopoverWillDismiss.
    /// </summary>
    public static void OnDidPresent<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonPopover
    {
        b.OnEventAction("ondidPresent", action);
    }
    /// <summary>
    /// Emitted after the popover has presented. Shorthand for ionPopoverWillDismiss.
    /// </summary>
    public static void OnDidPresent<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonPopover
    {
        b.OnEventAction("ondidPresent", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the popover has dismissed.
    /// </summary>
    public static void OnIonPopoverDidDismiss<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, OverlayEventDetail>> action) where TComponent: IonPopover
    {
        b.OnEventAction("onionPopoverDidDismiss", action, "detail");
    }
    /// <summary>
    /// Emitted after the popover has dismissed.
    /// </summary>
    public static void OnIonPopoverDidDismiss<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<OverlayEventDetail>, Var<TModel>> action) where TComponent: IonPopover
    {
        b.OnEventAction("onionPopoverDidDismiss", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// Emitted after the popover has presented.
    /// </summary>
    public static void OnIonPopoverDidPresent<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonPopover
    {
        b.OnEventAction("onionPopoverDidPresent", action);
    }
    /// <summary>
    /// Emitted after the popover has presented.
    /// </summary>
    public static void OnIonPopoverDidPresent<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonPopover
    {
        b.OnEventAction("onionPopoverDidPresent", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted before the popover has dismissed.
    /// </summary>
    public static void OnIonPopoverWillDismiss<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, OverlayEventDetail>> action) where TComponent: IonPopover
    {
        b.OnEventAction("onionPopoverWillDismiss", action, "detail");
    }
    /// <summary>
    /// Emitted before the popover has dismissed.
    /// </summary>
    public static void OnIonPopoverWillDismiss<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<OverlayEventDetail>, Var<TModel>> action) where TComponent: IonPopover
    {
        b.OnEventAction("onionPopoverWillDismiss", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// Emitted before the popover has presented.
    /// </summary>
    public static void OnIonPopoverWillPresent<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonPopover
    {
        b.OnEventAction("onionPopoverWillPresent", action);
    }
    /// <summary>
    /// Emitted before the popover has presented.
    /// </summary>
    public static void OnIonPopoverWillPresent<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonPopover
    {
        b.OnEventAction("onionPopoverWillPresent", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted before the popover has dismissed. Shorthand for ionPopoverWillDismiss.
    /// </summary>
    public static void OnWillDismiss<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, OverlayEventDetail>> action) where TComponent: IonPopover
    {
        b.OnEventAction("onwillDismiss", action, "detail");
    }
    /// <summary>
    /// Emitted before the popover has dismissed. Shorthand for ionPopoverWillDismiss.
    /// </summary>
    public static void OnWillDismiss<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<OverlayEventDetail>, Var<TModel>> action) where TComponent: IonPopover
    {
        b.OnEventAction("onwillDismiss", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// Emitted before the popover has presented. Shorthand for ionPopoverWillPresent.
    /// </summary>
    public static void OnWillPresent<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonPopover
    {
        b.OnEventAction("onwillPresent", action);
    }
    /// <summary>
    /// Emitted before the popover has presented. Shorthand for ionPopoverWillPresent.
    /// </summary>
    public static void OnWillPresent<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonPopover
    {
        b.OnEventAction("onwillPresent", b.MakeAction(action));
    }

}

