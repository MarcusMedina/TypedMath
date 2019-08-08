# Typed Math
Sometimes when working with calculations I tend to get a touch of Dyscalculia. That is why I loved Visual Basic in the 90s. 
It had descriptive code, and VB.net does still have it. But I prefer to work with C#. Though I do miss some functions from time to time.
To avoid visits from the ghost of Dyscalculia I created this project.
At first it seemed like a pretty meaningless project, but soon I realised this could be useful. So, I made it a NuGet.
It's all extensions to number types. 

LinQ is great and it does offer a lot of ways to make the code more readable, if you use LinQ I see no reason why you should need this package. 

Instead of writing
```C#
var x = 10 * 32 + y;
```
you can write 
```C#
var x = 10.MultipliedWith(32).Add(y);
```

The package contains namespaces for the most common data types in Visual Studio.

To use the extensions, use any of the namespaces
```C#
using MarcusMedinaPro.TypedMath.ByteExtension; // Bytes
using MarcusMedinaPro.TypedMath.CharExtension; // Char
using MarcusMedinaPro.TypedMath.DecimalExtension; // Decimal
using MarcusMedinaPro.TypedMath.DoubleExtension; // Double
using MarcusMedinaPro.TypedMath.IntExtension; // Int
using MarcusMedinaPro.TypedMath.LongExtension; // Long
using MarcusMedinaPro.TypedMath.SByteExtension; // SByte
using MarcusMedinaPro.TypedMath.ShortExtension; // Short
using MarcusMedinaPro.TypedMath.UintExtension; // Uint
using MarcusMedinaPro.TypedMath.UlongExtension; //Ulong
using MarcusMedinaPro.TypedMath.UshorttExtension; //Ushort
```
Most of the functions have automatic casting from one to another, so you can work with mixed doubles and floats and ints if you want.

## Disclaimer
This project is nothing magical most of the functions are one-liners. The idea is not to create special functions, but to make the code easier to read. If you're a hardcore coder that love to minimize your code, this is not for you. But if you feel like you want code that will be easy to read, this might help.

## Changes
* 10190603 - Added array handlers
* 20190524 - Added Percent, Highest, Lowest, Swap
* 20190526 - Renamed ChoseHighestValue/ChoseLowestValue to ChoseHighestValueOf/ChoseLowestValueOf. Added SetHighestValueOf/SetLowestValueOf. Swap uses reference now
* 20190529 - Corrected misspelling in Subtract and added Obsolete tag to the misspelled method. Renamed ChoseHighest/Lowest to ChooseIfHigher/ChooseIfLower

## Examples
Here is the list of functions available for most of the types. In this example I'm using *double*
```C#
using MarcusMedinaPro.TypedMath.DoubleExtension; // Double
```
Compares the current double to a value of almost any type. Greater than and Less than works fine, but I don't recommend using IsEqual between different types of numbers like ints and doubles. That is just silly.

```C#
    // bool GreaterThan(...);
    int x = 10;
    double y = 15.2;
    if (y.GreaterThan(x))
    { 
        // Do something
    }

    // bool LessThan(...);
    if (y.LessThan(x))
    { 
        // Do something
    }
```

Compare if the numbers are equal or not
(this can be tricky when using decimals though)
```C#
    // bool IsEqual(...);
    int x = 10;
    double y = 15.2;
    if (x.IsEqualTo(y))
    {
        // Do something
    }

    // bool IsNotEqual(...);
    if (x.IsNotEqualTo(y))
    {
        // Do something
    }

```
You could go wild and crazy and write
```C#
    if (!x.IsNotEqualTo(y))
    {
        // Do something if x is not not equal to y
        // or rather Do something if x is equal to y
    }

```
But that would make the code look weird.

Check if the value is positive or negative
```C#
    // bool IsNegative();

    double y=-2;
    if (y.IsNegative())
    {
        // Do something
    }

    // bool IsPositive();
    if (y.IsPositive())
    {
        // Do something
    }
```

Add and Subtract can also be done in typed form.
```C#
    // double Add(...);
    double y = 12;
    int x=14;
    var res = y.Add(x);

    // double Subtract(...);
    res = y.Subtract(x);
```

Divide, Multiply and Modulus are also available
```C#
    // double DividedBy(...);
    int x = 10;
    double y = 12;
    var res = y.DividedBy(x);

    // double MultipliedWith(...);
    res = y.MultipliedWith(x);

    // double Modulus(...);
    res = y.Modulus(x);
```

Cast to another type if you don't like using var x=(int)myDouble;
```C#
    double y = 13.37;
// byte CastDoubleToByte();
    var b = y.CastDoubleToByte();

// char CastDoubleToChar();
    var c = y.CastDoubleToChar();

// decimal CastDoubleToDecimal();
    var d = y.CastDoubleToDecimal();

// int CastDoubleToInt();
    var i = y.CastDoubleToInt();

// long CastDoubleToLong(...);
    var l = y.CastDoubleToLong();

// sbyte CastDoubleToSbyte(...);
    var sb = y.CastDoubleToSbyte();

// short CastDoubleToShort(...);
    var sh = y.CastDoubleToShort();

// uint CastDoubleToUint(...);
    var ui = y.CastDoubleToUint();

// ulong CastDoubleToUlong(...);
    var ul = y.CastDoubleToLong();

// ushort CastDoubleToUshort(...);
    var usr = y.CastDoubleToUshort();
```

