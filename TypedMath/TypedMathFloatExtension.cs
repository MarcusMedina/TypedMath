//----------------------------------------------------------------------------------------------
// <copyright file="TypedMathFloatExtension" company="MarcusMedinaPro">
// By Marcus Medina, 2019 - http://MarcusMedina.Pro 
// This file is subject to the terms and conditions defined in file 'license.txt', which is part of this project.
// </copyright>
// ----------------------------------------------------------------------------------------------
namespace MarcusMedinaPro.TypedMath.FloatExtension
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class TypedMathFloatExtension
    {

        /// <summary>
        /// Gets the NOT of float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <returns>The result of the operation</returns>
        public static float Not(this float x) =>(float) ~ (int)x;
        /// <summary>
        /// Checks if a number is prime
        /// </summary>
        /// <param name="number">The number</param>
        /// <returns>True if the number is prime</returns>
        public static bool IsPrime(this float number) => Enumerable.Range(2, (int)Math.Sqrt(number) - 1).All(divisor => number % divisor != 0);
        /// <summary>
        /// Compare original and second number
        /// </summary>
        /// <param name="first">The number</param>
        /// <param name="second">The number to compare with</param>
        /// <returns>The highest of the two numbers</returns>
        public static float ChooseHighestValue(this float first, float second) => first > second ? first : second;

        /// <summary>
        /// Compare original and second number
        /// </summary>
        /// <param name="first">The number</param>
        /// <param name="second">The number to compare with</param>
        /// <returns>The lowest of the two numbers</returns>
        public static float ChooseLowestValue(this float first, float second) => first < second ? first : second;

        /// <summary>
        /// Swaps two variables 
        /// </summary>
        /// <param name="first">The main variable</param>
        /// <param name="second">The variable to switch with</param>
        /// <returns>The value from the second variable and sets second variable to original value</returns>
        public static float SwapWith(this float first, ref float second)
        {
            var tmp = second;
            second = first;
            return tmp;
        }
        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static float PercentOf(this float percent, float value) => (float)(((float)percent) / ((float)100) * ((float)value));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static float AddPercent(this float value, float percent) => (float)(value + value.PercentOf(percent));

        /// <summary>
        /// Substracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static float SubstractPercent(this float value, float percent) => (float)(value - value.PercentOf(percent));

        /// <summary>
        /// Substracts byte from float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float Substract(this float x, byte y) => x - (float)y;

        /// <summary>
        /// Adds byte to float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float Add(this float x, byte y) => x + (float)y;

        /// <summary>
        /// Divides byte from float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float DividedBy(this float x, byte y) => x / (float)y;

        /// <summary>
        /// Multiplies byte with float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float MultipliedWith(this float x, byte y) => x * (float)y;

        /// <summary>
        /// Gets the remainder of byte from float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float Modulus(this float x, byte y) => x % (float)y;

        /// <summary>
        /// Gets a boolean True if float is less than byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this float x, byte y) => x < (float)y;

        /// <summary>
        /// Gets a boolean True if float is greater than byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this float x, byte y) => x > (float)y;

        /// <summary>
        /// Gets boolean True if byte is equal to float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this float x, byte y) => x == (float)y;

        /// <summary>
        /// Gets boolean True if byte is not equal to float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this float x, byte y) => x != (float)y;

        /// <summary>
        /// Tries to cast float to byte, this can get ugly though
        /// </summary>
        /// <param name="x">The original value</param>
        /// <returns>The result of the operation</returns>
        public static byte CastFloatToByte(this float x) => (byte)x;

        /// <summary>
        /// Substracts char from float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float Substract(this float x, char y) => x - (float)y;

        /// <summary>
        /// Adds char to float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float Add(this float x, char y) => x + (float)y;

        /// <summary>
        /// Divides char from float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float DividedBy(this float x, char y) => x / (float)y;

        /// <summary>
        /// Multiplies char with float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float MultipliedWith(this float x, char y) => x * (float)y;

        /// <summary>
        /// Gets the remainder of char from float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float Modulus(this float x, char y) => x % (float)y;

        /// <summary>
        /// Gets a boolean True if float is less than char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this float x, char y) => x < (float)y;

        /// <summary>
        /// Gets a boolean True if float is greater than char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this float x, char y) => x > (float)y;

        /// <summary>
        /// Gets boolean True if char is equal to float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this float x, char y) => x == (float)y;

        /// <summary>
        /// Gets boolean True if char is not equal to float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this float x, char y) => x != (float)y;

        /// <summary>
        /// Tries to cast float to char, this can get ugly though
        /// </summary>
        /// <param name="x">The original value</param>
        /// <returns>The result of the operation</returns>
        public static char CastFloatToChar(this float x) => (char)x;

        /// <summary>
        /// Substracts decimal from float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float Substract(this float x, decimal y) => x - (float)y;

        /// <summary>
        /// Adds decimal to float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float Add(this float x, decimal y) => x + (float)y;

        /// <summary>
        /// Divides decimal from float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float DividedBy(this float x, decimal y) => x / (float)y;

        /// <summary>
        /// Multiplies decimal with float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float MultipliedWith(this float x, decimal y) => x * (float)y;

        /// <summary>
        /// Gets the remainder of decimal from float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float Modulus(this float x, decimal y) => x % (float)y;

        /// <summary>
        /// Gets a boolean True if float is less than decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this float x, decimal y) => x < (float)y;

        /// <summary>
        /// Gets a boolean True if float is greater than decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this float x, decimal y) => x > (float)y;

        /// <summary>
        /// Gets boolean True if decimal is equal to float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this float x, decimal y) => x == (float)y;

        /// <summary>
        /// Gets boolean True if decimal is not equal to float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this float x, decimal y) => x != (float)y;

        /// <summary>
        /// Tries to cast float to decimal, this can get ugly though
        /// </summary>
        /// <param name="x">The original value</param>
        /// <returns>The result of the operation</returns>
        public static decimal CastFloatToDecimal(this float x) => (decimal)x;

        /// <summary>
        /// Substracts double from float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float Substract(this float x, double y) => x - (float)y;

        /// <summary>
        /// Adds double to float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float Add(this float x, double y) => x + (float)y;

        /// <summary>
        /// Divides double from float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float DividedBy(this float x, double y) => x / (float)y;

        /// <summary>
        /// Multiplies double with float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float MultipliedWith(this float x, double y) => x * (float)y;

        /// <summary>
        /// Gets the remainder of double from float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float Modulus(this float x, double y) => x % (float)y;

        /// <summary>
        /// Gets a boolean True if float is less than double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this float x, double y) => x < (float)y;

        /// <summary>
        /// Gets a boolean True if float is greater than double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this float x, double y) => x > (float)y;

        /// <summary>
        /// Gets boolean True if double is equal to float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this float x, double y) => x == (float)y;

        /// <summary>
        /// Gets boolean True if double is not equal to float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this float x, double y) => x != (float)y;

        /// <summary>
        /// Tries to cast float to double, this can get ugly though
        /// </summary>
        /// <param name="x">The original value</param>
        /// <returns>The result of the operation</returns>
        public static double CastFloatToDouble(this float x) => (double)x;

        /// <summary>
        /// Substracts float from float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float Substract(this float x, float y) => x - y;

        /// <summary>
        /// Adds float to float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float Add(this float x, float y) => x + y;

        /// <summary>
        /// Divides float from float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float DividedBy(this float x, float y) => x / y;

        /// <summary>
        /// Multiplies float with float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float MultipliedWith(this float x, float y) => x * y;

        /// <summary>
        /// Gets the remainder of float from float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float Modulus(this float x, float y) => x % y;

        /// <summary>
        /// Gets a boolean True if float is less than float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this float x, float y) => x < y;

        /// <summary>
        /// Gets a boolean True if float is greater than float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this float x, float y) => x > y;

        /// <summary>
        /// Gets boolean True if float is equal to float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this float x, float y) => x == y;

        /// <summary>
        /// Gets boolean True if float is not equal to float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this float x, float y) => x != y;

        /// <summary>
        /// Substracts int from float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float Substract(this float x, int y) => x - (float)y;

        /// <summary>
        /// Adds int to float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float Add(this float x, int y) => x + (float)y;

        /// <summary>
        /// Divides int from float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float DividedBy(this float x, int y) => x / (float)y;

        /// <summary>
        /// Multiplies int with float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float MultipliedWith(this float x, int y) => x * (float)y;

        /// <summary>
        /// Gets the remainder of int from float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float Modulus(this float x, int y) => x % (float)y;

        /// <summary>
        /// Gets a boolean True if float is less than int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this float x, int y) => x < (float)y;

        /// <summary>
        /// Gets a boolean True if float is greater than int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this float x, int y) => x > (float)y;

        /// <summary>
        /// Gets boolean True if int is equal to float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this float x, int y) => x == (float)y;

        /// <summary>
        /// Gets boolean True if int is not equal to float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this float x, int y) => x != (float)y;

        /// <summary>
        /// Tries to cast float to int, this can get ugly though
        /// </summary>
        /// <param name="x">The original value</param>
        /// <returns>The result of the operation</returns>
        public static int CastFloatToInt(this float x) => (int)x;

        /// <summary>
        /// Substracts long from float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float Substract(this float x, long y) => x - (float)y;

        /// <summary>
        /// Adds long to float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float Add(this float x, long y) => x + (float)y;

        /// <summary>
        /// Divides long from float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float DividedBy(this float x, long y) => x / (float)y;

        /// <summary>
        /// Multiplies long with float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float MultipliedWith(this float x, long y) => x * (float)y;

        /// <summary>
        /// Gets the remainder of long from float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float Modulus(this float x, long y) => x % (float)y;

        /// <summary>
        /// Gets a boolean True if float is less than long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this float x, long y) => x < (float)y;

        /// <summary>
        /// Gets a boolean True if float is greater than long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this float x, long y) => x > (float)y;

        /// <summary>
        /// Gets boolean True if long is equal to float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this float x, long y) => x == (float)y;

        /// <summary>
        /// Gets boolean True if long is not equal to float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this float x, long y) => x != (float)y;

        /// <summary>
        /// Tries to cast float to long, this can get ugly though
        /// </summary>
        /// <param name="x">The original value</param>
        /// <returns>The result of the operation</returns>
        public static long CastFloatToLong(this float x) => (long)x;

        /// <summary>
        /// Substracts sbyte from float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float Substract(this float x, sbyte y) => x - (float)y;

        /// <summary>
        /// Adds sbyte to float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float Add(this float x, sbyte y) => x + (float)y;

        /// <summary>
        /// Divides sbyte from float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float DividedBy(this float x, sbyte y) => x / (float)y;

        /// <summary>
        /// Multiplies sbyte with float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float MultipliedWith(this float x, sbyte y) => x * (float)y;

        /// <summary>
        /// Gets the remainder of sbyte from float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float Modulus(this float x, sbyte y) => x % (float)y;

        /// <summary>
        /// Gets a boolean True if float is less than sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this float x, sbyte y) => x < (float)y;

        /// <summary>
        /// Gets a boolean True if float is greater than sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this float x, sbyte y) => x > (float)y;

        /// <summary>
        /// Gets boolean true if value is less than zero
        /// </summary>
        /// <param name="x">The original value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNegative(this float x) => x < 0;

        /// <summary>
        /// Gets boolean true if value is more than zero
        /// </summary>
        /// <param name="x">The original value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsPositive(this float x) => x >= 0;

        /// <summary>
        /// Gets boolean True if sbyte is equal to float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this float x, sbyte y) => x == (float)y;

        /// <summary>
        /// Gets boolean True if sbyte is not equal to float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this float x, sbyte y) => x != (float)y;

        /// <summary>
        /// Tries to cast float to sbyte, this can get ugly though
        /// </summary>
        /// <param name="x">The original value</param>
        /// <returns>The result of the operation</returns>
        public static sbyte CastFloatToSbyte(this float x) => (sbyte)x;

        /// <summary>
        /// Substracts short from float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float Substract(this float x, short y) => x - (float)y;

        /// <summary>
        /// Adds short to float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float Add(this float x, short y) => x + (float)y;

        /// <summary>
        /// Divides short from float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float DividedBy(this float x, short y) => x / (float)y;

        /// <summary>
        /// Multiplies short with float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float MultipliedWith(this float x, short y) => x * (float)y;

        /// <summary>
        /// Gets the remainder of short from float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float Modulus(this float x, short y) => x % (float)y;

        /// <summary>
        /// Gets a boolean True if float is less than short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this float x, short y) => x < (float)y;

        /// <summary>
        /// Gets a boolean True if float is greater than short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this float x, short y) => x > (float)y;

        /// <summary>
        /// Gets boolean True if short is equal to float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this float x, short y) => x == (float)y;

        /// <summary>
        /// Gets boolean True if short is not equal to float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this float x, short y) => x != (float)y;

        /// <summary>
        /// Tries to cast float to short, this can get ugly though
        /// </summary>
        /// <param name="x">The original value</param>
        /// <returns>The result of the operation</returns>
        public static short CastFloatToShort(this float x) => (short)x;

        /// <summary>
        /// Substracts uint from float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float Substract(this float x, uint y) => x - (float)y;

        /// <summary>
        /// Adds uint to float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float Add(this float x, uint y) => x + (float)y;

        /// <summary>
        /// Divides uint from float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float DividedBy(this float x, uint y) => x / (float)y;

        /// <summary>
        /// Multiplies uint with float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float MultipliedWith(this float x, uint y) => x * (float)y;

        /// <summary>
        /// Gets the remainder of uint from float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float Modulus(this float x, uint y) => x % (float)y;

        /// <summary>
        /// Gets a boolean True if float is less than uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this float x, uint y) => x < (float)y;

        /// <summary>
        /// Gets a boolean True if float is greater than uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this float x, uint y) => x > (float)y;

        /// <summary>
        /// Gets boolean True if uint is equal to float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this float x, uint y) => x == (float)y;

        /// <summary>
        /// Gets boolean True if uint is not equal to float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this float x, uint y) => x != (float)y;

        /// <summary>
        /// Tries to cast float to uint, this can get ugly though
        /// </summary>
        /// <param name="x">The original value</param>
        /// <returns>The result of the operation</returns>
        public static uint CastFloatToUint(this float x) => (uint)x;

        /// <summary>
        /// Substracts ulong from float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float Substract(this float x, ulong y) => x - (float)y;

        /// <summary>
        /// Adds ulong to float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float Add(this float x, ulong y) => x + (float)y;

        /// <summary>
        /// Divides ulong from float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float DividedBy(this float x, ulong y) => x / (float)y;

        /// <summary>
        /// Multiplies ulong with float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float MultipliedWith(this float x, ulong y) => x * (float)y;

        /// <summary>
        /// Gets the remainder of ulong from float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float Modulus(this float x, ulong y) => x % (float)y;

        /// <summary>
        /// Gets a boolean True if float is less than ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this float x, ulong y) => x < (float)y;

        /// <summary>
        /// Gets a boolean True if float is greater than ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this float x, ulong y) => x > (float)y;

        /// <summary>
        /// Gets boolean True if ulong is equal to float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this float x, ulong y) => x == (float)y;

        /// <summary>
        /// Gets boolean True if ulong is not equal to float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this float x, ulong y) => x != (float)y;

        /// <summary>
        /// Tries to cast float to ulong, this can get ugly though
        /// </summary>
        /// <param name="x">The original value</param>
        /// <returns>The result of the operation</returns>
        public static ulong CastFloatToUlong(this float x) => (ulong)x;

        /// <summary>
        /// Substracts ushort from float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float Substract(this float x, ushort y) => x - (float)y;

        /// <summary>
        /// Adds ushort to float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float Add(this float x, ushort y) => x + (float)y;

        /// <summary>
        /// Divides ushort from float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float DividedBy(this float x, ushort y) => x / (float)y;

        /// <summary>
        /// Multiplies ushort with float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float MultipliedWith(this float x, ushort y) => x * (float)y;

        /// <summary>
        /// Gets the remainder of ushort from float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float Modulus(this float x, ushort y) => x % (float)y;

        /// <summary>
        /// Gets a boolean True if float is less than ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this float x, ushort y) => x < (float)y;

        /// <summary>
        /// Gets a boolean True if float is greater than ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this float x, ushort y) => x > (float)y;

        /// <summary>
        /// Gets boolean True if ushort is equal to float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this float x, ushort y) => x == (float)y;

        /// <summary>
        /// Gets boolean True if ushort is not equal to float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this float x, ushort y) => x != (float)y;

        /// <summary>
        /// Tries to cast float to ushort, this can get ugly though
        /// </summary>
        /// <param name="x">The original value</param>
        /// <returns>The result of the operation</returns>
        public static ushort CastFloatToUshort(this float x) => (ushort)x;

    }
}
