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
| BoseNelson_Comparable |           .NET 5.0 |           .NET 5.0 |     14 | 22000000 | 175.4 ms | 0.39 ms | 0.35 ms |     - |     - |     - |         - |
| BoseNelson_Branchless |           .NET 5.0 |           .NET 5.0 |     14 | 22000000 | 195.0 ms | 0.11 ms | 0.08 ms |     - |     - |     - |         - |
|  BestKnown_Comparable |           .NET 5.0 |           .NET 5.0 |     14 | 22000000 | 185.3 ms | 0.31 ms | 0.27 ms |     - |     - |     - |         - |
|  BestKnown_Branchless |           .NET 5.0 |           .NET 5.0 |     14 | 22000000 | 129.4 ms | 0.93 ms | 0.87 ms |     - |     - |     - |         - |
|  Insertion_Comparable |           .NET 5.0 |           .NET 5.0 |     14 | 22000000 | 221.1 ms | 3.94 ms | 3.29 ms |     - |     - |     - |      72 B |
| BoseNelson_Comparable |           .NET 6.0 |           .NET 6.0 |     14 | 22000000 | 171.7 ms | 0.25 ms | 0.22 ms |     - |     - |     - |     144 B |
| BoseNelson_Branchless |           .NET 6.0 |           .NET 6.0 |     14 | 22000000 | 195.3 ms | 0.07 ms | 0.06 ms |     - |     - |     - |     144 B |
|  BestKnown_Comparable |           .NET 6.0 |           .NET 6.0 |     14 | 22000000 | 188.2 ms | 0.29 ms | 0.26 ms |     - |     - |     - |     144 B |
|  BestKnown_Branchless |           .NET 6.0 |           .NET 6.0 |     14 | 22000000 | 128.3 ms | 0.12 ms | 0.10 ms |     - |     - |     - |     144 B |
|  Insertion_Comparable |           .NET 6.0 |           .NET 6.0 |     14 | 22000000 | 223.2 ms | 1.51 ms | 1.26 ms |     - |     - |     - |     192 B |
| BoseNelson_Comparable |      .NET Core 3.1 |      .NET Core 3.1 |     14 | 22000000 | 171.5 ms | 0.59 ms | 0.53 ms |     - |     - |     - |         - |
| BoseNelson_Branchless |      .NET Core 3.1 |      .NET Core 3.1 |     14 | 22000000 | 203.4 ms | 0.39 ms | 0.35 ms |     - |     - |     - |         - |
|  BestKnown_Comparable |      .NET Core 3.1 |      .NET Core 3.1 |     14 | 22000000 | 187.0 ms | 1.60 ms | 1.49 ms |     - |     - |     - |         - |
|  BestKnown_Branchless |      .NET Core 3.1 |      .NET Core 3.1 |     14 | 22000000 | 122.7 ms | 0.22 ms | 0.21 ms |     - |     - |     - |         - |
|  Insertion_Comparable |      .NET Core 3.1 |      .NET Core 3.1 |     14 | 22000000 | 218.1 ms | 2.20 ms | 1.95 ms |     - |     - |     - |      48 B |
| BoseNelson_Comparable | .NET Framework 4.8 | .NET Framework 4.8 |     14 | 22000000 | 180.7 ms | 1.70 ms | 1.51 ms |     - |     - |     - |         - |
| BoseNelson_Branchless | .NET Framework 4.8 | .NET Framework 4.8 |     14 | 22000000 | 198.3 ms | 1.24 ms | 1.16 ms |     - |     - |     - |         - |
|  BestKnown_Comparable | .NET Framework 4.8 | .NET Framework 4.8 |     14 | 22000000 | 195.9 ms | 2.48 ms | 2.32 ms |     - |     - |     - |         - |
|  BestKnown_Branchless | .NET Framework 4.8 | .NET Framework 4.8 |     14 | 22000000 | 121.7 ms | 0.26 ms | 0.22 ms |     - |     - |     - |         - |
|  Insertion_Comparable | .NET Framework 4.8 | .NET Framework 4.8 |     14 | 22000000 | 279.1 ms | 0.18 ms | 0.15 ms |     - |     - |     - |         - |
| BoseNelson_Comparable |         CoreRT 6.0 |         CoreRT 6.0 |     14 | 22000000 |       NA |      NA |      NA |     - |     - |     - |         - |
| BoseNelson_Branchless |         CoreRT 6.0 |         CoreRT 6.0 |     14 | 22000000 |       NA |      NA |      NA |     - |     - |     - |         - |
|  BestKnown_Comparable |         CoreRT 6.0 |         CoreRT 6.0 |     14 | 22000000 |       NA |      NA |      NA |     - |     - |     - |         - |
|  BestKnown_Branchless |         CoreRT 6.0 |         CoreRT 6.0 |     14 | 22000000 |       NA |      NA |      NA |     - |     - |     - |         - |
|  Insertion_Comparable |         CoreRT 6.0 |         CoreRT 6.0 |     14 | 22000000 |       NA |      NA |      NA |     - |     - |     - |         - |

Benchmarks with issues:
  SN14Benchmark.BoseNelson_Comparable: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=14, Count=22000000]
  SN14Benchmark.BoseNelson_Branchless: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=14, Count=22000000]
  SN14Benchmark.BestKnown_Comparable: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=14, Count=22000000]
  SN14Benchmark.BestKnown_Branchless: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=14, Count=22000000]
  SN14Benchmark.Insertion_Comparable: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=14, Count=22000000]
