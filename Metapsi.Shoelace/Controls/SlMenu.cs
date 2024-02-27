using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using System.ComponentModel;

namespace Metapsi.Shoelace;


public partial interface IClientSideSlMenu
{
}
public partial class SlMenuSelectArgs
{
    public IClientSideSlMenu target { get; set; }
    public partial class Details 
    {
        public IClientSideSlMenuItem item { get; set; }
    }
    public Details detail { get; set; }
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
    /// event detail: { item: SlMenuItem }
    /// </summary>
    public static void OnSlSelect<TModel>(this PropsBuilder<SlMenu> b, Var<HyperType.Action<TModel, SlMenuSelectArgs>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlMenuSelectArgs>>("onsl-select"), action);
    }
    /// <summary>
    /// Emitted when a menu item is selected.
    /// event detail: { item: SlMenuItem }
    /// </summary>
    public static void OnSlSelect<TModel>(this PropsBuilder<SlMenu> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SlMenuSelectArgs>, Var<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlMenuSelectArgs>>("onsl-select"), b.MakeAction(action));
    }
}

/// <summary>
/// Menus provide a list of options for the user to choose from.
/// </summary>
public partial class SlMenu : HtmlTag
{
    public SlMenu()
    {
        this.Tag = "sl-menu";
    }

    public static SlMenu New()
    {
        return new SlMenu();
    }
}

public static partial class SlMenuControl
{
}

