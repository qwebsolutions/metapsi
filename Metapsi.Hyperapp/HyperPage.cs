//using Metapsi.Syntax;
//using Metapsi.Ui;
//using System;
//using System.Linq;

//namespace Metapsi.Hyperapp
//{
//    public abstract class HyperPage<TDataModel> : HtmlPage<TDataModel>
//    {
//        public abstract Var<IVNode> OnRender(LayoutBuilder b, Var<TDataModel> model);
//        public virtual Var<HyperType.StateWithEffects> OnInit(SyntaxBuilder b, Var<TDataModel> model)
//        {
//            return b.MakeStateWithEffects(model);
//        }

//        public override void FillHtml(TDataModel dataModel, DocumentTag document)
//        {
//            document.Body.AddChild(
//                new HyperAppNode<TDataModel>()
//                {
//                    Model = dataModel,
//                    Render = (b, clientModel) =>
//                    {
//                        Func<LayoutBuilder, Var<TDataModel>, Var<IVNode>> renderFunc = this.OnRender;
//                        var moduleAssembly = renderFunc.Method.DeclaringType.Assembly;
//                        var moduleStylesheetName = b.GetModuleStylesheetName(moduleAssembly);
//                        if (moduleAssembly.GetManifestResourceNames().Contains(moduleStylesheetName))
//                        {
//                            b.AddModuleStylesheet(renderFunc.Method.DeclaringType.Assembly);
//                        }
//                        return b.Call(this.OnRender, clientModel);
//                    }
//                });
//        }
//    }
//}