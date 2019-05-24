//----------------------------------------------------------------------------------------------
// <copyright file="TypedMathUshortExtension.cs" company="MarcusMedinaPro">
// By Marcus Medina, 2019 - http://MarcusMedina.Pro 
// This file is subject to the terms and conditions defined in file 'license.txt', which is part of this project.
// </copyright>
// ----------------------------------------------------------------------------------------------
namespace MarcusMedinaPro.TypedMath.UshortExtension
{
    using System;
    using System.Linq;

    public static class TypedMathUshortExtension
    {
        /// <summary>
        /// Adds byte to ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort Add(this ushort x, byte y) => (ushort)(x + y);

        /// <summary>
        /// Adds char to ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort Add(this ushort x, char y) => (ushort)(x + y);

        /// <summary>
        /// Adds decimal to ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort Add(this ushort x, decimal y) => (ushort)(x + (int)y);

        /// <summary>
        /// Adds double to ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort Add(this ushort x, double y) => (ushort)(x + (int)y);

        /// <summary>
        /// Adds float to ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort Add(this ushort x, float y) => (ushort)(x + (int)y);

        /// <summary>
        /// Adds int to ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort Add(this ushort x, int y) => (ushort)(x + y);

        /// <summary>
        /// Adds long to ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort Add(this ushort x, long y) => (ushort)(x + (int)y);

        /// <summary>
        /// Adds sbyte to ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort Add(this ushort x, sbyte y) => (ushort)(x + y);

        /// <summary>
        /// Adds short to ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort Add(this ushort x, short y) => (ushort)(x + y);

        /// <summary>
        /// Adds uint to ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort Add(this ushort x, uint y) => (ushort)(x + (int)y);

        /// <summary>
        /// Adds ulong to ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort Add(this ushort x, ulong y) => (ushort)(x + (int)y);

        /// <summary>
        /// Adds ushort to ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort Add(this ushort x, ushort y) => (ushort)(x + y);

        /// <summary>
        /// Gets the AND of byte and ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort And(this ushort x, byte y) => (ushort)(x & y);

        /// <summary>
        /// Gets the AND of char and ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort And(this ushort x, char y) => (ushort)(x & y);

        /// <summary>
        /// Gets the AND of decimal and ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort And(this ushort x, decimal y) => (ushort)(x & (int)y);

        /// <summary>
        /// Gets the AND of double and ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort And(this ushort x, double y) => (ushort)(x & (int)y);

        /// <summary>
        /// Gets the AND of float and ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort And(this ushort x, float y) => (ushort)(x & (int)y);

        /// <summary>
        /// Gets the AND of int and ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort And(this ushort x, int y) => (ushort)(x & y);

        /// <summary>
        /// Gets the AND of long and ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort And(this ushort x, long y) => (ushort)(x & (int)y);

        /// <summary>
        /// Gets the AND of sbyte and ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort And(this ushort x, sbyte y) => (ushort)(x & y);

        /// <summary>
        /// Gets the AND of short and ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort And(this ushort x, short y) => (ushort)(x & y);

        /// <summary>
        /// Gets the AND of uint and ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort And(this ushort x, uint y) => (ushort)(x & (int)y);

        /// <summary>
        /// Gets the AND of ulong and ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort And(this ushort x, ulong y) => (ushort)(x & (int)y);

        /// <summary>
        /// Gets the AND of ushort and ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort And(this ushort x, ushort y) => (ushort)(x & y);

        /// <summary>
        /// Tries to cast ushort to byte, this can get ugly though
        /// </summary>
        /// <param name="x">The original value</param>
        /// <returns>The result of the operation</returns>
        public static byte CastUshortToByte(this ushort x) => (byte)x;

        /// <summary>
        /// Tries to cast ushort to char, this can get ugly though
        /// </summary>
        /// <param name="x">The original value</param>
        /// <returns>The result of the operation</returns>
        public static char CastUshortToChar(this ushort x) => (char)x;

        /// <summary>
        /// Tries to cast ushort to decimal, this can get ugly though
        /// </summary>
        /// <param name="x">The original value</param>
        /// <returns>The result of the operation</returns>
        public static decimal CastUshortToDecimal(this ushort x) => x;

