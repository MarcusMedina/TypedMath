# Typed Math
Sometimes when working with calculations I tend to get a touch of Dyscalculia. That is why I loved Visual Basic in the 90s. It had descriptive code, and VB.net does still have it. But I prefer to work with C#. Though I do miss some functions from time to time.
To avoid visits from the ghost of Discalcula I created this project.
At first it seemed like a pretty meaningless project, but soon I realized this could be useful. So I made it a nuget.
It's all extensions to number types. 

Instead of writing
```C#
var x = 10 * 32 + y;
```
you can write 
```C#
var x = 10.MultipliedWith(32).Add(y);
```

The package contains namespaces for the most common data types in Visual Studio.

To use the extensions use any of the namespaces
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
This project is nothing magical, actually, most of the functions are oneliners. The idea is not to create complicated functions, but to make the code easier to read. If you're a hardcore coder that love to minimize your code, this is not for you. If you don't believe me, check the code https://github.com/MarcusMedina/TypedMath

## Changes
20190524 - Added Percent, Highest, Lowest, Swap

## Examples
Here is the list of functions available for most of the types. In this example I'm using *double*
```C#
using MarcusMedinaPro.TypedMath.DoubleExtension; // Double
```
Compares the current double to a value of almost any type.

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

``
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

Add and Substract can also be done in typed form.
```C#
    // double Add(...);
    double y = 12;
    int x=14;
    var res = y.Add(x);

    // double Substract(...);
    res = y.Substract(x);
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

Cast to another type if you don't like using  var x=(int)myDouble;
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

Another nifty function is to be able to check if the current number is a prime number.
```C#
    var x = 5.IsPrime();
```

## New features added
You can get the percent, add and substract percent from a value.
```C#
    var money = 1500.5;
    var x = 15.2.PercentOf(money);

    money = money.AddPercent(20); // same as money += 20.PercentOf(money);
    money = money.SubstractPercent(20); // same as money -= 20.PercentOf(money);
```
Choose highest or lowest number. It's a as simple as it sounds.
```C#
    var value1 = 50;
    var value2 = 32;

    var x = value1.ChooseHighestValue(value2);
    var y = value2.ChooseLowestValue(value1);
```

Swap values if you'd ever need it.
```C#
    var x = 10;
    var y = 20;
    y = y.SwapWith(ref x); // x == 20, Y == 10;
```

## Source code
You can find the code at https://github.com/MarcusMedina/TypedMath

## Nuget
The nuget is available at https://www.nuget.org/packages/TypedMath/

## Collaboration
Feel free to add suggest or send a pull request to my github.

## Borrowed code
* LinQ Primenumbers, Zoran Horvat: http://www.codinghelmet.com/articles/linq-all-primes/

## Borrowed Icons
* The icon is GPL from http://www.iconarchive.com/show/ios7-icons-by-icons8/Science-Math-icon.html.

Cheers.
Marcus
