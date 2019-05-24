//----------------------------------------------------------------------------------------------
// <copyright file="TypedMathUintExtension.cs" company="MarcusMedinaPro">
// By Marcus Medina, 2019 - http://MarcusMedina.Pro 
// This file is subject to the terms and conditions defined in file 'license.txt', which is part of this project.
// </copyright>
// ----------------------------------------------------------------------------------------------
namespace MarcusMedinaPro.TypedMath.UintExtension
{
    using System;
    using System.Linq;

    public static class TypedMathUintExtension
    {
        /// <summary>
        /// Adds byte to uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Add(this uint x, byte y) => x + y;

        /// <summary>
        /// Adds char to uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Add(this uint x, char y) => x + y;

        /// <summary>
        /// Adds decimal to uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Add(this uint x, decimal y) => x + (uint)y;

        /// <summary>
        /// Adds double to uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Add(this uint x, double y) => x + (uint)y;

        /// <summary>
        /// Adds float to uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Add(this uint x, float y) => x + (uint)y;

        /// <summary>
        /// Adds int to uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Add(this uint x, int y) => x + (uint)y;

        /// <summary>
        /// Adds long to uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Add(this uint x, long y) => x + (uint)y;

        /// <summary>
        /// Adds sbyte to uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Add(this uint x, sbyte y) => x + (uint)y;

        /// <summary>
        /// Adds short to uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Add(this uint x, short y) => x + (uint)y;

        /// <summary>
        /// Adds uint to uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Add(this uint x, uint y) => x + y;

        /// <summary>
        /// Adds ulong to uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Add(this uint x, ulong y) => x + (uint)y;

        /// <summary>
        /// Adds ushort to uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Add(this uint x, ushort y) => x + y;

        /// <summary>
        /// Gets the AND of byte and uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint And(this uint x, byte y) => x & y;

        /// <summary>
        /// Gets the AND of char and uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint And(this uint x, char y) => x & y;

        /// <summary>
        /// Gets the AND of decimal and uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint And(this uint x, decimal y) => x & (uint)y;

        /// <summary>
        /// Gets the AND of double and uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint And(this uint x, double y) => x & (uint)y;

        /// <summary>
        /// Gets the AND of float and uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint And(this uint x, float y) => x & (uint)y;

        /// <summary>
        /// Gets the AND of int and uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint And(this uint x, int y) => x & (uint)y;

        /// <summary>
        /// Gets the AND of long and uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint And(this uint x, long y) => x & (uint)y;

        /// <summary>
        /// Gets the AND of sbyte and uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint And(this uint x, sbyte y) => x & (uint)y;

        /// <summary>
        /// Gets the AND of short and uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint And(this uint x, short y) => x & (uint)y;

        /// <summary>
        /// Gets the AND of uint and uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint And(this uint x, uint y) => x & y;

        /// <summary>
        /// Gets the AND of ulong and uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint And(this uint x, ulong y) => x & (uint)y;

        /// <summary>
        /// Gets the AND of ushort and uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint And(this uint x, ushort y) => x & y;

        /// <summary>
        /// Tries to cast uint to byte, this can get ugly though
        /// </summary>
        /// <param name="x">The original value</param>
        /// <returns>The result of the operation</returns>
        public static byte CastUintToByte(this uint x) => (byte)x;

        /// <summary>
        /// Tries to cast uint to char, this can get ugly though
        /// </summary>
        /// <param name="x">The original value</param>
        /// <returns>The result of the operation</returns>
        public static char CastUintToChar(this uint x) => (char)x;

        /// <summary>
        /// Tries to cast uint to decimal, this can get ugly though
        /// </summary>
        /// <param name="x">The original value</param>
        /// <returns>The result of the operation</returns>
        public static decimal CastUintToDecimal(this uint x) => x;

        /// <summary>
        /// Tries to cast uint to double, this can get ugly though
        /// </summary>
        /// <param name="x">The original value</param>
        /// <returns>The result of the operation</returns>
        public static double CastUintToDouble(this uint x) => x;

