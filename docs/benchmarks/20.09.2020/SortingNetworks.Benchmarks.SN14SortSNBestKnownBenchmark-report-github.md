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
| SN_Generic_Comparable |      .NET 4.8 |      .NET 4.8 |     14 | 460.4 ms | 1.75 ms | 1.64 ms |     - |     - |     - |         - |
|   SN_Fixed_Comparable |      .NET 4.8 |      .NET 4.8 |     14 | 445.2 ms | 1.50 ms | 1.40 ms |     - |     - |     - |         - |
|  Insertion_Comparable |      .NET 4.8 |      .NET 4.8 |     14 | 647.2 ms | 1.73 ms | 1.62 ms |     - |     - |     - |         - |
| SN_Generic_Comparable | .NET Core 3.1 | .NET Core 3.1 |     14 | 453.9 ms | 1.93 ms | 1.71 ms |     - |     - |     - |    1336 B |
|   SN_Fixed_Comparable | .NET Core 3.1 | .NET Core 3.1 |     14 | 443.6 ms | 1.83 ms | 1.71 ms |     - |     - |     - |         - |
|  Insertion_Comparable | .NET Core 3.1 | .NET Core 3.1 |     14 | 494.1 ms | 9.43 ms | 8.82 ms |     - |     - |     - |         - |
| SN_Generic_Comparable |    CoreRt 3.1 |    CoreRt 3.1 |     14 | 447.4 ms | 1.47 ms | 1.30 ms |     - |     - |     - |         - |
|   SN_Fixed_Comparable |    CoreRt 3.1 |    CoreRt 3.1 |     14 | 439.3 ms | 1.71 ms | 1.60 ms |     - |     - |     - |         - |
|  Insertion_Comparable |    CoreRt 3.1 |    CoreRt 3.1 |     14 | 518.5 ms | 2.67 ms | 2.08 ms |     - |     - |     - |         - |
