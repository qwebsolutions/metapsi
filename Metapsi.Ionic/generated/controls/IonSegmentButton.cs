using Metapsi.Html;
using Metapsi.Syntax;
using Metapsi.Hyperapp;

namespace Metapsi.Ionic;

/// <summary>
/// 
/// </summary>
public partial class IonSegmentButton
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
    }
}
/// <summary>
/// Setter extensions of IonSegmentButton
/// </summary>
public static partial class IonSegmentButtonControl
{
    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonSegmentButton(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonSegmentButton>> buildAttributes, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.IonicTag("ion-segment-button", buildAttributes, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonSegmentButton(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.IonicTag("ion-segment-button", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonSegmentButton(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonSegmentButton>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.IonicTag("ion-segment-button", buildAttributes, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonSegmentButton(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.IonicTag("ion-segment-button", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// The `id` of the segment content.
    /// </summary>
    public static void SetContentId(this Metapsi.Html.AttributesBuilder<IonSegmentButton> b, string contentId) 
    {
        b.SetAttribute("contentId", contentId);
    }

    /// <summary>
    /// If `true`, the user cannot interact with the segment button.
    /// </summary>
    public static void SetDisabled(this Metapsi.Html.AttributesBuilder<IonSegmentButton> b, bool disabled) 
    {
        if (disabled) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// If `true`, the user cannot interact with the segment button.
    /// </summary>
    public static void SetDisabled(this Metapsi.Html.AttributesBuilder<IonSegmentButton> b) 
    {
        b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// Set the layout of the text and icon in the segment.
    /// </summary>
    public static void SetLayoutIconBottom(this Metapsi.Html.AttributesBuilder<IonSegmentButton> b) 
    {
        b.SetAttribute("layout", "icon-bottom");
    }

    /// <summary>
    /// Set the layout of the text and icon in the segment.
    /// </summary>
    public static void SetLayoutIconEnd(this Metapsi.Html.AttributesBuilder<IonSegmentButton> b) 
    {
        b.SetAttribute("layout", "icon-end");
    }

    /// <summary>
    /// Set the layout of the text and icon in the segment.
    /// </summary>
    public static void SetLayoutIconHide(this Metapsi.Html.AttributesBuilder<IonSegmentButton> b) 
    {
        b.SetAttribute("layout", "icon-hide");
    }

    /// <summary>
    /// Set the layout of the text and icon in the segment.
    /// </summary>
    public static void SetLayoutIconStart(this Metapsi.Html.AttributesBuilder<IonSegmentButton> b) 
    {
        b.SetAttribute("layout", "icon-start");
    }

    /// <summary>
    /// Set the layout of the text and icon in the segment.
    /// </summary>
    public static void SetLayoutIconTop(this Metapsi.Html.AttributesBuilder<IonSegmentButton> b) 
    {
        b.SetAttribute("layout", "icon-top");
    }

    /// <summary>
    /// Set the layout of the text and icon in the segment.
    /// </summary>
    public static void SetLayoutLabelHide(this Metapsi.Html.AttributesBuilder<IonSegmentButton> b) 
    {
        b.SetAttribute("layout", "label-hide");
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos(this Metapsi.Html.AttributesBuilder<IonSegmentButton> b) 
    {
        b.SetAttribute("mode", "ios");
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd(this Metapsi.Html.AttributesBuilder<IonSegmentButton> b) 
    {
        b.SetAttribute("mode", "md");
    }

    /// <summary>
    /// The type of the button.
    /// </summary>
    public static void SetTypeButton(this Metapsi.Html.AttributesBuilder<IonSegmentButton> b) 
    {
        b.SetAttribute("type", "button");
    }

    /// <summary>
    /// The type of the button.
    /// </summary>
    public static void SetTypeReset(this Metapsi.Html.AttributesBuilder<IonSegmentButton> b) 
    {
        b.SetAttribute("type", "reset");
    }

    /// <summary>
    /// The type of the button.
    /// </summary>
    public static void SetTypeSubmit(this Metapsi.Html.AttributesBuilder<IonSegmentButton> b) 
    {
        b.SetAttribute("type", "submit");
    }

    /// <summary>
    /// The value of the segment button.
    /// </summary>
    public static void SetValue(this Metapsi.Html.AttributesBuilder<IonSegmentButton> b, string value) 
    {
        b.SetAttribute("value", value);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonSegmentButton(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonSegmentButton>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.IonicNode("ion-segment-button", buildProps, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonSegmentButton(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.IonicNode("ion-segment-button", children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonSegmentButton(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonSegmentButton>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.IonicNode("ion-segment-button", buildProps, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonSegmentButton(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.IonicNode("ion-segment-button", children);
    }

    /// <summary>
    /// The `id` of the segment content.
    /// </summary>
    public static void SetContentId<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> contentId) where T: IonSegmentButton
    {
        b.SetProperty(b.Props, b.Const("contentId"), contentId);
    }

    /// <summary>
    /// The `id` of the segment content.
    /// </summary>
    public static void SetContentId<T>(this Metapsi.Syntax.PropsBuilder<T> b, string contentId) where T: IonSegmentButton
    {
        b.SetContentId(b.Const(contentId));
    }

    /// <summary>
    /// If `true`, the user cannot interact with the segment button.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSegmentButton
    {
        b.SetDisabled(b.Const(true));
    }

    /// <summary>
    /// If `true`, the user cannot interact with the segment button.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> disabled) where T: IonSegmentButton
    {
        b.SetProperty(b.Props, b.Const("disabled"), disabled);
    }

    /// <summary>
    /// If `true`, the user cannot interact with the segment button.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool disabled) where T: IonSegmentButton
    {
        b.SetDisabled(b.Const(disabled));
    }

    /// <summary>
    /// Set the layout of the text and icon in the segment.
    /// </summary>
    public static void SetLayoutIconBottom<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSegmentButton
    {
        b.SetProperty(b.Props, b.Const("layout"), b.Const("icon-bottom"));
    }

    /// <summary>
    /// Set the layout of the text and icon in the segment.
    /// </summary>
    public static void SetLayoutIconEnd<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSegmentButton
    {
        b.SetProperty(b.Props, b.Const("layout"), b.Const("icon-end"));
    }

    /// <summary>
    /// Set the layout of the text and icon in the segment.
    /// </summary>
    public static void SetLayoutIconHide<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSegmentButton
    {
        b.SetProperty(b.Props, b.Const("layout"), b.Const("icon-hide"));
    }

    /// <summary>
    /// Set the layout of the text and icon in the segment.
    /// </summary>
    public static void SetLayoutIconStart<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSegmentButton
    {
        b.SetProperty(b.Props, b.Const("layout"), b.Const("icon-start"));
    }

    /// <summary>
    /// Set the layout of the text and icon in the segment.
    /// </summary>
    public static void SetLayoutIconTop<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSegmentButton
    {
        b.SetProperty(b.Props, b.Const("layout"), b.Const("icon-top"));
    }

    /// <summary>
    /// Set the layout of the text and icon in the segment.
    /// </summary>
    public static void SetLayoutLabelHide<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSegmentButton
    {
        b.SetProperty(b.Props, b.Const("layout"), b.Const("label-hide"));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSegmentButton
    {
        b.SetProperty(b.Props, b.Const("mode"), b.Const("ios"));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSegmentButton
    {
        b.SetProperty(b.Props, b.Const("mode"), b.Const("md"));
    }

    /// <summary>
    /// The type of the button.
    /// </summary>
    public static void SetTypeButton<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSegmentButton
    {
        b.SetProperty(b.Props, b.Const("type"), b.Const("button"));
    }

    /// <summary>
    /// The type of the button.
    /// </summary>
    public static void SetTypeReset<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSegmentButton
    {
        b.SetProperty(b.Props, b.Const("type"), b.Const("reset"));
    }

    /// <summary>
    /// The type of the button.
    /// </summary>
    public static void SetTypeSubmit<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonSegmentButton
    {
        b.SetProperty(b.Props, b.Const("type"), b.Const("submit"));
    }

    /// <summary>
    /// The value of the segment button.
    /// </summary>
    public static void SetValue<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<int> value) where T: IonSegmentButton
    {
        b.SetProperty(b.Props, b.Const("value"), value);
    }

    /// <summary>
    /// The value of the segment button.
    /// </summary>
    public static void SetValue<T>(this Metapsi.Syntax.PropsBuilder<T> b, int value) where T: IonSegmentButton
    {
        b.SetValue(b.Const(value));
    }

    /// <summary>
    /// The value of the segment button.
    /// </summary>
    public static void SetValue<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> value) where T: IonSegmentButton
    {
        b.SetProperty(b.Props, b.Const("value"), value);
    }

    /// <summary>
    /// The value of the segment button.
    /// </summary>
    public static void SetValue<T>(this Metapsi.Syntax.PropsBuilder<T> b, string value) where T: IonSegmentButton
    {
        b.SetValue(b.Const(value));
    }

}