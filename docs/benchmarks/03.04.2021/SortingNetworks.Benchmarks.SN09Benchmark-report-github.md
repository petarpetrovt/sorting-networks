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
| BoseNelson_Comparable |           .NET 5.0 |           .NET 5.0 |      9 | 50000000 | 317.1 ms | 0.80 ms | 0.75 ms |     - |     - |     - |      48 B |
| BoseNelson_Branchless |           .NET 5.0 |           .NET 5.0 |      9 | 50000000 | 141.0 ms | 0.35 ms | 0.31 ms |     - |     - |     - |         - |
|  BestKnown_Comparable |           .NET 5.0 |           .NET 5.0 |      9 | 50000000 | 317.9 ms | 2.25 ms | 2.10 ms |     - |     - |     - |         - |
|  BestKnown_Branchless |           .NET 5.0 |           .NET 5.0 |      9 | 50000000 | 115.7 ms | 0.50 ms | 0.47 ms |     - |     - |     - |         - |
|  Insertion_Comparable |           .NET 5.0 |           .NET 5.0 |      9 | 50000000 | 403.7 ms | 6.72 ms | 6.29 ms |     - |     - |     - |      48 B |
| BoseNelson_Comparable |           .NET 6.0 |           .NET 6.0 |      9 | 50000000 | 319.3 ms | 0.75 ms | 0.66 ms |     - |     - |     - |     144 B |
| BoseNelson_Branchless |           .NET 6.0 |           .NET 6.0 |      9 | 50000000 | 141.0 ms | 0.29 ms | 0.27 ms |     - |     - |     - |     144 B |
|  BestKnown_Comparable |           .NET 6.0 |           .NET 6.0 |      9 | 50000000 | 318.8 ms | 1.13 ms | 0.88 ms |     - |     - |     - |     192 B |
|  BestKnown_Branchless |           .NET 6.0 |           .NET 6.0 |      9 | 50000000 | 115.6 ms | 0.50 ms | 0.47 ms |     - |     - |     - |     144 B |
|  Insertion_Comparable |           .NET 6.0 |           .NET 6.0 |      9 | 50000000 | 425.0 ms | 1.77 ms | 1.48 ms |     - |     - |     - |     144 B |
| BoseNelson_Comparable |      .NET Core 3.1 |      .NET Core 3.1 |      9 | 50000000 | 318.1 ms | 1.09 ms | 1.02 ms |     - |     - |     - |   1,384 B |
| BoseNelson_Branchless |      .NET Core 3.1 |      .NET Core 3.1 |      9 | 50000000 | 142.1 ms | 0.94 ms | 0.88 ms |     - |     - |     - |         - |
|  BestKnown_Comparable |      .NET Core 3.1 |      .NET Core 3.1 |      9 | 50000000 | 318.3 ms | 0.66 ms | 0.62 ms |     - |     - |     - |     616 B |
|  BestKnown_Branchless |      .NET Core 3.1 |      .NET Core 3.1 |      9 | 50000000 | 116.0 ms | 0.60 ms | 0.53 ms |     - |     - |     - |         - |
|  Insertion_Comparable |      .NET Core 3.1 |      .NET Core 3.1 |      9 | 50000000 | 409.3 ms | 2.39 ms | 2.12 ms |     - |     - |     - |     616 B |
| BoseNelson_Comparable | .NET Framework 4.8 | .NET Framework 4.8 |      9 | 50000000 | 333.3 ms | 2.14 ms | 2.00 ms |     - |     - |     - |         - |
| BoseNelson_Branchless | .NET Framework 4.8 | .NET Framework 4.8 |      9 | 50000000 | 142.1 ms | 0.93 ms | 0.87 ms |     - |     - |     - |         - |
|  BestKnown_Comparable | .NET Framework 4.8 | .NET Framework 4.8 |      9 | 50000000 | 328.0 ms | 1.56 ms | 1.46 ms |     - |     - |     - |         - |
|  BestKnown_Branchless | .NET Framework 4.8 | .NET Framework 4.8 |      9 | 50000000 | 117.3 ms | 0.98 ms | 0.92 ms |     - |     - |     - |         - |
|  Insertion_Comparable | .NET Framework 4.8 | .NET Framework 4.8 |      9 | 50000000 | 510.8 ms | 1.72 ms | 1.53 ms |     - |     - |     - |         - |
| BoseNelson_Comparable |         CoreRT 6.0 |         CoreRT 6.0 |      9 | 50000000 |       NA |      NA |      NA |     - |     - |     - |         - |
| BoseNelson_Branchless |         CoreRT 6.0 |         CoreRT 6.0 |      9 | 50000000 |       NA |      NA |      NA |     - |     - |     - |         - |
|  BestKnown_Comparable |         CoreRT 6.0 |         CoreRT 6.0 |      9 | 50000000 |       NA |      NA |      NA |     - |     - |     - |         - |
|  BestKnown_Branchless |         CoreRT 6.0 |         CoreRT 6.0 |      9 | 50000000 |       NA |      NA |      NA |     - |     - |     - |         - |
|  Insertion_Comparable |         CoreRT 6.0 |         CoreRT 6.0 |      9 | 50000000 |       NA |      NA |      NA |     - |     - |     - |         - |

Benchmarks with issues:
  SN09Benchmark.BoseNelson_Comparable: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=9, Count=50000000]
  SN09Benchmark.BoseNelson_Branchless: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=9, Count=50000000]
  SN09Benchmark.BestKnown_Comparable: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=9, Count=50000000]
  SN09Benchmark.BestKnown_Branchless: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=9, Count=50000000]
  SN09Benchmark.Insertion_Comparable: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=9, Count=50000000]
