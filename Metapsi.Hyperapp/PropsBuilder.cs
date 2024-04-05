using Metapsi.Dom;
using Metapsi.Syntax;
using System;

namespace Metapsi.Hyperapp
{
    //public static class PropsBuilder
    //{
    //    public static PropsBuilder<TProps> New<TProps>(SyntaxBuilder b)
    //        where TProps : new()
    //    {
    //        return new PropsBuilder<TProps>(b, b.NewObj<TProps>());
    //    }

    //    public static PropsBuilder<TProps> New<TProps>(SyntaxBuilder b, Var<TProps> props)
    //    {
    //        return new PropsBuilder<TProps>(b, props);
    //    }
    //}

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

        //public PropsBuilder(SyntaxBuilder b, Var<TProps> props) : base(b)
        //{
        //    this.Props = props;
        //}

        public PropsBuilder<TNewType> Cast<TNewType>()
        {
            var newPropsBuilder = new PropsBuilder<TNewType>();
            newPropsBuilder.InitializeFrom(this);
            newPropsBuilder.Props = this.Props.As<TNewType>();
            return newPropsBuilder;
        }
    }
}
