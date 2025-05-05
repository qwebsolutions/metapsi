using Metapsi.Syntax;
using System;
using System.Collections.Generic;

namespace Metapsi.Html;

public static class GlobalAttributeExtensions
{
    public static void SetId<T>(this AttributesBuilder<T> b, string id)
    {
        b.SetAttribute("id", id);
    }

    public static void SetSlot<T>(this AttributesBuilder<T> b, string slot)
    {
        b.SetAttribute("slot", slot);
    }

    public static void SetAttribute<TControl>(this PropsBuilder<TControl> b, string name, Var<string> value)
    {
        b.SetProperty(b.Props, b.Const(name), value);
    }

    public static void SetAttribute<TControl>(this PropsBuilder<TControl> b, string name, string value)
    {
        b.SetAttribute(name, b.Const(value));
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
    /// Sets boolean attribute
    /// <para>Note that boolean attributes have no 'false' value. If they exist, they are true</para>
    /// </summary>
    /// <typeparam name="TControl"></typeparam>
    /// <param name="b"></param>
    /// <param name="name"></param>
    public static void SetAttribute<TControl>(this PropsBuilder<TControl> b, string name)
    {
        b.SetProperty(b.Props, b.Const(name), b.Const(true));
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
        var classList = b.GetClassList();
        b.Clear(classList);
        b.Push(classList.As<List<string>>(), @class);
    }

    public static void SetClass<T>(this PropsBuilder<T> b, string @class)
    {
        b.SetClass(b.Const(@class));
    }

    private static Var<List<DynamicObject>> GetClassList<T>(this PropsBuilder<T> b)
    {
        var classList = b.GetProperty<List<DynamicObject>>(b.Props, b.Const("class"));
        return b.If(
            b.HasObject(classList),
            b => classList,
            b =>
            {
                var newList = b.NewCollection<DynamicObject>();
                b.SetProperty(b.Props, b.Const("class"), newList);
                return newList;
            });
    }

    public static PropsBuilder<T> AddClass<T>(this PropsBuilder<T> b, Var<string> @class)
    {
        b.Push(b.GetClassList(), @class.As<DynamicObject>());
        return b;
    }

    public static PropsBuilder<T> AddClass<T>(this PropsBuilder<T> b, Var<string> @class, Var<bool> enabled)
    {
        b.Push(b.GetClassList(), b.NewObj<DynamicObject>(
            b =>
            {
                b.SetProperty(b.Props, @class, enabled);
            }));

        return b;
    }

    public static PropsBuilder<T> AddClass<T>(this PropsBuilder<T> b, string @class)
    {
        return b.AddClass(b.Const(@class));
    }

    public static void AddStyle<T>(this PropsBuilder<T> b, string property, Var<string> value)
    {
        var currentStyle = b.GetProperty<object>(b.Props, "style");
        b.If(
            b.Not(b.HasObject(currentStyle)),
            b =>
            {
                b.SetProperty(b.Props, b.Const("style"), b.NewObj<object>());
            });

        currentStyle = b.GetProperty<object>(b.Props, "style");
        b.SetProperty(currentStyle, b.Const(property), value);
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

    public static void AddStylesheet(this SyntaxBuilder b, string href)
    {
        if (!href.StartsWith("http"))
        {
            // If it is not absolute path, make it absolute
            href = $"/{href}".Replace("//", "/");
        }

        var stylesheet = new DistinctTag("link");
        stylesheet.Attributes.Add("rel", "stylesheet");
        stylesheet.Attributes.Add("href", href);

        b.Const(stylesheet);
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
