//----------------------------------------------------------------------------------------------
// <copyright file="TypedMathLongExtension.cs" company="MarcusMedinaPro">
// By Marcus Medina, 2019 - http://MarcusMedina.Pro 
// This file is subject to the terms and conditions defined in file 'license.txt', which is part of this project.
// </copyright>
// ----------------------------------------------------------------------------------------------
// Credits for borrowed code:
// LinQ Primenumbers, Zoran Horvat: http://www.codinghelmet.com/articles/linq-all-primes/
// ----------------------------------------------------------------------------------------------

namespace MarcusMedinaPro.TypedMath.LongExtension
{
    using System;
    using System.Linq;

    /// <summary>
    /// Extension for long
    /// </summary>
    public static class TypedMathLongExtension
    {

        /// <summary>
        /// Gets the NOT of long
        /// </summary>
        /// <returns>The result of the operation</returns>
        public static long Not(this long x) => ~(int)x;
        /// <summary>
        /// Checks if a number is prime
        /// </summary>
        /// <param name="number">The number</param>
        /// <returns>True if the number is prime</returns>
        /// <credits>Code borrowed from http://www.codinghelmet.com/articles/linq-all-primes/ to get primes with Linq</credits>
        public static bool IsPrime(this long number) => Enumerable.Range(2, (int)Math.Sqrt(number) - 1).All(divisor => number % divisor != 0);
        /// <summary>
        /// Compare original and second number
        /// </summary>
        /// <param name="first">The number</param>
        /// <param name="second">The number to compare with</param>
        /// <returns>The highest of the two numbers</returns>
        public static long ChooseHighestValue(this long first, long second) => first > second ? first : second;

        /// <summary>
        /// Compare original and second number
        /// </summary>
        /// <param name="first">The number</param>
        /// <param name="second">The number to compare with</param>
        /// <returns>The lowest of the two numbers</returns>
        public static long ChooseLowestValue(this long first, long second) => first < second ? first : second;

        /// <summary>
        /// Swaps two variables 
        /// </summary>
        /// <param name="first">The main variable</param>
        /// <param name="second">The variable to switch with</param>
        /// <returns>The value from the second variable and sets second variable to original value</returns>
        public static long SwapWith(this long first, ref long second)
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
        public static long PercentOf(this long percent, byte value) => percent / 100 * value;

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static long AddPercent(this long value, byte percent) => value + value.PercentOf(percent);

        /// <summary>
        /// Substracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static long SubstractPercent(this long value, byte percent) => value - value.PercentOf(percent);

        /// <summary>
        /// Substracts byte from long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long Substract(this long x, byte y) => x - y;

        /// <summary>
        /// Adds byte to long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long Add(this long x, byte y) => x + y;

        /// <summary>
        /// Divides byte from long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long DividedBy(this long x, byte y) => x / y;

        /// <summary>
        /// Multiplies byte with long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long MultipliedWith(this long x, byte y) => x * y;

        /// <summary>
        /// Gets the remainder of byte from long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long Modulus(this long x, byte y) => x % y;

        /// <summary>
        /// Gets XOR of byte of long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long Xor(this long x, byte y) => x ^ y;

        /// <summary>
        /// Gets a boolean True if long is less than byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this long x, byte y) => x < y;

        /// <summary>
        /// Gets a boolean True if long is greater than byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this long x, byte y) => x > y;

        /// <summary>
        /// Gets boolean True if byte is equal to long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this long x, byte y) => x == y;

        /// <summary>
        /// Gets boolean True if byte is not equal to long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this long x, byte y) => x != y;

        /// <summary>
        /// Tries to cast long to byte, this can get ugly though
        /// </summary>
        /// <returns>The result of the operation</returns>
        public static byte CastLongToByte(this long x) => (byte)x;

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static long PercentOf(this long percent, char value) => percent / 100 * value;

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static long AddPercent(this long value, char percent) => value + value.PercentOf(percent);

        /// <summary>
        /// Substracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static long SubstractPercent(this long value, char percent) => value - value.PercentOf(percent);

        /// <summary>
        /// Substracts char from long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long Substract(this long x, char y) => x - y;

        /// <summary>
        /// Adds char to long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long Add(this long x, char y) => x + y;

