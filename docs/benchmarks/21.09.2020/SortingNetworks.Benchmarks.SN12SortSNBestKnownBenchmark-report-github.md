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
| SN_Generic_Comparable |      .NET 4.8 |      .NET 4.8 |     12 | 402.0 ms | 4.97 ms | 4.65 ms |     - |     - |     - |         - |
|   SN_Fixed_Comparable |      .NET 4.8 |      .NET 4.8 |     12 | 391.0 ms | 3.02 ms | 2.82 ms |     - |     - |     - |         - |
|  Insertion_Comparable |      .NET 4.8 |      .NET 4.8 |     12 | 600.9 ms | 0.61 ms | 0.54 ms |     - |     - |     - |         - |
| SN_Generic_Comparable | .NET Core 3.1 | .NET Core 3.1 |     12 | 386.0 ms | 0.71 ms | 0.63 ms |     - |     - |     - |    1336 B |
|   SN_Fixed_Comparable | .NET Core 3.1 | .NET Core 3.1 |     12 | 377.4 ms | 2.62 ms | 2.45 ms |     - |     - |     - |    1336 B |
|  Insertion_Comparable | .NET Core 3.1 | .NET Core 3.1 |     12 | 459.0 ms | 7.95 ms | 7.44 ms |     - |     - |     - |         - |
| SN_Generic_Comparable |    CoreRt 3.1 |    CoreRt 3.1 |     12 | 383.3 ms | 0.72 ms | 0.56 ms |     - |     - |     - |         - |
|   SN_Fixed_Comparable |    CoreRt 3.1 |    CoreRt 3.1 |     12 | 375.3 ms | 0.67 ms | 0.59 ms |     - |     - |     - |         - |
|  Insertion_Comparable |    CoreRt 3.1 |    CoreRt 3.1 |     12 | 466.1 ms | 3.55 ms | 3.32 ms |     - |     - |     - |         - |
