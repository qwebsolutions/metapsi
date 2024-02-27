
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

public static class Program
{
    public static async Task Main(string[] args)
    {

        if (args.Length == 0)
        {
            Console.WriteLine("Full path to custom elements metadata file needs to be passed as parameter");
            return;
        }

        var customElementsJsonPath = args[0];

        if (!System.IO.Path.IsPathFullyQualified(customElementsJsonPath))
        {
            Console.WriteLine(customElementsJsonPath + ": path is not fully qualified");
            return;
        }

        var shoelaceProjectFolder = StaticFunctions.SearchUpfolder(System.IO.Path.GetDirectoryName(customElementsJsonPath), "Metapsi.Shoelace");

        if (string.IsNullOrEmpty(shoelaceProjectFolder))
        {
            Console.WriteLine("Project folder Metapsi.Shoelace not found");
            return;
        }

        var metadataText = await System.IO.File.ReadAllTextAsync(customElementsJsonPath);
        var metadata = System.Text.Json.JsonSerializer.Deserialize<CustomElementsMetadata>(metadataText);

        var shoelaceControlsOutputFolder = System.IO.Path.Combine(shoelaceProjectFolder, "Controls");

        System.IO.Directory.Delete(shoelaceControlsOutputFolder, true);
        System.IO.Directory.CreateDirectory(shoelaceControlsOutputFolder);

        foreach (var module in metadata.modules)
        {
            foreach (var declaration in module.declarations.Where(x => !StaticFunctions.SkippedControls().Contains(x.name)))
            {
                ShoelaceComponent shoelaceComponent = new ShoelaceComponent()
                {
                    Name = declaration.name,
                    Description = declaration.summary,
                    Tag = declaration.tagName
                };

                foreach (var member in declaration.members.Where(x => x.kind == "field").Where(x => !x.@static).Where(x => x.privacy != "private"))
                {
                    var shoelaceField = new ShoelaceField()
                    {
                        Name = member.name,
                        Description = member.description.Replace("\r", string.Empty).Replace("\n", " "),
                        Type = member.type.text
                    };

                    if (member.type.text == "boolean")
                    {
                        shoelaceField.Type = "bool";
                    }
                    else if (member.type.text == "number")
                    {
                        shoelaceField.Type = "int";
                    }
                    else if (member.@default == "Infinity")
                    {
                        shoelaceField.Type = "int";
                    }
                    else if (member.type.text == "CSSNumberish")
                    {
                        shoelaceField.Type = "decimal";
                    }
                    else if (member.name == "duration")
                    {
                        shoelaceField.Type = "int";
                    }
                    else if (member.type.text.Contains("|"))
                    {
                        if (member.type.text.Contains("Keyframe[]"))
                        {
                            shoelaceField.Type = "List<Keyframe>";
                        }
                        else if (member.type.text.Contains("[]"))
                        {
                            // Is not really an enum, it accepts single or multiple values
                            Console.WriteLine($"{shoelaceComponent.Name}.{member.name} {member.type.text}");
                        }
                        else if (member.type.text == "string | undefined")
                        {
                            shoelaceField.Type = "string";
                        }
                        else //if (!member.type.text.Contains("undefined"))
                        {
                            var withoutUndefined = member.type.text.Replace("| undefined", string.Empty);

                            shoelaceField.Type = $"{shoelaceComponent.Name}{StaticFunctions.Capitalize(member.name)}";
                            shoelaceComponent.SupportEnums.Add(new ShoelaceSupportEnum()
                            {
                                Name = shoelaceField.Type,
                                Options = withoutUndefined.Split("|", StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries).Select(x => StaticFunctions.FixEnumOptionSyntax(x.Replace("'", string.Empty))).ToList()
                            });
                        }
                    }

                    if (StaticFunctions.IsValidField(member))
                    {
                        shoelaceComponent.PropsFields.Add(shoelaceField);
                    }
                }

                foreach (var @event in declaration.events)
                {
                    shoelaceComponent.Events.Add(new ShoelaceEvent()
                    {
                        Name = @event.name,
                        Comment = @event.description,
                        Type = @event.type.text
                    });
                }

                foreach (var slot in declaration.slots)
                {
                    if (!string.IsNullOrEmpty(slot.name))
                    {
                        shoelaceComponent.Slots.Add(new ShoelaceSlot()
                        {
                            Name = slot.name,
                            Comment = slot.description
                        });
                    }
                }

                await System.IO.File.WriteAllTextAsync($"C:\\github\\qwebsolutions\\metapsi\\Metapsi.Shoelace\\Controls\\{shoelaceComponent.Name}.cs", shoelaceComponent.ToCShap());
            }
        }

        Console.WriteLine(metadata);
    }
}


