//----------------------------------------------------------------------------------------------
// <copyright file="TypedMathDoubleExtension.cs" company="MarcusMedinaPro">
// By Marcus Medina, 2019 - http://MarcusMedina.Pro
// This file is subject to the terms and conditions defined in file 'license.txt', which is part of this project.
// </copyright>
// ----------------------------------------------------------------------------------------------
// Credits for borrowed code:
// LinQ Primenumbers, Zoran Horvat: http://www.codinghelmet.com/articles/linq-all-primes/
// ----------------------------------------------------------------------------------------------

namespace MarcusMedinaPro.TypedMath.DoubleExtension
{
    using System;
    using System.Linq;

    /// <summary>
    /// Extension for double
    /// </summary>
    public static class TypedMathDoubleExtension
    {
        /// <summary>
        /// Adds byte to double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double Add(this double x, byte y) => x + (double)y;

        /// <summary>
        /// Adds char to double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double Add(this double x, char y) => x + (double)y;

        /// <summary>
        /// Adds decimal to double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double Add(this double x, decimal y) => x + (double)y;

        /// <summary>
        /// Adds double to double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double Add(this double x, double y) => x + y;

        /// <summary>
        /// Adds float to double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double Add(this double x, float y) => x + (double)y;

        /// <summary>
        /// Adds int to double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double Add(this double x, int y) => x + (double)y;

        /// <summary>
        /// Adds long to double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double Add(this double x, long y) => x + (double)y;

        /// <summary>
        /// Adds sbyte to double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double Add(this double x, sbyte y) => x + (double)y;

        /// <summary>
        /// Adds short to double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double Add(this double x, short y) => x + (double)y;

        /// <summary>
        /// Adds uint to double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double Add(this double x, uint y) => x + (double)y;

        /// <summary>
        /// Adds ulong to double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double Add(this double x, ulong y) => x + (double)y;

        /// <summary>
        /// Adds ushort to double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double Add(this double x, ushort y) => x + (double)y;

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static double AddPercent(this double value, byte percent) => (double)(value + value.PercentOf(percent));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static double AddPercent(this double value, char percent) => (double)(value + value.PercentOf(percent));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static double AddPercent(this double value, decimal percent) => (double)(value + value.PercentOf(percent));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static double AddPercent(this double value, double percent) => (double)(value + value.PercentOf(percent));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static double AddPercent(this double value, float percent) => (double)(value + value.PercentOf(percent));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static double AddPercent(this double value, int percent) => (double)(value + value.PercentOf(percent));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static double AddPercent(this double value, long percent) => (double)(value + value.PercentOf(percent));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static double AddPercent(this double value, sbyte percent) => (double)(value + value.PercentOf(percent));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static double AddPercent(this double value, short percent) => (double)(value + value.PercentOf(percent));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static double AddPercent(this double value, uint percent) => (double)(value + value.PercentOf(percent));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static double AddPercent(this double value, ulong percent) => (double)(value + value.PercentOf(percent));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static double AddPercent(this double value, ushort percent) => (double)(value + value.PercentOf(percent));

        /// <summary>
        /// Tries to cast double to byte, this can get ugly though
        /// </summary>
        /// <param name="x">The x <see cref="double"/></param>
        /// <returns>The result of the operation</returns>
        public static byte CastDoubleToByte(this double x) => (byte)x;

        /// <summary>
        /// Tries to cast double to char, this can get ugly though
        /// </summary>
        /// <param name="x">The x <see cref="double"/></param>
        /// <returns>The result of the operation</returns>
        public static char CastDoubleToChar(this double x) => (char)x;

        /// <summary>
        /// Tries to cast double to decimal, this can get ugly though
        /// </summary>
        /// <param name="x">The x <see cref="double"/></param>
        /// <returns>The result of the operation</returns>
        public static decimal CastDoubleToDecimal(this double x) => (decimal)x;

        /// <summary>
        /// Tries to cast double to float, this can get ugly though
        /// </summary>
        /// <param name="x">The x <see cref="double"/></param>
        /// <returns>The result of the operation</returns>
        public static float CastDoubleToFloat(this double x) => (float)x;

