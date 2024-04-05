using Metapsi.Syntax;
using Metapsi.Ui;
using System.Linq;
using Metapsi.Dom;

namespace Metapsi.Hyperapp;

public class HyperAppNode<TDataModel> : IHtmlNode, IHtmlComponent
{
    // TODO: Model should come from outside
    public TDataModel Model { get; set; }

    public ModuleBuilder ModuleBuilder { get; } = new ModuleBuilder();

    public HtmlTag TakeoverNode { get; set; }
    public System.Func<LayoutBuilder, Var<TDataModel>, Var<IVNode>> Render { get; set; } = (b, model) => b.T("");
    public System.Func<SyntaxBuilder, Var<TDataModel>, Var<HyperType.StateWithEffects>> Init { get; set; } = (b, model) => b.MakeStateWithEffects(model);

    public virtual void Attach(DocumentTag document, IHtmlElement parentNode)
    {
        // Assume control over TakeoverNode
        // If it's already added to the document, remove it
        // as we render it from inside this app

        document.ReplaceById(TakeoverNode.Attributes["id"], this);

        var module = this.ModuleBuilder.BuildHyperapp((b, model) =>
        {
            b.AddSubscription<TDataModel>(
                "SyncSharedModel",
                (SyntaxBuilder b, Var<TDataModel> state) =>
                {
                    return b.Listen<TDataModel, TDataModel>(
                        b.Const("sharedStateUpdate"),
                        b.MakeAction((SyntaxBuilder b, Var<TDataModel> oldModel, Var<TDataModel> newModel) =>
                        {
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

        var webComponentTags = module.Consts.Where(x => x.Value is WebComponentTag);
        foreach (var wcTag in webComponentTags)
        {
            document.AddToFadeInList((wcTag.Value as WebComponentTag).tag);
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
    public static Var<TModel> BroadcastModelUpdate<TModel>(this SyntaxBuilder b, Var<TModel> model)
    {
        var clone = b.Clone(model);
        b.DispatchEvent(b.Const("sharedStateUpdate"), clone);
        return clone;
    }
}
