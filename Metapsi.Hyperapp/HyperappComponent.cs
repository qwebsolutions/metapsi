//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Builder;
//using Microsoft.AspNetCore.Hosting;
//using Microsoft.Extensions.DependencyInjection;
//using Microsoft.Extensions.Hosting;
//using Microsoft.Extensions.FileProviders;
//using Microsoft.Extensions.DependencyInjection.Extensions;
//using Microsoft.AspNetCore.Http;
//using System;
//using Metapsi;
//using Metapsi.Syntax;
//using System.Reflection;
//using Microsoft.AspNetCore.Routing;
//using Microsoft.AspNetCore.Authorization;
//using static Metapsi.WebServer;
//using System.Net.Http;
//using System.Diagnostics;
//using System.Text;
//using Metapsi.JavaScript;

//namespace Metapsi.Hyperapp
//{
//    public static class HyperappComponent
//    {
//        public static bool MinifyJs { get; set; } = false;

//        public class References
//        {
//            public State State { get; set; }
//        }

//        //        public static string Path<P1, TResult>(Func<CommandContext, HttpContext, P1, TResult> handler, Var<P1> parameter)
//        //        {
//        //            return WebServer.Path(handler.Method, parameter);
//        //        }

//        private static MethodInfo GetMethod(this State state, string moduleName, string methodName)
//        {
//            var registeredMethod = state.Pages.SingleOrDefault(x => x.DeclaringType.Name.ToLower() == moduleName.ToLower() && x.Name.ToLower() == methodName.ToLower());

//#if DEBUG

//            if (state.DynamicRebuild && !Debugger.IsAttached)
//            {
//                var name = registeredMethod.DeclaringType.Assembly.GetName().Name;
//                var csProjName = $"{name}.csproj";
//                var csProjAbsolutePath = Metapsi.RelativePath.SearchUpfolder(registeredMethod.DeclaringType.Assembly.Location, csProjName);
//                var csProjFolder = System.IO.Path.GetDirectoryName(csProjAbsolutePath);
//                var dllName = $"{name}.dll";
//                var dynamicOutputDllsFolder = System.IO.Path.Combine(csProjFolder, "dyn");
//                var debugOutputDll = System.IO.Path.Combine(dynamicOutputDllsFolder, dllName);

//                var buildFlags = "";

//                if (System.IO.Directory.Exists(dynamicOutputDllsFolder) && System.IO.Directory.EnumerateFiles(dynamicOutputDllsFolder).Any())
//                {
//                    buildFlags = " --no-dependencies --no-restore ";
//                }

//                var startInfo = new System.Diagnostics.ProcessStartInfo()
//                {
//                    FileName = "dotnet",
//                    Arguments = $"build {buildFlags} -o {dynamicOutputDllsFolder}",
//                    UseShellExecute = true,
//                    WorkingDirectory = csProjFolder,
//                    //RedirectStandardError = true,
//                    //RedirectStandardOutput = true
//                };
//                var process = System.Diagnostics.Process.Start(startInfo);
//                process.WaitForExit();

//                var rebuiltDll = System.Reflection.Assembly.Load(File.ReadAllBytes(debugOutputDll));

//                var parentType = rebuiltDll.DefinedTypes.Single(x => x.AssemblyQualifiedName == registeredMethod.DeclaringType.AssemblyQualifiedName);
//                var rebuildMethod = parentType.DeclaredMethods.Single(x => x.Name.ToLower() == methodName.ToLower());
//                return rebuildMethod;
//            }
//            else
//            {
//                return registeredMethod;
//            }
//#else

//            return registeredMethod;
//#endif

//        }

//        public class State
//        {
//            public bool DynamicRebuild { get; set; } = true;

//            public WebApplication WebApplication { get; set; }

//            internal System.Delegate DefaultPage { get; set; }
//            internal object DefaultParameter { get; set; }

