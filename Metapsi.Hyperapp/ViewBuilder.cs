using Metapsi.Hyperapp;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Metapsi.Syntax
{
    public static class ViewBuilder
    {
        public static void AddChildren(this BlockBuilder b, Var<HyperNode> parent, params Func<BlockBuilder, Var<HyperNode>>[] children)
        {
            foreach (var buildChild in children)
            {
                b.Add(parent, b.Call(buildChild));
            }
        }

        public static Var<HyperNode> Node(this BlockBuilder b, string tag, string classNames = null)
        {
            //b.Const(new Import()
            //{
            //    Module = "hyperapp",
            //    Symbol = "app"
            //});

            Var<List<HyperNode>> newNodeChildren = b.NewCollection<HyperNode>();
            var props = b.NewObj<DynamicObject>();
            var newNode = b.CallExternal<HyperNode>("hyperapp", "h", b.Const(tag), props, newNodeChildren);

            if (!string.IsNullOrWhiteSpace(classNames))
            {
                b.SetAttr(newNode, Html.@class, b.Const(classNames));
            }

            return newNode;
        }

        public static Var<HyperNode> Node(this BlockBuilder b, string tag, Var<string> classNames)
        {
            Var<List<HyperNode>> newNodeChildren = b.NewCollection<HyperNode>();
            var props = b.NewObj<DynamicObject>();
            var newNode = b.CallExternal<HyperNode>("hyperapp", "h", b.Const(tag), props, newNodeChildren);

            b.If(b.HasValue(classNames),
                b =>
                {
                    b.SetAttr(newNode, Html.@class, classNames);
                });

            return newNode;
        }

        public static Var<HyperNode> Node(this BlockBuilder b, string tag, string classNames, params Func<BlockBuilder, Var<HyperNode>>[] children)
        {
            var node = b.Node(tag, classNames);
            foreach (var buildChild in children)
            {
                b.Add(node, b.Call(buildChild));
            }
            return node;
        }

        public static Var<HyperNode> Div(this BlockBuilder b, string classNames, Var<List<HyperNode>> children)
        {
            var container = b.Node("div", classNames);
            b.Foreach(children, (b, c) => b.Add(container, c));
            return container;
        }

        public static Var<HyperNode> Div(this BlockBuilder b, string classNames, params Func<BlockBuilder, Var<HyperNode>>[] children)
        {
            return b.Div(b.Const(classNames), children);
        }

        public static Var<HyperNode> Div(this BlockBuilder b, Var<string> classNames, params Func<BlockBuilder, Var<HyperNode>>[] children)
        {
            var container = b.Node("div", classNames);
            foreach (var buildChild in children)
            {
                b.Add(container, b.Call(buildChild));
            }
            return container;
        }

        public static Var<HyperNode> Div(this BlockBuilder b)
        {
            return b.Node("div");
        }

        public static Var<HyperNode> Div(this BlockBuilder b, string classNames)
        {
            return b.Node("div", classNames);
        }

        public static Var<HyperNode> Div(this BlockBuilder b, Var<string> classNames)
        {
            return b.Node("div", classNames);
        }

        public static Var<HyperNode> Span(this BlockBuilder b)
        {
            return b.Node("span");
        }

        public static Var<HyperNode> Span(this BlockBuilder b, Var<string> classNames)
        {
            return b.Node("span", classNames);
        }

        public static Var<HyperNode> Span(this BlockBuilder b, string classNames)
        {
            return b.Node("span", classNames);
        }

        public static Var<HyperNode> Span(this BlockBuilder b, string classNames, Var<List<HyperNode>> children)
        {
            var container = b.Node("span", classNames);
            b.Foreach(children, (b, c) => b.Add(container, c));
            return container;
        }

        public static Var<HyperNode> Span(this BlockBuilder b, string classNames, params Func<BlockBuilder, Var<HyperNode>>[] children)
        {
            var span = b.Node("span", classNames);

            foreach (var buildChild in children)
            {
                b.Add(span, b.Call(buildChild));
            }
            return span;
        }

        public static Var<HyperNode> Text(this BlockBuilder b, Var<string> text, Var<string> classNames)
        {
            var checkedText = b.If<string>(b.HasValue(text), b => text, b => b.Const(""));
            var textNode = b.CallExternal<HyperNode>("hyperapp", "text", checkedText);
            var span = b.Span(classNames);
            b.Add(span, textNode);
            return span;
        }

        public static Var<HyperNode> Text(this BlockBuilder b, Var<string> text, string classNames)
        {
            return b.Text(text, b.Const(classNames));
        }

        public static Var<HyperNode> Text(this BlockBuilder b, string text, string classNames)
        {
            return b.Text(b.Const(text), b.Const(classNames));
        }

        public static Var<HyperNode> Text(this BlockBuilder b, string text)
        {
            return b.Text(b.Const(text), b.Const(""));
        }



        public static Var<HyperNode> Text(this BlockBuilder b, Var<DateTime> dateTime)
        {
            var dateString = dateTime.As<string>();// for JS it IS a string
            var dateDate = b.ParseDate(dateString);
            var dateStringLocale = b.ItalianFormat(dateDate);
            return b.Text(dateStringLocale);
        }

        public static Var<HyperNode> TextNode(this BlockBuilder b, string text)
        {
            return TextNode(b, b.Const(text));
        }

        public static Var<HyperNode> TextNode(this BlockBuilder b, Var<string> text)
        {
            var checkedText = b.If<string>(b.HasValue(text), b => text, b => b.Const(""));
            return b.CallExternal<HyperNode>("hyperapp", "text", checkedText);
        }

        public static Var<HyperNode> Text(this BlockBuilder b, Var<string> text)
        {
            var checkedText = b.If<string>(b.HasValue(text), b => text, b => b.Const(""));
            var textNode = b.CallExternal<HyperNode>("hyperapp", "text", checkedText);
            var span = b.Span();
            b.Add(span, textNode);
            return span;
        }

        /// <summary>
        /// Adds child & returns it
        /// </summary>
        /// <param name="b"></param>
        /// <param name="parent"></param>
        /// <param name="child"></param>
        /// <returns></returns>
        public static Var<HyperNode> Add(this BlockBuilder b, Var<HyperNode> parent, Var<HyperNode> child)
        {
            var children = b.Get(parent, x => x.children);
            b.Push(children, child);
            return child;
        }

        public static void Add(this BlockBuilder b, Var<HyperNode> parent, Var<TextNode> child)
        {
            var children = b.Get(parent, x => x.children);
            b.Push(children, child.As<HyperNode>());// <- this conversion makes no statical sense
        }

        public static Var<HyperNode> Link(this BlockBuilder b, Var<string> text, Var<string> absoluteUrl)
        {
            var a = b.Node("a", "underline text-sky-500");
            var props = b.Get(a, x => x.props);
            b.Set(props, Html.href, absoluteUrl);
            b.Add(a, b.Text(text));
            return a;
        }
     
     
        public static Var<HyperNode> Link(this BlockBuilder b, Var<string> url, Var<HyperNode> content)
        {
            var a = b.Node("a", "");
            var props = b.Get(a, x => x.props);
            b.Set(props, Html.href, url);
            b.Add(a, content);
            return a;
        }

        public static Var<HyperNode> Link(
            this BlockBuilder b,
            Var<string> text,
            Func<CommandContext, HttpContext, Task<IResponse>> page,
            Var<string> parameter)
        {
            Var<string> absoluteUrl = b.Concat(b.RootPath(), b.Const($"/{page.Method.DeclaringType.Name}/{page.Method.Name}/"), parameter);
            return b.Link(text, absoluteUrl);
        }

        public static Var<HyperNode> Link(
            this BlockBuilder b,
            Var<string> text,
            Func<CommandContext, HttpContext, Task<IResponse>> page)
        {
            Var<string> absoluteUrl = b.Concat(b.RootPath(), b.Const($"/{page.Method.DeclaringType.Name}/{page.Method.Name}/"));
            return b.Link(text, absoluteUrl);
        }

        public static Var<HyperNode> Link(this BlockBuilder b, string classes, Var<string> url, params Func<BlockBuilder, Var<HyperNode>>[] children)
        {
            var a = b.Node("a", classes, children);
            b.SetAttr(a, Html.href, url);
            return a;
        }

        public static Var<HyperNode> Link<TState>(this BlockBuilder b, Var<string> text, Var<HyperType.Action<TState>> onClick)
        {
            var a = b.Node("a", "underline text-sky-500");
            var props = b.Get(a, x => x.props);
            b.Set(props, Html.href, b.Const("javascript:void(0);"));
            b.SetOnClick(a, onClick);
            b.Add(a, b.Text(text));
            return a;
        }

        public static void Add(this BlockBuilder b, Var<HyperNode> parent, Var<string> text)
        {
            var children = b.Get(parent, x => x.children);
            b.Push(children, b.Text(text).As<HyperNode>());
        }

        public static void SetAttr<TProp>(
            this BlockBuilder b,
            Var<HyperNode> node,
            DynamicProperty<TProp> property,
            Var<TProp> value)
        {
            var props = b.Get(node, x => x.props);
            b.Set(props, property, value);
        }

        public static void SetAttr<TProp>(
            this BlockBuilder b,
            Var<HyperNode> node,
            DynamicProperty<TProp> property,
            TProp value)
        {
            b.SetAttr(node, property, b.Const(value));
        }
        public static Var<HyperNode> AddClass(
            this BlockBuilder b,
            Var<HyperNode> node,
            Var<string> newClass)
        {
            var props = b.Get(node, x => x.props);
            var current = b.Get(props, Html.@class);
            var withSpacer = b.Concat(current, b.Const(" "));
            var withNew = b.Concat(withSpacer, newClass);
            b.Set(props, Html.@class, withNew);
            return node;
        }

        public static Var<HyperNode> AddClass(
            this BlockBuilder b,
            Var<HyperNode> node,
            string newClass)
        {
            return b.AddClass(node, b.Const(newClass));
        }
        public static Var<Guid> ToId(this BlockBuilder b, Var<string> value)
        {
            return b.If(b.HasValue(value), b => value.As<Guid>(), b => b.EmptyId());
        }

        public static Var<HyperNode> Image(this BlockBuilder b, Var<string> src, string stylingClasses = null)
        {
            var image = b.Node("img", stylingClasses);
            b.SetAttr(image, Html.src, src);
            return image;
        }

        public static Var<string> FormatDate(this BlockBuilder b, Var<DateTime> date, string locale, Var<DynamicObject> options)
        {
            var dateString = date.As<string>();// for JS it IS a string
            var dateDate = b.ParseDate(dateString);
            var dateStringLocale = b.FormatLocaleDate(dateDate, b.Const(locale), options);
            return dateStringLocale;
        }

        public static Var<string> FormatDate(this BlockBuilder b, Var<DateTime> date, string locale)
        {
            return b.FormatDate(date, locale, b.NewObj<DynamicObject>());
        }

        public static Var<string> EnglishDayName(this BlockBuilder b, Var<DateTime> date)
        {
            var formatParams = b.NewObj<DynamicObject>();
            b.Set(formatParams, new DynamicProperty<string>("weekday"), b.Const("long"));

            return FormatDate(b, date, "en-gb", formatParams);
        }

        public static Var<string> EnglishDayAndShortMonth(this BlockBuilder b, Var<DateTime> date)
        {
            var formatParams = b.NewObj<DynamicObject>();
            b.Set(formatParams, new DynamicProperty<string>("day"), b.Const("numeric"));
            b.Set(formatParams, new DynamicProperty<string>("month"), b.Const("short"));

            return FormatDate(b, date, "en-gb", formatParams);
        }

        public static Var<string> FormatNullableDate(this BlockBuilder b, Var<DateTime?> date, string locale)
        {
            return b.If(
                b.HasObject(date),
                b => FormatDate(b, date.As<DateTime>(), locale),
                b => b.Const(""));
        }

        public static Var<string> FormatDatetime(this BlockBuilder b, Var<DateTime> date, string languageFormat)
        {

            var dateString = date.As<string>();// for JS it IS a string
            var dateDate = b.ParseDate(dateString);
            var dateStringLocale = b.FormatLocaleDateTime(dateDate, b.Const(languageFormat));

            return dateStringLocale;
        }
        public static Var<string> ItalianFormat(this BlockBuilder b, Var<DateTime> date)
        {
            return FormatDatetime(b, date, "it-IT");
        }
        public static Var<string> UKFormat(this BlockBuilder b, Var<DateTime> date)
        {
            var dateString = date.As<string>();// for JS it IS a string
            var dateTime = b.ParseDate(dateString);
            var formatParams = b.NewObj<DynamicObject>();
            b.Set(formatParams, new DynamicProperty<string>("timeStyle"), b.Const("short"));
            b.Set(formatParams, new DynamicProperty<string>("dateStyle"), b.Const("short"));
            return b.FormatLocaleDateTime(dateTime, b.Const("en-gb"), formatParams);
        }

        public static Var<string> UKDate(this BlockBuilder b, Var<DateTime> date)
        {
            return FormatDate(b, date, "en-gb");
        }

        public static Var<string> UKNullableDate(this BlockBuilder b, Var<DateTime?> date)
        {
            return b.FormatNullableDate(date, "en-gb");
        }

        public static Var<string> USFormat(this BlockBuilder b, Var<DateTime> date)
        {
            return FormatDatetime(b, date, "en-us");
        }
        public static Var<string> ItalianFormat(this BlockBuilder b, Var<string> dateString)
        {
            return b.ItalianFormat(dateString.As<DateTime>());
        }
    }

    public static class Html
    {
        public static DynamicProperty<string> href = new(nameof(href));
        public static DynamicProperty<bool> disabled = new(nameof(disabled));
        public static DynamicProperty<string> @class = new(nameof(@class));
        public static DynamicProperty<string> action = new(nameof(action));
        public static DynamicProperty<string> name = new(nameof(name));
        public static DynamicProperty<string> id = new(nameof(id));
        public static DynamicProperty<string> type = new(nameof(type));
        public static DynamicProperty<string> value = new(nameof(value));
        public static DynamicProperty<string> method = new(nameof(method));
        public static DynamicProperty<string> innerHTML = new(nameof(innerHTML));
        public static DynamicProperty<string> placeholder = new(nameof(placeholder));
        public static DynamicProperty<int> tabindex = new(nameof(tabindex));
        public static DynamicProperty<bool> @checked = new(nameof(@checked));
        public static DynamicProperty<string> src = new(nameof(src));
        //public static DynamicProperty<object> onclick = new(nameof(onclick));
        public static DynamicProperty<string> min = new(nameof(min));
        public static DynamicProperty<string> max = new(nameof(max));
        public static DynamicProperty<string> step = new(nameof(step));
        public static DynamicProperty<string> title = new(nameof(title));

    }
}