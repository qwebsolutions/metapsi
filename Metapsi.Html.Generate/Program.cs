
using Metapsi.WebComponentGenerator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

public static class Program
{
    public static async Task Main()
    {
        List<string> allTags = System.Text.Json.JsonSerializer.Deserialize<List<string>>(
            await System.IO.File.ReadAllTextAsync(
                System.IO.Path.Combine(
                    Utils.SearchUpfolder(System.IO.Directory.GetCurrentDirectory(), "Metapsi.Html.Generate"),
                    "html-tags.json")));

        var outProjectFolder = Utils.SearchUpfolder(System.IO.Directory.GetCurrentDirectory(), "Metapsi.Html");

        if (string.IsNullOrEmpty(outProjectFolder))
        {
            Console.WriteLine("Project folder Metapsi.Html not found");
            return;
        }

        var controlsOutputFolder = System.IO.Path.Combine(outProjectFolder, "Controls");

        if (System.IO.Directory.Exists(controlsOutputFolder))
        {
            System.IO.Directory.Delete(controlsOutputFolder, true);
        }
        System.IO.Directory.CreateDirectory(controlsOutputFolder);

        CSharpConverter cSharpConverter = new CSharpConverter
        {
            Namespace = "Metapsi.Html",
            NodeConstructor = "H"
        };

        foreach (var tag in allTags.Where(x => !SkippedTags.Contains(x)))
        {
            WebComponent webComponent = new WebComponent()
            {
                Description = $"The HTML {tag} tag",
                Name = "Html" + Utils.ToCSharpValidName(tag),
                Tag = tag
            };

            await System.IO.File.WriteAllTextAsync(System.IO.Path.Combine(controlsOutputFolder, $"{webComponent.Name}.cs"), webComponent.ToCSharpFile(cSharpConverter));
        }
    }

    public static List<string> SkippedTags = new List<string>()
    {
        //"html",
        //"head",
        //"body",
        //"meta",
        //"noscript"
    };
}