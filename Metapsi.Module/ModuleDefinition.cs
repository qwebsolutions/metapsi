using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml.Linq;

namespace Metapsi.Syntax
{
    /// <summary>
    /// The abstract syntax tree of the module
    /// </summary>
    public class ModuleDefinition
    {
        public List<string> Comments { get; set; } = new List<string>();
        /// <summary>
        /// Key = source
        /// </summary>
        public Dictionary<string, ImportDefinition> Imports { get; set; } = new Dictionary<string, ImportDefinition>();
        public List<ISyntaxNode> Nodes { get; set; } = new List<ISyntaxNode>(); // AssignmentNode or CallNode
    }

    public enum NodeType
    {
        Literal, // 42, "John", { Name: "" }
        Identifier, // points to a variable
        Assignment, // var a = "John"
        Fn, // Function definition
        Linq, // Linq expression
        Call, // Function call
        Comment // Comment node
    }

    /// <summary>
    /// 
    /// </summary>
    public class LocalRename : IEquatable<LocalRename>
    {
        public string Import { get; set; }
        public string LocalName { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            if (!(obj is LocalRename)) return false;

            LocalRename other = (LocalRename)obj;

            return this.Import == other.Import && this.LocalName == other.LocalName;
        }

        public bool Equals(LocalRename other)
        {
            return this.Import == other.Import && this.LocalName == other.LocalName;
        }

        public override int GetHashCode()
        {
            return this.Import.GetHashCode() ^ this.LocalName.GetHashCode();
        }
    }

    public class ImportDefinition
    {
        /// <summary>
        /// Local name for default export
        /// </summary>
        public string Default { get; set; }

        /// <summary>
        /// Import with no name, performs side effect
        /// </summary>
        public bool SideEffect { get; set; }

        /// <summary>
        /// Named imports
        /// </summary>
        public HashSet<string> Imports { get; set; } = new HashSet<string>();

        /// <summary>
        /// Local renames. Could be multiple for same import
        /// </summary>
        public HashSet<LocalRename> Locals { get; set; } = new HashSet<LocalRename>();
    }

    public interface ISyntaxNode
    {
        NodeType Type { get; }
    }

    public class LiteralNode : ISyntaxNode
    {
        public NodeType Type => NodeType.Literal;
        public string Value { get; set; } // a JSON serialization
    }

    public class IdentifierNode : ISyntaxNode
    {
        public NodeType Type => NodeType.Identifier;
        public string Name { get; set; }
    }

    public class AssignmentNode : ISyntaxNode
    {
        public NodeType Type => NodeType.Assignment;
        public string Name { get; set; }
        public ISyntaxNode Node { get; set; }
    }

    public class FnNode : ISyntaxNode
    {
        public NodeType Type => NodeType.Fn;
        public List<string> Parameters { get; set; } = new List<string>();
        public List<ISyntaxNode> Body { get; set; } = new List<ISyntaxNode>(); // Assignment nodes
        public string Return { get; set; } // Optional, return identifier name
    }

    public class LinqNode : ISyntaxNode
    {
        public NodeType Type => NodeType.Linq;
        public string Expr { get; set; } // Expression is a string so it can be called in environments where the initial C# types are not defined
    }

    public class CallNode : ISyntaxNode
    {
        public NodeType Type => NodeType.Call;
        public ISyntaxNode Fn { get; set; } // IdentifierNode or FnNode
        public List<ISyntaxNode> Arguments { get; set; } = new List<ISyntaxNode>(); // Literal, Identifier or Fn
    }

    public class CommentNode : ISyntaxNode
    {
        public NodeType Type => NodeType.Comment;
        public string Comment { get; set; }
    }

    public class SyntaxNodeConverter : JsonConverter<ISyntaxNode>
    {
        public override ISyntaxNode Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType != JsonTokenType.StartObject)
            {
                throw new JsonException("Expected StartObject token");
            }

            reader.Read();
            if (reader.TokenType != JsonTokenType.PropertyName)
            {
                throw new JsonException("Expected PropertyName token");
            }

            var propertyName = reader.GetString();

            if (propertyName != "Type")
            {
                throw new JsonException("Expected Type property name");
            }

            reader.Read();

            var nodeType = reader.GetString();

            ISyntaxNode outNode = null;

