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
| SN_Generic_Comparable |      .NET 4.8 |      .NET 4.8 |     19 | 145.8 ms | 0.37 ms | 0.35 ms |     - |     - |     - |         - |
|   SN_Fixed_Comparable |      .NET 4.8 |      .NET 4.8 |     19 | 145.5 ms | 0.86 ms | 0.81 ms |     - |     - |     - |         - |
|  Insertion_Comparable |      .NET 4.8 |      .NET 4.8 |     19 | 195.3 ms | 0.90 ms | 0.70 ms |     - |     - |     - |         - |
| SN_Generic_Comparable | .NET Core 3.1 | .NET Core 3.1 |     19 | 137.8 ms | 0.31 ms | 0.28 ms |     - |     - |     - |         - |
|   SN_Fixed_Comparable | .NET Core 3.1 | .NET Core 3.1 |     19 | 136.8 ms | 0.45 ms | 0.42 ms |     - |     - |     - |         - |
|  Insertion_Comparable | .NET Core 3.1 | .NET Core 3.1 |     19 | 143.6 ms | 1.48 ms | 1.38 ms |     - |     - |     - |         - |
| SN_Generic_Comparable | .NET Core 5.0 | .NET Core 5.0 |     19 | 139.3 ms | 0.32 ms | 0.30 ms |     - |     - |     - |         - |
|   SN_Fixed_Comparable | .NET Core 5.0 | .NET Core 5.0 |     19 | 135.9 ms | 0.41 ms | 0.38 ms |     - |     - |     - |         - |
|  Insertion_Comparable | .NET Core 5.0 | .NET Core 5.0 |     19 | 147.9 ms | 1.44 ms | 1.28 ms |     - |     - |     - |         - |
| SN_Generic_Comparable |    CoreRt 3.1 |    CoreRt 3.1 |     19 | 138.8 ms | 0.28 ms | 0.25 ms |     - |     - |     - |         - |
|   SN_Fixed_Comparable |    CoreRt 3.1 |    CoreRt 3.1 |     19 | 137.8 ms | 0.28 ms | 0.25 ms |     - |     - |     - |         - |
|  Insertion_Comparable |    CoreRt 3.1 |    CoreRt 3.1 |     19 | 149.9 ms | 2.94 ms | 3.39 ms |     - |     - |     - |         - |
