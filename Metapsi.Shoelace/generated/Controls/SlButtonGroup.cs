using Metapsi.Html;
using Metapsi.Syntax;
using Metapsi.Hyperapp;

namespace Metapsi.Shoelace;

/// <summary>
/// Button groups can be used to group related buttons into sections.
/// </summary>
public partial class SlButtonGroup
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
/// Setter extensions of SlButtonGroup
/// </summary>
public static partial class SlButtonGroupControl
{
    /// <summary>
    /// Button groups can be used to group related buttons into sections.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlButtonGroup(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlButtonGroup>> buildAttributes, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-button-group", buildAttributes, children);
    }

    /// <summary>
    /// Button groups can be used to group related buttons into sections.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlButtonGroup(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-button-group", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// Button groups can be used to group related buttons into sections.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlButtonGroup(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlButtonGroup>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-button-group", buildAttributes, children);
    }

    /// <summary>
    /// Button groups can be used to group related buttons into sections.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlButtonGroup(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-button-group", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// A label to use for the button group. This won't be displayed on the screen, but it will be announced by assistive devices when interacting with the control and is strongly recommended.
    /// </summary>
    public static void SetLabel(this Metapsi.Html.AttributesBuilder<SlButtonGroup> b, string label) 
    {
        b.SetAttribute("label", label);
    }

    /// <summary>
    /// Button groups can be used to group related buttons into sections.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlButtonGroup(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlButtonGroup>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-button-group", buildProps, children);
    }

    /// <summary>
    /// Button groups can be used to group related buttons into sections.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlButtonGroup(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-button-group", children);
    }

    /// <summary>
    /// Button groups can be used to group related buttons into sections.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlButtonGroup(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlButtonGroup>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-button-group", buildProps, children);
    }

    /// <summary>
    /// Button groups can be used to group related buttons into sections.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlButtonGroup(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-button-group", children);
    }

    /// <summary>
    /// A label to use for the button group. This won't be displayed on the screen, but it will be announced by assistive devices when interacting with the control and is strongly recommended.
    /// </summary>
    public static void SetLabel<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> label) where T: SlButtonGroup
    {
        b.SetProperty(b.Props, b.Const("label"), label);
    }

    /// <summary>
    /// A label to use for the button group. This won't be displayed on the screen, but it will be announced by assistive devices when interacting with the control and is strongly recommended.
    /// </summary>
    public static void SetLabel<T>(this Metapsi.Syntax.PropsBuilder<T> b, string label) where T: SlButtonGroup
    {
        b.SetLabel(b.Const(label));
    }

}