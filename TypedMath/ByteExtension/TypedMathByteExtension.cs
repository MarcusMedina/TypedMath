// ----------------------------------------------------------------------------------------------
// <copyright file="TypedMathByteExtension.cs" company="MarcusMedinaPro">
//     By Marcus Medina, 2019 - http://MarcusMedina.Pro This file is subject to the terms and
//     conditions defined in file 'license.txt', which is part of this project.
// </copyright>
// ----------------------------------------------------------------------------------------------
// Credits for borrowed code: LinQ Primenumbers, Zoran Horvat, at
// http://www.codinghelmet.com/articles/linq-all-primes/ Increase/Decrease array values, mgp -
// https://stackoverflow.com/users/55943/mqp, at https://stackoverflow.com/a/823537 ----------------------------------------------------------------------------------------------

namespace MarcusMedinaPro.TypedMath.ByteExtension
{
    using System;
    using System.Linq;

    /// <summary>
    /// Extension for byte
    /// </summary>
    public static class TypedMathByteExtension
    {
        /// <summary>
        /// Adds byte to byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Add(this byte x, byte y) => (byte)((int)x + (int)y);

        /// <summary>
        /// Adds char to byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Add(this byte x, char y) => (byte)((int)x + (int)y);

        /// <summary>
        /// Adds decimal to byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Add(this byte x, decimal y) => (byte)((int)x + (int)y);

        /// <summary>
        /// Adds double to byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Add(this byte x, double y) => (byte)((int)x + (int)y);

        /// <summary>
        /// Adds float to byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Add(this byte x, float y) => (byte)((int)x + (int)y);

        /// <summary>
        /// Adds int to byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Add(this byte x, int y) => (byte)((int)x + (int)y);

        /// <summary>
        /// Adds long to byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Add(this byte x, long y) => (byte)((int)x + (int)y);

        /// <summary>
        /// Adds sbyte to byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Add(this byte x, sbyte y) => (byte)((int)x + (int)y);

        /// <summary>
        /// Adds short to byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Add(this byte x, short y) => (byte)((int)x + (int)y);

        /// <summary>
        /// Adds uint to byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Add(this byte x, uint y) => (byte)((int)x + (int)y);

        /// <summary>
        /// Adds ulong to byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Add(this byte x, ulong y) => (byte)((int)x + (int)y);

        /// <summary>
        /// Adds ushort to byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Add(this byte x, ushort y) => (byte)((int)x + (int)y);

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static byte AddPercent(this byte value, byte percent) => (byte)(value + value.PercentOf(percent));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static byte AddPercent(this byte value, char percent) => (byte)(value + value.PercentOf(percent));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static byte AddPercent(this byte value, decimal percent) => (byte)(value + value.PercentOf(percent));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static byte AddPercent(this byte value, double percent) => (byte)(value + value.PercentOf(percent));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static byte AddPercent(this byte value, float percent) => (byte)(value + value.PercentOf(percent));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static byte AddPercent(this byte value, int percent) => (byte)(value + value.PercentOf(percent));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static byte AddPercent(this byte value, long percent) => (byte)(value + value.PercentOf(percent));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static byte AddPercent(this byte value, sbyte percent) => (byte)(value + value.PercentOf(percent));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static byte AddPercent(this byte value, short percent) => (byte)(value + value.PercentOf(percent));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static byte AddPercent(this byte value, uint percent) => (byte)(value + value.PercentOf(percent));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static byte AddPercent(this byte value, ulong percent) => (byte)(value + value.PercentOf(percent));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static byte AddPercent(this byte value, ushort percent) => (byte)(value + value.PercentOf(percent));

        /// <summary>
        /// Gets the AND of byte and byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte And(this byte x, byte y) => (byte)((int)x & (int)y);

        /// <summary>
        /// Gets the AND of char and byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte And(this byte x, char y) => (byte)((int)x & (int)y);

        /// <summary>
        /// Gets the AND of decimal and byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte And(this byte x, decimal y) => (byte)((int)x & (int)y);

        /// <summary>
        /// Gets the AND of double and byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte And(this byte x, double y) => (byte)((int)x & (int)y);

        /// <summary>
        /// Gets the AND of float and byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte And(this byte x, float y) => (byte)((int)x & (int)y);

        /// <summary>
        /// Gets the AND of int and byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte And(this byte x, int y) => (byte)((int)x & (int)y);

        /// <summary>
        /// Gets the AND of long and byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte And(this byte x, long y) => (byte)((int)x & (int)y);

