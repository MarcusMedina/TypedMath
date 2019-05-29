//----------------------------------------------------------------------------------------------
// <copyright file="TypedMathSbyteExtension.cs" company="MarcusMedinaPro">
// By Marcus Medina, 2019 - http://MarcusMedina.Pro
// This file is subject to the terms and conditions defined in file 'license.txt', which is part of this project.
// </copyright>
// ----------------------------------------------------------------------------------------------
// Credits for borrowed code:
// LinQ Primenumbers, Zoran Horvat: http://www.codinghelmet.com/articles/linq-all-primes/
// ----------------------------------------------------------------------------------------------

namespace MarcusMedinaPro.TypedMath.SbyteExtension
{
    using System;
    using System.Linq;

    /// <summary>
    /// Extension for sbyte
    /// </summary>
    public static class TypedMathSbyteExtension
    {
        /// <summary>
        /// Adds byte to sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte Add(this sbyte x, byte y) => (sbyte)((int)x + (int)y);

        /// <summary>
        /// Adds char to sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte Add(this sbyte x, char y) => (sbyte)((int)x + (int)y);

        /// <summary>
        /// Adds decimal to sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte Add(this sbyte x, decimal y) => (sbyte)((int)x + (int)y);

        /// <summary>
        /// Adds double to sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte Add(this sbyte x, double y) => (sbyte)((int)x + (int)y);

        /// <summary>
        /// Adds float to sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte Add(this sbyte x, float y) => (sbyte)((int)x + (int)y);

        /// <summary>
        /// Adds int to sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte Add(this sbyte x, int y) => (sbyte)((int)x + (int)y);

        /// <summary>
        /// Adds long to sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte Add(this sbyte x, long y) => (sbyte)((int)x + (int)y);

        /// <summary>
        /// Adds sbyte to sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte Add(this sbyte x, sbyte y) => (sbyte)((int)x + (int)y);

        /// <summary>
        /// Adds short to sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte Add(this sbyte x, short y) => (sbyte)((int)x + (int)y);

        /// <summary>
        /// Adds uint to sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte Add(this sbyte x, uint y) => (sbyte)((int)x + (int)y);

        /// <summary>
        /// Adds ulong to sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte Add(this sbyte x, ulong y) => (sbyte)((int)x + (int)y);

        /// <summary>
        /// Adds ushort to sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte Add(this sbyte x, ushort y) => (sbyte)((int)x + (int)y);

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static sbyte AddPercent(this sbyte value, byte percent) => (sbyte)(value + value.PercentOf(percent));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static sbyte AddPercent(this sbyte value, char percent) => (sbyte)(value + value.PercentOf(percent));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static sbyte AddPercent(this sbyte value, decimal percent) => (sbyte)(value + value.PercentOf(percent));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static sbyte AddPercent(this sbyte value, double percent) => (sbyte)(value + value.PercentOf(percent));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static sbyte AddPercent(this sbyte value, float percent) => (sbyte)(value + value.PercentOf(percent));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static sbyte AddPercent(this sbyte value, int percent) => (sbyte)(value + value.PercentOf(percent));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static sbyte AddPercent(this sbyte value, long percent) => (sbyte)(value + value.PercentOf(percent));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static sbyte AddPercent(this sbyte value, sbyte percent) => (sbyte)(value + value.PercentOf(percent));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static sbyte AddPercent(this sbyte value, short percent) => (sbyte)(value + value.PercentOf(percent));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static sbyte AddPercent(this sbyte value, uint percent) => (sbyte)(value + value.PercentOf(percent));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static sbyte AddPercent(this sbyte value, ulong percent) => (sbyte)(value + value.PercentOf(percent));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static sbyte AddPercent(this sbyte value, ushort percent) => (sbyte)(value + value.PercentOf(percent));

        /// <summary>
        /// Gets the AND of byte and sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte And(this sbyte x, byte y) => (sbyte)((int)x & (int)y);

        /// <summary>
        /// Gets the AND of char and sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte And(this sbyte x, char y) => (sbyte)((int)x & (int)y);

        /// <summary>
        /// Gets the AND of decimal and sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte And(this sbyte x, decimal y) => (sbyte)((int)x & (int)y);

        /// <summary>
        /// Gets the AND of double and sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte And(this sbyte x, double y) => (sbyte)((int)x & (int)y);

        /// <summary>
        /// Gets the AND of float and sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte And(this sbyte x, float y) => (sbyte)((int)x & (int)y);

        /// <summary>
        /// Gets the AND of int and sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte And(this sbyte x, int y) => (sbyte)((int)x & (int)y);

        /// <summary>
        /// Gets the AND of long and sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte And(this sbyte x, long y) => (sbyte)((int)x & (int)y);

        /// <summary>
        /// Gets the AND of sbyte and sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte And(this sbyte x, sbyte y) => (sbyte)((int)x & (int)y);

