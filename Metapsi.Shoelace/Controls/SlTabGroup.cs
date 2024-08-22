using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Shoelace;


public partial class SlTabGroup
{
    /// <summary>
    ///
    /// </summary>
    public static class Slot
    {
        /// <summary>
        /// <para> Used for grouping tabs in the tab group. Must be `&lt;sl-tab&gt;` elements. </para>
        /// </summary>
        public const string Nav = "nav";
    }
    public static class Method
    {
        /// <summary>
        /// <para> Shows the specified tab panel. </para>
        /// </summary>
        public const string Show = "show";
    }
}

public static partial class SlTabGroupControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlTabGroup(this HtmlBuilder b, Action<AttributesBuilder<SlTabGroup>> buildAttributes, params IHtmlNode[] children)
    {
        return b.SlTag("sl-tab-group", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlTabGroup(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.SlTag("sl-tab-group", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlTabGroup(this HtmlBuilder b, Action<AttributesBuilder<SlTabGroup>> buildAttributes, List<IHtmlNode> children)
    {
        return b.SlTag("sl-tab-group", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlTabGroup(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.SlTag("sl-tab-group", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The placement of the tabs. </para>
    /// </summary>
    public static void SetPlacement(this AttributesBuilder<SlTabGroup> b, string placement)
    {
        b.SetAttribute("placement", placement);
    }

    /// <summary>
    /// <para> The placement of the tabs. </para>
    /// </summary>
    public static void SetPlacementTop(this AttributesBuilder<SlTabGroup> b)
    {
        b.SetAttribute("placement", "top");
    }

    /// <summary>
    /// <para> The placement of the tabs. </para>
    /// </summary>
    public static void SetPlacementBottom(this AttributesBuilder<SlTabGroup> b)
    {
        b.SetAttribute("placement", "bottom");
    }

    /// <summary>
    /// <para> The placement of the tabs. </para>
    /// </summary>
    public static void SetPlacementStart(this AttributesBuilder<SlTabGroup> b)
    {
        b.SetAttribute("placement", "start");
    }

    /// <summary>
    /// <para> The placement of the tabs. </para>
    /// </summary>
    public static void SetPlacementEnd(this AttributesBuilder<SlTabGroup> b)
    {
        b.SetAttribute("placement", "end");
    }

    /// <summary>
    /// <para> When set to auto, navigating tabs with the arrow keys will instantly show the corresponding tab panel. When set to manual, the tab will receive focus but will not show until the user presses spacebar or enter. </para>
    /// </summary>
    public static void SetActivation(this AttributesBuilder<SlTabGroup> b, string activation)
    {
        b.SetAttribute("activation", activation);
    }

    /// <summary>
    /// <para> When set to auto, navigating tabs with the arrow keys will instantly show the corresponding tab panel. When set to manual, the tab will receive focus but will not show until the user presses spacebar or enter. </para>
    /// </summary>
    public static void SetActivationAuto(this AttributesBuilder<SlTabGroup> b)
    {
        b.SetAttribute("activation", "auto");
    }

    /// <summary>
    /// <para> When set to auto, navigating tabs with the arrow keys will instantly show the corresponding tab panel. When set to manual, the tab will receive focus but will not show until the user presses spacebar or enter. </para>
    /// </summary>
    public static void SetActivationManual(this AttributesBuilder<SlTabGroup> b)
    {
        b.SetAttribute("activation", "manual");
    }

    /// <summary>
    /// <para> Disables the scroll arrows that appear when tabs overflow. </para>
    /// </summary>
    public static void SetNoScrollControls(this AttributesBuilder<SlTabGroup> b)
    {
        b.SetAttribute("no-scroll-controls", "");
    }

    /// <summary>
    /// <para> Disables the scroll arrows that appear when tabs overflow. </para>
    /// </summary>
    public static void SetNoScrollControls(this AttributesBuilder<SlTabGroup> b, bool noScrollControls)
    {
        if (noScrollControls) b.SetAttribute("no-scroll-controls", "");
    }

    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlTabGroup(this LayoutBuilder b, Action<PropsBuilder<SlTabGroup>> buildProps, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-tab-group", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlTabGroup(this LayoutBuilder b, Action<PropsBuilder<SlTabGroup>> buildProps, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-tab-group", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlTabGroup(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-tab-group", children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlTabGroup(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-tab-group", children);
    }
    /// <summary>
    /// <para> The placement of the tabs. </para>
    /// </summary>
    public static void SetPlacementTop<T>(this PropsBuilder<T> b) where T: SlTabGroup
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("placement"), b.Const("top"));
    }


    /// <summary>
    /// <para> The placement of the tabs. </para>
    /// </summary>
    public static void SetPlacementBottom<T>(this PropsBuilder<T> b) where T: SlTabGroup
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("placement"), b.Const("bottom"));
    }


    /// <summary>
    /// <para> The placement of the tabs. </para>
    /// </summary>
    public static void SetPlacementStart<T>(this PropsBuilder<T> b) where T: SlTabGroup
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("placement"), b.Const("start"));
    }


    /// <summary>
    /// <para> The placement of the tabs. </para>
    /// </summary>
    public static void SetPlacementEnd<T>(this PropsBuilder<T> b) where T: SlTabGroup
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("placement"), b.Const("end"));
    }


    /// <summary>
    /// <para> When set to auto, navigating tabs with the arrow keys will instantly show the corresponding tab panel. When set to manual, the tab will receive focus but will not show until the user presses spacebar or enter. </para>
    /// </summary>
    public static void SetActivationAuto<T>(this PropsBuilder<T> b) where T: SlTabGroup
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("activation"), b.Const("auto"));
    }


    /// <summary>
    /// <para> When set to auto, navigating tabs with the arrow keys will instantly show the corresponding tab panel. When set to manual, the tab will receive focus but will not show until the user presses spacebar or enter. </para>
    /// </summary>
    public static void SetActivationManual<T>(this PropsBuilder<T> b) where T: SlTabGroup
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("activation"), b.Const("manual"));
    }


    /// <summary>
    /// <para> Disables the scroll arrows that appear when tabs overflow. </para>
    /// </summary>
    public static void SetNoScrollControls<T>(this PropsBuilder<T> b) where T: SlTabGroup
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("noScrollControls"), b.Const(true));
    }


    /// <summary>
    /// <para> Disables the scroll arrows that appear when tabs overflow. </para>
    /// </summary>
    public static void SetNoScrollControls<T>(this PropsBuilder<T> b, Var<bool> noScrollControls) where T: SlTabGroup
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("noScrollControls"), noScrollControls);
    }

    /// <summary>
    /// <para> Disables the scroll arrows that appear when tabs overflow. </para>
    /// </summary>
    public static void SetNoScrollControls<T>(this PropsBuilder<T> b, bool noScrollControls) where T: SlTabGroup
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("noScrollControls"), b.Const(noScrollControls));
    }


    /// <summary>
    /// <para> Emitted when a tab is shown. </para>
    /// </summary>
    public static void OnSlTabShow<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, DomEvent>> action) where TComponent: SlTabGroup
    {
        b.OnEventAction("onsl-tab-show", action);
    }
    /// <summary>
    /// <para> Emitted when a tab is shown. </para>
    /// </summary>
    public static void OnSlTabShow<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action) where TComponent: SlTabGroup
    {
        b.OnEventAction("onsl-tab-show", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when a tab is shown. </para>
    /// </summary>
    public static void OnSlTabShow<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: SlTabGroup
    {
        b.OnEventAction("onsl-tab-show", action);
    }
    /// <summary>
    /// <para> Emitted when a tab is shown. </para>
    /// </summary>
    public static void OnSlTabShow<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: SlTabGroup
    {
        b.OnEventAction("onsl-tab-show", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when a tab is shown. </para>
    /// </summary>
    public static void OnSlTabShow<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, SlTabShowEventArgs>> action) where TComponent: SlTabGroup
    {
        b.OnEventAction("onsl-tab-show", action, "detail");
    }
    /// <summary>
    /// <para> Emitted when a tab is shown. </para>
    /// </summary>
    public static void OnSlTabShow<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SlTabShowEventArgs>, Var<TModel>> action) where TComponent: SlTabGroup
    {
        b.OnEventAction("onsl-tab-show", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// <para> Emitted when a tab is hidden. </para>
    /// </summary>
    public static void OnSlTabHide<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, DomEvent>> action) where TComponent: SlTabGroup
    {
        b.OnEventAction("onsl-tab-hide", action);
    }
    /// <summary>
    /// <para> Emitted when a tab is hidden. </para>
    /// </summary>
    public static void OnSlTabHide<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action) where TComponent: SlTabGroup
    {
        b.OnEventAction("onsl-tab-hide", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when a tab is hidden. </para>
    /// </summary>
    public static void OnSlTabHide<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: SlTabGroup
    {
        b.OnEventAction("onsl-tab-hide", action);
    }
    /// <summary>
    /// <para> Emitted when a tab is hidden. </para>
    /// </summary>
    public static void OnSlTabHide<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: SlTabGroup
    {
        b.OnEventAction("onsl-tab-hide", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when a tab is hidden. </para>
    /// </summary>
    public static void OnSlTabHide<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, SlTabHideEventArgs>> action) where TComponent: SlTabGroup
    {
        b.OnEventAction("onsl-tab-hide", action, "detail");
    }
    /// <summary>
    /// <para> Emitted when a tab is hidden. </para>
    /// </summary>
    public static void OnSlTabHide<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SlTabHideEventArgs>, Var<TModel>> action) where TComponent: SlTabGroup
    {
        b.OnEventAction("onsl-tab-hide", b.MakeAction(action), "detail");
    }

}

