using Metapsi.Html;
using Metapsi.Syntax;
using Metapsi.Hyperapp;

namespace Metapsi.Shoelace;

/// <summary>
/// Badges are used to draw attention and display statuses or counts.
/// </summary>
public partial class SlBadge
{
    /// <summary>
    /// 
    /// </summary>
    public static class Slot
    {
    }
    /// <summary>
    /// 
    /// </summary>
    public static class Method
    {
    }
}
/// <summary>
/// Setter extensions of SlBadge
/// </summary>
public static partial class SlBadgeControl
{
    /// <summary>
    /// Badges are used to draw attention and display statuses or counts.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlBadge(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlBadge>> buildAttributes, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-badge", buildAttributes, children);
    }

    /// <summary>
    /// Badges are used to draw attention and display statuses or counts.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlBadge(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-badge", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// Badges are used to draw attention and display statuses or counts.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlBadge(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlBadge>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-badge", buildAttributes, children);
    }

    /// <summary>
    /// Badges are used to draw attention and display statuses or counts.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlBadge(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-badge", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// The badge's theme variant.
    /// </summary>
    public static void SetVariantPrimary(this Metapsi.Html.AttributesBuilder<SlBadge> b) 
    {
        b.SetAttribute("variant", "primary");
    }

    /// <summary>
    /// The badge's theme variant.
    /// </summary>
    public static void SetVariantSuccess(this Metapsi.Html.AttributesBuilder<SlBadge> b) 
    {
        b.SetAttribute("variant", "success");
    }

    /// <summary>
    /// The badge's theme variant.
    /// </summary>
    public static void SetVariantNeutral(this Metapsi.Html.AttributesBuilder<SlBadge> b) 
    {
        b.SetAttribute("variant", "neutral");
    }

    /// <summary>
    /// The badge's theme variant.
    /// </summary>
    public static void SetVariantWarning(this Metapsi.Html.AttributesBuilder<SlBadge> b) 
    {
        b.SetAttribute("variant", "warning");
    }

    /// <summary>
    /// The badge's theme variant.
    /// </summary>
    public static void SetVariantDanger(this Metapsi.Html.AttributesBuilder<SlBadge> b) 
    {
        b.SetAttribute("variant", "danger");
    }

    /// <summary>
    /// Draws a pill-style badge with rounded edges.
    /// </summary>
    public static void SetPill(this Metapsi.Html.AttributesBuilder<SlBadge> b, bool pill) 
    {
        if (pill) b.SetAttribute("pill", "");
    }

    /// <summary>
    /// Draws a pill-style badge with rounded edges.
    /// </summary>
    public static void SetPill(this Metapsi.Html.AttributesBuilder<SlBadge> b) 
    {
        b.SetAttribute("pill", "");
    }

    /// <summary>
    /// Makes the badge pulsate to draw attention.
    /// </summary>
    public static void SetPulse(this Metapsi.Html.AttributesBuilder<SlBadge> b, bool pulse) 
    {
        if (pulse) b.SetAttribute("pulse", "");
    }

    /// <summary>
    /// Makes the badge pulsate to draw attention.
    /// </summary>
    public static void SetPulse(this Metapsi.Html.AttributesBuilder<SlBadge> b) 
    {
        b.SetAttribute("pulse", "");
    }

    /// <summary>
    /// Badges are used to draw attention and display statuses or counts.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlBadge(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlBadge>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-badge", buildProps, children);
    }

    /// <summary>
    /// Badges are used to draw attention and display statuses or counts.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlBadge(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-badge", children);
    }

    /// <summary>
    /// Badges are used to draw attention and display statuses or counts.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlBadge(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlBadge>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-badge", buildProps, children);
    }

    /// <summary>
    /// Badges are used to draw attention and display statuses or counts.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlBadge(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-badge", children);
    }

    /// <summary>
    /// The badge's theme variant.
    /// </summary>
    public static void SetVariantPrimary<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlBadge
    {
        b.SetProperty(b.Props, b.Const("variant"), b.Const("primary"));
    }

    /// <summary>
    /// The badge's theme variant.
    /// </summary>
    public static void SetVariantSuccess<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlBadge
    {
        b.SetProperty(b.Props, b.Const("variant"), b.Const("success"));
    }

    /// <summary>
    /// The badge's theme variant.
    /// </summary>
    public static void SetVariantNeutral<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlBadge
    {
        b.SetProperty(b.Props, b.Const("variant"), b.Const("neutral"));
    }

    /// <summary>
    /// The badge's theme variant.
    /// </summary>
    public static void SetVariantWarning<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlBadge
    {
        b.SetProperty(b.Props, b.Const("variant"), b.Const("warning"));
    }

    /// <summary>
    /// The badge's theme variant.
    /// </summary>
    public static void SetVariantDanger<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlBadge
    {
        b.SetProperty(b.Props, b.Const("variant"), b.Const("danger"));
    }

    /// <summary>
    /// Draws a pill-style badge with rounded edges.
    /// </summary>
    public static void SetPill<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlBadge
    {
        b.SetPill(b.Const(true));
    }

    /// <summary>
    /// Draws a pill-style badge with rounded edges.
    /// </summary>
    public static void SetPill<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> pill) where T: SlBadge
    {
        b.SetProperty(b.Props, b.Const("pill"), pill);
    }

    /// <summary>
    /// Draws a pill-style badge with rounded edges.
    /// </summary>
    public static void SetPill<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool pill) where T: SlBadge
    {
        b.SetPill(b.Const(pill));
    }

    /// <summary>
    /// Makes the badge pulsate to draw attention.
    /// </summary>
    public static void SetPulse<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlBadge
    {
        b.SetPulse(b.Const(true));
    }

    /// <summary>
    /// Makes the badge pulsate to draw attention.
    /// </summary>
    public static void SetPulse<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> pulse) where T: SlBadge
    {
        b.SetProperty(b.Props, b.Const("pulse"), pulse);
    }

    /// <summary>
    /// Makes the badge pulsate to draw attention.
    /// </summary>
    public static void SetPulse<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool pulse) where T: SlBadge
    {
        b.SetPulse(b.Const(pulse));
    }

}