
using Metapsi;
using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;
using System.Reflection;

namespace Metapsi.Html.Scenarios;

public class RootCustomElement: CustomElement<RootCustomElement.Model>
{
    public override Var<HyperType.StateWithEffects> OnInit(SyntaxBuilder b, Var<Element> element)
    {
        return b.MakeStateWithEffects(b.NewObj<Model>());
    }

    public override IRootControl OnRender(LayoutBuilder b, Var<Model> model)
    {
        var imported = b.RequireCustomElement<ImportedCustomElement>();
        return this.Root(b.H(imported.Tag));
    }

    public class Model
    {

    }
}

public class ImportedCustomElement : CustomElement<ImportedCustomElement.Model>
{
    public override Var<HyperType.StateWithEffects> OnInit(SyntaxBuilder b, Var<Element> element)
    {
        return b.MakeStateWithEffects(b.NewObj<Model>());
    }

    public override IRootControl OnRender(LayoutBuilder b, Var<Model> model)
    {
        // Not needed, tests recursive imports
        var root = b.RequireCustomElement<RootCustomElement>();
        return this.Root(
            b.Text("Imported custom element!"));
    }

    public class Model
    {

    }
}