        /// <summary>
        /// Tries to cast ushort to double, this can get ugly though
        /// </summary>
        /// <param name="x">The original value</param>
        /// <returns>The result of the operation</returns>
        public static double CastUshortToDouble(this ushort x) => x;

        /// <summary>
        /// Tries to cast ushort to float, this can get ugly though
        /// </summary>
        /// <param name="x">The original value</param>
        /// <returns>The result of the operation</returns>
        public static float CastUshortToFloat(this ushort x) => x;

        /// <summary>
        /// Tries to cast ushort to int, this can get ugly though
        /// </summary>
        /// <param name="x">The original value</param>
        /// <returns>The result of the operation</returns>
        public static int CastUshortToInt(this ushort x) => x;

        /// <summary>
        /// Tries to cast ushort to long, this can get ugly though
        /// </summary>
        /// <param name="x">The original value</param>
        /// <returns>The result of the operation</returns>
        public static long CastUshortToLong(this ushort x) => x;

        /// <summary>
        /// Tries to cast ushort to sbyte, this can get ugly though
        /// </summary>
        /// <param name="x">The original value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte CastUshortToSbyte(this ushort x) => (sbyte)x;

        /// <summary>
        /// Tries to cast ushort to short, this can get ugly though
        /// </summary>
        /// <param name="x">The original value</param>
        /// <returns>The result of the operation</returns>
        public static short CastUshortToShort(this ushort x) => (short)x;

        /// <summary>
        /// Tries to cast ushort to uint, this can get ugly though
        /// </summary>
        /// <param name="x">The original value</param>
        /// <returns>The result of the operation</returns>
        public static uint CastUshortToUint(this ushort x) => x;

        /// <summary>
        /// Tries to cast ushort to ulong, this can get ugly though
        /// </summary>
        /// <param name="x">The original value</param>
        /// <returns>The result of the operation</returns>
        public static ulong CastUshortToUlong(this ushort x) => x;

        /// <summary>
        /// Divides byte from ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort DividedBy(this ushort x, byte y) => (ushort)(x / y);

        /// <summary>
        /// Divides char from ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort DividedBy(this ushort x, char y) => (ushort)(x / y);

        /// <summary>
        /// Divides decimal from ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort DividedBy(this ushort x, decimal y) => (ushort)(x / (int)y);

        /// <summary>
        /// Divides double from ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort DividedBy(this ushort x, double y) => (ushort)(x / (int)y);

        /// <summary>
        /// Divides float from ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort DividedBy(this ushort x, float y) => (ushort)(x / (int)y);

        /// <summary>
        /// Divides int from ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort DividedBy(this ushort x, int y) => (ushort)(x / y);

        /// <summary>
        /// Divides long from ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort DividedBy(this ushort x, long y) => (ushort)(x / (int)y);

        /// <summary>
        /// Divides sbyte from ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort DividedBy(this ushort x, sbyte y) => (ushort)(x / y);

        /// <summary>
        /// Divides short from ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort DividedBy(this ushort x, short y) => (ushort)(x / y);

        /// <summary>
        /// Divides uint from ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort DividedBy(this ushort x, uint y) => (ushort)(x / (int)y);

        /// <summary>
        /// Divides ulong from ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort DividedBy(this ushort x, ulong y) => (ushort)(x / (int)y);

        /// <summary>
        /// Divides ushort from ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort DividedBy(this ushort x, ushort y) => (ushort)(x / y);

        /// <summary>
        /// Gets a boolean True if ushort is greater than byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this ushort x, byte y) => x > y;

        /// <summary>
        /// Gets a boolean True if ushort is greater than char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this ushort x, char y) => x > y;

        /// <summary>
        /// Gets a boolean True if ushort is greater than decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this ushort x, decimal y) => x > (ushort)y;

        /// <summary>
        /// Gets a boolean True if ushort is greater than double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this ushort x, double y) => x > (ushort)y;

        /// <summary>
        /// Gets a boolean True if ushort is greater than float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this ushort x, float y) => x > (ushort)y;

        /// <summary>
        /// Gets a boolean True if ushort is greater than int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this ushort x, int y) => x > (ushort)y;

