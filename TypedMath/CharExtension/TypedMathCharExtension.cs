//----------------------------------------------------------------------------------------------
// <copyright file="TypedMathCharExtension.cs" company="MarcusMedinaPro">
// By Marcus Medina, 2019 - http://MarcusMedina.Pro 
// This file is subject to the terms and conditions defined in file 'license.txt', which is part of this project.
// </copyright>
// ----------------------------------------------------------------------------------------------
// Credits for borrowed code:
// LinQ Primenumbers, Zoran Horvat, at http://www.codinghelmet.com/articles/linq-all-primes/
// Increase/Decrease array values, mgp - https://stackoverflow.com/users/55943/mqp, at https://stackoverflow.com/a/823537 
// ----------------------------------------------------------------------------------------------

namespace MarcusMedinaPro.TypedMath.CharExtension
{
    using System;
    using System.Linq;

    /// <summary>
    /// Extension for char
    /// </summary>
    public static class TypedMathCharExtension
    {
        /// <summary>
        /// Gets the first number in the array
        /// </summary>
        /// <param name="array">The array<see cref="char[]"/></param>
        /// <returns>The result of the operation</returns>
        public static char GetFirstValue(this char[] array) => array[0];

        /// <summary>
        /// Gets the hightest value of the numbers in the array
        /// </summary>
        /// <param name="array">The array</param>
        /// <returns>The hightest value in the array</returns>
        public static char GetHighestValue(this char[] array) => array.Max();

        /// <summary>
        /// Gets the last number in the array
        /// </summary>
        /// <param name="array">The array<see cref="char[]"/></param>
        /// <returns>The result of the operation</returns>
        public static char GetLastValue(this char[] array) => array[array.Length - 1];

        /// <summary>
        /// Peeks the lowest value in the array
        /// </summary>
        /// <param name="array">The array<see cref="char[]"/></param>
        /// <returns>The lowest value i the array</returns>
        public static char GetLowestValue(this char[] array) => array.Min();

        /// <summary>
        /// Gets the number in the middle of the array
        /// </summary>
        /// <param name="array">The array<see cref="char[]"/></param>
        /// <returns>The result of the operation</returns>
        public static char GetMiddleValue(this char[] array) => array[(array.Length - 1) / 2];

        /// <summary>
        /// Peeks numbers higher than given value in the array
        /// </summary>
        /// <param name="array"></param>
        /// <param name="x">The limit value</param>
        /// <returns>Returns a new array with all numbers higher than x</returns>
        public static char[] GetValuesHigherThan(this char[] array, char x) => array.Where(y => y >= x).ToArray();

        /// <summary>
        /// Peeks numbers lower than given value in the array
        /// </summary>
        /// <param name="array"></param>
        /// <param name="x">The limit value</param>
        /// <returns>Returns a new array with all numbers lower than x</returns>
        public static char[] GetValuesLowerThan(this char[] array, char x) => array.Where(y => y <= x).ToArray();

        /// <summary>
        /// Get the current size of the array
        /// </summary>
        /// <param name="array">The array<see cref="char[]"/></param>
        /// <param name="size">The size<see cref="int"/></param>
        /// <returns>The size of the array</returns>
        public static char[] SetNewArraySize(this char[] array, int size)
        {
            var newArr = new char[size];
            Array.Copy(array, 0, newArr, 0, array.Length);
            return newArr;
        }

        /// <summary>
        /// Sorts array from lowest to highest
        /// </summary>
        /// <param name="array">The array<see cref="char[]"/></param>
        /// <returns>A sorted array</returns>
        public static char[] SortArrayAsc(this char[] array) => array.OrderBy(x => x).ToArray();

        /// <summary>
        /// Sorts array from highest to lowest
        /// </summary>
        /// <param name="array">The array<see cref="char[]"/></param>
        /// <returns>A sorted array</returns>
        public static char[] SortArrayDesc(this char[] array) => array.OrderByDescending(x => x).ToArray();

        /// <summary>
        /// Converts the array to int.
        /// </summary>
        /// <param name="array">The array.</param>
        /// <returns>The <see cref="int[]"/></returns>
        public static int[] ConvertArrayToInt(this char[] array) => array.Select(x => (int)x).ToArray();

        /// <summary>
        /// Rotates the numbers to the left.
        /// </summary>
        /// <param name="array">The array.</param>
        /// <returns>The <see cref="char[]"/></returns>
        public static char[] RotateLeft(this char[] array)
        {
            var first = array.GetFirstValue();
            Array.Copy(array, 1, array, 0, array.Length - 1);
            array[array.Length - 1] = first;
            return array;
        }