        /// <summary>
        /// Gets the AND of short and sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte And(this sbyte x, short y) => (sbyte)((int)x & (int)y);

        /// <summary>
        /// Gets the AND of uint and sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte And(this sbyte x, uint y) => (sbyte)((int)x & (int)y);

        /// <summary>
        /// Gets the AND of ulong and sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte And(this sbyte x, ulong y) => (sbyte)((int)x & (int)y);

        /// <summary>
        /// Gets the AND of ushort and sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte And(this sbyte x, ushort y) => (sbyte)((int)x & (int)y);

        /// <summary>
        /// Tries to cast sbyte to byte, this can get ugly though
        /// </summary>
        /// <param name="x">The x <see cref="sbyte"/></param>
        /// <returns>The result of the operation</returns>
        public static byte CastSbyteToByte(this sbyte x) => (byte)x;

        /// <summary>
        /// Tries to cast sbyte to char, this can get ugly though
        /// </summary>
        /// <param name="x">The x <see cref="sbyte"/></param>
        /// <returns>The result of the operation</returns>
        public static char CastSbyteToChar(this sbyte x) => (char)x;

        /// <summary>
        /// Tries to cast sbyte to decimal, this can get ugly though
        /// </summary>
        /// <param name="x">The x <see cref="sbyte"/></param>
        /// <returns>The result of the operation</returns>
        public static decimal CastSbyteToDecimal(this sbyte x) => (decimal)x;

        /// <summary>
        /// Tries to cast sbyte to double, this can get ugly though
        /// </summary>
        /// <param name="x">The x <see cref="sbyte"/></param>
        /// <returns>The result of the operation</returns>
        public static double CastSbyteToDouble(this sbyte x) => (double)x;

        /// <summary>
        /// Tries to cast sbyte to float, this can get ugly though
        /// </summary>
        /// <param name="x">The x <see cref="sbyte"/></param>
        /// <returns>The result of the operation</returns>
        public static float CastSbyteToFloat(this sbyte x) => (float)x;

        /// <summary>
        /// Tries to cast sbyte to int, this can get ugly though
        /// </summary>
        /// <param name="x">The x <see cref="sbyte"/></param>
        /// <returns>The result of the operation</returns>
        public static int CastSbyteToInt(this sbyte x) => (int)x;

        /// <summary>
        /// Tries to cast sbyte to long, this can get ugly though
        /// </summary>
        /// <param name="x">The x <see cref="sbyte"/></param>
        /// <returns>The result of the operation</returns>
        public static long CastSbyteToLong(this sbyte x) => (long)x;

        /// <summary>
        /// Tries to cast sbyte to short, this can get ugly though
        /// </summary>
        /// <param name="x">The x <see cref="sbyte"/></param>
        /// <returns>The result of the operation</returns>
        public static short CastSbyteToShort(this sbyte x) => (short)x;

        /// <summary>
        /// Tries to cast sbyte to uint, this can get ugly though
        /// </summary>
        /// <param name="x">The x <see cref="sbyte"/></param>
        /// <returns>The result of the operation</returns>
        public static uint CastSbyteToUint(this sbyte x) => (uint)x;

        /// <summary>
        /// Tries to cast sbyte to ulong, this can get ugly though
        /// </summary>
        /// <param name="x">The x <see cref="sbyte"/></param>
        /// <returns>The result of the operation</returns>
        public static ulong CastSbyteToUlong(this sbyte x) => (ulong)x;

        /// <summary>
        /// Tries to cast sbyte to ushort, this can get ugly though
        /// </summary>
        /// <param name="x">The x <see cref="sbyte"/></param>
        /// <returns>The result of the operation</returns>
        public static ushort CastSbyteToUshort(this sbyte x) => (ushort)x;

        /// <summary>
        /// Compare original and second number
        /// </summary>
        /// <param name="first">The number</param>
        /// <param name="second">The number to compare with</param>
        /// <returns>The highest of the two numbers</returns>
        public static sbyte ChooseIfHigher(this sbyte first, sbyte second) => first > second ? first : second;

        /// <summary>
        /// Compare original and second number
        /// </summary>
        /// <param name="first">The number</param>
        /// <param name="second">The number to compare with</param>
        /// <returns>The lowest of the two numbers</returns>
        public static sbyte ChooseIfLower(this sbyte first, sbyte second) => first < second ? first : second;

        /// <summary>
        /// Divides byte from sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte DividedBy(this sbyte x, byte y) => (sbyte)((int)x / (int)y);

        /// <summary>
        /// Divides char from sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte DividedBy(this sbyte x, char y) => (sbyte)((int)x / (int)y);

        /// <summary>
        /// Divides decimal from sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte DividedBy(this sbyte x, decimal y) => (sbyte)((int)x / (int)y);

