//using Metapsi.Hyperapp;
//using Metapsi.Syntax;

//namespace Metapsi.Shoelace;

//public enum AlertVariant
//{
//    Primary,
//    Sucess,
//    Neutral,
//    Warning,
//    Danger
//}

//public class Alert
//{
//    public AlertVariant Variant { get; set; }
//    public string Text { get; set; } = string.Empty;
//}

//public static partial class Control
//{
//    public static Var<HyperNode> Alert(this LayoutBuilder b, Var<Alert> props)
//    {
//        var control = b.SlNode("sl-alert");
//        b.Add(control, b.TextNode(b.Get(props, x => x.Text)));
//        b.SetAttr(control, new DynamicProperty<string>("open"), "true");
//        b.SetAttr(control, new DynamicProperty<string>("variant"), StringVariant(b, b.Get(props, x => x.Variant)));
//        return control;
//    }

//    private static Var<string> StringVariant(SyntaxBuilder b, Var<AlertVariant> variant)
//    {
//        return b.Switch(
//            variant,
//            b => b.Const("primary"),
//            (AlertVariant.Sucess, b => b.Const("success")),
//            (AlertVariant.Neutral, b => b.Const("neutral")),
//            (AlertVariant.Warning, b => b.Const("warning")),
//            (AlertVariant.Danger, b => b.Const("danger"))
//            );
//    }

//    public static void Toast(this SyntaxBuilder b, Var<Alert> props)
//    {
//        var variant = StringVariant(b, b.Get(props, x => x.Variant));
//        b.CallExternal("Metapsi.Shoelace", "notify", b.Get(props, x => x.Text), variant);
//    }

//    public static void Toast(this SyntaxBuilder b, Var<string> message, Var<AlertVariant> variant)
//    {
//        var sv = StringVariant(b, variant);
//        b.CallExternal("Metapsi.Shoelace", "notify", message, sv);
//    }
//}