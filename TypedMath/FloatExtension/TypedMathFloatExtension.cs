//----------------------------------------------------------------------------------------------
// <copyright file="TypedMathFloatExtension.cs" company="MarcusMedinaPro">
// By Marcus Medina, 2019 - http://MarcusMedina.Pro 
// This file is subject to the terms and conditions defined in file 'license.txt', which is part of this project.
// </copyright>
// ----------------------------------------------------------------------------------------------
// Credits for borrowed code:
// LinQ Primenumbers, Zoran Horvat, at http://www.codinghelmet.com/articles/linq-all-primes/
// Increase/Decrease array values, mgp - https://stackoverflow.com/users/55943/mqp, at https://stackoverflow.com/a/823537 
// ----------------------------------------------------------------------------------------------

namespace MarcusMedinaPro.TypedMath.FloatExtension
{
    using System;
    using System.Linq;

    /// <summary>
    /// Extension for float
    /// </summary>
    public static class TypedMathFloatExtension
    {
        /// <summary>
        /// Peeks the average value of the numbers in the array
        /// </summary>
        /// <param name="array">The array</param>
        /// <returns>The average value from the array</returns>
        public static double GetAverage(this float[] array) => array.Average();

        /// <summary>
        /// Gets the first number in the array
        /// </summary>
        /// <param name="array">The array<see cref="float[]"/></param>
        /// <returns>The result of the operation</returns>
        public static float GetFirstValue(this float[] array) => array[0];

        /// <summary>
        /// Gets the hightest value of the numbers in the array
        /// </summary>
        /// <param name="array">The array</param>
        /// <returns>The hightest value in the array</returns>
        public static float GetHighestValue(this float[] array) => array.Max();

        /// <summary>
        /// Gets the last number in the array
        /// </summary>
        /// <param name="array">The array<see cref="float[]"/></param>
        /// <returns>The result of the operation</returns>
        public static float GetLastValue(this float[] array) => array[array.Length - 1];

        /// <summary>
        /// Peeks the lowest value in the array
        /// </summary>
        /// <param name="array">The array<see cref="float[]"/></param>
        /// <returns>The lowest value i the array</returns>
        public static float GetLowestValue(this float[] array) => array.Min();

        /// <summary>
        /// Gets the number in the middle of the array
        /// </summary>
        /// <param name="array">The array<see cref="float[]"/></param>
        /// <returns>The result of the operation</returns>
        public static float GetMiddleValue(this float[] array) => array[(array.Length - 1) / 2];

        /// <summary>
        /// Peeks numbers higher than given value in the array
        /// </summary>
        /// <param name="array"></param>
        /// <param name="x">The limit value</param>
        /// <returns>Returns a new array with all numbers higher than x</returns>
        public static float[] GetValuesHigherThan(this float[] array, float x) => array.Where(y => y >= x).ToArray();

        /// <summary>
        /// Peeks numbers lower than given value in the array
        /// </summary>
        /// <param name="array"></param>
        /// <param name="x">The limit value</param>
        /// <returns>Returns a new array with all numbers lower than x</returns>
        public static float[] GetValuesLowerThan(this float[] array, float x) => array.Where(y => y <= x).ToArray();

        /// <summary>
        /// Get the current size of the array
        /// </summary>
        /// <param name="array">The array<see cref="float[]"/></param>
        /// <param name="size">The size<see cref="int"/></param>
        /// <returns>The size of the array</returns>
        public static float[] SetNewArraySize(this float[] array, int size)
        {
            var newArr = new float[size];
            Array.Copy(array, 0, newArr, 0, array.Length);
            return newArr;
        }

        /// <summary>
        /// Sorts array from lowest to highest
        /// </summary>
        /// <param name="array">The array<see cref="float[]"/></param>
        /// <returns>A sorted array</returns>
        public static float[] SortArrayAsc(this float[] array) => array.OrderBy(x => x).ToArray();

        /// <summary>
        /// Sorts array from highest to lowest
        /// </summary>
        /// <param name="array">The array<see cref="float[]"/></param>
        /// <returns>A sorted array</returns>
        public static float[] SortArrayDesc(this float[] array) => array.OrderByDescending(x => x).ToArray();

