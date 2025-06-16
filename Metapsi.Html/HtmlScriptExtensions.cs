using Metapsi.Syntax;
using System;
using System.Linq;

namespace Metapsi.Html;

public static class HtmlScriptExtensions
{
    public static void SetTypeModule(this AttributesBuilder<HtmlScript> b)
    {
        b.SetAttribute("type", "module");
    }

    public static IHtmlNode HtmlScriptModule(this HtmlBuilder b, Action<AttributesBuilder<HtmlScript>> setAttributes, Action<SyntaxBuilder> buildScript)
    {
        ModuleBuilder moduleBuilder = new ModuleBuilder();
        moduleBuilder.AddFunction("main", buildScript);
        //GenerateAddExternalResources(b, moduleBuilder);
        return b.HtmlScript(
            b =>
            {
                b.SetAttribute("type", "module");
                setAttributes(b);
            },
            b.Text(moduleBuilder.Module.ToJs()),
            b.Text("main()"));
    }

    public static IHtmlNode HtmlScriptModule(
        this HtmlBuilder b, 
        Action<SyntaxBuilder> buildScript)
    {
        return b.HtmlScriptModule(b => { }, buildScript);
    }

    public static IHtmlNode HtmlScript(
        this HtmlBuilder b,
        string code)
    {
        return b.HtmlScript(
            b =>
            {
            },
            b.Text(code));
    }

    public static bool GenerateAddExternalResources(HtmlBuilder b, Module module)
    {
        var requiredTags = module.GetRequiredTagsMetadata();

        foreach (var tag in requiredTags)
        {
            b.HeadAppend(tag);
        }

        return true;
    }
}
