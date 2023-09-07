using Metapsi.Hyperapp;
using Metapsi.Shoelace;
using Metapsi.Syntax;
using Metapsi.Ui;
using Microsoft.AspNetCore.Http;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Metapsi.Tutorial;


public class HomeModel : IHasTreeMenu
{
    public List<Route> Routes { get; set; } = new();
    public List<Doc> Docs { get; set; } = new();
    public bool MenuIsExpanded { get; set; }
}

public class XXXModel : IApiSupportState
{
    public ApiSupport ApiSupport { get; set; } = new();

    public string P1 { get; set; }
    public string P2 { get; set; }

    public int count { get; set; }
}

public class XXXHandler : Http.Get<Metapsi.Tutorial.Routes.XXX, string, string>
{
    public override async Task<IResult> OnGet(CommandContext commandContext, HttpContext httpContext, string firstParam, string secondParam)
    {
        return Page.Result(new XXXModel() { P1 = firstParam, P2 = secondParam });
    }
}

public static class VisibilityExtensions
{
    public static HyperAppNode<TModel> VisibleIf<TModel>(
        this HyperAppNode<TModel> clientSideNode, 
        TModel model, 
        HeadTag head, 
        System.Linq.Expressions.Expression<Func<TModel, bool>> byProperty)
    {
        var initialRender = clientSideNode.Render;

        clientSideNode.Render = (b, model) =>
        {
            b.Log(model);
            b.Log(b.Get(model, byProperty));

            return b.If(
                b.Get(model, byProperty),
                b => initialRender(b, model),
                b => b.Div());
        };

        return clientSideNode;

        /*
        mountNode.ToClientSide(model,
            (b, model) =>
            {
                return b.If(
                    b.Get(model, byProperty),
                    b => b.ServerToClient(mountNode),
                    b => b.Div());
            });*/
    }

    public static Var<HyperNode> ServerToClient(this BlockBuilder b, IHtmlTag tag)
    {
        var node = b.Node(tag.ToTag().Tag);

        foreach (var attribute in tag.ToTag().Attributes)
        {
            b.SetAttr(node, DynamicProperty.String(attribute.Key), attribute.Value);
        }

        foreach (var child in tag.ToTag().Children)
        {
            if(child is IHtmlTag)
            {
                b.Add(node, b.ServerToClient(child as IHtmlTag));
            }
            if(child is HtmlText)
            {
                b.Add(node, b.TextNode((child as HtmlText).Text));
            }
        }

        return node;
    }
}

public class XXXRenderer : HtmlPage<XXXModel>
{
    public override IHtmlNode GetHtmlTree(XXXModel dataModel)
    {
        var document = DocumentTag.Create("TITLU!");

        var span = new SpanTag();
        span.AddText("abc");

        var maybeHidden1 = document.Body.AddChild(span.ToClientSide(dataModel));
        maybeHidden1.VisibleIf(dataModel, document.Head, x => x.count > 5);
        document.Body.AddTextSpan(dataModel.P2).AddAttribute("id", "removable").ToClientSide(dataModel).VisibleIf(dataModel, document.Head, x => x.count < 5);

        
        document.Body.AddHyperapp(
            dataModel,
            (b, model) =>
            {
                var container = b.Span();

                //b.If(
                //    b.Get(model, x => x.ApiSupport.InProgress),
                //    b =>
                //    {
                //        var panel = b.Add(container, b.Div("flex flex-row w-screen h-screen bg-white fixed top-0 left-0 bottom-0 right-0 z-50"));
                //        b.Add(panel, b.Text("In progress"));
                //        b.Log("Render in progress");
                //    });

                var button = b.Add(container, b.Node("button"));
                b.Add(button, b.TextNode("INCREMENT!"));

                b.SetOnClick(button, b.MakeServerAction(model, async (cc, model) =>
                {
                    model.count++;
                    return model;
                }));

                b.Add(container, b.Text(b.AsString(b.Get(model, x => x.count))));

                return container;
            });
        
        var div = document.Body.AddChild(new DivTag());

        div.AddHyperapp(dataModel,
            (b, model) =>
            {
                var container = b.Span();

                var button = b.Add(container, b.Node("button"));
                b.Add(button, b.TextNode(" +2 !"));

                b.SetOnClick(button, b.MakeAction((BlockBuilder b, Var<XXXModel> model) =>
                {
                    b.Set(model, x => x.count, b.Get(model, x => x.count + 2));
                    b.Log(model);
                    return b.Broadcast(model);
                }));

                b.Add(container, b.Text(b.AsString(b.Get(model, x => x.count))));

                return container;
            });

        document.AttachComponents();

        //var components = document.Body.Descendants().OfType<IHtmlComponent>();
        //foreach (var component in components)
        //{
        //    component.OnMount(document);
        //}

        return document;
    }
}

