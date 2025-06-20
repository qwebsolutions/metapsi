﻿using Metapsi.Syntax;
using System;
using System.Linq;
using System.Reflection;
using Metapsi.Html;
using System.Collections.Generic;

namespace Metapsi.Hyperapp
{
    public static class ViewBuilder
    {
        public const string VoidNodeTag = "--void--";

        /// <summary>
        /// Void nodes do not get added AT ALL to the DOM
        /// They're not just invisible/hidden, they are markers for 'do not add the result of this builder'
        /// </summary>
        /// <param name="b"></param>
        /// <returns></returns>
        public static Var<IVNode> VoidNode(this LayoutBuilder b)
        {
            return b.H(b.Const(VoidNodeTag), b.NewObj<object>());
        }

        public static Var<string> Url(this SyntaxBuilder b, Delegate handler)
        {
            var path = b.Const(Path(handler.Method));
            return path;
        }

        //public static Var<string> Url<TRoute>(this SyntaxBuilder b)
        //    where TRoute : Route.IGet
        //{
        //    var nestedTypeNames = typeof(TRoute).NestedTypeNames();
        //    string path = string.Join("/", nestedTypeNames);
        //    return b.Const($"/{path}");
        //}

        //public static Var<string> Url<TRoute, TPayload>(this SyntaxBuilder b)
        //    where TRoute : Route.IPost<TPayload>
        //{
        //    var nestedTypeNames = typeof(TRoute).NestedTypeNames();
        //    string path = string.Join("/", nestedTypeNames);
        //    return b.Const($"/{path}");
        //}

        //public static Var<string> Url<TRoute, TParam>(this SyntaxBuilder b, Var<TParam> param)
        //    where TRoute : Route.IGet<TParam>
        //{
        //    var nestedTypeNames = typeof(TRoute).NestedTypeNames();
        //    string path = string.Join("/", nestedTypeNames);
        //    return b.Concat(b.Const("/"), b.Const(path), b.Const("/"), b.AsString(param));
        //}

        public static Var<string> RootPath(this SyntaxBuilder b)
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

        public static Var<string> FormatDate(this SyntaxBuilder b, Var<DateTime> date, Var<string> locale, Var<object> options)
        {
            var dateString = date.As<string>();// for JS it IS a string
            var dateDate = b.ParseDate(dateString);
            var dateStringLocale = b.FormatLocaleDate(dateDate, locale, options);
            return dateStringLocale;
        }

        public static Var<string> FormatDate(this SyntaxBuilder b, Var<DateTime> date, string locale, Var<object> options)
        {
            return b.FormatDate(date, b.Const(locale), options);
        }

        public static Var<string> FormatDate(this SyntaxBuilder b, Var<DateTime> date, string locale)
        {
            return b.FormatDate(date, locale, b.NewObj<object>());
        }

        public static Var<string> EnglishDayName(this SyntaxBuilder b, Var<DateTime> date)
        {
            var formatParams = b.NewObj<object>();
            b.SetProperty(formatParams, b.Const("weekday"), b.Const("long"));

            return FormatDate(b, date, "en-gb", formatParams);
        }

        public static Var<string> EnglishDayAndShortMonth(this SyntaxBuilder b, Var<DateTime> date)
        {
            var formatParams = b.NewObj<object>();
            b.SetProperty(formatParams, b.Const("day"), b.Const("numeric"));
            b.SetProperty(formatParams, b.Const("month"), b.Const("short"));

            return FormatDate(b, date, "en-gb", formatParams);
        }

        public static Var<string> FormatNullableDate(this SyntaxBuilder b, Var<DateTime?> date, string locale)
        {
            return b.If(
                b.HasObject(date),
                b => FormatDate(b, date.As<DateTime>(), locale),
                b => b.Const(""));
        }

