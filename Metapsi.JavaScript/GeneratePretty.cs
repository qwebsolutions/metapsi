using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Metapsi.Syntax;

namespace Metapsi.JavaScript
{
    public enum ImportType
    {
        Destructured,
        ModuleAs
    }

    public class JsBuilderOptions
    {
        public int Indent { get; set; } = 4;
        public string Version { get; set; } = string.Empty;
        public ImportType ImportType { get; set; }
        internal Module Module { get; set; }
    }

    internal static class ModuleExtensions
    {
        internal static string ModuleNameFromPath(string path)
        {
            return path.Replace(".", string.Empty);
        }
    }

    public static class PrettyBuilder
    {
        //public const int IndentSize = 4;

        public static string Generate(Module module, JsBuilderOptions options = null)
        {
            if (options == null)
                options = new JsBuilderOptions();

            options.Module = module;

            var stopwatch = System.Diagnostics.Stopwatch.StartNew();
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("// import");

            // module, symbols
            Dictionary<string, HashSet<string>> moduleImports = new();

            foreach (var imp in module.Imports)
            {
                if (!moduleImports.ContainsKey(imp.Module))
                    moduleImports[imp.Module] = new HashSet<string>();
                moduleImports[imp.Module].Add(imp.Symbol);
            }

            EmbeddedFiles.Add(typeof(Metapsi.JavaScript.PrettyBuilder).Assembly, "metapsi.core.js");
            EmbeddedFiles.Add(typeof(LinqConverter).Assembly, "uuid.js");

            foreach (var externalModule in moduleImports)
            {
                if (externalModule.Key == "linq")
                {
                    EmbeddedFiles.Add(typeof(LinqConverter).Assembly, "linq.js");
                    builder.AppendLine($"import Enumerable from \"/{externalModule.Key}.js{Version.WithTag(options.Version)}\";");
                }
                else
                {
                    if (options.ImportType == ImportType.Destructured)
                    {
                        var symbolsList = string.Join(", ", externalModule.Value);
                        var extensionPlaceholder =
                            externalModule.Key.EndsWith(".js") || externalModule.Key.EndsWith(".mjs") ?
                            string.Empty : ".js";
                        var relativePlaceholder = externalModule.Key.StartsWith("http") ? "" : "/";
                        builder.AppendLine($"import {{ {symbolsList} }} from \"{relativePlaceholder}{externalModule.Key}{extensionPlaceholder}{Version.WithTag(options.Version)}\";");
                    }
                    else
                    {
                        builder.AppendLine($"import * as {ModuleExtensions.ModuleNameFromPath(externalModule.Key)} from \"/{externalModule.Key}.js{Version.WithTag(options.Version)}\";");
                    }
                }
            }

            builder.AppendLine("// constants");
            foreach (var c in module.Consts.Where(x => IsClientSideConstant(x)))
            {
                if (c.Name == "init")
                {
                    builder.AppendLine($"export var {c.Name} = {SerializeConst(c)}");
                }
                else
                {
                    if (c.Value is Import)
                    {
                        // do not serialize, imports are already available
                    }
                    else if (c.Value is System.Linq.Expressions.Expression)
                    {
                        builder.AppendLine($"var {c.Name} = {LinqConverter.ToJavaScript(c.Value as System.Linq.Expressions.Expression)}");
                    }
                    else
                    {
                        builder.AppendLine($"var {c.Name} = {SerializeConst(c)}");
                    }
                }
            }

            builder.AppendLine("// function definitions");
            foreach (var f in module.Functions)
            {
                builder.AppendLine(Generate(f, 0, true, options));
            }
            var time = stopwatch.ElapsedMilliseconds;
            return builder.ToString();
        }

        private static bool IsClientSideConstant(Constant c)
        {
            if (c.Value is Delegate)
                return false;

            //if (c.Value is IServerSideTag)
            //    return false;

            if (c.Value is Import)
                return false;

            return true;
        }

