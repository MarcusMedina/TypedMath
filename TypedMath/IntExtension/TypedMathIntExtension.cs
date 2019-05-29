//----------------------------------------------------------------------------------------------
// <copyright file="TypedMathIntExtension.cs" company="MarcusMedinaPro">
// By Marcus Medina, 2019 - http://MarcusMedina.Pro
// This file is subject to the terms and conditions defined in file 'license.txt', which is part of this project.
// </copyright>
// ----------------------------------------------------------------------------------------------
// Credits for borrowed code:
// LinQ Primenumbers, Zoran Horvat: http://www.codinghelmet.com/articles/linq-all-primes/
// ----------------------------------------------------------------------------------------------

namespace MarcusMedinaPro.TypedMath.IntExtension
{
    using System;
    using System.Linq;

    /// <summary>
    /// Extension for int
    /// </summary>
    public static class TypedMathIntExtension
    {
        /// <summary>
        /// Adds byte to int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int Add(this int x, byte y) => x + (int)y;

        /// <summary>
        /// Adds char to int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int Add(this int x, char y) => x + (int)y;

        /// <summary>
        /// Adds decimal to int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int Add(this int x, decimal y) => x + (int)y;

        /// <summary>
        /// Adds double to int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int Add(this int x, double y) => x + (int)y;

        /// <summary>
        /// Adds float to int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int Add(this int x, float y) => x + (int)y;

        /// <summary>
        /// Adds int to int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int Add(this int x, int y) => x + y;

        /// <summary>
        /// Adds long to int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int Add(this int x, long y) => x + (int)y;

        /// <summary>
        /// Adds sbyte to int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int Add(this int x, sbyte y) => x + (int)y;

        /// <summary>
        /// Adds short to int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int Add(this int x, short y) => x + (int)y;

        /// <summary>
        /// Adds uint to int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int Add(this int x, uint y) => x + (int)y;

        /// <summary>
        /// Adds ulong to int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int Add(this int x, ulong y) => x + (int)y;

        /// <summary>
        /// Adds ushort to int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int Add(this int x, ushort y) => x + (int)y;

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static int AddPercent(this int value, byte percent) => (int)(value + value.PercentOf(percent));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static int AddPercent(this int value, char percent) => (int)(value + value.PercentOf(percent));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static int AddPercent(this int value, decimal percent) => (int)(value + value.PercentOf(percent));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static int AddPercent(this int value, double percent) => (int)(value + value.PercentOf(percent));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static int AddPercent(this int value, float percent) => (int)(value + value.PercentOf(percent));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static int AddPercent(this int value, int percent) => (int)(value + value.PercentOf(percent));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static int AddPercent(this int value, long percent) => (int)(value + value.PercentOf(percent));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static int AddPercent(this int value, sbyte percent) => (int)(value + value.PercentOf(percent));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static int AddPercent(this int value, short percent) => (int)(value + value.PercentOf(percent));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static int AddPercent(this int value, uint percent) => (int)(value + value.PercentOf(percent));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static int AddPercent(this int value, ulong percent) => (int)(value + value.PercentOf(percent));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static int AddPercent(this int value, ushort percent) => (int)(value + value.PercentOf(percent));

        /// <summary>
        /// Gets the AND of byte and int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int And(this int x, byte y) => x & (int)y;

        /// <summary>
        /// Gets the AND of char and int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int And(this int x, char y) => x & (int)y;

        /// <summary>
        /// Gets the AND of decimal and int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int And(this int x, decimal y) => x & (int)y;

        /// <summary>
        /// Gets the AND of double and int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int And(this int x, double y) => x & (int)y;

        /// <summary>
        /// Gets the AND of float and int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int And(this int x, float y) => x & (int)y;

        /// <summary>
        /// Gets the AND of int and int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int And(this int x, int y) => x & y;

        /// <summary>
        /// Gets the AND of long and int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int And(this int x, long y) => x & (int)y;

        /// <summary>
        /// Gets the AND of sbyte and int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int And(this int x, sbyte y) => x & (int)y;