        /// <summary>
        /// Gets the AND of sbyte and byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte And(this byte x, sbyte y) => (byte)((int)x & (int)y);

        /// <summary>
        /// Gets the AND of short and byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte And(this byte x, short y) => (byte)((int)x & (int)y);

        /// <summary>
        /// Gets the AND of uint and byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte And(this byte x, uint y) => (byte)((int)x & (int)y);

        /// <summary>
        /// Gets the AND of ulong and byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte And(this byte x, ulong y) => (byte)((int)x & (int)y);

        /// <summary>
        /// Gets the AND of ushort and byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte And(this byte x, ushort y) => (byte)((int)x & (int)y);

        /// <summary>
        /// Tries to cast byte to char, this can get ugly though
        /// </summary>
        /// <param name="x">The x <see cref="byte"/></param>
        /// <returns>The result of the operation</returns>
        public static char CastByteToChar(this byte x) => (char)x;

        /// <summary>
        /// Tries to cast byte to decimal, this can get ugly though
        /// </summary>
        /// <param name="x">The x <see cref="byte"/></param>
        /// <returns>The result of the operation</returns>
        public static decimal CastByteToDecimal(this byte x) => (decimal)x;

        /// <summary>
        /// Tries to cast byte to double, this can get ugly though
        /// </summary>
        /// <param name="x">The x <see cref="byte"/></param>
        /// <returns>The result of the operation</returns>
        public static double CastByteToDouble(this byte x) => (double)x;

        /// <summary>
        /// Tries to cast byte to float, this can get ugly though
        /// </summary>
        /// <param name="x">The x <see cref="byte"/></param>
        /// <returns>The result of the operation</returns>
        public static float CastByteToFloat(this byte x) => (float)x;

        /// <summary>
        /// Tries to cast byte to int, this can get ugly though
        /// </summary>
        /// <param name="x">The x <see cref="byte"/></param>
        /// <returns>The result of the operation</returns>
        public static int CastByteToInt(this byte x) => (int)x;

        /// <summary>
        /// Tries to cast byte to long, this can get ugly though
        /// </summary>
        /// <param name="x">The x <see cref="byte"/></param>
        /// <returns>The result of the operation</returns>
        public static long CastByteToLong(this byte x) => (long)x;

        /// <summary>
        /// Tries to cast byte to sbyte, this can get ugly though
        /// </summary>
        /// <param name="x">The x <see cref="byte"/></param>
        /// <returns>The result of the operation</returns>
        public static sbyte CastByteToSbyte(this byte x) => (sbyte)x;

        /// <summary>
        /// Tries to cast byte to short, this can get ugly though
        /// </summary>
        /// <param name="x">The x <see cref="byte"/></param>
        /// <returns>The result of the operation</returns>
        public static short CastByteToShort(this byte x) => (short)x;

        /// <summary>
        /// Tries to cast byte to uint, this can get ugly though
        /// </summary>
        /// <param name="x">The x <see cref="byte"/></param>
        /// <returns>The result of the operation</returns>
        public static uint CastByteToUint(this byte x) => (uint)x;

        /// <summary>
        /// Tries to cast byte to ulong, this can get ugly though
        /// </summary>
        /// <param name="x">The x <see cref="byte"/></param>
        /// <returns>The result of the operation</returns>
        public static ulong CastByteToUlong(this byte x) => (ulong)x;

        /// <summary>
        /// Tries to cast byte to ushort, this can get ugly though
        /// </summary>
        /// <param name="x">The x <see cref="byte"/></param>
        /// <returns>The result of the operation</returns>
        public static ushort CastByteToUshort(this byte x) => (ushort)x;

        /// <summary>
        /// Compare original and second number
        /// </summary>
        /// <param name="first">The number</param>
        /// <param name="second">The number to compare with</param>
        /// <returns>The highest of the two numbers</returns>
        public static byte ChooseIfHigher(this byte first, byte second) => first > second ? first : second;

        /// <summary>
        /// Compare original and second number
        /// </summary>
        /// <param name="first">The number</param>
        /// <param name="second">The number to compare with</param>
        /// <returns>The lowest of the two numbers</returns>
        public static byte ChooseIfLower(this byte first, byte second) => first < second ? first : second;

        /// <summary>
        /// Converts the array to int.
        /// </summary>
        /// <param name="array">The array.</param>
        /// <returns>The <see cref="int[]"/></returns>
        public static int[] ConvertArrayToInt(this byte[] array) => array.Select(x => (int)x).ToArray();