        /// <summary>
        /// Rotates the numbers to the right.
        /// </summary>
        /// <param name="array">The array.</param>
        /// <returns>The <see cref="char[]"/></returns>
        public static char[] RotateRight(this char[] array)
        {
            var last = array.GetLastValue();
            Array.Copy(array, 0, array, 1, array.Length - 1);
            array[0] = last;
            return array;
        }

        /// <summary>
        /// Gets the first half of the array.
        /// </summary>
        /// <param name="array">The array.</param>
        /// <returns>The <see cref="char[]"/></returns>
        public static char[] GetFirstHalf(this char[] array) => array.Take(array.Length / 2).ToArray();

        /// <summary>
        /// Gets the last half of the array.
        /// </summary>
        /// <param name="array">The array.</param>
        /// <returns>The <see cref="char[]"/></returns>
        public static char[] GetLastHalf(this char[] array) => array.Skip(array.Length / 2).Take(array.Length / 2).ToArray();

        /// <summary>
        /// Gets the middle of both halves in the array.
        /// </summary>
        /// <param name="array">The array.</param>
        /// <returns>The <see cref="char[]"/></returns>
        public static char[] GetMiddle(this char[] array) => array.Skip(array.Length / 4).Take(array.Length / 2).ToArray();

        /// <summary>
        /// Gets the NOT of char
        /// </summary>
        /// <param name="x">The x<see cref="char"/></param>
        /// <returns>The result of the operation</returns>
        public static char Not(this char x) => (char)~(int)x;

        /// <summary>
        /// Checks if a number is prime
        /// </summary>
        /// <param name="number">The number</param>
        /// <returns>True if the number is prime</returns>
        public static bool IsPrime(this char number) => Enumerable.Range(2, (int)Math.Sqrt(number) - 1).All(divisor => number % divisor != 0);

        /// <summary>
        /// Compare original and second number
        /// </summary>
        /// <param name="first">The number</param>
        /// <param name="second">The number to compare with</param>
        /// <returns>The highest of the two numbers</returns>
        public static char ChooseIfHigher(this char first, char second) => first > second ? first : second;

        /// <summary>
        /// Compare original and second number
        /// </summary>
        /// <param name="first">The number</param>
        /// <param name="second">The number to compare with</param>
        /// <returns>The lowest of the two numbers</returns>
        public static char ChooseIfLower(this char first, char second) => first < second ? first : second;

        /// <summary>
        /// Compare original and second number and set the variable with the highest
        /// </summary>
        /// <param name="first">The variable</param>
        /// <param name="second">The number to compare</param>
        /// <param name="third">The number to compare with</param>
        /// <returns>Sets the variable to the highest of the two numbers</returns>
        public static ref char SetHighestValueOf(this ref char first, char second, char third)
        {
            first = second > third ? second : third;
            return ref first;
        }

        /// <summary>
        /// Compare original and second number and set the variable with the lowest
        /// </summary>
        /// <param name="first">The number</param>
        /// <param name="second">The number to compare with</param>
        /// <param name="third">The third<see cref="char"/></param>
        /// <returns>Sets the variable to the lowest of the two numbers</returns>
        public static ref char SetLowestValueOf(this ref char first, char second, char third)
        {
            first = second < third ? second : third;
            return ref first;
        }

