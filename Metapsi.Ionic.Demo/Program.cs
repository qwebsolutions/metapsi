
using Metapsi;
using Metapsi.Dom;
using Metapsi.Hyperapp;
using Metapsi.Ionic;
using Metapsi.Syntax;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using static Metapsi.Hyperapp.HyperType;

public class Parameters
{
    public int Port { get; set; }
}

public class Program
{
    public static async Task Main()
    {
        var serviceSetup = Mds.ServiceSetup.New(new System.Collections.Generic.Dictionary<string, string>()
        {
            { "ServiceName", "IonicDemo" },
            { "InfrastructureName", "IonicTestInfrastructure" },
            { "Port", "5000" }
        });
        await SetupService(serviceSetup);

        var app = serviceSetup.Revive();
        await app.SuspendComplete;
    }

    public static async Task SetupService(Mds.ServiceSetup serviceSetup)
    {
        var parameters = serviceSetup.ParametersAs<Parameters>();
        var ig = serviceSetup.ApplicationSetup.AddImplementationGroup();

        var webServerRefs = serviceSetup.ApplicationSetup.AddWebServer(
            ig,
        parameters.Port,
        "");

        webServerRefs.WebApplication.RegisterGetHandler<HomeHandler, Home>();
        webServerRefs.RegisterPageBuilder<HomeRenderer, HomeModel>();

        webServerRefs.WebApplication.MapGet("/", () => Results.Redirect(WebServer.Url<Home>())).AllowAnonymous().ExcludeFromDescription();

        webServerRefs.RegisterStaticFiles(typeof(Metapsi.Ionic.AccordionGroupChangeEventDetail).Assembly);
        webServerRefs.RegisterStaticFiles(typeof(Metapsi.Dom.ClickTarget).Assembly);
        webServerRefs.RegisterStaticFiles(typeof(Metapsi.Syntax.Block).Assembly);
        webServerRefs.RegisterStaticFiles(typeof(Metapsi.Hyperapp.HyperType).Assembly);
        webServerRefs.RegisterStaticFiles(typeof(Program).Assembly);
    }
}

public class HomeRenderer : HyperPage<HomeModel>
{
    public override Var<IVNode> OnRender(LayoutBuilder b, Var<HomeModel> model)
    {
        return b.IonApp(b => { },
            b.IonHeader(b => { },
                b.IonToolbar(
                    b => { },
                    b.IonSegment(
                        b => 
                        {
                            //b.SetValue("notifications");
                            b.OnIonChange((SyntaxBuilder b, Var<HomeModel> model, Var<SegmentChangeEventDetail> detail) =>
                            {
                                b.Log(detail);
                                return b.Clone(model);
                            });
                        },
                        b.IonSegmentButton(
                            b => { b.SetValue("chat"); },
                            b.IonLabel(b=> { }, b.T("Chat"))),
                        b.IonSegmentButton(
                            b => { b.SetValue("notifications"); },
                            b.IonLabel(b => { }, b.T("Notifications"))))

                    )),
            b.IonContent(
                b => 
                {
                    b.SetDynamic(b.Props, Html.id, b.Const("content"));
                },
                b.IonAlert(b=>
                {
                    b.SetCssClass("custom-alert");
                    b.SetTrigger("alert-me");
                    b.SetHeader("You clicked it, didn't you?");
                    b.SetSubHeader("Sneaky bastard...");
                    b.SetMessage("Well, close it now!");
                    b.SetButtons(new List<AlertButton>() {
                        new AlertButton()
                        {
                            text = "Cancel",
                            role = "cancel",
                            cssClass = "alert-button-cancel"
                        },
                        new AlertButton()
                        {
                            text = "OK",
                            role = "OK",
                            cssClass = "alert-button-confirm"
                        }
                    });

                    //b.SetButtons(new List<string>() { "abc", "def" });


                    b.OnDidDismiss((SyntaxBuilder b, Var<HomeModel> model, Var<OverlayEventDetail> detail) =>
                    {
                        b.Log(b.Concat(b.Const("You clicked on role:"), b.Get(detail, x => x.role)));
                        return b.Clone(model);
                    });
                }),
                b.IonButton(b=>
                {
                    b.SetDynamic(b.Props, Html.id, b.Const("alert-me"));
                    b.OnClickAction(b.MakeAction((SyntaxBuilder b, Var<HomeModel> model) =>
                    {
                        return b.Clone(model);
                    }));
                },
                b.T("Click me!")),
                b.IonDatetimeButton(b=>
                {
                    b.SetDatetime("datetime");
                }),
                b.IonModal(b=>
                {

                },
                b.IonDatetime(b=>
                {
                    b.SetDynamic(b.Props, Html.id, b.Const("datetime"));
                    b.OnIonChange((SyntaxBuilder b, Var<HomeModel> model, Var<DatetimeChangeEventDetail> selectedDate) =>
                    {
                        b.Log(selectedDate);
                        b.Set(model, x => x.ContentText, b.Get(selectedDate, x => x.value));
                        return b.Clone(model);
                    });
                })),
                b.IonList(
                    b => 
                    {
                        b.SetDynamic(b.Props, Html.id, b.Const("list-id"));
                    },
                    b.Map(
                        b.Get(model, x=>x.ListItems),
                        (b, item)=> 
                        b.IonItemSliding(
                            b => { },
                            b.IonItem(
                                b => { },
                                b.IonLabel(b => { }, b.T(item))),
                            b.IonItemOptions(
                                b => { },
                                b.IonItemOption(b =>
                                {
                                    b.OnClickAction(b.MakeAction((SyntaxBuilder b, Var<HomeModel> model) =>
                                    {
                                        b.Remove(b.Get(model, x => x.ListItems), item);
                                        b.CallOnObject(b.GetElementById(b.Const("list-id")), IonList.Method.CloseSlidingItems);

                                        return b.Clone(model);
                                    }));
                                },
                                b.T("Remove")))))),

                b.IonText(b => { }, b.T(b.Get(model, x=>x.ContentText)))));
    }
}

public class HomeModel
{
    public string ContentText { get; set; } = "Text here";
    public List<string> ListItems { get; set; } = new() { "Cătălin", "Călin", "Alice", "Bogdan", "Xenia", "Octav",
    "Cătălin2", "Călin2", "Alice2", "Bogdan2", "Xenia2", "Octav2",
    "Cătălin3", "Călin3", "Alice3", "Bogdan3", "Xenia3", "Octav3"
    };
}

public class HomeHandler : Metapsi.Http.Get<Home>
{
    public override async Task<IResult> OnGet(CommandContext commandContext, HttpContext httpContext)
    {
        return Page.Result(new HomeModel());
    }
}


public class Home : Metapsi.Route.IGet { }