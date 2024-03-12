using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Metapsi.WebComponentGenerator;

public class WebComponentsModule
{
    public List<WebComponent> Components { get; set; } = new List<WebComponent>();
}

public class WebComponent
{
    public string Name { get; set; }
    public string Tag { get; set; }
    public string Description { get; set; }
    public List<WebComponentProperty> Properties { get; set; } = new();
    public List<WebComponentEvent> Events { get; set; } = new();
    public List<WebComponentSlot> Slots { get; set; } = new();
    public List<WebComponentMethod> Methods { get; set; } = new();
}

public class WebComponentProperty
{
    public string Name { get; set; }
    public string Description { get; set; }
    public ITypeScriptType TypeScriptType { get; set; }
}

public class WebComponentPropertyType
{
    public List<string> EnumValues { get; set; } = new();
    public bool IsCollection { get; set; }
    public string ItemType { get; set; }
}

public class WebComponentSlot
{
    public string Name { get; set; }
    public string Comment { get; set; }
}

public class WebComponentEvent
{
    public string Name { get; set; }
    public string Comment { get; set; }
    public ITypeScriptType Type { get; set; }
}

public class WebComponentMethod
{
    public string Name { get; set; }
    public string Comment { get; set; }
    public string Signature { get; set; }
    public List<WebComponentMethodParameter> Parameters { get; set; } = new();
}

public class WebComponentMethodParameter
{
    public string Name { get; set; } = string.Empty;
    public string Type { get; set; }
    public string Comment { get; set; } = string.Empty;
}

public class CSharpConverter
{
    public List<string> UsingNamespaces { get; set; } = DefaultUsingNamespaces;
    public string Namespace { get; set; }
    public string NodeConstructor { get; set; } = "H";

    public Func<ITypeScriptType, CSharpConverter, string> ToCSharpType { get; set; } = DefaultToCSharpType;

    public static List<string> DefaultUsingNamespaces
    {
        get
        {
            return new List<string>()
            {
                "Metapsi.Hyperapp",
                "Metapsi.Syntax",
                "System",
                "System.Collections.Generic",
                "Metapsi.Ui"
            };
        }
    }

    public static string DefaultToCSharpType(ITypeScriptType typeScriptType, CSharpConverter converter)
    {
        switch (typeScriptType)
        {
            case TypeScriptObjectType objectType:
                {
                    var csharpTypeName = objectType.TypeName;
                    if (objectType.TypeName == "boolean")
                        csharpTypeName = "bool";

                    if (objectType.TypeName == "number")
                        csharpTypeName = "int";

                    if (objectType.TypeName == "any")
                        csharpTypeName = "object";

                    if (objectType.TypeName.Trim().EndsWith("<any>"))
                    {
                        csharpTypeName = objectType.TypeName.Trim().Replace("<any>", string.Empty);
                    }

                    return csharpTypeName;
                }

            case TypeScriptUnion unionType:
                {
                    var uselessUnions = unionType.Options.Where(x => x is TypeScriptObjectType).Where(x => (x as TypeScriptObjectType).TypeName == "undefined");

                    if (unionType.Options.Count() == uselessUnions.Count() + 1)
                    {
                        return unionType.Options.Except(uselessUnions).Single().ToCSharpType(converter);
                    }

                    return "object";
                }

            case TypeScriptCollection collectionType:
                {
                    return $"List<{collectionType.ItemType.ToCSharpType(converter)}>";
                }
            case TypeScriptDictionary dictionaryType:
                return "object";
        }

        throw new NotImplementedException();
    }
}