        /// <summary>
        /// Divides double from sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte DividedBy(this sbyte x, double y) => (sbyte)((int)x / (int)y);

        /// <summary>
        /// Divides float from sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte DividedBy(this sbyte x, float y) => (sbyte)((int)x / (int)y);

        /// <summary>
        /// Divides int from sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte DividedBy(this sbyte x, int y) => (sbyte)((int)x / (int)y);

        /// <summary>
        /// Divides long from sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte DividedBy(this sbyte x, long y) => (sbyte)((int)x / (int)y);

        /// <summary>
        /// Divides sbyte from sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte DividedBy(this sbyte x, sbyte y) => (sbyte)((int)x / (int)y);

        /// <summary>
        /// Divides short from sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte DividedBy(this sbyte x, short y) => (sbyte)((int)x / (int)y);

        /// <summary>
        /// Divides uint from sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte DividedBy(this sbyte x, uint y) => (sbyte)((int)x / (int)y);

        /// <summary>
        /// Divides ulong from sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte DividedBy(this sbyte x, ulong y) => (sbyte)((int)x / (int)y);

        /// <summary>
        /// Divides ushort from sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte DividedBy(this sbyte x, ushort y) => (sbyte)((int)x / (int)y);

        /// <summary>
        /// Gets a boolean True if sbyte is greater than byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this sbyte x, byte y) => x > (sbyte)y;

        /// <summary>
        /// Gets a boolean True if sbyte is greater than char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this sbyte x, char y) => x > (sbyte)y;

        /// <summary>
        /// Gets a boolean True if sbyte is greater than decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this sbyte x, decimal y) => x > (sbyte)y;

        /// <summary>
        /// Gets a boolean True if sbyte is greater than double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this sbyte x, double y) => x > (sbyte)y;

        /// <summary>
        /// Gets a boolean True if sbyte is greater than float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this sbyte x, float y) => x > (sbyte)y;

        /// <summary>
        /// Gets a boolean True if sbyte is greater than int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this sbyte x, int y) => x > (sbyte)y;

        /// <summary>
        /// Gets a boolean True if sbyte is greater than long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this sbyte x, long y) => x > (sbyte)y;

        /// <summary>
        /// Gets a boolean True if sbyte is greater than sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this sbyte x, sbyte y) => x > y;

        /// <summary>
        /// Gets a boolean True if sbyte is greater than short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this sbyte x, short y) => x > (sbyte)y;

        /// <summary>
        /// Gets a boolean True if sbyte is greater than uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this sbyte x, uint y) => x > (sbyte)y;

        /// <summary>
        /// Gets a boolean True if sbyte is greater than ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this sbyte x, ulong y) => x > (sbyte)y;

        /// <summary>
        /// Gets a boolean True if sbyte is greater than ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this sbyte x, ushort y) => x > (sbyte)y;

        /// <summary>
        /// Gets boolean True if byte is equal to sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this sbyte x, byte y) => x == (sbyte)y;

        /// <summary>
        /// Gets boolean True if char is equal to sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this sbyte x, char y) => x == (sbyte)y;

        /// <summary>
        /// Gets boolean True if decimal is equal to sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this sbyte x, decimal y) => x == (sbyte)y;

        /// <summary>
        /// Gets boolean True if double is equal to sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this sbyte x, double y) => x == (sbyte)y;

        /// <summary>
        /// Gets boolean True if float is equal to sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this sbyte x, float y) => x == (sbyte)y;

        /// <summary>
        /// Gets boolean True if int is equal to sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this sbyte x, int y) => x == (sbyte)y;

        /// <summary>
        /// Gets boolean True if long is equal to sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this sbyte x, long y) => x == (sbyte)y;

        /// <summary>
        /// Gets boolean True if sbyte is equal to sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this sbyte x, sbyte y) => x == y;

        /// <summary>
        /// Gets boolean True if short is equal to sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this sbyte x, short y) => x == (sbyte)y;

        /// <summary>
        /// Gets boolean True if uint is equal to sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this sbyte x, uint y) => x == (sbyte)y;

        /// <summary>
        /// Gets boolean True if ulong is equal to sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this sbyte x, ulong y) => x == (sbyte)y;

        /// <summary>
        /// Gets boolean True if ushort is equal to sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this sbyte x, ushort y) => x == (sbyte)y;

        /// <summary>
        /// Gets boolean true if value is less than zero
        /// </summary>
        /// <param name="x">The x <see cref="sbyte"/></param>
        /// <returns>The result of the operation</returns>
        public static bool IsNegative(this sbyte x) => x < 0;

        /// <summary>
        /// Gets boolean True if byte is not equal to sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this sbyte x, byte y) => x != (sbyte)y;

        /// <summary>
        /// Gets boolean True if char is not equal to sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this sbyte x, char y) => x != (sbyte)y;

