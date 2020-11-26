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
| BoseNelson_Comparable |      .NET 4.8 |      .NET 4.8 |      5 | 90000000 | 426.2 ms | 4.10 ms | 3.83 ms |     - |     - |     - |         - |
| BoseNelson_Branchless |      .NET 4.8 |      .NET 4.8 |      5 | 90000000 | 154.9 ms | 0.70 ms | 0.62 ms |     - |     - |     - |         - |
|  Insertion_Comparable |      .NET 4.8 |      .NET 4.8 |      5 | 90000000 | 676.4 ms | 0.42 ms | 0.37 ms |     - |     - |     - |         - |
| BoseNelson_Comparable | .NET Core 3.1 | .NET Core 3.1 |      5 | 90000000 | 393.6 ms | 0.36 ms | 0.32 ms |     - |     - |     - |    1336 B |
| BoseNelson_Branchless | .NET Core 3.1 | .NET Core 3.1 |      5 | 90000000 | 171.1 ms | 0.36 ms | 0.30 ms |     - |     - |     - |         - |
|  Insertion_Comparable | .NET Core 3.1 | .NET Core 3.1 |      5 | 90000000 | 542.8 ms | 1.62 ms | 1.52 ms |     - |     - |     - |         - |
| BoseNelson_Comparable | .NET Core 5.0 | .NET Core 5.0 |      5 | 90000000 | 379.1 ms | 3.14 ms | 2.94 ms |     - |     - |     - |         - |
| BoseNelson_Branchless | .NET Core 5.0 | .NET Core 5.0 |      5 | 90000000 | 151.7 ms | 0.20 ms | 0.16 ms |     - |     - |     - |         - |
|  Insertion_Comparable | .NET Core 5.0 | .NET Core 5.0 |      5 | 90000000 | 532.1 ms | 2.26 ms | 2.01 ms |     - |     - |     - |      48 B |
| BoseNelson_Comparable |    CoreRt 3.1 |    CoreRt 3.1 |      5 | 90000000 | 377.7 ms | 3.53 ms | 3.30 ms |     - |     - |     - |         - |
| BoseNelson_Branchless |    CoreRt 3.1 |    CoreRt 3.1 |      5 | 90000000 | 152.0 ms | 0.07 ms | 0.06 ms |     - |     - |     - |         - |
|  Insertion_Comparable |    CoreRt 3.1 |    CoreRt 3.1 |      5 | 90000000 | 545.9 ms | 9.78 ms | 9.15 ms |     - |     - |     - |         - |