        /// <summary>
        /// Tries to cast double to int, this can get ugly though
        /// </summary>
        /// <param name="x">The x <see cref="double"/></param>
        /// <returns>The result of the operation</returns>
        public static int CastDoubleToInt(this double x) => (int)x;

        /// <summary>
        /// Tries to cast double to long, this can get ugly though
        /// </summary>
        /// <param name="x">The x <see cref="double"/></param>
        /// <returns>The result of the operation</returns>
        public static long CastDoubleToLong(this double x) => (long)x;

        /// <summary>
        /// Tries to cast double to sbyte, this can get ugly though
        /// </summary>
        /// <param name="x">The x <see cref="double"/></param>
        /// <returns>The result of the operation</returns>
        public static sbyte CastDoubleToSbyte(this double x) => (sbyte)x;

        /// <summary>
        /// Tries to cast double to short, this can get ugly though
        /// </summary>
        /// <param name="x">The x <see cref="double"/></param>
        /// <returns>The result of the operation</returns>
        public static short CastDoubleToShort(this double x) => (short)x;

        /// <summary>
        /// Tries to cast double to uint, this can get ugly though
        /// </summary>
        /// <param name="x">The x <see cref="double"/></param>
        /// <returns>The result of the operation</returns>
        public static uint CastDoubleToUint(this double x) => (uint)x;

        /// <summary>
        /// Tries to cast double to ulong, this can get ugly though
        /// </summary>
        /// <param name="x">The x <see cref="double"/></param>
        /// <returns>The result of the operation</returns>
        public static ulong CastDoubleToUlong(this double x) => (ulong)x;

        /// <summary>
        /// Tries to cast double to ushort, this can get ugly though
        /// </summary>
        /// <param name="x">The x <see cref="double"/></param>
        /// <returns>The result of the operation</returns>
        public static ushort CastDoubleToUshort(this double x) => (ushort)x;

        /// <summary>
        /// Compare original and second number
        /// </summary>
        /// <param name="first">The number</param>
        /// <param name="second">The number to compare with</param>
        /// <returns>The highest of the two numbers</returns>
        public static double ChooseIfHigher(this double first, double second) => first > second ? first : second;

        /// <summary>
        /// Compare original and second number
        /// </summary>
        /// <param name="first">The number</param>
        /// <param name="second">The number to compare with</param>
        /// <returns>The lowest of the two numbers</returns>
        public static double ChooseIfLower(this double first, double second) => first < second ? first : second;

        /// <summary>
        /// Divides byte from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double DividedBy(this double x, byte y) => x / (double)y;

        /// <summary>
        /// Divides char from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double DividedBy(this double x, char y) => x / (double)y;

        /// <summary>
        /// Divides decimal from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double DividedBy(this double x, decimal y) => x / (double)y;

        /// <summary>
        /// Divides double from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double DividedBy(this double x, double y) => x / y;

        /// <summary>
        /// Divides float from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double DividedBy(this double x, float y) => x / (double)y;

        /// <summary>
        /// Divides int from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double DividedBy(this double x, int y) => x / (double)y;

        /// <summary>
        /// Divides long from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double DividedBy(this double x, long y) => x / (double)y;

        /// <summary>
        /// Divides sbyte from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double DividedBy(this double x, sbyte y) => x / (double)y;

        /// <summary>
        /// Divides short from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double DividedBy(this double x, short y) => x / (double)y;

        /// <summary>
        /// Divides uint from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double DividedBy(this double x, uint y) => x / (double)y;

        /// <summary>
        /// Divides ulong from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double DividedBy(this double x, ulong y) => x / (double)y;

        /// <summary>
        /// Divides ushort from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double DividedBy(this double x, ushort y) => x / (double)y;

        /// <summary>
        /// Gets a boolean True if double is greater than byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this double x, byte y) => x > (double)y;

        /// <summary>
        /// Gets a boolean True if double is greater than char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this double x, char y) => x > (double)y;

        /// <summary>
        /// Gets a boolean True if double is greater than decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this double x, decimal y) => x > (double)y;

        /// <summary>
        /// Gets a boolean True if double is greater than double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this double x, double y) => x > y;

        /// <summary>
        /// Gets a boolean True if double is greater than float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this double x, float y) => x > (double)y;

