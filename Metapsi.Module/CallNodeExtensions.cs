using System.Linq;

namespace Metapsi.Syntax
{
    public static class CallNodeExtensions
    {
        public static CallNode Call(this SyntaxBuilder b, IdentifierNode identifierNode, params ISyntaxNode[] argNodes)
        {
            var callNode = new CallNode()
            {
                Fn = identifierNode,
                Arguments = argNodes.ToList()
            };

            b.nodes.Add(callNode);

            return callNode;
        }

        public static CallNode Call(this SyntaxBuilder b, FnNode fnNode, params ISyntaxNode[] argNodes)
        {
            var callNode = new CallNode()
            {
                Fn = fnNode,
                Arguments = argNodes.ToList()
            };

            b.nodes.Add(callNode);
            return callNode;
        }
    }
}