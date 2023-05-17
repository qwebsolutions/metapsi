using Metapsi.Syntax;
using System.Linq;

namespace Metapsi.Hyperapp
{
    public static class TextArea
    {
        public class Props
        {
            public string Text { get; set; }
            public int Rows { get; set; } = 5;
            public string CssClass { get; set; } = "hyper-input";
            public bool Enabled { get; set; } = true;
            public string Placeholder { get; set; } = "";
        }

        public static Var<HyperNode> Render(this BlockBuilder b, Var<TextArea.Props> props)
        {
            var textArea = b.Node("textarea", b.Get(props, x => x.CssClass));
            b.SetAttr(textArea, new DynamicProperty<int>("rows"), b.Get(props, x => x.Rows));
            b.SetAttr(textArea, Html.placeholder, b.Get(props, x => x.Placeholder));

            var isEnabled = b.Get(props, x => x.Enabled);
            b.If(b.Not(isEnabled), b => b.SetAttr(textArea, Html.disabled, true));

            b.Add(textArea, b.TextNode(b.Get(props, x => x.Text)));

            return textArea;
        }
    }
    public static partial class Controls
    {



        public static Var<HyperNode> TextArea(this BlockBuilder b, Var<TextArea.Props> props)
        {
            return Metapsi.Hyperapp.TextArea.Render(b,props);
        }
        public static Var<HyperNode> TextArea(
            this BlockBuilder b, 
            Var<string> text,
            System.Action<Modifier<TextArea.Props>> optional = null)
        {
            var props = b.NewObj<TextArea.Props>(
                b =>
                {
                    b.Set(x => x.Text, text);
                });
            b.Modify(props, optional);

            return b.TextArea(props);
        }
    }
}