        /// <summary>
        /// Gets boolean True if decimal is not equal to sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this sbyte x, decimal y) => x != (sbyte)y;

        /// <summary>
        /// Gets boolean True if double is not equal to sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this sbyte x, double y) => x != (sbyte)y;

        /// <summary>
        /// Gets boolean True if float is not equal to sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this sbyte x, float y) => x != (sbyte)y;

        /// <summary>
        /// Gets boolean True if int is not equal to sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this sbyte x, int y) => x != (sbyte)y;

        /// <summary>
        /// Gets boolean True if long is not equal to sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this sbyte x, long y) => x != (sbyte)y;

        /// <summary>
        /// Gets boolean True if sbyte is not equal to sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this sbyte x, sbyte y) => x != y;

        /// <summary>
        /// Gets boolean True if short is not equal to sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this sbyte x, short y) => x != (sbyte)y;

        /// <summary>
        /// Gets boolean True if uint is not equal to sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this sbyte x, uint y) => x != (sbyte)y;

        /// <summary>
        /// Gets boolean True if ulong is not equal to sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this sbyte x, ulong y) => x != (sbyte)y;

        /// <summary>
        /// Gets boolean True if ushort is not equal to sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this sbyte x, ushort y) => x != (sbyte)y;

        /// <summary>
        /// Gets boolean true if value is more than zero
        /// </summary>
        /// <param name="x">The x <see cref="sbyte"/></param>
        /// <returns>The result of the operation</returns>
        public static bool IsPositive(this sbyte x) => x >= 0;

        /// <summary>
        /// Checks if a number is prime
        /// </summary>
        /// <param name="number">The number</param>
        /// <returns>True if the number is prime</returns>
        public static bool IsPrime(this sbyte number) => Enumerable.Range(2, (int)Math.Sqrt(number) - 1).All(divisor => number % divisor != 0);

        /// <summary>
        /// Gets a boolean True if sbyte is less than byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this sbyte x, byte y) => x < (sbyte)y;

        /// <summary>
        /// Gets a boolean True if sbyte is less than char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this sbyte x, char y) => x < (sbyte)y;

        /// <summary>
        /// Gets a boolean True if sbyte is less than decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this sbyte x, decimal y) => x < (sbyte)y;

        /// <summary>
        /// Gets a boolean True if sbyte is less than double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this sbyte x, double y) => x < (sbyte)y;

        /// <summary>
        /// Gets a boolean True if sbyte is less than float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this sbyte x, float y) => x < (sbyte)y;

        /// <summary>
        /// Gets a boolean True if sbyte is less than int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this sbyte x, int y) => x < (sbyte)y;

        /// <summary>
        /// Gets a boolean True if sbyte is less than long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this sbyte x, long y) => x < (sbyte)y;

        /// <summary>
        /// Gets a boolean True if sbyte is less than sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this sbyte x, sbyte y) => x < y;

        /// <summary>
        /// Gets a boolean True if sbyte is less than short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this sbyte x, short y) => x < (sbyte)y;

        /// <summary>
        /// Gets a boolean True if sbyte is less than uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this sbyte x, uint y) => x < (sbyte)y;

        /// <summary>
        /// Gets a boolean True if sbyte is less than ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this sbyte x, ulong y) => x < (sbyte)y;

        /// <summary>
        /// Gets a boolean True if sbyte is less than ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this sbyte x, ushort y) => x < (sbyte)y;

        /// <summary>
        /// Gets the remainder of byte from sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte Modulus(this sbyte x, byte y) => (sbyte)((int)x % (int)y);

        /// <summary>
        /// Gets the remainder of char from sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte Modulus(this sbyte x, char y) => (sbyte)((int)x % (int)y);

        /// <summary>
        /// Gets the remainder of decimal from sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte Modulus(this sbyte x, decimal y) => (sbyte)((int)x % (int)y);

        /// <summary>
        /// Gets the remainder of double from sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte Modulus(this sbyte x, double y) => (sbyte)((int)x % (int)y);

        /// <summary>
        /// Gets the remainder of float from sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte Modulus(this sbyte x, float y) => (sbyte)((int)x % (int)y);

        /// <summary>
        /// Gets the remainder of int from sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte Modulus(this sbyte x, int y) => (sbyte)((int)x % (int)y);

        /// <summary>
        /// Gets the remainder of long from sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte Modulus(this sbyte x, long y) => (sbyte)((int)x % (int)y);

        /// <summary>
        /// Gets the remainder of sbyte from sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte Modulus(this sbyte x, sbyte y) => (sbyte)((int)x % (int)y);

        /// <summary>
        /// Gets the remainder of short from sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte Modulus(this sbyte x, short y) => (sbyte)((int)x % (int)y);

