``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19044.1706 (21H2)
AMD Ryzen 7 3700X, 1 CPU, 16 logical and 8 physical cores
.NET SDK=6.0.105
  [Host]   : .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
  .NET 5.0 : .NET 5.0.17 (5.0.1722.21314), X64 RyuJIT
  .NET 6.0 : .NET 6.0.5 (6.0.522.21309), X64 RyuJIT

InvocationCount=1  UnrollFactor=1  

```
|                Method |        Job |    Runtime | Length |    Count |     Mean |   Error |  StdDev | Ratio | RatioSD | Allocated |
|---------------------- |----------- |----------- |------- |--------- |---------:|--------:|--------:|------:|--------:|----------:|
| BoseNelson_Comparable |   .NET 5.0 |   .NET 5.0 |     12 | 36000000 | 269.6 ms | 0.74 ms | 0.70 ms |  1.00 |    0.00 |         - |
| BoseNelson_Comparable |   .NET 6.0 |   .NET 6.0 |     12 | 36000000 | 271.8 ms | 0.48 ms | 0.45 ms |  1.01 |    0.00 |     480 B |
| BoseNelson_Comparable | CoreRT 6.0 | CoreRT 6.0 |     12 | 36000000 |       NA |      NA |      NA |     ? |       ? |         - |
|                       |            |            |        |          |          |         |         |       |         |           |
| BoseNelson_Branchless |   .NET 5.0 |   .NET 5.0 |     12 | 36000000 | 144.9 ms | 0.11 ms | 0.09 ms |  1.00 |    0.00 |         - |
| BoseNelson_Branchless |   .NET 6.0 |   .NET 6.0 |     12 | 36000000 | 145.9 ms | 0.12 ms | 0.11 ms |  1.01 |    0.00 |     480 B |
| BoseNelson_Branchless | CoreRT 6.0 | CoreRT 6.0 |     12 | 36000000 |       NA |      NA |      NA |     ? |       ? |         - |
|                       |            |            |        |          |          |         |         |       |         |           |
|  BestKnown_Comparable |   .NET 5.0 |   .NET 5.0 |     12 | 36000000 | 273.9 ms | 1.07 ms | 1.00 ms |  1.00 |    0.00 |      48 B |
|  BestKnown_Comparable |   .NET 6.0 |   .NET 6.0 |     12 | 36000000 | 277.8 ms | 0.25 ms | 0.23 ms |  1.01 |    0.00 |     480 B |
|  BestKnown_Comparable | CoreRT 6.0 | CoreRT 6.0 |     12 | 36000000 |       NA |      NA |      NA |     ? |       ? |         - |
|                       |            |            |        |          |          |         |         |       |         |           |
|  BestKnown_Branchless |   .NET 5.0 |   .NET 5.0 |     12 | 36000000 | 107.4 ms | 0.32 ms | 0.30 ms |  1.00 |    0.00 |         - |
|  BestKnown_Branchless |   .NET 6.0 |   .NET 6.0 |     12 | 36000000 | 107.1 ms | 0.26 ms | 0.25 ms |  1.00 |    0.00 |     480 B |
|  BestKnown_Branchless | CoreRT 6.0 | CoreRT 6.0 |     12 | 36000000 |       NA |      NA |      NA |     ? |       ? |         - |
|                       |            |            |        |          |          |         |         |       |         |           |
|  Insertion_Comparable |   .NET 5.0 |   .NET 5.0 |     12 | 36000000 | 329.5 ms | 3.55 ms | 3.32 ms |  1.00 |    0.00 |         - |
|  Insertion_Comparable |   .NET 6.0 |   .NET 6.0 |     12 | 36000000 | 340.2 ms | 6.00 ms | 5.61 ms |  1.03 |    0.02 |     520 B |
|  Insertion_Comparable | CoreRT 6.0 | CoreRT 6.0 |     12 | 36000000 |       NA |      NA |      NA |     ? |       ? |         - |

Benchmarks with issues:
  SN12Benchmark.BoseNelson_Comparable: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=12, Count=36000000]
  SN12Benchmark.BoseNelson_Branchless: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=12, Count=36000000]
  SN12Benchmark.BestKnown_Comparable: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=12, Count=36000000]
  SN12Benchmark.BestKnown_Branchless: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=12, Count=36000000]
  SN12Benchmark.Insertion_Comparable: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=12, Count=36000000]
