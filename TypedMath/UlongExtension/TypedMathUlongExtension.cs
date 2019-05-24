//----------------------------------------------------------------------------------------------
// <copyright file="TypedMathUlongExtension.cs" company="MarcusMedinaPro">
// By Marcus Medina, 2019 - http://MarcusMedina.Pro 
// This file is subject to the terms and conditions defined in file 'license.txt', which is part of this project.
// </copyright>
// ----------------------------------------------------------------------------------------------
// Credits for borrowed code:
// LinQ Primenumbers, Zoran Horvat: http://www.codinghelmet.com/articles/linq-all-primes/
// ----------------------------------------------------------------------------------------------

namespace MarcusMedinaPro.TypedMath.UlongExtension
{
    using System;
    using System.Linq;

    /// <summary>
    /// Extension for ulong
    /// </summary>
    public static class TypedMathUlongExtension
    {

        /// <summary>
        /// Gets the NOT of ulong
        /// </summary>
        /// <returns>The result of the operation</returns>
        public static ulong Not(this ulong x) => (ulong)~(int)x;
        /// <summary>
        /// Checks if a number is prime
        /// </summary>
        /// <param name="number">The number</param>
        /// <returns>True if the number is prime</returns>
        /// <credits>Code borrowed from http://www.codinghelmet.com/articles/linq-all-primes/ to get primes with Linq</credits>
        public static bool IsPrime(this ulong number) => Enumerable.Range(2, (int)Math.Sqrt(number) - 1).All(divisor => (long)number % divisor != 0);
        /// <summary>
        /// Compare original and second number
        /// </summary>
        /// <param name="first">The number</param>
        /// <param name="second">The number to compare with</param>
        /// <returns>The highest of the two numbers</returns>
        public static ulong ChooseHighestValue(this ulong first, ulong second) => first > second ? first : second;

        /// <summary>
        /// Compare original and second number
        /// </summary>
        /// <param name="first">The number</param>
        /// <param name="second">The number to compare with</param>
        /// <returns>The lowest of the two numbers</returns>
        public static ulong ChooseLowestValue(this ulong first, ulong second) => first < second ? first : second;

        /// <summary>
        /// Swaps two variables 
        /// </summary>
        /// <param name="first">The main variable</param>
        /// <param name="second">The variable to switch with</param>
        /// <returns>The value from the second variable and sets second variable to original value</returns>
        public static ulong SwapWith(this ulong first, ref ulong second)
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
        public static ulong PercentOf(this ulong percent, byte value) => percent / 100 * value;

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static ulong AddPercent(this ulong value, byte percent) => value + value.PercentOf(percent);

        /// <summary>
        /// Substracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static ulong SubstractPercent(this ulong value, byte percent) => value - value.PercentOf(percent);

        /// <summary>
        /// Substracts byte from ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Substract(this ulong x, byte y) => x - y;

        /// <summary>
        /// Adds byte to ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Add(this ulong x, byte y) => x + y;

        /// <summary>
        /// Divides byte from ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong DividedBy(this ulong x, byte y) => x / y;

        /// <summary>
        /// Multiplies byte with ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong MultipliedWith(this ulong x, byte y) => x * y;

        /// <summary>
        /// Gets the remainder of byte from ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Modulus(this ulong x, byte y) => x % y;

        /// <summary>
        /// Gets the AND of byte and ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong And(this ulong x, byte y) => x & y;

        /// <summary>
        /// Gets the OR of byte and ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Or(this ulong x, byte y) => (ulong)((int)x | y);

        /// <summary>
        /// Gets XOR of byte of ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Xor(this ulong x, byte y) => x ^ y;

        /// <summary>
        /// Gets a boolean True if ulong is less than byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this ulong x, byte y) => x < y;

        /// <summary>
        /// Gets a boolean True if ulong is greater than byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this ulong x, byte y) => x > y;

        /// <summary>
        /// Gets boolean True if byte is equal to ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this ulong x, byte y) => x == y;

        /// <summary>
        /// Gets boolean True if byte is not equal to ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this ulong x, byte y) => x != y;