        /// <summary>
        /// Swaps two variables
        /// </summary>
        /// <param name="first">The main variable</param>
        /// <param name="second">The variable to switch with</param>
        /// <returns>The value from the second variable and sets second variable to original value</returns>
        public static ref char SwapWith(this ref char first, ref char second)
        {
            var tmp = second;
            second = first;
            first = tmp;
            return ref first;
        }

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static char PercentOf(this char percent, byte value) => (char)(((char)percent) / ((char)100) * ((char)value));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static char AddPercent(this char value, byte percent) => (char)(value + value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static char SubtractPercent(this char value, byte percent) => (char)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(byte) instead.", false)]
        public static char SubstractPercent(this char value, byte percent) => (char)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts byte from char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char Subtract(this char x, byte y) => (char)((int)x - (int)y);

        /// <summary>
        /// Subtracts byte from char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(char,byte) instead.", false)]
        public static char Substract(this char x, byte y) => (char)((int)x - (int)y);

        /// <summary>
        /// Adds byte to char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char Add(this char x, byte y) => (char)((int)x + (int)y);

        /// <summary>
        /// Divides byte from char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char DividedBy(this char x, byte y) => (char)((int)x / (int)y);

        /// <summary>
        /// Multiplies byte with char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char MultipliedWith(this char x, byte y) => (char)((int)x * (int)y);

        /// <summary>
        /// Gets the remainder of byte from char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char Modulus(this char x, byte y) => (char)((int)x % (int)y);

        /// <summary>
        /// Gets the AND of byte and char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char And(this char x, byte y) => (char)((int)x & (int)y);

        /// <summary>
        /// Gets the OR of byte and char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char Or(this char x, byte y) => (char)((int)x | (int)y);

        /// <summary>
        /// Gets shift left of byte from char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char ShiftLeft(this char x, byte y) => (char)((int)x << (int)y);

        /// <summary>
        /// Gets shift right of byte from char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char ShiftRight(this char x, byte y) => (char)((int)x >> (int)y);

        /// <summary>
        /// Gets XOR of byte of char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char Xor(this char x, byte y) => (char)((int)x ^ (int)y);

        /// <summary>
        /// Gets a boolean True if char is less than byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this char x, byte y) => x < (char)y;

        /// <summary>
        /// Gets a boolean True if char is greater than byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this char x, byte y) => x > (char)y;

        /// <summary>
        /// Gets boolean True if byte is equal to char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this char x, byte y) => x == (char)y;

        /// <summary>
        /// Gets boolean True if byte is not equal to char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this char x, byte y) => x != (char)y;

        /// <summary>
        /// Tries to cast char to byte, this can get ugly though
        /// </summary>
        /// <param name="x">The x<see cref="char"/></param>
        /// <returns>The result of the operation</returns>
        public static byte CastCharToByte(this char x) => (byte)x;

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static char PercentOf(this char percent, char value) => (char)(((char)percent) / ((char)100) * ((char)value));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static char AddPercent(this char value, char percent) => (char)(value + value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static char SubtractPercent(this char value, char percent) => (char)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(char) instead.", false)]
        public static char SubstractPercent(this char value, char percent) => (char)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts char from char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char Subtract(this char x, char y) => (char)((int)x - (int)y);

        /// <summary>
        /// Subtracts char from char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(char,char) instead.", false)]
        public static char Substract(this char x, char y) => (char)((int)x - (int)y);

        /// <summary>
        /// Adds char to char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char Add(this char x, char y) => (char)((int)x + (int)y);

        /// <summary>
        /// Divides char from char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char DividedBy(this char x, char y) => (char)((int)x / (int)y);

        /// <summary>
        /// Multiplies char with char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char MultipliedWith(this char x, char y) => (char)((int)x * (int)y);

        /// <summary>
        /// Gets the remainder of char from char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char Modulus(this char x, char y) => (char)((int)x % (int)y);

        /// <summary>
        /// Gets the AND of char and char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char And(this char x, char y) => (char)((int)x & (int)y);

        /// <summary>
        /// Gets the OR of char and char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char Or(this char x, char y) => (char)((int)x | (int)y);

        /// <summary>
        /// Gets shift left of char from char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char ShiftLeft(this char x, char y) => (char)((int)x << (int)y);

        /// <summary>
        /// Gets shift right of char from char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char ShiftRight(this char x, char y) => (char)((int)x >> (int)y);

        /// <summary>
        /// Gets XOR of char of char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char Xor(this char x, char y) => (char)((int)x ^ (int)y);

        /// <summary>
        /// Gets a boolean True if char is less than char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this char x, char y) => x < y;

        /// <summary>
        /// Gets a boolean True if char is greater than char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this char x, char y) => x > y;

        /// <summary>
        /// Gets boolean True if char is equal to char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this char x, char y) => x == y;

        /// <summary>
        /// Gets boolean True if char is not equal to char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this char x, char y) => x != y;

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static char PercentOf(this char percent, decimal value) => (char)(((char)percent) / ((char)100) * ((char)value));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static char AddPercent(this char value, decimal percent) => (char)(value + value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static char SubtractPercent(this char value, decimal percent) => (char)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(decimal) instead.", false)]
        public static char SubstractPercent(this char value, decimal percent) => (char)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts decimal from char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char Subtract(this char x, decimal y) => (char)((int)x - (int)y);

        /// <summary>
        /// Subtracts decimal from char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(char,decimal) instead.", false)]
        public static char Substract(this char x, decimal y) => (char)((int)x - (int)y);

        /// <summary>
        /// Adds decimal to char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char Add(this char x, decimal y) => (char)((int)x + (int)y);

        /// <summary>
        /// Divides decimal from char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char DividedBy(this char x, decimal y) => (char)((int)x / (int)y);

        /// <summary>
        /// Multiplies decimal with char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char MultipliedWith(this char x, decimal y) => (char)((int)x * (int)y);

        /// <summary>
        /// Gets the remainder of decimal from char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char Modulus(this char x, decimal y) => (char)((int)x % (int)y);

        /// <summary>
        /// Gets the AND of decimal and char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char And(this char x, decimal y) => (char)((int)x & (int)y);

        /// <summary>
        /// Gets the OR of decimal and char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char Or(this char x, decimal y) => (char)((int)x | (int)y);

        /// <summary>
        /// Gets shift left of decimal from char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char ShiftLeft(this char x, decimal y) => (char)((int)x << (int)y);

        /// <summary>
        /// Gets shift right of decimal from char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char ShiftRight(this char x, decimal y) => (char)((int)x >> (int)y);

        /// <summary>
        /// Gets XOR of decimal of char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char Xor(this char x, decimal y) => (char)((int)x ^ (int)y);

        /// <summary>
        /// Gets a boolean True if char is less than decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this char x, decimal y) => x < (char)y;

        /// <summary>
        /// Gets a boolean True if char is greater than decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this char x, decimal y) => x > (char)y;

        /// <summary>
        /// Gets boolean True if decimal is equal to char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this char x, decimal y) => x == (char)y;

        /// <summary>
        /// Gets boolean True if decimal is not equal to char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this char x, decimal y) => x != (char)y;

        /// <summary>
        /// Tries to cast char to decimal, this can get ugly though
        /// </summary>
        /// <param name="x">The x<see cref="char"/></param>
        /// <returns>The result of the operation</returns>
        public static decimal CastCharToDecimal(this char x) => (decimal)x;

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static char PercentOf(this char percent, double value) => (char)(((char)percent) / ((char)100) * ((char)value));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static char AddPercent(this char value, double percent) => (char)(value + value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static char SubtractPercent(this char value, double percent) => (char)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(double) instead.", false)]
        public static char SubstractPercent(this char value, double percent) => (char)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts double from char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char Subtract(this char x, double y) => (char)((int)x - (int)y);

        /// <summary>
        /// Subtracts double from char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(char,double) instead.", false)]
        public static char Substract(this char x, double y) => (char)((int)x - (int)y);

        /// <summary>
        /// Adds double to char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char Add(this char x, double y) => (char)((int)x + (int)y);

        /// <summary>
        /// Divides double from char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char DividedBy(this char x, double y) => (char)((int)x / (int)y);

        /// <summary>
        /// Multiplies double with char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char MultipliedWith(this char x, double y) => (char)((int)x * (int)y);

        /// <summary>
        /// Gets the remainder of double from char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char Modulus(this char x, double y) => (char)((int)x % (int)y);

        /// <summary>
        /// Gets the AND of double and char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char And(this char x, double y) => (char)((int)x & (int)y);

        /// <summary>
        /// Gets the OR of double and char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char Or(this char x, double y) => (char)((int)x | (int)y);

        /// <summary>
        /// Gets shift left of double from char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char ShiftLeft(this char x, double y) => (char)((int)x << (int)y);

        /// <summary>
        /// Gets shift right of double from char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char ShiftRight(this char x, double y) => (char)((int)x >> (int)y);

        /// <summary>
        /// Gets XOR of double of char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char Xor(this char x, double y) => (char)((int)x ^ (int)y);

        /// <summary>
        /// Gets a boolean True if char is less than double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this char x, double y) => x < (char)y;

        /// <summary>
        /// Gets a boolean True if char is greater than double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this char x, double y) => x > (char)y;

        /// <summary>
        /// Gets boolean True if double is equal to char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this char x, double y) => x == (char)y;

        /// <summary>
        /// Gets boolean True if double is not equal to char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this char x, double y) => x != (char)y;

        /// <summary>
        /// Tries to cast char to double, this can get ugly though
        /// </summary>
        /// <param name="x">The x<see cref="char"/></param>
        /// <returns>The result of the operation</returns>
        public static double CastCharToDouble(this char x) => (double)x;

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static char PercentOf(this char percent, float value) => (char)(((char)percent) / ((char)100) * ((char)value));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static char AddPercent(this char value, float percent) => (char)(value + value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static char SubtractPercent(this char value, float percent) => (char)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(float) instead.", false)]
        public static char SubstractPercent(this char value, float percent) => (char)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts float from char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char Subtract(this char x, float y) => (char)((int)x - (int)y);

        /// <summary>
        /// Subtracts float from char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(char,float) instead.", false)]
        public static char Substract(this char x, float y) => (char)((int)x - (int)y);

        /// <summary>
        /// Adds float to char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char Add(this char x, float y) => (char)((int)x + (int)y);

        /// <summary>
        /// Divides float from char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char DividedBy(this char x, float y) => (char)((int)x / (int)y);

        /// <summary>
        /// Multiplies float with char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char MultipliedWith(this char x, float y) => (char)((int)x * (int)y);

        /// <summary>
        /// Gets the remainder of float from char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char Modulus(this char x, float y) => (char)((int)x % (int)y);

        /// <summary>
        /// Gets the AND of float and char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char And(this char x, float y) => (char)((int)x & (int)y);

        /// <summary>
        /// Gets the OR of float and char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char Or(this char x, float y) => (char)((int)x | (int)y);

        /// <summary>
        /// Gets shift left of float from char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char ShiftLeft(this char x, float y) => (char)((int)x << (int)y);

        /// <summary>
        /// Gets shift right of float from char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char ShiftRight(this char x, float y) => (char)((int)x >> (int)y);

        /// <summary>
        /// Gets XOR of float of char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char Xor(this char x, float y) => (char)((int)x ^ (int)y);

        /// <summary>
        /// Gets a boolean True if char is less than float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this char x, float y) => x < (char)y;

        /// <summary>
        /// Gets a boolean True if char is greater than float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this char x, float y) => x > (char)y;

        /// <summary>
        /// Gets boolean True if float is equal to char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this char x, float y) => x == (char)y;

        /// <summary>
        /// Gets boolean True if float is not equal to char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this char x, float y) => x != (char)y;

        /// <summary>
        /// Tries to cast char to float, this can get ugly though
        /// </summary>
        /// <param name="x">The x<see cref="char"/></param>
        /// <returns>The result of the operation</returns>
        public static float CastCharToFloat(this char x) => (float)x;

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static char PercentOf(this char percent, int value) => (char)(((char)percent) / ((char)100) * ((char)value));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static char AddPercent(this char value, int percent) => (char)(value + value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static char SubtractPercent(this char value, int percent) => (char)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(int) instead.", false)]
        public static char SubstractPercent(this char value, int percent) => (char)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts int from char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char Subtract(this char x, int y) => (char)((int)x - (int)y);

        /// <summary>
        /// Subtracts int from char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(char,int) instead.", false)]
        public static char Substract(this char x, int y) => (char)((int)x - (int)y);

        /// <summary>
        /// Adds int to char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char Add(this char x, int y) => (char)((int)x + (int)y);

        /// <summary>
        /// Divides int from char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char DividedBy(this char x, int y) => (char)((int)x / (int)y);

        /// <summary>
        /// Multiplies int with char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char MultipliedWith(this char x, int y) => (char)((int)x * (int)y);

        /// <summary>
        /// Gets the remainder of int from char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char Modulus(this char x, int y) => (char)((int)x % (int)y);

        /// <summary>
        /// Gets the AND of int and char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char And(this char x, int y) => (char)((int)x & (int)y);

        /// <summary>
        /// Gets the OR of int and char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char Or(this char x, int y) => (char)((int)x | (int)y);

        /// <summary>
        /// Gets shift left of int from char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char ShiftLeft(this char x, int y) => (char)((int)x << (int)y);

        /// <summary>
        /// Gets shift right of int from char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char ShiftRight(this char x, int y) => (char)((int)x >> (int)y);

        /// <summary>
        /// Gets XOR of int of char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char Xor(this char x, int y) => (char)((int)x ^ (int)y);

        /// <summary>
        /// Gets a boolean True if char is less than int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this char x, int y) => x < (char)y;

        /// <summary>
        /// Gets a boolean True if char is greater than int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this char x, int y) => x > (char)y;

        /// <summary>
        /// Gets boolean True if int is equal to char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this char x, int y) => x == (char)y;

        /// <summary>
        /// Gets boolean True if int is not equal to char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this char x, int y) => x != (char)y;

        /// <summary>
        /// Tries to cast char to int, this can get ugly though
        /// </summary>
        /// <param name="x">The x<see cref="char"/></param>
        /// <returns>The result of the operation</returns>
        public static int CastCharToInt(this char x) => (int)x;

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static char PercentOf(this char percent, long value) => (char)(((char)percent) / ((char)100) * ((char)value));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static char AddPercent(this char value, long percent) => (char)(value + value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static char SubtractPercent(this char value, long percent) => (char)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(long) instead.", false)]
        public static char SubstractPercent(this char value, long percent) => (char)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts long from char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char Subtract(this char x, long y) => (char)((int)x - (int)y);

        /// <summary>
        /// Subtracts long from char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(char,long) instead.", false)]
        public static char Substract(this char x, long y) => (char)((int)x - (int)y);

        /// <summary>
        /// Adds long to char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char Add(this char x, long y) => (char)((int)x + (int)y);

        /// <summary>
        /// Divides long from char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char DividedBy(this char x, long y) => (char)((int)x / (int)y);

        /// <summary>
        /// Multiplies long with char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char MultipliedWith(this char x, long y) => (char)((int)x * (int)y);

        /// <summary>
        /// Gets the remainder of long from char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char Modulus(this char x, long y) => (char)((int)x % (int)y);

        /// <summary>
        /// Gets the AND of long and char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char And(this char x, long y) => (char)((int)x & (int)y);

        /// <summary>
        /// Gets the OR of long and char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char Or(this char x, long y) => (char)((int)x | (int)y);

        /// <summary>
        /// Gets shift left of long from char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char ShiftLeft(this char x, long y) => (char)((int)x << (int)y);

        /// <summary>
        /// Gets shift right of long from char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char ShiftRight(this char x, long y) => (char)((int)x >> (int)y);

        /// <summary>
        /// Gets XOR of long of char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char Xor(this char x, long y) => (char)((int)x ^ (int)y);

        /// <summary>
        /// Gets a boolean True if char is less than long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this char x, long y) => x < (char)y;

        /// <summary>
        /// Gets a boolean True if char is greater than long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this char x, long y) => x > (char)y;

        /// <summary>
        /// Gets boolean True if long is equal to char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this char x, long y) => x == (char)y;

        /// <summary>
        /// Gets boolean True if long is not equal to char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this char x, long y) => x != (char)y;

        /// <summary>
        /// Tries to cast char to long, this can get ugly though
        /// </summary>
        /// <param name="x">The x<see cref="char"/></param>
        /// <returns>The result of the operation</returns>
        public static long CastCharToLong(this char x) => (long)x;

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static char PercentOf(this char percent, sbyte value) => (char)(((char)percent) / ((char)100) * ((char)value));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static char AddPercent(this char value, sbyte percent) => (char)(value + value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static char SubtractPercent(this char value, sbyte percent) => (char)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(sbyte) instead.", false)]
        public static char SubstractPercent(this char value, sbyte percent) => (char)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts sbyte from char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char Subtract(this char x, sbyte y) => (char)((int)x - (int)y);

        /// <summary>
        /// Subtracts sbyte from char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(char,sbyte) instead.", false)]
        public static char Substract(this char x, sbyte y) => (char)((int)x - (int)y);

        /// <summary>
        /// Adds sbyte to char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char Add(this char x, sbyte y) => (char)((int)x + (int)y);

        /// <summary>
        /// Divides sbyte from char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char DividedBy(this char x, sbyte y) => (char)((int)x / (int)y);

        /// <summary>
        /// Multiplies sbyte with char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char MultipliedWith(this char x, sbyte y) => (char)((int)x * (int)y);

        /// <summary>
        /// Gets the remainder of sbyte from char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char Modulus(this char x, sbyte y) => (char)((int)x % (int)y);

        /// <summary>
        /// Gets the AND of sbyte and char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char And(this char x, sbyte y) => (char)((int)x & (int)y);

        /// <summary>
        /// Gets the OR of sbyte and char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char Or(this char x, sbyte y) => (char)((int)x | (int)y);

        /// <summary>
        /// Gets shift left of sbyte from char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char ShiftLeft(this char x, sbyte y) => (char)((int)x << (int)y);

        /// <summary>
        /// Gets shift right of sbyte from char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char ShiftRight(this char x, sbyte y) => (char)((int)x >> (int)y);

        /// <summary>
        /// Gets XOR of sbyte of char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char Xor(this char x, sbyte y) => (char)((int)x ^ (int)y);

        /// <summary>
        /// Gets a boolean True if char is less than sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this char x, sbyte y) => x < (char)y;

        /// <summary>
        /// Gets a boolean True if char is greater than sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this char x, sbyte y) => x > (char)y;

        /// <summary>
        /// Gets boolean true if value is less than zero
        /// </summary>
        /// <param name="x">The x<see cref="char"/></param>
        /// <returns>The result of the operation</returns>
        public static bool IsNegative(this char x) => x < 0;

        /// <summary>
        /// Gets boolean true if value is more than zero
        /// </summary>
        /// <param name="x">The x<see cref="char"/></param>
        /// <returns>The result of the operation</returns>
        public static bool IsPositive(this char x) => x >= 0;

        /// <summary>
        /// Gets boolean True if sbyte is equal to char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this char x, sbyte y) => x == (char)y;

        /// <summary>
        /// Gets boolean True if sbyte is not equal to char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this char x, sbyte y) => x != (char)y;

        /// <summary>
        /// Tries to cast char to sbyte, this can get ugly though
        /// </summary>
        /// <param name="x">The x<see cref="char"/></param>
        /// <returns>The result of the operation</returns>
        public static sbyte CastCharToSbyte(this char x) => (sbyte)x;

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static char PercentOf(this char percent, short value) => (char)(((char)percent) / ((char)100) * ((char)value));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static char AddPercent(this char value, short percent) => (char)(value + value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static char SubtractPercent(this char value, short percent) => (char)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(short) instead.", false)]
        public static char SubstractPercent(this char value, short percent) => (char)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts short from char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char Subtract(this char x, short y) => (char)((int)x - (int)y);

        /// <summary>
        /// Subtracts short from char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(char,short) instead.", false)]
        public static char Substract(this char x, short y) => (char)((int)x - (int)y);

        /// <summary>
        /// Adds short to char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char Add(this char x, short y) => (char)((int)x + (int)y);

        /// <summary>
        /// Divides short from char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char DividedBy(this char x, short y) => (char)((int)x / (int)y);

        /// <summary>
        /// Multiplies short with char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char MultipliedWith(this char x, short y) => (char)((int)x * (int)y);

        /// <summary>
        /// Gets the remainder of short from char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char Modulus(this char x, short y) => (char)((int)x % (int)y);

        /// <summary>
        /// Gets the AND of short and char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char And(this char x, short y) => (char)((int)x & (int)y);

        /// <summary>
        /// Gets the OR of short and char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char Or(this char x, short y) => (char)((int)x | (int)y);

        /// <summary>
        /// Gets shift left of short from char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char ShiftLeft(this char x, short y) => (char)((int)x << (int)y);

        /// <summary>
        /// Gets shift right of short from char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char ShiftRight(this char x, short y) => (char)((int)x >> (int)y);

        /// <summary>
        /// Gets XOR of short of char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char Xor(this char x, short y) => (char)((int)x ^ (int)y);

        /// <summary>
        /// Gets a boolean True if char is less than short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this char x, short y) => x < (char)y;

        /// <summary>
        /// Gets a boolean True if char is greater than short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this char x, short y) => x > (char)y;

        /// <summary>
        /// Gets boolean True if short is equal to char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this char x, short y) => x == (char)y;

        /// <summary>
        /// Gets boolean True if short is not equal to char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this char x, short y) => x != (char)y;

        /// <summary>
        /// Tries to cast char to short, this can get ugly though
        /// </summary>
        /// <param name="x">The x<see cref="char"/></param>
        /// <returns>The result of the operation</returns>
        public static short CastCharToShort(this char x) => (short)x;

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static char PercentOf(this char percent, uint value) => (char)(((char)percent) / ((char)100) * ((char)value));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static char AddPercent(this char value, uint percent) => (char)(value + value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static char SubtractPercent(this char value, uint percent) => (char)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(uint) instead.", false)]
        public static char SubstractPercent(this char value, uint percent) => (char)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts uint from char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char Subtract(this char x, uint y) => (char)((int)x - (int)y);

        /// <summary>
        /// Subtracts uint from char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(char,uint) instead.", false)]
        public static char Substract(this char x, uint y) => (char)((int)x - (int)y);

        /// <summary>
        /// Adds uint to char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char Add(this char x, uint y) => (char)((int)x + (int)y);

        /// <summary>
        /// Divides uint from char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char DividedBy(this char x, uint y) => (char)((int)x / (int)y);

        /// <summary>
        /// Multiplies uint with char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char MultipliedWith(this char x, uint y) => (char)((int)x * (int)y);

        /// <summary>
        /// Gets the remainder of uint from char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char Modulus(this char x, uint y) => (char)((int)x % (int)y);

        /// <summary>
        /// Gets the AND of uint and char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char And(this char x, uint y) => (char)((int)x & (int)y);

        /// <summary>
        /// Gets the OR of uint and char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char Or(this char x, uint y) => (char)((int)x | (int)y);

        /// <summary>
        /// Gets shift left of uint from char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char ShiftLeft(this char x, uint y) => (char)((int)x << (int)y);

        /// <summary>
        /// Gets shift right of uint from char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char ShiftRight(this char x, uint y) => (char)((int)x >> (int)y);

        /// <summary>
        /// Gets XOR of uint of char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char Xor(this char x, uint y) => (char)((int)x ^ (int)y);

        /// <summary>
        /// Gets a boolean True if char is less than uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this char x, uint y) => x < (char)y;

        /// <summary>
        /// Gets a boolean True if char is greater than uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this char x, uint y) => x > (char)y;

        /// <summary>
        /// Gets boolean True if uint is equal to char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this char x, uint y) => x == (char)y;

        /// <summary>
        /// Gets boolean True if uint is not equal to char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this char x, uint y) => x != (char)y;

        /// <summary>
        /// Tries to cast char to uint, this can get ugly though
        /// </summary>
        /// <param name="x">The x<see cref="char"/></param>
        /// <returns>The result of the operation</returns>
        public static uint CastCharToUint(this char x) => (uint)x;

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static char PercentOf(this char percent, ulong value) => (char)(((char)percent) / ((char)100) * ((char)value));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static char AddPercent(this char value, ulong percent) => (char)(value + value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static char SubtractPercent(this char value, ulong percent) => (char)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(ulong) instead.", false)]
        public static char SubstractPercent(this char value, ulong percent) => (char)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts ulong from char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char Subtract(this char x, ulong y) => (char)((int)x - (int)y);

        /// <summary>
        /// Subtracts ulong from char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(char,ulong) instead.", false)]
        public static char Substract(this char x, ulong y) => (char)((int)x - (int)y);

        /// <summary>
        /// Adds ulong to char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char Add(this char x, ulong y) => (char)((int)x + (int)y);

        /// <summary>
        /// Divides ulong from char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char DividedBy(this char x, ulong y) => (char)((int)x / (int)y);

        /// <summary>
        /// Multiplies ulong with char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char MultipliedWith(this char x, ulong y) => (char)((int)x * (int)y);

        /// <summary>
        /// Gets the remainder of ulong from char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char Modulus(this char x, ulong y) => (char)((int)x % (int)y);

        /// <summary>
        /// Gets the AND of ulong and char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char And(this char x, ulong y) => (char)((int)x & (int)y);

        /// <summary>
        /// Gets the OR of ulong and char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char Or(this char x, ulong y) => (char)((int)x | (int)y);

        /// <summary>
        /// Gets shift left of ulong from char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char ShiftLeft(this char x, ulong y) => (char)((int)x << (int)y);

        /// <summary>
        /// Gets shift right of ulong from char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char ShiftRight(this char x, ulong y) => (char)((int)x >> (int)y);

        /// <summary>
        /// Gets XOR of ulong of char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char Xor(this char x, ulong y) => (char)((int)x ^ (int)y);

        /// <summary>
        /// Gets a boolean True if char is less than ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this char x, ulong y) => x < (char)y;

        /// <summary>
        /// Gets a boolean True if char is greater than ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this char x, ulong y) => x > (char)y;

        /// <summary>
        /// Gets boolean True if ulong is equal to char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this char x, ulong y) => x == (char)y;

        /// <summary>
        /// Gets boolean True if ulong is not equal to char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this char x, ulong y) => x != (char)y;

        /// <summary>
        /// Tries to cast char to ulong, this can get ugly though
        /// </summary>
        /// <param name="x">The x<see cref="char"/></param>
        /// <returns>The result of the operation</returns>
        public static ulong CastCharToUlong(this char x) => (ulong)x;

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static char PercentOf(this char percent, ushort value) => (char)(((char)percent) / ((char)100) * ((char)value));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static char AddPercent(this char value, ushort percent) => (char)(value + value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static char SubtractPercent(this char value, ushort percent) => (char)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(ushort) instead.", false)]
        public static char SubstractPercent(this char value, ushort percent) => (char)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts ushort from char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char Subtract(this char x, ushort y) => (char)((int)x - (int)y);

        /// <summary>
        /// Subtracts ushort from char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(char,ushort) instead.", false)]
        public static char Substract(this char x, ushort y) => (char)((int)x - (int)y);

        /// <summary>
        /// Adds ushort to char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char Add(this char x, ushort y) => (char)((int)x + (int)y);

        /// <summary>
        /// Divides ushort from char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char DividedBy(this char x, ushort y) => (char)((int)x / (int)y);

        /// <summary>
        /// Multiplies ushort with char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char MultipliedWith(this char x, ushort y) => (char)((int)x * (int)y);

        /// <summary>
        /// Gets the remainder of ushort from char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char Modulus(this char x, ushort y) => (char)((int)x % (int)y);

        /// <summary>
        /// Gets the AND of ushort and char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char And(this char x, ushort y) => (char)((int)x & (int)y);

        /// <summary>
        /// Gets the OR of ushort and char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char Or(this char x, ushort y) => (char)((int)x | (int)y);

        /// <summary>
        /// Gets shift left of ushort from char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char ShiftLeft(this char x, ushort y) => (char)((int)x << (int)y);

        /// <summary>
        /// Gets shift right of ushort from char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char ShiftRight(this char x, ushort y) => (char)((int)x >> (int)y);

        /// <summary>
        /// Gets XOR of ushort of char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static char Xor(this char x, ushort y) => (char)((int)x ^ (int)y);

        /// <summary>
        /// Gets a boolean True if char is less than ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this char x, ushort y) => x < (char)y;

        /// <summary>
        /// Gets a boolean True if char is greater than ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this char x, ushort y) => x > (char)y;

        /// <summary>
        /// Gets boolean True if ushort is equal to char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this char x, ushort y) => x == (char)y;

        /// <summary>
        /// Gets boolean True if ushort is not equal to char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this char x, ushort y) => x != (char)y;

        /// <summary>
        /// Tries to cast char to ushort, this can get ugly though
        /// </summary>
        /// <param name="x">The x<see cref="char"/></param>
        /// <returns>The result of the operation</returns>
        public static ushort CastCharToUshort(this char x) => (ushort)x;
    }
}
