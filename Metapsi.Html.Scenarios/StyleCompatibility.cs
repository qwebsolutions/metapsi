using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using static Metapsi.Html.Scenarios.Program;

namespace Metapsi.Html.Scenarios;


//public class DynamicStyleSheet
//{
//    public class Block
//    {
//        public string Selector { get; set; }
//        public string Content { get; set; }
//    }

//    public DynamicStyleSheet AddSelector(
//        string name, 
//        System.Action<IStyleBuilder> style)
//    {
//        return this;
//    }

//    public DynamicStyleSheet AddSelector(
//        string name,

//        )
//}

public static class StyleCompatibility
{


    public static string GenerateCss(
        System.Action<IStyleBuilder> setHoverStyle)
    {
        var builder = new AttributesBuilder<HtmlDiv>();
        setHoverStyle(builder);
        return builder.Attributes["style"];
    }

    //public static IHtmlNode HtmlStyleSheet(
    //    this HtmlBuilder b,
    //    System.Action<IStyleBuilder> setHoverStyle)
    //{
    //    var styleBuilder = new DynamicStyleBuilder();
    //    setHoverStyle(styleBuilder);
    //    return b.HtmlStyle(b.Text(
    //        styleBuilder.GenerateClass("div:hover")));
    //}


    public static IHtmlNode AddParticularStyleSheet(
        this HtmlBuilder b)
    {
        return b.HtmlStyleSheet(
            b =>
            {
                b.AddRule("div:hover", b =>
                {
                    b.AddStyle("color", "red");
                });
                b.AddRule(
                    "@media (max-width: 600px)",
                    b =>
                    {
                        b.AddRule("div",
                            b =>
                            {
                                b.AddStyle("color", "blue");
                            });
                    });
            });
    }


    public static void SetStickyHeaderStyle(this IHtmlAttributesBuilder b)
    {
        b.AddStyle("position", "sticky");
        b.AddStyle("top", "0");
        b.AddStyle("z-index", "10000");
        //b.AddStyle("color", "yellow");
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
                b.HeadAppend(b.AddParticularStyleSheet());
                b.BodyAppend(b.Text("WORKS!"));
                b.BodyAppend(
                    ServerSideInlineStyle(b));
                b.HeadAppend(b.HtmlStyleSheet(
                    b =>
                    {
                        b.AddStyle("color", "red");
                        b.AddStyle("font-weight", "700");
                    }));
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
