
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
using Metapsi.Shoelace;
using Metapsi.Html;
using Metapsi.Ui;
using System;
using Metapsi.TomSelect;
using Metapsi.JavaScript;

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

    public static Request<List<string>, string> SearchApi = new(nameof(SearchApi));

    public static List<string> FilterSource(string q)
    {
        var outList = new List<string>();
        for (char c1 = 'a'; c1 <= 'z'; c1++)
        {
            for (char c2 = 'a'; c2 <= 'z'; c2++)
            {
                for (char c3 = 'a'; c3 <= 'z'; c3++)
                {
                    for (char c4 = 'a'; c4 <= 'z'; c4++)
                    {
                        outList.Add($"{c1}{c2}{c3}{c4}");
                    }
                }
            }
        }

        var top = outList.Where(x => x.Contains(q.ToLower())).Take(50).ToList();
        return top;
    }

    public static void InitHtml(HtmlBuilder b, string title)
    {
        b.HeadAppend(b.HtmlTitle(b.Text(title)));
    }

    public static async Task SetupService(Mds.ServiceSetup serviceSetup)
    {
        var parameters = serviceSetup.ParametersAs<Parameters>();
        var ig = serviceSetup.ApplicationSetup.AddImplementationGroup();

        var webServerRefs = serviceSetup.ApplicationSetup.AddWebServer(
            ig,
        parameters.Port,
        "");

        webServerRefs.WebApplication.MapGet("/", () =>
        {
            ModuleBuilder b = new ModuleBuilder();
            b.Define("main", (SyntaxBuilder b) =>
            {
                
            });
            return PrettyBuilder.Generate(b.Module, new JsBuilderOptions()
            {
                ImportType = ImportType.ModuleAs,
                Indent = 2
            });
        });

        //webServerRefs.WebApplication.RegisterGetHandler<HomeHandler, Home>();
        //webServerRefs.RegisterPageBuilder<HomeModel>(model =>
        //{
        //    return htmlDocument.ToHtml();
        //});

        //webServerRefs.WebApplication.MapGet("/", () => Results.Redirect(WebServer.Url<Home>())).AllowAnonymous().ExcludeFromDescription();
        //webServerRefs.WebApplication.MapGet("/query", (string q) =>
        //{
        //    return FilterSource(q);
        //});

        //webServerRefs.WebApplication.MapGroup("api").MapRequest(
        //    SearchApi,
        //    async (CommandContext commandContex, HttpContext httpContext, string q) =>
        //    {
        //        return FilterSource(q);
        //    },
        //    WebServer.Authorization.Public,
        //    WebServer.SwaggerTryout.Block);
    }
}

