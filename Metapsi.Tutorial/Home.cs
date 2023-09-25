using Metapsi.Hyperapp;
using Metapsi.Shoelace;
using Metapsi.Syntax;
using Metapsi.Ui;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.RazorPages;
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

    public List<MenuEntry> Menu { get; set; } = new List<MenuEntry>();
    public MenuEntry CurrentEntry { get; set; } = new();

    public bool MenuIsExpanded { get; set; }
}

public class ComponentModel
{
    public string P1 { get; set; }
    public string P2 { get; set; }

    public int count { get; set; }

    public Nested Nested { get; set; } = new();

    public bool SomeBool { get; set; }
}

public class XXXModel : IApiSupportState
{
    public ApiSupport ApiSupport { get; set; } = new();
    public ComponentModel First { get; set; } = new();
    public ComponentModel Second { get; set; } = new();

    public List<ComponentModel> CompList { get; set; } = new();
}

public class Nested
{
    public bool ShowStuff { get; set; }
}

public class XXXHandler : Http.Get<Metapsi.Tutorial.Routes.XXX, string, string>
{
    public override async Task<IResult> OnGet(CommandContext commandContext, HttpContext httpContext, string firstParam, string secondParam)
    {
        return Page.Result(new XXXModel()
        {
            First = new()
            {
                P1 = firstParam + "_1",
                P2 = secondParam + "_1"
            },
            Second = new()
            {
                P1 = firstParam + "_2",
                P2 = secondParam + "_2"
            },
            CompList = new List<ComponentModel>()
            {
                new ComponentModel()
                {
                    P1 = "P1_1",
                    P2 = "P2_1"
                },
                new ComponentModel()
                {
                    P1 = "P1_2",
                    P2 = "P2_2"
                }
            }
        });
    }
}

public static class VisibilityExtensions
{
 
    public static Var<HyperNode> ServerToClient<TModel>(this BlockBuilder b, IHtmlElement tag, Var<TModel> model)
    {
        var node = b.Node(tag.GetTag().Tag);

        foreach (var attribute in tag.GetTag().Attributes)
        {
            b.SetAttr(node, DynamicProperty.String(attribute.Key), attribute.Value);
        }

        foreach (var child in tag.GetTag().Children)
        {
            if (child is IHtmlElement)
            {
                b.Add(node, b.ServerToClient<TModel>(child as IHtmlElement, model));
            }
            if (child is HtmlText)
            {
                b.Add(node, b.TextNode((child as HtmlText).Text));
            }

            if (child is IClientSideNode<TModel>)
            {
                IClientSideNode<TModel> clientNode = child as IClientSideNode<TModel>;

                if (!tag.HasAttribute("id", clientNode.TakeoverId))
                {
                    if (!clientNode.AlreadyRendered)
                    {
                        clientNode.AlreadyRendered = true;
                        b.Add(node, clientNode.Render(b, model));
                    }
                }
            }
        }

        return node;
    }
}


public static class CheckboxBindingExtensions
{
    public static Var<HyperNode> Checkbox<TPageModel, TItem>(
        this BlockBuilder b,
        Var<DataContext<TPageModel, TItem>> dataContext,
        Action<DataContextControlBuilder<TPageModel, TItem, Checkbox>> builder)
    {
        return b.BuildControl(dataContext, builder, Shoelace.Control.Checkbox);
    }


    public static void BindChecked<TPageModel, TContext, TControlProps>(
        this DataContextControlBuilder<TPageModel, TContext, TControlProps> builder,
        System.Linq.Expressions.Expression<Func<TContext, bool>> contextProperty)
        where TControlProps : IHasCheckedProperty
    {
        builder.BindInput(x => x.Checked, contextProperty);

        Action<BlockBuilder, Var<HyperNode>> eventAction = (b, node) =>
        {
            b.SetOnSlChange(node, b.MakeAction(
                (BlockBuilder b, Var<TPageModel> pageModel, Var<bool> isChecked) =>
                {
                    var dataItem = b.Call(b.Get(builder.Context, x => x.AccessData), pageModel);
                    b.Set(dataItem, contextProperty, isChecked);
                    return b.BroadcastModelUpdate(pageModel);
                }));
        };
        builder.ControlBuilderActions.Add(eventAction);
    }
}

/// <summary>
///  THE EXAMPLE
/// </summary>

//public class XXXRenderer : HtmlPage<XXXModel>
//{
//    public static async Task<XXXModel> IncrementFirst(CommandContext commandContext, XXXModel model)
//    {
//        model.First.count++;
//        return model;
//    }

