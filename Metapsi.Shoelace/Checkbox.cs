//using Metapsi.Hyperapp;
//using Metapsi.Syntax;
//using System.Runtime.CompilerServices;

//namespace Metapsi.Shoelace;

//public enum CheckboxSize
//{
//    Small,
//    Medium,
//    Large
//}

//public interface IHasCheckedProperty
//{
//    bool Checked { get; set; }
//}


//public class Checkbox : IHasCheckedProperty
//{
//    /// <summary>
//    /// Used in form data
//    /// </summary>
//    public string Name { get; set; }
//    /// <summary>
//    /// Used in form data
//    /// </summary>
//    public string Value { get; set; }

//    public bool Checked { get; set; }

//    public bool Disabled { get; set; }

//    public CheckboxSize CheckboxSize { get; set; } = CheckboxSize.Medium;
//}

//public partial class Control
//{
//    public static Var<HyperNode> Checkbox(this LayoutBuilder b, Var<Checkbox> props)
//    {
//        var checkbox = b.SlNode("sl-checkbox");

//        b.SetAttr(checkbox, new DynamicProperty<bool>("checked"), b.Get(props, x => x.Checked));
//        b.SetAttr(checkbox, new DynamicProperty<bool>("disabled"), b.Get(props, x => x.Disabled));
//        b.SetAttr(checkbox, new DynamicProperty<string>("size"), b.EnumToFirstLowercase(b.Get(props, x => x.CheckboxSize)));

//        return checkbox;
//    }

//    public static Var<HyperNode> BoundCheckbox<TModel>(
//        this LayoutBuilder b,
//        Var<string> label,
//        Var<TModel> model, 
//        System.Linq.Expressions.Expression<System.Func<TModel, bool>> onProperty)
//    {
//        var isChecked = b.Get(model, onProperty);

//        var checkbox = b.Checkbox(b.NewObj<Checkbox>(b =>
//        {
//            b.Set(x => x.Checked, isChecked);
//        }));

//        b.Add(checkbox, b.TextNode(label));

//        b.SetOnSlChange(checkbox, b.MakeAction((SyntaxBuilder b, Var<TModel> model, Var<bool> isChecked) =>
//        {
//            b.Set(model, onProperty, isChecked);
//            return b.Clone(model);
//        }));

//        return checkbox;
//    }
//}