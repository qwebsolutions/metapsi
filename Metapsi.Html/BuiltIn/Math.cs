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
        /// <param name="b"></param>
        /// <param name="values"></param>
        /// <returns></returns>
        public static Var<int> MathMin(this SyntaxBuilder b, params Var<int>[] values)
        {
            return b.CallOnObject<int>(b.MathStatic(), "min", values);
        }

        /// <summary>
        /// The Math.min() static method returns the smallest of the numbers given as input parameters, or Infinity if there are no parameters.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="values"></param>
        /// <returns></returns>
        public static Var<long> MathMin(this SyntaxBuilder b, params Var<long>[] values)
        {
            return b.CallOnObject<long>(b.MathStatic(), "min", values);
        }

        /// <summary>
        /// The Math.min() static method returns the smallest of the numbers given as input parameters, or Infinity if there are no parameters.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="values"></param>
        /// <returns></returns>
        public static Var<decimal> MathMin(this SyntaxBuilder b, params Var<decimal>[] values)
        {
            return b.CallOnObject<decimal>(b.MathStatic(), "min", values);
        }

        /// <summary>
        /// The Math.min() static method returns the smallest of the numbers given as input parameters, or Infinity if there are no parameters.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="values"></param>
        /// <returns></returns>
        public static Var<double> MathMin(this SyntaxBuilder b, params Var<double>[] values)
        {
            return b.CallOnObject<double>(b.MathStatic(), "min", values);
        }

        /// <summary>
        /// The Math.max() static method returns the largest of the numbers given as input parameters, or -Infinity if there are no parameters.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="values"></param>
        /// <returns></returns>
        public static Var<int> MathMax(this SyntaxBuilder b, params Var<int>[] values)
        {
            return b.CallOnObject<int>(b.MathStatic(), "max", values);
        }

        /// <summary>
        /// The Math.max() static method returns the largest of the numbers given as input parameters, or -Infinity if there are no parameters.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="values"></param>
        /// <returns></returns>
        public static Var<long> MathMax(this SyntaxBuilder b, params Var<long>[] values)
        {
            return b.CallOnObject<long>(b.MathStatic(), "max", values);
        }

        /// <summary>
        /// The Math.max() static method returns the largest of the numbers given as input parameters, or -Infinity if there are no parameters.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="values"></param>
        /// <returns></returns>
        public static Var<decimal> MathMax(this SyntaxBuilder b, params Var<decimal>[] values)
        {
            return b.CallOnObject<decimal>(b.MathStatic(), "max", values);
        }

        /// <summary>
        /// The Math.max() static method returns the largest of the numbers given as input parameters, or -Infinity if there are no parameters.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="values"></param>
        /// <returns></returns>
        public static Var<double> MathMax(this SyntaxBuilder b, params Var<double>[] values)
        {
            return b.CallOnObject<double>(b.MathStatic(), "max", values);
        }
    }
}
