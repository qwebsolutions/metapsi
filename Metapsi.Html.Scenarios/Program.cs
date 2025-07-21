using Microsoft.AspNetCore.Builder;
using System.Threading.Tasks;
using Metapsi;
using System;
using Metapsi.Html;
using Metapsi.Syntax;
using Metapsi.Hyperapp;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.SignalR;
using Microsoft.AspNetCore.Routing;
using Metapsi.SignalR;
using Microsoft.AspNetCore.Http;
using Metapsi.Shoelace;
using Metapsi.Web;

public class DataModel
{
    public bool ShowText { get; set; }
    public string Title { get; set; } = "Title";
    public string Message { get; set; } = "";
    public List<string> List { get; set; } = new();

    public string Length { get; set; }

    public NestedDataModel Nested { get; set; } = new();
    public DateTime SomeDate { get; set; }
}

public class NestedDataModel
{
    public string NestedMessage { get; set; } = "Default";
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
    public string BindingTest { get; set; }

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

public class Form
{
    public Widget[] Controls { get; set; }
    public String Title { get; set; }
}

public class Widget
{

}

public class TextBox : Widget
{
    public Action OnChange { get; set; }
    public Request<DataModel, DataModel> OnChangeApi { get; set; }
    public String Value { get; set; }
}

public class NavigateToPage : ServerRenderedPage<NavigateToPage.Model>
{
    public class Model
    {

    }

    public override async Task<Model> OnLoadModel(Metapsi.Web.CfHttpContext context, App.Map model)
    {
        return new Model();
    }

    public override void OnRender(HtmlBuilder b, Model model)
    {
        b.BodyAppend(b.Text("Works!"));
    }
}

public class TestPageImplementation : ServerRenderedPage<TestPageImplementation.Model>
{
    public class Model
    {
        public int RandomValue { get; set; }
        public string NavigateToUrl { get; set; }
        public string CustomElement1JsPath { get; set; }
    }

    public TestPageImplementation()
    {
        this.Name = "test";
    }

    public override async Task<Model> OnLoadModel(Metapsi.Web.CfHttpContext context, App.Map model)
    {
        return new Model()
        {
            NavigateToUrl = model.GetPageUrl<NavigateToPage>(),
            RandomValue = new Random().Next(),
            CustomElement1JsPath = model.GetCustomElementUrl<TestCustomElement>()
        };
    }

    public override void OnRender(HtmlBuilder b, Model model)
    {
        //HtmlBuilder trackers : always convert to HTML, as it needs to be serializable (does it?)
        //    b.CustomElement<T> adds header

        //    Custom element - call server - endpoint name
        //    MakeServerAction != CallServer in , for example, Custom element init


        b.AddScriptModule(model.CustomElement1JsPath);
        b.BodyAppend(
            b.HtmlA(
                b =>
                {
                    b.SetHref(model.NavigateToUrl);
                },
                b.Text("Navigate")),
            b.Tag(new TestCustomElement().Tag));
    }
}

public static class SubscriptionExtensions
{
    public static void AddSubscription(this PropsBuilder<List<HyperType.Subscription>> b, Var<HyperType.Subscription> subscription)
    {
        b.Push(b.Props, subscription);
    }
}

public class TestCustomElement : CustomElement<DataModel>
{
    public TestCustomElement()
    {
        this.Tag = "test-custom";
    }

    public override Var<HyperType.StateWithEffects> OnInit(SyntaxBuilder b, App.Map model, Var<Element> element)
    {
        return b.MakeStateWithEffects(b.NewObj<DataModel>());
    }

    public override IRootControl OnRender(LayoutBuilder b, Var<DataModel> model)
    {
        return Root(
            b.HtmlDiv(b.Text(b.Get(model, x => x.Title))));
    }

