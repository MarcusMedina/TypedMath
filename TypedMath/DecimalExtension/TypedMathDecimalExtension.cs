// ----------------------------------------------------------------------------------------------
// <copyright file="TypedMathDecimalExtension.cs" company="MarcusMedinaPro">
//     By Marcus Medina, 2019 - http://MarcusMedina.Pro This file is subject to the terms and
//     conditions defined in file 'license.txt', which is part of this project.
// </copyright>
// ----------------------------------------------------------------------------------------------
// Credits for borrowed code: LinQ Primenumbers, Zoran Horvat, at
// http://www.codinghelmet.com/articles/linq-all-primes/ Increase/Decrease array values, mgp -
// https://stackoverflow.com/users/55943/mqp, at https://stackoverflow.com/a/823537 ----------------------------------------------------------------------------------------------

namespace MarcusMedinaPro.TypedMath.DecimalExtension
{
    using System;
    using System.Linq;

    /// <summary>
    /// Extension for decimal
    /// </summary>
    public static class TypedMathDecimalExtension
    {
        /// <summary>
        /// Adds byte to decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal Add(this decimal x, byte y) => x + (decimal)y;

        /// <summary>
        /// Adds char to decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal Add(this decimal x, char y) => x + (decimal)y;

        /// <summary>
        /// Adds decimal to decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal Add(this decimal x, decimal y) => x + y;

        /// <summary>
        /// Adds double to decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal Add(this decimal x, double y) => x + (decimal)y;

        /// <summary>
        /// Adds float to decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal Add(this decimal x, float y) => x + (decimal)y;

        /// <summary>
        /// Adds int to decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal Add(this decimal x, int y) => x + (decimal)y;

        /// <summary>
        /// Adds long to decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal Add(this decimal x, long y) => x + (decimal)y;

        /// <summary>
        /// Adds sbyte to decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal Add(this decimal x, sbyte y) => x + (decimal)y;

        /// <summary>
        /// Adds short to decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal Add(this decimal x, short y) => x + (decimal)y;

        /// <summary>
        /// Adds uint to decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal Add(this decimal x, uint y) => x + (decimal)y;

        /// <summary>
        /// Adds ulong to decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal Add(this decimal x, ulong y) => x + (decimal)y;

        /// <summary>
        /// Adds ushort to decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal Add(this decimal x, ushort y) => x + (decimal)y;

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static decimal AddPercent(this decimal value, byte percent) => (decimal)(value + value.PercentOf(percent));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static decimal AddPercent(this decimal value, char percent) => (decimal)(value + value.PercentOf(percent));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static decimal AddPercent(this decimal value, decimal percent) => (decimal)(value + value.PercentOf(percent));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static decimal AddPercent(this decimal value, double percent) => (decimal)(value + value.PercentOf(percent));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static decimal AddPercent(this decimal value, float percent) => (decimal)(value + value.PercentOf(percent));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static decimal AddPercent(this decimal value, int percent) => (decimal)(value + value.PercentOf(percent));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static decimal AddPercent(this decimal value, long percent) => (decimal)(value + value.PercentOf(percent));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static decimal AddPercent(this decimal value, sbyte percent) => (decimal)(value + value.PercentOf(percent));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static decimal AddPercent(this decimal value, short percent) => (decimal)(value + value.PercentOf(percent));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static decimal AddPercent(this decimal value, uint percent) => (decimal)(value + value.PercentOf(percent));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static decimal AddPercent(this decimal value, ulong percent) => (decimal)(value + value.PercentOf(percent));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static decimal AddPercent(this decimal value, ushort percent) => (decimal)(value + value.PercentOf(percent));

        /// <summary>
        /// Tries to cast decimal to byte, this can get ugly though
        /// </summary>
        /// <param name="x">The x <see cref="decimal"/></param>
        /// <returns>The result of the operation</returns>
        public static byte CastDecimalToByte(this decimal x) => (byte)x;

        /// <summary>
        /// Tries to cast decimal to char, this can get ugly though
        /// </summary>
        /// <param name="x">The x <see cref="decimal"/></param>
        /// <returns>The result of the operation</returns>
        public static char CastDecimalToChar(this decimal x) => (char)x;