        /// <summary>
        /// Gets a boolean True if ushort is greater than long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this ushort x, long y) => x > (ushort)y;

        /// <summary>
        /// Gets a boolean True if ushort is greater than sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this ushort x, sbyte y) => x > (ushort)y;

        /// <summary>
        /// Gets a boolean True if ushort is greater than short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this ushort x, short y) => x > (ushort)y;

        /// <summary>
        /// Gets a boolean True if ushort is greater than uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this ushort x, uint y) => x > (ushort)y;

        /// <summary>
        /// Gets a boolean True if ushort is greater than ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this ushort x, ulong y) => x > (ushort)y;

        /// <summary>
        /// Gets a boolean True if ushort is greater than ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this ushort x, ushort y) => x > y;

        /// <summary>
        /// Gets boolean True if byte is equal to ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this ushort x, byte y) => x == y;

        /// <summary>
        /// Gets boolean True if char is equal to ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this ushort x, char y) => x == y;

        /// <summary>
        /// Gets boolean True if decimal is equal to ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this ushort x, decimal y) => x == (ushort)y;

        /// <summary>
        /// Gets boolean True if double is equal to ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this ushort x, double y) => x == (ushort)y;

        /// <summary>
        /// Gets boolean True if float is equal to ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this ushort x, float y) => x == (ushort)y;

        /// <summary>
        /// Gets boolean True if int is equal to ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this ushort x, int y) => x == (ushort)y;

        /// <summary>
        /// Gets boolean True if long is equal to ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this ushort x, long y) => x == (ushort)y;

        /// <summary>
        /// Gets boolean True if sbyte is equal to ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this ushort x, sbyte y) => x == (ushort)y;

        /// <summary>
        /// Gets boolean True if short is equal to ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this ushort x, short y) => x == (ushort)y;

        /// <summary>
        /// Gets boolean True if uint is equal to ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this ushort x, uint y) => x == (ushort)y;

        /// <summary>
        /// Gets boolean True if ulong is equal to ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this ushort x, ulong y) => x == (ushort)y;

        /// <summary>
        /// Gets boolean True if ushort is equal to ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this ushort x, ushort y) => x == y;

        /// <summary>
        /// Gets boolean True if byte is not equal to ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this ushort x, byte y) => x != y;

        /// <summary>
        /// Gets boolean True if char is not equal to ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this ushort x, char y) => x != y;

        /// <summary>
        /// Gets boolean True if decimal is not equal to ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this ushort x, decimal y) => x != (ushort)y;

        /// <summary>
        /// Gets boolean True if double is not equal to ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this ushort x, double y) => x != (ushort)y;

        /// <summary>
        /// Gets boolean True if float is not equal to ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this ushort x, float y) => x != (ushort)y;

        /// <summary>
        /// Gets boolean True if int is not equal to ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this ushort x, int y) => x != (ushort)y;

        /// <summary>
        /// Gets boolean True if long is not equal to ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this ushort x, long y) => x != (ushort)y;

        /// <summary>
        /// Gets boolean True if sbyte is not equal to ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this ushort x, sbyte y) => x != (ushort)y;

        /// <summary>
        /// Gets boolean True if short is not equal to ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this ushort x, short y) => x != (ushort)y;

        /// <summary>
        /// Gets boolean True if uint is not equal to ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this ushort x, uint y) => x != (ushort)y;

        /// <summary>
        /// Gets boolean True if ulong is not equal to ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this ushort x, ulong y) => x != (ushort)y;

        /// <summary>
        /// Gets boolean True if ushort is not equal to ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this ushort x, ushort y) => x != y;

        /// <summary>
        /// Checks if a number is prime
        /// </summary>
        /// <param name="number">The number</param>
        /// <returns>True if the number is prime</returns>
        public static bool IsPrime(this ushort number) => Enumerable.Range(2, (int)Math.Sqrt(number) - 1).All(divisor => number % divisor != 0);

        /// <summary>
        /// Gets a boolean True if ushort is less than byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this ushort x, byte y) => x < y;

        /// <summary>
        /// Gets a boolean True if ushort is less than char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this ushort x, char y) => x < y;

        /// <summary>
        /// Gets a boolean True if ushort is less than decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this ushort x, decimal y) => x < (ushort)y;

