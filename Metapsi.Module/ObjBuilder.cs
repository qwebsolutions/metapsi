using System;

namespace Metapsi.Syntax
{
    /// <summary>
    /// Points to the class definition of T, allowing access to constructor and static properties/methods
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface ClassDef<T>
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

        public void Call(string methodName, params IVariable[] parameters)
        {
            syntaxBuilder.CallOnObject(Var, methodName, parameters);
        }

        public ObjBuilder<TOut> Get<TOut>(string property)
        {
            return new ObjBuilder<TOut>(syntaxBuilder.GetProperty<TOut>(this.Var, property))
            {
                syntaxBuilder = this.syntaxBuilder
            };
        }

        public ObjBuilder<TOut> Get<TOut>(System.Linq.Expressions.Expression<Func<T, TOut>> property)
        {
            return this.Get<TOut>(property.PropertyName());
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
        //public static ObjBuilder<T> GetProperty<T>(this IObjBuilder b, Var<string> name)
        //{
        //    return new ObjBuilder<object>().Call b.GetSyntaxBuilder().GetProperty<T>(b.GetVariable(), name);
        //}

        //public static ObjBuilder<T> GetProperty<T>(this IObjBuilder b, string name)
        //{
        //    return b.GetSyntaxBuilder().GetProperty<T>(b.GetVariable(), name);
        //}

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

        public static void On<TIn>(this SyntaxBuilder b, Var<TIn> input, Action<ObjBuilder<TIn>> call)
        {
            call(new ObjBuilder<TIn>(input) { syntaxBuilder = b });
        }

        /// <summary>
        /// Call new operator on this class
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="b"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public static ObjBuilder<T> New<T>(this ObjBuilder<ClassDef<T>> b, params IVariable[] args)
        {
            return new ObjBuilder<T>(b.syntaxBuilder.New<T>(b.Var, args))
            {
                syntaxBuilder = b.syntaxBuilder
            };
        }
    }
}