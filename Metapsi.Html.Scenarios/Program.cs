using Microsoft.AspNetCore.Builder;
using System.Threading.Tasks;
using Metapsi;
using System;
using Metapsi.Html;
using Metapsi.Syntax;
using Metapsi.Hyperapp;
using Metapsi.Shoelace;
using Metapsi.Ionic;
using System.Collections.Generic;
using System.Linq;
using Metapsi.SignalR;
using System.Reflection;

public class DataModel
{
    public string Title { get; set; } = "Title";
    public string Message { get; set; } = "Hi! It works!";
}

public class Entry
{
    public string Ticker { get; set; }
    public string Name { get; set; }
    public decimal Value { get; set; } = 100;
    public bool GoingUp { get; set; } = true;
}

public class MarketData
{
    public List<Entry> Entries { get; set; } = new List<Entry>()
    {
        new Entry(){ Ticker = "NVDA", Name = "Nvidia" },
        new Entry(){ Ticker = "AAPL", Name = "Apple" },
        new Entry(){ Ticker = "TSLA", Name = "Tesla" },
        new Entry(){ Ticker = "AMZN", Name = "Amazon" },
        new Entry(){ Ticker = "MSFT", Name = "Microsoft" }
    };
}

public class Refresh
{
    public MarketData MarketData { get; set; }
}

public static class Program
{
    public class Nested
    {
        public class NestedAgain
        {
        }
    }

    public static async Task Main()
    {
        Console.WriteLine(typeof(List<Nested.NestedAgain>).CSharpTypeName());

        Console.WriteLine(typeof(Dictionary<string, HashSet<Guid>>).CSharpTypeName(TypeQualifier.All));
        Console.WriteLine(typeof(int).CSharpTypeName());
        Console.WriteLine(typeof(DateTime).CSharpTypeName());
        Console.WriteLine(typeof(List<string>).CSharpTypeName());
        Console.WriteLine(typeof(byte[]).CSharpTypeName());


        //await StaticFiles.AutoAdd();

        //await Task.Delay(100000);


        // AddMetapsiSignalR preserves JSON capitalization
        var app = WebApplication.CreateBuilder().AddMetapsi().AddMetapsiSignalR().Build();
        app.UseMetapsi();
        app.MapDefaultSignalRHub();
        app.MapGet("/", () => Page.Result(new DataModel()));
        app.MapGet("/market", () => Page.Result(new MarketData()));
        app.UseRenderer<DataModel>(model => $"<html><head><title>{model.Title}</title></head><body>{model.Message}</body></html>");

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


        app.UseRenderer<DataModel>(
            model => HtmlBuilder.FromDefault(
            b =>
            {
                b.UseWebComponentsFadeIn();
                b.HeadAppend(b.HtmlTitle(model.Title));
                b.BodyAppend(
                    b.SlDialog(
                        b =>
                        {
                            b.SetStyle("font-family:var(--sl-font-sans)");
                            b.SetLabel("Shoelace dialog");
                            b.SetOpen();
                        },
                        b.Text(model.Message)));
            }).ToHtml());

        app.UseRenderer<DataModel>(
            model => HtmlBuilder.FromDefault(
            b =>
            {
                b.UseWebComponentsFadeIn();
                b.HeadAppend(b.HtmlTitle(model.Title));
                b.BodyAppend(
                    b.Hyperapp(
                        model,
                        (b, model) =>
                        b.HtmlDiv(
                            b.SlDialog(
                                b =>
                                {
                                    b.AddStyle("font-family", "var(--sl-font-sans)");
                                    b.SetId("shoelace-dialog");
                                    b.SetLabel("Shoelace dialog");
                                },
                                b.Text(b.Get(model, x => x.Message)),
                                b.SlButton(
                                    b =>
                                    {
                                        b.SetSlot(SlDialog.Slot.Footer);
                                        b.SetVariantSuccess();
                                        b.OnClickAction((SyntaxBuilder b, Var<DataModel> model) =>
                                        {
                                            b.HideDialog("shoelace-dialog");
                                            return b.Clone(model);
                                        });
                                    },
                                    b.Text("Great!"))),
                            b.SlButton(
                                b =>
                                {
                                    b.OnClickAction((SyntaxBuilder b, Var<DataModel> model) =>
                                    {
                                        b.ShowDialog("shoelace-dialog");
                                        return b.Clone(model);
                                    });
                                },
                                b.Text("Open dialog")))));
            }).ToHtml());

        app.UseRenderer<DataModel>(
            model => HtmlBuilder.FromDefault(
            b =>
            {
                b.UseWebComponentsFadeIn();
                b.HeadAppend(b.HtmlTitle(model.Title));
                b.BodyAppend(
                    b.IonApp(
                        b.IonContent(
                            b.IonAlert(
                                b =>
                                {
                                    b.SetIsOpen();
                                    b.SetHeader(model.Title);
                                    b.SetMessage(model.Message);
                                }))));
            }).ToHtml());

        app.UseRenderer<DataModel>(
            model => HtmlBuilder.FromDefault(
            b =>
            {
                b.UseWebComponentsFadeIn();
                b.HeadAppend(b.HtmlTitle(model.Title));
                b.BodyAppend(
                    b.Hyperapp(
                        model,
                        (b, model) =>
                        {
                            return b.IonApp(
                                b.IonContent(
                                    b.IonAlert(
                                        b =>
                                        {
                                            b.SetIsOpen();
                                            b.SetHeader(b.Get(model, x => x.Title));
                                            b.SetMessage(b.Get(model, x => x.Message));
                                        })));
                        }));
            }).ToHtml());

        app.UseRenderer<MarketData>(
            model => HtmlBuilder.FromDefault(
            b =>
            {
                b.UseWebComponentsFadeIn();
                b.HeadAppend(b.HtmlTitle("Market data, absolutely real time for sure ..."));
                b.BodyAppend(
                    b.Hyperapp<MarketData>(
                        InitializeClientSideApp,
                        RenderClientSideApp,
                        ListenToUpdates));
            }).ToHtml());

        var _notAwaited = Task.Run(GenerateRandomData);

        await app.RunAsync();
    }

