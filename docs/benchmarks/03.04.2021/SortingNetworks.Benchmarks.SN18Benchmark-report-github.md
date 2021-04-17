``` ini

BenchmarkDotNet=v0.12.1.1521-nightly, OS=Windows 10.0.19042.867 (20H2/October2020Update)
AMD Ryzen 7 3700X, 1 CPU, 16 logical and 8 physical cores
.NET SDK=6.0.100-preview.2.21155.3
  [Host]             : .NET 6.0.0 (6.0.21.15406), X64 RyuJIT
  .NET 5.0           : .NET 5.0.4 (5.0.421.11614), X64 RyuJIT
  .NET 6.0           : .NET 6.0.0 (6.0.21.15406), X64 RyuJIT
  .NET Core 3.1      : .NET Core 3.1.13 (CoreCLR 4.700.21.11102, CoreFX 4.700.21.11602), X64 RyuJIT
  .NET Framework 4.8 : .NET Framework 4.8 (4.8.4300.0), X64 RyuJIT

InvocationCount=1  UnrollFactor=1  

```
|                Method |                Job |            Runtime | Length |    Count |     Mean |   Error |  StdDev | Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------- |------------------- |------------------- |------- |--------- |---------:|--------:|--------:|------:|------:|------:|----------:|
| BoseNelson_Comparable |           .NET 5.0 |           .NET 5.0 |     18 | 12000000 | 119.6 ms | 0.14 ms | 0.12 ms |     - |     - |     - |         - |
| BoseNelson_Branchless |           .NET 5.0 |           .NET 5.0 |     18 | 12000000 | 180.5 ms | 0.31 ms | 0.26 ms |     - |     - |     - |         - |
|  Insertion_Comparable |           .NET 5.0 |           .NET 5.0 |     18 | 12000000 | 123.3 ms | 0.36 ms | 0.32 ms |     - |     - |     - |         - |
| BoseNelson_Comparable |           .NET 6.0 |           .NET 6.0 |     18 | 12000000 | 119.7 ms | 0.19 ms | 0.18 ms |     - |     - |     - |     144 B |
| BoseNelson_Branchless |           .NET 6.0 |           .NET 6.0 |     18 | 12000000 | 180.9 ms | 1.37 ms | 1.28 ms |     - |     - |     - |     144 B |
|  Insertion_Comparable |           .NET 6.0 |           .NET 6.0 |     18 | 12000000 | 136.5 ms | 2.67 ms | 3.18 ms |     - |     - |     - |     144 B |
| BoseNelson_Comparable |      .NET Core 3.1 |      .NET Core 3.1 |     18 | 12000000 | 121.6 ms | 0.13 ms | 0.10 ms |     - |     - |     - |         - |
| BoseNelson_Branchless |      .NET Core 3.1 |      .NET Core 3.1 |     18 | 12000000 | 172.7 ms | 0.10 ms | 0.08 ms |     - |     - |     - |         - |
|  Insertion_Comparable |      .NET Core 3.1 |      .NET Core 3.1 |     18 | 12000000 | 132.8 ms | 1.53 ms | 1.43 ms |     - |     - |     - |         - |
| BoseNelson_Comparable | .NET Framework 4.8 | .NET Framework 4.8 |     18 | 12000000 | 123.9 ms | 0.32 ms | 0.26 ms |     - |     - |     - |         - |
| BoseNelson_Branchless | .NET Framework 4.8 | .NET Framework 4.8 |     18 | 12000000 | 173.0 ms | 0.62 ms | 0.52 ms |     - |     - |     - |         - |
|  Insertion_Comparable | .NET Framework 4.8 | .NET Framework 4.8 |     18 | 12000000 | 172.0 ms | 0.73 ms | 0.68 ms |     - |     - |     - |         - |
| BoseNelson_Comparable |         CoreRT 6.0 |         CoreRT 6.0 |     18 | 12000000 |       NA |      NA |      NA |     - |     - |     - |         - |
| BoseNelson_Branchless |         CoreRT 6.0 |         CoreRT 6.0 |     18 | 12000000 |       NA |      NA |      NA |     - |     - |     - |         - |
|  Insertion_Comparable |         CoreRT 6.0 |         CoreRT 6.0 |     18 | 12000000 |       NA |      NA |      NA |     - |     - |     - |         - |

Benchmarks with issues:
  SN18Benchmark.BoseNelson_Comparable: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=18, Count=12000000]
  SN18Benchmark.BoseNelson_Branchless: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=18, Count=12000000]
  SN18Benchmark.Insertion_Comparable: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=18, Count=12000000]
