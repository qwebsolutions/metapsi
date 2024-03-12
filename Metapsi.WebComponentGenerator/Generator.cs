using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Xml.Linq;
using static System.Reflection.Metadata.BlobBuilder;

namespace Metapsi.WebComponentGenerator;

public static class Generator
{
    public static string ToCSharpFile(this WebComponent webComponent, CSharpConverter converter)
    {
        StringBuilder codeBuilder = new StringBuilder();

        foreach (var usingNamespace in converter.UsingNamespaces)
        {
            codeBuilder.AppendLine($"using {usingNamespace};");
        }
        codeBuilder.AppendLine();
        codeBuilder.AppendLine($"namespace {converter.Namespace};");
        codeBuilder.AppendLine();
        codeBuilder.AppendLine();

        codeBuilder.AppendLine($"public partial class {webComponent.Name}");
        codeBuilder.AppendLine("{");
        if (webComponent.Slots.Any())
        {
            var defaultSlot = webComponent.Slots.SingleOrDefault(x => string.IsNullOrWhiteSpace(x.Name));

            if (defaultSlot != null)
            {
                codeBuilder.AppendLine("    /// <summary> ");
                codeBuilder.AppendLine($"    /// {defaultSlot.Comment}");
                codeBuilder.AppendLine("    /// </summary>");
            }
            codeBuilder.AppendLine("    public static class Slot");
            codeBuilder.AppendLine("    {");
            foreach (var slot in webComponent.Slots.Where(x => x != defaultSlot))
            {
                codeBuilder.AppendLine("        /// <summary> ");
                codeBuilder.AppendLine($"        /// {slot.Comment}");
                codeBuilder.AppendLine("        /// </summary>");
                codeBuilder.AppendLine($"        public const string {Utils.ToCSharpValidName(slot.Name)} = \"{slot.Name}\";");
            }
            codeBuilder.AppendLine("    }");
        }

        if (webComponent.Methods.Any())
        {
            codeBuilder.AppendLine("    public static class Method");
            codeBuilder.AppendLine("    {");
            foreach (var method in webComponent.Methods)
            {
                codeBuilder.AppendLine("        /// <summary> ");
                codeBuilder.AppendLine($"        /// {Utils.ReplaceAngleBrackets(method.Comment)}");
                if (!string.IsNullOrWhiteSpace(method.Signature))
                {
                    codeBuilder.AppendLine($"        /// <para>{Utils.ReplaceAngleBrackets(method.Signature)}</para>");
                }
                foreach (var parameter in method.Parameters)
                {
                    codeBuilder.AppendLine($"        /// <para>{parameter.Name} {parameter.Comment}</para>");
                }
                codeBuilder.AppendLine("        /// </summary>");
                codeBuilder.AppendLine($"        public const string {Utils.ToCSharpValidName(method.Name)} = \"{method.Name}\";");
            }
            codeBuilder.AppendLine("    }");
        }

        codeBuilder.AppendLine("}");
        codeBuilder.AppendLine();

        codeBuilder.AppendLine($"public static partial class {webComponent.Name}Control");
        codeBuilder.AppendLine("{");
        codeBuilder.AppendLine("    /// <summary>");
        codeBuilder.AppendLine($"    /// {webComponent.Description}");
        codeBuilder.AppendLine("    /// </summary>");
        codeBuilder.AppendLine($"    public static Var<IVNode> {webComponent.Name}(this LayoutBuilder b, Action<PropsBuilder<{webComponent.Name}>> buildProps, Var<List<IVNode>> children)");
        codeBuilder.AppendLine("    {");
        codeBuilder.AppendLine($"        return b.{converter.NodeConstructor}(\"{webComponent.Tag}\", buildProps, children);");
        codeBuilder.AppendLine("    }");

        codeBuilder.AppendLine("    /// <summary>");
        codeBuilder.AppendLine($"    /// {webComponent.Description}");
        codeBuilder.AppendLine("    /// </summary>");
        codeBuilder.AppendLine($"    public static Var<IVNode> {webComponent.Name}(this LayoutBuilder b, Action<PropsBuilder<{webComponent.Name}>> buildProps, params Var<IVNode>[] children)");
        codeBuilder.AppendLine("    {");
        codeBuilder.AppendLine($"        return b.{converter.NodeConstructor}(\"{webComponent.Tag}\", buildProps, children);");
        codeBuilder.AppendLine("    }");

        foreach (var property in webComponent.Properties)
        {
            var propertyCode = GenerateProperty(webComponent, property, property.TypeScriptType, converter);
            if (string.IsNullOrEmpty(propertyCode))
            {
                throw new NotImplementedException();
            }

            codeBuilder.AppendLine(propertyCode);
        }

        var anonEventDetails = webComponent.Events.Where(x => x.Type is TypeScriptAnonymousType);

        foreach (var anonEventDetail in anonEventDetails)
        {
            codeBuilder.AppendLine("    /// <summary>");
            codeBuilder.AppendLine($"    /// {anonEventDetail.Comment}");
            codeBuilder.AppendLine("    /// </summary>");
            codeBuilder.AppendLine($"    public class {anonEventDetail.EventNameFromAnonymous(webComponent)}");
            codeBuilder.AppendLine("    {");
            foreach (var eventProperty in (anonEventDetail.Type as TypeScriptAnonymousType).properties)
            {
                codeBuilder.AppendLine($"        public {eventProperty.type.ToCSharpType(converter)} {eventProperty.name} {{ get; set; }}");
            }
            codeBuilder.AppendLine("    }");
        }

        foreach (var @event in webComponent.Events)
        {
            var eventCode = GenerateEvent(webComponent, @event, converter);
            if (string.IsNullOrEmpty(eventCode))
            {
                throw new NotImplementedException();
            }

            codeBuilder.AppendLine(eventCode);
        }

        codeBuilder.AppendLine("}");
        codeBuilder.AppendLine();

        return codeBuilder.ToString();
    }

