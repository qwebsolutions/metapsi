using Metapsi.Syntax;
using System.Numerics;

namespace Metapsi.Html
{
    public static class MathExtensions
    {
        private static Var<object> MathStatic(this SyntaxBuilder b)
        {
            return b.GetProperty<object>(b.Self(), "Math");
        }

        /// <summary>
        /// Returns the absolute value of a number.
        /// </summary>
        /// <param name="x">The number to get the absolute value of.</param>
        /// <returns>The absolute value of <paramref name="x"/>.</returns>
        public static Var<decimal> MathAbs(this SyntaxBuilder b, Var<decimal> x)
        {
            return b.CallOnObject<decimal>(b.MathStatic(), "abs", x);
        }

        /// <summary>
        /// Returns the arccosine of a number.
        /// </summary>
        /// <param name="x">A number representing a cosine value.</param>
        /// <returns>The arccosine of <paramref name="x"/> in radians.</returns>
        public static Var<decimal> MathAcos(this SyntaxBuilder b, Var<decimal> x)
        {
            return b.CallOnObject<decimal>(b.MathStatic(), "acos", x);
        }

        /// <summary>
        /// Returns the hyperbolic arccosine of a number.
        /// </summary>
        /// <param name="x">A number greater than or equal to 1.</param>
        /// <returns>The hyperbolic arccosine of <paramref name="x"/>.</returns>
        public static Var<decimal> MathAcosh(this SyntaxBuilder b, Var<decimal> x)
        {
            return b.CallOnObject<decimal>(b.MathStatic(), "acosh", x);
        }

        /// <summary>
        /// Returns the arcsine of a number.
        /// </summary>
        /// <param name="x">A number representing a sine value.</param>
        /// <returns>The arcsine of <paramref name="x"/> in radians.</returns>
        public static Var<decimal> MathAsin(this SyntaxBuilder b, Var<decimal> x)
        {
            return b.CallOnObject<decimal>(b.MathStatic(), "asin", x);
        }

        /// <summary>
        /// Returns the hyperbolic arcsine of a number.
        /// </summary>
        /// <param name="x">A number.</param>
        /// <returns>The hyperbolic arcsine of <paramref name="x"/>.</returns>
        public static Var<decimal> MathAsinh(this SyntaxBuilder b, Var<decimal> x)
        {
            return b.CallOnObject<decimal>(b.MathStatic(), "asinh", x);
        }

        /// <summary>
        /// Returns the arctangent of a number.
        /// </summary>
        /// <param name="x">A number representing a tangent value.</param>
        /// <returns>The arctangent of <paramref name="x"/> in radians.</returns>
        public static Var<decimal> MathAtan(this SyntaxBuilder b, Var<decimal> x)
        {
            return b.CallOnObject<decimal>(b.MathStatic(), "atan", x);
        }

        /// <summary>
        /// Returns the hyperbolic arctangent of a number.
        /// </summary>
        /// <param name="x">A number between -1 and 1 exclusive.</param>
        /// <returns>The hyperbolic arctangent of <paramref name="x"/>.</returns>
        public static Var<decimal> MathAtanh(this SyntaxBuilder b, Var<decimal> x)
        {
            return b.CallOnObject<decimal>(b.MathStatic(), "atanh", x);
        }

        /// <summary>
        /// Returns the arctangent of the quotient of its arguments.
        /// </summary>
        /// <param name="y">The y-coordinate.</param>
        /// <param name="x">The x-coordinate.</param>
        /// <returns>The arctangent of <paramref name="y"/> / <paramref name="x"/> in radians.</returns>
        public static Var<decimal> MathAtan2(this SyntaxBuilder b, Var<decimal> y, Var<decimal> x)
        {
            return b.CallOnObject<decimal>(b.MathStatic(), "atan2", y, x);
        }

        /// <summary>
        /// Returns the cube root of a number.
        /// </summary>
        /// <param name="x">A number to get the cube root of.</param>
        /// <returns>The cube root of <paramref name="x"/>.</returns>
        public static Var<decimal> MathCbrt(this SyntaxBuilder b, Var<decimal> x)
        {
            return b.CallOnObject<decimal>(b.MathStatic(), "cbrt", x);
        }

        /// <summary>
        /// Returns the smallest integer greater than or equal to a number.
        /// </summary>
        /// <param name="x">The number to ceil.</param>
        /// <returns>The smallest integer greater than or equal to <paramref name="x"/>.</returns>
        public static Var<decimal> MathCeil(this SyntaxBuilder b, Var<decimal> x)
        {
            return b.CallOnObject<decimal>(b.MathStatic(), "ceil", x);
        }

