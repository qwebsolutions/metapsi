using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Shoelace;


public partial class SlCard
{
    /// <summary>
    ///
    /// </summary>
    public static class Slot
    {
        /// <summary>
        /// <para> An optional header for the card. </para>
        /// </summary>
        public const string Header = "header";
        /// <summary>
        /// <para> An optional footer for the card. </para>
        /// </summary>
        public const string Footer = "footer";
        /// <summary>
        /// <para> An optional image to render at the start of the card. </para>
        /// </summary>
        public const string Image = "image";
    }
}

public static partial class SlCardControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlCard(this HtmlBuilder b, Action<AttributesBuilder<SlCard>> buildAttributes, params IHtmlNode[] children)
    {
        return b.SlTag("sl-card", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlCard(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.SlTag("sl-card", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlCard(this HtmlBuilder b, Action<AttributesBuilder<SlCard>> buildAttributes, List<IHtmlNode> children)
    {
        return b.SlTag("sl-card", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlCard(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.SlTag("sl-card", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlCard(this LayoutBuilder b, Action<PropsBuilder<SlCard>> buildProps, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-card", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlCard(this LayoutBuilder b, Action<PropsBuilder<SlCard>> buildProps, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-card", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlCard(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-card", children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlCard(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-card", children);
    }
}