public static class StaticFunctions
{
    public static string SearchUpfolder(string startPath, string folderName)
    {
        if (string.IsNullOrEmpty(startPath))
            return string.Empty;

        var currentDirectories = System.IO.Directory.GetDirectories(startPath);
        var matchingPath = currentDirectories.FirstOrDefault(x => x.Split("\\").LastOrDefault(x => x == folderName) != null);
        if (matchingPath != null)
            return matchingPath;

        matchingPath = currentDirectories.FirstOrDefault(x => x.Split("\\").LastOrDefault(x => x == folderName) != null);
        if (matchingPath != null)
            return matchingPath;

        return SearchUpfolder(System.IO.Path.GetDirectoryName(startPath), folderName);
    }

    public static string SlotNameCapitalized(string slot)
    {
        return string.Join(null, slot.Split("-").Select(x => Capitalize(x)));
    }

    public static string SlotName(string slot)
    {
        return UnCapitalize(string.Join(null, slot.Split("-").Select(x => Capitalize(x))));
    }

    public static HashSet<string> SkippedControls()
    {
        return new HashSet<string>() { "SlPopup" };
    }

    public static List<string> AnimationDirections()
    {
        return new List<string>() { "normal", "reverse", "alternate", "alternate-reverse" };
    }

    public static List<string> FillModes()
    {
        return new List<string>() { "none", "forwards", "backwards", "both" };
    }

    public static bool IsValidField(CustomElementsMember member)
    {
        // It seems the fields that are not documented are not public
        if(string.IsNullOrEmpty(member.description))
            return false;

        if (string.IsNullOrEmpty(member.type.text))
            return false;

        if (member.type.text.Contains("HTML"))
            return false;

        if (member.type.text.Contains("SVG"))
            return false;

        if (member.type.text.Contains("Observer"))
            return false;

        //if (member.type.text.Contains("undefined"))
        //    return false;

        if (member.type.text == "SlPopup")
            return false;

        if (member.type.text.Contains("Option"))
            return false;

        return true;
    }

    public static HashSet<string> ReservedKeywords()
    {
        HashSet<string> reservedKeywords = new HashSet<string>() { "default", "string", "readonly", "checked", "short", "long", "byte", "decimal" };
        return reservedKeywords;
    }

    public static string ToCSharpValueType(string type)
    {
        if (type == "string | string[]")
            return "string";
        return type;
    }

    public static string ToCSharpDetailType(string docType)
    {
        if (docType.Contains("ResizeObserverEntry"))
            return string.Empty;

        if (docType.Contains("MutationRecord"))
            return string.Empty;

        if (docType.Contains("[]"))
            return $"List<IClientSide{docType.Replace("[]", string.Empty)}>";

        if (docType.Contains("|"))
            return "string";

        if (docType == "string")
            return "string";

        if (docType == "String")
            return "string";

        if (docType == "number")
            return "int";

        if (docType == "boolean")
            return "bool";

        return $"IClientSide{docType}";
    }

    public static string Capitalize(string s)
    {
        //s = RemoveAt(s);
        return s.Length == 1 ? s.ToUpperInvariant() : s.Substring(0, 1).ToUpperInvariant() + s.Substring(1);
    }

    public static string UnCapitalize(string s)
    {
        //s = RemoveAt(s);
        return s.Length == 1 ? s.ToLowerInvariant() : s.Substring(0, 1).ToLowerInvariant() + s.Substring(1);
    }

    //public static string RemoveAt(string s)
    //{
    //    if (s.StartsWith("@"))
    //    {
    //        return s.Substring(1);
    //    }

    //    return s;
    //}

