using Microsoft.AspNetCore.Http;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Metapsi
{
    class HtmlResult : IResult
    {
        private readonly string html;
        public HtmlResult(string html)
        {
            this.html = html;
        }
        public async Task ExecuteAsync(HttpContext httpContext)
        {
            httpContext.Response.ContentType = System.Net.Mime.MediaTypeNames.Text.Html;
            httpContext.Response.ContentLength = Encoding.UTF8.GetByteCount(html);
            await httpContext.Response.WriteAsync(html);
        }
    }
}