        /// <summary>
        /// Tries to cast decimal to double, this can get ugly though
        /// </summary>
        /// <param name="x">The x <see cref="decimal"/></param>
        /// <returns>The result of the operation</returns>
        public static double CastDecimalToDouble(this decimal x) => (double)x;

        /// <summary>
        /// Tries to cast decimal to float, this can get ugly though
        /// </summary>
        /// <param name="x">The x <see cref="decimal"/></param>
        /// <returns>The result of the operation</returns>
        public static float CastDecimalToFloat(this decimal x) => (float)x;

        /// <summary>
        /// Tries to cast decimal to int, this can get ugly though
        /// </summary>
        /// <param name="x">The x <see cref="decimal"/></param>
        /// <returns>The result of the operation</returns>
        public static int CastDecimalToInt(this decimal x) => (int)x;

        /// <summary>
        /// Tries to cast decimal to long, this can get ugly though
        /// </summary>
        /// <param name="x">The x <see cref="decimal"/></param>
        /// <returns>The result of the operation</returns>
        public static long CastDecimalToLong(this decimal x) => (long)x;

        /// <summary>
        /// Tries to cast decimal to sbyte, this can get ugly though
        /// </summary>
        /// <param name="x">The x <see cref="decimal"/></param>
        /// <returns>The result of the operation</returns>
        public static sbyte CastDecimalToSbyte(this decimal x) => (sbyte)x;

        /// <summary>
        /// Tries to cast decimal to short, this can get ugly though
        /// </summary>
        /// <param name="x">The x <see cref="decimal"/></param>
        /// <returns>The result of the operation</returns>
        public static short CastDecimalToShort(this decimal x) => (short)x;

        /// <summary>
        /// Tries to cast decimal to uint, this can get ugly though
        /// </summary>
        /// <param name="x">The x <see cref="decimal"/></param>
        /// <returns>The result of the operation</returns>
        public static uint CastDecimalToUint(this decimal x) => (uint)x;

        /// <summary>
        /// Tries to cast decimal to ulong, this can get ugly though
        /// </summary>
        /// <param name="x">The x <see cref="decimal"/></param>
        /// <returns>The result of the operation</returns>
        public static ulong CastDecimalToUlong(this decimal x) => (ulong)x;

        /// <summary>
        /// Tries to cast decimal to ushort, this can get ugly though
        /// </summary>
        /// <param name="x">The x <see cref="decimal"/></param>
        /// <returns>The result of the operation</returns>
        public static ushort CastDecimalToUshort(this decimal x) => (ushort)x;

        /// <summary>
        /// Compare original and second number
        /// </summary>
        /// <param name="first">The number</param>
        /// <param name="second">The number to compare with</param>
        /// <returns>The highest of the two numbers</returns>
        public static decimal ChooseIfHigher(this decimal first, decimal second) => first > second ? first : second;

        /// <summary>
        /// Compare original and second number
        /// </summary>
        /// <param name="first">The number</param>
        /// <param name="second">The number to compare with</param>
        /// <returns>The lowest of the two numbers</returns>
        public static decimal ChooseIfLower(this decimal first, decimal second) => first < second ? first : second;

        /// <summary>
        /// Converts the array to int.
        /// </summary>
        /// <param name="array">The array.</param>
        /// <returns>The <see cref="int[]"/></returns>
        public static int[] ConvertArrayToInt(this decimal[] array) => array.Select(x => (int)x).ToArray();

        /// <summary>
        /// Decreases all values with given value.
        /// </summary>
        /// <param name="array">The array.</param>
        /// <param name="dec">The value to add.</param>
        /// <returns>The <see cref="decimal[]"/></returns>
        public static decimal[] DecreaseAllValuesWith(this decimal[] array, decimal dec) => array.Select(x => x - dec).ToArray();

        /// <summary>
        /// Gets the differnce between two numbers
        /// </summary>
        /// <param name="original">The original.</param>
        /// <param name="compareTo">The compare to.</param>
        /// <returns></returns>
        public static decimal DiferenceFrom(this decimal original, decimal compareTo) => original > compareTo ? original - compareTo : original < compareTo ? compareTo - original : 0;

