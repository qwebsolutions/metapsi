using System;

namespace Metapsi.Ui;

public abstract class HtmlComponent : IHtmlComponent, IHtmlElement
{
    public HtmlComponent(string tagName)
    {
        this.HtmlTag = new HtmlTag(tagName);
    }

    public HtmlTag HtmlTag { get; set; }

    protected bool Attached { get; set; }

    void IHtmlComponent.Attach(DocumentTag document, IHtmlElement parentNode)
    {
        if (!this.Attached)
        {
            OnAttach(document, parentNode);
            Attached = true;
        }
    }

    protected abstract void OnAttach(DocumentTag documentTag, IHtmlElement parentNode);

    public HtmlTag GetTag()
    {
        return this.HtmlTag;
    }

    string IHtmlNode.ToHtml()
    {
        return this.GetTag().ToHtml();
    }
}

public class PageBuilder<TModel>
{
}

public interface IControlProps
{

}

public static class PageBuilderExtensions
{
    public static T Server<T>(this PageBuilder<T> builder, Action<T> buildProps) where T : IControlProps, new()
    {
        var props = new T();
        buildProps(props);
        return props;
    }
}