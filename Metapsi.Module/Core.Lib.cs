using System;
using System.Collections.Generic;
using System.Linq;
using Metapsi;

namespace Metapsi.Syntax
{
    public static partial class Core
    {
        private static Var<T> ImportCore<T>(SyntaxBuilder b, string symbol)
        {
            var metapsiCore = b.moduleBuilder.Module.Metadata.AddEmbeddedResourceMetadata(typeof(Core).Assembly, "metapsi.core.js");
            return b.ImportName<T>(metapsiCore, symbol);
        }

        private static Var<Delegate> ImportFn(SyntaxBuilder b, string symbol)
        {
            return ImportCore<Delegate>(b, symbol);
        }

        private static Var<T> CallCore<T>(this SyntaxBuilder b, string symbol, params IVariable[] args)
        {
            return b.CallDynamic<T>(ImportFn(b, symbol), args);
        }

        private static void CallCore(this SyntaxBuilder b, string symbol, params IVariable[] args)
        {
            b.CallDynamic(ImportFn(b, symbol), args);
        }

        [Obsolete]
        private static void CallExternal(this SyntaxBuilder b, string moduleName, string symbol, params IVariable[] args)
        {
            b.CallDynamic(ImportFn(b, symbol), args);
        }

        [Obsolete]
        private static Var<T> CallExternal<T>(this SyntaxBuilder b, string moduleName, string symbol, params IVariable[] args)
        {
            return b.CallDynamic<T>(ImportFn(b, symbol), args);
        }

        public static Var<T> GetProperty<T>(this SyntaxBuilder b, IVariable from, Var<string> propertyName)
        {
            var import = ImportCore<Delegate>(b, "GetProperty");
            return b.CallDynamic<T>(import, from, propertyName);
        }

        public static Var<T> GetProperty<T>(this SyntaxBuilder b, IVariable from, string propertyName)
        {
            return b.GetProperty<T>(from, b.Const(propertyName));
        }

        //public static Var<T> GetOrCreateProperty<T>(this SyntaxBuilder b, IVariable from, Var<string> propertyName)
        //    where T : new()
        //{
        //    var props = b.GetProperty<T>(from, propertyName);
        //    b.If(
        //        b.Not(b.HasObject(props)),
        //        (SyntaxBuilder b) =>
        //        {
        //            b.SetProperty(from, propertyName, b.NewObj<T>());
        //        });

        //    return b.GetProperty<T>(from, propertyName);
        //}

        //public static Var<T> GetOrCreateProperty<T>(this SyntaxBuilder b, IVariable from, string propertyName)
        //    where T : new()
        //{
        //    return b.GetOrCreateProperty<T>(from, b.Const(propertyName));
        //}

        public static Var<TResult> CallOnObject<TResult>(this SyntaxBuilder b, IVariable @object, string function, params IVariable[] parameters)
        {
            var callOnObject = ImportCore<Delegate>(b, "CallOnObject");
            List<IVariable> allParams = new List<IVariable>();
            allParams.Add(@object);
            allParams.Add(b.Const(function));
            allParams.AddRange(parameters);
            return b.CallDynamic<TResult>(callOnObject, allParams.ToArray());
        }

        public static void CallOnObject(this SyntaxBuilder b, IVariable @object, string function, params IVariable[] parameters)
        {
            // would return undefined, just ignore the result
            CallOnObject<object>(b, @object, function, parameters);
        }

        public static Var<string> TypeOf(this SyntaxBuilder b, IVariable @object)
        {
            return b.CallDynamic<string>(ImportCore<Delegate>(b, "TypeOf"), @object);
        }

        public static Var<bool> AreEqual<T>(this SyntaxBuilder b, Var<T> v1, Var<T> v2)
        {
            var areEqual = ImportCore<Delegate>(b, "AreEqual");
            return b.CallDynamic<bool>(areEqual, v1, v2);
        }

        public static Var<string> AsString(this SyntaxBuilder b, IVariable o)
        {
            return b.CallDynamic<string>(ImportFn(b, "AsString"), o);
        }

