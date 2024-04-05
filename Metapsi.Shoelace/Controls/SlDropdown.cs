using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Shoelace;


public partial class SlDropdown : SlComponent
{
    public SlDropdown() : base("sl-dropdown") { }
    /// <summary>
    /// Indicates whether or not the dropdown is open. You can toggle this attribute to show and hide the dropdown, or you can use the `show()` and `hide()` methods and this attribute will reflect the dropdown's open state.
    /// </summary>
    public bool open
    {
        get
        {
            return this.GetTag().GetAttribute<bool>("open");
        }
        set
        {
            if (!value) return;
            this.GetTag().SetAttribute("open", value.ToString());
        }
    }

    /// <summary>
    /// The preferred placement of the dropdown panel. Note that the actual placement may vary as needed to keep the panel inside of the viewport.
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
    /// Disables the dropdown so the panel will not open.
    /// </summary>
    public bool disabled
    {
        get
        {
            return this.GetTag().GetAttribute<bool>("disabled");
        }
        set
        {
            if (!value) return;
            this.GetTag().SetAttribute("disabled", value.ToString());
        }
    }

    /// <summary>
    /// By default, the dropdown is closed when an item is selected. This attribute will keep it open instead. Useful for dropdowns that allow for multiple interactions.
    /// </summary>
    public bool stayOpenOnSelect
    {
        get
        {
            return this.GetTag().GetAttribute<bool>("stayOpenOnSelect");
        }
        set
        {
            if (!value) return;
            this.GetTag().SetAttribute("stayOpenOnSelect", value.ToString());
        }
    }

    /// <summary>
    /// The dropdown will close when the user interacts outside of this element (e.g. clicking). Useful for composing other components that use a dropdown internally.
    /// </summary>
    public object containingElement
    {
        get
        {
            return this.GetTag().GetAttribute<object>("containingElement");
        }
        set
        {
            this.GetTag().SetAttribute("containingElement", value.ToString());
        }
    }

    /// <summary>
    /// The distance in pixels from which to offset the panel away from its trigger.
    /// </summary>
    public int distance
    {
        get
        {
            return this.GetTag().GetAttribute<int>("distance");
        }
        set
        {
            this.GetTag().SetAttribute("distance", value.ToString());
        }
    }

    /// <summary>
    /// The distance in pixels from which to offset the panel along its trigger.
    /// </summary>
    public int skidding
    {
        get
        {
            return this.GetTag().GetAttribute<int>("skidding");
        }
        set
        {
            this.GetTag().SetAttribute("skidding", value.ToString());
        }
    }

    /// <summary>
    /// Enable this option to prevent the panel from being clipped when the component is placed inside a container with `overflow: auto|scroll`. Hoisting uses a fixed positioning strategy that works in many, but not all, scenarios.
    /// </summary>
    public bool hoist
    {
        get
        {
            return this.GetTag().GetAttribute<bool>("hoist");
        }
        set
        {
            if (!value) return;
            this.GetTag().SetAttribute("hoist", value.ToString());
        }
    }

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
    public static void SetContainingElement(this PropsBuilder<SlDropdown> b, Var<object> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<object>("containingElement"), value);
    }
    /// <summary>
    /// The dropdown will close when the user interacts outside of this element (e.g. clicking). Useful for composing other components that use a dropdown internally.
    /// </summary>
    public static void SetContainingElement(this PropsBuilder<SlDropdown> b, object value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<object>("containingElement"), b.Const(value));
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
    public static void OnSlShow<TModel>(this PropsBuilder<SlDropdown> b, Var<HyperType.Action<TModel, DomEvent>> action)
    {
        b.OnEventAction("onsl-show", action);
    }
    /// <summary>
    /// Emitted when the dropdown opens.
    /// </summary>
    public static void OnSlShow<TModel>(this PropsBuilder<SlDropdown> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-show", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the dropdown opens.
    /// </summary>
    public static void OnSlShow<TModel>(this PropsBuilder<SlDropdown> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onsl-show", action);
    }
    /// <summary>
    /// Emitted when the dropdown opens.
    /// </summary>
    public static void OnSlShow<TModel>(this PropsBuilder<SlDropdown> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-show", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the dropdown opens and all animations are complete.
    /// </summary>
    public static void OnSlAfterShow<TModel>(this PropsBuilder<SlDropdown> b, Var<HyperType.Action<TModel, DomEvent>> action)
    {
        b.OnEventAction("onsl-after-show", action);
    }
    /// <summary>
    /// Emitted after the dropdown opens and all animations are complete.
    /// </summary>
    public static void OnSlAfterShow<TModel>(this PropsBuilder<SlDropdown> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-after-show", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the dropdown opens and all animations are complete.
    /// </summary>
    public static void OnSlAfterShow<TModel>(this PropsBuilder<SlDropdown> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onsl-after-show", action);
    }
    /// <summary>
    /// Emitted after the dropdown opens and all animations are complete.
    /// </summary>
    public static void OnSlAfterShow<TModel>(this PropsBuilder<SlDropdown> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-after-show", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the dropdown closes.
    /// </summary>
    public static void OnSlHide<TModel>(this PropsBuilder<SlDropdown> b, Var<HyperType.Action<TModel, DomEvent>> action)
    {
        b.OnEventAction("onsl-hide", action);
    }
    /// <summary>
    /// Emitted when the dropdown closes.
    /// </summary>
    public static void OnSlHide<TModel>(this PropsBuilder<SlDropdown> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-hide", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the dropdown closes.
    /// </summary>
    public static void OnSlHide<TModel>(this PropsBuilder<SlDropdown> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onsl-hide", action);
    }
    /// <summary>
    /// Emitted when the dropdown closes.
    /// </summary>
    public static void OnSlHide<TModel>(this PropsBuilder<SlDropdown> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-hide", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the dropdown closes and all animations are complete.
    /// </summary>
    public static void OnSlAfterHide<TModel>(this PropsBuilder<SlDropdown> b, Var<HyperType.Action<TModel, DomEvent>> action)
    {
        b.OnEventAction("onsl-after-hide", action);
    }
    /// <summary>
    /// Emitted after the dropdown closes and all animations are complete.
    /// </summary>
    public static void OnSlAfterHide<TModel>(this PropsBuilder<SlDropdown> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-after-hide", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the dropdown closes and all animations are complete.
    /// </summary>
    public static void OnSlAfterHide<TModel>(this PropsBuilder<SlDropdown> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onsl-after-hide", action);
    }
    /// <summary>
    /// Emitted after the dropdown closes and all animations are complete.
    /// </summary>
    public static void OnSlAfterHide<TModel>(this PropsBuilder<SlDropdown> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-after-hide", b.MakeAction(action));
    }

}

