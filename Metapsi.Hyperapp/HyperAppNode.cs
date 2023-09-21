using Metapsi.Syntax;
using Metapsi.Ui;
using System.Linq;
using Metapsi.Dom;

namespace Metapsi.Hyperapp;

public class HyperAppNode<TDataModel> : IHtmlNode, IHtmlComponent
{
    // TODO: Model should come from outside
    public TDataModel Model { get; set; }

    public HtmlTag TakeoverNode { get; set; }
    public System.Func<BlockBuilder, Var<TDataModel>, Var<HyperNode>> Render { get; set; } = (b, model) => b.Div();
    public System.Func<BlockBuilder, Var<TDataModel>, Var<HyperType.StateWithEffects>> Init { get; set; } = (b, model) => b.MakeStateWithEffects(model);

    public System.Action<DocumentTag, IHtmlElement, Module> OnModuleAttached { get; set; } = (d, e, m) => { };

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

        if (this.OnModuleAttached != null)
        {
            this.OnModuleAttached(document, parentNode, module);
        }
    }
    public string ToHtml()
    {
        // ToString, not ToHtml, because TakeoverNode contains 'this'
        // ToHtml will go into infinite recursion
        return TakeoverNode.ToString();
    }
}

public static partial class HyperAppNodeExtensions
{
    public static Var<TModel> BroadcastModelUpdate<TModel>(this BlockBuilder b, Var<TModel> model)
    {
        var clone = b.Clone(model);
        b.DispatchEvent(b.Const("sharedStateUpdate"), clone);
        return clone;
    }
}
