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
| BoseNelson_Comparable |      .NET 4.8 |      .NET 4.8 |     16 | 21000000 | 190.0 ms | 1.54 ms | 1.44 ms |     - |     - |     - |         - |
| BoseNelson_Branchless |      .NET 4.8 |      .NET 4.8 |     16 | 21000000 | 184.9 ms | 0.14 ms | 0.11 ms |     - |     - |     - |         - |
|  BestKnown_Comparable |      .NET 4.8 |      .NET 4.8 |     16 | 21000000 | 202.5 ms | 1.28 ms | 1.20 ms |     - |     - |     - |         - |
|  BestKnown_Branchless |      .NET 4.8 |      .NET 4.8 |     16 | 21000000 | 146.2 ms | 0.44 ms | 0.39 ms |     - |     - |     - |         - |
|  Insertion_Comparable |      .NET 4.8 |      .NET 4.8 |     16 | 21000000 | 291.8 ms | 1.98 ms | 1.75 ms |     - |     - |     - |         - |
| BoseNelson_Comparable | .NET Core 3.1 | .NET Core 3.1 |     16 | 21000000 | 187.2 ms | 0.52 ms | 0.44 ms |     - |     - |     - |         - |
| BoseNelson_Branchless | .NET Core 3.1 | .NET Core 3.1 |     16 | 21000000 | 192.0 ms | 0.12 ms | 0.10 ms |     - |     - |     - |         - |
|  BestKnown_Comparable | .NET Core 3.1 | .NET Core 3.1 |     16 | 21000000 | 199.7 ms | 0.61 ms | 0.57 ms |     - |     - |     - |         - |
|  BestKnown_Branchless | .NET Core 3.1 | .NET Core 3.1 |     16 | 21000000 | 156.4 ms | 0.32 ms | 0.27 ms |     - |     - |     - |         - |
|  Insertion_Comparable | .NET Core 3.1 | .NET Core 3.1 |     16 | 21000000 | 215.1 ms | 1.00 ms | 0.89 ms |     - |     - |     - |         - |
| BoseNelson_Comparable | .NET Core 5.0 | .NET Core 5.0 |     16 | 21000000 | 187.3 ms | 0.50 ms | 0.47 ms |     - |     - |     - |         - |
| BoseNelson_Branchless | .NET Core 5.0 | .NET Core 5.0 |     16 | 21000000 | 192.1 ms | 0.13 ms | 0.10 ms |     - |     - |     - |         - |
|  BestKnown_Comparable | .NET Core 5.0 | .NET Core 5.0 |     16 | 21000000 | 202.0 ms | 2.36 ms | 2.21 ms |     - |     - |     - |         - |
|  BestKnown_Branchless | .NET Core 5.0 | .NET Core 5.0 |     16 | 21000000 | 156.2 ms | 0.34 ms | 0.30 ms |     - |     - |     - |         - |
|  Insertion_Comparable | .NET Core 5.0 | .NET Core 5.0 |     16 | 21000000 | 225.3 ms | 2.05 ms | 1.92 ms |     - |     - |     - |         - |
| BoseNelson_Comparable |    CoreRt 3.1 |    CoreRt 3.1 |     16 | 21000000 | 186.2 ms | 0.23 ms | 0.19 ms |     - |     - |     - |         - |
| BoseNelson_Branchless |    CoreRt 3.1 |    CoreRt 3.1 |     16 | 21000000 | 185.0 ms | 0.16 ms | 0.13 ms |     - |     - |     - |         - |
|  BestKnown_Comparable |    CoreRt 3.1 |    CoreRt 3.1 |     16 | 21000000 | 198.9 ms | 0.61 ms | 0.57 ms |     - |     - |     - |         - |
|  BestKnown_Branchless |    CoreRt 3.1 |    CoreRt 3.1 |     16 | 21000000 | 147.6 ms | 0.36 ms | 0.32 ms |     - |     - |     - |         - |
|  Insertion_Comparable |    CoreRt 3.1 |    CoreRt 3.1 |     16 | 21000000 | 219.8 ms | 4.27 ms | 5.84 ms |     - |     - |     - |         - |
