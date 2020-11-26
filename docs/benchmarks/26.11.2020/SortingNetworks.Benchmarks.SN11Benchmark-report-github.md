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
| BoseNelson_Comparable |      .NET 4.8 |      .NET 4.8 |     11 | 43000000 | 311.6 ms | 2.80 ms | 2.48 ms |     - |     - |     - |         - |
| BoseNelson_Branchless |      .NET 4.8 |      .NET 4.8 |     11 | 43000000 | 145.8 ms | 0.47 ms | 0.41 ms |     - |     - |     - |         - |
|  BestKnown_Comparable |      .NET 4.8 |      .NET 4.8 |     11 | 43000000 | 317.7 ms | 2.68 ms | 2.51 ms |     - |     - |     - |         - |
|  BestKnown_Branchless |      .NET 4.8 |      .NET 4.8 |     11 | 43000000 | 109.5 ms | 0.27 ms | 0.24 ms |     - |     - |     - |         - |
|  Insertion_Comparable |      .NET 4.8 |      .NET 4.8 |     11 | 43000000 | 484.6 ms | 0.97 ms | 0.76 ms |     - |     - |     - |         - |
| BoseNelson_Comparable | .NET Core 3.1 | .NET Core 3.1 |     11 | 43000000 | 294.9 ms | 1.09 ms | 1.02 ms |     - |     - |     - |    1384 B |
| BoseNelson_Branchless | .NET Core 3.1 | .NET Core 3.1 |     11 | 43000000 | 145.4 ms | 1.11 ms | 0.98 ms |     - |     - |     - |         - |
|  BestKnown_Comparable | .NET Core 3.1 | .NET Core 3.1 |     11 | 43000000 | 311.9 ms | 2.66 ms | 2.22 ms |     - |     - |     - |         - |
|  BestKnown_Branchless | .NET Core 3.1 | .NET Core 3.1 |     11 | 43000000 | 109.7 ms | 0.30 ms | 0.28 ms |     - |     - |     - |         - |
|  Insertion_Comparable | .NET Core 3.1 | .NET Core 3.1 |     11 | 43000000 | 380.7 ms | 2.51 ms | 2.35 ms |     - |     - |     - |    1368 B |
| BoseNelson_Comparable | .NET Core 5.0 | .NET Core 5.0 |     11 | 43000000 | 294.1 ms | 0.50 ms | 0.47 ms |     - |     - |     - |         - |
| BoseNelson_Branchless | .NET Core 5.0 | .NET Core 5.0 |     11 | 43000000 | 145.1 ms | 0.75 ms | 0.63 ms |     - |     - |     - |         - |
|  BestKnown_Comparable | .NET Core 5.0 | .NET Core 5.0 |     11 | 43000000 | 306.2 ms | 0.80 ms | 0.75 ms |     - |     - |     - |         - |
|  BestKnown_Branchless | .NET Core 5.0 | .NET Core 5.0 |     11 | 43000000 | 109.4 ms | 0.13 ms | 0.10 ms |     - |     - |     - |         - |
|  Insertion_Comparable | .NET Core 5.0 | .NET Core 5.0 |     11 | 43000000 | 402.8 ms | 6.11 ms | 5.72 ms |     - |     - |     - |         - |
| BoseNelson_Comparable |    CoreRt 3.1 |    CoreRt 3.1 |     11 | 43000000 | 296.1 ms | 0.65 ms | 0.61 ms |     - |     - |     - |         - |
| BoseNelson_Branchless |    CoreRt 3.1 |    CoreRt 3.1 |     11 | 43000000 | 147.3 ms | 0.70 ms | 0.65 ms |     - |     - |     - |         - |
|  BestKnown_Comparable |    CoreRt 3.1 |    CoreRt 3.1 |     11 | 43000000 | 309.5 ms | 0.79 ms | 0.74 ms |     - |     - |     - |         - |
|  BestKnown_Branchless |    CoreRt 3.1 |    CoreRt 3.1 |     11 | 43000000 | 113.8 ms | 0.11 ms | 0.09 ms |     - |     - |     - |         - |
|  Insertion_Comparable |    CoreRt 3.1 |    CoreRt 3.1 |     11 | 43000000 | 390.3 ms | 2.44 ms | 2.29 ms |     - |     - |     - |         - |
