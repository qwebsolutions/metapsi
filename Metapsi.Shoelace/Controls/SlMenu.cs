using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Shoelace;


public partial class SlMenu
{
}

public static partial class SlMenuControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlMenu(this HtmlBuilder b, Action<AttributesBuilder<SlMenu>> buildAttributes, params IHtmlNode[] children)
    {
        return b.SlTag("sl-menu", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlMenu(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.SlTag("sl-menu", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlMenu(this HtmlBuilder b, Action<AttributesBuilder<SlMenu>> buildAttributes, List<IHtmlNode> children)
    {
        return b.SlTag("sl-menu", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlMenu(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.SlTag("sl-menu", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlMenu(this LayoutBuilder b, Action<PropsBuilder<SlMenu>> buildProps, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-menu", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlMenu(this LayoutBuilder b, Action<PropsBuilder<SlMenu>> buildProps, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-menu", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlMenu(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-menu", children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlMenu(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-menu", children);
    }
    /// <summary>
    /// <para> Emitted when a menu item is selected. </para>
    /// </summary>
    public static void OnSlSelect<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, DomEvent>> action) where TComponent: SlMenu
    {
        b.OnEventAction("onsl-select", action);
    }
    /// <summary>
    /// <para> Emitted when a menu item is selected. </para>
    /// </summary>
    public static void OnSlSelect<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action) where TComponent: SlMenu
    {
        b.OnEventAction("onsl-select", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when a menu item is selected. </para>
    /// </summary>
    public static void OnSlSelect<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: SlMenu
    {
        b.OnEventAction("onsl-select", action);
    }
    /// <summary>
    /// <para> Emitted when a menu item is selected. </para>
    /// </summary>
    public static void OnSlSelect<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: SlMenu
    {
        b.OnEventAction("onsl-select", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when a menu item is selected. </para>
    /// </summary>
    public static void OnSlSelect<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, SlSelectEventArgs>> action) where TComponent: SlMenu
    {
        b.OnEventAction("onsl-select", action, "detail");
    }
    /// <summary>
    /// <para> Emitted when a menu item is selected. </para>
    /// </summary>
    public static void OnSlSelect<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SlSelectEventArgs>, Var<TModel>> action) where TComponent: SlMenu
    {
        b.OnEventAction("onsl-select", b.MakeAction(action), "detail");
    }

}

