# Typed Math
Sometimes when working with calculations I tend to get a touch of Dyscalculia. To avoid this from happening I created this project.
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

The package contains namespaces for each of the data types in Visual Studio.

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

*This project is nothing magical, actually, most of the functions are oneliners. The idea is not to create complicated functions, but to make the code easier to read. If you're a hardcore coder that love to minimize your code, this is not for you :)*

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
    int x=10;
    double y=15.2;
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
    int x=10;
    double y=15.2;
    if (x.IsEqual(y))
    { 
        // Do something
    }

    // bool IsNotEqual(...);
    if (x.IsNotEqual(y))
    { 
        // Do something
    }

```
You could go wild and crazy and write
```C#
    if (!x.IsNotEqual(y))
    { 
        // Do something
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
    if (y.Positive())
    { 
        // Do something
    }
```

Add and Substract can also be done in typed form.
```C#
    // double Add(...);
    double y = 12;
    int x=14;
    var res = y.add(x);

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
    // byte CastDoubleToByte();
    double y = 13.37;
    var b= y.CastDoubleToByte()

    // char CastDoubleToChar();
    var c = y.CastDoubleToChar();

    // decimal CastDoubleToDecimal();
    var d = y.CastDoubleToDecimal()    

    // int CastDoubleToInt();
    var i = y.CastDoubleToInt();

    // long CastDoubleToLong(...);
    var l  = y.CastDoubleToLong();

    // sbyte CastDoubleToSbyte(...);
    var sb = y.CastDoubleToSbyte(); 

    // short CastDoubleToShort(...);
    var sh= y.CastDoubleToShort()
    
    // uint CastDoubleToUint(...);
    var ui = y.CastDoubleToUint();
    
    // ulong CastDoubleToUlong(...);
    var ul = y.CastDoubleToLong();

    // ushort CastDoubleToUshort(...);
    var usr = y.CastDoubleToUShort();
```

You can also do bitwise operations And, Or, Xor, Not, Shift left and Shift right on the types that works with those operations (Int, short, sbyte etc)
```C#
    var test1 = 10.And(2);
    var test2 = 12.Or(2);
    var test3 = 14.Xor(2);
    var test4 = 16.Not();
    var test5 = 42.ShiftLeft();
    var test6 = 24.ShiftRight();
```

Another nifty function is to be able to check if the current number is a prime number.
```C#
var x = 5.IsPrime();
```

## New features added
You can get the percent, add and substract percent from a value.
```C#
var money = 1500;
var x = 15.PercentOf(mmoney);

money = money.AddPercent(20); // same as Money +=20.PercentOf(Money)
money = money.SubstractPercent(20); // same as Money -=20.PercentOf(Money)

```
Choose highest or lowest number. It's a as simple as it sounds.
```C#
var x = ChooseHighestValue (value1, value2);
var y = ChooseLowestValue (value1, value2);
```

Swap values if you'd ever need it.
```C#
var x = 10;
var y = 20;
var y = Swap(ref x);
```

## Source code
You can find the code at https://github.com/MarcusMedina/TypedMath

## Nuget
The nuget is available at https://www.nuget.org/packages/TypedMath/

## Collaboration
Feel free to add suggest or send a pull request to my github.

## Borrowed code
* IsPrime() : http://www.codinghelmet.com/articles/linq-all-primes/

## Thanks
* The icon is GPL from http://www.iconarchive.com/show/ios7-icons-by-icons8/Science-Math-icon.html.

Cheers.
Marcus
