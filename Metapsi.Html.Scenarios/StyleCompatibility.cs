using Metapsi.Hyperapp;
using Metapsi.Syntax;

namespace Metapsi.Html.Scenarios;

public static class StyleCompatibility
{
    private static Var<IVNode> ClientSideInlineStyle(LayoutBuilder b)
    {
        return b.HtmlDiv(
            b =>
            {
                b.AddStyle("color", "red");
            },
            b.Text("Client side"));
    }

    private static IHtmlNode ServerSideInlineStyle(HtmlBuilder b)
    {
        return b.HtmlDiv(
            b =>
            {
                //b.SetStyle("color:red");
                b.AddStyle("color", "red");
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
