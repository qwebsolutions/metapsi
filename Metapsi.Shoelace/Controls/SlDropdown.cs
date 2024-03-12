using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Shoelace;


public partial class SlDropdown
{
    public static class Slot
    {
        /// <summary> 
        /// The dropdown's trigger, usually a `<sl-button>` element.
        /// </summary>
        public const string Trigger = "trigger";
    }
    public static class Method
    {
        /// <summary> 
        /// Shows the dropdown panel.
        /// </summary>
        public const string Show = "show";
        /// <summary> 
        /// Hides the dropdown panel
        /// </summary>
        public const string Hide = "hide";
        /// <summary> 
        /// Instructs the dropdown menu to reposition. Useful when the position or size of the trigger changes when the menu is activated.
        /// </summary>
        public const string Reposition = "reposition";
    }
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
    public static void SetPlacementTopStart(this PropsBuilder<SlDropdown> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("placement"), b.Const("top-start"));
    }
    /// <summary>
    /// The preferred placement of the dropdown panel. Note that the actual placement may vary as needed to keep the panel inside of the viewport.
    /// </summary>
    public static void SetPlacementTopEnd(this PropsBuilder<SlDropdown> b)
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
    public static void SetPlacementBottomStart(this PropsBuilder<SlDropdown> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("placement"), b.Const("bottom-start"));
    }
    /// <summary>
    /// The preferred placement of the dropdown panel. Note that the actual placement may vary as needed to keep the panel inside of the viewport.
    /// </summary>
    public static void SetPlacementBottomEnd(this PropsBuilder<SlDropdown> b)
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
    public static void SetPlacementRightStart(this PropsBuilder<SlDropdown> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("placement"), b.Const("right-start"));
    }
    /// <summary>
    /// The preferred placement of the dropdown panel. Note that the actual placement may vary as needed to keep the panel inside of the viewport.
    /// </summary>
    public static void SetPlacementRightEnd(this PropsBuilder<SlDropdown> b)
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
    public static void SetPlacementLeftStart(this PropsBuilder<SlDropdown> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("placement"), b.Const("left-start"));
    }
    /// <summary>
    /// The preferred placement of the dropdown panel. Note that the actual placement may vary as needed to keep the panel inside of the viewport.
    /// </summary>
    public static void SetPlacementLeftEnd(this PropsBuilder<SlDropdown> b)
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
    /// The dropdown will close when the user interacts outside of this element (e.g. clicking). Useful for composing other components that use a dropdown internally.
    /// </summary>
    public static void SetContainingElement(this PropsBuilder<SlDropdown> b, Var<HTMLElement> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HTMLElement>("containingElement"), value);
    }
    /// <summary>
    /// The dropdown will close when the user interacts outside of this element (e.g. clicking). Useful for composing other components that use a dropdown internally.
    /// </summary>
    public static void SetContainingElement(this PropsBuilder<SlDropdown> b, HTMLElement value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HTMLElement>("containingElement"), b.Const(value));
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
    public static void OnSlShow<TModel>(this PropsBuilder<SlDropdown> b, Var<HyperType.Action<TModel, object>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<object>("detail"));
            return b.MakeActionDescriptor<TModel, object>(action, value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onsl-show"), eventAction);
    }
    /// <summary>
    /// Emitted when the dropdown opens.
    /// </summary>
    public static void OnSlShow<TModel>(this PropsBuilder<SlDropdown> b, System.Func<SyntaxBuilder, Var<TModel>, Var<object>, Var<TModel>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<object>("detail"));
            return b.MakeActionDescriptor<TModel, object>(b.MakeAction(action), value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onsl-show"), eventAction);
    }

    /// <summary>
    /// Emitted after the dropdown opens and all animations are complete.
    /// </summary>
    public static void OnSlAfterShow<TModel>(this PropsBuilder<SlDropdown> b, Var<HyperType.Action<TModel, object>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<object>("detail"));
            return b.MakeActionDescriptor<TModel, object>(action, value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onsl-after-show"), eventAction);
    }
    /// <summary>
    /// Emitted after the dropdown opens and all animations are complete.
    /// </summary>
    public static void OnSlAfterShow<TModel>(this PropsBuilder<SlDropdown> b, System.Func<SyntaxBuilder, Var<TModel>, Var<object>, Var<TModel>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<object>("detail"));
            return b.MakeActionDescriptor<TModel, object>(b.MakeAction(action), value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onsl-after-show"), eventAction);
    }

    /// <summary>
    /// Emitted when the dropdown closes.
    /// </summary>
    public static void OnSlHide<TModel>(this PropsBuilder<SlDropdown> b, Var<HyperType.Action<TModel, object>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<object>("detail"));
            return b.MakeActionDescriptor<TModel, object>(action, value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onsl-hide"), eventAction);
    }
    /// <summary>
    /// Emitted when the dropdown closes.
    /// </summary>
    public static void OnSlHide<TModel>(this PropsBuilder<SlDropdown> b, System.Func<SyntaxBuilder, Var<TModel>, Var<object>, Var<TModel>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<object>("detail"));
            return b.MakeActionDescriptor<TModel, object>(b.MakeAction(action), value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onsl-hide"), eventAction);
    }

    /// <summary>
    /// Emitted after the dropdown closes and all animations are complete.
    /// </summary>
    public static void OnSlAfterHide<TModel>(this PropsBuilder<SlDropdown> b, Var<HyperType.Action<TModel, object>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<object>("detail"));
            return b.MakeActionDescriptor<TModel, object>(action, value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onsl-after-hide"), eventAction);
    }
    /// <summary>
    /// Emitted after the dropdown closes and all animations are complete.
    /// </summary>
    public static void OnSlAfterHide<TModel>(this PropsBuilder<SlDropdown> b, System.Func<SyntaxBuilder, Var<TModel>, Var<object>, Var<TModel>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<object>("detail"));
            return b.MakeActionDescriptor<TModel, object>(b.MakeAction(action), value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onsl-after-hide"), eventAction);
    }

}

