using Metapsi.Syntax;
using System.Collections.Generic;

namespace Metapsi.Html;

/// <summary>
/// Error objects are thrown when runtime errors occur. The Error object can also be used as a base object for user-defined exceptions.
/// </summary>
public interface Error
{
    /// <summary>
    /// The cause data property of an Error instance indicates the specific original cause of the error. It is used when catching and re-throwing an error with a more-specific or useful error message in order to still have access to the original error.
    /// </summary>
    DynamicObject cause { get; set; }

    /// <summary>
    /// The message data property of an Error instance is a human-readable description of the error.
    /// </summary>
    string message { get; set; }

    /// <summary>
    /// The name data property of Error.prototype is shared by all Error instances. It represents the name for the type of error. For Error.prototype.name, the initial value is "Error". Subclasses like TypeError and SyntaxError provide their own name properties.
    /// </summary>
    string name { get; set; }
}

/// <summary>
/// The RangeError object indicates an error when a value is not in the set or range of allowed values.
/// </summary>
public interface RangeError : Error
{

}

/// <summary>
/// The ReferenceError object represents an error when a variable that doesn't exist (or hasn't yet been initialized) in the current scope is referenced.
/// </summary>
public interface ReferenceError : Error
{

}

/// <summary>
/// The SyntaxError object represents an error when trying to interpret syntactically invalid code. It is thrown when the JavaScript engine encounters tokens or token order that does not conform to the syntax of the language when parsing code.
/// </summary>
public interface SyntaxError : Error
{

}

/// <summary>
/// The TypeError object represents an error when an operation could not be performed, typically (but not exclusively) when a value is not of the expected type.
/// </summary>
public interface TypeError : Error
{

}

/// <summary>
/// The URIError object represents an error when a global URI handling function was used in a wrong way.
/// </summary>
public interface URIError : Error
{

}


/// <summary>
/// The AggregateError object represents an error when several errors need to be wrapped in a single error. It is thrown when multiple errors need to be reported by an operation, for example by Promise.any(), when all promises passed to it reject.
/// </summary>
public interface AggregateError
{
    /// <summary>
    /// The errors data property of an AggregateError instance contains an array representing the errors that were aggregated.
    /// </summary>
    List<Error> errors { get;  }
}


/// <summary>
/// 
/// </summary>
public static class ErrorExtensions
{
    /// <summary>
    /// The toString() method of Error instances returns a string representing this error.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="b"></param>
    /// <param name="error"></param>
    /// <returns></returns>
    public static Var<string> ErrorToString<T>(this SyntaxBuilder b, Var<T> error)
        where T: Error
    {
        return b.CallOnObject<string>(error, "toString");
    }
}