        /// <summary>
        /// Gets a boolean True if double is greater than int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this double x, int y) => x > (double)y;

        /// <summary>
        /// Gets a boolean True if double is greater than long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this double x, long y) => x > (double)y;

        /// <summary>
        /// Gets a boolean True if double is greater than sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this double x, sbyte y) => x > (double)y;

        /// <summary>
        /// Gets a boolean True if double is greater than short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this double x, short y) => x > (double)y;

        /// <summary>
        /// Gets a boolean True if double is greater than uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this double x, uint y) => x > (double)y;

        /// <summary>
        /// Gets a boolean True if double is greater than ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this double x, ulong y) => x > (double)y;

        /// <summary>
        /// Gets a boolean True if double is greater than ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this double x, ushort y) => x > (double)y;

        /// <summary>
        /// Gets boolean True if byte is equal to double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqual(this double x, byte y) => (decimal)x == (decimal)y;

        /// <summary>
        /// Gets boolean True if char is equal to double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqual(this double x, char y) => (decimal)x == (decimal)y;

        /// <summary>
        /// Gets boolean True if decimal is equal to double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqual(this double x, decimal y) => (decimal)x == (decimal)y;

        /// <summary>
        /// Gets boolean True if double is equal to double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqual(this double x, double y) => (decimal)x == (decimal)y;

        /// <summary>
        /// Gets boolean True if float is equal to double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqual(this double x, float y) => (decimal)x == (decimal)y;

        /// <summary>
        /// Gets boolean True if int is equal to double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqual(this double x, int y) => (decimal)x == (decimal)y;

        /// <summary>
        /// Gets boolean True if long is equal to double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqual(this double x, long y) => (decimal)x == (decimal)y;

        /// <summary>
        /// Gets boolean True if sbyte is equal to double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqual(this double x, sbyte y) => (decimal)x == (decimal)y;

        /// <summary>
        /// Gets boolean True if short is equal to double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqual(this double x, short y) => (decimal)x == (decimal)y;

        /// <summary>
        /// Gets boolean True if uint is equal to double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqual(this double x, uint y) => (decimal)x == (decimal)y;

        /// <summary>
        /// Gets boolean True if ulong is equal to double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqual(this double x, ulong y) => (decimal)x == (decimal)y;

        /// <summary>
        /// Gets boolean True if ushort is equal to double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqual(this double x, ushort y) => (decimal)x == (decimal)y;

        /// <summary>
        /// Gets boolean true if value is less than zero
        /// </summary>
        /// <param name="x">The x <see cref="double"/></param>
        /// <returns>The result of the operation</returns>
        public static bool IsNegative(this double x) => x < 0;

        /// <summary>
        /// Gets boolean True if byte is not equal to double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqual(this double x, byte y) => (decimal)x != (decimal)y;

        /// <summary>
        /// Gets boolean True if char is not equal to double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqual(this double x, char y) => (decimal)x != (decimal)y;

        /// <summary>
        /// Gets boolean True if decimal is not equal to double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqual(this double x, decimal y) => (decimal)x != (decimal)y;

        /// <summary>
        /// Gets boolean True if double is not equal to double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqual(this double x, double y) => (decimal)x != (decimal)y;

        /// <summary>
        /// Gets boolean True if float is not equal to double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqual(this double x, float y) => (decimal)x != (decimal)y;

        /// <summary>
        /// Gets boolean True if int is not equal to double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqual(this double x, int y) => (decimal)x != (decimal)y;

        /// <summary>
        /// Gets boolean True if long is not equal to double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqual(this double x, long y) => (decimal)x != (decimal)y;

        /// <summary>
        /// Gets boolean True if sbyte is not equal to double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqual(this double x, sbyte y) => (decimal)x != (decimal)y;

        /// <summary>
        /// Gets boolean True if short is not equal to double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqual(this double x, short y) => (decimal)x != (decimal)y;

        /// <summary>
        /// Gets boolean True if uint is not equal to double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqual(this double x, uint y) => (decimal)x != (decimal)y;

        /// <summary>
        /// Gets boolean True if ulong is not equal to double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqual(this double x, ulong y) => (decimal)x != (decimal)y;

