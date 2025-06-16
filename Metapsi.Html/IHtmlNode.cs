using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Text;

namespace Metapsi.Html;

/// <summary>
/// A node is any html content on the page, both tags & text
/// </summary>
public interface IHtmlNode
{
    string ToHtml();
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

public class HtmlTag : IHtmlNode
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

    public virtual string ToHtml()
    {
        StringBuilder builder = new StringBuilder();

        builder.Append($"<{this.Tag}");
        foreach (var attribute in this.Attributes)
        {
            builder.Append($" {attribute.Key}=\"{attribute.Value}\"");
        }
        builder.Append(">");

        if (!SelfClosing.Tags.Contains(this.Tag))
        {
            foreach (var child in this.Children)
            {
                builder.Append(child.ToHtml());
            }
            builder.Append($"</{this.Tag}>");
        }

        return builder.ToString();
    }
}

//public class DistinctTag : HtmlTag, IEquatable<DistinctTag>
//{
//    public DistinctTag() { }

//    public DistinctTag(string tag) : base(tag)
//    {

//    }

//    public DistinctTag(HtmlTag tag)
//    {
//        this.Tag = tag.Tag;
//        this.Attributes = new Dictionary<string, string>(tag.Attributes);
//        this.Children = new List<IHtmlNode>(tag.Children);
//    }

//    public bool Equals(DistinctTag other)
//    {
//        return HtmlNodeComparer.HtmlTagEquals(this, other);
//    }

//    public override bool Equals(object obj)
//    {
//        if (obj == null) return false;
//        return this.Equals(obj as DistinctTag);
//    }

//    public override int GetHashCode()
//    {
//        return HashCode.Combine(this.ToHtml());
//    }

//    public static DistinctTag New<T>(string tagName, Action<AttributesBuilder<T>> buildAttributes, params IHtmlNode[] children)
//    {
//        DistinctTag tag = new DistinctTag(tagName);
//        buildAttributes(new AttributesBuilder<T>() { Attributes = tag.Attributes });
//        tag.Children.AddRange(children);
//        return tag;
//    }

//    public static DistinctTag New<T>(string tagName, params IHtmlNode[] children)
//    {
//        DistinctTag tag = new DistinctTag(tagName);
//        tag.Children.AddRange(children);
//        return tag;
//    }
//}

public class HtmlNodeComparer : IEqualityComparer<IHtmlNode>
{
    public bool Equals(IHtmlNode x, IHtmlNode y)
    {
        if (ReferenceEquals(x, y)) return true;

        if (x == null && y != null) return false;
        if (y == null && x != null) return false;

        if (x.GetType() != y.GetType()) return false;

        if (x is HtmlText)
        {
            return HtmlTextEquals(x as HtmlText, y as HtmlText);
        }

        if (x is HtmlTag)
        {
            return HtmlTagEquals(x as HtmlTag, y as HtmlTag);
        }

        return x.Equals(y);
    }

    public int GetHashCode(/*[DisallowNull]*/ IHtmlNode obj)
    {
        return obj.GetHashCode();
    }

    public static bool HtmlTextEquals(HtmlText first, HtmlText second)
    {
        if (first == null && second == null) return true;

        if (first == null) return false;
        if (second == null) return false;

        return first.Text == second.Text;
    }

    public static bool HtmlTagEquals(HtmlTag first, HtmlTag second)
    {
        if (first == null && second == null) return true;

        if (first == null) return false;
        if (second == null) return false;
        if (first.Tag != second.Tag) return false;

        if (first.Attributes == second.Attributes && first.Children == second.Children) return true;

        return first.ToHtml() == second.ToHtml();
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
    public static void AddChild<TChild>(this HtmlTag parent, TChild child)
        where TChild : IHtmlNode
    {
        if (!parent.Children.Contains(child))
        {
            parent.Children.Add(child);
        }
    }

    public static string GetAttribute(this HtmlTag element, string name)
    {
        element.Attributes.TryGetValue(name, out var value);
        return value;
    }

    public static void SetAttribute(this HtmlTag element, string name, string value)
    {
        element.Attributes[name] = value;
    }

    //public static HtmlTag AddDiv(this IHtmlElement element)
    //{
    //    return element.AddChild(new DivTag());
    //}

    //public static HtmlTag AddSpan(this IHtmlElement element)
    //{
    //    return element.AddChild(new SpanTag());
    //}

    //public static void AddText(this IHtmlElement element, string text)
    //{
    //    element.AddChild(new HtmlText(text));
    //}

    //public static HtmlTag AddTextSpan(this IHtmlElement element, string text, string cssClass = "")
    //{
    //    var span = element.AddSpan().WithClass(cssClass);
    //    span.AddText(text);
    //    return span;
    //}

    //public static T WithStyle<T>(this T element, string property, string value)
    //    where T: IHtmlElement
    //{
    //    value = value.Trim().TrimEnd(';');
    //    element.AppendToAttribute("style", $" {property}: {value};");
    //    return element;
    //}

    //public static T WithClass<T>(this T element, string className)
    //    where T : HtmlTag
    //{
    //    element.AppendToAttribute("class", " " + className);
    //    return element;
    //}

    //private static void AppendToAttribute(this IHtmlElement element, string attributeName, string value)
    //{
    //    var htmlTag = element.GetTag();

    //    if (!htmlTag.Attributes.ContainsKey(attributeName))
    //    {
    //        htmlTag.Attributes.Add(attributeName, value);
    //    }
    //    else
    //    {
    //        htmlTag.Attributes[attributeName] += value;
    //    }
    //}

    public static IEnumerable<IHtmlNode> Descendants(this HtmlTag root)
    {
        List<IHtmlNode> descendants = new List<IHtmlNode>();

        Traverse(root, (parent, child) =>
        {
            descendants.Add(child);
        });

        return descendants;
    }

    //public static void AttachComponents(this DocumentTag document)
    //{
    //    Traverse(document, (parent, child) =>
    //    {
    //        if (child is IHtmlComponent)
    //        {
    //            (child as IHtmlComponent).Attach(document, parent);
    //        }
    //    });
    //}

    public static void Traverse(this HtmlTag current, Action<IHtmlNode, IHtmlNode> onNode)
    {
        // copy list because some operations could modify it
        var children = new List<IHtmlNode>(current.Children);
        foreach (var child in children)
        {
            switch (child)
            {
                case HtmlTag childTag:
                    onNode(current, child);
                    Traverse(childTag, onNode);
                    break;
                case HtmlText childText:
                    onNode(current, child);
                    break;
            }
        }
    }

    public static IHtmlNode GetDescendantById(this HtmlTag root, string id)
    {
        var node = root.Descendants().Where(x => x is HtmlTag).Cast<HtmlTag>().Where(x => x != null).Where(x => x.Attributes.ContainsKey("id")).SingleOrDefault(x => x.Attributes["id"] == id);
        return node;
    }

    public static void RemoveById(this HtmlTag root, string id)
    {
        var node = root.GetDescendantById(id);
        if (node != null)
        {
            var parent = root.Descendants().Where(x => x is HtmlTag).Cast<HtmlTag>().Where(x => x != null).SingleOrDefault(x => x.Children.Any(x => x.HasAttribute("id", id)));
            parent.Children.Remove(node);
        }
    }

    public static void ReplaceById(this HtmlTag root, string id, IHtmlNode replacementNode)
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
