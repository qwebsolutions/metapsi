using Metapsi.Sqlite;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metapsi;

public static partial class ServiceDoc
{
    public class NewDoc<T> : IData
    {
        public T Doc { get; set; }
    }

    public class ChangedDoc<T> : IData
    {
        public T Old { get; set; }
        public T New { get; set; }
    }

    public class DeletedDoc<T> : IData
    {
        public T Doc { get; set; }
    }

    public class UnchangedDoc<T> : IData
    {
        public T Doc { get; set; }
    }

    public class SaveResult<T>
    {
        public NewDoc<T> New { get; set; }
        public ChangedDoc<T> Changed { get; set; }
        public UnchangedDoc<T> Unchanged { get; set; }
    }

    public class DeleteResult<T>
    {
        public T Doc { get; set; }
    }

    public class DocApi<T>
    {
        public Request<SaveResult<T>, T> Save { get; set; }
        public Request<List<T>> List { get; set; }
        public Request<T, string> Get { get; set; }
        public Request<DeleteResult<T>, string> Delete { get; set; }
    }

    public static DocApi<T> GetDocApi<T>()
    {
        return new DocApi<T>()
        {
            Save = new Request<SaveResult<T>, T>($"Save{typeof(T).Name}"),
            List = new Request<List<T>>($"List{typeof(T).Name}"),
            Get = new Request<T, string>($"Get{typeof(T).Name}"),
            Delete = new Request<DeleteResult<T>, string>($"Delete{typeof(T).Name}")
        };
    }

    public static Request<List<T>> Get<T, TProp>(this DocApi<T> docApi, System.Linq.Expressions.Expression<Func<T, TProp>> byProperty)
    {
        return new Request<List<T>>($"Get{typeof(T).Name}By{byProperty.PropertyName()}");
    }

    public static async Task RegisterDocBackendApi<T>(
        this WebServer.References webServer,
        string sqliteDbFullPath,
        System.Linq.Expressions.Expression<Func<T, string>> idProperty)
    {
        await CreateDocumentTableAsync<T>(sqliteDbFullPath);

        var notARealState = webServer.ApplicationSetup.AddBusinessState(new object());

        webServer.ApplicationSetup.MapEvent<ApplicationRevived>(e =>

        e.Using(notARealState, webServer.ImplementationGroup).EnqueueCommand(
            async (CommandContext commandContext, object _) =>
            {
                await CreateDocumentTableAsync<T>(sqliteDbFullPath);
            }));

        var getId = idProperty.Compile();

        var ig = webServer.ImplementationGroup;

        ig.MapRequest(GetDocApi<T>().Save,
            async (RequestRoutingContext rc, T input) =>
            {
                if (!TableCreated<T>())
                    throw new Exception($"Cannot save {typeof(T).FullName}, table is not yet created");

                var id = getId(input);
                if (string.IsNullOrEmpty(id))
                {
                    throw new Exception($"Cannot save {typeof(T).FullName}, id is empty");
                }

                var saveResult = await Db.WithCommit(
                    sqliteDbFullPath,
                    async (transaction) =>
                    {
                        var current = await transaction.Transaction.GetDocument(idProperty, id);
                        if (object.Equals(current, default(T)))
                        {
                            // The document did not exist before, it is new
                            await transaction.Transaction.SaveDocument(input, idProperty);

                            return new SaveResult<T>() { New = new NewDoc<T>() { Doc = input } };
                        }
                        else
                        {
                            var areEqual = Metapsi.Serialize.ToJson(current) == Metapsi.Serialize.ToJson(input);

                            if (areEqual)
                            {
                                return new SaveResult<T> { Unchanged = new UnchangedDoc<T> { Doc = input } };
                            }
                            else
                            {
                                await transaction.Transaction.SaveDocument(input, idProperty);
                                return new SaveResult<T> { Changed = new ChangedDoc<T>() { New = input, Old = current } };
                            }
                        }
                    });

                await rc.Using(notARealState, ig).EnqueueCommand(async (CommandContext commandContext, object _) =>
                {
                    if (saveResult.New != null)
                    {
                        commandContext.PostEvent(saveResult.New);
                    }
                    if (saveResult.Changed != null)
                    {
                        commandContext.PostEvent(saveResult.Changed);
                    }
                    if (saveResult.Unchanged != null)
                    {
                        commandContext.PostEvent(saveResult.Unchanged);
                    }
                });

                return saveResult;
            });

        ig.MapRequest(GetDocApi<T>().List, async (rc) =>
        {
            if (!TableCreated<T>())
                return new List<T>();

            return await Db.WithRollback(
                sqliteDbFullPath,
                async (transaction) =>
                {
                    return await transaction.Transaction.GetDocuments<T>();
                });
        });

        ig.MapRequest(GetDocApi<T>().Get, async (rc, id) =>
        {
            if (!TableCreated<T>())
                return default(T);

            return await Db.WithRollback(
                sqliteDbFullPath,
                async (transaction) =>
                {
                    return await transaction.Transaction.GetDocument<T, string>(idProperty, id);
                });
        });

        ig.MapRequest(GetDocApi<T>().Delete, async (rc, id) =>
        {
            if (!TableCreated<T>())
            {
                return new DeleteResult<T>();
            }

            var deleteResult = await Db.WithCommit(
                sqliteDbFullPath,
                async (transaction) =>
                {
                    var doc = await transaction.Transaction.GetDocument(idProperty, id);
                    await transaction.Transaction.DeleteDocuments(idProperty, id);
                    return new DeleteResult<T>() { Doc = doc };
                });

            await rc.Using(notARealState, ig).EnqueueCommand(async (CommandContext commandContext, object _) =>
            {
                commandContext.PostEvent(new DeletedDoc<T>() { Doc = deleteResult.Doc });
            });

            return deleteResult;
        });
    }

