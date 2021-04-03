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
| BoseNelson_Comparable |           .NET 5.0 |           .NET 5.0 |      8 | 55000000 | 335.1 ms | 0.40 ms | 0.33 ms |     - |     - |     - |         - |
| BoseNelson_Branchless |           .NET 5.0 |           .NET 5.0 |      8 | 55000000 | 120.9 ms | 0.23 ms | 0.19 ms |     - |     - |     - |         - |
|  Insertion_Comparable |           .NET 5.0 |           .NET 5.0 |      8 | 55000000 | 424.5 ms | 6.34 ms | 5.93 ms |     - |     - |     - |      48 B |
| BoseNelson_Comparable |           .NET 6.0 |           .NET 6.0 |      8 | 55000000 | 335.8 ms | 2.64 ms | 2.47 ms |     - |     - |     - |     192 B |
| BoseNelson_Branchless |           .NET 6.0 |           .NET 6.0 |      8 | 55000000 | 120.6 ms | 0.12 ms | 0.10 ms |     - |     - |     - |     144 B |
|  Insertion_Comparable |           .NET 6.0 |           .NET 6.0 |      8 | 55000000 | 441.1 ms | 1.05 ms | 0.93 ms |     - |     - |     - |     192 B |
| BoseNelson_Comparable |      .NET Core 3.1 |      .NET Core 3.1 |      8 | 55000000 | 323.8 ms | 0.65 ms | 0.61 ms |     - |     - |     - |   1,856 B |
| BoseNelson_Branchless |      .NET Core 3.1 |      .NET Core 3.1 |      8 | 55000000 | 121.0 ms | 0.12 ms | 0.10 ms |     - |     - |     - |         - |
|  Insertion_Comparable |      .NET Core 3.1 |      .NET Core 3.1 |      8 | 55000000 | 442.3 ms | 4.37 ms | 4.08 ms |     - |     - |     - |   1,856 B |
| BoseNelson_Comparable | .NET Framework 4.8 | .NET Framework 4.8 |      8 | 55000000 | 350.5 ms | 2.61 ms | 2.31 ms |     - |     - |     - |         - |
| BoseNelson_Branchless | .NET Framework 4.8 | .NET Framework 4.8 |      8 | 55000000 | 120.9 ms | 0.09 ms | 0.07 ms |     - |     - |     - |         - |
|  Insertion_Comparable | .NET Framework 4.8 | .NET Framework 4.8 |      8 | 55000000 | 528.1 ms | 2.10 ms | 1.86 ms |     - |     - |     - |         - |
| BoseNelson_Comparable |         CoreRT 6.0 |         CoreRT 6.0 |      8 | 55000000 |       NA |      NA |      NA |     - |     - |     - |         - |
| BoseNelson_Branchless |         CoreRT 6.0 |         CoreRT 6.0 |      8 | 55000000 |       NA |      NA |      NA |     - |     - |     - |         - |
|  Insertion_Comparable |         CoreRT 6.0 |         CoreRT 6.0 |      8 | 55000000 |       NA |      NA |      NA |     - |     - |     - |         - |

Benchmarks with issues:
  SN08Benchmark.BoseNelson_Comparable: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=8, Count=55000000]
  SN08Benchmark.BoseNelson_Branchless: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=8, Count=55000000]
  SN08Benchmark.Insertion_Comparable: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=8, Count=55000000]
