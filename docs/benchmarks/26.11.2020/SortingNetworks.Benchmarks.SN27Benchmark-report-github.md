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
|                Method |           Job |       Runtime | Length |   Count |     Mean |   Error |  StdDev |   Median | Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------- |-------------- |-------------- |------- |-------- |---------:|--------:|--------:|---------:|------:|------:|------:|----------:|
| BoseNelson_Comparable |      .NET 4.8 |      .NET 4.8 |     27 | 9000000 | 131.8 ms | 0.38 ms | 0.36 ms | 131.7 ms |     - |     - |     - |         - |
| BoseNelson_Branchless |      .NET 4.8 |      .NET 4.8 |     27 | 9000000 | 239.4 ms | 0.47 ms | 0.42 ms | 239.6 ms |     - |     - |     - |         - |
|  Insertion_Comparable |      .NET 4.8 |      .NET 4.8 |     27 | 9000000 | 163.6 ms | 0.27 ms | 0.24 ms | 163.6 ms |     - |     - |     - |         - |
| BoseNelson_Comparable | .NET Core 3.1 | .NET Core 3.1 |     27 | 9000000 | 124.3 ms | 0.17 ms | 0.14 ms | 124.2 ms |     - |     - |     - |         - |
| BoseNelson_Branchless | .NET Core 3.1 | .NET Core 3.1 |     27 | 9000000 | 244.8 ms | 0.35 ms | 0.29 ms | 244.8 ms |     - |     - |     - |    1384 B |
|  Insertion_Comparable | .NET Core 3.1 | .NET Core 3.1 |     27 | 9000000 | 116.3 ms | 2.28 ms | 3.05 ms | 118.5 ms |     - |     - |     - |         - |
| BoseNelson_Comparable | .NET Core 5.0 | .NET Core 5.0 |     27 | 9000000 | 123.8 ms | 0.14 ms | 0.12 ms | 123.8 ms |     - |     - |     - |         - |
| BoseNelson_Branchless | .NET Core 5.0 | .NET Core 5.0 |     27 | 9000000 | 246.8 ms | 0.79 ms | 0.74 ms | 246.5 ms |     - |     - |     - |      48 B |
|  Insertion_Comparable | .NET Core 5.0 | .NET Core 5.0 |     27 | 9000000 | 111.9 ms | 1.86 ms | 1.74 ms | 110.9 ms |     - |     - |     - |         - |
| BoseNelson_Comparable |    CoreRt 3.1 |    CoreRt 3.1 |     27 | 9000000 | 124.4 ms | 1.46 ms | 1.36 ms | 124.9 ms |     - |     - |     - |         - |
| BoseNelson_Branchless |    CoreRt 3.1 |    CoreRt 3.1 |     27 | 9000000 | 200.9 ms | 0.58 ms | 0.49 ms | 200.9 ms |     - |     - |     - |         - |
|  Insertion_Comparable |    CoreRt 3.1 |    CoreRt 3.1 |     27 | 9000000 | 120.4 ms | 2.39 ms | 3.58 ms | 121.9 ms |     - |     - |     - |         - |
