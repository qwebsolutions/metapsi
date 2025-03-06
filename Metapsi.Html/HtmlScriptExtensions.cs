using Metapsi.JavaScript;
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
        moduleBuilder.Define("main", buildScript);
        GenerateAddExternalResources(b, moduleBuilder);
        return b.HtmlScript(
            b =>
            {
                b.SetAttribute("type", "module");
                setAttributes(b);
            },
            b.Text(PrettyBuilder.Generate(moduleBuilder.Module)),
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

    public static bool GenerateAddExternalResources(HtmlBuilder b, ModuleBuilder moduleBuilder)
    {
        var distinctTagConstants = moduleBuilder.Module.Consts.Where(x => x.Value is DistinctTag).Distinct().ToList();// are already distinct anyway

        foreach (var tag in distinctTagConstants)
        {
            var distinctTag = tag.Value as DistinctTag;
            b.HeadAppend(distinctTag);
        }

        return true;
    }
}
