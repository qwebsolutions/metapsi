//using Metapsi.Hyperapp;
//using Metapsi.Syntax;
//using System;
//using Metapsi.Html;

//namespace Metapsi.Ionic;

//public class IonNavLink<TComponent> : IonNavLink
//{
//}

//public class IonNav<TComponent> : IonNav
//{
//}

//public static class IonRouteExtensions
//{
//    public static Var<IVNode> IonRouteComponent<TComponent, TModel>(
//        this LayoutBuilder b,
//        string urlPrefix,
//        System.Linq.Expressions.Expression<Func<TComponent, string>> urlParameter,
//        Var<TModel> model,
//        params Var<IVNode>[] children)
//        where TComponent : IHasDataModel<TModel>
//    {
//        var url = urlPrefix.TrimEnd('/') + "/:" + urlParameter.PropertyName();
//        return b.IonRouteComponent<TComponent, TModel>(url, model, children);
//    }

//    public static Var<IVNode> IonRouteComponent<TComponent, TModel>(
//        this LayoutBuilder b,
//        string url,
//        Var<TModel> model,
//        params Var<IVNode>[] children)
//        where TComponent : IHasDataModel<TModel>
//    {
//        var componentTag = b.GetCustomElementTagName<TComponent>();

//        return b.IonRoute(
//            b =>
//            {
//                b.SetUrl(url);
//                b.SetComponent(componentTag);
//                var props = b.NewObj<DynamicObject>();
//                b.SetModel(model);
//                var getModel = b.Def<SyntaxBuilder, TModel>(GetModel<TModel>);
//                b.SetProperty(props, b.Const("GetModel"), getModel);
//                b.SetComponentProps(props);
//            }, children);
//    }


//    public static Var<IVNode> IonNavComponent<TComponent, TModel>(
//        this LayoutBuilder b,
//        Var<TModel> model,
//        Action<PropsBuilder<IonNav<TComponent>>> setProps = null)
//        where TComponent : IHasDataModel<TModel>
//    {
//        var componentTag = b.GetCustomElementTagName<TComponent>();
//        return b.IonNav(
//            b =>
//            {
//                b.SetRoot(componentTag);
//                b.SetModel(model);
//                var getModel = b.Def<SyntaxBuilder, TModel>(GetModel<TModel>);
//                var props = b.GetOrCreateProperty<DynamicObject>(b.Props, "rootParams");
//                b.SetProperty(props, b.Const("GetModel"), getModel);

//                if (setProps != null)
//                {
//                    var componentBuilder = new PropsBuilder<IonNav<TComponent>>();
//                    componentBuilder.InitializeFrom(b);
//                    componentBuilder.Props = b.Props.As<IonNav<TComponent>>();
//                    setProps(componentBuilder);
//                }

//                b.SetRootParams(props);
//                b.Log("SetRootParams", props);
//            });
//    }



//    public static Var<IVNode> IonNavLinkComponent<TComponent, TModel>(
//        this LayoutBuilder b,
//        Var<TModel> model,
//        Action<PropsBuilder<IonNavLink<TComponent>>> setExtraProps,
//        params Var<IVNode>[] children)
//        where TComponent : IHasDataModel<TModel>
//    {
//        var componentTag = b.GetCustomElementTagName<TComponent>();
//        return b.IonNavLink(
//            b =>
//            {
//                b.SetComponent(componentTag);
//                // Clone the model because:
//                // * Hyperapp rendering will be ignored if the prev model is the same
//                //   as the new one. This is a problem when we set the model
//                //   and trigger rendering by setting another property
//                // * When routing from one page to another there really ARE supposed
//                //   to be two states, because the transition goes from 'current page'
//                //   that does not need re-rendering to a new page while having both
//                //   on the screen during the animation
//                b.SetModel(b.Clone(model));

//                // GetModel needs to be set before other properties that trigger render

//                var getModel = b.Def<SyntaxBuilder, TModel>(GetModel<TModel>);
//                var props = b.GetOrCreateProperty<DynamicObject>(b.Props, "componentProps");
//                b.SetProperty(props, b.Const("GetModel"), getModel);
//                b.SetComponentProps(props);

//                var componentBuilder = new PropsBuilder<IonNavLink<TComponent>>();
//                componentBuilder.InitializeFrom(b);
//                componentBuilder.Props = b.Props.As<IonNavLink<TComponent>>();
//                setExtraProps(componentBuilder);
//            }, 
//            children);
//    }