    public static void RegisterDocFrontendApi<T>(
        this Microsoft.AspNetCore.Routing.IEndpointRouteBuilder endpoint,
        WebServer.Authorization listAuthorization = WebServer.Authorization.Require,
        WebServer.Authorization getAuthorization = WebServer.Authorization.Require,
        WebServer.Authorization saveAuthorization = WebServer.Authorization.Require,
        WebServer.Authorization deleteAuthorization = WebServer.Authorization.Require)
    {
        var docApi = GetDocApi<T>();

        endpoint.MapRequest(
            docApi.Save,
            async (commandContext, httpContext, input) =>
            {
                return await commandContext.Do(docApi.Save, input);
            },
            saveAuthorization);

        endpoint.MapRequest(
            docApi.List,
            async (commandContext, httpContext) =>
            {
                return await commandContext.Do(docApi.List);
            },
            listAuthorization);

        endpoint.MapRequest(
            docApi.Get,
            async (commandContext, httpContext, id) =>
            {
                return await commandContext.Do(docApi.Get, id);
            },
            getAuthorization);

        endpoint.MapRequest(
            docApi.Delete,
            async (commandContext, httpContext, id) =>
            {
                return await commandContext.Do(docApi.Delete, id);
            },
            deleteAuthorization);
    }

    public static void RegisterDocFrontendRestApi<T>(
        this Microsoft.AspNetCore.Routing.IEndpointRouteBuilder endpoint)
    {
        var docApi = GetDocApi<T>();

        string typeName = typeof(T).Name;

        endpoint.MapGet(
            $"/{typeName}",
            async (CommandContext commandContext, HttpContext httpContext) =>
            {
                return await commandContext.Do(docApi.List);
            });

        endpoint.MapGet(
            $"/{typeName}/{{id}}",
            async (CommandContext commandContext, HttpContext httpContext, string id) =>
            {
                return await commandContext.Do(docApi.Get, id) is T item ? Results.Ok(item) : Results.NotFound();
            });

        endpoint.MapPost(
            $"/{typeName}",
            async (CommandContext commandContext, HttpContext httpContext, T item) =>
            {
                return await commandContext.Do(docApi.Save, item);
            });

        endpoint.MapDelete(
            $"/{typeName}/{{id}}",
            async (CommandContext commandContext, HttpContext httpContext, string id) =>
            {
                var deleteResult = await commandContext.Do(docApi.Delete, id);
                return deleteResult.Doc is T item ? Results.Ok(item) : Results.NotFound();
            });
    }

    public static string RegisterDocUiHandlers<T>(
        this Microsoft.AspNetCore.Routing.IEndpointRouteBuilder endpoint,
        System.Linq.Expressions.Expression<Func<T, string>> idProperty)
    {
        var typeEndpoint = endpoint.MapGroup(typeof(T).Name);

        typeEndpoint.MapGet("/list", async (CommandContext commandContext, HttpContext httpContext) =>
        {
            var list = await commandContext.Do(GetDocApi<T>().List);

            var descriptionAttributes = typeof(T).CustomAttributes.Where(x => x.AttributeType == typeof(DocDescriptionAttribute));

            var withoutOrder = descriptionAttributes.Where(x => x.ConstructorArguments.Count == 1);
            var withOrder = descriptionAttributes.Where(x => x.ConstructorArguments.Count == 2).OrderBy(x => (Int32)x.ConstructorArguments[1].Value);

            var orderedAttributes = new List<System.Reflection.CustomAttributeData>();
            orderedAttributes.AddRange(withOrder);
            orderedAttributes.AddRange(withoutOrder);

            StringBuilder descriptionBuilder = new StringBuilder();

            foreach (var descriptionAttribute in orderedAttributes)
            {
                var constructor = descriptionAttribute.ConstructorArguments.Where(x => x.ArgumentType == typeof(string)).FirstOrDefault();
                descriptionBuilder.AppendLine(constructor.Value.ToString());
            }

            return Page.Result(
                new ListDocsPageModel<T>()
                {
                    ServerModel = new ServerModel<T>()
                    {
                        IdProperty = idProperty,
                        DescriptionHtml = descriptionBuilder.ToString(),
                    },
                    ClientModel = new ListDocsPage<T>()
                    {
                        Documents = list
                    }
                });
        });

        return typeof(T).Name + "/list";
    }

    public class ListDocsPage<T>
    {
        public List<T> Documents { get; set; } = new List<T>();
        public T EditDocument { get; set; }
        public string SummaryHtml { get; set; }
    }
}