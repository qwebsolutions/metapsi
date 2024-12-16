import { v4 as uuidv4, NIL as NIL_UUID } from '/uuid.js';

export const TryCatchReturn = (tryFunc, catchFunc) => {
    try {
        return tryFunc()
    } catch (error) {
        return catchFunc(error)
    }
}
export const Serialize = JSON.stringify
export const Deserialize = JSON.parse
export const AreEqual = (left, right) => left === right
export const Concat = (args) => { var r = ''; args.forEach(x => r += !x ? '' : x); return r }
export const Split = (initialString, separator) => initialString.split(separator);
export const SubstringStart = (initialString, start) => initialString.substr(start);
export const SubstringStartLength = (initialString, start, length) => initialString.substr(start, length);
export const Slice = (initialString, start, end) => initialString.slice(start, end);
export const Replace = (initialString, oldText, newText) => initialString.replace(oldText, newText);
export const Push = (into, item) => into.push(item)
export const Clear = (collection) => collection.length = 0;
export const IndexOf = (collection, item) => collection.indexOf(item)
export const Remove = (collection, item) => {
    var index = collection.indexOf(item)
    if (index >= 0) {
        collection.splice(index, 1)
    }
}

export const HasValue = (s) => !(!s)
export const IsNull = (s) => !s
export const GetExpr = (expr, ...args) => console.log(expr)
export const IsEmptyString = (s) => !s
export const IsEmptyObject = (s) => !s
export const IsEmptyGuid = (id) => { if (id === '00000000-0000-0000-0000-000000000000') return true; return !id }
export const HasObject = (s) => !(!s)
export const CloneCollection = (x) => Array.from(x)
export const CloneObject = (x) => ({ ...x })
export const EmptyId = () => NIL_UUID
export const NewId = uuidv4
export const ToLowercase = (s) => !s ? "" : s.toLowerCase()
export const Trim = (s) => !s ? "" : s.trim()
export const EndsWith = (larger, end) => larger.endsWith(end);
export const Not = (s) => !s
export const And = (l, r) => l && r
export const Or = (l, r) => l || r
export const Log = (s) => console.log(s)
export const ParseDate = (s) => new Date(s)
export const FormatLocaleDateTime = (dateTime, localeCode, options) => dateTime.toLocaleString(localeCode, options);
export const FormatLocaleDate = (dateTime, localeCode, options) => dateTime.toLocaleDateString(localeCode, options);
export const GetProperty = (obj, propName) => {
    var r = obj[propName];
    return r;
}
export const SetProperty = (obj, propName, value) => obj[propName] = value;
export const DeleteProperty = (obj, propName) => delete obj[propName];
export const AsString = (obj) => "" + obj;
export const ParseId = (id) => id;
export const ParseInt = (v) => parseInt(v);
export const StringIncludes = (large, small) => large.includes(small);
export const ArrayIncludes = (array, item) => array.includes(item);
export const ObjectValues = Object.values
export const Minus = (n) => n * -1;
export const Add = (n1, n2) => n1 + n2;
export const ToFixed = (n, digits) => n.toFixed(digits);

export const GetHours = (d) => new Date(d).getHours();
export const GetMinutes = (d) => new Date(d).getMinutes();
export const Floor = (n) => Math.floor(n);
export const RemoveEventListener = removeEventListener;
export const SetInterval = setInterval;
export const ClearInterval = clearInterval;
export const ParseDecimal = (z) => parseFloat(z);

export const Undefined = () => {
    return undefined;
}

export const CreateObjectUrl = URL.createObjectURL;
export const ToBase64 = (o) => btoa(o)

export const FileToBase64 = (file, onResult, onError) => {
    var reader = new FileReader();
    reader.readAsDataURL(file);
    reader.onload = function () {
        onResult(file, reader.result);
    };
    reader.onerror = function (error) {
        onError(error);
    };
};

export const Chars = (s) => [...s]
export const JoinChars = (chars) => chars.join("");

export const CharToUpperCase = (c) => c.toUpperCase();
export const CharToLowerCase = (c) => c.toLowerCase();

export const CallOnObject = (object, functionName, ...args) => object[functionName](...args)

export const NewPromise = (callback) => new Promise(callback)
export const GetStaticPromise = () => Promise;

export const Self = () => self;
export const Throw = (message) => { throw new Error(message) }
export const New = (f, ...args) => new f(...args);
export const In = (value, obj) => value in obj;