            switch ((NodeType)Enum.Parse(typeof(NodeType), nodeType))
            {
                case NodeType.Literal:
                    {
                        outNode = new LiteralNode()
                        {
                            Value = ReadProperty<LiteralNode>(x => x.Value, ref reader, options)
                        };
                    }
                    break;
                case NodeType.Identifier:
                    {
                        outNode = new IdentifierNode()
                        {
                            Name = ReadProperty<IdentifierNode>(x => x.Name, ref reader, options)
                        };
                    }
                    break;
                case NodeType.Assignment:
                    {
                        outNode = new AssignmentNode()
                        {
                            Name = ReadProperty<AssignmentNode>(x => x.Name, ref reader, options),
                            Node = ReadProperty<AssignmentNode>(x => x.Node, ref reader, options)
                        };
                    }
                    break;
                case NodeType.Fn:
                    {
                        outNode = new FnNode()
                        {
                            Parameters = ReadProperty<FnNode>(x => x.Parameters, ref reader, options),
                            Body = ReadProperty<FnNode>(x => x.Body, ref reader, options),
                            Return = ReadProperty<FnNode>(x => x.Return, ref reader, options)
                        };
                    }
                    break;
                case NodeType.Call:
                    {
                        outNode = new CallNode()
                        {
                            Fn = ReadProperty<CallNode>(x => x.Fn, ref reader, options),
                            Arguments = ReadProperty<CallNode>(x => x.Arguments, ref reader, options),
                        };
                    }
                    break;
                case NodeType.Linq:
                    {
                        outNode = new LinqNode()
                        {
                            Expr = ReadProperty<LinqNode>(x => x.Expr, ref reader, options)
                        };
                    }
                    break;
                case NodeType.Comment:
                    {
                        outNode = new CommentNode()
                        {
                            Comment = ReadProperty<CommentNode>(x => x.Comment, ref reader, options)
                        };
                    }
                    break;
            }

            reader.Read();
            if (reader.TokenType != JsonTokenType.EndObject)
            {
                throw new JsonException("Expected EndObject");
            }