        //public static Var<TResult> If<TResult>(
        //    this SyntaxBuilder b,
        //    Var<bool> check,
        //    Var<Func<TResult>> ifTrue,
        //    Var<Func<TResult>> ifFalse)
        //{
        //    var ifFn = ImportFn(b, "mIf");
        //    return b.CallDynamic<TResult>(ifFn, ifTrue, ifFalse);
        //}



        public static Var<string> Concat(this SyntaxBuilder b, Var<string> s1, Var<string> s2, params Var<string>[] other)
        {
            var args = b.NewCollection<string>();
            b.Push(args, s1);
            b.Push(args, s2);
            foreach (var extra in other)
            {
                b.Push(args, extra);
            }

            return b.CallCore<string>(nameof(Concat), args);
        }

        public static Var<string> Trim(this SyntaxBuilder b, Var<string> s)
        {
            return b.CallCore<string>(nameof(Trim), s);
        }

        public static Var<List<T>> List<T>(this SyntaxBuilder b, IEnumerable<Var<T>> items)
        {
            var outList = b.NewCollection<T>();

            foreach (var item in items)
            {
                b.Push(outList, item);
            }

            return outList;
        }

        public static void Push<T>(this SyntaxBuilder b, Var<List<T>> onCollection, Var<T> item)
        {
            b.CallCore(nameof(Push), onCollection, item);
        }

        public static void PushRange<T>(this SyntaxBuilder b, Var<List<T>> onCollection, Var<List<T>> newItems)
        {
            b.Foreach(newItems, (b, item) => b.Push(onCollection, item));
        }

        public static void Clear<T>(this SyntaxBuilder b, Var<List<T>> collection)
        {
            b.CallDynamic(ImportFn(b, nameof(Clear)), collection);
        }

        public static Var<int> IndexOf<T>(this SyntaxBuilder b, Var<List<T>> collection, Var<T> item)
        {
            return b.CallDynamic<int>(ImportFn(b, nameof(IndexOf)), collection, item);
        }

        public static void Remove<T>(this SyntaxBuilder b, Var<List<T>> fromCollection, Var<T> item)
        {
            b.CallDynamic<int>(ImportFn(b, nameof(Remove)), fromCollection, item);
        }

        public static Var<bool> Not(this SyntaxBuilder b, Var<bool> v)
        {
            return b.CallDynamic<bool>(ImportFn(b, nameof(Not)), v);
        }

        public static Var<bool> And(this SyntaxBuilder b, Var<bool> l, Var<bool> r)
        {
            return b.CallDynamic<bool>(ImportFn(b, nameof(And)), l, r);
        }

        public static Var<bool> Or(this SyntaxBuilder b, Var<bool> l, Var<bool> r)
        {
            return b.CallDynamic<bool>(ImportFn(b, nameof(Or)), l, r);
        }

        public static Var<bool> IsEmpty(this SyntaxBuilder b, Var<string> v)
        {
            return b.CallDynamic<bool>(ImportFn(b, "IsEmptyString"), v);
        }

        public static Var<bool> IsEmpty(this SyntaxBuilder b, Var<object> v)
        {
            return b.CallDynamic<bool>(ImportFn(b, "IsEmptyObject"), v);
        }

        public static Var<bool> IsEmpty(this SyntaxBuilder b, Var<Guid> v)
        {
            return b.CallDynamic<bool>(ImportFn(b, "IsEmptyGuid"), v);
        }

        public static Var<bool> IsNull(this SyntaxBuilder b, IVariable v)
        {
            return b.CallDynamic<bool>(ImportFn(b, nameof(IsNull)), v);
        }

        public static Var<bool> HasValue(this SyntaxBuilder b, Var<string> v)
        {
            return b.CallDynamic<bool>(ImportFn(b, nameof(HasValue)), v);
        }

        public static Var<bool> HasId(this SyntaxBuilder b, Var<Guid> v)
        {
            return b.CallDynamic<bool>(ImportFn(b, nameof(HasId)), v);
        }

