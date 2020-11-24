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
| BoseNelson_Comparable |      .NET 4.8 |      .NET 4.8 |     14 | 174.2 ms | 0.79 ms | 0.74 ms |     - |     - |     - |         - |
| BoseNelson_Branchless |      .NET 4.8 |      .NET 4.8 |     14 | 171.0 ms | 0.42 ms | 0.35 ms |     - |     - |     - |         - |
|  BestKnown_Comparable |      .NET 4.8 |      .NET 4.8 |     14 | 194.7 ms | 2.10 ms | 1.96 ms |     - |     - |     - |         - |
|  BestKnown_Branchless |      .NET 4.8 |      .NET 4.8 |     14 | 104.7 ms | 0.25 ms | 0.24 ms |     - |     - |     - |         - |
|  Insertion_Comparable |      .NET 4.8 |      .NET 4.8 |     14 | 299.4 ms | 4.03 ms | 3.77 ms |     - |     - |     - |         - |
| BoseNelson_Comparable | .NET Core 3.1 | .NET Core 3.1 |     14 | 172.0 ms | 1.07 ms | 1.00 ms |     - |     - |     - |         - |
| BoseNelson_Branchless | .NET Core 3.1 | .NET Core 3.1 |     14 | 170.9 ms | 0.28 ms | 0.23 ms |     - |     - |     - |         - |
|  BestKnown_Comparable | .NET Core 3.1 | .NET Core 3.1 |     14 | 186.4 ms | 0.83 ms | 0.78 ms |     - |     - |     - |         - |
|  BestKnown_Branchless | .NET Core 3.1 | .NET Core 3.1 |     14 | 104.6 ms | 0.18 ms | 0.15 ms |     - |     - |     - |         - |
|  Insertion_Comparable | .NET Core 3.1 | .NET Core 3.1 |     14 | 204.2 ms | 2.35 ms | 2.08 ms |     - |     - |     - |      48 B |
| BoseNelson_Comparable | .NET Core 5.0 | .NET Core 5.0 |     14 | 174.6 ms | 1.22 ms | 1.14 ms |     - |     - |     - |         - |
| BoseNelson_Branchless | .NET Core 5.0 | .NET Core 5.0 |     14 | 170.8 ms | 0.25 ms | 0.21 ms |     - |     - |     - |         - |
|  BestKnown_Comparable | .NET Core 5.0 | .NET Core 5.0 |     14 | 191.1 ms | 1.59 ms | 1.49 ms |     - |     - |     - |         - |
|  BestKnown_Branchless | .NET Core 5.0 | .NET Core 5.0 |     14 | 104.6 ms | 0.23 ms | 0.21 ms |     - |     - |     - |         - |
|  Insertion_Comparable | .NET Core 5.0 | .NET Core 5.0 |     14 | 215.3 ms | 2.13 ms | 1.99 ms |     - |     - |     - |         - |
| BoseNelson_Comparable |    CoreRt 3.1 |    CoreRt 3.1 |     14 | 171.6 ms | 0.52 ms | 0.43 ms |     - |     - |     - |         - |
| BoseNelson_Branchless |    CoreRt 3.1 |    CoreRt 3.1 |     14 | 170.8 ms | 0.39 ms | 0.35 ms |     - |     - |     - |         - |
|  BestKnown_Comparable |    CoreRt 3.1 |    CoreRt 3.1 |     14 | 188.5 ms | 0.48 ms | 0.45 ms |     - |     - |     - |         - |
|  BestKnown_Branchless |    CoreRt 3.1 |    CoreRt 3.1 |     14 | 105.1 ms | 0.90 ms | 0.84 ms |     - |     - |     - |         - |
|  Insertion_Comparable |    CoreRt 3.1 |    CoreRt 3.1 |     14 | 203.3 ms | 3.15 ms | 2.79 ms |     - |     - |     - |         - |
