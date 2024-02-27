using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using System.ComponentModel;

namespace Metapsi.Shoelace;


public partial interface IClientSideSlDropdown
{
}
public partial class SlDropdownShowArgs
{
    public IClientSideSlDropdown target { get; set; }
}
public partial class SlDropdownAfterShowArgs
{
    public IClientSideSlDropdown target { get; set; }
}
public partial class SlDropdownHideArgs
{
    public IClientSideSlDropdown target { get; set; }
}
public partial class SlDropdownAfterHideArgs
{
    public IClientSideSlDropdown target { get; set; }
}
public static partial class SlDropdownControl
{
    /// <summary>
    /// Dropdowns expose additional content that "drops down" in a panel.
    /// </summary>
    public static Var<IVNode> SlDropdown(this LayoutBuilder b, Action<PropsBuilder<SlDropdown>> buildProps, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-dropdown", buildProps, children);
    }
    /// <summary>
    /// Dropdowns expose additional content that "drops down" in a panel.
    /// </summary>
    public static Var<IVNode> SlDropdown(this LayoutBuilder b, Action<PropsBuilder<SlDropdown>> buildProps, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-dropdown", buildProps, children);
    }
    /// <summary>
    /// Indicates whether or not the dropdown is open. You can toggle this attribute to show and hide the dropdown, or you can use the `show()` and `hide()` methods and this attribute will reflect the dropdown's open state.
    /// </summary>
    public static void SetOpen(this PropsBuilder<SlDropdown> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("open"), b.Const(true));
    }
    /// <summary>
    /// The preferred placement of the dropdown panel. Note that the actual placement may vary as needed to keep the panel inside of the viewport.
    /// </summary>
    public static void SetPlacementTop(this PropsBuilder<SlDropdown> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("placement"), b.Const("top"));
    }
    /// <summary>
    /// The preferred placement of the dropdown panel. Note that the actual placement may vary as needed to keep the panel inside of the viewport.
    /// </summary>
    public static void SetPlacementTopstart(this PropsBuilder<SlDropdown> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("placement"), b.Const("top-start"));
    }
    /// <summary>
    /// The preferred placement of the dropdown panel. Note that the actual placement may vary as needed to keep the panel inside of the viewport.
    /// </summary>
    public static void SetPlacementTopend(this PropsBuilder<SlDropdown> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("placement"), b.Const("top-end"));
    }
    /// <summary>
    /// The preferred placement of the dropdown panel. Note that the actual placement may vary as needed to keep the panel inside of the viewport.
    /// </summary>
    public static void SetPlacementBottom(this PropsBuilder<SlDropdown> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("placement"), b.Const("bottom"));
    }
    /// <summary>
    /// The preferred placement of the dropdown panel. Note that the actual placement may vary as needed to keep the panel inside of the viewport.
    /// </summary>
    public static void SetPlacementBottomstart(this PropsBuilder<SlDropdown> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("placement"), b.Const("bottom-start"));
    }
    /// <summary>
    /// The preferred placement of the dropdown panel. Note that the actual placement may vary as needed to keep the panel inside of the viewport.
    /// </summary>
    public static void SetPlacementBottomend(this PropsBuilder<SlDropdown> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("placement"), b.Const("bottom-end"));
    }
    /// <summary>
    /// The preferred placement of the dropdown panel. Note that the actual placement may vary as needed to keep the panel inside of the viewport.
    /// </summary>
    public static void SetPlacementRight(this PropsBuilder<SlDropdown> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("placement"), b.Const("right"));
    }
    /// <summary>
    /// The preferred placement of the dropdown panel. Note that the actual placement may vary as needed to keep the panel inside of the viewport.
    /// </summary>
    public static void SetPlacementRightstart(this PropsBuilder<SlDropdown> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("placement"), b.Const("right-start"));
    }
    /// <summary>
    /// The preferred placement of the dropdown panel. Note that the actual placement may vary as needed to keep the panel inside of the viewport.
    /// </summary>
    public static void SetPlacementRightend(this PropsBuilder<SlDropdown> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("placement"), b.Const("right-end"));
    }
    /// <summary>
    /// The preferred placement of the dropdown panel. Note that the actual placement may vary as needed to keep the panel inside of the viewport.
    /// </summary>
    public static void SetPlacementLeft(this PropsBuilder<SlDropdown> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("placement"), b.Const("left"));
    }
    /// <summary>
    /// The preferred placement of the dropdown panel. Note that the actual placement may vary as needed to keep the panel inside of the viewport.
    /// </summary>
    public static void SetPlacementLeftstart(this PropsBuilder<SlDropdown> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("placement"), b.Const("left-start"));
    }
    /// <summary>
    /// The preferred placement of the dropdown panel. Note that the actual placement may vary as needed to keep the panel inside of the viewport.
    /// </summary>
    public static void SetPlacementLeftend(this PropsBuilder<SlDropdown> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("placement"), b.Const("left-end"));
    }
    /// <summary>
    /// Disables the dropdown so the panel will not open.
    /// </summary>
    public static void SetDisabled(this PropsBuilder<SlDropdown> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("disabled"), b.Const(true));
    }
    /// <summary>
    /// By default, the dropdown is closed when an item is selected. This attribute will keep it open instead. Useful for dropdowns that allow for multiple interactions.
    /// </summary>
    public static void SetStayOpenOnSelect(this PropsBuilder<SlDropdown> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("stayOpenOnSelect"), b.Const(true));
    }
    /// <summary>
    /// The distance in pixels from which to offset the panel away from its trigger.
    /// </summary>
    public static void SetDistance(this PropsBuilder<SlDropdown> b, Var<int> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("distance"), value);
    }
    /// <summary>
    /// The distance in pixels from which to offset the panel away from its trigger.
    /// </summary>
    public static void SetDistance(this PropsBuilder<SlDropdown> b, int value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("distance"), b.Const(value));
    }
    /// <summary>
    /// The distance in pixels from which to offset the panel along its trigger.
    /// </summary>
    public static void SetSkidding(this PropsBuilder<SlDropdown> b, Var<int> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("skidding"), value);
    }
    /// <summary>
    /// The distance in pixels from which to offset the panel along its trigger.
    /// </summary>
    public static void SetSkidding(this PropsBuilder<SlDropdown> b, int value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("skidding"), b.Const(value));
    }
    /// <summary>
    /// Enable this option to prevent the panel from being clipped when the component is placed inside a container with `overflow: auto|scroll`. Hoisting uses a fixed positioning strategy that works in many, but not all, scenarios.
    /// </summary>
    public static void SetHoist(this PropsBuilder<SlDropdown> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("hoist"), b.Const(true));
    }
    /// <summary>
    /// Emitted when the dropdown opens.
    /// </summary>
    public static void OnSlShow<TModel>(this PropsBuilder<SlDropdown> b, Var<HyperType.Action<TModel, SlDropdownShowArgs>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlDropdownShowArgs>>("onsl-show"), action);
    }
    /// <summary>
    /// Emitted when the dropdown opens.
    /// </summary>
    public static void OnSlShow<TModel>(this PropsBuilder<SlDropdown> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SlDropdownShowArgs>, Var<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlDropdownShowArgs>>("onsl-show"), b.MakeAction(action));
    }
    /// <summary>
    /// Emitted after the dropdown opens and all animations are complete.
    /// </summary>
    public static void OnSlAfterShow<TModel>(this PropsBuilder<SlDropdown> b, Var<HyperType.Action<TModel, SlDropdownAfterShowArgs>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlDropdownAfterShowArgs>>("onsl-after-show"), action);
    }
    /// <summary>
    /// Emitted after the dropdown opens and all animations are complete.
    /// </summary>
    public static void OnSlAfterShow<TModel>(this PropsBuilder<SlDropdown> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SlDropdownAfterShowArgs>, Var<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlDropdownAfterShowArgs>>("onsl-after-show"), b.MakeAction(action));
    }
    /// <summary>
    /// Emitted when the dropdown closes.
    /// </summary>
    public static void OnSlHide<TModel>(this PropsBuilder<SlDropdown> b, Var<HyperType.Action<TModel, SlDropdownHideArgs>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlDropdownHideArgs>>("onsl-hide"), action);
    }
    /// <summary>
    /// Emitted when the dropdown closes.
    /// </summary>
    public static void OnSlHide<TModel>(this PropsBuilder<SlDropdown> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SlDropdownHideArgs>, Var<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlDropdownHideArgs>>("onsl-hide"), b.MakeAction(action));
    }
    /// <summary>
    /// Emitted after the dropdown closes and all animations are complete.
    /// </summary>
    public static void OnSlAfterHide<TModel>(this PropsBuilder<SlDropdown> b, Var<HyperType.Action<TModel, SlDropdownAfterHideArgs>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlDropdownAfterHideArgs>>("onsl-after-hide"), action);
    }
    /// <summary>
    /// Emitted after the dropdown closes and all animations are complete.
    /// </summary>
    public static void OnSlAfterHide<TModel>(this PropsBuilder<SlDropdown> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SlDropdownAfterHideArgs>, Var<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlDropdownAfterHideArgs>>("onsl-after-hide"), b.MakeAction(action));
    }
}

