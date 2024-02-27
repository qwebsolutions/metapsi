using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using System.ComponentModel;

namespace Metapsi.Shoelace;


public partial interface IClientSideSlBadge
{
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

/// <summary>
/// Badges are used to draw attention and display statuses or counts.
/// </summary>
public partial class SlBadge : HtmlTag
{
    public SlBadge()
    {
        this.Tag = "sl-badge";
    }

    public static SlBadge New()
    {
        return new SlBadge();
    }
}

public static partial class SlBadgeControl
{
    /// <summary>
    /// The badge's theme variant.
    /// </summary>
    public static SlBadge SetVariantPrimary(this SlBadge tag)
    {
        return tag.SetAttribute("variant", "primary");
    }
    /// <summary>
    /// The badge's theme variant.
    /// </summary>
    public static SlBadge SetVariantSuccess(this SlBadge tag)
    {
        return tag.SetAttribute("variant", "success");
    }
    /// <summary>
    /// The badge's theme variant.
    /// </summary>
    public static SlBadge SetVariantNeutral(this SlBadge tag)
    {
        return tag.SetAttribute("variant", "neutral");
    }
    /// <summary>
    /// The badge's theme variant.
    /// </summary>
    public static SlBadge SetVariantWarning(this SlBadge tag)
    {
        return tag.SetAttribute("variant", "warning");
    }
    /// <summary>
    /// The badge's theme variant.
    /// </summary>
    public static SlBadge SetVariantDanger(this SlBadge tag)
    {
        return tag.SetAttribute("variant", "danger");
    }
    /// <summary>
    /// Draws a pill-style badge with rounded edges.
    /// </summary>
    public static SlBadge SetPill(this SlBadge tag)
    {
        return tag.SetAttribute("pill", "true");
    }
    /// <summary>
    /// Makes the badge pulsate to draw attention.
    /// </summary>
    public static SlBadge SetPulse(this SlBadge tag)
    {
        return tag.SetAttribute("pulse", "true");
    }
}

