using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Ionic;


public partial class IonSegment
{
}

public static partial class IonSegmentControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonSegment(this HtmlBuilder b, Action<AttributesBuilder<IonSegment>> buildAttributes, params IHtmlNode[] children)
    {
        return b.IonicTag("ion-segment", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonSegment(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.IonicTag("ion-segment", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonSegment(this HtmlBuilder b, Action<AttributesBuilder<IonSegment>> buildAttributes, List<IHtmlNode> children)
    {
        return b.IonicTag("ion-segment", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonSegment(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.IonicTag("ion-segment", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColor(this AttributesBuilder<IonSegment> b, string color)
    {
        b.SetAttribute("color", color);
    }

    /// <summary>
    /// <para> If `true`, the user cannot interact with the segment. </para>
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<IonSegment> b)
    {
        b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// <para> If `true`, the user cannot interact with the segment. </para>
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<IonSegment> b, bool disabled)
    {
        if (disabled) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetMode(this AttributesBuilder<IonSegment> b, string mode)
    {
        b.SetAttribute("mode", mode);
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeIos(this AttributesBuilder<IonSegment> b)
    {
        b.SetAttribute("mode", "ios");
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeMd(this AttributesBuilder<IonSegment> b)
    {
        b.SetAttribute("mode", "md");
    }

    /// <summary>
    /// <para> If `true`, the segment buttons will overflow and the user can swipe to see them. In addition, this will disable the gesture to drag the indicator between the buttons in order to swipe to see hidden buttons. </para>
    /// </summary>
    public static void SetScrollable(this AttributesBuilder<IonSegment> b)
    {
        b.SetAttribute("scrollable", "");
    }

    /// <summary>
    /// <para> If `true`, the segment buttons will overflow and the user can swipe to see them. In addition, this will disable the gesture to drag the indicator between the buttons in order to swipe to see hidden buttons. </para>
    /// </summary>
    public static void SetScrollable(this AttributesBuilder<IonSegment> b, bool scrollable)
    {
        if (scrollable) b.SetAttribute("scrollable", "");
    }

    /// <summary>
    /// <para> If `true`, navigating to an `ion-segment-button` with the keyboard will focus and select the element. If `false`, keyboard navigation will only focus the `ion-segment-button` element. </para>
    /// </summary>
    public static void SetSelectOnFocus(this AttributesBuilder<IonSegment> b)
    {
        b.SetAttribute("select-on-focus", "");
    }

    /// <summary>
    /// <para> If `true`, navigating to an `ion-segment-button` with the keyboard will focus and select the element. If `false`, keyboard navigation will only focus the `ion-segment-button` element. </para>
    /// </summary>
    public static void SetSelectOnFocus(this AttributesBuilder<IonSegment> b, bool selectOnFocus)
    {
        if (selectOnFocus) b.SetAttribute("select-on-focus", "");
    }

    /// <summary>
    /// <para> If `true`, users will be able to swipe between segment buttons to activate them. </para>
    /// </summary>
    public static void SetSwipeGesture(this AttributesBuilder<IonSegment> b)
    {
        b.SetAttribute("swipe-gesture", "");
    }

    /// <summary>
    /// <para> If `true`, users will be able to swipe between segment buttons to activate them. </para>
    /// </summary>
    public static void SetSwipeGesture(this AttributesBuilder<IonSegment> b, bool swipeGesture)
    {
        if (swipeGesture) b.SetAttribute("swipe-gesture", "");
    }

    /// <summary>
    /// <para> the value of the segment. </para>
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
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorDanger<T>(this PropsBuilder<T> b) where T: IonSegment
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("danger"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorDark<T>(this PropsBuilder<T> b) where T: IonSegment
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("dark"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorLight<T>(this PropsBuilder<T> b) where T: IonSegment
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("light"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorMedium<T>(this PropsBuilder<T> b) where T: IonSegment
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("medium"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorPrimary<T>(this PropsBuilder<T> b) where T: IonSegment
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("primary"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorSecondary<T>(this PropsBuilder<T> b) where T: IonSegment
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("secondary"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorSuccess<T>(this PropsBuilder<T> b) where T: IonSegment
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("success"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorTertiary<T>(this PropsBuilder<T> b) where T: IonSegment
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("tertiary"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorWarning<T>(this PropsBuilder<T> b) where T: IonSegment
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("warning"));
    }


    /// <summary>
    /// <para> If `true`, the user cannot interact with the segment. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b) where T: IonSegment
    {
        b.SetProperty(b.Props, b.Const("disabled"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, the user cannot interact with the segment. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, Var<bool> disabled) where T: IonSegment
    {
        b.SetProperty(b.Props, b.Const("disabled"), disabled);
    }

    /// <summary>
    /// <para> If `true`, the user cannot interact with the segment. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, bool disabled) where T: IonSegment
    {
        b.SetProperty(b.Props, b.Const("disabled"), b.Const(disabled));
    }


    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeIos<T>(this PropsBuilder<T> b) where T: IonSegment
    {
        b.SetProperty(b.Props, b.Const("mode"), b.Const("ios"));
    }


    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeMd<T>(this PropsBuilder<T> b) where T: IonSegment
    {
        b.SetProperty(b.Props, b.Const("mode"), b.Const("md"));
    }


    /// <summary>
    /// <para> If `true`, the segment buttons will overflow and the user can swipe to see them. In addition, this will disable the gesture to drag the indicator between the buttons in order to swipe to see hidden buttons. </para>
    /// </summary>
    public static void SetScrollable<T>(this PropsBuilder<T> b) where T: IonSegment
    {
        b.SetProperty(b.Props, b.Const("scrollable"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, the segment buttons will overflow and the user can swipe to see them. In addition, this will disable the gesture to drag the indicator between the buttons in order to swipe to see hidden buttons. </para>
    /// </summary>
    public static void SetScrollable<T>(this PropsBuilder<T> b, Var<bool> scrollable) where T: IonSegment
    {
        b.SetProperty(b.Props, b.Const("scrollable"), scrollable);
    }

    /// <summary>
    /// <para> If `true`, the segment buttons will overflow and the user can swipe to see them. In addition, this will disable the gesture to drag the indicator between the buttons in order to swipe to see hidden buttons. </para>
    /// </summary>
    public static void SetScrollable<T>(this PropsBuilder<T> b, bool scrollable) where T: IonSegment
    {
        b.SetProperty(b.Props, b.Const("scrollable"), b.Const(scrollable));
    }


    /// <summary>
    /// <para> If `true`, navigating to an `ion-segment-button` with the keyboard will focus and select the element. If `false`, keyboard navigation will only focus the `ion-segment-button` element. </para>
    /// </summary>
    public static void SetSelectOnFocus<T>(this PropsBuilder<T> b) where T: IonSegment
    {
        b.SetProperty(b.Props, b.Const("selectOnFocus"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, navigating to an `ion-segment-button` with the keyboard will focus and select the element. If `false`, keyboard navigation will only focus the `ion-segment-button` element. </para>
    /// </summary>
    public static void SetSelectOnFocus<T>(this PropsBuilder<T> b, Var<bool> selectOnFocus) where T: IonSegment
    {
        b.SetProperty(b.Props, b.Const("selectOnFocus"), selectOnFocus);
    }

    /// <summary>
    /// <para> If `true`, navigating to an `ion-segment-button` with the keyboard will focus and select the element. If `false`, keyboard navigation will only focus the `ion-segment-button` element. </para>
    /// </summary>
    public static void SetSelectOnFocus<T>(this PropsBuilder<T> b, bool selectOnFocus) where T: IonSegment
    {
        b.SetProperty(b.Props, b.Const("selectOnFocus"), b.Const(selectOnFocus));
    }


    /// <summary>
    /// <para> If `true`, users will be able to swipe between segment buttons to activate them. </para>
    /// </summary>
    public static void SetSwipeGesture<T>(this PropsBuilder<T> b) where T: IonSegment
    {
        b.SetProperty(b.Props, b.Const("swipeGesture"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, users will be able to swipe between segment buttons to activate them. </para>
    /// </summary>
    public static void SetSwipeGesture<T>(this PropsBuilder<T> b, Var<bool> swipeGesture) where T: IonSegment
    {
        b.SetProperty(b.Props, b.Const("swipeGesture"), swipeGesture);
    }

    /// <summary>
    /// <para> If `true`, users will be able to swipe between segment buttons to activate them. </para>
    /// </summary>
    public static void SetSwipeGesture<T>(this PropsBuilder<T> b, bool swipeGesture) where T: IonSegment
    {
        b.SetProperty(b.Props, b.Const("swipeGesture"), b.Const(swipeGesture));
    }


    /// <summary>
    /// <para> the value of the segment. </para>
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, Var<int> value) where T: IonSegment
    {
        b.SetProperty(b.Props, b.Const("value"), value);
    }

    /// <summary>
    /// <para> the value of the segment. </para>
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, int value) where T: IonSegment
    {
        b.SetProperty(b.Props, b.Const("value"), b.Const(value));
    }


    /// <summary>
    /// <para> the value of the segment. </para>
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, Var<string> value) where T: IonSegment
    {
        b.SetProperty(b.Props, b.Const("value"), value);
    }

    /// <summary>
    /// <para> the value of the segment. </para>
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, string value) where T: IonSegment
    {
        b.SetProperty(b.Props, b.Const("value"), b.Const(value));
    }


    /// <summary>
    /// <para> Emitted when the value property has changed and any dragging pointer has been released from `ion-segment`.  This event will not emit when programmatically setting the `value` property. </para>
    /// </summary>
    public static void OnIonChange<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, SegmentChangeEventDetail>> action) where TComponent: IonSegment
    {
        b.OnEventAction("onionChange", action, "detail");
    }
    /// <summary>
    /// <para> Emitted when the value property has changed and any dragging pointer has been released from `ion-segment`.  This event will not emit when programmatically setting the `value` property. </para>
    /// </summary>
    public static void OnIonChange<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SegmentChangeEventDetail>, Var<TModel>> action) where TComponent: IonSegment
    {
        b.OnEventAction("onionChange", b.MakeAction(action), "detail");
    }

}

