using Metapsi.Syntax;
using System;
using System.Collections.Generic;

namespace Metapsi.Html;

/// <summary>
/// The DOMTokenList interface represents a set of space-separated tokens. Such a set is returned by Element.classList or HTMLLinkElement.relList, and many others.
/// A DOMTokenList is indexed beginning with 0 as with JavaScript Array objects.DOMTokenList is always case-sensitive.
/// </summary>
public interface DOMTokenList
{
    /// <summary>
    /// The read-only length property of the DOMTokenList interface is an integer representing the number of objects stored in the object.
    /// </summary>
    int length { get; }

    /// <summary>
    /// The value property of the DOMTokenList interface is a stringifier that returns the value of the list serialized as a string, or clears and sets the list to the given value.
    /// </summary>
    string value { get; set; }
}

/// <summary>
/// 
/// </summary>
public static class DOMTokenListExtensions
{
    /// <summary>
    /// The add() method of the DOMTokenList interface adds the given tokens to the list, omitting any that are already present.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="domTokenList"></param>
    /// <param name="tokens">A string representing a token (or tokens) to add to the DOMTokenList.</param>
    public static void DOMTokenListAdd(this SyntaxBuilder b, Var<DOMTokenList> domTokenList, params Var<string>[] tokens)
    {
        b.CallOnObject(domTokenList, "add", tokens);
    }

    /// <summary>
    /// The contains() method of the DOMTokenList interface returns a boolean value — true if the underlying list contains the given token, otherwise false.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="domTokenList"></param>
    /// <param name="token"></param>
    /// <returns>A string representing the token you want to check for the existence of in the list.</returns>
    public static Var<bool> DOMTokenListContains(this SyntaxBuilder b, Var<DOMTokenList> domTokenList, Var<string> token)
    {
        return b.CallOnObject<bool>(domTokenList, "contains", token);
    }

    /// <summary>
    /// The entries() method of the DOMTokenList interface returns an iterator allowing you to go through all key/value pairs contained in this object. The values are Arrays which have [key, value] pairs, each representing a single token.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="domTokenList"></param>
    /// <returns></returns>
    public static Var<object> DOMTokenListEntries(this SyntaxBuilder b, Var<DOMTokenList> domTokenList)
    {
        return b.CallOnObject<object>(domTokenList, "entries");
    }

    /// <summary>
    /// The forEach() method of the DOMTokenList interface calls the callback given in parameter once for each value pair in the list, in insertion order.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="domTokenList"></param>
    /// <param name="callback">The function to execute for each element, eventually taking three arguments:
    /// <para>currentValue - The current element being processed in the array.</para>
    /// <para>currentIndex - The index of the current element being processed in the array.</para>
    /// <para>listObj - The array that forEach() is being applied to.</para>
    /// </param>
    /// <param name="thisArg">The value to use as this when executing callback.</param>
    public static void DOMTokenListForEach(this SyntaxBuilder b, Var<DOMTokenList> domTokenList, Var<Action<string, int, List<string>>> callback, Var<object> thisArg)
    {
        b.CallOnObject(domTokenList, "forEach", callback, thisArg);
    }

    /// <summary>
    /// The forEach() method of the DOMTokenList interface calls the callback given in parameter once for each value pair in the list, in insertion order.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="domTokenList"></param>
    /// <param name="callback">The function to execute for each element, eventually taking three arguments:
    /// <para>currentValue - The current element being processed in the array.</para>
    /// <para>currentIndex - The index of the current element being processed in the array.</para>
    /// <para>listObj - The array that forEach() is being applied to.</para>
    /// </param>
    public static void DOMTokenListForEach(this SyntaxBuilder b, Var<DOMTokenList> domTokenList, Var<Action<string, int, List<string>>> callback)
    {
        b.CallOnObject(domTokenList, "forEach", callback);
    }

    /// <summary>
    /// The item() method of the DOMTokenList interface returns an item in the list, determined by its position in the list, its index.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="domTokenList"></param>
    /// <param name="index">A number representing the index of the item you want to return. If it isn't an integer, only the integer part is considered.</param>
    /// <returns>A string representing the returned item, or null if the number is greater than or equal to the length of the list.</returns>
    public static Var<string> DOMTokenListItem(this SyntaxBuilder b, Var<DOMTokenList> domTokenList, Var<int> index)
    {
        return b.CallOnObject<string>(domTokenList, "item", index);
    }

