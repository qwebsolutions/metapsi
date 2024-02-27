using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using System.ComponentModel;

namespace Metapsi.Shoelace;


public partial interface IClientSideSlTabGroup
{
}
public partial class SlTabGroupTabShowArgs
{
    public IClientSideSlTabGroup target { get; set; }
    public partial class Details 
    {
        public string name { get; set; }
    }
    public Details detail { get; set; }
}
public partial class SlTabGroupTabHideArgs
{
    public IClientSideSlTabGroup target { get; set; }
    public partial class Details 
    {
        public string name { get; set; }
    }
    public Details detail { get; set; }
}
public static partial class SlTabGroupControl
{
    /// <summary>
    /// Tab groups organize content into a container that shows one section at a time.
    /// </summary>
    public static Var<IVNode> SlTabGroup(this LayoutBuilder b, Action<PropsBuilder<SlTabGroup>> buildProps, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-tab-group", buildProps, children);
    }
    /// <summary>
    /// Tab groups organize content into a container that shows one section at a time.
    /// </summary>
    public static Var<IVNode> SlTabGroup(this LayoutBuilder b, Action<PropsBuilder<SlTabGroup>> buildProps, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-tab-group", buildProps, children);
    }
    /// <summary>
    /// The placement of the tabs.
    /// </summary>
    public static void SetPlacementTop(this PropsBuilder<SlTabGroup> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("placement"), b.Const("top"));
    }
    /// <summary>
    /// The placement of the tabs.
    /// </summary>
    public static void SetPlacementBottom(this PropsBuilder<SlTabGroup> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("placement"), b.Const("bottom"));
    }
    /// <summary>
    /// The placement of the tabs.
    /// </summary>
    public static void SetPlacementStart(this PropsBuilder<SlTabGroup> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("placement"), b.Const("start"));
    }
    /// <summary>
    /// The placement of the tabs.
    /// </summary>
    public static void SetPlacementEnd(this PropsBuilder<SlTabGroup> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("placement"), b.Const("end"));
    }
    /// <summary>
    /// When set to auto, navigating tabs with the arrow keys will instantly show the corresponding tab panel. When set to manual, the tab will receive focus but will not show until the user presses spacebar or enter.
    /// </summary>
    public static void SetActivationAuto(this PropsBuilder<SlTabGroup> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("activation"), b.Const("auto"));
    }
    /// <summary>
    /// When set to auto, navigating tabs with the arrow keys will instantly show the corresponding tab panel. When set to manual, the tab will receive focus but will not show until the user presses spacebar or enter.
    /// </summary>
    public static void SetActivationManual(this PropsBuilder<SlTabGroup> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("activation"), b.Const("manual"));
    }
    /// <summary>
    /// Disables the scroll arrows that appear when tabs overflow.
    /// </summary>
    public static void SetNoScrollControls(this PropsBuilder<SlTabGroup> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("noScrollControls"), b.Const(true));
    }
    /// <summary>
    /// Emitted when a tab is shown.
    /// event detail: { name: String }
    /// </summary>
    public static void OnSlTabShow<TModel>(this PropsBuilder<SlTabGroup> b, Var<HyperType.Action<TModel, SlTabGroupTabShowArgs>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlTabGroupTabShowArgs>>("onsl-tab-show"), action);
    }
    /// <summary>
    /// Emitted when a tab is shown.
    /// event detail: { name: String }
    /// </summary>
    public static void OnSlTabShow<TModel>(this PropsBuilder<SlTabGroup> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SlTabGroupTabShowArgs>, Var<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlTabGroupTabShowArgs>>("onsl-tab-show"), b.MakeAction(action));
    }
    /// <summary>
    /// Emitted when a tab is hidden.
    /// event detail: { name: String }
    /// </summary>
    public static void OnSlTabHide<TModel>(this PropsBuilder<SlTabGroup> b, Var<HyperType.Action<TModel, SlTabGroupTabHideArgs>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlTabGroupTabHideArgs>>("onsl-tab-hide"), action);
    }
    /// <summary>
    /// Emitted when a tab is hidden.
    /// event detail: { name: String }
    /// </summary>
    public static void OnSlTabHide<TModel>(this PropsBuilder<SlTabGroup> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SlTabGroupTabHideArgs>, Var<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlTabGroupTabHideArgs>>("onsl-tab-hide"), b.MakeAction(action));
    }
}

/// <summary>
/// Tab groups organize content into a container that shows one section at a time.
/// </summary>
public partial class SlTabGroup : HtmlTag
{
    public SlTabGroup()
    {
        this.Tag = "sl-tab-group";
    }

    public static SlTabGroup New()
    {
        return new SlTabGroup();
    }
    public static class Slot
    {
        /// <summary> 
        /// Used for grouping tabs in the tab group. Must be `<sl-tab>` elements.
        /// </summary>
        public const string Nav = "nav";
    }
}

public static partial class SlTabGroupControl
{
    /// <summary>
    /// The placement of the tabs.
    /// </summary>
    public static SlTabGroup SetPlacementTop(this SlTabGroup tag)
    {
        return tag.SetAttribute("placement", "top");
    }
    /// <summary>
    /// The placement of the tabs.
    /// </summary>
    public static SlTabGroup SetPlacementBottom(this SlTabGroup tag)
    {
        return tag.SetAttribute("placement", "bottom");
    }
    /// <summary>
    /// The placement of the tabs.
    /// </summary>
    public static SlTabGroup SetPlacementStart(this SlTabGroup tag)
    {
        return tag.SetAttribute("placement", "start");
    }
    /// <summary>
    /// The placement of the tabs.
    /// </summary>
    public static SlTabGroup SetPlacementEnd(this SlTabGroup tag)
    {
        return tag.SetAttribute("placement", "end");
    }
    /// <summary>
    /// When set to auto, navigating tabs with the arrow keys will instantly show the corresponding tab panel. When set to manual, the tab will receive focus but will not show until the user presses spacebar or enter.
    /// </summary>
    public static SlTabGroup SetActivationAuto(this SlTabGroup tag)
    {
        return tag.SetAttribute("activation", "auto");
    }
    /// <summary>
    /// When set to auto, navigating tabs with the arrow keys will instantly show the corresponding tab panel. When set to manual, the tab will receive focus but will not show until the user presses spacebar or enter.
    /// </summary>
    public static SlTabGroup SetActivationManual(this SlTabGroup tag)
    {
        return tag.SetAttribute("activation", "manual");
    }
    /// <summary>
    /// Disables the scroll arrows that appear when tabs overflow.
    /// </summary>
    public static SlTabGroup SetNoScrollControls(this SlTabGroup tag)
    {
        return tag.SetAttribute("noScrollControls", "true");
    }
}

