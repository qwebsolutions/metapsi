using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Shoelace;


public partial class SlInclude : SlComponent
{
    public SlInclude() : base("sl-include") { }
}

public static partial class SlIncludeControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlInclude(this HtmlBuilder b, Action<AttributesBuilder<SlInclude>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("sl-include", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlInclude(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("sl-include", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The location of the HTML file to include. Be sure you trust the content you are including as it will be executed as code and can result in XSS attacks. </para>
    /// </summary>
    public static void SetSrc(this AttributesBuilder<SlInclude> b,string src)
    {
        b.SetAttribute("src", src);
    }

    /// <summary>
    /// <para> The fetch mode to use. </para>
    /// </summary>
    public static void SetMode(this AttributesBuilder<SlInclude> b,string mode)
    {
        b.SetAttribute("mode", mode);
    }

    /// <summary>
    /// <para> The fetch mode to use. </para>
    /// </summary>
    public static void SetModeCors(this AttributesBuilder<SlInclude> b)
    {
        b.SetAttribute("mode", "cors");
    }

    /// <summary>
    /// <para> The fetch mode to use. </para>
    /// </summary>
    public static void SetModeNoCors(this AttributesBuilder<SlInclude> b)
    {
        b.SetAttribute("mode", "no-cors");
    }

    /// <summary>
    /// <para> The fetch mode to use. </para>
    /// </summary>
    public static void SetModeSameOrigin(this AttributesBuilder<SlInclude> b)
    {
        b.SetAttribute("mode", "same-origin");
    }

    /// <summary>
    /// <para> Allows included scripts to be executed. Be sure you trust the content you are including as it will be executed as code and can result in XSS attacks. </para>
    /// </summary>
    public static void SetAllowScripts(this AttributesBuilder<SlInclude> b)
    {
        b.SetAttribute("allow-scripts", "");
    }

    /// <summary>
    /// <para> Allows included scripts to be executed. Be sure you trust the content you are including as it will be executed as code and can result in XSS attacks. </para>
    /// </summary>
    public static void SetAllowScripts(this AttributesBuilder<SlInclude> b,bool allowScripts)
    {
        if (allowScripts) b.SetAttribute("allow-scripts", "");
    }

    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlInclude(this LayoutBuilder b, Action<PropsBuilder<SlInclude>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("sl-include", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlInclude(this LayoutBuilder b, Action<PropsBuilder<SlInclude>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("sl-include", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlInclude(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("sl-include", children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlInclude(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("sl-include", children);
    }
    /// <summary>
    /// <para> The location of the HTML file to include. Be sure you trust the content you are including as it will be executed as code and can result in XSS attacks. </para>
    /// </summary>
    public static void SetSrc<T>(this PropsBuilder<T> b, Var<string> src) where T: SlInclude
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("src"), src);
    }

    /// <summary>
    /// <para> The location of the HTML file to include. Be sure you trust the content you are including as it will be executed as code and can result in XSS attacks. </para>
    /// </summary>
    public static void SetSrc<T>(this PropsBuilder<T> b, string src) where T: SlInclude
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("src"), b.Const(src));
    }


    /// <summary>
    /// <para> The fetch mode to use. </para>
    /// </summary>
    public static void SetModeCors<T>(this PropsBuilder<T> b) where T: SlInclude
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("mode"), b.Const("cors"));
    }


    /// <summary>
    /// <para> The fetch mode to use. </para>
    /// </summary>
    public static void SetModeNoCors<T>(this PropsBuilder<T> b) where T: SlInclude
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("mode"), b.Const("no-cors"));
    }


    /// <summary>
    /// <para> The fetch mode to use. </para>
    /// </summary>
    public static void SetModeSameOrigin<T>(this PropsBuilder<T> b) where T: SlInclude
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("mode"), b.Const("same-origin"));
    }


    /// <summary>
    /// <para> Allows included scripts to be executed. Be sure you trust the content you are including as it will be executed as code and can result in XSS attacks. </para>
    /// </summary>
    public static void SetAllowScripts<T>(this PropsBuilder<T> b) where T: SlInclude
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("allowScripts"), b.Const(true));
    }


    /// <summary>
    /// <para> Allows included scripts to be executed. Be sure you trust the content you are including as it will be executed as code and can result in XSS attacks. </para>
    /// </summary>
    public static void SetAllowScripts<T>(this PropsBuilder<T> b, Var<bool> allowScripts) where T: SlInclude
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("allowScripts"), allowScripts);
    }

    /// <summary>
    /// <para> Allows included scripts to be executed. Be sure you trust the content you are including as it will be executed as code and can result in XSS attacks. </para>
    /// </summary>
    public static void SetAllowScripts<T>(this PropsBuilder<T> b, bool allowScripts) where T: SlInclude
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("allowScripts"), b.Const(allowScripts));
    }


    /// <summary>
    /// <para> Emitted when the included file is loaded. </para>
    /// </summary>
    public static void OnSlLoad<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, DomEvent>> action) where TComponent: SlInclude
    {
        b.OnEventAction("onsl-load", action);
    }
    /// <summary>
    /// <para> Emitted when the included file is loaded. </para>
    /// </summary>
    public static void OnSlLoad<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action) where TComponent: SlInclude
    {
        b.OnEventAction("onsl-load", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the included file is loaded. </para>
    /// </summary>
    public static void OnSlLoad<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: SlInclude
    {
        b.OnEventAction("onsl-load", action);
    }
    /// <summary>
    /// <para> Emitted when the included file is loaded. </para>
    /// </summary>
    public static void OnSlLoad<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: SlInclude
    {
        b.OnEventAction("onsl-load", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the included file fails to load due to an error. </para>
    /// </summary>
    public static void OnSlError<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, DomEvent>> action) where TComponent: SlInclude
    {
        b.OnEventAction("onsl-error", action);
    }
    /// <summary>
    /// <para> Emitted when the included file fails to load due to an error. </para>
    /// </summary>
    public static void OnSlError<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action) where TComponent: SlInclude
    {
        b.OnEventAction("onsl-error", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the included file fails to load due to an error. </para>
    /// </summary>
    public static void OnSlError<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: SlInclude
    {
        b.OnEventAction("onsl-error", action);
    }
    /// <summary>
    /// <para> Emitted when the included file fails to load due to an error. </para>
    /// </summary>
    public static void OnSlError<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: SlInclude
    {
        b.OnEventAction("onsl-error", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the included file fails to load due to an error. </para>
    /// </summary>
    public static void OnSlError<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, SlErrorEventArgs>> action) where TComponent: SlInclude
    {
        b.OnEventAction("onsl-error", action, "detail");
    }
    /// <summary>
    /// <para> Emitted when the included file fails to load due to an error. </para>
    /// </summary>
    public static void OnSlError<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SlErrorEventArgs>, Var<TModel>> action) where TComponent: SlInclude
    {
        b.OnEventAction("onsl-error", b.MakeAction(action), "detail");
    }

}

