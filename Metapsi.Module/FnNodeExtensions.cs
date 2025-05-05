using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Reflection;

namespace Metapsi.Syntax
{

    public static class FnNodeExtensions
    {
        /// <summary>
        /// Creates a FnNode based on a SyntaxBuilder delegate. 
        /// The node is returned as it is, not added to the parent.
        /// </summary>
        /// <param name="b">Parent builder</param>
        /// <param name="fn"></param>
        /// <returns></returns>
        internal static FnNode FromDelegate(SyntaxBuilder b, Delegate fn)
        {
            List<IVariable> parameters =
                    fn.Method.GetParameters().
                    Skip(1).
                    Select(x => Activator.CreateInstance(x.ParameterType, new object[] { x.Name }) as IVariable)
                    .ToList();

            var delegateBuilder = Activator.CreateInstance(fn.GetType().GenericTypeArguments.First(), b);
            List<object> arguments = new List<object> { delegateBuilder };
            arguments.AddRange(parameters);

            var result = fn.DynamicInvoke(arguments.ToArray());

            FnNode fnNode = new FnNode()
            {
                Body = (delegateBuilder as SyntaxBuilder).nodes,
                Parameters = parameters.Select(x => x.Name).ToList(),
            };

            if (result != null)
            {
                fnNode.Return = (result as IVariable).Name;
            }

            return fnNode;
        }

        private static Var<T> AddFunction<T>(SyntaxBuilder b, Delegate fn)
            where T : Delegate
        {
            // Is static, add it to module. This is important to minimize infinite recursion incidents
            if (fn.Target == null)
            {
                return b.moduleBuilder.AddFunction<T>(fn, ModuleBuilder.QualifiedName(fn.Method));
            }
            else
            {
                var assignmentNode = new AssignmentNode()
                {
                    Name = b.NewVarName(),
                    Node = FromDelegate(b, fn)
                };
                b.nodes.Add(assignmentNode);
                return new Var<T>(assignmentNode.Name);
            }
        }


        // Define global actions
        public static Var<Action> Def<TSyntaxBuilder>(this SyntaxBuilder b, string name, Action<TSyntaxBuilder> builder)
            where TSyntaxBuilder : SyntaxBuilder
        {
            return b.moduleBuilder.AddFunction<Action>(builder, name);
        }

        public static Var<Action<P1>> Def<TSyntaxBuilder, P1>(this SyntaxBuilder b, string name, Action<TSyntaxBuilder, Var<P1>> builder)
            where TSyntaxBuilder : SyntaxBuilder
        {
            return b.moduleBuilder.AddFunction<Action<P1>>(builder, name);
        }

        public static Var<Action<P1, P2>> Def<TSyntaxBuilder, P1, P2>(this SyntaxBuilder b, string name, Action<TSyntaxBuilder, Var<P1>, Var<P2>> builder)
            where TSyntaxBuilder : SyntaxBuilder
        {
            return b.moduleBuilder.AddFunction<Action<P1, P2>>(builder, name);
        }

        public static Var<Action<P1, P2, P3>> Def<TSyntaxBuilder, P1, P2, P3>(this SyntaxBuilder b, string name, Action<TSyntaxBuilder, Var<P1>, Var<P2>, Var<P3>> builder)
            where TSyntaxBuilder : SyntaxBuilder
        {
            return b.moduleBuilder.AddFunction<Action<P1, P2, P3>>(builder, name);
        }

        public static Var<Action<P1, P2, P3, P4>> Def<TSyntaxBuilder, P1, P2, P3, P4>(this SyntaxBuilder b, string name, Action<TSyntaxBuilder, Var<P1>, Var<P2>, Var<P3>, Var<P4>> builder)
            where TSyntaxBuilder : SyntaxBuilder
        {
            return b.moduleBuilder.AddFunction<Action<P1, P2, P3, P4>>(builder, name);
        }

        public static Var<Action<P1, P2, P3, P4, P5>> Def<TSyntaxBuilder, P1, P2, P3, P4, P5>(this SyntaxBuilder b, string name, Action<TSyntaxBuilder, Var<P1>, Var<P2>, Var<P3>, Var<P4>, Var<P5>> builder)
            where TSyntaxBuilder : SyntaxBuilder
        {
            return b.moduleBuilder.AddFunction<Action<P1, P2, P3, P4, P5>>(builder, name);
        }

