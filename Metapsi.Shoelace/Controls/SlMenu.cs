using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Shoelace;


public partial class SlMenu : SlComponent
{
    public SlMenu() : base("sl-menu") { }
}

public static partial class SlMenuControl
{
    /// <summary>
    /// Menus provide a list of options for the user to choose from.
    /// </summary>
    public static Var<IVNode> SlMenu(this LayoutBuilder b, Action<PropsBuilder<SlMenu>> buildProps, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-menu", buildProps, children);
    }
    /// <summary>
    /// Menus provide a list of options for the user to choose from.
    /// </summary>
    public static Var<IVNode> SlMenu(this LayoutBuilder b, Action<PropsBuilder<SlMenu>> buildProps, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-menu", buildProps, children);
    }
    /// <summary>
    /// Emitted when a menu item is selected.
    /// </summary>
    public static void OnSlSelect<TModel>(this PropsBuilder<SlMenu> b, Var<HyperType.Action<TModel, DomEvent>> action)
    {
        b.OnEventAction("onsl-select", action);
    }
    /// <summary>
    /// Emitted when a menu item is selected.
    /// </summary>
    public static void OnSlSelect<TModel>(this PropsBuilder<SlMenu> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-select", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when a menu item is selected.
    /// </summary>
    public static void OnSlSelect<TModel>(this PropsBuilder<SlMenu> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onsl-select", action);
    }
    /// <summary>
    /// Emitted when a menu item is selected.
    /// </summary>
    public static void OnSlSelect<TModel>(this PropsBuilder<SlMenu> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-select", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when a menu item is selected.
    /// </summary>
    public static void OnSlSelect<TModel>(this PropsBuilder<SlMenu> b, Var<HyperType.Action<TModel, SlSelectEventArgs>> action)
    {
        b.OnEventAction("onsl-select", action, "detail");
    }
    /// <summary>
    /// Emitted when a menu item is selected.
    /// </summary>
    public static void OnSlSelect<TModel>(this PropsBuilder<SlMenu> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SlSelectEventArgs>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-select", b.MakeAction(action), "detail");
    }

}

