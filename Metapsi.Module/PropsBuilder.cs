using System;

namespace Metapsi.Syntax
{
    public class PropsBuilder<TProps> : SyntaxBuilder, IHtmlAttributesBuilder
    {
        internal PropsBuilder(SyntaxBuilder parent): base(parent) 
        {
            this.Props = this.NewObj().As<TProps>();
        }
        internal PropsBuilder(PropsBuilder<TProps> parent) : base(parent)
        {
            this.Props = parent.Props;
        }

        public Var<TProps> Props { get; set; }

        public void AddStyle(string property, string value)
        {
            this.AddStyle(property, this.Const(value));
        }

        public void AddStyle(string property, Var<string> value)
        {
            var currentStyle = this.GetProperty<object>(this.Props, "style");
            this.If(
                this.Not(this.HasObject(currentStyle)),
                b =>
                {
                    b.SetProperty(b.Props, b.Const("style"), b.NewObj<object>());
                });

            currentStyle = this.GetProperty<object>(this.Props, "style");
            this.SetProperty(currentStyle, this.Const(property), value);
        }

        public void SetAttribute(string attribute, Var<string> value)
        {
            this.SetProperty(this.Props, this.Const(attribute), value);
        }

        public void SetAttribute(string attribute, string value)
        {
            this.SetAttribute(attribute, this.Const(value));
        }

        /// <summary>
        /// Sets boolean attribute
        /// <para>Note that boolean attributes have no 'false' value. If they exist, they are true</para>
        /// </summary>
        /// <param name="name"></param>
        public void SetAttribute(string name)
        {
            this.SetProperty(this.Props, this.Const(name), this.Const(true));
        }
    }

    public static class PropsBuilderExtensions
    {
        /// <summary>
        /// Sets properties on an already existing object
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="b"></param>
        /// <param name="obj"></param>
        /// <param name="setProps"></param>
        /// <returns></returns>
        public static Var<T> SetProps<T>(this SyntaxBuilder b, IVariable obj, Action<PropsBuilder<T>> setProps)
        {
            var propsBuilder = new PropsBuilder<T>(b);
            propsBuilder.Props = obj.As<T>();
            if (setProps != null)
            {
                setProps(propsBuilder);
                b.nodes.AddRange(propsBuilder.nodes);
            }
            return propsBuilder.Props;
        }

        /// <summary>
        /// Creates a new object of type T using the default values of the object properties
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="b"></param>
        /// <param name="setProps"></param>
        /// <returns></returns>
        public static Var<T> NewObj<T>(this SyntaxBuilder b, Action<PropsBuilder<T>> setProps)
            where T : new()
        {
            var propsBuilder = new PropsBuilder<T>(b);
            propsBuilder.Props = b.NewObj<T>();
            if (setProps != null)
            {
                setProps(propsBuilder);
                b.nodes.AddRange(propsBuilder.nodes);
            }
            return propsBuilder.Props;
        }

        public static void Set<TObject, TValue>(this PropsBuilder<TObject> b, System.Linq.Expressions.Expression<Func<TObject, TValue>> onProperty, Var<TValue> value)
        {
            b.Set(b.Props, onProperty, value);
        }

        public static void Set<TObject, TValue>(this PropsBuilder<TObject> b, System.Linq.Expressions.Expression<Func<TObject, TValue>> onProperty, TValue value)
        {
            // Guard against 'double clienting'
            if (value is IVariable)
            {
                Core.SetLax(b, b.Props, onProperty, value as IVariable);
            }
            else
            {
                b.Set(onProperty, b.Const(value));
            }
        }

        public static Var<TValue> Get<TObject, TValue>(this PropsBuilder<TObject> b, System.Linq.Expressions.Expression<Func<TObject, TValue>> property)
        {
            return b.Get(b.Props, property);
        }

        public static void SetIfExists<TObject, TValue>(this PropsBuilder<TObject> b, System.Linq.Expressions.Expression<Func<TObject, TValue>> onProperty, Var<TValue> value)
        {
            b.If(b.HasObject(value), b => b.Set(onProperty, value));
        }

        public static void AddProps<T>(this PropsBuilder<T> b, System.Action<PropsBuilder<T>> setProps)
        {
            if (setProps != null)
                setProps(b);
        }
    }
}