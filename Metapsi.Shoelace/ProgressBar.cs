//using Metapsi.Hyperapp;
//using Metapsi.Syntax;

//namespace Metapsi.Shoelace;

//public class ProgressBar
//{
//    public int Value { get; set; }
//}

//public static partial class Control
//{
//    public static Var<HyperNode> ProgressBar(this LayoutBuilder b, Var<ProgressBar> props)
//    {
//        var progressBar = b.SlNode("sl-progress-bar");
//        b.SetAttr(progressBar, new DynamicProperty<int>("value"), b.Get(props, x => x.Value));
        
//        return progressBar;
//    }

//    public static Var<HyperNode> ProgressBar(this LayoutBuilder b, Var<int> value)
//    {
//        return b.ProgressBar(b.NewObj<ProgressBar>(b => b.Set(x => x.Value, value)));
//    }
//}