using Metapsi.Hyperapp;
using Metapsi.Syntax;
using Metapsi.Html;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Metapsi.TomSelect;

public class TomSelectOption
{
    public string value { get; set; }
    public string text { get; set; }
}

public class Render
{
    public Func<TomSelectOption, Func<string, string>> option { get; set; }
    public Func<TomSelectOption, Func<string, string>> item { get; set; }
    public Func<TomSelectOption, Func<string, string>> option_create { get; set; }
    public Func<TomSelectOption, Func<string, string>> no_results { get; set; }
    public Func<TomSelectOption, Func<string, string>> not_loading { get; set; }
    public Func<TomSelectOption, Func<string, string>> optgroup { get; set; }
    public Func<TomSelectOption, Func<string, string>> optgroup_header { get; set; }
    public Func<TomSelectOption, Func<string, string>> loading { get; set; }
    public Func<TomSelectOption, Func<string, string>> dropdown { get; set; }
}

public class TomSelectSettings
{
    public bool allowEmptyOption { get; set; } = false;
    public string placeholder { get; set; }

    public string optionClass { get; set; } = "option";
    public string itemClass { get; set; } = "item";
    public Render render { get; set; }

    public List<TomSelectOption> options { get; set; } = new();
    public List<string> items { get; set; }= new();
    public DynamicObject plugins { get; set; } = new();

    public Action<object> onInitialize { get; set; }
    public Action<object> onDropdownOpen { get; set; }
    public Action<string, Action<object>> load { get; set; }

    /// <summary>
    /// Custom for Metapsi, edit directly the main div
    /// </summary>
    public Action<Element> editTsControl { get; set; } 
}

public partial class TomSelect
{
    public List<string> cssPaths { get; set; } = new List<string>()
    {
        "https://cdn.jsdelivr.net/npm/tom-select/dist/css/tom-select.css"
    };
    public TomSelectSettings settings { get; set; } = new();
}

public partial class TomSelect : IAllowsBinding<TomSelect>
{
    public ControlBinder<TomSelect> GetControlBinder()
    {
        return new ControlBinder<TomSelect>()
        {
            NewValueEventName = "change",
            GetEventValue = (b, @event) => b.GetProperty<string>(@event, b.Const("detail")),
            SetControlValue = Control.SetItem
        };
    }
}

public class ClearButtonConfiguration
{
    public string title { get; set; }
    public string className { get; set; }
    public Func<ClearButtonConfiguration, string> html { get; set; }
}

public static class Control
{
    public static Var<IVNode> TomSelect(this LayoutBuilder b, Action<PropsBuilder<TomSelect>> buildProps)
    {
        b.AddRequiredScriptMetadata("https://cdn.jsdelivr.net/npm/tom-select/dist/js/tom-select.complete.min.js", "module");
        b.AddRequiredScriptMetadata(typeof(TomSelect).Assembly, "metapsi.tomselect.js", "module");

        // Use own props builder to serialize the default values of the TomSelect class
        var tomSelectPropsBuilder = new PropsBuilder<TomSelect>(b) { Props = b.NewObj<TomSelect>() };
        buildProps(tomSelectPropsBuilder);

        return b.H("metapsi-tom-select", tomSelectPropsBuilder.Props.As<DynamicObject>());
    }

    public static void Configure<TProp>(
        this PropsBuilder<TomSelect> b,
        System.Linq.Expressions.Expression<System.Func<TomSelectSettings, TProp>> property,
        Var<TProp> value)
    {
        var configuration = b.Get(b.Props, x => x.settings);
        b.Set(configuration, property, value);
    }

    public static Var<List<TomSelectOption>> MapOptions<TItem, TId>(
        this SyntaxBuilder b,
        Var<List<TItem>> items,
        Var<System.Func<TItem, TId>> valueProp,
        Var<System.Func<TItem, string>> textProp)
    {
        return b.Map(items, (b, item) =>
        {
            var value = b.AsString(b.Call(valueProp, item));
            var label = b.AsString(b.Call(textProp, item));

            var option = b.NewObj<TomSelectOption>(b =>
            {
                b.Set(x => x.value, value);
                b.Set(x => x.text, label);
            });

            return option;
        });
    }

    public static Var<List<TomSelectOption>> MapOptions<TItem, TId>(
        this SyntaxBuilder b,
        Var<List<TItem>> items,
        System.Linq.Expressions.Expression<System.Func<TItem, TId>> valueProp,
        System.Linq.Expressions.Expression<System.Func<TItem, string>> textProp)
    {
        var getValue = b.Def((SyntaxBuilder b, Var<TItem> item) => b.Get(item, valueProp));
        var getText = b.Def((SyntaxBuilder b, Var<TItem> item) => b.Get(item, textProp));

        return b.MapOptions(items, getValue, getText);
    }

    public static Var<List<TomSelectOption>> MapOptions<TItem>(
            this SyntaxBuilder b,
            Var<List<TItem>> items,
            System.Linq.Expressions.Expression<System.Func<TItem, string>> valueProp,
            System.Linq.Expressions.Expression<System.Func<TItem, string>> labelProp)
    {
        return b.MapOptions<TItem, string>(items, valueProp, labelProp);
    }