    public override void OnSubscribe(SyntaxBuilder b, Var<DataModel> model, Var<List<HyperType.Subscription>> subscriptions)
    {
        b.Push(subscriptions, b.NewObj<HyperType.Subscription>());
    }
}

public static class Program
{
    public class Nested
    {
        public class NestedAgain
        {
        }
    }


    public static void ExplicitMethodHere(SyntaxBuilder b)
    {
        b.Log("BAU!");
    }

    static Dictionary<string, Delegate> ServerCalls { get; set; } = new();


    /// <summary>
    /// Adds a SignalR hub on DefaultMetapsiSignalRHub.Path
    /// </summary>
    /// <param name="builder"></param>
    /// <returns></returns>
    public static HubEndpointConventionBuilder MapDefaultSignalRHub(
        this IEndpointRouteBuilder builder,
        string path = nameof(DefaultMetapsiSignalRHub),
        Action<IHubContext> storeHubContext = null)
    {
        var hubBuilder = builder.MapHub<DefaultMetapsiSignalRHub>(path);
        if (storeHubContext != null)
        {
            var hubContext = builder.ServiceProvider.GetService(typeof(IHubContext<DefaultMetapsiSignalRHub>)) as IHubContext;
            storeHubContext(hubContext);
        }
        //DefaultMetapsiSignalRHub.HubContext = builder.ServiceProvider.GetService(typeof(IHubContext<DefaultMetapsiSignalRHub>)) as IHubContext<DefaultMetapsiSignalRHub>;
        return hubBuilder;
    }