        /// <summary>
        /// Divides byte from decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal DividedBy(this decimal x, byte y) => x / (decimal)y;

        /// <summary>
        /// Divides char from decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal DividedBy(this decimal x, char y) => x / (decimal)y;

        /// <summary>
        /// Divides decimal from decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal DividedBy(this decimal x, decimal y) => x / y;

        /// <summary>
        /// Divides double from decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal DividedBy(this decimal x, double y) => x / (decimal)y;

        /// <summary>
        /// Divides float from decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal DividedBy(this decimal x, float y) => x / (decimal)y;

        /// <summary>
        /// Divides int from decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal DividedBy(this decimal x, int y) => x / (decimal)y;

        /// <summary>
        /// Divides long from decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal DividedBy(this decimal x, long y) => x / (decimal)y;

        /// <summary>
        /// Divides sbyte from decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal DividedBy(this decimal x, sbyte y) => x / (decimal)y;

        /// <summary>
        /// Divides short from decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal DividedBy(this decimal x, short y) => x / (decimal)y;

        /// <summary>
        /// Divides uint from decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal DividedBy(this decimal x, uint y) => x / (decimal)y;

        /// <summary>
        /// Divides ulong from decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal DividedBy(this decimal x, ulong y) => x / (decimal)y;

        /// <summary>
        /// Divides ushort from decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal DividedBy(this decimal x, ushort y) => x / (decimal)y;

        /// <summary>
        /// Peeks the average value of the numbers in the array
        /// </summary>
        /// <param name="array">The array</param>
        /// <returns>The average value from the array</returns>
        public static decimal GetAverage(this decimal[] array) => array.Average();

        /// <summary>
        /// Gets the first half of the array.
        /// </summary>
        /// <param name="array">The array.</param>
        /// <returns>The <see cref="decimal[]"/></returns>
        public static decimal[] GetFirstHalf(this decimal[] array) => array.Take(array.Length / 2).ToArray();

        /// <summary>
        /// Gets the first number in the array
        /// </summary>
        /// <param name="array">The array <see cref="decimal[]"/></param>
        /// <returns>The result of the operation</returns>
        public static decimal GetFirstValue(this decimal[] array) => array[0];

        /// <summary>
        /// Gets the hightest value of the numbers in the array
        /// </summary>
        /// <param name="array">The array</param>
        /// <returns>The hightest value in the array</returns>
        public static decimal GetHighestValue(this decimal[] array) => array.Max();

        /// <summary>
        /// Gets the last half of the array.
        /// </summary>
        /// <param name="array">The array.</param>
        /// <returns>The <see cref="decimal[]"/></returns>
        public static decimal[] GetLastHalf(this decimal[] array) => array.Skip(array.Length / 2).Take(array.Length / 2).ToArray();

        /// <summary>
        /// Gets the last number in the array
        /// </summary>
        /// <param name="array">The array <see cref="decimal[]"/></param>
        /// <returns>The result of the operation</returns>
        public static decimal GetLastValue(this decimal[] array) => array[array.Length - 1];

        /// <summary>
        /// Peeks the lowest value in the array
        /// </summary>
        /// <param name="array">The array <see cref="decimal[]"/></param>
        /// <returns>The lowest value i the array</returns>
        public static decimal GetLowestValue(this decimal[] array) => array.Min();

        /// <summary>
        /// Gets the middle of both halves in the array.
        /// </summary>
        /// <param name="array">The array.</param>
        /// <returns>The <see cref="decimal[]"/></returns>
        public static decimal[] GetMiddle(this decimal[] array) => array.Skip(array.Length / 4).Take(array.Length / 2).ToArray();

        /// <summary>
        /// Gets the number in the middle of the array
        /// </summary>
        /// <param name="array">The array <see cref="decimal[]"/></param>
        /// <returns>The result of the operation</returns>
        public static decimal GetMiddleValue(this decimal[] array) => array[(array.Length - 1) / 2];

        /// <summary>
        /// Peeks numbers higher than given value in the array
        /// </summary>
        /// <param name="array"></param>
        /// <param name="x">The limit value</param>
        /// <returns>Returns a new array with all numbers higher than x</returns>
        public static decimal[] GetValuesHigherThan(this decimal[] array, decimal x) => array.Where(y => y >= x).ToArray();

