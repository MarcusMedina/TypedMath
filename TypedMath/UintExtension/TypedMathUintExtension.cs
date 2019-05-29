//----------------------------------------------------------------------------------------------
// <copyright file="TypedMathUintExtension.cs" company="MarcusMedinaPro">
// By Marcus Medina, 2019 - http://MarcusMedina.Pro
// This file is subject to the terms and conditions defined in file 'license.txt', which is part of this project.
// </copyright>
// ----------------------------------------------------------------------------------------------
// Credits for borrowed code:
// LinQ Primenumbers, Zoran Horvat: http://www.codinghelmet.com/articles/linq-all-primes/
// ----------------------------------------------------------------------------------------------

namespace MarcusMedinaPro.TypedMath.UintExtension
{
    using System;
    using System.Linq;

    /// <summary>
    /// Extension for uint
    /// </summary>
    public static class TypedMathUintExtension
    {
        /// <summary>
        /// Adds byte to uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Add(this uint x, byte y) => x + (uint)y;

        /// <summary>
        /// Adds char to uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Add(this uint x, char y) => x + (uint)y;

        /// <summary>
        /// Adds decimal to uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Add(this uint x, decimal y) => x + (uint)y;

        /// <summary>
        /// Adds double to uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Add(this uint x, double y) => x + (uint)y;

        /// <summary>
        /// Adds float to uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Add(this uint x, float y) => x + (uint)y;

        /// <summary>
        /// Adds int to uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Add(this uint x, int y) => x + (uint)y;

        /// <summary>
        /// Adds long to uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Add(this uint x, long y) => x + (uint)y;

        /// <summary>
        /// Adds sbyte to uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Add(this uint x, sbyte y) => x + (uint)y;

        /// <summary>
        /// Adds short to uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Add(this uint x, short y) => x + (uint)y;

        /// <summary>
        /// Adds uint to uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Add(this uint x, uint y) => x + y;

        /// <summary>
        /// Adds ulong to uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Add(this uint x, ulong y) => x + (uint)y;

        /// <summary>
        /// Adds ushort to uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Add(this uint x, ushort y) => x + (uint)y;

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static uint AddPercent(this uint value, byte percent) => (uint)(value + value.PercentOf(percent));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static uint AddPercent(this uint value, char percent) => (uint)(value + value.PercentOf(percent));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static uint AddPercent(this uint value, decimal percent) => (uint)(value + value.PercentOf(percent));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static uint AddPercent(this uint value, double percent) => (uint)(value + value.PercentOf(percent));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static uint AddPercent(this uint value, float percent) => (uint)(value + value.PercentOf(percent));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static uint AddPercent(this uint value, int percent) => (uint)(value + value.PercentOf(percent));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static uint AddPercent(this uint value, long percent) => (uint)(value + value.PercentOf(percent));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static uint AddPercent(this uint value, sbyte percent) => (uint)(value + value.PercentOf(percent));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static uint AddPercent(this uint value, short percent) => (uint)(value + value.PercentOf(percent));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static uint AddPercent(this uint value, uint percent) => (uint)(value + value.PercentOf(percent));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static uint AddPercent(this uint value, ulong percent) => (uint)(value + value.PercentOf(percent));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static uint AddPercent(this uint value, ushort percent) => (uint)(value + value.PercentOf(percent));

        /// <summary>
        /// Gets the AND of byte and uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint And(this uint x, byte y) => x & (uint)y;

        /// <summary>
        /// Gets the AND of char and uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint And(this uint x, char y) => x & (uint)y;

        /// <summary>
        /// Gets the AND of decimal and uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint And(this uint x, decimal y) => x & (uint)y;

        /// <summary>
        /// Gets the AND of double and uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint And(this uint x, double y) => x & (uint)y;

        /// <summary>
        /// Gets the AND of float and uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint And(this uint x, float y) => x & (uint)y;

        /// <summary>
        /// Gets the AND of int and uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint And(this uint x, int y) => x & (uint)y;

        /// <summary>
        /// Gets the AND of long and uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint And(this uint x, long y) => x & (uint)y;

        /// <summary>
        /// Gets the AND of sbyte and uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint And(this uint x, sbyte y) => x & (uint)y;