public class HomeHandler : Http.Get<Metapsi.Tutorial.Routes.Home>
{
    public override async Task<IResult> OnGet(CommandContext commandContext, HttpContext httpContext)
    {
        HomeModel model = new HomeModel();
        await model.LoadRoutes();
        return Page.Result(model);
    }
}


public class HomeRenderer : HtmlPage<HomeModel>
{
    public override IHtmlNode GetHtmlTree(HomeModel dataModel)
    {
        var htmlDocument = DocumentTag.Create();
        var head = htmlDocument.Head;
        var body = htmlDocument.Body;

        head.AddModuleStylesheet();
        var largeHeader = new DivTag().AddTextSpan("Metapsi").AddInlineStyle("font-size", "var(--sl-font-size-large)");
        body.AddChild(Header(dataModel, largeHeader, head));

        body.AddHyperapp(
            dataModel,
            (b, model) =>
            {
                return b.DrawerTreeMenu(model);
            });

        var allNodes = body.Descendants();

        var slTags = allNodes.Where(x => x is IHtmlTag).Where(x => (x as IHtmlTag).ToTag().Tag.StartsWith("sl-"));

        if (slTags.Any())
        {
            head.AddChild(new ExternalScriptTag("https://cdn.jsdelivr.net/npm/@shoelace-style/shoelace@2.6.0/cdn/shoelace-autoloader.js", "module"));
            head.AddStylesheet("https://cdn.jsdelivr.net/npm/@shoelace-style/shoelace@2.6.0/cdn/themes/light.css");
        }

        htmlDocument.AttachComponents();

        //var components = htmlDocument.Body.Descendants().OfType<IHtmlComponent>();
        //foreach (var component in components)
        //{
        //    component.OnMount(htmlDocument);
        //}

        //declare server-side shoelace with common props
        //await slTags. Also include client-side tags
        return htmlDocument;
    }



    public DivTag Header<TModel>(TModel model, IHtmlNode content, HeadTag headTag)
        where TModel: IHasTreeMenu
    {
        var container = new DivTag()
            .AddClass("flex flex-row gap-4 items-center w-full px-8 py-4 fixed top-0 shadow bg-gray-50 text-xl");

        //var icon = container.AddChild(new HtmlTag("sl-icon").AddAttribute("name", "list"));

        container.AddHyperapp(
            model,
            (b, model) =>
            {
                var showMenuButton = b.IconButton("list");
                b.SetOnClick(showMenuButton, b.MakeAction((BlockBuilder b, Var<TutorialModel> model) =>
                {
                    b.Set(model, x => x.MenuIsExpanded, true);
                    return b.Broadcast(model);
                }));

                return showMenuButton;
            });

        if (content != null)
        {
            container.AddChild(content);
        }

        return container;
    }


