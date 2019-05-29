//----------------------------------------------------------------------------------------------
// <copyright file="TypedMathShortExtension.cs" company="MarcusMedinaPro">
// By Marcus Medina, 2019 - http://MarcusMedina.Pro
// This file is subject to the terms and conditions defined in file 'license.txt', which is part of this project.
// </copyright>
// ----------------------------------------------------------------------------------------------
// Credits for borrowed code:
// LinQ Primenumbers, Zoran Horvat: http://www.codinghelmet.com/articles/linq-all-primes/
// ----------------------------------------------------------------------------------------------

namespace MarcusMedinaPro.TypedMath.ShortExtension
{
    using System;
    using System.Linq;

    /// <summary>
    /// Extension for short
    /// </summary>
    public static class TypedMathShortExtension
    {
        /// <summary>
        /// Adds byte to short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short Add(this short x, byte y) => (short)((int)x + (int)y);

        /// <summary>
        /// Adds char to short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short Add(this short x, char y) => (short)((int)x + (int)y);

        /// <summary>
        /// Adds decimal to short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short Add(this short x, decimal y) => (short)((int)x + (int)y);

        /// <summary>
        /// Adds double to short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short Add(this short x, double y) => (short)((int)x + (int)y);

        /// <summary>
        /// Adds float to short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short Add(this short x, float y) => (short)((int)x + (int)y);

        /// <summary>
        /// Adds int to short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short Add(this short x, int y) => (short)((int)x + (int)y);

        /// <summary>
        /// Adds long to short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short Add(this short x, long y) => (short)((int)x + (int)y);

        /// <summary>
        /// Adds sbyte to short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short Add(this short x, sbyte y) => (short)((int)x + (int)y);

        /// <summary>
        /// Adds short to short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short Add(this short x, short y) => (short)((int)x + (int)y);

        /// <summary>
        /// Adds uint to short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short Add(this short x, uint y) => (short)((int)x + (int)y);

        /// <summary>
        /// Adds ulong to short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short Add(this short x, ulong y) => (short)((int)x + (int)y);

        /// <summary>
        /// Adds ushort to short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short Add(this short x, ushort y) => (short)((int)x + (int)y);

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static short AddPercent(this short value, byte percent) => (short)(value + value.PercentOf(percent));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static short AddPercent(this short value, char percent) => (short)(value + value.PercentOf(percent));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static short AddPercent(this short value, decimal percent) => (short)(value + value.PercentOf(percent));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static short AddPercent(this short value, double percent) => (short)(value + value.PercentOf(percent));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static short AddPercent(this short value, float percent) => (short)(value + value.PercentOf(percent));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static short AddPercent(this short value, int percent) => (short)(value + value.PercentOf(percent));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static short AddPercent(this short value, long percent) => (short)(value + value.PercentOf(percent));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static short AddPercent(this short value, sbyte percent) => (short)(value + value.PercentOf(percent));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static short AddPercent(this short value, short percent) => (short)(value + value.PercentOf(percent));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static short AddPercent(this short value, uint percent) => (short)(value + value.PercentOf(percent));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static short AddPercent(this short value, ulong percent) => (short)(value + value.PercentOf(percent));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static short AddPercent(this short value, ushort percent) => (short)(value + value.PercentOf(percent));

        /// <summary>
        /// Gets the AND of byte and short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short And(this short x, byte y) => (short)((int)x & (int)y);

        /// <summary>
        /// Gets the AND of char and short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short And(this short x, char y) => (short)((int)x & (int)y);

        /// <summary>
        /// Gets the AND of decimal and short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short And(this short x, decimal y) => (short)((int)x & (int)y);

        /// <summary>
        /// Gets the AND of double and short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short And(this short x, double y) => (short)((int)x & (int)y);

        /// <summary>
        /// Gets the AND of float and short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short And(this short x, float y) => (short)((int)x & (int)y);

        /// <summary>
        /// Gets the AND of int and short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short And(this short x, int y) => (short)((int)x & (int)y);

        /// <summary>
        /// Gets the AND of long and short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short And(this short x, long y) => (short)((int)x & (int)y);

        /// <summary>
        /// Gets the AND of sbyte and short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short And(this short x, sbyte y) => (short)((int)x & (int)y);