        /// <summary>
        /// Tries to cast ulong to byte, this can get ugly though
        /// </summary>
        /// <returns>The result of the operation</returns>
        public static byte CastUlongToByte(this ulong x) => (byte)x;

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static ulong PercentOf(this ulong percent, char value) => percent / 100 * value;

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static ulong AddPercent(this ulong value, char percent) => value + value.PercentOf(percent);

        /// <summary>
        /// Substracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static ulong SubstractPercent(this ulong value, char percent) => value - value.PercentOf(percent);

        /// <summary>
        /// Substracts char from ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Substract(this ulong x, char y) => x - y;

        /// <summary>
        /// Adds char to ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Add(this ulong x, char y) => x + y;

        /// <summary>
        /// Divides char from ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong DividedBy(this ulong x, char y) => x / y;

        /// <summary>
        /// Multiplies char with ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong MultipliedWith(this ulong x, char y) => x * y;

        /// <summary>
        /// Gets the remainder of char from ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Modulus(this ulong x, char y) => x % y;

        /// <summary>
        /// Gets the AND of char and ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong And(this ulong x, char y) => x & y;

        /// <summary>
        /// Gets the OR of char and ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Or(this ulong x, char y) => (ulong)((int)x | y);

        /// <summary>
        /// Gets XOR of char of ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Xor(this ulong x, char y) => x ^ y;

        /// <summary>
        /// Gets a boolean True if ulong is less than char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this ulong x, char y) => x < y;

        /// <summary>
        /// Gets a boolean True if ulong is greater than char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this ulong x, char y) => x > y;

        /// <summary>
        /// Gets boolean True if char is equal to ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this ulong x, char y) => x == y;

        /// <summary>
        /// Gets boolean True if char is not equal to ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this ulong x, char y) => x != y;

        /// <summary>
        /// Tries to cast ulong to char, this can get ugly though
        /// </summary>
        /// <returns>The result of the operation</returns>
        public static char CastUlongToChar(this ulong x) => (char)x;

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static ulong PercentOf(this ulong percent, decimal value) => percent / 100 * ((ulong)value);

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static ulong AddPercent(this ulong value, decimal percent) => value + value.PercentOf(percent);

        /// <summary>
        /// Substracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static ulong SubstractPercent(this ulong value, decimal percent) => value - value.PercentOf(percent);

        /// <summary>
        /// Substracts decimal from ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Substract(this ulong x, decimal y) => x - (ulong)y;

        /// <summary>
        /// Adds decimal to ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Add(this ulong x, decimal y) => x + (ulong)y;

        /// <summary>
        /// Divides decimal from ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong DividedBy(this ulong x, decimal y) => x / (ulong)y;

        /// <summary>
        /// Multiplies decimal with ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong MultipliedWith(this ulong x, decimal y) => x * (ulong)y;

        /// <summary>
        /// Gets the remainder of decimal from ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Modulus(this ulong x, decimal y) => x % (ulong)y;

        /// <summary>
        /// Gets the AND of decimal and ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong And(this ulong x, decimal y) => x & (ulong)y;

        /// <summary>
        /// Gets the OR of decimal and ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Or(this ulong x, decimal y) => (ulong)((int)x | (int)y);

        /// <summary>
        /// Gets XOR of decimal of ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Xor(this ulong x, decimal y) => x ^ (ulong)y;

        /// <summary>
        /// Gets a boolean True if ulong is less than decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this ulong x, decimal y) => x < (ulong)y;

        /// <summary>
        /// Gets a boolean True if ulong is greater than decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this ulong x, decimal y) => x > (ulong)y;

        /// <summary>
        /// Gets boolean True if decimal is equal to ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this ulong x, decimal y) => x == (ulong)y;

        /// <summary>
        /// Gets boolean True if decimal is not equal to ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this ulong x, decimal y) => x != (ulong)y;

        /// <summary>
        /// Tries to cast ulong to decimal, this can get ugly though
        /// </summary>
        /// <returns>The result of the operation</returns>
        public static decimal CastUlongToDecimal(this ulong x) => x;

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static ulong PercentOf(this ulong percent, double value) => percent / 100 * ((ulong)value);

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static ulong AddPercent(this ulong value, double percent) => value + value.PercentOf(percent);

        /// <summary>
        /// Substracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static ulong SubstractPercent(this ulong value, double percent) => value - value.PercentOf(percent);

