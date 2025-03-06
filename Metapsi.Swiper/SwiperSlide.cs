using Metapsi.Html;
using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;

namespace Metapsi.Swiper;

public class SwiperSlide
{
}

public static partial class Control
{
    public static IHtmlNode SwiperSlide(this HtmlBuilder b, Action<AttributesBuilder<SwiperSlide>> setProps, params IHtmlNode[] slides)
    {
        b.ImportSwiper();
        return b.Tag("swiper-slide", setProps, slides);
    }

    public static Var<IVNode> SwiperSlide(this LayoutBuilder b, Action<PropsBuilder<SwiperSlide>> setProps, Var<List<IVNode>> slides)
    {
        b.ImportSwiper();
        return b.H("swiper-slide", setProps, slides);
    }

    public static Var<IVNode> SwiperSlide(this LayoutBuilder b, Action<PropsBuilder<SwiperSlide>> setProps, params Var<IVNode>[] slides)
    {
        b.ImportSwiper();
        return b.H("swiper-slide", setProps, slides);
    }
}
