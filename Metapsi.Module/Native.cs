using System;
using System.Collections.Generic;
using System.Linq;
using Metapsi.Syntax;

namespace Metapsi.Syntax
{
    public static class Native
    {
        public static Var<T> GetProperty<T>(this BlockBuilder b, IVariable from, Var<string> propertyName)
        {
            return b.CallExternal<T>(nameof(Native), nameof(GetProperty), from, propertyName);
        }

        public static void SetProperty(this BlockBuilder b, IVariable into, Var<string> propertyName, IVariable value)
        {
            b.CallExternal(nameof(Native), nameof(SetProperty), into, propertyName, value);
        }

        public static Var<bool> AreEqual<T>(this BlockBuilder b, Var<T> v1, Var<T> v2)
        {
            return b.CallExternal<bool>(nameof(Native), nameof(AreEqual), v1, v2);
        }

        public static Var<string> AsString<T>(this BlockBuilder b, Var<T> o)
        {
            return b.CallExternal<string>(nameof(Native), nameof(AsString), o);
        }

        public static Var<string> Concat(this BlockBuilder b, Var<string> s1, Var<string> s2, params Var<string>[] other)
        {
            var args = b.NewCollection<string>();
            b.Push(args, s1);
            b.Push(args, s2);
            foreach (var extra in other)
            {
                b.Push(args, extra);
            }

            return b.CallExternal<string>(nameof(Native), nameof(Concat), args);
        }

        public static Var<string> Trim(this BlockBuilder b, Var<string> s)
        {
            return b.CallExternal<string>(nameof(Native), nameof(Trim), s);
        }

        public static Var<List<T>> List<T>(this BlockBuilder b, params Var<T>[] items)
        {
            var outList = b.NewCollection<T>();

            foreach (var item in items)
            {
                b.Push(outList, item);
            }

            return outList;
        }

        public static void Push<T>(this BlockBuilder b, Var<List<T>> onCollection, Var<T> item)
        {
            b.CallExternal(nameof(Native), nameof(Push), onCollection, item);
        }

        public static Var<bool> Not(this BlockBuilder b, Var<bool> v)
        {
            return b.CallExternal<bool>(nameof(Native), nameof(Not), v);
            //return b.CallInline<bool>("(v) => !v", v);
        }

        public static Var<bool> IsEmpty(this BlockBuilder b, Var<string> v)
        {
            return b.CallExternal<bool>(nameof(Native), "IsEmptyString", v);
            //return b.CallInline<bool>("(s) => !s", var);
        }

        public static Var<bool> IsEmpty(this BlockBuilder b, Var<object> v)
        {
            return b.CallExternal<bool>(nameof(Native), "IsEmptyObject", v);
            //return b.CallInline<bool>("(s) => !s", var);
        }

        public static Var<bool> IsEmpty(this BlockBuilder b, Var<Guid> v)
        {
            return b.CallExternal<bool>(nameof(Native), "IsEmptyGuid", v);
            //return b.CallInline<bool>("(id) => { if(id=== '00000000-0000-0000-0000-000000000000') return true; return !id}", var);
        }

        public static Var<bool> IsNull(this BlockBuilder b, IVariable v)
        {
            return b.CallExternal<bool>(nameof(Native), nameof(IsNull), v);
            //return b.CallInline<bool>("(s) => !s", var);
        }

        public static Var<bool> HasValue(this BlockBuilder b, Var<string> v)
        {
            return b.CallExternal<bool>(nameof(Native), nameof(HasValue), v);
            //return b.CallInline<bool>("(s) => !(!s)", var);
        }

        public static Var<bool> HasId(this BlockBuilder b, Var<Guid> v)
        {
            return b.CallExternal<bool>(nameof(Native), nameof(HasId), v);
            //return b.CallInline<bool>("(id) => { if(id=== '00000000-0000-0000-0000-000000000000') return false; return id}", var);
        }

        public static Var<bool> HasObject<T>(this BlockBuilder b, Var<T> v)
        {
            return b.CallExternal<bool>(nameof(Native), nameof(HasObject), v);
            //return b.CallInline<bool>("(s) => !(!s)", var);
        }

        public static Var<bool> HasFunction<T>(this BlockBuilder b, Var<T> v) where T : System.Delegate
        {
            return b.CallExternal<bool>(nameof(Native), nameof(HasFunction), v);
            //return b.CallInline<bool>("(s) => !(!s)", var);
        }