        /// <summary>
        /// Substracts double from ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Substract(this ulong x, double y) => x - (ulong)y;

        /// <summary>
        /// Adds double to ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Add(this ulong x, double y) => x + (ulong)y;

        /// <summary>
        /// Divides double from ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong DividedBy(this ulong x, double y) => x / (ulong)y;

        /// <summary>
        /// Multiplies double with ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong MultipliedWith(this ulong x, double y) => x * (ulong)y;

        /// <summary>
        /// Gets the remainder of double from ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Modulus(this ulong x, double y) => x % (ulong)y;

        /// <summary>
        /// Gets the AND of double and ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong And(this ulong x, double y) => x & (ulong)y;

        /// <summary>
        /// Gets the OR of double and ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Or(this ulong x, double y) => (ulong)((int)x | (int)y);

        /// <summary>
        /// Gets XOR of double of ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Xor(this ulong x, double y) => x ^ (ulong)y;

        /// <summary>
        /// Gets a boolean True if ulong is less than double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this ulong x, double y) => x < (ulong)y;

        /// <summary>
        /// Gets a boolean True if ulong is greater than double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this ulong x, double y) => x > (ulong)y;

        /// <summary>
        /// Gets boolean True if double is equal to ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this ulong x, double y) => x == (ulong)y;

        /// <summary>
        /// Gets boolean True if double is not equal to ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this ulong x, double y) => x != (ulong)y;

        /// <summary>
        /// Tries to cast ulong to double, this can get ugly though
        /// </summary>
        /// <returns>The result of the operation</returns>
        public static double CastUlongToDouble(this ulong x) => x;

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static ulong PercentOf(this ulong percent, float value) => percent / 100 * ((ulong)value);

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static ulong AddPercent(this ulong value, float percent) => value + value.PercentOf(percent);

        /// <summary>
        /// Substracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static ulong SubstractPercent(this ulong value, float percent) => value - value.PercentOf(percent);

        /// <summary>
        /// Substracts float from ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Substract(this ulong x, float y) => x - (ulong)y;

        /// <summary>
        /// Adds float to ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Add(this ulong x, float y) => x + (ulong)y;

        /// <summary>
        /// Divides float from ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong DividedBy(this ulong x, float y) => x / (ulong)y;

        /// <summary>
        /// Multiplies float with ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong MultipliedWith(this ulong x, float y) => x * (ulong)y;

        /// <summary>
        /// Gets the remainder of float from ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Modulus(this ulong x, float y) => x % (ulong)y;

        /// <summary>
        /// Gets the AND of float and ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong And(this ulong x, float y) => x & (ulong)y;

        /// <summary>
        /// Gets the OR of float and ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Or(this ulong x, float y) => (ulong)((int)x | (int)y);

        /// <summary>
        /// Gets XOR of float of ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Xor(this ulong x, float y) => x ^ (ulong)y;

        /// <summary>
        /// Gets a boolean True if ulong is less than float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this ulong x, float y) => x < (ulong)y;

        /// <summary>
        /// Gets a boolean True if ulong is greater than float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this ulong x, float y) => x > (ulong)y;

        /// <summary>
        /// Gets boolean True if float is equal to ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this ulong x, float y) => x == (ulong)y;

        /// <summary>
        /// Gets boolean True if float is not equal to ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this ulong x, float y) => x != (ulong)y;

        /// <summary>
        /// Tries to cast ulong to float, this can get ugly though
        /// </summary>
        /// <returns>The result of the operation</returns>
        public static float CastUlongToFloat(this ulong x) => x;

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static ulong PercentOf(this ulong percent, int value) => percent / 100 * ((ulong)value);

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static ulong AddPercent(this ulong value, int percent) => value + value.PercentOf(percent);

        /// <summary>
        /// Substracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static ulong SubstractPercent(this ulong value, int percent) => value - value.PercentOf(percent);

        /// <summary>
        /// Substracts int from ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Substract(this ulong x, int y) => x - (ulong)y;

        /// <summary>
        /// Adds int to ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Add(this ulong x, int y) => x + (ulong)y;

        /// <summary>
        /// Divides int from ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong DividedBy(this ulong x, int y) => x / (ulong)y;

        /// <summary>
        /// Multiplies int with ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong MultipliedWith(this ulong x, int y) => x * (ulong)y;