        /// <summary>
        /// Tries to cast uint to float, this can get ugly though
        /// </summary>
        /// <param name="x">The original value</param>
        /// <returns>The result of the operation</returns>
        public static float CastUintToFloat(this uint x) => x;

        /// <summary>
        /// Tries to cast uint to int, this can get ugly though
        /// </summary>
        /// <param name="x">The original value</param>
        /// <returns>The result of the operation</returns>
        public static int CastUintToInt(this uint x) => (int)x;

        /// <summary>
        /// Tries to cast uint to long, this can get ugly though
        /// </summary>
        /// <param name="x">The original value</param>
        /// <returns>The result of the operation</returns>
        public static long CastUintToLong(this uint x) => x;

        /// <summary>
        /// Tries to cast uint to sbyte, this can get ugly though
        /// </summary>
        /// <param name="x">The original value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte CastUintToSbyte(this uint x) => (sbyte)x;

        /// <summary>
        /// Tries to cast uint to short, this can get ugly though
        /// </summary>
        /// <param name="x">The original value</param>
        /// <returns>The result of the operation</returns>
        public static short CastUintToShort(this uint x) => (short)x;

        /// <summary>
        /// Tries to cast uint to ulong, this can get ugly though
        /// </summary>
        /// <param name="x">The original value</param>
        /// <returns>The result of the operation</returns>
        public static ulong CastUintToUlong(this uint x) => x;

        /// <summary>
        /// Tries to cast uint to ushort, this can get ugly though
        /// </summary>
        /// <param name="x">The original value</param>
        /// <returns>The result of the operation</returns>
        public static ushort CastUintToUshort(this uint x) => (ushort)x;

        /// <summary>
        /// Divides byte from uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint DividedBy(this uint x, byte y) => x / y;

        /// <summary>
        /// Divides char from uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint DividedBy(this uint x, char y) => x / y;

        /// <summary>
        /// Divides decimal from uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint DividedBy(this uint x, decimal y) => x / (uint)y;

        /// <summary>
        /// Divides double from uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint DividedBy(this uint x, double y) => x / (uint)y;

        /// <summary>
        /// Divides float from uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint DividedBy(this uint x, float y) => x / (uint)y;

        /// <summary>
        /// Divides int from uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint DividedBy(this uint x, int y) => x / (uint)y;

        /// <summary>
        /// Divides long from uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint DividedBy(this uint x, long y) => x / (uint)y;

        /// <summary>
        /// Divides sbyte from uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint DividedBy(this uint x, sbyte y) => x / (uint)y;

        /// <summary>
        /// Divides short from uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint DividedBy(this uint x, short y) => x / (uint)y;

        /// <summary>
        /// Divides uint from uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint DividedBy(this uint x, uint y) => x / y;

        /// <summary>
        /// Divides ulong from uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint DividedBy(this uint x, ulong y) => x / (uint)y;

        /// <summary>
        /// Divides ushort from uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint DividedBy(this uint x, ushort y) => x / y;

        /// <summary>
        /// Gets a boolean True if uint is greater than byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this uint x, byte y) => x > y;

        /// <summary>
        /// Gets a boolean True if uint is greater than char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this uint x, char y) => x > y;

        /// <summary>
        /// Gets a boolean True if uint is greater than decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this uint x, decimal y) => x > (uint)y;

        /// <summary>
        /// Gets a boolean True if uint is greater than double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this uint x, double y) => x > (uint)y;

        /// <summary>
        /// Gets a boolean True if uint is greater than float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this uint x, float y) => x > (uint)y;

        /// <summary>
        /// Gets a boolean True if uint is greater than int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this uint x, int y) => x > (uint)y;

        /// <summary>
        /// Gets a boolean True if uint is greater than long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this uint x, long y) => x > (uint)y;

