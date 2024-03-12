using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Shoelace;


public partial class SlTabGroup
{
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
    public static void OnSlTabShow<TModel>(this PropsBuilder<SlTabGroup> b, Var<HyperType.Action<TModel, object>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<object>("detail"));
            return b.MakeActionDescriptor<TModel, object>(action, value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onsl-tab-show"), eventAction);
    }
    /// <summary>
    /// Emitted when a tab is shown.
    /// </summary>
    public static void OnSlTabShow<TModel>(this PropsBuilder<SlTabGroup> b, System.Func<SyntaxBuilder, Var<TModel>, Var<object>, Var<TModel>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<object>("detail"));
            return b.MakeActionDescriptor<TModel, object>(b.MakeAction(action), value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onsl-tab-show"), eventAction);
    }

    /// <summary>
    /// Emitted when a tab is hidden.
    /// </summary>
    public static void OnSlTabHide<TModel>(this PropsBuilder<SlTabGroup> b, Var<HyperType.Action<TModel, object>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<object>("detail"));
            return b.MakeActionDescriptor<TModel, object>(action, value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onsl-tab-hide"), eventAction);
    }
    /// <summary>
    /// Emitted when a tab is hidden.
    /// </summary>
    public static void OnSlTabHide<TModel>(this PropsBuilder<SlTabGroup> b, System.Func<SyntaxBuilder, Var<TModel>, Var<object>, Var<TModel>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<object>("detail"));
            return b.MakeActionDescriptor<TModel, object>(b.MakeAction(action), value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onsl-tab-hide"), eventAction);
    }

}