        /// <summary>
        /// Divides char from long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long DividedBy(this long x, char y) => x / y;

        /// <summary>
        /// Multiplies char with long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long MultipliedWith(this long x, char y) => x * y;

        /// <summary>
        /// Gets the remainder of char from long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long Modulus(this long x, char y) => x % y;

        /// <summary>
        /// Gets XOR of char of long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long Xor(this long x, char y) => x ^ y;

        /// <summary>
        /// Gets a boolean True if long is less than char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this long x, char y) => x < y;

        /// <summary>
        /// Gets a boolean True if long is greater than char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this long x, char y) => x > y;

        /// <summary>
        /// Gets boolean True if char is equal to long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this long x, char y) => x == y;

        /// <summary>
        /// Gets boolean True if char is not equal to long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this long x, char y) => x != y;

        /// <summary>
        /// Tries to cast long to char, this can get ugly though
        /// </summary>
        /// <returns>The result of the operation</returns>
        public static char CastLongToChar(this long x) => (char)x;

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static long PercentOf(this long percent, decimal value) => percent / 100 * ((long)value);

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static long AddPercent(this long value, decimal percent) => value + value.PercentOf(percent);

        /// <summary>
        /// Substracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static long SubstractPercent(this long value, decimal percent) => value - value.PercentOf(percent);

        /// <summary>
        /// Substracts decimal from long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long Substract(this long x, decimal y) => x - (long)y;

        /// <summary>
        /// Adds decimal to long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long Add(this long x, decimal y) => x + (long)y;

        /// <summary>
        /// Divides decimal from long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long DividedBy(this long x, decimal y) => x / (long)y;

        /// <summary>
        /// Multiplies decimal with long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long MultipliedWith(this long x, decimal y) => x * (long)y;

        /// <summary>
        /// Gets the remainder of decimal from long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long Modulus(this long x, decimal y) => x % (long)y;

        /// <summary>
        /// Gets XOR of decimal of long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long Xor(this long x, decimal y) => x ^ (long)y;

        /// <summary>
        /// Gets a boolean True if long is less than decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this long x, decimal y) => x < (long)y;

        /// <summary>
        /// Gets a boolean True if long is greater than decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this long x, decimal y) => x > (long)y;

        /// <summary>
        /// Gets boolean True if decimal is equal to long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this long x, decimal y) => x == (long)y;

        /// <summary>
        /// Gets boolean True if decimal is not equal to long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this long x, decimal y) => x != (long)y;

        /// <summary>
        /// Tries to cast long to decimal, this can get ugly though
        /// </summary>
        /// <returns>The result of the operation</returns>
        public static decimal CastLongToDecimal(this long x) => x;

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static long PercentOf(this long percent, double value) => percent / 100 * ((long)value);

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static long AddPercent(this long value, double percent) => value + value.PercentOf(percent);

        /// <summary>
        /// Substracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static long SubstractPercent(this long value, double percent) => value - value.PercentOf(percent);

        /// <summary>
        /// Substracts double from long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long Substract(this long x, double y) => x - (long)y;

        /// <summary>
        /// Adds double to long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long Add(this long x, double y) => x + (long)y;

        /// <summary>
        /// Divides double from long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long DividedBy(this long x, double y) => x / (long)y;

        /// <summary>
        /// Multiplies double with long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long MultipliedWith(this long x, double y) => x * (long)y;

        /// <summary>
        /// Gets the remainder of double from long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long Modulus(this long x, double y) => x % (long)y;

        /// <summary>
        /// Gets XOR of double of long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long Xor(this long x, double y) => x ^ (long)y;

        /// <summary>
        /// Gets a boolean True if long is less than double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this long x, double y) => x < (long)y;

        /// <summary>
        /// Gets a boolean True if long is greater than double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this long x, double y) => x > (long)y;

        /// <summary>
        /// Gets boolean True if double is equal to long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this long x, double y) => x == (long)y;

        /// <summary>
        /// Gets boolean True if double is not equal to long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this long x, double y) => x != (long)y;