        /// <summary>
        /// Peeks numbers lower than given value in the array
        /// </summary>
        /// <param name="array"></param>
        /// <param name="x">The limit value</param>
        /// <returns>Returns a new array with all numbers lower than x</returns>
        public static decimal[] GetValuesLowerThan(this decimal[] array, decimal x) => array.Where(y => y <= x).ToArray();

        /// <summary>
        /// Gets a boolean True if decimal is greater than byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this decimal x, byte y) => x > (decimal)y;

        /// <summary>
        /// Gets a boolean True if decimal is greater than char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this decimal x, char y) => x > (decimal)y;

        /// <summary>
        /// Gets a boolean True if decimal is greater than decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this decimal x, decimal y) => x > y;

        /// <summary>
        /// Gets a boolean True if decimal is greater than double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this decimal x, double y) => x > (decimal)y;

        /// <summary>
        /// Gets a boolean True if decimal is greater than float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this decimal x, float y) => x > (decimal)y;

        /// <summary>
        /// Gets a boolean True if decimal is greater than int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this decimal x, int y) => x > (decimal)y;

        /// <summary>
        /// Gets a boolean True if decimal is greater than long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this decimal x, long y) => x > (decimal)y;

        /// <summary>
        /// Gets a boolean True if decimal is greater than sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this decimal x, sbyte y) => x > (decimal)y;

        /// <summary>
        /// Gets a boolean True if decimal is greater than short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this decimal x, short y) => x > (decimal)y;

        /// <summary>
        /// Gets a boolean True if decimal is greater than uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this decimal x, uint y) => x > (decimal)y;

        /// <summary>
        /// Gets a boolean True if decimal is greater than ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this decimal x, ulong y) => x > (decimal)y;

        /// <summary>
        /// Gets a boolean True if decimal is greater than ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this decimal x, ushort y) => x > (decimal)y;

        /// <summary>
        /// Increases all values with given value.
        /// </summary>
        /// <param name="array">The array.</param>
        /// <param name="add">The value to add.</param>
        /// <returns>The <see cref="decimal[]"/></returns>
        public static decimal[] IncreaseAllValuesWith(this decimal[] array, decimal add) => array.Select(x => x + add).ToArray();

        /// <summary>
        /// Gets boolean True if byte is equal to decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this decimal x, byte y) => x == (decimal)y;

        /// <summary>
        /// Gets boolean True if char is equal to decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this decimal x, char y) => x == (decimal)y;

        /// <summary>
        /// Gets boolean True if decimal is equal to decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this decimal x, decimal y) => x == y;

        /// <summary>
        /// Gets boolean True if double is equal to decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this decimal x, double y) => x == (decimal)y;

        /// <summary>
        /// Gets boolean True if float is equal to decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this decimal x, float y) => x == (decimal)y;

        /// <summary>
        /// Gets boolean True if int is equal to decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this decimal x, int y) => x == (decimal)y;

        /// <summary>
        /// Gets boolean True if long is equal to decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this decimal x, long y) => x == (decimal)y;

        /// <summary>
        /// Gets boolean True if sbyte is equal to decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this decimal x, sbyte y) => x == (decimal)y;

        /// <summary>
        /// Gets boolean True if short is equal to decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this decimal x, short y) => x == (decimal)y;

        /// <summary>
        /// Gets boolean True if uint is equal to decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this decimal x, uint y) => x == (decimal)y;

        /// <summary>
        /// Gets boolean True if ulong is equal to decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this decimal x, ulong y) => x == (decimal)y;

        /// <summary>
        /// Gets boolean True if ushort is equal to decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this decimal x, ushort y) => x == (decimal)y;

        /// <summary>
        /// Gets boolean true if value is less than zero
        /// </summary>
        /// <param name="x">The x <see cref="decimal"/></param>
        /// <returns>The result of the operation</returns>
        public static bool IsNegative(this decimal x) => x < 0;

        /// <summary>
        /// Gets boolean True if byte is not equal to decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this decimal x, byte y) => x != (decimal)y;

