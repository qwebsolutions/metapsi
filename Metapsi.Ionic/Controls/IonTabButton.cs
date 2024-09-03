using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Ionic;


public partial class IonTabButton
{
}

public static partial class IonTabButtonControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonTabButton(this HtmlBuilder b, Action<AttributesBuilder<IonTabButton>> buildAttributes, params IHtmlNode[] children)
    {
        return b.IonicTag("ion-tab-button", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonTabButton(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.IonicTag("ion-tab-button", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonTabButton(this HtmlBuilder b, Action<AttributesBuilder<IonTabButton>> buildAttributes, List<IHtmlNode> children)
    {
        return b.IonicTag("ion-tab-button", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonTabButton(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.IonicTag("ion-tab-button", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> If `true`, the user cannot interact with the tab button. </para>
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<IonTabButton> b)
    {
        b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// <para> If `true`, the user cannot interact with the tab button. </para>
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<IonTabButton> b, bool disabled)
    {
        if (disabled) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// <para> This attribute instructs browsers to download a URL instead of navigating to it, so the user will be prompted to save it as a local file. If the attribute has a value, it is used as the pre-filled file name in the Save prompt (the user can still change the file name if they want). </para>
    /// </summary>
    public static void SetDownload(this AttributesBuilder<IonTabButton> b, string download)
    {
        b.SetAttribute("download", download);
    }

    /// <summary>
    /// <para> Contains a URL or a URL fragment that the hyperlink points to. If this property is set, an anchor tag will be rendered. </para>
    /// </summary>
    public static void SetHref(this AttributesBuilder<IonTabButton> b, string href)
    {
        b.SetAttribute("href", href);
    }

    /// <summary>
    /// <para> Set the layout of the text and icon in the tab bar. It defaults to `"icon-top"`. </para>
    /// </summary>
    public static void SetLayout(this AttributesBuilder<IonTabButton> b, string layout)
    {
        b.SetAttribute("layout", layout);
    }

    /// <summary>
    /// <para> Set the layout of the text and icon in the tab bar. It defaults to `"icon-top"`. </para>
    /// </summary>
    public static void SetLayoutIconBottom(this AttributesBuilder<IonTabButton> b)
    {
        b.SetAttribute("layout", "icon-bottom");
    }

    /// <summary>
    /// <para> Set the layout of the text and icon in the tab bar. It defaults to `"icon-top"`. </para>
    /// </summary>
    public static void SetLayoutIconEnd(this AttributesBuilder<IonTabButton> b)
    {
        b.SetAttribute("layout", "icon-end");
    }

    /// <summary>
    /// <para> Set the layout of the text and icon in the tab bar. It defaults to `"icon-top"`. </para>
    /// </summary>
    public static void SetLayoutIconHide(this AttributesBuilder<IonTabButton> b)
    {
        b.SetAttribute("layout", "icon-hide");
    }

    /// <summary>
    /// <para> Set the layout of the text and icon in the tab bar. It defaults to `"icon-top"`. </para>
    /// </summary>
    public static void SetLayoutIconStart(this AttributesBuilder<IonTabButton> b)
    {
        b.SetAttribute("layout", "icon-start");
    }

    /// <summary>
    /// <para> Set the layout of the text and icon in the tab bar. It defaults to `"icon-top"`. </para>
    /// </summary>
    public static void SetLayoutIconTop(this AttributesBuilder<IonTabButton> b)
    {
        b.SetAttribute("layout", "icon-top");
    }

    /// <summary>
    /// <para> Set the layout of the text and icon in the tab bar. It defaults to `"icon-top"`. </para>
    /// </summary>
    public static void SetLayoutLabelHide(this AttributesBuilder<IonTabButton> b)
    {
        b.SetAttribute("layout", "label-hide");
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetMode(this AttributesBuilder<IonTabButton> b, string mode)
    {
        b.SetAttribute("mode", mode);
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeIos(this AttributesBuilder<IonTabButton> b)
    {
        b.SetAttribute("mode", "ios");
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeMd(this AttributesBuilder<IonTabButton> b)
    {
        b.SetAttribute("mode", "md");
    }

    /// <summary>
    /// <para> Specifies the relationship of the target object to the link object. The value is a space-separated list of [link types](https://developer.mozilla.org/en-US/docs/Web/HTML/Link_types). </para>
    /// </summary>
    public static void SetRel(this AttributesBuilder<IonTabButton> b, string rel)
    {
        b.SetAttribute("rel", rel);
    }

    /// <summary>
    /// <para> The selected tab component </para>
    /// </summary>
    public static void SetSelected(this AttributesBuilder<IonTabButton> b)
    {
        b.SetAttribute("selected", "");
    }

    /// <summary>
    /// <para> The selected tab component </para>
    /// </summary>
    public static void SetSelected(this AttributesBuilder<IonTabButton> b, bool selected)
    {
        if (selected) b.SetAttribute("selected", "");
    }

    /// <summary>
    /// <para> A tab id must be provided for each `ion-tab`. It's used internally to reference the selected tab or by the router to switch between them. </para>
    /// </summary>
    public static void SetTab(this AttributesBuilder<IonTabButton> b, string tab)
    {
        b.SetAttribute("tab", tab);
    }

    /// <summary>
    /// <para> Specifies where to display the linked URL. Only applies when an `href` is provided. Special keywords: `"_blank"`, `"_self"`, `"_parent"`, `"_top"`. </para>
    /// </summary>
    public static void SetTarget(this AttributesBuilder<IonTabButton> b, string target)
    {
        b.SetAttribute("target", target);
    }

    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonTabButton(this LayoutBuilder b, Action<PropsBuilder<IonTabButton>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-tab-button", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonTabButton(this LayoutBuilder b, Action<PropsBuilder<IonTabButton>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-tab-button", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonTabButton(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-tab-button", children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonTabButton(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-tab-button", children);
    }
    /// <summary>
    /// <para> If `true`, the user cannot interact with the tab button. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b) where T: IonTabButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, the user cannot interact with the tab button. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, Var<bool> disabled) where T: IonTabButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), disabled);
    }

    /// <summary>
    /// <para> If `true`, the user cannot interact with the tab button. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, bool disabled) where T: IonTabButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), b.Const(disabled));
    }


    /// <summary>
    /// <para> This attribute instructs browsers to download a URL instead of navigating to it, so the user will be prompted to save it as a local file. If the attribute has a value, it is used as the pre-filled file name in the Save prompt (the user can still change the file name if they want). </para>
    /// </summary>
    public static void SetDownload<T>(this PropsBuilder<T> b, Var<string> download) where T: IonTabButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("download"), download);
    }

    /// <summary>
    /// <para> This attribute instructs browsers to download a URL instead of navigating to it, so the user will be prompted to save it as a local file. If the attribute has a value, it is used as the pre-filled file name in the Save prompt (the user can still change the file name if they want). </para>
    /// </summary>
    public static void SetDownload<T>(this PropsBuilder<T> b, string download) where T: IonTabButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("download"), b.Const(download));
    }


    /// <summary>
    /// <para> Contains a URL or a URL fragment that the hyperlink points to. If this property is set, an anchor tag will be rendered. </para>
    /// </summary>
    public static void SetHref<T>(this PropsBuilder<T> b, Var<string> href) where T: IonTabButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("href"), href);
    }

    /// <summary>
    /// <para> Contains a URL or a URL fragment that the hyperlink points to. If this property is set, an anchor tag will be rendered. </para>
    /// </summary>
    public static void SetHref<T>(this PropsBuilder<T> b, string href) where T: IonTabButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("href"), b.Const(href));
    }


    /// <summary>
    /// <para> Set the layout of the text and icon in the tab bar. It defaults to `"icon-top"`. </para>
    /// </summary>
    public static void SetLayoutIconBottom<T>(this PropsBuilder<T> b) where T: IonTabButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("layout"), b.Const("icon-bottom"));
    }


    /// <summary>
    /// <para> Set the layout of the text and icon in the tab bar. It defaults to `"icon-top"`. </para>
    /// </summary>
    public static void SetLayoutIconEnd<T>(this PropsBuilder<T> b) where T: IonTabButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("layout"), b.Const("icon-end"));
    }


    /// <summary>
    /// <para> Set the layout of the text and icon in the tab bar. It defaults to `"icon-top"`. </para>
    /// </summary>
    public static void SetLayoutIconHide<T>(this PropsBuilder<T> b) where T: IonTabButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("layout"), b.Const("icon-hide"));
    }


    /// <summary>
    /// <para> Set the layout of the text and icon in the tab bar. It defaults to `"icon-top"`. </para>
    /// </summary>
    public static void SetLayoutIconStart<T>(this PropsBuilder<T> b) where T: IonTabButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("layout"), b.Const("icon-start"));
    }


    /// <summary>
    /// <para> Set the layout of the text and icon in the tab bar. It defaults to `"icon-top"`. </para>
    /// </summary>
    public static void SetLayoutIconTop<T>(this PropsBuilder<T> b) where T: IonTabButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("layout"), b.Const("icon-top"));
    }


    /// <summary>
    /// <para> Set the layout of the text and icon in the tab bar. It defaults to `"icon-top"`. </para>
    /// </summary>
    public static void SetLayoutLabelHide<T>(this PropsBuilder<T> b) where T: IonTabButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("layout"), b.Const("label-hide"));
    }


    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeIos<T>(this PropsBuilder<T> b) where T: IonTabButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("mode"), b.Const("ios"));
    }


    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeMd<T>(this PropsBuilder<T> b) where T: IonTabButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("mode"), b.Const("md"));
    }


    /// <summary>
    /// <para> Specifies the relationship of the target object to the link object. The value is a space-separated list of [link types](https://developer.mozilla.org/en-US/docs/Web/HTML/Link_types). </para>
    /// </summary>
    public static void SetRel<T>(this PropsBuilder<T> b, Var<string> rel) where T: IonTabButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("rel"), rel);
    }

    /// <summary>
    /// <para> Specifies the relationship of the target object to the link object. The value is a space-separated list of [link types](https://developer.mozilla.org/en-US/docs/Web/HTML/Link_types). </para>
    /// </summary>
    public static void SetRel<T>(this PropsBuilder<T> b, string rel) where T: IonTabButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("rel"), b.Const(rel));
    }


    /// <summary>
    /// <para> The selected tab component </para>
    /// </summary>
    public static void SetSelected<T>(this PropsBuilder<T> b) where T: IonTabButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("selected"), b.Const(true));
    }


    /// <summary>
    /// <para> The selected tab component </para>
    /// </summary>
    public static void SetSelected<T>(this PropsBuilder<T> b, Var<bool> selected) where T: IonTabButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("selected"), selected);
    }

    /// <summary>
    /// <para> The selected tab component </para>
    /// </summary>
    public static void SetSelected<T>(this PropsBuilder<T> b, bool selected) where T: IonTabButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("selected"), b.Const(selected));
    }


    /// <summary>
    /// <para> A tab id must be provided for each `ion-tab`. It's used internally to reference the selected tab or by the router to switch between them. </para>
    /// </summary>
    public static void SetTab<T>(this PropsBuilder<T> b, Var<string> tab) where T: IonTabButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("tab"), tab);
    }

    /// <summary>
    /// <para> A tab id must be provided for each `ion-tab`. It's used internally to reference the selected tab or by the router to switch between them. </para>
    /// </summary>
    public static void SetTab<T>(this PropsBuilder<T> b, string tab) where T: IonTabButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("tab"), b.Const(tab));
    }


    /// <summary>
    /// <para> Specifies where to display the linked URL. Only applies when an `href` is provided. Special keywords: `"_blank"`, `"_self"`, `"_parent"`, `"_top"`. </para>
    /// </summary>
    public static void SetTarget<T>(this PropsBuilder<T> b, Var<string> target) where T: IonTabButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("target"), target);
    }

    /// <summary>
    /// <para> Specifies where to display the linked URL. Only applies when an `href` is provided. Special keywords: `"_blank"`, `"_self"`, `"_parent"`, `"_top"`. </para>
    /// </summary>
    public static void SetTarget<T>(this PropsBuilder<T> b, string target) where T: IonTabButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("target"), b.Const(target));
    }


}