    public static ShoelaceSupportEnumOption FixEnumOptionSyntax(string field)
    {
        ShoelaceSupportEnumOption option = new ShoelaceSupportEnumOption()
        {
            Name = field,
            Description = field
        };

        var validName = field.Replace("-", string.Empty).Replace("/", string.Empty);

        //if (ReservedKeywords().Contains(validName))
        //{
        //    validName = $"@{validName}";
        //}

        option.Name = validName;

        return option;
    }
}
public class ShoelaceComponent
{
    public string Name { get; set; }
    public string Tag { get; set; }
    public string Description { get; set; }
    public List<ShoelaceSupportEnum> SupportEnums { get; set; } = new List<ShoelaceSupportEnum>();
    public List<ShoelaceField> PropsFields { get; set; } = new List<ShoelaceField>();
    public List<ShoelaceEvent> Events { get; set; } = new List<ShoelaceEvent>();
    public List<ShoelaceSlot> Slots { get; set; } = new List<ShoelaceSlot>();

    private string ArgsName(ShoelaceEvent @event)
    {
        return $"{Name}{StaticFunctions.SlotNameCapitalized(@event.Name.Replace("sl-", string.Empty))}Args";
    }

    public string ToCShap()
    {
        StringBuilder codeBuilder = new StringBuilder();
        codeBuilder.AppendLine("using Metapsi.Hyperapp;");
        codeBuilder.AppendLine("using Metapsi.Syntax;");
        codeBuilder.AppendLine("using System;");
        codeBuilder.AppendLine("using System.Collections.Generic;");
        codeBuilder.AppendLine("using Metapsi.Ui;");
        codeBuilder.AppendLine("using System.ComponentModel;");
        codeBuilder.AppendLine();
        codeBuilder.AppendLine("namespace Metapsi.Shoelace;");
        codeBuilder.AppendLine();
        codeBuilder.AppendLine();

        codeBuilder.AppendLine($"public partial interface IClientSide{Name}");
        codeBuilder.AppendLine("{");
        var valueField = PropsFields.SingleOrDefault(x => x.Name == "value");
        if (valueField != null)
        {
            codeBuilder.AppendLine($"    public {StaticFunctions.ToCSharpValueType(valueField.Type)} {valueField.Name} {{ get; set; }}");
        }
        codeBuilder.AppendLine("}");

        foreach (var @event in Events)
        {
            codeBuilder.AppendLine($"public partial class {ArgsName(@event)}");
            codeBuilder.AppendLine("{");
            codeBuilder.AppendLine($"    public IClientSide{Name} target {{ get; set; }}");
            if (!string.IsNullOrWhiteSpace(@event.Type))
            {
                var details = @event.Type.Replace("{", string.Empty).Replace("}", string.Empty).Split(",", StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim());

                List<(string type, string name)> detailsList = new List<(string type, string name)>();

                foreach (var detail in details)
                {
                    var nameAndType = detail.Split(":", StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToList();
                    detailsList.Add((StaticFunctions.ToCSharpDetailType(nameAndType[1]), nameAndType[0]));
                }

                var validDetails = detailsList.Where(x => !string.IsNullOrWhiteSpace(x.type));
                if (validDetails.Any())
                {
                    codeBuilder.AppendLine("    public partial class Details ");
                    codeBuilder.AppendLine("    {");
                    foreach (var validDetail in validDetails)
                    {
                        codeBuilder.AppendLine($"        public {validDetail.type} {validDetail.name} {{ get; set; }}");
                    }
                    codeBuilder.AppendLine("    }");
                    codeBuilder.AppendLine("    public Details detail { get; set; }");
                }
            }
            codeBuilder.AppendLine("}");
        }

        codeBuilder.AppendLine($"public static partial class {Name}Control");
        codeBuilder.AppendLine("{");
        codeBuilder.AppendLine("    /// <summary>");
        codeBuilder.AppendLine($"    /// {Description}");
        codeBuilder.AppendLine("    /// </summary>");
        codeBuilder.AppendLine($"    public static Var<IVNode> {Name}(this LayoutBuilder b, Action<PropsBuilder<{Name}>> buildProps, Var<List<IVNode>> children)");
        codeBuilder.AppendLine("    {");
        codeBuilder.AppendLine($"        return b.SlNode(\"{Tag}\", buildProps, children);");
        codeBuilder.AppendLine("    }");

        codeBuilder.AppendLine("    /// <summary>");
        codeBuilder.AppendLine($"    /// {Description}");
        codeBuilder.AppendLine("    /// </summary>");
        codeBuilder.AppendLine($"    public static Var<IVNode> {Name}(this LayoutBuilder b, Action<PropsBuilder<{Name}>> buildProps, params Var<IVNode>[] children)");
        codeBuilder.AppendLine("    {");
        codeBuilder.AppendLine($"        return b.SlNode(\"{Tag}\", buildProps, children);");
        codeBuilder.AppendLine("    }");


        foreach (var property in PropsFields)
        {
            // Set each enum value
            if (SupportEnums.Any(x => property.Type == x.Name))
            {
                var supportEnum = SupportEnums.Single(x => x.Name == property.Type);

                foreach (var option in supportEnum.Options)
                {
                    codeBuilder.AppendLine("    /// <summary>");
                    codeBuilder.AppendLine($"    /// {property.Description}");
                    codeBuilder.AppendLine("    /// </summary>");
                    codeBuilder.AppendLine($"    public static void Set{StaticFunctions.Capitalize(property.Name)}{StaticFunctions.Capitalize(option.Name)}(this PropsBuilder<{Name}> b)");
                    codeBuilder.AppendLine("    {");
                    codeBuilder.AppendLine($"        b.SetDynamic(b.Props, DynamicProperty.String(\"{property.Name}\"), b.Const(\"{option.Description}\"));");
                    codeBuilder.AppendLine("    }");
                }
            }
            else
            {
                if (property.Type == "(value: number) => string")
                {
                    codeBuilder.AppendLine("    /// <summary>");
                    codeBuilder.AppendLine($"    /// {property.Description}");
                    codeBuilder.AppendLine("    /// </summary>");
                    codeBuilder.AppendLine($"    public static void Set{StaticFunctions.Capitalize(property.Name)}(this PropsBuilder<{Name}> b, Var<Func<int,string>> f)");
                    codeBuilder.AppendLine("    {");
                    codeBuilder.AppendLine($"        b.SetDynamic(b.Props, new DynamicProperty<Func<int,string>>(\"{property.Name}\"), f);");
                    codeBuilder.AppendLine("    }");
                }
                else if (property.Type.Contains("string[]"))
                {
                    codeBuilder.AppendLine("    /// <summary>");
                    codeBuilder.AppendLine($"    /// {property.Description}");
                    codeBuilder.AppendLine("    /// </summary>");
                    codeBuilder.AppendLine($"    public static void Set{StaticFunctions.Capitalize(property.Name)}(this PropsBuilder<{Name}> b, Var<string> value)");
                    codeBuilder.AppendLine("    {");
                    codeBuilder.AppendLine($"        b.SetDynamic(b.Props, DynamicProperty.String(\"{property.Name}\"), value);");
                    codeBuilder.AppendLine("    }");

                    codeBuilder.AppendLine("    /// <summary>");
                    codeBuilder.AppendLine($"    /// {property.Description}");
                    codeBuilder.AppendLine("    /// </summary>");
                    codeBuilder.AppendLine($"    public static void Set{StaticFunctions.Capitalize(property.Name)}s(this PropsBuilder<{Name}> b, Var<List<string>> values)");
                    codeBuilder.AppendLine("    {");
                    codeBuilder.AppendLine($"        b.SetDynamic(b.Props, new DynamicProperty<List<string>>(\"{property.Name}\"), values);");
                    codeBuilder.AppendLine("    }");
                }
                else if (property.Type == "bool")
                {
                    codeBuilder.AppendLine("    /// <summary>");
                    codeBuilder.AppendLine($"    /// {property.Description}");
                    codeBuilder.AppendLine("    /// </summary>");
                    codeBuilder.AppendLine($"    public static void Set{StaticFunctions.Capitalize(property.Name)}(this PropsBuilder<{Name}> b)");
                    codeBuilder.AppendLine("    {");
                    codeBuilder.AppendLine($"        b.SetDynamic(b.Props, DynamicProperty.Bool(\"{property.Name}\"), b.Const(true));");
                    codeBuilder.AppendLine("    }");
                }
                else if (property.Type == "PlaybackDirection")
                {
                    foreach (var animationDirection in StaticFunctions.AnimationDirections())
                    {
                        codeBuilder.AppendLine("    /// <summary>");
                        codeBuilder.AppendLine($"    /// {property.Description}");
                        codeBuilder.AppendLine("    /// </summary>");
                        codeBuilder.AppendLine($"    public static void Set{StaticFunctions.Capitalize(property.Name)}{StaticFunctions.SlotNameCapitalized(animationDirection)}(this PropsBuilder<{Name}> b)");
                        codeBuilder.AppendLine("    {");
                        codeBuilder.AppendLine($"        b.SetDynamic(b.Props, DynamicProperty.String(\"{property.Name}\"), b.Const(\"{animationDirection}\"));");
                        codeBuilder.AppendLine("    }");
                    }
                }
                else if (property.Type == "FillMode")
                {
                    foreach (var fillMode in StaticFunctions.FillModes())
                    {
                        codeBuilder.AppendLine("    /// <summary>");
                        codeBuilder.AppendLine($"    /// {property.Description}");
                        codeBuilder.AppendLine("    /// </summary>");
                        codeBuilder.AppendLine($"    public static void Set{StaticFunctions.Capitalize(property.Name)}{StaticFunctions.SlotNameCapitalized(fillMode)}(this PropsBuilder<{Name}> b)");
                        codeBuilder.AppendLine("    {");
                        codeBuilder.AppendLine($"        b.SetDynamic(b.Props, DynamicProperty.String(\"{property.Name}\"), b.Const(\"{fillMode}\"));");
                        codeBuilder.AppendLine("    }");
                    }
                }
                else
                {
                    codeBuilder.AppendLine("    /// <summary>");
                    codeBuilder.AppendLine($"    /// {property.Description}");
                    codeBuilder.AppendLine("    /// </summary>");
                    codeBuilder.AppendLine($"    public static void Set{StaticFunctions.Capitalize(property.Name)}(this PropsBuilder<{Name}> b, Var<{property.Type}> value)");
                    codeBuilder.AppendLine("    {");
                    codeBuilder.AppendLine($"        b.SetDynamic(b.Props, new DynamicProperty<{property.Type}>(\"{property.Name}\"), value);");
                    codeBuilder.AppendLine("    }");


                    codeBuilder.AppendLine("    /// <summary>");
                    codeBuilder.AppendLine($"    /// {property.Description}");
                    codeBuilder.AppendLine("    /// </summary>");
                    codeBuilder.AppendLine($"    public static void Set{StaticFunctions.Capitalize(property.Name)}(this PropsBuilder<{Name}> b, {property.Type} value)");
                    codeBuilder.AppendLine("    {");
                    codeBuilder.AppendLine($"        b.SetDynamic(b.Props, new DynamicProperty<{property.Type}>(\"{property.Name}\"), b.Const(value));");
                    codeBuilder.AppendLine("    }");
                }
            }
        }

        foreach (var @event in Events)
        {
            Console.WriteLine($"{@event.Name} {@event.Comment} {@event.Type}");
            codeBuilder.AppendLine("    /// <summary>");
            codeBuilder.AppendLine($"    /// {@event.Comment}");
            if (!string.IsNullOrWhiteSpace(@event.Type))
            {
                codeBuilder.AppendLine($"    /// event detail: {@event.Type}");
            }
            codeBuilder.AppendLine("    /// </summary>");
            codeBuilder.AppendLine($"    public static void On{StaticFunctions.SlotNameCapitalized(@event.Name)}<TModel>(this PropsBuilder<{Name}> b, Var<HyperType.Action<TModel, {ArgsName(@event)}>> action)");
            codeBuilder.AppendLine("    {");
            codeBuilder.AppendLine($"        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, {ArgsName(@event)}>>(\"on{@event.Name}\"), action);");
            codeBuilder.AppendLine("    }");

            codeBuilder.AppendLine("    /// <summary>");
            codeBuilder.AppendLine($"    /// {@event.Comment}");
            if (!string.IsNullOrWhiteSpace(@event.Type))
            {
                codeBuilder.AppendLine($"    /// event detail: {@event.Type}");
            }
            codeBuilder.AppendLine("    /// </summary>");
            codeBuilder.AppendLine($"    public static void On{StaticFunctions.SlotNameCapitalized(@event.Name)}<TModel>(this PropsBuilder<{Name}> b, System.Func<SyntaxBuilder, Var<TModel>, Var<{ArgsName(@event)}>, Var<TModel>> action)");
            codeBuilder.AppendLine("    {");
            codeBuilder.AppendLine($"        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, {ArgsName(@event)}>>(\"on{@event.Name}\"), b.MakeAction(action));");
            codeBuilder.AppendLine("    }");
        }

        codeBuilder.AppendLine("}");
        codeBuilder.AppendLine();

        codeBuilder.AppendLine("/// <summary>");
        codeBuilder.AppendLine($"/// {Description}");
        codeBuilder.AppendLine("/// </summary>");
        codeBuilder.AppendLine($"public partial class {Name} : HtmlTag");
        codeBuilder.AppendLine("{");
        codeBuilder.AppendLine($"    public {Name}()");
        codeBuilder.AppendLine("    {");
        codeBuilder.AppendLine($"        this.Tag = \"{Tag}\";");
        codeBuilder.AppendLine("    }");
        codeBuilder.AppendLine();
        codeBuilder.AppendLine($"    public static {Name} New()");
        codeBuilder.AppendLine("    {");
        codeBuilder.AppendLine($"        return new {Name}();");
        codeBuilder.AppendLine("    }");

        if (Slots.Any())
        {
            codeBuilder.AppendLine("    public static class Slot");
            codeBuilder.AppendLine("    {");
            foreach (var slot in Slots)
            {
                codeBuilder.AppendLine("        /// <summary> ");
                codeBuilder.AppendLine($"        /// {slot.Comment}");
                codeBuilder.AppendLine("        /// </summary>");
                codeBuilder.AppendLine($"        public const string {StaticFunctions.SlotNameCapitalized(slot.Name)} = \"{slot.Name}\";");
            }
            codeBuilder.AppendLine("    }");
        }

        codeBuilder.AppendLine("}");
        codeBuilder.AppendLine();

        codeBuilder.AppendLine($"public static partial class {Name}Control");
        codeBuilder.AppendLine("{");
        foreach (var property in PropsFields)
        {
            // Cannot set functions server-side
            if (property.Type.Contains("=>"))
                continue;

            // Set each enum value
            if (SupportEnums.Any(x => property.Type == x.Name))
            {
                var supportEnum = SupportEnums.Single(x => x.Name == property.Type);

                foreach (var option in supportEnum.Options)
                {
                    codeBuilder.AppendLine("    /// <summary>");
                    codeBuilder.AppendLine($"    /// {property.Description}");
                    codeBuilder.AppendLine("    /// </summary>");

                    codeBuilder.AppendLine($"    public static {Name} Set{StaticFunctions.Capitalize(property.Name)}{StaticFunctions.Capitalize(option.Name)}(this {Name} tag)");
                    codeBuilder.AppendLine("    {");
                    codeBuilder.AppendLine($"        return tag.SetAttribute(\"{property.Name}\", \"{option.Description}\");");
                    codeBuilder.AppendLine("    }");
                }
            }
            else if (property.Type.Contains("string[]"))
            {
                codeBuilder.AppendLine("    /// <summary>");
                codeBuilder.AppendLine($"    /// {property.Description}");
                codeBuilder.AppendLine("    /// </summary>");

                codeBuilder.AppendLine($"    public static {Name} Set{StaticFunctions.Capitalize(property.Name)}(this {Name} tag, string value)");
                codeBuilder.AppendLine("    {");
                codeBuilder.AppendLine($"        return tag.SetAttribute(\"{property.Name}\", value);");
                codeBuilder.AppendLine("    }");
            }
            else if (property.Type == "bool")
            {
                codeBuilder.AppendLine("    /// <summary>");
                codeBuilder.AppendLine($"    /// {property.Description}");
                codeBuilder.AppendLine("    /// </summary>");
                codeBuilder.AppendLine($"    public static {Name} Set{StaticFunctions.Capitalize(property.Name)}(this {Name} tag)");
                codeBuilder.AppendLine("    {");
                codeBuilder.AppendLine($"        return tag.SetAttribute(\"{property.Name}\", \"true\");");
                codeBuilder.AppendLine("    }");
            }
            else if (property.Type == "PlaybackDirection")
            {
                foreach (var animationDirection in StaticFunctions.AnimationDirections())
                {
                    codeBuilder.AppendLine("    /// <summary>");
                    codeBuilder.AppendLine($"    /// {property.Description}");
                    codeBuilder.AppendLine("    /// </summary>");
                    codeBuilder.AppendLine($"    public static {Name} Set{StaticFunctions.Capitalize(property.Name)}{StaticFunctions.SlotNameCapitalized(animationDirection)}(this {Name} tag)");
                    codeBuilder.AppendLine("    {");
                    codeBuilder.AppendLine($"        return tag.SetAttribute(\"{property.Name}\", \"{animationDirection}\");");
                    codeBuilder.AppendLine("    }");
                }
            }
            else if (property.Type == "FillMode")
            {
                foreach (var fillMode in StaticFunctions.FillModes())
                {
                    codeBuilder.AppendLine("    /// <summary>");
                    codeBuilder.AppendLine($"    /// {property.Description}");
                    codeBuilder.AppendLine("    /// </summary>");
                    codeBuilder.AppendLine($"    public static {Name} Set{StaticFunctions.Capitalize(property.Name)}{StaticFunctions.SlotNameCapitalized(fillMode)}(this {Name} tag)");
                    codeBuilder.AppendLine("    {");
                    codeBuilder.AppendLine($"        return tag.SetAttribute(\"{property.Name}\", \"{fillMode}\");");
                    codeBuilder.AppendLine("    }");
                }
            }
            else
            {
                codeBuilder.AppendLine("    /// <summary>");
                codeBuilder.AppendLine($"    /// {property.Description}");
                codeBuilder.AppendLine("    /// </summary>");
                codeBuilder.AppendLine($"    public static {Name} Set{StaticFunctions.Capitalize(property.Name)}(this {Name} tag, {property.Type} value)");
                codeBuilder.AppendLine("    {");
                codeBuilder.AppendLine($"        return tag.SetAttribute(\"{property.Name}\", value.ToString());");
                codeBuilder.AppendLine("    }");
            }
        }
        codeBuilder.AppendLine("}");
        codeBuilder.AppendLine();


        return codeBuilder.ToString();
    }
}

public class ShoelaceField
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string Type { get; set; }
}