//            public Func<MethodInfo, bool> PageFilter { get; set; } = DefaultPageFilter;
//            //public Func<MethodInfo, bool> ApiFilter { get; set; } = DefaultApiFilter;

//            public List<MethodInfo> Pages { get; set; } = new List<MethodInfo>();
//            //public List<MethodInfo> Apis { get; set; } = new List<MethodInfo>();
//        }

//        private static bool DefaultPageFilter(MethodInfo methodInfo)
//        {
//            if (!methodInfo.IsPublic)
//                return false;

//            if (methodInfo.ReturnType.Namespace != "System.Threading.Tasks")
//                return false;

//            if (methodInfo.ReturnType.GenericTypeArguments.Count() != 1)
//                return false;

//            if (methodInfo.ReturnType.GenericTypeArguments.First() != typeof(IResponse))
//                return false;

//            return true;
//        }

//        //        private static bool DefaultApiFilter(MethodInfo methodInfo)
//        //        {
//        //            if (!methodInfo.IsPublic)
//        //                return false;

//        //            if (methodInfo.ReturnType.Namespace != "System.Threading.Tasks")
//        //                return false;

//        //            // Is page, not api
//        //            if (methodInfo.ReturnType.GenericTypeArguments.Count() == 1 && methodInfo.ReturnType.GenericTypeArguments.First() == typeof(IResponse))
//        //                return false;

//        //            return true;
//        //        }

//        private static async Task RunHandler(string moduleName, string methodName, State state, HttpContext httpContext, CommandContext commandContext, string parameter = null)
//        {
//            var pageHandler = state.GetMethod(moduleName, methodName);

//            if (pageHandler == null)
//            {
//                httpContext.Response.StatusCode = 404;
//                return;
//            }

//            var sw = System.Diagnostics.Stopwatch.StartNew();

           

//            var arguments = new List<object>();

//            foreach (ParameterInfo parameterInfo in pageHandler.GetParameters())
//            {
//                if (parameterInfo.ParameterType == typeof(CommandContext))
//                {
//                    arguments.Add(commandContext);
//                }
//                else if (parameterInfo.ParameterType == typeof(HttpContext))
//                {
//                    arguments.Add(httpContext);
//                }
//                else
//                {
//                    if (parameter != null)
//                    {
//                        if (parameterInfo.ParameterType == typeof(Guid))
//                        {
//                            arguments.Add(Guid.Parse(parameter));
//                        }
//                        else
//                        {
//                            if (parameterInfo.ParameterType == typeof(int))
//                            {
//                                arguments.Add(Int32.Parse(parameter));
//                            }
//                            else
//                            {
//                                arguments.Add(parameter);
//                            }
//                        }
//                    }
//                }
//            }

//            dynamic response =  await (dynamic)pageHandler.Invoke(null, arguments.ToArray());

//            switch (response)
//            {
//                case PageResponse page:
////                    var indexPath = WebServer.FindPath("index.html");
////                    var indexContent = await File.ReadAllTextAsync(indexPath);
////#if DEBUG
////                    indexContent = indexContent.Replace("/tw.css", $"/tw.css?tick={DateTime.Now.Ticks}");
////#endif
////                    indexContent = indexContent.Replace("//@BASE", httpContext.GetHostedRootPath() + "/");
////                    indexContent = indexContent.Replace("//@MODULE", JavaScript.Builder.Generate(page.Module));
////                    // root path can be empty string on direct access or a prefix set by proxy
////                    indexContent = indexContent.Replace("/static/", httpContext.GetHostedRootPath() + "/static/");
////                    indexContent = indexContent.Replace("\"__RootPath\": \"\"", $"\"__RootPath\": \"{httpContext.GetHostedRootPath()}\"");
//                    httpContext.Response.ContentType = "text/html";
//                    //await httpContext.Response.WriteAsync(page.PageContent);

//                    await httpContext.Response.WriteAsync(page.PageContent);

//                    // Clear model before caching. It will be set on each request anyway
//                    //page.InitialModel = null;