        /// <summary>
        /// Gets the AND of short and short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short And(this short x, short y) => (short)((int)x & (int)y);

        /// <summary>
        /// Gets the AND of uint and short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short And(this short x, uint y) => (short)((int)x & (int)y);

        /// <summary>
        /// Gets the AND of ulong and short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short And(this short x, ulong y) => (short)((int)x & (int)y);

        /// <summary>
        /// Gets the AND of ushort and short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short And(this short x, ushort y) => (short)((int)x & (int)y);

        /// <summary>
        /// Tries to cast short to byte, this can get ugly though
        /// </summary>
        /// <param name="x">The x <see cref="short"/></param>
        /// <returns>The result of the operation</returns>
        public static byte CastShortToByte(this short x) => (byte)x;

        /// <summary>
        /// Tries to cast short to char, this can get ugly though
        /// </summary>
        /// <param name="x">The x <see cref="short"/></param>
        /// <returns>The result of the operation</returns>
        public static char CastShortToChar(this short x) => (char)x;

        /// <summary>
        /// Tries to cast short to decimal, this can get ugly though
        /// </summary>
        /// <param name="x">The x <see cref="short"/></param>
        /// <returns>The result of the operation</returns>
        public static decimal CastShortToDecimal(this short x) => (decimal)x;

        /// <summary>
        /// Tries to cast short to double, this can get ugly though
        /// </summary>
        /// <param name="x">The x <see cref="short"/></param>
        /// <returns>The result of the operation</returns>
        public static double CastShortToDouble(this short x) => (double)x;

        /// <summary>
        /// Tries to cast short to float, this can get ugly though
        /// </summary>
        /// <param name="x">The x <see cref="short"/></param>
        /// <returns>The result of the operation</returns>
        public static float CastShortToFloat(this short x) => (float)x;

        /// <summary>
        /// Tries to cast short to int, this can get ugly though
        /// </summary>
        /// <param name="x">The x <see cref="short"/></param>
        /// <returns>The result of the operation</returns>
        public static int CastShortToInt(this short x) => (int)x;

        /// <summary>
        /// Tries to cast short to long, this can get ugly though
        /// </summary>
        /// <param name="x">The x <see cref="short"/></param>
        /// <returns>The result of the operation</returns>
        public static long CastShortToLong(this short x) => (long)x;

        /// <summary>
        /// Tries to cast short to sbyte, this can get ugly though
        /// </summary>
        /// <param name="x">The x <see cref="short"/></param>
        /// <returns>The result of the operation</returns>
        public static sbyte CastShortToSbyte(this short x) => (sbyte)x;

        /// <summary>
        /// Tries to cast short to uint, this can get ugly though
        /// </summary>
        /// <param name="x">The x <see cref="short"/></param>
        /// <returns>The result of the operation</returns>
        public static uint CastShortToUint(this short x) => (uint)x;

        /// <summary>
        /// Tries to cast short to ulong, this can get ugly though
        /// </summary>
        /// <param name="x">The x <see cref="short"/></param>
        /// <returns>The result of the operation</returns>
        public static ulong CastShortToUlong(this short x) => (ulong)x;

        /// <summary>
        /// Tries to cast short to ushort, this can get ugly though
        /// </summary>
        /// <param name="x">The x <see cref="short"/></param>
        /// <returns>The result of the operation</returns>
        public static ushort CastShortToUshort(this short x) => (ushort)x;

        /// <summary>
        /// Compare original and second number
        /// </summary>
        /// <param name="first">The number</param>
        /// <param name="second">The number to compare with</param>
        /// <returns>The highest of the two numbers</returns>
        public static short ChooseIfHigher(this short first, short second) => first > second ? first : second;

        /// <summary>
        /// Compare original and second number
        /// </summary>
        /// <param name="first">The number</param>
        /// <param name="second">The number to compare with</param>
        /// <returns>The lowest of the two numbers</returns>
        public static short ChooseIfLower(this short first, short second) => first < second ? first : second;

        /// <summary>
        /// Divides byte from short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short DividedBy(this short x, byte y) => (short)((int)x / (int)y);

        /// <summary>
        /// Divides char from short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short DividedBy(this short x, char y) => (short)((int)x / (int)y);

