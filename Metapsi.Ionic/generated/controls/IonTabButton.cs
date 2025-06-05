using Metapsi.Html;
using Metapsi.Syntax;
using Metapsi.Hyperapp;

namespace Metapsi.Ionic;

/// <summary>
/// 
/// </summary>
public partial class IonTabButton
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
/// Setter extensions of IonTabButton
/// </summary>
public static partial class IonTabButtonControl
{
    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonTabButton(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonTabButton>> buildAttributes, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.IonicTag("ion-tab-button", buildAttributes, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonTabButton(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.IonicTag("ion-tab-button", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonTabButton(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonTabButton>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.IonicTag("ion-tab-button", buildAttributes, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonTabButton(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.IonicTag("ion-tab-button", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// If `true`, the user cannot interact with the tab button.
    /// </summary>
    public static void SetDisabled(this Metapsi.Html.AttributesBuilder<IonTabButton> b, bool disabled) 
    {
        if (disabled) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// If `true`, the user cannot interact with the tab button.
    /// </summary>
    public static void SetDisabled(this Metapsi.Html.AttributesBuilder<IonTabButton> b) 
    {
        b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// This attribute instructs browsers to download a URL instead of navigating to it, so the user will be prompted to save it as a local file. If the attribute has a value, it is used as the pre-filled file name in the Save prompt (the user can still change the file name if they want).
    /// </summary>
    public static void SetDownload(this Metapsi.Html.AttributesBuilder<IonTabButton> b, string download) 
    {
        b.SetAttribute("download", download);
    }

    /// <summary>
    /// Contains a URL or a URL fragment that the hyperlink points to. If this property is set, an anchor tag will be rendered.
    /// </summary>
    public static void SetHref(this Metapsi.Html.AttributesBuilder<IonTabButton> b, string href) 
    {
        b.SetAttribute("href", href);
    }

    /// <summary>
    /// Set the layout of the text and icon in the tab bar. It defaults to `"icon-top"`.
    /// </summary>
    public static void SetLayoutIconBottom(this Metapsi.Html.AttributesBuilder<IonTabButton> b) 
    {
        b.SetAttribute("layout", "icon-bottom");
    }

    /// <summary>
    /// Set the layout of the text and icon in the tab bar. It defaults to `"icon-top"`.
    /// </summary>
    public static void SetLayoutIconEnd(this Metapsi.Html.AttributesBuilder<IonTabButton> b) 
    {
        b.SetAttribute("layout", "icon-end");
    }

    /// <summary>
    /// Set the layout of the text and icon in the tab bar. It defaults to `"icon-top"`.
    /// </summary>
    public static void SetLayoutIconHide(this Metapsi.Html.AttributesBuilder<IonTabButton> b) 
    {
        b.SetAttribute("layout", "icon-hide");
    }

    /// <summary>
    /// Set the layout of the text and icon in the tab bar. It defaults to `"icon-top"`.
    /// </summary>
    public static void SetLayoutIconStart(this Metapsi.Html.AttributesBuilder<IonTabButton> b) 
    {
        b.SetAttribute("layout", "icon-start");
    }

    /// <summary>
    /// Set the layout of the text and icon in the tab bar. It defaults to `"icon-top"`.
    /// </summary>
    public static void SetLayoutIconTop(this Metapsi.Html.AttributesBuilder<IonTabButton> b) 
    {
        b.SetAttribute("layout", "icon-top");
    }

    /// <summary>
    /// Set the layout of the text and icon in the tab bar. It defaults to `"icon-top"`.
    /// </summary>
    public static void SetLayoutLabelHide(this Metapsi.Html.AttributesBuilder<IonTabButton> b) 
    {
        b.SetAttribute("layout", "label-hide");
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos(this Metapsi.Html.AttributesBuilder<IonTabButton> b) 
    {
        b.SetAttribute("mode", "ios");
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd(this Metapsi.Html.AttributesBuilder<IonTabButton> b) 
    {
        b.SetAttribute("mode", "md");
    }

    /// <summary>
    /// Specifies the relationship of the target object to the link object. The value is a space-separated list of [link types](https://developer.mozilla.org/en-US/docs/Web/HTML/Link_types).
    /// </summary>
    public static void SetRel(this Metapsi.Html.AttributesBuilder<IonTabButton> b, string rel) 
    {
        b.SetAttribute("rel", rel);
    }

    /// <summary>
    /// The selected tab component
    /// </summary>
    public static void SetSelected(this Metapsi.Html.AttributesBuilder<IonTabButton> b, bool selected) 
    {
        if (selected) b.SetAttribute("selected", "");
    }

    /// <summary>
    /// The selected tab component
    /// </summary>
    public static void SetSelected(this Metapsi.Html.AttributesBuilder<IonTabButton> b) 
    {
        b.SetAttribute("selected", "");
    }

    /// <summary>
    /// A tab id must be provided for each `ion-tab`. It's used internally to reference the selected tab or by the router to switch between them.
    /// </summary>
    public static void SetTab(this Metapsi.Html.AttributesBuilder<IonTabButton> b, string tab) 
    {
        b.SetAttribute("tab", tab);
    }

    /// <summary>
    /// Specifies where to display the linked URL. Only applies when an `href` is provided. Special keywords: `"_blank"`, `"_self"`, `"_parent"`, `"_top"`.
    /// </summary>
    public static void SetTarget(this Metapsi.Html.AttributesBuilder<IonTabButton> b, string target) 
    {
        b.SetAttribute("target", target);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonTabButton(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonTabButton>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.IonicNode("ion-tab-button", buildProps, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonTabButton(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.IonicNode("ion-tab-button", children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonTabButton(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonTabButton>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.IonicNode("ion-tab-button", buildProps, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonTabButton(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.IonicNode("ion-tab-button", children);
    }

    /// <summary>
    /// If `true`, the user cannot interact with the tab button.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonTabButton
    {
        b.SetDisabled(b.Const(true));
    }

    /// <summary>
    /// If `true`, the user cannot interact with the tab button.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> disabled) where T: IonTabButton
    {
        b.SetProperty(b.Props, b.Const("disabled"), disabled);
    }

    /// <summary>
    /// If `true`, the user cannot interact with the tab button.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool disabled) where T: IonTabButton
    {
        b.SetDisabled(b.Const(disabled));
    }

    /// <summary>
    /// This attribute instructs browsers to download a URL instead of navigating to it, so the user will be prompted to save it as a local file. If the attribute has a value, it is used as the pre-filled file name in the Save prompt (the user can still change the file name if they want).
    /// </summary>
    public static void SetDownload<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> download) where T: IonTabButton
    {
        b.SetProperty(b.Props, b.Const("download"), download);
    }

    /// <summary>
    /// This attribute instructs browsers to download a URL instead of navigating to it, so the user will be prompted to save it as a local file. If the attribute has a value, it is used as the pre-filled file name in the Save prompt (the user can still change the file name if they want).
    /// </summary>
    public static void SetDownload<T>(this Metapsi.Syntax.PropsBuilder<T> b, string download) where T: IonTabButton
    {
        b.SetDownload(b.Const(download));
    }

    /// <summary>
    /// Contains a URL or a URL fragment that the hyperlink points to. If this property is set, an anchor tag will be rendered.
    /// </summary>
    public static void SetHref<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> href) where T: IonTabButton
    {
        b.SetProperty(b.Props, b.Const("href"), href);
    }

    /// <summary>
    /// Contains a URL or a URL fragment that the hyperlink points to. If this property is set, an anchor tag will be rendered.
    /// </summary>
    public static void SetHref<T>(this Metapsi.Syntax.PropsBuilder<T> b, string href) where T: IonTabButton
    {
        b.SetHref(b.Const(href));
    }

    /// <summary>
    /// Set the layout of the text and icon in the tab bar. It defaults to `"icon-top"`.
    /// </summary>
    public static void SetLayoutIconBottom<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonTabButton
    {
        b.SetProperty(b.Props, b.Const("layout"), b.Const("icon-bottom"));
    }

    /// <summary>
    /// Set the layout of the text and icon in the tab bar. It defaults to `"icon-top"`.
    /// </summary>
    public static void SetLayoutIconEnd<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonTabButton
    {
        b.SetProperty(b.Props, b.Const("layout"), b.Const("icon-end"));
    }

    /// <summary>
    /// Set the layout of the text and icon in the tab bar. It defaults to `"icon-top"`.
    /// </summary>
    public static void SetLayoutIconHide<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonTabButton
    {
        b.SetProperty(b.Props, b.Const("layout"), b.Const("icon-hide"));
    }

    /// <summary>
    /// Set the layout of the text and icon in the tab bar. It defaults to `"icon-top"`.
    /// </summary>
    public static void SetLayoutIconStart<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonTabButton
    {
        b.SetProperty(b.Props, b.Const("layout"), b.Const("icon-start"));
    }

    /// <summary>
    /// Set the layout of the text and icon in the tab bar. It defaults to `"icon-top"`.
    /// </summary>
    public static void SetLayoutIconTop<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonTabButton
    {
        b.SetProperty(b.Props, b.Const("layout"), b.Const("icon-top"));
    }

    /// <summary>
    /// Set the layout of the text and icon in the tab bar. It defaults to `"icon-top"`.
    /// </summary>
    public static void SetLayoutLabelHide<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonTabButton
    {
        b.SetProperty(b.Props, b.Const("layout"), b.Const("label-hide"));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonTabButton
    {
        b.SetProperty(b.Props, b.Const("mode"), b.Const("ios"));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonTabButton
    {
        b.SetProperty(b.Props, b.Const("mode"), b.Const("md"));
    }

    /// <summary>
    /// Specifies the relationship of the target object to the link object. The value is a space-separated list of [link types](https://developer.mozilla.org/en-US/docs/Web/HTML/Link_types).
    /// </summary>
    public static void SetRel<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> rel) where T: IonTabButton
    {
        b.SetProperty(b.Props, b.Const("rel"), rel);
    }

    /// <summary>
    /// Specifies the relationship of the target object to the link object. The value is a space-separated list of [link types](https://developer.mozilla.org/en-US/docs/Web/HTML/Link_types).
    /// </summary>
    public static void SetRel<T>(this Metapsi.Syntax.PropsBuilder<T> b, string rel) where T: IonTabButton
    {
        b.SetRel(b.Const(rel));
    }

    /// <summary>
    /// The selected tab component
    /// </summary>
    public static void SetSelected<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonTabButton
    {
        b.SetSelected(b.Const(true));
    }

    /// <summary>
    /// The selected tab component
    /// </summary>
    public static void SetSelected<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> selected) where T: IonTabButton
    {
        b.SetProperty(b.Props, b.Const("selected"), selected);
    }

    /// <summary>
    /// The selected tab component
    /// </summary>
    public static void SetSelected<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool selected) where T: IonTabButton
    {
        b.SetSelected(b.Const(selected));
    }

    /// <summary>
    /// A tab id must be provided for each `ion-tab`. It's used internally to reference the selected tab or by the router to switch between them.
    /// </summary>
    public static void SetTab<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> tab) where T: IonTabButton
    {
        b.SetProperty(b.Props, b.Const("tab"), tab);
    }

    /// <summary>
    /// A tab id must be provided for each `ion-tab`. It's used internally to reference the selected tab or by the router to switch between them.
    /// </summary>
    public static void SetTab<T>(this Metapsi.Syntax.PropsBuilder<T> b, string tab) where T: IonTabButton
    {
        b.SetTab(b.Const(tab));
    }

    /// <summary>
    /// Specifies where to display the linked URL. Only applies when an `href` is provided. Special keywords: `"_blank"`, `"_self"`, `"_parent"`, `"_top"`.
    /// </summary>
    public static void SetTarget<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> target) where T: IonTabButton
    {
        b.SetProperty(b.Props, b.Const("target"), target);
    }

    /// <summary>
    /// Specifies where to display the linked URL. Only applies when an `href` is provided. Special keywords: `"_blank"`, `"_self"`, `"_parent"`, `"_top"`.
    /// </summary>
    public static void SetTarget<T>(this Metapsi.Syntax.PropsBuilder<T> b, string target) where T: IonTabButton
    {
        b.SetTarget(b.Const(target));
    }

}