//                    break;
//                case RedirectResponse redirect:
//                    httpContext.Response.Redirect(redirect.RedirectPath);
//                    break;
//            }

//            Console.WriteLine($"==== Page response time: {sw.ElapsedMilliseconds} ms");
//        }

//        public static string JsPath(this HttpContext httpContext)
//        {
//            var segments = httpContext.Request.Path.Value.Trim('/').Split("/");
//            if (segments.Count() < 2)
//            {
//                throw new Exception("Module path is not valid");
//            }

//            return $"./{segments[0]}_{segments[1]}.js";
//        }



//        // TODO: Register handler explicitly?
//        public static void RegisterHttpHandlers(this State state, IEndpointRouteBuilder routeBuilder, Type module, bool allowAnonymous = false)
//        {
//            string moduleName = module.Name;

//            var app = routeBuilder.MapGroup($"/{moduleName}/");

//            // Get without parameter
//            var routeHandlerBuilder = app.MapGet("{methodName}", async (HttpContext httpContext, CommandContext commandContext, string methodName) =>
//            {
//                await RunHandler(moduleName, methodName, state, httpContext, commandContext);
//            }).ExcludeFromDescription();

//            if (allowAnonymous)
//            {
//                routeHandlerBuilder.AllowAnonymous();
//            }

//            // Get with one parameter
//            routeHandlerBuilder = app.MapGet("{methodName}/{parameter}", async (HttpContext context, CommandContext commandContext, string methodName, string parameter) =>
//            {
//                await RunHandler(moduleName, methodName, state, context, commandContext, parameter);
//            }).ExcludeFromDescription();

//            if (allowAnonymous)
//            {
//                routeHandlerBuilder.AllowAnonymous();
//            }

//            // Post without parameter (is a form)
//            routeHandlerBuilder = app.MapPost("{methodName}", async (HttpContext context, CommandContext commandContext, string methodName) =>
//            {
//                var pageHandler = state.Pages.FirstOrDefault(x => context.Request.Path.Value.StartsWith(WebServer.Path(x)));

//                if (pageHandler != null)
//                {
//                    //RequestData requestData = new RequestData(context);
//                    //var form = await context.Request.ReadFormAsync();
//                    //requestData.Payload = form["payload"];
//                    //requestData.UiState = form["uistate"];
//                    //requestData.User = context.GetUser();

//                    await RunHandler(moduleName, methodName, state, context, commandContext);
//                }
//                else
//                {
//                    throw new NotSupportedException("API calls have a different ... API now");
//                }
//            }).ExcludeFromDescription();

//            if (allowAnonymous)
//            {
//                routeHandlerBuilder.AllowAnonymous();
//            }
//        }

//        public static References AddHyperapp(this WebServer.References webServerReferences, Delegate method, object parameter = null, bool allowAnonymous = false)
//        {
//            webServerReferences.RegisterStaticFiles(typeof(State).Assembly);
//            webServerReferences.RegisterStaticFiles(typeof(Native).Assembly);

//            State state = webServerReferences.ApplicationSetup.AddBusinessState(new State()
//            {
//                WebApplication = webServerReferences.WebApplication,
//                DefaultPage = method,
//                DefaultParameter = parameter
//            });

//            var app = state.WebApplication;

//            app.MapGet("/signin-redirect", (HttpContext httpContext) =>
//            {
//                var rootPath = httpContext.GetHostedRootPath();
//                return Results.Redirect(rootPath + WebServer.Path(state.DefaultPage.Method, state.DefaultParameter));
//            }).RequireAuthorization().ExcludeFromDescription();

//            app.MapGet("/signout", (HttpContext httpContext) =>
//            {
//                var rootPath = httpContext.GetHostedRootPath();
//                foreach (var cookie in httpContext.Request.Cookies)
//                {
//                    httpContext.Response.Cookies.Delete(cookie.Key);
//                }
//                httpContext.Response.Redirect(httpContext.GetHostedRootPath() + "/");
//            }).RequireAuthorization().ExcludeFromDescription();


