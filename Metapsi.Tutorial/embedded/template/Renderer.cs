using Metapsi;
using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System.Collections.Generic;
using System.Linq;
using System;

namespace Metapsi.Tutorial.Template;

public class Model { }

public class Renderer : HyperPage<Model>
{
    public override string GetMountDivId()
    {
        return "iframeApp";
    }

    public Var<IVNode> RenderHyperNode(LayoutBuilder b, Var<Model> model)
    {
        return null;
    }

    public override Var<IVNode> OnRender(LayoutBuilder b, Var<Model> model)
    {
        b.AddStylesheet("metapsi.tutorial.css");
        return RenderHyperNode(b, model);
    }

    public Model DeserializeModel(string json)
    {
        return Metapsi.Serialize.FromJson<Model>(json);
    }
}
