using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using System.ComponentModel;

namespace Metapsi.Shoelace;


public partial interface IClientSideSlTooltip
{
}
public partial class SlTooltipShowArgs
{
    public IClientSideSlTooltip target { get; set; }
}
public partial class SlTooltipAfterShowArgs
{
    public IClientSideSlTooltip target { get; set; }
}
public partial class SlTooltipHideArgs
{
    public IClientSideSlTooltip target { get; set; }
}
public partial class SlTooltipAfterHideArgs
{
    public IClientSideSlTooltip target { get; set; }
}
public static partial class SlTooltipControl
{
    /// <summary>
    /// Tooltips display additional information based on a specific action.
    /// </summary>
    public static Var<IVNode> SlTooltip(this LayoutBuilder b, Action<PropsBuilder<SlTooltip>> buildProps, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-tooltip", buildProps, children);
    }
    /// <summary>
    /// Tooltips display additional information based on a specific action.
    /// </summary>
    public static Var<IVNode> SlTooltip(this LayoutBuilder b, Action<PropsBuilder<SlTooltip>> buildProps, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-tooltip", buildProps, children);
    }
    /// <summary>
    /// The tooltip's content. If you need to display HTML, use the `content` slot instead.
    /// </summary>
    public static void SetContent(this PropsBuilder<SlTooltip> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("content"), value);
    }
    /// <summary>
    /// The tooltip's content. If you need to display HTML, use the `content` slot instead.
    /// </summary>
    public static void SetContent(this PropsBuilder<SlTooltip> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("content"), b.Const(value));
    }
    /// <summary>
    /// The preferred placement of the tooltip. Note that the actual placement may vary as needed to keep the tooltip inside of the viewport.
    /// </summary>
    public static void SetPlacementTop(this PropsBuilder<SlTooltip> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("placement"), b.Const("top"));
    }
    /// <summary>
    /// The preferred placement of the tooltip. Note that the actual placement may vary as needed to keep the tooltip inside of the viewport.
    /// </summary>
    public static void SetPlacementTopstart(this PropsBuilder<SlTooltip> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("placement"), b.Const("top-start"));
    }
    /// <summary>
    /// The preferred placement of the tooltip. Note that the actual placement may vary as needed to keep the tooltip inside of the viewport.
    /// </summary>
    public static void SetPlacementTopend(this PropsBuilder<SlTooltip> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("placement"), b.Const("top-end"));
    }
    /// <summary>
    /// The preferred placement of the tooltip. Note that the actual placement may vary as needed to keep the tooltip inside of the viewport.
    /// </summary>
    public static void SetPlacementRight(this PropsBuilder<SlTooltip> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("placement"), b.Const("right"));
    }
    /// <summary>
    /// The preferred placement of the tooltip. Note that the actual placement may vary as needed to keep the tooltip inside of the viewport.
    /// </summary>
    public static void SetPlacementRightstart(this PropsBuilder<SlTooltip> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("placement"), b.Const("right-start"));
    }
    /// <summary>
    /// The preferred placement of the tooltip. Note that the actual placement may vary as needed to keep the tooltip inside of the viewport.
    /// </summary>
    public static void SetPlacementRightend(this PropsBuilder<SlTooltip> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("placement"), b.Const("right-end"));
    }
    /// <summary>
    /// The preferred placement of the tooltip. Note that the actual placement may vary as needed to keep the tooltip inside of the viewport.
    /// </summary>
    public static void SetPlacementBottom(this PropsBuilder<SlTooltip> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("placement"), b.Const("bottom"));
    }
    /// <summary>
    /// The preferred placement of the tooltip. Note that the actual placement may vary as needed to keep the tooltip inside of the viewport.
    /// </summary>
    public static void SetPlacementBottomstart(this PropsBuilder<SlTooltip> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("placement"), b.Const("bottom-start"));
    }
    /// <summary>
    /// The preferred placement of the tooltip. Note that the actual placement may vary as needed to keep the tooltip inside of the viewport.
    /// </summary>
    public static void SetPlacementBottomend(this PropsBuilder<SlTooltip> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("placement"), b.Const("bottom-end"));
    }
    /// <summary>
    /// The preferred placement of the tooltip. Note that the actual placement may vary as needed to keep the tooltip inside of the viewport.
    /// </summary>
    public static void SetPlacementLeft(this PropsBuilder<SlTooltip> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("placement"), b.Const("left"));
    }
    /// <summary>
    /// The preferred placement of the tooltip. Note that the actual placement may vary as needed to keep the tooltip inside of the viewport.
    /// </summary>
    public static void SetPlacementLeftstart(this PropsBuilder<SlTooltip> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("placement"), b.Const("left-start"));
    }
    /// <summary>
    /// The preferred placement of the tooltip. Note that the actual placement may vary as needed to keep the tooltip inside of the viewport.
    /// </summary>
    public static void SetPlacementLeftend(this PropsBuilder<SlTooltip> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("placement"), b.Const("left-end"));
    }
    /// <summary>
    /// Disables the tooltip so it won't show when triggered.
    /// </summary>
    public static void SetDisabled(this PropsBuilder<SlTooltip> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("disabled"), b.Const(true));
    }
    /// <summary>
    /// The distance in pixels from which to offset the tooltip away from its target.
    /// </summary>
    public static void SetDistance(this PropsBuilder<SlTooltip> b, Var<int> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("distance"), value);
    }
    /// <summary>
    /// The distance in pixels from which to offset the tooltip away from its target.
    /// </summary>
    public static void SetDistance(this PropsBuilder<SlTooltip> b, int value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("distance"), b.Const(value));
    }
    /// <summary>
    /// Indicates whether or not the tooltip is open. You can use this in lieu of the show/hide methods.
    /// </summary>
    public static void SetOpen(this PropsBuilder<SlTooltip> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("open"), b.Const(true));
    }
    /// <summary>
    /// The distance in pixels from which to offset the tooltip along its target.
    /// </summary>
    public static void SetSkidding(this PropsBuilder<SlTooltip> b, Var<int> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("skidding"), value);
    }
    /// <summary>
    /// The distance in pixels from which to offset the tooltip along its target.
    /// </summary>
    public static void SetSkidding(this PropsBuilder<SlTooltip> b, int value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("skidding"), b.Const(value));
    }
    /// <summary>
    /// Controls how the tooltip is activated. Possible options include `click`, `hover`, `focus`, and `manual`. Multiple options can be passed by separating them with a space. When manual is used, the tooltip must be activated programmatically.
    /// </summary>
    public static void SetTrigger(this PropsBuilder<SlTooltip> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("trigger"), value);
    }
    /// <summary>
    /// Controls how the tooltip is activated. Possible options include `click`, `hover`, `focus`, and `manual`. Multiple options can be passed by separating them with a space. When manual is used, the tooltip must be activated programmatically.
    /// </summary>
    public static void SetTrigger(this PropsBuilder<SlTooltip> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("trigger"), b.Const(value));
    }
    /// <summary>
    /// Enable this option to prevent the tooltip from being clipped when the component is placed inside a container with `overflow: auto|hidden|scroll`. Hoisting uses a fixed positioning strategy that works in many, but not all, scenarios.
    /// </summary>
    public static void SetHoist(this PropsBuilder<SlTooltip> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("hoist"), b.Const(true));
    }
    /// <summary>
    /// Emitted when the tooltip begins to show.
    /// </summary>
    public static void OnSlShow<TModel>(this PropsBuilder<SlTooltip> b, Var<HyperType.Action<TModel, SlTooltipShowArgs>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlTooltipShowArgs>>("onsl-show"), action);
    }
    /// <summary>
    /// Emitted when the tooltip begins to show.
    /// </summary>
    public static void OnSlShow<TModel>(this PropsBuilder<SlTooltip> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SlTooltipShowArgs>, Var<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlTooltipShowArgs>>("onsl-show"), b.MakeAction(action));
    }
    /// <summary>
    /// Emitted after the tooltip has shown and all animations are complete.
    /// </summary>
    public static void OnSlAfterShow<TModel>(this PropsBuilder<SlTooltip> b, Var<HyperType.Action<TModel, SlTooltipAfterShowArgs>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlTooltipAfterShowArgs>>("onsl-after-show"), action);
    }
    /// <summary>
    /// Emitted after the tooltip has shown and all animations are complete.
    /// </summary>
    public static void OnSlAfterShow<TModel>(this PropsBuilder<SlTooltip> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SlTooltipAfterShowArgs>, Var<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlTooltipAfterShowArgs>>("onsl-after-show"), b.MakeAction(action));
    }
    /// <summary>
    /// Emitted when the tooltip begins to hide.
    /// </summary>
    public static void OnSlHide<TModel>(this PropsBuilder<SlTooltip> b, Var<HyperType.Action<TModel, SlTooltipHideArgs>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlTooltipHideArgs>>("onsl-hide"), action);
    }
    /// <summary>
    /// Emitted when the tooltip begins to hide.
    /// </summary>
    public static void OnSlHide<TModel>(this PropsBuilder<SlTooltip> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SlTooltipHideArgs>, Var<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlTooltipHideArgs>>("onsl-hide"), b.MakeAction(action));
    }
    /// <summary>
    /// Emitted after the tooltip has hidden and all animations are complete.
    /// </summary>
    public static void OnSlAfterHide<TModel>(this PropsBuilder<SlTooltip> b, Var<HyperType.Action<TModel, SlTooltipAfterHideArgs>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlTooltipAfterHideArgs>>("onsl-after-hide"), action);
    }
    /// <summary>
    /// Emitted after the tooltip has hidden and all animations are complete.
    /// </summary>
    public static void OnSlAfterHide<TModel>(this PropsBuilder<SlTooltip> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SlTooltipAfterHideArgs>, Var<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlTooltipAfterHideArgs>>("onsl-after-hide"), b.MakeAction(action));
    }
}