        public static Var<Action<P1, P2, P3, P4, P5, P6>> Def<TSyntaxBuilder, P1, P2, P3, P4, P5, P6>(this SyntaxBuilder b, string name, Action<TSyntaxBuilder, Var<P1>, Var<P2>, Var<P3>, Var<P4>, Var<P5>, Var<P6>> builder)
            where TSyntaxBuilder : SyntaxBuilder
        {
            return b.moduleBuilder.AddFunction<Action<P1, P2, P3, P4, P5, P6>>(builder, name);
        }

        public static Var<Action<P1, P2, P3, P4, P5, P6, P7>> Def<TSyntaxBuilder, P1, P2, P3, P4, P5, P6, P7>(this SyntaxBuilder b, string name, Action<TSyntaxBuilder, Var<P1>, Var<P2>, Var<P3>, Var<P4>, Var<P5>, Var<P6>, Var<P7>> builder)
            where TSyntaxBuilder : SyntaxBuilder
        {
            return b.moduleBuilder.AddFunction<Action<P1, P2, P3, P4, P5, P6, P7>>(builder, name);
        }

        public static Var<Action<P1, P2, P3, P4, P5, P6, P7, P8>> Def<TSyntaxBuilder, P1, P2, P3, P4, P5, P6, P7, P8>(this SyntaxBuilder b, string name, Action<TSyntaxBuilder, Var<P1>, Var<P2>, Var<P3>, Var<P4>, Var<P5>, Var<P6>, Var<P7>, Var<P8>> builder)
            where TSyntaxBuilder : SyntaxBuilder
        {
            return b.moduleBuilder.AddFunction<Action<P1, P2, P3, P4, P5, P6, P7, P8>>(builder, name);
        }

        // Define actions
        public static Var<Action> Def<TSyntaxBuilder>(this SyntaxBuilder b, Action<TSyntaxBuilder> builder)
            where TSyntaxBuilder : SyntaxBuilder
        {
            return AddFunction<Action>(b, builder);
        }

        public static Var<Action<P1>> Def<TSyntaxBuilder, P1>(this SyntaxBuilder b, Action<TSyntaxBuilder, Var<P1>> builder)
            where TSyntaxBuilder : SyntaxBuilder
        {
            return AddFunction<Action<P1>>(b, builder);
        }

        public static Var<Action<P1, P2>> Def<TSyntaxBuilder, P1, P2>(this SyntaxBuilder b, Action<TSyntaxBuilder, Var<P1>, Var<P2>> builder)
            where TSyntaxBuilder : SyntaxBuilder
        {
            return AddFunction<Action<P1, P2>>(b, builder);
        }

        public static Var<Action<P1, P2, P3>> Def<TSyntaxBuilder, P1, P2, P3>(this SyntaxBuilder b, Action<TSyntaxBuilder, Var<P1>, Var<P2>, Var<P3>> builder)
            where TSyntaxBuilder : SyntaxBuilder
        {
            return AddFunction<Action<P1, P2, P3>>(b, builder);
        }

        public static Var<Action<P1, P2, P3, P4>> Def<TSyntaxBuilder, P1, P2, P3, P4>(this SyntaxBuilder b, Action<TSyntaxBuilder, Var<P1>, Var<P2>, Var<P3>, Var<P4>> builder)
            where TSyntaxBuilder : SyntaxBuilder
        {
            return AddFunction<Action<P1, P2, P3, P4>>(b, builder);
        }

        public static Var<Action<P1, P2, P3, P4, P5>> Def<TSyntaxBuilder, P1, P2, P3, P4, P5>(this SyntaxBuilder b, Action<TSyntaxBuilder, Var<P1>, Var<P2>, Var<P3>, Var<P4>, Var<P5>> builder)
            where TSyntaxBuilder : SyntaxBuilder
        {
            return AddFunction<Action<P1, P2, P3, P4, P5>>(b, builder);
        }