    public static async Task Main()
    {

        //var module = Metapsi.Syntax.Module.Build(b =>
        //{
        //    var inlineFunc = b.Def((SyntaxBuilder b, Var<DataModel> model) =>
        //    {
        //        var title = b.Get(model, x => x.Title);
        //        b.Log(title);
        //        var nested = b.Get(model, x => x.Nested);
        //        b.Log(b.Get(nested, x => x.NestedMessage));
        //        b.If(
        //            b.Get(model, x => x.List.Any()),
        //            b =>
        //            {

        //            },
        //            b=>
        //            {

        //            });
        //        b.Foreach(
        //            b.Get(model, x => x.List),
        //            (b, item) =>
        //            {
        //                b.Log("item is ", item);
        //                var one = b.Const(1);
        //            });
        //    });

        //    b.Call(inlineFunc, b.Const(new DataModel()));
        //});

        //var serializable = module.GetDefinition();
        //var options = new JsonSerializerOptions();
        //options.Converters.Add(new SyntaxNodeConverter());
        //options.Converters.Add(new JsonStringEnumConverter());
        //options.WriteIndented = true;
        //var moduleJson = System.Text.Json.JsonSerializer.Serialize(serializable, options);
        //var back = System.Text.Json.JsonSerializer.Deserialize<ModuleDefinition>(moduleJson, options);
        //Console.WriteLine("!!!!!!!!!!! TO JS");
        //Console.WriteLine(back.ToJs());

        //Environment.Exit(0);

        //var converted = Metapsi.JavaScript.LinqConverter.ToJavaScript(() => "test");

        //Environment.Exit(0);

        //Console.WriteLine(typeof(List<Nested.NestedAgain>).CSharpTypeName());

        //Console.WriteLine(typeof(Dictionary<string, HashSet<Guid>>).CSharpTypeName(TypeQualifier.All));
        //Console.WriteLine(typeof(int).CSharpTypeName());
        //Console.WriteLine(typeof(DateTime).CSharpTypeName());
        //Console.WriteLine(typeof(List<string>).CSharpTypeName());
        //Console.WriteLine(typeof(byte[]).CSharpTypeName());


        //await StaticFiles.AutoAdd();

        //await Task.Delay(100000);

        //Form x = new();
        //x.Controls = new Widget[] 
        //    { 
        //        new TextBox() { OnChange = ()=>
        //        {
        //        }
        //    } 
        //};


        // AddMetapsiSignalR preserves JSON capitalization
        //var app = WebApplication.CreateBuilder().AddMetapsi().AddMetapsiSignalR().Build();
        var builder = WebApplication.CreateBuilder().AddMetapsi();
        builder.Services.AddSignalR()
            .AddJsonProtocol(options =>
            {
                options.PayloadSerializerOptions.PropertyNamingPolicy = null;
            });
        var app = builder.Build();
        app.UseMetapsi();
        app.Urls.Add("http://localhost:5000");
        app.MapDefaultSignalRHub(storeHubContext: hc => StaticHubContext = hc);

        app.MapGet("abc/{p1}/something/{f}", async (string p1, int f) =>
        {

        }).WithName("pattern");

        var testApp1 = App.New(
            b =>
            {
                b.ConfigureCustomElements(
                    b =>
                    {
                        b.Add<TestCustomElement>();
                    });

                b.ConfigurePages(
                    b =>
                    {
                        b.Add<TestPageImplementation>();
                        b.Add<NavigateToPage>();
                        b.Add<MarketData>(
                            b =>
                            {
                                b.Configuration.Name = "m";
                                b.Configuration.LoadModel = async (httpContext, appModel) =>
                                {
                                    var models = appModel.Features;
                                    return new MarketData();
                                };
                                b.Configuration.Render = (b, model) =>
                                {
                                    b.BodyAppend(b.Text("I don't know what to do with this MarketData"));
                                };
                            });
                        b.Add<DataModel>(
                            b =>
                            {
                                b.Configuration.LoadModel = async (httpContext, appModel) =>
                                {
                                    return new DataModel();
                                };

                                b.Configuration.Render = (b, model) =>
                                {
                                    b.BodyAppend(b.Text("I don't know what to do with this DataModel"));
                                };
                            });
                    });
            });

        app.MapGroup("testApp1").MapApp(testApp1);

        //app.MapGet("/", () => Page.Result(new DataModel()));
        //app.MapServerActions("someOtherPath");

        app.MapGet("/market", () => Page.Result(new MarketData()));
        app.MapPost("/serverAction", static (HttpContext httpContext, ServerAction.Call call) =>
        {
            call.UpdateParameterByType<MarketData>(model =>
            {
                model.BindingTest = httpContext.Request.Headers.UserAgent;
            });
            return call.Run(new() { typeof(Program) });
        });

        app.UseRenderer<MarketData>(model =>
        {
            return HtmlBuilder.FromDefault(
                b =>
                {
                    b.UseWebComponentsFadeIn();
                    b.HeadAppend(b.HtmlTitle("Market data, absolutely real time for sure ..."));
                    b.BodyAppend(
                        b.Hyperapp<MarketData>(
                            InitializeClientSideApp,
                            RenderClientSideApp,
                            ListenForUpdates));
                });
        });
        //app.UseRenderer<DataModel>(model => $"<html><head><title>{model.Title}</title></head><body>{model.Message}</body></html>");

        //app.UseRenderer<DataModel>(
        //    model => HtmlBuilder.FromDefault(
        //        b =>
        //        {
        //            b.HeadAppend(b.HtmlTitle(model.Title));
        //            b.BodyAppend(b.Text(model.Message));
        //        }).ToHtml());

        //app.UseRenderer<DataModel>(
        //    model => HtmlBuilder.FromDefault(
        //    b =>
        //    {
        //        b.HeadAppend(b.HtmlTitle(model.Title));
        //        b.BodyAppend(b.HtmlScript($"alert('{model.Message}')"));
        //    }).ToHtml());

        //app.UseRenderer<DataModel>(
        //    model => HtmlBuilder.FromDefault(
        //    b =>
        //    {
        //        b.HeadAppend(b.HtmlTitle(model.Title));
        //        b.BodyAppend(b.HtmlScriptModule(b =>
        //        {
        //            b.Alert(model.Message);
        //        }));
        //    }).ToHtml());

        //app.UseRenderer<DataModel>(
        //    model => HtmlBuilder.FromDefault(
        //    b =>
        //    {
        //        b.HeadAppend(b.HtmlTitle(model.Title));
        //        b.BodyAppend(b.HtmlButton(
        //            b =>
        //            {
        //                b.SetId("click-me");
        //                b.SetStyle("color:blue");
        //            },
        //            b.Text("Click me!")));
        //        b.BodyAppend(b.HtmlScriptModule(b =>
        //        {
        //            b.SetProperty(
        //                b.GetElementById("click-me"),
        //                b.Const("onclick"),
        //                b.Def((SyntaxBuilder b) =>
        //                {
        //                    b.Alert(model.Message);
        //                }));
        //        }));
        //    }).ToHtml());

        //app.UseRenderer<DataModel>(
        //    model => HtmlBuilder.FromDefault(
        //    b =>
        //    {
        //        b.HeadAppend(b.HtmlTitle(model.Title));
        //        b.BodyAppend(
        //            b.Hyperapp(
        //                model,
        //                (b, model) =>
        //                {
        //                    return b.HtmlButton(
        //                        b =>
        //                        {
        //                            b.AddStyle("color", "green");
        //                            b.OnClickAction((SyntaxBuilder b, Var<DataModel> model) =>
        //                            {
        //                                b.Alert(b.Get(model, x => x.Message));
        //                                b.Set(model, x => x.Message, b.Const("Already clicked!"));
        //                                return b.Clone(model);
        //                            });
        //                        },
        //                        b.Text("Click me!"));
        //                }));
        //    }).ToHtml());


        //app.UseRenderer<DataModel>(
        //    model => HtmlBuilder.FromDefault(
        //    b =>
        //    {
        //        b.UseWebComponentsFadeIn();
        //        b.HeadAppend(b.HtmlTitle(model.Title));
        //        b.BodyAppend(
        //            b.SlDialog(
        //                b =>
        //                {
        //                    b.SetStyle("font-family:var(--sl-font-sans)");
        //                    b.SetLabel("Shoelace dialog");
        //                    b.SetOpen();
        //                },
        //                b.Text(model.Message)));
        //    }).ToHtml());

        string line = "abc";

        //app.UseRenderer<DataModel>(
        //    model => HtmlBuilder.FromDefault(
        //    b =>
        //    {
        //        b.UseWebComponentsFadeIn();
        //        b.HeadAppend(b.HtmlTitle(model.Title));
        //        b.BodyAppend(
        //            b.Hyperapp(
        //                model,
        //                (b, model) =>
        //                b.HtmlDiv(
        //                    b.SlDialog(
        //                        b =>
        //                        {
        //                            b.AddStyle("font-family", "var(--sl-font-sans)");
        //                            b.SetId("shoelace-dialog");
        //                            b.SetLabel("Shoelace dialog");
        //                        },
        //                        b.SlIcon(
        //                            b=>
        //                            {
        //                                b.SetName("trash");
        //                            }),
        //                        b.IonButton(
        //                            b.IonIcon("people-circle"),
        //                            b.Text("Test")),
        //                        b.Text(b.Get(model, x => x.Message)),
        //                        b.SlInput(
        //                            b=>
        //                            {
        //                                var notUsed = b.Get(model, x => x.Length);

        //                                //b.OnInputAction(
        //                                //    b.CallServer(
        //                                //        async (DataModel model, string inputString) =>
        //                                //        {
        //                                //            model.Message = inputString;
        //                                //            model.ShowText = inputString.Length % 2 == 0;
        //                                //            return model;
        //                                //        }));

        //                                //b.SetValue(b.Get(model, x => x.Message));

        //                                //b.BindTo(model, x => x.Message);
        //                                b.BindTo(model, x => x.Nested, x => x.NestedMessage);
        //                                //b.BindTo(model, x => x.SomeDate, x => x.Minute);

        //                            }),
        //                        b.SlButton(
        //                            b =>
        //                            {
        //                                b.SetSlot(SlDialog.Slot.Footer);
        //                                b.SetVariantSuccess();
        //                                //b.OnClickAction((SyntaxBuilder b, Var<DataModel> model) =>
        //                                //{
        //                                //    var comment = b.Comment("Shoelace dialog here");

        //                                //    b.HideDialog("shoelace-dialog");
        //                                //    return b.Clone(model);
        //                                //});
        //                            },
        //                            b.Text(b.Get(model, x=>x.Message)))),
        //                    b.Optional(
        //                        b.Get(model, x=>x.Nested.NestedMessage.Length%2 == 0),
        //                        //b.Get(
        //                        //    model, 
        //                        //    b.Def<SyntaxBuilder, string,int>(Metapsi.Syntax.Core.StringLength),
        //                        //    (model, sl)=> sl(model.Nested.NestedMessage) %2 == 0),
        //                            //b.StringLength(
        //                                //b.Get(model, x=>x.Message)),
        //                                //x=> x%2 == 0),
        //                        b=> b.Text("Hidden text")),
        //                    b.SlButton(
        //                        b =>
        //                        {
        //                            b.OnClickAction(b.CallServer(
        //                                async (model) =>
        //                                {
        //                                    model.Message = "WORKS!";
        //                                    return model;
        //                                },
        //                                b.MakeAction((SyntaxBuilder b, Var<DataModel> model, Var<DataModel> newModel) =>
        //                                {
        //                                    b.ShowDialog("shoelace-dialog");
        //                                    return newModel;
        //                                })));

        //                            //b.OnClickAction((SyntaxBuilder b, Var<DataModel> model) =>
        //                            //{
        //                            //    return b.CallServerAction(
        //                            //        model,
        //                            //        model,
        //                            //        async (model) =>
        //                            //        {
        //                            //            model.Message = "Changed server side";
        //                            //            return model;
        //                            //        },
        //                            //        b.MakeAction((SyntaxBuilder b, Var<DataModel> model, Var<DataModel> newModel) =>
        //                            //        {
        //                            //            return newModel;
        //                            //        }),
        //                            //        b.MakeAction((SyntaxBuilder b, Var<DataModel> model, Var<ClientSideException> ex) =>
        //                            //        {
        //                            //            return model;
        //                            //        }));
        //                            //});

        //                            //b.OnClickAction((SyntaxBuilder b, Var<DataModel> model) =>
        //                            //{
        //                            //    b.ShowDialog("shoelace-dialog");
        //                            //    return b.Clone(model);
        //                            //});
        //                        },
        //                        b.Text("Open dialog")))));
        //    }).ToHtml());

        //app.UseRenderer<DataModel>(
        //    model => HtmlBuilder.FromDefault(
        //    b =>
        //    {
        //        b.UseWebComponentsFadeIn();
        //        b.HeadAppend(b.HtmlTitle(model.Title));
        //        b.BodyAppend(
        //            b.IonApp(
        //                b.IonContent(
        //                    b.IonAlert(
        //                        b =>
        //                        {
        //                            b.SetIsOpen();
        //                            b.SetHeader(model.Title);
        //                            b.SetMessage(model.Message);
        //                        }))));
        //    }).ToHtml());

        //app.UseRenderer<DataModel>(
        //    model => HtmlBuilder.FromDefault(
        //    b =>
        //    {
        //        b.UseWebComponentsFadeIn();
        //        b.HeadAppend(b.HtmlTitle(model.Title));
        //        b.BodyAppend(
        //            b.Hyperapp(
        //                model,
        //                (b, model) =>
        //                {
        //                    return b.IonApp(
        //                        b.IonContent(
        //                            b.IonAlert(
        //                                b =>
        //                                {
        //                                    b.SetIsOpen();
        //                                    b.SetHeader(b.Get(model, x => x.Title));
        //                                    b.SetMessage(b.Get(model, x => x.Message));
        //                                })));
        //                }));
        //    }).ToHtml());

        //app.UseRenderer<MarketData>(
        //    model =>);

        var _notAwaited = Task.Run(GenerateRandomData);

        await app.RunAsync();
    }

