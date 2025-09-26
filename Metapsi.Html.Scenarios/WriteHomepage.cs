using Metapsi;
using Metapsi.Html;
using Metapsi.Syntax;
using Metapsi.Web;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

public static partial class Scenario
{
    public static async Task WriteHomepage(
        HttpContext httpContext,
        ICustomElement customHttpHandlerElement)
    {
        var pageResultEndpointUrl = httpContext.GetEndpointUrl("page-result");
        var customElementUrl = httpContext.GetEndpointUrl("custom-element-http-handler");

        ToHtmlOptions options = new ToHtmlOptions()
        {
            ResolveResource = (document, resource) =>
            {
                if (resource.LogicalName.Contains("http"))
                {
                    return customElementUrl;
                }
                return resource.GetDefaultHttpPath();
            }
        };

        await httpContext.WriteHtmlDocumentResponse(HtmlBuilder.FromEmpty(
            b =>
            {
                b.HeadAppend(b.HtmlTitle("Metapsi Playground"));
                b.HeadAppend(b.HtmlStyle(b.Text("body { font-family : arial }")));

                b.BodyAppend(
                    b.HtmlDiv(
                        b =>
                        {
                            b.SetStyle("display: flex; flex-direction:row; font-family : arial; font-weight: 600; font-size: 24px; padding: 24px; background-color: #eee; color:#777; justify-content:center");
                        },
                        b.Text("Metapsi Playground")));

                b.BodyAppend(
                    b.HtmlA(
                        b =>
                        {
                            b.SetHref(pageResultEndpointUrl);
                        },
                        b.Text("Go to page returned by Page.Result")));

                b.BodyAppend(b.HtmlDiv(
                    b =>
                    {
                        b.SetStyle("border: 1px solid grey");
                    },
                    b.Text("This one is explicitly added"),
                    b.Tag("custom-element-http-handler")));

                b.BodyAppend(
                    b.HtmlDiv(
                    b =>
                    {
                        b.SetStyle("border: 1px solid grey");
                    },
                    b.Text("This one is added with b.CustomElement"),
                    b.HtmlDiv(b.CustomElement(customHttpHandlerElement))));

                b.BodyAppend(
                    b.HtmlDiv(
                        b.HtmlScript(
                            b=>
                            {
                                b.SetTypeModule();
                            },
                            b.Text(Scenario.InlineCustomElement().Module.ToJs()))),
                    b.Tag(Scenario.InlineCustomElement().Tag));
            }), options);
    }

    public static IHtmlNode CustomElement(this HtmlBuilder b, ICustomElement customElement)
    {
        //b.Document.Metadata.AddRequiredTagMetadata(new HtmlTag("script")
        //{
        //    Attributes = new System.Collections.Generic.Dictionary<string, HtmlAttribute>()
        //    {
        //        { "type", new HtmlAttribute(){Value = "module" } },
        //        {
        //            "src",
        //            new HtmlAttribute()
        //            {
        //                ResourceMetadata = new ResourceMetadata()
        //                {
        //                    LogicalName = $"{customElement.Tag}.js"
        //                }
        //            }
        //        }
        //    }
        //});

        b.HeadAppend(new HtmlNode()
        {
            Tags = new System.Collections.Generic.List<HtmlTag>()
            {
                new HtmlTag("script")
                {
                    Attributes = new System.Collections.Generic.Dictionary<string, HtmlAttribute>()
                    {
                        { "type", new HtmlAttribute(){Value = "module" } },
                        {
                            "src",
                            new HtmlAttribute()
                            {
                                ResourceMetadata = new ResourceMetadata()
                                {
                                    LogicalName = $"{customElement.Tag}.js"
                                }
                            }
                        }
                    }
            }
        }
        });
        return b.Tag(customElement.Tag);
    }
}
