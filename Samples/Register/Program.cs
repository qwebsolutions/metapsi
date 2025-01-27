using Metapsi.Html;
using Metapsi.Hyperapp;
using Metapsi.Shoelace;
using Metapsi.Syntax;
using Microsoft.AspNetCore.Builder;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Metapsi.Dev;

public static class LicenseExample
{
    public class Model
    {
        public string LicenseText { get; set; } = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor.";
        public bool Agreed { get; set; }
        public bool Complete { get; set; }
    }

    public static async Task Main()
    {
        var webApp = WebApplication.CreateBuilder().AddMetapsi().Build().UseMetapsi();
        webApp.MapServerActions();
        webApp.MapGet("/", () => Page.Result(new Model()));
        webApp.UseRenderer<Model>(
            model => 
            // Server side rendering starts here
            HtmlBuilder.FromDefault(
                b =>
                {
                    b.HeadAppend(b.HtmlTitle("Register for new account"));
                    // Tailwind Play CDN
                    b.AddScript("https://unpkg.com/@tailwindcss/browser@4");
                    b.BodyAppend(
                        b.HtmlDiv(
                            b =>
                            {
                                b.SetClass("flex flex-row flex-wrap");
                            },
                            b.RegisterForm(model)));
                                
                }).ToHtml());
        await webApp.RunAsync();
    }

    public static IHtmlNode RegisterForm(this HtmlBuilder b, Model model)
    {
        return b.HtmlDiv(
            b =>
            {
                b.SetClass("flex flex-col gap-8 rounded border border-sky-100 p-8 m-8 max-w-md");
            },
            b.SlTextarea(
                b =>
                {
                    b.SetReadonly();
                    b.SetValue(model.LicenseText);
                }),
            // 'Client-side' nodes are just HTML nodes like any other
            b.ClientSide(model));
    }

    public static IHtmlNode ClientSide(this HtmlBuilder b, Model model)
    {
        // Client-side rendering & actions are handled by Hyperapp
        return b.Hyperapp(
            model,
            (b, model) =>
            {
                return b.HtmlDiv(
                    b =>
                    {
                        b.SetClass("flex flex-col gap-8");
                    },
                    b.HtmlDiv(
                        b =>
                        {
                            b.SetClass("flex flex-row items-baseline justify-between");
                        },
                        b.SlCheckbox(
                            b =>
                            {
                                b.SetDisabled(b.Get(model, x => x.Complete));
                                b.SetSizeSmall();
                                b.BindTo(model, x => x.Agreed);
                            },
                            b.Text("I agree to the terms and conditions")),
                        b.SlButton(
                            b =>
                            {
                                // Client-side Linq
                                b.SetDisabled(b.Get(model, x => !x.Agreed || x.Complete));
                                b.OnClickAction(
                                    // Inline server-side call
                                    b.CallServer(async (Model model) =>
                                    {
                                        model.Complete = true;
                                        return model;
                                    }));
                            },
                            b.Text("Register"))),
                    b.Optional(
                        b.Get(model, x => x.Complete),
                        b => b.AfterRegisterMessage(model)));
            });
    }

    public static Var<IVNode> AfterRegisterMessage(this LayoutBuilder b, Var<Model> model)
    {
        return b.HtmlDiv(
            b =>
            {
                b.SetClass("flex flex-col gap-4 items-center bg-sky-200 rounded p-4");
            },
            b.HtmlDiv(
                b =>
                {
                    b.SetClass("text-gray-600 font-semibold text-lg");
                },
                b.Text("Thank you for registering")),
            b.HtmlA(
                b=>
                {
                    b.SetClass("underline text-sky-600 text-sm");
                    b.SetHref("/");
                },
                b.Text("Home")));
    }
}