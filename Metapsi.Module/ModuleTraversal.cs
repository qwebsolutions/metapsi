using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;

namespace Metapsi.Syntax
{
    public static class ModuleTraversal
    {
        public class Context
        {
            public List<SyntaxNode> ParentSyntaxNodes { get; set; } = new List<SyntaxNode>();
            public SyntaxNode CurrentSyntaxNode { get => ParentSyntaxNodes.FirstOrDefault(); }
            public SyntaxNode ParentSyntaxNode { get => ParentSyntaxNodes.Skip(1).FirstOrDefault(); }
            public AssignmentNode ParentAssignment
            {
                get
                {
                    var assignmentSyntaxNode = ParentSyntaxNodes.FirstOrDefault(x => x.Assignment != null);
                    if (assignmentSyntaxNode != null)
                    {
                        return assignmentSyntaxNode.Assignment;
                    }
                    return SsaReference.ModuleRoot;
                }
            }
        }

        public class AssignmentContext : Context
        {
            public Action TraverseAssignedNode { get; internal set; }
        }

        public class FnDefinitionContext : Context
        {
            public Action TraverseFnBody { get; internal set; }
        }

        public class FnCallContext : Context
        {
            public Action TraverseFn { get; internal set; }
            public Action TraverseArguments { get; internal set; }
        }

        public class Rules
        {
            public Action<CommentNode, Context> OnComment { get; set; }
            public Action<LiteralNode, Context> OnLiteral { get; set; }
            public Action<IdentifierNode, Context> OnIdentifier { get; set; }
            public Action<AssignmentNode, AssignmentContext> OnAssignment { get; set; }
            public Action<CallNode, FnCallContext> OnFnCall { get; set; }
            public Action<FnNode, FnDefinitionContext> OnFnDefinition { get; set; }
            public Action<LinqNode, Context> OnLinqFnDefinition { get; set; }

            public Rules()
            {
                OnAssignment = (assignment, context) =>
                {
                    context.TraverseAssignedNode();
                };
                OnFnDefinition = (fnDefinition, context) =>
                {
                    context.TraverseFnBody();
                };
                OnFnCall = (fnCall, context) =>
                {
                    context.TraverseFn();
                    context.TraverseArguments();
                };
            }
        }

        public static void Traverse(
            this Module moduleDefinition,
            Action<Rules> buildRules)
        {
            Rules rules = new Rules()
            {
                OnAssignment = (assignment, context) =>
                {
                    context.TraverseAssignedNode();
                },
                OnFnDefinition = (fnDefinition, context) =>
                {
                    context.TraverseFnBody();
                },
                OnFnCall = (fnCall, context) =>
                {
                    context.TraverseFn();
                    context.TraverseArguments();
                }
            };
            buildRules(rules);
            foreach (var node in new List<SyntaxNode>(moduleDefinition.Nodes))
            {
                Traverse(
                    node,
                    new List<SyntaxNode>(),
                    rules);
            }
        }

        private static List<SyntaxNode> WithParent(SyntaxNode syntaxNode, List<SyntaxNode> previousParents)
        {
            var newParents = new List<SyntaxNode>() { syntaxNode };
            newParents.AddRange(previousParents);
            return newParents;
        }

        public static void Traverse(
            this SyntaxNode syntaxNode,
            List<SyntaxNode> parents,
            Action<Rules> buildRules)
        {
            Rules rules = new Rules()
            {
                OnAssignment = (assignment, context) =>
                {
                    context.TraverseAssignedNode();
                },
                OnFnDefinition = (fnDefinition, context) =>
                {
                    context.TraverseFnBody();
                },
                OnFnCall = (fnCall, context) =>
                {
                    context.TraverseFn();
                    context.TraverseArguments();
                }
            };
            buildRules(rules);
            syntaxNode.Traverse(parents, rules);
        }