        public static string Generate(Block block, int nestingLevel, JsBuilderOptions options)
        {
            StringBuilder builder = new StringBuilder();
            foreach (ISyntaxElement syntaxElement in block.Lines)
            {
                switch (syntaxElement)
                {
                    case IObjectConstructor objectConstructor:
                        builder.AppendLine(Generate(objectConstructor, nestingLevel, options));
                        break;
                    case ICollectionConstructor collectionConstructor:
                        builder.AppendLine(Generate(collectionConstructor, nestingLevel, options));
                        break;
                    case IPropertyAssignment propertyAssignment:
                        builder.AppendLine(Generate(propertyAssignment, nestingLevel, options));
                        break;
                    case IPropertyAccess propertyAccess:
                        builder.AppendLine(Generate(propertyAccess, nestingLevel, options));
                        break;
                    case IForeachBlock foreachBlock:
                        builder.AppendLine(Generate(foreachBlock, nestingLevel, options));
                        break;
                    case IfBlock ifBlock:
                        builder.AppendLine(Generate(ifBlock, nestingLevel, options));
                        break;
                    case LineComment comment:
                        builder.AppendLine(Generate(comment, nestingLevel, options));
                        break;
                    case IFunction lambda:
                        builder.AppendLine(Generate(lambda, nestingLevel, false, options));
                        break;
                    case Metapsi.Syntax.FunctionCall functionCall:
                        builder.AppendLine(Generate(functionCall, nestingLevel, options));
                        break;

                    default:
                        throw new NotImplementedException();
                }
            }

            return builder.ToString();
        }

        public static string Generate(Metapsi.Syntax.FunctionCall functionCall, int nestingLevel, JsBuilderOptions options)
        {
            var functionName = functionCall.Function.Name;

            if (options.ImportType == ImportType.ModuleAs)
            {
                var import = options.Module.Imports.FirstOrDefault(x => x.Symbol == functionName);
                if (import != null)
                {
                    functionName = $"{ModuleExtensions.ModuleNameFromPath(import.Module)}.{functionName}";
                }
            }

            string argumentsList = string.Join(",", functionCall.Arguments.Select(x => x.Name));
            if (functionCall.IntoVariable != null)
            {
                return $"{Indent(nestingLevel, options)}let {functionCall.IntoVariable.Name} = {functionName}({argumentsList})";
            }
            else
            {
                return $"{Indent(nestingLevel, options)}{functionName}({argumentsList})";
            }
        }

        public static string Generate(IObjectConstructor constructor, int nestingLevel, JsBuilderOptions options)
        {
            return $"{Indent(nestingLevel, options)}let {constructor.IntoVar.Name} = {Serialize(constructor.From)}";
        }

        public static string Generate(ICollectionConstructor constructor, int nestingLevel, JsBuilderOptions options)
        {
            return $"{Indent(nestingLevel, options)}let {constructor.IntoVar.Name} = []";
        }

        public static string Generate(IPropertyAssignment propertyAssignment, int nestingLevel, JsBuilderOptions options)
        {
            return $"{Indent(nestingLevel, options)}{propertyAssignment.ObjectVar.Name}['{propertyAssignment.Property.PropertyName}'] = {propertyAssignment.FromVar.Name}";
        }

        public static bool IsValidPropertyName(string propertyName)
        {
            return propertyName.All(x =>
            {
                if (x == '_')
                    return true;
                return char.IsLetterOrDigit(x);
            });
        }

        public static string Generate(IPropertyAccess propertyAccess, int nestingLevel, JsBuilderOptions options)
        {
            return $"{Indent(nestingLevel, options)}let {propertyAccess.IntoVar.Name} = {propertyAccess.FromVar.Name}['{propertyAccess.Property.PropertyName}']";
        }

        public static string Generate(IForeachBlock foreachBlock, int nestingLevel, JsBuilderOptions options)
        {
            string blockCode = $"{Indent(nestingLevel, options)}{foreachBlock.CollectionVarName}.forEach(({foreachBlock.OverVarName}, index) => {{\n";
            blockCode += Generate(foreachBlock.ChildBlock, nestingLevel + 1, options);
            blockCode += $"{Indent(nestingLevel, options)}}})";

            return blockCode;
        }

        public static string Generate(IfBlock ifBlock, int nestingLevel, JsBuilderOptions options)
        {
            string blockCode = $"{Indent(nestingLevel, options)}if({ifBlock.Var.Name}){{\n";
            blockCode += Generate(ifBlock.TrueBlock, nestingLevel + 1, options);
            blockCode += $"{Indent(nestingLevel, options)}}}";
            if (ifBlock.FalseBlock != null)
            {
                blockCode += $" else {{\n";
                blockCode += Generate(ifBlock.FalseBlock, nestingLevel + 1, options);
                blockCode += $"{Indent(nestingLevel, options)}}}";
            }

            return blockCode;
        }

