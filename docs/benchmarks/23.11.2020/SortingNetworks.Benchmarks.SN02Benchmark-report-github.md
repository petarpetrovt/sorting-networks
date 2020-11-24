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
| BoseNelson_Comparable |      .NET 4.8 |      .NET 4.8 |      2 | 268.3 ms | 2.03 ms | 1.90 ms |     - |     - |     - |         - |
| BoseNelson_Branchless |      .NET 4.8 |      .NET 4.8 |      2 | 121.0 ms | 0.89 ms | 0.79 ms |     - |     - |     - |         - |
|  Insertion_Comparable |      .NET 4.8 |      .NET 4.8 |      2 | 494.5 ms | 1.60 ms | 1.50 ms |     - |     - |     - |         - |
| BoseNelson_Comparable | .NET Core 3.1 | .NET Core 3.1 |      2 | 267.6 ms | 3.45 ms | 3.23 ms |     - |     - |     - |    1336 B |
| BoseNelson_Branchless | .NET Core 3.1 | .NET Core 3.1 |      2 | 124.1 ms | 0.55 ms | 0.49 ms |     - |     - |     - |    1336 B |
|  Insertion_Comparable | .NET Core 3.1 | .NET Core 3.1 |      2 | 442.8 ms | 1.87 ms | 1.46 ms |     - |     - |     - |    1336 B |
| BoseNelson_Comparable | .NET Core 5.0 | .NET Core 5.0 |      2 | 277.5 ms | 2.02 ms | 1.89 ms |     - |     - |     - |      48 B |
| BoseNelson_Branchless | .NET Core 5.0 | .NET Core 5.0 |      2 | 124.3 ms | 0.90 ms | 0.84 ms |     - |     - |     - |         - |
|  Insertion_Comparable | .NET Core 5.0 | .NET Core 5.0 |      2 | 443.1 ms | 3.45 ms | 3.23 ms |     - |     - |     - |         - |
| BoseNelson_Comparable |    CoreRt 3.1 |    CoreRt 3.1 |      2 | 267.5 ms | 1.53 ms | 1.36 ms |     - |     - |     - |         - |
| BoseNelson_Branchless |    CoreRt 3.1 |    CoreRt 3.1 |      2 | 126.7 ms | 1.59 ms | 1.49 ms |     - |     - |     - |         - |
|  Insertion_Comparable |    CoreRt 3.1 |    CoreRt 3.1 |      2 | 436.6 ms | 2.09 ms | 1.95 ms |     - |     - |     - |         - |