        /// <summary>
        /// Gets the AND of short and int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int And(this int x, short y) => x & (int)y;

        /// <summary>
        /// Gets the AND of uint and int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int And(this int x, uint y) => x & (int)y;

        /// <summary>
        /// Gets the AND of ulong and int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int And(this int x, ulong y) => x & (int)y;

        /// <summary>
        /// Gets the AND of ushort and int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int And(this int x, ushort y) => x & (int)y;

        /// <summary>
        /// Tries to cast int to byte, this can get ugly though
        /// </summary>
        /// <param name="x">The x <see cref="int"/></param>
        /// <returns>The result of the operation</returns>
        public static byte CastIntToByte(this int x) => (byte)x;

        /// <summary>
        /// Tries to cast int to char, this can get ugly though
        /// </summary>
        /// <param name="x">The x <see cref="int"/></param>
        /// <returns>The result of the operation</returns>
        public static char CastIntToChar(this int x) => (char)x;

        /// <summary>
        /// Tries to cast int to decimal, this can get ugly though
        /// </summary>
        /// <param name="x">The x <see cref="int"/></param>
        /// <returns>The result of the operation</returns>
        public static decimal CastIntToDecimal(this int x) => (decimal)x;

        /// <summary>
        /// Tries to cast int to double, this can get ugly though
        /// </summary>
        /// <param name="x">The x <see cref="int"/></param>
        /// <returns>The result of the operation</returns>
        public static double CastIntToDouble(this int x) => (double)x;

        /// <summary>
        /// Tries to cast int to float, this can get ugly though
        /// </summary>
        /// <param name="x">The x <see cref="int"/></param>
        /// <returns>The result of the operation</returns>
        public static float CastIntToFloat(this int x) => (float)x;

        /// <summary>
        /// Tries to cast int to long, this can get ugly though
        /// </summary>
        /// <param name="x">The x <see cref="int"/></param>
        /// <returns>The result of the operation</returns>
        public static long CastIntToLong(this int x) => (long)x;

        /// <summary>
        /// Tries to cast int to sbyte, this can get ugly though
        /// </summary>
        /// <param name="x">The x <see cref="int"/></param>
        /// <returns>The result of the operation</returns>
        public static sbyte CastIntToSbyte(this int x) => (sbyte)x;

        /// <summary>
        /// Tries to cast int to short, this can get ugly though
        /// </summary>
        /// <param name="x">The x <see cref="int"/></param>
        /// <returns>The result of the operation</returns>
        public static short CastIntToShort(this int x) => (short)x;

        /// <summary>
        /// Tries to cast int to uint, this can get ugly though
        /// </summary>
        /// <param name="x">The x <see cref="int"/></param>
        /// <returns>The result of the operation</returns>
        public static uint CastIntToUint(this int x) => (uint)x;

        /// <summary>
        /// Tries to cast int to ulong, this can get ugly though
        /// </summary>
        /// <param name="x">The x <see cref="int"/></param>
        /// <returns>The result of the operation</returns>
        public static ulong CastIntToUlong(this int x) => (ulong)x;

        /// <summary>
        /// Tries to cast int to ushort, this can get ugly though
        /// </summary>
        /// <param name="x">The x <see cref="int"/></param>
        /// <returns>The result of the operation</returns>
        public static ushort CastIntToUshort(this int x) => (ushort)x;

        /// <summary>
        /// Compare original and second number
        /// </summary>
        /// <param name="first">The number</param>
        /// <param name="second">The number to compare with</param>
        /// <returns>The highest of the two numbers</returns>
        public static int ChooseIfHigher(this int first, int second) => first > second ? first : second;

        /// <summary>
        /// Compare original and second number
        /// </summary>
        /// <param name="first">The number</param>
        /// <param name="second">The number to compare with</param>
        /// <returns>The lowest of the two numbers</returns>
        public static int ChooseIfLower(this int first, int second) => first < second ? first : second;