You can also do bitwise operations And, Or, Xor, Not, Shift left and Shift right on the types that works with those operations (Int, short, sbyte etc)
```C#
    var test1 = 10.And(2);
    var test2 = 12.Or(2);
    var test3 = 14.Xor(2);
    var test4 = 16.Not();
    var test5 = 42.ShiftLeft(1);
    var test6 = 24.ShiftRight(1);
```
You can get the percent, add and Subtract percent from a value.
```C#
    var money = 1500.5;
    var x = 15.2.PercentOf(money);

    money = money.AddPercent(20); // same as money += 20.PercentOf(money);
    money = money.SubtractPercent(20); // same as money -= 20.PercentOf(money);
```
Choose highest or lowest number. It's a as simple as it sounds.
```C#
    var value1 = 50;
    var value2 = 32;

    var x = value1.ChooseIfHigher(value2);
    var y = value2.ChooseIfLower(value1);
```

Swap values if you'd ever need it.
```C#
    var x = 10;
    var y = 20;
    y.SwapWith(ref x); 
	// x == 20, Y == 10;
```
Choose highest or lowest number and set the variable. It's a as simple as it sounds.
```C#
    var x = 0;
    var y = 0;
    var value1 = 50;
    var value2 = 32;

    x.SetHighestValueOf(value1, value2);
    y.SetLowestValueOf(value1, value2);
```
Another nifty function is to be able to check if the current number is a prime number.
```C#
    var x = 5.IsPrime();
```

## New features added
This time I decided to simplify common array functions. Some of them are directly links to LinQ methods, but with a hopefully more descriptive name :)
```C#
      All you need is an array with numbers
      var arr = new double[] { 10,42,20.13,91.4,30,1,3,11,29,46};
```
If you don't want to use LinQ you can use this alternative
```C#
      var average = arr.GetAverage();
```
If you don't like using [0] or array[array.Length - 1] to get the first value and last value, or use array [(array.Length - 1) / 2] to get the value int the middle, you can use this alternatives. 
Though, in LinQ you can just use arr.Last() and with C#8 you can use arr[^1]
```C#
        var first = arr.GetFirstValue();
        var last = arr.GetLastValue(); 
        var middle = arr.GetMiddleValue();
```
Once again, if you don't want to use LinQ to get highest and lowest value, you can use this more readable alternative
```C#
        var highest = arr.GetHighestValue();
        var lowest = arr.GetLowestValue();
```
To filter out values higher/lower of given number without LinQ, use
```C#
        var higherThan = arr.GetValuesHigherThan(10);
        var lowerThan = arr.GetValuesLowerThan(10);
```
Sometimes you need to resize an array, this might help
```C#
        var newArrSize = arr.SetNewArraySize(150);
```
If you need to sort your array and don't want to use LinQ, use this
```C#
        var sortAscending = arr.SortArrayAsc();
        var sortDescending= arr.SortArrayDesc();
```
If you need to sum the array and don't want to use LinQ, use this
```C#
        var sum = arr.SumAllValues();
```
OK I admit it, I wrote this code for fun. It moves all values in the array from left to right and vice versa.
```C#
        var left = arr.RotateLeft();
        var right = arr.RotateRight();
```
If you by any reason need to convert the array from whatever numbers to int, and don't want Linq, use this.
```C#
        var ints = arr.ConvertArrayToInt();
```
If you need to increase all values in the array with a specific value, this is the one for you
```C#
        var plusVal = arr.IncreaseAllValuesWith(10);
        var minusVal = arr.DecreaseAllValuesWith(12);
```
And finally some quirky code to get the first or last half of the array, or if you need all the numbers in the middle. 
```C#
        var firsthalf = arr.GetFirstHalf();
        var MiddleValues = arr.GetMiddle();
        var lastHalf = arr.GetLastHalf();
```


## Source code
You can find the code at https://github.com/MarcusMedina/TypedMath

## NuGet
The NuGet is available at https://www.nuget.org/packages/TypedMath/

## Collaboration
Feel free to add, suggest or request a feature. If you want to help develop this NuGet, feel free to send a Pull Request.

## Borrowed code
* LinQ Prime numbers, Zoran Horvat: http://www.codinghelmet.com/articles/linq-all-primes/
* Increase/Decrease array values,  mgp (https://stackoverflow.com/users/55943/mqp ) @ https://stackoverflow.com/a/823537 

## Borrowed Icons
* The icon is GPL from http://www.iconarchive.com/show/ios7-icons-by-icons8/Science-Math-icon.html.

Cheers.
Marcus