        /// <summary>
        /// Gets a boolean True if uint is greater than sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this uint x, sbyte y) => x > (uint)y;

        /// <summary>
        /// Gets a boolean True if uint is greater than short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this uint x, short y) => x > (uint)y;

        /// <summary>
        /// Gets a boolean True if uint is greater than uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this uint x, uint y) => x > y;

        /// <summary>
        /// Gets a boolean True if uint is greater than ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this uint x, ulong y) => x > (uint)y;

        /// <summary>
        /// Gets a boolean True if uint is greater than ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this uint x, ushort y) => x > y;

        /// <summary>
        /// Gets boolean True if byte is equal to uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this uint x, byte y) => x == y;

        /// <summary>
        /// Gets boolean True if char is equal to uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this uint x, char y) => x == y;

        /// <summary>
        /// Gets boolean True if decimal is equal to uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this uint x, decimal y) => x == (uint)y;

        /// <summary>
        /// Gets boolean True if double is equal to uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this uint x, double y) => x == (uint)y;

        /// <summary>
        /// Gets boolean True if float is equal to uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this uint x, float y) => x == (uint)y;

        /// <summary>
        /// Gets boolean True if int is equal to uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this uint x, int y) => x == (uint)y;

        /// <summary>
        /// Gets boolean True if long is equal to uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this uint x, long y) => x == (uint)y;

        /// <summary>
        /// Gets boolean True if sbyte is equal to uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this uint x, sbyte y) => x == (uint)y;

        /// <summary>
        /// Gets boolean True if short is equal to uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this uint x, short y) => x == (uint)y;

        /// <summary>
        /// Gets boolean True if uint is equal to uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this uint x, uint y) => x == y;

        /// <summary>
        /// Gets boolean True if ulong is equal to uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this uint x, ulong y) => x == (uint)y;

        /// <summary>
        /// Gets boolean True if ushort is equal to uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this uint x, ushort y) => x == y;

        /// <summary>
        /// Gets boolean True if byte is not equal to uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this uint x, byte y) => x != y;

        /// <summary>
        /// Gets boolean True if char is not equal to uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this uint x, char y) => x != y;

        /// <summary>
        /// Gets boolean True if decimal is not equal to uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this uint x, decimal y) => x != (uint)y;

        /// <summary>
        /// Gets boolean True if double is not equal to uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this uint x, double y) => x != (uint)y;

        /// <summary>
        /// Gets boolean True if float is not equal to uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this uint x, float y) => x != (uint)y;

        /// <summary>
        /// Gets boolean True if int is not equal to uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this uint x, int y) => x != (uint)y;

        /// <summary>
        /// Gets boolean True if long is not equal to uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this uint x, long y) => x != (uint)y;

        /// <summary>
        /// Gets boolean True if sbyte is not equal to uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this uint x, sbyte y) => x != (uint)y;

        /// <summary>
        /// Gets boolean True if short is not equal to uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this uint x, short y) => x != (uint)y;

        /// <summary>
        /// Gets boolean True if uint is not equal to uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this uint x, uint y) => x != y;

        /// <summary>
        /// Gets boolean True if ulong is not equal to uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this uint x, ulong y) => x != (uint)y;

        /// <summary>
        /// Gets boolean True if ushort is not equal to uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this uint x, ushort y) => x != y;

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
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this uint x, byte y) => x < y;

        /// <summary>
        /// Gets a boolean True if uint is less than char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this uint x, char y) => x < y;

        /// <summary>
        /// Gets a boolean True if uint is less than decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this uint x, decimal y) => x < (uint)y;

        /// <summary>
        /// Gets a boolean True if uint is less than double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this uint x, double y) => x < (uint)y;

        /// <summary>
        /// Gets a boolean True if uint is less than float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this uint x, float y) => x < (uint)y;

        /// <summary>
        /// Gets a boolean True if uint is less than int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this uint x, int y) => x < (uint)y;

