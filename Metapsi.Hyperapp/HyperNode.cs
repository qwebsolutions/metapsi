using Metapsi.Syntax;
using System.Collections.Generic;

namespace Metapsi.Hyperapp
{
    //public class HParams
    //{
    //    public string Tag { get; set; }
    //    public DynamicObject Props { get; set; } = new();
    //    //public List<HyperNode> Children { get; set; } = new();
    //}

    //public class HParams<TProps>
    //    where TProps : new()
    //{
    //    public string Tag { get; set; }
    //    public TProps Props { get; set; } = new();
    //    public List<HyperNode> Children { get; set; } = new();
    //}

    //public class HyperNode
    //{
    //    public string tag { get; set; }
    //    public DynamicObject props { get; set; } = new DynamicObject();
    //    public List<HyperNode> children { get; set; }
    //}
    //public class TextNode
    //{
    //    public string Text { get; set; }
    //}

    public static class HExtensions
    {
        //public static Var<HParams> HNode(this BlockBuilder b, Var<string> tag)
        //{
        //    var p = b.NewObj<HParams>();
        //    b.Set(p, x => x.Tag, tag);
        //    return p;
        //}

        //public static Var<HParams> HNode(this BlockBuilder b, string tag)
        //{
        //    return b.HNode(b.Const(tag));
        //}

        //public static Var<HParams> HDiv(this BlockBuilder b)
        //{
        //    return b.HNode("div");
        //}

        //public static Var<HParams> HSvg(this BlockBuilder b, Var<string> svg)
        //{
        //    var container = b.HDiv();
        //    b.SetProp(container, Html.innerHTML, svg);
        //    return container;
        //}

        //public static Var<HParams> HSvg(this BlockBuilder b, string svg)
        //{
        //    return b.HSvg(b.Const(svg));
        //}

        //public static Var<HParams> SetProp<T>(
        //    this BlockBuilder b,
        //    Var<HParams> hParams,
        //    DynamicProperty<T> property,
        //    Var<T> value)
        //{
        //    b.SetDynamic(b.Get(hParams, x => x.Props), property, value);
        //    return hParams;
        //}

        //public static Var<HParams> SetProp<T>(
        //    this BlockBuilder b,
        //    Var<HParams> hParams,
        //    DynamicProperty<T> property,
        //    T value)
        //{
        //    return b.SetProp(hParams, property, b.Const(value));
        //}

        //public static Var<T> GetProp<T>(
        //    this BlockBuilder b,
        //    Var<HParams> hParams,
        //    DynamicProperty<T> property)
        //{
        //    return b.GetDynamic(b.Get(hParams, x => x.Props), property);
        //}

    }
}