using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;

namespace Metapsi.Shoelace;

public class Option
{
    // TODO: Content is HTML, not string
    public string Content { get; set; } = string.Empty;
    public string Value { get; set; } = string.Empty;
    public bool Disabled { get; set; } = false;
}

public static partial class Control
{
    public static Var<HyperNode> Option(this LayoutBuilder b, Var<Option> props)
    {
        var option = b.SlNode("sl-option");
        b.SetAttr(option, Html.value, b.Get(props, x => x.Value));

        b.Add(option, b.TextNode(b.Get(props, x => x.Content)));

        var disabled = b.Get(props, x => x.Disabled);
        b.If(disabled, x => b.SetAttr(option, Html.disabled, disabled));
        return option;
    }
}

public static partial class OptionExtensions
{
    public static Var<List<Option>> MapOptions<T>(
        this SyntaxBuilder b,
        Var<List<T>> items,
        System.Linq.Expressions.Expression<Func<T, string>> getValue,
        System.Linq.Expressions.Expression<Func<T, string>> getLabel)
    {
        return b.Map(
            items,
            (b, s) =>
            {
                var value =b.Get(s, getValue);
                var label = b.Get(s, getLabel);
                var option = b.NewObj<Option>(b =>
                {
                    b.Set(x => x.Value, value);
                    b.Set(x => x.Content, label);
                });
                return option;
            });
    }

    public static Var<List<Option>> MapOptions<T>(
        this SyntaxBuilder b,
        Var<List<T>> items,
        System.Linq.Expressions.Expression<Func<T, Guid>> getValue,
        System.Linq.Expressions.Expression<Func<T, string>> getLabel)
        {
            return b.Map(
                items,
                (b, s) =>
                {
                    var value = b.AsString(b.Get(s, getValue));
                    var label = b.Get(s, getLabel);
                    var option = b.NewObj<Option>(b =>
                    {
                        b.Set(x => x.Value, value);
                        b.Set(x => x.Content, label);
                    });
                    return option;
                });
        }
}