        /// <summary>
        /// Gets boolean True if char is not equal to decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this decimal x, char y) => x != (decimal)y;

        /// <summary>
        /// Gets boolean True if decimal is not equal to decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this decimal x, decimal y) => x != y;

        /// <summary>
        /// Gets boolean True if double is not equal to decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this decimal x, double y) => x != (decimal)y;

        /// <summary>
        /// Gets boolean True if float is not equal to decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this decimal x, float y) => x != (decimal)y;

        /// <summary>
        /// Gets boolean True if int is not equal to decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this decimal x, int y) => x != (decimal)y;

        /// <summary>
        /// Gets boolean True if long is not equal to decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this decimal x, long y) => x != (decimal)y;

        /// <summary>
        /// Gets boolean True if sbyte is not equal to decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this decimal x, sbyte y) => x != (decimal)y;

        /// <summary>
        /// Gets boolean True if short is not equal to decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this decimal x, short y) => x != (decimal)y;

        /// <summary>
        /// Gets boolean True if uint is not equal to decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this decimal x, uint y) => x != (decimal)y;

        /// <summary>
        /// Gets boolean True if ulong is not equal to decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this decimal x, ulong y) => x != (decimal)y;

        /// <summary>
        /// Gets boolean True if ushort is not equal to decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this decimal x, ushort y) => x != (decimal)y;

        /// <summary>
        /// Gets boolean true if value is more than zero
        /// </summary>
        /// <param name="x">The x <see cref="decimal"/></param>
        /// <returns>The result of the operation</returns>
        public static bool IsPositive(this decimal x) => x >= 0;

        /// <summary>
        /// Gets a boolean True if decimal is less than byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this decimal x, byte y) => x < (decimal)y;

        /// <summary>
        /// Gets a boolean True if decimal is less than char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this decimal x, char y) => x < (decimal)y;

        /// <summary>
        /// Gets a boolean True if decimal is less than decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this decimal x, decimal y) => x < y;

        /// <summary>
        /// Gets a boolean True if decimal is less than double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this decimal x, double y) => x < (decimal)y;

        /// <summary>
        /// Gets a boolean True if decimal is less than float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this decimal x, float y) => x < (decimal)y;

        /// <summary>
        /// Gets a boolean True if decimal is less than int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this decimal x, int y) => x < (decimal)y;

        /// <summary>
        /// Gets a boolean True if decimal is less than long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this decimal x, long y) => x < (decimal)y;

        /// <summary>
        /// Gets a boolean True if decimal is less than sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this decimal x, sbyte y) => x < (decimal)y;

        /// <summary>
        /// Gets a boolean True if decimal is less than short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this decimal x, short y) => x < (decimal)y;

        /// <summary>
        /// Gets a boolean True if decimal is less than uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this decimal x, uint y) => x < (decimal)y;

        /// <summary>
        /// Gets a boolean True if decimal is less than ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this decimal x, ulong y) => x < (decimal)y;

        /// <summary>
        /// Gets a boolean True if decimal is less than ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this decimal x, ushort y) => x < (decimal)y;

        /// <summary>
        /// Gets the remainder of byte from decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal Modulus(this decimal x, byte y) => x % (decimal)y;

        /// <summary>
        /// Gets the remainder of char from decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal Modulus(this decimal x, char y) => x % (decimal)y;

        /// <summary>
        /// Gets the remainder of decimal from decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal Modulus(this decimal x, decimal y) => x % y;

        /// <summary>
        /// Gets the remainder of double from decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal Modulus(this decimal x, double y) => x % (decimal)y;

        /// <summary>
        /// Gets the remainder of float from decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal Modulus(this decimal x, float y) => x % (decimal)y;

        /// <summary>
        /// Gets the remainder of int from decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal Modulus(this decimal x, int y) => x % (decimal)y;

        /// <summary>
        /// Gets the remainder of long from decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal Modulus(this decimal x, long y) => x % (decimal)y;

        /// <summary>
        /// Gets the remainder of sbyte from decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal Modulus(this decimal x, sbyte y) => x % (decimal)y;

