using System;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Metapsi.Syntax
{
    public class LinqNodeExtensions
    {
        public static LinqNode FromLambda(LambdaExpression lambda)
        {
            return new LinqNode()
            {
                Expr = LinqConverter.ToJavaScript(lambda)
            };
        }
    }

    public class LinqConverter : ExpressionVisitor
    {
        public static string ToJavaScript(Expression expression)
        {
            var converter = new LinqConverter();
            converter.Visit(expression);
            return converter.JsLinq();
        }

        private StringBuilder jsBuilder = new StringBuilder();

        public string JsLinq()
        {
            return jsBuilder.ToString();
        }

        protected override Expression VisitBinary(BinaryExpression node)
        {
            jsBuilder.Append("(");
            Visit(node.Left);
            jsBuilder.Append(" ");
            jsBuilder.Append(GetOperator(node.NodeType));
            jsBuilder.Append(" ");
            Visit(node.Right);
            jsBuilder.Append(")");
            return node;
        }

        protected override Expression VisitBlock(BlockExpression node)
        {
            throw new NotSupportedException();
        }

        protected override CatchBlock VisitCatchBlock(CatchBlock node)
        {
            throw new NotSupportedException();
        }

        protected override Expression VisitConditional(ConditionalExpression node)
        {
            base.Visit(node.Test);
            jsBuilder.Append("?");
            base.Visit(node.IfTrue);
            jsBuilder.Append(":");
            base.Visit(node.IfFalse);
            return node;
        }

        protected override Expression VisitConstant(ConstantExpression node)
        {
            if (node.Type == typeof(bool))
            {
                jsBuilder.Append(node.Value.ToString().ToLowerInvariant());
            }
            else
            {
                if (node.Value == null)
                {
                    jsBuilder.Append("null");
                }
                else
                {
                    if (node.Type == typeof(string))
                    {
                        jsBuilder.Append("\"" + node.Value.ToString() + "\"");
                    }
                    else
                    {
                        jsBuilder.Append(node.Value.ToString());
                    }
                }
            }

            return base.VisitConstant(node);
        }

        protected override Expression VisitDebugInfo(DebugInfoExpression node)
        {
            throw new NotSupportedException();
        }

        protected override Expression VisitDefault(DefaultExpression node)
        {
            throw new NotSupportedException();
        }

        protected override Expression VisitDynamic(DynamicExpression node)
        {
            throw new NotSupportedException();
        }

        protected override ElementInit VisitElementInit(ElementInit node)
        {
            throw new NotSupportedException();
        }

        protected override Expression VisitExtension(Expression node)
        {
            throw new NotSupportedException();
        }

        protected override Expression VisitGoto(GotoExpression node)
        {
            throw new NotSupportedException();
        }

        protected override Expression VisitIndex(IndexExpression node)
        {
            throw new NotSupportedException();
        }

        protected override Expression VisitInvocation(InvocationExpression node)
        {
            base.Visit(node.Expression);
            var methodName = node.Expression.ToString();
            jsBuilder.Append('(');

            var currentArgument = 0;
            foreach (var actualArgument in node.Arguments)
            {
                base.Visit(actualArgument);
                currentArgument++;
                if (currentArgument < node.Arguments.Count())
                    jsBuilder.Append(",");
            }

            jsBuilder.Append(")");
            return node;
        }

        protected override Expression VisitLabel(LabelExpression node)
        {
            throw new NotSupportedException();
        }

        //[return: NotNullIfNotNull("node")]
        protected override LabelTarget VisitLabelTarget(LabelTarget node)
        {
            throw new NotSupportedException();
        }

        protected override Expression VisitLambda<T>(Expression<T> node)
        {
            if (node.Parameters.Count == 0)
            {
                jsBuilder.Append("() =>");
                base.Visit(node.Body);
            }
            else if (node.Parameters.Count == 1)
            {
                jsBuilder.Append($"{node.Parameters.Single().Name} => (");
                base.Visit(node.Body);
                jsBuilder.Append(")");
            }
            else
            {
                jsBuilder.Append($"({string.Join(", ", node.Parameters.Select(x => x.Name))}) => (");
                base.Visit(node.Body);
                jsBuilder.Append(")");
            }
            return node;
        }

        protected override Expression VisitListInit(ListInitExpression node)
        {
            throw new NotSupportedException();
        }

        protected override Expression VisitLoop(LoopExpression node)
        {
            throw new NotSupportedException();
        }

        protected override Expression VisitMember(MemberExpression node)
        {
            base.Visit(node.Expression);
            jsBuilder.Append(".");

            // Shy support for string length
            if (node.Expression.Type == typeof(string) && node.Member.Name == "Length")
            {
                jsBuilder.Append("length");
            }
            else
                jsBuilder.Append(node.Member.Name);
            return node;
        }

        protected override MemberAssignment VisitMemberAssignment(MemberAssignment node)
        {
            jsBuilder.Append(node.Member.Name);
            jsBuilder.Append(':');
            base.Visit(node.Expression);
            return node;
        }

        protected override MemberBinding VisitMemberBinding(MemberBinding node)
        {
            throw new NotSupportedException();
        }

        protected override Expression VisitMemberInit(MemberInitExpression node)
        {
            jsBuilder.Append("{");
            foreach (var binding in node.Bindings)
            {
                base.VisitMemberBinding(binding);
                if (binding != node.Bindings.Last())
                {
                    jsBuilder.Append(',');
                }
            }
            jsBuilder.Append("}");
            return node;
        }

        protected override MemberListBinding VisitMemberListBinding(MemberListBinding node)
        {
            throw new NotSupportedException();
        }

        protected override MemberMemberBinding VisitMemberMemberBinding(MemberMemberBinding node)
        {
            throw new NotSupportedException();
        }

        protected override Expression VisitMethodCall(MethodCallExpression node)
        {
            if (node.Object != null)
            {
                base.Visit(node.Object);
                if(node.Method.Name == "ToString")
                {
                    return node;
                }
                else if (node.Method != null && node.Method.Name == "get_Item" && node.Method.DeclaringType.Namespace == "System.Collections.Generic")
                {
                    jsBuilder.Append("[");
                    base.Visit(node.Arguments.First());
                    jsBuilder.Append("]");
                    return node;
                }

                jsBuilder.Append(".");
                jsBuilder.Append(node.Method.Name);
                jsBuilder.Append("(");
                var currentArgument = 0;
                foreach (var actualArgument in node.Arguments)
                {
                    base.Visit(actualArgument);
                    currentArgument++;
                    if (currentArgument < node.Arguments.Count())
                        jsBuilder.Append(",");
                }
                jsBuilder.Append(")");
                return node;
            }
            else if (node.Method != null && node.Method.Name == "get_Item" && node.Method.DeclaringType.Namespace == "System.Collections.Generic")
            {
                jsBuilder.Append("[");
                base.Visit(node.Arguments.First());
                jsBuilder.Append("]");
                return node;
            }
            else
            {
                var isLinqMethod = node.Method.DeclaringType != null && node.Method.DeclaringType.Namespace == "System.Linq";

                // (x, id) => Enumerable.from(Enumerable.from(x.Children).selectMany(x => x.Children)).single(x => (x.GuidProperty === id))

                if (isLinqMethod)
                {
                    var thisExtensionArgument = node.Arguments.First();
                    jsBuilder.Append("Enumerable.from(");
                    base.Visit(thisExtensionArgument);
                    jsBuilder.Append(").");

                    if (node.Method.Name == "ToList")
                    {
                        jsBuilder.Append("toArray()");
                    }
                    else
                    {
                        var lowerCase = node.Method.Name.Substring(0, 1).ToLowerInvariant() + node.Method.Name.Substring(1);
                        jsBuilder.Append(lowerCase);
                        jsBuilder.Append("(");

                        var actualArguments = node.Arguments.Skip(1);
                        var currentArgument = 0;
                        foreach (var actualArgument in node.Arguments.Skip(1))
                        {
                            base.Visit(actualArgument);
                            currentArgument++;
                            if (currentArgument < actualArguments.Count())
                                jsBuilder.Append(",");
                        }
                        jsBuilder.Append(")");
                    }
                }
                else throw new NotSupportedException();
            }

            //if (node.Arguments.Count < 1)
            //    return base.VisitMethodCall(node);


            //LinqFunctions.Add(node.Method.Name);
            //if (node.Method.Name.ToLower() == "get_item")
            //{
            //    IndexeArguments.Add(node.Arguments.Single().ToString());
            //}

            //if (node.Arguments[0].Type.IsAssignableTo(typeof(System.Collections.IEnumerable)))
            //{
            //    var thisArg = node.Arguments[0];

            //    Type t = thisArg.Type.GenericTypeArguments.FirstOrDefault();

            //    if (t != null)
            //    {
            //        var arguments = new List<Expression>();

            //        var toEnumerableCall = Expression.Call(typeof(Enumerable), nameof(Enumerable.from), new[] { thisArg.Type }, Visit(thisArg));
            //        arguments.Add(toEnumerableCall);
            //        arguments.AddRange(node.Arguments.Skip(1).Select(x => Visit(x)));
            //        var wrapped = Expression.Call(node.Method, arguments);
            //        return wrapped;
            //    }
            //}
            //return base.VisitMethodCall(node);

            //else return base.Visit(node);
            return node;
        }

        protected override Expression VisitNew(NewExpression node)
        {
            throw new NotSupportedException();
        }

        protected override Expression VisitNewArray(NewArrayExpression node)
        {
            throw new NotSupportedException();
        }

        protected override Expression VisitParameter(ParameterExpression node)
        {
            jsBuilder.Append(node.Name);
            return node;
        }

        protected override Expression VisitRuntimeVariables(RuntimeVariablesExpression node)
        {
            throw new NotSupportedException();
        }

        protected override Expression VisitSwitch(SwitchExpression node)
        {
            throw new NotSupportedException();
        }

        protected override SwitchCase VisitSwitchCase(SwitchCase node)
        {
            throw new NotSupportedException();
        }

        protected override Expression VisitTry(TryExpression node)
        {
            throw new NotSupportedException();
        }

        protected override Expression VisitTypeBinary(TypeBinaryExpression node)
        {
            throw new NotSupportedException();
        }

        protected override Expression VisitUnary(UnaryExpression node)
        {
            if (node.NodeType == ExpressionType.Convert)
            {
                // Nothing to convert
                base.Visit(node.Operand);
            }
            else
            {
                jsBuilder.Append(GetOperator(node.NodeType));
                //jsBuilder.Append("(");
                base.Visit(node.Operand);
                //jsBuilder.Append(")");
            }

            return node;
        }

        private static string GetOperator(ExpressionType type)
        {
            switch (type)
            {
                case ExpressionType.Equal:
                    return "===";
                case ExpressionType.Not:
                    return "!";
                case ExpressionType.NotEqual:
                    return "!==";
                case ExpressionType.GreaterThan:
                    return ">";
                case ExpressionType.GreaterThanOrEqual:
                    return ">=";
                case ExpressionType.LessThan:
                    return "<";
                case ExpressionType.LessThanOrEqual:
                    return "<=";
                case ExpressionType.Or:
                    return "|";
                case ExpressionType.OrElse:
                    return "||";
                case ExpressionType.And:
                    return "&";
                case ExpressionType.AndAlso:
                    return "&&";
                case ExpressionType.Add:
                    return "+";
                case ExpressionType.AddAssign:
                    return "+=";
                case ExpressionType.Subtract:
                    return "-";
                case ExpressionType.SubtractAssign:
                    return "-=";
                case ExpressionType.Divide:
                    return "/";
                case ExpressionType.Multiply:
                    return "*";
                case ExpressionType.Modulo:
                    return "%";
                default:
                    throw new NotSupportedException(type.ToString());
            }
        }
    }
}

