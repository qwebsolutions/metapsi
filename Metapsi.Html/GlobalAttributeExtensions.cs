using Metapsi.Hyperapp;
using Metapsi.Syntax;
using Metapsi.Ui;

namespace Metapsi.Html;

public static class GlobalAttributeExtensions
{
    public static void SetAttribute<TControl>(this PropsBuilder<TControl> b, string name, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>(name), value);
    }

    public static void SetAttribute<TControl>(this PropsBuilder<TControl> b, string name, string value)
    {
        b.SetAttribute(name, b.Const(value));
    }

    public static void SetAttribute<TControl>(this PropsBuilder<TControl> b, string name, Var<int> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>(name), value);
    }

    public static void SetAttribute<TControl>(this PropsBuilder<TControl> b, string name, int value)
    {
        b.SetAttribute(name, b.Const(value));
    }

    /// <summary>
    /// Sets boolean attribute
    /// <para>Note that boolean attributes have no 'false' value. If they exist, they are true</para>
    /// </summary>
    /// <typeparam name="TControl"></typeparam>
    /// <param name="b"></param>
    /// <param name="name"></param>
    public static void SetAttribute<TControl>(this PropsBuilder<TControl> b, string name)
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>(name), b.Const(true));
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

    public static void SetId<T>(this PropsBuilder<T> b, string id)
    {
        b.SetId(b.Const(id));
    }

    public static void SetClass<T>(this PropsBuilder<T> b, Var<string> @class)
    {
        b.SetAttribute("class", @class);
    }

    public static void SetClass<T>(this PropsBuilder<T> b, string @class)
    {
        b.SetClass(b.Const(@class));
    }

    public static PropsBuilder<T> AddClass<T>(this PropsBuilder<T> b, Var<string> @class)
    {
        var currentClass = b.GetDynamic(b.Props, new DynamicProperty<string>("class"));
        var updatedClass = b.Concat(currentClass, b.Const(" "), @class);
        b.SetClass(updatedClass);
        return b;
    }

    public static PropsBuilder<T> AddClass<T>(this PropsBuilder<T> b, string @class)
    {
        return b.AddClass(b.Const(@class));
    }

    public static void AddStyle<T>(this PropsBuilder<T> b, string property, Var<string> value)
    {
        var styleProperty = new DynamicProperty<object>("style");

        var currentStyle = b.GetDynamic(b.Props, styleProperty);
        b.If(
            b.Not(b.HasObject(currentStyle)),
            b =>
            {
                b.SetDynamic(b.Props, styleProperty, b.NewObj<object>());
            });

        currentStyle = b.GetDynamic(b.Props, styleProperty);
        b.SetDynamic(currentStyle, new DynamicProperty<string>(property), value);
    }

    public static void AddStyle<T>(this PropsBuilder<T> b, string property, string value)
    {
        b.AddStyle(property, b.Const(value));
    }

    public static void SetSlot<TProps>(this PropsBuilder<TProps> b, Var<string> slotName)
    {
        b.SetAttribute("slot", slotName);
    }

    public static void SetSlot<TProps>(this PropsBuilder<TProps> b, string slotName)
    {
        b.SetSlot(b.Const(slotName));
    }

    public static void AddStylesheet<T>(this PropsBuilder<T> b, string href)
    {
        if (!href.StartsWith("http"))
        {
            // If it is not absolute path, make it absolute
            href = $"/{href}".Replace("//", "/");
        }

        b.Const(new LinkTag("stylesheet", href));
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