public static class CheckboxTests
{
    public static Var<IVNode> ToDoApp(this LayoutBuilder b, Var<HomeModel> model)
    {
        return b.HtmlDiv(
            b =>
            {
                b.SetClass("flex flex-col gap-6 p-4");
            },
            b.HtmlDiv(
                b =>
                {
                    b.SetClass("flex flex-row gap-6 p-4");
                }
                //b.HtmlSpanText("My TO DO list"),
                //b.HtmlButton(
                //    b =>
                //    {
                //        b.SetClass("rounded border border-gray-200 p-2");
                //        b.OnClickAction((SyntaxBuilder b, Var<HomeModel> model) =>
                //        {
                //            var newToDo = b.NewObj<HomeModel.ToDoItem>();
                //            //b.Set(newToDo, x => x.Id, b.NewId());
                //            b.Push(b.Get(model, x => x.ToDoList), newToDo);
                //            return b.Clone(model);
                //        });
                //    },
                //    b.Text("+"))
                   ),
            b.HtmlDiv(
                b =>
                {
                    b.SetClass("flex flex-col gap-2 p-4");
                },
                b.Map(
                    b.Get(model, x => x.ToDoList.OrderBy(x => x.Done).ToList()),
                    (b, toDo) =>
                    {
                        var id = b.Get(toDo, x => x.Id);
                        var done = b.Get(toDo, x => x.Done);
                        b.Log("done is", done);

                        var getToDo = (SyntaxBuilder b, Var<HomeModel> model) =>
                        {
                            //b.Log("searched id", id);
                            var found = b.Get(model, id, (model, id) => model.ToDoList.Single(x => x.Id == id));
                            //b.Log("found item", found);
                            return found;
                        };

                        return b.HtmlDiv(
                            b =>
                            {
                                b.SetClass("flex flex-row gap-2");
                            },
                            b.HtmlCheckbox(
                                b =>
                                {
                                    //b.SetDynamic(b.Props, DynamicProperty.String("key"), b.Concat(b.Const("checkbox-"), b.AsString(id)));
                                    b.SetId(b.Concat(b.Const("checkbox-"), b.AsString(id)));
                                    b.SetChecked(done);
                                    b.OnClickAction((SyntaxBuilder b, Var<HomeModel> model, Var<DomEvent> eventArgs) =>
                                    {
                                        var target = b.Get(eventArgs, x => x.target);
                                        b.Log(target);
                                        var newValue = b.GetProperty<bool>(target, "checked");
                                        b.Log("newValue", newValue);
                                        b.Set(getToDo(b, model), x => x.Done, newValue);
                                        var localToDo = b.Get(
                                            model,
                                            b.Get(toDo, x => x.Id),
                                            (model, id) => model.ToDoList.Single(x => x.Id == id));
                                        b.Set(localToDo, x => x.Done, newValue);
                                        return b.Clone(model);
                                    });
                                    //b.BindTo(model, getToDo, x => x.Done);
                                }),
                            b.Optional(
                                b.Const( true),
                                b => b.HtmlSpanText(b.Get(toDo, x => x.Action))
                                //b => b.HtmlInput(
                                //    b =>
                                //    {
                                //        b.SetClass("rounded border border-gray-200 p-2");
                                //        b.BindTo(model, getToDo, x => x.Action);
                                //    }
                                    ));
                    })));
    }
}