//    public static async Task<XXXModel> IncrementSecond(CommandContext commandContext, XXXModel model)
//    {
//        model.Second.count++;
//        return model;
//    }

//    public Var<HyperNode> ShowNested<TPageModel>(BlockBuilder b, Var<DataContext<TPageModel, Nested>> dataContext)
//    {
//        var container = b.Div("flex flex-col");

//        var data = b.Get(dataContext);

//        var showStuff = b.Get(data, x => x.ShowStuff);

//        //b.Add(container, b.Checkbox(dataContext, b =>
//        //{
//        //    b.BindChecked(x => x.ShowStuff);
//        //}));

//        b.OnProperty(dataContext, x => x.ShowStuff,
//            (b, dataContext) =>
//            {
//                var data = b.Get(dataContext, x => x.InputData);

//                b.Add(container, b.Text(b.AsString(data)));
//            });

//        return container;
//    }

//    public override IHtmlNode GetHtmlTree(XXXModel dataModel)
//    {
//        var document = DocumentTag.Create(dataModel.First.P1);
//        document.Head.AddModuleStylesheet();

//        for (int i = 0; i < 500; i++)
//        {
//            document.Body.AddChild(
//                DivTag.Create(
//                    "flex flex-row",
//                    new HtmlText(i.ToString()),
//                    ClientSide.Create(dataModel, (b, model) =>
//                    {
//                        var container = b.Div("flex flex-col");

//                        b.OnModel(model,
//                            (b, dataContext) =>
//                            {
//                                b.OnProperty(dataContext, x => x.First.Nested,
//                                    (b, dataContext) =>
//                                    {
//                                        b.Add(container, ShowNested(b, dataContext));
//                                    });

//                                b.OnList(
//                                    dataContext, x => x.CompList.Where(x => x.SomeBool),
//                                    (b, dataContext) =>
//                                    {
//                                        var data = b.Get(dataContext, x => x.InputData);
//                                        b.Add(container, b.Text(b.Get(data, x => x.P1)));
//                                    });

//                                b.OnList(dataContext, x => x.CompList,
//                                    (b, dataContext) =>
//                                    {
//                                        //b.Add(container, b.Checkbox(dataContext, b =>
//                                        //{
//                                        //    b.BindChecked(x => x.SomeBool);
//                                        //    b.BindInput(x => x.Disabled, x => x.SomeBool);
//                                        //}));

//                                        var checkbox = b.Node("input");
//                                        b.SetAttr(checkbox, Html.type, "checkbox");

//                                        b.SetAttr(checkbox, Html.@checked, b.Get(b.Get(dataContext), x => x.SomeBool));

//                                        b.SetOnClick(checkbox, b.MakeAction((BlockBuilder b, Var<XXXModel> model) =>
//                                        {
//                                            var getter = b.Get(dataContext, x => x.AccessData);

//                                            var componentModel = b.Call(getter, model);
//                                            var prevValue = b.Get(componentModel, x => x.SomeBool);

//                                            b.Set(componentModel, x => x.SomeBool, b.Not(prevValue));

//                                            return b.BroadcastModelUpdate(model);
//                                        }));

//                                        b.Add(container, checkbox);
//                                    });

//                            });

//                        return container;
//                    })));
//        }

//        document.Body.AddChild(new HtmlText("Second text here"));

//        document.AttachComponents();

//        return document;
//    }
//}

public class HomeHandler : Http.Get<Metapsi.Tutorial.Routes.Home>
{
    public override async Task<IResult> OnGet(CommandContext commandContext, HttpContext httpContext)
    {
        HomeModel model = new HomeModel();
        await model.LoadMenu();
        return Page.Result(model);
    }
}