        /// <summary>
        /// Sums all numbers in the array
        /// </summary>
        /// <param name="array">The array<see cref="float[]"/></param>
        /// <returns>A sum of all the numbers in the array</returns>
        public static float SumAllValues(this float[] array) => array.Sum();

        /// <summary>
        /// Converts the array to int.
        /// </summary>
        /// <param name="array">The array.</param>
        /// <returns>The <see cref="int[]"/></returns>
        public static int[] ConvertArrayToInt(this float[] array) => array.Select(x => (int)x).ToArray();

        /// <summary>
        /// Increases all values with given value.
        /// </summary>
        /// <param name="array">The array.</param>
        /// <param name="add">The value to add.</param>
        /// <returns>The <see cref="float[]"/></returns>
        public static float[] IncreaseAllValuesWith(this float[] array, float add) => array.Select(x => x + add).ToArray();

        /// <summary>
        /// Decreases all values with given value.
        /// </summary>
        /// <param name="array">The array.</param>
        /// <param name="dec">The value to add.</param>
        /// <returns>The <see cref="float[]"/></returns>
        public static float[] DecreaseAllValuesWith(this float[] array, float dec) => array.Select(x => x - dec).ToArray();

        /// <summary>
        /// Rotates the numbers to the left.
        /// </summary>
        /// <param name="array">The array.</param>
        /// <returns>The <see cref="float[]"/></returns>
        public static float[] RotateLeft(this float[] array)
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
        /// <returns>The <see cref="float[]"/></returns>
        public static float[] RotateRight(this float[] array)
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
        /// <returns>The <see cref="float[]"/></returns>
        public static float[] GetFirstHalf(this float[] array) => array.Take(array.Length / 2).ToArray();

        /// <summary>
        /// Gets the last half of the array.
        /// </summary>
        /// <param name="array">The array.</param>
        /// <returns>The <see cref="float[]"/></returns>
        public static float[] GetLastHalf(this float[] array) => array.Skip(array.Length / 2).Take(array.Length / 2).ToArray();

        /// <summary>
        /// Gets the middle of both halves in the array.
        /// </summary>
        /// <param name="array">The array.</param>
        /// <returns>The <see cref="float[]"/></returns>
        public static float[] GetMiddle(this float[] array) => array.Skip(array.Length / 4).Take(array.Length / 2).ToArray();

        /// <summary>
        /// Gets the NOT of float
        /// </summary>
        /// <param name="x">The x<see cref="float"/></param>
        /// <returns>The result of the operation</returns>
        public static float Not(this float x) => (float)~(int)x;

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
        public static float ChooseIfHigher(this float first, float second) => first > second ? first : second;

        /// <summary>
        /// Compare original and second number
        /// </summary>
        /// <param name="first">The number</param>
        /// <param name="second">The number to compare with</param>
        /// <returns>The lowest of the two numbers</returns>
        public static float ChooseIfLower(this float first, float second) => first < second ? first : second;

        /// <summary>
        /// Compare original and second number and set the variable with the highest
        /// </summary>
        /// <param name="first">The variable</param>
        /// <param name="second">The number to compare</param>
        /// <param name="third">The number to compare with</param>
        /// <returns>Sets the variable to the highest of the two numbers</returns>
        public static ref float SetHighestValueOf(this ref float first, float second, float third)
        {
            first = second > third ? second : third;
            return ref first;
        }