        /// <summary>
        /// Gets the AND of short and uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint And(this uint x, short y) => x & (uint)y;

        /// <summary>
        /// Gets the AND of uint and uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint And(this uint x, uint y) => x & y;

        /// <summary>
        /// Gets the AND of ulong and uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint And(this uint x, ulong y) => x & (uint)y;

        /// <summary>
        /// Gets the AND of ushort and uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint And(this uint x, ushort y) => x & (uint)y;

        /// <summary>
        /// Tries to cast uint to byte, this can get ugly though
        /// </summary>
        /// <param name="x">The x <see cref="uint"/></param>
        /// <returns>The result of the operation</returns>
        public static byte CastUintToByte(this uint x) => (byte)x;

        /// <summary>
        /// Tries to cast uint to char, this can get ugly though
        /// </summary>
        /// <param name="x">The x <see cref="uint"/></param>
        /// <returns>The result of the operation</returns>
        public static char CastUintToChar(this uint x) => (char)x;

        /// <summary>
        /// Tries to cast uint to decimal, this can get ugly though
        /// </summary>
        /// <param name="x">The x <see cref="uint"/></param>
        /// <returns>The result of the operation</returns>
        public static decimal CastUintToDecimal(this uint x) => (decimal)x;

        /// <summary>
        /// Tries to cast uint to double, this can get ugly though
        /// </summary>
        /// <param name="x">The x <see cref="uint"/></param>
        /// <returns>The result of the operation</returns>
        public static double CastUintToDouble(this uint x) => (double)x;

        /// <summary>
        /// Tries to cast uint to float, this can get ugly though
        /// </summary>
        /// <param name="x">The x <see cref="uint"/></param>
        /// <returns>The result of the operation</returns>
        public static float CastUintToFloat(this uint x) => (float)x;

        /// <summary>
        /// Tries to cast uint to int, this can get ugly though
        /// </summary>
        /// <param name="x">The x <see cref="uint"/></param>
        /// <returns>The result of the operation</returns>
        public static int CastUintToInt(this uint x) => (int)x;

        /// <summary>
        /// Tries to cast uint to long, this can get ugly though
        /// </summary>
        /// <param name="x">The x <see cref="uint"/></param>
        /// <returns>The result of the operation</returns>
        public static long CastUintToLong(this uint x) => (long)x;

        /// <summary>
        /// Tries to cast uint to sbyte, this can get ugly though
        /// </summary>
        /// <param name="x">The x <see cref="uint"/></param>
        /// <returns>The result of the operation</returns>
        public static sbyte CastUintToSbyte(this uint x) => (sbyte)x;

        /// <summary>
        /// Tries to cast uint to short, this can get ugly though
        /// </summary>
        /// <param name="x">The x <see cref="uint"/></param>
        /// <returns>The result of the operation</returns>
        public static short CastUintToShort(this uint x) => (short)x;

        /// <summary>
        /// Tries to cast uint to ulong, this can get ugly though
        /// </summary>
        /// <param name="x">The x <see cref="uint"/></param>
        /// <returns>The result of the operation</returns>
        public static ulong CastUintToUlong(this uint x) => (ulong)x;

        /// <summary>
        /// Tries to cast uint to ushort, this can get ugly though
        /// </summary>
        /// <param name="x">The x <see cref="uint"/></param>
        /// <returns>The result of the operation</returns>
        public static ushort CastUintToUshort(this uint x) => (ushort)x;

        /// <summary>
        /// Compare original and second number
        /// </summary>
        /// <param name="first">The number</param>
        /// <param name="second">The number to compare with</param>
        /// <returns>The highest of the two numbers</returns>
        public static uint ChooseIfHigher(this uint first, uint second) => first > second ? first : second;

        /// <summary>
        /// Compare original and second number
        /// </summary>
        /// <param name="first">The number</param>
        /// <param name="second">The number to compare with</param>
        /// <returns>The lowest of the two numbers</returns>
        public static uint ChooseIfLower(this uint first, uint second) => first < second ? first : second;

        /// <summary>
        /// Divides byte from uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint DividedBy(this uint x, byte y) => x / (uint)y;

        /// <summary>
        /// Divides char from uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint DividedBy(this uint x, char y) => x / (uint)y;

