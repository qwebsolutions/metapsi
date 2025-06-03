using Metapsi.Html;
using Metapsi.Syntax;
using Metapsi.Hyperapp;

namespace Metapsi.Shoelace;

/// <summary>
/// Tab groups organize content into a container that shows one section at a time.
/// </summary>
public partial class SlTabGroup
{
    /// <summary>
    /// 
    /// </summary>
    public static class Slot
    {
        /// <summary>
        /// Used for grouping tabs in the tab group. Must be `&lt;sl-tab&gt;` elements.
        /// </summary>
        public const string Nav = "nav";
    }
    /// <summary>
    /// 
    /// </summary>
    public static class Method
    {
        /// <summary>
        /// Shows the specified tab panel.
        /// </summary>
        public const string Show = "show";
    }
}
/// <summary>
/// Setter extensions of SlTabGroup
/// </summary>
public static partial class SlTabGroupControl
{
    /// <summary>
    /// Tab groups organize content into a container that shows one section at a time.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlTabGroup(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlTabGroup>> buildAttributes, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-tab-group", buildAttributes, children);
    }

    /// <summary>
    /// Tab groups organize content into a container that shows one section at a time.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlTabGroup(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-tab-group", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// Tab groups organize content into a container that shows one section at a time.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlTabGroup(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlTabGroup>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-tab-group", buildAttributes, children);
    }

    /// <summary>
    /// Tab groups organize content into a container that shows one section at a time.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlTabGroup(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-tab-group", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// The placement of the tabs.
    /// </summary>
    public static void SetPlacementTop(this Metapsi.Html.AttributesBuilder<SlTabGroup> b) 
    {
        b.SetAttribute("placement", "top");
    }

    /// <summary>
    /// The placement of the tabs.
    /// </summary>
    public static void SetPlacementBottom(this Metapsi.Html.AttributesBuilder<SlTabGroup> b) 
    {
        b.SetAttribute("placement", "bottom");
    }

    /// <summary>
    /// The placement of the tabs.
    /// </summary>
    public static void SetPlacementStart(this Metapsi.Html.AttributesBuilder<SlTabGroup> b) 
    {
        b.SetAttribute("placement", "start");
    }

    /// <summary>
    /// The placement of the tabs.
    /// </summary>
    public static void SetPlacementEnd(this Metapsi.Html.AttributesBuilder<SlTabGroup> b) 
    {
        b.SetAttribute("placement", "end");
    }

    /// <summary>
    /// When set to auto, navigating tabs with the arrow keys will instantly show the corresponding tab panel. When set to manual, the tab will receive focus but will not show until the user presses spacebar or enter.
    /// </summary>
    public static void SetActivationAuto(this Metapsi.Html.AttributesBuilder<SlTabGroup> b) 
    {
        b.SetAttribute("activation", "auto");
    }

    /// <summary>
    /// When set to auto, navigating tabs with the arrow keys will instantly show the corresponding tab panel. When set to manual, the tab will receive focus but will not show until the user presses spacebar or enter.
    /// </summary>
    public static void SetActivationManual(this Metapsi.Html.AttributesBuilder<SlTabGroup> b) 
    {
        b.SetAttribute("activation", "manual");
    }

    /// <summary>
    /// Disables the scroll arrows that appear when tabs overflow.
    /// </summary>
    public static void SetNoScrollControls(this Metapsi.Html.AttributesBuilder<SlTabGroup> b, bool noScrollControls) 
    {
        if (noScrollControls) b.SetAttribute("no-scroll-controls", "");
    }

    /// <summary>
    /// Disables the scroll arrows that appear when tabs overflow.
    /// </summary>
    public static void SetNoScrollControls(this Metapsi.Html.AttributesBuilder<SlTabGroup> b) 
    {
        b.SetAttribute("no-scroll-controls", "");
    }

    /// <summary>
    /// Prevent scroll buttons from being hidden when inactive.
    /// </summary>
    public static void SetFixedScrollControls(this Metapsi.Html.AttributesBuilder<SlTabGroup> b, bool fixedScrollControls) 
    {
        if (fixedScrollControls) b.SetAttribute("fixed-scroll-controls", "");
    }

    /// <summary>
    /// Prevent scroll buttons from being hidden when inactive.
    /// </summary>
    public static void SetFixedScrollControls(this Metapsi.Html.AttributesBuilder<SlTabGroup> b) 
    {
        b.SetAttribute("fixed-scroll-controls", "");
    }

    /// <summary>
    /// Tab groups organize content into a container that shows one section at a time.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlTabGroup(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlTabGroup>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-tab-group", buildProps, children);
    }

    /// <summary>
    /// Tab groups organize content into a container that shows one section at a time.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlTabGroup(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-tab-group", children);
    }

    /// <summary>
    /// Tab groups organize content into a container that shows one section at a time.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlTabGroup(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlTabGroup>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-tab-group", buildProps, children);
    }

    /// <summary>
    /// Tab groups organize content into a container that shows one section at a time.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlTabGroup(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-tab-group", children);
    }

    /// <summary>
    /// The placement of the tabs.
    /// </summary>
    public static void SetPlacementTop<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlTabGroup
    {
        b.SetProperty(b.Props, b.Const("placement"), b.Const("top"));
    }

    /// <summary>
    /// The placement of the tabs.
    /// </summary>
    public static void SetPlacementBottom<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlTabGroup
    {
        b.SetProperty(b.Props, b.Const("placement"), b.Const("bottom"));
    }

    /// <summary>
    /// The placement of the tabs.
    /// </summary>
    public static void SetPlacementStart<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlTabGroup
    {
        b.SetProperty(b.Props, b.Const("placement"), b.Const("start"));
    }

    /// <summary>
    /// The placement of the tabs.
    /// </summary>
    public static void SetPlacementEnd<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlTabGroup
    {
        b.SetProperty(b.Props, b.Const("placement"), b.Const("end"));
    }

    /// <summary>
    /// When set to auto, navigating tabs with the arrow keys will instantly show the corresponding tab panel. When set to manual, the tab will receive focus but will not show until the user presses spacebar or enter.
    /// </summary>
    public static void SetActivationAuto<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlTabGroup
    {
        b.SetProperty(b.Props, b.Const("activation"), b.Const("auto"));
    }

    /// <summary>
    /// When set to auto, navigating tabs with the arrow keys will instantly show the corresponding tab panel. When set to manual, the tab will receive focus but will not show until the user presses spacebar or enter.
    /// </summary>
    public static void SetActivationManual<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlTabGroup
    {
        b.SetProperty(b.Props, b.Const("activation"), b.Const("manual"));
    }

    /// <summary>
    /// Disables the scroll arrows that appear when tabs overflow.
    /// </summary>
    public static void SetNoScrollControls<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlTabGroup
    {
        b.SetNoScrollControls(b.Const(true));
    }

    /// <summary>
    /// Disables the scroll arrows that appear when tabs overflow.
    /// </summary>
    public static void SetNoScrollControls<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> noScrollControls) where T: SlTabGroup
    {
        b.SetProperty(b.Props, b.Const("noScrollControls"), noScrollControls);
    }

    /// <summary>
    /// Disables the scroll arrows that appear when tabs overflow.
    /// </summary>
    public static void SetNoScrollControls<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool noScrollControls) where T: SlTabGroup
    {
        b.SetNoScrollControls(b.Const(noScrollControls));
    }

    /// <summary>
    /// Prevent scroll buttons from being hidden when inactive.
    /// </summary>
    public static void SetFixedScrollControls<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlTabGroup
    {
        b.SetFixedScrollControls(b.Const(true));
    }

    /// <summary>
    /// Prevent scroll buttons from being hidden when inactive.
    /// </summary>
    public static void SetFixedScrollControls<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> fixedScrollControls) where T: SlTabGroup
    {
        b.SetProperty(b.Props, b.Const("fixedScrollControls"), fixedScrollControls);
    }

    /// <summary>
    /// Prevent scroll buttons from being hidden when inactive.
    /// </summary>
    public static void SetFixedScrollControls<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool fixedScrollControls) where T: SlTabGroup
    {
        b.SetFixedScrollControls(b.Const(fixedScrollControls));
    }

    /// <summary>
    /// Emitted when a tab is shown.
    /// </summary>
    public static void OnSlTabShow<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: SlTabGroup
    {
        b.OnSlEvent("onsl-tab-show", action);
    }

    /// <summary>
    /// Emitted when a tab is shown.
    /// </summary>
    public static void OnSlTabShow<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: SlTabGroup
    {
        b.OnSlTabShow(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when a tab is shown.
    /// </summary>
    public static void OnSlTabShow<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: SlTabGroup
    {
        b.OnSlEvent("onsl-tab-show", action);
    }

    /// <summary>
    /// Emitted when a tab is shown.
    /// </summary>
    public static void OnSlTabShow<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: SlTabGroup
    {
        b.OnSlTabShow(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when a tab is shown.
    /// </summary>
    public static void OnSlTabShow<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.CustomEvent<SlTabShowDetail>>> action) where T: SlTabGroup
    {
        b.OnSlEvent("onsl-tab-show", action);
    }

    /// <summary>
    /// Emitted when a tab is hidden.
    /// </summary>
    public static void OnSlTabHide<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: SlTabGroup
    {
        b.OnSlEvent("onsl-tab-hide", action);
    }

    /// <summary>
    /// Emitted when a tab is hidden.
    /// </summary>
    public static void OnSlTabHide<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: SlTabGroup
    {
        b.OnSlTabHide(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when a tab is hidden.
    /// </summary>
    public static void OnSlTabHide<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: SlTabGroup
    {
        b.OnSlEvent("onsl-tab-hide", action);
    }

    /// <summary>
    /// Emitted when a tab is hidden.
    /// </summary>
    public static void OnSlTabHide<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: SlTabGroup
    {
        b.OnSlTabHide(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when a tab is hidden.
    /// </summary>
    public static void OnSlTabHide<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.CustomEvent<SlTabHideDetail>>> action) where T: SlTabGroup
    {
        b.OnSlEvent("onsl-tab-hide", action);
    }

}