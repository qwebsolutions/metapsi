
using Metapsi.WebComponentGenerator;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

public static class Program
{
    public static async Task Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("Package version not specified!");
            return;
        }

        var version = args[0];

        var metadataFileUrl = Utils.JsDelivrFileUrl("ionic", "core", version, "docs.json");

        var packageMetadata = await new HttpClient().GetStringAsync(metadataFileUrl);

        var ionicGeneratorFolder = Utils.SearchUpfolder(System.IO.Path.GetDirectoryName(Directory.GetCurrentDirectory()), "Metapsi.Ionic.Generate");

        await System.IO.File.WriteAllTextAsync(System.IO.Path.Combine(ionicGeneratorFolder, "docs" + version + ".json"), packageMetadata);


        var ionicProjectFolder = Utils.SearchUpfolder(System.IO.Path.GetDirectoryName(Directory.GetCurrentDirectory()), "Metapsi.Ionic");

        if (string.IsNullOrEmpty(ionicProjectFolder))
        {
            Console.WriteLine("Project folder Metapsi.Ionic not found");
            return;
        }

        var metadata = System.Text.Json.JsonSerializer.Deserialize<IonicMetadata>(packageMetadata);

        var controlsOutputFolder = System.IO.Path.Combine(ionicProjectFolder, "Controls");

        if (System.IO.Directory.Exists(controlsOutputFolder))
        {
            System.IO.Directory.Delete(controlsOutputFolder, true);
        }
        System.IO.Directory.CreateDirectory(controlsOutputFolder);

        var typeLibraryOutputFolder = System.IO.Path.Combine(ionicProjectFolder, "Types");

        if (System.IO.Directory.Exists(typeLibraryOutputFolder))
        {
            System.IO.Directory.Delete(typeLibraryOutputFolder, true);
        }
        System.IO.Directory.CreateDirectory(typeLibraryOutputFolder);


        CSharpConverter cSharpConverter = new CSharpConverter
        {
            Namespace = "Metapsi.Ionic",
            NodeConstructor = "IonicNode",
            BaseComponent = "IonComponent",
            ToCSharpType = (t, converter) =>
            {
                var defaultConversion = CSharpConverter.DefaultToCSharpType(t, converter);
                if (defaultConversion == "Function")
                {
                    return "Metapsi.Ionic.Function";
                }

                if (defaultConversion.Trim().StartsWith("Promise<"))
                    return "DynamicObject";

                return defaultConversion;
            }
        };

        foreach (var componentMetadata in metadata.components)
        {
            WebComponent webComponent = new()
            {
                Name = Utils.ToCSharpValidName(componentMetadata.tag),
                Description = componentMetadata.docs,
                Tag = componentMetadata.tag
            };

            foreach (var prop in componentMetadata.props)
            {
                var propType = prop.type;
                propType = propType.Replace("<any>", string.Empty);
                propType = propType.Replace("& Record<never, never>", string.Empty);

                var webComponentField = new WebComponentProperty()
                {
                    PropertyName = prop.name,
                    AttributeName = prop.attr,
                    Description = Utils.SingleLine(prop.docs)
                };

                webComponentField.TypeScriptType = TypeParser.GetTypeScriptType(propType);
                webComponent.Properties.Add(webComponentField);
            }

            foreach (var slot in componentMetadata.slots)
            {
                webComponent.Slots.Add(new WebComponentSlot()
                {
                    Name = slot.name,
                    Comment = Utils.SingleLine(slot.docs)
                });
            }

            foreach (var @event in componentMetadata.events)
            {
                var eventType = @event.detail;
                eventType = eventType.Replace("<any>", string.Empty);

                webComponent.Events.Add(new WebComponentEvent()
                {
                    Name = @event.@event,
                    Type = TypeParser.GetTypeScriptType(eventType),
                    Comment = Utils.SingleLine(@event.docs),
                    DetailPath = new() { "detail" }
                });
            }

            foreach (var method in componentMetadata.methods)
            {
                var webComponentMethod = new WebComponentMethod()
                {
                    Name = method.name,
                    Comment = Utils.SingleLine(method.docs)
                };

                webComponentMethod.Signature = method.complexType.signature;
                foreach (var parameter in method.complexType.parameters)
                {
                    webComponentMethod.Parameters.Add(new WebComponentMethodParameter()
                    {
                        Name = parameter.name,
                        Type = parameter.type,
                        Comment = Utils.SingleLine(parameter.docs),
                    });
                }
                webComponent.Methods.Add(webComponentMethod);
            }

            var csharpComponent = webComponent.ToCSharpComponent(cSharpConverter);
            //csharpComponent.BaseClassName = "IonComponent";
            csharpComponent.ClientSideConstructorName = "IonicNode";
            csharpComponent.ServerSideConstructorName = "IonicTag";
            foreach (var withSafeString in csharpComponent.PropertySetters.Where(x => x.CSharpType == "IonicSafeString"))
            {
                withSafeString.GenerateConst = false;
            }

            var csharpFile = csharpComponent.ToCSharpFile("Metapsi.Ionic", new List<string>()
            {
                "Metapsi.Hyperapp",
                "Metapsi.Syntax",
                "System",
                "System.Collections.Generic",
                "Metapsi.Html"
            });

            await System.IO.File.WriteAllTextAsync(System.IO.Path.Combine(controlsOutputFolder, $"{webComponent.Name}.cs"), csharpFile);
        }


        foreach (var libType in metadata.typeLibrary)
        {
            string declaration = libType.Value.declaration;

            if (!declaration.StartsWith("export interface"))
                continue;

            StringBuilder codeBuilder = new StringBuilder();

            var typeName = libType.Key.Split(":", StringSplitOptions.RemoveEmptyEntries).Last();

            var typeLines = declaration.Split('\n', StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim());

            string pendingComment = string.Empty;

            foreach (var typeScriptLine in typeLines)
            {
                if (typeScriptLine.StartsWith("export interface"))
                {
                    var csTypeDeclaration = typeScriptLine.Replace("export interface", "public class").Replace("<T = any>", string.Empty);

                    // The only instance of multiple inheritance
                    if (csTypeDeclaration.Contains("ScrollDetail"))
                    {
                        csTypeDeclaration = csTypeDeclaration.Replace("GestureDetail, ScrollBaseDetail", "ScrollBaseDetail, GestureDetail");
                    }

                    csTypeDeclaration = csTypeDeclaration.Replace(" extends ", " : ");
                    csTypeDeclaration = csTypeDeclaration.Trim().TrimEnd('{');
                    codeBuilder.AppendLine("namespace Metapsi.Ionic;");
                    codeBuilder.AppendLine();
                    codeBuilder.AppendLine(csTypeDeclaration);
                    codeBuilder.AppendLine("{");
                }
                else if (typeScriptLine == "}")
                {
                    codeBuilder.AppendLine("}");
                }
                else
                {
                    var propertyLine = typeScriptLine;

                    if (propertyLine.Contains("*"))
                    {
                        // It's actually a comment

                        pendingComment += Utils.SingleLine(propertyLine).Replace("*", string.Empty);
                        continue;
                    }

                    var tsName = propertyLine.Trim().Split(":").First();

                    if (tsName.Contains("[")) // Some sort of dictionary? Don't know how to handle it
                    {
                        pendingComment = string.Empty;
                        continue;
                    }

                    if (tsName.Contains("("))
                    {
                        pendingComment = string.Empty;
                        continue;
                    }

                    if (tsName.Contains("/")) // it's a : inside a comment
                        continue;

                    // Take just to ; as the line can have comments at the end
                    var tsType = propertyLine.Split(";").First().Replace(tsName + ":", string.Empty).Replace(";", string.Empty).Trim();
                    var csType = tsType;

                    if (tsType == "any")
                        csType = "DynamicObject";

                    if (tsType == "number")
                        csType = "int";

                    if (tsType == "boolean")
                        csType = "bool";

                    if (tsType == "T")
                        csType = "DynamicObject";

                    if (tsType.Contains("|"))
                    {
                        csType = "DynamicObject";
                        if(tsType == "LiteralUnion<'cancel' | 'destructive' | 'selected', string>")
                        {
                            csType = "string";
                        }
                        else if (tsType == "LiteralUnion<'cancel' | 'destructive', string>")
                        {
                            csType = "string";
                        }
                        else if(tsType == "string | string[]")
                        {
                            csType = "string";
                        }
                    }
                    else if (tsType.Contains("{"))
                        csType = "DynamicObject";
                    else if (tsType.Contains("<"))
                        csType = "DynamicObject";
                    else if (tsType.Contains("=>"))
                        csType = "DynamicObject";
                    else if (csType.Contains("[]"))
                    {
                        var itemType = tsType.Replace("[]", string.Empty);
                        if (itemType == "any")
                        {
                            itemType = "DynamicObject";
                        }
                        csType = $"System.Collections.Generic.List<{itemType}>";
                    }

                    var tsProperty = tsName.Replace("?", string.Empty).Trim();

                    if (tsProperty == "checked")
                        tsProperty = "@checked";

                    if (tsProperty == "delegate")
                        tsProperty = "@delegate";

                    if (tsProperty == "event")
                        tsProperty = "@event";

                    if (tsProperty == "params")
                        tsProperty = "@params";

                    codeBuilder.AppendLine("    /// <summary>");
                    if (!string.IsNullOrEmpty(pendingComment))
                    {
                        codeBuilder.AppendLine($"    /// {pendingComment}");
                        pendingComment = string.Empty;
                    }
                    codeBuilder.AppendLine($"    /// {Utils.ReplaceAngleBrackets(tsType)}");
                    codeBuilder.AppendLine("    /// </summary>");
                    codeBuilder.AppendLine($"    public {csType} {tsProperty} {{ get; set; }}");
                }
            }

            var csharpCode = codeBuilder.ToString();

            await System.IO.File.WriteAllTextAsync(System.IO.Path.Combine(typeLibraryOutputFolder, $"{typeName}.cs"), csharpCode);
        }

        StringBuilder importsBuilder = new StringBuilder();
        importsBuilder.AppendLine("namespace Metapsi.Ionic;");
        importsBuilder.AppendLine();
        importsBuilder.AppendLine("public static partial class Cdn");
        importsBuilder.AppendLine("{");
        importsBuilder.AppendLine($"    public static string Version = \"{version}\";");
        importsBuilder.AppendLine("}");

        await System.IO.File.WriteAllTextAsync(System.IO.Path.Combine(controlsOutputFolder, $"CdnPaths.cs"), importsBuilder.ToString());


        var csProjPath = System.IO.Path.Combine(ionicProjectFolder, "Metapsi.Ionic.csproj");
        var projectDescription = $"Use Ionic {version} with Metapsi for client-side generated web pages (https://ionicframework.com)";
        Utils.SetCsProjDescription(csProjPath, projectDescription);
    }
}