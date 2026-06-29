using Metapsi.Html;
using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;

namespace Metapsi.Ionic;

public static partial class IonInputControl
{
    public static void BindTo<TEntity>(
        this PropsBuilder<IonInput> b,
        Var<TEntity> entityRef,
        System.Linq.Expressions.Expression<System.Func<TEntity, string>> onProperty)
    {
        var value = b.Get(entityRef, onProperty);
        b.SetValue(value);
        b.OnIonInput(b.MakeAction((SyntaxBuilder b, Var<object> model, Var<CustomEvent<InputInputEventDetail>> e) =>
        {
            var value = b.Get(e, x => x.detail.value);
            b.Set(entityRef, onProperty, value);
            return b.Clone(model);
        }));
    }

    public static void BindTo<TEntity>(
        this PropsBuilder<IonInput> b,
        Var<TEntity> entityRef,
        System.Linq.Expressions.Expression<System.Func<TEntity, int>> onProperty)
    {
        var value = b.Get(entityRef, onProperty);
        b.SetValue(value);
        b.OnIonInput(b.MakeAction((SyntaxBuilder b, Var<object> model, Var<CustomEvent<InputInputEventDetail>> e) =>
        {
            var value = b.Get(e, x => x.detail.value).As<int>();
            b.Set(entityRef, onProperty, value);
            return b.Clone(model);
        }));
    }
}

public static partial class IonTextareaControl
{
    public static void BindTo<TEntity>(
        this PropsBuilder<IonTextarea> b,
        Var<TEntity> entityRef,
        System.Linq.Expressions.Expression<System.Func<TEntity, string>> onProperty)
    {
        var value = b.Get(entityRef, onProperty);
        b.SetValue(value);
        b.OnIonInput(b.MakeAction((SyntaxBuilder b, Var<object> model, Var<CustomEvent<TextareaInputEventDetail>> e) =>
        {
            var value = b.Get(e, x => x.detail.value);
            b.Set(entityRef, onProperty, value);
            return b.Clone(model);
        }));
    }
}

public static partial class IonSelectControl
{
    public static void BindTo<TEntity>(
        this PropsBuilder<IonSelect> b,
        Var<TEntity> entityRef,
        System.Linq.Expressions.Expression<System.Func<TEntity, string>> onProperty)
    {
        var value = b.Get(entityRef, onProperty);
        b.SetValue(value);
        b.OnIonChange(b.MakeAction((SyntaxBuilder b, Var<object> model, Var<CustomEvent<SelectChangeEventDetail>> e) =>
        {
            var value = b.Get(e, x => x.detail.value).As<string>();
            b.Set(entityRef, onProperty, value);
            return b.Clone(model);
        }));
    }

    public static void BindTo<TEntity>(
        this PropsBuilder<IonSelect> b,
        Var<TEntity> entityRef,
        System.Linq.Expressions.Expression<System.Func<TEntity, int>> onProperty)
    {
        var value = b.Get(entityRef, onProperty);
        b.SetValue(value);
        b.OnIonChange(b.MakeAction((SyntaxBuilder b, Var<object> model, Var<CustomEvent<SelectChangeEventDetail>> e) =>
        {
            var value = b.Get(e, x => x.detail.value).As<int>();
            b.Set(entityRef, onProperty, value);
            return b.Clone(model);
        }));
    }
}


public static partial class IonPickerColumnControl
{
    public static void BindTo<TEntity>(
        this PropsBuilder<IonPickerColumn> b,
        Var<TEntity> entityRef,
        System.Linq.Expressions.Expression<System.Func<TEntity, string>> onProperty)
    {
        var value = b.Get(entityRef, onProperty);
        b.SetValue(value);
        b.OnIonChange(b.MakeAction((SyntaxBuilder b, Var<object> model, Var<CustomEvent<PickerColumnChangeEventDetail>> e) =>
        {
            var value = b.Get(e, x => x.detail.value).As<string>();
            b.Set(entityRef, onProperty, value);
            return b.Clone(model);
        }));
    }
}

public static partial class IonDatetimeControl
{
    public static void BindTo<TEntity>(
        this PropsBuilder<IonDatetime> b,
        Var<TEntity> entityRef,
        System.Linq.Expressions.Expression<System.Func<TEntity, string>> onProperty)
    {
        var value = b.Get(entityRef, onProperty);
        b.SetValue(value);
        b.OnIonChange(b.MakeAction((SyntaxBuilder b, Var<object> model, Var<CustomEvent<DatetimeChangeEventDetail>> e) =>
        {
            var value = b.Get(e, x => x.detail.value).As<string>();
            b.Set(entityRef, onProperty, value);
            return b.Clone(model);
        }));
    }
}

public static partial class IonSegmentControl
{
    public static void BindTo<TEntity>(
        this PropsBuilder<IonSegment> b,
        Var<TEntity> entityRef,
        System.Linq.Expressions.Expression<System.Func<TEntity, string>> onProperty)
    {
        var value = b.Get(entityRef, onProperty);
        b.SetValue(value);
        b.OnIonChange(b.MakeAction((SyntaxBuilder b, Var<object> model, Var<CustomEvent<SegmentChangeEventDetail>> e) =>
        {
            var value = b.Get(e, x => x.detail.value).As<string>();
            b.Set(entityRef, onProperty, value);
            return b.Clone(model);
        }));
    }
}

public static partial class IonCheckboxControl
{
    public static void BindTo<TEntity>(
        this PropsBuilder<IonCheckbox> b,
        Var<TEntity> entityRef,
        System.Linq.Expressions.Expression<System.Func<TEntity, bool>> onProperty)
    {
        var value = b.Get(entityRef, onProperty);
        b.SetChecked(value);
        b.OnIonChange(b.MakeAction((SyntaxBuilder b, Var<object> model, Var<CustomEvent<CheckboxChangeEventDetail>> e) =>
        {
            var value = b.Get(e, x => x.detail.@checked);
            b.Set(entityRef, onProperty, value);
            return b.Clone(model);
        }));
    }
}

public static partial class IonInputOtpControl
{
    public static void BindTo<TEntity>(
        this PropsBuilder<IonInputOtp> b,
        Var<TEntity> entityRef,
        System.Linq.Expressions.Expression<System.Func<TEntity, string>> onProperty)
    {
        var value = b.Get(entityRef, onProperty);
        b.SetValue(value);
        b.OnIonInput(b.MakeAction((SyntaxBuilder b, Var<object> model, Var<CustomEvent<InputOtpInputEventDetail>> e) =>
        {
            var value = b.Get(e, x => x.detail.value);
            b.Set(entityRef, onProperty, value);
            return b.Clone(model);
        }));
    }
}

public static partial class IonSearchbarControl
{
    public static void BindTo<TEntity>(
        this PropsBuilder<IonSearchbar> b,
        Var<TEntity> entityRef,
        System.Linq.Expressions.Expression<System.Func<TEntity, string>> onProperty)
    {
        var value = b.Get(entityRef, onProperty);
        b.SetValue(value);
        b.OnIonInput(b.MakeAction((SyntaxBuilder b, Var<object> model, Var<CustomEvent<SearchbarInputEventDetail>> e) =>
        {
            var value = b.Get(e, x => x.detail.value).As<string>();
            b.Set(entityRef, onProperty, value);
            return b.Clone(model);
        }));
    }
}