using Metapsi.Hyperapp;
using Metapsi.Syntax;
using Metapsi.Html;
using System;
using System.Collections.Generic;

namespace Metapsi.ChoicesJs;


public interface IChoices
{
    ChoicesOptions props { get; }
}

public interface IChoicesSelect
{

}

public class ChoicesText : IChoices
{
    public ChoicesOptions props { get; set; } = new ChoicesOptions();
}

public class ChoicesSelectOne : IChoices, IChoicesSelect
{
    public ChoicesOptions props { get; set; } = new ChoicesOptions();
}

public class ChoicesSelectMultiple : IChoices, IChoicesSelect
{
    public ChoicesOptions props { get; set; } = new ChoicesOptions();
}

public static partial class Control
{
    /// <summary>
    /// Choices.js 'text' control
    /// </summary>
    /// <param name="b"></param>
    /// <param name="buildProps"></param>
    /// <returns></returns>
    public static Var<IVNode> ChoicesText(
        this LayoutBuilder b,
        Action<PropsBuilder<ChoicesText>> buildProps)
    {
        return BuildChoices(b, "metapsi-choices-text", buildProps);
    }

    /// <summary>
    /// Choices.js 'select-one' control
    /// </summary>
    /// <param name="b"></param>
    /// <param name="buildProps"></param>
    /// <returns></returns>
    public static Var<IVNode> Choices(
        this LayoutBuilder b,
        Action<PropsBuilder<ChoicesSelectOne>> buildProps)
    {
        return BuildChoices(b, "metapsi-choices-select-one", buildProps);
    }

    /// <summary>
    /// Choices.js 'select-multiple' control
    /// </summary>
    /// <param name="b"></param>
    /// <param name="buildProps"></param>
    /// <returns></returns>
    public static Var<IVNode> ChoicesSelectMultiple(
        this LayoutBuilder b,
        Action<PropsBuilder<ChoicesSelectMultiple>> buildProps)
    {
        return BuildChoices(b, "metapsi-choices-select-multiple", buildProps);
    }

    private static Var<IVNode> BuildChoices<T>(LayoutBuilder b, string tag, Action<PropsBuilder<T>> buildProps)
        where T : IChoices, new()
    {
        var choicesMinJsResource = b.AddEmbeddedResourceMetadata(typeof(Metapsi.ChoicesJs.Control).Assembly, "choices.min.js");

        var choicesMinJsTag = new HtmlTag("script");
        choicesMinJsTag.SetAttribute("src", choicesMinJsResource);
        b.Metadata().AddRequiredTagMetadata(choicesMinJsTag);

        var metapsiChoicesJsResource = b.AddEmbeddedResourceMetadata(typeof(Metapsi.ChoicesJs.Control).Assembly, "metapsi.choices.js");
        var metapsiChoicesJsTag = new HtmlTag("script");
        metapsiChoicesJsTag.SetAttribute("src", metapsiChoicesJsResource);
        metapsiChoicesJsTag.SetAttribute("type", "module");
        b.Metadata().AddRequiredTagMetadata(choicesMinJsTag);

        var metapsiChoicesCssResource = b.AddEmbeddedResourceMetadata(typeof(Metapsi.ChoicesJs.Control).Assembly, "metapsi.choices.css");
        b.AddRequiredStylesheetMetadata(metapsiChoicesCssResource);

        return b.H(tag, buildProps);
    }

    public static void Configure<TControl, TProp>(
        this PropsBuilder<TControl> b,
        System.Linq.Expressions.Expression<System.Func<ChoicesOptions, TProp>> property,
        Var<TProp> value)
        where TControl : IChoices, new()
    {
        var configuration = b.Get(b.Props, x => x.props);
        b.Set(configuration, property, value);
    }

    public static void Configure<TControl, TProp>(
        this PropsBuilder<TControl> b,
        System.Linq.Expressions.Expression<System.Func<ChoicesOptions, TProp>> property,
        TProp value)
        where TControl : IChoices, new()
    {
        b.Configure(property, b.Const(value));
    }

