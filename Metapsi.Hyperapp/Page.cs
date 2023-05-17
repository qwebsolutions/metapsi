using Metapsi.Syntax;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.WebUtilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metapsi.Hyperapp
{
    public static partial class Page
    {
        public static Request<string> GetVersion { get; set; } = new(nameof(GetVersion));

        public interface ISubBuilder { }

        public class ExternalSubscriptionBuilder : ISubBuilder
        {
            public Import Import { get; set; }
        }

        public class LocalSubscription : ISubBuilder
        {
            public HyperType.Subscription Subscription { get; set; }
        }

        public static Module BuildMain<TDataModel>(
            Func<BlockBuilder, Var<TDataModel>, Var<HyperNode>> render,
            Func<BlockBuilder, Var<TDataModel>, Var<HyperType.StateWithEffects>> initAction = null)
        {
            ModuleBuilder b = new ModuleBuilder();

            b.Define("main", (BlockBuilder b, Var<TDataModel> model) =>
            {
                Var<HyperType.Init> init = null;

                if (initAction == null)
                {
                    init = b.MakeInit(b.Def((BlockBuilder b) =>
                    {
                        return model;
                    }));
                }
                else
                {
                    init = b.MakeInit(b.Def((BlockBuilder b) =>
                    {
                        return b.Call(initAction, model);
                    }));
                }

                var onRenderError = (BlockBuilder b, Var<TDataModel> model, Var<DynamicObject> error) =>
                {
                    b.Log(error);
                    b.Log(model);

                    Var<DynamicObject> inlineStyle = b.NewObj<DynamicObject>();
                    b.Set(inlineStyle, new DynamicProperty<string>("backgroundColor"), b.Const("white"));
                    b.Set(inlineStyle, new DynamicProperty<string>("color"), b.Const("black"));
                    b.Set(inlineStyle, new DynamicProperty<string>("display"), b.Const("flex"));
                    b.Set(inlineStyle, new DynamicProperty<string>("flex-direction"), b.Const("row"));
                    b.Set(inlineStyle, new DynamicProperty<string>("width"), b.Const("100vw"));
                    b.Set(inlineStyle, new DynamicProperty<string>("height"), b.Const("100vh"));
                    b.Set(inlineStyle, new DynamicProperty<string>("justify-content"), b.Const("center"));
                    b.Set(inlineStyle, new DynamicProperty<string>("align-items"), b.Const("center"));

                    var errorDiv = b.Div("", b => b.TextNode("An error has occurred"));
                    b.SetAttr(errorDiv, new DynamicProperty<DynamicObject>("style"), inlineStyle);

                    return errorDiv;
                };

                var app = b.NewObj<HyperType.App<TDataModel>>();
                b.Set(app, x => x.init, init);
                b.Set(app, x => x.view, b.Def((BlockBuilder b, Var<TDataModel> model) =>
                {
                    var r = b.Def(render);
                    var rootNode = b.TryCatchReturn<HyperNode>(
                        b.Def(b => b.Call(r, model)),
                        b.Def((BlockBuilder b, Var<DynamicObject> error) =>
                        {
                            return b.Call(onRenderError, model, error);
                        }));
                    b.CallExternal(nameof(Native), "DispatchEvent", b.Const("afterRender"));
                    return rootNode;
                }));
                b.Set(app, x => x.node, b.GetElementById(b.Const("app")));


                //var subFuncs2 = b.Module.Constants.Where(x => x.Value is IFunction);
                var subFuncs = b.Module.Functions.Where(x => x.ReturnVariable.Type == typeof(HyperType.Subscription) && x.Parameters.Count == 1 && (x.Parameters.First().Type == typeof(TDataModel) || x.Parameters.First().Type == typeof(object)));
                var aggSubs = b.ModuleBuilder.Define("PageSubscriptions", (BlockBuilder b, Var<TDataModel> state) =>
                {
                    var subscriptions = b.NewCollection<HyperType.Subscription>();
                    foreach (var subBuilder in subFuncs)
                    {
                        var fakeFunc = new Var<object>(subBuilder.Name);
                        var sub = b.CallFunction<HyperType.Subscription>(fakeFunc, state);
                        b.Push(subscriptions, sub);
                    }
                    return subscriptions;
                });

                b.Set(app, x => x.subscriptions, aggSubs.As<Func<TDataModel, List<HyperType.Subscription>>>());

                b.CallExternal("hyperapp", "app", app);
            });

            return b.Module;
        }

        public static PageResponse Response<TDataModel>(
            TDataModel serverModel,
            Func<BlockBuilder, Var<TDataModel>, Var<HyperNode>> render,
            string version = null,
            Func<BlockBuilder, Var<TDataModel>, Var<HyperType.StateWithEffects>> initAction = null,
            Func<BlockBuilder, Var<TDataModel>, Var<DynamicObject>, Var<HyperNode>> onRenderError = null)
            where TDataModel : new()
        {
            PageDetails pageResponse = new()
            {
                InitialModel = serverModel,
                Version = version
            };

            Console.WriteLine($"@@@@@@@@ render {render.Method.Name}");

            var sw = System.Diagnostics.Stopwatch.StartNew();
            var module = BuildMain(render, initAction);
            var serverSideTags = module.Consts.Where(x => x.Value is IServerSideTag);

            foreach (var serverSideTag in serverSideTags)
            {
                switch (serverSideTag.Value)
                {
                    // TODO: Server-side only
                    case TitleTag titleTag:
                        pageResponse.PageTitle = titleTag.title;
                        break;
                    case ScriptTag scriptTag:
                        pageResponse.ScriptPaths.Add(scriptTag.src);
                        break;
                    case LinkTag linkTag:
                        string cssHref = linkTag.href;
#if DEBUG
                        linkTag = new LinkTag(linkTag.rel, linkTag.href + $"?tick={DateTime.Now.Ticks}");
#endif
                        pageResponse.LinkTags.Add(linkTag);
                        break;

                    // TODO: Server-side only
                    case FaviconTag faviconTag:
                        pageResponse.Favicon = faviconTag.href;
                        break;
                    case BodyTag bodyTag:
                        pageResponse.BodyCss = bodyTag.bodyCss;
                        break;
                }
            }

            var jsModule = HyperappComponent.MinifyJs ? JavaScript.UglyBuilder.Generate(module, version) : JavaScript.PrettyBuilder.Generate(module, version);
            pageResponse.PageScript = jsModule;

            var time = sw.ElapsedMilliseconds;

            Console.WriteLine($"=== Build module: {sw.ElapsedMilliseconds} ms ===");
            Console.WriteLine(System.Threading.ThreadPool.ThreadCount);

            return new PageResponse() { PageContent = pageResponse.BuildInlineScriptPageContent() };
        }

        public static PageResponse Response<TDataModel, TRenderer>(
            TDataModel serverModel,
            string version)
            where TDataModel : new()
            where TRenderer: IPageBuilder<TDataModel>, new()
        {
            PageDetails pageResponse = new()
            {
                InitialModel = serverModel,
                Version = version
            };

            var sw = System.Diagnostics.Stopwatch.StartNew();
            var renderer = new TRenderer();
            var module = renderer.GetModule();

            var serverSideTags = module.Consts.Where(x => x.Value is IServerSideTag);

            foreach (var serverSideTag in serverSideTags)
            {
                switch (serverSideTag.Value)
                {
                    // TODO: Server-side only
                    case TitleTag titleTag:
                        pageResponse.PageTitle = titleTag.title;
                        break;
                    case ScriptTag scriptTag:
                        pageResponse.ScriptPaths.Add(scriptTag.src);
                        break;
                    case LinkTag linkTag:
                        string cssHref = linkTag.href;
#if DEBUG
                        linkTag = new LinkTag(linkTag.rel, linkTag.href + $"?tick={DateTime.Now.Ticks}");
#endif
                        pageResponse.LinkTags.Add(linkTag);
                        break;

                    // TODO: Server-side only
                    case FaviconTag faviconTag:
                        pageResponse.Favicon = faviconTag.href;
                        break;
                    case BodyTag bodyTag:
                        pageResponse.BodyCss = bodyTag.bodyCss;
                        break;
                }
            }

            //var jsModule = JavaScript.Builder.Generate(module, version);
            //pageResponse.PageScript = jsModule;
            pageResponse.ModuleScriptPath = $"/{PageDetailsExtensions.PageRendererScriptPath<TRenderer>()}{PageDetailsExtensions.WithVersion(version)}";

            var time = sw.ElapsedMilliseconds;

            Console.WriteLine($"=== Build module: {sw.ElapsedMilliseconds} ms ===");
            Console.WriteLine(System.Threading.ThreadPool.ThreadCount);

            return new PageResponse() { PageContent = pageResponse.BuildExternalScriptPageContent() };
        }


        // Well known variables that can be overwritten by proxy
        public class StandardVariables
        {
            public string __RootPath { get; set; } = "";
        }

        private static StandardVariables standardVariables = new StandardVariables();

        public static Var<string> RootPath(this BlockBuilder b)
        {
            var svConst = b.Const(standardVariables, nameof(standardVariables));
            return b.Get(svConst, x => x.__RootPath);
        }

        public static Var<string> Url(this BlockBuilder b, Delegate handler)
        {
            var path = b.Concat(b.RootPath(), b.Const(WebServer.Path(handler.Method)));
            return path;
        }

        public static Var<string> Url<P1, TResult>(this BlockBuilder b, Func<CommandContext, HttpContext, P1, TResult> handler, Var<P1> parameter)
        {
            var path = b.Concat(b.RootPath(), b.Const(WebServer.Path(handler.Method)), b.Const("/"), b.AsString(parameter));
            return path;
        }

        public static Var<string> Url<P1, TResult>(this BlockBuilder b, Func<CommandContext, P1, TResult> handler, Var<P1> parameter)
        {
            var path = b.Concat(b.RootPath(), b.Const(WebServer.Path(handler.Method)), b.Const("/"), b.AsString(parameter));
            return path;
        }

        public static Var<string> Url(this BlockBuilder b, Func<CommandContext, HttpContext, System.Threading.Tasks.Task<IResponse>> handler, Var<string> parameter)
        {
            var path = b.Concat(b.RootPath(), b.Const(WebServer.Path(handler.Method)), b.Const("/"), parameter);
            return path;
        }

        public static Var<string> Url(this BlockBuilder b, Func<CommandContext, HttpContext, System.Threading.Tasks.Task<IResponse>> handler, Var<Guid> parameter)
        {
            var path = b.Concat(b.RootPath(), b.Const(WebServer.Path(handler.Method)), b.Const("/"), b.AsString(parameter));
            return path;
        }

        public static Var<HyperType.Effect> NoEffect(this BlockBuilder b)
        {
            return b.MakeEffect(b.MakeEffecter((BlockBuilder b, Var<HyperType.Dispatcher<object>> _) =>
            {
                // Do nothing
            }));
        }

        public static RedirectResponse Redirect(Delegate d, object parameter = null)
        {
            return new RedirectResponse() { RedirectPath = WebServer.Path(d.Method, parameter) };
        }

        public static RedirectResponse Redirect(string url)
        {
            return new RedirectResponse() { RedirectPath = url };
        }
    }

    public class PageDetails
    {
        public string Version { get; set; } = string.Empty;
        public string PageTitle { get; set; } = string.Empty;
        public List<LinkTag> LinkTags { get; set; } = new();
        public List<string> ScriptPaths { get; set; } = new();
        public string Favicon { get; set; } = string.Empty;
        public object InitialModel { get; set; }
        public string PageScript { get; set; }
        public string ModuleScriptPath { get; set; } = string.Empty;
        public string BodyCss { get; set; } = string.Empty;
    }

    public static class PageDetailsExtensions
    {
        public static string BuildInlineScriptPageContent(this PageDetails page)
        {
            StringBuilder pageBuilder = new StringBuilder();
            pageBuilder.AppendLine($"<!DOCTYPE html>");
            pageBuilder.AppendLine($"<html lang=\"en\">");
            pageBuilder.AppendLine($"<head>");
            pageBuilder.AppendLine($"    <meta charset='utf-8'>");
            pageBuilder.AppendLine($"    <meta name='viewport' content='width=device-width,initial-scale=1'>");
            pageBuilder.AppendLine($"    <title>{page.PageTitle}</title>");
            pageBuilder.AppendLine($"    <link rel='icon' type='image/x-icon' href='{page.Favicon}'>");
            pageBuilder.AppendLine($"    <base href=\"/\">");
            foreach (var link in page.LinkTags)
            {
                pageBuilder.AppendLine($"<link rel=\"{link.rel}\" href=\"{link.href}{WithVersion(page.Version)}\"/>");
            }
            foreach (var script in page.ScriptPaths)
            {
                pageBuilder.AppendLine($"<script src=\"{script}{WithVersion(page.Version)}\"></script>");
            }
            pageBuilder.AppendLine($"</head>");

            if (!string.IsNullOrEmpty(page.BodyCss))
            {
                pageBuilder.AppendLine($"<body class=\"{page.BodyCss}\">");
            }
            else
            {
                pageBuilder.AppendLine($"<body>");
            }

            pageBuilder.AppendLine($"    <script type=\"module\">");

            pageBuilder.AppendLine($"    {page.PageScript}");
            //pageBuilder.AppendLine($"    import {{ main }} from \"{page.ModuleScriptPath}\";");
            pageBuilder.AppendLine($"    var model = {Metapsi.JavaScript.PrettyBuilder.Serialize(page.InitialModel)}");
            pageBuilder.AppendLine($"    main(model)");
            pageBuilder.AppendLine($"    </script>");
            pageBuilder.AppendLine($"    <main id=\"app\"></main>");
            pageBuilder.AppendLine($"</body>");

            return pageBuilder.ToString();
        }

        public static string BuildExternalScriptPageContent(this PageDetails page)
        {
            StringBuilder pageBuilder = new StringBuilder();
            pageBuilder.AppendLine($"<!DOCTYPE html>");
            pageBuilder.AppendLine($"<html lang=\"en\">");
            pageBuilder.AppendLine($"<head>");
            pageBuilder.AppendLine($"    <meta charset='utf-8'>");
            pageBuilder.AppendLine($"    <meta name='viewport' content='width=device-width,initial-scale=1'>");
            pageBuilder.AppendLine($"    <title>{page.PageTitle}</title>");
            pageBuilder.AppendLine($"    <link rel='icon' type='image/x-icon' href='{page.Favicon}'>");
            pageBuilder.AppendLine($"    <base href=\"/\">");
            foreach (var linkTag in page.LinkTags)
            {
                pageBuilder.AppendLine($"<link rel=\"{linkTag.rel}\" href=\"{linkTag.href}{WithVersion(page.Version)}\"/>");
            }
            foreach (var script in page.ScriptPaths)
            {
                pageBuilder.AppendLine($"<script src=\"{script}{WithVersion(page.Version)}\"></script>");
            }
            pageBuilder.AppendLine($"</head>");

            if (!string.IsNullOrEmpty(page.BodyCss))
            {
                pageBuilder.AppendLine($"<body class=\"{page.BodyCss}\">");
            }
            else
            {
                pageBuilder.AppendLine($"<body>");
            }

            pageBuilder.AppendLine($"    <script type=\"module\">");

            //pageBuilder.AppendLine($"    {page.PageScript}");
            pageBuilder.AppendLine($"    import {{ main }} from \"{page.ModuleScriptPath}\";");
            pageBuilder.AppendLine($"    var model = {Metapsi.JavaScript.PrettyBuilder.Serialize(page.InitialModel)}");
            pageBuilder.AppendLine($"    main(model)");
            pageBuilder.AppendLine($"    </script>");
            pageBuilder.AppendLine($"    <main id=\"app\"></main>");
            pageBuilder.AppendLine($"</body>");

            return pageBuilder.ToString();
        }

        public static string WithVersion(string version)
        {
            if (string.IsNullOrEmpty(version))
                return string.Empty;

            return $"?v={version}";
        }

        public static string PageRendererScriptPath(Type rendererType)
        {
            List<Type> nestedTypes = new List<Type>();

            var currentType = rendererType;

            while (currentType != null)
            {
                nestedTypes.Add(currentType);
                currentType = currentType.DeclaringType;
            }

            nestedTypes.Reverse();
            string path = $"{string.Join("_", nestedTypes.Select(x => x.Name))}.js";
            return path.ToLower();
        }

        public static string PageRendererScriptPath<TRenderer>() where TRenderer : IPageBuilder
        {
            return PageRendererScriptPath(typeof(TRenderer));
        }
    }

    public interface IPageBuilder
    {
        public Module GetModule();
    }

    public interface IPageBuilder<TModel> : IPageBuilder
    {
        public Var<HyperNode> Render(BlockBuilder b, Var<TModel> model);
        public Var<HyperType.StateWithEffects> Init(BlockBuilder b, Var<TModel> model);
    }

    public abstract class PageBuilder<TModel> : IPageBuilder<TModel>
    {
        private static Module module = null;

        public Module GetModule()
        {
            if (module == null)
            {
                module = Page.BuildMain<TModel>(Render, Init);
            }
            return module;
        }

        public virtual Var<HyperType.StateWithEffects> Init(BlockBuilder b, Var<TModel> model)
        {
            return b.MakeStateWithEffects(model);
        }

        public abstract Var<HyperNode> Render(BlockBuilder b, Var<TModel> model);
    }
}

