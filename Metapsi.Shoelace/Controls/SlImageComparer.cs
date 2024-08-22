using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Shoelace;


public partial class SlImageComparer
{
    /// <summary>
    ///
    /// </summary>
    public static class Slot
    {
        /// <summary>
        /// <para> The before image, an `&lt;img&gt;` or `&lt;svg&gt;` element. </para>
        /// </summary>
        public const string Before = "before";
        /// <summary>
        /// <para> The after image, an `&lt;img&gt;` or `&lt;svg&gt;` element. </para>
        /// </summary>
        public const string After = "after";
        /// <summary>
        /// <para> The icon used inside the handle. </para>
        /// </summary>
        public const string Handle = "handle";
    }
}

public static partial class SlImageComparerControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlImageComparer(this HtmlBuilder b, Action<AttributesBuilder<SlImageComparer>> buildAttributes, params IHtmlNode[] children)
    {
        return b.SlTag("sl-image-comparer", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlImageComparer(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.SlTag("sl-image-comparer", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlImageComparer(this HtmlBuilder b, Action<AttributesBuilder<SlImageComparer>> buildAttributes, List<IHtmlNode> children)
    {
        return b.SlTag("sl-image-comparer", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlImageComparer(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.SlTag("sl-image-comparer", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The position of the divider as a percentage. </para>
    /// </summary>
    public static void SetPosition(this AttributesBuilder<SlImageComparer> b, string position)
    {
        b.SetAttribute("position", position);
    }

    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlImageComparer(this LayoutBuilder b, Action<PropsBuilder<SlImageComparer>> buildProps, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-image-comparer", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlImageComparer(this LayoutBuilder b, Action<PropsBuilder<SlImageComparer>> buildProps, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-image-comparer", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlImageComparer(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-image-comparer", children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlImageComparer(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-image-comparer", children);
    }
    /// <summary>
    /// <para> The position of the divider as a percentage. </para>
    /// </summary>
    public static void SetPosition<T>(this PropsBuilder<T> b, Var<int> position) where T: SlImageComparer
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("position"), position);
    }

    /// <summary>
    /// <para> The position of the divider as a percentage. </para>
    /// </summary>
    public static void SetPosition<T>(this PropsBuilder<T> b, int position) where T: SlImageComparer
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("position"), b.Const(position));
    }


    /// <summary>
    /// <para> Emitted when the position changes. </para>
    /// </summary>
    public static void OnSlChange<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, DomEvent>> action) where TComponent: SlImageComparer
    {
        b.OnEventAction("onsl-change", action);
    }
    /// <summary>
    /// <para> Emitted when the position changes. </para>
    /// </summary>
    public static void OnSlChange<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action) where TComponent: SlImageComparer
    {
        b.OnEventAction("onsl-change", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the position changes. </para>
    /// </summary>
    public static void OnSlChange<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: SlImageComparer
    {
        b.OnEventAction("onsl-change", action);
    }
    /// <summary>
    /// <para> Emitted when the position changes. </para>
    /// </summary>
    public static void OnSlChange<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: SlImageComparer
    {
        b.OnEventAction("onsl-change", b.MakeAction(action));
    }

}

