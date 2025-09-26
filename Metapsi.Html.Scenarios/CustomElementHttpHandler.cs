using Metapsi;
using Metapsi.Html;
using Metapsi.Syntax;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

public static partial class Scenario
{
    public static ICustomElement CustomElementWithExplicitHttpHandler()
    {
        var tagName = "custom-element-http-handler";

        var module = ModuleBuilder.New(
            b =>
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
            });

        return new CustomElement()
        {
            Tag = tagName,
            Module = module
        };
    }

    public static ICustomElement InlineCustomElement()
    {
        return new CustomElement()
        {
            Tag = "inline-custom-element",
            Module = ModuleBuilder.New(
                b =>
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
                })
        };
    }

    public static async Task CustomElementHttpHandler(this HttpContext httpContext)
    {
        httpContext.Response.Headers["Cache-Control"] = "public,max-age=31536000"; // Cache for 1 year
        await httpContext.WriteJsModule(CustomElementWithExplicitHttpHandler().Module);
    }
}
