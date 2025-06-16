using Metapsi.Html;
using Metapsi.Syntax;
using Metapsi.Hyperapp;

namespace Metapsi.Shoelace;

/// <summary>
/// Ratings give users a way to quickly view and provide feedback.
/// </summary>
public partial class SlRating
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
        /// <summary>
        /// Sets focus on the rating.
        /// </summary>
        public const string Focus = "focus";
        /// <summary>
        /// Removes focus from the rating.
        /// </summary>
        public const string Blur = "blur";
    }
}
/// <summary>
/// Setter extensions of SlRating
/// </summary>
public static partial class SlRatingControl
{
    /// <summary>
    /// Ratings give users a way to quickly view and provide feedback.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlRating(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlRating>> buildAttributes, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-rating", buildAttributes, children);
    }

    /// <summary>
    /// Ratings give users a way to quickly view and provide feedback.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlRating(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-rating", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// Ratings give users a way to quickly view and provide feedback.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlRating(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlRating>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-rating", buildAttributes, children);
    }

    /// <summary>
    /// Ratings give users a way to quickly view and provide feedback.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlRating(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-rating", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// A label that describes the rating to assistive devices.
    /// </summary>
    public static void SetLabel(this Metapsi.Html.AttributesBuilder<SlRating> b, string label) 
    {
        b.SetAttribute("label", label);
    }

    /// <summary>
    /// Makes the rating readonly.
    /// </summary>
    public static void SetReadonly(this Metapsi.Html.AttributesBuilder<SlRating> b, bool @readonly) 
    {
        if (@readonly) b.SetAttribute("readonly", "");
    }

    /// <summary>
    /// Makes the rating readonly.
    /// </summary>
    public static void SetReadonly(this Metapsi.Html.AttributesBuilder<SlRating> b) 
    {
        b.SetAttribute("readonly", "");
    }

    /// <summary>
    /// Disables the rating.
    /// </summary>
    public static void SetDisabled(this Metapsi.Html.AttributesBuilder<SlRating> b, bool disabled) 
    {
        if (disabled) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// Disables the rating.
    /// </summary>
    public static void SetDisabled(this Metapsi.Html.AttributesBuilder<SlRating> b) 
    {
        b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// Ratings give users a way to quickly view and provide feedback.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlRating(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlRating>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-rating", buildProps, children);
    }

    /// <summary>
    /// Ratings give users a way to quickly view and provide feedback.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlRating(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-rating", children);
    }

    /// <summary>
    /// Ratings give users a way to quickly view and provide feedback.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlRating(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlRating>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-rating", buildProps, children);
    }

    /// <summary>
    /// Ratings give users a way to quickly view and provide feedback.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlRating(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-rating", children);
    }

    /// <summary>
    /// A label that describes the rating to assistive devices.
    /// </summary>
    public static void SetLabel<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> label) where T: SlRating
    {
        b.SetProperty(b.Props, b.Const("label"), label);
    }

    /// <summary>
    /// A label that describes the rating to assistive devices.
    /// </summary>
    public static void SetLabel<T>(this Metapsi.Syntax.PropsBuilder<T> b, string label) where T: SlRating
    {
        b.SetLabel(b.Const(label));
    }

    /// <summary>
    /// The current rating.
    /// </summary>
    public static void SetValue<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<int> value) where T: SlRating
    {
        b.SetProperty(b.Props, b.Const("value"), value);
    }

    /// <summary>
    /// The current rating.
    /// </summary>
    public static void SetValue<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<decimal> value) where T: SlRating
    {
        b.SetProperty(b.Props, b.Const("value"), value);
    }

    /// <summary>
    /// The highest rating to show.
    /// </summary>
    public static void SetMax<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<int> max) where T: SlRating
    {
        b.SetProperty(b.Props, b.Const("max"), max);
    }

    /// <summary>
    /// The highest rating to show.
    /// </summary>
    public static void SetMax<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<decimal> max) where T: SlRating
    {
        b.SetProperty(b.Props, b.Const("max"), max);
    }

    /// <summary>
    /// The precision at which the rating will increase and decrease. For example, to allow half-star ratings, set this attribute to `0.5`.
    /// </summary>
    public static void SetPrecision<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<decimal> precision) where T: SlRating
    {
        b.SetProperty(b.Props, b.Const("precision"), precision);
    }

    /// <summary>
    /// Makes the rating readonly.
    /// </summary>
    public static void SetReadonly<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlRating
    {
        b.SetReadonly(b.Const(true));
    }

    /// <summary>
    /// Makes the rating readonly.
    /// </summary>
    public static void SetReadonly<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> @readonly) where T: SlRating
    {
        b.SetProperty(b.Props, b.Const("readonly"), @readonly);
    }

    /// <summary>
    /// Makes the rating readonly.
    /// </summary>
    public static void SetReadonly<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool @readonly) where T: SlRating
    {
        b.SetReadonly(b.Const(@readonly));
    }

    /// <summary>
    /// Disables the rating.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlRating
    {
        b.SetDisabled(b.Const(true));
    }

    /// <summary>
    /// Disables the rating.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> disabled) where T: SlRating
    {
        b.SetProperty(b.Props, b.Const("disabled"), disabled);
    }

    /// <summary>
    /// Disables the rating.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool disabled) where T: SlRating
    {
        b.SetDisabled(b.Const(disabled));
    }

    /// <summary>
    /// A function that customizes the symbol to be rendered. The first and only argument is the rating's current value. The function should return a string containing trusted HTML of the symbol to render at the specified value. Works well with `&lt;sl-icon&gt;` elements.
    /// </summary>
    public static void SetGetSymbol<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Syntax.Var<System.Func<decimal, string>>> getSymbol) where T: SlRating
    {
        b.SetProperty(b.Props, b.Const("getSymbol"), getSymbol);
    }

    /// <summary>
    /// Emitted when the rating's value changes.
    /// </summary>
    public static void OnSlChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: SlRating
    {
        b.OnSlEvent("onsl-change", action);
    }

    /// <summary>
    /// Emitted when the rating's value changes.
    /// </summary>
    public static void OnSlChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: SlRating
    {
        b.OnSlChange(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the rating's value changes.
    /// </summary>
    public static void OnSlChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: SlRating
    {
        b.OnSlEvent("onsl-change", action);
    }

    /// <summary>
    /// Emitted when the rating's value changes.
    /// </summary>
    public static void OnSlChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: SlRating
    {
        b.OnSlChange(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the user hovers over a value. The `phase` property indicates when hovering starts, moves to a new value, or ends. The `value` property tells what the rating's value would be if the user were to commit to the hovered value.
    /// </summary>
    public static void OnSlHover<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: SlRating
    {
        b.OnSlEvent("onsl-hover", action);
    }

    /// <summary>
    /// Emitted when the user hovers over a value. The `phase` property indicates when hovering starts, moves to a new value, or ends. The `value` property tells what the rating's value would be if the user were to commit to the hovered value.
    /// </summary>
    public static void OnSlHover<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: SlRating
    {
        b.OnSlHover(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the user hovers over a value. The `phase` property indicates when hovering starts, moves to a new value, or ends. The `value` property tells what the rating's value would be if the user were to commit to the hovered value.
    /// </summary>
    public static void OnSlHover<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: SlRating
    {
        b.OnSlEvent("onsl-hover", action);
    }

    /// <summary>
    /// Emitted when the user hovers over a value. The `phase` property indicates when hovering starts, moves to a new value, or ends. The `value` property tells what the rating's value would be if the user were to commit to the hovered value.
    /// </summary>
    public static void OnSlHover<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: SlRating
    {
        b.OnSlHover(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the user hovers over a value. The `phase` property indicates when hovering starts, moves to a new value, or ends. The `value` property tells what the rating's value would be if the user were to commit to the hovered value.
    /// </summary>
    public static void OnSlHover<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.CustomEvent<SlHoverDetail>>> action) where T: SlRating
    {
        b.OnSlEvent("onsl-hover", action);
    }

}