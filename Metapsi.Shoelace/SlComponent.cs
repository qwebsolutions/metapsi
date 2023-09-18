using Metapsi.Ui;
using System;
using System.Linq;

namespace Metapsi.Shoelace;

public abstract class SlComponent : IHtmlComponent, IHtmlElement
{
    private HtmlTag htmlTag;

    public SlComponent(string slTag)
    {
        this.htmlTag = new HtmlTag(slTag);
    }

    private bool Attached { get; set; }

    public void Attach(DocumentTag document, IHtmlElement parentNode)
    {
        if (!this.Attached)
        {
            OnAttach(document, parentNode);
            Attached = true;
        }
    }

    public void OnAttach(DocumentTag document, IHtmlElement parentNode)
    {
        document.StartHidden();

        document.Head.AddChild(new ExternalScriptTag("https://cdn.jsdelivr.net/npm/@shoelace-style/shoelace@2.6.0/cdn/shoelace-autoloader.js", "module"));
        document.Head.AddChild(new LinkTag("stylesheet", "https://cdn.jsdelivr.net/npm/@shoelace-style/shoelace@2.6.0/cdn/themes/light.css"));

        var slAwaitScript = document.Head.Children.OfType<SlAwaitScript>().SingleOrDefault();
        if (slAwaitScript == null)
        {
            slAwaitScript = document.Head.AddChild(new SlAwaitScript());
        }
        slAwaitScript.SlTags.Add(this.htmlTag.Tag);
    }

    public string ToHtml()
    {
        return this.GetTag().ToHtml();
    }

    public HtmlTag GetTag()
    {
        var publicProperties = this.GetType().GetProperties();

        foreach (var property in publicProperties)
        {
            var propertyValue = property.GetValue(this);

            if (propertyValue != null)
            {
                var attributeName = ToCamelCase(property.Name);

                if (property.PropertyType == typeof(string))
                {
                    this.htmlTag.SetAttribute(attributeName, propertyValue.ToString());
                }

                if (property.PropertyType == typeof(bool))
                {
                    if (Convert.ToBoolean(propertyValue))
                    {
                        this.htmlTag.SetAttribute(attributeName, "true");
                    }
                }

                if (property.PropertyType.IsEnum)
                {
                    this.htmlTag.SetAttribute(attributeName, System.Enum.GetName(property.PropertyType, propertyValue).ToLower());
                }
            }
        }

        return this.htmlTag;
    }

    public static string ToCamelCase(string s)
    {
        return s.Length == 1 ? s.ToLowerInvariant() : s.Substring(0, 1).ToLowerInvariant() + s.Substring(1);
    }
}