        /// <summary>
        /// Divides byte from int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int DividedBy(this int x, byte y) => x / (int)y;

        /// <summary>
        /// Divides char from int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int DividedBy(this int x, char y) => x / (int)y;

        /// <summary>
        /// Divides decimal from int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int DividedBy(this int x, decimal y) => x / (int)y;

        /// <summary>
        /// Divides double from int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int DividedBy(this int x, double y) => x / (int)y;

        /// <summary>
        /// Divides float from int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int DividedBy(this int x, float y) => x / (int)y;

        /// <summary>
        /// Divides int from int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int DividedBy(this int x, int y) => x / y;

        /// <summary>
        /// Divides long from int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int DividedBy(this int x, long y) => x / (int)y;

        /// <summary>
        /// Divides sbyte from int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int DividedBy(this int x, sbyte y) => x / (int)y;

        /// <summary>
        /// Divides short from int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int DividedBy(this int x, short y) => x / (int)y;

        /// <summary>
        /// Divides uint from int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int DividedBy(this int x, uint y) => x / (int)y;

        /// <summary>
        /// Divides ulong from int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int DividedBy(this int x, ulong y) => x / (int)y;

        /// <summary>
        /// Divides ushort from int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int DividedBy(this int x, ushort y) => x / (int)y;

        /// <summary>
        /// Gets a boolean True if int is greater than byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this int x, byte y) => x > (int)y;

        /// <summary>
        /// Gets a boolean True if int is greater than char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this int x, char y) => x > (int)y;

        /// <summary>
        /// Gets a boolean True if int is greater than decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this int x, decimal y) => x > (int)y;

        /// <summary>
        /// Gets a boolean True if int is greater than double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this int x, double y) => x > (int)y;

        /// <summary>
        /// Gets a boolean True if int is greater than float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this int x, float y) => x > (int)y;

        /// <summary>
        /// Gets a boolean True if int is greater than int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this int x, int y) => x > y;

        /// <summary>
        /// Gets a boolean True if int is greater than long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this int x, long y) => x > (int)y;

        /// <summary>
        /// Gets a boolean True if int is greater than sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this int x, sbyte y) => x > (int)y;

        /// <summary>
        /// Gets a boolean True if int is greater than short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this int x, short y) => x > (int)y;

        /// <summary>
        /// Gets a boolean True if int is greater than uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this int x, uint y) => x > (int)y;

        /// <summary>
        /// Gets a boolean True if int is greater than ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this int x, ulong y) => x > (int)y;

        /// <summary>
        /// Gets a boolean True if int is greater than ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this int x, ushort y) => x > (int)y;

        /// <summary>
        /// Gets boolean True if byte is equal to int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this int x, byte y) => x == (int)y;

        /// <summary>
        /// Gets boolean True if char is equal to int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this int x, char y) => x == (int)y;

        /// <summary>
        /// Gets boolean True if decimal is equal to int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this int x, decimal y) => x == (int)y;

        /// <summary>
        /// Gets boolean True if double is equal to int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this int x, double y) => x == (int)y;

        /// <summary>
        /// Gets boolean True if float is equal to int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this int x, float y) => x == (int)y;

        /// <summary>
        /// Gets boolean True if int is equal to int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this int x, int y) => x == y;

        /// <summary>
        /// Gets boolean True if long is equal to int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this int x, long y) => x == (int)y;

        /// <summary>
        /// Gets boolean True if sbyte is equal to int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this int x, sbyte y) => x == (int)y;

        /// <summary>
        /// Gets boolean True if short is equal to int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this int x, short y) => x == (int)y;

        /// <summary>
        /// Gets boolean True if uint is equal to int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this int x, uint y) => x == (int)y;

        /// <summary>
        /// Gets boolean True if ulong is equal to int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this int x, ulong y) => x == (int)y;

        /// <summary>
        /// Gets boolean True if ushort is equal to int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this int x, ushort y) => x == (int)y;