    public static void SetOptions<TItem, TId>(
        this PropsBuilder<TomSelect> b,
        Var<List<TItem>> items,
        Var<System.Func<TItem, TId>> valueProp,
        Var<System.Func<TItem, string>> textProp)
    {
        b.Configure(x => x.options, b.MapOptions(items, valueProp, textProp));
    }

    public static void SetOptions<TItem, TId>(
        this PropsBuilder<TomSelect> b,
        Var<List<TItem>> items,
        System.Linq.Expressions.Expression<System.Func<TItem, TId>> valueProp,
        System.Linq.Expressions.Expression<System.Func<TItem, string>> labelProp)
    {
        b.Configure(x => x.options, b.MapOptions(items, valueProp, labelProp));
    }

    public static void SetItem<TId>(
        this PropsBuilder<TomSelect> b,
        Var<TId> item)
    {
        var itemValues = b.NewCollection<string>();
        b.Push(itemValues, b.AsString(item));
        b.Configure(x => x.items, itemValues);
    }

    public static void SetItems<TId>(
        this PropsBuilder<TomSelect> b,
        Var<List<TId>> items)
    {
        var itemValues = b.NewCollection<string>();
        b.PushRange(itemValues,
            b.Get(items,
            b.Def<SyntaxBuilder, TId, string>(Core.AsString),
            (items, asString) => items.Select(x => asString(x)).ToList()));

        b.Configure(x => x.items, itemValues);
    }

    public static void SetPlaceholder(
        this PropsBuilder<TomSelect> b,
        Var<string> placeholder)
    {
        b.Configure(x=>x.placeholder, placeholder);
    }

    public static void SetPlaceholder(
        this PropsBuilder<TomSelect> b,
        string placeholder)
    {
        b.SetPlaceholder(b.Const(placeholder));
    }

    public static void UseDropDownInput(this PropsBuilder<TomSelect> b)
    {
        var plugins = b.Get(b.Props, x => x.settings.plugins);
        b.SetProperty(plugins, b.Const("dropdown_input"), b.NewObj<object>());
    }

    public static void UseShoelaceClearButton(this PropsBuilder<TomSelect> b)
    {
        var config = b.NewObj<ClearButtonConfiguration>();
        var plugins = b.Get(b.Props, x => x.settings.plugins);
        b.Set(config, x => x.html, b.Def((SyntaxBuilder b, Var<ClearButtonConfiguration> config) =>
        {
            return b.Const("<sl-icon class='clear-button' name='x-circle-fill' library='system'></sl-icon>");
        }));
        b.SetProperty(plugins, b.Const("clear_button"), config);
    }

    public static void UseClearButton(this PropsBuilder<TomSelect> b, Var<ClearButtonConfiguration> configuration)
    {
        var plugins = b.Get(b.Props, x => x.settings.plugins);
        b.SetProperty(plugins, b.Const("clear_button"), configuration);
    }

    public static void UseClearButton(this PropsBuilder<TomSelect> b, string title)
    {
        b.UseClearButton(b.Const(new ClearButtonConfiguration()
        {
            title = title
        }));
    }

    private static List<string> Bootstrap4Styles = new List<string>()
    {
        "/tom-select.bootstrap4.css"
    };

    private static List<string> ShoelaceCssPaths = new List<string>()
    {
        "/metapsi.tomselect.shoelace.css",
    };

    public static void UseBootstrap4Styles(this PropsBuilder<TomSelect> b)
    {
        b.Set(b.Props, x => x.cssPaths, b.Const(Bootstrap4Styles));
    }

