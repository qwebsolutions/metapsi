using Metapsi.Syntax;
using System.Numerics;

namespace Metapsi.Html
{
    /// <summary>
    /// 
    /// </summary>
    public static class MathExtensions
    {
        private static Var<object> MathStatic(this SyntaxBuilder b)
        {
            return b.GetProperty<object>(b.Self(), "Math");
        }

        /// <summary>
        /// The Math.min() static method returns the smallest of the numbers given as input parameters, or Infinity if there are no parameters.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="b"></param>
        /// <param name="values"></param>
        /// <returns></returns>
        public static Var<T> MathMin<T>(this SyntaxBuilder b, params Var<T>[] values)
            where T: INumber<T>
        {
            return b.CallOnObject<T>(b.MathStatic(), "min", values);
        }

        /// <summary>
        /// The Math.max() static method returns the largest of the numbers given as input parameters, or -Infinity if there are no parameters.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="b"></param>
        /// <param name="values"></param>
        /// <returns></returns>
        public static Var<T> MathMax<T>(this SyntaxBuilder b, params Var<T>[] values)
            where T : INumber<T>
        {
            return b.CallOnObject<T>(b.MathStatic(), "max", values);
        }
    }
}