        /// <summary>
        /// Gets the differnce between two numbers
        /// </summary>
        /// <param name="original">The original.</param>
        /// <param name="compareTo">The compare to.</param>
        /// <returns></returns>
        public static byte DiferenceFrom(this byte original, byte compareTo) => (byte)(original > compareTo ? original - compareTo : original < compareTo ? compareTo - original : 0);

        /// <summary>
        /// Divides byte from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte DividedBy(this byte x, byte y) => (byte)((int)x / (int)y);

        /// <summary>
        /// Divides char from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte DividedBy(this byte x, char y) => (byte)((int)x / (int)y);

        /// <summary>
        /// Divides decimal from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte DividedBy(this byte x, decimal y) => (byte)((int)x / (int)y);

        /// <summary>
        /// Divides double from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte DividedBy(this byte x, double y) => (byte)((int)x / (int)y);

        /// <summary>
        /// Divides float from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte DividedBy(this byte x, float y) => (byte)((int)x / (int)y);

        /// <summary>
        /// Divides int from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte DividedBy(this byte x, int y) => (byte)((int)x / (int)y);

        /// <summary>
        /// Divides long from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte DividedBy(this byte x, long y) => (byte)((int)x / (int)y);

        /// <summary>
        /// Divides sbyte from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte DividedBy(this byte x, sbyte y) => (byte)((int)x / (int)y);

        /// <summary>
        /// Divides short from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte DividedBy(this byte x, short y) => (byte)((int)x / (int)y);

        /// <summary>
        /// Divides uint from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte DividedBy(this byte x, uint y) => (byte)((int)x / (int)y);

        /// <summary>
        /// Divides ulong from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte DividedBy(this byte x, ulong y) => (byte)((int)x / (int)y);

        /// <summary>
        /// Divides ushort from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte DividedBy(this byte x, ushort y) => (byte)((int)x / (int)y);

        /// <summary>
        /// Gets the first half of the array.
        /// </summary>
        /// <param name="array">The array.</param>
        /// <returns>The <see cref="byte[]"/></returns>
        public static byte[] GetFirstHalf(this byte[] array) => array.Take(array.Length / 2).ToArray();

        /// <summary>
        /// Gets the first number in the array
        /// </summary>
        /// <param name="array">The array <see cref="byte[]"/></param>
        /// <returns>The result of the operation</returns>
        public static byte GetFirstValue(this byte[] array) => array[0];

        /// <summary>
        /// Gets the hightest value of the numbers in the array
        /// </summary>
        /// <param name="array">The array</param>
        /// <returns>The hightest value in the array</returns>
        public static byte GetHighestValue(this byte[] array) => array.Max();

        /// <summary>
        /// Gets the last half of the array.
        /// </summary>
        /// <param name="array">The array.</param>
        /// <returns>The <see cref="byte[]"/></returns>
        public static byte[] GetLastHalf(this byte[] array) => array.Skip(array.Length / 2).Take(array.Length / 2).ToArray();

        /// <summary>
        /// Gets the last number in the array
        /// </summary>
        /// <param name="array">The array <see cref="byte[]"/></param>
        /// <returns>The result of the operation</returns>
        public static byte GetLastValue(this byte[] array) => array[array.Length - 1];

        /// <summary>
        /// Peeks the lowest value in the array
        /// </summary>
        /// <param name="array">The array <see cref="byte[]"/></param>
        /// <returns>The lowest value i the array</returns>
        public static byte GetLowestValue(this byte[] array) => array.Min();

        /// <summary>
        /// Gets the middle of both halves in the array.
        /// </summary>
        /// <param name="array">The array.</param>
        /// <returns>The <see cref="byte[]"/></returns>
        public static byte[] GetMiddle(this byte[] array) => array.Skip(array.Length / 4).Take(array.Length / 2).ToArray();

        /// <summary>
        /// Gets the number in the middle of the array
        /// </summary>
        /// <param name="array">The array <see cref="byte[]"/></param>
        /// <returns>The result of the operation</returns>
        public static byte GetMiddleValue(this byte[] array) => array[(array.Length - 1) / 2];

        /// <summary>
        /// Peeks numbers higher than given value in the array
        /// </summary>
        /// <param name="array"></param>
        /// <param name="x">The limit value</param>
        /// <returns>Returns a new array with all numbers higher than x</returns>
        public static byte[] GetValuesHigherThan(this byte[] array, byte x) => array.Where(y => y >= x).ToArray();

        /// <summary>
        /// Peeks numbers lower than given value in the array
        /// </summary>
        /// <param name="array"></param>
        /// <param name="x">The limit value</param>
        /// <returns>Returns a new array with all numbers lower than x</returns>
        public static byte[] GetValuesLowerThan(this byte[] array, byte x) => array.Where(y => y <= x).ToArray();

