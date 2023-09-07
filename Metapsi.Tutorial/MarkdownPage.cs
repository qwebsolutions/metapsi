using Markdig;
using Metapsi.Hyperapp;
using Metapsi.Syntax;
using Metapsi.Ui;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
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


public enum CheckboxSize
{
    Small,
    Medium,
    Large
}

public class SlAwaitScript : BaseTag
{
    public HashSet<string> SlTags { get; set; } = new();

    public override HtmlTag ToTag()
    {
        var scriptTag = new HtmlTag("script");
        scriptTag.AddAttribute("type", "module");

        var whenDefinedArray = string.Join(",\n", SlTags.Select(x => $"customElements.whenDefined('{x}')"));

        scriptTag.AddChild(new HtmlText()
        {
            Text = $" await Promise.allSettled([{whenDefinedArray}]);document.body.classList.add('ready');console.log('document ready');"
        });

        return scriptTag;
    }
}

public static class SlHtmlExtensions
{
    public static void StartHidden(this DocumentTag document)
    {
        const string hiddenStyle = "\r\nbody {\r\n    opacity: 0;\r\n}\r\n\r\n    body.ready {\r\n        opacity: 1;\r\n        transition: .25s opacity;\r\n    }";

        var style = document.Head.Descendants().OfType<StyleTag>().SingleOrDefault(x => x.StyleName == nameof(hiddenStyle));

        if (style == null)
        {
            var styleTag = document.Head.AddChild(new StyleTag()
            {
                StyleName = nameof(hiddenStyle),
            });

            styleTag.AddSelector("body").AddProperty("opacity", "0");
            styleTag.AddSelector("body.ready")
                .AddProperty("opacity", "1")
                .AddProperty("transition", ".25s opacity;");
        }
    }
}

public class SlCheckbox : BaseTag, IHtmlComponent
{
    /// <summary>
    /// Used in form data
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// Used in form data
    /// </summary>
    public string Value { get; set; }

    public bool Checked { get; set; }

    public bool Disabled { get; set; }

    public CheckboxSize CheckboxSize { get; set; } = CheckboxSize.Medium;

    public override HtmlTag ToTag()
    {
        var checkbox = new HtmlTag("sl-checkbox");

        checkbox.AddText("Checkbox name here");

        return checkbox;
    }

    public void OnMount(DocumentTag document, IHtmlTag parentNode)
    {
        document.StartHidden();

        document.Head.AddChild(new ExternalScriptTag("https://cdn.jsdelivr.net/npm/@shoelace-style/shoelace@2.6.0/cdn/shoelace-autoloader.js", "module"));
        document.Head.AddChild(new LinkTag("stylesheet", "https://cdn.jsdelivr.net/npm/@shoelace-style/shoelace@2.6.0/cdn/themes/light.css"));

        var slAwaitScript = document.Head.Children.OfType<SlAwaitScript>().SingleOrDefault();
        if(slAwaitScript == null)
        {
            slAwaitScript = document.Head.AddChild(new SlAwaitScript());
        }
        slAwaitScript.SlTags.Add("sl-checkbox");
    }
}

public class MarkdownRenderer : MarkdownHtmlPage<MarkdownPage>
{
    public override IHtmlNode GetHtml(MarkdownPage dataModel)
    {
        var document = DocumentTag.Create();
        var head = document.Head;
        var body = document.Body;
        
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

        body.AddChild(new SlCheckbox());

        body.AddChild(new SlCheckbox());

        document.AttachComponents();

        //var components = document.Body.Descendants().OfType<IHtmlComponent>();
        //foreach (var component in components)
        //{
        //    component.OnMount(document);
        //}

        return document;
    }
}

public class HyperAppNode<TDataModel> : IHtmlNode, IHtmlComponent
{
    // TODO: Model should come from outside
    public TDataModel Model { get; set; }

    public HtmlTag TakeoverNode { get; set; }
    public System.Func<BlockBuilder, Var<TDataModel>, Var<HyperNode>> Render { get; set; } = (b, model) => b.Div();
    public System.Func<BlockBuilder, Var<TDataModel>, Var<HyperType.StateWithEffects>> Init { get; set; } = (b, model) => b.MakeStateWithEffects(model);

