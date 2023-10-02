using Metapsi;
using Metapsi.Tutorial.Samples;
using Metapsi.Ui;
using Microsoft.AspNetCore.Http;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.MSBuild;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metapsi.Tutorial;

public class TutorialHandler : Http.Get<Metapsi.Tutorial.Routes.Tutorial, string>
{
    public override async Task<IResult> OnGet(CommandContext commandContext, HttpContext httpContext, string docCode)
    {
        Console.WriteLine(httpContext.Request.Path);

        var dbFullPath = await Arguments.FullDbPath();

        TutorialModel model = new TutorialModel();
        await model.LoadMenu();
        model.SetCurrentEntry(httpContext.Request.Path);
        model.MarkdownContent = await System.Reflection.Assembly.GetAssembly(this.GetType()).GetEmbeddedTextFile(docCode + ".md");

        return Page.Result(model);
    }

}
