//----------------------------------------------------------------------------------------------
// <copyright file="TypedMathByteExtension.cs" company="MarcusMedinaPro">
// By Marcus Medina, 2019 - http://MarcusMedina.Pro
// This file is subject to the terms and conditions defined in file 'license.txt', which is part of this project.
// </copyright>
// ----------------------------------------------------------------------------------------------

namespace MarcusMedinaPro.TypedMath.ByteExtension
{
    /// <summary>
    /// Defines the <see cref="TypedMathByteExtension"/>
    /// </summary>
    public static class TypedMathByteExtension
    {
        /// <summary>
        /// Adds sbyte to byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Add(this byte x, sbyte y) => (byte)(x + y);

        /// <summary>
        /// Adds byte to byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Add(this byte x, byte y) => (byte)(x + y);

        /// <summary>
        /// Adds char to byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Add(this byte x, char y) => (byte)(x + y);

        /// <summary>
        /// Adds short to byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Add(this byte x, short y) => (byte)(x + y);

        /// <summary>
        /// Adds ushort to byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Add(this byte x, ushort y) => (byte)(x + y);

        /// <summary>
        /// Adds int to byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Add(this byte x, int y) => (byte)(x + y);

        /// <summary>
        /// Adds uint to byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Add(this byte x, uint y) => (byte)(x + (int)y);

        /// <summary>
        /// Adds long to byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Add(this byte x, long y) => (byte)(x + (int)y);

        /// <summary>
        /// Adds ulong to byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Add(this byte x, ulong y) => (byte)(x + (int)y);

        /// <summary>
        /// Adds double to byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Add(this byte x, double y) => (byte)(x + (int)y);

        /// <summary>
        /// Adds decimal to byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Add(this byte x, decimal y) => (byte)(x + (int)y);

        /// <summary>
        /// Gets the AND of sbyte and byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte And(this byte x, sbyte y) => (byte)(x & y);

        /// <summary>
        /// Gets the AND of byte and byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte And(this byte x, byte y) => (byte)(x & y);

        /// <summary>
        /// Gets the AND of char and byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte And(this byte x, char y) => (byte)(x & y);

        /// <summary>
        /// Gets the AND of short and byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte And(this byte x, short y) => (byte)(x & y);

        /// <summary>
        /// Gets the AND of ushort and byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte And(this byte x, ushort y) => (byte)(x & y);

        /// <summary>
        /// Gets the AND of int and byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte And(this byte x, int y) => (byte)(x & y);

        /// <summary>
        /// Gets the AND of uint and byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte And(this byte x, uint y) => (byte)(x & (int)y);

        /// <summary>
        /// Gets the AND of long and byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte And(this byte x, long y) => (byte)(x & (int)y);

        /// <summary>
        /// Gets the AND of ulong and byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte And(this byte x, ulong y) => (byte)(x & (int)y);

        /// <summary>
        /// Gets the AND of double and byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte And(this byte x, double y) => (byte)(x & (int)y);

        /// <summary>
        /// Gets the AND of decimal and byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte And(this byte x, decimal y) => (byte)(x & (int)y);

        /// <summary>
        /// Tries to cast byte to char, this can get ugly though
        /// </summary>
        /// <param name="x">The original value</param>
        /// <returns>The result of the operation</returns>
        public static char CastByteToChar(this byte x) => (char)x;

        /// <summary>
        /// Tries to cast byte to decimal, this can get ugly though
        /// </summary>
        /// <param name="x">The original value</param>
        /// <returns>The result of the operation</returns>
        public static decimal CastByteToDecimal(this byte x) => x;

        /// <summary>
        /// Tries to cast byte to double, this can get ugly though
        /// </summary>
        /// <param name="x">The original value</param>
        /// <returns>The result of the operation</returns>
        public static double CastByteToDouble(this byte x) => x;

        /// <summary>
        /// Tries to cast byte to int, this can get ugly though
        /// </summary>
        /// <param name="x">The original value</param>
        /// <returns>The result of the operation</returns>
        public static int CastByteToInt(this byte x) => x;

        /// <summary>
        /// Tries to cast byte to long, this can get ugly though
        /// </summary>
        /// <param name="x">The original value</param>
        /// <returns>The result of the operation</returns>
        public static long CastByteToLong(this byte x) => x;

        /// <summary>
        /// Tries to cast byte to sbyte, this can get ugly though
        /// </summary>
        /// <param name="x">The original value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte CastByteToSbyte(this byte x) => (sbyte)x;

        /// <summary>
        /// Tries to cast byte to short, this can get ugly though
        /// </summary>
        /// <param name="x">The original value</param>
        /// <returns>The result of the operation</returns>
        public static short CastByteToShort(this byte x) => x;

