using System;

namespace Metapsi.Syntax
{
    /// <summary>
    /// Points to the class definition of T, allowing access to constructor and static properties/methods
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ClassDef<T>
    {

    }

    public interface IObjBuilder
    {
        internal SyntaxBuilder GetSyntaxBuilder();
        internal IVariable GetVariable();
    }

    /// <summary>
    /// Wraps a specific object for property and method access. Does not allow creating new blocks (branching, loops)
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ObjBuilder<T> : IObjBuilder
    {
        SyntaxBuilder IObjBuilder.GetSyntaxBuilder()
        {
            return this.syntaxBuilder;
        }

        IVariable IObjBuilder.GetVariable()
        {
            return this.Var;
        }

        public ObjBuilder(Var<T> var)
        {
            this.Var = var;
        }

        internal SyntaxBuilder syntaxBuilder { get; set; }
        public Var<T> Var { get; private set; }

        public ObjBuilder<TOut> Call<TOut>(string methodName, params IVariable[] parameters)
        {
            return new ObjBuilder<TOut>(syntaxBuilder.CallOnObject<TOut>(Var, methodName, parameters))
            {
                syntaxBuilder = this.syntaxBuilder
            };
        }

        public Var<TConst> Const<TConst>(TConst c)
        {
            //if anonymous (or always?), serialize also read-only properties

            return syntaxBuilder.Const(c);
        }

        public Var<TObj> NewObj<TObj>(Action<PropsBuilder<TObj>> setProps)
        {
            return syntaxBuilder.SetProps(syntaxBuilder.NewObj(), setProps);
        }
    }

    public static class ObjectBuilderExtensions
    {
        public static Var<T> GetProperty<T>(this IObjBuilder b, Var<string> name)
        {
            return b.GetSyntaxBuilder().GetProperty<T>(b.GetVariable(), name);
        }

        public static Var<T> GetProperty<T>(this IObjBuilder b, string name)
        {
            return b.GetSyntaxBuilder().GetProperty<T>(b.GetVariable(), name);
        }

        public static Var<TOut> On<TIn, TOut>(this SyntaxBuilder b, Var<TIn> input, Func<ObjBuilder<TIn>, Var<TOut>> transform)
        {
            var result = transform(new ObjBuilder<TIn>(input) { syntaxBuilder = b });
            return result;
        }

        public static Var<TOut> On<TIn, TOut>(this SyntaxBuilder b, Var<TIn> input, Func<ObjBuilder<TIn>, ObjBuilder<TOut>> transform)
        {
            var result = transform(new ObjBuilder<TIn>(input) { syntaxBuilder = b });
            return result.Var;
        }
    }
}