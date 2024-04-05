using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Shoelace;


public partial class SlSplitPanel : SlComponent
{
    public SlSplitPanel() : base("sl-split-panel") { }
    /// <summary>
    /// The current position of the divider from the primary panel's edge as a percentage 0-100. Defaults to 50% of the container's initial size.
    /// </summary>
    public int position
    {
        get
        {
            return this.GetTag().GetAttribute<int>("position");
        }
        set
        {
            this.GetTag().SetAttribute("position", value.ToString());
        }
    }

    /// <summary>
    /// The current position of the divider from the primary panel's edge in pixels.
    /// </summary>
    public int positionInPixels
    {
        get
        {
            return this.GetTag().GetAttribute<int>("position-in-pixels");
        }
        set
        {
            this.GetTag().SetAttribute("position-in-pixels", value.ToString());
        }
    }

    /// <summary>
    /// Draws the split panel in a vertical orientation with the start and end panels stacked.
    /// </summary>
    public bool vertical
    {
        get
        {
            return this.GetTag().GetAttribute<bool>("vertical");
        }
        set
        {
            if (!value) return;
            this.GetTag().SetAttribute("vertical", value.ToString());
        }
    }

    /// <summary>
    /// Disables resizing. Note that the position may still change as a result of resizing the host element.
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
    /// If no primary panel is designated, both panels will resize proportionally when the host element is resized. If a primary panel is designated, it will maintain its size and the other panel will grow or shrink as needed when the host element is resized.
    /// </summary>
    public string primary
    {
        get
        {
            return this.GetTag().GetAttribute<string>("primary");
        }
        set
        {
            this.GetTag().SetAttribute("primary", value.ToString());
        }
    }

    /// <summary>
    /// One or more space-separated values at which the divider should snap. Values can be in pixels or percentages, e.g. `"100px 50%"`.
    /// </summary>
    public string snap
    {
        get
        {
            return this.GetTag().GetAttribute<string>("snap");
        }
        set
        {
            this.GetTag().SetAttribute("snap", value.ToString());
        }
    }

    /// <summary>
    /// How close the divider must be to a snap point until snapping occurs.
    /// </summary>
    public int snapThreshold
    {
        get
        {
            return this.GetTag().GetAttribute<int>("snap-threshold");
        }
        set
        {
            this.GetTag().SetAttribute("snap-threshold", value.ToString());
        }
    }

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
}

public static partial class SlSplitPanelControl
{
    /// <summary>
    /// Split panels display two adjacent panels, allowing the user to reposition them.
    /// </summary>
    public static Var<IVNode> SlSplitPanel(this LayoutBuilder b, Action<PropsBuilder<SlSplitPanel>> buildProps, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-split-panel", buildProps, children);
    }
    /// <summary>
    /// Split panels display two adjacent panels, allowing the user to reposition them.
    /// </summary>
    public static Var<IVNode> SlSplitPanel(this LayoutBuilder b, Action<PropsBuilder<SlSplitPanel>> buildProps, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-split-panel", buildProps, children);
    }
    /// <summary>
    /// The current position of the divider from the primary panel's edge as a percentage 0-100. Defaults to 50% of the container's initial size.
    /// </summary>
    public static void SetPosition(this PropsBuilder<SlSplitPanel> b, Var<int> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("position"), value);
    }
    /// <summary>
    /// The current position of the divider from the primary panel's edge as a percentage 0-100. Defaults to 50% of the container's initial size.
    /// </summary>
    public static void SetPosition(this PropsBuilder<SlSplitPanel> b, int value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("position"), b.Const(value));
    }

    /// <summary>
    /// The current position of the divider from the primary panel's edge in pixels.
    /// </summary>
    public static void SetPositionInPixels(this PropsBuilder<SlSplitPanel> b, Var<int> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("position-in-pixels"), value);
    }
    /// <summary>
    /// The current position of the divider from the primary panel's edge in pixels.
    /// </summary>
    public static void SetPositionInPixels(this PropsBuilder<SlSplitPanel> b, int value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("position-in-pixels"), b.Const(value));
    }

    /// <summary>
    /// Draws the split panel in a vertical orientation with the start and end panels stacked.
    /// </summary>
    public static void SetVertical(this PropsBuilder<SlSplitPanel> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("vertical"), b.Const(string.Empty));
    }

    /// <summary>
    /// Disables resizing. Note that the position may still change as a result of resizing the host element.
    /// </summary>
    public static void SetDisabled(this PropsBuilder<SlSplitPanel> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("disabled"), b.Const(string.Empty));
    }

    /// <summary>
    /// If no primary panel is designated, both panels will resize proportionally when the host element is resized. If a primary panel is designated, it will maintain its size and the other panel will grow or shrink as needed when the host element is resized.
    /// </summary>
    public static void SetPrimaryStart(this PropsBuilder<SlSplitPanel> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("primary"), b.Const("start"));
    }
    /// <summary>
    /// If no primary panel is designated, both panels will resize proportionally when the host element is resized. If a primary panel is designated, it will maintain its size and the other panel will grow or shrink as needed when the host element is resized.
    /// </summary>
    public static void SetPrimaryEnd(this PropsBuilder<SlSplitPanel> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("primary"), b.Const("end"));
    }

    /// <summary>
    /// One or more space-separated values at which the divider should snap. Values can be in pixels or percentages, e.g. `"100px 50%"`.
    /// </summary>
    public static void SetSnap(this PropsBuilder<SlSplitPanel> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("snap"), value);
    }
    /// <summary>
    /// One or more space-separated values at which the divider should snap. Values can be in pixels or percentages, e.g. `"100px 50%"`.
    /// </summary>
    public static void SetSnap(this PropsBuilder<SlSplitPanel> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("snap"), b.Const(value));
    }

    /// <summary>
    /// How close the divider must be to a snap point until snapping occurs.
    /// </summary>
    public static void SetSnapThreshold(this PropsBuilder<SlSplitPanel> b, Var<int> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("snap-threshold"), value);
    }
    /// <summary>
    /// How close the divider must be to a snap point until snapping occurs.
    /// </summary>
    public static void SetSnapThreshold(this PropsBuilder<SlSplitPanel> b, int value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("snap-threshold"), b.Const(value));
    }

    /// <summary>
    /// Emitted when the divider's position changes.
    /// </summary>
    public static void OnSlReposition<TModel>(this PropsBuilder<SlSplitPanel> b, Var<HyperType.Action<TModel, DomEvent>> action)
    {
        b.OnEventAction("onsl-reposition", action);
    }
    /// <summary>
    /// Emitted when the divider's position changes.
    /// </summary>
    public static void OnSlReposition<TModel>(this PropsBuilder<SlSplitPanel> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-reposition", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the divider's position changes.
    /// </summary>
    public static void OnSlReposition<TModel>(this PropsBuilder<SlSplitPanel> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onsl-reposition", action);
    }
    /// <summary>
    /// Emitted when the divider's position changes.
    /// </summary>
    public static void OnSlReposition<TModel>(this PropsBuilder<SlSplitPanel> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-reposition", b.MakeAction(action));
    }

}

