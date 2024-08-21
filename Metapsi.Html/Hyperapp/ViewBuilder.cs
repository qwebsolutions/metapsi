using Metapsi.Dom;
using Metapsi.Syntax;
using System;
using System.Linq;
using System.Reflection;
using Metapsi.Html;

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
            return b.CallExternal<IVNode>("hyperapp", "h", b.Const(VoidNodeTag), b.NewObj<DynamicObject>());
        }

        public static Var<string> Url(this SyntaxBuilder b, Delegate handler)
        {
            var path = b.Const(Path(handler.Method));
            return path;
        }

        public static Var<string> Url<TRoute>(this SyntaxBuilder b)
            where TRoute : Route.IGet
        {
            var nestedTypeNames = typeof(TRoute).NestedTypeNames();
            string path = string.Join("/", nestedTypeNames);
            return b.Const($"/{path}");
        }

        public static Var<string> Url<TRoute, TPayload>(this SyntaxBuilder b)
            where TRoute : Route.IPost<TPayload>
        {
            var nestedTypeNames = typeof(TRoute).NestedTypeNames();
            string path = string.Join("/", nestedTypeNames);
            return b.Const($"/{path}");
        }

        public static Var<string> Url<TRoute, TParam>(this SyntaxBuilder b, Var<TParam> param)
            where TRoute : Route.IGet<TParam>
        {
            var nestedTypeNames = typeof(TRoute).NestedTypeNames();
            string path = string.Join("/", nestedTypeNames);
            return b.Concat(b.Const("/"), b.Const(path), b.Const("/"), b.AsString(param));
        }

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

        public static Var<string> FormatDate(this LayoutBuilder b, Var<DateTime> date, Var<string> locale, Var<DynamicObject> options)
        {
            var dateString = date.As<string>();// for JS it IS a string
            var dateDate = b.ParseDate(dateString);
            var dateStringLocale = b.FormatLocaleDate(dateDate, locale, options);
            return dateStringLocale;
        }

        public static Var<string> FormatDate(this LayoutBuilder b, Var<DateTime> date, string locale, Var<DynamicObject> options)
        {
            return b.FormatDate(date, b.Const(locale), options);
        }

        public static Var<string> FormatDate(this LayoutBuilder b, Var<DateTime> date, string locale)
        {
            return b.FormatDate(date, locale, b.NewObj<DynamicObject>());
        }

        public static Var<string> EnglishDayName(this LayoutBuilder b, Var<DateTime> date)
        {
            var formatParams = b.NewObj<DynamicObject>();
            b.SetDynamic(formatParams, new DynamicProperty<string>("weekday"), b.Const("long"));

            return FormatDate(b, date, "en-gb", formatParams);
        }

        public static Var<string> EnglishDayAndShortMonth(this LayoutBuilder b, Var<DateTime> date)
        {
            var formatParams = b.NewObj<DynamicObject>();
            b.SetDynamic(formatParams, new DynamicProperty<string>("day"), b.Const("numeric"));
            b.SetDynamic(formatParams, new DynamicProperty<string>("month"), b.Const("short"));

            return FormatDate(b, date, "en-gb", formatParams);
        }

        public static Var<string> FormatNullableDate(this LayoutBuilder b, Var<DateTime?> date, string locale)
        {
            return b.If(
                b.HasObject(date),
                b => FormatDate(b, date.As<DateTime>(), locale),
                b => b.Const(""));
        }

        public static Var<string> FormatDatetime(this LayoutBuilder b, Var<DateTime> date, Var<string> languageFormat)
        {
            var dateString = date.As<string>();// for JS it IS a string
            var dateDate = b.ParseDate(dateString);
            var dateStringLocale = b.FormatLocaleDateTime(dateDate, languageFormat);

            return dateStringLocale;
        }

        public static Var<string> FormatDatetime(this LayoutBuilder b, Var<DateTime> date, string languageFormat)
        {
            return b.FormatDatetime(date, b.Const(languageFormat));
        }

        public static Var<string> FormatDatetime(this LayoutBuilder b, Var<DateTime> date)
        {
            return b.FormatDatetime(date, b.GetLocale());
        }

        public static Var<string> ItalianFormat(this LayoutBuilder b, Var<DateTime> date)
        {
            return FormatDatetime(b, date, "it-IT");
        }
        public static Var<string> UKFormat(this LayoutBuilder b, Var<DateTime> date)
        {
            var dateString = date.As<string>();// for JS it IS a string
            var dateTime = b.ParseDate(dateString);
            var formatParams = b.NewObj<DynamicObject>();
            b.SetDynamic(formatParams, new DynamicProperty<string>("timeStyle"), b.Const("short"));
            b.SetDynamic(formatParams, new DynamicProperty<string>("dateStyle"), b.Const("short"));
            return b.FormatLocaleDateTime(dateTime, b.Const("en-gb"), formatParams);
        }

        public static Var<string> UKDate(this LayoutBuilder b, Var<DateTime> date)
        {
            return FormatDate(b, date, "en-gb");
        }

        public static Var<string> UKNullableDate(this LayoutBuilder b, Var<DateTime?> date)
        {
            return b.FormatNullableDate(date, "en-gb");
        }

        public static Var<string> USFormat(this LayoutBuilder b, Var<DateTime> date)
        {
            return FormatDatetime(b, date, "en-us");
        }
        public static Var<string> ItalianFormat(this LayoutBuilder b, Var<string> dateString)
        {
            return b.ItalianFormat(dateString.As<DateTime>());
        }


        public static string GetModuleStylesheetName(this LayoutBuilder b, Assembly assembly)
        {
            return $"{assembly.GetName().Name}.css";
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
        public static void AddModuleStylesheet(this LayoutBuilder b)
        {
            b.AddModuleStylesheet(System.Reflection.Assembly.GetCallingAssembly());
        }

        public static void AddModuleStylesheet(this LayoutBuilder b, Assembly assembly)
        {
            var cssName = b.GetModuleStylesheetName(assembly);
            
            // Use resource file name for embedding
            StaticFiles.Add(assembly, cssName.Trim('/'));

            b.AddStylesheet(cssName);
        }


        /// <summary>
        /// Adds embedded resource script. File name is case-sensitive
        /// </summary>
        /// <param name="b"></param>
        /// <param name="assembly"></param>
        /// <param name="src"></param>
        /// <param name="type"></param>
        public static void AddScript(this LayoutBuilder b, Assembly assembly, string src, string type = "")
        {
            // Use resource file name for embedding
            StaticFiles.Add(assembly, src.Trim('/'));
            
            // Use URL for script path
            if (!src.StartsWith('/'))
            {
                src = "/" + src.ToLowerInvariant();
            }

            DistinctTag scriptTag = new DistinctTag("script");
            scriptTag.SetAttribute("src", src);
            if (!string.IsNullOrEmpty(type))
            {
                scriptTag.SetAttribute("type", type);
            }
            b.Const(scriptTag);
        }

        public static void AddScript(this LayoutBuilder b, string src, string type = "")
        {
            if (!src.StartsWith("http"))
            {
                // If it is not absolute path, make it absolute
                src = $"/{src}".Replace("//", "/");
            }
            DistinctTag scriptTag = new DistinctTag("script");
            scriptTag.SetAttribute("src", src);
            if (!string.IsNullOrEmpty(type))
            {
                scriptTag.SetAttribute("type", type);
            }
            b.Const(scriptTag);
        }

        public static void AddInlineScript(this SyntaxBuilder b, string scriptContent, string type = "")
        {
            DistinctTag scriptTag = new DistinctTag("script");
            if (!string.IsNullOrEmpty(type))
            {
                scriptTag.SetAttribute("type", type);
            }
            scriptTag.AddChild(new HtmlText(scriptContent));
            b.Const(scriptTag);
        }
    }
}
