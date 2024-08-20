using Metapsi.Dom;
using Metapsi.Syntax;
using System;

namespace Metapsi.Hyperapp
{
    public static class ScrollEffects
    {
        private static void ScrollToBottomEffecter(
            this SyntaxBuilder b,
            Var<HyperType.Dispatcher> _dispatcher,
            Var<string> elementId)
        {
            b.RequestAnimationFrame(b.Def<SyntaxBuilder>(b =>
            {
                var domElement = b.GetElementById(elementId);
                b.If(b.HasObject(domElement), b =>
                {
                    var scrollHeight = b.GetDynamic(domElement, new DynamicProperty<int>("scrollHeight"));
                    b.SetDynamic(domElement, new DynamicProperty<int>("scrollTop"), scrollHeight);
                });
            }));
        }

        public static Var<HyperType.Effect> ScrollToBottom(
            this SyntaxBuilder b,
            Var<string> elementId)
        {
            var def = b.Def<SyntaxBuilder, HyperType.Dispatcher, string>(ScrollToBottomEffecter);
            return b.MakeEffect(def, elementId);
        }
    }
}
