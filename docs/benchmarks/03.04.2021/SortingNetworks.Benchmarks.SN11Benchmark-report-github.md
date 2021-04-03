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
| BoseNelson_Comparable |           .NET 5.0 |           .NET 5.0 |     11 | 43000000 | 294.6 ms | 0.50 ms | 0.41 ms |     - |     - |     - |      48 B |
| BoseNelson_Branchless |           .NET 5.0 |           .NET 5.0 |     11 | 43000000 | 145.4 ms | 0.08 ms | 0.07 ms |     - |     - |     - |         - |
|  BestKnown_Comparable |           .NET 5.0 |           .NET 5.0 |     11 | 43000000 | 307.0 ms | 0.50 ms | 0.47 ms |     - |     - |     - |      48 B |
|  BestKnown_Branchless |           .NET 5.0 |           .NET 5.0 |     11 | 43000000 | 109.9 ms | 0.34 ms | 0.32 ms |     - |     - |     - |         - |
|  Insertion_Comparable |           .NET 5.0 |           .NET 5.0 |     11 | 43000000 | 372.2 ms | 7.01 ms | 7.19 ms |     - |     - |     - |         - |
| BoseNelson_Comparable |           .NET 6.0 |           .NET 6.0 |     11 | 43000000 | 297.6 ms | 0.95 ms | 0.89 ms |     - |     - |     - |     192 B |
| BoseNelson_Branchless |           .NET 6.0 |           .NET 6.0 |     11 | 43000000 | 146.7 ms | 0.79 ms | 0.74 ms |     - |     - |     - |     144 B |
|  BestKnown_Comparable |           .NET 6.0 |           .NET 6.0 |     11 | 43000000 | 304.3 ms | 0.32 ms | 0.28 ms |     - |     - |     - |     224 B |
|  BestKnown_Branchless |           .NET 6.0 |           .NET 6.0 |     11 | 43000000 | 110.0 ms | 0.30 ms | 0.28 ms |     - |     - |     - |     144 B |
|  Insertion_Comparable |           .NET 6.0 |           .NET 6.0 |     11 | 43000000 | 395.6 ms | 2.77 ms | 2.59 ms |     - |     - |     - |     192 B |
| BoseNelson_Comparable |      .NET Core 3.1 |      .NET Core 3.1 |     11 | 43000000 | 297.3 ms | 0.73 ms | 0.68 ms |     - |     - |     - |         - |
| BoseNelson_Branchless |      .NET Core 3.1 |      .NET Core 3.1 |     11 | 43000000 | 145.4 ms | 0.15 ms | 0.12 ms |     - |     - |     - |         - |
|  BestKnown_Comparable |      .NET Core 3.1 |      .NET Core 3.1 |     11 | 43000000 | 305.3 ms | 1.10 ms | 0.98 ms |     - |     - |     - |   1,336 B |
|  BestKnown_Branchless |      .NET Core 3.1 |      .NET Core 3.1 |     11 | 43000000 | 110.5 ms | 0.28 ms | 0.25 ms |     - |     - |     - |         - |
|  Insertion_Comparable |      .NET Core 3.1 |      .NET Core 3.1 |     11 | 43000000 | 381.9 ms | 2.66 ms | 2.35 ms |     - |     - |     - |      48 B |
| BoseNelson_Comparable | .NET Framework 4.8 | .NET Framework 4.8 |     11 | 43000000 | 312.4 ms | 5.91 ms | 5.81 ms |     - |     - |     - |         - |
| BoseNelson_Branchless | .NET Framework 4.8 | .NET Framework 4.8 |     11 | 43000000 | 145.5 ms | 0.09 ms | 0.07 ms |     - |     - |     - |         - |
|  BestKnown_Comparable | .NET Framework 4.8 | .NET Framework 4.8 |     11 | 43000000 | 313.7 ms | 2.16 ms | 1.92 ms |     - |     - |     - |         - |
|  BestKnown_Branchless | .NET Framework 4.8 | .NET Framework 4.8 |     11 | 43000000 | 109.9 ms | 0.19 ms | 0.17 ms |     - |     - |     - |         - |
|  Insertion_Comparable | .NET Framework 4.8 | .NET Framework 4.8 |     11 | 43000000 | 484.3 ms | 3.42 ms | 3.20 ms |     - |     - |     - |         - |
| BoseNelson_Comparable |         CoreRT 6.0 |         CoreRT 6.0 |     11 | 43000000 |       NA |      NA |      NA |     - |     - |     - |         - |
| BoseNelson_Branchless |         CoreRT 6.0 |         CoreRT 6.0 |     11 | 43000000 |       NA |      NA |      NA |     - |     - |     - |         - |
|  BestKnown_Comparable |         CoreRT 6.0 |         CoreRT 6.0 |     11 | 43000000 |       NA |      NA |      NA |     - |     - |     - |         - |
|  BestKnown_Branchless |         CoreRT 6.0 |         CoreRT 6.0 |     11 | 43000000 |       NA |      NA |      NA |     - |     - |     - |         - |
|  Insertion_Comparable |         CoreRT 6.0 |         CoreRT 6.0 |     11 | 43000000 |       NA |      NA |      NA |     - |     - |     - |         - |

Benchmarks with issues:
  SN11Benchmark.BoseNelson_Comparable: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=11, Count=43000000]
  SN11Benchmark.BoseNelson_Branchless: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=11, Count=43000000]
  SN11Benchmark.BestKnown_Comparable: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=11, Count=43000000]
  SN11Benchmark.BestKnown_Branchless: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=11, Count=43000000]
  SN11Benchmark.Insertion_Comparable: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=11, Count=43000000]