        public static Var<bool> HasObject<T>(this SyntaxBuilder b, Var<T> v)
        {
            return b.CallDynamic<bool>(ImportFn(b, nameof(HasObject)), v);
        }

        public static Var<bool> HasFunction<T>(this SyntaxBuilder b, Var<T> v) where T : System.Delegate
        {
            return b.CallDynamic<bool>(ImportFn(b, nameof(HasFunction)), v);
        }

        public static Var<Guid> NewId(this SyntaxBuilder b)
        {
            var resource = b.moduleBuilder.Module.Metadata.AddEmbeddedResourceMetadata(typeof(Core).Assembly, "uuid.js");
            var newId = b.ImportName<Func<Guid>>(resource, "v4");
            return b.Call(newId);
        }

        public static Var<Guid> EmptyId(this SyntaxBuilder b)
        {
            var resource = b.moduleBuilder.Module.Metadata.AddEmbeddedResourceMetadata(typeof(Core).Assembly, "uuid.js");
            var emptyId = b.ImportName<Guid>(resource, "NIL");
            return emptyId;
        }

        public static Var<Guid> ParseId(this SyntaxBuilder b, Var<string> id)
        {
            return b.CallDynamic<Guid>(ImportFn(b, nameof(ParseId)), id);
        }

        public static Var<int> ParseInt(this SyntaxBuilder b, Var<string> v)
        {
            return b.CallDynamic<int>(ImportFn(b, nameof(ParseInt)), v);
        }

        public static Var<bool> ParseBool(this SyntaxBuilder b, Var<string> v)
        {
            return b.AreEqual(v, b.Const("true"));
        }

        public static Var<decimal> ParseDecimal(this SyntaxBuilder b, Var<string> v)
        {
            return b.CallDynamic<decimal>(ImportFn(b, nameof(ParseDecimal)), v);
        }
        public static Var<string> ToLowercase(this SyntaxBuilder b, Var<string> text)
        {
            return b.CallDynamic<string>(ImportFn(b, nameof(ToLowercase)), text);
        }

        public static Var<bool> EndsWith(this SyntaxBuilder b, Var<string> larger, Var<string> end)
        {
            return b.CallDynamic<bool>(ImportFn(b, nameof(EndsWith)), larger, end);
        }

        public static Var<TScalar> ParseScalar<TScalar>(this SyntaxBuilder b, Var<string> value)
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

        public static Var<string> JoinStrings(this SyntaxBuilder b, Var<string> separator, Var<List<string>> values)
        {
            var checkedValues = b.Get(values, x => x.Where(x => x != null && x != "").ToList());
            return b.CallDynamic<string>(ImportFn(b, nameof(Concat)), b.Join(separator, checkedValues));
        }

        public static Var<List<T>> Join<T>(this SyntaxBuilder b, Var<T> separator, Var<List<T>> items)
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

        public static Var<string> Replace(this SyntaxBuilder b, Var<string> initialString, Var<string> oldText, Var<string> newText)
        {
            return b.CallDynamic<string>(ImportFn(b, nameof(Replace)), initialString, oldText, newText);
        }

        public static Var<int> GetHours(this SyntaxBuilder b, Var<DateTime> dateTime)
        {
            return b.CallDynamic<int>(ImportFn(b, nameof(GetHours)), dateTime);
        }


        public static Var<int> GetMinutes(this SyntaxBuilder b, Var<DateTime> dateTime)
        {
            return b.CallDynamic<int>(ImportFn(b, nameof(GetMinutes)), dateTime);
        }

        public static Var<int> GetHours(this SyntaxBuilder b, Var<DateTime?> dateTime)
        {
            return b.CallDynamic<int>(ImportFn(b, nameof(GetHours)), dateTime);
        }

        public static Var<int> Floor<T>(this SyntaxBuilder b, Var<T> n)
        {
            return b.CallDynamic<int>(ImportFn(b, nameof(Floor)), n);
        }

        public static Var<int> GetMinutes(this SyntaxBuilder b, Var<DateTime?> dateTime)
        {
            return b.CallDynamic<int>(ImportFn(b, nameof(GetMinutes)), dateTime);
        }