        /// <summary>
        /// Gets boolean True if byte is equal to byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this byte x, byte y) => x == y;

        /// <summary>
        /// Gets boolean True if char is equal to byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this byte x, char y) => x == (byte)y;

        /// <summary>
        /// Gets boolean True if decimal is equal to byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this byte x, decimal y) => x == (byte)y;

        /// <summary>
        /// Gets boolean True if double is equal to byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this byte x, double y) => x == (byte)y;

        /// <summary>
        /// Gets boolean True if float is equal to byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this byte x, float y) => x == (byte)y;

        /// <summary>
        /// Gets boolean True if int is equal to byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this byte x, int y) => x == (byte)y;

        /// <summary>
        /// Gets boolean True if long is equal to byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this byte x, long y) => x == (byte)y;

        /// <summary>
        /// Gets boolean True if sbyte is equal to byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this byte x, sbyte y) => x == (byte)y;

        /// <summary>
        /// Gets boolean True if short is equal to byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this byte x, short y) => x == (byte)y;

        /// <summary>
        /// Gets boolean True if uint is equal to byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this byte x, uint y) => x == (byte)y;

        /// <summary>
        /// Gets boolean True if ulong is equal to byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this byte x, ulong y) => x == (byte)y;

        /// <summary>
        /// Gets boolean True if ushort is equal to byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this byte x, ushort y) => x == (byte)y;

        /// <summary>
        /// Gets boolean True if byte is not equal to byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this byte x, byte y) => x != y;

        /// <summary>
        /// Gets boolean True if char is not equal to byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this byte x, char y) => x != (byte)y;

        /// <summary>
        /// Gets boolean True if decimal is not equal to byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this byte x, decimal y) => x != (byte)y;

        /// <summary>
        /// Gets boolean True if double is not equal to byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this byte x, double y) => x != (byte)y;

        /// <summary>
        /// Gets boolean True if float is not equal to byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this byte x, float y) => x != (byte)y;

        /// <summary>
        /// Gets boolean True if int is not equal to byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this byte x, int y) => x != (byte)y;

        /// <summary>
        /// Gets boolean True if long is not equal to byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this byte x, long y) => x != (byte)y;

        /// <summary>
        /// Gets boolean True if sbyte is not equal to byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this byte x, sbyte y) => x != (byte)y;

        /// <summary>
        /// Gets boolean True if short is not equal to byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this byte x, short y) => x != (byte)y;

        /// <summary>
        /// Gets boolean True if uint is not equal to byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this byte x, uint y) => x != (byte)y;

        /// <summary>
        /// Gets boolean True if ulong is not equal to byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this byte x, ulong y) => x != (byte)y;

        /// <summary>
        /// Gets boolean True if ushort is not equal to byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this byte x, ushort y) => x != (byte)y;

        /// <summary>
        /// Checks if a number is prime
        /// </summary>
        /// <param name="number">The number</param>
        /// <returns>True if the number is prime</returns>
        public static bool IsPrime(this byte number) => Enumerable.Range(2, (int)Math.Sqrt(number) - 1).All(divisor => number % divisor != 0);

        /// <summary>
        /// Gets the remainder of byte from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Modulus(this byte x, byte y) => (byte)((int)x % (int)y);

        /// <summary>
        /// Gets the remainder of char from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Modulus(this byte x, char y) => (byte)((int)x % (int)y);

        /// <summary>
        /// Gets the remainder of decimal from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Modulus(this byte x, decimal y) => (byte)((int)x % (int)y);

        /// <summary>
        /// Gets the remainder of double from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Modulus(this byte x, double y) => (byte)((int)x % (int)y);

        /// <summary>
        /// Gets the remainder of float from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Modulus(this byte x, float y) => (byte)((int)x % (int)y);

        /// <summary>
        /// Gets the remainder of int from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Modulus(this byte x, int y) => (byte)((int)x % (int)y);

        /// <summary>
        /// Gets the remainder of long from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Modulus(this byte x, long y) => (byte)((int)x % (int)y);

        /// <summary>
        /// Gets the remainder of sbyte from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Modulus(this byte x, sbyte y) => (byte)((int)x % (int)y);

        /// <summary>
        /// Gets the remainder of short from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Modulus(this byte x, short y) => (byte)((int)x % (int)y);

        /// <summary>
        /// Gets the remainder of uint from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Modulus(this byte x, uint y) => (byte)((int)x % (int)y);