    public static Var<HyperType.Init> InitializeClientSideApp(SyntaxBuilder b)
    {
        return b.MakeInit(
            b.MakeStateWithEffects(
                b.Const(new MarketData()),
                // Connect to default SignalR hub
                b.SignalRConnect()));
    }

    public static Var<HyperType.Subscription> ListenToUpdates(SyntaxBuilder b, Var<MarketData> _modelNotUsed)
    {
        // Listen to SignalR event
        return b.Listen(b.MakeAction((SyntaxBuilder b, Var<MarketData> model, Var<Refresh> refreshEvent) =>
        {
            // Return the data. Hyperapp triggers automatic refresh
            return b.Get(refreshEvent, x => x.MarketData);
        }));
    }

    public static Var<IVNode> RenderClientSideApp(LayoutBuilder b, Var<MarketData> model)
    {
        return b.HtmlDiv(
            b.Map(
                b.Get(model, x => x.Entries.OrderByDescending(x => x.Value).ToList()),
                (b, company) =>
                {
                    return b.HtmlDiv(
                        b =>
                        {
                            b.AddStyle("display", "flex");
                            b.AddStyle(
                                "color",
                                b.If(
                                    b.Get(company, x => x.GoingUp),
                                    b => b.Const("green"),
                                    b => b.Const("red")));
                        },
                        b.HtmlDiv(
                            b =>
                            {
                                b.AddStyle("width", "100px");
                            },
                            b.Text(b.Get(company, x => x.Ticker))),
                        b.HtmlDiv(
                            b =>
                            {
                                b.AddStyle("width", "150px");
                            },
                            b.Text(b.Get(company, x => x.Name))),
                        b.HtmlDiv(
                            b =>
                            {
                                b.AddStyle("width", "50px");
                            },
                            b.Text(b.AsString(b.Get(company, x => x.Value)))));
                }));
    }

    public static async Task GenerateRandomData()
    {
        MarketData marketData = new();

        Random r = new Random();

        while (true)
        {
            await Task.Delay(3000);
            foreach (var entry in marketData.Entries)
            {
                var newValue = entry.Value + new decimal(r.NextDouble() - 0.5) * 2;
                entry.GoingUp = newValue > entry.Value;
                entry.Value = decimal.Round(newValue, 2);
            }

            // Raise SignalR event with new data
            await DefaultMetapsiSignalRHub.HubContext.Clients.All.RaiseEvent(new Refresh()
            {
                MarketData = marketData
            });
        }
    }
}