        /// <summary>
        /// Gets the remainder of int from ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Modulus(this ulong x, int y) => x % (ulong)y;

        /// <summary>
        /// Gets the AND of int and ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong And(this ulong x, int y) => x & (ulong)y;

        /// <summary>
        /// Gets the OR of int and ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Or(this ulong x, int y) => (ulong)((int)x | y);

        /// <summary>
        /// Gets XOR of int of ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Xor(this ulong x, int y) => x ^ (ulong)y;

        /// <summary>
        /// Gets a boolean True if ulong is less than int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this ulong x, int y) => x < (ulong)y;

        /// <summary>
        /// Gets a boolean True if ulong is greater than int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this ulong x, int y) => x > (ulong)y;

        /// <summary>
        /// Gets boolean True if int is equal to ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this ulong x, int y) => x == (ulong)y;

        /// <summary>
        /// Gets boolean True if int is not equal to ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this ulong x, int y) => x != (ulong)y;

        /// <summary>
        /// Tries to cast ulong to int, this can get ugly though
        /// </summary>
        /// <returns>The result of the operation</returns>
        public static int CastUlongToInt(this ulong x) => (int)x;

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static ulong PercentOf(this ulong percent, long value) => percent / 100 * ((ulong)value);

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static ulong AddPercent(this ulong value, long percent) => value + value.PercentOf(percent);

        /// <summary>
        /// Substracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static ulong SubstractPercent(this ulong value, long percent) => value - value.PercentOf(percent);

        /// <summary>
        /// Substracts long from ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Substract(this ulong x, long y) => x - (ulong)y;

        /// <summary>
        /// Adds long to ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Add(this ulong x, long y) => x + (ulong)y;

        /// <summary>
        /// Divides long from ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong DividedBy(this ulong x, long y) => x / (ulong)y;

        /// <summary>
        /// Multiplies long with ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong MultipliedWith(this ulong x, long y) => x * (ulong)y;

        /// <summary>
        /// Gets the remainder of long from ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Modulus(this ulong x, long y) => x % (ulong)y;

        /// <summary>
        /// Gets the AND of long and ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong And(this ulong x, long y) => x & (ulong)y;

        /// <summary>
        /// Gets the OR of long and ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Or(this ulong x, long y) => (ulong)((int)x | (int)y);

        /// <summary>
        /// Gets XOR of long of ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Xor(this ulong x, long y) => x ^ (ulong)y;

        /// <summary>
        /// Gets a boolean True if ulong is less than long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this ulong x, long y) => x < (ulong)y;

        /// <summary>
        /// Gets a boolean True if ulong is greater than long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this ulong x, long y) => x > (ulong)y;

        /// <summary>
        /// Gets boolean True if long is equal to ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this ulong x, long y) => x == (ulong)y;

        /// <summary>
        /// Gets boolean True if long is not equal to ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this ulong x, long y) => x != (ulong)y;

        /// <summary>
        /// Tries to cast ulong to long, this can get ugly though
        /// </summary>
        /// <returns>The result of the operation</returns>
        public static long CastUlongToLong(this ulong x) => (long)x;

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static ulong PercentOf(this ulong percent, sbyte value) => percent / 100 * ((ulong)value);

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static ulong AddPercent(this ulong value, sbyte percent) => value + value.PercentOf(percent);

        /// <summary>
        /// Substracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static ulong SubstractPercent(this ulong value, sbyte percent) => value - value.PercentOf(percent);

        /// <summary>
        /// Substracts sbyte from ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Substract(this ulong x, sbyte y) => x - (ulong)y;

        /// <summary>
        /// Adds sbyte to ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Add(this ulong x, sbyte y) => x + (ulong)y;

        /// <summary>
        /// Divides sbyte from ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong DividedBy(this ulong x, sbyte y) => x / (ulong)y;

        /// <summary>
        /// Multiplies sbyte with ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong MultipliedWith(this ulong x, sbyte y) => x * (ulong)y;

        /// <summary>
        /// Gets the remainder of sbyte from ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Modulus(this ulong x, sbyte y) => x % (ulong)y;

        /// <summary>
        /// Gets the AND of sbyte and ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong And(this ulong x, sbyte y) => x & (ulong)y;