        /// <summary>
        /// Gets the remainder of ulong from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Modulus(this byte x, ulong y) => (byte)((int)x % (int)y);

        /// <summary>
        /// Gets the remainder of ushort from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Modulus(this byte x, ushort y) => (byte)((int)x % (int)y);

        /// <summary>
        /// Multiplies byte with byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte MultipliedWith(this byte x, byte y) => (byte)((int)x * (int)y);

        /// <summary>
        /// Multiplies char with byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte MultipliedWith(this byte x, char y) => (byte)((int)x * (int)y);

        /// <summary>
        /// Multiplies decimal with byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte MultipliedWith(this byte x, decimal y) => (byte)((int)x * (int)y);

        /// <summary>
        /// Multiplies double with byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte MultipliedWith(this byte x, double y) => (byte)((int)x * (int)y);

        /// <summary>
        /// Multiplies float with byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte MultipliedWith(this byte x, float y) => (byte)((int)x * (int)y);

        /// <summary>
        /// Multiplies int with byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte MultipliedWith(this byte x, int y) => (byte)((int)x * (int)y);

        /// <summary>
        /// Multiplies long with byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte MultipliedWith(this byte x, long y) => (byte)((int)x * (int)y);

        /// <summary>
        /// Multiplies sbyte with byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte MultipliedWith(this byte x, sbyte y) => (byte)((int)x * (int)y);

        /// <summary>
        /// Multiplies short with byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte MultipliedWith(this byte x, short y) => (byte)((int)x * (int)y);

        /// <summary>
        /// Multiplies uint with byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte MultipliedWith(this byte x, uint y) => (byte)((int)x * (int)y);

        /// <summary>
        /// Multiplies ulong with byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte MultipliedWith(this byte x, ulong y) => (byte)((int)x * (int)y);

        /// <summary>
        /// Multiplies ushort with byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte MultipliedWith(this byte x, ushort y) => (byte)((int)x * (int)y);

        /// <summary>
        /// Gets the NOT of byte
        /// </summary>
        /// <param name="x">The x <see cref="byte"/></param>
        /// <returns>The result of the operation</returns>
        public static byte Not(this byte x) => (byte)~(int)x;

        /// <summary>
        /// Gets the OR of byte and byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Or(this byte x, byte y) => (byte)((int)x | (int)y);

        /// <summary>
        /// Gets the OR of char and byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Or(this byte x, char y) => (byte)((int)x | (int)y);

        /// <summary>
        /// Gets the OR of decimal and byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Or(this byte x, decimal y) => (byte)((int)x | (int)y);

        /// <summary>
        /// Gets the OR of double and byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Or(this byte x, double y) => (byte)((int)x | (int)y);

        /// <summary>
        /// Gets the OR of float and byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Or(this byte x, float y) => (byte)((int)x | (int)y);

        /// <summary>
        /// Gets the OR of int and byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Or(this byte x, int y) => (byte)((int)x | (int)y);

        /// <summary>
        /// Gets the OR of long and byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Or(this byte x, long y) => (byte)((int)x | (int)y);

        /// <summary>
        /// Gets the OR of sbyte and byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Or(this byte x, sbyte y) => (byte)((int)x | (int)y);

        /// <summary>
        /// Gets the OR of short and byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Or(this byte x, short y) => (byte)((int)x | (int)y);

        /// <summary>
        /// Gets the OR of uint and byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Or(this byte x, uint y) => (byte)((int)x | (int)y);

        /// <summary>
        /// Gets the OR of ulong and byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Or(this byte x, ulong y) => (byte)((int)x | (int)y);

        /// <summary>
        /// Gets the OR of ushort and byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Or(this byte x, ushort y) => (byte)((int)x | (int)y);

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static byte PercentOf(this byte percent, byte value) => (byte)(((byte)percent) / ((byte)100) * ((byte)value));

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static byte PercentOf(this byte percent, char value) => (byte)(((byte)percent) / ((byte)100) * ((byte)value));

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static byte PercentOf(this byte percent, decimal value) => (byte)(((byte)percent) / ((byte)100) * ((byte)value));

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static byte PercentOf(this byte percent, double value) => (byte)(((byte)percent) / ((byte)100) * ((byte)value));

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static byte PercentOf(this byte percent, float value) => (byte)(((byte)percent) / ((byte)100) * ((byte)value));

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static byte PercentOf(this byte percent, int value) => (byte)(((byte)percent) / ((byte)100) * ((byte)value));

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static byte PercentOf(this byte percent, long value) => (byte)(((byte)percent) / ((byte)100) * ((byte)value));

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static byte PercentOf(this byte percent, sbyte value) => (byte)(((byte)percent) / ((byte)100) * ((byte)value));

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static byte PercentOf(this byte percent, short value) => (byte)(((byte)percent) / ((byte)100) * ((byte)value));

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static byte PercentOf(this byte percent, uint value) => (byte)(((byte)percent) / ((byte)100) * ((byte)value));

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static byte PercentOf(this byte percent, ulong value) => (byte)(((byte)percent) / ((byte)100) * ((byte)value));

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static byte PercentOf(this byte percent, ushort value) => (byte)(((byte)percent) / ((byte)100) * ((byte)value));

