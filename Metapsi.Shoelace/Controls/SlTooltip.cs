using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Shoelace;


public partial class SlTooltip
{
    public static class Slot
    {
        /// <summary> 
        /// The content to render in the tooltip. Alternatively, you can use the `content` attribute.
        /// </summary>
        public const string Content = "content";
    }
    public static class Method
    {
        /// <summary> 
        /// Shows the tooltip.
        /// </summary>
        public const string Show = "show";
        /// <summary> 
        /// Hides the tooltip
        /// </summary>
        public const string Hide = "hide";
    }
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
    public static void SetPlacementTopStart(this PropsBuilder<SlTooltip> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("placement"), b.Const("top-start"));
    }
    /// <summary>
    /// The preferred placement of the tooltip. Note that the actual placement may vary as needed to keep the tooltip inside of the viewport.
    /// </summary>
    public static void SetPlacementTopEnd(this PropsBuilder<SlTooltip> b)
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
    public static void SetPlacementRightStart(this PropsBuilder<SlTooltip> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("placement"), b.Const("right-start"));
    }
    /// <summary>
    /// The preferred placement of the tooltip. Note that the actual placement may vary as needed to keep the tooltip inside of the viewport.
    /// </summary>
    public static void SetPlacementRightEnd(this PropsBuilder<SlTooltip> b)
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
    public static void SetPlacementBottomStart(this PropsBuilder<SlTooltip> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("placement"), b.Const("bottom-start"));
    }
    /// <summary>
    /// The preferred placement of the tooltip. Note that the actual placement may vary as needed to keep the tooltip inside of the viewport.
    /// </summary>
    public static void SetPlacementBottomEnd(this PropsBuilder<SlTooltip> b)
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
    public static void SetPlacementLeftStart(this PropsBuilder<SlTooltip> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("placement"), b.Const("left-start"));
    }
    /// <summary>
    /// The preferred placement of the tooltip. Note that the actual placement may vary as needed to keep the tooltip inside of the viewport.
    /// </summary>
    public static void SetPlacementLeftEnd(this PropsBuilder<SlTooltip> b)
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
    public static void OnSlShow<TModel>(this PropsBuilder<SlTooltip> b, Var<HyperType.Action<TModel, object>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<object>("detail"));
            return b.MakeActionDescriptor<TModel, object>(action, value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onsl-show"), eventAction);
    }
    /// <summary>
    /// Emitted when the tooltip begins to show.
    /// </summary>
    public static void OnSlShow<TModel>(this PropsBuilder<SlTooltip> b, System.Func<SyntaxBuilder, Var<TModel>, Var<object>, Var<TModel>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<object>("detail"));
            return b.MakeActionDescriptor<TModel, object>(b.MakeAction(action), value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onsl-show"), eventAction);
    }

    /// <summary>
    /// Emitted after the tooltip has shown and all animations are complete.
    /// </summary>
    public static void OnSlAfterShow<TModel>(this PropsBuilder<SlTooltip> b, Var<HyperType.Action<TModel, object>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<object>("detail"));
            return b.MakeActionDescriptor<TModel, object>(action, value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onsl-after-show"), eventAction);
    }
    /// <summary>
    /// Emitted after the tooltip has shown and all animations are complete.
    /// </summary>
    public static void OnSlAfterShow<TModel>(this PropsBuilder<SlTooltip> b, System.Func<SyntaxBuilder, Var<TModel>, Var<object>, Var<TModel>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<object>("detail"));
            return b.MakeActionDescriptor<TModel, object>(b.MakeAction(action), value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onsl-after-show"), eventAction);
    }

    /// <summary>
    /// Emitted when the tooltip begins to hide.
    /// </summary>
    public static void OnSlHide<TModel>(this PropsBuilder<SlTooltip> b, Var<HyperType.Action<TModel, object>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<object>("detail"));
            return b.MakeActionDescriptor<TModel, object>(action, value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onsl-hide"), eventAction);
    }
    /// <summary>
    /// Emitted when the tooltip begins to hide.
    /// </summary>
    public static void OnSlHide<TModel>(this PropsBuilder<SlTooltip> b, System.Func<SyntaxBuilder, Var<TModel>, Var<object>, Var<TModel>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<object>("detail"));
            return b.MakeActionDescriptor<TModel, object>(b.MakeAction(action), value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onsl-hide"), eventAction);
    }

    /// <summary>
    /// Emitted after the tooltip has hidden and all animations are complete.
    /// </summary>
    public static void OnSlAfterHide<TModel>(this PropsBuilder<SlTooltip> b, Var<HyperType.Action<TModel, object>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<object>("detail"));
            return b.MakeActionDescriptor<TModel, object>(action, value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onsl-after-hide"), eventAction);
    }
    /// <summary>
    /// Emitted after the tooltip has hidden and all animations are complete.
    /// </summary>
    public static void OnSlAfterHide<TModel>(this PropsBuilder<SlTooltip> b, System.Func<SyntaxBuilder, Var<TModel>, Var<object>, Var<TModel>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<object>("detail"));
            return b.MakeActionDescriptor<TModel, object>(b.MakeAction(action), value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onsl-after-hide"), eventAction);
    }

}