        /// <summary>
        /// Divides decimal from uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint DividedBy(this uint x, decimal y) => x / (uint)y;

        /// <summary>
        /// Divides double from uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint DividedBy(this uint x, double y) => x / (uint)y;

        /// <summary>
        /// Divides float from uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint DividedBy(this uint x, float y) => x / (uint)y;

        /// <summary>
        /// Divides int from uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint DividedBy(this uint x, int y) => x / (uint)y;

        /// <summary>
        /// Divides long from uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint DividedBy(this uint x, long y) => x / (uint)y;

        /// <summary>
        /// Divides sbyte from uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint DividedBy(this uint x, sbyte y) => x / (uint)y;

        /// <summary>
        /// Divides short from uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint DividedBy(this uint x, short y) => x / (uint)y;

        /// <summary>
        /// Divides uint from uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint DividedBy(this uint x, uint y) => x / y;

        /// <summary>
        /// Divides ulong from uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint DividedBy(this uint x, ulong y) => x / (uint)y;

        /// <summary>
        /// Divides ushort from uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint DividedBy(this uint x, ushort y) => x / (uint)y;

        /// <summary>
        /// Gets a boolean True if uint is greater than byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this uint x, byte y) => x > (uint)y;

        /// <summary>
        /// Gets a boolean True if uint is greater than char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this uint x, char y) => x > (uint)y;

        /// <summary>
        /// Gets a boolean True if uint is greater than decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this uint x, decimal y) => x > (uint)y;

        /// <summary>
        /// Gets a boolean True if uint is greater than double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this uint x, double y) => x > (uint)y;

        /// <summary>
        /// Gets a boolean True if uint is greater than float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this uint x, float y) => x > (uint)y;

        /// <summary>
        /// Gets a boolean True if uint is greater than int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this uint x, int y) => x > (uint)y;

        /// <summary>
        /// Gets a boolean True if uint is greater than long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this uint x, long y) => x > (uint)y;

        /// <summary>
        /// Gets a boolean True if uint is greater than sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this uint x, sbyte y) => x > (uint)y;

        /// <summary>
        /// Gets a boolean True if uint is greater than short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this uint x, short y) => x > (uint)y;

        /// <summary>
        /// Gets a boolean True if uint is greater than uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this uint x, uint y) => x > y;

        /// <summary>
        /// Gets a boolean True if uint is greater than ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this uint x, ulong y) => x > (uint)y;

        /// <summary>
        /// Gets a boolean True if uint is greater than ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this uint x, ushort y) => x > (uint)y;

        /// <summary>
        /// Gets boolean True if byte is equal to uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this uint x, byte y) => x == (uint)y;

        /// <summary>
        /// Gets boolean True if char is equal to uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this uint x, char y) => x == (uint)y;

        /// <summary>
        /// Gets boolean True if decimal is equal to uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this uint x, decimal y) => x == (uint)y;

        /// <summary>
        /// Gets boolean True if double is equal to uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this uint x, double y) => x == (uint)y;

        /// <summary>
        /// Gets boolean True if float is equal to uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this uint x, float y) => x == (uint)y;

        /// <summary>
        /// Gets boolean True if int is equal to uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this uint x, int y) => x == (uint)y;

        /// <summary>
        /// Gets boolean True if long is equal to uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this uint x, long y) => x == (uint)y;

        /// <summary>
        /// Gets boolean True if sbyte is equal to uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this uint x, sbyte y) => x == (uint)y;

        /// <summary>
        /// Gets boolean True if short is equal to uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this uint x, short y) => x == (uint)y;

        /// <summary>
        /// Gets boolean True if uint is equal to uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this uint x, uint y) => x == y;

        /// <summary>
        /// Gets boolean True if ulong is equal to uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this uint x, ulong y) => x == (uint)y;

        /// <summary>
        /// Gets boolean True if ushort is equal to uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this uint x, ushort y) => x == (uint)y;

        /// <summary>
        /// Gets boolean True if byte is not equal to uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this uint x, byte y) => x != (uint)y;

        /// <summary>
        /// Gets boolean True if char is not equal to uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this uint x, char y) => x != (uint)y;

        /// <summary>
        /// Gets boolean True if decimal is not equal to uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this uint x, decimal y) => x != (uint)y;