        public static string Generate(LineComment lineComment, int nestingLevel, JsBuilderOptions options)
        {
            var callerPlaceholder = string.Empty;
            if (!string.IsNullOrWhiteSpace(lineComment.FileName))
                callerPlaceholder += lineComment.FileName;
            if (lineComment.LineNumber > 0)
            {
                callerPlaceholder += " " + lineComment.LineNumber;
            }

            if (!string.IsNullOrEmpty(callerPlaceholder))
            {
                callerPlaceholder = ", " + callerPlaceholder;
            }
            return $"{Indent(nestingLevel, options)}// {lineComment.Comment}{callerPlaceholder}";
        }

        public static string Generate(IFunction function, int nestingLevel, bool export, JsBuilderOptions options)
        {
            string exportPlaceholder = export ? "export " : "";

            string asyncPlaceholder = "";

            var parametersList = string.Join(",", function.Parameters.Select(x => x.Name));
            string body = $"{Indent(nestingLevel, options)}{exportPlaceholder}var {function.Name} = {asyncPlaceholder}({parametersList}) => {{\n";
            body += $"{Generate(function.ChildBlock, nestingLevel + 1, options)}";

            if (function.ReturnVariable != null)
            {
                if (ModuleBuilder.ScalarTypes.Contains(function.ReturnVariable.Type))
                {
                    body += $"{Indent(nestingLevel + 1, options)}return {function.ReturnVariable.Name}\n";
                }
                else if (function.ReturnVariable.Type.IsAssignableTo(typeof(System.Collections.IEnumerable)))
                {
                    body += $"{Indent(nestingLevel + 1, options)}return Array.from({function.ReturnVariable.Name})\n";
                }
                else
                {
                    body += $"{Indent(nestingLevel + 1, options)}return {function.ReturnVariable.Name}\n";
                }
            }

            body += $"{Indent(nestingLevel + 1, options)}}}";
            return body;
        }

        public static string Indent(int level, JsBuilderOptions options)
        {
            return new string(' ', level * options.Indent);
        }

        public static string SerializeConst(IConstant constant)
        {
            return JsonSerializer.Serialize(constant.Value, constSerializerOptions);
        }

        public static string Serialize(object obj)
        {
            return JsonSerializer.Serialize(obj, varSerializerOptions);
        }

        private static JsonSerializerOptions constSerializerOptions = GetConstSerializerOptions();

        private static JsonSerializerOptions GetConstSerializerOptions()
        {
            var options = new JsonSerializerOptions()
            {
                WriteIndented = true,
                IgnoreReadOnlyFields = true,
                IgnoreReadOnlyProperties = true,
                //DefaultIgnoreCondition= System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault
            };
            options.Converters.Add(new ConstFunctionNameSerializer());
            options.Converters.Add(new JsDynamicObjectConverter());
            return options;
        }

        private static JsonSerializerOptions varSerializerOptions = GetVarSerializerOptions();

        private static JsonSerializerOptions GetVarSerializerOptions()
        {
            var options = new JsonSerializerOptions()
            {
                WriteIndented = true,
                IgnoreReadOnlyFields = true,
                IgnoreReadOnlyProperties = true,
            };
            options.Converters.Add(new VarFunctionNameSerializer());
            options.Converters.Add(new JsDynamicObjectConverter());
            return options;
        }
    }

    public class JsDynamicObjectConverter : System.Text.Json.Serialization.JsonConverter<DynamicObject>
    {
        public override DynamicObject Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }

        public override void Write(System.Text.Json.Utf8JsonWriter writer, DynamicObject value, System.Text.Json.JsonSerializerOptions options)
        {
            writer.WriteStartObject();
            foreach (var dynValue in value.Values)
            {
                writer.WriteRawValue($"\"{dynValue.Key}\"");
                var s = System.Text.Json.JsonSerializer.Serialize(dynValue.Value.Value, options: options);
                writer.WriteRawValue(s);
            }
            writer.WriteEndObject();
        }
    }

    public static class Version
    {
        public static string WithTag(string version)
        {
            if (string.IsNullOrEmpty(version))
                return string.Empty;

            return $"?v={version}";
        }
    }
}

