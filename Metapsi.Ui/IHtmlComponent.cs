using System.Collections.Generic;

namespace Metapsi.Ui;

public interface IHtmlComponent
{
    void OnMount(DocumentTag document);
}

//public class ClientControl : IHtmlComponent
//{
//    public List<IHtmlNode> HeaderRequiredNodes { get; set; } = new();
//    public HtmlTag MountPoint { get; set; }

//    public void OnMount(DocumentTag document)
//    {
//        foreach(IHtmlNode htmlNode in HeaderRequiredNodes)
//        {
//            document.Head.AddChild(htmlNode);
//        }
//    }

//    public static ClientControl Create<TDataModel(
//        System.Func<BlockBuilder, Var<TDataModel>, Var<HyperNode>> render,
//        System.Func<BlockBuilder, Var<TDataModel>, Var<HyperType.StateWithEffects>> init = null)
//}