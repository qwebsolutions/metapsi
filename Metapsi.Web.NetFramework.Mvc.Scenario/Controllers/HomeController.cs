using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Metapsi;
using Metapsi.Html;
using Metapsi.Hyperapp;

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
                        b.BodyAppend(b.Text("Hello from Metapsi"));
                        b.BodyAppend(b.Hyperapp<object>(
                            new object(),
                            (b, model) => { return b.Text("Hello from Metapsi client-side"); }));
                    }));
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}