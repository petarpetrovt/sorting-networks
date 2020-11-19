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
| SN_Generic_Comparable |      .NET 4.8 |      .NET 4.8 |     16 | 128.1 ms | 0.80 ms | 0.75 ms |     - |     - |     - |         - |
|   SN_Fixed_Comparable |      .NET 4.8 |      .NET 4.8 |     16 | 126.3 ms | 0.31 ms | 0.26 ms |     - |     - |     - |         - |
|  Insertion_Comparable |      .NET 4.8 |      .NET 4.8 |     16 | 181.9 ms | 2.97 ms | 2.78 ms |     - |     - |     - |         - |
| SN_Generic_Comparable | .NET Core 3.1 | .NET Core 3.1 |     16 | 126.4 ms | 0.39 ms | 0.36 ms |     - |     - |     - |         - |
|   SN_Fixed_Comparable | .NET Core 3.1 | .NET Core 3.1 |     16 | 127.1 ms | 0.27 ms | 0.24 ms |     - |     - |     - |         - |
|  Insertion_Comparable | .NET Core 3.1 | .NET Core 3.1 |     16 | 133.4 ms | 1.20 ms | 1.13 ms |     - |     - |     - |         - |
| SN_Generic_Comparable | .NET Core 5.0 | .NET Core 5.0 |     16 | 126.5 ms | 0.21 ms | 0.18 ms |     - |     - |     - |         - |
|   SN_Fixed_Comparable | .NET Core 5.0 | .NET Core 5.0 |     16 | 125.5 ms | 0.52 ms | 0.48 ms |     - |     - |     - |         - |
|  Insertion_Comparable | .NET Core 5.0 | .NET Core 5.0 |     16 | 139.6 ms | 2.04 ms | 1.91 ms |     - |     - |     - |         - |
| SN_Generic_Comparable |    CoreRt 3.1 |    CoreRt 3.1 |     16 | 126.3 ms | 0.38 ms | 0.35 ms |     - |     - |     - |         - |
|   SN_Fixed_Comparable |    CoreRt 3.1 |    CoreRt 3.1 |     16 | 124.9 ms | 0.12 ms | 0.10 ms |     - |     - |     - |         - |
|  Insertion_Comparable |    CoreRt 3.1 |    CoreRt 3.1 |     16 | 140.4 ms | 1.81 ms | 1.69 ms |     - |     - |     - |         - |
