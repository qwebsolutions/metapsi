using Markdig;
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

public static partial class ClientSideExtensions
{
    public static HyperAppNode<TModel, TComponentModel, TControl> WithText<TModel, TComponentModel, TControl>(
        this HyperAppNode<TModel, TComponentModel, TControl> control,
        Expression<Func<TModel, string>> modelProperty)
        where TControl : IHtmlElement, IHasTextContent
    {
        var initialRender = control.Render;

        control.Render = (b, model) =>
        {
            var control = initialRender(b, model);
            var value = b.Get(model, modelProperty);
            b.Add(control, b.TextNode(value));

            return control;
        };

        return control;
    }
}

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

public class SlCheckbox : SlComponent, IHasCheckedProperty
{
    public SlCheckbox() : base("sl-checkbox") { }

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

    public bool Required { get; set; }

    public CheckboxSize Size { get; set; } = CheckboxSize.Medium;

    public static SlCheckbox Create(string css, params IHtmlNode[] nodes)
    {
        var slCheckbox = new SlCheckbox();
        slCheckbox.GetTag().AddClass(css);
        slCheckbox.AddChildren(nodes);
        return slCheckbox;
    }
}



public static partial class ClientSideExtensions
{
    public static HyperAppNode<TModel, TComponentModel, TControl> BindChecked<TModel, TComponentModel, TControl>(
        this HyperAppNode<TModel, TComponentModel, TControl> control,
        Expression<Func<TModel, TComponentModel>> componentModel,
        Expression<Func<TComponentModel, bool>> componentModelProperty)
        where TControl: IHtmlElement, IHasCheckedProperty
    {
        var initialRender = control.Render;

        control.Render = (b, model) =>
        {
            var control = initialRender(b, model);

            var componentState = b.Get(model, componentModel);

            var value = b.Get(componentState, componentModelProperty);

            b.SetAttr(control, DynamicProperty.Bool("checked"), value);

            b.SetOnSlChange(control, b.MakeAction((BlockBuilder b, Var<TModel> model, Var<bool> newValue) =>
            {
                var componentState = b.Get(model, componentModel);

                var propertyName = componentModelProperty.PropertyName();

                var nestedExpressions = componentModelProperty.GetMemberAccess();
                var entityReference = b.Get<TComponentModel, object>(componentState, nestedExpressions.EntityReference);
                b.Set(entityReference, nestedExpressions.EntityProperty, newValue);
                return b.Broadcast(model);
            }));

            return control;
        };

        return control;
    }
}

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

    public static HyperAppNode<TDataModel, TComponentModel, TControl> ClientNode<TDataModel, TComponentModel, TControl>(
    TDataModel model,
    System.Linq.Expressions.Expression<Func<TDataModel, TComponentModel>> getComponentModel,
    TControl takeoverNode)
    where TControl : IHtmlElement
    {
        if (!takeoverNode.GetTag().Attributes.ContainsKey("id"))
        {
            takeoverNode.SetAttribute("id", $"id_{Guid.NewGuid()}");
        }

        var hyperApp = new HyperAppNode<TDataModel, TComponentModel, TControl>()
        {
            Model = model,
            Render = (b, model) => b.ServerToClient(takeoverNode, model),
            TakeoverNode = takeoverNode,
            GetComponentModel = getComponentModel,
        };

        // import & attach are different operations
        // import is 'static', once per tag

        hyperApp.OnAttach += (sender, e) =>
        {
            HyperApp.AttachNode<TDataModel, TComponentModel, TControl>(hyperApp, e.Document, e.ParentNode, e.Module);
            if (takeoverNode is IHtmlComponent)
            {
                (takeoverNode as IHtmlComponent).Attach(e.Document, e.ParentNode);
            }

            //var functionCalls = e.Module.Consts.Where(x => x.Value is Syntax.FunctionCall);
            var slConsts = e.Module.Consts.Where(x => x.Type == typeof(string));
            var slTags = slConsts.Where(x => (x.Value as string).StartsWith("sl-")).Select(x => x.Value as string);

            foreach (var slTag in slTags)
            {

                var document = e.Document;

                document.StartHidden();

                document.Head.AddChild(new ExternalScriptTag("https://cdn.jsdelivr.net/npm/@shoelace-style/shoelace@2.6.0/cdn/shoelace-autoloader.js", "module"));
                document.Head.AddChild(new LinkTag("stylesheet", "https://cdn.jsdelivr.net/npm/@shoelace-style/shoelace@2.6.0/cdn/themes/light.css"));

                var slAwaitScript = document.Head.Children.OfType<SlAwaitScript>().SingleOrDefault();
                if (slAwaitScript == null)
                {
                    slAwaitScript = document.Head.AddChild(new SlAwaitScript());
                }
                slAwaitScript.SlTags.Add(slTag);
            }
        };

        takeoverNode.GetTag().Children.Add(hyperApp);

        return hyperApp;
    }

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

    public static void AttachNode<TDataModel, TComponentModel, TControl>(
        this HyperAppNode<TDataModel, TComponentModel, TControl> control, 
        DocumentTag document, 
        IHtmlElement parentNode,
        Syntax.Module module)
        where TControl: IHtmlElement
    {
        // Assume control over TakeoverNode
        // If it's already added to the document, remove it
        // as we render it from inside this app

        document.ReplaceById(control.TakeoverNode.GetTag().Attributes["id"], control);

        var mainScript = new HtmlTag("script");
        mainScript.SetAttribute("type", "module");

        var moduleScript = Metapsi.JavaScript.PrettyBuilder.Generate(module, string.Empty);

        mainScript.Children.Add(new HtmlText()
        {
            Text = moduleScript
        });

        var jsonModel = Metapsi.JavaScript.PrettyBuilder.Serialize(control.Model);

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

public class ModelNavigator
{
    public List<object> NavigatorStack { get; set; } = new();// Func(parent) -> children
}

public interface IDrill
{
    List<System.Linq.Expressions.LambdaExpression> Stack { get; }
}

public class Drill<TParent, TChild> : IDrill
{
    public List<System.Linq.Expressions.LambdaExpression> Stack { get; set; } = new();

    public Drill<TChild, TGrandchild> Down<TGrandchild>(System.Linq.Expressions.Expression<Func<TChild, TGrandchild>> goDown)
    {
        Drill<TChild, TGrandchild> newDrill = new Drill<TChild, TGrandchild>();
        newDrill.Stack.AddRange(this.Stack);
        newDrill.Stack.Add(goDown);
        return newDrill;
    }

    public Drill<TGrandparent, TParent> Wrap<TGrandparent>(System.Linq.Expressions.Expression<Func<TGrandparent, TParent>> wrap)
    {
        Drill<TGrandparent, TParent> newDrill = new Drill<TGrandparent, TParent>();
        newDrill.Stack.Add(wrap);
        newDrill.Stack.AddRange(this.Stack);
        return newDrill;
    }
}

public static class Drill
{
    public static Drill<T, T> Root<T>()
    {
        Drill<T, T> root = new Drill<T, T>();
        System.Linq.Expressions.Expression<Func<T, T>> itself = x => x;
        root.Stack.Add(itself);
        return root;
    }

    public static IDrill Down<TParent, TChild>(this IDrill drill, System.Linq.Expressions.Expression<Func<TParent, TChild>> goDown)
    {
        Drill<TParent, TChild> newDrill = new();
        newDrill.Stack.AddRange(drill.Stack);
        newDrill.Stack.Add(goDown);
        return newDrill;
    }

    public static Var<Func<TRoot, TLeaf>> GetDrillFunc<TRoot, TLeaf>(this BlockBuilder b, IDrill drill)
    {
        return b.DefineFunc((BlockBuilder b, Var<TRoot> root) =>
        {
            var current = b.Ref<object>(root.As<object>());
            foreach (var expression in drill.Stack)
            {
                b.SetRef(current, b.Get<object, object>(b.GetRef(current), expression));
            }
            return b.GetRef(current).As<TLeaf>();
        });
    }

    public static Var<TLeaf> Get<TRoot, TLeaf>(this BlockBuilder b, Var<TRoot> root, IDrill drill)
    {
        var drillFunc = b.GetDrillFunc<TRoot, TLeaf>(drill);
        return b.Call(drillFunc, root);
    }
}


public class ItemModelContext<TItem>
{
    public TItem Item { get; set; }
    public Func<object, TItem> GetItem { get; set; }

    public Func<TItem> GetContextData { get; set; }
}

//public class ModelContext<T>
//{
//    internal IDrill drill = Metapsi.Tutorial.Drill.Root<T>();
//    internal BlockBuilder b;
//    internal Var<T> contextReference;

//    public ModelContext<TChild> OnProperty<TChild>(System.Linq.Expressions.Expression<Func<T, TChild>> drill, Action<BlockBuilder, Var<ItemModelContext<TChild>>> action)
//    {
//        //var itemModelContext = b.NewObj<ItemModelContext<TChild>>();
//        //var getItem = b.DefineFunc((BlockBuilder b, Var<object> rootModel) =>
//        //{
//        //    return b.Get<object, TChild>();
//        //});

//        //b.Set(itemModelContext, x => x.Item, item);
//        //b.Set(itemModelContext, x => x.GetItem, getItem);

//        //ItemModelContext<TChild> childContext = new ItemModelContext<TChild>();
//        //childContext.Drill = this.drill.Down<T, TChild>(drill);
//        //childContext.GetItem = b.DefineFunc((BlockBuilder b, Var<object> rootModel) =>
//        //{
//        //    return b.Get<object, TChild>(rootModel, childContext.Drill);
//        //});

//        //ModelContext<TChild> childContext = new ModelContext<TChild>();
//        //childContext.drill = this.drill.Down<T, TChild>(drill);
//        //childContext.b = b;
//        //var childReference = b.Get<T, TChild>(contextReference, childContext.drill);
//        //b.Call(action, childReference);
//        //return childContext;
//    }

//    public ModelContext<TChild> OnList<TChild>(System.Linq.Expressions.Expression<Func<T, List<TChild>>> drill, Action<BlockBuilder, Var<ItemModelContext<TChild>>> action)
//    {
//        ModelContext<TChild> childContext = new ModelContext<TChild>();
//        childContext.drill = this.drill.Down<T, List<TChild>>(drill);
//        childContext.b = b;
//        var childListReference = b.Get<T, List<TChild>>(contextReference, childContext.drill);
//        var indexRef = b.Ref(b.Const(0));
//        b.Foreach(childListReference, (b, item) =>
//        {
//            var itemIndex = b.GetRef(indexRef);
//            var getItem = b.DefineFunc((BlockBuilder b, Var<object> state) =>
//            {
//                b.Log("getItem itemIndex", itemIndex);
//                //var drillFunc = b.GetDrillFunc<object, List<TChild>>(childContext.drill);
//                var childListReference = b.Get<T, List<TChild>>(contextReference, childContext.drill);
//                var innerIndex = b.Ref(b.Const(0));
//                var currentItem = b.Ref(b.Const(new object()));
//                b.Foreach(childListReference,
//                    (b, item) =>
//                    {
//                        b.If(b.AreEqual(itemIndex, b.GetRef(innerIndex)),
//                            b =>
//                            {
//                                //b.Log("item set for index", itemIndex);
//                                //b.Log("to value", item);
//                                b.SetRef(currentItem, item.As<object>());
//                            });
//                        b.SetRef(innerIndex, b.Get(b.GetRef(innerIndex), x => x + 1));
//                    });

//                return b.GetRef(currentItem).As<TChild>();
//            });

//            var itemModelContext = b.NewObj<ItemModelContext<TChild>>();
//            b.Set(itemModelContext, x => x.Item, item);
//            b.Set(itemModelContext, x => x.GetItem, getItem);

//            b.Call(action, itemModelContext);
//            b.SetRef(indexRef, b.Get(b.GetRef(indexRef), x => x + 1));
//        });
//        return childContext;
//    }
//}

//public static class ModelContext
//{
//    public static ModelContext<T> Root<T>(this BlockBuilder b, Var<T> model)
//    {
//        ModelContext<T> root = new ModelContext<T>();
//        root.drill = Drill.Root<T>();
//        root.b = b;
//        root.contextReference = model;
//        return root;
//    }
//}

public class HyperAppNode<TDataModel, TComponentModel, TControl> : IHtmlComponent, IHtmlNode, IClientSideNode<TDataModel>
    where TControl: IHtmlElement
{
    public bool AlreadyRendered { get; set; }

    // TODO: Model should come from outside
    public TDataModel Model { get; set; }

    public TControl TakeoverNode { get; set; }

    public System.Linq.Expressions.Expression<Func<TDataModel, TComponentModel>> GetComponentModel { get; set; }

    public string TakeoverId => TakeoverNode.GetTag().Attributes["id"];

    public System.Func<BlockBuilder, Var<TDataModel>, Var<HyperNode>> Render { get; set; } = (b, model) => b.Div();
    public System.Func<BlockBuilder, Var<TDataModel>, Var<HyperType.StateWithEffects>> Init { get; set; } = (b, model) => b.MakeStateWithEffects(model);

    public event EventHandler<ClientNodeAttachEventArgs> OnAttach;

    protected bool Attached { get; set; }

    public void Attach(DocumentTag document, IHtmlElement parentNode)
    {
        if (!this.Attached)
        {
            var onAttach = this.OnAttach;
            if (onAttach != null)
            {
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
                this.TakeoverNode.GetTag().Attributes["id"]);

                onAttach(this, new ClientNodeAttachEventArgs()
                {
                    Document = document,
                    ParentNode = parentNode,
                    Module = module
                });
            }

            //HyperApp.AttachNode(this, document, parentNode);

            //// Assume control over TakeoverNode
            //// If it's already added to the document, remove it
            //// as we render it from inside this app

            //document.ReplaceById(TakeoverNode.GetTag().Attributes["id"], this);



            //this.OnModuleBuilt(document, parentNode, module);


            //var mainScript = new HtmlTag("script");
            //mainScript.SetAttribute("type", "module");

            //var moduleScript = Metapsi.JavaScript.PrettyBuilder.Generate(module, string.Empty);

            //mainScript.Children.Add(new HtmlText()
            //{
            //    Text = moduleScript
            //});

            //var jsonModel = Metapsi.JavaScript.PrettyBuilder.Serialize(this.Model);

            //mainScript.Children.Add(new HtmlText()
            //{
            //    Text = $"var model = {jsonModel}\n"
            //});

            //mainScript.Children.Add(new HtmlText()
            //{
            //    Text = "\nmain(model)"
            //});

            //document.Head.AddChild(mainScript);
            Attached = true;
        }
    }

    //protected virtual void OnModuleBuilt(DocumentTag document, IHtmlElement parentNode, Syntax.Module module)
    //{
    //    var moduleRequiredTags = module.Consts.Where(x => x.Value is IHtmlElement).Select(x => x.Value as IHtmlElement);

    //    foreach (var requiredTag in moduleRequiredTags)
    //    {
    //        document.Head.AddChild(requiredTag);
    //    }

    //}

    public string ToHtml()
    {
        // ToString, not ToHtml, because TakeoverNode contains 'this'
        // ToHtml will go into infinite recursion
        return TakeoverNode.GetTag().ToString();
    }
}


