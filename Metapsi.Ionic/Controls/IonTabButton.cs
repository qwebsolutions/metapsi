using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Ionic;


public partial class IonTabButton : IonComponent
{
    public IonTabButton() : base("ion-tab-button") { }
}

public static partial class IonTabButtonControl
{
    /// <summary>
    /// 
    /// </summary>
    public static IHtmlNode IonTabButton(this HtmlBuilder b, Action<AttributesBuilder<IonTabButton>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("ion-tab-button", buildAttributes, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static IHtmlNode IonTabButton(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("ion-tab-button", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// If `true`, the user cannot interact with the tab button.
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<IonTabButton> b)
    {
        b.SetAttribute("disabled", "");
    }
    /// <summary>
    /// If `true`, the user cannot interact with the tab button.
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<IonTabButton> b, bool value)
    {
        if (value) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// This attribute instructs browsers to download a URL instead of navigating to it, so the user will be prompted to save it as a local file. If the attribute has a value, it is used as the pre-filled file name in the Save prompt (the user can still change the file name if they want).
    /// </summary>
    public static void SetDownload(this AttributesBuilder<IonTabButton> b, string value)
    {
        b.SetAttribute("download", value);
    }

    /// <summary>
    /// Contains a URL or a URL fragment that the hyperlink points to. If this property is set, an anchor tag will be rendered.
    /// </summary>
    public static void SetHref(this AttributesBuilder<IonTabButton> b, string value)
    {
        b.SetAttribute("href", value);
    }

    /// <summary>
    /// Set the layout of the text and icon in the tab bar. It defaults to `"icon-top"`.
    /// </summary>
    public static void SetLayout(this AttributesBuilder<IonTabButton> b, string value)
    {
        b.SetAttribute("layout", value);
    }
    /// <summary>
    /// Set the layout of the text and icon in the tab bar. It defaults to `"icon-top"`.
    /// </summary>
    public static void SetLayoutIconBottom(this AttributesBuilder<IonTabButton> b)
    {
        b.SetAttribute("layout", "icon-bottom");
    }
    /// <summary>
    /// Set the layout of the text and icon in the tab bar. It defaults to `"icon-top"`.
    /// </summary>
    public static void SetLayoutIconEnd(this AttributesBuilder<IonTabButton> b)
    {
        b.SetAttribute("layout", "icon-end");
    }
    /// <summary>
    /// Set the layout of the text and icon in the tab bar. It defaults to `"icon-top"`.
    /// </summary>
    public static void SetLayoutIconHide(this AttributesBuilder<IonTabButton> b)
    {
        b.SetAttribute("layout", "icon-hide");
    }
    /// <summary>
    /// Set the layout of the text and icon in the tab bar. It defaults to `"icon-top"`.
    /// </summary>
    public static void SetLayoutIconStart(this AttributesBuilder<IonTabButton> b)
    {
        b.SetAttribute("layout", "icon-start");
    }
    /// <summary>
    /// Set the layout of the text and icon in the tab bar. It defaults to `"icon-top"`.
    /// </summary>
    public static void SetLayoutIconTop(this AttributesBuilder<IonTabButton> b)
    {
        b.SetAttribute("layout", "icon-top");
    }
    /// <summary>
    /// Set the layout of the text and icon in the tab bar. It defaults to `"icon-top"`.
    /// </summary>
    public static void SetLayoutLabelHide(this AttributesBuilder<IonTabButton> b)
    {
        b.SetAttribute("layout", "label-hide");
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetMode(this AttributesBuilder<IonTabButton> b, string value)
    {
        b.SetAttribute("mode", value);
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos(this AttributesBuilder<IonTabButton> b)
    {
        b.SetAttribute("mode", "ios");
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd(this AttributesBuilder<IonTabButton> b)
    {
        b.SetAttribute("mode", "md");
    }

    /// <summary>
    /// Specifies the relationship of the target object to the link object. The value is a space-separated list of [link types](https://developer.mozilla.org/en-US/docs/Web/HTML/Link_types).
    /// </summary>
    public static void SetRel(this AttributesBuilder<IonTabButton> b, string value)
    {
        b.SetAttribute("rel", value);
    }

    /// <summary>
    /// The selected tab component
    /// </summary>
    public static void SetSelected(this AttributesBuilder<IonTabButton> b)
    {
        b.SetAttribute("selected", "");
    }
    /// <summary>
    /// The selected tab component
    /// </summary>
    public static void SetSelected(this AttributesBuilder<IonTabButton> b, bool value)
    {
        if (value) b.SetAttribute("selected", "");
    }

    /// <summary>
    /// A tab id must be provided for each `ion-tab`. It's used internally to reference the selected tab or by the router to switch between them.
    /// </summary>
    public static void SetTab(this AttributesBuilder<IonTabButton> b, string value)
    {
        b.SetAttribute("tab", value);
    }

    /// <summary>
    /// Specifies where to display the linked URL. Only applies when an `href` is provided. Special keywords: `"_blank"`, `"_self"`, `"_parent"`, `"_top"`.
    /// </summary>
    public static void SetTarget(this AttributesBuilder<IonTabButton> b, string value)
    {
        b.SetAttribute("target", value);
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
    /// If `true`, the user cannot interact with the tab button.
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b) where T: IonTabButton
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("disabled"), b.Const(true));
    }

    /// <summary>
    /// This attribute instructs browsers to download a URL instead of navigating to it, so the user will be prompted to save it as a local file. If the attribute has a value, it is used as the pre-filled file name in the Save prompt (the user can still change the file name if they want).
    /// </summary>
    public static void SetDownload<T>(this PropsBuilder<T> b, Var<string> value) where T: IonTabButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("download"), value);
    }
    /// <summary>
    /// This attribute instructs browsers to download a URL instead of navigating to it, so the user will be prompted to save it as a local file. If the attribute has a value, it is used as the pre-filled file name in the Save prompt (the user can still change the file name if they want).
    /// </summary>
    public static void SetDownload<T>(this PropsBuilder<T> b, string value) where T: IonTabButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("download"), b.Const(value));
    }

