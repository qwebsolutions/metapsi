using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Shoelace;


public partial class SlCarousel : SlComponent
{
    public SlCarousel() : base("sl-carousel") { }
    /// <summary>
    /// When set, allows the user to navigate the carousel in the same direction indefinitely.
    /// </summary>
    public bool loop
    {
        get
        {
            return this.GetTag().GetAttribute<bool>("loop");
        }
        set
        {
            if (!value) return;
            this.GetTag().SetAttribute("loop", value.ToString());
        }
    }

    /// <summary>
    /// When set, show the carousel's navigation.
    /// </summary>
    public bool navigation
    {
        get
        {
            return this.GetTag().GetAttribute<bool>("navigation");
        }
        set
        {
            if (!value) return;
            this.GetTag().SetAttribute("navigation", value.ToString());
        }
    }

    /// <summary>
    /// When set, show the carousel's pagination indicators.
    /// </summary>
    public bool pagination
    {
        get
        {
            return this.GetTag().GetAttribute<bool>("pagination");
        }
        set
        {
            if (!value) return;
            this.GetTag().SetAttribute("pagination", value.ToString());
        }
    }

    /// <summary>
    /// When set, the slides will scroll automatically when the user is not interacting with them.
    /// </summary>
    public bool autoplay
    {
        get
        {
            return this.GetTag().GetAttribute<bool>("autoplay");
        }
        set
        {
            if (!value) return;
            this.GetTag().SetAttribute("autoplay", value.ToString());
        }
    }

    /// <summary>
    /// Specifies the amount of time, in milliseconds, between each automatic scroll.
    /// </summary>
    public int autoplayInterval
    {
        get
        {
            return this.GetTag().GetAttribute<int>("autoplay-interval");
        }
        set
        {
            this.GetTag().SetAttribute("autoplay-interval", value.ToString());
        }
    }

    /// <summary>
    /// Specifies how many slides should be shown at a given time.
    /// </summary>
    public int slidesPerPage
    {
        get
        {
            return this.GetTag().GetAttribute<int>("slides-per-page");
        }
        set
        {
            this.GetTag().SetAttribute("slides-per-page", value.ToString());
        }
    }

    /// <summary>
    /// Specifies the number of slides the carousel will advance when scrolling, useful when specifying a `slides-per-page` greater than one. It can't be higher than `slides-per-page`.
    /// </summary>
    public int slidesPerMove
    {
        get
        {
            return this.GetTag().GetAttribute<int>("slides-per-move");
        }
        set
        {
            this.GetTag().SetAttribute("slides-per-move", value.ToString());
        }
    }

    /// <summary>
    /// Specifies the orientation in which the carousel will lay out.
    /// </summary>
    public string orientation
    {
        get
        {
            return this.GetTag().GetAttribute<string>("orientation");
        }
        set
        {
            this.GetTag().SetAttribute("orientation", value.ToString());
        }
    }

    /// <summary>
    /// When set, it is possible to scroll through the slides by dragging them with the mouse.
    /// </summary>
    public bool mouseDragging
    {
        get
        {
            return this.GetTag().GetAttribute<bool>("mouse-dragging");
        }
        set
        {
            if (!value) return;
            this.GetTag().SetAttribute("mouse-dragging", value.ToString());
        }
    }

    public static class Slot
    {
        /// <summary> 
        /// Optional next icon to use instead of the default. Works best with `<sl-icon>`.
        /// </summary>
        public const string NextIcon = "next-icon";
        /// <summary> 
        /// Optional previous icon to use instead of the default. Works best with `<sl-icon>`.
        /// </summary>
        public const string PreviousIcon = "previous-icon";
    }
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

public static partial class SlCarouselControl
{
    /// <summary>
    /// Carousels display an arbitrary number of content slides along a horizontal or vertical axis.
    /// </summary>
    public static Var<IVNode> SlCarousel(this LayoutBuilder b, Action<PropsBuilder<SlCarousel>> buildProps, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-carousel", buildProps, children);
    }
    /// <summary>
    /// Carousels display an arbitrary number of content slides along a horizontal or vertical axis.
    /// </summary>
    public static Var<IVNode> SlCarousel(this LayoutBuilder b, Action<PropsBuilder<SlCarousel>> buildProps, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-carousel", buildProps, children);
    }
    /// <summary>
    /// Carousels display an arbitrary number of content slides along a horizontal or vertical axis.
    /// </summary>
    public static Var<IVNode> SlCarousel(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-carousel", children);
    }
    /// <summary>
    /// Carousels display an arbitrary number of content slides along a horizontal or vertical axis.
    /// </summary>
    public static Var<IVNode> SlCarousel(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-carousel", children);
    }
    /// <summary>
    /// When set, allows the user to navigate the carousel in the same direction indefinitely.
    /// </summary>
    public static void SetLoop(this PropsBuilder<SlCarousel> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("loop"), b.Const(true));
    }

