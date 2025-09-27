
using Metapsi;
using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ionic;
using Metapsi.Html;

namespace Metapsi.Html.Scenarios;

public static partial class MediaLoaderExtensions
{
    public static IHtmlNode MediaLoader(
        this HtmlBuilder b,
        Action<AttributesBuilder<MediaLoader>> setAttributes = null)
    {
        var mediaLoaderTag = new MediaLoader().Tag;
        b.HeadAppend(b.CustomElementSrcScript(mediaLoaderTag));
        return b.Tag(mediaLoaderTag, setAttributes);
    }

    public static void SetSrc(this AttributesBuilder<MediaLoader> b, string src)
    {
        b.SetAttribute("src", src);
    }

    public static void SetInitProps<T, TProps>(this AttributesBuilder<T> b)
        where T: ICustomElementProps<TProps>
    {
        throw new NotImplementedException();
    }

    public static Var<IVNode> MediaLoader(
        this LayoutBuilder b,
        Action<PropsBuilder<MediaLoader.Props>> setProps)
    {
        b.Metadata().AddRequiredTagMetadata(b.CustomElementSrcScript(new MediaLoader().Tag));
        return b.H(new MediaLoader().Tag, setProps);
    }
}

public class MediaLoader : CustomElement<MediaLoader.Model, MediaLoader.Props>
{
    public MediaLoader()
    {
        this.Tag = "qweb-media-loader";
    }

    public class Model
    {
        public bool Loading { get; set; } = false;
        public string Src { get; set; }
        public int Width { get; set; } = 500;
        public int Height { get; set; } = 500;
    }

    public class Props
    {
        public string Src { get; set; }
        public int Width { get; set; } = 500;
        public int Height { get; set; } = 500;
    }

    public override Var<HyperType.StateWithEffects> OnInit(SyntaxBuilder b, Var<Element> element)
    {
        b.Log(element);
        var src = b.GetAttribute<string>(element, b.Const("src"));
        b.Log(src);
        return OnInitProps(b, b.NewObj<Props>(
            b =>
            {
                b.Set(x => x.Src, src);
            }));
    }

    public override Var<HyperType.StateWithEffects> OnInitProps(SyntaxBuilder b, Var<Props> props)
    {
        return b.MakeStateWithEffects(b.NewObj<MediaLoader.Model>(
            b =>
            {
                b.Set(x => x.Src, b.Get(props, x => x.Src));
            }));
    }

    public override IRootControl OnRender(LayoutBuilder b, Var<Model> model)
    {
        return this.Root(
            b =>
            {
                b.AddStyle("width", b.Concat(b.AsString(b.Get(model, x => x.Width)), b.Const("px")));
                b.AddStyle("height", b.Concat(b.AsString(b.Get(model, x => x.Height)), b.Const("px")));
                b.AddStyle("display", "flex");
                b.AddStyle("flex-direction", "column");
                b.AddStyle("align-items", "center");
                b.AddStyle("justify-content", "center");
            },
            b.Optional(
                b.Get(model, x => x.Loading),
                b =>
                {
                    return b.IonSpinner();
                }),
            b.Optional(
                b.Not(b.Get(model, x => x.Loading)),
                b =>
                {
                    return b.IonImg(
                        b =>
                        {
                            b.AddStyle("height", "100%");
                            b.SetSrc(b.Get(model, x => x.Src));
                            b.OnIonError(b.MakeAction((SyntaxBuilder b, Var<Model> model, Var<Metapsi.Html.Event> e) =>
                            {
                                //b.Log("Error", e);
                                b.Set(model, x => x.Loading, true);
                                return b.Clone(model);
                            }));
                        });
                }));
    }

    public override void OnSubscribe(SyntaxBuilder b, Var<Model> model, Var<List<HyperType.Subscription>> subscriptions)
    {
        b.If(
            b.Not(b.Get(model, x => x.Loading)),
            b =>
            {
                b.Push(subscriptions, b.Const(false).As<HyperType.Subscription>());
            },
            b =>
            {
                b.Push(
                    subscriptions,
                    b.Every<Model>(TimeSpan.FromMilliseconds(500),
                    b.MakeAction((SyntaxBuilder b, Var<Model> model, Var<long> tick) =>
                    {
                        return b.MakeStateWithEffects(
                            model,
                            (b, dispatch) =>
                            {
                                var fetchPromise = b.Fetch(b.Get(model, x => x.Src));
                                b.PromiseThen(fetchPromise, (SyntaxBuilder b, Var<Metapsi.Html.Response> r) =>
                                {
                                    b.If(
                                        b.Get(r, x => x.ok),
                                        (SyntaxBuilder b) =>
                                        {
                                            b.Set(model, x => x.Loading, false);
                                            b.Dispatch(
                                                dispatch,
                                                b.MakeStateWithEffects(
                                                    b.Clone(model)));
                                        });
                                });
                            });
                    })));
            });
    }
}