public class HomeRenderer : HyperPage<HomeModel>
{
    public override void FillHtml(HomeModel dataModel, Metapsi.Ui.DocumentTag document)
    {
        document.Body.WithClass("sl-theme-dark");
        document.Body.WithClass("dark");
        document.Head.AddChild(new HtmlTag("meta").SetAttribute("name=", "color-scheme").SetAttribute("content", "dark"));

        var choicesCss = new HtmlTag("style");
        choicesCss.AddText(
            @"
.choices {
    --choices-font-family: var(--sl-input-font-family);
    --choices-font-size: var(--sl-button-font-size-medium);
    --choices-item-border-radius: var(--sl-border-radius-small);
    --choices-item-border-color: var(--sl-color-neutral-300);
    --choices-item-color: var(--sl-color-neutral-700);
    --choices-item-background-color: var(--sl-input-background-color);
    --choices-item-remove-button-size: 13px;
    --choices-item-remove-button-background-image: url(""data:image/svg+xml,%3Csvg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 24 24' height='20px' width='20px' fill='%2352525b' %3E%3Cpath fill-rule='evenodd' d='M5.47 5.47a.75.75 0 0 1 1.06 0L12 10.94l5.47-5.47a.75.75 0 1 1 1.06 1.06L13.06 12l5.47 5.47a.75.75 0 1 1-1.06 1.06L12 13.06l-5.47 5.47a.75.75 0 0 1-1.06-1.06L10.94 12 5.47 6.53a.75.75 0 0 1 0-1.06Z' clip-rule='evenodd' /%3E%3C/svg%3E%0A"");
    --choices-item-remove-button-background-image-highlighted: url(""data:image/svg+xml,%3Csvg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 24 24' fill='%23ffffff' %3E%3Cpath fill-rule='evenodd' d='M5.47 5.47a.75.75 0 0 1 1.06 0L12 10.94l5.47-5.47a.75.75 0 1 1 1.06 1.06L13.06 12l5.47 5.47a.75.75 0 1 1-1.06 1.06L12 13.06l-5.47 5.47a.75.75 0 0 1-1.06-1.06L10.94 12 5.47 6.53a.75.75 0 0 1 0-1.06Z' clip-rule='evenodd' /%3E%3C/svg%3E%0A"");

    --choices-item-color-highlighted : var(--sl-color-neutral-0);
    --choices-item-border-color-highlighted: var(--sl-color-primary-600);
    --choices-item-background-color-highlighted: var(--sl-color-primary-600);
}");

        //        styleSheet.AddText(
        //            @"
        //.choices {
        //    --choices-font-size: 20px;
        //    --choices-item-border-radius: 8px;
        //    --choices-item-color: red;
        //}");

        document.Head.AddChild(choicesCss);

//        document.Head.AddChild(new HtmlTag("style").WithChild(new HtmlText()
//        {
//            Text =
//            @"/* Ionic Variables and Theming. For more info, please see:
//http://ionicframework.com/docs/theming/ */

///*
// * Dark Colors
// * -------------------------------------------
// */

//body.dark {
//  --ion-color-primary: #428cff;
//  --ion-color-primary-rgb: 66, 140, 255;
//  --ion-color-primary-contrast: #ffffff;
//  --ion-color-primary-contrast-rgb: 255, 255, 255;
//  --ion-color-primary-shade: #3a7be0;
//  --ion-color-primary-tint: #5598ff;

//  --ion-color-secondary: #50c8ff;
//  --ion-color-secondary-rgb: 80, 200, 255;
//  --ion-color-secondary-contrast: #ffffff;
//  --ion-color-secondary-contrast-rgb: 255, 255, 255;
//  --ion-color-secondary-shade: #46b0e0;
//  --ion-color-secondary-tint: #62ceff;

//  --ion-color-tertiary: #6a64ff;
//  --ion-color-tertiary-rgb: 106, 100, 255;
//  --ion-color-tertiary-contrast: #ffffff;
//  --ion-color-tertiary-contrast-rgb: 255, 255, 255;
//  --ion-color-tertiary-shade: #5d58e0;
//  --ion-color-tertiary-tint: #7974ff;

//  --ion-color-success: #2fdf75;
//  --ion-color-success-rgb: 47, 223, 117;
//  --ion-color-success-contrast: #000000;
//  --ion-color-success-contrast-rgb: 0, 0, 0;
//  --ion-color-success-shade: #29c467;
//  --ion-color-success-tint: #44e283;

//  --ion-color-warning: #ffd534;
//  --ion-color-warning-rgb: 255, 213, 52;
//  --ion-color-warning-contrast: #000000;
//  --ion-color-warning-contrast-rgb: 0, 0, 0;
//  --ion-color-warning-shade: #e0bb2e;
//  --ion-color-warning-tint: #ffd948;

//  --ion-color-danger: #ff4961;
//  --ion-color-danger-rgb: 255, 73, 97;
//  --ion-color-danger-contrast: #ffffff;
//  --ion-color-danger-contrast-rgb: 255, 255, 255;
//  --ion-color-danger-shade: #e04055;
//  --ion-color-danger-tint: #ff5b71;

//  --ion-color-dark: #f4f5f8;
//  --ion-color-dark-rgb: 244, 245, 248;
//  --ion-color-dark-contrast: #000000;
//  --ion-color-dark-contrast-rgb: 0, 0, 0;
//  --ion-color-dark-shade: #d7d8da;
//  --ion-color-dark-tint: #f5f6f9;

//  --ion-color-medium: #989aa2;
//  --ion-color-medium-rgb: 152, 154, 162;
//  --ion-color-medium-contrast: #000000;
//  --ion-color-medium-contrast-rgb: 0, 0, 0;
//  --ion-color-medium-shade: #86888f;
//  --ion-color-medium-tint: #a2a4ab;

//  --ion-color-light: #222428;
//  --ion-color-light-rgb: 34, 36, 40;
//  --ion-color-light-contrast: #ffffff;
//  --ion-color-light-contrast-rgb: 255, 255, 255;
//  --ion-color-light-shade: #1e2023;
//  --ion-color-light-tint: #383a3e;
//}

///*
// * iOS Dark Theme
// * -------------------------------------------
// */

//.ios body.dark {
//  --ion-background-color: #000000;
//  --ion-background-color-rgb: 0, 0, 0;

//  --ion-text-color: #ffffff;
//  --ion-text-color-rgb: 255, 255, 255;

//  --ion-color-step-50: #0d0d0d;
//  --ion-color-step-100: #1a1a1a;
//  --ion-color-step-150: #262626;
//  --ion-color-step-200: #333333;
//  --ion-color-step-250: #404040;
//  --ion-color-step-300: #4d4d4d;
//  --ion-color-step-350: #595959;
//  --ion-color-step-400: #666666;
//  --ion-color-step-450: #737373;
//  --ion-color-step-500: #808080;
//  --ion-color-step-550: #8c8c8c;
//  --ion-color-step-600: #999999;
//  --ion-color-step-650: #a6a6a6;
//  --ion-color-step-700: #b3b3b3;
//  --ion-color-step-750: #bfbfbf;
//  --ion-color-step-800: #cccccc;
//  --ion-color-step-850: #d9d9d9;
//  --ion-color-step-900: #e6e6e6;
//  --ion-color-step-950: #f2f2f2;

//  --ion-item-background: #1c1c1d;

//  --ion-card-background: #1c1c1d;
//}

//.ios body.dark ion-modal {
//  --ion-background-color: var(--ion-color-step-100);
//  --ion-toolbar-background: var(--ion-color-step-150);
//  --ion-toolbar-border-color: var(--ion-color-step-250);
//}

///*
// * Material Design Dark Theme
// * -------------------------------------------
// */

//.md body.dark {
//  --ion-background-color: #121212;
//  --ion-background-color-rgb: 18, 18, 18;

//  --ion-text-color: #ffffff;
//  --ion-text-color-rgb: 255, 255, 255;

//  --ion-border-color: #222222;

//  --ion-color-step-50: #1e1e1e;
//  --ion-color-step-100: #2a2a2a;
//  --ion-color-step-150: #363636;
//  --ion-color-step-200: #414141;
//  --ion-color-step-250: #4d4d4d;
//  --ion-color-step-300: #595959;
//  --ion-color-step-350: #656565;
//  --ion-color-step-400: #717171;
//  --ion-color-step-450: #7d7d7d;
//  --ion-color-step-500: #898989;
//  --ion-color-step-550: #949494;
//  --ion-color-step-600: #a0a0a0;
//  --ion-color-step-650: #acacac;
//  --ion-color-step-700: #b8b8b8;
//  --ion-color-step-750: #c4c4c4;
//  --ion-color-step-800: #d0d0d0;
//  --ion-color-step-850: #dbdbdb;
//  --ion-color-step-900: #e7e7e7;
//  --ion-color-step-950: #f3f3f3;

//  --ion-item-background: #1e1e1e;

//  --ion-toolbar-background: #1f1f1f;

//  --ion-tab-bar-background: #1f1f1f;

//  --ion-card-background: #1e1e1e;
//}"
//        }));

        base.FillHtml(dataModel, document);
    }

    public override Var<IVNode> OnRender(LayoutBuilder b, Var<HomeModel> model)
    {
        return b.ToDoApp(model);
    }

    public /*override*/ Var<IVNode> OnRenderIonic(LayoutBuilder b, Var<HomeModel> model)
    {
        b.AddModuleStylesheet();
        StaticFiles.Add(typeof(HomeRenderer).Assembly, "DataSourceApi.js");

        return b.IonApp(b => { },
            b.IonHeader(b => { },
                b.IonToolbar(
                    b => { },
                    b.IonSegment(
                        b =>
                        {
                            b.OnIonChange((SyntaxBuilder b, Var<HomeModel> model, Var<SegmentChangeEventDetail> detail) =>
                            {
                                b.Log(detail);
                                return b.Clone(model);
                            });
                        },
                        b.IonSegmentButton(
                            b => { b.SetValue("chat"); },
                            b.IonLabel(b => { }, b.Text("Chat"))),
                        b.IonSegmentButton(
                            b => { b.SetValue("notifications"); },
                            b.IonLabel(b => { }, b.Text("Notifications"))))

                    )),
            b.IonContent(
                b =>
                {
                    b.SetId("content");
                },
                b.SlButton(b =>
                {
                    b.OnSlFocus((SyntaxBuilder b, Var<HomeModel> model, Var<DomEvent> eventArgs) =>
                    {
                        b.Log(eventArgs);
                        return b.Clone(model);
                    });
                },
                b.Text("Butonu' normal")),
                b.SlButton(
                    b =>
                    {
                        b.SetVariantPrimary();
                        b.OnSlFocus((SyntaxBuilder b, Var<HomeModel> model, Var<DomEvent> eventArgs) =>
                        {
                            b.Log(eventArgs);
                            return b.Clone(model);
                        });
                    },
                b.Text("Butonu' primar")),

                b.HtmlDiv(
                    b=>
                    {
                        b.SetClass("flex flex-row gap-4 p-12");
                    },
                    b.Text(b.Get(model, x=>x.SelectedItem)),
                    b.TomSelect(b=>
                    {

                        b.UseShoelaceStyles();
                        //b.UseDropDownInput();
                        b.UseShoelaceClearButton();
                        var items = b.NewCollection<string>();
                        b.Push(items, b.Get(model, x => x.SelectedItem));
                        b.Configure(x => x.items, items);
                        b.Configure(x => x.options, b.MapOptions(b.Get(model, x => x.ListItems), x => x, x => x));
                        b.Configure(x => x.load, b.Def((SyntaxBuilder b, Var<string> query, Var<Action<object>> callback) =>
                        {
                            b.CallExternal("DataSourceApi", "GetRemoteDataSource", query, b.Def((SyntaxBuilder b, Var<List<string>> remoteData) =>
                            {
                                var options = b.MapOptions(remoteData, x => x, x => x);
                                b.Call(callback, options.As<object>());
                            }));
                        }));
                        b.Comment("Configured load here");

                        b.OnEventAction("change", b.MakeAction((SyntaxBuilder b, Var<HomeModel> model, Var<string> value) =>
                        {
                            b.Set(model, x => x.SelectedItem, value);
                            return b.Clone(model);
                        }), "detail");

                        b.OnEventAction("load", b.MakeAction((SyntaxBuilder b, Var<HomeModel> model, Var<List<TomSelectOption>> options) =>
                        {
                            b.Set(model, x => x.ListItems, b.Get(options, x => x.Select(x => x.value)));
                            return b.Clone(model);
                        }), "detail");

                        //b.OnEventAction("type", b.MakeAction((SyntaxBuilder b, Var<HomeModel> model, Var<string> text) =>
                        //{
                        //    b.Log("from action", text);

                        //    return b.MakeStateWithEffects(
                        //        b.Clone(model),
                        //        b.MakeEffect(b.Def((SyntaxBuilder b, Var<HyperType.Dispatcher<HomeModel>> dispatcher) =>
                        //        {
                        //            var setRemoteDataSourceAction = b.MakeAction((SyntaxBuilder b, Var<HomeModel> model, Var<List<string>> remoteData) =>
                        //            {
                        //                b.Log("remoteData", remoteData);
                        //                b.Set(model, x => x.ListItems, remoteData);
                        //                return b.Clone(model);
                        //            });
                        //            b.Log("GetRemoteDataSource", text);
                        //            b.CallExternal("DataSourceApi", "GetRemoteDataSource", text, b.Def((SyntaxBuilder b, Var<List<string>> remoteData) =>
                        //            {
                        //                b.Dispatch(dispatcher, setRemoteDataSourceAction, remoteData);
                        //            }));
                        //        })));
                        //}), "detail");
                    }),
                    b.SlSelect(b=>
                    {
                        b.SetClearable();
                    },
                    b.Map(
                        b.Get(model, x=>x.ListItems),
                        (b, item) =>
                        {
                            return b.SlOption(b =>
                            {
                                b.SetValue(item);
                            },
                            b.Text(item));
                        })
                    ),
                    b.SlInput(b=>
                    {
                        b.SetClearable();
                        b.SetPlaceholder("Placeholder text here");
                        b.SetValue(b.Get(model, x => x.ContentText));
                        b.OnInputAction((SyntaxBuilder b, Var<HomeModel> model, Var<string> value) =>
                        {
                            b.Set(model, x => x.ContentText, value);
                            return b.Clone(model);
                        });
                    })),
                b.IonAlert(b =>
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

                    b.OnDidDismiss((SyntaxBuilder b, Var<HomeModel> model, Var<OverlayEventDetail> detail) =>
                    {
                        b.Log(b.Concat(b.Const("You clicked on role:"), b.Get(detail, x => x.role)));
                        return b.Clone(model);
                    });
                }),
                b.IonDatetimeButton(b =>
                {
                    b.SetDatetime("datetime");
                }),
                b.IonModal(b =>
                {

                },
                b.IonDatetime(b =>
                {
                    b.SetId("datetime");
                    b.OnIonChange((SyntaxBuilder b, Var<HomeModel> model, Var<DatetimeChangeEventDetail> selectedDate) =>
                    {
                        b.Log(selectedDate);
                        b.Set(model, x => x.ContentText, b.Get(selectedDate, x => x.value).As<string>());
                        return b.Clone(model);
                    });
                })),
                //b.IonList(
                //    b =>
                //    {
                //        b.SetDynamic(b.Props, Html.id, b.Const("list-id"));
                //    },
                //    b.Map(
                //        b.Get(model, x => x.ListItems),
                //        (b, item) =>
                //        b.IonItemSliding(
                //            b => { },
                //            b.IonItem(
                //                b => { },
                //                b.IonLabel(b => { }, b.T(item))),
                //            b.IonItemOptions(
                //                b => { },
                //                b.IonItemOption(b =>
                //                {
                //                    b.OnClickAction(b.MakeAction((SyntaxBuilder b, Var<HomeModel> model) =>
                //                    {
                //                        b.Remove(b.Get(model, x => x.ListItems), item);
                //                        b.CallOnObject(b.GetElementById(b.Const("list-id")), IonList.Method.CloseSlidingItems);

                //                        return b.Clone(model);
                //                    }));
                //                },
                //                b.T("Remove")))))),

                b.IonText(b => { }, b.Text(b.Get(model, x => x.ContentText))),
                b.SlSplitPanel(b =>
                {

                },
                b.HtmlDiv(
                    b =>
                    {
                        b.AddClass(" flex flex-row items-center justify-center");
                        b.SetSlot(SlSplitPanel.Slot.Start);
                    },
                    b.SlButton(b =>
                    {
                        b.SetDynamic(b.Props, Html.id, b.Const("alert-me"));
                        b.OnClickAction<HomeModel, SlButton>(OnAnyClick);
                    },
                    b.Text("Shoelace here!"))),
                b.HtmlDiv(
                    b =>
                    {
                        b.AddClass(" flex flex-row items-center justify-center");
                        b.SetSlot(SlSplitPanel.Slot.End);
                    },
                    b.IonButton(b =>
                    {
                        b.OnClickAction<HomeModel, IonButton>(OnAnyClick);
                    },
                    b.Text("Click me!")))
                )));
    }

    public static Var<HomeModel> OnAnyClick(SyntaxBuilder b, Var<HomeModel> model)
    {
        b.Log("clicked!");
        return b.Clone(model);
    }
}

public class HomeModel
{
    public class ToDoItem
    {
        public string Id { get; set; }
        public bool Done { get; set; }
        public string Action { get; set; } = "";
    }

    public List<ToDoItem> ToDoList { get; set; } = System.Linq.Enumerable.Range(0, 5).Select(x =>
        new ToDoItem()
        {
            Id = "action" + x,
            Action = "action" + x,
            Done = false
        }).ToList();

    public string ContentText { get; set; } = "Text here";
    public List<string> ListItems { get; set; } = new()
    {
        "Davina",
        "Margaretta",
        "Casey",
        "Kristine",
        "Lovell",
        "Athena",
        "Adriana",
        "Ora",
        "America",
        "James",
        "Leona",
        "Rosemarie",
        "Isabelle",
        "Ryan",
        "Sylvan"
    };
    public string SelectedItem { get; set; } = "aaab";

    public string SearchValue { get; set; } = string.Empty;
}

public class HomeHandler : Metapsi.Http.Get<Home>
{
    public override async Task<IResult> OnGet(CommandContext commandContext, HttpContext httpContext)
    {
        return Page.Result(new HomeModel()
        {
            ListItems = Program.FilterSource(string.Empty)
        });
    }
}


public class Home : Metapsi.Route.IGet { }