using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Metapsi.Syntax;

namespace Metapsi.CSharp
{
    public static class CSharpBuilder
    {
        public const int IndentSize = 4;

        public static string Generate(this Module module)
        {
            var stopwatch = System.Diagnostics.Stopwatch.StartNew();
            StringBuilder builder = new StringBuilder();
            //builder.AppendLine("// import");

            // module, symbols
            Dictionary<string, HashSet<string>> moduleImports = new();

            foreach (var import in module.Constants.Where(x=>x.Value is Import))
            {
                Import imp = import.Value as Import;
                if (!moduleImports.ContainsKey(imp.Module))
                    moduleImports[imp.Module] = new HashSet<string>();
                moduleImports[imp.Module].Add(imp.Symbol);
            }

            //builder.AppendLine($"using System.Text.Json;");
            builder.AppendLine("using System.Linq;");
            builder.AppendLine("using static Metapsi.Syntax.HyperappFunctions;");
            builder.AppendLine("using static MdsInfrastructure.connect;");

            foreach (var externalModule in moduleImports)
            {
                //if (externalModule.Key == "linq")
                //{
                //    builder.AppendLine($"using System.Linq;");
                //}
                //else
                //{
                //    builder.AppendLine($"using {externalModule.Key};");
                //}
            }

            builder.AppendLine($"public class DynModule");
            builder.AppendLine("{");

            //builder.AppendLine("System.Collections.Generic.Dictionary<string, System.Delegate> funcs = new System.Collections.Generic.Dictionary<string, System.Delegate>();");

            //builder.AppendLine("T CallFunc<T>(string functionName, params object[] arguments){ return (T)funcs[functionName].Method.Invoke(null, arguments); }");
            //builder.AppendLine("void CallAction(string functionName, params object[] arguments){ funcs[functionName].Method.Invoke(null, arguments); }");

            builder.AppendLine("// constants");
            foreach (var c in module.Constants.Where(x => !(x.Value is IFunction)))
            {
                if (c.Name == "init")
                {
                    builder.AppendLine($"    {c.Value.GetType().Name} {c.Name} = {CreateReference(c.Type, c.Value)};");
                }
                else
                {
                    if (c.Value is Import)
                    {
                        // do not serialize, imports are already available
                    }
                    else if (c.Value is System.Linq.Expressions.Expression)
                    {
                        System.Linq.Expressions.LambdaExpression lambda = c.Value as System.Linq.Expressions.LambdaExpression;

                        var parametersList = string.Join(",", lambda.Parameters.Select(x => $"{QualifiedTypeName(x.Type)} {WrapReservedKeyword(x.Name)}"));

                        var funcTypes = new List<Type>();
                        funcTypes.AddRange(lambda.Parameters.Select(x => x.Type));
                        funcTypes.Add(lambda.ReturnType);

                        var funcTypesList = string.Join(", ", funcTypes.Select(x => QualifiedTypeName(x)));

                        //builder.Append($"var {c.Name}" =  into dictionary, the result of the compiled expression?)
                        builder.AppendLine($"    System.Func<{funcTypesList}> {c.Name} => {Metapsi.CsLinq.Convert(c.Value as System.Linq.Expressions.Expression)};");
                    }
                    else
                    {
                        builder.AppendLine($"    {QualifiedTypeName(c.Value.GetType())} {c.Name} = {CreateReference(c.Type, c.Value)};");
                    }
                }
            }

            builder.AppendLine("// function definitions");
            foreach (var c in module.Constants.Where(x => x.Value is IFunction))
            {
                IFunction f = c.Value as IFunction;
                builder.AppendLine(f.Generate(1, true));
            }
            builder.AppendLine("}");
            var time = stopwatch.ElapsedMilliseconds;
            return builder.ToString();
        }

        public static string CreateReference(Type t, object o)
        {

            if (o == null)
            {
                if (t == typeof(string))
                    o = string.Empty;
                else if (t == typeof(bool))
                    o = false;
                else if (t.IsAssignableTo(typeof(System.Collections.IList)))
                {
                    o = new List<object>();
                }
                else
                {
                    o = new object();
                }
            }

            var objectString = Metapsi.Serialize.ToJson(o);
            var quoted = Metapsi.Serialize.ToJson(objectString);
            return $"Deserialize<{QualifiedTypeName(t)}>({quoted})";
        }