        /// <summary>
        /// Gets boolean true if value is less than zero
        /// </summary>
        /// <param name="x">The x <see cref="int"/></param>
        /// <returns>The result of the operation</returns>
        public static bool IsNegative(this int x) => x < 0;

        /// <summary>
        /// Gets boolean True if byte is not equal to int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this int x, byte y) => x != (int)y;

        /// <summary>
        /// Gets boolean True if char is not equal to int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this int x, char y) => x != (int)y;

        /// <summary>
        /// Gets boolean True if decimal is not equal to int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this int x, decimal y) => x != (int)y;

        /// <summary>
        /// Gets boolean True if double is not equal to int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this int x, double y) => x != (int)y;

        /// <summary>
        /// Gets boolean True if float is not equal to int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this int x, float y) => x != (int)y;

        /// <summary>
        /// Gets boolean True if int is not equal to int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this int x, int y) => x != y;

        /// <summary>
        /// Gets boolean True if long is not equal to int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this int x, long y) => x != (int)y;

        /// <summary>
        /// Gets boolean True if sbyte is not equal to int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this int x, sbyte y) => x != (int)y;

        /// <summary>
        /// Gets boolean True if short is not equal to int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this int x, short y) => x != (int)y;

        /// <summary>
        /// Gets boolean True if uint is not equal to int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this int x, uint y) => x != (int)y;

        /// <summary>
        /// Gets boolean True if ulong is not equal to int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this int x, ulong y) => x != (int)y;

        /// <summary>
        /// Gets boolean True if ushort is not equal to int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this int x, ushort y) => x != (int)y;

        /// <summary>
        /// Gets boolean true if value is more than zero
        /// </summary>
        /// <param name="x">The x <see cref="int"/></param>
        /// <returns>The result of the operation</returns>
        public static bool IsPositive(this int x) => x >= 0;

        /// <summary>
        /// Checks if a number is prime
        /// </summary>
        /// <param name="number">The number</param>
        /// <returns>True if the number is prime</returns>
        public static bool IsPrime(this int number) => Enumerable.Range(2, (int)Math.Sqrt(number) - 1).All(divisor => number % divisor != 0);

        /// <summary>
        /// Gets a boolean True if int is less than byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this int x, byte y) => x < (int)y;

        /// <summary>
        /// Gets a boolean True if int is less than char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this int x, char y) => x < (int)y;

        /// <summary>
        /// Gets a boolean True if int is less than decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this int x, decimal y) => x < (int)y;

        /// <summary>
        /// Gets a boolean True if int is less than double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this int x, double y) => x < (int)y;

        /// <summary>
        /// Gets a boolean True if int is less than float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this int x, float y) => x < (int)y;

        /// <summary>
        /// Gets a boolean True if int is less than int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this int x, int y) => x < y;

        /// <summary>
        /// Gets a boolean True if int is less than long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this int x, long y) => x < (int)y;

        /// <summary>
        /// Gets a boolean True if int is less than sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this int x, sbyte y) => x < (int)y;

        /// <summary>
        /// Gets a boolean True if int is less than short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this int x, short y) => x < (int)y;

        /// <summary>
        /// Gets a boolean True if int is less than uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this int x, uint y) => x < (int)y;

        /// <summary>
        /// Gets a boolean True if int is less than ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this int x, ulong y) => x < (int)y;

        /// <summary>
        /// Gets a boolean True if int is less than ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this int x, ushort y) => x < (int)y;

        /// <summary>
        /// Gets the remainder of byte from int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int Modulus(this int x, byte y) => x % (int)y;

        /// <summary>
        /// Gets the remainder of char from int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int Modulus(this int x, char y) => x % (int)y;

        /// <summary>
        /// Gets the remainder of decimal from int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int Modulus(this int x, decimal y) => x % (int)y;

        /// <summary>
        /// Gets the remainder of double from int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int Modulus(this int x, double y) => x % (int)y;

        /// <summary>
        /// Gets the remainder of float from int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int Modulus(this int x, float y) => x % (int)y;