    //public static string Capitalize(this WebComponentProperty property)
    //{
    //    return Capitalize(property.Name);
    //}

    //public static string Capitalize(this TypeScriptLiteral typeScriptLiteral)
    //{
    //    return string.Join(null, typeScriptLiteral.StringValue().Split(new char[] { '-', '/' }).Select(x => Capitalize(x)));
    //}

    //public static string Capitalize(this WebComponentSlot slot)
    //{
    //    return string.Join(null, slot.Name.Split("-").Select(x => Capitalize(x)));
    //}

    //public static string Capitalize(this WebComponentEvent @event)
    //{
    //    return string.Join(null, @event.Name.Split("-").Select(x => Capitalize(x)));
    //}

    public static string EventNameFromAnonymous(this WebComponentEvent @event, WebComponent webComponent)
    {
        return $"{webComponent.Name}{Utils.ToCSharpValidName(@event.Name)}Detail";
    }

    public static string StringValue(this TypeScriptLiteral typeScriptLiteral)
    {
        return typeScriptLiteral.Value.Replace("\"", string.Empty);
    }

    public static string ToCSharpType(this ITypeScriptType typeScriptType, CSharpConverter converter)
    {
        return converter.ToCSharpType(typeScriptType, converter);
    }

    public static string GenerateProperty(WebComponent webComponent, WebComponentProperty property, ITypeScriptType propertyType, CSharpConverter converter)
    {
        if (IsStringLiteral(propertyType))
        {
            return GenerateStringLiteralProperty(webComponent, property, propertyType as TypeScriptLiteral);
        }

        if (IsMultiTypeUnion(propertyType))
        {
            return GenerateMultiTypeUnionProperty(webComponent, property, propertyType as TypeScriptUnion, converter);
        }

        // Do not generate code for 'undefined' value
        if (IsUndefinedType(propertyType))
        {
            return string.Empty;
        }

        // Do not generate code for 'null' value
        if (IsNullType(propertyType))
        {
            return string.Empty;
        }

        if (IsBoolType(propertyType))
        {
            return GenerateBoolProperty(webComponent, property);
        }

        if (IsCollectionType(propertyType))
        {
            return GenerateCollectionProperty(webComponent, property, propertyType as TypeScriptCollection, converter);
        }

        if (IsObjectType(propertyType))
        {
            return GenerateValueProperty(webComponent, property, propertyType as TypeScriptObjectType, converter);
        }

        if (IsFuncType(propertyType))
        {
            return GenerateFuncProperty(webComponent, property, propertyType as TypeScriptFunction, converter);
        }

        if (IsDictionary(propertyType))
        {
            return GenerateDictionaryProperty(webComponent, property, propertyType as TypeScriptDictionary, converter);
        }

        if (IsAnonymousType(propertyType))
        {
            return GenerateAnonymousTypeProperty(webComponent, property, propertyType as TypeScriptAnonymousType, converter);
        }

        throw new NotImplementedException();
    }

