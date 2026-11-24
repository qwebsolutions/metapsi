using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Globalization;
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
        return System.Net.WebUtility.HtmlEncode(this.Text);
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
    public string Tag { get; } = string.Empty;
    Dictionary<string, string> Attributes { get; set; } = new();
    public List<IHtmlNode> Children { get; set; } = new();

    public HtmlTag(string tag)
    {
        if (ContainsForbiddenNameChar(tag))
        {
            throw new ArgumentException($"Invalid tag name '{tag}'", nameof(tag));
        }
        this.Tag = tag;
    }

    public HtmlTag(string tag, Dictionary<string, string> attributes)
    {
        if (ContainsForbiddenNameChar(tag))
        {
            throw new ArgumentException($"Invalid tag name '{tag}'", nameof(tag));
        }
        this.Tag = tag;
        foreach (var entry in attributes)
        {
            if (ContainsForbiddenNameChar(entry.Key))
                throw new System.Exception($"Invalid attribute name '{entry.Key}'");
            this.Attributes[entry.Key] = entry.Value;
        }
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

    public virtual string ToHtml(ToHtmlOptions toHtmlOptions)
    {
        StringBuilder builder = new StringBuilder();

        builder.Append($"<{this.Tag}");
        foreach (var attribute in this.Attributes)
        {
            var attributeValue = System.Net.WebUtility.HtmlEncode(attribute.Value);

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
        foreach (var otherTagAttribute in otherTag.Attributes)
        {
            if(!this.Attributes.TryGetValue(otherTagAttribute.Key, out var thisAttributeValue))
            {
                return false;
            }
            if (thisAttributeValue != otherTagAttribute.Value) return false;
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

    private static bool IsForbiddenNameChar(char c)
    {
        if (c <= ' ') return true;                 // C0 controls, tab, LF, FF, CR, space, NUL
        if (c == 0x7F) return true;                // DEL
        switch (c)
        {
            case '/':
            case '>':
            case '<':
            case '=':
            case '"':
            case '\'':
            case '&':
                return true;
        }
        // Invisible / reordering characters: never legitimate in a name
        switch (CharUnicodeInfo.GetUnicodeCategory(c))
        {
            case UnicodeCategory.Control:
            case UnicodeCategory.Format:             // ZWJ, ZWNJ, bidi overrides, BOM
            case UnicodeCategory.LineSeparator:
            case UnicodeCategory.ParagraphSeparator:
            case UnicodeCategory.Surrogate:          // validated per code point below if ever needed
            case UnicodeCategory.OtherNotAssigned:
            case UnicodeCategory.PrivateUse:
                return true;
        }
        return false;
    }

    private static bool ContainsForbiddenNameChar(string name)
    {
        for (int i = 0; i < name.Length; i++)
        {
            if (IsForbiddenNameChar(name[i])) return true;
        }
        return false;
    }

    public static bool IsValidTagName(string name)
    {
        if (string.IsNullOrEmpty(name)) return false;
        if (!char.IsLetter(name[0])) return false;      // parser only opens a tag on a letter
        for (int i = 0; i < name.Length; i++)
        {
            if (IsForbiddenNameChar(name[i])) return false;
        }
        return true;
    }

    public static bool IsValidAttributeName(string name)
    {
        if (string.IsNullOrEmpty(name)) return false;

        // First char: anything that could read as syntax is out.
        // '-' alone would be fine for the tokenizer, but "-x" is never a real
        // attribute, and a leading digit isn't either; keep it to letters and
        // the prefixes frameworks actually use.
        char c0 = name[0];
        if (!(char.IsLetter(c0) || c0 == '_' || c0 == ':' || c0 == '@' || c0 == '*' || c0 == '#' || c0 == '[' || c0 == '('))
            return false;

        for (int i = 0; i < name.Length; i++)
        {
            if (IsForbiddenNameChar(name[i])) return false;
        }
        return true;
    }

    public static bool IsValidCssPropertyName(string name)
    {
        if (string.IsNullOrEmpty(name)) return false;

        char c0 = name[0];
        if (!(char.IsLetter(c0) || c0 == '-')) return false;

        for (int i = 0; i < name.Length; i++)
        {
            char c = name[i];
            if (c <= ' ' || c == 0x7F) return false;              // controls, whitespace
            switch (c)
            {
                case ':':
                case ';':
                case '{':
                case '}':
                case '/':
                case '\\':
                case '"':
                case '\'':
                case '<':
                case '>':
                case '&':
                case '=':
                    return false;
            }
            var cat = CharUnicodeInfo.GetUnicodeCategory(c);
            if (cat == UnicodeCategory.Control || cat == UnicodeCategory.Format ||
                cat == UnicodeCategory.LineSeparator || cat == UnicodeCategory.ParagraphSeparator ||
                cat == UnicodeCategory.Surrogate || cat == UnicodeCategory.OtherNotAssigned ||
                cat == UnicodeCategory.PrivateUse)
                return false;
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
        return this.Module.ToJs(options.JsonSerializer, options.ToJavaScriptOptions);
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
        return string.Join("\n", Rules.Select(x => x.ToCss(options.ToCssOptions)));
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

//public static class HtmlNodeExtensions
//{
//    public static void SetAttribute(this HtmlTag element, string name, string value)
//    {
//        element.Attributes[name] = value;
//    }
//}