        /// <summary>
        /// Gets the remainder of int from int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int Modulus(this int x, int y) => x % y;

        /// <summary>
        /// Gets the remainder of long from int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int Modulus(this int x, long y) => x % (int)y;

        /// <summary>
        /// Gets the remainder of sbyte from int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int Modulus(this int x, sbyte y) => x % (int)y;

        /// <summary>
        /// Gets the remainder of short from int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int Modulus(this int x, short y) => x % (int)y;

        /// <summary>
        /// Gets the remainder of uint from int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int Modulus(this int x, uint y) => x % (int)y;

        /// <summary>
        /// Gets the remainder of ulong from int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int Modulus(this int x, ulong y) => x % (int)y;

        /// <summary>
        /// Gets the remainder of ushort from int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int Modulus(this int x, ushort y) => x % (int)y;

        /// <summary>
        /// Multiplies byte with int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int MultipliedWith(this int x, byte y) => x * (int)y;

        /// <summary>
        /// Multiplies char with int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int MultipliedWith(this int x, char y) => x * (int)y;

        /// <summary>
        /// Multiplies decimal with int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int MultipliedWith(this int x, decimal y) => x * (int)y;

        /// <summary>
        /// Multiplies double with int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int MultipliedWith(this int x, double y) => x * (int)y;

        /// <summary>
        /// Multiplies float with int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int MultipliedWith(this int x, float y) => x * (int)y;

        /// <summary>
        /// Multiplies int with int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int MultipliedWith(this int x, int y) => x * y;

        /// <summary>
        /// Multiplies long with int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int MultipliedWith(this int x, long y) => x * (int)y;

        /// <summary>
        /// Multiplies sbyte with int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int MultipliedWith(this int x, sbyte y) => x * (int)y;

        /// <summary>
        /// Multiplies short with int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int MultipliedWith(this int x, short y) => x * (int)y;

        /// <summary>
        /// Multiplies uint with int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int MultipliedWith(this int x, uint y) => x * (int)y;

        /// <summary>
        /// Multiplies ulong with int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int MultipliedWith(this int x, ulong y) => x * (int)y;

        /// <summary>
        /// Multiplies ushort with int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int MultipliedWith(this int x, ushort y) => x * (int)y;

        /// <summary>
        /// Gets the NOT of int
        /// </summary>
        /// <param name="x">The x <see cref="int"/></param>
        /// <returns>The result of the operation</returns>
        public static int Not(this int x) => (int)~(int)x;

        /// <summary>
        /// Gets the OR of byte and int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int Or(this int x, byte y) => (int)((int)x | (int)y);

        /// <summary>
        /// Gets the OR of char and int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int Or(this int x, char y) => (int)((int)x | (int)y);

        /// <summary>
        /// Gets the OR of decimal and int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int Or(this int x, decimal y) => (int)((int)x | (int)y);

        /// <summary>
        /// Gets the OR of double and int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int Or(this int x, double y) => (int)((int)x | (int)y);

        /// <summary>
        /// Gets the OR of float and int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int Or(this int x, float y) => (int)((int)x | (int)y);

        /// <summary>
        /// Gets the OR of int and int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int Or(this int x, int y) => (int)((int)x | (int)y);

        /// <summary>
        /// Gets the OR of long and int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int Or(this int x, long y) => (int)((int)x | (int)y);

        /// <summary>
        /// Gets the OR of sbyte and int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int Or(this int x, sbyte y) => (int)((int)x | (int)y);

        /// <summary>
        /// Gets the OR of short and int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int Or(this int x, short y) => (int)((int)x | (int)y);

        /// <summary>
        /// Gets the OR of uint and int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int Or(this int x, uint y) => (int)((int)x | (int)y);

        /// <summary>
        /// Gets the OR of ulong and int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int Or(this int x, ulong y) => (int)((int)x | (int)y);

