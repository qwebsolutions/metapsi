using Metapsi.Sqlite;
using Microsoft.AspNetCore.Http;
using System.Linq;
using System.Threading.Tasks;

namespace Metapsi.Tutorial;

public class ParagraphHandler : Http.Get<Metapsi.Tutorial.Routes.Paragraph, string>
{
    public override async Task<IResult> OnGet(CommandContext commandContext, HttpContext httpContext, string paragraphCode)
    {
        var parametersFullFilePath = Metapsi.RelativePath.SearchUpfolder(RelativePath.From.CurrentDir, "parameters.json");
        var dbFullPath = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(parametersFullFilePath), "Metapsi.Tutorial.db");

        var paragraphs = await Db.Entities<Paragraph, string>(dbFullPath, x => x.Code, paragraphCode);

        if(paragraphs.Any())
        {
            return Results.Text(paragraphs.First().Content, "text/html");
        }

        return Results.NotFound();
    }
}