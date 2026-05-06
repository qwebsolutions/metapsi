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
        /// Creates a FnNode based on a ISyntaxBuilder delegate. 
        /// The node is returned as it is, not added to the parent.
        /// </summary>
        /// <param name="b">Parent builder</param>
        /// <param name="fn"></param>
        /// <returns></returns>
        internal static FnNode FromDelegate(ISyntaxBuilder b, Delegate fn)
        {
            List<IVariable> parameters =
                    fn.Method.GetParameters().
                    Skip(1).
                    Select(x => Activator.CreateInstance(x.ParameterType, new object[] { x.Name }) as IVariable)
                    .ToList();

            var genericTypeArguments = fn.GetType().GenericTypeArguments;
            Type delegateBuilderDeclaredType = genericTypeArguments.First();
            Type delegateBuilderInstanceType = null;

            object[] constructorArguments = null;

            if (delegateBuilderDeclaredType.IsInterface)
            {
                delegateBuilderInstanceType= b.GetType();
            }
            else
            {
                delegateBuilderInstanceType = delegateBuilderDeclaredType;
            }

            if (typeof(IObjBuilder).IsAssignableFrom(delegateBuilderInstanceType))
            {
                // Delegate builder uses encapsulated Var
                if (!(b is IObjBuilder))
                {
                    //throw new Exception("No encapsulated variable to pass along to delegate builder");
                    constructorArguments = new object[] { b.ModuleBuilder, b.NewObj<object>() };
                }
                else
                {
                    constructorArguments = new object[] { b.ModuleBuilder, (b as IVariable) };
                }
            }
            else
            {
                constructorArguments = new object[] { b.ModuleBuilder };
            }


            var delegateBuilder = Activator.CreateInstance(
                delegateBuilderInstanceType,
                BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public,
                binder: null,
                constructorArguments,
                culture: null);
            List<object> arguments = new List<object> { delegateBuilder };
            arguments.AddRange(parameters);

            var result = fn.DynamicInvoke(arguments.ToArray());

            FnNode fnNode = new FnNode()
            {
                Body = (delegateBuilder as ISyntaxBuilder).Nodes,
                Parameters = parameters.Select(x => x.Name).ToList(),
            };

            fnNode.AddDebugType(fn);

            if (result != null)
            {
                fnNode.Return = (result as IVariable).Name;
            }

            return fnNode;
        }

        private static Var<T> AddFunction<T>(ISyntaxBuilder b, Delegate fn)
            where T : Delegate
        {
            // Is static, add it to module. This is important to minimize infinite recursion incidents
            if (fn.Target == null)
            {
                return (b as ISyntaxBuilder).ModuleBuilder.AddFunction<T>(fn, ModuleBuilder.QualifiedName(fn.Method));
            }
            else
            {
                var assignmentNode = new AssignmentNode()
                {
                    Name = (b as ISyntaxBuilder).ModuleBuilder.NewName(),
                    Node = new SyntaxNode() { Fn = FromDelegate(b, fn) }
                };

                assignmentNode.AddDebugType(fn.Method.ReturnType);

                (b as ISyntaxBuilder).Nodes.Add(new SyntaxNode() { Assignment = assignmentNode });
                return new Var<T>(assignmentNode.Name)
                {
                    AssignmentNode = assignmentNode
                };
            }
        }


        // Define global actions
        public static Var<Action> Def<TSyntaxBuilder>(this ISyntaxBuilder b, string name, Action<TSyntaxBuilder> builder)
            where TSyntaxBuilder : ISyntaxBuilder
        {
            return (b as ISyntaxBuilder).ModuleBuilder.AddFunction<Action>(builder, name);
        }

        public static Var<Action<P1>> Def<TSyntaxBuilder, P1>(this ISyntaxBuilder b, string name, Action<TSyntaxBuilder, Var<P1>> builder)
            where TSyntaxBuilder : ISyntaxBuilder
        {
            return (b as ISyntaxBuilder).ModuleBuilder.AddFunction<Action<P1>>(builder, name);
        }

        public static Var<Action<P1, P2>> Def<TSyntaxBuilder, P1, P2>(this ISyntaxBuilder b, string name, Action<TSyntaxBuilder, Var<P1>, Var<P2>> builder)
            where TSyntaxBuilder : ISyntaxBuilder
        {
            return (b as ISyntaxBuilder).ModuleBuilder.AddFunction<Action<P1, P2>>(builder, name);
        }

        public static Var<Action<P1, P2, P3>> Def<TSyntaxBuilder, P1, P2, P3>(this ISyntaxBuilder b, string name, Action<TSyntaxBuilder, Var<P1>, Var<P2>, Var<P3>> builder)
            where TSyntaxBuilder : ISyntaxBuilder
        {
            return (b as ISyntaxBuilder).ModuleBuilder.AddFunction<Action<P1, P2, P3>>(builder, name);
        }

        public static Var<Action<P1, P2, P3, P4>> Def<TSyntaxBuilder, P1, P2, P3, P4>(this ISyntaxBuilder b, string name, Action<TSyntaxBuilder, Var<P1>, Var<P2>, Var<P3>, Var<P4>> builder)
            where TSyntaxBuilder : ISyntaxBuilder
        {
            return (b as ISyntaxBuilder).ModuleBuilder.AddFunction<Action<P1, P2, P3, P4>>(builder, name);
        }

        public static Var<Action<P1, P2, P3, P4, P5>> Def<TSyntaxBuilder, P1, P2, P3, P4, P5>(this ISyntaxBuilder b, string name, Action<TSyntaxBuilder, Var<P1>, Var<P2>, Var<P3>, Var<P4>, Var<P5>> builder)
            where TSyntaxBuilder : ISyntaxBuilder
        {
            return (b as ISyntaxBuilder).ModuleBuilder.AddFunction<Action<P1, P2, P3, P4, P5>>(builder, name);
        }

        public static Var<Action<P1, P2, P3, P4, P5, P6>> Def<TSyntaxBuilder, P1, P2, P3, P4, P5, P6>(this ISyntaxBuilder b, string name, Action<TSyntaxBuilder, Var<P1>, Var<P2>, Var<P3>, Var<P4>, Var<P5>, Var<P6>> builder)
            where TSyntaxBuilder : ISyntaxBuilder
        {
            return (b as ISyntaxBuilder).ModuleBuilder.AddFunction<Action<P1, P2, P3, P4, P5, P6>>(builder, name);
        }

        public static Var<Action<P1, P2, P3, P4, P5, P6, P7>> Def<TSyntaxBuilder, P1, P2, P3, P4, P5, P6, P7>(this ISyntaxBuilder b, string name, Action<TSyntaxBuilder, Var<P1>, Var<P2>, Var<P3>, Var<P4>, Var<P5>, Var<P6>, Var<P7>> builder)
            where TSyntaxBuilder : ISyntaxBuilder
        {
            return (b as ISyntaxBuilder).ModuleBuilder.AddFunction<Action<P1, P2, P3, P4, P5, P6, P7>>(builder, name);
        }

        public static Var<Action<P1, P2, P3, P4, P5, P6, P7, P8>> Def<TSyntaxBuilder, P1, P2, P3, P4, P5, P6, P7, P8>(this ISyntaxBuilder b, string name, Action<TSyntaxBuilder, Var<P1>, Var<P2>, Var<P3>, Var<P4>, Var<P5>, Var<P6>, Var<P7>, Var<P8>> builder)
            where TSyntaxBuilder : ISyntaxBuilder
        {
            return (b as ISyntaxBuilder).ModuleBuilder.AddFunction<Action<P1, P2, P3, P4, P5, P6, P7, P8>>(builder, name);
        }

        // Define actions
        public static Var<Action> Def<TSyntaxBuilder>(this ISyntaxBuilder b, Action<TSyntaxBuilder> builder)
            where TSyntaxBuilder : ISyntaxBuilder
        {
            return AddFunction<Action>(b, builder);
        }

        public static Var<Action<P1>> Def<TSyntaxBuilder, P1>(this ISyntaxBuilder b, Action<TSyntaxBuilder, Var<P1>> builder)
            where TSyntaxBuilder : ISyntaxBuilder
        {
            return AddFunction<Action<P1>>(b, builder);
        }

        public static Var<Action<P1, P2>> Def<TSyntaxBuilder, P1, P2>(this ISyntaxBuilder b, Action<TSyntaxBuilder, Var<P1>, Var<P2>> builder)
            where TSyntaxBuilder : ISyntaxBuilder
        {
            return AddFunction<Action<P1, P2>>(b, builder);
        }

        public static Var<Action<P1, P2, P3>> Def<TSyntaxBuilder, P1, P2, P3>(this ISyntaxBuilder b, Action<TSyntaxBuilder, Var<P1>, Var<P2>, Var<P3>> builder)
            where TSyntaxBuilder : ISyntaxBuilder
        {
            return AddFunction<Action<P1, P2, P3>>(b, builder);
        }

        public static Var<Action<P1, P2, P3, P4>> Def<TSyntaxBuilder, P1, P2, P3, P4>(this ISyntaxBuilder b, Action<TSyntaxBuilder, Var<P1>, Var<P2>, Var<P3>, Var<P4>> builder)
            where TSyntaxBuilder : ISyntaxBuilder
        {
            return AddFunction<Action<P1, P2, P3, P4>>(b, builder);
        }

        public static Var<Action<P1, P2, P3, P4, P5>> Def<TSyntaxBuilder, P1, P2, P3, P4, P5>(this ISyntaxBuilder b, Action<TSyntaxBuilder, Var<P1>, Var<P2>, Var<P3>, Var<P4>, Var<P5>> builder)
            where TSyntaxBuilder : ISyntaxBuilder
        {
            return AddFunction<Action<P1, P2, P3, P4, P5>>(b, builder);
        }

        public static Var<Action<P1, P2, P3, P4, P5, P6>> Def<TSyntaxBuilder, P1, P2, P3, P4, P5, P6>(this ISyntaxBuilder b, Action<TSyntaxBuilder, Var<P1>, Var<P2>, Var<P3>, Var<P4>, Var<P5>, Var<P6>> builder)
            where TSyntaxBuilder : ISyntaxBuilder
        {
            return AddFunction<Action<P1, P2, P3, P4, P5, P6>>(b, builder);
        }

        public static Var<Action<P1, P2, P3, P4, P5, P6, P7>> Def<TSyntaxBuilder, P1, P2, P3, P4, P5, P6, P7>(this ISyntaxBuilder b, Action<TSyntaxBuilder, Var<P1>, Var<P2>, Var<P3>, Var<P4>, Var<P5>, Var<P6>, Var<P7>> builder)
            where TSyntaxBuilder : ISyntaxBuilder
        {
            return AddFunction<Action<P1, P2, P3, P4, P5, P6, P7>>(b, builder);
        }

        public static Var<Action<P1, P2, P3, P4, P5, P6, P7, P8>> Def<TSyntaxBuilder, P1, P2, P3, P4, P5, P6, P7, P8>(this ISyntaxBuilder b, Action<TSyntaxBuilder, Var<P1>, Var<P2>, Var<P3>, Var<P4>, Var<P5>, Var<P6>, Var<P7>, Var<P8>> builder)
            where TSyntaxBuilder : ISyntaxBuilder
        {
            return AddFunction<Action<P1, P2, P3, P4, P5, P6, P7, P8>>(b, builder);
        }

        // Define global functions

        public static Var<Func<TOut>> Def<TSyntaxBuilder, TOut>(this ISyntaxBuilder b, string name, Func<TSyntaxBuilder, Var<TOut>> builder)
            where TSyntaxBuilder : ISyntaxBuilder
        {
            return (b as ISyntaxBuilder).ModuleBuilder.AddFunction<Func<TOut>>(builder, name);
        }

        public static Var<Func<P1, TOut>> Def<TSyntaxBuilder, P1, TOut>(this ISyntaxBuilder b, string name, Func<TSyntaxBuilder, Var<P1>, Var<TOut>> builder)
            where TSyntaxBuilder : ISyntaxBuilder
        {
            return (b as ISyntaxBuilder).ModuleBuilder.AddFunction<Func<P1, TOut>>(builder, name);
        }

        public static Var<Func<P1, P2, TOut>> Def<TSyntaxBuilder, P1, P2, TOut>(this ISyntaxBuilder b, string name, Func<TSyntaxBuilder, Var<P1>, Var<P2>, Var<TOut>> builder)
            where TSyntaxBuilder : ISyntaxBuilder
        {
            return (b as ISyntaxBuilder).ModuleBuilder.AddFunction<Func<P1, P2, TOut>>(builder, name);
        }

        public static Var<Func<P1, P2, P3, TOut>> Def<TSyntaxBuilder, P1, P2, P3, TOut>(this ISyntaxBuilder b, string name, Func<TSyntaxBuilder, Var<P1>, Var<P2>, Var<P3>, Var<TOut>> builder)
            where TSyntaxBuilder : ISyntaxBuilder
        {
            return (b as ISyntaxBuilder).ModuleBuilder.AddFunction<Func<P1, P2, P3, TOut>>(builder, name);
        }

        public static Var<Func<P1, P2, P3, P4, TOut>> Def<TSyntaxBuilder, P1, P2, P3, P4, TOut>(this ISyntaxBuilder b, string name, Func<TSyntaxBuilder, Var<P1>, Var<P2>, Var<P3>, Var<P4>, Var<TOut>> builder)
            where TSyntaxBuilder : ISyntaxBuilder
        {
            return (b as ISyntaxBuilder).ModuleBuilder.AddFunction<Func<P1, P2, P3, P4, TOut>>(builder, name);
        }

        public static Var<Func<P1, P2, P3, P4, P5, TOut>> Def<TSyntaxBuilder, P1, P2, P3, P4, P5, TOut>(this ISyntaxBuilder b, string name, Func<TSyntaxBuilder, Var<P1>, Var<P2>, Var<P3>, Var<P4>, Var<P5>, Var<TOut>> builder)
            where TSyntaxBuilder : ISyntaxBuilder
        {
            return (b as ISyntaxBuilder).ModuleBuilder.AddFunction<Func<P1, P2, P3, P4, P5, TOut>>(builder, name);
        }

        public static Var<Func<P1, P2, P3, P4, P5, P6, TOut>> Def<TSyntaxBuilder, P1, P2, P3, P4, P5, P6, TOut>(this ISyntaxBuilder b, string name, Func<TSyntaxBuilder, Var<P1>, Var<P2>, Var<P3>, Var<P4>, Var<P5>, Var<P6>, Var<TOut>> builder)
            where TSyntaxBuilder : ISyntaxBuilder
        {
            return (b as ISyntaxBuilder).ModuleBuilder.AddFunction<Func<P1, P2, P3, P4, P5, P6, TOut>>(builder, name);
        }

        public static Var<Func<P1, P2, P3, P4, P5, P6, P7, TOut>> Def<TSyntaxBuilder, P1, P2, P3, P4, P5, P6, P7, TOut>(this ISyntaxBuilder b, string name, Func<TSyntaxBuilder, Var<P1>, Var<P2>, Var<P3>, Var<P4>, Var<P5>, Var<P6>, Var<P7>, Var<TOut>> builder)
            where TSyntaxBuilder : ISyntaxBuilder
        {
            return (b as ISyntaxBuilder).ModuleBuilder.AddFunction<Func<P1, P2, P3, P4, P5, P6, P7, TOut>>(builder, name);
        }

        public static Var<Func<P1, P2, P3, P4, P5, P6, P7, P8, TOut>> Def<TSyntaxBuilder, P1, P2, P3, P4, P5, P6, P7, P8, TOut>(this ISyntaxBuilder b, string name, Func<TSyntaxBuilder, Var<P1>, Var<P2>, Var<P3>, Var<P4>, Var<P5>, Var<P6>, Var<P7>, Var<P8>, Var<TOut>> builder)
            where TSyntaxBuilder : ISyntaxBuilder
        {
            return (b as ISyntaxBuilder).ModuleBuilder.AddFunction<Func<P1, P2, P3, P4, P5, P6, P7, P8, TOut>>(builder, name);
        }

        // Define functions

        public static Var<Func<TOut>> Def<TSyntaxBuilder, TOut>(this ISyntaxBuilder b, Func<TSyntaxBuilder, Var<TOut>> builder)
            where TSyntaxBuilder : ISyntaxBuilder
        {
            return AddFunction<Func<TOut>>(b, builder);
        }

        public static Var<Func<P1, TOut>> Def<TSyntaxBuilder, P1, TOut>(this ISyntaxBuilder b, Func<TSyntaxBuilder, Var<P1>, Var<TOut>> builder)
            where TSyntaxBuilder : ISyntaxBuilder
        {
            return AddFunction<Func<P1, TOut>>(b, builder);
        }

        public static Var<Func<P1, P2, TOut>> Def<TSyntaxBuilder, P1, P2, TOut>(this ISyntaxBuilder b, Func<TSyntaxBuilder, Var<P1>, Var<P2>, Var<TOut>> builder)
            where TSyntaxBuilder : ISyntaxBuilder
        {
            return AddFunction<Func<P1, P2, TOut>>(b, builder);
        }

        public static Var<Func<P1, P2, P3, TOut>> Def<TSyntaxBuilder, P1, P2, P3, TOut>(this ISyntaxBuilder b, Func<TSyntaxBuilder, Var<P1>, Var<P2>, Var<P3>, Var<TOut>> builder)
            where TSyntaxBuilder : ISyntaxBuilder
        {
            return AddFunction<Func<P1, P2, P3, TOut>>(b, builder);
        }

        public static Var<Func<P1, P2, P3, P4, TOut>> Def<TSyntaxBuilder, P1, P2, P3, P4, TOut>(this ISyntaxBuilder b, Func<TSyntaxBuilder, Var<P1>, Var<P2>, Var<P3>, Var<P4>, Var<TOut>> builder)
            where TSyntaxBuilder : ISyntaxBuilder
        {
            return AddFunction<Func<P1, P2, P3, P4, TOut>>(b, builder);
        }

        public static Var<Func<P1, P2, P3, P4, P5, TOut>> Def<TSyntaxBuilder, P1, P2, P3, P4, P5, TOut>(this ISyntaxBuilder b, Func<TSyntaxBuilder, Var<P1>, Var<P2>, Var<P3>, Var<P4>, Var<P5>, Var<TOut>> builder)
            where TSyntaxBuilder : ISyntaxBuilder
        {
            return AddFunction<Func<P1, P2, P3, P4, P5, TOut>>(b, builder);
        }

        public static Var<Func<P1, P2, P3, P4, P5, P6, TOut>> Def<TSyntaxBuilder, P1, P2, P3, P4, P5, P6, TOut>(this ISyntaxBuilder b, Func<TSyntaxBuilder, Var<P1>, Var<P2>, Var<P3>, Var<P4>, Var<P5>, Var<P6>, Var<TOut>> builder)
            where TSyntaxBuilder : ISyntaxBuilder
        {
            return AddFunction<Func<P1, P2, P3, P4, P5, P6, TOut>>(b, builder);
        }

        public static Var<Func<P1, P2, P3, P4, P5, P6, P7, TOut>> Def<TSyntaxBuilder, P1, P2, P3, P4, P5, P6, P7, TOut>(this ISyntaxBuilder b, Func<TSyntaxBuilder, Var<P1>, Var<P2>, Var<P3>, Var<P4>, Var<P5>, Var<P6>, Var<P7>, Var<TOut>> builder)
            where TSyntaxBuilder : ISyntaxBuilder
        {
            return AddFunction<Func<P1, P2, P3, P4, P5, P6, P7, TOut>>(b, builder);
        }

        public static Var<Func<P1, P2, P3, P4, P5, P6, P7, P8, TOut>> Def<TSyntaxBuilder, P1, P2, P3, P4, P5, P6, P7, P8, TOut>(this ISyntaxBuilder b, Func<TSyntaxBuilder, Var<P1>, Var<P2>, Var<P3>, Var<P4>, Var<P5>, Var<P6>, Var<P7>, Var<P8>, Var<TOut>> builder)
            where TSyntaxBuilder : ISyntaxBuilder
        {
            return AddFunction<Func<P1, P2, P3, P4, P5, P6, P7, P8, TOut>>(b, builder);
        }

        // Call actions

        public static void Call(this ISyntaxBuilder b, Var<Action> action)
        {
            b.CallDynamic(action.As<Delegate>());
        }

        public static void Call<P1>(this ISyntaxBuilder b, Var<Action<P1>> action, Var<P1> p1)
        {
            b.CallDynamic(action.As<Delegate>(), p1);
        }

        public static void Call<P1, P2>(this ISyntaxBuilder b, Var<Action<P1, P2>> action, Var<P1> p1, Var<P2> p2)
        {
            b.CallDynamic(action.As<Delegate>(), p1, p2);
        }

        public static void Call<P1, P2, P3>(this ISyntaxBuilder b, Var<Action<P1, P2, P3>> action, Var<P1> p1, Var<P2> p2, Var<P3> p3)
        {
            b.CallDynamic(action.As<Delegate>(), p1, p2, p3);
        }

        public static void Call<P1, P2, P3, P4>(this ISyntaxBuilder b, Var<Action<P1, P2, P3, P4>> action, Var<P1> p1, Var<P2> p2, Var<P3> p3, Var<P4> p4)
        {
            b.CallDynamic(action.As<Delegate>(), p1, p2, p3, p4);
        }

        public static void Call<P1, P2, P3, P4, P5>(this ISyntaxBuilder b, Var<Action<P1, P2, P3, P4, P5>> action, Var<P1> p1, Var<P2> p2, Var<P3> p3, Var<P4> p4, Var<P5> p5)
        {
            b.CallDynamic(action.As<Delegate>(), p1, p2, p3, p4, p5);
        }

        public static void Call<P1, P2, P3, P4, P5, P6>(this ISyntaxBuilder b, Var<Action<P1, P2, P3, P4, P5, P6>> action, Var<P1> p1, Var<P2> p2, Var<P3> p3, Var<P4> p4, Var<P5> p5, Var<P6> p6)
        {
            b.CallDynamic(action.As<Delegate>(), p1, p2, p3, p4, p5, p6);
        }

        public static void Call<P1, P2, P3, P4, P5, P6, P7>(this ISyntaxBuilder b, Var<Action<P1, P2, P3, P4, P5, P6, P7>> action, Var<P1> p1, Var<P2> p2, Var<P3> p3, Var<P4> p4, Var<P5> p5, Var<P6> p6, Var<P7> p7)
        {
            b.CallDynamic(action.As<Delegate>(), p1, p2, p3, p4, p5, p6, p7);
        }

        public static void Call<P1, P2, P3, P4, P5, P6, P7, P8>(this ISyntaxBuilder b, Var<Action<P1, P2, P3, P4, P5, P6, P7, P8>> action, Var<P1> p1, Var<P2> p2, Var<P3> p3, Var<P4> p4, Var<P5> p5, Var<P6> p6, Var<P7> p7, Var<P8> p8)
        {
            b.CallDynamic(action.As<Delegate>(), p1, p2, p3, p4, p5, p6, p7, p8);
        }

        // Call functions

        public static Var<TOut> Call<TOut>(this ISyntaxBuilder b, Var<Func<TOut>> func)
        {
            return b.CallDynamic<TOut>(func.As<Delegate>());
        }

        public static Var<TOut> Call<P1, TOut>(this ISyntaxBuilder b, Var<Func<P1, TOut>> func, Var<P1> p1)
        {
            return b.CallDynamic<TOut>(func.As<Delegate>(), p1);
        }

        public static Var<TOut> Call<P1, P2, TOut>(this ISyntaxBuilder b, Var<Func<P1, P2, TOut>> func, Var<P1> p1, Var<P2> p2)
        {
            return b.CallDynamic<TOut>(func.As<Delegate>(), p1, p2);
        }

        public static Var<TOut> Call<P1, P2, P3, TOut>(this ISyntaxBuilder b, Var<Func<P1, P2, P3, TOut>> func, Var<P1> p1, Var<P2> p2, Var<P3> p3)
        {
            return b.CallDynamic<TOut>(func.As<Delegate>(), p1, p2, p3);
        }

        public static Var<TOut> Call<P1, P2, P3, P4, TOut>(this ISyntaxBuilder b, Var<Func<P1, P2, P3, P4, TOut>> func, Var<P1> p1, Var<P2> p2, Var<P3> p3, Var<P4> p4)
        {
            return b.CallDynamic<TOut>(func.As<Delegate>(), p1, p2, p3, p4);
        }

        public static Var<TOut> Call<P1, P2, P3, P4, P5, TOut>(this ISyntaxBuilder b, Var<Func<P1, P2, P3, P4, P5, TOut>> func, Var<P1> p1, Var<P2> p2, Var<P3> p3, Var<P4> p4, Var<P5> p5)
        {
            return b.CallDynamic<TOut>(func.As<Delegate>(), p1, p2, p3, p4, p5);
        }

        public static Var<TOut> Call<P1, P2, P3, P4, P5, P6, TOut>(this ISyntaxBuilder b, Var<Func<P1, P2, P3, P4, P5, P6, TOut>> func, Var<P1> p1, Var<P2> p2, Var<P3> p3, Var<P4> p4, Var<P5> p5, Var<P6> p6)
        {
            return b.CallDynamic<TOut>(func.As<Delegate>(), p1, p2, p3, p4, p5, p6);
        }

        public static Var<TOut> Call<P1, P2, P3, P4, P5, P6, P7, TOut>(this ISyntaxBuilder b, Var<Func<P1, P2, P3, P4, P5, P6, P7, TOut>> func, Var<P1> p1, Var<P2> p2, Var<P3> p3, Var<P4> p4, Var<P5> p5, Var<P6> p6, Var<P7> p7)
        {
            return b.CallDynamic<TOut>(func.As<Delegate>(), p1, p2, p3, p4, p5, p6, p7);
        }

        public static Var<TOut> Call<P1, P2, P3, P4, P5, P6, P7, P8, TOut>(this ISyntaxBuilder b, Var<Func<P1, P2, P3, P4, P5, P6, P7, P8, TOut>> func, Var<P1> p1, Var<P2> p2, Var<P3> p3, Var<P4> p4, Var<P5> p5, Var<P6> p6, Var<P7> p7, Var<P8> p8)
        {
            return b.CallDynamic<TOut>(func.As<Delegate>(), p1, p2, p3, p4, p5, p6, p7, p8);
        }

        // Define & call actions

        public static void Call<TSyntaxBuilder>(this ISyntaxBuilder b, Action<TSyntaxBuilder> action)
            where TSyntaxBuilder : ISyntaxBuilder
        {
            b.Call(b.Def(action));
        }

        public static void Call<TSyntaxBuilder, P1>(this ISyntaxBuilder b, Action<TSyntaxBuilder, Var<P1>> action, Var<P1> p1)
            where TSyntaxBuilder : ISyntaxBuilder
        {
            b.Call(b.Def(action), p1);
        }

        public static void Call<TSyntaxBuilder, P1, P2>(this ISyntaxBuilder b, Action<TSyntaxBuilder, Var<P1>, Var<P2>> action, Var<P1> p1, Var<P2> p2)
            where TSyntaxBuilder : ISyntaxBuilder
        {
            b.Call(b.Def(action), p1, p2);
        }

        public static void Call<TSyntaxBuilder, P1, P2, P3>(this ISyntaxBuilder b, Action<TSyntaxBuilder, Var<P1>, Var<P2>, Var<P3>> action, Var<P1> p1, Var<P2> p2, Var<P3> p3)
            where TSyntaxBuilder : ISyntaxBuilder
        {
            b.Call(b.Def(action), p1, p2, p3);
        }

        public static void Call<TSyntaxBuilder, P1, P2, P3, P4>(this ISyntaxBuilder b, Action<TSyntaxBuilder, Var<P1>, Var<P2>, Var<P3>, Var<P4>> action, Var<P1> p1, Var<P2> p2, Var<P3> p3, Var<P4> p4)
            where TSyntaxBuilder : ISyntaxBuilder
        {
            b.Call(b.Def(action), p1, p2, p3, p4);
        }

        public static void Call<TSyntaxBuilder, P1, P2, P3, P4, P5>(this ISyntaxBuilder b, Action<TSyntaxBuilder, Var<P1>, Var<P2>, Var<P3>, Var<P4>, Var<P5>> action, Var<P1> p1, Var<P2> p2, Var<P3> p3, Var<P4> p4, Var<P5> p5)
            where TSyntaxBuilder : ISyntaxBuilder
        {
            b.Call(b.Def(action), p1, p2, p3, p4, p5);
        }

        public static void Call<TSyntaxBuilder, P1, P2, P3, P4, P5, P6>(this ISyntaxBuilder b, Action<TSyntaxBuilder, Var<P1>, Var<P2>, Var<P3>, Var<P4>, Var<P5>, Var<P6>> action, Var<P1> p1, Var<P2> p2, Var<P3> p3, Var<P4> p4, Var<P5> p5, Var<P6> p6)
            where TSyntaxBuilder : ISyntaxBuilder
        {
            b.Call(b.Def(action), p1, p2, p3, p4, p5, p6);
        }

        public static void Call<TSyntaxBuilder, P1, P2, P3, P4, P5, P6, P7>(this ISyntaxBuilder b, Action<TSyntaxBuilder, Var<P1>, Var<P2>, Var<P3>, Var<P4>, Var<P5>, Var<P6>, Var<P7>> action, Var<P1> p1, Var<P2> p2, Var<P3> p3, Var<P4> p4, Var<P5> p5, Var<P6> p6, Var<P7> p7)
            where TSyntaxBuilder : ISyntaxBuilder
        {
            b.Call(b.Def(action), p1, p2, p3, p4, p5, p6, p7);
        }

        public static void Call<TSyntaxBuilder, P1, P2, P3, P4, P5, P6, P7, P8>(this ISyntaxBuilder b, Action<TSyntaxBuilder, Var<P1>, Var<P2>, Var<P3>, Var<P4>, Var<P5>, Var<P6>, Var<P7>, Var<P8>> action, Var<P1> p1, Var<P2> p2, Var<P3> p3, Var<P4> p4, Var<P5> p5, Var<P6> p6, Var<P7> p7, Var<P8> p8)
            where TSyntaxBuilder : ISyntaxBuilder
        {
            b.Call(b.Def(action), p1, p2, p3, p4, p5, p6, p7, p8);
        }

        // Define & call functions

        public static Var<TOut> Call<TSyntaxBuilder, TOut>(this TSyntaxBuilder b, Func<TSyntaxBuilder, Var<TOut>> func)
            where TSyntaxBuilder : ISyntaxBuilder
        {
            return b.Call(b.Def<TSyntaxBuilder, TOut>(func));
        }

        public static Var<TOut> Call<TSyntaxBuilder, P1, TOut>(this TSyntaxBuilder b, Func<TSyntaxBuilder, Var<P1>, Var<TOut>> func, Var<P1> p1)
            where TSyntaxBuilder : ISyntaxBuilder
        {
            return b.Call(b.Def(func), p1);
        }

        public static Var<TOut> Call<TSyntaxBuilder, P1, P2, TOut>(this TSyntaxBuilder b, Func<TSyntaxBuilder, Var<P1>, Var<P2>, Var<TOut>> func, Var<P1> p1, Var<P2> p2)
            where TSyntaxBuilder : ISyntaxBuilder
        {
            return b.Call(b.Def(func), p1, p2);
        }

        public static Var<TOut> Call<TSyntaxBuilder, P1, P2, P3, TOut>(this TSyntaxBuilder b, Func<TSyntaxBuilder, Var<P1>, Var<P2>, Var<P3>, Var<TOut>> func, Var<P1> p1, Var<P2> p2, Var<P3> p3)
            where TSyntaxBuilder : ISyntaxBuilder
        {
            return b.Call(b.Def(func), p1, p2, p3);
        }

        public static Var<TOut> Call<TSyntaxBuilder, P1, P2, P3, P4, TOut>(this TSyntaxBuilder b, Func<TSyntaxBuilder, Var<P1>, Var<P2>, Var<P3>, Var<P4>, Var<TOut>> func, Var<P1> p1, Var<P2> p2, Var<P3> p3, Var<P4> p4)
            where TSyntaxBuilder : ISyntaxBuilder
        {
            return b.Call(b.Def(func), p1, p2, p3, p4);
        }

        public static Var<TOut> Call<TSyntaxBuilder, P1, P2, P3, P4, P5, TOut>(this TSyntaxBuilder b, Func<TSyntaxBuilder, Var<P1>, Var<P2>, Var<P3>, Var<P4>, Var<P5>, Var<TOut>> func, Var<P1> p1, Var<P2> p2, Var<P3> p3, Var<P4> p4, Var<P5> p5)
            where TSyntaxBuilder : ISyntaxBuilder
        {
            return b.Call(b.Def(func), p1, p2, p3, p4, p5);
        }

        public static Var<TOut> Call<TSyntaxBuilder, P1, P2, P3, P4, P5, P6, TOut>(this TSyntaxBuilder b, Func<TSyntaxBuilder, Var<P1>, Var<P2>, Var<P3>, Var<P4>, Var<P5>, Var<P6>, Var<TOut>> func, Var<P1> p1, Var<P2> p2, Var<P3> p3, Var<P4> p4, Var<P5> p5, Var<P6> p6)
            where TSyntaxBuilder : ISyntaxBuilder
        {
            return b.Call(b.Def(func), p1, p2, p3, p4, p5, p6);
        }

        public static Var<TOut> Call<TSyntaxBuilder, P1, P2, P3, P4, P5, P6, P7, TOut>(this TSyntaxBuilder b, Func<TSyntaxBuilder, Var<P1>, Var<P2>, Var<P3>, Var<P4>, Var<P5>, Var<P6>, Var<P7>, Var<TOut>> func, Var<P1> p1, Var<P2> p2, Var<P3> p3, Var<P4> p4, Var<P5> p5, Var<P6> p6, Var<P7> p7)
            where TSyntaxBuilder : ISyntaxBuilder
        {
            return b.Call(b.Def(func), p1, p2, p3, p4, p5, p6, p7);
        }

        public static Var<TOut> Call<TSyntaxBuilder, P1, P2, P3, P4, P5, P6, P7, P8, TOut>(this TSyntaxBuilder b, Func<TSyntaxBuilder, Var<P1>, Var<P2>, Var<P3>, Var<P4>, Var<P5>, Var<P6>, Var<P7>, Var<P8>, Var<TOut>> func, Var<P1> p1, Var<P2> p2, Var<P3> p3, Var<P4> p4, Var<P5> p5, Var<P6> p6, Var<P7> p7, Var<P8> p8)
            where TSyntaxBuilder : ISyntaxBuilder
        {
            return b.Call(b.Def(func), p1, p2, p3, p4, p5, p6, p7, p8);
        }
    }
}