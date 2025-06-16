using Metapsi.Html;
using Metapsi.Syntax;
using Metapsi.Hyperapp;

namespace Metapsi.Shoelace;

/// <summary>
/// Skeletons are used to provide a visual representation of where content will eventually be drawn.
/// </summary>
public partial class SlSkeleton
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
/// Setter extensions of SlSkeleton
/// </summary>
public static partial class SlSkeletonControl
{
    /// <summary>
    /// Skeletons are used to provide a visual representation of where content will eventually be drawn.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlSkeleton(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlSkeleton>> buildAttributes, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-skeleton", buildAttributes, children);
    }

    /// <summary>
    /// Skeletons are used to provide a visual representation of where content will eventually be drawn.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlSkeleton(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-skeleton", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// Skeletons are used to provide a visual representation of where content will eventually be drawn.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlSkeleton(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlSkeleton>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-skeleton", buildAttributes, children);
    }

    /// <summary>
    /// Skeletons are used to provide a visual representation of where content will eventually be drawn.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlSkeleton(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-skeleton", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// Determines which effect the skeleton will use.
    /// </summary>
    public static void SetEffectPulse(this Metapsi.Html.AttributesBuilder<SlSkeleton> b) 
    {
        b.SetAttribute("effect", "pulse");
    }

    /// <summary>
    /// Determines which effect the skeleton will use.
    /// </summary>
    public static void SetEffectSheen(this Metapsi.Html.AttributesBuilder<SlSkeleton> b) 
    {
        b.SetAttribute("effect", "sheen");
    }

    /// <summary>
    /// Determines which effect the skeleton will use.
    /// </summary>
    public static void SetEffectNone(this Metapsi.Html.AttributesBuilder<SlSkeleton> b) 
    {
        b.SetAttribute("effect", "none");
    }

    /// <summary>
    /// Skeletons are used to provide a visual representation of where content will eventually be drawn.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlSkeleton(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlSkeleton>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-skeleton", buildProps, children);
    }

    /// <summary>
    /// Skeletons are used to provide a visual representation of where content will eventually be drawn.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlSkeleton(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-skeleton", children);
    }

    /// <summary>
    /// Skeletons are used to provide a visual representation of where content will eventually be drawn.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlSkeleton(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlSkeleton>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-skeleton", buildProps, children);
    }

    /// <summary>
    /// Skeletons are used to provide a visual representation of where content will eventually be drawn.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlSkeleton(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-skeleton", children);
    }

    /// <summary>
    /// Determines which effect the skeleton will use.
    /// </summary>
    public static void SetEffectPulse<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlSkeleton
    {
        b.SetProperty(b.Props, b.Const("effect"), b.Const("pulse"));
    }

    /// <summary>
    /// Determines which effect the skeleton will use.
    /// </summary>
    public static void SetEffectSheen<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlSkeleton
    {
        b.SetProperty(b.Props, b.Const("effect"), b.Const("sheen"));
    }

    /// <summary>
    /// Determines which effect the skeleton will use.
    /// </summary>
    public static void SetEffectNone<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlSkeleton
    {
        b.SetProperty(b.Props, b.Const("effect"), b.Const("none"));
    }

}