        public static string Generate(this Block block, int indent)
        {
            StringBuilder builder = new StringBuilder();
            foreach (ISyntaxElement syntaxElement in block.Lines)
            {
                switch (syntaxElement)
                {
                    case IObjectConstructor objectConstructor: builder.AppendLine(objectConstructor.Generate(indent));
                        break;
                    case ICollectionConstructor collectionConstructor: builder.AppendLine(collectionConstructor.Generate(indent));
                        break;
                    case IPropertyAssignment propertyAssignment: builder.AppendLine(propertyAssignment.Generate(indent));
                        break;
                    case IPropertyAccess propertyAccess: builder.AppendLine(propertyAccess.Generate(indent));
                        break;
                    case IForeachBlock foreachBlock: builder.AppendLine(foreachBlock.Generate(indent));
                        break;
                    case IfBlock ifBlock: builder.AppendLine(ifBlock.Generate(indent));
                        break;
                    case LineComment comment: builder.AppendLine(comment.Generate(indent));
                        break;
                    case IFunction lambda: builder.AppendLine(lambda.Generate(indent));
                        break;
                    case Metapsi.Syntax.FunctionCall functionCall: builder.AppendLine(functionCall.Generate(indent));
                        break;

                    default:
                        throw new NotImplementedException();
                }
            }

            return builder.ToString();
        }

        public static string Generate(this Metapsi.Syntax.FunctionCall functionCall, int indent)
        {
            string argumentsList = string.Join(",", functionCall.Arguments.Select(x => WrapReservedKeyword(x.Name)));

            if (functionCall.Function.Name == "Deserialize")
            {

                return $"{Indent(indent)}{QualifiedTypeName(functionCall.IntoVariable.Type)} {functionCall.IntoVariable.Name} = Deserialize<{QualifiedTypeName(functionCall.IntoVariable.Type)}>({argumentsList});";
            }

            if (functionCall.IntoVariable != null)
            {
                return $"{Indent(indent)}{QualifiedTypeName(functionCall.IntoVariable.Type)} {functionCall.IntoVariable.Name} = ({QualifiedTypeName(functionCall.IntoVariable.Type)}) {functionCall.Function.Name}({argumentsList});";
                //return $"{Indent(indent)}var {functionCall.IntoVariable.Name} = CallFunc<{QualifiedTypeName(functionCall.IntoVariable.Type)}>(\"{functionCall.Function.Name}\", {argumentsList});";
            }
            else
            {
                return $"{Indent(indent)}{functionCall.Function.Name}({argumentsList});";
                //return $"{Indent(indent)}CallAction(\"{functionCall.Function.Name}\",{argumentsList});";
            }
        }

        public static string Generate(this IObjectConstructor constructor, int indent)
        {
            if (constructor.Type.IsAssignableTo(typeof(Delegate)))
            {
                return $"{Indent(indent)}{QualifiedTypeName(constructor.Type)} {constructor.IntoVar.Name} = null;";
            }
            else
            {
                return $"{Indent(indent)}var {constructor.IntoVar.Name} = {CreateReference(constructor.Type, constructor.From)};";
            }
        }

        public static string Generate(this ICollectionConstructor constructor, int indent)
        {
            return $"{Indent(indent)}var {constructor.IntoVar.Name} = new System.Collections.Generic.List<{QualifiedTypeName(constructor.ItemType)}>();";
        }

        public static string Generate(this IPropertyAssignment propertyAssignment, int indent)
        {
            if (propertyAssignment.ObjectVar.Type != propertyAssignment.Property.InterfaceType)
            {
                return $"{Indent(indent)}(({QualifiedTypeName(propertyAssignment.Property.InterfaceType)}){propertyAssignment.ObjectVar.Name}).{WrapReservedKeyword(propertyAssignment.Property.PropertyName)} = {propertyAssignment.FromVar.Name};";
            }
            else
            {
                return $"{Indent(indent)}{propertyAssignment.ObjectVar.Name}.{WrapReservedKeyword(propertyAssignment.Property.PropertyName)} = {propertyAssignment.FromVar.Name};";
            }
        }

        private static HashSet<string> reservedKeywords { get; set; } 

        public static HashSet<string> ReservedKeywords
        {
            get
            {
                if (reservedKeywords == null)
                {
                    reservedKeywords = new HashSet<string>();
                    reservedKeywords.Add("class");
                    reservedKeywords.Add("checked");
                    reservedKeywords.Add("event");

                }
                return reservedKeywords;
            }
        }

        public static string ReplaceReservedKeywords(string inCode)
        {
            inCode = inCode + "€";// To mark end of string

            foreach (string keyword in ReservedKeywords)
            {
                var wrapped = WrapReservedKeyword(keyword);
                inCode = inCode.Replace($".{keyword} ", $".{wrapped} ");
                inCode = inCode.Replace($".{keyword};", $".{wrapped};");
                inCode = inCode.Replace($".{keyword}€", $".{wrapped}€");
            }

            return inCode.TrimEnd('€');
        }