//public class HyperAppComponent<TComponentModel, TComponent> : IHtmlComponent, IHtmlNode
//    where TComponent: IHtmlComponent
//{
//    // TODO: Model should come from outside
//    public TComponentModel Model { get; set; }

//    public System.Func<BlockBuilder, Var<TComponentModel>, Var<HyperNode>> Render { get; set; } = (b, model) => b.Div();

//    private string DivId = "id_" + Guid.NewGuid();

//    public void Attach(DocumentTag document, IHtmlElement parentNode)
//    {
//        var module = HyperBuilder.BuildModule<TDataModel>((b, model) =>
//        {
//            b.AddSubscription<TDataModel>(
//                "SyncSharedModel",
//                (BlockBuilder b, Var<TDataModel> state) =>
//                {
//                    b.Comment("Subscription");
//                    return b.Listen<TDataModel, TDataModel>(
//                        b.Const("sharedStateUpdate"),
//                        b.MakeAction((BlockBuilder b, Var<TDataModel> oldModel, Var<TDataModel> newModel) =>
//                        {
//                            b.Log("Subscription");
//                            return newModel;
//                        }));
//                });

//            return this.Render(b, model);
//        },
//                this.Init,
//                this.TakeoverNode.GetTag().Attributes["id"]);

//        onAttach(this, new ClientNodeAttachEventArgs()
//        {
//            Document = document,
//            ParentNode = parentNode,
//            Module = module
//        });
//    }


