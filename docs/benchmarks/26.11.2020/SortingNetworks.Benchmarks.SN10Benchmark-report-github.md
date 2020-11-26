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
| BoseNelson_Comparable |      .NET 4.8 |      .NET 4.8 |     10 | 45000000 | 315.4 ms | 2.99 ms | 2.80 ms |     - |     - |     - |         - |
| BoseNelson_Branchless |      .NET 4.8 |      .NET 4.8 |     10 | 45000000 | 150.0 ms | 0.24 ms | 0.21 ms |     - |     - |     - |         - |
|  BestKnown_Comparable |      .NET 4.8 |      .NET 4.8 |     10 | 45000000 | 311.1 ms | 3.97 ms | 3.71 ms |     - |     - |     - |         - |
|  BestKnown_Branchless |      .NET 4.8 |      .NET 4.8 |     10 | 45000000 | 109.6 ms | 0.35 ms | 0.31 ms |     - |     - |     - |         - |
|  Insertion_Comparable |      .NET 4.8 |      .NET 4.8 |     10 | 45000000 | 484.9 ms | 0.92 ms | 0.81 ms |     - |     - |     - |         - |
| BoseNelson_Comparable | .NET Core 3.1 | .NET Core 3.1 |     10 | 45000000 | 306.1 ms | 3.77 ms | 3.52 ms |     - |     - |     - |         - |
| BoseNelson_Branchless | .NET Core 3.1 | .NET Core 3.1 |     10 | 45000000 | 147.9 ms | 0.21 ms | 0.18 ms |     - |     - |     - |         - |
|  BestKnown_Comparable | .NET Core 3.1 | .NET Core 3.1 |     10 | 45000000 | 305.6 ms | 1.73 ms | 1.62 ms |     - |     - |     - |    1336 B |
|  BestKnown_Branchless | .NET Core 3.1 | .NET Core 3.1 |     10 | 45000000 | 109.8 ms | 0.46 ms | 0.43 ms |     - |     - |     - |         - |
|  Insertion_Comparable | .NET Core 3.1 | .NET Core 3.1 |     10 | 45000000 | 396.2 ms | 5.25 ms | 4.91 ms |     - |     - |     - |    1336 B |
| BoseNelson_Comparable | .NET Core 5.0 | .NET Core 5.0 |     10 | 45000000 | 302.8 ms | 1.57 ms | 1.47 ms |     - |     - |     - |      48 B |
| BoseNelson_Branchless | .NET Core 5.0 | .NET Core 5.0 |     10 | 45000000 | 147.9 ms | 0.19 ms | 0.17 ms |     - |     - |     - |         - |
|  BestKnown_Comparable | .NET Core 5.0 | .NET Core 5.0 |     10 | 45000000 | 307.6 ms | 2.39 ms | 2.23 ms |     - |     - |     - |      48 B |
|  BestKnown_Branchless | .NET Core 5.0 | .NET Core 5.0 |     10 | 45000000 | 111.5 ms | 0.78 ms | 0.73 ms |     - |     - |     - |         - |
|  Insertion_Comparable | .NET Core 5.0 | .NET Core 5.0 |     10 | 45000000 | 381.1 ms | 6.92 ms | 6.47 ms |     - |     - |     - |      48 B |
| BoseNelson_Comparable |    CoreRt 3.1 |    CoreRt 3.1 |     10 | 45000000 | 305.4 ms | 1.83 ms | 1.71 ms |     - |     - |     - |         - |
| BoseNelson_Branchless |    CoreRt 3.1 |    CoreRt 3.1 |     10 | 45000000 | 150.3 ms | 0.22 ms | 0.19 ms |     - |     - |     - |         - |
|  BestKnown_Comparable |    CoreRt 3.1 |    CoreRt 3.1 |     10 | 45000000 | 307.9 ms | 1.45 ms | 1.36 ms |     - |     - |     - |         - |
|  BestKnown_Branchless |    CoreRt 3.1 |    CoreRt 3.1 |     10 | 45000000 | 113.2 ms | 0.13 ms | 0.11 ms |     - |     - |     - |         - |
|  Insertion_Comparable |    CoreRt 3.1 |    CoreRt 3.1 |     10 | 45000000 | 391.6 ms | 2.99 ms | 2.80 ms |     - |     - |     - |         - |
