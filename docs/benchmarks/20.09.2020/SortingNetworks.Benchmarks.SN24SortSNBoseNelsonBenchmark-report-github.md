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
| SN_Generic_Comparable |      .NET 4.8 |      .NET 4.8 |     24 | 692.8 ms |  1.67 ms |  1.56 ms |     - |     - |     - |         - |
|   SN_Fixed_Comparable |      .NET 4.8 |      .NET 4.8 |     24 | 689.3 ms |  1.37 ms |  1.22 ms |     - |     - |     - |         - |
|  Insertion_Comparable |      .NET 4.8 |      .NET 4.8 |     24 | 868.4 ms |  1.82 ms |  1.61 ms |     - |     - |     - |         - |
| SN_Generic_Comparable | .NET Core 3.1 | .NET Core 3.1 |     24 | 692.6 ms |  1.70 ms |  1.59 ms |     - |     - |     - |    1856 B |
|   SN_Fixed_Comparable | .NET Core 3.1 | .NET Core 3.1 |     24 | 688.9 ms |  0.82 ms |  0.76 ms |     - |     - |     - |         - |
|  Insertion_Comparable | .NET Core 3.1 | .NET Core 3.1 |     24 | 597.7 ms | 11.59 ms | 12.40 ms |     - |     - |     - |    1480 B |
| SN_Generic_Comparable |    CoreRt 3.1 |    CoreRt 3.1 |     24 | 694.0 ms |  1.25 ms |  1.17 ms |     - |     - |     - |         - |
|   SN_Fixed_Comparable |    CoreRt 3.1 |    CoreRt 3.1 |     24 | 686.0 ms |  1.08 ms |  1.01 ms |     - |     - |     - |         - |
|  Insertion_Comparable |    CoreRt 3.1 |    CoreRt 3.1 |     24 | 644.7 ms |  6.91 ms |  6.47 ms |     - |     - |     - |         - |
