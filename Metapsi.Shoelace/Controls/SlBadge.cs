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
}

public static partial class SlBadgeControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlBadge(this HtmlBuilder b, Action<AttributesBuilder<SlBadge>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("sl-badge", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlBadge(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("sl-badge", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The badge's theme variant. </para>
    /// </summary>
    public static void SetVariant(this AttributesBuilder<SlBadge> b,string variant)
    {
        b.SetAttribute("variant", variant);
    }

    /// <summary>
    /// <para> The badge's theme variant. </para>
    /// </summary>
    public static void SetVariantPrimary(this AttributesBuilder<SlBadge> b)
    {
        b.SetAttribute("variant", "primary");
    }

    /// <summary>
    /// <para> The badge's theme variant. </para>
    /// </summary>
    public static void SetVariantSuccess(this AttributesBuilder<SlBadge> b)
    {
        b.SetAttribute("variant", "success");
    }

    /// <summary>
    /// <para> The badge's theme variant. </para>
    /// </summary>
    public static void SetVariantNeutral(this AttributesBuilder<SlBadge> b)
    {
        b.SetAttribute("variant", "neutral");
    }

    /// <summary>
    /// <para> The badge's theme variant. </para>
    /// </summary>
    public static void SetVariantWarning(this AttributesBuilder<SlBadge> b)
    {
        b.SetAttribute("variant", "warning");
    }

    /// <summary>
    /// <para> The badge's theme variant. </para>
    /// </summary>
    public static void SetVariantDanger(this AttributesBuilder<SlBadge> b)
    {
        b.SetAttribute("variant", "danger");
    }

    /// <summary>
    /// <para> Draws a pill-style badge with rounded edges. </para>
    /// </summary>
    public static void SetPill(this AttributesBuilder<SlBadge> b)
    {
        b.SetAttribute("pill", "");
    }

    /// <summary>
    /// <para> Draws a pill-style badge with rounded edges. </para>
    /// </summary>
    public static void SetPill(this AttributesBuilder<SlBadge> b,bool pill)
    {
        if (pill) b.SetAttribute("pill", "");
    }

    /// <summary>
    /// <para> Makes the badge pulsate to draw attention. </para>
    /// </summary>
    public static void SetPulse(this AttributesBuilder<SlBadge> b)
    {
        b.SetAttribute("pulse", "");
    }

    /// <summary>
    /// <para> Makes the badge pulsate to draw attention. </para>
    /// </summary>
    public static void SetPulse(this AttributesBuilder<SlBadge> b,bool pulse)
    {
        if (pulse) b.SetAttribute("pulse", "");
    }

    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlBadge(this LayoutBuilder b, Action<PropsBuilder<SlBadge>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("sl-badge", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlBadge(this LayoutBuilder b, Action<PropsBuilder<SlBadge>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("sl-badge", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlBadge(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("sl-badge", children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlBadge(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("sl-badge", children);
    }
    /// <summary>
    /// <para> The badge's theme variant. </para>
    /// </summary>
    public static void SetVariantPrimary<T>(this PropsBuilder<T> b) where T: SlBadge
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("variant"), b.Const("primary"));
    }


    /// <summary>
    /// <para> The badge's theme variant. </para>
    /// </summary>
    public static void SetVariantSuccess<T>(this PropsBuilder<T> b) where T: SlBadge
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("variant"), b.Const("success"));
    }


    /// <summary>
    /// <para> The badge's theme variant. </para>
    /// </summary>
    public static void SetVariantNeutral<T>(this PropsBuilder<T> b) where T: SlBadge
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("variant"), b.Const("neutral"));
    }


    /// <summary>
    /// <para> The badge's theme variant. </para>
    /// </summary>
    public static void SetVariantWarning<T>(this PropsBuilder<T> b) where T: SlBadge
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("variant"), b.Const("warning"));
    }


    /// <summary>
    /// <para> The badge's theme variant. </para>
    /// </summary>
    public static void SetVariantDanger<T>(this PropsBuilder<T> b) where T: SlBadge
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("variant"), b.Const("danger"));
    }


    /// <summary>
    /// <para> Draws a pill-style badge with rounded edges. </para>
    /// </summary>
    public static void SetPill<T>(this PropsBuilder<T> b) where T: SlBadge
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("pill"), b.Const(true));
    }


    /// <summary>
    /// <para> Draws a pill-style badge with rounded edges. </para>
    /// </summary>
    public static void SetPill<T>(this PropsBuilder<T> b, Var<bool> pill) where T: SlBadge
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("pill"), pill);
    }

    /// <summary>
    /// <para> Draws a pill-style badge with rounded edges. </para>
    /// </summary>
    public static void SetPill<T>(this PropsBuilder<T> b, bool pill) where T: SlBadge
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("pill"), b.Const(pill));
    }


    /// <summary>
    /// <para> Makes the badge pulsate to draw attention. </para>
    /// </summary>
    public static void SetPulse<T>(this PropsBuilder<T> b) where T: SlBadge
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("pulse"), b.Const(true));
    }


    /// <summary>
    /// <para> Makes the badge pulsate to draw attention. </para>
    /// </summary>
    public static void SetPulse<T>(this PropsBuilder<T> b, Var<bool> pulse) where T: SlBadge
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("pulse"), pulse);
    }

    /// <summary>
    /// <para> Makes the badge pulsate to draw attention. </para>
    /// </summary>
    public static void SetPulse<T>(this PropsBuilder<T> b, bool pulse) where T: SlBadge
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("pulse"), b.Const(pulse));
    }


}

