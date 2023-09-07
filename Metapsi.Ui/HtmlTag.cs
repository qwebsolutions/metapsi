using System;
using System.Collections.Generic;
using System.Linq;
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

    public static IEnumerable<IHtmlNode> Descendants(this IHtmlTag root)
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
                (child as IHtmlComponent).OnMount(document, parent);
            }
        });
    }

    //private static void FillDescendants(IHtmlTag current, List<IHtmlNode> intoList)
    //{
    //    intoList.Add(current);
    //    var children = current.ToTag().Children;
    //    foreach (var child in children)
    //    {
    //        IHtmlTag childTag = child as IHtmlTag;
    //        if (childTag != null)
    //        {
    //            FillDescendants(childTag, intoList);
    //        }
    //        else
    //        {
    //            IHtmlComponent htmlComponent = child as IHtmlComponent;
    //            if (htmlComponent != null)
    //            {
    //                intoList.Add(child);
    //            }
    //        }
    //    }
    //}

    public static void Traverse(this IHtmlTag current, Action<IHtmlTag, IHtmlNode> onNode)
    {
        // copy list because some operations could modify it
        var children = new List<IHtmlNode>(current.ToTag().Children);
        foreach (var child in children)
        {
            switch (child)
            {
                case IHtmlTag childTag:
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

    public static IHtmlNode GetDescendantById(this IHtmlTag root, string id)
    {
        var node = root.Descendants().Where(x => x is HtmlTag).Cast<HtmlTag>().Where(x => x != null).Where(x => x.Attributes.ContainsKey("id")).SingleOrDefault(x => x.Attributes["id"] == id);
        return node;
    }

    public static void RemoveById(this IHtmlTag root, string id)
    {
        var node = root.GetDescendantById(id);
        if (node != null)
        {
            var parent = root.Descendants().Where(x => x is HtmlTag).Cast<HtmlTag>().Where(x => x != null).SingleOrDefault(x => x.Children.Any(x => x.HasAttribute("id", id)));
            parent.Children.Remove(node);
        }
    }

    public static void ReplaceById(this IHtmlTag root, string id, IHtmlNode replacementNode)
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

    //public static IEnumerable<T> OfType<T>(this IEnumerable<IHtmlNode> nodes)
    //{
    //    return nodes.Where(x => x is T).Select(x => (T)x);
    //}
}
