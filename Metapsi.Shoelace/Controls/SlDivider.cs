using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Shoelace;


public partial class SlDivider
{
}

public static partial class SlDividerControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlDivider(this HtmlBuilder b, Action<AttributesBuilder<SlDivider>> buildAttributes, params IHtmlNode[] children)
    {
        return b.SlTag("sl-divider", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlDivider(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.SlTag("sl-divider", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlDivider(this HtmlBuilder b, Action<AttributesBuilder<SlDivider>> buildAttributes, List<IHtmlNode> children)
    {
        return b.SlTag("sl-divider", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlDivider(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.SlTag("sl-divider", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> Draws the divider in a vertical orientation. </para>
    /// </summary>
    public static void SetVertical(this AttributesBuilder<SlDivider> b)
    {
        b.SetAttribute("vertical", "");
    }

    /// <summary>
    /// <para> Draws the divider in a vertical orientation. </para>
    /// </summary>
    public static void SetVertical(this AttributesBuilder<SlDivider> b, bool vertical)
    {
        if (vertical) b.SetAttribute("vertical", "");
    }

    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlDivider(this LayoutBuilder b, Action<PropsBuilder<SlDivider>> buildProps, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-divider", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlDivider(this LayoutBuilder b, Action<PropsBuilder<SlDivider>> buildProps, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-divider", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlDivider(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-divider", children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlDivider(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-divider", children);
    }
    /// <summary>
    /// <para> Draws the divider in a vertical orientation. </para>
    /// </summary>
    public static void SetVertical<T>(this PropsBuilder<T> b) where T: SlDivider
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("vertical"), b.Const(true));
    }


    /// <summary>
    /// <para> Draws the divider in a vertical orientation. </para>
    /// </summary>
    public static void SetVertical<T>(this PropsBuilder<T> b, Var<bool> vertical) where T: SlDivider
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("vertical"), vertical);
    }

    /// <summary>
    /// <para> Draws the divider in a vertical orientation. </para>
    /// </summary>
    public static void SetVertical<T>(this PropsBuilder<T> b, bool vertical) where T: SlDivider
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("vertical"), b.Const(vertical));
    }


}

