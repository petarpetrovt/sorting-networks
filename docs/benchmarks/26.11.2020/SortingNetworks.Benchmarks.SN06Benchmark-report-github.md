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
|                Method |           Job |       Runtime | Length |    Count |     Mean |   Error |   StdDev | Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------- |-------------- |-------------- |------- |--------- |---------:|--------:|---------:|------:|------:|------:|----------:|
| BoseNelson_Comparable |      .NET 4.8 |      .NET 4.8 |      6 | 85000000 | 447.6 ms | 8.88 ms | 11.23 ms |     - |     - |     - |         - |
| BoseNelson_Branchless |      .NET 4.8 |      .NET 4.8 |      6 | 85000000 | 188.4 ms | 0.19 ms |  0.16 ms |     - |     - |     - |         - |
|  Insertion_Comparable |      .NET 4.8 |      .NET 4.8 |      6 | 85000000 | 694.1 ms | 8.16 ms |  7.63 ms |     - |     - |     - |         - |
| BoseNelson_Comparable | .NET Core 3.1 | .NET Core 3.1 |      6 | 85000000 | 416.3 ms | 1.37 ms |  1.28 ms |     - |     - |     - |      48 B |
| BoseNelson_Branchless | .NET Core 3.1 | .NET Core 3.1 |      6 | 85000000 | 188.4 ms | 0.13 ms |  0.10 ms |     - |     - |     - |         - |
|  Insertion_Comparable | .NET Core 3.1 | .NET Core 3.1 |      6 | 85000000 | 568.1 ms | 3.95 ms |  3.69 ms |     - |     - |     - |      48 B |
| BoseNelson_Comparable | .NET Core 5.0 | .NET Core 5.0 |      6 | 85000000 | 418.4 ms | 2.73 ms |  2.55 ms |     - |     - |     - |      48 B |
| BoseNelson_Branchless | .NET Core 5.0 | .NET Core 5.0 |      6 | 85000000 | 172.3 ms | 0.49 ms |  0.41 ms |     - |     - |     - |         - |
|  Insertion_Comparable | .NET Core 5.0 | .NET Core 5.0 |      6 | 85000000 | 592.4 ms | 3.67 ms |  3.44 ms |     - |     - |     - |      48 B |
| BoseNelson_Comparable |    CoreRt 3.1 |    CoreRt 3.1 |      6 | 85000000 | 411.0 ms | 1.37 ms |  1.21 ms |     - |     - |     - |         - |
| BoseNelson_Branchless |    CoreRt 3.1 |    CoreRt 3.1 |      6 | 85000000 | 167.9 ms | 0.33 ms |  0.29 ms |     - |     - |     - |         - |
|  Insertion_Comparable |    CoreRt 3.1 |    CoreRt 3.1 |      6 | 85000000 | 591.8 ms | 3.97 ms |  3.71 ms |     - |     - |     - |         - |
