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
| SN_Generic_Comparable |      .NET 4.8 |      .NET 4.8 |     14 | 421.6 ms |  3.17 ms |  2.96 ms |     - |     - |     - |         - |
|   SN_Fixed_Comparable |      .NET 4.8 |      .NET 4.8 |     14 | 417.3 ms |  3.94 ms |  3.68 ms |     - |     - |     - |         - |
|  Insertion_Comparable |      .NET 4.8 |      .NET 4.8 |     14 | 658.2 ms |  3.34 ms |  2.96 ms |     - |     - |     - |         - |
| SN_Generic_Comparable | .NET Core 3.1 | .NET Core 3.1 |     14 | 422.3 ms |  2.69 ms |  2.52 ms |     - |     - |     - |    1856 B |
|   SN_Fixed_Comparable | .NET Core 3.1 | .NET Core 3.1 |     14 | 414.0 ms |  3.26 ms |  3.05 ms |     - |     - |     - |         - |
|  Insertion_Comparable | .NET Core 3.1 | .NET Core 3.1 |     14 | 520.6 ms | 10.04 ms | 11.16 ms |     - |     - |     - |         - |
| SN_Generic_Comparable |    CoreRt 3.1 |    CoreRt 3.1 |     14 | 420.0 ms |  3.73 ms |  3.49 ms |     - |     - |     - |         - |
|   SN_Fixed_Comparable |    CoreRt 3.1 |    CoreRt 3.1 |     14 | 412.7 ms |  3.41 ms |  3.19 ms |     - |     - |     - |         - |
|  Insertion_Comparable |    CoreRt 3.1 |    CoreRt 3.1 |     14 | 522.9 ms |  5.15 ms |  4.82 ms |     - |     - |     - |         - |
