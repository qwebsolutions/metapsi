using Metapsi.Syntax;

namespace Metapsi.Shoelace;

public class Breadcrumb
{

}

public class BreadcrumbItem
{
    public string Href { get; set; } = string.Empty;

    public string Target { get; set; } = string.Empty;
}

public static partial class Control
{
    public static Var<HyperNode> Breadcrumb(this BlockBuilder b)
    {
        return b.Node("sl-breadcrumb");
    }

    public static Var<HyperNode> BreadcrumbHrefItem(this BlockBuilder b, Var<BreadcrumbItem> props)
    {
        var item = b.Node("sl-breadcrumb-item");

        var href = b.Get(props, x => x.Href);
        var target = b.Get(props, x => x.Target);

        b.If(b.HasValue(href), b => b.SetAttr(item, new DynamicProperty<string>("href"), href));
        b.If(b.HasValue(target), b => b.SetAttr(item, new DynamicProperty<string>("target"), target));

        return item;
    }

    public static Var<HyperNode> BreadcrumbHrefItem(this BlockBuilder b, Var<string> label, Var<string> href)
    {
        var item = b.BreadcrumbHrefItem(b.NewObj<BreadcrumbItem>(
            b => b.Set(x => x.Href, href)));
        b.Add(item, b.TextNode(label));
        return item;
    }

    public static Var<HyperNode> BreadcrumbButtonItem(this BlockBuilder b, Var<string> label)
    {
        var item = b.Node("sl-breadcrumb-item");
        b.Add(item, b.TextNode(label));
        return item;
    }
}