    public static string GenerateEvent(WebComponent webComponent, WebComponentEvent @event, CSharpConverter converter)
    {
        var csharpType = @event.Type is TypeScriptAnonymousType ? @event.EventNameFromAnonymous(webComponent) : @event.Type.ToCSharpType(converter);

        StringBuilder codeBuilder = new StringBuilder();

        if (csharpType == "void")
        {
            // HyperAction with no payload

            codeBuilder.AppendLine("    /// <summary>");
            codeBuilder.AppendLine($"    /// {@event.Comment}");
            codeBuilder.AppendLine("    /// </summary>");
            codeBuilder.AppendLine($"    public static void On{Utils.ToCSharpValidName(@event.Name)}<TModel>(this PropsBuilder<{webComponent.Name}> b, Var<HyperType.Action<TModel>> action)");
            codeBuilder.AppendLine("    {");
            codeBuilder.AppendLine($"        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel>>(\"on{@event.Name}\"), action);");
            codeBuilder.AppendLine("    }");

            codeBuilder.AppendLine("    /// <summary>");
            codeBuilder.AppendLine($"    /// {@event.Comment}");
            codeBuilder.AppendLine("    /// </summary>");
            codeBuilder.AppendLine($"    public static void On{Utils.ToCSharpValidName(@event.Name)}<TModel>(this PropsBuilder<{webComponent.Name}> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)");
            codeBuilder.AppendLine("    {");
            codeBuilder.AppendLine($"        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel>>(\"on{@event.Name}\"), b.MakeAction(action));");
            codeBuilder.AppendLine("    }");
        }
        else
        {
            codeBuilder.AppendLine("    /// <summary>");
            codeBuilder.AppendLine($"    /// {@event.Comment}");
            codeBuilder.AppendLine("    /// </summary>");
            codeBuilder.AppendLine($"    public static void On{Utils.ToCSharpValidName(@event.Name)}<TModel>(this PropsBuilder<{webComponent.Name}> b, Var<HyperType.Action<TModel, {csharpType}>> action)");
            codeBuilder.AppendLine("    {");
            codeBuilder.AppendLine("        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>");
            codeBuilder.AppendLine("        {");
            codeBuilder.AppendLine($"            var value = b.GetDynamic(eventArgs, new DynamicProperty<{csharpType}>(\"detail\"));");
            codeBuilder.AppendLine($"            return b.MakeActionDescriptor<TModel, {csharpType}>(action, value);");
            codeBuilder.AppendLine("        });");
            codeBuilder.AppendLine($"        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>(\"on{@event.Name}\"), eventAction);");
            codeBuilder.AppendLine("    }");

            codeBuilder.AppendLine("    /// <summary>");
            codeBuilder.AppendLine($"    /// {@event.Comment}");
            codeBuilder.AppendLine("    /// </summary>");
            codeBuilder.AppendLine($"    public static void On{Utils.ToCSharpValidName(@event.Name)}<TModel>(this PropsBuilder<{webComponent.Name}> b, System.Func<SyntaxBuilder, Var<TModel>, Var<{csharpType}>, Var<TModel>> action)");
            codeBuilder.AppendLine("    {");
            codeBuilder.AppendLine("        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>");
            codeBuilder.AppendLine("        {");
            codeBuilder.AppendLine($"            var value = b.GetDynamic(eventArgs, new DynamicProperty<{csharpType}>(\"detail\"));");
            codeBuilder.AppendLine($"            return b.MakeActionDescriptor<TModel, {csharpType}>(b.MakeAction(action), value);");
            codeBuilder.AppendLine("        });");
            codeBuilder.AppendLine($"        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>(\"on{@event.Name}\"), eventAction);");
            codeBuilder.AppendLine("    }");
        }

        return codeBuilder.ToString();
    }

