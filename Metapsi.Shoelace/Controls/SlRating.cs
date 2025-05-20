using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Shoelace;


public partial class SlRating
{
    public static class Method
    {
        /// <summary>
        /// <para> Sets focus on the rating. </para>
        /// </summary>
        public const string Focus = "focus";
        /// <summary>
        /// <para> Removes focus from the rating. </para>
        /// </summary>
        public const string Blur = "blur";
    }
}

public static partial class SlRatingControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlRating(this HtmlBuilder b, Action<AttributesBuilder<SlRating>> buildAttributes, params IHtmlNode[] children)
    {
        return b.SlTag("sl-rating", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlRating(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.SlTag("sl-rating", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlRating(this HtmlBuilder b, Action<AttributesBuilder<SlRating>> buildAttributes, List<IHtmlNode> children)
    {
        return b.SlTag("sl-rating", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlRating(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.SlTag("sl-rating", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> A label that describes the rating to assistive devices. </para>
    /// </summary>
    public static void SetLabel(this AttributesBuilder<SlRating> b, string label)
    {
        b.SetAttribute("label", label);
    }

    /// <summary>
    /// <para> The current rating. </para>
    /// </summary>
    public static void SetValue(this AttributesBuilder<SlRating> b, string value)
    {
        b.SetAttribute("value", value);
    }

    /// <summary>
    /// <para> The highest rating to show. </para>
    /// </summary>
    public static void SetMax(this AttributesBuilder<SlRating> b, string max)
    {
        b.SetAttribute("max", max);
    }

    /// <summary>
    /// <para> The precision at which the rating will increase and decrease. For example, to allow half-star ratings, set this attribute to `0.5`. </para>
    /// </summary>
    public static void SetPrecision(this AttributesBuilder<SlRating> b, string precision)
    {
        b.SetAttribute("precision", precision);
    }

    /// <summary>
    /// <para> Makes the rating readonly. </para>
    /// </summary>
    public static void SetReadonly(this AttributesBuilder<SlRating> b)
    {
        b.SetAttribute("readonly", "");
    }

    /// <summary>
    /// <para> Makes the rating readonly. </para>
    /// </summary>
    public static void SetReadonly(this AttributesBuilder<SlRating> b, bool @readonly)
    {
        if (@readonly) b.SetAttribute("readonly", "");
    }

    /// <summary>
    /// <para> Disables the rating. </para>
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<SlRating> b)
    {
        b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// <para> Disables the rating. </para>
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<SlRating> b, bool disabled)
    {
        if (disabled) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// <para> A function that customizes the symbol to be rendered. The first and only argument is the rating's current value. The function should return a string containing trusted HTML of the symbol to render at the specified value. Works well with `&lt;sl-icon&gt;` elements. </para>
    /// </summary>
    public static void SetGetSymbol(this AttributesBuilder<SlRating> b, string getSymbol)
    {
        b.SetAttribute("getSymbol", getSymbol);
    }

    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlRating(this LayoutBuilder b, Action<PropsBuilder<SlRating>> buildProps, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-rating", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlRating(this LayoutBuilder b, Action<PropsBuilder<SlRating>> buildProps, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-rating", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlRating(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-rating", children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlRating(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-rating", children);
    }
    /// <summary>
    /// <para> A label that describes the rating to assistive devices. </para>
    /// </summary>
    public static void SetLabel<T>(this PropsBuilder<T> b, Var<string> label) where T: SlRating
    {
        b.SetProperty(b.Props, b.Const("label"), label);
    }

    /// <summary>
    /// <para> A label that describes the rating to assistive devices. </para>
    /// </summary>
    public static void SetLabel<T>(this PropsBuilder<T> b, string label) where T: SlRating
    {
        b.SetProperty(b.Props, b.Const("label"), b.Const(label));
    }


    /// <summary>
    /// <para> The current rating. </para>
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, Var<int> value) where T: SlRating
    {
        b.SetProperty(b.Props, b.Const("value"), value);
    }

    /// <summary>
    /// <para> The current rating. </para>
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, int value) where T: SlRating
    {
        b.SetProperty(b.Props, b.Const("value"), b.Const(value));
    }


    /// <summary>
    /// <para> The highest rating to show. </para>
    /// </summary>
    public static void SetMax<T>(this PropsBuilder<T> b, Var<int> max) where T: SlRating
    {
        b.SetProperty(b.Props, b.Const("max"), max);
    }

    /// <summary>
    /// <para> The highest rating to show. </para>
    /// </summary>
    public static void SetMax<T>(this PropsBuilder<T> b, int max) where T: SlRating
    {
        b.SetProperty(b.Props, b.Const("max"), b.Const(max));
    }


    /// <summary>
    /// <para> The precision at which the rating will increase and decrease. For example, to allow half-star ratings, set this attribute to `0.5`. </para>
    /// </summary>
    public static void SetPrecision<T>(this PropsBuilder<T> b, Var<int> precision) where T: SlRating
    {
        b.SetProperty(b.Props, b.Const("precision"), precision);
    }

    /// <summary>
    /// <para> The precision at which the rating will increase and decrease. For example, to allow half-star ratings, set this attribute to `0.5`. </para>
    /// </summary>
    public static void SetPrecision<T>(this PropsBuilder<T> b, int precision) where T: SlRating
    {
        b.SetProperty(b.Props, b.Const("precision"), b.Const(precision));
    }


    /// <summary>
    /// <para> Makes the rating readonly. </para>
    /// </summary>
    public static void SetReadonly<T>(this PropsBuilder<T> b) where T: SlRating
    {
        b.SetProperty(b.Props, b.Const("readonly"), b.Const(true));
    }


    /// <summary>
    /// <para> Makes the rating readonly. </para>
    /// </summary>
    public static void SetReadonly<T>(this PropsBuilder<T> b, Var<bool> @readonly) where T: SlRating
    {
        b.SetProperty(b.Props, b.Const("readonly"), @readonly);
    }

    /// <summary>
    /// <para> Makes the rating readonly. </para>
    /// </summary>
    public static void SetReadonly<T>(this PropsBuilder<T> b, bool @readonly) where T: SlRating
    {
        b.SetProperty(b.Props, b.Const("readonly"), b.Const(@readonly));
    }


    /// <summary>
    /// <para> Disables the rating. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b) where T: SlRating
    {
        b.SetProperty(b.Props, b.Const("disabled"), b.Const(true));
    }


    /// <summary>
    /// <para> Disables the rating. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, Var<bool> disabled) where T: SlRating
    {
        b.SetProperty(b.Props, b.Const("disabled"), disabled);
    }

    /// <summary>
    /// <para> Disables the rating. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, bool disabled) where T: SlRating
    {
        b.SetProperty(b.Props, b.Const("disabled"), b.Const(disabled));
    }


    /// <summary>
    /// <para> A function that customizes the symbol to be rendered. The first and only argument is the rating's current value. The function should return a string containing trusted HTML of the symbol to render at the specified value. Works well with `&lt;sl-icon&gt;` elements. </para>
    /// </summary>
    public static void SetGetSymbol<T>(this PropsBuilder<T> b, Var<System.Func<int,string>> getSymbol) where T: SlRating
    {
        b.SetProperty(b.Props, b.Const("getSymbol"), getSymbol);
    }

    /// <summary>
    /// <para> A function that customizes the symbol to be rendered. The first and only argument is the rating's current value. The function should return a string containing trusted HTML of the symbol to render at the specified value. Works well with `&lt;sl-icon&gt;` elements. </para>
    /// </summary>
    public static void SetGetSymbol<T>(this PropsBuilder<T> b, System.Func<int,string> getSymbol) where T: SlRating
    {
        b.SetProperty(b.Props, b.Const("getSymbol"), b.Const(getSymbol));
    }


    /// <summary>
    /// <para> Emitted when the rating's value changes. </para>
    /// </summary>
    public static void OnSlChange<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, Event>> action) where TComponent: SlRating
    {
        b.OnEventAction("onsl-change", action);
    }
    /// <summary>
    /// <para> Emitted when the rating's value changes. </para>
    /// </summary>
    public static void OnSlChange<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<Event>, Var<TModel>> action) where TComponent: SlRating
    {
        b.OnEventAction("onsl-change", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the rating's value changes. </para>
    /// </summary>
    public static void OnSlChange<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: SlRating
    {
        b.OnEventAction("onsl-change", action);
    }
    /// <summary>
    /// <para> Emitted when the rating's value changes. </para>
    /// </summary>
    public static void OnSlChange<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: SlRating
    {
        b.OnEventAction("onsl-change", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the user hovers over a value. The `phase` property indicates when hovering starts, moves to a new value, or ends. The `value` property tells what the rating's value would be if the user were to commit to the hovered value. </para>
    /// </summary>
    public static void OnSlHover<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, Event>> action) where TComponent: SlRating
    {
        b.OnEventAction("onsl-hover", action);
    }
    /// <summary>
    /// <para> Emitted when the user hovers over a value. The `phase` property indicates when hovering starts, moves to a new value, or ends. The `value` property tells what the rating's value would be if the user were to commit to the hovered value. </para>
    /// </summary>
    public static void OnSlHover<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<Event>, Var<TModel>> action) where TComponent: SlRating
    {
        b.OnEventAction("onsl-hover", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the user hovers over a value. The `phase` property indicates when hovering starts, moves to a new value, or ends. The `value` property tells what the rating's value would be if the user were to commit to the hovered value. </para>
    /// </summary>
    public static void OnSlHover<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: SlRating
    {
        b.OnEventAction("onsl-hover", action);
    }
    /// <summary>
    /// <para> Emitted when the user hovers over a value. The `phase` property indicates when hovering starts, moves to a new value, or ends. The `value` property tells what the rating's value would be if the user were to commit to the hovered value. </para>
    /// </summary>
    public static void OnSlHover<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: SlRating
    {
        b.OnEventAction("onsl-hover", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the user hovers over a value. The `phase` property indicates when hovering starts, moves to a new value, or ends. The `value` property tells what the rating's value would be if the user were to commit to the hovered value. </para>
    /// </summary>
    public static void OnSlHover<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, SlHoverEventArgs>> action) where TComponent: SlRating
    {
        b.OnEventAction("onsl-hover", action, "detail");
    }
    /// <summary>
    /// <para> Emitted when the user hovers over a value. The `phase` property indicates when hovering starts, moves to a new value, or ends. The `value` property tells what the rating's value would be if the user were to commit to the hovered value. </para>
    /// </summary>
    public static void OnSlHover<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SlHoverEventArgs>, Var<TModel>> action) where TComponent: SlRating
    {
        b.OnEventAction("onsl-hover", b.MakeAction(action), "detail");
    }

}

