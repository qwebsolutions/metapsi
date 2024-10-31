using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Linq.Expressions;
using System.Text.Json;

namespace Metapsi.Syntax
{
    public interface IVariable
    {
        string Name { get; }
        public Type Type { get; }
    }

    public interface IProperty
    {
        public Type InterfaceType { get; set; }
        public string PropertyName { get; set; }
    }

    public class Property : IProperty
    {
        public Type InterfaceType { get; set; }
        public string PropertyName { get; set; }
    }


    public class Constant : IConstant, IVariable
    {
        public string Name { get; set; }
        public object Value { get; set; }

        public Type Type => Value.GetType();
    }

    public record Import(string Module, string Symbol);

    //public record Constant
    //{
    //    public record Function<T>(T function) : Constant where T : Delegate;
    //    public record Value<T>(T value): Constant ;
    //}

    public class Module
    {
        public List<Import> Imports { get; set; } = new();
        public List<Constant> Consts { get; set; } = new();
        public List<IFunction> Functions { get; set; } = new();
    }

    public class FunctionCall : ISyntaxElement
    {
        public IVariable Function { get; set; }
        public List<IVariable> Arguments { get; set; } = new List<IVariable>();
        public IVariable IntoVariable { get; set; }
    }

    public interface IFunction 
    {
        public string Name { get; }
        public Block ChildBlock { get; }
        public List<IVariable> Parameters { get; }
        public IVariable ReturnVariable { get; set; }
    }

    public class Function<TAction> : ISyntaxElement, IFunction
    {
        //public TAction Value { get; set; }
        public string Name { get; set; }
        public Block ChildBlock { get; set; } = new Block();
        public List<IVariable> Parameters { get; set; } = new List<IVariable>();
        public IVariable ReturnVariable { get; set; } = new Var<object>();

        //public Delegate Definition => Value as Delegate;
    }

    public class Var<T> : IVariable
    {
        public Var() { }

        public Var(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public Type Type => typeof(T);
    }

    public interface IConstant : IVariable
    {
        public object Value { get; }
    }

    public class Const<T> : Var<T>, IConstant
    {
        public T Value { get; set; }
        object IConstant.Value => Value;
    }

    public interface ISyntaxElement
    {
    }

    public class Block
    {
        public List<ISyntaxElement> Lines { get; set; } = new List<ISyntaxElement>();

        //public override string ToString()
        //{
        //    return JavaScript.Builder.Generate(this, 0);
        //}
    }

    public class IfBlock : ISyntaxElement
    {
        public IVariable Var { get; set; }
        public Block TrueBlock { get; set; } = new Block();
        public Block FalseBlock { get; set; } = null;
    }

    public interface IForeachBlock
    {
        public string CollectionVarName { get; }
        public string OverVarName { get; }
        public Block ChildBlock { get; }
    }

    public class ForeachBlock<T> : IForeachBlock, ISyntaxElement
    {
        public Var<List<T>> Collection { get; set; }
        public Var<T> OverVariable { get; set; }
        public Block ChildBlock { get; set; } = new Block();
        string IForeachBlock.CollectionVarName => Collection.Name;
        string IForeachBlock.OverVarName => OverVariable.Name;
    }

    public class LineComment : ISyntaxElement
    {
        public string FileName { get; set; }
        public int LineNumber { get; set; }
        public string Comment { get; set; }
    }

    public interface IObjectConstructor
    {
        public IVariable IntoVar { get; }
        public object From { get; }
        public Type Type { get; set; }

    }

    public class ObjectConstructor<T> : IObjectConstructor, ISyntaxElement
    {
        public Var<T> IntoVar { get; set; }
        public T From { get; set; }
        IVariable IObjectConstructor.IntoVar => IntoVar;
        object IObjectConstructor.From => From;
        public Type Type { get; set; }
    }

    public interface ICollectionConstructor
    {
        public IVariable IntoVar { get; }
        public Type ItemType { get; }
    }

    public class CollectionConstructor<T> : ICollectionConstructor, ISyntaxElement
    {
        public Var<List<T>> IntoVar { get; set; }
        IVariable ICollectionConstructor.IntoVar => IntoVar;
        public Type ItemType => typeof(T);
    }

    public interface IPropertyAssignment
    {
        IVariable ObjectVar { get; set; }
        IProperty Property { get; set; }
        IVariable FromVar { get; set; }
    }

    public class PropertyAssignment : IPropertyAssignment, ISyntaxElement
    {
        public IVariable ObjectVar { get; set; }
        public IProperty Property { get; set; }
        public IVariable FromVar { get; set; }
    }

    public interface IPropertyAccess
    {
        public IVariable FromVar { get; set; }
        public IProperty Property { get; }
        public IVariable IntoVar { get; }
    }

    public class PropertyAccess : IPropertyAccess, ISyntaxElement
    {
        public IVariable FromVar { get; set; }
        public IProperty Property { get; set; }
        public IVariable IntoVar { get; set; }
    }

    //public interface IVariableAssignment : ISyntaxElement
    //{
    //    IVariable IntoVar { get; }
    //    IVariable FromVar { get; }
    //}

    //public class VariableAssignment<T> : IVariableAssignment, ISyntaxElement
    //{
    //    public Var<T> IntoVar { get; set; }
    //    public Var<T> FromVar { get; set; }
    //    IVariable IVariableAssignment.IntoVar => IntoVar;
    //    IVariable IVariableAssignment.FromVar => FromVar;
    //}

    public class ExternalCall : ISyntaxElement
    {

    }

    public class ConstFunctionNameSerializer : System.Text.Json.Serialization.JsonConverter<IFunction>
    {
        public override IFunction Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }

        public override bool CanConvert(Type typeToConvert)
        {
            return typeToConvert.IsAssignableTo(typeof(IFunction));
        }

        public override void Write(Utf8JsonWriter writer, IFunction value, JsonSerializerOptions options)
        {
            writer.WriteRawValue(value.Name, true);
        }
    }

    public class VarFunctionNameSerializer : System.Text.Json.Serialization.JsonConverter<IFunction>
    {
        public override IFunction Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }

        public override bool CanConvert(Type typeToConvert)
        {
            return typeToConvert.IsAssignableTo(typeof(IFunction));
        }

        public override void Write(Utf8JsonWriter writer, IFunction value, JsonSerializerOptions options)
        {
            writer.WriteRawValue(value.Name, true);
        }
    }
}