    public static bool IsStringLiteral(ITypeScriptType type)
    {
        TypeScriptLiteral typeScriptLiteral = type as TypeScriptLiteral;
        if (typeScriptLiteral == null)
            return false;

        if (typeScriptLiteral.Type != "string")
            return false;

        return true;
    }

    public static bool IsAnonymousType(ITypeScriptType type)
    {
        TypeScriptAnonymousType typeScriptAnonymousType = type as TypeScriptAnonymousType;
        if (typeScriptAnonymousType == null) return false;
        return true;
    }

    public static bool IsMultiTypeUnion(ITypeScriptType type)
    {
        TypeScriptUnion optionType = type as TypeScriptUnion;
        if (optionType == null)
            return false;
        return true;
    }

    public static bool IsDictionary(ITypeScriptType type)
    {
        TypeScriptDictionary typeScriptDictionary = type as TypeScriptDictionary;
        if (typeScriptDictionary == null) return false;
        return true;
    }

    public static bool IsBoolType(ITypeScriptType type)
    {
        TypeScriptObjectType objectType = type as TypeScriptObjectType;
        if(objectType == null) return false;
        if(objectType.TypeName != "boolean") return false;
        return true;
    }

    public static bool IsCollectionType(ITypeScriptType type)
    {
        TypeScriptCollection collectionType = type as TypeScriptCollection;
        if(collectionType == null) return false;
        return true;
    }

    public static bool IsUndefinedType(ITypeScriptType type)
    {
        TypeScriptObjectType objectType = type as TypeScriptObjectType;
        if (objectType == null) return false;
        if (objectType.TypeName != "undefined") return false;
        return true;
    }

    public static bool IsNullType(ITypeScriptType type)
    {
        TypeScriptObjectType objectType = type as TypeScriptObjectType;
        if (objectType == null) return false;
        if (objectType.TypeName != "null") return false;
        return true;
    }

    public static bool IsObjectType(ITypeScriptType type)
    {
        TypeScriptObjectType objectType = type as TypeScriptObjectType;
        if (objectType == null) return false;
        return true;
    }

    public static bool IsFuncType(ITypeScriptType type)
    {
        TypeScriptFunction funcType = type as TypeScriptFunction;
        if(funcType == null) return false;
        return true;
    }

    public static string GenerateBoolProperty(WebComponent component, WebComponentProperty property)
    {
        StringBuilder codeBuilder = new StringBuilder();

        codeBuilder.AppendLine("    /// <summary>");
        codeBuilder.AppendLine($"    /// {property.Description}");
        codeBuilder.AppendLine("    /// </summary>");
        codeBuilder.AppendLine($"    public static void Set{Utils.ToCSharpValidName(property.Name)}(this PropsBuilder<{component.Name}> b)");
        codeBuilder.AppendLine("    {");
        codeBuilder.AppendLine($"        b.SetDynamic(b.Props, DynamicProperty.Bool(\"{property.Name}\"), b.Const(true));");
        codeBuilder.AppendLine("    }");

        return codeBuilder.ToString();
    }

    public static string GenerateValueProperty(WebComponent component, WebComponentProperty property, TypeScriptObjectType propertyType, CSharpConverter converter)
    {
        if(propertyType.TypeName == "IonicSafeString")
        {
            return string.Empty;
        }

        if (propertyType == null)
            throw new NotSupportedException();

        StringBuilder codeBuilder = new StringBuilder();

        codeBuilder.AppendLine("    /// <summary>");
        codeBuilder.AppendLine($"    /// {property.Description}");
        codeBuilder.AppendLine("    /// </summary>");
        codeBuilder.AppendLine($"    public static void Set{Utils.ToCSharpValidName(property.Name)}(this PropsBuilder<{component.Name}> b, Var<{propertyType.ToCSharpType(converter)}> value)");
        codeBuilder.AppendLine("    {");
        codeBuilder.AppendLine($"        b.SetDynamic(b.Props, new DynamicProperty<{propertyType.ToCSharpType(converter)}>(\"{property.Name}\"), value);");
        codeBuilder.AppendLine("    }");

        codeBuilder.AppendLine("    /// <summary>");
        codeBuilder.AppendLine($"    /// {property.Description}");
        codeBuilder.AppendLine("    /// </summary>");
        codeBuilder.AppendLine($"    public static void Set{Utils.ToCSharpValidName(property.Name)}(this PropsBuilder<{component.Name}> b, {propertyType.ToCSharpType(converter)} value)");
        codeBuilder.AppendLine("    {");
        codeBuilder.AppendLine($"        b.SetDynamic(b.Props, new DynamicProperty<{propertyType.ToCSharpType(converter)}>(\"{property.Name}\"), b.Const(value));");
        codeBuilder.AppendLine("    }");

        return codeBuilder.ToString();
    }

