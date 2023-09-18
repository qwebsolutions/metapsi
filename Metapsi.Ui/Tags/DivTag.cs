namespace Metapsi.Ui;

public class DivTag : HtmlTag
{
    public DivTag()
    {
        this.Tag = "div";
    }

    public static DivTag Create(string css, params IHtmlNode[] nodes)
    {
        var div = new DivTag().AddClass(css);
        div.AddChildren(nodes);
        return div;
    }
}
