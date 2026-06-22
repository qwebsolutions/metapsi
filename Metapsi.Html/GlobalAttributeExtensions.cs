using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace Metapsi.Html;

public static class GlobalAttributeExtensions
{
    public static void SetId(this IHtmlPropsBuilder b, string id)
    {
        b.SetAttribute("id", id);
    }

    public static void SetSlot(this IHtmlPropsBuilder b, string slot)
    {
        b.SetAttribute("slot", slot);
    }

    public static void SetAttribute<TControl>(this PropsBuilder<TControl> b, string name, Var<int> value)
    {
        b.SetProperty(b.Props, b.Const(name), value);
    }

    public static void SetAttribute<TControl>(this PropsBuilder<TControl> b, string name, int value)
    {
        b.SetAttribute(name, b.Const(value));
    }

    /// <summary>
    /// Sets boolean attribute if it is not false. 
    /// Useful for binding to some property without needing to always check if value is true
    /// </summary>
    /// <typeparam name="TControl"></typeparam>
    /// <param name="b"></param>
    /// <param name="name"></param>
    /// <param name="value"></param>
    public static void SetAttribute<TControl>(this PropsBuilder<TControl> b, string name, Var<bool> value)
    {
        b.If(
            value,
            b => b.SetAttribute(name));
    }

    public static void SetId<T>(this PropsBuilder<T> b, Var<string> id)
    {
        b.SetAttribute("id", id);
    }



    public static void SetSlot<TProps>(this PropsBuilder<TProps> b, Var<string> slotName)
    {
        b.SetAttribute("slot", slotName);
    }

    public static void SetInnerHtml<T>(this PropsBuilder<T> b, Var<string> innerHtml)
    {
        b.SetAttribute("innerHTML", innerHtml);
    }

    public static void SetInnerHtml<T>(this PropsBuilder<T> b, string innerHtml)
    {
        b.SetInnerHtml(b.Const(innerHtml));
    }
}
