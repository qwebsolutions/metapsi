using Metapsi.Dom;
using Metapsi.Syntax;
using Metapsi.Ui;
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

namespace Metapsi.Hyperapp
{
    public static class ViewBuilder
    {
        public const string VoidNodeTag = "--void--";

        public static void AddChildren(this BlockBuilder b, Var<HyperNode> parent, params Func<BlockBuilder, Var<HyperNode>>[] children)
        {
            foreach (var buildChild in children)
            {
                b.AddIfNotVoid(parent, b.Call(buildChild));
            }
        }

        public static void AddChildren(this BlockBuilder b, Var<HyperNode> parent, Var<List<HyperNode>> children)
        {
            b.Foreach(children, (b, c) => b.AddIfNotVoid(parent, c));
        }

        public static Var<HyperNode> Node(this BlockBuilder b, string tag, string classNames = null)
        {
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
                b.AddIfNotVoid(node, b.Call(buildChild));
            }
            return node;
        }

        /// <summary>
        /// Void nodes do not get added AT ALL to the DOM
        /// They're not just invisible/hidden, they are markers for 'do not add the result of this builder'
        /// </summary>
        /// <param name="b"></param>
        /// <returns></returns>
        public static Var<HyperNode> VoidNode(this BlockBuilder b)
        {
            return b.Node(VoidNodeTag);
        }

        public static Var<HyperNode> Div(this BlockBuilder b, string classNames, Var<List<HyperNode>> children)
        {
            var container = b.Node("div", classNames);
            b.Foreach(children, (b, c) => b.AddIfNotVoid(container, c));
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
                b.AddIfNotVoid(container, b.Call(buildChild));
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
            b.Foreach(children, (b, c) => b.AddIfNotVoid(container, c));
            return container;
        }

        public static Var<HyperNode> Span(this BlockBuilder b, string classNames, params Func<BlockBuilder, Var<HyperNode>>[] children)
        {
            var span = b.Node("span", classNames);

            foreach (var buildChild in children)
            {
                b.AddIfNotVoid(span, b.Call(buildChild));
            }
            return span;
        }

        public static Var<HyperNode> Text(this BlockBuilder b, Var<string> text, Var<string> classNames)
        {
            var checkedText = b.If(b.HasValue(text), b => text, b => b.Const(""));
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
            var checkedText = b.If(b.HasValue(text), b => text, b => b.Const(""));
            return b.CallExternal<HyperNode>("hyperapp", "text", checkedText);
        }

