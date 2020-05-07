// ----------------------------------------------------------------------------------------------
// <copyright file="TypedMathLongExtension.cs" company="MarcusMedinaPro">
//     By Marcus Medina, 2019 - http://MarcusMedina.Pro This file is subject to the terms and
//     conditions defined in file 'license.txt', which is part of this project.
// </copyright>
// ----------------------------------------------------------------------------------------------
// Credits for borrowed code: LinQ Primenumbers, Zoran Horvat, at
// http://www.codinghelmet.com/articles/linq-all-primes/ Increase/Decrease array values, mgp -
// https://stackoverflow.com/users/55943/mqp, at https://stackoverflow.com/a/823537 ----------------------------------------------------------------------------------------------

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
        /// Adds byte to long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long Add(this long x, byte y) => x + (long)y;

        /// <summary>
        /// Adds char to long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long Add(this long x, char y) => x + (long)y;

        /// <summary>
        /// Adds decimal to long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long Add(this long x, decimal y) => x + (long)y;

        /// <summary>
        /// Adds double to long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long Add(this long x, double y) => x + (long)y;

        /// <summary>
        /// Adds float to long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long Add(this long x, float y) => x + (long)y;

        /// <summary>
        /// Adds int to long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long Add(this long x, int y) => x + (long)y;

        /// <summary>
        /// Adds long to long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long Add(this long x, long y) => x + y;

        /// <summary>
        /// Adds sbyte to long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long Add(this long x, sbyte y) => x + (long)y;

        /// <summary>
        /// Adds short to long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long Add(this long x, short y) => x + (long)y;

        /// <summary>
        /// Adds uint to long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long Add(this long x, uint y) => x + (long)y;

        /// <summary>
        /// Adds ulong to long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long Add(this long x, ulong y) => x + (long)y;

        /// <summary>
        /// Adds ushort to long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long Add(this long x, ushort y) => x + (long)y;

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static long AddPercent(this long value, byte percent) => (long)(value + value.PercentOf(percent));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static long AddPercent(this long value, char percent) => (long)(value + value.PercentOf(percent));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static long AddPercent(this long value, decimal percent) => (long)(value + value.PercentOf(percent));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static long AddPercent(this long value, double percent) => (long)(value + value.PercentOf(percent));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static long AddPercent(this long value, float percent) => (long)(value + value.PercentOf(percent));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static long AddPercent(this long value, int percent) => (long)(value + value.PercentOf(percent));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static long AddPercent(this long value, long percent) => (long)(value + value.PercentOf(percent));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static long AddPercent(this long value, sbyte percent) => (long)(value + value.PercentOf(percent));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static long AddPercent(this long value, short percent) => (long)(value + value.PercentOf(percent));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static long AddPercent(this long value, uint percent) => (long)(value + value.PercentOf(percent));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static long AddPercent(this long value, ulong percent) => (long)(value + value.PercentOf(percent));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static long AddPercent(this long value, ushort percent) => (long)(value + value.PercentOf(percent));

        /// <summary>
        /// Tries to cast long to byte, this can get ugly though
        /// </summary>
        /// <param name="x">The x <see cref="long"/></param>
        /// <returns>The result of the operation</returns>
        public static byte CastLongToByte(this long x) => (byte)x;

        /// <summary>
        /// Tries to cast long to char, this can get ugly though
        /// </summary>
        /// <param name="x">The x <see cref="long"/></param>
        /// <returns>The result of the operation</returns>
        public static char CastLongToChar(this long x) => (char)x;

        /// <summary>
        /// Tries to cast long to decimal, this can get ugly though
        /// </summary>
        /// <param name="x">The x <see cref="long"/></param>
        /// <returns>The result of the operation</returns>
        public static decimal CastLongToDecimal(this long x) => (decimal)x;

        /// <summary>
        /// Tries to cast long to double, this can get ugly though
        /// </summary>
        /// <param name="x">The x <see cref="long"/></param>
        /// <returns>The result of the operation</returns>
        public static double CastLongToDouble(this long x) => (double)x;

        /// <summary>
        /// Tries to cast long to float, this can get ugly though
        /// </summary>
        /// <param name="x">The x <see cref="long"/></param>
        /// <returns>The result of the operation</returns>
        public static float CastLongToFloat(this long x) => (float)x;

        /// <summary>
        /// Tries to cast long to int, this can get ugly though
        /// </summary>
        /// <param name="x">The x <see cref="long"/></param>
        /// <returns>The result of the operation</returns>
        public static int CastLongToInt(this long x) => (int)x;

        /// <summary>
        /// Tries to cast long to sbyte, this can get ugly though
        /// </summary>
        /// <param name="x">The x <see cref="long"/></param>
        /// <returns>The result of the operation</returns>
        public static sbyte CastLongToSbyte(this long x) => (sbyte)x;

        /// <summary>
        /// Tries to cast long to short, this can get ugly though
        /// </summary>
        /// <param name="x">The x <see cref="long"/></param>
        /// <returns>The result of the operation</returns>
        public static short CastLongToShort(this long x) => (short)x;

        /// <summary>
        /// Tries to cast long to uint, this can get ugly though
        /// </summary>
        /// <param name="x">The x <see cref="long"/></param>
        /// <returns>The result of the operation</returns>
        public static uint CastLongToUint(this long x) => (uint)x;

        /// <summary>
        /// Tries to cast long to ulong, this can get ugly though
        /// </summary>
        /// <param name="x">The x <see cref="long"/></param>
        /// <returns>The result of the operation</returns>
        public static ulong CastLongToUlong(this long x) => (ulong)x;

        /// <summary>
        /// Tries to cast long to ushort, this can get ugly though
        /// </summary>
        /// <param name="x">The x <see cref="long"/></param>
        /// <returns>The result of the operation</returns>
        public static ushort CastLongToUshort(this long x) => (ushort)x;

        /// <summary>
        /// Compare original and second number
        /// </summary>
        /// <param name="first">The number</param>
        /// <param name="second">The number to compare with</param>
        /// <returns>The highest of the two numbers</returns>
        public static long ChooseIfHigher(this long first, long second) => first > second ? first : second;

        /// <summary>
        /// Compare original and second number
        /// </summary>
        /// <param name="first">The number</param>
        /// <param name="second">The number to compare with</param>
        /// <returns>The lowest of the two numbers</returns>
        public static long ChooseIfLower(this long first, long second) => first < second ? first : second;

        /// <summary>
        /// Converts the array to int.
        /// </summary>
        /// <param name="array">The array.</param>
        /// <returns>The <see cref="int[]"/></returns>
        public static int[] ConvertArrayToInt(this long[] array) => array.Select(x => (int)x).ToArray();

        /// <summary>
        /// Decreases all values with given value.
        /// </summary>
        /// <param name="array">The array.</param>
        /// <param name="dec">The value to add.</param>
        /// <returns>The <see cref="long[]"/></returns>
        public static long[] DecreaseAllValuesWith(this long[] array, long dec) => array.Select(x => x - dec).ToArray();

        /// <summary>
        /// Gets the differnce between two numbers
        /// </summary>
        /// <param name="original">The original.</param>
        /// <param name="compareTo">The compare to.</param>
        /// <returns></returns>
        public static long DiferenceFrom(this long original, long compareTo) => original > compareTo ? original - compareTo : original < compareTo ? compareTo - original : 0;

        /// <summary>
        /// Divides byte from long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long DividedBy(this long x, byte y) => x / (long)y;

        /// <summary>
        /// Divides char from long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long DividedBy(this long x, char y) => x / (long)y;

        /// <summary>
        /// Divides decimal from long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long DividedBy(this long x, decimal y) => x / (long)y;

        /// <summary>
        /// Divides double from long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long DividedBy(this long x, double y) => x / (long)y;

        /// <summary>
        /// Divides float from long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long DividedBy(this long x, float y) => x / (long)y;

        /// <summary>
        /// Divides int from long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long DividedBy(this long x, int y) => x / (long)y;

        /// <summary>
        /// Divides long from long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long DividedBy(this long x, long y) => x / y;

        /// <summary>
        /// Divides sbyte from long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long DividedBy(this long x, sbyte y) => x / (long)y;

        /// <summary>
        /// Divides short from long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long DividedBy(this long x, short y) => x / (long)y;

        /// <summary>
        /// Divides uint from long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long DividedBy(this long x, uint y) => x / (long)y;

        /// <summary>
        /// Divides ulong from long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long DividedBy(this long x, ulong y) => x / (long)y;

        /// <summary>
        /// Divides ushort from long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long DividedBy(this long x, ushort y) => x / (long)y;

        /// <summary>
        /// Peeks the average value of the numbers in the array
        /// </summary>
        /// <param name="array">The array</param>
        /// <returns>The average value from the array</returns>
        public static double GetAverage(this long[] array) => array.Average();

        /// <summary>
        /// Gets the first half of the array.
        /// </summary>
        /// <param name="array">The array.</param>
        /// <returns>The <see cref="long[]"/></returns>
        public static long[] GetFirstHalf(this long[] array) => array.Take(array.Length / 2).ToArray();

        /// <summary>
        /// Gets the first number in the array
        /// </summary>
        /// <param name="array">The array <see cref="long[]"/></param>
        /// <returns>The result of the operation</returns>
        public static long GetFirstValue(this long[] array) => array[0];

        /// <summary>
        /// Gets the hightest value of the numbers in the array
        /// </summary>
        /// <param name="array">The array</param>
        /// <returns>The hightest value in the array</returns>
        public static long GetHighestValue(this long[] array) => array.Max();

        /// <summary>
        /// Gets the last half of the array.
        /// </summary>
        /// <param name="array">The array.</param>
        /// <returns>The <see cref="long[]"/></returns>
        public static long[] GetLastHalf(this long[] array) => array.Skip(array.Length / 2).Take(array.Length / 2).ToArray();

        /// <summary>
        /// Gets the last number in the array
        /// </summary>
        /// <param name="array">The array <see cref="long[]"/></param>
        /// <returns>The result of the operation</returns>
        public static long GetLastValue(this long[] array) => array[array.Length - 1];

        /// <summary>
        /// Peeks the lowest value in the array
        /// </summary>
        /// <param name="array">The array <see cref="long[]"/></param>
        /// <returns>The lowest value i the array</returns>
        public static long GetLowestValue(this long[] array) => array.Min();

        /// <summary>
        /// Gets the middle of both halves in the array.
        /// </summary>
        /// <param name="array">The array.</param>
        /// <returns>The <see cref="long[]"/></returns>
        public static long[] GetMiddle(this long[] array) => array.Skip(array.Length / 4).Take(array.Length / 2).ToArray();

        /// <summary>
        /// Gets the number in the middle of the array
        /// </summary>
        /// <param name="array">The array <see cref="long[]"/></param>
        /// <returns>The result of the operation</returns>
        public static long GetMiddleValue(this long[] array) => array[(array.Length - 1) / 2];

        /// <summary>
        /// Peeks numbers higher than given value in the array
        /// </summary>
        /// <param name="array"></param>
        /// <param name="x">The limit value</param>
        /// <returns>Returns a new array with all numbers higher than x</returns>
        public static long[] GetValuesHigherThan(this long[] array, long x) => array.Where(y => y >= x).ToArray();

        /// <summary>
        /// Peeks numbers lower than given value in the array
        /// </summary>
        /// <param name="array"></param>
        /// <param name="x">The limit value</param>
        /// <returns>Returns a new array with all numbers lower than x</returns>
        public static long[] GetValuesLowerThan(this long[] array, long x) => array.Where(y => y <= x).ToArray();

        /// <summary>
        /// Gets a boolean True if long is greater than byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this long x, byte y) => x > (long)y;

        /// <summary>
        /// Gets a boolean True if long is greater than char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this long x, char y) => x > (long)y;

        /// <summary>
        /// Gets a boolean True if long is greater than decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this long x, decimal y) => x > (long)y;

        /// <summary>
        /// Gets a boolean True if long is greater than double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this long x, double y) => x > (long)y;

        /// <summary>
        /// Gets a boolean True if long is greater than float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this long x, float y) => x > (long)y;

        /// <summary>
        /// Gets a boolean True if long is greater than int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this long x, int y) => x > (long)y;

        /// <summary>
        /// Gets a boolean True if long is greater than long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this long x, long y) => x > y;

        /// <summary>
        /// Gets a boolean True if long is greater than sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this long x, sbyte y) => x > (long)y;

        /// <summary>
        /// Gets a boolean True if long is greater than short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this long x, short y) => x > (long)y;

        /// <summary>
        /// Gets a boolean True if long is greater than uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this long x, uint y) => x > (long)y;

        /// <summary>
        /// Gets a boolean True if long is greater than ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this long x, ulong y) => x > (long)y;

        /// <summary>
        /// Gets a boolean True if long is greater than ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this long x, ushort y) => x > (long)y;

        /// <summary>
        /// Increases all values with given value.
        /// </summary>
        /// <param name="array">The array.</param>
        /// <param name="add">The value to add.</param>
        /// <returns>The <see cref="long[]"/></returns>
        public static long[] IncreaseAllValuesWith(this long[] array, long add) => array.Select(x => x + add).ToArray();

        /// <summary>
        /// Gets boolean True if byte is equal to long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this long x, byte y) => x == (long)y;

        /// <summary>
        /// Gets boolean True if char is equal to long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this long x, char y) => x == (long)y;

        /// <summary>
        /// Gets boolean True if decimal is equal to long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this long x, decimal y) => x == (long)y;

        /// <summary>
        /// Gets boolean True if double is equal to long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this long x, double y) => x == (long)y;

        /// <summary>
        /// Gets boolean True if float is equal to long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this long x, float y) => x == (long)y;

        /// <summary>
        /// Gets boolean True if int is equal to long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this long x, int y) => x == (long)y;

        /// <summary>
        /// Gets boolean True if long is equal to long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this long x, long y) => x == y;

        /// <summary>
        /// Gets boolean True if sbyte is equal to long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this long x, sbyte y) => x == (long)y;

        /// <summary>
        /// Gets boolean True if short is equal to long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this long x, short y) => x == (long)y;

        /// <summary>
        /// Gets boolean True if uint is equal to long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this long x, uint y) => x == (long)y;

        /// <summary>
        /// Gets boolean True if ulong is equal to long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this long x, ulong y) => x == (long)y;

        /// <summary>
        /// Gets boolean True if ushort is equal to long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this long x, ushort y) => x == (long)y;

        /// <summary>
        /// Gets boolean true if value is less than zero
        /// </summary>
        /// <param name="x">The x <see cref="long"/></param>
        /// <returns>The result of the operation</returns>
        public static bool IsNegative(this long x) => x < 0;

        /// <summary>
        /// Gets boolean True if byte is not equal to long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this long x, byte y) => x != (long)y;

        /// <summary>
        /// Gets boolean True if char is not equal to long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this long x, char y) => x != (long)y;

        /// <summary>
        /// Gets boolean True if decimal is not equal to long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this long x, decimal y) => x != (long)y;

        /// <summary>
        /// Gets boolean True if double is not equal to long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this long x, double y) => x != (long)y;

        /// <summary>
        /// Gets boolean True if float is not equal to long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this long x, float y) => x != (long)y;

        /// <summary>
        /// Gets boolean True if int is not equal to long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this long x, int y) => x != (long)y;

        /// <summary>
        /// Gets boolean True if long is not equal to long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this long x, long y) => x != y;

        /// <summary>
        /// Gets boolean True if sbyte is not equal to long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this long x, sbyte y) => x != (long)y;

        /// <summary>
        /// Gets boolean True if short is not equal to long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this long x, short y) => x != (long)y;

        /// <summary>
        /// Gets boolean True if uint is not equal to long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this long x, uint y) => x != (long)y;

        /// <summary>
        /// Gets boolean True if ulong is not equal to long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this long x, ulong y) => x != (long)y;

        /// <summary>
        /// Gets boolean True if ushort is not equal to long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this long x, ushort y) => x != (long)y;

        /// <summary>
        /// Gets boolean true if value is more than zero
        /// </summary>
        /// <param name="x">The x <see cref="long"/></param>
        /// <returns>The result of the operation</returns>
        public static bool IsPositive(this long x) => x >= 0;

        /// <summary>
        /// Checks if a number is prime
        /// </summary>
        /// <param name="number">The number</param>
        /// <returns>True if the number is prime</returns>
        public static bool IsPrime(this long number) => Enumerable.Range(2, (int)Math.Sqrt(number) - 1).All(divisor => number % divisor != 0);

        /// <summary>
        /// Gets a boolean True if long is less than byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this long x, byte y) => x < (long)y;

        /// <summary>
        /// Gets a boolean True if long is less than char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this long x, char y) => x < (long)y;

        /// <summary>
        /// Gets a boolean True if long is less than decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this long x, decimal y) => x < (long)y;

        /// <summary>
        /// Gets a boolean True if long is less than double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this long x, double y) => x < (long)y;

        /// <summary>
        /// Gets a boolean True if long is less than float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this long x, float y) => x < (long)y;

        /// <summary>
        /// Gets a boolean True if long is less than int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this long x, int y) => x < (long)y;

        /// <summary>
        /// Gets a boolean True if long is less than long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this long x, long y) => x < y;

        /// <summary>
        /// Gets a boolean True if long is less than sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this long x, sbyte y) => x < (long)y;

        /// <summary>
        /// Gets a boolean True if long is less than short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this long x, short y) => x < (long)y;

        /// <summary>
        /// Gets a boolean True if long is less than uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this long x, uint y) => x < (long)y;

        /// <summary>
        /// Gets a boolean True if long is less than ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this long x, ulong y) => x < (long)y;

        /// <summary>
        /// Gets a boolean True if long is less than ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this long x, ushort y) => x < (long)y;

        /// <summary>
        /// Gets the remainder of byte from long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long Modulus(this long x, byte y) => x % (long)y;

        /// <summary>
        /// Gets the remainder of char from long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long Modulus(this long x, char y) => x % (long)y;

        /// <summary>
        /// Gets the remainder of decimal from long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long Modulus(this long x, decimal y) => x % (long)y;

        /// <summary>
        /// Gets the remainder of double from long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long Modulus(this long x, double y) => x % (long)y;

        /// <summary>
        /// Gets the remainder of float from long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long Modulus(this long x, float y) => x % (long)y;

        /// <summary>
        /// Gets the remainder of int from long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long Modulus(this long x, int y) => x % (long)y;

        /// <summary>
        /// Gets the remainder of long from long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long Modulus(this long x, long y) => x % y;

        /// <summary>
        /// Gets the remainder of sbyte from long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long Modulus(this long x, sbyte y) => x % (long)y;

        /// <summary>
        /// Gets the remainder of short from long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long Modulus(this long x, short y) => x % (long)y;

        /// <summary>
        /// Gets the remainder of uint from long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long Modulus(this long x, uint y) => x % (long)y;

        /// <summary>
        /// Gets the remainder of ulong from long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long Modulus(this long x, ulong y) => x % (long)y;

        /// <summary>
        /// Gets the remainder of ushort from long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long Modulus(this long x, ushort y) => x % (long)y;

        /// <summary>
        /// Multiplies byte with long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long MultipliedWith(this long x, byte y) => x * (long)y;

        /// <summary>
        /// Multiplies char with long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long MultipliedWith(this long x, char y) => x * (long)y;

        /// <summary>
        /// Multiplies decimal with long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long MultipliedWith(this long x, decimal y) => x * (long)y;

        /// <summary>
        /// Multiplies double with long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long MultipliedWith(this long x, double y) => x * (long)y;

        /// <summary>
        /// Multiplies float with long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long MultipliedWith(this long x, float y) => x * (long)y;

        /// <summary>
        /// Multiplies int with long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long MultipliedWith(this long x, int y) => x * (long)y;

        /// <summary>
        /// Multiplies long with long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long MultipliedWith(this long x, long y) => x * y;

        /// <summary>
        /// Multiplies sbyte with long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long MultipliedWith(this long x, sbyte y) => x * (long)y;

        /// <summary>
        /// Multiplies short with long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long MultipliedWith(this long x, short y) => x * (long)y;

        /// <summary>
        /// Multiplies uint with long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long MultipliedWith(this long x, uint y) => x * (long)y;

        /// <summary>
        /// Multiplies ulong with long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long MultipliedWith(this long x, ulong y) => x * (long)y;

        /// <summary>
        /// Multiplies ushort with long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long MultipliedWith(this long x, ushort y) => x * (long)y;

        /// <summary>
        /// Gets the NOT of long
        /// </summary>
        /// <param name="x">The x <see cref="long"/></param>
        /// <returns>The result of the operation</returns>
        public static long Not(this long x) => (long)~(int)x;

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static long PercentOf(this long percent, byte value) => (long)(((long)percent) / ((long)100) * ((long)value));

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static long PercentOf(this long percent, char value) => (long)(((long)percent) / ((long)100) * ((long)value));

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static long PercentOf(this long percent, decimal value) => (long)(((long)percent) / ((long)100) * ((long)value));

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static long PercentOf(this long percent, double value) => (long)(((long)percent) / ((long)100) * ((long)value));

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static long PercentOf(this long percent, float value) => (long)(((long)percent) / ((long)100) * ((long)value));

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static long PercentOf(this long percent, int value) => (long)(((long)percent) / ((long)100) * ((long)value));

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static long PercentOf(this long percent, long value) => (long)(((long)percent) / ((long)100) * ((long)value));

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static long PercentOf(this long percent, sbyte value) => (long)(((long)percent) / ((long)100) * ((long)value));

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static long PercentOf(this long percent, short value) => (long)(((long)percent) / ((long)100) * ((long)value));

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static long PercentOf(this long percent, uint value) => (long)(((long)percent) / ((long)100) * ((long)value));

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static long PercentOf(this long percent, ulong value) => (long)(((long)percent) / ((long)100) * ((long)value));

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static long PercentOf(this long percent, ushort value) => (long)(((long)percent) / ((long)100) * ((long)value));

        /// <summary>
        /// Rotates the numbers to the left.
        /// </summary>
        /// <param name="array">The array.</param>
        /// <returns>The <see cref="long[]"/></returns>
        public static long[] RotateLeft(this long[] array)
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
        /// <returns>The <see cref="long[]"/></returns>
        public static long[] RotateRight(this long[] array)
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
        public static ref long SetHighestValueOf(this ref long first, long second, long third)
        {
            first = second > third ? second : third;
            return ref first;
        }

        /// <summary>
        /// Compare original and second number and set the variable with the lowest
        /// </summary>
        /// <param name="first">The number</param>
        /// <param name="second">The number to compare with</param>
        /// <param name="third">The third <see cref="long"/></param>
        /// <returns>Sets the variable to the lowest of the two numbers</returns>
        public static ref long SetLowestValueOf(this ref long first, long second, long third)
        {
            first = second < third ? second : third;
            return ref first;
        }

        /// <summary>
        /// Get the current size of the array
        /// </summary>
        /// <param name="array">The array <see cref="long[]"/></param>
        /// <param name="size">The size <see cref="int"/></param>
        /// <returns>The size of the array</returns>
        public static long[] SetNewArraySize(this long[] array, int size)
        {
            var newArr = new long[size];
            Array.Copy(array, 0, newArr, 0, array.Length);
            return newArr;
        }

        /// <summary>
        /// Sorts array from lowest to highest
        /// </summary>
        /// <param name="array">The array <see cref="long[]"/></param>
        /// <returns>A sorted array</returns>
        public static long[] SortArrayAsc(this long[] array) => array.OrderBy(x => x).ToArray();

        /// <summary>
        /// Sorts array from highest to lowest
        /// </summary>
        /// <param name="array">The array <see cref="long[]"/></param>
        /// <returns>A sorted array</returns>
        public static long[] SortArrayDesc(this long[] array) => array.OrderByDescending(x => x).ToArray();

        /// <summary>
        /// Subtracts byte from long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(long,byte) instead.", false)]
        public static long Substract(this long x, byte y) => x - (long)y;

        /// <summary>
        /// Subtracts char from long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(long,char) instead.", false)]
        public static long Substract(this long x, char y) => x - (long)y;

        /// <summary>
        /// Subtracts decimal from long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(long,decimal) instead.", false)]
        public static long Substract(this long x, decimal y) => x - (long)y;

        /// <summary>
        /// Subtracts double from long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(long,double) instead.", false)]
        public static long Substract(this long x, double y) => x - (long)y;

        /// <summary>
        /// Subtracts float from long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(long,float) instead.", false)]
        public static long Substract(this long x, float y) => x - (long)y;

        /// <summary>
        /// Subtracts int from long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(long,int) instead.", false)]
        public static long Substract(this long x, int y) => x - (long)y;

        /// <summary>
        /// Subtracts long from long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(long,long) instead.", false)]
        public static long Substract(this long x, long y) => x - y;

        /// <summary>
        /// Subtracts sbyte from long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(long,sbyte) instead.", false)]
        public static long Substract(this long x, sbyte y) => x - (long)y;

        /// <summary>
        /// Subtracts short from long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(long,short) instead.", false)]
        public static long Substract(this long x, short y) => x - (long)y;

        /// <summary>
        /// Subtracts uint from long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(long,uint) instead.", false)]
        public static long Substract(this long x, uint y) => x - (long)y;

        /// <summary>
        /// Subtracts ulong from long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(long,ulong) instead.", false)]
        public static long Substract(this long x, ulong y) => x - (long)y;

        /// <summary>
        /// Subtracts ushort from long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(long,ushort) instead.", false)]
        public static long Substract(this long x, ushort y) => x - (long)y;

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(byte) instead.", false)]
        public static long SubstractPercent(this long value, byte percent) => (long)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(char) instead.", false)]
        public static long SubstractPercent(this long value, char percent) => (long)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(decimal) instead.", false)]
        public static long SubstractPercent(this long value, decimal percent) => (long)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(double) instead.", false)]
        public static long SubstractPercent(this long value, double percent) => (long)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(float) instead.", false)]
        public static long SubstractPercent(this long value, float percent) => (long)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(int) instead.", false)]
        public static long SubstractPercent(this long value, int percent) => (long)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(long) instead.", false)]
        public static long SubstractPercent(this long value, long percent) => (long)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(sbyte) instead.", false)]
        public static long SubstractPercent(this long value, sbyte percent) => (long)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(short) instead.", false)]
        public static long SubstractPercent(this long value, short percent) => (long)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(uint) instead.", false)]
        public static long SubstractPercent(this long value, uint percent) => (long)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(ulong) instead.", false)]
        public static long SubstractPercent(this long value, ulong percent) => (long)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(ushort) instead.", false)]
        public static long SubstractPercent(this long value, ushort percent) => (long)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts byte from long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long Subtract(this long x, byte y) => x - (long)y;

        /// <summary>
        /// Subtracts char from long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long Subtract(this long x, char y) => x - (long)y;

        /// <summary>
        /// Subtracts decimal from long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long Subtract(this long x, decimal y) => x - (long)y;

        /// <summary>
        /// Subtracts double from long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long Subtract(this long x, double y) => x - (long)y;

        /// <summary>
        /// Subtracts float from long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long Subtract(this long x, float y) => x - (long)y;

        /// <summary>
        /// Subtracts int from long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long Subtract(this long x, int y) => x - (long)y;

        /// <summary>
        /// Subtracts long from long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long Subtract(this long x, long y) => x - y;

        /// <summary>
        /// Subtracts sbyte from long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long Subtract(this long x, sbyte y) => x - (long)y;

        /// <summary>
        /// Subtracts short from long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long Subtract(this long x, short y) => x - (long)y;

        /// <summary>
        /// Subtracts uint from long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long Subtract(this long x, uint y) => x - (long)y;

        /// <summary>
        /// Subtracts ulong from long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long Subtract(this long x, ulong y) => x - (long)y;

        /// <summary>
        /// Subtracts ushort from long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long Subtract(this long x, ushort y) => x - (long)y;

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static long SubtractPercent(this long value, byte percent) => (long)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static long SubtractPercent(this long value, char percent) => (long)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static long SubtractPercent(this long value, decimal percent) => (long)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static long SubtractPercent(this long value, double percent) => (long)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static long SubtractPercent(this long value, float percent) => (long)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static long SubtractPercent(this long value, int percent) => (long)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static long SubtractPercent(this long value, long percent) => (long)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static long SubtractPercent(this long value, sbyte percent) => (long)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static long SubtractPercent(this long value, short percent) => (long)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static long SubtractPercent(this long value, uint percent) => (long)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static long SubtractPercent(this long value, ulong percent) => (long)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static long SubtractPercent(this long value, ushort percent) => (long)(value - value.PercentOf(percent));

        /// <summary>
        /// Sums all numbers in the array
        /// </summary>
        /// <param name="array">The array <see cref="long[]"/></param>
        /// <returns>A sum of all the numbers in the array</returns>
        public static long SumAllValues(this long[] array) => array.Sum();

        /// <summary>
        /// Swaps two variables
        /// </summary>
        /// <param name="first">The main variable</param>
        /// <param name="second">The variable to switch with</param>
        /// <returns>
        /// The value from the second variable and sets second variable to original value
        /// </returns>
        public static ref long SwapWith(this ref long first, ref long second)
        {
            var tmp = second;
            second = first;
            first = tmp;
            return ref first;
        }

        /// <summary>
        /// Gets XOR of byte of long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long Xor(this long x, byte y) => x ^ (long)y;

        /// <summary>
        /// Gets XOR of char of long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long Xor(this long x, char y) => x ^ (long)y;

        /// <summary>
        /// Gets XOR of decimal of long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long Xor(this long x, decimal y) => x ^ (long)y;

        /// <summary>
        /// Gets XOR of double of long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long Xor(this long x, double y) => x ^ (long)y;

        /// <summary>
        /// Gets XOR of float of long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long Xor(this long x, float y) => x ^ (long)y;

        /// <summary>
        /// Gets XOR of int of long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long Xor(this long x, int y) => x ^ (long)y;

        /// <summary>
        /// Gets XOR of long of long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long Xor(this long x, long y) => x ^ y;

        /// <summary>
        /// Gets XOR of sbyte of long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long Xor(this long x, sbyte y) => x ^ (long)y;

        /// <summary>
        /// Gets XOR of short of long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long Xor(this long x, short y) => x ^ (long)y;

        /// <summary>
        /// Gets XOR of uint of long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long Xor(this long x, uint y) => x ^ (long)y;

        /// <summary>
        /// Gets XOR of ulong of long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long Xor(this long x, ulong y) => x ^ (long)y;

        /// <summary>
        /// Gets XOR of ushort of long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static long Xor(this long x, ushort y) => x ^ (long)y;
    }
}
