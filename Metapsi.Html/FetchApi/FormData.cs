using Metapsi.Syntax;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Metapsi.Html
{
    /// <summary>
    /// The FormData interface provides a way to construct a set of key/value pairs representing form fields and their values, which can be sent using the fetch(), XMLHttpRequest.send() or navigator.sendBeacon() methods. It uses the same format a form would use if the encoding type were set to "multipart/form-data".
    /// </summary>
    public interface FormData
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public static class FormDataExtensions
    {
        /// <summary>
        /// The append() method of the FormData interface appends a new value onto an existing key inside a FormData object, or adds the key if it does not already exist.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="formData"></param>
        /// <param name="name">The name of the field whose data is contained in value.</param>
        /// <param name="value">The field's value.</param>
        public static void FormDataAppend(this SyntaxBuilder b, Var<FormData> formData, Var<string> name, Var<string> value)
        {
            b.CallOnObject(formData, "append", name, value);
        }

        /// <summary>
        /// The append() method of the FormData interface appends a new value onto an existing key inside a FormData object, or adds the key if it does not already exist.
        /// </summary>
        /// <typeparam name="TBlob"></typeparam>
        /// <param name="b"></param>
        /// <param name="formData"></param>
        /// <param name="name">The name of the field whose data is contained in value.</param>
        /// <param name="value">The field's value. This can be a Blob (including subclasses such as File)</param>
        public static void FormDataAppend<TBlob>(this SyntaxBuilder b, Var<FormData> formData, Var<string> name, Var<TBlob> value)
            where TBlob: Blob
        {
            b.CallOnObject(formData, "append", name, value);
        }

        /// <summary>
        /// The append() method of the FormData interface appends a new value onto an existing key inside a FormData object, or adds the key if it does not already exist.
        /// </summary>
        /// <typeparam name="TBlob"></typeparam>
        /// <param name="b"></param>
        /// <param name="formData"></param>
        /// <param name="name">The name of the field whose data is contained in value.</param>
        /// <param name="value">The field's value. This can be a Blob (including subclasses such as File)</param>
        /// <param name="filename">The filename reported to the server (a string), when a Blob or File is passed as the second parameter. The default filename for Blob objects is "blob". The default filename for File objects is the file's filename.</param>
        public static void FormDataAppend<TBlob>(this SyntaxBuilder b, Var<FormData> formData, Var<string> name, Var<TBlob> value, Var<string> filename)
            where TBlob : Blob
        {
            b.CallOnObject(formData, "append", name, value, filename);
        }

        /// <summary>
        /// The delete() method of the FormData interface deletes a key and its value(s) from a FormData object.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="formData"></param>
        /// <param name="name">The name of the key you want to delete.</param>
        public static void FormDataDelete(this SyntaxBuilder b, Var<FormData> formData, Var<string> name)
        {
            b.CallOnObject(formData, "delete", name);
        }

        /// <summary>
        /// The FormData.entries() method returns an iterator which iterates through all key/value pairs contained in the FormData. The key of each pair is a string, and the value is either a string or a Blob.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="formData"></param>
        /// <returns>An iterator of FormData's key/value pairs.</returns>
        public static Var<object> FormDataEntries(this SyntaxBuilder b, Var<FormData> formData)
        {
            return b.CallOnObject<object>(formData, "entries");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="b"></param>
        /// <param name="formData"></param>
        /// <param name="name">A string representing the name of the key you want to retrieve.</param>
        /// <returns>A value whose key matches the specified name. Otherwise, null.</returns>
        public static Var<object> FormDataGet(this SyntaxBuilder b, Var<FormData> formData, Var<string> name)
        {
            return b.CallOnObject<object>(formData, "get", name);
        }

        /// <summary>
        /// The getAll() method of the FormData interface returns all the values associated with a given key from within a FormData object.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="formData"></param>
        /// <param name="name">A string representing the name of the key you want to retrieve.</param>
        /// <returns>An array of values whose key matches the specified name. Otherwise, an empty list.</returns>
        public static Var<List<object>> FormDataGetAll(this SyntaxBuilder b, Var<FormData> formData, Var<string> name)
        {
            return b.CallOnObject<List<object>>(formData, "getAll", name);
        }

        /// <summary>
        /// The has() method of the FormData interface returns whether a FormData object contains a certain key.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="formData"></param>
        /// <param name="name">A string representing the name of the key you want to test for.</param>
        /// <returns>true if a key of FormData matches the specified name. Otherwise, false.</returns>
        public static Var<bool> FormDataHas(this SyntaxBuilder b, Var<FormData> formData, Var<string> name)
        {
            return b.CallOnObject<bool>(formData, "has", name);
        }

        /// <summary>
        /// The FormData.keys() method returns an iterator which iterates through all keys contained in the FormData. The keys are strings.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="formData"></param>
        /// <returns>An iterator of FormData's keys.</returns>
        public static Var<object> FormDataKeys(this SyntaxBuilder b, Var<FormData> formData)
        {
            return b.CallOnObject<object>(formData, "keys");
        }

        /// <summary>
        /// The set() method of the FormData interface sets a new value for an existing key inside a FormData object, or adds the key/value if it does not already exist.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="formData"></param>
        /// <param name="name">The name of the field whose data is contained in value.</param>
        /// <param name="value">The field's value.</param>
        public static void FormDataSet(this SyntaxBuilder b, Var<FormData> formData, Var<string> name, Var<string> value)
        {
            b.CallOnObject(formData, "set", name, value);
        }

        /// <summary>
        /// The set() method of the FormData interface sets a new value for an existing key inside a FormData object, or adds the key/value if it does not already exist.
        /// </summary>
        /// <typeparam name="TBlob"></typeparam>
        /// <param name="b"></param>
        /// <param name="formData"></param>
        /// <param name="name">The name of the field whose data is contained in value.</param>
        /// <param name="value">The field's value. This can be a Blob (including subclasses such as File)</param>
        public static void FormDataSet<TBlob>(this SyntaxBuilder b, Var<FormData> formData, Var<string> name, Var<TBlob> value)
            where TBlob : Blob
        {
            b.CallOnObject(formData, "set", name, value);
        }

        /// <summary>
        /// The set() method of the FormData interface sets a new value for an existing key inside a FormData object, or adds the key/value if it does not already exist.
        /// </summary>
        /// <typeparam name="TBlob"></typeparam>
        /// <param name="b"></param>
        /// <param name="formData"></param>
        /// <param name="name">The name of the field whose data is contained in value.</param>
        /// <param name="value">The field's value. This can be a Blob (including subclasses such as File)</param>
        /// <param name="filename">The filename reported to the server (a string), when a Blob or File is passed as the second parameter. The default filename for Blob objects is "blob". The default filename for File objects is the file's filename.</param>
        public static void FormDataSet<TBlob>(this SyntaxBuilder b, Var<FormData> formData, Var<string> name, Var<TBlob> value, Var<string> filename)
            where TBlob : Blob
        {
            b.CallOnObject(formData, "set", name, value, filename);
        }

        /// <summary>
        /// The FormData.values() method returns an iterator which iterates through all values contained in the FormData. The values are strings or Blob objects.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="formData"></param>
        /// <returns></returns>
        public static Var<object> FormDataValues(this SyntaxBuilder b, Var<FormData> formData)
        {
            return b.CallOnObject<object>(formData, "values");
        }
    }
}