        /// <summary>
        /// Gets boolean True if double is not equal to uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this uint x, double y) => x != (uint)y;

        /// <summary>
        /// Gets boolean True if float is not equal to uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this uint x, float y) => x != (uint)y;

        /// <summary>
        /// Gets boolean True if int is not equal to uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this uint x, int y) => x != (uint)y;

        /// <summary>
        /// Gets boolean True if long is not equal to uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this uint x, long y) => x != (uint)y;

        /// <summary>
        /// Gets boolean True if sbyte is not equal to uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this uint x, sbyte y) => x != (uint)y;

        /// <summary>
        /// Gets boolean True if short is not equal to uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this uint x, short y) => x != (uint)y;

        /// <summary>
        /// Gets boolean True if uint is not equal to uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this uint x, uint y) => x != y;

        /// <summary>
        /// Gets boolean True if ulong is not equal to uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this uint x, ulong y) => x != (uint)y;

        /// <summary>
        /// Gets boolean True if ushort is not equal to uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this uint x, ushort y) => x != (uint)y;

        /// <summary>
        /// Checks if a number is prime
        /// </summary>
        /// <param name="number">The number</param>
        /// <returns>True if the number is prime</returns>
        public static bool IsPrime(this uint number) => Enumerable.Range(2, (int)Math.Sqrt(number) - 1).All(divisor => (int)number % divisor != 0);

        /// <summary>
        /// Gets a boolean True if uint is less than byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this uint x, byte y) => x < (uint)y;

        /// <summary>
        /// Gets a boolean True if uint is less than char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this uint x, char y) => x < (uint)y;

        /// <summary>
        /// Gets a boolean True if uint is less than decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this uint x, decimal y) => x < (uint)y;

        /// <summary>
        /// Gets a boolean True if uint is less than double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this uint x, double y) => x < (uint)y;

        /// <summary>
        /// Gets a boolean True if uint is less than float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this uint x, float y) => x < (uint)y;

        /// <summary>
        /// Gets a boolean True if uint is less than int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this uint x, int y) => x < (uint)y;

        /// <summary>
        /// Gets a boolean True if uint is less than long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this uint x, long y) => x < (uint)y;

        /// <summary>
        /// Gets a boolean True if uint is less than sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this uint x, sbyte y) => x < (uint)y;

        /// <summary>
        /// Gets a boolean True if uint is less than short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this uint x, short y) => x < (uint)y;

        /// <summary>
        /// Gets a boolean True if uint is less than uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this uint x, uint y) => x < y;

        /// <summary>
        /// Gets a boolean True if uint is less than ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this uint x, ulong y) => x < (uint)y;

        /// <summary>
        /// Gets a boolean True if uint is less than ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this uint x, ushort y) => x < (uint)y;

        /// <summary>
        /// Gets the remainder of byte from uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Modulus(this uint x, byte y) => x % (uint)y;

        /// <summary>
        /// Gets the remainder of char from uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Modulus(this uint x, char y) => x % (uint)y;

        /// <summary>
        /// Gets the remainder of decimal from uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Modulus(this uint x, decimal y) => x % (uint)y;

        /// <summary>
        /// Gets the remainder of double from uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Modulus(this uint x, double y) => x % (uint)y;

        /// <summary>
        /// Gets the remainder of float from uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Modulus(this uint x, float y) => x % (uint)y;

        /// <summary>
        /// Gets the remainder of int from uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Modulus(this uint x, int y) => x % (uint)y;

        /// <summary>
        /// Gets the remainder of long from uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Modulus(this uint x, long y) => x % (uint)y;

        /// <summary>
        /// Gets the remainder of sbyte from uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Modulus(this uint x, sbyte y) => x % (uint)y;

        /// <summary>
        /// Gets the remainder of short from uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Modulus(this uint x, short y) => x % (uint)y;

        /// <summary>
        /// Gets the remainder of uint from uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Modulus(this uint x, uint y) => x % y;

        /// <summary>
        /// Gets the remainder of ulong from uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Modulus(this uint x, ulong y) => x % (uint)y;

        /// <summary>
        /// Gets the remainder of ushort from uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Modulus(this uint x, ushort y) => x % (uint)y;

        /// <summary>
        /// Multiplies byte with uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint MultipliedWith(this uint x, byte y) => x * (uint)y;