        /// <summary>
        /// Gets boolean True if ushort is not equal to double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqual(this double x, ushort y) => (decimal)x != (decimal)y;

        /// <summary>
        /// Gets boolean true if value is more than zero
        /// </summary>
        /// <param name="x">The x <see cref="double"/></param>
        /// <returns>The result of the operation</returns>
        public static bool IsPositive(this double x) => x >= 0;

        /// <summary>
        /// Checks if a number is prime
        /// </summary>
        /// <param name="number">The number</param>
        /// <returns>True if the number is prime</returns>
        public static bool IsPrime(this double number) => Enumerable.Range(2, (int)Math.Sqrt(number) - 1).All(divisor => number % divisor != 0);

        /// <summary>
        /// Gets a boolean True if double is less than byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this double x, byte y) => x < (double)y;

        /// <summary>
        /// Gets a boolean True if double is less than char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this double x, char y) => x < (double)y;

        /// <summary>
        /// Gets a boolean True if double is less than decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this double x, decimal y) => x < (double)y;

        /// <summary>
        /// Gets a boolean True if double is less than double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this double x, double y) => x < y;

        /// <summary>
        /// Gets a boolean True if double is less than float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this double x, float y) => x < (double)y;

        /// <summary>
        /// Gets a boolean True if double is less than int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this double x, int y) => x < (double)y;

        /// <summary>
        /// Gets a boolean True if double is less than long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this double x, long y) => x < (double)y;

        /// <summary>
        /// Gets a boolean True if double is less than sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this double x, sbyte y) => x < (double)y;

        /// <summary>
        /// Gets a boolean True if double is less than short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this double x, short y) => x < (double)y;

        /// <summary>
        /// Gets a boolean True if double is less than uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this double x, uint y) => x < (double)y;

        /// <summary>
        /// Gets a boolean True if double is less than ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this double x, ulong y) => x < (double)y;

        /// <summary>
        /// Gets a boolean True if double is less than ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this double x, ushort y) => x < (double)y;

        /// <summary>
        /// Gets the remainder of byte from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double Modulus(this double x, byte y) => x % (double)y;

        /// <summary>
        /// Gets the remainder of char from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double Modulus(this double x, char y) => x % (double)y;

        /// <summary>
        /// Gets the remainder of decimal from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double Modulus(this double x, decimal y) => x % (double)y;

        /// <summary>
        /// Gets the remainder of double from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double Modulus(this double x, double y) => x % y;

        /// <summary>
        /// Gets the remainder of float from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double Modulus(this double x, float y) => x % (double)y;

        /// <summary>
        /// Gets the remainder of int from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double Modulus(this double x, int y) => x % (double)y;

        /// <summary>
        /// Gets the remainder of long from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double Modulus(this double x, long y) => x % (double)y;

        /// <summary>
        /// Gets the remainder of sbyte from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double Modulus(this double x, sbyte y) => x % (double)y;

        /// <summary>
        /// Gets the remainder of short from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double Modulus(this double x, short y) => x % (double)y;

        /// <summary>
        /// Gets the remainder of uint from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double Modulus(this double x, uint y) => x % (double)y;

        /// <summary>
        /// Gets the remainder of ulong from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double Modulus(this double x, ulong y) => x % (double)y;

        /// <summary>
        /// Gets the remainder of ushort from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double Modulus(this double x, ushort y) => x % (double)y;

        /// <summary>
        /// Multiplies byte with double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double MultipliedWith(this double x, byte y) => x * (double)y;

        /// <summary>
        /// Multiplies char with double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double MultipliedWith(this double x, char y) => x * (double)y;

        /// <summary>
        /// Multiplies decimal with double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double MultipliedWith(this double x, decimal y) => x * (double)y;

        /// <summary>
        /// Multiplies double with double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double MultipliedWith(this double x, double y) => x * y;

        /// <summary>
        /// Multiplies float with double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double MultipliedWith(this double x, float y) => x * (double)y;

        /// <summary>
        /// Multiplies int with double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double MultipliedWith(this double x, int y) => x * (double)y;

        /// <summary>
        /// Multiplies long with double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double MultipliedWith(this double x, long y) => x * (double)y;