        /// <summary>
        /// Rotates the numbers to the left.
        /// </summary>
        /// <param name="array">The array.</param>
        /// <returns>The <see cref="byte[]"/></returns>
        public static byte[] RotateLeft(this byte[] array)
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
        /// <returns>The <see cref="byte[]"/></returns>
        public static byte[] RotateRight(this byte[] array)
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
        public static ref byte SetHighestValueOf(this ref byte first, byte second, byte third)
        {
            first = second > third ? second : third;
            return ref first;
        }

        /// <summary>
        /// Compare original and second number and set the variable with the lowest
        /// </summary>
        /// <param name="first">The number</param>
        /// <param name="second">The number to compare with</param>
        /// <param name="third">The third <see cref="byte"/></param>
        /// <returns>Sets the variable to the lowest of the two numbers</returns>
        public static ref byte SetLowestValueOf(this ref byte first, byte second, byte third)
        {
            first = second < third ? second : third;
            return ref first;
        }

        /// <summary>
        /// Get the current size of the array
        /// </summary>
        /// <param name="array">The array <see cref="byte[]"/></param>
        /// <param name="size">The size <see cref="int"/></param>
        /// <returns>The size of the array</returns>
        public static byte[] SetNewArraySize(this byte[] array, int size)
        {
            var newArr = new byte[size];
            Array.Copy(array, 0, newArr, 0, array.Length);
            return newArr;
        }

        /// <summary>
        /// Gets shift left of byte from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte ShiftLeft(this byte x, byte y) => (byte)((int)x << (int)y);

        /// <summary>
        /// Gets shift left of char from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte ShiftLeft(this byte x, char y) => (byte)((int)x << (int)y);

        /// <summary>
        /// Gets shift left of decimal from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte ShiftLeft(this byte x, decimal y) => (byte)((int)x << (int)y);

        /// <summary>
        /// Gets shift left of double from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte ShiftLeft(this byte x, double y) => (byte)((int)x << (int)y);

        /// <summary>
        /// Gets shift left of float from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte ShiftLeft(this byte x, float y) => (byte)((int)x << (int)y);

        /// <summary>
        /// Gets shift left of int from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte ShiftLeft(this byte x, int y) => (byte)((int)x << (int)y);

        /// <summary>
        /// Gets shift left of long from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte ShiftLeft(this byte x, long y) => (byte)((int)x << (int)y);

        /// <summary>
        /// Gets shift left of sbyte from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte ShiftLeft(this byte x, sbyte y) => (byte)((int)x << (int)y);

        /// <summary>
        /// Gets shift left of short from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte ShiftLeft(this byte x, short y) => (byte)((int)x << (int)y);

        /// <summary>
        /// Gets shift left of uint from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte ShiftLeft(this byte x, uint y) => (byte)((int)x << (int)y);

        /// <summary>
        /// Gets shift left of ulong from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte ShiftLeft(this byte x, ulong y) => (byte)((int)x << (int)y);

        /// <summary>
        /// Gets shift left of ushort from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte ShiftLeft(this byte x, ushort y) => (byte)((int)x << (int)y);

        /// <summary>
        /// Gets shift right of byte from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte ShiftRight(this byte x, byte y) => (byte)((int)x >> (int)y);

        /// <summary>
        /// Gets shift right of char from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte ShiftRight(this byte x, char y) => (byte)((int)x >> (int)y);

        /// <summary>
        /// Gets shift right of decimal from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte ShiftRight(this byte x, decimal y) => (byte)((int)x >> (int)y);

        /// <summary>
        /// Gets shift right of double from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte ShiftRight(this byte x, double y) => (byte)((int)x >> (int)y);

        /// <summary>
        /// Gets shift right of float from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte ShiftRight(this byte x, float y) => (byte)((int)x >> (int)y);

        /// <summary>
        /// Gets shift right of int from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte ShiftRight(this byte x, int y) => (byte)((int)x >> (int)y);

