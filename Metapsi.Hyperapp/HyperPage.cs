using Metapsi.Syntax;
using Metapsi.Ui;
using System;
using System.Linq;

namespace Metapsi.Hyperapp
{
    public abstract class HyperPage<TDataModel> : HtmlPage<TDataModel>
    {
        public abstract Var<IVNode> OnRender(LayoutBuilder b, Var<TDataModel> model);
        public virtual Var<HyperType.StateWithEffects> OnInit(SyntaxBuilder b, Var<TDataModel> model)
        {
            return b.MakeStateWithEffects(model);
        }

        public override void FillHtml(TDataModel dataModel, DocumentTag document)
        {
            var module = new ModuleBuilder().BuildHyperapp<TDataModel>(
                (b, clientModel)=>
                {
                    Func<LayoutBuilder, Var<TDataModel>, Var<IVNode>> renderFunc = this.OnRender;
                    var moduleAssembly = renderFunc.Method.DeclaringType.Assembly;
                    var moduleStylesheetName = b.GetModuleStylesheetName(moduleAssembly);
                    if (moduleAssembly.GetManifestResourceNames().Contains(moduleStylesheetName))
                    {
                        b.AddModuleStylesheet(renderFunc.Method.DeclaringType.Assembly);
                    }
                    return b.Call(this.OnRender, clientModel);
                },
                this.OnInit, 
                GetMountDivId());

            var moduleRequiredTags = module.Consts.Where(x => x.Value is IHtmlElement).Select(x => x.Value as IHtmlElement);

            var head = document.Head;
            var body = document.Body;

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
        }

        public virtual string GetMountDivId()
        {
            return "app";
        }
    }
}