        public static Var<bool> Includes<T>(this SyntaxBuilder b, Var<List<T>> collection, Var<T> item)
        {
            return b.CallDynamic<bool>(ImportFn(b, "ArrayIncludes"), new IVariable[2] { collection, item });
        }

        // Metapsi.Syntax.Core
        public static Var<bool> Includes(this SyntaxBuilder b, Var<string> large, Var<string> small)
        {
            return b.CallDynamic<bool>(ImportFn(b, "StringIncludes"), new IVariable[2] { large, small });
        }


        public static Var<List<string>> Split(this SyntaxBuilder b, Var<string> inputString, Var<string> separator)
        {
            return b.CallDynamic<List<string>>(ImportFn(b, nameof(Split)), inputString, separator);
        }

        public static Var<string> SubstringStart(this SyntaxBuilder b, Var<string> inputString, Var<string> start)
        {
            return b.CallDynamic<string>(ImportFn(b, nameof(SubstringStart)), inputString, start);
        }

        public static Var<string> SubstringStartLength(this SyntaxBuilder b, Var<string> inputString, Var<string> start, Var<string> end)
        {
            return b.CallDynamic<string>(ImportFn(b, nameof(SubstringStartLength)), inputString, start, end);
        }

        public static Var<string> Slice(this SyntaxBuilder b, Var<string> inputString, Var<int> start, Var<int> end)
        {
            return b.CallDynamic<string>(ImportFn(b, nameof(Slice)), inputString, start, end);
        }

        public static Var<int> StringLength(this SyntaxBuilder b, Var<string> inputString)
        {
            return b.GetProperty<int>(inputString,"length");
        }

        public static Var<int> CollectionLength<T>(this SyntaxBuilder b, Var<List<T>> collection)
        {
            return b.GetProperty<int>(collection, "length");
        }

        public static Var<int> Minus(this SyntaxBuilder b, Var<int> number)
        {
            return b.CallDynamic<int>(ImportFn(b, nameof(Minus)), number);
        }

        public static Var<int> Add(this SyntaxBuilder b, Var<int> firstNumber, Var<int> secondNumber)
        {
            return b.CallDynamic<int>(ImportFn(b, nameof(Add)), firstNumber, secondNumber);
        }

        public static Var<decimal> Add(this SyntaxBuilder b, Var<decimal> firstNumber, Var<decimal> secondNumber)
        {
            return b.CallDynamic<decimal>(ImportFn(b, nameof(Add)), firstNumber, secondNumber);
        }

        public static Var<long> Add(this SyntaxBuilder b, Var<long> firstNumber, Var<long> secondNumber)
        {
            return b.CallDynamic<long>(ImportFn(b, nameof(Add)), firstNumber, secondNumber);
        }

        public static Var<double> Add(this SyntaxBuilder b, Var<double> firstNumber, Var<double> secondNumber)
        {
            return b.CallDynamic<double>(ImportFn(b, nameof(Add)), firstNumber, secondNumber);
        }

        public static Var<string> ToFixed(this SyntaxBuilder b, Var<decimal> number, Var<int> digits)
        {
            return b.CallDynamic<string>(ImportFn(b, nameof(ToFixed)), number, digits);
        }

        public static Var<TResult> TryCatchReturn<TResult>(this SyntaxBuilder b, Var<Func<TResult>> onTry, Var<Func<object, TResult>> onCatch)
        {
            return b.CallDynamic<TResult>(ImportFn(b, nameof(TryCatchReturn)), onTry, onCatch);
        }

        public static Var<T> Clone<T>(this SyntaxBuilder b, Var<T> v)
        {

            if (ModuleBuilder.ScalarTypes.Contains(typeof(T)))
            {
                return v;
            }
            else if (typeof(System.Collections.IEnumerable).IsAssignableFrom(typeof(T)))
            {
                return b.CallDynamic<T>(ImportFn(b, "CloneCollection"), v);
            }
            else
            {
                return b.CallDynamic<T>(ImportFn(b, "CloneObject"), v);
            }
        }

        public enum CopyType
        {
            Reference,
            Clone
        }

