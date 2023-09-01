using Metapsi;
using Metapsi.Ui;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Metapsi.Tutorial;

public class TutorialHandler : Http.Get<Metapsi.Tutorial.Routes.Tutorial, string>
{
    public override async Task<IResult> OnGet(CommandContext commandContext, HttpContext httpContext, string docCode)
    {
        var dbFullPath = await Arguments.FullDbPath();

        TutorialModel model = new TutorialModel();
        await model.LoadRoutes();

        model.Doc = (await Sqlite.Db.Entities<Doc, string>(dbFullPath, x => x.Code, docCode)).SingleOrDefault();

        if (model.Doc != null)
        {
            model.Slices.AddRange(await Sqlite.Db.Entities<DocSlice, string>(dbFullPath, x => x.ParentDoc, model.Doc.Code));
            
            var codeSampleCodes = model.Slices.Where(x => x.SliceType == nameof(CodeSample)).Select(x => x.SliceCode);
            model.Samples.AddRange(await Sqlite.Db.Entities<CodeSample, string>(dbFullPath, x => x.SampleId, codeSampleCodes));
            
            var headers = model.Slices.Where(x => x.SliceType == nameof(Header)).Select(x => x.SliceCode);
            model.Headers.AddRange(await Sqlite.Db.Entities<Header, string>(dbFullPath, x => x.Code, headers));
            
            return Page.Result(model);
        }
        else
        {
            return Results.NotFound();
        }
    }
}