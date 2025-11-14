using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metapsi.FluentUi;

public static partial class FluentExtensions
{
    public static Var<IVNode> FluentNode<T>(
        this LayoutBuilder b,
        string tagName,
        Action<PropsBuilder<T>> setProps, Var<System.Collections.Generic.List<IVNode>> children)
    {
        return b.H(
            b.Const(tagName),
            b.SetProps<T>(b.NewObj<object>(), setProps).As<object>(),
            children);
    }
}

//public class DropdownOption
//{

//}

//public class MenuList
//{

//}

//public class Tab
//{

//}

//public class NodeList
//{

//}

//public class Radio
//{

//}