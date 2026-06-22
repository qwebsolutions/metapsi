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
        ModuleBuilder moduleBuilder = new ModuleBuilder(b.Resolver);
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
            new JsModuleNode()
            {
                Module = moduleBuilder.Module
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

    public static IHtmlNode HtmlScriptModuleReference(this HtmlBuilder b, IModuleResource module)
    {
        var modulePath = b.ResolvePath(module);
        return b.HtmlScript(
            b =>
            {
                b.SetTypeModule();
                b.SetSrc(modulePath);
            });
    }
}
