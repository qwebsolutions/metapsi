using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Linq;
using static Metapsi.Syntax.ModuleTraversal;

namespace Metapsi.Syntax
{

    /// <summary>
    /// The abstract syntax tree of the module
    /// </summary>
    public class Module
    {
        /// <summary>
        /// Key = source
        /// </summary>
        public Dictionary<string, Import> Imports { get; set; } = new Dictionary<string, Import>();
        public List<SyntaxNode> Nodes { get; set; } = new List<SyntaxNode>(); // AssignmentNode or CallNode
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

    public class SyntaxNode
    {
        public LiteralNode Literal { get; set; }
        public IdentifierNode Identifier { get; set; }
        public AssignmentNode Assignment { get; set; }
        public FnNode Fn { get; set; }
        public LinqNode Linq { get; set; }
        public CallNode Call { get; set; }
        public CommentNode Comment { get; set; }
    }

    public class LiteralNode
    {
        //public NodeType Type => NodeType.Literal;
        public string Value { get; set; } // a JSON serialization
    }

    public class IdentifierNode
    {
        //public NodeType Type => NodeType.Identifier;
        public string Name { get; set; }
    }

    public class AssignmentNode
    {
        public string DebugType { get; set; }
        public string Name { get; set; }
        public SyntaxNode Node { get; set; }
    }

    public class FnNode
    {
        public string DebugSource { get; set; }

        public List<string> Parameters { get; set; } = new List<string>();
        public List<SyntaxNode> Body { get; set; } = new List<SyntaxNode>(); // Assignment nodes
        public string Return { get; set; } // Optional, return identifier name
    }

    public class LinqNode
    {
        //public NodeType Type => NodeType.Linq;
        public string Expr { get; set; } // Expression is a string so it can be called in environments where the initial C# types are not defined
    }

    public class CallNode
    {
        /// <summary>
        /// IdentifierNode or FnNode
        /// </summary>
        public SyntaxNode Fn { get; set; } 
        public List<SyntaxNode> Arguments { get; set; } = new List<SyntaxNode>(); // Literal, Identifier or Fn
    }

    public class CommentNode
    {
        //public NodeType Type => NodeType.Comment;
        public string Comment { get; set; }
    }

    public class FunctionCallSourceArgument
    {
        public string Literal { get; set; }
        public string Identifier { get; set; }
        public string LambdaFunction { get; set; }
    }

    internal class FunctionCallSource
    {
        public string FunctionLooksLike { get; set; }
        public List<FunctionCallSourceArgument> Arguments { get; set; } = new List<FunctionCallSourceArgument>();
    }

    internal class ConstantSource
    {
        public string Constant { get; set; }
    }

    internal class ParameterSource
    {
        public string FunctionName { get; set; }
    }

    internal sealed class SymbolReference : IEquatable<SymbolReference>
    {
        public string ScopeId { get; set; }
        public string SymbolName { get; set; }

