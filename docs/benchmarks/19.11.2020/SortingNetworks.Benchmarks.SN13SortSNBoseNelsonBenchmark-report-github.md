``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
AMD Ryzen 7 3700X, 1 CPU, 16 logical and 8 physical cores
.NET Core SDK=5.0.100
  [Host]        : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT
  .NET 4.8      : .NET Framework 4.8 (4.8.4250.0), X64 RyuJIT
  .NET Core 3.1 : .NET Core 3.1.10 (CoreCLR 4.700.20.51601, CoreFX 4.700.20.51901), X64 RyuJIT
  .NET Core 5.0 : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT
  CoreRt 3.1    : .NET 5.0.29408.02 @BuiltBy: dlab14-DDVSOWINAGE075 @Branch: master @Commit: 4ce1c21ac0d4d1a3b7f7a548214966f69ac9f199, X64 AOT

InvocationCount=1  UnrollFactor=1  

```
|                Method |           Job |       Runtime | Length |     Mean |   Error |  StdDev | Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------- |-------------- |-------------- |------- |---------:|--------:|--------:|------:|------:|------:|----------:|
| SN_Generic_Comparable |      .NET 4.8 |      .NET 4.8 |     13 | 115.7 ms | 1.16 ms | 1.08 ms |     - |     - |     - |         - |
|   SN_Fixed_Comparable |      .NET 4.8 |      .NET 4.8 |     13 | 115.5 ms | 0.50 ms | 0.46 ms |     - |     - |     - |         - |
|  Insertion_Comparable |      .NET 4.8 |      .NET 4.8 |     13 | 184.0 ms | 0.54 ms | 0.48 ms |     - |     - |     - |         - |
| SN_Generic_Comparable | .NET Core 3.1 | .NET Core 3.1 |     13 | 113.7 ms | 0.56 ms | 0.52 ms |     - |     - |     - |         - |
|   SN_Fixed_Comparable | .NET Core 3.1 | .NET Core 3.1 |     13 | 113.0 ms | 0.84 ms | 0.78 ms |     - |     - |     - |         - |
|  Insertion_Comparable | .NET Core 3.1 | .NET Core 3.1 |     13 | 143.7 ms | 1.40 ms | 1.31 ms |     - |     - |     - |         - |
| SN_Generic_Comparable | .NET Core 5.0 | .NET Core 5.0 |     13 | 113.5 ms | 0.33 ms | 0.31 ms |     - |     - |     - |         - |
|   SN_Fixed_Comparable | .NET Core 5.0 | .NET Core 5.0 |     13 | 112.9 ms | 0.48 ms | 0.45 ms |     - |     - |     - |         - |
|  Insertion_Comparable | .NET Core 5.0 | .NET Core 5.0 |     13 | 148.0 ms | 2.11 ms | 1.98 ms |     - |     - |     - |         - |
| SN_Generic_Comparable |    CoreRt 3.1 |    CoreRt 3.1 |     13 | 115.0 ms | 0.28 ms | 0.23 ms |     - |     - |     - |         - |
|   SN_Fixed_Comparable |    CoreRt 3.1 |    CoreRt 3.1 |     13 | 112.3 ms | 0.29 ms | 0.26 ms |     - |     - |     - |         - |
|  Insertion_Comparable |    CoreRt 3.1 |    CoreRt 3.1 |     13 | 143.8 ms | 2.72 ms | 2.67 ms |     - |     - |     - |         - |
