using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Shoelace;


public partial class SlCarousel
{
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
        b.SetDynamic(b.Props, new DynamicProperty<int>("autoplayInterval"), value);
    }
    /// <summary>
    /// Specifies the amount of time, in milliseconds, between each automatic scroll.
    /// </summary>
    public static void SetAutoplayInterval(this PropsBuilder<SlCarousel> b, int value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("autoplayInterval"), b.Const(value));
    }

    /// <summary>
    /// Specifies how many slides should be shown at a given time.
    /// </summary>
    public static void SetSlidesPerPage(this PropsBuilder<SlCarousel> b, Var<int> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("slidesPerPage"), value);
    }
    /// <summary>
    /// Specifies how many slides should be shown at a given time.
    /// </summary>
    public static void SetSlidesPerPage(this PropsBuilder<SlCarousel> b, int value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("slidesPerPage"), b.Const(value));
    }

    /// <summary>
    /// Specifies the number of slides the carousel will advance when scrolling, useful when specifying a `slides-per-page` greater than one. It can't be higher than `slides-per-page`.
    /// </summary>
    public static void SetSlidesPerMove(this PropsBuilder<SlCarousel> b, Var<int> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("slidesPerMove"), value);
    }
    /// <summary>
    /// Specifies the number of slides the carousel will advance when scrolling, useful when specifying a `slides-per-page` greater than one. It can't be higher than `slides-per-page`.
    /// </summary>
    public static void SetSlidesPerMove(this PropsBuilder<SlCarousel> b, int value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("slidesPerMove"), b.Const(value));
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
    public static void OnSlSlideChange<TModel>(this PropsBuilder<SlCarousel> b, Var<HyperType.Action<TModel, object>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<object>("detail"));
            return b.MakeActionDescriptor<TModel, object>(action, value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onsl-slide-change"), eventAction);
    }
    /// <summary>
    /// Emitted when the active slide changes.
    /// </summary>
    public static void OnSlSlideChange<TModel>(this PropsBuilder<SlCarousel> b, System.Func<SyntaxBuilder, Var<TModel>, Var<object>, Var<TModel>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<object>("detail"));
            return b.MakeActionDescriptor<TModel, object>(b.MakeAction(action), value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onsl-slide-change"), eventAction);
    }

}

