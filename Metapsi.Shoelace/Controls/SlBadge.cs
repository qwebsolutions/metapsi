using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Shoelace;


public partial class SlBadge : SlComponent
{
    public SlBadge() : base("sl-badge") { }
    /// <summary>
    /// The badge's theme variant.
    /// </summary>
    public string variant
    {
        get
        {
            return this.GetTag().GetAttribute<string>("variant");
        }
        set
        {
            this.GetTag().SetAttribute("variant", value.ToString());
        }
    }

    /// <summary>
    /// Draws a pill-style badge with rounded edges.
    /// </summary>
    public bool pill
    {
        get
        {
            return this.GetTag().GetAttribute<bool>("pill");
        }
        set
        {
            if (!value) return;
            this.GetTag().SetAttribute("pill", value.ToString());
        }
    }

    /// <summary>
    /// Makes the badge pulsate to draw attention.
    /// </summary>
    public bool pulse
    {
        get
        {
            return this.GetTag().GetAttribute<bool>("pulse");
        }
        set
        {
            if (!value) return;
            this.GetTag().SetAttribute("pulse", value.ToString());
        }
    }

}

public static partial class SlBadgeControl
{
    /// <summary>
    /// Badges are used to draw attention and display statuses or counts.
    /// </summary>
    public static Var<IVNode> SlBadge(this LayoutBuilder b, Action<PropsBuilder<SlBadge>> buildProps, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-badge", buildProps, children);
    }
    /// <summary>
    /// Badges are used to draw attention and display statuses or counts.
    /// </summary>
    public static Var<IVNode> SlBadge(this LayoutBuilder b, Action<PropsBuilder<SlBadge>> buildProps, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-badge", buildProps, children);
    }
    /// <summary>
    /// Badges are used to draw attention and display statuses or counts.
    /// </summary>
    public static Var<IVNode> SlBadge(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-badge", children);
    }
    /// <summary>
    /// Badges are used to draw attention and display statuses or counts.
    /// </summary>
    public static Var<IVNode> SlBadge(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-badge", children);
    }
    /// <summary>
    /// The badge's theme variant.
    /// </summary>
    public static void SetVariantPrimary(this PropsBuilder<SlBadge> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("variant"), b.Const("primary"));
    }
    /// <summary>
    /// The badge's theme variant.
    /// </summary>
    public static void SetVariantSuccess(this PropsBuilder<SlBadge> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("variant"), b.Const("success"));
    }
    /// <summary>
    /// The badge's theme variant.
    /// </summary>
    public static void SetVariantNeutral(this PropsBuilder<SlBadge> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("variant"), b.Const("neutral"));
    }
    /// <summary>
    /// The badge's theme variant.
    /// </summary>
    public static void SetVariantWarning(this PropsBuilder<SlBadge> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("variant"), b.Const("warning"));
    }
    /// <summary>
    /// The badge's theme variant.
    /// </summary>
    public static void SetVariantDanger(this PropsBuilder<SlBadge> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("variant"), b.Const("danger"));
    }

    /// <summary>
    /// Draws a pill-style badge with rounded edges.
    /// </summary>
    public static void SetPill(this PropsBuilder<SlBadge> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("pill"), b.Const(true));
    }

    /// <summary>
    /// Makes the badge pulsate to draw attention.
    /// </summary>
    public static void SetPulse(this PropsBuilder<SlBadge> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("pulse"), b.Const(true));
    }

}

