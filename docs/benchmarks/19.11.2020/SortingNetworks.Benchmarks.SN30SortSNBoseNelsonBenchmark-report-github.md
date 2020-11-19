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
| SN_Generic_Comparable |      .NET 4.8 |      .NET 4.8 |     30 | 136.1 ms | 1.00 ms | 0.94 ms |     - |     - |     - |         - |
|   SN_Fixed_Comparable |      .NET 4.8 |      .NET 4.8 |     30 | 137.2 ms | 0.70 ms | 0.58 ms |     - |     - |     - |         - |
|  Insertion_Comparable |      .NET 4.8 |      .NET 4.8 |     30 | 174.2 ms | 0.88 ms | 0.78 ms |     - |     - |     - |         - |
| SN_Generic_Comparable | .NET Core 3.1 | .NET Core 3.1 |     30 | 130.6 ms | 0.28 ms | 0.24 ms |     - |     - |     - |         - |
|   SN_Fixed_Comparable | .NET Core 3.1 | .NET Core 3.1 |     30 | 130.7 ms | 0.32 ms | 0.30 ms |     - |     - |     - |         - |
|  Insertion_Comparable | .NET Core 3.1 | .NET Core 3.1 |     30 | 121.9 ms | 0.33 ms | 0.31 ms |     - |     - |     - |         - |
| SN_Generic_Comparable | .NET Core 5.0 | .NET Core 5.0 |     30 | 130.2 ms | 0.47 ms | 0.44 ms |     - |     - |     - |         - |
|   SN_Fixed_Comparable | .NET Core 5.0 | .NET Core 5.0 |     30 | 129.8 ms | 0.28 ms | 0.26 ms |     - |     - |     - |         - |
|  Insertion_Comparable | .NET Core 5.0 | .NET Core 5.0 |     30 | 127.5 ms | 2.45 ms | 2.41 ms |     - |     - |     - |         - |
| SN_Generic_Comparable |    CoreRt 3.1 |    CoreRt 3.1 |     30 | 130.5 ms | 0.28 ms | 0.26 ms |     - |     - |     - |         - |
|   SN_Fixed_Comparable |    CoreRt 3.1 |    CoreRt 3.1 |     30 | 129.4 ms | 0.20 ms | 0.18 ms |     - |     - |     - |         - |
|  Insertion_Comparable |    CoreRt 3.1 |    CoreRt 3.1 |     30 | 127.4 ms | 2.26 ms | 2.42 ms |     - |     - |     - |         - |
