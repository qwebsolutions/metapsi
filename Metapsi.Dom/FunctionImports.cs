using System;
using System.Collections.Generic;
using System.Linq;
using Metapsi.Syntax;

namespace Metapsi.Dom
{
    public interface IDomElement
    {
    }

    public class Window : IDomElement
    {

    }

    public class DomElement : IDomElement
    {
        public string innerHTML { get; set; }
        public List<DomElement> children { get; set; }
    }

    public class ClickTarget
    {
    }

    public interface IDomEvent
    {

    }

    public class DomEvent<TTarget> : IDomEvent
    {
        public TTarget target { get; set; }
    }

    public class InputTarget
    {
        public string value { get; set; }
    }

    public class KeyboardEvent
    {
        public string key { get; set; }
    }

    public class CustomEvent<TDetail> : IDomEvent
    {
        public TDetail detail { get; set; }
    }


    public static class FunctionImports
    {
        private const string ModuleName = "metapsi.dom";

        public static Var<TOut> CallDomFunction<TOut>(this SyntaxBuilder b, string function, params IVariable[] arguments)
        {
            return b.CallExternal<TOut>(ModuleName, function, arguments);
        }

        public static void CallDomFunction(this SyntaxBuilder b, string function, params IVariable[] arguments)
        {
            b.CallExternal(ModuleName, function, arguments);
        }

        public static Var<Window> Window(this SyntaxBuilder b)
        {
            return b.CallDomFunction<Window>(nameof(Window));
        }

        public static Var<DomElement> GetElementById(this SyntaxBuilder b, Var<string> id)
        {
            return b.CallDomFunction<DomElement>(nameof(GetElementById), id);
        }

        public static Var<DomElement> CreateElement(this SyntaxBuilder b, Var<string> tag)
        {
            return b.CallDomFunction<DomElement>(nameof(CreateElement), tag);
        }

        public static Var<T> GetAttribute<T>(this SyntaxBuilder b, Var<DomElement> domElement, Var<string> attributeName)
        {
            return b.CallDomFunction<T>(nameof(GetAttribute), domElement, attributeName);
        }

        public static void SetAttribute<T>(this SyntaxBuilder b, Var<DomElement> domElement, Var<string> attributeName, Var<T> attributeValue)
        {
            b.CallDomFunction(nameof(SetAttribute), domElement, attributeName, attributeValue);
        }

        public static void AppendChild(this SyntaxBuilder b, Var<DomElement> parent, Var<DomElement> child)
        {
            b.CallDomFunction(nameof(AppendChild), parent, child);
        }

        public static void AddEventListener<T>(this SyntaxBuilder b, Var<T> element, Var<string> eventName, Var<Action> handler)
            where T: IDomElement
        {
            b.CallDomFunction(nameof(AddEventListener), element, eventName, handler);
        }

        public static void AddEventListener<T, TPayload>(this SyntaxBuilder b, Var<T> element, Var<string> eventName, Var<Action<CustomEvent<TPayload>>> handler)
            where T : IDomElement
        {
            b.CallDomFunction(nameof(AddEventListener), element, eventName, handler);
        }

        public static void RemoveEventListener<T>(this SyntaxBuilder b, Var<T> domElement, Var<string> eventName, Var<Action> handler)
               where T : IDomElement
        {
            b.CallDomFunction(nameof(RemoveEventListener), domElement, eventName, handler);
        }

        public static void RemoveEventListener<T, TPayload>(this SyntaxBuilder b, Var<T> element, Var<string> eventName, Var<Action<CustomEvent<TPayload>>> handler)
            where T : IDomElement
        {
            b.CallDomFunction(nameof(RemoveEventListener), element, eventName, handler);
        }

        public static void DispatchEvent(this SyntaxBuilder b, Var<string> eventName)
        {
            b.CallDomFunction(nameof(DispatchEvent), eventName);
        }

        public static void DispatchEvent<TPayload>(this SyntaxBuilder b, Var<string> eventName, Var<TPayload> payload)
        {
            b.CallDomFunction(nameof(DispatchEvent), eventName, payload);
        }

        public static void RequestAnimationFrame(this SyntaxBuilder b, Var<Action> action)
        {
            b.CallDomFunction(nameof(RequestAnimationFrame), action);
        }

        public static void StopPropagation<T>(this SyntaxBuilder b, Var<T> domEvent)
            where T: IDomEvent
        {
            b.CallDomFunction(nameof(StopPropagation), domEvent);
        }

        public static void Focus(this SyntaxBuilder b, Var<DomElement> domElement, bool scroll)
        {
            b.CallDomFunction(nameof(Focus), domElement, b.Const(scroll));
        }

        public static Var<string> GetUrl(this SyntaxBuilder b)
        {
            return b.CallDomFunction<string>(nameof(GetUrl));
        }

        public static void SetUrl(this SyntaxBuilder b, Var<string> url)
        {
            b.CallDomFunction(nameof(SetUrl), url);
        }

        public static void ScrollIntoView(this SyntaxBuilder b, Var<DomElement> domElement)
        {
            b.CallDomFunction(nameof(ScrollIntoView), domElement);
        }

        public static void ScrollBy(this SyntaxBuilder b, Var<int> x, Var<int> y)
        {
            b.CallDomFunction(nameof(ScrollBy), x, y);
        }

        public static void ScrollTo(this SyntaxBuilder b, Var<int> x, Var<int> y)
        {
            b.CallDomFunction(nameof(ScrollTo), x, y);
        }

        public static Var<int> SetInterval(this SyntaxBuilder b, Var<Action> action, Var<int> delay)
        {
            return b.CallDomFunction<int>(nameof(SetInterval), action, delay);
        }

        public static void ClearInterval(this SyntaxBuilder b, Var<int> intervalId)
        {
            b.CallDomFunction(nameof(ClearInterval), intervalId);
        }

        public static Var<string> GetLocale(this SyntaxBuilder b)
        {
            return b.CallDomFunction<string>(nameof(GetLocale));
        }

        public static void SetStyle(this SyntaxBuilder b, Var<DomElement> element, Var<string> styleName, Var<string> styleValue)
        {
            b.CallDomFunction("SetStyle", element, styleName, styleValue);
        }
    }
}

