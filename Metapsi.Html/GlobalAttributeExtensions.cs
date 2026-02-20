using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace Metapsi.Html;

public static class GlobalAttributeExtensions
{
    public static void SetId(this IHtmlAttributesBuilder b, string id)
    {
        b.SetAttribute("id", id);
    }

    public static void SetSlot(this IHtmlAttributesBuilder b, string slot)
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

    private static Var<List<object>> GetClassList<T>(this PropsBuilder<T> b)
    {
        var classList = b.GetProperty<List<object>>(b.Props, b.Const("class"));
        return b.If(
            b.HasObject(classList),
            b => classList,
            b =>
            {
                var newList = b.NewCollection<object>();
                b.SetProperty(b.Props, b.Const("class"), newList);
                return newList;
            });
    }

    public static PropsBuilder<T> AddClass<T>(this PropsBuilder<T> b, Var<string> @class)
    {
        b.Push(b.GetClassList(), @class.As<object>());
        return b;
    }

    public static PropsBuilder<T> AddClass<T>(this PropsBuilder<T> b, Var<string> @class, Var<bool> enabled)
    {
        b.Push(b.GetClassList(), b.NewObj<object>(
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

    public static void SetSlot<TProps>(this PropsBuilder<TProps> b, Var<string> slotName)
    {
        b.SetAttribute("slot", slotName);
    }

    public static void AddRequiredStylesheetMetadata(this SyntaxBuilder b, string href)
    {
        var stylesheet = new HtmlTag("link");
        stylesheet.SetAttribute("rel", "stylesheet");
        stylesheet.SetAttribute("href", href);

        b.Metadata().AddRequiredTagMetadata(stylesheet);
    }

    public static void AddRequiredStylesheetMetadata(this SyntaxBuilder b, ResourceMetadata href)
    {
        var stylesheet = new HtmlTag("link");
        stylesheet.SetAttribute("rel", "stylesheet");
        stylesheet.SetAttribute("href", href);

        b.Metadata().AddRequiredTagMetadata(stylesheet);
    }

    //public static void AddRequiredStylesheetMetadata(this SyntaxBuilder b, Assembly assembly, string href)
    //{
    //    b.AddRequiredStylesheetMetadata(href);
    //    b.AddEmbeddedResourceMetadata(assembly, href);
    //}

    public static void SetInnerHtml<T>(this PropsBuilder<T> b, Var<string> innerHtml)
    {
        b.SetAttribute("innerHTML", innerHtml);
    }

    public static void SetInnerHtml<T>(this PropsBuilder<T> b, string innerHtml)
    {
        b.SetInnerHtml(b.Const(innerHtml));
    }
}
