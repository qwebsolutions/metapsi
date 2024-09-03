using Microsoft.AspNetCore.Builder;
using System.Threading.Tasks;
using Metapsi;
using System;
using Metapsi.Html;
using Metapsi.Syntax;
using Metapsi.Hyperapp;

public class DataModel
{
    public string Title { get; set; } = "Title";
    public string Message { get; set; } = "Hi! It works!";
}

public static class Program
{
    public static async Task Main()
    {
        var app = WebApplication.CreateBuilder().AddMetapsi().Build();
        app.UseMetapsi();
        app.MapGet("/", () => Page.Result(new DataModel()));
        app.UseRenderer<DataModel>(model => $"<html> <head><title>{model.Title}</title></head><body>{model.Message}</body></html>");

        app.UseRenderer<DataModel>(
            model => HtmlBuilder.FromDefault(
                b =>
                {
                    b.HeadAppend(b.HtmlTitle(model.Title));
                    b.BodyAppend(b.Text(model.Message));
                }).ToHtml());

        app.UseRenderer<DataModel>(
            model => HtmlBuilder.FromDefault(
            b =>
            {
                b.HeadAppend(b.HtmlTitle(model.Title));
                b.BodyAppend(b.HtmlScript($"alert('{model.Message}')"));
            }).ToHtml());

        app.UseRenderer<DataModel>(
            model => HtmlBuilder.FromDefault(
            b =>
            {
                b.HeadAppend(b.HtmlTitle(model.Title));
                b.BodyAppend(b.HtmlScriptModule(b =>
                {
                    b.Alert(model.Message);
                }));
            }).ToHtml());

        app.UseRenderer<DataModel>(
            model => HtmlBuilder.FromDefault(
            b =>
            {
                b.HeadAppend(b.HtmlTitle(model.Title));
                b.BodyAppend(b.HtmlButton(
                    b =>
                    {
                        b.SetId("click-me");
                        b.SetStyle("color:blue");
                    },
                    b.Text("Click me!")));
                b.BodyAppend(b.HtmlScriptModule(b =>
                {
                    b.SetProperty(
                        b.GetElementById("click-me"),
                        b.Const("onclick"),
                        b.Def((SyntaxBuilder b) =>
                        {
                            b.Alert(model.Message);
                        }));
                }));
            }).ToHtml());

        app.UseRenderer<DataModel>(
            model => HtmlBuilder.FromDefault(
            b =>
            {
                b.HeadAppend(b.HtmlTitle(model.Title));
                b.BodyAppend(
                    b.Hyperapp(
                        model,
                        (b, model) =>
                        {
                            return b.HtmlButton(
                                b =>
                                {
                                    b.AddStyle("color", "green");
                                    b.OnClickAction((SyntaxBuilder b, Var<DataModel> model) =>
                                    {
                                        b.Alert(b.Get(model, x => x.Message));
                                        b.Set(model, x => x.Message, b.Const("Already clicked!"));
                                        return b.Clone(model);
                                    });
                                },
                                b.Text("Click me!"));
                        }));
            }).ToHtml());

        await app.RunAsync();
    }
}