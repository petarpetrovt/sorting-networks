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
| SN_Generic_Comparable |      .NET 4.8 |      .NET 4.8 |     25 | 700.7 ms | 0.95 ms | 0.84 ms |     - |     - |     - |         - |
|   SN_Fixed_Comparable |      .NET 4.8 |      .NET 4.8 |     25 | 699.1 ms | 2.16 ms | 2.02 ms |     - |     - |     - |         - |
|  Insertion_Comparable |      .NET 4.8 |      .NET 4.8 |     25 | 887.2 ms | 3.82 ms | 3.38 ms |     - |     - |     - |         - |
| SN_Generic_Comparable | .NET Core 3.1 | .NET Core 3.1 |     25 | 671.3 ms | 0.91 ms | 0.81 ms |     - |     - |     - |     616 B |
|   SN_Fixed_Comparable | .NET Core 3.1 | .NET Core 3.1 |     25 | 664.4 ms | 0.54 ms | 0.48 ms |     - |     - |     - |    1448 B |
|  Insertion_Comparable | .NET Core 3.1 | .NET Core 3.1 |     25 | 614.4 ms | 9.50 ms | 9.76 ms |     - |     - |     - |    1808 B |
| SN_Generic_Comparable |    CoreRt 3.1 |    CoreRt 3.1 |     25 | 676.4 ms | 1.01 ms | 0.94 ms |     - |     - |     - |         - |
|   SN_Fixed_Comparable |    CoreRt 3.1 |    CoreRt 3.1 |     25 | 670.3 ms | 4.99 ms | 4.66 ms |     - |     - |     - |         - |
|  Insertion_Comparable |    CoreRt 3.1 |    CoreRt 3.1 |     25 | 639.3 ms | 4.93 ms | 4.61 ms |     - |     - |     - |         - |