        /// <summary>
        /// Gets the remainder of short from decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal Modulus(this decimal x, short y) => x % (decimal)y;

        /// <summary>
        /// Gets the remainder of uint from decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal Modulus(this decimal x, uint y) => x % (decimal)y;

        /// <summary>
        /// Gets the remainder of ulong from decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal Modulus(this decimal x, ulong y) => x % (decimal)y;

        /// <summary>
        /// Gets the remainder of ushort from decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal Modulus(this decimal x, ushort y) => x % (decimal)y;

        /// <summary>
        /// Multiplies byte with decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal MultipliedWith(this decimal x, byte y) => x * (decimal)y;

        /// <summary>
        /// Multiplies char with decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal MultipliedWith(this decimal x, char y) => x * (decimal)y;

        /// <summary>
        /// Multiplies decimal with decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal MultipliedWith(this decimal x, decimal y) => x * y;

        /// <summary>
        /// Multiplies double with decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal MultipliedWith(this decimal x, double y) => x * (decimal)y;

        /// <summary>
        /// Multiplies float with decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal MultipliedWith(this decimal x, float y) => x * (decimal)y;

        /// <summary>
        /// Multiplies int with decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal MultipliedWith(this decimal x, int y) => x * (decimal)y;

        /// <summary>
        /// Multiplies long with decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal MultipliedWith(this decimal x, long y) => x * (decimal)y;

        /// <summary>
        /// Multiplies sbyte with decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal MultipliedWith(this decimal x, sbyte y) => x * (decimal)y;

        /// <summary>
        /// Multiplies short with decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal MultipliedWith(this decimal x, short y) => x * (decimal)y;

        /// <summary>
        /// Multiplies uint with decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal MultipliedWith(this decimal x, uint y) => x * (decimal)y;

        /// <summary>
        /// Multiplies ulong with decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal MultipliedWith(this decimal x, ulong y) => x * (decimal)y;

        /// <summary>
        /// Multiplies ushort with decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal MultipliedWith(this decimal x, ushort y) => x * (decimal)y;

        /// <summary>
        /// Gets the NOT of decimal
        /// </summary>
        /// <param name="x">The x <see cref="decimal"/></param>
        /// <returns>The result of the operation</returns>
        public static decimal Not(this decimal x) => (decimal)~(int)x;

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static decimal PercentOf(this decimal percent, byte value) => (decimal)(((decimal)percent) / ((decimal)100) * ((decimal)value));

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static decimal PercentOf(this decimal percent, char value) => (decimal)(((decimal)percent) / ((decimal)100) * ((decimal)value));

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static decimal PercentOf(this decimal percent, decimal value) => (decimal)(((decimal)percent) / ((decimal)100) * ((decimal)value));

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static decimal PercentOf(this decimal percent, double value) => (decimal)(((decimal)percent) / ((decimal)100) * ((decimal)value));

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static decimal PercentOf(this decimal percent, float value) => (decimal)(((decimal)percent) / ((decimal)100) * ((decimal)value));

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static decimal PercentOf(this decimal percent, int value) => (decimal)(((decimal)percent) / ((decimal)100) * ((decimal)value));

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static decimal PercentOf(this decimal percent, long value) => (decimal)(((decimal)percent) / ((decimal)100) * ((decimal)value));

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static decimal PercentOf(this decimal percent, sbyte value) => (decimal)(((decimal)percent) / ((decimal)100) * ((decimal)value));

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static decimal PercentOf(this decimal percent, short value) => (decimal)(((decimal)percent) / ((decimal)100) * ((decimal)value));

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static decimal PercentOf(this decimal percent, uint value) => (decimal)(((decimal)percent) / ((decimal)100) * ((decimal)value));

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static decimal PercentOf(this decimal percent, ulong value) => (decimal)(((decimal)percent) / ((decimal)100) * ((decimal)value));

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static decimal PercentOf(this decimal percent, ushort value) => (decimal)(((decimal)percent) / ((decimal)100) * ((decimal)value));

