using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Metapsi
{

    internal class RenderersService
    {
        public Dictionary<Type, Delegate> Renderers { get; set; } = new();
    }

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
        }

        public class HttpRequestEvent : IData
        {
            public string Path { get; set; }
        }

        public static IServiceCollection AddMetapsiCommandContext(
            this IServiceCollection services,
            ApplicationSetup setup,
            ImplementationGroup ig)
        {
            return services.AddScoped<Metapsi.CommandContext>(provider =>
            {
                var httpAccesor = provider.GetRequiredService<IHttpContextAccessor>();
                var cc = new Metapsi.CommandContext(
                    setup,
                    ig,
                    new Metapsi.ExecutionQueue(setup, Guid.NewGuid().ToString(), new object()),
                    new CallStack(new HttpRequestEvent()
                    {
                        Path = httpAccesor.HttpContext.Request.Path
                    }));
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

            //TODO: This should not be default
            builder.Services.AddCors(b =>
            {
                b.AddPolicy("allow-everything", b =>
                {
                    b.AllowAnyHeader();
                    b.AllowAnyMethod();
                    b.AllowAnyOrigin();
                });
            });

            builder.Host.ConfigureHostOptions(options =>
            {
                options.ShutdownTimeout = TimeSpan.FromSeconds(30);
            });

            builder.Services.AddSingleton<RenderersService>();
            builder.Services.AddHttpContextAccessor();

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

            app.UseCors("allow-everything");

            //app.Use(async (context, next) =>
            //{
            //    context.Items["Metapsi.Renderers"] = references.Renderers;
            //    await next(context);
            //});

            //// some JS files need path updates
            //app.Use(async (context, next) =>
            //{
            //    if (!string.IsNullOrWhiteSpace(context.GetHostedRootPath()) && context.Request.Path.Value.EndsWith(".js"))
            //    {
            //        string fileWebPath = context.Request.Path.Value;
            //        fileWebPath = fileWebPath.Replace(context.GetHostedRootPath() + "/", string.Empty);
            //        var fileSegments = new List<string>();
            //        fileSegments.Add(webRootPath);
            //        fileSegments.AddRange(fileWebPath.Split("/", StringSplitOptions.RemoveEmptyEntries).ToArray());
            //        string filePath = System.IO.Path.Combine(fileSegments.ToArray());
            //        if (!File.Exists(filePath))
            //        {
            //            context.Response.StatusCode = 404;
            //            return;
            //        }
            //        var allContent = await System.IO.File.ReadAllTextAsync(filePath);
            //        allContent = allContent.Replace("/static/", context.GetHostedRootPath() + "/static/");
            //        context.Response.ContentType = "text/javascript";
            //        await context.Response.WriteAsync(allContent);
            //        return;
            //    }
            //    // if not a js file served through proxy just move on
            //    await next(context);
            //});

            HashSet<string> staticFileExtensions = new HashSet<string>
            {
                ".js",
                ".css",
                ".ico"
            };

            app.UseEmbeddedFiles();

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

            //references.RegisterPageBuilder<System.Exception>(DefaultExceptionHandler);

            return references;
        }

        public static string DefaultExceptionHandler(System.Exception ex)
        {
            Console.WriteLine(ex);
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("<html>");
            builder.AppendLine("<head><title>Error</title></head>");
            builder.AppendLine($"<body><pre>{ex}</pre></body>");
            builder.AppendLine("</html>");
            return builder.ToString();
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

        //public static void ThrowSwaggerException(HttpContext httpContext, SwaggerTryout tryout)
        //{
        //    if (tryout == SwaggerTryout.Block && IsSwaggerUi(httpContext))
        //        throw new NotSupportedException("This method performs permanent changes so it cannot be tested");
        //}

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

        //public static string Url<TRoute>() where TRoute : Route.IGet
        //{
        //    var nestedTypeNames = typeof(TRoute).NestedTypeNames();
        //    string path = string.Join("/", nestedTypeNames);
        //    return $"/{path}";
        //}

        //public static string Url<TRoute, TParam>(TParam param) where TRoute : Route.IGet<TParam>
        //{
        //    var nestedTypeNames = typeof(TRoute).NestedTypeNames();
        //    string path = string.Join("/", nestedTypeNames);
        //    return $"/{path}/{param}";
        //}

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



        //public static void RegisterGetHandler<THandler, TRoute>(this IEndpointRouteBuilder routeBuilder)
        //    where THandler : Http.Get<TRoute>, new()
        //    where TRoute : Route.IGet
        //{
        //    var type = typeof(THandler).BaseType.GenericTypeArguments.FirstOrDefault();
        //    if (type != null)
        //    {
        //        var nestedTypeNames = type.NestedTypeNames();
        //        string path = string.Join("/", nestedTypeNames);

        //        var get = async (CommandContext commandContext, HttpContext httpContext) =>
        //        {
        //            try
        //            {
        //                return await new THandler().OnGet(commandContext, httpContext);
        //            }
        //            catch (Exception ex)
        //            {
        //                Console.WriteLine(ex);
        //                return Page.Result(ex);
        //            }
        //        };

        //        routeBuilder.MapGet(path, get);
        //    }
        //}

        //public static void RegisterGetHandler<THandler, TRoute, T1>(this IEndpointRouteBuilder routeBuilder)
        //    where THandler : Http.Get<TRoute, T1>, new()
        //    where TRoute : Route.IGet<T1>
        //{
        //    var type = typeof(THandler).BaseType.GenericTypeArguments.FirstOrDefault();
        //    if (type != null)
        //    {
        //        var nestedTypeNames = type.NestedTypeNames();
        //        string nestedPath = string.Join("/", nestedTypeNames);

        //        var get = async (CommandContext commandContext, HttpContext httpContext, T1 p1) =>
        //        {
        //            try
        //            {
        //                return await new THandler().OnGet(commandContext, httpContext, p1);
        //            }
        //            catch (Exception ex)
        //            {
        //                return Page.Result(ex);
        //            }
        //        };

        //        var requestPath = $"{nestedPath}/{{{DataParametersPath(get)}}}";

        //        routeBuilder.MapGet(requestPath, get);
        //    }
        //}

        //public static void RegisterGetHandler<THandler, TRoute, T1, T2>(this IEndpointRouteBuilder routeBuilder)
        //    where THandler : Http.Get<TRoute, T1, T2>, new()
        //    where TRoute : Route.IGet<T1, T2>
        //{
        //    var type = typeof(THandler).BaseType.GenericTypeArguments.FirstOrDefault();
        //    if (type != null)
        //    {
        //        var nestedTypeNames = type.NestedTypeNames();
        //        string nestedPath = string.Join("/", nestedTypeNames);

        //        var get = async (CommandContext commandContext, HttpContext httpContext, T1 p1, T2 p2) =>
        //        {
        //            try
        //            {
        //                return await new THandler().OnGet(commandContext, httpContext, p1, p2);
        //            }
        //            catch (Exception ex)
        //            {
        //                return Page.Result(ex);
        //            }
        //        };

        //        var paramNames = DataParameterNames(get);
        //        var paramsPath = string.Join("/", paramNames.Select(x => $"{{{x}}}"));

        //        var requestPath = $"{nestedPath}/{paramsPath}";

        //        routeBuilder.MapGet(requestPath, get);
        //    }
        //}

        //public static void RegisterPostHandler<THandler, TRoute, T1>(this IEndpointRouteBuilder routeBuilder)
        //    where THandler : Http.Post<TRoute, T1>, new()
        //    where TRoute : Route.IPost<T1>
        //{
        //    var type = typeof(THandler).BaseType.GenericTypeArguments.FirstOrDefault();
        //    if (type != null)
        //    {
        //        var nestedTypeNames = type.NestedTypeNames();
        //        string nestedPath = string.Join("/", nestedTypeNames);

        //        routeBuilder.MapPost(nestedPath, async (CommandContext commandContext, HttpContext httpContext) =>
        //        {
        //            try
        //            {
        //                T1 payload = await httpContext.Payload<T1>();

        //                var post = await new THandler().OnPost(commandContext, httpContext, payload);
        //                return post;
        //            }
        //            catch (Exception ex)
        //            {
        //                return Page.Result(ex);
        //            }
        //        });
        //    }
        //}

        //private static List<ParameterInfo> DataParameters(Delegate d)
        //{
        //    var dataParameters = d.Method.GetParameters().Where(x => x.ParameterType != typeof(CommandContext) && x.ParameterType != typeof(HttpContext));
        //    return dataParameters.ToList();
        //}

        //private static List<string> DataParameterNames(Delegate d)
        //{
        //    return DataParameters(d).Select(x => x.Name).ToList();
        //}

        //private static string DataParametersPath(Delegate d)
        //{
        //    return string.Join("/", DataParameterNames(d));
        //}

        public static void UseRenderer<TModel>(this IEndpointRouteBuilder uiEndpoint, Func<TModel, string> renderer)
        {
            uiEndpoint.ServiceProvider.GetService<RenderersService>().Renderers[typeof(TModel)] = renderer;
        }

        //public static void MapServerAction(IEndpointRouteBuilder apiEndpoint)
        //{
        //    apiEndpoint.MapRequest(Metapsi.Ui.ServerActionEndpoint.ServerAction, async (CommandContext commandContext, HttpContext httpContext, ServerActionInput input) =>
        //    {
        //        try
        //        {
        //            var handlerClass = Type.GetType(input.QualifiedHandlerClass);
        //            var method = handlerClass.GetMethod(
        //                input.HandlerMethod,
        //                System.Reflection.BindingFlags.Public |
        //                System.Reflection.BindingFlags.NonPublic |
        //                System.Reflection.BindingFlags.Static |
        //                System.Reflection.BindingFlags.Instance);

        //            var methodParameters = method.GetParameters();

        //            if (!methodParameters.Any())
        //                throw new NotSupportedException("Server action must receive the model as parameter");


        //            var stateParameter = methodParameters.FirstOrDefault(x => x.ParameterType != typeof(CommandContext) && x.ParameterType != typeof(HttpContext));
        //            if (stateParameter == null)
        //            {
        //                throw new NotSupportedException("Server action must receive the model as parameter");
        //            }

        //            var payloadParameter = methodParameters.FirstOrDefault(
        //                x => x.ParameterType != typeof(CommandContext)
        //                && x.ParameterType != typeof(HttpContext)
        //                && x.ParameterType != stateParameter.ParameterType);

        //            List<object> invokeParameters = new();


        //            foreach (var parameterInfo in methodParameters)
        //            {
        //                if (parameterInfo.ParameterType == typeof(CommandContext))
        //                {
        //                    invokeParameters.Add(commandContext);
        //                }

        //                if (parameterInfo.ParameterType == typeof(HttpContext))
        //                {
        //                    invokeParameters.Add(httpContext);
        //                }

        //                if (parameterInfo == stateParameter)
        //                {
        //                    var stateObject = Metapsi.Serialize.FromJson(parameterInfo.ParameterType, input.SerializedModel);
        //                    invokeParameters.Add(stateObject);
        //                }

        //                if (parameterInfo == payloadParameter)
        //                {
        //                    var payloadObject = Metapsi.Serialize.FromJson(parameterInfo.ParameterType, input.SerializedPayload);
        //                    invokeParameters.Add(payloadObject);
        //                }
        //            }

        //            object result;

        //            if (method.IsStatic)
        //            {
        //                result = method.Invoke(null, invokeParameters.ToArray());
        //            }
        //            else
        //            {
        //                var invokeInstance = Activator.CreateInstance(handlerClass);
        //                result = method.Invoke(invokeInstance, invokeParameters.ToArray());
        //            }

        //            var isAsync = method.ReturnType.Namespace == "System.Threading.Tasks";

        //            if (isAsync)
        //                result = await (dynamic)result;

        //            var serializedResult = Metapsi.Serialize.ToJson(result);

        //            return new Metapsi.Ui.ServerActionResponse()
        //            {
        //                SerializedModel = serializedResult
        //            };
        //        }
        //        catch (Exception ex)
        //        {
        //            return new Metapsi.Ui.ServerActionResponse()
        //            {
        //                ResultCode = ApiResultCode.Error,
        //                ErrorMessage = ex.Message
        //            };
        //        }
        //    },
        //    WebServer.Authorization.Public);
        //}
    }

}