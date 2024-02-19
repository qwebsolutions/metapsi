using Metapsi.Hyperapp;
using Metapsi.Shoelace;
using Metapsi.Syntax;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Metapsi
{
    public static class Register
    {
        public static Request<T> InitDocument<T>() => new Request<T>($"{nameof(InitDocument)}/{typeof(T).Name}");
        public static Request<List<T>> ListDocuments<T>() => new Request<List<T>>($"{nameof(ListDocuments)}/{typeof(T).Name}");

        internal static List<System.Type> DocTypes { get; set; } = new();

        public static async Task<string> RegisterDocsUi<T>(
            this Metapsi.WebServer.References webServer,
            string dbPath,
            Func<CommandContext, Task<List<T>>> listDocuments = null)
            where T : Metapsi.ServiceDoc.IDocument, new()
        {
            return await RegisterDocsUi<T>(webServer, dbPath, x => x.Id, async (cc) => new T(), listDocuments);
        }

        public static async Task<string> RegisterDocsUi<T>(
            this Metapsi.WebServer.References webServer,
            string dbPath,
            System.Linq.Expressions.Expression<Func<T,string>> idProperty,
            Func<CommandContext, Task<T>> createDocument,
            Func<CommandContext, Task<List<T>>> listDocuments = null)
        { 
            if (listDocuments == null) listDocuments = async (cc) => await cc.Do(ServiceDoc.GetDocApi<T>().List);

            DocTypes.Add(typeof(T));

            await webServer.RegisterDocBackendApi<T>(dbPath, idProperty);
            var apiRoute = webServer.WebApplication.MapGroup("api");
            apiRoute.RegisterDocFrontendApi<T>(WebServer.Authorization.Public, WebServer.Authorization.Public, WebServer.Authorization.Public, WebServer.Authorization.Public);
            var restRoute = webServer.WebApplication.MapGroup("rest");
            restRoute.RegisterDocFrontendRestApi<T>();

            var listUrl = webServer.WebApplication.RegisterDocUiHandlers<T>(idProperty);

            webServer.RegisterRenderer<ListDocsPageModel<T>, ListDocsRenderer<T>>();
            webServer.RegisterStaticFiles(typeof(SyntaxBuilder).Assembly);
            webServer.RegisterStaticFiles(typeof(Hyperapp.IVNode).Assembly);
            webServer.RegisterStaticFiles(typeof(Metapsi.Dom.DomElement).Assembly);
            webServer.RegisterStaticFiles(typeof(Register).Assembly);

            var noActualState = webServer.ApplicationSetup.AddBusinessState(new object());

            var apiGroup = webServer.WebApplication.MapGroup("api");
            apiGroup.MapRequest(
                InitDocument<T>(),
                async (CommandContext commandContext, HttpContext httpContext) =>
                {
                    return await createDocument(commandContext);
                }, WebServer.Authorization.Public);

            apiGroup.MapRequest(
                ListDocuments<T>(),
                async (CommandContext commandContext, HttpContext httpContext) =>
                {
                    return await listDocuments(commandContext);
                }, 
                WebServer.Authorization.Public);

            //webServer.ApplicationSetup.MapEvent<ApplicationRevived>(e =>
            //{
            //    e.Using(noActualState, webServer.ImplementationGroup).EnqueueCommand(
            //        async (CommandContext commandContext, object _state) =>
            //        {
            //            var list = await commandContext.Do(NoSqlDoc.GetDocApi<T>().List);
            //            commandContext.PostEvent(new NoSqlDoc.StartupListLoaded<T>()
            //            {
            //                Docs = list
            //            });
            //        });
            //});

            return listUrl;
        }

        public static string RegisterDocsOverview(
            this Metapsi.WebServer.References webServer)
        {
            webServer.RegisterRenderer<DocsOverviewModel, OverviewDocsRenderer>();
            webServer.WebApplication.RegisterGetHandler<OverviewHandler, Docs.Overview>();

            return WebServer.Url<Docs.Overview>();
        }
    }

    public class Docs
    {
        public class Overview : Metapsi.Route.IGet
        {

        }
    }

    public class OverviewHandler : Http.Get<Docs.Overview>
    {
        public override async Task<IResult> OnGet(CommandContext commandContext, HttpContext httpContext)
        {
            var docsOverviewModel = new DocsOverviewModel();
            foreach (var type in Register.DocTypes)
            {
                docsOverviewModel.DocServices.Add(new DocsService()
                {
                    DocTypeName = type.Name,
                    ListUrl = "/" + type.Name + "/list"
                });
            }

            return Page.Result(docsOverviewModel);
        }
    }

    public class DocsService
    {
        public string DocTypeName { get; set; } = string.Empty;
        public int Count { get; set; } = 0;
        public string ListUrl { get; set; } = string.Empty;
    }

    public class DocsOverviewModel
    {
        public List<DocsService> DocServices { get; set; } = new();
    }

    public class OverviewDocsRenderer : Hyperapp.HyperPage<DocsOverviewModel>
    {
        public override Var<IVNode> OnRender(LayoutBuilder b, Var<DocsOverviewModel> model)
        {
            return b.Div(
                "flex flex-row flex-wrap gap-2",
                b.Map(b.Get(model, x => x.DocServices), (b, service) =>
                {
                    return b.H(
                        "a",
                        (b, props) =>
                        {
                            b.SetDynamic(props, Html.href, b.Get(service, x => x.ListUrl));
                        },
                        b.SlNode(
                            "sl-card",
                            (b, props) =>
                            {

                            },
                            b.T(b.Get(service, x => x.DocTypeName))));
                }));
        }
    }
}