        /// <summary>
        /// Gets the remainder of uint from sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte Modulus(this sbyte x, uint y) => (sbyte)((int)x % (int)y);

        /// <summary>
        /// Gets the remainder of ulong from sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte Modulus(this sbyte x, ulong y) => (sbyte)((int)x % (int)y);

        /// <summary>
        /// Gets the remainder of ushort from sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte Modulus(this sbyte x, ushort y) => (sbyte)((int)x % (int)y);

        /// <summary>
        /// Multiplies byte with sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte MultipliedWith(this sbyte x, byte y) => (sbyte)((int)x * (int)y);

        /// <summary>
        /// Multiplies char with sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte MultipliedWith(this sbyte x, char y) => (sbyte)((int)x * (int)y);

        /// <summary>
        /// Multiplies decimal with sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte MultipliedWith(this sbyte x, decimal y) => (sbyte)((int)x * (int)y);

        /// <summary>
        /// Multiplies double with sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte MultipliedWith(this sbyte x, double y) => (sbyte)((int)x * (int)y);

        /// <summary>
        /// Multiplies float with sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte MultipliedWith(this sbyte x, float y) => (sbyte)((int)x * (int)y);

        /// <summary>
        /// Multiplies int with sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte MultipliedWith(this sbyte x, int y) => (sbyte)((int)x * (int)y);

        /// <summary>
        /// Multiplies long with sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte MultipliedWith(this sbyte x, long y) => (sbyte)((int)x * (int)y);

        /// <summary>
        /// Multiplies sbyte with sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte MultipliedWith(this sbyte x, sbyte y) => (sbyte)((int)x * (int)y);

        /// <summary>
        /// Multiplies short with sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte MultipliedWith(this sbyte x, short y) => (sbyte)((int)x * (int)y);

        /// <summary>
        /// Multiplies uint with sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte MultipliedWith(this sbyte x, uint y) => (sbyte)((int)x * (int)y);

        /// <summary>
        /// Multiplies ulong with sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte MultipliedWith(this sbyte x, ulong y) => (sbyte)((int)x * (int)y);

        /// <summary>
        /// Multiplies ushort with sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte MultipliedWith(this sbyte x, ushort y) => (sbyte)((int)x * (int)y);

        /// <summary>
        /// Gets the NOT of sbyte
        /// </summary>
        /// <param name="x">The x <see cref="sbyte"/></param>
        /// <returns>The result of the operation</returns>
        public static sbyte Not(this sbyte x) => (sbyte)~(int)x;

        /// <summary>
        /// Gets the OR of byte and sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte Or(this sbyte x, byte y) => (sbyte)((int)x | (int)y);

        /// <summary>
        /// Gets the OR of char and sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte Or(this sbyte x, char y) => (sbyte)((int)x | (int)y);

        /// <summary>
        /// Gets the OR of decimal and sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte Or(this sbyte x, decimal y) => (sbyte)((int)x | (int)y);

        /// <summary>
        /// Gets the OR of double and sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte Or(this sbyte x, double y) => (sbyte)((int)x | (int)y);

        /// <summary>
        /// Gets the OR of float and sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte Or(this sbyte x, float y) => (sbyte)((int)x | (int)y);

        /// <summary>
        /// Gets the OR of int and sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte Or(this sbyte x, int y) => (sbyte)((int)x | (int)y);

        /// <summary>
        /// Gets the OR of long and sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte Or(this sbyte x, long y) => (sbyte)((int)x | (int)y);

        /// <summary>
        /// Gets the OR of sbyte and sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte Or(this sbyte x, sbyte y) => (sbyte)((int)x | (int)y);

        /// <summary>
        /// Gets the OR of short and sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte Or(this sbyte x, short y) => (sbyte)((int)x | (int)y);

        /// <summary>
        /// Gets the OR of uint and sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte Or(this sbyte x, uint y) => (sbyte)((int)x | (int)y);

        /// <summary>
        /// Gets the OR of ulong and sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte Or(this sbyte x, ulong y) => (sbyte)((int)x | (int)y);

