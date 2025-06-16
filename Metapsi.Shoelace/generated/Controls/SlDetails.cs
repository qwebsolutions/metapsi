using Metapsi.Html;
using Metapsi.Syntax;
using Metapsi.Hyperapp;

namespace Metapsi.Shoelace;

/// <summary>
/// Details show a brief summary and expand to show additional content.
/// </summary>
public partial class SlDetails
{
    /// <summary>
    /// 
    /// </summary>
    public static class Slot
    {
        /// <summary>
        /// The details' summary. Alternatively, you can use the `summary` attribute.
        /// </summary>
        public const string Summary = "summary";
        /// <summary>
        /// Optional expand icon to use instead of the default. Works best with `&lt;sl-icon&gt;`.
        /// </summary>
        public const string ExpandIcon = "expand-icon";
        /// <summary>
        /// Optional collapse icon to use instead of the default. Works best with `&lt;sl-icon&gt;`.
        /// </summary>
        public const string CollapseIcon = "collapse-icon";
    }
    /// <summary>
    /// 
    /// </summary>
    public static class Method
    {
        /// <summary>
        /// Shows the details.
        /// </summary>
        public const string Show = "show";
        /// <summary>
        /// Hides the details
        /// </summary>
        public const string Hide = "hide";
    }
}
/// <summary>
/// Setter extensions of SlDetails
/// </summary>
public static partial class SlDetailsControl
{
    /// <summary>
    /// Details show a brief summary and expand to show additional content.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlDetails(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlDetails>> buildAttributes, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-details", buildAttributes, children);
    }

    /// <summary>
    /// Details show a brief summary and expand to show additional content.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlDetails(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-details", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// Details show a brief summary and expand to show additional content.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlDetails(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlDetails>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-details", buildAttributes, children);
    }

    /// <summary>
    /// Details show a brief summary and expand to show additional content.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlDetails(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-details", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// Indicates whether or not the details is open. You can toggle this attribute to show and hide the details, or you can use the `show()` and `hide()` methods and this attribute will reflect the details' open state.
    /// </summary>
    public static void SetOpen(this Metapsi.Html.AttributesBuilder<SlDetails> b, bool open) 
    {
        if (open) b.SetAttribute("open", "");
    }

    /// <summary>
    /// Indicates whether or not the details is open. You can toggle this attribute to show and hide the details, or you can use the `show()` and `hide()` methods and this attribute will reflect the details' open state.
    /// </summary>
    public static void SetOpen(this Metapsi.Html.AttributesBuilder<SlDetails> b) 
    {
        b.SetAttribute("open", "");
    }

    /// <summary>
    /// The summary to show in the header. If you need to display HTML, use the `summary` slot instead.
    /// </summary>
    public static void SetSummary(this Metapsi.Html.AttributesBuilder<SlDetails> b, string summary) 
    {
        b.SetAttribute("summary", summary);
    }

    /// <summary>
    /// Disables the details so it can't be toggled.
    /// </summary>
    public static void SetDisabled(this Metapsi.Html.AttributesBuilder<SlDetails> b, bool disabled) 
    {
        if (disabled) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// Disables the details so it can't be toggled.
    /// </summary>
    public static void SetDisabled(this Metapsi.Html.AttributesBuilder<SlDetails> b) 
    {
        b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// Details show a brief summary and expand to show additional content.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlDetails(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlDetails>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-details", buildProps, children);
    }

    /// <summary>
    /// Details show a brief summary and expand to show additional content.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlDetails(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-details", children);
    }

    /// <summary>
    /// Details show a brief summary and expand to show additional content.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlDetails(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlDetails>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-details", buildProps, children);
    }

    /// <summary>
    /// Details show a brief summary and expand to show additional content.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlDetails(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-details", children);
    }

    /// <summary>
    /// Indicates whether or not the details is open. You can toggle this attribute to show and hide the details, or you can use the `show()` and `hide()` methods and this attribute will reflect the details' open state.
    /// </summary>
    public static void SetOpen<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlDetails
    {
        b.SetOpen(b.Const(true));
    }

    /// <summary>
    /// Indicates whether or not the details is open. You can toggle this attribute to show and hide the details, or you can use the `show()` and `hide()` methods and this attribute will reflect the details' open state.
    /// </summary>
    public static void SetOpen<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> open) where T: SlDetails
    {
        b.SetProperty(b.Props, b.Const("open"), open);
    }

    /// <summary>
    /// Indicates whether or not the details is open. You can toggle this attribute to show and hide the details, or you can use the `show()` and `hide()` methods and this attribute will reflect the details' open state.
    /// </summary>
    public static void SetOpen<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool open) where T: SlDetails
    {
        b.SetOpen(b.Const(open));
    }

    /// <summary>
    /// The summary to show in the header. If you need to display HTML, use the `summary` slot instead.
    /// </summary>
    public static void SetSummary<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> summary) where T: SlDetails
    {
        b.SetProperty(b.Props, b.Const("summary"), summary);
    }

    /// <summary>
    /// The summary to show in the header. If you need to display HTML, use the `summary` slot instead.
    /// </summary>
    public static void SetSummary<T>(this Metapsi.Syntax.PropsBuilder<T> b, string summary) where T: SlDetails
    {
        b.SetSummary(b.Const(summary));
    }

    /// <summary>
    /// Disables the details so it can't be toggled.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlDetails
    {
        b.SetDisabled(b.Const(true));
    }

    /// <summary>
    /// Disables the details so it can't be toggled.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> disabled) where T: SlDetails
    {
        b.SetProperty(b.Props, b.Const("disabled"), disabled);
    }

    /// <summary>
    /// Disables the details so it can't be toggled.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool disabled) where T: SlDetails
    {
        b.SetDisabled(b.Const(disabled));
    }

    /// <summary>
    /// Emitted when the details opens.
    /// </summary>
    public static void OnSlShow<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: SlDetails
    {
        b.OnSlEvent("onsl-show", action);
    }

    /// <summary>
    /// Emitted when the details opens.
    /// </summary>
    public static void OnSlShow<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: SlDetails
    {
        b.OnSlShow(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the details opens.
    /// </summary>
    public static void OnSlShow<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: SlDetails
    {
        b.OnSlEvent("onsl-show", action);
    }

    /// <summary>
    /// Emitted when the details opens.
    /// </summary>
    public static void OnSlShow<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: SlDetails
    {
        b.OnSlShow(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the details opens and all animations are complete.
    /// </summary>
    public static void OnSlAfterShow<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: SlDetails
    {
        b.OnSlEvent("onsl-after-show", action);
    }

    /// <summary>
    /// Emitted after the details opens and all animations are complete.
    /// </summary>
    public static void OnSlAfterShow<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: SlDetails
    {
        b.OnSlAfterShow(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the details opens and all animations are complete.
    /// </summary>
    public static void OnSlAfterShow<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: SlDetails
    {
        b.OnSlEvent("onsl-after-show", action);
    }

    /// <summary>
    /// Emitted after the details opens and all animations are complete.
    /// </summary>
    public static void OnSlAfterShow<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: SlDetails
    {
        b.OnSlAfterShow(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the details closes.
    /// </summary>
    public static void OnSlHide<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: SlDetails
    {
        b.OnSlEvent("onsl-hide", action);
    }

    /// <summary>
    /// Emitted when the details closes.
    /// </summary>
    public static void OnSlHide<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: SlDetails
    {
        b.OnSlHide(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the details closes.
    /// </summary>
    public static void OnSlHide<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: SlDetails
    {
        b.OnSlEvent("onsl-hide", action);
    }

    /// <summary>
    /// Emitted when the details closes.
    /// </summary>
    public static void OnSlHide<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: SlDetails
    {
        b.OnSlHide(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the details closes and all animations are complete.
    /// </summary>
    public static void OnSlAfterHide<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: SlDetails
    {
        b.OnSlEvent("onsl-after-hide", action);
    }

    /// <summary>
    /// Emitted after the details closes and all animations are complete.
    /// </summary>
    public static void OnSlAfterHide<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: SlDetails
    {
        b.OnSlAfterHide(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the details closes and all animations are complete.
    /// </summary>
    public static void OnSlAfterHide<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: SlDetails
    {
        b.OnSlEvent("onsl-after-hide", action);
    }

    /// <summary>
    /// Emitted after the details closes and all animations are complete.
    /// </summary>
    public static void OnSlAfterHide<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: SlDetails
    {
        b.OnSlAfterHide(b.MakeAction(action));
    }

}