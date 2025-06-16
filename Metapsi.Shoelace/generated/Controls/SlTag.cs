using Metapsi.Html;
using Metapsi.Syntax;
using Metapsi.Hyperapp;

namespace Metapsi.Shoelace;

/// <summary>
/// Tags are used as labels to organize things or to indicate a selection.
/// </summary>
public partial class SlTag
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
/// Setter extensions of SlTag
/// </summary>
public static partial class SlTagControl
{
    /// <summary>
    /// Tags are used as labels to organize things or to indicate a selection.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlTag(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlTag>> buildAttributes, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-tag", buildAttributes, children);
    }

    /// <summary>
    /// Tags are used as labels to organize things or to indicate a selection.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlTag(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-tag", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// Tags are used as labels to organize things or to indicate a selection.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlTag(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlTag>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-tag", buildAttributes, children);
    }

    /// <summary>
    /// Tags are used as labels to organize things or to indicate a selection.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlTag(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-tag", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// The tag's theme variant.
    /// </summary>
    public static void SetVariantPrimary(this Metapsi.Html.AttributesBuilder<SlTag> b) 
    {
        b.SetAttribute("variant", "primary");
    }

    /// <summary>
    /// The tag's theme variant.
    /// </summary>
    public static void SetVariantSuccess(this Metapsi.Html.AttributesBuilder<SlTag> b) 
    {
        b.SetAttribute("variant", "success");
    }

    /// <summary>
    /// The tag's theme variant.
    /// </summary>
    public static void SetVariantNeutral(this Metapsi.Html.AttributesBuilder<SlTag> b) 
    {
        b.SetAttribute("variant", "neutral");
    }

    /// <summary>
    /// The tag's theme variant.
    /// </summary>
    public static void SetVariantWarning(this Metapsi.Html.AttributesBuilder<SlTag> b) 
    {
        b.SetAttribute("variant", "warning");
    }

    /// <summary>
    /// The tag's theme variant.
    /// </summary>
    public static void SetVariantDanger(this Metapsi.Html.AttributesBuilder<SlTag> b) 
    {
        b.SetAttribute("variant", "danger");
    }

    /// <summary>
    /// The tag's theme variant.
    /// </summary>
    public static void SetVariantText(this Metapsi.Html.AttributesBuilder<SlTag> b) 
    {
        b.SetAttribute("variant", "text");
    }

    /// <summary>
    /// The tag's size.
    /// </summary>
    public static void SetSizeSmall(this Metapsi.Html.AttributesBuilder<SlTag> b) 
    {
        b.SetAttribute("size", "small");
    }

    /// <summary>
    /// The tag's size.
    /// </summary>
    public static void SetSizeMedium(this Metapsi.Html.AttributesBuilder<SlTag> b) 
    {
        b.SetAttribute("size", "medium");
    }

    /// <summary>
    /// The tag's size.
    /// </summary>
    public static void SetSizeLarge(this Metapsi.Html.AttributesBuilder<SlTag> b) 
    {
        b.SetAttribute("size", "large");
    }

    /// <summary>
    /// Draws a pill-style tag with rounded edges.
    /// </summary>
    public static void SetPill(this Metapsi.Html.AttributesBuilder<SlTag> b, bool pill) 
    {
        if (pill) b.SetAttribute("pill", "");
    }

    /// <summary>
    /// Draws a pill-style tag with rounded edges.
    /// </summary>
    public static void SetPill(this Metapsi.Html.AttributesBuilder<SlTag> b) 
    {
        b.SetAttribute("pill", "");
    }

    /// <summary>
    /// Makes the tag removable and shows a remove button.
    /// </summary>
    public static void SetRemovable(this Metapsi.Html.AttributesBuilder<SlTag> b, bool removable) 
    {
        if (removable) b.SetAttribute("removable", "");
    }

    /// <summary>
    /// Makes the tag removable and shows a remove button.
    /// </summary>
    public static void SetRemovable(this Metapsi.Html.AttributesBuilder<SlTag> b) 
    {
        b.SetAttribute("removable", "");
    }

    /// <summary>
    /// Tags are used as labels to organize things or to indicate a selection.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlTag(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlTag>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-tag", buildProps, children);
    }

    /// <summary>
    /// Tags are used as labels to organize things or to indicate a selection.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlTag(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-tag", children);
    }

    /// <summary>
    /// Tags are used as labels to organize things or to indicate a selection.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlTag(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlTag>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-tag", buildProps, children);
    }

    /// <summary>
    /// Tags are used as labels to organize things or to indicate a selection.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlTag(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-tag", children);
    }

    /// <summary>
    /// The tag's theme variant.
    /// </summary>
    public static void SetVariantPrimary<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlTag
    {
        b.SetProperty(b.Props, b.Const("variant"), b.Const("primary"));
    }

    /// <summary>
    /// The tag's theme variant.
    /// </summary>
    public static void SetVariantSuccess<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlTag
    {
        b.SetProperty(b.Props, b.Const("variant"), b.Const("success"));
    }

    /// <summary>
    /// The tag's theme variant.
    /// </summary>
    public static void SetVariantNeutral<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlTag
    {
        b.SetProperty(b.Props, b.Const("variant"), b.Const("neutral"));
    }

    /// <summary>
    /// The tag's theme variant.
    /// </summary>
    public static void SetVariantWarning<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlTag
    {
        b.SetProperty(b.Props, b.Const("variant"), b.Const("warning"));
    }

    /// <summary>
    /// The tag's theme variant.
    /// </summary>
    public static void SetVariantDanger<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlTag
    {
        b.SetProperty(b.Props, b.Const("variant"), b.Const("danger"));
    }

    /// <summary>
    /// The tag's theme variant.
    /// </summary>
    public static void SetVariantText<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlTag
    {
        b.SetProperty(b.Props, b.Const("variant"), b.Const("text"));
    }

    /// <summary>
    /// The tag's size.
    /// </summary>
    public static void SetSizeSmall<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlTag
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const("small"));
    }

    /// <summary>
    /// The tag's size.
    /// </summary>
    public static void SetSizeMedium<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlTag
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const("medium"));
    }

    /// <summary>
    /// The tag's size.
    /// </summary>
    public static void SetSizeLarge<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlTag
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const("large"));
    }

    /// <summary>
    /// Draws a pill-style tag with rounded edges.
    /// </summary>
    public static void SetPill<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlTag
    {
        b.SetPill(b.Const(true));
    }

    /// <summary>
    /// Draws a pill-style tag with rounded edges.
    /// </summary>
    public static void SetPill<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> pill) where T: SlTag
    {
        b.SetProperty(b.Props, b.Const("pill"), pill);
    }

    /// <summary>
    /// Draws a pill-style tag with rounded edges.
    /// </summary>
    public static void SetPill<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool pill) where T: SlTag
    {
        b.SetPill(b.Const(pill));
    }

    /// <summary>
    /// Makes the tag removable and shows a remove button.
    /// </summary>
    public static void SetRemovable<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlTag
    {
        b.SetRemovable(b.Const(true));
    }

    /// <summary>
    /// Makes the tag removable and shows a remove button.
    /// </summary>
    public static void SetRemovable<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> removable) where T: SlTag
    {
        b.SetProperty(b.Props, b.Const("removable"), removable);
    }

    /// <summary>
    /// Makes the tag removable and shows a remove button.
    /// </summary>
    public static void SetRemovable<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool removable) where T: SlTag
    {
        b.SetRemovable(b.Const(removable));
    }

    /// <summary>
    /// Emitted when the remove button is activated.
    /// </summary>
    public static void OnSlRemove<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: SlTag
    {
        b.OnSlEvent("onsl-remove", action);
    }

    /// <summary>
    /// Emitted when the remove button is activated.
    /// </summary>
    public static void OnSlRemove<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: SlTag
    {
        b.OnSlRemove(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the remove button is activated.
    /// </summary>
    public static void OnSlRemove<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: SlTag
    {
        b.OnSlEvent("onsl-remove", action);
    }

    /// <summary>
    /// Emitted when the remove button is activated.
    /// </summary>
    public static void OnSlRemove<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: SlTag
    {
        b.OnSlRemove(b.MakeAction(action));
    }

}