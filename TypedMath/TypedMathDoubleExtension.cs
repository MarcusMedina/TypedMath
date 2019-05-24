namespace MarcusMedinaPro.TypedMath.DoubleExtension
{
    using System;
    using System.Linq;

    public static class TypedMathDoubleExtension
    {
        /// <summary>
        /// Adds byte to double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double Add(this double x, byte y) => x + y;

        /// <summary>
        /// Adds char to double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double Add(this double x, char y) => x + y;

        /// <summary>
        /// Adds decimal to double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double Add(this double x, decimal y) => x + (double)y;

        /// <summary>
        /// Adds double to double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double Add(this double x, double y) => x + y;

        /// <summary>
        /// Adds float to double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double Add(this double x, float y) => x + y;

        /// <summary>
        /// Adds int to double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double Add(this double x, int y) => x + y;

        /// <summary>
        /// Adds long to double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double Add(this double x, long y) => x + y;

        /// <summary>
        /// Adds sbyte to double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double Add(this double x, sbyte y) => x + y;

        /// <summary>
        /// Adds short to double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double Add(this double x, short y) => x + y;

        /// <summary>
        /// Adds uint to double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double Add(this double x, uint y) => x + y;

        /// <summary>
        /// Adds ulong to double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double Add(this double x, ulong y) => x + y;

        /// <summary>
        /// Adds ushort to double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double Add(this double x, ushort y) => x + y;

        /// <summary>
        /// Tries to cast double to byte, this can get ugly though
        /// </summary>
        /// <param name="x">The original value</param>
        /// <returns>The result of the operation</returns>
        public static byte CastDoubleToByte(this double x) => (byte)x;

        /// <summary>
        /// Tries to cast double to char, this can get ugly though
        /// </summary>
        /// <param name="x">The original value</param>
        /// <returns>The result of the operation</returns>
        public static char CastDoubleToChar(this double x) => (char)x;

        /// <summary>
        /// Tries to cast double to decimal, this can get ugly though
        /// </summary>
        /// <param name="x">The original value</param>
        /// <returns>The result of the operation</returns>
        public static decimal CastDoubleToDecimal(this double x) => (decimal)x;

        /// <summary>
        /// Tries to cast double to float, this can get ugly though
        /// </summary>
        /// <param name="x">The original value</param>
        /// <returns>The result of the operation</returns>
        public static float CastDoubleToFloat(this double x) => (float)x;

        /// <summary>
        /// Tries to cast double to int, this can get ugly though
        /// </summary>
        /// <param name="x">The original value</param>
        /// <returns>The result of the operation</returns>
        public static int CastDoubleToInt(this double x) => (int)x;

        /// <summary>
        /// Tries to cast double to long, this can get ugly though
        /// </summary>
        /// <param name="x">The original value</param>
        /// <returns>The result of the operation</returns>
        public static long CastDoubleToLong(this double x) => (long)x;

        /// <summary>
        /// Tries to cast double to sbyte, this can get ugly though
        /// </summary>
        /// <param name="x">The original value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte CastDoubleToSbyte(this double x) => (sbyte)x;

        /// <summary>
        /// Tries to cast double to short, this can get ugly though
        /// </summary>
        /// <param name="x">The original value</param>
        /// <returns>The result of the operation</returns>
        public static short CastDoubleToShort(this double x) => (short)x;

        /// <summary>
        /// Tries to cast double to uint, this can get ugly though
        /// </summary>
        /// <param name="x">The original value</param>
        /// <returns>The result of the operation</returns>
        public static uint CastDoubleToUint(this double x) => (uint)x;

        /// <summary>
        /// Tries to cast double to ulong, this can get ugly though
        /// </summary>
        /// <param name="x">The original value</param>
        /// <returns>The result of the operation</returns>
        public static ulong CastDoubleToUlong(this double x) => (ulong)x;

        /// <summary>
        /// Tries to cast double to ushort, this can get ugly though
        /// </summary>
        /// <param name="x">The original value</param>
        /// <returns>The result of the operation</returns>
        public static ushort CastDoubleToUshort(this double x) => (ushort)x;

        /// <summary>
        /// Divides byte from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double DividedBy(this double x, byte y) => x / y;

        /// <summary>
        /// Divides char from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double DividedBy(this double x, char y) => x / y;

        /// <summary>
        /// Divides decimal from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double DividedBy(this double x, decimal y) => x / (double)y;

        /// <summary>
        /// Divides double from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double DividedBy(this double x, double y) => x / y;

        /// <summary>
        /// Divides float from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double DividedBy(this double x, float y) => x / y;

        /// <summary>
        /// Divides int from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double DividedBy(this double x, int y) => x / y;

        /// <summary>
        /// Divides long from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double DividedBy(this double x, long y) => x / y;

        /// <summary>
        /// Divides sbyte from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double DividedBy(this double x, sbyte y) => x / y;

        /// <summary>
        /// Divides short from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double DividedBy(this double x, short y) => x / y;

        /// <summary>
        /// Divides uint from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double DividedBy(this double x, uint y) => x / y;

        /// <summary>
        /// Divides ulong from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double DividedBy(this double x, ulong y) => x / y;

        /// <summary>
        /// Divides ushort from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double DividedBy(this double x, ushort y) => x / y;

        /// <summary>
        /// Gets a boolean True if double is greater than byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this double x, byte y) => x > y;

        /// <summary>
        /// Gets a boolean True if double is greater than char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this double x, char y) => x > y;

        /// <summary>
        /// Gets a boolean True if double is greater than decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this double x, decimal y) => x > (double)y;

        /// <summary>
        /// Gets a boolean True if double is greater than double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this double x, double y) => x > y;

        /// <summary>
        /// Gets a boolean True if double is greater than float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this double x, float y) => x > y;

        /// <summary>
        /// Gets a boolean True if double is greater than int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this double x, int y) => x > y;

        /// <summary>
        /// Gets a boolean True if double is greater than long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this double x, long y) => x > y;

        /// <summary>
        /// Gets a boolean True if double is greater than sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this double x, sbyte y) => x > y;

        /// <summary>
        /// Gets a boolean True if double is greater than short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this double x, short y) => x > y;

        /// <summary>
        /// Gets a boolean True if double is greater than uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this double x, uint y) => x > y;

        /// <summary>
        /// Gets a boolean True if double is greater than ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this double x, ulong y) => x > y;

        /// <summary>
        /// Gets a boolean True if double is greater than ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this double x, ushort y) => x > y;

        /// <summary>
        /// Gets boolean True if byte is equal to double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqual(this double x, byte y) => (decimal)x == y;

        /// <summary>
        /// Gets boolean True if char is equal to double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqual(this double x, char y) => (decimal)x == y;

        /// <summary>
        /// Gets boolean True if decimal is equal to double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqual(this double x, decimal y) => (decimal)x == y;

        /// <summary>
        /// Gets boolean True if double is equal to double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqual(this double x, double y) => (decimal)x == (decimal)y;

        /// <summary>
        /// Gets boolean True if float is equal to double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqual(this double x, float y) => (decimal)x == (decimal)y;

        /// <summary>
        /// Gets boolean True if int is equal to double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqual(this double x, int y) => (decimal)x == y;

        /// <summary>
        /// Gets boolean True if long is equal to double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqual(this double x, long y) => (decimal)x == y;

        /// <summary>
        /// Gets boolean True if sbyte is equal to double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqual(this double x, sbyte y) => (decimal)x == y;

        /// <summary>
        /// Gets boolean True if short is equal to double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqual(this double x, short y) => (decimal)x == y;

        /// <summary>
        /// Gets boolean True if uint is equal to double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqual(this double x, uint y) => (decimal)x == y;

        /// <summary>
        /// Gets boolean True if ulong is equal to double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqual(this double x, ulong y) => (decimal)x == y;

        /// <summary>
        /// Gets boolean True if ushort is equal to double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqual(this double x, ushort y) => (decimal)x == y;

        /// <summary>
        /// Gets boolean true if value is less than zero
        /// </summary>
        /// <param name="x">The original value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNegative(this double x) => x < 0;

        /// <summary>
        /// Gets boolean True if byte is not equal to double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqual(this double x, byte y) => (decimal)x != y;

        /// <summary>
        /// Gets boolean True if char is not equal to double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqual(this double x, char y) => (decimal)x != y;

        /// <summary>
        /// Gets boolean True if decimal is not equal to double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqual(this double x, decimal y) => (decimal)x != y;

        /// <summary>
        /// Gets boolean True if double is not equal to double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqual(this double x, double y) => (decimal)x != (decimal)y;

        /// <summary>
        /// Gets boolean True if float is not equal to double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqual(this double x, float y) => (decimal)x != (decimal)y;

        /// <summary>
        /// Gets boolean True if int is not equal to double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqual(this double x, int y) => (decimal)x != y;

        /// <summary>
        /// Gets boolean True if long is not equal to double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqual(this double x, long y) => (decimal)x != y;

        /// <summary>
        /// Gets boolean True if sbyte is not equal to double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqual(this double x, sbyte y) => (decimal)x != y;

        /// <summary>
        /// Gets boolean True if short is not equal to double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqual(this double x, short y) => (decimal)x != y;

        /// <summary>
        /// Gets boolean True if uint is not equal to double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqual(this double x, uint y) => (decimal)x != y;

        /// <summary>
        /// Gets boolean True if ulong is not equal to double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqual(this double x, ulong y) => (decimal)x != y;

        /// <summary>
        /// Gets boolean True if ushort is not equal to double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqual(this double x, ushort y) => (decimal)x != y;

        /// <summary>
        /// Gets boolean true if value is more than zero
        /// </summary>
        /// <param name="x">The original value</param>
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
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this double x, byte y) => x < y;

        /// <summary>
        /// Gets a boolean True if double is less than char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this double x, char y) => x < y;

        /// <summary>
        /// Gets a boolean True if double is less than decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this double x, decimal y) => x < (double)y;

        /// <summary>
        /// Gets a boolean True if double is less than double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this double x, double y) => x < y;

        /// <summary>
        /// Gets a boolean True if double is less than float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this double x, float y) => x < y;

        /// <summary>
        /// Gets a boolean True if double is less than int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this double x, int y) => x < y;

        /// <summary>
        /// Gets a boolean True if double is less than long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this double x, long y) => x < y;

        /// <summary>
        /// Gets a boolean True if double is less than sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this double x, sbyte y) => x < y;

        /// <summary>
        /// Gets a boolean True if double is less than short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this double x, short y) => x < y;

        /// <summary>
        /// Gets a boolean True if double is less than uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this double x, uint y) => x < y;

        /// <summary>
        /// Gets a boolean True if double is less than ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this double x, ulong y) => x < y;

        /// <summary>
        /// Gets a boolean True if double is less than ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this double x, ushort y) => x < y;

        /// <summary>
        /// Gets the remainder of byte from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double Modulus(this double x, byte y) => x % y;

        /// <summary>
        /// Gets the remainder of char from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double Modulus(this double x, char y) => x % y;

        /// <summary>
        /// Gets the remainder of decimal from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double Modulus(this double x, decimal y) => x % (double)y;

        /// <summary>
        /// Gets the remainder of double from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double Modulus(this double x, double y) => x % y;

        /// <summary>
        /// Gets the remainder of float from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double Modulus(this double x, float y) => x % y;

        /// <summary>
        /// Gets the remainder of int from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double Modulus(this double x, int y) => x % y;

        /// <summary>
        /// Gets the remainder of long from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double Modulus(this double x, long y) => x % y;

        /// <summary>
        /// Gets the remainder of sbyte from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double Modulus(this double x, sbyte y) => x % y;

        /// <summary>
        /// Gets the remainder of short from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double Modulus(this double x, short y) => x % y;

        /// <summary>
        /// Gets the remainder of uint from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double Modulus(this double x, uint y) => x % y;

        /// <summary>
        /// Gets the remainder of ulong from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double Modulus(this double x, ulong y) => x % y;

        /// <summary>
        /// Gets the remainder of ushort from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double Modulus(this double x, ushort y) => x % y;

        /// <summary>
        /// Multiplies byte with double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double MultipliedWith(this double x, byte y) => x * y;

        /// <summary>
        /// Multiplies char with double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double MultipliedWith(this double x, char y) => x * y;

        /// <summary>
        /// Multiplies decimal with double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double MultipliedWith(this double x, decimal y) => x * (double)y;

        /// <summary>
        /// Multiplies double with double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double MultipliedWith(this double x, double y) => x * y;

        /// <summary>
        /// Multiplies float with double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double MultipliedWith(this double x, float y) => x * y;

        /// <summary>
        /// Multiplies int with double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double MultipliedWith(this double x, int y) => x * y;

        /// <summary>
        /// Multiplies long with double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double MultipliedWith(this double x, long y) => x * y;

        /// <summary>
        /// Multiplies sbyte with double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double MultipliedWith(this double x, sbyte y) => x * y;

        /// <summary>
        /// Multiplies short with double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double MultipliedWith(this double x, short y) => x * y;

        /// <summary>
        /// Multiplies uint with double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double MultipliedWith(this double x, uint y) => x * y;

        /// <summary>
        /// Multiplies ulong with double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double MultipliedWith(this double x, ulong y) => x * y;

        /// <summary>
        /// Multiplies ushort with double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double MultipliedWith(this double x, ushort y) => x * y;

        /// <summary>
        /// Gets the NOT of double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <returns>The result of the operation</returns>
        public static double Not(this double x) => ~(int)x;

        /// <summary>
        /// Substracts byte from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double Substract(this double x, byte y) => x - y;

        /// <summary>
        /// Substracts char from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double Substract(this double x, char y) => x - y;

        /// <summary>
        /// Substracts decimal from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double Substract(this double x, decimal y) => x - (double)y;

        /// <summary>
        /// Substracts double from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double Substract(this double x, double y) => x - y;

        /// <summary>
        /// Substracts float from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double Substract(this double x, float y) => x - y;

        /// <summary>
        /// Substracts int from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double Substract(this double x, int y) => x - y;

        /// <summary>
        /// Substracts long from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double Substract(this double x, long y) => x - y;

        /// <summary>
        /// Substracts sbyte from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double Substract(this double x, sbyte y) => x - y;

        /// <summary>
        /// Substracts short from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double Substract(this double x, short y) => x - y;

        /// <summary>
        /// Substracts uint from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double Substract(this double x, uint y) => x - y;

        /// <summary>
        /// Substracts ulong from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double Substract(this double x, ulong y) => x - y;

        /// <summary>
        /// Substracts ushort from double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static double Substract(this double x, ushort y) => x - y;
    }
}