    public static Var<List<Choice>> MapChoices<TItem, TId>(
        this LayoutBuilder b,
        Var<List<TItem>> items,
        Var<System.Func<TItem, TId>> valueProp,
        Var<System.Func<TItem, string>> labelProp,
        Var<TId> selectedId)
    {
        var choices = b.Map(items, (b, item) =>
        {
            var value = b.AsString(b.Call(valueProp, item));
            var label = b.AsString(b.Call(labelProp, item));

            var choice = b.NewObj<Choice>(b =>
            {
                b.Set(x => x.value, value);
                b.Set(x => x.label, label);
            });
            if (selectedId != null)
            {
                b.If(
                    b.AreEqual(selectedId, b.Call(valueProp, item)),
                    b =>
                    {
                        b.Set(choice, x => x.selected, b.Const(true));
                    });
            }

            return choice;
        });

        //var outList = b.NewCollection<Choice>();
        //var placeholder = b.NewObj<Choice>(b =>
        //{
        //    b.Set(x => x.value, b.Const(""));
        //    b.Set(x => x.label, b.Const("Not selected"));
        //});

        //b.SetDynamic(placeholder, DynamicProperty.Bool("placeholder"), b.Const(true));

        //b.Push(outList, placeholder);
        //b.Foreach(choices, (b, item) => b.Push(outList, item));
        return choices;
    }

    public static void SetChoices<TControl>(
        this PropsBuilder<TControl> b,
        Var<List<Choice>> choices)
        where TControl : IChoices, new()
    {
        b.Configure(x => x.choices, choices);
    }

    public static void SetChoices<TControl, TItem, TId>(
        this PropsBuilder<TControl> b,
        Var<List<TItem>> items,
        System.Linq.Expressions.Expression<System.Func<TItem, TId>> valueProp,
        System.Linq.Expressions.Expression<System.Func<TItem, string>> labelProp,
        Var<TId> selectedId)
        where TControl : IChoices, new()
    {
        var choices = MapChoices(b, items, valueProp, labelProp, selectedId);
        b.Configure(x => x.choices, choices);
    }

    public static Var<List<Choice>> MapChoices<TItem, TId>(
        this SyntaxBuilder b,
        Var<List<TItem>> items,
        System.Linq.Expressions.Expression<System.Func<TItem, TId>> valueProp,
        System.Linq.Expressions.Expression<System.Func<TItem, string>> labelProp,
        Var<TId> selectedId)
    {
        var choices = b.Map(items, (b, item) =>
        {
            var value = b.AsString(b.Get(item, valueProp));
            var label = b.AsString(b.Get(item, labelProp));

            var choice = b.NewObj<Choice>(b =>
            {
                b.Set(x => x.value, value);
                b.Set(x => x.label, label);
            });

            if (selectedId != null)
            {
                b.If(
                    b.AreEqual(selectedId, b.Get(item, valueProp)),
                    b =>
                    {
                        b.Set(choice, x => x.selected, b.Const(true));
                    });
            }
            return choice;
        });

        return choices;
    }

    public static Var<List<Choice>> MapChoices<TItem>(
            this SyntaxBuilder b,
            Var<List<TItem>> items,
            System.Linq.Expressions.Expression<System.Func<TItem, string>> valueProp,
            System.Linq.Expressions.Expression<System.Func<TItem, string>> labelProp,
            Var<string> selectedId)
    {
        return b.MapChoices<TItem, string>(items, valueProp, labelProp, selectedId);
    }

    //private static void AddStaticFiles(this LayoutBuilder b)
    //{
    //    b.AddRequiredStylesheetMetadata("metapsi.choices.css");
    //    b.AddRequiredScriptMetadata("choices.min.js");
    //    b.AddRequiredScriptMetadata("metapsi.choices.js", "module");
    //}
}
