using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Shoelace;


public partial class SlTooltip
{
    /// <summary>
    ///
    /// </summary>
    public static class Slot
    {
        /// <summary>
        /// <para> The content to render in the tooltip. Alternatively, you can use the `content` attribute. </para>
        /// </summary>
        public const string Content = "content";
    }
    public static class Method
    {
        /// <summary>
        /// <para> Shows the tooltip. </para>
        /// </summary>
        public const string Show = "show";
        /// <summary>
        /// <para> Hides the tooltip </para>
        /// </summary>
        public const string Hide = "hide";
    }
}

public static partial class SlTooltipControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlTooltip(this HtmlBuilder b, Action<AttributesBuilder<SlTooltip>> buildAttributes, params IHtmlNode[] children)
    {
        return b.SlTag("sl-tooltip", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlTooltip(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.SlTag("sl-tooltip", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlTooltip(this HtmlBuilder b, Action<AttributesBuilder<SlTooltip>> buildAttributes, List<IHtmlNode> children)
    {
        return b.SlTag("sl-tooltip", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlTooltip(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.SlTag("sl-tooltip", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The tooltip's content. If you need to display HTML, use the `content` slot instead. </para>
    /// </summary>
    public static void SetContent(this AttributesBuilder<SlTooltip> b, string content)
    {
        b.SetAttribute("content", content);
    }

    /// <summary>
    /// <para> The preferred placement of the tooltip. Note that the actual placement may vary as needed to keep the tooltip inside of the viewport. </para>
    /// </summary>
    public static void SetPlacement(this AttributesBuilder<SlTooltip> b, string placement)
    {
        b.SetAttribute("placement", placement);
    }

    /// <summary>
    /// <para> The preferred placement of the tooltip. Note that the actual placement may vary as needed to keep the tooltip inside of the viewport. </para>
    /// </summary>
    public static void SetPlacementTop(this AttributesBuilder<SlTooltip> b)
    {
        b.SetAttribute("placement", "top");
    }

    /// <summary>
    /// <para> The preferred placement of the tooltip. Note that the actual placement may vary as needed to keep the tooltip inside of the viewport. </para>
    /// </summary>
    public static void SetPlacementTopStart(this AttributesBuilder<SlTooltip> b)
    {
        b.SetAttribute("placement", "top-start");
    }

    /// <summary>
    /// <para> The preferred placement of the tooltip. Note that the actual placement may vary as needed to keep the tooltip inside of the viewport. </para>
    /// </summary>
    public static void SetPlacementTopEnd(this AttributesBuilder<SlTooltip> b)
    {
        b.SetAttribute("placement", "top-end");
    }

    /// <summary>
    /// <para> The preferred placement of the tooltip. Note that the actual placement may vary as needed to keep the tooltip inside of the viewport. </para>
    /// </summary>
    public static void SetPlacementRight(this AttributesBuilder<SlTooltip> b)
    {
        b.SetAttribute("placement", "right");
    }

    /// <summary>
    /// <para> The preferred placement of the tooltip. Note that the actual placement may vary as needed to keep the tooltip inside of the viewport. </para>
    /// </summary>
    public static void SetPlacementRightStart(this AttributesBuilder<SlTooltip> b)
    {
        b.SetAttribute("placement", "right-start");
    }

    /// <summary>
    /// <para> The preferred placement of the tooltip. Note that the actual placement may vary as needed to keep the tooltip inside of the viewport. </para>
    /// </summary>
    public static void SetPlacementRightEnd(this AttributesBuilder<SlTooltip> b)
    {
        b.SetAttribute("placement", "right-end");
    }

    /// <summary>
    /// <para> The preferred placement of the tooltip. Note that the actual placement may vary as needed to keep the tooltip inside of the viewport. </para>
    /// </summary>
    public static void SetPlacementBottom(this AttributesBuilder<SlTooltip> b)
    {
        b.SetAttribute("placement", "bottom");
    }

    /// <summary>
    /// <para> The preferred placement of the tooltip. Note that the actual placement may vary as needed to keep the tooltip inside of the viewport. </para>
    /// </summary>
    public static void SetPlacementBottomStart(this AttributesBuilder<SlTooltip> b)
    {
        b.SetAttribute("placement", "bottom-start");
    }

    /// <summary>
    /// <para> The preferred placement of the tooltip. Note that the actual placement may vary as needed to keep the tooltip inside of the viewport. </para>
    /// </summary>
    public static void SetPlacementBottomEnd(this AttributesBuilder<SlTooltip> b)
    {
        b.SetAttribute("placement", "bottom-end");
    }

    /// <summary>
    /// <para> The preferred placement of the tooltip. Note that the actual placement may vary as needed to keep the tooltip inside of the viewport. </para>
    /// </summary>
    public static void SetPlacementLeft(this AttributesBuilder<SlTooltip> b)
    {
        b.SetAttribute("placement", "left");
    }

    /// <summary>
    /// <para> The preferred placement of the tooltip. Note that the actual placement may vary as needed to keep the tooltip inside of the viewport. </para>
    /// </summary>
    public static void SetPlacementLeftStart(this AttributesBuilder<SlTooltip> b)
    {
        b.SetAttribute("placement", "left-start");
    }

    /// <summary>
    /// <para> The preferred placement of the tooltip. Note that the actual placement may vary as needed to keep the tooltip inside of the viewport. </para>
    /// </summary>
    public static void SetPlacementLeftEnd(this AttributesBuilder<SlTooltip> b)
    {
        b.SetAttribute("placement", "left-end");
    }

    /// <summary>
    /// <para> Disables the tooltip so it won't show when triggered. </para>
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<SlTooltip> b)
    {
        b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// <para> Disables the tooltip so it won't show when triggered. </para>
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<SlTooltip> b, bool disabled)
    {
        if (disabled) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// <para> The distance in pixels from which to offset the tooltip away from its target. </para>
    /// </summary>
    public static void SetDistance(this AttributesBuilder<SlTooltip> b, string distance)
    {
        b.SetAttribute("distance", distance);
    }

    /// <summary>
    /// <para> Indicates whether or not the tooltip is open. You can use this in lieu of the show/hide methods. </para>
    /// </summary>
    public static void SetOpen(this AttributesBuilder<SlTooltip> b)
    {
        b.SetAttribute("open", "");
    }

    /// <summary>
    /// <para> Indicates whether or not the tooltip is open. You can use this in lieu of the show/hide methods. </para>
    /// </summary>
    public static void SetOpen(this AttributesBuilder<SlTooltip> b, bool open)
    {
        if (open) b.SetAttribute("open", "");
    }

    /// <summary>
    /// <para> The distance in pixels from which to offset the tooltip along its target. </para>
    /// </summary>
    public static void SetSkidding(this AttributesBuilder<SlTooltip> b, string skidding)
    {
        b.SetAttribute("skidding", skidding);
    }

    /// <summary>
    /// <para> Controls how the tooltip is activated. Possible options include `click`, `hover`, `focus`, and `manual`. Multiple options can be passed by separating them with a space. When manual is used, the tooltip must be activated programmatically. </para>
    /// </summary>
    public static void SetTrigger(this AttributesBuilder<SlTooltip> b, string trigger)
    {
        b.SetAttribute("trigger", trigger);
    }

    /// <summary>
    /// <para> Enable this option to prevent the tooltip from being clipped when the component is placed inside a container with `overflow: auto|hidden|scroll`. Hoisting uses a fixed positioning strategy that works in many, but not all, scenarios. </para>
    /// </summary>
    public static void SetHoist(this AttributesBuilder<SlTooltip> b)
    {
        b.SetAttribute("hoist", "");
    }

    /// <summary>
    /// <para> Enable this option to prevent the tooltip from being clipped when the component is placed inside a container with `overflow: auto|hidden|scroll`. Hoisting uses a fixed positioning strategy that works in many, but not all, scenarios. </para>
    /// </summary>
    public static void SetHoist(this AttributesBuilder<SlTooltip> b, bool hoist)
    {
        if (hoist) b.SetAttribute("hoist", "");
    }

    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlTooltip(this LayoutBuilder b, Action<PropsBuilder<SlTooltip>> buildProps, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-tooltip", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlTooltip(this LayoutBuilder b, Action<PropsBuilder<SlTooltip>> buildProps, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-tooltip", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlTooltip(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-tooltip", children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlTooltip(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-tooltip", children);
    }
    /// <summary>
    /// <para> The tooltip's content. If you need to display HTML, use the `content` slot instead. </para>
    /// </summary>
    public static void SetContent<T>(this PropsBuilder<T> b, Var<string> content) where T: SlTooltip
    {
        b.SetProperty(b.Props, b.Const("content"), content);
    }

    /// <summary>
    /// <para> The tooltip's content. If you need to display HTML, use the `content` slot instead. </para>
    /// </summary>
    public static void SetContent<T>(this PropsBuilder<T> b, string content) where T: SlTooltip
    {
        b.SetProperty(b.Props, b.Const("content"), b.Const(content));
    }


    /// <summary>
    /// <para> The preferred placement of the tooltip. Note that the actual placement may vary as needed to keep the tooltip inside of the viewport. </para>
    /// </summary>
    public static void SetPlacementTop<T>(this PropsBuilder<T> b) where T: SlTooltip
    {
        b.SetProperty(b.Props, b.Const("placement"), b.Const("top"));
    }


    /// <summary>
    /// <para> The preferred placement of the tooltip. Note that the actual placement may vary as needed to keep the tooltip inside of the viewport. </para>
    /// </summary>
    public static void SetPlacementTopStart<T>(this PropsBuilder<T> b) where T: SlTooltip
    {
        b.SetProperty(b.Props, b.Const("placement"), b.Const("top-start"));
    }


    /// <summary>
    /// <para> The preferred placement of the tooltip. Note that the actual placement may vary as needed to keep the tooltip inside of the viewport. </para>
    /// </summary>
    public static void SetPlacementTopEnd<T>(this PropsBuilder<T> b) where T: SlTooltip
    {
        b.SetProperty(b.Props, b.Const("placement"), b.Const("top-end"));
    }


    /// <summary>
    /// <para> The preferred placement of the tooltip. Note that the actual placement may vary as needed to keep the tooltip inside of the viewport. </para>
    /// </summary>
    public static void SetPlacementRight<T>(this PropsBuilder<T> b) where T: SlTooltip
    {
        b.SetProperty(b.Props, b.Const("placement"), b.Const("right"));
    }


    /// <summary>
    /// <para> The preferred placement of the tooltip. Note that the actual placement may vary as needed to keep the tooltip inside of the viewport. </para>
    /// </summary>
    public static void SetPlacementRightStart<T>(this PropsBuilder<T> b) where T: SlTooltip
    {
        b.SetProperty(b.Props, b.Const("placement"), b.Const("right-start"));
    }


    /// <summary>
    /// <para> The preferred placement of the tooltip. Note that the actual placement may vary as needed to keep the tooltip inside of the viewport. </para>
    /// </summary>
    public static void SetPlacementRightEnd<T>(this PropsBuilder<T> b) where T: SlTooltip
    {
        b.SetProperty(b.Props, b.Const("placement"), b.Const("right-end"));
    }


    /// <summary>
    /// <para> The preferred placement of the tooltip. Note that the actual placement may vary as needed to keep the tooltip inside of the viewport. </para>
    /// </summary>
    public static void SetPlacementBottom<T>(this PropsBuilder<T> b) where T: SlTooltip
    {
        b.SetProperty(b.Props, b.Const("placement"), b.Const("bottom"));
    }


    /// <summary>
    /// <para> The preferred placement of the tooltip. Note that the actual placement may vary as needed to keep the tooltip inside of the viewport. </para>
    /// </summary>
    public static void SetPlacementBottomStart<T>(this PropsBuilder<T> b) where T: SlTooltip
    {
        b.SetProperty(b.Props, b.Const("placement"), b.Const("bottom-start"));
    }


    /// <summary>
    /// <para> The preferred placement of the tooltip. Note that the actual placement may vary as needed to keep the tooltip inside of the viewport. </para>
    /// </summary>
    public static void SetPlacementBottomEnd<T>(this PropsBuilder<T> b) where T: SlTooltip
    {
        b.SetProperty(b.Props, b.Const("placement"), b.Const("bottom-end"));
    }


    /// <summary>
    /// <para> The preferred placement of the tooltip. Note that the actual placement may vary as needed to keep the tooltip inside of the viewport. </para>
    /// </summary>
    public static void SetPlacementLeft<T>(this PropsBuilder<T> b) where T: SlTooltip
    {
        b.SetProperty(b.Props, b.Const("placement"), b.Const("left"));
    }


    /// <summary>
    /// <para> The preferred placement of the tooltip. Note that the actual placement may vary as needed to keep the tooltip inside of the viewport. </para>
    /// </summary>
    public static void SetPlacementLeftStart<T>(this PropsBuilder<T> b) where T: SlTooltip
    {
        b.SetProperty(b.Props, b.Const("placement"), b.Const("left-start"));
    }


    /// <summary>
    /// <para> The preferred placement of the tooltip. Note that the actual placement may vary as needed to keep the tooltip inside of the viewport. </para>
    /// </summary>
    public static void SetPlacementLeftEnd<T>(this PropsBuilder<T> b) where T: SlTooltip
    {
        b.SetProperty(b.Props, b.Const("placement"), b.Const("left-end"));
    }


    /// <summary>
    /// <para> Disables the tooltip so it won't show when triggered. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b) where T: SlTooltip
    {
        b.SetProperty(b.Props, b.Const("disabled"), b.Const(true));
    }


    /// <summary>
    /// <para> Disables the tooltip so it won't show when triggered. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, Var<bool> disabled) where T: SlTooltip
    {
        b.SetProperty(b.Props, b.Const("disabled"), disabled);
    }

    /// <summary>
    /// <para> Disables the tooltip so it won't show when triggered. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, bool disabled) where T: SlTooltip
    {
        b.SetProperty(b.Props, b.Const("disabled"), b.Const(disabled));
    }


    /// <summary>
    /// <para> The distance in pixels from which to offset the tooltip away from its target. </para>
    /// </summary>
    public static void SetDistance<T>(this PropsBuilder<T> b, Var<int> distance) where T: SlTooltip
    {
        b.SetProperty(b.Props, b.Const("distance"), distance);
    }

    /// <summary>
    /// <para> The distance in pixels from which to offset the tooltip away from its target. </para>
    /// </summary>
    public static void SetDistance<T>(this PropsBuilder<T> b, int distance) where T: SlTooltip
    {
        b.SetProperty(b.Props, b.Const("distance"), b.Const(distance));
    }


    /// <summary>
    /// <para> Indicates whether or not the tooltip is open. You can use this in lieu of the show/hide methods. </para>
    /// </summary>
    public static void SetOpen<T>(this PropsBuilder<T> b) where T: SlTooltip
    {
        b.SetProperty(b.Props, b.Const("open"), b.Const(true));
    }


    /// <summary>
    /// <para> Indicates whether or not the tooltip is open. You can use this in lieu of the show/hide methods. </para>
    /// </summary>
    public static void SetOpen<T>(this PropsBuilder<T> b, Var<bool> open) where T: SlTooltip
    {
        b.SetProperty(b.Props, b.Const("open"), open);
    }

    /// <summary>
    /// <para> Indicates whether or not the tooltip is open. You can use this in lieu of the show/hide methods. </para>
    /// </summary>
    public static void SetOpen<T>(this PropsBuilder<T> b, bool open) where T: SlTooltip
    {
        b.SetProperty(b.Props, b.Const("open"), b.Const(open));
    }


    /// <summary>
    /// <para> The distance in pixels from which to offset the tooltip along its target. </para>
    /// </summary>
    public static void SetSkidding<T>(this PropsBuilder<T> b, Var<int> skidding) where T: SlTooltip
    {
        b.SetProperty(b.Props, b.Const("skidding"), skidding);
    }

    /// <summary>
    /// <para> The distance in pixels from which to offset the tooltip along its target. </para>
    /// </summary>
    public static void SetSkidding<T>(this PropsBuilder<T> b, int skidding) where T: SlTooltip
    {
        b.SetProperty(b.Props, b.Const("skidding"), b.Const(skidding));
    }


    /// <summary>
    /// <para> Controls how the tooltip is activated. Possible options include `click`, `hover`, `focus`, and `manual`. Multiple options can be passed by separating them with a space. When manual is used, the tooltip must be activated programmatically. </para>
    /// </summary>
    public static void SetTrigger<T>(this PropsBuilder<T> b, Var<string> trigger) where T: SlTooltip
    {
        b.SetProperty(b.Props, b.Const("trigger"), trigger);
    }

    /// <summary>
    /// <para> Controls how the tooltip is activated. Possible options include `click`, `hover`, `focus`, and `manual`. Multiple options can be passed by separating them with a space. When manual is used, the tooltip must be activated programmatically. </para>
    /// </summary>
    public static void SetTrigger<T>(this PropsBuilder<T> b, string trigger) where T: SlTooltip
    {
        b.SetProperty(b.Props, b.Const("trigger"), b.Const(trigger));
    }


    /// <summary>
    /// <para> Enable this option to prevent the tooltip from being clipped when the component is placed inside a container with `overflow: auto|hidden|scroll`. Hoisting uses a fixed positioning strategy that works in many, but not all, scenarios. </para>
    /// </summary>
    public static void SetHoist<T>(this PropsBuilder<T> b) where T: SlTooltip
    {
        b.SetProperty(b.Props, b.Const("hoist"), b.Const(true));
    }


    /// <summary>
    /// <para> Enable this option to prevent the tooltip from being clipped when the component is placed inside a container with `overflow: auto|hidden|scroll`. Hoisting uses a fixed positioning strategy that works in many, but not all, scenarios. </para>
    /// </summary>
    public static void SetHoist<T>(this PropsBuilder<T> b, Var<bool> hoist) where T: SlTooltip
    {
        b.SetProperty(b.Props, b.Const("hoist"), hoist);
    }

    /// <summary>
    /// <para> Enable this option to prevent the tooltip from being clipped when the component is placed inside a container with `overflow: auto|hidden|scroll`. Hoisting uses a fixed positioning strategy that works in many, but not all, scenarios. </para>
    /// </summary>
    public static void SetHoist<T>(this PropsBuilder<T> b, bool hoist) where T: SlTooltip
    {
        b.SetProperty(b.Props, b.Const("hoist"), b.Const(hoist));
    }


    /// <summary>
    /// <para> Emitted when the tooltip begins to show. </para>
    /// </summary>
    public static void OnSlShow<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, Event>> action) where TComponent: SlTooltip
    {
        b.OnEventAction("onsl-show", action);
    }
    /// <summary>
    /// <para> Emitted when the tooltip begins to show. </para>
    /// </summary>
    public static void OnSlShow<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<Event>, Var<TModel>> action) where TComponent: SlTooltip
    {
        b.OnEventAction("onsl-show", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the tooltip begins to show. </para>
    /// </summary>
    public static void OnSlShow<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: SlTooltip
    {
        b.OnEventAction("onsl-show", action);
    }
    /// <summary>
    /// <para> Emitted when the tooltip begins to show. </para>
    /// </summary>
    public static void OnSlShow<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: SlTooltip
    {
        b.OnEventAction("onsl-show", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted after the tooltip has shown and all animations are complete. </para>
    /// </summary>
    public static void OnSlAfterShow<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, Event>> action) where TComponent: SlTooltip
    {
        b.OnEventAction("onsl-after-show", action);
    }
    /// <summary>
    /// <para> Emitted after the tooltip has shown and all animations are complete. </para>
    /// </summary>
    public static void OnSlAfterShow<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<Event>, Var<TModel>> action) where TComponent: SlTooltip
    {
        b.OnEventAction("onsl-after-show", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted after the tooltip has shown and all animations are complete. </para>
    /// </summary>
    public static void OnSlAfterShow<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: SlTooltip
    {
        b.OnEventAction("onsl-after-show", action);
    }
    /// <summary>
    /// <para> Emitted after the tooltip has shown and all animations are complete. </para>
    /// </summary>
    public static void OnSlAfterShow<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: SlTooltip
    {
        b.OnEventAction("onsl-after-show", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the tooltip begins to hide. </para>
    /// </summary>
    public static void OnSlHide<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, Event>> action) where TComponent: SlTooltip
    {
        b.OnEventAction("onsl-hide", action);
    }
    /// <summary>
    /// <para> Emitted when the tooltip begins to hide. </para>
    /// </summary>
    public static void OnSlHide<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<Event>, Var<TModel>> action) where TComponent: SlTooltip
    {
        b.OnEventAction("onsl-hide", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the tooltip begins to hide. </para>
    /// </summary>
    public static void OnSlHide<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: SlTooltip
    {
        b.OnEventAction("onsl-hide", action);
    }
    /// <summary>
    /// <para> Emitted when the tooltip begins to hide. </para>
    /// </summary>
    public static void OnSlHide<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: SlTooltip
    {
        b.OnEventAction("onsl-hide", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted after the tooltip has hidden and all animations are complete. </para>
    /// </summary>
    public static void OnSlAfterHide<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, Event>> action) where TComponent: SlTooltip
    {
        b.OnEventAction("onsl-after-hide", action);
    }
    /// <summary>
    /// <para> Emitted after the tooltip has hidden and all animations are complete. </para>
    /// </summary>
    public static void OnSlAfterHide<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<Event>, Var<TModel>> action) where TComponent: SlTooltip
    {
        b.OnEventAction("onsl-after-hide", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted after the tooltip has hidden and all animations are complete. </para>
    /// </summary>
    public static void OnSlAfterHide<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: SlTooltip
    {
        b.OnEventAction("onsl-after-hide", action);
    }
    /// <summary>
    /// <para> Emitted after the tooltip has hidden and all animations are complete. </para>
    /// </summary>
    public static void OnSlAfterHide<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: SlTooltip
    {
        b.OnEventAction("onsl-after-hide", b.MakeAction(action));
    }

}

