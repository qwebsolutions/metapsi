using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Metapsi.Html;

/// <summary>
/// 
/// </summary>
public class ToCssOptions
{
    /// <summary>
    /// 
    /// </summary>
    public int IndentSpaces { get; set; } = 2;
}

internal class CssRule
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

    public string ToCss(ToCssOptions toCssOptions)
    {
        if (toCssOptions == null) toCssOptions = new ToCssOptions();
        return this.ToCss(toCssOptions, 0);
    }

    private string ToCss(ToCssOptions toCssOptions, int nestingLevel)
    {
        var isStylesheetTop = string.IsNullOrWhiteSpace(Prelude);

        // The only case where there's no prelude.
        // Stylesheet itself is represented as a CssRule with just nested rules to avoid a separate builder declaration for stylesheet
        if (isStylesheetTop)
        {
            var css = "\n" + string.Join("\n", NestedRules.Select(x => x.ToCss(toCssOptions, nestingLevel)));
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
            var indentSpaces = new string(' ', nestingLevel * toCssOptions.IndentSpaces);

            var declarations = string.Join("\n", Declarations.Select(x => $"  {indentSpaces}{x.Key}: {x.Value};"));
            var nested = string.Join("\n", NestedRules.Select(x => x.ToCss(toCssOptions, nestingLevel + 1)));

            var outputCss = indentSpaces + Prelude + " {\n";
            outputCss += declarations;
            outputCss += nested;
            outputCss += "\n" + indentSpaces + "}";
            return outputCss;
        }
    }
}

public class CssBuilder : IStyleBuilder, ICanRequestResourcePath
{
    public IResourceResolver ResourceResolver { get; }

    public CssBuilder(IResourceResolver resolver)
    {
        if (resolver == null)
        {
            throw new System.ArgumentNullException("resolver");
        }
        this.ResourceResolver = resolver;
    }

    internal CssRule Rule { get; set; } = new CssRule();

    public void AddStyle(string property, string value)
    {
        if (!HtmlTag.IsValidCssPropertyName(property))
        {
            throw new ArgumentException($"Invalid CSS property name '{property}'", nameof(property));
        }

        if (value == null)
            throw new ArgumentNullException(nameof(value));

        if (HtmlTag.ContainsStyleEndTag(value))
        {
            throw new ArgumentException($"Invalid CSS property name '{property}'", nameof(property));
        }

        Rule.Declarations[property] = value;
    }

    public void AddRule(string prelude, System.Action<CssBuilder> builder)
    {
        if (string.IsNullOrWhiteSpace(prelude))
            throw new ArgumentException("A rule needs a selector or an at-rule", nameof(prelude));
        if (HtmlTag.ContainsStyleEndTag(prelude))
            throw new ArgumentException($"Invalid CSS rule '{prelude}'", nameof(prelude));

        var nestedRule = new CssRule() { Prelude = prelude };
        var nestedBuilder = new CssBuilder(this.ResourceResolver) { Rule = nestedRule };
        builder(nestedBuilder);
        this.Rule.NestedRules.Add(nestedRule);
    }

    public string ResolvePath(IResource resource)
    {
        return this.ResourceResolver.ResolvePath(resource);
    }

    public string GetCss(ToCssOptions toCssOptions)
    {
        return this.Rule.ToCss(toCssOptions);
    }

    public static string GetCss(System.Action<CssBuilder> build, IResourceResolver resourceResolver, ToCssOptions toCssOptions)
    {
        var b = new CssBuilder(resourceResolver);
        build(b);
        return b.GetCss(toCssOptions);
    }
}

public static class CssBuilderExtensions
{
    /// <summary>
    /// Adds a style tag with content build by <paramref name="addCss"/>. This explicitly needs <paramref name="setAttributes"/> so the signature doesn't clash with the default one
    /// </summary>
    /// <param name="b"></param>
    /// <param name="setAttributes"></param>
    /// <param name="addCss"></param>
    /// <returns></returns>
    public static IHtmlNode HtmlStyle(
        this HtmlBuilder b,
        System.Action<IHtmlPropsBuilder> setAttributes,
        System.Action<CssBuilder> addCss)
    {
        var builder = new CssBuilder(b.ResourceResolver)
        {
            Rule = new CssRule()
            {
                Prelude = string.Empty,
            }
        };

        addCss(builder);
        var cssNode = new CssNode()
        {
            Rules = builder.Rule.NestedRules
        };
        //var cssText = builder.Rule.ToCss();

        return b.HtmlStyle(cssNode);
    }
}