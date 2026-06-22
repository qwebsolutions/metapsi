using Metapsi;
using Metapsi.Html;
using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Metapsi.Html.Scenarios;

public static class CommonLayout
{

    public class Item
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public int Value { get; set; } = Random.Shared.Next(-20, 20);
    }

    public class Model
    {
        public string Name { get; set; } = "John";

        public List<Item> Items { get; set; } = new List<Item>();
    }

    public static HtmlDocument CommonDocument()
    {
        var model = new Model();
        model.Items = Enumerable.Range(0, 15).Select(x => new Item()).ToList();

        return HtmlBuilder.FromDefault(
            b =>
            {
                b.BodyAppend(b.ServerSideLayout(model));
            });
    }

    public static IHtmlNode ServerSideLayout(this HtmlBuilder b, Model model)
    {
        b.HeadAppend(b.HtmlScriptModule(
            (SyntaxBuilder b) =>
            {
                var appDiv = b.QuerySelector("#app");

                var app = b.NewObj<HyperType.App<Model>>(
                    b =>
                    {
                        b.SetInitModel(model);
                        //b.SetView(b.Def((LayoutBuilder b, Var<Model> model) =>
                        //{
                        //    return b.HtmlDiv(b.Text(b.Get(model, x => x.Name)));
                        //}));
                        b.SetView(b.Def<LayoutBuilder, Model, IVNode>((b, model) =>
                        {
                            return b.RenderLayout(
                                model,
                                buildButton: (b, children) =>
                                {
                                    return b.HtmlButton(
                                        b =>
                                        {
                                            b.AddStyle("background-color", "green");
                                            b.AddStyle("font-weight", "900");
                                            b.SetDisabled();
                                            b.SetProperty(b.Props, "disabled", b.Const(false));

                                            b.OnClickAction(b.MakeAction((SyntaxBuilder b, Var<Model> model) =>
                                            {
                                                var newItem = b.NewObj<Item>(
                                                    b =>
                                                    {
                                                        b.Set(x => x.Id, "client-side");
                                                        b.Set(x => x.Value, 20);
                                                    });
                                                b.Push(b.Get(model, x => x.Items), newItem);
                                                return b.Clone(model);
                                            }));
                                        },
                                        children.ToArray());
                                });
                        }));
                        b.SetNode(appDiv);
                    });
                b.SetTimeout(b.Def((SyntaxBuilder b) =>
                {
                    b.Hyperapp(app);
                    b.On(b.Document(),
                        b =>
                        {
                            b.Set(x => x.title, "Client side!");
                        });
                }),
                b.Const(5000));
            }));

        //return b.HtmlDiv(
        //    b =>
        //    {
        //        b.SetId("app");
        //    },
        //    b.HtmlDiv(b.Text(model.Name)));

        return b.Layout(
            b => b.RenderLayout(
                new ServerVar<Model>(model),
                buildButton: (b, children) =>
                {
                    return b.HtmlButton(
                        b =>
                        {
                            b.SetAttribute("disabled");
                        },
                        children);
                }));
    }

    public static Var<IVNode> RenderLayout<TLayoutBuilder>(
        this TLayoutBuilder b,
        Var<Model> model,
        Func<TLayoutBuilder, Var<IVNode>[], Var<IVNode>> buildButton)
        where TLayoutBuilder : ILayoutBuilder<TLayoutBuilder>
    {
        return b.HtmlDiv(
            b =>
            {
                b.SetId("app");
                b.AddStyle("color", "#333");
                b.AddStyle("min-width", "200px");
            },
            b.HtmlDiv(
                b =>
                {
                    b.AddStyle("display", "flex");
                    b.AddStyle("flex-direction", "column");
                    b.AddStyle("gap", "0.5rem");
                },
                b.Map(
                    b.Get(model, x => x.Items),
                    (b, item) =>
                    {
                        var color = b.If(
                            b.Get(item, x => x.Value < 10),
                            b => b.Const("red"),
                            b => b.Const("#333"));

                        var isPositive = b.Get(item, x => x.Value >= 0);

                        var backgroundColor = b.Switch(
                            b.Get(item, x => x.Value),
                            b => b.Const("white"),
                            (0, b => b.Const("#666")),
                            (1, b => b.Const("#999")));

                        return b.Optional(
                            isPositive,
                            b =>
                            {
                                return b.HtmlDiv(
                                    b =>
                                    {
                                        b.AddStyle("max-width", "400px");
                                        b.AddStyle("border", "1px solid #eee");
                                        b.AddStyle("border-radius", "0.2rem");
                                        b.AddStyle("padding", "0.5rem");
                                        b.AddStyle("display", "flex");
                                        b.AddStyle("gap", "0.5rem");
                                        b.AddStyle("color", color);
                                        b.AddStyle("background-color", backgroundColor);
                                    },
                                    b.HtmlDiv(
                                        b =>
                                        {

                                        },
                                        b.Text(b.Get(item, x => x.Id))),
                                    b.HtmlDiv(
                                        b =>
                                        {
                                        },
                                        b.Text(b.AsString(b.Get(item, x => x.Value)))));
                            });
                    })),
            b.HtmlDiv(
                b =>
                {
                    b.AddStyle("color", "red");
                },
                b.Text("TEST")),
            buildButton(b, [b.Text("Click me")]));
    }

    public static IHtmlNode Layout(
        this HtmlBuilder b,
        System.Func<ServerSideLayoutBuilder, Var<IVNode>> buildNode)
    {
        var layoutBuilder = new ServerSideLayoutBuilder(b);
        Var<IVNode> node = buildNode(layoutBuilder);
        IHtmlNode outNode = ServerSideLayoutBuilder.GetValue(node) as IHtmlNode;
        return outNode;
    }

    public static Var<IVNode> HtmlDiv(this ILayoutBuilder b, System.Action<IHtmlPropsBuilder<HtmlButton>> buildProps, params Var<IVNode>[] children)
    {
        return b.Tag("div", buildProps, children);
    }

    public static Var<IVNode> HtmlDiv(this ILayoutBuilder b, System.Action<IHtmlPropsBuilder<HtmlButton>> buildProps, Var<List<IVNode>> children)
    {
        return b.Tag("div", buildProps, children);
    }

    public static Var<IVNode> Tag<TElement>(this ILayoutBuilder b, string tagName, System.Action<IHtmlPropsBuilder<TElement>> buildProps, params Var<IVNode>[] children)
    {
        var propsBuilder = b.GetPropsBuilder<TElement>();
        buildProps(propsBuilder);
        return b.Tag(b.Const(tagName), propsBuilder.GetProps(), b.ToList(children));
    }

    public static Var<IVNode> Tag<TElement>(this ILayoutBuilder b, string tagName, System.Action<IHtmlPropsBuilder<TElement>> buildProps, Var<List<IVNode>> children)
    {
        var propsBuilder = b.GetPropsBuilder<TElement>();
        buildProps(propsBuilder);
        return b.Tag(b.Const(tagName), propsBuilder.GetProps(), children);
    }

    //public static TNode Text<TNode>(this IHtmlBuilder<TNode> b, string text)
    //{
    //    return b.Text(text);
    //}

    public static Var<IVNode> HtmlButton(this ILayoutBuilder b, System.Action<IHtmlPropsBuilder<HtmlButton>> buildProps, params Var<IVNode>[] children)
    {
        return b.Tag("button", buildProps, children);
        //var attrsBuilder = b.GetPropsBuilder<HtmlButton>();
        //buildProps(attrsBuilder);
        //return b.Tag("button", attrsBuilder.GetProps(), children);
    }
}

