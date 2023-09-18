using System;

namespace Metapsi.Ui;

public abstract class HtmlComponent : IHtmlComponent
{
    protected bool Attached { get; set; }

    public void Attach(DocumentTag document, IHtmlElement parentNode)
    {
        if (!this.Attached)
        {
            OnAttach(document, parentNode);
            Attached = true;
        }
    }

    public abstract void OnAttach(DocumentTag documentTag, IHtmlElement parentNode);
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