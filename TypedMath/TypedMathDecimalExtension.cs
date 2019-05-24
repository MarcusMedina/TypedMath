namespace MarcusMedinaPro.TypedMath.DecimalExtension
{
    public static class TypedMathDecimalExtension
    {
        /// <summary>
        /// Adds byte to decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal Add(this decimal x, byte y) => x + y;

        /// <summary>
        /// Adds char to decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal Add(this decimal x, char y) => x + y;

        /// <summary>
        /// Adds decimal to decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal Add(this decimal x, decimal y) => x + y;

        /// <summary>
        /// Adds double to decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal Add(this decimal x, double y) => x + (decimal)y;

        /// <summary>
        /// Adds float to decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal Add(this decimal x, float y) => x + (decimal)y;

        /// <summary>
        /// Adds int to decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal Add(this decimal x, int y) => x + y;

        /// <summary>
        /// Adds long to decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal Add(this decimal x, long y) => x + y;

        /// <summary>
        /// Adds sbyte to decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal Add(this decimal x, sbyte y) => x + y;

        /// <summary>
        /// Adds short to decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal Add(this decimal x, short y) => x + y;

        /// <summary>
        /// Adds uint to decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal Add(this decimal x, uint y) => x + y;

        /// <summary>
        /// Adds ulong to decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal Add(this decimal x, ulong y) => x + y;

        /// <summary>
        /// Adds ushort to decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal Add(this decimal x, ushort y) => x + y;

        /// <summary>
        /// Tries to cast decimal to byte, this can get ugly though
        /// </summary>
        /// <param name="x">The original value</param>
        /// <returns>The result of the operation</returns>
        public static byte CastDecimalToByte(this decimal x) => (byte)x;

        /// <summary>
        /// Tries to cast decimal to char, this can get ugly though
        /// </summary>
        /// <param name="x">The original value</param>
        /// <returns>The result of the operation</returns>
        public static char CastDecimalToChar(this decimal x) => (char)x;

        /// <summary>
        /// Tries to cast decimal to double, this can get ugly though
        /// </summary>
        /// <param name="x">The original value</param>
        /// <returns>The result of the operation</returns>
        public static double CastDecimalToDouble(this decimal x) => (double)x;

        /// <summary>
        /// Tries to cast decimal to float, this can get ugly though
        /// </summary>
        /// <param name="x">The original value</param>
        /// <returns>The result of the operation</returns>
        public static float CastDecimalToFloat(this decimal x) => (float)x;

        /// <summary>
        /// Tries to cast decimal to int, this can get ugly though
        /// </summary>
        /// <param name="x">The original value</param>
        /// <returns>The result of the operation</returns>
        public static int CastDecimalToInt(this decimal x) => (int)x;

        /// <summary>
        /// Tries to cast decimal to long, this can get ugly though
        /// </summary>
        /// <param name="x">The original value</param>
        /// <returns>The result of the operation</returns>
        public static long CastDecimalToLong(this decimal x) => (long)x;

        /// <summary>
        /// Tries to cast decimal to sbyte, this can get ugly though
        /// </summary>
        /// <param name="x">The original value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte CastDecimalToSbyte(this decimal x) => (sbyte)x;

        /// <summary>
        /// Tries to cast decimal to short, this can get ugly though
        /// </summary>
        /// <param name="x">The original value</param>
        /// <returns>The result of the operation</returns>
        public static short CastDecimalToShort(this decimal x) => (short)x;

        /// <summary>
        /// Tries to cast decimal to uint, this can get ugly though
        /// </summary>
        /// <param name="x">The original value</param>
        /// <returns>The result of the operation</returns>
        public static uint CastDecimalToUint(this decimal x) => (uint)x;

        /// <summary>
        /// Tries to cast decimal to ulong, this can get ugly though
        /// </summary>
        /// <param name="x">The original value</param>
        /// <returns>The result of the operation</returns>
        public static ulong CastDecimalToUlong(this decimal x) => (ulong)x;

        /// <summary>
        /// Tries to cast decimal to ushort, this can get ugly though
        /// </summary>
        /// <param name="x">The original value</param>
        /// <returns>The result of the operation</returns>
        public static ushort CastDecimalToUshort(this decimal x) => (ushort)x;

        /// <summary>
        /// Divides byte from decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal DividedBy(this decimal x, byte y) => x / y;

        /// <summary>
        /// Divides char from decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal DividedBy(this decimal x, char y) => x / y;

        /// <summary>
        /// Divides decimal from decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal DividedBy(this decimal x, decimal y) => x / y;

        /// <summary>
        /// Divides double from decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal DividedBy(this decimal x, double y) => x / (decimal)y;

        /// <summary>
        /// Divides float from decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal DividedBy(this decimal x, float y) => x / (decimal)y;

        /// <summary>
        /// Divides int from decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal DividedBy(this decimal x, int y) => x / y;

        /// <summary>
        /// Divides long from decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal DividedBy(this decimal x, long y) => x / y;

        /// <summary>
        /// Divides sbyte from decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal DividedBy(this decimal x, sbyte y) => x / y;

        /// <summary>
        /// Divides short from decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal DividedBy(this decimal x, short y) => x / y;

        /// <summary>
        /// Divides uint from decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal DividedBy(this decimal x, uint y) => x / y;

        /// <summary>
        /// Divides ulong from decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal DividedBy(this decimal x, ulong y) => x / y;

        /// <summary>
        /// Divides ushort from decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal DividedBy(this decimal x, ushort y) => x / y;

        /// <summary>
        /// Gets a boolean True if decimal is greater than byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this decimal x, byte y) => x > y;

        /// <summary>
        /// Gets a boolean True if decimal is greater than char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this decimal x, char y) => x > y;

        /// <summary>
        /// Gets a boolean True if decimal is greater than decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this decimal x, decimal y) => x > y;

        /// <summary>
        /// Gets a boolean True if decimal is greater than double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this decimal x, double y) => x > (decimal)y;

        /// <summary>
        /// Gets a boolean True if decimal is greater than float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this decimal x, float y) => x > (decimal)y;

        /// <summary>
        /// Gets a boolean True if decimal is greater than int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this decimal x, int y) => x > y;

        /// <summary>
        /// Gets a boolean True if decimal is greater than long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this decimal x, long y) => x > y;

        /// <summary>
        /// Gets a boolean True if decimal is greater than sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this decimal x, sbyte y) => x > y;

        /// <summary>
        /// Gets a boolean True if decimal is greater than short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this decimal x, short y) => x > y;

        /// <summary>
        /// Gets a boolean True if decimal is greater than uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this decimal x, uint y) => x > y;

        /// <summary>
        /// Gets a boolean True if decimal is greater than ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this decimal x, ulong y) => x > y;

        /// <summary>
        /// Gets a boolean True if decimal is greater than ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this decimal x, ushort y) => x > y;

        /// <summary>
        /// Gets boolean True if byte is equal to decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this decimal x, byte y) => x == y;

        /// <summary>
        /// Gets boolean True if char is equal to decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this decimal x, char y) => x == y;

        /// <summary>
        /// Gets boolean True if decimal is equal to decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this decimal x, decimal y) => x == y;

        /// <summary>
        /// Gets boolean True if double is equal to decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this decimal x, double y) => x == (decimal)y;

        /// <summary>
        /// Gets boolean True if float is equal to decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this decimal x, float y) => x == (decimal)y;

        /// <summary>
        /// Gets boolean True if int is equal to decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this decimal x, int y) => x == y;

        /// <summary>
        /// Gets boolean True if long is equal to decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this decimal x, long y) => x == y;

        /// <summary>
        /// Gets boolean True if sbyte is equal to decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this decimal x, sbyte y) => x == y;

        /// <summary>
        /// Gets boolean True if short is equal to decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this decimal x, short y) => x == y;

        /// <summary>
        /// Gets boolean True if uint is equal to decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this decimal x, uint y) => x == y;

        /// <summary>
        /// Gets boolean True if ulong is equal to decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this decimal x, ulong y) => x == y;

        /// <summary>
        /// Gets boolean True if ushort is equal to decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this decimal x, ushort y) => x == y;

        /// <summary>
        /// Gets boolean true if value is less than zero
        /// </summary>
        /// <param name="x">The original value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNegative(this decimal x) => x < 0;

        /// <summary>
        /// Gets boolean True if byte is not equal to decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this decimal x, byte y) => x != y;

        /// <summary>
        /// Gets boolean True if char is not equal to decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this decimal x, char y) => x != y;

        /// <summary>
        /// Gets boolean True if decimal is not equal to decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this decimal x, decimal y) => x != y;

        /// <summary>
        /// Gets boolean True if double is not equal to decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this decimal x, double y) => x != (decimal)y;

        /// <summary>
        /// Gets boolean True if float is not equal to decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this decimal x, float y) => x != (decimal)y;

        /// <summary>
        /// Gets boolean True if int is not equal to decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this decimal x, int y) => x != y;

        /// <summary>
        /// Gets boolean True if long is not equal to decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this decimal x, long y) => x != y;

        /// <summary>
        /// Gets boolean True if sbyte is not equal to decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this decimal x, sbyte y) => x != y;

        /// <summary>
        /// Gets boolean True if short is not equal to decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this decimal x, short y) => x != y;

        /// <summary>
        /// Gets boolean True if uint is not equal to decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this decimal x, uint y) => x != y;

        /// <summary>
        /// Gets boolean True if ulong is not equal to decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this decimal x, ulong y) => x != y;

        /// <summary>
        /// Gets boolean True if ushort is not equal to decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this decimal x, ushort y) => x != y;

        /// <summary>
        /// Gets boolean true if value is more than zero
        /// </summary>
        /// <param name="x">The original value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsPositive(this decimal x) => x >= 0;

        /// <summary>
        /// Gets a boolean True if decimal is less than byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this decimal x, byte y) => x < y;

        /// <summary>
        /// Gets a boolean True if decimal is less than char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this decimal x, char y) => x < y;

        /// <summary>
        /// Gets a boolean True if decimal is less than decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this decimal x, decimal y) => x < y;

        /// <summary>
        /// Gets a boolean True if decimal is less than double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this decimal x, double y) => x < (decimal)y;

        /// <summary>
        /// Gets a boolean True if decimal is less than float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this decimal x, float y) => x < (decimal)y;

        /// <summary>
        /// Gets a boolean True if decimal is less than int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this decimal x, int y) => x < y;

        /// <summary>
        /// Gets a boolean True if decimal is less than long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this decimal x, long y) => x < y;

        /// <summary>
        /// Gets a boolean True if decimal is less than sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this decimal x, sbyte y) => x < y;

        /// <summary>
        /// Gets a boolean True if decimal is less than short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this decimal x, short y) => x < y;

        /// <summary>
        /// Gets a boolean True if decimal is less than uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this decimal x, uint y) => x < y;

        /// <summary>
        /// Gets a boolean True if decimal is less than ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this decimal x, ulong y) => x < y;

        /// <summary>
        /// Gets a boolean True if decimal is less than ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this decimal x, ushort y) => x < y;

        /// <summary>
        /// Gets the remainder of byte from decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal Modulus(this decimal x, byte y) => x % y;

        /// <summary>
        /// Gets the remainder of char from decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal Modulus(this decimal x, char y) => x % y;

        /// <summary>
        /// Gets the remainder of decimal from decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal Modulus(this decimal x, decimal y) => x % y;

        /// <summary>
        /// Gets the remainder of double from decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal Modulus(this decimal x, double y) => x % (decimal)y;

        /// <summary>
        /// Gets the remainder of float from decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal Modulus(this decimal x, float y) => x % (decimal)y;

        /// <summary>
        /// Gets the remainder of int from decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal Modulus(this decimal x, int y) => x % y;

        /// <summary>
        /// Gets the remainder of long from decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal Modulus(this decimal x, long y) => x % y;

        /// <summary>
        /// Gets the remainder of sbyte from decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal Modulus(this decimal x, sbyte y) => x % y;

        /// <summary>
        /// Gets the remainder of short from decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal Modulus(this decimal x, short y) => x % y;

        /// <summary>
        /// Gets the remainder of uint from decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal Modulus(this decimal x, uint y) => x % y;

        /// <summary>
        /// Gets the remainder of ulong from decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal Modulus(this decimal x, ulong y) => x % y;

        /// <summary>
        /// Gets the remainder of ushort from decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal Modulus(this decimal x, ushort y) => x % y;

        /// <summary>
        /// Multiplies byte with decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal MultipliedWith(this decimal x, byte y) => x * y;

        /// <summary>
        /// Multiplies char with decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal MultipliedWith(this decimal x, char y) => x * y;

        /// <summary>
        /// Multiplies decimal with decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal MultipliedWith(this decimal x, decimal y) => x * y;

        /// <summary>
        /// Multiplies double with decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal MultipliedWith(this decimal x, double y) => x * (decimal)y;

        /// <summary>
        /// Multiplies float with decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal MultipliedWith(this decimal x, float y) => x * (decimal)y;

        /// <summary>
        /// Multiplies int with decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal MultipliedWith(this decimal x, int y) => x * y;

        /// <summary>
        /// Multiplies long with decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal MultipliedWith(this decimal x, long y) => x * y;

        /// <summary>
        /// Multiplies sbyte with decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal MultipliedWith(this decimal x, sbyte y) => x * y;

        /// <summary>
        /// Multiplies short with decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal MultipliedWith(this decimal x, short y) => x * y;

        /// <summary>
        /// Multiplies uint with decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal MultipliedWith(this decimal x, uint y) => x * y;

        /// <summary>
        /// Multiplies ulong with decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal MultipliedWith(this decimal x, ulong y) => x * y;

        /// <summary>
        /// Multiplies ushort with decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal MultipliedWith(this decimal x, ushort y) => x * y;

        /// <summary>
        /// Gets the NOT of decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <returns>The result of the operation</returns>
        public static decimal Not(this decimal x) => ~(int)x;

        /// <summary>
        /// Substracts byte from decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal Substract(this decimal x, byte y) => x - y;

        /// <summary>
        /// Substracts char from decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal Substract(this decimal x, char y) => x - y;

        /// <summary>
        /// Substracts decimal from decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal Substract(this decimal x, decimal y) => x - y;

        /// <summary>
        /// Substracts double from decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal Substract(this decimal x, double y) => x - (decimal)y;

        /// <summary>
        /// Substracts float from decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal Substract(this decimal x, float y) => x - (decimal)y;

        /// <summary>
        /// Substracts int from decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal Substract(this decimal x, int y) => x - y;

        /// <summary>
        /// Substracts long from decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal Substract(this decimal x, long y) => x - y;

        /// <summary>
        /// Substracts sbyte from decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal Substract(this decimal x, sbyte y) => x - y;

        /// <summary>
        /// Substracts short from decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal Substract(this decimal x, short y) => x - y;

        /// <summary>
        /// Substracts uint from decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal Substract(this decimal x, uint y) => x - y;

        /// <summary>
        /// Substracts ulong from decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal Substract(this decimal x, ulong y) => x - y;

        /// <summary>
        /// Substracts ushort from decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static decimal Substract(this decimal x, ushort y) => x - y;
    }
}