        public static Var<Action<P1, P2, P3, P4, P5, P6>> Def<TSyntaxBuilder, P1, P2, P3, P4, P5, P6>(this SyntaxBuilder b, Action<TSyntaxBuilder, Var<P1>, Var<P2>, Var<P3>, Var<P4>, Var<P5>, Var<P6>> builder)
            where TSyntaxBuilder : SyntaxBuilder
        {
            return AddFunction<Action<P1, P2, P3, P4, P5, P6>>(b, builder);
        }

        public static Var<Action<P1, P2, P3, P4, P5, P6, P7>> Def<TSyntaxBuilder, P1, P2, P3, P4, P5, P6, P7>(this SyntaxBuilder b, Action<TSyntaxBuilder, Var<P1>, Var<P2>, Var<P3>, Var<P4>, Var<P5>, Var<P6>, Var<P7>> builder)
            where TSyntaxBuilder : SyntaxBuilder
        {
            return AddFunction<Action<P1, P2, P3, P4, P5, P6, P7>>(b, builder);
        }

        public static Var<Action<P1, P2, P3, P4, P5, P6, P7, P8>> Def<TSyntaxBuilder, P1, P2, P3, P4, P5, P6, P7, P8>(this SyntaxBuilder b, Action<TSyntaxBuilder, Var<P1>, Var<P2>, Var<P3>, Var<P4>, Var<P5>, Var<P6>, Var<P7>, Var<P8>> builder)
            where TSyntaxBuilder : SyntaxBuilder
        {
            return AddFunction<Action<P1, P2, P3, P4, P5, P6, P7, P8>>(b, builder);
        }

        // Define global functions

        public static Var<Func<TOut>> Def<TSyntaxBuilder, TOut>(this SyntaxBuilder b, string name, Func<TSyntaxBuilder, Var<TOut>> builder)
            where TSyntaxBuilder : SyntaxBuilder
        {
            return b.moduleBuilder.AddFunction<Func<TOut>>(builder, name);
        }

        public static Var<Func<P1, TOut>> Def<TSyntaxBuilder, P1, TOut>(this SyntaxBuilder b, string name, Func<TSyntaxBuilder, Var<P1>, Var<TOut>> builder)
            where TSyntaxBuilder : SyntaxBuilder
        {
            return b.moduleBuilder.AddFunction<Func<P1, TOut>>(builder, name);
        }

        public static Var<Func<P1, P2, TOut>> Def<TSyntaxBuilder, P1, P2, TOut>(this SyntaxBuilder b, string name, Func<TSyntaxBuilder, Var<P1>, Var<P2>, Var<TOut>> builder)
            where TSyntaxBuilder : SyntaxBuilder
        {
            return b.moduleBuilder.AddFunction<Func<P1, P2, TOut>>(builder, name);
        }

        public static Var<Func<P1, P2, P3, TOut>> Def<TSyntaxBuilder, P1, P2, P3, TOut>(this SyntaxBuilder b, string name, Func<TSyntaxBuilder, Var<P1>, Var<P2>, Var<P3>, Var<TOut>> builder)
            where TSyntaxBuilder : SyntaxBuilder
        {
            return b.moduleBuilder.AddFunction<Func<P1, P2, P3, TOut>>(builder, name);
        }

        public static Var<Func<P1, P2, P3, P4, TOut>> Def<TSyntaxBuilder, P1, P2, P3, P4, TOut>(this SyntaxBuilder b, string name, Func<TSyntaxBuilder, Var<P1>, Var<P2>, Var<P3>, Var<P4>, Var<TOut>> builder)
            where TSyntaxBuilder : SyntaxBuilder
        {
            return b.moduleBuilder.AddFunction<Func<P1, P2, P3, P4, TOut>>(builder, name);
        }

        public static Var<Func<P1, P2, P3, P4, P5, TOut>> Def<TSyntaxBuilder, P1, P2, P3, P4, P5, TOut>(this SyntaxBuilder b, string name, Func<TSyntaxBuilder, Var<P1>, Var<P2>, Var<P3>, Var<P4>, Var<P5>, Var<TOut>> builder)
            where TSyntaxBuilder : SyntaxBuilder
        {
            return b.moduleBuilder.AddFunction<Func<P1, P2, P3, P4, P5, TOut>>(builder, name);
        }

