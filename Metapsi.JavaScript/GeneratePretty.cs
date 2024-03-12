using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Metapsi.Hyperapp;
using Metapsi.Syntax;

namespace Metapsi.JavaScript
{
    public static class PrettyBuilder
    {
        public const int IndentSize = 4;

        public static string Generate(Module module, string version)
        {
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

            foreach (var externalModule in moduleImports)
            {
                if (externalModule.Key == "linq")
                {
                    builder.AppendLine($"import Enumerable from \"/{externalModule.Key}.js{Version.WithTag(version)}\";");
                }
                else
                {
                    var symbolsList = string.Join(", ", externalModule.Value);
                    builder.AppendLine($"import {{ {symbolsList} }} from \"/{externalModule.Key}.js{Version.WithTag(version)}\";");
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
                        builder.AppendLine($"var {c.Name} = {Metapsi.Hyperapp.JsLinq.Convert(c.Value as System.Linq.Expressions.Expression)}");
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
                builder.AppendLine(Generate(f, 0, true));
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

        public static string Generate(Block block, int indent)
        {
            StringBuilder builder = new StringBuilder();
            foreach (ISyntaxElement syntaxElement in block.Lines)
            {
                switch (syntaxElement)
                {
                    case IObjectConstructor objectConstructor:
                        builder.AppendLine(Generate(objectConstructor, indent));
                        break;
                    case ICollectionConstructor collectionConstructor:
                        builder.AppendLine(Generate(collectionConstructor, indent));
                        break;
                    case IPropertyAssignment propertyAssignment:
                        builder.AppendLine(Generate(propertyAssignment, indent));
                        break;
                    case IPropertyAccess propertyAccess:
                        builder.AppendLine(Generate(propertyAccess, indent));
                        break;
                    case IForeachBlock foreachBlock:
                        builder.AppendLine(Generate(foreachBlock, indent));
                        break;
                    case IfBlock ifBlock:
                        builder.AppendLine(Generate(ifBlock, indent));
                        break;
                    case LineComment comment:
                        builder.AppendLine(Generate(comment, indent));
                        break;
                    case IFunction lambda:
                        builder.AppendLine(Generate(lambda, indent));
                        break;
                    case Metapsi.Syntax.FunctionCall functionCall:
                        builder.AppendLine(Generate(functionCall, indent));
                        break;

                    default:
                        throw new NotImplementedException();
                }
            }

            return builder.ToString();
        }

        public static string Generate(Metapsi.Syntax.FunctionCall functionCall, int indent)
        {
            string argumentsList = string.Join(",", functionCall.Arguments.Select(x => x.Name));
            if (functionCall.IntoVariable != null)
            {
                return $"{Indent(indent)}let {functionCall.IntoVariable.Name} = {functionCall.Function.Name}({argumentsList})";
            }
            else
            {
                return $"{Indent(indent)}{functionCall.Function.Name}({argumentsList})";
            }
        }

        public static string Generate(IObjectConstructor constructor, int indent)
        {
            return $"{Indent(indent)}let {constructor.IntoVar.Name} = {Serialize(constructor.From)}";
        }

        public static string Generate(ICollectionConstructor constructor, int indent)
        {
            return $"{Indent(indent)}let {constructor.IntoVar.Name} = []";
        }

        public static string Generate(IPropertyAssignment propertyAssignment, int indent)
        {
            return $"{Indent(indent)}{propertyAssignment.ObjectVar.Name}['{propertyAssignment.Property.PropertyName}'] = {propertyAssignment.FromVar.Name}";
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

        public static string Generate(IPropertyAccess propertyAccess, int indent)
        {
            return $"{Indent(indent)}let {propertyAccess.IntoVar.Name} = {propertyAccess.FromVar.Name}['{propertyAccess.Property.PropertyName}']";
        }

        public static string Generate(IForeachBlock foreachBlock, int indent)
        {
            string blockCode = $"{Indent(indent)}{foreachBlock.CollectionVarName}.forEach(({foreachBlock.OverVarName}, index) => {{\n";
            blockCode += Generate(foreachBlock.ChildBlock, indent + 1);
            blockCode += $"{Indent(indent)}}})";

            return blockCode;
        }

        public static string Generate(IfBlock ifBlock, int indent)
        {
            string blockCode = $"{Indent(indent)}if({ifBlock.Var.Name}){{\n";
            blockCode += Generate(ifBlock.TrueBlock, indent + 1);
            blockCode += $"{Indent(indent)}}}";
            if (ifBlock.FalseBlock != null)
            {
                blockCode += $" else {{\n";
                blockCode += Generate(ifBlock.FalseBlock, indent + 1);
                blockCode += $"{Indent(indent)}}}";
            }

            return blockCode;
        }

        public static string Generate(LineComment lineComment, int indent)
        {
            return $"{Indent(indent)}// {lineComment.Comment}";
        }

        public static string Generate(IFunction function, int indent, bool export = false)
        {
            string exportPlaceholder = export ? "export " : "";

            string asyncPlaceholder = "";

            var parametersList = string.Join(",", function.Parameters.Select(x => x.Name));
            string body = $"{Indent(indent)}{exportPlaceholder}var {function.Name} = {asyncPlaceholder}({parametersList}) => {{\n";
            body += $"{Generate(function.ChildBlock, indent + 1)}";

            if (function.ReturnVariable != null)
            {
                if (ModuleBuilder.ScalarTypes.Contains(function.ReturnVariable.Type))
                {
                    body += $"{Indent(indent + 1)}return {function.ReturnVariable.Name}\n";
                }
                else if (function.ReturnVariable.Type.IsAssignableTo(typeof(System.Collections.IEnumerable)))
                {
                    body += $"{Indent(indent + 1)}return Array.from({function.ReturnVariable.Name})\n";
                }
                else
                {
                    body += $"{Indent(indent + 1)}return {function.ReturnVariable.Name}\n";
                }
            }

            body += $"{Indent(indent + 1)}}}";
            return body;
        }

        public static string Indent(int level)
        {
            return new string(' ', level * IndentSize);
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
                DefaultIgnoreCondition= System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault
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

