using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Shoelace;


public partial class SlDetails
{
    /// <summary>
    ///
    /// </summary>
    public static class Slot
    {
        /// <summary>
        /// <para> The details' summary. Alternatively, you can use the `summary` attribute. </para>
        /// </summary>
        public const string Summary = "summary";
        /// <summary>
        /// <para> Optional expand icon to use instead of the default. Works best with `&lt;sl-icon&gt;`. </para>
        /// </summary>
        public const string ExpandIcon = "expand-icon";
        /// <summary>
        /// <para> Optional collapse icon to use instead of the default. Works best with `&lt;sl-icon&gt;`. </para>
        /// </summary>
        public const string CollapseIcon = "collapse-icon";
    }
    public static class Method
    {
        /// <summary>
        /// <para> Shows the details. </para>
        /// </summary>
        public const string Show = "show";
        /// <summary>
        /// <para> Hides the details </para>
        /// </summary>
        public const string Hide = "hide";
    }
}

public static partial class SlDetailsControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlDetails(this HtmlBuilder b, Action<AttributesBuilder<SlDetails>> buildAttributes, params IHtmlNode[] children)
    {
        return b.SlTag("sl-details", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlDetails(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.SlTag("sl-details", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlDetails(this HtmlBuilder b, Action<AttributesBuilder<SlDetails>> buildAttributes, List<IHtmlNode> children)
    {
        return b.SlTag("sl-details", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlDetails(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.SlTag("sl-details", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> Indicates whether or not the details is open. You can toggle this attribute to show and hide the details, or you can use the `show()` and `hide()` methods and this attribute will reflect the details' open state. </para>
    /// </summary>
    public static void SetOpen(this AttributesBuilder<SlDetails> b)
    {
        b.SetAttribute("open", "");
    }

    /// <summary>
    /// <para> Indicates whether or not the details is open. You can toggle this attribute to show and hide the details, or you can use the `show()` and `hide()` methods and this attribute will reflect the details' open state. </para>
    /// </summary>
    public static void SetOpen(this AttributesBuilder<SlDetails> b, bool open)
    {
        if (open) b.SetAttribute("open", "");
    }

    /// <summary>
    /// <para> The summary to show in the header. If you need to display HTML, use the `summary` slot instead. </para>
    /// </summary>
    public static void SetSummary(this AttributesBuilder<SlDetails> b, string summary)
    {
        b.SetAttribute("summary", summary);
    }

    /// <summary>
    /// <para> Disables the details so it can't be toggled. </para>
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<SlDetails> b)
    {
        b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// <para> Disables the details so it can't be toggled. </para>
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<SlDetails> b, bool disabled)
    {
        if (disabled) b.SetAttribute("disabled", "");
    }

    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlDetails(this LayoutBuilder b, Action<PropsBuilder<SlDetails>> buildProps, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-details", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlDetails(this LayoutBuilder b, Action<PropsBuilder<SlDetails>> buildProps, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-details", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlDetails(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-details", children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlDetails(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-details", children);
    }
    /// <summary>
    /// <para> Indicates whether or not the details is open. You can toggle this attribute to show and hide the details, or you can use the `show()` and `hide()` methods and this attribute will reflect the details' open state. </para>
    /// </summary>
    public static void SetOpen<T>(this PropsBuilder<T> b) where T: SlDetails
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("open"), b.Const(true));
    }


    /// <summary>
    /// <para> Indicates whether or not the details is open. You can toggle this attribute to show and hide the details, or you can use the `show()` and `hide()` methods and this attribute will reflect the details' open state. </para>
    /// </summary>
    public static void SetOpen<T>(this PropsBuilder<T> b, Var<bool> open) where T: SlDetails
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("open"), open);
    }

    /// <summary>
    /// <para> Indicates whether or not the details is open. You can toggle this attribute to show and hide the details, or you can use the `show()` and `hide()` methods and this attribute will reflect the details' open state. </para>
    /// </summary>
    public static void SetOpen<T>(this PropsBuilder<T> b, bool open) where T: SlDetails
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("open"), b.Const(open));
    }


    /// <summary>
    /// <para> The summary to show in the header. If you need to display HTML, use the `summary` slot instead. </para>
    /// </summary>
    public static void SetSummary<T>(this PropsBuilder<T> b, Var<string> summary) where T: SlDetails
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("summary"), summary);
    }

    /// <summary>
    /// <para> The summary to show in the header. If you need to display HTML, use the `summary` slot instead. </para>
    /// </summary>
    public static void SetSummary<T>(this PropsBuilder<T> b, string summary) where T: SlDetails
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("summary"), b.Const(summary));
    }


    /// <summary>
    /// <para> Disables the details so it can't be toggled. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b) where T: SlDetails
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), b.Const(true));
    }


    /// <summary>
    /// <para> Disables the details so it can't be toggled. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, Var<bool> disabled) where T: SlDetails
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), disabled);
    }

    /// <summary>
    /// <para> Disables the details so it can't be toggled. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, bool disabled) where T: SlDetails
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), b.Const(disabled));
    }


    /// <summary>
    /// <para> Emitted when the details opens. </para>
    /// </summary>
    public static void OnSlShow<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, DomEvent>> action) where TComponent: SlDetails
    {
        b.OnEventAction("onsl-show", action);
    }
    /// <summary>
    /// <para> Emitted when the details opens. </para>
    /// </summary>
    public static void OnSlShow<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action) where TComponent: SlDetails
    {
        b.OnEventAction("onsl-show", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the details opens. </para>
    /// </summary>
    public static void OnSlShow<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: SlDetails
    {
        b.OnEventAction("onsl-show", action);
    }
    /// <summary>
    /// <para> Emitted when the details opens. </para>
    /// </summary>
    public static void OnSlShow<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: SlDetails
    {
        b.OnEventAction("onsl-show", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted after the details opens and all animations are complete. </para>
    /// </summary>
    public static void OnSlAfterShow<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, DomEvent>> action) where TComponent: SlDetails
    {
        b.OnEventAction("onsl-after-show", action);
    }
    /// <summary>
    /// <para> Emitted after the details opens and all animations are complete. </para>
    /// </summary>
    public static void OnSlAfterShow<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action) where TComponent: SlDetails
    {
        b.OnEventAction("onsl-after-show", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted after the details opens and all animations are complete. </para>
    /// </summary>
    public static void OnSlAfterShow<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: SlDetails
    {
        b.OnEventAction("onsl-after-show", action);
    }
    /// <summary>
    /// <para> Emitted after the details opens and all animations are complete. </para>
    /// </summary>
    public static void OnSlAfterShow<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: SlDetails
    {
        b.OnEventAction("onsl-after-show", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the details closes. </para>
    /// </summary>
    public static void OnSlHide<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, DomEvent>> action) where TComponent: SlDetails
    {
        b.OnEventAction("onsl-hide", action);
    }
    /// <summary>
    /// <para> Emitted when the details closes. </para>
    /// </summary>
    public static void OnSlHide<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action) where TComponent: SlDetails
    {
        b.OnEventAction("onsl-hide", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the details closes. </para>
    /// </summary>
    public static void OnSlHide<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: SlDetails
    {
        b.OnEventAction("onsl-hide", action);
    }
    /// <summary>
    /// <para> Emitted when the details closes. </para>
    /// </summary>
    public static void OnSlHide<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: SlDetails
    {
        b.OnEventAction("onsl-hide", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted after the details closes and all animations are complete. </para>
    /// </summary>
    public static void OnSlAfterHide<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, DomEvent>> action) where TComponent: SlDetails
    {
        b.OnEventAction("onsl-after-hide", action);
    }
    /// <summary>
    /// <para> Emitted after the details closes and all animations are complete. </para>
    /// </summary>
    public static void OnSlAfterHide<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action) where TComponent: SlDetails
    {
        b.OnEventAction("onsl-after-hide", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted after the details closes and all animations are complete. </para>
    /// </summary>
    public static void OnSlAfterHide<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: SlDetails
    {
        b.OnEventAction("onsl-after-hide", action);
    }
    /// <summary>
    /// <para> Emitted after the details closes and all animations are complete. </para>
    /// </summary>
    public static void OnSlAfterHide<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: SlDetails
    {
        b.OnEventAction("onsl-after-hide", b.MakeAction(action));
    }

}