/// <summary>
/// Dropdowns expose additional content that "drops down" in a panel.
/// </summary>
public partial class SlDropdown : HtmlTag
{
    public SlDropdown()
    {
        this.Tag = "sl-dropdown";
    }

    public static SlDropdown New()
    {
        return new SlDropdown();
    }
    public static class Slot
    {
        /// <summary> 
        /// The dropdown's trigger, usually a `<sl-button>` element.
        /// </summary>
        public const string Trigger = "trigger";
    }
}

public static partial class SlDropdownControl
{
    /// <summary>
    /// Indicates whether or not the dropdown is open. You can toggle this attribute to show and hide the dropdown, or you can use the `show()` and `hide()` methods and this attribute will reflect the dropdown's open state.
    /// </summary>
    public static SlDropdown SetOpen(this SlDropdown tag)
    {
        return tag.SetAttribute("open", "true");
    }
    /// <summary>
    /// The preferred placement of the dropdown panel. Note that the actual placement may vary as needed to keep the panel inside of the viewport.
    /// </summary>
    public static SlDropdown SetPlacementTop(this SlDropdown tag)
    {
        return tag.SetAttribute("placement", "top");
    }
    /// <summary>
    /// The preferred placement of the dropdown panel. Note that the actual placement may vary as needed to keep the panel inside of the viewport.
    /// </summary>
    public static SlDropdown SetPlacementTopstart(this SlDropdown tag)
    {
        return tag.SetAttribute("placement", "top-start");
    }
    /// <summary>
    /// The preferred placement of the dropdown panel. Note that the actual placement may vary as needed to keep the panel inside of the viewport.
    /// </summary>
    public static SlDropdown SetPlacementTopend(this SlDropdown tag)
    {
        return tag.SetAttribute("placement", "top-end");
    }
    /// <summary>
    /// The preferred placement of the dropdown panel. Note that the actual placement may vary as needed to keep the panel inside of the viewport.
    /// </summary>
    public static SlDropdown SetPlacementBottom(this SlDropdown tag)
    {
        return tag.SetAttribute("placement", "bottom");
    }
    /// <summary>
    /// The preferred placement of the dropdown panel. Note that the actual placement may vary as needed to keep the panel inside of the viewport.
    /// </summary>
    public static SlDropdown SetPlacementBottomstart(this SlDropdown tag)
    {
        return tag.SetAttribute("placement", "bottom-start");
    }
    /// <summary>
    /// The preferred placement of the dropdown panel. Note that the actual placement may vary as needed to keep the panel inside of the viewport.
    /// </summary>
    public static SlDropdown SetPlacementBottomend(this SlDropdown tag)
    {
        return tag.SetAttribute("placement", "bottom-end");
    }
    /// <summary>
    /// The preferred placement of the dropdown panel. Note that the actual placement may vary as needed to keep the panel inside of the viewport.
    /// </summary>
    public static SlDropdown SetPlacementRight(this SlDropdown tag)
    {
        return tag.SetAttribute("placement", "right");
    }
    /// <summary>
    /// The preferred placement of the dropdown panel. Note that the actual placement may vary as needed to keep the panel inside of the viewport.
    /// </summary>
    public static SlDropdown SetPlacementRightstart(this SlDropdown tag)
    {
        return tag.SetAttribute("placement", "right-start");
    }
    /// <summary>
    /// The preferred placement of the dropdown panel. Note that the actual placement may vary as needed to keep the panel inside of the viewport.
    /// </summary>
    public static SlDropdown SetPlacementRightend(this SlDropdown tag)
    {
        return tag.SetAttribute("placement", "right-end");
    }
    /// <summary>
    /// The preferred placement of the dropdown panel. Note that the actual placement may vary as needed to keep the panel inside of the viewport.
    /// </summary>
    public static SlDropdown SetPlacementLeft(this SlDropdown tag)
    {
        return tag.SetAttribute("placement", "left");
    }
    /// <summary>
    /// The preferred placement of the dropdown panel. Note that the actual placement may vary as needed to keep the panel inside of the viewport.
    /// </summary>
    public static SlDropdown SetPlacementLeftstart(this SlDropdown tag)
    {
        return tag.SetAttribute("placement", "left-start");
    }
    /// <summary>
    /// The preferred placement of the dropdown panel. Note that the actual placement may vary as needed to keep the panel inside of the viewport.
    /// </summary>
    public static SlDropdown SetPlacementLeftend(this SlDropdown tag)
    {
        return tag.SetAttribute("placement", "left-end");
    }
    /// <summary>
    /// Disables the dropdown so the panel will not open.
    /// </summary>
    public static SlDropdown SetDisabled(this SlDropdown tag)
    {
        return tag.SetAttribute("disabled", "true");
    }
    /// <summary>
    /// By default, the dropdown is closed when an item is selected. This attribute will keep it open instead. Useful for dropdowns that allow for multiple interactions.
    /// </summary>
    public static SlDropdown SetStayOpenOnSelect(this SlDropdown tag)
    {
        return tag.SetAttribute("stayOpenOnSelect", "true");
    }
    /// <summary>
    /// The distance in pixels from which to offset the panel away from its trigger.
    /// </summary>
    public static SlDropdown SetDistance(this SlDropdown tag, int value)
    {
        return tag.SetAttribute("distance", value.ToString());
    }
    /// <summary>
    /// The distance in pixels from which to offset the panel along its trigger.
    /// </summary>
    public static SlDropdown SetSkidding(this SlDropdown tag, int value)
    {
        return tag.SetAttribute("skidding", value.ToString());
    }
    /// <summary>
    /// Enable this option to prevent the panel from being clipped when the component is placed inside a container with `overflow: auto|scroll`. Hoisting uses a fixed positioning strategy that works in many, but not all, scenarios.
    /// </summary>
    public static SlDropdown SetHoist(this SlDropdown tag)
    {
        return tag.SetAttribute("hoist", "true");
    }
}

