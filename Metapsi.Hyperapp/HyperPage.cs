using Metapsi.Syntax;
using Metapsi.Ui;
using System.Linq;

namespace Metapsi.Hyperapp
{
    public abstract class HyperPage<TDataModel> : HtmlPage<TDataModel>
    {
        public abstract Var<HyperNode> OnRender(BlockBuilder b, Var<TDataModel> model);
        public virtual Var<HyperType.StateWithEffects> OnInit(BlockBuilder b, Var<TDataModel> model)
        {
            return b.MakeStateWithEffects(model);
        }

        public override IHtmlNode GetHtmlTree(TDataModel dataModel)
        {
            var module = new ModuleBuilder().BuildHyperapp<TDataModel>(this.OnRender, this.OnInit, GetMountDivId());

            var moduleRequiredTags = module.Consts.Where(x => x.Value is IHtmlElement).Select(x => x.Value as IHtmlElement);

            var root = DocumentTag.Create();
            var head = root.Head;
            var body = root.Body;

            foreach (var requiredTag in moduleRequiredTags)
            {
                head.AddChild(requiredTag.GetTag());
            }

            var mainScript = body.AddChild(new HtmlTag("script"));
            mainScript.SetAttribute("type", "module");

            var moduleScript = Metapsi.JavaScript.PrettyBuilder.Generate(module, string.Empty);

            mainScript.Children.Add(new HtmlText()
            {
                Text = moduleScript
            });

            var model = Metapsi.JavaScript.PrettyBuilder.Serialize(dataModel);

            mainScript.Children.Add(new HtmlText()
            {
                Text = $"var model = {model}\n"
            });

            mainScript.Children.Add(new HtmlText()
            {
                Text = "\nmain(model)"
            });

            var mainDiv = body.AddChild(new HtmlTag("div"));
            mainDiv.SetAttribute("id", GetMountDivId());

            ModifyHtml(root, module);
            return root;
        }

        public virtual string GetMountDivId()
        {
            return "app";
        }

        public virtual IHtmlNode ModifyHtml(IHtmlNode root, Module module)
        {
            return root;
        }
    }
}