        /// <summary>
        /// Gets the OR of sbyte and ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Or(this ulong x, sbyte y) => (ulong)((int)x | y);

        /// <summary>
        /// Gets XOR of sbyte of ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Xor(this ulong x, sbyte y) => x ^ (ulong)y;

        /// <summary>
        /// Gets a boolean True if ulong is less than sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this ulong x, sbyte y) => x < (ulong)y;

        /// <summary>
        /// Gets a boolean True if ulong is greater than sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this ulong x, sbyte y) => x > (ulong)y;

        /// <summary>
        /// Gets boolean True if sbyte is equal to ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this ulong x, sbyte y) => x == (ulong)y;

        /// <summary>
        /// Gets boolean True if sbyte is not equal to ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this ulong x, sbyte y) => x != (ulong)y;

        /// <summary>
        /// Tries to cast ulong to sbyte, this can get ugly though
        /// </summary>
        /// <returns>The result of the operation</returns>
        public static sbyte CastUlongToSbyte(this ulong x) => (sbyte)x;

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static ulong PercentOf(this ulong percent, short value) => percent / 100 * ((ulong)value);

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static ulong AddPercent(this ulong value, short percent) => value + value.PercentOf(percent);

        /// <summary>
        /// Substracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static ulong SubstractPercent(this ulong value, short percent) => value - value.PercentOf(percent);

        /// <summary>
        /// Substracts short from ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Substract(this ulong x, short y) => x - (ulong)y;

        /// <summary>
        /// Adds short to ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Add(this ulong x, short y) => x + (ulong)y;

        /// <summary>
        /// Divides short from ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong DividedBy(this ulong x, short y) => x / (ulong)y;

        /// <summary>
        /// Multiplies short with ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong MultipliedWith(this ulong x, short y) => x * (ulong)y;

        /// <summary>
        /// Gets the remainder of short from ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Modulus(this ulong x, short y) => x % (ulong)y;

        /// <summary>
        /// Gets the AND of short and ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong And(this ulong x, short y) => x & (ulong)y;

        /// <summary>
        /// Gets the OR of short and ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Or(this ulong x, short y) => (ulong)((int)x | y);

        /// <summary>
        /// Gets XOR of short of ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Xor(this ulong x, short y) => x ^ (ulong)y;

        /// <summary>
        /// Gets a boolean True if ulong is less than short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this ulong x, short y) => x < (ulong)y;

        /// <summary>
        /// Gets a boolean True if ulong is greater than short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this ulong x, short y) => x > (ulong)y;

        /// <summary>
        /// Gets boolean True if short is equal to ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this ulong x, short y) => x == (ulong)y;

        /// <summary>
        /// Gets boolean True if short is not equal to ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this ulong x, short y) => x != (ulong)y;

        /// <summary>
        /// Tries to cast ulong to short, this can get ugly though
        /// </summary>
        /// <returns>The result of the operation</returns>
        public static short CastUlongToShort(this ulong x) => (short)x;

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static ulong PercentOf(this ulong percent, uint value) => percent / 100 * value;

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static ulong AddPercent(this ulong value, uint percent) => value + value.PercentOf(percent);

        /// <summary>
        /// Substracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static ulong SubstractPercent(this ulong value, uint percent) => value - value.PercentOf(percent);

        /// <summary>
        /// Substracts uint from ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Substract(this ulong x, uint y) => x - y;

        /// <summary>
        /// Adds uint to ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Add(this ulong x, uint y) => x + y;

        /// <summary>
        /// Divides uint from ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong DividedBy(this ulong x, uint y) => x / y;

        /// <summary>
        /// Multiplies uint with ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong MultipliedWith(this ulong x, uint y) => x * y;

        /// <summary>
        /// Gets the remainder of uint from ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Modulus(this ulong x, uint y) => x % y;

        /// <summary>
        /// Gets the AND of uint and ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong And(this ulong x, uint y) => x & y;

        /// <summary>
        /// Gets the OR of uint and ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Or(this ulong x, uint y) => (ulong)((int)x | (int)y);

        /// <summary>
        /// Gets XOR of uint of ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Xor(this ulong x, uint y) => x ^ y;