        /// <summary>
        /// Rotates the numbers to the left.
        /// </summary>
        /// <param name="array">The array.</param>
        /// <returns>The <see cref="decimal[]"/></returns>
        public static decimal[] RotateLeft(this decimal[] array)
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
        /// <returns>The <see cref="decimal[]"/></returns>
        public static decimal[] RotateRight(this decimal[] array)
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
        public static ref decimal SetHighestValueOf(this ref decimal first, decimal second, decimal third)
        {
            first = second > third ? second : third;
            return ref first;
        }

        /// <summary>
        /// Compare original and second number and set the variable with the lowest
        /// </summary>
        /// <param name="first">The number</param>
        /// <param name="second">The number to compare with</param>
        /// <param name="third">The third <see cref="decimal"/></param>
        /// <returns>Sets the variable to the lowest of the two numbers</returns>
        public static ref decimal SetLowestValueOf(this ref decimal first, decimal second, decimal third)
        {
            first = second < third ? second : third;
            return ref first;
        }

        /// <summary>
        /// Get the current size of the array
        /// </summary>
        /// <param name="array">The array <see cref="decimal[]"/></param>
        /// <param name="size">The size <see cref="int"/></param>
        /// <returns>The size of the array</returns>
        public static decimal[] SetNewArraySize(this decimal[] array, int size)
        {
            var newArr = new decimal[size];
            Array.Copy(array, 0, newArr, 0, array.Length);
            return newArr;
        }

        /// <summary>
        /// Sorts array from lowest to highest
        /// </summary>
        /// <param name="array">The array <see cref="decimal[]"/></param>
        /// <returns>A sorted array</returns>
        public static decimal[] SortArrayAsc(this decimal[] array) => array.OrderBy(x => x).ToArray();

        /// <summary>
        /// Sorts array from highest to lowest
        /// </summary>
        /// <param name="array">The array <see cref="decimal[]"/></param>
        /// <returns>A sorted array</returns>
        public static decimal[] SortArrayDesc(this decimal[] array) => array.OrderByDescending(x => x).ToArray();

        /// <summary>
        /// Subtracts byte from decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(decimal,byte) instead.", false)]
        public static decimal Substract(this decimal x, byte y) => x - (decimal)y;

        /// <summary>
        /// Subtracts char from decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(decimal,char) instead.", false)]
        public static decimal Substract(this decimal x, char y) => x - (decimal)y;

        /// <summary>
        /// Subtracts decimal from decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(decimal,decimal) instead.", false)]
        public static decimal Substract(this decimal x, decimal y) => x - y;

        /// <summary>
        /// Subtracts double from decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(decimal,double) instead.", false)]
        public static decimal Substract(this decimal x, double y) => x - (decimal)y;

        /// <summary>
        /// Subtracts float from decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(decimal,float) instead.", false)]
        public static decimal Substract(this decimal x, float y) => x - (decimal)y;

        /// <summary>
        /// Subtracts int from decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(decimal,int) instead.", false)]
        public static decimal Substract(this decimal x, int y) => x - (decimal)y;

        /// <summary>
        /// Subtracts long from decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(decimal,long) instead.", false)]
        public static decimal Substract(this decimal x, long y) => x - (decimal)y;

        /// <summary>
        /// Subtracts sbyte from decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(decimal,sbyte) instead.", false)]
        public static decimal Substract(this decimal x, sbyte y) => x - (decimal)y;

        /// <summary>
        /// Subtracts short from decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(decimal,short) instead.", false)]
        public static decimal Substract(this decimal x, short y) => x - (decimal)y;

        /// <summary>
        /// Subtracts uint from decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(decimal,uint) instead.", false)]
        public static decimal Substract(this decimal x, uint y) => x - (decimal)y;

        /// <summary>
        /// Subtracts ulong from decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(decimal,ulong) instead.", false)]
        public static decimal Substract(this decimal x, ulong y) => x - (decimal)y;