        /// <summary>
        /// Gets a boolean True if uint is less than long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this uint x, long y) => x < (uint)y;

        /// <summary>
        /// Gets a boolean True if uint is less than sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this uint x, sbyte y) => x < (uint)y;

        /// <summary>
        /// Gets a boolean True if uint is less than short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this uint x, short y) => x < (uint)y;

        /// <summary>
        /// Gets a boolean True if uint is less than uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this uint x, uint y) => x < y;

        /// <summary>
        /// Gets a boolean True if uint is less than ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this uint x, ulong y) => x < (uint)y;

        /// <summary>
        /// Gets a boolean True if uint is less than ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this uint x, ushort y) => x < y;

        /// <summary>
        /// Gets the remainder of byte from uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Modulus(this uint x, byte y) => x % y;

        /// <summary>
        /// Gets the remainder of char from uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Modulus(this uint x, char y) => x % y;

        /// <summary>
        /// Gets the remainder of decimal from uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Modulus(this uint x, decimal y) => x % (uint)y;

        /// <summary>
        /// Gets the remainder of double from uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Modulus(this uint x, double y) => x % (uint)y;

        /// <summary>
        /// Gets the remainder of float from uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Modulus(this uint x, float y) => x % (uint)y;

        /// <summary>
        /// Gets the remainder of int from uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Modulus(this uint x, int y) => x % (uint)y;

        /// <summary>
        /// Gets the remainder of long from uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Modulus(this uint x, long y) => x % (uint)y;

        /// <summary>
        /// Gets the remainder of sbyte from uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Modulus(this uint x, sbyte y) => x % (uint)y;

        /// <summary>
        /// Gets the remainder of short from uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Modulus(this uint x, short y) => x % (uint)y;

        /// <summary>
        /// Gets the remainder of uint from uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Modulus(this uint x, uint y) => x % y;

        /// <summary>
        /// Gets the remainder of ulong from uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Modulus(this uint x, ulong y) => x % (uint)y;

        /// <summary>
        /// Gets the remainder of ushort from uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Modulus(this uint x, ushort y) => x % y;

        /// <summary>
        /// Multiplies byte with uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint MultipliedWith(this uint x, byte y) => x * y;

        /// <summary>
        /// Multiplies char with uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint MultipliedWith(this uint x, char y) => x * y;

        /// <summary>
        /// Multiplies decimal with uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint MultipliedWith(this uint x, decimal y) => x * (uint)y;

        /// <summary>
        /// Multiplies double with uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint MultipliedWith(this uint x, double y) => x * (uint)y;

        /// <summary>
        /// Multiplies float with uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint MultipliedWith(this uint x, float y) => x * (uint)y;

        /// <summary>
        /// Multiplies int with uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint MultipliedWith(this uint x, int y) => x * (uint)y;

        /// <summary>
        /// Multiplies long with uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint MultipliedWith(this uint x, long y) => x * (uint)y;

        /// <summary>
        /// Multiplies sbyte with uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint MultipliedWith(this uint x, sbyte y) => x * (uint)y;

        /// <summary>
        /// Multiplies short with uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint MultipliedWith(this uint x, short y) => x * (uint)y;

        /// <summary>
        /// Multiplies uint with uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint MultipliedWith(this uint x, uint y) => x * y;

        /// <summary>
        /// Multiplies ulong with uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint MultipliedWith(this uint x, ulong y) => x * (uint)y;

        /// <summary>
        /// Multiplies ushort with uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint MultipliedWith(this uint x, ushort y) => x * y;

        /// <summary>
        /// Gets the NOT of uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <returns>The result of the operation</returns>
        public static uint Not(this uint x) => (uint)~(int)x;

        /// <summary>
        /// Gets the OR of byte and uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Or(this uint x, byte y) => (uint)((int)x | y);

        /// <summary>
        /// Gets the OR of char and uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Or(this uint x, char y) => (uint)((int)x | y);

