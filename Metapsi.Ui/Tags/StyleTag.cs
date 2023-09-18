using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Metapsi.Ui;

public class StyleTag : BaseTag
{
    public string StyleName { get; set; } = string.Empty;

    public List<CssSelector> Selectors { get; set; } = new();

    public override HtmlTag GetTag()
    {
        var styleTag = new HtmlTag("style");
        styleTag.Children.Add(new HtmlText()
        {
            Text = "\n" + string.Join("\n", Selectors.Select(x => x.ToString()))
        });

        return styleTag;
    }

    public static StyleTag Create(params CssSelector[] selectors)
    {
        StyleTag styleTag = new StyleTag();

        foreach (var selector in selectors)
        {
            styleTag.Selectors.Add(selector);
        }

        return styleTag;
    }
}


public class CssSelector
{
    public string Selector { get; set; } = string.Empty;
    public Dictionary<string, string> Properties { get; set; } = new();

    public CssSelector()
    {
    }

    public CssSelector(string selector)
    {
        this.Selector = selector;
    }

    public override string ToString()
    {
        StringBuilder builder = new StringBuilder();
        builder.Append(this.Selector);
        builder.AppendLine(" {");
        foreach (var property in Properties)
        {
            builder.Append($"  {property.Key}:");
            builder.AppendLine($" {property.Value};");
        }
        builder.AppendLine("}");
        return builder.ToString();
    }

    public static CssSelector Create(string selector)
    {
        return new CssSelector(selector);
    }
}

public static class StyleTagExtensions
{
    public static CssSelector AddSelector(this StyleTag styleTag, string selectorName)
    {
        var selector = new CssSelector() { Selector = selectorName };
        styleTag.Selectors.Add(selector);
        return selector;
    }

    public static CssSelector AddProperty(this CssSelector selector, string propertyName, string propertyValue)
    {
        selector.Properties.Add(propertyName, propertyValue.Trim().TrimEnd(';'));
        return selector;
    }
}
