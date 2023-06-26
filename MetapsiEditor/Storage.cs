using Metapsi;
using Metapsi.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;

public static class Storage
{
    public static Request<Backend.SolutionsResponse> GetSolutions { get; set; } = new(nameof(GetSolutions));
    public static Request<List<Metapsi.Live.Db.Input>, string> LoadRendererInputs { get; set; } = new(nameof(LoadRendererInputs));
    public static Command<string, string> SaveInput { get; set; } = new(nameof(SaveInput));

    public static void MapStorage(this ImplementationGroup ig, string dbFullPath)
    {
        ig.MapCommand(SaveInput, async (rc, rendererName, input) =>
        {

            await Db.WithCommit(dbFullPath, async (t) =>
            {
                var rendererRecords = await t.Transaction.LoadRecords<Metapsi.Live.Db.Input, string>(x => x.RendererName, rendererName);

                await t.Transaction.InsertRecord(new Metapsi.Live.Db.Input()
                {
                    Id = Guid.NewGuid(),
                    InputName = "Input" + rendererRecords.Count(),
                    Json = input,
                    RendererName = rendererName
                });
            });
        });

        ig.MapRequest(Storage.GetSolutions, async (rc) =>
        {
            return new Backend.SolutionsResponse()
            {
                Solutions = (await Db.Records<Metapsi.Live.Db.Solution>(dbFullPath)).ToList()
            };
        });


        ig.MapRequest(Storage.LoadRendererInputs, async (rc, rendererName) =>
        {
            var allInputs = await Db.Records<Metapsi.Live.Db.Input>(dbFullPath);
            return allInputs.Where(x => x.RendererName == rendererName).ToList();
        });
    }
}
