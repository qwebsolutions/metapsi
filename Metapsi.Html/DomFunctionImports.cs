using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using Metapsi.Syntax;
using Microsoft.AspNetCore.Identity;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Metapsi.Html
{
    //public interface IDomElement
    //{
    //}

    //public class Window : IDomElement
    //{

    //}

    //public class Document: IDomElement
    //{

    //}

    //public class DomElement : IDomElement
    //{
    //    public string id { get; }
    //    public string @class { get; }
    //    public string innerHTML { get; }
    //    public List<DomElement> children { get; }
    //}

    //public class ClickTarget
    //{
    //}

    //public interface IDomEvent
    //{

    //}

    //public class DomEvent<TTarget> : IDomEvent
    //{
    //    public TTarget target { get; set; }
    //}

    //public class DomEvent : IDomEvent
    //{
    //    public DomElement currentTarget { get; set; }
    //    public DomElement target { get; set; }
    //}


    public class InputTarget
    {
        public string value { get; set; }
    }

    public class KeyboardEvent
    {
        public string key { get; set; }
    }

    public static class FunctionImports
    {
        private const string ModuleName = "metapsi.core";

        public static Var<TOut> CallCoreFunction<TOut>(this SyntaxBuilder b, string function, params IVariable[] arguments)
        {
            var fn = b.ImportName<Delegate>(ModuleName + ".js", function);
            return b.CallDynamic<TOut>(fn, arguments);
        }

        public static void CallDomFunction(this SyntaxBuilder b, string function, params IVariable[] arguments)
        {
            var fn = b.ImportName<Delegate>(ModuleName + ".js", function);
            b.CallDynamic(fn, arguments);
        }

        public static Var<object> Self(this SyntaxBuilder b)
        {
            return b.CallCoreFunction<object>(nameof(Self));
        }

        /// <summary>
        /// While loop
        /// </summary>
        /// <param name="b"></param>
        /// <param name="checkFn"></param>
        /// <param name="doFn"></param>
        public static void While(this SyntaxBuilder b, Var<Func<bool>> checkFn, Var<Action> doFn)
        {
            b.CallDomFunction("While", checkFn, doFn);
        }

        /// <summary>
        /// While loop
        /// </summary>
        /// <param name="b"></param>
        /// <param name="checkFn"></param>
        /// <param name="doFn"></param>
        public static void While(this SyntaxBuilder b, Func<SyntaxBuilder, Var<bool>> checkFn, Action<SyntaxBuilder> doFn)
        {
            b.While(b.Def(checkFn), b.Def(doFn));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="b"></param>
        /// <param name="collection"></param>
        /// <param name="doStuff"></param>
        /// <returns></returns>
        public static Var<Promise> AsyncForeach<T>(this SyntaxBuilder b, Var<List<T>> collection, Var<Func<T, Promise>> doStuff)
        {
            return b.CallCoreFunction<Promise>("AsyncForeach", collection, doStuff);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TSyntaxBuilder"></typeparam>
        /// <typeparam name="TItem"></typeparam>
        /// <param name="b"></param>
        /// <param name="collection"></param>
        /// <param name="doStuff"></param>
        /// <returns></returns>
        public static Var<Promise> AsyncForeach<TSyntaxBuilder, TItem>(this TSyntaxBuilder b, Var<List<TItem>> collection, Func<SyntaxBuilder, Var<TItem>, Var<Promise>> doStuff)
            where TSyntaxBuilder: SyntaxBuilder
        {
            return b.CallCoreFunction<Promise>("AsyncForeach", collection, b.Def(doStuff));
        }

        /// <summary>
        /// 'Returns' a non-existing variable so it can be used in expressions
        /// </summary>
        /// <param name="b"></param>
        /// <param name="errorMessage"></param>
        /// <returns></returns>
        public static IVariable Throw(this SyntaxBuilder b, Var<string> errorMessage)
        {
            return b.CallCoreFunction<IVariable>(nameof(Throw), errorMessage);
        }

        public static Var<Window> Window(this SyntaxBuilder b)
        {
            return b.GetProperty<Window>(b.Self(), "window");
        }

        /// <summary>
        /// Uses the 'new' keyword to create an object based on <paramref name="constructor"/>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="b"></param>
        /// <param name="constructor"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public static Var<T> New<T>(this SyntaxBuilder b, Var<object> constructor, params IVariable[] args)
        {
            List<IVariable> withFunc = new List<IVariable>();
            withFunc.Add(constructor);
            withFunc.AddRange(args);
            return b.CallCoreFunction<T>("New", withFunc.ToArray());
        }

        /// <summary>
        /// Uses the 'new' keyword to create an object based on constructor of type 'T'
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="b"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public static Var<T> New<T>(this SyntaxBuilder b, params IVariable[] args)
        {
            var constructor = b.GetProperty<object>(b.Self(), b.Const(typeof(T).Name));
            return b.New<T>(constructor, args);
        }

        public static Var<bool> In(this SyntaxBuilder b, IVariable value, IVariable inObject)
        {
            return b.CallCoreFunction<bool>("In", value, inObject);
        }

        //public static Var<T> New<T>(this SyntaxBuilder b, Var<IFunction> function, params IVariable[] args)
        //{
        //    List<IVariable> withFunc = new List<IVariable>();
        //    withFunc.Add(function);
        //    withFunc.AddRange(args);
        //    return b.CallDomFunction<T>("New", withFunc.ToArray());
        //}

        public static Var<Document> Document(this SyntaxBuilder b)
        {
            return b.GetProperty<Document>(b.Self(), "document");
        }

        public static Var<Element> GetElementById(this SyntaxBuilder b, Var<string> id)
        {
            return b.CallOnObject<Element>(b.Document(), "getElementById", id);
        }

        public static Var<Element> GetElementById(this SyntaxBuilder b, string id)
        {
            return b.GetElementById(b.Const(id));
        }


        public static Var<List<Element>> GetElementsByTagName(this SyntaxBuilder b, Var<Element> parent, Var<string> tagName)
        {
            return b.CallOnObject<List<Element>>(parent, "getElementsByTagName", tagName);
        }

        public static Var<List<Element>> GetElementsByTagName(this SyntaxBuilder b, Var<Element> parent, string tagName)
        {
            return b.GetElementsByTagName(parent, b.Const(tagName));
        }

        public static Var<Element> CreateElement(this SyntaxBuilder b, Var<string> tag)
        {
            return b.CallOnObject<Element>(b.Document(), "createElement", tag);
        }

        public static Var<Element> CreateTextNode(this SyntaxBuilder b, Var<string> content)
        {
            return b.CallOnObject<Element>(b.Document(), "createTextNode", content);
        }

        public static Var<Element> CreateTextNode(this SyntaxBuilder b, string content)
        {
            return b.CreateTextNode(b.Const(content));
        }

        public static Var<Element> CreateElement<T>(this SyntaxBuilder b, Var<string> tag, Action<PropsBuilder<T>> buildProps, Var<List<Element>> children)
        {
            var domElement = b.CreateElement(tag);
            b.CallOnObject<Element>(
                b.GetProperty<object>(
                    b.Self(),
                    b.Const("Object")),
                "assign",
                domElement,
                b.SetProps(b.NewObj<DynamicObject>(), buildProps));
            b.Foreach(
                children,
                (b, c) =>
                {
                    b.AppendChild(domElement, c);
                });
            return domElement;
        }
        public static Var<Element> CreateElement<T>(this SyntaxBuilder b, string tag, Action<PropsBuilder<T>> buildProps, Var<List<Element>> children)
        {
            return b.CreateElement(b.Const(tag), buildProps, children);
        }

        public static Var<Element> CreateElement<T>(this SyntaxBuilder b, string tag, Action<PropsBuilder<T>> buildProps, params Var<Element>[] children)
        {
            return b.CreateElement(b.Const(tag), buildProps, b.List(children));
        }

        public static Var<T> GetAttribute<T>(this SyntaxBuilder b, Var<Element> domElement, Var<string> attributeName)
        {
            return b.CallOnObject<T>(domElement, "getAttribute", attributeName);
        }

        public static void SetAttribute<T>(this SyntaxBuilder b, Var<Element> domElement, Var<string> attributeName, Var<T> attributeValue)
        {
            b.CallOnObject(domElement, "setAttribute", attributeName, attributeValue);
        }

        public static void AppendChild(this SyntaxBuilder b, Var<Element> parent, Var<Element> child)
        {
            b.CallOnObject(parent, "appendChild", child);
        }


        //public static void DispatchEvent<TPayload>(this SyntaxBuilder b, Var<string> eventName, Var<TPayload> payload)
        //{
        //    var customEvent = b.CreateCustomEvent<TPayload>(eventName, payload);
        //    b.DispatchEvent(customEvent);
        //}

        //public static void DispatchEvent<TPayload>(this SyntaxBuilder b, Var<TPayload> payload)
        //{
        //    var customEvent = b.CreateCustomEvent<TPayload>(payload);
        //    //b.DispatchEvent(customEvent);
        //}

        public static void RequestAnimationFrame(this SyntaxBuilder b, Var<Action> action)
        {
            b.CallOnObject(b.Window(), "requestAnimationFrame", action);
        }

        public static void RequestAnimationFrame(this SyntaxBuilder b, Action<SyntaxBuilder> action)
        {
            b.RequestAnimationFrame(b.Def(action));
        }


        // Not event present?
        /*
        public static void Focus(this SyntaxBuilder b, Var<DomElement> domElement, bool scroll)
        {
            b.CallDomFunction(nameof(Focus), domElement, b.Const(scroll));
        }*/

        public static Var<string> GetUrl(this SyntaxBuilder b)
        {
            return b.GetProperty<string>(b.GetProperty<object>(b.Window(), "location"), "pathname");
        }

        public static void SetUrl(this SyntaxBuilder b, Var<string> url)
        {
            b.SetProperty(b.GetProperty<object>(b.Window(), "location"), b.Const("href"), url);
        }


        public static Var<string> GetLocale(this SyntaxBuilder b)
        {
            var intl = b.GetProperty<object>(b.Window(), "Intl");
            var numberFormat = b.CallOnObject<object>(intl, "NumberFormat");
            var resolvedOptions = b.CallOnObject<object>(numberFormat, "resolvedOptions");
            return b.GetProperty<string>(resolvedOptions, "locale");
        }

        public static void SetStyle(this SyntaxBuilder b, Var<Element> element, Var<string> styleName, Var<string> styleValue)
        {
            b.SetProperty(b.GetProperty<object>(element, "style"), styleName, styleValue);
        }

        public static void SubmitForm(this SyntaxBuilder b, Var<string> formId)
        {
            var form = b.GetElementById(formId);
            b.If(
                b.HasObject(form),
                b =>
                {
                    b.CallOnObject(form, "submit");
                });
        }

        public static void SetTimeout(this SyntaxBuilder b, Var<Action> action, Var<int> delayMs)
        {
            b.CallOnObject(b.Window(), "setTimeout", action, delayMs);
        }

        public static Var<int> SetInterval(this SyntaxBuilder b, Var<Action> action, Var<int> delayMs)
        {
            return b.CallOnObject<int>(b.Window(), "setInterval", action, delayMs);
        }

        public static void ClearInterval(this SyntaxBuilder b, Var<int> intervalId)
        {
            b.CallOnObject(b.Window(), "clearInterval", intervalId);
        }

        public static Var<long> DateNow(this SyntaxBuilder b)
        {
            var dateObject = b.GetProperty<object>(b.Self(), "Date");
            var nowFunction = b.GetProperty<Func<long>>(dateObject, "now");
            return b.Call(nowFunction);
        }
    }
}