        public static Var<Guid> NewId(this BlockBuilder b)
        {
            return b.CallExternal<Guid>(nameof(Native), nameof(NewId));
        }

        public static Var<Guid> EmptyId(this BlockBuilder b)
        {
            return b.CallExternal<Guid>(nameof(Native), nameof(EmptyId));
        }

        public static Var<Guid> ParseId(this BlockBuilder b, Var<string> id)
        {
            return b.CallExternal<Guid>(nameof(Native), nameof(ParseId), id);
        }

        public static Var<int> ParseInt(this BlockBuilder b, Var<string> v)
        {
            return b.CallExternal<int>(nameof(Native), nameof(ParseInt), v);
        }
        public static Var<decimal> ParseDecimal(this BlockBuilder b, Var<string> v)
        {
            return b.CallExternal<decimal>(nameof(Native), nameof(ParseDecimal), v);
        }
        public static Var<string> ToLowercase(this BlockBuilder b, Var<string> text)
        {
            return b.CallExternal<string>(nameof(Native), nameof(ToLowercase), text);
        }

        public static Var<bool> EndsWith(this BlockBuilder b, Var<string> larger, Var<string> end)
        {
            return b.CallExternal<bool>(nameof(Native), nameof(EndsWith), larger, end);
        }

        //public static Var<string> VarToString(this BlockBuilder b, IVariable variable)
        //{
        //    return b.CallExternal<string>(nameof(Native), nameof(ToString), variable);
        //}

        public static Var<TScalar> ParseScalar<TScalar>(this BlockBuilder b, Var<string> value)
        {
            var r = b.Ref<TScalar>(b.Const(string.Empty).As<TScalar>());

            if (typeof(TScalar) == typeof(int))
                b.SetRef(r, b.ParseInt(value).As<TScalar>());
            else if (typeof(TScalar) == typeof(string))
                b.SetRef(r, value.As<TScalar>());
            else if (typeof(TScalar) == typeof(Guid))
                b.SetRef(r, b.ParseId(value).As<TScalar>());
            else if (typeof(TScalar) == typeof(decimal))
                b.SetRef(r, b.ParseDecimal(value).As<TScalar>());
            else throw new NotSupportedException($"Cannot parse type {typeof(TScalar).Name}");

            return b.GetRef(r);
        }


        public static Var<string> JoinStrings(this BlockBuilder b, Var<string> separator, Var<List<string>> values)
        {
            var checkedValues = b.Get(values, x => x.Where( x=> x != null && x != "").ToList());
            return b.CallExternal<string>(nameof(Native), nameof(Concat), b.Join(separator, checkedValues));
        }

        public static Var<List<T>> Join<T>(this BlockBuilder b, Var<T> separator, Var<List<T>> items)
        {
            var outList = b.NewCollection<T>();
            b.Foreach(items, (b, item) =>
            {
                b.If(b.Get(outList, x => x.Any()),
                    b => b.Push(outList, separator));
                b.Push(outList, item);
            });

            return outList;
        }

        public static Var<string> Replace(this BlockBuilder b, Var<string> initialString, Var<string> oldText, Var<string> newText)
        {
            return b.CallExternal<string>(nameof(Native), nameof(Replace), initialString, oldText, newText);
        }

        public static Var<int> GetHours(this BlockBuilder b, Var<DateTime> dateTime)
        {
            return b.CallExternal<int>(nameof(Native), nameof(GetHours), dateTime);
        }


        public static Var<int> GetMinutes(this BlockBuilder b, Var<DateTime> dateTime)
        {
            return b.CallExternal<int>(nameof(Native), nameof(GetMinutes), dateTime);
        }

        public static Var<int> GetHours(this BlockBuilder b, Var<DateTime?> dateTime)
        {
            return b.CallExternal<int>(nameof(Native), nameof(GetHours), dateTime);
        }

        public static Var<int> Floor<T>(this BlockBuilder b, Var<T> n)
        {
            return b.CallExternal<int>(nameof(Native), nameof(Floor), n);
        }

        public static Var<int> GetMinutes(this BlockBuilder b, Var<DateTime?> dateTime)
        {
            return b.CallExternal<int>(nameof(Native), nameof(GetMinutes), dateTime);
        }