        /// <summary>
        /// Divides decimal from short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short DividedBy(this short x, decimal y) => (short)((int)x / (int)y);

        /// <summary>
        /// Divides double from short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short DividedBy(this short x, double y) => (short)((int)x / (int)y);

        /// <summary>
        /// Divides float from short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short DividedBy(this short x, float y) => (short)((int)x / (int)y);

        /// <summary>
        /// Divides int from short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short DividedBy(this short x, int y) => (short)((int)x / (int)y);

        /// <summary>
        /// Divides long from short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short DividedBy(this short x, long y) => (short)((int)x / (int)y);

        /// <summary>
        /// Divides sbyte from short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short DividedBy(this short x, sbyte y) => (short)((int)x / (int)y);

        /// <summary>
        /// Divides short from short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short DividedBy(this short x, short y) => (short)((int)x / (int)y);

        /// <summary>
        /// Divides uint from short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short DividedBy(this short x, uint y) => (short)((int)x / (int)y);

        /// <summary>
        /// Divides ulong from short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short DividedBy(this short x, ulong y) => (short)((int)x / (int)y);

        /// <summary>
        /// Divides ushort from short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short DividedBy(this short x, ushort y) => (short)((int)x / (int)y);

        /// <summary>
        /// Gets a boolean True if short is greater than byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this short x, byte y) => x > (short)y;

        /// <summary>
        /// Gets a boolean True if short is greater than char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this short x, char y) => x > (short)y;

        /// <summary>
        /// Gets a boolean True if short is greater than decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this short x, decimal y) => x > (short)y;

        /// <summary>
        /// Gets a boolean True if short is greater than double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this short x, double y) => x > (short)y;

        /// <summary>
        /// Gets a boolean True if short is greater than float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this short x, float y) => x > (short)y;

        /// <summary>
        /// Gets a boolean True if short is greater than int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this short x, int y) => x > (short)y;

        /// <summary>
        /// Gets a boolean True if short is greater than long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this short x, long y) => x > (short)y;

        /// <summary>
        /// Gets a boolean True if short is greater than sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this short x, sbyte y) => x > (short)y;

        /// <summary>
        /// Gets a boolean True if short is greater than short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this short x, short y) => x > y;

        /// <summary>
        /// Gets a boolean True if short is greater than uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this short x, uint y) => x > (short)y;

        /// <summary>
        /// Gets a boolean True if short is greater than ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this short x, ulong y) => x > (short)y;

        /// <summary>
        /// Gets a boolean True if short is greater than ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this short x, ushort y) => x > (short)y;

        /// <summary>
        /// Gets boolean True if byte is equal to short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this short x, byte y) => x == (short)y;

        /// <summary>
        /// Gets boolean True if char is equal to short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this short x, char y) => x == (short)y;

        /// <summary>
        /// Gets boolean True if decimal is equal to short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this short x, decimal y) => x == (short)y;

        /// <summary>
        /// Gets boolean True if double is equal to short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this short x, double y) => x == (short)y;

        /// <summary>
        /// Gets boolean True if float is equal to short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this short x, float y) => x == (short)y;

        /// <summary>
        /// Gets boolean True if int is equal to short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this short x, int y) => x == (short)y;

        /// <summary>
        /// Gets boolean True if long is equal to short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this short x, long y) => x == (short)y;

        /// <summary>
        /// Gets boolean True if sbyte is equal to short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this short x, sbyte y) => x == (short)y;

        /// <summary>
        /// Gets boolean True if short is equal to short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this short x, short y) => x == y;

        /// <summary>
        /// Gets boolean True if uint is equal to short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this short x, uint y) => x == (short)y;

        /// <summary>
        /// Gets boolean True if ulong is equal to short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this short x, ulong y) => x == (short)y;

        /// <summary>
        /// Gets boolean True if ushort is equal to short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this short x, ushort y) => x == (short)y;

        /// <summary>
        /// Gets boolean true if value is less than zero
        /// </summary>
        /// <param name="x">The x <see cref="short"/></param>
        /// <returns>The result of the operation</returns>
        public static bool IsNegative(this short x) => x < 0;

