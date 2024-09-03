using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Shoelace;


public partial class SlSplitPanel
{
    /// <summary>
    ///
    /// </summary>
    public static class Slot
    {
        /// <summary>
        /// <para> Content to place in the start panel. </para>
        /// </summary>
        public const string Start = "start";
        /// <summary>
        /// <para> Content to place in the end panel. </para>
        /// </summary>
        public const string End = "end";
        /// <summary>
        /// <para> The divider. Useful for slotting in a custom icon that renders as a handle. </para>
        /// </summary>
        public const string Divider = "divider";
    }
}

public static partial class SlSplitPanelControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlSplitPanel(this HtmlBuilder b, Action<AttributesBuilder<SlSplitPanel>> buildAttributes, params IHtmlNode[] children)
    {
        return b.SlTag("sl-split-panel", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlSplitPanel(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.SlTag("sl-split-panel", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlSplitPanel(this HtmlBuilder b, Action<AttributesBuilder<SlSplitPanel>> buildAttributes, List<IHtmlNode> children)
    {
        return b.SlTag("sl-split-panel", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlSplitPanel(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.SlTag("sl-split-panel", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The current position of the divider from the primary panel's edge as a percentage 0-100. Defaults to 50% of the container's initial size. </para>
    /// </summary>
    public static void SetPosition(this AttributesBuilder<SlSplitPanel> b, string position)
    {
        b.SetAttribute("position", position);
    }

    /// <summary>
    /// <para> The current position of the divider from the primary panel's edge in pixels. </para>
    /// </summary>
    public static void SetPositionInPixels(this AttributesBuilder<SlSplitPanel> b, string positionInPixels)
    {
        b.SetAttribute("position-in-pixels", positionInPixels);
    }

    /// <summary>
    /// <para> Draws the split panel in a vertical orientation with the start and end panels stacked. </para>
    /// </summary>
    public static void SetVertical(this AttributesBuilder<SlSplitPanel> b)
    {
        b.SetAttribute("vertical", "");
    }

    /// <summary>
    /// <para> Draws the split panel in a vertical orientation with the start and end panels stacked. </para>
    /// </summary>
    public static void SetVertical(this AttributesBuilder<SlSplitPanel> b, bool vertical)
    {
        if (vertical) b.SetAttribute("vertical", "");
    }

    /// <summary>
    /// <para> Disables resizing. Note that the position may still change as a result of resizing the host element. </para>
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<SlSplitPanel> b)
    {
        b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// <para> Disables resizing. Note that the position may still change as a result of resizing the host element. </para>
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<SlSplitPanel> b, bool disabled)
    {
        if (disabled) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// <para> If no primary panel is designated, both panels will resize proportionally when the host element is resized. If a primary panel is designated, it will maintain its size and the other panel will grow or shrink as needed when the host element is resized. </para>
    /// </summary>
    public static void SetPrimary(this AttributesBuilder<SlSplitPanel> b, string primary)
    {
        b.SetAttribute("primary", primary);
    }

    /// <summary>
    /// <para> If no primary panel is designated, both panels will resize proportionally when the host element is resized. If a primary panel is designated, it will maintain its size and the other panel will grow or shrink as needed when the host element is resized. </para>
    /// </summary>
    public static void SetPrimaryStart(this AttributesBuilder<SlSplitPanel> b)
    {
        b.SetAttribute("primary", "start");
    }

    /// <summary>
    /// <para> If no primary panel is designated, both panels will resize proportionally when the host element is resized. If a primary panel is designated, it will maintain its size and the other panel will grow or shrink as needed when the host element is resized. </para>
    /// </summary>
    public static void SetPrimaryEnd(this AttributesBuilder<SlSplitPanel> b)
    {
        b.SetAttribute("primary", "end");
    }

    /// <summary>
    /// <para> One or more space-separated values at which the divider should snap. Values can be in pixels or percentages, e.g. `"100px 50%"`. </para>
    /// </summary>
    public static void SetSnap(this AttributesBuilder<SlSplitPanel> b, string snap)
    {
        b.SetAttribute("snap", snap);
    }

    /// <summary>
    /// <para> How close the divider must be to a snap point until snapping occurs. </para>
    /// </summary>
    public static void SetSnapThreshold(this AttributesBuilder<SlSplitPanel> b, string snapThreshold)
    {
        b.SetAttribute("snap-threshold", snapThreshold);
    }

    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlSplitPanel(this LayoutBuilder b, Action<PropsBuilder<SlSplitPanel>> buildProps, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-split-panel", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlSplitPanel(this LayoutBuilder b, Action<PropsBuilder<SlSplitPanel>> buildProps, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-split-panel", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlSplitPanel(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-split-panel", children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlSplitPanel(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-split-panel", children);
    }
    /// <summary>
    /// <para> The current position of the divider from the primary panel's edge as a percentage 0-100. Defaults to 50% of the container's initial size. </para>
    /// </summary>
    public static void SetPosition<T>(this PropsBuilder<T> b, Var<int> position) where T: SlSplitPanel
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("position"), position);
    }

    /// <summary>
    /// <para> The current position of the divider from the primary panel's edge as a percentage 0-100. Defaults to 50% of the container's initial size. </para>
    /// </summary>
    public static void SetPosition<T>(this PropsBuilder<T> b, int position) where T: SlSplitPanel
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("position"), b.Const(position));
    }


    /// <summary>
    /// <para> The current position of the divider from the primary panel's edge in pixels. </para>
    /// </summary>
    public static void SetPositionInPixels<T>(this PropsBuilder<T> b, Var<int> positionInPixels) where T: SlSplitPanel
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("positionInPixels"), positionInPixels);
    }

    /// <summary>
    /// <para> The current position of the divider from the primary panel's edge in pixels. </para>
    /// </summary>
    public static void SetPositionInPixels<T>(this PropsBuilder<T> b, int positionInPixels) where T: SlSplitPanel
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("positionInPixels"), b.Const(positionInPixels));
    }


    /// <summary>
    /// <para> Draws the split panel in a vertical orientation with the start and end panels stacked. </para>
    /// </summary>
    public static void SetVertical<T>(this PropsBuilder<T> b) where T: SlSplitPanel
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("vertical"), b.Const(true));
    }


    /// <summary>
    /// <para> Draws the split panel in a vertical orientation with the start and end panels stacked. </para>
    /// </summary>
    public static void SetVertical<T>(this PropsBuilder<T> b, Var<bool> vertical) where T: SlSplitPanel
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("vertical"), vertical);
    }

    /// <summary>
    /// <para> Draws the split panel in a vertical orientation with the start and end panels stacked. </para>
    /// </summary>
    public static void SetVertical<T>(this PropsBuilder<T> b, bool vertical) where T: SlSplitPanel
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("vertical"), b.Const(vertical));
    }


    /// <summary>
    /// <para> Disables resizing. Note that the position may still change as a result of resizing the host element. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b) where T: SlSplitPanel
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), b.Const(true));
    }


    /// <summary>
    /// <para> Disables resizing. Note that the position may still change as a result of resizing the host element. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, Var<bool> disabled) where T: SlSplitPanel
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), disabled);
    }

    /// <summary>
    /// <para> Disables resizing. Note that the position may still change as a result of resizing the host element. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, bool disabled) where T: SlSplitPanel
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), b.Const(disabled));
    }


    /// <summary>
    /// <para> If no primary panel is designated, both panels will resize proportionally when the host element is resized. If a primary panel is designated, it will maintain its size and the other panel will grow or shrink as needed when the host element is resized. </para>
    /// </summary>
    public static void SetPrimaryStart<T>(this PropsBuilder<T> b) where T: SlSplitPanel
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("primary"), b.Const("start"));
    }


    /// <summary>
    /// <para> If no primary panel is designated, both panels will resize proportionally when the host element is resized. If a primary panel is designated, it will maintain its size and the other panel will grow or shrink as needed when the host element is resized. </para>
    /// </summary>
    public static void SetPrimaryEnd<T>(this PropsBuilder<T> b) where T: SlSplitPanel
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("primary"), b.Const("end"));
    }


    /// <summary>
    /// <para> One or more space-separated values at which the divider should snap. Values can be in pixels or percentages, e.g. `"100px 50%"`. </para>
    /// </summary>
    public static void SetSnap<T>(this PropsBuilder<T> b, Var<string> snap) where T: SlSplitPanel
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("snap"), snap);
    }

    /// <summary>
    /// <para> One or more space-separated values at which the divider should snap. Values can be in pixels or percentages, e.g. `"100px 50%"`. </para>
    /// </summary>
    public static void SetSnap<T>(this PropsBuilder<T> b, string snap) where T: SlSplitPanel
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("snap"), b.Const(snap));
    }


    /// <summary>
    /// <para> How close the divider must be to a snap point until snapping occurs. </para>
    /// </summary>
    public static void SetSnapThreshold<T>(this PropsBuilder<T> b, Var<int> snapThreshold) where T: SlSplitPanel
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("snapThreshold"), snapThreshold);
    }

    /// <summary>
    /// <para> How close the divider must be to a snap point until snapping occurs. </para>
    /// </summary>
    public static void SetSnapThreshold<T>(this PropsBuilder<T> b, int snapThreshold) where T: SlSplitPanel
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("snapThreshold"), b.Const(snapThreshold));
    }


    /// <summary>
    /// <para> Emitted when the divider's position changes. </para>
    /// </summary>
    public static void OnSlReposition<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, DomEvent>> action) where TComponent: SlSplitPanel
    {
        b.OnEventAction("onsl-reposition", action);
    }
    /// <summary>
    /// <para> Emitted when the divider's position changes. </para>
    /// </summary>
    public static void OnSlReposition<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action) where TComponent: SlSplitPanel
    {
        b.OnEventAction("onsl-reposition", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the divider's position changes. </para>
    /// </summary>
    public static void OnSlReposition<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: SlSplitPanel
    {
        b.OnEventAction("onsl-reposition", action);
    }
    /// <summary>
    /// <para> Emitted when the divider's position changes. </para>
    /// </summary>
    public static void OnSlReposition<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: SlSplitPanel
    {
        b.OnEventAction("onsl-reposition", b.MakeAction(action));
    }

}

