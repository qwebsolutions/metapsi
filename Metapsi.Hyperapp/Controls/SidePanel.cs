using Metapsi.Syntax;
using System.Linq;

namespace Metapsi.Hyperapp
{
    public interface IHasSidePanel
    {
        bool ShowSidePanel { get; set; }
    }

    public static class SidePanel
    {

        public class State
        {
            public string PanelName { get; set; } = string.Empty;
            public string Reference { get; set; } = string.Empty;
        }

        public const string X = "<svg xmlns=\"http://www.w3.org/2000/svg\" viewBox=\"0 0 24 24\" fill=\"currentColor\">\r\n\t<path fill-rule=\"evenodd\" d=\"M5.47 5.47a.75.75 0 011.06 0L12 10.94l5.47-5.47a.75.75 0 111.06 1.06L13.06 12l5.47 5.47a.75.75 0 11-1.06 1.06L12 13.06l-5.47 5.47a.75.75 0 01-1.06-1.06L10.94 12 5.47 6.53a.75.75 0 010-1.06z\" clip-rule=\"evenodd\" />\r\n</svg>\r\n";

        public static Var<HyperNode> Render(BlockBuilder b, Var<HyperNode> content)
        {
            var panel = b.Div("fixed top-0 right-0 bottom-0 w-1/3 bg-gray-50 h-screen transition-all duration-500 z-50");
            var verticalLayout = b.Add(panel, b.Div("flex flex-col p-4 items-start space-y-4 h-full"));

            var close = b.Add(verticalLayout, b.Node("button", "rounded text-white bg-rose-600 p-1 shadow"));
            b.Add(close, b.Svg(X, "w-4 h-4"));

            var container = b.Add(verticalLayout, b.Div("w-full h-full overflow-auto"));
            b.Add(container, content);

            var onClick = b.Def<IHasSidePanel, IHasSidePanel>((b, state) =>
            {
                b.Set(state, x => x.ShowSidePanel, b.Const(false));
                return b.Clone(state);
            });

            b.SetAttr(close, new DynamicProperty<System.Func<IHasSidePanel, IHasSidePanel>>("onclick"), onClick);

            return panel;
        }

        public static Var<TPage> ShowSidePanel<TPage>(this BlockBuilder b, Var<TPage> page)
            where TPage : IHasSidePanel
        {
            b.Set(page, x => x.ShowSidePanel, b.Const(true));
            return b.Clone(page);
        }

        //public static void ShowSidePanel<T>(this BlockBuilder b, Var<T> entity) where T: IRecord
        //{
        //    var reference = b.Get(entity, x => x.Id).As<string>();
        //    b.UpdateControlState<State>(b.Const(nameof(SidePanel)), b =>
        //    {
        //        b.Set(x => x.PanelName, b.Const(typeof(T).Name));
        //        b.Set(x => x.Reference, reference);
        //    });
        //}
    }

    public static partial class Controls
    {
        public static Var<HyperNode> SidePanel<TPage>(
            this BlockBuilder b,
            Var<TPage> page,
            System.Func<BlockBuilder, Var<HyperNode>> renderContent)
             where TPage : IHasSidePanel
        {
            b.Log("b.Get(page, x => x.ShowSidePanel)", b.Get(page, x => x.ShowSidePanel));
            return b.If(
                b.Get(page, x => x.ShowSidePanel),
                b =>
                {
                    var content = b.Call(renderContent);
                    return b.Call(Hyperapp.SidePanel.Render, content);
                },
                b => b.Div("fixed top-0 right-0 bottom-0 w-0 transition-all bg-gray-50 h-screen duration-500"));
        }
    }
}

