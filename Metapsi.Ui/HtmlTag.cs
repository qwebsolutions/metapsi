using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;

namespace Metapsi.Ui;

/// <summary>
/// A node is any html content on the page, both tags & text
/// </summary>
public interface IHtmlNode
{
    public string ToHtml();
}

/// <summary>
/// An element is a tag that can have descendants
/// </summary>
public interface IHtmlElement : IHtmlNode
{
    HtmlTag GetTag();
}

public abstract record DistinctTag : IHtmlElement
{
    public string ToHtml()
    {
        return this.GetTag().ToHtml();
    }

    public abstract HtmlTag GetTag();
}

public abstract class BaseTag : IHtmlElement
{
    public string ToHtml()
    {
        return this.GetTag().ToHtml();
    }

    public abstract HtmlTag GetTag();
}

public class HtmlTag : IHtmlElement
{
    public string Tag { get; set; } = string.Empty;
    public Dictionary<string, string> Attributes { get; set; } = new();
    public List<IHtmlNode> Children { get; set; } = new();

    public HtmlTag() { }

    public HtmlTag(string tag)
    {
        this.Tag = tag;
    }

    public HtmlTag GetTag()
    {
        return this;
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

        // Do not append children, as this would make for
        // a bad debug experience, especially when investigating 
        // infinitely recursive children

        builder.AppendLine($"</{this.Tag}>");

        return builder.ToString();
    }

    public string ToHtml()
    {
        StringBuilder builder = new StringBuilder();

        builder.Append($"<{this.Tag}");
        foreach (var attribute in this.Attributes)
        {
            builder.Append($" {attribute.Key}=\"{attribute.Value}\"");
        }
        builder.Append(">");
        foreach (var child in this.Children)
        {
            builder.AppendLine(child.ToHtml());
        }
        builder.AppendLine($"</{this.Tag}>");

        return builder.ToString();
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

    public static HtmlText CreateTextNode(string text)
    {
        return new HtmlText(text);
    }

    public static SpanTag Create(string text)
    {
        return SpanTag.Create(HtmlText.CreateTextNode(text));
    }
}

public static class HtmlNodeExtensions
{
    public static TChild AddChild<TChild>(this IHtmlElement parent, TChild child)
        where TChild : IHtmlNode
    {
        if (!parent.GetTag().Children.Contains(child))
        {
            parent.GetTag().Children.Add(child);
        }

        return child;
    }

    public static TParent WithChild<TParent, TChild>(this TParent parent, TChild child)
        where TParent: IHtmlElement
        where TChild : IHtmlNode
    {
        if (!parent.GetTag().Children.Contains(child))
        {
            parent.GetTag().Children.Add(child);
        }

        return parent;
    }

    public static void AddChildren(this IHtmlElement parent, IEnumerable<IHtmlNode> children)
    {
        foreach(var child in children)
        {
            parent.AddChild(child);
        }
    }

    public static T SetAttribute<T>(this T element, string name, string value)
        where T : IHtmlElement
    {
        element.GetTag().Attributes[name] = value;
        return element;
    }

    public static HtmlTag AddDiv(this IHtmlElement element)
    {
        return element.AddChild(new DivTag());
    }

    public static HtmlTag AddSpan(this IHtmlElement element)
    {
        return element.AddChild(new SpanTag());
    }

    public static void AddText(this IHtmlElement element, string text)
    {
        element.AddChild(new HtmlText(text));
    }

    public static HtmlTag AddTextSpan(this IHtmlElement element, string text, string cssClass = "")
    {
        var span = element.AddSpan().WithClass(cssClass);
        span.AddText(text);
        return span;
    }

    public static T WithStyle<T>(this T element, string property, string value)
        where T: IHtmlElement
    {
        value = value.Trim().TrimEnd(';');
        element.AppendToAttribute("style", $" {property}: {value};");
        return element;
    }

    public static T WithClass<T>(this T element, string className)
        where T : HtmlTag
    {
        element.AppendToAttribute("class", " " + className);
        return element;
    }

    private static void AppendToAttribute(this IHtmlElement element, string attributeName, string value)
    {
        var htmlTag = element.GetTag();

        if (!htmlTag.Attributes.ContainsKey(attributeName))
        {
            htmlTag.Attributes.Add(attributeName, value);
        }
        else
        {
            htmlTag.Attributes[attributeName] += value;
        }
    }

    public static IEnumerable<IHtmlNode> Descendants(this IHtmlElement root)
    {
        List<IHtmlNode> descendants = new List<IHtmlNode>();

        Traverse(root, (parent, child) =>
        {
            descendants.Add(child);
        });

        return descendants;
    }

    public static void AttachComponents(this DocumentTag document)
    {
        Traverse(document, (parent, child) =>
        {
            if (child is IHtmlComponent)
            {
                (child as IHtmlComponent).Attach(document, parent);
            }
        });
    }

    public static void Traverse(this IHtmlElement current, Action<IHtmlElement, IHtmlNode> onNode)
    {
        // copy list because some operations could modify it
        var children = new List<IHtmlNode>(current.GetTag().Children);
        foreach (var child in children)
        {
            switch (child)
            {
                case IHtmlElement childTag:
                    onNode(current, child);
                    Traverse(childTag, onNode);
                    break;
                case IHtmlComponent childComponent:
                    onNode(current, child);
                    break;
                case HtmlText childText:
                    onNode(current, child);
                    break;
            }
        }
    }

    public static IHtmlNode GetDescendantById(this IHtmlElement root, string id)
    {
        var node = root.Descendants().Where(x => x is HtmlTag).Cast<HtmlTag>().Where(x => x != null).Where(x => x.Attributes.ContainsKey("id")).SingleOrDefault(x => x.Attributes["id"] == id);
        return node;
    }

    public static void RemoveById(this IHtmlElement root, string id)
    {
        var node = root.GetDescendantById(id);
        if (node != null)
        {
            var parent = root.Descendants().Where(x => x is HtmlTag).Cast<HtmlTag>().Where(x => x != null).SingleOrDefault(x => x.Children.Any(x => x.HasAttribute("id", id)));
            parent.Children.Remove(node);
        }
    }

    public static void ReplaceById(this IHtmlElement root, string id, IHtmlNode replacementNode)
    {
        var node = root.GetDescendantById(id);
        if (node != null)
        {
            var parent = root.Descendants().Where(x => x is HtmlTag).Cast<HtmlTag>().Where(x => x != null).SingleOrDefault(x => x.Children.Any(x => x.HasAttribute("id", id)));
            var index = parent.Children.IndexOf(node);
            parent.Children[index] = replacementNode;
        }
    }

    public static bool HasAttribute(this HtmlTag tag, string attributeName, string attributeValue)
    {
        if (!tag.Attributes.ContainsKey(attributeName))
            return false;

        return tag.Attributes[attributeName] == attributeValue;
    }

    public static bool HasAttribute(this IHtmlNode node, string attributeName, string attributeValue)
    {
        if (!(node is HtmlTag))
            return false;

        return (node as HtmlTag).HasAttribute(attributeName, attributeValue);
    }
}
