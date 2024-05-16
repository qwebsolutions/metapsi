using Metapsi.JavaScript;
using Metapsi.Syntax;
using Metapsi.Ui;
using System;

namespace Metapsi.Html;

public static class HtmlScriptExtensions
{
    public static IHtmlNode HtmlScriptModule(this HtmlBuilder b, Action<AttributesBuilder<HtmlScript>> setAttributes, Action<SyntaxBuilder> buildScript)
    {
        ModuleBuilder moduleBuilder = new ModuleBuilder();
        moduleBuilder.Define("main", buildScript);
        return b.HtmlScript(
            b =>
            {
                b.SetAttribute("type", "module");
                setAttributes(b);
            },
            b.Text(PrettyBuilder.Generate(moduleBuilder.Module, "")),
            b.Text("main()"));
    }

    public static IHtmlNode HtmlScriptModule(
        this HtmlBuilder b, 
        Action<SyntaxBuilder> buildScript)
    {
        return b.HtmlScriptModule(b => { }, buildScript);
    }
}