        /// <summary>
        /// Subtracts ushort from decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(decimal,ushort) instead.", false)]
        public static decimal Substract(this decimal x, ushort y) => x - (decimal)y;

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(byte) instead.", false)]
        public static decimal SubstractPercent(this decimal value, byte percent) => (decimal)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(char) instead.", false)]
        public static decimal SubstractPercent(this decimal value, char percent) => (decimal)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(decimal) instead.", false)]
        public static decimal SubstractPercent(this decimal value, decimal percent) => (decimal)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(double) instead.", false)]
        public static decimal SubstractPercent(this decimal value, double percent) => (decimal)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(float) instead.", false)]
        public static decimal SubstractPercent(this decimal value, float percent) => (decimal)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(int) instead.", false)]
        public static decimal SubstractPercent(this decimal value, int percent) => (decimal)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(long) instead.", false)]
        public static decimal SubstractPercent(this decimal value, long percent) => (decimal)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(sbyte) instead.", false)]
        public static decimal SubstractPercent(this decimal value, sbyte percent) => (decimal)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(short) instead.", false)]
        public static decimal SubstractPercent(this decimal value, short percent) => (decimal)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(uint) instead.", false)]
        public static decimal SubstractPercent(this decimal value, uint percent) => (decimal)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(ulong) instead.", false)]
        public static decimal SubstractPercent(this decimal value, ulong percent) => (decimal)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(ushort) instead.", false)]
        public static decimal SubstractPercent(this decimal value, ushort percent) => (decimal)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts byte from decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal Subtract(this decimal x, byte y) => x - (decimal)y;

        /// <summary>
        /// Subtracts char from decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal Subtract(this decimal x, char y) => x - (decimal)y;

        /// <summary>
        /// Subtracts decimal from decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal Subtract(this decimal x, decimal y) => x - y;

        /// <summary>
        /// Subtracts double from decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal Subtract(this decimal x, double y) => x - (decimal)y;

        /// <summary>
        /// Subtracts float from decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal Subtract(this decimal x, float y) => x - (decimal)y;

        /// <summary>
        /// Subtracts int from decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal Subtract(this decimal x, int y) => x - (decimal)y;

        /// <summary>
        /// Subtracts long from decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal Subtract(this decimal x, long y) => x - (decimal)y;

        /// <summary>
        /// Subtracts sbyte from decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal Subtract(this decimal x, sbyte y) => x - (decimal)y;

        /// <summary>
        /// Subtracts short from decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal Subtract(this decimal x, short y) => x - (decimal)y;

        /// <summary>
        /// Subtracts uint from decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal Subtract(this decimal x, uint y) => x - (decimal)y;

        /// <summary>
        /// Subtracts ulong from decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal Subtract(this decimal x, ulong y) => x - (decimal)y;

        /// <summary>
        /// Subtracts ushort from decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal Subtract(this decimal x, ushort y) => x - (decimal)y;

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static decimal SubtractPercent(this decimal value, byte percent) => (decimal)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static decimal SubtractPercent(this decimal value, char percent) => (decimal)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static decimal SubtractPercent(this decimal value, decimal percent) => (decimal)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static decimal SubtractPercent(this decimal value, double percent) => (decimal)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static decimal SubtractPercent(this decimal value, float percent) => (decimal)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static decimal SubtractPercent(this decimal value, int percent) => (decimal)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static decimal SubtractPercent(this decimal value, long percent) => (decimal)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static decimal SubtractPercent(this decimal value, sbyte percent) => (decimal)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static decimal SubtractPercent(this decimal value, short percent) => (decimal)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static decimal SubtractPercent(this decimal value, uint percent) => (decimal)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static decimal SubtractPercent(this decimal value, ulong percent) => (decimal)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static decimal SubtractPercent(this decimal value, ushort percent) => (decimal)(value - value.PercentOf(percent));

        /// <summary>
        /// Sums all numbers in the array
        /// </summary>
        /// <param name="array">The array <see cref="decimal[]"/></param>
        /// <returns>A sum of all the numbers in the array</returns>
        public static decimal SumAllValues(this decimal[] array) => array.Sum();

        /// <summary>
        /// Swaps two variables
        /// </summary>
        /// <param name="first">The main variable</param>
        /// <param name="second">The variable to switch with</param>
        /// <returns>
        /// The value from the second variable and sets second variable to original value
        /// </returns>
        public static ref decimal SwapWith(this ref decimal first, ref decimal second)
        {
            var tmp = second;
            second = first;
            first = tmp;
            return ref first;
        }
    }
}