        public static Var<Func<P1, P2, P3, P4, P5, P6, TOut>> Def<TSyntaxBuilder, P1, P2, P3, P4, P5, P6, TOut>(this SyntaxBuilder b, string name, Func<TSyntaxBuilder, Var<P1>, Var<P2>, Var<P3>, Var<P4>, Var<P5>, Var<P6>, Var<TOut>> builder)
            where TSyntaxBuilder : SyntaxBuilder
        {
            return b.moduleBuilder.AddFunction<Func<P1, P2, P3, P4, P5, P6, TOut>>(builder, name);
        }

        public static Var<Func<P1, P2, P3, P4, P5, P6, P7, TOut>> Def<TSyntaxBuilder, P1, P2, P3, P4, P5, P6, P7, TOut>(this SyntaxBuilder b, string name, Func<TSyntaxBuilder, Var<P1>, Var<P2>, Var<P3>, Var<P4>, Var<P5>, Var<P6>, Var<P7>, Var<TOut>> builder)
            where TSyntaxBuilder : SyntaxBuilder
        {
            return b.moduleBuilder.AddFunction<Func<P1, P2, P3, P4, P5, P6, P7, TOut>>(builder, name);
        }

        public static Var<Func<P1, P2, P3, P4, P5, P6, P7, P8, TOut>> Def<TSyntaxBuilder, P1, P2, P3, P4, P5, P6, P7, P8, TOut>(this SyntaxBuilder b, string name, Func<TSyntaxBuilder, Var<P1>, Var<P2>, Var<P3>, Var<P4>, Var<P5>, Var<P6>, Var<P7>, Var<P8>, Var<TOut>> builder)
            where TSyntaxBuilder : SyntaxBuilder
        {
            return b.moduleBuilder.AddFunction<Func<P1, P2, P3, P4, P5, P6, P7, P8, TOut>>(builder, name);
        }

        // Define functions

        public static Var<Func<TOut>> Def<TSyntaxBuilder, TOut>(this SyntaxBuilder b, Func<TSyntaxBuilder, Var<TOut>> builder)
            where TSyntaxBuilder : SyntaxBuilder
        {
            return AddFunction<Func<TOut>>(b, builder);
        }

        public static Var<Func<P1, TOut>> Def<TSyntaxBuilder, P1, TOut>(this SyntaxBuilder b, Func<TSyntaxBuilder, Var<P1>, Var<TOut>> builder)
            where TSyntaxBuilder : SyntaxBuilder
        {
            return AddFunction<Func<P1, TOut>>(b, builder);
        }

        public static Var<Func<P1, P2, TOut>> Def<TSyntaxBuilder, P1, P2, TOut>(this SyntaxBuilder b, Func<TSyntaxBuilder, Var<P1>, Var<P2>, Var<TOut>> builder)
            where TSyntaxBuilder : SyntaxBuilder
        {
            return AddFunction<Func<P1, P2, TOut>>(b, builder);
        }

        public static Var<Func<P1, P2, P3, TOut>> Def<TSyntaxBuilder, P1, P2, P3, TOut>(this SyntaxBuilder b, Func<TSyntaxBuilder, Var<P1>, Var<P2>, Var<P3>, Var<TOut>> builder)
            where TSyntaxBuilder : SyntaxBuilder
        {
            return AddFunction<Func<P1, P2, P3, TOut>>(b, builder);
        }

        public static Var<Func<P1, P2, P3, P4, TOut>> Def<TSyntaxBuilder, P1, P2, P3, P4, TOut>(this SyntaxBuilder b, Func<TSyntaxBuilder, Var<P1>, Var<P2>, Var<P3>, Var<P4>, Var<TOut>> builder)
            where TSyntaxBuilder : SyntaxBuilder
        {
            return AddFunction<Func<P1, P2, P3, P4, TOut>>(b, builder);
        }

        public static Var<Func<P1, P2, P3, P4, P5, TOut>> Def<TSyntaxBuilder, P1, P2, P3, P4, P5, TOut>(this SyntaxBuilder b, Func<TSyntaxBuilder, Var<P1>, Var<P2>, Var<P3>, Var<P4>, Var<P5>, Var<TOut>> builder)
            where TSyntaxBuilder : SyntaxBuilder
        {
            return AddFunction<Func<P1, P2, P3, P4, P5, TOut>>(b, builder);
        }

