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
| BoseNelson_Comparable |      .NET 4.8 |      .NET 4.8 |     13 | 35000000 | 268.1 ms | 2.11 ms | 1.87 ms |     - |     - |     - |         - |
| BoseNelson_Branchless |      .NET 4.8 |      .NET 4.8 |     13 | 35000000 | 152.1 ms | 0.34 ms | 0.29 ms |     - |     - |     - |         - |
|  BestKnown_Comparable |      .NET 4.8 |      .NET 4.8 |     13 | 35000000 | 281.6 ms | 4.16 ms | 3.90 ms |     - |     - |     - |         - |
|  BestKnown_Branchless |      .NET 4.8 |      .NET 4.8 |     13 | 35000000 | 117.6 ms | 0.28 ms | 0.26 ms |     - |     - |     - |         - |
|  Insertion_Comparable |      .NET 4.8 |      .NET 4.8 |     13 | 35000000 | 430.6 ms | 1.77 ms | 1.48 ms |     - |     - |     - |         - |
| BoseNelson_Comparable | .NET Core 3.1 | .NET Core 3.1 |     13 | 35000000 | 258.6 ms | 0.75 ms | 0.67 ms |     - |     - |     - |      48 B |
| BoseNelson_Branchless | .NET Core 3.1 | .NET Core 3.1 |     13 | 35000000 | 151.2 ms | 0.52 ms | 0.46 ms |     - |     - |     - |         - |
|  BestKnown_Comparable | .NET Core 3.1 | .NET Core 3.1 |     13 | 35000000 | 273.3 ms | 0.84 ms | 0.79 ms |     - |     - |     - |    1336 B |
|  BestKnown_Branchless | .NET Core 3.1 | .NET Core 3.1 |     13 | 35000000 | 118.4 ms | 0.27 ms | 0.25 ms |     - |     - |     - |         - |
|  Insertion_Comparable | .NET Core 3.1 | .NET Core 3.1 |     13 | 35000000 | 330.3 ms | 3.07 ms | 2.87 ms |     - |     - |     - |         - |
| BoseNelson_Comparable | .NET Core 5.0 | .NET Core 5.0 |     13 | 35000000 | 260.8 ms | 0.84 ms | 0.79 ms |     - |     - |     - |      48 B |
| BoseNelson_Branchless | .NET Core 5.0 | .NET Core 5.0 |     13 | 35000000 | 150.9 ms | 0.51 ms | 0.45 ms |     - |     - |     - |         - |
|  BestKnown_Comparable | .NET Core 5.0 | .NET Core 5.0 |     13 | 35000000 | 277.2 ms | 2.71 ms | 2.26 ms |     - |     - |     - |         - |
|  BestKnown_Branchless | .NET Core 5.0 | .NET Core 5.0 |     13 | 35000000 | 118.1 ms | 0.23 ms | 0.21 ms |     - |     - |     - |         - |
|  Insertion_Comparable | .NET Core 5.0 | .NET Core 5.0 |     13 | 35000000 | 347.4 ms | 5.83 ms | 5.45 ms |     - |     - |     - |         - |
| BoseNelson_Comparable |    CoreRt 3.1 |    CoreRt 3.1 |     13 | 35000000 | 258.3 ms | 1.58 ms | 1.48 ms |     - |     - |     - |         - |
| BoseNelson_Branchless |    CoreRt 3.1 |    CoreRt 3.1 |     13 | 35000000 | 150.8 ms | 0.34 ms | 0.32 ms |     - |     - |     - |         - |
|  BestKnown_Comparable |    CoreRt 3.1 |    CoreRt 3.1 |     13 | 35000000 | 271.3 ms | 0.58 ms | 0.54 ms |     - |     - |     - |         - |
|  BestKnown_Branchless |    CoreRt 3.1 |    CoreRt 3.1 |     13 | 35000000 | 118.0 ms | 0.30 ms | 0.28 ms |     - |     - |     - |         - |
|  Insertion_Comparable |    CoreRt 3.1 |    CoreRt 3.1 |     13 | 35000000 | 340.8 ms | 2.60 ms | 2.31 ms |     - |     - |     - |         - |
