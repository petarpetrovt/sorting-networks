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
|                Method |           Job |       Runtime | Length |    Count |     Mean |   Error |  StdDev | Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------- |-------------- |-------------- |------- |--------- |---------:|--------:|--------:|------:|------:|------:|----------:|
| BoseNelson_Comparable |      .NET 4.8 |      .NET 4.8 |     12 | 36000000 | 264.8 ms | 2.62 ms | 2.45 ms |     - |     - |     - |         - |
| BoseNelson_Branchless |      .NET 4.8 |      .NET 4.8 |     12 | 36000000 | 142.5 ms | 0.26 ms | 0.22 ms |     - |     - |     - |         - |
|  BestKnown_Comparable |      .NET 4.8 |      .NET 4.8 |     12 | 36000000 | 282.3 ms | 1.64 ms | 1.54 ms |     - |     - |     - |         - |
|  BestKnown_Branchless |      .NET 4.8 |      .NET 4.8 |     12 | 36000000 | 104.8 ms | 0.31 ms | 0.26 ms |     - |     - |     - |         - |
|  Insertion_Comparable |      .NET 4.8 |      .NET 4.8 |     12 | 36000000 | 426.9 ms | 2.50 ms | 2.34 ms |     - |     - |     - |         - |
| BoseNelson_Comparable | .NET Core 3.1 | .NET Core 3.1 |     12 | 36000000 | 262.3 ms | 1.34 ms | 1.25 ms |     - |     - |     - |    1368 B |
| BoseNelson_Branchless | .NET Core 3.1 | .NET Core 3.1 |     12 | 36000000 | 141.9 ms | 0.50 ms | 0.44 ms |     - |     - |     - |         - |
|  BestKnown_Comparable | .NET Core 3.1 | .NET Core 3.1 |     12 | 36000000 | 269.9 ms | 0.59 ms | 0.52 ms |     - |     - |     - |    1336 B |
|  BestKnown_Branchless | .NET Core 3.1 | .NET Core 3.1 |     12 | 36000000 | 105.4 ms | 0.40 ms | 0.38 ms |     - |     - |     - |         - |
|  Insertion_Comparable | .NET Core 3.1 | .NET Core 3.1 |     12 | 36000000 | 329.7 ms | 3.24 ms | 2.87 ms |     - |     - |     - |         - |
| BoseNelson_Comparable | .NET Core 5.0 | .NET Core 5.0 |     12 | 36000000 | 263.2 ms | 0.85 ms | 0.80 ms |     - |     - |     - |      48 B |
| BoseNelson_Branchless | .NET Core 5.0 | .NET Core 5.0 |     12 | 36000000 | 142.3 ms | 0.89 ms | 0.83 ms |     - |     - |     - |         - |
|  BestKnown_Comparable | .NET Core 5.0 | .NET Core 5.0 |     12 | 36000000 | 269.4 ms | 0.26 ms | 0.21 ms |     - |     - |     - |         - |
|  BestKnown_Branchless | .NET Core 5.0 | .NET Core 5.0 |     12 | 36000000 | 105.2 ms | 0.28 ms | 0.26 ms |     - |     - |     - |         - |
|  Insertion_Comparable | .NET Core 5.0 | .NET Core 5.0 |     12 | 36000000 | 344.3 ms | 3.42 ms | 3.03 ms |     - |     - |     - |      48 B |
| BoseNelson_Comparable |    CoreRt 3.1 |    CoreRt 3.1 |     12 | 36000000 | 262.2 ms | 1.40 ms | 1.31 ms |     - |     - |     - |         - |
| BoseNelson_Branchless |    CoreRt 3.1 |    CoreRt 3.1 |     12 | 36000000 | 143.4 ms | 0.62 ms | 0.58 ms |     - |     - |     - |         - |
|  BestKnown_Comparable |    CoreRt 3.1 |    CoreRt 3.1 |     12 | 36000000 | 278.1 ms | 0.81 ms | 0.72 ms |     - |     - |     - |         - |
|  BestKnown_Branchless |    CoreRt 3.1 |    CoreRt 3.1 |     12 | 36000000 | 107.7 ms | 0.15 ms | 0.13 ms |     - |     - |     - |         - |
|  Insertion_Comparable |    CoreRt 3.1 |    CoreRt 3.1 |     12 | 36000000 | 341.1 ms | 3.88 ms | 3.63 ms |     - |     - |     - |         - |