/// <summary>
/// Tooltips display additional information based on a specific action.
/// </summary>
public partial class SlTooltip : HtmlTag
{
    public SlTooltip()
    {
        this.Tag = "sl-tooltip";
    }

    public static SlTooltip New()
    {
        return new SlTooltip();
    }
    public static class Slot
    {
        /// <summary> 
        /// The content to render in the tooltip. Alternatively, you can use the `content` attribute.
        /// </summary>
        public const string Content = "content";
    }
}

public static partial class SlTooltipControl
{
    /// <summary>
    /// The tooltip's content. If you need to display HTML, use the `content` slot instead.
    /// </summary>
    public static SlTooltip SetContent(this SlTooltip tag, string value)
    {
        return tag.SetAttribute("content", value.ToString());
    }
    /// <summary>
    /// The preferred placement of the tooltip. Note that the actual placement may vary as needed to keep the tooltip inside of the viewport.
    /// </summary>
    public static SlTooltip SetPlacementTop(this SlTooltip tag)
    {
        return tag.SetAttribute("placement", "top");
    }
    /// <summary>
    /// The preferred placement of the tooltip. Note that the actual placement may vary as needed to keep the tooltip inside of the viewport.
    /// </summary>
    public static SlTooltip SetPlacementTopstart(this SlTooltip tag)
    {
        return tag.SetAttribute("placement", "top-start");
    }
    /// <summary>
    /// The preferred placement of the tooltip. Note that the actual placement may vary as needed to keep the tooltip inside of the viewport.
    /// </summary>
    public static SlTooltip SetPlacementTopend(this SlTooltip tag)
    {
        return tag.SetAttribute("placement", "top-end");
    }
    /// <summary>
    /// The preferred placement of the tooltip. Note that the actual placement may vary as needed to keep the tooltip inside of the viewport.
    /// </summary>
    public static SlTooltip SetPlacementRight(this SlTooltip tag)
    {
        return tag.SetAttribute("placement", "right");
    }
    /// <summary>
    /// The preferred placement of the tooltip. Note that the actual placement may vary as needed to keep the tooltip inside of the viewport.
    /// </summary>
    public static SlTooltip SetPlacementRightstart(this SlTooltip tag)
    {
        return tag.SetAttribute("placement", "right-start");
    }
    /// <summary>
    /// The preferred placement of the tooltip. Note that the actual placement may vary as needed to keep the tooltip inside of the viewport.
    /// </summary>
    public static SlTooltip SetPlacementRightend(this SlTooltip tag)
    {
        return tag.SetAttribute("placement", "right-end");
    }
    /// <summary>
    /// The preferred placement of the tooltip. Note that the actual placement may vary as needed to keep the tooltip inside of the viewport.
    /// </summary>
    public static SlTooltip SetPlacementBottom(this SlTooltip tag)
    {
        return tag.SetAttribute("placement", "bottom");
    }
    /// <summary>
    /// The preferred placement of the tooltip. Note that the actual placement may vary as needed to keep the tooltip inside of the viewport.
    /// </summary>
    public static SlTooltip SetPlacementBottomstart(this SlTooltip tag)
    {
        return tag.SetAttribute("placement", "bottom-start");
    }
    /// <summary>
    /// The preferred placement of the tooltip. Note that the actual placement may vary as needed to keep the tooltip inside of the viewport.
    /// </summary>
    public static SlTooltip SetPlacementBottomend(this SlTooltip tag)
    {
        return tag.SetAttribute("placement", "bottom-end");
    }
    /// <summary>
    /// The preferred placement of the tooltip. Note that the actual placement may vary as needed to keep the tooltip inside of the viewport.
    /// </summary>
    public static SlTooltip SetPlacementLeft(this SlTooltip tag)
    {
        return tag.SetAttribute("placement", "left");
    }
    /// <summary>
    /// The preferred placement of the tooltip. Note that the actual placement may vary as needed to keep the tooltip inside of the viewport.
    /// </summary>
    public static SlTooltip SetPlacementLeftstart(this SlTooltip tag)
    {
        return tag.SetAttribute("placement", "left-start");
    }
    /// <summary>
    /// The preferred placement of the tooltip. Note that the actual placement may vary as needed to keep the tooltip inside of the viewport.
    /// </summary>
    public static SlTooltip SetPlacementLeftend(this SlTooltip tag)
    {
        return tag.SetAttribute("placement", "left-end");
    }
    /// <summary>
    /// Disables the tooltip so it won't show when triggered.
    /// </summary>
    public static SlTooltip SetDisabled(this SlTooltip tag)
    {
        return tag.SetAttribute("disabled", "true");
    }
    /// <summary>
    /// The distance in pixels from which to offset the tooltip away from its target.
    /// </summary>
    public static SlTooltip SetDistance(this SlTooltip tag, int value)
    {
        return tag.SetAttribute("distance", value.ToString());
    }
    /// <summary>
    /// Indicates whether or not the tooltip is open. You can use this in lieu of the show/hide methods.
    /// </summary>
    public static SlTooltip SetOpen(this SlTooltip tag)
    {
        return tag.SetAttribute("open", "true");
    }
    /// <summary>
    /// The distance in pixels from which to offset the tooltip along its target.
    /// </summary>
    public static SlTooltip SetSkidding(this SlTooltip tag, int value)
    {
        return tag.SetAttribute("skidding", value.ToString());
    }
    /// <summary>
    /// Controls how the tooltip is activated. Possible options include `click`, `hover`, `focus`, and `manual`. Multiple options can be passed by separating them with a space. When manual is used, the tooltip must be activated programmatically.
    /// </summary>
    public static SlTooltip SetTrigger(this SlTooltip tag, string value)
    {
        return tag.SetAttribute("trigger", value.ToString());
    }
    /// <summary>
    /// Enable this option to prevent the tooltip from being clipped when the component is placed inside a container with `overflow: auto|hidden|scroll`. Hoisting uses a fixed positioning strategy that works in many, but not all, scenarios.
    /// </summary>
    public static SlTooltip SetHoist(this SlTooltip tag)
    {
        return tag.SetAttribute("hoist", "true");
    }
}

