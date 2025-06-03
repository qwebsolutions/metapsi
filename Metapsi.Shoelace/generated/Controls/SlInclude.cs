using Metapsi.Html;
using Metapsi.Syntax;
using Metapsi.Hyperapp;

namespace Metapsi.Shoelace;

/// <summary>
/// Includes give you the power to embed external HTML files into the page.
/// </summary>
public partial class SlInclude
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
/// Setter extensions of SlInclude
/// </summary>
public static partial class SlIncludeControl
{
    /// <summary>
    /// Includes give you the power to embed external HTML files into the page.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlInclude(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlInclude>> buildAttributes, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-include", buildAttributes, children);
    }

    /// <summary>
    /// Includes give you the power to embed external HTML files into the page.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlInclude(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-include", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// Includes give you the power to embed external HTML files into the page.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlInclude(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlInclude>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-include", buildAttributes, children);
    }

    /// <summary>
    /// Includes give you the power to embed external HTML files into the page.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlInclude(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-include", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// The location of the HTML file to include. Be sure you trust the content you are including as it will be executed as code and can result in XSS attacks.
    /// </summary>
    public static void SetSrc(this Metapsi.Html.AttributesBuilder<SlInclude> b, string src) 
    {
        b.SetAttribute("src", src);
    }

    /// <summary>
    /// The fetch mode to use.
    /// </summary>
    public static void SetModeCors(this Metapsi.Html.AttributesBuilder<SlInclude> b) 
    {
        b.SetAttribute("mode", "cors");
    }

    /// <summary>
    /// The fetch mode to use.
    /// </summary>
    public static void SetModeNoCors(this Metapsi.Html.AttributesBuilder<SlInclude> b) 
    {
        b.SetAttribute("mode", "no-cors");
    }

    /// <summary>
    /// The fetch mode to use.
    /// </summary>
    public static void SetModeSameOrigin(this Metapsi.Html.AttributesBuilder<SlInclude> b) 
    {
        b.SetAttribute("mode", "same-origin");
    }

    /// <summary>
    /// Allows included scripts to be executed. Be sure you trust the content you are including as it will be executed as code and can result in XSS attacks.
    /// </summary>
    public static void SetAllowScripts(this Metapsi.Html.AttributesBuilder<SlInclude> b, bool allowScripts) 
    {
        if (allowScripts) b.SetAttribute("allow-scripts", "");
    }

    /// <summary>
    /// Allows included scripts to be executed. Be sure you trust the content you are including as it will be executed as code and can result in XSS attacks.
    /// </summary>
    public static void SetAllowScripts(this Metapsi.Html.AttributesBuilder<SlInclude> b) 
    {
        b.SetAttribute("allow-scripts", "");
    }

    /// <summary>
    /// Includes give you the power to embed external HTML files into the page.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlInclude(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlInclude>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-include", buildProps, children);
    }

    /// <summary>
    /// Includes give you the power to embed external HTML files into the page.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlInclude(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-include", children);
    }

    /// <summary>
    /// Includes give you the power to embed external HTML files into the page.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlInclude(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlInclude>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-include", buildProps, children);
    }

    /// <summary>
    /// Includes give you the power to embed external HTML files into the page.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlInclude(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-include", children);
    }

    /// <summary>
    /// The location of the HTML file to include. Be sure you trust the content you are including as it will be executed as code and can result in XSS attacks.
    /// </summary>
    public static void SetSrc<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> src) where T: SlInclude
    {
        b.SetProperty(b.Props, b.Const("src"), src);
    }

    /// <summary>
    /// The location of the HTML file to include. Be sure you trust the content you are including as it will be executed as code and can result in XSS attacks.
    /// </summary>
    public static void SetSrc<T>(this Metapsi.Syntax.PropsBuilder<T> b, string src) where T: SlInclude
    {
        b.SetSrc(b.Const(src));
    }

    /// <summary>
    /// The fetch mode to use.
    /// </summary>
    public static void SetModeCors<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlInclude
    {
        b.SetProperty(b.Props, b.Const("mode"), b.Const("cors"));
    }

    /// <summary>
    /// The fetch mode to use.
    /// </summary>
    public static void SetModeNoCors<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlInclude
    {
        b.SetProperty(b.Props, b.Const("mode"), b.Const("no-cors"));
    }

    /// <summary>
    /// The fetch mode to use.
    /// </summary>
    public static void SetModeSameOrigin<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlInclude
    {
        b.SetProperty(b.Props, b.Const("mode"), b.Const("same-origin"));
    }

    /// <summary>
    /// Allows included scripts to be executed. Be sure you trust the content you are including as it will be executed as code and can result in XSS attacks.
    /// </summary>
    public static void SetAllowScripts<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlInclude
    {
        b.SetAllowScripts(b.Const(true));
    }

    /// <summary>
    /// Allows included scripts to be executed. Be sure you trust the content you are including as it will be executed as code and can result in XSS attacks.
    /// </summary>
    public static void SetAllowScripts<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> allowScripts) where T: SlInclude
    {
        b.SetProperty(b.Props, b.Const("allowScripts"), allowScripts);
    }

    /// <summary>
    /// Allows included scripts to be executed. Be sure you trust the content you are including as it will be executed as code and can result in XSS attacks.
    /// </summary>
    public static void SetAllowScripts<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool allowScripts) where T: SlInclude
    {
        b.SetAllowScripts(b.Const(allowScripts));
    }

    /// <summary>
    /// Emitted when the included file is loaded.
    /// </summary>
    public static void OnSlLoad<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: SlInclude
    {
        b.OnSlEvent("onsl-load", action);
    }

    /// <summary>
    /// Emitted when the included file is loaded.
    /// </summary>
    public static void OnSlLoad<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: SlInclude
    {
        b.OnSlLoad(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the included file is loaded.
    /// </summary>
    public static void OnSlLoad<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: SlInclude
    {
        b.OnSlEvent("onsl-load", action);
    }

    /// <summary>
    /// Emitted when the included file is loaded.
    /// </summary>
    public static void OnSlLoad<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: SlInclude
    {
        b.OnSlLoad(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the included file fails to load due to an error.
    /// </summary>
    public static void OnSlError<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: SlInclude
    {
        b.OnSlEvent("onsl-error", action);
    }

    /// <summary>
    /// Emitted when the included file fails to load due to an error.
    /// </summary>
    public static void OnSlError<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: SlInclude
    {
        b.OnSlError(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the included file fails to load due to an error.
    /// </summary>
    public static void OnSlError<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: SlInclude
    {
        b.OnSlEvent("onsl-error", action);
    }

    /// <summary>
    /// Emitted when the included file fails to load due to an error.
    /// </summary>
    public static void OnSlError<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: SlInclude
    {
        b.OnSlError(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the included file fails to load due to an error.
    /// </summary>
    public static void OnSlError<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.CustomEvent<SlErrorDetail>>> action) where T: SlInclude
    {
        b.OnSlEvent("onsl-error", action);
    }

}