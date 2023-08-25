using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;

namespace Metapsi.Shoelace;

public class Animation
{
    public string Name { get; set; }
    public bool Play { get; set; }
    public int Delay { get; set; }
    public int Duration { get; set; } = 1000;
    public int Iterations { get; set; } = -1;
    public string Fill { get; set; } = "auto";
    public string Easing { get; set; } = "linear";
}

public static partial class Control
{
    public static Var<HyperNode> Animation(this BlockBuilder b, Var<Animation> props, Func<BlockBuilder, Var<HyperNode>> content = null)
    {
        var animation = b.SlNode("sl-animation");

        b.SetAttr(animation, DynamicProperty.String("name"), b.Get(props, x => x.Name));
        b.SetAttr(animation, DynamicProperty.Bool("play"), b.Get(props, x => x.Play));
        b.SetAttr(animation, DynamicProperty.Int("duration"), b.Get(props, x => x.Duration));
        b.SetAttr(animation, DynamicProperty.Int("delay"), b.Get(props, x => x.Delay));
        b.SetAttr(animation, DynamicProperty.String("fill"), b.Get(props, x => x.Fill));
        b.SetAttr(animation, DynamicProperty.String("easing"), b.Get(props, x => x.Easing));

        var iterations = b.Get(props, x => x.Iterations);
        b.If(
            b.Not(
                b.AreEqual(iterations, b.Const(-1))),
            b =>
            {
                b.SetAttr(animation, DynamicProperty.Int("iterations"), iterations);
            });

        if (content != null)
        {
            b.Add(animation, b.Call(content));
        }

        return animation;
    }
}