        public bool Equals(SymbolReference other)
        {
            if (ReferenceEquals(other, null))
                return false;

            if (ReferenceEquals(this, other))
                return true;

            return string.Equals(ScopeId, other.ScopeId) &&
                   string.Equals(SymbolName, other.SymbolName);
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as SymbolReference);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (ScopeId?.GetHashCode() ?? 0);
                hash = hash * 23 + (SymbolName?.GetHashCode() ?? 0);
                return hash;
            }
        }
    }

    internal class NodeContext
    {

    }

    internal class TraverseActions
    {
        public Action<CommentNode, NodeContext> OnComment { get; set; }
    }

    internal class MetadataBuilder
    {
        internal class NodeMetadata
        {
            public string SsaVarName { get; set; }
            public SyntaxNode AssignmentNode { get; set; }
            //public SyntaxNode AssignedNode { get; set; }
            public List<SyntaxNode> ReferencedBy { get; set; } = new List<SyntaxNode>();
        }

        private static string NodeDescription(SyntaxNode syntaxNode)
        {
            switch (syntaxNode.GetNodeType())
            {
                case NodeType.Assignment:
                    return $"{syntaxNode.Assignment.Name} -> {syntaxNode.Assignment.Node.GetNodeType()}";
                case NodeType.Call:
                    return $"{NodeDescription(syntaxNode.Call.Fn)}({string.Join(",", syntaxNode.Call.Arguments.Select(NodeDescription))})";
                case NodeType.Identifier:
                    return syntaxNode.Identifier.Name;
                case NodeType.Literal:
                    return syntaxNode.Literal.Value;
                case NodeType.Comment:
                    return syntaxNode.Comment.Comment;
                case NodeType.Fn:
                    return $"def ({string.Join(",", syntaxNode.Fn.Parameters)})";
                case NodeType.Linq:
                    return syntaxNode.Linq.Expr;
                default:
                    throw new NotImplementedException();
            }
        }

        internal static string ListParents(List<SyntaxNode> parents)
        {
            StringBuilder b = new StringBuilder();
            foreach(var parent in parents)
            {
                b.AppendLine();
                b.Append(ModuleExtensions.Spaces(parents.IndexOf(parent) + 1));
                b.Append(NodeDescription(parent));
            }
            return b.ToString();
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

        internal static string Spaces(int indentLevel)
        {
            return new string(' ', indentLevel * 2);
        }

        private static void ThrowIfEmptyNode(SyntaxNode syntaxNode)
        {
            syntaxNode.GetNodeType();
        }

        private static CallNode RewriteCall(
            CallNode callNode, 
            AssignmentNode usingAssignmentNode)
        {
            var newCall = new CallNode();
            if (callNode.Fn.Identifier != null)
            {
                if (callNode.Fn.Identifier.Name == usingAssignmentNode.Name)
                {
                    newCall.Fn = usingAssignmentNode.Node;
                }
                else
                {
                    newCall.Fn = callNode.Fn;
                }
            }

            foreach (var argument in callNode.Arguments)
            {
                if (argument.Identifier != null)
                {
                    if (argument.Identifier.Name == usingAssignmentNode.Name)
                    {
                        newCall.Arguments.Add(usingAssignmentNode.Node);
                    }
                }
            }

            return newCall;
        }

        public static FnNode RewriteFunction(
            this FnNode fnNode,
            Dictionary<string, SsaReference> ssaDeps)
        {
            var singleUseDeps = new Dictionary<string, SsaReference>();
            foreach (var ssaDep in ssaDeps.Where(x => x.Value.ReferencedBy.Count() == 1))
            {
                singleUseDeps.Add(ssaDep.Key, ssaDep.Value);
            }

            var fnNodeSsaIds = fnNode.Body.Where(x => x.Assignment != null).Select(x => x.Assignment.Name).ToList();

            var rewrittenSsa = new Dictionary<string, AssignmentNode>();
            foreach (var ssaDep in singleUseDeps)
            {
                if (fnNodeSsaIds.Contains(ssaDep.Key))
                {
                    rewrittenSsa[ssaDep.Key] = new AssignmentNode()
                    {
                        Name = ssaDep.Key,
                        Node = ssaDep.Value.AssignmentNode.Node
                    };
                }
            }

            var originalFnSyntaxNode = new SyntaxNode()
            {
                Fn = fnNode,
            };

            var rewrittenFnNode = new FnNode()
            {
                Parameters = new List<string>(fnNode.Parameters),
                Return = fnNode.Return
            };

            originalFnSyntaxNode.Traverse(new List<SyntaxNode>(),
                (rules) =>
                {
                    rules.OnFnDefinition = (fnDef, context) =>
                    {
                        foreach (var line in fnDef.Body)
                        {
                            switch (line.GetNodeType())
                            {
                                case NodeType.Assignment:
                                    {
                                        if (singleUseDeps.ContainsKey(line.Assignment.Name))
                                        {
                                            var reference = singleUseDeps[line.Assignment.Name].ReferencedBy.Single();
                                            switch (reference.Node.GetNodeType())
                                            {
                                                case NodeType.Call:
                                                    {
                                                        //var newCall = new CallNode();
                                                        //if (reference.Node.Call.Fn.Identifier != null)
                                                        //{
                                                        //    if (reference.Node.Call.Fn.Identifier.Name == line.Assignment.Name)
                                                        //    {
                                                        //        newCall.Fn = rewrittenSsa[line.Assignment.Name].Node;
                                                        //    }
                                                        //    else
                                                        //    {
                                                        //        newCall.Fn = reference.Node.Call.Fn;
                                                        //    }
                                                        //}

                                                        //foreach (var argument in reference.Node.Call.Arguments)
                                                        //{
                                                        //    var argReplaced = false;
                                                        //    if (argument.Identifier != null)
                                                        //    {
                                                        //        if (argument.Identifier.Name == line.Assignment.Name)
                                                        //        {
                                                        //            newCall.Arguments.Add(rewrittenSsa[line.Assignment.Name].Node);
                                                        //            argReplaced = true;
                                                        //        }
                                                        //    }

                                                        //    if (!argReplaced)
                                                        //    {
                                                        //        //newCall.Arguments.Add(
                                                        //        argument.Traverse(
                                                        //            context.ParentSyntaxNodes,
                                                        //            rules);
                                                        //    }
                                                        //}

                                                        var newCall = RewriteCall(reference.Node.Call, line.Assignment);

                                                        rewrittenSsa[reference.Name] = new AssignmentNode()
                                                        {
                                                            Node = new SyntaxNode()
                                                            {
                                                                Call = newCall
                                                            }
                                                        };
                                                    }
                                                    break;
                                                case NodeType.Fn:
                                                    {
                                                        if (fnDef == reference.Node.Fn)
                                                        {
                                                            // Referenced in itself
                                                        }
                                                        else
                                                        {
                                                            throw new Exception($"{line.Assignment.Name} is referenced by {reference.Name}");
                                                        }
                                                    }
                                                    break;
                                                default:
                                                    throw new NotImplementedException();
                                            }
                                        }
                                        else
                                        {

                                        }

                                        if (!rewrittenSsa.ContainsKey(line.Assignment.Name))
                                        {
                                            rewrittenFnNode.Body.Add(line);
                                            //rewrittenFnNode.Body.Add(new SyntaxNode()
                                            //{
                                            //    Assignment = rewrittenSsa[line.Assignment.Name]
                                            //});
                                        }
                                        else
                                        {
                                            if (!singleUseDeps.ContainsKey(line.Assignment.Name))
                                            {
                                                rewrittenFnNode.Body.Add(new SyntaxNode()
                                                {
                                                    Assignment = rewrittenSsa[line.Assignment.Name]
                                                });
                                            }
                                        }

                                        //if (!singleUseDeps.ContainsKey(line.Assignment.Name))
                                        //{
                                        //    if (rewrittenSsa.ContainsKey(line.Assignment.Name))
                                        //    {
                                        //        rewrittenFnNode.Body.Add(new SyntaxNode()
                                        //        {
                                        //            Assignment = rewrittenSsa[line.Assignment.Name]
                                        //        });
                                        //    }
                                        //    else
                                        //    {
                                        //        rewrittenFnNode.Body.Add(line);
                                        //    }
                                        //}
                                        //else
                                        //{
                                        //    rewrittenFnNode.Body.Add(line);
                                        //}
                                    }
                                    break;
                                case NodeType.Call:
                                    {

                                    }
                                    break;
                                default:
                                    throw new NotImplementedException();
                            }
                        }
                        if (!string.IsNullOrEmpty(fnNode.Return))
                        {
                            if (rewrittenSsa.ContainsKey(fnNode.Return))
                            {
                                rewrittenFnNode.Return = ModuleExtensions.ToJs(rewrittenSsa[fnNode.Return].Node);
                            }
                            else
                            {
                                rewrittenFnNode.Return = fnNode.Return;
                            }
                        }
                        //context.TraverseFnBody();
                    };
                    rules.OnAssignment = (assignment, context) =>
                    {
                        context.TraverseAssignedNode();

                        if (singleUseDeps.ContainsKey(assignment.Name))
                        {

                        }
                    };
                });

            Console.WriteLine("=============== REWRITE");
            Console.WriteLine(ModuleExtensions.ToJs(rewrittenFnNode));

            return rewrittenFnNode;
        }

        public static Module InlineModule(Module moduleDefinition)
        {
            return moduleDefinition;
            var ssaDeps = moduleDefinition.GetSsaDependencyGraph();

            Module inlined = new Module()
            {
                Imports = moduleDefinition.Imports
            };

            var currentFnDef = new FnNode();

            moduleDefinition.Traverse(
                rules =>
                {
                    rules.OnFnDefinition = (fnDef, context) =>
                    {
                        var newFn = RewriteFunction(fnDef, ssaDeps);
                    };
                });

            return inlined;
        }

        public static string ToJs(this Module moduleDefinition, ToJavaScriptOptions options = null)
        {
            moduleDefinition = InlineModule(moduleDefinition);

            if (options == null) options = new ToJavaScriptOptions();

            StringBuilder outJs = new StringBuilder();

            List<SymbolReference> symbols = new List<SymbolReference>();

            foreach (var import in moduleDefinition.Imports)
            {
                var source = import.Key;

                var importDefinition = import.Value;

                if (!string.IsNullOrEmpty(importDefinition.Default))
                {
                    outJs.AppendLine($"import {importDefinition.Default} from \"{source}\";");
                }

                if (importDefinition.Imports.Any())
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

        public static NodeType GetNodeType(this SyntaxNode syntaxNode)
        {
            if (syntaxNode.Literal != null) return NodeType.Literal;
            if (syntaxNode.Identifier != null) return NodeType.Identifier;
            if (syntaxNode.Assignment != null) return NodeType.Assignment;
            if (syntaxNode.Fn != null) return NodeType.Fn;
            if (syntaxNode.Linq != null) return NodeType.Linq;
            if (syntaxNode.Call != null) return NodeType.Call;
            if (syntaxNode.Comment != null) return NodeType.Comment;

            throw new ArgumentException("Node type not supported");
        }

        public static string ToJs(this SyntaxNode syntaxNode, int indentLevel = 0)
        {
            // This renders the node itself, which could be anywhere
            // Pass indent level, but don't use it for alignment here,
            // it will be used in the specific node output
            switch (syntaxNode.GetNodeType())
            {
                case NodeType.Literal:
                    {
                        return syntaxNode.Literal.Value;
                    }
                case NodeType.Identifier:
                    {
                        return syntaxNode.Identifier.Name;
                    }
                case NodeType.Assignment:
                    {
                        var assignment = syntaxNode.Assignment;
                        var typeComment = string.IsNullOrEmpty(assignment.DebugType) ? "" : $"/*{assignment.DebugType}*/ ";
                        return $"let {typeComment}{assignment.Name} = " + assignment.Node.ToJs(indentLevel);
                    }
                case NodeType.Fn:
                    {
                        return ToJs(syntaxNode.Fn, indentLevel);
                    }
                case NodeType.Linq:
                    {
                        return syntaxNode.Linq.Expr;
                    }
                case NodeType.Call:
                    {
                        return ToJs(syntaxNode.Call, indentLevel);
                    }
                case NodeType.Comment:
                    {
                        var commentNode = syntaxNode.Comment;
                        return $"// {commentNode.Comment}";
                    }
                default:
                    throw new NotSupportedException("Node type not supported");
            }
        }

        public static string ToJs(this FnNode fnNode, int indentLevel = 0)
        {
            // This handles { ... } blocks, this is the place where alignment happens

            StringBuilder outJs = new StringBuilder();
            var parameters = string.Join(", ", fnNode.Parameters);
            var fnNameComment = string.IsNullOrEmpty(fnNode.DebugSource) ? "" : $"/*{fnNode.DebugSource}*/";
            outJs.AppendLine($"({parameters}) => {{ {fnNameComment}");
            foreach (var line in fnNode.Body)
            {
                outJs.AppendLine(Spaces(indentLevel + 1) + line.ToJs(indentLevel + 1));
            }

            if (fnNode.Return != null)
            {
                outJs.AppendLine($"{Spaces(indentLevel + 1)}return {fnNode.Return}");
            }

            outJs.Append(Spaces(indentLevel) + "}");

            return outJs.ToString();
        }

        public static string ToJs(this CallNode callNode, int indentLevel = 0)
        {
            StringBuilder outJs = new StringBuilder();
            if (callNode.Fn.GetNodeType() == NodeType.Fn)
            {
                outJs.Append("(" + ToJs(callNode.Fn.Fn) + ")");
            }
            else if (callNode.Fn.GetNodeType() == NodeType.Identifier)
            {
                outJs.Append(callNode.Fn.Identifier.Name);
            }
            else if (callNode.Fn.GetNodeType() == NodeType.Linq)
            {
                outJs.Append("(" + ToJs(callNode.Fn) + ")");
            }
            else throw new NotSupportedException($"Cannot call {callNode.Fn.GetNodeType()}");
            List<string> arguments = new List<string>();
            foreach (var argument in callNode.Arguments)
            {
                arguments.Add(argument.ToJs(indentLevel));
            }

            outJs.Append($"({string.Join(", ", arguments)})");
            return outJs.ToString();
        }

        /// <summary>
        /// Computes a module hash without resolving resources first
        /// </summary>
        /// <param name="module"></param>
        /// <returns>Module hash</returns>
        public static string Hash(this Module module)
        {
            return EmbeddedFiles.Hash(Metapsi.Serialize.ToJson(module, "to-js"));
        }
    }
}