using Metapsi.Syntax;
using System.Collections.Generic;

namespace Metapsi.Html;

/// <summary>
/// 
/// </summary>
public static class StringExtensions
{
    /// <summary>
    /// The length data property of a String value contains the length of the string in UTF-16 code units.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="s"></param>
    /// <returns>A non-negative integer.</returns>
    /// <remarks>In Metapsi this is a method, not a property, because we use the C# string as the interface</remarks>
    public static Var<int> Length(this SyntaxBuilder b, Var<string> s)
    {
        return b.GetProperty<int>(s, "length");
    }

    /// <summary>
    /// The at() method of String values takes an integer value and returns a new String consisting of the single UTF-16 code unit located at the specified offset. This method allows for positive and negative integers. Negative integers count back from the last string character.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="s"></param>
    /// <param name="index">The index (position) of the string character to be returned. Supports relative indexing from the end of the string when passed a negative index; i.e., if a negative number is used, the character returned will be found by counting back from the end of the string.</param>
    /// <returns>A String consisting of the single UTF-16 code unit located at the specified position. Returns undefined if the given index can not be found.</returns>
    public static Var<string> At(this SyntaxBuilder b, Var<string> s, Var<int> index)
    {
        return b.CallOnObject<string>(s, "at", index);
    }

    /// <summary>
    /// The concat() method of String values concatenates the string arguments to this string and returns a new string.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="s"></param>
    /// <param name="other">One or more strings to concatenate to str.</param>
    /// <returns>A new string containing the combined text of the strings provided.</returns>
    public static Var<string> StringConcat(this SyntaxBuilder b, Var<string> s, params Var<string>[] other)
    {
        return b.CallOnObject<string>(s, "concat", other);
    }

    /// <summary>
    /// The endsWith() method of String values determines whether a string ends with the characters of this string, returning true or false as appropriate.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="s"></param>
    /// <param name="searchString">The characters to be searched for at the end of str. Cannot be a regex. All values that are not regexes are coerced to strings, so omitting it or passing undefined causes endsWith() to search for the string "undefined", which is rarely what you want.</param>
    /// <param name="endPosition">The end position at which searchString is expected to be found (the index of searchString's last character plus 1). Defaults to str.length.</param>
    /// <returns>true if the given characters are found at the end of the string, including when searchString is an empty string; otherwise, false.</returns>
    public static Var<bool> StringEndsWith(this SyntaxBuilder b, Var<string> s, Var<string> searchString, Var<int> endPosition = null)
    {
        return endPosition == null ? b.CallOnObject<bool>(s, "endsWith", searchString) : b.CallOnObject<bool>(s, "endsWith", searchString, endPosition);
    }

    /// <summary>
    /// The includes() method of String values performs a case-sensitive search to determine whether a given string may be found within this string, returning true or false as appropriate.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="s"></param>
    /// <param name="searchString">A string to be searched for within str. Cannot be a regex. All values that are not regexes are coerced to strings, so omitting it or passing undefined causes includes() to search for the string "undefined", which is rarely what you want.</param>
    /// <param name="position">The position within the string at which to begin searching for searchString. (Defaults to 0.)</param>
    /// <returns>true if the search string is found anywhere within the given string, including when searchString is an empty string; otherwise, false.</returns>
    public static Var<bool> StringIncludes(this SyntaxBuilder b, Var<string> s, Var<string> searchString, Var<int> position = null)
    {
        return position == null ? b.CallOnObject<bool>(s, "includes", searchString) : b.CallOnObject<bool>(s, "endsWith", searchString, position);
    }

    /// <summary>
    /// The indexOf() method of String values searches this string and returns the index of the first occurrence of the specified substring. It takes an optional starting position and returns the first occurrence of the specified substring at an index greater than or equal to the specified number.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="s"></param>
    /// <param name="searchString">Substring to search for. All values are coerced to strings, so omitting it or passing undefined causes indexOf() to search for the string "undefined", which is rarely what you want.</param>
    /// <param name="position">The method returns the index of the first occurrence of the specified substring at a position greater than or equal to position, which defaults to 0. If position is greater than the length of the calling string, the method doesn't search the calling string at all. If position is less than zero, the method behaves as it would if position were 0.</param>
    /// <returns>The index of the first occurrence of searchString found, or -1 if not found.</returns>
    public static Var<int> StringIndexOf(this SyntaxBuilder b, Var<string> s, Var<string> searchString, Var<int> position = null)
    {
        return position == null ? b.CallOnObject<int>(s, "indexOf", searchString) : b.CallOnObject<int>(s, "indexOf", searchString, position);
    }