        /// <summary>
        /// Tries to cast long to double, this can get ugly though
        /// </summary>
        /// <returns>The result of the operation</returns>
        public static double CastLongToDouble(this long x) => x;

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static long PercentOf(this long percent, float value) => percent / 100 * ((long)value);

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static long AddPercent(this long value, float percent) => value + value.PercentOf(percent);

        /// <summary>
        /// Substracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static long SubstractPercent(this long value, float percent) => value - value.PercentOf(percent);

        /// <summary>
        /// Substracts float from long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long Substract(this long x, float y) => x - (long)y;

        /// <summary>
        /// Adds float to long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long Add(this long x, float y) => x + (long)y;

        /// <summary>
        /// Divides float from long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long DividedBy(this long x, float y) => x / (long)y;

        /// <summary>
        /// Multiplies float with long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long MultipliedWith(this long x, float y) => x * (long)y;

        /// <summary>
        /// Gets the remainder of float from long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long Modulus(this long x, float y) => x % (long)y;

        /// <summary>
        /// Gets XOR of float of long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long Xor(this long x, float y) => x ^ (long)y;

        /// <summary>
        /// Gets a boolean True if long is less than float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this long x, float y) => x < (long)y;

        /// <summary>
        /// Gets a boolean True if long is greater than float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this long x, float y) => x > (long)y;

        /// <summary>
        /// Gets boolean True if float is equal to long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this long x, float y) => x == (long)y;

        /// <summary>
        /// Gets boolean True if float is not equal to long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this long x, float y) => x != (long)y;

        /// <summary>
        /// Tries to cast long to float, this can get ugly though
        /// </summary>
        /// <returns>The result of the operation</returns>
        public static float CastLongToFloat(this long x) => x;

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static long PercentOf(this long percent, int value) => percent / 100 * value;

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static long AddPercent(this long value, int percent) => value + value.PercentOf(percent);

        /// <summary>
        /// Substracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static long SubstractPercent(this long value, int percent) => value - value.PercentOf(percent);

        /// <summary>
        /// Substracts int from long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long Substract(this long x, int y) => x - y;

        /// <summary>
        /// Adds int to long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long Add(this long x, int y) => x + y;

        /// <summary>
        /// Divides int from long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long DividedBy(this long x, int y) => x / y;

        /// <summary>
        /// Multiplies int with long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long MultipliedWith(this long x, int y) => x * y;

        /// <summary>
        /// Gets the remainder of int from long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long Modulus(this long x, int y) => x % y;

        /// <summary>
        /// Gets XOR of int of long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long Xor(this long x, int y) => x ^ y;

        /// <summary>
        /// Gets a boolean True if long is less than int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this long x, int y) => x < y;

        /// <summary>
        /// Gets a boolean True if long is greater than int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this long x, int y) => x > y;

        /// <summary>
        /// Gets boolean True if int is equal to long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this long x, int y) => x == y;

        /// <summary>
        /// Gets boolean True if int is not equal to long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this long x, int y) => x != y;

        /// <summary>
        /// Tries to cast long to int, this can get ugly though
        /// </summary>
        /// <returns>The result of the operation</returns>
        public static int CastLongToInt(this long x) => (int)x;

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static long PercentOf(this long percent, long value) => percent / 100 * value;

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static long AddPercent(this long value, long percent) => value + value.PercentOf(percent);

        /// <summary>
        /// Substracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static long SubstractPercent(this long value, long percent) => value - value.PercentOf(percent);

        /// <summary>
        /// Substracts long from long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long Substract(this long x, long y) => x - y;

        /// <summary>
        /// Adds long to long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long Add(this long x, long y) => x + y;

        /// <summary>
        /// Divides long from long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long DividedBy(this long x, long y) => x / y;

        /// <summary>
        /// Multiplies long with long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long MultipliedWith(this long x, long y) => x * y;

        /// <summary>
        /// Gets the remainder of long from long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long Modulus(this long x, long y) => x % y;

        /// <summary>
        /// Gets XOR of long of long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long Xor(this long x, long y) => x ^ y;

        /// <summary>
        /// Gets a boolean True if long is less than long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this long x, long y) => x < y;

        /// <summary>
        /// Gets a boolean True if long is greater than long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this long x, long y) => x > y;

        /// <summary>
        /// Gets boolean True if long is equal to long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this long x, long y) => x == y;