        /// <summary>
        /// Gets the OR of ushort and int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int Or(this int x, ushort y) => (int)((int)x | (int)y);

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static int PercentOf(this int percent, byte value) => (int)(((int)percent) / ((int)100) * ((int)value));

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static int PercentOf(this int percent, char value) => (int)(((int)percent) / ((int)100) * ((int)value));

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static int PercentOf(this int percent, decimal value) => (int)(((int)percent) / ((int)100) * ((int)value));

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static int PercentOf(this int percent, double value) => (int)(((int)percent) / ((int)100) * ((int)value));

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static int PercentOf(this int percent, float value) => (int)(((int)percent) / ((int)100) * ((int)value));

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static int PercentOf(this int percent, int value) => (int)(((int)percent) / ((int)100) * ((int)value));

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static int PercentOf(this int percent, long value) => (int)(((int)percent) / ((int)100) * ((int)value));

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static int PercentOf(this int percent, sbyte value) => (int)(((int)percent) / ((int)100) * ((int)value));

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static int PercentOf(this int percent, short value) => (int)(((int)percent) / ((int)100) * ((int)value));

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static int PercentOf(this int percent, uint value) => (int)(((int)percent) / ((int)100) * ((int)value));

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static int PercentOf(this int percent, ulong value) => (int)(((int)percent) / ((int)100) * ((int)value));

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static int PercentOf(this int percent, ushort value) => (int)(((int)percent) / ((int)100) * ((int)value));

        /// <summary>
        /// Compare original and second number and set the variable with the highest
        /// </summary>
        /// <param name="first">The variable</param>
        /// <param name="second">The number to compare</param>
        /// <param name="third">The number to compare with</param>
        /// <returns>Sets the variable to the highest of the two numbers</returns>
        public static ref int SetHighestValueOf(this ref int first, int second, int third)
        {
            first = second > third ? second : third;
            return ref first;
        }

        /// <summary>
        /// Compare original and second number and set the variable with the lowest
        /// </summary>
        /// <param name="first">The number</param>
        /// <param name="second">The number to compare with</param>
        /// <param name="third">The third <see cref="int"/></param>
        /// <returns>Sets the variable to the lowest of the two numbers</returns>
        public static ref int SetLowestValueOf(this ref int first, int second, int third)
        {
            first = second < third ? second : third;
            return ref first;
        }

        /// <summary>
        /// Gets shift left of byte from int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int ShiftLeft(this int x, byte y) => x << (int)y;

        /// <summary>
        /// Gets shift left of char from int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int ShiftLeft(this int x, char y) => x << (int)y;

        /// <summary>
        /// Gets shift left of decimal from int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int ShiftLeft(this int x, decimal y) => x << (int)y;

        /// <summary>
        /// Gets shift left of double from int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int ShiftLeft(this int x, double y) => x << (int)y;

        /// <summary>
        /// Gets shift left of float from int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int ShiftLeft(this int x, float y) => x << (int)y;

        /// <summary>
        /// Gets shift left of int from int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int ShiftLeft(this int x, int y) => x << y;

        /// <summary>
        /// Gets shift left of long from int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int ShiftLeft(this int x, long y) => x << (int)y;

        /// <summary>
        /// Gets shift left of sbyte from int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int ShiftLeft(this int x, sbyte y) => x << (int)y;

        /// <summary>
        /// Gets shift left of short from int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int ShiftLeft(this int x, short y) => x << (int)y;

        /// <summary>
        /// Gets shift left of uint from int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int ShiftLeft(this int x, uint y) => x << (int)y;

        /// <summary>
        /// Gets shift left of ulong from int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int ShiftLeft(this int x, ulong y) => x << (int)y;

        /// <summary>
        /// Gets shift left of ushort from int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int ShiftLeft(this int x, ushort y) => x << (int)y;

        /// <summary>
        /// Gets shift right of byte from int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int ShiftRight(this int x, byte y) => x >> (int)y;

        /// <summary>
        /// Gets shift right of char from int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int ShiftRight(this int x, char y) => x >> (int)y;

        /// <summary>
        /// Gets shift right of decimal from int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int ShiftRight(this int x, decimal y) => x >> (int)y;

