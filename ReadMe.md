# Typed Math
This is a completly meaningsless project that I created a day when I had a bit of a Visual Basic nostalgia. If there is one thing I love about Visual Basic is how the code becomes sort of a story to read.

So I decided to use words instead of operators when doing calculations. To make my calculations more readble for future use.
instead of writing
```C#
var x = 10 * 32 + y;
```
you can write 
```C#
var x = 10.MultipliedWith(32).Add(y);
```

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

This is a DLL project, use it if you want. It's published with GNU public license 3. 
If you want to try it, here's the nuget: https://www.nuget.org/packages/TypedMath

Cheers.
Marcus
