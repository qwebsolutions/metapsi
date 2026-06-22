using Metapsi.Html;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Metapsi.Hyperapp
{
    public interface IGetVarExpressionBuilder
    {
        Var<TResult> Get<TInput, TResult>(
            Var<TInput> input,
            Expression<Func<TInput, TResult>> expression);
    }

    public interface IGetExpressionBuilder
    {
        TResult Get<TInput, TResult>(
            TInput input,
            Expression<Func<TInput, TResult>> expression);
    }

    public interface ILayoutBuilder
    {
        IHtmlPropsBuilder<TElement> GetPropsBuilder<TElement>();

        Var<IVNode> Tag(Var<string> tagName, Var<IHtmlProps> props, Var<List<IVNode>> children);
        Var<IVNode> Text(Var<string> text);
        Var<T> Const<T>(T value);

        Var<TResult> Get<TInput, TResult>(
            Var<TInput> input,
            Expression<Func<TInput, TResult>> expression);
        Var<List<T>> ToList<T>(IEnumerable<Var<T>> items);

        Var<string> AsString<T>(Var<T> value);
    }

    public interface ILayoutBuilder<TLayoutBuilder> : ILayoutBuilder, IIfExpressionBuilder<TLayoutBuilder>
    {
        Var<IVNode> Optional(Var<bool> ifValue, System.Func<TLayoutBuilder, Var<IVNode>> buildControl);
        Var<List<TOut>> Map<TIn, TOut>(
            Var<List<TIn>> list,
            Func<TLayoutBuilder, Var<TIn>, Var<TOut>> transform);
    }

    public class LayoutBuilder : SyntaxBuilder, ILayoutBuilder<LayoutBuilder>
    {
        public LayoutBuilder(ModuleBuilder b, List<SyntaxNode> nodes) : base(b, nodes) { }

        public IHtmlPropsBuilder<TElement> GetPropsBuilder<TElement>()
        {
            ISyntaxBuilder b = this as ISyntaxBuilder;
            return new PropsBuilder<TElement>(b.ModuleBuilder, b.GetNodes(), b.NewObj());
        }

        public Var<IVNode> Tag(Var<string> tagName, Var<IHtmlProps> props, Var<List<IVNode>> children)
        {
            var vNode = ExternalFunctions.H(
                this,
                tagName,
                props.As<object>(),
                children);

            return vNode;
        }

        public Var<IVNode> Text(Var<string> text)
        {
            return ExternalFunctions.Text(this, text);
        }

        public Var<IVNode> Optional(Var<bool> ifValue, System.Func<LayoutBuilder, Var<IVNode>> buildControl)
        {
            return LayoutBuilderExtensions.Optional(this, ifValue, buildControl);
        }

        public Var<T> Const<T>(T value)
        {
            return SyntaxBuilderExtensions.Const(this, value);
        }

        public Var<List<TOut>> Map<TIn, TOut>(Var<List<TIn>> list, Func<LayoutBuilder, Var<TIn>, Var<TOut>> transform)
        {
            return Core.Map(this, list, transform);
        }

        public Var<TResult> Get<TInput, TResult>(Var<TInput> input, Expression<Func<TInput, TResult>> expression)
        {
            return Core.Get(this, input, expression);
        }

        public Var<List<T>> ToList<T>(IEnumerable<Var<T>> items)
        {
            return Core.List(this, items);
        }

        public Var<string> AsString<T>(Var<T> value)
        {
            return Core.AsString(this, value);
        }

        public Var<TResult> If<TResult>(Var<bool> check, Func<LayoutBuilder, Var<TResult>> ifTrue, Func<LayoutBuilder, Var<TResult>> ifFalse)
        {
            return Core.If(this, check, ifTrue, ifFalse);
        }

        public Var<TResult> Switch<TResult, TInput>(Var<TInput> v, Func<LayoutBuilder, Var<TResult>> @default, params (TInput, Func<LayoutBuilder, Var<TResult>>)[] cases)
        {
            return Core.Switch(this, v, @default, cases);
        }
    }

    public static partial class LayoutBuilderExtensions
    {
        public static Var<IVNode> Optional(this LayoutBuilder b, Var<bool> ifValue, System.Func<LayoutBuilder, Var<IVNode>> buildControl)
        {
            return b.If(
                ifValue,
                b => b.Call(buildControl),
                b => b.H(ViewBuilder.VoidNodeTag));
        }

        public static Var<IVNode> Text(this ILayoutBuilder b, string text)
        {
            return b.Text(b.Const(text));
        }
    }
}