        /// <summary>
        /// Gets boolean True if long is not equal to long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this long x, long y) => x != y;

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static long PercentOf(this long percent, sbyte value) => percent / 100 * value;

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static long AddPercent(this long value, sbyte percent) => value + value.PercentOf(percent);

        /// <summary>
        /// Substracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static long SubstractPercent(this long value, sbyte percent) => value - value.PercentOf(percent);

        /// <summary>
        /// Substracts sbyte from long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long Substract(this long x, sbyte y) => x - y;

        /// <summary>
        /// Adds sbyte to long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long Add(this long x, sbyte y) => x + y;

        /// <summary>
        /// Divides sbyte from long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long DividedBy(this long x, sbyte y) => x / y;

        /// <summary>
        /// Multiplies sbyte with long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long MultipliedWith(this long x, sbyte y) => x * y;

        /// <summary>
        /// Gets the remainder of sbyte from long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long Modulus(this long x, sbyte y) => x % y;

        /// <summary>
        /// Gets XOR of sbyte of long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long Xor(this long x, sbyte y) => x ^ y;

        /// <summary>
        /// Gets a boolean True if long is less than sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this long x, sbyte y) => x < y;

        /// <summary>
        /// Gets a boolean True if long is greater than sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this long x, sbyte y) => x > y;

        /// <summary>
        /// Gets boolean true if value is less than zero
        /// </summary>
        /// <returns>The result of the operation</returns>
        public static bool IsNegative(this long x) => x < 0;

        /// <summary>
        /// Gets boolean true if value is more than zero
        /// </summary>
        /// <returns>The result of the operation</returns>
        public static bool IsPositive(this long x) => x >= 0;

        /// <summary>
        /// Gets boolean True if sbyte is equal to long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this long x, sbyte y) => x == y;

        /// <summary>
        /// Gets boolean True if sbyte is not equal to long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this long x, sbyte y) => x != y;

        /// <summary>
        /// Tries to cast long to sbyte, this can get ugly though
        /// </summary>
        /// <returns>The result of the operation</returns>
        public static sbyte CastLongToSbyte(this long x) => (sbyte)x;

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static long PercentOf(this long percent, short value) => percent / 100 * value;

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static long AddPercent(this long value, short percent) => value + value.PercentOf(percent);

        /// <summary>
        /// Substracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static long SubstractPercent(this long value, short percent) => value - value.PercentOf(percent);

        /// <summary>
        /// Substracts short from long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long Substract(this long x, short y) => x - y;

        /// <summary>
        /// Adds short to long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long Add(this long x, short y) => x + y;

        /// <summary>
        /// Divides short from long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long DividedBy(this long x, short y) => x / y;

        /// <summary>
        /// Multiplies short with long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long MultipliedWith(this long x, short y) => x * y;

        /// <summary>
        /// Gets the remainder of short from long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long Modulus(this long x, short y) => x % y;

        /// <summary>
        /// Gets XOR of short of long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long Xor(this long x, short y) => x ^ y;

        /// <summary>
        /// Gets a boolean True if long is less than short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this long x, short y) => x < y;

        /// <summary>
        /// Gets a boolean True if long is greater than short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this long x, short y) => x > y;

        /// <summary>
        /// Gets boolean True if short is equal to long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this long x, short y) => x == y;

        /// <summary>
        /// Gets boolean True if short is not equal to long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this long x, short y) => x != y;

        /// <summary>
        /// Tries to cast long to short, this can get ugly though
        /// </summary>
        /// <returns>The result of the operation</returns>
        public static short CastLongToShort(this long x) => (short)x;

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static long PercentOf(this long percent, uint value) => percent / 100 * value;

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static long AddPercent(this long value, uint percent) => value + value.PercentOf(percent);

        /// <summary>
        /// Substracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static long SubstractPercent(this long value, uint percent) => value - value.PercentOf(percent);

        /// <summary>
        /// Substracts uint from long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long Substract(this long x, uint y) => x - y;

        /// <summary>
        /// Adds uint to long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long Add(this long x, uint y) => x + y;

        /// <summary>
        /// Divides uint from long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long DividedBy(this long x, uint y) => x / y;