        /// <summary>
        /// Gets a boolean True if ushort is less than double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this ushort x, double y) => x < (ushort)y;

        /// <summary>
        /// Gets a boolean True if ushort is less than float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this ushort x, float y) => x < (ushort)y;

        /// <summary>
        /// Gets a boolean True if ushort is less than int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this ushort x, int y) => x < (ushort)y;

        /// <summary>
        /// Gets a boolean True if ushort is less than long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this ushort x, long y) => x < (ushort)y;

        /// <summary>
        /// Gets a boolean True if ushort is less than sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this ushort x, sbyte y) => x < (ushort)y;

        /// <summary>
        /// Gets a boolean True if ushort is less than short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this ushort x, short y) => x < (ushort)y;

        /// <summary>
        /// Gets a boolean True if ushort is less than uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this ushort x, uint y) => x < (ushort)y;

        /// <summary>
        /// Gets a boolean True if ushort is less than ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this ushort x, ulong y) => x < (ushort)y;

        /// <summary>
        /// Gets a boolean True if ushort is less than ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this ushort x, ushort y) => x < y;

        /// <summary>
        /// Gets the remainder of byte from ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort Modulus(this ushort x, byte y) => (ushort)(x % y);

        /// <summary>
        /// Gets the remainder of char from ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort Modulus(this ushort x, char y) => (ushort)(x % y);

        /// <summary>
        /// Gets the remainder of decimal from ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort Modulus(this ushort x, decimal y) => (ushort)(x % (int)y);

        /// <summary>
        /// Gets the remainder of double from ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort Modulus(this ushort x, double y) => (ushort)(x % (int)y);

        /// <summary>
        /// Gets the remainder of float from ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort Modulus(this ushort x, float y) => (ushort)(x % (int)y);

        /// <summary>
        /// Gets the remainder of int from ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort Modulus(this ushort x, int y) => (ushort)(x % y);

        /// <summary>
        /// Gets the remainder of long from ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort Modulus(this ushort x, long y) => (ushort)(x % (int)y);

        /// <summary>
        /// Gets the remainder of sbyte from ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort Modulus(this ushort x, sbyte y) => (ushort)(x % y);

        /// <summary>
        /// Gets the remainder of short from ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort Modulus(this ushort x, short y) => (ushort)(x % y);

        /// <summary>
        /// Gets the remainder of uint from ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort Modulus(this ushort x, uint y) => (ushort)(x % (int)y);

        /// <summary>
        /// Gets the remainder of ulong from ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort Modulus(this ushort x, ulong y) => (ushort)(x % (int)y);

        /// <summary>
        /// Gets the remainder of ushort from ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort Modulus(this ushort x, ushort y) => (ushort)(x % y);

        /// <summary>
        /// Multiplies byte with ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort MultipliedWith(this ushort x, byte y) => (ushort)(x * y);

        /// <summary>
        /// Multiplies char with ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort MultipliedWith(this ushort x, char y) => (ushort)(x * y);

        /// <summary>
        /// Multiplies decimal with ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort MultipliedWith(this ushort x, decimal y) => (ushort)(x * (int)y);

        /// <summary>
        /// Multiplies double with ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort MultipliedWith(this ushort x, double y) => (ushort)(x * (int)y);

        /// <summary>
        /// Multiplies float with ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort MultipliedWith(this ushort x, float y) => (ushort)(x * (int)y);

        /// <summary>
        /// Multiplies int with ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort MultipliedWith(this ushort x, int y) => (ushort)(x * y);

        /// <summary>
        /// Multiplies long with ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort MultipliedWith(this ushort x, long y) => (ushort)(x * (int)y);

        /// <summary>
        /// Multiplies sbyte with ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort MultipliedWith(this ushort x, sbyte y) => (ushort)(x * y);

        /// <summary>
        /// Multiplies short with ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort MultipliedWith(this ushort x, short y) => (ushort)(x * y);

        /// <summary>
        /// Multiplies uint with ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort MultipliedWith(this ushort x, uint y) => (ushort)(x * (int)y);

        /// <summary>
        /// Multiplies ulong with ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort MultipliedWith(this ushort x, ulong y) => (ushort)(x * (int)y);

