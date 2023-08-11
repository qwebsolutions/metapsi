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

        public override IHtmlNode GetHtml(TDataModel dataModel)
        {
            var module = HyperBuilder.BuildModule<TDataModel>(this.OnRender, this.OnInit);

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
                        var scriptTag = new HtmlTag("script").AddAttribute("src", script.src);

                        if (!string.IsNullOrEmpty(script.type))
                        {
                            scriptTag.AddAttribute("type", script.type);
                        }

                        head.AddChild(scriptTag);
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