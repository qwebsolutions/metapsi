//using Metapsi.Hyperapp;
//using Metapsi.Syntax;
//using System;

//namespace Metapsi.Shoelace;

//public class Textarea
//{
//    public string Value { get; set; } = string.Empty;
//    public string HelpText { get; set; } = string.Empty;
//    public int Rows { get; set; } = 4;
//    public string Label { get; set; } = string.Empty;
//}

//public static partial class Control
//{
//    public static Var<HyperNode> Textarea(this LayoutBuilder b, Var<Textarea> props)
//    {
//        var textarea = b.SlNode("sl-textarea");

//        b.SetAttr(textarea, new DynamicProperty<string>("value"), b.Get(props, x => x.Value));
//        b.SetAttr(textarea, new DynamicProperty<int>("rows"), b.Get(props, x => x.Rows));
//        b.SetAttrIfNotEmptyString(textarea, new DynamicProperty<string>("help-text"), b.Get(props, x => x.HelpText));
//        b.SetAttrIfNotEmptyString(textarea, new DynamicProperty<string>("label"), b.Get(props, x => x.Label));

//        return textarea;
//    }

//    public static Var<HyperNode> BoundTextarea<TModel>(this LayoutBuilder b, Var<TModel> model, System.Linq.Expressions.Expression<Func<TModel, string>> onProperty, Var<Textarea> props)
//    {
//        b.Set(props, x => x.Value, b.Get(model, onProperty));
//        var textArea = b.Textarea(props);
//        b.SetOnSlChange(textArea, b.MakeAction((SyntaxBuilder b, Var<TModel> model, Var<string> newValue) =>
//        {
//            b.Set(model, onProperty, newValue);
//            return b.Clone(model);
//        }));

//        return textArea;
//    }
//}
