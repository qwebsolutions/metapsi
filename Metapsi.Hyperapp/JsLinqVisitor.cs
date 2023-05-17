using System.Linq;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using Microsoft.CSharp.RuntimeBinder;

namespace Metapsi.Hyperapp
{
    public static class JsLinq
    {
        public static string Convert(Expression expression)
        {
            var jsLinqVisitor = new JsLinqVisitor();
            var jsExpression = jsLinqVisitor.Visit(expression);

            string methodBody = jsExpression.ToString().Replace("from(", "Enumerable.from(");

            foreach (string indexArg in jsLinqVisitor.IndexeArguments)
            {
                methodBody = methodBody.Replace($".get_Item({indexArg})", $"[{indexArg}]");
            }

            foreach (string calledMethod in jsLinqVisitor.LinqFunctions)
            {
                string lowerCall = calledMethod.Substring(0, 1).ToLower() + calledMethod.Substring(1);
                methodBody = methodBody.Replace(calledMethod + "(", lowerCall + "(");
            }

            foreach (var closure in jsLinqVisitor.Closures)
            {
                methodBody = methodBody.Replace(closure.Key, closure.Value);
            }

            foreach (var invocation in jsLinqVisitor.Invocations)
            {
                methodBody = methodBody.Replace(invocation.Key, invocation.Value);
            }

            foreach (string constructor in jsLinqVisitor.Constructors)
            {
                // Loop in case same constructor is called multiple times
                while (true)
                {
                    var startsAt = methodBody.IndexOf(constructor);

                    if (startsAt < 0)
                        break;

                    var initializerStart = startsAt + constructor.Length + 1;
                    var hasInitializer = methodBody[initializerStart] == '{';
                    if (hasInitializer)
                    {
                        var endOfInitializer = methodBody.IndexOf('}', initializerStart + 1);
                        var setters = methodBody.Substring(initializerStart, endOfInitializer - initializerStart + 1);
                        methodBody = methodBody.Replace(setters, "(" + setters.Replace(" = ", " : ") + ")"); // because => { ... } is a block statement, not an object literal
                    }
                    methodBody = methodBody.Remove(startsAt, constructor.Length + 1); // There's an extra space
                }
            }

            methodBody = methodBody.Replace(".ToString()", string.Empty);

            methodBody = methodBody.Replace("True", "true");
            methodBody = methodBody.Replace("False", "false");
            methodBody = methodBody.Replace("==", "===");
            methodBody = methodBody.Replace("Not(", "!(");
            methodBody = methodBody.Replace("AndAlso", "&&");
            methodBody = methodBody.Replace(".call(", "(");
            methodBody = methodBody.Replace("IIF", "((c, v1, v2) => c?v1:v2)");
            methodBody = methodBody.Replace("OrElse", "||");

            while (true)
            {
                var convertStart = methodBody.IndexOf("Convert(");

                if (convertStart == -1)
                    break;

                var convertEnd = methodBody.IndexOf(")", convertStart + 1);
                var convertCall = methodBody.Substring(convertStart, (convertEnd - convertStart) + 1);

                var convertParam = convertCall.Replace("Convert(", string.Empty).Split(",").First();

                methodBody = methodBody.Replace(convertCall, convertParam);
            }

            methodBody = methodBody.Replace("toList()", "toArray()");

            return methodBody;
        }
    }

    public class JsLinqVisitor : ExpressionVisitor
    {
        public HashSet<string> LinqFunctions { get; set; } = new HashSet<string>();
        public HashSet<string> IndexeArguments { get; set; } = new();
        public Dictionary<string, string> Closures { get; set; } = new Dictionary<string, string>();
        public HashSet<string> Constructors { get; set; } = new HashSet<string>();
        public Dictionary<string, string> Invocations { get; set; } = new Dictionary<string, string>();

        protected override Expression VisitMember(MemberExpression node)
        {
            if (node.Expression.NodeType == ExpressionType.Constant)
            {
                ConstantExpression closure = node.Expression as ConstantExpression;
                var closureField = ((System.Reflection.FieldInfo)node.Member).GetValue(closure.Value);
                if (!(closureField is Syntax.IVariable))
                {
                    throw new NotSupportedException($"Acess to type {closureField.GetType().Name} is not allowed inside client-side Linq expressions. Make sure to declare all variables outside of the expression");
                }

                Syntax.IVariable boundVar = closureField as Syntax.IVariable;

                Closures[node.ToString()] = boundVar.Name;
            }

            return base.VisitMember(node);
        }

        protected override Expression VisitLambda<T>(Expression<T> node)
        {
            //Console.WriteLine(node.Body.NodeType);
            //Console.WriteLine(node.NodeType);
            //Console.WriteLine(node.ToString());
            //Console.WriteLine();
            return base.VisitLambda(node);
        }

        protected override Expression VisitInvocation(InvocationExpression node)
        {
            var methodName = node.Expression.ToString();
            var arguments = node.Arguments.Select(x => x.ToString());
            string replacement = $"{methodName}({string.Join(", ", arguments)})";
            //Console.WriteLine(node);
            Invocations.Add(node.ToString(), replacement);
            return base.VisitInvocation(node);
        }

        protected override Expression VisitMethodCall(MethodCallExpression node)
        {
            if (node.Arguments.Count < 1)
                return base.VisitMethodCall(node);

            LinqFunctions.Add(node.Method.Name);
            if (node.Method.Name.ToLower() == "get_item")
            {
                IndexeArguments.Add(node.Arguments.Single().ToString());
            }

            if (node.Arguments[0].Type.IsAssignableTo(typeof(System.Collections.IEnumerable)))
            {
                var thisArg = node.Arguments[0];

                Type t = thisArg.Type.GenericTypeArguments.FirstOrDefault();

                if (t != null)
                {
                    var arguments = new List<Expression>();

                    var toEnumerableCall = Expression.Call(typeof(Enumerable), nameof(Enumerable.from), new[] { thisArg.Type }, Visit(thisArg));
                    arguments.Add(toEnumerableCall);
                    arguments.AddRange(node.Arguments.Skip(1).Select(x => Visit(x)));
                    var wrapped = Expression.Call(node.Method, arguments);
                    return wrapped;
                }
            }
            return base.VisitMethodCall(node);
        }

        protected override ElementInit VisitElementInit(ElementInit node)
        {
            return base.VisitElementInit(node);
        }

        protected override Expression VisitMemberInit(MemberInitExpression node)
        {
            Constructors.Add(node.NewExpression.ToString());
            return base.VisitMemberInit(node);
        }

        protected override Expression VisitIndex(IndexExpression node)
        {
            return base.VisitIndex(node);
        }
    }

    public static class Enumerable
    {
        public static TCol from<TCol>(TCol source)
        {
            throw new NotSupportedException("This cannot actually be called, it's just a JS signature");
        }
    }
}

