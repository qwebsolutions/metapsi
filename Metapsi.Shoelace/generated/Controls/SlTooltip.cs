using Metapsi.Html;
using Metapsi.Syntax;
using Metapsi.Hyperapp;

namespace Metapsi.Shoelace;

/// <summary>
/// Tooltips display additional information based on a specific action.
/// </summary>
public partial class SlTooltip
{
    /// <summary>
    /// 
    /// </summary>
    public static class Slot
    {
        /// <summary>
        /// The content to render in the tooltip. Alternatively, you can use the `content` attribute.
        /// </summary>
        public const string Content = "content";
    }
    /// <summary>
    /// 
    /// </summary>
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
/// <summary>
/// Setter extensions of SlTooltip
/// </summary>
public static partial class SlTooltipControl
{
    /// <summary>
    /// Tooltips display additional information based on a specific action.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlTooltip(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlTooltip>> buildAttributes, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-tooltip", buildAttributes, children);
    }

    /// <summary>
    /// Tooltips display additional information based on a specific action.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlTooltip(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-tooltip", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// Tooltips display additional information based on a specific action.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlTooltip(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlTooltip>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-tooltip", buildAttributes, children);
    }

    /// <summary>
    /// Tooltips display additional information based on a specific action.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlTooltip(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-tooltip", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// The tooltip's content. If you need to display HTML, use the `content` slot instead.
    /// </summary>
    public static void SetContent(this Metapsi.Html.AttributesBuilder<SlTooltip> b, string content) 
    {
        b.SetAttribute("content", content);
    }

    /// <summary>
    /// The preferred placement of the tooltip. Note that the actual placement may vary as needed to keep the tooltip inside of the viewport.
    /// </summary>
    public static void SetPlacementTop(this Metapsi.Html.AttributesBuilder<SlTooltip> b) 
    {
        b.SetAttribute("placement", "top");
    }

    /// <summary>
    /// The preferred placement of the tooltip. Note that the actual placement may vary as needed to keep the tooltip inside of the viewport.
    /// </summary>
    public static void SetPlacementTopStart(this Metapsi.Html.AttributesBuilder<SlTooltip> b) 
    {
        b.SetAttribute("placement", "top-start");
    }

    /// <summary>
    /// The preferred placement of the tooltip. Note that the actual placement may vary as needed to keep the tooltip inside of the viewport.
    /// </summary>
    public static void SetPlacementTopEnd(this Metapsi.Html.AttributesBuilder<SlTooltip> b) 
    {
        b.SetAttribute("placement", "top-end");
    }

    /// <summary>
    /// The preferred placement of the tooltip. Note that the actual placement may vary as needed to keep the tooltip inside of the viewport.
    /// </summary>
    public static void SetPlacementRight(this Metapsi.Html.AttributesBuilder<SlTooltip> b) 
    {
        b.SetAttribute("placement", "right");
    }

    /// <summary>
    /// The preferred placement of the tooltip. Note that the actual placement may vary as needed to keep the tooltip inside of the viewport.
    /// </summary>
    public static void SetPlacementRightStart(this Metapsi.Html.AttributesBuilder<SlTooltip> b) 
    {
        b.SetAttribute("placement", "right-start");
    }

    /// <summary>
    /// The preferred placement of the tooltip. Note that the actual placement may vary as needed to keep the tooltip inside of the viewport.
    /// </summary>
    public static void SetPlacementRightEnd(this Metapsi.Html.AttributesBuilder<SlTooltip> b) 
    {
        b.SetAttribute("placement", "right-end");
    }

    /// <summary>
    /// The preferred placement of the tooltip. Note that the actual placement may vary as needed to keep the tooltip inside of the viewport.
    /// </summary>
    public static void SetPlacementBottom(this Metapsi.Html.AttributesBuilder<SlTooltip> b) 
    {
        b.SetAttribute("placement", "bottom");
    }

    /// <summary>
    /// The preferred placement of the tooltip. Note that the actual placement may vary as needed to keep the tooltip inside of the viewport.
    /// </summary>
    public static void SetPlacementBottomStart(this Metapsi.Html.AttributesBuilder<SlTooltip> b) 
    {
        b.SetAttribute("placement", "bottom-start");
    }

    /// <summary>
    /// The preferred placement of the tooltip. Note that the actual placement may vary as needed to keep the tooltip inside of the viewport.
    /// </summary>
    public static void SetPlacementBottomEnd(this Metapsi.Html.AttributesBuilder<SlTooltip> b) 
    {
        b.SetAttribute("placement", "bottom-end");
    }

    /// <summary>
    /// The preferred placement of the tooltip. Note that the actual placement may vary as needed to keep the tooltip inside of the viewport.
    /// </summary>
    public static void SetPlacementLeft(this Metapsi.Html.AttributesBuilder<SlTooltip> b) 
    {
        b.SetAttribute("placement", "left");
    }

    /// <summary>
    /// The preferred placement of the tooltip. Note that the actual placement may vary as needed to keep the tooltip inside of the viewport.
    /// </summary>
    public static void SetPlacementLeftStart(this Metapsi.Html.AttributesBuilder<SlTooltip> b) 
    {
        b.SetAttribute("placement", "left-start");
    }

    /// <summary>
    /// The preferred placement of the tooltip. Note that the actual placement may vary as needed to keep the tooltip inside of the viewport.
    /// </summary>
    public static void SetPlacementLeftEnd(this Metapsi.Html.AttributesBuilder<SlTooltip> b) 
    {
        b.SetAttribute("placement", "left-end");
    }

    /// <summary>
    /// Disables the tooltip so it won't show when triggered.
    /// </summary>
    public static void SetDisabled(this Metapsi.Html.AttributesBuilder<SlTooltip> b, bool disabled) 
    {
        if (disabled) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// Disables the tooltip so it won't show when triggered.
    /// </summary>
    public static void SetDisabled(this Metapsi.Html.AttributesBuilder<SlTooltip> b) 
    {
        b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// Indicates whether or not the tooltip is open. You can use this in lieu of the show/hide methods.
    /// </summary>
    public static void SetOpen(this Metapsi.Html.AttributesBuilder<SlTooltip> b, bool open) 
    {
        if (open) b.SetAttribute("open", "");
    }

    /// <summary>
    /// Indicates whether or not the tooltip is open. You can use this in lieu of the show/hide methods.
    /// </summary>
    public static void SetOpen(this Metapsi.Html.AttributesBuilder<SlTooltip> b) 
    {
        b.SetAttribute("open", "");
    }

    /// <summary>
    /// Controls how the tooltip is activated. Possible options include `click`, `hover`, `focus`, and `manual`. Multiple options can be passed by separating them with a space. When manual is used, the tooltip must be activated programmatically.
    /// </summary>
    public static void SetTrigger(this Metapsi.Html.AttributesBuilder<SlTooltip> b, string trigger) 
    {
        b.SetAttribute("trigger", trigger);
    }

    /// <summary>
    /// Enable this option to prevent the tooltip from being clipped when the component is placed inside a container with `overflow: auto|hidden|scroll`. Hoisting uses a fixed positioning strategy that works in many, but not all, scenarios.
    /// </summary>
    public static void SetHoist(this Metapsi.Html.AttributesBuilder<SlTooltip> b, bool hoist) 
    {
        if (hoist) b.SetAttribute("hoist", "");
    }

    /// <summary>
    /// Enable this option to prevent the tooltip from being clipped when the component is placed inside a container with `overflow: auto|hidden|scroll`. Hoisting uses a fixed positioning strategy that works in many, but not all, scenarios.
    /// </summary>
    public static void SetHoist(this Metapsi.Html.AttributesBuilder<SlTooltip> b) 
    {
        b.SetAttribute("hoist", "");
    }

    /// <summary>
    /// Tooltips display additional information based on a specific action.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlTooltip(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlTooltip>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-tooltip", buildProps, children);
    }

    /// <summary>
    /// Tooltips display additional information based on a specific action.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlTooltip(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-tooltip", children);
    }

    /// <summary>
    /// Tooltips display additional information based on a specific action.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlTooltip(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlTooltip>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-tooltip", buildProps, children);
    }

    /// <summary>
    /// Tooltips display additional information based on a specific action.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlTooltip(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-tooltip", children);
    }

    /// <summary>
    /// The tooltip's content. If you need to display HTML, use the `content` slot instead.
    /// </summary>
    public static void SetContent<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> content) where T: SlTooltip
    {
        b.SetProperty(b.Props, b.Const("content"), content);
    }

    /// <summary>
    /// The tooltip's content. If you need to display HTML, use the `content` slot instead.
    /// </summary>
    public static void SetContent<T>(this Metapsi.Syntax.PropsBuilder<T> b, string content) where T: SlTooltip
    {
        b.SetContent(b.Const(content));
    }

    /// <summary>
    /// The preferred placement of the tooltip. Note that the actual placement may vary as needed to keep the tooltip inside of the viewport.
    /// </summary>
    public static void SetPlacementTop<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlTooltip
    {
        b.SetProperty(b.Props, b.Const("placement"), b.Const("top"));
    }

    /// <summary>
    /// The preferred placement of the tooltip. Note that the actual placement may vary as needed to keep the tooltip inside of the viewport.
    /// </summary>
    public static void SetPlacementTopStart<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlTooltip
    {
        b.SetProperty(b.Props, b.Const("placement"), b.Const("top-start"));
    }

    /// <summary>
    /// The preferred placement of the tooltip. Note that the actual placement may vary as needed to keep the tooltip inside of the viewport.
    /// </summary>
    public static void SetPlacementTopEnd<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlTooltip
    {
        b.SetProperty(b.Props, b.Const("placement"), b.Const("top-end"));
    }

    /// <summary>
    /// The preferred placement of the tooltip. Note that the actual placement may vary as needed to keep the tooltip inside of the viewport.
    /// </summary>
    public static void SetPlacementRight<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlTooltip
    {
        b.SetProperty(b.Props, b.Const("placement"), b.Const("right"));
    }

    /// <summary>
    /// The preferred placement of the tooltip. Note that the actual placement may vary as needed to keep the tooltip inside of the viewport.
    /// </summary>
    public static void SetPlacementRightStart<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlTooltip
    {
        b.SetProperty(b.Props, b.Const("placement"), b.Const("right-start"));
    }

    /// <summary>
    /// The preferred placement of the tooltip. Note that the actual placement may vary as needed to keep the tooltip inside of the viewport.
    /// </summary>
    public static void SetPlacementRightEnd<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlTooltip
    {
        b.SetProperty(b.Props, b.Const("placement"), b.Const("right-end"));
    }

    /// <summary>
    /// The preferred placement of the tooltip. Note that the actual placement may vary as needed to keep the tooltip inside of the viewport.
    /// </summary>
    public static void SetPlacementBottom<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlTooltip
    {
        b.SetProperty(b.Props, b.Const("placement"), b.Const("bottom"));
    }

    /// <summary>
    /// The preferred placement of the tooltip. Note that the actual placement may vary as needed to keep the tooltip inside of the viewport.
    /// </summary>
    public static void SetPlacementBottomStart<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlTooltip
    {
        b.SetProperty(b.Props, b.Const("placement"), b.Const("bottom-start"));
    }

    /// <summary>
    /// The preferred placement of the tooltip. Note that the actual placement may vary as needed to keep the tooltip inside of the viewport.
    /// </summary>
    public static void SetPlacementBottomEnd<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlTooltip
    {
        b.SetProperty(b.Props, b.Const("placement"), b.Const("bottom-end"));
    }

    /// <summary>
    /// The preferred placement of the tooltip. Note that the actual placement may vary as needed to keep the tooltip inside of the viewport.
    /// </summary>
    public static void SetPlacementLeft<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlTooltip
    {
        b.SetProperty(b.Props, b.Const("placement"), b.Const("left"));
    }

    /// <summary>
    /// The preferred placement of the tooltip. Note that the actual placement may vary as needed to keep the tooltip inside of the viewport.
    /// </summary>
    public static void SetPlacementLeftStart<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlTooltip
    {
        b.SetProperty(b.Props, b.Const("placement"), b.Const("left-start"));
    }

    /// <summary>
    /// The preferred placement of the tooltip. Note that the actual placement may vary as needed to keep the tooltip inside of the viewport.
    /// </summary>
    public static void SetPlacementLeftEnd<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlTooltip
    {
        b.SetProperty(b.Props, b.Const("placement"), b.Const("left-end"));
    }

    /// <summary>
    /// Disables the tooltip so it won't show when triggered.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlTooltip
    {
        b.SetDisabled(b.Const(true));
    }

    /// <summary>
    /// Disables the tooltip so it won't show when triggered.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> disabled) where T: SlTooltip
    {
        b.SetProperty(b.Props, b.Const("disabled"), disabled);
    }

    /// <summary>
    /// Disables the tooltip so it won't show when triggered.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool disabled) where T: SlTooltip
    {
        b.SetDisabled(b.Const(disabled));
    }

    /// <summary>
    /// The distance in pixels from which to offset the tooltip away from its target.
    /// </summary>
    public static void SetDistance<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<decimal> distance) where T: SlTooltip
    {
        b.SetProperty(b.Props, b.Const("distance"), distance);
    }

    /// <summary>
    /// The distance in pixels from which to offset the tooltip away from its target.
    /// </summary>
    public static void SetDistance<T>(this Metapsi.Syntax.PropsBuilder<T> b, decimal distance) where T: SlTooltip
    {
        b.SetDistance(b.Const(distance));
    }

    /// <summary>
    /// Indicates whether or not the tooltip is open. You can use this in lieu of the show/hide methods.
    /// </summary>
    public static void SetOpen<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlTooltip
    {
        b.SetOpen(b.Const(true));
    }

    /// <summary>
    /// Indicates whether or not the tooltip is open. You can use this in lieu of the show/hide methods.
    /// </summary>
    public static void SetOpen<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> open) where T: SlTooltip
    {
        b.SetProperty(b.Props, b.Const("open"), open);
    }

    /// <summary>
    /// Indicates whether or not the tooltip is open. You can use this in lieu of the show/hide methods.
    /// </summary>
    public static void SetOpen<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool open) where T: SlTooltip
    {
        b.SetOpen(b.Const(open));
    }

    /// <summary>
    /// The distance in pixels from which to offset the tooltip along its target.
    /// </summary>
    public static void SetSkidding<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<decimal> skidding) where T: SlTooltip
    {
        b.SetProperty(b.Props, b.Const("skidding"), skidding);
    }

    /// <summary>
    /// The distance in pixels from which to offset the tooltip along its target.
    /// </summary>
    public static void SetSkidding<T>(this Metapsi.Syntax.PropsBuilder<T> b, decimal skidding) where T: SlTooltip
    {
        b.SetSkidding(b.Const(skidding));
    }

    /// <summary>
    /// Controls how the tooltip is activated. Possible options include `click`, `hover`, `focus`, and `manual`. Multiple options can be passed by separating them with a space. When manual is used, the tooltip must be activated programmatically.
    /// </summary>
    public static void SetTrigger<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> trigger) where T: SlTooltip
    {
        b.SetProperty(b.Props, b.Const("trigger"), trigger);
    }

    /// <summary>
    /// Controls how the tooltip is activated. Possible options include `click`, `hover`, `focus`, and `manual`. Multiple options can be passed by separating them with a space. When manual is used, the tooltip must be activated programmatically.
    /// </summary>
    public static void SetTrigger<T>(this Metapsi.Syntax.PropsBuilder<T> b, string trigger) where T: SlTooltip
    {
        b.SetTrigger(b.Const(trigger));
    }

    /// <summary>
    /// Enable this option to prevent the tooltip from being clipped when the component is placed inside a container with `overflow: auto|hidden|scroll`. Hoisting uses a fixed positioning strategy that works in many, but not all, scenarios.
    /// </summary>
    public static void SetHoist<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlTooltip
    {
        b.SetHoist(b.Const(true));
    }

    /// <summary>
    /// Enable this option to prevent the tooltip from being clipped when the component is placed inside a container with `overflow: auto|hidden|scroll`. Hoisting uses a fixed positioning strategy that works in many, but not all, scenarios.
    /// </summary>
    public static void SetHoist<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> hoist) where T: SlTooltip
    {
        b.SetProperty(b.Props, b.Const("hoist"), hoist);
    }

    /// <summary>
    /// Enable this option to prevent the tooltip from being clipped when the component is placed inside a container with `overflow: auto|hidden|scroll`. Hoisting uses a fixed positioning strategy that works in many, but not all, scenarios.
    /// </summary>
    public static void SetHoist<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool hoist) where T: SlTooltip
    {
        b.SetHoist(b.Const(hoist));
    }

    /// <summary>
    /// Emitted when the tooltip begins to show.
    /// </summary>
    public static void OnSlShow<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: SlTooltip
    {
        b.OnSlEvent("onsl-show", action);
    }

    /// <summary>
    /// Emitted when the tooltip begins to show.
    /// </summary>
    public static void OnSlShow<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: SlTooltip
    {
        b.OnSlShow(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the tooltip begins to show.
    /// </summary>
    public static void OnSlShow<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: SlTooltip
    {
        b.OnSlEvent("onsl-show", action);
    }

    /// <summary>
    /// Emitted when the tooltip begins to show.
    /// </summary>
    public static void OnSlShow<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: SlTooltip
    {
        b.OnSlShow(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the tooltip has shown and all animations are complete.
    /// </summary>
    public static void OnSlAfterShow<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: SlTooltip
    {
        b.OnSlEvent("onsl-after-show", action);
    }

    /// <summary>
    /// Emitted after the tooltip has shown and all animations are complete.
    /// </summary>
    public static void OnSlAfterShow<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: SlTooltip
    {
        b.OnSlAfterShow(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the tooltip has shown and all animations are complete.
    /// </summary>
    public static void OnSlAfterShow<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: SlTooltip
    {
        b.OnSlEvent("onsl-after-show", action);
    }

    /// <summary>
    /// Emitted after the tooltip has shown and all animations are complete.
    /// </summary>
    public static void OnSlAfterShow<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: SlTooltip
    {
        b.OnSlAfterShow(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the tooltip begins to hide.
    /// </summary>
    public static void OnSlHide<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: SlTooltip
    {
        b.OnSlEvent("onsl-hide", action);
    }

    /// <summary>
    /// Emitted when the tooltip begins to hide.
    /// </summary>
    public static void OnSlHide<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: SlTooltip
    {
        b.OnSlHide(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the tooltip begins to hide.
    /// </summary>
    public static void OnSlHide<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: SlTooltip
    {
        b.OnSlEvent("onsl-hide", action);
    }

    /// <summary>
    /// Emitted when the tooltip begins to hide.
    /// </summary>
    public static void OnSlHide<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: SlTooltip
    {
        b.OnSlHide(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the tooltip has hidden and all animations are complete.
    /// </summary>
    public static void OnSlAfterHide<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: SlTooltip
    {
        b.OnSlEvent("onsl-after-hide", action);
    }

    /// <summary>
    /// Emitted after the tooltip has hidden and all animations are complete.
    /// </summary>
    public static void OnSlAfterHide<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: SlTooltip
    {
        b.OnSlAfterHide(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the tooltip has hidden and all animations are complete.
    /// </summary>
    public static void OnSlAfterHide<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: SlTooltip
    {
        b.OnSlEvent("onsl-after-hide", action);
    }

    /// <summary>
    /// Emitted after the tooltip has hidden and all animations are complete.
    /// </summary>
    public static void OnSlAfterHide<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: SlTooltip
    {
        b.OnSlAfterHide(b.MakeAction(action));
    }

}