        /// <summary>
        /// Compare original and second number and set the variable with the lowest
        /// </summary>
        /// <param name="first">The number</param>
        /// <param name="second">The number to compare with</param>
        /// <param name="third">The third<see cref="float"/></param>
        /// <returns>Sets the variable to the lowest of the two numbers</returns>
        public static ref float SetLowestValueOf(this ref float first, float second, float third)
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
        public static ref float SwapWith(this ref float first, ref float second)
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
        public static float PercentOf(this float percent, byte value) => (float)(((float)percent) / ((float)100) * ((float)value));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static float AddPercent(this float value, byte percent) => (float)(value + value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static float SubtractPercent(this float value, byte percent) => (float)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(byte) instead.", false)]
        public static float SubstractPercent(this float value, byte percent) => (float)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts byte from float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float Subtract(this float x, byte y) => x - (float)y;

        /// <summary>
        /// Subtracts byte from float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(float,byte) instead.", false)]
        public static float Substract(this float x, byte y) => x - (float)y;

        /// <summary>
        /// Adds byte to float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float Add(this float x, byte y) => x + (float)y;

        /// <summary>
        /// Divides byte from float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float DividedBy(this float x, byte y) => x / (float)y;

        /// <summary>
        /// Multiplies byte with float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float MultipliedWith(this float x, byte y) => x * (float)y;

        /// <summary>
        /// Gets the remainder of byte from float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float Modulus(this float x, byte y) => x % (float)y;

        /// <summary>
        /// Gets a boolean True if float is less than byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this float x, byte y) => x < (float)y;

        /// <summary>
        /// Gets a boolean True if float is greater than byte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this float x, byte y) => x > (float)y;

        /// <summary>
        /// Gets boolean True if byte is equal to float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this float x, byte y) => x == (float)y;

        /// <summary>
        /// Gets boolean True if byte is not equal to float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this float x, byte y) => x != (float)y;

        /// <summary>
        /// Tries to cast float to byte, this can get ugly though
        /// </summary>
        /// <param name="x">The x<see cref="float"/></param>
        /// <returns>The result of the operation</returns>
        public static byte CastFloatToByte(this float x) => (byte)x;

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static float PercentOf(this float percent, char value) => (float)(((float)percent) / ((float)100) * ((float)value));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static float AddPercent(this float value, char percent) => (float)(value + value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static float SubtractPercent(this float value, char percent) => (float)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(char) instead.", false)]
        public static float SubstractPercent(this float value, char percent) => (float)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts char from float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float Subtract(this float x, char y) => x - (float)y;

        /// <summary>
        /// Subtracts char from float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(float,char) instead.", false)]
        public static float Substract(this float x, char y) => x - (float)y;

        /// <summary>
        /// Adds char to float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float Add(this float x, char y) => x + (float)y;

        /// <summary>
        /// Divides char from float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float DividedBy(this float x, char y) => x / (float)y;

        /// <summary>
        /// Multiplies char with float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float MultipliedWith(this float x, char y) => x * (float)y;

        /// <summary>
        /// Gets the remainder of char from float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float Modulus(this float x, char y) => x % (float)y;

        /// <summary>
        /// Gets a boolean True if float is less than char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this float x, char y) => x < (float)y;

        /// <summary>
        /// Gets a boolean True if float is greater than char
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this float x, char y) => x > (float)y;

        /// <summary>
        /// Gets boolean True if char is equal to float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this float x, char y) => x == (float)y;

        /// <summary>
        /// Gets boolean True if char is not equal to float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this float x, char y) => x != (float)y;

        /// <summary>
        /// Tries to cast float to char, this can get ugly though
        /// </summary>
        /// <param name="x">The x<see cref="float"/></param>
        /// <returns>The result of the operation</returns>
        public static char CastFloatToChar(this float x) => (char)x;

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static float PercentOf(this float percent, decimal value) => (float)(((float)percent) / ((float)100) * ((float)value));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static float AddPercent(this float value, decimal percent) => (float)(value + value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static float SubtractPercent(this float value, decimal percent) => (float)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(decimal) instead.", false)]
        public static float SubstractPercent(this float value, decimal percent) => (float)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts decimal from float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float Subtract(this float x, decimal y) => x - (float)y;

        /// <summary>
        /// Subtracts decimal from float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(float,decimal) instead.", false)]
        public static float Substract(this float x, decimal y) => x - (float)y;

        /// <summary>
        /// Adds decimal to float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float Add(this float x, decimal y) => x + (float)y;

        /// <summary>
        /// Divides decimal from float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float DividedBy(this float x, decimal y) => x / (float)y;

        /// <summary>
        /// Multiplies decimal with float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float MultipliedWith(this float x, decimal y) => x * (float)y;

        /// <summary>
        /// Gets the remainder of decimal from float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float Modulus(this float x, decimal y) => x % (float)y;

        /// <summary>
        /// Gets a boolean True if float is less than decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this float x, decimal y) => x < (float)y;

        /// <summary>
        /// Gets a boolean True if float is greater than decimal
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this float x, decimal y) => x > (float)y;

        /// <summary>
        /// Gets boolean True if decimal is equal to float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this float x, decimal y) => x == (float)y;

        /// <summary>
        /// Gets boolean True if decimal is not equal to float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this float x, decimal y) => x != (float)y;

        /// <summary>
        /// Tries to cast float to decimal, this can get ugly though
        /// </summary>
        /// <param name="x">The x<see cref="float"/></param>
        /// <returns>The result of the operation</returns>
        public static decimal CastFloatToDecimal(this float x) => (decimal)x;

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static float PercentOf(this float percent, double value) => (float)(((float)percent) / ((float)100) * ((float)value));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static float AddPercent(this float value, double percent) => (float)(value + value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static float SubtractPercent(this float value, double percent) => (float)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(double) instead.", false)]
        public static float SubstractPercent(this float value, double percent) => (float)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts double from float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float Subtract(this float x, double y) => x - (float)y;

        /// <summary>
        /// Subtracts double from float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(float,double) instead.", false)]
        public static float Substract(this float x, double y) => x - (float)y;

        /// <summary>
        /// Adds double to float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float Add(this float x, double y) => x + (float)y;

        /// <summary>
        /// Divides double from float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float DividedBy(this float x, double y) => x / (float)y;

        /// <summary>
        /// Multiplies double with float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float MultipliedWith(this float x, double y) => x * (float)y;

        /// <summary>
        /// Gets the remainder of double from float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float Modulus(this float x, double y) => x % (float)y;

        /// <summary>
        /// Gets a boolean True if float is less than double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this float x, double y) => x < (float)y;

        /// <summary>
        /// Gets a boolean True if float is greater than double
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this float x, double y) => x > (float)y;

        /// <summary>
        /// Gets boolean True if double is equal to float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this float x, double y) => x == (float)y;

        /// <summary>
        /// Gets boolean True if double is not equal to float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this float x, double y) => x != (float)y;

        /// <summary>
        /// Tries to cast float to double, this can get ugly though
        /// </summary>
        /// <param name="x">The x<see cref="float"/></param>
        /// <returns>The result of the operation</returns>
        public static double CastFloatToDouble(this float x) => (double)x;

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
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static float SubtractPercent(this float value, float percent) => (float)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(float) instead.", false)]
        public static float SubstractPercent(this float value, float percent) => (float)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts float from float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float Subtract(this float x, float y) => x - y;

        /// <summary>
        /// Subtracts float from float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(float,float) instead.", false)]
        public static float Substract(this float x, float y) => x - y;

        /// <summary>
        /// Adds float to float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float Add(this float x, float y) => x + y;

        /// <summary>
        /// Divides float from float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float DividedBy(this float x, float y) => x / y;

        /// <summary>
        /// Multiplies float with float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float MultipliedWith(this float x, float y) => x * y;

        /// <summary>
        /// Gets the remainder of float from float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float Modulus(this float x, float y) => x % y;

        /// <summary>
        /// Gets a boolean True if float is less than float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this float x, float y) => x < y;

        /// <summary>
        /// Gets a boolean True if float is greater than float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this float x, float y) => x > y;

        /// <summary>
        /// Gets boolean True if float is equal to float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this float x, float y) => x == y;

        /// <summary>
        /// Gets boolean True if float is not equal to float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this float x, float y) => x != y;

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static float PercentOf(this float percent, int value) => (float)(((float)percent) / ((float)100) * ((float)value));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static float AddPercent(this float value, int percent) => (float)(value + value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static float SubtractPercent(this float value, int percent) => (float)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(int) instead.", false)]
        public static float SubstractPercent(this float value, int percent) => (float)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts int from float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float Subtract(this float x, int y) => x - (float)y;

        /// <summary>
        /// Subtracts int from float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(float,int) instead.", false)]
        public static float Substract(this float x, int y) => x - (float)y;

        /// <summary>
        /// Adds int to float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float Add(this float x, int y) => x + (float)y;

        /// <summary>
        /// Divides int from float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float DividedBy(this float x, int y) => x / (float)y;

        /// <summary>
        /// Multiplies int with float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float MultipliedWith(this float x, int y) => x * (float)y;

        /// <summary>
        /// Gets the remainder of int from float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float Modulus(this float x, int y) => x % (float)y;

        /// <summary>
        /// Gets a boolean True if float is less than int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this float x, int y) => x < (float)y;

        /// <summary>
        /// Gets a boolean True if float is greater than int
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this float x, int y) => x > (float)y;

        /// <summary>
        /// Gets boolean True if int is equal to float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this float x, int y) => x == (float)y;

        /// <summary>
        /// Gets boolean True if int is not equal to float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this float x, int y) => x != (float)y;

        /// <summary>
        /// Tries to cast float to int, this can get ugly though
        /// </summary>
        /// <param name="x">The x<see cref="float"/></param>
        /// <returns>The result of the operation</returns>
        public static int CastFloatToInt(this float x) => (int)x;

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static float PercentOf(this float percent, long value) => (float)(((float)percent) / ((float)100) * ((float)value));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static float AddPercent(this float value, long percent) => (float)(value + value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static float SubtractPercent(this float value, long percent) => (float)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(long) instead.", false)]
        public static float SubstractPercent(this float value, long percent) => (float)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts long from float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float Subtract(this float x, long y) => x - (float)y;

        /// <summary>
        /// Subtracts long from float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(float,long) instead.", false)]
        public static float Substract(this float x, long y) => x - (float)y;

        /// <summary>
        /// Adds long to float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float Add(this float x, long y) => x + (float)y;

        /// <summary>
        /// Divides long from float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float DividedBy(this float x, long y) => x / (float)y;

        /// <summary>
        /// Multiplies long with float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float MultipliedWith(this float x, long y) => x * (float)y;

        /// <summary>
        /// Gets the remainder of long from float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float Modulus(this float x, long y) => x % (float)y;

        /// <summary>
        /// Gets a boolean True if float is less than long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this float x, long y) => x < (float)y;

        /// <summary>
        /// Gets a boolean True if float is greater than long
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this float x, long y) => x > (float)y;

        /// <summary>
        /// Gets boolean True if long is equal to float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this float x, long y) => x == (float)y;

        /// <summary>
        /// Gets boolean True if long is not equal to float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this float x, long y) => x != (float)y;

        /// <summary>
        /// Tries to cast float to long, this can get ugly though
        /// </summary>
        /// <param name="x">The x<see cref="float"/></param>
        /// <returns>The result of the operation</returns>
        public static long CastFloatToLong(this float x) => (long)x;

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static float PercentOf(this float percent, sbyte value) => (float)(((float)percent) / ((float)100) * ((float)value));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static float AddPercent(this float value, sbyte percent) => (float)(value + value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static float SubtractPercent(this float value, sbyte percent) => (float)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(sbyte) instead.", false)]
        public static float SubstractPercent(this float value, sbyte percent) => (float)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts sbyte from float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float Subtract(this float x, sbyte y) => x - (float)y;

        /// <summary>
        /// Subtracts sbyte from float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(float,sbyte) instead.", false)]
        public static float Substract(this float x, sbyte y) => x - (float)y;

        /// <summary>
        /// Adds sbyte to float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float Add(this float x, sbyte y) => x + (float)y;

        /// <summary>
        /// Divides sbyte from float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float DividedBy(this float x, sbyte y) => x / (float)y;

        /// <summary>
        /// Multiplies sbyte with float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float MultipliedWith(this float x, sbyte y) => x * (float)y;

        /// <summary>
        /// Gets the remainder of sbyte from float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float Modulus(this float x, sbyte y) => x % (float)y;

        /// <summary>
        /// Gets a boolean True if float is less than sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this float x, sbyte y) => x < (float)y;

        /// <summary>
        /// Gets a boolean True if float is greater than sbyte
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this float x, sbyte y) => x > (float)y;

        /// <summary>
        /// Gets boolean true if value is less than zero
        /// </summary>
        /// <param name="x">The x<see cref="float"/></param>
        /// <returns>The result of the operation</returns>
        public static bool IsNegative(this float x) => x < 0;

        /// <summary>
        /// Gets boolean true if value is more than zero
        /// </summary>
        /// <param name="x">The x<see cref="float"/></param>
        /// <returns>The result of the operation</returns>
        public static bool IsPositive(this float x) => x >= 0;

        /// <summary>
        /// Gets boolean True if sbyte is equal to float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this float x, sbyte y) => x == (float)y;

        /// <summary>
        /// Gets boolean True if sbyte is not equal to float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this float x, sbyte y) => x != (float)y;

        /// <summary>
        /// Tries to cast float to sbyte, this can get ugly though
        /// </summary>
        /// <param name="x">The x<see cref="float"/></param>
        /// <returns>The result of the operation</returns>
        public static sbyte CastFloatToSbyte(this float x) => (sbyte)x;

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static float PercentOf(this float percent, short value) => (float)(((float)percent) / ((float)100) * ((float)value));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static float AddPercent(this float value, short percent) => (float)(value + value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static float SubtractPercent(this float value, short percent) => (float)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(short) instead.", false)]
        public static float SubstractPercent(this float value, short percent) => (float)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts short from float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float Subtract(this float x, short y) => x - (float)y;

        /// <summary>
        /// Subtracts short from float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(float,short) instead.", false)]
        public static float Substract(this float x, short y) => x - (float)y;

        /// <summary>
        /// Adds short to float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float Add(this float x, short y) => x + (float)y;

        /// <summary>
        /// Divides short from float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float DividedBy(this float x, short y) => x / (float)y;

        /// <summary>
        /// Multiplies short with float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float MultipliedWith(this float x, short y) => x * (float)y;

        /// <summary>
        /// Gets the remainder of short from float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float Modulus(this float x, short y) => x % (float)y;

        /// <summary>
        /// Gets a boolean True if float is less than short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this float x, short y) => x < (float)y;

        /// <summary>
        /// Gets a boolean True if float is greater than short
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this float x, short y) => x > (float)y;

        /// <summary>
        /// Gets boolean True if short is equal to float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this float x, short y) => x == (float)y;

        /// <summary>
        /// Gets boolean True if short is not equal to float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this float x, short y) => x != (float)y;

        /// <summary>
        /// Tries to cast float to short, this can get ugly though
        /// </summary>
        /// <param name="x">The x<see cref="float"/></param>
        /// <returns>The result of the operation</returns>
        public static short CastFloatToShort(this float x) => (short)x;

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static float PercentOf(this float percent, uint value) => (float)(((float)percent) / ((float)100) * ((float)value));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static float AddPercent(this float value, uint percent) => (float)(value + value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static float SubtractPercent(this float value, uint percent) => (float)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(uint) instead.", false)]
        public static float SubstractPercent(this float value, uint percent) => (float)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts uint from float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float Subtract(this float x, uint y) => x - (float)y;

        /// <summary>
        /// Subtracts uint from float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(float,uint) instead.", false)]
        public static float Substract(this float x, uint y) => x - (float)y;

        /// <summary>
        /// Adds uint to float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float Add(this float x, uint y) => x + (float)y;

        /// <summary>
        /// Divides uint from float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float DividedBy(this float x, uint y) => x / (float)y;

        /// <summary>
        /// Multiplies uint with float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float MultipliedWith(this float x, uint y) => x * (float)y;

        /// <summary>
        /// Gets the remainder of uint from float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float Modulus(this float x, uint y) => x % (float)y;

        /// <summary>
        /// Gets a boolean True if float is less than uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this float x, uint y) => x < (float)y;

        /// <summary>
        /// Gets a boolean True if float is greater than uint
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this float x, uint y) => x > (float)y;

        /// <summary>
        /// Gets boolean True if uint is equal to float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this float x, uint y) => x == (float)y;

        /// <summary>
        /// Gets boolean True if uint is not equal to float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this float x, uint y) => x != (float)y;

        /// <summary>
        /// Tries to cast float to uint, this can get ugly though
        /// </summary>
        /// <param name="x">The x<see cref="float"/></param>
        /// <returns>The result of the operation</returns>
        public static uint CastFloatToUint(this float x) => (uint)x;

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static float PercentOf(this float percent, ulong value) => (float)(((float)percent) / ((float)100) * ((float)value));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static float AddPercent(this float value, ulong percent) => (float)(value + value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static float SubtractPercent(this float value, ulong percent) => (float)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(ulong) instead.", false)]
        public static float SubstractPercent(this float value, ulong percent) => (float)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts ulong from float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float Subtract(this float x, ulong y) => x - (float)y;

        /// <summary>
        /// Subtracts ulong from float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(float,ulong) instead.", false)]
        public static float Substract(this float x, ulong y) => x - (float)y;

        /// <summary>
        /// Adds ulong to float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float Add(this float x, ulong y) => x + (float)y;

        /// <summary>
        /// Divides ulong from float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float DividedBy(this float x, ulong y) => x / (float)y;

        /// <summary>
        /// Multiplies ulong with float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float MultipliedWith(this float x, ulong y) => x * (float)y;

        /// <summary>
        /// Gets the remainder of ulong from float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float Modulus(this float x, ulong y) => x % (float)y;

        /// <summary>
        /// Gets a boolean True if float is less than ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this float x, ulong y) => x < (float)y;

        /// <summary>
        /// Gets a boolean True if float is greater than ulong
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this float x, ulong y) => x > (float)y;

        /// <summary>
        /// Gets boolean True if ulong is equal to float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this float x, ulong y) => x == (float)y;

        /// <summary>
        /// Gets boolean True if ulong is not equal to float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this float x, ulong y) => x != (float)y;

        /// <summary>
        /// Tries to cast float to ulong, this can get ugly though
        /// </summary>
        /// <param name="x">The x<see cref="float"/></param>
        /// <returns>The result of the operation</returns>
        public static ulong CastFloatToUlong(this float x) => (ulong)x;

        /// <summary>
        /// Gets the percent of the value
        /// </summary>
        /// <param name="percent">The amount of percent</param>
        /// <param name="value">The value</param>
        /// <returns>The percent</returns>
        public static float PercentOf(this float percent, ushort value) => (float)(((float)percent) / ((float)100) * ((float)value));

        /// <summary>
        /// Adds the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static float AddPercent(this float value, ushort percent) => (float)(value + value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        public static float SubtractPercent(this float value, ushort percent) => (float)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts the percent of the value (deprecated)
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="percent">The amount of percent</param>
        /// <returns>The result</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use SubtractPercent(ushort) instead.", false)]
        public static float SubstractPercent(this float value, ushort percent) => (float)(value - value.PercentOf(percent));

        /// <summary>
        /// Subtracts ushort from float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float Subtract(this float x, ushort y) => x - (float)y;

        /// <summary>
        /// Subtracts ushort from float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        [Obsolete("This method is deprecated and will be removed in future versions, please use Subtract(float,ushort) instead.", false)]
        public static float Substract(this float x, ushort y) => x - (float)y;

        /// <summary>
        /// Adds ushort to float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float Add(this float x, ushort y) => x + (float)y;

        /// <summary>
        /// Divides ushort from float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float DividedBy(this float x, ushort y) => x / (float)y;

        /// <summary>
        /// Multiplies ushort with float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float MultipliedWith(this float x, ushort y) => x * (float)y;

        /// <summary>
        /// Gets the remainder of ushort from float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static float Modulus(this float x, ushort y) => x % (float)y;

        /// <summary>
        /// Gets a boolean True if float is less than ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool LessThan(this float x, ushort y) => x < (float)y;

        /// <summary>
        /// Gets a boolean True if float is greater than ushort
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool GreaterThan(this float x, ushort y) => x > (float)y;

        /// <summary>
        /// Gets boolean True if ushort is equal to float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsEqualTo(this float x, ushort y) => x == (float)y;

        /// <summary>
        /// Gets boolean True if ushort is not equal to float
        /// </summary>
        /// <param name="x">The original value</param>
        /// <param name="y">The work value</param>
        /// <returns>The result of the operation</returns>
        public static bool IsNotEqualTo(this float x, ushort y) => x != (float)y;

        /// <summary>
        /// Tries to cast float to ushort, this can get ugly though
        /// </summary>
        /// <param name="x">The x<see cref="float"/></param>
        /// <returns>The result of the operation</returns>
        public static ushort CastFloatToUshort(this float x) => (ushort)x;
    }
}
