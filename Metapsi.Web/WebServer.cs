using Metapsi.Ui;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.StaticFiles;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace Metapsi
{
    public static class WebServer
    {
        public static HashSet<string> WebRootPaths { get; set; } = new HashSet<string>();

        public class References
        {
            public ApplicationSetup ApplicationSetup { get; set; }
            public WebApplication WebApplication { get; set; }
            public ImplementationGroup ImplementationGroup { get; set; }
            public string WebRootPath { get; set; }
            public int Port { get; set; }
            public Dictionary<string, byte[]> StaticFiles { get; set; } = new Dictionary<string, byte[]>();
            public Dictionary<Type, Delegate> Renderers { get; set; } = new();
        }

        public enum SwaggerTryout
        {
            Allow,
            Block
        }

        public enum Authorization
        {
            Require,
            Public
        }

        public class HttpRequestEvent : IData
        {

        }

        public static IServiceCollection AddMetapsiCommandContext(
            this IServiceCollection services,
            ApplicationSetup setup,
            ImplementationGroup ig)
        {
            return services.AddScoped<Metapsi.CommandContext>(provider =>
            {
                var cc = new Metapsi.CommandContext(
                    setup,
                    ig,
                    new Metapsi.ExecutionQueue(setup, Guid.NewGuid().ToString(), new object()),
                    new CallStack(new HttpRequestEvent()));
                return cc;
            });
        }

        public static async Task RunAsync(this References webServerReferences, int port)
        {
            webServerReferences.WebApplication.Urls.Add($"http://*:{port}");
            await webServerReferences.WebApplication.RunAsync();
        }

        public static References AddWebServer(
            this ApplicationSetup setup,
            ImplementationGroup ig,
            int port = 0,
            string webRootPath = null,
            Action<WebApplicationBuilder> buildServices = null,
            Action<WebApplication> buildApp = null)
        {
            var references = new References()
            {
                ApplicationSetup = setup,
                ImplementationGroup = ig
            };


            WebApplicationBuilder builder = null;

            //IdentityModelEventSource.ShowPII = true;

            if (string.IsNullOrWhiteSpace(webRootPath))
            {
                builder = WebApplication.CreateBuilder();
            }
            else
            {
                builder = WebApplication.CreateBuilder(new WebApplicationOptions() { WebRootPath = webRootPath });
                //builder = WebApplication.CreateBuilder();
                WebRootPaths.Add(webRootPath);
            }

            builder.Services.AddWindowsService();
            builder.Services.AddSystemd();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddMetapsiCommandContext(setup, ig);
            builder.Services.ConfigureHttpJsonOptions(options =>
            {
                options.SerializerOptions.PropertyNamingPolicy = null;
                options.SerializerOptions.WriteIndented = true;
                options.SerializerOptions.PropertyNameCaseInsensitive = true;
            });

            if (buildServices != null)
                buildServices(builder);

            var app = builder.Build();

            app.Use(async (context, next) =>
            {
                context.Items["Metapsi.Renderers"] = references.Renderers;
                await next(context);
            });

            // some JS files need path updates
            app.Use(async (context, next) =>
            {
                if (!string.IsNullOrWhiteSpace(context.GetHostedRootPath()) && context.Request.Path.Value.EndsWith(".js"))
                {
                    string fileWebPath = context.Request.Path.Value;
                    fileWebPath = fileWebPath.Replace(context.GetHostedRootPath() + "/", string.Empty);
                    var fileSegments = new List<string>();
                    fileSegments.Add(webRootPath);
                    fileSegments.AddRange(fileWebPath.Split("/", StringSplitOptions.RemoveEmptyEntries).ToArray());
                    string filePath = System.IO.Path.Combine(fileSegments.ToArray());
                    if (!File.Exists(filePath))
                    {
                        context.Response.StatusCode = 404;
                        return;
                    }
                    var allContent = await System.IO.File.ReadAllTextAsync(filePath);
                    allContent = allContent.Replace("/static/", context.GetHostedRootPath() + "/static/");
                    context.Response.ContentType = "text/javascript";
                    await context.Response.WriteAsync(allContent);
                    return;
                }
                // if not a js file served through proxy just move on
                await next(context);
            });

            HashSet<string> staticFileExtensions = new HashSet<string>
            {
                ".js",
                ".css",
                ".ico"
            };

            // Embedded static files
            app.Use(async (context, next) =>
            {
                var handled = false;

                if (!string.IsNullOrEmpty(context.Request.Path))
                {
                    var fileName = context.Request.Path.Value.ToLower().Trim('/');
                    if (references.StaticFiles.ContainsKey(fileName))
                    {
                        var contentType = GetMimeTypeForFileExtension(fileName);

                        switch (contentType)
                        {
                            case "text/html":
                                {
                                    context.Response.StatusCode = StatusCodes.Status404NotFound;
                                    handled = true;
                                }
                                break;
                            default:
                                {
                                    byte[] bytes = references.StaticFiles[fileName];

#if !DEBUG
                                    context.Response.Headers.CacheControl = new[] { "public", $"max-age={TimeSpan.FromDays(100).TotalSeconds}" };
#endif
                                    context.Response.ContentType = contentType;
                                    await context.Response.BodyWriter.WriteAsync(bytes);
                                    handled = true;
                                }
                                break;
                        }
                    }
                }
                if (!handled)
                    await next(context);
            });

            app.UseStaticFiles();

            // If no static middleware found the file, stop now!
            app.Use(async (context, next) =>
            {
                // Except if swagger file ...

                if (!context.Request.Path.Value.ToLower().Contains("swagger"))
                {
                    foreach (string extension in staticFileExtensions)
                    {
                        if (context.Request.Path.Value.EndsWith(extension))
                        {
                            context.Response.StatusCode = 404;
                            return;
                        }
                    }
                }
                await next(context);
            });

            app.UseForwardedHeaders();
            app.UseHttpLogging();

            MapServerAction(app.MapGroup("api"));

            if (buildApp != null)
                buildApp(app);

            // Always close web server when shutting down application
            setup.MapEvent<ApplicationIsShuttingDown>(e =>
            {
                app.StopAsync();
            });

            if (port != 0)
            {
                app.Urls.Add($"http://*:{port}");

                setup.MapEvent<ApplicationRevived>(e =>
                {
                    app.RunAsync();
                });
            }

            references.WebApplication = app;
            return references;
        }

        public static T Unescape<T>(T segment)
        {
            if (typeof(T) == typeof(string))
            {
                // Just the forward slash, the other characters are (hopefully) unescaped by the api routing
                return (T)(object)segment.ToString().Replace("%2", "/");
            }
            return segment;
        }

        public static string FindPath(string relativePath)
        {
            foreach (var webRoot in WebRootPaths)
            {
                var absolutePath = Metapsi.RelativePath.SearchUpfolder(webRoot, relativePath);
                if (!string.IsNullOrEmpty(absolutePath))
                    return absolutePath;
            }

            throw new Exception($"Relative path not found: {relativePath}");
        }

        public static void ThrowSwaggerException(HttpContext httpContext, SwaggerTryout tryout)
        {
            if (tryout == SwaggerTryout.Block && IsSwaggerUi(httpContext))
                throw new NotSupportedException("This method performs permanent changes so it cannot be tested");
        }

        public static bool IsSwaggerUi(HttpContext httpContext)
        {
            var referer = httpContext.Request.Headers["Referer"];
            if (string.IsNullOrEmpty(referer))
                return false;

            var isSwaggerUi = referer.Any(x => x.Contains("/swagger"));
            return isSwaggerUi;
        }

        public static string Path(MethodInfo methodInfo, object parameter = null)
        {
            var methodPath = $"/{methodInfo.DeclaringType.Name.ToLowerInvariant()}/{methodInfo.Name.ToLowerInvariant()}";

            if (parameter != null)
            {
                methodPath += $"/{parameter}";
            }

            return methodPath.Replace("//", "/");
        }

        public static string RelativePath(MethodInfo methodInfo, object parameter = null)
        {
            var methodPath = $"{methodInfo.DeclaringType.Name.ToLowerInvariant()}/{methodInfo.Name.ToLowerInvariant()}";

            if (parameter != null)
            {
                methodPath += $"/{parameter}";
            }

            return methodPath.Replace("//", "/");
        }

        // Same functions, just that I always forget the name. Is it Url? Or is it Path? It is both.
        public static string Url<TResult>(Func<CommandContext, HttpContext, TResult> handler)
        {
            return Path(handler.Method);
        }

        public static string Url<TRoute>() where TRoute : Route.IGet
        {
            var nestedTypeNames = typeof(TRoute).NestedTypeNames();
            string path = string.Join("/", nestedTypeNames);
            return $"/{path}";
        }

        public static string Url<TRoute, TParam>(TParam param) where TRoute : Route.IGet<TParam>
        {
            var nestedTypeNames = typeof(TRoute).NestedTypeNames();
            string path = string.Join("/", nestedTypeNames);
            return $"/{path}/{param}";
        }

        public static string Url<TResult, TArg>(Func<CommandContext, HttpContext, TArg, TResult> handler, TArg arg)
        {
            return Path(handler.Method, arg);
        }

        public static string Path<TResult>(Func<CommandContext, HttpContext, TResult> handler)
        {
            return Path(handler.Method);
        }
        public static string Path<TResult, TArg>(Func<CommandContext, HttpContext, TArg, TResult> handler, TArg arg)
        {
            return Path(handler.Method, arg);
        }

        public static bool IsSignedIn(this System.Security.Claims.ClaimsPrincipal userClaims)
        {
            if (userClaims == null)
                return false;

            return userClaims.Identity.IsAuthenticated;
        }

        public static void RegisterStaticFiles(this WebServer.References references, Assembly assembly)
        {
            var allResources = assembly.GetManifestResourceNames();

            foreach (var r in allResources)
            {
                var info = assembly.GetManifestResourceInfo(r);
                var stream = assembly.GetManifestResourceStream(r);
                using (var ms = new MemoryStream())
                {
                    stream.CopyTo(ms);
                    references.StaticFiles[r.ToLower()] = ms.ToArray();
                }
            }
        }

        public static string GetMimeTypeForFileExtension(string filePath)
        {
            const string DefaultContentType = "application/octet-stream";

            var provider = new FileExtensionContentTypeProvider();

            if (!provider.TryGetContentType(filePath, out string contentType))
            {
                contentType = DefaultContentType;
            }

            return contentType;
        }

        public static void RegisterGetHandler<THandler, TRoute>(this IEndpointRouteBuilder routeBuilder)
            where THandler : Http.Get<TRoute>, new()
            where TRoute : Route.IGet
        {
            var type = typeof(THandler).BaseType.GenericTypeArguments.FirstOrDefault();
            if (type != null)
            {
                var nestedTypeNames = type.NestedTypeNames();
                string path = string.Join("/", nestedTypeNames);

                var get = new THandler().OnGet;

                routeBuilder.MapGet(path, new THandler().OnGet);
            }
        }

        public static void RegisterGetHandler<THandler, TRoute, T1>(this IEndpointRouteBuilder routeBuilder)
            where THandler : Http.Get<TRoute, T1>, new()
            where TRoute : Route.IGet<T1>
        {
            var type = typeof(THandler).BaseType.GenericTypeArguments.FirstOrDefault();
            if (type != null)
            {
                var nestedTypeNames = type.NestedTypeNames();
                string nestedPath = string.Join("/", nestedTypeNames);

                var get = new THandler().OnGet;

                var requestPath = $"{nestedPath}/{{{DataParametersPath(get)}}}";

                routeBuilder.MapGet(requestPath, get);
            }
        }

        public static void RegisterPostHandler<THandler, TRoute, T1>(this IEndpointRouteBuilder routeBuilder)
            where THandler : Http.Post<TRoute, T1>, new()
            where TRoute : Route.IPost<T1>
        {
            var type = typeof(THandler).BaseType.GenericTypeArguments.FirstOrDefault();
            if (type != null)
            {
                var nestedTypeNames = type.NestedTypeNames();
                string nestedPath = string.Join("/", nestedTypeNames);

                routeBuilder.MapPost(nestedPath, async (CommandContext commandContext, HttpContext httpContext) =>
                {
                    T1 payload = await httpContext.Payload<T1>();

                    var post = await new THandler().OnPost(commandContext, httpContext, payload);
                    return post;
                });
            }
        }

        private static List<ParameterInfo> DataParameters(Delegate d)
        {
            var dataParameters = d.Method.GetParameters().Where(x => x.ParameterType != typeof(CommandContext) && x.ParameterType != typeof(HttpContext));
            return dataParameters.ToList();
        }

        private static List<string> DataParameterNames(Delegate d)
        {
            return DataParameters(d).Select(x => x.Name).ToList();
        }

        private static string DataParametersPath(Delegate d)
        {
            return string.Join("/", DataParameterNames(d));
        }

        public static void RegisterPageBuilder<TModel>(this References references, Func<TModel, string> builder)
        {
            references.Renderers[typeof(TModel)] = builder;
        }

        public static void RegisterPageBuilder<TRenderer, TModel>(this References references)
            where TRenderer : IPageTemplate<TModel>, new()
        {
            references.Renderers[typeof(TModel)] = new TRenderer().Render;
        }

        public static void MapServerAction(IEndpointRouteBuilder apiEndpoint)
        {
            apiEndpoint.MapRequest(Metapsi.Ui.ServerActionEndpoint.ServerAction, async (CommandContext commandContext, HttpContext httpContext, ServerActionInput input) =>
            {
                try
                {
                    var handlerClass = Type.GetType(input.QualifiedHandlerClass);
                    var method = handlerClass.GetMethod(
                        input.HandlerMethod,
                        System.Reflection.BindingFlags.Public |
                        System.Reflection.BindingFlags.NonPublic |
                        System.Reflection.BindingFlags.Static |
                        System.Reflection.BindingFlags.Instance);

                    var methodParameters = method.GetParameters();

                    if (!methodParameters.Any())
                        throw new NotSupportedException("Server action must receive the model as parameter");


                    var stateParameter = methodParameters.FirstOrDefault(x => x.ParameterType != typeof(CommandContext) && x.ParameterType != typeof(HttpContext));
                    if (stateParameter == null)
                    {
                        throw new NotSupportedException("Server action must receive the model as parameter");
                    }

                    var payloadParameter = methodParameters.FirstOrDefault(
                        x => x.ParameterType != typeof(CommandContext)
                        && x.ParameterType != typeof(HttpContext)
                        && x.ParameterType != stateParameter.ParameterType);

                    List<object> invokeParameters = new();


                    foreach (var parameterInfo in methodParameters)
                    {
                        if (parameterInfo.ParameterType == typeof(CommandContext))
                        {
                            invokeParameters.Add(commandContext);
                        }

                        if (parameterInfo.ParameterType == typeof(HttpContext))
                        {
                            invokeParameters.Add(httpContext);
                        }

                        if (parameterInfo == stateParameter)
                        {
                            var stateObject = Metapsi.Serialize.FromJson(parameterInfo.ParameterType, input.SerializedModel);
                            invokeParameters.Add(stateObject);
                        }

                        if (parameterInfo == payloadParameter)
                        {
                            var payloadObject = Metapsi.Serialize.FromJson(parameterInfo.ParameterType, input.SerializedPayload);
                            invokeParameters.Add(payloadObject);
                        }
                    }

                    object result;

                    if (method.IsStatic)
                    {
                        result = method.Invoke(null, invokeParameters.ToArray());
                    }
                    else
                    {
                        var invokeInstance = Activator.CreateInstance(handlerClass);
                        result = method.Invoke(invokeInstance, invokeParameters.ToArray());
                    }

                    var isAsync = method.ReturnType.Namespace == "System.Threading.Tasks";

                    if (isAsync)
                        result = await (dynamic)result;

                    var serializedResult = Metapsi.Serialize.ToJson(result);

                    return new Metapsi.Ui.ServerActionResponse()
                    {
                        SerializedModel = serializedResult
                    };
                }
                catch (Exception ex)
                {
                    return new Metapsi.Ui.ServerActionResponse()
                    {
                        ResultCode = ApiResultCode.Error,
                        ErrorMessage = ex.Message
                    };
                }
            },
            WebServer.Authorization.Public);
        }
    }

}