        public static Var<Func<P1, P2, P3, P4, P5, P6, TOut>> Def<TSyntaxBuilder, P1, P2, P3, P4, P5, P6, TOut>(this SyntaxBuilder b, Func<TSyntaxBuilder, Var<P1>, Var<P2>, Var<P3>, Var<P4>, Var<P5>, Var<P6>, Var<TOut>> builder)
            where TSyntaxBuilder : SyntaxBuilder
        {
            return AddFunction<Func<P1, P2, P3, P4, P5, P6, TOut>>(b, builder);
        }

        public static Var<Func<P1, P2, P3, P4, P5, P6, P7, TOut>> Def<TSyntaxBuilder, P1, P2, P3, P4, P5, P6, P7, TOut>(this SyntaxBuilder b, Func<TSyntaxBuilder, Var<P1>, Var<P2>, Var<P3>, Var<P4>, Var<P5>, Var<P6>, Var<P7>, Var<TOut>> builder)
            where TSyntaxBuilder : SyntaxBuilder
        {
            return AddFunction<Func<P1, P2, P3, P4, P5, P6, P7, TOut>>(b, builder);
        }

        public static Var<Func<P1, P2, P3, P4, P5, P6, P7, P8, TOut>> Def<TSyntaxBuilder, P1, P2, P3, P4, P5, P6, P7, P8, TOut>(this SyntaxBuilder b, Func<TSyntaxBuilder, Var<P1>, Var<P2>, Var<P3>, Var<P4>, Var<P5>, Var<P6>, Var<P7>, Var<P8>, Var<TOut>> builder)
            where TSyntaxBuilder : SyntaxBuilder
        {
            return AddFunction<Func<P1, P2, P3, P4, P5, P6, P7, P8, TOut>>(b, builder);
        }

        // Call actions

        public static void Call(this SyntaxBuilder b, Var<Action> action)
        {
            b.CallDynamic(action.As<Delegate>());
        }

        public static void Call<P1>(this SyntaxBuilder b, Var<Action<P1>> action, Var<P1> p1)
        {
            b.CallDynamic(action.As<Delegate>(), p1);
        }

        public static void Call<P1, P2>(this SyntaxBuilder b, Var<Action<P1, P2>> action, Var<P1> p1, Var<P2> p2)
        {
            b.CallDynamic(action.As<Delegate>(), p1, p2);
        }

        public static void Call<P1, P2, P3>(this SyntaxBuilder b, Var<Action<P1, P2, P3>> action, Var<P1> p1, Var<P2> p2, Var<P3> p3)
        {
            b.CallDynamic(action.As<Delegate>(), p1, p2, p3);
        }

        public static void Call<P1, P2, P3, P4>(this SyntaxBuilder b, Var<Action<P1, P2, P3, P4>> action, Var<P1> p1, Var<P2> p2, Var<P3> p3, Var<P4> p4)
        {
            b.CallDynamic(action.As<Delegate>(), p1, p2, p3, p4);
        }

        public static void Call<P1, P2, P3, P4, P5>(this SyntaxBuilder b, Var<Action<P1, P2, P3, P4, P5>> action, Var<P1> p1, Var<P2> p2, Var<P3> p3, Var<P4> p4, Var<P5> p5)
        {
            b.CallDynamic(action.As<Delegate>(), p1, p2, p3, p4, p5);
        }

        public static void Call<P1, P2, P3, P4, P5, P6>(this SyntaxBuilder b, Var<Action<P1, P2, P3, P4, P5, P6>> action, Var<P1> p1, Var<P2> p2, Var<P3> p3, Var<P4> p4, Var<P5> p5, Var<P6> p6)
        {
            b.CallDynamic(action.As<Delegate>(), p1, p2, p3, p4, p5, p6);
        }

        public static void Call<P1, P2, P3, P4, P5, P6, P7>(this SyntaxBuilder b, Var<Action<P1, P2, P3, P4, P5, P6, P7>> action, Var<P1> p1, Var<P2> p2, Var<P3> p3, Var<P4> p4, Var<P5> p5, Var<P6> p6, Var<P7> p7)
        {
            b.CallDynamic(action.As<Delegate>(), p1, p2, p3, p4, p5, p6, p7);
        }