        /// <summary>
        /// Gets the OR of ushort and sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte Or(this sbyte x, ushort y) => (sbyte)((int)x | (int)y);

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static sbyte PercentOf(this sbyte percent, byte value) => (sbyte)(((sbyte)percent) / ((sbyte)100) * ((sbyte)value));

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static sbyte PercentOf(this sbyte percent, char value) => (sbyte)(((sbyte)percent) / ((sbyte)100) * ((sbyte)value));

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static sbyte PercentOf(this sbyte percent, decimal value) => (sbyte)(((sbyte)percent) / ((sbyte)100) * ((sbyte)value));

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static sbyte PercentOf(this sbyte percent, double value) => (sbyte)(((sbyte)percent) / ((sbyte)100) * ((sbyte)value));

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static sbyte PercentOf(this sbyte percent, float value) => (sbyte)(((sbyte)percent) / ((sbyte)100) * ((sbyte)value));

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static sbyte PercentOf(this sbyte percent, int value) => (sbyte)(((sbyte)percent) / ((sbyte)100) * ((sbyte)value));

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static sbyte PercentOf(this sbyte percent, long value) => (sbyte)(((sbyte)percent) / ((sbyte)100) * ((sbyte)value));

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static sbyte PercentOf(this sbyte percent, sbyte value) => (sbyte)(((sbyte)percent) / ((sbyte)100) * ((sbyte)value));

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static sbyte PercentOf(this sbyte percent, short value) => (sbyte)(((sbyte)percent) / ((sbyte)100) * ((sbyte)value));

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static sbyte PercentOf(this sbyte percent, uint value) => (sbyte)(((sbyte)percent) / ((sbyte)100) * ((sbyte)value));

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static sbyte PercentOf(this sbyte percent, ulong value) => (sbyte)(((sbyte)percent) / ((sbyte)100) * ((sbyte)value));

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static sbyte PercentOf(this sbyte percent, ushort value) => (sbyte)(((sbyte)percent) / ((sbyte)100) * ((sbyte)value));

        /// <summary>
        /// Compare original and second number and set the variable with the highest
        /// </summary>
        /// <param name="first">The variable</param>
        /// <param name="second">The number to compare</param>
        /// <param name="third">The number to compare with</param>
        /// <returns>Sets the variable to the highest of the two numbers</returns>
        public static ref sbyte SetHighestValueOf(this ref sbyte first, sbyte second, sbyte third)
        {
            first = second > third ? second : third;
            return ref first;
        }

        /// <summary>
        /// Compare original and second number and set the variable with the lowest
        /// </summary>
        /// <param name="first">The number</param>
        /// <param name="second">The number to compare with</param>
        /// <param name="third">The third <see cref="sbyte"/></param>
        /// <returns>Sets the variable to the lowest of the two numbers</returns>
        public static ref sbyte SetLowestValueOf(this ref sbyte first, sbyte second, sbyte third)
        {
            first = second < third ? second : third;
            return ref first;
        }

        /// <summary>
        /// Gets shift left of byte from sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte ShiftLeft(this sbyte x, byte y) => (sbyte)((int)x << (int)y);

        /// <summary>
        /// Gets shift left of char from sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte ShiftLeft(this sbyte x, char y) => (sbyte)((int)x << (int)y);

        /// <summary>
        /// Gets shift left of decimal from sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte ShiftLeft(this sbyte x, decimal y) => (sbyte)((int)x << (int)y);

        /// <summary>
        /// Gets shift left of double from sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte ShiftLeft(this sbyte x, double y) => (sbyte)((int)x << (int)y);

        /// <summary>
        /// Gets shift left of float from sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte ShiftLeft(this sbyte x, float y) => (sbyte)((int)x << (int)y);

        /// <summary>
        /// Gets shift left of int from sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte ShiftLeft(this sbyte x, int y) => (sbyte)((int)x << (int)y);

        /// <summary>
        /// Gets shift left of long from sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte ShiftLeft(this sbyte x, long y) => (sbyte)((int)x << (int)y);

        /// <summary>
        /// Gets shift left of sbyte from sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte ShiftLeft(this sbyte x, sbyte y) => (sbyte)((int)x << (int)y);

        /// <summary>
        /// Gets shift left of short from sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte ShiftLeft(this sbyte x, short y) => (sbyte)((int)x << (int)y);

        /// <summary>
        /// Gets shift left of uint from sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte ShiftLeft(this sbyte x, uint y) => (sbyte)((int)x << (int)y);

        /// <summary>
        /// Gets shift left of ulong from sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte ShiftLeft(this sbyte x, ulong y) => (sbyte)((int)x << (int)y);

        /// <summary>
        /// Gets shift left of ushort from sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte ShiftLeft(this sbyte x, ushort y) => (sbyte)((int)x << (int)y);

        /// <summary>
        /// Gets shift right of byte from sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte ShiftRight(this sbyte x, byte y) => (sbyte)((int)x >> (int)y);

        /// <summary>
        /// Gets shift right of char from sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte ShiftRight(this sbyte x, char y) => (sbyte)((int)x >> (int)y);

        /// <summary>
        /// Gets shift right of decimal from sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte ShiftRight(this sbyte x, decimal y) => (sbyte)((int)x >> (int)y);

        /// <summary>
        /// Gets shift right of double from sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte ShiftRight(this sbyte x, double y) => (sbyte)((int)x >> (int)y);

        /// <summary>
        /// Gets shift right of float from sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte ShiftRight(this sbyte x, float y) => (sbyte)((int)x >> (int)y);

        /// <summary>
        /// Gets shift right of int from sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte ShiftRight(this sbyte x, int y) => (sbyte)((int)x >> (int)y);