    public static Var<HyperType.Init> InitializeClientSideApp(SyntaxBuilder b)
    {
        var dateTimeFormat = b.NewIntlDateTimeFormat(
            b.Const("ro"),
            b.Const(new Intl.DateTimeFormatOptions()
            {
                dateStyle = "long"
            }));
        var dateConstructor = b.GetProperty<object>(b.Self(), "Date");
        var nowDate = b.New<object>(dateConstructor);
        b.Log(b.CallOnObject<string>(dateTimeFormat, "format", nowDate));
        //b.NewObj<Intl.DateTimeFormatOptions>(
        //    b =>
        //    {
        //        b.Set(x => x.dateStyle, "long");
        //    }));

        return b.MakeInit(
            b.MakeStateWithEffects(
                b.Const(new MarketData()),
                // Connect to default SignalR hub
                b.SignalRConnect(nameof(DefaultMetapsiSignalRHub))));
    }

    //public static void CallServer(this PropsBuilder<SlButton> propsBuilder, Action<DataModel> action)
    //{
    //    ServerCalls.Add(action.Method.Name, action);
    //    propsBuilder.OnClickAction((SyntaxBuilder b, Var<DataModel> model) =>
    //    {
    //        return b.MakeStateWithEffects(
    //            b.Clone(model),