        public static void Traverse(
            this SyntaxNode syntaxNode,
            List<SyntaxNode> parents,
            Rules rules)
        {
            parents = WithParent(syntaxNode, parents);

            switch (syntaxNode.GetNodeType())
            {
                case NodeType.Comment:
                    if (rules.OnComment != null)
                    {
                        rules.OnComment(
                            syntaxNode.Comment,
                            new Context()
                            {
                                ParentSyntaxNodes = parents
                            });
                    }
                    break;
                case NodeType.Literal:
                    if (rules.OnLiteral != null)
                    {
                        rules.OnLiteral(
                            syntaxNode.Literal,
                            new Context()
                            {
                                ParentSyntaxNodes = parents
                            });
                    }
                    break;
                case NodeType.Identifier:
                    if (rules.OnIdentifier != null)
                    {
                        rules.OnIdentifier(
                            syntaxNode.Identifier,
                            new Context()
                            {
                                ParentSyntaxNodes = parents
                            });
                    }
                    break;
                case NodeType.Assignment:
                    if (rules.OnAssignment != null)
                    {
                        rules.OnAssignment(
                            syntaxNode.Assignment,
                            new AssignmentContext()
                            {
                                ParentSyntaxNodes = parents,
                                TraverseAssignedNode = () =>
                                {
                                    Traverse(
                                        syntaxNode.Assignment.Node,
                                        parents,
                                        rules);
                                }
                            });
                    }
                    break;
                case NodeType.Fn:
                    if (rules.OnFnDefinition != null)
                    {
                        rules.OnFnDefinition(
                            syntaxNode.Fn,
                            new FnDefinitionContext()
                            {
                                ParentSyntaxNodes = parents,
                                TraverseFnBody = () =>
                                {
                                    foreach (var child in new List<SyntaxNode>(syntaxNode.Fn.Body))
                                    {
                                        Traverse(child, parents, rules);
                                    }
                                }
                            });
                    }
                    break;
                case NodeType.Call:
                    if (rules.OnFnCall != null)
                    {
                        rules.OnFnCall(
                            syntaxNode.Call,
                            new FnCallContext()
                            {
                                ParentSyntaxNodes = parents,
                                TraverseFn = () =>
                                {
                                    Traverse(syntaxNode.Call.Fn, parents, rules);
                                },
                                TraverseArguments = () =>
                                {
                                    foreach (var argument in syntaxNode.Call.Arguments)
                                    {
                                        Traverse(argument, parents, rules);
                                    }
                                }
                            });
                    }
                    break;
                case NodeType.Linq:
                    if (rules.OnLinqFnDefinition != null)
                    {
                        rules.OnLinqFnDefinition(
                            syntaxNode.Linq,
                            new Context()
                            {
                                ParentSyntaxNodes = parents
                            });
                    }
                    break;
                default:
                    throw new NotImplementedException();
            }
        }
    }

    public class SsaReference
    {
        public AssignmentNode AssignmentNode { get; set; }
        public HashSet<AssignmentNode> ReferencedBy { get; set; } = new HashSet<AssignmentNode>();

        public static AssignmentNode ModuleRoot = new AssignmentNode() { Name = "@module" };
        public static AssignmentNode FnParameter = new AssignmentNode() { Name = "@param" };
    }

    public static class SyntaxNodeReferenceExtensions
    {
        public static Dictionary<string, SsaReference> GetSsaDependencyGraph(this Module module)
        {
            Dictionary<string, SsaReference> into = new Dictionary<string, SsaReference>();
            foreach (var import in module.Imports)
            {
                foreach (var symbol in import.Value.Imports)
                {
                    into[symbol] = new SsaReference()
                    {
                        AssignmentNode = SsaReference.ModuleRoot
                    };
                }
            }

            module.Traverse(
                rules =>
                {
                    rules.OnIdentifier = (identifier, context) =>
                    {
                        if (!into.ContainsKey(identifier.Name))
                            throw new Exception($"Identifier {identifier.Name} was reached without recording the declaration first");
                        if (!into[identifier.Name].ReferencedBy.Any())
                        {
                            throw new Exception($"Identifier {identifier.Name} was reached without recording any usage first");
                        }
                        //into[identifier.Name].ReferencedBy.Add(context.ParentSyntaxNode);
                    };
                    rules.OnAssignment = (assignment, context) =>
                    {
                        into.Add(assignment.Name, new SsaReference()
                        {
                            AssignmentNode = assignment
                        });
                        context.TraverseAssignedNode();
                    };
                    rules.OnFnDefinition = (fnDefinition, context) =>
                    {
                        foreach (var parameter in fnDefinition.Parameters)
                        {
                            into[parameter] = new SsaReference()
                            {
                                AssignmentNode = SsaReference.FnParameter
                            };
                        }
                        context.TraverseFnBody();

                        if (!string.IsNullOrEmpty(fnDefinition.Return))
                        {
                            into[fnDefinition.Return].ReferencedBy.Add(context.ParentAssignment);
                        }
                    };
                    rules.OnFnCall = (call, context) =>
                    {
                        if (call.Fn.Identifier != null)
                        {
                            into[call.Fn.Identifier.Name].ReferencedBy.Add(context.ParentAssignment);
                        }
                        context.TraverseFn();
                        foreach (var argument in call.Arguments)
                        {
                            if (argument.Identifier != null)
                            {
                                into[argument.Identifier.Name].ReferencedBy.Add(context.ParentAssignment);
                            }
                            else
                            {
                                argument.Traverse(context.ParentSyntaxNodes, rules);
                            }
                        }
                    };
                });
            return into;
        }
    }
}