    /// <summary>
    /// The lastIndexOf() method of String values searches this string and returns the index of the last occurrence of the specified substring. It takes an optional starting position and returns the last occurrence of the specified substring at an index less than or equal to the specified number.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="s"></param>
    /// <param name="searchString">Substring to search for. All values are coerced to strings, so omitting it or passing undefined causes lastIndexOf() to search for the string "undefined", which is rarely what you want.</param>
    /// <param name="position">The method returns the index of the last occurrence of the specified substring at a position less than or equal to position, which defaults to +Infinity. If position is greater than the length of the calling string, the method searches the entire string. If position is less than 0, the behavior is the same as for 0 — that is, the method looks for the specified substring only at index 0.</param>
    /// <returns>The index of the last occurrence of searchString found, or -1 if not found.</returns>
    public static Var<int> StringLastIndexOf(this SyntaxBuilder b, Var<string> s, Var<string> searchString, Var<int> position = null)
    {
        return position == null ? b.CallOnObject<int>(s, "lastIndexOf", searchString) : b.CallOnObject<int>(s, "lastIndexOf", searchString, position);
    }

    /// <summary>
    /// The padEnd() method of String values pads this string with a given string (repeated, if needed) so that the resulting string reaches a given length. The padding is applied from the end of this string.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="s"></param>
    /// <param name="targetLength">The length of the resulting string once the current str has been padded. If the value is less than or equal to str.length, the current string will be returned as-is.</param>
    /// <param name="padString">The string to pad the current str with. If padString is too long to stay within targetLength, it will be truncated: for left-to-right languages the left-most part and for right-to-left languages the right-most will be applied. The default value for this parameter is " " (U+0020).</param>
    /// <returns>A String of the specified targetLength with the padString applied at the end of the current str.</returns>
    public static Var<string> StringPadEnd(this SyntaxBuilder b, Var<string> s, Var<int> targetLength, Var<string> padString = null)
    {
        return padString == null ? b.CallOnObject<string>(s, "padEnd", targetLength) : b.CallOnObject<string>(s, "padEnd", targetLength, padString);
    }

    /// <summary>
    /// The padStart() method of String values pads this string with another string (multiple times, if needed) until the resulting string reaches the given length. The padding is applied from the start of this string.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="s"></param>
    /// <param name="targetLength">The length of the resulting string once the current str has been padded. If the value is less than or equal to str.length, then str is returned as-is.</param>
    /// <param name="padString">The string to pad the current str with. If padString is too long to stay within the targetLength, it will be truncated from the end. The default value is the unicode "space" character (U+0020).</param>
    /// <returns>A String of the specified targetLength with padString applied from the start.</returns>
    public static Var<string> StringPadStart(this SyntaxBuilder b, Var<string> s, Var<int> targetLength, Var<string> padString = null)
    {
        return padString == null ? b.CallOnObject<string>(s, "padStart", targetLength) : b.CallOnObject<string>(s, "padStart", targetLength, padString);
    }

    /// <summary>
    /// The repeat() method of String values constructs and returns a new string which contains the specified number of copies of this string, concatenated together.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="s"></param>
    /// <param name="count">An integer between 0 and +Infinity, indicating the number of times to repeat the string.</param>
    /// <returns></returns>
    public static Var<string> StringRepeat(this SyntaxBuilder b, Var<string> s, Var<int> count)
    {
        return b.CallOnObject<string>(s, "repeat", count);
    }

