using Metapsi.Syntax;
using System.Collections.Generic;
using System.Linq;

namespace Metapsi.Hyperapp
{

    public static class ActionBar
    {
        public class Command<TItem>
        {
            public string IconHtml { get; set; }
            public System.Action<TItem> OnCommand { get; set; }
        }

        public class Props<TItem>
        {
            public List<Command<TItem>> Commands { get; set; } = new();
        }

        public static Var<HyperNode> Render<TItem>(BlockBuilder b, Var<Props<TItem>> props, Var<TItem> entity)
        {
            var commands = b.Get(props, x => x.Commands);

            var rootContainer = b.Div("flex flex-row space-x-2 justify-end");

            b.Foreach(commands, (b, command) =>
            {
                var action = b.Div("flex rounded bg-gray-200 w-10 h-10 p-1 cursor-pointer justify-center items-center opacity-50 hover:opacity-100 text-red-500");
                b.SetInnerHtml(action, b.Get(command, x => x.IconHtml));

                var onClick = b.Def<object, object>((b, state) =>
                {
                    var onCommand = b.Get(command, x => x.OnCommand);
                    b.Call(onCommand, entity);
                    return b.Clone(state);
                });

                b.SetAttr(action, new DynamicProperty<System.Func<object, object>>("onclick"), onClick);
                b.Add(rootContainer, action);
            });

            return rootContainer;
        }
    }

    public static partial class Controls
    {

        public static Var<HyperNode> ActionBar<TItem>(
            this BlockBuilder b,
            Var<ActionBar.Props<TItem>> props,
            Var<TItem> entity)
        {
            return b.Call(Hyperapp.ActionBar.Render, props, entity);
        }
    }
}