        /// <summary>
        /// Multiplies char with uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint MultipliedWith(this uint x, char y) => x * (uint)y;

        /// <summary>
        /// Multiplies decimal with uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint MultipliedWith(this uint x, decimal y) => x * (uint)y;

        /// <summary>
        /// Multiplies double with uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint MultipliedWith(this uint x, double y) => x * (uint)y;

        /// <summary>
        /// Multiplies float with uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint MultipliedWith(this uint x, float y) => x * (uint)y;

        /// <summary>
        /// Multiplies int with uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint MultipliedWith(this uint x, int y) => x * (uint)y;

        /// <summary>
        /// Multiplies long with uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint MultipliedWith(this uint x, long y) => x * (uint)y;

        /// <summary>
        /// Multiplies sbyte with uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint MultipliedWith(this uint x, sbyte y) => x * (uint)y;

        /// <summary>
        /// Multiplies short with uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint MultipliedWith(this uint x, short y) => x * (uint)y;

        /// <summary>
        /// Multiplies uint with uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint MultipliedWith(this uint x, uint y) => x * y;

        /// <summary>
        /// Multiplies ulong with uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint MultipliedWith(this uint x, ulong y) => x * (uint)y;

        /// <summary>
        /// Multiplies ushort with uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint MultipliedWith(this uint x, ushort y) => x * (uint)y;

        /// <summary>
        /// Gets the NOT of uint
        /// </summary>
        /// <param name="x">The x <see cref="uint"/></param>
        /// <returns>The result of the operation</returns>
        public static uint Not(this uint x) => (uint)~(int)x;

        /// <summary>
        /// Gets the OR of byte and uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Or(this uint x, byte y) => (uint)((int)x | (int)y);

        /// <summary>
        /// Gets the OR of char and uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Or(this uint x, char y) => (uint)((int)x | (int)y);

        /// <summary>
        /// Gets the OR of decimal and uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Or(this uint x, decimal y) => (uint)((int)x | (int)y);

        /// <summary>
        /// Gets the OR of double and uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Or(this uint x, double y) => (uint)((int)x | (int)y);

        /// <summary>
        /// Gets the OR of float and uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Or(this uint x, float y) => (uint)((int)x | (int)y);

        /// <summary>
        /// Gets the OR of int and uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Or(this uint x, int y) => (uint)((int)x | (int)y);

        /// <summary>
        /// Gets the OR of long and uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Or(this uint x, long y) => (uint)((int)x | (int)y);

        /// <summary>
        /// Gets the OR of sbyte and uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Or(this uint x, sbyte y) => (uint)((int)x | (int)y);

        /// <summary>
        /// Gets the OR of short and uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Or(this uint x, short y) => (uint)((int)x | (int)y);

        /// <summary>
        /// Gets the OR of uint and uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Or(this uint x, uint y) => (uint)((int)x | (int)y);

        /// <summary>
        /// Gets the OR of ulong and uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Or(this uint x, ulong y) => (uint)((int)x | (int)y);

        /// <summary>
        /// Gets the OR of ushort and uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Or(this uint x, ushort y) => (uint)((int)x | (int)y);

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static uint PercentOf(this uint percent, byte value) => (uint)(((uint)percent) / ((uint)100) * ((uint)value));

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static uint PercentOf(this uint percent, char value) => (uint)(((uint)percent) / ((uint)100) * ((uint)value));

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static uint PercentOf(this uint percent, decimal value) => (uint)(((uint)percent) / ((uint)100) * ((uint)value));

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static uint PercentOf(this uint percent, double value) => (uint)(((uint)percent) / ((uint)100) * ((uint)value));

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static uint PercentOf(this uint percent, float value) => (uint)(((uint)percent) / ((uint)100) * ((uint)value));

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static uint PercentOf(this uint percent, int value) => (uint)(((uint)percent) / ((uint)100) * ((uint)value));

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static uint PercentOf(this uint percent, long value) => (uint)(((uint)percent) / ((uint)100) * ((uint)value));

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static uint PercentOf(this uint percent, sbyte value) => (uint)(((uint)percent) / ((uint)100) * ((uint)value));

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static uint PercentOf(this uint percent, short value) => (uint)(((uint)percent) / ((uint)100) * ((uint)value));

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static uint PercentOf(this uint percent, uint value) => (uint)(((uint)percent) / ((uint)100) * ((uint)value));

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static uint PercentOf(this uint percent, ulong value) => (uint)(((uint)percent) / ((uint)100) * ((uint)value));

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static uint PercentOf(this uint percent, ushort value) => (uint)(((uint)percent) / ((uint)100) * ((uint)value));

