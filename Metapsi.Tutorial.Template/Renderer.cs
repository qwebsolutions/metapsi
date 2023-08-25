﻿using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System.Collections.Generic;

namespace Metapsi.Tutorial.Template;

public class Model { }

public class Renderer : HyperPage<Model>
{
    public override string GetMountDivId()
    {
        return "iframeApp";
    }

    public override Var<HyperNode> OnRender(BlockBuilder b, Var<Model> model)
    {
        b.AddStylesheet("metapsi.tutorial.css");
        return null;
    }

    public Model DeserializeModel(string json)
    {
        return Metapsi.Serialize.FromJson<Model>(json);
    }
}