    /// <summary>
    /// Contains a URL or a URL fragment that the hyperlink points to. If this property is set, an anchor tag will be rendered.
    /// </summary>
    public static void SetHref<T>(this PropsBuilder<T> b, Var<string> value) where T: IonTabButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("href"), value);
    }
    /// <summary>
    /// Contains a URL or a URL fragment that the hyperlink points to. If this property is set, an anchor tag will be rendered.
    /// </summary>
    public static void SetHref<T>(this PropsBuilder<T> b, string value) where T: IonTabButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("href"), b.Const(value));
    }

    /// <summary>
    /// Set the layout of the text and icon in the tab bar. It defaults to `"icon-top"`.
    /// </summary>
    public static void SetLayoutIconBottom<T>(this PropsBuilder<T> b) where T: IonTabButton
    {
        b.SetDynamic(b.Props, DynamicProperty.String("layout"), b.Const("icon-bottom"));
    }
    /// <summary>
    /// Set the layout of the text and icon in the tab bar. It defaults to `"icon-top"`.
    /// </summary>
    public static void SetLayoutIconEnd<T>(this PropsBuilder<T> b) where T: IonTabButton
    {
        b.SetDynamic(b.Props, DynamicProperty.String("layout"), b.Const("icon-end"));
    }
    /// <summary>
    /// Set the layout of the text and icon in the tab bar. It defaults to `"icon-top"`.
    /// </summary>
    public static void SetLayoutIconHide<T>(this PropsBuilder<T> b) where T: IonTabButton
    {
        b.SetDynamic(b.Props, DynamicProperty.String("layout"), b.Const("icon-hide"));
    }
    /// <summary>
    /// Set the layout of the text and icon in the tab bar. It defaults to `"icon-top"`.
    /// </summary>
    public static void SetLayoutIconStart<T>(this PropsBuilder<T> b) where T: IonTabButton
    {
        b.SetDynamic(b.Props, DynamicProperty.String("layout"), b.Const("icon-start"));
    }
    /// <summary>
    /// Set the layout of the text and icon in the tab bar. It defaults to `"icon-top"`.
    /// </summary>
    public static void SetLayoutIconTop<T>(this PropsBuilder<T> b) where T: IonTabButton
    {
        b.SetDynamic(b.Props, DynamicProperty.String("layout"), b.Const("icon-top"));
    }
    /// <summary>
    /// Set the layout of the text and icon in the tab bar. It defaults to `"icon-top"`.
    /// </summary>
    public static void SetLayoutLabelHide<T>(this PropsBuilder<T> b) where T: IonTabButton
    {
        b.SetDynamic(b.Props, DynamicProperty.String("layout"), b.Const("label-hide"));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos<T>(this PropsBuilder<T> b) where T: IonTabButton
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("ios"));
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd<T>(this PropsBuilder<T> b) where T: IonTabButton
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("md"));
    }

    /// <summary>
    /// Specifies the relationship of the target object to the link object. The value is a space-separated list of [link types](https://developer.mozilla.org/en-US/docs/Web/HTML/Link_types).
    /// </summary>
    public static void SetRel<T>(this PropsBuilder<T> b, Var<string> value) where T: IonTabButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("rel"), value);
    }
    /// <summary>
    /// Specifies the relationship of the target object to the link object. The value is a space-separated list of [link types](https://developer.mozilla.org/en-US/docs/Web/HTML/Link_types).
    /// </summary>
    public static void SetRel<T>(this PropsBuilder<T> b, string value) where T: IonTabButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("rel"), b.Const(value));
    }

    /// <summary>
    /// The selected tab component
    /// </summary>
    public static void SetSelected<T>(this PropsBuilder<T> b) where T: IonTabButton
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("selected"), b.Const(true));
    }

    /// <summary>
    /// A tab id must be provided for each `ion-tab`. It's used internally to reference the selected tab or by the router to switch between them.
    /// </summary>
    public static void SetTab<T>(this PropsBuilder<T> b, Var<string> value) where T: IonTabButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("tab"), value);
    }
    /// <summary>
    /// A tab id must be provided for each `ion-tab`. It's used internally to reference the selected tab or by the router to switch between them.
    /// </summary>
    public static void SetTab<T>(this PropsBuilder<T> b, string value) where T: IonTabButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("tab"), b.Const(value));
    }

    /// <summary>
    /// Specifies where to display the linked URL. Only applies when an `href` is provided. Special keywords: `"_blank"`, `"_self"`, `"_parent"`, `"_top"`.
    /// </summary>
    public static void SetTarget<T>(this PropsBuilder<T> b, Var<string> value) where T: IonTabButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("target"), value);
    }
    /// <summary>
    /// Specifies where to display the linked URL. Only applies when an `href` is provided. Special keywords: `"_blank"`, `"_self"`, `"_parent"`, `"_top"`.
    /// </summary>
    public static void SetTarget<T>(this PropsBuilder<T> b, string value) where T: IonTabButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("target"), b.Const(value));
    }

}

