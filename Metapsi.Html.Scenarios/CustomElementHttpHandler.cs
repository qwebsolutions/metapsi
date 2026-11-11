using Metapsi;
using Metapsi.Html;
using Metapsi.Syntax;
using Metapsi.Web;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Metapsi.Html.Scenarios;

public static partial class Scenario
{
    public static ICustomElement CustomElementWithExplicitHttpHandler()
    {
        var tagName = "custom-element-http-handler";

        var buildModule =
            (ModuleBuilder b) =>
            {
                b.Call(
                    b =>
                    {
                        b.DefineCustomElement(
                            tagName,
                            (b, element) =>
                            {
                                b.Set(element, x => x.innerHTML, "<i>THIS</i> IS THE <b>INNER</b> HTML of a custom element");
                            });
                    });
            };

        return new CustomElement(tagName, buildModule);
    }

    public static ICustomElement InlineCustomElement()
    {
        return new CustomElement("inline-custom-element", b =>
        {
            b.Call(
                b =>
                {
                    b.DefineCustomElement("inline-custom-element",
                        (b, element) =>
                        {
                            b.Set(element, x => x.innerHTML, "THIS IS AN <B> INLINE! </B> CUSTOM ELEMENT");
                        });
                });
        });
    }

    public static async Task CustomElementHttpHandler(this HttpContext httpContext)
    {
        var module = ModuleBuilder.New(null, null, CustomElementWithExplicitHttpHandler().BuildModule);

        httpContext.Response.Headers["Cache-Control"] = "public,max-age=31536000"; // Cache for 1 year
        await httpContext.WriteJsModuleResponse(module);
    }
}