        /// <summary>
        /// Multiplies ushort with ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort MultipliedWith(this ushort x, ushort y) => (ushort)(x * y);

        /// <summary>
        /// Gets the NOT of ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <returns>The result of the operation</returns>
        public static ushort Not(this ushort x) => (ushort)~(int)x;

        /// <summary>
        /// Gets the OR of byte and ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort Or(this ushort x, byte y) => (ushort)(x | y);

        /// <summary>
        /// Gets the OR of char and ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort Or(this ushort x, char y) => (ushort)(x | y);

        /// <summary>
        /// Gets the OR of decimal and ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort Or(this ushort x, decimal y) => (ushort)(x | (int)y);

        /// <summary>
        /// Gets the OR of double and ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort Or(this ushort x, double y) => (ushort)(x | (int)y);

        /// <summary>
        /// Gets the OR of float and ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort Or(this ushort x, float y) => (ushort)(x | (int)y);

        /// <summary>
        /// Gets the OR of int and ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort Or(this ushort x, int y) => (ushort)(x | y);

        /// <summary>
        /// Gets the OR of long and ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort Or(this ushort x, long y) => (ushort)(x | (int)y);

        /// <summary>
        /// Gets the OR of sbyte and ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort Or(this ushort x, sbyte y) => (ushort)(x | y);

        /// <summary>
        /// Gets the OR of short and ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort Or(this ushort x, short y) => (ushort)(x | y);

        /// <summary>
        /// Gets the OR of uint and ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort Or(this ushort x, uint y) => (ushort)(x | (int)y);

        /// <summary>
        /// Gets the OR of ulong and ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort Or(this ushort x, ulong y) => (ushort)(x | (int)y);

        /// <summary>
        /// Gets the OR of ushort and ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort Or(this ushort x, ushort y) => (ushort)(x | y);

        /// <summary>
        /// Gets shift left of byte from ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort ShiftLeft(this ushort x, byte y) => (ushort)(x << y);

        /// <summary>
        /// Gets shift left of char from ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort ShiftLeft(this ushort x, char y) => (ushort)(x << y);

        /// <summary>
        /// Gets shift left of decimal from ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort ShiftLeft(this ushort x, decimal y) => (ushort)(x << (int)y);

        /// <summary>
        /// Gets shift left of double from ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort ShiftLeft(this ushort x, double y) => (ushort)(x << (int)y);

        /// <summary>
        /// Gets shift left of float from ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort ShiftLeft(this ushort x, float y) => (ushort)(x << (int)y);

        /// <summary>
        /// Gets shift left of int from ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort ShiftLeft(this ushort x, int y) => (ushort)(x << y);

        /// <summary>
        /// Gets shift left of long from ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort ShiftLeft(this ushort x, long y) => (ushort)(x << (int)y);

        /// <summary>
        /// Gets shift left of sbyte from ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort ShiftLeft(this ushort x, sbyte y) => (ushort)(x << y);

        /// <summary>
        /// Gets shift left of short from ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort ShiftLeft(this ushort x, short y) => (ushort)(x << y);

        /// <summary>
        /// Gets shift left of uint from ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort ShiftLeft(this ushort x, uint y) => (ushort)(x << (int)y);

        /// <summary>
        /// Gets shift left of ulong from ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort ShiftLeft(this ushort x, ulong y) => (ushort)(x << (int)y);

        /// <summary>
        /// Gets shift left of ushort from ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort ShiftLeft(this ushort x, ushort y) => (ushort)(x << y);

        /// <summary>
        /// Gets shift right of byte from ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort ShiftRight(this ushort x, byte y) => (ushort)(x >> y);

        /// <summary>
        /// Gets shift right of char from ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort ShiftRight(this ushort x, char y) => (ushort)(x >> y);

        /// <summary>
        /// Gets shift right of decimal from ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort ShiftRight(this ushort x, decimal y) => (ushort)(x >> (int)y);

        /// <summary>
        /// Gets shift right of double from ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort ShiftRight(this ushort x, double y) => (ushort)(x >> (int)y);