        /// <summary>
        /// Gets boolean True if byte is not equal to short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this short x, byte y) => x != (short)y;

        /// <summary>
        /// Gets boolean True if char is not equal to short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this short x, char y) => x != (short)y;

        /// <summary>
        /// Gets boolean True if decimal is not equal to short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this short x, decimal y) => x != (short)y;

        /// <summary>
        /// Gets boolean True if double is not equal to short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this short x, double y) => x != (short)y;

        /// <summary>
        /// Gets boolean True if float is not equal to short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this short x, float y) => x != (short)y;

        /// <summary>
        /// Gets boolean True if int is not equal to short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this short x, int y) => x != (short)y;

        /// <summary>
        /// Gets boolean True if long is not equal to short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this short x, long y) => x != (short)y;

        /// <summary>
        /// Gets boolean True if sbyte is not equal to short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this short x, sbyte y) => x != (short)y;

        /// <summary>
        /// Gets boolean True if short is not equal to short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this short x, short y) => x != y;

        /// <summary>
        /// Gets boolean True if uint is not equal to short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this short x, uint y) => x != (short)y;

        /// <summary>
        /// Gets boolean True if ulong is not equal to short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this short x, ulong y) => x != (short)y;

        /// <summary>
        /// Gets boolean True if ushort is not equal to short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this short x, ushort y) => x != (short)y;

        /// <summary>
        /// Gets boolean true if value is more than zero
        /// </summary>
        /// <param name="x">The x <see cref="short"/></param>
        /// <returns>The result of the operation</returns>
        public static bool IsPositive(this short x) => x >= 0;

        /// <summary>
        /// Checks if a number is prime
        /// </summary>
        /// <param name="number">The number</param>
        /// <returns>True if the number is prime</returns>
        public static bool IsPrime(this short number) => Enumerable.Range(2, (int)Math.Sqrt(number) - 1).All(divisor => number % divisor != 0);

        /// <summary>
        /// Gets a boolean True if short is less than byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this short x, byte y) => x < (short)y;

        /// <summary>
        /// Gets a boolean True if short is less than char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this short x, char y) => x < (short)y;

        /// <summary>
        /// Gets a boolean True if short is less than decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this short x, decimal y) => x < (short)y;

        /// <summary>
        /// Gets a boolean True if short is less than double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this short x, double y) => x < (short)y;

        /// <summary>
        /// Gets a boolean True if short is less than float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this short x, float y) => x < (short)y;

        /// <summary>
        /// Gets a boolean True if short is less than int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this short x, int y) => x < (short)y;

        /// <summary>
        /// Gets a boolean True if short is less than long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this short x, long y) => x < (short)y;

        /// <summary>
        /// Gets a boolean True if short is less than sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this short x, sbyte y) => x < (short)y;

        /// <summary>
        /// Gets a boolean True if short is less than short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this short x, short y) => x < y;

        /// <summary>
        /// Gets a boolean True if short is less than uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this short x, uint y) => x < (short)y;

        /// <summary>
        /// Gets a boolean True if short is less than ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this short x, ulong y) => x < (short)y;

        /// <summary>
        /// Gets a boolean True if short is less than ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this short x, ushort y) => x < (short)y;

        /// <summary>
        /// Gets the remainder of byte from short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short Modulus(this short x, byte y) => (short)((int)x % (int)y);

        /// <summary>
        /// Gets the remainder of char from short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short Modulus(this short x, char y) => (short)((int)x % (int)y);

        /// <summary>
        /// Gets the remainder of decimal from short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short Modulus(this short x, decimal y) => (short)((int)x % (int)y);

        /// <summary>
        /// Gets the remainder of double from short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short Modulus(this short x, double y) => (short)((int)x % (int)y);

        /// <summary>
        /// Gets the remainder of float from short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short Modulus(this short x, float y) => (short)((int)x % (int)y);

        /// <summary>
        /// Gets the remainder of int from short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short Modulus(this short x, int y) => (short)((int)x % (int)y);

        /// <summary>
        /// Gets the remainder of long from short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short Modulus(this short x, long y) => (short)((int)x % (int)y);

        /// <summary>
        /// Gets the remainder of sbyte from short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short Modulus(this short x, sbyte y) => (short)((int)x % (int)y);