        public static Var<string> FormatDatetime(this SyntaxBuilder b, Var<DateTime> date, Var<string> languageFormat)
        {
            var dateString = date.As<string>();// for JS it IS a string
            var dateDate = b.ParseDate(dateString);
            var dateStringLocale = b.FormatLocaleDateTime(dateDate, languageFormat);

            return dateStringLocale;
        }

        public static Var<string> FormatDatetime(this SyntaxBuilder b, Var<DateTime> date, string languageFormat)
        {
            return b.FormatDatetime(date, b.Const(languageFormat));
        }

        public static Var<string> FormatDatetime(this SyntaxBuilder b, Var<DateTime> date)
        {
            return b.FormatDatetime(date, b.GetLocale());
        }

        public static Var<string> ItalianFormat(this SyntaxBuilder b, Var<DateTime> date)
        {
            return FormatDatetime(b, date, "it-IT");
        }
        public static Var<string> UKFormat(this SyntaxBuilder b, Var<DateTime> date)
        {
            var dateString = date.As<string>();// for JS it IS a string
            var dateTime = b.ParseDate(dateString);
            var formatParams = b.NewObj<object>();
            b.SetProperty(formatParams, b.Const("timeStyle"), b.Const("short"));
            b.SetProperty(formatParams, b.Const("dateStyle"), b.Const("short"));
            return b.FormatLocaleDateTime(dateTime, b.Const("en-gb"), formatParams);
        }

        public static Var<string> UKDate(this SyntaxBuilder b, Var<DateTime> date)
        {
            return FormatDate(b, date, "en-gb");
        }

        public static Var<string> UKNullableDate(this SyntaxBuilder b, Var<DateTime?> date)
        {
            return b.FormatNullableDate(date, "en-gb");
        }

        public static Var<string> USFormat(this SyntaxBuilder b, Var<DateTime> date)
        {
            return FormatDatetime(b, date, "en-us");
        }
        public static Var<string> ItalianFormat(this SyntaxBuilder b, Var<string> dateString)
        {
            return b.ItalianFormat(dateString.As<DateTime>());
        }


        public static string GetModuleStylesheetName(this SyntaxBuilder b, Assembly assembly)
        {
            return $"{assembly.GetName().Name}.css";
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
        public static void AddModuleStylesheet(this SyntaxBuilder b)
        {
            b.AddModuleStylesheet(System.Reflection.Assembly.GetCallingAssembly());
        }

        public static void AddModuleStylesheet(this SyntaxBuilder b, Assembly assembly)
        {
            var cssName = b.GetModuleStylesheetName(assembly);
            b.AddRequiredStylesheetMetadata(cssName);
            b.AddEmbeddedResourceMetadata(assembly, cssName);
        }

        /// <summary>
        /// Adds embedded resource script. File name is case-sensitive
        /// </summary>
        /// <param name="b"></param>
        /// <param name="assembly"></param>
        /// <param name="src"></param>
        /// <param name="type"></param>
        public static void AddRequiredScriptMetadata(this SyntaxBuilder b, Assembly assembly, string src, string type = "")
        {
            b.AddRequiredScriptMetadata(src, type);
            b.AddEmbeddedResourceMetadata(assembly, src);
        }

        public static void AddRequiredScriptMetadata(this SyntaxBuilder b, string src, string type = "")
        {
            var scriptTag = new HtmlTag("script");
            scriptTag.SetAttribute("src", src);
            if (!string.IsNullOrEmpty(type))
            {
                scriptTag.SetAttribute("type", type);
            }
            b.Metadata().AddRequiredTagMetadata(scriptTag);
        }

        public static void AddInlineScript(this SyntaxBuilder b, string scriptContent, string type = "")
        {
            HtmlTag scriptTag = new HtmlTag("script");
            if (!string.IsNullOrEmpty(type))
            {
                scriptTag.SetAttribute("type", type);
            }
            scriptTag.AddChild(new HtmlText(scriptContent));
            b.Metadata().AddRequiredTagMetadata(scriptTag);
        }
    }
}