        public static Var<HyperNode> Text(this BlockBuilder b, Var<string> text)
        {
            var checkedText = b.If(b.HasValue(text), b => text, b => b.Const(""));
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

        public static void AddIfNotVoid(this BlockBuilder b, Var<HyperNode> parent, Var<HyperNode> child)
        {
            b.If(b.Not(b.AreEqual(b.Get(child, x => x.tag), b.Const(VoidNodeTag))),
                b => b.Add(parent, child));
        }

        public static Var<HyperNode> Optional(this BlockBuilder b, Var<bool> ifValue, System.Func<BlockBuilder, Var<HyperNode>> buildControl)
        {
            return b.If(
                ifValue,
                b => b.Call(buildControl),
                b => b.VoidNode());
        }

        public static Var<HyperNode> ShowIfAny<T>(this BlockBuilder b, Var<IEnumerable<T>> collection, System.Func<BlockBuilder, Var<HyperNode>> buildControl)
        {
            return b.Optional(
                b.Get(collection, x => x.Any()),
                b => buildControl(b));
        }

        public static Var<HyperNode> ShowIfAny<T>(this BlockBuilder b, Var<List<T>> collection, System.Func<BlockBuilder, Var<HyperNode>> buildControl)
        {
            return b.Optional(
                b.Get(collection, x => x.Any()),
                b => buildControl(b));
        }

        public static Var<HyperNode> ListIfAny<T>(
            this BlockBuilder b,
            Var<List<T>> collection,
            System.Func<BlockBuilder, Var<HyperNode>> renderContainer,
            System.Func<BlockBuilder, Var<T>, Var<HyperNode>> renderItem,
            System.Func<BlockBuilder, Var<HyperNode>> renderEmpty)
        {
            return b.If(
                b.Get(collection, x => x.Any()),
                b =>
                {
                    var container = renderContainer(b);
                    b.AddChildren(container, b.Map(collection, renderItem));
                    return container;
                },
                b => renderEmpty(b));
        }

        public static Var<string> Url(this BlockBuilder b, Delegate handler)
        {
            var path = b.Const(Path(handler.Method));
            return path;
        }

        public static Var<string> Url<TRoute>(this BlockBuilder b)
            where TRoute : Route.IGet
        {
            var nestedTypeNames = typeof(TRoute).NestedTypeNames();
            string path = string.Join("/", nestedTypeNames);
            return b.Const($"/{path}");
        }

        public static Var<string> Url<TRoute, TPayload>(this BlockBuilder b)
            where TRoute : Route.IPost<TPayload>
        {
            var nestedTypeNames = typeof(TRoute).NestedTypeNames();
            string path = string.Join("/", nestedTypeNames);
            return b.Const($"/{path}");
        }

        public static Var<string> Url<TRoute, TParam>(this BlockBuilder b, Var<TParam> param)
            where TRoute : Route.IGet<TParam>
        {
            var nestedTypeNames = typeof(TRoute).NestedTypeNames();
            string path = string.Join("/", nestedTypeNames);
            return b.Concat(b.Const("/"), b.Const(path), b.Const("/"), b.AsString(param));
        }

        public static Var<string> RootPath(this BlockBuilder b)
        {
            return b.Const(string.Empty);
        }

        private static string Path(System.Reflection.MethodInfo methodInfo, object parameter = null)
        {
            var methodPath = $"/{methodInfo.DeclaringType.Name.ToLowerInvariant()}/{methodInfo.Name.ToLowerInvariant()}";

            if (parameter != null)
            {
                methodPath += $"/{parameter}";
            }

            return methodPath.Replace("//", "/");
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
            b.SetDynamic(props, property, value);
        }

        public static void SetAttrIfNotEmptyString(
            this BlockBuilder b,
            Var<HyperNode> node,
            DynamicProperty<string> property,
            Var<string> value)
        {
            b.If(
                b.HasValue(value),
                b =>
                {
                    var props = b.Get(node, x => x.props);
                    b.SetDynamic(props, property, value);
                });
        }

        public static void SetAttr<TProp>(
            this BlockBuilder b,
            Var<HyperNode> node,
            DynamicProperty<TProp> property,
            TProp value)
        {
            b.SetAttr(node, property, b.Const(value));
        }

        public static Var<TProp> GetAttr<TProp>(
            this BlockBuilder b,
            Var<HyperNode> node,
            DynamicProperty<TProp> property)
        {
            var props = b.Get(node, x => x.props);
            return b.GetDynamic(props, property);
        }

        public static Var<HyperNode> AddClass(
            this BlockBuilder b,
            Var<HyperNode> node,
            Var<string> newClass)
        {
            var props = b.Get(node, x => x.props);
            var current = b.GetDynamic(props, Html.@class);
            var withSpacer = b.Concat(current, b.Const(" "));
            var withNew = b.Concat(withSpacer, newClass);
            b.SetDynamic(props, Html.@class, withNew);
            return node;
        }

        public static Var<HyperNode> AddClass(
            this BlockBuilder b,
            Var<HyperNode> node,
            string newClass)
        {
            return b.AddClass(node, b.Const(newClass));
        }

        public static Var<HyperNode> AddStyle(
            this BlockBuilder b,
            Var<HyperNode> node,
            string property,
            Var<string> value)
        {
            var props = b.Get(node, x => x.props);
            var style = b.Ref(b.GetDynamic(props, new DynamicProperty<DynamicObject>("style")));

            b.If(
                b.Not(b.HasObject(b.GetRef(style))),
                b =>
                {
                    b.SetRef(style, b.NewObj<DynamicObject>());
                });

            b.SetDynamic(b.GetRef(style), new DynamicProperty<string>(property), value);

            b.SetAttr(node, new DynamicProperty<DynamicObject>("style"), b.GetRef(style));

            return node;
        }

        public static Var<HyperNode> AddStyle(
          this BlockBuilder b,
          Var<HyperNode> node,
          string property,
          string value)
        {
            return b.AddStyle(node, property, b.Const(value));
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

        public static Var<string> FormatDate(this BlockBuilder b, Var<DateTime> date, Var<string> locale, Var<DynamicObject> options)
        {
            var dateString = date.As<string>();// for JS it IS a string
            var dateDate = b.ParseDate(dateString);
            var dateStringLocale = b.FormatLocaleDate(dateDate, locale, options);
            return dateStringLocale;
        }

        public static Var<string> FormatDate(this BlockBuilder b, Var<DateTime> date, string locale, Var<DynamicObject> options)
        {
            return b.FormatDate(date, b.Const(locale), options);
        }

        public static Var<string> FormatDate(this BlockBuilder b, Var<DateTime> date, string locale)
        {
            return b.FormatDate(date, locale, b.NewObj<DynamicObject>());
        }

        public static Var<string> EnglishDayName(this BlockBuilder b, Var<DateTime> date)
        {
            var formatParams = b.NewObj<DynamicObject>();
            b.SetDynamic(formatParams, new DynamicProperty<string>("weekday"), b.Const("long"));

            return FormatDate(b, date, "en-gb", formatParams);
        }

        public static Var<string> EnglishDayAndShortMonth(this BlockBuilder b, Var<DateTime> date)
        {
            var formatParams = b.NewObj<DynamicObject>();
            b.SetDynamic(formatParams, new DynamicProperty<string>("day"), b.Const("numeric"));
            b.SetDynamic(formatParams, new DynamicProperty<string>("month"), b.Const("short"));

            return FormatDate(b, date, "en-gb", formatParams);
        }

        public static Var<string> FormatNullableDate(this BlockBuilder b, Var<DateTime?> date, string locale)
        {
            return b.If(
                b.HasObject(date),
                b => FormatDate(b, date.As<DateTime>(), locale),
                b => b.Const(""));
        }

        public static Var<string> FormatDatetime(this BlockBuilder b, Var<DateTime> date, Var<string> languageFormat)
        {
            var dateString = date.As<string>();// for JS it IS a string
            var dateDate = b.ParseDate(dateString);
            var dateStringLocale = b.FormatLocaleDateTime(dateDate, languageFormat);

            return dateStringLocale;
        }

        public static Var<string> FormatDatetime(this BlockBuilder b, Var<DateTime> date, string languageFormat)
        {
            return b.FormatDatetime(date, b.Const(languageFormat));
        }

        public static Var<string> FormatDatetime(this BlockBuilder b, Var<DateTime> date)
        {
            return b.FormatDatetime(date, b.GetLocale());
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
            b.SetDynamic(formatParams, new DynamicProperty<string>("timeStyle"), b.Const("short"));
            b.SetDynamic(formatParams, new DynamicProperty<string>("dateStyle"), b.Const("short"));
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

        public static void AddStylesheet(this BlockBuilder b, string href)
        {
            if (!href.StartsWith("http"))
            {
                // If it is not absolute path, make it absolute
                href = $"/{href}".Replace("//", "/");
            }

            b.Const(new LinkTag("stylesheet", href));
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
        public static void AddModuleStylesheet(this BlockBuilder b)
        {
            var assembly = System.Reflection.Assembly.GetCallingAssembly();
            var cssName = $"{assembly.GetName().Name}.css";

            b.AddStylesheet(cssName);
        }

        public static void AddScript(this BlockBuilder b, string src, string type = "")
        {
            if (!src.StartsWith("http"))
            {
                // If it is not absolute path, make it absolute
                src = $"/{src}".Replace("//", "/");
            }
            b.Const(new ExternalScriptTag(src, type));
        }
    }

    public static class Html
    {
        public static DynamicProperty<string> href = new(nameof(href));
        public static DynamicProperty<string> target = new(nameof(target));
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
