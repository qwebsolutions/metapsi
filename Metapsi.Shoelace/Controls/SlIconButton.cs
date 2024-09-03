using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Shoelace;


public partial class SlIconButton
{
    public static class Method
    {
        /// <summary>
        /// <para> Simulates a click on the icon button. </para>
        /// </summary>
        public const string Click = "click";
        /// <summary>
        /// <para> Sets focus on the icon button. </para>
        /// </summary>
        public const string Focus = "focus";
        /// <summary>
        /// <para> Removes focus from the icon button. </para>
        /// </summary>
        public const string Blur = "blur";
    }
}

public static partial class SlIconButtonControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlIconButton(this HtmlBuilder b, Action<AttributesBuilder<SlIconButton>> buildAttributes, params IHtmlNode[] children)
    {
        return b.SlTag("sl-icon-button", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlIconButton(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.SlTag("sl-icon-button", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlIconButton(this HtmlBuilder b, Action<AttributesBuilder<SlIconButton>> buildAttributes, List<IHtmlNode> children)
    {
        return b.SlTag("sl-icon-button", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlIconButton(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.SlTag("sl-icon-button", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The name of the icon to draw. Available names depend on the icon library being used. </para>
    /// </summary>
    public static void SetName(this AttributesBuilder<SlIconButton> b, string name)
    {
        b.SetAttribute("name", name);
    }

    /// <summary>
    /// <para> The name of a registered custom icon library. </para>
    /// </summary>
    public static void SetLibrary(this AttributesBuilder<SlIconButton> b, string library)
    {
        b.SetAttribute("library", library);
    }

    /// <summary>
    /// <para> An external URL of an SVG file. Be sure you trust the content you are including, as it will be executed as code and can result in XSS attacks. </para>
    /// </summary>
    public static void SetSrc(this AttributesBuilder<SlIconButton> b, string src)
    {
        b.SetAttribute("src", src);
    }

    /// <summary>
    /// <para> When set, the underlying button will be rendered as an `<a>` with this `href` instead of a `<button>`. </para>
    /// </summary>
    public static void SetHref(this AttributesBuilder<SlIconButton> b, string href)
    {
        b.SetAttribute("href", href);
    }

    /// <summary>
    /// <para> Tells the browser where to open the link. Only used when `href` is set. </para>
    /// </summary>
    public static void SetTarget(this AttributesBuilder<SlIconButton> b, string target)
    {
        b.SetAttribute("target", target);
    }

    /// <summary>
    /// <para> Tells the browser where to open the link. Only used when `href` is set. </para>
    /// </summary>
    public static void SetTarget_blank(this AttributesBuilder<SlIconButton> b)
    {
        b.SetAttribute("target", "_blank");
    }

    /// <summary>
    /// <para> Tells the browser where to open the link. Only used when `href` is set. </para>
    /// </summary>
    public static void SetTarget_parent(this AttributesBuilder<SlIconButton> b)
    {
        b.SetAttribute("target", "_parent");
    }

    /// <summary>
    /// <para> Tells the browser where to open the link. Only used when `href` is set. </para>
    /// </summary>
    public static void SetTarget_self(this AttributesBuilder<SlIconButton> b)
    {
        b.SetAttribute("target", "_self");
    }

    /// <summary>
    /// <para> Tells the browser where to open the link. Only used when `href` is set. </para>
    /// </summary>
    public static void SetTarget_top(this AttributesBuilder<SlIconButton> b)
    {
        b.SetAttribute("target", "_top");
    }

    /// <summary>
    /// <para> Tells the browser to download the linked file as this filename. Only used when `href` is set. </para>
    /// </summary>
    public static void SetDownload(this AttributesBuilder<SlIconButton> b, string download)
    {
        b.SetAttribute("download", download);
    }

    /// <summary>
    /// <para> A description that gets read by assistive devices. For optimal accessibility, you should always include a label that describes what the icon button does. </para>
    /// </summary>
    public static void SetLabel(this AttributesBuilder<SlIconButton> b, string label)
    {
        b.SetAttribute("label", label);
    }

    /// <summary>
    /// <para> Disables the button. </para>
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<SlIconButton> b)
    {
        b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// <para> Disables the button. </para>
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<SlIconButton> b, bool disabled)
    {
        if (disabled) b.SetAttribute("disabled", "");
    }

    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlIconButton(this LayoutBuilder b, Action<PropsBuilder<SlIconButton>> buildProps, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-icon-button", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlIconButton(this LayoutBuilder b, Action<PropsBuilder<SlIconButton>> buildProps, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-icon-button", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlIconButton(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-icon-button", children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlIconButton(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-icon-button", children);
    }
    /// <summary>
    /// <para> The name of the icon to draw. Available names depend on the icon library being used. </para>
    /// </summary>
    public static void SetName<T>(this PropsBuilder<T> b, Var<string> name) where T: SlIconButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("name"), name);
    }

    /// <summary>
    /// <para> The name of the icon to draw. Available names depend on the icon library being used. </para>
    /// </summary>
    public static void SetName<T>(this PropsBuilder<T> b, string name) where T: SlIconButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("name"), b.Const(name));
    }


    /// <summary>
    /// <para> The name of a registered custom icon library. </para>
    /// </summary>
    public static void SetLibrary<T>(this PropsBuilder<T> b, Var<string> library) where T: SlIconButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("library"), library);
    }

    /// <summary>
    /// <para> The name of a registered custom icon library. </para>
    /// </summary>
    public static void SetLibrary<T>(this PropsBuilder<T> b, string library) where T: SlIconButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("library"), b.Const(library));
    }


    /// <summary>
    /// <para> An external URL of an SVG file. Be sure you trust the content you are including, as it will be executed as code and can result in XSS attacks. </para>
    /// </summary>
    public static void SetSrc<T>(this PropsBuilder<T> b, Var<string> src) where T: SlIconButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("src"), src);
    }

    /// <summary>
    /// <para> An external URL of an SVG file. Be sure you trust the content you are including, as it will be executed as code and can result in XSS attacks. </para>
    /// </summary>
    public static void SetSrc<T>(this PropsBuilder<T> b, string src) where T: SlIconButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("src"), b.Const(src));
    }


    /// <summary>
    /// <para> When set, the underlying button will be rendered as an `<a>` with this `href` instead of a `<button>`. </para>
    /// </summary>
    public static void SetHref<T>(this PropsBuilder<T> b, Var<string> href) where T: SlIconButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("href"), href);
    }

    /// <summary>
    /// <para> When set, the underlying button will be rendered as an `<a>` with this `href` instead of a `<button>`. </para>
    /// </summary>
    public static void SetHref<T>(this PropsBuilder<T> b, string href) where T: SlIconButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("href"), b.Const(href));
    }


    /// <summary>
    /// <para> Tells the browser where to open the link. Only used when `href` is set. </para>
    /// </summary>
    public static void SetTarget_blank<T>(this PropsBuilder<T> b) where T: SlIconButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("target"), b.Const("_blank"));
    }


    /// <summary>
    /// <para> Tells the browser where to open the link. Only used when `href` is set. </para>
    /// </summary>
    public static void SetTarget_parent<T>(this PropsBuilder<T> b) where T: SlIconButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("target"), b.Const("_parent"));
    }


    /// <summary>
    /// <para> Tells the browser where to open the link. Only used when `href` is set. </para>
    /// </summary>
    public static void SetTarget_self<T>(this PropsBuilder<T> b) where T: SlIconButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("target"), b.Const("_self"));
    }


    /// <summary>
    /// <para> Tells the browser where to open the link. Only used when `href` is set. </para>
    /// </summary>
    public static void SetTarget_top<T>(this PropsBuilder<T> b) where T: SlIconButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("target"), b.Const("_top"));
    }


    /// <summary>
    /// <para> Tells the browser to download the linked file as this filename. Only used when `href` is set. </para>
    /// </summary>
    public static void SetDownload<T>(this PropsBuilder<T> b, Var<string> download) where T: SlIconButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("download"), download);
    }

    /// <summary>
    /// <para> Tells the browser to download the linked file as this filename. Only used when `href` is set. </para>
    /// </summary>
    public static void SetDownload<T>(this PropsBuilder<T> b, string download) where T: SlIconButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("download"), b.Const(download));
    }


    /// <summary>
    /// <para> A description that gets read by assistive devices. For optimal accessibility, you should always include a label that describes what the icon button does. </para>
    /// </summary>
    public static void SetLabel<T>(this PropsBuilder<T> b, Var<string> label) where T: SlIconButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("label"), label);
    }

    /// <summary>
    /// <para> A description that gets read by assistive devices. For optimal accessibility, you should always include a label that describes what the icon button does. </para>
    /// </summary>
    public static void SetLabel<T>(this PropsBuilder<T> b, string label) where T: SlIconButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("label"), b.Const(label));
    }


    /// <summary>
    /// <para> Disables the button. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b) where T: SlIconButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), b.Const(true));
    }


    /// <summary>
    /// <para> Disables the button. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, Var<bool> disabled) where T: SlIconButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), disabled);
    }

    /// <summary>
    /// <para> Disables the button. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, bool disabled) where T: SlIconButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), b.Const(disabled));
    }


    /// <summary>
    /// <para> Emitted when the icon button loses focus. </para>
    /// </summary>
    public static void OnSlBlur<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, DomEvent>> action) where TComponent: SlIconButton
    {
        b.OnEventAction("onsl-blur", action);
    }
    /// <summary>
    /// <para> Emitted when the icon button loses focus. </para>
    /// </summary>
    public static void OnSlBlur<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action) where TComponent: SlIconButton
    {
        b.OnEventAction("onsl-blur", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the icon button loses focus. </para>
    /// </summary>
    public static void OnSlBlur<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: SlIconButton
    {
        b.OnEventAction("onsl-blur", action);
    }
    /// <summary>
    /// <para> Emitted when the icon button loses focus. </para>
    /// </summary>
    public static void OnSlBlur<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: SlIconButton
    {
        b.OnEventAction("onsl-blur", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the icon button gains focus. </para>
    /// </summary>
    public static void OnSlFocus<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, DomEvent>> action) where TComponent: SlIconButton
    {
        b.OnEventAction("onsl-focus", action);
    }
    /// <summary>
    /// <para> Emitted when the icon button gains focus. </para>
    /// </summary>
    public static void OnSlFocus<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action) where TComponent: SlIconButton
    {
        b.OnEventAction("onsl-focus", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the icon button gains focus. </para>
    /// </summary>
    public static void OnSlFocus<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: SlIconButton
    {
        b.OnEventAction("onsl-focus", action);
    }
    /// <summary>
    /// <para> Emitted when the icon button gains focus. </para>
    /// </summary>
    public static void OnSlFocus<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: SlIconButton
    {
        b.OnEventAction("onsl-focus", b.MakeAction(action));
    }

}