    //public static Var<HyperNode> Header<TModel>(this BlockBuilder b, Var<TModel> model, Func<BlockBuilder, Var<HyperNode>> headerContent)
    //{
    //    var header = b.Div(
    //        "flex flex-row gap-4 items-center w-full px-8 py-4 fixed top-0 shadow bg-gray-50 text-xl",
    //        b =>
    //        {
    //            var showMenuButton = b.IconButton("list");
    //            b.SetOnClick(showMenuButton, b.MakeAction((BlockBuilder b, Var<TutorialModel> model) =>
    //            {
    //                b.Set(model, x => x.MenuIsExpanded, true);
    //                return b.Clone(model);
    //            }));

    //            return showMenuButton;
    //        },
    //        headerContent);

    //    return header;
    //}
}

/*

public class HomeRenderer : ShoelaceHyperPage<HomeModel>
{
    public override Var<HyperNode> OnRender(BlockBuilder b, Var<HomeModel> model)
    {
        b.AddModuleStylesheet();

        var largeHeader = b.Div("", b =>
        {
            var text = b.Text("Metapsi");
            b.AddStyle(text, "font-size", "var(--sl-font-size-large)");
            return text;
        });

        var page = b.Div("flex flex-col");

        var slogan = b.Add(page, b.Div(
            "flex flex-col justify-center items-center pt-36 text-gray-800",
            b =>
            {
                return b.Animation(b.Const(new Animation()
                {
                    Name = "fadeInDown",
                    Iterations = 1,
                    Duration = 300,
                    Delay = 500,
                    Play = true,
                    Fill = "both",
                    Easing = "easeOut"
                }),
                b =>
                {
                    var text = b.Span(
                        "",
                        b => b.Text("The "),
                        b => b.Text("full stack C#", "bg-blue-50"),
                        b => b.Text(" framework"));
                    b.AddStyle(text, "font-size", "var(--sl-font-size-2x-large)");
                    return text;
                });
            },
            b =>
            {
            return b.Animation(b.Const(new Animation()
            {
                Name = "fadeIn",
                Iterations = 1,
                Delay = 1000,
                Duration = 500,
                Play = true,
                Fill = "both",
                Easing = "easeOut"
            }),
            b =>
            {
                var text = b.Div(
                        "",
                        b => b.Text("that"),
                        b =>
                        {

                            var tooltip = b.Tooltip(b.Const(new Tooltip()), b => b.Text(" packs ", "underline decoration-dashed"));
                            b.SetAttr(tooltip, DynamicProperty.String("placement"), "bottom");
                            var icon = b.Add(tooltip, b.Icon("box-seam"));
                            b.SetAttr(icon, DynamicProperty.String("slot"), "content");
                            return tooltip;
                        },
                        b => b.Text("everything."));
                    b.AddStyle(text, "font-size", "var(--sl-font-size-2x-large)");
                    return text;
                });
            }));

        b.AddStyle(slogan, "font-family", "var(--sl-font-serif)");
        b.AddStyle(slogan, "font-weight", "var(--sl-font-weight-bold)");

        b.Add(page, b.Div("h-12"));

        var featuresPanel = b.Add(page, b.Div("flex flex-col bg-blue-50"));

        b.Add(featuresPanel, HomeFeature(
            b,
            b.Const("Your tools"),
            b.Const("Stay inside VS Code/Visual Studio, just add nugets and you're ready to go."),
            b.Const("No node.js, no npm required."),
            b.Const("wrench")));

        b.Add(featuresPanel, b.Div("mx-12 bg-gray-200 h-px"));

        b.Add(featuresPanel, HomeFeature(
            b,
            b.Const("Your types, everywhere"),
            b.Const("The client-side code speaks C#. One definition, shared"),
            b.Const(string.Empty),
            b.Const("arrow-left-right")));

        b.Add(featuresPanel, Separator(b));

        b.Add(featuresPanel, HomeFeature(
            b,
            b.Const("Your version, always"),
            b.Const("Resources are embedded, allowing you to upgrade & downgrade atomically"),
            b.Const("This applies to CSS, JS, images & more"),
            b.Const("box")));

        b.Add(featuresPanel, Separator(b));

        b.Add(featuresPanel, HomeFeature(
            b,
            b.Const("Your solution & nothing else"),
            b.Const("You don't use it? Then it's not included. Each HTML page knows exactly what JS files it needs."),
            b.Const("Also, nugets build on top of each other, allowing you to work as high or low level as you need"),
            b.Const("scissors")));

        b.Add(featuresPanel, Separator(b));

        b.Add(featuresPanel, HomeFeature(
            b,
            b.Const("Open source"),
            b.Const("MIT licensed, just like the great projects we build upon"),
            b.Const(string.Empty),
            b.Const("file-text")));

        b.Add(page,
            b.Div(
                "flex flex-row justify-center p-16 text-sm text-gray-500",
                b => b.Text("And many more, but it's late in the evening & this is just a draft anyway...")));

        b.Add(page, b.Header(model, b => largeHeader));
        b.Add(page, b.DrawerTreeMenu(model));

        return page;
    }

    public Var<HyperNode> Separator(BlockBuilder b)
    {
        return b.Div("mx-12 bg-gray-200 h-px");
    }

    public Var<HyperNode> HomeFeature(
        BlockBuilder b,
        Var<string> title,
        Var<string> subtitle,
        Var<string> details,
        Var<string> icon)
    {
        return b.Div(
            "flex flex-row items-center justify-center gap-24 bg-blue-50 p-16",
            b => b.Div(
                "flex-1 basis-1/3 flex flex-row items-center justify-end",
                b => b.Div(
                    "flex flex-row items-center justify-center w-16 h-16 text-3xl rounded-full bg-blue-400 text-white",
                    b => b.Icon(icon))),
            b => b.Div(
                "flex-1 basis-2/3 flex flex-col gap-4 text-gray-700",
                b => b.Text(title, "text-large font-semibold"),
                b => b.Optional(b.HasValue(subtitle), b => b.Text(subtitle, "text-sm")),
                b => b.Optional(b.HasValue(details), b => b.Text(details, "text-sm"))));
    }
}
*/

