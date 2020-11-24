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
| BoseNelson_Comparable |      .NET 4.8 |      .NET 4.8 |     12 | 266.9 ms | 3.15 ms | 2.95 ms |     - |     - |     - |         - |
| BoseNelson_Branchless |      .NET 4.8 |      .NET 4.8 |     12 | 132.3 ms | 0.57 ms | 0.54 ms |     - |     - |     - |         - |
|  BestKnown_Comparable |      .NET 4.8 |      .NET 4.8 |     12 | 281.3 ms | 3.76 ms | 3.52 ms |     - |     - |     - |         - |
|  BestKnown_Branchless |      .NET 4.8 |      .NET 4.8 |     12 | 101.9 ms | 0.33 ms | 0.31 ms |     - |     - |     - |         - |
|  Insertion_Comparable |      .NET 4.8 |      .NET 4.8 |     12 | 439.0 ms | 1.25 ms | 1.10 ms |     - |     - |     - |         - |
| BoseNelson_Comparable | .NET Core 3.1 | .NET Core 3.1 |     12 | 262.8 ms | 0.78 ms | 0.69 ms |     - |     - |     - |    1336 B |
| BoseNelson_Branchless | .NET Core 3.1 | .NET Core 3.1 |     12 | 131.8 ms | 0.37 ms | 0.33 ms |     - |     - |     - |         - |
|  BestKnown_Comparable | .NET Core 3.1 | .NET Core 3.1 |     12 | 271.3 ms | 2.23 ms | 1.98 ms |     - |     - |     - |    1336 B |
|  BestKnown_Branchless | .NET Core 3.1 | .NET Core 3.1 |     12 | 101.5 ms | 0.14 ms | 0.11 ms |     - |     - |     - |         - |
|  Insertion_Comparable | .NET Core 3.1 | .NET Core 3.1 |     12 | 319.7 ms | 4.46 ms | 4.17 ms |     - |     - |     - |   16136 B |
| BoseNelson_Comparable | .NET Core 5.0 | .NET Core 5.0 |     12 | 261.7 ms | 1.13 ms | 1.00 ms |     - |     - |     - |         - |
| BoseNelson_Branchless | .NET Core 5.0 | .NET Core 5.0 |     12 | 132.1 ms | 0.69 ms | 0.64 ms |     - |     - |     - |         - |
|  BestKnown_Comparable | .NET Core 5.0 | .NET Core 5.0 |     12 | 271.9 ms | 0.76 ms | 0.71 ms |     - |     - |     - |         - |
|  BestKnown_Branchless | .NET Core 5.0 | .NET Core 5.0 |     12 | 101.8 ms | 0.24 ms | 0.20 ms |     - |     - |     - |         - |
|  Insertion_Comparable | .NET Core 5.0 | .NET Core 5.0 |     12 | 332.0 ms | 4.35 ms | 4.07 ms |     - |     - |     - |      48 B |
| BoseNelson_Comparable |    CoreRt 3.1 |    CoreRt 3.1 |     12 | 262.7 ms | 0.97 ms | 0.91 ms |     - |     - |     - |         - |
| BoseNelson_Branchless |    CoreRt 3.1 |    CoreRt 3.1 |     12 | 135.3 ms | 1.00 ms | 0.89 ms |     - |     - |     - |         - |
|  BestKnown_Comparable |    CoreRt 3.1 |    CoreRt 3.1 |     12 | 267.1 ms | 0.47 ms | 0.44 ms |     - |     - |     - |         - |
|  BestKnown_Branchless |    CoreRt 3.1 |    CoreRt 3.1 |     12 | 102.4 ms | 0.19 ms | 0.18 ms |     - |     - |     - |         - |
|  Insertion_Comparable |    CoreRt 3.1 |    CoreRt 3.1 |     12 | 326.5 ms | 6.48 ms | 8.87 ms |     - |     - |     - |         - |
