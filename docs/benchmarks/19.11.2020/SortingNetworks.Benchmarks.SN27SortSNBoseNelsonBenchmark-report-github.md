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
| SN_Generic_Comparable |      .NET 4.8 |      .NET 4.8 |     27 | 131.8 ms | 0.40 ms | 0.37 ms |     - |     - |     - |         - |
|   SN_Fixed_Comparable |      .NET 4.8 |      .NET 4.8 |     27 | 130.2 ms | 0.44 ms | 0.39 ms |     - |     - |     - |         - |
|  Insertion_Comparable |      .NET 4.8 |      .NET 4.8 |     27 | 162.9 ms | 0.38 ms | 0.34 ms |     - |     - |     - |         - |
| SN_Generic_Comparable | .NET Core 3.1 | .NET Core 3.1 |     27 | 125.6 ms | 0.22 ms | 0.18 ms |     - |     - |     - |         - |
|   SN_Fixed_Comparable | .NET Core 3.1 | .NET Core 3.1 |     27 | 125.2 ms | 0.16 ms | 0.12 ms |     - |     - |     - |         - |
|  Insertion_Comparable | .NET Core 3.1 | .NET Core 3.1 |     27 | 117.4 ms | 2.32 ms | 2.48 ms |     - |     - |     - |         - |
| SN_Generic_Comparable | .NET Core 5.0 | .NET Core 5.0 |     27 | 126.6 ms | 1.21 ms | 1.14 ms |     - |     - |     - |         - |
|   SN_Fixed_Comparable | .NET Core 5.0 | .NET Core 5.0 |     27 | 124.4 ms | 0.25 ms | 0.23 ms |     - |     - |     - |         - |
|  Insertion_Comparable | .NET Core 5.0 | .NET Core 5.0 |     27 | 122.3 ms | 1.91 ms | 1.79 ms |     - |     - |     - |         - |
| SN_Generic_Comparable |    CoreRt 3.1 |    CoreRt 3.1 |     27 | 125.0 ms | 0.20 ms | 0.18 ms |     - |     - |     - |         - |
|   SN_Fixed_Comparable |    CoreRt 3.1 |    CoreRt 3.1 |     27 | 124.3 ms | 0.15 ms | 0.13 ms |     - |     - |     - |         - |
|  Insertion_Comparable |    CoreRt 3.1 |    CoreRt 3.1 |     27 | 121.5 ms | 2.43 ms | 3.85 ms |     - |     - |     - |         - |
