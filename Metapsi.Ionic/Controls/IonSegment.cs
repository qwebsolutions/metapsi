using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Ionic;


public partial class IonSegment : IonComponent
{
    public IonSegment() : base("ion-segment") { }
}

public static partial class IonSegmentControl
{
    /// <summary>
    /// 
    /// </summary>
    public static IHtmlNode IonSegment(this HtmlBuilder b, Action<AttributesBuilder<IonSegment>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("ion-segment", buildAttributes, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static IHtmlNode IonSegment(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("ion-segment", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor(this AttributesBuilder<IonSegment> b, string value)
    {
        b.SetAttribute("color", value);
    }

    /// <summary>
    /// If `true`, the user cannot interact with the segment.
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<IonSegment> b)
    {
        b.SetAttribute("disabled", "");
    }
    /// <summary>
    /// If `true`, the user cannot interact with the segment.
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<IonSegment> b, bool value)
    {
        if (value) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetMode(this AttributesBuilder<IonSegment> b, string value)
    {
        b.SetAttribute("mode", value);
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos(this AttributesBuilder<IonSegment> b)
    {
        b.SetAttribute("mode", "ios");
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd(this AttributesBuilder<IonSegment> b)
    {
        b.SetAttribute("mode", "md");
    }

    /// <summary>
    /// If `true`, the segment buttons will overflow and the user can swipe to see them. In addition, this will disable the gesture to drag the indicator between the buttons in order to swipe to see hidden buttons.
    /// </summary>
    public static void SetScrollable(this AttributesBuilder<IonSegment> b)
    {
        b.SetAttribute("scrollable", "");
    }
    /// <summary>
    /// If `true`, the segment buttons will overflow and the user can swipe to see them. In addition, this will disable the gesture to drag the indicator between the buttons in order to swipe to see hidden buttons.
    /// </summary>
    public static void SetScrollable(this AttributesBuilder<IonSegment> b, bool value)
    {
        if (value) b.SetAttribute("scrollable", "");
    }

    /// <summary>
    /// If `true`, navigating to an `ion-segment-button` with the keyboard will focus and select the element. If `false`, keyboard navigation will only focus the `ion-segment-button` element.
    /// </summary>
    public static void SetSelectOnFocus(this AttributesBuilder<IonSegment> b)
    {
        b.SetAttribute("select-on-focus", "");
    }
    /// <summary>
    /// If `true`, navigating to an `ion-segment-button` with the keyboard will focus and select the element. If `false`, keyboard navigation will only focus the `ion-segment-button` element.
    /// </summary>
    public static void SetSelectOnFocus(this AttributesBuilder<IonSegment> b, bool value)
    {
        if (value) b.SetAttribute("select-on-focus", "");
    }

    /// <summary>
    /// If `true`, users will be able to swipe between segment buttons to activate them.
    /// </summary>
    public static void SetSwipeGesture(this AttributesBuilder<IonSegment> b)
    {
        b.SetAttribute("swipe-gesture", "");
    }
    /// <summary>
    /// If `true`, users will be able to swipe between segment buttons to activate them.
    /// </summary>
    public static void SetSwipeGesture(this AttributesBuilder<IonSegment> b, bool value)
    {
        if (value) b.SetAttribute("swipe-gesture", "");
    }

    /// <summary>
    /// the value of the segment.
    /// </summary>
    public static void SetValue(this AttributesBuilder<IonSegment> b, string value)
    {
        b.SetAttribute("value", value);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonSegment(this LayoutBuilder b, Action<PropsBuilder<IonSegment>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-segment", buildProps, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonSegment(this LayoutBuilder b, Action<PropsBuilder<IonSegment>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-segment", buildProps, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonSegment(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-segment", children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonSegment(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-segment", children);
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDanger<T>(this PropsBuilder<T> b) where T: IonSegment
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("danger"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDark<T>(this PropsBuilder<T> b) where T: IonSegment
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("dark"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorLight<T>(this PropsBuilder<T> b) where T: IonSegment
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("light"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorMedium<T>(this PropsBuilder<T> b) where T: IonSegment
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("medium"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorPrimary<T>(this PropsBuilder<T> b) where T: IonSegment
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("primary"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSecondary<T>(this PropsBuilder<T> b) where T: IonSegment
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("secondary"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSuccess<T>(this PropsBuilder<T> b) where T: IonSegment
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("success"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorTertiary<T>(this PropsBuilder<T> b) where T: IonSegment
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("tertiary"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorWarning<T>(this PropsBuilder<T> b) where T: IonSegment
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("warning"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor<T>(this PropsBuilder<T> b, Var<string> value) where T: IonSegment
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), value);
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor<T>(this PropsBuilder<T> b, string value) where T: IonSegment
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const(value));
    }

    /// <summary>
    /// If `true`, the user cannot interact with the segment.
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b) where T: IonSegment
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("disabled"), b.Const(true));
    }
    /// <summary>
    /// If `true`, the user cannot interact with the segment.
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, Var<bool> value) where T: IonSegment
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("disabled"), value);
    }
    /// <summary>
    /// If `true`, the user cannot interact with the segment.
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, bool value) where T: IonSegment
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("disabled"), b.Const(value));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos<T>(this PropsBuilder<T> b) where T: IonSegment
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("ios"));
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd<T>(this PropsBuilder<T> b) where T: IonSegment
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("md"));
    }

    /// <summary>
    /// If `true`, the segment buttons will overflow and the user can swipe to see them. In addition, this will disable the gesture to drag the indicator between the buttons in order to swipe to see hidden buttons.
    /// </summary>
    public static void SetScrollable<T>(this PropsBuilder<T> b) where T: IonSegment
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("scrollable"), b.Const(true));
    }
    /// <summary>
    /// If `true`, the segment buttons will overflow and the user can swipe to see them. In addition, this will disable the gesture to drag the indicator between the buttons in order to swipe to see hidden buttons.
    /// </summary>
    public static void SetScrollable<T>(this PropsBuilder<T> b, Var<bool> value) where T: IonSegment
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("scrollable"), value);
    }
    /// <summary>
    /// If `true`, the segment buttons will overflow and the user can swipe to see them. In addition, this will disable the gesture to drag the indicator between the buttons in order to swipe to see hidden buttons.
    /// </summary>
    public static void SetScrollable<T>(this PropsBuilder<T> b, bool value) where T: IonSegment
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("scrollable"), b.Const(value));
    }

    /// <summary>
    /// If `true`, navigating to an `ion-segment-button` with the keyboard will focus and select the element. If `false`, keyboard navigation will only focus the `ion-segment-button` element.
    /// </summary>
    public static void SetSelectOnFocus<T>(this PropsBuilder<T> b) where T: IonSegment
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("selectOnFocus"), b.Const(true));
    }
    /// <summary>
    /// If `true`, navigating to an `ion-segment-button` with the keyboard will focus and select the element. If `false`, keyboard navigation will only focus the `ion-segment-button` element.
    /// </summary>
    public static void SetSelectOnFocus<T>(this PropsBuilder<T> b, Var<bool> value) where T: IonSegment
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("selectOnFocus"), value);
    }
    /// <summary>
    /// If `true`, navigating to an `ion-segment-button` with the keyboard will focus and select the element. If `false`, keyboard navigation will only focus the `ion-segment-button` element.
    /// </summary>
    public static void SetSelectOnFocus<T>(this PropsBuilder<T> b, bool value) where T: IonSegment
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("selectOnFocus"), b.Const(value));
    }

    /// <summary>
    /// If `true`, users will be able to swipe between segment buttons to activate them.
    /// </summary>
    public static void SetSwipeGesture<T>(this PropsBuilder<T> b) where T: IonSegment
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("swipeGesture"), b.Const(true));
    }
    /// <summary>
    /// If `true`, users will be able to swipe between segment buttons to activate them.
    /// </summary>
    public static void SetSwipeGesture<T>(this PropsBuilder<T> b, Var<bool> value) where T: IonSegment
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("swipeGesture"), value);
    }
    /// <summary>
    /// If `true`, users will be able to swipe between segment buttons to activate them.
    /// </summary>
    public static void SetSwipeGesture<T>(this PropsBuilder<T> b, bool value) where T: IonSegment
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("swipeGesture"), b.Const(value));
    }

    /// <summary>
    /// the value of the segment.
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, Var<int> value) where T: IonSegment
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("value"), value);
    }
    /// <summary>
    /// the value of the segment.
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, int value) where T: IonSegment
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("value"), b.Const(value));
    }
    /// <summary>
    /// the value of the segment.
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, Var<string> value) where T: IonSegment
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("value"), value);
    }
    /// <summary>
    /// the value of the segment.
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, string value) where T: IonSegment
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("value"), b.Const(value));
    }

    /// <summary>
    /// Emitted when the value property has changed and any dragging pointer has been released from `ion-segment`.
    /// </summary>
    public static void OnIonChange<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, SegmentChangeEventDetail>> action) where TComponent: IonSegment
    {
        b.OnEventAction("onionChange", action, "detail");
    }
    /// <summary>
    /// Emitted when the value property has changed and any dragging pointer has been released from `ion-segment`.
    /// </summary>
    public static void OnIonChange<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SegmentChangeEventDetail>, Var<TModel>> action) where TComponent: IonSegment
    {
        b.OnEventAction("onionChange", b.MakeAction(action), "detail");
    }

}