public class ShoelaceSupportEnum
{
    public string Name { get; set; }
    public List<ShoelaceSupportEnumOption> Options { get; set; } = new List<ShoelaceSupportEnumOption>();
}

public class ShoelaceSupportEnumOption
{
    public string Name { get; set; }
    public string Description { get; set; }

    public string ToCSharp()
    {
        return $"[Description(\"{Description}\")]\r\n    {Name}";
    }
}

public class ShoelaceSlot
{
    public string Name { get; set; }
    public string Comment { get; set; }
}

public class ShoelaceEvent
{
    public string Name { get; set; }
    public string Comment { get; set; }
    public string Type { get; set; }
}

public class CustomElementsMetadata
{
    public string schemaVersion { get; set; }
    public string readme { get; set; }
    public List<CustomElementsModule> modules { get; set; } = new List<CustomElementsModule>();
}

public class CustomElementsModule
{
    public string kind { get; set; }
    public string path { get; set; }
    public List<CustomElementsDeclaration> declarations { get; set; } = new List<CustomElementsDeclaration>();
}

public class CustomElementsDeclaration
{
    public string kind { get; set; }
    public string description { get; set; }
    public string name { get; set; }
    public List<CustomElementsCssPart> cssParts { get; set; } = new List<CustomElementsCssPart>();
    public List<CustomElementsSlots> slots { get; set; } = new List<CustomElementsSlots>();
    public List<CustomElementsMember> members { get; set; } = new List<CustomElementsMember>();
    public List<CustomElementsEvent> events { get; set; } = new List<CustomElementsEvent>();
    public List<CustomElementsAttribute> attributes { get; set; } = new List<CustomElementsAttribute>();
    public string summary { get; set; }
    public List<CustomElementsAnimation> animations { get; set; } = new List<CustomElementsAnimation>();
    public string tagName { get; set; }
}

public class CustomElementsCssPart
{
    public string description { get;set; }
    public string name { get; set; }
}

public class CustomElementsSlots
{
    public string description { get; set; }
    public string name { get; set; }
}

public class CustomElementsMember
{
    public string kind { get; set; }
    public string name { get; set; }
    public CustomElementsType type { get; set; } = new();
    public string description { get; set; } = string.Empty;
    public string attribute { get; set; }
    public string @default { get; set; }
    public bool @static { get; set; }
    public string privacy { get; set; }
    public bool reflects { get; set; }
}

public class CustomElementsType
{
    public string text { get; set; } = string.Empty;
}

public class CustomElementsEvent
{
    public string description { get; set; }
    public string name { get; set; }
    public CustomElementsType type { get; set; } = new();
}

public class CustomElementsAttribute
{
    public string name { get; set; }
    public CustomElementsType type { get; set; }
    public string @default { get; set; }
    public string description { get; set; }
}

public class CustomElementsAnimation
{
    public string name { get; set; }
    public string description { get; set; }
}