        /// <summary>
        /// Gets the remainder of short from short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short Modulus(this short x, short y) => (short)((int)x % (int)y);

        /// <summary>
        /// Gets the remainder of uint from short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short Modulus(this short x, uint y) => (short)((int)x % (int)y);

        /// <summary>
        /// Gets the remainder of ulong from short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short Modulus(this short x, ulong y) => (short)((int)x % (int)y);

        /// <summary>
        /// Gets the remainder of ushort from short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short Modulus(this short x, ushort y) => (short)((int)x % (int)y);

        /// <summary>
        /// Multiplies byte with short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short MultipliedWith(this short x, byte y) => (short)((int)x * (int)y);

        /// <summary>
        /// Multiplies char with short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short MultipliedWith(this short x, char y) => (short)((int)x * (int)y);

        /// <summary>
        /// Multiplies decimal with short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short MultipliedWith(this short x, decimal y) => (short)((int)x * (int)y);

        /// <summary>
        /// Multiplies double with short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short MultipliedWith(this short x, double y) => (short)((int)x * (int)y);

        /// <summary>
        /// Multiplies float with short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short MultipliedWith(this short x, float y) => (short)((int)x * (int)y);

        /// <summary>
        /// Multiplies int with short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short MultipliedWith(this short x, int y) => (short)((int)x * (int)y);

        /// <summary>
        /// Multiplies long with short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short MultipliedWith(this short x, long y) => (short)((int)x * (int)y);

        /// <summary>
        /// Multiplies sbyte with short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short MultipliedWith(this short x, sbyte y) => (short)((int)x * (int)y);

        /// <summary>
        /// Multiplies short with short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short MultipliedWith(this short x, short y) => (short)((int)x * (int)y);

        /// <summary>
        /// Multiplies uint with short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short MultipliedWith(this short x, uint y) => (short)((int)x * (int)y);

        /// <summary>
        /// Multiplies ulong with short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short MultipliedWith(this short x, ulong y) => (short)((int)x * (int)y);

        /// <summary>
        /// Multiplies ushort with short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short MultipliedWith(this short x, ushort y) => (short)((int)x * (int)y);

        /// <summary>
        /// Gets the NOT of short
        /// </summary>
        /// <param name="x">The x <see cref="short"/></param>
        /// <returns>The result of the operation</returns>
        public static short Not(this short x) => (short)~(int)x;

        /// <summary>
        /// Gets the OR of byte and short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short Or(this short x, byte y) => (short)((int)x | (int)y);

        /// <summary>
        /// Gets the OR of char and short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short Or(this short x, char y) => (short)((int)x | (int)y);

        /// <summary>
        /// Gets the OR of decimal and short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short Or(this short x, decimal y) => (short)((int)x | (int)y);

        /// <summary>
        /// Gets the OR of double and short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short Or(this short x, double y) => (short)((int)x | (int)y);

        /// <summary>
        /// Gets the OR of float and short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short Or(this short x, float y) => (short)((int)x | (int)y);

        /// <summary>
        /// Gets the OR of int and short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short Or(this short x, int y) => (short)((int)x | (int)y);

        /// <summary>
        /// Gets the OR of long and short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short Or(this short x, long y) => (short)((int)x | (int)y);

        /// <summary>
        /// Gets the OR of sbyte and short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short Or(this short x, sbyte y) => (short)((int)x | (int)y);

        /// <summary>
        /// Gets the OR of short and short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short Or(this short x, short y) => (short)((int)x | (int)y);

        /// <summary>
        /// Gets the OR of uint and short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short Or(this short x, uint y) => (short)((int)x | (int)y);

        /// <summary>
        /// Gets the OR of ulong and short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short Or(this short x, ulong y) => (short)((int)x | (int)y);