    //            b.PostJson<DataModel, ServerCall, DataModel>(
    //                b.Const("/ServerAction"),
    //                b.NewObj<ServerCall>(
    //                    b=>
    //                    {
    //                        b.Set(x => x.Model, b.Serialize(model));
    //                        b.Set(x => x.MethodName, action.Method.Name);
    //                    }),
    //            b.MakeAction<DataModel, DataModel>((SyntaxBuilder b, Var<DataModel> model, Var<DataModel> newModel) =>
    //            {
    //                return newModel;
    //            }),
    //            b.MakeAction((SyntaxBuilder b, Var<DataModel> model, Var<ClientSideException> ex) =>
    //            {
    //                return model;
    //            })));
    //    });
    //}


    //public static Var<HyperType.StateWithEffects> CallServerAction<TModel, TInput, TOutput>(
    //    this SyntaxBuilder b,
    //    Var<TModel> model,
    //    Var<TInput> input,
    //    Func<TModel, TInput, Task<TOutput>> action,
    //    Var<HyperType.Action<TModel, TOutput>> onSuccess,
    //    Var<HyperType.Action<TModel, ClientSideException>> onError)
    //{
    //    return b.MakeStateWithEffects(
    //        model,
    //        b.CallServerActionEffect(model, input, action, onSuccess, onError));
    //}

