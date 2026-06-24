using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;

namespace Metapsi.Html;

/// <summary>
/// A node is any html content on the page, both tags and text
/// </summary>
public interface IHtmlNode
{
    string ToHtml(ToHtmlOptions options);
    bool IsEquivalentTo(IHtmlNode other);
}


public class HtmlText : IHtmlNode, IVNode
{
    public string Text { get; set; } = string.Empty;

    public HtmlText() { }

    public HtmlText(string text)
    {
        this.Text = text;
    }

    public override string ToString()
    {
        return this.Text;
    }

    public string ToHtml(ToHtmlOptions options)
    {
        return this.Text;
    }

    public bool IsEquivalentTo(IHtmlNode other)
    {
        if (other == null) return false;
        HtmlText otherText = other as HtmlText;
        if (otherText == null) return false;
        return this.Text == otherText.Text;
    }
}

public class HtmlTag : IHtmlNode, IVNode
{
    public string Tag { get; set; } = string.Empty;
    public Dictionary<string, string> Attributes { get; set; } = new();
    public List<IHtmlNode> Children { get; set; } = new();
    public HtmlTag() { }

    public HtmlTag(string tag)
    {
        this.Tag = tag;
    }

    public override string ToString()
    {
        StringBuilder builder = new StringBuilder();

        builder.Append($"<{this.Tag}");
        foreach (var attribute in this.Attributes)
        {
            builder.Append($" {attribute.Key}=\"{attribute.Value}\"");
        }
        builder.Append(">");
        builder.Append($"[... {Children.Count} children ...]");

        // Do not append children, as this would make for
        // a bad debug experience, especially when investigating 
        // infinitely recursive children

        builder.AppendLine($"</{this.Tag}>");

        return builder.ToString();
    }

    public virtual string ToHtml(ToHtmlOptions toHtmlOptions = null)
    {
        if (toHtmlOptions == null) toHtmlOptions = new ToHtmlOptions();

        StringBuilder builder = new StringBuilder();

        builder.Append($"<{this.Tag}");
        foreach (var attribute in this.Attributes)
        {
            var attributeValue = attribute.Value;

            builder.Append($" {attribute.Key}=\"{attributeValue}\"");
        }
        builder.Append(">");

        if (!SelfClosing.Tags.Contains(this.Tag))
        {
            foreach (var child in this.Children)
            {
                if (child != null) // optional children are null
                {
                    builder.Append(child.ToHtml(toHtmlOptions));
                }
            }
            builder.Append($"</{this.Tag}>");
        }

        return builder.ToString();
    }

    public bool IsEquivalentTo(IHtmlNode other)
    {
        if (other == null) return false;
        var otherTag = other as HtmlTag;
        if (otherTag == null) return false;

        if (otherTag.Tag != this.Tag) return false;
        if (otherTag.Attributes.Count != this.Attributes.Count) return false;
        foreach (var attribute in otherTag.Attributes)
        {
            if (this.Attributes[attribute.Key] != attribute.Value) return false;
        }

        if (otherTag.Children.Count != this.Children.Count) return false;

        for (int i = 0; i < otherTag.Children.Count; i++)
        {
            var thisChild = this.Children[i];
            if (thisChild == null) return false;
            var otherChild = otherTag.Children[i];
            if (otherChild == null) return false;
            if (!thisChild.IsEquivalentTo(otherChild)) return false;
        }

        return true;
    }
}

public class JsModuleNode : IHtmlNode
{
    public Module Module { get; set; }

    public bool IsEquivalentTo(IHtmlNode other)
    {
        if (other == null)
            return false;
        JsModuleNode otherModuleNode = other as JsModuleNode;
        if (otherModuleNode == null) return false;
        return this.Module == otherModuleNode.Module;
    }

    public string ToHtml(ToHtmlOptions options)
    {
        return this.Module.ToJs(options.ToJavaScriptOptions);
    }
}

public class CssNode : IHtmlNode
{
    public List<Metapsi.Html.CssRule> Rules { get; set; } = new List<CssRule>();

    public bool IsEquivalentTo(IHtmlNode other)
    {
        if (other == null)
            return false;

        CssNode otherCssNode = other as CssNode;

        if (otherCssNode == null) return false;

        if (this.Rules.Count != otherCssNode.Rules.Count) return false;

        return this.Rules == otherCssNode.Rules;
    }

    public string ToHtml(ToHtmlOptions options)
    {
        return string.Join("\n", Rules.Select(x => x.ToCss(2)));
    }
}

public static class SelfClosing
{
    public static HashSet<string> Tags = new HashSet<string>()
    {
        "area",
        "base",
        "br",
        "col",
        "embed",
        "hr",
        "img",
        "input",
        "link",
        "meta",
        "param",
        "source",
        "track",
        "wbr",
    };
}

public static class HtmlNodeExtensions
{
    public static void SetAttribute(this HtmlTag element, string name, string value)
    {
        element.Attributes[name] = value;
    }
}
