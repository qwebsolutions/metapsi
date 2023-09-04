using Markdig;
using Metapsi.Hyperapp;
using Metapsi.Syntax;
using Metapsi.Ui;
using Microsoft.AspNetCore.Http;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metapsi.Tutorial;

public class MarkdownPage
{

}

public class MarkdownHandler : Http.Get<Metapsi.Tutorial.Routes.MTutorial, string>
{
    public override async Task<IResult> OnGet(CommandContext commandContext, HttpContext httpContext, string pageName)
    {
        return Page.Result(new MarkdownPage());
    }
}

public class MarkdownRenderer : MarkdownHtmlPage<MarkdownPage>
{
    public override IHtmlNode GetHtml(MarkdownPage dataModel)
    {
        var document = DocumentTag.Create();
        var head = document.Head;
        var body = document.Body;
        head.AddChild(new ExternalScriptTag("https://cdn.jsdelivr.net/npm/@shoelace-style/shoelace@2.6.0/cdn/shoelace-autoloader.js", "module"));
        head.AddChild(new LinkTag("stylesheet", "https://cdn.jsdelivr.net/npm/@shoelace-style/shoelace@2.6.0/cdn/themes/light.css"));

        head.AddChild(
            StyleTag.Create(
                CssSelector.Create("body").
                AddProperty("font-family", "var(--sl-font-sans)")
                .AddProperty("color", "var(--sl-color-gray-800)"),

                CssSelector.Create("strong")
                .AddProperty("font-weight", "var(--sl-font-weight-bold)")));


        body.AddChild(new MarkdownNode()
        {
            Markdown = "### Heading level 3 \nI just love **bold text**."
        });

        return document;
    }
}

//public class HyperappNode<TDataModel>
//{
//    public TDataModel DataModel { get; set; }
//    public string DivId { get; set; } = $"id_{Guid.NewGuid()}";
//    public System.Func<BlockBuilder, Var<TDataModel>, Var<HyperNode>> OnRender { get; set; }
//    public System.Func<BlockBuilder, Var<TDataModel>, Var<HyperType.StateWithEffects>> OnInit { get; set; } =
//        (BlockBuilder b, Var<TDataModel> model) =>
//    {
//        return b.MakeStateWithEffects(model);
//    };


//    public string ToHtml()
//    {
//        StringBuilder builder = new StringBuilder();
//        //var module = HyperBuilder.BuildModule<TDataModel>(this.OnRender, this.OnInit, this.DivId);

//        //var moduleRequiredTags = module.Consts.Where(x => x.Value is IHtmlTag).Select(x => x.Value as IHtmlTag);

//        //foreach (var requiredTag in moduleRequiredTags)
//        //{
//        //    builder.Append(requiredTag.ToTag().ToHtml());
//        //}

//        //var mainScript = new HtmlTag("script");
//        //mainScript.AddAttribute("type", "module");

//        //var moduleScript = Metapsi.JavaScript.PrettyBuilder.Generate(module, string.Empty);

//        //mainScript.Children.Add(new HtmlText()
//        //{
//        //    Text = moduleScript
//        //});

//        //var model = Metapsi.JavaScript.PrettyBuilder.Serialize(this.DataModel);

//        //mainScript.Children.Add(new HtmlText()
//        //{
//        //    Text = $"var model = {model}\n"
//        //});

//        //mainScript.Children.Add(new HtmlText()
//        //{
//        //    Text = "\nmain(model)"
//        //});

//        //var mainDiv = new HtmlTag("div");
//        //mainDiv.AddAttribute("id", DivId);
//        //builder.Append(mainScript);
//        //builder.Append(mainDiv.ToHtml());

//        return builder.ToString();
//    }
//}

public static class HyperappNodeExtensions
{
    public static void AddHyperapp<TDataModel>(
        this HtmlTag mountPoint,
        HtmlTag headTag,
        TDataModel model,
        System.Func<BlockBuilder, Var<TDataModel>, Var<HyperNode>> render,
        System.Func<BlockBuilder, Var<TDataModel>, Var<HyperType.StateWithEffects>> init = null)
    {
        var mountDivId = $"id_{Guid.NewGuid()}";

        if (init == null)
        {
            init = (b, model) => b.MakeStateWithEffects(model);
        }

        var module = HyperBuilder.BuildModule<TDataModel>((b, model) =>
        {
            b.AddSubscription<HomeModel>(
                "SyncSharedModel",
                (BlockBuilder b, Var<HomeModel> state) =>
                {
                    return b.Listen<TDataModel, TDataModel>(
                        b.Const("sharedStateUpdate"),
                        b.MakeAction((BlockBuilder b, Var<TDataModel> oldModel, Var<TDataModel> newModel) =>
                        {
                            return newModel;
                        }));
                });

            return render(b, model);
        },
        init,
        mountDivId);

        var moduleRequiredTags = module.Consts.Where(x => x.Value is IHtmlTag).Select(x => x.Value as IHtmlTag);

        foreach (var requiredTag in moduleRequiredTags)
        {
            headTag.AddChild(requiredTag);
        }

        var mainScript = new HtmlTag("script");
        mainScript.AddAttribute("type", "module");

        var moduleScript = Metapsi.JavaScript.PrettyBuilder.Generate(module, string.Empty);

        mainScript.Children.Add(new HtmlText()
        {
            Text = moduleScript
        });

        var jsonModel = Metapsi.JavaScript.PrettyBuilder.Serialize(model);

        mainScript.Children.Add(new HtmlText()
        {
            Text = $"var model = {jsonModel}\n"
        });

        mainScript.Children.Add(new HtmlText()
        {
            Text = "\nmain(model)"
        });

        headTag.AddChild(mainScript);

        mountPoint.AddChild(new HtmlTag("div").AddAttribute("id", mountDivId));
    }

