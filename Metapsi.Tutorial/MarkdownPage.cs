using Markdig;
using Markdig.Helpers;
using Markdig.Parsers;
using Markdig.Renderers;
using Markdig.Renderers.Html;
using Markdig.Syntax;
using Markdig.Syntax.Inlines;
using Metapsi.Hyperapp;
using Metapsi.Shoelace;
using Metapsi.Syntax;
using Metapsi.Ui;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
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

public interface IHasTextContent
{

}

public class ClientTextNode : SpanTag, IHasTextContent
{
    public string Text { get; set; }
}

//public static partial class ClientSideExtensions
//{
//    public static HyperAppNode<TModel, TComponentModel, TControl> WithText<TModel, TComponentModel, TControl>(
//        this HyperAppNode<TModel, TComponentModel, TControl> control,
//        Expression<Func<TModel, string>> modelProperty)
//        where TControl : IHtmlElement, IHasTextContent
//    {
//        var initialRender = control.Render;

//        control.Render = (b, model) =>
//        {
//            var control = initialRender(b, model);
//            var value = b.Get(model, modelProperty);
//            b.Add(control, b.TextNode(value));

//            return control;
//        };

//        return control;
//    }
//}

//public class TestCheckbox
//{
//    /// <summary>
//    /// Used in form data
//    /// </summary>
//    public string Name { get; set; }
//    /// <summary>
//    /// Used in form data
//    /// </summary>
//    public string Value { get; set; }

//    public bool Checked { get; set; }

//    public bool Disabled { get; set; }

//    public bool Required { get; set; }

//    public CheckboxSize Size { get; set; } = CheckboxSize.Medium;
//}

//public class SlCheckbox : SlComponent, IHasCheckedProperty
//{
//    public SlCheckbox() : base("sl-checkbox") { }

//    /// <summary>
//    /// Used in form data
//    /// </summary>
//    public string Name { get; set; }
//    /// <summary>
//    /// Used in form data
//    /// </summary>
//    public string Value { get; set; }

//    public bool Checked { get; set; }

//    public bool Disabled { get; set; }

//    public bool Required { get; set; }

//    public CheckboxSize Size { get; set; } = CheckboxSize.Medium;

//    public static SlCheckbox Create(string css, params IHtmlNode[] nodes)
//    {
//        var slCheckbox = new SlCheckbox();
//        slCheckbox.GetTag().AddClass(css);
//        slCheckbox.AddChildren(nodes);
//        return slCheckbox;
//    }
//}



//public static partial class ClientSideExtensions
//{
//    public static HyperAppNode<TModel, TComponentModel, TControl> BindChecked<TModel, TComponentModel, TControl>(
//        this HyperAppNode<TModel, TComponentModel, TControl> control,
//        Expression<Func<TModel, TComponentModel>> componentModel,
//        Expression<Func<TComponentModel, bool>> componentModelProperty)
//        where TControl: IHtmlElement, IHasCheckedProperty
//    {
//        var initialRender = control.Render;

//        control.Render = (b, model) =>
//        {
//            var control = initialRender(b, model);

//            var componentState = b.Get(model, componentModel);

//            var value = b.Get(componentState, componentModelProperty);

//            b.SetAttr(control, DynamicProperty.Bool("checked"), value);

//            b.SetOnSlChange(control, b.MakeAction((BlockBuilder b, Var<TModel> model, Var<bool> newValue) =>
//            {
//                var componentState = b.Get(model, componentModel);

//                var propertyName = componentModelProperty.PropertyName();

//                var nestedExpressions = componentModelProperty.GetMemberAccess();
//                var entityReference = b.Get<TComponentModel, object>(componentState, nestedExpressions.EntityReference);
//                b.Set(entityReference, nestedExpressions.EntityProperty, newValue);
//                return b.Broadcast(model);
//            }));

//            return control;
//        };

//        return control;
//    }
//}

public static class HyperApp
{
    //public static HyperAppNode<TDataModel, TControl> ClientNode<TDataModel, TControl>(
    //    TDataModel model,
    //    TControl takeoverNode)
    //    where TControl : IHtmlElement
    //{
    //    if (!takeoverNode.GetTag().Attributes.ContainsKey("id"))
    //    {
    //        takeoverNode.SetAttribute("id", $"id_{Guid.NewGuid()}");
    //    }

