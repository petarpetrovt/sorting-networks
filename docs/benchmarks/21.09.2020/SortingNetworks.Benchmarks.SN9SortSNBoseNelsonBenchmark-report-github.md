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
|                Method |           Job |       Runtime | Length |     Mean |   Error |  StdDev | Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------- |-------------- |-------------- |------- |---------:|--------:|--------:|------:|------:|------:|----------:|
| SN_Generic_Comparable |      .NET 4.8 |      .NET 4.8 |      9 | 348.7 ms | 3.03 ms | 2.84 ms |     - |     - |     - |         - |
|   SN_Fixed_Comparable |      .NET 4.8 |      .NET 4.8 |      9 | 336.0 ms | 1.76 ms | 1.56 ms |     - |     - |     - |         - |
|  Insertion_Comparable |      .NET 4.8 |      .NET 4.8 |      9 | 522.6 ms | 1.71 ms | 1.60 ms |     - |     - |     - |         - |
| SN_Generic_Comparable | .NET Core 3.1 | .NET Core 3.1 |      9 | 337.8 ms | 1.34 ms | 1.25 ms |     - |     - |     - |      48 B |
|   SN_Fixed_Comparable | .NET Core 3.1 | .NET Core 3.1 |      9 | 321.7 ms | 1.31 ms | 1.22 ms |     - |     - |     - |         - |
|  Insertion_Comparable | .NET Core 3.1 | .NET Core 3.1 |      9 | 416.3 ms | 6.07 ms | 5.67 ms |     - |     - |     - |    1856 B |
| SN_Generic_Comparable |    CoreRt 3.1 |    CoreRt 3.1 |      9 | 333.3 ms | 0.99 ms | 0.93 ms |     - |     - |     - |         - |
|   SN_Fixed_Comparable |    CoreRt 3.1 |    CoreRt 3.1 |      9 | 321.5 ms | 0.70 ms | 0.66 ms |     - |     - |     - |         - |
|  Insertion_Comparable |    CoreRt 3.1 |    CoreRt 3.1 |      9 | 426.8 ms | 3.11 ms | 2.76 ms |     - |     - |     - |         - |