        /// <summary>
        /// Gets the OR of ushort and short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short Or(this short x, ushort y) => (short)((int)x | (int)y);

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static short PercentOf(this short percent, byte value) => (short)(((short)percent) / ((short)100) * ((short)value));

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static short PercentOf(this short percent, char value) => (short)(((short)percent) / ((short)100) * ((short)value));

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static short PercentOf(this short percent, decimal value) => (short)(((short)percent) / ((short)100) * ((short)value));

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static short PercentOf(this short percent, double value) => (short)(((short)percent) / ((short)100) * ((short)value));

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static short PercentOf(this short percent, float value) => (short)(((short)percent) / ((short)100) * ((short)value));

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static short PercentOf(this short percent, int value) => (short)(((short)percent) / ((short)100) * ((short)value));

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static short PercentOf(this short percent, long value) => (short)(((short)percent) / ((short)100) * ((short)value));

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static short PercentOf(this short percent, sbyte value) => (short)(((short)percent) / ((short)100) * ((short)value));

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static short PercentOf(this short percent, short value) => (short)(((short)percent) / ((short)100) * ((short)value));

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static short PercentOf(this short percent, uint value) => (short)(((short)percent) / ((short)100) * ((short)value));

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static short PercentOf(this short percent, ulong value) => (short)(((short)percent) / ((short)100) * ((short)value));

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static short PercentOf(this short percent, ushort value) => (short)(((short)percent) / ((short)100) * ((short)value));

        /// <summary>
        /// Compare original and second number and set the variable with the highest
        /// </summary>
        /// <param name="first">The variable</param>
        /// <param name="second">The number to compare</param>
        /// <param name="third">The number to compare with</param>
        /// <returns>Sets the variable to the highest of the two numbers</returns>
        public static ref short SetHighestValueOf(this ref short first, short second, short third)
        {
            first = second > third ? second : third;
            return ref first;
        }

        /// <summary>
        /// Compare original and second number and set the variable with the lowest
        /// </summary>
        /// <param name="first">The number</param>
        /// <param name="second">The number to compare with</param>
        /// <param name="third">The third <see cref="short"/></param>
        /// <returns>Sets the variable to the lowest of the two numbers</returns>
        public static ref short SetLowestValueOf(this ref short first, short second, short third)
        {
            first = second < third ? second : third;
            return ref first;
        }

        /// <summary>
        /// Gets shift left of byte from short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short ShiftLeft(this short x, byte y) => (short)((int)x << (int)y);

        /// <summary>
        /// Gets shift left of char from short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short ShiftLeft(this short x, char y) => (short)((int)x << (int)y);

        /// <summary>
        /// Gets shift left of decimal from short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short ShiftLeft(this short x, decimal y) => (short)((int)x << (int)y);

        /// <summary>
        /// Gets shift left of double from short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short ShiftLeft(this short x, double y) => (short)((int)x << (int)y);

        /// <summary>
        /// Gets shift left of float from short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short ShiftLeft(this short x, float y) => (short)((int)x << (int)y);

        /// <summary>
        /// Gets shift left of int from short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short ShiftLeft(this short x, int y) => (short)((int)x << (int)y);

        /// <summary>
        /// Gets shift left of long from short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short ShiftLeft(this short x, long y) => (short)((int)x << (int)y);

        /// <summary>
        /// Gets shift left of sbyte from short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short ShiftLeft(this short x, sbyte y) => (short)((int)x << (int)y);

        /// <summary>
        /// Gets shift left of short from short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short ShiftLeft(this short x, short y) => (short)((int)x << (int)y);

        /// <summary>
        /// Gets shift left of uint from short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short ShiftLeft(this short x, uint y) => (short)((int)x << (int)y);

        /// <summary>
        /// Gets shift left of ulong from short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short ShiftLeft(this short x, ulong y) => (short)((int)x << (int)y);

        /// <summary>
        /// Gets shift left of ushort from short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short ShiftLeft(this short x, ushort y) => (short)((int)x << (int)y);

        /// <summary>
        /// Gets shift right of byte from short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short ShiftRight(this short x, byte y) => (short)((int)x >> (int)y);

        /// <summary>
        /// Gets shift right of char from short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short ShiftRight(this short x, char y) => (short)((int)x >> (int)y);

        /// <summary>
        /// Gets shift right of decimal from short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short ShiftRight(this short x, decimal y) => (short)((int)x >> (int)y);

        /// <summary>
        /// Gets shift right of double from short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short ShiftRight(this short x, double y) => (short)((int)x >> (int)y);

        /// <summary>
        /// Gets shift right of float from short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short ShiftRight(this short x, float y) => (short)((int)x >> (int)y);

