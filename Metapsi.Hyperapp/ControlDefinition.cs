using Metapsi;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Metapsi.Hyperapp
{

    public interface IControlDefinition<TData>
    {
        Func<LayoutBuilder, Var<TData>, Var<IVNode>> GetRenderer();
    }

    public static class ControlDefinition
    {
        public static ControlDefinition<TData> New<TData>(
            string tag,
            Action<PropsBuilder, Var<TData>, Var<DynamicObject>> defaultProps,
            Func<LayoutBuilder, Var<TData>, Var<IVNode>> child)
        {
            var builder = new ControlDefinition<TData>(tag);
            builder.EditProps(defaultProps);
            builder.AddChild(child);
            return builder;
        }

        public static ControlDefinition<TData> New<TData>(
            string tag,
            Action<PropsBuilder, Var<TData>, Var<DynamicObject>> defaultProps,
            params Func<LayoutBuilder, Var<TData>, Var<IVNode>>[] children)
        {
            var builder = new ControlDefinition<TData>(tag);
            builder.EditProps(defaultProps);
            foreach(var child in children)
            {
                builder.AddChild(child);
            }
            return builder;
        }

        public static ControlDefinition<TData> New<TData>(
            string tag,
            Action<PropsBuilder, Var<TData>, Var<DynamicObject>> defaultProps,
            Func<LayoutBuilder, Var<TData>, Var<List<IVNode>>> children)
        {
            var builder = new ControlDefinition<TData>(tag);
            builder.EditProps(defaultProps);
            builder.AddChildren(children);
            return builder;
        }
    }

    public class ControlDefinition<TData> : IControlDefinition<TData>
    {
        public ControlDefinition(string tag)
        {
            this.Tag = tag;
        }

        public string Tag { get; set; }
        public List<Func<LayoutBuilder, Var<TData>, Var<List<IVNode>>>> ChildrenBuilders { get; set; } = new();
        public List<Action<PropsBuilder, Var<TData>, Var<DynamicObject>>> PropsActions { get; set; } = new();

        /// <summary>
        /// Called when the control is completely defined
        /// </summary>
        public Func<LayoutBuilder, Var<TData>, Var<IVNode>> GetRenderer()
        {
            // Clone so that we get the renderer at this specific time
            // Otherwise the returned function keeps a reference to a control definition
            // that could change in the meantime, possibly leading to infinite loops if we reuse this renderer

            var clone = this.Clone();

            return (LayoutBuilder b, Var<TData> data) =>
            {
                var props = b.NewObj<DynamicObject>();
                PropsBuilder propsBuilder = new PropsBuilder(b);
                foreach (var prop in clone.PropsActions)
                {
                    prop(propsBuilder, data, props);
                }

                var children = b.NewCollection<IVNode>();

                foreach (var buildChildren in clone.ChildrenBuilders)
                {
                    var newChildren = buildChildren(b, data);
                    b.Foreach(newChildren, (b, child) =>
                    {
                        b.Push(children, child);
                    });
                }

                return b.H(Tag, props, children);
            };
        }
    }

    public static class ControlDefinitionExtensions
    {
        public static ControlDefinition<TData> Clone<TData>(this ControlDefinition<TData> source)
        {
            var clone = new ControlDefinition<TData>(source.Tag);
            clone.PropsActions.AddRange(source.PropsActions);
            clone.ChildrenBuilders.AddRange(source.ChildrenBuilders);

            return clone;
        }

        public static void Override<TData>(
            this ControlDefinition<TData> definition,
            ControlDefinition<TData> newDefinition)
        {
            definition.Tag = newDefinition.Tag;
            definition.PropsActions = new(newDefinition.PropsActions);
            definition.ChildrenBuilders = new(newDefinition.ChildrenBuilders);
        }

        public static void OverrideChild<TData>(
            this ControlDefinition<TData> definition,
            Func<LayoutBuilder, Var<TData>, Func<LayoutBuilder, Var<TData>, Var<IVNode>>, Var<IVNode>> overrideChild)
        {
            var previousRenderer = definition.GetRenderer();
            SetChild(definition, (b, data) => overrideChild(b, data, previousRenderer));
        }

        public static void SetChild<TData>(
            this ControlDefinition<TData> definition,
            Func<LayoutBuilder, Var<TData>, Var<IVNode>> buildChild)
        {
            definition.ChildrenBuilders.Clear();
            definition.ChildrenBuilders.Add((b, data) =>
            {
                var singleChildCollection = b.NewCollection<IVNode>();
                b.Push(singleChildCollection, buildChild(b, data));
                return singleChildCollection;
            });
        }

        public static void AddChild<TData>(
            this ControlDefinition<TData> definition,
            Func<LayoutBuilder, Var<TData>, Var<IVNode>> buildChild)
        {
            definition.ChildrenBuilders.Add((b, data) =>
            {
                var singleChildCollection = b.NewCollection<IVNode>();
                b.Push(singleChildCollection, buildChild(b, data));
                return singleChildCollection;
            });
        }

        public static void AddChild<TData>(
            this ControlDefinition<TData> definition,
            Func<LayoutBuilder, Var<IVNode>> buildChild)
        {
            definition.ChildrenBuilders.Add((b, data) =>
            {
                var singleChildCollection = b.NewCollection<IVNode>();
                b.Push(singleChildCollection, buildChild(b));
                return singleChildCollection;
            });
        }

        public static void SetChildren<TData>(
            this ControlDefinition<TData> definition,
            Func<LayoutBuilder, Var<TData>, Var<List<IVNode>>> buildChildren)
        {
            definition.ChildrenBuilders.Clear();
            definition.ChildrenBuilders.Add(buildChildren);
        }

        public static void AddChildren<TData>(
            this ControlDefinition<TData> definition,
            Func<LayoutBuilder, Var<TData>, Var<List<IVNode>>> buildChildren)
        {
            definition.ChildrenBuilders.Add(buildChildren);
        }
    }
}

