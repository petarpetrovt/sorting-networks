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
|                Method |           Job |       Runtime | Length |   Count |     Mean |   Error |  StdDev |   Median | Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------- |-------------- |-------------- |------- |-------- |---------:|--------:|--------:|---------:|------:|------:|------:|----------:|
| BoseNelson_Comparable |      .NET 4.8 |      .NET 4.8 |     26 | 9000000 | 128.1 ms | 0.16 ms | 0.13 ms | 128.1 ms |     - |     - |     - |         - |
| BoseNelson_Branchless |      .NET 4.8 |      .NET 4.8 |     26 | 9000000 | 249.5 ms | 0.45 ms | 0.38 ms | 249.4 ms |     - |     - |     - |         - |
|  Insertion_Comparable |      .NET 4.8 |      .NET 4.8 |     26 | 9000000 | 161.9 ms | 1.86 ms | 1.65 ms | 162.5 ms |     - |     - |     - |         - |
| BoseNelson_Comparable | .NET Core 3.1 | .NET Core 3.1 |     26 | 9000000 | 122.7 ms | 0.24 ms | 0.20 ms | 122.7 ms |     - |     - |     - |         - |
| BoseNelson_Branchless | .NET Core 3.1 | .NET Core 3.1 |     26 | 9000000 | 247.0 ms | 0.73 ms | 0.68 ms | 246.8 ms |     - |     - |     - |    1336 B |
|  Insertion_Comparable | .NET Core 3.1 | .NET Core 3.1 |     26 | 9000000 | 114.4 ms | 2.28 ms | 2.80 ms | 115.9 ms |     - |     - |     - |         - |
| BoseNelson_Comparable | .NET Core 5.0 | .NET Core 5.0 |     26 | 9000000 | 121.7 ms | 0.22 ms | 0.19 ms | 121.7 ms |     - |     - |     - |         - |
| BoseNelson_Branchless | .NET Core 5.0 | .NET Core 5.0 |     26 | 9000000 | 241.2 ms | 0.82 ms | 0.73 ms | 240.9 ms |     - |     - |     - |      48 B |
|  Insertion_Comparable | .NET Core 5.0 | .NET Core 5.0 |     26 | 9000000 | 120.9 ms | 2.36 ms | 2.62 ms | 121.6 ms |     - |     - |     - |         - |
| BoseNelson_Comparable |    CoreRt 3.1 |    CoreRt 3.1 |     26 | 9000000 | 123.0 ms | 0.11 ms | 0.10 ms | 123.0 ms |     - |     - |     - |         - |
| BoseNelson_Branchless |    CoreRt 3.1 |    CoreRt 3.1 |     26 | 9000000 | 204.0 ms | 0.53 ms | 0.47 ms | 203.9 ms |     - |     - |     - |         - |
|  Insertion_Comparable |    CoreRt 3.1 |    CoreRt 3.1 |     26 | 9000000 | 116.9 ms | 2.29 ms | 3.95 ms | 119.0 ms |     - |     - |     - |         - |