//public class HomeRenderer : HtmlPage<HomeModel>
//{
    //public override IHtmlNode GetHtmlTree(HomeModel dataModel)
    //{
    //    var htmlDocument = DocumentTag.Create();
    //    var head = htmlDocument.Head;
    //    var body = htmlDocument.Body;

    //    head.AddModuleStylesheet();
    //    var largeHeader = new DivTag().AddTextSpan("Metapsi").AddInlineStyle("font-size", "var(--sl-font-size-large)");
    //    body.AddChild(Header(dataModel, largeHeader, head));

    //    //body.AddHyperapp(
    //    //    dataModel,
    //    //    (b, model) =>
    //    //    {
    //    //        return b.DrawerTreeMenu(model);
    //    //    });

    //    var allNodes = body.Descendants();

    //    var slTags = allNodes.Where(x => x is IHtmlElement).Where(x => (x as IHtmlElement).GetTag().Tag.StartsWith("sl-"));

    //    if (slTags.Any())
    //    {
    //        head.AddChild(new ExternalScriptTag("https://cdn.jsdelivr.net/npm/@shoelace-style/shoelace@2.6.0/cdn/shoelace-autoloader.js", "module"));
    //        head.AddStylesheet("https://cdn.jsdelivr.net/npm/@shoelace-style/shoelace@2.6.0/cdn/themes/light.css");
    //    }

    //    htmlDocument.AttachComponents();

    //    //var components = htmlDocument.Body.Descendants().OfType<IHtmlComponent>();
    //    //foreach (var component in components)
    //    //{
    //    //    component.OnMount(htmlDocument);
    //    //}

    //    //declare server-side shoelace with common props
    //    //await slTags. Also include client-side tags
    //    return htmlDocument;
    //}



    //public DivTag Header<TModel>(TModel model, IHtmlNode content, HeadTag headTag)
    //    where TModel: IHasTreeMenu
    //{
    //    var container = new DivTag()
    //        .AddClass("flex flex-row gap-4 items-center w-full px-8 py-4 fixed top-0 shadow bg-gray-50 text-xl");

    //    //var icon = container.AddChild(new HtmlTag("sl-icon").AddAttribute("name", "list"));

    //    //container.AddHyperapp(
    //    //    model,
    //    //    (b, model) =>
    //    //    {
    //    //        var showMenuButton = b.IconButton("list");
    //    //        b.SetOnClick(showMenuButton, b.MakeAction((BlockBuilder b, Var<TutorialModel> model) =>
    //    //        {
    //    //            b.Set(model, x => x.MenuIsExpanded, true);
    //    //            return b.Broadcast(model);
    //    //        }));

    //    //        return showMenuButton;
    //    //    });

    //    if (content != null)
    //    {
    //        container.AddChild(content);
    //    }

    //    return container;
    //}


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
//}


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


    //public static HyperAppNode<TModel, TComponentModel, TControl> OnClickServer<TModel, TComponentModel, TControl>(
    //    this HyperAppNode<TModel, TComponentModel, TControl> control,
    //    Func<CommandContext, TModel, System.Threading.Tasks.Task<TModel>> onServerAction)
    //    where TModel : IApiSupportState
    //    where TControl: IHtmlElement
    //{
    //    var buttonRenderer = control.Render;
    //    control.Render = (BlockBuilder b, Var<TModel> model) =>
    //    {
    //        var btn = buttonRenderer(b, model);
    //        b.SetOnClick(btn, b.MakeServerAction(model, onServerAction));
    //        return btn;
    //    };
    //    return control;
    //}
}

//public abstract class ShoelaceHyperPage<TDataModel> : HyperPage<TDataModel>
//{
//    public override IHtmlNode ModifyHtml(IHtmlNode root, Module module)
//    {
//        // sl-tooltip crashes for some reason
//        var shoelaceTags = module.Consts.Where(x => x.Value is ShoelaceTag).Select(x => (x.Value as ShoelaceTag).tag).Where(x => x != "sl-tooltip").ToList();

//        var head = (root as HtmlTag).Children.Cast<HtmlTag>().Single(x => x.Tag == "head");
//        var style = head.AddChild(new HtmlTag("style"));
//        style.AddChild(new HtmlText() { Text = "\r\nbody {\r\n    opacity: 0;\r\n}\r\n\r\n    body.ready {\r\n        opacity: 1;\r\n        transition: .25s opacity;\r\n    }" });

//        var body = (root as HtmlTag).Children.Cast<HtmlTag>().Single(x => x.Tag == "body");

//        var workaroundDiv = body.AddChild(new HtmlTag() { Tag = "div" });
//        workaroundDiv.SetAttribute("class", "hidden");
//        foreach (var shoelaceTag in shoelaceTags)
//        {
//            workaroundDiv.AddChild(new HtmlTag(shoelaceTag));
//        }

//        var scriptTag = body.AddChild(new HtmlTag("script"));
//        scriptTag.SetAttribute("type", "module");

//        var whenDefinedArray = string.Join(",\n", shoelaceTags.Select(x => $"customElements.whenDefined('{x}')"));

//        scriptTag.AddChild(new HtmlText()
//        {
//            Text = $" await Promise.allSettled([{whenDefinedArray}]);document.body.classList.add('ready');console.log('document ready');"
//        });

//        return root;
//    }
//}