        /// <summary>
        /// Tries to cast byte to uint, this can get ugly though
        /// </summary>
        /// <param name="x">The original value</param>
        /// <returns>The result of the operation</returns>
        public static uint CastByteToUint(this byte x) => x;

        /// <summary>
        /// Tries to cast byte to ulong, this can get ugly though
        /// </summary>
        /// <param name="x">The original value</param>
        /// <returns>The result of the operation</returns>
        public static ulong CastByteToUlong(this byte x) => x;

        /// <summary>
        /// Tries to cast byte to ushort, this can get ugly though
        /// </summary>
        /// <param name="x">The original value</param>
        /// <returns>The result of the operation</returns>
        public static ushort CastByteToUshort(this byte x) => x;

        /// <summary>
        /// Divides sbyte from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte DividedBy(this byte x, sbyte y) => (byte)(x / y);

        /// <summary>
        /// Divides byte from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte DividedBy(this byte x, byte y) => (byte)(x / y);

        /// <summary>
        /// Divides char from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte DividedBy(this byte x, char y) => (byte)(x / y);

        /// <summary>
        /// Divides short from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte DividedBy(this byte x, short y) => (byte)(x / y);

        /// <summary>
        /// Divides ushort from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte DividedBy(this byte x, ushort y) => (byte)(x / y);

        /// <summary>
        /// Divides int from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte DividedBy(this byte x, int y) => (byte)(x / y);

        /// <summary>
        /// Divides uint from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte DividedBy(this byte x, uint y) => (byte)(x / (int)y);

        /// <summary>
        /// Divides long from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte DividedBy(this byte x, long y) => (byte)(x / (int)y);

        /// <summary>
        /// Divides ulong from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte DividedBy(this byte x, ulong y) => (byte)(x / (int)y);

        /// <summary>
        /// Divides double from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte DividedBy(this byte x, double y) => (byte)(x / (int)y);

        /// <summary>
        /// Divides decimal from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte DividedBy(this byte x, decimal y) => (byte)(x / (int)y);

        /// <summary>
        /// Gets boolean True if sbyte is equal to byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this byte x, sbyte y) => x == (byte)y;

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
        /// Gets boolean True if short is equal to byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this byte x, short y) => x == (byte)y;

        /// <summary>
        /// Gets boolean True if ushort is equal to byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this byte x, ushort y) => x == (byte)y;

        /// <summary>
        /// Gets boolean True if int is equal to byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this byte x, int y) => x == (byte)y;

        /// <summary>
        /// Gets boolean True if uint is equal to byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this byte x, uint y) => x == (byte)y;

        /// <summary>
        /// Gets boolean True if long is equal to byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this byte x, long y) => x == (byte)y;

        /// <summary>
        /// Gets boolean True if ulong is equal to byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this byte x, ulong y) => x == (byte)y;

        /// <summary>
        /// Gets boolean True if double is equal to byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this byte x, double y) => x == (byte)y;

        /// <summary>
        /// Gets boolean True if decimal is equal to byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this byte x, decimal y) => x == (byte)y;

        /// <summary>
        /// Gets boolean True if sbyte is not equal to byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this byte x, sbyte y) => x != (byte)y;

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
        /// Gets boolean True if short is not equal to byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this byte x, short y) => x != (byte)y;

        /// <summary>
        /// Gets boolean True if ushort is not equal to byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this byte x, ushort y) => x != (byte)y;

        /// <summary>
        /// Gets boolean True if int is not equal to byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this byte x, int y) => x != (byte)y;

        /// <summary>
        /// Gets boolean True if uint is not equal to byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this byte x, uint y) => x != (byte)y;

        /// <summary>
        /// Gets boolean True if long is not equal to byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this byte x, long y) => x != (byte)y;

        /// <summary>
        /// Gets boolean True if ulong is not equal to byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this byte x, ulong y) => x != (byte)y;

        /// <summary>
        /// Gets boolean True if double is not equal to byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this byte x, double y) => x != (byte)y;

        /// <summary>
        /// Gets boolean True if decimal is not equal to byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this byte x, decimal y) => x != (byte)y;

        /// <summary>
        /// Gets the remainder of sbyte from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Modulus(this byte x, sbyte y) => (byte)(x % y);

        /// <summary>
        /// Gets the remainder of byte from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Modulus(this byte x, byte y) => (byte)(x % y);

        /// <summary>
        /// Gets the remainder of char from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Modulus(this byte x, char y) => (byte)(x % y);

