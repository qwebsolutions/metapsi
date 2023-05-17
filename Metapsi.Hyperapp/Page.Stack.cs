using Metapsi.Syntax;
using Microsoft.AspNetCore.Components.RenderTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Metapsi.Hyperapp
{
    public static partial class Page
    {
        public class StackItem<TState>
        {
            public Func<TState, Guid, HyperNode> Renderer { get; set; }
            public Guid EntityId { get; set; }
        }

        public class Stack<TState>
        {
            public List<StackItem<TState>> Renderers { get; set; } = new();
        }

        public static void PushView<TState>(
            this BlockBuilder b,
            Var<TState> state,
            Expression<Func<TState, Page.Stack<TState>>> onStack,
            Var<Func<TState, Guid, HyperNode>> renderer,
            Var<Guid> entityId)
        {
            var stack = b.Get(state, onStack);
            var renderers = b.Get(stack, x => x.Renderers);
            b.Push(renderers, b.NewObj<StackItem<TState>>(b=>
            {
                b.Set(x => x.Renderer, renderer);
                b.Set(x => x.EntityId, entityId);
            }));
        }

        public static void PopView<TState>(
            this BlockBuilder b,
            Var<TState> state,
            Expression<Func<TState, Page.Stack<TState>>> onStack)
        {
            var stack = b.Get(state, onStack);
            var renderers = b.Get(stack, x => x.Renderers);
            var last = b.Get(renderers, x => x.Last());
            var withoutLast = b.Get(renderers, last, (renderers, last) => renderers.Where(x => x != last).ToList());
            b.Set(stack, x => x.Renderers, withoutLast);
        }

        public static Var<HyperNode> RenderCurrentView<TState>(
            this BlockBuilder b,
            Var<TState> state,
            Expression<Func<TState, Page.Stack<TState>>> fromStack,
            Func<BlockBuilder, Var<TState>, Var<HyperNode>> defaultRenderer)
        {
            var stack = b.Get(state, fromStack);

            return b.If(b.Get(stack, x => x.Renderers.Any()), b =>
            {
                var topRenderer = b.Get(stack, x => x.Renderers.Last());
                return b.Call(b.Get(topRenderer, x => x.Renderer), state, b.Get(topRenderer, x => x.EntityId));
            },
            b =>
            {
                return b.Call(defaultRenderer, state);
            });
        }
    }
}