        /// <summary>
        /// Gets shift right of int from short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short ShiftRight(this short x, int y) => (short)((int)x >> (int)y);

        /// <summary>
        /// Gets shift right of long from short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short ShiftRight(this short x, long y) => (short)((int)x >> (int)y);

        /// <summary>
        /// Gets shift right of sbyte from short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short ShiftRight(this short x, sbyte y) => (short)((int)x >> (int)y);

        /// <summary>
        /// Gets shift right of short from short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short ShiftRight(this short x, short y) => (short)((int)x >> (int)y);

        /// <summary>
        /// Gets shift right of uint from short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short ShiftRight(this short x, uint y) => (short)((int)x >> (int)y);

        /// <summary>
        /// Gets shift right of ulong from short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short ShiftRight(this short x, ulong y) => (short)((int)x >> (int)y);

        /// <summary>
        /// Gets shift right of ushort from short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short ShiftRight(this short x, ushort y) => (short)((int)x >> (int)y);

        /// <summary>
        /// Subtracts byte from short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(short,byte) instead.", false)]
        public static short Substract(this short x, byte y) => (short)((int)x - (int)y);

        /// <summary>
        /// Subtracts char from short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(short,char) instead.", false)]
        public static short Substract(this short x, char y) => (short)((int)x - (int)y);

        /// <summary>
        /// Subtracts decimal from short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(short,decimal) instead.", false)]
        public static short Substract(this short x, decimal y) => (short)((int)x - (int)y);

        /// <summary>
        /// Subtracts double from short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(short,double) instead.", false)]
        public static short Substract(this short x, double y) => (short)((int)x - (int)y);

        /// <summary>
        /// Subtracts float from short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(short,float) instead.", false)]
        public static short Substract(this short x, float y) => (short)((int)x - (int)y);

        /// <summary>
        /// Subtracts int from short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(short,int) instead.", false)]
        public static short Substract(this short x, int y) => (short)((int)x - (int)y);

        /// <summary>
        /// Subtracts long from short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(short,long) instead.", false)]
        public static short Substract(this short x, long y) => (short)((int)x - (int)y);

        /// <summary>
        /// Subtracts sbyte from short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(short,sbyte) instead.", false)]
        public static short Substract(this short x, sbyte y) => (short)((int)x - (int)y);

        /// <summary>
        /// Subtracts short from short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(short,short) instead.", false)]
        public static short Substract(this short x, short y) => (short)((int)x - (int)y);

        /// <summary>
        /// Subtracts uint from short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(short,uint) instead.", false)]
        public static short Substract(this short x, uint y) => (short)((int)x - (int)y);

        /// <summary>
        /// Subtracts ulong from short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(short,ulong) instead.", false)]
        public static short Substract(this short x, ulong y) => (short)((int)x - (int)y);

        /// <summary>
        /// Subtracts ushort from short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(short,ushort) instead.", false)]
        public static short Substract(this short x, ushort y) => (short)((int)x - (int)y);

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(byte) instead.", false)]
        public static short SubstractPercent(this short value, byte percent) => (short)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(char) instead.", false)]
        public static short SubstractPercent(this short value, char percent) => (short)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(decimal) instead.", false)]
        public static short SubstractPercent(this short value, decimal percent) => (short)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(double) instead.", false)]
        public static short SubstractPercent(this short value, double percent) => (short)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(float) instead.", false)]
        public static short SubstractPercent(this short value, float percent) => (short)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(int) instead.", false)]
        public static short SubstractPercent(this short value, int percent) => (short)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(long) instead.", false)]
        public static short SubstractPercent(this short value, long percent) => (short)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(sbyte) instead.", false)]
        public static short SubstractPercent(this short value, sbyte percent) => (short)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(short) instead.", false)]
        public static short SubstractPercent(this short value, short percent) => (short)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(uint) instead.", false)]
        public static short SubstractPercent(this short value, uint percent) => (short)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(ulong) instead.", false)]
        public static short SubstractPercent(this short value, ulong percent) => (short)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(ushort) instead.", false)]
        public static short SubstractPercent(this short value, ushort percent) => (short)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts byte from short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short Subtract(this short x, byte y) => (short)((int)x - (int)y);