        public static Var<bool> Includes(this BlockBuilder b, Var<string> large, Var<string> small)
        {
            return b.CallExternal<bool>(nameof(Native), nameof(Includes), large, small);
        }

        public static Var<List<string>> Split(this BlockBuilder b, Var<string> inputString, Var<string> separator)
        {
            return b.CallExternal<List<string>>(nameof(Native), nameof(Split), inputString, separator);
        }

        public static Var<string> SubstringStart(this BlockBuilder b, Var<string> inputString, Var<string> start)
        {
            return b.CallExternal<string>(nameof(Native), nameof(SubstringStart), inputString, start);
        }
        public static Var<string> SubstringStartLength(this BlockBuilder b, Var<string> inputString, Var<string> start, Var<string> end)
        {
            return b.CallExternal<string>(nameof(Native), nameof(SubstringStartLength), inputString, start, end);
        }

        public static Var<string> Slice(this BlockBuilder b, Var<string> inputString,Var<int> start, Var<int> end)
        {
            return b.CallExternal<string>(nameof(Native), nameof(Slice), inputString, start, end);
        }

        public static Var<int> StringLength(this BlockBuilder b, Var<string> inputString)
        {
            return b.Get(inputString.As<DynamicObject>(), new DynamicProperty<int>("length"));
        }
        public static Var<int> Minus(this BlockBuilder b, Var<int> number)
        {
            return b.CallExternal<int>(nameof(Native), nameof(Minus), number);
        }

        public static Var<int> Add(this BlockBuilder b, Var<int> firstNumber, Var<int> secondNumber)
        {
            return b.CallExternal<int>(nameof(Native), nameof(Add), firstNumber, secondNumber);
        }

        public static Var<string> ToFixed(this BlockBuilder b, Var<decimal> number, Var<int> digits)
        {
            return b.CallExternal<string>(nameof(Native), nameof(ToFixed), number, digits);
        }

        public static Var<TResult> TryCatchReturn<TResult>(this BlockBuilder b, Var<Func<TResult>> onTry, Var<Func<DynamicObject, TResult>> onCatch)
        {
            return b.CallExternal<TResult>(nameof(Native), nameof(TryCatchReturn), onTry, onCatch);
        }

        public static Var<T> Clone<T>(this BlockBuilder b, Var<T> v)
        {

            if (ModuleBuilder.ScalarTypes.Contains(typeof(T)))
            {
                return v;
            }
            else if (typeof(T).IsAssignableTo(typeof(System.Collections.IEnumerable)))
            {
                return b.CallExternal<T>(nameof(Native), "CloneCollection", v);
            }
            else
            {
                return b.CallExternal<T>(nameof(Native), "CloneObject", v);
            }
        }

        public static Var<T> Deserialize<T>(this BlockBuilder b, Var<string> json)
        {
            return b.CallExternal<T>(nameof(Native), nameof(Deserialize), json);
        }

        public static Var<string> Serialize<T>(this BlockBuilder b, Var<T> obj)
        {
            return b.CallExternal<string>(nameof(Native), nameof(Serialize), obj);
        }

        public static Var<List<IVariable>> ObjectValues<T>(this BlockBuilder b, Var<T> obj)
        {
            return b.CallExternal<List<IVariable>>(nameof(Native), nameof(ObjectValues), obj);
        }

        public static Var<string> ConcatObjectValues<T>(this BlockBuilder b, Var<T> obj)
        {
            var result = b.JoinStrings(
                b.Const("|"),
                b.Map(
                    b.ObjectValues(obj),
                    b.Def((BlockBuilder b, Var<IVariable> v) => b.If(b.HasObject(v), b => b.AsString(v), b => b.Const(string.Empty)))));
            return result;
        }

        public static Var<DateTime> ParseDate(this BlockBuilder b, Var<string> stringDate)
        {
            return b.CallExternal<DateTime>(nameof(Native), nameof(ParseDate), stringDate);
        }

        public static Var<string> FormatLocaleDateTime(this BlockBuilder b, Var<DateTime> dateTime, Var<string> localeCode)
        {
            return b.CallExternal<string>(nameof(Native), nameof(FormatLocaleDateTime), dateTime, localeCode);
        }
        public static Var<string> FormatLocaleDateTime(this BlockBuilder b, Var<DateTime?> dateTime, Var<string> localeCode)
        {
            return b.CallExternal<string>(nameof(Native), nameof(FormatLocaleDateTime), dateTime, localeCode);
        }

