//----------------------------------------------------------------------------------------------
// <copyright file="TypedMathDoubleExtension" company="MarcusMedinaPro">
// By Marcus Medina, 2019 - http://MarcusMedina.Pro 
// This file is subject to the terms and conditions defined in file 'license.txt', which is part of this project.
// </copyright>
// ----------------------------------------------------------------------------------------------
namespace MarcusMedinaPro.TypedMath.DoubleExtension
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class TypedMathDoubleExtension
    {

        /// <summary>
        /// Gets the NOT of double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <returns>The result of the operation</returns>
        public static double Not(this double x) =>(double) ~ (int)x;
        /// <summary>
        /// Checks if a number is prime
        /// </summary>
        /// <param name="number">The number</param>
        /// <returns>True if the number is prime</returns>
        public static bool IsPrime(this double number) => Enumerable.Range(2, (int)Math.Sqrt(number) - 1).All(divisor => number % divisor != 0);
        /// <summary>
        /// Compare original and second number
        /// </summary>
        /// <param name="first">The number</param>
        /// <param name="second">The number to compare with</param>
        /// <returns>The highest of the two numbers</returns>
        public static double ChooseHighestValue(this double first, double second) => first > second ? first : second;

        /// <summary>
        /// Compare original and second number
        /// </summary>
        /// <param name="first">The number</param>
        /// <param name="second">The number to compare with</param>
        /// <returns>The lowest of the two numbers</returns>
        public static double ChooseLowestValue(this double first, double second) => first < second ? first : second;

        /// <summary>
        /// Swaps two variables 
        /// </summary>
        /// <param name="first">The main variable</param>
        /// <param name="second">The variable to switch with</param>
        /// <returns>The value from the second variable and sets second variable to original value</returns>
        public static double SwapWith(this double first, ref double second)
        {
            var tmp = second;
            second = first;
            return tmp;
        }
        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static double PercentOf(this double percent, double value) => (double)(((double)percent) / ((double)100) * ((double)value));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static double AddPercent(this double value, double percent) => (double)(value + value.PercentOf(percent));

        /// <summary>
        /// Substracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static double SubstractPercent(this double value, double percent) => (double)(value - value.PercentOf(percent));

        /// <summary>
        /// Substracts byte from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double Substract(this double x, byte y) => x - (double)y;

        /// <summary>
        /// Adds byte to double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double Add(this double x, byte y) => x + (double)y;

        /// <summary>
        /// Divides byte from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double DividedBy(this double x, byte y) => x / (double)y;

        /// <summary>
        /// Multiplies byte with double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double MultipliedWith(this double x, byte y) => x * (double)y;

        /// <summary>
        /// Gets the remainder of byte from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double Modulus(this double x, byte y) => x % (double)y;

        /// <summary>
        /// Gets a boolean True if double is less than byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this double x, byte y) => x < (double)y;

        /// <summary>
        /// Gets a boolean True if double is greater than byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this double x, byte y) => x > (double)y;

        /// <summary>
        /// Gets boolean True if byte is equal to double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqual(this double x, byte y) => (decimal)x == (decimal)y;

        /// <summary>
        /// Gets boolean True if byte is not equal to double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqual(this double x, byte y) => (decimal)x != (decimal)y;

        /// <summary>
        /// Tries to cast double to byte, this can get ugly though
        /// </summary>
        /// <param name="x">The original value</param>
        /// <returns>The result of the operation</returns>
        public static byte CastDoubleToByte(this double x) => (byte)x;

        /// <summary>
        /// Substracts char from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double Substract(this double x, char y) => x - (double)y;

        /// <summary>
        /// Adds char to double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double Add(this double x, char y) => x + (double)y;

        /// <summary>
        /// Divides char from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double DividedBy(this double x, char y) => x / (double)y;

        /// <summary>
        /// Multiplies char with double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double MultipliedWith(this double x, char y) => x * (double)y;

        /// <summary>
        /// Gets the remainder of char from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double Modulus(this double x, char y) => x % (double)y;

        /// <summary>
        /// Gets a boolean True if double is less than char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this double x, char y) => x < (double)y;

        /// <summary>
        /// Gets a boolean True if double is greater than char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this double x, char y) => x > (double)y;

        /// <summary>
        /// Gets boolean True if char is equal to double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqual(this double x, char y) => (decimal)x == (decimal)y;

        /// <summary>
        /// Gets boolean True if char is not equal to double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqual(this double x, char y) => (decimal)x != (decimal)y;

        /// <summary>
        /// Tries to cast double to char, this can get ugly though
        /// </summary>
        /// <param name="x">The original value</param>
        /// <returns>The result of the operation</returns>
        public static char CastDoubleToChar(this double x) => (char)x;

        /// <summary>
        /// Substracts decimal from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double Substract(this double x, decimal y) => x - (double)y;

        /// <summary>
        /// Adds decimal to double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double Add(this double x, decimal y) => x + (double)y;

        /// <summary>
        /// Divides decimal from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double DividedBy(this double x, decimal y) => x / (double)y;

        /// <summary>
        /// Multiplies decimal with double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double MultipliedWith(this double x, decimal y) => x * (double)y;

        /// <summary>
        /// Gets the remainder of decimal from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double Modulus(this double x, decimal y) => x % (double)y;

        /// <summary>
        /// Gets a boolean True if double is less than decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this double x, decimal y) => x < (double)y;

        /// <summary>
        /// Gets a boolean True if double is greater than decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this double x, decimal y) => x > (double)y;

        /// <summary>
        /// Gets boolean True if decimal is equal to double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqual(this double x, decimal y) => (decimal)x == (decimal)y;

        /// <summary>
        /// Gets boolean True if decimal is not equal to double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqual(this double x, decimal y) => (decimal)x != (decimal)y;

        /// <summary>
        /// Tries to cast double to decimal, this can get ugly though
        /// </summary>
        /// <param name="x">The original value</param>
        /// <returns>The result of the operation</returns>
        public static decimal CastDoubleToDecimal(this double x) => (decimal)x;

        /// <summary>
        /// Substracts double from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double Substract(this double x, double y) => x - y;

        /// <summary>
        /// Adds double to double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double Add(this double x, double y) => x + y;

        /// <summary>
        /// Divides double from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double DividedBy(this double x, double y) => x / y;

        /// <summary>
        /// Multiplies double with double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double MultipliedWith(this double x, double y) => x * y;

        /// <summary>
        /// Gets the remainder of double from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double Modulus(this double x, double y) => x % y;

        /// <summary>
        /// Gets a boolean True if double is less than double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this double x, double y) => x < y;

        /// <summary>
        /// Gets a boolean True if double is greater than double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this double x, double y) => x > y;

        /// <summary>
        /// Gets boolean True if double is equal to double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqual(this double x, double y) => (decimal)x == (decimal)y;

        /// <summary>
        /// Gets boolean True if double is not equal to double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqual(this double x, double y) => (decimal)x != (decimal)y;

        /// <summary>
        /// Substracts float from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double Substract(this double x, float y) => x - (double)y;

        /// <summary>
        /// Adds float to double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double Add(this double x, float y) => x + (double)y;

        /// <summary>
        /// Divides float from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double DividedBy(this double x, float y) => x / (double)y;

        /// <summary>
        /// Multiplies float with double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double MultipliedWith(this double x, float y) => x * (double)y;

        /// <summary>
        /// Gets the remainder of float from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double Modulus(this double x, float y) => x % (double)y;

        /// <summary>
        /// Gets a boolean True if double is less than float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this double x, float y) => x < (double)y;

        /// <summary>
        /// Gets a boolean True if double is greater than float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this double x, float y) => x > (double)y;

        /// <summary>
        /// Gets boolean True if float is equal to double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqual(this double x, float y) => (decimal)x == (decimal)y;

        /// <summary>
        /// Gets boolean True if float is not equal to double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqual(this double x, float y) => (decimal)x != (decimal)y;

        /// <summary>
        /// Tries to cast double to float, this can get ugly though
        /// </summary>
        /// <param name="x">The original value</param>
        /// <returns>The result of the operation</returns>
        public static float CastDoubleToFloat(this double x) => (float)x;

        /// <summary>
        /// Substracts int from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double Substract(this double x, int y) => x - (double)y;

        /// <summary>
        /// Adds int to double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double Add(this double x, int y) => x + (double)y;

        /// <summary>
        /// Divides int from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double DividedBy(this double x, int y) => x / (double)y;

        /// <summary>
        /// Multiplies int with double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double MultipliedWith(this double x, int y) => x * (double)y;

        /// <summary>
        /// Gets the remainder of int from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double Modulus(this double x, int y) => x % (double)y;

        /// <summary>
        /// Gets a boolean True if double is less than int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this double x, int y) => x < (double)y;

        /// <summary>
        /// Gets a boolean True if double is greater than int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this double x, int y) => x > (double)y;

        /// <summary>
        /// Gets boolean True if int is equal to double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqual(this double x, int y) => (decimal)x == (decimal)y;

        /// <summary>
        /// Gets boolean True if int is not equal to double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqual(this double x, int y) => (decimal)x != (decimal)y;

        /// <summary>
        /// Tries to cast double to int, this can get ugly though
        /// </summary>
        /// <param name="x">The original value</param>
        /// <returns>The result of the operation</returns>
        public static int CastDoubleToInt(this double x) => (int)x;

        /// <summary>
        /// Substracts long from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double Substract(this double x, long y) => x - (double)y;

        /// <summary>
        /// Adds long to double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double Add(this double x, long y) => x + (double)y;

        /// <summary>
        /// Divides long from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double DividedBy(this double x, long y) => x / (double)y;

        /// <summary>
        /// Multiplies long with double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double MultipliedWith(this double x, long y) => x * (double)y;

        /// <summary>
        /// Gets the remainder of long from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double Modulus(this double x, long y) => x % (double)y;

        /// <summary>
        /// Gets a boolean True if double is less than long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this double x, long y) => x < (double)y;

        /// <summary>
        /// Gets a boolean True if double is greater than long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this double x, long y) => x > (double)y;

        /// <summary>
        /// Gets boolean True if long is equal to double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqual(this double x, long y) => (decimal)x == (decimal)y;

        /// <summary>
        /// Gets boolean True if long is not equal to double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqual(this double x, long y) => (decimal)x != (decimal)y;

        /// <summary>
        /// Tries to cast double to long, this can get ugly though
        /// </summary>
        /// <param name="x">The original value</param>
        /// <returns>The result of the operation</returns>
        public static long CastDoubleToLong(this double x) => (long)x;

        /// <summary>
        /// Substracts sbyte from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double Substract(this double x, sbyte y) => x - (double)y;

        /// <summary>
        /// Adds sbyte to double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double Add(this double x, sbyte y) => x + (double)y;

        /// <summary>
        /// Divides sbyte from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double DividedBy(this double x, sbyte y) => x / (double)y;

        /// <summary>
        /// Multiplies sbyte with double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double MultipliedWith(this double x, sbyte y) => x * (double)y;

        /// <summary>
        /// Gets the remainder of sbyte from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double Modulus(this double x, sbyte y) => x % (double)y;

        /// <summary>
        /// Gets a boolean True if double is less than sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this double x, sbyte y) => x < (double)y;

        /// <summary>
        /// Gets a boolean True if double is greater than sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this double x, sbyte y) => x > (double)y;

        /// <summary>
        /// Gets boolean true if value is less than zero
        /// </summary>
        /// <param name="x">The original value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNegative(this double x) => x < 0;

        /// <summary>
        /// Gets boolean true if value is more than zero
        /// </summary>
        /// <param name="x">The original value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsPositive(this double x) => x >= 0;

        /// <summary>
        /// Gets boolean True if sbyte is equal to double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqual(this double x, sbyte y) => (decimal)x == (decimal)y;

        /// <summary>
        /// Gets boolean True if sbyte is not equal to double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqual(this double x, sbyte y) => (decimal)x != (decimal)y;

        /// <summary>
        /// Tries to cast double to sbyte, this can get ugly though
        /// </summary>
        /// <param name="x">The original value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte CastDoubleToSbyte(this double x) => (sbyte)x;

        /// <summary>
        /// Substracts short from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double Substract(this double x, short y) => x - (double)y;

        /// <summary>
        /// Adds short to double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double Add(this double x, short y) => x + (double)y;

        /// <summary>
        /// Divides short from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double DividedBy(this double x, short y) => x / (double)y;

        /// <summary>
        /// Multiplies short with double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double MultipliedWith(this double x, short y) => x * (double)y;

        /// <summary>
        /// Gets the remainder of short from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double Modulus(this double x, short y) => x % (double)y;

        /// <summary>
        /// Gets a boolean True if double is less than short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this double x, short y) => x < (double)y;

        /// <summary>
        /// Gets a boolean True if double is greater than short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this double x, short y) => x > (double)y;

        /// <summary>
        /// Gets boolean True if short is equal to double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqual(this double x, short y) => (decimal)x == (decimal)y;

        /// <summary>
        /// Gets boolean True if short is not equal to double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqual(this double x, short y) => (decimal)x != (decimal)y;

        /// <summary>
        /// Tries to cast double to short, this can get ugly though
        /// </summary>
        /// <param name="x">The original value</param>
        /// <returns>The result of the operation</returns>
        public static short CastDoubleToShort(this double x) => (short)x;

        /// <summary>
        /// Substracts uint from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double Substract(this double x, uint y) => x - (double)y;

        /// <summary>
        /// Adds uint to double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double Add(this double x, uint y) => x + (double)y;

        /// <summary>
        /// Divides uint from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double DividedBy(this double x, uint y) => x / (double)y;

        /// <summary>
        /// Multiplies uint with double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double MultipliedWith(this double x, uint y) => x * (double)y;

        /// <summary>
        /// Gets the remainder of uint from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double Modulus(this double x, uint y) => x % (double)y;

        /// <summary>
        /// Gets a boolean True if double is less than uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this double x, uint y) => x < (double)y;

        /// <summary>
        /// Gets a boolean True if double is greater than uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this double x, uint y) => x > (double)y;

        /// <summary>
        /// Gets boolean True if uint is equal to double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqual(this double x, uint y) => (decimal)x == (decimal)y;

        /// <summary>
        /// Gets boolean True if uint is not equal to double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqual(this double x, uint y) => (decimal)x != (decimal)y;

        /// <summary>
        /// Tries to cast double to uint, this can get ugly though
        /// </summary>
        /// <param name="x">The original value</param>
        /// <returns>The result of the operation</returns>
        public static uint CastDoubleToUint(this double x) => (uint)x;

        /// <summary>
        /// Substracts ulong from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double Substract(this double x, ulong y) => x - (double)y;

        /// <summary>
        /// Adds ulong to double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double Add(this double x, ulong y) => x + (double)y;

        /// <summary>
        /// Divides ulong from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double DividedBy(this double x, ulong y) => x / (double)y;

        /// <summary>
        /// Multiplies ulong with double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double MultipliedWith(this double x, ulong y) => x * (double)y;

        /// <summary>
        /// Gets the remainder of ulong from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double Modulus(this double x, ulong y) => x % (double)y;

        /// <summary>
        /// Gets a boolean True if double is less than ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this double x, ulong y) => x < (double)y;

        /// <summary>
        /// Gets a boolean True if double is greater than ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this double x, ulong y) => x > (double)y;

        /// <summary>
        /// Gets boolean True if ulong is equal to double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqual(this double x, ulong y) => (decimal)x == (decimal)y;

        /// <summary>
        /// Gets boolean True if ulong is not equal to double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqual(this double x, ulong y) => (decimal)x != (decimal)y;

        /// <summary>
        /// Tries to cast double to ulong, this can get ugly though
        /// </summary>
        /// <param name="x">The original value</param>
        /// <returns>The result of the operation</returns>
        public static ulong CastDoubleToUlong(this double x) => (ulong)x;

        /// <summary>
        /// Substracts ushort from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double Substract(this double x, ushort y) => x - (double)y;

        /// <summary>
        /// Adds ushort to double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double Add(this double x, ushort y) => x + (double)y;

        /// <summary>
        /// Divides ushort from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double DividedBy(this double x, ushort y) => x / (double)y;

        /// <summary>
        /// Multiplies ushort with double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double MultipliedWith(this double x, ushort y) => x * (double)y;

        /// <summary>
        /// Gets the remainder of ushort from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double Modulus(this double x, ushort y) => x % (double)y;

        /// <summary>
        /// Gets a boolean True if double is less than ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this double x, ushort y) => x < (double)y;

        /// <summary>
        /// Gets a boolean True if double is greater than ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this double x, ushort y) => x > (double)y;

        /// <summary>
        /// Gets boolean True if ushort is equal to double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqual(this double x, ushort y) => (decimal)x == (decimal)y;

        /// <summary>
        /// Gets boolean True if ushort is not equal to double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqual(this double x, ushort y) => (decimal)x != (decimal)y;

        /// <summary>
        /// Tries to cast double to ushort, this can get ugly though
        /// </summary>
        /// <param name="x">The original value</param>
        /// <returns>The result of the operation</returns>
        public static ushort CastDoubleToUshort(this double x) => (ushort)x;

    }
}