        public static void Call<P1, P2, P3, P4, P5, P6, P7, P8>(this SyntaxBuilder b, Var<Action<P1, P2, P3, P4, P5, P6, P7, P8>> action, Var<P1> p1, Var<P2> p2, Var<P3> p3, Var<P4> p4, Var<P5> p5, Var<P6> p6, Var<P7> p7, Var<P8> p8)
        {
            b.CallDynamic(action.As<Delegate>(), p1, p2, p3, p4, p5, p6, p7, p8);
        }

        // Call functions

        public static Var<TOut> Call<TOut>(this SyntaxBuilder b, Var<Func<TOut>> func)
        {
            return b.CallDynamic<TOut>(func.As<Delegate>());
        }

        public static Var<TOut> Call<P1, TOut>(this SyntaxBuilder b, Var<Func<P1, TOut>> func, Var<P1> p1)
        {
            return b.CallDynamic<TOut>(func.As<Delegate>(), p1);
        }

        public static Var<TOut> Call<P1, P2, TOut>(this SyntaxBuilder b, Var<Func<P1, P2, TOut>> func, Var<P1> p1, Var<P2> p2)
        {
            return b.CallDynamic<TOut>(func.As<Delegate>(), p1, p2);
        }

        public static Var<TOut> Call<P1, P2, P3, TOut>(this SyntaxBuilder b, Var<Func<P1, P2, P3, TOut>> func, Var<P1> p1, Var<P2> p2, Var<P3> p3)
        {
            return b.CallDynamic<TOut>(func.As<Delegate>(), p1, p2, p3);
        }

        public static Var<TOut> Call<P1, P2, P3, P4, TOut>(this SyntaxBuilder b, Var<Func<P1, P2, P3, P4, TOut>> func, Var<P1> p1, Var<P2> p2, Var<P3> p3, Var<P4> p4)
        {
            return b.CallDynamic<TOut>(func.As<Delegate>(), p1, p2, p3, p4);
        }

        public static Var<TOut> Call<P1, P2, P3, P4, P5, TOut>(this SyntaxBuilder b, Var<Func<P1, P2, P3, P4, P5, TOut>> func, Var<P1> p1, Var<P2> p2, Var<P3> p3, Var<P4> p4, Var<P5> p5)
        {
            return b.CallDynamic<TOut>(func.As<Delegate>(), p1, p2, p3, p4, p5);
        }

        public static Var<TOut> Call<P1, P2, P3, P4, P5, P6, TOut>(this SyntaxBuilder b, Var<Func<P1, P2, P3, P4, P5, P6, TOut>> func, Var<P1> p1, Var<P2> p2, Var<P3> p3, Var<P4> p4, Var<P5> p5, Var<P6> p6)
        {
            return b.CallDynamic<TOut>(func.As<Delegate>(), p1, p2, p3, p4, p5, p6);
        }

        public static Var<TOut> Call<P1, P2, P3, P4, P5, P6, P7, TOut>(this SyntaxBuilder b, Var<Func<P1, P2, P3, P4, P5, P6, P7, TOut>> func, Var<P1> p1, Var<P2> p2, Var<P3> p3, Var<P4> p4, Var<P5> p5, Var<P6> p6, Var<P7> p7)
        {
            return b.CallDynamic<TOut>(func.As<Delegate>(), p1, p2, p3, p4, p5, p6, p7);
        }

        public static Var<TOut> Call<P1, P2, P3, P4, P5, P6, P7, P8, TOut>(this SyntaxBuilder b, Var<Func<P1, P2, P3, P4, P5, P6, P7, P8, TOut>> func, Var<P1> p1, Var<P2> p2, Var<P3> p3, Var<P4> p4, Var<P5> p5, Var<P6> p6, Var<P7> p7, Var<P8> p8)
        {
            return b.CallDynamic<TOut>(func.As<Delegate>(), p1, p2, p3, p4, p5, p6, p7, p8);
        }

        // Define & call actions

        public static void Call<TSyntaxBuilder>(this SyntaxBuilder b, Action<TSyntaxBuilder> action)
            where TSyntaxBuilder : SyntaxBuilder
        {
            b.Call(b.Def(action));
        }

