using Metapsi.Hyperapp;
using Metapsi.Syntax;

public static class PropsStore
{
    //public static void PassProps<T>(this SyntaxBuilder b, Var<string> id, Var<T> props)
    //{
    //    b.CallExternal("Metapsi.PropsStore", "PassProps", id, props);
    //}

    //public static void SetControlProps<T>(this LayoutBuilder b, Var<HyperNode> node, Var<T> props)
    //{
    //    var nodeProps = b.Get(node, x => x.props);
    //    var nodeId = b.GetDynamic(nodeProps, Html.id);

    //    b.If(b.Not(b.HasValue(nodeId)),
    //        b =>
    //        {
    //            var newId = b.Concat(b.Const("id-"), b.AsString(b.NewId()));
    //            b.SetAttr(node, Html.id, newId);
    //            b.PassProps(newId, props);
    //        },
    //        b =>
    //        {
    //            b.PassProps(nodeId, props);
    //        });
    //}
}