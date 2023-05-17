using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Metapsi.Hyperapp;
using Metapsi.Syntax;

namespace Metapsi.JavaScript
{
    public static partial class UglyBuilder
    {
        public static string Generate(Module module, string version)
        {
            var stopwatch = System.Diagnostics.Stopwatch.StartNew();
            StringBuilder builder = new StringBuilder();
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
                    builder.Append($"import Enumerable from \"/{externalModule.Key}.js{PageDetailsExtensions.WithVersion(version)}\";");
                }
                else
                {
                    var symbolsList = string.Join(",", externalModule.Value);
                    builder.Append($"import {{{symbolsList}}} from \"/{externalModule.Key}.js{PageDetailsExtensions.WithVersion(version)}\";");
                }
            }

            foreach (var c in module.Consts.Where(x => IsClientSideConstant(x)))
            {
                if (c.Name == "init")
                {
                    builder.Append($"export var {c.Name}={SerializeConst(c)};");
                }
                else
                {
                    if (c.Value is Import)
                    {
                        // do not serialize, imports are already available
                    }
                    else if (c.Value is System.Linq.Expressions.Expression)
                    {
                        builder.Append($"var {c.Name}={Metapsi.Hyperapp.JsLinq.Convert(c.Value as System.Linq.Expressions.Expression)};");
                    }
                    else
                    {
                        builder.Append($"var {c.Name}={SerializeConst(c)};");
                    }
                }
            }

            foreach (var f in module.Functions)
            {
                builder.Append(Generate(f, true));
            }
            var time = stopwatch.ElapsedMilliseconds;
            return builder.ToString();
        }

        private static bool IsClientSideConstant(Constant c)
        {
            if (c.Value is Delegate)
                return false;

            if (c.Value is IServerSideTag)
                return false;

            if (c.Value is Import)
                return false;

            return true;
        }

        public static string Generate(Block block)
        {
            StringBuilder builder = new StringBuilder();
            foreach (ISyntaxElement syntaxElement in block.Lines)
            {
                switch (syntaxElement)
                {
                    case IObjectConstructor objectConstructor: builder.Append(Generate(objectConstructor));
                        break;
                    case ICollectionConstructor collectionConstructor: builder.Append(Generate(collectionConstructor));
                        break;
                    case IPropertyAssignment propertyAssignment: builder.Append(Generate(propertyAssignment));
                        break;
                    case IPropertyAccess propertyAccess: builder.Append(Generate(propertyAccess));
                        break;
                    case IForeachBlock foreachBlock: builder.Append(Generate(foreachBlock));
                        break;
                    case IfBlock ifBlock: builder.Append(Generate(ifBlock));
                        break;

                    // Keep AppendLine for comments, otherwise they're hard to find & makes no sense
                    case LineComment comment: //builder.Append(Generate(comment));
                        break;
                    case IFunction lambda: builder.Append(Generate(lambda));
                        break;
                    case Metapsi.Syntax.FunctionCall functionCall: builder.Append(Generate(functionCall));
                        break;

                    default:
                        throw new NotImplementedException();
                }
            }

            return builder.ToString();
        }

        public static string Generate(Metapsi.Syntax.FunctionCall functionCall)
        {
            string argumentsList = string.Join(",", functionCall.Arguments.Select(x => x.Name));
            if (functionCall.IntoVariable != null)
            {
                return $"let {functionCall.IntoVariable.Name}={functionCall.Function.Name}({argumentsList});";
            }
            else
            {
                return $"{functionCall.Function.Name}({argumentsList});";
            }
        }

        public static string Generate(IObjectConstructor constructor)
        {
            return $"let {constructor.IntoVar.Name}={Serialize(constructor.From)};";
        }

        public static string Generate(ICollectionConstructor constructor)
        {
            return $"let {constructor.IntoVar.Name}=[];";
        }

        public static string Generate(IPropertyAssignment propertyAssignment)
        {
            return $"{propertyAssignment.ObjectVar.Name}['{propertyAssignment.Property.PropertyName}']={propertyAssignment.FromVar.Name};";
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

        public static string Generate(IPropertyAccess propertyAccess)
        {
            return $"let {propertyAccess.IntoVar.Name}={propertyAccess.FromVar.Name}['{propertyAccess.Property.PropertyName}'];";
        }

        public static string Generate(IForeachBlock foreachBlock)
        {
            string blockCode = $"{foreachBlock.CollectionVarName}.forEach(({foreachBlock.OverVarName},i)=>{{";
            blockCode += Generate(foreachBlock.ChildBlock);
            blockCode += $"}});";

            return blockCode;
        }

        public static string Generate(IfBlock ifBlock)
        {
            string blockCode = $"if({ifBlock.Var.Name}){{";
            blockCode += Generate(ifBlock.TrueBlock);
            blockCode += $"}}";
            if (ifBlock.FalseBlock != null)
            {
                blockCode += $"else{{";
                blockCode += Generate(ifBlock.FalseBlock);
                blockCode += $"}};";
            }
            else
            {
                blockCode += ";";
            }

            return blockCode;
        }

        public static string Generate(LineComment lineComment)
        {
            return $"/*{lineComment.Comment}*/";
        }

        public static string Generate(IFunction function, bool export = false)
        {
            string exportPlaceholder = export ? "export " : "";

            string asyncPlaceholder = "";

            var parametersList = string.Join(",", function.Parameters.Select(x => x.Name));
            string body = $"{exportPlaceholder}var {function.Name} = {asyncPlaceholder}({parametersList}) => {{";
            body += $"{Generate(function.ChildBlock)}";

            if (function.ReturnVariable != null)
            {
                if (ModuleBuilder.ScalarTypes.Contains(function.ReturnVariable.Type))
                {
                    body += $"return {function.ReturnVariable.Name};";
                }
                else if (function.ReturnVariable.Type.IsAssignableTo(typeof(System.Collections.IEnumerable)))
                {
                    body += $"return Array.from({function.ReturnVariable.Name});";
                }
                else
                {
                    body += $"return {function.ReturnVariable.Name};";
                }
            }

            body += $"}};";
            return body;
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
                WriteIndented = false,
                IgnoreReadOnlyFields = true,
                IgnoreReadOnlyProperties = true,
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
                WriteIndented = false,
                IgnoreReadOnlyFields = true,
                IgnoreReadOnlyProperties = true,
            };
            options.Converters.Add(new VarFunctionNameSerializer());
            options.Converters.Add(new JsDynamicObjectConverter());
            return options;
        }
    }

    //public class JsDynamicObjectConverter : System.Text.Json.Serialization.JsonConverter<DynamicObject>
    //{
    //    public override DynamicObject Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    //    {
    //        throw new NotSupportedException();
    //    }

    //    public override void Write(System.Text.Json.Utf8JsonWriter writer, DynamicObject value, System.Text.Json.JsonSerializerOptions options)
    //    {
    //        writer.WriteStartObject();
    //        foreach (var dynValue in value.Values)
    //        {
    //            writer.WriteRawValue($"\"{dynValue.Key}\"");
    //            var s = System.Text.Json.JsonSerializer.Serialize(dynValue.Value.Value, options: options);
    //            writer.WriteRawValue(s);
    //        }
    //        writer.WriteEndObject();
    //    }
    //}
}