    /// <summary>
    /// The keys() method of the DOMTokenList interface returns an iterator allowing to go through all keys contained in this object. The keys are unsigned integers.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="domTokenList"></param>
    /// <returns>Returns an iterator.</returns>
    public static Var<object> DOMTokenListKeys(this SyntaxBuilder b, Var<DOMTokenList> domTokenList)
    {
        return b.CallOnObject<object>(domTokenList, "keys");
    }

    /// <summary>
    /// The remove() method of the DOMTokenList interface removes the specified tokens from the list.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="domTokenList"></param>
    /// <param name="tokens">A string representing the token you want to remove from the list. If the string is not in the list, no error is thrown, and nothing happens.</param>
    public static void DOMTokenListRemove(this SyntaxBuilder b, Var<DOMTokenList> domTokenList, params Var<string>[] tokens)
    {
        b.CallOnObject(domTokenList, "remove", tokens);
    }

    /// <summary>
    /// The replace() method of the DOMTokenList interface replaces an existing token with a new token. If the first token doesn't exist, replace() returns false immediately, without adding the new token to the token list.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="domTokenList"></param>
    /// <param name="oldToken">A string representing the token you want to replace.</param>
    /// <param name="newToken">A string representing the token you want to replace oldToken with.</param>
    /// <returns>A boolean value, which is true if oldToken was successfully replaced, or false if not.</returns>
    public static Var<bool> DOMTokenListReplace(this SyntaxBuilder b, Var<DOMTokenList> domTokenList, Var<string> oldToken, Var<string> newToken)
    {
        return b.CallOnObject<bool>(domTokenList, "replace", oldToken, newToken);
    }

    /// <summary>
    /// The supports() method of the DOMTokenList interface returns true if a given token is in the associated attribute's supported tokens. This method is intended to support feature detection.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="domTokenList"></param>
    /// <param name="token">A string containing the token to query for.</param>
    /// <returns>A boolean value indicating whether the token was found.</returns>
    public static Var<bool> DOMTokenListSupports(this SyntaxBuilder b, Var<DOMTokenList> domTokenList, Var<string> token)
    {
        return b.CallOnObject<bool>(domTokenList, "supports", token);
    }

    /// <summary>
    /// The toggle() method of the DOMTokenList interface removes an existing token from the list and returns false. If the token doesn't exist it's added and the function returns true.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="domTokenList"></param>
    /// <param name="token">A string representing the token you want to toggle.</param>
    /// <param name="force">If included, turns the toggle into a one way-only operation. If set to false, then token will only be removed, but not added. If set to true, then token will only be added, but not removed.</param>
    /// <returns>A boolean value, true or false, indicating whether token is in the list after the call or not.</returns>
    public static Var<bool> DOMTokenListToggle(this SyntaxBuilder b, Var<DOMTokenList> domTokenList, Var<string> token, Var<bool> force)
    {
        return b.CallOnObject<bool>(domTokenList, "toggle", token, force);
    }

    /// <summary>
    /// The toggle() method of the DOMTokenList interface removes an existing token from the list and returns false. If the token doesn't exist it's added and the function returns true.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="domTokenList"></param>
    /// <param name="token">A string representing the token you want to toggle.</param>
    /// <returns>A boolean value, true or false, indicating whether token is in the list after the call or not.</returns>
    public static Var<bool> DOMTokenListToggle(this SyntaxBuilder b, Var<DOMTokenList> domTokenList, Var<string> token)
    {
        return b.CallOnObject<bool>(domTokenList, "toggle", token);
    }

    /// <summary>
    /// The toString() stringifier method of the DOMTokenList interface returns the values of the token list serialized as a string. The return value is a space-separated list of tokens equal to the DOMTokenList.value property.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="domTokenList"></param>
    /// <returns>A string.</returns>
    public static Var<string> DOMTokenListToString(this SyntaxBuilder b, Var<DOMTokenList> domTokenList)
    {
        return b.CallOnObject<string>(domTokenList, "toString");
    }

    /// <summary>
    /// The values() method of the DOMTokenList interface returns an iterator allowing the caller to go through all values contained in the DOMTokenList. The individual values are strings.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="domTokenList"></param>
    /// <returns>Returns an iterator.</returns>
    public static Var<object> DOMTokenListValues(this SyntaxBuilder b, Var<DOMTokenList> domTokenList)
    {
        return b.CallOnObject<object>(domTokenList, "values");
    }
}
