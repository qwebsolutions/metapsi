
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
    public static async Task Main(string[] args)
    {
        var version = args[0];

        var metadataFileUrl = Utils.JsDelivrFileUrl("shoelace-style", "shoelace", version, "custom-elements.json");

        var packageMetadata = await new HttpClient().GetStringAsync(metadataFileUrl);

        var shoelaceProjectFolder = Utils.SearchUpfolder(System.IO.Directory.GetCurrentDirectory(), "Metapsi.Shoelace");

        if (string.IsNullOrEmpty(shoelaceProjectFolder))
        {
            Console.WriteLine("Project folder Metapsi.Shoelace not found");
            return;
        }

        var metadata = System.Text.Json.JsonSerializer.Deserialize<ShoelaceMetadata>(packageMetadata);

        var shoelaceControlsOutputFolder = System.IO.Path.Combine(shoelaceProjectFolder, "Controls");

        if (System.IO.Directory.Exists(shoelaceControlsOutputFolder))
        {
            System.IO.Directory.Delete(shoelaceControlsOutputFolder, true);
        }
        System.IO.Directory.CreateDirectory(shoelaceControlsOutputFolder);

        CSharpConverter cSharpConverter = new CSharpConverter
        {
            Namespace = "Metapsi.Shoelace",
            NodeConstructor = "SlNode",
            ToCSharpType = (t, converter) =>
            {
                var defaultConversion = CSharpConverter.DefaultToCSharpType(t, converter);

                if (defaultConversion == "Date")
                {
                    return "DateTime";
                }

                if (defaultConversion.Trim().StartsWith("Promise<"))
                    return "object";

                return defaultConversion;
            }
        };

        foreach (var module in metadata.modules)
        {
            foreach (var declaration in module.declarations.Where(x => !SkippedControls().Contains(x.name)))
            {
                WebComponent shoelaceComponent = new()
                {
                    Name = declaration.name,
                    Description = declaration.summary,
                    Tag = declaration.tagName
                };

                foreach (var member in declaration.members.Where(x => x.kind == "field").Where(x => !string.IsNullOrWhiteSpace(x.description)).Where(x => !x.@readonly))
                {
                    var typeString = member.type.text;

                    if (member.@default == "Infinity")
                    {
                        typeString = "number";
                    }

                    if (member.name == "valueAsDate")
                    {
                        typeString = "any";
                    }

                    if (member.name == "valueAsNumber")
                    {
                        typeString = "number";
                    }

                    if (member.name == "modal")
                    {
                        // this seems readonly? Anyway, looks like some corner case property
                        continue;
                    }

                    if (typeString.Trim().StartsWith("|"))
                    {
                        typeString = typeString.Trim().TrimStart('|');
                    }

                    var shoelaceField = new WebComponentProperty()
                    {
                        Name = member.name,
                        Description = member.description.Replace("\r", string.Empty).Replace("\n", " "),
                        TypeScriptType = TypeParser.GetTypeScriptType(typeString)
                    };

                    shoelaceComponent.Properties.Add(shoelaceField);
                }
                foreach (var @event in declaration.events)
                {
                    shoelaceComponent.Events.Add(new WebComponentEvent()
                    {
                        Name = @event.name,
                        Comment = Utils.SingleLine(@event.description),
                        Type = new TypeScriptObjectType() { TypeName = "any" }
                    });
                }

                foreach (var slot in declaration.slots)
                {
                    if (!string.IsNullOrEmpty(slot.name))
                    {
                        shoelaceComponent.Slots.Add(new WebComponentSlot()
                        {
                            Name = slot.name,
                            Comment = Utils.SingleLine(slot.description)
                        });
                    }
                }

                foreach (var method in declaration.members.Where(x => x.kind == "method" && !string.IsNullOrWhiteSpace(x.description)))
                {
                    shoelaceComponent.Methods.Add(new WebComponentMethod()
                    {
                        Name = method.name,
                        Comment = Utils.SingleLine(method.description)
                    });
                }

                await System.IO.File.WriteAllTextAsync(System.IO.Path.Combine(shoelaceControlsOutputFolder, $"{shoelaceComponent.Name}.cs"), shoelaceComponent.ToCSharpFile(cSharpConverter));
            }
        }

        var csProjPath = System.IO.Path.Combine(shoelaceProjectFolder, "Metapsi.Shoelace.csproj");
        var projectDescription = $"Use Shoelace {version} with Metapsi for both server-side and client-side generated web pages (https://shoelace.style)";
        Utils.SetCsProjDescription(csProjPath, projectDescription);

    }
    public static HashSet<string> SkippedControls()
    {
        return new HashSet<string>() { "SlPopup" };
    }
}