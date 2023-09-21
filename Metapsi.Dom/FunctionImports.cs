using System;
using System.Collections.Generic;
using System.Linq;
using Metapsi.Syntax;

namespace Metapsi.Dom
{
    public class DomElement
    {
        public string innerHTML { get; set; }
        public List<DomElement> children { get; set; }
    }

    public static class FunctionImports
    {
        private const string ModuleName = "metapsi.dom";

        public static Var<TOut> CallDomFunction<TOut>(this BlockBuilder b, string function, params IVariable[] arguments)
        {
            return b.CallExternal<TOut>(ModuleName, function, arguments);
        }

        public static void CallDomFunction(this BlockBuilder b, string function, params IVariable[] arguments)
        {
            b.CallExternal(ModuleName, function, arguments);
        }

        public static Var<DomElement> GetElementById(this BlockBuilder b, Var<string> id)
        {
            return b.CallDomFunction<DomElement>(nameof(GetElementById), id);
        }

        public static Var<DomElement> CreateElement(this BlockBuilder b, Var<string> tag)
        {
            return b.CallDomFunction<DomElement>(nameof(CreateElement), tag);
        }

        public static Var<T> GetAttribute<T>(this BlockBuilder b, Var<DomElement> domElement, Var<string> attributeName)
        {
            return b.CallDomFunction<T>(nameof(GetAttribute), domElement, attributeName);
        }

        public static void SetAttribute<T>(this BlockBuilder b, Var<DomElement> domElement, Var<string> attributeName, Var<T> attributeValue)
        {
            b.CallDomFunction(nameof(SetAttribute), domElement, attributeName, attributeValue);
        }

        public static void AppendChild(this BlockBuilder b, Var<DomElement> parent, Var<DomElement> child)
        {
            b.CallDomFunction(nameof(AppendChild), parent, child);
        }

        public static void AddEventListener(this BlockBuilder b, Var<DomElement> element, Var<string> eventName, Var<Action> handler)
        {
            b.CallDomFunction(nameof(AddEventListener), element, eventName, handler);
        }

        public static void DispatchEvent(this BlockBuilder b, Var<string> eventName)
        {
            b.CallDomFunction(nameof(DispatchEvent), eventName);
        }

        public static void DispatchEvent<TPayload>(this BlockBuilder b, Var<string> eventName, Var<TPayload> payload)
        {
            b.CallDomFunction(nameof(DispatchEvent), eventName, payload);
        }

        public static void RequestAnimationFrame(this BlockBuilder b, Var<Action> action)
        {
            b.CallDomFunction(nameof(RequestAnimationFrame), action);
        }

        public static void Focus(this BlockBuilder b, Var<DomElement> domElement, bool scroll)
        {
            b.CallDomFunction(nameof(Focus), domElement, b.Const(scroll));
        }

        public static Var<string> GetUrl(this BlockBuilder b)
        {
            return b.CallDomFunction<string>(nameof(GetUrl));
        }

        public static void SetUrl(this BlockBuilder b, Var<string> url)
        {
            b.CallDomFunction(nameof(SetUrl), url);
        }

        public static void ScrollIntoView(this BlockBuilder b, Var<DomElement> domElement)
        {
            b.CallDomFunction(nameof(ScrollIntoView), domElement);
        }

        public static void ScrollBy(this BlockBuilder b, Var<int> x, Var<int> y)
        {
            b.CallDomFunction(nameof(ScrollBy), x, y);
        }

        public static void ScrollTo(this BlockBuilder b, Var<int> x, Var<int> y)
        {
            b.CallDomFunction(nameof(ScrollTo), x, y);
        }
    }
}