        public static Var<string> FormatLocaleDateTime(this BlockBuilder b, Var<DateTime> dateTime, Var<string> localeCode, Var<DynamicObject> options)
        {
            return b.CallExternal<string>(nameof(Native), nameof(FormatLocaleDateTime), dateTime, localeCode, options);
        }

        public static Var<string> FormatLocaleDate(this BlockBuilder b, Var<DateTime> dateTime, Var<string> localeCode, Var<DynamicObject> options)
        {
            return b.CallExternal<string>(nameof(Native), nameof(FormatLocaleDate), dateTime, localeCode, options);
        }


        public static void Log(this BlockBuilder b, IVariable v)
        {
            b.CallExternal(nameof(Native), nameof(Log), v);
        }

        public static void Log(this BlockBuilder b, Var<string> tag, IVariable v)
        {
            b.Log(tag);
            b.Log(v);
        }

        public static void Log(this BlockBuilder b, string tag, IVariable v)
        {
            b.Log(b.Const(tag), v);
        }

        public static void Log(this BlockBuilder b, string tag)
        {
            b.Log(b.Const(tag));
        }

        public static Var<DomElement> GetElementById(this BlockBuilder b, Var<string> id)
        {
            return b.CallExternal<DomElement>(nameof(Native), nameof(GetElementById), id);
        }

        public static Var<DomElement> CreateElement(this BlockBuilder b, Var<string> tag)
        {
            return b.CallExternal<DomElement>(nameof(Native), nameof(CreateElement), tag);
        }

        public static void AppendChild(this BlockBuilder b, Var<DomElement> parent, Var<DomElement> child)
        {
            b.CallExternal<DomElement>(nameof(Native), nameof(AppendChild), parent, child);
        }

        public static void DispatchEvent(this BlockBuilder b, Var<string> eventName)
        {
            b.CallExternal(nameof(Native), nameof(DispatchEvent), eventName);
        }

        public static void RequestAnimationFrame(this BlockBuilder b, Var<Action> action)
        {
            b.CallExternal(nameof(Native), nameof(RequestAnimationFrame), action);
        }

        public static void Focus(this BlockBuilder b, Var<DomElement> domElement, bool scroll)
        {
            b.CallExternal(nameof(Native), nameof(Focus), domElement, b.Const(scroll));
        }

        public static Var<string> GetUrl(this BlockBuilder b)
        {
            return b.CallExternal<string>(nameof(Native), nameof(GetUrl));
        }

        public static void SetUrl(this BlockBuilder b, Var<string> url)
        {
            b.CallExternal(nameof(Native), nameof(SetUrl), url);
        }

        public static void ScrollIntoView(this BlockBuilder b, Var<DomElement> domElement)
        {
            b.CallExternal(nameof(Native), nameof(ScrollIntoView), domElement);
        }

        public static void ScrollBy(this BlockBuilder b, Var<int> x, Var<int> y)
        {
            b.CallExternal(nameof(Native), nameof(ScrollBy), x, y);
        }

        public static void ScrollTo(this BlockBuilder b, Var<int> x, Var<int> y)
        {
            b.CallExternal(nameof(Native), nameof(ScrollTo), x, y);
        }

        public static Var<string> ToBase64<T>(this BlockBuilder b, Var<T> input)
        {
            return b.CallExternal<string>(nameof(Native), nameof(ToBase64), input);
        }

        public static void FileToBase64(
            this BlockBuilder b,
            Var<DynamicObject> file,
            Var<Action<DynamicObject, string>> onResult,
            Var<Action<DynamicObject>> onError)
        {
            b.CallExternal(nameof(Native), nameof(FileToBase64), file, onResult, onError);
        }

        //public static void SetPageTitle(this BlockBuilder b, string title)
        //{
        //    b.Const(new TitleTag(title));
        //}

        //public static void SetFavicon(this BlockBuilder b, string href)
        //{
        //    b.Const(new FaviconTag(href));
        //}

        //public static void SetBodyClass(this BlockBuilder b, string css)
        //{
        //    b.Const(new BodyTag(css));
        //}
    }

    public class DomElement
    {
        public string innerHTML { get; set; }
        public List<DomElement> children { get; set; }
    }
}

