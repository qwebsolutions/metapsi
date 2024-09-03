using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Shoelace;


public partial class SlDropdown
{
    /// <summary>
    ///
    /// </summary>
    public static class Slot
    {
        /// <summary>
        /// <para> The dropdown's trigger, usually a `&lt;sl-button&gt;` element. </para>
        /// </summary>
        public const string Trigger = "trigger";
    }
    public static class Method
    {
        /// <summary>
        /// <para> Shows the dropdown panel. </para>
        /// </summary>
        public const string Show = "show";
        /// <summary>
        /// <para> Hides the dropdown panel </para>
        /// </summary>
        public const string Hide = "hide";
        /// <summary>
        /// <para> Instructs the dropdown menu to reposition. Useful when the position or size of the trigger changes when the menu is activated. </para>
        /// </summary>
        public const string Reposition = "reposition";
    }
}

public static partial class SlDropdownControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlDropdown(this HtmlBuilder b, Action<AttributesBuilder<SlDropdown>> buildAttributes, params IHtmlNode[] children)
    {
        return b.SlTag("sl-dropdown", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlDropdown(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.SlTag("sl-dropdown", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlDropdown(this HtmlBuilder b, Action<AttributesBuilder<SlDropdown>> buildAttributes, List<IHtmlNode> children)
    {
        return b.SlTag("sl-dropdown", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlDropdown(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.SlTag("sl-dropdown", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> Indicates whether or not the dropdown is open. You can toggle this attribute to show and hide the dropdown, or you can use the `show()` and `hide()` methods and this attribute will reflect the dropdown's open state. </para>
    /// </summary>
    public static void SetOpen(this AttributesBuilder<SlDropdown> b)
    {
        b.SetAttribute("open", "");
    }

    /// <summary>
    /// <para> Indicates whether or not the dropdown is open. You can toggle this attribute to show and hide the dropdown, or you can use the `show()` and `hide()` methods and this attribute will reflect the dropdown's open state. </para>
    /// </summary>
    public static void SetOpen(this AttributesBuilder<SlDropdown> b, bool open)
    {
        if (open) b.SetAttribute("open", "");
    }

    /// <summary>
    /// <para> The preferred placement of the dropdown panel. Note that the actual placement may vary as needed to keep the panel inside of the viewport. </para>
    /// </summary>
    public static void SetPlacement(this AttributesBuilder<SlDropdown> b, string placement)
    {
        b.SetAttribute("placement", placement);
    }

    /// <summary>
    /// <para> The preferred placement of the dropdown panel. Note that the actual placement may vary as needed to keep the panel inside of the viewport. </para>
    /// </summary>
    public static void SetPlacementTop(this AttributesBuilder<SlDropdown> b)
    {
        b.SetAttribute("placement", "top");
    }

    /// <summary>
    /// <para> The preferred placement of the dropdown panel. Note that the actual placement may vary as needed to keep the panel inside of the viewport. </para>
    /// </summary>
    public static void SetPlacementTopStart(this AttributesBuilder<SlDropdown> b)
    {
        b.SetAttribute("placement", "top-start");
    }

    /// <summary>
    /// <para> The preferred placement of the dropdown panel. Note that the actual placement may vary as needed to keep the panel inside of the viewport. </para>
    /// </summary>
    public static void SetPlacementTopEnd(this AttributesBuilder<SlDropdown> b)
    {
        b.SetAttribute("placement", "top-end");
    }

    /// <summary>
    /// <para> The preferred placement of the dropdown panel. Note that the actual placement may vary as needed to keep the panel inside of the viewport. </para>
    /// </summary>
    public static void SetPlacementBottom(this AttributesBuilder<SlDropdown> b)
    {
        b.SetAttribute("placement", "bottom");
    }

    /// <summary>
    /// <para> The preferred placement of the dropdown panel. Note that the actual placement may vary as needed to keep the panel inside of the viewport. </para>
    /// </summary>
    public static void SetPlacementBottomStart(this AttributesBuilder<SlDropdown> b)
    {
        b.SetAttribute("placement", "bottom-start");
    }

    /// <summary>
    /// <para> The preferred placement of the dropdown panel. Note that the actual placement may vary as needed to keep the panel inside of the viewport. </para>
    /// </summary>
    public static void SetPlacementBottomEnd(this AttributesBuilder<SlDropdown> b)
    {
        b.SetAttribute("placement", "bottom-end");
    }

    /// <summary>
    /// <para> The preferred placement of the dropdown panel. Note that the actual placement may vary as needed to keep the panel inside of the viewport. </para>
    /// </summary>
    public static void SetPlacementRight(this AttributesBuilder<SlDropdown> b)
    {
        b.SetAttribute("placement", "right");
    }

    /// <summary>
    /// <para> The preferred placement of the dropdown panel. Note that the actual placement may vary as needed to keep the panel inside of the viewport. </para>
    /// </summary>
    public static void SetPlacementRightStart(this AttributesBuilder<SlDropdown> b)
    {
        b.SetAttribute("placement", "right-start");
    }

    /// <summary>
    /// <para> The preferred placement of the dropdown panel. Note that the actual placement may vary as needed to keep the panel inside of the viewport. </para>
    /// </summary>
    public static void SetPlacementRightEnd(this AttributesBuilder<SlDropdown> b)
    {
        b.SetAttribute("placement", "right-end");
    }

    /// <summary>
    /// <para> The preferred placement of the dropdown panel. Note that the actual placement may vary as needed to keep the panel inside of the viewport. </para>
    /// </summary>
    public static void SetPlacementLeft(this AttributesBuilder<SlDropdown> b)
    {
        b.SetAttribute("placement", "left");
    }

    /// <summary>
    /// <para> The preferred placement of the dropdown panel. Note that the actual placement may vary as needed to keep the panel inside of the viewport. </para>
    /// </summary>
    public static void SetPlacementLeftStart(this AttributesBuilder<SlDropdown> b)
    {
        b.SetAttribute("placement", "left-start");
    }

    /// <summary>
    /// <para> The preferred placement of the dropdown panel. Note that the actual placement may vary as needed to keep the panel inside of the viewport. </para>
    /// </summary>
    public static void SetPlacementLeftEnd(this AttributesBuilder<SlDropdown> b)
    {
        b.SetAttribute("placement", "left-end");
    }

    /// <summary>
    /// <para> Disables the dropdown so the panel will not open. </para>
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<SlDropdown> b)
    {
        b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// <para> Disables the dropdown so the panel will not open. </para>
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<SlDropdown> b, bool disabled)
    {
        if (disabled) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// <para> By default, the dropdown is closed when an item is selected. This attribute will keep it open instead. Useful for dropdowns that allow for multiple interactions. </para>
    /// </summary>
    public static void SetStayOpenOnSelect(this AttributesBuilder<SlDropdown> b)
    {
        b.SetAttribute("stay-open-on-select", "");
    }

    /// <summary>
    /// <para> By default, the dropdown is closed when an item is selected. This attribute will keep it open instead. Useful for dropdowns that allow for multiple interactions. </para>
    /// </summary>
    public static void SetStayOpenOnSelect(this AttributesBuilder<SlDropdown> b, bool stayOpenOnSelect)
    {
        if (stayOpenOnSelect) b.SetAttribute("stay-open-on-select", "");
    }

    /// <summary>
    /// <para> The distance in pixels from which to offset the panel away from its trigger. </para>
    /// </summary>
    public static void SetDistance(this AttributesBuilder<SlDropdown> b, string distance)
    {
        b.SetAttribute("distance", distance);
    }

    /// <summary>
    /// <para> The distance in pixels from which to offset the panel along its trigger. </para>
    /// </summary>
    public static void SetSkidding(this AttributesBuilder<SlDropdown> b, string skidding)
    {
        b.SetAttribute("skidding", skidding);
    }

    /// <summary>
    /// <para> Enable this option to prevent the panel from being clipped when the component is placed inside a container with `overflow: auto|scroll`. Hoisting uses a fixed positioning strategy that works in many, but not all, scenarios. </para>
    /// </summary>
    public static void SetHoist(this AttributesBuilder<SlDropdown> b)
    {
        b.SetAttribute("hoist", "");
    }

    /// <summary>
    /// <para> Enable this option to prevent the panel from being clipped when the component is placed inside a container with `overflow: auto|scroll`. Hoisting uses a fixed positioning strategy that works in many, but not all, scenarios. </para>
    /// </summary>
    public static void SetHoist(this AttributesBuilder<SlDropdown> b, bool hoist)
    {
        if (hoist) b.SetAttribute("hoist", "");
    }

    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlDropdown(this LayoutBuilder b, Action<PropsBuilder<SlDropdown>> buildProps, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-dropdown", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlDropdown(this LayoutBuilder b, Action<PropsBuilder<SlDropdown>> buildProps, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-dropdown", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlDropdown(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-dropdown", children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlDropdown(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-dropdown", children);
    }
    /// <summary>
    /// <para> Indicates whether or not the dropdown is open. You can toggle this attribute to show and hide the dropdown, or you can use the `show()` and `hide()` methods and this attribute will reflect the dropdown's open state. </para>
    /// </summary>
    public static void SetOpen<T>(this PropsBuilder<T> b) where T: SlDropdown
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("open"), b.Const(true));
    }


    /// <summary>
    /// <para> Indicates whether or not the dropdown is open. You can toggle this attribute to show and hide the dropdown, or you can use the `show()` and `hide()` methods and this attribute will reflect the dropdown's open state. </para>
    /// </summary>
    public static void SetOpen<T>(this PropsBuilder<T> b, Var<bool> open) where T: SlDropdown
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("open"), open);
    }

    /// <summary>
    /// <para> Indicates whether or not the dropdown is open. You can toggle this attribute to show and hide the dropdown, or you can use the `show()` and `hide()` methods and this attribute will reflect the dropdown's open state. </para>
    /// </summary>
    public static void SetOpen<T>(this PropsBuilder<T> b, bool open) where T: SlDropdown
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("open"), b.Const(open));
    }


    /// <summary>
    /// <para> The preferred placement of the dropdown panel. Note that the actual placement may vary as needed to keep the panel inside of the viewport. </para>
    /// </summary>
    public static void SetPlacementTop<T>(this PropsBuilder<T> b) where T: SlDropdown
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("placement"), b.Const("top"));
    }


    /// <summary>
    /// <para> The preferred placement of the dropdown panel. Note that the actual placement may vary as needed to keep the panel inside of the viewport. </para>
    /// </summary>
    public static void SetPlacementTopStart<T>(this PropsBuilder<T> b) where T: SlDropdown
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("placement"), b.Const("top-start"));
    }


    /// <summary>
    /// <para> The preferred placement of the dropdown panel. Note that the actual placement may vary as needed to keep the panel inside of the viewport. </para>
    /// </summary>
    public static void SetPlacementTopEnd<T>(this PropsBuilder<T> b) where T: SlDropdown
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("placement"), b.Const("top-end"));
    }


    /// <summary>
    /// <para> The preferred placement of the dropdown panel. Note that the actual placement may vary as needed to keep the panel inside of the viewport. </para>
    /// </summary>
    public static void SetPlacementBottom<T>(this PropsBuilder<T> b) where T: SlDropdown
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("placement"), b.Const("bottom"));
    }


    /// <summary>
    /// <para> The preferred placement of the dropdown panel. Note that the actual placement may vary as needed to keep the panel inside of the viewport. </para>
    /// </summary>
    public static void SetPlacementBottomStart<T>(this PropsBuilder<T> b) where T: SlDropdown
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("placement"), b.Const("bottom-start"));
    }


    /// <summary>
    /// <para> The preferred placement of the dropdown panel. Note that the actual placement may vary as needed to keep the panel inside of the viewport. </para>
    /// </summary>
    public static void SetPlacementBottomEnd<T>(this PropsBuilder<T> b) where T: SlDropdown
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("placement"), b.Const("bottom-end"));
    }


    /// <summary>
    /// <para> The preferred placement of the dropdown panel. Note that the actual placement may vary as needed to keep the panel inside of the viewport. </para>
    /// </summary>
    public static void SetPlacementRight<T>(this PropsBuilder<T> b) where T: SlDropdown
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("placement"), b.Const("right"));
    }


    /// <summary>
    /// <para> The preferred placement of the dropdown panel. Note that the actual placement may vary as needed to keep the panel inside of the viewport. </para>
    /// </summary>
    public static void SetPlacementRightStart<T>(this PropsBuilder<T> b) where T: SlDropdown
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("placement"), b.Const("right-start"));
    }


    /// <summary>
    /// <para> The preferred placement of the dropdown panel. Note that the actual placement may vary as needed to keep the panel inside of the viewport. </para>
    /// </summary>
    public static void SetPlacementRightEnd<T>(this PropsBuilder<T> b) where T: SlDropdown
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("placement"), b.Const("right-end"));
    }


    /// <summary>
    /// <para> The preferred placement of the dropdown panel. Note that the actual placement may vary as needed to keep the panel inside of the viewport. </para>
    /// </summary>
    public static void SetPlacementLeft<T>(this PropsBuilder<T> b) where T: SlDropdown
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("placement"), b.Const("left"));
    }


    /// <summary>
    /// <para> The preferred placement of the dropdown panel. Note that the actual placement may vary as needed to keep the panel inside of the viewport. </para>
    /// </summary>
    public static void SetPlacementLeftStart<T>(this PropsBuilder<T> b) where T: SlDropdown
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("placement"), b.Const("left-start"));
    }


    /// <summary>
    /// <para> The preferred placement of the dropdown panel. Note that the actual placement may vary as needed to keep the panel inside of the viewport. </para>
    /// </summary>
    public static void SetPlacementLeftEnd<T>(this PropsBuilder<T> b) where T: SlDropdown
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("placement"), b.Const("left-end"));
    }


    /// <summary>
    /// <para> Disables the dropdown so the panel will not open. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b) where T: SlDropdown
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), b.Const(true));
    }


    /// <summary>
    /// <para> Disables the dropdown so the panel will not open. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, Var<bool> disabled) where T: SlDropdown
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), disabled);
    }

    /// <summary>
    /// <para> Disables the dropdown so the panel will not open. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, bool disabled) where T: SlDropdown
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), b.Const(disabled));
    }


    /// <summary>
    /// <para> By default, the dropdown is closed when an item is selected. This attribute will keep it open instead. Useful for dropdowns that allow for multiple interactions. </para>
    /// </summary>
    public static void SetStayOpenOnSelect<T>(this PropsBuilder<T> b) where T: SlDropdown
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("stayOpenOnSelect"), b.Const(true));
    }


    /// <summary>
    /// <para> By default, the dropdown is closed when an item is selected. This attribute will keep it open instead. Useful for dropdowns that allow for multiple interactions. </para>
    /// </summary>
    public static void SetStayOpenOnSelect<T>(this PropsBuilder<T> b, Var<bool> stayOpenOnSelect) where T: SlDropdown
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("stayOpenOnSelect"), stayOpenOnSelect);
    }

    /// <summary>
    /// <para> By default, the dropdown is closed when an item is selected. This attribute will keep it open instead. Useful for dropdowns that allow for multiple interactions. </para>
    /// </summary>
    public static void SetStayOpenOnSelect<T>(this PropsBuilder<T> b, bool stayOpenOnSelect) where T: SlDropdown
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("stayOpenOnSelect"), b.Const(stayOpenOnSelect));
    }


    /// <summary>
    /// <para> The dropdown will close when the user interacts outside of this element (e.g. clicking). Useful for composing other components that use a dropdown internally. </para>
    /// </summary>
    public static void SetContainingElement<T>(this PropsBuilder<T> b, Var<object> containingElement) where T: SlDropdown
    {
        b.SetDynamic(b.Props, new DynamicProperty<object>("containingElement"), containingElement);
    }

    /// <summary>
    /// <para> The dropdown will close when the user interacts outside of this element (e.g. clicking). Useful for composing other components that use a dropdown internally. </para>
    /// </summary>
    public static void SetContainingElement<T>(this PropsBuilder<T> b, object containingElement) where T: SlDropdown
    {
        b.SetDynamic(b.Props, new DynamicProperty<object>("containingElement"), b.Const(containingElement));
    }


    /// <summary>
    /// <para> The distance in pixels from which to offset the panel away from its trigger. </para>
    /// </summary>
    public static void SetDistance<T>(this PropsBuilder<T> b, Var<int> distance) where T: SlDropdown
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("distance"), distance);
    }

    /// <summary>
    /// <para> The distance in pixels from which to offset the panel away from its trigger. </para>
    /// </summary>
    public static void SetDistance<T>(this PropsBuilder<T> b, int distance) where T: SlDropdown
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("distance"), b.Const(distance));
    }


    /// <summary>
    /// <para> The distance in pixels from which to offset the panel along its trigger. </para>
    /// </summary>
    public static void SetSkidding<T>(this PropsBuilder<T> b, Var<int> skidding) where T: SlDropdown
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("skidding"), skidding);
    }

    /// <summary>
    /// <para> The distance in pixels from which to offset the panel along its trigger. </para>
    /// </summary>
    public static void SetSkidding<T>(this PropsBuilder<T> b, int skidding) where T: SlDropdown
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("skidding"), b.Const(skidding));
    }


    /// <summary>
    /// <para> Enable this option to prevent the panel from being clipped when the component is placed inside a container with `overflow: auto|scroll`. Hoisting uses a fixed positioning strategy that works in many, but not all, scenarios. </para>
    /// </summary>
    public static void SetHoist<T>(this PropsBuilder<T> b) where T: SlDropdown
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("hoist"), b.Const(true));
    }


    /// <summary>
    /// <para> Enable this option to prevent the panel from being clipped when the component is placed inside a container with `overflow: auto|scroll`. Hoisting uses a fixed positioning strategy that works in many, but not all, scenarios. </para>
    /// </summary>
    public static void SetHoist<T>(this PropsBuilder<T> b, Var<bool> hoist) where T: SlDropdown
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("hoist"), hoist);
    }

    /// <summary>
    /// <para> Enable this option to prevent the panel from being clipped when the component is placed inside a container with `overflow: auto|scroll`. Hoisting uses a fixed positioning strategy that works in many, but not all, scenarios. </para>
    /// </summary>
    public static void SetHoist<T>(this PropsBuilder<T> b, bool hoist) where T: SlDropdown
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("hoist"), b.Const(hoist));
    }


    /// <summary>
    /// <para> Emitted when the dropdown opens. </para>
    /// </summary>
    public static void OnSlShow<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, DomEvent>> action) where TComponent: SlDropdown
    {
        b.OnEventAction("onsl-show", action);
    }
    /// <summary>
    /// <para> Emitted when the dropdown opens. </para>
    /// </summary>
    public static void OnSlShow<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action) where TComponent: SlDropdown
    {
        b.OnEventAction("onsl-show", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the dropdown opens. </para>
    /// </summary>
    public static void OnSlShow<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: SlDropdown
    {
        b.OnEventAction("onsl-show", action);
    }
    /// <summary>
    /// <para> Emitted when the dropdown opens. </para>
    /// </summary>
    public static void OnSlShow<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: SlDropdown
    {
        b.OnEventAction("onsl-show", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted after the dropdown opens and all animations are complete. </para>
    /// </summary>
    public static void OnSlAfterShow<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, DomEvent>> action) where TComponent: SlDropdown
    {
        b.OnEventAction("onsl-after-show", action);
    }
    /// <summary>
    /// <para> Emitted after the dropdown opens and all animations are complete. </para>
    /// </summary>
    public static void OnSlAfterShow<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action) where TComponent: SlDropdown
    {
        b.OnEventAction("onsl-after-show", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted after the dropdown opens and all animations are complete. </para>
    /// </summary>
    public static void OnSlAfterShow<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: SlDropdown
    {
        b.OnEventAction("onsl-after-show", action);
    }
    /// <summary>
    /// <para> Emitted after the dropdown opens and all animations are complete. </para>
    /// </summary>
    public static void OnSlAfterShow<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: SlDropdown
    {
        b.OnEventAction("onsl-after-show", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the dropdown closes. </para>
    /// </summary>
    public static void OnSlHide<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, DomEvent>> action) where TComponent: SlDropdown
    {
        b.OnEventAction("onsl-hide", action);
    }
    /// <summary>
    /// <para> Emitted when the dropdown closes. </para>
    /// </summary>
    public static void OnSlHide<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action) where TComponent: SlDropdown
    {
        b.OnEventAction("onsl-hide", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the dropdown closes. </para>
    /// </summary>
    public static void OnSlHide<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: SlDropdown
    {
        b.OnEventAction("onsl-hide", action);
    }
    /// <summary>
    /// <para> Emitted when the dropdown closes. </para>
    /// </summary>
    public static void OnSlHide<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: SlDropdown
    {
        b.OnEventAction("onsl-hide", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted after the dropdown closes and all animations are complete. </para>
    /// </summary>
    public static void OnSlAfterHide<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, DomEvent>> action) where TComponent: SlDropdown
    {
        b.OnEventAction("onsl-after-hide", action);
    }
    /// <summary>
    /// <para> Emitted after the dropdown closes and all animations are complete. </para>
    /// </summary>
    public static void OnSlAfterHide<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action) where TComponent: SlDropdown
    {
        b.OnEventAction("onsl-after-hide", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted after the dropdown closes and all animations are complete. </para>
    /// </summary>
    public static void OnSlAfterHide<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: SlDropdown
    {
        b.OnEventAction("onsl-after-hide", action);
    }
    /// <summary>
    /// <para> Emitted after the dropdown closes and all animations are complete. </para>
    /// </summary>
    public static void OnSlAfterHide<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: SlDropdown
    {
        b.OnEventAction("onsl-after-hide", b.MakeAction(action));
    }

}

