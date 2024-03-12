using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;

namespace Metapsi.Ionic;

public static class IonicNodeImport
{
    public static Var<IVNode> IonicNode<TProps>(
        this LayoutBuilder b,
        string tag,
        Action<PropsBuilder<TProps>> buildProps,
        Var<IVNode>[] children)
        where TProps : new()
    {
        b.AddScript("https://cdn.jsdelivr.net/npm/@ionic/core/dist/ionic/ionic.esm.js", "module");
        b.AddScript("https://cdn.jsdelivr.net/npm/@ionic/core/dist/ionic/ionic.js");
        b.AddStylesheet("https://cdn.jsdelivr.net/npm/@ionic/core/css/ionic.bundle.css");

        Action<PropsBuilder, Var<DynamicObject>> dynamicPropsBuilder = (PropsBuilder b, Var<DynamicObject> props) =>
        {
            var propsBuilder = new PropsBuilder<TProps>(b, props.As<TProps>());
            buildProps(propsBuilder);
        };
        return b.H(tag, dynamicPropsBuilder, children);
    }

    public static Var<IVNode> IonicNode<TProps>(
        this LayoutBuilder b,
        string tag,
        Action<PropsBuilder<TProps>> buildProps,
        Var<List<IVNode>> children)
        where TProps : new()
    {
        b.AddScript("https://cdn.jsdelivr.net/npm/@ionic/core/dist/ionic/ionic.esm.js", "module");
        b.AddScript("https://cdn.jsdelivr.net/npm/@ionic/core/dist/ionic/ionic.js");
        b.AddStylesheet("https://cdn.jsdelivr.net/npm/@ionic/core/css/ionic.bundle.css");

        Action<PropsBuilder, Var<DynamicObject>> dynamicPropsBuilder = (PropsBuilder b, Var<DynamicObject> props) =>
        {
            var propsBuilder = new PropsBuilder<TProps>(b, props.As<TProps>());
            buildProps(propsBuilder);
        };
        return b.H(tag, dynamicPropsBuilder, children);
    }
}
