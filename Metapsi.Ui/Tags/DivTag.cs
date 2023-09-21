namespace Metapsi.Ui;

public class DivTag : HtmlTag
{
    public DivTag()
    {
        this.Tag = "div";
    }

    public static DivTag CreateStyled(string css, params IHtmlNode[] nodes)
    {
        var div = new DivTag().WithClass(css);
        div.AddChildren(nodes);
        return div;
    }

    public static DivTag Create(params IHtmlNode[] nodes)
    {
        var div = new DivTag();
        div.AddChildren(nodes);
        return div;
    }
}