    public static string GenerateDictionaryProperty(WebComponent component, WebComponentProperty property, TypeScriptDictionary propertyType, CSharpConverter converter)
    {
        if (propertyType == null)
            throw new NotSupportedException();

        StringBuilder codeBuilder = new StringBuilder();

        codeBuilder.AppendLine("    /// <summary>");
        codeBuilder.AppendLine($"    /// {property.Description}");
        codeBuilder.AppendLine("    /// </summary>");
        codeBuilder.AppendLine($"    public static void Set{Utils.ToCSharpValidName(property.Name)}(this PropsBuilder<{component.Name}> b, Var<{propertyType.ToCSharpType(converter)}> value)");
        codeBuilder.AppendLine("    {");
        codeBuilder.AppendLine($"        throw new NotImplementedException();");
        codeBuilder.AppendLine("    }");

        return codeBuilder.ToString();
    }

    public static string GenerateAnonymousTypeProperty(WebComponent component, WebComponentProperty property, TypeScriptAnonymousType propertyType, CSharpConverter converter)
    {
        if (propertyType == null)
            throw new NotSupportedException();

        StringBuilder codeBuilder = new StringBuilder();

        var parameters = string.Join(",", propertyType.properties.Select(x => $"Var<{x.type.ToCSharpType(converter)}> {x.name}"));

        codeBuilder.AppendLine("    /// <summary>");
        codeBuilder.AppendLine($"    /// {property.Description}");
        codeBuilder.AppendLine("    /// </summary>");
        codeBuilder.AppendLine($"    public static void Set{Utils.ToCSharpValidName(property.Name)}(this PropsBuilder<{component.Name}> b, {parameters})");
        codeBuilder.AppendLine("    {");
        codeBuilder.AppendLine($"        var _dynamicParameter = b.NewObj<DynamicObject>();");
        foreach (var anonProperty in propertyType.properties)
        {
            codeBuilder.AppendLine($"        b.SetDynamic(_dynamicParameter, new DynamicProperty<{anonProperty.type.ToCSharpType(converter)}>(\"{anonProperty.name}\"), {anonProperty.name});");
        }
        codeBuilder.AppendLine($"        b.SetDynamic(b.Props, new DynamicProperty<DynamicObject>(\"{property.Name}\"), _dynamicParameter);");
        codeBuilder.AppendLine("    }");
        return codeBuilder.ToString();
    }

    public static string GenerateCollectionProperty(WebComponent component, WebComponentProperty property, TypeScriptCollection propertyType, CSharpConverter converter)
    {
        if (propertyType == null)
            throw new NotSupportedException();

        StringBuilder codeBuilder = new StringBuilder();

        // Collection of union types is for us two collections of different types
        if (IsMultiTypeUnion(propertyType.ItemType))
        {
            foreach (var option in (propertyType.ItemType as TypeScriptUnion).Options)
            {
                TypeScriptCollection collectionType = new TypeScriptCollection()
                {
                    ItemType = option
                };
                codeBuilder.Append(GenerateCollectionProperty(component, property, collectionType, converter));
            }

            return codeBuilder.ToString();
        }

        // Else, a collection of object types

        codeBuilder.AppendLine("    /// <summary>");
        codeBuilder.AppendLine($"    /// {property.Description}");
        codeBuilder.AppendLine("    /// </summary>");
        codeBuilder.AppendLine($"    public static void Set{Utils.ToCSharpValidName(property.Name)}(this PropsBuilder<{component.Name}> b, Var<List<{propertyType.ItemType.ToCSharpType(converter)}>> value)");
        codeBuilder.AppendLine("    {");
        codeBuilder.AppendLine($"        b.SetDynamic(b.Props, new DynamicProperty<List<{propertyType.ItemType.ToCSharpType(converter)}>>(\"{property.Name}\"), value);");
        codeBuilder.AppendLine("    }");

        codeBuilder.AppendLine("    /// <summary>");
        codeBuilder.AppendLine($"    /// {property.Description}");
        codeBuilder.AppendLine("    /// </summary>");
        codeBuilder.AppendLine($"    public static void Set{Utils.ToCSharpValidName(property.Name)}(this PropsBuilder<{component.Name}> b, List<{propertyType.ItemType.ToCSharpType(converter)}> value)");
        codeBuilder.AppendLine("    {");
        codeBuilder.AppendLine($"        b.SetDynamic(b.Props, new DynamicProperty<List<{propertyType.ItemType.ToCSharpType(converter)}>>(\"{property.Name}\"), b.Const(value));");
        codeBuilder.AppendLine("    }");

        return codeBuilder.ToString();
    }

