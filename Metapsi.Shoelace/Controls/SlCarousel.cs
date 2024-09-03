using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Shoelace;


public partial class SlCarousel
{
    /// <summary>
    ///
    /// </summary>
    public static class Slot
    {
        /// <summary>
        /// <para> Optional next icon to use instead of the default. Works best with `&lt;sl-icon&gt;`. </para>
        /// </summary>
        public const string NextIcon = "next-icon";
        /// <summary>
        /// <para> Optional previous icon to use instead of the default. Works best with `&lt;sl-icon&gt;`. </para>
        /// </summary>
        public const string PreviousIcon = "previous-icon";
    }
    public static class Method
    {
        /// <summary>
        /// <para> Move the carousel backward by `slides-per-move` slides. </para>
        /// </summary>
        public const string Previous = "previous";
        /// <summary>
        /// <para> Move the carousel forward by `slides-per-move` slides. </para>
        /// </summary>
        public const string Next = "next";
        /// <summary>
        /// <para> Scrolls the carousel to the slide specified by `index`. </para>
        /// </summary>
        public const string GoToSlide = "goToSlide";
    }
}

public static partial class SlCarouselControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlCarousel(this HtmlBuilder b, Action<AttributesBuilder<SlCarousel>> buildAttributes, params IHtmlNode[] children)
    {
        return b.SlTag("sl-carousel", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlCarousel(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.SlTag("sl-carousel", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlCarousel(this HtmlBuilder b, Action<AttributesBuilder<SlCarousel>> buildAttributes, List<IHtmlNode> children)
    {
        return b.SlTag("sl-carousel", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlCarousel(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.SlTag("sl-carousel", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> When set, allows the user to navigate the carousel in the same direction indefinitely. </para>
    /// </summary>
    public static void SetLoop(this AttributesBuilder<SlCarousel> b)
    {
        b.SetAttribute("loop", "");
    }

    /// <summary>
    /// <para> When set, allows the user to navigate the carousel in the same direction indefinitely. </para>
    /// </summary>
    public static void SetLoop(this AttributesBuilder<SlCarousel> b, bool loop)
    {
        if (loop) b.SetAttribute("loop", "");
    }

    /// <summary>
    /// <para> When set, show the carousel's navigation. </para>
    /// </summary>
    public static void SetNavigation(this AttributesBuilder<SlCarousel> b)
    {
        b.SetAttribute("navigation", "");
    }

    /// <summary>
    /// <para> When set, show the carousel's navigation. </para>
    /// </summary>
    public static void SetNavigation(this AttributesBuilder<SlCarousel> b, bool navigation)
    {
        if (navigation) b.SetAttribute("navigation", "");
    }

    /// <summary>
    /// <para> When set, show the carousel's pagination indicators. </para>
    /// </summary>
    public static void SetPagination(this AttributesBuilder<SlCarousel> b)
    {
        b.SetAttribute("pagination", "");
    }

    /// <summary>
    /// <para> When set, show the carousel's pagination indicators. </para>
    /// </summary>
    public static void SetPagination(this AttributesBuilder<SlCarousel> b, bool pagination)
    {
        if (pagination) b.SetAttribute("pagination", "");
    }

    /// <summary>
    /// <para> When set, the slides will scroll automatically when the user is not interacting with them. </para>
    /// </summary>
    public static void SetAutoplay(this AttributesBuilder<SlCarousel> b)
    {
        b.SetAttribute("autoplay", "");
    }

    /// <summary>
    /// <para> When set, the slides will scroll automatically when the user is not interacting with them. </para>
    /// </summary>
    public static void SetAutoplay(this AttributesBuilder<SlCarousel> b, bool autoplay)
    {
        if (autoplay) b.SetAttribute("autoplay", "");
    }

    /// <summary>
    /// <para> Specifies the amount of time, in milliseconds, between each automatic scroll. </para>
    /// </summary>
    public static void SetAutoplayInterval(this AttributesBuilder<SlCarousel> b, string autoplayInterval)
    {
        b.SetAttribute("autoplay-interval", autoplayInterval);
    }

    /// <summary>
    /// <para> Specifies how many slides should be shown at a given time. </para>
    /// </summary>
    public static void SetSlidesPerPage(this AttributesBuilder<SlCarousel> b, string slidesPerPage)
    {
        b.SetAttribute("slides-per-page", slidesPerPage);
    }

    /// <summary>
    /// <para> Specifies the number of slides the carousel will advance when scrolling, useful when specifying a `slides-per-page` greater than one. It can't be higher than `slides-per-page`. </para>
    /// </summary>
    public static void SetSlidesPerMove(this AttributesBuilder<SlCarousel> b, string slidesPerMove)
    {
        b.SetAttribute("slides-per-move", slidesPerMove);
    }

    /// <summary>
    /// <para> Specifies the orientation in which the carousel will lay out. </para>
    /// </summary>
    public static void SetOrientation(this AttributesBuilder<SlCarousel> b, string orientation)
    {
        b.SetAttribute("orientation", orientation);
    }

    /// <summary>
    /// <para> Specifies the orientation in which the carousel will lay out. </para>
    /// </summary>
    public static void SetOrientationHorizontal(this AttributesBuilder<SlCarousel> b)
    {
        b.SetAttribute("orientation", "horizontal");
    }

    /// <summary>
    /// <para> Specifies the orientation in which the carousel will lay out. </para>
    /// </summary>
    public static void SetOrientationVertical(this AttributesBuilder<SlCarousel> b)
    {
        b.SetAttribute("orientation", "vertical");
    }

    /// <summary>
    /// <para> When set, it is possible to scroll through the slides by dragging them with the mouse. </para>
    /// </summary>
    public static void SetMouseDragging(this AttributesBuilder<SlCarousel> b)
    {
        b.SetAttribute("mouse-dragging", "");
    }

    /// <summary>
    /// <para> When set, it is possible to scroll through the slides by dragging them with the mouse. </para>
    /// </summary>
    public static void SetMouseDragging(this AttributesBuilder<SlCarousel> b, bool mouseDragging)
    {
        if (mouseDragging) b.SetAttribute("mouse-dragging", "");
    }

    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlCarousel(this LayoutBuilder b, Action<PropsBuilder<SlCarousel>> buildProps, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-carousel", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlCarousel(this LayoutBuilder b, Action<PropsBuilder<SlCarousel>> buildProps, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-carousel", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlCarousel(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-carousel", children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlCarousel(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-carousel", children);
    }
    /// <summary>
    /// <para> When set, allows the user to navigate the carousel in the same direction indefinitely. </para>
    /// </summary>
    public static void SetLoop<T>(this PropsBuilder<T> b) where T: SlCarousel
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("loop"), b.Const(true));
    }


    /// <summary>
    /// <para> When set, allows the user to navigate the carousel in the same direction indefinitely. </para>
    /// </summary>
    public static void SetLoop<T>(this PropsBuilder<T> b, Var<bool> loop) where T: SlCarousel
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("loop"), loop);
    }

    /// <summary>
    /// <para> When set, allows the user to navigate the carousel in the same direction indefinitely. </para>
    /// </summary>
    public static void SetLoop<T>(this PropsBuilder<T> b, bool loop) where T: SlCarousel
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("loop"), b.Const(loop));
    }


    /// <summary>
    /// <para> When set, show the carousel's navigation. </para>
    /// </summary>
    public static void SetNavigation<T>(this PropsBuilder<T> b) where T: SlCarousel
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("navigation"), b.Const(true));
    }


    /// <summary>
    /// <para> When set, show the carousel's navigation. </para>
    /// </summary>
    public static void SetNavigation<T>(this PropsBuilder<T> b, Var<bool> navigation) where T: SlCarousel
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("navigation"), navigation);
    }

    /// <summary>
    /// <para> When set, show the carousel's navigation. </para>
    /// </summary>
    public static void SetNavigation<T>(this PropsBuilder<T> b, bool navigation) where T: SlCarousel
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("navigation"), b.Const(navigation));
    }


    /// <summary>
    /// <para> When set, show the carousel's pagination indicators. </para>
    /// </summary>
    public static void SetPagination<T>(this PropsBuilder<T> b) where T: SlCarousel
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("pagination"), b.Const(true));
    }


    /// <summary>
    /// <para> When set, show the carousel's pagination indicators. </para>
    /// </summary>
    public static void SetPagination<T>(this PropsBuilder<T> b, Var<bool> pagination) where T: SlCarousel
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("pagination"), pagination);
    }

    /// <summary>
    /// <para> When set, show the carousel's pagination indicators. </para>
    /// </summary>
    public static void SetPagination<T>(this PropsBuilder<T> b, bool pagination) where T: SlCarousel
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("pagination"), b.Const(pagination));
    }


    /// <summary>
    /// <para> When set, the slides will scroll automatically when the user is not interacting with them. </para>
    /// </summary>
    public static void SetAutoplay<T>(this PropsBuilder<T> b) where T: SlCarousel
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("autoplay"), b.Const(true));
    }


    /// <summary>
    /// <para> When set, the slides will scroll automatically when the user is not interacting with them. </para>
    /// </summary>
    public static void SetAutoplay<T>(this PropsBuilder<T> b, Var<bool> autoplay) where T: SlCarousel
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("autoplay"), autoplay);
    }

    /// <summary>
    /// <para> When set, the slides will scroll automatically when the user is not interacting with them. </para>
    /// </summary>
    public static void SetAutoplay<T>(this PropsBuilder<T> b, bool autoplay) where T: SlCarousel
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("autoplay"), b.Const(autoplay));
    }


    /// <summary>
    /// <para> Specifies the amount of time, in milliseconds, between each automatic scroll. </para>
    /// </summary>
    public static void SetAutoplayInterval<T>(this PropsBuilder<T> b, Var<int> autoplayInterval) where T: SlCarousel
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("autoplayInterval"), autoplayInterval);
    }

    /// <summary>
    /// <para> Specifies the amount of time, in milliseconds, between each automatic scroll. </para>
    /// </summary>
    public static void SetAutoplayInterval<T>(this PropsBuilder<T> b, int autoplayInterval) where T: SlCarousel
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("autoplayInterval"), b.Const(autoplayInterval));
    }


    /// <summary>
    /// <para> Specifies how many slides should be shown at a given time. </para>
    /// </summary>
    public static void SetSlidesPerPage<T>(this PropsBuilder<T> b, Var<int> slidesPerPage) where T: SlCarousel
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("slidesPerPage"), slidesPerPage);
    }

    /// <summary>
    /// <para> Specifies how many slides should be shown at a given time. </para>
    /// </summary>
    public static void SetSlidesPerPage<T>(this PropsBuilder<T> b, int slidesPerPage) where T: SlCarousel
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("slidesPerPage"), b.Const(slidesPerPage));
    }


    /// <summary>
    /// <para> Specifies the number of slides the carousel will advance when scrolling, useful when specifying a `slides-per-page` greater than one. It can't be higher than `slides-per-page`. </para>
    /// </summary>
    public static void SetSlidesPerMove<T>(this PropsBuilder<T> b, Var<int> slidesPerMove) where T: SlCarousel
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("slidesPerMove"), slidesPerMove);
    }

    /// <summary>
    /// <para> Specifies the number of slides the carousel will advance when scrolling, useful when specifying a `slides-per-page` greater than one. It can't be higher than `slides-per-page`. </para>
    /// </summary>
    public static void SetSlidesPerMove<T>(this PropsBuilder<T> b, int slidesPerMove) where T: SlCarousel
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("slidesPerMove"), b.Const(slidesPerMove));
    }


    /// <summary>
    /// <para> Specifies the orientation in which the carousel will lay out. </para>
    /// </summary>
    public static void SetOrientationHorizontal<T>(this PropsBuilder<T> b) where T: SlCarousel
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("orientation"), b.Const("horizontal"));
    }


    /// <summary>
    /// <para> Specifies the orientation in which the carousel will lay out. </para>
    /// </summary>
    public static void SetOrientationVertical<T>(this PropsBuilder<T> b) where T: SlCarousel
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("orientation"), b.Const("vertical"));
    }


    /// <summary>
    /// <para> When set, it is possible to scroll through the slides by dragging them with the mouse. </para>
    /// </summary>
    public static void SetMouseDragging<T>(this PropsBuilder<T> b) where T: SlCarousel
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("mouseDragging"), b.Const(true));
    }


    /// <summary>
    /// <para> When set, it is possible to scroll through the slides by dragging them with the mouse. </para>
    /// </summary>
    public static void SetMouseDragging<T>(this PropsBuilder<T> b, Var<bool> mouseDragging) where T: SlCarousel
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("mouseDragging"), mouseDragging);
    }

    /// <summary>
    /// <para> When set, it is possible to scroll through the slides by dragging them with the mouse. </para>
    /// </summary>
    public static void SetMouseDragging<T>(this PropsBuilder<T> b, bool mouseDragging) where T: SlCarousel
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("mouseDragging"), b.Const(mouseDragging));
    }


    /// <summary>
    /// <para> Emitted when the active slide changes. </para>
    /// </summary>
    public static void OnSlSlideChange<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, DomEvent>> action) where TComponent: SlCarousel
    {
        b.OnEventAction("onsl-slide-change", action);
    }
    /// <summary>
    /// <para> Emitted when the active slide changes. </para>
    /// </summary>
    public static void OnSlSlideChange<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action) where TComponent: SlCarousel
    {
        b.OnEventAction("onsl-slide-change", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the active slide changes. </para>
    /// </summary>
    public static void OnSlSlideChange<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: SlCarousel
    {
        b.OnEventAction("onsl-slide-change", action);
    }
    /// <summary>
    /// <para> Emitted when the active slide changes. </para>
    /// </summary>
    public static void OnSlSlideChange<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: SlCarousel
    {
        b.OnEventAction("onsl-slide-change", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the active slide changes. </para>
    /// </summary>
    public static void OnSlSlideChange<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, SlSlideChangeEventArgs>> action) where TComponent: SlCarousel
    {
        b.OnEventAction("onsl-slide-change", action, "detail");
    }
    /// <summary>
    /// <para> Emitted when the active slide changes. </para>
    /// </summary>
    public static void OnSlSlideChange<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SlSlideChangeEventArgs>, Var<TModel>> action) where TComponent: SlCarousel
    {
        b.OnEventAction("onsl-slide-change", b.MakeAction(action), "detail");
    }

}

