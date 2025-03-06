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
        b.ImportSwiper();
        return b.Tag("swiper-container", setProps, slides);
    }

    public static Var<IVNode> SwiperContainer(this LayoutBuilder b, Action<PropsBuilder<SwiperContainer>> setProps, Var<List<IVNode>> slides)
    {
        b.ImportSwiper();

        var nodeProps = b.NewObj(setProps);
        var initParameters = b.Get(nodeProps, x => x.InitParameters);
        b.Push(
            slides, 
            b.HtmlScript(
                b.Text(
                    "Object.assign(document.currentScript.parentNode, window." + initParameters.Name+ ");document.currentScript.parentNode.initialize()"
                    )));
        b.DeleteProperty(nodeProps, b.Const(nameof(Metapsi.Swiper.SwiperContainer.InitParameters)));
        b.SetProperty(b.Window(), b.Const(initParameters.Name), initParameters);

        return b.H(b.Const("swiper-container"), nodeProps.As<DynamicObject>(), slides);
    }

    public static Var<IVNode> SwiperContainer(this LayoutBuilder b, Action<PropsBuilder<SwiperContainer>> setProps, params Var<IVNode>[] slides)
    {
        b.ImportSwiper();
        return b.SwiperContainer(setProps, b.List(slides));
    }

    private static void ImportSwiper(this LayoutBuilder b)
    {
        b.AddScript(typeof(Control).Assembly, "swiper-element-bundle.min.js", "module");
    }

    private static void ImportSwiper(this HtmlBuilder b)
    {
        b.AddScript(typeof(Control).Assembly, "swiper-element-bundle.min.js", "module");
    }

    public static void SetSwiperParameter(this PropsBuilder<SwiperContainer> b, string parameter, IVariable value)
    {
        b.SetProperty(b.Get(b.Props, x => x.InitParameters), b.Const(parameter), value);
    }
}