//            // Redirect to default page
//            app.MapGet("/", () => Results.Redirect(RelativePath(state.DefaultPage.Method, state.DefaultParameter))).AllowAnonymous().ExcludeFromDescription();


//            var references = new References() { State = state };

//            RegisterModule(references, method.Method.DeclaringType, allowAnonymous);

//            return references;
//        }

//        public static void PrebuildModules(
//            this WebServer.References webServerReferences, 
//            Assembly assembly,
//            string version)
//        {
//            Stopwatch sw = Stopwatch.StartNew();

//            var allPageBuilders = assembly.GetTypes().Where(x => x.IsAssignableTo(typeof(IPageBuilder)));
//            foreach (Type pageBuilderType in allPageBuilders)
//            {
//                IPageBuilder pageBuilder = Activator.CreateInstance(pageBuilderType) as IPageBuilder;
//                var module = pageBuilder.GetModule();
//                var jsModule = HyperappComponent.MinifyJs ? UglyBuilder.Generate(module, version) : PrettyBuilder.Generate(module, version);
//                webServerReferences.StaticFiles[PageDetailsExtensions.PageRendererScriptPath(pageBuilderType).Trim('/')] = Encoding.UTF8.GetBytes(jsModule);
//            }

//            Console.WriteLine("Generate all pages " + sw.ElapsedMilliseconds + " ms");
//        }

//        //        public static void ToHtml(HyperNode hyperNode, System.Text.StringBuilder stringBuilder)
//        //        {
//        //            if (hyperNode.text != null)
//        //            {
//        //                stringBuilder.Append(hyperNode.text);
//        //                return; // a leaf, can return
//        //            }

//        //            if (hyperNode.children != null)
//        //            {
//        //                var attributes = hyperNode.props.Values.Where(x => x.Key != Html.innerHTML.PropertyName).Select(x => $"{x.Key}=\"{x.Value.Value}\"");

//        //                stringBuilder.Append($"<{hyperNode.tag} {string.Join(" ", attributes)}>");

//        //                if (!string.IsNullOrEmpty(hyperNode.props.Get(Html.innerHTML)))
//        //                {
//        //                    stringBuilder.Append(hyperNode.props.Get(Html.innerHTML));
//        //                }
//        //                else
//        //                {

//        //                    foreach (HyperNode children in hyperNode.children)
//        //                    {
//        //                        ToHtml(children, stringBuilder);
//        //                    }
//        //                }

//        //                stringBuilder.Append($"</{hyperNode.tag}>");
//        //            }
//        //        }

//        public static void RegisterModule(this References references,
//            Type moduleType,
//            bool allowAnonymous = false)
//        {
//            if (references.State.Pages.Any(x => x.DeclaringType == moduleType))
//            {
//                // Already registered
//                return;
//            }

//            foreach (var method in moduleType.GetMethods())
//            {
//                if (references.State.PageFilter(method))
//                {
//                    references.State.Pages.Add(method);
//                }
//            }

//            references.State.RegisterHttpHandlers(references.State.WebApplication, moduleType, allowAnonymous);
//        }

//        //        public static void SetPageFilter(this References references, Func<System.Reflection.MethodInfo, bool> isPage)
//        //        {
//        //            references.State.PageFilter = isPage;
//        //        }
//    }

//    //public class RequestData
//    //{
//    //    public RequestData(HttpContext httpContext)
//    //    {
//    //        HttpContext = httpContext;
//    //    }

//    //    public WebServer.User User { get; set; } = new WebServer.User();

//    //    public string FromPath { get; set; }
//    //    public List<string> Parameters { get; set; } = new List<string>();
//    //    public string Payload { get; set; } = string.Empty;
//    //    public string UiState { get; set; }
//    //    public Dictionary<string, string> QueryParameters { get; set; } = new Dictionary<string, string>();
//    //    public HttpContext HttpContext { get; }
//    //}
//}
