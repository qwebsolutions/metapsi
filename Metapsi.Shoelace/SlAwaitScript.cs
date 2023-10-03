using Metapsi.Dom;
using Metapsi.JavaScript;
using Metapsi.Syntax;
using Metapsi.Ui;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Metapsi.Shoelace;

public class SlAwaitWhenDefinedScript : BaseTag
{
    public HashSet<string> SlTags { get; set; } = new();
    public HashSet<Action<BlockBuilder>> ThenActions { get; set; } = new();

    public override HtmlTag GetTag()
    {
        ModuleBuilder moduleBuilder = new ModuleBuilder();
        moduleBuilder.Define(
            "whenDefinedCallback", b =>
            {
                foreach (var action in ThenActions)
                {
                    b.Call(action);
                }
            });
        var moduleCode = PrettyBuilder.Generate(moduleBuilder.Module, string.Empty);

        var scriptTag = new HtmlTag("script");
        scriptTag.SetAttribute("type", "module");

        var whenDefinedArray = string.Join(",\n", SlTags.Select(x => $"customElements.whenDefined('{x}')"));

        moduleCode += $"await Promise.allSettled([{whenDefinedArray}]);";
        moduleCode += "\n whenDefinedCallback()";

        scriptTag.AddChild(new HtmlText()
        {
            Text = moduleCode
        });

        return scriptTag;
    }
}

public static class SlAwaitWhenDefinedScriptExtensions
{
    public static SlAwaitWhenDefinedScript GetSlAwaitWhenDefinedScript(this DocumentTag document)
    {
        var slAwaitScript = document.Head.Children.OfType<SlAwaitWhenDefinedScript>().SingleOrDefault();
        if (slAwaitScript == null)
        {
            slAwaitScript = document.Head.AddChild(new SlAwaitWhenDefinedScript());
        }
        return slAwaitScript;
    }

    public static void SlAwaitWhenUpdated(this BlockBuilder b, Var<string> controlId, Action<BlockBuilder> action)
    {
        b.Log(controlId);
        var domControl = b.GetElementById(controlId);
        b.CallExternal("Metapsi.Shoelace", "WhenUpdateComplete", domControl, b.Def(action));
    }
}