//    public static Var<IVNode> IonNavLinkComponent<TComponent, TModel>(
//        this LayoutBuilder b,
//        Var<TModel> model,
//        params Var<IVNode>[] children)
//        where TComponent : IHasDataModel<TModel>
//    {
//        return b.IonNavLinkComponent<TComponent, TModel>(model, b => { }, children);
//    }

//    public static void AddComponentProp<TComponent, TProp>(this PropsBuilder<IonNavLink<TComponent>> b, System.Linq.Expressions.Expression<Func<TComponent, TProp>> property, Var<TProp> value)
//    {
//        var componentProps = b.GetOrCreateProperty<DynamicObject>(b.Props, "componentProps").As<TComponent>();
//        b.Set(componentProps, property, value);
//    }

//    public static void AddComponentProp<TComponent, TProp>(this PropsBuilder<IonNavLink<TComponent>> b, System.Linq.Expressions.Expression<Func<TComponent, TProp>> property, TProp value)
//    {
//        b.AddComponentProp(property, b.Const(value));
//    }

//    public static void AddComponentProp<TComponent, TProp>(this PropsBuilder<IonNav<TComponent>> b, System.Linq.Expressions.Expression<Func<TComponent, TProp>> property, Var<TProp> value)
//    {
//        var componentProps = b.GetOrCreateProperty<DynamicObject>(b.Props, "rootParams").As<TComponent>();
//        b.Set(componentProps, property, value);
//    }

//    public static void AddComponentProp<TComponent, TProp>(this PropsBuilder<IonNav<TComponent>> b, System.Linq.Expressions.Expression<Func<TComponent, TProp>> property, TProp value)
//    {
//        b.AddComponentProp(property, b.Const(value));
//    }

//    public static Reference<object> ModelReference = new Reference<object>() { Value = new object() };

//    public static void SetModel<TModel>(this SyntaxBuilder b, Var<TModel> model)
//    {
//        b.SetRef(b.GlobalRef(ModelReference), model.As<object>());
//    }

//    public static Var<TModel> GetModel<TModel>(this SyntaxBuilder b)
//    {
//        var model = b.GetRef(b.GlobalRef(ModelReference)).As<TModel>();
//        return model;
//    }


//    // No model

//    public static Var<IVNode> IonNav<TComponent>(
//        this LayoutBuilder b,
//        Action<PropsBuilder<IonNav<TComponent>>> setProps = null)
//    {
//        var componentTag = b.GetCustomElementTagName<TComponent>();
//        return b.IonNav(
//            b =>
//            {
//                b.SetRoot(componentTag);

//                if (setProps != null)
//                {
//                    var componentBuilder = new PropsBuilder<IonNav<TComponent>>();
//                    componentBuilder.InitializeFrom(b);
//                    componentBuilder.Props = b.Props.As<IonNav<TComponent>>();
//                    setProps(componentBuilder);
//                }
//            });
//    }


//    public static Var<IVNode> IonNavLink<TComponent>(
//        this LayoutBuilder b,
//        Action<PropsBuilder<IonNavLink<TComponent>>> setExtraProps = null,
//        params Var<IVNode>[] children)
//    {
//        var componentTag = b.GetCustomElementTagName<TComponent>();
//        return b.IonNavLink(
//            b =>
//            {
//                b.SetComponent(componentTag);

//                if (setExtraProps != null)
//                {
//                    var componentBuilder = new PropsBuilder<IonNavLink<TComponent>>();
//                    componentBuilder.InitializeFrom(b);
//                    componentBuilder.Props = b.Props.As<IonNavLink<TComponent>>();
//                    setExtraProps(componentBuilder);
//                }
//            },
//            children);
//    }

//    /// <summary>
//    /// Typecasted SetComponentProps. If you use this, do not use SetComponentProps
//    /// </summary>
//    /// <typeparam name="TComponent"></typeparam>
//    /// <param name="b"></param>
//    /// <param name="model"></param>
//    public static void SetComponentProps<TComponent>(this PropsBuilder<IonNavLink<TComponent>> b, Var<TComponent> model)
//    {
//        b.SetComponentProps(model.As<DynamicObject>());
//    }

//    public static void SetRootParams<TComponent>(this PropsBuilder<IonNav<TComponent>> b, Var<TComponent> model)
//    {
//        b.SetRootParams(model.As<DynamicObject>());
//    }
//}