        public static void Call<TSyntaxBuilder, P1>(this TSyntaxBuilder b, Action<TSyntaxBuilder, Var<P1>> action, Var<P1> p1)
            where TSyntaxBuilder : SyntaxBuilder
        {
            b.Call(b.Def(action), p1);
        }

        public static void Call<TSyntaxBuilder, P1, P2>(this TSyntaxBuilder b, Action<TSyntaxBuilder, Var<P1>, Var<P2>> action, Var<P1> p1, Var<P2> p2)
            where TSyntaxBuilder : SyntaxBuilder
        {
            b.Call(b.Def(action), p1, p2);
        }

        public static void Call<TSyntaxBuilder, P1, P2, P3>(this TSyntaxBuilder b, Action<TSyntaxBuilder, Var<P1>, Var<P2>, Var<P3>> action, Var<P1> p1, Var<P2> p2, Var<P3> p3)
            where TSyntaxBuilder : SyntaxBuilder
        {
            b.Call(b.Def(action), p1, p2, p3);
        }

        public static void Call<TSyntaxBuilder, P1, P2, P3, P4>(this TSyntaxBuilder b, Action<TSyntaxBuilder, Var<P1>, Var<P2>, Var<P3>, Var<P4>> action, Var<P1> p1, Var<P2> p2, Var<P3> p3, Var<P4> p4)
            where TSyntaxBuilder : SyntaxBuilder
        {
            b.Call(b.Def(action), p1, p2, p3, p4);
        }

        public static void Call<TSyntaxBuilder, P1, P2, P3, P4, P5>(this TSyntaxBuilder b, Action<TSyntaxBuilder, Var<P1>, Var<P2>, Var<P3>, Var<P4>, Var<P5>> action, Var<P1> p1, Var<P2> p2, Var<P3> p3, Var<P4> p4, Var<P5> p5)
            where TSyntaxBuilder : SyntaxBuilder
        {
            b.Call(b.Def(action), p1, p2, p3, p4, p5);
        }

        public static void Call<TSyntaxBuilder, P1, P2, P3, P4, P5, P6>(this TSyntaxBuilder b, Action<TSyntaxBuilder, Var<P1>, Var<P2>, Var<P3>, Var<P4>, Var<P5>, Var<P6>> action, Var<P1> p1, Var<P2> p2, Var<P3> p3, Var<P4> p4, Var<P5> p5, Var<P6> p6)
            where TSyntaxBuilder : SyntaxBuilder
        {
            b.Call(b.Def(action), p1, p2, p3, p4, p5, p6);
        }

        public static void Call<TSyntaxBuilder, P1, P2, P3, P4, P5, P6, P7>(this TSyntaxBuilder b, Action<TSyntaxBuilder, Var<P1>, Var<P2>, Var<P3>, Var<P4>, Var<P5>, Var<P6>, Var<P7>> action, Var<P1> p1, Var<P2> p2, Var<P3> p3, Var<P4> p4, Var<P5> p5, Var<P6> p6, Var<P7> p7)
            where TSyntaxBuilder : SyntaxBuilder
        {
            b.Call(b.Def(action), p1, p2, p3, p4, p5, p6, p7);
        }

        public static void Call<TSyntaxBuilder, P1, P2, P3, P4, P5, P6, P7, P8>(this TSyntaxBuilder b, Action<TSyntaxBuilder, Var<P1>, Var<P2>, Var<P3>, Var<P4>, Var<P5>, Var<P6>, Var<P7>, Var<P8>> action, Var<P1> p1, Var<P2> p2, Var<P3> p3, Var<P4> p4, Var<P5> p5, Var<P6> p6, Var<P7> p7, Var<P8> p8)
            where TSyntaxBuilder : SyntaxBuilder
        {
            b.Call(b.Def(action), p1, p2, p3, p4, p5, p6, p7, p8);
        }

        // Define & call functions

        public static Var<TOut> Call<TSyntaxBuilder, TOut>(this TSyntaxBuilder b, Func<TSyntaxBuilder, Var<TOut>> func)
            where TSyntaxBuilder : SyntaxBuilder
        {
            return b.Call(b.Def<TSyntaxBuilder, TOut>(func));
        }

