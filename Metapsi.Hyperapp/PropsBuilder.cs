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
}
