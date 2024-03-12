using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Ionic;


public partial class IonPopover
{
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
    /// Describes how to align the popover content with the `reference` point. Defaults to `"center"` for `ios` mode, and `"start"` for `md` mode.
    /// </summary>
    public static void SetAlignmentCenter(this PropsBuilder<IonPopover> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("alignment"), b.Const("center"));
    }
    /// <summary>
    /// Describes how to align the popover content with the `reference` point. Defaults to `"center"` for `ios` mode, and `"start"` for `md` mode.
    /// </summary>
    public static void SetAlignmentEnd(this PropsBuilder<IonPopover> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("alignment"), b.Const("end"));
    }
    /// <summary>
    /// Describes how to align the popover content with the `reference` point. Defaults to `"center"` for `ios` mode, and `"start"` for `md` mode.
    /// </summary>
    public static void SetAlignmentStart(this PropsBuilder<IonPopover> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("alignment"), b.Const("start"));
    }

    /// <summary>
    /// If `true`, the popover will animate.
    /// </summary>
    public static void SetAnimated(this PropsBuilder<IonPopover> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("animated"), b.Const(true));
    }

    /// <summary>
    /// If `true`, the popover will display an arrow that points at the `reference` when running in `ios` mode. Does not apply in `md` mode.
    /// </summary>
    public static void SetArrow(this PropsBuilder<IonPopover> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("arrow"), b.Const(true));
    }

    /// <summary>
    /// If `true`, the popover will be dismissed when the backdrop is clicked.
    /// </summary>
    public static void SetBackdropDismiss(this PropsBuilder<IonPopover> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("backdropDismiss"), b.Const(true));
    }

    /// <summary>
    /// The component to display inside of the popover. You only need to use this if you are not using a JavaScript framework. Otherwise, you can just slot your component inside of `ion-popover`.
    /// </summary>
    public static void SetComponent(this PropsBuilder<IonPopover> b, Var<Metapsi.Ionic.Function> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<Metapsi.Ionic.Function>("component"), value);
    }
    /// <summary>
    /// The component to display inside of the popover. You only need to use this if you are not using a JavaScript framework. Otherwise, you can just slot your component inside of `ion-popover`.
    /// </summary>
    public static void SetComponent(this PropsBuilder<IonPopover> b, Metapsi.Ionic.Function value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<Metapsi.Ionic.Function>("component"), b.Const(value));
    }
    /// <summary>
    /// The component to display inside of the popover. You only need to use this if you are not using a JavaScript framework. Otherwise, you can just slot your component inside of `ion-popover`.
    /// </summary>
    public static void SetComponent(this PropsBuilder<IonPopover> b, Var<HTMLElement> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HTMLElement>("component"), value);
    }
    /// <summary>
    /// The component to display inside of the popover. You only need to use this if you are not using a JavaScript framework. Otherwise, you can just slot your component inside of `ion-popover`.
    /// </summary>
    public static void SetComponent(this PropsBuilder<IonPopover> b, HTMLElement value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HTMLElement>("component"), b.Const(value));
    }
    /// <summary>
    /// The component to display inside of the popover. You only need to use this if you are not using a JavaScript framework. Otherwise, you can just slot your component inside of `ion-popover`.
    /// </summary>
    public static void SetComponent(this PropsBuilder<IonPopover> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("component"), value);
    }
    /// <summary>
    /// The component to display inside of the popover. You only need to use this if you are not using a JavaScript framework. Otherwise, you can just slot your component inside of `ion-popover`.
    /// </summary>
    public static void SetComponent(this PropsBuilder<IonPopover> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("component"), b.Const(value));
    }

    /// <summary>
    /// The data to pass to the popover component. You only need to use this if you are not using a JavaScript framework. Otherwise, you can just set the props directly on your component.
    /// </summary>
    public static void SetComponentProps(this PropsBuilder<IonPopover> b, Var<object> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<object>("componentProps"), value);
    }
    /// <summary>
    /// The data to pass to the popover component. You only need to use this if you are not using a JavaScript framework. Otherwise, you can just set the props directly on your component.
    /// </summary>
    public static void SetComponentProps(this PropsBuilder<IonPopover> b, object value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<object>("componentProps"), b.Const(value));
    }

    /// <summary>
    /// If `true`, the popover will be automatically dismissed when the content has been clicked.
    /// </summary>
    public static void SetDismissOnSelect(this PropsBuilder<IonPopover> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("dismissOnSelect"), b.Const(true));
    }

    /// <summary>
    /// Animation to use when the popover is presented.
    /// </summary>
    public static void SetEnterAnimation(this PropsBuilder<IonPopover> b, Var<Func<object,object,Animation>> f)
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<object,object,Animation>>("enterAnimation"), f);
    }
    /// <summary>
    /// Animation to use when the popover is presented.
    /// </summary>
    public static void SetEnterAnimation(this PropsBuilder<IonPopover> b, Func<SyntaxBuilder,Var<object>,Var<object>,Var<Animation>> f)
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<object,object,Animation>>("enterAnimation"), b.Def(f));
    }

    /// <summary>
    /// The event to pass to the popover animation.
    /// </summary>
    public static void SetEvent(this PropsBuilder<IonPopover> b, Var<object> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<object>("event"), value);
    }
    /// <summary>
    /// The event to pass to the popover animation.
    /// </summary>
    public static void SetEvent(this PropsBuilder<IonPopover> b, object value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<object>("event"), b.Const(value));
    }

    /// <summary>
    /// Additional attributes to pass to the popover.
    /// </summary>
    public static void SetHtmlAttributes(this PropsBuilder<IonPopover> b, Var<object> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<object>("htmlAttributes"), value);
    }
    /// <summary>
    /// Additional attributes to pass to the popover.
    /// </summary>
    public static void SetHtmlAttributes(this PropsBuilder<IonPopover> b, object value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<object>("htmlAttributes"), b.Const(value));
    }

    /// <summary>
    /// If `true`, the popover will open. If `false`, the popover will close. Use this if you need finer grained control over presentation, otherwise just use the popoverController or the `trigger` property. Note: `isOpen` will not automatically be set back to `false` when the popover dismisses. You will need to do that in your code.
    /// </summary>
    public static void SetIsOpen(this PropsBuilder<IonPopover> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("isOpen"), b.Const(true));
    }

    /// <summary>
    /// If `true`, the component passed into `ion-popover` will automatically be mounted when the popover is created. The component will remain mounted even when the popover is dismissed. However, the component will be destroyed when the popover is destroyed. This property is not reactive and should only be used when initially creating a popover.  Note: This feature only applies to inline popovers in JavaScript frameworks such as Angular, React, and Vue.
    /// </summary>
    public static void SetKeepContentsMounted(this PropsBuilder<IonPopover> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("keepContentsMounted"), b.Const(true));
    }

    /// <summary>
    /// If `true`, the keyboard will be automatically dismissed when the overlay is presented.
    /// </summary>
    public static void SetKeyboardClose(this PropsBuilder<IonPopover> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("keyboardClose"), b.Const(true));
    }

    /// <summary>
    /// Animation to use when the popover is dismissed.
    /// </summary>
    public static void SetLeaveAnimation(this PropsBuilder<IonPopover> b, Var<Func<object,object,Animation>> f)
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<object,object,Animation>>("leaveAnimation"), f);
    }
    /// <summary>
    /// Animation to use when the popover is dismissed.
    /// </summary>
    public static void SetLeaveAnimation(this PropsBuilder<IonPopover> b, Func<SyntaxBuilder,Var<object>,Var<object>,Var<Animation>> f)
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<object,object,Animation>>("leaveAnimation"), b.Def(f));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos(this PropsBuilder<IonPopover> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("ios"));
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd(this PropsBuilder<IonPopover> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("md"));
    }

    /// <summary>
    /// Describes what to position the popover relative to. If `"trigger"`, the popover will be positioned relative to the trigger button. If passing in an event, this is determined via event.target. If `"event"`, the popover will be positioned relative to the x/y coordinates of the trigger action. If passing in an event, this is determined via event.clientX and event.clientY.
    /// </summary>
    public static void SetReferenceEvent(this PropsBuilder<IonPopover> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("reference"), b.Const("event"));
    }
    /// <summary>
    /// Describes what to position the popover relative to. If `"trigger"`, the popover will be positioned relative to the trigger button. If passing in an event, this is determined via event.target. If `"event"`, the popover will be positioned relative to the x/y coordinates of the trigger action. If passing in an event, this is determined via event.clientX and event.clientY.
    /// </summary>
    public static void SetReferenceTrigger(this PropsBuilder<IonPopover> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("reference"), b.Const("trigger"));
    }

    /// <summary>
    /// If `true`, a backdrop will be displayed behind the popover. This property controls whether or not the backdrop darkens the screen when the popover is presented. It does not control whether or not the backdrop is active or present in the DOM.
    /// </summary>
    public static void SetShowBackdrop(this PropsBuilder<IonPopover> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("showBackdrop"), b.Const(true));
    }

    /// <summary>
    /// Describes which side of the `reference` point to position the popover on. The `"start"` and `"end"` values are RTL-aware, and the `"left"` and `"right"` values are not.
    /// </summary>
    public static void SetSideBottom(this PropsBuilder<IonPopover> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("side"), b.Const("bottom"));
    }
    /// <summary>
    /// Describes which side of the `reference` point to position the popover on. The `"start"` and `"end"` values are RTL-aware, and the `"left"` and `"right"` values are not.
    /// </summary>
    public static void SetSideEnd(this PropsBuilder<IonPopover> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("side"), b.Const("end"));
    }
    /// <summary>
    /// Describes which side of the `reference` point to position the popover on. The `"start"` and `"end"` values are RTL-aware, and the `"left"` and `"right"` values are not.
    /// </summary>
    public static void SetSideLeft(this PropsBuilder<IonPopover> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("side"), b.Const("left"));
    }
    /// <summary>
    /// Describes which side of the `reference` point to position the popover on. The `"start"` and `"end"` values are RTL-aware, and the `"left"` and `"right"` values are not.
    /// </summary>
    public static void SetSideRight(this PropsBuilder<IonPopover> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("side"), b.Const("right"));
    }
    /// <summary>
    /// Describes which side of the `reference` point to position the popover on. The `"start"` and `"end"` values are RTL-aware, and the `"left"` and `"right"` values are not.
    /// </summary>
    public static void SetSideStart(this PropsBuilder<IonPopover> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("side"), b.Const("start"));
    }
    /// <summary>
    /// Describes which side of the `reference` point to position the popover on. The `"start"` and `"end"` values are RTL-aware, and the `"left"` and `"right"` values are not.
    /// </summary>
    public static void SetSideTop(this PropsBuilder<IonPopover> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("side"), b.Const("top"));
    }

    /// <summary>
    /// Describes how to calculate the popover width. If `"cover"`, the popover width will match the width of the trigger. If `"auto"`, the popover width will be set to a static default value.
    /// </summary>
    public static void SetSizeAuto(this PropsBuilder<IonPopover> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("size"), b.Const("auto"));
    }
    /// <summary>
    /// Describes how to calculate the popover width. If `"cover"`, the popover width will match the width of the trigger. If `"auto"`, the popover width will be set to a static default value.
    /// </summary>
    public static void SetSizeCover(this PropsBuilder<IonPopover> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("size"), b.Const("cover"));
    }

    /// <summary>
    /// If `true`, the popover will be translucent. Only applies when the mode is `"ios"` and the device supports [`backdrop-filter`](https://developer.mozilla.org/en-US/docs/Web/CSS/backdrop-filter#Browser_compatibility).
    /// </summary>
    public static void SetTranslucent(this PropsBuilder<IonPopover> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("translucent"), b.Const(true));
    }

    /// <summary>
    /// An ID corresponding to the trigger element that causes the popover to open. Use the `trigger-action` property to customize the interaction that results in the popover opening.
    /// </summary>
    public static void SetTrigger(this PropsBuilder<IonPopover> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("trigger"), value);
    }
    /// <summary>
    /// An ID corresponding to the trigger element that causes the popover to open. Use the `trigger-action` property to customize the interaction that results in the popover opening.
    /// </summary>
    public static void SetTrigger(this PropsBuilder<IonPopover> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("trigger"), b.Const(value));
    }

    /// <summary>
    /// Describes what kind of interaction with the trigger that should cause the popover to open. Does not apply when the `trigger` property is `undefined`. If `"click"`, the popover will be presented when the trigger is left clicked. If `"hover"`, the popover will be presented when a pointer hovers over the trigger. If `"context-menu"`, the popover will be presented when the trigger is right clicked on desktop and long pressed on mobile. This will also prevent your device's normal context menu from appearing.
    /// </summary>
    public static void SetTriggerActionClick(this PropsBuilder<IonPopover> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("triggerAction"), b.Const("click"));
    }
    /// <summary>
    /// Describes what kind of interaction with the trigger that should cause the popover to open. Does not apply when the `trigger` property is `undefined`. If `"click"`, the popover will be presented when the trigger is left clicked. If `"hover"`, the popover will be presented when a pointer hovers over the trigger. If `"context-menu"`, the popover will be presented when the trigger is right clicked on desktop and long pressed on mobile. This will also prevent your device's normal context menu from appearing.
    /// </summary>
    public static void SetTriggerActionContextMenu(this PropsBuilder<IonPopover> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("triggerAction"), b.Const("context-menu"));
    }
    /// <summary>
    /// Describes what kind of interaction with the trigger that should cause the popover to open. Does not apply when the `trigger` property is `undefined`. If `"click"`, the popover will be presented when the trigger is left clicked. If `"hover"`, the popover will be presented when a pointer hovers over the trigger. If `"context-menu"`, the popover will be presented when the trigger is right clicked on desktop and long pressed on mobile. This will also prevent your device's normal context menu from appearing.
    /// </summary>
    public static void SetTriggerActionHover(this PropsBuilder<IonPopover> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("triggerAction"), b.Const("hover"));
    }

    /// <summary>
    /// Emitted after the popover has dismissed. Shorthand for ionPopoverDidDismiss.
    /// </summary>
    public static void OnDidDismiss<TModel>(this PropsBuilder<IonPopover> b, Var<HyperType.Action<TModel, OverlayEventDetail>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<OverlayEventDetail>("detail"));
            return b.MakeActionDescriptor<TModel, OverlayEventDetail>(action, value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("ondidDismiss"), eventAction);
    }
    /// <summary>
    /// Emitted after the popover has dismissed. Shorthand for ionPopoverDidDismiss.
    /// </summary>
    public static void OnDidDismiss<TModel>(this PropsBuilder<IonPopover> b, System.Func<SyntaxBuilder, Var<TModel>, Var<OverlayEventDetail>, Var<TModel>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<OverlayEventDetail>("detail"));
            return b.MakeActionDescriptor<TModel, OverlayEventDetail>(b.MakeAction(action), value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("ondidDismiss"), eventAction);
    }

    /// <summary>
    /// Emitted after the popover has presented. Shorthand for ionPopoverWillDismiss.
    /// </summary>
    public static void OnDidPresent<TModel>(this PropsBuilder<IonPopover> b, Var<HyperType.Action<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel>>("ondidPresent"), action);
    }
    /// <summary>
    /// Emitted after the popover has presented. Shorthand for ionPopoverWillDismiss.
    /// </summary>
    public static void OnDidPresent<TModel>(this PropsBuilder<IonPopover> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel>>("ondidPresent"), b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the popover has dismissed.
    /// </summary>
    public static void OnIonPopoverDidDismiss<TModel>(this PropsBuilder<IonPopover> b, Var<HyperType.Action<TModel, OverlayEventDetail>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<OverlayEventDetail>("detail"));
            return b.MakeActionDescriptor<TModel, OverlayEventDetail>(action, value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onionPopoverDidDismiss"), eventAction);
    }
    /// <summary>
    /// Emitted after the popover has dismissed.
    /// </summary>
    public static void OnIonPopoverDidDismiss<TModel>(this PropsBuilder<IonPopover> b, System.Func<SyntaxBuilder, Var<TModel>, Var<OverlayEventDetail>, Var<TModel>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<OverlayEventDetail>("detail"));
            return b.MakeActionDescriptor<TModel, OverlayEventDetail>(b.MakeAction(action), value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onionPopoverDidDismiss"), eventAction);
    }

    /// <summary>
    /// Emitted after the popover has presented.
    /// </summary>
    public static void OnIonPopoverDidPresent<TModel>(this PropsBuilder<IonPopover> b, Var<HyperType.Action<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel>>("onionPopoverDidPresent"), action);
    }
    /// <summary>
    /// Emitted after the popover has presented.
    /// </summary>
    public static void OnIonPopoverDidPresent<TModel>(this PropsBuilder<IonPopover> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel>>("onionPopoverDidPresent"), b.MakeAction(action));
    }

    /// <summary>
    /// Emitted before the popover has dismissed.
    /// </summary>
    public static void OnIonPopoverWillDismiss<TModel>(this PropsBuilder<IonPopover> b, Var<HyperType.Action<TModel, OverlayEventDetail>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<OverlayEventDetail>("detail"));
            return b.MakeActionDescriptor<TModel, OverlayEventDetail>(action, value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onionPopoverWillDismiss"), eventAction);
    }
    /// <summary>
    /// Emitted before the popover has dismissed.
    /// </summary>
    public static void OnIonPopoverWillDismiss<TModel>(this PropsBuilder<IonPopover> b, System.Func<SyntaxBuilder, Var<TModel>, Var<OverlayEventDetail>, Var<TModel>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<OverlayEventDetail>("detail"));
            return b.MakeActionDescriptor<TModel, OverlayEventDetail>(b.MakeAction(action), value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onionPopoverWillDismiss"), eventAction);
    }

    /// <summary>
    /// Emitted before the popover has presented.
    /// </summary>
    public static void OnIonPopoverWillPresent<TModel>(this PropsBuilder<IonPopover> b, Var<HyperType.Action<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel>>("onionPopoverWillPresent"), action);
    }
    /// <summary>
    /// Emitted before the popover has presented.
    /// </summary>
    public static void OnIonPopoverWillPresent<TModel>(this PropsBuilder<IonPopover> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel>>("onionPopoverWillPresent"), b.MakeAction(action));
    }

    /// <summary>
    /// Emitted before the popover has dismissed. Shorthand for ionPopoverWillDismiss.
    /// </summary>
    public static void OnWillDismiss<TModel>(this PropsBuilder<IonPopover> b, Var<HyperType.Action<TModel, OverlayEventDetail>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<OverlayEventDetail>("detail"));
            return b.MakeActionDescriptor<TModel, OverlayEventDetail>(action, value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onwillDismiss"), eventAction);
    }
    /// <summary>
    /// Emitted before the popover has dismissed. Shorthand for ionPopoverWillDismiss.
    /// </summary>
    public static void OnWillDismiss<TModel>(this PropsBuilder<IonPopover> b, System.Func<SyntaxBuilder, Var<TModel>, Var<OverlayEventDetail>, Var<TModel>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<OverlayEventDetail>("detail"));
            return b.MakeActionDescriptor<TModel, OverlayEventDetail>(b.MakeAction(action), value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onwillDismiss"), eventAction);
    }

    /// <summary>
    /// Emitted before the popover has presented. Shorthand for ionPopoverWillPresent.
    /// </summary>
    public static void OnWillPresent<TModel>(this PropsBuilder<IonPopover> b, Var<HyperType.Action<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel>>("onwillPresent"), action);
    }
    /// <summary>
    /// Emitted before the popover has presented. Shorthand for ionPopoverWillPresent.
    /// </summary>
    public static void OnWillPresent<TModel>(this PropsBuilder<IonPopover> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel>>("onwillPresent"), b.MakeAction(action));
    }

}

