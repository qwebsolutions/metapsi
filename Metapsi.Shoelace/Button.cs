using Metapsi.Hyperapp;
using Metapsi.Syntax;

namespace Metapsi.Shoelace;

public enum ButtonVariant
{
    Default,
    Primary,
    Success,
    Neutral,
    Warning,
    Danger,
    Text
}

public enum ButtonSize
{
    Small,
    Medium,
    Large
}

public enum ButtonType
{
    Button,
    Submit,
    Reset
}

public class Button
{
    public ButtonVariant Variant { get; set; }
    public ButtonSize Size { get; set; } = ButtonSize.Medium;
    public bool Disabled { get; set; }
    public bool Loading { get; set; }
    public bool Outlined { get; set; }
    public bool Pill { get; set; }
    public bool Circle { get; set; }

    public string Text { get; set; }
}

public static partial class Control
{
    public static Var<HyperNode> Button(this BlockBuilder b, Var<Button> props)
    {
        var button = b.Node("sl-button");
        b.SetAttrIfNotEmptyString(button, DynamicProperty.String("variant"), b.EnumToLowercase(b.Get(props, x => x.Variant)));
        b.SetAttrIfNotEmptyString(button, DynamicProperty.String("size"), b.EnumToLowercase(b.Get(props, x => x.Size)));
        b.SetAttr(button, DynamicProperty.Bool("disabled"), b.Get(props, x => x.Disabled));
        b.SetAttr(button, DynamicProperty.Bool("loading"), b.Get(props, x => x.Loading));
        b.SetAttr(button, DynamicProperty.Bool("outlined"), b.Get(props, x => x.Outlined));
        b.SetAttr(button, DynamicProperty.Bool("pill"), b.Get(props, x => x.Pill));
        b.SetAttr(button, DynamicProperty.Bool("circle"), b.Get(props, x => x.Circle));

        var text = b.Get(props, x => x.Text);
        b.If(b.HasValue(text),
            b =>
            {
                b.Add(button, b.TextNode(text));
            });

        return button;
    }

    public static Var<HyperNode> Button(this BlockBuilder b, Var<string> text)
    {
        var props = b.NewObj<Button>();
        var button = b.Button(props);
        b.Add(button, b.TextNode(text));
        return button;
    }

    public static Var<HyperNode> Button(this BlockBuilder b, string text)
    {
        return b.Button(b.Const(text));
    }
}