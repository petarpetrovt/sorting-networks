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
| BoseNelson_Comparable |           .NET 5.0 |           .NET 5.0 |     16 | 21000000 | 184.2 ms | 0.23 ms | 0.19 ms |     - |     - |     - |         - |
| BoseNelson_Branchless |           .NET 5.0 |           .NET 5.0 |     16 | 21000000 | 185.9 ms | 0.36 ms | 0.32 ms |     - |     - |     - |         - |
|  BestKnown_Comparable |           .NET 5.0 |           .NET 5.0 |     16 | 21000000 | 200.0 ms | 0.42 ms | 0.37 ms |     - |     - |     - |         - |
|  BestKnown_Branchless |           .NET 5.0 |           .NET 5.0 |     16 | 21000000 | 146.7 ms | 0.27 ms | 0.24 ms |     - |     - |     - |         - |
|  Insertion_Comparable |           .NET 5.0 |           .NET 5.0 |     16 | 21000000 | 207.2 ms | 2.18 ms | 1.82 ms |     - |     - |     - |         - |
| BoseNelson_Comparable |           .NET 6.0 |           .NET 6.0 |     16 | 21000000 | 187.4 ms | 0.45 ms | 0.42 ms |     - |     - |     - |     144 B |
| BoseNelson_Branchless |           .NET 6.0 |           .NET 6.0 |     16 | 21000000 | 185.8 ms | 0.12 ms | 0.09 ms |     - |     - |     - |     144 B |
|  BestKnown_Comparable |           .NET 6.0 |           .NET 6.0 |     16 | 21000000 | 201.5 ms | 1.79 ms | 1.67 ms |     - |     - |     - |     144 B |
|  BestKnown_Branchless |           .NET 6.0 |           .NET 6.0 |     16 | 21000000 | 147.3 ms | 0.71 ms | 0.67 ms |     - |     - |     - |     144 B |
|  Insertion_Comparable |           .NET 6.0 |           .NET 6.0 |     16 | 21000000 | 226.2 ms | 1.63 ms | 1.52 ms |     - |     - |     - |     192 B |
| BoseNelson_Comparable |      .NET Core 3.1 |      .NET Core 3.1 |     16 | 21000000 | 185.0 ms | 0.60 ms | 0.50 ms |     - |     - |     - |         - |
| BoseNelson_Branchless |      .NET Core 3.1 |      .NET Core 3.1 |     16 | 21000000 | 186.4 ms | 0.54 ms | 0.51 ms |     - |     - |     - |         - |
|  BestKnown_Comparable |      .NET Core 3.1 |      .NET Core 3.1 |     16 | 21000000 | 201.4 ms | 0.37 ms | 0.33 ms |     - |     - |     - |         - |
|  BestKnown_Branchless |      .NET Core 3.1 |      .NET Core 3.1 |     16 | 21000000 | 146.7 ms | 0.26 ms | 0.23 ms |     - |     - |     - |         - |
|  Insertion_Comparable |      .NET Core 3.1 |      .NET Core 3.1 |     16 | 21000000 | 217.0 ms | 0.87 ms | 0.81 ms |     - |     - |     - |      48 B |
| BoseNelson_Comparable | .NET Framework 4.8 | .NET Framework 4.8 |     16 | 21000000 | 191.2 ms | 2.10 ms | 1.96 ms |     - |     - |     - |         - |
| BoseNelson_Branchless | .NET Framework 4.8 | .NET Framework 4.8 |     16 | 21000000 | 187.0 ms | 1.55 ms | 1.45 ms |     - |     - |     - |         - |
|  BestKnown_Comparable | .NET Framework 4.8 | .NET Framework 4.8 |     16 | 21000000 | 203.2 ms | 0.77 ms | 0.68 ms |     - |     - |     - |         - |
|  BestKnown_Branchless | .NET Framework 4.8 | .NET Framework 4.8 |     16 | 21000000 | 146.7 ms | 0.22 ms | 0.18 ms |     - |     - |     - |         - |
|  Insertion_Comparable | .NET Framework 4.8 | .NET Framework 4.8 |     16 | 21000000 | 284.9 ms | 0.45 ms | 0.38 ms |     - |     - |     - |         - |
| BoseNelson_Comparable |         CoreRT 6.0 |         CoreRT 6.0 |     16 | 21000000 |       NA |      NA |      NA |     - |     - |     - |         - |
| BoseNelson_Branchless |         CoreRT 6.0 |         CoreRT 6.0 |     16 | 21000000 |       NA |      NA |      NA |     - |     - |     - |         - |
|  BestKnown_Comparable |         CoreRT 6.0 |         CoreRT 6.0 |     16 | 21000000 |       NA |      NA |      NA |     - |     - |     - |         - |
|  BestKnown_Branchless |         CoreRT 6.0 |         CoreRT 6.0 |     16 | 21000000 |       NA |      NA |      NA |     - |     - |     - |         - |
|  Insertion_Comparable |         CoreRT 6.0 |         CoreRT 6.0 |     16 | 21000000 |       NA |      NA |      NA |     - |     - |     - |         - |

Benchmarks with issues:
  SN16Benchmark.BoseNelson_Comparable: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=16, Count=21000000]
  SN16Benchmark.BoseNelson_Branchless: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=16, Count=21000000]
  SN16Benchmark.BestKnown_Comparable: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=16, Count=21000000]
  SN16Benchmark.BestKnown_Branchless: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=16, Count=21000000]
  SN16Benchmark.Insertion_Comparable: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=16, Count=21000000]
