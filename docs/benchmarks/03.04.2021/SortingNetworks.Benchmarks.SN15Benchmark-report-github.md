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
| BoseNelson_Comparable |           .NET 5.0 |           .NET 5.0 |     15 | 21000000 | 172.2 ms | 0.32 ms | 0.30 ms |     - |     - |     - |         - |
| BoseNelson_Branchless |           .NET 5.0 |           .NET 5.0 |     15 | 21000000 | 200.5 ms | 1.15 ms | 1.08 ms |     - |     - |     - |         - |
|  BestKnown_Comparable |           .NET 5.0 |           .NET 5.0 |     15 | 21000000 | 190.3 ms | 0.34 ms | 0.30 ms |     - |     - |     - |         - |
|  BestKnown_Branchless |           .NET 5.0 |           .NET 5.0 |     15 | 21000000 | 151.1 ms | 0.09 ms | 0.07 ms |     - |     - |     - |         - |
|  Insertion_Comparable |           .NET 5.0 |           .NET 5.0 |     15 | 21000000 | 202.6 ms | 2.93 ms | 2.45 ms |     - |     - |     - |         - |
| BoseNelson_Comparable |           .NET 6.0 |           .NET 6.0 |     15 | 21000000 | 172.3 ms | 0.50 ms | 0.45 ms |     - |     - |     - |     144 B |
| BoseNelson_Branchless |           .NET 6.0 |           .NET 6.0 |     15 | 21000000 | 197.8 ms | 0.19 ms | 0.17 ms |     - |     - |     - |     144 B |
|  BestKnown_Comparable |           .NET 6.0 |           .NET 6.0 |     15 | 21000000 | 190.9 ms | 0.45 ms | 0.42 ms |     - |     - |     - |     144 B |
|  BestKnown_Branchless |           .NET 6.0 |           .NET 6.0 |     15 | 21000000 | 151.2 ms | 0.25 ms | 0.22 ms |     - |     - |     - |     144 B |
|  Insertion_Comparable |           .NET 6.0 |           .NET 6.0 |     15 | 21000000 | 216.9 ms | 2.43 ms | 2.28 ms |     - |     - |     - |     192 B |
| BoseNelson_Comparable |      .NET Core 3.1 |      .NET Core 3.1 |     15 | 21000000 | 173.4 ms | 1.54 ms | 1.44 ms |     - |     - |     - |         - |
| BoseNelson_Branchless |      .NET Core 3.1 |      .NET Core 3.1 |     15 | 21000000 | 197.7 ms | 0.06 ms | 0.05 ms |     - |     - |     - |         - |
|  BestKnown_Comparable |      .NET Core 3.1 |      .NET Core 3.1 |     15 | 21000000 | 190.7 ms | 0.40 ms | 0.33 ms |     - |     - |     - |         - |
|  BestKnown_Branchless |      .NET Core 3.1 |      .NET Core 3.1 |     15 | 21000000 | 151.6 ms | 0.64 ms | 0.60 ms |     - |     - |     - |         - |
|  Insertion_Comparable |      .NET Core 3.1 |      .NET Core 3.1 |     15 | 21000000 | 211.4 ms | 1.03 ms | 0.96 ms |     - |     - |     - |      48 B |
| BoseNelson_Comparable | .NET Framework 4.8 | .NET Framework 4.8 |     15 | 21000000 | 178.4 ms | 1.02 ms | 0.95 ms |     - |     - |     - |         - |
| BoseNelson_Branchless | .NET Framework 4.8 | .NET Framework 4.8 |     15 | 21000000 | 198.0 ms | 0.18 ms | 0.15 ms |     - |     - |     - |         - |
|  BestKnown_Comparable | .NET Framework 4.8 | .NET Framework 4.8 |     15 | 21000000 | 192.3 ms | 1.06 ms | 0.99 ms |     - |     - |     - |         - |
|  BestKnown_Branchless | .NET Framework 4.8 | .NET Framework 4.8 |     15 | 21000000 | 142.2 ms | 0.34 ms | 0.31 ms |     - |     - |     - |         - |
|  Insertion_Comparable | .NET Framework 4.8 | .NET Framework 4.8 |     15 | 21000000 | 278.5 ms | 1.98 ms | 1.85 ms |     - |     - |     - |         - |
| BoseNelson_Comparable |         CoreRT 6.0 |         CoreRT 6.0 |     15 | 21000000 |       NA |      NA |      NA |     - |     - |     - |         - |
| BoseNelson_Branchless |         CoreRT 6.0 |         CoreRT 6.0 |     15 | 21000000 |       NA |      NA |      NA |     - |     - |     - |         - |
|  BestKnown_Comparable |         CoreRT 6.0 |         CoreRT 6.0 |     15 | 21000000 |       NA |      NA |      NA |     - |     - |     - |         - |
|  BestKnown_Branchless |         CoreRT 6.0 |         CoreRT 6.0 |     15 | 21000000 |       NA |      NA |      NA |     - |     - |     - |         - |
|  Insertion_Comparable |         CoreRT 6.0 |         CoreRT 6.0 |     15 | 21000000 |       NA |      NA |      NA |     - |     - |     - |         - |

Benchmarks with issues:
  SN15Benchmark.BoseNelson_Comparable: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=15, Count=21000000]
  SN15Benchmark.BoseNelson_Branchless: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=15, Count=21000000]
  SN15Benchmark.BestKnown_Comparable: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=15, Count=21000000]
  SN15Benchmark.BestKnown_Branchless: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=15, Count=21000000]
  SN15Benchmark.Insertion_Comparable: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=15, Count=21000000]