        /// <summary>
        /// Gets the remainder of short from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Modulus(this byte x, short y) => (byte)(x % y);

        /// <summary>
        /// Gets the remainder of ushort from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Modulus(this byte x, ushort y) => (byte)(x % y);

        /// <summary>
        /// Gets the remainder of int from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Modulus(this byte x, int y) => (byte)(x % y);

        /// <summary>
        /// Gets the remainder of uint from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Modulus(this byte x, uint y) => (byte)(x % (int)y);

        /// <summary>
        /// Gets the remainder of long from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Modulus(this byte x, long y) => (byte)(x % (int)y);

        /// <summary>
        /// Gets the remainder of ulong from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Modulus(this byte x, ulong y) => (byte)(x % (int)y);

        /// <summary>
        /// Gets the remainder of double from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Modulus(this byte x, double y) => (byte)(x % (int)y);

        /// <summary>
        /// Gets the remainder of decimal from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Modulus(this byte x, decimal y) => (byte)(x % (int)y);

        /// <summary>
        /// Multiplies sbyte with byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte MultipliedWith(this byte x, sbyte y) => (byte)(x * y);

        /// <summary>
        /// Multiplies byte with byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte MultipliedWith(this byte x, byte y) => (byte)(x * y);

        /// <summary>
        /// Multiplies char with byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte MultipliedWith(this byte x, char y) => (byte)(x * y);

        /// <summary>
        /// Multiplies short with byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte MultipliedWith(this byte x, short y) => (byte)(x * y);

        /// <summary>
        /// Multiplies ushort with byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte MultipliedWith(this byte x, ushort y) => (byte)(x * y);

        /// <summary>
        /// Multiplies int with byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte MultipliedWith(this byte x, int y) => (byte)(x * y);

        /// <summary>
        /// Multiplies uint with byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte MultipliedWith(this byte x, uint y) => (byte)(x * (int)y);

        /// <summary>
        /// Multiplies long with byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte MultipliedWith(this byte x, long y) => (byte)(x * (int)y);

        /// <summary>
        /// Multiplies ulong with byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte MultipliedWith(this byte x, ulong y) => (byte)(x * (int)y);

        /// <summary>
        /// Multiplies double with byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte MultipliedWith(this byte x, double y) => (byte)(x * (int)y);

        /// <summary>
        /// Multiplies decimal with byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte MultipliedWith(this byte x, decimal y) => (byte)(x * (int)y);

        /// <summary>
        /// Gets the OR of sbyte and byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Or(this byte x, sbyte y) => (byte)(x | y);

        /// <summary>
        /// Gets the OR of byte and byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Or(this byte x, byte y) => (byte)(x | y);

        /// <summary>
        /// Gets the OR of char and byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Or(this byte x, char y) => (byte)(x | y);

        /// <summary>
        /// Gets the OR of short and byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Or(this byte x, short y) => (byte)(x | y);

        /// <summary>
        /// Gets the OR of ushort and byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Or(this byte x, ushort y) => (byte)(x | y);

        /// <summary>
        /// Gets the OR of int and byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Or(this byte x, int y) => (byte)(x | y);

        /// <summary>
        /// Gets the OR of uint and byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Or(this byte x, uint y) => (byte)(x | (int)y);

        /// <summary>
        /// Gets the OR of long and byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Or(this byte x, long y) => (byte)(x | (int)y);

        /// <summary>
        /// Gets the OR of ulong and byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Or(this byte x, ulong y) => (byte)(x | (int)y);

        /// <summary>
        /// Gets the OR of double and byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Or(this byte x, double y) => (byte)(x | (int)y);

        /// <summary>
        /// Gets the OR of decimal and byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Or(this byte x, decimal y) => (byte)(x | (int)y);

        /// <summary>
        /// Gets shift left of sbyte from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte ShiftLeft(this byte x, sbyte y) => (byte)(x << y);

        /// <summary>
        /// Gets shift left of byte from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte ShiftLeft(this byte x, byte y) => (byte)(x << y);

        /// <summary>
        /// Gets shift left of char from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte ShiftLeft(this byte x, char y) => (byte)(x << y);

        /// <summary>
        /// Gets shift left of short from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte ShiftLeft(this byte x, short y) => (byte)(x << y);

        /// <summary>
        /// Gets shift left of ushort from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte ShiftLeft(this byte x, ushort y) => (byte)(x << y);

        /// <summary>
        /// Gets shift left of int from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte ShiftLeft(this byte x, int y) => (byte)(x << y);

        /// <summary>
        /// Gets shift left of uint from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte ShiftLeft(this byte x, uint y) => (byte)(x << (int)y);

