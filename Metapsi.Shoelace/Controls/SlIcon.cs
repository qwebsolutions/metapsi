using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Shoelace;


public partial class SlIcon
{
    public static class Method
    {
        /// <summary>
        /// <para> Given a URL, this function returns the resulting SVG element or an appropriate error symbol. </para>
        /// </summary>
        public const string ResolveIcon = "resolveIcon";
    }
}

public static partial class SlIconControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlIcon(this HtmlBuilder b, Action<AttributesBuilder<SlIcon>> buildAttributes, params IHtmlNode[] children)
    {
        return b.SlTag("sl-icon", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlIcon(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.SlTag("sl-icon", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlIcon(this HtmlBuilder b, Action<AttributesBuilder<SlIcon>> buildAttributes, List<IHtmlNode> children)
    {
        return b.SlTag("sl-icon", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlIcon(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.SlTag("sl-icon", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The name of the icon to draw. Available names depend on the icon library being used. </para>
    /// </summary>
    public static void SetName(this AttributesBuilder<SlIcon> b, string name)
    {
        b.SetAttribute("name", name);
    }

    /// <summary>
    /// <para> An external URL of an SVG file. Be sure you trust the content you are including, as it will be executed as code and can result in XSS attacks. </para>
    /// </summary>
    public static void SetSrc(this AttributesBuilder<SlIcon> b, string src)
    {
        b.SetAttribute("src", src);
    }

    /// <summary>
    /// <para> An alternate description to use for assistive devices. If omitted, the icon will be considered presentational and ignored by assistive devices. </para>
    /// </summary>
    public static void SetLabel(this AttributesBuilder<SlIcon> b, string label)
    {
        b.SetAttribute("label", label);
    }

    /// <summary>
    /// <para> The name of a registered custom icon library. </para>
    /// </summary>
    public static void SetLibrary(this AttributesBuilder<SlIcon> b, string library)
    {
        b.SetAttribute("library", library);
    }

    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlIcon(this LayoutBuilder b, Action<PropsBuilder<SlIcon>> buildProps, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-icon", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlIcon(this LayoutBuilder b, Action<PropsBuilder<SlIcon>> buildProps, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-icon", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlIcon(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-icon", children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlIcon(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-icon", children);
    }
    /// <summary>
    /// <para> The name of the icon to draw. Available names depend on the icon library being used. </para>
    /// </summary>
    public static void SetName<T>(this PropsBuilder<T> b, Var<string> name) where T: SlIcon
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("name"), name);
    }

    /// <summary>
    /// <para> The name of the icon to draw. Available names depend on the icon library being used. </para>
    /// </summary>
    public static void SetName<T>(this PropsBuilder<T> b, string name) where T: SlIcon
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("name"), b.Const(name));
    }


    /// <summary>
    /// <para> An external URL of an SVG file. Be sure you trust the content you are including, as it will be executed as code and can result in XSS attacks. </para>
    /// </summary>
    public static void SetSrc<T>(this PropsBuilder<T> b, Var<string> src) where T: SlIcon
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("src"), src);
    }

    /// <summary>
    /// <para> An external URL of an SVG file. Be sure you trust the content you are including, as it will be executed as code and can result in XSS attacks. </para>
    /// </summary>
    public static void SetSrc<T>(this PropsBuilder<T> b, string src) where T: SlIcon
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("src"), b.Const(src));
    }


    /// <summary>
    /// <para> An alternate description to use for assistive devices. If omitted, the icon will be considered presentational and ignored by assistive devices. </para>
    /// </summary>
    public static void SetLabel<T>(this PropsBuilder<T> b, Var<string> label) where T: SlIcon
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("label"), label);
    }

    /// <summary>
    /// <para> An alternate description to use for assistive devices. If omitted, the icon will be considered presentational and ignored by assistive devices. </para>
    /// </summary>
    public static void SetLabel<T>(this PropsBuilder<T> b, string label) where T: SlIcon
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("label"), b.Const(label));
    }


    /// <summary>
    /// <para> The name of a registered custom icon library. </para>
    /// </summary>
    public static void SetLibrary<T>(this PropsBuilder<T> b, Var<string> library) where T: SlIcon
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("library"), library);
    }

    /// <summary>
    /// <para> The name of a registered custom icon library. </para>
    /// </summary>
    public static void SetLibrary<T>(this PropsBuilder<T> b, string library) where T: SlIcon
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("library"), b.Const(library));
    }


    /// <summary>
    /// <para> Emitted when the icon has loaded. When using `spriteSheet: true` this will not emit. </para>
    /// </summary>
    public static void OnSlLoad<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, Event>> action) where TComponent: SlIcon
    {
        b.OnEventAction("onsl-load", action);
    }
    /// <summary>
    /// <para> Emitted when the icon has loaded. When using `spriteSheet: true` this will not emit. </para>
    /// </summary>
    public static void OnSlLoad<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<Event>, Var<TModel>> action) where TComponent: SlIcon
    {
        b.OnEventAction("onsl-load", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the icon has loaded. When using `spriteSheet: true` this will not emit. </para>
    /// </summary>
    public static void OnSlLoad<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: SlIcon
    {
        b.OnEventAction("onsl-load", action);
    }
    /// <summary>
    /// <para> Emitted when the icon has loaded. When using `spriteSheet: true` this will not emit. </para>
    /// </summary>
    public static void OnSlLoad<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: SlIcon
    {
        b.OnEventAction("onsl-load", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the icon fails to load due to an error. When using `spriteSheet: true` this will not emit. </para>
    /// </summary>
    public static void OnSlError<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, Event>> action) where TComponent: SlIcon
    {
        b.OnEventAction("onsl-error", action);
    }
    /// <summary>
    /// <para> Emitted when the icon fails to load due to an error. When using `spriteSheet: true` this will not emit. </para>
    /// </summary>
    public static void OnSlError<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<Event>, Var<TModel>> action) where TComponent: SlIcon
    {
        b.OnEventAction("onsl-error", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the icon fails to load due to an error. When using `spriteSheet: true` this will not emit. </para>
    /// </summary>
    public static void OnSlError<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: SlIcon
    {
        b.OnEventAction("onsl-error", action);
    }
    /// <summary>
    /// <para> Emitted when the icon fails to load due to an error. When using `spriteSheet: true` this will not emit. </para>
    /// </summary>
    public static void OnSlError<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: SlIcon
    {
        b.OnEventAction("onsl-error", b.MakeAction(action));
    }

}

