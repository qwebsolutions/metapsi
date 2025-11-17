using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Metapsi.Web;

namespace Metapsi.Web.NetFramework.Mvc.Scenario.Controllers
{
    [RoutePrefix("embedded")]
    public class EmbeddedController : Controller
    {
        [AllowAnonymous()]
        [HttpGet]
        [Route("{package}/{version}/{*logicalName}")]
        public async Task Embedded(string package, string version, string logicalName)
        {
            await new Metapsi.Web.CfHttpContext(System.Web.HttpContext.Current).Response.WriteEmbeddedResource(package, logicalName);
        }
    }
}