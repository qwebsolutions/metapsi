using Metapsi.Html;
using Metapsi.Syntax;
using Metapsi.Hyperapp;

namespace Metapsi.Shoelace;

/// <summary>
/// Icons buttons are simple, icon-only buttons that can be used for actions and in toolbars.
/// </summary>
public partial class SlIconButton
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
        /// <summary>
        /// Simulates a click on the icon button.
        /// </summary>
        public const string Click = "click";
        /// <summary>
        /// Sets focus on the icon button.
        /// </summary>
        public const string Focus = "focus";
        /// <summary>
        /// Removes focus from the icon button.
        /// </summary>
        public const string Blur = "blur";
    }
}
/// <summary>
/// Setter extensions of SlIconButton
/// </summary>
public static partial class SlIconButtonControl
{
    /// <summary>
    /// Icons buttons are simple, icon-only buttons that can be used for actions and in toolbars.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlIconButton(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlIconButton>> buildAttributes, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-icon-button", buildAttributes, children);
    }

    /// <summary>
    /// Icons buttons are simple, icon-only buttons that can be used for actions and in toolbars.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlIconButton(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-icon-button", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// Icons buttons are simple, icon-only buttons that can be used for actions and in toolbars.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlIconButton(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlIconButton>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-icon-button", buildAttributes, children);
    }

    /// <summary>
    /// Icons buttons are simple, icon-only buttons that can be used for actions and in toolbars.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlIconButton(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-icon-button", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// The name of the icon to draw. Available names depend on the icon library being used.
    /// </summary>
    public static void SetName(this Metapsi.Html.AttributesBuilder<SlIconButton> b, string name) 
    {
        b.SetAttribute("name", name);
    }

    /// <summary>
    /// The name of a registered custom icon library.
    /// </summary>
    public static void SetLibrary(this Metapsi.Html.AttributesBuilder<SlIconButton> b, string library) 
    {
        b.SetAttribute("library", library);
    }

    /// <summary>
    /// An external URL of an SVG file. Be sure you trust the content you are including, as it will be executed as code and can result in XSS attacks.
    /// </summary>
    public static void SetSrc(this Metapsi.Html.AttributesBuilder<SlIconButton> b, string src) 
    {
        b.SetAttribute("src", src);
    }

    /// <summary>
    /// When set, the underlying button will be rendered as an `&lt;a&gt;` with this `href` instead of a `&lt;button&gt;`.
    /// </summary>
    public static void SetHref(this Metapsi.Html.AttributesBuilder<SlIconButton> b, string href) 
    {
        b.SetAttribute("href", href);
    }

    /// <summary>
    /// Tells the browser where to open the link. Only used when `href` is set.
    /// </summary>
    public static void SetTarget_blank(this Metapsi.Html.AttributesBuilder<SlIconButton> b) 
    {
        b.SetAttribute("target", "_blank");
    }

    /// <summary>
    /// Tells the browser where to open the link. Only used when `href` is set.
    /// </summary>
    public static void SetTarget_parent(this Metapsi.Html.AttributesBuilder<SlIconButton> b) 
    {
        b.SetAttribute("target", "_parent");
    }

    /// <summary>
    /// Tells the browser where to open the link. Only used when `href` is set.
    /// </summary>
    public static void SetTarget_self(this Metapsi.Html.AttributesBuilder<SlIconButton> b) 
    {
        b.SetAttribute("target", "_self");
    }

    /// <summary>
    /// Tells the browser where to open the link. Only used when `href` is set.
    /// </summary>
    public static void SetTarget_top(this Metapsi.Html.AttributesBuilder<SlIconButton> b) 
    {
        b.SetAttribute("target", "_top");
    }

    /// <summary>
    /// Tells the browser to download the linked file as this filename. Only used when `href` is set.
    /// </summary>
    public static void SetDownload(this Metapsi.Html.AttributesBuilder<SlIconButton> b, string download) 
    {
        b.SetAttribute("download", download);
    }

    /// <summary>
    /// A description that gets read by assistive devices. For optimal accessibility, you should always include a label that describes what the icon button does.
    /// </summary>
    public static void SetLabel(this Metapsi.Html.AttributesBuilder<SlIconButton> b, string label) 
    {
        b.SetAttribute("label", label);
    }

    /// <summary>
    /// Disables the button.
    /// </summary>
    public static void SetDisabled(this Metapsi.Html.AttributesBuilder<SlIconButton> b, bool disabled) 
    {
        if (disabled) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// Disables the button.
    /// </summary>
    public static void SetDisabled(this Metapsi.Html.AttributesBuilder<SlIconButton> b) 
    {
        b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// Icons buttons are simple, icon-only buttons that can be used for actions and in toolbars.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlIconButton(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlIconButton>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-icon-button", buildProps, children);
    }

    /// <summary>
    /// Icons buttons are simple, icon-only buttons that can be used for actions and in toolbars.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlIconButton(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-icon-button", children);
    }

    /// <summary>
    /// Icons buttons are simple, icon-only buttons that can be used for actions and in toolbars.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlIconButton(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlIconButton>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-icon-button", buildProps, children);
    }

    /// <summary>
    /// Icons buttons are simple, icon-only buttons that can be used for actions and in toolbars.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlIconButton(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-icon-button", children);
    }

    /// <summary>
    /// The name of the icon to draw. Available names depend on the icon library being used.
    /// </summary>
    public static void SetName<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> name) where T: SlIconButton
    {
        b.SetProperty(b.Props, b.Const("name"), name);
    }

    /// <summary>
    /// The name of the icon to draw. Available names depend on the icon library being used.
    /// </summary>
    public static void SetName<T>(this Metapsi.Syntax.PropsBuilder<T> b, string name) where T: SlIconButton
    {
        b.SetName(b.Const(name));
    }

    /// <summary>
    /// The name of a registered custom icon library.
    /// </summary>
    public static void SetLibrary<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> library) where T: SlIconButton
    {
        b.SetProperty(b.Props, b.Const("library"), library);
    }

    /// <summary>
    /// The name of a registered custom icon library.
    /// </summary>
    public static void SetLibrary<T>(this Metapsi.Syntax.PropsBuilder<T> b, string library) where T: SlIconButton
    {
        b.SetLibrary(b.Const(library));
    }

    /// <summary>
    /// An external URL of an SVG file. Be sure you trust the content you are including, as it will be executed as code and can result in XSS attacks.
    /// </summary>
    public static void SetSrc<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> src) where T: SlIconButton
    {
        b.SetProperty(b.Props, b.Const("src"), src);
    }

    /// <summary>
    /// An external URL of an SVG file. Be sure you trust the content you are including, as it will be executed as code and can result in XSS attacks.
    /// </summary>
    public static void SetSrc<T>(this Metapsi.Syntax.PropsBuilder<T> b, string src) where T: SlIconButton
    {
        b.SetSrc(b.Const(src));
    }

    /// <summary>
    /// When set, the underlying button will be rendered as an `&lt;a&gt;` with this `href` instead of a `&lt;button&gt;`.
    /// </summary>
    public static void SetHref<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> href) where T: SlIconButton
    {
        b.SetProperty(b.Props, b.Const("href"), href);
    }

    /// <summary>
    /// When set, the underlying button will be rendered as an `&lt;a&gt;` with this `href` instead of a `&lt;button&gt;`.
    /// </summary>
    public static void SetHref<T>(this Metapsi.Syntax.PropsBuilder<T> b, string href) where T: SlIconButton
    {
        b.SetHref(b.Const(href));
    }

    /// <summary>
    /// Tells the browser where to open the link. Only used when `href` is set.
    /// </summary>
    public static void SetTarget_blank<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlIconButton
    {
        b.SetProperty(b.Props, b.Const("target"), b.Const("_blank"));
    }

    /// <summary>
    /// Tells the browser where to open the link. Only used when `href` is set.
    /// </summary>
    public static void SetTarget_parent<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlIconButton
    {
        b.SetProperty(b.Props, b.Const("target"), b.Const("_parent"));
    }

    /// <summary>
    /// Tells the browser where to open the link. Only used when `href` is set.
    /// </summary>
    public static void SetTarget_self<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlIconButton
    {
        b.SetProperty(b.Props, b.Const("target"), b.Const("_self"));
    }

    /// <summary>
    /// Tells the browser where to open the link. Only used when `href` is set.
    /// </summary>
    public static void SetTarget_top<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlIconButton
    {
        b.SetProperty(b.Props, b.Const("target"), b.Const("_top"));
    }

    /// <summary>
    /// Tells the browser to download the linked file as this filename. Only used when `href` is set.
    /// </summary>
    public static void SetDownload<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> download) where T: SlIconButton
    {
        b.SetProperty(b.Props, b.Const("download"), download);
    }

    /// <summary>
    /// Tells the browser to download the linked file as this filename. Only used when `href` is set.
    /// </summary>
    public static void SetDownload<T>(this Metapsi.Syntax.PropsBuilder<T> b, string download) where T: SlIconButton
    {
        b.SetDownload(b.Const(download));
    }

    /// <summary>
    /// A description that gets read by assistive devices. For optimal accessibility, you should always include a label that describes what the icon button does.
    /// </summary>
    public static void SetLabel<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> label) where T: SlIconButton
    {
        b.SetProperty(b.Props, b.Const("label"), label);
    }

    /// <summary>
    /// A description that gets read by assistive devices. For optimal accessibility, you should always include a label that describes what the icon button does.
    /// </summary>
    public static void SetLabel<T>(this Metapsi.Syntax.PropsBuilder<T> b, string label) where T: SlIconButton
    {
        b.SetLabel(b.Const(label));
    }

    /// <summary>
    /// Disables the button.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlIconButton
    {
        b.SetDisabled(b.Const(true));
    }

    /// <summary>
    /// Disables the button.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> disabled) where T: SlIconButton
    {
        b.SetProperty(b.Props, b.Const("disabled"), disabled);
    }

    /// <summary>
    /// Disables the button.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool disabled) where T: SlIconButton
    {
        b.SetDisabled(b.Const(disabled));
    }

    /// <summary>
    /// Emitted when the icon button loses focus.
    /// </summary>
    public static void OnSlBlur<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: SlIconButton
    {
        b.OnSlEvent("onsl-blur", action);
    }

    /// <summary>
    /// Emitted when the icon button loses focus.
    /// </summary>
    public static void OnSlBlur<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: SlIconButton
    {
        b.OnSlBlur(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the icon button loses focus.
    /// </summary>
    public static void OnSlBlur<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: SlIconButton
    {
        b.OnSlEvent("onsl-blur", action);
    }

    /// <summary>
    /// Emitted when the icon button loses focus.
    /// </summary>
    public static void OnSlBlur<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: SlIconButton
    {
        b.OnSlBlur(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the icon button gains focus.
    /// </summary>
    public static void OnSlFocus<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: SlIconButton
    {
        b.OnSlEvent("onsl-focus", action);
    }

    /// <summary>
    /// Emitted when the icon button gains focus.
    /// </summary>
    public static void OnSlFocus<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: SlIconButton
    {
        b.OnSlFocus(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the icon button gains focus.
    /// </summary>
    public static void OnSlFocus<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: SlIconButton
    {
        b.OnSlEvent("onsl-focus", action);
    }

    /// <summary>
    /// Emitted when the icon button gains focus.
    /// </summary>
    public static void OnSlFocus<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: SlIconButton
    {
        b.OnSlFocus(b.MakeAction(action));
    }

}