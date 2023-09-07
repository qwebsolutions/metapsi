using Metapsi.Syntax;
using Metapsi.Ui;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Metapsi.Hyperapp
{
    public abstract class MixedHyperPage<TServerModel, TClientModel> : HtmlPage<TServerModel>
    {
        /// <summary>
        /// Extracts the serializable subset of actual data that is used as page model
        /// </summary>
        /// <param name="serverModel"></param>
        /// <returns></returns>
        public abstract TClientModel ExtractClientModel(TServerModel serverModel);

        public abstract Var<HyperNode> OnRender(BlockBuilder b, TServerModel serverModel, Var<TClientModel> clientModel);
        public virtual Var<HyperType.StateWithEffects> OnInit(BlockBuilder b, Var<TClientModel> model)
        {
            return b.MakeStateWithEffects(model);
        }

        public override IHtmlNode GetHtmlTree(TServerModel serverModel)
        {
            var dataModel = ExtractClientModel(serverModel);

            var module = HyperBuilder.BuildModule<TClientModel>(
                (b, clientModel) =>
                {
                    return OnRender(b, serverModel, clientModel);
                },
                this.OnInit);

            var moduleRequiredTags = module.Consts.Where(x => x.Value is IHtmlTag).Select(x => x.Value as IHtmlTag);

            var document = DocumentTag.Create();
            var head = document.Head;
            var body = document.Body;

            foreach (var requiredTag in moduleRequiredTags)
            {
                head.AddChild(requiredTag.ToTag());
            }

            var mainScript = body.AddChild(new HtmlTag("script"));
            mainScript.AddAttribute("type", "module");

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
            mainDiv.AddAttribute("id", "app");

            return document;
        }
    }
}