using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Shoelace;


public partial class SlCard : SlComponent
{
    public SlCard() : base("sl-card") { }
    public static class Slot
    {
        /// <summary> 
        /// An optional header for the card.
        /// </summary>
        public const string Header = "header";
        /// <summary> 
        /// An optional footer for the card.
        /// </summary>
        public const string Footer = "footer";
        /// <summary> 
        /// An optional image to render at the start of the card.
        /// </summary>
        public const string Image = "image";
    }
}

public static partial class SlCardControl
{
    /// <summary>
    /// Cards can be used to group related subjects in a container.
    /// </summary>
    public static Var<IVNode> SlCard(this LayoutBuilder b, Action<PropsBuilder<SlCard>> buildProps, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-card", buildProps, children);
    }
    /// <summary>
    /// Cards can be used to group related subjects in a container.
    /// </summary>
    public static Var<IVNode> SlCard(this LayoutBuilder b, Action<PropsBuilder<SlCard>> buildProps, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-card", buildProps, children);
    }
    /// <summary>
    /// Cards can be used to group related subjects in a container.
    /// </summary>
    public static Var<IVNode> SlCard(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-card", children);
    }
    /// <summary>
    /// Cards can be used to group related subjects in a container.
    /// </summary>
    public static Var<IVNode> SlCard(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-card", children);
    }
}