        /// <summary>
        /// Gets shift right of double from int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int ShiftRight(this int x, double y) => x >> (int)y;

        /// <summary>
        /// Gets shift right of float from int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int ShiftRight(this int x, float y) => x >> (int)y;

        /// <summary>
        /// Gets shift right of int from int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int ShiftRight(this int x, int y) => x >> y;

        /// <summary>
        /// Gets shift right of long from int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int ShiftRight(this int x, long y) => x >> (int)y;

        /// <summary>
        /// Gets shift right of sbyte from int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int ShiftRight(this int x, sbyte y) => x >> (int)y;

        /// <summary>
        /// Gets shift right of short from int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int ShiftRight(this int x, short y) => x >> (int)y;

        /// <summary>
        /// Gets shift right of uint from int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int ShiftRight(this int x, uint y) => x >> (int)y;

        /// <summary>
        /// Gets shift right of ulong from int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int ShiftRight(this int x, ulong y) => x >> (int)y;

        /// <summary>
        /// Gets shift right of ushort from int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int ShiftRight(this int x, ushort y) => x >> (int)y;

        /// <summary>
        /// Subtracts byte from int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(int,byte) instead.", false)]
        public static int Substract(this int x, byte y) => x - (int)y;

        /// <summary>
        /// Subtracts char from int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(int,char) instead.", false)]
        public static int Substract(this int x, char y) => x - (int)y;

        /// <summary>
        /// Subtracts decimal from int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(int,decimal) instead.", false)]
        public static int Substract(this int x, decimal y) => x - (int)y;

        /// <summary>
        /// Subtracts double from int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(int,double) instead.", false)]
        public static int Substract(this int x, double y) => x - (int)y;

        /// <summary>
        /// Subtracts float from int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(int,float) instead.", false)]
        public static int Substract(this int x, float y) => x - (int)y;

        /// <summary>
        /// Subtracts int from int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(int,int) instead.", false)]
        public static int Substract(this int x, int y) => x - y;

        /// <summary>
        /// Subtracts long from int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(int,long) instead.", false)]
        public static int Substract(this int x, long y) => x - (int)y;

        /// <summary>
        /// Subtracts sbyte from int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(int,sbyte) instead.", false)]
        public static int Substract(this int x, sbyte y) => x - (int)y;

        /// <summary>
        /// Subtracts short from int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(int,short) instead.", false)]
        public static int Substract(this int x, short y) => x - (int)y;

        /// <summary>
        /// Subtracts uint from int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(int,uint) instead.", false)]
        public static int Substract(this int x, uint y) => x - (int)y;

        /// <summary>
        /// Subtracts ulong from int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(int,ulong) instead.", false)]
        public static int Substract(this int x, ulong y) => x - (int)y;

        /// <summary>
        /// Subtracts ushort from int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(int,ushort) instead.", false)]
        public static int Substract(this int x, ushort y) => x - (int)y;

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(byte) instead.", false)]
        public static int SubstractPercent(this int value, byte percent) => (int)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(char) instead.", false)]
        public static int SubstractPercent(this int value, char percent) => (int)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(decimal) instead.", false)]
        public static int SubstractPercent(this int value, decimal percent) => (int)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(double) instead.", false)]
        public static int SubstractPercent(this int value, double percent) => (int)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(float) instead.", false)]
        public static int SubstractPercent(this int value, float percent) => (int)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(int) instead.", false)]
        public static int SubstractPercent(this int value, int percent) => (int)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(long) instead.", false)]
        public static int SubstractPercent(this int value, long percent) => (int)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(sbyte) instead.", false)]
        public static int SubstractPercent(this int value, sbyte percent) => (int)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(short) instead.", false)]
        public static int SubstractPercent(this int value, short percent) => (int)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(uint) instead.", false)]
        public static int SubstractPercent(this int value, uint percent) => (int)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(ulong) instead.", false)]
        public static int SubstractPercent(this int value, ulong percent) => (int)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(ushort) instead.", false)]
        public static int SubstractPercent(this int value, ushort percent) => (int)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts byte from int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int Subtract(this int x, byte y) => x - (int)y;

