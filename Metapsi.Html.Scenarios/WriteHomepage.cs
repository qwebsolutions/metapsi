using Metapsi;
using Metapsi.Html;
using Metapsi.Hyperapp;
using Metapsi.Ionic;
using Metapsi.Syntax;
using Metapsi.Web;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Metapsi.Html.Scenarios;

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
                b.HeadAppend(b.HtmlStyle(b.Text("body { font-family : arial; display: flex; flex-direction: column; gap:20px; }")));

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

                //b.BodyAppend(
                //    b.HtmlDiv(
                //    b =>
                //    {
                //        b.SetStyle("border: 1px solid grey");
                //    },
                //    b.Text("This one is added with b.CustomElement"),
                //    b.HtmlDiv(b.ResolvedCustomElement(customHttpHandlerElement))));
                b.BodyAppend(
                    b.IonButton());
                //b.BodyAppend(
                //    b.HtmlDiv(
                //        b.HtmlScript(
                //            b=>
                //            {
                //                b.SetTypeModule();
                //            },
                //            b.Text(Scenario.InlineCustomElement().Module.ToJs()))),
                //    b.Tag(Scenario.InlineCustomElement().Tag));
                b.BodyAppend(
                    b.MediaLoader(
                        b=>
                        {
                            b.SetSrc("http://localhost:5000/test-svg.svg");
                        }));
                b.BodyAppend(
                    b.Hyperapp(new object(),
                        (b, model) =>
                        {
                            b.Log("From hyperapp renderer");
                            return b.MediaLoader(
                                b =>
                                {
                                    b.Set(x => x.Src, "https://shoelace.style/assets/images/wordmark.svg");
                                },
                                b.HtmlDiv(
                                    b=>
                                    {
                                        b.SetSlot("before");
                                    },
                                    b.Text("Before text")),
                                b.HtmlDiv(
                                    b =>
                                    {
                                        b.SetSlot("after");
                                    },
                                    b.Text("After text"))
                                );
                        }));

                    //b.InlineCustomElement<MediaLoader.Props>(
                    //    new MediaLoader(),
                    //    b=>
                    //    {
                    //        //b.SetAttribute("Url", "https://shoelace.style/assets/images-/wordmark.svg");
                    //        b.SetAttribute("Url", "http://localhost:5000/test-svg.svg");
                    //    }));
                    
                b.BodyAppend(b.WebComponentsFadeInScript());
            }), options);
    }

}
