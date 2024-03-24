using Metapsi.Hyperapp;
using Metapsi.Syntax;
using Metapsi.Ui;

namespace Metapsi.Html;

public static class GlobalAttributeExtensions
{
    public static void SetAttribute<TControl>(this PropsBuilder<TControl> b, string name, Var<string> value)
        where TControl : new()
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>(name), value);
    }

    public static void SetAttribute<TControl>(this PropsBuilder<TControl> b, string name, string value)
        where TControl : new()
    {
        b.SetAttribute(name, b.Const(value));
    }

    public static void SetAttribute<TControl>(this PropsBuilder<TControl> b, string name, Var<int> value)
        where TControl : new()
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>(name), value);
    }

    public static void SetAttribute<TControl>(this PropsBuilder<TControl> b, string name, int value)
        where TControl : new()
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
        where TControl : new()
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>(name), b.Const(true));
    }

    public static void SetId<T>(this PropsBuilder<T> b, Var<string> id)
        where T : new()
    {
        b.SetAttribute("id", id);
    }

    public static void SetId<T>(this PropsBuilder<T> b, string id)
        where T : new()
    {
        b.SetId(b.Const(id));
    }

    public static void SetClass<T>(this PropsBuilder<T> b, Var<string> @class)
        where T : new()
    {
        b.SetAttribute("class", @class);
    }

    public static void SetClass<T>(this PropsBuilder<T> b, string @class)
        where T : new()
    {
        b.SetClass(b.Const(@class));
    }

    public static void AddClass<T>(this PropsBuilder<T> b, Var<string> @class)
        where T : new()
    {
        var currentClass = b.GetDynamic(b.Props, new DynamicProperty<string>("class"));
        var updatedClass = b.Concat(currentClass, b.Const(" "), @class);
        b.SetClass(updatedClass);
    }

    public static void AddClass<T>(this PropsBuilder<T> b, string @class)
        where T : new()
    {
        b.AddClass(b.Const(@class));
    }

    public static void AddStyle<T>(this PropsBuilder<T> b, string property, Var<string> value)
        where T : new()
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
        where T : new()
    {
        b.AddStyle(property, b.Const(value));
    }

    public static void SetSlot<TProps>(this PropsBuilder<TProps> b, Var<string> slotName)
        where TProps : new()
    {
        b.SetAttribute("slot", slotName);
    }

    public static void SetSlot<TProps>(this PropsBuilder<TProps> b, string slotName)
        where TProps : new()
    {
        b.SetSlot(b.Const(slotName));
    }

    public static void AddStylesheet<T>(this PropsBuilder<T> b, string href)
        where T : new()
    {
        if (!href.StartsWith("http"))
        {
            // If it is not absolute path, make it absolute
            href = $"/{href}".Replace("//", "/");
        }

        b.Const(new LinkTag("stylesheet", href));
    }
}