        /// <summary>
        /// Multiplies sbyte with double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double MultipliedWith(this double x, sbyte y) => x * (double)y;

        /// <summary>
        /// Multiplies short with double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double MultipliedWith(this double x, short y) => x * (double)y;

        /// <summary>
        /// Multiplies uint with double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double MultipliedWith(this double x, uint y) => x * (double)y;

        /// <summary>
        /// Multiplies ulong with double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double MultipliedWith(this double x, ulong y) => x * (double)y;

        /// <summary>
        /// Multiplies ushort with double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double MultipliedWith(this double x, ushort y) => x * (double)y;

        /// <summary>
        /// Gets the NOT of double
        /// </summary>
        /// <param name="x">The x <see cref="double"/></param>
        /// <returns>The result of the operation</returns>
        public static double Not(this double x) => (double)~(int)x;

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static double PercentOf(this double percent, byte value) => (double)(((double)percent) / ((double)100) * ((double)value));

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static double PercentOf(this double percent, char value) => (double)(((double)percent) / ((double)100) * ((double)value));

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static double PercentOf(this double percent, decimal value) => (double)(((double)percent) / ((double)100) * ((double)value));

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static double PercentOf(this double percent, double value) => (double)(((double)percent) / ((double)100) * ((double)value));

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static double PercentOf(this double percent, float value) => (double)(((double)percent) / ((double)100) * ((double)value));

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static double PercentOf(this double percent, int value) => (double)(((double)percent) / ((double)100) * ((double)value));

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static double PercentOf(this double percent, long value) => (double)(((double)percent) / ((double)100) * ((double)value));

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static double PercentOf(this double percent, sbyte value) => (double)(((double)percent) / ((double)100) * ((double)value));

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static double PercentOf(this double percent, short value) => (double)(((double)percent) / ((double)100) * ((double)value));

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static double PercentOf(this double percent, uint value) => (double)(((double)percent) / ((double)100) * ((double)value));

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static double PercentOf(this double percent, ulong value) => (double)(((double)percent) / ((double)100) * ((double)value));

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static double PercentOf(this double percent, ushort value) => (double)(((double)percent) / ((double)100) * ((double)value));

        /// <summary>
        /// Compare original and second number and set the variable with the highest
        /// </summary>
        /// <param name="first">The variable</param>
        /// <param name="second">The number to compare</param>
        /// <param name="third">The number to compare with</param>
        /// <returns>Sets the variable to the highest of the two numbers</returns>
        public static ref double SetHighestValueOf(this ref double first, double second, double third)
        {
            first = second > third ? second : third;
            return ref first;
        }

        /// <summary>
        /// Compare original and second number and set the variable with the lowest
        /// </summary>
        /// <param name="first">The number</param>
        /// <param name="second">The number to compare with</param>
        /// <param name="third">The third <see cref="double"/></param>
        /// <returns>Sets the variable to the lowest of the two numbers</returns>
        public static ref double SetLowestValueOf(this ref double first, double second, double third)
        {
            first = second < third ? second : third;
            return ref first;
        }

        /// <summary>
        /// Subtracts byte from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(double,byte) instead.", false)]
        public static double Substract(this double x, byte y) => x - (double)y;

        /// <summary>
        /// Subtracts char from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(double,char) instead.", false)]
        public static double Substract(this double x, char y) => x - (double)y;

        /// <summary>
        /// Subtracts decimal from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(double,decimal) instead.", false)]
        public static double Substract(this double x, decimal y) => x - (double)y;

        /// <summary>
        /// Subtracts double from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(double,double) instead.", false)]
        public static double Substract(this double x, double y) => x - y;

        /// <summary>
        /// Subtracts float from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(double,float) instead.", false)]
        public static double Substract(this double x, float y) => x - (double)y;

        /// <summary>
        /// Subtracts int from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(double,int) instead.", false)]
        public static double Substract(this double x, int y) => x - (double)y;

        /// <summary>
        /// Subtracts long from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(double,long) instead.", false)]
        public static double Substract(this double x, long y) => x - (double)y;

        /// <summary>
        /// Subtracts sbyte from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(double,sbyte) instead.", false)]
        public static double Substract(this double x, sbyte y) => x - (double)y;