    public void OnMount(DocumentTag document, IHtmlTag parent)
    {
        // Assume control over TakeoverNode
        // If it's already added to the document, remove it
        // as we render it from inside this app

        document.ReplaceById(TakeoverNode.Attributes["id"], this);

        // It the HyperAppNode is already attached to TakeoverNode, all is ok
        //if (!parent.HasAttribute("id", TakeoverNode.Attributes["id"]))
        //{
        //    // If takeover node is not yet attached, the node was created in isolation
        //    // Attach now
        //    if (parent.GetDescendantById(TakeoverNode.Attributes["id"]) == null)
        //    {
        //        parent.ToTag().AddChild(TakeoverNode);
        //    }
        //}

        var module = HyperBuilder.BuildModule<TDataModel>((b, model) =>
        {
            b.AddSubscription<TDataModel>(
                "SyncSharedModel",
                (BlockBuilder b, Var<TDataModel> state) =>
                {
                    b.Comment("Subscription");
                    return b.Listen<TDataModel, TDataModel>(
                        b.Const("sharedStateUpdate"),
                        b.MakeAction((BlockBuilder b, Var<TDataModel> oldModel, Var<TDataModel> newModel) =>
                        {
                            b.Log("Subscription");
                            return newModel;
                        }));
                });

            return this.Render(b, model);
        },
        this.Init,
        this.TakeoverNode.Attributes["id"]);

        var moduleRequiredTags = module.Consts.Where(x => x.Value is IHtmlTag).Select(x => x.Value as IHtmlTag);

        foreach (var requiredTag in moduleRequiredTags)
        {
            document.Head.AddChild(requiredTag);
        }

        var mainScript = new HtmlTag("script");
        mainScript.AddAttribute("type", "module");

        var moduleScript = Metapsi.JavaScript.PrettyBuilder.Generate(module, string.Empty);

        mainScript.Children.Add(new HtmlText()
        {
            Text = moduleScript
        });

        var jsonModel = Metapsi.JavaScript.PrettyBuilder.Serialize(this.Model);

        mainScript.Children.Add(new HtmlText()
        {
            Text = $"var model = {jsonModel}\n"
        });

        mainScript.Children.Add(new HtmlText()
        {
            Text = "\nmain(model)"
        });

        document.Head.AddChild(mainScript);
    }

    public string ToHtml()
    {
        // ToString, not ToHtml, because TakeoverNode contains 'this'
        // ToHtml will go into infinite recursion
        return TakeoverNode.ToString();
    }
}

public static class HyperappNodeExtensions
{
    public static void AddHyperapp<TDataModel>(
        this HtmlTag mountPoint,
        TDataModel model,
        System.Func<BlockBuilder, Var<TDataModel>, Var<HyperNode>> render = null,
        System.Func<BlockBuilder, Var<TDataModel>, Var<HyperType.StateWithEffects>> init = null)
    {
        var mountDivId = $"id_{Guid.NewGuid()}";
        var appContainer = mountPoint.AddChild(new DivTag().AddAttribute("id", mountDivId));

        var hyperApp = new HyperAppNode<TDataModel>()
        {
            Model = model,
            Init = init,
            Render = render,
            TakeoverNode = appContainer
        };

        appContainer.AddChild(hyperApp);
    }


    public static HyperAppNode<TDataModel> ToClientSide<TDataModel>(
        this HtmlTag takeoverNode,
        TDataModel model)
    {
        if (!takeoverNode.Attributes.ContainsKey("id"))
        {
            takeoverNode.AddAttribute("id", $"id_{Guid.NewGuid()}");
        }

        var hyperApp = new HyperAppNode<TDataModel>()
        {
            Model = model,
            Render = (b, model) => b.ServerToClient(takeoverNode),
            TakeoverNode = takeoverNode
        };

        takeoverNode.Children.Add(hyperApp);

        return hyperApp;
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