            return outNode;
        }

        public override void Write(Utf8JsonWriter writer, ISyntaxNode value, JsonSerializerOptions options)
        {
            switch (value.Type)
            {
                case NodeType.Literal:
                    ((JsonConverter<LiteralNode>)options.GetConverter(typeof(LiteralNode))).Write(writer, value as LiteralNode, options);
                    break;
                case NodeType.Identifier:
                    ((JsonConverter<IdentifierNode>)options.GetConverter(typeof(IdentifierNode))).Write(writer, value as IdentifierNode, options);
                    break;
                case NodeType.Assignment:
                    ((JsonConverter<AssignmentNode>)options.GetConverter(typeof(AssignmentNode))).Write(writer, value as AssignmentNode, options);
                    break;
                case NodeType.Fn:
                    ((JsonConverter<FnNode>)options.GetConverter(typeof(FnNode))).Write(writer, value as FnNode, options);
                    break;
                case NodeType.Call:
                    ((JsonConverter<CallNode>)options.GetConverter(typeof(CallNode))).Write(writer, value as CallNode, options);
                    break;
                case NodeType.Linq:
                    ((JsonConverter<LinqNode>)options.GetConverter(typeof(LinqNode))).Write(writer, value as LinqNode, options);
                    break;
                case NodeType.Comment:
                    ((JsonConverter<CommentNode>)options.GetConverter(typeof(CommentNode))).Write(writer, value as CommentNode, options);
                    break;
            }
        }

        private void ReadProperty(string propertyName, ref Utf8JsonReader reader, JsonSerializerOptions options)
        {
            reader.Read();
            if (reader.TokenType != JsonTokenType.PropertyName)
            {
                throw new JsonException("Property name expected!");
            }

            var nextPropertyName = reader.GetString();
            if (nextPropertyName != propertyName)
                throw new JsonException($"{propertyName} property expected!");

            reader.Read();
        }

        private string ReadProperty<T>(System.Linq.Expressions.Expression<Func<T, string>> property, ref Utf8JsonReader reader, JsonSerializerOptions options)
        {
            ReadProperty(property.PropertyName(), ref reader, options);
            return reader.GetString();
        }

        private List<string> ReadProperty<T>(System.Linq.Expressions.Expression<Func<T, List<string>>> property, ref Utf8JsonReader reader, JsonSerializerOptions options)
        {
            List<string> outList = new List<string>();
            ReadProperty(property.PropertyName(), ref reader, options);
            if (reader.TokenType != JsonTokenType.StartArray)
            {
                throw new JsonException("Array expected!");
            }
            while (true)
            {
                reader.Read();
                if (reader.TokenType != JsonTokenType.EndArray)
                {
                    outList.Add(reader.GetString());
                }
                else break;
            }
            return outList;
        }

        private List<ISyntaxNode> ReadProperty<T>(System.Linq.Expressions.Expression<Func<T, List<ISyntaxNode>>> property, ref Utf8JsonReader reader, JsonSerializerOptions options)
        {
            List<ISyntaxNode> outList = new List<ISyntaxNode>();
            ReadProperty(property.PropertyName(), ref reader, options);
            if (reader.TokenType != JsonTokenType.StartArray)
            {
                throw new JsonException("Array expected!");
            }
            while (true)
            {
                reader.Read();
                if (reader.TokenType != JsonTokenType.EndArray)
                {
                    outList.Add(this.Read(ref reader, typeof(ISyntaxNode), options));
                }
                else break;
            }
            return outList;
        }

        private ISyntaxNode ReadProperty<T>(System.Linq.Expressions.Expression<Func<T, ISyntaxNode>> property, ref Utf8JsonReader reader, JsonSerializerOptions options)
        {
            ReadProperty(property.PropertyName(), ref reader, options);
            return this.Read(ref reader, typeof(ISyntaxNode), options);
        }
    }

    public static class ModuleExtensions
    {
        /// <summary>
        /// Import name
        /// </summary>
        /// <param name="moduleDefinition"></param>
        /// <param name="source"></param>
        /// <param name="importName"></param>
        public static void ImportName(this ModuleDefinition moduleDefinition, string source, string importName)
        {
            moduleDefinition.Imports.TryGetValue(source, out ImportDefinition import);
            if (import == null)
            {
                import = new ImportDefinition();
            }

            import.Imports.Add(importName);
            moduleDefinition.Imports[source] = import;
        }

        /// <summary>
        /// Import default with name <paramref name="asName"/>
        /// </summary>
        /// <param name="moduleDefinition"></param>
        /// <param name="source"></param>
        /// <param name="asName"></param>
        public static void ImportDefault(this ModuleDefinition moduleDefinition, string source, string asName)
        {
            moduleDefinition.Imports.TryGetValue(source, out ImportDefinition import);
            if (import == null)
            {
                import = new ImportDefinition();
            }

            import.Default = asName;
            moduleDefinition.Imports[source] = import;
        }

        /// <summary>
        /// Side effect import 
        /// </summary>
        /// <param name="moduleDefinition"></param>
        /// <param name="source"></param>
        public static void ImportSideEffect(this ModuleDefinition moduleDefinition, string source)
        {
            moduleDefinition.Imports.TryGetValue(source, out ImportDefinition import);
            if (import == null)
            {
                import = new ImportDefinition();
            }

            import.SideEffect = true;
            moduleDefinition.Imports[source] = import;
        }

        //public static ModuleDefinition GetDefinition(this Syntax.Module module)
        //{
        //    ModuleDefinition outModule = new();
        //    foreach (var import in module.Imports)
        //    {
        //        if (import.Symbol != "Enumerable")
        //        {
        //            var importModule = import.Module;
        //            if (!importModule.StartsWith("/"))
        //            {
        //                importModule = "/" + importModule;
        //            }
        //            if (!importModule.EndsWith("js"))
        //            {
        //                importModule += ".js";
        //            }
        //            outModule.ImportName(importModule, import.Symbol);
        //        }
        //    }
        //    foreach (var constant in module.Consts)
        //    {
        //        if (constant.Value is System.Linq.Expressions.Expression)
        //        {
        //            outModule.ImportDefault("/linq.js", "Enumerable");

        //            System.Linq.Expressions.Expression lambda = constant.Value as System.Linq.Expressions.Expression;

        //            var jsBody = LinqConverter.ToJavaScript(lambda);
        //            outModule.Nodes.Add(new AssignmentNode()
        //            {
        //                Name = constant.Name,
        //                Node = new LinqNode() { Expr = jsBody },
        //            });
        //        }
        //        else
        //        {
        //            outModule.Nodes.Add(new AssignmentNode()
        //            {
        //                Name = constant.Name,
        //                Node = new LiteralNode()
        //                {
        //                    Value = Metapsi.Serialize.ToJson(constant.Value)
        //                }
        //            });
        //        }
        //    }
        //    foreach (var function in module.Functions)
        //    {
        //        outModule.Nodes.Add(new AssignmentNode()
        //        {
        //            Name = function.Name,
        //            Node = ToFnNode(function, outModule)
        //        });
        //    }

        //    return outModule;
        //}

        //private static FnNode ToFnNode(IFunction function, ModuleDefinition outModule)
        //{
        //    return new FnNode()
        //    {
        //        Parameters = function.Parameters.Select(x => x.Name).ToList(),
        //        Return = function.ReturnVariable?.Name,
        //        Body = GetSyntaxBody(function.ChildBlock, outModule)
        //    };
        //}

        //public static List<ISyntaxNode> GetSyntaxBody(this Syntax.Block block, ModuleDefinition moduleDefinition)
        //{
        //    List<ISyntaxNode> body = new();

        //    foreach (var line in block.Lines)
        //    {
        //        switch (line)
        //        {
        //            case LineComment lineComment:
        //                {
        //                    body.Add(new CommentNode() { Comment = $"{lineComment.Comment} {lineComment.FileName} {lineComment.LineNumber}" });
        //                }
        //                break;
        //            case Metapsi.Syntax.FunctionCall call:
        //                {
        //                    var arguments = call.Arguments.Select(x => new IdentifierNode() { Name = x.Name });
        //                    var callNode = new CallNode()
        //                    {
        //                        Fn = new IdentifierNode() { Name = call.Function.Name },
        //                        Arguments = arguments.Cast<ISyntaxNode>().ToList(),
        //                    };

        //                    if (call.IntoVariable != null)
        //                    {
        //                        body.Add(new AssignmentNode()
        //                        {
        //                            Name = call.IntoVariable.Name,
        //                            Node = callNode
        //                        });
        //                    }
        //                    else
        //                    {
        //                        body.Add(callNode);
        //                    }
        //                }
        //                break;
        //            case IfBlock ifBlock:
        //                {
        //                    moduleDefinition.ImportName("/metapsi.core.js", "mIf");
        //                    var ifCall = new CallNode()
        //                    {
        //                        Fn = new IdentifierNode() { Name = "mIf" }
        //                    };
        //                    ifCall.Arguments.Add(new IdentifierNode() { Name = ifBlock.Var.Name });
        //                    ifCall.Arguments.Add(new FnNode() { Body = GetSyntaxBody(ifBlock.TrueBlock, moduleDefinition) });
        //                    if (ifBlock.FalseBlock != null)
        //                    {
        //                        ifCall.Arguments.Add(new FnNode() { Body = GetSyntaxBody(ifBlock.FalseBlock, moduleDefinition) });
        //                    }
        //                    body.Add(ifCall);
        //                }
        //                break;
        //            case IForeachBlock foreachBlock:
        //                {
        //                    moduleDefinition.ImportName("/metapsi.core.js", "mForEach");
        //                    body.Add(new CallNode()
        //                    {
        //                        Fn = new IdentifierNode() { Name = "mForEach" },
        //                        Arguments = new List<ISyntaxNode>()
        //                    {
        //                        new IdentifierNode()
        //                        {
        //                            Name = foreachBlock.CollectionVarName
        //                        },
        //                        new FnNode()
        //                        {
        //                            Parameters = new List<string>(){ foreachBlock.OverVarName, "index"},
        //                            Body = GetSyntaxBody(foreachBlock.ChildBlock, moduleDefinition)
        //                        }
        //                    }
        //                    });
        //                }
        //                break;
        //            case IFunction function:
        //                {
        //                    body.Add(
        //                        new AssignmentNode()
        //                        {
        //                            Name = function.Name,
        //                            Node = ToFnNode(function, moduleDefinition)
        //                        });
        //                }
        //                break;
        //            case IObjectConstructor obj:
        //                {
        //                    body.Add(new AssignmentNode()
        //                    {
        //                        Name = obj.IntoVar.Name,
        //                        Node = new LiteralNode()
        //                        {
        //                            Value = Metapsi.Serialize.ToJson(obj.From)
        //                        }
        //                    });
        //                }
        //                break;
        //            case ICollectionConstructor col:
        //                {
        //                    body.Add(new AssignmentNode()
        //                    {
        //                        Name = col.IntoVar.Name,
        //                        Node = new LiteralNode()
        //                        {
        //                            Value = Metapsi.Serialize.ToJson(new List<object>())
        //                        }
        //                    });
        //                }
        //                break;
        //            case IPropertyAssignment setter:
        //                {
        //                    moduleDefinition.ImportName("/metapsi.core.js", "mSet");
        //                    body.Add(new CallNode()
        //                    {
        //                        Fn = new IdentifierNode() { Name = "mSet" },
        //                        Arguments = new List<ISyntaxNode>()
        //                    {
        //                        new IdentifierNode()
        //                        {
        //                            Name = setter.ObjectVar.Name,
        //                        },
        //                        new LiteralNode()
        //                        {
        //                            Value = Metapsi.Serialize.ToJson(setter.Property.PropertyName),
        //                        },
        //                        new IdentifierNode()
        //                        {
        //                            Name= setter.FromVar.Name,
        //                        }
        //                    }
        //                    });
        //                }
        //                break;
        //            default:
        //                throw new NotImplementedException();
        //        }
        //    }
        //    return body;
        //}

        public static string ToJs(this ModuleDefinition moduleDefinition)
        {
            //EmbeddedFiles.Add(typeof(Metapsi.JavaScript.PrettyBuilder).Assembly, "metapsi.core.js");
            //EmbeddedFiles.Add(typeof(LinqConverter).Assembly, "uuid.js");
            //EmbeddedFiles.Add(typeof(LinqConverter).Assembly, "linq.js");

            StringBuilder outJs = new StringBuilder();

            foreach (var comment in moduleDefinition.Comments)
            {
                var lines = comment.Split('\n');
                foreach (var line in lines)
                {
                    outJs.AppendLine($"// {line}");
                }
            }

            foreach (var import in moduleDefinition.Imports)
            {
                var source = import.Key;
                var importDefinition = import.Value;

                if (!string.IsNullOrEmpty(importDefinition.Default))
                {
                    outJs.AppendLine($"import {importDefinition.Default} from \"{source}\";");
                }
                
                if(importDefinition.Imports.Any())
                {
                    List<string> importNames = new List<string>();
                    foreach (var name in importDefinition.Imports)
                    {
                        importNames.Add(name);
                    }

                    var joined = string.Join(", ", importNames);

                    outJs.AppendLine($"import {{ {joined} }} from \"{source}\";");
                }

                if (importDefinition.SideEffect)
                {
                    outJs.AppendLine($"import \"{source}\";");
                }
            }

            foreach (var node in moduleDefinition.Nodes)
            {
                outJs.AppendLine(node.ToJs());
            }

            return outJs.ToString();
        }

        public static string ToJs(this ISyntaxNode syntaxNode)
        {
            switch (syntaxNode.Type)
            {
                case NodeType.Literal:
                    {
                        var literal = syntaxNode as LiteralNode;
                        return literal.Value;
                    }
                case NodeType.Identifier:
                    {
                        var identifier = syntaxNode as IdentifierNode;
                        return identifier.Name;
                    }
                case NodeType.Assignment:
                    {
                        var assignment = syntaxNode as AssignmentNode;
                        return $"let {assignment.Name} = " + assignment.Node.ToJs();
                    }
                case NodeType.Fn:
                    {
                        var fnDef = syntaxNode as FnNode;
                        return ToJs(fnDef);
                    }
                case NodeType.Linq:
                    {
                        var linqNode = syntaxNode as LinqNode;
                        return linqNode.Expr;
                    }
                case NodeType.Call:
                    {
                        var callNode = syntaxNode as CallNode;
                        return ToJs(callNode);
                    }
                case NodeType.Comment:
                    {
                        var commentNode = syntaxNode as CommentNode;
                        return $"// {commentNode.Comment}";
                    }
                default:
                    throw new NotSupportedException(syntaxNode.Type.ToString());
            }
        }

        public static string ToJs(this FnNode fnNode)
        {
            StringBuilder outJs = new StringBuilder();
            var parameters = string.Join(", ", fnNode.Parameters);
            outJs.AppendLine($"({parameters}) => {{ ");
            foreach (var line in fnNode.Body)
            {
                outJs.AppendLine(line.ToJs());
            }

            if (fnNode.Return != null)
            {
                outJs.AppendLine($"return {fnNode.Return}");
            }

            outJs.Append("}");

            return outJs.ToString();
        }

        public static string ToJs(this CallNode callNode)
        {
            StringBuilder outJs = new StringBuilder();
            if (callNode.Fn.Type == NodeType.Fn)
            {
                outJs.Append("(" + ToJs(callNode.Fn as FnNode) + ")");
            }
            else if (callNode.Fn.Type == NodeType.Identifier)
            {
                outJs.Append((callNode.Fn as IdentifierNode).Name);
            }
            else if (callNode.Fn.Type == NodeType.Linq)
            {
                outJs.Append("(" + ToJs(callNode.Fn as LinqNode) + ")");
            }
            else throw new NotSupportedException($"Cannot call {callNode.Fn.Type}");
            List<string> arguments = new List<string>();
            foreach (var argument in callNode.Arguments)
            {
                arguments.Add(argument.ToJs());
            }

            outJs.Append($"({string.Join(", ", arguments)})");
            return outJs.ToString();
        }
    }
}