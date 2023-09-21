using Metapsi.Syntax;
using Metapsi.Ui;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Metapsi.Dom
{
    public class InlineModuleScript : BaseTag
    {
        public ModuleBuilder ModuleBuilder { get; } = new ModuleBuilder();

        public List<Var<Action>> ActionCalls { get; } = new List<Var<Action>>();

        public override HtmlTag GetTag()
        {
            var code = Metapsi.JavaScript.PrettyBuilder.Generate(ModuleBuilder.Module, string.Empty);

            code += string.Join("\n", ActionCalls.Select(x => x.Name + "();"));
            return new HtmlTag("script").SetAttribute("type", "module").WithChild(new HtmlText(code));
        }

        public void CallAction(Var<Action> action)
        {
            this.ActionCalls.Add(action);
        }
    }
}

