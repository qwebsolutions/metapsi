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

    public static IHtmlNode HtmlScriptModule(
        this HtmlBuilder b,
        Action<AttributesBuilder<HtmlScript>> setAttributes,
        Action<SyntaxBuilder> buildScript)
    {
        ModuleBuilder moduleBuilder = new ModuleBuilder();
        moduleBuilder.AddFunction("main", buildScript);

        var scriptTag = b.HtmlScript(
            b =>
            {
                b.SetAttribute("type", "module");
                setAttributes(b);
            });

        moduleBuilder.Module.Nodes.Add(
            new SyntaxNode()
            {
                Call = new CallNode()
                {
                    Fn = new SyntaxNode()
                    {
                        Identifier = new IdentifierNode()
                        {
                            Name = "main"
                        }
                    }
                }
            });

        return b.HtmlScript(
            b =>
            {
                b.SetAttribute("type", "module");
                setAttributes(b);
            },
            new HtmlNode()
            {
                Modules = new System.Collections.Generic.List<Module>()
                {
                    moduleBuilder.Module
                }
            });
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
            b.HeadAppend(new HtmlNode() { Tags = requiredTags });
        }

        return true;
    }
}
