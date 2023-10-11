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
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Metapsi.Tutorial;

public class TutorialHandler : Http.Get<Metapsi.Tutorial.Routes.Tutorial, string>
{
    public override async Task<IResult> OnGet(CommandContext commandContext, HttpContext httpContext, string docCode)
    {
        return Page.Result(await httpContext.WithBreakpointProbing(async delegate (TutorialModel model)
        {
            await model.LoadMenu();
            model.SetCurrentEntry(httpContext.Request.Path);
            model.MarkdownContent = await Assembly.GetAssembly(GetType()).GetEmbeddedTextFile(docCode + ".md");
        }));
    }

}