        /// <summary>
        /// Compare original and second number and set the variable with the highest
        /// </summary>
        /// <param name="first">The variable</param>
        /// <param name="second">The number to compare</param>
        /// <param name="third">The number to compare with</param>
        /// <returns>Sets the variable to the highest of the two numbers</returns>
        public static ref uint SetHighestValueOf(this ref uint first, uint second, uint third)
        {
            first = second > third ? second : third;
            return ref first;
        }

        /// <summary>
        /// Compare original and second number and set the variable with the lowest
        /// </summary>
        /// <param name="first">The number</param>
        /// <param name="second">The number to compare with</param>
        /// <param name="third">The third <see cref="uint"/></param>
        /// <returns>Sets the variable to the lowest of the two numbers</returns>
        public static ref uint SetLowestValueOf(this ref uint first, uint second, uint third)
        {
            first = second < third ? second : third;
            return ref first;
        }

        /// <summary>
        /// Subtracts byte from uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(uint,byte) instead.", false)]
        public static uint Substract(this uint x, byte y) => x - (uint)y;

        /// <summary>
        /// Subtracts char from uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(uint,char) instead.", false)]
        public static uint Substract(this uint x, char y) => x - (uint)y;

        /// <summary>
        /// Subtracts decimal from uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(uint,decimal) instead.", false)]
        public static uint Substract(this uint x, decimal y) => x - (uint)y;

        /// <summary>
        /// Subtracts double from uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(uint,double) instead.", false)]
        public static uint Substract(this uint x, double y) => x - (uint)y;

        /// <summary>
        /// Subtracts float from uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(uint,float) instead.", false)]
        public static uint Substract(this uint x, float y) => x - (uint)y;

        /// <summary>
        /// Subtracts int from uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(uint,int) instead.", false)]
        public static uint Substract(this uint x, int y) => x - (uint)y;

        /// <summary>
        /// Subtracts long from uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(uint,long) instead.", false)]
        public static uint Substract(this uint x, long y) => x - (uint)y;

        /// <summary>
        /// Subtracts sbyte from uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(uint,sbyte) instead.", false)]
        public static uint Substract(this uint x, sbyte y) => x - (uint)y;

        /// <summary>
        /// Subtracts short from uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(uint,short) instead.", false)]
        public static uint Substract(this uint x, short y) => x - (uint)y;

        /// <summary>
        /// Subtracts uint from uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(uint,uint) instead.", false)]
        public static uint Substract(this uint x, uint y) => x - y;

        /// <summary>
        /// Subtracts ulong from uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(uint,ulong) instead.", false)]
        public static uint Substract(this uint x, ulong y) => x - (uint)y;

        /// <summary>
        /// Subtracts ushort from uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(uint,ushort) instead.", false)]
        public static uint Substract(this uint x, ushort y) => x - (uint)y;

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(byte) instead.", false)]
        public static uint SubstractPercent(this uint value, byte percent) => (uint)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(char) instead.", false)]
        public static uint SubstractPercent(this uint value, char percent) => (uint)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(decimal) instead.", false)]
        public static uint SubstractPercent(this uint value, decimal percent) => (uint)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(double) instead.", false)]
        public static uint SubstractPercent(this uint value, double percent) => (uint)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(float) instead.", false)]
        public static uint SubstractPercent(this uint value, float percent) => (uint)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(int) instead.", false)]
        public static uint SubstractPercent(this uint value, int percent) => (uint)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(long) instead.", false)]
        public static uint SubstractPercent(this uint value, long percent) => (uint)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(sbyte) instead.", false)]
        public static uint SubstractPercent(this uint value, sbyte percent) => (uint)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(short) instead.", false)]
        public static uint SubstractPercent(this uint value, short percent) => (uint)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(uint) instead.", false)]
        public static uint SubstractPercent(this uint value, uint percent) => (uint)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(ulong) instead.", false)]
        public static uint SubstractPercent(this uint value, ulong percent) => (uint)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(ushort) instead.", false)]
        public static uint SubstractPercent(this uint value, ushort percent) => (uint)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts byte from uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Subtract(this uint x, byte y) => x - (uint)y;

