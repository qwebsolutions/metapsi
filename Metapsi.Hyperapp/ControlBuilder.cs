﻿using Metapsi.Syntax;
using System;
using System.Collections.Generic;

namespace Metapsi.Hyperapp
{
    public class ControlBuilder<TControlDefinition, TData>
        where TControlDefinition : IControlDefinition<TData>
    {
        public TControlDefinition Control { get; set; }

        public Func<SyntaxBuilder, Var<TData>> InitData { get; set; }
        public List<Action<SyntaxBuilder, Var<TData>>> DataActions { get; set; } = new();

        public ControlBuilder(TControlDefinition controlDefinition, Func<SyntaxBuilder, Var<TData>> initData)
        {
            this.Control = controlDefinition;
            this.InitData = initData;
        }

        internal Var<TData> GetData(SyntaxBuilder b)
        {
            var data = InitData(b);

            foreach (var dataAction in DataActions)
            {
                dataAction(b, data);
            }

            return data;
        }
    }

    public static class ControlBuilderExtensions
    {
        public static void SetData<TControlDefinition, TData>(
            this ControlBuilder<TControlDefinition, TData> builder,
            Action<SyntaxBuilder,Var<TData>> action)
            where TControlDefinition : IControlDefinition<TData>
        {
            builder.DataActions.Add(action);
        }

        public static void OnChildControl<TParentControlDefinition, TParentData, TChildControlDefinition, TChildData>(
            this ControlBuilder<TParentControlDefinition, TParentData> b,
            Func<TParentControlDefinition, TChildControlDefinition> getChildDefinition,
            System.Linq.Expressions.Expression<Func<TParentData, TChildData>> childDataProperty,
            Action<ControlBuilder<TChildControlDefinition, TChildData>> custom)
            where TParentControlDefinition : IControlDefinition<TParentData>
            where TChildControlDefinition : IControlDefinition<TChildData>
            where TChildData : new()
        {
            var childDefinition = getChildDefinition(b.Control);
            ControlBuilder<TChildControlDefinition, TChildData> childBuilder = new(childDefinition, b => b.NewObj<TChildData>());
            custom(childBuilder);


            // Transfer data actions from child to parent because child actions are never actually called, just registered

            b.SetData((b, parentData) =>
            {
                b.Call(childBuilder.InitData);
            });

            foreach (var childDataAction in childBuilder.DataActions)
            {
                b.SetData((b, parentData) =>
                {
                    var childData = b.Get(parentData, childDataProperty);
                    b.Call(childDataAction, childData);
                });
            }
        }

        public static void AddChild<TData>(
            this ControlBuilder<ControlDefinition<TData>, TData> b,
            Func<LayoutBuilder, Var<TData>, Var<IVNode>> buildChild)
        {
            b.Control.AddChild(buildChild);
        }
    }
}

