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
| SN_Generic_Comparable |      .NET 4.8 |      .NET 4.8 |     21 | 648.8 ms | 4.20 ms | 3.72 ms |     - |     - |     - |         - |
|   SN_Fixed_Comparable |      .NET 4.8 |      .NET 4.8 |     21 | 640.1 ms | 7.23 ms | 6.76 ms |     - |     - |     - |         - |
|  Insertion_Comparable |      .NET 4.8 |      .NET 4.8 |     21 | 819.4 ms | 8.63 ms | 8.08 ms |     - |     - |     - |         - |
| SN_Generic_Comparable | .NET Core 3.1 | .NET Core 3.1 |     21 | 660.0 ms | 5.92 ms | 5.54 ms |     - |     - |     - |    1336 B |
|   SN_Fixed_Comparable | .NET Core 3.1 | .NET Core 3.1 |     21 | 641.0 ms | 4.88 ms | 4.57 ms |     - |     - |     - |      48 B |
|  Insertion_Comparable | .NET Core 3.1 | .NET Core 3.1 |     21 | 562.8 ms | 6.12 ms | 5.43 ms |     - |     - |     - |    1336 B |
| SN_Generic_Comparable |    CoreRt 3.1 |    CoreRt 3.1 |     21 | 642.0 ms | 2.17 ms | 2.03 ms |     - |     - |     - |         - |
|   SN_Fixed_Comparable |    CoreRt 3.1 |    CoreRt 3.1 |     21 | 637.8 ms | 2.00 ms | 1.87 ms |     - |     - |     - |         - |
|  Insertion_Comparable |    CoreRt 3.1 |    CoreRt 3.1 |     21 | 615.7 ms | 4.52 ms | 4.23 ms |     - |     - |     - |         - |
