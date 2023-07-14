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

        public override IHtmlNode GetHtml(TServerModel serverModel)
        {
            var dataModel = ExtractClientModel(serverModel);

            var module = HyperBuilder.BuildModule<TClientModel>(
                (b, clientModel) =>
                {
                    return OnRender(b, serverModel, clientModel);
                },
                this.OnInit);

            var links = module.Consts.Where(x => x.Value is LinkTag).Select(x => x.Value as LinkTag);
            var scripts = module.Consts.Where(x => x.Value is ScriptTag).Select(x => x.Value as ScriptTag);

            return Template.BlankPage(
                buildHead: head =>
                {
                    foreach (var link in links)
                    {
                        head.AddChild(new HtmlTag("link").AddAttribute("rel", link.rel).AddAttribute("href", link.href));
                    }

                    foreach (var script in scripts)
                    {
                        head.AddChild(new HtmlTag("script").AddAttribute("src", script.src));
                    }
                },
                buildBody: body =>
                {
                    var mainScript = body.AddChild(new HtmlTag("script"));
                    mainScript.Attributes.Add("type", "module");

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
                    mainDiv.Attributes.Add("id", "app");
                });
        }

    }
}