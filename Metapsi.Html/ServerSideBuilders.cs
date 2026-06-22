using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Metapsi.Html;

public abstract class DocumentTemplate
{
    public IHtmlNode Render() {  return null; }

    public abstract void SetHtmlAttributes(AttributesBuilder<HtmlHtml> b);
    public abstract IHtmlNode BuildBody(AttributesBuilder<HtmlBody> b, params IHtmlNode[] children);
}

public class ServerVar<T> : Var<T>
{
    public ServerVar(T value)
    {
        this.ServerSideValue = value;
    }
    public T ServerSideValue { get; private set; }
}

public class AttributesBuilder : IHtmlPropsBuilder
{
    public Dictionary<string, string> Styles { get; set; } = new Dictionary<string, string>();
    public HtmlAttributes _attributes { get; set; } = new();

    public void AddClass(string className)
    {
        string previousClass = "";
        if (this._attributes.ContainsKey("class"))
        {
            previousClass = this._attributes["class"];
        }

        this.SetAttribute("class", previousClass + " " + className);
    }

    public void AddStyle(string property, string value)
    {
        this.Styles[property] = value;
        this._attributes["style"] = string.Join(";", this.Styles.Select(x => $"{x.Key}:{x.Value}"));
    }

    public void AddStyle(string property, Var<string> value)
    {
        this.AddStyle(property, (value as ServerVar<string>).ServerSideValue);
    }

    public IHtmlPropsBuilder<TElement> ForElement<TElement>()
    {
        return new AttributesBuilder<TElement>()
        {
        };
    }

    /// <summary>
    /// Sets attribute to value
    /// </summary>
    /// <param name="attributeName"></param>
    /// <param name="attributeValue"></param>
    public void SetAttribute(string attributeName, string attributeValue)
    {
        this._attributes[attributeName] = attributeValue;
    }

    /// <summary>
    /// Boolean attribute, has no value (is set if it exists)
    /// </summary>
    /// <typeparam name="TTag"></typeparam>
    /// <param name="b"></param>
    /// <param name="attributeName"></param>
    public void SetAttribute(string attributeName)
    {
        this._attributes[attributeName] = "";
    }

    public void MergeAttributes(IHtmlProps htmlAttributes)
    {
        var newAttributes = htmlAttributes as HtmlAttributes;
        foreach (var newAttribute in newAttributes)
        {
            this._attributes[newAttribute.Key] = newAttribute.Value;
        }
    }

    Syntax.Var<IHtmlProps> IHtmlPropsBuilder.GetProps()
    {
        return new ServerVar<IHtmlProps>(this._attributes);
    }
}

public class AttributesBuilder<TTag> : AttributesBuilder, IHtmlPropsBuilder<TTag>
{
}

public static class AttributesBuilderExtensions
{

    public static void SetClass<TTag>(this AttributesBuilder<TTag> b, string className)
    {
        b.SetAttribute("class", className);
    }

    public static void SetStyle<TTag>(this AttributesBuilder<TTag> b, string styles)
    {
        b.SetAttribute("style", styles);
    }
}