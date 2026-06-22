using System;
using System.Collections.Generic;

namespace Metapsi.Syntax
{
    public class PropsBuilder<TProps> : Var<TProps>, IObjBuilder, IHtmlPropsBuilder, IHtmlPropsBuilder<TProps>, IClientVar
    {
        private readonly ModuleBuilder moduleBuilder;
        private readonly List<SyntaxNode> nodes;

        public PropsBuilder(ModuleBuilder moduleBuilder, List<SyntaxNode> nodes, IVariable var)
        {
            this.moduleBuilder = moduleBuilder;
            this.nodes = nodes;
            this.Props = var.As<TProps>();
            (this as IClientVar).Name = (var as IClientVar).Name;
        }

        ModuleBuilder ISyntaxBuilder.ModuleBuilder => this.moduleBuilder;

        public Var<TProps> Props { get; set; }
        string IClientVar.Name { get; set; }

        public string ResolvePath(IResource resource)
        {
            return this.moduleBuilder.Resolver.ResolvePath(resource);
        }

        public void AddClass(string className)
        {
            this.AddClass(this.Const(className));
        }

        private Var<List<object>> GetClassList()
        {
            return GetClassList(this, this.Props.As<object>());
        }

        private static Var<List<object>> GetClassList(ISyntaxBuilder b, Var<object> props)
        {
            var classList = b.GetProperty<List<object>>(props, b.Const("class"));
            return b.If(
                b.HasObject(classList),
                b => classList,
                b =>
                {
                    var newList = b.NewCollection<object>();
                    b.SetProperty(props, b.Const("class"), newList);
                    return newList;
                });
        }

        public void AddClass(Var<string> @class)
        {
            AddClass(this, this.Props.As<object>(), @class);
        }

        private static void AddClass(ISyntaxBuilder b, Var<object> props, Var<string> @class)
        {
            b.Push(GetClassList(b, props), @class.As<object>());
        }

        public void SetClass(Var<string> @class)
        {
            var classList = this.GetClassList();
            this.Clear(classList);
            this.Push(classList.As<List<string>>(), @class);
        }

        public void SetClass(string @class)
        {
            this.SetClass(this.Const(@class));
        }

        public void AddClass(Var<string> @class, Var<bool> enabled)
        {
            this.Push(this.GetClassList(), this.NewObj<object>(
                b =>
                {
                    b.SetProperty(b.Props, @class, enabled);
                }));
        }

        public void AddStyle(string property, string value)
        {
            this.AddStyle(property, this.Const(value));
        }

        public void AddStyle(string property, Var<string> value)
        {
            this.AddStyle(this.Const(property), value);
        }

        public void AddStyle(Var<string> property, Var<string> value)
        {
            this.Call<ISyntaxBuilder, object, string, string>(AddStyle, this.Props.As<object>(), property, value);
        }

        private static void AddStyle(ISyntaxBuilder b, Var<object> props, Var<string> property, Var<string> value)
        {
            var currentStyle = b.GetProperty<object>(props, "style");
            b.If(
                b.Not(b.HasObject(currentStyle)),
                b =>
                {
                    b.SetProperty(props, b.Const("style"), b.NewObj<object>());
                });

            currentStyle = b.GetProperty<object>(props, "style");
            b.SetProperty(currentStyle, property, value);
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

        void ISyntaxBuilder.AddSyntaxNode(SyntaxNode syntaxNode)
        {
            this.nodes.Add(syntaxNode);
        }

        List<SyntaxNode> ISyntaxBuilder.GetNodes()
        {
            return this.nodes;
        }

        public Var<IHtmlProps> GetProps()
        {
            return Props.As<IHtmlProps>();
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
        public static Var<T> SetProps<T>(this ISyntaxBuilder b, IVariable obj, Action<PropsBuilder<T>> setProps)
        {
            var propsBuilder = new PropsBuilder<T>(b.ModuleBuilder, b.GetNodes(), obj);
            if (setProps != null)
            {
                setProps(propsBuilder);
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
        public static Var<T> NewObj<T>(this ISyntaxBuilder b, Action<PropsBuilder<T>> setProps)
            where T : new()
        {
            var obj = b.NewObj<T>();
            var propsBuilder = new PropsBuilder<T>(b.ModuleBuilder, b.GetNodes(), obj);
            if (setProps != null)
            {
                setProps(propsBuilder);
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