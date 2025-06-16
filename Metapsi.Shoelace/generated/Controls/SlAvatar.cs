using Metapsi.Html;
using Metapsi.Syntax;
using Metapsi.Hyperapp;

namespace Metapsi.Shoelace;

/// <summary>
/// Avatars are used to represent a person or object.
/// </summary>
public partial class SlAvatar
{
    /// <summary>
    /// 
    /// </summary>
    public static class Slot
    {
        /// <summary>
        /// The default icon to use when no image or initials are present. Works best with `&lt;sl-icon&gt;`.
        /// </summary>
        public const string Icon = "icon";
    }
    /// <summary>
    /// 
    /// </summary>
    public static class Method
    {
    }
}
/// <summary>
/// Setter extensions of SlAvatar
/// </summary>
public static partial class SlAvatarControl
{
    /// <summary>
    /// Avatars are used to represent a person or object.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlAvatar(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlAvatar>> buildAttributes, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-avatar", buildAttributes, children);
    }

    /// <summary>
    /// Avatars are used to represent a person or object.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlAvatar(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-avatar", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// Avatars are used to represent a person or object.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlAvatar(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlAvatar>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-avatar", buildAttributes, children);
    }

    /// <summary>
    /// Avatars are used to represent a person or object.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlAvatar(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-avatar", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// The image source to use for the avatar.
    /// </summary>
    public static void SetImage(this Metapsi.Html.AttributesBuilder<SlAvatar> b, string image) 
    {
        b.SetAttribute("image", image);
    }

    /// <summary>
    /// A label to use to describe the avatar to assistive devices.
    /// </summary>
    public static void SetLabel(this Metapsi.Html.AttributesBuilder<SlAvatar> b, string label) 
    {
        b.SetAttribute("label", label);
    }

    /// <summary>
    /// Initials to use as a fallback when no image is available (1-2 characters max recommended).
    /// </summary>
    public static void SetInitials(this Metapsi.Html.AttributesBuilder<SlAvatar> b, string initials) 
    {
        b.SetAttribute("initials", initials);
    }

    /// <summary>
    /// Indicates how the browser should load the image.
    /// </summary>
    public static void SetLoadingEager(this Metapsi.Html.AttributesBuilder<SlAvatar> b) 
    {
        b.SetAttribute("loading", "eager");
    }

    /// <summary>
    /// Indicates how the browser should load the image.
    /// </summary>
    public static void SetLoadingLazy(this Metapsi.Html.AttributesBuilder<SlAvatar> b) 
    {
        b.SetAttribute("loading", "lazy");
    }

    /// <summary>
    /// The shape of the avatar.
    /// </summary>
    public static void SetShapeCircle(this Metapsi.Html.AttributesBuilder<SlAvatar> b) 
    {
        b.SetAttribute("shape", "circle");
    }

    /// <summary>
    /// The shape of the avatar.
    /// </summary>
    public static void SetShapeSquare(this Metapsi.Html.AttributesBuilder<SlAvatar> b) 
    {
        b.SetAttribute("shape", "square");
    }

    /// <summary>
    /// The shape of the avatar.
    /// </summary>
    public static void SetShapeRounded(this Metapsi.Html.AttributesBuilder<SlAvatar> b) 
    {
        b.SetAttribute("shape", "rounded");
    }

    /// <summary>
    /// Avatars are used to represent a person or object.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlAvatar(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlAvatar>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-avatar", buildProps, children);
    }

    /// <summary>
    /// Avatars are used to represent a person or object.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlAvatar(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-avatar", children);
    }

    /// <summary>
    /// Avatars are used to represent a person or object.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlAvatar(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlAvatar>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-avatar", buildProps, children);
    }

    /// <summary>
    /// Avatars are used to represent a person or object.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlAvatar(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-avatar", children);
    }

    /// <summary>
    /// The image source to use for the avatar.
    /// </summary>
    public static void SetImage<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> image) where T: SlAvatar
    {
        b.SetProperty(b.Props, b.Const("image"), image);
    }

    /// <summary>
    /// The image source to use for the avatar.
    /// </summary>
    public static void SetImage<T>(this Metapsi.Syntax.PropsBuilder<T> b, string image) where T: SlAvatar
    {
        b.SetImage(b.Const(image));
    }

    /// <summary>
    /// A label to use to describe the avatar to assistive devices.
    /// </summary>
    public static void SetLabel<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> label) where T: SlAvatar
    {
        b.SetProperty(b.Props, b.Const("label"), label);
    }

    /// <summary>
    /// A label to use to describe the avatar to assistive devices.
    /// </summary>
    public static void SetLabel<T>(this Metapsi.Syntax.PropsBuilder<T> b, string label) where T: SlAvatar
    {
        b.SetLabel(b.Const(label));
    }

    /// <summary>
    /// Initials to use as a fallback when no image is available (1-2 characters max recommended).
    /// </summary>
    public static void SetInitials<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> initials) where T: SlAvatar
    {
        b.SetProperty(b.Props, b.Const("initials"), initials);
    }

    /// <summary>
    /// Initials to use as a fallback when no image is available (1-2 characters max recommended).
    /// </summary>
    public static void SetInitials<T>(this Metapsi.Syntax.PropsBuilder<T> b, string initials) where T: SlAvatar
    {
        b.SetInitials(b.Const(initials));
    }

    /// <summary>
    /// Indicates how the browser should load the image.
    /// </summary>
    public static void SetLoadingEager<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlAvatar
    {
        b.SetProperty(b.Props, b.Const("loading"), b.Const("eager"));
    }

    /// <summary>
    /// Indicates how the browser should load the image.
    /// </summary>
    public static void SetLoadingLazy<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlAvatar
    {
        b.SetProperty(b.Props, b.Const("loading"), b.Const("lazy"));
    }

    /// <summary>
    /// The shape of the avatar.
    /// </summary>
    public static void SetShapeCircle<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlAvatar
    {
        b.SetProperty(b.Props, b.Const("shape"), b.Const("circle"));
    }

    /// <summary>
    /// The shape of the avatar.
    /// </summary>
    public static void SetShapeSquare<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlAvatar
    {
        b.SetProperty(b.Props, b.Const("shape"), b.Const("square"));
    }

    /// <summary>
    /// The shape of the avatar.
    /// </summary>
    public static void SetShapeRounded<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlAvatar
    {
        b.SetProperty(b.Props, b.Const("shape"), b.Const("rounded"));
    }

    /// <summary>
    /// The image could not be loaded. This may because of an invalid URL, a temporary network condition, or some unknown cause.
    /// </summary>
    public static void OnSlError<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: SlAvatar
    {
        b.OnSlEvent("onsl-error", action);
    }

    /// <summary>
    /// The image could not be loaded. This may because of an invalid URL, a temporary network condition, or some unknown cause.
    /// </summary>
    public static void OnSlError<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: SlAvatar
    {
        b.OnSlError(b.MakeAction(action));
    }

    /// <summary>
    /// The image could not be loaded. This may because of an invalid URL, a temporary network condition, or some unknown cause.
    /// </summary>
    public static void OnSlError<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: SlAvatar
    {
        b.OnSlEvent("onsl-error", action);
    }

    /// <summary>
    /// The image could not be loaded. This may because of an invalid URL, a temporary network condition, or some unknown cause.
    /// </summary>
    public static void OnSlError<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: SlAvatar
    {
        b.OnSlError(b.MakeAction(action));
    }

}