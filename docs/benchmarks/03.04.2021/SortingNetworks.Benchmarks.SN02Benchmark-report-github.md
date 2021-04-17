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
|                Method |                Job |            Runtime | Length |     Count |     Mean |   Error |  StdDev | Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------- |------------------- |------------------- |------- |---------- |---------:|--------:|--------:|------:|------:|------:|----------:|
| BoseNelson_Comparable |           .NET 5.0 |           .NET 5.0 |      2 | 110000000 | 265.2 ms | 2.42 ms | 2.27 ms |     - |     - |     - |         - |
| BoseNelson_Branchless |           .NET 5.0 |           .NET 5.0 |      2 | 110000000 | 119.5 ms | 0.54 ms | 0.51 ms |     - |     - |     - |         - |
|  Insertion_Comparable |           .NET 5.0 |           .NET 5.0 |      2 | 110000000 | 438.8 ms | 2.10 ms | 1.96 ms |     - |     - |     - |         - |
| BoseNelson_Comparable |           .NET 6.0 |           .NET 6.0 |      2 | 110000000 | 266.9 ms | 2.53 ms | 2.37 ms |     - |     - |     - |     304 B |
| BoseNelson_Branchless |           .NET 6.0 |           .NET 6.0 |      2 | 110000000 | 118.8 ms | 0.41 ms | 0.38 ms |     - |     - |     - |     144 B |
|  Insertion_Comparable |           .NET 6.0 |           .NET 6.0 |      2 | 110000000 | 440.3 ms | 1.51 ms | 1.41 ms |     - |     - |     - |     144 B |
| BoseNelson_Comparable |      .NET Core 3.1 |      .NET Core 3.1 |      2 | 110000000 | 273.0 ms | 1.74 ms | 1.63 ms |     - |     - |     - |   1,856 B |
| BoseNelson_Branchless |      .NET Core 3.1 |      .NET Core 3.1 |      2 | 110000000 | 119.7 ms | 0.62 ms | 0.58 ms |     - |     - |     - |         - |
|  Insertion_Comparable |      .NET Core 3.1 |      .NET Core 3.1 |      2 | 110000000 | 440.6 ms | 1.61 ms | 1.51 ms |     - |     - |     - |         - |
| BoseNelson_Comparable | .NET Framework 4.8 | .NET Framework 4.8 |      2 | 110000000 | 269.2 ms | 0.34 ms | 0.26 ms |     - |     - |     - |         - |
| BoseNelson_Branchless | .NET Framework 4.8 | .NET Framework 4.8 |      2 | 110000000 | 118.7 ms | 0.28 ms | 0.26 ms |     - |     - |     - |         - |
|  Insertion_Comparable | .NET Framework 4.8 | .NET Framework 4.8 |      2 | 110000000 | 481.7 ms | 1.76 ms | 1.64 ms |     - |     - |     - |         - |
| BoseNelson_Comparable |         CoreRT 6.0 |         CoreRT 6.0 |      2 | 110000000 |       NA |      NA |      NA |     - |     - |     - |         - |
| BoseNelson_Branchless |         CoreRT 6.0 |         CoreRT 6.0 |      2 | 110000000 |       NA |      NA |      NA |     - |     - |     - |         - |
|  Insertion_Comparable |         CoreRT 6.0 |         CoreRT 6.0 |      2 | 110000000 |       NA |      NA |      NA |     - |     - |     - |         - |

Benchmarks with issues:
  SN02Benchmark.BoseNelson_Comparable: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=2, Count=110000000]
  SN02Benchmark.BoseNelson_Branchless: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=2, Count=110000000]
  SN02Benchmark.Insertion_Comparable: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=2, Count=110000000]
