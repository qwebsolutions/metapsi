using Metapsi.Html;
using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;

namespace Metapsi.Swiper;

public class SwiperContainer
{
}

public static partial class Control
{
    private static void AddSwiper(this SyntaxBuilder b)
    {
        string scriptPath = $"swiper@{Cdn.Version}/swiper-element-bundle.mjs";
        var resource = b.AddEmbeddedResourceMetadata(typeof(SwiperContainer).Assembly, scriptPath);
        var register = b.ImportName<Action>(resource, "register");
        b.Call(register);
    }

    public static IHtmlNode SwiperContainer(this HtmlBuilder b, Action<AttributesBuilder<SwiperContainer>> setProps, params IHtmlNode[] slides)
    {
        b.HeadAppend(b.HtmlScriptModule(AddSwiper));
        return b.Tag("swiper-container", setProps, slides);
    }

    public static Var<IVNode> SwiperContainer(this LayoutBuilder b, Action<PropsBuilder<SwiperContainer>> setProps, Var<List<IVNode>> slides)
    {
        b.AddSwiper();
        var nodeProps = b.SetProps(b.NewObj(), setProps);
        return b.H(b.Const("swiper-container"), nodeProps.As<object>(), slides);
    }

    public static Var<IVNode> SwiperContainer(this LayoutBuilder b, Action<PropsBuilder<SwiperContainer>> setProps, params Var<IVNode>[] slides)
    {
        b.AddSwiper();
        return b.SwiperContainer(setProps, b.List(slides));
    }
}
