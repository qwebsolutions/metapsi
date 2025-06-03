using Metapsi.Html;
using Metapsi.Syntax;
using Metapsi.Hyperapp;

namespace Metapsi.Shoelace;

/// <summary>
/// Split panels display two adjacent panels, allowing the user to reposition them.
/// </summary>
public partial class SlSplitPanel
{
    /// <summary>
    /// 
    /// </summary>
    public static class Slot
    {
        /// <summary>
        /// Content to place in the start panel.
        /// </summary>
        public const string Start = "start";
        /// <summary>
        /// Content to place in the end panel.
        /// </summary>
        public const string End = "end";
        /// <summary>
        /// The divider. Useful for slotting in a custom icon that renders as a handle.
        /// </summary>
        public const string Divider = "divider";
    }
    /// <summary>
    /// 
    /// </summary>
    public static class Method
    {
    }
}
/// <summary>
/// Setter extensions of SlSplitPanel
/// </summary>
public static partial class SlSplitPanelControl
{
    /// <summary>
    /// Split panels display two adjacent panels, allowing the user to reposition them.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlSplitPanel(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlSplitPanel>> buildAttributes, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-split-panel", buildAttributes, children);
    }

    /// <summary>
    /// Split panels display two adjacent panels, allowing the user to reposition them.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlSplitPanel(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-split-panel", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// Split panels display two adjacent panels, allowing the user to reposition them.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlSplitPanel(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlSplitPanel>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-split-panel", buildAttributes, children);
    }

    /// <summary>
    /// Split panels display two adjacent panels, allowing the user to reposition them.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlSplitPanel(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-split-panel", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// Draws the split panel in a vertical orientation with the start and end panels stacked.
    /// </summary>
    public static void SetVertical(this Metapsi.Html.AttributesBuilder<SlSplitPanel> b, bool vertical) 
    {
        if (vertical) b.SetAttribute("vertical", "");
    }

    /// <summary>
    /// Draws the split panel in a vertical orientation with the start and end panels stacked.
    /// </summary>
    public static void SetVertical(this Metapsi.Html.AttributesBuilder<SlSplitPanel> b) 
    {
        b.SetAttribute("vertical", "");
    }

    /// <summary>
    /// Disables resizing. Note that the position may still change as a result of resizing the host element.
    /// </summary>
    public static void SetDisabled(this Metapsi.Html.AttributesBuilder<SlSplitPanel> b, bool disabled) 
    {
        if (disabled) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// Disables resizing. Note that the position may still change as a result of resizing the host element.
    /// </summary>
    public static void SetDisabled(this Metapsi.Html.AttributesBuilder<SlSplitPanel> b) 
    {
        b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// If no primary panel is designated, both panels will resize proportionally when the host element is resized. If a primary panel is designated, it will maintain its size and the other panel will grow or shrink as needed when the host element is resized.
    /// </summary>
    public static void SetPrimaryStart(this Metapsi.Html.AttributesBuilder<SlSplitPanel> b) 
    {
        b.SetAttribute("primary", "start");
    }

    /// <summary>
    /// If no primary panel is designated, both panels will resize proportionally when the host element is resized. If a primary panel is designated, it will maintain its size and the other panel will grow or shrink as needed when the host element is resized.
    /// </summary>
    public static void SetPrimaryEnd(this Metapsi.Html.AttributesBuilder<SlSplitPanel> b) 
    {
        b.SetAttribute("primary", "end");
    }

    /// <summary>
    /// Either one or more space-separated values at which the divider should snap, in pixels, percentages, or repeat expressions e.g. `'100px 50% 500px' or `repeat(50%) 10px`, or a function which takes in a `SnapFunctionParams`, and returns a position to snap to, e.g. `({ pos }) =&gt; Math.round(pos / 8) * 8`.
    /// </summary>
    public static void SetSnap(this Metapsi.Html.AttributesBuilder<SlSplitPanel> b, string snap) 
    {
        b.SetAttribute("snap", snap);
    }

    /// <summary>
    /// Split panels display two adjacent panels, allowing the user to reposition them.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlSplitPanel(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlSplitPanel>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-split-panel", buildProps, children);
    }

    /// <summary>
    /// Split panels display two adjacent panels, allowing the user to reposition them.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlSplitPanel(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-split-panel", children);
    }

    /// <summary>
    /// Split panels display two adjacent panels, allowing the user to reposition them.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlSplitPanel(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlSplitPanel>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-split-panel", buildProps, children);
    }

    /// <summary>
    /// Split panels display two adjacent panels, allowing the user to reposition them.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlSplitPanel(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-split-panel", children);
    }

    /// <summary>
    /// The current position of the divider from the primary panel's edge as a percentage 0-100. Defaults to 50% of the container's initial size.
    /// </summary>
    public static void SetPosition<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<int> position) where T: SlSplitPanel
    {
        b.SetProperty(b.Props, b.Const("position"), position);
    }

    /// <summary>
    /// The current position of the divider from the primary panel's edge as a percentage 0-100. Defaults to 50% of the container's initial size.
    /// </summary>
    public static void SetPosition<T>(this Metapsi.Syntax.PropsBuilder<T> b, int position) where T: SlSplitPanel
    {
        b.SetPosition(b.Const(position));
    }

    /// <summary>
    /// The current position of the divider from the primary panel's edge as a percentage 0-100. Defaults to 50% of the container's initial size.
    /// </summary>
    public static void SetPosition<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<decimal> position) where T: SlSplitPanel
    {
        b.SetProperty(b.Props, b.Const("position"), position);
    }

    /// <summary>
    /// The current position of the divider from the primary panel's edge as a percentage 0-100. Defaults to 50% of the container's initial size.
    /// </summary>
    public static void SetPosition<T>(this Metapsi.Syntax.PropsBuilder<T> b, decimal position) where T: SlSplitPanel
    {
        b.SetPosition(b.Const(position));
    }

    /// <summary>
    /// The current position of the divider from the primary panel's edge in pixels.
    /// </summary>
    public static void SetPositionInPixels<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<int> positionInPixels) where T: SlSplitPanel
    {
        b.SetProperty(b.Props, b.Const("positionInPixels"), positionInPixels);
    }

    /// <summary>
    /// The current position of the divider from the primary panel's edge in pixels.
    /// </summary>
    public static void SetPositionInPixels<T>(this Metapsi.Syntax.PropsBuilder<T> b, int positionInPixels) where T: SlSplitPanel
    {
        b.SetPositionInPixels(b.Const(positionInPixels));
    }

    /// <summary>
    /// The current position of the divider from the primary panel's edge in pixels.
    /// </summary>
    public static void SetPositionInPixels<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<decimal> positionInPixels) where T: SlSplitPanel
    {
        b.SetProperty(b.Props, b.Const("positionInPixels"), positionInPixels);
    }

    /// <summary>
    /// The current position of the divider from the primary panel's edge in pixels.
    /// </summary>
    public static void SetPositionInPixels<T>(this Metapsi.Syntax.PropsBuilder<T> b, decimal positionInPixels) where T: SlSplitPanel
    {
        b.SetPositionInPixels(b.Const(positionInPixels));
    }

    /// <summary>
    /// Draws the split panel in a vertical orientation with the start and end panels stacked.
    /// </summary>
    public static void SetVertical<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlSplitPanel
    {
        b.SetVertical(b.Const(true));
    }

    /// <summary>
    /// Draws the split panel in a vertical orientation with the start and end panels stacked.
    /// </summary>
    public static void SetVertical<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> vertical) where T: SlSplitPanel
    {
        b.SetProperty(b.Props, b.Const("vertical"), vertical);
    }

    /// <summary>
    /// Draws the split panel in a vertical orientation with the start and end panels stacked.
    /// </summary>
    public static void SetVertical<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool vertical) where T: SlSplitPanel
    {
        b.SetVertical(b.Const(vertical));
    }

    /// <summary>
    /// Disables resizing. Note that the position may still change as a result of resizing the host element.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlSplitPanel
    {
        b.SetDisabled(b.Const(true));
    }

    /// <summary>
    /// Disables resizing. Note that the position may still change as a result of resizing the host element.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> disabled) where T: SlSplitPanel
    {
        b.SetProperty(b.Props, b.Const("disabled"), disabled);
    }

    /// <summary>
    /// Disables resizing. Note that the position may still change as a result of resizing the host element.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool disabled) where T: SlSplitPanel
    {
        b.SetDisabled(b.Const(disabled));
    }

    /// <summary>
    /// If no primary panel is designated, both panels will resize proportionally when the host element is resized. If a primary panel is designated, it will maintain its size and the other panel will grow or shrink as needed when the host element is resized.
    /// </summary>
    public static void SetPrimaryStart<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlSplitPanel
    {
        b.SetProperty(b.Props, b.Const("primary"), b.Const("start"));
    }

    /// <summary>
    /// If no primary panel is designated, both panels will resize proportionally when the host element is resized. If a primary panel is designated, it will maintain its size and the other panel will grow or shrink as needed when the host element is resized.
    /// </summary>
    public static void SetPrimaryEnd<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlSplitPanel
    {
        b.SetProperty(b.Props, b.Const("primary"), b.Const("end"));
    }

    /// <summary>
    /// Either one or more space-separated values at which the divider should snap, in pixels, percentages, or repeat expressions e.g. `'100px 50% 500px' or `repeat(50%) 10px`, or a function which takes in a `SnapFunctionParams`, and returns a position to snap to, e.g. `({ pos }) =&gt; Math.round(pos / 8) * 8`.
    /// </summary>
    public static void SetSnap<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<int> snap) where T: SlSplitPanel
    {
        b.SetProperty(b.Props, b.Const("snap"), snap);
    }

    /// <summary>
    /// Either one or more space-separated values at which the divider should snap, in pixels, percentages, or repeat expressions e.g. `'100px 50% 500px' or `repeat(50%) 10px`, or a function which takes in a `SnapFunctionParams`, and returns a position to snap to, e.g. `({ pos }) =&gt; Math.round(pos / 8) * 8`.
    /// </summary>
    public static void SetSnap<T>(this Metapsi.Syntax.PropsBuilder<T> b, int snap) where T: SlSplitPanel
    {
        b.SetSnap(b.Const(snap));
    }

    /// <summary>
    /// How close the divider must be to a snap point until snapping occurs.
    /// </summary>
    public static void SetSnapThreshold<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<int> snapThreshold) where T: SlSplitPanel
    {
        b.SetProperty(b.Props, b.Const("snapThreshold"), snapThreshold);
    }

    /// <summary>
    /// How close the divider must be to a snap point until snapping occurs.
    /// </summary>
    public static void SetSnapThreshold<T>(this Metapsi.Syntax.PropsBuilder<T> b, int snapThreshold) where T: SlSplitPanel
    {
        b.SetSnapThreshold(b.Const(snapThreshold));
    }

    /// <summary>
    /// How close the divider must be to a snap point until snapping occurs.
    /// </summary>
    public static void SetSnapThreshold<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<decimal> snapThreshold) where T: SlSplitPanel
    {
        b.SetProperty(b.Props, b.Const("snapThreshold"), snapThreshold);
    }

    /// <summary>
    /// How close the divider must be to a snap point until snapping occurs.
    /// </summary>
    public static void SetSnapThreshold<T>(this Metapsi.Syntax.PropsBuilder<T> b, decimal snapThreshold) where T: SlSplitPanel
    {
        b.SetSnapThreshold(b.Const(snapThreshold));
    }

    /// <summary>
    /// Emitted when the divider's position changes.
    /// </summary>
    public static void OnSlReposition<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: SlSplitPanel
    {
        b.OnSlEvent("onsl-reposition", action);
    }

    /// <summary>
    /// Emitted when the divider's position changes.
    /// </summary>
    public static void OnSlReposition<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: SlSplitPanel
    {
        b.OnSlReposition(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the divider's position changes.
    /// </summary>
    public static void OnSlReposition<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: SlSplitPanel
    {
        b.OnSlEvent("onsl-reposition", action);
    }

    /// <summary>
    /// Emitted when the divider's position changes.
    /// </summary>
    public static void OnSlReposition<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: SlSplitPanel
    {
        b.OnSlReposition(b.MakeAction(action));
    }

}