        /// <summary>
        /// Gets shift right of long from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte ShiftRight(this byte x, long y) => (byte)((int)x >> (int)y);

        /// <summary>
        /// Gets shift right of sbyte from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte ShiftRight(this byte x, sbyte y) => (byte)((int)x >> (int)y);

        /// <summary>
        /// Gets shift right of short from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte ShiftRight(this byte x, short y) => (byte)((int)x >> (int)y);

        /// <summary>
        /// Gets shift right of uint from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte ShiftRight(this byte x, uint y) => (byte)((int)x >> (int)y);

        /// <summary>
        /// Gets shift right of ulong from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte ShiftRight(this byte x, ulong y) => (byte)((int)x >> (int)y);

        /// <summary>
        /// Gets shift right of ushort from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte ShiftRight(this byte x, ushort y) => (byte)((int)x >> (int)y);

        /// <summary>
        /// Sorts array from lowest to highest
        /// </summary>
        /// <param name="array">The array <see cref="byte[]"/></param>
        /// <returns>A sorted array</returns>
        public static byte[] SortArrayAsc(this byte[] array) => array.OrderBy(x => x).ToArray();

        /// <summary>
        /// Sorts array from highest to lowest
        /// </summary>
        /// <param name="array">The array <see cref="byte[]"/></param>
        /// <returns>A sorted array</returns>
        public static byte[] SortArrayDesc(this byte[] array) => array.OrderByDescending(x => x).ToArray();

        /// <summary>
        /// Subtracts byte from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(byte,byte) instead.", false)]
        public static byte Substract(this byte x, byte y) => (byte)((int)x - (int)y);

        /// <summary>
        /// Subtracts char from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(byte,char) instead.", false)]
        public static byte Substract(this byte x, char y) => (byte)((int)x - (int)y);

        /// <summary>
        /// Subtracts decimal from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(byte,decimal) instead.", false)]
        public static byte Substract(this byte x, decimal y) => (byte)((int)x - (int)y);

        /// <summary>
        /// Subtracts double from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(byte,double) instead.", false)]
        public static byte Substract(this byte x, double y) => (byte)((int)x - (int)y);

        /// <summary>
        /// Subtracts float from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(byte,float) instead.", false)]
        public static byte Substract(this byte x, float y) => (byte)((int)x - (int)y);

        /// <summary>
        /// Subtracts int from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(byte,int) instead.", false)]
        public static byte Substract(this byte x, int y) => (byte)((int)x - (int)y);

        /// <summary>
        /// Subtracts long from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(byte,long) instead.", false)]
        public static byte Substract(this byte x, long y) => (byte)((int)x - (int)y);

        /// <summary>
        /// Subtracts sbyte from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(byte,sbyte) instead.", false)]
        public static byte Substract(this byte x, sbyte y) => (byte)((int)x - (int)y);

        /// <summary>
        /// Subtracts short from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(byte,short) instead.", false)]
        public static byte Substract(this byte x, short y) => (byte)((int)x - (int)y);

        /// <summary>
        /// Subtracts uint from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(byte,uint) instead.", false)]
        public static byte Substract(this byte x, uint y) => (byte)((int)x - (int)y);

        /// <summary>
        /// Subtracts ulong from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(byte,ulong) instead.", false)]
        public static byte Substract(this byte x, ulong y) => (byte)((int)x - (int)y);

        /// <summary>
        /// Subtracts ushort from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(byte,ushort) instead.", false)]
        public static byte Substract(this byte x, ushort y) => (byte)((int)x - (int)y);

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(byte) instead.", false)]
        public static byte SubstractPercent(this byte value, byte percent) => (byte)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(char) instead.", false)]
        public static byte SubstractPercent(this byte value, char percent) => (byte)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(decimal) instead.", false)]
        public static byte SubstractPercent(this byte value, decimal percent) => (byte)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(double) instead.", false)]
        public static byte SubstractPercent(this byte value, double percent) => (byte)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(float) instead.", false)]
        public static byte SubstractPercent(this byte value, float percent) => (byte)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(int) instead.", false)]
        public static byte SubstractPercent(this byte value, int percent) => (byte)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(long) instead.", false)]
        public static byte SubstractPercent(this byte value, long percent) => (byte)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(sbyte) instead.", false)]
        public static byte SubstractPercent(this byte value, sbyte percent) => (byte)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(short) instead.", false)]
        public static byte SubstractPercent(this byte value, short percent) => (byte)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(uint) instead.", false)]
        public static byte SubstractPercent(this byte value, uint percent) => (byte)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(ulong) instead.", false)]
        public static byte SubstractPercent(this byte value, ulong percent) => (byte)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(ushort) instead.", false)]
        public static byte SubstractPercent(this byte value, ushort percent) => (byte)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts byte from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Subtract(this byte x, byte y) => (byte)((int)x - (int)y);