        /// <summary>
        /// Subtracts char from int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int Subtract(this int x, char y) => x - (int)y;

        /// <summary>
        /// Subtracts decimal from int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int Subtract(this int x, decimal y) => x - (int)y;

        /// <summary>
        /// Subtracts double from int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int Subtract(this int x, double y) => x - (int)y;

        /// <summary>
        /// Subtracts float from int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int Subtract(this int x, float y) => x - (int)y;

        /// <summary>
        /// Subtracts int from int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int Subtract(this int x, int y) => x - y;

        /// <summary>
        /// Subtracts long from int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int Subtract(this int x, long y) => x - (int)y;

        /// <summary>
        /// Subtracts sbyte from int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int Subtract(this int x, sbyte y) => x - (int)y;

        /// <summary>
        /// Subtracts short from int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int Subtract(this int x, short y) => x - (int)y;

        /// <summary>
        /// Subtracts uint from int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int Subtract(this int x, uint y) => x - (int)y;

        /// <summary>
        /// Subtracts ulong from int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int Subtract(this int x, ulong y) => x - (int)y;

        /// <summary>
        /// Subtracts ushort from int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int Subtract(this int x, ushort y) => x - (int)y;

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static int SubtractPercent(this int value, byte percent) => (int)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static int SubtractPercent(this int value, char percent) => (int)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static int SubtractPercent(this int value, decimal percent) => (int)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static int SubtractPercent(this int value, double percent) => (int)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static int SubtractPercent(this int value, float percent) => (int)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static int SubtractPercent(this int value, int percent) => (int)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static int SubtractPercent(this int value, long percent) => (int)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static int SubtractPercent(this int value, sbyte percent) => (int)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static int SubtractPercent(this int value, short percent) => (int)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static int SubtractPercent(this int value, uint percent) => (int)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static int SubtractPercent(this int value, ulong percent) => (int)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static int SubtractPercent(this int value, ushort percent) => (int)(value - value.PercentOf(percent));

        /// <summary>
        /// Swaps two variables
        /// </summary>
        /// <param name="first">The main variable</param>
        /// <param name="second">The variable to switch with</param>
        /// <returns>
        /// The value from the second variable and sets second variable to original value
        /// </returns>
        public static ref int SwapWith(this ref int first, ref int second)
        {
            var tmp = second;
            second = first;
            first = tmp;
            return ref first;
        }

        /// <summary>
        /// Gets XOR of byte of int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int Xor(this int x, byte y) => x ^ (int)y;

        /// <summary>
        /// Gets XOR of char of int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int Xor(this int x, char y) => x ^ (int)y;

        /// <summary>
        /// Gets XOR of decimal of int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int Xor(this int x, decimal y) => x ^ (int)y;

        /// <summary>
        /// Gets XOR of double of int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int Xor(this int x, double y) => x ^ (int)y;

        /// <summary>
        /// Gets XOR of float of int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int Xor(this int x, float y) => x ^ (int)y;

        /// <summary>
        /// Gets XOR of int of int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int Xor(this int x, int y) => x ^ y;

        /// <summary>
        /// Gets XOR of long of int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int Xor(this int x, long y) => x ^ (int)y;

        /// <summary>
        /// Gets XOR of sbyte of int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int Xor(this int x, sbyte y) => x ^ (int)y;

        /// <summary>
        /// Gets XOR of short of int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int Xor(this int x, short y) => x ^ (int)y;

        /// <summary>
        /// Gets XOR of uint of int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int Xor(this int x, uint y) => x ^ (int)y;

        /// <summary>
        /// Gets XOR of ulong of int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int Xor(this int x, ulong y) => x ^ (int)y;

        /// <summary>
        /// Gets XOR of ushort of int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static int Xor(this int x, ushort y) => x ^ (int)y;
    }
}