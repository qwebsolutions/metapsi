using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Shoelace;


public partial class SlAvatar
{
    /// <summary>
    ///
    /// </summary>
    public static class Slot
    {
        /// <summary>
        /// <para> The default icon to use when no image or initials are present. Works best with `&lt;sl-icon&gt;`. </para>
        /// </summary>
        public const string Icon = "icon";
    }
}

public static partial class SlAvatarControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlAvatar(this HtmlBuilder b, Action<AttributesBuilder<SlAvatar>> buildAttributes, params IHtmlNode[] children)
    {
        return b.SlTag("sl-avatar", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlAvatar(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.SlTag("sl-avatar", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlAvatar(this HtmlBuilder b, Action<AttributesBuilder<SlAvatar>> buildAttributes, List<IHtmlNode> children)
    {
        return b.SlTag("sl-avatar", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlAvatar(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.SlTag("sl-avatar", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The image source to use for the avatar. </para>
    /// </summary>
    public static void SetImage(this AttributesBuilder<SlAvatar> b, string image)
    {
        b.SetAttribute("image", image);
    }

    /// <summary>
    /// <para> A label to use to describe the avatar to assistive devices. </para>
    /// </summary>
    public static void SetLabel(this AttributesBuilder<SlAvatar> b, string label)
    {
        b.SetAttribute("label", label);
    }

    /// <summary>
    /// <para> Initials to use as a fallback when no image is available (1-2 characters max recommended). </para>
    /// </summary>
    public static void SetInitials(this AttributesBuilder<SlAvatar> b, string initials)
    {
        b.SetAttribute("initials", initials);
    }

    /// <summary>
    /// <para> Indicates how the browser should load the image. </para>
    /// </summary>
    public static void SetLoading(this AttributesBuilder<SlAvatar> b, string loading)
    {
        b.SetAttribute("loading", loading);
    }

    /// <summary>
    /// <para> Indicates how the browser should load the image. </para>
    /// </summary>
    public static void SetLoadingEager(this AttributesBuilder<SlAvatar> b)
    {
        b.SetAttribute("loading", "eager");
    }

    /// <summary>
    /// <para> Indicates how the browser should load the image. </para>
    /// </summary>
    public static void SetLoadingLazy(this AttributesBuilder<SlAvatar> b)
    {
        b.SetAttribute("loading", "lazy");
    }

    /// <summary>
    /// <para> The shape of the avatar. </para>
    /// </summary>
    public static void SetShape(this AttributesBuilder<SlAvatar> b, string shape)
    {
        b.SetAttribute("shape", shape);
    }

    /// <summary>
    /// <para> The shape of the avatar. </para>
    /// </summary>
    public static void SetShapeCircle(this AttributesBuilder<SlAvatar> b)
    {
        b.SetAttribute("shape", "circle");
    }

    /// <summary>
    /// <para> The shape of the avatar. </para>
    /// </summary>
    public static void SetShapeSquare(this AttributesBuilder<SlAvatar> b)
    {
        b.SetAttribute("shape", "square");
    }

    /// <summary>
    /// <para> The shape of the avatar. </para>
    /// </summary>
    public static void SetShapeRounded(this AttributesBuilder<SlAvatar> b)
    {
        b.SetAttribute("shape", "rounded");
    }

    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlAvatar(this LayoutBuilder b, Action<PropsBuilder<SlAvatar>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("sl-avatar", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlAvatar(this LayoutBuilder b, Action<PropsBuilder<SlAvatar>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("sl-avatar", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlAvatar(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("sl-avatar", children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlAvatar(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("sl-avatar", children);
    }
    /// <summary>
    /// <para> The image source to use for the avatar. </para>
    /// </summary>
    public static void SetImage<T>(this PropsBuilder<T> b, Var<string> image) where T: SlAvatar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("image"), image);
    }

    /// <summary>
    /// <para> The image source to use for the avatar. </para>
    /// </summary>
    public static void SetImage<T>(this PropsBuilder<T> b, string image) where T: SlAvatar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("image"), b.Const(image));
    }


    /// <summary>
    /// <para> A label to use to describe the avatar to assistive devices. </para>
    /// </summary>
    public static void SetLabel<T>(this PropsBuilder<T> b, Var<string> label) where T: SlAvatar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("label"), label);
    }

    /// <summary>
    /// <para> A label to use to describe the avatar to assistive devices. </para>
    /// </summary>
    public static void SetLabel<T>(this PropsBuilder<T> b, string label) where T: SlAvatar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("label"), b.Const(label));
    }


    /// <summary>
    /// <para> Initials to use as a fallback when no image is available (1-2 characters max recommended). </para>
    /// </summary>
    public static void SetInitials<T>(this PropsBuilder<T> b, Var<string> initials) where T: SlAvatar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("initials"), initials);
    }

    /// <summary>
    /// <para> Initials to use as a fallback when no image is available (1-2 characters max recommended). </para>
    /// </summary>
    public static void SetInitials<T>(this PropsBuilder<T> b, string initials) where T: SlAvatar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("initials"), b.Const(initials));
    }


    /// <summary>
    /// <para> Indicates how the browser should load the image. </para>
    /// </summary>
    public static void SetLoadingEager<T>(this PropsBuilder<T> b) where T: SlAvatar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("loading"), b.Const("eager"));
    }


    /// <summary>
    /// <para> Indicates how the browser should load the image. </para>
    /// </summary>
    public static void SetLoadingLazy<T>(this PropsBuilder<T> b) where T: SlAvatar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("loading"), b.Const("lazy"));
    }


    /// <summary>
    /// <para> The shape of the avatar. </para>
    /// </summary>
    public static void SetShapeCircle<T>(this PropsBuilder<T> b) where T: SlAvatar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("shape"), b.Const("circle"));
    }


    /// <summary>
    /// <para> The shape of the avatar. </para>
    /// </summary>
    public static void SetShapeSquare<T>(this PropsBuilder<T> b) where T: SlAvatar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("shape"), b.Const("square"));
    }


    /// <summary>
    /// <para> The shape of the avatar. </para>
    /// </summary>
    public static void SetShapeRounded<T>(this PropsBuilder<T> b) where T: SlAvatar
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("shape"), b.Const("rounded"));
    }


}

