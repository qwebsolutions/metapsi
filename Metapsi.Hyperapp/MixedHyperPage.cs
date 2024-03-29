﻿using Metapsi.Syntax;
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

        public abstract Var<IVNode> OnRender(LayoutBuilder b, TServerModel serverModel, Var<TClientModel> clientModel);
        public virtual Var<HyperType.StateWithEffects> OnInit(SyntaxBuilder b, Var<TClientModel> model)
        {
            return b.MakeStateWithEffects(model);
        }

        public override void FillHtml(TServerModel serverModel, DocumentTag document)
        {
            var dataModel = ExtractClientModel(serverModel);

            var module = new ModuleBuilder().BuildHyperapp<TClientModel>(
                (b, clientModel) =>
                {
                    return OnRender(b, serverModel, clientModel);
                },
                this.OnInit);

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
            mainDiv.SetAttribute("id", "app");
        }
    }
}