    public static void UseShoelaceStyles(
        this PropsBuilder<TomSelect> b)
    {
        b.Set(b.Props, x => x.cssPaths, b.Const(ShoelaceCssPaths));
        b.SetRenderFunction("option", (SyntaxBuilder b, Var<TomSelectOption> option, Var<Func<string, string>> escape) =>
        {
            return b.Concat(
                b.Const(
                    "<div class='item' style='display: flex; flex-direction:row; align-items: baseline;'>"),
                b.Const("<sl-icon library='system' name='check' style='padding-inline-end: var(--sl-spacing-2x-small);'></sl-icon>"),
                b.Const("<div>"),
                b.Call(escape, b.Get(option, x => x.text)),
                b.Const("</div>"),
                b.Const("</div>;"));
        });
        //b.SetRenderFunction("dropdown", (SyntaxBuilder b, Var<TomSelectOption> option, Var<Func<string, string>> escape) =>
        //{
        //    var popup = b.GetProperty<string>(b.Window(), b.Const("dropdownPopup"));
        //    b.SetProperty(popup, b.Const("active"), b.Const(true));
        //    b.If(b.HasObject(b.GetProperty<object>(popup, b.Const("reposition"))),
        //        b =>
        //        {
        //            b.RequestAnimationFrame(b.Def((SyntaxBuilder b) =>
        //            {
        //                b.RequestAnimationFrame(b.Def((SyntaxBuilder b) =>
        //                {
        //                    b.RequestAnimationFrame(b.Def((SyntaxBuilder b) =>
        //                    {
        //                        b.RequestAnimationFrame(b.Def((SyntaxBuilder b) =>
        //                        {
        //                            b.RequestAnimationFrame(b.Def((SyntaxBuilder b) =>
        //                            {
        //                                b.RequestAnimationFrame(b.Def((SyntaxBuilder b) =>
        //                                {
        //                                    b.CallOnObject(popup, "reposition");
        //                                }));
        //                            }));
        //                        }));
        //                    }));
        //                }));
        //            }));
        //        });
        //    return popup;
        //    //return b.Const("#popup-id");
        //    ////var popup = b.GetElementById(b.Const("popup-id"));
        //    ////b.Log("popup", popup);
        //    ////return popup.As<string>(); ;
        //    ////return b.Const("<sl-popup active></sl-popup>");
        //});

        b.Configure(x => x.editTsControl, b.Def((SyntaxBuilder b, Var<Element> tsControl) =>
        {
            var svg = b.Const("<svg xmlns=\"http://www.w3.org/2000/svg\" width=\"16\" height=\"16\" fill=\"currentColor\" class=\"bi bi-chevron-down\" viewBox=\"0 0 16 16\" part=\"svg\">\r\n      <path fill-rule=\"evenodd\" d=\"M1.646 4.646a.5.5 0 0 1 .708 0L8 10.293l5.646-5.647a.5.5 0 0 1 .708.708l-6 6a.5.5 0 0 1-.708 0l-6-6a.5.5 0 0 1 0-.708z\"></path>\r\n    </svg>");

            //var chevron = b.CreateElement(b.Const("sl-icon"));
            //b.SetAttribute(chevron, b.Const("name"), b.Const("chevron-down"));
            //b.SetAttribute(chevron, b.Const("library"), b.Const("system"));
            //b.SetProperty(chevron, b.Const("className"), b.Const("chevron"));


            //var dataSet = b.GetProperty<object>(chevron, b.Const("dataset"));
            //b.Log(dataSet);
            //b.SetProperty(dataSet, b.Const("tsItem"), b.Const(""));
            //b.CallOnObject(chevron, "addEventListener", b.Const("click"), b.Def((SyntaxBuilder b, Var<object> e) =>
            //{
            //    b.CallOnObject(e, "preventDefault");
            //    b.CallOnObject(e, "stopPropagation");
            //    b.Log("Click!", e);
            //}));
            var container = b.CreateElement(b.Const("div"));
            b.SetAttribute(container, b.Const("class"), b.Const("chevron"));
            b.SetProperty(container, b.Const("innerHTML"), svg);
            b.AppendChild(tsControl, container);
        }));
        //b.Configure(x => x.onDropdownOpen, b.Def((SyntaxBuilder b, Var<object> p) =>
        //{
        //    var rootNode = b.CallOnObject<IDomElement>(p, "getRootNode");
        //    //var host = b.GetProperty<IDomElement>(rootNode, b.Const("host"));
        //    b.Log("p", p);
        //    var children = b.GetProperty<List<IDomElement>>(rootNode, b.Const("children"));
        //    b.Log(children);

        //    b.SetProperty(
        //        p,
        //        b.Const("anchor"),
        //        b.Get(
        //            b.CallOnObject<List<object>>(rootNode, "querySelectorAll", b.Const(".ts-control")),
        //            x => x.First()));

        //    b.CallOnObject(p, "reposition");
        //    b.Log("called resposition on ", p);
        //}));
    }

    public static void SetRenderFunction(this PropsBuilder<TomSelect> b, string renderFn, Func<SyntaxBuilder, Var<TomSelectOption>, Var<Func<string,string>>, Var<string>> render)
    {
        // keep them all in variables because b.If on PropsBuilder does not set .Props
        var props = b.Props;
        var settings = b.Get(props, x => x.settings);
        var renderObject = b.Get(settings, x => x.render);
        
        b.If(
            b.Not(b.HasObject(renderObject)),
            b =>
            {
                b.Set(settings, x => x.render, b.NewObj<object>());
            });

        renderObject = b.Get(b.Props, x => x.settings.render);
        b.SetProperty(renderObject, b.Const(renderFn), b.Def(render));
    }

    //public static void SetRenderCssSelector(this PropsBuilder<TomSelect> b, string renderFn, Var<string> cssSelector)
    //{
    //    var props = b.Props;
    //    var settings = b.Get(props, x => x.settings);
    //    var renderObject = b.Get(settings, x => x.render);

    //    b.If(
    //        b.Not(b.HasObject(renderObject)),
    //        b =>
    //        {
    //            b.Set(settings, x => x.render, b.NewObj<object>());
    //        });

    //    renderObject = b.Get(b.Props, x => x.settings.render);
    //    b.SetProperty(renderObject, b.Const(renderFn), cssSelector);
    //}
}
