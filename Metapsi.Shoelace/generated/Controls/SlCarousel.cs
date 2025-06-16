using Metapsi.Html;
using Metapsi.Syntax;
using Metapsi.Hyperapp;

namespace Metapsi.Shoelace;

/// <summary>
/// Carousels display an arbitrary number of content slides along a horizontal or vertical axis.
/// </summary>
public partial class SlCarousel
{
    /// <summary>
    /// 
    /// </summary>
    public static class Slot
    {
        /// <summary>
        /// Optional next icon to use instead of the default. Works best with `&lt;sl-icon&gt;`.
        /// </summary>
        public const string NextIcon = "next-icon";
        /// <summary>
        /// Optional previous icon to use instead of the default. Works best with `&lt;sl-icon&gt;`.
        /// </summary>
        public const string PreviousIcon = "previous-icon";
    }
    /// <summary>
    /// 
    /// </summary>
    public static class Method
    {
        /// <summary>
        /// Move the carousel backward by `slides-per-move` slides.
        /// </summary>
        public const string Previous = "previous";
        /// <summary>
        /// Move the carousel forward by `slides-per-move` slides.
        /// </summary>
        public const string Next = "next";
        /// <summary>
        /// Scrolls the carousel to the slide specified by `index`.
        /// </summary>
        public const string GoToSlide = "goToSlide";
    }
}
/// <summary>
/// Setter extensions of SlCarousel
/// </summary>
public static partial class SlCarouselControl
{
    /// <summary>
    /// Carousels display an arbitrary number of content slides along a horizontal or vertical axis.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlCarousel(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlCarousel>> buildAttributes, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-carousel", buildAttributes, children);
    }

    /// <summary>
    /// Carousels display an arbitrary number of content slides along a horizontal or vertical axis.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlCarousel(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-carousel", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// Carousels display an arbitrary number of content slides along a horizontal or vertical axis.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlCarousel(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlCarousel>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-carousel", buildAttributes, children);
    }

    /// <summary>
    /// Carousels display an arbitrary number of content slides along a horizontal or vertical axis.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlCarousel(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-carousel", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// When set, allows the user to navigate the carousel in the same direction indefinitely.
    /// </summary>
    public static void SetLoop(this Metapsi.Html.AttributesBuilder<SlCarousel> b, bool loop) 
    {
        if (loop) b.SetAttribute("loop", "");
    }

    /// <summary>
    /// When set, allows the user to navigate the carousel in the same direction indefinitely.
    /// </summary>
    public static void SetLoop(this Metapsi.Html.AttributesBuilder<SlCarousel> b) 
    {
        b.SetAttribute("loop", "");
    }

    /// <summary>
    /// When set, show the carousel's navigation.
    /// </summary>
    public static void SetNavigation(this Metapsi.Html.AttributesBuilder<SlCarousel> b, bool navigation) 
    {
        if (navigation) b.SetAttribute("navigation", "");
    }

    /// <summary>
    /// When set, show the carousel's navigation.
    /// </summary>
    public static void SetNavigation(this Metapsi.Html.AttributesBuilder<SlCarousel> b) 
    {
        b.SetAttribute("navigation", "");
    }

    /// <summary>
    /// When set, show the carousel's pagination indicators.
    /// </summary>
    public static void SetPagination(this Metapsi.Html.AttributesBuilder<SlCarousel> b, bool pagination) 
    {
        if (pagination) b.SetAttribute("pagination", "");
    }

    /// <summary>
    /// When set, show the carousel's pagination indicators.
    /// </summary>
    public static void SetPagination(this Metapsi.Html.AttributesBuilder<SlCarousel> b) 
    {
        b.SetAttribute("pagination", "");
    }

    /// <summary>
    /// When set, the slides will scroll automatically when the user is not interacting with them.
    /// </summary>
    public static void SetAutoplay(this Metapsi.Html.AttributesBuilder<SlCarousel> b, bool autoplay) 
    {
        if (autoplay) b.SetAttribute("autoplay", "");
    }

    /// <summary>
    /// When set, the slides will scroll automatically when the user is not interacting with them.
    /// </summary>
    public static void SetAutoplay(this Metapsi.Html.AttributesBuilder<SlCarousel> b) 
    {
        b.SetAttribute("autoplay", "");
    }

    /// <summary>
    /// Specifies the orientation in which the carousel will lay out.
    /// </summary>
    public static void SetOrientationHorizontal(this Metapsi.Html.AttributesBuilder<SlCarousel> b) 
    {
        b.SetAttribute("orientation", "horizontal");
    }

    /// <summary>
    /// Specifies the orientation in which the carousel will lay out.
    /// </summary>
    public static void SetOrientationVertical(this Metapsi.Html.AttributesBuilder<SlCarousel> b) 
    {
        b.SetAttribute("orientation", "vertical");
    }

    /// <summary>
    /// When set, it is possible to scroll through the slides by dragging them with the mouse.
    /// </summary>
    public static void SetMouseDragging(this Metapsi.Html.AttributesBuilder<SlCarousel> b, bool mouseDragging) 
    {
        if (mouseDragging) b.SetAttribute("mouse-dragging", "");
    }

    /// <summary>
    /// When set, it is possible to scroll through the slides by dragging them with the mouse.
    /// </summary>
    public static void SetMouseDragging(this Metapsi.Html.AttributesBuilder<SlCarousel> b) 
    {
        b.SetAttribute("mouse-dragging", "");
    }

    /// <summary>
    /// Carousels display an arbitrary number of content slides along a horizontal or vertical axis.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlCarousel(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlCarousel>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-carousel", buildProps, children);
    }

    /// <summary>
    /// Carousels display an arbitrary number of content slides along a horizontal or vertical axis.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlCarousel(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-carousel", children);
    }

    /// <summary>
    /// Carousels display an arbitrary number of content slides along a horizontal or vertical axis.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlCarousel(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlCarousel>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-carousel", buildProps, children);
    }

    /// <summary>
    /// Carousels display an arbitrary number of content slides along a horizontal or vertical axis.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlCarousel(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-carousel", children);
    }

    /// <summary>
    /// When set, allows the user to navigate the carousel in the same direction indefinitely.
    /// </summary>
    public static void SetLoop<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlCarousel
    {
        b.SetLoop(b.Const(true));
    }

    /// <summary>
    /// When set, allows the user to navigate the carousel in the same direction indefinitely.
    /// </summary>
    public static void SetLoop<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> loop) where T: SlCarousel
    {
        b.SetProperty(b.Props, b.Const("loop"), loop);
    }

    /// <summary>
    /// When set, allows the user to navigate the carousel in the same direction indefinitely.
    /// </summary>
    public static void SetLoop<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool loop) where T: SlCarousel
    {
        b.SetLoop(b.Const(loop));
    }

    /// <summary>
    /// When set, show the carousel's navigation.
    /// </summary>
    public static void SetNavigation<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlCarousel
    {
        b.SetNavigation(b.Const(true));
    }

    /// <summary>
    /// When set, show the carousel's navigation.
    /// </summary>
    public static void SetNavigation<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> navigation) where T: SlCarousel
    {
        b.SetProperty(b.Props, b.Const("navigation"), navigation);
    }

    /// <summary>
    /// When set, show the carousel's navigation.
    /// </summary>
    public static void SetNavigation<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool navigation) where T: SlCarousel
    {
        b.SetNavigation(b.Const(navigation));
    }

    /// <summary>
    /// When set, show the carousel's pagination indicators.
    /// </summary>
    public static void SetPagination<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlCarousel
    {
        b.SetPagination(b.Const(true));
    }

    /// <summary>
    /// When set, show the carousel's pagination indicators.
    /// </summary>
    public static void SetPagination<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> pagination) where T: SlCarousel
    {
        b.SetProperty(b.Props, b.Const("pagination"), pagination);
    }

    /// <summary>
    /// When set, show the carousel's pagination indicators.
    /// </summary>
    public static void SetPagination<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool pagination) where T: SlCarousel
    {
        b.SetPagination(b.Const(pagination));
    }

    /// <summary>
    /// When set, the slides will scroll automatically when the user is not interacting with them.
    /// </summary>
    public static void SetAutoplay<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlCarousel
    {
        b.SetAutoplay(b.Const(true));
    }

    /// <summary>
    /// When set, the slides will scroll automatically when the user is not interacting with them.
    /// </summary>
    public static void SetAutoplay<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> autoplay) where T: SlCarousel
    {
        b.SetProperty(b.Props, b.Const("autoplay"), autoplay);
    }

    /// <summary>
    /// When set, the slides will scroll automatically when the user is not interacting with them.
    /// </summary>
    public static void SetAutoplay<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool autoplay) where T: SlCarousel
    {
        b.SetAutoplay(b.Const(autoplay));
    }

    /// <summary>
    /// Specifies the amount of time, in milliseconds, between each automatic scroll.
    /// </summary>
    public static void SetAutoplayInterval<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<int> autoplayInterval) where T: SlCarousel
    {
        b.SetProperty(b.Props, b.Const("autoplayInterval"), autoplayInterval);
    }

    /// <summary>
    /// Specifies the amount of time, in milliseconds, between each automatic scroll.
    /// </summary>
    public static void SetAutoplayInterval<T>(this Metapsi.Syntax.PropsBuilder<T> b, int autoplayInterval) where T: SlCarousel
    {
        b.SetAutoplayInterval(b.Const(autoplayInterval));
    }

    /// <summary>
    /// Specifies how many slides should be shown at a given time.
    /// </summary>
    public static void SetSlidesPerPage<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<int> slidesPerPage) where T: SlCarousel
    {
        b.SetProperty(b.Props, b.Const("slidesPerPage"), slidesPerPage);
    }

    /// <summary>
    /// Specifies how many slides should be shown at a given time.
    /// </summary>
    public static void SetSlidesPerPage<T>(this Metapsi.Syntax.PropsBuilder<T> b, int slidesPerPage) where T: SlCarousel
    {
        b.SetSlidesPerPage(b.Const(slidesPerPage));
    }

    /// <summary>
    /// Specifies the number of slides the carousel will advance when scrolling, useful when specifying a `slides-per-page` greater than one. It can't be higher than `slides-per-page`.
    /// </summary>
    public static void SetSlidesPerMove<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<int> slidesPerMove) where T: SlCarousel
    {
        b.SetProperty(b.Props, b.Const("slidesPerMove"), slidesPerMove);
    }

    /// <summary>
    /// Specifies the number of slides the carousel will advance when scrolling, useful when specifying a `slides-per-page` greater than one. It can't be higher than `slides-per-page`.
    /// </summary>
    public static void SetSlidesPerMove<T>(this Metapsi.Syntax.PropsBuilder<T> b, int slidesPerMove) where T: SlCarousel
    {
        b.SetSlidesPerMove(b.Const(slidesPerMove));
    }

    /// <summary>
    /// Specifies the orientation in which the carousel will lay out.
    /// </summary>
    public static void SetOrientationHorizontal<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlCarousel
    {
        b.SetProperty(b.Props, b.Const("orientation"), b.Const("horizontal"));
    }

    /// <summary>
    /// Specifies the orientation in which the carousel will lay out.
    /// </summary>
    public static void SetOrientationVertical<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlCarousel
    {
        b.SetProperty(b.Props, b.Const("orientation"), b.Const("vertical"));
    }

    /// <summary>
    /// When set, it is possible to scroll through the slides by dragging them with the mouse.
    /// </summary>
    public static void SetMouseDragging<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlCarousel
    {
        b.SetMouseDragging(b.Const(true));
    }

    /// <summary>
    /// When set, it is possible to scroll through the slides by dragging them with the mouse.
    /// </summary>
    public static void SetMouseDragging<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> mouseDragging) where T: SlCarousel
    {
        b.SetProperty(b.Props, b.Const("mouseDragging"), mouseDragging);
    }

    /// <summary>
    /// When set, it is possible to scroll through the slides by dragging them with the mouse.
    /// </summary>
    public static void SetMouseDragging<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool mouseDragging) where T: SlCarousel
    {
        b.SetMouseDragging(b.Const(mouseDragging));
    }

    /// <summary>
    /// Emitted when the active slide changes.
    /// </summary>
    public static void OnSlSlideChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: SlCarousel
    {
        b.OnSlEvent("onsl-slide-change", action);
    }

    /// <summary>
    /// Emitted when the active slide changes.
    /// </summary>
    public static void OnSlSlideChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: SlCarousel
    {
        b.OnSlSlideChange(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the active slide changes.
    /// </summary>
    public static void OnSlSlideChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: SlCarousel
    {
        b.OnSlEvent("onsl-slide-change", action);
    }

    /// <summary>
    /// Emitted when the active slide changes.
    /// </summary>
    public static void OnSlSlideChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: SlCarousel
    {
        b.OnSlSlideChange(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the active slide changes.
    /// </summary>
    public static void OnSlSlideChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.CustomEvent<SlSlideChangeDetail>>> action) where T: SlCarousel
    {
        b.OnSlEvent("onsl-slide-change", action);
    }

}