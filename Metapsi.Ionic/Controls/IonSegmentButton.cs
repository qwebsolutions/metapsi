using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Ionic;


public partial class IonSegmentButton
{
}

public static partial class IonSegmentButtonControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonSegmentButton(this HtmlBuilder b, Action<AttributesBuilder<IonSegmentButton>> buildAttributes, params IHtmlNode[] children)
    {
        return b.IonicTag("ion-segment-button", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonSegmentButton(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.IonicTag("ion-segment-button", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonSegmentButton(this HtmlBuilder b, Action<AttributesBuilder<IonSegmentButton>> buildAttributes, List<IHtmlNode> children)
    {
        return b.IonicTag("ion-segment-button", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonSegmentButton(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.IonicTag("ion-segment-button", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The `id` of the segment content. </para>
    /// </summary>
    public static void SetContentId(this AttributesBuilder<IonSegmentButton> b, string contentId)
    {
        b.SetAttribute("content-id", contentId);
    }

    /// <summary>
    /// <para> If `true`, the user cannot interact with the segment button. </para>
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<IonSegmentButton> b)
    {
        b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// <para> If `true`, the user cannot interact with the segment button. </para>
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<IonSegmentButton> b, bool disabled)
    {
        if (disabled) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// <para> Set the layout of the text and icon in the segment. </para>
    /// </summary>
    public static void SetLayout(this AttributesBuilder<IonSegmentButton> b, string layout)
    {
        b.SetAttribute("layout", layout);
    }

    /// <summary>
    /// <para> Set the layout of the text and icon in the segment. </para>
    /// </summary>
    public static void SetLayoutIconBottom(this AttributesBuilder<IonSegmentButton> b)
    {
        b.SetAttribute("layout", "icon-bottom");
    }

    /// <summary>
    /// <para> Set the layout of the text and icon in the segment. </para>
    /// </summary>
    public static void SetLayoutIconEnd(this AttributesBuilder<IonSegmentButton> b)
    {
        b.SetAttribute("layout", "icon-end");
    }

    /// <summary>
    /// <para> Set the layout of the text and icon in the segment. </para>
    /// </summary>
    public static void SetLayoutIconHide(this AttributesBuilder<IonSegmentButton> b)
    {
        b.SetAttribute("layout", "icon-hide");
    }

    /// <summary>
    /// <para> Set the layout of the text and icon in the segment. </para>
    /// </summary>
    public static void SetLayoutIconStart(this AttributesBuilder<IonSegmentButton> b)
    {
        b.SetAttribute("layout", "icon-start");
    }

    /// <summary>
    /// <para> Set the layout of the text and icon in the segment. </para>
    /// </summary>
    public static void SetLayoutIconTop(this AttributesBuilder<IonSegmentButton> b)
    {
        b.SetAttribute("layout", "icon-top");
    }

    /// <summary>
    /// <para> Set the layout of the text and icon in the segment. </para>
    /// </summary>
    public static void SetLayoutLabelHide(this AttributesBuilder<IonSegmentButton> b)
    {
        b.SetAttribute("layout", "label-hide");
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetMode(this AttributesBuilder<IonSegmentButton> b, string mode)
    {
        b.SetAttribute("mode", mode);
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeIos(this AttributesBuilder<IonSegmentButton> b)
    {
        b.SetAttribute("mode", "ios");
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeMd(this AttributesBuilder<IonSegmentButton> b)
    {
        b.SetAttribute("mode", "md");
    }

    /// <summary>
    /// <para> The type of the button. </para>
    /// </summary>
    public static void SetType(this AttributesBuilder<IonSegmentButton> b, string type)
    {
        b.SetAttribute("type", type);
    }

    /// <summary>
    /// <para> The type of the button. </para>
    /// </summary>
    public static void SetTypeButton(this AttributesBuilder<IonSegmentButton> b)
    {
        b.SetAttribute("type", "button");
    }

    /// <summary>
    /// <para> The type of the button. </para>
    /// </summary>
    public static void SetTypeReset(this AttributesBuilder<IonSegmentButton> b)
    {
        b.SetAttribute("type", "reset");
    }

    /// <summary>
    /// <para> The type of the button. </para>
    /// </summary>
    public static void SetTypeSubmit(this AttributesBuilder<IonSegmentButton> b)
    {
        b.SetAttribute("type", "submit");
    }

    /// <summary>
    /// <para> The value of the segment button. </para>
    /// </summary>
    public static void SetValue(this AttributesBuilder<IonSegmentButton> b, string value)
    {
        b.SetAttribute("value", value);
    }

    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonSegmentButton(this LayoutBuilder b, Action<PropsBuilder<IonSegmentButton>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-segment-button", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonSegmentButton(this LayoutBuilder b, Action<PropsBuilder<IonSegmentButton>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-segment-button", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonSegmentButton(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-segment-button", children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonSegmentButton(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-segment-button", children);
    }
    /// <summary>
    /// <para> The `id` of the segment content. </para>
    /// </summary>
    public static void SetContentId<T>(this PropsBuilder<T> b, Var<string> contentId) where T: IonSegmentButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("contentId"), contentId);
    }

    /// <summary>
    /// <para> The `id` of the segment content. </para>
    /// </summary>
    public static void SetContentId<T>(this PropsBuilder<T> b, string contentId) where T: IonSegmentButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("contentId"), b.Const(contentId));
    }


    /// <summary>
    /// <para> If `true`, the user cannot interact with the segment button. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b) where T: IonSegmentButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, the user cannot interact with the segment button. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, Var<bool> disabled) where T: IonSegmentButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), disabled);
    }

    /// <summary>
    /// <para> If `true`, the user cannot interact with the segment button. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, bool disabled) where T: IonSegmentButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), b.Const(disabled));
    }


    /// <summary>
    /// <para> Set the layout of the text and icon in the segment. </para>
    /// </summary>
    public static void SetLayoutIconBottom<T>(this PropsBuilder<T> b) where T: IonSegmentButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("layout"), b.Const("icon-bottom"));
    }


    /// <summary>
    /// <para> Set the layout of the text and icon in the segment. </para>
    /// </summary>
    public static void SetLayoutIconEnd<T>(this PropsBuilder<T> b) where T: IonSegmentButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("layout"), b.Const("icon-end"));
    }


    /// <summary>
    /// <para> Set the layout of the text and icon in the segment. </para>
    /// </summary>
    public static void SetLayoutIconHide<T>(this PropsBuilder<T> b) where T: IonSegmentButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("layout"), b.Const("icon-hide"));
    }


    /// <summary>
    /// <para> Set the layout of the text and icon in the segment. </para>
    /// </summary>
    public static void SetLayoutIconStart<T>(this PropsBuilder<T> b) where T: IonSegmentButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("layout"), b.Const("icon-start"));
    }


    /// <summary>
    /// <para> Set the layout of the text and icon in the segment. </para>
    /// </summary>
    public static void SetLayoutIconTop<T>(this PropsBuilder<T> b) where T: IonSegmentButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("layout"), b.Const("icon-top"));
    }


    /// <summary>
    /// <para> Set the layout of the text and icon in the segment. </para>
    /// </summary>
    public static void SetLayoutLabelHide<T>(this PropsBuilder<T> b) where T: IonSegmentButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("layout"), b.Const("label-hide"));
    }


    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeIos<T>(this PropsBuilder<T> b) where T: IonSegmentButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("mode"), b.Const("ios"));
    }


    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeMd<T>(this PropsBuilder<T> b) where T: IonSegmentButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("mode"), b.Const("md"));
    }


    /// <summary>
    /// <para> The type of the button. </para>
    /// </summary>
    public static void SetTypeButton<T>(this PropsBuilder<T> b) where T: IonSegmentButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("type"), b.Const("button"));
    }


    /// <summary>
    /// <para> The type of the button. </para>
    /// </summary>
    public static void SetTypeReset<T>(this PropsBuilder<T> b) where T: IonSegmentButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("type"), b.Const("reset"));
    }


    /// <summary>
    /// <para> The type of the button. </para>
    /// </summary>
    public static void SetTypeSubmit<T>(this PropsBuilder<T> b) where T: IonSegmentButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("type"), b.Const("submit"));
    }


    /// <summary>
    /// <para> The value of the segment button. </para>
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, Var<int> value) where T: IonSegmentButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("value"), value);
    }

    /// <summary>
    /// <para> The value of the segment button. </para>
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, int value) where T: IonSegmentButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("value"), b.Const(value));
    }


    /// <summary>
    /// <para> The value of the segment button. </para>
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, Var<string> value) where T: IonSegmentButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("value"), value);
    }

    /// <summary>
    /// <para> The value of the segment button. </para>
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, string value) where T: IonSegmentButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("value"), b.Const(value));
    }


}

