using System.Collections.Generic;
using System.Linq;

namespace Metapsi.Html;

public class CssRule
{
    /// <summary>
    /// This seems to be the spec terminology that encompasses @ rules and qualified selectors
    /// </summary>
    public string Prelude { get; set; }

    /// <summary>
    /// @ rules can have nested rules
    /// </summary>
    public List<CssRule> NestedRules { get; set; } = new List<CssRule>();

    /// <summary>
    /// The actual CSS properties
    /// </summary>
    public Dictionary<string, string> Declarations { get; set; } = new Dictionary<string, string>();

    public string ToCss(int indent = 0)
    {
        var isStylesheetTop = string.IsNullOrWhiteSpace(Prelude);

        // The only case where there's no prelude.
        // Stylesheet itself is represented as a CssRule with just nested rules to avoid a separate builder declaration for stylesheet
        if (isStylesheetTop)
        {
            var css = "\n" + string.Join("\n", NestedRules.Select(x => x.ToCss(indent)));
            return css;
        }

        // Has no block. Applies to @import, @charset...
        var isStatement = !Declarations.Any() && !NestedRules.Any();
        if (isStatement)
        {
            return Prelude + ";\n";
        }
        else
        {
            var indentSpaces = new string(' ', indent * 2);

            var declarations = string.Join("\n", Declarations.Select(x => $"  {indentSpaces}{x.Key}: {x.Value};"));
            var nested = string.Join("\n", NestedRules.Select(x => x.ToCss(indent + 1)));

            var outputCss = indentSpaces + Prelude + " {\n";
            outputCss += declarations;
            outputCss += nested;
            outputCss += "\n" + indentSpaces + "}";
            return outputCss;
        }
    }
}

public class CssBuilder : IStyleBuilder
{
    public CssRule Rule { get; set; } = new CssRule();

    public void AddStyle(string property, string value)
    {
        Rule.Declarations[property] = value;
    }

    public void AddRule(string prelude, System.Action<CssBuilder> builder)
    {
        var nestedRule = new CssRule() { Prelude = prelude };
        var nestedBuilder = new CssBuilder() { Rule = nestedRule };
        builder(nestedBuilder);
        this.Rule.NestedRules.Add(nestedRule);
    }
}

public static class CssBuilderExtensions
{
    public static IHtmlNode HtmlStyleSheet(
        this HtmlBuilder b,
        System.Action<CssBuilder> addCss)
    {
        var builder = new CssBuilder()
        {
            Rule = new CssRule()
            {
                Prelude = string.Empty,
            }
        };

        addCss(builder);
        var cssText = builder.Rule.ToCss();

        return b.HtmlStyle(b.Text(cssText));
    }
}