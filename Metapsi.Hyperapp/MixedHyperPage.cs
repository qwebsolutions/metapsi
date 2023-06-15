using Metapsi.Syntax;
using Metapsi.Ui;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Metapsi.Hyperapp
{
    public abstract class MixedHyperPage<TDataModel, TServerData> : HtmlPage<TServerData>
    {
        /// <summary>
        /// Extracts the serializable subset of actual data that is used as page model
        /// </summary>
        /// <param name="serverData"></param>
        /// <returns></returns>
        public abstract TDataModel ExtractDataModel(TServerData serverData);

        public abstract Var<HyperNode> OnRender(BlockBuilder b, Var<TDataModel> clientModel, TServerData serverData);
        public virtual Var<HyperType.StateWithEffects> OnInit(BlockBuilder b, Var<TDataModel> model)
        {
            return b.MakeStateWithEffects(model);
        }

        public override IHtmlNode GetHtml(TServerData serverData)
        {
            var dataModel = ExtractDataModel(serverData);

            var module = HyperBuilder.BuildModule<TDataModel>(
                (b, clientModel) =>
                {
                    return OnRender(b, clientModel, serverData);
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