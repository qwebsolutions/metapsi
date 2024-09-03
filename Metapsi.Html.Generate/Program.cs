
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

        var jsonDefinitionsText = await System.IO.File.ReadAllTextAsync(
                System.IO.Path.Combine(
                    Utils.SearchUpfolder(System.IO.Directory.GetCurrentDirectory(), "Metapsi.Html.Generate"),
                    "html-tags.json"));

        var allTags = System.Text.Json.JsonSerializer.Deserialize<List<TagDefinition>>(jsonDefinitionsText);

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

        foreach (var tag in allTags.Where(x => !SkippedTags.Contains(x.name)))
        {
            CSharpComponent csComponent = new()
            {
                ClassName = "Html" + Utils.ToCSharpValidName(tag.name),
                HtmlTag = tag.name
            };
            csComponent.Comments.Add($"The HTML {tag.name} tag");

            foreach (var stringAttribute in tag.battrs)
            {
                var defaultTrueSetter= new CSharpPropertySetter()
                {
                    SetterName = "Set" + Utils.Capitalize(Utils.ToCSharpValidName(stringAttribute)),
                    ClientSidePropertyName = stringAttribute,
                    CSharpType = "bool",
                    DefaultValue = ""
                };

                csComponent.AttributeSetters.Add(defaultTrueSetter);

                var valueSetter = new CSharpPropertySetter()
                {
                    SetterName = "Set" + Utils.Capitalize(Utils.ToCSharpValidName(stringAttribute)),
                    ClientSidePropertyName = stringAttribute,
                    CSharpType = "bool",
                };
                valueSetter.Parameters.Add(new CSharpPropertySetterParameter()
                {
                    CSharpType = "bool",
                    ParameterName = Utils.ToParameterName(stringAttribute)
                });
                csComponent.AttributeSetters.Add(valueSetter);
            }

            foreach (var stringAttribute in tag.sattrs)
            {
                var setter = new CSharpPropertySetter()
                {
                    SetterName = "Set" + Utils.Capitalize(Utils.ToCSharpValidName(stringAttribute)),
                    ClientSidePropertyName = stringAttribute,
                    CSharpType = "string",
                };
                setter.Parameters.Add(new CSharpPropertySetterParameter()
                {
                    CSharpType = "string",
                    ParameterName = Utils.ToParameterName(stringAttribute)
                });

                csComponent.AttributeSetters.Add(setter);
            }

            await System.IO.File.WriteAllTextAsync(System.IO.Path.Combine(controlsOutputFolder, $"{csComponent.ClassName}.cs"), csComponent.ToCSharpFile("Metapsi.Html", CSharpConverter.DefaultUsingNamespaces));
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

public class TagDefinition
{
    public string name { get; set; }
    public List<string> sattrs { get; set; } = new List<string>();
    public List<string> battrs { get; set; } = new List<string>();
}