        /// <summary>
        /// Returns the number of leading zero bits in the 32-bit binary representation of the given number.
        /// </summary>
        /// <param name="x">A 32-bit integer.</param>
        /// <returns>The number of leading zero bits in <paramref name="x"/>.</returns>
        public static Var<int> MathClz32(this SyntaxBuilder b, Var<int> x)
        {
            return b.CallOnObject<int>(b.MathStatic(), "clz32", x);
        }

        /// <summary>
        /// Returns the cosine of a number.
        /// </summary>
        /// <param name="x">An angle in radians.</param>
        /// <returns>The cosine of <paramref name="x"/>.</returns>
        public static Var<decimal> MathCos(this SyntaxBuilder b, Var<decimal> x)
        {
            return b.CallOnObject<decimal>(b.MathStatic(), "cos", x);
        }

        /// <summary>
        /// Returns the hyperbolic cosine of a number.
        /// </summary>
        /// <param name="x">A number.</param>
        /// <returns>The hyperbolic cosine of <paramref name="x"/>.</returns>
        public static Var<decimal> MathCosh(this SyntaxBuilder b, Var<decimal> x)
        {
            return b.CallOnObject<decimal>(b.MathStatic(), "cosh", x);
        }

        /// <summary>
        /// Returns e raised to the power of a number.
        /// </summary>
        /// <param name="x">The exponent.</param>
        /// <returns>The value of e raised to the power <paramref name="x"/>.</returns>
        public static Var<decimal> MathExp(this SyntaxBuilder b, Var<decimal> x)
        {
            return b.CallOnObject<decimal>(b.MathStatic(), "exp", x);
        }

        /// <summary>
        /// Returns e raised to the power of a number minus one.
        /// </summary>
        /// <param name="x">The exponent.</param>
        /// <returns>The value of e raised to the power <paramref name="x"/> minus one.</returns>
        public static Var<decimal> MathExpm1(this SyntaxBuilder b, Var<decimal> x)
        {
            return b.CallOnObject<decimal>(b.MathStatic(), "expm1", x);
        }

        /// <summary>
        /// Returns the largest integer less than or equal to a number.
        /// </summary>
        /// <param name="x">The number to floor.</param>
        /// <returns>The largest integer less than or equal to <paramref name="x"/>.</returns>
        public static Var<decimal> MathFloor(this SyntaxBuilder b, Var<decimal> x)
        {
            return b.CallOnObject<decimal>(b.MathStatic(), "floor", x);
        }

        /// <summary>
        /// Returns the natural logarithm (base e) of a number.
        /// </summary>
        /// <param name="x">A number greater than 0.</param>
        /// <returns>The natural logarithm of <paramref name="x"/>.</returns>
        public static Var<decimal> MathLog(this SyntaxBuilder b, Var<decimal> x)
        {
            return b.CallOnObject<decimal>(b.MathStatic(), "log", x);
        }

        /// <summary>
        /// Returns the base 10 logarithm of a number.
        /// </summary>
        /// <param name="x">A number greater than 0.</param>
        /// <returns>The base 10 logarithm of <paramref name="x"/>.</returns>
        public static Var<decimal> MathLog10(this SyntaxBuilder b, Var<decimal> x)
        {
            return b.CallOnObject<decimal>(b.MathStatic(), "log10", x);
        }

        /// <summary>
        /// Returns the natural logarithm of 1 + x (ln(1 + x)).
        /// </summary>
        /// <param name="x">A number greater than -1.</param>
        /// <returns>The natural logarithm of 1 plus <paramref name="x"/>.</returns>
        public static Var<decimal> MathLog1p(this SyntaxBuilder b, Var<decimal> x)
        {
            return b.CallOnObject<decimal>(b.MathStatic(), "log1p", x);
        }

        /// <summary>
        /// Returns the base 2 logarithm of a number.
        /// </summary>
        /// <param name="x">A number greater than 0.</param>
        /// <returns>The base 2 logarithm of <paramref name="x"/>.</returns>
        public static Var<decimal> MathLog2(this SyntaxBuilder b, Var<decimal> x)
        {
            return b.CallOnObject<decimal>(b.MathStatic(), "log2", x);
        }

        /// <summary>
        /// Returns the maximum of zero or more numbers.
        /// </summary>
        /// <param name="values">An array of numbers to compare.</param>
        /// <returns>The largest of the given numbers.</returns>
        public static Var<decimal> MathMax(this SyntaxBuilder b, params Var<decimal>[] values)
        {
            return b.CallOnObject<decimal>(b.MathStatic(), "max", values);
        }

        /// <summary>
        /// Returns the minimum of zero or more numbers.
        /// </summary>
        /// <param name="values">An array of numbers to compare.</param>
        /// <returns>The smallest of the given numbers.</returns>
        public static Var<decimal> MathMin(this SyntaxBuilder b, params Var<decimal>[] values)
        {
            return b.CallOnObject<decimal>(b.MathStatic(), "min", values);
        }

