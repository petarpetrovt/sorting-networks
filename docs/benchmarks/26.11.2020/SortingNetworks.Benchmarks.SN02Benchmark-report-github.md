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
|                Method |           Job |       Runtime | Length |     Count |     Mean |   Error |  StdDev | Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------- |-------------- |-------------- |------- |---------- |---------:|--------:|--------:|------:|------:|------:|----------:|
| BoseNelson_Comparable |      .NET 4.8 |      .NET 4.8 |      2 | 110000000 | 269.6 ms | 2.74 ms | 2.14 ms |     - |     - |     - |         - |
| BoseNelson_Branchless |      .NET 4.8 |      .NET 4.8 |      2 | 110000000 | 119.4 ms | 0.33 ms | 0.28 ms |     - |     - |     - |         - |
|  Insertion_Comparable |      .NET 4.8 |      .NET 4.8 |      2 | 110000000 | 494.6 ms | 2.05 ms | 1.82 ms |     - |     - |     - |         - |
| BoseNelson_Comparable | .NET Core 3.1 | .NET Core 3.1 |      2 | 110000000 | 270.2 ms | 0.86 ms | 0.81 ms |     - |     - |     - |    1384 B |
| BoseNelson_Branchless | .NET Core 3.1 | .NET Core 3.1 |      2 | 110000000 | 120.6 ms | 2.40 ms | 2.24 ms |     - |     - |     - |         - |
|  Insertion_Comparable | .NET Core 3.1 | .NET Core 3.1 |      2 | 110000000 | 439.2 ms | 1.37 ms | 1.22 ms |     - |     - |     - |    1336 B |
| BoseNelson_Comparable | .NET Core 5.0 | .NET Core 5.0 |      2 | 110000000 | 267.1 ms | 1.98 ms | 1.85 ms |     - |     - |     - |      48 B |
| BoseNelson_Branchless | .NET Core 5.0 | .NET Core 5.0 |      2 | 110000000 | 119.2 ms | 0.39 ms | 0.37 ms |     - |     - |     - |         - |
|  Insertion_Comparable | .NET Core 5.0 | .NET Core 5.0 |      2 | 110000000 | 430.8 ms | 3.51 ms | 2.93 ms |     - |     - |     - |         - |
| BoseNelson_Comparable |    CoreRt 3.1 |    CoreRt 3.1 |      2 | 110000000 | 262.8 ms | 3.38 ms | 2.82 ms |     - |     - |     - |         - |
| BoseNelson_Branchless |    CoreRt 3.1 |    CoreRt 3.1 |      2 | 110000000 | 120.2 ms | 0.54 ms | 0.45 ms |     - |     - |     - |         - |
|  Insertion_Comparable |    CoreRt 3.1 |    CoreRt 3.1 |      2 | 110000000 | 449.1 ms | 1.59 ms | 1.49 ms |     - |     - |     - |         - |
