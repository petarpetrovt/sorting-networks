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
| SN_Generic_Comparable |      .NET 4.8 |      .NET 4.8 |     14 | 449.4 ms | 3.50 ms | 3.27 ms |     - |     - |     - |         - |
|   SN_Fixed_Comparable |      .NET 4.8 |      .NET 4.8 |     14 | 441.6 ms | 0.97 ms | 0.86 ms |     - |     - |     - |         - |
|  Insertion_Comparable |      .NET 4.8 |      .NET 4.8 |     14 | 646.4 ms | 1.84 ms | 1.43 ms |     - |     - |     - |         - |
| SN_Generic_Comparable | .NET Core 3.1 | .NET Core 3.1 |     14 | 438.5 ms | 0.91 ms | 0.85 ms |     - |     - |     - |         - |
|   SN_Fixed_Comparable | .NET Core 3.1 | .NET Core 3.1 |     14 | 429.1 ms | 5.14 ms | 4.56 ms |     - |     - |     - |    1336 B |
|  Insertion_Comparable | .NET Core 3.1 | .NET Core 3.1 |     14 | 492.6 ms | 9.28 ms | 8.68 ms |     - |     - |     - |    1336 B |
| SN_Generic_Comparable |    CoreRt 3.1 |    CoreRt 3.1 |     14 | 446.1 ms | 5.39 ms | 5.04 ms |     - |     - |     - |         - |
|   SN_Fixed_Comparable |    CoreRt 3.1 |    CoreRt 3.1 |     14 | 432.0 ms | 0.61 ms | 0.51 ms |     - |     - |     - |         - |
|  Insertion_Comparable |    CoreRt 3.1 |    CoreRt 3.1 |     14 | 493.2 ms | 1.28 ms | 1.20 ms |     - |     - |     - |         - |