        /// <summary>
        /// Subtracts char from uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Subtract(this uint x, char y) => x - (uint)y;

        /// <summary>
        /// Subtracts decimal from uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Subtract(this uint x, decimal y) => x - (uint)y;

        /// <summary>
        /// Subtracts double from uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Subtract(this uint x, double y) => x - (uint)y;

        /// <summary>
        /// Subtracts float from uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Subtract(this uint x, float y) => x - (uint)y;

        /// <summary>
        /// Subtracts int from uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Subtract(this uint x, int y) => x - (uint)y;

        /// <summary>
        /// Subtracts long from uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Subtract(this uint x, long y) => x - (uint)y;

        /// <summary>
        /// Subtracts sbyte from uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Subtract(this uint x, sbyte y) => x - (uint)y;

        /// <summary>
        /// Subtracts short from uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Subtract(this uint x, short y) => x - (uint)y;

        /// <summary>
        /// Subtracts uint from uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Subtract(this uint x, uint y) => x - y;

        /// <summary>
        /// Subtracts ulong from uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Subtract(this uint x, ulong y) => x - (uint)y;

        /// <summary>
        /// Subtracts ushort from uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Subtract(this uint x, ushort y) => x - (uint)y;

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static uint SubtractPercent(this uint value, byte percent) => (uint)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static uint SubtractPercent(this uint value, char percent) => (uint)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static uint SubtractPercent(this uint value, decimal percent) => (uint)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static uint SubtractPercent(this uint value, double percent) => (uint)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static uint SubtractPercent(this uint value, float percent) => (uint)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static uint SubtractPercent(this uint value, int percent) => (uint)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static uint SubtractPercent(this uint value, long percent) => (uint)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static uint SubtractPercent(this uint value, sbyte percent) => (uint)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static uint SubtractPercent(this uint value, short percent) => (uint)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static uint SubtractPercent(this uint value, uint percent) => (uint)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static uint SubtractPercent(this uint value, ulong percent) => (uint)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static uint SubtractPercent(this uint value, ushort percent) => (uint)(value - value.PercentOf(percent));

        /// <summary>
        /// Swaps two variables
        /// </summary>
        /// <param name="first">The main variable</param>
        /// <param name="second">The variable to switch with</param>
        /// <returns>
        /// The value from the second variable and sets second variable to original value
        /// </returns>
        public static ref uint SwapWith(this ref uint first, ref uint second)
        {
            var tmp = second;
            second = first;
            first = tmp;
            return ref first;
        }

        /// <summary>
        /// Gets XOR of byte of uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Xor(this uint x, byte y) => x ^ (uint)y;

        /// <summary>
        /// Gets XOR of char of uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Xor(this uint x, char y) => x ^ (uint)y;

        /// <summary>
        /// Gets XOR of decimal of uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Xor(this uint x, decimal y) => x ^ (uint)y;

        /// <summary>
        /// Gets XOR of double of uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Xor(this uint x, double y) => x ^ (uint)y;

        /// <summary>
        /// Gets XOR of float of uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Xor(this uint x, float y) => x ^ (uint)y;

        /// <summary>
        /// Gets XOR of int of uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Xor(this uint x, int y) => x ^ (uint)y;

        /// <summary>
        /// Gets XOR of long of uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Xor(this uint x, long y) => x ^ (uint)y;

        /// <summary>
        /// Gets XOR of sbyte of uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Xor(this uint x, sbyte y) => x ^ (uint)y;

        /// <summary>
        /// Gets XOR of short of uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Xor(this uint x, short y) => x ^ (uint)y;

        /// <summary>
        /// Gets XOR of uint of uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Xor(this uint x, uint y) => x ^ y;

        /// <summary>
        /// Gets XOR of ulong of uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Xor(this uint x, ulong y) => x ^ (uint)y;

        /// <summary>
        /// Gets XOR of ushort of uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Xor(this uint x, ushort y) => x ^ (uint)y;
    }
}