    //public static ClientControl ClientControl<TDataModel>(
    //    TDataModel model,
    //    System.Func<BlockBuilder, Var<TDataModel>, Var<HyperNode>> render,
    //    System.Func<BlockBuilder, Var<TDataModel>, Var<HyperType.StateWithEffects>> init = null)
    //{
    //    ClientControl clientControl = new();

    //    var mountDivId = $"id_{Guid.NewGuid()}";

    //    if (init == null)
    //    {
    //        init = (b, model) => b.MakeStateWithEffects(model);
    //    }

    //    var module = HyperBuilder.BuildModule<TDataModel>((b, model) =>
    //    {
    //        b.AddSubscription<HomeModel>(
    //            "SyncSharedModel",
    //            (BlockBuilder b, Var<HomeModel> state) =>
    //            {
    //                return b.Listen<TDataModel, TDataModel>(
    //                    b.Const("sharedStateUpdate"),
    //                    b.MakeAction((BlockBuilder b, Var<TDataModel> oldModel, Var<TDataModel> newModel) =>
    //                    {
    //                        return newModel;
    //                    }));
    //            });

    //        return render(b, model);
    //    },
    //    init,
    //    mountDivId);

    //    var moduleRequiredTags = module.Consts.Where(x => x.Value is IHtmlTag).Select(x => x.Value as IHtmlTag);

    //    foreach (var requiredTag in moduleRequiredTags)
    //    {
    //        clientControl.HeaderRequiredNodes.Add(requiredTag);
    //    }

    //    var mainScript = new HtmlTag("script");
    //    mainScript.AddAttribute("type", "module");

    //    var moduleScript = Metapsi.JavaScript.PrettyBuilder.Generate(module, string.Empty);

    //    mainScript.Children.Add(new HtmlText()
    //    {
    //        Text = moduleScript
    //    });

    //    var jsonModel = Metapsi.JavaScript.PrettyBuilder.Serialize(model);

    //    mainScript.Children.Add(new HtmlText()
    //    {
    //        Text = $"var model = {jsonModel}\n"
    //    });

    //    mainScript.Children.Add(new HtmlText()
    //    {
    //        Text = "\nmain(model)"
    //    });

    //    clientControl.HeaderRequiredNodes.Add(mainScript);
    //    clientControl.MountPoint = new HtmlTag("div").AddAttribute("id", mountDivId);

    //    return clientControl;
    //}
}

public class MarkdownNode : IHtmlNode
{
    public string Markdown { get; set; } = string.Empty;

    public string ToHtml()
    {
        return Markdig.Markdown.ToHtml(this.Markdown);
    }
}

public abstract class MarkdownHtmlPage<TDataModel> : IPageTemplate<TDataModel>
{
    public abstract IHtmlNode GetHtml(TDataModel dataModel);

    public string Render(TDataModel model)
    {
        StringBuilder builder = new StringBuilder();
        builder.AppendLine("<!DOCTYPE html>");
        return GetHtml(model).ToHtml();
        //BuildHtml(builder, GetHtml(model));
        //var html = builder.ToString();
        //return html;
    }

    //private void BuildHtml(StringBuilder builder, IHtmlNode htmlNode)
    //{
    //    switch (htmlNode)
    //    {
    //        case HtmlTag htmlTag:
    //            HtmlWriters.HtmlTag(builder, htmlTag, BuildHtml);
    //            break;
    //        case HtmlText textNode:
    //            HtmlWriters.HtmlText(builder, textNode);
    //            break;
    //        case MarkdownNode markdownNode:
    //            {
    //                builder.Append(Markdown.ToHtml(markdownNode.Markdown));
    //            }
    //            break;
    //        case HyperappNode hyperappNode:
    //            {
    //                builder.Append("hyperapp node here");
    //            }
    //            break;
    //        default:
    //            throw new System.NotSupportedException(htmlNode.ToString());
    //    }
    //}
}