        /// <summary>
        /// Gets shift right of long from sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte ShiftRight(this sbyte x, long y) => (sbyte)((int)x >> (int)y);

        /// <summary>
        /// Gets shift right of sbyte from sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte ShiftRight(this sbyte x, sbyte y) => (sbyte)((int)x >> (int)y);

        /// <summary>
        /// Gets shift right of short from sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte ShiftRight(this sbyte x, short y) => (sbyte)((int)x >> (int)y);

        /// <summary>
        /// Gets shift right of uint from sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte ShiftRight(this sbyte x, uint y) => (sbyte)((int)x >> (int)y);

        /// <summary>
        /// Gets shift right of ulong from sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte ShiftRight(this sbyte x, ulong y) => (sbyte)((int)x >> (int)y);

        /// <summary>
        /// Gets shift right of ushort from sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte ShiftRight(this sbyte x, ushort y) => (sbyte)((int)x >> (int)y);

        /// <summary>
        /// Subtracts byte from sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(sbyte,byte) instead.", false)]
        public static sbyte Substract(this sbyte x, byte y) => (sbyte)((int)x - (int)y);

        /// <summary>
        /// Subtracts char from sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(sbyte,char) instead.", false)]
        public static sbyte Substract(this sbyte x, char y) => (sbyte)((int)x - (int)y);

        /// <summary>
        /// Subtracts decimal from sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(sbyte,decimal) instead.", false)]
        public static sbyte Substract(this sbyte x, decimal y) => (sbyte)((int)x - (int)y);

        /// <summary>
        /// Subtracts double from sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(sbyte,double) instead.", false)]
        public static sbyte Substract(this sbyte x, double y) => (sbyte)((int)x - (int)y);

        /// <summary>
        /// Subtracts float from sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(sbyte,float) instead.", false)]
        public static sbyte Substract(this sbyte x, float y) => (sbyte)((int)x - (int)y);

        /// <summary>
        /// Subtracts int from sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(sbyte,int) instead.", false)]
        public static sbyte Substract(this sbyte x, int y) => (sbyte)((int)x - (int)y);

        /// <summary>
        /// Subtracts long from sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(sbyte,long) instead.", false)]
        public static sbyte Substract(this sbyte x, long y) => (sbyte)((int)x - (int)y);

        /// <summary>
        /// Subtracts sbyte from sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(sbyte,sbyte) instead.", false)]
        public static sbyte Substract(this sbyte x, sbyte y) => (sbyte)((int)x - (int)y);

        /// <summary>
        /// Subtracts short from sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(sbyte,short) instead.", false)]
        public static sbyte Substract(this sbyte x, short y) => (sbyte)((int)x - (int)y);

        /// <summary>
        /// Subtracts uint from sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(sbyte,uint) instead.", false)]
        public static sbyte Substract(this sbyte x, uint y) => (sbyte)((int)x - (int)y);

        /// <summary>
        /// Subtracts ulong from sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(sbyte,ulong) instead.", false)]
        public static sbyte Substract(this sbyte x, ulong y) => (sbyte)((int)x - (int)y);

        /// <summary>
        /// Subtracts ushort from sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(sbyte,ushort) instead.", false)]
        public static sbyte Substract(this sbyte x, ushort y) => (sbyte)((int)x - (int)y);

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(byte) instead.", false)]
        public static sbyte SubstractPercent(this sbyte value, byte percent) => (sbyte)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(char) instead.", false)]
        public static sbyte SubstractPercent(this sbyte value, char percent) => (sbyte)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(decimal) instead.", false)]
        public static sbyte SubstractPercent(this sbyte value, decimal percent) => (sbyte)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(double) instead.", false)]
        public static sbyte SubstractPercent(this sbyte value, double percent) => (sbyte)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(float) instead.", false)]
        public static sbyte SubstractPercent(this sbyte value, float percent) => (sbyte)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(int) instead.", false)]
        public static sbyte SubstractPercent(this sbyte value, int percent) => (sbyte)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(long) instead.", false)]
        public static sbyte SubstractPercent(this sbyte value, long percent) => (sbyte)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(sbyte) instead.", false)]
        public static sbyte SubstractPercent(this sbyte value, sbyte percent) => (sbyte)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(short) instead.", false)]
        public static sbyte SubstractPercent(this sbyte value, short percent) => (sbyte)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(uint) instead.", false)]
        public static sbyte SubstractPercent(this sbyte value, uint percent) => (sbyte)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(ulong) instead.", false)]
        public static sbyte SubstractPercent(this sbyte value, ulong percent) => (sbyte)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(ushort) instead.", false)]
        public static sbyte SubstractPercent(this sbyte value, ushort percent) => (sbyte)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts byte from sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte Subtract(this sbyte x, byte y) => (sbyte)((int)x - (int)y);

