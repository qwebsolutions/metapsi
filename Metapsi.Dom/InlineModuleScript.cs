using Metapsi.Syntax;
using Metapsi.Ui;
using System;
using System.Collections.Generic;
using System.Linq;

//namespace Metapsi.Dom
//{
//    public class InlineModuleScript : BaseTag
//    {
//        public ModuleBuilder ModuleBuilder { get; } = new ModuleBuilder();

//        public List<Var<Action>> ActionCalls { get; } = new List<Var<Action>>();

//        public override HtmlTag GetTag()
//        {
//            var code = Metapsi.JavaScript.PrettyBuilder.Generate(ModuleBuilder.Module);

//            code += string.Join("\n", ActionCalls.Select(x => x.Name + "();"));
//            return new HtmlTag("script").SetAttribute("type", "module").WithChild(new HtmlText(code));
//        }

//        public void CallAction(Var<Action> action)
//        {
//            this.ActionCalls.Add(action);
//        }
//    }


//    public static partial class JsExtensions
//    {
//        public static void AddJs(this IHtmlElement htmlElement, Action<SyntaxBuilder> jsCall)
//        {
//            var inlineScript = htmlElement.AddChild(new InlineModuleScript());
//            var definition = inlineScript.ModuleBuilder.Define(inlineScript.ModuleBuilder.NewName(), jsCall);
//            inlineScript.ActionCalls.Add(definition);
//        }
//    }
//}