    public static string GenerateFuncProperty(WebComponent component, WebComponentProperty property, TypeScriptFunction propertyType, CSharpConverter converter)
    {
        if (propertyType == null)
            throw new NotSupportedException();

        StringBuilder codeBuilder = new StringBuilder();

        var funcParams = propertyType.Parameters.Select(x => x.Type.ToCSharpType(converter)).ToList();
        funcParams.Add(propertyType.ReturnType.ToCSharpType(converter));

        var genericType = $"Func<{string.Join(",", funcParams)}>";

        var clientSideFunc = $"Var<Func<{string.Join(",", funcParams)}>>";

        var serverSideFunc = $"Func<SyntaxBuilder,{string.Join(",", funcParams.Select(x => $"Var<{x}>"))}>";

        codeBuilder.AppendLine("    /// <summary>");
        codeBuilder.AppendLine($"    /// {property.Description}");
        codeBuilder.AppendLine("    /// </summary>");
        codeBuilder.AppendLine($"    public static void Set{Utils.ToCSharpValidName(property.Name)}(this PropsBuilder<{component.Name}> b, {clientSideFunc} f)");
        codeBuilder.AppendLine("    {");
        codeBuilder.AppendLine($"        b.SetDynamic(b.Props, new DynamicProperty<{genericType}>(\"{property.Name}\"), f);");
        codeBuilder.AppendLine("    }");

        codeBuilder.AppendLine("    /// <summary>");
        codeBuilder.AppendLine($"    /// {property.Description}");
        codeBuilder.AppendLine("    /// </summary>");
        codeBuilder.AppendLine($"    public static void Set{Utils.ToCSharpValidName(property.Name)}(this PropsBuilder<{component.Name}> b, {serverSideFunc} f)");
        codeBuilder.AppendLine("    {");
        codeBuilder.AppendLine($"        b.SetDynamic(b.Props, new DynamicProperty<{genericType}>(\"{property.Name}\"), b.Def(f));");
        codeBuilder.AppendLine("    }");

        return codeBuilder.ToString();
    }

    public static string GenerateStringLiteralProperty(WebComponent component, WebComponentProperty property, TypeScriptLiteral typeScriptLiteral)
    {
        StringBuilder codeBuilder = new StringBuilder();

        codeBuilder.AppendLine("    /// <summary>");
        codeBuilder.AppendLine($"    /// {property.Description}");
        codeBuilder.AppendLine("    /// </summary>");
        codeBuilder.AppendLine($"    public static void Set{Utils.ToCSharpValidName(property.Name)}{Utils.ToCSharpValidName(typeScriptLiteral.Value)}(this PropsBuilder<{component.Name}> b)");
        codeBuilder.AppendLine("    {");
        codeBuilder.AppendLine($"        b.SetDynamic(b.Props, DynamicProperty.String(\"{property.Name}\"), b.Const(\"{typeScriptLiteral.StringValue()}\"));");
        codeBuilder.AppendLine("    }");

        return codeBuilder.ToString();
    }

    public static string GenerateMultiTypeUnionProperty(WebComponent component, WebComponentProperty property, TypeScriptUnion optionType, CSharpConverter converter)
    {
        StringBuilder codeBuilder = new StringBuilder();

        foreach (var option in optionType.Options)
        {
            codeBuilder.Append(GenerateProperty(component, property, option, converter));
        }

        return codeBuilder.ToString();
    }
}