    //public static Var<HyperType.StateWithEffects> CallServerAction<TModel, TInput, TOutput>(
    //    this SyntaxBuilder b,
    //    Var<TModel> model,
    //    Var<TInput> input,
    //    Func<TInput, Task<TOutput>> action,
    //    Var<HyperType.Action<TModel, TOutput>> onSuccess,
    //    Var<HyperType.Action<TModel, ClientSideException>> onError)
    //{
    //    return b.MakeStateWithEffects(
    //        model,
    //        b.CallServerActionEffect(input, action, onSuccess, onError));
    //}

    //public static Var<HyperType.Effect> CallServerActionEffect<TModel, TInput, TOutput>(
    //    this SyntaxBuilder b,
    //    Var<TModel> model,
    //    Var<TInput> input,
    //    Func<TModel, TInput, Task<TOutput>> serverAction,
    //    Var<HyperType.Action<TModel, TOutput>> onSuccess,
    //    Var<HyperType.Action<TModel, ClientSideException>> onError)
    //{
    //    var parameters = b.NewCollection<object>();
    //    b.Push(parameters, model.As<object>());
    //    b.Push(parameters, input.As<object>());

    //    return b.CallDelegateServerActionEffect(parameters, serverAction, onSuccess, onError);
    //}

    //public static Var<HyperType.Effect> CallServerActionEffect<TModel, TInput, TOutput>(
    //    this SyntaxBuilder b,
    //    Var<TInput> input,
    //    Func<TInput, Task<TOutput>> serverAction,
    //    Var<HyperType.Action<TModel, TOutput>> onSuccess,
    //    Var<HyperType.Action<TModel, ClientSideException>> onError)
    //{
    //    var parameters = b.NewCollection<object>();
    //    b.Push(parameters, input.As<object>());
    //    return b.CallDelegateServerActionEffect(parameters, serverAction, onSuccess, onError);
    //}