//    public string ToHtml()
//    {
//        // ToString, not ToHtml, because TakeoverNode contains 'this'
//        // ToHtml will go into infinite recursion
//        return new DivTag<>
//    }
//}


public class HyperAppNode<TDataModel> : IHtmlNode, IHtmlComponent
{
    // TODO: Model should come from outside
    public TDataModel Model { get; set; }

    public HtmlTag TakeoverNode { get; set; }
    public System.Func<BlockBuilder, Var<TDataModel>, Var<HyperNode>> Render { get; set; } = (b, model) => b.Div();
    public System.Func<BlockBuilder, Var<TDataModel>, Var<HyperType.StateWithEffects>> Init { get; set; } = (b, model) => b.MakeStateWithEffects(model);

    public void Attach(DocumentTag document, IHtmlElement parentNode)
    {
        // Assume control over TakeoverNode
        // If it's already added to the document, remove it
        // as we render it from inside this app

        document.ReplaceById(TakeoverNode.Attributes["id"], this);

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

        var moduleRequiredTags = module.Consts.Where(x => x.Value is IHtmlElement).Select(x => x.Value as IHtmlElement);

        foreach (var requiredTag in moduleRequiredTags)
        {
            document.Head.AddChild(requiredTag);
        }

        var mainScript = new HtmlTag("script");
        mainScript.SetAttribute("type", "module");

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

    //public void OnMount(DocumentTag document, IHtmlElement parent)
    //{
    //    // Assume control over TakeoverNode
    //    // If it's already added to the document, remove it
    //    // as we render it from inside this app

    //    document.ReplaceById(TakeoverNode.Attributes["id"], this);

    //    // It the HyperAppNode is already attached to TakeoverNode, all is ok
    //    //if (!parent.HasAttribute("id", TakeoverNode.Attributes["id"]))
    //    //{
    //    //    // If takeover node is not yet attached, the node was created in isolation
    //    //    // Attach now
    //    //    if (parent.GetDescendantById(TakeoverNode.Attributes["id"]) == null)
    //    //    {
    //    //        parent.ToTag().AddChild(TakeoverNode);
    //    //    }
    //    //}

    //    var module = HyperBuilder.BuildModule<TDataModel>((b, model) =>
    //    {
    //        b.AddSubscription<TDataModel>(
    //            "SyncSharedModel",
    //            (BlockBuilder b, Var<TDataModel> state) =>
    //            {
    //                b.Comment("Subscription");
    //                return b.Listen<TDataModel, TDataModel>(
    //                    b.Const("sharedStateUpdate"),
    //                    b.MakeAction((BlockBuilder b, Var<TDataModel> oldModel, Var<TDataModel> newModel) =>
    //                    {
    //                        b.Log("Subscription");
    //                        return newModel;
    //                    }));
    //            });

    //        return this.Render(b, model);
    //    },
    //    this.Init,
    //    this.TakeoverNode.Attributes["id"]);

    //    var moduleRequiredTags = module.Consts.Where(x => x.Value is IHtmlElement).Select(x => x.Value as IHtmlElement);

    //    foreach (var requiredTag in moduleRequiredTags)
    //    {
    //        document.Head.AddChild(requiredTag);
    //    }

    //    var mainScript = new HtmlTag("script");
    //    mainScript.SetAttribute("type", "module");

    //    var moduleScript = Metapsi.JavaScript.PrettyBuilder.Generate(module, string.Empty);

    //    mainScript.Children.Add(new HtmlText()
    //    {
    //        Text = moduleScript
    //    });

    //    var jsonModel = Metapsi.JavaScript.PrettyBuilder.Serialize(this.Model);

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
        var appContainer = mountPoint.AddChild(new DivTag().SetAttribute("id", mountDivId));

        var hyperApp = new HyperAppNode<TDataModel>()
        {
            Model = model,
            Init = init,
            Render = render,
            TakeoverNode = appContainer
        };

        appContainer.AddChild(hyperApp);
    }

    //public static HyperAppNode<TDataModel> ToClientSide<TDataModel>(
    //    this HtmlTag takeoverNode,
    //    TDataModel model)
    //{
    //    if (!takeoverNode.GetTag().Attributes.ContainsKey("id"))
    //    {
    //        takeoverNode.SetAttribute("id", $"id_{Guid.NewGuid()}");
    //    }

    //    var hyperApp = new HyperAppNode<TDataModel>()
    //    {
    //        Model = model,
    //        Render = (b, model) => b.ServerToClient(takeoverNode),
    //        TakeoverNode = takeoverNode
    //    };

    //    takeoverNode.GetTag().Children.Add(hyperApp);

    //    return hyperApp;
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