using Metapsi.Dom;
using Metapsi.Syntax;
using System;

namespace Metapsi.Hyperapp
{
    public class PropsBuilder<TProps> : SyntaxBuilder
    {
        public Var<TProps> Props { get; set; }

        public override void InitializeFrom(SyntaxBuilder parent)
        {
            base.InitializeFrom(parent);

            if (parent is PropsBuilder<TProps>)
            {
                this.Props = ((PropsBuilder<TProps>)parent).Props;
            }
        }

        public PropsBuilder<TNewType> Cast<TNewType>()
        {
            var newPropsBuilder = new PropsBuilder<TNewType>();
            newPropsBuilder.InitializeFrom(this);
            newPropsBuilder.Props = this.Props.As<TNewType>();
            return newPropsBuilder;
        }
    }

    public static class PropsBuilderExtensions
    {
        public static Var<T> SetProps<T>(this SyntaxBuilder b, IVariable obj, Action<PropsBuilder<T>> setProps)
        {
            var propsBuilder = new PropsBuilder<T>();
            propsBuilder.InitializeFrom(b);
            propsBuilder.Props = obj.As<T>();
            setProps(propsBuilder);
            return propsBuilder.Props;
        }

        public static Var<T> NewObj<T>(this SyntaxBuilder b, Action<PropsBuilder<T>> setProps)
            where T : new()
        {
            var propsBuilder = new PropsBuilder<T>();
            propsBuilder.InitializeFrom(b);
            propsBuilder.Props = b.NewObj<T>();
            setProps(propsBuilder);
            return propsBuilder.Props;
        }
    }
}