        /// <summary>
        /// Subtracts char from short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short Subtract(this short x, char y) => (short)((int)x - (int)y);

        /// <summary>
        /// Subtracts decimal from short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short Subtract(this short x, decimal y) => (short)((int)x - (int)y);

        /// <summary>
        /// Subtracts double from short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short Subtract(this short x, double y) => (short)((int)x - (int)y);

        /// <summary>
        /// Subtracts float from short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short Subtract(this short x, float y) => (short)((int)x - (int)y);

        /// <summary>
        /// Subtracts int from short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short Subtract(this short x, int y) => (short)((int)x - (int)y);

        /// <summary>
        /// Subtracts long from short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short Subtract(this short x, long y) => (short)((int)x - (int)y);

        /// <summary>
        /// Subtracts sbyte from short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short Subtract(this short x, sbyte y) => (short)((int)x - (int)y);

        /// <summary>
        /// Subtracts short from short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short Subtract(this short x, short y) => (short)((int)x - (int)y);

        /// <summary>
        /// Subtracts uint from short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short Subtract(this short x, uint y) => (short)((int)x - (int)y);

        /// <summary>
        /// Subtracts ulong from short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short Subtract(this short x, ulong y) => (short)((int)x - (int)y);

        /// <summary>
        /// Subtracts ushort from short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short Subtract(this short x, ushort y) => (short)((int)x - (int)y);

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static short SubtractPercent(this short value, byte percent) => (short)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static short SubtractPercent(this short value, char percent) => (short)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static short SubtractPercent(this short value, decimal percent) => (short)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static short SubtractPercent(this short value, double percent) => (short)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static short SubtractPercent(this short value, float percent) => (short)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static short SubtractPercent(this short value, int percent) => (short)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static short SubtractPercent(this short value, long percent) => (short)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static short SubtractPercent(this short value, sbyte percent) => (short)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static short SubtractPercent(this short value, short percent) => (short)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static short SubtractPercent(this short value, uint percent) => (short)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static short SubtractPercent(this short value, ulong percent) => (short)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static short SubtractPercent(this short value, ushort percent) => (short)(value - value.PercentOf(percent));

        /// <summary>
        /// Swaps two variables
        /// </summary>
        /// <param name="first">The main variable</param>
        /// <param name="second">The variable to switch with</param>
        /// <returns>
        /// The value from the second variable and sets second variable to original value
        /// </returns>
        public static ref short SwapWith(this ref short first, ref short second)
        {
            var tmp = second;
            second = first;
            first = tmp;
            return ref first;
        }

        /// <summary>
        /// Gets XOR of byte of short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short Xor(this short x, byte y) => (short)((int)x ^ (int)y);

        /// <summary>
        /// Gets XOR of char of short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short Xor(this short x, char y) => (short)((int)x ^ (int)y);

        /// <summary>
        /// Gets XOR of decimal of short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short Xor(this short x, decimal y) => (short)((int)x ^ (int)y);

        /// <summary>
        /// Gets XOR of double of short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short Xor(this short x, double y) => (short)((int)x ^ (int)y);

        /// <summary>
        /// Gets XOR of float of short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short Xor(this short x, float y) => (short)((int)x ^ (int)y);

        /// <summary>
        /// Gets XOR of int of short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short Xor(this short x, int y) => (short)((int)x ^ (int)y);

        /// <summary>
        /// Gets XOR of long of short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short Xor(this short x, long y) => (short)((int)x ^ (int)y);

        /// <summary>
        /// Gets XOR of sbyte of short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short Xor(this short x, sbyte y) => (short)((int)x ^ (int)y);

        /// <summary>
        /// Gets XOR of short of short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short Xor(this short x, short y) => (short)((int)x ^ (int)y);

        /// <summary>
        /// Gets XOR of uint of short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short Xor(this short x, uint y) => (short)((int)x ^ (int)y);

        /// <summary>
        /// Gets XOR of ulong of short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short Xor(this short x, ulong y) => (short)((int)x ^ (int)y);

        /// <summary>
        /// Gets XOR of ushort of short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static short Xor(this short x, ushort y) => (short)((int)x ^ (int)y);
    }
}