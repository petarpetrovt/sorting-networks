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
| BoseNelson_Comparable |      .NET 4.8 |      .NET 4.8 |      8 | 55000000 | 347.8 ms | 2.68 ms | 2.51 ms |     - |     - |     - |         - |
| BoseNelson_Branchless |      .NET 4.8 |      .NET 4.8 |      8 | 55000000 | 120.3 ms | 0.07 ms | 0.06 ms |     - |     - |     - |         - |
|  Insertion_Comparable |      .NET 4.8 |      .NET 4.8 |      8 | 55000000 | 528.4 ms | 1.38 ms | 1.23 ms |     - |     - |     - |         - |
| BoseNelson_Comparable | .NET Core 3.1 | .NET Core 3.1 |      8 | 55000000 | 328.9 ms | 2.98 ms | 2.79 ms |     - |     - |     - |    1408 B |
| BoseNelson_Branchless | .NET Core 3.1 | .NET Core 3.1 |      8 | 55000000 | 120.4 ms | 0.10 ms | 0.09 ms |     - |     - |     - |         - |
|  Insertion_Comparable | .NET Core 3.1 | .NET Core 3.1 |      8 | 55000000 | 430.2 ms | 2.45 ms | 2.29 ms |     - |     - |     - |    1384 B |
| BoseNelson_Comparable | .NET Core 5.0 | .NET Core 5.0 |      8 | 55000000 | 335.4 ms | 0.91 ms | 0.76 ms |     - |     - |     - |      48 B |
| BoseNelson_Branchless | .NET Core 5.0 | .NET Core 5.0 |      8 | 55000000 | 120.4 ms | 0.14 ms | 0.13 ms |     - |     - |     - |         - |
|  Insertion_Comparable | .NET Core 5.0 | .NET Core 5.0 |      8 | 55000000 | 449.7 ms | 3.28 ms | 2.91 ms |     - |     - |     - |         - |
| BoseNelson_Comparable |    CoreRt 3.1 |    CoreRt 3.1 |      8 | 55000000 | 335.2 ms | 0.50 ms | 0.39 ms |     - |     - |     - |         - |
| BoseNelson_Branchless |    CoreRt 3.1 |    CoreRt 3.1 |      8 | 55000000 | 121.9 ms | 1.05 ms | 0.98 ms |     - |     - |     - |         - |
|  Insertion_Comparable |    CoreRt 3.1 |    CoreRt 3.1 |      8 | 55000000 | 452.5 ms | 7.10 ms | 6.64 ms |     - |     - |     - |         - |