    /// <summary>
    /// The replace() method of String values returns a new string with one, some, or all matches of a pattern replaced by a replacement. The pattern can be a string or a RegExp, and the replacement can be a string or a function called for each match. If pattern is a string, only the first occurrence will be replaced. The original string is left unchanged.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="s"></param>
    /// <param name="pattern">Can be a string or an object with a Symbol.replace method — the typical example being a regular expression. Any value that doesn't have the Symbol.replace method will be coerced to a string.</param>
    /// <param name="replacement">Can be a string or a function.
    /// <para>If it's a string, it will replace the substring matched by pattern. A number of special replacement patterns are supported; see the Specifying a string as the replacement section below.</para>
    /// <para>If it's a function, it will be invoked for every match and its return value is used as the replacement text. The arguments supplied to this function are described in the Specifying a function as the replacement section below.</para></param>
    /// <returns>A new string, with one, some, or all matches of the pattern replaced by the specified replacement.</returns>
    public static Var<string> StringReplace(this SyntaxBuilder b, Var<string> s, Var<string> pattern, Var<string> replacement)
    {
        return b.CallOnObject<string>(s, "replace", pattern, replacement);
    }

    /// <summary>
    /// The replaceAll() method of String values returns a new string with all matches of a pattern replaced by a replacement. The pattern can be a string or a RegExp, and the replacement can be a string or a function to be called for each match. The original string is left unchanged.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="s"></param>
    /// <param name="pattern">Can be a string or an object with a Symbol.replace method — the typical example being a regular expression.Any value that doesn't have the Symbol.replace method will be coerced to a string. If pattern is a regex, then it must have the global (g) flag set, or a TypeError is thrown.</param>
    /// <param name="replacement">Can be a string or a function. The replacement has the same semantics as that of String.prototype.replace().</param>
    /// <returns>A new string, with all matches of a pattern replaced by a replacement.</returns>
    public static Var<string> StringReplaceAll(this SyntaxBuilder b, Var<string> s, Var<string> pattern, Var<string> replacement)
    {
        return b.CallOnObject<string>(s, "replaceAll", pattern, replacement);
    }

    /// <summary>
    /// The slice() method of String values extracts a section of this string and returns it as a new string, without modifying the original string.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="s"></param>
    /// <param name="indexStart">The index of the first character to include in the returned substring.</param>
    /// <param name="indexEnd">The index of the first character to exclude from the returned substring.</param>
    /// <returns>A new string containing the extracted section of the string.</returns>
    public static Var<string> StringSlice(this SyntaxBuilder b, Var<string> s, Var<int> indexStart, Var<int> indexEnd = null)
    {
        return indexEnd == null ? b.CallOnObject<string>(s, "slice", indexStart) : b.CallOnObject<string>(s, "slice", indexStart, indexEnd);
    }

    /// <summary>
    /// The split() method of String values takes a pattern and divides this string into an ordered list of substrings by searching for the pattern, puts these substrings into an array, and returns the array.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="s"></param>
    /// <param name="separator">The pattern describing where each split should occur. Can be undefined, a string, or an object with a Symbol.split method — the typical example being a regular expression. Omitting separator or passing undefined causes split() to return an array with the calling string as a single element. All values that are not undefined or objects with a [Symbol.split]() method are coerced to strings.</param>
    /// <param name="limit">A non-negative integer specifying a limit on the number of substrings to be included in the array.If provided, splits the string at each occurrence of the specified separator, but stops when limit entries have been placed in the array. Any leftover text is not included in the array at all. The array may contain fewer entries than limit if the end of the string is reached before the limit is reached. If limit is 0, [] is returned.</param>
    /// <returns>If separator is a string, an Array of strings is returned, split at each point where the separator occurs in the given string. If separator is a regex, the returned Array also contains the captured groups for each separator match; see below for details.The capturing groups may be unmatched, in which case they are undefined in the array. If separator has a custom [Symbol.split] () method, its return value is directly returned.</returns>
    public static Var<List<string>> StringSplit(this SyntaxBuilder b, Var<string> s, Var<string> separator, Var<int> limit = null)
    {
        return limit == null ? b.CallOnObject<List<string>>(s, "split", separator) : b.CallOnObject<List<string>>(s, "split", separator, limit);
    }