        /// <summary>
        /// Copies the common public properties 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="b"></param>
        /// <param name="into"></param>
        /// <param name="source"></param>
        public static void CopyProperties<TInto, TFrom>(this SyntaxBuilder b, Var<TInto> into, Var<TFrom> source, CopyType copyType = CopyType.Reference)
        {
            var intoProperties = typeof(TInto).GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
            var fromProperties = typeof(TFrom).GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);

            var commonProperties = intoProperties.Select(x => x.Name).Intersect(fromProperties.Select(x => x.Name));

            foreach (var propertyName in commonProperties)
            {
                var sourceValue = b.GetProperty<object>(source, b.Const(propertyName));
                if (copyType == CopyType.Clone)
                {
                    sourceValue = b.Clone(sourceValue);
                }
                b.SetProperty(into, b.Const(propertyName), sourceValue);
            }
        }

        /// <summary>
        /// Copies the properties of TInto from any source
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="b"></param>
        /// <param name="into"></param>
        /// <param name="source"></param>
        public static void CopyProperties<TInto>(this SyntaxBuilder b, Var<TInto> into, IVariable source, CopyType copyType = CopyType.Reference)
        {
            var intoProperties = typeof(TInto).GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);

            foreach (var property in intoProperties)
            {
                var sourceValue = b.GetProperty<object>(source, b.Const(property.Name));
                if (copyType == CopyType.Clone)
                {
                    sourceValue = b.Clone(sourceValue);
                }
                b.SetProperty(into, b.Const(property.Name), sourceValue);
            }
        }

        /// <summary>
        /// Creates a new T object with properties copied from a source object
        /// </summary>
        public static Var<TObj> NewObjFrom<TObj, TFrom>(this SyntaxBuilder b, Var<TFrom> from, CopyType copyType = CopyType.Reference)
            where TObj : new()
        {
            var outObject = b.NewObj<TObj>();
            b.CopyProperties(outObject, from, copyType);
            return outObject;
        }

        /// <summary>
        /// Creates a new T object with properties copied from a source object of any type
        /// </summary>
        public static Var<TObj> NewObjFrom<TObj>(this SyntaxBuilder b, IVariable from, CopyType copyType = CopyType.Reference)
            where TObj : new()
        {
            var outObject = b.NewObj<TObj>();
            b.CopyProperties(outObject, from, copyType);
            return outObject;
        }

        public static Var<T> Deserialize<T>(this SyntaxBuilder b, Var<string> json)
        {
            return b.CallDynamic<T>(ImportFn(b, nameof(Deserialize)), json);
        }

        public static Var<string> Serialize<T>(this SyntaxBuilder b, Var<T> obj)
        {
            return b.CallDynamic<string>(ImportFn(b, nameof(Serialize)), obj);
        }

        public static Var<List<IVariable>> ObjectValues<T>(this SyntaxBuilder b, Var<T> obj)
        {
            return b.CallDynamic<List<IVariable>>(ImportFn(b, nameof(ObjectValues)), obj);
        }

        public static Var<string> ConcatObjectValues<T>(this SyntaxBuilder b, Var<T> obj)
        {
            var result = b.JoinStrings(
                b.Const("|"),
                b.Map(
                    b.ObjectValues(obj),
                    b.Def((SyntaxBuilder b, Var<IVariable> v) => b.If(b.HasObject(v), b => b.AsString(v), b => b.Const(string.Empty)))));
            return result;
        }

        public static Var<DateTime> ParseDate(this SyntaxBuilder b, Var<string> stringDate)
        {
            return b.CallDynamic<DateTime>(ImportFn(b, nameof(ParseDate)), stringDate);
        }

        public static Var<string> FormatLocaleDateTime(this SyntaxBuilder b, Var<DateTime> dateTime, Var<string> localeCode)
        {
            return b.CallDynamic<string>(ImportFn(b, nameof(FormatLocaleDateTime)), dateTime, localeCode);
        }
        public static Var<string> FormatLocaleDateTime(this SyntaxBuilder b, Var<DateTime?> dateTime, Var<string> localeCode)
        {
            return b.CallDynamic<string>(ImportFn(b, nameof(FormatLocaleDateTime)), dateTime, localeCode);
        }

        public static Var<string> FormatLocaleDateTime(this SyntaxBuilder b, Var<DateTime> dateTime, Var<string> localeCode, Var<object> options)
        {
            return b.CallDynamic<string>(ImportFn(b, nameof(FormatLocaleDateTime)), dateTime, localeCode, options);
        }

        public static Var<string> FormatLocaleDate(this SyntaxBuilder b, Var<DateTime> dateTime, Var<string> localeCode, Var<object> options)
        {
            return b.CallDynamic<string>(ImportFn(b, nameof(FormatLocaleDate)), dateTime, localeCode, options);
        }


        public static void Log(this SyntaxBuilder b, IVariable v)
        {
            b.CallDynamic(ImportFn(b, nameof(Log)), v);
        }

        public static void Log(this SyntaxBuilder b, Var<string> tag, IVariable v)
        {
            b.Log(tag);
            b.Log(v);
        }

        public static void Log(this SyntaxBuilder b, string tag, IVariable v)
        {
            b.Log(b.Const(tag), v);
        }

        public static void Log(this SyntaxBuilder b, string tag)
        {
            b.Log(b.Const(tag));
        }

        public static Var<string> ToBase64<T>(this SyntaxBuilder b, Var<T> input)
        {
            return b.CallDynamic<string>(ImportFn(b, nameof(ToBase64)), input);
        }

        public static void FileToBase64(
            this SyntaxBuilder b,
            Var<object> file,
            Var<Action<object, string>> onResult,
            Var<Action<object>> onError)
        {
            b.CallDynamic(ImportFn(b, nameof(FileToBase64)), file, onResult, onError);
        }

        public static Var<List<char>> Chars(this SyntaxBuilder b, Var<string> s)
        {
            return b.CallDynamic<List<char>>(ImportFn(b, nameof(Chars)), s);
        }

        public static Var<string> JoinChars(this SyntaxBuilder b, Var<List<char>> s)
        {
            return b.CallDynamic<string>(ImportFn(b, nameof(JoinChars)), s);
        }

        public static Var<char> CharToUpperCase(this SyntaxBuilder b, Var<char> c)
        {
            return b.CallDynamic<char>(ImportFn(b, nameof(CharToUpperCase)), c);
        }

        public static Var<char> CharToLowerCase(this SyntaxBuilder b, Var<char> c)
        {
            return b.CallDynamic<char>(ImportFn(b, nameof(CharToLowerCase)), c);
        }

        public static Var<bool> CharIsUpperCase(this SyntaxBuilder b, Var<char> c)
        {
            var isUpperCase = b.AreEqual(b.CharToUpperCase(c), c);
            var hasUpperCase = b.Not(b.AreEqual(b.CharToLowerCase(c), c));

            var result = b.And(isUpperCase, hasUpperCase);
            return result;
        }

        public static Var<List<string>> SplitOnUppercase(this SyntaxBuilder b, Var<string> text)
        {
            var outStrings = b.NewCollection<string>();
            var currentString = b.Ref(b.NewCollection<char>());

            b.Foreach(b.Chars(text), (b, c) =>
            {
                b.If(b.CharIsUpperCase(c),
                    b =>
                    {
                        var joined = b.JoinChars(b.GetRef(currentString));
                        b.If(
                            b.Get(b.StringLength(joined), x => x > 0),
                            b =>
                            {
                                b.Push(outStrings, joined);
                            });
                        b.SetRef(currentString, b.NewCollection<char>());
                    });

                b.Push(b.GetRef(currentString), c);
            });

            b.Push(outStrings, b.JoinChars(b.GetRef(currentString)));

            return outStrings;
        }

        public static Var<string> FormatLabel(this SyntaxBuilder b, Var<string> fieldName)
        {
            var split = b.SplitOnUppercase(fieldName);
            var label = b.JoinStrings(b.Const(" "), split);
            return label;
        }
    }
}