    public static Var<HyperType.Subscription> ListenForUpdates(SyntaxBuilder b, Var<MarketData> _modelNotUsed)
    {
        // Listen to SignalR event
        return b.Listen(
            b.Window(),
            b.Const("Refresh"),
            b.MakeAction((SyntaxBuilder b, Var<MarketData> model, Var<CustomEvent<Refresh>> refreshEvent) =>
            {
                // Return the data. Hyperapp triggers automatic refresh
                return b.Get(refreshEvent, x => x.detail.MarketData);
            }));
    }

    public static Var<HyperType.Action<MarketData>> CallServerAction(this SyntaxBuilder b, Func<MarketData, Task<MarketData>> action)
    {
        return b.CallServerAction<MarketData>(b.Const("/serverAction"), action);
    }

    public static Var<HyperType.Action<MarketData, string>> CallServerAction(this SyntaxBuilder b, Func<MarketData, string, Task<MarketData>> action)
    {
        return b.CallServerAction<MarketData, string>(b.Const("/serverAction"), action);
    }

    public static async Task<MarketData> StaticAction(MarketData marketData, string someValue)
    {
        marketData.BindingTest += someValue;
        return marketData;
    }

    public static Var<IVNode> RenderClientSideApp(LayoutBuilder b, Var<MarketData> model)
    {
        return b.HtmlDiv(
            b.SlInput(
                b =>
                {
                    b.BindTo(model, x => x.BindingTest);
                    b.Log("model", model);
                    //b.OnSlChange(b.CallMarketAction(StaticAction));
                    b.OnSlChange(b.CallServerAction(StaticAction));
                }),
            b.HtmlDiv(
                b.Map(
                    b.Get(model, x => x.Entries.OrderByDescending(x => x.Value).ToList()),
                    (b, company) =>
                    {
                        return b.HtmlDiv(
                            b =>
                            {
                                b.AddStyle("display", "flex");
                                b.Comment("Display flex");
                                b.AddStyle(
                                    "color",
                                    b.If(
                                        b.Get(company, x => x.GoingUp),
                                        b => b.Const("green"),
                                        b => b.Const("red")));
                            },
                            b.SlBadge(
                                b =>
                                {
                                    b.AddStyle("width", "100px");
                                },
                                b.Text(b.Get(company, x => x.Ticker))),
                            b.HtmlDiv(
                                b =>
                                {
                                    b.AddStyle("width", "150px");
                                    b.OnClickAction(b.CallServerAction(
                                        async (model) =>
                                        {
                                            return model;
                                        }));
                                },
                                b.Text(b.Get(company, x => x.Name))),
                            b.HtmlDiv(
                                b =>
                                {
                                    b.AddStyle("width", "50px");
                                },
                                b.Text(b.AsString(b.Get(company, x => x.Value)))));
                    })));
    }

    public static IHubContext StaticHubContext;

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

            //Raise SignalR event with new data
            await StaticHubContext.Clients.All.RaiseCustomEvent(
                typeof(Refresh).Name,
                new Refresh()
                {
                    MarketData = marketData
                });
        }
    }
}