    //    var hyperApp = new HyperAppNode<TDataModel, TControl>()
    //    {
    //        Model = model,
    //        Render = (b, model) => b.ServerToClient(takeoverNode, model),
    //        TakeoverNode = takeoverNode
    //    };

    //    hyperApp.OnAttach += (sender, e) =>
    //    {
    //        HyperApp.AttachNode(hyperApp, e.Document, e.ParentNode, e.Module);
    //        if(takeoverNode is IHtmlComponent)
    //        {
    //            (takeoverNode as IHtmlComponent).Attach(e.Document, e.ParentNode);
    //        }
    //    };

    //    takeoverNode.GetTag().Children.Add(hyperApp);

    //    return hyperApp;
    //}

    //public static HyperAppNode<TDataModel, TComponentModel, TControl> ClientNode<TDataModel, TComponentModel, TControl>(
    //TDataModel model,
    //System.Linq.Expressions.Expression<Func<TDataModel, TComponentModel>> getComponentModel,
    //TControl takeoverNode)
    //where TControl : IHtmlElement
    //{
    //    if (!takeoverNode.GetTag().Attributes.ContainsKey("id"))
    //    {
    //        takeoverNode.SetAttribute("id", $"id_{Guid.NewGuid()}");
    //    }

    //    var hyperApp = new HyperAppNode<TDataModel, TComponentModel, TControl>()
    //    {
    //        Model = model,
    //        Render = (b, model) => b.ServerToClient(takeoverNode, model),
    //        TakeoverNode = takeoverNode,
    //        GetComponentModel = getComponentModel,
    //    };

    //    // import & attach are different operations
    //    // import is 'static', once per tag

    //    hyperApp.OnAttach += (sender, e) =>
    //    {
    //        HyperApp.AttachNode<TDataModel, TComponentModel, TControl>(hyperApp, e.Document, e.ParentNode, e.Module);
    //        if (takeoverNode is IHtmlComponent)
    //        {
    //            (takeoverNode as IHtmlComponent).Attach(e.Document, e.ParentNode);
    //        }

    //        //var functionCalls = e.Module.Consts.Where(x => x.Value is Syntax.FunctionCall);
    //        var slConsts = e.Module.Consts.Where(x => x.Type == typeof(string));
    //        var slTags = slConsts.Where(x => (x.Value as string).StartsWith("sl-")).Select(x => x.Value as string);

    //        foreach (var slTag in slTags)
    //        {

    //            var document = e.Document;

    //            document.StartHidden();

    //            document.Head.AddChild(new ExternalScriptTag("https://cdn.jsdelivr.net/npm/@shoelace-style/shoelace@2.6.0/cdn/shoelace-autoloader.js", "module"));
    //            document.Head.AddChild(new LinkTag("stylesheet", "https://cdn.jsdelivr.net/npm/@shoelace-style/shoelace@2.6.0/cdn/themes/light.css"));

    //            var slAwaitScript = document.Head.Children.OfType<SlAwaitScript>().SingleOrDefault();
    //            if (slAwaitScript == null)
    //            {
    //                slAwaitScript = document.Head.AddChild(new SlAwaitScript());
    //            }
    //            slAwaitScript.SlTags.Add(slTag);
    //        }
    //    };

    //    takeoverNode.GetTag().Children.Add(hyperApp);

    //    return hyperApp;
    //}

    //public static HyperAppComponent<TDataModel> ClientNode<TDataModel>(
    //    TDataModel model,
    //    System.Func<BlockBuilder, Var<TDataModel>, Var<HyperNode>> render)
    //{
    //    var hyperApp = new HyperAppComponent<TDataModel>()
    //    {
    //        Model = model,
    //        Render = render
    //    };

    //    return hyperApp;
    //}

    //public static void AttachNode<TDataModel, TComponentModel, TControl>(
    //    this HyperAppNode<TDataModel, TComponentModel, TControl> control, 
    //    DocumentTag document, 
    //    IHtmlElement parentNode,
    //    Syntax.Module module)
    //    where TControl: IHtmlElement
    //{
    //    // Assume control over TakeoverNode
    //    // If it's already added to the document, remove it
    //    // as we render it from inside this app

    //    document.ReplaceById(control.TakeoverNode.GetTag().Attributes["id"], control);

