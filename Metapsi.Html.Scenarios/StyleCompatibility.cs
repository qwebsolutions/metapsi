using Metapsi.Hyperapp;
using Metapsi.Syntax;

namespace Metapsi.Html.Scenarios;

public static class StyleCompatibility
{
    public static void SetStickyHeaderStyle(this IHtmlAttributesBuilder b)
    {
        b.AddStyle("position", "sticky");
        b.AddStyle("top", "0");
        b.AddStyle("z-index", "10000");
        b.AddStyle("color", "yellow");
        b.SetAttribute("href", "#");
    }

    private static Var<IVNode> ClientSideInlineStyle(LayoutBuilder b)
    {
        return b.HtmlDiv(
            b =>
            {
                //b.AddStyle("color", "red");
                b.SetStickyHeaderStyle();
            },
            b.Text("Client side"));
    }

    private static IHtmlNode ServerSideInlineStyle(HtmlBuilder b)
    {
        return b.HtmlDiv(
            b =>
            {
                b.SetStickyHeaderStyle();
                //b.SetStyle("color:red");
                //b.AddStyle("color", "red");
                b.AddStyle("font-weight", "700");
                //b.AddStyle("color", "red");
            },
            b.Text("Server side"));
    }

    public static HtmlDocument CompatibilityScenario()
    {
        return HtmlBuilder.FromDefault(
            b =>
            {
                b.BodyAppend(b.Text("WORKS!"));
                b.BodyAppend(
                    ServerSideInlineStyle(b));
                b.BodyAppend(
                    b.Hyperapp(
                        new object(),
                        (b, model) =>
                        {
                            return ClientSideInlineStyle(b);
                        }));
            });
    }
}