        /// <summary>
        /// Gets shift left of long from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte ShiftLeft(this byte x, long y) => (byte)(x << (int)y);

        /// <summary>
        /// Gets shift left of ulong from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte ShiftLeft(this byte x, ulong y) => (byte)(x << (int)y);

        /// <summary>
        /// Gets shift left of double from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte ShiftLeft(this byte x, double y) => (byte)(x << (int)y);

        /// <summary>
        /// Gets shift left of decimal from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte ShiftLeft(this byte x, decimal y) => (byte)(x << (int)y);

        /// <summary>
        /// Gets shift right of sbyte from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte ShiftRight(this byte x, sbyte y) => (byte)(x >> y);

        /// <summary>
        /// Gets shift right of byte from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte ShiftRight(this byte x, byte y) => (byte)(x >> y);

        /// <summary>
        /// Gets shift right of char from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte ShiftRight(this byte x, char y) => (byte)(x >> y);

        /// <summary>
        /// Gets shift right of short from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte ShiftRight(this byte x, short y) => (byte)(x >> y);

        /// <summary>
        /// Gets shift right of ushort from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte ShiftRight(this byte x, ushort y) => (byte)(x >> y);

        /// <summary>
        /// Gets shift right of int from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte ShiftRight(this byte x, int y) => (byte)(x >> y);

        /// <summary>
        /// Gets shift right of uint from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte ShiftRight(this byte x, uint y) => (byte)(x >> (int)y);

        /// <summary>
        /// Gets shift right of long from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte ShiftRight(this byte x, long y) => (byte)(x >> (int)y);

        /// <summary>
        /// Gets shift right of ulong from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte ShiftRight(this byte x, ulong y) => (byte)(x >> (int)y);

        /// <summary>
        /// Gets shift right of double from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte ShiftRight(this byte x, double y) => (byte)(x >> (int)y);

        /// <summary>
        /// Gets shift right of decimal from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte ShiftRight(this byte x, decimal y) => (byte)(x >> (int)y);

        /// <summary>
        /// Substracts sbyte from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Substract(this byte x, sbyte y) => (byte)(x - y);

        /// <summary>
        /// Substracts byte from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Substract(this byte x, byte y) => (byte)(x - y);

        /// <summary>
        /// Substracts char from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Substract(this byte x, char y) => (byte)(x - y);

        /// <summary>
        /// Substracts short from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Substract(this byte x, short y) => (byte)(x - y);

        /// <summary>
        /// Substracts ushort from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Substract(this byte x, ushort y) => (byte)(x - y);

        /// <summary>
        /// Substracts int from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Substract(this byte x, int y) => (byte)(x - y);

        /// <summary>
        /// Substracts uint from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Substract(this byte x, uint y) => (byte)(x - (int)y);

        /// <summary>
        /// Substracts long from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Substract(this byte x, long y) => (byte)(x - (int)y);

        /// <summary>
        /// Substracts ulong from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Substract(this byte x, ulong y) => (byte)(x - (int)y);

        /// <summary>
        /// Substracts double from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Substract(this byte x, double y) => (byte)(x - (int)y);

        /// <summary>
        /// Substracts decimal from byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Substract(this byte x, decimal y) => (byte)(x - (int)y);

        /// <summary>
        /// Gets XOR of sbyte of byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Xor(this byte x, sbyte y) => (byte)(x ^ y);

        /// <summary>
        /// Gets XOR of byte of byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Xor(this byte x, byte y) => (byte)(x ^ y);

        /// <summary>
        /// Gets XOR of char of byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Xor(this byte x, char y) => (byte)(x ^ y);

        /// <summary>
        /// Gets XOR of short of byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Xor(this byte x, short y) => (byte)(x ^ y);

        /// <summary>
        /// Gets XOR of ushort of byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Xor(this byte x, ushort y) => (byte)(x ^ y);

        /// <summary>
        /// Gets XOR of int of byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Xor(this byte x, int y) => (byte)(x ^ y);

        /// <summary>
        /// Gets XOR of uint of byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Xor(this byte x, uint y) => (byte)(x ^ (int)y);

        /// <summary>
        /// Gets XOR of long of byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Xor(this byte x, long y) => (byte)(x ^ (int)y);

        /// <summary>
        /// Gets XOR of ulong of byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Xor(this byte x, ulong y) => (byte)(x ^ (int)y);

        /// <summary>
        /// Gets XOR of double of byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Xor(this byte x, double y) => (byte)(x ^ (int)y);

        /// <summary>
        /// Gets XOR of decimal of byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static byte Xor(this byte x, decimal y) => (byte)(x ^ (int)y);
    }
}