    /// <summary>
    /// The startsWith() method of String values determines whether this string begins with the characters of a specified string, returning true or false as appropriate.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="s"></param>
    /// <param name="searchString">The characters to be searched for at the start of this string. Cannot be a regex. All values that are not regexes are coerced to strings, so omitting it or passing undefined causes startsWith() to search for the string "undefined", which is rarely what you want.</param>
    /// <param name="position">The start position at which searchString is expected to be found (the index of searchString's first character). Defaults to 0.</param>
    /// <returns>true if the given characters are found at the beginning of the string, including when searchString is an empty string; otherwise, false.</returns>
    public static Var<bool> StringStartsWith(this SyntaxBuilder b, Var<string> s, Var<string> searchString, Var<int> position = null)
    {
        return position == null ? b.CallOnObject<bool>(s, "startsWith", searchString) : b.CallOnObject<bool>(s, "startsWith", searchString, position);
    }

    /// <summary>
    /// The substring() method of String values returns the part of this string from the start index up to and excluding the end index, or to the end of the string if no end index is supplied.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="s"></param>
    /// <param name="indexStart">The index of the first character to include in the returned substring.</param>
    /// <param name="indexEnd">The index of the first character to exclude from the returned substring.</param>
    /// <returns>A new string containing the specified part of the given string.</returns>
    public static Var<string> StringSubstring(this SyntaxBuilder b, Var<string> s, Var<int> indexStart, Var<int> indexEnd = null)
    {
        return indexEnd == null ? b.CallOnObject<string>(s, "substring", indexStart) : b.CallOnObject<string>(s, "substring", indexStart, indexEnd);
    }

    /// <summary>
    /// The toLocaleLowerCase() method of String values returns this string converted to lower case, according to any locale-specific case mappings.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="s"></param>
    /// <returns>A new string representing the calling string converted to lower case, according to any locale-specific case mappings.</returns>
    public static Var<string> StringToLocaleLowerCase(this SyntaxBuilder b, Var<string> s)
    {
        return b.CallOnObject<string>(s, "toLocaleLowerCase");
    }

    /// <summary>
    /// The toLocaleLowerCase() method of String values returns this string converted to lower case, according to any locale-specific case mappings.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="s"></param>
    /// <param name="locales"> A string with a BCP 47 language tag, or an array of such strings.Indicates the locale to be used to convert to lower case according to any locale-specific case mappings.For the general form and interpretation of the locales argument, see the parameter description on the Intl main page. Unlike other methods that use the locales argument, toLocaleLowerCase() does not allow locale matching. Therefore, after checking the validity of the locales argument, toLocaleLowerCase() always uses the first locale in the list (or the default locale if the list is empty), even if this locale is not supported by the implementation.</param>
    /// <returns>A new string representing the calling string converted to lower case, according to any locale-specific case mappings.</returns>
    public static Var<string> StringToLocaleLowerCase(this SyntaxBuilder b, Var<string> s, Var<string> locales)
    {
        return b.CallOnObject<string>(s, "toLocaleLowerCase", locales);
    }

    /// <summary>
    /// The toLocaleLowerCase() method of String values returns this string converted to lower case, according to any locale-specific case mappings.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="s"></param>
    /// <param name="locales"> A string with a BCP 47 language tag, or an array of such strings.Indicates the locale to be used to convert to lower case according to any locale-specific case mappings.For the general form and interpretation of the locales argument, see the parameter description on the Intl main page. Unlike other methods that use the locales argument, toLocaleLowerCase() does not allow locale matching. Therefore, after checking the validity of the locales argument, toLocaleLowerCase() always uses the first locale in the list (or the default locale if the list is empty), even if this locale is not supported by the implementation.</param>
    /// <returns>A new string representing the calling string converted to lower case, according to any locale-specific case mappings.</returns>
    public static Var<string> StringToLocaleLowerCase(this SyntaxBuilder b, Var<string> s, Var<List<string>> locales)
    {
        return b.CallOnObject<string>(s, "toLocaleLowerCase", locales);
    }

    /// <summary>
    /// The toLocaleUpperCase() method of String values returns this string converted to upper case, according to any locale-specific case mappings.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="s"></param>
    /// <returns>A new string representing the calling string converted to upper case, according to any locale-specific case mappings.</returns>
    public static Var<string> StringToLocaleUpperCase(this SyntaxBuilder b, Var<string> s)
    {
        return b.CallOnObject<string>(s, "toLocaleUpperCase");
    }

