using Metapsi.Html;
using Metapsi.Syntax;
using Metapsi.Hyperapp;

namespace Metapsi.Shoelace;

/// <summary>
/// Dropdowns expose additional content that "drops down" in a panel.
/// </summary>
public partial class SlDropdown
{
    /// <summary>
    /// 
    /// </summary>
    public static class Slot
    {
        /// <summary>
        /// The dropdown's trigger, usually a `&lt;sl-button&gt;` element.
        /// </summary>
        public const string Trigger = "trigger";
    }
    /// <summary>
    /// 
    /// </summary>
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
/// <summary>
/// Setter extensions of SlDropdown
/// </summary>
public static partial class SlDropdownControl
{
    /// <summary>
    /// Dropdowns expose additional content that "drops down" in a panel.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlDropdown(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlDropdown>> buildAttributes, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-dropdown", buildAttributes, children);
    }

    /// <summary>
    /// Dropdowns expose additional content that "drops down" in a panel.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlDropdown(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-dropdown", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// Dropdowns expose additional content that "drops down" in a panel.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlDropdown(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlDropdown>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-dropdown", buildAttributes, children);
    }

    /// <summary>
    /// Dropdowns expose additional content that "drops down" in a panel.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlDropdown(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-dropdown", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// Indicates whether or not the dropdown is open. You can toggle this attribute to show and hide the dropdown, or you can use the `show()` and `hide()` methods and this attribute will reflect the dropdown's open state.
    /// </summary>
    public static void SetOpen(this Metapsi.Html.AttributesBuilder<SlDropdown> b, bool open) 
    {
        if (open) b.SetAttribute("open", "");
    }

    /// <summary>
    /// Indicates whether or not the dropdown is open. You can toggle this attribute to show and hide the dropdown, or you can use the `show()` and `hide()` methods and this attribute will reflect the dropdown's open state.
    /// </summary>
    public static void SetOpen(this Metapsi.Html.AttributesBuilder<SlDropdown> b) 
    {
        b.SetAttribute("open", "");
    }

    /// <summary>
    /// The preferred placement of the dropdown panel. Note that the actual placement may vary as needed to keep the panel inside of the viewport.
    /// </summary>
    public static void SetPlacementTop(this Metapsi.Html.AttributesBuilder<SlDropdown> b) 
    {
        b.SetAttribute("placement", "top");
    }

    /// <summary>
    /// The preferred placement of the dropdown panel. Note that the actual placement may vary as needed to keep the panel inside of the viewport.
    /// </summary>
    public static void SetPlacementTopStart(this Metapsi.Html.AttributesBuilder<SlDropdown> b) 
    {
        b.SetAttribute("placement", "top-start");
    }

    /// <summary>
    /// The preferred placement of the dropdown panel. Note that the actual placement may vary as needed to keep the panel inside of the viewport.
    /// </summary>
    public static void SetPlacementTopEnd(this Metapsi.Html.AttributesBuilder<SlDropdown> b) 
    {
        b.SetAttribute("placement", "top-end");
    }

    /// <summary>
    /// The preferred placement of the dropdown panel. Note that the actual placement may vary as needed to keep the panel inside of the viewport.
    /// </summary>
    public static void SetPlacementBottom(this Metapsi.Html.AttributesBuilder<SlDropdown> b) 
    {
        b.SetAttribute("placement", "bottom");
    }

    /// <summary>
    /// The preferred placement of the dropdown panel. Note that the actual placement may vary as needed to keep the panel inside of the viewport.
    /// </summary>
    public static void SetPlacementBottomStart(this Metapsi.Html.AttributesBuilder<SlDropdown> b) 
    {
        b.SetAttribute("placement", "bottom-start");
    }

    /// <summary>
    /// The preferred placement of the dropdown panel. Note that the actual placement may vary as needed to keep the panel inside of the viewport.
    /// </summary>
    public static void SetPlacementBottomEnd(this Metapsi.Html.AttributesBuilder<SlDropdown> b) 
    {
        b.SetAttribute("placement", "bottom-end");
    }

    /// <summary>
    /// The preferred placement of the dropdown panel. Note that the actual placement may vary as needed to keep the panel inside of the viewport.
    /// </summary>
    public static void SetPlacementRight(this Metapsi.Html.AttributesBuilder<SlDropdown> b) 
    {
        b.SetAttribute("placement", "right");
    }

    /// <summary>
    /// The preferred placement of the dropdown panel. Note that the actual placement may vary as needed to keep the panel inside of the viewport.
    /// </summary>
    public static void SetPlacementRightStart(this Metapsi.Html.AttributesBuilder<SlDropdown> b) 
    {
        b.SetAttribute("placement", "right-start");
    }

    /// <summary>
    /// The preferred placement of the dropdown panel. Note that the actual placement may vary as needed to keep the panel inside of the viewport.
    /// </summary>
    public static void SetPlacementRightEnd(this Metapsi.Html.AttributesBuilder<SlDropdown> b) 
    {
        b.SetAttribute("placement", "right-end");
    }

    /// <summary>
    /// The preferred placement of the dropdown panel. Note that the actual placement may vary as needed to keep the panel inside of the viewport.
    /// </summary>
    public static void SetPlacementLeft(this Metapsi.Html.AttributesBuilder<SlDropdown> b) 
    {
        b.SetAttribute("placement", "left");
    }

    /// <summary>
    /// The preferred placement of the dropdown panel. Note that the actual placement may vary as needed to keep the panel inside of the viewport.
    /// </summary>
    public static void SetPlacementLeftStart(this Metapsi.Html.AttributesBuilder<SlDropdown> b) 
    {
        b.SetAttribute("placement", "left-start");
    }

    /// <summary>
    /// The preferred placement of the dropdown panel. Note that the actual placement may vary as needed to keep the panel inside of the viewport.
    /// </summary>
    public static void SetPlacementLeftEnd(this Metapsi.Html.AttributesBuilder<SlDropdown> b) 
    {
        b.SetAttribute("placement", "left-end");
    }

    /// <summary>
    /// Disables the dropdown so the panel will not open.
    /// </summary>
    public static void SetDisabled(this Metapsi.Html.AttributesBuilder<SlDropdown> b, bool disabled) 
    {
        if (disabled) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// Disables the dropdown so the panel will not open.
    /// </summary>
    public static void SetDisabled(this Metapsi.Html.AttributesBuilder<SlDropdown> b) 
    {
        b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// By default, the dropdown is closed when an item is selected. This attribute will keep it open instead. Useful for dropdowns that allow for multiple interactions.
    /// </summary>
    public static void SetStayOpenOnSelect(this Metapsi.Html.AttributesBuilder<SlDropdown> b, bool stayOpenOnSelect) 
    {
        if (stayOpenOnSelect) b.SetAttribute("stay-open-on-select", "");
    }

    /// <summary>
    /// By default, the dropdown is closed when an item is selected. This attribute will keep it open instead. Useful for dropdowns that allow for multiple interactions.
    /// </summary>
    public static void SetStayOpenOnSelect(this Metapsi.Html.AttributesBuilder<SlDropdown> b) 
    {
        b.SetAttribute("stay-open-on-select", "");
    }

    /// <summary>
    /// Enable this option to prevent the panel from being clipped when the component is placed inside a container with `overflow: auto|scroll`. Hoisting uses a fixed positioning strategy that works in many, but not all, scenarios.
    /// </summary>
    public static void SetHoist(this Metapsi.Html.AttributesBuilder<SlDropdown> b, bool hoist) 
    {
        if (hoist) b.SetAttribute("hoist", "");
    }

    /// <summary>
    /// Enable this option to prevent the panel from being clipped when the component is placed inside a container with `overflow: auto|scroll`. Hoisting uses a fixed positioning strategy that works in many, but not all, scenarios.
    /// </summary>
    public static void SetHoist(this Metapsi.Html.AttributesBuilder<SlDropdown> b) 
    {
        b.SetAttribute("hoist", "");
    }

    /// <summary>
    /// Syncs the popup width or height to that of the trigger element.
    /// </summary>
    public static void SetSyncWidth(this Metapsi.Html.AttributesBuilder<SlDropdown> b) 
    {
        b.SetAttribute("sync", "width");
    }

    /// <summary>
    /// Syncs the popup width or height to that of the trigger element.
    /// </summary>
    public static void SetSyncHeight(this Metapsi.Html.AttributesBuilder<SlDropdown> b) 
    {
        b.SetAttribute("sync", "height");
    }

    /// <summary>
    /// Syncs the popup width or height to that of the trigger element.
    /// </summary>
    public static void SetSyncBoth(this Metapsi.Html.AttributesBuilder<SlDropdown> b) 
    {
        b.SetAttribute("sync", "both");
    }

    /// <summary>
    /// Dropdowns expose additional content that "drops down" in a panel.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlDropdown(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlDropdown>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-dropdown", buildProps, children);
    }

    /// <summary>
    /// Dropdowns expose additional content that "drops down" in a panel.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlDropdown(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-dropdown", children);
    }

    /// <summary>
    /// Dropdowns expose additional content that "drops down" in a panel.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlDropdown(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlDropdown>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-dropdown", buildProps, children);
    }

    /// <summary>
    /// Dropdowns expose additional content that "drops down" in a panel.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlDropdown(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-dropdown", children);
    }

    /// <summary>
    /// Indicates whether or not the dropdown is open. You can toggle this attribute to show and hide the dropdown, or you can use the `show()` and `hide()` methods and this attribute will reflect the dropdown's open state.
    /// </summary>
    public static void SetOpen<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlDropdown
    {
        b.SetOpen(b.Const(true));
    }

    /// <summary>
    /// Indicates whether or not the dropdown is open. You can toggle this attribute to show and hide the dropdown, or you can use the `show()` and `hide()` methods and this attribute will reflect the dropdown's open state.
    /// </summary>
    public static void SetOpen<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> open) where T: SlDropdown
    {
        b.SetProperty(b.Props, b.Const("open"), open);
    }

    /// <summary>
    /// Indicates whether or not the dropdown is open. You can toggle this attribute to show and hide the dropdown, or you can use the `show()` and `hide()` methods and this attribute will reflect the dropdown's open state.
    /// </summary>
    public static void SetOpen<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool open) where T: SlDropdown
    {
        b.SetOpen(b.Const(open));
    }

    /// <summary>
    /// The preferred placement of the dropdown panel. Note that the actual placement may vary as needed to keep the panel inside of the viewport.
    /// </summary>
    public static void SetPlacementTop<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlDropdown
    {
        b.SetProperty(b.Props, b.Const("placement"), b.Const("top"));
    }

    /// <summary>
    /// The preferred placement of the dropdown panel. Note that the actual placement may vary as needed to keep the panel inside of the viewport.
    /// </summary>
    public static void SetPlacementTopStart<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlDropdown
    {
        b.SetProperty(b.Props, b.Const("placement"), b.Const("top-start"));
    }

    /// <summary>
    /// The preferred placement of the dropdown panel. Note that the actual placement may vary as needed to keep the panel inside of the viewport.
    /// </summary>
    public static void SetPlacementTopEnd<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlDropdown
    {
        b.SetProperty(b.Props, b.Const("placement"), b.Const("top-end"));
    }

    /// <summary>
    /// The preferred placement of the dropdown panel. Note that the actual placement may vary as needed to keep the panel inside of the viewport.
    /// </summary>
    public static void SetPlacementBottom<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlDropdown
    {
        b.SetProperty(b.Props, b.Const("placement"), b.Const("bottom"));
    }

    /// <summary>
    /// The preferred placement of the dropdown panel. Note that the actual placement may vary as needed to keep the panel inside of the viewport.
    /// </summary>
    public static void SetPlacementBottomStart<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlDropdown
    {
        b.SetProperty(b.Props, b.Const("placement"), b.Const("bottom-start"));
    }

    /// <summary>
    /// The preferred placement of the dropdown panel. Note that the actual placement may vary as needed to keep the panel inside of the viewport.
    /// </summary>
    public static void SetPlacementBottomEnd<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlDropdown
    {
        b.SetProperty(b.Props, b.Const("placement"), b.Const("bottom-end"));
    }

    /// <summary>
    /// The preferred placement of the dropdown panel. Note that the actual placement may vary as needed to keep the panel inside of the viewport.
    /// </summary>
    public static void SetPlacementRight<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlDropdown
    {
        b.SetProperty(b.Props, b.Const("placement"), b.Const("right"));
    }

    /// <summary>
    /// The preferred placement of the dropdown panel. Note that the actual placement may vary as needed to keep the panel inside of the viewport.
    /// </summary>
    public static void SetPlacementRightStart<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlDropdown
    {
        b.SetProperty(b.Props, b.Const("placement"), b.Const("right-start"));
    }

    /// <summary>
    /// The preferred placement of the dropdown panel. Note that the actual placement may vary as needed to keep the panel inside of the viewport.
    /// </summary>
    public static void SetPlacementRightEnd<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlDropdown
    {
        b.SetProperty(b.Props, b.Const("placement"), b.Const("right-end"));
    }

    /// <summary>
    /// The preferred placement of the dropdown panel. Note that the actual placement may vary as needed to keep the panel inside of the viewport.
    /// </summary>
    public static void SetPlacementLeft<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlDropdown
    {
        b.SetProperty(b.Props, b.Const("placement"), b.Const("left"));
    }

    /// <summary>
    /// The preferred placement of the dropdown panel. Note that the actual placement may vary as needed to keep the panel inside of the viewport.
    /// </summary>
    public static void SetPlacementLeftStart<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlDropdown
    {
        b.SetProperty(b.Props, b.Const("placement"), b.Const("left-start"));
    }

    /// <summary>
    /// The preferred placement of the dropdown panel. Note that the actual placement may vary as needed to keep the panel inside of the viewport.
    /// </summary>
    public static void SetPlacementLeftEnd<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlDropdown
    {
        b.SetProperty(b.Props, b.Const("placement"), b.Const("left-end"));
    }

    /// <summary>
    /// Disables the dropdown so the panel will not open.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlDropdown
    {
        b.SetDisabled(b.Const(true));
    }

    /// <summary>
    /// Disables the dropdown so the panel will not open.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> disabled) where T: SlDropdown
    {
        b.SetProperty(b.Props, b.Const("disabled"), disabled);
    }

    /// <summary>
    /// Disables the dropdown so the panel will not open.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool disabled) where T: SlDropdown
    {
        b.SetDisabled(b.Const(disabled));
    }

    /// <summary>
    /// By default, the dropdown is closed when an item is selected. This attribute will keep it open instead. Useful for dropdowns that allow for multiple interactions.
    /// </summary>
    public static void SetStayOpenOnSelect<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlDropdown
    {
        b.SetStayOpenOnSelect(b.Const(true));
    }

    /// <summary>
    /// By default, the dropdown is closed when an item is selected. This attribute will keep it open instead. Useful for dropdowns that allow for multiple interactions.
    /// </summary>
    public static void SetStayOpenOnSelect<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> stayOpenOnSelect) where T: SlDropdown
    {
        b.SetProperty(b.Props, b.Const("stayOpenOnSelect"), stayOpenOnSelect);
    }

    /// <summary>
    /// By default, the dropdown is closed when an item is selected. This attribute will keep it open instead. Useful for dropdowns that allow for multiple interactions.
    /// </summary>
    public static void SetStayOpenOnSelect<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool stayOpenOnSelect) where T: SlDropdown
    {
        b.SetStayOpenOnSelect(b.Const(stayOpenOnSelect));
    }

    /// <summary>
    /// The dropdown will close when the user interacts outside of this element (e.g. clicking). Useful for composing other components that use a dropdown internally.
    /// </summary>
    public static void SetContainingElement<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Syntax.Var<Metapsi.Html.HTMLElement>> containingElement) where T: SlDropdown
    {
        b.SetProperty(b.Props, b.Const("containingElement"), containingElement);
    }

    /// <summary>
    /// The distance in pixels from which to offset the panel away from its trigger.
    /// </summary>
    public static void SetDistance<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<decimal> distance) where T: SlDropdown
    {
        b.SetProperty(b.Props, b.Const("distance"), distance);
    }

    /// <summary>
    /// The distance in pixels from which to offset the panel along its trigger.
    /// </summary>
    public static void SetSkidding<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<decimal> skidding) where T: SlDropdown
    {
        b.SetProperty(b.Props, b.Const("skidding"), skidding);
    }

    /// <summary>
    /// Enable this option to prevent the panel from being clipped when the component is placed inside a container with `overflow: auto|scroll`. Hoisting uses a fixed positioning strategy that works in many, but not all, scenarios.
    /// </summary>
    public static void SetHoist<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlDropdown
    {
        b.SetHoist(b.Const(true));
    }

    /// <summary>
    /// Enable this option to prevent the panel from being clipped when the component is placed inside a container with `overflow: auto|scroll`. Hoisting uses a fixed positioning strategy that works in many, but not all, scenarios.
    /// </summary>
    public static void SetHoist<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> hoist) where T: SlDropdown
    {
        b.SetProperty(b.Props, b.Const("hoist"), hoist);
    }

    /// <summary>
    /// Enable this option to prevent the panel from being clipped when the component is placed inside a container with `overflow: auto|scroll`. Hoisting uses a fixed positioning strategy that works in many, but not all, scenarios.
    /// </summary>
    public static void SetHoist<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool hoist) where T: SlDropdown
    {
        b.SetHoist(b.Const(hoist));
    }

    /// <summary>
    /// Syncs the popup width or height to that of the trigger element.
    /// </summary>
    public static void SetSyncWidth<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlDropdown
    {
        b.SetProperty(b.Props, b.Const("sync"), b.Const("width"));
    }

    /// <summary>
    /// Syncs the popup width or height to that of the trigger element.
    /// </summary>
    public static void SetSyncHeight<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlDropdown
    {
        b.SetProperty(b.Props, b.Const("sync"), b.Const("height"));
    }

    /// <summary>
    /// Syncs the popup width or height to that of the trigger element.
    /// </summary>
    public static void SetSyncBoth<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlDropdown
    {
        b.SetProperty(b.Props, b.Const("sync"), b.Const("both"));
    }

    /// <summary>
    /// Emitted when the dropdown opens.
    /// </summary>
    public static void OnSlShow<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: SlDropdown
    {
        b.OnSlEvent("onsl-show", action);
    }

    /// <summary>
    /// Emitted when the dropdown opens.
    /// </summary>
    public static void OnSlShow<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: SlDropdown
    {
        b.OnSlShow(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the dropdown opens.
    /// </summary>
    public static void OnSlShow<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: SlDropdown
    {
        b.OnSlEvent("onsl-show", action);
    }

    /// <summary>
    /// Emitted when the dropdown opens.
    /// </summary>
    public static void OnSlShow<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: SlDropdown
    {
        b.OnSlShow(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the dropdown opens and all animations are complete.
    /// </summary>
    public static void OnSlAfterShow<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: SlDropdown
    {
        b.OnSlEvent("onsl-after-show", action);
    }

    /// <summary>
    /// Emitted after the dropdown opens and all animations are complete.
    /// </summary>
    public static void OnSlAfterShow<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: SlDropdown
    {
        b.OnSlAfterShow(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the dropdown opens and all animations are complete.
    /// </summary>
    public static void OnSlAfterShow<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: SlDropdown
    {
        b.OnSlEvent("onsl-after-show", action);
    }

    /// <summary>
    /// Emitted after the dropdown opens and all animations are complete.
    /// </summary>
    public static void OnSlAfterShow<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: SlDropdown
    {
        b.OnSlAfterShow(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the dropdown closes.
    /// </summary>
    public static void OnSlHide<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: SlDropdown
    {
        b.OnSlEvent("onsl-hide", action);
    }

    /// <summary>
    /// Emitted when the dropdown closes.
    /// </summary>
    public static void OnSlHide<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: SlDropdown
    {
        b.OnSlHide(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the dropdown closes.
    /// </summary>
    public static void OnSlHide<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: SlDropdown
    {
        b.OnSlEvent("onsl-hide", action);
    }

    /// <summary>
    /// Emitted when the dropdown closes.
    /// </summary>
    public static void OnSlHide<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: SlDropdown
    {
        b.OnSlHide(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the dropdown closes and all animations are complete.
    /// </summary>
    public static void OnSlAfterHide<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: SlDropdown
    {
        b.OnSlEvent("onsl-after-hide", action);
    }

    /// <summary>
    /// Emitted after the dropdown closes and all animations are complete.
    /// </summary>
    public static void OnSlAfterHide<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: SlDropdown
    {
        b.OnSlAfterHide(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the dropdown closes and all animations are complete.
    /// </summary>
    public static void OnSlAfterHide<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: SlDropdown
    {
        b.OnSlEvent("onsl-after-hide", action);
    }

    /// <summary>
    /// Emitted after the dropdown closes and all animations are complete.
    /// </summary>
    public static void OnSlAfterHide<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: SlDropdown
    {
        b.OnSlAfterHide(b.MakeAction(action));
    }

}