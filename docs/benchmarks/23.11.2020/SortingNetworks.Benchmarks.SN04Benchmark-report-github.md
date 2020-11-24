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
|                Method |           Job |       Runtime | Length |     Mean |   Error |   StdDev | Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------- |-------------- |-------------- |------- |---------:|--------:|---------:|------:|------:|------:|----------:|
| BoseNelson_Comparable |      .NET 4.8 |      .NET 4.8 |      4 | 441.1 ms | 8.71 ms | 10.70 ms |     - |     - |     - |         - |
| BoseNelson_Branchless |      .NET 4.8 |      .NET 4.8 |      4 | 119.3 ms | 0.45 ms |  0.42 ms |     - |     - |     - |         - |
|  Insertion_Comparable |      .NET 4.8 |      .NET 4.8 |      4 | 715.7 ms | 2.47 ms |  2.31 ms |     - |     - |     - |         - |
| BoseNelson_Comparable | .NET Core 3.1 | .NET Core 3.1 |      4 | 411.4 ms | 3.70 ms |  3.46 ms |     - |     - |     - |      48 B |
| BoseNelson_Branchless | .NET Core 3.1 | .NET Core 3.1 |      4 | 119.1 ms | 0.77 ms |  0.68 ms |     - |     - |     - |    1336 B |
|  Insertion_Comparable | .NET Core 3.1 | .NET Core 3.1 |      4 | 578.7 ms | 2.82 ms |  2.63 ms |     - |     - |     - |     504 B |
| BoseNelson_Comparable | .NET Core 5.0 | .NET Core 5.0 |      4 | 428.7 ms | 1.52 ms |  1.42 ms |     - |     - |     - |         - |
| BoseNelson_Branchless | .NET Core 5.0 | .NET Core 5.0 |      4 | 119.3 ms | 0.96 ms |  0.90 ms |     - |     - |     - |         - |
|  Insertion_Comparable | .NET Core 5.0 | .NET Core 5.0 |      4 | 578.0 ms | 2.81 ms |  2.63 ms |     - |     - |     - |      48 B |
| BoseNelson_Comparable |    CoreRt 3.1 |    CoreRt 3.1 |      4 | 427.0 ms | 0.92 ms |  0.86 ms |     - |     - |     - |         - |
| BoseNelson_Branchless |    CoreRt 3.1 |    CoreRt 3.1 |      4 | 118.1 ms | 1.24 ms |  1.16 ms |     - |     - |     - |         - |
|  Insertion_Comparable |    CoreRt 3.1 |    CoreRt 3.1 |      4 | 595.2 ms | 6.27 ms |  5.86 ms |     - |     - |     - |         - |