        /// <summary>
        /// Gets shift right of float from ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort ShiftRight(this ushort x, float y) => (ushort)(x >> (int)y);

        /// <summary>
        /// Gets shift right of int from ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort ShiftRight(this ushort x, int y) => (ushort)(x >> y);

        /// <summary>
        /// Gets shift right of long from ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort ShiftRight(this ushort x, long y) => (ushort)(x >> (int)y);

        /// <summary>
        /// Gets shift right of sbyte from ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort ShiftRight(this ushort x, sbyte y) => (ushort)(x >> y);

        /// <summary>
        /// Gets shift right of short from ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort ShiftRight(this ushort x, short y) => (ushort)(x >> y);

        /// <summary>
        /// Gets shift right of uint from ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort ShiftRight(this ushort x, uint y) => (ushort)(x >> (int)y);

        /// <summary>
        /// Gets shift right of ulong from ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort ShiftRight(this ushort x, ulong y) => (ushort)(x >> (int)y);

        /// <summary>
        /// Gets shift right of ushort from ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort ShiftRight(this ushort x, ushort y) => (ushort)(x >> y);

        /// <summary>
        /// Substracts byte from ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort Substract(this ushort x, byte y) => (ushort)(x - y);

        /// <summary>
        /// Substracts char from ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort Substract(this ushort x, char y) => (ushort)(x - y);

        /// <summary>
        /// Substracts decimal from ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort Substract(this ushort x, decimal y) => (ushort)(x - (int)y);

        /// <summary>
        /// Substracts double from ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort Substract(this ushort x, double y) => (ushort)(x - (int)y);

        /// <summary>
        /// Substracts float from ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort Substract(this ushort x, float y) => (ushort)(x - (int)y);

        /// <summary>
        /// Substracts int from ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort Substract(this ushort x, int y) => (ushort)(x - y);

        /// <summary>
        /// Substracts long from ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort Substract(this ushort x, long y) => (ushort)(x - (int)y);

        /// <summary>
        /// Substracts sbyte from ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort Substract(this ushort x, sbyte y) => (ushort)(x - y);

        /// <summary>
        /// Substracts short from ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort Substract(this ushort x, short y) => (ushort)(x - y);

        /// <summary>
        /// Substracts uint from ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort Substract(this ushort x, uint y) => (ushort)(x - (int)y);

        /// <summary>
        /// Substracts ulong from ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort Substract(this ushort x, ulong y) => (ushort)(x - (int)y);

        /// <summary>
        /// Substracts ushort from ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort Substract(this ushort x, ushort y) => (ushort)(x - y);

        /// <summary>
        /// Gets XOR of byte of ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort Xor(this ushort x, byte y) => (ushort)(x ^ y);

        /// <summary>
        /// Gets XOR of char of ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort Xor(this ushort x, char y) => (ushort)(x ^ y);

        /// <summary>
        /// Gets XOR of decimal of ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort Xor(this ushort x, decimal y) => (ushort)(x ^ (int)y);

        /// <summary>
        /// Gets XOR of double of ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort Xor(this ushort x, double y) => (ushort)(x ^ (int)y);

        /// <summary>
        /// Gets XOR of float of ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort Xor(this ushort x, float y) => (ushort)(x ^ (int)y);

        /// <summary>
        /// Gets XOR of int of ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort Xor(this ushort x, int y) => (ushort)(x ^ y);

        /// <summary>
        /// Gets XOR of long of ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort Xor(this ushort x, long y) => (ushort)(x ^ (int)y);

        /// <summary>
        /// Gets XOR of sbyte of ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort Xor(this ushort x, sbyte y) => (ushort)(x ^ y);

        /// <summary>
        /// Gets XOR of short of ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort Xor(this ushort x, short y) => (ushort)(x ^ y);

        /// <summary>
        /// Gets XOR of uint of ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort Xor(this ushort x, uint y) => (ushort)(x ^ (int)y);

        /// <summary>
        /// Gets XOR of ulong of ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort Xor(this ushort x, ulong y) => (ushort)(x ^ (int)y);

        /// <summary>
        /// Gets XOR of ushort of ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static ushort Xor(this ushort x, ushort y) => (ushort)(x ^ y);
    }
}