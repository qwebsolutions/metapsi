using Metapsi.Html;
using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;

namespace Metapsi.Swiper;

public class SwiperContainer
{
    public DynamicObject InitParameters { get; set; } = new DynamicObject();
}

public static partial class Control
{
    public static IHtmlNode SwiperContainer(this HtmlBuilder b, Action<AttributesBuilder<SwiperContainer>> setProps, params IHtmlNode[] slides)
    {
        EmbeddedFiles.AddAll(typeof(SwiperContainer).Assembly);
        b.HeadAppend(b.HtmlScriptModule(b => b.CallExternal($"swiper@{Cdn.Version}/swiper-element-bundle.mjs", "register")));
        return b.Tag("swiper-container", setProps, slides);
    }

    public static Var<IVNode> SwiperContainer(this LayoutBuilder b, Action<PropsBuilder<SwiperContainer>> setProps, Var<List<IVNode>> slides)
    {
        EmbeddedFiles.AddAll(typeof(SwiperContainer).Assembly);
        b.CallExternal($"swiper@{Cdn.Version}/swiper-element-bundle.mjs", "register");

        var nodeProps = b.NewObj(setProps);
        return b.H(b.Const("swiper-container"), nodeProps.As<DynamicObject>(), slides);
    }

    public static Var<IVNode> SwiperContainer(this LayoutBuilder b, Action<PropsBuilder<SwiperContainer>> setProps, params Var<IVNode>[] slides)
    {
        EmbeddedFiles.AddAll(typeof(SwiperContainer).Assembly);
        b.CallExternal($"swiper@{Cdn.Version}/swiper-element-bundle.mjs", "register");
        return b.SwiperContainer(setProps, b.List(slides));
    }

    public static void SetSwiperParameter(this PropsBuilder<SwiperContainer> b, string parameter, IVariable value)
    {
        b.SetProperty(b.Get(b.Props, x => x.InitParameters), b.Const(parameter), value);
    }
}