        /// <summary>
        /// Multiplies uint with long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long MultipliedWith(this long x, uint y) => x * y;

        /// <summary>
        /// Gets the remainder of uint from long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long Modulus(this long x, uint y) => x % y;

        /// <summary>
        /// Gets XOR of uint of long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long Xor(this long x, uint y) => x ^ y;

        /// <summary>
        /// Gets a boolean True if long is less than uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this long x, uint y) => x < y;

        /// <summary>
        /// Gets a boolean True if long is greater than uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this long x, uint y) => x > y;

        /// <summary>
        /// Gets boolean True if uint is equal to long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this long x, uint y) => x == y;

        /// <summary>
        /// Gets boolean True if uint is not equal to long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this long x, uint y) => x != y;

        /// <summary>
        /// Tries to cast long to uint, this can get ugly though
        /// </summary>
        /// <returns>The result of the operation</returns>
        public static uint CastLongToUint(this long x) => (uint)x;

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static long PercentOf(this long percent, ulong value) => percent / 100 * ((long)value);

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static long AddPercent(this long value, ulong percent) => value + value.PercentOf(percent);

        /// <summary>
        /// Substracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static long SubstractPercent(this long value, ulong percent) => value - value.PercentOf(percent);

        /// <summary>
        /// Substracts ulong from long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long Substract(this long x, ulong y) => x - (long)y;

        /// <summary>
        /// Adds ulong to long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long Add(this long x, ulong y) => x + (long)y;

        /// <summary>
        /// Divides ulong from long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long DividedBy(this long x, ulong y) => x / (long)y;

        /// <summary>
        /// Multiplies ulong with long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long MultipliedWith(this long x, ulong y) => x * (long)y;

        /// <summary>
        /// Gets the remainder of ulong from long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long Modulus(this long x, ulong y) => x % (long)y;

        /// <summary>
        /// Gets XOR of ulong of long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long Xor(this long x, ulong y) => x ^ (long)y;

        /// <summary>
        /// Gets a boolean True if long is less than ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this long x, ulong y) => x < (long)y;

        /// <summary>
        /// Gets a boolean True if long is greater than ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this long x, ulong y) => x > (long)y;

        /// <summary>
        /// Gets boolean True if ulong is equal to long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this long x, ulong y) => x == (long)y;

        /// <summary>
        /// Gets boolean True if ulong is not equal to long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this long x, ulong y) => x != (long)y;

        /// <summary>
        /// Tries to cast long to ulong, this can get ugly though
        /// </summary>
        /// <returns>The result of the operation</returns>
        public static ulong CastLongToUlong(this long x) => (ulong)x;

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static long PercentOf(this long percent, ushort value) => percent / 100 * value;

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static long AddPercent(this long value, ushort percent) => value + value.PercentOf(percent);

        /// <summary>
        /// Substracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static long SubstractPercent(this long value, ushort percent) => value - value.PercentOf(percent);

        /// <summary>
        /// Substracts ushort from long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long Substract(this long x, ushort y) => x - y;

        /// <summary>
        /// Adds ushort to long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long Add(this long x, ushort y) => x + y;

        /// <summary>
        /// Divides ushort from long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long DividedBy(this long x, ushort y) => x / y;

        /// <summary>
        /// Multiplies ushort with long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long MultipliedWith(this long x, ushort y) => x * y;

        /// <summary>
        /// Gets the remainder of ushort from long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long Modulus(this long x, ushort y) => x % y;

        /// <summary>
        /// Gets XOR of ushort of long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long Xor(this long x, ushort y) => x ^ y;

        /// <summary>
        /// Gets a boolean True if long is less than ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this long x, ushort y) => x < y;

        /// <summary>
        /// Gets a boolean True if long is greater than ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this long x, ushort y) => x > y;

        /// <summary>
        /// Gets boolean True if ushort is equal to long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this long x, ushort y) => x == y;

        /// <summary>
        /// Gets boolean True if ushort is not equal to long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this long x, ushort y) => x != y;

        /// <summary>
        /// Tries to cast long to ushort, this can get ugly though
        /// </summary>
        /// <returns>The result of the operation</returns>
        public static ushort CastLongToUshort(this long x) => (ushort)x;

    }
}