        /// <summary>
        /// Returns the base to the exponent power, that is, base^exponent.
        /// </summary>
        /// <param name="baseValue">The base number.</param>
        /// <param name="exponent">The exponent to raise the base to.</param>
        /// <returns>The value of <paramref name="baseValue"/> raised to the power <paramref name="exponent"/>.</returns>
        public static Var<decimal> MathPow(this SyntaxBuilder b, Var<decimal> baseValue, Var<decimal> exponent)
        {
            return b.CallOnObject<decimal>(b.MathStatic(), "pow", baseValue, exponent);
        }

        /// <summary>
        /// Returns a pseudo-random number between 0 (inclusive) and 1 (exclusive).
        /// </summary>
        /// <returns>A pseudo-random number in the range [0, 1).</returns>
        public static Var<decimal> MathRandom(this SyntaxBuilder b)
        {
            return b.CallOnObject<decimal>(b.MathStatic(), "random");
        }

        /// <summary>
        /// Returns the square root of the sum of the squares of its arguments.
        /// </summary>
        /// <param name="values">An array of numbers.</param>
        /// <returns>The square root of the sum of squares of the given numbers.</returns>
        public static Var<decimal> MathHypot(this SyntaxBuilder b, params Var<decimal>[] values)
        {
            return b.CallOnObject<decimal>(b.MathStatic(), "hypot", values);
        }

        /// <summary>
        /// Returns the value of a number rounded to the nearest integer.
        /// </summary>
        /// <param name="x">The number to round.</param>
        /// <returns>The nearest integer to <paramref name="x"/>.</returns>
        public static Var<decimal> MathRound(this SyntaxBuilder b, Var<decimal> x)
        {
            return b.CallOnObject<decimal>(b.MathStatic(), "round", x);
        }

        /// <summary>
        /// Returns the sign of a number, indicating whether the number is positive, negative, or zero.
        /// </summary>
        /// <param name="x">The number to determine the sign of.</param>
        /// <returns>1 if positive, -1 if negative, and 0 if zero.</returns>
        public static Var<decimal> MathSign(this SyntaxBuilder b, Var<decimal> x)
        {
            return b.CallOnObject<decimal>(b.MathStatic(), "sign", x);
        }

        /// <summary>
        /// Returns the sine of a number.
        /// </summary>
        /// <param name="x">An angle in radians.</param>
        /// <returns>The sine of <paramref name="x"/>.</returns>
        public static Var<decimal> MathSin(this SyntaxBuilder b, Var<decimal> x)
        {
            return b.CallOnObject<decimal>(b.MathStatic(), "sin", x);
        }

        /// <summary>
        /// Returns the hyperbolic sine of a number.
        /// </summary>
        /// <param name="x">A number.</param>
        /// <returns>The hyperbolic sine of <paramref name="x"/>.</returns>
        public static Var<decimal> MathSinh(this SyntaxBuilder b, Var<decimal> x)
        {
            return b.CallOnObject<decimal>(b.MathStatic(), "sinh", x);
        }

        /// <summary>
        /// Returns the square root of a number.
        /// </summary>
        /// <param name="x">A number to get the square root of.</param>
        /// <returns>The square root of <paramref name="x"/>.</returns>
        public static Var<decimal> MathSqrt(this SyntaxBuilder b, Var<decimal> x)
        {
            return b.CallOnObject<decimal>(b.MathStatic(), "sqrt", x);
        }

        /// <summary>
        /// Returns the tangent of a number.
        /// </summary>
        /// <param name="x">An angle in radians.</param>
        /// <returns>The tangent of <paramref name="x"/>.</returns>
        public static Var<decimal> MathTan(this SyntaxBuilder b, Var<decimal> x)
        {
            return b.CallOnObject<decimal>(b.MathStatic(), "tan", x);
        }

        /// <summary>
        /// Returns the hyperbolic tangent of a number.
        /// </summary>
        /// <param name="x">A number.</param>
        /// <returns>The hyperbolic tangent of <paramref name="x"/>.</returns>
        public static Var<decimal> MathTanh(this SyntaxBuilder b, Var<decimal> x)
        {
            return b.CallOnObject<decimal>(b.MathStatic(), "tanh", x);
        }

        /// <summary>
        /// Returns the integral part of a number by removing any fractional digits.
        /// </summary>
        /// <param name="x">A number to truncate.</param>
        /// <returns>The integral part of <paramref name="x"/>.</returns>
        public static Var<decimal> MathTrunc(this SyntaxBuilder b, Var<decimal> x)
        {
            return b.CallOnObject<decimal>(b.MathStatic(), "trunc", x);
        }
    }
}
