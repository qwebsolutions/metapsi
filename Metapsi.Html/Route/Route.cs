using Metapsi.Html;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Metapsi;

/// <summary>
/// Declares routes
/// </summary>
public static class Route
{
    /// <summary>
    /// Route segment type
    /// </summary>
    public enum SegmentType
    {
        /// <summary>
        /// Use exactly <see cref="Segment.Identifier"/>
        /// </summary>
        Literal,
        /// <summary>
        /// Use the property identified by <see cref="Segment.Identifier"/>
        /// </summary>
        Property
    }

    /// <summary>
    /// A segment used when building the route
    /// </summary>
    public class Segment
    {
        /// <summary>
        /// Segment type
        /// </summary>
        public SegmentType SegmentType { get; set; }
        /// <summary>
        /// Either literal or property name
        /// </summary>
        public string Identifier { get; set; }
    }

    /// <summary>
    /// Shorthand constructor for routes
    /// </summary>
    /// <typeparam name="TValues"></typeparam>
    /// <returns></returns>
    public static Route<TValues> New<TValues>()
    {
        return new Route<TValues>();
    }

    public static string FormatValue(object value)
    {
        switch (value)
        {
            case null: return null;
            case string s: return s;
            case bool b: return b ? "true" : "false";              // bool.ToString() gives "True"; match JS
            case Enum e: return e.ToString();                       // the name; not culture-dependent
            case Guid g: return g.ToString("D");
            case double d: return d.ToString("R", CultureInfo.InvariantCulture);
            case float f: return f.ToString("R", CultureInfo.InvariantCulture);
            default:
                throw new ArgumentException($"{value.GetType().Name} cannot be used as a route value");
        }
    }
}

/// <summary>
/// A route is a simple concatenation of strings that are either known beforehand (<see cref="Route.SegmentType.Literal"/>) or when resolving the route at runtime (<see cref="Route.SegmentType.Property"/>).
/// Routes are always declared server side and represent a contract between a provider and a consumer.
/// The provider just mentions that a route of type <typeparamref name="TValues"/> exists and implements its logic based on that.
/// A consumer fills the route itself based on the environment (the web host).
/// </summary>
/// <remarks>A route with a single literal and no <typeparamref name="TValues"/> is just a string, so this doesn't need a non-generic class variant</remarks>
/// <typeparam name="TValues">The type used when resolving the route at runtime</typeparam>
public class Route<TValues>
{
    /// <summary>
    /// The segments used when resolving the route. The resolving is just a simple concatenation.
    /// This must be public, the route is serializable so it can be resolved client-side as well
    /// </summary>
    public List<Route.Segment> Segments { get; set; } = new List<Route.Segment>();

    /// <summary>
    /// Adds a literal value to the route
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Same route reference itself, for chaining calls</returns>
    public Route<TValues> AddLiteral(string value)
    {
        this.Segments.Add(new Route.Segment()
        {
            SegmentType = Route.SegmentType.Literal,
            Identifier = value
        });
        return this;
    }

    /// <summary>
    /// Adds <paramref name="property"/> property segment in the route segments. When the route is resolved, the value of <paramref name="property"/> is extracted from <typeparamref name="TValues"/>
    /// </summary>
    /// <typeparam name="TProp"></typeparam>
    /// <param name="property"></param>
    /// <returns></returns>
    public Route<TValues> AddParameter<TProp>(System.Linq.Expressions.Expression<Func<TValues, TProp>> property)
    {
        Segments.Add(new Route.Segment()
        {
            SegmentType = Route.SegmentType.Property,
            Identifier = property.PropertyName()
        });

        return this;
    }

}

public static class RouteExtensions
{
    public static Route<TValues> AddParameter<TValues>(this Route<TValues> route, System.Linq.Expressions.Expression<Func<TValues, string>> getValue)
    {
        return route.AddParameter<string>(getValue);
    }

    public static Route<TValues> AddParameter<TValues>(this Route<TValues> route, System.Linq.Expressions.Expression<Func<TValues, int>> getValue)
    {
        return route.AddParameter(getValue);
    }

    public static Route<TValues> AddParameter<TValues>(this Route<TValues> route, System.Linq.Expressions.Expression<Func<TValues, Guid>> getValue)
    {
        return route.AddParameter(getValue);
    }


    public static string Resolve<TValues>(this Route<TValues> route, TValues values)
    {
        StringBuilder stringBuilder = new StringBuilder();
        foreach (var segment in route.Segments)
        {
            if (segment.SegmentType == Route.SegmentType.Literal)
            {
                stringBuilder.Append(segment.Identifier);
            }
            else
            {
                var value = values.GetType().GetProperty(segment.Identifier).GetValue(values);
                var formatted = Route.FormatValue(value);
                var escaped = Uri.EscapeDataString(formatted);
                stringBuilder.Append(escaped);
            }
        }

        return stringBuilder.ToString();
    }

    public static Var<string> ResolveRoute<TValues>(this ISyntaxBuilder b, Var<Route<TValues>> route, Var<TValues> values)
    {
        var segments = b.Map(
            b.Get(route, x => x.Segments),
            (b, segment) =>
            {
                return b.If(
                    b.Get(segment, segment => segment.SegmentType == Route.SegmentType.Literal),
                    b =>
                    {
                        return b.Get(segment, x => x.Identifier);
                    },
                    b =>
                    {
                        var propertyValue = b.GetProperty<object>(values, b.Get(segment, x => x.Identifier));
                        var encodeFn = b.GetProperty<Func<object, string>>(b.Self(), "encodeURIComponent");
                        var escaped = b.Call(encodeFn, propertyValue);
                        return b.AsString(escaped);
                    });
            });
        return b.On(segments.As<Metapsi.Html.Array>(), b =>
        {
            return b.join(b.Const(string.Empty));
        });
    }
}