using Metapsi;
using Metapsi.Html;
using Metapsi.Hyperapp;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Metapsi.Web.NetFramework.Mvc.Scenario.Controllers
{
    public class HomeController : Controller
    {
        public async Task Index()
        {
            await new Metapsi.Web.CfHttpContext(System.Web.HttpContext.Current).Response.WriteHtmlDocument(
                HtmlBuilder.FromDefault(
                    b =>
                    {
                        b.HeadAppend(b.HtmlTitle("Metapsi rendering server and client directly from the HTTP handler"));
                        b.BodyAppend(
                            b.SharedLayout(
                            b.HtmlDiv(
                                b =>
                                {
                                    b.SetStyle("display: flex; flex-direction: column; gap:2rem");
                                },
                                b.HtmlDiv(
                                    b =>
                                    {
                                        b.SetStyle("background-color: #eee; padding: 2rem; font-family: sans-serif; font-weight: 600");
                                    },
                                    b.Text("Hello from Metapsi server-side")),
                                b.Hyperapp<object>(
                                    new object(),
                                    (b, model) =>
                                    {
                                        return b.HtmlDiv(
                                            b =>
                                            {
                                                b.AddStyle("background-color", "#222");
                                                b.AddStyle("padding", "2rem");
                                                b.AddStyle("font-family", "sans-serif");
                                                b.AddStyle("font-weight", "600");
                                                b.AddStyle("color", "#eee");
                                            },
                                            b.Text("Hello from Metapsi client-side"));
                                    }))));
                    }));
        }

        public async Task MvcViewInMetapsi()
        {
            var result = RenderViewToString(this.ControllerContext, "MvcViewInMetapsi", new object());
            var inView = HtmlBuilder.FromDefault(
                b =>
                {
                    b.HeadAppend(b.HtmlTitle("MVC view inside Metapsi"));
                    b.BodyAppend(b.SharedLayout(b.Text(result)));
                });

            await new Metapsi.Web.CfHttpContext(System.Web.HttpContext.Current).Response.WriteHtmlDocument(inView);
        }

        public ActionResult MetapsiInMvcView()
        {
            return this.View();
        }

        public string RenderViewToString(ControllerContext context, string viewName, object model)
        {
            // Assign model
            context.Controller.ViewData.Model = model;

            using (var sw = new StringWriter())
            {
                var viewResult = ViewEngines.Engines.FindView(context, viewName, null);
                var viewContext = new ViewContext(context, viewResult.View, context.Controller.ViewData, context.Controller.TempData, sw);
                viewResult.View.Render(viewContext, sw);
                viewResult.ViewEngine.ReleaseView(context, viewResult.View);
                return sw.GetStringBuilder().ToString();
            }
        }
    }

    public static class SharedLayoutExtensions
    {
        public static IHtmlNode BodyClass(this HtmlBuilder b)
        {
            return b.HtmlStyle(b.Text("body { font-family: sans-serif; }"));
        }

        public static string ToHtml(System.Func<HtmlBuilder, IHtmlNode> renderNode)
        {
            var node = HtmlBuilder.Node(renderNode);
            return (node as HtmlNode).ToHtml();
        }

        public static string GetSharedMenu()
        {
            var sharedMenu = HtmlBuilder.Node(SharedMenu);
            var tag = (sharedMenu as HtmlNode);
            return tag.ToHtml();
        }

        public static IHtmlNode SharedMenu(this HtmlBuilder b)
        {
            return b.HtmlDiv(
                b =>
                {
                    b.SetStyle("display: flex; flex-direction:row; gap:4rem; padding:2rem; background-color: aliceblue; flex-wrap: wrap");
                },
                b.HtmlDiv(b.HtmlB(b.Text("Metapsi ASP MVC sample"))),
                b.HtmlDiv(
                    b =>
                    {
                        b.SetStyle("display: flex; flex-direction:row; gap:2rem");
                    },
                    b.HtmlA(
                        b =>
                        {
                            b.SetHref("/");
                        },
                        b.Text("Home")),
                    b.HtmlA(
                        b =>
                        {
                            b.SetHref("/home/MvcViewInMetapsi");
                        },
                        b.Text("MVC view inside Metapsi")),
                    b.HtmlA(
                        b =>
                        {
                            b.SetHref("/home/MetapsiInMvcView");
                        },
                        b.Text("Metapsi inside a MVC view"))));
        }

        public static IHtmlNode SharedLayout(this HtmlBuilder b, IHtmlNode pageContent)
        {
            b.HeadAppend(b.BodyClass());
            return b.HtmlDiv(
                b=>
                {
                    b.SetStyle("display: flex; flex-direction: column; gap: 2rem");
                },
                b.SharedMenu(),
                pageContent);
        }
    }
}