        public static string WrapReservedKeyword(string name)
        {
            if (ReservedKeywords.Contains(name))
                return $"@{name}";

            return name;
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

        public static string Generate(this IPropertyAccess propertyAccess, int indent)
        {
            if (propertyAccess.Property.InterfaceType != propertyAccess.IntoVar.Type)
            {
                return $"{Indent(indent)}{QualifiedTypeName(propertyAccess.IntoVar.Type)} {propertyAccess.IntoVar.Name} = (({QualifiedTypeName(propertyAccess.Property.InterfaceType)}){propertyAccess.FromVar.Name}).{WrapReservedKeyword(propertyAccess.Property.PropertyName)};";
            }
            else
            {
                return $"{Indent(indent)}{QualifiedTypeName(propertyAccess.IntoVar.Type)} {propertyAccess.IntoVar.Name} = {propertyAccess.FromVar.Name}.{WrapReservedKeyword(propertyAccess.Property.PropertyName)};";
            }
        }

        public static string Generate(this IForeachBlock foreachBlock, int indent)
        {
            string blockCode = $"{Indent(indent)}foreach(var {foreachBlock.OverVarName} in {foreachBlock.CollectionVarName})\n{Indent(indent)}{{\n";
            blockCode += Generate(foreachBlock.ChildBlock, indent + 1);
            blockCode += $"{Indent(indent)}}}";

            return blockCode;
        }

        public static string Generate(this IfBlock ifBlock, int indent)
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

        public static string Generate(this LineComment lineComment, int indent)
        {
            return $"{Indent(indent)}// {lineComment.Comment}";
        }

        public static string SyntacticTypeName(Type t)
        {
            if (!t.GenericTypeArguments.Any())
                return t.Name;

            var genericTypes = string.Join(",", t.GenericTypeArguments.Select(x => QualifiedTypeName(x)));

            var howIsThisEvenPossible = $"{t.Name}<{genericTypes}>";

            howIsThisEvenPossible = howIsThisEvenPossible.Replace("`1", string.Empty);
            howIsThisEvenPossible = howIsThisEvenPossible.Replace("`2", string.Empty);
            howIsThisEvenPossible = howIsThisEvenPossible.Replace("`3", string.Empty);
            howIsThisEvenPossible = howIsThisEvenPossible.Replace("`4", string.Empty);
            howIsThisEvenPossible = howIsThisEvenPossible.Replace("`5", string.Empty);

            return howIsThisEvenPossible;
        }

        public static string QualifiedTypeName(Type t)
        {
            List<Type> nestedTypes = new List<Type>();
            var parentType = t;
            while (true)
            {
                nestedTypes.Add(parentType);
                parentType = parentType.DeclaringType;
                if (parentType == null)
                    break;
            }

            nestedTypes.Reverse();

            string nestedType = string.Join(".", nestedTypes.Select(x => SyntacticTypeName(x)));

            return $"{t.Namespace}.{nestedType}";
        }

        public static string Generate(this IFunction function, int indent, bool export = false)
        {
            string publicPlaceholder = export ? "public" : string.Empty;

            var parametersList = string.Join(",", function.Parameters.Select(x => $"{QualifiedTypeName(x.Type)}  {WrapReservedKeyword(x.Name)}"));

            string functionType = "System.Action";

            List<Type> genericParametersList = new List<Type>();
            genericParametersList.AddRange(function.Parameters.Select(x => x.Type));
            if (function.ReturnVariable != null)
            {
                genericParametersList.Add(function.ReturnVariable.Type);
                functionType = $"System.Func<{string.Join(", ", genericParametersList.Select(x => QualifiedTypeName(x)))}>";
            }
            else
            {
                if (genericParametersList.Any())
                {
                    functionType = $"System.Action<{string.Join(", ", genericParametersList.Select(x => QualifiedTypeName(x)))}>";
                }
            }


            var initializer = export ? "=>" : "="; // => field, = lambda

            string body = $"    {publicPlaceholder}{Indent(indent)}{functionType} {function.Name} {initializer} ({parametersList}) =>{Indent(indent)}{{\n";
            body += $"{function.ChildBlock.Generate(indent + 1)}";

            if (function.ReturnVariable != null)
            {
                body += $"{Indent(indent + 1)}return {WrapReservedKeyword(function.ReturnVariable.Name)};\n";
            }

            body += $"{Indent(indent + 1)}}};";
            return body;
        }

        public static string Indent(int level)
        {
            return new string(' ', level * IndentSize);
        }
    }
}

