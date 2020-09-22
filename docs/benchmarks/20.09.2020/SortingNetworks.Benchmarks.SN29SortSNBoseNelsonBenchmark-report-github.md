``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.508 (2004/?/20H1)
AMD Ryzen 7 3700X, 1 CPU, 16 logical and 8 physical cores
.NET Core SDK=3.1.402
  [Host]        : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT
  .NET 4.8      : .NET Framework 4.8 (4.8.4220.0), X64 RyuJIT
  .NET Core 3.1 : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT
  CoreRt 3.1    : .NET 5.0.29316.02 @BuiltBy: dlab14-DDVSOWINAGE075 @Branch: master @Commit: 40be8b7e2598b2ccb827fd90cd30c0e2d4496941, X64 AOT

InvocationCount=1  UnrollFactor=1  

```
|                Method |           Job |       Runtime | Length |     Mean |    Error |   StdDev | Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------- |-------------- |-------------- |------- |---------:|---------:|---------:|------:|------:|------:|----------:|
| SN_Generic_Comparable |      .NET 4.8 |      .NET 4.8 |     29 | 824.4 ms |  4.09 ms |  3.82 ms |     - |     - |     - |         - |
|   SN_Fixed_Comparable |      .NET 4.8 |      .NET 4.8 |     29 | 820.5 ms |  2.78 ms |  2.47 ms |     - |     - |     - |         - |
|  Insertion_Comparable |      .NET 4.8 |      .NET 4.8 |     29 | 974.2 ms |  2.15 ms |  2.01 ms |     - |     - |     - |         - |
| SN_Generic_Comparable | .NET Core 3.1 | .NET Core 3.1 |     29 | 828.6 ms |  4.95 ms |  4.63 ms |     - |     - |     - |      48 B |
|   SN_Fixed_Comparable | .NET Core 3.1 | .NET Core 3.1 |     29 | 821.8 ms |  4.76 ms |  4.45 ms |     - |     - |     - |    1336 B |
|  Insertion_Comparable | .NET Core 3.1 | .NET Core 3.1 |     29 | 656.4 ms | 12.92 ms | 17.25 ms |     - |     - |     - |         - |
| SN_Generic_Comparable |    CoreRt 3.1 |    CoreRt 3.1 |     29 | 817.0 ms |  1.09 ms |  1.02 ms |     - |     - |     - |         - |
|   SN_Fixed_Comparable |    CoreRt 3.1 |    CoreRt 3.1 |     29 | 810.7 ms |  1.33 ms |  1.25 ms |     - |     - |     - |         - |
|  Insertion_Comparable |    CoreRt 3.1 |    CoreRt 3.1 |     29 | 704.2 ms |  7.88 ms |  7.37 ms |     - |     - |     - |         - |
