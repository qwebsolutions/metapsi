using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace Metapsi.Ui;

public interface IHtmlNode
{
    public string ToHtml();
}

public interface IHtmlTag : IHtmlNode
{
    HtmlTag ToTag();
}

public abstract record DistinctTag : IHtmlTag
{
    public string ToHtml()
    {
        return this.ToTag().ToHtml();
    }

    public abstract HtmlTag ToTag();
}

public abstract class BaseTag : IHtmlTag
{
    public string ToHtml()
    {
        return this.ToTag().ToHtml();
    }

    public abstract HtmlTag ToTag();
}

public class HtmlTag : IHtmlNode, IHtmlTag
{
    public string Tag { get; set; } = string.Empty;
    public Dictionary<string, string> Attributes { get; set; } = new();
    public List<IHtmlNode> Children { get; set; } = new();

    public HtmlTag() { }

    public HtmlTag(string tag)
    {
        this.Tag = tag;
    }

    public HtmlTag ToTag()
    {
        return this;
    }

    public override string ToString()
    {
        StringBuilder builder = new StringBuilder();
        HtmlWriters.HtmlTag(builder, this);
        return builder.ToString();
    }

    public string ToHtml()
    {
        return this.ToString();
    }
}


public class HtmlText : IHtmlNode
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

    public string ToHtml()
    {
        return this.Text;
    }
}

public static class HtmlNodeExtensions
{
    public static TChild AddChild<TChild>(this HtmlTag tag, TChild child)
        where TChild : IHtmlNode
    {
        if (!tag.Children.Contains(child))
        {
            tag.Children.Add(child);
        }

        return child;
    }

    public static HtmlTag AddAttribute(this HtmlTag tag, string name, string value)
    {
        tag.Attributes[name] = value;
        return tag;
    }

    public static HtmlTag AddDiv(this HtmlTag tag)
    {
        return tag.AddChild(new DivTag());
    }

    public static HtmlTag AddSpan(this HtmlTag tag)
    {
        return tag.AddChild(new SpanTag());
    }

    public static void AddText(this HtmlTag tag, string text)
    {
        tag.AddChild(new HtmlText(text));
    }

    public static HtmlTag AddTextSpan(this HtmlTag tag, string text, string cssClass = "")
    {
        var span = tag.AddSpan().AddClass(cssClass);
        span.AddText(text);
        return span;
    }

    public static HtmlTag AddInlineStyle(this HtmlTag tag, string property, string value)
    {
        value = value.Trim().TrimEnd(';');
        tag.AppendToAttribute("style", $" {property}: {value};");
        return tag;
    }

    public static T AddClass<T>(this T htmlTag, string className)
        where T : HtmlTag
    {
        htmlTag.AppendToAttribute("class", " " + className);
        return htmlTag;
    }

    private static void AppendToAttribute(this HtmlTag htmlTag, string attributeName, string value)
    {
        if (!htmlTag.Attributes.ContainsKey(attributeName))
        {
            htmlTag.Attributes.Add(attributeName, value);
        }
        else
        {
            htmlTag.Attributes[attributeName] += value;
        }
    }
}