public static class SharedStateExtensions
{
    public static Var<TModel> Broadcast<TModel>(this BlockBuilder b, Var<TModel> model)
    {
        var clone = b.Clone(model);
        b.DispatchEvent(b.Const("sharedStateUpdate"), clone);
        return clone;
    }
}

public abstract class ShoelaceHyperPage<TDataModel> : HyperPage<TDataModel>
{
    public override IHtmlNode ModifyHtml(IHtmlNode root, Module module)
    {
        // sl-tooltip crashes for some reason
        var shoelaceTags = module.Consts.Where(x => x.Value is ShoelaceTag).Select(x => (x.Value as ShoelaceTag).tag).Where(x => x != "sl-tooltip").ToList();

        var head = (root as HtmlTag).Children.Cast<HtmlTag>().Single(x => x.Tag == "head");
        var style = head.AddChild(new HtmlTag("style"));
        style.AddChild(new HtmlText() { Text = "\r\nbody {\r\n    opacity: 0;\r\n}\r\n\r\n    body.ready {\r\n        opacity: 1;\r\n        transition: .25s opacity;\r\n    }" });

        var body = (root as HtmlTag).Children.Cast<HtmlTag>().Single(x => x.Tag == "body");

        var workaroundDiv = body.AddChild(new HtmlTag() { Tag = "div" });
        workaroundDiv.AddAttribute("class", "hidden");
        foreach (var shoelaceTag in shoelaceTags)
        {
            workaroundDiv.AddChild(new HtmlTag(shoelaceTag));
        }

        var scriptTag = body.AddChild(new HtmlTag("script"));
        scriptTag.AddAttribute("type", "module");

        var whenDefinedArray = string.Join(",\n", shoelaceTags.Select(x => $"customElements.whenDefined('{x}')"));

        scriptTag.AddChild(new HtmlText()
        {
            Text = $" await Promise.allSettled([{whenDefinedArray}]);document.body.classList.add('ready');console.log('document ready');"
        });

        return root;
    }
}