    //    var mainScript = new HtmlTag("script");
    //    mainScript.SetAttribute("type", "module");

    //    var moduleScript = Metapsi.JavaScript.PrettyBuilder.Generate(module, string.Empty);

    //    mainScript.Children.Add(new HtmlText()
    //    {
    //        Text = moduleScript
    //    });

    //    var jsonModel = Metapsi.JavaScript.PrettyBuilder.Serialize(control.Model);

    //    mainScript.Children.Add(new HtmlText()
    //    {
    //        Text = $"var model = {jsonModel}\n"
    //    });

    //    mainScript.Children.Add(new HtmlText()
    //    {
    //        Text = "\nmain(model)"
    //    });

    //    document.Head.AddChild(mainScript);
    //}
}

//public class ClientSlCheckbox<TModel> : HyperAppNode<TModel>
//{
//    public ClientSlCheckbox<TModel> BindChecked(Expression<Func<TModel, bool>> modelProperty)
//    {
//        var initialRender = this.Render;

//        this.Render = (b, model) =>
//        {
//            var control = initialRender(b, model);
//            var value = b.Get(model, modelProperty);

//            b.SetAttr(control, DynamicProperty.Bool("checked"), value);

//            b.SetOnSlChange(control, b.MakeAction((BlockBuilder b, Var<TModel> model, Var<bool> newValue) =>
//            {
//                var propertyName = modelProperty.PropertyName();

//                var nestedExpressions = modelProperty.GetMemberAccess();
//                var entityReference = b.Get<TModel, object>(model, nestedExpressions.EntityReference);
//                b.Set(entityReference, nestedExpressions.EntityProperty, newValue);
//                return b.Broadcast(model);
//            }));

//            return control;
//        };

//        return this;
//    }
//}

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


        body.AddChild(new TutorialArticleNode()
        {
            Markdown = "### Heading level 3 \nI just love **bold text**."
        });

        //body.AddChild(new SlCheckbox());

        //body.AddChild(new SlCheckbox());

        document.AttachComponents();

        //var components = document.Body.Descendants().OfType<IHtmlComponent>();
        //foreach (var component in components)
        //{
        //    component.OnMount(document);
        //}

        return document;
    }
}

//public class HyperAppNode<TDataModel> : IHtmlComponent, IHtmlNode
//{
//    // TODO: Model should come from outside
//    public TDataModel Model { get; set; }

//    public IHtmlElement TakeoverNode { get; set; }
//    public System.Func<BlockBuilder, Var<TDataModel>, Var<HyperNode>> Render { get; set; } = (b, model) => b.Div();
//    public System.Func<BlockBuilder, Var<TDataModel>, Var<HyperType.StateWithEffects>> Init { get; set; } = (b, model) => b.MakeStateWithEffects(model);

//    protected bool Attached { get; set; }

//    public void Attach(DocumentTag document, IHtmlElement parentNode)
//    {
//        if (!this.Attached)
//        {
//            Attached = true;
//        }
//    }

//    protected virtual void OnModuleBuilt(DocumentTag document, IHtmlElement parentNode, Syntax.Module module)
//    {
//        var moduleRequiredTags = module.Consts.Where(x => x.Value is IHtmlElement).Select(x => x.Value as IHtmlElement);

//        foreach (var requiredTag in moduleRequiredTags)
//        {
//            document.Head.AddChild(requiredTag);
//        }

//    }

//    public string ToHtml()
//    {
//        // ToString, not ToHtml, because TakeoverNode contains 'this'
//        // ToHtml will go into infinite recursion
//        return TakeoverNode.GetTag().ToString();
//    }
//}

public class ClientNodeAttachEventArgs
{
    public DocumentTag Document { get; set; } 
    public IHtmlElement ParentNode { get; set; }
    public Syntax.Module Module { get; set; }
}

public interface IClientSideNode<TDataModel>
{
    System.Func<BlockBuilder, Var<TDataModel>, Var<HyperNode>> Render { get; set; }
    System.Func<BlockBuilder, Var<TDataModel>, Var<HyperType.StateWithEffects>> Init { get; set; }

    bool AlreadyRendered { get; set; }
    public string TakeoverId { get; }
}

