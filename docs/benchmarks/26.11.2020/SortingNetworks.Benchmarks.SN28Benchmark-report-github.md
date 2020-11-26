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
|                Method |           Job |       Runtime | Length |   Count |     Mean |   Error |  StdDev | Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------- |-------------- |-------------- |------- |-------- |---------:|--------:|--------:|------:|------:|------:|----------:|
| BoseNelson_Comparable |      .NET 4.8 |      .NET 4.8 |     28 | 9000000 | 129.7 ms | 0.26 ms | 0.24 ms |     - |     - |     - |         - |
| BoseNelson_Branchless |      .NET 4.8 |      .NET 4.8 |     28 | 9000000 | 171.0 ms | 0.06 ms | 0.05 ms |     - |     - |     - |         - |
|  Insertion_Comparable |      .NET 4.8 |      .NET 4.8 |     28 | 9000000 | 167.4 ms | 0.36 ms | 0.33 ms |     - |     - |     - |         - |
| BoseNelson_Comparable | .NET Core 3.1 | .NET Core 3.1 |     28 | 9000000 | 124.0 ms | 0.15 ms | 0.13 ms |     - |     - |     - |         - |
| BoseNelson_Branchless | .NET Core 3.1 | .NET Core 3.1 |     28 | 9000000 | 170.7 ms | 0.12 ms | 0.10 ms |     - |     - |     - |         - |
|  Insertion_Comparable | .NET Core 3.1 | .NET Core 3.1 |     28 | 9000000 | 117.3 ms | 2.30 ms | 2.91 ms |     - |     - |     - |         - |
| BoseNelson_Comparable | .NET Core 5.0 | .NET Core 5.0 |     28 | 9000000 | 124.2 ms | 0.48 ms | 0.45 ms |     - |     - |     - |         - |
| BoseNelson_Branchless | .NET Core 5.0 | .NET Core 5.0 |     28 | 9000000 | 173.2 ms | 1.25 ms | 1.05 ms |     - |     - |     - |         - |
|  Insertion_Comparable | .NET Core 5.0 | .NET Core 5.0 |     28 | 9000000 | 127.6 ms | 1.44 ms | 1.34 ms |     - |     - |     - |         - |
| BoseNelson_Comparable |    CoreRt 3.1 |    CoreRt 3.1 |     28 | 9000000 | 124.7 ms | 0.30 ms | 0.27 ms |     - |     - |     - |         - |
| BoseNelson_Branchless |    CoreRt 3.1 |    CoreRt 3.1 |     28 | 9000000 | 184.1 ms | 0.36 ms | 0.32 ms |     - |     - |     - |         - |
|  Insertion_Comparable |    CoreRt 3.1 |    CoreRt 3.1 |     28 | 9000000 | 123.3 ms | 2.31 ms | 2.27 ms |     - |     - |     - |         - |
