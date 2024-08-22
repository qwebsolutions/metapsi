using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Shoelace;


public partial class SlSkeleton
{
}

public static partial class SlSkeletonControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlSkeleton(this HtmlBuilder b, Action<AttributesBuilder<SlSkeleton>> buildAttributes, params IHtmlNode[] children)
    {
        return b.SlTag("sl-skeleton", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlSkeleton(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.SlTag("sl-skeleton", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlSkeleton(this HtmlBuilder b, Action<AttributesBuilder<SlSkeleton>> buildAttributes, List<IHtmlNode> children)
    {
        return b.SlTag("sl-skeleton", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlSkeleton(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.SlTag("sl-skeleton", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> Determines which effect the skeleton will use. </para>
    /// </summary>
    public static void SetEffect(this AttributesBuilder<SlSkeleton> b, string effect)
    {
        b.SetAttribute("effect", effect);
    }

    /// <summary>
    /// <para> Determines which effect the skeleton will use. </para>
    /// </summary>
    public static void SetEffectPulse(this AttributesBuilder<SlSkeleton> b)
    {
        b.SetAttribute("effect", "pulse");
    }

    /// <summary>
    /// <para> Determines which effect the skeleton will use. </para>
    /// </summary>
    public static void SetEffectSheen(this AttributesBuilder<SlSkeleton> b)
    {
        b.SetAttribute("effect", "sheen");
    }

    /// <summary>
    /// <para> Determines which effect the skeleton will use. </para>
    /// </summary>
    public static void SetEffectNone(this AttributesBuilder<SlSkeleton> b)
    {
        b.SetAttribute("effect", "none");
    }

    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlSkeleton(this LayoutBuilder b, Action<PropsBuilder<SlSkeleton>> buildProps, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-skeleton", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlSkeleton(this LayoutBuilder b, Action<PropsBuilder<SlSkeleton>> buildProps, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-skeleton", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlSkeleton(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-skeleton", children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlSkeleton(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-skeleton", children);
    }
    /// <summary>
    /// <para> Determines which effect the skeleton will use. </para>
    /// </summary>
    public static void SetEffectPulse<T>(this PropsBuilder<T> b) where T: SlSkeleton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("effect"), b.Const("pulse"));
    }


    /// <summary>
    /// <para> Determines which effect the skeleton will use. </para>
    /// </summary>
    public static void SetEffectSheen<T>(this PropsBuilder<T> b) where T: SlSkeleton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("effect"), b.Const("sheen"));
    }


    /// <summary>
    /// <para> Determines which effect the skeleton will use. </para>
    /// </summary>
    public static void SetEffectNone<T>(this PropsBuilder<T> b) where T: SlSkeleton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("effect"), b.Const("none"));
    }


}

