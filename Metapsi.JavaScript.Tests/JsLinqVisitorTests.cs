using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Metapsi.JavaScript.Tests;

[TestClass]
public class JsLinqVisitorTests
{
    [TestMethod]
    public void TestMethod1()
    {
        //Expect((string p) => true, "p => (true)");
        //CompareOldNew((string p) => true);
        //CompareOldNew((string p1, DateTime p2) => p1 == p2.ToString());

        //Expect(
        //    (Entity x, Guid id, Func<Entity, Guid, bool> predicate) => x.Children.SelectMany(x => x.Children).Where(x => predicate(x, id)).Single(x => x.GuidProperty == id),
        //    "()");

        //Expect((Entity x) => x.Children.ToList()[0], "");

        //Expect(
        //    (Entity x, string s) => x.Children.SingleOrDefault(y => y.StringProperty == s, s == "" ? null : new Entity() { StringProperty = "(not set)" }).StringProperty,
        //    "");

        //Expect(
        //    (Entity x, Guid id) => x.Children.SingleOrDefault(y => y.GuidProperty == id, new Entity() { StringProperty = "(not set)", IntProperty = 6 }).StringProperty,
        //    "");

        //Expect((Entity x, Guid paramId) => x.Children.Where(x => x.StringProperty != paramId.ToString()).ToList(), "");
        //Expect((Entity p) => !(p.StringProperty == "abc"), "");
        //Expect((Entity e, EntityType t) => e.EntityType == t, "");
        Expect(
            (Entity e) => !((e.StringProperty == e.InnerEntity.StringProperty || e.StringProperty != e.InnerEntity.InnerEntity.StringProperty) && e.InnerEntity.IntProperty == e.IntProperty),
            "");
    }

    public enum EntityType
    {
        First,
        Second
    }

    public class Entity
    {
        public bool BoolProperty { get; set; }
        public string StringProperty { get; set; }
        public int IntProperty { get; set; }
        public EntityType EntityType { get; set; }
        public Guid GuidProperty { get; set; }

        public Entity InnerEntity { get; set; } = new();
        public List<Entity> Children { get; set; } = new();
    }

    private static void Expect(System.Linq.Expressions.Expression expression, string expected)
    {
        //var oldStyle = JsLinq.Convert(expression);

        var newConverter = new Syntax.LinqConverter();
        newConverter.Visit(expression);
        var output = newConverter.JsLinq();

        if (output.Replace(" ", string.Empty) != expected.Replace(" ", string.Empty))
            throw new Exception("Ain't workin'");
    }

    //private static void CompareOldNew(System.Linq.Expressions.Expression expression)
    //{
    //    try
    //    {
    //        var oldStyle = JsLinq.Convert(expression);
    //        var newConverter = new JavaScript.LinqConverter();
    //        newConverter.Visit(expression);
    //        var newStyle = newConverter.JsLinq();

    //        Console.WriteLine(oldStyle);
    //        Console.WriteLine(newStyle);

    //        if (oldStyle.Replace(" ", string.Empty) != newStyle.Replace(" ", string.Empty))
    //            throw new Exception("Ain't workin'");
    //    }
    //    catch (Exception ex)
    //    {
    //        throw;
    //    }
    //}
}