        /// <summary>
        /// Subtracts char from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Subtract(this byte x, char y) => (byte)((int)x - (int)y);

        /// <summary>
        /// Subtracts decimal from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Subtract(this byte x, decimal y) => (byte)((int)x - (int)y);

        /// <summary>
        /// Subtracts double from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Subtract(this byte x, double y) => (byte)((int)x - (int)y);

        /// <summary>
        /// Subtracts float from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Subtract(this byte x, float y) => (byte)((int)x - (int)y);

        /// <summary>
        /// Subtracts int from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Subtract(this byte x, int y) => (byte)((int)x - (int)y);

        /// <summary>
        /// Subtracts long from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Subtract(this byte x, long y) => (byte)((int)x - (int)y);

        /// <summary>
        /// Subtracts sbyte from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Subtract(this byte x, sbyte y) => (byte)((int)x - (int)y);

        /// <summary>
        /// Subtracts short from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Subtract(this byte x, short y) => (byte)((int)x - (int)y);

        /// <summary>
        /// Subtracts uint from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Subtract(this byte x, uint y) => (byte)((int)x - (int)y);

        /// <summary>
        /// Subtracts ulong from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Subtract(this byte x, ulong y) => (byte)((int)x - (int)y);

        /// <summary>
        /// Subtracts ushort from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Subtract(this byte x, ushort y) => (byte)((int)x - (int)y);

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static byte SubtractPercent(this byte value, byte percent) => (byte)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static byte SubtractPercent(this byte value, char percent) => (byte)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static byte SubtractPercent(this byte value, decimal percent) => (byte)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static byte SubtractPercent(this byte value, double percent) => (byte)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static byte SubtractPercent(this byte value, float percent) => (byte)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static byte SubtractPercent(this byte value, int percent) => (byte)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static byte SubtractPercent(this byte value, long percent) => (byte)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static byte SubtractPercent(this byte value, sbyte percent) => (byte)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static byte SubtractPercent(this byte value, short percent) => (byte)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static byte SubtractPercent(this byte value, uint percent) => (byte)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static byte SubtractPercent(this byte value, ulong percent) => (byte)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static byte SubtractPercent(this byte value, ushort percent) => (byte)(value - value.PercentOf(percent));

        /// <summary>
        /// Swaps two variables
        /// </summary>
        /// <param name="first">The main variable</param>
        /// <param name="second">The variable to switch with</param>
        /// <returns>
        /// The value from the second variable and sets second variable to original value
        /// </returns>
        public static ref byte SwapWith(this ref byte first, ref byte second)
        {
            var tmp = second;
            second = first;
            first = tmp;
            return ref first;
        }

        /// <summary>
        /// Gets XOR of byte of byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Xor(this byte x, byte y) => (byte)((int)x ^ (int)y);

        /// <summary>
        /// Gets XOR of char of byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Xor(this byte x, char y) => (byte)((int)x ^ (int)y);

        /// <summary>
        /// Gets XOR of decimal of byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Xor(this byte x, decimal y) => (byte)((int)x ^ (int)y);

        /// <summary>
        /// Gets XOR of double of byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Xor(this byte x, double y) => (byte)((int)x ^ (int)y);

        /// <summary>
        /// Gets XOR of float of byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Xor(this byte x, float y) => (byte)((int)x ^ (int)y);

        /// <summary>
        /// Gets XOR of int of byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Xor(this byte x, int y) => (byte)((int)x ^ (int)y);

        /// <summary>
        /// Gets XOR of long of byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Xor(this byte x, long y) => (byte)((int)x ^ (int)y);

        /// <summary>
        /// Gets XOR of sbyte of byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Xor(this byte x, sbyte y) => (byte)((int)x ^ (int)y);

        /// <summary>
        /// Gets XOR of short of byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Xor(this byte x, short y) => (byte)((int)x ^ (int)y);

        /// <summary>
        /// Gets XOR of uint of byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Xor(this byte x, uint y) => (byte)((int)x ^ (int)y);

        /// <summary>
        /// Gets XOR of ulong of byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Xor(this byte x, ulong y) => (byte)((int)x ^ (int)y);

        /// <summary>
        /// Gets XOR of ushort of byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Xor(this byte x, ushort y) => (byte)((int)x ^ (int)y);
    }
}
