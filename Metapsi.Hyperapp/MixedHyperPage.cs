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

        public abstract Var<IVNode> OnRender(LayoutBuilder b, TServerModel serverModel, Var<TClientModel> clientModel);
        public virtual Var<HyperType.StateWithEffects> OnInit(SyntaxBuilder b, Var<TClientModel> model)
        {
            return b.MakeStateWithEffects(model);
        }

        public override void FillHtml(TServerModel serverModel, DocumentTag document)
        {
            document.UseWebComponentsFadeIn();

            var dataModel = ExtractClientModel(serverModel);

            document.Body.AddChild(
                new HyperAppNode<TClientModel>()
                {
                    Model = dataModel,
                    Render = (b, clientModel) => OnRender(b, serverModel, clientModel),
                    Init = b => this.OnInit(b, b.Const(dataModel))
                });
        }
    }
}