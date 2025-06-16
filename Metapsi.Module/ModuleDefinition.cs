using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace Metapsi.Syntax
{
    /// <summary>
    /// The abstract syntax tree of the module
    /// </summary>
    public class Module
    {
        public HashSet<Metadata> Metadata { get; set; } = new HashSet<Metadata>();
        /// <summary>
        /// Key = source
        /// </summary>
        public Dictionary<string, Import> Imports { get; set; } = new Dictionary<string, Import>();
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

    public class Import
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

    public static class ModuleExtensions
    {
        /// <summary>
        /// Import name
        /// </summary>
        /// <param name="moduleDefinition"></param>
        /// <param name="source"></param>
        /// <param name="importName"></param>
        public static void ImportName(this Module moduleDefinition, string source, string importName)
        {
            moduleDefinition.Imports.TryGetValue(source, out Import import);
            if (import == null)
            {
                import = new Import();
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
        public static void ImportDefault(this Module moduleDefinition, string source, string asName)
        {
            moduleDefinition.Imports.TryGetValue(source, out Import import);
            if (import == null)
            {
                import = new Import();
            }

            import.Default = asName;
            moduleDefinition.Imports[source] = import;
        }

        /// <summary>
        /// Side effect import 
        /// </summary>
        /// <param name="moduleDefinition"></param>
        /// <param name="source"></param>
        public static void ImportSideEffect(this Module moduleDefinition, string source)
        {
            moduleDefinition.Imports.TryGetValue(source, out Import import);
            if (import == null)
            {
                import = new Import();
            }

            import.SideEffect = true;
            moduleDefinition.Imports[source] = import;
        }

        public static string ToJs(this Module moduleDefinition)
        {
            StringBuilder outJs = new StringBuilder();

            //foreach (var comment in moduleDefinition.Comments)
            //{
            //    var lines = comment.Split('\n');
            //    foreach (var line in lines)
            //    {
            //        outJs.AppendLine($"// {line}");
            //    }
            //}

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