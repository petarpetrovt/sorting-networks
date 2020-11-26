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
|                Method |           Job |       Runtime | Length |    Count |     Mean |   Error |  StdDev |   Median | Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------- |-------------- |-------------- |------- |--------- |---------:|--------:|--------:|---------:|------:|------:|------:|----------:|
| BoseNelson_Comparable |      .NET 4.8 |      .NET 4.8 |     18 | 12000000 | 126.0 ms | 0.66 ms | 0.62 ms | 126.0 ms |     - |     - |     - |         - |
| BoseNelson_Branchless |      .NET 4.8 |      .NET 4.8 |     18 | 12000000 | 178.7 ms | 0.13 ms | 0.11 ms | 178.7 ms |     - |     - |     - |         - |
|  Insertion_Comparable |      .NET 4.8 |      .NET 4.8 |     18 | 12000000 | 172.6 ms | 0.20 ms | 0.17 ms | 172.5 ms |     - |     - |     - |         - |
| BoseNelson_Comparable | .NET Core 3.1 | .NET Core 3.1 |     18 | 12000000 | 121.1 ms | 0.15 ms | 0.13 ms | 121.1 ms |     - |     - |     - |         - |
| BoseNelson_Branchless | .NET Core 3.1 | .NET Core 3.1 |     18 | 12000000 | 172.1 ms | 0.60 ms | 0.56 ms | 171.8 ms |     - |     - |     - |         - |
|  Insertion_Comparable | .NET Core 3.1 | .NET Core 3.1 |     18 | 12000000 | 128.8 ms | 1.98 ms | 1.85 ms | 129.4 ms |     - |     - |     - |         - |
| BoseNelson_Comparable | .NET Core 5.0 | .NET Core 5.0 |     18 | 12000000 | 119.7 ms | 0.31 ms | 0.28 ms | 119.7 ms |     - |     - |     - |         - |
| BoseNelson_Branchless | .NET Core 5.0 | .NET Core 5.0 |     18 | 12000000 | 171.8 ms | 0.19 ms | 0.16 ms | 171.8 ms |     - |     - |     - |         - |
|  Insertion_Comparable | .NET Core 5.0 | .NET Core 5.0 |     18 | 12000000 | 129.5 ms | 2.58 ms | 6.76 ms | 125.3 ms |     - |     - |     - |         - |
| BoseNelson_Comparable |    CoreRt 3.1 |    CoreRt 3.1 |     18 | 12000000 | 121.5 ms | 0.62 ms | 0.55 ms | 121.4 ms |     - |     - |     - |         - |
| BoseNelson_Branchless |    CoreRt 3.1 |    CoreRt 3.1 |     18 | 12000000 | 179.4 ms | 0.10 ms | 0.09 ms | 179.4 ms |     - |     - |     - |         - |
|  Insertion_Comparable |    CoreRt 3.1 |    CoreRt 3.1 |     18 | 12000000 | 132.0 ms | 2.49 ms | 2.55 ms | 132.7 ms |     - |     - |     - |         - |