        /// <summary>
        /// Subtracts short from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(double,short) instead.", false)]
        public static double Substract(this double x, short y) => x - (double)y;

        /// <summary>
        /// Subtracts uint from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(double,uint) instead.", false)]
        public static double Substract(this double x, uint y) => x - (double)y;

        /// <summary>
        /// Subtracts ulong from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(double,ulong) instead.", false)]
        public static double Substract(this double x, ulong y) => x - (double)y;

        /// <summary>
        /// Subtracts ushort from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(double,ushort) instead.", false)]
        public static double Substract(this double x, ushort y) => x - (double)y;

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(byte) instead.", false)]
        public static double SubstractPercent(this double value, byte percent) => (double)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(char) instead.", false)]
        public static double SubstractPercent(this double value, char percent) => (double)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(decimal) instead.", false)]
        public static double SubstractPercent(this double value, decimal percent) => (double)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(double) instead.", false)]
        public static double SubstractPercent(this double value, double percent) => (double)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(float) instead.", false)]
        public static double SubstractPercent(this double value, float percent) => (double)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(int) instead.", false)]
        public static double SubstractPercent(this double value, int percent) => (double)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(long) instead.", false)]
        public static double SubstractPercent(this double value, long percent) => (double)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(sbyte) instead.", false)]
        public static double SubstractPercent(this double value, sbyte percent) => (double)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(short) instead.", false)]
        public static double SubstractPercent(this double value, short percent) => (double)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(uint) instead.", false)]
        public static double SubstractPercent(this double value, uint percent) => (double)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(ulong) instead.", false)]
        public static double SubstractPercent(this double value, ulong percent) => (double)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(ushort) instead.", false)]
        public static double SubstractPercent(this double value, ushort percent) => (double)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts byte from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double Subtract(this double x, byte y) => x - (double)y;

        /// <summary>
        /// Subtracts char from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double Subtract(this double x, char y) => x - (double)y;

        /// <summary>
        /// Subtracts decimal from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double Subtract(this double x, decimal y) => x - (double)y;

        /// <summary>
        /// Subtracts double from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double Subtract(this double x, double y) => x - y;

        /// <summary>
        /// Subtracts float from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double Subtract(this double x, float y) => x - (double)y;

        /// <summary>
        /// Subtracts int from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double Subtract(this double x, int y) => x - (double)y;

        /// <summary>
        /// Subtracts long from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double Subtract(this double x, long y) => x - (double)y;

        /// <summary>
        /// Subtracts sbyte from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double Subtract(this double x, sbyte y) => x - (double)y;

        /// <summary>
        /// Subtracts short from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double Subtract(this double x, short y) => x - (double)y;

        /// <summary>
        /// Subtracts uint from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double Subtract(this double x, uint y) => x - (double)y;

        /// <summary>
        /// Subtracts ulong from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double Subtract(this double x, ulong y) => x - (double)y;

        /// <summary>
        /// Subtracts ushort from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double Subtract(this double x, ushort y) => x - (double)y;

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static double SubtractPercent(this double value, byte percent) => (double)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static double SubtractPercent(this double value, char percent) => (double)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static double SubtractPercent(this double value, decimal percent) => (double)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static double SubtractPercent(this double value, double percent) => (double)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static double SubtractPercent(this double value, float percent) => (double)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static double SubtractPercent(this double value, int percent) => (double)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static double SubtractPercent(this double value, long percent) => (double)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static double SubtractPercent(this double value, sbyte percent) => (double)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static double SubtractPercent(this double value, short percent) => (double)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static double SubtractPercent(this double value, uint percent) => (double)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static double SubtractPercent(this double value, ulong percent) => (double)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static double SubtractPercent(this double value, ushort percent) => (double)(value - value.PercentOf(percent));

        /// <summary>
        /// Swaps two variables
        /// </summary>
        /// <param name="first">The main variable</param>
        /// <param name="second">The variable to switch with</param>
        /// <returns>The <see cref="ref double"/></returns>
        public static ref double SwapWith(this ref double first, ref double second)
        {
            var tmp = second;
            second = first;
            first = tmp;
            return ref first;
        }
    }
}