        /// <summary>
        /// Gets the OR of decimal and uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Or(this uint x, decimal y) => (uint)((int)x | (int)y);

        /// <summary>
        /// Gets the OR of double and uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Or(this uint x, double y) => (uint)((int)x | (int)y);

        /// <summary>
        /// Gets the OR of float and uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Or(this uint x, float y) => (uint)((int)x | (int)y);

        /// <summary>
        /// Gets the OR of int and uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Or(this uint x, int y) => (uint)((int)x | y);

        /// <summary>
        /// Gets the OR of long and uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Or(this uint x, long y) => (uint)((int)x | (int)y);

        /// <summary>
        /// Gets the OR of sbyte and uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Or(this uint x, sbyte y) => (uint)((int)x | y);

        /// <summary>
        /// Gets the OR of short and uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Or(this uint x, short y) => (uint)((int)x | y);

        /// <summary>
        /// Gets the OR of uint and uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Or(this uint x, uint y) => (uint)((int)x | (int)y);

        /// <summary>
        /// Gets the OR of ulong and uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Or(this uint x, ulong y) => (uint)((int)x | (int)y);

        /// <summary>
        /// Gets the OR of ushort and uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Or(this uint x, ushort y) => (uint)((int)x | y);

        /// <summary>
        /// Substracts byte from uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Substract(this uint x, byte y) => x - y;

        /// <summary>
        /// Substracts char from uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Substract(this uint x, char y) => x - y;

        /// <summary>
        /// Substracts decimal from uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Substract(this uint x, decimal y) => x - (uint)y;

        /// <summary>
        /// Substracts double from uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Substract(this uint x, double y) => x - (uint)y;

        /// <summary>
        /// Substracts float from uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Substract(this uint x, float y) => x - (uint)y;

        /// <summary>
        /// Substracts int from uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Substract(this uint x, int y) => x - (uint)y;

        /// <summary>
        /// Substracts long from uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Substract(this uint x, long y) => x - (uint)y;

        /// <summary>
        /// Substracts sbyte from uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Substract(this uint x, sbyte y) => x - (uint)y;

        /// <summary>
        /// Substracts short from uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Substract(this uint x, short y) => x - (uint)y;

        /// <summary>
        /// Substracts uint from uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Substract(this uint x, uint y) => x - y;

        /// <summary>
        /// Substracts ulong from uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Substract(this uint x, ulong y) => x - (uint)y;

        /// <summary>
        /// Substracts ushort from uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Substract(this uint x, ushort y) => x - y;

        /// <summary>
        /// Gets XOR of byte of uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Xor(this uint x, byte y) => x ^ y;

        /// <summary>
        /// Gets XOR of char of uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Xor(this uint x, char y) => x ^ y;

        /// <summary>
        /// Gets XOR of decimal of uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Xor(this uint x, decimal y) => x ^ (uint)y;

        /// <summary>
        /// Gets XOR of double of uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Xor(this uint x, double y) => x ^ (uint)y;

        /// <summary>
        /// Gets XOR of float of uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Xor(this uint x, float y) => x ^ (uint)y;

        /// <summary>
        /// Gets XOR of int of uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Xor(this uint x, int y) => x ^ (uint)y;

        /// <summary>
        /// Gets XOR of long of uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Xor(this uint x, long y) => x ^ (uint)y;

        /// <summary>
        /// Gets XOR of sbyte of uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Xor(this uint x, sbyte y) => x ^ (uint)y;

        /// <summary>
        /// Gets XOR of short of uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Xor(this uint x, short y) => x ^ (uint)y;

        /// <summary>
        /// Gets XOR of uint of uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Xor(this uint x, uint y) => x ^ y;

        /// <summary>
        /// Gets XOR of ulong of uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Xor(this uint x, ulong y) => x ^ (uint)y;

        /// <summary>
        /// Gets XOR of ushort of uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static uint Xor(this uint x, ushort y) => x ^ y;
    }
}