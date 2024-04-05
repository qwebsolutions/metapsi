using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Shoelace;


public partial class SlTabGroup : SlComponent
{
    public SlTabGroup() : base("sl-tab-group") { }
    /// <summary>
    /// The placement of the tabs.
    /// </summary>
    public string placement
    {
        get
        {
            return this.GetTag().GetAttribute<string>("placement");
        }
        set
        {
            this.GetTag().SetAttribute("placement", value.ToString());
        }
    }

    /// <summary>
    /// When set to auto, navigating tabs with the arrow keys will instantly show the corresponding tab panel. When set to manual, the tab will receive focus but will not show until the user presses spacebar or enter.
    /// </summary>
    public string activation
    {
        get
        {
            return this.GetTag().GetAttribute<string>("activation");
        }
        set
        {
            this.GetTag().SetAttribute("activation", value.ToString());
        }
    }

    /// <summary>
    /// Disables the scroll arrows that appear when tabs overflow.
    /// </summary>
    public bool noScrollControls
    {
        get
        {
            return this.GetTag().GetAttribute<bool>("noScrollControls");
        }
        set
        {
            if (!value) return;
            this.GetTag().SetAttribute("noScrollControls", value.ToString());
        }
    }

    public static class Slot
    {
        /// <summary> 
        /// Used for grouping tabs in the tab group. Must be `<sl-tab>` elements.
        /// </summary>
        public const string Nav = "nav";
    }
    public static class Method
    {
        /// <summary> 
        /// Shows the specified tab panel.
        /// </summary>
        public const string Show = "show";
    }
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
    /// </summary>
    public static void OnSlTabShow<TModel>(this PropsBuilder<SlTabGroup> b, Var<HyperType.Action<TModel, DomEvent>> action)
    {
        b.OnEventAction("onsl-tab-show", action);
    }
    /// <summary>
    /// Emitted when a tab is shown.
    /// </summary>
    public static void OnSlTabShow<TModel>(this PropsBuilder<SlTabGroup> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-tab-show", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when a tab is shown.
    /// </summary>
    public static void OnSlTabShow<TModel>(this PropsBuilder<SlTabGroup> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onsl-tab-show", action);
    }
    /// <summary>
    /// Emitted when a tab is shown.
    /// </summary>
    public static void OnSlTabShow<TModel>(this PropsBuilder<SlTabGroup> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-tab-show", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when a tab is shown.
    /// </summary>
    public static void OnSlTabShow<TModel>(this PropsBuilder<SlTabGroup> b, Var<HyperType.Action<TModel, SlTabShowEventArgs>> action)
    {
        b.OnEventAction("onsl-tab-show", action, "detail");
    }
    /// <summary>
    /// Emitted when a tab is shown.
    /// </summary>
    public static void OnSlTabShow<TModel>(this PropsBuilder<SlTabGroup> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SlTabShowEventArgs>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-tab-show", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// Emitted when a tab is hidden.
    /// </summary>
    public static void OnSlTabHide<TModel>(this PropsBuilder<SlTabGroup> b, Var<HyperType.Action<TModel, DomEvent>> action)
    {
        b.OnEventAction("onsl-tab-hide", action);
    }
    /// <summary>
    /// Emitted when a tab is hidden.
    /// </summary>
    public static void OnSlTabHide<TModel>(this PropsBuilder<SlTabGroup> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-tab-hide", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when a tab is hidden.
    /// </summary>
    public static void OnSlTabHide<TModel>(this PropsBuilder<SlTabGroup> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onsl-tab-hide", action);
    }
    /// <summary>
    /// Emitted when a tab is hidden.
    /// </summary>
    public static void OnSlTabHide<TModel>(this PropsBuilder<SlTabGroup> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-tab-hide", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when a tab is hidden.
    /// </summary>
    public static void OnSlTabHide<TModel>(this PropsBuilder<SlTabGroup> b, Var<HyperType.Action<TModel, SlTabHideEventArgs>> action)
    {
        b.OnEventAction("onsl-tab-hide", action, "detail");
    }
    /// <summary>
    /// Emitted when a tab is hidden.
    /// </summary>
    public static void OnSlTabHide<TModel>(this PropsBuilder<SlTabGroup> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SlTabHideEventArgs>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-tab-hide", b.MakeAction(action), "detail");
    }

}