        /// <summary>
        /// Gets a boolean True if ulong is less than uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this ulong x, uint y) => x < y;

        /// <summary>
        /// Gets a boolean True if ulong is greater than uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this ulong x, uint y) => x > y;

        /// <summary>
        /// Gets boolean True if uint is equal to ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this ulong x, uint y) => x == y;

        /// <summary>
        /// Gets boolean True if uint is not equal to ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this ulong x, uint y) => x != y;

        /// <summary>
        /// Tries to cast ulong to uint, this can get ugly though
        /// </summary>
        /// <returns>The result of the operation</returns>
        public static uint CastUlongToUint(this ulong x) => (uint)x;

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static ulong PercentOf(this ulong percent, ulong value) => percent / 100 * value;

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static ulong AddPercent(this ulong value, ulong percent) => value + value.PercentOf(percent);

        /// <summary>
        /// Substracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static ulong SubstractPercent(this ulong value, ulong percent) => value - value.PercentOf(percent);

        /// <summary>
        /// Substracts ulong from ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Substract(this ulong x, ulong y) => x - y;

        /// <summary>
        /// Adds ulong to ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Add(this ulong x, ulong y) => x + y;

        /// <summary>
        /// Divides ulong from ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong DividedBy(this ulong x, ulong y) => x / y;

        /// <summary>
        /// Multiplies ulong with ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong MultipliedWith(this ulong x, ulong y) => x * y;

        /// <summary>
        /// Gets the remainder of ulong from ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Modulus(this ulong x, ulong y) => x % y;

        /// <summary>
        /// Gets the AND of ulong and ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong And(this ulong x, ulong y) => x & y;

        /// <summary>
        /// Gets the OR of ulong and ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Or(this ulong x, ulong y) => (ulong)((int)x | (int)y);

        /// <summary>
        /// Gets XOR of ulong of ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Xor(this ulong x, ulong y) => x ^ y;

        /// <summary>
        /// Gets a boolean True if ulong is less than ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this ulong x, ulong y) => x < y;

        /// <summary>
        /// Gets a boolean True if ulong is greater than ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this ulong x, ulong y) => x > y;

        /// <summary>
        /// Gets boolean True if ulong is equal to ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this ulong x, ulong y) => x == y;

        /// <summary>
        /// Gets boolean True if ulong is not equal to ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this ulong x, ulong y) => x != y;

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static ulong PercentOf(this ulong percent, ushort value) => percent / 100 * value;

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static ulong AddPercent(this ulong value, ushort percent) => value + value.PercentOf(percent);

        /// <summary>
        /// Substracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static ulong SubstractPercent(this ulong value, ushort percent) => value - value.PercentOf(percent);

        /// <summary>
        /// Substracts ushort from ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Substract(this ulong x, ushort y) => x - y;

        /// <summary>
        /// Adds ushort to ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Add(this ulong x, ushort y) => x + y;

        /// <summary>
        /// Divides ushort from ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong DividedBy(this ulong x, ushort y) => x / y;

        /// <summary>
        /// Multiplies ushort with ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong MultipliedWith(this ulong x, ushort y) => x * y;

        /// <summary>
        /// Gets the remainder of ushort from ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Modulus(this ulong x, ushort y) => x % y;

        /// <summary>
        /// Gets the AND of ushort and ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong And(this ulong x, ushort y) => x & y;

        /// <summary>
        /// Gets the OR of ushort and ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Or(this ulong x, ushort y) => (ulong)((int)x | y);

        /// <summary>
        /// Gets XOR of ushort of ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Xor(this ulong x, ushort y) => x ^ y;

        /// <summary>
        /// Gets a boolean True if ulong is less than ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this ulong x, ushort y) => x < y;

        /// <summary>
        /// Gets a boolean True if ulong is greater than ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this ulong x, ushort y) => x > y;

        /// <summary>
        /// Gets boolean True if ushort is equal to ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this ulong x, ushort y) => x == y;

        /// <summary>
        /// Gets boolean True if ushort is not equal to ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this ulong x, ushort y) => x != y;

        /// <summary>
        /// Tries to cast ulong to ushort, this can get ugly though
        /// </summary>
        /// <returns>The result of the operation</returns>
        public static ushort CastUlongToUshort(this ulong x) => (ushort)x;

    }
}