//public class HyperAppNode<TDataModel, TComponentModel, TControl> : IHtmlComponent, IHtmlNode, IClientSideNode<TDataModel>
//    where TControl: IHtmlElement
//{
//    public bool AlreadyRendered { get; set; }

//    // TODO: Model should come from outside
//    public TDataModel Model { get; set; }

//    public TControl TakeoverNode { get; set; }

//    public System.Linq.Expressions.Expression<Func<TDataModel, TComponentModel>> GetComponentModel { get; set; }

//    public string TakeoverId => TakeoverNode.GetTag().Attributes["id"];

//    public System.Func<BlockBuilder, Var<TDataModel>, Var<HyperNode>> Render { get; set; } = (b, model) => b.Div();
//    public System.Func<BlockBuilder, Var<TDataModel>, Var<HyperType.StateWithEffects>> Init { get; set; } = (b, model) => b.MakeStateWithEffects(model);

//    public event EventHandler<ClientNodeAttachEventArgs> OnAttach;

//    protected bool Attached { get; set; }

//    public void Attach(DocumentTag document, IHtmlElement parentNode)
//    {
//        if (!this.Attached)
//        {
//            var onAttach = this.OnAttach;
//            if (onAttach != null)
//            {
//                var module = HyperBuilder.BuildModule<TDataModel>((b, model) =>
//                {
//                    b.AddSubscription<TDataModel>(
//                        "SyncSharedModel",
//                        (BlockBuilder b, Var<TDataModel> state) =>
//                        {
//                            b.Comment("Subscription");
//                            return b.Listen<TDataModel, TDataModel>(
//                                b.Const("sharedStateUpdate"),
//                                b.MakeAction((BlockBuilder b, Var<TDataModel> oldModel, Var<TDataModel> newModel) =>
//                                {
//                                    b.Log("Subscription");
//                                    return newModel;
//                                }));
//                        });

//                    return this.Render(b, model);
//                },
//                this.Init,
//                this.TakeoverNode.GetTag().Attributes["id"]);

//                onAttach(this, new ClientNodeAttachEventArgs()
//                {
//                    Document = document,
//                    ParentNode = parentNode,
//                    Module = module
//                });
//            }

//            //HyperApp.AttachNode(this, document, parentNode);

//            //// Assume control over TakeoverNode
//            //// If it's already added to the document, remove it
//            //// as we render it from inside this app

//            //document.ReplaceById(TakeoverNode.GetTag().Attributes["id"], this);



//            //this.OnModuleBuilt(document, parentNode, module);


//            //var mainScript = new HtmlTag("script");
//            //mainScript.SetAttribute("type", "module");

//            //var moduleScript = Metapsi.JavaScript.PrettyBuilder.Generate(module, string.Empty);

//            //mainScript.Children.Add(new HtmlText()
//            //{
//            //    Text = moduleScript
//            //});

//            //var jsonModel = Metapsi.JavaScript.PrettyBuilder.Serialize(this.Model);

//            //mainScript.Children.Add(new HtmlText()
//            //{
//            //    Text = $"var model = {jsonModel}\n"
//            //});

//            //mainScript.Children.Add(new HtmlText()
//            //{
//            //    Text = "\nmain(model)"
//            //});

//            //document.Head.AddChild(mainScript);
//            Attached = true;
//        }
//    }

//    //protected virtual void OnModuleBuilt(DocumentTag document, IHtmlElement parentNode, Syntax.Module module)
//    //{
//    //    var moduleRequiredTags = module.Consts.Where(x => x.Value is IHtmlElement).Select(x => x.Value as IHtmlElement);

//    //    foreach (var requiredTag in moduleRequiredTags)
//    //    {
//    //        document.Head.AddChild(requiredTag);
//    //    }

//    //}

//    public string ToHtml()
//    {
//        // ToString, not ToHtml, because TakeoverNode contains 'this'
//        // ToHtml will go into infinite recursion
//        return TakeoverNode.GetTag().ToString();
//    }
//}


public class TutorialArticleNode : IHtmlNode
{
    public string Markdown { get; set; } = string.Empty;
    public List<CodeSample> CodeSamples { get; set; } = new();

    public string ToHtml()
    {
        var pipeline = new MarkdownPipelineBuilder().Use<CodeSampleMarkdownExtension>().Build();
        var markdown = Markdig.Markdown.ToHtml(this.Markdown, pipeline);
        return markdown;
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