using Metapsi.Syntax;

namespace Metapsi.Html;

/// <summary>
/// 
/// </summary>
public static class CSSStyleDeclarationExtensions
{
    /// <summary>
    /// The CSSStyleDeclaration.getPropertyPriority() method interface returns a string that provides all explicitly set priorities on the CSS property.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="property">A string representing the property name to be checked.</param>
    /// <returns>A string that represents the priority (e.g., "important") if one exists. If none exists, returns the empty string.</returns>
    public static ObjBuilder<string> getPropertyPriority<T>(this ObjBuilder<T> b, Var<string> property)
        where T: CSSStyleDeclaration
    {
        return b.Call<string>(nameof(getPropertyPriority), property);
    }

    /// <summary>
    /// The CSSStyleDeclaration.getPropertyValue() method interface returns a string containing the value of a specified CSS property.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="property">A string representing the property name (in hyphen case) to be checked.</param>
    /// <returns>A string containing the value of the property. If not set, returns the empty string. The property value is dynamically computed, not what was originally specified in the declaration.</returns>
    public static ObjBuilder<string> getPropertyValue<T>(this ObjBuilder<T> b, Var<string> property)
        where T : CSSStyleDeclaration
    {
        return b.Call<string>(nameof(getPropertyValue), property);
    }

    /// <summary>
    /// The CSSStyleDeclaration.item() method interface returns a CSS property name from a CSSStyleDeclaration by index.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="index">The index of the node to be fetched. The index is zero-based.</param>
    /// <returns>A string that is the name of the CSS property at the specified index.</returns>
    public static ObjBuilder<string> item<T>(this ObjBuilder<T> b, Var<int> index)
        where T : CSSStyleDeclaration
    {
        return b.Call<string>(nameof(item), index);
    }

    /// <summary>
    /// The CSSStyleDeclaration.removeProperty() method interface removes a property from a CSS style declaration object.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="property">A string representing the property name to be removed. Multi-word property names are hyphenated (kebab-case) and not camel-cased.</param>
    /// <returns>A string equal to the value of the CSS property before it was removed.</returns>
    public static ObjBuilder<string> removeProperty<T>(this ObjBuilder<T> b, Var<string> property)
        where T : CSSStyleDeclaration
    {
        return b.Call<string>(nameof(removeProperty), property);
    }

    /// <summary>
    /// The CSSStyleDeclaration.setProperty() method interface sets a new value for a property on a CSS style declaration object.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="propertyName">A string representing the CSS property name (hyphen case) to be modified.</param>
    /// <param name="value">A string containing the new property value. If not specified, treated as the empty string. A null value is treated the same as the empty string ("").</param>
    /// <remarks>value must not contain "!important", that should be set using the priority parameter.</remarks>
    public static void setProperty<T>(this ObjBuilder<T> b, Var<string> propertyName, Var<string> value)
        where T : CSSStyleDeclaration
    {
        b.Call(nameof(setProperty), propertyName, value);
    }

    /// <summary>
    /// The CSSStyleDeclaration.setProperty() method interface sets a new value for a property on a CSS style declaration object.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="propertyName">A string representing the CSS property name (hyphen case) to be modified.</param>
    /// <param name="value">A string containing the new property value. If not specified, treated as the empty string. A null value is treated the same as the empty string ("").</param>
    /// <param name="priority">A string allowing the CSS priority to be set to important. Only the values listed below are accepted:
    /// <para>"important" (case-insensitive) for setting the property as !important;</para>
    /// <para>"", undefined, or null for removing the !important flag if present.</para>
    /// </param>
    /// <remarks>value must not contain "!important", that should be set using the priority parameter.</remarks>
    public static void setProperty<T>(this ObjBuilder<T> b, Var<string> propertyName, Var<string> value, Var<string> priority)
        where T : CSSStyleDeclaration
    {
        b.Call(nameof(setProperty), propertyName, value, priority);
    }
}
