// ----------------------------------------------------------------------------------------------
// <copyright file="TypedMathUlongExtension.cs" company="MarcusMedinaPro">
//     By Marcus Medina, 2019 - http://MarcusMedina.Pro This file is subject to the terms and
//     conditions defined in file 'license.txt', which is part of this project.
// </copyright>
// ----------------------------------------------------------------------------------------------
// Credits for borrowed code: LinQ Primenumbers, Zoran Horvat, at
// http://www.codinghelmet.com/articles/linq-all-primes/ Increase/Decrease array values, mgp -
// https://stackoverflow.com/users/55943/mqp, at https://stackoverflow.com/a/823537 ----------------------------------------------------------------------------------------------

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
        /// Adds byte to ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Add(this ulong x, byte y) => x + (ulong)y;

        /// <summary>
        /// Adds char to ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Add(this ulong x, char y) => x + (ulong)y;

        /// <summary>
        /// Adds decimal to ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Add(this ulong x, decimal y) => x + (ulong)y;

        /// <summary>
        /// Adds double to ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Add(this ulong x, double y) => x + (ulong)y;

        /// <summary>
        /// Adds float to ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Add(this ulong x, float y) => x + (ulong)y;

        /// <summary>
        /// Adds int to ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Add(this ulong x, int y) => x + (ulong)y;

        /// <summary>
        /// Adds long to ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Add(this ulong x, long y) => x + (ulong)y;

        /// <summary>
        /// Adds sbyte to ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Add(this ulong x, sbyte y) => x + (ulong)y;

        /// <summary>
        /// Adds short to ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Add(this ulong x, short y) => x + (ulong)y;

        /// <summary>
        /// Adds uint to ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Add(this ulong x, uint y) => x + (ulong)y;

        /// <summary>
        /// Adds ulong to ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Add(this ulong x, ulong y) => x + y;

        /// <summary>
        /// Adds ushort to ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Add(this ulong x, ushort y) => x + (ulong)y;

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static ulong AddPercent(this ulong value, byte percent) => (ulong)(value + value.PercentOf(percent));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static ulong AddPercent(this ulong value, char percent) => (ulong)(value + value.PercentOf(percent));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static ulong AddPercent(this ulong value, decimal percent) => (ulong)(value + value.PercentOf(percent));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static ulong AddPercent(this ulong value, double percent) => (ulong)(value + value.PercentOf(percent));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static ulong AddPercent(this ulong value, float percent) => (ulong)(value + value.PercentOf(percent));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static ulong AddPercent(this ulong value, int percent) => (ulong)(value + value.PercentOf(percent));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static ulong AddPercent(this ulong value, long percent) => (ulong)(value + value.PercentOf(percent));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static ulong AddPercent(this ulong value, sbyte percent) => (ulong)(value + value.PercentOf(percent));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static ulong AddPercent(this ulong value, short percent) => (ulong)(value + value.PercentOf(percent));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static ulong AddPercent(this ulong value, uint percent) => (ulong)(value + value.PercentOf(percent));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static ulong AddPercent(this ulong value, ulong percent) => (ulong)(value + value.PercentOf(percent));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static ulong AddPercent(this ulong value, ushort percent) => (ulong)(value + value.PercentOf(percent));

        /// <summary>
        /// Gets the AND of byte and ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong And(this ulong x, byte y) => x & (ulong)y;

        /// <summary>
        /// Gets the AND of char and ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong And(this ulong x, char y) => x & (ulong)y;

        /// <summary>
        /// Gets the AND of decimal and ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong And(this ulong x, decimal y) => x & (ulong)y;

        /// <summary>
        /// Gets the AND of double and ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong And(this ulong x, double y) => x & (ulong)y;

        /// <summary>
        /// Gets the AND of float and ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong And(this ulong x, float y) => x & (ulong)y;

        /// <summary>
        /// Gets the AND of int and ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong And(this ulong x, int y) => x & (ulong)y;

        /// <summary>
        /// Gets the AND of long and ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong And(this ulong x, long y) => x & (ulong)y;

        /// <summary>
        /// Gets the AND of sbyte and ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong And(this ulong x, sbyte y) => x & (ulong)y;

        /// <summary>
        /// Gets the AND of short and ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong And(this ulong x, short y) => x & (ulong)y;

        /// <summary>
        /// Gets the AND of uint and ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong And(this ulong x, uint y) => x & (ulong)y;

        /// <summary>
        /// Gets the AND of ulong and ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong And(this ulong x, ulong y) => x & y;

        /// <summary>
        /// Gets the AND of ushort and ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong And(this ulong x, ushort y) => x & (ulong)y;

        /// <summary>
        /// Tries to cast ulong to byte, this can get ugly though
        /// </summary>
        /// <param name="x">The x <see cref="ulong"/></param>
        /// <returns>The result of the operation</returns>
        public static byte CastUlongToByte(this ulong x) => (byte)x;

        /// <summary>
        /// Tries to cast ulong to char, this can get ugly though
        /// </summary>
        /// <param name="x">The x <see cref="ulong"/></param>
        /// <returns>The result of the operation</returns>
        public static char CastUlongToChar(this ulong x) => (char)x;

        /// <summary>
        /// Tries to cast ulong to decimal, this can get ugly though
        /// </summary>
        /// <param name="x">The x <see cref="ulong"/></param>
        /// <returns>The result of the operation</returns>
        public static decimal CastUlongToDecimal(this ulong x) => (decimal)x;

        /// <summary>
        /// Tries to cast ulong to double, this can get ugly though
        /// </summary>
        /// <param name="x">The x <see cref="ulong"/></param>
        /// <returns>The result of the operation</returns>
        public static double CastUlongToDouble(this ulong x) => (double)x;

        /// <summary>
        /// Tries to cast ulong to float, this can get ugly though
        /// </summary>
        /// <param name="x">The x <see cref="ulong"/></param>
        /// <returns>The result of the operation</returns>
        public static float CastUlongToFloat(this ulong x) => (float)x;

        /// <summary>
        /// Tries to cast ulong to int, this can get ugly though
        /// </summary>
        /// <param name="x">The x <see cref="ulong"/></param>
        /// <returns>The result of the operation</returns>
        public static int CastUlongToInt(this ulong x) => (int)x;

        /// <summary>
        /// Tries to cast ulong to long, this can get ugly though
        /// </summary>
        /// <param name="x">The x <see cref="ulong"/></param>
        /// <returns>The result of the operation</returns>
        public static long CastUlongToLong(this ulong x) => (long)x;

        /// <summary>
        /// Tries to cast ulong to sbyte, this can get ugly though
        /// </summary>
        /// <param name="x">The x <see cref="ulong"/></param>
        /// <returns>The result of the operation</returns>
        public static sbyte CastUlongToSbyte(this ulong x) => (sbyte)x;

        /// <summary>
        /// Tries to cast ulong to short, this can get ugly though
        /// </summary>
        /// <param name="x">The x <see cref="ulong"/></param>
        /// <returns>The result of the operation</returns>
        public static short CastUlongToShort(this ulong x) => (short)x;

        /// <summary>
        /// Tries to cast ulong to uint, this can get ugly though
        /// </summary>
        /// <param name="x">The x <see cref="ulong"/></param>
        /// <returns>The result of the operation</returns>
        public static uint CastUlongToUint(this ulong x) => (uint)x;

        /// <summary>
        /// Tries to cast ulong to ushort, this can get ugly though
        /// </summary>
        /// <param name="x">The x <see cref="ulong"/></param>
        /// <returns>The result of the operation</returns>
        public static ushort CastUlongToUshort(this ulong x) => (ushort)x;

        /// <summary>
        /// Compare original and second number
        /// </summary>
        /// <param name="first">The number</param>
        /// <param name="second">The number to compare with</param>
        /// <returns>The highest of the two numbers</returns>
        public static ulong ChooseIfHigher(this ulong first, ulong second) => first > second ? first : second;

        /// <summary>
        /// Compare original and second number
        /// </summary>
        /// <param name="first">The number</param>
        /// <param name="second">The number to compare with</param>
        /// <returns>The lowest of the two numbers</returns>
        public static ulong ChooseIfLower(this ulong first, ulong second) => first < second ? first : second;

        /// <summary>
        /// Converts the array to int.
        /// </summary>
        /// <param name="array">The array.</param>
        /// <returns>The <see cref="int[]"/></returns>
        public static int[] ConvertArrayToInt(this ulong[] array) => array.Select(x => (int)x).ToArray();

        /// <summary>
        /// Gets the differnce between two numbers
        /// </summary>
        /// <param name="original">The original.</param>
        /// <param name="compareTo">The compare to.</param>
        /// <returns></returns>
        public static ulong DiferenceFrom(this ulong original, ulong compareTo) => original > compareTo ? original - compareTo : original < compareTo ? compareTo - original : 0;

        /// <summary>
        /// Divides byte from ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong DividedBy(this ulong x, byte y) => x / (ulong)y;

        /// <summary>
        /// Divides char from ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong DividedBy(this ulong x, char y) => x / (ulong)y;

        /// <summary>
        /// Divides decimal from ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong DividedBy(this ulong x, decimal y) => x / (ulong)y;

        /// <summary>
        /// Divides double from ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong DividedBy(this ulong x, double y) => x / (ulong)y;

        /// <summary>
        /// Divides float from ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong DividedBy(this ulong x, float y) => x / (ulong)y;

        /// <summary>
        /// Divides int from ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong DividedBy(this ulong x, int y) => x / (ulong)y;

        /// <summary>
        /// Divides long from ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong DividedBy(this ulong x, long y) => x / (ulong)y;

        /// <summary>
        /// Divides sbyte from ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong DividedBy(this ulong x, sbyte y) => x / (ulong)y;

        /// <summary>
        /// Divides short from ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong DividedBy(this ulong x, short y) => x / (ulong)y;

        /// <summary>
        /// Divides uint from ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong DividedBy(this ulong x, uint y) => x / (ulong)y;

        /// <summary>
        /// Divides ulong from ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong DividedBy(this ulong x, ulong y) => x / y;

        /// <summary>
        /// Divides ushort from ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong DividedBy(this ulong x, ushort y) => x / (ulong)y;

        /// <summary>
        /// Gets the first half of the array.
        /// </summary>
        /// <param name="array">The array.</param>
        /// <returns>The <see cref="ulong[]"/></returns>
        public static ulong[] GetFirstHalf(this ulong[] array) => array.Take(array.Length / 2).ToArray();

        /// <summary>
        /// Gets the first number in the array
        /// </summary>
        /// <param name="array">The array <see cref="ulong[]"/></param>
        /// <returns>The result of the operation</returns>
        public static ulong GetFirstValue(this ulong[] array) => array[0];

        /// <summary>
        /// Gets the hightest value of the numbers in the array
        /// </summary>
        /// <param name="array">The array</param>
        /// <returns>The hightest value in the array</returns>
        public static ulong GetHighestValue(this ulong[] array) => array.Max();

        /// <summary>
        /// Gets the last half of the array.
        /// </summary>
        /// <param name="array">The array.</param>
        /// <returns>The <see cref="ulong[]"/></returns>
        public static ulong[] GetLastHalf(this ulong[] array) => array.Skip(array.Length / 2).Take(array.Length / 2).ToArray();

        /// <summary>
        /// Gets the last number in the array
        /// </summary>
        /// <param name="array">The array <see cref="ulong[]"/></param>
        /// <returns>The result of the operation</returns>
        public static ulong GetLastValue(this ulong[] array) => array[array.Length - 1];

        /// <summary>
        /// Peeks the lowest value in the array
        /// </summary>
        /// <param name="array">The array <see cref="ulong[]"/></param>
        /// <returns>The lowest value i the array</returns>
        public static ulong GetLowestValue(this ulong[] array) => array.Min();

        /// <summary>
        /// Gets the middle of both halves in the array.
        /// </summary>
        /// <param name="array">The array.</param>
        /// <returns>The <see cref="ulong[]"/></returns>
        public static ulong[] GetMiddle(this ulong[] array) => array.Skip(array.Length / 4).Take(array.Length / 2).ToArray();

        /// <summary>
        /// Gets the number in the middle of the array
        /// </summary>
        /// <param name="array">The array <see cref="ulong[]"/></param>
        /// <returns>The result of the operation</returns>
        public static ulong GetMiddleValue(this ulong[] array) => array[(array.Length - 1) / 2];

        /// <summary>
        /// Peeks numbers higher than given value in the array
        /// </summary>
        /// <param name="array"></param>
        /// <param name="x">The limit value</param>
        /// <returns>Returns a new array with all numbers higher than x</returns>
        public static ulong[] GetValuesHigherThan(this ulong[] array, ulong x) => array.Where(y => y >= x).ToArray();

        /// <summary>
        /// Peeks numbers lower than given value in the array
        /// </summary>
        /// <param name="array"></param>
        /// <param name="x">The limit value</param>
        /// <returns>Returns a new array with all numbers lower than x</returns>
        public static ulong[] GetValuesLowerThan(this ulong[] array, ulong x) => array.Where(y => y <= x).ToArray();

        /// <summary>
        /// Gets a boolean True if ulong is greater than byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this ulong x, byte y) => x > (ulong)y;

        /// <summary>
        /// Gets a boolean True if ulong is greater than char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this ulong x, char y) => x > (ulong)y;

        /// <summary>
        /// Gets a boolean True if ulong is greater than decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this ulong x, decimal y) => x > (ulong)y;

        /// <summary>
        /// Gets a boolean True if ulong is greater than double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this ulong x, double y) => x > (ulong)y;

        /// <summary>
        /// Gets a boolean True if ulong is greater than float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this ulong x, float y) => x > (ulong)y;

        /// <summary>
        /// Gets a boolean True if ulong is greater than int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this ulong x, int y) => x > (ulong)y;

        /// <summary>
        /// Gets a boolean True if ulong is greater than long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this ulong x, long y) => x > (ulong)y;

        /// <summary>
        /// Gets a boolean True if ulong is greater than sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this ulong x, sbyte y) => x > (ulong)y;

        /// <summary>
        /// Gets a boolean True if ulong is greater than short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this ulong x, short y) => x > (ulong)y;

        /// <summary>
        /// Gets a boolean True if ulong is greater than uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this ulong x, uint y) => x > (ulong)y;

        /// <summary>
        /// Gets a boolean True if ulong is greater than ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this ulong x, ulong y) => x > y;

        /// <summary>
        /// Gets a boolean True if ulong is greater than ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this ulong x, ushort y) => x > (ulong)y;

        /// <summary>
        /// Gets boolean True if byte is equal to ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this ulong x, byte y) => x == (ulong)y;

        /// <summary>
        /// Gets boolean True if char is equal to ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this ulong x, char y) => x == (ulong)y;

        /// <summary>
        /// Gets boolean True if decimal is equal to ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this ulong x, decimal y) => x == (ulong)y;

        /// <summary>
        /// Gets boolean True if double is equal to ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this ulong x, double y) => x == (ulong)y;

        /// <summary>
        /// Gets boolean True if float is equal to ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this ulong x, float y) => x == (ulong)y;

        /// <summary>
        /// Gets boolean True if int is equal to ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this ulong x, int y) => x == (ulong)y;

        /// <summary>
        /// Gets boolean True if long is equal to ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this ulong x, long y) => x == (ulong)y;

        /// <summary>
        /// Gets boolean True if sbyte is equal to ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this ulong x, sbyte y) => x == (ulong)y;

        /// <summary>
        /// Gets boolean True if short is equal to ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this ulong x, short y) => x == (ulong)y;

        /// <summary>
        /// Gets boolean True if uint is equal to ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this ulong x, uint y) => x == (ulong)y;

        /// <summary>
        /// Gets boolean True if ulong is equal to ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this ulong x, ulong y) => x == y;

        /// <summary>
        /// Gets boolean True if ushort is equal to ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this ulong x, ushort y) => x == (ulong)y;

        /// <summary>
        /// Gets boolean True if byte is not equal to ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this ulong x, byte y) => x != (ulong)y;

        /// <summary>
        /// Gets boolean True if char is not equal to ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this ulong x, char y) => x != (ulong)y;

        /// <summary>
        /// Gets boolean True if decimal is not equal to ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this ulong x, decimal y) => x != (ulong)y;

        /// <summary>
        /// Gets boolean True if double is not equal to ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this ulong x, double y) => x != (ulong)y;

        /// <summary>
        /// Gets boolean True if float is not equal to ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this ulong x, float y) => x != (ulong)y;

        /// <summary>
        /// Gets boolean True if int is not equal to ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this ulong x, int y) => x != (ulong)y;

        /// <summary>
        /// Gets boolean True if long is not equal to ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this ulong x, long y) => x != (ulong)y;

        /// <summary>
        /// Gets boolean True if sbyte is not equal to ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this ulong x, sbyte y) => x != (ulong)y;

        /// <summary>
        /// Gets boolean True if short is not equal to ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this ulong x, short y) => x != (ulong)y;

        /// <summary>
        /// Gets boolean True if uint is not equal to ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this ulong x, uint y) => x != (ulong)y;

        /// <summary>
        /// Gets boolean True if ulong is not equal to ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this ulong x, ulong y) => x != y;

        /// <summary>
        /// Gets boolean True if ushort is not equal to ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this ulong x, ushort y) => x != (ulong)y;

        /// <summary>
        /// Checks if a number is prime
        /// </summary>
        /// <param name="number">The number</param>
        /// <returns>True if the number is prime</returns>
        public static bool IsPrime(this ulong number) => Enumerable.Range(2, (int)Math.Sqrt(number) - 1).All(divisor => (long)number % divisor != 0);

        /// <summary>
        /// Gets a boolean True if ulong is less than byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this ulong x, byte y) => x < (ulong)y;

        /// <summary>
        /// Gets a boolean True if ulong is less than char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this ulong x, char y) => x < (ulong)y;

        /// <summary>
        /// Gets a boolean True if ulong is less than decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this ulong x, decimal y) => x < (ulong)y;

        /// <summary>
        /// Gets a boolean True if ulong is less than double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this ulong x, double y) => x < (ulong)y;

        /// <summary>
        /// Gets a boolean True if ulong is less than float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this ulong x, float y) => x < (ulong)y;

        /// <summary>
        /// Gets a boolean True if ulong is less than int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this ulong x, int y) => x < (ulong)y;

        /// <summary>
        /// Gets a boolean True if ulong is less than long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this ulong x, long y) => x < (ulong)y;

        /// <summary>
        /// Gets a boolean True if ulong is less than sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this ulong x, sbyte y) => x < (ulong)y;

        /// <summary>
        /// Gets a boolean True if ulong is less than short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this ulong x, short y) => x < (ulong)y;

        /// <summary>
        /// Gets a boolean True if ulong is less than uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this ulong x, uint y) => x < (ulong)y;

        /// <summary>
        /// Gets a boolean True if ulong is less than ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this ulong x, ulong y) => x < y;

        /// <summary>
        /// Gets a boolean True if ulong is less than ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this ulong x, ushort y) => x < (ulong)y;

        /// <summary>
        /// Gets the remainder of byte from ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Modulus(this ulong x, byte y) => x % (ulong)y;

        /// <summary>
        /// Gets the remainder of char from ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Modulus(this ulong x, char y) => x % (ulong)y;

        /// <summary>
        /// Gets the remainder of decimal from ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Modulus(this ulong x, decimal y) => x % (ulong)y;

        /// <summary>
        /// Gets the remainder of double from ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Modulus(this ulong x, double y) => x % (ulong)y;

        /// <summary>
        /// Gets the remainder of float from ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Modulus(this ulong x, float y) => x % (ulong)y;

        /// <summary>
        /// Gets the remainder of int from ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Modulus(this ulong x, int y) => x % (ulong)y;

        /// <summary>
        /// Gets the remainder of long from ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Modulus(this ulong x, long y) => x % (ulong)y;

        /// <summary>
        /// Gets the remainder of sbyte from ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Modulus(this ulong x, sbyte y) => x % (ulong)y;

        /// <summary>
        /// Gets the remainder of short from ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Modulus(this ulong x, short y) => x % (ulong)y;

        /// <summary>
        /// Gets the remainder of uint from ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Modulus(this ulong x, uint y) => x % (ulong)y;

        /// <summary>
        /// Gets the remainder of ulong from ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Modulus(this ulong x, ulong y) => x % y;

        /// <summary>
        /// Gets the remainder of ushort from ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Modulus(this ulong x, ushort y) => x % (ulong)y;

        /// <summary>
        /// Multiplies byte with ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong MultipliedWith(this ulong x, byte y) => x * (ulong)y;

        /// <summary>
        /// Multiplies char with ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong MultipliedWith(this ulong x, char y) => x * (ulong)y;

        /// <summary>
        /// Multiplies decimal with ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong MultipliedWith(this ulong x, decimal y) => x * (ulong)y;

        /// <summary>
        /// Multiplies double with ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong MultipliedWith(this ulong x, double y) => x * (ulong)y;

        /// <summary>
        /// Multiplies float with ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong MultipliedWith(this ulong x, float y) => x * (ulong)y;

        /// <summary>
        /// Multiplies int with ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong MultipliedWith(this ulong x, int y) => x * (ulong)y;

        /// <summary>
        /// Multiplies long with ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong MultipliedWith(this ulong x, long y) => x * (ulong)y;

        /// <summary>
        /// Multiplies sbyte with ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong MultipliedWith(this ulong x, sbyte y) => x * (ulong)y;

        /// <summary>
        /// Multiplies short with ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong MultipliedWith(this ulong x, short y) => x * (ulong)y;

        /// <summary>
        /// Multiplies uint with ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong MultipliedWith(this ulong x, uint y) => x * (ulong)y;

        /// <summary>
        /// Multiplies ulong with ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong MultipliedWith(this ulong x, ulong y) => x * y;

        /// <summary>
        /// Multiplies ushort with ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong MultipliedWith(this ulong x, ushort y) => x * (ulong)y;

        /// <summary>
        /// Gets the NOT of ulong
        /// </summary>
        /// <param name="x">The x <see cref="ulong"/></param>
        /// <returns>The result of the operation</returns>
        public static ulong Not(this ulong x) => (ulong)~(int)x;

        /// <summary>
        /// Gets the OR of byte and ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Or(this ulong x, byte y) => (ulong)((int)x | (int)y);

        /// <summary>
        /// Gets the OR of char and ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Or(this ulong x, char y) => (ulong)((int)x | (int)y);

        /// <summary>
        /// Gets the OR of decimal and ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Or(this ulong x, decimal y) => (ulong)((int)x | (int)y);

        /// <summary>
        /// Gets the OR of double and ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Or(this ulong x, double y) => (ulong)((int)x | (int)y);

        /// <summary>
        /// Gets the OR of float and ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Or(this ulong x, float y) => (ulong)((int)x | (int)y);

        /// <summary>
        /// Gets the OR of int and ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Or(this ulong x, int y) => (ulong)((int)x | (int)y);

        /// <summary>
        /// Gets the OR of long and ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Or(this ulong x, long y) => (ulong)((int)x | (int)y);

        /// <summary>
        /// Gets the OR of sbyte and ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Or(this ulong x, sbyte y) => (ulong)((int)x | (int)y);

        /// <summary>
        /// Gets the OR of short and ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Or(this ulong x, short y) => (ulong)((int)x | (int)y);

        /// <summary>
        /// Gets the OR of uint and ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Or(this ulong x, uint y) => (ulong)((int)x | (int)y);

        /// <summary>
        /// Gets the OR of ulong and ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Or(this ulong x, ulong y) => (ulong)((int)x | (int)y);

        /// <summary>
        /// Gets the OR of ushort and ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Or(this ulong x, ushort y) => (ulong)((int)x | (int)y);

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static ulong PercentOf(this ulong percent, byte value) => (ulong)(((ulong)percent) / ((ulong)100) * ((ulong)value));

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static ulong PercentOf(this ulong percent, char value) => (ulong)(((ulong)percent) / ((ulong)100) * ((ulong)value));

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static ulong PercentOf(this ulong percent, decimal value) => (ulong)(((ulong)percent) / ((ulong)100) * ((ulong)value));

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static ulong PercentOf(this ulong percent, double value) => (ulong)(((ulong)percent) / ((ulong)100) * ((ulong)value));

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static ulong PercentOf(this ulong percent, float value) => (ulong)(((ulong)percent) / ((ulong)100) * ((ulong)value));

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static ulong PercentOf(this ulong percent, int value) => (ulong)(((ulong)percent) / ((ulong)100) * ((ulong)value));

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static ulong PercentOf(this ulong percent, long value) => (ulong)(((ulong)percent) / ((ulong)100) * ((ulong)value));

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static ulong PercentOf(this ulong percent, sbyte value) => (ulong)(((ulong)percent) / ((ulong)100) * ((ulong)value));

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static ulong PercentOf(this ulong percent, short value) => (ulong)(((ulong)percent) / ((ulong)100) * ((ulong)value));

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static ulong PercentOf(this ulong percent, uint value) => (ulong)(((ulong)percent) / ((ulong)100) * ((ulong)value));

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static ulong PercentOf(this ulong percent, ulong value) => (ulong)(((ulong)percent) / ((ulong)100) * ((ulong)value));

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static ulong PercentOf(this ulong percent, ushort value) => (ulong)(((ulong)percent) / ((ulong)100) * ((ulong)value));

        /// <summary>
        /// Rotates the numbers to the left.
        /// </summary>
        /// <param name="array">The array.</param>
        /// <returns>The <see cref="ulong[]"/></returns>
        public static ulong[] RotateLeft(this ulong[] array)
        {
            var first = array.GetFirstValue();
            Array.Copy(array, 1, array, 0, array.Length - 1);
            array[array.Length - 1] = first;
            return array;
        }

        /// <summary>
        /// Rotates the numbers to the right.
        /// </summary>
        /// <param name="array">The array.</param>
        /// <returns>The <see cref="ulong[]"/></returns>
        public static ulong[] RotateRight(this ulong[] array)
        {
            var last = array.GetLastValue();
            Array.Copy(array, 0, array, 1, array.Length - 1);
            array[0] = last;
            return array;
        }

        /// <summary>
        /// Compare original and second number and set the variable with the highest
        /// </summary>
        /// <param name="first">The variable</param>
        /// <param name="second">The number to compare</param>
        /// <param name="third">The number to compare with</param>
        /// <returns>Sets the variable to the highest of the two numbers</returns>
        public static ref ulong SetHighestValueOf(this ref ulong first, ulong second, ulong third)
        {
            first = second > third ? second : third;
            return ref first;
        }

        /// <summary>
        /// Compare original and second number and set the variable with the lowest
        /// </summary>
        /// <param name="first">The number</param>
        /// <param name="second">The number to compare with</param>
        /// <param name="third">The third <see cref="ulong"/></param>
        /// <returns>Sets the variable to the lowest of the two numbers</returns>
        public static ref ulong SetLowestValueOf(this ref ulong first, ulong second, ulong third)
        {
            first = second < third ? second : third;
            return ref first;
        }

        /// <summary>
        /// Get the current size of the array
        /// </summary>
        /// <param name="array">The array <see cref="ulong[]"/></param>
        /// <param name="size">The size <see cref="int"/></param>
        /// <returns>The size of the array</returns>
        public static ulong[] SetNewArraySize(this ulong[] array, int size)
        {
            var newArr = new ulong[size];
            Array.Copy(array, 0, newArr, 0, array.Length);
            return newArr;
        }

        /// <summary>
        /// Sorts array from lowest to highest
        /// </summary>
        /// <param name="array">The array <see cref="ulong[]"/></param>
        /// <returns>A sorted array</returns>
        public static ulong[] SortArrayAsc(this ulong[] array) => array.OrderBy(x => x).ToArray();

        /// <summary>
        /// Sorts array from highest to lowest
        /// </summary>
        /// <param name="array">The array <see cref="ulong[]"/></param>
        /// <returns>A sorted array</returns>
        public static ulong[] SortArrayDesc(this ulong[] array) => array.OrderByDescending(x => x).ToArray();

        /// <summary>
        /// Subtracts byte from ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(ulong,byte) instead.", false)]
        public static ulong Substract(this ulong x, byte y) => x - (ulong)y;

        /// <summary>
        /// Subtracts char from ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(ulong,char) instead.", false)]
        public static ulong Substract(this ulong x, char y) => x - (ulong)y;

        /// <summary>
        /// Subtracts decimal from ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(ulong,decimal) instead.", false)]
        public static ulong Substract(this ulong x, decimal y) => x - (ulong)y;

        /// <summary>
        /// Subtracts double from ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(ulong,double) instead.", false)]
        public static ulong Substract(this ulong x, double y) => x - (ulong)y;

        /// <summary>
        /// Subtracts float from ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(ulong,float) instead.", false)]
        public static ulong Substract(this ulong x, float y) => x - (ulong)y;

        /// <summary>
        /// Subtracts int from ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(ulong,int) instead.", false)]
        public static ulong Substract(this ulong x, int y) => x - (ulong)y;

        /// <summary>
        /// Subtracts long from ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(ulong,long) instead.", false)]
        public static ulong Substract(this ulong x, long y) => x - (ulong)y;

        /// <summary>
        /// Subtracts sbyte from ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(ulong,sbyte) instead.", false)]
        public static ulong Substract(this ulong x, sbyte y) => x - (ulong)y;

        /// <summary>
        /// Subtracts short from ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(ulong,short) instead.", false)]
        public static ulong Substract(this ulong x, short y) => x - (ulong)y;

        /// <summary>
        /// Subtracts uint from ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(ulong,uint) instead.", false)]
        public static ulong Substract(this ulong x, uint y) => x - (ulong)y;

        /// <summary>
        /// Subtracts ulong from ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(ulong,ulong) instead.", false)]
        public static ulong Substract(this ulong x, ulong y) => x - y;

        /// <summary>
        /// Subtracts ushort from ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(ulong,ushort) instead.", false)]
        public static ulong Substract(this ulong x, ushort y) => x - (ulong)y;

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(byte) instead.", false)]
        public static ulong SubstractPercent(this ulong value, byte percent) => (ulong)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(char) instead.", false)]
        public static ulong SubstractPercent(this ulong value, char percent) => (ulong)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(decimal) instead.", false)]
        public static ulong SubstractPercent(this ulong value, decimal percent) => (ulong)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(double) instead.", false)]
        public static ulong SubstractPercent(this ulong value, double percent) => (ulong)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(float) instead.", false)]
        public static ulong SubstractPercent(this ulong value, float percent) => (ulong)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(int) instead.", false)]
        public static ulong SubstractPercent(this ulong value, int percent) => (ulong)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(long) instead.", false)]
        public static ulong SubstractPercent(this ulong value, long percent) => (ulong)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(sbyte) instead.", false)]
        public static ulong SubstractPercent(this ulong value, sbyte percent) => (ulong)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(short) instead.", false)]
        public static ulong SubstractPercent(this ulong value, short percent) => (ulong)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(uint) instead.", false)]
        public static ulong SubstractPercent(this ulong value, uint percent) => (ulong)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(ulong) instead.", false)]
        public static ulong SubstractPercent(this ulong value, ulong percent) => (ulong)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(ushort) instead.", false)]
        public static ulong SubstractPercent(this ulong value, ushort percent) => (ulong)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts byte from ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Subtract(this ulong x, byte y) => x - (ulong)y;

        /// <summary>
        /// Subtracts char from ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Subtract(this ulong x, char y) => x - (ulong)y;

        /// <summary>
        /// Subtracts decimal from ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Subtract(this ulong x, decimal y) => x - (ulong)y;

        /// <summary>
        /// Subtracts double from ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Subtract(this ulong x, double y) => x - (ulong)y;

        /// <summary>
        /// Subtracts float from ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Subtract(this ulong x, float y) => x - (ulong)y;

        /// <summary>
        /// Subtracts int from ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Subtract(this ulong x, int y) => x - (ulong)y;

        /// <summary>
        /// Subtracts long from ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Subtract(this ulong x, long y) => x - (ulong)y;

        /// <summary>
        /// Subtracts sbyte from ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Subtract(this ulong x, sbyte y) => x - (ulong)y;

        /// <summary>
        /// Subtracts short from ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Subtract(this ulong x, short y) => x - (ulong)y;

        /// <summary>
        /// Subtracts uint from ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Subtract(this ulong x, uint y) => x - (ulong)y;

        /// <summary>
        /// Subtracts ulong from ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Subtract(this ulong x, ulong y) => x - y;

        /// <summary>
        /// Subtracts ushort from ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Subtract(this ulong x, ushort y) => x - (ulong)y;

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static ulong SubtractPercent(this ulong value, byte percent) => (ulong)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static ulong SubtractPercent(this ulong value, char percent) => (ulong)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static ulong SubtractPercent(this ulong value, decimal percent) => (ulong)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static ulong SubtractPercent(this ulong value, double percent) => (ulong)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static ulong SubtractPercent(this ulong value, float percent) => (ulong)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static ulong SubtractPercent(this ulong value, int percent) => (ulong)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static ulong SubtractPercent(this ulong value, long percent) => (ulong)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static ulong SubtractPercent(this ulong value, sbyte percent) => (ulong)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static ulong SubtractPercent(this ulong value, short percent) => (ulong)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static ulong SubtractPercent(this ulong value, uint percent) => (ulong)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static ulong SubtractPercent(this ulong value, ulong percent) => (ulong)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static ulong SubtractPercent(this ulong value, ushort percent) => (ulong)(value - value.PercentOf(percent));

        /// <summary>
        /// Swaps two variables
        /// </summary>
        /// <param name="first">The main variable</param>
        /// <param name="second">The variable to switch with</param>
        /// <returns>
        /// The value from the second variable and sets second variable to original value
        /// </returns>
        public static ref ulong SwapWith(this ref ulong first, ref ulong second)
        {
            var tmp = second;
            second = first;
            first = tmp;
            return ref first;
        }

        /// <summary>
        /// Gets XOR of byte of ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Xor(this ulong x, byte y) => x ^ (ulong)y;

        /// <summary>
        /// Gets XOR of char of ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Xor(this ulong x, char y) => x ^ (ulong)y;

        /// <summary>
        /// Gets XOR of decimal of ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Xor(this ulong x, decimal y) => x ^ (ulong)y;

        /// <summary>
        /// Gets XOR of double of ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Xor(this ulong x, double y) => x ^ (ulong)y;

        /// <summary>
        /// Gets XOR of float of ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Xor(this ulong x, float y) => x ^ (ulong)y;

        /// <summary>
        /// Gets XOR of int of ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Xor(this ulong x, int y) => x ^ (ulong)y;

        /// <summary>
        /// Gets XOR of long of ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Xor(this ulong x, long y) => x ^ (ulong)y;

        /// <summary>
        /// Gets XOR of sbyte of ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Xor(this ulong x, sbyte y) => x ^ (ulong)y;

        /// <summary>
        /// Gets XOR of short of ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Xor(this ulong x, short y) => x ^ (ulong)y;

        /// <summary>
        /// Gets XOR of uint of ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Xor(this ulong x, uint y) => x ^ (ulong)y;

        /// <summary>
        /// Gets XOR of ulong of ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Xor(this ulong x, ulong y) => x ^ y;

        /// <summary>
        /// Gets XOR of ushort of ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ulong Xor(this ulong x, ushort y) => x ^ (ulong)y;
    }
}