        public static Var<TOut> Call<TSyntaxBuilder, P1, TOut>(this TSyntaxBuilder b, Func<TSyntaxBuilder, Var<P1>, Var<TOut>> func, Var<P1> p1)
            where TSyntaxBuilder : SyntaxBuilder
        {
            return b.Call(b.Def(func), p1);
        }

        public static Var<TOut> Call<TSyntaxBuilder, P1, P2, TOut>(this TSyntaxBuilder b, Func<TSyntaxBuilder, Var<P1>, Var<P2>, Var<TOut>> func, Var<P1> p1, Var<P2> p2)
            where TSyntaxBuilder : SyntaxBuilder
        {
            return b.Call(b.Def(func), p1, p2);
        }

        public static Var<TOut> Call<TSyntaxBuilder, P1, P2, P3, TOut>(this TSyntaxBuilder b, Func<TSyntaxBuilder, Var<P1>, Var<P2>, Var<P3>, Var<TOut>> func, Var<P1> p1, Var<P2> p2, Var<P3> p3)
            where TSyntaxBuilder : SyntaxBuilder
        {
            return b.Call(b.Def(func), p1, p2, p3);
        }

        public static Var<TOut> Call<TSyntaxBuilder, P1, P2, P3, P4, TOut>(this TSyntaxBuilder b, Func<TSyntaxBuilder, Var<P1>, Var<P2>, Var<P3>, Var<P4>, Var<TOut>> func, Var<P1> p1, Var<P2> p2, Var<P3> p3, Var<P4> p4)
            where TSyntaxBuilder : SyntaxBuilder
        {
            return b.Call(b.Def(func), p1, p2, p3, p4);
        }

        public static Var<TOut> Call<TSyntaxBuilder, P1, P2, P3, P4, P5, TOut>(this TSyntaxBuilder b, Func<TSyntaxBuilder, Var<P1>, Var<P2>, Var<P3>, Var<P4>, Var<P5>, Var<TOut>> func, Var<P1> p1, Var<P2> p2, Var<P3> p3, Var<P4> p4, Var<P5> p5)
            where TSyntaxBuilder : SyntaxBuilder
        {
            return b.Call(b.Def(func), p1, p2, p3, p4, p5);
        }

        public static Var<TOut> Call<TSyntaxBuilder, P1, P2, P3, P4, P5, P6, TOut>(this TSyntaxBuilder b, Func<TSyntaxBuilder, Var<P1>, Var<P2>, Var<P3>, Var<P4>, Var<P5>, Var<P6>, Var<TOut>> func, Var<P1> p1, Var<P2> p2, Var<P3> p3, Var<P4> p4, Var<P5> p5, Var<P6> p6)
            where TSyntaxBuilder : SyntaxBuilder
        {
            return b.Call(b.Def(func), p1, p2, p3, p4, p5, p6);
        }

        public static Var<TOut> Call<TSyntaxBuilder, P1, P2, P3, P4, P5, P6, P7, TOut>(this TSyntaxBuilder b, Func<TSyntaxBuilder, Var<P1>, Var<P2>, Var<P3>, Var<P4>, Var<P5>, Var<P6>, Var<P7>, Var<TOut>> func, Var<P1> p1, Var<P2> p2, Var<P3> p3, Var<P4> p4, Var<P5> p5, Var<P6> p6, Var<P7> p7)
            where TSyntaxBuilder : SyntaxBuilder
        {
            return b.Call(b.Def(func), p1, p2, p3, p4, p5, p6, p7);
        }

        public static Var<TOut> Call<TSyntaxBuilder, P1, P2, P3, P4, P5, P6, P7, P8, TOut>(this TSyntaxBuilder b, Func<TSyntaxBuilder, Var<P1>, Var<P2>, Var<P3>, Var<P4>, Var<P5>, Var<P6>, Var<P7>, Var<P8>, Var<TOut>> func, Var<P1> p1, Var<P2> p2, Var<P3> p3, Var<P4> p4, Var<P5> p5, Var<P6> p6, Var<P7> p7, Var<P8> p8)
            where TSyntaxBuilder : SyntaxBuilder
        {
            return b.Call(b.Def(func), p1, p2, p3, p4, p5, p6, p7, p8);
        }
    }
}