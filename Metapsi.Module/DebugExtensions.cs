using System.Linq;
using System.Linq.Expressions;

namespace Metapsi.Syntax
{
    public static class DebugExtensions
    {
        public static void AddDebugType(this AssignmentNode assignmentNode, System.Type type)
        {
//#if DEBUG
            if (type.Name == "Var`1")
            {
                var varType = type.GenericTypeArguments.FirstOrDefault();
                if (varType != null)
                {
                    assignmentNode.DebugType = varType.CSharpTypeName();
                }
            }
            else
            {
                assignmentNode.DebugType = type.CSharpTypeName();
            }
//#endif
        }

        public static void AddDebugType(this FnNode fnNode, System.Delegate @delegate)
        {
//#if DEBUG
            fnNode.DebugSource = $"{@delegate.Method.DeclaringType.CSharpTypeName()}";
//#endif
        }
    }
}