    /// <summary>
    /// When set, show the carousel's navigation.
    /// </summary>
    public static void SetNavigation(this PropsBuilder<SlCarousel> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("navigation"), b.Const(true));
    }

    /// <summary>
    /// When set, show the carousel's pagination indicators.
    /// </summary>
    public static void SetPagination(this PropsBuilder<SlCarousel> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("pagination"), b.Const(true));
    }

    /// <summary>
    /// When set, the slides will scroll automatically when the user is not interacting with them.
    /// </summary>
    public static void SetAutoplay(this PropsBuilder<SlCarousel> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("autoplay"), b.Const(true));
    }

    /// <summary>
    /// Specifies the amount of time, in milliseconds, between each automatic scroll.
    /// </summary>
    public static void SetAutoplayInterval(this PropsBuilder<SlCarousel> b, Var<int> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("autoplay-interval"), value);
    }
    /// <summary>
    /// Specifies the amount of time, in milliseconds, between each automatic scroll.
    /// </summary>
    public static void SetAutoplayInterval(this PropsBuilder<SlCarousel> b, int value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("autoplay-interval"), b.Const(value));
    }

    /// <summary>
    /// Specifies how many slides should be shown at a given time.
    /// </summary>
    public static void SetSlidesPerPage(this PropsBuilder<SlCarousel> b, Var<int> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("slides-per-page"), value);
    }
    /// <summary>
    /// Specifies how many slides should be shown at a given time.
    /// </summary>
    public static void SetSlidesPerPage(this PropsBuilder<SlCarousel> b, int value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("slides-per-page"), b.Const(value));
    }

    /// <summary>
    /// Specifies the number of slides the carousel will advance when scrolling, useful when specifying a `slides-per-page` greater than one. It can't be higher than `slides-per-page`.
    /// </summary>
    public static void SetSlidesPerMove(this PropsBuilder<SlCarousel> b, Var<int> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("slides-per-move"), value);
    }
    /// <summary>
    /// Specifies the number of slides the carousel will advance when scrolling, useful when specifying a `slides-per-page` greater than one. It can't be higher than `slides-per-page`.
    /// </summary>
    public static void SetSlidesPerMove(this PropsBuilder<SlCarousel> b, int value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("slides-per-move"), b.Const(value));
    }

    /// <summary>
    /// Specifies the orientation in which the carousel will lay out.
    /// </summary>
    public static void SetOrientationHorizontal(this PropsBuilder<SlCarousel> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("orientation"), b.Const("horizontal"));
    }
    /// <summary>
    /// Specifies the orientation in which the carousel will lay out.
    /// </summary>
    public static void SetOrientationVertical(this PropsBuilder<SlCarousel> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("orientation"), b.Const("vertical"));
    }

    /// <summary>
    /// When set, it is possible to scroll through the slides by dragging them with the mouse.
    /// </summary>
    public static void SetMouseDragging(this PropsBuilder<SlCarousel> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("mouseDragging"), b.Const(true));
    }

    /// <summary>
    /// Emitted when the active slide changes.
    /// </summary>
    public static void OnSlSlideChange<TModel>(this PropsBuilder<SlCarousel> b, Var<HyperType.Action<TModel, DomEvent>> action)
    {
        b.OnEventAction("onsl-slide-change", action);
    }
    /// <summary>
    /// Emitted when the active slide changes.
    /// </summary>
    public static void OnSlSlideChange<TModel>(this PropsBuilder<SlCarousel> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-slide-change", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the active slide changes.
    /// </summary>
    public static void OnSlSlideChange<TModel>(this PropsBuilder<SlCarousel> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onsl-slide-change", action);
    }
    /// <summary>
    /// Emitted when the active slide changes.
    /// </summary>
    public static void OnSlSlideChange<TModel>(this PropsBuilder<SlCarousel> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-slide-change", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the active slide changes.
    /// </summary>
    public static void OnSlSlideChange<TModel>(this PropsBuilder<SlCarousel> b, Var<HyperType.Action<TModel, SlSlideChangeEventArgs>> action)
    {
        b.OnEventAction("onsl-slide-change", action, "detail");
    }
    /// <summary>
    /// Emitted when the active slide changes.
    /// </summary>
    public static void OnSlSlideChange<TModel>(this PropsBuilder<SlCarousel> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SlSlideChangeEventArgs>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-slide-change", b.MakeAction(action), "detail");
    }

}

