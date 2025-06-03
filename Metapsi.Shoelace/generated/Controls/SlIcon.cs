using Metapsi.Html;
using Metapsi.Syntax;
using Metapsi.Hyperapp;

namespace Metapsi.Shoelace;

/// <summary>
/// Icons are symbols that can be used to represent various options within an application.
/// </summary>
public partial class SlIcon
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
/// Setter extensions of SlIcon
/// </summary>
public static partial class SlIconControl
{
    /// <summary>
    /// Icons are symbols that can be used to represent various options within an application.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlIcon(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlIcon>> buildAttributes, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-icon", buildAttributes, children);
    }

    /// <summary>
    /// Icons are symbols that can be used to represent various options within an application.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlIcon(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-icon", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// Icons are symbols that can be used to represent various options within an application.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlIcon(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlIcon>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-icon", buildAttributes, children);
    }

    /// <summary>
    /// Icons are symbols that can be used to represent various options within an application.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlIcon(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-icon", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// The name of the icon to draw. Available names depend on the icon library being used.
    /// </summary>
    public static void SetName(this Metapsi.Html.AttributesBuilder<SlIcon> b, string name) 
    {
        b.SetAttribute("name", name);
    }

    /// <summary>
    /// An external URL of an SVG file. Be sure you trust the content you are including, as it will be executed as code and can result in XSS attacks.
    /// </summary>
    public static void SetSrc(this Metapsi.Html.AttributesBuilder<SlIcon> b, string src) 
    {
        b.SetAttribute("src", src);
    }

    /// <summary>
    /// An alternate description to use for assistive devices. If omitted, the icon will be considered presentational and ignored by assistive devices.
    /// </summary>
    public static void SetLabel(this Metapsi.Html.AttributesBuilder<SlIcon> b, string label) 
    {
        b.SetAttribute("label", label);
    }

    /// <summary>
    /// The name of a registered custom icon library.
    /// </summary>
    public static void SetLibrary(this Metapsi.Html.AttributesBuilder<SlIcon> b, string library) 
    {
        b.SetAttribute("library", library);
    }

    /// <summary>
    /// Icons are symbols that can be used to represent various options within an application.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlIcon(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlIcon>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-icon", buildProps, children);
    }

    /// <summary>
    /// Icons are symbols that can be used to represent various options within an application.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlIcon(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-icon", children);
    }

    /// <summary>
    /// Icons are symbols that can be used to represent various options within an application.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlIcon(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlIcon>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-icon", buildProps, children);
    }

    /// <summary>
    /// Icons are symbols that can be used to represent various options within an application.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlIcon(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-icon", children);
    }

    /// <summary>
    /// The name of the icon to draw. Available names depend on the icon library being used.
    /// </summary>
    public static void SetName<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> name) where T: SlIcon
    {
        b.SetProperty(b.Props, b.Const("name"), name);
    }

    /// <summary>
    /// An external URL of an SVG file. Be sure you trust the content you are including, as it will be executed as code and can result in XSS attacks.
    /// </summary>
    public static void SetSrc<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> src) where T: SlIcon
    {
        b.SetProperty(b.Props, b.Const("src"), src);
    }

    /// <summary>
    /// An alternate description to use for assistive devices. If omitted, the icon will be considered presentational and ignored by assistive devices.
    /// </summary>
    public static void SetLabel<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> label) where T: SlIcon
    {
        b.SetProperty(b.Props, b.Const("label"), label);
    }

    /// <summary>
    /// An alternate description to use for assistive devices. If omitted, the icon will be considered presentational and ignored by assistive devices.
    /// </summary>
    public static void SetLabel<T>(this Metapsi.Syntax.PropsBuilder<T> b, string label) where T: SlIcon
    {
        b.SetLabel(b.Const(label));
    }

    /// <summary>
    /// The name of a registered custom icon library.
    /// </summary>
    public static void SetLibrary<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> library) where T: SlIcon
    {
        b.SetProperty(b.Props, b.Const("library"), library);
    }

    /// <summary>
    /// The name of a registered custom icon library.
    /// </summary>
    public static void SetLibrary<T>(this Metapsi.Syntax.PropsBuilder<T> b, string library) where T: SlIcon
    {
        b.SetLibrary(b.Const(library));
    }

    /// <summary>
    /// Emitted when the icon has loaded. When using `spriteSheet: true` this will not emit.
    /// </summary>
    public static void OnSlLoad<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: SlIcon
    {
        b.OnSlEvent("onsl-load", action);
    }

    /// <summary>
    /// Emitted when the icon has loaded. When using `spriteSheet: true` this will not emit.
    /// </summary>
    public static void OnSlLoad<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: SlIcon
    {
        b.OnSlLoad(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the icon has loaded. When using `spriteSheet: true` this will not emit.
    /// </summary>
    public static void OnSlLoad<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: SlIcon
    {
        b.OnSlEvent("onsl-load", action);
    }

    /// <summary>
    /// Emitted when the icon has loaded. When using `spriteSheet: true` this will not emit.
    /// </summary>
    public static void OnSlLoad<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: SlIcon
    {
        b.OnSlLoad(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the icon fails to load due to an error. When using `spriteSheet: true` this will not emit.
    /// </summary>
    public static void OnSlError<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: SlIcon
    {
        b.OnSlEvent("onsl-error", action);
    }

    /// <summary>
    /// Emitted when the icon fails to load due to an error. When using `spriteSheet: true` this will not emit.
    /// </summary>
    public static void OnSlError<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: SlIcon
    {
        b.OnSlError(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the icon fails to load due to an error. When using `spriteSheet: true` this will not emit.
    /// </summary>
    public static void OnSlError<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: SlIcon
    {
        b.OnSlEvent("onsl-error", action);
    }

    /// <summary>
    /// Emitted when the icon fails to load due to an error. When using `spriteSheet: true` this will not emit.
    /// </summary>
    public static void OnSlError<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: SlIcon
    {
        b.OnSlError(b.MakeAction(action));
    }

}