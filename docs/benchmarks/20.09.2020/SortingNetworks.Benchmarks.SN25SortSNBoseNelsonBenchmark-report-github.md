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
| SN_Generic_Comparable |      .NET 4.8 |      .NET 4.8 |     25 | 722.8 ms |  1.42 ms |  1.33 ms |     - |     - |     - |         - |
|   SN_Fixed_Comparable |      .NET 4.8 |      .NET 4.8 |     25 | 723.5 ms |  1.99 ms |  1.86 ms |     - |     - |     - |         - |
|  Insertion_Comparable |      .NET 4.8 |      .NET 4.8 |     25 | 887.6 ms |  4.19 ms |  3.92 ms |     - |     - |     - |         - |
| SN_Generic_Comparable | .NET Core 3.1 | .NET Core 3.1 |     25 | 726.5 ms |  4.41 ms |  4.13 ms |     - |     - |     - |         - |
|   SN_Fixed_Comparable | .NET Core 3.1 | .NET Core 3.1 |     25 | 725.3 ms |  1.78 ms |  1.66 ms |     - |     - |     - |    1336 B |
|  Insertion_Comparable | .NET Core 3.1 | .NET Core 3.1 |     25 | 625.7 ms | 12.29 ms | 15.54 ms |     - |     - |     - |      72 B |
| SN_Generic_Comparable |    CoreRt 3.1 |    CoreRt 3.1 |     25 | 718.3 ms |  1.50 ms |  1.41 ms |     - |     - |     - |         - |
|   SN_Fixed_Comparable |    CoreRt 3.1 |    CoreRt 3.1 |     25 | 713.0 ms |  0.91 ms |  0.85 ms |     - |     - |     - |         - |
|  Insertion_Comparable |    CoreRt 3.1 |    CoreRt 3.1 |     25 | 648.5 ms |  7.26 ms |  6.44 ms |     - |     - |     - |         - |