public class ServerSideLayoutBuilder : ILayoutBuilder<ServerSideLayoutBuilder>
{
    private readonly HtmlBuilder htmlBuilder;

    public ServerSideLayoutBuilder(HtmlBuilder htmlBuilder)
    {
        this.htmlBuilder = htmlBuilder;
    }

    internal static T GetValue<T>(Var<T> var)
    {
        return (var as ServerVar<T>).ServerSideValue;
    }

    public Var<string> AsString<T>(Var<T> value)
    {
        return new ServerVar<string>(GetValue(value).ToString());
    }

    public Var<T> Const<T>(T value)
    {
        return new ServerVar<T>(value);
    }

    public Var<TResult> Get<TInput, TResult>(Var<TInput> input, Expression<Func<TInput, TResult>> expression)
    {
        var outValue = expression.Compile()(GetValue(input));
        return new ServerVar<TResult>(outValue);
    }

    public IHtmlPropsBuilder<TElement> GetPropsBuilder<TElement>()
    {
        return new AttributesBuilder<TElement>();
    }

    public Var<TResult> If<TResult>(Var<bool> check, Func<ServerSideLayoutBuilder, Var<TResult>> ifTrue, Func<ServerSideLayoutBuilder, Var<TResult>> ifFalse)
    {
        if (GetValue(check))
        {
            var trueResult = ifTrue(this);
            return new ServerVar<TResult>(GetValue(trueResult));
        }
        else
        {
            var falseResult = ifFalse(this);
            return new ServerVar<TResult>(GetValue(falseResult));
        }
    }

    public Var<List<TOut>> Map<TIn, TOut>(Var<List<TIn>> list, Func<ServerSideLayoutBuilder, Var<TIn>, Var<TOut>> transform)
    {
        var inList = GetValue(list);
        List<TOut> outList = new List<TOut>();
        foreach (var item in inList)
        {
            var outItem = transform(this, new ServerVar<TIn>(item));
            outList.Add(GetValue(outItem));
        }

        return new ServerVar<List<TOut>>(outList);
    }

    public Var<IVNode> Optional(Var<bool> ifValue, Func<ServerSideLayoutBuilder, Var<IVNode>> buildControl)
    {
        if (GetValue(ifValue))
        {
            return buildControl(this);
        }
        return new ServerVar<IVNode>(null);
    }

    public Var<TResult> Switch<TResult, TInput>(Var<TInput> v, Func<ServerSideLayoutBuilder, Var<TResult>> @default, params (TInput, Func<ServerSideLayoutBuilder, Var<TResult>>)[] cases)
    {
        var onValue = GetValue(v);
        foreach (var variant in cases)
        {
            if (EqualityComparer<TInput>.Default.Equals(onValue, variant.Item1))
            {
                return variant.Item2(this);
            }
        }
        var defaultValue = @default(this);
        return defaultValue;
    }

    public Var<IVNode> Tag(Var<string> tagName, Var<IHtmlProps> props, Var<List<IVNode>> children)
    {
        var childrenNodes = GetValue(children).Select(x => x).Cast<IHtmlNode>().ToList();

        HtmlTag node = HtmlBuilderExtensions.Tag(
            this.htmlBuilder,
            GetValue(tagName),
            GetValue(props) as HtmlAttributes,
            childrenNodes) as HtmlTag;
        return new ServerVar<IVNode>(node);
    }

    public Var<IVNode> Text(Var<string> text)
    {
        HtmlText htmlText = this.htmlBuilder.Text(GetValue(text)) as HtmlText;
        return new ServerVar<IVNode>(htmlText);
    }

    public Var<List<T>> ToList<T>(IEnumerable<Var<T>> items)
    {
        return new ServerVar<List<T>>(items.Select(x => GetValue(x)).ToList());
    }
}