    /// <summary>
    /// The toLocaleUpperCase() method of String values returns this string converted to upper case, according to any locale-specific case mappings.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="s"></param>
    /// <param name="locales">A string with a BCP 47 language tag, or an array of such strings.Indicates the locale to be used to convert to upper case according to any locale-specific case mappings.For the general form and interpretation of the locales argument, see the parameter description on the Intl main page. Unlike other methods that use the locales argument, toLocaleUpperCase() does not allow locale matching. Therefore, after checking the validity of the locales argument, toLocaleUpperCase() always uses the first locale in the list (or the default locale if the list is empty), even if this locale is not supported by the implementation.</param>
    /// <returns>A new string representing the calling string converted to upper case, according to any locale-specific case mappings.</returns>
    public static Var<string> StringToLocaleUpperCase(this SyntaxBuilder b, Var<string> s, Var<string> locales)
    {
        return b.CallOnObject<string>(s, "toLocaleUpperCase", locales);
    }

    /// <summary>
    /// The toLocaleUpperCase() method of String values returns this string converted to upper case, according to any locale-specific case mappings.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="s"></param>
    /// <param name="locales">A string with a BCP 47 language tag, or an array of such strings.Indicates the locale to be used to convert to upper case according to any locale-specific case mappings.For the general form and interpretation of the locales argument, see the parameter description on the Intl main page. Unlike other methods that use the locales argument, toLocaleUpperCase() does not allow locale matching. Therefore, after checking the validity of the locales argument, toLocaleUpperCase() always uses the first locale in the list (or the default locale if the list is empty), even if this locale is not supported by the implementation.</param>
    /// <returns>A new string representing the calling string converted to upper case, according to any locale-specific case mappings.</returns>
    public static Var<string> StringToLocaleUpperCase(this SyntaxBuilder b, Var<string> s, Var<List<string>> locales)
    {
        return b.CallOnObject<string>(s, "toLocaleUpperCase", locales);
    }

    /// <summary>
    /// The toLowerCase() method of String values returns this string converted to lower case.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="s"></param>
    /// <returns>A new string representing the calling string converted to lower case.</returns>
    public static Var<string> StringToLowerCase(this SyntaxBuilder b, Var<string> s)
    {
        return b.CallOnObject<string>(s, "toLowerCase");
    }

    /// <summary>
    /// The toUpperCase() method of String values returns this string converted to uppercase.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="s"></param>
    /// <returns>A new string representing the calling string converted to upper case.</returns>
    public static Var<string> StringToUpperCase(this SyntaxBuilder b, Var<string> s)
    {
        return b.CallOnObject<string>(s, "toUpperCase");
    }

    /// <summary>
    /// The trim() method of String values removes whitespace from both ends of this string and returns a new string, without modifying the original string.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="s"></param>
    /// <returns>A new string representing str stripped of whitespace from both its beginning and end. Whitespace is defined as white space characters plus line terminators. If neither the beginning or end of str has any whitespace, a new string is still returned(essentially a copy of str).</returns>
    public static Var<string> StringTrim(this SyntaxBuilder b, Var<string> s)
    {
        return b.CallOnObject<string>(s, "trim");
    }

    /// <summary>
    /// The trimEnd() method of String values removes whitespace from the end of this string and returns a new string, without modifying the original string. trimRight() is an alias of this method.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="s"></param>
    /// <returns>A new string representing str stripped of whitespace from its end (right side). Whitespace is defined as white space characters plus line terminators. If the end of str has no whitespace, a new string is still returned(essentially a copy of str).</returns>
    public static Var<string> StringTrimEnd(this SyntaxBuilder b, Var<string> s)
    {
        return b.CallOnObject<string>(s, "trimEnd");
    }

    /// <summary>
    /// The trimStart() method of String values removes whitespace from the beginning of this string and returns a new string, without modifying the original string. trimLeft() is an alias of this method.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="s"></param>
    /// <returns>A new string representing str stripped of whitespace from its beginning (left side). Whitespace is defined as white space characters plus line terminators. If the beginning of str has no whitespace, a new string is still returned(essentially a copy of str).</returns>
    public static Var<string> StringTrimStart(this SyntaxBuilder b, Var<string> s)
    {
        return b.CallOnObject<string>(s, "trimStart");
    }
}