        /// <summary>
        /// Subtracts char from sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte Subtract(this sbyte x, char y) => (sbyte)((int)x - (int)y);

        /// <summary>
        /// Subtracts decimal from sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte Subtract(this sbyte x, decimal y) => (sbyte)((int)x - (int)y);

        /// <summary>
        /// Subtracts double from sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte Subtract(this sbyte x, double y) => (sbyte)((int)x - (int)y);

        /// <summary>
        /// Subtracts float from sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte Subtract(this sbyte x, float y) => (sbyte)((int)x - (int)y);

        /// <summary>
        /// Subtracts int from sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte Subtract(this sbyte x, int y) => (sbyte)((int)x - (int)y);

        /// <summary>
        /// Subtracts long from sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte Subtract(this sbyte x, long y) => (sbyte)((int)x - (int)y);

        /// <summary>
        /// Subtracts sbyte from sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte Subtract(this sbyte x, sbyte y) => (sbyte)((int)x - (int)y);

        /// <summary>
        /// Subtracts short from sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte Subtract(this sbyte x, short y) => (sbyte)((int)x - (int)y);

        /// <summary>
        /// Subtracts uint from sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte Subtract(this sbyte x, uint y) => (sbyte)((int)x - (int)y);

        /// <summary>
        /// Subtracts ulong from sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte Subtract(this sbyte x, ulong y) => (sbyte)((int)x - (int)y);

        /// <summary>
        /// Subtracts ushort from sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte Subtract(this sbyte x, ushort y) => (sbyte)((int)x - (int)y);

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static sbyte SubtractPercent(this sbyte value, byte percent) => (sbyte)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static sbyte SubtractPercent(this sbyte value, char percent) => (sbyte)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static sbyte SubtractPercent(this sbyte value, decimal percent) => (sbyte)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static sbyte SubtractPercent(this sbyte value, double percent) => (sbyte)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static sbyte SubtractPercent(this sbyte value, float percent) => (sbyte)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static sbyte SubtractPercent(this sbyte value, int percent) => (sbyte)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static sbyte SubtractPercent(this sbyte value, long percent) => (sbyte)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static sbyte SubtractPercent(this sbyte value, sbyte percent) => (sbyte)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static sbyte SubtractPercent(this sbyte value, short percent) => (sbyte)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static sbyte SubtractPercent(this sbyte value, uint percent) => (sbyte)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static sbyte SubtractPercent(this sbyte value, ulong percent) => (sbyte)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static sbyte SubtractPercent(this sbyte value, ushort percent) => (sbyte)(value - value.PercentOf(percent));

        /// <summary>
        /// Swaps two variables
        /// </summary>
        /// <param name="first">The main variable</param>
        /// <param name="second">The variable to switch with</param>
        /// <returns>
        /// The value from the second variable and sets second variable to original value
        /// </returns>
        public static ref sbyte SwapWith(this ref sbyte first, ref sbyte second)
        {
            var tmp = second;
            second = first;
            first = tmp;
            return ref first;
        }

        /// <summary>
        /// Gets XOR of byte of sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte Xor(this sbyte x, byte y) => (sbyte)((int)x ^ (int)y);

        /// <summary>
        /// Gets XOR of char of sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte Xor(this sbyte x, char y) => (sbyte)((int)x ^ (int)y);

        /// <summary>
        /// Gets XOR of decimal of sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte Xor(this sbyte x, decimal y) => (sbyte)((int)x ^ (int)y);

        /// <summary>
        /// Gets XOR of double of sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte Xor(this sbyte x, double y) => (sbyte)((int)x ^ (int)y);

        /// <summary>
        /// Gets XOR of float of sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte Xor(this sbyte x, float y) => (sbyte)((int)x ^ (int)y);

        /// <summary>
        /// Gets XOR of int of sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte Xor(this sbyte x, int y) => (sbyte)((int)x ^ (int)y);

        /// <summary>
        /// Gets XOR of long of sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte Xor(this sbyte x, long y) => (sbyte)((int)x ^ (int)y);

        /// <summary>
        /// Gets XOR of sbyte of sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte Xor(this sbyte x, sbyte y) => (sbyte)((int)x ^ (int)y);

        /// <summary>
        /// Gets XOR of short of sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte Xor(this sbyte x, short y) => (sbyte)((int)x ^ (int)y);

        /// <summary>
        /// Gets XOR of uint of sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte Xor(this sbyte x, uint y) => (sbyte)((int)x ^ (int)y);

        /// <summary>
        /// Gets XOR of ulong of sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte Xor(this sbyte x, ulong y) => (sbyte)((int)x ^ (int)y);

        /// <summary>
        /// Gets XOR of ushort of sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte Xor(this sbyte x, ushort y) => (sbyte)((int)x ^ (int)y);
    }
}